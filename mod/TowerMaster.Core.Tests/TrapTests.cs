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
        Assert.Equal("当一名玩家在一个回合内打出第 3 张攻击牌时，所有敌人获得 8 点格挡。", TrapCatalog.Get("harden").Describe(3));
        Assert.Equal("当一名玩家在一个回合内打出第 3 张技能牌时，给予该玩家 2 层[脆弱]。", TrapCatalog.Get("brittle").Describe(2, w => $"[{w}]"));
        Assert.Equal("第 2 回合开始时，将 2 张晕眩放入每名玩家的抽牌堆。", TrapCatalog.Get("mire").Describe(1));
        Assert.Equal("没有任何效果。", TrapCatalog.Get("bluff").Describe(1));
        Assert.DoesNotContain("金币", TrapCatalog.Get("bluff").Rules(10).Replace("不给玩家金币", ""));
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

public class TrapDraftTests
{
    [Fact]
    public void OfferIsSeededAndVariesByRun()
    {
        var a = TrapCatalog.DraftOffer(1, 111, 6);
        Assert.Equal(7, a.Count);
        Assert.Equal("bluff", a[^1].Id);
        Assert.Equal(a.Select(c => c.Id), TrapCatalog.DraftOffer(1, 111, 6).Select(c => c.Id)); // 同一局固定
        Assert.Contains(Enumerable.Range(0, 20), s => !TrapCatalog.DraftOffer(1, (ulong)s, 6).Select(c => c.Id).SequenceEqual(a.Select(c => c.Id)));
        Assert.All(TrapCatalog.DraftOffer(2, 111, 6), c => Assert.Equal(2, c.Tier));
    }

    [Fact]
    public void BudgetPicksOwnedAndHandLimit()
    {
        var offer = new[] { new TrapCard("frenzy", 1), new TrapCard("harden", 1), new TrapCard("mire", 1), new TrapCard("brittle", 1), new TrapCard("bluff", 1) };
        var d = new TrapDraft(1, offer, [new TrapCard("mire", 1)], budget: 5, maxPicks: 3, handLimit: 6);
        Assert.True(d.Owned(2));
        Assert.False(d.Toggle(2));            // 手里已有泥沼，不能重复
        Assert.True(d.Toggle(0));             // 狂怒 3
        Assert.True(d.Toggle(1));             // 硬化 2 → 5
        Assert.False(d.Toggle(3));            // 碎甲 1 超预算
        Assert.True(d.Toggle(4));             // 空陷阱 0：第 3 张
        Assert.Equal(5, d.Spent);
        Assert.True(d.Toggle(1));             // 去掉硬化
        Assert.True(d.Toggle(3));             // 现在碎甲可以
        Assert.Equal(new[] { "frenzy", "brittle", "bluff" }, d.Confirm().Select(c => c.Id));

        var full = new TrapDraft(1, offer, Enumerable.Range(0, 6).Select(_ => new TrapCard("bluff", 1)).ToList(), 5, 3, 6);
        Assert.False(full.Toggle(0));          // 手满了
        Assert.Empty(full.Confirm());         // 可以一张不挑
    }
}
