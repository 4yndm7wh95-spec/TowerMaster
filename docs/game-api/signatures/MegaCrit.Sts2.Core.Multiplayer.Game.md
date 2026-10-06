# MegaCrit.Sts2.Core.Multiplayer.Game

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Multiplayer.Game.ActChangeSynchronizer

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private System.Int32 _lastTransitioningActIndex
private readonly MegaCrit.Sts2.Core.Logging.Logger _logger
private readonly System.Collections.Generic.List<System.Boolean> _readyPlayers
private readonly MegaCrit.Sts2.Core.Runs.RunState _runState
public .ctor(MegaCrit.Sts2.Core.Runs.RunState runState)
private System.Void MoveToNextAct()
public System.Boolean IsWaitingForOtherPlayers()
public System.Void OnPlayerReady(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Int32 actIndex)
public System.Void SetLocalPlayerReady()
```

## MegaCrit.Sts2.Core.Multiplayer.Game.ActChangeSynchronizer+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Multiplayer.Game.ActChangeSynchronizer+<>c <>9
public static System.Func<System.Boolean, System.Boolean> <>9__7_0
private static .cctor()
public .ctor()
internal System.Boolean <OnPlayerReady>b__7_0(System.Boolean x)
```

## MegaCrit.Sts2.Core.Multiplayer.Game.ChecksumTracker

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：`System.IDisposable`

```text
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Multiplayer.Game.ChecksumTracker+TrackedChecksum> _checksums
private static const System.Int32 _checksumsToSave = 20
private readonly MegaCrit.Sts2.Core.Logging.Logger _logger
private readonly MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService _netService
private readonly MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketWriter _packetWriter
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Multiplayer.Game.ChecksumTracker+QueuedRemoteChecksum> _queuedRemoteChecksums
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Multiplayer.Replay.ReplayChecksumData> _replayChecksums
private readonly MegaCrit.Sts2.Core.Runs.IRunState _runState
private System.Boolean <IsEnabled>k__BackingField
private System.UInt32 <NextId>k__BackingField
private System.Action<MegaCrit.Sts2.Core.Entities.Multiplayer.NetChecksumData, System.String, MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState> ChecksumGenerated
private System.Action<System.UInt64, MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState> StateDiverged
System.Boolean IsEnabled { public get; public set; }
System.UInt32 NextId { public get; private set; }
event System.Action<MegaCrit.Sts2.Core.Entities.Multiplayer.NetChecksumData, System.String, MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState> ChecksumGenerated
event System.Action<System.UInt64, MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState> StateDiverged
public .ctor(MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService netService, MegaCrit.Sts2.Core.Runs.IRunState runState)
private MegaCrit.Sts2.Core.Entities.Multiplayer.NetChecksumData ObtainAndTrackChecksum(System.String context, MegaCrit.Sts2.Core.GameActions.GameAction action)
private System.Void CheckAgainstReplayChecksum(MegaCrit.Sts2.Core.Entities.Multiplayer.NetChecksumData localData, System.String context)
private System.Void CompareChecksums(MegaCrit.Sts2.Core.Multiplayer.Game.ChecksumTracker+TrackedChecksum localChecksum, MegaCrit.Sts2.Core.Entities.Multiplayer.NetChecksumData remoteChecksum, System.UInt64 remoteId)
private System.Void LogStateDivergence(MegaCrit.Sts2.Core.Multiplayer.Game.ChecksumTracker+TrackedChecksum localChecksum, MegaCrit.Sts2.Core.Multiplayer.Messages.Game.Checksums.StateDivergenceMessage message, System.UInt64 remoteId, System.Int32 checksumIndex)
private System.Void OnReceivedChecksumDataMessage(MegaCrit.Sts2.Core.Multiplayer.Messages.Game.Checksums.ChecksumDataMessage message, System.UInt64 senderId)
private System.Void OnReceivedStateDivergenceMessage(MegaCrit.Sts2.Core.Multiplayer.Messages.Game.Checksums.StateDivergenceMessage message, System.UInt64 senderId)
private System.Void ReportDivergenceToSentry(MegaCrit.Sts2.Core.Multiplayer.Game.ChecksumTracker+TrackedChecksum localChecksum, MegaCrit.Sts2.Core.Multiplayer.Messages.Game.Checksums.StateDivergenceMessage message, System.UInt64 remoteId, System.Int32 checksumIndex)
private System.Void set_NextId(System.UInt32 value)
public MegaCrit.Sts2.Core.Entities.Multiplayer.NetChecksumData GenerateChecksum(System.String context, MegaCrit.Sts2.Core.GameActions.GameAction action)
public System.Boolean get_IsEnabled()
public System.UInt32 GenerateChecksum(MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState state)
public System.UInt32 get_NextId()
public System.Void add_ChecksumGenerated(System.Action<MegaCrit.Sts2.Core.Entities.Multiplayer.NetChecksumData, System.String, MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState> value)
public System.Void add_StateDiverged(System.Action<System.UInt64, MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState> value)
public System.Void LoadReplayChecksums(System.Collections.Generic.List<MegaCrit.Sts2.Core.Multiplayer.Replay.ReplayChecksumData> replayChecksums, System.UInt32 nextId)
public System.Void remove_ChecksumGenerated(System.Action<MegaCrit.Sts2.Core.Entities.Multiplayer.NetChecksumData, System.String, MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState> value)
public System.Void remove_StateDiverged(System.Action<System.UInt64, MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState> value)
public System.Void set_IsEnabled(System.Boolean value)
public virtual System.Void Dispose()
```

## MegaCrit.Sts2.Core.Multiplayer.Game.ChecksumTracker+<>c__DisplayClass27_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Entities.Multiplayer.NetChecksumData remoteChecksumData
public .ctor()
internal System.Boolean <OnReceivedChecksumDataMessage>b__0(MegaCrit.Sts2.Core.Multiplayer.Game.ChecksumTracker+TrackedChecksum c)
```

## MegaCrit.Sts2.Core.Multiplayer.Game.ChecksumTracker+<>c__DisplayClass28_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Entities.Multiplayer.NetChecksumData remoteChecksumData
public .ctor()
internal System.Boolean <OnReceivedStateDivergenceMessage>b__0(MegaCrit.Sts2.Core.Multiplayer.Game.ChecksumTracker+TrackedChecksum c)
```

## MegaCrit.Sts2.Core.Multiplayer.Game.ChecksumTracker+<>c__DisplayClass32_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Multiplayer.Game.ChecksumTracker <>4__this
public System.Int32 checksumIndex
public MegaCrit.Sts2.Core.Multiplayer.Game.ChecksumTracker+TrackedChecksum localChecksum
public System.String localState
public MegaCrit.Sts2.Core.Multiplayer.Messages.Game.Checksums.StateDivergenceMessage message
public System.UInt64 remoteId
public System.String remoteState
public System.String role
public .ctor()
internal System.Void <ReportDivergenceToSentry>b__0(Sentry.Scope scope)
```

## MegaCrit.Sts2.Core.Multiplayer.Game.ChecksumTracker+<>c__DisplayClass34_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Entities.Multiplayer.NetChecksumData localData
public .ctor()
internal System.Boolean <CheckAgainstReplayChecksum>b__0(MegaCrit.Sts2.Core.Multiplayer.Replay.ReplayChecksumData c)
internal System.Boolean <CheckAgainstReplayChecksum>b__1(MegaCrit.Sts2.Core.Multiplayer.Game.ChecksumTracker+TrackedChecksum c)
```

## MegaCrit.Sts2.Core.Multiplayer.Game.ChecksumTracker+QueuedRemoteChecksum

类型属性：`NestedPrivate, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：

```text
public MegaCrit.Sts2.Core.Entities.Multiplayer.NetChecksumData data
public System.UInt64 senderId
```

## MegaCrit.Sts2.Core.Multiplayer.Game.ChecksumTracker+TrackedChecksum

类型属性：`NestedPrivate, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：

```text
public System.String context
public MegaCrit.Sts2.Core.Entities.Multiplayer.NetChecksumData data
public System.String fingerprintContext
public MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState fullState
```

