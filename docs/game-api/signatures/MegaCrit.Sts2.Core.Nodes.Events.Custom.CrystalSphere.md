# MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere.NCrystalSphereCell

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl`。

接口：`System.IDisposable`

```text
private Godot.Tween _fadeTween
private Godot.Control _hoveredFg
private MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere.NCrystalSphereMask _mask
private static const System.String _scenePath = "res://scenes/events/custom/crystal_sphere/crystal_sphere_cell.tscn"
private MegaCrit.Sts2.Core.Events.Custom.CrystalSphereEvent.CrystalSphereCell <Entity>k__BackingField
MegaCrit.Sts2.Core.Events.Custom.CrystalSphereEvent.CrystalSphereCell Entity { public get; private set; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void EntityClicked()
private System.Void OnEntityHighlightUpdated()
private System.Void set_Entity(MegaCrit.Sts2.Core.Events.Custom.CrystalSphereEvent.CrystalSphereCell value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public MegaCrit.Sts2.Core.Events.Custom.CrystalSphereEvent.CrystalSphereCell get_Entity()
public static MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere.NCrystalSphereCell Create(MegaCrit.Sts2.Core.Events.Custom.CrystalSphereEvent.CrystalSphereCell cell, MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere.NCrystalSphereMask mask)
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere.NCrystalSphereCell+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName EntityClicked
public static readonly Godot.StringName OnEntityHighlightUpdated
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere.NCrystalSphereCell+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+PropertyName`。

接口：

```text
public static readonly Godot.StringName _fadeTween
public static readonly Godot.StringName _hoveredFg
public static readonly Godot.StringName _mask
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere.NCrystalSphereCell+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere.NCrystalSphereDialogue

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private Godot.Sprite2D _bubble
private Godot.Node2D _dialogueBox
private static readonly MegaCrit.Sts2.Core.Localization.LocString[] _endLines
private static readonly Godot.StringName _h
private Godot.ShaderMaterial _hsv
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _label
private static readonly MegaCrit.Sts2.Core.Localization.LocString[] _revealBadLines
private static readonly MegaCrit.Sts2.Core.Localization.LocString[] _revealGoodLines
private static readonly Godot.StringName _s
private static readonly MegaCrit.Sts2.Core.Localization.LocString[] _startLines
private Godot.Tween _tween
private static readonly Godot.StringName _v
private static readonly Godot.Vector2 _xRange
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void Play(MegaCrit.Sts2.Core.Localization.LocString locString)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void PlayBad()
public System.Void PlayEnd()
public System.Void PlayGood()
public System.Void PlayStart()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere.NCrystalSphereDialogue+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName PlayBad
public static readonly Godot.StringName PlayEnd
public static readonly Godot.StringName PlayGood
public static readonly Godot.StringName PlayStart
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere.NCrystalSphereDialogue+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _bubble
public static readonly Godot.StringName _dialogueBox
public static readonly Godot.StringName _hsv
public static readonly Godot.StringName _label
public static readonly Godot.StringName _tween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere.NCrystalSphereDialogue+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere.NCrystalSphereItem

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private Godot.Control _card
private Godot.TextureRect _cardBanner
private Godot.TextureRect _cardFrame
private Godot.TextureRect _icon
private MegaCrit.Sts2.Core.Events.Custom.CrystalSphereEvent.CrystalSphereItem _item
private Godot.Material _material
private Godot.Tween _tween
public static const System.String scenePath = "res://scenes/events/custom/crystal_sphere/crystal_sphere_item.tscn"
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnRevealed(MegaCrit.Sts2.Core.Events.Custom.CrystalSphereEvent.CrystalSphereItem item)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere.NCrystalSphereItem Create(MegaCrit.Sts2.Core.Events.Custom.CrystalSphereEvent.CrystalSphereItem item)
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere.NCrystalSphereItem+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere.NCrystalSphereItem+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _card
public static readonly Godot.StringName _cardBanner
public static readonly Godot.StringName _cardFrame
public static readonly Godot.StringName _icon
public static readonly Godot.StringName _material
public static readonly Godot.StringName _tween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere.NCrystalSphereItem+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere.NCrystalSphereMask

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private static readonly Godot.StringName _gridFadeParams
private Godot.ShaderMaterial _material
private System.Single _time
private static readonly Godot.StringName _timeStr
private Godot.Collections.Array<Godot.Vector3> _values
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void UpdateMat(MegaCrit.Sts2.Core.Events.Custom.CrystalSphereEvent.CrystalSphereCell cell)
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere.NCrystalSphereMask+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere.NCrystalSphereMask+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _material
public static readonly Godot.StringName _time
public static readonly Godot.StringName _values
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere.NCrystalSphereMask+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere.NCrystalSphereScreen

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.Overlays.IOverlayScreen`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private MegaCrit.Sts2.Core.Nodes.Events.NDivinationButton _bigDivinationButton
private Godot.Control _cellContainer
private MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere.NCrystalSphereDialogue _dialogue
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _divinationsLeftLabel
private readonly MegaCrit.Sts2.Core.Localization.LocString _divinationsRemainLoc
private MegaCrit.Sts2.Core.Events.Custom.CrystalSphereEvent.CrystalSphereMinigame _entity
private Godot.Tween _fadeTween
private Godot.Control _instructionsContainer
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _instructionsDescriptionLabel
private readonly MegaCrit.Sts2.Core.Localization.LocString _instructionsDescriptionLoc
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _instructionsTitleLabel
private readonly MegaCrit.Sts2.Core.Localization.LocString _instructionsTitleLoc
private Godot.Control _itemsContainer
private MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere.NCrystalSphereMask _mask
private MegaCrit.Sts2.Core.Nodes.CommonUi.NProceedButton _proceedButton
private static const System.String _scenePath = "res://scenes/events/custom/crystal_sphere/crystal_sphere_screen.tscn"
private MegaCrit.Sts2.Core.Nodes.Events.NDivinationButton _smallDivinationButton
Godot.Control DefaultFocusedControl { public virtual get; }
MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType ScreenType { public virtual get; }
System.Boolean UseSharedBackstop { public virtual get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task OnCellClicked(MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere.NCrystalSphereCell cell)
private System.Void <AfterOverlayOpened>b__35_0()
private System.Void OnCellReleased(MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere.NCrystalSphereCell cell)
private System.Void OnHoverCell(MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere.NCrystalSphereCell cell)
private System.Void OnItemRevealed(MegaCrit.Sts2.Core.Events.Custom.CrystalSphereEvent.CrystalSphereItem item)
private System.Void OnMinigameFinished()
private System.Void OnProceedButtonPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OnUnhoverCell(MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere.NCrystalSphereCell cell)
private System.Void SetBigDivination(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton obj)
private System.Void SetSmallDivination(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton obj)
private System.Void UpdateDivinationsLeft()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere.NCrystalSphereScreen ShowScreen(MegaCrit.Sts2.Core.Events.Custom.CrystalSphereEvent.CrystalSphereMinigame grid)
public virtual Godot.Control get_DefaultFocusedControl()
public virtual MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType get_ScreenType()
public virtual System.Boolean get_UseSharedBackstop()
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
public virtual System.Void AfterOverlayClosed()
public virtual System.Void AfterOverlayHidden()
public virtual System.Void AfterOverlayOpened()
public virtual System.Void AfterOverlayShown()
```

## MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere.NCrystalSphereScreen+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere.NCrystalSphereScreen+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere.NCrystalSphereCell, System.Boolean> <>9__25_0
public static System.Func<MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere.NCrystalSphereCell, System.Boolean> <>9__40_0
private static .cctor()
public .ctor()
internal System.Boolean <get_DefaultFocusedControl>b__40_0(MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere.NCrystalSphereCell c)
internal System.Boolean <OnCellClicked>b__25_0(MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere.NCrystalSphereCell c)
```

## MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere.NCrystalSphereScreen+<>c__DisplayClass18_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere.NCrystalSphereScreen <>4__this
public MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere.NCrystalSphereCell cell
public .ctor()
internal System.Void <_Ready>b__0()
internal System.Void <_Ready>b__1()
internal System.Void <_Ready>b__2()
internal System.Void <_Ready>b__3()
internal System.Void <_Ready>b__4(Godot.InputEvent _)
```

## MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere.NCrystalSphereScreen+<>c__DisplayClass25_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere.NCrystalSphereCell cell
public .ctor()
internal System.Single <OnCellClicked>b__1(MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere.NCrystalSphereCell c1)
```

## MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere.NCrystalSphereScreen+<OnCellClicked>d__25

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere.NCrystalSphereScreen <>4__this
private MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere.NCrystalSphereScreen+<>c__DisplayClass25_0 <>8__1
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere.NCrystalSphereCell cell
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere.NCrystalSphereScreen+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AfterOverlayClosed
public static readonly Godot.StringName AfterOverlayHidden
public static readonly Godot.StringName AfterOverlayOpened
public static readonly Godot.StringName AfterOverlayShown
public static readonly Godot.StringName OnCellReleased
public static readonly Godot.StringName OnHoverCell
public static readonly Godot.StringName OnMinigameFinished
public static readonly Godot.StringName OnProceedButtonPressed
public static readonly Godot.StringName OnUnhoverCell
public static readonly Godot.StringName SetBigDivination
public static readonly Godot.StringName SetSmallDivination
public static readonly Godot.StringName UpdateDivinationsLeft
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere.NCrystalSphereScreen+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _bigDivinationButton
public static readonly Godot.StringName _cellContainer
public static readonly Godot.StringName _dialogue
public static readonly Godot.StringName _divinationsLeftLabel
public static readonly Godot.StringName _fadeTween
public static readonly Godot.StringName _instructionsContainer
public static readonly Godot.StringName _instructionsDescriptionLabel
public static readonly Godot.StringName _instructionsTitleLabel
public static readonly Godot.StringName _itemsContainer
public static readonly Godot.StringName _mask
public static readonly Godot.StringName _proceedButton
public static readonly Godot.StringName _smallDivinationButton
public static readonly Godot.StringName DefaultFocusedControl
public static readonly Godot.StringName ScreenType
public static readonly Godot.StringName UseSharedBackstop
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere.NCrystalSphereScreen+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```
