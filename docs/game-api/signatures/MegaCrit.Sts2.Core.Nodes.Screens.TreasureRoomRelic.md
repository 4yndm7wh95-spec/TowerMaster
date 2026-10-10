# MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NHandImage

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private System.Threading.CancellationTokenSource _cts
private Godot.Vector2 _currentVelocity
private Godot.Vector2 _desiredPosition
private Godot.Tween _downTween
private static readonly Godot.Vector2 _fightingPivot
private Godot.Marker2D _grabMarker
private System.Single _handAnimateInProgress
private System.Boolean _isInFight
private Godot.Vector2 _originalPosition
private static readonly Godot.Vector2 _pointingPivot
private static readonly System.String _scenePath
private MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NHandImage+State _state
private Godot.TextureRect _textureRect
private System.Int32 <Index>k__BackingField
private System.Boolean <IsDown>k__BackingField
private System.Boolean <IsShown>k__BackingField
private MegaCrit.Sts2.Core.Entities.Players.Player <Player>k__BackingField
System.Int32 Index { public get; private set; }
System.Boolean IsDown { public get; private set; }
System.Boolean IsShown { public get; private set; }
MegaCrit.Sts2.Core.Entities.Players.Player Player { public get; private set; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private Godot.Vector2 GetFrozenPosition()
private System.Void <AnimateIn>b__41_0(System.Single v)
private System.Void set_Index(System.Int32 value)
private System.Void set_IsDown(System.Boolean value)
private System.Void set_IsShown(System.Boolean value)
private System.Void set_Player(MegaCrit.Sts2.Core.Entities.Players.Player value)
private System.Void SetTextureToFightMove(MegaCrit.Sts2.Core.Entities.TreasureRelicPicking.RelicPickingFightMove move)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public [async] System.Threading.Tasks.Task DoLoseShake(System.Single duration)
public [async] System.Threading.Tasks.Task GrabRelic(MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NTreasureRoomRelicHolder holder)
public Godot.Tween DoFightMove(MegaCrit.Sts2.Core.Entities.TreasureRelicPicking.RelicPickingFightMove move, System.Single duration)
public MegaCrit.Sts2.Core.Entities.Players.Player get_Player()
public static MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NHandImage Create(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Int32 slotIndex)
public System.Boolean get_IsDown()
public System.Boolean get_IsShown()
public System.Int32 get_Index()
public System.Void AnimateAway()
public System.Void AnimateIn()
public System.Void SetFrozenForRelicAwards(System.Boolean frozenForRelicAwards)
public System.Void SetIsDown(System.Boolean isDown)
public System.Void SetIsInFight(System.Boolean inFight)
public System.Void SetPointingPosition(Godot.Vector2 position)
public System.Void SetSkipped()
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NHandImage+<>c__DisplayClass37_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NHandImage <>4__this
public MegaCrit.Sts2.Core.Entities.TreasureRelicPicking.RelicPickingFightMove move
public .ctor()
internal System.Void <DoFightMove>b__0()
```

## MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NHandImage+<DoLoseShake>d__43

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NHandImage <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.ScreenRumbleInstance <rumble>5__2
public System.Single duration
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NHandImage+<GrabRelic>d__44

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NHandImage <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NHandImage+State <oldState>5__2
public MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NTreasureRoomRelicHolder holder
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NHandImage+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AnimateAway
public static readonly Godot.StringName AnimateIn
public static readonly Godot.StringName DoFightMove
public static readonly Godot.StringName GetFrozenPosition
public static readonly Godot.StringName SetFrozenForRelicAwards
public static readonly Godot.StringName SetIsDown
public static readonly Godot.StringName SetIsInFight
public static readonly Godot.StringName SetPointingPosition
public static readonly Godot.StringName SetSkipped
public static readonly Godot.StringName SetTextureToFightMove
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NHandImage+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _currentVelocity
public static readonly Godot.StringName _desiredPosition
public static readonly Godot.StringName _downTween
public static readonly Godot.StringName _grabMarker
public static readonly Godot.StringName _handAnimateInProgress
public static readonly Godot.StringName _isInFight
public static readonly Godot.StringName _originalPosition
public static readonly Godot.StringName _state
public static readonly Godot.StringName _textureRect
public static readonly Godot.StringName Index
public static readonly Godot.StringName IsDown
public static readonly Godot.StringName IsShown
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NHandImage+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NHandImage+State

类型属性：`NestedPrivate, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NHandImage+State Frozen = 1
public static const MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NHandImage+State GrabbingRelic = 2
public static const MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NHandImage+State None = 0
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NHandImageCollection

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private System.Threading.CancellationTokenSource _cts
private System.Single _handAnimateInProgress
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NHandImage> _hands
private MegaCrit.Sts2.Core.Runs.IRunState _runState
private MegaCrit.Sts2.Core.Multiplayer.Game.PeerInput.PeerInputSynchronizer _synchronizer
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task DoLoseShake(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Single duration)
private System.Threading.Tasks.Task <DoFight>b__20_0(Godot.Tween t)
private System.Void AddHand(System.UInt64 playerId)
private System.Void OnInputStateAdded(System.UInt64 playerId)
private System.Void OnInputStateChanged(System.UInt64 playerId)
private System.Void OnInputStateRemoved(System.UInt64 playerId)
private System.Void ProcessGuiFocus(Godot.Control focusedControl)
private System.Void RemoveHand(System.UInt64 playerId)
private System.Void UpdateHandVisibility()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public [async] System.Threading.Tasks.Task DoFight(MegaCrit.Sts2.Core.Entities.TreasureRelicPicking.RelicPickingResult result, MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NTreasureRoomRelicHolder holder)
public MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NHandImage GetHand(System.UInt64 playerId)
public System.Void AnimateHandsIn()
public System.Void BeforeFightStarted(System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Players.Player> playersInvolved)
public System.Void BeforeRelicsAwarded()
public System.Void Initialize(MegaCrit.Sts2.Core.Runs.IRunState runState)
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Input(Godot.InputEvent inputEvent)
```

## MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NHandImageCollection+<>c__DisplayClass10_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.UInt64 playerId
public .ctor()
internal System.Boolean <AddHand>b__0(MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NHandImage c)
```

## MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NHandImageCollection+<>c__DisplayClass14_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.UInt64 playerId
public .ctor()
internal System.Boolean <GetHand>b__0(MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NHandImage c)
```

## MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NHandImageCollection+<DoFight>d__20

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NHandImageCollection <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Single <durationMultiplier>5__6
private MegaCrit.Sts2.Core.Entities.TreasureRelicPicking.RelicPickingFight <fight>5__2
private System.Int32 <i>5__5
private MegaCrit.Sts2.Core.Entities.TreasureRelicPicking.RelicPickingFightRound <round>5__7
private System.Collections.Generic.List<System.Threading.Tasks.Task> <tasks>5__4
private System.Collections.Generic.List<Godot.Tween> <tweens>5__3
public MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NTreasureRoomRelicHolder holder
public MegaCrit.Sts2.Core.Entities.TreasureRelicPicking.RelicPickingResult result
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NHandImageCollection+<DoLoseShake>d__21

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NHandImageCollection <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NHandImage <hand>5__2
public System.Single duration
public MegaCrit.Sts2.Core.Entities.Players.Player player
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NHandImageCollection+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Input
public static readonly Godot.StringName AddHand
public static readonly Godot.StringName AnimateHandsIn
public static readonly Godot.StringName BeforeRelicsAwarded
public static readonly Godot.StringName GetHand
public static readonly Godot.StringName OnInputStateAdded
public static readonly Godot.StringName OnInputStateChanged
public static readonly Godot.StringName OnInputStateRemoved
public static readonly Godot.StringName ProcessGuiFocus
public static readonly Godot.StringName RemoveHand
public static readonly Godot.StringName UpdateHandVisibility
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NHandImageCollection+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _handAnimateInProgress
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NHandImageCollection+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NTreasureRoomRelicCollection

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private System.Threading.CancellationTokenSource _cts
private Godot.Tween _emptyVfxTween
private Godot.Control _fightBackstop
private MegaCrit.Sts2.addons.mega_text.MegaLabel _fightLabel
private MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NHandImageCollection _hands
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NTreasureRoomRelicHolder> _holdersInUse
private System.Boolean _isEmptyChest
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NTreasureRoomRelicHolder> _multiplayerHolders
private static const System.UInt64 _noSelectionTimeMsec = 200
private System.UInt64 _openedTicks
private Godot.Control _relicContainer
private readonly System.Threading.Tasks.TaskCompletionSource _relicPickingBeganTaskCompletionSource
private readonly System.Threading.Tasks.TaskCompletionSource _relicPickingCompleteTaskCompletionSource
private MegaCrit.Sts2.Core.Runs.IRunState _runState
private MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NTreasureRoomRelicHolder <SingleplayerRelicHolder>k__BackingField
Godot.Control DefaultFocusedControl { public virtual get; }
MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NTreasureRoomRelicHolder SingleplayerRelicHolder { public get; private set; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task AnimateRelicAwards(System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.TreasureRelicPicking.RelicPickingResult> results)
private System.Boolean <AnimOut>b__28_0()
private System.Void OnRelicsAwarded(System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.TreasureRelicPicking.RelicPickingResult> results)
private System.Void PickRelic(MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NTreasureRoomRelicHolder holder)
private System.Void RefreshVotes()
private System.Void set_SingleplayerRelicHolder(MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NTreasureRoomRelicHolder value)
private System.Void SpawnEmptyChestVfx()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NTreasureRoomRelicHolder get_SingleplayerRelicHolder()
public System.Threading.Tasks.Task RelicPickingBegan()
public System.Threading.Tasks.Task RelicPickingFinished()
public System.Void AnimIn()
public System.Void AnimOut()
public System.Void Initialize(MegaCrit.Sts2.Core.Runs.IRunState runState)
public System.Void InitializeRelics()
public System.Void SetSelectionEnabled(System.Boolean isEnabled)
public virtual Godot.Control get_DefaultFocusedControl()
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NTreasureRoomRelicCollection+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NTreasureRoomRelicCollection+<>c <>9
public static System.Action <>9__27_0
public static System.Comparison<MegaCrit.Sts2.Core.Entities.TreasureRelicPicking.RelicPickingResult> <>9__31_0
private static .cctor()
public .ctor()
internal System.Int32 <AnimateRelicAwards>b__31_0(MegaCrit.Sts2.Core.Entities.TreasureRelicPicking.RelicPickingResult r1, MegaCrit.Sts2.Core.Entities.TreasureRelicPicking.RelicPickingResult r2)
internal System.Void <AnimIn>b__27_0()
```

## MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NTreasureRoomRelicCollection+<>c__DisplayClass27_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NTreasureRoomRelicHolder holder
public .ctor()
internal Godot.Control+MouseFilterEnum <AnimIn>b__1()
```

## MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NTreasureRoomRelicCollection+<>c__DisplayClass31_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Entities.TreasureRelicPicking.RelicPickingResult result
public .ctor()
internal System.Boolean <AnimateRelicAwards>b__1(MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NTreasureRoomRelicHolder h)
```

## MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NTreasureRoomRelicCollection+<>c__DisplayClass31_1

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Entities.TreasureRelicPicking.RelicPickingResult result
public .ctor()
internal System.Boolean <AnimateRelicAwards>b__2(MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NTreasureRoomRelicHolder h)
```

## MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NTreasureRoomRelicCollection+<AnimateRelicAwards>d__31

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NTreasureRoomRelicCollection <>4__this
private System.Collections.Generic.List+Enumerator<MegaCrit.Sts2.Core.Entities.TreasureRelicPicking.RelicPickingResult> <>7__wrap2
private MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NTreasureRoomRelicCollection+<>c__DisplayClass31_0 <>8__1
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NTreasureRoomRelicHolder <holder>5__4
private System.Collections.Generic.List<System.Threading.Tasks.Task> <tasksToWait>5__2
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.TreasureRelicPicking.RelicPickingResult> results
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NTreasureRoomRelicCollection+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AnimIn
public static readonly Godot.StringName AnimOut
public static readonly Godot.StringName InitializeRelics
public static readonly Godot.StringName PickRelic
public static readonly Godot.StringName RefreshVotes
public static readonly Godot.StringName SetSelectionEnabled
public static readonly Godot.StringName SpawnEmptyChestVfx
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NTreasureRoomRelicCollection+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _emptyVfxTween
public static readonly Godot.StringName _fightBackstop
public static readonly Godot.StringName _fightLabel
public static readonly Godot.StringName _hands
public static readonly Godot.StringName _isEmptyChest
public static readonly Godot.StringName _openedTicks
public static readonly Godot.StringName _relicContainer
public static readonly Godot.StringName DefaultFocusedControl
public static readonly Godot.StringName SingleplayerRelicHolder
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NTreasureRoomRelicCollection+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NTreasureRoomRelicHolder

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private System.Boolean _animatedIn
private Godot.Tween _initTween
private Godot.GpuParticles2D _rareGlow
private Godot.Tween _tween
private Godot.GpuParticles2D _uncommonGlow
private System.Int32 <Index>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Relics.NRelic <Relic>k__BackingField
private MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer <VoteContainer>k__BackingField
System.Int32 Index { public get; public set; }
MegaCrit.Sts2.Core.Nodes.Relics.NRelic Relic { public get; private set; }
MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer VoteContainer { public get; private set; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Boolean PlayerVotedForRelic(MegaCrit.Sts2.Core.Entities.Players.Player player)
private System.Void set_Relic(MegaCrit.Sts2.Core.Nodes.Relics.NRelic value)
private System.Void set_VoteContainer(MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnFocus()
protected virtual System.Void OnPress()
protected virtual System.Void OnRelease()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer get_VoteContainer()
public MegaCrit.Sts2.Core.Nodes.Relics.NRelic get_Relic()
public System.Int32 get_Index()
public System.Void AnimateAwayVotes()
public System.Void Initialize(MegaCrit.Sts2.Core.Models.RelicModel relic, MegaCrit.Sts2.Core.Runs.IRunState runState)
public System.Void set_Index(System.Int32 value)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NTreasureRoomRelicHolder+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AnimateAwayVotes
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnUnfocus
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NTreasureRoomRelicHolder+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _animatedIn
public static readonly Godot.StringName _initTween
public static readonly Godot.StringName _rareGlow
public static readonly Godot.StringName _tween
public static readonly Godot.StringName _uncommonGlow
public static readonly Godot.StringName Index
public static readonly Godot.StringName Relic
public static readonly Godot.StringName VoteContainer
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NTreasureRoomRelicHolder+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```
