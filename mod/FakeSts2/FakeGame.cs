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
        public EncounterModel PullNextEncounter(MegaCrit.Sts2.Core.Rooms.RoomType roomType) => next;
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
    }
    public sealed class RunRng { public ulong Seed { get; set; } = 123; }
}

namespace MegaCrit.Sts2.Core.Combat
{
    public sealed class CombatState(EncounterModel encounter, MegaCrit.Sts2.Core.Runs.IRunState runState)
    {
        public EncounterModel Encounter { get; } = encounter;
        public MegaCrit.Sts2.Core.Runs.IRunState RunState { get; } = runState;
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
