# MegaCrit.Sts2.Core.Nodes.Debug

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.Debug.BootstrapSettingsUtil

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static System.Type Get()
```

## MegaCrit.Sts2.Core.Nodes.Debug.IBootstrapSettings

类型属性：`Public, ClassSemanticsMask, Abstract, BeforeFieldInit`；基类：`无`。

接口：

```text
MegaCrit.Sts2.Core.Models.ActModel Act { public abstract get; }
System.Int32 Ascension { public abstract get; }
System.Boolean BootstrapInMultiplayer { public abstract get; }
MegaCrit.Sts2.Core.Models.CharacterModel Character { public abstract get; }
System.Boolean DoPreloading { public abstract get; }
MegaCrit.Sts2.Core.Models.EncounterModel Encounter { public abstract get; }
MegaCrit.Sts2.Core.Models.EventModel Event { public abstract get; }
System.String Language { public virtual get; }
MegaCrit.Sts2.Core.Map.MapPointType MapPointType { public virtual get; }
System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModifierModel> Modifiers { public abstract get; }
System.Nullable<System.Int32> ReplayPlayerIndex { public virtual get; }
MegaCrit.Sts2.Core.Rooms.RoomType RoomType { public abstract get; }
System.Boolean SaveRunHistory { public abstract get; }
System.String Seed { public abstract get; }
public abstract MegaCrit.Sts2.Core.Models.ActModel get_Act()
public abstract MegaCrit.Sts2.Core.Models.CharacterModel get_Character()
public abstract MegaCrit.Sts2.Core.Models.EncounterModel get_Encounter()
public abstract MegaCrit.Sts2.Core.Models.EventModel get_Event()
public abstract MegaCrit.Sts2.Core.Rooms.RoomType get_RoomType()
public abstract System.Boolean get_BootstrapInMultiplayer()
public abstract System.Boolean get_DoPreloading()
public abstract System.Boolean get_SaveRunHistory()
public abstract System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModifierModel> get_Modifiers()
public abstract System.Int32 get_Ascension()
public abstract System.String get_Seed()
public abstract System.Threading.Tasks.Task Setup(MegaCrit.Sts2.Core.Entities.Players.Player localPlayer)
public virtual MegaCrit.Sts2.Core.Map.MapPointType get_MapPointType()
public virtual System.Nullable<System.Int32> get_ReplayPlayerIndex()
public virtual System.String get_Language()
```

## MegaCrit.Sts2.Core.Nodes.Debug.IBootstrapSettingsSubtypes

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static readonly System.Type[] _subtypes
System.Collections.Generic.IReadOnlyList<System.Type> All { public static get; }
System.Int32 Count { public static get; }
private static .cctor()
public static System.Collections.Generic.IReadOnlyList<System.Type> get_All()
public static System.Int32 get_Count()
public static System.Type Get(System.Int32 i)
```

