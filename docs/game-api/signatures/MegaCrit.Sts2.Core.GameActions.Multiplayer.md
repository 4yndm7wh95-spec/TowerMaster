# MegaCrit.Sts2.Core.GameActions.Multiplayer

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSet

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSet+ActionQueue> _actionQueues
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSet+ActionWaitingForResumption> _actionsWaitingForResumption
private System.Boolean _isInCombat
private readonly MegaCrit.Sts2.Core.Logging.Logger _logger
private System.UInt32 _nextId
private System.Threading.Tasks.TaskCompletionSource _queuesEmptyCompletionSource
private System.Boolean _wasReset
private System.Action<MegaCrit.Sts2.Core.GameActions.GameAction> ActionEnqueued
private System.Action ActionQueueChanged
private System.Action<System.UInt32> ActionResumed
System.Boolean IsEmpty { public get; }
System.UInt32 NextActionId { public get; }
event System.Action<MegaCrit.Sts2.Core.GameActions.GameAction> ActionEnqueued
event System.Action ActionQueueChanged
event System.Action<System.UInt32> ActionResumed
public .ctor(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Players.Player> players)
private MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSet+ActionQueue GetQueue(System.UInt64 playerId)
private System.Boolean TryGetAction(System.UInt32 id, out MegaCrit.Sts2.Core.GameActions.GameAction gameAction, out MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSet+ActionQueue queue)
private System.UInt32 GetAndIncrementActionId()
private System.Void CancelNonExecutingActionsOfType<T>(System.UInt64 ownerId, System.Nullable<System.UInt32> maxActionId) where T: [None] MegaCrit.Sts2.Core.GameActions.GameAction
private System.Void CheckIfQueuesEmpty()
private System.Void PopAction(MegaCrit.Sts2.Core.GameActions.GameAction action)
public MegaCrit.Sts2.Core.GameActions.GameAction GetReadyAction()
public static System.Boolean IsGameActionPlayerDriven(MegaCrit.Sts2.Core.GameActions.GameAction gameAction)
public System.Boolean ActionQueueIsPaused(System.UInt64 playerId)
public System.Boolean get_IsEmpty()
public System.Threading.Tasks.Task BecameEmpty()
public System.UInt32 get_NextActionId()
public System.Void add_ActionEnqueued(System.Action<MegaCrit.Sts2.Core.GameActions.GameAction> value)
public System.Void add_ActionQueueChanged(System.Action value)
public System.Void add_ActionResumed(System.Action<System.UInt32> value)
public System.Void CancelNonExecutingActionsForPlayer(System.UInt64 playerId)
public System.Void CombatEnded()
public System.Void CombatStarted()
public System.Void EnqueueWithoutSynchronizing(MegaCrit.Sts2.Core.GameActions.GameAction gameAction)
public System.Void FastForwardNextActionId(System.UInt32 nextId)
public System.Void PauseActionForPlayerChoice(MegaCrit.Sts2.Core.GameActions.GameAction action, MegaCrit.Sts2.Core.Entities.Multiplayer.PlayerChoiceOptions options)
public System.Void PauseAllPlayerQueues()
public System.Void remove_ActionEnqueued(System.Action<MegaCrit.Sts2.Core.GameActions.GameAction> value)
public System.Void remove_ActionQueueChanged(System.Action value)
public System.Void remove_ActionResumed(System.Action<System.UInt32> value)
public System.Void Reset()
public System.Void ResumeActionWithoutSynchronizing(System.UInt32 id)
public System.Void SetUpForCombat()
public System.Void StartCancellingAllPlayerDrivenCombatActions()
public System.Void UnpauseAllPlayerQueues()
```

## MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSet+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSet+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSet+ActionQueue, System.Boolean> <>9__43_0
private static .cctor()
public .ctor()
internal System.Boolean <CheckIfQueuesEmpty>b__43_0(MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSet+ActionQueue q)
```

## MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSet+<>c__DisplayClass40_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.UInt64 playerId
public .ctor()
internal System.Boolean <GetQueue>b__0(MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSet+ActionQueue q)
```

## MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSet+ActionQueue

类型属性：`NestedPrivate, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.GameActions.GameAction actionCancellingPlayCardActions
public System.Collections.Generic.List<MegaCrit.Sts2.Core.GameActions.GameAction> actions
public System.Boolean isCancellingCombatActions
public System.Boolean isCancellingPlayerDrivenCombatActions
public System.Boolean isPaused
public System.UInt64 ownerId
System.Boolean IsCancellingPlayCardActions { public get; }
public .ctor()
public System.Boolean get_IsCancellingPlayCardActions()
```

## MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSet+ActionWaitingForResumption

类型属性：`NestedPrivate, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：

```text
public System.UInt32 newId
public System.UInt32 oldId
```

## MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSynchronizer

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private readonly MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSet _actionQueueSet
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.GameActions.GenericHookGameAction> _hookActions
private readonly MegaCrit.Sts2.Core.Logging.Logger _logger
private readonly MegaCrit.Sts2.Core.Multiplayer.Game.RunLocationTargetedMessageBuffer _messageBuffer
private readonly MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService _netService
private System.UInt32 _nextHookId
private readonly MegaCrit.Sts2.Core.Runs.IPlayerCollection _playerCollection
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.GameActions.GameAction> _requestedActionsWaitingForPlayerTurn
private MegaCrit.Sts2.Core.Entities.Multiplayer.ActionSynchronizerCombatState <CombatState>k__BackingField
MegaCrit.Sts2.Core.Entities.Multiplayer.ActionSynchronizerCombatState CombatState { public get; private set; }
System.UInt32 NextHookId { public get; }
public .ctor(MegaCrit.Sts2.Core.Runs.IPlayerCollection players, MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSet actionQueueSet, MegaCrit.Sts2.Core.Multiplayer.Game.RunLocationTargetedMessageBuffer messageBuffer, MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService netService)
private MegaCrit.Sts2.Core.GameActions.GameAction NetActionToGameAction(MegaCrit.Sts2.Core.GameActions.Multiplayer.INetAction action, System.UInt64 actionOwnerId)
private System.Void EnqueueAction(MegaCrit.Sts2.Core.GameActions.GameAction action, System.UInt64 actionOwnerId)
private System.Void EnqueueHookAction(MegaCrit.Sts2.Core.GameActions.GenericHookGameAction gameAction)
private System.Void HandleActionEnqueuedMessage(MegaCrit.Sts2.Core.Multiplayer.Messages.Game.ActionEnqueuedMessage message, System.UInt64 _)
private System.Void HandleHookActionEnqueuedMessage(MegaCrit.Sts2.Core.Multiplayer.Messages.Game.HookActionEnqueuedMessage message, System.UInt64 _)
private System.Void HandleRequestEnqueueActionMessage(MegaCrit.Sts2.Core.Multiplayer.Messages.Game.RequestEnqueueActionMessage message, System.UInt64 senderId)
private System.Void HandleRequestEnqueueHookActionMessage(MegaCrit.Sts2.Core.Multiplayer.Messages.Game.RequestEnqueueHookActionMessage message, System.UInt64 senderId)
private System.Void HandleRequestResumeActionAfterPlayerChoiceMessage(MegaCrit.Sts2.Core.Multiplayer.Messages.Game.RequestResumeActionAfterPlayerChoiceMessage afterPlayerChoiceMessage, System.UInt64 senderId)
private System.Void HandleResumeActionAfterPlayerChoiceMessage(MegaCrit.Sts2.Core.Multiplayer.Messages.Game.ResumeActionAfterPlayerChoiceMessage afterPlayerChoiceMessage, System.UInt64 _)
private System.Void HookActionStarted(MegaCrit.Sts2.Core.GameActions.GenericHookGameAction action)
private System.Void ResumeActionAfterPlayerChoice(System.UInt32 id)
private System.Void set_CombatState(MegaCrit.Sts2.Core.Entities.Multiplayer.ActionSynchronizerCombatState value)
public MegaCrit.Sts2.Core.Entities.Multiplayer.ActionSynchronizerCombatState get_CombatState()
public MegaCrit.Sts2.Core.GameActions.GenericHookGameAction GenerateHookAction(System.UInt64 ownerId, MegaCrit.Sts2.Core.Entities.Multiplayer.GameActionType gameActionType)
public MegaCrit.Sts2.Core.GameActions.GenericHookGameAction GetHookActionForId(System.UInt32 id, System.UInt64 ownerId, MegaCrit.Sts2.Core.Entities.Multiplayer.GameActionType gameActionType)
public System.UInt32 get_NextHookId()
public System.Void Dispose()
public System.Void FastForwardHookId(System.UInt32 hookId)
public System.Void RequestEnqueue(MegaCrit.Sts2.Core.GameActions.GameAction action)
public System.Void RequestEnqueueHookAction(MegaCrit.Sts2.Core.GameActions.GenericHookGameAction action)
public System.Void RequestResumeActionAfterPlayerChoice(MegaCrit.Sts2.Core.GameActions.GameAction action)
public System.Void SetCombatState(MegaCrit.Sts2.Core.Entities.Multiplayer.ActionSynchronizerCombatState combatState)
```

## MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSynchronizer+<>c__DisplayClass31_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSynchronizer <>4__this
public MegaCrit.Sts2.Core.GameActions.GenericHookGameAction action
public System.UInt32 id
public .ctor()
internal System.Boolean <GetHookActionForId>b__0(MegaCrit.Sts2.Core.GameActions.GenericHookGameAction a)
internal System.Void <GetHookActionForId>b__1(System.Threading.Tasks.Task _)
```

## MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionTypes

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static MegaCrit.Sts2.Core.Multiplayer.Serialization.NetTypeCache<MegaCrit.Sts2.Core.GameActions.Multiplayer.INetAction> _cache
private static System.Int32 TypeToId(System.Type type)
public static System.Boolean TryGetActionType(System.Int32 id, out System.Type type)
public static System.Int32 ToId(MegaCrit.Sts2.Core.GameActions.Multiplayer.INetAction message)
public static System.Int32 TypeToId<T>() where T: [None] MegaCrit.Sts2.Core.GameActions.Multiplayer.INetAction
public static System.Void Initialize()
```

## MegaCrit.Sts2.Core.GameActions.Multiplayer.BlockingPlayerChoiceContext

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext`。

接口：

```text
System.Nullable<System.UInt64> OwnerId { public virtual get; }
public .ctor()
public virtual System.Nullable<System.UInt64> get_OwnerId()
public virtual System.Threading.Tasks.Task SignalPlayerChoiceBegun(MegaCrit.Sts2.Core.Entities.Players.Player chooser, MegaCrit.Sts2.Core.Entities.Multiplayer.PlayerChoiceOptions options)
public virtual System.Threading.Tasks.Task SignalPlayerChoiceEnded()
```

## MegaCrit.Sts2.Core.GameActions.Multiplayer.BranchingPlayerChoiceContext

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext`。

接口：

```text
private MegaCrit.Sts2.Core.GameActions.Multiplayer.HookPlayerChoiceContext _createdContext
private readonly MegaCrit.Sts2.Core.Entities.Multiplayer.GameActionType _gameActionType
private readonly System.UInt64 _localPlayerId
private MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext _originalContext
private System.Threading.Tasks.TaskCompletionSource _pausedCompletionSource
private readonly MegaCrit.Sts2.Core.Models.AbstractModel <Source>k__BackingField
private System.Action<MegaCrit.Sts2.Core.GameActions.Multiplayer.HookPlayerChoiceContext> AfterBranched
System.Nullable<System.UInt64> OwnerId { public virtual get; }
MegaCrit.Sts2.Core.Models.AbstractModel Source { public get; }
event System.Action<MegaCrit.Sts2.Core.GameActions.Multiplayer.HookPlayerChoiceContext> AfterBranched
public .ctor(MegaCrit.Sts2.Core.Models.AbstractModel source, System.UInt64 localPlayerId, MegaCrit.Sts2.Core.Entities.Multiplayer.GameActionType gameActionType, MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext existing)
public .ctor(System.UInt64 localPlayerId, MegaCrit.Sts2.Core.Entities.Multiplayer.GameActionType gameActionType, MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext existing)
public [async] System.Threading.Tasks.Task AssignTaskAndWaitForPauseOrCompletion(System.Threading.Tasks.Task task)
public MegaCrit.Sts2.Core.Models.AbstractModel get_Source()
public System.Void add_AfterBranched(System.Action<MegaCrit.Sts2.Core.GameActions.Multiplayer.HookPlayerChoiceContext> value)
public System.Void remove_AfterBranched(System.Action<MegaCrit.Sts2.Core.GameActions.Multiplayer.HookPlayerChoiceContext> value)
public virtual [async] System.Threading.Tasks.Task SignalPlayerChoiceBegun(MegaCrit.Sts2.Core.Entities.Players.Player chooser, MegaCrit.Sts2.Core.Entities.Multiplayer.PlayerChoiceOptions options)
public virtual System.Nullable<System.UInt64> get_OwnerId()
public virtual System.Threading.Tasks.Task SignalPlayerChoiceEnded()
```

## MegaCrit.Sts2.Core.GameActions.Multiplayer.BranchingPlayerChoiceContext+<AssignTaskAndWaitForPauseOrCompletion>d__16

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.GameActions.Multiplayer.BranchingPlayerChoiceContext <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__2
public System.Threading.Tasks.Task task
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.GameActions.Multiplayer.BranchingPlayerChoiceContext+<SignalPlayerChoiceBegun>d__15

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.GameActions.Multiplayer.BranchingPlayerChoiceContext <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.Entities.Players.Player chooser
public MegaCrit.Sts2.Core.Entities.Multiplayer.PlayerChoiceOptions options
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.GameActions.Multiplayer.GameActionPlayerChoiceContext

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext`。

