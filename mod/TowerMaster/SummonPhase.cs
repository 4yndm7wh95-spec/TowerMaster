using System.Collections;
using System.Reflection;
using System.Text.Json;
using HarmonyLib;
using TowerMaster.Core;

namespace TowerMaster;

/// <summary>召唤面板的界面接口；游戏里是 Godot 面板，测试里换成假的。</summary>
internal interface ISummonUi
{
    void Show();
    void Close();
}

/// <summary>
/// 召唤阶段（开发顺序第 2 步）。塔主 = 房主，只在房主这台电脑上运行：
/// 1. 地图投票到齐、房主要入队「移动」动作时（<see cref="Test1bMixedEncounter.BeforeEnqueue"/>），
///    如果目的地是普通、精英或 Boss 房，先扣住移动，打开召唤面板（限时 30 秒）。
/// 2. 确认或超时后：扣召唤点、记下本场花费，确认时广播召唤清单（复用测试 1b 的联机动作），再放行移动。
///    各客户端在进房时按清单换遭遇，和测试 1b 一样。
/// 3. 战斗胜利后结算收入（<see cref="AfterCombatWon"/>）。
/// 「?」房间进房后才知道是不是战斗，第一版不召唤，按原版出场、不扣点。
/// </summary>
internal static class SummonPhase
{
    private static TowerMasterConfig _config = new();
    private static SummonRules _rules = null!;
    private static object? _heldMove, _queue;
    private static ISummonUi? _openUi;
    private static bool _releasing;
    private static int _sent;
    private static readonly Dictionary<ulong, int> StartHp = new();
    private static readonly HashSet<ulong> KnockedDown = new();
    private static object? _subscribedManager;
    private static bool _patched;

    public static bool Enabled { get; private set; }
    public static SummonSession? Current { get; private set; }

    private static HashSet<string>? _mixable;

    /// <summary>遭遇没有专用场景、也没有命名槽位（怪可以随便摆）。</summary>
    internal static bool IsSceneless(string encounterId)
    {
        if (GameReflection.TypeNamed(encounterId) == null) return false;
        var model = Test1bMixedEncounter.Model("Encounter", encounterId);
        return GameReflection.Get(model, "HasScene") is false
               && GameReflection.Get(model, "Slots") is IEnumerable slots && !slots.Cast<object>().Any();
    }

    /// <summary>
    /// 能召唤哪些怪：在任何一幕的某个「没有专用场景、没有命名槽位」的原版普通或精英遭遇里出现过的怪。
    /// 有的怪靠槽位名决定行动（例如外骨骼要 first~fourth），混搭进通用场景后没有槽位，开战就卡死（0.0.12 实测）。
    /// 测试里替换。第一个参数（幕）保留给以后按幕区分用。
    /// </summary>
    internal static Func<string, string, bool> MonsterFilter = (_, monster) =>
    {
        if (_mixable == null)
        {
            _mixable = new HashSet<string>();
            foreach (var act in _rules.Prices.Acts.Values)
            foreach (var (id, enc) in act.Encounters.Where(e => e.Value.Room is RoomKind.Monster or RoomKind.Elite))
            {
                try { if (IsSceneless(id)) _mixable.UnionWith(enc.Lineups.SelectMany(l => l.Monsters)); }
                catch (Exception e) { Log.Warn($"召唤阶段：检查遭遇 {id} 的场景失败，它的怪不放进可召唤列表：{e.Message}"); }
            }
            Log.Info($"召唤阶段：可混搭的怪 {_mixable.Count} 种：{string.Join(", ", _mixable.Order())}");
        }
        return _mixable.Contains(monster);
    };

    /// <summary>Boss 能不能另加怪：只有没有专用场景、命名槽位的 Boss 能（例如墨影幻灵的召唤物要专用槽位，不能）。测试里替换。</summary>
    internal static Func<string, bool> BossAllowsExtras = encounter =>
    {
        try { return IsSceneless(encounter); }
        catch (Exception e) { Log.Warn($"召唤阶段：检查 Boss {encounter} 的场景失败，不允许另加怪：{e.Message}"); return false; }
    };

    /// <summary>正在等塔主选的陷阱（每幕一次）；没有为 null。</summary>
    public static TrapDraftChoice? Draft { get; private set; }

    /// <summary>选陷阱界面工厂；测试里替换。</summary>
    internal static Func<TrapDraftChoice, ISummonUi> DraftUiFactory = choice => new TrapDraftPanel(choice);

    /// <summary>界面工厂；测试里替换。</summary>
    internal static Func<SummonSession, ISummonUi> UiFactory = session => new SummonPanel(session);

