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
        [MethodImpl(MethodImplOptions.NoInlining)]
        public void ReviveBeforeCombatEnd() => Creature.Revive();
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
    public sealed class MoveToMapCoordAction(ulong owner, MegaCrit.Sts2.Core.Map.MapCoord destination = default) : GameAction
    {
        private readonly MegaCrit.Sts2.Core.Map.MapCoord _destination = destination;
        public MegaCrit.Sts2.Core.Map.MapCoord Destination => _destination;
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
        public MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSynchronizer? ActionQueueSynchronizer { get; set; }
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
namespace MegaCrit.Sts2.Core.Map
{
    public sealed record MapLocation(int Row, int Col);
    public readonly record struct MapCoord(int col, int row);
    public enum MapPointType { Unassigned, Unknown, Shop, Treasure, RestSite, Monster, Elite, Boss, Ancient }
    public sealed class MapPoint(MapPointType type) { public MapPointType PointType { get; set; } = type; }
    public sealed class ActMap
    {
        public Dictionary<MapCoord, MapPoint> Points { get; } = new();
        public MapPoint GetPoint(MapCoord coord) => Points.TryGetValue(coord, out var p) ? p : new MapPoint(MapPointType.Monster);
    }
    public readonly record struct MapVote(int Row, int Col);
}
namespace MegaCrit.Sts2.Core.GameActions
{
    public sealed class VoteForMapCoordAction(
        MegaCrit.Sts2.Core.Entities.Players.Player player,
        MegaCrit.Sts2.Core.Map.MapLocation source,
        MegaCrit.Sts2.Core.Map.MapVote? destination) : GameAction
    {
        public MegaCrit.Sts2.Core.Entities.Players.Player Player { get; } = player;
        public override ulong OwnerId => Player.NetId;
        public override MegaCrit.Sts2.Core.Entities.Multiplayer.GameActionType ActionType => MegaCrit.Sts2.Core.Entities.Multiplayer.GameActionType.NonCombat;
        protected override Task ExecuteAction()
        {
            MegaCrit.Sts2.Core.Multiplayer.Game.MapSelectionSynchronizer.Instance.PlayerVotedForMapCoord(Player, source, destination);
            return Task.CompletedTask;
        }
        public override INetAction ToNetAction() => throw new NotSupportedException();
    }
}
namespace MegaCrit.Sts2.Core.Multiplayer.Game
{
    using MegaCrit.Sts2.Core.Entities.Players;

    public sealed class MapSelectionSynchronizer
    {
        public static MapSelectionSynchronizer Instance { get; set; } = new();
        public Dictionary<ulong, MegaCrit.Sts2.Core.Map.MapVote?> Votes { get; } = new();

        [MethodImpl(MethodImplOptions.NoInlining)]
        public void PlayerVotedForMapCoord(Player player, MegaCrit.Sts2.Core.Map.MapLocation source, MegaCrit.Sts2.Core.Map.MapVote? destination) =>
            Votes[player.NetId] = destination;
    }

    public sealed class RewardsSetSynchronizer
    {
        public int Skipped { get; private set; }
        /// <summary>仿造实测：奖励集合还没显示时，游戏拒绝跳过。</summary>
        public bool Viewing { get; set; } = true;
        [MethodImpl(MethodImplOptions.NoInlining)]
        public Task BeginRewardsSet(object set) => Task.CompletedTask;
        public void SkipLocalRewardsSet()
        {
            if (!Viewing) throw new InvalidOperationException("Tried to skip reward set for player 100001, but they are not currently viewing any reward set!");
            Skipped++;
        }
        [MethodImpl(MethodImplOptions.NoInlining)]
        public Task<bool> SelectLocalReward(object reward) => Task.FromResult(true);
    }

    public sealed class OneOffSynchronizer
    {
        [MethodImpl(MethodImplOptions.NoInlining)]
        public Task<bool> DoLocalMerchantCardRemoval(int goldCost, bool cancelable = true) => Task.FromResult(true);
        [MethodImpl(MethodImplOptions.NoInlining)]
        public Task<int> DoLocalTreasureRoomRewards() => Task.FromResult(42);
    }

    public sealed class TreasureRoomRelicSynchronizer
    {
        public int Skipped { get; private set; }
        [MethodImpl(MethodImplOptions.NoInlining)]
        public void BeginRelicPicking() { }
        public void SkipRelicLocally() => Skipped++;
        public List<int?> Picks { get; } = new();
        [MethodImpl(MethodImplOptions.NoInlining)]
        public void PickRelicLocally(int? index) => Picks.Add(index);
    }

    public sealed class EventSynchronizer
    {
        public List<int> LocalChoices { get; } = new();
        [MethodImpl(MethodImplOptions.NoInlining)]
        public void PlayerVotedForSharedOptionIndex(Player player, uint optionIndex, uint pageIndex) { }
        public void ChooseLocalOption(int index) => LocalChoices.Add(index);
    }

    public sealed class RestSiteSynchronizer
    {
        public int Skipped { get; private set; }
        [MethodImpl(MethodImplOptions.NoInlining)]
        public void BeginRestSite() { }
        public void BeforeLocalRestSiteExited() => Skipped++;
    }

    public sealed class ActChangeSynchronizer
    {
        public int LocalReady { get; private set; }
        [MethodImpl(MethodImplOptions.NoInlining)]
        public void OnPlayerReady(Player player, int actIndex) { }
        public void SetLocalPlayerReady() => LocalReady++;
    }
}

namespace MegaCrit.Sts2.Core.Entities.Merchant
{
    public sealed class MerchantEntry
    {
        [MethodImpl(MethodImplOptions.NoInlining)]
        public Task<bool> OnTryPurchaseWrapper(object? inventory, bool ignoreCost = false) => Task.FromResult(true);
    }
}
namespace MegaCrit.Sts2.Core.Nodes.Screens.Map
{
    public sealed class NMapScreen
    {
        public int Selected { get; private set; }
        [MethodImpl(MethodImplOptions.NoInlining)]
        public void OnMapPointSelectedLocally(object point) => Selected++;
    }
}

namespace MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic
{
    /// <summary>仿造实测：塔主跳过后只摆一个遗物槽，座位号 1 的玩家取默认焦点越界。</summary>
    public sealed class NTreasureRoomRelicCollection
    {
        private readonly List<Godot.Control> _holdersInUse = new();
        public int LocalSlot { get; set; } = 1;
        public Godot.Control? SingleplayerRelicHolder => null;
        public Godot.Control DefaultFocusedControl
        {
            [MethodImpl(MethodImplOptions.NoInlining)]
            get => _holdersInUse[LocalSlot];
        }
    }

    public sealed class NHandImageCollection
    {
        [MethodImpl(MethodImplOptions.NoInlining)]
        public void _Input(object inputEvent)
        {
            ulong? netId = null;
            _ = netId!.Value; // 退出后本地身份为空
        }
    }
}
namespace MegaCrit.Sts2.Core.Nodes.Rooms
{
    /// <summary>仿造宝箱房间节点：点开宝箱时为所有玩家建额外奖励集合（这里只计数）。</summary>
    public sealed class NTreasureRoom
    {
        private bool _hasChestBeenOpened;
        public int Opened { get; private set; }
        [MethodImpl(MethodImplOptions.NoInlining)]
        public void _Ready() { }
        private void OnChestButtonReleased(object? _)
        {
            if (_hasChestBeenOpened) return;
            _hasChestBeenOpened = true;
            Opened++;
        }
        public void ClickChest() => OnChestButtonReleased(null);
    }
}
