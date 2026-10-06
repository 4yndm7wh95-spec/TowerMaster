using HarmonyLib;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.GameActions;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.Map;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Models.Acts;
using MegaCrit.Sts2.Core.Models.Encounters;
using MegaCrit.Sts2.Core.Rooms;
using MegaCrit.Sts2.Core.Runs;
using TowerMaster.Core;
using Xunit;

namespace TowerMaster.Tests;

/// <summary>召唤阶段：扣住移动 → 面板（假的）→ 确认或超时 → 广播清单、扣点、放行 → 进房按清单生成 → 胜利后结算收入。</summary>
public class SummonPhaseTests
{
    private sealed class FakeUi(SummonSession session) : ISummonUi
    {
        public SummonSession Session { get; } = session;
        public void Show() => Shown.Add(this);
        public void Close() { }
    }

    private static readonly List<FakeUi> Shown = new();
    private static readonly List<string> Toasts = new();
    private static bool _patched;
    private static readonly Player Master = new(100001), Climber = new(100002);

    private static ActionQueueSynchronizer Init(NetGameType type = NetGameType.Host)
    {
        var run = new RunState();
        run.Players.Add(new Player(100001));
        run.Players.Add(new Player(100002));
        RunManager.Instance.State = run;
        RunManager.Instance.NetService = new() { Type = type, NetId = type == NetGameType.Client ? 100002UL : 100001UL, HostNetId = 100001 };
        var queue = new ActionQueueSynchronizer(RunManager.Instance.NetService);
        RunManager.Instance.ActionQueueSynchronizer = queue;
        var prices = PriceBook.Load(Path.Combine(Log.ModDir, "price_book.data"));
        var settings = new TestSettings { Test1bMixedEncounter = true, SummonPhase = true };
        if (!_patched)
        {
            Log.Init();
            var harmony = new Harmony("towermaster.summon");
            Test1bMixedEncounter.Apply(harmony, settings, prices);
            SummonPhase.Apply(harmony, new TowerMasterConfig(), prices);
            _patched = true;
        }
        Test1bMixedEncounter.Configure(settings, prices);
        PlanStore.Clear();
        MasterLedger.Clear();
        SummonPhase.Configure(new TowerMasterConfig(), prices);
        SummonPhase.Apply(new Harmony("towermaster.summon"), new TowerMasterConfig(), prices); // 已挂过，只打开开关
        SummonPhase.UiFactory = s => new FakeUi(s);
        Test1FixedEncounter.SetEnabled(false); // 同一进程里测试 1a 的补丁也挂着，关掉免得它再换一次遭遇
        SummonPhase.Toast = Toasts.Add;
        Shown.Clear();
        Toasts.Clear();
        return queue;
    }

    private static MoveToMapCoordAction MoveTo(MapPointType type)
    {
        var coord = new MapCoord(3, 1);
        ((RunState)RunManager.Instance.State).Map.Points[coord] = new MapPoint(type);
        return new MoveToMapCoordAction(100001, coord);
    }

    /// <summary>按队列顺序执行动作，然后进房（楼层 +1）生成怪物。</summary>
    private static async Task<EncounterModel> RunQueueAndEnter(ActionQueueSynchronizer queue, RoomType roomType)
    {
        foreach (var action in queue.Queued.ToList()) await action.Execute();
        var state = RunManager.Instance.State;
        var encounter = new Overgrowth().PullNextEncounter(roomType).ToMutable();
        state.TotalFloor++;
        new CombatRoom(encounter, state).StartCombat();
        return encounter;
    }

    private static string[] Names(EncounterModel e) => e.MonstersWithSlots.Select(m => m.Monster.GetType().Name).ToArray();

    [Fact]
    public async Task NormalRoomHoldsMoveUntilConfirmedThenMixesChosenMonsters()
    {
        var queue = Init();
        queue.RequestEnqueue(MoveTo(MapPointType.Monster));
        Assert.Empty(queue.Queued); // 移动被扣住
        var session = Assert.Single(Shown).Session;
        Assert.Equal(RoomKind.Monster, session.Room.Room);
        Assert.True(session.IsOpeningProtected); // 第一幕第一场：开局保护
        Assert.All(session.Options, o => Assert.Contains(o.Id, new[] { "FuzzyWurmCrawler", "Nibbit", "ShrinkerBeetle", "LeafSlimeM", "LeafSlimeS", "TwigSlimeM", "TwigSlimeS" }));

        session.Click("Nibbit");
        Assert.True(session.Quote.Ok, string.Join(",", session.Quote.Violations)); // 开局保护标准开销 3，小啃兽 2
        session.Click("LeafSlimeS");
        Assert.False(session.Confirm()); // 2 + 1 + 税 1 = 4 > 3
        session.RemoveAt(1);
        Assert.True(session.Confirm());

        Assert.Equal(2, queue.Queued.Count);
        Assert.Equal(RuntimeNetAction.ActionType, queue.Queued[0].GetType()); // 清单先于移动
        Assert.IsType<MoveToMapCoordAction>(queue.Queued[1]);
        Assert.Equal(8, MasterLedger.Wallet!.Points); // 10 − 2

        var encounter = await RunQueueAndEnter(queue, RoomType.Monster);
        Assert.IsType<CultistsNormal>(encounter);
        Assert.Equal(new[] { "Nibbit" }, Names(encounter));
    }

