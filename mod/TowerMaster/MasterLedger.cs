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
    private sealed record Saved(ulong Seed, int Points, int ActNo, ulong[] KnockedDown, int Battles,
        string[]? Traps = null, int[]? PacksPicked = null, string[]? LastPlaced = null);

    private static readonly List<TrapCard> _traps = new();
    private static readonly HashSet<int> _packsPicked = new();

    /// <summary>塔主手里的陷阱（「id@等级」）。</summary>
    public static IReadOnlyList<TrapCard> Traps => _traps;

    private static readonly HashSet<string> _lastPlaced = new();

    /// <summary>这一幕的陷阱选过没有。</summary>
    public static bool DraftDone(int actNo) => _packsPicked.Contains(actNo);

    /// <summary>上一场盖过的陷阱种类（冷却：这一场不能再盖）。</summary>
    public static IReadOnlySet<string> LastPlaced => _lastPlaced;

    public static void SetLastPlaced(IEnumerable<string> ids)
    {
        _lastPlaced.Clear();
        _lastPlaced.UnionWith(ids);
        Save();
    }

    /// <summary>新一幕：手里的陷阱升到本幕等级。</summary>
    public static void UpgradeHand(int actNo)
    {
        int tier = Math.Clamp(actNo, 1, 3);
        bool changed = false;
        for (int i = 0; i < _traps.Count; i++)
            if (_traps[i].Tier < tier) { _traps[i] = _traps[i] with { Tier = tier }; changed = true; }
        if (changed) { Log.Info($"塔主陷阱：手里的陷阱升到第 {tier} 级"); Save(); }
    }

    public static void CompleteDraft(int actNo, IReadOnlyList<TrapCard> cards)
    {
        _packsPicked.Add(actNo);
        if (cards.Count > 0) AddTraps(cards, $"第 {actNo} 幕选陷阱");
        else { Log.Info($"塔主陷阱：第 {actNo} 幕没有挑陷阱"); Save(); }
    }

    public static void AddTraps(IEnumerable<TrapCard> cards, string reason)
    {
        var list = cards.ToList();
        _traps.AddRange(list);
        Log.Info($"塔主陷阱：{reason}，获得 {string.Join("、", list.Select(c => c.Name))}，手里 {_traps.Count} 张");
        Save();
    }

    /// <summary>盖下陷阱：从手里拿走（按序号，从大到小删）。返回拿走的牌。</summary>
    public static List<TrapCard> TakeTraps(IEnumerable<int> indexes)
    {
        var sorted = indexes.Distinct().Where(i => i >= 0 && i < _traps.Count).OrderByDescending(i => i).ToList();
        var taken = sorted.Select(i => _traps[i]).Reverse().ToList();
        foreach (var i in sorted) _traps.RemoveAt(i);
        Save();
        return taken;
    }

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
        _traps.Clear();
        _packsPicked.Clear();
        _lastPlaced.Clear();
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
            _traps.Clear();
            _packsPicked.Clear();
            _lastPlaced.Clear();
            if (saved != null && saved.Seed == seed)
            {
                Wallet.Restore(saved.Points, saved.ActNo, saved.KnockedDown);
                BattlesFought = saved.Battles;
                _traps.AddRange((saved.Traps ?? []).Select(TrapCatalog.Parse).Where(c => TrapCatalog.Exists(c.Id)));
                _packsPicked.UnionWith(saved.PacksPicked ?? []);
                _lastPlaced.UnionWith(saved.LastPlaced ?? []);
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
            var saved = new Saved(_seed, Wallet.Points, Wallet.ActNo, Wallet.KnockedDownLastBattle.ToArray(), BattlesFought,
                _traps.Select(t => t.ToString()).ToArray(), _packsPicked.Order().ToArray(), _lastPlaced.Order().ToArray());
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
