using TowerMaster.Core;
using Xunit;

namespace TowerMaster.Core.Tests;

public class TrapTests
{
    [Fact]
    public void PacksHaveThreeStylesAndScaleByAct()
    {
        var act1 = TrapCatalog.PacksFor(1);
        Assert.Equal(3, act1.Count);
        Assert.All(act1, p => Assert.InRange(p.Cards.Count, 4, 5));
        Assert.All(act1.SelectMany(p => p.Cards), c => Assert.Equal(1, c.Tier));
        Assert.All(TrapCatalog.PacksFor(3).SelectMany(p => p.Cards), c => Assert.Equal(3, c.Tier));
        Assert.Equal("所有敌人 +11 格挡", TrapCatalog.Get("harden").Describe(3).Split(" → ")[1]);
        Assert.Equal("硬化+2", new TrapCard("harden", 3).Name);
        Assert.DoesNotContain(TrapCatalog.PoolFor(1), c => c.Id == "bluff");
        Assert.Equal(new TrapCard("mire", 2), TrapCatalog.Parse("mire@2"));
    }

    [Fact]
    public void CardCountsArePerPlayerPerTurn()
    {
        var t = new TrapTracker([new TrapCard("harden", 1), new TrapCard("harden", 1), new TrapCard("brittle", 1)]);
        t.RoundStarted(1);
        Assert.Empty(t.CardPlayed(1, attack: true, skill: false));
        Assert.Empty(t.CardPlayed(2, attack: true, skill: false)); // 另一名玩家的攻击不累计
        Assert.Empty(t.CardPlayed(1, attack: true, skill: false));
        var fire = Assert.Single(t.CardPlayed(1, attack: true, skill: false)); // 玩家 1 的第 3 张攻击
        Assert.Equal(("harden", 1UL), (fire.Card.Id, fire.Player));            // 两张硬化只触发一张
        Assert.Empty(t.CardPlayed(1, attack: true, skill: false));

        t.RoundStarted(2); // 新回合重新计数，另一张硬化可以再触发
        t.CardPlayed(1, true, false);
        t.CardPlayed(1, true, false);
        Assert.Single(t.CardPlayed(1, true, false));
        Assert.Equal(new[] { "brittle" }, t.Unfired.Select(c => c.Id));
        Assert.Equal(2, t.FiredCount);
    }

    [Fact]
    public void RoundEnemyDeathAndBluff()
    {
        var t = new TrapTracker([new TrapCard("rally", 1), new TrapCard("frenzy", 2), new TrapCard("bluff", 1)]);
        Assert.Empty(t.RoundStarted(2));
        var rally = Assert.Single(t.RoundStarted(3));
        Assert.Equal(0UL, rally.Player); // 回合类：所有玩家
        Assert.Equal("frenzy", Assert.Single(t.EnemyDied()).Card.Id);
        Assert.Empty(t.EnemyDied());
        for (int r = 4; r < 20; r++) t.RoundStarted(r);
        Assert.Equal("bluff", Assert.Single(t.Unfired).Id); // 空陷阱永不触发，战后照样给躲过奖励
    }
}
