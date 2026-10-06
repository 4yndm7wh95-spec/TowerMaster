# MegaCrit.Sts2.Core.Nodes.TopBar

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.TopBar.NRunTimer

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private Godot.Timer _timer
private MegaCrit.Sts2.addons.mega_text.MegaLabel _timerLabel
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void <DeferredInit>b__3_0()
private System.Void DeferredInit()
private System.Void OnTimerTimeout()
private System.Void ToggleTimer(System.Boolean on)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void RefreshVisibility()
public virtual System.Void _Notification(System.Int32 what)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.TopBar.NRunTimer+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Notification
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName DeferredInit
public static readonly Godot.StringName OnTimerTimeout
public static readonly Godot.StringName RefreshVisibility
public static readonly Godot.StringName ToggleTimer
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.TopBar.NRunTimer+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _timer
public static readonly Godot.StringName _timerLabel
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.TopBar.NRunTimer+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarButton

类型属性：`Public, Abstract, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private static const System.Single _defaultV = 1
private static const System.Single _hoverAngle = -0.20943952
private System.Threading.CancellationTokenSource _hoverAnimCancelToken
protected static const System.Single _hoverAnimDur = 0.5
protected static readonly Godot.Vector2 _hoverScale
private static const System.Single _hoverShaderV = 1.1
protected Godot.ShaderMaterial _hsv
protected Godot.Control _icon
private System.Threading.CancellationTokenSource _pressDownCancelToken
protected static const System.Single _pressDownDur = 0.25
private static const System.Single _pressDownV = 0.4
private System.Threading.CancellationTokenSource _unhoverAnimCancelToken
protected static const System.Single _unhoverAnimDur = 1
private static readonly Godot.StringName _v
private System.Boolean <IsScreenOpen>k__BackingField
System.Boolean IsScreenOpen { protected get; private set; }
private static .cctor()
protected .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void CancelAnimations()
private System.Void OnScreenClosed()
private System.Void set_IsScreenOpen(System.Boolean value)
protected abstract System.Boolean IsOpen()
protected System.Boolean get_IsScreenOpen()
protected System.Void InitTopBarButton()
protected System.Void UpdateScreenOpen()
protected virtual [async] System.Threading.Tasks.Task AnimHover(System.Threading.CancellationTokenSource cancelToken)
protected virtual [async] System.Threading.Tasks.Task AnimPressDown(System.Threading.CancellationTokenSource cancelToken)
protected virtual [async] System.Threading.Tasks.Task AnimUnhover(System.Threading.CancellationTokenSource cancelToken)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnDisable()
protected virtual System.Void OnEnable()
protected virtual System.Void OnFocus()
protected virtual System.Void OnPress()
protected virtual System.Void OnRelease()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarButton+<AnimHover>d__27

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarButton <>4__this
private System.Single <>7__wrap2
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
private System.Single <startAngle>5__2
public System.Threading.CancellationTokenSource cancelToken
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarButton+<AnimPressDown>d__23

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarButton <>4__this
private System.Single <>7__wrap3
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
private System.Single <startAngle>5__2
private System.Single <targetAngle>5__3
public System.Threading.CancellationTokenSource cancelToken
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarButton+<AnimUnhover>d__29

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarButton <>4__this
private System.Single <>7__wrap2
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
private System.Single <startAngle>5__2
public System.Threading.CancellationTokenSource cancelToken
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName CancelAnimations
public static readonly Godot.StringName InitTopBarButton
public static readonly Godot.StringName IsOpen
public static readonly Godot.StringName OnDisable
public static readonly Godot.StringName OnEnable
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnScreenClosed
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName UpdateScreenOpen
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _hsv
public static readonly Godot.StringName _icon
public static readonly Godot.StringName IsScreenOpen
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarDeckButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarButton`。

接口：`System.IDisposable`

