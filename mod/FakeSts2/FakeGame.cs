using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Models.Encounters;

namespace MegaCrit.Sts2.Core.Models
{
    public abstract class AbstractModel
    {
        public bool IsMutable { get; private set; }

        protected AbstractModel MutableClone()
        {
            var copy = (AbstractModel)MemberwiseClone();
            copy.IsMutable = true;
            return copy;
        }
    }

    public abstract class EncounterModel : AbstractModel
    {
        public IReadOnlyList<(MonsterModel Monster, string? Slot)> MonstersWithSlots { get; private set; } = [];
        public virtual bool HasScene => false;
        public virtual IReadOnlyList<string> Slots => [];

        public EncounterModel ToMutable()
        {
            if (IsMutable) throw new InvalidOperationException("只有规范模型能创建可变副本");
            return (EncounterModel)MutableClone();
        }

        protected abstract IReadOnlyList<(MonsterModel, string?)> GenerateMonsters();

        [MethodImpl(MethodImplOptions.NoInlining)]
        public void GenerateMonstersWithSlots(MegaCrit.Sts2.Core.Runs.IRunState runState)
        {
            if (!IsMutable) throw new InvalidOperationException("规范模型不能生成怪物");
            MonstersWithSlots = GenerateMonsters();
        }
    }

    public static class ModelDb
    {
        private static readonly Dictionary<Type, object> Cache = new();
        private static readonly Dictionary<Type, AbstractModel> Content = new();

        /// <summary>仿造：Init 时收录 mod 类型（经 ReflectionHelper.ModTypes）。</summary>
        public static void Init()
        {
            foreach (var t in MegaCrit.Sts2.Core.Helpers.ReflectionHelper.ModTypes.Where(t => typeof(AbstractModel).IsAssignableFrom(t) && !t.IsAbstract))
                Content[t] = (AbstractModel)Activator.CreateInstance(t)!;
        }
        private static AbstractModel Get(Type type) => Content[type];
        public static string GetEntry(Type type) => string.Concat(type.Name.Select((c, i) => i > 0 && char.IsUpper(c) ? "_" + c : c.ToString())).ToUpperInvariant();
        public static IEnumerable<CardPoolModel> AllSharedCardPools { get; } = [new ColorlessCardPool()];

        public static T Monster<T>() where T : MonsterModel => Activator.CreateInstance<T>();

        public static T Encounter<T>() where T : EncounterModel
        {
            if (!Cache.TryGetValue(typeof(T), out var model)) Cache[typeof(T)] = model = Activator.CreateInstance<T>();
            return (T)model;
        }
    }
}

namespace MegaCrit.Sts2.Core.Models.Encounters
{
    public sealed class MawlerNormal : EncounterModel
    {
        protected override IReadOnlyList<(MonsterModel, string?)> GenerateMonsters() => [(new MegaCrit.Sts2.Core.Models.Monsters.Mawler().ToMutable(), null)];
    }

    public sealed class NibbitsNormal : EncounterModel
    {
        protected override IReadOnlyList<(MonsterModel, string?)> GenerateMonsters() => [(new MegaCrit.Sts2.Core.Models.Monsters.Nibbit().ToMutable(), "front"), (new MegaCrit.Sts2.Core.Models.Monsters.Nibbit().ToMutable(), "back")];
    }

    public sealed class ByrdonisElite : EncounterModel
    {
        protected override IReadOnlyList<(MonsterModel, string?)> GenerateMonsters() => [(new MegaCrit.Sts2.Core.Models.Monsters.BygoneEffigy().ToMutable(), null)];
    }

    public sealed class VantomBoss : EncounterModel
    {
        protected override IReadOnlyList<(MonsterModel, string?)> GenerateMonsters() => [(new MegaCrit.Sts2.Core.Models.Monsters.Mawler().ToMutable(), null)];
    }

    public sealed class CeremonialBeastBoss : EncounterModel
    {
        protected override IReadOnlyList<(MonsterModel, string?)> GenerateMonsters() => [(new MegaCrit.Sts2.Core.Models.Monsters.Mawler().ToMutable(), null)];
    }

    public sealed class TheKinBoss : EncounterModel
    {
        protected override IReadOnlyList<(MonsterModel, string?)> GenerateMonsters() => [(new MegaCrit.Sts2.Core.Models.Monsters.Mawler().ToMutable(), null)];
    }