## MegaCrit.Sts2.Core.Multiplayer.Game.EventCombatSynchronizer

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private MegaCrit.Sts2.Core.Models.EventModel _canonicalEvent
private readonly MegaCrit.Sts2.Core.Logging.Logger _logger
private readonly MegaCrit.Sts2.Core.Runs.IRunState _runState
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Multiplayer.Game.EventCombatSynchronizer+EventCombatState> _states
private MegaCrit.Sts2.Core.Combat.CombatState <CombatStateForLayout>k__BackingField
private MegaCrit.Sts2.Core.Models.EncounterModel <MutableEncounterForLayout>k__BackingField
MegaCrit.Sts2.Core.Combat.CombatState CombatStateForLayout { public get; private set; }
MegaCrit.Sts2.Core.Models.EncounterModel MutableEncounterForLayout { public get; private set; }
public .ctor(MegaCrit.Sts2.Core.Runs.IPlayerCollection playerCollection, MegaCrit.Sts2.Core.Runs.IRunState runState)
private MegaCrit.Sts2.Core.Combat.CombatState CreateCombatState(MegaCrit.Sts2.Core.Models.EncounterModel mutableEncounter)
private System.Void EnterCombat()
private System.Void set_CombatStateForLayout(MegaCrit.Sts2.Core.Combat.CombatState value)
private System.Void set_MutableEncounterForLayout(MegaCrit.Sts2.Core.Models.EncounterModel value)
public MegaCrit.Sts2.Core.Combat.CombatState get_CombatStateForLayout()
public MegaCrit.Sts2.Core.Models.EncounterModel get_MutableEncounterForLayout()
public System.Void InitializeForEvent(MegaCrit.Sts2.Core.Models.EventModel localEvent)
public System.Void ReadyToEnterCombat(MegaCrit.Sts2.Core.Models.EncounterModel canonicalEncounter, MegaCrit.Sts2.Core.Entities.Players.Player player, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Rewards.Reward> extraRewards, System.Boolean shouldResumeAfterCombat)
public System.Void ResetState()
```

## MegaCrit.Sts2.Core.Multiplayer.Game.EventCombatSynchronizer+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Multiplayer.Game.EventCombatSynchronizer+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Multiplayer.Game.EventCombatSynchronizer+EventCombatState, System.Boolean> <>9__15_0
private static .cctor()
public .ctor()
internal System.Boolean <ReadyToEnterCombat>b__15_0(MegaCrit.Sts2.Core.Multiplayer.Game.EventCombatSynchronizer+EventCombatState s)
```

## MegaCrit.Sts2.Core.Multiplayer.Game.EventCombatSynchronizer+EventCombatState

类型属性：`NestedPrivate, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Models.EncounterModel canonicalEncounter
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Rewards.Reward> extraRewards
public System.Boolean shouldResumeAfterCombat
public .ctor()
```

## MegaCrit.Sts2.Core.Multiplayer.Game.EventSynchronizer

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Models.EventModel _canonicalEvent
private readonly MegaCrit.Sts2.Core.Multiplayer.Game.EventCombatSynchronizer _combatSynchronizer
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.EventModel> _events
private readonly System.UInt64 _localPlayerId
private readonly MegaCrit.Sts2.Core.Logging.Logger _logger
private readonly MegaCrit.Sts2.Core.Multiplayer.Game.RunLocationTargetedMessageBuffer _messageBuffer
private readonly MegaCrit.Sts2.Core.Random.Rng _multiplayerOptionSelectionRng
private readonly MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService _netService
private System.UInt32 _pageIndex
private readonly System.Collections.Generic.List<System.Threading.Tasks.Task> _pendingOptionTasks
private readonly MegaCrit.Sts2.Core.Runs.IPlayerCollection _playerCollection
private readonly System.Collections.Generic.List<System.Nullable<System.UInt32>> _playerVotes
private System.Action<MegaCrit.Sts2.Core.Entities.Players.Player> PlayerVoteChanged
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.EventModel> Events { public get; }
System.Boolean IsShared { public get; }
MegaCrit.Sts2.Core.Entities.Players.Player LocalPlayer { private get; }
event System.Action<MegaCrit.Sts2.Core.Entities.Players.Player> PlayerVoteChanged
public .ctor(MegaCrit.Sts2.Core.Multiplayer.Game.RunLocationTargetedMessageBuffer messageBuffer, MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService netService, MegaCrit.Sts2.Core.Runs.IPlayerCollection playerCollection, MegaCrit.Sts2.Core.Runs.IRunState runState, System.UInt64 localPlayerId, System.UInt64 seed)
private MegaCrit.Sts2.Core.Entities.Players.Player get_LocalPlayer()
private System.Void ChooseOptionForEvent(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Int32 optionIndex)
private System.Void ChooseOptionForSharedEvent(System.UInt32 optionIndex)
private System.Void ChooseSharedEventOption()
private System.Void ClearPlayerVotes()
private System.Void HandleEventOptionChosenMessage(MegaCrit.Sts2.Core.Multiplayer.Messages.Game.Sync.OptionIndexChosenMessage message, System.UInt64 senderId)
private System.Void HandleSharedEventOptionChosenMessage(MegaCrit.Sts2.Core.Multiplayer.Messages.Game.Sync.SharedEventOptionChosenMessage message, System.UInt64 senderId)
private System.Void HandleVotedForSharedEventOptionMessage(MegaCrit.Sts2.Core.Multiplayer.Messages.Game.Sync.VotedForSharedEventOptionMessage message, System.UInt64 senderId)
private System.Void PlayerVotedForSharedOptionIndex(MegaCrit.Sts2.Core.Entities.Players.Player player, System.UInt32 optionIndex, System.UInt32 pageIndex)
private System.Void SaveEventOptionToHistory(MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.Events.EventOption option)
public [async] System.Threading.Tasks.Task AwaitPendingOptionTasks()
public MegaCrit.Sts2.Core.Models.EventModel GetEventForPlayer(MegaCrit.Sts2.Core.Entities.Players.Player player)
public MegaCrit.Sts2.Core.Models.EventModel GetLocalEvent()
public System.Boolean get_IsShared()
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.EventModel> get_Events()
public System.Nullable<System.UInt32> GetPlayerVote(MegaCrit.Sts2.Core.Entities.Players.Player player)
public System.Void add_PlayerVoteChanged(System.Action<MegaCrit.Sts2.Core.Entities.Players.Player> value)
public System.Void BeforeExitingRoom()
public System.Void BeginEvent(MegaCrit.Sts2.Core.Models.EventModel canonicalEvent, System.Boolean isPrefinished = False, System.Action<MegaCrit.Sts2.Core.Models.EventModel> debugOnStart = null)
public System.Void ChooseLocalOption(System.Int32 index)
public System.Void GenerateInternalCombatStateIfNecessary(MegaCrit.Sts2.Core.Models.EventModel localEvent)
public System.Void remove_PlayerVoteChanged(System.Action<MegaCrit.Sts2.Core.Entities.Players.Player> value)
public System.Void ResumeEvents(MegaCrit.Sts2.Core.Rooms.AbstractRoom exitedRoom)
public virtual System.Void Dispose()
```

## MegaCrit.Sts2.Core.Multiplayer.Game.EventSynchronizer+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Multiplayer.Game.EventSynchronizer+<>c <>9
public static System.Func<System.Nullable<System.UInt32>, System.Boolean> <>9__25_0
private static .cctor()
public .ctor()
internal System.Boolean <PlayerVotedForSharedOptionIndex>b__25_0(System.Nullable<System.UInt32> p)
```

## MegaCrit.Sts2.Core.Multiplayer.Game.EventSynchronizer+<AwaitPendingOptionTasks>d__40

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Multiplayer.Game.EventSynchronizer <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Multiplayer.Game.FlavorSynchronizer

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：`System.IDisposable`

```text
private readonly System.Collections.Generic.Dictionary<MegaCrit.Sts2.Core.Entities.Players.Player, MegaCrit.Sts2.Core.Nodes.Vfx.NSpeechBubbleVfx> _endTurnPingDialogues
private readonly MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService _gameService
private readonly System.UInt64 _localPlayerId
private static const System.UInt64 _mapPingDebounceMsec = 200
private System.UInt64 _nextAllowedPingTime
private static const System.UInt64 _pingDebounceMsec = 1000
private readonly MegaCrit.Sts2.Core.Runs.IPlayerCollection _playerCollection
private System.Action<System.UInt64> OnEndTurnPingReceived
MegaCrit.Sts2.Core.Entities.Players.Player LocalPlayer { private get; }
event System.Action<System.UInt64> OnEndTurnPingReceived
public .ctor(MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService gameService, MegaCrit.Sts2.Core.Runs.IPlayerCollection playerCollection, System.UInt64 localPlayerId)
private MegaCrit.Sts2.Core.Entities.Players.Player get_LocalPlayer()
private System.Void CreateEndTurnPingDialogueIfNecessary(MegaCrit.Sts2.Core.Entities.Players.Player player)
private System.Void CreateMapPing(MegaCrit.Sts2.Core.Map.MapCoord coord, MegaCrit.Sts2.Core.Entities.Players.Player player)
private System.Void HandleEndTurnPingMessage(MegaCrit.Sts2.Core.Multiplayer.Messages.Game.Flavor.EndTurnPingMessage message, System.UInt64 senderId)
private System.Void HandleMapPingMessage(MegaCrit.Sts2.Core.Multiplayer.Messages.Game.Flavor.MapPingMessage message, System.UInt64 senderId)
public System.Void add_OnEndTurnPingReceived(System.Action<System.UInt64> value)
public System.Void remove_OnEndTurnPingReceived(System.Action<System.UInt64> value)
public System.Void SendEndTurnPing()
public System.Void SendMapPing(MegaCrit.Sts2.Core.Map.MapCoord coord)
public virtual System.Void Dispose()
```