    /// <summary>结算提示（收入等）；游戏里显示在屏幕上，测试里只记日志。</summary>
    internal static Action<string> Toast = text => SummonPanel.ShowToast(text);

    /// <summary>
    /// 一局结束（回主菜单、断线、放弃）或新开一局时：关掉还开着的面板，丢掉扣住的移动和本场记录，
    /// 账本只清内存（下次按新一局的种子从文件读或新开）。0.0.26 实测：断线后新局还显示上一局的召唤点和暂停状态。
    /// </summary>
    internal static void ResetRun()
    {
        var ui = _openUi;
        _openUi = null;
        try { ui?.Close(); } catch (Exception e) { Log.Warn($"召唤阶段：关闭面板失败：{e.Message}"); }
        _heldMove = _queue = null;
        _releasing = false;
        Current = null;
        Draft = null;
        StartHp.Clear();
        KnockedDown.Clear();
        MasterLedger.Configure(_config); // 订阅不清：CombatManager 是单例，回调一直有效
    }

    internal static void Configure(TowerMasterConfig config, PriceBook prices)
    {
        _config = config;
        _rules = new SummonRules(config, prices);
        MasterLedger.Configure(config);
        _heldMove = _queue = null;
        _releasing = false;
        Current = null;
        StartHp.Clear();
        KnockedDown.Clear();
        _subscribedManager = null;
        _mixable = null;
    }

    internal static void Apply(Harmony harmony, TowerMasterConfig config, PriceBook prices)
    {
        Configure(config, prices);
        Enabled = true;
        if (_patched) return;
        _patched = true;
        Patch(harmony, "SetUpCombat", "CombatManager", nameof(AfterSetUp), prefix: false);
        Patch(harmony, "ReviveBeforeCombatEnd", "Player", nameof(BeforeRevive), prefix: true);
        Log.Info("召唤阶段：已启用（塔主 = 房主）");
    }

    internal static void Disable() => Enabled = false;

    private static void Patch(Harmony harmony, string method, string type, string callback, bool prefix)
    {
        var target = GameReflection.FindMethod(method, type);
        if (target == null) { Log.Warn($"召唤阶段：找不到 {type}.{method}"); return; }
        var patch = new HarmonyMethod(typeof(SummonPhase).GetMethod(callback, GameReflection.All)!);
        harmony.Patch(target, prefix: prefix ? patch : null, postfix: prefix ? null : patch);
        Log.Info($"召唤阶段：已挂到 {GameReflection.Describe(target)}");
    }

    private static object State => GameReflection.Get(Test1bMixedEncounter.Run, "State") ?? throw new InvalidOperationException("没有进行中的对局");
    internal static ulong Seed(object state) => Convert.ToUInt64(GameReflection.Get(GameReflection.Get(state, "Rng")!, "Seed"));
    private static string ActId(object state) => GameReflection.Get(state, "Act")!.GetType().Name;

    private static int Climbers(object state) =>
        (GameReflection.Get(state, "Players") as IEnumerable)?.Cast<object>().Count(p => Test2MasterOffField.NetIdOf(p) != Test2MasterOffField.MasterId) ?? 1;

    // ---------------------------------------------------------------- 1. 扣住移动、打开面板

