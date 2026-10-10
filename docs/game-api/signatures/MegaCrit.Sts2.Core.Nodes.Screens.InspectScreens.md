# MegaCrit.Sts2.Core.Nodes.Screens.InspectScreens

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.Screens.InspectScreens.NInspectRelicScreen

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Models.RelicModel> _allUnlockedRelics
private static const System.Double _arrowButtonDelay = 0.1
private Godot.Control _backstop
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _description
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _flavor
private Godot.ShaderMaterial _frameHsv
private static readonly Godot.StringName _h
private Godot.Control _hoverTipRect
private System.Int32 _index
private MegaCrit.Sts2.Core.Nodes.CommonUi.NGoldArrowButton _leftButton
private System.Single _leftButtonX
private MegaCrit.Sts2.addons.mega_text.MegaLabel _nameLabel
private Godot.Control _popup
private Godot.Vector2 _popupPosition
private Godot.Tween _popupTween
private MegaCrit.Sts2.addons.mega_text.MegaLabel _rarityLabel
private Godot.TextureRect _relicImage
private System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.RelicModel> _relics
private MegaCrit.Sts2.Core.Nodes.CommonUi.NGoldArrowButton _rightButton
private System.Single _rightButtonX
private static readonly Godot.StringName _s
private static readonly System.String _scenePath
private Godot.Tween _screenTween
private static readonly Godot.StringName _v
System.String[] AssetPaths { public static get; }
Godot.Control DefaultFocusedControl { public virtual get; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void <Close>b__35_0()
private System.Void OnBackstopPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OnLeftButtonPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton button)
private System.Void OnRightButtonPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton button)
private System.Void SetRarityVisuals(MegaCrit.Sts2.Core.Entities.Relics.RelicRarity rarity)
private System.Void SetRelic(System.Int32 index)
private System.Void UpdateRelicDisplay()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.InspectScreens.NInspectRelicScreen Create()
public static System.String[] get_AssetPaths()
public System.Void Close()
public System.Void Open(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.RelicModel> relics, MegaCrit.Sts2.Core.Models.RelicModel relic)
public virtual Godot.Control get_DefaultFocusedControl()
public virtual System.Void _Input(Godot.InputEvent inputEvent)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.InspectScreens.NInspectRelicScreen+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Input
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Close
public static readonly Godot.StringName Create
public static readonly Godot.StringName OnBackstopPressed
public static readonly Godot.StringName OnLeftButtonPressed
public static readonly Godot.StringName OnRightButtonPressed
public static readonly Godot.StringName SetRarityVisuals
public static readonly Godot.StringName SetRelic
public static readonly Godot.StringName UpdateRelicDisplay
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.InspectScreens.NInspectRelicScreen+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _backstop
public static readonly Godot.StringName _description
public static readonly Godot.StringName _flavor
public static readonly Godot.StringName _frameHsv
public static readonly Godot.StringName _hoverTipRect
public static readonly Godot.StringName _index
public static readonly Godot.StringName _leftButton
public static readonly Godot.StringName _leftButtonX
public static readonly Godot.StringName _nameLabel
public static readonly Godot.StringName _popup
public static readonly Godot.StringName _popupPosition
public static readonly Godot.StringName _popupTween
public static readonly Godot.StringName _rarityLabel
public static readonly Godot.StringName _relicImage
public static readonly Godot.StringName _rightButton
public static readonly Godot.StringName _rightButtonX
public static readonly Godot.StringName _screenTween
public static readonly Godot.StringName DefaultFocusedControl
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.InspectScreens.NInspectRelicScreen+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.InspectScreens.NUpgradePreviewTickbox

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox`。

接口：`System.IDisposable`

```text
System.String[] Hotkeys { protected virtual get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.String[] get_Hotkeys()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.InspectScreens.NUpgradePreviewTickbox+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.InspectScreens.NUpgradePreviewTickbox+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox+PropertyName`。

接口：

```text
public static readonly Godot.StringName Hotkeys
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.InspectScreens.NUpgradePreviewTickbox+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox+SignalName`。

接口：

```text
public .ctor()
```