## MegaCrit.Sts2.Core.Multiplayer.Game.INetClientGameService

类型属性：`Public, ClassSemanticsMask, Abstract, BeforeFieldInit`；基类：`无`。

接口：`MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService`, `MegaCrit.Sts2.Core.Multiplayer.Transport.INetClientHandler`, `MegaCrit.Sts2.Core.Multiplayer.Transport.INetHandler`

```text
MegaCrit.Sts2.Core.Multiplayer.Transport.NetClient NetClient { public abstract get; }
event System.Action<MegaCrit.Sts2.Core.Entities.Multiplayer.NetErrorInfo> ConnectionFailed
public abstract MegaCrit.Sts2.Core.Multiplayer.Transport.NetClient get_NetClient()
public abstract System.Void add_ConnectionFailed(System.Action<MegaCrit.Sts2.Core.Entities.Multiplayer.NetErrorInfo> value)
public abstract System.Void remove_ConnectionFailed(System.Action<MegaCrit.Sts2.Core.Entities.Multiplayer.NetErrorInfo> value)
```

## MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService

类型属性：`Public, ClassSemanticsMask, Abstract, BeforeFieldInit`；基类：`无`。

接口：

```text
System.Boolean IsConnected { public abstract get; }
System.Boolean IsGameLoading { public abstract get; }
MegaCrit.Sts2.Core.Multiplayer.PeerVersionInfo LocalVersion { public abstract get; }
System.UInt64 NetId { public abstract get; }
MegaCrit.Sts2.Core.Platform.PlatformType Platform { public abstract get; }
MegaCrit.Sts2.Core.Multiplayer.Game.NetGameType Type { public abstract get; }
event System.Action<MegaCrit.Sts2.Core.Entities.Multiplayer.NetErrorInfo> Disconnected
public abstract MegaCrit.Sts2.Core.Multiplayer.Game.NetGameType get_Type()
public abstract MegaCrit.Sts2.Core.Multiplayer.PeerVersionInfo get_LocalVersion()
public abstract MegaCrit.Sts2.Core.Multiplayer.Quality.ConnectionStats GetStatsForPeer(System.UInt64 peerId)
public abstract MegaCrit.Sts2.Core.Platform.PlatformType get_Platform()
public abstract System.Boolean get_IsConnected()
public abstract System.Boolean get_IsGameLoading()
public abstract System.String GetRawLobbyIdentifier()
public abstract System.UInt64 get_NetId()
public abstract System.Void add_Disconnected(System.Action<MegaCrit.Sts2.Core.Entities.Multiplayer.NetErrorInfo> value)
public abstract System.Void Disconnect(MegaCrit.Sts2.Core.Entities.Multiplayer.NetError reason, System.Boolean now = False)
public abstract System.Void RegisterMessageHandler<T>(MegaCrit.Sts2.Core.Multiplayer.Game.MessageHandlerDelegate<T> messageHandlerDelegate) where T: [None] MegaCrit.Sts2.Core.Multiplayer.Serialization.INetMessage
public abstract System.Void remove_Disconnected(System.Action<MegaCrit.Sts2.Core.Entities.Multiplayer.NetErrorInfo> value)
public abstract System.Void SendMessage<T>(T message, System.UInt64 playerId) where T: [None] MegaCrit.Sts2.Core.Multiplayer.Serialization.INetMessage
public abstract System.Void SendMessage<T>(T message) where T: [None] MegaCrit.Sts2.Core.Multiplayer.Serialization.INetMessage
public abstract System.Void SetBufferMessages(System.Boolean bufferMessages)
public abstract System.Void SetGameLoading(System.Boolean isLoading)
public abstract System.Void UnregisterMessageHandler<T>(MegaCrit.Sts2.Core.Multiplayer.Game.MessageHandlerDelegate<T> messageHandlerDelegate) where T: [None] MegaCrit.Sts2.Core.Multiplayer.Serialization.INetMessage
public abstract System.Void Update()
```

## MegaCrit.Sts2.Core.Multiplayer.Game.INetHostGameService

类型属性：`Public, ClassSemanticsMask, Abstract, BeforeFieldInit`；基类：`无`。

接口：`MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService`

```text
MegaCrit.Sts2.Core.Multiplayer.Transport.NetHost NetHost { public abstract get; }
event System.Action<System.UInt64> ClientConnected
event System.Action<System.UInt64, MegaCrit.Sts2.Core.Entities.Multiplayer.NetErrorInfo> ClientConnectionFailed
event System.Action<System.UInt64, MegaCrit.Sts2.Core.Entities.Multiplayer.NetErrorInfo> ClientDisconnected
public abstract MegaCrit.Sts2.Core.Multiplayer.Transport.NetHost get_NetHost()
public abstract System.Nullable<MegaCrit.Sts2.Core.Multiplayer.PeerVersionInfo> GetVersionInfoForPeer(System.UInt64 peerId)
public abstract System.Void add_ClientConnected(System.Action<System.UInt64> value)
public abstract System.Void add_ClientConnectionFailed(System.Action<System.UInt64, MegaCrit.Sts2.Core.Entities.Multiplayer.NetErrorInfo> value)
public abstract System.Void add_ClientDisconnected(System.Action<System.UInt64, MegaCrit.Sts2.Core.Entities.Multiplayer.NetErrorInfo> value)
public abstract System.Void DisconnectClient(System.UInt64 peerId, MegaCrit.Sts2.Core.Entities.Multiplayer.NetError reason, System.Boolean now = False)
public abstract System.Void remove_ClientConnected(System.Action<System.UInt64> value)
public abstract System.Void remove_ClientConnectionFailed(System.Action<System.UInt64, MegaCrit.Sts2.Core.Entities.Multiplayer.NetErrorInfo> value)
public abstract System.Void remove_ClientDisconnected(System.Action<System.UInt64, MegaCrit.Sts2.Core.Entities.Multiplayer.NetErrorInfo> value)
public abstract System.Void SetPeerReadyForBroadcasting(System.UInt64 peerId)
```

## MegaCrit.Sts2.Core.Multiplayer.Game.JoinFlow

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private System.Threading.Tasks.TaskCompletionSource<MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.InitialGameInfoMessage> _connectCompletion
private System.Threading.Tasks.TaskCompletionSource<MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.ClientLobbyJoinResponseMessage> _joinCompletion
private System.Threading.Tasks.TaskCompletionSource<MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.ClientLoadJoinResponseMessage> _loadJoinCompletion
private readonly MegaCrit.Sts2.Core.Logging.Logger _logger
private System.Threading.Tasks.TaskCompletionSource<MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.ClientRejoinResponseMessage> _rejoinCompletion
private readonly System.Threading.CancellationTokenSource <CancelToken>k__BackingField
private readonly MegaCrit.Sts2.Core.Multiplayer.Game.INetClientGameService <NetService>k__BackingField
System.Threading.CancellationTokenSource CancelToken { public get; }
MegaCrit.Sts2.Core.Multiplayer.Game.INetClientGameService NetService { public get; }
public .ctor(MegaCrit.Sts2.Core.Multiplayer.Game.INetClientGameService netService)
private [async] System.Threading.Tasks.Task NetServiceUpdateLoop(System.Threading.CancellationTokenSource token, Godot.SceneTree sceneTree)
private [async] System.Threading.Tasks.Task<MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.ClientLoadJoinResponseMessage> AttemptLoadJoin()
private [async] System.Threading.Tasks.Task<MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.ClientLobbyJoinResponseMessage> AttemptJoin()
private [async] System.Threading.Tasks.Task<MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.ClientRejoinResponseMessage> AttemptRejoin()
private System.Void Cancel()
private System.Void HandleInitialGameInfoMessage(MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.InitialGameInfoMessage message, System.UInt64 _)
private System.Void HandleJoinResponseMessage(MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.ClientLobbyJoinResponseMessage message, System.UInt64 senderId)
private System.Void HandleLoadJoinResponseMessage(MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.ClientLoadJoinResponseMessage message, System.UInt64 senderId)
private System.Void HandleRejoinResponseMessage(MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.ClientRejoinResponseMessage message, System.UInt64 senderId)
private System.Void OnDisconnected(MegaCrit.Sts2.Core.Entities.Multiplayer.NetErrorInfo info)
private System.Void OnFailedToConnectToHost(MegaCrit.Sts2.Core.Entities.Multiplayer.NetErrorInfo info)
private System.Void SetDisconnectionException(System.Exception exception)
public [async] System.Threading.Tasks.Task<MegaCrit.Sts2.Core.Multiplayer.Game.JoinResult> Begin(MegaCrit.Sts2.Core.Multiplayer.Connection.IClientConnectionInitializer initializer, Godot.SceneTree sceneTree)
public MegaCrit.Sts2.Core.Multiplayer.Game.INetClientGameService get_NetService()
public System.Threading.CancellationTokenSource get_CancelToken()
```

## MegaCrit.Sts2.Core.Multiplayer.Game.JoinFlow+<AttemptJoin>d__14

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Multiplayer.Game.JoinFlow <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.ClientLobbyJoinResponseMessage> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.ClientLobbyJoinResponseMessage> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Multiplayer.Game.JoinFlow+<AttemptLoadJoin>d__15

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Multiplayer.Game.JoinFlow <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.ClientLoadJoinResponseMessage> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.ClientLoadJoinResponseMessage> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Multiplayer.Game.JoinFlow+<AttemptRejoin>d__16

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Multiplayer.Game.JoinFlow <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.ClientRejoinResponseMessage> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.ClientRejoinResponseMessage> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Multiplayer.Game.JoinFlow+<Begin>d__12

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Multiplayer.Game.JoinFlow <>4__this
private System.Object <>7__wrap2
private System.Int32 <>7__wrap3
private MegaCrit.Sts2.Core.Multiplayer.Game.JoinResult <>7__wrap4
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<MegaCrit.Sts2.Core.Multiplayer.Game.JoinResult> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Nullable<MegaCrit.Sts2.Core.Entities.Multiplayer.NetErrorInfo>> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.InitialGameInfoMessage> <>u__2
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.ClientLobbyJoinResponseMessage> <>u__3
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.ClientLoadJoinResponseMessage> <>u__4
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.ClientRejoinResponseMessage> <>u__5
private System.Runtime.CompilerServices.TaskAwaiter <>u__6
private MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.InitialGameInfoMessage <initialMessage>5__6
private MegaCrit.Sts2.Core.Entities.Multiplayer.RunSessionState <state>5__7
private System.Threading.CancellationTokenSource <updateLoopCancelSource>5__2
public MegaCrit.Sts2.Core.Multiplayer.Connection.IClientConnectionInitializer initializer
public Godot.SceneTree sceneTree
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Multiplayer.Game.JoinFlow+<NetServiceUpdateLoop>d__13

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Multiplayer.Game.JoinFlow <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Object <>u__1
public Godot.SceneTree sceneTree
public System.Threading.CancellationTokenSource token
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Multiplayer.Game.JoinResult

类型属性：`Public, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：

