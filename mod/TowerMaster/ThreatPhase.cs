using System.Collections;
using System.Reflection;
using System.Text.Json;
using HarmonyLib;
using TowerMaster.Core;

namespace TowerMaster;

/// <summary>塔主回合的一条联机指令（各端按同样顺序执行）。</summary>
/// <param name="Op">begin、end、block、heal、strength、strength_all、weak、vulnerable、frail、dazed。</param>
/// <param name="Monster">怪物在 CombatState.Enemies 里的下标；<paramref name="MonsterId"/> 用来核对是不是同一只。</param>
/// <param name="Amount">房主算好的数值（格挡量、回血量、力量、层数），客户端照做不再计算。</param>
internal sealed record ThreatCommand(int Version, int Sequence, ulong Seed, int Round, string Op,
    int Monster = -1, string? MonsterId = null, ulong Player = 0, int Amount = 0, int[]? Monsters = null);

/// <summary>塔主回合面板；测试里替换。</summary>
internal interface IThreatUi
{
    void Show();
    void Close();
}

/// <summary>
/// 塔主回合（设计文档「每一轮的顺序」：玩家抽牌 → 塔主回合 → 玩家出牌 → 怪物行动）。
///
/// 流程（塔主 = 房主）：
/// 1. 每场战斗开始（CombatManager.SetUpCombat）时房主按幕、房间、人数建一个 <see cref="ThreatSession"/>（威胁点整场共用）。
/// 2. 玩家回合开始（CombatManager.TurnStarted，玩家一侧）时，还有威胁点就入队 begin 指令：
///    各端执行时暂停所有玩家队列（ActionQueueSet.PauseAllPlayerQueues，出牌、结束回合都排队等着），爬塔玩家屏幕上显示「塔主回合」。
/// 3. 塔主在面板上操作，每次操作先由 ThreatSession 判断能不能做、花多少、效果多大，再入队一条指令；
///    各端执行时用原版命令（CreatureCmd.GainBlock、Heal，PowerCmd.Apply，CardPileCmd.AddToCombatAndPreview）真正施加。
/// 4. 塔主点「结束」、威胁点用完或超时，入队 end：各端恢复玩家队列。
/// 指令动作类型是 Any：玩家队列暂停时照样执行。战斗结束时各端兜底恢复队列。
/// </summary>
internal static class ThreatPhase
{
    public const string Prefix = "threat:";

    /// <summary>
    /// begin 是 CombatPlayPhaseOnly：各端都要进入出牌阶段（抽完牌、能量重置、生成「回合开始」校验之后）才执行，
    /// 和玩家出牌同一个时间点。0.0.20 用 Any，慢的一端还在发牌时就执行了，校验编号错位，StateDivergence。
    /// begin 之后的操作和 end 排在塔主队列里 begin 后面（每个玩家的队列只看队头），用 Any 才不被暂停挡住。
    /// </summary>
    /// 陷阱触发（trap）和陷阱数提示（trap_info）同理用 CombatPlayPhaseOnly；躲过奖励（trap_dodge）在战斗结束后发金币，用 NonCombat。
    internal static string ActionKind(string payload) =>
        payload.Contains("\"Op\":\"begin\"") || payload.Contains("\"Op\":\"trap\"") || payload.Contains("\"Op\":\"trap_info\"") ? "CombatPlayPhaseOnly"
        : payload.Contains("\"Op\":\"trap_dodge\"") ? "NonCombat"
        : "Any";

    private static TowerMasterConfig _config = new();
    private static PriceBook? _prices;
    private static bool _patched;
    private static object? _subscribed;
    private static int _sent;
    private static bool _pausedByUs;
    private static IThreatUi? _ui;

    public static bool Enabled { get; private set; }

    /// <summary>本场的威胁点（只在房主上有）。</summary>
    public static ThreatSession? Session { get; private set; }

    /// <summary>塔主回合是否正在进行（房主）。</summary>
    public static bool TurnOpen { get; private set; }

    public static int Round { get; private set; }

    /// <summary>本机执行过 begin、还没执行 end：玩家队列正被塔主回合暂停（各端都有）。</summary>
    public static bool PausedHere => _pausedByUs;

