using HarmonyLib;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.GameActions;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.Map;
using MegaCrit.Sts2.Core.Multiplayer.Game;
using MegaCrit.Sts2.Core.Runs;
using Xunit;

namespace TowerMaster.Tests;

/// <summary>用假同步器验证测试 3：只在房主（塔主）上自动操作，跟随爬塔玩家，不重复、不递归。</summary>
public class Test3MasterAutoPilotTests
{
    private static bool _patched;
    private static readonly Player Master = new(100001), Climber = new(100002);

    private static ActionQueueSynchronizer Init(NetGameType type = NetGameType.Host)
    {
        var run = new RunState();
        run.Players.Add(Master);
        run.Players.Add(Climber);
        RunManager.Instance.State = run;
        RunManager.Instance.NetService = new() { Type = type, NetId = type == NetGameType.Client ? 100002UL : 100001UL, HostNetId = 100001 };
        var queue = new ActionQueueSynchronizer(RunManager.Instance.NetService);
        RunManager.Instance.ActionQueueSynchronizer = queue;
        MapSelectionSynchronizer.Instance = new();
        if (!_patched)
        {
            Log.Init();
            Test3MasterAutoPilot.Apply(new Harmony("towermaster.test3"));
            _patched = true;
        }
        return queue;
    }

    [Fact]
    public async Task MapVoteFollowsClimberOnceAndCompletesTheVote()
    {
        var queue = Init();
        var sync = MapSelectionSynchronizer.Instance;
        var source = new MapLocation(0, 1);
        sync.PlayerVotedForMapCoord(Climber, source, new MapVote(1, 2));
        sync.PlayerVotedForMapCoord(Climber, source, new MapVote(1, 2)); // 同一票重复：不再跟投

        var vote = Assert.IsType<VoteForMapCoordAction>(Assert.Single(queue.Queued));
        Assert.Equal(100001UL, vote.OwnerId);
        await vote.Execute(); // 塔主的票执行：不会再触发跟投
        Assert.Single(queue.Queued);
        Assert.Equal(new MapVote(1, 2), sync.Votes[100001]);
        Assert.Equal(new MapVote(1, 2), sync.Votes[100002]);

        sync.PlayerVotedForMapCoord(Climber, source, new MapVote(1, 3)); // 改票：塔主跟着改
        Assert.Equal(2, queue.Queued.Count);
    }

    [Fact]
    public void ClientNeverActsForMaster()
    {
        var queue = Init(NetGameType.Client);
        MapSelectionSynchronizer.Instance.PlayerVotedForMapCoord(Climber, new MapLocation(0, 1), new MapVote(1, 2));
        Assert.Empty(queue.Queued);
        var rewards = new RewardsSetSynchronizer();
        rewards.BeginRewardsSet(new object());
        Assert.Equal(0, rewards.Skipped);
    }

    [Fact]
    public void MasterSkipsRewardsTreasureAndRestSite()
    {
        Init();
        var rewards = new RewardsSetSynchronizer();
        rewards.BeginRewardsSet(new object());
        var treasure = new TreasureRoomRelicSynchronizer();
        treasure.BeginRelicPicking();
        var rest = new RestSiteSynchronizer();
        rest.BeginRestSite();
        Assert.Equal((1, 1, 1), (rewards.Skipped, treasure.Skipped, rest.Skipped));
    }

    [Fact]
    public void SharedEventAndActChangeFollowClimberOnly()
    {
        Init();
        var events = new EventSynchronizer();
        events.PlayerVotedForSharedOptionIndex(Master, 0, 0); // 塔主自己的票：不跟
        events.PlayerVotedForSharedOptionIndex(Climber, 2, 0);
        events.PlayerVotedForSharedOptionIndex(Climber, 2, 0); // 重复
        events.PlayerVotedForSharedOptionIndex(Climber, 1, 1); // 下一页
        Assert.Equal(new[] { 2, 1 }, events.LocalChoices);

        var act = new ActChangeSynchronizer();
        act.OnPlayerReady(Master, 0);
        act.OnPlayerReady(Climber, 0);
        act.OnPlayerReady(Climber, 0);
        Assert.Equal(1, act.LocalReady);
    }
}