```text
public MegaCrit.Sts2.Core.Runs.GameMode gameMode
public System.Nullable<MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.ClientLobbyJoinResponseMessage> joinResponse
public System.Nullable<MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.ClientLoadJoinResponseMessage> loadJoinResponse
public System.Nullable<MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.ClientRejoinResponseMessage> rejoinResponse
public System.Nullable<MegaCrit.Sts2.Core.Entities.Multiplayer.RunSessionState> sessionState
```

## MegaCrit.Sts2.Core.Multiplayer.Game.MapSelectionSynchronizer

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private MegaCrit.Sts2.Core.Runs.MapLocation _acceptingVotesFromSource
private readonly MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSynchronizer _actionQueueSynchronizer
private readonly MegaCrit.Sts2.Core.Logging.Logger _logger
private readonly MegaCrit.Sts2.Core.Random.Rng _multiplayerMapPointSelection
private readonly MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService _netService
private readonly MegaCrit.Sts2.Core.Runs.RunState _runState
private readonly System.Collections.Generic.List<System.Nullable<MegaCrit.Sts2.Core.Multiplayer.Game.MapVote>> _votes
private System.Int32 <MapGenerationCount>k__BackingField
private System.Action<MegaCrit.Sts2.Core.Entities.Players.Player> PlayerVoteCancelled
private System.Action<MegaCrit.Sts2.Core.Entities.Players.Player, System.Nullable<MegaCrit.Sts2.Core.Multiplayer.Game.MapVote>, System.Nullable<MegaCrit.Sts2.Core.Multiplayer.Game.MapVote>> PlayerVoteChanged
private System.Action PlayerVotesCleared
System.Int32 MapGenerationCount { public get; private set; }
event System.Action<MegaCrit.Sts2.Core.Entities.Players.Player> PlayerVoteCancelled
event System.Action<MegaCrit.Sts2.Core.Entities.Players.Player, System.Nullable<MegaCrit.Sts2.Core.Multiplayer.Game.MapVote>, System.Nullable<MegaCrit.Sts2.Core.Multiplayer.Game.MapVote>> PlayerVoteChanged
event System.Action PlayerVotesCleared
public .ctor(MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService netService, MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSynchronizer actionQueueSynchronizer, MegaCrit.Sts2.Core.Runs.RunState runState)
private System.Boolean <PlayerVotedForMapCoord>b__21_0(System.Nullable<MegaCrit.Sts2.Core.Multiplayer.Game.MapVote> p)
private System.Void MoveToMapCoord()
private System.Void set_MapGenerationCount(System.Int32 value)
public System.Int32 get_MapGenerationCount()
public System.Nullable<MegaCrit.Sts2.Core.Multiplayer.Game.MapVote> GetVote(MegaCrit.Sts2.Core.Entities.Players.Player player)
public System.Void add_PlayerVoteCancelled(System.Action<MegaCrit.Sts2.Core.Entities.Players.Player> value)
public System.Void add_PlayerVoteChanged(System.Action<MegaCrit.Sts2.Core.Entities.Players.Player, System.Nullable<MegaCrit.Sts2.Core.Multiplayer.Game.MapVote>, System.Nullable<MegaCrit.Sts2.Core.Multiplayer.Game.MapVote>> value)
public System.Void add_PlayerVotesCleared(System.Action value)
public System.Void BeforeMapGenerated()
public System.Void OnLocationChanged(MegaCrit.Sts2.Core.Runs.MapLocation location)
public System.Void PlayerVotedForMapCoord(MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.Runs.MapLocation source, System.Nullable<MegaCrit.Sts2.Core.Multiplayer.Game.MapVote> destination)
public System.Void remove_PlayerVoteCancelled(System.Action<MegaCrit.Sts2.Core.Entities.Players.Player> value)
public System.Void remove_PlayerVoteChanged(System.Action<MegaCrit.Sts2.Core.Entities.Players.Player, System.Nullable<MegaCrit.Sts2.Core.Multiplayer.Game.MapVote>, System.Nullable<MegaCrit.Sts2.Core.Multiplayer.Game.MapVote>> value)
public System.Void remove_PlayerVotesCleared(System.Action value)
```

## MegaCrit.Sts2.Core.Multiplayer.Game.MapVote

类型属性：`Public, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`MegaCrit.Sts2.Core.Multiplayer.Serialization.IPacketSerializable`

```text
public MegaCrit.Sts2.Core.Map.MapCoord coord
public System.Int32 mapGenerationCount
public virtual System.String ToString()
public virtual System.Void Deserialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketReader reader)
public virtual System.Void Serialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketWriter writer)
```

## MegaCrit.Sts2.Core.Multiplayer.Game.MessageHandlerDelegate<T>

类型属性：`Public, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(T message, System.UInt64 senderId, System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke(T message, System.UInt64 senderId)
```

