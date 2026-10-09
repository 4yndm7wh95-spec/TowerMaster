namespace TowerMaster.Core;

/// <summary>陷阱的触发条件。</summary>
public enum TrapTrigger
{
    /// <summary>第 N 回合开始（玩家回合）。</summary>
    RoundStart,
    /// <summary>某名玩家一回合内打出第 N 张攻击牌。</summary>
    AttacksInTurn,
    /// <summary>某名玩家一回合内打出第 N 张技能牌。</summary>
    SkillsInTurn,
    /// <summary>某名玩家一回合内打出第 N 张牌。</summary>
    CardsInTurn,
    /// <summary>任意敌人死亡（还有活着的敌人时）。</summary>
    EnemyDied,
    /// <summary>空陷阱：永不触发，纯诈唬。</summary>
    Never,
}

/// <summary>陷阱效果。玩家类效果只作用于触发者（回合类触发作用于所有玩家）。</summary>
public enum TrapEffect
{
    None,
    BlockAllEnemies,
    StrengthAllEnemies,
    HealAllEnemiesPercent,
    WeakPlayer,
    VulnerablePlayer,
    FrailPlayer,
    DazedPlayer,
}

/// <summary>一种陷阱。<see cref="Amounts"/> 按等级（1/2/3，对应牌池所在幕）取效果数值。</summary>
/// <param name="DraftCost">选进手里要花的「陷阱预算」（越强越贵）。</param>
public sealed record TrapDef(string Id, string NameZh, TrapTrigger Trigger, int Threshold, TrapEffect Effect, int[] Amounts, int DraftCost = 1)
{
    public int Amount(int tier) => Amounts[Math.Clamp(tier, 1, Amounts.Length) - 1];

    /// <summary>
    /// 原版卡牌风格的完整说明（用户要求「学原版的表述」），例如
    /// 「当一名玩家在一个回合内打出第 3 张技能牌时，给予该玩家 2 层脆弱。」
    /// <paramref name="keyword"/> 把关键词包起来（卡面传 BBCode 高亮，纯文本不传）。
    /// </summary>
    public string Describe(int tier, Func<string, string>? keyword = null)
    {
        var k = keyword ?? (w => w);
        string when = Trigger switch
        {
            TrapTrigger.RoundStart => $"第 {Threshold} 回合开始时，",
            TrapTrigger.AttacksInTurn => $"当一名玩家在一个回合内打出第 {Threshold} 张攻击牌时，",
            TrapTrigger.SkillsInTurn => $"当一名玩家在一个回合内打出第 {Threshold} 张技能牌时，",
            TrapTrigger.CardsInTurn => $"当一名玩家在一个回合内打出第 {Threshold} 张牌时，",
            TrapTrigger.EnemyDied => "当一名敌人死亡且场上还有其他敌人时，",
            _ => "",
        };
        int a = Amount(tier);
        string target = Trigger == TrapTrigger.RoundStart ? "每名玩家" : "该玩家";
        string what = Effect switch
        {
            TrapEffect.BlockAllEnemies => $"所有敌人获得 {a} 点{k("格挡")}。",
            TrapEffect.StrengthAllEnemies => $"所有敌人获得 {a} 点{k("力量")}。",
            TrapEffect.HealAllEnemiesPercent => $"所有敌人回复 {a}% 最大生命值。",
            TrapEffect.WeakPlayer => $"给予{target} {a} 层{k("虚弱")}。",
            TrapEffect.VulnerablePlayer => $"给予{target} {a} 层{k("易伤")}。",
            TrapEffect.FrailPlayer => $"给予{target} {a} 层{k("脆弱")}。",
            TrapEffect.DazedPlayer => $"将 {a} 张{k("晕眩")}放入{target}的抽牌堆。",
            _ => "没有任何效果。",
        };
        return when + what;
    }

    /// <summary>悬停提示里补充的规则说明（卡面放不下的）。</summary>
    public string Rules(int dodgeGold)
    {
        var lines = new List<string>();
        if (Effect == TrapEffect.None)
            lines.Add("玩家只知道你盖了几张陷阱，不知道这张是空的。战斗结束翻开时不给玩家金币。");
        else
        {
            lines.Add("每场战斗只触发一次。");
            if (Trigger is TrapTrigger.AttacksInTurn or TrapTrigger.SkillsInTurn or TrapTrigger.CardsInTurn)
                lines.Add("每名玩家分开计数，每回合重新计数。");
            if (Effect == TrapEffect.StrengthAllEnemies) lines.Add("和塔主行动给的力量合计，不超过本幕的力量上限。");
            lines.Add($"如果战斗胜利时还没触发，陷阱翻开，每名玩家获得 {dodgeGold} 金币。");
        }
        return string.Join("\n", lines);
    }

