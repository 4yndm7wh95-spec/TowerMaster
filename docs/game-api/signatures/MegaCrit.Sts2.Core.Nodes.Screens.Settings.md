# MegaCrit.Sts2.Core.Nodes.Screens.Settings

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.IResettableSettingNode

类型属性：`Public, ClassSemanticsMask, Abstract, BeforeFieldInit`；基类：`无`。

接口：

```text
public abstract System.Void SetFromSettings()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NAbandonRunButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.addons.mega_text.MegaLabel _label
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnFocus()
protected virtual System.Void OnRelease()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NAbandonRunButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnUnfocus
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NAbandonRunButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _label
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NAbandonRunButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NAmbienceSlider

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsSlider`。

接口：`System.IDisposable`

```text
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
private static System.Void OnValueChanged(System.Double value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NAmbienceSlider+<>O

类型属性：`NestedPrivate, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static System.Action<System.Double> <0>__OnValueChanged
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NAmbienceSlider+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsSlider+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnValueChanged
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NAmbienceSlider+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsSlider+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NAmbienceSlider+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsSlider+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NAspectRatioDropdown

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsDropdown`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.Settings.IResettableSettingNode`

```text
private MegaCrit.Sts2.Core.Settings.AspectRatioSetting _currentAspectRatioSetting
System.String AspectRatioDropdownItemScenePath { private static get; }
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private static System.String get_AspectRatioDropdownItemScenePath()
private static System.String GetAspectRatioSettingString(MegaCrit.Sts2.Core.Settings.AspectRatioSetting aspectRatioSettingString)
private System.Void AddDropdownItem(MegaCrit.Sts2.Core.Settings.AspectRatioSetting aspectRatioSetting)
private System.Void OnDropdownItemSelected(MegaCrit.Sts2.Core.Nodes.CommonUi.NDropdownItem nDropdownItem)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Void _Ready()
public virtual System.Void SetFromSettings()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NAspectRatioDropdown+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsDropdown+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AddDropdownItem
public static readonly Godot.StringName GetAspectRatioSettingString
public static readonly Godot.StringName OnDropdownItemSelected
public static readonly Godot.StringName SetFromSettings
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NAspectRatioDropdown+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsDropdown+PropertyName`。

接口：

```text
public static readonly Godot.StringName _currentAspectRatioSetting
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NAspectRatioDropdown+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsDropdown+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NAspectRatioDropdownItem

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NDropdownItem`。

接口：`System.IDisposable`

```text
public MegaCrit.Sts2.Core.Settings.AspectRatioSetting aspectRatioSetting
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void Init(MegaCrit.Sts2.Core.Settings.AspectRatioSetting setAspectRatioSetting)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NAspectRatioDropdownItem+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NDropdownItem+MethodName`。

接口：

```text
public static readonly Godot.StringName Init
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NAspectRatioDropdownItem+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NDropdownItem+PropertyName`。

接口：

```text
public static readonly Godot.StringName aspectRatioSetting
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NAspectRatioDropdownItem+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NDropdownItem+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NBackgroundModeHoverTip

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.HoverTips.IHoverTip _hoverTip
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
private System.Void OnHovered()
private System.Void OnUnhovered()
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NBackgroundModeHoverTip+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnHovered
public static readonly Godot.StringName OnUnhovered
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NBackgroundModeHoverTip+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NBackgroundModeHoverTip+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NBackgroundModeTickbox

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.Settings.IResettableSettingNode`

```text
private MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsScreen _settingsScreen
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnTick()
protected virtual System.Void OnUntick()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
public virtual System.Void SetFromSettings()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NBackgroundModeTickbox+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnTick
public static readonly Godot.StringName OnUntick
public static readonly Godot.StringName SetFromSettings
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NBackgroundModeTickbox+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox+PropertyName`。

接口：

```text
public static readonly Godot.StringName _settingsScreen
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NBackgroundModeTickbox+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NBgmVolumeSlider

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsSlider`。

接口：`System.IDisposable`

```text
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
private System.Void OnValueChanged(System.Double value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NBgmVolumeSlider+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsSlider+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnValueChanged
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NBgmVolumeSlider+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsSlider+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NBgmVolumeSlider+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsSlider+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NCommonTooltipsHoverTip

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.HoverTips.IHoverTip _hoverTip
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
private System.Void OnHovered()
private System.Void OnUnhovered()
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NCommonTooltipsHoverTip+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnHovered
public static readonly Godot.StringName OnUnhovered
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NCommonTooltipsHoverTip+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NCommonTooltipsHoverTip+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NCommonTooltipsTickbox

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.Settings.IResettableSettingNode`

```text
private MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsScreen _settingsScreen
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnTick()
protected virtual System.Void OnUntick()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
public virtual System.Void SetFromSettings()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NCommonTooltipsTickbox+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnTick
public static readonly Godot.StringName OnUntick
public static readonly Godot.StringName SetFromSettings
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NCommonTooltipsTickbox+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox+PropertyName`。

接口：

```text
public static readonly Godot.StringName _settingsScreen
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NCommonTooltipsTickbox+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NCreditsButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsButton`。

接口：`System.IDisposable`

```text
private Godot.TextureRect _image
private MegaCrit.Sts2.addons.mega_text.MegaLabel _label
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnRelease()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NCreditsButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnRelease
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NCreditsButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _image
public static readonly Godot.StringName _label
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NCreditsButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NDisplayDropdown

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsDropdown`。

接口：`System.IDisposable`

```text
private System.Int32 _currentDisplayIndex
private Godot.PackedScene _dropdownItemScene
private static readonly MegaCrit.Sts2.Core.Localization.LocString _optionString
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnDropdownItemSelected(MegaCrit.Sts2.Core.Nodes.CommonUi.NDropdownItem nDropdownItem)
private System.Void OnWindowChange(System.Boolean _)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Notification(System.Int32 what)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NDisplayDropdown+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsDropdown+MethodName`。

接口：

```text
public static readonly Godot.StringName _Notification
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnDropdownItemSelected
public static readonly Godot.StringName OnWindowChange
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NDisplayDropdown+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsDropdown+PropertyName`。

接口：