## MegaCrit.Sts2.Core.Multiplayer.Game.NetGameType

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Multiplayer.Game.NetGameType Client = 3
public static const MegaCrit.Sts2.Core.Multiplayer.Game.NetGameType Host = 2
public static const MegaCrit.Sts2.Core.Multiplayer.Game.NetGameType None = 0
public static const MegaCrit.Sts2.Core.Multiplayer.Game.NetGameType Replay = 4
public static const MegaCrit.Sts2.Core.Multiplayer.Game.NetGameType Singleplayer = 1
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Multiplayer.Game.NetGameTypeExtensions

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static System.Boolean IsMultiplayer(MegaCrit.Sts2.Core.Multiplayer.Game.NetGameType type)
```

## MegaCrit.Sts2.Core.Multiplayer.Game.NetLoadingHandle

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：`System.IDisposable`

```text
private static readonly System.Collections.Generic.Dictionary<MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService, System.Int32> _loadCounts
private readonly MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService _netService
private static .cctor()
public .ctor(MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService netService)
public static System.Void Release(MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService netService)
public virtual System.Void Dispose()
```

## MegaCrit.Sts2.Core.Multiplayer.Game.OneOffSynchronizer

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：`System.IDisposable`

```text
private readonly MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService _gameService
private readonly System.UInt64 _localPlayerId
private readonly MegaCrit.Sts2.Core.Multiplayer.Game.RunLocationTargetedMessageBuffer _messageBuffer
private readonly MegaCrit.Sts2.Core.Runs.IPlayerCollection _playerCollection
MegaCrit.Sts2.Core.Entities.Players.Player LocalPlayer { private get; }
public .ctor(MegaCrit.Sts2.Core.Multiplayer.Game.RunLocationTargetedMessageBuffer messageBuffer, MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService gameService, MegaCrit.Sts2.Core.Runs.IPlayerCollection playerCollection, System.UInt64 localPlayerId)
private [async] System.Threading.Tasks.Task OfferCrystalSphereRewards(MegaCrit.Sts2.Core.Entities.Players.Player owner, System.Collections.Generic.List<MegaCrit.Sts2.Core.Events.Custom.CrystalSphereEvent.CrystalSphereItem> revealed, MegaCrit.Sts2.Core.Random.Rng rng)
private [async] System.Threading.Tasks.Task<System.Boolean> DoMerchantCardRemoval(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Int32 goldCost, System.Boolean cancelable = True)
private [async] System.Threading.Tasks.Task<System.Int32> DoTreasureRoomRewards(MegaCrit.Sts2.Core.Entities.Players.Player player)
private [async] System.Threading.Tasks.Task<System.Int32> TryHandleSpoilsMap(MegaCrit.Sts2.Core.Entities.Players.Player player)
private MegaCrit.Sts2.Core.Entities.Players.Player get_LocalPlayer()
private System.Void HandleCrystalSphereRewardsMessage(MegaCrit.Sts2.Core.Multiplayer.Messages.Game.CrystalSphereRewardsMessage message, System.UInt64 senderId)
private System.Void HandleMerchantCardRemoval(MegaCrit.Sts2.Core.Multiplayer.Messages.Game.MerchantCardRemovalMessage message, System.UInt64 senderId)
private System.Void HandleTreasureChestOpenedMessage(MegaCrit.Sts2.Core.Multiplayer.Messages.Game.TreasureChestOpenedMessage message, System.UInt64 senderId)
public [async] System.Threading.Tasks.Task DoLocalCrystalSphereRewards(MegaCrit.Sts2.Core.Entities.Players.Player owner, MegaCrit.Sts2.Core.Random.Rng rng, System.Collections.Generic.List<MegaCrit.Sts2.Core.Events.Custom.CrystalSphereEvent.CrystalSphereItem> revealed)
public System.Threading.Tasks.Task<System.Boolean> DoLocalMerchantCardRemoval(System.Int32 goldCost, System.Boolean cancelable = True)
public System.Threading.Tasks.Task<System.Int32> DoLocalTreasureRoomRewards()
public virtual System.Void Dispose()
```

## MegaCrit.Sts2.Core.Multiplayer.Game.OneOffSynchronizer+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Multiplayer.Game.OneOffSynchronizer+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Models.AbstractModel, System.Boolean> <>9__14_0
public static System.Func<MegaCrit.Sts2.Core.Events.Custom.CrystalSphereEvent.CrystalSphereItem, MegaCrit.Sts2.Core.Events.Custom.CrystalSphereEvent.SerializableCrystalSphereItem> <>9__15_0
private static .cctor()
public .ctor()
internal MegaCrit.Sts2.Core.Events.Custom.CrystalSphereEvent.SerializableCrystalSphereItem <DoLocalCrystalSphereRewards>b__15_0(MegaCrit.Sts2.Core.Events.Custom.CrystalSphereEvent.CrystalSphereItem r)
internal System.Boolean <TryHandleSpoilsMap>b__14_0(MegaCrit.Sts2.Core.Models.AbstractModel q)
```

## MegaCrit.Sts2.Core.Multiplayer.Game.OneOffSynchronizer+<>c__DisplayClass16_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Entities.Players.Player player
public .ctor()
internal MegaCrit.Sts2.Core.Events.Custom.CrystalSphereEvent.CrystalSphereItem <HandleCrystalSphereRewardsMessage>b__0(MegaCrit.Sts2.Core.Events.Custom.CrystalSphereEvent.SerializableCrystalSphereItem r)
```

## MegaCrit.Sts2.Core.Multiplayer.Game.OneOffSynchronizer+<>c__DisplayClass17_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Entities.Players.Player owner
public MegaCrit.Sts2.Core.Random.Rng rng
public .ctor()
internal MegaCrit.Sts2.Core.Rewards.Reward <OfferCrystalSphereRewards>b__0(MegaCrit.Sts2.Core.Events.Custom.CrystalSphereEvent.CrystalSphereItem r)
```

## MegaCrit.Sts2.Core.Multiplayer.Game.OneOffSynchronizer+<DoLocalCrystalSphereRewards>d__15

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Multiplayer.Game.OneOffSynchronizer <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.Entities.Players.Player owner
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Events.Custom.CrystalSphereEvent.CrystalSphereItem> revealed
public MegaCrit.Sts2.Core.Random.Rng rng
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Multiplayer.Game.OneOffSynchronizer+<DoMerchantCardRemoval>d__10

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Boolean> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
private MegaCrit.Sts2.Core.Models.CardModel <card>5__2
public System.Boolean cancelable
public System.Int32 goldCost
public MegaCrit.Sts2.Core.Entities.Players.Player player
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Multiplayer.Game.OneOffSynchronizer+<DoTreasureRoomRewards>d__13

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Multiplayer.Game.OneOffSynchronizer <>4__this
private System.Double <>7__wrap2
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Int32> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<System.Int32> <>u__2
private System.Double <gold>5__2
public MegaCrit.Sts2.Core.Entities.Players.Player player
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Multiplayer.Game.OneOffSynchronizer+<OfferCrystalSphereRewards>d__17

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.Entities.Players.Player owner
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Events.Custom.CrystalSphereEvent.CrystalSphereItem> revealed
public MegaCrit.Sts2.Core.Random.Rng rng
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Multiplayer.Game.OneOffSynchronizer+<TryHandleSpoilsMap>d__14

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
private System.Collections.Generic.List+Enumerator<MegaCrit.Sts2.Core.Models.Cards.SpoilsMap> <>7__wrap1
private System.Int32 <>7__wrap2
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Int32> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Int32> <>u__1
public MegaCrit.Sts2.Core.Entities.Players.Player player
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Multiplayer.Game.ReactionSynchronizer

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：`System.IDisposable`

```text
private readonly MegaCrit.Sts2.Core.Nodes.Reaction.NReactionContainer _container
private readonly MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService <NetService>k__BackingField
MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService NetService { public get; }
public .ctor(MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService netService, MegaCrit.Sts2.Core.Nodes.Reaction.NReactionContainer container)
private System.Void HandleReactionMessage(MegaCrit.Sts2.Core.Multiplayer.Messages.Game.Flavor.ReactionMessage message, System.UInt64 senderId)
public MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService get_NetService()
public System.Void SendLocalReaction(MegaCrit.Sts2.Core.Entities.Multiplayer.ReactionType type, Godot.Vector2 mouseScreenPos)
public virtual System.Void Dispose()
```

## MegaCrit.Sts2.Core.Multiplayer.Game.RestSiteSynchronizer

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：`System.IDisposable`

```text
private System.Nullable<MegaCrit.Sts2.Core.Multiplayer.Messages.Game.Flavor.RestSiteOptionHoveredMessage> _hoveredMessage
private System.Threading.Tasks.Task _hoverMessageTask
private System.UInt64 _lastHoverMessageMsec
private readonly System.UInt64 _localPlayerId
private readonly MegaCrit.Sts2.Core.Logging.Logger _logger
private readonly MegaCrit.Sts2.Core.Multiplayer.Game.RunLocationTargetedMessageBuffer _messageBuffer
private readonly MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService _netService
private readonly MegaCrit.Sts2.Core.Runs.IPlayerCollection _playerCollection
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Multiplayer.Game.RestSiteSynchronizer+PlayerRestSite> _restSites
private readonly MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.RunLobby _runLobby
private System.Action<MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption, System.Boolean, System.UInt64> AfterPlayerOptionChosen
private System.Action<MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption, System.UInt64> BeforePlayerOptionChosen
public static const System.Int32 minHoverMessageMsec = 50
private System.Action<System.UInt64> PlayerHoverChanged
MegaCrit.Sts2.Core.Entities.Players.Player LocalPlayer { private get; }
event System.Action<MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption, System.Boolean, System.UInt64> AfterPlayerOptionChosen
event System.Action<MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption, System.UInt64> BeforePlayerOptionChosen
event System.Action<System.UInt64> PlayerHoverChanged
public .ctor(MegaCrit.Sts2.Core.Multiplayer.Game.RunLocationTargetedMessageBuffer messageBuffer, MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService netService, MegaCrit.Sts2.Core.Runs.IPlayerCollection playerCollection, System.UInt64 localPlayerId, MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.RunLobby runLobby)
private [async] System.Threading.Tasks.Task QueueHoverMessage(System.Int32 delayMsec)
private [async] System.Threading.Tasks.Task SendHoverMessageAfterSmallDelay()
private [async] System.Threading.Tasks.Task<System.Boolean> ChooseOption(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Int32 optionIndex)
private MegaCrit.Sts2.Core.Entities.Players.Player get_LocalPlayer()
private System.Void HandleRestSiteOptionChosenMessage(MegaCrit.Sts2.Core.Multiplayer.Messages.Game.Sync.OptionIndexChosenMessage message, System.UInt64 senderId)
private System.Void HandleRestSiteOptionHoveredMessage(MegaCrit.Sts2.Core.Multiplayer.Messages.Game.Flavor.RestSiteOptionHoveredMessage message, System.UInt64 senderId)
private System.Void HandleRestSiteSkippedMessage(MegaCrit.Sts2.Core.Multiplayer.Messages.Game.Sync.RestSiteSkippedMessage message, System.UInt64 senderId)
private System.Void OnPeerDisconnected(System.UInt64 peerId)
private System.Void SendHoverMessage()
private System.Void TrySendHoverMessage()
public [async] System.Threading.Tasks.Task AfterAllRestSitesCompleted()
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption> GetLocalOptions()
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption> GetOptionsForPlayer(MegaCrit.Sts2.Core.Entities.Players.Player player)
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption> GetOptionsForPlayer(System.UInt64 playerId)
public System.Nullable<System.Int32> GetChosenOptionIndex(System.UInt64 playerId)
public System.Nullable<System.Int32> GetHoveredOptionIndex(System.UInt64 playerId)
public System.Threading.Tasks.Task<System.Boolean> ChooseLocalOption(System.Int32 index)
public System.Void add_AfterPlayerOptionChosen(System.Action<MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption, System.Boolean, System.UInt64> value)
public System.Void add_BeforePlayerOptionChosen(System.Action<MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption, System.UInt64> value)
public System.Void add_PlayerHoverChanged(System.Action<System.UInt64> value)
public System.Void BeforeLocalRestSiteExited()
public System.Void BeginRestSite()
public System.Void LocalOptionHovered(MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption option)
public System.Void remove_AfterPlayerOptionChosen(System.Action<MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption, System.Boolean, System.UInt64> value)
public System.Void remove_BeforePlayerOptionChosen(System.Action<MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption, System.UInt64> value)
public System.Void remove_PlayerHoverChanged(System.Action<System.UInt64> value)
public virtual System.Void Dispose()
```