    /// <summary>塔主回合剩余秒数；配置为 0 时不限时。</summary>
    public static double SecondsLeft { get; private set; }

    /// <summary>塔主回合面板；测试里替换。</summary>
    internal static Func<IThreatUi> UiFactory = () => new ThreatPanel();

    /// <summary>爬塔玩家屏幕上的「塔主回合」提示（显示、隐藏）；测试里替换。</summary>
    internal static Action<bool> Banner = ThreatPanel.SetBanner;

    /// <summary>每条指令执行完（各端）。面板据此刷新。</summary>
    public static event Action? Applied;

    internal static void Apply(Harmony harmony, TowerMasterConfig config, PriceBook prices)
    {
        Configure(config, prices);
        Enabled = true;
        TrapPhase.Apply(harmony);
        if (_patched) return;
        _patched = true;
        var target = GameReflection.FindMethod("SetUpCombat", "CombatManager");
        if (target == null) { Log.Warn("塔主回合：找不到 CombatManager.SetUpCombat，不启用"); return; }
        harmony.Patch(target, postfix: new HarmonyMethod(typeof(ThreatPhase).GetMethod(nameof(AfterSetUp), GameReflection.All)!));
        Log.Info($"塔主回合：已挂到 {GameReflection.Describe(target)}");
    }

    internal static void Configure(TowerMasterConfig config, PriceBook prices)
    {
        _config = config;
        _prices = prices;
        Session = null;
        TurnOpen = false;
        Round = 0;
        _pausedByUs = false;
        _subscribed = null;
        _ui = null;
    }

    internal static void Disable() => Enabled = false;

    // ---------------------------------------------------------------- 战斗开始、回合开始、战斗结束

    private static void AfterSetUp(object? __instance, object[] __args)
    {
        try
        {
            if (!Enabled) return;
            if (__instance != null && !ReferenceEquals(__instance, _subscribed)) Subscribe(__instance);
            TurnOpen = false;
            Round = 0;
            Session = null;
            if (!Test3MasterAutoPilot.LocalIsMaster) return;
            var state = Test1bMixedEncounter.Run is { } run ? GameReflection.Get(run, "State") : null;
            if (state == null) return;
            var actNo = _prices!.Acts.TryGetValue(GameReflection.Get(state, "Act")!.GetType().Name, out var act) ? act.ActNo : 1;
            var room = RoomOf(state);
            TrapPhase.CombatSetUp();
            Session = new ThreatSession(_config, actNo, room, Climbers(state).Count);
            BalanceLog.CombatStarted(state, null, Session.Points);
            Log.Info($"塔主回合：本场 {room} 房，第 {actNo} 幕，威胁点 {Session.Points}");
        }
        catch (Exception e) { Log.Error("塔主回合：战斗开始时初始化失败，本场没有塔主回合", e); }
    }

    private static RoomKind RoomOf(object state)
    {
        var point = GameReflection.Get(state, "CurrentMapPoint");
        return (point == null ? null : GameReflection.Get(point, "PointType")?.ToString()) switch
        {
            "Elite" => RoomKind.Elite,
            "Boss" => RoomKind.Boss,
            _ => RoomKind.Monster,
        };
    }

    private static void Subscribe(object manager)
    {
        Hook(manager, "TurnStarted", nameof(OnTurnStarted));
        Hook(manager, "CombatEnded", nameof(OnCombatEnded));
        Hook(manager, "CombatWon", nameof(OnCombatWon));
        _subscribed = manager;
    }

    private static void Hook(object manager, string name, string callback)
    {
        var ev = manager.GetType().GetEvent(name, GameReflection.All);
        if (ev?.EventHandlerType == null) { Log.Warn($"塔主回合：找不到 CombatManager.{name} 事件"); return; }
        ev.AddEventHandler(manager, Delegate.CreateDelegate(ev.EventHandlerType, typeof(ThreatPhase).GetMethod(callback, GameReflection.All)!));
    }

