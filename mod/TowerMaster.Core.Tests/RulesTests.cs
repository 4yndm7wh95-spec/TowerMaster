using TowerMaster.Core;
using Xunit;

namespace TowerMaster.Core.Tests;

public class Fixture
{
    public static readonly PriceBook Prices = PriceBook.Load(Path.Combine(AppContext.BaseDirectory, "price_book.json"));
    public static TowerMasterConfig Config() => new();
    public static SummonRules Rules() => new(Config(), Prices);
}

public class PriceBookTests
{
    [Fact]
    public void LoadsAllActs()
    {
        Assert.Equal(new[] { "Glory", "Hive", "Overgrowth", "Underdocks" }, Fixture.Prices.Acts.Keys.Order());
        Assert.Equal(1, Fixture.Prices.Act("Underdocks").ActNo);
        Assert.Equal(3, Fixture.Prices.Act("Overgrowth").Price("Mawler"));
        Assert.Equal(MonsterRole.Elite, Fixture.Prices.Act("Overgrowth").Monsters["PhrogParasite"].Role);
    }

    [Fact]
    public void EveryEncounterMonsterHasAPrice()
    {
        foreach (var act in Fixture.Prices.Acts.Values)
        foreach (var enc in act.Encounters.Values)
        foreach (var m in enc.Lineups.SelectMany(l => l.Monsters))
            Assert.True(act.TryPrice(m, out _), $"{act.Id}/{m}");
    }

    [Fact]
    public void StandardCostMatchesTableForFixedLineups()
    {
        var rules = Fixture.Rules();
        foreach (var act in Fixture.Prices.Acts.Values)
        foreach (var (id, enc) in act.Encounters.Where(e => e.Value.Lineups.Count == 1 && e.Value.Room != RoomKind.Boss))
            Assert.Equal(enc.StandardCost, rules.StandardCost(act.Id, enc.Room, enc.Lineups[0].Monsters));
    }

    [Theory]
    [InlineData(1, 4.8)]
    [InlineData(2, 6.0)]
    [InlineData(3, 7.2)]
    public void NormalEncountersAverageAboutOnePointTwoIncomes(int actNo, double target)
    {
        // 校准目标：每幕普通（非简单）遭遇平均标准开销 ≈ 1.2 × 基础收入（第一幕两个版本合起来算）。
        var costs = Fixture.Prices.Acts.Values.Where(a => a.ActNo == actNo)
            .SelectMany(a => a.Encounters.Values).Where(e => e.Room == RoomKind.Monster && !e.Weak)
            .Select(e => e.StandardCost).ToList();
        Assert.InRange(costs.Average(), target - 0.1, target + 0.1);
    }
}

public class SummonRulesTests
{
    private static RoomContext Normal(string act = "Overgrowth", string[]? original = null, int savings = 30,
        int climbers = 1, int battlesBefore = 5) =>
        new(act, RoomKind.Monster, climbers, battlesBefore, original ?? ["Nibbit", "Nibbit"], savings);

    [Fact]
    public void CrowdTaxIsTriangular()
    {
        Assert.Equal(new[] { 0, 0, 1, 3, 6, 10 }, Enumerable.Range(0, 6).Select(SummonRules.CrowdTax));
    }

    [Fact]
    public void FourCheapMonstersBlowTheActOneCap()
    {
        // 设计文档的例子：四只 2 点的小怪 = 2+2+2+2 + 群体税 6 = 14，超过标准开销 5 × 1.6 = 8。
        var quote = Fixture.Rules().Quote(Normal(climbers: 2),
            new SummonPlan(null, ["Nibbit", "Flyconid", "SnappingJaxfruit", "SlitheringStrangler"]));
        Assert.Equal(5, quote.StandardCost);
        Assert.Equal(14, quote.MonsterSpend);
        Assert.Contains(SummonViolation.OverSpendCap, quote.Violations);
    }