    /// <summary>
    /// 房主入队「移动」动作前调用。返回 true 放行；返回 false 扣住（面板关闭后由本类重新入队）。
    /// </summary>
    internal static bool OnMoveRequested(object queue, object move)
    {
        if (_releasing) { _releasing = false; return true; } // 召唤结束后本类自己重新入队
        if (!Test3MasterAutoPilot.LocalIsMaster) return true;
        if (Current != null) { Log.Warn("召唤阶段：上一个召唤还没结束，又收到移动，扣住"); return false; }

        var state = State;
        var room = RoomKindAt(state, move);
        if (room == null) return true;

        var actId = ActId(state);
        var prices = _rules.Prices;
        if (!prices.Acts.TryGetValue(actId, out var act)) { Log.Warn($"召唤阶段：价格表里没有幕 {actId}，按原版"); return true; }
        var wallet = MasterLedger.For(Seed(state), act.ActNo);

        var context = new RoomContext(actId, room.Value, Climbers(state), MasterLedger.BattlesFought, [], wallet.Points);
        bool opening = _rules.IsOpeningProtected(context);
        // Boss 免费出场，没有标准开销（不然日志和面板会显示一个没用的数）
        context = context with { StandardCostOverride = room == RoomKind.Boss ? 0 : _rules.AverageStandardCost(actId, room.Value, weak: opening) };
        var candidates = room == RoomKind.Boss ? BossCandidates(state, actId, act.ActNo) : [];
        if (room == RoomKind.Boss)
            Log.Info($"召唤阶段：Boss 候选 {string.Join("、", candidates.Select(c => $"{c}（{(BossAllowsExtras(c) ? "可另加怪" : "专用场景，不能另加")}）"))}；" +
                     $"所有 Boss：{string.Join("、", prices.Acts.Values.SelectMany(a => a.Encounters).Where(e => e.Value.Room == RoomKind.Boss).Select(e => $"{e.Key}={(BossAllowsExtras(e.Key) ? "可" : "不可")}"))}");

        _heldMove = move;
        _queue = queue;
        Log.Info($"召唤阶段：{room} 房，幕 {actId}，召唤点 {wallet.Points}，标准开销 {context.StandardCostOverride}{(opening ? "（开局保护）" : "")}，扣住移动");

        void OpenSummon()
        {
            var session = new SummonSession(_rules, context, candidates, _config.SummonPhaseSeconds, m => MonsterFilter(actId, m), BossAllowsExtras,
                ThreatPhase.Enabled ? MasterLedger.Traps : null, _config.TrapCooldown ? MasterLedger.LastPlaced : null);
            Current = session;
            session.Finished += OnFinished;
            try
            {
                _openUi = UiFactory(session);
                _openUi.Show();
            }
            catch (Exception e)
            {
                Log.Error("召唤阶段：打开面板失败，按原版出场", e);
                session.UseVanilla();
            }
        }

        // 每幕第一次召唤前，塔主先自由挑陷阱（用户要求：不要固定卡包；预算、张数、不重复约束见 TrapDraft）
        if (ThreatPhase.Enabled && !MasterLedger.DraftDone(act.ActNo))
        {
            MasterLedger.UpgradeHand(act.ActNo);
            var draft = new TrapDraft(act.ActNo, TrapCatalog.DraftOffer(act.ActNo, Seed(state), _config.TrapDraftOfferSize), MasterLedger.Traps,
                TowerMasterConfig.ByAct(_config.TrapDraftBudget, act.ActNo), _config.TrapDraftMaxPicks, _config.TrapHandLimit);
            var choice = new TrapDraftChoice(draft);
            Draft = choice;
            choice.Confirmed += cards =>
            {
                Draft = null;
                MasterLedger.CompleteDraft(act.ActNo, cards);
                MasterDeck.Publish($"第 {act.ActNo} 幕挑完陷阱");
                OpenSummon();
            };
            try { _openUi = DraftUiFactory(choice); _openUi.Show(); }
            catch (Exception e)
            {
                Log.Error("召唤阶段：打开选陷阱面板失败，这一幕不挑陷阱", e);
                choice.Confirm();
            }
        }
        else OpenSummon();
        return false;
    }

    private static RoomKind? RoomKindAt(object state, object move)
    {
        var coord = GameReflection.Get(move, "_destination") ?? throw new InvalidOperationException("移动动作上没有 _destination");
        var map = GameReflection.Get(state, "Map") ?? throw new InvalidOperationException("没有地图");
        var point = map.GetType().GetMethods(GameReflection.All)
            .First(m => m.Name == "GetPoint" && m.GetParameters().Length == 1).Invoke(map, [coord]);
        return GameReflection.Get(point!, "PointType")?.ToString() switch
        {
            "Monster" => RoomKind.Monster,
            "Elite" => RoomKind.Elite,
            "Boss" => RoomKind.Boss,
            _ => null,
        };
    }

    /// <summary>
    /// 本幕公开的候选 Boss 中文名（玩家信息条用；各端用同一个种子和规则算，结果相同，不用发网络消息）。没有对局/没有规则时为空。
    /// </summary>
    internal static IReadOnlyList<string> PublicBossNames()
    {
        if (_rules == null || GameReflection.Get(Test1bMixedEncounter.Run, "State") is not { } state) return [];
        if (!_rules.Prices.Acts.TryGetValue(ActId(state), out var act)) return [];
        return BossCandidates(state, ActId(state), act.ActNo)
            .Select(id => act.Encounters.TryGetValue(id, out var e) ? e.NameZh : id).ToList();
    }

    /// <summary>候选 Boss：游戏本来为本幕选的 Boss 在前，再按种子抽一个本幕其他 Boss（只在房主算，结果随清单广播）。</summary>
    private static IReadOnlyList<string> BossCandidates(object state, string actId, int actNo)
    {
        var original = GameReflection.Get(GameReflection.Get(state, "Act")!, "BossEncounter")?.GetType().Name;
        if (original == null) return [];
        var rng = new Random(unchecked((int)(Seed(state) ^ (ulong)(actNo * 7919))));
        return _rules.PickBossCandidates(actId, original, n => rng.Next(n));
    }

