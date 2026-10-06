using HarmonyLib;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.GameActions;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Models.Cards;
using MegaCrit.Sts2.Core.Models.Encounters;
using MegaCrit.Sts2.Core.Models.Monsters;
using MegaCrit.Sts2.Core.Models.Powers;
using MegaCrit.Sts2.Core.Runs;
using TowerMaster.Core;
using Xunit;

namespace TowerMaster.Tests;

/// <summary>塔主回合：开回合暂停玩家队列 → 塔主操作经联机动作在各端施加 → 结束恢复；限制、目标核对、战斗结束兜底。</summary>
public class ThreatPhaseTests
{
    private sealed class FakeUi : IThreatUi
    {
        public bool Open { get; private set; }
        public void Show() { Open = true; Shown.Add(this); }
        public void Close() => Open = false;
    }

    private static readonly List<FakeUi> Shown = new();
    private static readonly List<bool> Banners = new();
    private static bool _patched;

    private sealed record Setup(ActionQueueSynchronizer Queue, CombatManager Manager, CombatState Combat, Player Climber);

    private static Setup Init(NetGameType type = NetGameType.Host, int threat = 10)
    {
        var run = new RunState();
        run.Players.Add(new Player(100001));
        var climber = new Player(100002);
        climber.PlayerCombatState.Hand.Cards.Add(new Strike());
        run.Players.Add(climber);
        RunManager.Instance.State = run;
        RunManager.Instance.NetService = new() { Type = type, NetId = type == NetGameType.Client ? 100002UL : 100001UL, HostNetId = 100001 };
        RunManager.Instance.ActionQueueSet = new ActionQueueSet();
        var queue = new ActionQueueSynchronizer(RunManager.Instance.NetService);
        RunManager.Instance.ActionQueueSynchronizer = queue;
        var prices = PriceBook.Load(Path.Combine(Log.ModDir, "price_book.data"));
        var config = new TowerMasterConfig { ThreatPerBattle = [threat, threat, threat], MasterTurnSeconds = 20 };
        if (!_patched)
        {
            Log.Init();
            var harmony = new Harmony("towermaster.threat");
            Test1bMixedEncounter.Apply(harmony, new TestSettings { Test1bMixedEncounter = true, SummonPhase = true }, prices);
            ThreatPhase.Apply(harmony, config, prices);
            _patched = true;
        }
        Test1FixedEncounter.SetEnabled(false);
        SummonPhase.Disable();
        ThreatPhase.Apply(new Harmony("towermaster.threat"), config, prices); // 已挂过，只换配置、打开开关
        ThreatPhase.UiFactory = () => new FakeUi();
        ThreatPhase.Banner = Banners.Add;
        SummonPhase.Toast = _ => { };
        Shown.Clear();
        Banners.Clear();

        var combat = new CombatState(ModelDb.Encounter<CultistsNormal>().ToMutable(), run);
        combat.CreateCreature(new Nibbit().ToMutable(), 40);
        combat.CreateCreature(new Mawler().ToMutable(), 50);
        var manager = new CombatManager();
        CombatManager.Instance = manager;
        manager.SetUpCombat(combat);
        return new Setup(queue, manager, combat, climber);
    }

    /// <summary>按顺序执行队列里还没执行的动作。</summary>
    private static async Task Run(ActionQueueSynchronizer queue, int from = 0)
    {
        foreach (var action in queue.Queued.Skip(from).ToList()) await action.Execute();
    }

    [Fact]
    public async Task MasterTurnPausesPlayersAppliesEffectsAndResumes()
    {
        var s = Init(threat: 3);
        Assert.Equal(3, ThreatPhase.Session!.Points);
        s.Manager.StartTurn(CombatSide.Player, 1);
        Assert.True(ThreatPhase.TurnOpen);
        Assert.True(Assert.Single(Shown).Open);
        var begin = Assert.Single(s.Queue.Queued);
        Assert.Equal(GameActionType.CombatPlayPhaseOnly, begin.ActionType); // 各端进了出牌阶段才开始（0.0.20 用 Any 导致不同步）
        await begin.Execute();
        Assert.True(RunManager.Instance.ActionQueueSet.Paused);

        Assert.True(ThreatPhase.Act("block", 0).Ok);
        Assert.Equal(GameActionType.Any, s.Queue.Queued[1].ActionType); // 操作在玩家队列暂停时也要能执行
        Assert.True(ThreatPhase.Act("strength", 1).Ok); // 3 − 1 − 2 = 0：自动结束
        Assert.False(ThreatPhase.TurnOpen);
        Assert.False(Shown[0].Open);
        await Run(s.Queue, 1);
        Assert.Equal(6, s.Combat.Enemies[0].Block);
        Assert.Equal(1, s.Combat.Enemies[1].Powers.OfType<StrengthPower>().Single().Amount);
        Assert.False(RunManager.Instance.ActionQueueSet.Paused);

        // 没有威胁点了：下一回合不再开塔主回合
        int queued = s.Queue.Queued.Count;
        s.Manager.StartTurn(CombatSide.Player, 2);
        Assert.Equal(queued, s.Queue.Queued.Count);
        Assert.False(ThreatPhase.TurnOpen);
    }

