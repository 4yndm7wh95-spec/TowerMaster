using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Models;

// 塔主回合用到的原版命令、能力、牌和队列暂停（只保留被调用的形状）。

namespace MegaCrit.Sts2.Core.GameActions.Multiplayer
{
    public sealed class ActionQueueSet
    {
        public bool Paused { get; private set; }
        public int PauseCount { get; private set; }
        public void PauseAllPlayerQueues() { Paused = true; PauseCount++; }
        public void UnpauseAllPlayerQueues() => Paused = false;
    }
    public abstract class PlayerChoiceContext { }
    public sealed class GameActionPlayerChoiceContext(MegaCrit.Sts2.Core.GameActions.GameAction action) : PlayerChoiceContext
    {
        public MegaCrit.Sts2.Core.GameActions.GameAction Action { get; } = action;
    }
}
namespace MegaCrit.Sts2.Core.ValueProps
{
    [Flags] public enum ValueProp { None = 0, Unblockable = 2, Unpowered = 4, Move = 8 }
}
namespace MegaCrit.Sts2.Core.Entities.Cards
{
    public enum PileType { None, Draw, Hand, Discard, Exhaust }
    public enum CardPilePosition { None, Bottom, Top, Random }
    public sealed class CardPlay { }
    public sealed class CardPile
    {
        public List<CardModel> Cards { get; } = new();
    }
}
namespace MegaCrit.Sts2.Core.Models
{
    public abstract class PowerModel : AbstractModel { public int Amount { get; set; } }
    public abstract class CardModel : AbstractModel { public virtual string Title => GetType().Name; }
}
namespace MegaCrit.Sts2.Core.Models.Powers
{
    public sealed class StrengthPower : PowerModel { }
    public sealed class WeakPower : PowerModel { }
    public sealed class VulnerablePower : PowerModel { }
    public sealed class FrailPower : PowerModel { }
}
namespace MegaCrit.Sts2.Core.Models.Cards
{
    public sealed class Dazed : CardModel { }
    public sealed class Strike : CardModel { public override string Title => "打击"; }
}
namespace MegaCrit.Sts2.Core.Commands
{
    using MegaCrit.Sts2.Core.Entities.Cards;
    using MegaCrit.Sts2.Core.GameActions.Multiplayer;

    public static class CreatureCmd
    {
        public static Task<decimal> GainBlock(Creature creature, object blockVar, CardPlay? cardPlay, bool fast = false) => throw new NotSupportedException();
        public static Task<decimal> GainBlock(Creature creature, decimal amount, MegaCrit.Sts2.Core.ValueProps.ValueProp props, CardPlay? cardPlay, bool fast = false)
        {
            creature.Block += (int)amount;
            return Task.FromResult(amount);
        }
        public static Task Heal(Creature creature, decimal amount, bool playAnim = true)
        {
            creature.HealBy((int)amount);
            return Task.CompletedTask;
        }
    }
    public static class PowerCmd
    {
        public static Task<IReadOnlyList<T>> Apply<T>(PlayerChoiceContext choiceContext, IEnumerable<Creature> targets, decimal amount, Creature? applier, CardModel? cardSource, bool silent = false)
            where T : PowerModel => throw new NotSupportedException();
        public static Task<T?> Apply<T>(PlayerChoiceContext choiceContext, Creature target, decimal amount, Creature? applier, CardModel? cardSource, bool silent = false)
            where T : PowerModel
        {
            if (choiceContext == null) throw new ArgumentNullException(nameof(choiceContext));
            var power = target.Powers.OfType<T>().FirstOrDefault();
            if (power == null) { power = Activator.CreateInstance<T>(); target.Powers.Add(power); }
            power.Amount += (int)amount;
            return Task.FromResult<T?>(power);
        }
    }
    public static class CardPileCmd
    {
        public static Task AddToCombatAndPreview<T>(IEnumerable<Creature> targets, PileType pileType, int count, MegaCrit.Sts2.Core.Entities.Players.Player? creator, CardPilePosition position = CardPilePosition.Bottom)
            where T : CardModel => throw new NotSupportedException();
        public static Task AddToCombatAndPreview<T>(Creature target, PileType pileType, int count, MegaCrit.Sts2.Core.Entities.Players.Player? creator, CardPilePosition position = CardPilePosition.Bottom)
            where T : CardModel
        {
            if (pileType != PileType.Draw) throw new ArgumentException("测试只支持抽牌堆");
            for (int i = 0; i < count; i++) target.Player!.PlayerCombatState.DrawPile.Cards.Add(Activator.CreateInstance<T>());
            return Task.CompletedTask;
        }
    }
}