```text
public static readonly Godot.StringName _currentDisplayIndex
public static readonly Godot.StringName _dropdownItemScene
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NDisplayDropdown+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsDropdown+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NDisplayDropdownItem

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NDropdownItem`。

接口：`System.IDisposable`

```text
public System.Int32 displayIndex
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void Init(System.Int32 setIndex)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NDisplayDropdownItem+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NDropdownItem+MethodName`。

接口：

```text
public static readonly Godot.StringName Init
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NDisplayDropdownItem+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NDropdownItem+PropertyName`。

接口：

```text
public static readonly Godot.StringName displayIndex
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NDisplayDropdownItem+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NDropdownItem+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NDropdownPositioner

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private Godot.Control _dropdownNode
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void <_Ready>b__1_0()
private System.Void OnVisibilityChange()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NDropdownPositioner+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnVisibilityChange
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NDropdownPositioner+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _dropdownNode
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NDropdownPositioner+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NFastModeHoverTip

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.HoverTips.IHoverTip _hoverTip
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
private System.Void OnHovered()
private System.Void OnUnhovered()
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NFastModeHoverTip+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnHovered
public static readonly Godot.StringName OnUnhovered
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NFastModeHoverTip+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NFastModeHoverTip+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NFastModeTickbox

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.Settings.IResettableSettingNode`

```text
private MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsScreen _settingsScreen
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnTick()
protected virtual System.Void OnUntick()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
public virtual System.Void SetFromSettings()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NFastModeTickbox+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnTick
public static readonly Godot.StringName OnUntick
public static readonly Godot.StringName SetFromSettings
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NFastModeTickbox+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox+PropertyName`。

接口：

