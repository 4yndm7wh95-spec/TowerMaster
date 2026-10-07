using System.Collections;
using HarmonyLib;
using TowerMaster.Core;

namespace TowerMaster;

/// <summary>
/// 塔主牌第二阶段：战斗中用原版手牌出牌（方案 A：塔主在战斗里仍是「死亡」状态，不被怪物打、判负只看爬塔玩家，
/// 只放开他抽牌、拿能量、出牌）。全部在各端同步执行的塔主回合指令里做，结果一致：
///
/// - begin（玩家回合开始、各端都进了出牌阶段）：暂停所有玩家队列后，只把塔主的队列放开（ActionQueueSet 私有 GetQueue 的 isPaused 等标志）；
///   撤销塔主「已准备结束回合」（死亡玩家每回合会被自动设为已准备）；第 1 回合把陷阱牌移出战斗牌堆；
///   设能量（每回合 1/1/2，第 1 回合 +1，精英/Boss +1）、抽 4 张（原版 SetupPlayerTurn 会跳过死者，所以我们自己发）。
/// - 塔主在自己屏幕上用原版手牌拖牌：原版 PlayCardAction 各端执行 OnPlay（<see cref="MasterCards"/>）。
/// - end（塔主按结束）：弃掉塔主手牌、重新设为已准备结束回合、恢复所有玩家队列。
///
/// 出牌限制（同一名玩家每回合 1 次减益、每只怪治疗 2 次、力量上限、战吼每场 1 次、晕眩每场 3 次）在各端用同样的记录判断：
/// CardModel.CanPlay / IsValidTarget 的后置补丁。塔主牌只在塔主回合里能打。
/// </summary>
internal static class MasterHand
{
    private static readonly Dictionary<object, int> Heals = new(ReferenceEqualityComparer.Instance);
    private static readonly Dictionary<object, int> Strength = new(ReferenceEqualityComparer.Instance);
    private static readonly Dictionary<object, int> DebuffsThisTurn = new(ReferenceEqualityComparer.Instance);
    private static int _dazed, _strengthAll;
    private static bool _patched;

    /// <summary>塔主回合进行中（各端在 begin/end 指令里同步切换）。</summary>
    internal static bool Active { get; private set; }

    internal static void Apply(Harmony harmony)
    {
        if (_patched) return;
        _patched = true;
        var card = GameReflection.TypesNamed("CardModel").First(t => t.IsAbstract);
        var canPlay = card.GetMethods(GameReflection.All).FirstOrDefault(m => m.Name == "CanPlay" && m.GetParameters().Length == 2);
        var valid = card.GetMethods(GameReflection.All).FirstOrDefault(m => m.Name == "IsValidTarget" && m.GetParameters().Length == 1);
        if (canPlay != null) harmony.Patch(canPlay, postfix: new HarmonyMethod(typeof(MasterHand).GetMethod(nameof(AfterCanPlay), GameReflection.All)!));
        else Log.Warn("塔主手牌：找不到 CardModel.CanPlay，出牌限制不生效");
        if (valid != null) harmony.Patch(valid, postfix: new HarmonyMethod(typeof(MasterHand).GetMethod(nameof(AfterIsValidTarget), GameReflection.All)!));
        else Log.Warn("塔主手牌：找不到 CardModel.IsValidTarget，按目标的限制不生效");
        // 塔主按原版「结束回合」= 结束塔主先手（0.0.31 实测原版结束回合对塔主不起作用）
        var endTurn = GameReflection.TypesNamed("EndPlayerTurnAction").SelectMany(t => t.GetMethods(GameReflection.All))
            .FirstOrDefault(m => m.Name == "ExecuteAction" && m.DeclaringType?.Name == "EndPlayerTurnAction");
        if (endTurn != null) harmony.Patch(endTurn, prefix: new HarmonyMethod(typeof(MasterHand).GetMethod(nameof(BeforeEndPlayerTurn), GameReflection.All)!));
        else Log.Warn("塔主手牌：找不到 EndPlayerTurnAction.ExecuteAction，塔主只能用面板上的结束按钮");
    }