    /// <summary>每个回合开始（双方都会触发）。只在房主、玩家一侧、还有威胁点时开塔主回合。</summary>
    internal static void OnTurnStarted(object combatState)
    {
        try
        {
            if (!Enabled || !Test3MasterAutoPilot.LocalIsMaster) return;
            if (GameReflection.Get(combatState, "CurrentSide")?.ToString() != "Player") return;
            Round = Convert.ToInt32(GameReflection.Get(combatState, "RoundNumber") ?? Round + 1);
            BalanceLog.Round(Round);
            if (Round == 1) BalanceLog.Spawned(combatState);
            // 陷阱先发：指令排在 begin 前面，不会被塔主回合的暂停挡住
            try { TrapPhase.RoundStarted(Round); }
            catch (Exception e) { Log.Warn($"陷阱：回合开始检查失败：{e.Message}"); }
            if (Session == null) return;
            if (Round > 1) Session.NextTurn();
            if (Session.Points <= 0) { Log.Info($"塔主回合：第 {Round} 回合没有威胁点了，跳过"); return; }
            if (TurnOpen) { Log.Warn("塔主回合：上一个塔主回合还没结束，又开始新回合，先结束上一个"); EndTurn("新回合开始"); }
            TurnOpen = true;
            SecondsLeft = _config.MasterTurnSeconds;
            Send(new ThreatCommand(1, 0, 0, Round, "begin"));
            Log.Info($"塔主回合：第 {Round} 回合开始，威胁点 {Session.Points}");
            _ui = UiFactory();
            _ui.Show();
        }
        catch (Exception e)
        {
            Log.Error("塔主回合：开始失败，跳过本回合", e);
            if (TurnOpen) EndTurn("出错");
        }
    }

    /// <summary>战斗胜利（房主）：没触发的陷阱翻开、给躲过奖励。</summary>
    internal static void OnCombatWon(object room)
    {
        try { if (Enabled && Test3MasterAutoPilot.LocalIsMaster) TrapPhase.Finish(true, _config); }
        catch (Exception e) { Log.Error("陷阱：战斗胜利结算失败", e); }
    }

    internal static void OnCombatEnded(object room)
    {
        try
        {
            if (Enabled && Test3MasterAutoPilot.LocalIsMaster)
            {
                // 不确定 CombatWon、CombatEnded 谁先触发：这里按场面判断是不是赢了（还有爬塔玩家活着、敌人都死了）
                bool won = Won();
                try { TrapPhase.Finish(won, _config); }
                catch (Exception e) { Log.Error("陷阱：战斗结束结算失败", e); }
                if (!won) SummonPhase.RecordLoss();
            }
            CloseUi();
            TurnOpen = false;
            Session = null;
            if (_pausedByUs) // 兜底：战斗在塔主回合中结束（例如控制台 win）
            {
                CallQueueSet("UnpauseAllPlayerQueues");
                _pausedByUs = false;
                Log.Info("塔主回合：战斗结束，恢复玩家队列");
            }
            Banner(false);
        }
        catch (Exception e) { Log.Error("塔主回合：战斗结束时清理失败", e); }
    }

    // ---------------------------------------------------------------- 房主操作

    /// <summary>
    /// 塔主的一次操作。monster 是 Enemies 下标，player 是联机 id。
    /// 返回 (成功, 说明)；成功时已扣威胁点并入队指令。
    /// </summary>
    public static (bool Ok, string Message) Act(string op, int monster = -1, ulong player = 0)
    {
        if (!TurnOpen || Session == null) return (false, "现在不是塔主回合");
        try
        {
            var combat = CombatState() ?? throw new InvalidOperationException("不在战斗中");
            ThreatResult result;
            int pointsBefore = Session.Points;
            string? monsterId = null;
            object? creature = null;
            if (op is "block" or "heal" or "strength")
            {
                creature = AliveEnemy(combat, monster) ?? throw new ArgumentException($"没有第 {monster} 只活着的怪物");
                monsterId = MonsterId(creature);
            }
            if (op is "weak" or "vulnerable" or "frail" or "dazed" && ClimberCreature(combat, player) == null)
                return (false, $"没有活着的玩家 {player}");

            result = op switch
            {
                "block" => Session.Block(monster),
                "heal" => Session.Heal(monster, Convert.ToInt32(GameReflection.Get(creature!, "MaxHp"))),
                "strength" => Session.Strength(monster),
                "strength_all" => Session.StrengthAll(AliveEnemyIndexes(combat)),
                "weak" => Session.Debuff(player, PlayerDebuff.Weak),
                "vulnerable" => Session.Debuff(player, PlayerDebuff.Vulnerable),
                "frail" => Session.Debuff(player, PlayerDebuff.Frail),
                "dazed" => Session.Dazed(player),
                _ => throw new ArgumentException($"不认识的操作 {op}"),
            };
            if (!result.Ok) return (false, Describe(result.Violation));
            BalanceLog.ThreatUsed(op, pointsBefore - Session.Points);

            Send(new ThreatCommand(1, 0, 0, Round, op, monster, monsterId, player, result.Amount,
                op == "strength_all" ? result.Monsters?.ToArray() : null));
            var message = $"{OpName(op)}{(monsterId != null ? $" → {NameOf(monsterId)}" : player != 0 ? $" → 玩家 {player}" : "")}（剩余威胁点 {Session.Points}）";
            Log.Info($"塔主回合：{message}");
            if (Session.Points <= 0) EndTurn("威胁点用完");
            return (true, message);
        }
        catch (Exception e)
        {
            Log.Warn($"塔主回合：操作 {op} 失败：{e.Message}");
            return (false, e.Message);
        }
    }

