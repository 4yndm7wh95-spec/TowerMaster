# MegaCrit.Sts2.Core.Nodes.Screens.RelicCollection

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.Screens.RelicCollection.NRelicCollection

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private MegaCrit.Sts2.Core.Nodes.Screens.RelicCollection.NRelicCollectionCategory _ancient
private MegaCrit.Sts2.Core.Nodes.Screens.RelicCollection.NRelicCollectionCategory _common
private System.Threading.CancellationTokenSource _cts
private MegaCrit.Sts2.Core.Nodes.Screens.RelicCollection.NRelicCollectionCategory _event
private System.Threading.Tasks.Task _loadTask
private MegaCrit.Sts2.Core.Nodes.Screens.RelicCollection.NRelicCollectionCategory _rare
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.RelicModel> _relics
private static readonly System.String _scenePath
private MegaCrit.Sts2.Core.Nodes.GodotExtensions.NScrollableContainer _screenContents
private Godot.Tween _screenTween
private MegaCrit.Sts2.Core.Nodes.Screens.RelicCollection.NRelicCollectionCategory _shop
private MegaCrit.Sts2.Core.Nodes.Screens.RelicCollection.NRelicCollectionCategory _starter
private MegaCrit.Sts2.Core.Nodes.Screens.RelicCollection.NRelicCollectionCategory _uncommon
System.String[] AssetPaths { public static get; }
Godot.Control InitialFocusedControl { protected virtual get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.RelicModel> Relics { public get; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task LoadRelics()
private [async] System.Threading.Tasks.Task TweenAfterLoading()
private System.Void ClearRelics()
protected virtual Godot.Control get_InitialFocusedControl()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnSubmenuShown()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.RelicCollection.NRelicCollection Create()
public static System.String[] get_AssetPaths()
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.RelicModel> get_Relics()
public System.Void AddRelics(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.RelicModel> relics)
public System.Void SetLastFocusedRelic(MegaCrit.Sts2.Core.Nodes.Screens.RelicCollection.NRelicCollectionEntry relic)
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
public virtual System.Void OnSubmenuClosed()
public virtual System.Void OnSubmenuOpened()
```

## MegaCrit.Sts2.Core.Nodes.Screens.RelicCollection.NRelicCollection+<>O

类型属性：`NestedPrivate, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static System.Func<MegaCrit.Sts2.Core.Models.ModelId, MegaCrit.Sts2.Core.Models.RelicModel> <0>__GetByIdOrNull
```

## MegaCrit.Sts2.Core.Nodes.Screens.RelicCollection.NRelicCollection+<LoadRelics>d__25

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.RelicCollection.NRelicCollection <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.RelicCollection.NRelicCollection+<TweenAfterLoading>d__24

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.RelicCollection.NRelicCollection <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.RelicCollection.NRelicCollection+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName ClearRelics
public static readonly Godot.StringName Create
public static readonly Godot.StringName OnSubmenuClosed
public static readonly Godot.StringName OnSubmenuOpened
public static readonly Godot.StringName OnSubmenuShown
public static readonly Godot.StringName SetLastFocusedRelic
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.RelicCollection.NRelicCollection+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+PropertyName`。

接口：

```text
public static readonly Godot.StringName _ancient
public static readonly Godot.StringName _common
public static readonly Godot.StringName _event
public static readonly Godot.StringName _rare
public static readonly Godot.StringName _screenContents
public static readonly Godot.StringName _screenTween
public static readonly Godot.StringName _shop
public static readonly Godot.StringName _starter
public static readonly Godot.StringName _uncommon
public static readonly Godot.StringName InitialFocusedControl
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.RelicCollection.NRelicCollection+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.RelicCollection.NRelicCollectionCategory

类型属性：`Public, BeforeFieldInit`；基类：`Godot.VBoxContainer`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Nodes.Screens.RelicCollection.NRelicCollection _collection
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _headerLabel
private Godot.TextureRect _icon
private static readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.RelicModel> _relicModelCache
private Godot.GridContainer _relicsContainer
private Godot.Control _spacer
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Screens.RelicCollection.NRelicCollectionCategory> _subCategories
public static readonly System.String scenePath
Godot.Control DefaultFocusedControl { public get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private MegaCrit.Sts2.Core.Nodes.Screens.RelicCollection.NRelicCollectionCategory CreateForSubcategory()
private System.Void LoadIcon(Godot.Texture2D tex)
private System.Void LoadRelicNodes(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.RelicModel> relics, System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Models.RelicModel> seenRelics, System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Models.RelicModel> unlockedRelics)
private System.Void LoadSubcategory(MegaCrit.Sts2.Core.Nodes.Screens.RelicCollection.NRelicCollection collection, MegaCrit.Sts2.Core.Localization.LocString header, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.RelicModel> relics, System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Models.RelicModel> seenRelics, System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Models.RelicModel> unlockedRelics)
private System.Void OnRelicEntryPressed(MegaCrit.Sts2.Core.Nodes.Screens.RelicCollection.NRelicCollectionEntry entry)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public Godot.Control get_DefaultFocusedControl()
public System.Collections.Generic.List<System.Collections.Generic.IReadOnlyList<Godot.Control>> GetGridItems()
public System.Void ClearRelics()
public System.Void LoadRelics(MegaCrit.Sts2.Core.Entities.Relics.RelicRarity relicRarity, MegaCrit.Sts2.Core.Nodes.Screens.RelicCollection.NRelicCollection collection, MegaCrit.Sts2.Core.Localization.LocString header, System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Models.RelicModel> seenRelics, MegaCrit.Sts2.Core.Unlocks.UnlockState unlockState, System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Models.RelicModel> allUnlockedRelics)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.RelicCollection.NRelicCollectionCategory+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Screens.RelicCollection.NRelicCollectionCategory+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Models.CharacterModel, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.RelicModel>> <>9__10_1
public static System.Comparison<MegaCrit.Sts2.Core.Models.RelicModel> <>9__10_10
public static System.Func<MegaCrit.Sts2.Core.Models.RelicModel, MegaCrit.Sts2.Core.Models.RelicModel> <>9__10_2
public static System.Func<MegaCrit.Sts2.Core.Models.ActModel, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AncientEventModel>> <>9__10_3
public static System.Func<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AncientEventModel>, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AncientEventModel>> <>9__10_4
public static System.Func<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AncientEventModel>, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AncientEventModel>> <>9__10_6
public static System.Func<MegaCrit.Sts2.Core.Events.EventOption, MegaCrit.Sts2.Core.Models.RelicModel> <>9__10_7
public static System.Func<MegaCrit.Sts2.Core.Models.RelicModel, System.String> <>9__10_8
private static .cctor()
public .ctor()
internal MegaCrit.Sts2.Core.Models.RelicModel <LoadRelics>b__10_2(MegaCrit.Sts2.Core.Models.RelicModel r)
internal MegaCrit.Sts2.Core.Models.RelicModel <LoadRelics>b__10_7(MegaCrit.Sts2.Core.Events.EventOption o)
internal System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AncientEventModel> <LoadRelics>b__10_3(MegaCrit.Sts2.Core.Models.ActModel a)
internal System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AncientEventModel> <LoadRelics>b__10_4(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AncientEventModel> a)
internal System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AncientEventModel> <LoadRelics>b__10_6(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AncientEventModel> a)
internal System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.RelicModel> <LoadRelics>b__10_1(MegaCrit.Sts2.Core.Models.CharacterModel c)
internal System.Int32 <LoadRelics>b__10_10(MegaCrit.Sts2.Core.Models.RelicModel p1, MegaCrit.Sts2.Core.Models.RelicModel p2)
internal System.String <LoadRelics>b__10_8(MegaCrit.Sts2.Core.Models.RelicModel r)
```

## MegaCrit.Sts2.Core.Nodes.Screens.RelicCollection.NRelicCollectionCategory+<>c__DisplayClass10_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.Func<MegaCrit.Sts2.Core.Models.RelicModel, System.Boolean> <>9__9
public MegaCrit.Sts2.Core.Entities.Relics.RelicRarity relicRarity
public System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Models.RelicModel> seenRelics
public MegaCrit.Sts2.Core.Unlocks.UnlockState unlockState
public .ctor()
internal System.Boolean <LoadRelics>b__0(MegaCrit.Sts2.Core.Models.RelicModel relic)
internal System.Boolean <LoadRelics>b__9(MegaCrit.Sts2.Core.Models.RelicModel r)
internal System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AncientEventModel> <LoadRelics>b__5(MegaCrit.Sts2.Core.Models.ActModel a)
```

## MegaCrit.Sts2.Core.Nodes.Screens.RelicCollection.NRelicCollectionCategory+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.VBoxContainer+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName ClearRelics
public static readonly Godot.StringName CreateForSubcategory
public static readonly Godot.StringName LoadIcon
public static readonly Godot.StringName OnRelicEntryPressed
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.RelicCollection.NRelicCollectionCategory+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.VBoxContainer+PropertyName`。

接口：

```text
public static readonly Godot.StringName _collection
public static readonly Godot.StringName _headerLabel
public static readonly Godot.StringName _icon
public static readonly Godot.StringName _relicsContainer
public static readonly Godot.StringName _spacer
public static readonly Godot.StringName DefaultFocusedControl
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.RelicCollection.NRelicCollectionCategory+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.VBoxContainer+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.RelicCollection.NRelicCollectionEntry

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private Godot.Tween _hoverTween
private Godot.Control _relicHolder
private Godot.Control _relicNode
private MegaCrit.Sts2.Core.Entities.UI.ModelVisibility <ModelVisibility>k__BackingField
public static readonly System.String lockedIconPath
public MegaCrit.Sts2.Core.Models.RelicModel relic
public static readonly System.String scenePath
MegaCrit.Sts2.Core.HoverTips.HoverTip LockedHoverTip { private static get; }
MegaCrit.Sts2.Core.Localization.LocString LockedHoverTipDescription { private static get; }
MegaCrit.Sts2.Core.Localization.LocString LockedHoverTipTitle { private static get; }
MegaCrit.Sts2.Core.Entities.UI.ModelVisibility ModelVisibility { public get; public set; }
MegaCrit.Sts2.Core.HoverTips.HoverTip UnknownHoverTip { private static get; }
MegaCrit.Sts2.Core.Localization.LocString UnknownHoverTipDescription { private static get; }
MegaCrit.Sts2.Core.Localization.LocString UnknownHoverTipTitle { private static get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private static MegaCrit.Sts2.Core.HoverTips.HoverTip get_LockedHoverTip()
private static MegaCrit.Sts2.Core.HoverTips.HoverTip get_UnknownHoverTip()
private static MegaCrit.Sts2.Core.Localization.LocString get_LockedHoverTipDescription()
private static MegaCrit.Sts2.Core.Localization.LocString get_LockedHoverTipTitle()
private static MegaCrit.Sts2.Core.Localization.LocString get_UnknownHoverTipDescription()
private static MegaCrit.Sts2.Core.Localization.LocString get_UnknownHoverTipTitle()
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
public MegaCrit.Sts2.Core.Entities.UI.ModelVisibility get_ModelVisibility()
public static MegaCrit.Sts2.Core.Nodes.Screens.RelicCollection.NRelicCollectionEntry Create(MegaCrit.Sts2.Core.Models.RelicModel relic, MegaCrit.Sts2.Core.Entities.UI.ModelVisibility visibility)
public System.Void set_ModelVisibility(MegaCrit.Sts2.Core.Entities.UI.ModelVisibility value)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.RelicCollection.NRelicCollectionEntry+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnUnfocus
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.RelicCollection.NRelicCollectionEntry+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _hoverTween
public static readonly Godot.StringName _relicHolder
public static readonly Godot.StringName _relicNode
public static readonly Godot.StringName ModelVisibility
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.RelicCollection.NRelicCollectionEntry+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```