```text
private Godot.Tween _bumpTween
private System.Single _count
private MegaCrit.Sts2.addons.mega_text.MegaLabel _countLabel
private static const System.Single _defaultV = 0.9
private System.Single _elapsedTime
private MegaCrit.Sts2.Core.Entities.Cards.CardPile _pile
private MegaCrit.Sts2.Core.Entities.Players.Player _player
private System.Single _rockBaseRotation
private static const System.Single _rockDist = 0.12
private static const System.Single _rockSpeed = 4
private static readonly Godot.StringName _v
System.String[] Hotkeys { protected virtual get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnPileContentsChanged()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean IsOpen()
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.String[] get_Hotkeys()
protected virtual System.Void OnFocus()
protected virtual System.Void OnRelease()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void Initialize(MegaCrit.Sts2.Core.Entities.Players.Player player)
public System.Void ToggleAnimState()
public virtual System.Void _Notification(System.Int32 what)
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarDeckButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Notification
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName IsOpen
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPileContentsChanged
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName ToggleAnimState
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarDeckButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _bumpTween
public static readonly Godot.StringName _count
public static readonly Godot.StringName _countLabel
public static readonly Godot.StringName _elapsedTime
public static readonly Godot.StringName _rockBaseRotation
public static readonly Godot.StringName Hotkeys
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarDeckButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarMapButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarButton`。

接口：`System.IDisposable`

```text
private static const System.Single _defaultV = 0.9
private Godot.Tween _oscillateTween
private static readonly Godot.StringName _v
System.String[] Hotkeys { protected virtual get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean IsOpen()
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.String[] get_Hotkeys()
protected virtual System.Void OnFocus()
protected virtual System.Void OnRelease()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void StartOscillation()
public System.Void StopOscillation()
```

## MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarMapButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarButton+MethodName`。

接口：

```text
public static readonly Godot.StringName IsOpen
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName StartOscillation
public static readonly Godot.StringName StopOscillation
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarMapButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _oscillateTween
public static readonly Godot.StringName Hotkeys
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarMapButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarPauseButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarButton`。

接口：`System.IDisposable`

```text
private static const System.Single _defaultV = 0.9
private static const System.Single _hoverAngle = -3.1415927
private static const System.Single _hoverShaderV = 1.1
private static const System.Single _pressDownV = 0.4
private MegaCrit.Sts2.Core.Runs.IRunState _runState
private static readonly Godot.StringName _v
System.String[] Hotkeys { protected virtual get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual [async] System.Threading.Tasks.Task AnimHover(System.Threading.CancellationTokenSource cancelToken)
protected virtual [async] System.Threading.Tasks.Task AnimPressDown(System.Threading.CancellationTokenSource cancelToken)
protected virtual [async] System.Threading.Tasks.Task AnimUnhover(System.Threading.CancellationTokenSource cancelToken)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean IsOpen()
protected virtual System.String[] get_Hotkeys()
protected virtual System.Void OnFocus()
protected virtual System.Void OnRelease()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void Initialize(MegaCrit.Sts2.Core.Runs.IRunState runState)
public System.Void ToggleAnimState()
public virtual System.Void _Process(System.Double delta)
```

## MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarPauseButton+<AnimHover>d__13

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarPauseButton <>4__this
private System.Single <>7__wrap2
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
private System.Single <startAngle>5__2
public System.Threading.CancellationTokenSource cancelToken
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarPauseButton+<AnimPressDown>d__12

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarPauseButton <>4__this
private System.Single <>7__wrap3
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
private System.Single <startAngle>5__2
private System.Single <targetAngle>5__3
public System.Threading.CancellationTokenSource cancelToken
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarPauseButton+<AnimUnhover>d__14

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarPauseButton <>4__this
private System.Single <>7__wrap2
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
private System.Single <startAngle>5__2
public System.Threading.CancellationTokenSource cancelToken
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarPauseButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Process
public static readonly Godot.StringName IsOpen
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName ToggleAnimState
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarPauseButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName Hotkeys
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarPauseButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarButton+SignalName`。

接口：

```text
public .ctor()
```