    /// <summary>战斗开始（各端）：清记录。</summary>
    internal static void CombatStarted()
    {
        Heals.Clear();
        Strength.Clear();
        DebuffsThisTurn.Clear();
        _dazed = _strengthAll = 0;
        Active = false;
    }

    // ---------------------------------------------------------------- 塔主回合开始 / 结束（各端，在同步指令里）

    internal static async Task Begin(object action, int round, string tag)
    {
        DebuffsThisTurn.Clear();
        var master = MasterPlayer();
        if (master == null) { Log.Warn($"{tag}：找不到塔主，不发牌"); return; }
        Active = true;
        // 0.0.31 实测：塔主死着时原版不给他建手牌节点（抽牌跳过死者），出牌也在 OnPlayWrapper 里遇到死亡牌主直接返回、不执行效果。
        // 塔主回合里爬塔玩家暂停、怪物不行动，所以这段时间让塔主「活着」（生命直接写 1，不走复活流程），结束时再写回 0。
        if (GameReflection.Get(master, "Creature") is { } creature) Test2MasterOffField.SetHp(creature, 1);
        OpenMasterQueue();
        try { RuntimeNetAction.Call(CombatManager()!, "UndoReadyToEndTurn", master); }
        catch (Exception e) { Log.Warn($"{tag}：撤销塔主的「已准备结束回合」失败：{e.Message}"); }
        var context = Context(action);
        var pcs = GameReflection.Get(master, "PlayerCombatState") ?? throw new InvalidOperationException("塔主没有战斗状态（PlayerCombatState）");
        if (round == 1) RemoveTraps(pcs);
        await DiscardHand(context, master, pcs);
        int energy = Energy(round);
        await (Task)Static("PlayerCmd", "SetEnergy", m => m.GetParameters().Length == 2).Invoke(null, [(decimal)energy, master])!;
        int before = Count(pcs, "Hand");
        int draw = ModEntry.Active.MasterHandDraw;
        await (Task)Static("CardPileCmd", "Draw", m => m.GetParameters().Length == 4 && m.GetParameters()[1].ParameterType == typeof(decimal))
            .Invoke(null, [context, (decimal)draw, master, false])!;
        if (Count(pcs, "Hand") == before) ManualDraw(pcs, draw); // 原版抽牌可能也跳过死者
        Log.Info($"{tag}：塔主能量 {GameReflection.Get(pcs, "Energy")}，手牌 {Count(pcs, "Hand")} 张（抽牌堆 {Count(pcs, "DrawPile")}，弃牌堆 {Count(pcs, "DiscardPile")}）");
        if (Test3MasterAutoPilot.LocalIsMaster) ShowHand(tag);
    }

    /// <summary>显示塔主手牌界面；测试里换成空操作（没有 Godot 引擎）。</summary>
    internal static Action<string> ShowHand = ShowHandUi;

    /// <summary>塔主自己的屏幕：原版对死亡的本机玩家可能隐藏手牌界面，找到 NPlayerHand 记下状态并显示出来。</summary>
    private static void ShowHandUi(string tag)
    {
        try
        {
            if (Godot.Engine.GetMainLoop() is not Godot.SceneTree tree) return;
            var stack = new Stack<Godot.Node>();
            stack.Push(tree.Root);
            while (stack.Count > 0)
            {
                var node = stack.Pop();
                if (node.GetType().Name == "NPlayerHand" && node is Godot.CanvasItem item)
                {
                    Log.Info($"{tag}：原版手牌界面 {node.GetPath()} visible={item.Visible} modulate={item.Modulate}");
                    item.Visible = true;
                    item.Modulate = Godot.Colors.White;
                    return;
                }
                foreach (var child in node.GetChildren()) stack.Push(child);
            }
            Log.Warn($"{tag}：没找到原版手牌界面 NPlayerHand");
        }
        catch (Exception e) { Log.Warn($"{tag}：显示手牌界面失败：{e.Message}"); }
    }

