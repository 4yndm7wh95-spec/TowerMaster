# MegaCrit.Sts2.Core.GameActions

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.GameActions.ActionExecutor

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private System.Threading.CancellationTokenSource _actionCancelToken
private readonly MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSet _actionQueueSet
private System.Boolean _isPaused
private readonly MegaCrit.Sts2.Core.Logging.Logger _logger
private System.Threading.Tasks.TaskCompletionSource<System.Boolean> _queueTaskCompletionSource
private MegaCrit.Sts2.Core.GameActions.GameAction <CurrentlyRunningAction>k__BackingField
private System.Action<MegaCrit.Sts2.Core.GameActions.GameAction> AfterActionExecuted
private System.Action<MegaCrit.Sts2.Core.GameActions.GameAction> BeforeActionExecuted
private System.Action<MegaCrit.Sts2.Core.GameActions.GameAction> JustBeforeActionFinishedExecuting
MegaCrit.Sts2.Core.GameActions.GameAction CurrentlyRunningAction { public get; private set; }
System.Boolean IsPaused { public get; }
System.Boolean IsRunning { public get; }
event System.Action<MegaCrit.Sts2.Core.GameActions.GameAction> AfterActionExecuted
event System.Action<MegaCrit.Sts2.Core.GameActions.GameAction> BeforeActionExecuted
event System.Action<MegaCrit.Sts2.Core.GameActions.GameAction> JustBeforeActionFinishedExecuting
public .ctor(MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSet actionQueueSet)
private [async] System.Threading.Tasks.Task ExecuteActions()
private [async] System.Threading.Tasks.Task WaitForUnpause()
private System.Void ActionQueueChanged()
private System.Void AfterActionFinished(MegaCrit.Sts2.Core.GameActions.GameAction action)
private System.Void JustBeforeActionFinished(MegaCrit.Sts2.Core.GameActions.GameAction action)
private System.Void set_CurrentlyRunningAction(MegaCrit.Sts2.Core.GameActions.GameAction value)
public MegaCrit.Sts2.Core.GameActions.GameAction get_CurrentlyRunningAction()
public System.Boolean get_IsPaused()
public System.Boolean get_IsRunning()
public System.Threading.Tasks.Task FinishedExecutingActions()
public System.Void add_AfterActionExecuted(System.Action<MegaCrit.Sts2.Core.GameActions.GameAction> value)
public System.Void add_BeforeActionExecuted(System.Action<MegaCrit.Sts2.Core.GameActions.GameAction> value)
public System.Void add_JustBeforeActionFinishedExecuting(System.Action<MegaCrit.Sts2.Core.GameActions.GameAction> value)
public System.Void Cancel()
public System.Void Pause()
public System.Void remove_AfterActionExecuted(System.Action<MegaCrit.Sts2.Core.GameActions.GameAction> value)
public System.Void remove_BeforeActionExecuted(System.Action<MegaCrit.Sts2.Core.GameActions.GameAction> value)
public System.Void remove_JustBeforeActionFinishedExecuting(System.Action<MegaCrit.Sts2.Core.GameActions.GameAction> value)
public System.Void Unpause()
```

## MegaCrit.Sts2.Core.GameActions.ActionExecutor+<ExecuteActions>d__28

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.GameActions.ActionExecutor <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Object <>u__2
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__3
private System.Threading.Tasks.Task <actionTask>5__3
private MegaCrit.Sts2.Core.GameActions.GameAction <readyAction>5__2
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.GameActions.ActionExecutor+<WaitForUnpause>d__31

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.GameActions.ActionExecutor <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__2
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.GameActions.DiscardPotionGameAction

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.GameActions.GameAction`。

接口：

```text
private readonly MegaCrit.Sts2.Core.Entities.Players.Player _player
private readonly System.UInt32 _potionSlotIndex
private readonly System.Boolean <WasEnqueuedInCombat>k__BackingField
MegaCrit.Sts2.Core.Entities.Multiplayer.GameActionType ActionType { public virtual get; }
System.UInt64 OwnerId { public virtual get; }
System.Boolean WasEnqueuedInCombat { public get; }
public .ctor(MegaCrit.Sts2.Core.Entities.Players.Player player, System.UInt32 potionSlotIndex, System.Boolean isCombatInProgress)
protected virtual [async] System.Threading.Tasks.Task ExecuteAction()
protected virtual System.Void CancelAction()
public System.Boolean get_WasEnqueuedInCombat()
public virtual MegaCrit.Sts2.Core.Entities.Multiplayer.GameActionType get_ActionType()
public virtual MegaCrit.Sts2.Core.GameActions.Multiplayer.INetAction ToNetAction()
public virtual System.String ToString()
public virtual System.UInt64 get_OwnerId()
```

