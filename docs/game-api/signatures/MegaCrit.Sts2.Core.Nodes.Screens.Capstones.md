# MegaCrit.Sts2.Core.Nodes.Screens.Capstones

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.Screens.Capstones.ICapstoneScreen

类型属性：`Public, ClassSemanticsMask, Abstract, BeforeFieldInit`；基类：`无`。

接口：`MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType ScreenType { public abstract get; }
System.Boolean UseSharedBackstop { public abstract get; }
public abstract MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType get_ScreenType()
public abstract System.Boolean get_UseSharedBackstop()
public abstract System.Void AfterCapstoneClosed()
public abstract System.Void AfterCapstoneOpened()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Capstones.NCapstoneContainer

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private Godot.Control _backstop
private Godot.Tween _backstopFade
private MegaCrit.Sts2.Core.Nodes.Screens.Capstones.ICapstoneScreen <CurrentCapstoneScreen>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Screens.Capstones.NCapstoneContainer+CapstoneClosedEventHandler backing_CapstoneClosed
private MegaCrit.Sts2.Core.Nodes.Screens.Capstones.NCapstoneContainer+ChangedEventHandler backing_Changed
MegaCrit.Sts2.Core.Nodes.Screens.Capstones.ICapstoneScreen CurrentCapstoneScreen { public get; private set; }
MegaCrit.Sts2.Core.Nodes.Screens.Capstones.NCapstoneContainer Instance { public static get; }
System.Boolean InUse { public get; }
event MegaCrit.Sts2.Core.Nodes.Screens.Capstones.NCapstoneContainer+CapstoneClosedEventHandler CapstoneClosed
event MegaCrit.Sts2.Core.Nodes.Screens.Capstones.NCapstoneContainer+ChangedEventHandler Changed
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotSignalList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void CloseInternal()
private System.Void OnActiveScreenChanged()
private System.Void set_CurrentCapstoneScreen(MegaCrit.Sts2.Core.Nodes.Screens.Capstones.ICapstoneScreen value)
protected System.Void EmitSignalCapstoneClosed()
protected System.Void EmitSignalChanged()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean HasGodotClassSignal(in Godot.NativeInterop.godot_string_name signal)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RaiseGodotClassSignalCallbacks(in Godot.NativeInterop.godot_string_name signal, Godot.NativeInterop.NativeVariantPtrArgs args)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public MegaCrit.Sts2.Core.Nodes.Screens.Capstones.ICapstoneScreen get_CurrentCapstoneScreen()
public static MegaCrit.Sts2.Core.Nodes.Screens.Capstones.NCapstoneContainer get_Instance()
public System.Boolean get_InUse()
public System.Void add_CapstoneClosed(MegaCrit.Sts2.Core.Nodes.Screens.Capstones.NCapstoneContainer+CapstoneClosedEventHandler value)
public System.Void add_Changed(MegaCrit.Sts2.Core.Nodes.Screens.Capstones.NCapstoneContainer+ChangedEventHandler value)
public System.Void CleanUp()
public System.Void Close()
public System.Void DisableBackstopInstantly()
public System.Void EnableBackstopInstantly()
public System.Void Open(MegaCrit.Sts2.Core.Nodes.Screens.Capstones.ICapstoneScreen screen)
public System.Void remove_CapstoneClosed(MegaCrit.Sts2.Core.Nodes.Screens.Capstones.NCapstoneContainer+CapstoneClosedEventHandler value)
public System.Void remove_Changed(MegaCrit.Sts2.Core.Nodes.Screens.Capstones.NCapstoneContainer+ChangedEventHandler value)
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Capstones.NCapstoneContainer+CapstoneClosedEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Capstones.NCapstoneContainer+ChangedEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Capstones.NCapstoneContainer+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName CleanUp
public static readonly Godot.StringName Close
public static readonly Godot.StringName CloseInternal
public static readonly Godot.StringName DisableBackstopInstantly
public static readonly Godot.StringName EnableBackstopInstantly
public static readonly Godot.StringName OnActiveScreenChanged
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Capstones.NCapstoneContainer+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _backstop
public static readonly Godot.StringName _backstopFade
public static readonly Godot.StringName InUse
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Capstones.NCapstoneContainer+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public static readonly Godot.StringName CapstoneClosed
public static readonly Godot.StringName Changed
private static .cctor()
public .ctor()
```
