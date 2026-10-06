# MegaCrit.Sts2.Core.Combat

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Combat.CombatId

类型属性：`Public, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.IEquatable<MegaCrit.Sts2.Core.Combat.CombatId>`

```text
private readonly System.Int32 <Value>k__BackingField
System.Int32 Value { public get; public set; }
public .ctor(System.Int32 Value)
private System.Boolean PrintMembers(System.Text.StringBuilder builder)
public static System.Boolean op_Equality(MegaCrit.Sts2.Core.Combat.CombatId left, MegaCrit.Sts2.Core.Combat.CombatId right)
public static System.Boolean op_Inequality(MegaCrit.Sts2.Core.Combat.CombatId left, MegaCrit.Sts2.Core.Combat.CombatId right)
public System.Int32 get_Value()
public System.Void Deconstruct(out System.Int32 Value)
public System.Void set_Value(System.Int32 value)
public virtual System.Boolean Equals(MegaCrit.Sts2.Core.Combat.CombatId other)
public virtual System.Boolean Equals(System.Object obj)
public virtual System.Int32 GetHashCode()
public virtual System.String ToString()
```

## MegaCrit.Sts2.Core.Combat.CombatManager

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private readonly System.Collections.Generic.Dictionary<MegaCrit.Sts2.Core.Entities.Players.Player, System.Int32> _cardOrPotionEffectDepth
private System.Boolean _playerActionsDisabled
private static readonly System.TimeSpan _previousTurnLoopTimeout
private static System.Boolean _staleTurnEndReported
private System.Threading.Tasks.Task _turnLoopTask
private System.Threading.Tasks.TaskCompletionSource _turnLoopWaitingForPreviousSource
private static System.Boolean _turnLoopWaitTimeoutReported
private MegaCrit.Sts2.Core.Combat.CombatTurnState _turnState
private MegaCrit.Sts2.Core.Models.CardModel <DebugForcedTopCardOnNextShuffle>k__BackingField
private readonly MegaCrit.Sts2.Core.Combat.History.CombatHistory <History>k__BackingField
private static readonly MegaCrit.Sts2.Core.Combat.CombatManager <Instance>k__BackingField
private System.Boolean <IsPaused>k__BackingField
private readonly MegaCrit.Sts2.Core.Combat.CombatStateTracker <StateTracker>k__BackingField
private System.Action<MegaCrit.Sts2.Core.Combat.CombatState> AboutToSwitchToEnemyTurn
public static const System.Int32 baseHandDrawCount = 5
private System.Action<MegaCrit.Sts2.Core.Combat.CombatState> CombatBegan
private System.Action<MegaCrit.Sts2.Core.Rooms.CombatRoom> CombatEnded
private System.Action<MegaCrit.Sts2.Core.Combat.CombatState> CombatSetUp
private System.Action<MegaCrit.Sts2.Core.Rooms.CombatRoom> CombatWon
private System.Action<MegaCrit.Sts2.Core.Combat.CombatState> CreaturesChanged
private System.Action<MegaCrit.Sts2.Core.Combat.CombatState> PlayerActionsDisabledChanged
private System.Action<MegaCrit.Sts2.Core.Entities.Players.Player, System.Boolean> PlayerEndedTurn
private System.Action<MegaCrit.Sts2.Core.Entities.Players.Player> PlayerUnendedTurn
private System.Action<MegaCrit.Sts2.Core.Combat.CombatState> TurnEnded
private System.Action<MegaCrit.Sts2.Core.Combat.CombatState> TurnStarted
System.Nullable<MegaCrit.Sts2.Core.Combat.CombatId> CurrentCombatId { public get; }
MegaCrit.Sts2.Core.Models.CardModel DebugForcedTopCardOnNextShuffle { public get; private set; }
System.Threading.Tasks.Task DebugOnlyCurrentTurnLoopTask { internal get; }
System.Boolean EndingPlayerTurnPhaseOne { public get; }
System.Boolean EndingPlayerTurnPhaseTwo { public get; }
MegaCrit.Sts2.Core.Combat.History.CombatHistory History { public get; }
MegaCrit.Sts2.Core.Combat.CombatManager Instance { public static get; }
System.Boolean IsAboutToLose { public get; }
System.Boolean IsEnding { public get; }
System.Boolean IsEnemyTurnStarted { public get; }
System.Boolean IsInProgress { public get; }
System.Boolean IsOverOrEnding { public get; }
System.Boolean IsPaused { public get; private set; }
System.Boolean IsStarting { public get; }
System.Boolean PlayerActionsDisabled { public get; private set; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Players.Player> PlayersTakingExtraTurn { public get; }
MegaCrit.Sts2.Core.Combat.CombatStateTracker StateTracker { public get; }
event System.Action<MegaCrit.Sts2.Core.Combat.CombatState> AboutToSwitchToEnemyTurn
event System.Action<MegaCrit.Sts2.Core.Combat.CombatState> CombatBegan
event System.Action<MegaCrit.Sts2.Core.Rooms.CombatRoom> CombatEnded
event System.Action<MegaCrit.Sts2.Core.Combat.CombatState> CombatSetUp
event System.Action<MegaCrit.Sts2.Core.Rooms.CombatRoom> CombatWon
event System.Action<MegaCrit.Sts2.Core.Combat.CombatState> CreaturesChanged
event System.Action<MegaCrit.Sts2.Core.Combat.CombatState> PlayerActionsDisabledChanged
event System.Action<MegaCrit.Sts2.Core.Entities.Players.Player, System.Boolean> PlayerEndedTurn
event System.Action<MegaCrit.Sts2.Core.Entities.Players.Player> PlayerUnendedTurn
event System.Action<MegaCrit.Sts2.Core.Combat.CombatState> TurnEnded
event System.Action<MegaCrit.Sts2.Core.Combat.CombatState> TurnStarted
private .ctor()
private static .cctor()
internal [async] System.Threading.Tasks.Task EndCombatInternal()
internal [async] System.Threading.Tasks.Task EndPlayerTurnPhaseOneInternal()
internal [async] System.Threading.Tasks.Task EndPlayerTurnPhaseTwoInternal()
internal System.Threading.Tasks.Task DebugOnlyWhenNextTurnLoopWaitsForPrevious()
internal System.Threading.Tasks.Task get_DebugOnlyCurrentTurnLoopTask()
private [async] System.Threading.Tasks.Task AddTurnEndCardToPlayPileWithDelay(MegaCrit.Sts2.Core.Models.CardModel card, System.Single delay)
private [async] System.Threading.Tasks.Task AfterAllPlayersReadyToBeginEnemyTurn(MegaCrit.Sts2.Core.Combat.CombatTurnState turnState)
private [async] System.Threading.Tasks.Task AfterAllPlayersReadyToEndTurn(MegaCrit.Sts2.Core.Combat.CombatTurnState turnState, MegaCrit.Sts2.Core.Combat.EndTurnSignal signal)
private [async] System.Threading.Tasks.Task CheckForEmptyHand(MegaCrit.Sts2.Core.Combat.CombatTurnState turnState, MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Players.Player player)
private [async] System.Threading.Tasks.Task DoTurnEnd(MegaCrit.Sts2.Core.Combat.CombatTurnState turnState, MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext)
private [async] System.Threading.Tasks.Task DoTurnEndCards(MegaCrit.Sts2.Core.Combat.CombatTurnState turnState, System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.CardModel> turnEndCards, MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext)
private [async] System.Threading.Tasks.Task EndCombatInternal(MegaCrit.Sts2.Core.Combat.CombatTurnState turnState)
private [async] System.Threading.Tasks.Task EndEnemyTurn(MegaCrit.Sts2.Core.Combat.CombatTurnState turnState)
private [async] System.Threading.Tasks.Task EndEnemyTurnInternal(MegaCrit.Sts2.Core.Combat.CombatTurnState turnState)
private [async] System.Threading.Tasks.Task EndPlayerTurnPhaseOneInternal(MegaCrit.Sts2.Core.Combat.CombatTurnState turnState)
private [async] System.Threading.Tasks.Task EndPlayerTurnPhaseTwoInternal(MegaCrit.Sts2.Core.Combat.CombatTurnState turnState)
private [async] System.Threading.Tasks.Task ExecuteEnemyTurn(MegaCrit.Sts2.Core.Combat.CombatTurnState turnState, System.Func<System.Threading.Tasks.Task> actionDuringEnemyTurn = null)
private [async] System.Threading.Tasks.Task FlushPlayerHand(MegaCrit.Sts2.Core.Combat.CombatTurnState turnState, MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.GameActions.Multiplayer.HookPlayerChoiceContext playerChoiceContext)
private [async] System.Threading.Tasks.Task RunAutoPrePlayPhase(MegaCrit.Sts2.Core.Combat.CombatTurnState turnState, MegaCrit.Sts2.Core.GameActions.Multiplayer.HookPlayerChoiceContext playerChoiceContext, System.Threading.Tasks.Task setupPlayerTurnTask, MegaCrit.Sts2.Core.Entities.Players.Player player)
private [async] System.Threading.Tasks.Task RunTurnLoopAfter(System.Threading.Tasks.Task previousTurnLoopTask)
private [async] System.Threading.Tasks.Task SetupPlayerTurn(MegaCrit.Sts2.Core.Combat.CombatTurnState turnState, MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.GameActions.Multiplayer.HookPlayerChoiceContext playerChoiceContext)
private [async] System.Threading.Tasks.Task StartCombatInternal(MegaCrit.Sts2.Core.Combat.CombatTurnState turnState)
private [async] System.Threading.Tasks.Task StartTurn(MegaCrit.Sts2.Core.Combat.CombatTurnState turnState, System.Func<System.Threading.Tasks.Task> actionDuringEnemyTurn = null)
private [async] System.Threading.Tasks.Task SwitchFromPlayerToEnemySide(MegaCrit.Sts2.Core.Combat.CombatTurnState turnState)
private [async] System.Threading.Tasks.Task TweenTurnEndCardToResultPile(MegaCrit.Sts2.Core.Combat.CombatTurnState turnState, System.Threading.Tasks.Task<System.Nullable<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult>> resultTask)
private [async] System.Threading.Tasks.Task WaitForPreviousTurnLoopToFinish(System.Threading.Tasks.Task previousTurnLoopTask, MegaCrit.Sts2.Core.Combat.CombatTurnState turnState)
private [async] System.Threading.Tasks.Task WaitForUnpause(MegaCrit.Sts2.Core.Combat.CombatTurnState turnState)
private [async] System.Threading.Tasks.Task WaitUntilQueueIsEmptyOrWaitingOnNonPlayerDrivenAction(MegaCrit.Sts2.Core.Combat.CombatTurnState turnState)
private [async] System.Threading.Tasks.Task<System.Boolean> CheckWinCondition(MegaCrit.Sts2.Core.Combat.CombatTurnState turnState)
private [async] System.Threading.Tasks.Task<System.Func<System.Threading.Tasks.Task>> AwaitTurnEndAndSwitchSides(MegaCrit.Sts2.Core.Combat.CombatTurnState turnState)
private [async] System.Threading.Tasks.Task<System.Nullable<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult>> ResolveTurnEndCardEffects(MegaCrit.Sts2.Core.Models.CardModel card, MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, System.Threading.Tasks.Task waitTask)
private MegaCrit.Sts2.Core.Combat.CombatTurnState LiveTurnStateFor(System.Nullable<MegaCrit.Sts2.Core.Combat.CombatId> combatId)
private static [async] System.Threading.Tasks.Task AfterCreatureAdded(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature, MegaCrit.Sts2.Core.Combat.CombatState state)
private static System.Void SetPhaseForAllPlayers(MegaCrit.Sts2.Core.Combat.CombatState state, MegaCrit.Sts2.Core.Combat.PlayerTurnPhase phase)
private System.Boolean AllPlayersReadyToEndTurn(MegaCrit.Sts2.Core.Combat.CombatTurnState turnState)
private System.Boolean IsCombatEnding(MegaCrit.Sts2.Core.Combat.CombatTurnState turnState)
private System.Void ProcessPendingLoss(MegaCrit.Sts2.Core.Combat.CombatTurnState turnState)
private System.Void set_DebugForcedTopCardOnNextShuffle(MegaCrit.Sts2.Core.Models.CardModel value)
private System.Void set_IsPaused(System.Boolean value)
private System.Void set_PlayerActionsDisabled(System.Boolean value)
private System.Void SwitchSides(MegaCrit.Sts2.Core.Combat.CombatTurnState turnState)
public [async] System.Threading.Tasks.Task CheckForEmptyHand(System.Nullable<MegaCrit.Sts2.Core.Combat.CombatId> combatId, MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Players.Player player)
public [async] System.Threading.Tasks.Task EndCardOrPotionEffect(System.Nullable<MegaCrit.Sts2.Core.Combat.CombatId> combatId, MegaCrit.Sts2.Core.Entities.Players.Player player)
public [async] System.Threading.Tasks.Task HandlePlayerDeath(System.Nullable<MegaCrit.Sts2.Core.Combat.CombatId> combatId, MegaCrit.Sts2.Core.Entities.Players.Player player)
public [async] System.Threading.Tasks.Task RemoveDeadPlayerCardsFromCombat(System.Nullable<MegaCrit.Sts2.Core.Combat.CombatId> combatId, MegaCrit.Sts2.Core.Entities.Players.Player player)
public [async] System.Threading.Tasks.Task<System.Boolean> CheckWinCondition()
public MegaCrit.Sts2.Core.Combat.CombatState DebugOnlyGetState()
public MegaCrit.Sts2.Core.Combat.CombatStateTracker get_StateTracker()
public MegaCrit.Sts2.Core.Combat.History.CombatHistory get_History()
public MegaCrit.Sts2.Core.Models.CardModel get_DebugForcedTopCardOnNextShuffle()
public static MegaCrit.Sts2.Core.Combat.CombatManager get_Instance()
public System.Boolean AllPlayersReadyToEndTurn()
public System.Boolean get_EndingPlayerTurnPhaseOne()
public System.Boolean get_EndingPlayerTurnPhaseTwo()
public System.Boolean get_IsAboutToLose()
public System.Boolean get_IsEnding()
public System.Boolean get_IsEnemyTurnStarted()
public System.Boolean get_IsInProgress()
public System.Boolean get_IsOverOrEnding()
public System.Boolean get_IsPaused()
public System.Boolean get_IsStarting()
public System.Boolean get_PlayerActionsDisabled()
public System.Boolean IsCurrentLiveCombat(System.Nullable<MegaCrit.Sts2.Core.Combat.CombatId> combatId)
public System.Boolean IsExecutingCardOrPotionEffect(MegaCrit.Sts2.Core.Entities.Players.Player player)
public System.Boolean IsPartOfPlayerTurn(MegaCrit.Sts2.Core.Entities.Players.Player player)
public System.Boolean IsPlayerReadyToEndTurn(MegaCrit.Sts2.Core.Entities.Players.Player player)
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Players.Player> get_PlayersTakingExtraTurn()
public System.Nullable<MegaCrit.Sts2.Core.Combat.CombatId> BeginCardOrPotionEffect(MegaCrit.Sts2.Core.Entities.Players.Player player)
public System.Nullable<MegaCrit.Sts2.Core.Combat.CombatId> get_CurrentCombatId()
public System.Threading.Tasks.Task AfterCreatureAdded(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public System.Threading.Tasks.Task WaitForUnpause()
public System.Void add_AboutToSwitchToEnemyTurn(System.Action<MegaCrit.Sts2.Core.Combat.CombatState> value)
public System.Void add_CombatBegan(System.Action<MegaCrit.Sts2.Core.Combat.CombatState> value)
public System.Void add_CombatEnded(System.Action<MegaCrit.Sts2.Core.Rooms.CombatRoom> value)
public System.Void add_CombatSetUp(System.Action<MegaCrit.Sts2.Core.Combat.CombatState> value)
public System.Void add_CombatWon(System.Action<MegaCrit.Sts2.Core.Rooms.CombatRoom> value)
public System.Void add_CreaturesChanged(System.Action<MegaCrit.Sts2.Core.Combat.CombatState> value)
public System.Void add_PlayerActionsDisabledChanged(System.Action<MegaCrit.Sts2.Core.Combat.CombatState> value)
public System.Void add_PlayerEndedTurn(System.Action<MegaCrit.Sts2.Core.Entities.Players.Player, System.Boolean> value)
public System.Void add_PlayerUnendedTurn(System.Action<MegaCrit.Sts2.Core.Entities.Players.Player> value)
public System.Void add_TurnEnded(System.Action<MegaCrit.Sts2.Core.Combat.CombatState> value)
public System.Void add_TurnStarted(System.Action<MegaCrit.Sts2.Core.Combat.CombatState> value)
public System.Void AddCreature(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public System.Void AfterCombatRoomLoaded()
public System.Void DebugClearForcedTopCardOnNextShuffle()
public System.Void DebugForceTopCardOnNextShuffle(MegaCrit.Sts2.Core.Models.CardModel card)
public System.Void LoseCombat()
public System.Void OnEndedTurnLocally()
public System.Void Pause()
public System.Void remove_AboutToSwitchToEnemyTurn(System.Action<MegaCrit.Sts2.Core.Combat.CombatState> value)
public System.Void remove_CombatBegan(System.Action<MegaCrit.Sts2.Core.Combat.CombatState> value)
public System.Void remove_CombatEnded(System.Action<MegaCrit.Sts2.Core.Rooms.CombatRoom> value)
public System.Void remove_CombatSetUp(System.Action<MegaCrit.Sts2.Core.Combat.CombatState> value)
public System.Void remove_CombatWon(System.Action<MegaCrit.Sts2.Core.Rooms.CombatRoom> value)
public System.Void remove_CreaturesChanged(System.Action<MegaCrit.Sts2.Core.Combat.CombatState> value)
public System.Void remove_PlayerActionsDisabledChanged(System.Action<MegaCrit.Sts2.Core.Combat.CombatState> value)
public System.Void remove_PlayerEndedTurn(System.Action<MegaCrit.Sts2.Core.Entities.Players.Player, System.Boolean> value)
public System.Void remove_PlayerUnendedTurn(System.Action<MegaCrit.Sts2.Core.Entities.Players.Player> value)
public System.Void remove_TurnEnded(System.Action<MegaCrit.Sts2.Core.Combat.CombatState> value)
public System.Void remove_TurnStarted(System.Action<MegaCrit.Sts2.Core.Combat.CombatState> value)
public System.Void RemoveCreature(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public System.Void Reset(System.Boolean graceful)
public System.Void SetReadyToBeginEnemyTurn(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Func<System.Threading.Tasks.Task> actionDuringEnemyTurn = null)
public System.Void SetReadyToEndTurn(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Boolean canBackOut, System.Func<System.Threading.Tasks.Task> actionDuringEnemyTurn = null)
public System.Void SetUpCombat(MegaCrit.Sts2.Core.Combat.CombatState state)
public System.Void UndoReadyToEndTurn(MegaCrit.Sts2.Core.Entities.Players.Player player)
public System.Void Unpause()
```

## MegaCrit.Sts2.Core.Combat.CombatManager+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Combat.CombatManager+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Entities.Players.Player, MegaCrit.Sts2.Core.Entities.Creatures.Creature> <>9__100_0
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> <>9__102_0
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> <>9__102_1
public static System.Func<MegaCrit.Sts2.Core.Entities.Players.Player, MegaCrit.Sts2.Core.Entities.Creatures.Creature> <>9__113_0
public static System.Func<MegaCrit.Sts2.Core.Entities.Players.Player, System.Boolean> <>9__117_0
public static System.Func<MegaCrit.Sts2.Core.Entities.Players.Player, System.Boolean> <>9__118_0
public static System.Func<MegaCrit.Sts2.Core.Entities.Players.Player, MegaCrit.Sts2.Core.Entities.Creatures.Creature> <>9__130_0
public static System.Func<MegaCrit.Sts2.Core.Entities.Players.Player, MegaCrit.Sts2.Core.Entities.Creatures.Creature> <>9__139_0
public static System.Func<MegaCrit.Sts2.Core.Entities.Creatures.Creature, System.Boolean> <>9__82_0
private static .cctor()
public .ctor()
internal MegaCrit.Sts2.Core.Entities.Creatures.Creature <AfterCreatureAdded>b__113_0(MegaCrit.Sts2.Core.Entities.Players.Player p)
internal MegaCrit.Sts2.Core.Entities.Creatures.Creature <EndPlayerTurnPhaseOneInternal>b__130_0(MegaCrit.Sts2.Core.Entities.Players.Player p)
internal MegaCrit.Sts2.Core.Entities.Creatures.Creature <EndPlayerTurnPhaseTwoInternal>b__139_0(MegaCrit.Sts2.Core.Entities.Players.Player p)
internal MegaCrit.Sts2.Core.Entities.Creatures.Creature <StartTurn>b__100_0(MegaCrit.Sts2.Core.Entities.Players.Player p)
internal System.Boolean <HandlePlayerDeath>b__117_0(MegaCrit.Sts2.Core.Entities.Players.Player p)
internal System.Boolean <IsCombatEnding>b__82_0(MegaCrit.Sts2.Core.Entities.Creatures.Creature e)
internal System.Boolean <RemoveDeadPlayerCardsFromCombat>b__118_0(MegaCrit.Sts2.Core.Entities.Players.Player p)
internal System.Boolean <SetupPlayerTurn>b__102_0(MegaCrit.Sts2.Core.Models.CardModel c)
internal System.Boolean <SetupPlayerTurn>b__102_1(MegaCrit.Sts2.Core.Models.CardModel c)
```

## MegaCrit.Sts2.Core.Combat.CombatManager+<>c__DisplayClass127_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Combat.EndTurnSignal signal
public MegaCrit.Sts2.Core.Combat.CombatTurnState turnState
public .ctor()
internal System.Void <AfterAllPlayersReadyToEndTurn>b__0(Sentry.Scope scope)
```

## MegaCrit.Sts2.Core.Combat.CombatManager+<>c__DisplayClass128_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.Threading.Tasks.TaskCompletionSource completionSource
public .ctor()
internal System.Void <WaitUntilQueueIsEmptyOrWaitingOnNonPlayerDrivenAction>g__AfterActionExecuted|0(MegaCrit.Sts2.Core.GameActions.GameAction action)
```

## MegaCrit.Sts2.Core.Combat.CombatManager+<>c__DisplayClass96_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.Exception e
public MegaCrit.Sts2.Core.Combat.CombatTurnState turnState
public .ctor()
internal System.Void <RunTurnLoopAfter>b__0(Sentry.Scope scope)
```

## MegaCrit.Sts2.Core.Combat.CombatManager+<>c__DisplayClass97_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Combat.CombatTurnState turnState
public .ctor()
internal System.Void <WaitForPreviousTurnLoopToFinish>b__0(Sentry.Scope scope)
```

## MegaCrit.Sts2.Core.Combat.CombatManager+<AddTurnEndCardToPlayPileWithDelay>d__133

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult> <>u__2
public MegaCrit.Sts2.Core.Models.CardModel card
public System.Single delay
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Combat.CombatManager+<AfterAllPlayersReadyToBeginEnemyTurn>d__137

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Combat.CombatManager <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.YieldAwaitable+YieldAwaiter <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
public MegaCrit.Sts2.Core.Combat.CombatTurnState turnState
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Combat.CombatManager+<AfterAllPlayersReadyToEndTurn>d__127

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Combat.CombatManager <>4__this
private MegaCrit.Sts2.Core.Combat.CombatManager+<>c__DisplayClass127_0 <>8__1
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.Combat.EndTurnSignal signal
public MegaCrit.Sts2.Core.Combat.CombatTurnState turnState
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Combat.CombatManager+<AfterCreatureAdded>d__113

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.Entities.Creatures.Creature creature
public MegaCrit.Sts2.Core.Combat.CombatState state
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Combat.CombatManager+<AwaitTurnEndAndSwitchSides>d__99

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Combat.CombatManager <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Func<System.Threading.Tasks.Task>> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Combat.EndTurnSignal> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
private System.Runtime.CompilerServices.TaskAwaiter<System.Func<System.Threading.Tasks.Task>> <>u__3
private System.Func<System.Threading.Tasks.Task> <actionDuringEnemyTurn>5__4
private System.Threading.Tasks.TaskCompletionSource<System.Func<System.Threading.Tasks.Task>> <beginEnemyTurnSignalSource>5__2
private MegaCrit.Sts2.Core.Combat.EndTurnSignal <endTurnSignal>5__3
public MegaCrit.Sts2.Core.Combat.CombatTurnState turnState
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Combat.CombatManager+<CheckForEmptyHand>d__114

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Combat.CombatManager <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext
public System.Nullable<MegaCrit.Sts2.Core.Combat.CombatId> combatId
public MegaCrit.Sts2.Core.Entities.Players.Player player
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Combat.CombatManager+<CheckForEmptyHand>d__115

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Combat.CombatManager <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext
public MegaCrit.Sts2.Core.Entities.Players.Player player
public MegaCrit.Sts2.Core.Combat.CombatTurnState turnState
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Combat.CombatManager+<CheckWinCondition>d__124

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Combat.CombatManager <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Boolean> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Combat.CombatManager+<CheckWinCondition>d__125

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Combat.CombatManager <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Boolean> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.Combat.CombatTurnState turnState
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Combat.CombatManager+<DoTurnEnd>d__131

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Combat.CombatManager <>4__this
private System.Collections.Generic.List+Enumerator<MegaCrit.Sts2.Core.Models.CardModel> <>7__wrap2
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<System.Nullable<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult>> <>u__2
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.CardModel> <turnEndCards>5__2
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext
public MegaCrit.Sts2.Core.Entities.Players.Player player
public MegaCrit.Sts2.Core.Combat.CombatTurnState turnState
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Combat.CombatManager+<DoTurnEndCards>d__132

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Combat.CombatManager <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.CardModel> turnEndCards
public MegaCrit.Sts2.Core.Combat.CombatTurnState turnState
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Combat.CombatManager+<EndCardOrPotionEffect>d__77

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Combat.CombatManager <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public System.Nullable<MegaCrit.Sts2.Core.Combat.CombatId> combatId
public MegaCrit.Sts2.Core.Entities.Players.Player player
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Combat.CombatManager+<EndCombatInternal>d__121

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Combat.CombatManager <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Combat.CombatManager+<EndCombatInternal>d__122

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Combat.CombatManager <>4__this
private System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Entities.Players.Player> <>7__wrap6
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private MegaCrit.Sts2.Core.Combat.CombatState <combatState>5__2
private MegaCrit.Sts2.Core.Entities.Players.Player <localPlayer>5__3
private MegaCrit.Sts2.Core.Rooms.CombatRoom <room>5__6
private MegaCrit.Sts2.Core.Runs.IRunState <runState>5__5
private System.Int32 <turnsTaken>5__4
public MegaCrit.Sts2.Core.Combat.CombatTurnState turnState
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Combat.CombatManager+<EndEnemyTurn>d__110

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Combat.CombatManager <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__2
public MegaCrit.Sts2.Core.Combat.CombatTurnState turnState
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Combat.CombatManager+<EndEnemyTurnInternal>d__136

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Creatures.Creature> <enemies>5__2
public MegaCrit.Sts2.Core.Combat.CombatTurnState turnState
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Combat.CombatManager+<EndPlayerTurnPhaseOneInternal>d__129

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Combat.CombatManager <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Combat.CombatManager+<EndPlayerTurnPhaseOneInternal>d__130

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Combat.CombatManager <>4__this
private System.Collections.Generic.List+Enumerator<MegaCrit.Sts2.Core.Entities.Players.Player> <>7__wrap4
private System.Collections.Generic.List+Enumerator<System.ValueTuple<MegaCrit.Sts2.Core.Entities.Players.Player, MegaCrit.Sts2.Core.GameActions.Multiplayer.HookPlayerChoiceContext>> <>7__wrap7
private System.Collections.Generic.List+Enumerator<MegaCrit.Sts2.Core.GameActions.Multiplayer.HookPlayerChoiceContext> <>7__wrap8
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__2
private System.Collections.Generic.List<System.ValueTuple<MegaCrit.Sts2.Core.Entities.Players.Player, MegaCrit.Sts2.Core.GameActions.Multiplayer.HookPlayerChoiceContext>> <autoPostPlayContexts>5__3
private MegaCrit.Sts2.Core.Entities.Players.Player <player>5__6
private MegaCrit.Sts2.Core.GameActions.Multiplayer.HookPlayerChoiceContext <playerChoiceContext>5__7
private System.Collections.Generic.List<MegaCrit.Sts2.Core.GameActions.Multiplayer.HookPlayerChoiceContext> <playerEndContexts>5__4
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Players.Player> <playersEndingTurn>5__2
public MegaCrit.Sts2.Core.Combat.CombatTurnState turnState
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Combat.CombatManager+<EndPlayerTurnPhaseTwoInternal>d__138

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Combat.CombatManager <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Combat.CombatManager+<EndPlayerTurnPhaseTwoInternal>d__139

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Combat.CombatManager <>4__this
private System.Collections.Generic.List+Enumerator<MegaCrit.Sts2.Core.Entities.Players.Player> <>7__wrap3
private System.Collections.Generic.List+Enumerator<MegaCrit.Sts2.Core.GameActions.Multiplayer.HookPlayerChoiceContext> <>7__wrap5
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
private System.Collections.Generic.List<MegaCrit.Sts2.Core.GameActions.Multiplayer.HookPlayerChoiceContext> <flushPlayerHandContexts>5__3
private MegaCrit.Sts2.Core.GameActions.Multiplayer.HookPlayerChoiceContext <playerChoiceContext>5__5
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Players.Player> <playersEndingTurn>5__2
public MegaCrit.Sts2.Core.Combat.CombatTurnState turnState
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Combat.CombatManager+<ExecuteEnemyTurn>d__126

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Combat.CombatManager <>4__this
private System.Collections.Generic.List+Enumerator<MegaCrit.Sts2.Core.Entities.Creatures.Creature> <>7__wrap1
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__2
private MegaCrit.Sts2.Core.Entities.Creatures.Creature <enemy>5__3
public System.Func<System.Threading.Tasks.Task> actionDuringEnemyTurn
public MegaCrit.Sts2.Core.Combat.CombatTurnState turnState
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Combat.CombatManager+<FlushPlayerHand>d__140

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult>> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.CardModel> <cardsToFlush>5__3
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.CardModel> <cardsToRetain>5__4
private MegaCrit.Sts2.Core.Combat.CombatState <state>5__2
public MegaCrit.Sts2.Core.Entities.Players.Player player
public MegaCrit.Sts2.Core.GameActions.Multiplayer.HookPlayerChoiceContext playerChoiceContext
public MegaCrit.Sts2.Core.Combat.CombatTurnState turnState
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Combat.CombatManager+<HandlePlayerDeath>d__117

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Combat.CombatManager <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public System.Nullable<MegaCrit.Sts2.Core.Combat.CombatId> combatId
public MegaCrit.Sts2.Core.Entities.Players.Player player
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Combat.CombatManager+<RemoveDeadPlayerCardsFromCombat>d__118

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Combat.CombatManager <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public System.Nullable<MegaCrit.Sts2.Core.Combat.CombatId> combatId
public MegaCrit.Sts2.Core.Entities.Players.Player player
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Combat.CombatManager+<ResolveTurnEndCardEffects>d__134

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Nullable<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult>> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<System.Nullable<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult>> <>u__2
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult> <>u__3
public MegaCrit.Sts2.Core.Models.CardModel card
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext
public System.Threading.Tasks.Task waitTask
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Combat.CombatManager+<RunAutoPrePlayPhase>d__101

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Combat.CombatManager <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.Entities.Players.Player player
public MegaCrit.Sts2.Core.GameActions.Multiplayer.HookPlayerChoiceContext playerChoiceContext
public System.Threading.Tasks.Task setupPlayerTurnTask
public MegaCrit.Sts2.Core.Combat.CombatTurnState turnState
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Combat.CombatManager+<RunTurnLoopAfter>d__96

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Combat.CombatManager <>4__this
private MegaCrit.Sts2.Core.Combat.CombatManager+<>c__DisplayClass96_0 <>8__1
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public System.Threading.Tasks.Task previousTurnLoopTask
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Combat.CombatManager+<SetupPlayerTurn>d__102

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> <>u__2
private System.Decimal <handDraw>5__3
private MegaCrit.Sts2.Core.Combat.CombatState <state>5__2
public MegaCrit.Sts2.Core.Entities.Players.Player player
public MegaCrit.Sts2.Core.GameActions.Multiplayer.HookPlayerChoiceContext playerChoiceContext
public MegaCrit.Sts2.Core.Combat.CombatTurnState turnState
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Combat.CombatManager+<StartCombatInternal>d__98

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Combat.CombatManager <>4__this
private System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Entities.Creatures.Creature> <>7__wrap2
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<System.Func<System.Threading.Tasks.Task>> <>u__2
private MegaCrit.Sts2.Core.Nodes.Ftue.NCombatRulesFtue <ftue>5__2
public MegaCrit.Sts2.Core.Combat.CombatTurnState turnState
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Combat.CombatManager+<StartTurn>d__100

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Combat.CombatManager <>4__this
private System.Collections.Generic.List+Enumerator<MegaCrit.Sts2.Core.Entities.Creatures.Creature> <>7__wrap5
private System.Collections.Generic.List+Enumerator<MegaCrit.Sts2.Core.Entities.Players.Player> <>7__wrap6
private System.Collections.Generic.IEnumerator<System.ValueTuple<MegaCrit.Sts2.Core.Entities.Players.Player, System.ValueTuple<MegaCrit.Sts2.Core.GameActions.Multiplayer.HookPlayerChoiceContext, System.Threading.Tasks.Task>>> <>7__wrap9
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__2
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Creatures.Creature> <creaturesStartingTurn>5__2
private System.Boolean <isExtraPlayerTurn>5__4
private MegaCrit.Sts2.Core.GameActions.Multiplayer.HookPlayerChoiceContext <playerChoiceContext>5__8
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Players.Player> <playersStartingTurn>5__3
private System.Collections.Generic.List<System.ValueTuple<MegaCrit.Sts2.Core.GameActions.Multiplayer.HookPlayerChoiceContext, System.Threading.Tasks.Task>> <setupPlayerTurnContext>5__5
private System.Threading.Tasks.Task <task>5__9
public System.Func<System.Threading.Tasks.Task> actionDuringEnemyTurn
public MegaCrit.Sts2.Core.Combat.CombatTurnState turnState
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Combat.CombatManager+<SwitchFromPlayerToEnemySide>d__141

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Combat.CombatManager <>4__this
private System.Collections.Generic.List+Enumerator<MegaCrit.Sts2.Core.Entities.Players.Player> <>7__wrap1
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.Combat.CombatTurnState turnState
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Combat.CombatManager+<TweenTurnEndCardToResultPile>d__135

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Nullable<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult>> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
public System.Threading.Tasks.Task<System.Nullable<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult>> resultTask
public MegaCrit.Sts2.Core.Combat.CombatTurnState turnState
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Combat.CombatManager+<WaitForPreviousTurnLoopToFinish>d__97

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Combat.CombatManager <>4__this
private MegaCrit.Sts2.Core.Combat.CombatManager+<>c__DisplayClass97_0 <>8__1
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public System.Threading.Tasks.Task previousTurnLoopTask
public MegaCrit.Sts2.Core.Combat.CombatTurnState turnState
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Combat.CombatManager+<WaitForUnpause>d__147

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Combat.CombatManager <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
public MegaCrit.Sts2.Core.Combat.CombatTurnState turnState
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Combat.CombatManager+<WaitUntilQueueIsEmptyOrWaitingOnNonPlayerDrivenAction>d__128

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
private MegaCrit.Sts2.Core.Combat.CombatManager+<>c__DisplayClass128_0 <>8__1
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.Combat.CombatTurnState turnState
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Combat.CombatSide

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Combat.CombatSide Enemy = 2
public static const MegaCrit.Sts2.Core.Combat.CombatSide None = 0
public static const MegaCrit.Sts2.Core.Combat.CombatSide Player = 1
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Combat.CombatSideExtensions

类型属性：`Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static MegaCrit.Sts2.Core.Combat.CombatSide GetOppositeSide(MegaCrit.Sts2.Core.Combat.CombatSide side)
```

## MegaCrit.Sts2.Core.Combat.CombatState

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：`MegaCrit.Sts2.Core.Combat.ICombatState`, `MegaCrit.Sts2.Core.Runs.ICardScope`

```text
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.CardModel> _allCards
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Creatures.Creature> _allies
private readonly MegaCrit.Sts2.Core.Models.EncounterModel _encounter
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Creatures.Creature> _enemies
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Creatures.Creature> _escapedCreatures
private System.UInt32 _nextCreatureId
private readonly System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.BadgeModel> <BadgeModels>k__BackingField
private MegaCrit.Sts2.Core.Combat.CombatSide <CurrentSide>k__BackingField
private readonly System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel> <Modifiers>k__BackingField
private MegaCrit.Sts2.Core.Models.Singleton.MultiplayerScalingModel <MultiplayerScalingModel>k__BackingField
private System.Int32 <RoundNumber>k__BackingField
private readonly MegaCrit.Sts2.Core.Runs.IRunState <RunState>k__BackingField
private System.Action<MegaCrit.Sts2.Core.Combat.ICombatState> CreaturesChanged
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> Allies { public virtual get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.BadgeModel> BadgeModels { public get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> Creatures { public virtual get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> CreaturesOnCurrentSide { public virtual get; }
MegaCrit.Sts2.Core.Combat.CombatSide CurrentSide { public virtual get; public virtual set; }
MegaCrit.Sts2.Core.Models.EncounterModel Encounter { public virtual get; private set; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> Enemies { public virtual get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> EscapedCreatures { public virtual get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> HittableEnemies { public virtual get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel> Modifiers { public virtual get; }
MegaCrit.Sts2.Core.Models.Singleton.MultiplayerScalingModel MultiplayerScalingModel { public virtual get; private set; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> PlayerCreatures { public virtual get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Players.Player> Players { public virtual get; }
System.Int32 RoundNumber { public virtual get; public virtual set; }
MegaCrit.Sts2.Core.Runs.IRunState RunState { public virtual get; }
event System.Action<MegaCrit.Sts2.Core.Combat.ICombatState> CreaturesChanged
public .ctor(MegaCrit.Sts2.Core.Models.EncounterModel encounter = null, MegaCrit.Sts2.Core.Runs.IRunState runState = null, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel> modifiers = null, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.BadgeModel> badgeModels = null, MegaCrit.Sts2.Core.Models.Singleton.MultiplayerScalingModel multiplayerScalingModel = null)
private static [async] System.Threading.Tasks.Task GodotTimerTask(System.Double timeSec)
private System.Boolean Contains(MegaCrit.Sts2.Core.Models.AbstractModel model)
private System.Int32 <SortEnemiesBySlotName>b__70_0(MegaCrit.Sts2.Core.Entities.Creatures.Creature a, MegaCrit.Sts2.Core.Entities.Creatures.Creature b)
private System.Void AddCard(MegaCrit.Sts2.Core.Models.CardModel card)
private System.Void AttachCreature(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
private System.Void set_Encounter(MegaCrit.Sts2.Core.Models.EncounterModel value)
private System.Void set_MultiplayerScalingModel(MegaCrit.Sts2.Core.Models.Singleton.MultiplayerScalingModel value)
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.BadgeModel> get_BadgeModels()
public virtual [async] System.Threading.Tasks.Task<MegaCrit.Sts2.Core.Entities.Creatures.Creature> GetCreatureAsync(System.Nullable<System.UInt32> combatId, System.Double timeoutSec)
public virtual MegaCrit.Sts2.Core.Combat.CombatSide get_CurrentSide()
public virtual MegaCrit.Sts2.Core.Entities.Creatures.Creature CreateCreature(MegaCrit.Sts2.Core.Models.MonsterModel monster, MegaCrit.Sts2.Core.Combat.CombatSide side, System.String slot)
public virtual MegaCrit.Sts2.Core.Entities.Creatures.Creature GetCreature(System.Nullable<System.UInt32> combatId)
public virtual MegaCrit.Sts2.Core.Entities.Players.Player GetPlayer(System.UInt64 playerId)
public virtual MegaCrit.Sts2.Core.Models.CardModel CloneCard(MegaCrit.Sts2.Core.Models.CardModel mutableCard)
public virtual MegaCrit.Sts2.Core.Models.CardModel CreateCard(MegaCrit.Sts2.Core.Models.CardModel canonicalCard, MegaCrit.Sts2.Core.Entities.Players.Player owner)
public virtual MegaCrit.Sts2.Core.Models.EncounterModel get_Encounter()
public virtual MegaCrit.Sts2.Core.Models.Singleton.MultiplayerScalingModel get_MultiplayerScalingModel()
public virtual MegaCrit.Sts2.Core.Runs.IRunState get_RunState()
public virtual System.Boolean ContainsCard(MegaCrit.Sts2.Core.Models.CardModel card)
public virtual System.Boolean ContainsCreature(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public virtual System.Boolean ContainsMonster<T>() where T: [None] MegaCrit.Sts2.Core.Models.MonsterModel
public virtual System.Boolean IsLiveCombat()
public virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AbstractModel> IterateHookListeners()
public virtual System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> get_Allies()
public virtual System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> get_Creatures()
public virtual System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> get_CreaturesOnCurrentSide()
public virtual System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> get_Enemies()
public virtual System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> get_EscapedCreatures()
public virtual System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> get_HittableEnemies()
public virtual System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> get_PlayerCreatures()
public virtual System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> GetCreaturesOnSide(MegaCrit.Sts2.Core.Combat.CombatSide side)
public virtual System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> GetOpponentsOf(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public virtual System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> GetTeammatesOf(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public virtual System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Players.Player> get_Players()
public virtual System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel> get_Modifiers()
public virtual System.Int32 get_RoundNumber()
public virtual System.Void add_CreaturesChanged(System.Action<MegaCrit.Sts2.Core.Combat.ICombatState> value)
public virtual System.Void AddCard(MegaCrit.Sts2.Core.Models.CardModel card, MegaCrit.Sts2.Core.Entities.Players.Player owner)
public virtual System.Void AddCreature(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public virtual System.Void AddPlayer(MegaCrit.Sts2.Core.Entities.Players.Player player)
public virtual System.Void CreatureEscaped(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public virtual System.Void remove_CreaturesChanged(System.Action<MegaCrit.Sts2.Core.Combat.ICombatState> value)
public virtual System.Void RemoveCard(MegaCrit.Sts2.Core.Models.CardModel card)
public virtual System.Void RemoveCreature(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature, System.Boolean unattach = True)
public virtual System.Void set_CurrentSide(MegaCrit.Sts2.Core.Combat.CombatSide value)
public virtual System.Void set_RoundNumber(System.Int32 value)
public virtual System.Void SetEnemyIndex(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature, System.Int32 index)
public virtual System.Void SortEnemiesBySlotName()
public virtual T CreateCard<T>(MegaCrit.Sts2.Core.Entities.Players.Player owner) where T: [None] MegaCrit.Sts2.Core.Models.CardModel
```

## MegaCrit.Sts2.Core.Combat.CombatState+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Combat.CombatState+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Entities.Creatures.Creature, System.Boolean> <>9__16_0
public static System.Func<MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Entities.Players.Player> <>9__18_0
public static System.Func<MegaCrit.Sts2.Core.Entities.Creatures.Creature, System.Boolean> <>9__67_0
private static .cctor()
public .ctor()
internal MegaCrit.Sts2.Core.Entities.Players.Player <get_Players>b__18_0(MegaCrit.Sts2.Core.Entities.Creatures.Creature c)
internal System.Boolean <get_HittableEnemies>b__67_0(MegaCrit.Sts2.Core.Entities.Creatures.Creature e)
internal System.Boolean <get_PlayerCreatures>b__16_0(MegaCrit.Sts2.Core.Entities.Creatures.Creature c)
```

## MegaCrit.Sts2.Core.Combat.CombatState+<>c__58<T>

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Combat.CombatState+<>c__58<T> <>9
public static System.Func<MegaCrit.Sts2.Core.Entities.Creatures.Creature, System.Boolean> <>9__58_0
private static .cctor()
public .ctor()
internal System.Boolean <ContainsMonster>b__58_0(MegaCrit.Sts2.Core.Entities.Creatures.Creature c)
```

## MegaCrit.Sts2.Core.Combat.CombatState+<>c__DisplayClass59_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.Nullable<System.UInt32> combatId
public .ctor()
internal System.Boolean <GetCreature>b__0(MegaCrit.Sts2.Core.Entities.Creatures.Creature c)
```

## MegaCrit.Sts2.Core.Combat.CombatState+<>c__DisplayClass60_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Combat.CombatState <>4__this
public System.Nullable<System.UInt32> combatId
public System.Threading.Tasks.TaskCompletionSource<MegaCrit.Sts2.Core.Entities.Creatures.Creature> completionSource
public .ctor()
internal System.Void <GetCreatureAsync>g__OnCreaturesChanged|0(MegaCrit.Sts2.Core.Combat.ICombatState _)
```

## MegaCrit.Sts2.Core.Combat.CombatState+<>c__DisplayClass68_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.UInt64 playerId
public .ctor()
internal System.Boolean <GetPlayer>b__0(MegaCrit.Sts2.Core.Entities.Players.Player p)
```

## MegaCrit.Sts2.Core.Combat.CombatState+<GetCreatureAsync>d__60

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Combat.CombatState <>4__this
private MegaCrit.Sts2.Core.Combat.CombatState+<>c__DisplayClass60_0 <>8__1
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<MegaCrit.Sts2.Core.Entities.Creatures.Creature> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Threading.Tasks.Task> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Entities.Creatures.Creature> <>u__2
private System.Threading.Tasks.Task <timeoutTask>5__2
public System.Nullable<System.UInt32> combatId
public System.Double timeoutSec
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Combat.CombatState+<GodotTimerTask>d__75

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Object <>u__2
public System.Double timeSec
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Combat.CombatState+<IterateHookListeners>d__69

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：`System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AbstractModel>`, `System.Collections.IEnumerable`, `System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Models.AbstractModel>`, `System.Collections.IEnumerator`, `System.IDisposable`

```text
private System.Int32 <>1__state
private MegaCrit.Sts2.Core.Models.AbstractModel <>2__current
public MegaCrit.Sts2.Core.Combat.CombatState <>4__this
private System.Collections.Generic.List+Enumerator<MegaCrit.Sts2.Core.Models.AbstractModel> <>7__wrap1
private System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Models.AbstractModel> <>7__wrap2
private System.Int32 <>l__initialThreadId
MegaCrit.Sts2.Core.Models.AbstractModel System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Models.AbstractModel>.Current { private virtual get; }
System.Object System.Collections.IEnumerator.Current { private virtual get; }
public .ctor(System.Int32 <>1__state)
private System.Void <>m__Finally1()
private System.Void <>m__Finally2()
private virtual MegaCrit.Sts2.Core.Models.AbstractModel System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Models.AbstractModel>.get_Current()
private virtual System.Boolean MoveNext()
private virtual System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Models.AbstractModel> System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AbstractModel>.GetEnumerator()
private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
private virtual System.Object System.Collections.IEnumerator.get_Current()
private virtual System.Void System.Collections.IEnumerator.Reset()
private virtual System.Void System.IDisposable.Dispose()
```

## MegaCrit.Sts2.Core.Combat.CombatStateTracker

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private readonly MegaCrit.Sts2.Core.Combat.CombatManager _combatManager
private System.Threading.Tasks.Task _combatStateChangedDeferredTask
private MegaCrit.Sts2.Core.Combat.CombatState _state
private System.Action<MegaCrit.Sts2.Core.Combat.CombatState> CombatStateChanged
event System.Action<MegaCrit.Sts2.Core.Combat.CombatState> CombatStateChanged
public .ctor(MegaCrit.Sts2.Core.Combat.CombatManager combatManager)
private [async] System.Threading.Tasks.Task CallCombatStateChangedDeferred()
private System.Void NotifyCombatStateChanged(System.String caller)
private System.Void OnCardPileContentsChanged()
private System.Void OnCardValueChanged()
private System.Void OnCombatBegan(MegaCrit.Sts2.Core.Combat.CombatState _)
private System.Void OnCombatHistoryChanged()
private System.Void OnCreatureChanged(MegaCrit.Sts2.Core.Entities.Creatures.Creature _)
private System.Void OnCreaturesChanged(MegaCrit.Sts2.Core.Combat.CombatState _)
private System.Void OnCreatureValueChanged(System.Int32 _, System.Int32 __)
private System.Void OnPlayerCombatStateValueChanged(System.Int32 _, System.Int32 __)
private System.Void OnPlayerStateChanged()
private System.Void OnPowerAppliedOrRemoved(MegaCrit.Sts2.Core.Models.PowerModel _)
private System.Void OnPowerDecreased(MegaCrit.Sts2.Core.Models.PowerModel _, System.Boolean __)
private System.Void OnPowerIncreased(MegaCrit.Sts2.Core.Models.PowerModel _, System.Int32 __, System.Boolean ___)
private System.Void OnTurnEnded(MegaCrit.Sts2.Core.Combat.CombatState _)
private System.Void OnTurnStarted(MegaCrit.Sts2.Core.Combat.CombatState _)
protected virtual System.Void Finalize()
public System.Void add_CombatStateChanged(System.Action<MegaCrit.Sts2.Core.Combat.CombatState> value)
public System.Void remove_CombatStateChanged(System.Action<MegaCrit.Sts2.Core.Combat.CombatState> value)
public System.Void SetState(MegaCrit.Sts2.Core.Combat.CombatState state)
public System.Void Subscribe(MegaCrit.Sts2.Core.Entities.Cards.CardPile pile)
public System.Void Subscribe(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public System.Void Subscribe(MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState combatState)
public System.Void Subscribe(MegaCrit.Sts2.Core.Models.CardModel card)
public System.Void Unsubscribe(MegaCrit.Sts2.Core.Entities.Cards.CardPile pile)
public System.Void Unsubscribe(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public System.Void Unsubscribe(MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState combatState)
public System.Void Unsubscribe(MegaCrit.Sts2.Core.Models.CardModel card)
```

## MegaCrit.Sts2.Core.Combat.CombatStateTracker+<CallCombatStateChangedDeferred>d__32

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Combat.CombatStateTracker <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Combat.CombatTurnState

类型属性：`Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private readonly System.Threading.CancellationTokenSource _cts
private static System.Int32 _sequenceCounter
private System.Threading.Tasks.TaskCompletionSource<System.Func<System.Threading.Tasks.Task>> <BeginEnemyTurnSignalSource>k__BackingField
private System.Boolean <EndingPlayerTurnPhaseOne>k__BackingField
private System.Boolean <EndingPlayerTurnPhaseTwo>k__BackingField
private System.Threading.Tasks.TaskCompletionSource<MegaCrit.Sts2.Core.Combat.EndTurnSignal> <EndTurnSignalSource>k__BackingField
private readonly MegaCrit.Sts2.Core.Combat.CombatId <Id>k__BackingField
private System.Boolean <IsEnemyTurnStarted>k__BackingField
private System.Boolean <IsInProgress>k__BackingField
private System.Boolean <IsStarting>k__BackingField
private MegaCrit.Sts2.Core.Combat.PendingLossState <PendingLoss>k__BackingField
private readonly System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Entities.Players.Player> <PlayersReadyToBeginEnemyTurn>k__BackingField
private readonly System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Entities.Players.Player> <PlayersReadyToEndTurn>k__BackingField
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Players.Player> <PlayersTakingExtraTurn>k__BackingField
private readonly System.Threading.Lock <ReadyLock>k__BackingField
private readonly MegaCrit.Sts2.Core.Combat.CombatState <State>k__BackingField
System.Threading.Tasks.TaskCompletionSource<System.Func<System.Threading.Tasks.Task>> BeginEnemyTurnSignalSource { public get; public set; }
System.Threading.CancellationToken Ct { public get; }
System.Boolean EndingPlayerTurnPhaseOne { public get; public set; }
System.Boolean EndingPlayerTurnPhaseTwo { public get; public set; }
System.Threading.Tasks.TaskCompletionSource<MegaCrit.Sts2.Core.Combat.EndTurnSignal> EndTurnSignalSource { public get; public set; }
MegaCrit.Sts2.Core.Combat.CombatId Id { public get; }
System.Boolean IsEnemyTurnStarted { public get; public set; }
System.Boolean IsInProgress { public get; public set; }
System.Boolean IsLive { public get; }
System.Boolean IsStarting { public get; public set; }
MegaCrit.Sts2.Core.Combat.PendingLossState PendingLoss { public get; public set; }
System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Entities.Players.Player> PlayersReadyToBeginEnemyTurn { public get; }
System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Entities.Players.Player> PlayersReadyToEndTurn { public get; }
System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Players.Player> PlayersTakingExtraTurn { public get; }
System.Threading.Lock ReadyLock { public get; }
MegaCrit.Sts2.Core.Combat.CombatState State { public get; }
public .ctor(MegaCrit.Sts2.Core.Combat.CombatState state)
public MegaCrit.Sts2.Core.Combat.CombatId get_Id()
public MegaCrit.Sts2.Core.Combat.CombatState get_State()
public MegaCrit.Sts2.Core.Combat.PendingLossState get_PendingLoss()
public System.Boolean get_EndingPlayerTurnPhaseOne()
public System.Boolean get_EndingPlayerTurnPhaseTwo()
public System.Boolean get_IsEnemyTurnStarted()
public System.Boolean get_IsInProgress()
public System.Boolean get_IsLive()
public System.Boolean get_IsStarting()
public System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Entities.Players.Player> get_PlayersReadyToBeginEnemyTurn()
public System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Entities.Players.Player> get_PlayersReadyToEndTurn()
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Players.Player> get_PlayersTakingExtraTurn()
public System.Threading.CancellationToken get_Ct()
public System.Threading.Lock get_ReadyLock()
public System.Threading.Tasks.TaskCompletionSource<MegaCrit.Sts2.Core.Combat.EndTurnSignal> get_EndTurnSignalSource()
public System.Threading.Tasks.TaskCompletionSource<System.Func<System.Threading.Tasks.Task>> get_BeginEnemyTurnSignalSource()
public System.Void Cancel()
public System.Void set_BeginEnemyTurnSignalSource(System.Threading.Tasks.TaskCompletionSource<System.Func<System.Threading.Tasks.Task>> value)
public System.Void set_EndingPlayerTurnPhaseOne(System.Boolean value)
public System.Void set_EndingPlayerTurnPhaseTwo(System.Boolean value)
public System.Void set_EndTurnSignalSource(System.Threading.Tasks.TaskCompletionSource<MegaCrit.Sts2.Core.Combat.EndTurnSignal> value)
public System.Void set_IsEnemyTurnStarted(System.Boolean value)
public System.Void set_IsInProgress(System.Boolean value)
public System.Void set_IsStarting(System.Boolean value)
public System.Void set_PendingLoss(MegaCrit.Sts2.Core.Combat.PendingLossState value)
```

## MegaCrit.Sts2.Core.Combat.EndTurnSignal

类型属性：`Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：`System.IEquatable<MegaCrit.Sts2.Core.Combat.EndTurnSignal>`

```text
private readonly System.Func<System.Threading.Tasks.Task> <ActionDuringEnemyTurn>k__BackingField
private readonly MegaCrit.Sts2.Core.GameActions.GameAction <RunningAction>k__BackingField
private readonly MegaCrit.Sts2.Core.Entities.Players.Player <ScheduledPlayer>k__BackingField
private readonly System.Int32 <ScheduledTurnNumber>k__BackingField
System.Func<System.Threading.Tasks.Task> ActionDuringEnemyTurn { public get; public set; }
System.Type EqualityContract { private get; }
MegaCrit.Sts2.Core.GameActions.GameAction RunningAction { public get; public set; }
MegaCrit.Sts2.Core.Entities.Players.Player ScheduledPlayer { public get; public set; }
System.Int32 ScheduledTurnNumber { public get; public set; }
private .ctor(MegaCrit.Sts2.Core.Combat.EndTurnSignal original)
public .ctor(MegaCrit.Sts2.Core.GameActions.GameAction RunningAction, System.Int32 ScheduledTurnNumber, MegaCrit.Sts2.Core.Entities.Players.Player ScheduledPlayer, System.Func<System.Threading.Tasks.Task> ActionDuringEnemyTurn)
private System.Boolean PrintMembers(System.Text.StringBuilder builder)
private System.Type get_EqualityContract()
public MegaCrit.Sts2.Core.Combat.EndTurnSignal <Clone>$()
public MegaCrit.Sts2.Core.Entities.Players.Player get_ScheduledPlayer()
public MegaCrit.Sts2.Core.GameActions.GameAction get_RunningAction()
public static System.Boolean op_Equality(MegaCrit.Sts2.Core.Combat.EndTurnSignal left, MegaCrit.Sts2.Core.Combat.EndTurnSignal right)
public static System.Boolean op_Inequality(MegaCrit.Sts2.Core.Combat.EndTurnSignal left, MegaCrit.Sts2.Core.Combat.EndTurnSignal right)
public System.Func<System.Threading.Tasks.Task> get_ActionDuringEnemyTurn()
public System.Int32 get_ScheduledTurnNumber()
public System.Void Deconstruct(out MegaCrit.Sts2.Core.GameActions.GameAction RunningAction, out System.Int32 ScheduledTurnNumber, out MegaCrit.Sts2.Core.Entities.Players.Player ScheduledPlayer, out System.Func<System.Threading.Tasks.Task> ActionDuringEnemyTurn)
public System.Void set_ActionDuringEnemyTurn(System.Func<System.Threading.Tasks.Task> value)
public System.Void set_RunningAction(MegaCrit.Sts2.Core.GameActions.GameAction value)
public System.Void set_ScheduledPlayer(MegaCrit.Sts2.Core.Entities.Players.Player value)
public System.Void set_ScheduledTurnNumber(System.Int32 value)
public virtual System.Boolean Equals(MegaCrit.Sts2.Core.Combat.EndTurnSignal other)
public virtual System.Boolean Equals(System.Object obj)
public virtual System.Int32 GetHashCode()
public virtual System.String ToString()
```

## MegaCrit.Sts2.Core.Combat.ICombatState

类型属性：`Public, ClassSemanticsMask, Abstract, BeforeFieldInit`；基类：`无`。

接口：

```text
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> Allies { public abstract get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> Creatures { public abstract get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> CreaturesOnCurrentSide { public abstract get; }
MegaCrit.Sts2.Core.Combat.CombatSide CurrentSide { public abstract get; public abstract set; }
MegaCrit.Sts2.Core.Models.EncounterModel Encounter { public abstract get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> Enemies { public abstract get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> EscapedCreatures { public abstract get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> HittableEnemies { public abstract get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel> Modifiers { public abstract get; }
MegaCrit.Sts2.Core.Models.Singleton.MultiplayerScalingModel MultiplayerScalingModel { public abstract get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> PlayerCreatures { public abstract get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Players.Player> Players { public abstract get; }
System.Int32 RoundNumber { public abstract get; public abstract set; }
MegaCrit.Sts2.Core.Runs.IRunState RunState { public abstract get; }
event System.Action<MegaCrit.Sts2.Core.Combat.ICombatState> CreaturesChanged
public abstract MegaCrit.Sts2.Core.Combat.CombatSide get_CurrentSide()
public abstract MegaCrit.Sts2.Core.Entities.Creatures.Creature CreateCreature(MegaCrit.Sts2.Core.Models.MonsterModel monster, MegaCrit.Sts2.Core.Combat.CombatSide side, System.String slot)
public abstract MegaCrit.Sts2.Core.Entities.Creatures.Creature GetCreature(System.Nullable<System.UInt32> combatId)
public abstract MegaCrit.Sts2.Core.Entities.Players.Player GetPlayer(System.UInt64 playerId)
public abstract MegaCrit.Sts2.Core.Models.CardModel CloneCard(MegaCrit.Sts2.Core.Models.CardModel mutableCard)
public abstract MegaCrit.Sts2.Core.Models.CardModel CreateCard(MegaCrit.Sts2.Core.Models.CardModel canonicalCard, MegaCrit.Sts2.Core.Entities.Players.Player owner)
public abstract MegaCrit.Sts2.Core.Models.EncounterModel get_Encounter()
public abstract MegaCrit.Sts2.Core.Models.Singleton.MultiplayerScalingModel get_MultiplayerScalingModel()
public abstract MegaCrit.Sts2.Core.Runs.IRunState get_RunState()
public abstract System.Boolean ContainsCard(MegaCrit.Sts2.Core.Models.CardModel card)
public abstract System.Boolean ContainsCreature(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public abstract System.Boolean ContainsMonster<T>() where T: [None] MegaCrit.Sts2.Core.Models.MonsterModel
public abstract System.Boolean IsLiveCombat()
public abstract System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AbstractModel> IterateHookListeners()
public abstract System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> get_Allies()
public abstract System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> get_Creatures()
public abstract System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> get_CreaturesOnCurrentSide()
public abstract System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> get_Enemies()
public abstract System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> get_EscapedCreatures()
public abstract System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> get_HittableEnemies()
public abstract System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> get_PlayerCreatures()
public abstract System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> GetCreaturesOnSide(MegaCrit.Sts2.Core.Combat.CombatSide side)
public abstract System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> GetOpponentsOf(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public abstract System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> GetTeammatesOf(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public abstract System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Players.Player> get_Players()
public abstract System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel> get_Modifiers()
public abstract System.Int32 get_RoundNumber()
public abstract System.Threading.Tasks.Task<MegaCrit.Sts2.Core.Entities.Creatures.Creature> GetCreatureAsync(System.Nullable<System.UInt32> combatId, System.Double timeoutSec)
public abstract System.Void add_CreaturesChanged(System.Action<MegaCrit.Sts2.Core.Combat.ICombatState> value)
public abstract System.Void AddCard(MegaCrit.Sts2.Core.Models.CardModel card, MegaCrit.Sts2.Core.Entities.Players.Player owner)
public abstract System.Void AddCreature(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public abstract System.Void AddPlayer(MegaCrit.Sts2.Core.Entities.Players.Player player)
public abstract System.Void CreatureEscaped(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public abstract System.Void remove_CreaturesChanged(System.Action<MegaCrit.Sts2.Core.Combat.ICombatState> value)
public abstract System.Void RemoveCard(MegaCrit.Sts2.Core.Models.CardModel card)
public abstract System.Void RemoveCreature(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature, System.Boolean unattach = True)
public abstract System.Void set_CurrentSide(MegaCrit.Sts2.Core.Combat.CombatSide value)
public abstract System.Void set_RoundNumber(System.Int32 value)
public abstract System.Void SetEnemyIndex(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature, System.Int32 index)
public abstract System.Void SortEnemiesBySlotName()
public abstract T CreateCard<T>(MegaCrit.Sts2.Core.Entities.Players.Player owner) where T: [None] MegaCrit.Sts2.Core.Models.CardModel
```

## MegaCrit.Sts2.Core.Combat.NullCombatState

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：`MegaCrit.Sts2.Core.Combat.ICombatState`

```text
private readonly System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> <Allies>k__BackingField
private readonly System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> <Creatures>k__BackingField
private readonly System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> <CreaturesOnCurrentSide>k__BackingField
private MegaCrit.Sts2.Core.Combat.CombatSide <CurrentSide>k__BackingField
private readonly System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> <Enemies>k__BackingField
private readonly System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> <HittableEnemies>k__BackingField
private static readonly MegaCrit.Sts2.Core.Combat.NullCombatState <Instance>k__BackingField
private readonly System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel> <Modifiers>k__BackingField
private readonly System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> <PlayerCreatures>k__BackingField
private readonly System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Players.Player> <Players>k__BackingField
private System.Int32 <RoundNumber>k__BackingField
private System.Action<MegaCrit.Sts2.Core.Combat.ICombatState> CreaturesChanged
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> Allies { public virtual get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> Creatures { public virtual get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> CreaturesOnCurrentSide { public virtual get; }
MegaCrit.Sts2.Core.Combat.CombatSide CurrentSide { public virtual get; public virtual set; }
MegaCrit.Sts2.Core.Models.EncounterModel Encounter { public virtual get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> Enemies { public virtual get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> EscapedCreatures { public virtual get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> HittableEnemies { public virtual get; }
MegaCrit.Sts2.Core.Combat.NullCombatState Instance { public static get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel> Modifiers { public virtual get; }
MegaCrit.Sts2.Core.Models.Singleton.MultiplayerScalingModel MultiplayerScalingModel { public virtual get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> PlayerCreatures { public virtual get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Players.Player> Players { public virtual get; }
System.Int32 RoundNumber { public virtual get; public virtual set; }
MegaCrit.Sts2.Core.Runs.IRunState RunState { public virtual get; }
event System.Action<MegaCrit.Sts2.Core.Combat.ICombatState> CreaturesChanged
private static .cctor()
public .ctor()
public static MegaCrit.Sts2.Core.Combat.NullCombatState get_Instance()
public virtual MegaCrit.Sts2.Core.Combat.CombatSide get_CurrentSide()
public virtual MegaCrit.Sts2.Core.Entities.Creatures.Creature CreateCreature(MegaCrit.Sts2.Core.Models.MonsterModel monster, MegaCrit.Sts2.Core.Combat.CombatSide side, System.String slot)
public virtual MegaCrit.Sts2.Core.Entities.Creatures.Creature GetCreature(System.Nullable<System.UInt32> combatId)
public virtual MegaCrit.Sts2.Core.Entities.Players.Player GetPlayer(System.UInt64 playerId)
public virtual MegaCrit.Sts2.Core.Models.CardModel CloneCard(MegaCrit.Sts2.Core.Models.CardModel mutableCard)
public virtual MegaCrit.Sts2.Core.Models.CardModel CreateCard(MegaCrit.Sts2.Core.Models.CardModel canonicalCard, MegaCrit.Sts2.Core.Entities.Players.Player owner)
public virtual MegaCrit.Sts2.Core.Models.EncounterModel get_Encounter()
public virtual MegaCrit.Sts2.Core.Models.Singleton.MultiplayerScalingModel get_MultiplayerScalingModel()
public virtual MegaCrit.Sts2.Core.Runs.IRunState get_RunState()
public virtual System.Boolean ContainsCard(MegaCrit.Sts2.Core.Models.CardModel card)
public virtual System.Boolean ContainsCreature(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public virtual System.Boolean ContainsMonster<T>() where T: [None] MegaCrit.Sts2.Core.Models.MonsterModel
public virtual System.Boolean IsLiveCombat()
public virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AbstractModel> IterateHookListeners()
public virtual System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> get_Allies()
public virtual System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> get_Creatures()
public virtual System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> get_CreaturesOnCurrentSide()
public virtual System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> get_Enemies()
public virtual System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> get_EscapedCreatures()
public virtual System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> get_HittableEnemies()
public virtual System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> get_PlayerCreatures()
public virtual System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> GetCreaturesOnSide(MegaCrit.Sts2.Core.Combat.CombatSide side)
public virtual System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> GetOpponentsOf(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public virtual System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> GetTeammatesOf(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public virtual System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Players.Player> get_Players()
public virtual System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel> get_Modifiers()
public virtual System.Int32 get_RoundNumber()
public virtual System.Threading.Tasks.Task<MegaCrit.Sts2.Core.Entities.Creatures.Creature> GetCreatureAsync(System.Nullable<System.UInt32> combatId, System.Double timeoutSec)
public virtual System.Void add_CreaturesChanged(System.Action<MegaCrit.Sts2.Core.Combat.ICombatState> value)
public virtual System.Void AddCard(MegaCrit.Sts2.Core.Models.CardModel card, MegaCrit.Sts2.Core.Entities.Players.Player owner)
public virtual System.Void AddCreature(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public virtual System.Void AddPlayer(MegaCrit.Sts2.Core.Entities.Players.Player player)
public virtual System.Void CreatureEscaped(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public virtual System.Void remove_CreaturesChanged(System.Action<MegaCrit.Sts2.Core.Combat.ICombatState> value)
public virtual System.Void RemoveCard(MegaCrit.Sts2.Core.Models.CardModel card)
public virtual System.Void RemoveCreature(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature, System.Boolean unattach = True)
public virtual System.Void set_CurrentSide(MegaCrit.Sts2.Core.Combat.CombatSide value)
public virtual System.Void set_RoundNumber(System.Int32 value)
public virtual System.Void SetEnemyIndex(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature, System.Int32 index)
public virtual System.Void SortEnemiesBySlotName()
public virtual T CreateCard<T>(MegaCrit.Sts2.Core.Entities.Players.Player owner) where T: [None] MegaCrit.Sts2.Core.Models.CardModel
```

## MegaCrit.Sts2.Core.Combat.PendingLossState

类型属性：`Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：`System.IEquatable<MegaCrit.Sts2.Core.Combat.PendingLossState>`

```text
private readonly MegaCrit.Sts2.Core.Rooms.CombatRoom <Room>k__BackingField
System.Type EqualityContract { private get; }
MegaCrit.Sts2.Core.Rooms.CombatRoom Room { public get; public set; }
private .ctor(MegaCrit.Sts2.Core.Combat.PendingLossState original)
public .ctor(MegaCrit.Sts2.Core.Rooms.CombatRoom Room)
private System.Boolean PrintMembers(System.Text.StringBuilder builder)
private System.Type get_EqualityContract()
public MegaCrit.Sts2.Core.Combat.PendingLossState <Clone>$()
public MegaCrit.Sts2.Core.Rooms.CombatRoom get_Room()
public static System.Boolean op_Equality(MegaCrit.Sts2.Core.Combat.PendingLossState left, MegaCrit.Sts2.Core.Combat.PendingLossState right)
public static System.Boolean op_Inequality(MegaCrit.Sts2.Core.Combat.PendingLossState left, MegaCrit.Sts2.Core.Combat.PendingLossState right)
public System.Void Deconstruct(out MegaCrit.Sts2.Core.Rooms.CombatRoom Room)
public System.Void set_Room(MegaCrit.Sts2.Core.Rooms.CombatRoom value)
public virtual System.Boolean Equals(MegaCrit.Sts2.Core.Combat.PendingLossState other)
public virtual System.Boolean Equals(System.Object obj)
public virtual System.Int32 GetHashCode()
public virtual System.String ToString()
```

## MegaCrit.Sts2.Core.Combat.PlayerTurnPhase

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Combat.PlayerTurnPhase AutoPostPlay = 4
public static const MegaCrit.Sts2.Core.Combat.PlayerTurnPhase AutoPrePlay = 2
public static const MegaCrit.Sts2.Core.Combat.PlayerTurnPhase End = 5
public static const MegaCrit.Sts2.Core.Combat.PlayerTurnPhase None = 0
public static const MegaCrit.Sts2.Core.Combat.PlayerTurnPhase Play = 3
public static const MegaCrit.Sts2.Core.Combat.PlayerTurnPhase Start = 1
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Combat.StuckCombatException

类型属性：`Public, BeforeFieldInit`；基类：`System.Exception`。

接口：`System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.String message, System.Exception innerException)
```
