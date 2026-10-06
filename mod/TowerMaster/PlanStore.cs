using System.Text.Json;

namespace TowerMaster;

/// <summary>
/// 把已经用于替换的召唤清单按「种子 + 进房楼层」记到本地文件，读档或重开战斗时找回混搭。
/// 各客户端都在同一个时刻（替换遭遇时）写入同一份清单，所以正常情况下各家文件一致。
/// 只保留当前这局（同一种子）的清单。
/// </summary>
internal static class PlanStore
{
    private static readonly object Lock = new();

    /// <summary>同机双实例时跟着各自的日志文件走，避免两个实例写同一个文件。</summary>
    public static string FilePath => Log.FilePath != null && Environment.GetEnvironmentVariable("TOWERMASTER_LOG_FILE") != null
        ? Path.ChangeExtension(Log.FilePath, ".plans.json")
        : Path.Combine(Log.ModDir, "towermaster.plans.json");

    private static string Key(ulong seed, int floor) => $"{seed}:{floor}";

    public static void Save(SummonPlan plan)
    {
        lock (Lock)
        {
            try
            {
                var plans = Read().Where(p => p.Value.Seed == plan.Seed).ToDictionary();
                plans[Key(plan.Seed, plan.SourceFloor + 1)] = plan;
                var temp = FilePath + ".tmp";
                File.WriteAllText(temp, JsonSerializer.Serialize(plans));
                File.Move(temp, FilePath, overwrite: true);
            }
            catch (Exception e)
            {
                Log.Warn($"测试1b：保存召唤清单失败，读档后这一场会变回载体遭遇：{e.Message}");
            }
        }
    }

    /// <summary>按进房后的楼层找清单。</summary>
    public static SummonPlan? Find(ulong seed, int enteredFloor)
    {
        lock (Lock)
        {
            return Read().GetValueOrDefault(Key(seed, enteredFloor));
        }
    }

    public static void Clear()
    {
        lock (Lock)
        {
            try { File.Delete(FilePath); } catch { /* 没有就算了 */ }
        }
    }

    private static Dictionary<string, SummonPlan> Read()
    {
        try
        {
            return File.Exists(FilePath)
                ? JsonSerializer.Deserialize<Dictionary<string, SummonPlan>>(File.ReadAllText(FilePath)) ?? new()
                : new();
        }
        catch (Exception e)
        {
            Log.Warn($"测试1b：召唤清单文件损坏，忽略：{e.Message}");
            return new();
        }
    }
}