    [Fact]
    public void ValidNormalPlan()
    {
        var quote = Fixture.Rules().Quote(Normal(), new SummonPlan(null, ["Mawler", "Nibbit"], Traps: 2));
        Assert.True(quote.Ok, string.Join(",", quote.Violations));
        Assert.Equal(5, quote.MonsterPrice);
        Assert.Equal(1, quote.CrowdTax);
        Assert.Equal(2, quote.TrapCost);
        Assert.Equal(8, quote.Total);
    }

    [Fact]
    public void NormalRoomTakesAnyActNormalOrEliteButNotBossOrSummons()
    {
        var rules = Fixture.Rules();
        Assert.True(rules.Quote(Normal(), new SummonPlan(null, ["Chomper"])).Ok);     // 第二幕的怪，第一幕也能召唤
        Assert.Contains(SummonViolation.OverSpendCap, rules.Quote(Normal(), new SummonPlan(null, ["Byrdonis"])).Violations); // 精英可以选，但 9 点超过上限 8
        Assert.Contains(SummonViolation.UnknownMonster, rules.Quote(Normal(), new SummonPlan(null, ["KinPriest"])).Violations); // Boss 不在可召唤表里
        Assert.Contains(SummonViolation.UnknownMonster, rules.Quote(Normal(), new SummonPlan(null, ["Wriggler"])).Violations);       // 召唤物
        Assert.Contains(SummonViolation.EncounterNotAllowed, rules.Quote(Normal(), new SummonPlan("MawlerNormal", ["Mawler"])).Violations);
        Assert.Contains(SummonViolation.EmptyRoom, rules.Quote(Normal(), new SummonPlan(null, [])).Violations);
    }

    [Fact]
    public void FieldLimitScalesWithClimbers()
    {
        var rules = Fixture.Rules();
        var plan = new SummonPlan(null, ["LeafSlimeS", "TwigSlimeS", "LeafSlimeM", "TwigSlimeM"]); // 4 + 税6 = 10
        var solo = rules.Quote(Normal(original: ["TwigSlimeM", "LeafSlimeM", "LeafSlimeS", "TwigSlimeS"]), plan);
        Assert.Contains(SummonViolation.TooManyMonsters, solo.Violations);
        var duo = rules.Quote(Normal(original: ["TwigSlimeM", "LeafSlimeM", "LeafSlimeS", "TwigSlimeS"], climbers: 2), plan);
        Assert.True(duo.Ok, string.Join(",", duo.Violations));
    }

    [Fact]
    public void SameMonsterLimit()
    {
        var quote = Fixture.Rules().Quote(Normal(original: ["Inklet", "Inklet", "Inklet"], climbers: 3),
            new SummonPlan(null, ["Inklet", "Inklet", "Inklet", "Inklet"]));
        Assert.Contains(SummonViolation.TooManySameMonster, quote.Violations);
    }

    [Fact]
    public void TrapLimitsAndSavings()
    {
        var rules = Fixture.Rules();
        Assert.Contains(SummonViolation.TooManyTraps, rules.Quote(Normal(), new SummonPlan(null, ["Mawler"], 3)).Violations);
        Assert.Contains(SummonViolation.NotEnoughPoints, rules.Quote(Normal(savings: 3), new SummonPlan(null, ["Mawler"], 1)).Violations);
    }

    [Fact]
    public void OpeningProtection()
    {
        var rules = Fixture.Rules();
        var room = Normal(original: ["Nibbit"], battlesBefore: 0);
        Assert.True(rules.IsOpeningProtected(room));
        Assert.True(rules.Quote(room, new SummonPlan(null, ["ShrinkerBeetle"])).Ok);
        Assert.True(rules.Quote(room, new SummonPlan(null, ["Inklet"])).Ok); // 本幕普通怪都能用
        Assert.Contains(SummonViolation.OpeningProtectionMonster, rules.Quote(room, new SummonPlan(null, ["Byrdonis"])).Violations); // 精英不行
        Assert.Contains(SummonViolation.OpeningProtectionCost, rules.Quote(room, new SummonPlan(null, ["Nibbit", "LeafSlimeS"])).Violations);
        Assert.Contains(SummonViolation.OpeningProtectionTraps, rules.Quote(room, new SummonPlan(null, ["Nibbit"], 1)).Violations);

        Assert.False(rules.IsOpeningProtected(room with { BattlesBeforeInRun = 3 }));
        Assert.False(rules.IsOpeningProtected(room with { ActId = "Hive", BattlesBeforeInRun = 0 }));
    }

