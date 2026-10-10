using System.Collections;
using System.Text.Json;
using TowerMaster.Core;

namespace TowerMaster;

/// <summary>
/// 平衡数据（设计文档「从第一版就记日志」）：塔主（房主）这边每打完一场战斗，往
/// 「日志文件名.balance.jsonl」（默认 mod 目录 towermaster.balance.jsonl）追加一行 JSON。字段说明见 docs/balance-plan.md。
/// 只记录，不影响游戏；写失败只打 WARN。
/// </summary>
internal static class BalanceLog
{
    private sealed class Battle
    {
        public string? Time { get; set; }
        public string? Seed { get; set; }
        public string? Act { get; set; }
        public int ActNo { get; set; }
        public int Floor { get; set; }
        public int BattleIndex { get; set; }
        public string Room { get; set; } = "Monster";
        public int Climbers { get; set; }
        public bool OpeningProtected { get; set; }
        public string Summon { get; set; } = "none"; // confirmed / vanilla / none（「?」房等没有召唤）
        public string? Encounter { get; set; }
        public List<string> Monsters { get; set; } = new();
        public List<string> Spawned { get; set; } = new();
        public int SpawnedHp { get; set; }
        public int StandardCost { get; set; }
        public int MonsterSpend { get; set; }
        public int TrapCost { get; set; }
        public int PointsBefore { get; set; }
        public int PointsAfterSummon { get; set; }
        public List<string> TrapsPlaced { get; set; } = new();
        public List<string> TrapsFired { get; set; } = new();
        public List<string> TrapsDodged { get; set; } = new();
        public int ThreatAllotted { get; set; }
        public int ThreatSpent { get; set; }
        public Dictionary<string, int> ThreatOps { get; set; } = new();
        public int Rounds { get; set; }
        public string Result { get; set; } = "?";
        public Dictionary<string, int> HpStart { get; set; } = new();
        public Dictionary<string, int> HpEnd { get; set; } = new();
        public Dictionary<string, int> MaxHp { get; set; } = new();
        public int DamageTaken { get; set; }
        public List<string> KnockedDown { get; set; } = new();
        public int Income { get; set; }
        public int IncomeWasted { get; set; }
        public int PointsAfterBattle { get; set; }
    }

    private static Battle? _current;
    private static readonly JsonSerializerOptions Json = new() { PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower };

    public static string FilePath => Environment.GetEnvironmentVariable("TOWERMASTER_LOG_FILE") is { } log
        ? Path.ChangeExtension(log, ".balance.jsonl")
        : Path.Combine(Log.ModDir, "towermaster.balance.jsonl");

    private static Battle Current => _current ??= new Battle();

    /// <summary>召唤结束（确认或按原版）。</summary>
    public static void Summoned(SummonSession session, int pointsBefore, int pointsAfter)
    {
        _current = new Battle
        {
            Room = session.Room.Room.ToString(),
            Climbers = session.Room.Climbers,
            OpeningProtected = session.IsOpeningProtected,
            Summon = session.Confirmed ? "confirmed" : "vanilla",
            Encounter = session.Room.Room == RoomKind.Boss ? session.Encounter : null,
            Monsters = session.Confirmed ? session.Monsters.ToList() : new(),
            StandardCost = session.Room.StandardCostOverride ?? 0,
            MonsterSpend = session.Charge.MonsterSpend,
            TrapCost = session.Confirmed ? session.Quote.TrapCost : 0,
            PointsBefore = pointsBefore,
            PointsAfterSummon = pointsAfter,
            TrapsPlaced = session.Confirmed ? session.SelectedTraps.Select(i => session.TrapHand[i].ToString()).ToList() : new(),
        };
    }

    /// <summary>战斗开始：本场实际怪物、威胁点。</summary>
    public static void CombatStarted(object state, object? combat, int threat)
    {
        var b = Current;
        b.Seed = Try(() => Convert.ToUInt64(GameReflection.Get(GameReflection.Get(state, "Rng")!, "Seed")).ToString());
        b.Act = Try(() => GameReflection.Get(state, "Act")?.GetType().Name);
        b.Floor = Try(() => Convert.ToInt32(GameReflection.Get(state, "TotalFloor"))) ;
        b.ThreatAllotted = threat;
        b.Time = DateTime.Now.ToString("s");
    }

    public static void ThreatUsed(string op, int cost)
    {
        Current.ThreatSpent += cost;
        Current.ThreatOps[op] = Current.ThreatOps.GetValueOrDefault(op) + 1;
    }

    public static void TrapFired(TrapCard card) => Current.TrapsFired.Add(card.ToString());

    public static void TrapsDodged(IEnumerable<TrapCard> cards) => Current.TrapsDodged.AddRange(cards.Select(c => c.ToString()));

    /// <summary>回合数：每个玩家回合开始时更新。</summary>
    public static void Round(int round) => Current.Rounds = Math.Max(Current.Rounds, round);

    /// <summary>战斗结束（胜或负）时写一行。spawned 在胜利时可能已经全死，所以开战时也可以先记（见 <see cref="Spawned"/>）。</summary>
    public static void Finish(bool won, int actNo, int battleIndex, IReadOnlyDictionary<ulong, int> hpStart, IEnumerable<object> climbers,
        IEnumerable<ulong> knocked, int damage, IncomeBreakdown? income, int pointsAfter)
    {
        var b = Current;
        _current = null;
        try
        {
            b.Result = won ? "won" : "lost";
            b.ActNo = actNo;
            b.BattleIndex = battleIndex;
            foreach (var (id, hp) in hpStart) b.HpStart[id.ToString()] = hp;
            foreach (var p in climbers)
            {
                var id = Test2MasterOffField.NetIdOf(p)?.ToString() ?? "?";
                var creature = GameReflection.Get(p, "Creature");
                if (creature == null) continue;
                b.HpEnd[id] = Convert.ToInt32(GameReflection.Get(creature, "CurrentHp"));
                b.MaxHp[id] = Convert.ToInt32(GameReflection.Get(creature, "MaxHp"));
            }
            b.KnockedDown = knocked.Select(k => k.ToString()).ToList();
            b.DamageTaken = damage;
            b.Income = income?.Credited ?? 0;
            b.IncomeWasted = income?.Wasted ?? 0;
            b.PointsAfterBattle = pointsAfter;
            File.AppendAllText(FilePath, JsonSerializer.Serialize(b, Json) + "\n");
        }
        catch (Exception e) { Log.Warn($"平衡记录：写入失败：{e.Message}"); }
    }

    /// <summary>开战时本场生成的怪和总血量。</summary>
    public static void Spawned(object combat)
    {
        try
        {
            var enemies = (GameReflection.Get(combat, "Enemies") as IEnumerable)?.Cast<object>().ToList() ?? [];
            Current.Spawned = enemies.Select(e => GameReflection.Get(e, "Monster")?.GetType().Name ?? "?").ToList();
            Current.SpawnedHp = enemies.Sum(e => Convert.ToInt32(GameReflection.Get(e, "MaxHp") ?? 0));
        }
        catch { /* 只是记录 */ }
    }

    private static T? Try<T>(Func<T> get)
    {
        try { return get(); } catch { return default; }
    }
}