    internal static async Task End(object action, string tag)
    {
        Active = false;
        var master = MasterPlayer();
        if (master == null) return;
        if (GameReflection.Get(master, "PlayerCombatState") is { } pcs) await DiscardHand(Context(action), master, pcs);
        if (GameReflection.Get(master, "Creature") is { } creature) Test2MasterOffField.SetHp(creature, 0); // 回到「死亡」：不被打、不算判负
        try { RuntimeNetAction.Call(CombatManager()!, "SetReadyToEndTurn", master, false, null); }
        catch (Exception e) { Log.Warn($"{tag}：把塔主设回「已准备结束回合」失败：{e.Message}"); }
    }

    /// <summary>
    /// 原版结束回合动作（各端执行）：塔主回合进行中、动作属于塔主时不走原版（不把塔主标成结束、不触发整轮结束判断），
    /// 房主改为发 end 指令结束塔主先手；之后 end 指令里再把塔主设为「已准备」。
    /// </summary>
    private static bool BeforeEndPlayerTurn(object __instance, ref Task __result)
    {
        try
        {
            if (!MasterCards.Enabled || !Active) return true;
            var owner = Test2MasterOffField.NetIdOf(GameReflection.Get(__instance, "Player"))
                        ?? (GameReflection.Get(__instance, "OwnerId") is { } id ? Convert.ToUInt64(id) : null);
            if (owner == null || owner != Test2MasterOffField.MasterId) return true;
            __result = Task.CompletedTask;
            if (Test3MasterAutoPilot.LocalIsMaster) ThreatPhase.EndTurn("塔主按原版结束回合");
            Log.Info("塔主手牌：原版结束回合 → 结束塔主先手");
            return false;
        }
        catch (Exception e) { Log.Warn($"塔主手牌：处理原版结束回合失败：{e.Message}"); return true; }
    }

    /// <summary>塔主本回合能量：按幕 1/1/2，第 1 回合 +1，精英、Boss 每回合 +1。</summary>
    internal static int Energy(int round)
    {
        var c = ModEntry.Active;
        var state = GameReflection.Get(Test1bMixedEncounter.Run, "State");
        int act = state == null ? 1 : ThreatPhase.ActNoOf(state);
        var room = state == null ? RoomKind.Monster : ThreatPhase.RoomOf(state);
        return TowerMasterConfig.ByAct(c.MasterEnergy, act) + (round == 1 ? c.MasterEnergyFirstTurnBonus : 0)
               + (room != RoomKind.Monster ? c.MasterEnergyRoomBonus : 0);
    }

    // ---------------------------------------------------------------- 出牌限制（各端一致）

    private static void AfterCanPlay(object __instance, object[] __args, ref bool __result)
    {
        var def = MasterCards.DefOf(__instance);
        if (def == null || def.Unplayable) return;
        if (!Active) { __result = false; return; } // 塔主牌只在塔主回合里打
        if (!__result)
        {
            // 塔主「死着」时原版数活着的玩家只有爬塔玩家，单人局会判成「没有活着的队友」；有活着的爬塔玩家就放行
            var reason = __args[0]?.ToString();
            bool affordable = MasterPlayer() is { } m && GameReflection.Get(m, "PlayerCombatState") is { } pcs
                              && Convert.ToInt32(GameReflection.Get(pcs, "Energy") ?? 0) >= def.Cost;
            // Harmony 给后置补丁的 out 参数可能还是调用前的值（测试里实测是 None），所以原因读不准时自己判断能量够不够
            if ((reason == "NoLivingAllies" || reason is null or "None" && def.TargetType == 6) && affordable && LivingClimbers().Any()) __result = true;
            return;
        }
        var p = ModEntry.Active.Threat;
        if (def.Op == "strength_all")
            __result = _strengthAll < p.StrengthAllPerBattle && LivingEnemies().Any(e => Strength.GetValueOrDefault(e) + p.StrengthAllAmount <= Cap(def));
        else if (def.Op == "dazed") __result = _dazed < p.DazedPerBattle;
    }

    private static void AfterIsValidTarget(object __instance, object? __0, ref bool __result)
    {
        if (!__result || __0 == null || MasterCards.DefOf(__instance) is not { } def) return;
        __result = Allowed(def, __0);
    }

