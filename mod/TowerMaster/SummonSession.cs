using TowerMaster.Core;

namespace TowerMaster;

/// <summary>召唤面板上一个可选项：怪物或 Boss 遭遇。</summary>
/// <param name="HomeAct">怪物最早出现在第几幕（跨幕的怪在卡片上标出来）。</param>
/// <param name="IsElite">精英类怪物（每个房间最多一只）。</param>
/// <param name="HpFactor">「水土不服」后的血量倍数（1 = 不变）。</param>
internal sealed record SummonOption(string Id, string Name, int Price, int HomeAct = 0, bool IsElite = false, double HpFactor = 1);

/// <summary>
/// 一次召唤阶段的状态：选了什么、报价。不碰 Godot，界面只负责把它画出来、把点击转给它。
/// 规则（用户要求）：每个房间都能召唤任何幕的普通、精英怪（Boss 除外）；精英房所有怪打折；
/// Boss 房在候选里选一个 Boss（免费），还能另加任何怪（这个 Boss 有专用场景时不能另加）。
/// 默认不限时（<see cref="TowerMasterConfig.SummonPhaseSeconds"/> = 0）。
/// </summary>
internal sealed class SummonSession
{
    private readonly SummonRules _rules;
    private readonly List<string> _monsters = new();
    private readonly Func<string, bool> _bossAllowsExtras;
    private readonly List<int> _traps = new();

    /// <param name="allowMonster">哪些怪能选（排除依赖专用场景、槽位的怪）；null 表示不限制。</param>
    /// <param name="bossAllowsExtras">这个 Boss 能不能另加怪（有专用场景、命名槽位的不能）；null 表示都能。</param>
    public SummonSession(SummonRules rules, RoomContext room, IReadOnlyList<string> bossCandidates, double seconds,
        Func<string, bool>? allowMonster = null, Func<string, bool>? bossAllowsExtras = null, IReadOnlyList<TrapCard>? trapHand = null)
    {
        TrapHand = trapHand ?? [];
        _rules = rules;
        Room = room;
        SecondsLeft = seconds;
        Unlimited = seconds <= 0;
        _bossAllowsExtras = bossAllowsExtras ?? (_ => true);
        var act = rules.Prices.Act(room.ActId);
        bool opening = rules.IsOpeningProtected(room);

        MonsterOptions = rules.Prices.AllMonsters
            .Where(m => rules.IsSummonable(m.Key) && (allowMonster?.Invoke(m.Key) ?? true)
                        && (!opening || rules.OpeningAllows(room.ActId, m.Key)))
            .Select(m => new SummonOption(m.Key, m.Value.NameZh, rules.SummonPrice(m.Key, act.ActNo, room.Room),
                m.Value.HomeAct, m.Value.Role == MonsterRole.Elite, rules.HpFactor(m.Key, act.ActNo)))
            // 本幕的怪排前面，然后按幕；同一幕里普通怪在前、按价格
            .OrderBy(o => o.HomeAct == act.ActNo ? 0 : 1).ThenBy(o => o.HomeAct).ThenBy(o => o.IsElite).ThenBy(o => o.Price)
            .ThenBy(o => o.Id, StringComparer.Ordinal)
            .ToList();

        EncounterOptions = room.Room == RoomKind.Boss
            ? bossCandidates.Where(act.Encounters.ContainsKey).Select(id => new SummonOption(id, act.Encounters[id].NameZh, 0)).ToList()
            : [];
        if (EncounterOptions.Count > 0) Encounter = EncounterOptions[0].Id; // 默认第一个候选（游戏本来的 Boss）
    }

    public RoomContext Room { get; }
    /// <summary>当前是第几幕。</summary>
    public int ActNo => _rules.Prices.Act(Room.ActId).ActNo;
    /// <summary>可召唤的怪（所有房间都有）。</summary>
    public IReadOnlyList<SummonOption> MonsterOptions { get; }
    /// <summary>Boss 房的候选 Boss；其他房间为空。</summary>
    public IReadOnlyList<SummonOption> EncounterOptions { get; }
    public IReadOnlyList<string> Monsters => _monsters;