    [Fact]
    public async Task DebuffsDazedAndLimits()
    {
        var s = Init();
        s.Manager.StartTurn(CombatSide.Enemy, 1); // 怪物回合不开
        Assert.False(ThreatPhase.TurnOpen);
        s.Manager.StartTurn(CombatSide.Player, 1);
        Assert.True(ThreatPhase.Act("weak", player: 100002).Ok);
        var limited = ThreatPhase.Act("frail", player: 100002); // 同一玩家每回合 1 次减益
        Assert.False(limited.Ok);
        Assert.Contains("本回合", limited.Message);
        Assert.False(ThreatPhase.Act("weak", player: 100001).Ok); // 塔主不是目标
        Assert.True(ThreatPhase.Act("dazed", player: 100002).Ok);
        Assert.True(ThreatPhase.Act("heal", 0).Ok);
        Assert.True(ThreatPhase.Act("strength_all").Ok);
        Assert.False(ThreatPhase.Act("strength_all").Ok); // 每场 1 次
        Assert.False(ThreatPhase.Act("block", 5).Ok);     // 没有这只怪
        ThreatPhase.EndTurn();
        await Run(s.Queue);

        Assert.Equal(1, s.Climber.Creature.Powers.OfType<WeakPower>().Single().Amount);
        Assert.IsType<Dazed>(Assert.Single(s.Climber.PlayerCombatState.DrawPile.Cards));
        Assert.All(s.Combat.Enemies, e => Assert.Equal(1, e.Powers.OfType<StrengthPower>().Single().Amount));
        Assert.False(RunManager.Instance.ActionQueueSet.Paused);

        // 下一回合减益次数重置
        s.Manager.StartTurn(CombatSide.Player, 2);
        Assert.True(ThreatPhase.Act("frail", player: 100002).Ok);
        var (monsters, players) = ThreatPhase.Snapshot();
        Assert.Equal(2, monsters.Count);
        Assert.Equal(1, monsters[0].HealsLeft);
        Assert.Equal(new[] { "打击" }, Assert.Single(players).Hand);
    }

    [Fact]
    public async Task ClientShowsBannerAndSkipsMismatchedTarget()
    {
        var s = Init(NetGameType.Client);
        Assert.Null(ThreatPhase.Session); // 爬塔玩家这边没有威胁点
        s.Manager.StartTurn(CombatSide.Player, 1);
        Assert.Empty(s.Queue.Queued);    // 只有房主发指令

        static GameAction Command(string op, int monster = -1, string? id = null, int amount = 0) =>
            (GameAction)RuntimeNetAction.Create(100001, ThreatPhase.Prefix + System.Text.Json.JsonSerializer.Serialize(
                new ThreatCommand(1, 1, 123, 1, op, monster, id, 0, amount)));

        await Command("begin").Execute();
        Assert.True(RunManager.Instance.ActionQueueSet.Paused);
        Assert.Equal(new[] { true }, Banners);
        await Command("block", 0, "Mawler", 6).Execute(); // 下标 0 是小啃兽：对不上，跳过
        Assert.Equal(0, s.Combat.Enemies[0].Block);
        await Command("block", 0, "Nibbit", 6).Execute();
        Assert.Equal(6, s.Combat.Enemies[0].Block);

        s.Manager.End(null!); // 塔主回合中战斗结束：兜底恢复
        Assert.False(RunManager.Instance.ActionQueueSet.Paused);
        Assert.Equal(new[] { true, false }, Banners);
    }

    [Fact]
    public void TimeoutEndsTheTurn()
    {
        var s = Init();
        s.Manager.StartTurn(CombatSide.Player, 1);
        ThreatPhase.Tick(19);
        Assert.True(ThreatPhase.TurnOpen);
        ThreatPhase.Tick(2);
        Assert.False(ThreatPhase.TurnOpen);
        Assert.Equal(2, s.Queue.Queued.Count); // begin + end
    }
}
