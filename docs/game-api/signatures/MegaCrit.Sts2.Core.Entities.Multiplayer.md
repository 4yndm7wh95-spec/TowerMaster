# MegaCrit.Sts2.Core.Entities.Multiplayer

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Entities.Multiplayer.ActionSynchronizerCombatState

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.ActionSynchronizerCombatState EndTurnPhaseOne = 3
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.ActionSynchronizerCombatState NotInCombat = 0
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.ActionSynchronizerCombatState NotPlayPhase = 4
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.ActionSynchronizerCombatState PlayPhase = 2
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.ActionSynchronizerCombatState PreCombatSetup = 1
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Entities.Multiplayer.ConnectionFailureExtraInfo

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：`System.IEquatable<MegaCrit.Sts2.Core.Entities.Multiplayer.ConnectionFailureExtraInfo>`

```text
public MegaCrit.Sts2.Core.Multiplayer.PeerVersionInfo localInfo
public System.Boolean localIsHost
public MegaCrit.Sts2.Core.Multiplayer.PeerVersionInfo remoteInfo
System.Type EqualityContract { protected virtual get; }
protected .ctor(MegaCrit.Sts2.Core.Entities.Multiplayer.ConnectionFailureExtraInfo original)
public .ctor()
protected virtual System.Boolean PrintMembers(System.Text.StringBuilder builder)
protected virtual System.Type get_EqualityContract()
public static System.Boolean op_Equality(MegaCrit.Sts2.Core.Entities.Multiplayer.ConnectionFailureExtraInfo left, MegaCrit.Sts2.Core.Entities.Multiplayer.ConnectionFailureExtraInfo right)
public static System.Boolean op_Inequality(MegaCrit.Sts2.Core.Entities.Multiplayer.ConnectionFailureExtraInfo left, MegaCrit.Sts2.Core.Entities.Multiplayer.ConnectionFailureExtraInfo right)
public System.Collections.Generic.List<System.String> GetMissingModsOnLocal(System.Boolean nonGameplay)
public System.Collections.Generic.List<System.String> GetMissingModsOnRemote(System.Boolean nonGameplay)
public virtual MegaCrit.Sts2.Core.Entities.Multiplayer.ConnectionFailureExtraInfo <Clone>$()
public virtual System.Boolean Equals(MegaCrit.Sts2.Core.Entities.Multiplayer.ConnectionFailureExtraInfo other)
public virtual System.Boolean Equals(System.Object obj)
public virtual System.Int32 GetHashCode()
public virtual System.String ToString()
```

## MegaCrit.Sts2.Core.Entities.Multiplayer.ConnectionFailureReason

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.ConnectionFailureReason HandshakeTimeout = 6
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.ConnectionFailureReason LobbyFull = 1
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.ConnectionFailureReason ModMismatch = 5
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.ConnectionFailureReason None = 0
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.ConnectionFailureReason NotInSaveGame = 2
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.ConnectionFailureReason RunInProgress = 3
public System.Int32 value__
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.ConnectionFailureReason VersionMismatch = 4
```

## MegaCrit.Sts2.Core.Entities.Multiplayer.GameActionType

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.GameActionType Any = 4
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.GameActionType Combat = 1
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.GameActionType CombatPlayPhaseOnly = 2
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.GameActionType NonCombat = 3
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.GameActionType None = 0
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Entities.Multiplayer.LoadRunLobbyPlayer

类型属性：`Public, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`MegaCrit.Sts2.Core.Multiplayer.Serialization.IPacketSerializable`

```text
public System.UInt64 id
public System.Boolean isModded
public System.Boolean isReady
public virtual System.String ToString()
public virtual System.Void Deserialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketReader reader)
public virtual System.Void Serialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketWriter writer)
```

## MegaCrit.Sts2.Core.Entities.Multiplayer.NetChecksumData

类型属性：`Public, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`MegaCrit.Sts2.Core.Multiplayer.Serialization.IPacketSerializable`

```text
public System.UInt32 checksum
public System.UInt32 id
public virtual System.Void Deserialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketReader reader)
public virtual System.Void Serialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketWriter writer)
```

## MegaCrit.Sts2.Core.Entities.Multiplayer.NetClientData

类型属性：`Public, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：

