using System.Text.Json;
using HarmonyLib;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.GameActions;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.Helpers;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Models.Acts;
using MegaCrit.Sts2.Core.Models.Encounters;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;
using MegaCrit.Sts2.Core.Rooms;
using MegaCrit.Sts2.Core.Runs;
using TowerMaster.Core;

[assembly: CollectionBehavior(DisableTestParallelization = true)]

namespace TowerMaster.Tests;

/// <summary>用真实 Harmony 和运行时接口实现验证清单动作、序列化和混搭生成。</summary>
public class Test1bMixedEncounterTests
{
    private static bool _patched;
    private static TestSettings Settings() => new()
    {
        Test1bMixedEncounter = true,
        MixedMonsters = new() { ["Overgrowth"] = ["Mawler", "Flyconid"] },
    };
    private static PriceBook Prices() => PriceBook.Load(Path.Combine(Log.ModDir, "price_book.data"));
    private static void Init()
    {
        RunManager.Instance.State = new();
        RunManager.Instance.NetService = new();
        if (!_patched)
        {
            Log.Init();
            Test1bMixedEncounter.Apply(new Harmony("towermaster.test1b"), Settings(), Prices());
            _patched = true;
        }
        Test1bMixedEncounter.Configure(Settings(), Prices());
        PlanStore.Clear();
        SummonPhase.Disable(); // 召唤阶段的测试会打开它；这里测的是固定清单
    }
    private static SummonPlan Plan() => new(1, 1, 123, "Overgrowth", 0, ["Mawler", "Flyconid"]);
    private static EncounterModel Generate()
    {
        var state = RunManager.Instance.State;
        var encounter = new Overgrowth().PullNextEncounter(RoomType.Monster).ToMutable();
        state.TotalFloor++;
        new CombatRoom(encounter, state).StartCombat();
        return encounter;
    }

    [Fact]
    public void RegistersActualInterfaceAndRoundTripsPayload()
    {
        Init();
        Assert.Contains(RuntimeNetAction.NetType, ReflectionHelper.ModTypes);
        var payload = JsonSerializer.Serialize(Plan());
        var action = (GameAction)RuntimeNetAction.Create(100001, payload);
        var writer = new PacketWriter();
        action.ToNetAction().Serialize(writer);
        var decoded = (INetAction)Activator.CreateInstance(RuntimeNetAction.NetType)!;
        decoded.Deserialize(new PacketReader(writer.Text));
        var restored = decoded.ToGameAction(new Player(100001));
        Assert.Equal(payload, RuntimeNetAction.Payload(restored));
        Assert.Equal(100001UL, restored.OwnerId);
        Assert.Equal(GameActionType.NonCombat, restored.ActionType);
    }

    [Fact]
    public void DynamicAssemblyIsAssociatedWithOurMod()
    {
        Init();
        var mod = MegaCrit.Sts2.Core.Modding.ModManager.AssemblyToMod[RuntimeNetAction.NetType.Assembly];
        Assert.Equal("TowerMaster", mod.manifest!.id);
    }

    [Fact]
    public async Task HostQueuesPlanBeforeMovementAndGeneratesDistinctMutableMonsters()
    {
        Init();
        var queue = new ActionQueueSynchronizer(RunManager.Instance.NetService);
        queue.RequestEnqueue(new MoveToMapCoordAction(100001));
        Assert.Equal(2, queue.Queued.Count);
        Assert.Equal(RuntimeNetAction.ActionType, queue.Queued[0].GetType());
        Assert.IsType<MoveToMapCoordAction>(queue.Queued[1]);
        await queue.Queued[0].Execute();
        var encounter = Generate();
        Assert.IsType<CultistsNormal>(encounter);
        Assert.Equal(new[] { "Mawler", "Flyconid" }, encounter.MonstersWithSlots.Select(m => m.Monster.GetType().Name));
        Assert.All(encounter.MonstersWithSlots, m => { Assert.True(m.Monster.IsMutable); Assert.Null(m.Slot); });
        var log = File.ReadAllText(Path.Combine(Log.ModDir, "TowerMaster.log"));
        Assert.True(log.LastIndexOf("收到清单") < log.LastIndexOf("开始生成"));
        Assert.True(log.LastIndexOf("开始生成") < log.LastIndexOf("：生成 ["));
    }

