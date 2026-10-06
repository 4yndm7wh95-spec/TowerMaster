# MegaCrit.Sts2.Core.Nodes.Screens.Overlays

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.Screens.Overlays.IOverlayScreen

类型属性：`Public, ClassSemanticsMask, Abstract, BeforeFieldInit`；基类：`无`。

接口：`MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType ScreenType { public abstract get; }
System.Boolean UseSharedBackstop { public abstract get; }
public abstract MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType get_ScreenType()
public abstract System.Boolean get_UseSharedBackstop()
public abstract System.Void AfterOverlayClosed()
public abstract System.Void AfterOverlayHidden()
public abstract System.Void AfterOverlayOpened()
public abstract System.Void AfterOverlayShown()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Overlays.NOverlayStack

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private Godot.Control _backstop
private Godot.Tween _backstopFade
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Screens.Overlays.IOverlayScreen> _overlays
private MegaCrit.Sts2.Core.Nodes.Screens.Overlays.NOverlayStack+ChangedEventHandler backing_Changed
MegaCrit.Sts2.Core.Nodes.Screens.Overlays.NOverlayStack Instance { public static get; }
System.Int32 ScreenCount { public get; }
System.Boolean StackIsCovered { private static get; }
event MegaCrit.Sts2.Core.Nodes.Screens.Overlays.NOverlayStack+ChangedEventHandler Changed
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotSignalList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private Godot.Error <_Ready>b__10_0()
private Godot.Error <_Ready>b__10_1()
private static System.Boolean get_StackIsCovered()
private System.Void OnActiveScreenChanged()
protected System.Void EmitSignalChanged()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean HasGodotClassSignal(in Godot.NativeInterop.godot_string_name signal)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RaiseGodotClassSignalCallbacks(in Godot.NativeInterop.godot_string_name signal, Godot.NativeInterop.NativeVariantPtrArgs args)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public MegaCrit.Sts2.Core.Nodes.Screens.Overlays.IOverlayScreen Peek()
public static MegaCrit.Sts2.Core.Nodes.Screens.Overlays.NOverlayStack get_Instance()
public System.Int32 get_ScreenCount()
public System.Void add_Changed(MegaCrit.Sts2.Core.Nodes.Screens.Overlays.NOverlayStack+ChangedEventHandler value)
public System.Void Clear()
public System.Void HideBackstop()
public System.Void HideOverlays()
public System.Void Push(MegaCrit.Sts2.Core.Nodes.Screens.Overlays.IOverlayScreen screen)
public System.Void remove_Changed(MegaCrit.Sts2.Core.Nodes.Screens.Overlays.NOverlayStack+ChangedEventHandler value)
public System.Void Remove(MegaCrit.Sts2.Core.Nodes.Screens.Overlays.IOverlayScreen screen)
public System.Void ShowBackstop()
public System.Void ShowOverlays()
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Overlays.NOverlayStack+ChangedEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Overlays.NOverlayStack+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Clear
public static readonly Godot.StringName HideBackstop
public static readonly Godot.StringName HideOverlays
public static readonly Godot.StringName OnActiveScreenChanged
public static readonly Godot.StringName ShowBackstop
public static readonly Godot.StringName ShowOverlays
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Overlays.NOverlayStack+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _backstop
public static readonly Godot.StringName _backstopFade
public static readonly Godot.StringName ScreenCount
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Overlays.NOverlayStack+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public static readonly Godot.StringName Changed
private static .cctor()
public .ctor()
```
