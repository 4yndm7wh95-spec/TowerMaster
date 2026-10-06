# MegaCrit.Sts2.Core.Nodes.Screens.PauseMenu

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.Screens.PauseMenu.NPauseMenu

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private MegaCrit.Sts2.Core.Nodes.CommonUi.NBackButton _backButton
private Godot.Control _buttonContainer
private MegaCrit.Sts2.Core.Nodes.Screens.PauseMenu.NPauseMenuButton _compendiumButton
private static readonly MegaCrit.Sts2.Core.Localization.LocString _compendiumLoc
private MegaCrit.Sts2.Core.Nodes.Screens.PauseMenu.NPauseMenuButton _disconnectButton
private static readonly MegaCrit.Sts2.Core.Localization.LocString _disconnectLoc
private MegaCrit.Sts2.Core.Nodes.Screens.PauseMenu.NPauseMenuButton _giveUpButton
private static readonly MegaCrit.Sts2.Core.Localization.LocString _giveUpLoc
private MegaCrit.Sts2.addons.mega_text.MegaLabel _pausedLabel
private static readonly MegaCrit.Sts2.Core.Localization.LocString _pausedLoc
private MegaCrit.Sts2.Core.Nodes.Screens.PauseMenu.NPauseMenuButton _resumeButton
private static readonly MegaCrit.Sts2.Core.Localization.LocString _resumeLoc
private MegaCrit.Sts2.Core.Runs.IRunState _runState
private MegaCrit.Sts2.Core.Nodes.Screens.PauseMenu.NPauseMenuButton _saveAndQuitButton
private static readonly MegaCrit.Sts2.Core.Localization.LocString _saveAndQuitLoc
private MegaCrit.Sts2.Core.Nodes.Screens.PauseMenu.NPauseMenuButton _settingsButton
private static readonly MegaCrit.Sts2.Core.Localization.LocString _settingsLoc
MegaCrit.Sts2.Core.Nodes.Screens.PauseMenu.NPauseMenuButton[] Buttons { private get; }
Godot.Control InitialFocusedControl { protected virtual get; }
MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType ScreenType { public get; }
System.Boolean UseSharedBackstop { public get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task CloseToMenu()
private MegaCrit.Sts2.Core.Nodes.Screens.PauseMenu.NPauseMenuButton[] get_Buttons()
private System.Void OnBackOrResumeButtonPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OnCompendiumButtonPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OnDisconnectButtonPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OnGiveUpButtonPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OnSaveAndQuitButtonPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OnSettingsButtonPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void RefreshLabels()
protected virtual Godot.Control get_InitialFocusedControl()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType get_ScreenType()
public System.Boolean get_UseSharedBackstop()
public System.Void Initialize(MegaCrit.Sts2.Core.Runs.IRunState runState)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
public virtual System.Void OnSubmenuClosed()
public virtual System.Void OnSubmenuOpened()
```

## MegaCrit.Sts2.Core.Nodes.Screens.PauseMenu.NPauseMenu+<CloseToMenu>d__35

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.PauseMenu.NPauseMenu <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.PauseMenu.NPauseMenu+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnBackOrResumeButtonPressed
public static readonly Godot.StringName OnCompendiumButtonPressed
public static readonly Godot.StringName OnDisconnectButtonPressed
public static readonly Godot.StringName OnGiveUpButtonPressed
public static readonly Godot.StringName OnSaveAndQuitButtonPressed
public static readonly Godot.StringName OnSettingsButtonPressed
public static readonly Godot.StringName OnSubmenuClosed
public static readonly Godot.StringName OnSubmenuOpened
public static readonly Godot.StringName RefreshLabels
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.PauseMenu.NPauseMenu+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+PropertyName`。

接口：

```text
public static readonly Godot.StringName _backButton
public static readonly Godot.StringName _buttonContainer
public static readonly Godot.StringName _compendiumButton
public static readonly Godot.StringName _disconnectButton
public static readonly Godot.StringName _giveUpButton
public static readonly Godot.StringName _pausedLabel
public static readonly Godot.StringName _resumeButton
public static readonly Godot.StringName _saveAndQuitButton
public static readonly Godot.StringName _settingsButton
public static readonly Godot.StringName Buttons
public static readonly Godot.StringName InitialFocusedControl
public static readonly Godot.StringName ScreenType
public static readonly Godot.StringName UseSharedBackstop
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.PauseMenu.NPauseMenu+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.PauseMenu.NPauseMenuButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Nodes.CommonUi.NBackButton _backButton
private static const System.Single _hoverS = 1.1
private static const System.Single _hoverV = 1.1
private Godot.ShaderMaterial _hsv
private Godot.TextureRect _image
private MegaCrit.Sts2.addons.mega_text.MegaLabel _label
private static const System.Single _pressDownYOffset = 6
private static readonly Godot.StringName _s
private Godot.Tween _tween
private static const System.Single _unhoverS = 0.8
private static const System.Single _unhoverV = 0.9
private static readonly Godot.StringName _v
System.Boolean UseSharedBackstop { public get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void UpdateShaderS(System.Single value)
private System.Void UpdateShaderV(System.Single value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnDisable()
protected virtual System.Void OnEnable()
protected virtual System.Void OnFocus()
protected virtual System.Void OnPress()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Boolean get_UseSharedBackstop()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.PauseMenu.NPauseMenuButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnDisable
public static readonly Godot.StringName OnEnable
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName UpdateShaderS
public static readonly Godot.StringName UpdateShaderV
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.PauseMenu.NPauseMenuButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _backButton
public static readonly Godot.StringName _hsv
public static readonly Godot.StringName _image
public static readonly Godot.StringName _label
public static readonly Godot.StringName _tween
public static readonly Godot.StringName UseSharedBackstop
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.PauseMenu.NPauseMenuButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```