```text
public System.UInt64 peerId
public System.Boolean readyForBroadcasting
public MegaCrit.Sts2.Core.Multiplayer.PeerVersionInfo versionInfo
```

## MegaCrit.Sts2.Core.Entities.Multiplayer.NetCombatCard

类型属性：`Public, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`MegaCrit.Sts2.Core.Multiplayer.Serialization.IPacketSerializable`, `System.IEquatable<MegaCrit.Sts2.Core.Entities.Multiplayer.NetCombatCard>`

```text
private System.UInt32 <CombatCardIndex>k__BackingField
System.UInt32 CombatCardIndex { public get; private set; }
private System.Void set_CombatCardIndex(System.UInt32 value)
public MegaCrit.Sts2.Core.Models.CardModel ToCardModel()
public MegaCrit.Sts2.Core.Models.CardModel ToCardModelOrNull()
public static MegaCrit.Sts2.Core.Entities.Multiplayer.NetCombatCard ForTesting(System.UInt32 index)
public static MegaCrit.Sts2.Core.Entities.Multiplayer.NetCombatCard FromModel(MegaCrit.Sts2.Core.Models.CardModel card)
public static System.Boolean op_Equality(MegaCrit.Sts2.Core.Entities.Multiplayer.NetCombatCard c1, MegaCrit.Sts2.Core.Entities.Multiplayer.NetCombatCard c2)
public static System.Boolean op_Inequality(MegaCrit.Sts2.Core.Entities.Multiplayer.NetCombatCard c1, MegaCrit.Sts2.Core.Entities.Multiplayer.NetCombatCard c2)
public System.UInt32 get_CombatCardIndex()
public virtual System.Boolean Equals(MegaCrit.Sts2.Core.Entities.Multiplayer.NetCombatCard other)
public virtual System.Boolean Equals(System.Object obj)
public virtual System.Int32 GetHashCode()
public virtual System.String ToString()
public virtual System.Void Deserialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketReader reader)
public virtual System.Void Serialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketWriter writer)
```

## MegaCrit.Sts2.Core.Entities.Multiplayer.NetDeckCard

类型属性：`Public, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`MegaCrit.Sts2.Core.Multiplayer.Serialization.IPacketSerializable`

```text
private System.UInt32 <DeckIndex>k__BackingField
System.UInt32 DeckIndex { public get; private set; }
private System.Void set_DeckIndex(System.UInt32 value)
public MegaCrit.Sts2.Core.Models.CardModel ToCardModel(MegaCrit.Sts2.Core.Entities.Players.Player player)
public static MegaCrit.Sts2.Core.Entities.Multiplayer.NetDeckCard FromModel(MegaCrit.Sts2.Core.Models.CardModel card)
public System.UInt32 get_DeckIndex()
public virtual System.String ToString()
public virtual System.Void Deserialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketReader reader)
public virtual System.Void Serialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketWriter writer)
```

## MegaCrit.Sts2.Core.Entities.Multiplayer.NetError

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.NetError CancelledJoin = 6
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.NetError FailedToHost = 206
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.NetError HandshakeTimeout = 106
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.NetError HostAbandoned = 3
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.NetError InternalError = 202
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.NetError InvalidHandshake = 108
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.NetError InvalidJoin = 5
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.NetError JoinBlockedByUser = 104
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.NetError Kicked = 4
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.NetError LobbyFull = 100
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.NetError LobbyJoinTimeout = 109
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.NetError ModMismatch = 107
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.NetError NoInternet = 200
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.NetError None = 0
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.NetError NotInSaveGame = 102
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.NetError Quit = 1
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.NetError QuitGameOver = 2
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.NetError RateLimited = 204
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.NetError RunInProgress = 101
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.NetError SecureConnectionFailed = 207
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.NetError StateDivergence = 105
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.NetError Timeout = 201
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.NetError TryAgainLater = 205
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.NetError UnknownNetworkError = 203
public System.Int32 value__
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.NetError VersionMismatch = 103
```

## MegaCrit.Sts2.Core.Entities.Multiplayer.NetErrorInfo

类型属性：`Public, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：

