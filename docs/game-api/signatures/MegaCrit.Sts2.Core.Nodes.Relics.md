# MegaCrit.Sts2.Core.Nodes.Relics

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.Relics.NRelic

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Nodes.Relics.NRelic+IconSize _iconSize
private MegaCrit.Sts2.Core.Models.RelicModel _model
private static readonly System.String _scenePath
private Godot.TextureRect <Icon>k__BackingField
private Godot.TextureRect <Outline>k__BackingField
private System.Action<MegaCrit.Sts2.Core.Models.RelicModel, MegaCrit.Sts2.Core.Models.RelicModel> ModelChanged
public static const System.String relicMatPath = "res://materials/ui/relic_mat.tres"
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
Godot.TextureRect Icon { public get; private set; }
MegaCrit.Sts2.Core.Models.RelicModel Model { public get; public set; }
Godot.TextureRect Outline { public get; private set; }
event System.Action<MegaCrit.Sts2.Core.Models.RelicModel, MegaCrit.Sts2.Core.Models.RelicModel> ModelChanged
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void Reload()
private System.Void set_Icon(Godot.TextureRect value)
private System.Void set_Outline(Godot.TextureRect value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public Godot.TextureRect get_Icon()
public Godot.TextureRect get_Outline()
public MegaCrit.Sts2.Core.Models.RelicModel get_Model()
public static MegaCrit.Sts2.Core.Nodes.Relics.NRelic Create(MegaCrit.Sts2.Core.Models.RelicModel relic, MegaCrit.Sts2.Core.Nodes.Relics.NRelic+IconSize iconSize)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Void add_ModelChanged(System.Action<MegaCrit.Sts2.Core.Models.RelicModel, MegaCrit.Sts2.Core.Models.RelicModel> value)
public System.Void remove_ModelChanged(System.Action<MegaCrit.Sts2.Core.Models.RelicModel, MegaCrit.Sts2.Core.Models.RelicModel> value)
public System.Void set_Model(MegaCrit.Sts2.Core.Models.RelicModel value)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Relics.NRelic+IconSize

类型属性：`NestedPublic, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Nodes.Relics.NRelic+IconSize Large = 1
public static const MegaCrit.Sts2.Core.Nodes.Relics.NRelic+IconSize Small = 0
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Nodes.Relics.NRelic+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Reload
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Relics.NRelic+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _iconSize
public static readonly Godot.StringName Icon
public static readonly Godot.StringName Outline
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Relics.NRelic+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Relics.NRelicBasicHolder

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private Godot.Tween _hoverTween
private MegaCrit.Sts2.Core.Models.RelicModel _model
private MegaCrit.Sts2.Core.Nodes.Relics.NRelic _relic
private static readonly System.String _scenePath
MegaCrit.Sts2.Core.Nodes.Relics.NRelic Relic { public get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnFocus()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public MegaCrit.Sts2.Core.Nodes.Relics.NRelic get_Relic()
public static MegaCrit.Sts2.Core.Nodes.Relics.NRelicBasicHolder Create(MegaCrit.Sts2.Core.Models.RelicModel relic)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Relics.NRelicBasicHolder+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnUnfocus
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Relics.NRelicBasicHolder+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _hoverTween
public static readonly Godot.StringName _relic
public static readonly Godot.StringName Relic
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Relics.NRelicBasicHolder+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Relics.NRelicInventory

类型属性：`Public, BeforeFieldInit`；基类：`Godot.FlowContainer`。

接口：`System.IDisposable`

```text
private Godot.Tween _curTween
private Godot.Tween _debugHideTween
private System.Boolean _isDebugHidden
private Godot.Vector2 _originalPos
private MegaCrit.Sts2.Core.Entities.Players.Player _player
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Relics.NRelicInventoryHolder> _relicNodes
private MegaCrit.Sts2.Core.Nodes.Relics.NRelicInventory+RelicsChangedEventHandler backing_RelicsChanged
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Nodes.Relics.NRelicInventoryHolder> RelicNodes { public get; }
event MegaCrit.Sts2.Core.Nodes.Relics.NRelicInventory+RelicsChangedEventHandler RelicsChanged
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotSignalList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private static System.Void OnRelicUnfocused()
private System.Void <_Ready>b__9_0()
private System.Void Add(MegaCrit.Sts2.Core.Models.RelicModel relic, System.Boolean startsShown, System.Int32 index = -1)
private System.Void ConnectPlayerEvents()
private System.Void DebugHideTopBar()
private System.Void DisconnectPlayerEvents()
private System.Void OnRelicClicked(MegaCrit.Sts2.Core.Models.RelicModel model)
private System.Void OnRelicFocused(MegaCrit.Sts2.Core.Models.RelicModel model)
private System.Void OnRelicObtained(MegaCrit.Sts2.Core.Models.RelicModel relic)
private System.Void OnRelicRemoved(MegaCrit.Sts2.Core.Models.RelicModel relic)
private System.Void Remove(MegaCrit.Sts2.Core.Models.RelicModel relic)
private System.Void UpdateNavigation()
protected System.Void EmitSignalRelicsChanged()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean HasGodotClassSignal(in Godot.NativeInterop.godot_string_name signal)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RaiseGodotClassSignalCallbacks(in Godot.NativeInterop.godot_string_name signal, Godot.NativeInterop.NativeVariantPtrArgs args)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public Godot.Vector2 GetBottomOfInventory()
public Godot.Vector2 GetDefaultPosition()
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Nodes.Relics.NRelicInventoryHolder> get_RelicNodes()
public System.Void add_RelicsChanged(MegaCrit.Sts2.Core.Nodes.Relics.NRelicInventory+RelicsChangedEventHandler value)
public System.Void AnimateRelic(MegaCrit.Sts2.Core.Models.RelicModel relic, System.Nullable<Godot.Vector2> startPosition = null, System.Nullable<Godot.Vector2> startScale = null)
public System.Void AnimHide()
public System.Void AnimShow()
public System.Void HideImmediately()
public System.Void Initialize(MegaCrit.Sts2.Core.Runs.RunState runState)
public System.Void remove_RelicsChanged(MegaCrit.Sts2.Core.Nodes.Relics.NRelicInventory+RelicsChangedEventHandler value)
public System.Void ShowImmediately()
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Input(Godot.InputEvent inputEvent)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Relics.NRelicInventory+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Relics.NRelicInventory+<>c <>9
public static System.Action<MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl> <>9__16_2
private static .cctor()
public .ctor()
internal System.Void <Add>b__16_2(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl _)
```

## MegaCrit.Sts2.Core.Nodes.Relics.NRelicInventory+<>c__DisplayClass16_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Relics.NRelicInventory <>4__this
public MegaCrit.Sts2.Core.Models.RelicModel relic
public .ctor()
internal System.Void <Add>b__0(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
internal System.Void <Add>b__1(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl _)
```

## MegaCrit.Sts2.Core.Nodes.Relics.NRelicInventory+<>c__DisplayClass17_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Models.RelicModel relic
public .ctor()
internal System.Boolean <Remove>b__0(MegaCrit.Sts2.Core.Nodes.Relics.NRelicInventoryHolder n)
```

## MegaCrit.Sts2.Core.Nodes.Relics.NRelicInventory+<>c__DisplayClass21_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Models.RelicModel relic
public .ctor()
internal System.Boolean <AnimateRelic>b__0(MegaCrit.Sts2.Core.Nodes.Relics.NRelicInventoryHolder n)
```

## MegaCrit.Sts2.Core.Nodes.Relics.NRelicInventory+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.FlowContainer+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Input
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AnimHide
public static readonly Godot.StringName AnimShow
public static readonly Godot.StringName ConnectPlayerEvents
public static readonly Godot.StringName DebugHideTopBar
public static readonly Godot.StringName DisconnectPlayerEvents
public static readonly Godot.StringName GetBottomOfInventory
public static readonly Godot.StringName GetDefaultPosition
public static readonly Godot.StringName HideImmediately
public static readonly Godot.StringName OnRelicUnfocused
public static readonly Godot.StringName ShowImmediately
public static readonly Godot.StringName UpdateNavigation
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Relics.NRelicInventory+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.FlowContainer+PropertyName`。

接口：

```text
public static readonly Godot.StringName _curTween
public static readonly Godot.StringName _debugHideTween
public static readonly Godot.StringName _isDebugHidden
public static readonly Godot.StringName _originalPos
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Relics.NRelicInventory+RelicsChangedEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke()
```

## MegaCrit.Sts2.Core.Nodes.Relics.NRelicInventory+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.FlowContainer+SignalName`。

接口：

```text
public static readonly Godot.StringName RelicsChanged
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Relics.NRelicInventoryHolder

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.addons.mega_text.MegaLabel _amountLabel
private System.Threading.CancellationTokenSource _cancellationTokenSource
private static readonly System.String _flashPath
private Godot.Tween _hoverTween
private MegaCrit.Sts2.Core.Models.RelicModel _model
private static const System.Single _newlyAcquiredFadeInDuration = 0.1
private static const System.Single _newlyAcquiredPopDistance = 40
private static const System.Single _newlyAcquiredPopDuration = 0.35
private Godot.Tween _obtainedTween
private Godot.Vector2 _originalIconPosition
private MegaCrit.Sts2.Core.Nodes.Relics.NRelic _relic
private static readonly System.String _scenePath
private MegaCrit.Sts2.Core.Models.RelicModel _subscribedRelic
private MegaCrit.Sts2.Core.Nodes.Relics.NRelicInventory <Inventory>k__BackingField
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
MegaCrit.Sts2.Core.Nodes.Relics.NRelicInventory Inventory { public get; public set; }
MegaCrit.Sts2.Core.Nodes.Relics.NRelic Relic { public get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void DoFlash()
private System.Void OnDisplayAmountChanged()
private System.Void OnModelChanged(MegaCrit.Sts2.Core.Models.RelicModel oldModel, MegaCrit.Sts2.Core.Models.RelicModel newModel)
private System.Void OnRelicFlashed(MegaCrit.Sts2.Core.Models.RelicModel _, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature> __)
private System.Void OnStatusChanged()
private System.Void RefreshAmount()
private System.Void RefreshStatus()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnFocus()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public [async] System.Threading.Tasks.Task PlayNewlyAcquiredAnimation(System.Nullable<Godot.Vector2> startLocation, System.Nullable<Godot.Vector2> startScale)
public MegaCrit.Sts2.Core.Nodes.Relics.NRelic get_Relic()
public MegaCrit.Sts2.Core.Nodes.Relics.NRelicInventory get_Inventory()
public static MegaCrit.Sts2.Core.Nodes.Relics.NRelicInventoryHolder Create(MegaCrit.Sts2.Core.Models.RelicModel relic)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Void set_Inventory(MegaCrit.Sts2.Core.Nodes.Relics.NRelicInventory value)
public virtual System.Void _ExitTree()
public virtual System.Void _Notification(System.Int32 what)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Relics.NRelicInventoryHolder+<PlayNewlyAcquiredAnimation>d__28

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Relics.NRelicInventoryHolder <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__2
private System.Threading.CancellationTokenSource <cancelTokenSource>5__2
public System.Nullable<Godot.Vector2> startLocation
public System.Nullable<Godot.Vector2> startScale
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Relics.NRelicInventoryHolder+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Notification
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName DoFlash
public static readonly Godot.StringName OnDisplayAmountChanged
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnStatusChanged
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName RefreshAmount
public static readonly Godot.StringName RefreshStatus
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Relics.NRelicInventoryHolder+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _amountLabel
public static readonly Godot.StringName _hoverTween
public static readonly Godot.StringName _obtainedTween
public static readonly Godot.StringName _originalIconPosition
public static readonly Godot.StringName _relic
public static readonly Godot.StringName Inventory
public static readonly Godot.StringName Relic
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Relics.NRelicInventoryHolder+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```