    [Fact]
    public void EliteRoomIsADiscountRoomWithOneElite()
    {
        var rules = Fixture.Rules();
        var room = new RoomContext("Overgrowth", RoomKind.Elite, 2, 10, ["BygoneEffigy"], 30); // 标准开销 8，上限 12

        Assert.Equal(9, rules.SummonPrice("Byrdonis", 1, RoomKind.Monster));
        Assert.Equal(7, rules.SummonPrice("Byrdonis", 1, RoomKind.Elite)); // 打七折：9.6 × 0.7 ≈ 6.7 → 7
        var plan = rules.Quote(room, new SummonPlan(null, ["Byrdonis", "Mawler"])); // 7 + 2 + 税 1 = 10
        Assert.True(plan.Ok, string.Join(",", plan.Violations));
        Assert.Equal(10, plan.Total);

        Assert.Contains(SummonViolation.TooManyElites, rules.Quote(room, new SummonPlan(null, ["Byrdonis", "BygoneEffigy"])).Violations);
        Assert.Contains(SummonViolation.EncounterNotAllowed, rules.Quote(room, new SummonPlan("ByrdonisElite", [])).Violations);
        Assert.Contains(SummonViolation.EmptyRoom, rules.Quote(room, new SummonPlan(null, [])).Violations);
    }

    [Fact]
    public void HomeActPricesMatchThePriceTable()
    {
        var rules = Fixture.Rules();
        foreach (var act in Fixture.Prices.Acts.Values)
        foreach (var (id, m) in act.Monsters.Where(m => m.Value.Role is MonsterRole.Normal or MonsterRole.Elite))
            if (rules.ActsAhead(id, act.ActNo) == 0)
                Assert.Equal(m.Price, rules.SummonPrice(id, act.ActNo, RoomKind.Monster));
    }

    [Fact]
    public void LaterActMonstersAreWeakerButPricier()
    {
        var rules = Fixture.Rules();
        Assert.Equal(1.0, rules.HpFactor("Mawler", 3));        // 早期的怪放到后面：不变
        Assert.Equal(0.8, rules.HpFactor("Chomper", 1), 6);    // 第二幕的怪在第一幕：血量 −20%
        Assert.Equal(0.6, rules.HpFactor("FrogKnight", 1), 6); // 第三幕的怪在第一幕：−40%
        Assert.True(rules.SummonPrice("Chomper", 1, RoomKind.Monster) > rules.SummonPrice("Chomper", 2, RoomKind.Monster));
    }

