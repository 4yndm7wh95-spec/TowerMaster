using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Models;

// 塔主回合用到的原版命令、能力、牌和队列暂停（只保留被调用的形状）。

namespace MegaCrit.Sts2.Core.GameActions.Multiplayer
{
    public sealed class ActionQueueSet
    {
        public sealed class ActionQueue { public bool isPaused; public bool isCancellingPlayerDrivenCombatActions; public bool isCancellingCombatActions; }
        private readonly Dictionary<ulong, ActionQueue> _queues = new();
        public bool Paused { get; private set; }
        public int PauseCount { get; private set; }
        public void PauseAllPlayerQueues()
        {
            Paused = true; PauseCount++;
            foreach (var q in _queues.Values) q.isPaused = true;
        }
        public void UnpauseAllPlayerQueues() { Paused = false; foreach (var q in _queues.Values) q.isPaused = false; }
        public bool ActionQueueIsPaused(ulong id) => GetQueue(id).isPaused || (Paused && !_queues.ContainsKey(id));
        private ActionQueue GetQueue(ulong id) => _queues.TryGetValue(id, out var q) ? q : _queues[id] = new ActionQueue { isPaused = Paused };
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
    public enum CardType { None, Attack, Skill, Power, Status, Curse }
    public enum CardRarity { None, Basic, Common, Uncommon, Rare, Ancient, Event, Token, Status, Curse, Quest }
    public enum TargetType { None, Self, AnyEnemy, AllEnemies, RandomEnemy, AnyPlayer, AnyAlly, AllAllies, TargetedNoCreature, Osty }
    public enum CardKeyword { None, Exhaust, Ethereal, Innate, Unplayable, Retain, Sly, Eternal }
    [Flags] public enum UnplayableReason { None = 0, HasUnplayableKeyword = 2, BlockedByHook = 4, BlockedByCardLogic = 8, EnergyCostTooHigh = 16, StarCostTooHigh = 32, NoLivingAllies = 64 }
    public sealed class CardPlay
    {
        public MegaCrit.Sts2.Core.Entities.Creatures.Creature? Target { get; set; }
        public CardModel Card { get; set; } = null!;
        public MegaCrit.Sts2.Core.Entities.Players.Player Player { get; set; } = null!;
        public bool IsFirstInSeries { get; set; } = true;
    }
    public sealed class CardPile
    {
        public List<CardModel> Cards { get; } = new();
        public void Clear(bool silent = false) => Cards.Clear();
        public void AddInternal(CardModel card, int index = -1, bool silent = false) => Cards.Add(card);
        public void RemoveInternal(CardModel card, bool silent = false) => Cards.Remove(card);
    }
}
namespace MegaCrit.Sts2.Core.Models
{
    public abstract class PowerModel : AbstractModel { public int Amount { get; set; } }
    public abstract class CardPoolModel : AbstractModel { }
    public sealed class ColorlessCardPool : CardPoolModel { }
    public abstract class CardModel : AbstractModel
    {
        protected CardModel() { }
        protected CardModel(int canonicalEnergyCost, MegaCrit.Sts2.Core.Entities.Cards.CardType type, MegaCrit.Sts2.Core.Entities.Cards.CardRarity rarity,
            MegaCrit.Sts2.Core.Entities.Cards.TargetType targetType, bool shouldShowInCardLibrary = true)
        {
            Cost = canonicalEnergyCost; _type = type; Rarity = rarity; TargetType = targetType; ShouldShowInCardLibrary = shouldShowInCardLibrary;
        }
        private readonly MegaCrit.Sts2.Core.Entities.Cards.CardType _type = MegaCrit.Sts2.Core.Entities.Cards.CardType.Skill;
        public int Cost { get; }
        public MegaCrit.Sts2.Core.Entities.Cards.CardRarity Rarity { get; }
        public MegaCrit.Sts2.Core.Entities.Cards.TargetType TargetType { get; }
        public bool ShouldShowInCardLibrary { get; }
        public static string MissingPortraitPath => "res://missing.png";
        public virtual string Title => GetType().Name;
        public virtual MegaCrit.Sts2.Core.Entities.Cards.CardType Type => _type;
        public virtual string PortraitPath => "res://" + GetType().Name;
        public virtual CardPoolModel Pool => throw new InvalidProgramException("不在卡池里");
        public virtual CardPoolModel VisualCardPool => Pool;
        public virtual IEnumerable<MegaCrit.Sts2.Core.Entities.Cards.CardKeyword> CanonicalKeywords => [];
        public virtual bool CanBeGeneratedInCombat => true;
        public virtual bool CanBeGeneratedByModifiers => true;
        public virtual int MaxUpgradeLevel => 1;
        public MegaCrit.Sts2.Core.Entities.Players.Player? Owner { get; set; }
        protected virtual Task OnPlay(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Cards.CardPlay cardPlay) => Task.CompletedTask;
        public Task Play(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Cards.CardPlay cardPlay) => OnPlay(choiceContext, cardPlay);
        public CardModel ToMutable() => (CardModel)MutableClone();
        /// <summary>仿原版：能量不够不能打；给队友的牌要有其他活着的玩家（这里简化成永远没有，测试塔主牌的放行）。</summary>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        public bool CanPlay(out MegaCrit.Sts2.Core.Entities.Cards.UnplayableReason reason, out AbstractModel? preventer)
        {
            preventer = null;
            reason = Owner != null && Owner.PlayerCombatState.Energy < Cost ? MegaCrit.Sts2.Core.Entities.Cards.UnplayableReason.EnergyCostTooHigh
                : TargetType == MegaCrit.Sts2.Core.Entities.Cards.TargetType.AnyAlly ? MegaCrit.Sts2.Core.Entities.Cards.UnplayableReason.NoLivingAllies
                : MegaCrit.Sts2.Core.Entities.Cards.UnplayableReason.None;
            return reason == MegaCrit.Sts2.Core.Entities.Cards.UnplayableReason.None;
        }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        public bool IsValidTarget(MegaCrit.Sts2.Core.Entities.Creatures.Creature? target) => target == null || !target.IsDead;
    }
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
    public sealed class Strike : CardModel
    {
        public override string Title => "打击";
        public override MegaCrit.Sts2.Core.Entities.Cards.CardType Type => MegaCrit.Sts2.Core.Entities.Cards.CardType.Attack;
    }
    public sealed class Defend : CardModel { public override string Title => "防御"; }
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
    public static class PlayerCmd
    {
        public static Task SetEnergy(decimal amount, MegaCrit.Sts2.Core.Entities.Players.Player player)
        {
            player.PlayerCombatState.Energy = (int)amount;
            return Task.CompletedTask;
        }
        public static Task GainGold(decimal amount, MegaCrit.Sts2.Core.Entities.Players.Player player, bool wasStolenBack = false)
        {
            player.Gold += (int)amount;
            return Task.CompletedTask;
        }
    }
    /// <summary>原版的静态钩子（出牌后通知所有模型）。</summary>
    public static class Hook
    {
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        public static Task AfterCardPlayed(MegaCrit.Sts2.Core.Combat.CombatState combatState, PlayerChoiceContext choiceContext, CardPlay cardPlay) => Task.CompletedTask;
    }
    public static class CardPileCmd
    {
        /// <summary>仿原版：死亡玩家不抽牌（SetupPlayerTurn 跳过死者，这里也跳过，测试我们的手动发牌）。</summary>
        public static Task<IEnumerable<CardModel>> Draw(PlayerChoiceContext choiceContext, decimal count, MegaCrit.Sts2.Core.Entities.Players.Player player, bool fromHandDraw = false)
        {
            if (player.Creature.IsDead) return Task.FromResult<IEnumerable<CardModel>>([]);
            var drawn = player.PlayerCombatState.DrawPile.Cards.Take((int)count).ToList();
            foreach (var c in drawn) { player.PlayerCombatState.DrawPile.Cards.Remove(c); player.PlayerCombatState.Hand.Cards.Add(c); }
            return Task.FromResult<IEnumerable<CardModel>>(drawn);
        }
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
    /// <summary>仿原版：弃牌在 CardCmd 上（CardPileCmd 没有 Discard）。</summary>
    public static class CardCmd
    {
        public static Task Discard(PlayerChoiceContext choiceContext, IEnumerable<CardModel> cards)
        {
            foreach (var c in cards.ToList())
            {
                var pcs = c.Owner!.PlayerCombatState;
                pcs.Hand.Cards.Remove(c);
                pcs.DiscardPile.Cards.Add(c);
            }
            return Task.CompletedTask;
        }
    }
}