接口：

```text
private MegaCrit.Sts2.Core.GameActions.ActionExecutor _actionExecutor
private MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSet _actionQueueSet
private MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSynchronizer _actionQueueSynchronizer
private readonly MegaCrit.Sts2.Core.GameActions.GameAction <Action>k__BackingField
MegaCrit.Sts2.Core.GameActions.GameAction Action { public get; }
MegaCrit.Sts2.Core.GameActions.ActionExecutor ActionExecutor { private get; }
MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSet ActionQueueSet { private get; }
MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSynchronizer ActionQueueSynchronizer { private get; }
System.Nullable<System.UInt64> OwnerId { public virtual get; }
public .ctor(MegaCrit.Sts2.Core.GameActions.GameAction action)
private MegaCrit.Sts2.Core.GameActions.ActionExecutor get_ActionExecutor()
private MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSet get_ActionQueueSet()
private MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSynchronizer get_ActionQueueSynchronizer()
public MegaCrit.Sts2.Core.GameActions.GameAction get_Action()
public System.Void MockDependenciesForTest(MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSynchronizer actionQueueSynchronizer, MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSet actionQueueSet, MegaCrit.Sts2.Core.GameActions.ActionExecutor actionExecutor)
public virtual [async] System.Threading.Tasks.Task SignalPlayerChoiceEnded()
public virtual System.Nullable<System.UInt64> get_OwnerId()
public virtual System.Threading.Tasks.Task SignalPlayerChoiceBegun(MegaCrit.Sts2.Core.Entities.Players.Player chooser, MegaCrit.Sts2.Core.Entities.Multiplayer.PlayerChoiceOptions options)
```

