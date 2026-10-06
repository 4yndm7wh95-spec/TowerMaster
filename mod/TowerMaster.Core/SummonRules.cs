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
/// <param name="Encounter">精英房、Boss 房选的原版遭遇类名；普通房必须为 null。</param>
/// <param name="Monsters">普通房的全部怪物；精英房、Boss 房另加的小怪。</param>
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

    /// <summary>超时未确认：按原版组合出场，花费按标准开销（不够就扣到 0）。</summary>
    public SummonQuote Fallback(RoomContext room)
    {
        int std = StandardCostOf(room);
        int paid = Math.Min(std, Math.Max(0, room.Savings));
        return new SummonQuote([], paid, 0, 0, std, std, room.OriginalLineup);
    }

    public SummonQuote Quote(RoomContext room, SummonPlan plan)
    {
        var act = Prices.Act(room.ActId);
        var errors = new List<SummonViolation>();
        int std = StandardCostOf(room);
        bool opening = IsOpeningProtected(room);

        // 怪物本身是否可召唤：只能用本幕的普通怪（精英、Boss 只能通过遭遇出场；怪物召唤出的小怪不单卖）。
        int price = 0;
        foreach (var m in plan.Monsters)
        {
            if (!act.Monsters.TryGetValue(m, out var info)) { errors.Add(SummonViolation.UnknownMonster); continue; }
            if (info.Role != MonsterRole.Normal) errors.Add(SummonViolation.MonsterNotSummonable);
            else if (opening && !info.WeakPool) errors.Add(SummonViolation.OpeningProtectionMonster);
            price += info.Price;
        }

        // 精英、Boss 房的遭遇本体。
        List<string> encounterMonsters = [];
        int encounterPrice = 0;
        if (room.Room == RoomKind.Monster)
        {
            if (plan.Encounter != null) errors.Add(SummonViolation.EncounterNotAllowed);
            if (plan.Monsters.Count == 0) errors.Add(SummonViolation.EmptyRoom);
        }
        else if (plan.Encounter == null)
        {
            errors.Add(SummonViolation.EncounterRequired);
        }
        else if (!act.Encounters.TryGetValue(plan.Encounter, out var enc))
        {
            errors.Add(SummonViolation.UnknownEncounter);
        }
        else if (enc.Room != room.Room)
        {
            errors.Add(SummonViolation.WrongEncounterRoom);
        }
        else if (room.Room == RoomKind.Boss && room.BossCandidates != null && !room.BossCandidates.Contains(plan.Encounter))
        {
            errors.Add(SummonViolation.BossNotCandidate);
        }
        else
        {
            // 随机组合的遭遇按最大的那组算数量（实际组合由游戏生成，价格按期望标准开销向上取整）。
            encounterMonsters = enc.Lineups.OrderByDescending(l => l.Monsters.Count).First().Monsters;
            if (room.Room == RoomKind.Elite) encounterPrice = (int)Math.Ceiling(enc.StandardCost - 1e-9);
        }

        // 群体税：普通房按怪物只数；精英、Boss 房把遭遇本体算 1 个单位，另加的小怪从 +1 起收。
        int tax = room.Room == RoomKind.Monster
            ? CrowdTax(plan.Monsters.Count)
            : CrowdTax(1 + plan.Monsters.Count);
        int extraSpend = price + tax;
        int monsterPrice = price + encounterPrice;

        // 数量限制。
        var lineup = encounterMonsters.Concat(plan.Monsters).ToList();
        if (plan.Monsters.Count > 0 && lineup.Count > MaxMonsters(room.Climbers)) errors.Add(SummonViolation.TooManyMonsters);
        if (lineup.GroupBy(m => m).Any(g => g.Count() > Config.MaxSameMonster)) errors.Add(SummonViolation.TooManySameMonster);

        // 陷阱。
        if (plan.Traps > Config.MaxTrapsPerBattle) errors.Add(SummonViolation.TooManyTraps);
        if (opening && plan.Traps > 0) errors.Add(SummonViolation.OpeningProtectionTraps);
        int trapCost = Math.Max(0, plan.Traps) * Config.TrapPlaceCost;

        // 花费上限。
        double cap;
        switch (room.Room)
        {
            case RoomKind.Monster:
                cap = opening ? std : std * Config.NormalSpendCapMultiplier;
                if (monsterPrice + tax > cap + 1e-9)
                    errors.Add(opening ? SummonViolation.OpeningProtectionCost : SummonViolation.OverSpendCap);
                break;
            case RoomKind.Elite:
                cap = std * Config.EliteSpendCapMultiplier;
                if (extraSpend > Config.EliteExtraSpendCap) errors.Add(SummonViolation.OverEliteExtraCap);
                if (monsterPrice + tax > cap + 1e-9) errors.Add(SummonViolation.OverSpendCap);
                break;
            default:
                cap = act.AverageNormalStandardCost * Config.BossExtraSpendCapMultiplier;
                if (extraSpend > cap + 1e-9) errors.Add(SummonViolation.OverBossExtraCap);
                break;
        }

        int total = monsterPrice + tax + trapCost;
        if (total > room.Savings) errors.Add(SummonViolation.NotEnoughPoints);

        return new SummonQuote(errors.Distinct().ToList(), monsterPrice, tax, trapCost, std, cap, lineup);
    }
}
