# MegaCrit.Sts2.Core.Nodes.Events

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.Events.NAncientEventLayout

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Events.NEventLayout`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Nodes.Screens.NAncientBgContainer _ancientBgContainer
private MegaCrit.Sts2.Core.Models.AncientEventModel _ancientEvent
private Godot.Control _ancientNameBanner
private Godot.Tween _bannerTween
private Godot.VBoxContainer _content
private Godot.Control _contentContainer
private Godot.Tween _contentTween
private static const System.Double _contentTweenDuration = 1
private System.Threading.CancellationTokenSource _cts
private System.Int32 _currentDialogueLine
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogueLine> _dialogue
private Godot.VBoxContainer _dialogueContainer
private MegaCrit.Sts2.Core.Nodes.Events.NAncientDialogueHitbox _dialogueHitbox
private Godot.Control _fakeNextButton
private Godot.Control _fakeNextButtonContainer
private MegaCrit.Sts2.Core.Nodes.CommonUi.NHotkeyIcon _fakeNextButtonControllerIcon
private MegaCrit.Sts2.addons.mega_text.MegaLabel _fakeNextButtonLabel
private System.Single _originalContentContainerHeight
public static const System.String ancientScenePath = "res://scenes/events/ancient_event_layout.tscn"
Godot.Control DefaultFocusedControl { public virtual get; }
System.Boolean IsDialogueOnLastLine { private get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task PlayHealVfxAfterFadeIn(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Decimal healAmount)
private System.Boolean get_IsDialogueOnLastLine()
private System.Void <SetDialogueLineAndAnimate>b__32_0()
private System.Void HideNameBanner()
private System.Void OnDialogueHitboxClicked(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl _)
private System.Void OnDialogueLineFocused(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl dialogueLine)
private System.Void OnDialogueLineUnfocused(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl dialogueLine)
private System.Void SetDialogueLineAndAnimate(System.Int32 lineIndex)
private System.Void ShowNameBanner()
private System.Void UpdateBannerVisibility()
private System.Void UpdateFakeNextButton()
private System.Void UpdateHotkeyDisplay()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void AnimateButtonsIn()
protected virtual System.Void AnimateIn()
protected virtual System.Void InitializeVisuals()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void ClearDialogue()
public System.Void SetDialogue(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogueLine> lines)
public virtual Godot.Control get_DefaultFocusedControl()
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
public virtual System.Void OnSetupComplete()
```