## MegaCrit.Sts2.Core.GameActions.Multiplayer.GameActionPlayerChoiceContext+<SignalPlayerChoiceEnded>d__16

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.GameActions.Multiplayer.GameActionPlayerChoiceContext <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.GameActions.Multiplayer.HookPlayerChoiceContext

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext`。

接口：

```text
private MegaCrit.Sts2.Core.GameActions.ActionExecutor _actionExecutor
private MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSet _actionQueueSet
private MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSynchronizer _actionQueueSynchronizer
private MegaCrit.Sts2.Core.GameActions.GenericHookGameAction _gameAction
private MegaCrit.Sts2.Core.Entities.Multiplayer.GameActionType _gameActionType
private readonly System.UInt64 _localPlayerId
private readonly System.Threading.Tasks.TaskCompletionSource _pausedBeforeTaskAssignedCompletionSource
private readonly System.Threading.Tasks.TaskCompletionSource _pausedCompletionSource
private readonly System.Threading.Tasks.TaskCompletionSource _taskAssignedCompletionSource
private readonly MegaCrit.Sts2.Core.Entities.Players.Player <Owner>k__BackingField
private readonly MegaCrit.Sts2.Core.Models.AbstractModel <Source>k__BackingField
private System.Threading.Tasks.Task <Task>k__BackingField
MegaCrit.Sts2.Core.GameActions.ActionExecutor ActionExecutor { private get; }
MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSet ActionQueueSet { private get; }
MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSynchronizer ActionQueueSynchronizer { private get; }
MegaCrit.Sts2.Core.GameActions.GenericHookGameAction GameAction { public get; }
MegaCrit.Sts2.Core.Entities.Players.Player Owner { public get; }
System.Nullable<System.UInt64> OwnerId { public virtual get; }
MegaCrit.Sts2.Core.Models.AbstractModel Source { public get; }
System.Threading.Tasks.Task Task { public get; private set; }
public .ctor(MegaCrit.Sts2.Core.Entities.Players.Player owner, System.UInt64 localPlayerId, MegaCrit.Sts2.Core.Entities.Multiplayer.GameActionType gameActionType)
public .ctor(MegaCrit.Sts2.Core.Models.AbstractModel source, MegaCrit.Sts2.Core.Entities.Players.Player owner, System.UInt64 localPlayerId, MegaCrit.Sts2.Core.Entities.Multiplayer.GameActionType gameActionType)
public .ctor(MegaCrit.Sts2.Core.Models.AbstractModel source, System.UInt64 localPlayerId, MegaCrit.Sts2.Core.Combat.ICombatState combatState, MegaCrit.Sts2.Core.Entities.Multiplayer.GameActionType gameActionType)
private [async] System.Threading.Tasks.Task ExecuteTaskThenInvokeExecutionFinished(System.Threading.Tasks.Task task)
private MegaCrit.Sts2.Core.GameActions.ActionExecutor get_ActionExecutor()
private MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSet get_ActionQueueSet()
private MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSynchronizer get_ActionQueueSynchronizer()
private System.Void set_Task(System.Threading.Tasks.Task value)
public [async] System.Threading.Tasks.Task WaitForCompletion()
public [async] System.Threading.Tasks.Task<System.Boolean> AssignTaskAndWaitForPauseOrCompletion(System.Threading.Tasks.Task task)
public [async] System.Threading.Tasks.Task<System.Boolean> WaitForPauseOrCompletionWithoutAssigningTask(System.Threading.Tasks.Task task)
public MegaCrit.Sts2.Core.Entities.Players.Player get_Owner()
public MegaCrit.Sts2.Core.GameActions.GenericHookGameAction get_GameAction()
public MegaCrit.Sts2.Core.Models.AbstractModel get_Source()
public static MegaCrit.Sts2.Core.Entities.Players.Player GetOwner(MegaCrit.Sts2.Core.Models.AbstractModel source, MegaCrit.Sts2.Core.Combat.ICombatState combatState)
public System.Threading.Tasks.Task get_Task()
public System.Void MockDependenciesForTest(MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSynchronizer actionQueueSynchronizer, MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSet actionQueueSet, MegaCrit.Sts2.Core.GameActions.ActionExecutor actionExecutor)
public virtual [async] System.Threading.Tasks.Task SignalPlayerChoiceBegun(MegaCrit.Sts2.Core.Entities.Players.Player chooser, MegaCrit.Sts2.Core.Entities.Multiplayer.PlayerChoiceOptions options)
public virtual [async] System.Threading.Tasks.Task SignalPlayerChoiceEnded()
public virtual System.Nullable<System.UInt64> get_OwnerId()
```

## MegaCrit.Sts2.Core.GameActions.Multiplayer.HookPlayerChoiceContext+<AssignTaskAndWaitForPauseOrCompletion>d__34

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.GameActions.Multiplayer.HookPlayerChoiceContext <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Boolean> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public System.Threading.Tasks.Task task
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.GameActions.Multiplayer.HookPlayerChoiceContext+<ExecuteTaskThenInvokeExecutionFinished>d__36

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.GameActions.Multiplayer.HookPlayerChoiceContext <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public System.Threading.Tasks.Task task
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.GameActions.Multiplayer.HookPlayerChoiceContext+<SignalPlayerChoiceBegun>d__37

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.GameActions.Multiplayer.HookPlayerChoiceContext <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.Entities.Players.Player chooser
public MegaCrit.Sts2.Core.Entities.Multiplayer.PlayerChoiceOptions options
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.GameActions.Multiplayer.HookPlayerChoiceContext+<SignalPlayerChoiceEnded>d__38

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.GameActions.Multiplayer.HookPlayerChoiceContext <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.GameActions.Multiplayer.HookPlayerChoiceContext+<WaitForCompletion>d__39

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.GameActions.Multiplayer.HookPlayerChoiceContext <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.GameActions.Multiplayer.HookPlayerChoiceContext+<WaitForPauseOrCompletionWithoutAssigningTask>d__35

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.GameActions.Multiplayer.HookPlayerChoiceContext <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Boolean> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public System.Threading.Tasks.Task task
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.GameActions.Multiplayer.INetAction

类型属性：`Public, ClassSemanticsMask, Abstract, BeforeFieldInit`；基类：`无`。

接口：`MegaCrit.Sts2.Core.Multiplayer.Serialization.IPacketSerializable`

```text
public abstract MegaCrit.Sts2.Core.GameActions.GameAction ToGameAction(MegaCrit.Sts2.Core.Entities.Players.Player player)
```

## MegaCrit.Sts2.Core.GameActions.Multiplayer.INetActionSubtypes

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static readonly System.Type[] _subtypes
private static readonly System.Type _t0
private static readonly System.Type _t1
private static readonly System.Type _t10
private static readonly System.Type _t2
private static readonly System.Type _t3
private static readonly System.Type _t4
private static readonly System.Type _t5
private static readonly System.Type _t6
private static readonly System.Type _t7
private static readonly System.Type _t8
private static readonly System.Type _t9
System.Collections.Generic.IReadOnlyList<System.Type> All { public static get; }
System.Int32 Count { public static get; }
private static .cctor()
public static System.Collections.Generic.IReadOnlyList<System.Type> get_All()
public static System.Int32 get_Count()
public static System.Type Get(System.Int32 i)
```