## MegaCrit.Sts2.Core.Multiplayer.Game.RestSiteSynchronizer+<AfterAllRestSitesCompleted>d__33

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Multiplayer.Game.RestSiteSynchronizer <>4__this
private System.Collections.Generic.List+Enumerator<MegaCrit.Sts2.Core.Multiplayer.Game.RestSiteSynchronizer+PlayerRestSite> <>7__wrap1
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Multiplayer.Game.RestSiteSynchronizer+<ChooseOption>d__31

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Multiplayer.Game.RestSiteSynchronizer <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Boolean> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption <option>5__3
private MegaCrit.Sts2.Core.Multiplayer.Game.RestSiteSynchronizer+PlayerRestSite <restSite>5__2
public System.Int32 optionIndex
public MegaCrit.Sts2.Core.Entities.Players.Player player
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Multiplayer.Game.RestSiteSynchronizer+<QueueHoverMessage>d__41

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Multiplayer.Game.RestSiteSynchronizer <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public System.Int32 delayMsec
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Multiplayer.Game.RestSiteSynchronizer+<SendHoverMessageAfterSmallDelay>d__42

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Multiplayer.Game.RestSiteSynchronizer <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.YieldAwaitable+YieldAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Multiplayer.Game.RestSiteSynchronizer+PlayerRestSite

类型属性：`NestedPrivate, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.Threading.Tasks.TaskCompletionSource completionTaskSource
public System.Nullable<System.UInt32> hoveredOptionIndex
public System.Nullable<System.UInt32> lastChosenOptionIndex
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption> options
public .ctor()
```

## MegaCrit.Sts2.Core.Multiplayer.Game.RewardsSetSynchronizer

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：`System.IDisposable`

```text
private readonly System.UInt64 _localPlayerId
private readonly MegaCrit.Sts2.Core.Logging.Logger _logger
private readonly MegaCrit.Sts2.Core.Multiplayer.Game.RunLocationTargetedMessageBuffer _messageBuffer
private readonly MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService _netService
private readonly MegaCrit.Sts2.Core.Runs.IPlayerCollection _playerCollection
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Multiplayer.Game.RewardsSetSynchronizer+PlayerRewardState> _rewardStates
private System.Action RewardsSkippedDuringRoomExit
MegaCrit.Sts2.Core.Entities.Players.Player LocalPlayer { private get; }
event System.Action RewardsSkippedDuringRoomExit
public .ctor(MegaCrit.Sts2.Core.Multiplayer.Game.RunLocationTargetedMessageBuffer messageBuffer, MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService netService, MegaCrit.Sts2.Core.Runs.IPlayerCollection playerCollection, System.UInt64 localPlayerId)
private [async] System.Threading.Tasks.Task SelectRewardForPlayer(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Int32 rewardIndex)
private [async] System.Threading.Tasks.Task<System.Boolean> SelectRewardForPlayer(MegaCrit.Sts2.Core.Multiplayer.Game.RewardsSetSynchronizer+RewardsSetState setState, MegaCrit.Sts2.Core.Rewards.Reward reward)
private MegaCrit.Sts2.Core.Entities.Players.Player get_LocalPlayer()
private MegaCrit.Sts2.Core.Multiplayer.Game.RewardsSetSynchronizer+PlayerRewardState GetRewardStateForPlayer(MegaCrit.Sts2.Core.Entities.Players.Player player)
private MegaCrit.Sts2.Core.Multiplayer.Game.RewardsSetSynchronizer+RewardsSetState SkipRewardsSetOnStackTopForPlayer(MegaCrit.Sts2.Core.Entities.Players.Player player)
private System.Void CompleteRewardsSet(MegaCrit.Sts2.Core.Multiplayer.Game.RewardsSetSynchronizer+RewardsSetState setState, MegaCrit.Sts2.Core.Multiplayer.Game.RewardsSetSynchronizer+RewardSetCompleteState completeState)
private System.Void CompleteRewardsSetIfNecessary(MegaCrit.Sts2.Core.Multiplayer.Game.RewardsSetSynchronizer+RewardsSetState setState)
private System.Void SkipRewardsSet(MegaCrit.Sts2.Core.Multiplayer.Game.RewardsSetSynchronizer+RewardsSetState setState)
public [async] System.Threading.Tasks.Task<System.Boolean> SelectLocalReward(MegaCrit.Sts2.Core.Rewards.Reward reward)
public System.Boolean IsRewardsSetCompleted(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Int32 id)
public System.Boolean IsRewardsSetCompleted(MegaCrit.Sts2.Core.Rewards.RewardsSet set)
public System.Collections.Generic.IEnumerable<System.Int32> GetNextRewardIds()
public System.Threading.Tasks.Task BeginRewardsSet(MegaCrit.Sts2.Core.Rewards.RewardsSet set)
public System.Void add_RewardsSkippedDuringRoomExit(System.Action value)
public System.Void BeforeLeavingRoom()
public System.Void FastForwardRewardIds(System.Collections.Generic.List<System.Int32> rewardIds)
public System.Void HandleRewardSelectedMessage(MegaCrit.Sts2.Core.Multiplayer.Messages.Game.Sync.RewardSelectedMessage message, System.UInt64 senderId)
public System.Void HandleRewardSetSkippedMessage(MegaCrit.Sts2.Core.Multiplayer.Messages.Game.Sync.RewardSetSkippedMessage message, System.UInt64 senderId)
public System.Void remove_RewardsSkippedDuringRoomExit(System.Action value)
public System.Void SkipLocalRewardsSet()
public virtual System.Void Dispose()
```

## MegaCrit.Sts2.Core.Multiplayer.Game.RewardsSetSynchronizer+<GetNextRewardIds>d__32

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：`System.Collections.Generic.IEnumerable<System.Int32>`, `System.Collections.IEnumerable`, `System.Collections.Generic.IEnumerator<System.Int32>`, `System.Collections.IEnumerator`, `System.IDisposable`

```text
private System.Int32 <>1__state
private System.Int32 <>2__current
public MegaCrit.Sts2.Core.Multiplayer.Game.RewardsSetSynchronizer <>4__this
private System.Collections.Generic.List+Enumerator<MegaCrit.Sts2.Core.Multiplayer.Game.RewardsSetSynchronizer+PlayerRewardState> <>7__wrap1
private System.Int32 <>l__initialThreadId
System.Int32 System.Collections.Generic.IEnumerator<System.Int32>.Current { private virtual get; }
System.Object System.Collections.IEnumerator.Current { private virtual get; }
public .ctor(System.Int32 <>1__state)
private System.Void <>m__Finally1()
private virtual System.Boolean MoveNext()
private virtual System.Collections.Generic.IEnumerator<System.Int32> System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator()
private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
private virtual System.Int32 System.Collections.Generic.IEnumerator<System.Int32>.get_Current()
private virtual System.Object System.Collections.IEnumerator.get_Current()
private virtual System.Void System.Collections.IEnumerator.Reset()
private virtual System.Void System.IDisposable.Dispose()
```

