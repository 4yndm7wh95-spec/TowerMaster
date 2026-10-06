namespace TowerMaster.Core;

/// <summary>召唤阶段要校验的房间信息。</summary>
/// <param name="ActId">幕类名（Overgrowth / Underdocks / Hive / Glory）。</param>
/// <param name="Room">房间类型。</param>
/// <param name="Climbers">爬塔玩家人数（不含塔主）。</param>
/// <param name="BattlesBeforeInRun">本局在此之前已经打过几场战斗（开局保护用）。</param>
/// <param name="OriginalLineup">本房间原版生成的怪物组合（游戏用种子算出的那一组）。</param>
/// <param name="Savings">塔主当前召唤点。</param>
/// <param name="BossCandidates">本幕开头公开的候选 Boss 遭遇（见 <see cref="SummonRules.PickBossCandidates"/>）；null 表示不限制。</param>
/// <param name="StandardCostOverride">
/// 直接指定标准开销。进房前拿不到原版遭遇（提前抽会改变随机序列），召唤阶段用本幕同类房间的平均标准开销。
/// </param>
public sealed record RoomContext(
    string ActId,
    RoomKind Room,
    int Climbers,
    int BattlesBeforeInRun,
    IReadOnlyList<string> OriginalLineup,
    int Savings,
    IReadOnlyList<string>? BossCandidates = null,
    int? StandardCostOverride = null);

/// <summary>塔主提交的召唤方案。</summary>
/// <param name="Encounter">Boss 房选的 Boss 遭遇类名；普通房、精英房必须为 null。</param>
/// <param name="Monsters">普通房、精英房的全部怪物；Boss 房另加的怪。可以是任何幕的普通、精英怪。</param>
/// <param name="Traps">盖几张陷阱。</param>
public sealed record SummonPlan(string? Encounter, IReadOnlyList<string> Monsters, int Traps = 0);

public enum SummonViolation
{
    UnknownMonster,
    UnknownEncounter,
    MonsterNotSummonable,
    EncounterRequired,
    EncounterNotAllowed,
    WrongEncounterRoom,
    BossNotCandidate,
    EmptyRoom,
    OpeningProtectionMonster,
    OpeningProtectionCost,
    OpeningProtectionTraps,
    TooManyMonsters,
    TooManySameMonster,
    TooManyTraps,
    OverSpendCap,
    OverEliteExtraCap,
    TooManyElites,
    OverBossExtraCap,
    NotEnoughPoints,
}

/// <summary>校验结果和花费明细。<see cref="Total"/> 是要从召唤点里扣掉的数。</summary>
public sealed record SummonQuote(
    IReadOnlyList<SummonViolation> Violations,
    int MonsterPrice,
    int CrowdTax,
    int TrapCost,
    int StandardCost,
    double SpendCap,
    IReadOnlyList<string> Lineup)
{
    public bool Ok => Violations.Count == 0;
    /// <summary>怪物花费（召唤价 + 群体税），用于单场上限和节约奖励。</summary>
    public int MonsterSpend => MonsterPrice + CrowdTax;
    public int Total => MonsterSpend + TrapCost;
}

/// <summary>
/// 召唤阶段的规则（设计文档「战斗规则」「防滥用规则」）。纯函数，各客户端用同一份输入算出同一结果。
/// </summary>
public sealed class SummonRules(TowerMasterConfig config, PriceBook prices)
{
    public TowerMasterConfig Config { get; } = config;
    public PriceBook Prices { get; } = prices;

    /// <summary>群体税：第 2 只起每多一只 +1、+2、+3…，n 只合计 n(n−1)/2。</summary>
    public static int CrowdTax(int units) => units <= 1 ? 0 : units * (units - 1) / 2;

    /// <summary>
    /// 房间标准开销，按原版实际生成的组合算：普通房 = 召唤价合计 + 群体税；精英房不收群体税；Boss 免费，记 0。
    /// </summary>
    public int StandardCost(string actId, RoomKind room, IReadOnlyList<string> lineup)
    {
        if (room == RoomKind.Boss) return 0;
        var act = Prices.Act(actId);
        int sum = lineup.Sum(m => act.TryPrice(m, out var p) ? p : 0);
        return room == RoomKind.Monster ? sum + CrowdTax(lineup.Count) : sum;
    }

    public int StandardCostOf(RoomContext room) =>
        room.Room == RoomKind.Boss ? 0 : room.StandardCostOverride ?? StandardCost(room.ActId, room.Room, room.OriginalLineup);

