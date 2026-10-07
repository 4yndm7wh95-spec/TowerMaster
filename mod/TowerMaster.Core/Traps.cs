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
public sealed record TrapDef(string Id, string NameZh, TrapTrigger Trigger, int Threshold, TrapEffect Effect, int[] Amounts)
{
    public int Amount(int tier) => Amounts[Math.Clamp(tier, 1, Amounts.Length) - 1];

    /// <summary>中文说明，例如「一回合打出第 3 张攻击牌 → 所有敌人 +5 格挡」。</summary>
    public string Describe(int tier)
    {
        string when = Trigger switch
        {
            TrapTrigger.RoundStart => $"第 {Threshold} 回合开始",
            TrapTrigger.AttacksInTurn => $"玩家一回合打出第 {Threshold} 张攻击牌",
            TrapTrigger.SkillsInTurn => $"玩家一回合打出第 {Threshold} 张技能牌",
            TrapTrigger.CardsInTurn => $"玩家一回合打出第 {Threshold} 张牌",
            TrapTrigger.EnemyDied => "任意敌人死亡",
            _ => "永不触发",
        };
        int a = Amount(tier);
        string what = Effect switch
        {
            TrapEffect.BlockAllEnemies => $"所有敌人 +{a} 格挡",
            TrapEffect.StrengthAllEnemies => $"所有敌人 +{a} 力量",
            TrapEffect.HealAllEnemiesPercent => $"所有敌人回复 {a}% 最大生命",
            TrapEffect.WeakPlayer => $"{Subject} {a} 层虚弱",
            TrapEffect.VulnerablePlayer => $"{Subject} {a} 层易伤",
            TrapEffect.FrailPlayer => $"{Subject} {a} 层脆弱",
            TrapEffect.DazedPlayer => $"{Subject}抽牌堆塞 {a} 张眩晕",
            _ => "没有效果（诈唬）",
        };
        return $"{when} → {what}";
    }

    private string Subject => Trigger == TrapTrigger.RoundStart ? "每名玩家" : "该玩家";
}

/// <summary>塔主手里的一张陷阱：种类 + 等级。</summary>
public sealed record TrapCard(string Id, int Tier)
{
    public TrapDef Def => TrapCatalog.Get(Id);
    public string Name => Tier > 1 ? $"{Def.NameZh}+{Tier - 1}" : Def.NameZh;
    public string Describe() => Def.Describe(Tier);
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
        new("harden", "硬化", TrapTrigger.AttacksInTurn, 3, TrapEffect.BlockAllEnemies, [5, 8, 11]),
        new("brittle", "碎甲", TrapTrigger.SkillsInTurn, 3, TrapEffect.FrailPlayer, [1, 2, 2]),
        new("stifle", "窒息", TrapTrigger.CardsInTurn, 6, TrapEffect.WeakPlayer, [2, 2, 3]),
        new("rally", "鼓舞", TrapTrigger.RoundStart, 3, TrapEffect.StrengthAllEnemies, [1, 2, 2]),
        new("frenzy", "狂怒", TrapTrigger.EnemyDied, 1, TrapEffect.StrengthAllEnemies, [2, 3, 3]),
        new("mire", "泥沼", TrapTrigger.RoundStart, 2, TrapEffect.DazedPlayer, [2, 2, 3]),
        new("mend", "再生", TrapTrigger.RoundStart, 4, TrapEffect.HealAllEnemiesPercent, [15, 20, 25]),
        new("countdown", "倒计时", TrapTrigger.RoundStart, 6, TrapEffect.HealAllEnemiesPercent, [30, 35, 40]),
        new("exposed", "破绽", TrapTrigger.AttacksInTurn, 4, TrapEffect.VulnerablePlayer, [1, 2, 2]),
        new("bluff", "空陷阱", TrapTrigger.Never, 0, TrapEffect.None, [0, 0, 0]),
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