## MegaCrit.Sts2.Core.Multiplayer.Game.RewardsSetSynchronizer+<SelectLocalReward>d__19

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Multiplayer.Game.RewardsSetSynchronizer <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Boolean> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
public MegaCrit.Sts2.Core.Rewards.Reward reward
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Multiplayer.Game.RewardsSetSynchronizer+<SelectRewardForPlayer>d__23

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Multiplayer.Game.RewardsSetSynchronizer <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
public MegaCrit.Sts2.Core.Entities.Players.Player player
public System.Int32 rewardIndex
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Multiplayer.Game.RewardsSetSynchronizer+<SelectRewardForPlayer>d__24

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Multiplayer.Game.RewardsSetSynchronizer <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Boolean> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
public MegaCrit.Sts2.Core.Rewards.Reward reward
public MegaCrit.Sts2.Core.Multiplayer.Game.RewardsSetSynchronizer+RewardsSetState setState
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Multiplayer.Game.RewardsSetSynchronizer+BufferedMessage

类型属性：`NestedPrivate, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.IEquatable<MegaCrit.Sts2.Core.Multiplayer.Game.RewardsSetSynchronizer+BufferedMessage>`

```text
public MegaCrit.Sts2.Core.Multiplayer.Messages.Game.Sync.RewardSelectedMessage selectedMessage
public System.UInt64 senderId
public MegaCrit.Sts2.Core.Multiplayer.Messages.Game.Sync.RewardSetSkippedMessage skippedMessage
System.Int32 SetId { public get; }
private System.Boolean PrintMembers(System.Text.StringBuilder builder)
public static System.Boolean op_Equality(MegaCrit.Sts2.Core.Multiplayer.Game.RewardsSetSynchronizer+BufferedMessage left, MegaCrit.Sts2.Core.Multiplayer.Game.RewardsSetSynchronizer+BufferedMessage right)
public static System.Boolean op_Inequality(MegaCrit.Sts2.Core.Multiplayer.Game.RewardsSetSynchronizer+BufferedMessage left, MegaCrit.Sts2.Core.Multiplayer.Game.RewardsSetSynchronizer+BufferedMessage right)
public System.Int32 get_SetId()
public virtual System.Boolean Equals(MegaCrit.Sts2.Core.Multiplayer.Game.RewardsSetSynchronizer+BufferedMessage other)
public virtual System.Boolean Equals(System.Object obj)
public virtual System.Int32 GetHashCode()
public virtual System.String ToString()
```

## MegaCrit.Sts2.Core.Multiplayer.Game.RewardsSetSynchronizer+PlayerRewardState

类型属性：`NestedPrivate, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Multiplayer.Game.RewardsSetSynchronizer+BufferedMessage> bufferedMessages
public readonly System.Collections.Generic.Dictionary<System.Int32, MegaCrit.Sts2.Core.Multiplayer.Game.RewardsSetSynchronizer+RewardSetCompleteState> completedRewards
public System.Int32 nextId
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Multiplayer.Game.RewardsSetSynchronizer+RewardsSetState> rewardsStack
public .ctor()
```

## MegaCrit.Sts2.Core.Multiplayer.Game.RewardsSetSynchronizer+RewardSetCompleteState

类型属性：`NestedPrivate, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Multiplayer.Game.RewardsSetSynchronizer+RewardSetCompleteState Completed = 1
public static const MegaCrit.Sts2.Core.Multiplayer.Game.RewardsSetSynchronizer+RewardSetCompleteState None = 0
public static const MegaCrit.Sts2.Core.Multiplayer.Game.RewardsSetSynchronizer+RewardSetCompleteState Skipped = 2
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Multiplayer.Game.RewardsSetSynchronizer+RewardsSetState

类型属性：`NestedPrivate, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.Threading.Tasks.TaskCompletionSource completionSource
public MegaCrit.Sts2.Core.Rewards.RewardsSet set
public .ctor()
```

## MegaCrit.Sts2.Core.Multiplayer.Game.RewardSynchronizer

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：`System.IDisposable`

```text
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Multiplayer.Game.RewardSynchronizer+BufferedMessage> _bufferedMessages
private readonly MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService _gameService
private readonly System.UInt64 _localPlayerId
private readonly MegaCrit.Sts2.Core.Multiplayer.Game.RunLocationTargetedMessageBuffer _messageBuffer
private readonly MegaCrit.Sts2.Core.Runs.IPlayerCollection _playerCollection
MegaCrit.Sts2.Core.Entities.Players.Player LocalPlayer { private get; }
public .ctor(MegaCrit.Sts2.Core.Multiplayer.Game.RunLocationTargetedMessageBuffer messageBuffer, MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService gameService, MegaCrit.Sts2.Core.Runs.IPlayerCollection playerCollection, System.UInt64 localPlayerId)
private MegaCrit.Sts2.Core.Entities.Players.Player get_LocalPlayer()
private System.Void HandleCardRemovedMessage(MegaCrit.Sts2.Core.Multiplayer.Messages.Game.CardRemovedMessage message, System.UInt64 senderId)
private System.Void HandleGoldLostMessage(MegaCrit.Sts2.Core.Multiplayer.Messages.Game.Sync.GoldLostMessage message, System.UInt64 senderId)
private System.Void HandleRewardObtainedMessage(MegaCrit.Sts2.Core.Multiplayer.Messages.Game.Sync.RewardObtainedMessage message, System.UInt64 senderId)
private System.Void OnCombatEnded(MegaCrit.Sts2.Core.Rooms.CombatRoom _)
private System.Void SyncLocalCardEvent(MegaCrit.Sts2.Core.Models.CardModel card, System.Boolean skipped)
private System.Void SyncLocalPotionEvent(MegaCrit.Sts2.Core.Models.PotionModel potion, System.Boolean skipped)
private System.Void SyncLocalRelicEvent(MegaCrit.Sts2.Core.Models.RelicModel relic, System.Boolean skipped)
public [async] System.Threading.Tasks.Task<System.Boolean> DoLocalCardRemoval()
public [async] System.Threading.Tasks.Task<System.Boolean> DoUnsyncedCardRemoval(MegaCrit.Sts2.Core.Entities.Players.Player player)
public System.Void SyncLocalGoldLost(System.Int32 goldLost)
public System.Void SyncLocalObtainedCard(MegaCrit.Sts2.Core.Models.CardModel card)
public System.Void SyncLocalObtainedGold(System.Int32 goldAmount)
public System.Void SyncLocalObtainedPotion(MegaCrit.Sts2.Core.Models.PotionModel potion)
public System.Void SyncLocalObtainedRelic(MegaCrit.Sts2.Core.Models.RelicModel relic)
public System.Void SyncLocalSkippedCard(MegaCrit.Sts2.Core.Models.CardModel card)
public System.Void SyncLocalSkippedPotion(MegaCrit.Sts2.Core.Models.PotionModel potion)
public System.Void SyncLocalSkippedRelic(MegaCrit.Sts2.Core.Models.RelicModel relic)
public virtual System.Void Dispose()
```

## MegaCrit.Sts2.Core.Multiplayer.Game.RewardSynchronizer+<DoLocalCardRemoval>d__21

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Multiplayer.Game.RewardSynchronizer <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Boolean> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Multiplayer.Game.RewardSynchronizer+<DoUnsyncedCardRemoval>d__26

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Boolean> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
private MegaCrit.Sts2.Core.Models.CardModel <card>5__2
public MegaCrit.Sts2.Core.Entities.Players.Player player
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Multiplayer.Game.RewardSynchronizer+BufferedMessage

类型属性：`NestedPrivate, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：

```text
public MegaCrit.Sts2.Core.Multiplayer.Messages.Game.CardRemovedMessage cardRemovedMessage
public System.Nullable<MegaCrit.Sts2.Core.Multiplayer.Messages.Game.Sync.GoldLostMessage> goldLostMessage
public System.Nullable<MegaCrit.Sts2.Core.Multiplayer.Messages.Game.Sync.RewardObtainedMessage> rewardMessage
public System.UInt64 senderId
```