## MegaCrit.Sts2.Core.GameActions.DiscardPotionGameAction+<ExecuteAction>d__10

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.GameActions.DiscardPotionGameAction <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.GameActions.EndPlayerTurnAction

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.GameActions.GameAction`。

接口：

```text
private readonly MegaCrit.Sts2.Core.Entities.Players.Player _player
private readonly System.Int32 _turnNumber
MegaCrit.Sts2.Core.Entities.Multiplayer.GameActionType ActionType { public virtual get; }
System.UInt64 OwnerId { public virtual get; }
public .ctor(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Int32 turnNumber)
protected virtual System.Threading.Tasks.Task ExecuteAction()
public virtual MegaCrit.Sts2.Core.Entities.Multiplayer.GameActionType get_ActionType()
public virtual MegaCrit.Sts2.Core.GameActions.Multiplayer.INetAction ToNetAction()
public virtual System.String ToString()
public virtual System.UInt64 get_OwnerId()
```

## MegaCrit.Sts2.Core.GameActions.GameAction

类型属性：`Public, Abstract, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private System.Threading.Tasks.TaskCompletionSource _completionSource
private System.Threading.Tasks.TaskCompletionSource _executeAfterResumptionTaskSource
private System.Threading.Tasks.Task _executionTask
private static readonly MegaCrit.Sts2.Core.Logging.Logger _logger
private System.Threading.Tasks.TaskCompletionSource _pauseForPlayerChoiceTaskSource
private System.Nullable<System.UInt32> <Id>k__BackingField
private MegaCrit.Sts2.Core.Entities.Actions.GameActionState <State>k__BackingField
private System.Action<MegaCrit.Sts2.Core.GameActions.GameAction> AfterFinished
private System.Action<MegaCrit.Sts2.Core.GameActions.GameAction> BeforeCancelled
private System.Action<MegaCrit.Sts2.Core.GameActions.GameAction> BeforeExecuted
private System.Action<MegaCrit.Sts2.Core.GameActions.GameAction> BeforePausedForPlayerChoice
private System.Action<MegaCrit.Sts2.Core.GameActions.GameAction> BeforeReadyToResumeAfterPlayerChoice
private System.Action<MegaCrit.Sts2.Core.GameActions.GameAction> BeforeResumedAfterPlayerChoice
private System.Action<MegaCrit.Sts2.Core.GameActions.GameAction> JustBeforeFinished
MegaCrit.Sts2.Core.Entities.Multiplayer.GameActionType ActionType { public abstract get; }
System.Threading.Tasks.Task CompletionTask { public get; }
System.Exception Exception { public get; }
System.Nullable<System.UInt32> Id { public get; private set; }
System.UInt64 OwnerId { public abstract get; }
System.Boolean RecordableToReplay { public virtual get; }
MegaCrit.Sts2.Core.Entities.Actions.GameActionState State { public get; private set; }
event System.Action<MegaCrit.Sts2.Core.GameActions.GameAction> AfterFinished
event System.Action<MegaCrit.Sts2.Core.GameActions.GameAction> BeforeCancelled
event System.Action<MegaCrit.Sts2.Core.GameActions.GameAction> BeforeExecuted
event System.Action<MegaCrit.Sts2.Core.GameActions.GameAction> BeforePausedForPlayerChoice
event System.Action<MegaCrit.Sts2.Core.GameActions.GameAction> BeforeReadyToResumeAfterPlayerChoice
event System.Action<MegaCrit.Sts2.Core.GameActions.GameAction> BeforeResumedAfterPlayerChoice
event System.Action<MegaCrit.Sts2.Core.GameActions.GameAction> JustBeforeFinished
private static .cctor()
protected .ctor()
private System.Boolean <Cancel>b__50_0()
private System.Void set_Id(System.Nullable<System.UInt32> value)
private System.Void set_State(MegaCrit.Sts2.Core.Entities.Actions.GameActionState value)
protected abstract System.Threading.Tasks.Task ExecuteAction()
protected virtual System.Void CancelAction()
public [async] System.Threading.Tasks.Task Execute()
public [async] System.Threading.Tasks.Task WaitForActionToResumeExecutingAfterPlayerChoice()
public abstract MegaCrit.Sts2.Core.Entities.Multiplayer.GameActionType get_ActionType()
public abstract MegaCrit.Sts2.Core.GameActions.Multiplayer.INetAction ToNetAction()
public abstract System.UInt64 get_OwnerId()
public MegaCrit.Sts2.Core.Entities.Actions.GameActionState get_State()
public System.Exception get_Exception()
public System.Nullable<System.UInt32> get_Id()
public System.Threading.Tasks.Task get_CompletionTask()
public System.Void add_AfterFinished(System.Action<MegaCrit.Sts2.Core.GameActions.GameAction> value)
public System.Void add_BeforeCancelled(System.Action<MegaCrit.Sts2.Core.GameActions.GameAction> value)
public System.Void add_BeforeExecuted(System.Action<MegaCrit.Sts2.Core.GameActions.GameAction> value)
public System.Void add_BeforePausedForPlayerChoice(System.Action<MegaCrit.Sts2.Core.GameActions.GameAction> value)
public System.Void add_BeforeReadyToResumeAfterPlayerChoice(System.Action<MegaCrit.Sts2.Core.GameActions.GameAction> value)
public System.Void add_BeforeResumedAfterPlayerChoice(System.Action<MegaCrit.Sts2.Core.GameActions.GameAction> value)
public System.Void add_JustBeforeFinished(System.Action<MegaCrit.Sts2.Core.GameActions.GameAction> value)
public System.Void Cancel()
public System.Void OnEnqueued(System.Action<MegaCrit.Sts2.Core.GameActions.GameAction> afterFinished, System.UInt32 id)
public System.Void PauseForPlayerChoice()
public System.Void remove_AfterFinished(System.Action<MegaCrit.Sts2.Core.GameActions.GameAction> value)
public System.Void remove_BeforeCancelled(System.Action<MegaCrit.Sts2.Core.GameActions.GameAction> value)
public System.Void remove_BeforeExecuted(System.Action<MegaCrit.Sts2.Core.GameActions.GameAction> value)
public System.Void remove_BeforePausedForPlayerChoice(System.Action<MegaCrit.Sts2.Core.GameActions.GameAction> value)
public System.Void remove_BeforeReadyToResumeAfterPlayerChoice(System.Action<MegaCrit.Sts2.Core.GameActions.GameAction> value)
public System.Void remove_BeforeResumedAfterPlayerChoice(System.Action<MegaCrit.Sts2.Core.GameActions.GameAction> value)
public System.Void remove_JustBeforeFinished(System.Action<MegaCrit.Sts2.Core.GameActions.GameAction> value)
public System.Void ResumeAfterGatheringPlayerChoice(System.UInt32 newId)
public virtual System.Boolean get_RecordableToReplay()
```

## MegaCrit.Sts2.Core.GameActions.GameAction+<Execute>d__45

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.GameActions.GameAction <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.GameActions.GameAction+<WaitForActionToResumeExecutingAfterPlayerChoice>d__47

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.GameActions.GameAction <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.GameActions.GenericHookGameAction

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.GameActions.GameAction`。