    [Fact]
    public async Task ClientUsesBroadcastInsteadOfItsOwnDifferentList()
    {
        Init();
        var local = Settings();
        local.MixedMonsters["Overgrowth"] = ["Nibbit", "Mawler"];
        Test1bMixedEncounter.Configure(local, Prices());
        RunManager.Instance.NetService.Type = NetGameType.Client;
        RunManager.Instance.NetService.NetId = 100002;
        var queue = new ActionQueueSynchronizer(RunManager.Instance.NetService);
        queue.RequestEnqueue(new MoveToMapCoordAction(100002));
        Assert.Single(queue.Queued);
        var net = (INetAction)RuntimeNetAction.ToNetAction(RuntimeNetAction.Create(100001, JsonSerializer.Serialize(Plan())));
        var writer = new PacketWriter();
        net.Serialize(writer);
        var incoming = (INetAction)Activator.CreateInstance(RuntimeNetAction.NetType)!;
        incoming.Deserialize(new PacketReader(writer.Text));
        await incoming.ToGameAction(new Player(100001)).Execute();
        Assert.Equal(new[] { "Mawler", "Flyconid" }, Generate().MonstersWithSlots.Select(m => m.Monster.GetType().Name));
    }

    [Fact]
    public void RejectsWrongOwnerReplayWrongFloorAndUnknownMonster()
    {
        Init();
        var payload = JsonSerializer.Serialize(Plan());
        Assert.Throws<InvalidDataException>(() => Test1bMixedEncounter.Receive(payload, 100002));
        Assert.Throws<InvalidDataException>(() => Test1bMixedEncounter.Receive(JsonSerializer.Serialize(Plan() with { SourceFloor = 9 }), 100001));
        Assert.Throws<InvalidDataException>(() => Test1bMixedEncounter.Receive(JsonSerializer.Serialize(Plan() with { Monsters = ["Mawler", "UnknownMonster"] }), 100001));
        Test1bMixedEncounter.Receive(payload, 100001);
        Test1bMixedEncounter.Receive(payload, 100001); // 同一份清单收到两次：忽略，不报错
    }

    private static string[] Names(EncounterModel encounter) =>
        encounter.MonstersWithSlots.Select(m => m.Monster.GetType().Name).ToArray();

    [Fact]
    public void WithoutPlanNormalRoomFallsBackToVanilla()
    {
        Init();
        // 没收到清单就进房（例如读档、重连）：不换成混搭载体、不抛异常。
        // 同一进程里测试 1a 的补丁也挂着，原版遭遇可能被 1a 换掉，所以只断言没进混搭流程。
        var encounter = Generate();
        Assert.IsNotType<CultistsNormal>(encounter);
        Assert.DoesNotContain("Flyconid", Names(encounter));
    }

    [Fact]
    public async Task RejectedPlanIsLoggedNotThrownAndRoomFallsBack()
    {
        Init();
        var bad = RuntimeNetAction.Create(100002, JsonSerializer.Serialize(Plan())); // 不是房主
        await ((GameAction)bad).Execute();
        Assert.IsNotType<CultistsNormal>(Generate());
        Assert.Contains("拒收召唤清单", File.ReadAllText(Path.Combine(Log.ModDir, "TowerMaster.log")));
    }

    [Fact]
    public void HostRestartRenumberingIsAccepted()
    {
        Init();
        Test1bMixedEncounter.Receive(JsonSerializer.Serialize(Plan() with { Sequence = 5 }), 100001);
        Generate();
        // 房主重启游戏后序号从 1 重来，对方没重启：仍然接受。
        Test1bMixedEncounter.Receive(JsonSerializer.Serialize(Plan() with { Sequence = 1, SourceFloor = 1 }), 100001);
        Assert.Equal(new[] { "Mawler", "Flyconid" }, Names(Generate()));
    }

    [Fact]
    public void ReloadedCombatRecoversMixFromLocalFile()
    {
        Init();
        Test1bMixedEncounter.Receive(JsonSerializer.Serialize(Plan()), 100001);
        Assert.Equal(new[] { "Mawler", "Flyconid" }, Names(Generate()));

        // 读档：游戏从存档恢复同一楼层的载体遭遇，没有经过选遭遇和清单动作。
        var state = RunManager.Instance.State;
        var reloaded = ModelDb.Encounter<CultistsNormal>().ToMutable();
        new CombatRoom(reloaded, state).StartCombat();
        Assert.Equal(new[] { "Mawler", "Flyconid" }, Names(reloaded));

        // 别的楼层的载体遭遇（没有清单）保持原样。
        state.TotalFloor++;
        var other = ModelDb.Encounter<CultistsNormal>().ToMutable();
        new CombatRoom(other, state).StartCombat();
        Assert.Equal(new[] { "CalcifiedCultist", "DampCultist" }, Names(other));
    }
}