```text
private readonly System.Nullable<MegaCrit.Sts2.Core.Entities.Multiplayer.ConnectionFailureReason> _connectionReason
private readonly System.String _debugReason
private readonly System.Nullable<Godot.Error> _godotError
private readonly System.Nullable<Steamworks.EResult> _lobbyCreationResult
private readonly System.Nullable<Steamworks.EChatRoomEnterResponse> _lobbyEnterResponse
private readonly System.Nullable<MegaCrit.Sts2.Core.Entities.Multiplayer.NetError> _reason
private readonly System.Nullable<MegaCrit.Sts2.Core.Platform.Steam.SteamDisconnectionReason> _steamReason
private readonly MegaCrit.Sts2.Core.Entities.Multiplayer.ConnectionFailureExtraInfo <ConnectionExtraInfo>k__BackingField
private System.Boolean <IsModded>k__BackingField
private readonly System.Boolean <SelfInitiated>k__BackingField
MegaCrit.Sts2.Core.Entities.Multiplayer.ConnectionFailureExtraInfo ConnectionExtraInfo { public get; }
System.Boolean IsModded { public get; private set; }
System.Boolean SelfInitiated { public get; }
public .ctor(Godot.Error error)
public .ctor(MegaCrit.Sts2.Core.Entities.Multiplayer.ConnectionFailureReason reason, MegaCrit.Sts2.Core.Entities.Multiplayer.ConnectionFailureExtraInfo extraInfo = null)
public .ctor(MegaCrit.Sts2.Core.Entities.Multiplayer.NetError reason, System.Boolean selfInitiated)
public .ctor(MegaCrit.Sts2.Core.Platform.Steam.SteamDisconnectionReason steamReason, System.String debugReason, System.Boolean selfInitiated)
public .ctor(Steamworks.EChatRoomEnterResponse lobbyEnterResponse)
public .ctor(Steamworks.EResult lobbyCreationResult)
private System.Void set_IsModded(System.Boolean value)
public MegaCrit.Sts2.Core.Entities.Multiplayer.ConnectionFailureExtraInfo get_ConnectionExtraInfo()
public MegaCrit.Sts2.Core.Entities.Multiplayer.NetError GetReason()
public System.Boolean get_IsModded()
public System.Boolean get_SelfInitiated()
public System.String GetErrorString()
public System.Void SetModdedFlagIfModded(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.RunLobby runLobby)
public virtual System.String ToString()
```

## MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：`MegaCrit.Sts2.Core.Multiplayer.Serialization.IPacketSerializable`

```text
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState+CreatureState> <Creatures>k__BackingField
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState+PlayerState> <Players>k__BackingField
private MegaCrit.Sts2.Core.Saves.Runs.SerializableRunRngSet <Rng>k__BackingField
public System.Nullable<System.UInt32> lastExecutedActionId
public System.Nullable<System.UInt32> lastExecutedHookId
public System.Collections.Generic.List<System.UInt32> nextChoiceIds
public System.Collections.Generic.List<System.Int32> nextRewardIds
System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState+CreatureState> Creatures { public get; private set; }
System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState+PlayerState> Players { public get; private set; }
MegaCrit.Sts2.Core.Saves.Runs.SerializableRunRngSet Rng { public get; private set; }
public .ctor()
private System.Void set_Creatures(System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState+CreatureState> value)
private System.Void set_Players(System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState+PlayerState> value)
private System.Void set_Rng(MegaCrit.Sts2.Core.Saves.Runs.SerializableRunRngSet value)
public MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState Anonymized()
public MegaCrit.Sts2.Core.Saves.Runs.SerializableRunRngSet get_Rng()
public static MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState FromRun(MegaCrit.Sts2.Core.Runs.IRunState runState, MegaCrit.Sts2.Core.GameActions.GameAction justFinishedAction)
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState+CreatureState> get_Creatures()
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState+PlayerState> get_Players()
public virtual System.String ToString()
public virtual System.Void Deserialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketReader reader)
public virtual System.Void Serialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketWriter writer)
```

## MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState+CreatureState, MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState+CreatureState> <>9__27_0
public static System.Func<MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState+PlayerState, MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState+PlayerState> <>9__27_1
public static System.Func<MegaCrit.Sts2.Core.Models.ModelId, System.String> <>9__28_0
private static .cctor()
public .ctor()
internal MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState+CreatureState <Anonymized>b__27_0(MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState+CreatureState c)
internal MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState+PlayerState <Anonymized>b__27_1(MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState+PlayerState p)
internal System.String <ToString>b__28_0(MegaCrit.Sts2.Core.Models.ModelId m)
```

## MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState+<>O

类型属性：`NestedPrivate, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static System.Func<MegaCrit.Sts2.Core.Models.OrbModel, MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState+OrbState> <0>__From
```

## MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState+CardState

类型属性：`NestedPublic, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`MegaCrit.Sts2.Core.Multiplayer.Serialization.IPacketSerializable`

```text
public MegaCrit.Sts2.Core.Models.ModelId affliction
public System.Int32 afflictionCount
public MegaCrit.Sts2.Core.Saves.Runs.SerializableCard card
public System.Nullable<System.Int32> energyCost
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Cards.CardKeyword> keywords
public static MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState+CardState From(MegaCrit.Sts2.Core.Models.CardModel card)
public virtual System.Void Deserialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketReader reader)
public virtual System.Void Serialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketWriter writer)
```

## MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState+CombatPileState

类型属性：`NestedPublic, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`MegaCrit.Sts2.Core.Multiplayer.Serialization.IPacketSerializable`

```text
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState+CardState> cards
public MegaCrit.Sts2.Core.Entities.Cards.PileType pileType
public static MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState+CombatPileState From(MegaCrit.Sts2.Core.Entities.Cards.CardPile pile)
public virtual System.Void Deserialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketReader reader)
public virtual System.Void Serialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketWriter writer)
```

## MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState+CreatureState

类型属性：`NestedPublic, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`MegaCrit.Sts2.Core.Multiplayer.Serialization.IPacketSerializable`

```text
public System.Int32 block
public System.Int32 currentHp
public System.Int32 maxHp
public MegaCrit.Sts2.Core.Models.ModelId monsterId
public System.Nullable<System.UInt64> playerId
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState+PowerState> powers
public MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState+CreatureState Anonymized()
public virtual System.Void Deserialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketReader reader)
public virtual System.Void Serialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketWriter writer)
```

## MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState+OrbState

类型属性：`NestedPublic, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`MegaCrit.Sts2.Core.Multiplayer.Serialization.IPacketSerializable`

```text
public System.Int32 evoke
public MegaCrit.Sts2.Core.Models.ModelId id
public System.Int32 passive
public static MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState+OrbState From(MegaCrit.Sts2.Core.Models.OrbModel orb)
public virtual System.Void Deserialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketReader reader)
public virtual System.Void Serialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketWriter writer)
```

## MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState+PlayerState

类型属性：`NestedPublic, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`MegaCrit.Sts2.Core.Multiplayer.Serialization.IPacketSerializable`

```text
public MegaCrit.Sts2.Core.Models.ModelId characterId
public System.Int32 energy
public System.Int32 gold
public System.Int32 maxPotionCount
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState+OrbState> orbs
public MegaCrit.Sts2.Core.Combat.PlayerTurnPhase phase
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState+CombatPileState> piles
public System.UInt64 playerId
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState+PotionState> potions
public MegaCrit.Sts2.Core.Saves.Runs.SerializableRelicGrabBag relicGrabBag
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState+RelicState> relics
public MegaCrit.Sts2.Core.Saves.SerializablePlayerRngSet rngSet
public System.Int32 stars
public System.Int32 turnNumber
public MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState+PlayerState Anonymized()
public virtual System.Void Deserialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketReader reader)
public virtual System.Void Serialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketWriter writer)
```

## MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState+PotionState