接口：

```text
private readonly System.Threading.Tasks.TaskCompletionSource _choiceContextSetSource
private readonly System.Threading.Tasks.TaskCompletionSource _executionStartedSource
private readonly MegaCrit.Sts2.Core.Entities.Multiplayer.GameActionType _gameActionType
private MegaCrit.Sts2.Core.GameActions.Multiplayer.HookPlayerChoiceContext <ChoiceContext>k__BackingField
private readonly System.UInt32 <HookId>k__BackingField
private readonly System.UInt64 <OwnerId>k__BackingField
public System.Threading.Tasks.Task debugArtificialDelayAfterTask
MegaCrit.Sts2.Core.Entities.Multiplayer.GameActionType ActionType { public virtual get; }
MegaCrit.Sts2.Core.GameActions.Multiplayer.HookPlayerChoiceContext ChoiceContext { public get; private set; }
System.Threading.Tasks.Task ExecutionStartedTask { public get; }
System.UInt32 HookId { public get; }
System.UInt64 OwnerId { public virtual get; }
System.Boolean RecordableToReplay { public virtual get; }
public .ctor(System.UInt32 hookId, System.UInt64 ownerId, MegaCrit.Sts2.Core.Entities.Multiplayer.GameActionType gameActionType)
private System.Void set_ChoiceContext(MegaCrit.Sts2.Core.GameActions.Multiplayer.HookPlayerChoiceContext value)
protected virtual [async] System.Threading.Tasks.Task ExecuteAction()
public MegaCrit.Sts2.Core.GameActions.Multiplayer.HookPlayerChoiceContext get_ChoiceContext()
public System.Threading.Tasks.Task get_ExecutionStartedTask()
public System.UInt32 get_HookId()
public System.Void SetChoiceContext(MegaCrit.Sts2.Core.GameActions.Multiplayer.HookPlayerChoiceContext choiceContext)
public virtual MegaCrit.Sts2.Core.Entities.Multiplayer.GameActionType get_ActionType()
public virtual MegaCrit.Sts2.Core.GameActions.Multiplayer.INetAction ToNetAction()
public virtual System.Boolean get_RecordableToReplay()
public virtual System.String ToString()
public virtual System.UInt64 get_OwnerId()
```