    /// <summary>界面上的短条件（小卡、日志用）。</summary>
    public string ShortWhen => Trigger switch
    {
        TrapTrigger.RoundStart => $"第 {Threshold} 回合",
        TrapTrigger.AttacksInTurn => $"第 {Threshold} 张攻击",
        TrapTrigger.SkillsInTurn => $"第 {Threshold} 张技能",
        TrapTrigger.CardsInTurn => $"第 {Threshold} 张牌",
        TrapTrigger.EnemyDied => "敌人死亡",
        _ => "不触发",
    };

    /// <summary>界面上的短效果（小卡、提示用）。</summary>
    /// <summary>触发后发生了什么（提示用的大白话，带主语）。</summary>
    public string Plain(int tier)
    {
        int a = Amount(tier);
        string who = Trigger == TrapTrigger.RoundStart ? "每名玩家" : "触发的玩家";
        return Effect switch
        {
            TrapEffect.BlockAllEnemies => $"所有敌人 +{a} 格挡",
            TrapEffect.StrengthAllEnemies => $"所有敌人 +{a} 力量",
            TrapEffect.HealAllEnemiesPercent => $"所有敌人回复 {a}% 生命",
            TrapEffect.WeakPlayer => $"{who}获得 {a} 层虚弱",
            TrapEffect.VulnerablePlayer => $"{who}获得 {a} 层易伤",
            TrapEffect.FrailPlayer => $"{who}获得 {a} 层脆弱",
            TrapEffect.DazedPlayer => $"{who}的抽牌堆多了 {a} 张晕眩",
            _ => "什么也没发生",
        };
    }

    public string ShortWhat(int tier)
    {
        int a = Amount(tier);
        return Effect switch
        {
            TrapEffect.BlockAllEnemies => $"敌人 {a} 格挡",
            TrapEffect.StrengthAllEnemies => $"敌人 {a} 力量",
            TrapEffect.HealAllEnemiesPercent => $"敌人回复 {a}%",
            TrapEffect.WeakPlayer => $"{a} 层虚弱",
            TrapEffect.VulnerablePlayer => $"{a} 层易伤",
            TrapEffect.FrailPlayer => $"{a} 层脆弱",
            TrapEffect.DazedPlayer => $"{a} 张晕眩",
            _ => "空陷阱",
        };
    }
}

/// <summary>塔主手里的一张陷阱：种类 + 等级。</summary>
public sealed record TrapCard(string Id, int Tier)
{
    public TrapDef Def => TrapCatalog.Get(Id);
    public string Name => Tier > 1 ? $"{Def.NameZh}+{Tier - 1}" : Def.NameZh;
    public string Describe(Func<string, string>? keyword = null) => Def.Describe(Tier, keyword);
    /// <summary>「条件：效果」短文本（小卡、日志用）。</summary>
    public string Short => $"{Def.ShortWhen}：{Def.ShortWhat(Tier)}";
    public override string ToString() => $"{Id}@{Tier}";
}

/// <summary>一个陷阱包（每幕开头 3 选 1）。</summary>
public sealed record TrapPack(string NameZh, string Style, IReadOnlyList<TrapCard> Cards);

/// <summary>
/// 陷阱牌表（设计文档「陷阱牌」示例的第一版实现）。只用原版命令能稳定施加、触发条件能在房主上可靠判断的种类。
/// 「召唤增援」「药水触发」「下回合少抽牌」需要更多游戏接口，后续再加。
/// </summary>
public static class TrapCatalog
{
    public static readonly IReadOnlyList<TrapDef> All =
    [
        new("harden", "硬化", TrapTrigger.AttacksInTurn, 3, TrapEffect.BlockAllEnemies, [4, 6, 8], 2),
        new("brittle", "碎甲", TrapTrigger.SkillsInTurn, 3, TrapEffect.FrailPlayer, [1, 2, 2], 1),
        new("stifle", "窒息", TrapTrigger.CardsInTurn, 5, TrapEffect.WeakPlayer, [2, 2, 3], 1),
        new("rally", "鼓舞", TrapTrigger.RoundStart, 3, TrapEffect.StrengthAllEnemies, [1, 1, 2], 2),
        new("frenzy", "狂怒", TrapTrigger.EnemyDied, 1, TrapEffect.StrengthAllEnemies, [1, 2, 2], 3),
        new("mire", "泥沼", TrapTrigger.RoundStart, 2, TrapEffect.DazedPlayer, [2, 2, 3], 1),
        new("mend", "再生", TrapTrigger.RoundStart, 4, TrapEffect.HealAllEnemiesPercent, [15, 20, 25], 2),
        new("countdown", "倒计时", TrapTrigger.RoundStart, 5, TrapEffect.HealAllEnemiesPercent, [25, 30, 35], 1),
        new("exposed", "破绽", TrapTrigger.AttacksInTurn, 4, TrapEffect.VulnerablePlayer, [1, 2, 2], 2),
        new("bluff", "空陷阱", TrapTrigger.Never, 0, TrapEffect.None, [0, 0, 0], 0),
    ];