    // ---------------------------------------------------------------- 2. 确认或超时

    private static void OnFinished(SummonSession session)
    {
        try
        {
            var wallet = MasterLedger.Wallet!;
            var (total, spend) = session.Charge;
            total = Math.Min(total, wallet.Points);
            int before = wallet.Points;
            wallet.Spend(total);
            BalanceLog.Summoned(session, before, wallet.Points);
            MasterLedger.Pending = new PendingBattle(session.Room.Room, session.Room.StandardCostOverride ?? 0, spend);
            MasterLedger.Save();

            if (session.Confirmed) SendPlan(session);
            // 盖下的陷阱：从手里拿走，留给下一场战斗（只有房主知道盖了什么）
            TrapPhase.Place(session.Confirmed ? MasterLedger.TakeTraps(session.SelectedTraps) : [], MasterLedger.Traps.Count);
            Log.Info(session.Confirmed
                ? $"召唤阶段：确认 {(session.Encounter ?? string.Join("+", session.Monsters))}，花费 {total}，剩余 {wallet.Points}"
                : $"召唤阶段：{(!session.Unlimited && session.SecondsLeft <= 0 ? "超时" : "塔主选择按原版出场")}，按原版出场，花费 {total}，剩余 {wallet.Points}");
        }
        catch (Exception e)
        {
            Log.Error("召唤阶段：结算召唤失败，按原版出场", e);
        }
        finally
        {
            Release();
        }
    }

    private static void SendPlan(SummonSession session)
    {
        var state = State;
        var owner = Convert.ToUInt64(GameReflection.Get(_heldMove!, "OwnerId"));
        var plan = new SummonPlan(2, ++_sent, Seed(state), ActId(state), Convert.ToInt32(GameReflection.Get(state, "TotalFloor")),
            session.Monsters.ToArray(),
            session.Room.Room == RoomKind.Boss ? session.Encounter : null,
            Test1bMixedEncounter.CoordKey(GameReflection.Get(_heldMove!, "_destination")));
        var payload = JsonSerializer.Serialize(plan);
        Log.Info($"召唤阶段 #{plan.Sequence}：房主发送 {payload}");
        RuntimeNetAction.Call(_queue!, "RequestEnqueue", RuntimeNetAction.Create(owner, payload));
    }

    /// <summary>放行扣住的移动。清单动作已先入队，同一个玩家队列保证它先执行。</summary>
    private static void Release()
    {
        var move = _heldMove;
        var queue = _queue;
        _heldMove = _queue = null;
        Current = null;
        if (move == null || queue == null) return;
        _releasing = true;
        try { RuntimeNetAction.Call(queue, "RequestEnqueue", move); }
        catch (Exception e) { Log.Error("召唤阶段：放行移动失败（大家会停在地图上）", e); }
        finally { _releasing = false; }
    }

    // ---------------------------------------------------------------- 3. 战斗结算

    private static void AfterSetUp(object? __instance, object[] __args)
    {
        try
        {
            if (!Enabled || !Test3MasterAutoPilot.LocalIsMaster) return;
            StartHp.Clear();
            KnockedDown.Clear();
            foreach (var p in ClimberPlayers())
                StartHp[Test2MasterOffField.NetIdOf(p)!.Value] = Convert.ToInt32(GameReflection.Get(GameReflection.Get(p, "Creature")!, "CurrentHp"));
            if (__instance != null && !ReferenceEquals(__instance, _subscribedManager)) Subscribe(__instance);
        }
        catch (Exception e) { Log.Error("召唤阶段：记录开局血量失败", e); }
    }

    /// <summary>订阅 CombatManager.CombatWon（Action&lt;CombatRoom&gt;）。</summary>
    private static void Subscribe(object manager)
    {
        var ev = manager.GetType().GetEvent("CombatWon", GameReflection.All);
        if (ev?.EventHandlerType == null) { Log.Warn("召唤阶段：找不到 CombatWon 事件，不结算收入"); return; }
        var handler = Delegate.CreateDelegate(ev.EventHandlerType, typeof(SummonPhase).GetMethod(nameof(AfterCombatWon), GameReflection.All)!);
        // CombatManager 是整个进程的单例：先摘掉可能已经挂着的同一个回调再挂，免得换局后重复结算（0.0.27 实测收入执行两次）
        ev.RemoveEventHandler(manager, handler);
        ev.AddEventHandler(manager, handler);
        _subscribedManager = manager;
        Log.Info("召唤阶段：已订阅战斗胜利事件");
    }