## MegaCrit.Sts2.Core.GameActions.GenericHookGameAction+<ExecuteAction>d__22

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.GameActions.GenericHookGameAction <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.GameActions.MoveToMapCoordAction

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.GameActions.GameAction`。

接口：

```text
private readonly MegaCrit.Sts2.Core.Map.MapCoord _destination
private readonly MegaCrit.Sts2.Core.Entities.Players.Player _player
MegaCrit.Sts2.Core.Entities.Multiplayer.GameActionType ActionType { public virtual get; }
System.UInt64 OwnerId { public virtual get; }
public .ctor(MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.Map.MapCoord destination)
protected virtual [async] System.Threading.Tasks.Task ExecuteAction()
public virtual MegaCrit.Sts2.Core.Entities.Multiplayer.GameActionType get_ActionType()
public virtual MegaCrit.Sts2.Core.GameActions.Multiplayer.INetAction ToNetAction()
public virtual System.String ToString()
public virtual System.UInt64 get_OwnerId()
```

## MegaCrit.Sts2.Core.GameActions.MoveToMapCoordAction+<ExecuteAction>d__7

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.GameActions.MoveToMapCoordAction <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.GameActions.NetDiscardPotionGameAction

类型属性：`Public, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`MegaCrit.Sts2.Core.GameActions.Multiplayer.INetAction`, `MegaCrit.Sts2.Core.Multiplayer.Serialization.IPacketSerializable`

```text
public System.UInt32 potionSlotIndex
public System.Boolean wasEnqueuedInCombat
public virtual MegaCrit.Sts2.Core.GameActions.GameAction ToGameAction(MegaCrit.Sts2.Core.Entities.Players.Player player)
public virtual System.String ToString()
public virtual System.Void Deserialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketReader reader)
public virtual System.Void Serialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketWriter writer)
```

## MegaCrit.Sts2.Core.GameActions.NetEndPlayerTurnAction

类型属性：`Public, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`MegaCrit.Sts2.Core.GameActions.Multiplayer.INetAction`, `MegaCrit.Sts2.Core.Multiplayer.Serialization.IPacketSerializable`

```text
public System.Int32 turnNumber
public virtual MegaCrit.Sts2.Core.GameActions.GameAction ToGameAction(MegaCrit.Sts2.Core.Entities.Players.Player player)
public virtual System.String ToString()
public virtual System.Void Deserialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketReader reader)
public virtual System.Void Serialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketWriter writer)
```

## MegaCrit.Sts2.Core.GameActions.NetMoveToMapCoordAction

类型属性：`Public, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`MegaCrit.Sts2.Core.GameActions.Multiplayer.INetAction`, `MegaCrit.Sts2.Core.Multiplayer.Serialization.IPacketSerializable`

```text
public MegaCrit.Sts2.Core.Map.MapCoord destination
public virtual MegaCrit.Sts2.Core.GameActions.GameAction ToGameAction(MegaCrit.Sts2.Core.Entities.Players.Player player)
public virtual System.String ToString()
public virtual System.Void Deserialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketReader reader)
public virtual System.Void Serialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketWriter writer)
```

## MegaCrit.Sts2.Core.GameActions.NetPickRelicAction

类型属性：`Public, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`MegaCrit.Sts2.Core.GameActions.Multiplayer.INetAction`, `MegaCrit.Sts2.Core.Multiplayer.Serialization.IPacketSerializable`

```text
public System.Nullable<System.Int32> relicIndex
public virtual MegaCrit.Sts2.Core.GameActions.GameAction ToGameAction(MegaCrit.Sts2.Core.Entities.Players.Player player)
public virtual System.String ToString()
public virtual System.Void Deserialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketReader reader)
public virtual System.Void Serialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketWriter writer)
```

## MegaCrit.Sts2.Core.GameActions.NetPlayCardAction

类型属性：`Public, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`MegaCrit.Sts2.Core.GameActions.Multiplayer.INetAction`, `MegaCrit.Sts2.Core.Multiplayer.Serialization.IPacketSerializable`

```text
public MegaCrit.Sts2.Core.Entities.Multiplayer.NetCombatCard card
public MegaCrit.Sts2.Core.Models.ModelId modelId
public System.Nullable<System.UInt32> targetId
public virtual MegaCrit.Sts2.Core.GameActions.GameAction ToGameAction(MegaCrit.Sts2.Core.Entities.Players.Player player)
public virtual System.String ToString()
public virtual System.Void Deserialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketReader reader)
public virtual System.Void Serialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketWriter writer)
```