    public static TrapDef Get(string id) => All.FirstOrDefault(d => d.Id == id) ?? throw new KeyNotFoundException($"没有陷阱 {id}");

    public static bool Exists(string id) => All.Any(d => d.Id == id);

    private static TrapPack Pack(string name, string style, int tier, params string[] ids) =>
        new(name, style, ids.Select(id => new TrapCard(id, tier)).ToList());

    /// <summary>
    /// 每幕开头的 3 个陷阱包。第一幕三种风格各一包；第二、三幕同样三种风格、等级随幕提高（效果更强），
    /// 设计文档里「升级已有陷阱」「强力但有代价」两类选项后续再做。
    /// </summary>
    public static IReadOnlyList<TrapPack> PacksFor(int actNo)
    {
        int tier = Math.Clamp(actNo, 1, 3);
        return
        [
            Pack("铁壁包", "惩罚连续进攻", tier, "harden", "harden", "exposed", "bluff"),
            Pack("拖延包", "拖长战斗、消耗玩家", tier, "mire", "mend", "countdown", "bluff"),
            Pack("压迫包", "让怪物越打越强", tier, "rally", "frenzy", "brittle", tier >= 2 ? "stifle" : "bluff"),
        ];
    }

    /// <summary>本幕牌池（击倒奖励从这里抽，空陷阱除外）。</summary>
    public static IReadOnlyList<TrapCard> PoolFor(int actNo) =>
        PacksFor(actNo).SelectMany(p => p.Cards).Where(c => c.Id != "bluff").DistinctBy(c => c.Id).ToList();

    /// <summary>
    /// 每幕开头给塔主挑的候选：除空陷阱外随机 offerSize 种（按种子固定，每局不同），再加一张空陷阱；等级 = 幕数。
    /// </summary>
    public static IReadOnlyList<TrapCard> DraftOffer(int actNo, ulong seed, int offerSize)
    {
        int tier = Math.Clamp(actNo, 1, 3);
        var kinds = All.Where(d => d.Id != "bluff").Select(d => d.Id).ToList();
        var rng = new Random(unchecked((int)(seed ^ (ulong)(actNo * 104729))));
        for (int i = kinds.Count - 1; i > 0; i--)
        {
            int j = rng.Next(i + 1);
            (kinds[i], kinds[j]) = (kinds[j], kinds[i]);
        }
        return kinds.Take(Math.Min(offerSize, kinds.Count)).Order(StringComparer.Ordinal)
            .Select(id => new TrapCard(id, tier)).Append(new TrapCard("bluff", tier)).ToList();
    }

    /// <summary>"id@tier" 解析。</summary>
    public static TrapCard Parse(string text)
    {
        var parts = text.Split('@');
        return new TrapCard(parts[0], parts.Length > 1 && int.TryParse(parts[1], out var t) ? t : 1);
    }
}

/// <summary>陷阱触发：哪张陷阱、作用于哪名玩家（回合类为 0，表示所有玩家）。</summary>
public sealed record TrapFire(TrapCard Card, ulong Player);

/// <summary>
/// 一场战斗里盖下的陷阱和触发判定（只在房主上运行；触发后由 mod 广播效果）。
/// 计数按单个玩家、单个回合（设计文档建议：多人时条件按单个玩家计，效果只作用于触发者）。
/// 每张陷阱只触发一次。
/// </summary>
public sealed class TrapTracker
{
    private readonly List<TrapCard> _armed;
    private readonly HashSet<int> _fired = new();
    private readonly Dictionary<(ulong, TrapTrigger), int> _counts = new();

    public TrapTracker(IEnumerable<TrapCard> placed) => _armed = placed.ToList();

    public IReadOnlyList<TrapCard> Placed => _armed;

    /// <summary>还没触发的陷阱（战斗结束时翻开、收回手里，每张给玩家躲过奖励）。</summary>
    public IReadOnlyList<TrapCard> Unfired => _armed.Where((_, i) => !_fired.Contains(i)).ToList();

    public int FiredCount => _fired.Count;

    /// <summary>玩家回合开始：清零每回合计数，检查「第 N 回合开始」。</summary>
    public IReadOnlyList<TrapFire> RoundStarted(int round)
    {
        _counts.Clear();
        return Check(d => d.Trigger == TrapTrigger.RoundStart && d.Threshold == round, 0);
    }