    /// <summary>塔主手里的陷阱（召唤时可以选几张盖下）。</summary>
    public IReadOnlyList<TrapCard> TrapHand { get; }

    /// <summary>选了要盖的陷阱（TrapHand 的序号）。</summary>
    public IReadOnlyList<int> SelectedTraps => _traps;

    /// <summary>选中或取消一张陷阱。</summary>
    public void ToggleTrap(int index)
    {
        if (Done || index < 0 || index >= TrapHand.Count) return;
        if (!_traps.Remove(index)) _traps.Add(index);
        Changed?.Invoke();
    }
    public string? Encounter { get; private set; }
    public bool Unlimited { get; }
    public double SecondsLeft { get; private set; }
    public bool Done { get; private set; }
    public bool Confirmed { get; private set; }

    /// <summary>确认或放弃后调用一次。</summary>
    public event Action<SummonSession>? Finished;

    /// <summary>选择变了（面板以外的地方改的，例如测试接口），面板据此刷新。</summary>
    public event Action? Changed;

    public bool IsOpeningProtected => _rules.IsOpeningProtected(Room);

    public string NameOf(string id) =>
        MonsterOptions.Concat(EncounterOptions).FirstOrDefault(o => o.Id == id)?.Name ?? id;

    /// <summary>遭遇的代表怪物（第一种组合里召唤价最高的那只，即 Boss 本体），面板画形象用。</summary>
    public string? LeadMonsterOf(string encounterId)
    {
        var act = _rules.Prices.Act(Room.ActId);
        return act.Encounters.TryGetValue(encounterId, out var enc)
            ? enc.Lineups.FirstOrDefault()?.Monsters.OrderByDescending(m => act.TryPrice(m, out var p) ? p : 0).FirstOrDefault()
            : null;
    }

    /// <summary>某个候选 Boss 能不能另加怪（面板在 Boss 卡片上标出来）。</summary>
    public bool EncounterAllowsExtras(string encounterId) => _bossAllowsExtras(encounterId);

    /// <summary>当前选的 Boss 能不能另加怪。</summary>
    public bool BossAllowsExtras => Room.Room != RoomKind.Boss || Encounter == null || _bossAllowsExtras(Encounter);

    public SummonQuote Quote => _rules.Quote(Room, new Core.SummonPlan(Room.Room == RoomKind.Boss ? Encounter : null, _monsters, _traps.Count));

    /// <summary>规则之外、面板要提示的问题（目前只有「这个 Boss 不能另加怪」）。</summary>
    public IReadOnlyList<string> ExtraProblems =>
        Room.Room == RoomKind.Boss && _monsters.Count > 0 && !BossAllowsExtras
            ? ["这个 Boss 有专用场景，不能另加怪物"]
            : [];

    public bool CanConfirm => !Done && Quote.Ok && ExtraProblems.Count == 0;

    /// <summary>放弃时的花费（按原版出场，扣标准开销）。</summary>
    public SummonQuote FallbackQuote => _rules.Fallback(Room);

    /// <summary>实际要扣的召唤点和用于节约奖励的怪物花费。</summary>
    public (int Total, int MonsterSpend) Charge => Confirmed ? (Quote.Total, Quote.MonsterSpend) : (FallbackQuote.Total, FallbackQuote.MonsterSpend);

    public void Click(string id)
    {
        if (Done) return;
        if (EncounterOptions.Any(o => o.Id == id))
        {
            Encounter = id;
            if (!BossAllowsExtras) _monsters.Clear(); // 换成不能另加怪的 Boss：已选的另加怪清掉
        }
        else if (BossAllowsExtras) _monsters.Add(id);
        Changed?.Invoke();
    }