## MegaCrit.Sts2.Core.GameActions.NetReadyToBeginEnemyTurnAction

类型属性：`Public, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`MegaCrit.Sts2.Core.GameActions.Multiplayer.INetAction`, `MegaCrit.Sts2.Core.Multiplayer.Serialization.IPacketSerializable`

```text
public virtual MegaCrit.Sts2.Core.GameActions.GameAction ToGameAction(MegaCrit.Sts2.Core.Entities.Players.Player player)
public virtual System.String ToString()
public virtual System.Void Deserialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketReader deserializer)
public virtual System.Void Serialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketWriter serializer)
```

## MegaCrit.Sts2.Core.GameActions.NetUndoEndPlayerTurnAction

类型属性：`Public, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`MegaCrit.Sts2.Core.GameActions.Multiplayer.INetAction`, `MegaCrit.Sts2.Core.Multiplayer.Serialization.IPacketSerializable`

```text
public System.Int32 turnNumber
public virtual MegaCrit.Sts2.Core.GameActions.GameAction ToGameAction(MegaCrit.Sts2.Core.Entities.Players.Player player)
public virtual System.String ToString()
public virtual System.Void Deserialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketReader reader)
public virtual System.Void Serialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketWriter writer)
```

## MegaCrit.Sts2.Core.GameActions.NetUsePotionAction

类型属性：`Public, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`MegaCrit.Sts2.Core.GameActions.Multiplayer.INetAction`, `MegaCrit.Sts2.Core.Multiplayer.Serialization.IPacketSerializable`

```text
public System.Boolean enqueuedInCombat
public System.UInt32 potionIndex
public System.Nullable<System.UInt32> targetId
public System.Nullable<System.UInt64> targetPlayerId
public virtual MegaCrit.Sts2.Core.GameActions.GameAction ToGameAction(MegaCrit.Sts2.Core.Entities.Players.Player player)
public virtual System.String ToString()
public virtual System.Void Deserialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketReader reader)
public virtual System.Void Serialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketWriter writer)
```

## MegaCrit.Sts2.Core.GameActions.NetVoteForMapCoordAction

类型属性：`Public, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`MegaCrit.Sts2.Core.GameActions.Multiplayer.INetAction`, `MegaCrit.Sts2.Core.Multiplayer.Serialization.IPacketSerializable`

```text
public System.Nullable<MegaCrit.Sts2.Core.Multiplayer.Game.MapVote> destination
public MegaCrit.Sts2.Core.Runs.MapLocation source
public virtual MegaCrit.Sts2.Core.GameActions.GameAction ToGameAction(MegaCrit.Sts2.Core.Entities.Players.Player player)
public virtual System.String ToString()
public virtual System.Void Deserialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketReader reader)
public virtual System.Void Serialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketWriter writer)
```

## MegaCrit.Sts2.Core.GameActions.NetVoteToMoveToNextActAction

类型属性：`Public, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`MegaCrit.Sts2.Core.GameActions.Multiplayer.INetAction`, `MegaCrit.Sts2.Core.Multiplayer.Serialization.IPacketSerializable`

```text
public System.Int32 currentActIndex
public virtual MegaCrit.Sts2.Core.GameActions.GameAction ToGameAction(MegaCrit.Sts2.Core.Entities.Players.Player player)
public virtual System.String ToString()
public virtual System.Void Deserialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketReader reader)
public virtual System.Void Serialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketWriter writer)
```

## MegaCrit.Sts2.Core.GameActions.PickRelicAction

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.GameActions.GameAction`。

接口：

```text
private readonly MegaCrit.Sts2.Core.Entities.Players.Player _player
private readonly System.Nullable<System.Int32> _relicIndex
private MegaCrit.Sts2.Core.Multiplayer.Game.TreasureRoomRelicSynchronizer <TestSynchronizer>k__BackingField
MegaCrit.Sts2.Core.Entities.Multiplayer.GameActionType ActionType { public virtual get; }
System.UInt64 OwnerId { public virtual get; }
MegaCrit.Sts2.Core.Multiplayer.Game.TreasureRoomRelicSynchronizer TestSynchronizer { public get; public set; }
public .ctor(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Nullable<System.Int32> relicIndex)
protected virtual System.Threading.Tasks.Task ExecuteAction()
public MegaCrit.Sts2.Core.Multiplayer.Game.TreasureRoomRelicSynchronizer get_TestSynchronizer()
public System.Void set_TestSynchronizer(MegaCrit.Sts2.Core.Multiplayer.Game.TreasureRoomRelicSynchronizer value)
public virtual MegaCrit.Sts2.Core.Entities.Multiplayer.GameActionType get_ActionType()
public virtual MegaCrit.Sts2.Core.GameActions.Multiplayer.INetAction ToNetAction()
public virtual System.String ToString()
public virtual System.UInt64 get_OwnerId()
```

