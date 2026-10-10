namespace TowerMaster.Core;

/// <summary>塔主事件的一个选项。Key 是本地化 key 里的选项名（大写）。</summary>
public sealed record MasterEventOption(string Key, string Title, string Description);

/// <summary>
/// 一个塔主事件：问号房里玩家处理原版事件时，塔主那一份换成它。
/// Results：选完之后的结果页（key → 文字），由游戏接线按实际结果挑一页。
/// </summary>
public sealed record MasterEventDef(string Id, string Title, string Description, IReadOnlyList<MasterEventOption> Options, IReadOnlyDictionary<string, string> Results)
{
    /// <summary>本地化 key 前缀（events 表），例如 TOWER_MASTER_CASINO。</summary>
    public string LocKey => "TOWER_MASTER_" + Id.ToUpperInvariant();
}

/// <summary>
/// 塔主事件表与确定性的随机（各端用同样的种子 + 楼层算出同样的结果，不碰游戏的随机流）。
/// 文字原则：短、口语、有点好笑；数字写清楚。不能用花括号（游戏的本地化格式化会当成变量）。
/// </summary>
public static class MasterEvents
{
    public const int BlackMarketPrice = 5, GambleWin = 6, GambleLose = 3, SlackPoints = 2, OvertimeConsolation = 1, UnionFee = 3, CopyPrice = 4;

    public static readonly IReadOnlyList<MasterEventDef> All =
    [
        new("black_market", "黑市商人",
            "角落里的斗篷商人掀开大衣，里面挂满了发光的卡牌。「新货，刚从别的塔顺来的。」",
            [
                new("BUY", "买一张", $"花 {BlackMarketPrice} 召唤点，随机得到一张塔主牌。"),
                new("LEAVE", "离开", "不买。"),
            ],
            new Dictionary<string, string>
            {
                ["BUY"] = "商人把一张牌塞进你手里，转身消失在阴影里。",
                ["BROKE"] = "「钱都没有，看什么看。」商人白了你一眼。",
                ["LEAVE"] = "你摆摆手走开了。商人在背后嘀咕：「穷鬼。」",
            }),
        new("casino", "地下赌场",
            "骷髅荷官摇着骰子，咔啦咔啦。「押上几点，赢了翻倍。」",
            [
                new("GAMBLE", "赌一把", $"一半机会召唤点 +{GambleWin}，一半机会 -{GambleLose}。"),
                new("LEAVE", "不赌", "离开。"),
            ],
            new Dictionary<string, string>
            {
                ["WIN"] = $"骰子停在了六。骷髅荷官的下巴掉了下来。召唤点 +{GambleWin}。",
                ["LOSE"] = $"骰子停在了一。骷髅荷官笑得骨头直响。召唤点 -{GambleLose}。",
                ["LEAVE"] = "你把手揣回兜里。荷官失望地把骰子收了起来。",
            }),
        new("overtime", "加班申请",
            "深夜，提灯照着一摞没批完的文件。咖啡还热着。",
            [
                new("WORK", "加班", "手里一张陷阱升一级。"),
                new("SLACK", "摸鱼", $"召唤点 +{SlackPoints}。"),
            ],
            new Dictionary<string, string>
            {
                ["WORK"] = "你熬了一整夜，一张陷阱变得更结实了。",
                ["WORK_NONE"] = $"手里没有能升级的陷阱，白加班了。召唤点 +{OvertimeConsolation} 当加班费。",
                ["SLACK"] = $"你趴在桌上睡着了。醒来时口袋里多了 {SlackPoints} 点召唤点，谁放的？",
            }),
        new("monster_union", "怪物工会",
            "史莱姆敲了敲小木槌：「本次大会讨论塔主的待遇问题。」",
            [
                new("HIRE", "招临时工", $"花 {UnionFee} 召唤点，随机得到一张陷阱。"),
                new("REFUSE", "不交会费", "什么也不会发生。大概。"),
            ],
            new Dictionary<string, string>
            {
                ["HIRE"] = "一只小怪举手报名，顺手塞给你一张陷阱。",
                ["FULL"] = "你手里的陷阱已经满了。工会说下次再说。",
                ["BROKE"] = "你摸遍口袋也凑不齐会费。史莱姆敲了一下木槌：「下一位。」",
                ["REFUSE"] = "工会把你的名字写进了小本本。",
            }),
        new("master_worry", "塔主的烦恼",
            "你坐在台阶上翻着自己的牌，越看越烦。头顶飘来一小团乌云。",
            [
                new("TOSS", "扔一张", "随机删掉一张塔主牌。"),
                new("COPY", "复印一张", $"花 {CopyPrice} 召唤点，随机复制一张塔主牌。"),
                new("LEAVE", "算了", "什么也不做。"),
            ],
            new Dictionary<string, string>
            {
                ["TOSS"] = "你把一张牌揉成团扔了出去。乌云散了一点。",
                ["TOSS_NONE"] = "牌已经很少了，舍不得扔。乌云更黑了。",
                ["COPY"] = "复印机吐出一张热乎乎的牌。",
                ["BROKE"] = "复印机要投币，你摸遍口袋……算了。",
                ["LEAVE"] = "你叹了口气，把牌收好。雨还在下。",
            }),
    ];

    public static MasterEventDef? Find(string id) => All.FirstOrDefault(e => e.Id == id);

    /// <summary>这个楼层给塔主哪个事件。</summary>
    public static MasterEventDef Pick(ulong seed, int floor) => All[Index(seed, floor, 1, All.Count)];

    /// <summary>赌场：赢没赢（一半一半）。</summary>
    public static bool GambleWins(ulong seed, int floor) => Index(seed, floor, 2, 2) == 0;

    /// <summary>0..count-1 的确定性随机（count ≤ 0 返回 -1）。salt 区分同一楼层的不同用途。</summary>
    public static int Index(ulong seed, int floor, int salt, int count)
    {
        if (count <= 0) return -1;
        ulong x = seed ^ ((ulong)(uint)floor << 20) ^ ((ulong)(uint)salt * 0x9E3779B97F4A7C15UL);
        x += 0x9E3779B97F4A7C15UL; // splitmix64
        x = (x ^ (x >> 30)) * 0xBF58476D1CE4E5B9UL;
        x = (x ^ (x >> 27)) * 0x94D049BB133111EBUL;
        x ^= x >> 31;
        return (int)(x % (ulong)count);
    }

    /// <summary>本地化条目（合并进游戏 events 表）：标题、首页说明、选项标题/说明、结果页说明。</summary>
    public static Dictionary<string, string> LocEntries()
    {
        var entries = new Dictionary<string, string>();
        foreach (var e in All)
        {
            entries[$"{e.LocKey}.title"] = e.Title;
            entries[$"{e.LocKey}.pages.INITIAL.description"] = e.Description;
            foreach (var o in e.Options)
            {
                entries[$"{e.LocKey}.pages.INITIAL.options.{o.Key}.title"] = o.Title;
                entries[$"{e.LocKey}.pages.INITIAL.options.{o.Key}.description"] = o.Description;
            }
            foreach (var (key, text) in e.Results) entries[$"{e.LocKey}.pages.{key}.description"] = text;
        }
        return entries;
    }
}