    /// <summary>结束塔主回合：入队 end，各端恢复玩家队列。</summary>
    public static void EndTurn(string reason = "塔主结束")
    {
        if (!TurnOpen) return;
        TurnOpen = false;
        CloseUi();
        try { Send(new ThreatCommand(1, 0, 0, Round, "end")); }
        catch (Exception e) { Log.Error("塔主回合：发送结束失败", e); }
        try { TrapPhase.Flush(); }
        catch (Exception e) { Log.Error("陷阱：补发塔主回合期间触发的陷阱失败", e); }
        Log.Info($"塔主回合：第 {Round} 回合结束（{reason}），剩余威胁点 {Session?.Points ?? 0}");
    }

    /// <summary>经过 seconds 秒；限时到了自动结束（面板每帧调用）。</summary>
    public static void Tick(double seconds)
    {
        if (!TurnOpen || _config.MasterTurnSeconds <= 0) return;
        SecondsLeft = Math.Max(0, SecondsLeft - seconds);
        if (SecondsLeft <= 0) EndTurn("超时");
    }

    public static bool Unlimited => _config.MasterTurnSeconds <= 0;
    public static int TotalSeconds => _config.MasterTurnSeconds;
    public static ThreatPrices Prices => _config.Threat;

    private static void CloseUi()
    {
        var ui = _ui;
        _ui = null;
        try { ui?.Close(); } catch (Exception e) { Log.Warn($"塔主回合：关闭面板失败：{e.Message}"); }
    }

    internal static void Send(ThreatCommand command)
    {
        var run = Test1bMixedEncounter.Run;
        var state = GameReflection.Get(run, "State")!;
        command = command with { Sequence = ++_sent, Seed = Convert.ToUInt64(GameReflection.Get(GameReflection.Get(state, "Rng")!, "Seed")) };
        var payload = Prefix + JsonSerializer.Serialize(command);
        var queue = GameReflection.Get(run, "ActionQueueSynchronizer") ?? throw new InvalidOperationException("找不到 ActionQueueSynchronizer");
        var owner = Test2MasterOffField.MasterId ?? throw new InvalidOperationException("不知道塔主是谁");
        RuntimeNetAction.Call(queue, "RequestEnqueue", RuntimeNetAction.Create(owner, payload));
    }

    // ---------------------------------------------------------------- 各端执行