## MegaCrit.Sts2.Core.Multiplayer.Game.RunLocationTargetedMessageBuffer

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private readonly MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService _gameService
private readonly MegaCrit.Sts2.Core.Logging.Logger _logger
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Multiplayer.Game.RunLocationTargetedMessageBuffer+TypeAndMessageHandlers> _messageHandlers
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Multiplayer.Game.RunLocationTargetedMessageBuffer+BlockedMessage> _messagesWaitingOnLocationChange
private readonly System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Runs.RunLocation> _visitedLocations
private MegaCrit.Sts2.Core.Runs.RunLocation <CurrentLocation>k__BackingField
MegaCrit.Sts2.Core.Runs.RunLocation CurrentLocation { public get; private set; }
public .ctor(MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService gameService)
private System.Void CallHandlersOfType(System.Type type, MegaCrit.Sts2.Core.Multiplayer.Serialization.INetMessage message, System.UInt64 senderId)
private System.Void HandleMessage<T>(T message, System.UInt64 senderId) where T: [None] MegaCrit.Sts2.Core.Multiplayer.Serialization.INetMessage, MegaCrit.Sts2.Core.Multiplayer.Messages.Game.IRunLocationTargetedMessage
private System.Void set_CurrentLocation(MegaCrit.Sts2.Core.Runs.RunLocation value)
public MegaCrit.Sts2.Core.Runs.RunLocation get_CurrentLocation()
public System.Void OnLocationChanged(MegaCrit.Sts2.Core.Runs.RunLocation location)
public System.Void RegisterMessageHandler<T>(MegaCrit.Sts2.Core.Multiplayer.Game.MessageHandlerDelegate<T> handler) where T: [None] MegaCrit.Sts2.Core.Multiplayer.Serialization.INetMessage, MegaCrit.Sts2.Core.Multiplayer.Messages.Game.IRunLocationTargetedMessage
public System.Void UnregisterMessageHandler<T>(MegaCrit.Sts2.Core.Multiplayer.Game.MessageHandlerDelegate<T> handler) where T: [None] MegaCrit.Sts2.Core.Multiplayer.Serialization.INetMessage, MegaCrit.Sts2.Core.Multiplayer.Messages.Game.IRunLocationTargetedMessage
```

## MegaCrit.Sts2.Core.Multiplayer.Game.RunLocationTargetedMessageBuffer+<>c__DisplayClass16_0<T>

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Multiplayer.Game.MessageHandlerDelegate<T> handler
public .ctor()
internal System.Void <RegisterMessageHandler>g__AnonymousDelegate|0(MegaCrit.Sts2.Core.Multiplayer.Serialization.INetMessage message, System.UInt64 senderId)
```

## MegaCrit.Sts2.Core.Multiplayer.Game.RunLocationTargetedMessageBuffer+AnonymizedMessageHandlerDelegate

类型属性：`NestedPrivate, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(MegaCrit.Sts2.Core.Multiplayer.Serialization.INetMessage message, System.UInt64 senderId, System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke(MegaCrit.Sts2.Core.Multiplayer.Serialization.INetMessage message, System.UInt64 senderId)
```

## MegaCrit.Sts2.Core.Multiplayer.Game.RunLocationTargetedMessageBuffer+BlockedMessage

类型属性：`NestedPrivate, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：

```text
public MegaCrit.Sts2.Core.Runs.RunLocation location
public MegaCrit.Sts2.Core.Multiplayer.Serialization.INetMessage message
public System.Type messageType
public System.UInt64 senderId
```

## MegaCrit.Sts2.Core.Multiplayer.Game.RunLocationTargetedMessageBuffer+MessageHandler

类型属性：`NestedPrivate, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：

```text
public MegaCrit.Sts2.Core.Multiplayer.Game.RunLocationTargetedMessageBuffer+AnonymizedMessageHandlerDelegate anonymizedHandler
public System.Object originalHandler
```

## MegaCrit.Sts2.Core.Multiplayer.Game.RunLocationTargetedMessageBuffer+TypeAndMessageHandlers

类型属性：`NestedPrivate, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：

```text
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Multiplayer.Game.RunLocationTargetedMessageBuffer+MessageHandler> handlers
public System.Type messageType
public System.Object netServiceHandler
```

## MegaCrit.Sts2.Core.Multiplayer.Game.StateDivergenceException

类型属性：`Public, BeforeFieldInit`；基类：`System.Exception`。

接口：`System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.String message)
```

## MegaCrit.Sts2.Core.Multiplayer.Game.TreasureRoomRelicSynchronizer

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private readonly MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSynchronizer _actionQueueSynchronizer
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.RelicModel> _currentRelics
private readonly System.UInt64 _localPlayerId
private readonly MegaCrit.Sts2.Core.Logging.Logger _logger
private readonly MegaCrit.Sts2.Core.Runs.IPlayerCollection _playerCollection
private MegaCrit.Sts2.Core.Multiplayer.Game.TreasureRoomRelicSynchronizer+PlayerVote _predictedVote
private readonly MegaCrit.Sts2.Core.Random.Rng _rng
private readonly MegaCrit.Sts2.Core.Runs.RelicGrabBag _sharedGrabBag
private System.Boolean _singleplayerSkipped
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Multiplayer.Game.TreasureRoomRelicSynchronizer+PlayerVote> _votes
private System.Action<System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.TreasureRelicPicking.RelicPickingResult>> RelicsAwarded
private System.Action VotesChanged
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.RelicModel> CurrentRelics { public get; }
MegaCrit.Sts2.Core.Entities.Players.Player LocalPlayer { private get; }
event System.Action<System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.TreasureRelicPicking.RelicPickingResult>> RelicsAwarded
event System.Action VotesChanged
public .ctor(MegaCrit.Sts2.Core.Runs.IPlayerCollection playerCollection, System.UInt64 localPlayerId, MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSynchronizer actionQueueSynchronizer, MegaCrit.Sts2.Core.Runs.RelicGrabBag sharedGrabBag, MegaCrit.Sts2.Core.Random.Rng rng)
private MegaCrit.Sts2.Core.Entities.Players.Player get_LocalPlayer()
private MegaCrit.Sts2.Core.Models.RelicModel TryGetRelicForTutorial(MegaCrit.Sts2.Core.Entities.Players.Player player)
private System.Void AwardRelics()
private System.Void EndRelicVoting()
public MegaCrit.Sts2.Core.Multiplayer.Game.TreasureRoomRelicSynchronizer+PlayerVote GetPlayerVote(MegaCrit.Sts2.Core.Entities.Players.Player player)
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.RelicModel> get_CurrentRelics()
public System.Void add_RelicsAwarded(System.Action<System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.TreasureRelicPicking.RelicPickingResult>> value)
public System.Void add_VotesChanged(System.Action value)
public System.Void BeginRelicPicking()
public System.Void CompleteWithNoRelics()
public System.Void OnPicked(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Nullable<System.Int32> index)
public System.Void OnRoomExited()
public System.Void PickRelicLocally(System.Nullable<System.Int32> index)
public System.Void remove_RelicsAwarded(System.Action<System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.TreasureRelicPicking.RelicPickingResult>> value)
public System.Void remove_VotesChanged(System.Action value)
public System.Void SkipRelicLocally()
```

## MegaCrit.Sts2.Core.Multiplayer.Game.TreasureRoomRelicSynchronizer+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Multiplayer.Game.TreasureRoomRelicSynchronizer+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Multiplayer.Game.TreasureRoomRelicSynchronizer+PlayerVote, System.Boolean> <>9__25_0
public static System.Func<System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry>, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry>> <>9__31_0
public static System.Func<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry, System.Boolean> <>9__31_1
private static .cctor()
public .ctor()
internal System.Boolean <OnPicked>b__25_0(MegaCrit.Sts2.Core.Multiplayer.Game.TreasureRoomRelicSynchronizer+PlayerVote v)
internal System.Boolean <TryGetRelicForTutorial>b__31_1(MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry p)
internal System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry> <TryGetRelicForTutorial>b__31_0(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry> l)
```

## MegaCrit.Sts2.Core.Multiplayer.Game.TreasureRoomRelicSynchronizer+<>c__DisplayClass26_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Multiplayer.Game.TreasureRoomRelicSynchronizer <>4__this
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.TreasureRelicPicking.RelicPickingResult> results
public .ctor()
internal System.Boolean <AwardRelics>b__0(MegaCrit.Sts2.Core.Entities.Players.Player p)
```

## MegaCrit.Sts2.Core.Multiplayer.Game.TreasureRoomRelicSynchronizer+<>c__DisplayClass26_1

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Multiplayer.Game.TreasureRoomRelicSynchronizer+<>c__DisplayClass26_0 CS$<>8__locals1
public MegaCrit.Sts2.Core.Entities.TreasureRelicPicking.RelicPickingFightMove[] possibleMoves
public .ctor()
internal MegaCrit.Sts2.Core.Entities.TreasureRelicPicking.RelicPickingFightMove <AwardRelics>b__1()
```

## MegaCrit.Sts2.Core.Multiplayer.Game.TreasureRoomRelicSynchronizer+<>c__DisplayClass26_2

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Entities.Players.Player p
public .ctor()
internal System.Boolean <AwardRelics>b__2(MegaCrit.Sts2.Core.Entities.TreasureRelicPicking.RelicPickingResult r)
```

## MegaCrit.Sts2.Core.Multiplayer.Game.TreasureRoomRelicSynchronizer+PlayerVote

类型属性：`NestedPublic, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.Nullable<System.Int32> index
public System.Boolean voteReceived
public .ctor()
```
