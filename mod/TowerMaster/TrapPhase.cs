using System.Collections;
using HarmonyLib;
using TowerMaster.Core;

namespace TowerMaster;

/// <summary>每幕一次的陷阱包选择（3 选 1）。</summary>
internal sealed class TrapPackChoice(int actNo, IReadOnlyList<TrapPack> packs)
{
    public int ActNo { get; } = actNo;
    public IReadOnlyList<TrapPack> Packs { get; } = packs;
    public bool Done { get; private set; }
    public event Action<TrapPack>? Picked;

    public void Pick(int index)
    {
        if (Done || index < 0 || index >= Packs.Count) return;
        Done = true;
        Picked?.Invoke(Packs[index]);
    }
}

/// <summary>
/// 陷阱（设计文档「陷阱牌」）。只有房主知道盖了什么：
/// 召唤确认时从手里拿走（<see cref="Place"/>），战斗开始时布置（<see cref="CombatSetUp"/>），
/// 房主看到触发条件满足（回合开始、玩家出牌、敌人死亡）就经塔主回合的联机通道发一条 trap 指令，各端施加效果。
/// 战斗胜利后没触发的陷阱翻开、收回手里，每张给每名爬塔玩家 15 金币（trap_dodge 指令，各端用 PlayerCmd.GainGold）。
/// 击倒奖励从本幕牌池抽 1 张。
/// </summary>
internal static class TrapPhase
{
    private static List<TrapCard> _pending = new();
    private static int _handAtEntry;
    private static bool _infoSent;
    private static int _deadSeen;
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
        _handAtEntry = 0;
        _infoSent = false;
        _deadSeen = 0;
        Tracker = null;
        Deferred.Clear();
    }

    /// <summary>召唤结束时（房主）：这场要盖的陷阱，以及塔主手里还剩几张。</summary>
    internal static void Place(IReadOnlyList<TrapCard> cards, int handLeft)
    {
        _pending = cards.ToList();
        _handAtEntry = handLeft + cards.Count;
        if (cards.Count > 0) Log.Info($"塔主陷阱：盖下 {string.Join("、", cards.Select(c => c.Name))}（只有塔主知道）");
    }

    /// <summary>战斗开始（房主）：布置陷阱。</summary>
    internal static void CombatSetUp()
    {
        Tracker = new TrapTracker(_pending);
        _pending = new();
        _infoSent = false;
        _deadSeen = 0;
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
            if (_handAtEntry > 0) ThreatPhase.Send(new ThreatCommand(1, 0, 0, round, "trap_info", Amount: _handAtEntry));
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

    /// <summary>有新死的敌人、而且还有活着的敌人：触发「敌人死亡」陷阱（每只死亡一次）。</summary>
    private static void CheckDeaths(int round)
    {
        if (Tracker == null || ThreatPhase.CombatState() is not { } combat) return;
        var enemies = (GameReflection.Get(combat, "Enemies") as IEnumerable)?.Cast<object>().ToList() ?? [];
        int dead = enemies.Count(e => GameReflection.Get(e, "IsDead") is true);
        bool anyAlive = enemies.Any(e => GameReflection.Get(e, "IsDead") is not true);
        for (; _deadSeen < dead; _deadSeen++)
            if (anyAlive) Fire(Tracker.EnemyDied(), round);
    }

    private static void Fire(IReadOnlyList<TrapFire> fires, int round)
    {
        foreach (var fire in fires)
        {
            Log.Info($"塔主陷阱：{fire.Card.Name} 触发（{fire.Card.Describe()}）{(fire.Player != 0 ? $"，玩家 {fire.Player}" : "")}");
            var command = new ThreatCommand(1, 0, 0, round, "trap", MonsterId: fire.Card.ToString(), Player: fire.Player,
                Amount: fire.Card.Def.Amount(fire.Card.Tier));
            if (ThreatPhase.TurnOpen) Deferred.Add(fire); // 塔主回合里玩家队列暂停着，等塔主回合结束再发（指令要排在 end 后面）
            else ThreatPhase.Send(command);
        }
    }

    /// <summary>塔主回合结束后（end 已入队）补发期间触发的陷阱。</summary>
    internal static void Flush()
    {
        var fires = Deferred.ToList();
        Deferred.Clear();
        foreach (var fire in fires)
            ThreatPhase.Send(new ThreatCommand(1, 0, 0, ThreatPhase.Round, "trap", MonsterId: fire.Card.ToString(), Player: fire.Player,
                Amount: fire.Card.Def.Amount(fire.Card.Tier)));
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
        ThreatPhase.Send(new ThreatCommand(1, 0, 0, ThreatPhase.Round, "trap_dodge",
            MonsterId: string.Join("、", unfired.Select(c => c.Name)), Amount: config.DodgeRewardGold * unfired.Count));
    }

    /// <summary>击倒奖励：每名被击倒（且有奖励）的玩家，从本幕牌池抽 1 张。</summary>
    internal static void KnockdownReward(int count, int actNo, ulong seed, int battle)
    {
        if (count <= 0) return;
        var pool = TrapCatalog.PoolFor(actNo);
        var rng = new Random(unchecked((int)(seed ^ (ulong)(battle * 7919 + 17))));
        MasterLedger.AddTraps(Enumerable.Range(0, count).Select(_ => pool[rng.Next(pool.Count)]), "击倒奖励");
    }
}
