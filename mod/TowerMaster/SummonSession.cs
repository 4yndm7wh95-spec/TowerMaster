using TowerMaster.Core;

namespace TowerMaster;

/// <summary>召唤面板上一个可选项：怪物或遭遇。</summary>
internal sealed record SummonOption(string Id, string Name, int Price);

/// <summary>
/// 一次召唤阶段的状态：选了什么、报价、倒计时。不碰 Godot，界面只负责把它画出来、把点击转给它。
/// 第一版：普通房选怪物；精英房选一个本幕精英遭遇；Boss 房在候选 Boss 里选一个（免费）。精英、Boss 房暂不支持另加小怪。
/// </summary>
internal sealed class SummonSession
{
    private readonly SummonRules _rules;
    private readonly List<string> _monsters = new();

    public SummonSession(SummonRules rules, RoomContext room, IReadOnlyList<string> bossCandidates, double seconds)
    {
        _rules = rules;
        Room = room;
        SecondsLeft = seconds;
        var act = rules.Prices.Act(room.ActId);
        bool opening = rules.IsOpeningProtected(room);

        Options = room.Room switch
        {
            RoomKind.Monster => act.Monsters
                .Where(m => m.Value.Role == MonsterRole.Normal && (!opening || m.Value.WeakPool))
                .OrderBy(m => m.Value.Price).ThenBy(m => m.Key, StringComparer.Ordinal)
                .Select(m => new SummonOption(m.Key, m.Value.NameZh, m.Value.Price)).ToList(),
            RoomKind.Elite => act.Encounters.Where(e => e.Value.Room == RoomKind.Elite)
                .OrderBy(e => e.Value.StandardCost).ThenBy(e => e.Key, StringComparer.Ordinal)
                .Select(e => new SummonOption(e.Key, e.Value.NameZh, (int)Math.Ceiling(e.Value.StandardCost - 1e-9))).ToList(),
            _ => bossCandidates.Where(act.Encounters.ContainsKey)
                .Select(id => new SummonOption(id, act.Encounters[id].NameZh, 0)).ToList(),
        };
        // 精英房默认选第一个（最便宜），Boss 房默认选第一个候选（游戏本来的 Boss）
        if (room.Room != RoomKind.Monster && Options.Count > 0) Encounter = Options[0].Id;
    }

    public RoomContext Room { get; }
    public IReadOnlyList<SummonOption> Options { get; }
    public IReadOnlyList<string> Monsters => _monsters;
    public string? Encounter { get; private set; }
    public double SecondsLeft { get; private set; }
    public bool Done { get; private set; }
    public bool Confirmed { get; private set; }

    /// <summary>确认或超时后调用一次。</summary>
    public event Action<SummonSession>? Finished;

    public bool IsOpeningProtected => _rules.IsOpeningProtected(Room);
    public string NameOf(string id) => Options.FirstOrDefault(o => o.Id == id)?.Name ?? id;

    public SummonQuote Quote => _rules.Quote(Room, new Core.SummonPlan(Room.Room == RoomKind.Monster ? null : Encounter, _monsters));

    /// <summary>超时或选择「按原版出场」时的花费。</summary>
    public SummonQuote FallbackQuote => _rules.Fallback(Room);

    /// <summary>实际要扣的召唤点和用于节约奖励的怪物花费。</summary>
    public (int Total, int MonsterSpend) Charge => Confirmed ? (Quote.Total, Quote.MonsterSpend) : (FallbackQuote.Total, FallbackQuote.MonsterSpend);

    public void Click(string id)
    {
        if (Done) return;
        if (Room.Room == RoomKind.Monster) _monsters.Add(id);
        else Encounter = id;
    }

    public void RemoveAt(int index)
    {
        if (!Done && index >= 0 && index < _monsters.Count) _monsters.RemoveAt(index);
    }

    public void Clear()
    {
        if (!Done) _monsters.Clear();
    }

    /// <summary>经过 seconds 秒；到时间就按超时结束。</summary>
    public void Tick(double seconds)
    {
        if (Done) return;
        SecondsLeft = Math.Max(0, SecondsLeft - seconds);
        if (SecondsLeft <= 0) Finish(false);
    }

    /// <summary>确认当前选择；不合规则时什么都不做，返回 false。</summary>
    public bool Confirm()
    {
        if (Done || !Quote.Ok) return false;
        Finish(true);
        return true;
    }

    /// <summary>放弃选择，按原版出场（和超时一样）。</summary>
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
        SummonViolation.UnknownMonster => "有不属于本幕的怪物",
        SummonViolation.UnknownEncounter => "不是本幕的遭遇",
        SummonViolation.MonsterNotSummonable => "精英、Boss、召唤物不能单独召唤",
        SummonViolation.EncounterRequired => "要先选一个遭遇",
        SummonViolation.EncounterNotAllowed => "普通房不能选遭遇",
        SummonViolation.WrongEncounterRoom => "遭遇类型和房间不符",
        SummonViolation.BossNotCandidate => "不是本幕的候选 Boss",
        SummonViolation.EmptyRoom => "至少召唤一只怪物",
        SummonViolation.OpeningProtectionMonster => "开局保护：只能用简单遭遇的怪物",
        SummonViolation.OpeningProtectionCost => "开局保护：花费不能超过标准开销",
        SummonViolation.OpeningProtectionTraps => "开局保护：不能盖陷阱",
        SummonViolation.TooManyMonsters => "场上怪物太多",
        SummonViolation.TooManySameMonster => "同名怪物太多",
        SummonViolation.TooManyTraps => "陷阱太多",
        SummonViolation.OverSpendCap => "超过单场花费上限",
        SummonViolation.OverEliteExtraCap => "精英房另加小怪超过上限",
        SummonViolation.OverBossExtraCap => "Boss 房另加小怪超过上限",
        SummonViolation.NotEnoughPoints => "召唤点不够",
        _ => v.ToString(),
    };
}
