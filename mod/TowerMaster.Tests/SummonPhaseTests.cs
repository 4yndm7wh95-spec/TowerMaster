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
        ThreatPhase.Disable();                 // 塔主回合测试可能打开过：这里不要陷阱包
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
        Assert.All(session.MonsterOptions, o => Assert.True(o.HomeAct == 1 && !o.IsElite, o.Id)); // 只能用本幕普通怪
        Assert.Contains(session.MonsterOptions, o => o.Id == "Mawler");                      // 不再只限简单遭遇

        session.Click("Nibbit");
        Assert.True(session.Quote.Ok, string.Join(",", session.Quote.Violations)); // 开局保护标准开销 3，小啃兽 2
        session.Click("LeafSlimeS");
        Assert.False(session.Confirm()); // 2 + 1 + 税 1 = 4 > 3 × 1.3
        session.RemoveAt(1);
        Assert.True(session.Confirm());

        Assert.Equal(2, queue.Queued.Count);
        Assert.Equal(RuntimeNetAction.ActionType, queue.Queued[0].GetType()); // 清单先于移动
        Assert.IsType<MoveToMapCoordAction>(queue.Queued[1]);
        Assert.Equal(10, MasterLedger.Wallet!.Points); // 12 − 2

        var encounter = await RunQueueAndEnter(queue, RoomType.Monster);
        Assert.IsType<CultistsNormal>(encounter);
        Assert.Equal(new[] { "Nibbit" }, Names(encounter));
    }

    [Fact]
    public async Task NoTimeLimitByDefaultAndVanillaChargesStandardCost()
    {
        var queue = Init();
        queue.RequestEnqueue(MoveTo(MapPointType.Monster));
        var session = Shown.Single().Session;
        Assert.True(session.Unlimited);
        session.Tick(1000); // 不限时：多久都不会自动结束
        Assert.False(session.Done);
        Assert.Empty(queue.Queued);
        session.UseVanilla();
        Assert.IsType<MoveToMapCoordAction>(Assert.Single(queue.Queued)); // 没有清单，只放行移动
        Assert.Equal(9, MasterLedger.Wallet!.Points); // 12 − 开局保护标准开销 3
        Assert.IsNotType<CultistsNormal>(await RunQueueAndEnter(queue, RoomType.Monster)); // 没有混搭（同进程里测试 1a 可能换掉原版遭遇）
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
    public async Task EliteRoomMixesAnyMonstersAtDiscountAndBossTakesExtras()
    {
        var queue = Init();
        queue.RequestEnqueue(MoveTo(MapPointType.Elite));
        var session = Shown.Single().Session;
        Assert.Empty(session.EncounterOptions);                       // 精英房不再选遭遇
        Assert.Equal(8, session.MonsterOptions.Single(o => o.Id == "Byrdonis").Price); // 八五折
        session.Click("Byrdonis");
        Assert.True(session.Confirm(), string.Join(",", session.Quote.Violations));
        Assert.Equal(4, MasterLedger.Wallet!.Points); // 12 − 8
        var elite = await RunQueueAndEnter(queue, RoomType.Elite);
        Assert.IsType<BygoneEffigyElite>(elite);      // 精英载体：无专用场景的精英遭遇，房间类型、奖励仍是精英
        Assert.Equal(new[] { "Byrdonis" }, Names(elite));

        queue.Queued.Clear();
        Shown.Clear();
        queue.RequestEnqueue(MoveTo(MapPointType.Boss));
        session = Shown.Single().Session;
        Assert.Equal("VantomBoss", session.EncounterOptions[0].Id); // 候选第一个是游戏本来的 Boss
        Assert.Equal(2, session.EncounterOptions.Count);
        Assert.Equal(0, session.Room.StandardCostOverride);         // Boss 免费，没有标准开销
        Assert.Equal("Vantom", session.LeadMonsterOf("VantomBoss"));
        Assert.Equal("KinPriest", session.LeadMonsterOf("TheKinBoss")); // 画同族神官，不是信徒
        var other = session.EncounterOptions[1].Id;
        session.Click(other);
        session.Click("LeafSlimeS"); // 另加：1 点 + 税 1
        Assert.True(session.Confirm(), string.Join(",", session.Quote.Violations));
        Assert.Equal(2, MasterLedger.Wallet!.Points);
        var boss = await RunQueueAndEnter(queue, RoomType.Boss);
        Assert.Equal(other, boss.GetType().Name);
        Assert.Equal(new[] { "Mawler", "LeafSlimeS" }, Names(boss)); // Boss 本体（假游戏里是蛮兽）+ 另加的怪
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
        File.Delete(BalanceLog.FilePath);
        manager.Win(null!);
        var line = File.ReadAllLines(BalanceLog.FilePath).Single(); // 平衡记录：一场一行
        Assert.Contains("\"result\":\"won\"", line);
        Assert.Contains("\"damage_taken\":23", line);
        Assert.Contains("\"summon\":\"confirmed\"", line);

        // 收入 = 基础 5 + 节约 0 + 战果 1（掉 23 血，每 15 点 +1）= 6；12 − 2 + 6 = 16
        Assert.Equal(16, MasterLedger.Wallet!.Points);
        Assert.Equal(1, MasterLedger.BattlesFought);
        Assert.Contains("战斗收入 +6", Assert.Single(Toasts));

        // 读档：换一个进程状态，从文件恢复
        MasterLedger.Configure(new TowerMasterConfig());
        var wallet = MasterLedger.For(run.Rng.Seed, 1);
        Assert.Equal(16, wallet.Points);
        Assert.Equal(1, MasterLedger.BattlesFought);
    }

    [Fact]
    public void MonstersFromSlottedEncountersAreNotOffered()
    {
        Init();
        Assert.True(SummonPhase.MonsterFilter("Overgrowth", "Mawler"));   // MawlerNormal：无场景、无槽位
        Assert.False(SummonPhase.MonsterFilter("Overgrowth", "Inklet"));  // InkletsNormal 有命名槽位
        Assert.True(SummonPhase.MonsterFilter("Overgrowth", "Byrdonis")); // 精英遭遇无场景：精英也能召唤
    }

    [Fact]
    public async Task ReconnectRebuildRecoversPlanByCoordinate()
    {
        var queue = Init();
        var move = MoveTo(MapPointType.Monster);
        queue.RequestEnqueue(move);
        var session = Shown.Single().Session;
        session.Click("Nibbit");
        Assert.True(session.Confirm());
        await RunQueueAndEnter(queue, RoomType.Monster);

        // 重连：房间重建，没有清单动作；当前坐标就是这个房间
        var state = (RunState)RunManager.Instance.State;
        state.CurrentMapCoord = move.Destination;
        var rebuilt = new Overgrowth().PullNextEncounter(RoomType.Monster).ToMutable();
        new CombatRoom(rebuilt, state).StartCombat();
        Assert.IsType<CultistsNormal>(rebuilt);
        Assert.Equal(new[] { "Nibbit" }, Names(rebuilt));

        // 别的坐标没有清单：按原版
        state.CurrentMapCoord = new MapCoord(0, 9);
        Assert.IsNotType<CultistsNormal>(new Overgrowth().PullNextEncounter(RoomType.Monster));
    }

    [Fact]
    public async Task BridgeSelectsAndConfirmsLikeThePanel()
    {
        var queue = Init();
        TestBridge.Dispatch = work => work(); // 测试里没有 Godot 主线程，直接执行
        var (status, _) = await TestBridge.Route("POST", "/summon", null, "");
        Assert.Equal(400, status); // 还没有面板

        queue.RequestEnqueue(MoveTo(MapPointType.Monster));
        var session = Shown.Single().Session;
        int changed = 0;
        session.Changed += () => changed++;

        (status, var body) = await TestBridge.Route("POST", "/summon/select", null, """{"monsters":["Nibbit","Nope"]}""");
        Assert.Equal(400, status);
        Assert.Contains("unknown_option", Json(body));
        Assert.Empty(session.Monsters); // 有不认识的就整份不改

        var other = session.MonsterOptions.First(o => o.Id != "Nibbit").Id;
        (status, body) = await TestBridge.Route("POST", "/summon/select", null, $$"""{"monsters":["Nibbit","{{other}}"]}""");
        Assert.True(status == 200, Json(body));
        (status, _) = await TestBridge.Route("POST", "/summon/select", null, """{"monsters":["Nibbit"]}""");
        Assert.Equal(new[] { "Nibbit" }, session.Monsters); // 整份替换，不叠加
        Assert.Equal(2, changed);

        (status, body) = await TestBridge.Route("POST", "/summon/confirm", null, "");
        Assert.Equal(200, status);
        Assert.Contains("\"points_after\":10", Json(body));
        Assert.True(session.Confirmed);
        Assert.Equal(2, queue.Queued.Count);
    }

    [Fact]
    public async Task BridgeRejectsUnconfirmableAndWrongToken()
    {
        var queue = Init();
        TestBridge.Dispatch = work => work();
        queue.RequestEnqueue(MoveTo(MapPointType.Monster));
        var (status, body) = await TestBridge.Route("POST", "/summon/confirm", null, ""); // 空阵容
        Assert.Equal(400, status);
        Assert.Contains("rejected_rule", Json(body));
        (status, _) = await TestBridge.Route("POST", "/nope", null, "");
        Assert.Equal(404, status);
    }

    private static string Json(object body) => System.Text.Json.JsonSerializer.Serialize(body, TestBridge.JsonOut);

    [Fact]
    public void FirstSummonOfActDraftsTrapsThenPlacesThemWithCooldown()
    {
        var queue = Init();
        var prices = PriceBook.Load(Path.Combine(Log.ModDir, "price_book.data"));
        ThreatPhase.Apply(new Harmony("towermaster.summon"), new TowerMasterConfig(), prices);
        TrapDraftChoice? shown = null;
        SummonPhase.DraftUiFactory = c => { shown = c; return new FakeUi(null!); };
        try
        {
            MasterLedger.For(123, 1);
            for (int i = 0; i < 3; i++) MasterLedger.CountBattle(); // 过了开局保护才能盖陷阱
            queue.RequestEnqueue(MoveTo(MapPointType.Monster));
            Assert.NotNull(shown);
            Assert.Null(SummonPhase.Current);              // 先挑陷阱，召唤面板还没出来
            var draft = shown!.Draft;
            Assert.Equal(7, draft.Offer.Count);            // 6 种随机 + 空陷阱
            Assert.Equal(5, draft.Budget);
            // 挑两张便宜的 + 空陷阱
            var cheap = Enumerable.Range(0, draft.Offer.Count).Where(i => draft.Offer[i].Def.DraftCost == 1).Take(2).ToList();
            int bluff = draft.Offer.Count - 1;
            Assert.True(shown.Set([.. cheap, bluff]));
            Assert.False(shown.Set([0, 1, 2, 3]));         // 超张数：整份不改
            Assert.Equal(cheap.Count + 1, draft.Picked.Count);
            Assert.True(shown.Confirm());
            Assert.True(MasterLedger.DraftDone(1));
            var session = Assert.Single(Shown, u => u.Session != null).Session;
            Assert.Equal(cheap.Count + 1, session.TrapHand.Count);

            session.Click("Nibbit");
            session.ToggleTrap(0);
            Assert.True(session.Confirm(), string.Join(",", session.Quote.Violations));
            var placed = TrapPhase.Tracker == null ? MasterLedger.LastPlaced.Single() : null;
            Assert.NotNull(placed);

            // 下一场：同种陷阱冷却，不能盖；同一幕不再挑
            shown = null;
            Shown.Clear();
            queue.Queued.Clear();
            queue.RequestEnqueue(MoveTo(MapPointType.Monster));
            Assert.Null(shown);
            var next = Shown.Single(u => u.Session != null).Session;
            Assert.All(Enumerable.Range(0, next.TrapHand.Count).Where(i => next.TrapHand[i].Id == placed), i => Assert.True(next.TrapCooling(i)));
        }
        finally
        {
            ThreatPhase.Disable();
            SummonPhase.DraftUiFactory = c => new TrapDraftPanel(c);
        }
    }

    [Fact]
    public void SceneBossRejectsExtrasAndClearsThem()
    {
        var queue = Init();
        var original = SummonPhase.BossAllowsExtras;
        try
        {
            SummonPhase.BossAllowsExtras = id => id == "VantomBoss"; // 假设第二个候选有专用场景
            queue.RequestEnqueue(MoveTo(MapPointType.Boss));
            var session = Shown.Single().Session;
            Assert.True(session.EncounterAllowsExtras("VantomBoss"));
            session.Click("LeafSlimeS");
            Assert.Single(session.Monsters);
            var scene = session.EncounterOptions[1].Id;
            Assert.False(session.EncounterAllowsExtras(scene));
            session.Click(scene);
            Assert.Empty(session.Monsters);  // 换成不能另加的 Boss：已选的清掉
            session.Click("LeafSlimeS");
            Assert.Empty(session.Monsters);  // 也加不进去
            Assert.True(session.Confirm());
        }
        finally { SummonPhase.BossAllowsExtras = original; }
    }

    [Fact]
    public async Task SameBossAsOriginalIsNotReplaced()
    {
        var queue = Init();
        queue.RequestEnqueue(MoveTo(MapPointType.Boss));
        var session = Shown.Single().Session;
        Assert.True(session.Confirm()); // 默认就是原版 Boss，不另加
        var original = ModelDb.Encounter<VantomBoss>();
        foreach (var action in queue.Queued.ToList()) await action.Execute();
        Assert.Same(original, new Overgrowth().PullNextEncounter(RoomType.Boss)); // 原样返回
        Assert.Contains("不替换", File.ReadAllText(Path.Combine(Log.ModDir, "TowerMaster.log")));
    }

    [Fact]
    public async Task LaterActMonsterArrivesWithLessHp()
    {
        var queue = Init();
        var run = (RunState)RunManager.Instance.State;
        MasterLedger.For(run.Rng.Seed, 1);
        for (int i = 0; i < 3; i++) MasterLedger.CountBattle(); // 过了开局保护
        queue.RequestEnqueue(MoveTo(MapPointType.Monster));
        var session = Shown.Single().Session;
        var chomper = session.MonsterOptions.Single(o => o.Id == "Chomper"); // 第二幕的怪
        Assert.Equal(2, chomper.HomeAct);
        Assert.Equal(0.8, chomper.HpFactor, 6);
        session.Click("Chomper");
        Assert.True(session.Confirm(), string.Join(",", session.Quote.Violations));
        var encounter = await RunQueueAndEnter(queue, RoomType.Monster);

        var state = new CombatState(encounter, run);
        // 同进程里测试 2 的人数改写可能挂着也可能没挂，所以和同样血量的「不是召唤来的」怪比
        var normal = state.CreateCreature(new MegaCrit.Sts2.Core.Models.Monsters.Mawler(), 50);
        var creature = state.CreateCreature(encounter.MonstersWithSlots.Single().Monster, 50);
        Assert.Equal((int)Math.Round(normal.MaxHp * 0.8), creature.MaxHp);
        Assert.Equal(creature.MaxHp, creature.CurrentHp);
    }

}