    [Fact]
    public async Task TimeoutUsesVanillaAndChargesStandardCost()
    {
        var queue = Init();
        queue.RequestEnqueue(MoveTo(MapPointType.Monster));
        var session = Shown.Single().Session;
        session.Tick(10);
        Assert.Empty(queue.Queued);
        session.Tick(25); // 默认 30 秒
        Assert.IsType<MoveToMapCoordAction>(Assert.Single(queue.Queued)); // 没有清单，只放行移动
        Assert.Equal(7, MasterLedger.Wallet!.Points); // 开局保护标准开销 3
        Assert.IsNotType<CultistsNormal>(await RunQueueAndEnter(queue, RoomType.Monster)); // 没有混搭（同进程里测试 1a 可能把原版遭遇换掉，所以不断言具体是哪个）
    }

    [Fact]
    public void NonCombatRoomsAndClientsPassThrough()
    {
        var queue = Init();
        queue.RequestEnqueue(MoveTo(MapPointType.Shop));
        queue.RequestEnqueue(MoveTo(MapPointType.Unknown));
        Assert.Equal(2, queue.Queued.Count);
        Assert.Empty(Shown);

        queue = Init(NetGameType.Client);
        queue.RequestEnqueue(MoveTo(MapPointType.Monster));
        Assert.Single(queue.Queued);
        Assert.Empty(Shown);
    }

    [Fact]
    public async Task EliteAndBossRoomsSwapEncounter()
    {
        var queue = Init();
        queue.RequestEnqueue(MoveTo(MapPointType.Elite));
        var session = Shown.Single().Session;
        Assert.Equal("BygoneEffigyElite", session.Encounter); // 默认最便宜的
        session.Click("ByrdonisElite");
        Assert.True(session.Confirm(), string.Join(",", session.Quote.Violations));
        Assert.Equal(1, MasterLedger.Wallet!.Points); // 10 − 9
        Assert.IsType<ByrdonisElite>(await RunQueueAndEnter(queue, RoomType.Elite));

        queue.Queued.Clear();
        Shown.Clear();
        queue.RequestEnqueue(MoveTo(MapPointType.Boss));
        session = Shown.Single().Session;
        Assert.Equal("VantomBoss", session.Options[0].Id); // 候选第一个是游戏本来的 Boss
        Assert.Equal(2, session.Options.Count);
        var other = session.Options[1].Id;
        session.Click(other);
        Assert.True(session.Confirm());
        Assert.Equal(1, MasterLedger.Wallet!.Points); // Boss 免费
        var boss = await RunQueueAndEnter(queue, RoomType.Boss);
        Assert.Equal(other, boss.GetType().Name);
    }

    [Fact]
    public async Task IncomeIsSettledAfterVictoryAndSaved()
    {
        var queue = Init();
        queue.RequestEnqueue(MoveTo(MapPointType.Monster));
        var session = Shown.Single().Session;
        session.Click("Nibbit");
        session.Confirm(); // 花 2，标准开销 3 → 节约 0（(3−2)/2 = 0）
        await RunQueueAndEnter(queue, RoomType.Monster);

        var run = (RunState)RunManager.Instance.State;
        var state = new CombatState(ModelDb.Encounter<CultistsNormal>().ToMutable(), run);
        var manager = new CombatManager();
        manager.SetUpCombat(state);
        run.Players[1].Creature.Damage(23);
        manager.Win(null!);

        // 收入 = 基础 4 + 节约 0 + 战果 2（掉 23 血）= 6；10 − 2 + 6 = 14
        Assert.Equal(14, MasterLedger.Wallet!.Points);
        Assert.Equal(1, MasterLedger.BattlesFought);
        Assert.Contains("战斗收入 +6", Assert.Single(Toasts));

        // 读档：换一个进程状态，从文件恢复
        MasterLedger.Configure(new TowerMasterConfig());
        var wallet = MasterLedger.For(run.Rng.Seed, 1);
        Assert.Equal(14, wallet.Points);
        Assert.Equal(1, MasterLedger.BattlesFought);
    }
}