    /// <summary>
    /// 本幕同类房间的平均标准开销，四舍五入：普通房取非简单遭遇的平均（开局保护时取简单遭遇的平均），精英房取精英遭遇的平均。
    /// </summary>
    public int AverageStandardCost(string actId, RoomKind room, bool weak = false)
    {
        var costs = Prices.Act(actId).Encounters.Values
            .Where(e => e.Room == room && (room != RoomKind.Monster || e.Weak == weak))
            .Select(e => e.StandardCost).ToList();
        return costs.Count == 0 ? 0 : (int)Math.Round(costs.Average(), MidpointRounding.AwayFromZero);
    }

    /// <summary>场上同时最多几只怪：基础值 + 爬塔人数。</summary>
    public int MaxMonsters(int climbers) => Config.MaxMonstersBase + climbers;

    /// <summary>
    /// 每幕开头公开的候选 Boss：第一个是游戏本来为这一幕选好的 Boss（超时就按它出场），
    /// 其余从本幕别的 Boss 遭遇里抽。<paramref name="nextInt"/>(n) 返回 [0, n) 的随机数，
    /// mod 里要传游戏的种子随机数，保证各客户端抽到同一组。
    /// </summary>
    public IReadOnlyList<string> PickBossCandidates(string actId, string originalBossEncounter, Func<int, int> nextInt)
    {
        var others = Prices.Act(actId).Encounters
            .Where(e => e.Value.Room == RoomKind.Boss && e.Key != originalBossEncounter)
            .Select(e => e.Key).OrderBy(k => k, StringComparer.Ordinal).ToList();
        var picked = new List<string> { originalBossEncounter };
        while (picked.Count < Config.BossCandidateCount && others.Count > 0)
        {
            int i = nextInt(others.Count);
            picked.Add(others[i]);
            others.RemoveAt(i);
        }
        return picked;
    }

    public bool IsOpeningProtected(RoomContext room) =>
        room.Room == RoomKind.Monster
        && Prices.Act(room.ActId).ActNo == 1
        && room.BattlesBeforeInRun < Config.OpeningProtectionBattles;

    /// <summary>开局保护期间能用的怪：本幕的普通怪（不跨幕、不要精英）。</summary>
    public bool OpeningAllows(string actId, string monster) =>
        Prices.Act(actId).Monsters.TryGetValue(monster, out var local) && local.Role == MonsterRole.Normal;

    /// <summary>超时未确认：按原版组合出场，花费按标准开销（不够就扣到 0）。</summary>
    public SummonQuote Fallback(RoomContext room)
    {
        int std = StandardCostOf(room);
        int paid = Math.Min(std, Math.Max(0, room.Savings));
        return new SummonQuote([], paid, 0, 0, std, std, room.OriginalLineup);
    }

    // ---------------------------------------------------------------- 召唤价（任何幕的怪都能召唤）

    /// <summary>怪物比当前幕「超前」几幕（第一幕的怪在第三幕为 0，不打折也不加价）。</summary>
    public int ActsAhead(string monster, int actNo) =>
        Prices.AllMonsters.TryGetValue(monster, out var m) ? Math.Max(0, m.HomeAct - actNo) : 0;

    /// <summary>「水土不服」：每超前一幕，血量 × (1 − 配置的降幅)，最低 10%。</summary>
    public double HpFactor(string monster, int actNo) =>
        Math.Max(0.1, 1 - Config.CrossActHpCut * ActsAhead(monster, actNo));

    /// <summary>
    /// 召唤价 = 战力（按降过的血量算）× 本幕系数 ×（精英 × 精英系数）×（1 + 每超前一幕的加价）×（精英房折扣），四舍五入，至少 1。
    /// 战力 = 有效血量 / 10 + 前 3 回合伤害 / 6 + 机制分（设计文档「数值」）。
    /// </summary>
    public int SummonPrice(string monster, int actNo, RoomKind room)
    {
        var m = Prices.AllMonsters[monster];
        int ahead = ActsAhead(monster, actNo);
        double power = m.EffectiveHp * HpFactor(monster, actNo) / 10 + m.Damage / 6.0 + m.Mechanics;
        double price = power * Prices.Coefficient(actNo)
                       * (m.Role == MonsterRole.Elite ? Prices.EliteMultiplier : 1)
                       * (1 + Config.CrossActPricePremium * ahead)
                       * (room == RoomKind.Elite ? Config.EliteRoomDiscount : 1);
        return Math.Max(1, (int)Math.Round(price, MidpointRounding.AwayFromZero));
    }

