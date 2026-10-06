using System.Text.Json;
using TowerMaster.Core;

namespace TowerMaster;

/// <summary>本场战斗的召唤记录，结算收入时用。</summary>
internal sealed record PendingBattle(RoomKind Room, int StandardCost, int MonsterSpend);

/// <summary>
/// 塔主的账本：召唤点钱包、本局已打场数，只在塔主（房主）这台电脑上维护，按局（种子）存到本地文件，读档后继续。
/// 爬塔玩家看不到余额（设计文档「信息规则」），所以不需要同步给客户端。
/// </summary>
internal static class MasterLedger
{
    private sealed record Saved(ulong Seed, int Points, int ActNo, ulong[] KnockedDown, int Battles);

    private static TowerMasterConfig _config = new();
    private static ulong _seed;

    public static SummonWallet? Wallet { get; private set; }
    public static int BattlesFought { get; private set; }
    public static PendingBattle? Pending { get; set; }

    public static string FilePath => Environment.GetEnvironmentVariable("TOWERMASTER_LOG_FILE") is { } log
        ? Path.ChangeExtension(log, ".master.json")
        : Path.Combine(Log.ModDir, "towermaster.master.json");

    public static void Configure(TowerMasterConfig config)
    {
        _config = config;
        Wallet = null;
        _seed = 0;
        BattlesFought = 0;
        Pending = null;
    }

    /// <summary>取当前这局的钱包：换了局就从文件读，没有就新开；进入新一幕时按新上限截断。</summary>
    public static SummonWallet For(ulong seed, int actNo)
    {
        if (Wallet == null || seed != _seed)
        {
            _seed = seed;
            Pending = null;
            var saved = Load();
            Wallet = new SummonWallet(_config, actNo);
            BattlesFought = 0;
            if (saved != null && saved.Seed == seed)
            {
                Wallet.Restore(saved.Points, saved.ActNo, saved.KnockedDown);
                BattlesFought = saved.Battles;
                Log.Info($"塔主账本：读档，召唤点 {Wallet.Points}，已打 {BattlesFought} 场");
            }
            else Log.Info($"塔主账本：新的一局，召唤点 {Wallet.Points}");
        }
        if (actNo > Wallet.ActNo)
        {
            int wasted = Wallet.EnterAct(actNo);
            Log.Info($"塔主账本：进入第 {actNo} 幕，上限 {Wallet.Cap}{(wasted > 0 ? $"，作废 {wasted}" : "")}");
            Save();
        }
        return Wallet;
    }

    public static void CountBattle() => BattlesFought++;

    public static void Save()
    {
        if (Wallet == null) return;
        try
        {
            var saved = new Saved(_seed, Wallet.Points, Wallet.ActNo, Wallet.KnockedDownLastBattle.ToArray(), BattlesFought);
            var temp = FilePath + ".tmp";
            File.WriteAllText(temp, JsonSerializer.Serialize(saved));
            File.Move(temp, FilePath, overwrite: true);
        }
        catch (Exception e)
        {
            Log.Warn($"塔主账本：保存失败（读档后召唤点会回到上次保存的值）：{e.Message}");
        }
    }

    private static Saved? Load()
    {
        try { return File.Exists(FilePath) ? JsonSerializer.Deserialize<Saved>(File.ReadAllText(FilePath)) : null; }
        catch (Exception e) { Log.Warn($"塔主账本：文件损坏，重新开始：{e.Message}"); return null; }
    }

    public static void Clear()
    {
        try { File.Delete(FilePath); } catch { /* 没有就算了 */ }
        Configure(_config);
    }
}