## MegaCrit.Sts2.Core.GameActions.PlayCardAction

类型属性：`Public, Sealed, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.GameActions.GameAction`。

接口：

```text
private MegaCrit.Sts2.Core.Models.CardModel _card
private readonly MegaCrit.Sts2.Core.Models.ModelId <CardModelId>k__BackingField
private readonly MegaCrit.Sts2.Core.Entities.Multiplayer.NetCombatCard <NetCombatCard>k__BackingField
private readonly MegaCrit.Sts2.Core.Entities.Players.Player <Player>k__BackingField
private MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext <PlayerChoiceContext>k__BackingField
private readonly System.Nullable<System.UInt32> <TargetId>k__BackingField
MegaCrit.Sts2.Core.Entities.Multiplayer.GameActionType ActionType { public virtual get; }
MegaCrit.Sts2.Core.Models.ModelId CardModelId { public get; }
MegaCrit.Sts2.Core.Entities.Multiplayer.NetCombatCard NetCombatCard { public get; }
System.UInt64 OwnerId { public virtual get; }
MegaCrit.Sts2.Core.Entities.Players.Player Player { public get; }
MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext PlayerChoiceContext { public get; private set; }
MegaCrit.Sts2.Core.Entities.Creatures.Creature Target { public get; }
System.Nullable<System.UInt32> TargetId { public get; }
public .ctor(MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.Entities.Multiplayer.NetCombatCard netCombatCard, MegaCrit.Sts2.Core.Models.ModelId cardModelId, System.Nullable<System.UInt32> targetId)
public .ctor(MegaCrit.Sts2.Core.Models.CardModel cardModel, MegaCrit.Sts2.Core.Entities.Creatures.Creature target)
private System.Void set_PlayerChoiceContext(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext value)
protected virtual [async] System.Threading.Tasks.Task ExecuteAction()
protected virtual System.Void CancelAction()
public MegaCrit.Sts2.Core.Entities.Creatures.Creature get_Target()
public MegaCrit.Sts2.Core.Entities.Multiplayer.NetCombatCard get_NetCombatCard()
public MegaCrit.Sts2.Core.Entities.Players.Player get_Player()
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext get_PlayerChoiceContext()
public MegaCrit.Sts2.Core.Models.ModelId get_CardModelId()
public System.Nullable<System.UInt32> get_TargetId()
public virtual MegaCrit.Sts2.Core.Entities.Multiplayer.GameActionType get_ActionType()
public virtual MegaCrit.Sts2.Core.GameActions.Multiplayer.INetAction ToNetAction()
public virtual System.String ToString()
public virtual System.UInt64 get_OwnerId()
```