    /// <summary>各端执行一条塔主指令（RuntimeNetAction.Execute 转过来）。目标对不上就跳过，各端结果一致。</summary>
    internal static async Task Execute(string payload, object action)
    {
        ThreatCommand command;
        try { command = JsonSerializer.Deserialize<ThreatCommand>(payload[Prefix.Length..]) ?? throw new JsonException("空指令"); }
        catch (Exception e) { Log.Warn($"塔主回合：看不懂指令（{e.Message}），跳过"); return; }

        var tag = $"塔主回合 #{command.Sequence} 第{command.Round}回合";
        try
        {
            switch (command.Op)
            {
                case "begin":
                    CallQueueSet("PauseAllPlayerQueues");
                    _pausedByUs = true;
                    if (!Test3MasterAutoPilot.LocalIsMaster) Banner(true);
                    Log.Info($"{tag}：开始，玩家暂停出牌");
                    break;
                case "end":
                    if (_pausedByUs) CallQueueSet("UnpauseAllPlayerQueues");
                    _pausedByUs = false;
                    Banner(false);
                    Log.Info($"{tag}：结束，玩家继续");
                    break;
                case "trap":
                    await ApplyTrap(command, action, tag);
                    MasterPresence.Cast();
                    break;
                case "trap_info":
                    Log.Info($"{tag}：塔主手里有 {command.Amount} 张陷阱");
                    if (!Test3MasterAutoPilot.LocalIsMaster) SummonPhase.Toast($"塔主手里有 {command.Amount} 张陷阱");
                    break;
                case "trap_dodge":
                    await DodgeReward(command, tag);
                    break;
                default:
                    await ApplyEffect(command, action, tag);
                    MasterPresence.Cast();
                    break;
            }
        }
        catch (Exception e) { Log.Error($"{tag}：执行 {command.Op} 失败", e); }
        finally
        {
            try { Applied?.Invoke(); } catch (Exception e) { Log.Warn($"塔主回合：刷新面板失败：{e.Message}"); }
        }
    }

    private static async Task ApplyEffect(ThreatCommand c, object action, string tag)
    {
        var combat = CombatState();
        if (combat == null) { Log.Info($"{tag}：已不在战斗中，跳过 {c.Op}"); return; }
        decimal amount = c.Amount;
        switch (c.Op)
        {
            case "block":
            case "heal":
            case "strength":
            {
                var creature = AliveEnemy(combat, c.Monster);
                if (creature == null || MonsterId(creature) != c.MonsterId)
                {
                    Log.Info($"{tag}：目标 {c.Monster}（{c.MonsterId}）已不在，跳过 {c.Op}");
                    return;
                }
                if (c.Op == "block") await GainBlock(creature, amount);
                else if (c.Op == "heal") await Heal(creature, amount);
                else await ApplyPower("StrengthPower", action, creature, amount);
                Log.Info($"{tag}：{OpName(c.Op)} {c.MonsterId}[{c.Monster}] {amount}");
                break;
            }
            case "strength_all":
                foreach (var index in c.Monsters ?? [])
                {
                    var creature = AliveEnemy(combat, index);
                    if (creature != null) await ApplyPower("StrengthPower", action, creature, amount);
                }
                Log.Info($"{tag}：全体力量 {amount} → [{string.Join(", ", c.Monsters ?? [])}]");
                break;
            case "weak":
            case "vulnerable":
            case "frail":
            case "dazed":
            {
                var creature = ClimberCreature(combat, c.Player);
                if (creature == null) { Log.Info($"{tag}：玩家 {c.Player} 已不在，跳过 {c.Op}"); return; }
                if (c.Op == "dazed") await AddDazed(creature);
                else await ApplyPower(c.Op switch { "weak" => "WeakPower", "vulnerable" => "VulnerablePower", _ => "FrailPower" }, action, creature, amount);
                Log.Info($"{tag}：{OpName(c.Op)} 玩家 {c.Player} {amount}");
                break;
            }
            default:
                Log.Warn($"{tag}：不认识的操作 {c.Op}，跳过");
                return;
        }
        if (!Test3MasterAutoPilot.LocalIsMaster) SummonPhase.Toast(c.MonsterId != null ? $"塔主：{NameOf(c.MonsterId)} {OpName(c.Op)}" : $"塔主：{OpName(c.Op)}");
    }

    // ---------------------------------------------------------------- 陷阱效果（各端）