## MegaCrit.Sts2.Core.GameActions.Multiplayer.NetCombatCardDb

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private readonly System.Collections.Generic.Dictionary<MegaCrit.Sts2.Core.Models.CardModel, System.UInt32> _cardToId
private readonly System.Collections.Generic.Dictionary<System.UInt32, MegaCrit.Sts2.Core.Models.CardModel> _idToCard
private System.UInt32 _nextId
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.GameActions.Multiplayer.NetCombatCardDb+Subscription> _subscriptions
private static readonly MegaCrit.Sts2.Core.GameActions.Multiplayer.NetCombatCardDb <Instance>k__BackingField
MegaCrit.Sts2.Core.GameActions.Multiplayer.NetCombatCardDb Instance { public static get; }
private static .cctor()
public .ctor()
private System.Void IdCardIfNecessary(MegaCrit.Sts2.Core.Models.CardModel card)
private System.Void OnCombatEnded(MegaCrit.Sts2.Core.Rooms.CombatRoom _)
private System.Void OnPileContentsChanged(MegaCrit.Sts2.Core.Entities.Cards.CardPile pile)
public MegaCrit.Sts2.Core.Models.CardModel GetCard(System.UInt32 id)
public static MegaCrit.Sts2.Core.GameActions.Multiplayer.NetCombatCardDb get_Instance()
public System.Boolean TryGetCard(System.UInt32 id, out MegaCrit.Sts2.Core.Models.CardModel card)
public System.Boolean TryGetCardId(MegaCrit.Sts2.Core.Models.CardModel card, out System.UInt32 id)
public System.UInt32 GetCardId(MegaCrit.Sts2.Core.Models.CardModel card)
public System.UInt32 IdCardForTesting(MegaCrit.Sts2.Core.Models.CardModel card)
public System.Void ClearCardsForTesting()
public System.Void StartCombat(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Players.Player> players)
```

## MegaCrit.Sts2.Core.GameActions.Multiplayer.NetCombatCardDb+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.GameActions.Multiplayer.NetCombatCardDb+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Entities.Cards.CardPile, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> <>9__8_0
private static .cctor()
public .ctor()
internal System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> <StartCombat>b__8_0(MegaCrit.Sts2.Core.Entities.Cards.CardPile p)
```