    /// <summary>玩家打出一张牌（同一张牌的重复打出只算一次）。</summary>
    public IReadOnlyList<TrapFire> CardPlayed(ulong player, bool attack, bool skill)
    {
        var fires = new List<TrapFire>();
        int all = Bump(player, TrapTrigger.CardsInTurn);
        fires.AddRange(Check(d => d.Trigger == TrapTrigger.CardsInTurn && d.Threshold == all, player));
        if (attack)
        {
            int n = Bump(player, TrapTrigger.AttacksInTurn);
            fires.AddRange(Check(d => d.Trigger == TrapTrigger.AttacksInTurn && d.Threshold == n, player));
        }
        if (skill)
        {
            int n = Bump(player, TrapTrigger.SkillsInTurn);
            fires.AddRange(Check(d => d.Trigger == TrapTrigger.SkillsInTurn && d.Threshold == n, player));
        }
        return fires;
    }

    /// <summary>有敌人死亡（调用方保证每只只报一次、还有活着的敌人）。</summary>
    public IReadOnlyList<TrapFire> EnemyDied() => Check(d => d.Trigger == TrapTrigger.EnemyDied, 0);

    private int Bump(ulong player, TrapTrigger kind)
    {
        var key = (player, kind);
        _counts[key] = _counts.GetValueOrDefault(key) + 1;
        return _counts[key];
    }

    /// <summary>满足条件的未触发陷阱：同一时机同名的只触发一张（另一张留着下次）。</summary>
    private List<TrapFire> Check(Func<TrapDef, bool> match, ulong player)
    {
        var fires = new List<TrapFire>();
        var seen = new HashSet<string>();
        for (int i = 0; i < _armed.Count; i++)
        {
            if (_fired.Contains(i) || !match(_armed[i].Def) || !seen.Add(_armed[i].Id)) continue;
            _fired.Add(i);
            fires.Add(new TrapFire(_armed[i], player));
        }
        return fires;
    }
}

/// <summary>选陷阱时不能确认的原因。</summary>
public enum TrapDraftProblem { OverBudget, TooManyPicks, HandFull }

/// <summary>
/// 每幕开头的自由选陷阱（用户要求：不要固定卡包，让塔主自己挑、自己搭配，并有约束保证平衡和变化）：
/// - 候选是本幕随机的一批（<see cref="TrapCatalog.DraftOffer"/>），每局不同；
/// - 每种陷阱有预算花费（越强越贵），本幕预算有限；最多挑几张；
/// - 手里同一种陷阱只能有一张（已有的不能再挑）；手牌有上限；
/// - 已有的陷阱在新一幕自动升到本幕等级。
/// </summary>
public sealed class TrapDraft
{
    private readonly List<int> _picked = new();

    public TrapDraft(int actNo, IReadOnlyList<TrapCard> offer, IReadOnlyList<TrapCard> hand, int budget, int maxPicks, int handLimit)
    {
        ActNo = actNo;
        Offer = offer;
        Hand = hand;
        Budget = budget;
        MaxPicks = maxPicks;
        HandLimit = handLimit;
    }

    public int ActNo { get; }
    public IReadOnlyList<TrapCard> Offer { get; }
    public IReadOnlyList<TrapCard> Hand { get; }
    public int Budget { get; }
    public int MaxPicks { get; }
    public int HandLimit { get; }
    public IReadOnlyList<int> Picked => _picked;
    public int Spent => _picked.Sum(i => Offer[i].Def.DraftCost);
    public bool Done { get; private set; }

    /// <summary>手里已经有这一种（不能重复挑）。</summary>
    public bool Owned(int index) => Hand.Any(h => h.Id == Offer[index].Id);

    /// <summary>这张现在能不能加选（不算已选的）。</summary>
    public bool CanAdd(int index) =>
        !Done && !Owned(index) && !_picked.Contains(index)
        && Spent + Offer[index].Def.DraftCost <= Budget
        && _picked.Count < MaxPicks && Hand.Count + _picked.Count < HandLimit;

    /// <summary>点一下：没选就加（能加的话），选了就去掉。返回是否变了。</summary>
    public bool Toggle(int index)
    {
        if (Done || index < 0 || index >= Offer.Count) return false;
        if (_picked.Remove(index)) return true;
        if (!CanAdd(index)) return false;
        _picked.Add(index);
        return true;
    }

    public IReadOnlyList<TrapDraftProblem> Problems
    {
        get
        {
            var list = new List<TrapDraftProblem>();
            if (Spent > Budget) list.Add(TrapDraftProblem.OverBudget);
            if (_picked.Count > MaxPicks) list.Add(TrapDraftProblem.TooManyPicks);
            if (Hand.Count + _picked.Count > HandLimit) list.Add(TrapDraftProblem.HandFull);
            return list;
        }
    }

    /// <summary>确认：返回挑中的牌（可以一张不挑）。</summary>
    public IReadOnlyList<TrapCard> Confirm()
    {
        if (Problems.Count > 0) throw new InvalidOperationException("选陷阱不合规则");
        Done = true;
        return _picked.Order().Select(i => Offer[i]).ToList();
    }
}