    private static async Task ApplyTrap(ThreatCommand c, object action, string tag)
    {
        var card = TrapCatalog.Parse(c.MonsterId ?? "");
        if (!TrapCatalog.Exists(card.Id)) { Log.Warn($"{tag}：不认识的陷阱 {c.MonsterId}，跳过"); return; }
        var combat = CombatState();
        if (combat == null) { Log.Info($"{tag}：已不在战斗中，陷阱 {card} 跳过"); return; }
        var def = card.Def;
        var enemies = Enemies(combat).Where(Alive).ToList();
        var players = c.Player != 0
            ? new[] { ClimberCreature(combat, c.Player) }.Where(x => x != null).Cast<object>().ToList()
            : (GameReflection.Get(Test1bMixedEncounter.Run, "State") is { } state ? Climbers(state) : [])
                .Select(p => GameReflection.Get(p, "Creature")!).Where(Alive).ToList();
        decimal amount = c.Amount;
        switch (def.Effect)
        {
            case TrapEffect.BlockAllEnemies:
                foreach (var e in enemies) await GainBlock(e, amount);
                break;
            case TrapEffect.StrengthAllEnemies:
                foreach (var e in enemies) await ApplyPower("StrengthPower", action, e, amount);
                break;
            case TrapEffect.HealAllEnemiesPercent:
                foreach (var e in enemies) await Heal(e, Math.Max(1, Convert.ToInt32(GameReflection.Get(e, "MaxHp")) * c.Amount / 100));
                break;
            case TrapEffect.WeakPlayer:
            case TrapEffect.VulnerablePlayer:
            case TrapEffect.FrailPlayer:
                var power = def.Effect switch { TrapEffect.WeakPlayer => "WeakPower", TrapEffect.VulnerablePlayer => "VulnerablePower", _ => "FrailPower" };
                foreach (var p in players) await ApplyPower(power, action, p, amount);
                break;
            case TrapEffect.DazedPlayer:
                foreach (var p in players)
                    for (int i = 0; i < c.Amount; i++) await AddDazed(p);
                break;
        }
        Log.Info($"{tag}：陷阱 {card} 触发{(c.Player != 0 ? $"，玩家 {c.Player}" : "")}，数值 {c.Amount}");
        SummonPhase.Toast($"陷阱「{card.Name}」：{card.Def.ShortWhat(card.Tier)}");
    }

    /// <summary>躲过奖励：每名爬塔玩家 +金币（PlayerCmd.GainGold，各端同样执行）。</summary>
    private static async Task DodgeReward(ThreatCommand c, string tag)
    {
        var state = GameReflection.Get(Test1bMixedEncounter.Run, "State");
        if (state == null) return;
        var gain = Static("PlayerCmd", "GainGold", m => m.GetParameters().Length == 3 && m.GetParameters()[0].ParameterType == typeof(decimal));
        foreach (var p in Climbers(state))
            await (Task)gain.Invoke(null, [(decimal)c.Amount, p, false])!;
        Log.Info($"{tag}：躲过陷阱 {c.MonsterId}，每名玩家 +{c.Amount} 金币");
        SummonPhase.Toast($"躲过陷阱：{c.MonsterId} · 每人 +{c.Amount} 金币");
    }

    /// <summary>还有爬塔玩家活着、敌人都死了（或跑了）。</summary>
    private static bool Won()
    {
        var combat = CombatState();
        if (combat == null) return false;
        var state = GameReflection.Get(Test1bMixedEncounter.Run, "State");
        bool climberAlive = state != null && Climbers(state).Any(p => Alive(GameReflection.Get(p, "Creature")!));
        return climberAlive && !Enemies(combat).Any(Alive);
    }

    // ---------------------------------------------------------------- 原版命令（反射）

    private static Task GainBlock(object creature, decimal amount)
    {
        var method = Static("CreatureCmd", "GainBlock", m => m.GetParameters().Length == 5 && m.GetParameters()[1].ParameterType == typeof(decimal));
        var props = Enum.ToObject(method.GetParameters()[2].ParameterType, 0); // 普通格挡，照常受能力修正
        return (Task)method.Invoke(null, [creature, amount, props, null, false])!;
    }

    private static Task Heal(object creature, decimal amount)
    {
        var method = Static("CreatureCmd", "Heal", m => m.GetParameters().Length == 3 && m.GetParameters()[1].ParameterType == typeof(decimal));
        return (Task)method.Invoke(null, [creature, amount, true])!;
    }