## MegaCrit.Sts2.Core.GameActions.PlayCardAction+<ExecuteAction>d__25

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.GameActions.PlayCardAction <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Entities.Creatures.Creature> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<System.ValueTuple<System.Int32, System.Int32>> <>u__2
private System.Runtime.CompilerServices.TaskAwaiter <>u__3
private MegaCrit.Sts2.Core.Entities.Creatures.Creature <target>5__2
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.CardModel> _canonicalCards
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.CardModel> _combatCards
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.CardModel> _deckCards
private System.Collections.Generic.List<System.Int32> _indexes
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.CardModel> _mutableCards
private System.Nullable<System.UInt64> _playerId
private readonly MegaCrit.Sts2.Core.Entities.Models.PlayerChoiceType <ChoiceType>k__BackingField
MegaCrit.Sts2.Core.Entities.Models.PlayerChoiceType ChoiceType { public get; private set; }
public .ctor()
private System.Void set_ChoiceType(MegaCrit.Sts2.Core.Entities.Models.PlayerChoiceType value)
public MegaCrit.Sts2.Core.Entities.Models.PlayerChoiceType get_ChoiceType()
public MegaCrit.Sts2.Core.Entities.Multiplayer.NetPlayerChoiceResult ToNetData()
public MegaCrit.Sts2.Core.Models.CardModel AsCanonicalCard()
public MegaCrit.Sts2.Core.Models.CardModel AsMutableCard()
public static MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult FromCanonicalCard(MegaCrit.Sts2.Core.Models.CardModel canonicalCard)
public static MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult FromCanonicalCards(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> canonicalCards)
public static MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult FromCards(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> cards, MegaCrit.Sts2.Core.Entities.Models.PlayerChoiceType choiceType)
public static MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult FromIndex(System.Nullable<System.Int32> index)
public static MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult FromIndexes(System.Collections.Generic.List<System.Int32> indexes)
public static MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult FromMutableCard(MegaCrit.Sts2.Core.Models.CardModel mutableCard)
public static MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult FromMutableCards(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> mutableCards)
public static MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult FromMutableCombatCard(MegaCrit.Sts2.Core.Models.CardModel combatCard)
public static MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult FromMutableCombatCards(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> combatCards)
public static MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult FromMutableDeckCard(MegaCrit.Sts2.Core.Models.CardModel deckCard)
public static MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult FromMutableDeckCards(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> deckCards)
public static MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult FromNetData(MegaCrit.Sts2.Core.Entities.Players.Player sender, MegaCrit.Sts2.Core.Runs.IPlayerCollection players, MegaCrit.Sts2.Core.Entities.Multiplayer.NetPlayerChoiceResult netData)
public static MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult FromPlayerId(System.Nullable<System.UInt64> playerId)
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> AsCanonicalCards()
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> AsCards(MegaCrit.Sts2.Core.Entities.Models.PlayerChoiceType type)
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> AsCombatCards()
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> AsDeckCards()
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> AsMutableCards()
public System.Collections.Generic.List<System.Int32> AsIndexes()
public System.Int32 AsIndex()
public System.Nullable<System.Int32> AsIndexOrNull()
public System.Nullable<System.UInt64> AsPlayerId()
public virtual System.String ToString()
```

## MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Entities.Multiplayer.NetCombatCard, MegaCrit.Sts2.Core.Models.CardModel> <>9__33_0
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, MegaCrit.Sts2.Core.Saves.Runs.SerializableCard> <>9__34_0
private static .cctor()
public .ctor()
internal MegaCrit.Sts2.Core.Models.CardModel <FromNetData>b__33_0(MegaCrit.Sts2.Core.Entities.Multiplayer.NetCombatCard c)
internal MegaCrit.Sts2.Core.Saves.Runs.SerializableCard <ToNetData>b__34_0(MegaCrit.Sts2.Core.Models.CardModel c)
```

## MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult+<>c__DisplayClass33_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Entities.Players.Player sender
public .ctor()
internal MegaCrit.Sts2.Core.Models.CardModel <FromNetData>b__1(MegaCrit.Sts2.Core.Entities.Multiplayer.NetDeckCard c)
```

## MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult+<>O

类型属性：`NestedPrivate, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static System.Func<MegaCrit.Sts2.Core.Saves.Runs.SerializableCard, MegaCrit.Sts2.Core.Models.CardModel> <0>__FromSerializable
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, MegaCrit.Sts2.Core.Entities.Multiplayer.NetCombatCard> <1>__FromModel
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, MegaCrit.Sts2.Core.Entities.Multiplayer.NetDeckCard> <2>__FromModel
```

## MegaCrit.Sts2.Core.GameActions.ReadyToBeginEnemyTurnAction

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.GameActions.GameAction`。

接口：

```text
private readonly System.Func<System.Threading.Tasks.Task> _actionDuringEnemyTurn
private readonly MegaCrit.Sts2.Core.Entities.Players.Player _player
MegaCrit.Sts2.Core.Entities.Multiplayer.GameActionType ActionType { public virtual get; }
System.UInt64 OwnerId { public virtual get; }
public .ctor(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Func<System.Threading.Tasks.Task> actionDuringEnemyTurn = null)
protected virtual System.Threading.Tasks.Task ExecuteAction()
protected virtual System.Void CancelAction()
public virtual MegaCrit.Sts2.Core.Entities.Multiplayer.GameActionType get_ActionType()
public virtual MegaCrit.Sts2.Core.GameActions.Multiplayer.INetAction ToNetAction()
public virtual System.String ToString()
public virtual System.UInt64 get_OwnerId()
```

## MegaCrit.Sts2.Core.GameActions.UndoEndPlayerTurnAction

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.GameActions.GameAction`。

接口：

```text
private readonly MegaCrit.Sts2.Core.Entities.Players.Player _player
private readonly System.Int32 _turnNumber
MegaCrit.Sts2.Core.Entities.Multiplayer.GameActionType ActionType { public virtual get; }
System.UInt64 OwnerId { public virtual get; }
public .ctor(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Int32 turnNumber)
protected virtual System.Threading.Tasks.Task ExecuteAction()
public virtual MegaCrit.Sts2.Core.Entities.Multiplayer.GameActionType get_ActionType()
public virtual MegaCrit.Sts2.Core.GameActions.Multiplayer.INetAction ToNetAction()
public virtual System.String ToString()
public virtual System.UInt64 get_OwnerId()
```

## MegaCrit.Sts2.Core.GameActions.UsePotionAction

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.GameActions.GameAction`。