    /// <summary>原版战斗结束前复活倒下的玩家：在这里记下谁被击倒了。</summary>
    private static void BeforeRevive(object __instance)
    {
        try
        {
            if (!Enabled || !Test3MasterAutoPilot.LocalIsMaster) return;
            var id = Test2MasterOffField.NetIdOf(__instance);
            if (id == null || id == Test2MasterOffField.MasterId) return;
            if (GameReflection.Get(GameReflection.Get(__instance, "Creature")!, "IsDead") is true) KnockedDown.Add(id.Value);
        }
        catch (Exception e) { Log.Error("召唤阶段：记录击倒失败", e); }
    }

    /// <summary>战斗没赢（全员倒下等）：只写平衡记录。</summary>
    internal static void RecordLoss()
    {
        try
        {
            if (!Enabled || !Test3MasterAutoPilot.LocalIsMaster) return;
            int damage = 0;
            foreach (var p in ClimberPlayers())
            {
                var id = Test2MasterOffField.NetIdOf(p)!.Value;
                int end = Convert.ToInt32(GameReflection.Get(GameReflection.Get(p, "Creature")!, "CurrentHp"));
                damage += Math.Max(0, StartHp.GetValueOrDefault(id, end) - end);
            }
            BalanceLog.Finish(false, MasterLedger.Wallet?.ActNo ?? 1, MasterLedger.BattlesFought + 1, StartHp, ClimberPlayers(), KnockedDown, damage, null, MasterLedger.Wallet?.Points ?? 0);
        }
        catch (Exception e) { Log.Warn($"平衡记录：记录失败的战斗出错：{e.Message}"); }
    }

    internal static void AfterCombatWon(object room)
    {
        try
        {
            if (!Enabled || !Test3MasterAutoPilot.LocalIsMaster) return;
            var state = State;
            var act = _rules.Prices.Acts.GetValueOrDefault(ActId(state));
            var wallet = MasterLedger.For(Seed(state), act?.ActNo ?? MasterLedger.Wallet?.ActNo ?? 1);
            var pending = MasterLedger.Pending ?? new PendingBattle(RoomKind.Monster, 0, 0); // 「?」战斗等：没有召唤记录
            MasterLedger.Pending = null;
            if (ThreatPhase.Enabled) TrapPhase.Finish(true, _config); // 先结算陷阱（躲过奖励要记进平衡记录）

            int damage = 0;
            foreach (var p in ClimberPlayers())
            {
                var id = Test2MasterOffField.NetIdOf(p)!.Value;
                int end = KnockedDown.Contains(id) ? 0 : Convert.ToInt32(GameReflection.Get(GameReflection.Get(p, "Creature")!, "CurrentHp"));
                damage += Math.Max(0, StartHp.GetValueOrDefault(id, end) - end);
            }

            var income = wallet.SettleBattle(new BattleResult(pending.Room, pending.StandardCost, pending.MonsterSpend, damage, KnockedDown.ToList()),
                Climbers(state), out var rewarded);
            MasterLedger.CountBattle();
            if (ThreatPhase.Enabled) TrapPhase.KnockdownReward(rewarded.Count, wallet.ActNo, Seed(state), MasterLedger.BattlesFought, _config.TrapHandLimit);
            MasterDeck.Publish("战斗结束（陷阱用掉/收回、击倒奖励）");
            MasterRewards.AfterWin(pending.Room, Seed(state), MasterLedger.BattlesFought, wallet.ActNo);
            MasterLedger.Save();
            BalanceLog.Finish(true, wallet.ActNo, MasterLedger.BattlesFought, StartHp, ClimberPlayers(), KnockedDown, damage, income, wallet.Points);
            var text = $"战斗收入 +{income.Credited}（基础 {income.Base}，节约 {income.Savings}，战果 {income.Damage}" +
                       (income.Knockdown > 0 ? $"，击倒 {income.Knockdown}" : "") + (income.Wasted > 0 ? $"，超上限作废 {income.Wasted}" : "") +
                       $"），召唤点 {wallet.Points}/{wallet.Cap}";
            Log.Info($"召唤阶段：{text}；玩家掉血 {damage}，击倒 [{string.Join(",", KnockedDown)}]，有奖励 [{string.Join(",", rewarded)}]");
            Toast(text);
        }
        catch (Exception e) { Log.Error("召唤阶段：结算收入失败", e); }
    }

    private static IEnumerable<object> ClimberPlayers() =>
        (GameReflection.Get(State, "Players") as IEnumerable)?.Cast<object>()
            .Where(p => Test2MasterOffField.NetIdOf(p) != Test2MasterOffField.MasterId) ?? [];
}
