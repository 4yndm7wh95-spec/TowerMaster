# MegaCrit.Sts2.Core.Nodes.Events

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。


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