    internal static bool Allowed(MasterCardDef def, object target)
    {
        var p = ModEntry.Active.Threat;
        return def.Op switch
        {
            "heal" => Heals.GetValueOrDefault(target) < p.HealPerMonsterPerBattle,
            "strength" => Strength.GetValueOrDefault(target) + TowerMasterConfig.ByAct(p.StrengthAmount, def.Tier) <= Cap(def),
            "weak" or "vulnerable" or "frail" => DebuffsThisTurn.GetValueOrDefault(target) < p.DebuffPerPlayerPerTurn,
            _ => true,
        };
    }

    private static int Cap(MasterCardDef def) => TowerMasterConfig.ByAct(ModEntry.Active.Threat.StrengthCap, def.Tier);

    /// <summary>打出后记下（各端在 OnPlay 里调）。</summary>
    internal static void Record(MasterCardDef def, object? target, int amount)
    {
        switch (def.Op)
        {
            case "heal" when target != null: Heals[target] = Heals.GetValueOrDefault(target) + 1; break;
            case "strength" when target != null: RecordStrength(target, amount, fromCard: true); break;
            case "strength_all": _strengthAll++; break;
            case "weak" or "vulnerable" or "frail" when target != null: DebuffsThisTurn[target] = DebuffsThisTurn.GetValueOrDefault(target) + 1; break;
            case "dazed": _dazed++; break;
        }
    }

    /// <summary>力量记录（塔主牌和陷阱合计；房主的威胁点记账也同步一份，陷阱按它截断）。</summary>
    /// <param name="fromCard">塔主牌给的：房主的威胁点记账也加一份（陷阱给的在房主发指令时已经记过）。</param>
    internal static void RecordStrength(object creature, int amount, bool fromCard = false)
    {
        Strength[creature] = Strength.GetValueOrDefault(creature) + amount;
        if (fromCard && ThreatPhase.Session is { } session) session.AddTrapStrength(ThreatPhase.KeyOf(creature), amount);
    }

    internal static int StrengthOf(object creature) => Strength.GetValueOrDefault(creature);

    // ---------------------------------------------------------------- 工具

    private static object? CombatManager() => RuntimeNetAction.Required("CombatManager").GetProperty("Instance", GameReflection.All)?.GetValue(null);

    internal static object? MasterPlayer()
    {
        var state = GameReflection.Get(Test1bMixedEncounter.Run, "State");
        var id = Test2MasterOffField.MasterId;
        return state == null || id == null ? null
            : (GameReflection.Get(state, "Players") as IEnumerable)?.Cast<object>().FirstOrDefault(p => Test2MasterOffField.NetIdOf(p) == id);
    }

    private static IEnumerable<object> LivingClimbers()
    {
        var state = GameReflection.Get(Test1bMixedEncounter.Run, "State");
        var id = Test2MasterOffField.MasterId;
        return ((state == null ? null : GameReflection.Get(state, "Players") as IEnumerable)?.Cast<object>() ?? [])
            .Where(p => Test2MasterOffField.NetIdOf(p) != id)
            .Select(p => GameReflection.Get(p, "Creature")).Where(c => c != null && GameReflection.Get(c, "IsDead") is not true).Cast<object>();
    }

    private static IEnumerable<object> LivingEnemies() =>
        ThreatPhase.CombatState() is { } combat
            ? ((GameReflection.Get(combat, "Enemies") as IEnumerable)?.Cast<object>() ?? []).Where(e => GameReflection.Get(e, "IsDead") is not true)
            : [];

    private static object Context(object action) => Activator.CreateInstance(RuntimeNetAction.Required("GameActionPlayerChoiceContext"), action)!;