    [Fact]
    public void BossRoomIsFreeAndExtrasAreCapped()
    {
        var rules = Fixture.Rules();
        var room = new RoomContext("Overgrowth", RoomKind.Boss, 1, 15, ["Vantom"], 30);
        var free = rules.Quote(room, new SummonPlan("CeremonialBeastBoss", []));
        Assert.True(free.Ok);
        Assert.Equal(0, free.Total);

        // 本幕（密林）普通战平均标准开销 ≈ 4.96，额外召唤上限 ≈ 9.9。
        var extras = rules.Quote(room, new SummonPlan("CeremonialBeastBoss", ["Mawler", "Fogmog"])); // 6 + 税3 = 9
        Assert.True(extras.Ok, string.Join(",", extras.Violations));
        Assert.Equal(9, extras.Total);
        Assert.Contains(SummonViolation.OverBossExtraCap,
            rules.Quote(room with { Climbers = 3 }, new SummonPlan("CeremonialBeastBoss", ["Mawler", "Fogmog", "Nibbit"])).Violations);

        // Boss 遭遇整体算 1 个单位：同族小队本身 3 只，单人时（上限 3）还能另加 2 只，第 3 只超限。
        Assert.DoesNotContain(SummonViolation.TooManyMonsters, rules.Quote(room, new SummonPlan("TheKinBoss", ["Nibbit", "Nibbit"])).Violations);
        Assert.Contains(SummonViolation.TooManyMonsters, rules.Quote(room, new SummonPlan("TheKinBoss", ["Nibbit", "Nibbit", "LeafSlimeS"])).Violations);
        Assert.True(rules.Quote(room, new SummonPlan("TheKinBoss", [])).Ok);
    }

    [Fact]
    public void BossMustBeAPublishedCandidate()
    {
        var rules = Fixture.Rules();
        var candidates = rules.PickBossCandidates("Overgrowth", "VantomBoss", n => n - 1);
        Assert.Equal(new[] { "VantomBoss", "TheKinBoss" }, candidates); // 其余按名字排序：CeremonialBeastBoss, TheKinBoss
        Assert.Equal(new[] { "VantomBoss", "CeremonialBeastBoss" }, rules.PickBossCandidates("Overgrowth", "VantomBoss", _ => 0));

        var room = new RoomContext("Overgrowth", RoomKind.Boss, 1, 15, ["Vantom"], 30, candidates);
        Assert.True(rules.Quote(room, new SummonPlan("TheKinBoss", [])).Ok);
        Assert.Contains(SummonViolation.BossNotCandidate, rules.Quote(room, new SummonPlan("CeremonialBeastBoss", [])).Violations);
    }

    [Fact]
    public void StandardCostOverrideAndActAverages()
    {
        var rules = Fixture.Rules();
        Assert.Equal(5, rules.AverageStandardCost("Overgrowth", RoomKind.Monster));       // 4.96
        Assert.Equal(3, rules.AverageStandardCost("Overgrowth", RoomKind.Monster, weak: true));
        Assert.Equal(9, rules.AverageStandardCost("Overgrowth", RoomKind.Elite));         // 9.33

        // 进房前不知道原版遭遇：用平均值当标准开销，上限 = 5 × 1.6 = 8
        var room = new RoomContext("Overgrowth", RoomKind.Monster, 1, 5, [], 30, StandardCostOverride: 5);
        var quote = rules.Quote(room, new SummonPlan(null, ["Mawler", "Nibbit"]));
        Assert.Equal(5, quote.StandardCost);
        Assert.True(quote.Ok);
        Assert.Contains(SummonViolation.OverSpendCap, rules.Quote(room, new SummonPlan(null, ["Mawler", "Fogmog", "Nibbit"])).Violations);
        Assert.Equal(5, rules.Fallback(room).Total);
    }

    [Fact]
    public void FallbackPaysStandardCostOrWhatIsLeft()
    {
        var rules = Fixture.Rules();
        Assert.Equal(5, rules.Fallback(Normal()).Total);
        Assert.Equal(3, rules.Fallback(Normal(savings: 3)).Total);
        Assert.Equal(0, rules.Fallback(new RoomContext("Overgrowth", RoomKind.Boss, 1, 15, ["Vantom"], 30)).Total);
    }
}

public class EconomyTests
{
    private static BattleResult Battle(int std = 5, int spend = 5, int dmg = 0, params ulong[] down) =>
        new(RoomKind.Monster, std, spend, dmg, down);

    [Theory]
    [InlineData(1, 1, 5)]
    [InlineData(1, 2, 6)] // 5 × 1.25 = 6.25 → 6
    [InlineData(1, 3, 7)]
    [InlineData(2, 2, 7)]
    [InlineData(3, 3, 10)]
    public void BaseIncomeByActAndClimbers(int act, int climbers, int expected)
    {
        Assert.Equal(expected, new SummonWallet(Fixture.Config(), act).BaseIncome(climbers));
    }

