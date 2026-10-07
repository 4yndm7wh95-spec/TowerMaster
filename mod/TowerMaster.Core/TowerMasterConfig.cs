using System.Text.Json;
using System.Text.Json.Serialization;

namespace TowerMaster.Core;

/// <summary>
/// 所有可调数值（设计文档「平衡目标与调平方法」：关键数值都放进配置文件）。
/// 默认值是设计文档里的第一版测试起点。按幕区分的数组下标 0/1/2 对应第一/二/三幕。
/// </summary>
public sealed class TowerMasterConfig
{
    // ---------------------------------------------------------------- 召唤点
    /// <summary>开局召唤点。</summary>
    public int StartingSummonPoints { get; set; } = 12;

    /// <summary>每场战斗后的基础收入（按幕）。和各幕普通战平均标准开销大致持平：照原版强度出怪不亏。</summary>
    public int[] BaseIncome { get; set; } = [5, 6, 7];

    /// <summary>基础收入的人数系数，下标 0/1/2 对应 1/2/3 名爬塔玩家。乘完向下取整。</summary>
    public double[] ClimberIncomeFactor { get; set; } = [1.0, 1.25, 1.5];

    /// <summary>节约奖励 = (标准开销 − 实际花费) ÷ 该值，向下取整。</summary>
    public int SavingsBonusDivisor { get; set; } = 2;

    /// <summary>节约奖励上限。</summary>
    public int SavingsBonusMax { get; set; } = 3;

    /// <summary>战果奖励：所有玩家合计每掉这么多血 +1。</summary>
    public int DamagePerBonusPoint { get; set; } = 15;

    /// <summary>战果奖励每场最多几点（防止越打越强的滚雪球）。</summary>
    public int DamageBonusMax { get; set; } = 2;

    /// <summary>储蓄上限（按幕）。超出的收入作废；进入新一幕时超出新上限的部分作废。</summary>
    public int[] SavingsCap { get; set; } = [30, 45, 60];

    /// <summary>击倒奖励的召唤点（另从当前幕牌池抽 1 张陷阱）。</summary>
    public int KnockdownSummonPoints { get; set; } = 3;

    // ---------------------------------------------------------------- 召唤限制
    /// <summary>普通房单场花费上限 = 标准开销 × 该值。</summary>
    public double NormalSpendCapMultiplier { get; set; } = 1.35;

    /// <summary>精英房单场花费上限 = 标准开销 × 该值。</summary>
    public double EliteSpendCapMultiplier { get; set; } = 1.3;

    /// <summary>精英房另加小怪（含群体税）不超过这么多召唤点。</summary>
    public int EliteExtraSpendCap { get; set; } = 3;

    /// <summary>Boss 房额外召唤上限 = 本幕普通战平均标准开销 × 该值。</summary>
    public double BossExtraSpendCapMultiplier { get; set; } = 1.0;

    /// <summary>每幕开头公开几个候选 Boss，塔主进 Boss 房时从中选一个。</summary>
    public int BossCandidateCount { get; set; } = 2;

    /// <summary>场上同时最多 (该值 + 爬塔人数) 只怪。</summary>
    public int MaxMonstersBase { get; set; } = 2;

    /// <summary>同名怪最多几只。</summary>
    public int MaxSameMonster { get; set; } = 3;

    /// <summary>
    /// 跨幕「水土不服」：怪物每比当前幕超前一幕，血量降这么多（0.2 = −20%）。
    /// 只降血量、伤害不变，所以同时加价（<see cref="CrossActPricePremium"/>）。
    /// </summary>
    public double CrossActHpCut { get; set; } = 0.2;

    /// <summary>怪物每比当前幕超前一幕，召唤价加这么多（1.0 = +100%）。</summary>
    public double CrossActPricePremium { get; set; } = 1.0;

    /// <summary>精英房是「优惠房」：所有怪的召唤价乘这个折扣。</summary>
    public double EliteRoomDiscount { get; set; } = 0.85;

    /// <summary>每个房间最多几只精英类怪物（防止精英房折扣叠精英）。</summary>
    public int MaxEliteMonstersPerRoom { get; set; } = 1;

    /// <summary>开局保护：第一幕前几场战斗只能用本幕的普通怪（不跨幕、不要精英）、花费有上限、不能盖陷阱。</summary>
    public int OpeningProtectionBattles { get; set; } = 3;

    /// <summary>开局保护期间单场花费上限 = 标准开销 × 该值。</summary>
    public double OpeningSpendCapMultiplier { get; set; } = 1.3;

    // ---------------------------------------------------------------- 陷阱
    public int MaxTrapsPerBattle { get; set; } = 2;

    /// <summary>每幕开头选陷阱：候选几种（另加一张空陷阱）。</summary>
    public int TrapDraftOfferSize { get; set; } = 6;

    /// <summary>每幕选陷阱的预算（按幕）。陷阱的预算花费见 TrapDef.DraftCost（1~3，空陷阱 0）。</summary>
    public int[] TrapDraftBudget { get; set; } = [5, 5, 5];

