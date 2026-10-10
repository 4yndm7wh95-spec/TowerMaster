using System.Collections;
using HarmonyLib;
using TowerMaster.Core;

namespace TowerMaster;

/// <summary>每幕一次的自由选陷阱（包着规则库的 <see cref="TrapDraft"/>，加上界面要用的事件）。</summary>
internal sealed class TrapDraftChoice(TrapDraft draft)
{
    public TrapDraft Draft { get; } = draft;
    public bool Done => Draft.Done;
    public event Action? Changed;
    public event Action<IReadOnlyList<TrapCard>>? Confirmed;

    public bool Toggle(int index)
    {
        bool changed = Draft.Toggle(index);
        if (changed) Changed?.Invoke();
        return changed;
    }

    /// <summary>整份替换选择（测试接口用）。有不能选的就整份不改，返回 false。</summary>
    public bool Set(IReadOnlyList<int> picks)
    {
        var before = Draft.Picked.ToList();
        foreach (var i in before) Draft.Toggle(i);
        foreach (var i in picks.Distinct())
        {
            if (Draft.Toggle(i)) continue;
            foreach (var j in Draft.Picked.ToList()) Draft.Toggle(j);
            foreach (var j in before) Draft.Toggle(j);
            return false;
        }
        Changed?.Invoke();
        return true;
    }

    public bool Confirm()
    {
        if (Draft.Done || Draft.Problems.Count > 0) return false;
        Confirmed?.Invoke(Draft.Confirm());
        return true;
    }
}

/// <summary>
/// 陷阱（设计文档「陷阱牌」）。只有房主知道盖了什么：
/// 召唤确认时从手里拿走（<see cref="Place"/>），战斗开始时布置（<see cref="CombatSetUp"/>），
/// 房主看到触发条件满足（回合开始、玩家出牌、敌人死亡）就经塔主回合的联机通道发一条 trap 指令，各端施加效果。
/// 战斗胜利后没触发的陷阱翻开、收回手里，每张（空陷阱除外）给每名爬塔玩家 10 金币（trap_dodge 指令，各端用 PlayerCmd.GainGold）。
/// 第 1 回合公开本场盖了几张（不公开是什么），空陷阱靠这个起诈唬作用。
/// 击倒奖励从本幕牌池抽 1 张。
/// </summary>
internal static class TrapPhase
{
    private static List<TrapCard> _pending = new();
    private static int _placed;
    private static int _handLeft;
    private static bool _infoSent;
    private static bool _patched;
    private static readonly List<TrapFire> Deferred = new();

    /// <summary>本场布置的陷阱（房主）。</summary>
    public static TrapTracker? Tracker { get; private set; }

    internal static void Apply(Harmony harmony)
    {
        Reset();
        if (_patched) return;
        _patched = true;
        var hook = GameReflection.TypesNamed("Hook").SelectMany(t => t.GetMethods(GameReflection.All))
            .FirstOrDefault(m => m.IsStatic && m.Name == "AfterCardPlayed" && m.GetParameters().Any(p => p.ParameterType.Name == "CardPlay"));
        if (hook == null) { Log.Warn("陷阱：找不到 Hook.AfterCardPlayed，出牌类陷阱不会触发"); return; }
        harmony.Patch(hook, postfix: new HarmonyMethod(typeof(TrapPhase).GetMethod(nameof(AfterCardPlayed), GameReflection.All)!));
        Log.Info($"陷阱：已挂到 {GameReflection.Describe(hook)}");
    }

    internal static void Reset()
    {
        _pending = new();
        _placed = 0;
        _handLeft = 0;
        _infoSent = false;
        Known.Clear();
        CountedDead.Clear();
        Tracker = null;
        Deferred.Clear();
    }

    /// <summary>召唤结束时（房主）：这场要盖的陷阱，以及塔主手里还剩几张。</summary>
    internal static void Place(IReadOnlyList<TrapCard> cards, int handLeft)
    {
        _pending = cards.ToList();
        _placed = cards.Count;
        _handLeft = handLeft;
        MasterLedger.SetLastPlaced(cards.Select(c => c.Id));
        if (cards.Count > 0) Log.Info($"塔主陷阱：盖下 {string.Join("、", cards.Select(c => c.Name))}（只有塔主知道）");
    }

    /// <summary>战斗开始（房主）：布置陷阱。</summary>
    internal static void CombatSetUp()
    {
        Tracker = new TrapTracker(_pending);
        _pending = new();
        _infoSent = false;
        Known.Clear();
        CountedDead.Clear();
        Deferred.Clear();
    }

    // ---------------------------------------------------------------- 触发（房主）

    /// <summary>玩家回合开始（房主，在塔主回合开始之前调用，这样陷阱指令排在 begin 前面）。</summary>
    internal static void RoundStarted(int round)
    {
        if (Tracker == null) return;
        if (!_infoSent)
        {
            _infoSent = true;
            if (_placed + _handLeft > 0) ThreatPhase.Send(new ThreatCommand(1, 0, 0, round, "trap_info", Monster: _handLeft, Amount: _placed));
        }
        CheckDeaths(round);
        Fire(Tracker.RoundStarted(round), round);
    }