    [Fact]
    public void SavingsBonus()
    {
        var w = new SummonWallet(Fixture.Config());
        Assert.Equal(0, w.SavingsBonus(RoomKind.Monster, 5, 8));
        Assert.Equal(0, w.SavingsBonus(RoomKind.Monster, 5, 4));
        Assert.Equal(1, w.SavingsBonus(RoomKind.Monster, 5, 3));
        Assert.Equal(3, w.SavingsBonus(RoomKind.Monster, 16, 2));
        Assert.Equal(0, w.SavingsBonus(RoomKind.Boss, 0, 0));
    }

    [Fact]
    public void SettleAddsAllParts()
    {
        var w = new SummonWallet(Fixture.Config());
        w.Spend(3);
        var income = w.SettleBattle(Battle(std: 5, spend: 1, dmg: 27, down: 7), climbers: 1, out var rewarded);
        Assert.Equal(new IncomeBreakdown(5, 2, 2, 5, 0), income);
        Assert.Equal(new[] { 7UL }, rewarded);
        Assert.Equal(12 - 3 + 14, w.Points);
    }

    [Fact]
    public void ConsecutiveKnockdownGivesNoSecondReward()
    {
        var w = new SummonWallet(Fixture.Config());
        w.SettleBattle(Battle(down: [1, 2]), 2, out var first);
        w.SettleBattle(Battle(down: [1]), 2, out var second);
        w.SettleBattle(Battle(), 2, out _);
        w.SettleBattle(Battle(down: [1]), 2, out var fourth);
        Assert.Equal(new[] { 1UL, 2UL }, first);
        Assert.Empty(second);
        Assert.Equal(new[] { 1UL }, fourth);
    }

    [Fact]
    public void RestoreFromSave()
    {
        var w = new SummonWallet(Fixture.Config());
        w.Restore(22, 2, [5UL]);
        Assert.Equal((22, 2), (w.Points, w.ActNo));
        w.SettleBattle(Battle(down: [5]), 2, out var rewarded);
        Assert.Empty(rewarded); // 存档前那场被击倒的人，连续第二场不给奖励
        w.Restore(999, 1, []);
        Assert.Equal(30, w.Points); // 截到上限
    }

    [Fact]
    public void SavingsCapWastesOverflowAndNewActTrims()
    {
        var config = Fixture.Config();
        config.SavingsCap = [30, 20, 60];
        var w = new SummonWallet(config);
        w.Gain(16); // 28
        var income = w.SettleBattle(Battle(dmg: 30), 1, out _); // 5 + 3 = 8，只能进 2
        Assert.Equal(6, income.Wasted);
        Assert.Equal(2, income.Credited);
        Assert.Equal(30, w.Points);
        Assert.Equal(10, w.EnterAct(2));
        Assert.Equal(20, w.Points);
        Assert.Throws<InvalidOperationException>(() => w.Spend(21));
    }
}

public class ThreatSessionTests
{
    [Theory]
    [InlineData(1, RoomKind.Monster, 1, 3)]
    [InlineData(2, RoomKind.Elite, 1, 5)]
    [InlineData(3, RoomKind.Boss, 3, 9)]
    public void Allotment(int act, RoomKind room, int climbers, int expected)
    {
        Assert.Equal(expected, ThreatSession.Allotment(Fixture.Config(), act, room, climbers));
    }

    [Fact]
    public void BlockScalesWithActAndSpendsPoints()
    {
        var s = new ThreatSession(Fixture.Config(), 2, RoomKind.Monster, 1);
        Assert.Equal(9, s.Block(1).Amount);
        Assert.Equal(3, s.Points);
    }