    private static Task ApplyPower(string power, object action, object target, decimal amount)
    {
        var powerType = GameReflection.TypesNamed(power).FirstOrDefault(t => IsSubclassNamed(t, "PowerModel"))
                        ?? throw new TypeLoadException(power);
        var method = Static("PowerCmd", "Apply", m => m.IsGenericMethodDefinition && m.GetParameters().Length == 6
                                                      && m.GetParameters()[1].ParameterType.Name == "Creature").MakeGenericMethod(powerType);
        var context = Activator.CreateInstance(RuntimeNetAction.Required("GameActionPlayerChoiceContext"), action)!;
        return (Task)method.Invoke(null, [context, target, amount, null, null, false])!;
    }

    private static Task AddDazed(object target)
    {
        var card = GameReflection.TypesNamed("Dazed").FirstOrDefault(t => IsSubclassNamed(t, "CardModel")) ?? throw new TypeLoadException("Dazed");
        var method = Static("CardPileCmd", "AddToCombatAndPreview", m => m.IsGenericMethodDefinition && m.GetParameters().Length == 5
                                                                         && m.GetParameters()[0].ParameterType.Name == "Creature").MakeGenericMethod(card);
        var ps = method.GetParameters();
        return (Task)method.Invoke(null, [target, Enum.Parse(ps[1].ParameterType, "Draw"), 1, null, Enum.Parse(ps[4].ParameterType, "Random")])!;
    }

    private static MethodInfo Static(string type, string name, Func<MethodInfo, bool> match) =>
        RuntimeNetAction.Required(type).GetMethods(BindingFlags.Public | BindingFlags.Static).FirstOrDefault(m => m.Name == name && match(m))
        ?? throw new MissingMethodException(type, name);

    private static bool IsSubclassNamed(Type t, string baseName)
    {
        for (var b = t.BaseType; b != null; b = b.BaseType)
            if (b.Name == baseName) return true;
        return false;
    }

    private static void CallQueueSet(string method)
    {
        var set = GameReflection.Get(Test1bMixedEncounter.Run, "ActionQueueSet") ?? throw new InvalidOperationException("找不到 ActionQueueSet");
        RuntimeNetAction.Call(set, method);
    }

    // ---------------------------------------------------------------- 读战斗状态

    internal static object? CombatState()
    {
        var manager = RuntimeNetAction.Required("CombatManager").GetProperty("Instance", GameReflection.All)?.GetValue(null);
        return manager == null ? null : RuntimeNetAction.Call(manager, "DebugOnlyGetState");
    }

    private static List<object> Enemies(object combat) => (GameReflection.Get(combat, "Enemies") as IEnumerable)?.Cast<object>().ToList() ?? [];

    private static bool Alive(object creature) =>
        GameReflection.Get(creature, "IsDead") is not true && Convert.ToInt32(GameReflection.Get(creature, "CurrentHp")) > 0;

    private static object? AliveEnemy(object combat, int index)
    {
        var enemies = Enemies(combat);
        return index >= 0 && index < enemies.Count && Alive(enemies[index]) ? enemies[index] : null;
    }

    private static IEnumerable<int> AliveEnemyIndexes(object combat) =>
        Enemies(combat).Select((c, i) => (c, i)).Where(x => Alive(x.c)).Select(x => x.i);

    private static string? MonsterId(object creature) => GameReflection.Get(creature, "Monster")?.GetType().Name;

    private static List<object> Climbers(object state) =>
        (GameReflection.Get(state, "Players") as IEnumerable)?.Cast<object>()
        .Where(p => Test2MasterOffField.NetIdOf(p) != Test2MasterOffField.MasterId).ToList() ?? [];

    private static object? ClimberCreature(object combat, ulong player)
    {
        if (player == 0 || player == Test2MasterOffField.MasterId) return null;
        var state = GameReflection.Get(Test1bMixedEncounter.Run, "State");
        var p = state == null ? null : Climbers(state).FirstOrDefault(x => Test2MasterOffField.NetIdOf(x) == player);
        var creature = p == null ? null : GameReflection.Get(p, "Creature");
        return creature != null && Alive(creature) ? creature : null;
    }

    // ---------------------------------------------------------------- 给面板和测试接口的快照

    internal sealed record MonsterView(int Index, string Id, string Name, int Hp, int MaxHp, int Block, int Strength, int StrengthFromMaster, int HealsLeft);
    internal sealed record PlayerView(ulong NetId, int Hp, int MaxHp, int Block, IReadOnlyList<string> Hand, IReadOnlyList<string> Powers);