    /// <summary>只放开塔主的队列（暂停全部之后）：清掉暂停和「取消玩家战斗动作」标志。</summary>
    private static void OpenMasterQueue()
    {
        try
        {
            var set = GameReflection.Get(Test1bMixedEncounter.Run, "ActionQueueSet") ?? throw new InvalidOperationException("没有 ActionQueueSet");
            var getQueue = set.GetType().GetMethods(GameReflection.All).First(m => m.Name == "GetQueue" && m.GetParameters().Length == 1);
            var queue = getQueue.Invoke(set, [Test2MasterOffField.MasterId!.Value]) ?? throw new InvalidOperationException("没有塔主的队列");
            foreach (var flag in new[] { "isPaused", "isCancellingPlayerDrivenCombatActions", "isCancellingCombatActions" })
                GameReflection.SetField(queue, flag, false);
        }
        catch (Exception e) { Log.Warn($"塔主手牌：放开塔主的出牌队列失败：{e.Message}"); }
    }

    private static List<object> Cards(object pcs, string pile) =>
        (GameReflection.Get(GameReflection.Get(pcs, pile)!, "Cards") as IEnumerable)?.Cast<object>().ToList() ?? [];

    private static int Count(object pcs, string pile) => Cards(pcs, pile).Count;

    /// <summary>陷阱牌战斗中不能抽到：第 1 回合抽牌前从抽牌堆、手牌、弃牌堆拿掉（只是战斗里的副本，牌组不变）。</summary>
    private static void RemoveTraps(object pcs)
    {
        int removed = 0;
        foreach (var pile in new[] { "DrawPile", "Hand", "DiscardPile" })
        {
            var holder = GameReflection.Get(pcs, pile);
            if (holder == null) continue;
            foreach (var card in Cards(pcs, pile).Where(c => MasterCards.DefOf(c)?.Unplayable == true))
            {
                RuntimeNetAction.Call(holder, "RemoveInternal", card, true);
                removed++;
            }
        }
        if (removed > 0) Log.Info($"塔主手牌：陷阱牌移出战斗牌堆 {removed} 张");
    }

    private static async Task DiscardHand(object context, object master, object pcs)
    {
        var hand = Cards(pcs, "Hand");
        if (hand.Count == 0) return;
        var cardModel = GameReflection.TypesNamed("CardModel").First(t => t.IsAbstract);
        var typed = Array.CreateInstance(cardModel, hand.Count);
        for (int i = 0; i < hand.Count; i++) typed.SetValue(hand[i], i);
        try
        {
            // 原版弃牌在 CardCmd（0.0.31 实测 CardPileCmd 上没有 Discard）
            await (Task)Static("CardCmd", "Discard", m => m.GetParameters().Length == 2 && m.GetParameters()[1].ParameterType != cardModel)
                .Invoke(null, [context, typed])!;
        }
        catch (Exception e)
        {
            Log.Warn($"塔主手牌：原版弃牌失败（{e.InnerException?.Message ?? e.Message}），直接移到弃牌堆");
            MovePile(pcs, "Hand", "DiscardPile", hand);
        }
    }

    /// <summary>原版抽牌没发牌时：从抽牌堆顶拿；抽牌堆空了就把弃牌堆按原顺序放回（各端一样，不洗牌）。</summary>
    private static void ManualDraw(object pcs, int count)
    {
        for (int i = 0; i < count; i++)
        {
            if (Count(pcs, "DrawPile") == 0) MovePile(pcs, "DiscardPile", "DrawPile", Cards(pcs, "DiscardPile"));
            var top = Cards(pcs, "DrawPile").FirstOrDefault();
            if (top == null) break;
            MovePile(pcs, "DrawPile", "Hand", [top]);
        }
        Log.Info("塔主手牌：原版抽牌跳过了塔主，改为直接从抽牌堆拿");
    }

    private static void MovePile(object pcs, string from, string to, List<object> cards)
    {
        var a = GameReflection.Get(pcs, from)!;
        var b = GameReflection.Get(pcs, to)!;
        foreach (var c in cards)
        {
            RuntimeNetAction.Call(a, "RemoveInternal", c, false);
            RuntimeNetAction.Call(b, "AddInternal", c, -1, false);
        }
    }

    private static System.Reflection.MethodInfo Static(string type, string name, Func<System.Reflection.MethodInfo, bool> match) =>
        RuntimeNetAction.Required(type).GetMethods(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static)
            .FirstOrDefault(m => m.Name == name && !m.IsGenericMethodDefinition && match(m)) ?? throw new MissingMethodException(type, name);
}
