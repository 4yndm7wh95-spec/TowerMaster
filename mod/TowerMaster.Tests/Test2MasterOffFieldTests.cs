using HarmonyLib;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Models.Encounters;
using MegaCrit.Sts2.Core.Models.Monsters;
using MegaCrit.Sts2.Core.Models.Powers;
using MegaCrit.Sts2.Core.Multiplayer.Game;
using MegaCrit.Sts2.Core.Runs;
using MegaCrit.Sts2.Core.Models;
using Xunit;

namespace TowerMaster.Tests;

/// <summary>用假 sts2 验证测试 2：只数爬塔玩家的人数改写、范围控制、塔主开局退场。</summary>
public class Test2MasterOffFieldTests
{
    private static bool _patched;

    /// <summary>1 名塔主（房主 100001）+ 1 名爬塔玩家（100002）。</summary>
    private static CombatState Init(NetGameType type = NetGameType.Host)
    {
        RunManager.Instance.NetService = new() { Type = type, NetId = type == NetGameType.Client ? 100002UL : 100001UL, HostNetId = 100001 };
        var run = new RunState();
        run.Players.Add(new Player(100001));
        run.Players.Add(new Player(100002));
        RunManager.Instance.State = run;
        if (!_patched)
        {
            Log.Init();
            Test2MasterOffField.Apply(new Harmony("towermaster.test2"), new TestSettings { Test2MasterOffField = true });
            _patched = true;
        }
        return new CombatState(ModelDb.Encounter<CultistsNormal>().ToMutable(), run);
    }

    private static string LogText() => File.ReadAllText(Path.Combine(Log.ModDir, "TowerMaster.log"));

    [Fact]
    public void ScalingCountsOnlyClimbersInScope()
    {
        var state = Init();
        Assert.Equal(40, state.CreateCreature(new Mawler(), 40).MaxHp); // 2 名玩家，但只有 1 名爬塔
        Assert.Equal(3, FakeScaledPower.Amount(state, 3));
        Assert.False(FakeVoteSynchronizer.AllVoted(state, 1)); // 范围外：仍等 2 人

        var log = LogText();
        Assert.Contains("★ 1 处 Creature MegaCrit.Sts2.Core.Combat.CombatState.CreateCreature", log);
        Assert.Contains("   1 处 static Boolean MegaCrit.Sts2.Core.Multiplayer.Game.FakeVoteSynchronizer.AllVoted", log);
        Assert.Contains("测试2 参数 Creature.ScaleHpForMultiplayer(hp=40, playerCount=1)", log);
    }

    [Fact]
    public void ClientAgreesWhoIsMaster()
    {
        var state = Init(NetGameType.Client);
        Assert.Equal(100001UL, Test2MasterOffField.MasterId);
        Assert.Equal(40, state.CreateCreature(new Mawler(), 40).MaxHp);
    }

    [Fact]
    public void SingleplayerIsUntouched()
    {
        var state = Init(NetGameType.Singleplayer);
        Assert.Null(Test2MasterOffField.MasterId);
        Assert.Equal(80, state.CreateCreature(new Mawler(), 40).MaxHp);
    }

    [Fact]
    public void MasterCharacterIsDeadAfterSetUpAndClimberIsNot()
    {
        var state = Init();
        state.CreateCreature(new Mawler(), 40);
        new CombatManager().SetUpCombat(state);

        var run = (RunState)RunManager.Instance.State;
        Assert.True(run.Players[0].Creature.IsDead);
        Assert.False(run.Players[1].Creature.IsDead);
        // 「所有玩家都死才判负」现在等价于「爬塔玩家都死」
        Assert.False(run.Players.All(p => p.Creature.IsDead));

        var log = LogText();
        Assert.Contains("测试2 开局 玩家 100001（塔主）：生命=0/80 死亡=True", log);
        Assert.Contains("测试2 开局 爬塔人数=1", log);
        Assert.Contains("测试2 开局 怪物 Mawler:MONSTER.MAWLER：生命=40/40", log);
    }
}
