using HarmonyLib;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Helpers;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Runs;
using TowerMaster.Core;

namespace TowerMaster.Tests;

[Collection("game")]
public class MasterCardsTests
{
    private static readonly object Gate = new();

    private static void Register()
    {
        lock (Gate)
        {
            Log.Init();
            MasterCards.Register(new Harmony("towermaster.cards"), new TowerMasterConfig());
            ModelDb.Init(); // 仿游戏：ModelDb.Init 在 mod 入口之后，经 ReflectionHelper.ModTypes 收录
        }
    }

    private static CardModel Card(string key) => (CardModel)MasterCards.Canonical(MasterCards.TypeOf(key)!);

    [Fact]
    public void CardsAreRealCardModelsRegisteredBeforeModelDbInit()
    {
        Register();
        Assert.Equal((8 + MasterCards.RewardPool.Length) * 3 + TrapCatalog.All.Count * 3, MasterCards.Types.Count);
        Assert.All(MasterCards.Types, t => Assert.Contains(t, ReflectionHelper.ModTypes));

        var block = Card("act:block@1");
        Assert.Equal("加固", block.Title);
        Assert.Equal("加固+1", Card("act:block@2").Title);
        Assert.Equal(1, block.Cost);
        Assert.Equal(TargetType.AnyEnemy, block.TargetType);
        Assert.Equal(TargetType.AnyAlly, Card("act:weak@1").TargetType);
        Assert.False(block.ShouldShowInCardLibrary);
        Assert.False(block.CanBeGeneratedInCombat);
        Assert.IsType<ColorlessCardPool>(block.Pool);
        Assert.Equal(CardModel.MissingPortraitPath, block.PortraitPath);
        Assert.Empty(block.CanonicalKeywords);

        var trap = Card("trap:brittle@2");
        Assert.Equal("碎甲+1", trap.Title);
        Assert.Equal(CardKeyword.Unplayable, Assert.Single(trap.CanonicalKeywords));

        var cards = LocManager.Instance.GetTable("cards");
        var entry = MasterCards.Entry(MasterCards.TypeOf("trap:brittle@2")!);
        Assert.Contains("给予该玩家 2 层脆弱", cards.Entries[$"{entry}.description"]);
        Assert.Equal("加固", cards.Entries[$"{MasterCards.Entry(MasterCards.TypeOf("act:block@1")!)}.title"]);
    }

    [Fact]
    public async Task BlockCardGivesBlockToItsTarget()
    {
        Register();
        var monster = new MegaCrit.Sts2.Core.Entities.Creatures.Creature(40);
        await Card("act:block@2").Play(null!, new CardPlay { Target = monster });
        Assert.Equal(9, monster.Block);
    }

    [Fact]
    public void NewRunGivesTheMasterAMasterDeckAndDeckCommandsReplaceIt()
    {
        Register();
        var run = new RunState();
        var master = new Player(100001);
        var climber = new Player(100002);
        master.Deck.Cards.Add(new MegaCrit.Sts2.Core.Models.Cards.Strike());
        run.Players.Add(master);
        run.Players.Add(climber);
        RunManager.Instance.NetService = new() { Type = MegaCrit.Sts2.Core.Entities.Multiplayer.NetGameType.Host, NetId = 100001, HostNetId = 100001 };
        RunManager.Instance.SetUpNewMultiplayer(run, null!, false);
        Assert.Equal(MasterCards.StartingActions.Length, master.Deck.Cards.Count);
        Assert.Equal("加固", master.Deck.Cards[0].Title);
        Assert.All(master.Deck.Cards, c => Assert.Same(master, c.Owner));
        Assert.All(master.Deck.Cards, c => Assert.Contains(c, run.AllCards)); // 经 RunState.CreateCard 登记
        run.CheckDecks();
        Assert.Empty(climber.Deck.Cards);

        RunManager.Instance.State = run;
        MasterDeck.Execute(string.Join(",", MasterDeck.Keys(2, [new TrapCard("mire", 2)])), "测试");
        Assert.Equal(MasterCards.StartingActions.Length + 1, master.Deck.Cards.Count);
        Assert.Equal("加固+1", master.Deck.Cards[0].Title);
        Assert.Equal("泥沼+1", master.Deck.Cards[^1].Title);
        Assert.Equal(master.Deck.Cards.Count, run.AllCards.Count); // 旧牌注销了
        run.CheckDecks();
    }

    [Fact]
    public async Task EliteRewardOpensTheVanillaChooseACardScreenAndTheChoiceJoinsTheDeck()
    {
        Register();
        MasterLedger.Clear();
        var run = new RunState();
        var master = new Player(100001);
        run.Players.Add(master);
        run.Players.Add(new Player(100002));
        RunManager.Instance.State = run;
        RunManager.Instance.NetService = new() { Type = MegaCrit.Sts2.Core.Entities.Multiplayer.NetGameType.Host, NetId = 100001, HostNetId = 100001 };

        var offer = MasterRewards.Offer(123, 5);
        Assert.Equal(offer, MasterRewards.Offer(123, 5)); // 同一场固定（读档相同）
        Assert.Equal(3, offer.Distinct().Count());
        Assert.All(offer, op => Assert.Contains(op, MasterCards.RewardPool));

        var action = new MegaCrit.Sts2.Core.GameActions.MoveToMapCoordAction(100001);
        MegaCrit.Sts2.Core.Commands.CardSelectCmd.ChosenIndex = 1;
        await MasterRewards.Execute(new ThreatCommand(1, 0, 0, 2, "reward", MonsterId: string.Join(",", offer), Amount: 5), action, "测试");
        Assert.Equal(3, MegaCrit.Sts2.Core.Commands.CardSelectCmd.LastOffer.Count);
        Assert.EndsWith("+1", MegaCrit.Sts2.Core.Commands.CardSelectCmd.LastOffer[0].Title); // 第二幕的等级
        Assert.Equal(offer[1], Assert.Single(MasterLedger.ExtraCards));
        Assert.True(MasterLedger.RewardTaken(5));
        Assert.Empty(run.AllCards); // 候选牌都注销了

        var keys = MasterDeck.Keys(2, [], MasterLedger.ExtraCards);
        Assert.Contains($"act:{offer[1]}@2", keys);
        Assert.All(keys, k => Assert.NotNull(MasterCards.TypeOf(k)));
        Assert.Equal(CardKeyword.Exhaust, Assert.Single(Card("act:surge@1").CanonicalKeywords));
        Assert.Equal("坚壁+2", Card("act:fortify_all@3").Title);
    }
}