类型属性：`NestedPublic, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`MegaCrit.Sts2.Core.Multiplayer.Serialization.IPacketSerializable`

```text
public MegaCrit.Sts2.Core.Models.ModelId id
public virtual System.Void Deserialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketReader reader)
public virtual System.Void Serialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketWriter writer)
```

## MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState+PowerState

类型属性：`NestedPublic, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`MegaCrit.Sts2.Core.Multiplayer.Serialization.IPacketSerializable`

```text
public System.Int32 amount
public MegaCrit.Sts2.Core.Models.ModelId id
public virtual System.Void Deserialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketReader reader)
public virtual System.Void Serialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketWriter writer)
```

## MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState+RelicState

类型属性：`NestedPublic, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`MegaCrit.Sts2.Core.Multiplayer.Serialization.IPacketSerializable`

```text
public MegaCrit.Sts2.Core.Saves.Runs.SerializableRelic relic
public virtual System.Void Deserialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketReader reader)
public virtual System.Void Serialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketWriter writer)
```

## MegaCrit.Sts2.Core.Entities.Multiplayer.NetPlayerChoiceResult

类型属性：`Public, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`MegaCrit.Sts2.Core.Multiplayer.Serialization.IPacketSerializable`

```text
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.CardModel> canonicalCards
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Multiplayer.NetCombatCard> combatCards
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Multiplayer.NetDeckCard> deckCards
public System.Collections.Generic.List<System.Int32> indexes
public System.Nullable<System.UInt64> mutableCardOwner
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Saves.Runs.SerializableCard> mutableCards
public System.Nullable<System.UInt64> playerId
public MegaCrit.Sts2.Core.Entities.Models.PlayerChoiceType type
public virtual System.String ToString()
public virtual System.Void Deserialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketReader reader)
public virtual System.Void Serialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketWriter writer)
```

## MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType CardPile = 6
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType CardSelection = 8
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType Compendium = 4
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType DeckView = 5
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType Feedback = 12
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType GameOver = 9
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType Map = 2
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType None = 0
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType PauseMenu = 10
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType RemotePlayerExpandedState = 14
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType Rewards = 11
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType Room = 1
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType Settings = 3
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType SharedRelicPicking = 13
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType SimpleCardsView = 7
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenTypeExtensions

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static Godot.Texture2D GetLocationIcon(MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType screenType)
```

## MegaCrit.Sts2.Core.Entities.Multiplayer.PlayerChoiceOptions

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.PlayerChoiceOptions CancelPlayCardActions = 1
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.PlayerChoiceOptions None = 0
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Entities.Multiplayer.ReactionType

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.ReactionType Exclamation = 1
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.ReactionType HappyCultist = 8
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.ReactionType Heart = 6
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.ReactionType None = 0
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.ReactionType QuestionMark = 5
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.ReactionType SadSlime = 4
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.ReactionType Skull = 2
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.ReactionType ThumbDown = 3
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.ReactionType ThumbUp = 7
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Entities.Multiplayer.RunLobbyPlayer

类型属性：`Public, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`MegaCrit.Sts2.Core.Multiplayer.Serialization.IPacketSerializable`

```text
public System.UInt64 id
public System.Boolean isModded
public virtual System.Void Deserialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketReader reader)
public virtual System.Void Serialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketWriter writer)
```

## MegaCrit.Sts2.Core.Entities.Multiplayer.RunSessionState

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.RunSessionState InLoadedLobby = 2
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.RunSessionState InLobby = 1
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.RunSessionState None = 0
public static const MegaCrit.Sts2.Core.Entities.Multiplayer.RunSessionState Running = 3
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Entities.Multiplayer.StartRunLobbyPlayer

类型属性：`Public, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`MegaCrit.Sts2.Core.Multiplayer.Serialization.IPacketSerializable`

```text
public MegaCrit.Sts2.Core.Models.CharacterModel character
public System.UInt64 id
public System.Boolean isModded
public System.Boolean isReady
public System.Int32 maxMultiplayerAscensionUnlocked
public System.Int32 slotId
public MegaCrit.Sts2.Core.Unlocks.SerializableUnlockState unlockState
public virtual System.String ToString()
public virtual System.Void Deserialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketReader reader)
public virtual System.Void Serialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketWriter writer)
```