## MegaCrit.Sts2.Core.Nodes.Events.NEventLayout

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private Godot.Texture2D _currentPhobiaPortraitTex
private Godot.Texture2D _currentPortraitTex
protected MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _description
protected Godot.Tween _descriptionTween
protected MegaCrit.Sts2.Core.Models.EventModel _event
private static System.Boolean _isDebugUiVisible
protected Godot.VBoxContainer _optionsContainer
private Godot.TextureRect _portrait
protected MegaCrit.Sts2.addons.mega_text.MegaLabel _sharedEventLabel
private static readonly MegaCrit.Sts2.Core.Localization.LocString _sharedEventLoc
private MegaCrit.Sts2.addons.mega_text.MegaLabel _title
private Godot.Control <VfxContainer>k__BackingField
public static const System.String defaultScenePath = "res://scenes/events/default_event_layout.tscn"
Godot.Control DefaultFocusedControl { public virtual get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Nodes.Events.NEventOptionButton> OptionButtons { public get; }
Godot.Control VfxContainer { public get; private set; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void ApplyDebugUiVisibility()
private System.Void OnPlayerVoteChanged(MegaCrit.Sts2.Core.Entities.Players.Player player)
private System.Void set_VfxContainer(Godot.Control value)
private System.Void UpdatePhobiaMode()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void AnimateButtonsIn()
protected virtual System.Void AnimateIn()
protected virtual System.Void InitializeVisuals()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public [async] System.Threading.Tasks.Task BeforeSharedOptionChosen(MegaCrit.Sts2.Core.Events.EventOption option)
public Godot.Control get_VfxContainer()
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Nodes.Events.NEventOptionButton> get_OptionButtons()
public System.Void AddOptions(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Events.EventOption> options)
public System.Void AddVfxAnchoredToPortrait(Godot.Node vfx)
public System.Void ClearOptions()
public System.Void DisableEventOptions()
public System.Void RemoveNodesOnPortrait()
public System.Void SetDescription(System.String description)
public System.Void SetPortrait(Godot.Texture2D portrait, Godot.Texture2D phobiaModePortrait = null)
public System.Void SetTitle(System.String title)
public virtual Godot.Control get_DefaultFocusedControl()
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Input(Godot.InputEvent inputEvent)
public virtual System.Void _Ready()
public virtual System.Void OnSetupComplete()
public virtual System.Void SetEvent(MegaCrit.Sts2.Core.Models.EventModel eventModel)
```

## MegaCrit.Sts2.Core.Nodes.Events.NEventOptionButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private Godot.Tween _animInTween
private Godot.Color _buttonColor
private readonly System.Threading.CancellationTokenSource _cancelToken
private Godot.NinePatchRect _confirmFlash
private System.Threading.CancellationTokenSource _deathPreventionCancellation
private MegaCrit.Sts2.Core.Nodes.Vfx.NThoughtBubbleVfx _deathPreventionVfx
private Godot.Vector2 _deathPreventionVfxPosition
private static const System.Single _defaultV = 0.9
private Godot.Tween _flashTween
private static readonly Godot.StringName _h
private static readonly Godot.Vector2 _hoverScale
private static const System.Single _hoverV = 1.2
private Godot.ShaderMaterial _hsv
private Godot.NinePatchRect _image
private Godot.NinePatchRect _killGlow
private Godot.Tween _killGlowTween
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _label
private Godot.NinePatchRect _outline
private MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer _playerVoteContainer
private static readonly Godot.Vector2 _pressScale
private static readonly Godot.StringName _s
private Godot.Tween _tween
private static readonly Godot.StringName _v
private static readonly System.String _voteIconPath
private MegaCrit.Sts2.Core.Models.EventModel <Event>k__BackingField
private System.Int32 <Index>k__BackingField
private MegaCrit.Sts2.Core.Events.EventOption <Option>k__BackingField
System.String AncientScenePath { private static get; }
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
MegaCrit.Sts2.Core.Models.EventModel Event { public get; private set; }
System.Int32 Index { private get; private set; }
MegaCrit.Sts2.Core.Events.EventOption Option { public get; private set; }
System.String ScenePath { private static get; }
MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer VoteContainer { public get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task ExpireDeathPreventionVfx()
private [async] System.Threading.Tasks.Task RumbleDeathVfx()
private static System.String get_AncientScenePath()
private static System.String get_ScenePath()
private System.Boolean ShouldDisplayPlayerVote(MegaCrit.Sts2.Core.Entities.Players.Player player)
private System.Boolean WillKillPlayer()
private System.Int32 get_Index()
private System.Void PulseKillGlow()
private System.Void set_Event(MegaCrit.Sts2.Core.Models.EventModel value)
private System.Void set_Index(System.Int32 value)
private System.Void set_Option(MegaCrit.Sts2.Core.Events.EventOption value)
private System.Void SetVisuallyLocked()
private System.Void ShowPersistentKillGlow()
private System.Void UpdateShaderParam(System.Single newV)
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
public [async] System.Threading.Tasks.Task FlashConfirmation()
public MegaCrit.Sts2.Core.Events.EventOption get_Option()
public MegaCrit.Sts2.Core.Models.EventModel get_Event()
public MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer get_VoteContainer()
public static MegaCrit.Sts2.Core.Nodes.Events.NEventOptionButton Create(MegaCrit.Sts2.Core.Models.EventModel eventModel, MegaCrit.Sts2.Core.Events.EventOption option, System.Int32 index)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Void AnimateIn()
public System.Void EnableButton()
public System.Void GrayOut()
public System.Void RefreshVotes()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```
