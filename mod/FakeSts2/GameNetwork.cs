using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.GameActions;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Entities.Multiplayer
{
    public enum GameActionType { None, Combat, CombatPlayPhaseOnly, NonCombat, Any }
    public enum NetGameType { Singleplayer, Host, Client }
}
namespace MegaCrit.Sts2.Core.Entities.Players
{
    public sealed class Player
    {
        public Player(ulong id) { NetId = id; Creature = new MegaCrit.Sts2.Core.Entities.Creatures.Creature(80) { Player = this }; }
        public ulong NetId { get; }
        public MegaCrit.Sts2.Core.Entities.Creatures.Creature Creature { get; }
    }
}
namespace MegaCrit.Sts2.Core.Multiplayer.Serialization
{
    public interface IPacketSerializable { void Serialize(PacketWriter writer); void Deserialize(PacketReader reader); }
    public sealed class PacketWriter
    {
        public string Text { get; private set; } = "";
        public void WriteString(string text) => Text = text;
    }
    public sealed class PacketReader(string text) { public string ReadString() => text; }
}
namespace MegaCrit.Sts2.Core.GameActions.Multiplayer
{
    public interface INetAction : MegaCrit.Sts2.Core.Multiplayer.Serialization.IPacketSerializable
    {
        GameAction ToGameAction(MegaCrit.Sts2.Core.Entities.Players.Player player);
    }
    public sealed class ActionQueueSynchronizer(MegaCrit.Sts2.Core.Runs.FakeService service)
    {
        private readonly MegaCrit.Sts2.Core.Runs.FakeService _netService = service;
        public List<GameAction> Queued { get; } = new();
        [MethodImpl(MethodImplOptions.NoInlining)]
        public void RequestEnqueue(GameAction action) => Queued.Add(action);
    }
}
namespace MegaCrit.Sts2.Core.GameActions
{
    public abstract class GameAction
    {
        // 真游戏的静态日志字段使基类同时具有静态和实例构造，覆盖反射歧义回归。
        static GameAction() { }

        public abstract ulong OwnerId { get; }
        public abstract MegaCrit.Sts2.Core.Entities.Multiplayer.GameActionType ActionType { get; }
        protected abstract Task ExecuteAction();
        public abstract INetAction ToNetAction();
        public Task Execute() => ExecuteAction();
    }
    public sealed class MoveToMapCoordAction(ulong owner) : GameAction
    {
        public override ulong OwnerId => owner;
        public override MegaCrit.Sts2.Core.Entities.Multiplayer.GameActionType ActionType => MegaCrit.Sts2.Core.Entities.Multiplayer.GameActionType.NonCombat;
        protected override Task ExecuteAction() => Task.CompletedTask;
        public override INetAction ToNetAction() => throw new NotSupportedException();
    }
}
namespace MegaCrit.Sts2.Core.Helpers
{
    public static class ReflectionHelper
    {
        public static Type[] ModTypes
        {
            [MethodImpl(MethodImplOptions.NoInlining)]
            get => [];
        }
    }
}
namespace MegaCrit.Sts2.Core.Runs
{
    public sealed class FakeService
    {
        public MegaCrit.Sts2.Core.Entities.Multiplayer.NetGameType Type { get; set; } = MegaCrit.Sts2.Core.Entities.Multiplayer.NetGameType.Host;
        public ulong NetId { get; set; } = 100001;
        public ulong HostNetId { get; set; } = 100001;
    }
    public sealed class RunManager
    {
        public static RunManager Instance { get; } = new();
        public RunState State { get; set; } = new();
        public FakeService NetService { get; set; } = new();
    }
}
namespace MegaCrit.Sts2.Core.Modding
{
    public sealed class ModManifest { public string? id { get; init; } public string? name { get; init; } }
    public sealed class Mod { public ModManifest? manifest { get; init; } public System.Reflection.Assembly? assembly { get; set; } }

    /// <summary>仿造：游戏按程序集查 mod，动态程序集要手动登记。</summary>
    public static class ModManager
    {
        private static readonly List<Mod> _loadedMods =
        [
            new() { manifest = new() { id = "DirectConnectIP", name = "IP直连" } },
            new() { manifest = new() { id = "TowerMaster", name = "塔主" } },
        ];
        public static Dictionary<System.Reflection.Assembly, Mod> AssemblyToMod { get; } = new();
        public static IReadOnlyList<Mod> LoadedMods => _loadedMods;

        public static void AssociateAssemblyWithMod(System.Reflection.Assembly assembly, Mod mod) => AssemblyToMod[assembly] = mod;
    }
}