    /// <summary>仿造有命名槽位的遭遇（墨宝靠槽位排位）：它的怪不能混搭。</summary>
    public sealed class InkletsNormal : EncounterModel
    {
        public override IReadOnlyList<string> Slots => ["front", "middle", "back"];
        protected override IReadOnlyList<(MonsterModel, string?)> GenerateMonsters() => [];
    }

    public sealed class ChompersNormal : EncounterModel
    {
        protected override IReadOnlyList<(MonsterModel, string?)> GenerateMonsters() => [(new MegaCrit.Sts2.Core.Models.Monsters.Chomper().ToMutable(), null)];
    }

    public sealed class BygoneEffigyElite : EncounterModel
    {
        protected override IReadOnlyList<(MonsterModel, string?)> GenerateMonsters() => [(new MegaCrit.Sts2.Core.Models.Monsters.BygoneEffigy().ToMutable(), null)];
    }
}

namespace MegaCrit.Sts2.Core.Models
{
    public class ActModel(EncounterModel next)
    {
        [MethodImpl(MethodImplOptions.NoInlining)]
        public EncounterModel PullNextEncounter(MegaCrit.Sts2.Core.Rooms.RoomType roomType) => roomType switch
        {
            MegaCrit.Sts2.Core.Rooms.RoomType.Elite => ModelDb.Encounter<BygoneEffigyElite>(),
            MegaCrit.Sts2.Core.Rooms.RoomType.Boss => BossEncounter,
            _ => next,
        };

        /// <summary>游戏为本幕选好的 Boss。</summary>
        public EncounterModel BossEncounter => ModelDb.Encounter<VantomBoss>();
    }
}

namespace MegaCrit.Sts2.Core.Runs
{
    public interface IRunState { }
    public sealed class RunState : IRunState
    {
        public int TotalFloor { get; set; }
        public ActModel Act { get; set; } = new MegaCrit.Sts2.Core.Models.Acts.Overgrowth();
        public RunRng Rng { get; } = new();
        public List<MegaCrit.Sts2.Core.Entities.Players.Player> Players { get; } = new();
        public MegaCrit.Sts2.Core.Map.ActMap Map { get; set; } = new();
        public MegaCrit.Sts2.Core.Map.MapCoord? CurrentMapCoord { get; set; }
    }
    public sealed class RunRng { public ulong Seed { get; set; } = 123; }
}

namespace MegaCrit.Sts2.Core.Combat
{
    public sealed class CombatState(EncounterModel encounter, MegaCrit.Sts2.Core.Runs.IRunState runState)
    {
        public EncounterModel Encounter { get; } = encounter;
        public MegaCrit.Sts2.Core.Runs.IRunState RunState { get; } = runState;
        public IReadOnlyList<MegaCrit.Sts2.Core.Entities.Players.Player> Players =>
            (RunState as MegaCrit.Sts2.Core.Runs.RunState)?.Players ?? [];
        public List<MegaCrit.Sts2.Core.Entities.Creatures.Creature> Enemies { get; } = new();
        public CombatSide CurrentSide { get; set; } = CombatSide.Player;
        public int RoundNumber { get; set; } = 1;

        // 真游戏：按人数缩放怪物血量（调用方读 Players.Count 传进公式）
        [MethodImpl(MethodImplOptions.NoInlining)]
        public MegaCrit.Sts2.Core.Entities.Creatures.Creature CreateCreature(MonsterModel monster, int baseHp)
        {
            var creature = new MegaCrit.Sts2.Core.Entities.Creatures.Creature(
                MegaCrit.Sts2.Core.Entities.Creatures.Creature.ScaleHpForMultiplayer(baseHp, Players.Count)) { Monster = monster };
            Enemies.Add(creature);
            return creature;
        }
    }

    public enum CombatSide { None, Player, Enemy }

    public sealed class CombatManager
    {
        public static CombatManager? Instance { get; set; }
        public CombatState? State { get; private set; }
        public CombatState? DebugOnlyGetState() => State;
        public event Action<CombatState>? TurnStarted;
        public event Action<MegaCrit.Sts2.Core.Rooms.CombatRoom>? CombatEnded;
        public void StartTurn(CombatSide side, int round)
        {
            State!.CurrentSide = side;
            State.RoundNumber = round;
            TurnStarted?.Invoke(State);
        }
        public void End(MegaCrit.Sts2.Core.Rooms.CombatRoom room) => CombatEnded?.Invoke(room);

