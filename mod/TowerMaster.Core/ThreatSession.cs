namespace TowerMaster.Core;

public enum PlayerDebuff { Weak, Vulnerable, Frail }

public enum ThreatViolation
{
    None,
    NotEnoughThreat,
    HealLimit,
    DebuffLimit,
    DazedLimit,
    StrengthCap,
    StrengthAllLimit,
    NoTarget,
}

/// <summary>一次塔主操作的结果。<see cref="Amount"/> 是要实际施加的数值（格挡量、回血量、力量、层数）。</summary>
public readonly record struct ThreatResult(ThreatViolation Violation, int Amount, IReadOnlyList<int>? Monsters = null)
{
    public bool Ok => Violation == ThreatViolation.None;
    public static ThreatResult Fail(ThreatViolation v) => new(v, 0);
}

/// <summary>
/// 一场战斗内的威胁点和各项限制（设计文档「威胁点价目表」）。
/// 怪物用战斗内的 id（int）标识，玩家用联机 id（ulong）标识。
/// 只负责「能不能做、花多少、效果多大」；真正改游戏状态由 mod 的联机动作执行。
/// </summary>
public sealed class ThreatSession
{
    private readonly ThreatPrices _p;
    private readonly Dictionary<int, int> _heals = new();
    private readonly Dictionary<int, int> _strength = new();
    private readonly Dictionary<ulong, int> _debuffsThisTurn = new();
    private int _dazed;
    private int _strengthAll;

    public ThreatSession(TowerMasterConfig config, int actNo, RoomKind room, int climbers)
    {
        _p = config.Threat;
        ActNo = actNo;
        Points = Allotment(config, actNo, room, climbers);
    }

    public int ActNo { get; }
    public int Points { get; private set; }
    public int Turn { get; private set; } = 1;

    /// <summary>每场威胁点：按幕 3/4/5，精英 +1，Boss +2，每多 1 名爬塔玩家 +1。</summary>
    public static int Allotment(TowerMasterConfig config, int actNo, RoomKind room, int climbers) =>
        TowerMasterConfig.ByAct(config.ThreatPerBattle, actNo)
        + room switch { RoomKind.Elite => config.ThreatEliteBonus, RoomKind.Boss => config.ThreatBossBonus, _ => 0 }
        + Math.Max(0, climbers - 1) * config.ThreatPerExtraClimber;

    /// <summary>每只怪物累计力量上限 = 幕数 × 2。</summary>
    public int StrengthCap => ActNo * _p.StrengthCapPerAct;

    public int StrengthOf(int monster) => _strength.GetValueOrDefault(monster);

    /// <summary>这只怪本场还能回几次血。</summary>
    public int HealsLeft(int monster) => Math.Max(0, _p.HealPerMonsterPerBattle - _heals.GetValueOrDefault(monster));

    /// <summary>进入新的一轮（玩家抽牌后、塔主回合开始前调用）。</summary>
    public void NextTurn()
    {
        Turn++;
        _debuffsThisTurn.Clear();
    }

    private bool Pay(int cost)
    {
        if (Points < cost) return false;
        Points -= cost;
        return true;
    }

    public ThreatResult Block(int monster) =>
        Pay(_p.BlockCost)
            ? new ThreatResult(ThreatViolation.None, TowerMasterConfig.ByAct(_p.BlockAmount, ActNo), [monster])
            : ThreatResult.Fail(ThreatViolation.NotEnoughThreat);

    public ThreatResult Heal(int monster, int maxHp)
    {
        if (_heals.GetValueOrDefault(monster) >= _p.HealPerMonsterPerBattle) return ThreatResult.Fail(ThreatViolation.HealLimit);
        if (!Pay(_p.HealCost)) return ThreatResult.Fail(ThreatViolation.NotEnoughThreat);
        _heals[monster] = _heals.GetValueOrDefault(monster) + 1;
        return new ThreatResult(ThreatViolation.None, Math.Max(1, maxHp * _p.HealPercent / 100), [monster]);
    }

    public ThreatResult Debuff(ulong player, PlayerDebuff kind)
    {
        _ = kind; // 三种减益同价，共用每回合次数
        if (_debuffsThisTurn.GetValueOrDefault(player) >= _p.DebuffPerPlayerPerTurn) return ThreatResult.Fail(ThreatViolation.DebuffLimit);
        if (!Pay(_p.DebuffCost)) return ThreatResult.Fail(ThreatViolation.NotEnoughThreat);
        _debuffsThisTurn[player] = _debuffsThisTurn.GetValueOrDefault(player) + 1;
        return new ThreatResult(ThreatViolation.None, _p.DebuffStacks);
    }

    public ThreatResult Dazed(ulong player)
    {
        _ = player;
        if (_dazed >= _p.DazedPerBattle) return ThreatResult.Fail(ThreatViolation.DazedLimit);
        if (!Pay(_p.DazedCost)) return ThreatResult.Fail(ThreatViolation.NotEnoughThreat);
        _dazed++;
        return new ThreatResult(ThreatViolation.None, 1);
    }

    /// <summary>单只加力量：超过累计上限就拒绝（不截断，免得白花点数）。</summary>
    public ThreatResult Strength(int monster)
    {
        int amount = TowerMasterConfig.ByAct(_p.StrengthAmount, ActNo);
        if (StrengthOf(monster) + amount > StrengthCap) return ThreatResult.Fail(ThreatViolation.StrengthCap);
        if (!Pay(_p.StrengthCost)) return ThreatResult.Fail(ThreatViolation.NotEnoughThreat);
        _strength[monster] = StrengthOf(monster) + amount;
        return new ThreatResult(ThreatViolation.None, amount, [monster]);
    }

    /// <summary>所有怪物加力量：已到上限的怪物跳过；全都到上限就拒绝。</summary>
    public ThreatResult StrengthAll(IEnumerable<int> aliveMonsters)
    {
        if (_strengthAll >= _p.StrengthAllPerBattle) return ThreatResult.Fail(ThreatViolation.StrengthAllLimit);
        var targets = aliveMonsters.Distinct().Where(m => StrengthOf(m) + _p.StrengthAllAmount <= StrengthCap).ToList();
        if (targets.Count == 0) return ThreatResult.Fail(ThreatViolation.NoTarget);
        if (!Pay(_p.StrengthAllCost)) return ThreatResult.Fail(ThreatViolation.NotEnoughThreat);
        _strengthAll++;
        foreach (var m in targets) _strength[m] = StrengthOf(m) + _p.StrengthAllAmount;
        return new ThreatResult(ThreatViolation.None, _p.StrengthAllAmount, targets);
    }

    /// <summary>陷阱给的力量：陷阱自动触发不能拒绝，所以截断到上限。返回实际加的量。</summary>
    public int AddTrapStrength(int monster, int amount)
    {
        int applied = Math.Clamp(StrengthCap - StrengthOf(monster), 0, Math.Max(0, amount));
        _strength[monster] = StrengthOf(monster) + applied;
        return applied;
    }
}
