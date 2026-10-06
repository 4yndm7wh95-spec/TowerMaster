using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Models
{
    public abstract class AbstractModel
    {
        public bool IsMutable { get; private set; }

        public AbstractModel ToMutable()
        {
            var copy = (AbstractModel)MemberwiseClone();
            copy.IsMutable = true;
            return copy;
        }
    }

    public abstract class EncounterModel : AbstractModel
    {
        public IReadOnlyList<(string Monster, string? Slot)> MonstersWithSlots { get; private set; } = [];

        protected abstract List<(string, string?)> Lineup();

        [MethodImpl(MethodImplOptions.NoInlining)]
        public void GenerateMonstersWithSlots(int seed)
        {
            if (!IsMutable) throw new InvalidOperationException("规范模型不能生成怪物");
            MonstersWithSlots = Lineup();
        }
    }

    public static class ModelDb
    {
        private static readonly Dictionary<Type, object> Cache = new();

        public static T Encounter<T>() where T : EncounterModel, new()
        {
            if (!Cache.TryGetValue(typeof(T), out var model)) Cache[typeof(T)] = model = new T();
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

namespace MegaCrit.Sts2.Core.Rooms
{
    public sealed class CombatRoom(EncounterModel encounter)
    {
        public EncounterModel Encounter { get; } = encounter;

        [MethodImpl(MethodImplOptions.NoInlining)]
        public void StartCombat() => Encounter.GenerateMonstersWithSlots(seed: 1);
    }
}
