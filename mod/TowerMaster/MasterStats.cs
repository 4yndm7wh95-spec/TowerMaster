using System.Text.Json;
using TowerMaster.Core;

namespace TowerMaster;

/// <summary>
/// 塔主战报要用的记录：触发过的陷阱、打出的塔主牌。各端执行同一条指令/同一张牌时各自记一笔（所以各端一样），
/// 按种子存到本地文件，读档、重开游戏后还在；换一局（种子不同）就重新记。召唤和 Boss 从 <see cref="PlanStore"/> 的清单里读。
/// </summary>
internal static class MasterStats
{
    private sealed record Saved(ulong Seed, List<string> Traps, List<string> Cards);

    private static readonly object Lock = new();

    /// <summary>同机双实例时跟着各自的日志文件走。</summary>
    public static string FilePath => Log.FilePath != null && Environment.GetEnvironmentVariable("TOWERMASTER_LOG_FILE") != null
        ? Path.ChangeExtension(Log.FilePath, ".stats.json")
        : Path.Combine(Log.ModDir, "towermaster.stats.json");

    internal static void RecordTrap(string name) => Record(s => s.Traps.Add(name));
    internal static void RecordCard(string title) => Record(s => s.Cards.Add(title));

    private static void Record(Action<Saved> add)
    {
        try
        {
            if (GameReflection.Get(Test1bMixedEncounter.Run, "State") is not { } state) return;
            ulong seed = SummonPhase.Seed(state);
            lock (Lock)
            {
                var saved = Read();
                if (saved == null || saved.Seed != seed) saved = new Saved(seed, [], []);
                add(saved);
                var temp = FilePath + ".tmp";
                File.WriteAllText(temp, JsonSerializer.Serialize(saved));
                File.Move(temp, FilePath, overwrite: true);
            }
        }
        catch (Exception e) { Log.Warn($"塔主战报：记录失败（不影响游戏）：{e.Message}"); }
    }

    private static Saved? Read()
    {
        try { return File.Exists(FilePath) ? JsonSerializer.Deserialize<Saved>(File.ReadAllText(FilePath)) : null; }
        catch { return null; }
    }

    /// <summary>凑出这一局的战报数据。masterWon 不给就按「爬塔玩家是不是全死了」判断。</summary>
    internal static RunReportInput Collect(object state, bool? masterWon = null)
    {
        ulong seed = SummonPhase.Seed(state);
        Saved? saved;
        lock (Lock) saved = Read();
        if (saved?.Seed != seed) saved = new Saved(seed, [], []);
        var plans = PlanStore.All(seed);
        var prices = ModEntry.Prices;
        string MonsterName(string id) => prices?.Acts.Values.Select(a => a.Monsters.GetValueOrDefault(id)?.NameZh).FirstOrDefault(n => !string.IsNullOrEmpty(n)) ?? id;
        string EncounterName(string id) => prices?.Acts.Values.Select(a => a.Encounters.GetValueOrDefault(id)?.NameZh).FirstOrDefault(n => !string.IsNullOrEmpty(n)) ?? id;
        bool won = masterWon ?? ClimbersAllDead(state);
        return new RunReportInput(won, Convert.ToInt32(GameReflection.Get(state, "TotalFloor") ?? 0), plans.Count,
            plans.SelectMany(p => p.Monsters).Select(MonsterName).ToList(),
            plans.Where(p => p.Encounter != null && prices?.Acts.Values.Any(a => a.Encounters.TryGetValue(p.Encounter!, out var e) && e.Room == RoomKind.Boss) == true)
                .Select(p => EncounterName(p.Encounter!)).ToList(),
            saved.Traps, saved.Cards);
    }

    private static bool ClimbersAllDead(object state)
    {
        var climbers = (GameReflection.Get(state, "Players") as System.Collections.IEnumerable)?.Cast<object>()
            .Where(p => Test2MasterOffField.NetIdOf(p) != Test2MasterOffField.MasterId).ToList() ?? [];
        return climbers.Count > 0 && climbers.All(p => GameReflection.Get(p, "Creature") is not { } c
                                                         || GameReflection.Get(c, "IsDead") is true || Convert.ToInt32(GameReflection.Get(c, "CurrentHp") ?? 0) <= 0);
    }
}