    [Fact]
    public void HealTwicePerMonster()
    {
        var s = new ThreatSession(Fixture.Config(), 3, RoomKind.Monster, 1);
        Assert.Equal(14, s.Heal(1, 145).Amount);
        Assert.True(s.Heal(1, 145).Ok);
        Assert.Equal(ThreatViolation.HealLimit, s.Heal(1, 145).Violation);
        Assert.True(s.Heal(2, 5).Ok); // 至少回 1
        Assert.Equal(2, s.Points);
    }

    [Fact]
    public void DebuffOncePerPlayerPerTurn()
    {
        var s = new ThreatSession(Fixture.Config(), 1, RoomKind.Monster, 2);
        Assert.True(s.Debuff(10, PlayerDebuff.Weak).Ok);
        Assert.Equal(ThreatViolation.DebuffLimit, s.Debuff(10, PlayerDebuff.Frail).Violation);
        Assert.True(s.Debuff(11, PlayerDebuff.Vulnerable).Ok);
        s.NextTurn();
        Assert.True(s.Debuff(10, PlayerDebuff.Frail).Ok);
        Assert.True(s.Debuff(11, PlayerDebuff.Weak).Ok);
        Assert.Equal(0, s.Points);
        s.NextTurn();
        Assert.Equal(ThreatViolation.NotEnoughThreat, s.Debuff(10, PlayerDebuff.Weak).Violation);
    }

    [Fact]
    public void DazedThreePerBattle()
    {
        var config = Fixture.Config();
        config.ThreatPerBattle = [10, 10, 10];
        var s = new ThreatSession(config, 1, RoomKind.Monster, 1);
        for (int i = 0; i < 3; i++) Assert.True(s.Dazed(1).Ok);
        Assert.Equal(ThreatViolation.DazedLimit, s.Dazed(2).Violation);
    }

    [Fact]
    public void StrengthCapCombinesThreatAndTraps()
    {
        var config = Fixture.Config();
        config.ThreatPerBattle = [20, 20, 20];
        var s = new ThreatSession(config, 2, RoomKind.Monster, 1); // 上限 4，单次 +2
        Assert.Equal(1, s.AddTrapStrength(1, 1));
        Assert.True(s.Strength(1).Ok); // 3
        Assert.Equal(ThreatViolation.StrengthCap, s.Strength(1).Violation); // 5 > 4，拒绝且不扣点
        Assert.Equal(18, s.Points);
        Assert.Equal(1, s.AddTrapStrength(1, 2)); // 截断到 4

        var all = s.StrengthAll([1, 2, 2, 3]);
        Assert.Equal(new[] { 2, 3 }, all.Monsters!);
        Assert.Equal(15, s.Points);
        Assert.Equal(ThreatViolation.StrengthAllLimit, s.StrengthAll([2]).Violation);
    }

    [Fact]
    public void StrengthAllNeedsATarget()
    {
        var s = new ThreatSession(Fixture.Config(), 1, RoomKind.Boss, 1); // 5 点，上限 2
        s.AddTrapStrength(1, 2);
        Assert.Equal(ThreatViolation.NoTarget, s.StrengthAll([1]).Violation);
        Assert.Equal(5, s.Points);
    }
}

public class ConfigTests
{
    [Fact]
    public void RoundTripsAndKeepsDefaultsForMissingFields()
    {
        var config = TowerMasterConfig.FromJson("""
        {
          // 注释和尾逗号都允许
          "base_income": [5, 6, 7],
          "threat": { "strength_cap_per_act": 3 },
        }
        """);
        Assert.Equal(new[] { 5, 6, 7 }, config.BaseIncome);
        Assert.Equal(3, config.Threat.StrengthCapPerAct);
        Assert.Equal(2, config.Threat.StrengthCost);
        Assert.Equal(12, config.StartingSummonPoints);

        var again = TowerMasterConfig.FromJson(config.ToJson());
        Assert.Equal(config.ToJson(), again.ToJson());
    }
}
