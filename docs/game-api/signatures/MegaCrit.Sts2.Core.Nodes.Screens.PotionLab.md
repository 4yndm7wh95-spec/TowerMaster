# MegaCrit.Sts2.Core.Nodes.Screens.PotionLab

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.Screens.PotionLab.NLabPotionHolder

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private Godot.Tween _hoverTween
private MegaCrit.Sts2.Core.Models.PotionModel _model
private Godot.Control _potionHolder
private MegaCrit.Sts2.Core.Nodes.Potions.NPotion _potionNode
private MegaCrit.Sts2.Core.Entities.UI.ModelVisibility _visibility
public static readonly System.String lockedIconPath
public static readonly System.String scenePath
MegaCrit.Sts2.Core.HoverTips.HoverTip LockedHoverTip { private static get; }
MegaCrit.Sts2.Core.Localization.LocString LockedHoverTipDescription { private static get; }
MegaCrit.Sts2.Core.Localization.LocString LockedHoverTipTitle { private static get; }
MegaCrit.Sts2.Core.HoverTips.HoverTip UnknownHoverTip { private get; }
MegaCrit.Sts2.Core.Localization.LocString UnknownHoverTipDescription { private get; }
MegaCrit.Sts2.Core.Localization.LocString UnknownHoverTipTitle { private get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private MegaCrit.Sts2.Core.HoverTips.HoverTip get_UnknownHoverTip()
private MegaCrit.Sts2.Core.Localization.LocString get_UnknownHoverTipDescription()
private MegaCrit.Sts2.Core.Localization.LocString get_UnknownHoverTipTitle()
private static MegaCrit.Sts2.Core.HoverTips.HoverTip get_LockedHoverTip()
private static MegaCrit.Sts2.Core.Localization.LocString get_LockedHoverTipDescription()
private static MegaCrit.Sts2.Core.Localization.LocString get_LockedHoverTipTitle()
private System.Boolean <_Ready>b__20_0(MegaCrit.Sts2.Core.Models.PotionModel p)
private System.Void OnFocus()
private System.Void OnUnfocus()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.PotionLab.NLabPotionHolder Create(MegaCrit.Sts2.Core.Models.PotionModel potion, MegaCrit.Sts2.Core.Entities.UI.ModelVisibility visibility)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.PotionLab.NLabPotionHolder+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnUnfocus
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.PotionLab.NLabPotionHolder+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _hoverTween
public static readonly Godot.StringName _potionHolder
public static readonly Godot.StringName _potionNode
public static readonly Godot.StringName _visibility
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.PotionLab.NLabPotionHolder+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.PotionLab.NPotionLab

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private MegaCrit.Sts2.Core.Nodes.Screens.PotionLab.NPotionLabCategory _common
private System.Threading.CancellationTokenSource _cts
private System.Threading.Tasks.Task _loadTask
private MegaCrit.Sts2.Core.Nodes.Screens.PotionLab.NPotionLabCategory _rare
private static readonly System.String _scenePath
private MegaCrit.Sts2.Core.Nodes.GodotExtensions.NScrollableContainer _screenContents
private Godot.Tween _screenTween
private MegaCrit.Sts2.Core.Nodes.Screens.PotionLab.NPotionLabCategory _special
private MegaCrit.Sts2.Core.Nodes.Screens.PotionLab.NPotionLabCategory _uncommon
System.String[] AssetPaths { public static get; }
Godot.Control InitialFocusedControl { protected virtual get; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task LoadPotions()
private [async] System.Threading.Tasks.Task TweenAfterLoading()
private System.Void ClearPotions()
protected virtual Godot.Control get_InitialFocusedControl()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnSubmenuShown()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.PotionLab.NPotionLab Create()
public static System.String[] get_AssetPaths()
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
public virtual System.Void OnSubmenuClosed()
public virtual System.Void OnSubmenuOpened()
```

## MegaCrit.Sts2.Core.Nodes.Screens.PotionLab.NPotionLab+<>O

类型属性：`NestedPrivate, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static System.Func<MegaCrit.Sts2.Core.Models.ModelId, MegaCrit.Sts2.Core.Models.PotionModel> <0>__GetByIdOrNull
```

## MegaCrit.Sts2.Core.Nodes.Screens.PotionLab.NPotionLab+<LoadPotions>d__19

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.PotionLab.NPotionLab <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.PotionLab.NPotionLab+<TweenAfterLoading>d__18

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.PotionLab.NPotionLab <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.PotionLab.NPotionLab+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName ClearPotions
public static readonly Godot.StringName Create
public static readonly Godot.StringName OnSubmenuClosed
public static readonly Godot.StringName OnSubmenuOpened
public static readonly Godot.StringName OnSubmenuShown
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.PotionLab.NPotionLab+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+PropertyName`。

接口：

```text
public static readonly Godot.StringName _common
public static readonly Godot.StringName _rare
public static readonly Godot.StringName _screenContents
public static readonly Godot.StringName _screenTween
public static readonly Godot.StringName _special
public static readonly Godot.StringName _uncommon
public static readonly Godot.StringName InitialFocusedControl
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.PotionLab.NPotionLab+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.PotionLab.NPotionLabCategory

类型属性：`Public, BeforeFieldInit`；基类：`Godot.VBoxContainer`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _headerLabel
private Godot.GridContainer _potionContainer
Godot.Control DefaultFocusedControl { public get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public Godot.Control get_DefaultFocusedControl()
public System.Collections.Generic.List<System.Collections.Generic.IReadOnlyList<Godot.Control>> GetGridItems()
public System.Void ClearPotions()
public System.Void LoadPotions(MegaCrit.Sts2.Core.Entities.Potions.PotionRarity potionRarity, MegaCrit.Sts2.Core.Localization.LocString header, System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Models.PotionModel> seenPotions, MegaCrit.Sts2.Core.Unlocks.UnlockState unlockState, System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Models.PotionModel> allUnlockedPotions, System.Nullable<MegaCrit.Sts2.Core.Entities.Potions.PotionRarity> secondRarity = null)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.PotionLab.NPotionLabCategory+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Screens.PotionLab.NPotionLabCategory+<>c <>9
public static System.Comparison<MegaCrit.Sts2.Core.Models.PotionModel> <>9__3_1
private static .cctor()
public .ctor()
internal System.Int32 <LoadPotions>b__3_1(MegaCrit.Sts2.Core.Models.PotionModel p1, MegaCrit.Sts2.Core.Models.PotionModel p2)
```

## MegaCrit.Sts2.Core.Nodes.Screens.PotionLab.NPotionLabCategory+<>c__DisplayClass3_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Entities.Potions.PotionRarity potionRarity
public System.Nullable<MegaCrit.Sts2.Core.Entities.Potions.PotionRarity> secondRarity
public .ctor()
internal System.Boolean <LoadPotions>b__0(MegaCrit.Sts2.Core.Models.PotionModel relic)
```

## MegaCrit.Sts2.Core.Nodes.Screens.PotionLab.NPotionLabCategory+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.VBoxContainer+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName ClearPotions
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.PotionLab.NPotionLabCategory+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.VBoxContainer+PropertyName`。

接口：

```text
public static readonly Godot.StringName _headerLabel
public static readonly Godot.StringName _potionContainer
public static readonly Godot.StringName DefaultFocusedControl
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.PotionLab.NPotionLabCategory+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.VBoxContainer+SignalName`。

接口：

```text
public .ctor()
```
