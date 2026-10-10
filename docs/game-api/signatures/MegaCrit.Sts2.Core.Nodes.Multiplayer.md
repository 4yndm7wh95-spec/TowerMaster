# MegaCrit.Sts2.Core.Nodes.Multiplayer

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NGenericPopup

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private System.Threading.Tasks.TaskCompletionSource<System.Boolean> _confirmationCompletionSource
private static readonly System.String _scenePath
private System.UInt64 _steamId
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
public static MegaCrit.Sts2.Core.Nodes.Multiplayer.NGenericPopup Create()
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Threading.Tasks.Task<System.Boolean> WaitForConfirmation(MegaCrit.Sts2.Core.Localization.LocString body, MegaCrit.Sts2.Core.Localization.LocString header, MegaCrit.Sts2.Core.Localization.LocString noButton, MegaCrit.Sts2.Core.Localization.LocString yesButton)
public virtual Godot.Control get_DefaultFocusedControl()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NGenericPopup+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName Create
public static readonly Godot.StringName OnNoButtonPressed
public static readonly Godot.StringName OnYesButtonPressed
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NGenericPopup+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _steamId
public static readonly Godot.StringName _verticalPopup
public static readonly Godot.StringName DefaultFocusedControl
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NGenericPopup+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NInvitePlayersButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private Godot.Control _container
private static readonly Godot.StringName _s
private Godot.ShaderMaterial _shaderMaterial
private MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby _startRunLobby
private static readonly Godot.StringName _v
System.String[] Hotkeys { protected virtual get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void UpdateVisibility()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.String[] get_Hotkeys()
protected virtual System.Void OnFocus()
protected virtual System.Void OnRelease()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void Cleanup()
public System.Void Initialize(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby lobby)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NInvitePlayersButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Cleanup
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName UpdateVisibility
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NInvitePlayersButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _container
public static readonly Godot.StringName _shaderMaterial
public static readonly Godot.StringName Hotkeys
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NInvitePlayersButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerCardIntent

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Models.CardModel _card
private MegaCrit.Sts2.Core.Nodes.Cards.NCard _cardNode
MegaCrit.Sts2.Core.Models.CardModel Card { public get; public set; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public MegaCrit.Sts2.Core.Models.CardModel get_Card()
public System.Void set_Card(MegaCrit.Sts2.Core.Models.CardModel value)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerCardIntent+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerCardIntent+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _cardNode
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerCardIntent+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerNetworkProblemIndicator

类型属性：`Public, BeforeFieldInit`；基类：`Godot.TextureRect`。

接口：`System.IDisposable`

```text
private System.UInt64 _peerId
private static const System.Single _qualityScoreToShowAt = 350
private Godot.Tween _tween
private System.Boolean <IsShown>k__BackingField
System.Boolean IsShown { public get; private set; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task UpdateLoop()
private System.Void set_IsShown(System.Boolean value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Boolean get_IsShown()
public System.Void Initialize(System.UInt64 peerId)
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerNetworkProblemIndicator+<UpdateLoop>d__8

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerNetworkProblemIndicator <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerNetworkProblemIndicator+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.TextureRect+MethodName`。

接口：

```text
public static readonly Godot.StringName Initialize
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerNetworkProblemIndicator+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.TextureRect+PropertyName`。

接口：

```text
public static readonly Godot.StringName _peerId
public static readonly Godot.StringName _tween
public static readonly Godot.StringName IsShown
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerNetworkProblemIndicator+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.TextureRect+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerExpandedState

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.Capstones.ICapstoneScreen`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private MegaCrit.Sts2.Core.Nodes.CommonUi.NBackButton _backButton
private Godot.Control _cardContainer
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.CardModel> _cards
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _cardsHeader
private MegaCrit.Sts2.Core.Entities.Players.Player _player
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _playerNameLabel
private Godot.Control _potionContainer
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _potionsHeader
private Godot.Control _relicContainer
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _relicsHeader
private static readonly System.String _scenePath
Godot.Control DefaultFocusedControl { public virtual get; }
MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType ScreenType { public virtual get; }
System.Boolean UseSharedBackstop { public virtual get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void BackButtonPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OnRelicClicked(MegaCrit.Sts2.Core.Nodes.Relics.NRelic node)
private System.Void OnRelicHolderReleased(MegaCrit.Sts2.Core.Nodes.Relics.NRelicBasicHolder holder)
private System.Void ShowEntry(MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NDeckHistoryEntry entry)
private System.Void UpdateNavigation()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerExpandedState Create(MegaCrit.Sts2.Core.Entities.Players.Player player)
public virtual Godot.Control get_DefaultFocusedControl()
public virtual MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType get_ScreenType()
public virtual System.Boolean get_UseSharedBackstop()
public virtual System.Void _Input(Godot.InputEvent inputEvent)
public virtual System.Void _Ready()
public virtual System.Void AfterCapstoneClosed()
public virtual System.Void AfterCapstoneOpened()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerExpandedState+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerExpandedState+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerExpandedState+CardGroupKey> <>9__19_0
private static .cctor()
public .ctor()
internal MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerExpandedState+CardGroupKey <_Ready>b__19_0(MegaCrit.Sts2.Core.Models.CardModel x)
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerExpandedState+CardGroupKey

类型属性：`NestedPrivate, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private readonly MegaCrit.Sts2.Core.Models.CardModel _card
public .ctor(MegaCrit.Sts2.Core.Models.CardModel card)
public virtual System.Boolean Equals(System.Object obj)
public virtual System.Int32 GetHashCode()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerExpandedState+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Input
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AfterCapstoneClosed
public static readonly Godot.StringName AfterCapstoneOpened
public static readonly Godot.StringName BackButtonPressed
public static readonly Godot.StringName OnRelicClicked
public static readonly Godot.StringName OnRelicHolderReleased
public static readonly Godot.StringName ShowEntry
public static readonly Godot.StringName UpdateNavigation
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerExpandedState+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _backButton
public static readonly Godot.StringName _cardContainer
public static readonly Godot.StringName _cardsHeader
public static readonly Godot.StringName _playerNameLabel
public static readonly Godot.StringName _potionContainer
public static readonly Godot.StringName _potionsHeader
public static readonly Godot.StringName _relicContainer
public static readonly Godot.StringName _relicsHeader
public static readonly Godot.StringName DefaultFocusedControl
public static readonly Godot.StringName ScreenType
public static readonly Godot.StringName UseSharedBackstop
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerExpandedState+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerIntentHandler

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Nodes.Cards.NCard _cardInPlayAwaitingPlayerChoice
private MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerCardIntent _cardIntent
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _cardThinkyDots
private MegaCrit.Sts2.Core.Models.AbstractModel _displayedModel
private Godot.Control _hitbox
private MegaCrit.Sts2.Core.Nodes.HoverTips.NHoverTipSet _hoverTips
private System.Boolean _isInPlayerChoice
private MegaCrit.Sts2.Core.Entities.Players.Player _player
private MegaCrit.Sts2.Core.Nodes.Potions.NPotion _potionIntent
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _potionThinkyDots
private MegaCrit.Sts2.Core.Nodes.Combat.NPower _powerIntent
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _powerThinkyDots
private MegaCrit.Sts2.Core.Nodes.Relics.NRelic _relicIntent
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _relicThinkyDots
private static const System.String _scenePath = "combat/multiplayer_player_intent"
private System.Boolean _shouldShowHoverTip
private MegaCrit.Sts2.Core.Nodes.Combat.NRemoteTargetingIndicator _targetingIndicator
private Godot.Tween _tween
MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerCardIntent CardIntent { public get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void BeforeActionExecuted(MegaCrit.Sts2.Core.GameActions.GameAction action)
private System.Void BeforeActionPausedForPlayerChoice(MegaCrit.Sts2.Core.GameActions.GameAction action)
private System.Void BeforeActionReadyToResumeAfterPlayerChoice(MegaCrit.Sts2.Core.GameActions.GameAction action)
private System.Void HideThinkyDots()
private System.Void OnActionEnqueued(MegaCrit.Sts2.Core.GameActions.GameAction action)
private System.Void OnHitboxEntered()
private System.Void OnHitboxExited()
private System.Void OnHoverChanged(System.UInt64 playerId)
private System.Void OnPeerInputStateChanged(System.UInt64 playerId)
private System.Void OnPeerInputStateRemoved(System.UInt64 playerId)
private System.Void RefreshHoverDisplay()
private System.Void RefreshHoverTips()
private System.Void UnsubscribeFromAction(MegaCrit.Sts2.Core.GameActions.GameAction action)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerCardIntent get_CardIntent()
public static MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerIntentHandler Create(MegaCrit.Sts2.Core.Entities.Players.Player player)
public virtual System.Void _ExitTree()
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerIntentHandler+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName HideThinkyDots
public static readonly Godot.StringName OnHitboxEntered
public static readonly Godot.StringName OnHitboxExited
public static readonly Godot.StringName OnHoverChanged
public static readonly Godot.StringName OnPeerInputStateChanged
public static readonly Godot.StringName OnPeerInputStateRemoved
public static readonly Godot.StringName RefreshHoverDisplay
public static readonly Godot.StringName RefreshHoverTips
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerIntentHandler+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _cardInPlayAwaitingPlayerChoice
public static readonly Godot.StringName _cardIntent
public static readonly Godot.StringName _cardThinkyDots
public static readonly Godot.StringName _hitbox
public static readonly Godot.StringName _hoverTips
public static readonly Godot.StringName _isInPlayerChoice
public static readonly Godot.StringName _potionIntent
public static readonly Godot.StringName _potionThinkyDots
public static readonly Godot.StringName _powerIntent
public static readonly Godot.StringName _powerThinkyDots
public static readonly Godot.StringName _relicIntent
public static readonly Godot.StringName _relicThinkyDots
public static readonly Godot.StringName _shouldShowHoverTip
public static readonly Godot.StringName _targetingIndicator
public static readonly Godot.StringName _tween
public static readonly Godot.StringName CardIntent
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerIntentHandler+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerState

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private Godot.Control _cardContainer
private MegaCrit.Sts2.addons.mega_text.MegaLabel _cardCount
private MegaCrit.Sts2.Core.Nodes.Cards.NTinyCard _cardImage
private static readonly System.String _cardScenePath
private Godot.TextureRect _characterIcon
private Godot.Texture2D _currentLocationIcon
private static const System.String _darkenedEnergyMatPath = "res://materials/ui/energy_orb_dark.tres"
private static const System.UInt64 _delayBetweenTweensMsec = 500
private Godot.TextureRect _disconnectedIndicator
private Godot.Control _energyContainer
private MegaCrit.Sts2.addons.mega_text.MegaLabel _energyCount
private Godot.TextureRect _energyImage
private System.Boolean _focusedWhileTargeting
private MegaCrit.Sts2.Core.Nodes.Combat.NHealthBar _healthBar
private System.Boolean _isCreatureHovered
private System.Boolean _isHighlighted
private System.Boolean _isMouseOver
private Godot.Control _locationContainer
private Godot.TextureRect _locationIcon
private Godot.Tween _locationIconTween
private MegaCrit.Sts2.addons.mega_text.MegaLabel _nameplateLabel
private MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerNetworkProblemIndicator _networkProblemIndicator
private System.UInt64 _nextTweenTime
private static const System.Single _refHpBarMaxHp = 80
private static const System.Single _refHpBarWidth = 175
private static readonly System.String _scenePath
private MegaCrit.Sts2.Core.Nodes.Combat.NSelectionReticle _selectionReticle
private static const System.Single _selectionReticlePadding = 6
private Godot.Control _starContainer
private MegaCrit.Sts2.addons.mega_text.MegaLabel _starCount
private Godot.HBoxContainer _topContainer
private Godot.TextureRect _turnEndIndicator
private MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton <Hitbox>k__BackingField
private MegaCrit.Sts2.Core.Entities.Players.Player <Player>k__BackingField
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton Hitbox { public get; private set; }
MegaCrit.Sts2.Core.Entities.Players.Player Player { public get; private set; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task AnimateCardObtained(MegaCrit.Sts2.Core.Models.CardModel card)
private [async] System.Threading.Tasks.Task AnimateCardRemovedFromDeck(MegaCrit.Sts2.Core.Models.CardModel card)
private [async] System.Threading.Tasks.Task AnimatePotionDiscarded(MegaCrit.Sts2.Core.Models.PotionModel potion)
private [async] System.Threading.Tasks.Task AnimatePotionObtained(MegaCrit.Sts2.Core.Models.PotionModel potion)
private [async] System.Threading.Tasks.Task AnimateRelicObtained(MegaCrit.Sts2.Core.Models.RelicModel relic)
private [async] System.Threading.Tasks.Task AnimateRelicRemoved(MegaCrit.Sts2.Core.Models.RelicModel relic)
private [async] System.Threading.Tasks.Task ObtainedAnimation(Godot.Control node)
private [async] System.Threading.Tasks.Task RemovedAnimation(Godot.Control node)
private [async] System.Threading.Tasks.Task WaitUntilNextTweenTime()
private System.Boolean <TweenLocationIconAway>b__92_0()
private System.Void BlockChanged(System.Int32 oldBlock, System.Int32 blockGain)
private System.Void FlashEndTurn()
private System.Void OnCardAdded(MegaCrit.Sts2.Core.Models.CardModel _)
private System.Void OnCardObtained(MegaCrit.Sts2.Core.Models.CardModel card)
private System.Void OnCardRemoved(MegaCrit.Sts2.Core.Models.CardModel _)
private System.Void OnCardRemovedFromDeck(MegaCrit.Sts2.Core.Models.CardModel card)
private System.Void OnCombatEnded(MegaCrit.Sts2.Core.Rooms.CombatRoom _)
private System.Void OnCombatSetUp(MegaCrit.Sts2.Core.Combat.CombatState _)
private System.Void OnCreatureChanged(MegaCrit.Sts2.Core.Entities.Creatures.Creature _)
private System.Void OnCreatureValueChanged(System.Int32 _, System.Int32 __)
private System.Void OnEnergyChanged(System.Int32 _, System.Int32 __)
private System.Void OnPlayerEndTurnPing(System.UInt64 playerId)
private System.Void OnPlayerScreenChanged(System.UInt64 playerId, MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType _)
private System.Void OnPlayerVoteChanged(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Nullable<MegaCrit.Sts2.Core.Multiplayer.Game.MapVote> _, System.Nullable<MegaCrit.Sts2.Core.Multiplayer.Game.MapVote> __)
private System.Void OnPlayerVotesCleared()
private System.Void OnPotionDiscarded(MegaCrit.Sts2.Core.Models.PotionModel potion)
private System.Void OnPotionProcured(MegaCrit.Sts2.Core.Models.PotionModel potion)
private System.Void OnPowerAppliedOrRemoved(MegaCrit.Sts2.Core.Models.PowerModel _)
private System.Void OnPowerDecreased(MegaCrit.Sts2.Core.Models.PowerModel _, System.Boolean __)
private System.Void OnPowerIncreased(MegaCrit.Sts2.Core.Models.PowerModel _, System.Int32 __, System.Boolean ___)
private System.Void OnRelicObtained(MegaCrit.Sts2.Core.Models.RelicModel relic)
private System.Void OnRelicRemoved(MegaCrit.Sts2.Core.Models.RelicModel relic)
private System.Void OnStarsChanged(System.Int32 _, System.Int32 __)
private System.Void OnTurnStarted(MegaCrit.Sts2.Core.Combat.CombatState _)
private System.Void RefreshCombatValues()
private System.Void RefreshConnectedState()
private System.Void RefreshConnectedState(MegaCrit.Sts2.Core.Entities.Multiplayer.RunLobbyPlayer _)
private System.Void RefreshConnectedState(System.UInt64 _)
private System.Void RefreshPlayerReadyIndicator(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Boolean _)
private System.Void RefreshPlayerReadyIndicator(MegaCrit.Sts2.Core.Entities.Players.Player player)
private System.Void RefreshValues()
private System.Void set_Hitbox(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton value)
private System.Void set_Player(MegaCrit.Sts2.Core.Entities.Players.Player value)
private System.Void SetNextTweenTime()
private System.Void TweenLocationIconAway()
private System.Void TweenLocationIconIn(Godot.Texture2D texture)
private System.Void UpdateHealthBarWidth()
private System.Void UpdateHighlightedState()
private System.Void UpdateSelectionReticleWidth()
protected System.Void OnFocus(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
protected System.Void OnRelease(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
protected System.Void OnUnfocus(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public MegaCrit.Sts2.Core.Entities.Players.Player get_Player()
public MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton get_Hitbox()
public static MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerState Create(MegaCrit.Sts2.Core.Entities.Players.Player player)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Void FlashPlayerReady()
public System.Void OnCreatureHovered()
public System.Void OnCreatureUnhovered()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerState+<>c__DisplayClass93_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerState <>4__this
public Godot.Texture2D texture
public .ctor()
internal Godot.Texture2D <TweenLocationIconIn>b__0()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerState+<AnimateCardObtained>d__73

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerState <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NDeckHistoryEntry <cardNode>5__2
public MegaCrit.Sts2.Core.Models.CardModel card
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerState+<AnimateCardRemovedFromDeck>d__75

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerState <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NDeckHistoryEntry <cardNode>5__2
public MegaCrit.Sts2.Core.Models.CardModel card
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerState+<AnimatePotionDiscarded>d__79

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerState <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private MegaCrit.Sts2.Core.Nodes.Potions.NPotion <node>5__2
public MegaCrit.Sts2.Core.Models.PotionModel potion
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerState+<AnimatePotionObtained>d__77

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerState <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private MegaCrit.Sts2.Core.Nodes.Potions.NPotion <node>5__2
public MegaCrit.Sts2.Core.Models.PotionModel potion
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerState+<AnimateRelicObtained>d__69

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerState <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private MegaCrit.Sts2.Core.Nodes.Relics.NRelic <relicImage>5__2
public MegaCrit.Sts2.Core.Models.RelicModel relic
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerState+<AnimateRelicRemoved>d__71

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerState <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private MegaCrit.Sts2.Core.Nodes.Relics.NRelic <relicImage>5__2
public MegaCrit.Sts2.Core.Models.RelicModel relic
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerState+<ObtainedAnimation>d__89

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerState <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
public Godot.Control node
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerState+<RemovedAnimation>d__90

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerState <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
public Godot.Control node
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerState+<WaitUntilNextTweenTime>d__88

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerState <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerState+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName BlockChanged
public static readonly Godot.StringName FlashEndTurn
public static readonly Godot.StringName FlashPlayerReady
public static readonly Godot.StringName OnCreatureHovered
public static readonly Godot.StringName OnCreatureUnhovered
public static readonly Godot.StringName OnCreatureValueChanged
public static readonly Godot.StringName OnEnergyChanged
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPlayerEndTurnPing
public static readonly Godot.StringName OnPlayerScreenChanged
public static readonly Godot.StringName OnPlayerVotesCleared
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnStarsChanged
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName RefreshCombatValues
public static readonly Godot.StringName RefreshConnectedState
public static readonly Godot.StringName RefreshValues
public static readonly Godot.StringName SetNextTweenTime
public static readonly Godot.StringName TweenLocationIconAway
public static readonly Godot.StringName TweenLocationIconIn
public static readonly Godot.StringName UpdateHealthBarWidth
public static readonly Godot.StringName UpdateHighlightedState
public static readonly Godot.StringName UpdateSelectionReticleWidth
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerState+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _cardContainer
public static readonly Godot.StringName _cardCount
public static readonly Godot.StringName _cardImage
public static readonly Godot.StringName _characterIcon
public static readonly Godot.StringName _currentLocationIcon
public static readonly Godot.StringName _disconnectedIndicator
public static readonly Godot.StringName _energyContainer
public static readonly Godot.StringName _energyCount
public static readonly Godot.StringName _energyImage
public static readonly Godot.StringName _focusedWhileTargeting
public static readonly Godot.StringName _healthBar
public static readonly Godot.StringName _isCreatureHovered
public static readonly Godot.StringName _isHighlighted
public static readonly Godot.StringName _isMouseOver
public static readonly Godot.StringName _locationContainer
public static readonly Godot.StringName _locationIcon
public static readonly Godot.StringName _locationIconTween
public static readonly Godot.StringName _nameplateLabel
public static readonly Godot.StringName _networkProblemIndicator
public static readonly Godot.StringName _nextTweenTime
public static readonly Godot.StringName _selectionReticle
public static readonly Godot.StringName _starContainer
public static readonly Godot.StringName _starCount
public static readonly Godot.StringName _topContainer
public static readonly Godot.StringName _turnEndIndicator
public static readonly Godot.StringName Hitbox
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerState+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerStateContainer

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private System.Boolean _hidden
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerState> _nodes
private MegaCrit.Sts2.Core.Runs.IRunState _runState
private Godot.Tween _tween
MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerState FirstPlayerState { public get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task UpdatePositionAfterOneFrameAsync()
private Godot.Vector2 GetTargetPosition()
private System.Void UpdateNavigation()
private System.Void UpdatePosition()
private System.Void UpdatePositionAfterOneFrame()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerState get_FirstPlayerState()
public System.Void AnimHide()
public System.Void AnimShow()
public System.Void FlashPlayerReady(MegaCrit.Sts2.Core.Entities.Players.Player player)
public System.Void HideImmediately()
public System.Void HighlightPlayer(MegaCrit.Sts2.Core.Entities.Players.Player player)
public System.Void Initialize(MegaCrit.Sts2.Core.Runs.RunState runState)
public System.Void LockNavigation()
public System.Void ShowImmediately()
public System.Void UnhighlightPlayer(MegaCrit.Sts2.Core.Entities.Players.Player player)
public System.Void UnlockNavigation()
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Input(Godot.InputEvent inputEvent)
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerStateContainer+<>c__DisplayClass17_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Entities.Players.Player player
public .ctor()
internal System.Boolean <HighlightPlayer>b__0(MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerState n)
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerStateContainer+<>c__DisplayClass18_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Entities.Players.Player player
public .ctor()
internal System.Boolean <UnhighlightPlayer>b__0(MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerState n)
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerStateContainer+<>c__DisplayClass19_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Entities.Players.Player player
public .ctor()
internal System.Boolean <FlashPlayerReady>b__0(MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerState n)
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerStateContainer+<UpdatePositionAfterOneFrameAsync>d__14

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerStateContainer <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerStateContainer+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Input
public static readonly Godot.StringName AnimHide
public static readonly Godot.StringName AnimShow
public static readonly Godot.StringName GetTargetPosition
public static readonly Godot.StringName HideImmediately
public static readonly Godot.StringName LockNavigation
public static readonly Godot.StringName ShowImmediately
public static readonly Godot.StringName UnlockNavigation
public static readonly Godot.StringName UpdateNavigation
public static readonly Godot.StringName UpdatePosition
public static readonly Godot.StringName UpdatePositionAfterOneFrame
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerStateContainer+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _hidden
public static readonly Godot.StringName _tween
public static readonly Godot.StringName FirstPlayerState
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerStateContainer+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerTimeoutOverlay

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private System.Boolean _gameLevel
private Godot.TextureRect _icon
private static const System.Int32 _loadingNoResponseMsec = 8000
private MegaCrit.Sts2.Core.Multiplayer.NetClientGameService _netService
private static const System.Int32 _noResponseMsec = 3000
private System.Boolean <IsShown>k__BackingField
System.Boolean IsShown { public get; private set; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task UpdateLoop()
private System.Void set_IsShown(System.Boolean value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Boolean get_IsShown()
public System.Void Initialize(MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService netService, System.Boolean isGameLevel)
public System.Void Relocalize()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerTimeoutOverlay+<UpdateLoop>d__12

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerTimeoutOverlay <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerTimeoutOverlay+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Relocalize
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerTimeoutOverlay+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _gameLevel
public static readonly Godot.StringName _icon
public static readonly Godot.StringName IsShown
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerTimeoutOverlay+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerWarningPopup

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NVerticalPopup`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private static readonly System.String _scenePath
private MegaCrit.Sts2.Core.Nodes.CommonUi.NVerticalPopup _verticalPopup
public static const System.String ftueId = "multiplayer_warning"
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
Godot.Control DefaultFocusedControl { public virtual get; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnBackButtonPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OnIgnoreButtonPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerWarningPopup Create()
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual Godot.Control get_DefaultFocusedControl()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerWarningPopup+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NVerticalPopup+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName OnBackButtonPressed
public static readonly Godot.StringName OnIgnoreButtonPressed
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerWarningPopup+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NVerticalPopup+PropertyName`。

接口：

```text
public static readonly Godot.StringName _verticalPopup
public static readonly Godot.StringName DefaultFocusedControl
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerWarningPopup+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NVerticalPopup+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteLoadLobbyPlayerContainer

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private Godot.Control _container
private MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.LoadRunLobby _lobby
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteLobbyPlayer> _nodes
private MegaCrit.Sts2.addons.mega_text.MegaLabel _othersLabel
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void Cleanup()
public System.Void Initialize(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.LoadRunLobby runLobby, System.Boolean displayLocalPlayer)
public System.Void OnPlayerChanged(System.UInt64 playerId)
public System.Void OnPlayerConnected(System.UInt64 playerId)
public System.Void OnPlayerDisconnected(System.UInt64 playerId)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteLoadLobbyPlayerContainer+<>c__DisplayClass8_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.UInt64 playerId
public .ctor()
internal System.Boolean <OnPlayerChanged>b__0(MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteLobbyPlayer p)
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteLoadLobbyPlayerContainer+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Cleanup
public static readonly Godot.StringName OnPlayerChanged
public static readonly Godot.StringName OnPlayerConnected
public static readonly Godot.StringName OnPlayerDisconnected
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteLoadLobbyPlayerContainer+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _container
public static readonly Godot.StringName _othersLabel
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteLoadLobbyPlayerContainer+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteLobbyPlayer

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Models.CharacterModel _character
private Godot.TextureRect _characterIcon
private MegaCrit.Sts2.addons.mega_text.MegaLabel _characterLabel
private Godot.Control _disconnectedIndicator
private System.Boolean _isConnected
private System.Boolean _isReady
private System.Boolean _isSingleplayer
private MegaCrit.Sts2.addons.mega_text.MegaLabel _nameplateLabel
private System.Nullable<Godot.Vector2> _originalPosition
private MegaCrit.Sts2.Core.Platform.PlatformType _platform
private System.UInt64 _playerId
private Godot.Control _readyIndicator
private static readonly System.String _scenePath
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.ScreenPunchInstance _shake
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
System.UInt64 PlayerId { public get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void RefreshVisuals()
private System.Void SetCharacter(MegaCrit.Sts2.Core.Models.CharacterModel character)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteLobbyPlayer Create(MegaCrit.Sts2.Core.Entities.Multiplayer.StartRunLobbyPlayer player, MegaCrit.Sts2.Core.Platform.PlatformType platform, System.Boolean isSingleplayer)
public static MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteLobbyPlayer Create(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.LoadRunLobby runLobby, System.UInt64 playerId, MegaCrit.Sts2.Core.Platform.PlatformType platform, System.Boolean isSingleplayer)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.UInt64 get_PlayerId()
public System.Void CancelShake()
public System.Void OnPlayerChanged(MegaCrit.Sts2.Core.Entities.Multiplayer.StartRunLobbyPlayer lobbyPlayer)
public System.Void OnPlayerChanged(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.LoadRunLobby runLobby, System.UInt64 playerId)
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteLobbyPlayer+<>c__DisplayClass19_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.UInt64 playerId
public .ctor()
internal System.Boolean <Create>b__0(MegaCrit.Sts2.Core.Saves.Runs.SerializablePlayer p)
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteLobbyPlayer+<>c__DisplayClass22_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.UInt64 playerId
public .ctor()
internal System.Boolean <OnPlayerChanged>b__0(MegaCrit.Sts2.Core.Saves.Runs.SerializablePlayer p)
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteLobbyPlayer+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName CancelShake
public static readonly Godot.StringName RefreshVisuals
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteLobbyPlayer+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _characterIcon
public static readonly Godot.StringName _characterLabel
public static readonly Godot.StringName _disconnectedIndicator
public static readonly Godot.StringName _isConnected
public static readonly Godot.StringName _isReady
public static readonly Godot.StringName _isSingleplayer
public static readonly Godot.StringName _nameplateLabel
public static readonly Godot.StringName _platform
public static readonly Godot.StringName _playerId
public static readonly Godot.StringName _readyIndicator
public static readonly Godot.StringName PlayerId
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteLobbyPlayer+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteLobbyPlayerContainer

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private Godot.Container _container
private System.Boolean _displayLocalPlayer
private MegaCrit.Sts2.Core.Nodes.Multiplayer.NInvitePlayersButton _inviteButton
private MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby _lobby
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteLobbyPlayer> _nodes
private MegaCrit.Sts2.addons.mega_text.MegaLabel _soloLabel
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void RefreshSoloLabelVisibility()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void Cleanup()
public System.Void Initialize(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby lobby, System.Boolean displayLocalPlayer)
public System.Void OnPlayerChanged(MegaCrit.Sts2.Core.Entities.Multiplayer.StartRunLobbyPlayer player)
public System.Void OnPlayerConnected(MegaCrit.Sts2.Core.Entities.Multiplayer.StartRunLobbyPlayer player)
public System.Void OnPlayerDisconnected(MegaCrit.Sts2.Core.Entities.Multiplayer.StartRunLobbyPlayer player)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteLobbyPlayerContainer+<>c__DisplayClass10_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Entities.Multiplayer.StartRunLobbyPlayer player
public .ctor()
internal System.Boolean <OnPlayerChanged>b__0(MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteLobbyPlayer p)
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteLobbyPlayerContainer+<>c__DisplayClass9_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Entities.Multiplayer.StartRunLobbyPlayer player
public .ctor()
internal System.Boolean <OnPlayerDisconnected>b__0(MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteLobbyPlayer p)
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteLobbyPlayerContainer+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Cleanup
public static readonly Godot.StringName RefreshSoloLabelVisibility
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteLobbyPlayerContainer+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _container
public static readonly Godot.StringName _displayLocalPlayer
public static readonly Godot.StringName _inviteButton
public static readonly Godot.StringName _soloLabel
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteLobbyPlayerContainer+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteMouseCursor

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private Godot.Image _defaultCursorImage
private Godot.ImageTexture _defaultCursorTexture
private Godot.Image _defaultDrawingImage
private Godot.ImageTexture _defaultDrawingTexture
private Godot.Image _defaultErasingImage
private Godot.ImageTexture _defaultErasingTexture
private Godot.Vector2 _defaultHotspot
private Godot.Vector2 _drawingHotspot
private MegaCrit.Sts2.Core.Nodes.Screens.Map.DrawingMode _drawingMode
private Godot.Vector2 _erasingHotspot
private System.UInt64 _lastPositionUpdateMsec
private System.Nullable<Godot.Vector2> _nextPosition
private System.Nullable<Godot.Vector2> _previousPosition
private static const System.String _scenePath = "ui/multiplayer/remote_mouse_cursor"
private Godot.TextureRect _textureRect
private Godot.Image _tiltedCursorImage
private Godot.ImageTexture _tiltedCursorTexture
private Godot.Image _tiltedDrawingImage
private Godot.ImageTexture _tiltedDrawingTexture
private Godot.Image _tiltedErasingImage
private Godot.ImageTexture _tiltedErasingTexture
private System.UInt64 <PlayerId>k__BackingField
System.UInt64 PlayerId { public get; private set; }
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private Godot.Texture2D GetTexture(System.Boolean isDown, MegaCrit.Sts2.Core.Nodes.Screens.Map.DrawingMode drawingMode)
private Godot.Vector2 GetHotspot(MegaCrit.Sts2.Core.Nodes.Screens.Map.DrawingMode drawingMode)
private System.Void set_PlayerId(System.UInt64 value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteMouseCursor Create(System.UInt64 playerId)
public System.UInt64 get_PlayerId()
public System.Void RefreshSize()
public System.Void SetNextPosition(Godot.Vector2 position)
public System.Void UpdateImage(System.Boolean isDown, MegaCrit.Sts2.Core.Nodes.Screens.Map.DrawingMode drawingMode)
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteMouseCursor+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName GetHotspot
public static readonly Godot.StringName GetTexture
public static readonly Godot.StringName RefreshSize
public static readonly Godot.StringName SetNextPosition
public static readonly Godot.StringName UpdateImage
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteMouseCursor+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _defaultCursorImage
public static readonly Godot.StringName _defaultCursorTexture
public static readonly Godot.StringName _defaultDrawingImage
public static readonly Godot.StringName _defaultDrawingTexture
public static readonly Godot.StringName _defaultErasingImage
public static readonly Godot.StringName _defaultErasingTexture
public static readonly Godot.StringName _defaultHotspot
public static readonly Godot.StringName _drawingHotspot
public static readonly Godot.StringName _drawingMode
public static readonly Godot.StringName _erasingHotspot
public static readonly Godot.StringName _lastPositionUpdateMsec
public static readonly Godot.StringName _textureRect
public static readonly Godot.StringName _tiltedCursorImage
public static readonly Godot.StringName _tiltedCursorTexture
public static readonly Godot.StringName _tiltedDrawingImage
public static readonly Godot.StringName _tiltedDrawingTexture
public static readonly Godot.StringName _tiltedErasingImage
public static readonly Godot.StringName _tiltedErasingTexture
public static readonly Godot.StringName PlayerId
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteMouseCursor+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteMouseCursorContainer

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteMouseCursor> _cursors
private static System.Boolean _isDebugUiVisible
private MegaCrit.Sts2.Core.Multiplayer.Game.PeerInput.PeerInputSynchronizer _synchronizer
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
private MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteMouseCursor GetCursor(System.UInt64 playerId)
private static MegaCrit.Sts2.Core.Nodes.Screens.Map.DrawingMode GetDrawingMode(System.UInt64 playerId)
private System.Void AddCursor(System.UInt64 playerId)
private System.Void ApplyDebugUiVisibility()
private System.Void NetServiceDisconnected(MegaCrit.Sts2.Core.Entities.Multiplayer.NetErrorInfo _)
private System.Void OnGuiFocusChanged(Godot.Control focused)
private System.Void OnInputStateAdded(System.UInt64 playerId)
private System.Void OnInputStateChanged(System.UInt64 playerId)
private System.Void OnInputStateRemoved(System.UInt64 playerId)
private System.Void RemoveCursor(System.UInt64 playerId)
private System.Void UpdateCursorVisibility()
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public Godot.Vector2 GetCursorPosition(System.UInt64 playerId)
public System.Void Deinitialize()
public System.Void DrawingCursorStateChanged(System.UInt64 playerId)
public System.Void ForceUpdateAllCursors()
public System.Void Initialize(MegaCrit.Sts2.Core.Multiplayer.Game.PeerInput.PeerInputSynchronizer synchronizer, System.Collections.Generic.IEnumerable<System.UInt64> connectedPlayerIds)
public virtual System.Void _ExitTree()
public virtual System.Void _Input(Godot.InputEvent inputEvent)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteMouseCursorContainer+<>c__DisplayClass12_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.UInt64 playerId
public .ctor()
internal System.Boolean <AddCursor>b__0(MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteMouseCursor c)
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteMouseCursorContainer+<>c__DisplayClass16_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.UInt64 playerId
public .ctor()
internal System.Boolean <GetCursor>b__0(MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteMouseCursor c)
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteMouseCursorContainer+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Input
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AddCursor
public static readonly Godot.StringName ApplyDebugUiVisibility
public static readonly Godot.StringName Deinitialize
public static readonly Godot.StringName DrawingCursorStateChanged
public static readonly Godot.StringName ForceUpdateAllCursors
public static readonly Godot.StringName GetCursor
public static readonly Godot.StringName GetCursorPosition
public static readonly Godot.StringName GetDrawingMode
public static readonly Godot.StringName OnGuiFocusChanged
public static readonly Godot.StringName OnInputStateAdded
public static readonly Godot.StringName OnInputStateChanged
public static readonly Godot.StringName OnInputStateRemoved
public static readonly Godot.StringName RemoveCursor
public static readonly Godot.StringName UpdateCursorVisibility
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteMouseCursorContainer+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteMouseCursorContainer+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```