    /// <summary>能单独召唤的怪：任何幕的普通怪、精英怪（Boss 只能在 Boss 房当遭遇选；怪物召唤出的小怪不单卖）。</summary>
    public bool IsSummonable(string monster) =>
        Prices.AllMonsters.TryGetValue(monster, out var m) && m.Role is MonsterRole.Normal or MonsterRole.Elite;

    public SummonQuote Quote(RoomContext room, SummonPlan plan)
    {
        var act = Prices.Act(room.ActId);
        var errors = new List<SummonViolation>();
        int std = StandardCostOf(room);
        bool opening = IsOpeningProtected(room);

        // 怪物本身：任何幕的普通、精英怪；开局保护时只能用本幕的普通怪
        int price = 0, elites = 0;
        foreach (var m in plan.Monsters)
        {
            if (!Prices.AllMonsters.TryGetValue(m, out var info)) { errors.Add(SummonViolation.UnknownMonster); continue; }
            if (!IsSummonable(m)) { errors.Add(SummonViolation.MonsterNotSummonable); continue; }
            if (opening && !OpeningAllows(room.ActId, m)) errors.Add(SummonViolation.OpeningProtectionMonster);
            if (info.Role == MonsterRole.Elite) elites++;
            price += SummonPrice(m, act.ActNo, room.Room);
        }
        if (elites > Config.MaxEliteMonstersPerRoom) errors.Add(SummonViolation.TooManyElites);

        // Boss 房：必须选一个候选 Boss（免费），另加的怪随意；普通房、精英房不选遭遇
        List<string> encounterMonsters = [];
        if (room.Room != RoomKind.Boss)
        {
            if (plan.Encounter != null) errors.Add(SummonViolation.EncounterNotAllowed);
            if (plan.Monsters.Count == 0) errors.Add(SummonViolation.EmptyRoom);
        }
        else if (plan.Encounter == null) errors.Add(SummonViolation.EncounterRequired);
        else if (!act.Encounters.TryGetValue(plan.Encounter, out var enc)) errors.Add(SummonViolation.UnknownEncounter);
        else if (enc.Room != RoomKind.Boss) errors.Add(SummonViolation.WrongEncounterRoom);
        else if (room.BossCandidates != null && !room.BossCandidates.Contains(plan.Encounter)) errors.Add(SummonViolation.BossNotCandidate);
        else encounterMonsters = enc.Lineups.OrderByDescending(l => l.Monsters.Count).First().Monsters;

        // 群体税：Boss 房把 Boss 遭遇算 1 个单位，另加的怪从 +1 起收
        int tax = room.Room == RoomKind.Boss ? CrowdTax(1 + plan.Monsters.Count) : CrowdTax(plan.Monsters.Count);

        // 数量限制
        var lineup = encounterMonsters.Concat(plan.Monsters).ToList();
        if (plan.Monsters.Count > 0 && lineup.Count > MaxMonsters(room.Climbers)) errors.Add(SummonViolation.TooManyMonsters);
        if (lineup.GroupBy(m => m).Any(g => g.Count() > Config.MaxSameMonster)) errors.Add(SummonViolation.TooManySameMonster);

        // 陷阱
        if (plan.Traps > Config.MaxTrapsPerBattle) errors.Add(SummonViolation.TooManyTraps);
        if (opening && plan.Traps > 0) errors.Add(SummonViolation.OpeningProtectionTraps);
        int trapCost = Math.Max(0, plan.Traps) * Config.TrapPlaceCost;

        // 花费上限
        double cap = room.Room switch
        {
            RoomKind.Monster => std * (opening ? Config.OpeningSpendCapMultiplier : Config.NormalSpendCapMultiplier),
            RoomKind.Elite => std * Config.EliteSpendCapMultiplier,
            _ => act.AverageNormalStandardCost * Config.BossExtraSpendCapMultiplier,
        };
        if (price + tax > cap + 1e-9)
            errors.Add(room.Room == RoomKind.Boss ? SummonViolation.OverBossExtraCap
                : opening ? SummonViolation.OpeningProtectionCost : SummonViolation.OverSpendCap);

        int total = price + tax + trapCost;
        if (total > room.Savings) errors.Add(SummonViolation.NotEnoughPoints);

        return new SummonQuote(errors.Distinct().ToList(), price, tax, trapCost, std, cap, lineup);
    }
}