## MegaCrit.Sts2.Core.GameActions.Multiplayer.NetCombatCardDb+<>c__DisplayClass8_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.GameActions.Multiplayer.NetCombatCardDb <>4__this
public MegaCrit.Sts2.Core.GameActions.Multiplayer.NetCombatCardDb+Subscription subscription
public .ctor()
internal System.Void <StartCombat>b__1()
```

## MegaCrit.Sts2.Core.GameActions.Multiplayer.NetCombatCardDb+Subscription

类型属性：`NestedPrivate, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：

```text
public System.Action action
public MegaCrit.Sts2.Core.Entities.Cards.CardPile pile
```

## MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext

类型属性：`Public, Abstract, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private System.Collections.Generic.Stack<MegaCrit.Sts2.Core.Models.AbstractModel> _modelStack
MegaCrit.Sts2.Core.Models.AbstractModel LastInvolvedModel { public get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AbstractModel> ModelStack { public get; }
System.Nullable<System.UInt64> OwnerId { public abstract get; }
protected .ctor()
public abstract System.Nullable<System.UInt64> get_OwnerId()
public abstract System.Threading.Tasks.Task SignalPlayerChoiceBegun(MegaCrit.Sts2.Core.Entities.Players.Player chooser, MegaCrit.Sts2.Core.Entities.Multiplayer.PlayerChoiceOptions options)
public abstract System.Threading.Tasks.Task SignalPlayerChoiceEnded()
public MegaCrit.Sts2.Core.Models.AbstractModel get_LastInvolvedModel()
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AbstractModel> get_ModelStack()
public System.Void PopModel(MegaCrit.Sts2.Core.Models.AbstractModel model)
public System.Void PushModel(MegaCrit.Sts2.Core.Models.AbstractModel model)
```

## MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContinuation

类型属性：`Public, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult result, System.AsyncCallback callback, System.Object object)
public virtual System.Threading.Tasks.Task EndInvoke(System.IAsyncResult result)
public virtual System.Threading.Tasks.Task Invoke(MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult result)
```

## MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceDelegate

类型属性：`Public, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object)
public virtual System.Threading.Tasks.Task<MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult> EndInvoke(System.IAsyncResult result)
public virtual System.Threading.Tasks.Task<MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult> Invoke()
```

## MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceSynchronizer

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：`System.IDisposable`

