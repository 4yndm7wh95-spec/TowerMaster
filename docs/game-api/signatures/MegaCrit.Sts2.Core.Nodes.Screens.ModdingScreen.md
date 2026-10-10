# MegaCrit.Sts2.Core.Nodes.Screens.ModdingScreen

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.Screens.ModdingScreen.NConfirmModLoadingPopup

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private static readonly System.String _scenePath
private MegaCrit.Sts2.Core.Nodes.CommonUi.NVerticalPopup _verticalPopup
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
Godot.Control DefaultFocusedControl { public virtual get; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnNoButtonPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OnYesButtonPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.ModdingScreen.NConfirmModLoadingPopup Create()
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual Godot.Control get_DefaultFocusedControl()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.ModdingScreen.NConfirmModLoadingPopup+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName OnNoButtonPressed
public static readonly Godot.StringName OnYesButtonPressed
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.ModdingScreen.NConfirmModLoadingPopup+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _verticalPopup
public static readonly Godot.StringName DefaultFocusedControl
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.ModdingScreen.NConfirmModLoadingPopup+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.ModdingScreen.NModdingScreen

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private MegaCrit.Sts2.Core.Nodes.Screens.ModdingScreen.NModInfoContainer _modInfoContainer
private Godot.Control _modRowContainer
private Godot.Control _pendingChangesWarning
private static readonly System.String _scenePath
private MegaCrit.Sts2.Core.Nodes.GodotExtensions.NScrollableContainer _scrollableContainer
System.String[] AssetPaths { public static get; }
Godot.Control InitialFocusedControl { protected virtual get; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnGetModsPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OnMakeModsPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OnNewModDetected(MegaCrit.Sts2.Core.Modding.Mod mod)
protected virtual Godot.Control get_InitialFocusedControl()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.ModdingScreen.NModdingScreen Create()
public static System.String[] get_AssetPaths()
public System.Void OnModEnabledOrDisabled()
public System.Void OnRowSelected(MegaCrit.Sts2.Core.Nodes.Screens.ModdingScreen.NModMenuRow row)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
public virtual System.Void OnSubmenuClosed()
public virtual System.Void OnSubmenuOpened()
```

## MegaCrit.Sts2.Core.Nodes.Screens.ModdingScreen.NModdingScreen+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName OnGetModsPressed
public static readonly Godot.StringName OnMakeModsPressed
public static readonly Godot.StringName OnModEnabledOrDisabled
public static readonly Godot.StringName OnRowSelected
public static readonly Godot.StringName OnSubmenuClosed
public static readonly Godot.StringName OnSubmenuOpened
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.ModdingScreen.NModdingScreen+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+PropertyName`。

接口：

```text
public static readonly Godot.StringName _modInfoContainer
public static readonly Godot.StringName _modRowContainer
public static readonly Godot.StringName _pendingChangesWarning
public static readonly Godot.StringName _scrollableContainer
public static readonly Godot.StringName InitialFocusedControl
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.ModdingScreen.NModdingScreen+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.ModdingScreen.NModInfoContainer

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _description
private Godot.TextureRect _image
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _title
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void Clear()
public System.Void Fill(MegaCrit.Sts2.Core.Modding.Mod mod)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.ModdingScreen.NModInfoContainer+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Clear
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.ModdingScreen.NModInfoContainer+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _description
public static readonly Godot.StringName _image
public static readonly Godot.StringName _title
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.ModdingScreen.NModInfoContainer+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.ModdingScreen.NModMenuButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private Godot.Tween _hoverTween
private Godot.ShaderMaterial _hsv
private Godot.TextureRect _image
private MegaCrit.Sts2.addons.mega_text.MegaLabel _label
private static readonly Godot.StringName _v
private Godot.Viewport _viewport
private Godot.Control _visuals
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

## MegaCrit.Sts2.Core.Nodes.Screens.ModdingScreen.NModMenuButton+MethodName

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

## MegaCrit.Sts2.Core.Nodes.Screens.ModdingScreen.NModMenuButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _hoverTween
public static readonly Godot.StringName _hsv
public static readonly Godot.StringName _image
public static readonly Godot.StringName _label
public static readonly Godot.StringName _viewport
public static readonly Godot.StringName _visuals
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.ModdingScreen.NModMenuButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.ModdingScreen.NModMenuRow

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Nodes.CommonUi.NHotkeyIcon _hotkeyIcon
private System.Boolean _isSelected
private static readonly System.String _scenePath
private MegaCrit.Sts2.Core.Nodes.Screens.ModdingScreen.NModdingScreen _screen
private static const System.Single _selectedAlpha = 0.25
private Godot.Panel _selectionHighlight
private MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox _tickbox
private MegaCrit.Sts2.Core.Modding.Mod <Mod>k__BackingField
System.String Hotkey { private get; }
MegaCrit.Sts2.Core.Modding.Mod Mod { public get; private set; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.String get_Hotkey()
private System.Void OnTickboxToggled(MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox tickbox)
private System.Void set_Mod(MegaCrit.Sts2.Core.Modding.Mod value)
private System.Void UpdateControllerButton()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnFocus()
protected virtual System.Void OnRelease()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public MegaCrit.Sts2.Core.Modding.Mod get_Mod()
public static Godot.Texture2D GetPlatformIcon(MegaCrit.Sts2.Core.Modding.ModSource modSource)
public static MegaCrit.Sts2.Core.Nodes.Screens.ModdingScreen.NModMenuRow Create(MegaCrit.Sts2.Core.Nodes.Screens.ModdingScreen.NModdingScreen screen, MegaCrit.Sts2.Core.Modding.Mod mod)
public System.Void SetSelected(System.Boolean isSelected)
public virtual System.Void _GuiInput(Godot.InputEvent inputEvent)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.ModdingScreen.NModMenuRow+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+MethodName`。

接口：

```text
public static readonly Godot.StringName _GuiInput
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName GetPlatformIcon
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnTickboxToggled
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName SetSelected
public static readonly Godot.StringName UpdateControllerButton
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.ModdingScreen.NModMenuRow+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+PropertyName`。

接口：

```text
public static readonly Godot.StringName _hotkeyIcon
public static readonly Godot.StringName _isSelected
public static readonly Godot.StringName _screen
public static readonly Godot.StringName _selectionHighlight
public static readonly Godot.StringName _tickbox
public static readonly Godot.StringName Hotkey
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.ModdingScreen.NModMenuRow+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+SignalName`。

接口：

```text
public .ctor()
```
