# MegaCrit.Sts2.Core.Nodes.Screens.CustomRun

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.Screens.CustomRun.NCustomRunLoadScreen

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`, `MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.ILoadRunLobbyListener`

```text
private MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NAscensionPanel _ascensionPanel
private MegaCrit.Sts2.Core.Nodes.CommonUi.NBackButton _backButton
private MegaCrit.Sts2.Core.Nodes.CommonUi.NConfirmButton _confirmButton
private MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.LoadRunLobby _lobby
private MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NCustomRunModifiersList _modifiersList
private Godot.Control _readyAndWaitingContainer
private MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteLoadLobbyPlayerContainer _remotePlayerContainer
private static readonly System.String _scenePath
private Godot.LineEdit _seedInput
private MegaCrit.Sts2.Core.Nodes.CommonUi.NBackButton _unreadyButton
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
Godot.Control InitialFocusedControl { protected virtual get; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task StartRun()
private System.Boolean <StartRun>b__27_0(MegaCrit.Sts2.Core.Saves.Runs.SerializablePlayer p)
private System.Void AfterInitialized()
private System.Void CleanUpLobby(System.Boolean disconnectSession, MegaCrit.Sts2.Core.Entities.Multiplayer.NetError error = 1)
private System.Void OnEmbarkPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OnUnreadyPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void RemoteClientFailedToConnectToLocalHost(System.UInt64 sender, MegaCrit.Sts2.Core.Entities.Multiplayer.NetErrorInfo info)
private System.Void UpdateRichPresence()
protected virtual Godot.Control get_InitialFocusedControl()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.CustomRun.NCustomRunLoadScreen Create()
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Void InitializeAsClient(MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService gameService, MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.ClientLoadJoinResponseMessage message)
public System.Void InitializeAsHost(MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService gameService, MegaCrit.Sts2.Core.Saves.SerializableRun run)
public virtual [async] System.Threading.Tasks.Task<System.Boolean> ShouldAllowRunToBegin()
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
public virtual System.Void BeginRun()
public virtual System.Void LocalPlayerDisconnected(MegaCrit.Sts2.Core.Entities.Multiplayer.NetErrorInfo info)
public virtual System.Void OnSubmenuClosed()
public virtual System.Void OnSubmenuOpened()
public virtual System.Void PlayerConnected(MegaCrit.Sts2.Core.Entities.Multiplayer.LoadRunLobbyPlayer player)
public virtual System.Void PlayerReadyChanged(System.UInt64 playerId)
public virtual System.Void RemotePlayerDisconnected(System.UInt64 playerId)
```

## MegaCrit.Sts2.Core.Nodes.Screens.CustomRun.NCustomRunLoadScreen+<>O

类型属性：`NestedPrivate, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static System.Func<MegaCrit.Sts2.Core.Saves.Runs.SerializableModifier, MegaCrit.Sts2.Core.Models.ModifierModel> <0>__FromSerializable
```

## MegaCrit.Sts2.Core.Nodes.Screens.CustomRun.NCustomRunLoadScreen+<ShouldAllowRunToBegin>d__26

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.CustomRun.NCustomRunLoadScreen <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Boolean> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.CustomRun.NCustomRunLoadScreen+<StartRun>d__27

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.CustomRun.NCustomRunLoadScreen <>4__this
private System.Object <>7__wrap1
private System.Int32 <>7__wrap2
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private MegaCrit.Sts2.Core.Runs.RunState <runState>5__4
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.CustomRun.NCustomRunLoadScreen+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+MethodName`。

接口：

```text
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AfterInitialized
public static readonly Godot.StringName BeginRun
public static readonly Godot.StringName CleanUpLobby
public static readonly Godot.StringName Create
public static readonly Godot.StringName OnEmbarkPressed
public static readonly Godot.StringName OnSubmenuClosed
public static readonly Godot.StringName OnSubmenuOpened
public static readonly Godot.StringName OnUnreadyPressed
public static readonly Godot.StringName PlayerReadyChanged
public static readonly Godot.StringName RemotePlayerDisconnected
public static readonly Godot.StringName UpdateRichPresence
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CustomRun.NCustomRunLoadScreen+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+PropertyName`。

接口：

```text
public static readonly Godot.StringName _ascensionPanel
public static readonly Godot.StringName _backButton
public static readonly Godot.StringName _confirmButton
public static readonly Godot.StringName _modifiersList
public static readonly Godot.StringName _readyAndWaitingContainer
public static readonly Godot.StringName _remotePlayerContainer
public static readonly Godot.StringName _seedInput
public static readonly Godot.StringName _unreadyButton
public static readonly Godot.StringName InitialFocusedControl
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CustomRun.NCustomRunLoadScreen+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CustomRun.NCustomRunRandomizeButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _label
private static readonly Godot.StringName _s
private Godot.ShaderMaterial _shaderMaterial
private static readonly Godot.StringName _v
System.String[] Hotkeys { protected virtual get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.String[] get_Hotkeys()
protected virtual System.Void OnDisable()
protected virtual System.Void OnEnable()
protected virtual System.Void OnFocus()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CustomRun.NCustomRunRandomizeButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnDisable
public static readonly Godot.StringName OnEnable
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnUnfocus
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CustomRun.NCustomRunRandomizeButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _label
public static readonly Godot.StringName _shaderMaterial
public static readonly Godot.StringName Hotkeys
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CustomRun.NCustomRunRandomizeButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CustomRun.NCustomRunScreen

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`, `MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.IStartRunLobbyListener`, `MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.ICharacterSelectButtonDelegate`

```text
private MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NAscensionPanel _ascensionPanel
private MegaCrit.Sts2.Core.Nodes.CommonUi.NBackButton _backButton
private Godot.Control _charButtonContainer
private MegaCrit.Sts2.Core.Nodes.CommonUi.NConfirmButton _confirmButton
private MegaCrit.Sts2.addons.mega_text.MegaLabel _disclaimer
private MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby _lobby
private MegaCrit.Sts2.Core.Nodes.CommonUi.NHotkeyIcon _modifiersHotkeyIcon
private MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NCustomRunModifiersList _modifiersList
private MegaCrit.Sts2.Core.Nodes.Screens.CustomRun.NCustomRunRandomizeButton _randomizeButton
private Godot.Control _readyAndWaitingContainer
private MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteLobbyPlayerContainer _remotePlayerContainer
private static const System.String _sceneCharSelectButtonPath = "res://scenes/screens/char_select/char_select_button.tscn"
private static readonly System.String _scenePath
private Godot.LineEdit _seedInput
private MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NCharacterSelectButton _selectedButton
private MegaCrit.Sts2.Core.Entities.UI.MultiplayerUiMode _uiMode
private MegaCrit.Sts2.Core.Nodes.CommonUi.NBackButton _unreadyButton
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
Godot.Control InitialFocusedControl { protected virtual get; }
MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby Lobby { public virtual get; }
System.String ModifiersHotkey { private get; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task StartNewMultiplayerRun(System.String seed, System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ActModel> acts, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel> modifiers)
private [async] System.Threading.Tasks.Task StartNewSingleplayerRun(System.String seed, System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ActModel> acts, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel> modifiers)
private System.String get_ModifiersHotkey()
private System.String GetModifiersString()
private System.Void AfterInitialized()
private System.Void CleanUpLobby(System.Boolean disconnectSession, MegaCrit.Sts2.Core.Entities.Multiplayer.NetError error = 1)
private System.Void DebugUnlockAllCharacters()
private System.Void InitCharacterButtons()
private System.Void OnAscensionPanelLevelChanged()
private System.Void OnEmbarkPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OnModifiersListChanged()
private System.Void OnRandomizePressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OnSeedInputSubmitted(System.String newText)
private System.Void OnUnreadyPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void RandomizeLocalCharacter()
private System.Void RefreshButtonSelectionForPlayer(MegaCrit.Sts2.Core.Entities.Multiplayer.StartRunLobbyPlayer player)
private System.Void RemoteClientFailedToConnectToLocalHost(System.UInt64 sender, MegaCrit.Sts2.Core.Entities.Multiplayer.NetErrorInfo info)
private System.Void TryFocusOnModifiersList()
private System.Void UpdateControllerButton()
private System.Void UpdateRichPresence()
protected virtual Godot.Control get_InitialFocusedControl()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.CustomRun.NCustomRunScreen Create()
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Void InitializeMultiplayerAsClient(MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService gameService, MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.ClientLobbyJoinResponseMessage message)
public System.Void InitializeMultiplayerAsHost(MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService gameService, System.Int32 maxPlayers)
public System.Void InitializeSingleplayer()
public virtual MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby get_Lobby()
public virtual System.Void _Input(Godot.InputEvent inputEvent)
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
public virtual System.Void AscensionChanged()
public virtual System.Void BeginRun(System.String seed, System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ActModel> acts, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel> modifiers)
public virtual System.Void LocalPlayerDisconnected(MegaCrit.Sts2.Core.Entities.Multiplayer.NetErrorInfo info)
public virtual System.Void MaxAscensionChanged()
public virtual System.Void ModifiersChanged()
public virtual System.Void OnSubmenuClosed()
public virtual System.Void OnSubmenuOpened()
public virtual System.Void PlayerChanged(MegaCrit.Sts2.Core.Entities.Multiplayer.StartRunLobbyPlayer player, System.Boolean isRandomCharacterResolution)
public virtual System.Void PlayerConnected(MegaCrit.Sts2.Core.Entities.Multiplayer.StartRunLobbyPlayer player)
public virtual System.Void RemotePlayerDisconnected(MegaCrit.Sts2.Core.Entities.Multiplayer.StartRunLobbyPlayer player)
public virtual System.Void SeedChanged()
public virtual System.Void SelectCharacter(MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NCharacterSelectButton charSelectButton, MegaCrit.Sts2.Core.Models.CharacterModel characterModel)
```

## MegaCrit.Sts2.Core.Nodes.Screens.CustomRun.NCustomRunScreen+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Screens.CustomRun.NCustomRunScreen+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Entities.Multiplayer.StartRunLobbyPlayer, MegaCrit.Sts2.Core.Models.CharacterModel> <>9__36_0
public static System.Func<MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NCharacterSelectButton, System.Boolean> <>9__37_0
public static System.Func<MegaCrit.Sts2.Core.Models.ModifierModel, MegaCrit.Sts2.Core.Models.ModelId> <>9__46_0
public static System.Func<MegaCrit.Sts2.Core.Entities.Multiplayer.StartRunLobbyPlayer, System.UInt64> <>9__60_0
private static .cctor()
public .ctor()
internal MegaCrit.Sts2.Core.Models.CharacterModel <OnRandomizePressed>b__36_0(MegaCrit.Sts2.Core.Entities.Multiplayer.StartRunLobbyPlayer p)
internal MegaCrit.Sts2.Core.Models.ModelId <GetModifiersString>b__46_0(MegaCrit.Sts2.Core.Models.ModifierModel m)
internal System.Boolean <RandomizeLocalCharacter>b__37_0(MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NCharacterSelectButton b)
internal System.UInt64 <AfterInitialized>b__60_0(MegaCrit.Sts2.Core.Entities.Multiplayer.StartRunLobbyPlayer p)
```

## MegaCrit.Sts2.Core.Nodes.Screens.CustomRun.NCustomRunScreen+<StartNewMultiplayerRun>d__45

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.CustomRun.NCustomRunScreen <>4__this
private System.Object <>7__wrap1
private System.Int32 <>7__wrap2
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Runs.RunState> <>u__2
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ActModel> acts
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel> modifiers
public System.String seed
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.CustomRun.NCustomRunScreen+<StartNewSingleplayerRun>d__44

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.CustomRun.NCustomRunScreen <>4__this
private System.Object <>7__wrap1
private System.Int32 <>7__wrap2
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Runs.RunState> <>u__2
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ActModel> acts
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel> modifiers
public System.String seed
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.CustomRun.NCustomRunScreen+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+MethodName`。

接口：

```text
public static readonly Godot.StringName _Input
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AfterInitialized
public static readonly Godot.StringName AscensionChanged
public static readonly Godot.StringName CleanUpLobby
public static readonly Godot.StringName Create
public static readonly Godot.StringName DebugUnlockAllCharacters
public static readonly Godot.StringName GetModifiersString
public static readonly Godot.StringName InitCharacterButtons
public static readonly Godot.StringName InitializeSingleplayer
public static readonly Godot.StringName MaxAscensionChanged
public static readonly Godot.StringName ModifiersChanged
public static readonly Godot.StringName OnAscensionPanelLevelChanged
public static readonly Godot.StringName OnEmbarkPressed
public static readonly Godot.StringName OnModifiersListChanged
public static readonly Godot.StringName OnRandomizePressed
public static readonly Godot.StringName OnSeedInputSubmitted
public static readonly Godot.StringName OnSubmenuClosed
public static readonly Godot.StringName OnSubmenuOpened
public static readonly Godot.StringName OnUnreadyPressed
public static readonly Godot.StringName RandomizeLocalCharacter
public static readonly Godot.StringName SeedChanged
public static readonly Godot.StringName TryFocusOnModifiersList
public static readonly Godot.StringName UpdateControllerButton
public static readonly Godot.StringName UpdateRichPresence
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CustomRun.NCustomRunScreen+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+PropertyName`。

接口：

```text
public static readonly Godot.StringName _ascensionPanel
public static readonly Godot.StringName _backButton
public static readonly Godot.StringName _charButtonContainer
public static readonly Godot.StringName _confirmButton
public static readonly Godot.StringName _disclaimer
public static readonly Godot.StringName _modifiersHotkeyIcon
public static readonly Godot.StringName _modifiersList
public static readonly Godot.StringName _randomizeButton
public static readonly Godot.StringName _readyAndWaitingContainer
public static readonly Godot.StringName _remotePlayerContainer
public static readonly Godot.StringName _seedInput
public static readonly Godot.StringName _selectedButton
public static readonly Godot.StringName _uiMode
public static readonly Godot.StringName _unreadyButton
public static readonly Godot.StringName InitialFocusedControl
public static readonly Godot.StringName ModifiersHotkey
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CustomRun.NCustomRunScreen+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CustomRun.NRunModifierTickbox

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox`。

接口：`System.IDisposable`

```text
private static readonly MegaCrit.Sts2.Core.Localization.LocString _descriptionLoc
private Godot.Control _highlight
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _label
private MegaCrit.Sts2.Core.Models.ModifierModel <Modifier>k__BackingField
public static const System.String scenePath = "res://scenes/screens/custom_run/modifier_tickbox.tscn"
MegaCrit.Sts2.Core.Models.ModifierModel Modifier { public get; private set; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Boolean <_Ready>b__11_0(MegaCrit.Sts2.Core.Models.ModifierModel m)
private System.Boolean <_Ready>b__11_1(MegaCrit.Sts2.Core.Models.ModifierModel m)
private System.Void set_Modifier(MegaCrit.Sts2.Core.Models.ModifierModel value)
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
public MegaCrit.Sts2.Core.Models.ModifierModel get_Modifier()
public static MegaCrit.Sts2.Core.Nodes.Screens.CustomRun.NRunModifierTickbox Create(MegaCrit.Sts2.Core.Models.ModifierModel model)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CustomRun.NRunModifierTickbox+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnDisable
public static readonly Godot.StringName OnEnable
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnUnfocus
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CustomRun.NRunModifierTickbox+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox+PropertyName`。

接口：

```text
public static readonly Godot.StringName _highlight
public static readonly Godot.StringName _label
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CustomRun.NRunModifierTickbox+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox+SignalName`。

接口：

```text
public .ctor()
```