    /// <summary>每幕最多挑几张。</summary>
    public int TrapDraftMaxPicks { get; set; } = 3;

    /// <summary>手里最多几张陷阱。</summary>
    public int TrapHandLimit { get; set; } = 6;

    /// <summary>上一场盖过的陷阱种类，这一场不能再盖（冷却 1 场，逼塔主轮换）。</summary>
    public bool TrapCooldown { get; set; } = true;

    /// <summary>每张陷阱盖下时花的召唤点（不退）。</summary>
    public int TrapPlaceCost { get; set; } = 1;

    /// <summary>陷阱没触发时每位玩家拿到的「躲过」金币。</summary>
    public int DodgeRewardGold { get; set; } = 10;

    // ---------------------------------------------------------------- 计时
    /// <summary>召唤阶段限时（秒）；0 = 不限时（用户要求去掉倒计时）。</summary>
    public int SummonPhaseSeconds { get; set; } = 0;
    /// <summary>塔主回合限时（秒）；0 = 不限时、不显示倒计时（用户要求去掉）。</summary>
    public int MasterTurnSeconds { get; set; } = 0;

    // ---------------------------------------------------------------- 威胁点
    /// <summary>每场威胁点（按幕）。</summary>
    public int[] ThreatPerBattle { get; set; } = [3, 4, 5];
    public int ThreatEliteBonus { get; set; } = 1;
    public int ThreatBossBonus { get; set; } = 2;

    /// <summary>每多 1 名爬塔玩家（第 2 名起）加多少威胁点。</summary>
    public int ThreatPerExtraClimber { get; set; } = 1;

    /// <summary>开局保护的战斗（第一幕前几场普通战）威胁点最多这么多。</summary>
    public int OpeningThreatPoints { get; set; } = 2;

    /// <summary>威胁点逐回合解锁：第 1 回合能用多少（按幕）；0 = 不分回合，一开始全给。</summary>
    public int[] ThreatFirstTurnRelease { get; set; } = [2, 3, 3];

    /// <summary>之后每回合再解锁多少。</summary>
    public int ThreatReleasePerTurn { get; set; } = 1;

    public ThreatPrices Threat { get; set; } = new();

    // ---------------------------------------------------------------- 读写
    public static readonly JsonSerializerOptions JsonOptions = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
        WriteIndented = true,
        ReadCommentHandling = JsonCommentHandling.Skip,
        AllowTrailingCommas = true,
        Converters = { new JsonStringEnumConverter(JsonNamingPolicy.SnakeCaseLower) },
    };

    /// <summary>读配置；文件里没写的字段保留默认值。</summary>
    public static TowerMasterConfig FromJson(string json) =>
        JsonSerializer.Deserialize<TowerMasterConfig>(json, JsonOptions) ?? new TowerMasterConfig();

    public string ToJson() => JsonSerializer.Serialize(this, JsonOptions);

    /// <summary>按幕取值。actNo 从 1 开始，超出范围取最后一项。</summary>
    public static T ByAct<T>(T[] values, int actNo) => values[Math.Clamp(actNo, 1, values.Length) - 1];

    /// <summary>按爬塔人数取值。climbers 从 1 开始，超出范围取最后一项。</summary>
    public static T ByClimbers<T>(T[] values, int climbers) => values[Math.Clamp(climbers, 1, values.Length) - 1];
}

/// <summary>威胁点价目表（设计文档「威胁点价目表」）。</summary>
public sealed class ThreatPrices
{
    public int BlockCost { get; set; } = 1;
    /// <summary>格挡量（按幕）。</summary>
    public int[] BlockAmount { get; set; } = [6, 9, 12];

    public int HealCost { get; set; } = 1;
    /// <summary>回复最大生命的百分比，向下取整，至少 1。</summary>
    public int HealPercent { get; set; } = 10;
    public int HealPerMonsterPerBattle { get; set; } = 2;

    public int DebuffCost { get; set; } = 1;
    public int DebuffStacks { get; set; } = 1;
    /// <summary>同一玩家每回合最多被上几次减益（虚弱、易伤、脆弱合计）。</summary>
    public int DebuffPerPlayerPerTurn { get; set; } = 1;

    public int DazedCost { get; set; } = 1;
    public int DazedPerBattle { get; set; } = 3;

    public int StrengthCost { get; set; } = 2;
    /// <summary>单只加力量的量（按幕）。</summary>
    public int[] StrengthAmount { get; set; } = [1, 1, 2];
    /// <summary>每只怪物累计力量上限（按幕；威胁点和陷阱给的合并计算）。</summary>
    public int[] StrengthCap { get; set; } = [2, 3, 4];

    public int StrengthAllCost { get; set; } = 3;
    public int StrengthAllAmount { get; set; } = 1;
    public int StrengthAllPerBattle { get; set; } = 1;
}