接口：

```text
private readonly MegaCrit.Sts2.Core.Entities.Players.Player <Player>k__BackingField
private MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext <PlayerChoiceContext>k__BackingField
private readonly System.UInt32 <PotionIndex>k__BackingField
private readonly System.Nullable<System.UInt32> <TargetId>k__BackingField
private readonly System.Nullable<System.UInt64> <TargetPlayerId>k__BackingField
private readonly System.Boolean <WasEnqueuedInCombat>k__BackingField
MegaCrit.Sts2.Core.Entities.Multiplayer.GameActionType ActionType { public virtual get; }
System.UInt64 OwnerId { public virtual get; }
MegaCrit.Sts2.Core.Entities.Players.Player Player { public get; }
MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext PlayerChoiceContext { public get; private set; }
System.UInt32 PotionIndex { public get; }
System.Nullable<System.UInt32> TargetId { public get; }
System.Nullable<System.UInt64> TargetPlayerId { private get; }
System.Boolean WasEnqueuedInCombat { public get; }
public .ctor(MegaCrit.Sts2.Core.Entities.Players.Player player, System.UInt32 potionIndex, System.Nullable<System.UInt32> targetId, System.Nullable<System.UInt64> targetPlayerId, System.Boolean isCombatInProgress)
public .ctor(MegaCrit.Sts2.Core.Models.PotionModel potion, MegaCrit.Sts2.Core.Entities.Creatures.Creature target, System.Boolean isCombatInProgress)
private System.Nullable<System.UInt64> get_TargetPlayerId()
private System.Void set_PlayerChoiceContext(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext value)
protected virtual [async] System.Threading.Tasks.Task ExecuteAction()
protected virtual System.Void CancelAction()
public MegaCrit.Sts2.Core.Entities.Players.Player get_Player()
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext get_PlayerChoiceContext()
public System.Boolean get_WasEnqueuedInCombat()
public System.Nullable<System.UInt32> get_TargetId()
public System.UInt32 get_PotionIndex()
public virtual MegaCrit.Sts2.Core.Entities.Multiplayer.GameActionType get_ActionType()
public virtual MegaCrit.Sts2.Core.GameActions.Multiplayer.INetAction ToNetAction()
public virtual System.String ToString()
public virtual System.UInt64 get_OwnerId()
```

## MegaCrit.Sts2.Core.GameActions.UsePotionAction+<ExecuteAction>d__25

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.GameActions.UsePotionAction <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Entities.Creatures.Creature> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
private MegaCrit.Sts2.Core.Models.PotionModel <potion>5__2
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.GameActions.VoteForMapCoordAction

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.GameActions.GameAction`。

接口：

```text
private readonly System.Nullable<MegaCrit.Sts2.Core.Multiplayer.Game.MapVote> _destination
private readonly MegaCrit.Sts2.Core.Entities.Players.Player _player
private readonly MegaCrit.Sts2.Core.Runs.MapLocation _source
MegaCrit.Sts2.Core.Entities.Multiplayer.GameActionType ActionType { public virtual get; }
System.UInt64 OwnerId { public virtual get; }
public .ctor(MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.Runs.MapLocation source, System.Nullable<MegaCrit.Sts2.Core.Multiplayer.Game.MapVote> destination)
protected virtual System.Threading.Tasks.Task ExecuteAction()
public virtual MegaCrit.Sts2.Core.Entities.Multiplayer.GameActionType get_ActionType()
public virtual MegaCrit.Sts2.Core.GameActions.Multiplayer.INetAction ToNetAction()
public virtual System.String ToString()
public virtual System.UInt64 get_OwnerId()
```

## MegaCrit.Sts2.Core.GameActions.VoteToMoveToNextActAction

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.GameActions.GameAction`。

接口：

```text
private readonly MegaCrit.Sts2.Core.Entities.Players.Player _player
private readonly System.Int32 <CurrentActIndex>k__BackingField
MegaCrit.Sts2.Core.Entities.Multiplayer.GameActionType ActionType { public virtual get; }
System.Int32 CurrentActIndex { public get; }
System.UInt64 OwnerId { public virtual get; }
public .ctor(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Int32 currentActIndex)
protected virtual System.Threading.Tasks.Task ExecuteAction()
public System.Int32 get_CurrentActIndex()
public virtual MegaCrit.Sts2.Core.Entities.Multiplayer.GameActionType get_ActionType()
public virtual MegaCrit.Sts2.Core.GameActions.Multiplayer.INetAction ToNetAction()
public virtual System.String ToString()
public virtual System.UInt64 get_OwnerId()
```