    /// <summary>
    /// 整份替换选择（测试接口用，重复调用不会叠加）。不认识的编号原样返回、不改任何东西；
    /// Boss 房 encounter 为 null 时保留当前 Boss。
    /// </summary>
    public IReadOnlyList<string> SetSelection(string? encounter, IReadOnlyList<string> monsters, IReadOnlyList<int>? traps = null)
    {
        var unknown = monsters.Where(m => MonsterOptions.All(o => o.Id != m)).ToList();
        if (encounter != null && EncounterOptions.All(o => o.Id != encounter)) unknown.Insert(0, encounter);
        unknown.AddRange((traps ?? []).Where(i => i < 0 || i >= TrapHand.Count).Select(i => $"陷阱序号 {i}"));
        if (Done || unknown.Count > 0) return unknown;
        if (encounter != null) Encounter = encounter;
        _monsters.Clear();
        if (BossAllowsExtras) _monsters.AddRange(monsters);
        _traps.Clear();
        _traps.AddRange((traps ?? []).Distinct());
        Changed?.Invoke();
        return [];
    }

    public void RemoveAt(int index)
    {
        if (!Done && index >= 0 && index < _monsters.Count) _monsters.RemoveAt(index);
        Changed?.Invoke();
    }

    public void Clear()
    {
        if (!Done) _monsters.Clear();
        Changed?.Invoke();
    }

    /// <summary>经过 seconds 秒；限时模式下到时间就按放弃结束。不限时什么都不做。</summary>
    public void Tick(double seconds)
    {
        if (Done || Unlimited) return;
        SecondsLeft = Math.Max(0, SecondsLeft - seconds);
        if (SecondsLeft <= 0) Finish(false);
    }

    /// <summary>确认当前选择；不合规则时什么都不做，返回 false。</summary>
    public bool Confirm()
    {
        if (!CanConfirm) return false;
        Finish(true);
        return true;
    }

    /// <summary>放弃选择，按原版出场。</summary>
    public void UseVanilla()
    {
        if (!Done) Finish(false);
    }

    private void Finish(bool confirmed)
    {
        Done = true;
        Confirmed = confirmed;
        Finished?.Invoke(this);
    }

    /// <summary>规则违反的中文说明。</summary>
    public static string Describe(SummonViolation v) => v switch
    {
        SummonViolation.UnknownMonster => "有不能召唤的怪物",
        SummonViolation.UnknownEncounter => "不是本幕的遭遇",
        SummonViolation.MonsterNotSummonable => "Boss、召唤物不能单独召唤",
        SummonViolation.EncounterRequired => "要先选一个 Boss",
        SummonViolation.EncounterNotAllowed => "这个房间不能选遭遇",
        SummonViolation.WrongEncounterRoom => "遭遇类型和房间不符",
        SummonViolation.BossNotCandidate => "不是本幕的候选 Boss",
        SummonViolation.EmptyRoom => "至少召唤一只怪物",
        SummonViolation.TooManyTraps => "每场最多盖 2 张陷阱",
        SummonViolation.OpeningProtectionMonster => "开局保护：只能用本幕的普通怪",
        SummonViolation.OpeningProtectionCost => "开局保护：花费超过本场上限",
        SummonViolation.OpeningProtectionTraps => "开局保护：不能盖陷阱",
        SummonViolation.TooManyMonsters => "场上怪物太多",
        SummonViolation.TooManySameMonster => "同名怪物太多",
        SummonViolation.TooManyElites => "每个房间最多一只精英",
        SummonViolation.OverSpendCap => "超过单场花费上限",
        SummonViolation.OverEliteExtraCap => "精英房另加小怪超过上限",
        SummonViolation.OverBossExtraCap => "Boss 房另加的怪超过上限",
        SummonViolation.NotEnoughPoints => "召唤点不够",
        _ => v.ToString(),
    };
}
