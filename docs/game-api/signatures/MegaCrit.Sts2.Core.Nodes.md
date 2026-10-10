# MegaCrit.Sts2.Core.Nodes

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.NActBanner

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Models.ActModel _act
private System.Int32 _actIndex
private MegaCrit.Sts2.addons.mega_text.MegaLabel _actName
private MegaCrit.Sts2.addons.mega_text.MegaLabel _actNumber
private Godot.ColorRect _banner
private static readonly System.String _path
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task AnimateVfx()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.NActBanner Create(MegaCrit.Sts2.Core.Models.ActModel act, System.Int32 actIndex)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.NActBanner+<AnimateVfx>d__10

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.NActBanner <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.NActBanner+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.NActBanner+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _actIndex
public static readonly Godot.StringName _actName
public static readonly Godot.StringName _actNumber
public static readonly Godot.StringName _banner
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.NActBanner+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.NAncientNameBanner

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Models.AncientEventModel _ancient
private MegaCrit.Sts2.Core.RichTextTags.RichTextAncientBanner _ancientBannerEffect
private MegaCrit.Sts2.addons.mega_text.MegaLabel _epithetLabel
private Godot.Tween _moveTween
private static readonly System.String _path
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _titleLabel
private Godot.Tween _tween
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task AnimateVfx()
private System.Single GetTextCenterGlyphIndex(System.String text, Godot.Font font, System.Int32 fontSize)
private System.Void UpdateGlyphSpace(System.Single spacing)
private System.Void UpdateTransform(System.Single obj)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.NAncientNameBanner Create(MegaCrit.Sts2.Core.Models.AncientEventModel ancient)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.NAncientNameBanner+<AnimateVfx>d__11

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.NAncientNameBanner <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.NAncientNameBanner+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName GetTextCenterGlyphIndex
public static readonly Godot.StringName UpdateGlyphSpace
public static readonly Godot.StringName UpdateTransform
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.NAncientNameBanner+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _ancientBannerEffect
public static readonly Godot.StringName _epithetLabel
public static readonly Godot.StringName _moveTween
public static readonly Godot.StringName _titleLabel
public static readonly Godot.StringName _tween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.NAncientNameBanner+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.NAssetLoader

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Assets.AssetLoadingSession _currentSession
private static MegaCrit.Sts2.Core.Nodes.NAssetLoader _instance
private readonly System.Collections.Concurrent.ConcurrentQueue<MegaCrit.Sts2.Core.Assets.AssetLoadingSession> _sessions
MegaCrit.Sts2.Core.Nodes.NAssetLoader Instance { public static get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.NAssetLoader get_Instance()
public System.Threading.Tasks.Task<System.Boolean> LoadInTheBackground(MegaCrit.Sts2.Core.Assets.AssetLoadingSession session)
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.NAssetLoader+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.NAssetLoader+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.NAssetLoader+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.NBackgroundModeHandler

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private static const System.Int32 _backgroundFps = 30
private System.Boolean _isBackgrounded
private System.Int32 _savedMaxFps
System.Boolean IsEditor { private static get; }
System.Boolean IsHeadless { private static get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private static System.Boolean get_IsEditor()
private static System.Boolean get_IsHeadless()
private System.Void EnterBackgroundMode()
private System.Void ExitBackgroundMode()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Notification(System.Int32 what)
```

## MegaCrit.Sts2.Core.Nodes.NBackgroundModeHandler+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Notification
public static readonly Godot.StringName EnterBackgroundMode
public static readonly Godot.StringName ExitBackgroundMode
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.NBackgroundModeHandler+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _isBackgrounded
public static readonly Godot.StringName _savedMaxFps
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.NBackgroundModeHandler+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.NGame

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private readonly System.Threading.Tasks.TaskCompletionSource _gameStartupComplete
private Godot.Control _inspectionContainer
private MegaCrit.Sts2.Core.Platform.Steam.SteamJoinCallbackHandler _joinCallbackHandler
private System.Threading.CancellationTokenSource _logoCancelToken
private static System.Nullable<System.Int32> _mainThreadId
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NScreenShake _screenShake
private static Godot.Window _window
private MegaCrit.Sts2.Core.Nodes.Audio.NAudioManager <AudioManager>k__BackingField
private MegaCrit.Sts2.Core.Nodes.CommonUi.NCursorManager <CursorManager>k__BackingField
private MegaCrit.Sts2.Core.Audio.Debug.NDebugAudioManager <DebugAudio>k__BackingField
private System.String <DebugSeedOverride>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackScreen <FeedbackScreen>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NHitStop <HitStop>k__BackingField
private MegaCrit.Sts2.Core.Nodes.CommonUi.NHotkeyManager <HotkeyManager>k__BackingField
private Godot.Node <HoverTipsContainer>k__BackingField
private MegaCrit.Sts2.Core.Nodes.CommonUi.NInputManager <InputManager>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Screens.NInspectCardScreen <InspectCardScreen>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Screens.InspectScreens.NInspectRelicScreen <InspectRelicScreen>k__BackingField
private static MegaCrit.Sts2.Core.Nodes.NGame <Instance>k__BackingField
private static System.Boolean <IsDebugHidingHoverTips>k__BackingField
private static System.Boolean <IsDebugHidingProceedButton>k__BackingField
private static System.Boolean <IsTrailerMode>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Reaction.NReactionContainer <ReactionContainer>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Reaction.NReactionWheel <ReactionWheel>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteMouseCursorContainer <RemoteCursorContainer>k__BackingField
private MegaCrit.Sts2.Core.Nodes.NSceneContainer <RootSceneContainer>k__BackingField
private System.Boolean <StartOnMainMenu>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerTimeoutOverlay <TimeoutOverlay>k__BackingField
private MegaCrit.Sts2.Core.Nodes.NTransition <Transition>k__BackingField
private Godot.WorldEnvironment <WorldEnvironment>k__BackingField
private MegaCrit.Sts2.Core.Nodes.NGame+PhobiaModeToggledEventHandler backing_PhobiaModeToggled
private MegaCrit.Sts2.Core.Nodes.NGame+WindowChangeEventHandler backing_WindowChange
private System.Action DebugToggleProceedButton
public static readonly Godot.Vector2 devResolution
MegaCrit.Sts2.Core.Nodes.Audio.NAudioManager AudioManager { public get; private set; }
MegaCrit.Sts2.Core.Nodes.NRun CurrentRunNode { public get; }
MegaCrit.Sts2.Core.Nodes.CommonUi.NCursorManager CursorManager { public get; private set; }
MegaCrit.Sts2.Core.Audio.Debug.NDebugAudioManager DebugAudio { public get; private set; }
System.String DebugSeedOverride { public get; public set; }
MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackScreen FeedbackScreen { public get; private set; }
System.Threading.Tasks.Task GameStartupComplete { public get; }
MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NHitStop HitStop { private get; private set; }
MegaCrit.Sts2.Core.Nodes.CommonUi.NHotkeyManager HotkeyManager { public get; private set; }
Godot.Node HoverTipsContainer { public get; private set; }
MegaCrit.Sts2.Core.Nodes.CommonUi.NInputManager InputManager { public get; private set; }
MegaCrit.Sts2.Core.Nodes.Screens.NInspectCardScreen InspectCardScreen { public get; public set; }
MegaCrit.Sts2.Core.Nodes.Screens.InspectScreens.NInspectRelicScreen InspectRelicScreen { public get; public set; }
MegaCrit.Sts2.Core.Nodes.NGame Instance { public static get; private static set; }
System.Boolean IsDebugHidingHoverTips { public static get; private static set; }
System.Boolean IsDebugHidingProceedButton { public static get; private static set; }
System.Boolean IsTrailerMode { public static get; private static set; }
MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NLogoAnimation LogoAnimation { public get; }
MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu MainMenu { public get; }
MegaCrit.Sts2.Core.Nodes.Reaction.NReactionContainer ReactionContainer { public get; private set; }
MegaCrit.Sts2.Core.Nodes.Reaction.NReactionWheel ReactionWheel { public get; private set; }
MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteMouseCursorContainer RemoteCursorContainer { public get; private set; }
MegaCrit.Sts2.Core.Nodes.NSceneContainer RootSceneContainer { public get; private set; }
Godot.Control ScreenshakeTarget { public get; }
System.Boolean StartOnMainMenu { public get; public set; }
MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerTimeoutOverlay TimeoutOverlay { public get; private set; }
MegaCrit.Sts2.Core.Nodes.NTransition Transition { public get; private set; }
Godot.WorldEnvironment WorldEnvironment { private get; private set; }
event System.Action DebugToggleProceedButton
event MegaCrit.Sts2.Core.Nodes.NGame+PhobiaModeToggledEventHandler PhobiaModeToggled
event MegaCrit.Sts2.Core.Nodes.NGame+WindowChangeEventHandler WindowChange
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotSignalList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
internal static System.String FormatBytes(System.UInt64 bytes)
private [async] System.Threading.Tasks.Task DoCloudSync()
private [async] System.Threading.Tasks.Task GameStartup()
private [async] System.Threading.Tasks.Task GameStartupError()
private [async] System.Threading.Tasks.Task GameStartupWrapper()
private [async] System.Threading.Tasks.Task LaunchMainMenu(System.Boolean skipLogo)
private [async] System.Threading.Tasks.Task LoadDeferredStartupAssetsAsync()
private [async] System.Threading.Tasks.Task LoadMainMenu(System.Boolean openTimeline = False)
private [async] System.Threading.Tasks.Task StartRun(MegaCrit.Sts2.Core.Runs.RunState runState)
private [async] System.Threading.Tasks.Task TryErrorInit()
private [async] System.Threading.Tasks.Task<System.Boolean> InitializePlatform()
private Godot.WorldEnvironment get_WorldEnvironment()
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NHitStop get_HitStop()
private static System.Void set_Instance(MegaCrit.Sts2.Core.Nodes.NGame value)
private static System.Void set_IsDebugHidingHoverTips(System.Boolean value)
private static System.Void set_IsDebugHidingProceedButton(System.Boolean value)
private static System.Void set_IsTrailerMode(System.Boolean value)
private System.Void CheckShowLocalizationOverrideErrors()
private System.Void CheckShowModdedSaveFilePopup()
private System.Void DebugModifyTimescale(System.Double offset)
private System.Void InitializeGraphicsPreferences()
private System.Void InitPools()
private System.Void OnFilesDropped(System.String[] files)
private System.Void OnNewModDetected(MegaCrit.Sts2.Core.Modding.Mod mod)
private System.Void OnSteamNoLongerRunning()
private System.Void OnWindowChange()
private System.Void set_AudioManager(MegaCrit.Sts2.Core.Nodes.Audio.NAudioManager value)
private System.Void set_CursorManager(MegaCrit.Sts2.Core.Nodes.CommonUi.NCursorManager value)
private System.Void set_DebugAudio(MegaCrit.Sts2.Core.Audio.Debug.NDebugAudioManager value)
private System.Void set_FeedbackScreen(MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackScreen value)
private System.Void set_HitStop(MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NHitStop value)
private System.Void set_HotkeyManager(MegaCrit.Sts2.Core.Nodes.CommonUi.NHotkeyManager value)
private System.Void set_HoverTipsContainer(Godot.Node value)
private System.Void set_InputManager(MegaCrit.Sts2.Core.Nodes.CommonUi.NInputManager value)
private System.Void set_ReactionContainer(MegaCrit.Sts2.Core.Nodes.Reaction.NReactionContainer value)
private System.Void set_ReactionWheel(MegaCrit.Sts2.Core.Nodes.Reaction.NReactionWheel value)
private System.Void set_RemoteCursorContainer(MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteMouseCursorContainer value)
private System.Void set_RootSceneContainer(MegaCrit.Sts2.Core.Nodes.NSceneContainer value)
private System.Void set_TimeoutOverlay(MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerTimeoutOverlay value)
private System.Void set_Transition(MegaCrit.Sts2.Core.Nodes.NTransition value)
private System.Void set_WorldEnvironment(Godot.WorldEnvironment value)
private System.Void ToggleFullscreen()
protected System.Void EmitSignalPhobiaModeToggled()
protected System.Void EmitSignalWindowChange()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean HasGodotClassSignal(in Godot.NativeInterop.godot_string_name signal)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RaiseGodotClassSignalCallbacks(in Godot.NativeInterop.godot_string_name signal, Godot.NativeInterop.NativeVariantPtrArgs args)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public [async] System.Threading.Tasks.Task GoToTimeline()
public [async] System.Threading.Tasks.Task GoToTimelineAfterRun()
public [async] System.Threading.Tasks.Task LoadRun(MegaCrit.Sts2.Core.Runs.RunState runState, MegaCrit.Sts2.Core.Saves.Runs.SerializableRoom preFinishedRoom)
public [async] System.Threading.Tasks.Task ReturnToMainMenu()
public [async] System.Threading.Tasks.Task ReturnToMainMenuAfterRun()
public [async] System.Threading.Tasks.Task ReturnToMainMenuWithInternalError(System.Exception e)
public [async] System.Threading.Tasks.Task<MegaCrit.Sts2.Core.Runs.RunState> StartNewMultiplayerRun(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby lobby, System.Boolean shouldSave, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel> acts, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel> modifiers, System.String seed, System.Int32 ascensionLevel, System.Nullable<System.DateTimeOffset> dailyTime = null)
public [async] System.Threading.Tasks.Task<MegaCrit.Sts2.Core.Runs.RunState> StartNewSingleplayerRun(MegaCrit.Sts2.Core.Models.CharacterModel character, System.Boolean shouldSave, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel> acts, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel> modifiers, System.String seed, MegaCrit.Sts2.Core.Runs.GameMode gameMode, System.Int32 ascensionLevel = 0, System.Nullable<System.DateTimeOffset> dailyTime = null)
public Godot.Control get_ScreenshakeTarget()
public Godot.Node get_HoverTipsContainer()
public Godot.WorldEnvironment ActivateWorldEnvironment()
public MegaCrit.Sts2.Core.Audio.Debug.NDebugAudioManager get_DebugAudio()
public MegaCrit.Sts2.Core.Nodes.Audio.NAudioManager get_AudioManager()
public MegaCrit.Sts2.Core.Nodes.CommonUi.NCursorManager get_CursorManager()
public MegaCrit.Sts2.Core.Nodes.CommonUi.NHotkeyManager get_HotkeyManager()
public MegaCrit.Sts2.Core.Nodes.CommonUi.NInputManager get_InputManager()
public MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerTimeoutOverlay get_TimeoutOverlay()
public MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteMouseCursorContainer get_RemoteCursorContainer()
public MegaCrit.Sts2.Core.Nodes.NRun get_CurrentRunNode()
public MegaCrit.Sts2.Core.Nodes.NSceneContainer get_RootSceneContainer()
public MegaCrit.Sts2.Core.Nodes.NTransition get_Transition()
public MegaCrit.Sts2.Core.Nodes.Reaction.NReactionContainer get_ReactionContainer()
public MegaCrit.Sts2.Core.Nodes.Reaction.NReactionWheel get_ReactionWheel()
public MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackScreen get_FeedbackScreen()
public MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackScreen GetOrCreateFeedbackScreen()
public MegaCrit.Sts2.Core.Nodes.Screens.InspectScreens.NInspectRelicScreen get_InspectRelicScreen()
public MegaCrit.Sts2.Core.Nodes.Screens.InspectScreens.NInspectRelicScreen GetInspectRelicScreen()
public MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NLogoAnimation get_LogoAnimation()
public MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu get_MainMenu()
public MegaCrit.Sts2.Core.Nodes.Screens.NInspectCardScreen get_InspectCardScreen()
public MegaCrit.Sts2.Core.Nodes.Screens.NInspectCardScreen GetInspectCardScreen()
public static MegaCrit.Sts2.Core.Nodes.NGame get_Instance()
public static System.Boolean get_IsDebugHidingHoverTips()
public static System.Boolean get_IsDebugHidingProceedButton()
public static System.Boolean get_IsTrailerMode()
public static System.Boolean IsGameFocusedWindow()
public static System.Boolean IsMainThread()
public static System.Boolean IsReleaseGame()
public static System.String GetGameVersion()
public static System.Void ApplySyncSetting()
public static System.Void LogResourceStats(System.String context)
public static System.Void Reset()
public static System.Void ToggleTrailerMode()
public System.Boolean get_StartOnMainMenu()
public System.String get_DebugSeedOverride()
public System.Threading.Tasks.Task get_GameStartupComplete()
public System.Void add_DebugToggleProceedButton(System.Action value)
public System.Void add_PhobiaModeToggled(MegaCrit.Sts2.Core.Nodes.NGame+PhobiaModeToggledEventHandler value)
public System.Void add_WindowChange(MegaCrit.Sts2.Core.Nodes.NGame+WindowChangeEventHandler value)
public System.Void ApplyDisplaySettings()
public System.Void CheckShowSaveFileError(MegaCrit.Sts2.Core.Saves.ReadSaveResult<MegaCrit.Sts2.Core.Saves.SerializableProgress> progressReadResult, MegaCrit.Sts2.Core.Saves.ReadSaveResult<MegaCrit.Sts2.Core.Saves.PrefsSave> prefsReadResult, MegaCrit.Sts2.Core.Saves.ReadSaveResult<MegaCrit.Sts2.Core.Saves.SettingsSave> settingsReadResult)
public System.Void ClearScreenShakeTarget()
public System.Void DeactivateWorldEnvironment()
public System.Void DoHitStop(MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.ShakeStrength strength, MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.ShakeDuration duration)
public System.Void Quit()
public System.Void ReloadMainMenu()
public System.Void Relocalize()
public System.Void remove_DebugToggleProceedButton(System.Action value)
public System.Void remove_PhobiaModeToggled(MegaCrit.Sts2.Core.Nodes.NGame+PhobiaModeToggledEventHandler value)
public System.Void remove_WindowChange(MegaCrit.Sts2.Core.Nodes.NGame+WindowChangeEventHandler value)
public System.Void ScreenRumble(MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.ShakeStrength strength, MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.ShakeDuration duration, MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.RumbleStyle style)
public System.Void ScreenShake(MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.ShakeStrength strength, MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.ShakeDuration duration, System.Single degAngle = -1)
public System.Void ScreenShakeTrauma(MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.ShakeStrength strength)
public System.Void set_DebugSeedOverride(System.String value)
public System.Void set_InspectCardScreen(MegaCrit.Sts2.Core.Nodes.Screens.NInspectCardScreen value)
public System.Void set_InspectRelicScreen(MegaCrit.Sts2.Core.Nodes.Screens.InspectScreens.NInspectRelicScreen value)
public System.Void set_StartOnMainMenu(System.Boolean value)
public System.Void SetScreenshakeMultiplier(System.Single multiplier)
public System.Void SetScreenShakeTarget(Godot.Control target)
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Input(Godot.InputEvent inputEvent)
public virtual System.Void _Notification(System.Int32 what)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.NGame+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.NGame+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Models.ActModel, MegaCrit.Sts2.Core.Models.ActModel> <>9__145_0
public static System.Func<MegaCrit.Sts2.Core.Entities.Multiplayer.StartRunLobbyPlayer, MegaCrit.Sts2.Core.Entities.Players.Player> <>9__146_0
public static System.Func<MegaCrit.Sts2.Core.Models.ActModel, MegaCrit.Sts2.Core.Models.ActModel> <>9__146_1
public static System.Func<MegaCrit.Sts2.Core.Entities.Players.Player, MegaCrit.Sts2.Core.Models.CharacterModel> <>9__147_0
public static System.Func<MegaCrit.Sts2.Core.Entities.Players.Player, MegaCrit.Sts2.Core.Models.CharacterModel> <>9__148_0
public static System.Func<MegaCrit.Sts2.Core.Localization.LocValidationError, System.String> <>9__165_0
public static System.Func<System.Linq.IGrouping<System.String, MegaCrit.Sts2.Core.Localization.LocValidationError>, System.String> <>9__165_1
private static .cctor()
public .ctor()
internal MegaCrit.Sts2.Core.Entities.Players.Player <StartNewMultiplayerRun>b__146_0(MegaCrit.Sts2.Core.Entities.Multiplayer.StartRunLobbyPlayer p)
internal MegaCrit.Sts2.Core.Models.ActModel <StartNewMultiplayerRun>b__146_1(MegaCrit.Sts2.Core.Models.ActModel a)
internal MegaCrit.Sts2.Core.Models.ActModel <StartNewSingleplayerRun>b__145_0(MegaCrit.Sts2.Core.Models.ActModel a)
internal MegaCrit.Sts2.Core.Models.CharacterModel <LoadRun>b__147_0(MegaCrit.Sts2.Core.Entities.Players.Player p)
internal MegaCrit.Sts2.Core.Models.CharacterModel <StartRun>b__148_0(MegaCrit.Sts2.Core.Entities.Players.Player p)
internal System.String <CheckShowLocalizationOverrideErrors>b__165_0(MegaCrit.Sts2.Core.Localization.LocValidationError e)
internal System.String <CheckShowLocalizationOverrideErrors>b__165_1(System.Linq.IGrouping<System.String, MegaCrit.Sts2.Core.Localization.LocValidationError> g)
```

## MegaCrit.Sts2.Core.Nodes.NGame+<DoCloudSync>d__122

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.NGame+<GameStartup>d__121

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.NGame <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Object <>u__2
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__3
private System.Threading.Tasks.Task <cloudSavesTask>5__2
private MegaCrit.Sts2.Core.Saves.ReadSaveResult<MegaCrit.Sts2.Core.Saves.PrefsSave> <prefsReadResult>5__4
private MegaCrit.Sts2.Core.Saves.ReadSaveResult<MegaCrit.Sts2.Core.Saves.SerializableProgress> <progressReadResult>5__3
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.NGame+<GameStartupError>d__120

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.NGame <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__2
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.NGame+<GameStartupWrapper>d__118

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.NGame <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.NGame+<GoToTimeline>d__140

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.NGame <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.NGame+<GoToTimelineAfterRun>d__137

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.NGame <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.NGame+<InitializePlatform>d__167

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.NGame <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Boolean> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__2
private System.Boolean <steamInitialized>5__2
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.NGame+<LaunchMainMenu>d__135

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.NGame <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NLogoAnimation <logoAnimation>5__2
public System.Boolean skipLogo
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.NGame+<LoadDeferredStartupAssetsAsync>d__136

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.NGame+<LoadMainMenu>d__144

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.NGame <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public System.Boolean openTimeline
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.NGame+<LoadRun>d__147

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.NGame <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.Saves.Runs.SerializableRoom preFinishedRoom
public MegaCrit.Sts2.Core.Runs.RunState runState
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.NGame+<ReturnToMainMenu>d__141

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.NGame <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.NGame+<ReturnToMainMenuAfterRun>d__138

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.NGame <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.NGame+<ReturnToMainMenuWithInternalError>d__139

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.NGame <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public System.Exception e
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.NGame+<StartNewMultiplayerRun>d__146

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.NGame <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<MegaCrit.Sts2.Core.Runs.RunState> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private MegaCrit.Sts2.Core.Runs.RunState <runState>5__2
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel> acts
public System.Int32 ascensionLevel
public System.Nullable<System.DateTimeOffset> dailyTime
public MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby lobby
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel> modifiers
public System.String seed
public System.Boolean shouldSave
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.NGame+<StartNewSingleplayerRun>d__145

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.NGame <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<MegaCrit.Sts2.Core.Runs.RunState> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private MegaCrit.Sts2.Core.Runs.RunState <runState>5__2
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel> acts
public System.Int32 ascensionLevel
public MegaCrit.Sts2.Core.Models.CharacterModel character
public System.Nullable<System.DateTimeOffset> dailyTime
public MegaCrit.Sts2.Core.Runs.GameMode gameMode
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel> modifiers
public System.String seed
public System.Boolean shouldSave
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.NGame+<StartRun>d__148

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.NGame <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private MegaCrit.Sts2.Core.Multiplayer.Game.NetLoadingHandle <loadHandle>5__2
public MegaCrit.Sts2.Core.Runs.RunState runState
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.NGame+<TryErrorInit>d__119

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.NGame <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Object <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.NGame+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Input
public static readonly Godot.StringName _Notification
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName ActivateWorldEnvironment
public static readonly Godot.StringName ApplyDisplaySettings
public static readonly Godot.StringName ApplySyncSetting
public static readonly Godot.StringName CheckShowLocalizationOverrideErrors
public static readonly Godot.StringName CheckShowModdedSaveFilePopup
public static readonly Godot.StringName ClearScreenShakeTarget
public static readonly Godot.StringName DeactivateWorldEnvironment
public static readonly Godot.StringName DebugModifyTimescale
public static readonly Godot.StringName DoHitStop
public static readonly Godot.StringName FormatBytes
public static readonly Godot.StringName GetGameVersion
public static readonly Godot.StringName GetInspectCardScreen
public static readonly Godot.StringName GetInspectRelicScreen
public static readonly Godot.StringName GetOrCreateFeedbackScreen
public static readonly Godot.StringName InitializeGraphicsPreferences
public static readonly Godot.StringName InitPools
public static readonly Godot.StringName IsGameFocusedWindow
public static readonly Godot.StringName IsMainThread
public static readonly Godot.StringName IsReleaseGame
public static readonly Godot.StringName LogResourceStats
public static readonly Godot.StringName OnFilesDropped
public static readonly Godot.StringName OnSteamNoLongerRunning
public static readonly Godot.StringName OnWindowChange
public static readonly Godot.StringName Quit
public static readonly Godot.StringName ReloadMainMenu
public static readonly Godot.StringName Relocalize
public static readonly Godot.StringName Reset
public static readonly Godot.StringName ScreenRumble
public static readonly Godot.StringName ScreenShake
public static readonly Godot.StringName ScreenShakeTrauma
public static readonly Godot.StringName SetScreenshakeMultiplier
public static readonly Godot.StringName SetScreenShakeTarget
public static readonly Godot.StringName ToggleFullscreen
public static readonly Godot.StringName ToggleTrailerMode
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.NGame+PhobiaModeToggledEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke()
```

## MegaCrit.Sts2.Core.Nodes.NGame+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _inspectionContainer
public static readonly Godot.StringName _screenShake
public static readonly Godot.StringName AudioManager
public static readonly Godot.StringName CurrentRunNode
public static readonly Godot.StringName CursorManager
public static readonly Godot.StringName DebugAudio
public static readonly Godot.StringName DebugSeedOverride
public static readonly Godot.StringName FeedbackScreen
public static readonly Godot.StringName HitStop
public static readonly Godot.StringName HotkeyManager
public static readonly Godot.StringName HoverTipsContainer
public static readonly Godot.StringName InputManager
public static readonly Godot.StringName InspectCardScreen
public static readonly Godot.StringName InspectRelicScreen
public static readonly Godot.StringName LogoAnimation
public static readonly Godot.StringName MainMenu
public static readonly Godot.StringName ReactionContainer
public static readonly Godot.StringName ReactionWheel
public static readonly Godot.StringName RemoteCursorContainer
public static readonly Godot.StringName RootSceneContainer
public static readonly Godot.StringName ScreenshakeTarget
public static readonly Godot.StringName StartOnMainMenu
public static readonly Godot.StringName TimeoutOverlay
public static readonly Godot.StringName Transition
public static readonly Godot.StringName WorldEnvironment
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.NGame+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public static readonly Godot.StringName PhobiaModeToggled
public static readonly Godot.StringName WindowChange
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.NGame+WindowChangeEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke()
```

## MegaCrit.Sts2.Core.Nodes.NMuteInBackgroundHandler

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private System.UInt64 _lastFocusOutMsec
private System.Boolean _loggedEnvironment
private Godot.Tween _tween
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private static System.Void SetMasterVolume(System.Single volume)
private System.Void Mute()
private System.Void Unmute()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Notification(System.Int32 what)
```

## MegaCrit.Sts2.Core.Nodes.NMuteInBackgroundHandler+<>O

类型属性：`NestedPrivate, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static System.Action<System.Single> <0>__SetMasterVolume
```

## MegaCrit.Sts2.Core.Nodes.NMuteInBackgroundHandler+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Notification
public static readonly Godot.StringName Mute
public static readonly Godot.StringName SetMasterVolume
public static readonly Godot.StringName Unmute
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.NMuteInBackgroundHandler+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _lastFocusOutMsec
public static readonly Godot.StringName _loggedEnvironment
public static readonly Godot.StringName _tween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.NMuteInBackgroundHandler+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.NRun

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private Godot.PackedScene _cardScene
private MegaCrit.Sts2.Core.Nodes.NSceneContainer _roomContainer
private static const System.String _scenePath = "res://scenes/run.tscn"
private MegaCrit.Sts2.addons.mega_text.MegaLabel _seedLabel
private MegaCrit.Sts2.Core.Runs.RunState _state
private Godot.Button _testButton
private MegaCrit.Sts2.Core.Nodes.CommonUi.NGlobalUi <GlobalUi>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController <RunMusicController>k__BackingField
private MegaCrit.Sts2.Core.Multiplayer.Game.PeerInput.ScreenStateTracker <ScreenStateTracker>k__BackingField
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
MegaCrit.Sts2.Core.Nodes.Rooms.NCombatRoom CombatRoom { public get; }
MegaCrit.Sts2.Core.Nodes.Rooms.NEventRoom EventRoom { public get; }
MegaCrit.Sts2.Core.Nodes.CommonUi.NGlobalUi GlobalUi { public get; private set; }
MegaCrit.Sts2.Core.Nodes.NRun Instance { public static get; }
MegaCrit.Sts2.Core.Nodes.Rooms.NMapRoom MapRoom { public get; }
MegaCrit.Sts2.Core.Nodes.Rooms.NMerchantRoom MerchantRoom { public get; }
MegaCrit.Sts2.Core.Nodes.Rooms.NRestSiteRoom RestSiteRoom { public get; }
MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController RunMusicController { public get; private set; }
MegaCrit.Sts2.Core.Multiplayer.Game.PeerInput.ScreenStateTracker ScreenStateTracker { public get; private set; }
MegaCrit.Sts2.Core.Nodes.Rooms.NTreasureRoom TreasureRoom { public get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void set_GlobalUi(MegaCrit.Sts2.Core.Nodes.CommonUi.NGlobalUi value)
private System.Void set_RunMusicController(MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController value)
private System.Void set_ScreenStateTracker(MegaCrit.Sts2.Core.Multiplayer.Game.PeerInput.ScreenStateTracker value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public MegaCrit.Sts2.Core.Multiplayer.Game.PeerInput.ScreenStateTracker get_ScreenStateTracker()
public MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController get_RunMusicController()
public MegaCrit.Sts2.Core.Nodes.CommonUi.NGlobalUi get_GlobalUi()
public MegaCrit.Sts2.Core.Nodes.Rooms.NCombatRoom get_CombatRoom()
public MegaCrit.Sts2.Core.Nodes.Rooms.NEventRoom get_EventRoom()
public MegaCrit.Sts2.Core.Nodes.Rooms.NMapRoom get_MapRoom()
public MegaCrit.Sts2.Core.Nodes.Rooms.NMerchantRoom get_MerchantRoom()
public MegaCrit.Sts2.Core.Nodes.Rooms.NRestSiteRoom get_RestSiteRoom()
public MegaCrit.Sts2.Core.Nodes.Rooms.NTreasureRoom get_TreasureRoom()
public static MegaCrit.Sts2.Core.Nodes.NRun Create(MegaCrit.Sts2.Core.Runs.RunState state)
public static MegaCrit.Sts2.Core.Nodes.NRun get_Instance()
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Void SetCurrentRoom(Godot.Control node)
public System.Void ShowGameOverScreen(MegaCrit.Sts2.Core.Saves.SerializableRun serializableRun)
public virtual System.Void _Notification(System.Int32 what)
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.NRun+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Notification
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName SetCurrentRoom
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.NRun+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _cardScene
public static readonly Godot.StringName _roomContainer
public static readonly Godot.StringName _seedLabel
public static readonly Godot.StringName _testButton
public static readonly Godot.StringName CombatRoom
public static readonly Godot.StringName EventRoom
public static readonly Godot.StringName GlobalUi
public static readonly Godot.StringName MapRoom
public static readonly Godot.StringName MerchantRoom
public static readonly Godot.StringName RestSiteRoom
public static readonly Godot.StringName RunMusicController
public static readonly Godot.StringName TreasureRoom
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.NRun+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.NSceneContainer

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private Godot.Control _currentScene
Godot.Control CurrentScene { public get; private set; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void set_CurrentScene(Godot.Control value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public Godot.Control get_CurrentScene()
public System.Void SetCurrentScene(Godot.Control node)
```

## MegaCrit.Sts2.Core.Nodes.NSceneContainer+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName SetCurrentScene
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.NSceneContainer+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _currentScene
public static readonly Godot.StringName CurrentScene
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.NSceneContainer+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.NTransition

类型属性：`Public, BeforeFieldInit`；基类：`Godot.ColorRect`。

接口：`System.IDisposable`

```text
private static const System.String _fadeTransitionPath = "res://materials/transitions/fade_transition_mat.tres"
private static const System.String _fightTransitionPath = "res://materials/transitions/fight_transition_mat.tres"
private Godot.Control _gradientTransition
private System.Single _initialGradientYPosition
private Godot.Control _simpleTransition
private System.Single _targetGradientYPosition
private static readonly Godot.StringName _threshold
private static readonly Godot.NodePath _thresholdTweenPath
private Godot.Tween _tween
private System.Boolean <InTransition>k__BackingField
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
System.Boolean InTransition { public get; private set; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void <RoomFadeIn>b__19_0()
private System.Void set_InTransition(System.Boolean value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public [async] System.Threading.Tasks.Task FadeIn(System.Single time = 0.8, System.String transitionPath = "res://materials/transitions/fade_transition_mat.tres", System.Nullable<System.Threading.CancellationToken> cancelToken = null)
public [async] System.Threading.Tasks.Task FadeOut(System.Single time = 0.8, System.String transitionPath = "res://materials/transitions/fade_transition_mat.tres", System.Nullable<System.Threading.CancellationToken> cancelToken = null)
public [async] System.Threading.Tasks.Task RoomFadeIn(System.Boolean showTransition = True)
public [async] System.Threading.Tasks.Task RoomFadeOut()
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Boolean get_InTransition()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.NTransition+<FadeIn>d__17

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.NTransition <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
private System.Double <t>5__3
private Godot.ShaderMaterial <transitionMaterial>5__2
public System.Nullable<System.Threading.CancellationToken> cancelToken
public System.Single time
public System.String transitionPath
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.NTransition+<FadeOut>d__16

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.NTransition <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
private System.Double <t>5__3
private Godot.ShaderMaterial <transitionMaterial>5__2
public System.Nullable<System.Threading.CancellationToken> cancelToken
public System.Single time
public System.String transitionPath
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.NTransition+<RoomFadeIn>d__19

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.NTransition <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
public System.Boolean showTransition
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.NTransition+<RoomFadeOut>d__18

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.NTransition <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.NTransition+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.ColorRect+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.NTransition+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.ColorRect+PropertyName`。

接口：

```text
public static readonly Godot.StringName _gradientTransition
public static readonly Godot.StringName _initialGradientYPosition
public static readonly Godot.StringName _simpleTransition
public static readonly Godot.StringName _targetGradientYPosition
public static readonly Godot.StringName _tween
public static readonly Godot.StringName InTransition
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.NTransition+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.ColorRect+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.SentryBootstrap

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _EnterTree()
```

## MegaCrit.Sts2.Core.Nodes.SentryBootstrap+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.SentryBootstrap+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.SentryBootstrap+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```