```text
private readonly System.Collections.Generic.List<System.UInt32> _choiceIds
private readonly MegaCrit.Sts2.Core.Logging.Logger _logger
private readonly MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService _netService
private readonly MegaCrit.Sts2.Core.Runs.IPlayerCollection _players
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceSynchronizer+ReceivedChoice> _receivedChoices
private System.Action<MegaCrit.Sts2.Core.Entities.Players.Player, System.UInt32, MegaCrit.Sts2.Core.Entities.Multiplayer.NetPlayerChoiceResult> PlayerChoiceReceived
System.Collections.Generic.IReadOnlyList<System.UInt32> ChoiceIds { public get; }
event System.Action<MegaCrit.Sts2.Core.Entities.Players.Player, System.UInt32, MegaCrit.Sts2.Core.Entities.Multiplayer.NetPlayerChoiceResult> PlayerChoiceReceived
public .ctor(MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService netService, MegaCrit.Sts2.Core.Runs.IPlayerCollection players)
private System.Boolean ValidateChoiceId(MegaCrit.Sts2.Core.Entities.Players.Player player, System.UInt32 choiceId)
private System.UInt32 GetChoiceId(MegaCrit.Sts2.Core.Entities.Players.Player player)
private System.Void OnPlayerChoiceMessageReceived(MegaCrit.Sts2.Core.Multiplayer.Messages.Game.PlayerChoiceMessage message, System.UInt64 senderId)
private System.Void OnReceivePlayerChoice(MegaCrit.Sts2.Core.Entities.Players.Player player, System.UInt32 choiceId, MegaCrit.Sts2.Core.Entities.Multiplayer.NetPlayerChoiceResult result)
public [async] System.Threading.Tasks.Task<MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult> WaitForRemoteChoice(MegaCrit.Sts2.Core.Entities.Players.Player player, System.UInt32 choiceId)
public System.Collections.Generic.IReadOnlyList<System.UInt32> get_ChoiceIds()
public System.UInt32 ReserveChoiceId(MegaCrit.Sts2.Core.Entities.Players.Player player)
public System.Void add_PlayerChoiceReceived(System.Action<MegaCrit.Sts2.Core.Entities.Players.Player, System.UInt32, MegaCrit.Sts2.Core.Entities.Multiplayer.NetPlayerChoiceResult> value)
public System.Void FastForwardChoiceIds(System.Collections.Generic.List<System.UInt32> choiceIds)
public System.Void ReceiveReplayChoice(MegaCrit.Sts2.Core.Entities.Players.Player player, System.UInt32 choiceId, MegaCrit.Sts2.Core.Entities.Multiplayer.NetPlayerChoiceResult result)
public System.Void remove_PlayerChoiceReceived(System.Action<MegaCrit.Sts2.Core.Entities.Players.Player, System.UInt32, MegaCrit.Sts2.Core.Entities.Multiplayer.NetPlayerChoiceResult> value)
public System.Void SyncLocalChoice(MegaCrit.Sts2.Core.Entities.Players.Player player, System.UInt32 choiceId, MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult result)
public virtual System.Void Dispose()
```

## MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceSynchronizer+<>c__DisplayClass15_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.UInt32 choiceId
public MegaCrit.Sts2.Core.Entities.Players.Player player
public .ctor()
internal System.Boolean <WaitForRemoteChoice>b__0(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceSynchronizer+ReceivedChoice c)
```

## MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceSynchronizer+<>c__DisplayClass19_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.UInt32 choiceId
public MegaCrit.Sts2.Core.Entities.Players.Player player
public .ctor()
internal System.Boolean <OnReceivePlayerChoice>b__0(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceSynchronizer+ReceivedChoice c)
```

## MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceSynchronizer+<WaitForRemoteChoice>d__15

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceSynchronizer <>4__this
private MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceSynchronizer+<>c__DisplayClass15_0 <>8__1
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Entities.Multiplayer.NetPlayerChoiceResult> <>u__1
public System.UInt32 choiceId
public MegaCrit.Sts2.Core.Entities.Players.Player player
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceSynchronizer+ReceivedChoice

类型属性：`NestedPrivate, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：

```text
public System.UInt32 choiceId
public System.Threading.Tasks.TaskCompletionSource<MegaCrit.Sts2.Core.Entities.Multiplayer.NetPlayerChoiceResult> completionSource
public System.UInt64 senderId
```

## MegaCrit.Sts2.Core.GameActions.Multiplayer.ThrowingPlayerChoiceContext

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext`。

接口：

```text
System.Nullable<System.UInt64> OwnerId { public virtual get; }
public .ctor()
public virtual System.Nullable<System.UInt64> get_OwnerId()
public virtual System.Threading.Tasks.Task SignalPlayerChoiceBegun(MegaCrit.Sts2.Core.Entities.Players.Player chooser, MegaCrit.Sts2.Core.Entities.Multiplayer.PlayerChoiceOptions options)
public virtual System.Threading.Tasks.Task SignalPlayerChoiceEnded()
```
