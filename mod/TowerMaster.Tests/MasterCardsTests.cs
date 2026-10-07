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
        Assert.Equal(8 * 3 + TrapCatalog.All.Count * 3, MasterCards.Types.Count);
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
}
