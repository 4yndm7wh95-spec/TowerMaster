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
    public sealed class Player(ulong id) { public ulong NetId { get; } = id; }
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
