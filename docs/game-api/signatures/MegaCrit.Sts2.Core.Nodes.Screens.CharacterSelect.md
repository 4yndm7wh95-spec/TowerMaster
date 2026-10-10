# MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.ICharacterSelectButtonDelegate

类型属性：`Public, ClassSemanticsMask, Abstract, BeforeFieldInit`；基类：`无`。

接口：

```text
MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby Lobby { public abstract get; }
public abstract MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby get_Lobby()
public abstract System.Void SelectCharacter(MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NCharacterSelectButton charSelectButton, MegaCrit.Sts2.Core.Models.CharacterModel characterModel)
```

## MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NActDropdown

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NDropdown`。

接口：`System.IDisposable`

```text
private System.Int32 _currentOptionIndex
private static readonly System.String[] _options
System.String CurrentOption { public get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private Godot.Control GetDropdownContainer()
private System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Nodes.CommonUi.NDropdownItem> GetDropdownItems()
private System.Void OnDropdownItemSelected(MegaCrit.Sts2.Core.Nodes.CommonUi.NDropdownItem item)
private System.Void PopulateOptions()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnFocus()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.String get_CurrentOption()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NActDropdown+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NDropdown+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName GetDropdownContainer
public static readonly Godot.StringName OnDropdownItemSelected
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName PopulateOptions
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NActDropdown+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NDropdown+PropertyName`。

接口：

```text
public static readonly Godot.StringName _currentOptionIndex
public static readonly Godot.StringName CurrentOption
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NActDropdown+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NDropdown+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NAscensionPanel

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private System.Boolean _arrowsVisible
private MegaCrit.Sts2.addons.mega_text.MegaLabel _ascensionLevel
private static readonly Godot.Color _blueLabelOutline
private static readonly Godot.StringName _fontOutlineTheme
private static readonly Godot.StringName _h
private Godot.ShaderMaterial _iconHsv
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _info
private MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _leftArrow
private MegaCrit.Sts2.Core.Nodes.CommonUi.NHotkeyIcon _leftTabIcon
private System.Int32 _maxAscension
private MegaCrit.Sts2.Core.Entities.UI.MultiplayerUiMode _mode
private static readonly Godot.Color _redLabelOutline
private MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _rightArrow
private MegaCrit.Sts2.Core.Nodes.CommonUi.NHotkeyIcon _rightTabIcon
private static readonly Godot.StringName _tabLeftHotkey
private static readonly Godot.StringName _tabRightHotkey
private Godot.Tween _tween
private static readonly Godot.StringName _v
private System.Int32 <Ascension>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NAscensionPanel+AscensionLevelChangedEventHandler backing_AscensionLevelChanged
System.Int32 Ascension { public get; private set; }
event MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NAscensionPanel+AscensionLevelChangedEventHandler AscensionLevelChanged
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotSignalList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void <_Ready>b__23_0(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void <_Ready>b__23_1(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void DecrementAscension()
private System.Void IncrementAscension()
private System.Void RefreshArrowVisibility()
private System.Void RefreshAscensionText()
private System.Void set_Ascension(System.Int32 value)
private System.Void SetFireBlue()
private System.Void SetFireRed()
private System.Void UpdateControllerButton()
protected System.Void EmitSignalAscensionLevelChanged()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean HasGodotClassSignal(in Godot.NativeInterop.godot_string_name signal)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RaiseGodotClassSignalCallbacks(in Godot.NativeInterop.godot_string_name signal, Godot.NativeInterop.NativeVariantPtrArgs args)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Int32 get_Ascension()
public System.Void add_AscensionLevelChanged(MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NAscensionPanel+AscensionLevelChangedEventHandler value)
public System.Void AnimIn()
public System.Void Cleanup()
public System.Void Disable()
public System.Void Initialize(MegaCrit.Sts2.Core.Entities.UI.MultiplayerUiMode mode)
public System.Void remove_AscensionLevelChanged(MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NAscensionPanel+AscensionLevelChangedEventHandler value)
public System.Void SetAscensionLevel(System.Int32 ascension)
public System.Void SetMaxAscension(System.Int32 maxAscension)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NAscensionPanel+AscensionLevelChangedEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NAscensionPanel+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AnimIn
public static readonly Godot.StringName Cleanup
public static readonly Godot.StringName DecrementAscension
public static readonly Godot.StringName Disable
public static readonly Godot.StringName IncrementAscension
public static readonly Godot.StringName Initialize
public static readonly Godot.StringName RefreshArrowVisibility
public static readonly Godot.StringName RefreshAscensionText
public static readonly Godot.StringName SetAscensionLevel
public static readonly Godot.StringName SetFireBlue
public static readonly Godot.StringName SetFireRed
public static readonly Godot.StringName SetMaxAscension
public static readonly Godot.StringName UpdateControllerButton
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NAscensionPanel+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _arrowsVisible
public static readonly Godot.StringName _ascensionLevel
public static readonly Godot.StringName _iconHsv
public static readonly Godot.StringName _info
public static readonly Godot.StringName _leftArrow
public static readonly Godot.StringName _leftTabIcon
public static readonly Godot.StringName _maxAscension
public static readonly Godot.StringName _mode
public static readonly Godot.StringName _rightArrow
public static readonly Godot.StringName _rightTabIcon
public static readonly Godot.StringName _tween
public static readonly Godot.StringName Ascension
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NAscensionPanel+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public static readonly Godot.StringName AscensionLevelChanged
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NCharacterSelectButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Models.CharacterModel _character
private Godot.Control _currentOutline
private MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.ICharacterSelectButtonDelegate _delegate
private static const System.Single _glowSpeed = 1.6
private static readonly Godot.StringName _h
private static readonly Godot.Vector2 _hoverScale
private static readonly Godot.Vector2 _hoverTipOffset
private Godot.Tween _hoverTween
private Godot.ShaderMaterial _hsv
private Godot.Tween _hsvTween
private Godot.TextureRect _icon
private Godot.TextureRect _iconAdd
private System.Boolean _isLocked
private System.Boolean _isSelected
private Godot.TextureRect _lock
private static const System.Single _notSelectedSaturation = 0.2
private static const System.Single _notSelectedValue = 0.4
private Godot.Control _outlineLocal
private Godot.Control _outlineMixed
private Godot.Control _outlineRemote
private Godot.Control _playerIconContainer
private static readonly System.String _playerIconScenePath
private static const System.Single _remotelySelectedSaturation = 0.8
private static const System.Single _remotelySelectedValue = 0.4
private readonly System.Collections.Generic.HashSet<System.UInt64> _remoteSelectedPlayers
private static readonly Godot.StringName _s
private static const System.Single _selectedSaturation = 1
private static const System.Single _selectedValue = 1.1
private Godot.Control _shadow
private MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NCharacterSelectButton+State _state
private static const System.Single _unhoverDuration = 0.5
private static readonly System.String _unlockedIconPath
private static readonly Godot.StringName _v
private System.Boolean <IsRandom>k__BackingField
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
MegaCrit.Sts2.Core.Models.CharacterModel Character { public get; }
System.Boolean IsLocked { public get; }
System.Boolean IsRandom { public get; private set; }
System.Boolean IsSelected { public get; }
System.Collections.Generic.IReadOnlyCollection<System.UInt64> RemoteSelectedPlayers { public get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Single GetSaturationForCurrentState()
private System.Single GetValueForCurrentState()
private System.Void AnimateSaturationToCurrentState(Godot.Tween tween)
private System.Void RefreshOutline()
private System.Void RefreshPlayerIcons()
private System.Void RefreshState()
private System.Void set_IsRandom(System.Boolean value)
private System.Void UpdateShaderH(System.Single value)
private System.Void UpdateShaderS(System.Single value)
private System.Void UpdateShaderV(System.Single value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnFocus()
protected virtual System.Void OnPress()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public [async] System.Threading.Tasks.Task AnimateUnlock()
public MegaCrit.Sts2.Core.Models.CharacterModel get_Character()
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Boolean get_IsLocked()
public System.Boolean get_IsRandom()
public System.Boolean get_IsSelected()
public System.Collections.Generic.IReadOnlyCollection<System.UInt64> get_RemoteSelectedPlayers()
public System.Void DebugUnlock()
public System.Void Deselect()
public System.Void Init(MegaCrit.Sts2.Core.Models.CharacterModel character, MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.ICharacterSelectButtonDelegate del)
public System.Void LockForAnimation()
public System.Void OnRemotePlayerDeselected(System.UInt64 playerId)
public System.Void OnRemotePlayerSelected(System.UInt64 playerId)
public System.Void Reset()
public System.Void Select()
public System.Void UnlockIfPossible()
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NCharacterSelectButton+<>c__DisplayClass49_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Unlocks.UnlockState unlockState
public .ctor()
internal System.Boolean <Init>b__0(MegaCrit.Sts2.Core.Models.CharacterModel c)
```

## MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NCharacterSelectButton+<AnimateUnlock>d__55

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NCharacterSelectButton <>4__this
private System.Single <>7__wrap3
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
private Godot.GpuParticles2D <chargeParticles>5__2
private Godot.Vector2 <originalLockPosition>5__3
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NCharacterSelectButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AnimateSaturationToCurrentState
public static readonly Godot.StringName DebugUnlock
public static readonly Godot.StringName Deselect
public static readonly Godot.StringName GetSaturationForCurrentState
public static readonly Godot.StringName GetValueForCurrentState
public static readonly Godot.StringName LockForAnimation
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnRemotePlayerDeselected
public static readonly Godot.StringName OnRemotePlayerSelected
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName RefreshOutline
public static readonly Godot.StringName RefreshPlayerIcons
public static readonly Godot.StringName RefreshState
public static readonly Godot.StringName Reset
public static readonly Godot.StringName Select
public static readonly Godot.StringName UnlockIfPossible
public static readonly Godot.StringName UpdateShaderH
public static readonly Godot.StringName UpdateShaderS
public static readonly Godot.StringName UpdateShaderV
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NCharacterSelectButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _currentOutline
public static readonly Godot.StringName _hoverTween
public static readonly Godot.StringName _hsv
public static readonly Godot.StringName _hsvTween
public static readonly Godot.StringName _icon
public static readonly Godot.StringName _iconAdd
public static readonly Godot.StringName _isLocked
public static readonly Godot.StringName _isSelected
public static readonly Godot.StringName _lock
public static readonly Godot.StringName _outlineLocal
public static readonly Godot.StringName _outlineMixed
public static readonly Godot.StringName _outlineRemote
public static readonly Godot.StringName _playerIconContainer
public static readonly Godot.StringName _shadow
public static readonly Godot.StringName _state
public static readonly Godot.StringName IsLocked
public static readonly Godot.StringName IsRandom
public static readonly Godot.StringName IsSelected
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NCharacterSelectButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NCharacterSelectButton+State

类型属性：`NestedPrivate, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NCharacterSelectButton+State NotSelected = 0
public static const MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NCharacterSelectButton+State SelectedLocally = 1
public static const MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NCharacterSelectButton+State SelectedRemotely = 2
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NCharacterSelectScreen

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`, `MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.IStartRunLobbyListener`, `MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.ICharacterSelectButtonDelegate`

```text
private MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NActDropdown _actDropdown
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _actDropdownLabel
private MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NAscensionPanel _ascensionPanel
private MegaCrit.Sts2.Core.Nodes.CommonUi.NBackButton _backButton
private Godot.Control _bgContainer
private Godot.Control _characterUnlockAnimationBackstop
private Godot.Control _charButtonContainer
private Godot.PackedScene _charSelectButtonScene
private System.Boolean _delayEmbarkForCharacterSelect
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _description
private MegaCrit.Sts2.Core.Nodes.CommonUi.NConfirmButton _embarkButton
private MegaCrit.Sts2.addons.mega_text.MegaLabel _gold
private MegaCrit.Sts2.addons.mega_text.MegaLabel _hp
private Godot.Control _infoPanel
private Godot.Vector2 _infoPanelPosFinalVal
private Godot.Tween _infoPanelTween
private MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby _lobby
private MegaCrit.Sts2.addons.mega_text.MegaLabel _name
private MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NCharacterSelectButton _randomCharacterButton
private Godot.Control _readyAndWaitingContainer
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _relicDescription
private Godot.TextureRect _relicIcon
private Godot.TextureRect _relicIconOutline
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _relicTitle
private MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteLobbyPlayerContainer _remotePlayerContainer
private static const System.String _sceneCharSelectButtonPath = "res://scenes/screens/char_select/char_select_button.tscn"
private static readonly System.String _scenePath
private MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NCharacterSelectButton _selectedButton
private MegaCrit.Sts2.Core.Nodes.Debug.IBootstrapSettings _settings
private MegaCrit.Sts2.Core.Nodes.CommonUi.NBackButton _unreadyButton
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
Godot.Control InitialFocusedControl { protected virtual get; }
MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby Lobby { public virtual get; }
System.Boolean ShouldShowActDropdown { private get; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task PlayUnlockCharacterAnimation(MegaCrit.Sts2.Core.Models.ModelId character)
private [async] System.Threading.Tasks.Task StartNewMultiplayerRun(System.String seed, System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ActModel> acts)
private [async] System.Threading.Tasks.Task StartNewSingleplayerRun(System.String seed, System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ActModel> acts)
private System.Boolean get_ShouldShowActDropdown()
private System.Void <OnEmbarkPressed>b__51_0()
private System.Void AfterInitialized()
private System.Void CheckForMultiplayerAscensionPopup()
private System.Void CleanUpLobby(System.Boolean disconnectSession, MegaCrit.Sts2.Core.Entities.Multiplayer.NetError error = 1)
private System.Void DebugUnlockAllCharacters()
private System.Void InitCharacterButtons()
private System.Void OnAscensionPanelLevelChanged()
private System.Void OnEmbarkPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OnLocalCharacterChangedForRandom(MegaCrit.Sts2.Core.Models.CharacterModel characterModel)
private System.Void OnUnreadyPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void RefreshButtonSelectionForPlayer(MegaCrit.Sts2.Core.Entities.Multiplayer.StartRunLobbyPlayer player)
private System.Void RemoteClientFailedToConnectToLocalHost(System.UInt64 sender, MegaCrit.Sts2.Core.Entities.Multiplayer.NetErrorInfo info)
private System.Void UpdateRandomCharacterVisibility()
private System.Void UpdateRichPresence()
protected virtual Godot.Control get_InitialFocusedControl()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NCharacterSelectScreen Create()
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

## MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NCharacterSelectScreen+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NCharacterSelectScreen+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NCharacterSelectButton, System.Boolean> <>9__42_0
public static System.Func<MegaCrit.Sts2.Core.Entities.Multiplayer.StartRunLobbyPlayer, MegaCrit.Sts2.Core.Entities.Players.Player> <>9__56_0
public static System.Func<MegaCrit.Sts2.Core.Models.ActModel, MegaCrit.Sts2.Core.Models.ActModel> <>9__56_1
public static System.Func<MegaCrit.Sts2.Core.Entities.Players.Player, MegaCrit.Sts2.Core.Models.CharacterModel> <>9__56_2
public static System.Func<MegaCrit.Sts2.Core.Entities.Multiplayer.StartRunLobbyPlayer, System.UInt64> <>9__72_0
private static .cctor()
public .ctor()
internal MegaCrit.Sts2.Core.Entities.Players.Player <StartNewMultiplayerRun>b__56_0(MegaCrit.Sts2.Core.Entities.Multiplayer.StartRunLobbyPlayer p)
internal MegaCrit.Sts2.Core.Models.ActModel <StartNewMultiplayerRun>b__56_1(MegaCrit.Sts2.Core.Models.ActModel a)
internal MegaCrit.Sts2.Core.Models.CharacterModel <StartNewMultiplayerRun>b__56_2(MegaCrit.Sts2.Core.Entities.Players.Player p)
internal System.Boolean <InitCharacterButtons>b__42_0(MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NCharacterSelectButton c)
internal System.UInt64 <AfterInitialized>b__72_0(MegaCrit.Sts2.Core.Entities.Multiplayer.StartRunLobbyPlayer p)
```

## MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NCharacterSelectScreen+<PlayUnlockCharacterAnimation>d__47

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NCharacterSelectScreen <>4__this
private System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NCharacterSelectButton> <>7__wrap1
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
private MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NCharacterSelectButton <button>5__3
public MegaCrit.Sts2.Core.Models.ModelId character
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NCharacterSelectScreen+<StartNewMultiplayerRun>d__56

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NCharacterSelectScreen <>4__this
private System.Object <>7__wrap3
private System.Int32 <>7__wrap4
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Rooms.AbstractRoom> <>u__2
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Runs.RunState> <>u__3
private MegaCrit.Sts2.Core.Multiplayer.Game.NetLoadingHandle <loadHandle>5__2
private MegaCrit.Sts2.Core.Runs.RunState <runState>5__3
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ActModel> acts
public System.String seed
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NCharacterSelectScreen+<StartNewSingleplayerRun>d__55

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NCharacterSelectScreen <>4__this
private System.Object <>7__wrap2
private System.Int32 <>7__wrap3
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Runs.RunState> <>u__2
private System.Int32 <ascensionToEmbark>5__2
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ActModel> acts
public System.String seed
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NCharacterSelectScreen+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+MethodName`。

接口：

```text
public static readonly Godot.StringName _Input
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AfterInitialized
public static readonly Godot.StringName AscensionChanged
public static readonly Godot.StringName CheckForMultiplayerAscensionPopup
public static readonly Godot.StringName CleanUpLobby
public static readonly Godot.StringName Create
public static readonly Godot.StringName DebugUnlockAllCharacters
public static readonly Godot.StringName InitCharacterButtons
public static readonly Godot.StringName InitializeSingleplayer
public static readonly Godot.StringName MaxAscensionChanged
public static readonly Godot.StringName ModifiersChanged
public static readonly Godot.StringName OnAscensionPanelLevelChanged
public static readonly Godot.StringName OnEmbarkPressed
public static readonly Godot.StringName OnSubmenuClosed
public static readonly Godot.StringName OnSubmenuOpened
public static readonly Godot.StringName OnUnreadyPressed
public static readonly Godot.StringName SeedChanged
public static readonly Godot.StringName UpdateRandomCharacterVisibility
public static readonly Godot.StringName UpdateRichPresence
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NCharacterSelectScreen+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+PropertyName`。

接口：

```text
public static readonly Godot.StringName _actDropdown
public static readonly Godot.StringName _actDropdownLabel
public static readonly Godot.StringName _ascensionPanel
public static readonly Godot.StringName _backButton
public static readonly Godot.StringName _bgContainer
public static readonly Godot.StringName _characterUnlockAnimationBackstop
public static readonly Godot.StringName _charButtonContainer
public static readonly Godot.StringName _charSelectButtonScene
public static readonly Godot.StringName _delayEmbarkForCharacterSelect
public static readonly Godot.StringName _description
public static readonly Godot.StringName _embarkButton
public static readonly Godot.StringName _gold
public static readonly Godot.StringName _hp
public static readonly Godot.StringName _infoPanel
public static readonly Godot.StringName _infoPanelPosFinalVal
public static readonly Godot.StringName _infoPanelTween
public static readonly Godot.StringName _name
public static readonly Godot.StringName _randomCharacterButton
public static readonly Godot.StringName _readyAndWaitingContainer
public static readonly Godot.StringName _relicDescription
public static readonly Godot.StringName _relicIcon
public static readonly Godot.StringName _relicIconOutline
public static readonly Godot.StringName _relicTitle
public static readonly Godot.StringName _remotePlayerContainer
public static readonly Godot.StringName _selectedButton
public static readonly Godot.StringName _unreadyButton
public static readonly Godot.StringName InitialFocusedControl
public static readonly Godot.StringName ShouldShowActDropdown
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NCharacterSelectScreen+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NCharacterSelectScreenBg

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private static readonly System.Single _defaultBgScale
private static const System.Single _fourByThree = 1.3333334
private static readonly System.Single _narrowBgScale
private static const System.Single _sixteenByNine = 1.7777778
private Godot.Window _window
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnWindowChange()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NCharacterSelectScreenBg+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnWindowChange
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NCharacterSelectScreenBg+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _window
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NCharacterSelectScreenBg+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NMultiplayerLoadGameScreen

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`, `MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.ILoadRunLobbyListener`

```text
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _actLabel
private MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NAscensionPanel _ascensionPanel
private MegaCrit.Sts2.Core.Nodes.CommonUi.NBackButton _backButton
private Godot.Control _bgContainer
private MegaCrit.Sts2.Core.Nodes.CommonUi.NConfirmButton _confirmButton
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _floorLabel
private MegaCrit.Sts2.addons.mega_text.MegaLabel _gold
private MegaCrit.Sts2.addons.mega_text.MegaLabel _hp
private Godot.Control _infoPanel
private Godot.Vector2 _infoPanelPosFinalVal
private Godot.Tween _infoPanelTween
private MegaCrit.Sts2.addons.mega_text.MegaLabel _name
private MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteLoadLobbyPlayerContainer _remotePlayerContainer
private MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.LoadRunLobby _runLobby
private static const System.String _sceneCharSelectButtonPath = "res://scenes/screens/char_select/char_select_button.tscn"
private static readonly System.String _scenePath
private MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NCharacterSelectButton _selectedButton
private MegaCrit.Sts2.Core.Nodes.CommonUi.NBackButton _unreadyButton
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
Godot.Control InitialFocusedControl { protected virtual get; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task StartRun()
private System.Boolean <AfterMultiplayerStarted>b__41_0(MegaCrit.Sts2.Core.Saves.Runs.SerializablePlayer p)
private System.Boolean <StartRun>b__34_0(MegaCrit.Sts2.Core.Saves.Runs.SerializablePlayer p)
private System.Void AfterMultiplayerStarted()
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
public static MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NMultiplayerLoadGameScreen Create()
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

## MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NMultiplayerLoadGameScreen+<ShouldAllowRunToBegin>d__33

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NMultiplayerLoadGameScreen <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Boolean> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NMultiplayerLoadGameScreen+<StartRun>d__34

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NMultiplayerLoadGameScreen <>4__this
private System.Object <>7__wrap1
private System.Int32 <>7__wrap2
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private MegaCrit.Sts2.Core.Runs.RunState <runState>5__4
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NMultiplayerLoadGameScreen+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+MethodName`。

接口：

```text
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AfterMultiplayerStarted
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

## MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NMultiplayerLoadGameScreen+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+PropertyName`。

接口：

```text
public static readonly Godot.StringName _actLabel
public static readonly Godot.StringName _ascensionPanel
public static readonly Godot.StringName _backButton
public static readonly Godot.StringName _bgContainer
public static readonly Godot.StringName _confirmButton
public static readonly Godot.StringName _floorLabel
public static readonly Godot.StringName _gold
public static readonly Godot.StringName _hp
public static readonly Godot.StringName _infoPanel
public static readonly Godot.StringName _infoPanelPosFinalVal
public static readonly Godot.StringName _infoPanelTween
public static readonly Godot.StringName _name
public static readonly Godot.StringName _remotePlayerContainer
public static readonly Godot.StringName _selectedButton
public static readonly Godot.StringName _unreadyButton
public static readonly Godot.StringName InitialFocusedControl
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NMultiplayerLoadGameScreen+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NRegentCharacterSelectBg

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private Godot.Control _amogusHover
private Godot.Control _cultistHover
private Godot.Control _decaHover
private Godot.Control _sentryHover
private Godot.Control _shapesHover
private Godot.Control _sneckoHover
private Godot.Control _sphereGuardianHover
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _spineController
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void <_Ready>b__8_0()
private System.Void <_Ready>b__8_1()
private System.Void <_Ready>b__8_10()
private System.Void <_Ready>b__8_11()
private System.Void <_Ready>b__8_12()
private System.Void <_Ready>b__8_13()
private System.Void <_Ready>b__8_2()
private System.Void <_Ready>b__8_3()
private System.Void <_Ready>b__8_4()
private System.Void <_Ready>b__8_5()
private System.Void <_Ready>b__8_6()
private System.Void <_Ready>b__8_7()
private System.Void <_Ready>b__8_8()
private System.Void <_Ready>b__8_9()
private System.Void SetSkin(System.String skinName)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NRegentCharacterSelectBg+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName SetSkin
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NRegentCharacterSelectBg+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _amogusHover
public static readonly Godot.StringName _cultistHover
public static readonly Godot.StringName _decaHover
public static readonly Godot.StringName _sentryHover
public static readonly Godot.StringName _shapesHover
public static readonly Godot.StringName _sneckoHover
public static readonly Godot.StringName _sphereGuardianHover
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NRegentCharacterSelectBg+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```