        [MethodImpl(MethodImplOptions.NoInlining)]
        public void SetUpCombat(CombatState state) => State = state;

        public event Action<MegaCrit.Sts2.Core.Rooms.CombatRoom>? CombatWon;
        public void Win(MegaCrit.Sts2.Core.Rooms.CombatRoom room) => CombatWon?.Invoke(room);
    }
}

namespace MegaCrit.Sts2.Core.Rooms
{
    public enum RoomType { Monster, Elite, Boss }

    public sealed class CombatRoom
    {
        public MegaCrit.Sts2.Core.Combat.CombatState CombatState { get; }
        public EncounterModel Encounter => CombatState.Encounter;

        public CombatRoom(EncounterModel encounter, MegaCrit.Sts2.Core.Runs.IRunState? runState = null)
        {
            if (!encounter.IsMutable) throw new InvalidOperationException("房间必须使用可变遭遇");
            CombatState = new(encounter, runState ?? new MegaCrit.Sts2.Core.Runs.RunState());
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public void StartCombat() => Encounter.GenerateMonstersWithSlots(CombatState.RunState);
    }
}

namespace MegaCrit.Sts2.Core.Models
{
    public abstract class MonsterModel : AbstractModel
    {
        public string Id => "MONSTER." + GetType().Name.ToUpperInvariant();
        public MonsterModel ToMutable() => (MonsterModel)MutableClone();
        public override string ToString() => Id + " (" + RuntimeHelpers.GetHashCode(this) + ")";
    }
}
namespace MegaCrit.Sts2.Core.Models.Monsters
{
    public sealed class Mawler : MonsterModel { }
    public sealed class Nibbit : MonsterModel { }
    public sealed class BygoneEffigy : MonsterModel { }
    public sealed class Flyconid : MonsterModel { }
    public sealed class CalcifiedCultist : MonsterModel { }
    public sealed class DampCultist : MonsterModel { }
    public sealed class Seapunk : MonsterModel { }
    public sealed class Byrdonis : MonsterModel { }
    public sealed class LeafSlimeS : MonsterModel { }
    public sealed class Chomper : MonsterModel { }
}
namespace MegaCrit.Sts2.Core.Models.Encounters
{
    public sealed class CultistsNormal : EncounterModel
    {
        [MethodImpl(MethodImplOptions.NoInlining)]
        protected override IReadOnlyList<(MonsterModel, string?)> GenerateMonsters() =>
            [(new MegaCrit.Sts2.Core.Models.Monsters.CalcifiedCultist().ToMutable(), null),
             (new MegaCrit.Sts2.Core.Models.Monsters.DampCultist().ToMutable(), null)];
    }
}
namespace MegaCrit.Sts2.Core.Models.Acts
{
    public sealed class Overgrowth() : ActModel(ModelDb.Encounter<MawlerNormal>()) { }
}

namespace MegaCrit.Sts2.Core.Entities.Creatures
{
    public sealed class Creature(int maxHp)
    {
        public int MaxHp { get; } = maxHp;
        public int CurrentHp { get; private set; } = maxHp;
        public int Block { get; internal set; }
        public List<MegaCrit.Sts2.Core.Models.PowerModel> Powers { get; } = new();
        internal void HealBy(int amount) => CurrentHp = Math.Min(MaxHp, CurrentHp + amount);
        public bool IsDead => CurrentHp <= 0;
        public void Damage(int amount) => CurrentHp = Math.Max(0, CurrentHp - amount);
        public void Revive() { if (IsDead) CurrentHp = 1; }
        public MegaCrit.Sts2.Core.Entities.Players.Player? Player { get; init; }
        public MonsterModel? Monster { get; init; }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static int ScaleHpForMultiplayer(int hp, int playerCount) => hp * playerCount;
    }
}
namespace MegaCrit.Sts2.Core.Models.Powers
{
    /// <summary>仿造按人数缩放层数的能力（范围内，应改写）。</summary>
    public static class FakeScaledPower
    {
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static int Amount(MegaCrit.Sts2.Core.Combat.CombatState state, int baseAmount) => baseAmount * state.Players.Count;
    }
}
namespace MegaCrit.Sts2.Core.Multiplayer.Game
{
    /// <summary>仿造等所有玩家投票的同步器（范围外，不应改写）。</summary>
    public static class FakeVoteSynchronizer
    {
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static bool AllVoted(MegaCrit.Sts2.Core.Combat.CombatState state, int votes) => votes >= state.Players.Count;
    }
}