```text
public static readonly Godot.StringName _settingsScreen
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NFastModeTickbox+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NFpsPaginator

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NPaginator`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.Settings.IResettableSettingNode`

```text
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void OnIndexChanged(System.Int32 index)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
public virtual System.Void SetFromSettings()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NFpsPaginator+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NPaginator+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnIndexChanged
public static readonly Godot.StringName SetFromSettings
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NFpsPaginator+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NPaginator+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NFpsPaginator+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NPaginator+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NFullscreenHoverTip

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.HoverTips.IHoverTip _hoverTip
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
private System.Void OnHovered()
private System.Void OnUnhovered()
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NFullscreenHoverTip+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnHovered
public static readonly Godot.StringName OnUnhovered
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NFullscreenHoverTip+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NFullscreenHoverTip+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NFullscreenTickbox

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox`。

接口：`System.IDisposable`

```text
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
private System.Void OnWindowChange(System.Boolean _)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void OnTick()
protected virtual System.Void OnUntick()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static System.Void SetFullscreen(System.Boolean fullscreen)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NFullscreenTickbox+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnTick
public static readonly Godot.StringName OnUntick
public static readonly Godot.StringName OnWindowChange
public static readonly Godot.StringName SetFullscreen
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NFullscreenTickbox+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NFullscreenTickbox+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NHandCardCountHoverTip

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.HoverTips.IHoverTip _hoverTip
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
private System.Void OnHovered()
private System.Void OnUnhovered()
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NHandCardCountHoverTip+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnHovered
public static readonly Godot.StringName OnUnhovered
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NHandCardCountHoverTip+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NHandCardCountHoverTip+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NHandCardCountTickbox

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.Settings.IResettableSettingNode`

```text
private MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsScreen _settingsScreen
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private static System.Void TryRefreshHandIndices()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnTick()
protected virtual System.Void OnUntick()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
public virtual System.Void SetFromSettings()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NHandCardCountTickbox+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnTick
public static readonly Godot.StringName OnUntick
public static readonly Godot.StringName SetFromSettings
public static readonly Godot.StringName TryRefreshHandIndices
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NHandCardCountTickbox+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox+PropertyName`。

接口：

```text
public static readonly Godot.StringName _settingsScreen
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NHandCardCountTickbox+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NInputSettingsEntry

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private Godot.Control _bg
private Godot.TextureRect _controllerBindingIcon
private MegaCrit.Sts2.addons.mega_text.MegaLabel _inputLabel
private MegaCrit.Sts2.addons.mega_text.MegaLabel _keyboardOnlyModeBindingLabel
private Godot.Control _missingControllerBindingLabel
private MegaCrit.Sts2.addons.mega_text.MegaLabel _mKbBindingLabel
private static const System.String _scenePath = "res://scenes/screens/settings_screen/input_settings_entry.tscn"
private Godot.Tween _tween
private Godot.StringName <InputName>k__BackingField
public static readonly System.Collections.Generic.Dictionary<Godot.StringName, System.String> commandToLocTitle
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
Godot.StringName InputName { public get; private set; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void set_InputName(Godot.StringName value)
private System.Void UpdateInput()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnFocus()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public Godot.StringName get_InputName()
public static MegaCrit.Sts2.Core.Nodes.Screens.Settings.NInputSettingsEntry Create(System.String commandName)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NInputSettingsEntry+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName UpdateInput
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NInputSettingsEntry+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _bg
public static readonly Godot.StringName _controllerBindingIcon
public static readonly Godot.StringName _inputLabel
public static readonly Godot.StringName _keyboardOnlyModeBindingLabel
public static readonly Godot.StringName _missingControllerBindingLabel
public static readonly Godot.StringName _mKbBindingLabel
public static readonly Godot.StringName _tween
public static readonly Godot.StringName InputName
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NInputSettingsEntry+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NInputSettingsPanel

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsPanel`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.addons.mega_text.MegaLabel _commandHeader
private MegaCrit.Sts2.addons.mega_text.MegaLabel _controllerHeader
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _kbModeHeader
private MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox _kbModeTickbox
private MegaCrit.Sts2.addons.mega_text.MegaLabel _keyboardHeader
private MegaCrit.Sts2.Core.Nodes.Screens.Settings.NInputSettingsEntry _listeningEntry
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _listeningLabel
private Godot.Control _listeningPrompt
private System.Single _minPadding
private MegaCrit.Sts2.addons.mega_text.MegaLabel _mkbHeader
private MegaCrit.Sts2.addons.mega_text.MegaLabel _resetLabel
private MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _resetToDefaultButton
private MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsScreen _settingsScreen
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _steamInputPrompt
MegaCrit.Sts2.Core.Localization.LocString CannotRemapLoc { private get; }
MegaCrit.Sts2.Core.Localization.LocString ControllerHeaderLoc { private get; }
MegaCrit.Sts2.Core.Localization.LocString KeyboardOnlyHeaderLoc { private get; }
MegaCrit.Sts2.Core.Localization.LocString MKbHeaderLoc { private get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task RefreshSize()
private MegaCrit.Sts2.Core.Localization.LocString get_CannotRemapLoc()
private MegaCrit.Sts2.Core.Localization.LocString get_ControllerHeaderLoc()
private MegaCrit.Sts2.Core.Localization.LocString get_KeyboardOnlyHeaderLoc()
private MegaCrit.Sts2.Core.Localization.LocString get_MKbHeaderLoc()
private System.Void OnViewportSizeChange()
private System.Void SetAsListeningEntry(MegaCrit.Sts2.Core.Nodes.Screens.Settings.NInputSettingsEntry entry)
private System.Void ShowCannotRemapToast(System.String hotkey, MegaCrit.Sts2.Core.Localization.LocString controlType)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnVisibilityChange()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _ExitTree()
public virtual System.Void _Input(Godot.InputEvent inputEvent)
public virtual System.Void _Ready()
public virtual System.Void _UnhandledKeyInput(Godot.InputEvent inputEvent)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NInputSettingsPanel+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Screens.Settings.NInputSettingsPanel+<>c <>9
public static System.Action<MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl> <>9__22_0
private static .cctor()
public .ctor()
internal System.Void <_Ready>b__22_0(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl _)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NInputSettingsPanel+<RefreshSize>d__23

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.Settings.NInputSettingsPanel <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NInputSettingsPanel+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsPanel+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Input
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName _UnhandledKeyInput
public static readonly Godot.StringName OnViewportSizeChange
public static readonly Godot.StringName OnVisibilityChange
public static readonly Godot.StringName SetAsListeningEntry
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NInputSettingsPanel+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsPanel+PropertyName`。

接口：

```text
public static readonly Godot.StringName _commandHeader
public static readonly Godot.StringName _controllerHeader
public static readonly Godot.StringName _kbModeHeader
public static readonly Godot.StringName _kbModeTickbox
public static readonly Godot.StringName _keyboardHeader
public static readonly Godot.StringName _listeningEntry
public static readonly Godot.StringName _listeningLabel
public static readonly Godot.StringName _listeningPrompt
public static readonly Godot.StringName _minPadding
public static readonly Godot.StringName _mkbHeader
public static readonly Godot.StringName _resetLabel
public static readonly Godot.StringName _resetToDefaultButton
public static readonly Godot.StringName _settingsScreen
public static readonly Godot.StringName _steamInputPrompt
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NInputSettingsPanel+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsPanel+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NIntroLogoHoverTip

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.HoverTips.IHoverTip _hoverTip
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
private System.Void OnHovered()
private System.Void OnUnhovered()
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NIntroLogoHoverTip+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnHovered
public static readonly Godot.StringName OnUnhovered
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NIntroLogoHoverTip+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NIntroLogoHoverTip+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NIntroLogoTickbox

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.Settings.IResettableSettingNode`

```text
private MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsScreen _settingsScreen
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnTick()
protected virtual System.Void OnUntick()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
public virtual System.Void SetFromSettings()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NIntroLogoTickbox+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnTick
public static readonly Godot.StringName OnUntick
public static readonly Godot.StringName SetFromSettings
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NIntroLogoTickbox+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox+PropertyName`。

接口：

```text
public static readonly Godot.StringName _settingsScreen
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NIntroLogoTickbox+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NKeyboardOnlyModeHoverTip

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.HoverTips.IHoverTip _hoverTip
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
private System.Void OnHovered()
private System.Void OnUnhovered()
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NKeyboardOnlyModeHoverTip+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnHovered
public static readonly Godot.StringName OnUnhovered
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NKeyboardOnlyModeHoverTip+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NKeyboardOnlyModeHoverTip+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NKeyboardOnlyModeTickbox

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.Settings.IResettableSettingNode`

```text
private MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsScreen _settingsScreen
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnTick()
protected virtual System.Void OnUntick()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
public virtual System.Void SetFromSettings()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NKeyboardOnlyModeTickbox+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnTick
public static readonly Godot.StringName OnUntick
public static readonly Godot.StringName SetFromSettings
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NKeyboardOnlyModeTickbox+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox+PropertyName`。

接口：

```text
public static readonly Godot.StringName _settingsScreen
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NKeyboardOnlyModeTickbox+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NLanguageButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private Godot.TextureRect _flag
private Godot.TextureRect _image
private MegaCrit.Sts2.addons.mega_text.MegaLabel _label
private Godot.Control _outline
private Godot.Tween _tween
private System.Boolean <IsSelected>k__BackingField
public System.String isoCode
System.Boolean IsSelected { public get; private set; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void set_IsSelected(System.Boolean value)
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
public System.Boolean get_IsSelected()
public System.Void Init(System.String languageIsoCode)
public System.Void SetAsDeselected()
public System.Void SetAsSelected()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NLanguageButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Init
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName SetAsDeselected
public static readonly Godot.StringName SetAsSelected
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NLanguageButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _flag
public static readonly Godot.StringName _image
public static readonly Godot.StringName _label
public static readonly Godot.StringName _outline
public static readonly Godot.StringName _tween
public static readonly Godot.StringName isoCode
public static readonly Godot.StringName IsSelected
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NLanguageButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NLanguageDropdown

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsDropdown`。

接口：`System.IDisposable`

```text
private Godot.PackedScene _dropdownItemScene
private static readonly System.Collections.Generic.Dictionary<System.String, System.String> _languageCodeToName
System.String CurrentLanguage { private get; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.String get_CurrentLanguage()
private System.Void OnDropdownItemSelected(MegaCrit.Sts2.Core.Nodes.CommonUi.NDropdownItem nDropdownItem)
private System.Void PopulateOptions()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static System.String GetLanguageNameForCode(System.String languageCode)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NLanguageDropdown+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsDropdown+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName GetLanguageNameForCode
public static readonly Godot.StringName OnDropdownItemSelected
public static readonly Godot.StringName PopulateOptions
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NLanguageDropdown+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsDropdown+PropertyName`。

接口：

```text
public static readonly Godot.StringName _dropdownItemScene
public static readonly Godot.StringName CurrentLanguage
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NLanguageDropdown+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsDropdown+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NLanguageDropdownItem

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NDropdownItem`。

接口：`System.IDisposable`

```text
private static const System.String _warnImageTag = "[img]res://images/ui/language_warning.png[/img]"
private System.String <LanguageCode>k__BackingField
public static const System.String languageWarningIconPath = "res://images/ui/language_warning.png"
System.String LanguageCode { public get; private set; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void set_LanguageCode(System.String value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.String get_LanguageCode()
public System.Void Init(System.String languageCode)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NLanguageDropdownItem+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NDropdownItem+MethodName`。

接口：

```text
public static readonly Godot.StringName Init
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NLanguageDropdownItem+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NDropdownItem+PropertyName`。

接口：

```text
public static readonly Godot.StringName LanguageCode
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NLanguageDropdownItem+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NDropdownItem+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NLongPressConfirmationHoverTip

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.HoverTips.IHoverTip _hoverTip
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
private System.Void OnHovered()
private System.Void OnUnhovered()
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NLongPressConfirmationHoverTip+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnHovered
public static readonly Godot.StringName OnUnhovered
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NLongPressConfirmationHoverTip+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NLongPressConfirmationHoverTip+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NLongPressConfirmationTickbox

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.Settings.IResettableSettingNode`

```text
private MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsScreen _settingsScreen
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnTick()
protected virtual System.Void OnUntick()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
public virtual System.Void SetFromSettings()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NLongPressConfirmationTickbox+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnTick
public static readonly Godot.StringName OnUntick
public static readonly Godot.StringName SetFromSettings
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NLongPressConfirmationTickbox+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox+PropertyName`。

接口：

```text
public static readonly Godot.StringName _settingsScreen
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NLongPressConfirmationTickbox+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NMasterVolumeSlider

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsSlider`。

接口：`System.IDisposable`

```text
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
private System.Void OnValueChanged(System.Double value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NMasterVolumeSlider+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsSlider+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnValueChanged
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NMasterVolumeSlider+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsSlider+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NMasterVolumeSlider+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsSlider+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NMsaaHoverTip

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.HoverTips.IHoverTip _hoverTip
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
private System.Void OnHovered()
private System.Void OnUnhovered()
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NMsaaHoverTip+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnHovered
public static readonly Godot.StringName OnUnhovered
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NMsaaHoverTip+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NMsaaHoverTip+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NMsaaPaginator

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NPaginator`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.Settings.IResettableSettingNode`

```text
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
private Godot.RenderingServer+ViewportMsaa GetMsaa(System.Int32 index)
private System.String GetMsaaLabel(System.Int32 msaaAmount)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void OnIndexChanged(System.Int32 index)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
public virtual System.Void SetFromSettings()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NMsaaPaginator+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NPaginator+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName GetMsaa
public static readonly Godot.StringName GetMsaaLabel
public static readonly Godot.StringName OnIndexChanged
public static readonly Godot.StringName SetFromSettings
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NMsaaPaginator+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NPaginator+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NMsaaPaginator+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NPaginator+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NMuteInBackgroundTickbox

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsScreen _settingsScreen
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnTick()
protected virtual System.Void OnUntick()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NMuteInBackgroundTickbox+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnTick
public static readonly Godot.StringName OnUntick
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NMuteInBackgroundTickbox+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox+PropertyName`。

接口：

```text
public static readonly Godot.StringName _settingsScreen
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NMuteInBackgroundTickbox+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NOpenFeedbackScreenButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsButton`。

接口：`System.IDisposable`

```text
private Godot.TextureRect _image
private MegaCrit.Sts2.addons.mega_text.MegaLabel _label
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NOpenFeedbackScreenButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NOpenFeedbackScreenButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _image
public static readonly Godot.StringName _label
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NOpenFeedbackScreenButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NOpenModdingScreenButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsButton`。

接口：`System.IDisposable`

```text
private Godot.TextureRect _image
private MegaCrit.Sts2.addons.mega_text.MegaLabel _label
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnDisable()
protected virtual System.Void OnEnable()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NOpenModdingScreenButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnDisable
public static readonly Godot.StringName OnEnable
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NOpenModdingScreenButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _image
public static readonly Godot.StringName _label
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NOpenModdingScreenButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NPaginateArrow

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private Godot.Vector2 _baseScale
private Godot.ShaderMaterial _hsv
private Godot.TextureRect _image
private System.Boolean _pageLeft
private MegaCrit.Sts2.Core.Nodes.Screens.Settings.NPaginator _paginator
private Godot.Tween _tween
private static readonly Godot.StringName _v
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void UpdateShaderV(System.Single value)
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
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NPaginateArrow+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName UpdateShaderV
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NPaginateArrow+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _baseScale
public static readonly Godot.StringName _hsv
public static readonly Godot.StringName _image
public static readonly Godot.StringName _pageLeft
public static readonly Godot.StringName _paginator
public static readonly Godot.StringName _tween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NPaginateArrow+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NPaginator

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private static const System.Single _animDistance = 90
private static const System.Double _animDuration = 0.25
protected System.Int32 _currentIndex
protected MegaCrit.Sts2.addons.mega_text.MegaLabel _label
protected readonly System.Collections.Generic.List<System.String> _options
private MegaCrit.Sts2.Core.Nodes.Combat.NSelectionReticle _selectionReticle
private Godot.Tween _tween
private MegaCrit.Sts2.addons.mega_text.MegaLabel _vfxLabel
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void IndexChangeHelper(System.Boolean pagedLeft)
private System.Void OnFocus()
private System.Void OnUnfocus()
protected System.Void ConnectSignals()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnIndexChanged(System.Int32 index)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void PageLeft()
public System.Void PageRight()
public System.Void SetIndex(System.Int32 index)
public virtual System.Void _GuiInput(Godot.InputEvent input)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NPaginator+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _GuiInput
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName ConnectSignals
public static readonly Godot.StringName IndexChangeHelper
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnIndexChanged
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName PageLeft
public static readonly Godot.StringName PageRight
public static readonly Godot.StringName SetIndex
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NPaginator+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _currentIndex
public static readonly Godot.StringName _label
public static readonly Godot.StringName _selectionReticle
public static readonly Godot.StringName _tween
public static readonly Godot.StringName _vfxLabel
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NPaginator+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NPhobiaModeHoverTip

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.HoverTips.IHoverTip _hoverTip
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
private System.Void OnHovered()
private System.Void OnUnhovered()
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NPhobiaModeHoverTip+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnHovered
public static readonly Godot.StringName OnUnhovered
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NPhobiaModeHoverTip+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NPhobiaModeHoverTip+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NPhobiaModeTickbox

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.Settings.IResettableSettingNode`

```text
private MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsScreen _settingsScreen
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnTick()
protected virtual System.Void OnUntick()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
public virtual System.Void SetFromSettings()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NPhobiaModeTickbox+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnTick
public static readonly Godot.StringName OnUntick
public static readonly Godot.StringName SetFromSettings
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NPhobiaModeTickbox+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox+PropertyName`。

接口：

```text
public static readonly Godot.StringName _settingsScreen
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NPhobiaModeTickbox+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NResetGameplayButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsButton`。

接口：`System.IDisposable`

```text
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
private [async] System.Threading.Tasks.Task ResetSettingsAfterConfirmation()
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void OnRelease()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NResetGameplayButton+<ResetSettingsAfterConfirmation>d__1

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.Settings.NResetGameplayButton <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NResetGameplayButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnRelease
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NResetGameplayButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsButton+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NResetGameplayButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NResetGraphicsButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsButton`。

接口：`System.IDisposable`

```text
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
private [async] System.Threading.Tasks.Task ResetSettingsAfterConfirmation()
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void OnRelease()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NResetGraphicsButton+<ResetSettingsAfterConfirmation>d__1

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.Settings.NResetGraphicsButton <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NResetGraphicsButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnRelease
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NResetGraphicsButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsButton+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NResetGraphicsButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NResetToDefaultControlsButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsButton`。

接口：`System.IDisposable`

```text
private Godot.Control _image
private MegaCrit.Sts2.addons.mega_text.MegaLabel _label
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NResetToDefaultControlsButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NResetToDefaultControlsButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _image
public static readonly Godot.StringName _label
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NResetToDefaultControlsButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NResetTutorialsButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsButton`。

接口：`System.IDisposable`

```text
private readonly MegaCrit.Sts2.Core.Localization.LocString _description
private readonly MegaCrit.Sts2.Core.Localization.LocString _header
private Godot.TextureRect _image
private MegaCrit.Sts2.addons.mega_text.MegaLabel _label
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OpenPopup(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NResetTutorialsButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OpenPopup
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NResetTutorialsButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _image
public static readonly Godot.StringName _label
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NResetTutorialsButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NResolutionDropdown

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsDropdown`。

接口：`System.IDisposable`

```text
private Godot.Control _arrow
private static Godot.Vector2I _currentResolution
private Godot.PackedScene _dropdownItemScene
private static MegaCrit.Sts2.Core.Nodes.Screens.Settings.NResolutionDropdown <Instance>k__BackingField
MegaCrit.Sts2.Core.Nodes.Screens.Settings.NResolutionDropdown Instance { public static get; private static set; }
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private static System.Boolean DoesResolutionFit(Godot.Vector2I resolution, Godot.Vector2I boundaryResolution)
private static System.Collections.Generic.List<Godot.Vector2I> GetResolutionWhiteList()
private static System.Void set_Instance(MegaCrit.Sts2.Core.Nodes.Screens.Settings.NResolutionDropdown value)
private System.Void OnDropdownItemSelected(MegaCrit.Sts2.Core.Nodes.CommonUi.NDropdownItem nDropdownItem)
private System.Void OnWindowChange(System.Boolean isAutoAspectRatio)
private System.Void RefreshEnabled()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnDisable()
protected virtual System.Void OnEnable()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.Settings.NResolutionDropdown get_Instance()
public System.Void PopulateDropdownItems()
public System.Void RefreshCurrentlySelectedResolution()
public virtual System.Void _EnterTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NResolutionDropdown+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsDropdown+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName DoesResolutionFit
public static readonly Godot.StringName OnDisable
public static readonly Godot.StringName OnDropdownItemSelected
public static readonly Godot.StringName OnEnable
public static readonly Godot.StringName OnWindowChange
public static readonly Godot.StringName PopulateDropdownItems
public static readonly Godot.StringName RefreshCurrentlySelectedResolution
public static readonly Godot.StringName RefreshEnabled
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NResolutionDropdown+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsDropdown+PropertyName`。

接口：

```text
public static readonly Godot.StringName _arrow
public static readonly Godot.StringName _dropdownItemScene
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NResolutionDropdown+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsDropdown+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NResolutionDropdownItem

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NDropdownItem`。

接口：`System.IDisposable`

```text
public Godot.Vector2I resolution
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void Init(Godot.Vector2I setResolution)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NResolutionDropdownItem+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NDropdownItem+MethodName`。

接口：

```text
public static readonly Godot.StringName Init
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NResolutionDropdownItem+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NDropdownItem+PropertyName`。

接口：

```text
public static readonly Godot.StringName resolution
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NResolutionDropdownItem+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NDropdownItem+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NRunTimerHoverTip

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.HoverTips.IHoverTip _hoverTip
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
private System.Void OnHovered()
private System.Void OnUnhovered()
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NRunTimerHoverTip+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnHovered
public static readonly Godot.StringName OnUnhovered
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NRunTimerHoverTip+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NRunTimerHoverTip+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NRunTimerTickbox

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.Settings.IResettableSettingNode`

```text
private MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsScreen _settingsScreen
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private static System.Void TryRefreshRunTimer()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnTick()
protected virtual System.Void OnUntick()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
public virtual System.Void SetFromSettings()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NRunTimerTickbox+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnTick
public static readonly Godot.StringName OnUntick
public static readonly Godot.StringName SetFromSettings
public static readonly Godot.StringName TryRefreshRunTimer
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NRunTimerTickbox+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox+PropertyName`。

接口：

```text
public static readonly Godot.StringName _settingsScreen
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NRunTimerTickbox+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NScreenshakeHoverTip

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.HoverTips.IHoverTip _hoverTip
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
private System.Void OnHovered()
private System.Void OnUnhovered()
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NScreenshakeHoverTip+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnHovered
public static readonly Godot.StringName OnUnhovered
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NScreenshakeHoverTip+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NScreenshakeHoverTip+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NScreenshakePaginator

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NPaginator`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.Settings.IResettableSettingNode`

```text
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void OnIndexChanged(System.Int32 index)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static System.Single GetShakeMultiplier(System.Int32 index)
public virtual System.Void _Ready()
public virtual System.Void SetFromSettings()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NScreenshakePaginator+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NPaginator+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName GetShakeMultiplier
public static readonly Godot.StringName OnIndexChanged
public static readonly Godot.StringName SetFromSettings
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NScreenshakePaginator+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NPaginator+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NScreenshakePaginator+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NPaginator+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private Godot.TextureRect _image
private MegaCrit.Sts2.addons.mega_text.MegaLabel _label
private MegaCrit.Sts2.Core.Nodes.Combat.NSelectionReticle _selectionReticle
private Godot.Tween _tween
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void ConnectSignals()
protected virtual System.Void OnFocus()
protected virtual System.Void OnPress()
protected virtual System.Void OnRelease()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName ConnectSignals
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnUnfocus
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _image
public static readonly Godot.StringName _label
public static readonly Godot.StringName _selectionReticle
public static readonly Godot.StringName _tween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsDropdown

类型属性：`Public, Abstract, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NDropdown`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Nodes.Combat.NSelectionReticle _selectionReticle
protected .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void ConnectSignals()
protected virtual System.Void OnFocus()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsDropdown+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NDropdown+MethodName`。

接口：

```text
public static readonly Godot.StringName ConnectSignals
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnUnfocus
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsDropdown+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NDropdown+PropertyName`。

接口：

```text
public static readonly Godot.StringName _selectionReticle
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsDropdown+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NDropdown+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsGradientMask

类型属性：`Public, BeforeFieldInit`；基类：`Godot.TextureRect`。

接口：`System.IDisposable`

```text
private static const System.Single _fadeOffset = -8
private static const System.Single _fadeSize = 16
private MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTabManager _tabContainer
private Godot.GradientTexture2D _texture
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnResized()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsGradientMask+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.TextureRect+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnResized
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsGradientMask+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.TextureRect+PropertyName`。

接口：

```text
public static readonly Godot.StringName _tabContainer
public static readonly Godot.StringName _texture
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsGradientMask+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.TextureRect+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsPaginatorArrow

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private Godot.Vector2 _baseScale
private Godot.ShaderMaterial _hsv
private Godot.TextureRect _image
private System.Boolean _isLeftArrow
private MegaCrit.Sts2.Core.Nodes.Screens.Settings.NPaginator _paginator
private Godot.Tween _tween
private static readonly Godot.StringName _v
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void UpdateShaderV(System.Single value)
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
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsPaginatorArrow+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnDisable
public static readonly Godot.StringName OnEnable
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName UpdateShaderV
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsPaginatorArrow+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _baseScale
public static readonly Godot.StringName _hsv
public static readonly Godot.StringName _image
public static readonly Godot.StringName _isLeftArrow
public static readonly Godot.StringName _paginator
public static readonly Godot.StringName _tween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsPaginatorArrow+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsPanel

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private Godot.Control _firstControl
private System.Single _minPadding
private Godot.Tween _tween
private Godot.VBoxContainer <Content>k__BackingField
Godot.VBoxContainer Content { public get; private set; }
Godot.Control DefaultFocusedControl { public get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Boolean IsSettingsOption(Godot.Control c)
private System.Void GetSettingsOptionsRecursive(Godot.Control parent, System.Collections.Generic.List<Godot.Control> ancestors, System.Boolean includeInvisibleSettings = False)
private System.Void RefreshSize()
private System.Void set_Content(Godot.VBoxContainer value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnVisibilityChange()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void UpdateNavigation()
public Godot.Control get_DefaultFocusedControl()
public Godot.VBoxContainer get_Content()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsPanel+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName IsSettingsOption
public static readonly Godot.StringName OnVisibilityChange
public static readonly Godot.StringName RefreshSize
public static readonly Godot.StringName UpdateNavigation
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsPanel+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _firstControl
public static readonly Godot.StringName _minPadding
public static readonly Godot.StringName _tween
public static readonly Godot.StringName Content
public static readonly Godot.StringName DefaultFocusedControl
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsPanel+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsScreen

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private MegaCrit.Sts2.Core.Nodes.Screens.Settings.NOpenFeedbackScreenButton _feedbackScreenButton
private System.Boolean _isInRun
private MegaCrit.Sts2.Core.Nodes.Screens.Settings.NOpenModdingScreenButton _moddingScreenButton
private static readonly System.String _scenePath
private MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTabManager _settingsTabManager
private MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsToast _toast
private MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsScreen+SettingsClosedEventHandler backing_SettingsClosed
private MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsScreen+SettingsOpenedEventHandler backing_SettingsOpened
public static readonly Godot.Vector2 settingTipsOffset
System.String[] AssetPaths { public static get; }
Godot.Control InitialFocusedControl { protected virtual get; }
event MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsScreen+SettingsClosedEventHandler SettingsClosed
event MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsScreen+SettingsOpenedEventHandler SettingsOpened
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotSignalList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private static System.Void LocHelper(Godot.Node settingsLineNode, MegaCrit.Sts2.Core.Localization.LocString locString)
private System.Void LocalizeLabels()
private System.Void OnSettingsTabChanged()
private System.Void OpenFeedbackScreen(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OpenModdingScreen(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
protected System.Void EmitSignalSettingsClosed()
protected System.Void EmitSignalSettingsOpened()
protected virtual Godot.Control get_InitialFocusedControl()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean HasGodotClassSignal(in Godot.NativeInterop.godot_string_name signal)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnSubmenuHidden()
protected virtual System.Void OnSubmenuShown()
protected virtual System.Void RaiseGodotClassSignalCallbacks(in Godot.NativeInterop.godot_string_name signal, Godot.NativeInterop.NativeVariantPtrArgs args)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public [async] System.Threading.Tasks.Task OpenFeedbackScreen()
public static System.String[] get_AssetPaths()
public System.Void add_SettingsClosed(MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsScreen+SettingsClosedEventHandler value)
public System.Void add_SettingsOpened(MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsScreen+SettingsOpenedEventHandler value)
public System.Void remove_SettingsClosed(MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsScreen+SettingsClosedEventHandler value)
public System.Void remove_SettingsOpened(MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsScreen+SettingsOpenedEventHandler value)
public System.Void SetIsInRun(System.Boolean isInRun)
public System.Void ShowToast(MegaCrit.Sts2.Core.Localization.LocString locString)
public virtual System.Void _Ready()
public virtual System.Void OnSubmenuClosed()
public virtual System.Void OnSubmenuOpened()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsScreen+<OpenFeedbackScreen>d__21

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsScreen <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsScreen+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName LocalizeLabels
public static readonly Godot.StringName OnSettingsTabChanged
public static readonly Godot.StringName OnSubmenuClosed
public static readonly Godot.StringName OnSubmenuHidden
public static readonly Godot.StringName OnSubmenuOpened
public static readonly Godot.StringName OnSubmenuShown
public static readonly Godot.StringName OpenFeedbackScreen
public static readonly Godot.StringName OpenModdingScreen
public static readonly Godot.StringName SetIsInRun
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsScreen+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+PropertyName`。

接口：

```text
public static readonly Godot.StringName _feedbackScreenButton
public static readonly Godot.StringName _isInRun
public static readonly Godot.StringName _moddingScreenButton
public static readonly Godot.StringName _settingsTabManager
public static readonly Godot.StringName _toast
public static readonly Godot.StringName InitialFocusedControl
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsScreen+SettingsClosedEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsScreen+SettingsOpenedEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsScreen+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+SignalName`。

接口：

```text
public static readonly Godot.StringName SettingsClosed
public static readonly Godot.StringName SettingsOpened
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsSlider

类型属性：`Public, Abstract, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Nodes.Combat.NSelectionReticle _selectionReticle
protected MegaCrit.Sts2.Core.Nodes.GodotExtensions.NSlider _slider
private MegaCrit.Sts2.addons.mega_text.MegaLabel _valueLabel
protected .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnFocus()
private System.Void OnUnfocus()
private System.Void OnValueChanged(System.Double value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void ConnectSignals()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _GuiInput(Godot.InputEvent input)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsSlider+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _GuiInput
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName ConnectSignals
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName OnValueChanged
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsSlider+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _selectionReticle
public static readonly Godot.StringName _slider
public static readonly Godot.StringName _valueLabel
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsSlider+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTab

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private static const System.Single _defaultV = 0.9
private static const System.Single _hoverV = 1.2
private Godot.ShaderMaterial _hsv
private Godot.TextureRect _image
private System.Boolean _isSelected
private MegaCrit.Sts2.addons.mega_text.MegaLabel _label
private Godot.TextureRect _outline
private Godot.Tween _tween
private static const System.Single _unhoverDuration = 0.5
private static readonly Godot.StringName _v
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void UpdateShaderParam(System.Single newV)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnDisable()
protected virtual System.Void OnEnable()
protected virtual System.Void OnFocus()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void Deselect()
public System.Void ForceTabPressed()
public System.Void Select()
public System.Void SetLabel(System.String text)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTab+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Deselect
public static readonly Godot.StringName ForceTabPressed
public static readonly Godot.StringName OnDisable
public static readonly Godot.StringName OnEnable
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName Select
public static readonly Godot.StringName SetLabel
public static readonly Godot.StringName UpdateShaderParam
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTab+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _hsv
public static readonly Godot.StringName _image
public static readonly Godot.StringName _isSelected
public static readonly Godot.StringName _label
public static readonly Godot.StringName _outline
public static readonly Godot.StringName _tween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTab+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTabManager

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTab _currentTab
private MegaCrit.Sts2.Core.Nodes.CommonUi.NHotkeyIcon _leftTabIcon
private MegaCrit.Sts2.Core.Nodes.CommonUi.NHotkeyIcon _rightTabIcon
private Godot.Tween _scrollbarTween
private MegaCrit.Sts2.Core.Nodes.GodotExtensions.NScrollableContainer _scrollContainer
private static const System.Single _scrollPaddingBottom = 30
private static const System.Single _scrollPaddingTop = 20
private static readonly Godot.StringName _tabLeftHotkey
private static readonly Godot.StringName _tabRightHotkey
private readonly System.Collections.Generic.Dictionary<MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTab, MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsPanel> _tabs
private MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTabManager+TabChangedEventHandler backing_TabChanged
MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsPanel CurrentlyDisplayedPanel { private get; }
Godot.Control DefaultFocusedControl { public get; }
event MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTabManager+TabChangedEventHandler TabChanged
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotSignalList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsPanel get_CurrentlyDisplayedPanel()
private System.Void SwitchTabTo(MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTab selectedTab)
private System.Void TabLeft()
private System.Void TabRight()
private System.Void UpdateControllerButton()
protected System.Void EmitSignalTabChanged()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean HasGodotClassSignal(in Godot.NativeInterop.godot_string_name signal)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RaiseGodotClassSignalCallbacks(in Godot.NativeInterop.godot_string_name signal, Godot.NativeInterop.NativeVariantPtrArgs args)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public Godot.Control get_DefaultFocusedControl()
public System.Void add_TabChanged(MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTabManager+TabChangedEventHandler value)
public System.Void Disable()
public System.Void Enable()
public System.Void remove_TabChanged(MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTabManager+TabChangedEventHandler value)
public System.Void ResetTabs()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTabManager+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Disable
public static readonly Godot.StringName Enable
public static readonly Godot.StringName ResetTabs
public static readonly Godot.StringName SwitchTabTo
public static readonly Godot.StringName TabLeft
public static readonly Godot.StringName TabRight
public static readonly Godot.StringName UpdateControllerButton
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTabManager+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _currentTab
public static readonly Godot.StringName _leftTabIcon
public static readonly Godot.StringName _rightTabIcon
public static readonly Godot.StringName _scrollbarTween
public static readonly Godot.StringName _scrollContainer
public static readonly Godot.StringName CurrentlyDisplayedPanel
public static readonly Godot.StringName DefaultFocusedControl
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTabManager+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public static readonly Godot.StringName TabChanged
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTabManager+TabChangedEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Nodes.Combat.NSelectionReticle _selectionReticle
private MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsScreen _settingsScreen
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void ConnectSignals()
protected virtual System.Void OnFocus()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox+MethodName`。

接口：

```text
public static readonly Godot.StringName ConnectSignals
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnUnfocus
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox+PropertyName`。

接口：

```text
public static readonly Godot.StringName _selectionReticle
public static readonly Godot.StringName _settingsScreen
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsToast

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _label
private System.Single _originalY
private Godot.Tween _tween
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void Show(MegaCrit.Sts2.Core.Localization.LocString locString)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsToast+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsToast+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _label
public static readonly Godot.StringName _originalY
public static readonly Godot.StringName _tween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsToast+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSfxVolumeSlider

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsSlider`。

接口：`System.IDisposable`

```text
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
private static System.Void OnDragEnded(System.Boolean valueChanged)
private static System.Void OnValueChanged(System.Double value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSfxVolumeSlider+<>O

类型属性：`NestedPrivate, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static System.Action<System.Double> <0>__OnValueChanged
public static System.Action<System.Boolean> <1>__OnDragEnded
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSfxVolumeSlider+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsSlider+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnDragEnded
public static readonly Godot.StringName OnValueChanged
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSfxVolumeSlider+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsSlider+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSfxVolumeSlider+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsSlider+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NShowMpMapDrawingsHoverTip

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.HoverTips.IHoverTip _hoverTip
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
private System.Void OnHovered()
private System.Void OnUnhovered()
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NShowMpMapDrawingsHoverTip+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnHovered
public static readonly Godot.StringName OnUnhovered
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NShowMpMapDrawingsHoverTip+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NShowMpMapDrawingsHoverTip+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NShowMpMapDrawingsTickbox

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.Settings.IResettableSettingNode`

```text
private MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsScreen _settingsScreen
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private static System.Void TryRefreshMapDrawings()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnTick()
protected virtual System.Void OnUntick()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
public virtual System.Void SetFromSettings()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NShowMpMapDrawingsTickbox+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnTick
public static readonly Godot.StringName OnUntick
public static readonly Godot.StringName SetFromSettings
public static readonly Godot.StringName TryRefreshMapDrawings
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NShowMpMapDrawingsTickbox+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox+PropertyName`。

接口：

```text
public static readonly Godot.StringName _settingsScreen
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NShowMpMapDrawingsTickbox+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NTextEffectsHoverTip

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.HoverTips.IHoverTip _hoverTip
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
private System.Void OnHovered()
private System.Void OnUnhovered()
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NTextEffectsHoverTip+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnHovered
public static readonly Godot.StringName OnUnhovered
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NTextEffectsHoverTip+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NTextEffectsHoverTip+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NTextEffectsTickbox

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.Settings.IResettableSettingNode`

```text
private MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsScreen _settingsScreen
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnTick()
protected virtual System.Void OnUntick()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
public virtual System.Void SetFromSettings()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NTextEffectsTickbox+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnTick
public static readonly Godot.StringName OnUntick
public static readonly Godot.StringName SetFromSettings
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NTextEffectsTickbox+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox+PropertyName`。

接口：

```text
public static readonly Godot.StringName _settingsScreen
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NTextEffectsTickbox+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NUploadDataTickbox

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.Settings.IResettableSettingNode`

```text
private MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsScreen _settingsScreen
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnTick()
protected virtual System.Void OnUntick()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
public virtual System.Void SetFromSettings()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NUploadDataTickbox+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnTick
public static readonly Godot.StringName OnUntick
public static readonly Godot.StringName SetFromSettings
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NUploadDataTickbox+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox+PropertyName`。

接口：

```text
public static readonly Godot.StringName _settingsScreen
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NUploadDataTickbox+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NUploadGameplayDataHoverTip

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.HoverTips.IHoverTip _hoverTip
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
private System.Void OnHovered()
private System.Void OnUnhovered()
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NUploadGameplayDataHoverTip+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnHovered
public static readonly Godot.StringName OnUnhovered
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NUploadGameplayDataHoverTip+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NUploadGameplayDataHoverTip+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NVSyncPaginator

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NPaginator`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.Settings.IResettableSettingNode`

```text
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
private static System.String GetVSyncString(MegaCrit.Sts2.Core.Settings.VSyncType vsyncType)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void OnIndexChanged(System.Int32 index)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static System.String GetVSyncLabelKey(MegaCrit.Sts2.Core.Settings.VSyncType vsyncType)
public virtual System.Void _Ready()
public virtual System.Void SetFromSettings()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NVSyncPaginator+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NPaginator+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName GetVSyncLabelKey
public static readonly Godot.StringName GetVSyncString
public static readonly Godot.StringName OnIndexChanged
public static readonly Godot.StringName SetFromSettings
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NVSyncPaginator+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NPaginator+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NVSyncPaginator+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NPaginator+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NWindowResizeHoverTip

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.HoverTips.IHoverTip _hoverTip
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
private System.Void OnHovered()
private System.Void OnUnhovered()
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NWindowResizeHoverTip+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnHovered
public static readonly Godot.StringName OnUnhovered
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NWindowResizeHoverTip+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NWindowResizeHoverTip+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NWindowResizeTickbox

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.Settings.IResettableSettingNode`

```text
private MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsScreen _settingsScreen
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnWindowChange(System.Boolean isAutoAspectRatio)
private System.Void RefreshEnabled()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnTick()
protected virtual System.Void OnUntick()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
public virtual System.Void SetFromSettings()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NWindowResizeTickbox+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnTick
public static readonly Godot.StringName OnUntick
public static readonly Godot.StringName OnWindowChange
public static readonly Godot.StringName RefreshEnabled
public static readonly Godot.StringName SetFromSettings
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NWindowResizeTickbox+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox+PropertyName`。

接口：

```text
public static readonly Godot.StringName _settingsScreen
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Settings.NWindowResizeTickbox+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTickbox+SignalName`。

接口：

```text
public .ctor()
```