    internal static (List<MonsterView> Monsters, List<PlayerView> Players) Snapshot()
    {
        var combat = CombatState();
        if (combat == null) return ([], []);
        var monsters = Enemies(combat).Select((c, i) => (c, i)).Where(x => Alive(x.c)).Select(x =>
        {
            var id = MonsterId(x.c) ?? "?";
            return new MonsterView(x.i, id, NameOf(id), Int(x.c, "CurrentHp"), Int(x.c, "MaxHp"), Int(x.c, "Block"),
                PowerAmount(x.c, "StrengthPower"), Session?.StrengthOf(x.i) ?? 0, Session?.HealsLeft(x.i) ?? 0);
        }).ToList();
        var state = GameReflection.Get(Test1bMixedEncounter.Run, "State");
        var players = (state == null ? [] : Climbers(state)).Select(p =>
        {
            var creature = GameReflection.Get(p, "Creature")!;
            return new PlayerView(Test2MasterOffField.NetIdOf(p) ?? 0, Int(creature, "CurrentHp"), Int(creature, "MaxHp"), Int(creature, "Block"),
                Hand(p), Powers(creature));
        }).ToList();
        return (monsters, players);
    }

    private static int Int(object obj, string name)
    {
        try { return Convert.ToInt32(GameReflection.Get(obj, name) ?? 0); } catch { return 0; }
    }

    private static int PowerAmount(object creature, string power) =>
        (GameReflection.Get(creature, "Powers") as IEnumerable)?.Cast<object>().Where(p => p.GetType().Name == power).Sum(p => Int(p, "Amount")) ?? 0;

    private static IReadOnlyList<string> Powers(object creature) =>
        (GameReflection.Get(creature, "Powers") as IEnumerable)?.Cast<object>()
        .Select(p => $"{PowerName(p.GetType().Name)} {Int(p, "Amount")}").ToList() ?? [];

    private static string PowerName(string type) => type switch
    {
        "WeakPower" => "虚弱",
        "VulnerablePower" => "易伤",
        "FrailPower" => "脆弱",
        "StrengthPower" => "力量",
        _ => type.EndsWith("Power") ? type[..^5] : type,
    };

    /// <summary>玩家手牌（PlayerCombatState.Hand.Cards 的 Title）。</summary>
    private static IReadOnlyList<string> Hand(object player)
    {
        try
        {
            var hand = GameReflection.Get(GameReflection.Get(player, "PlayerCombatState")!, "Hand")!;
            return (GameReflection.Get(hand, "Cards") as IEnumerable)!.Cast<object>()
                .Select(c => GameReflection.Get(c, "Title")?.ToString() ?? c.GetType().Name).ToList();
        }
        catch { return []; }
    }

    internal static string NameOf(string monsterId)
    {
        if (_prices == null) return monsterId;
        if (_prices.AllMonsters.TryGetValue(monsterId, out var m)) return m.NameZh;
        foreach (var act in _prices.Acts.Values)
            if (act.Monsters.TryGetValue(monsterId, out var local)) return local.NameZh;
        return monsterId;
    }

    internal static string OpName(string op) => op switch
    {
        "block" => "加格挡",
        "heal" => "回血",
        "strength" => "加力量",
        "strength_all" => "全体加力量",
        "weak" => "虚弱",
        "vulnerable" => "易伤",
        "frail" => "脆弱",
        "dazed" => "塞眩晕",
        _ => op,
    };

    internal static string Describe(ThreatViolation v) => v switch
    {
        ThreatViolation.NotEnoughThreat => "威胁点不够",
        ThreatViolation.HealLimit => "这只怪本场回血次数用完了",
        ThreatViolation.DebuffLimit => "这名玩家本回合已经上过减益",
        ThreatViolation.DazedLimit => "本场塞眩晕次数用完了",
        ThreatViolation.StrengthCap => "这只怪的力量到上限了",
        ThreatViolation.StrengthAllLimit => "全体加力量本场已经用过",
        ThreatViolation.NoTarget => "没有能加力量的怪",
        _ => v.ToString(),
    };
}
