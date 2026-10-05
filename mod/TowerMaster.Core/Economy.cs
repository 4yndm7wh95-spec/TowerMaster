namespace TowerMaster.Core;

/// <summary>一场战斗后的召唤点收入明细。</summary>
public sealed record IncomeBreakdown(int Base, int Savings, int Damage, int Knockdown, int Wasted)
{
    /// <summary>实际入账（已扣掉超出储蓄上限作废的部分）。</summary>
    public int Credited => Base + Savings + Damage + Knockdown - Wasted;
}

/// <summary>战斗结果，由 mod 在战斗结束时汇总。</summary>
/// <param name="Room">房间类型。</param>
/// <param name="StandardCost">本房间标准开销。</param>
/// <param name="MonsterSpend">塔主本场的怪物花费（召唤价 + 群体税，不含陷阱）。</param>
/// <param name="DamageTaken">本场所有爬塔玩家合计掉的血。</param>
/// <param name="KnockedDown">本场被击倒（但队友打完了房间）的玩家。</param>
public sealed record BattleResult(
    RoomKind Room,
    int StandardCost,
    int MonsterSpend,
    int DamageTaken,
    IReadOnlyCollection<ulong> KnockedDown);

/// <summary>
/// 塔主的召唤点钱包（设计文档「两种点数」「召唤点收入」「击倒奖励」）。
/// 所有客户端用同样的输入按同样的顺序调用，结果一致，不需要额外同步。
/// </summary>
public sealed class SummonWallet
{
    private readonly TowerMasterConfig _config;
    private readonly HashSet<ulong> _knockedDownLastBattle = new();

    public SummonWallet(TowerMasterConfig config, int actNo = 1)
    {
        _config = config;
        ActNo = actNo;
        Points = Math.Min(config.StartingSummonPoints, Cap);
    }

    public int Points { get; private set; }
    public int ActNo { get; private set; }
    public int Cap => TowerMasterConfig.ByAct(_config.SavingsCap, ActNo);

    /// <summary>扣除召唤花费。不够时抛异常：调用前应已用 <see cref="SummonRules.Quote"/> 校验。</summary>
    public void Spend(int amount)
    {
        if (amount < 0 || amount > Points) throw new InvalidOperationException($"召唤点不足：需要 {amount}，只有 {Points}");
        Points -= amount;
    }

    /// <summary>进入新一幕：超出新上限的部分作废。返回作废数。</summary>
    public int EnterAct(int actNo)
    {
        ActNo = actNo;
        int wasted = Math.Max(0, Points - Cap);
        Points -= wasted;
        return wasted;
    }

    /// <summary>基础收入 × 人数系数，向下取整。</summary>
    public int BaseIncome(int climbers) =>
        (int)Math.Floor(TowerMasterConfig.ByAct(_config.BaseIncome, ActNo)
                        * TowerMasterConfig.ByClimbers(_config.ClimberIncomeFactor, climbers) + 1e-9);

    /// <summary>节约奖励：(标准开销 − 实际花费) ÷ 2 向下取整，最多 +3；花超了不扣。Boss 房没有标准开销，不给。</summary>
    public int SavingsBonus(RoomKind room, int standardCost, int monsterSpend)
    {
        if (room == RoomKind.Boss) return 0;
        int saved = standardCost - monsterSpend;
        return saved <= 0 ? 0 : Math.Min(_config.SavingsBonusMax, saved / _config.SavingsBonusDivisor);
    }

    /// <summary>战果奖励：所有玩家合计每掉 10 点血 +1。</summary>
    public int DamageBonus(int damageTaken) => Math.Max(0, damageTaken) / _config.DamagePerBonusPoint;

    /// <summary>
    /// 本场哪些击倒给奖励：同一玩家连续两场被击倒时，第二次不给。
    /// 调用后会记住本场的击倒，供下一场判断，所以每场战斗只调用一次（<see cref="SettleBattle"/> 内部会调）。
    /// </summary>
    private List<ulong> RewardedKnockdowns(IReadOnlyCollection<ulong> knockedDown)
    {
        var rewarded = knockedDown.Where(p => !_knockedDownLastBattle.Contains(p)).Distinct().ToList();
        _knockedDownLastBattle.Clear();
        _knockedDownLastBattle.UnionWith(knockedDown);
        return rewarded;
    }

    /// <summary>
    /// 战斗结束结算收入，入账并返回明细。<paramref name="rewardedKnockdowns"/> 是拿到击倒奖励的玩家
    /// （每人另从当前幕牌池抽 1 张陷阱，由陷阱系统处理）。
    /// </summary>
    public IncomeBreakdown SettleBattle(BattleResult result, int climbers, out IReadOnlyList<ulong> rewardedKnockdowns)
    {
        rewardedKnockdowns = RewardedKnockdowns(result.KnockedDown);
        int @base = BaseIncome(climbers);
        int savings = SavingsBonus(result.Room, result.StandardCost, result.MonsterSpend);
        int damage = DamageBonus(result.DamageTaken);
        int knockdown = rewardedKnockdowns.Count * _config.KnockdownSummonPoints;
        int gross = @base + savings + damage + knockdown;
        int wasted = Math.Max(0, Points + gross - Cap);
        Points += gross - wasted;
        return new IncomeBreakdown(@base, savings, damage, knockdown, wasted);
    }

    /// <summary>宝箱等额外来源：同样受储蓄上限限制。返回实际入账。</summary>
    public int Gain(int amount)
    {
        int credited = Math.Clamp(Cap - Points, 0, Math.Max(0, amount));
        Points += credited;
        return credited;
    }
}