## MegaCrit.Sts2.Core.Nodes.Debug.NDebugAspectRatio

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private Godot.TextureRect _bg
private static const System.Single _bgScaleRatioThreshold = 1.5
private static readonly Godot.Vector2 _defaultBgScale
private Godot.Label _infoLabel
private static const System.Single _maxNarrowRatio = 1.3333334
private static const System.Single _maxWideRatio = 2.3888888
private Godot.Window _window
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnWindowChange()
private System.Void ScaleBgIfNarrow(System.Single ratio)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Debug.NDebugAspectRatio+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnWindowChange
public static readonly Godot.StringName ScaleBgIfNarrow
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Debug.NDebugAspectRatio+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _bg
public static readonly Godot.StringName _infoLabel
public static readonly Godot.StringName _window
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Debug.NDebugAspectRatio+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Debug.NDebugInfoLabelManager

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.addons.mega_text.MegaLabel _moddedWarning
private Godot.Control _modWarningContainer
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _modWarningLabel
private MegaCrit.Sts2.addons.mega_text.MegaLabel _releaseInfo
private MegaCrit.Sts2.addons.mega_text.MegaLabel _seed
public System.Boolean isMainMenu
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task SetCommitIdInEditor()
private System.Void OnModdedWarningHovered()
private System.Void OnModdedWarningUnhovered()
private System.Void UpdateText(System.String commitId)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Input(Godot.InputEvent inputEvent)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Debug.NDebugInfoLabelManager+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Debug.NDebugInfoLabelManager+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Modding.Mod, System.Boolean> <>9__8_0
public static System.Func<MegaCrit.Sts2.Core.Modding.Mod, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Localization.LocString>> <>9__8_1
public static System.Func<MegaCrit.Sts2.Core.Localization.LocString, System.String> <>9__8_2
public static System.Func<MegaCrit.Sts2.Core.Modding.Mod, System.String> <>9__8_3
private static .cctor()
public .ctor()
internal System.Boolean <UpdateText>b__8_0(MegaCrit.Sts2.Core.Modding.Mod m)
internal System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Localization.LocString> <UpdateText>b__8_1(MegaCrit.Sts2.Core.Modding.Mod m)
internal System.String <UpdateText>b__8_2(MegaCrit.Sts2.Core.Localization.LocString s)
internal System.String <UpdateText>b__8_3(MegaCrit.Sts2.Core.Modding.Mod m)
```

## MegaCrit.Sts2.Core.Nodes.Debug.NDebugInfoLabelManager+<SetCommitIdInEditor>d__7

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Debug.NDebugInfoLabelManager <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.String> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Debug.NDebugInfoLabelManager+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Input
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnModdedWarningHovered
public static readonly Godot.StringName OnModdedWarningUnhovered
public static readonly Godot.StringName UpdateText
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Debug.NDebugInfoLabelManager+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _moddedWarning
public static readonly Godot.StringName _modWarningContainer
public static readonly Godot.StringName _modWarningLabel
public static readonly Godot.StringName _releaseInfo
public static readonly Godot.StringName _seed
public static readonly Godot.StringName isMainMenu
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Debug.NDebugInfoLabelManager+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Debug.NDevConsole

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Panel`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.DevConsole.DevConsole _devConsole
private Godot.Label _ghostTextLabel
private Godot.LineEdit _inputBuffer
private static const System.Single _inputBufferSizeY = 40
private Godot.Control _inputContainer
private static MegaCrit.Sts2.Core.Nodes.Debug.NDevConsole _instance
private System.Boolean _isFullscreen
private Godot.RichTextLabel _outputBuffer
private Godot.Label _promptLabel
private System.String _symbolDown
private System.String _symbolPrompt
private System.String _symbolUp
private System.String _symbolWarning
private Godot.RichTextLabel _tabBuffer
private readonly MegaCrit.Sts2.Core.DevConsole.TabCompletionState _tabCompletion
private System.String _yankBuffer
public static readonly System.String assetPath
MegaCrit.Sts2.Core.Nodes.Debug.NDevConsole Instance { public static get; }
System.Boolean IsConsoleVisible { public static get; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void AcceptSelection()
private System.Void AddCandidateToDisplay(System.Collections.Generic.List<System.String> displayLines, System.Int32 index)
private System.Void AutocompleteCommand()
private System.Void DeleteWordBackward()
private System.Void DisableTabBuffer()
private System.Void EnableTabBuffer()
private System.Void ExitSelectionMode()
private System.Void HandleReadlineKeybinding(Godot.InputEventKey keyEvent)
private System.Void HideGhostText()
private System.Void KillToEndOfLine()
private System.Void NavigateSelection(System.Int32 direction)
private System.Void OnInputTextChanged(System.String newText)
private System.Void OnToggleMaximizeButtonPressed()
private System.Void PrintUsage()
private System.Void ProcessCommand()
private System.Void RenderSelectionMenu()
private System.Void ShowGhostText(System.String ghostText)
private System.Void UpdateGhostText()
private System.Void UpdatePromptStyle()
private System.Void Yank()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static Godot.CanvasLayer Create()
public static MegaCrit.Sts2.Core.Nodes.Debug.NDevConsole get_Instance()
public static System.Boolean get_IsConsoleVisible()
public System.Threading.Tasks.Task ProcessNetCommand(MegaCrit.Sts2.Core.Entities.Players.Player player, System.String netCommand)
public System.Void AddChildToTree(Godot.Node node)
public System.Void HideConsole()
public System.Void MakeFullScreen()
public System.Void MakeHalfScreen()
public System.Void MoveInputCursorToEndOfLine()
public System.Void SetBackgroundColor(Godot.Color color)
public System.Void ShowConsole()
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Input(Godot.InputEvent inputEvent)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Debug.NDevConsole+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Panel+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Input
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AcceptSelection
public static readonly Godot.StringName AddChildToTree
public static readonly Godot.StringName AutocompleteCommand
public static readonly Godot.StringName Create
public static readonly Godot.StringName DeleteWordBackward
public static readonly Godot.StringName DisableTabBuffer
public static readonly Godot.StringName EnableTabBuffer
public static readonly Godot.StringName ExitSelectionMode
public static readonly Godot.StringName HandleReadlineKeybinding
public static readonly Godot.StringName HideConsole
public static readonly Godot.StringName HideGhostText
public static readonly Godot.StringName KillToEndOfLine
public static readonly Godot.StringName MakeFullScreen
public static readonly Godot.StringName MakeHalfScreen
public static readonly Godot.StringName MoveInputCursorToEndOfLine
public static readonly Godot.StringName NavigateSelection
public static readonly Godot.StringName OnInputTextChanged
public static readonly Godot.StringName OnToggleMaximizeButtonPressed
public static readonly Godot.StringName PrintUsage
public static readonly Godot.StringName ProcessCommand
public static readonly Godot.StringName RenderSelectionMenu
public static readonly Godot.StringName SetBackgroundColor
public static readonly Godot.StringName ShowConsole
public static readonly Godot.StringName ShowGhostText
public static readonly Godot.StringName UpdateGhostText
public static readonly Godot.StringName UpdatePromptStyle
public static readonly Godot.StringName Yank
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Debug.NDevConsole+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Panel+PropertyName`。

接口：

```text
public static readonly Godot.StringName _ghostTextLabel
public static readonly Godot.StringName _inputBuffer
public static readonly Godot.StringName _inputContainer
public static readonly Godot.StringName _isFullscreen
public static readonly Godot.StringName _outputBuffer
public static readonly Godot.StringName _promptLabel
public static readonly Godot.StringName _symbolDown
public static readonly Godot.StringName _symbolPrompt
public static readonly Godot.StringName _symbolUp
public static readonly Godot.StringName _symbolWarning
public static readonly Godot.StringName _tabBuffer
public static readonly Godot.StringName _yankBuffer
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Debug.NDevConsole+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Panel+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Debug.NFormVfxTester

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NFormVfx _formVfx
private System.Boolean _testActiveState
private System.String _testBoneName
private Godot.Node2D _testSpine
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Input(Godot.InputEvent inputEvent)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Debug.NFormVfxTester+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _Input
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Debug.NFormVfxTester+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _formVfx
public static readonly Godot.StringName _testActiveState
public static readonly Godot.StringName _testBoneName
public static readonly Godot.StringName _testSpine
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Debug.NFormVfxTester+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Debug.NFpsVisualizer

类型属性：`Public, BeforeFieldInit`；基类：`Godot.TextureRect`。

接口：`System.IDisposable`

```text
private Godot.Texture2D _content
private Godot.Texture2D _happy
private Godot.Label _label
private Godot.Texture2D _neutral
private Godot.Texture2D _sad
private MegaCrit.Sts2.Core.Nodes.Debug.NFpsVisualizer+MouseReleasedEventHandler backing_MouseReleased
event MegaCrit.Sts2.Core.Nodes.Debug.NFpsVisualizer+MouseReleasedEventHandler MouseReleased
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotSignalList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void HandleMouseRelease(Godot.InputEvent inputEvent)
protected System.Void EmitSignalMouseReleased(Godot.InputEvent inputEvent)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean HasGodotClassSignal(in Godot.NativeInterop.godot_string_name signal)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RaiseGodotClassSignalCallbacks(in Godot.NativeInterop.godot_string_name signal, Godot.NativeInterop.NativeVariantPtrArgs args)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void add_MouseReleased(MegaCrit.Sts2.Core.Nodes.Debug.NFpsVisualizer+MouseReleasedEventHandler value)
public System.Void remove_MouseReleased(MegaCrit.Sts2.Core.Nodes.Debug.NFpsVisualizer+MouseReleasedEventHandler value)
public virtual System.Void _GuiInput(Godot.InputEvent inputEvent)
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Debug.NFpsVisualizer+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.TextureRect+MethodName`。

接口：

```text
public static readonly Godot.StringName _GuiInput
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName HandleMouseRelease
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Debug.NFpsVisualizer+MouseReleasedEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(Godot.InputEvent inputEvent, System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke(Godot.InputEvent inputEvent)
```

## MegaCrit.Sts2.Core.Nodes.Debug.NFpsVisualizer+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.TextureRect+PropertyName`。

接口：

```text
public static readonly Godot.StringName _content
public static readonly Godot.StringName _happy
public static readonly Godot.StringName _label
public static readonly Godot.StringName _neutral
public static readonly Godot.StringName _sad
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Debug.NFpsVisualizer+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.TextureRect+SignalName`。

接口：

```text
public static readonly Godot.StringName MouseReleased
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Debug.NOrbVfxTester

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private System.Single _baseEvokeValue
private System.Single _basePassiveValue
private Godot.Control _combatVfxContainer
private System.Decimal _evokeVal
private System.Boolean _isFocused
private MegaCrit.Sts2.Core.Nodes.Orbs.NOrbVfx _orbVfx
private System.Single _passiveIncrements
private System.Decimal _passiveVal
private Godot.Node2D _playerCenter
private Godot.Node2D _target
private MegaCrit.Sts2.Core.Nodes.Debug.NOrbVfxTester+OrbVfxTestModelType _testModelType
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Input(Godot.InputEvent inputEvent)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Debug.NOrbVfxTester+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Input
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Debug.NOrbVfxTester+OrbVfxTestModelType

类型属性：`NestedPrivate, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Nodes.Debug.NOrbVfxTester+OrbVfxTestModelType Dark = 1
public static const MegaCrit.Sts2.Core.Nodes.Debug.NOrbVfxTester+OrbVfxTestModelType Frost = 2
public static const MegaCrit.Sts2.Core.Nodes.Debug.NOrbVfxTester+OrbVfxTestModelType Glass = 3
public static const MegaCrit.Sts2.Core.Nodes.Debug.NOrbVfxTester+OrbVfxTestModelType Lightning = 0
public static const MegaCrit.Sts2.Core.Nodes.Debug.NOrbVfxTester+OrbVfxTestModelType Plasma = 4
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Nodes.Debug.NOrbVfxTester+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _baseEvokeValue
public static readonly Godot.StringName _basePassiveValue
public static readonly Godot.StringName _combatVfxContainer
public static readonly Godot.StringName _isFocused
public static readonly Godot.StringName _orbVfx
public static readonly Godot.StringName _passiveIncrements
public static readonly Godot.StringName _playerCenter
public static readonly Godot.StringName _target
public static readonly Godot.StringName _testModelType
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Debug.NOrbVfxTester+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Debug.NParticleCounter

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private Godot.TextureRect _icon
private Godot.Label _label
private static const System.Single _secondsPerUpdate = 5
private System.Double _secondsSinceLastUpdate
private static readonly Godot.StringName _toggleParticleCounter
private System.Int32 _totalParticles
private System.Int32 _updateCount
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private static System.Collections.Generic.List<Godot.Node> GetChildrenRecursive(Godot.Node root)
private System.Void CheckForHotkey(Godot.InputEvent inputEvent)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Input(Godot.InputEvent inputEvent)
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Debug.NParticleCounter+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Input
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName CheckForHotkey
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Debug.NParticleCounter+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _icon
public static readonly Godot.StringName _label
public static readonly Godot.StringName _secondsSinceLastUpdate
public static readonly Godot.StringName _totalParticles
public static readonly Godot.StringName _updateCount
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Debug.NParticleCounter+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Debug.NSceneBootstrapper

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Nodes.NGame _game
private System.Boolean _openConsole
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task StartNewRun()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Debug.NSceneBootstrapper+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Debug.NSceneBootstrapper+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Models.ActModel, MegaCrit.Sts2.Core.Models.ActModel> <>9__3_0
private static .cctor()
public .ctor()
internal MegaCrit.Sts2.Core.Models.ActModel <StartNewRun>b__3_0(MegaCrit.Sts2.Core.Models.ActModel a)
```

## MegaCrit.Sts2.Core.Nodes.Debug.NSceneBootstrapper+<StartNewRun>d__3

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Debug.NSceneBootstrapper <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Rooms.AbstractRoom> <>u__2
private MegaCrit.Sts2.Core.Runs.RunState <runState>5__3
private MegaCrit.Sts2.Core.Nodes.Debug.IBootstrapSettings <settings>5__2
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Debug.NSceneBootstrapper+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Debug.NSceneBootstrapper+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _game
public static readonly Godot.StringName _openConsole
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Debug.NSceneBootstrapper+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```