    private static void AfterCardPlayed(object[] __args)
    {
        try
        {
            if (Tracker == null || !Test3MasterAutoPilot.LocalIsMaster) return;
            var play = __args.FirstOrDefault(a => a?.GetType().Name == "CardPlay");
            if (play == null) return;
            if (GameReflection.Get(play, "IsFirstInSeries") is false) return; // 同一张牌重复打出只算一次
            var player = Test2MasterOffField.NetIdOf(GameReflection.Get(play, "Player"));
            if (player == null || player == Test2MasterOffField.MasterId) return;
            var type = GameReflection.Get(GameReflection.Get(play, "Card")!, "Type")?.ToString();
            CheckDeaths(ThreatPhase.Round);
            Fire(Tracker.CardPlayed(player.Value, type == "Attack", type == "Skill"), ThreatPhase.Round);
        }
        catch (Exception e) { Log.Warn($"陷阱：处理出牌失败：{e.Message}"); }
    }

    private static readonly List<object> Known = new();
    private static readonly HashSet<object> CountedDead = new(ReferenceEqualityComparer.Instance);

    /// <summary>
    /// 有新死的敌人、而且还有活着的敌人：触发「敌人死亡」陷阱（每只死亡一次）。
    /// 原版死掉的怪会从 CombatState.Enemies 里移除（0.0.22 实测狂怒因此没触发），所以记住见过的每只怪：
    /// 列表里没了（又不在逃跑名单里）或标记死亡，都算死了。
    /// </summary>
    private static void CheckDeaths(int round)
    {
        if (Tracker == null || ThreatPhase.CombatState() is not { } combat) return;
        var enemies = (GameReflection.Get(combat, "Enemies") as IEnumerable)?.Cast<object>().ToList() ?? [];
        var escaped = (GameReflection.Get(combat, "EscapedCreatures") as IEnumerable)?.Cast<object>().ToHashSet(ReferenceEqualityComparer.Instance)
                      ?? new HashSet<object>(ReferenceEqualityComparer.Instance);
        foreach (var e in enemies)
            if (!Known.Any(k => ReferenceEquals(k, e))) Known.Add(e);
        bool anyAlive = enemies.Any(e => GameReflection.Get(e, "IsDead") is not true);
        foreach (var k in Known)
        {
            if (CountedDead.Contains(k) || escaped.Contains(k)) continue;
            bool gone = !enemies.Any(e => ReferenceEquals(e, k));
            if (!gone && GameReflection.Get(k, "IsDead") is not true) continue;
            CountedDead.Add(k);
            if (anyAlive) Fire(Tracker.EnemyDied(), round);
        }
    }

    private static void Fire(IReadOnlyList<TrapFire> fires, int round)
    {
        foreach (var fire in fires)
        {
            Log.Info($"塔主陷阱：{fire.Card.Name} 触发（{fire.Card.Describe()}）{(fire.Player != 0 ? $"，玩家 {fire.Player}" : "")}");
            BalanceLog.TrapFired(fire.Card);
            if (ThreatPhase.TurnOpen) Deferred.Add(fire); // 塔主回合里玩家队列暂停着，等塔主回合结束再发（指令要排在 end 后面）
            else ThreatPhase.Send(ThreatPhase.TrapCommand(fire.Card, fire.Player, round));
        }
    }

    /// <summary>塔主回合结束后（end 已入队）补发期间触发的陷阱。</summary>
    internal static void Flush()
    {
        var fires = Deferred.ToList();
        Deferred.Clear();
        foreach (var fire in fires)
            ThreatPhase.Send(ThreatPhase.TrapCommand(fire.Card, fire.Player, ThreatPhase.Round));
    }

    // ---------------------------------------------------------------- 战斗结束（房主）

    /// <summary>
    /// 战斗结束（房主）。赢了：没触发的陷阱翻开、收回手里，发躲过奖励；没赢：只收回。
    /// CombatWon 和 CombatEnded 都会调，先到的那次处理，第二次 Tracker 已清空。
    /// </summary>
    internal static void Finish(bool won, TowerMasterConfig config)
    {
        var tracker = Tracker;
        Tracker = null;
        Deferred.Clear();
        if (tracker == null || tracker.Placed.Count == 0) return;
        var unfired = tracker.Unfired;
        Log.Info($"塔主陷阱：战斗{(won ? "胜利" : "结束")}，触发 {tracker.FiredCount} 张，没触发 {unfired.Count} 张");
        if (unfired.Count == 0) return;
        MasterLedger.AddTraps(unfired, "没触发的陷阱收回");
        if (!won) return;
        BalanceLog.TrapsDodged(unfired);
        int dodged = unfired.Count(c => c.Def.Effect != TrapEffect.None); // 空陷阱翻开不给金币
        int gold = config.DodgeRewardGold * dodged;
        if (MasterRelics.Has("stingy_purse")) gold /= 2; // 塔主遗物「吝啬鬼钱包」
        ThreatPhase.Send(new ThreatCommand(1, 0, 0, ThreatPhase.Round, "trap_dodge",
            MonsterId: string.Join("、", unfired.Select(c => c.Name)), Amount: gold));
    }

    /// <summary>击倒奖励：每名被击倒（且有奖励）的玩家，从本幕牌池抽 1 张手里没有的（手满就不给）。</summary>
    internal static void KnockdownReward(int count, int actNo, ulong seed, int battle, int handLimit)
    {
        if (count <= 0) return;
        var rng = new Random(unchecked((int)(seed ^ (ulong)(battle * 7919 + 17))));
        var gained = new List<TrapCard>();
        for (int i = 0; i < count; i++)
        {
            var pool = TrapCatalog.PoolFor(actNo).Where(c => MasterLedger.Traps.Concat(gained).All(h => h.Id != c.Id)).ToList();
            if (pool.Count == 0 || MasterLedger.Traps.Count + gained.Count >= handLimit) break;
            gained.Add(pool[rng.Next(pool.Count)]);
        }
        if (gained.Count > 0) MasterLedger.AddTraps(gained, "击倒奖励");
    }
}
