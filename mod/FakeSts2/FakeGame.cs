using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Models;

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
        public IReadOnlyList<(string Monster, string? Slot)> MonstersWithSlots { get; private set; } = [];

        public EncounterModel ToMutable()
        {
            if (IsMutable) throw new InvalidOperationException("只有规范模型能创建可变副本");
            return (EncounterModel)MutableClone();
        }

        protected abstract List<(string, string?)> Lineup();

        [MethodImpl(MethodImplOptions.NoInlining)]
        public void GenerateMonstersWithSlots(MegaCrit.Sts2.Core.Runs.IRunState runState)
        {
            if (!IsMutable) throw new InvalidOperationException("规范模型不能生成怪物");
            MonstersWithSlots = Lineup();
        }
    }

    public static class ModelDb
    {
        private static readonly Dictionary<Type, object> Cache = new();

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
        protected override List<(string, string?)> Lineup() => [("Mawler", null)];
    }

    public sealed class NibbitsNormal : EncounterModel
    {
        protected override List<(string, string?)> Lineup() => [("Nibbit", "front"), ("Nibbit", "back")];
    }

    public sealed class BygoneEffigyElite : EncounterModel
    {
        protected override List<(string, string?)> Lineup() => [("BygoneEffigy", null)];
    }
}

namespace MegaCrit.Sts2.Core.Models
{
    public sealed class ActModel(EncounterModel next)
    {
        [MethodImpl(MethodImplOptions.NoInlining)]
        public EncounterModel PullNextEncounter(MegaCrit.Sts2.Core.Rooms.RoomType roomType) => next;
    }
}

namespace MegaCrit.Sts2.Core.Runs
{
    public interface IRunState { }
    public sealed class RunState : IRunState { }
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
