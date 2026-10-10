# MegaCrit.Sts2.Core.Nodes.Screens.Timeline

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.EpochComparer

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：`System.Collections.Generic.IComparer<MegaCrit.Sts2.Core.Saves.SerializableEpoch>`

```text
public .ctor()
public virtual System.Int32 Compare(MegaCrit.Sts2.Core.Saves.SerializableEpoch x, MegaCrit.Sts2.Core.Saves.SerializableEpoch y)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.EpochSlotState

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Nodes.Screens.Timeline.EpochSlotState Complete = 1
public static const MegaCrit.Sts2.Core.Nodes.Screens.Timeline.EpochSlotState None = 0
public static const MegaCrit.Sts2.Core.Nodes.Screens.Timeline.EpochSlotState NotObtained = 3
public static const MegaCrit.Sts2.Core.Nodes.Screens.Timeline.EpochSlotState Obtained = 2
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NAcknowledgeButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.addons.mega_text.MegaLabel _label
private Godot.Tween _tween
System.String ClickedSfx { protected virtual get; }
System.String[] Hotkeys { protected virtual get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.String get_ClickedSfx()
protected virtual System.String[] get_Hotkeys()
protected virtual System.Void OnFocus()
protected virtual System.Void OnPress()
protected virtual System.Void OnRelease()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NAcknowledgeButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnUnfocus
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NAcknowledgeButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _label
public static readonly Godot.StringName _tween
public static readonly Godot.StringName ClickedSfx
public static readonly Godot.StringName Hotkeys
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NAcknowledgeButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NChapterPaginateButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private Godot.TextureRect _icon
private System.Boolean _isFacingRight
private Godot.Tween _tween
System.String ClickedSfx { protected virtual get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.String get_ClickedSfx()
protected virtual System.Void OnDisable()
protected virtual System.Void OnEnable()
protected virtual System.Void OnFocus()
protected virtual System.Void OnPress()
protected virtual System.Void OnRelease()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void SetDirection(System.Boolean isFacingRight)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NChapterPaginateButton+MethodName

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
public static readonly Godot.StringName SetDirection
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NChapterPaginateButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _icon
public static readonly Godot.StringName _isFacingRight
public static readonly Godot.StringName _tween
public static readonly Godot.StringName ClickedSfx
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NChapterPaginateButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NCloseButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.addons.mega_text.MegaLabel _closeLabel
private Godot.Tween _tween
System.String ClickedSfx { protected virtual get; }
System.String ControllerIconHotkey { protected virtual get; }
System.String[] Hotkeys { protected virtual get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.String get_ClickedSfx()
protected virtual System.String get_ControllerIconHotkey()
protected virtual System.String[] get_Hotkeys()
protected virtual System.Void OnFocus()
protected virtual System.Void OnPress()
protected virtual System.Void OnRelease()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void SetLabel(System.String text)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NCloseButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName SetLabel
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NCloseButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _closeLabel
public static readonly Godot.StringName _tween
public static readonly Godot.StringName ClickedSfx
public static readonly Godot.StringName ControllerIconHotkey
public static readonly Godot.StringName Hotkeys
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NCloseButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEpochCard

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private Godot.Color _blueGlowColor
private Godot.Tween _denyTween
private Godot.TextureRect _glow
private Godot.Tween _glowTween
private Godot.Color _goldGlowColor
private System.Boolean _isHeld
private System.Boolean _isHoverable
private System.Boolean _isHovered
private System.Boolean _isWigglyUnlockPreviewMode
private Godot.TextureRect _mask
private Godot.FastNoiseLite _noise
private System.Single _noiseSpeed
private Godot.TextureRect _portrait
private Godot.Tween _scaleTween
private Godot.Vector2 _targetScale
private System.Single _time
private Godot.Tween _transparencyTween
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void GlowFlash()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void Init(MegaCrit.Sts2.Core.Timeline.EpochModel epochModel)
public System.Void SetToWigglyUnlockPreviewMode()
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEpochCard+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName GlowFlash
public static readonly Godot.StringName SetToWigglyUnlockPreviewMode
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEpochCard+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _blueGlowColor
public static readonly Godot.StringName _denyTween
public static readonly Godot.StringName _glow
public static readonly Godot.StringName _glowTween
public static readonly Godot.StringName _goldGlowColor
public static readonly Godot.StringName _isHeld
public static readonly Godot.StringName _isHoverable
public static readonly Godot.StringName _isHovered
public static readonly Godot.StringName _isWigglyUnlockPreviewMode
public static readonly Godot.StringName _mask
public static readonly Godot.StringName _noise
public static readonly Godot.StringName _noiseSpeed
public static readonly Godot.StringName _portrait
public static readonly Godot.StringName _scaleTween
public static readonly Godot.StringName _targetScale
public static readonly Godot.StringName _time
public static readonly Godot.StringName _transparencyTween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEpochCard+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEpochInspectScreen

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Saves.SerializableEpoch> _allEpochs
private Godot.Tween _buttonTween
private MegaCrit.Sts2.Core.Nodes.Vfx.Ui.NEpochChains _chains
private MegaCrit.Sts2.addons.mega_text.MegaLabel _chapterLabel
private MegaCrit.Sts2.Core.Localization.LocString _chapterLoc
private MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NCloseButton _closeButton
private System.Single _closeButtonY
private MegaCrit.Sts2.Core.Timeline.EpochModel _epoch
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _fancyText
private System.Boolean _hasStory
private Godot.TextureRect _mask
private System.Single _maskOffsetX
private System.Single _maskOffsetY
private MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEpochPaginateButton _nextChapterButton
private System.Single _nextChapterButtonOffsetX
private MegaCrit.Sts2.Core.Timeline.EpochModel _nextChapterEpoch
private MegaCrit.Sts2.addons.mega_text.MegaLabel _placeholderLabel
private static readonly MegaCrit.Sts2.Core.Localization.LocString _placeholderLoc
private Godot.TextureRect _portrait
private Godot.TextureRect _portraitFlash
private Godot.ShaderMaterial _portraitHsv
private MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEpochPaginateButton _prevChapterButton
private System.Single _prevChapterButtonOffsetX
private MegaCrit.Sts2.Core.Timeline.EpochModel _prevChapterEpoch
private static readonly Godot.StringName _s
private MegaCrit.Sts2.addons.mega_text.MegaLabel _storyLabel
private Godot.Tween _textTween
private Godot.Tween _tween
private MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NUnlockInfo _unlockInfo
private Godot.Tween _unlockTween
private static readonly Godot.StringName _v
private System.Boolean _wasRevealed
public static readonly System.String lockedImagePath
Godot.Control DefaultFocusedControl { public virtual get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task UnlockAnimation(MegaCrit.Sts2.Core.Timeline.EpochModel epoch)
private System.Void <_Ready>b__33_0(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl _)
private System.Void <_Ready>b__33_1(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl _)
private System.Void <Close>b__37_0()
private System.Void HidePaginators()
private System.Void NextChapter()
private System.Void OnMouseReleased(Godot.InputEvent obj)
private System.Void OpenViaPaginator(MegaCrit.Sts2.Core.Timeline.EpochModel epoch)
private System.Void PrevChapter()
private System.Void RefreshChapterPaginators()
private System.Void SpeedUpTextAnimation()
private System.Void UpdateShaderS(System.Single value)
private System.Void UpdateShaderV(System.Single value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public [async] System.Threading.Tasks.Task Open(MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEpochSlot slot, MegaCrit.Sts2.Core.Timeline.EpochModel epoch, System.Boolean wasRevealed)
public System.Void Close()
public virtual Godot.Control get_DefaultFocusedControl()
public virtual System.Void _Input(Godot.InputEvent inputEvent)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEpochInspectScreen+<Open>d__34

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEpochInspectScreen <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.Timeline.EpochModel epoch
public MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEpochSlot slot
public System.Boolean wasRevealed
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEpochInspectScreen+<UnlockAnimation>d__38

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEpochInspectScreen <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
private System.Boolean <isFast>5__2
public MegaCrit.Sts2.Core.Timeline.EpochModel epoch
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEpochInspectScreen+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+MethodName`。

接口：

```text
public static readonly Godot.StringName _Input
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Close
public static readonly Godot.StringName HidePaginators
public static readonly Godot.StringName NextChapter
public static readonly Godot.StringName OnMouseReleased
public static readonly Godot.StringName PrevChapter
public static readonly Godot.StringName RefreshChapterPaginators
public static readonly Godot.StringName SpeedUpTextAnimation
public static readonly Godot.StringName UpdateShaderS
public static readonly Godot.StringName UpdateShaderV
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEpochInspectScreen+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+PropertyName`。

接口：

```text
public static readonly Godot.StringName _buttonTween
public static readonly Godot.StringName _chains
public static readonly Godot.StringName _chapterLabel
public static readonly Godot.StringName _closeButton
public static readonly Godot.StringName _closeButtonY
public static readonly Godot.StringName _fancyText
public static readonly Godot.StringName _hasStory
public static readonly Godot.StringName _mask
public static readonly Godot.StringName _maskOffsetX
public static readonly Godot.StringName _maskOffsetY
public static readonly Godot.StringName _nextChapterButton
public static readonly Godot.StringName _nextChapterButtonOffsetX
public static readonly Godot.StringName _placeholderLabel
public static readonly Godot.StringName _portrait
public static readonly Godot.StringName _portraitFlash
public static readonly Godot.StringName _portraitHsv
public static readonly Godot.StringName _prevChapterButton
public static readonly Godot.StringName _prevChapterButtonOffsetX
public static readonly Godot.StringName _storyLabel
public static readonly Godot.StringName _textTween
public static readonly Godot.StringName _tween
public static readonly Godot.StringName _unlockInfo
public static readonly Godot.StringName _unlockTween
public static readonly Godot.StringName _wasRevealed
public static readonly Godot.StringName DefaultFocusedControl
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEpochInspectScreen+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEpochPaginateButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NGoldArrowButton`。

接口：`System.IDisposable`

```text
private System.Boolean _isLeft
System.String ClickedSfx { protected virtual get; }
System.String[] Hotkeys { protected virtual get; }
System.Boolean IsLeft { public get; public set; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.String get_ClickedSfx()
protected virtual System.String[] get_Hotkeys()
protected virtual System.Void OnDisable()
protected virtual System.Void OnEnable()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Boolean get_IsLeft()
public System.Void set_IsLeft(System.Boolean value)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEpochPaginateButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NGoldArrowButton+MethodName`。

接口：

```text
public static readonly Godot.StringName OnDisable
public static readonly Godot.StringName OnEnable
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEpochPaginateButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NGoldArrowButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _isLeft
public static readonly Godot.StringName ClickedSfx
public static readonly Godot.StringName Hotkeys
public static readonly Godot.StringName IsLeft
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEpochPaginateButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NGoldArrowButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEpochReminderText

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _label
private MegaCrit.Sts2.Core.Localization.LocString _loc
private Godot.Tween _tween
private Godot.Control _vfxHolder
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void AnimateIn()
public System.Void AnimateOut()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEpochReminderText+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AnimateIn
public static readonly Godot.StringName AnimateOut
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEpochReminderText+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _label
public static readonly Godot.StringName _tween
public static readonly Godot.StringName _vfxHolder
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEpochReminderText+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEpochSlot

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private Godot.Control _blur
private Godot.TextureRect _blurPortrait
private Godot.ShaderMaterial _blurShader
private Godot.TextureRect _chains
private static readonly Godot.Color _defaultSlotOutlineColor
private MegaCrit.Sts2.Core.Timeline.EpochEra _era
private Godot.Tween _glowTween
private static readonly Godot.Color _highlightSlotColor
private Godot.Control _highlightVfx
private MegaCrit.Sts2.Core.HoverTips.IHoverTip _hoverTip
private Godot.Tween _hoverTween
private Godot.ShaderMaterial _hsv
private System.Boolean _isComplete
private System.Boolean _isGlowPulsing
private System.Boolean _isHovered
private static readonly Godot.StringName _lod
private MegaCrit.Sts2.Core.Nodes.Vfx.NEpochOffscreenVfx _offscreenVfx
private Godot.TextureRect _outline
private Godot.TextureRect _portrait
private static readonly Godot.StringName _s
private static const System.String _scenePath = "res://scenes/timeline_screen/epoch_slot.tscn"
private MegaCrit.Sts2.Core.Nodes.Combat.NSelectionReticle _selectionReticle
private Godot.TextureRect _slotImage
private Godot.Tween _spawnTween
private Godot.SubViewport _subViewport
private Godot.SubViewportContainer _subViewportContainer
private static const System.String _unlockIconPath = "res://images/packed/unlock_icon.png"
private static readonly Godot.StringName _v
private System.Boolean <HasSpawned>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Screens.Timeline.EpochSlotState <State>k__BackingField
public static readonly System.Collections.Generic.IEnumerable<System.String> assetPaths
public System.Int32 eraPosition
public MegaCrit.Sts2.Core.Timeline.EpochModel model
System.String ClickedSfx { protected virtual get; }
System.Boolean HasSpawned { public get; private set; }
System.String HoveredSfx { protected virtual get; }
MegaCrit.Sts2.Core.Nodes.Screens.Timeline.EpochSlotState State { public get; private set; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void DisableHighlight()
private System.Void EnableHighlight()
private System.Void RevealEpoch()
private System.Void set_HasSpawned(System.Boolean value)
private System.Void set_State(MegaCrit.Sts2.Core.Nodes.Screens.Timeline.EpochSlotState value)
private System.Void UpdateBlurLod(System.Single value)
private System.Void UpdateShaderS(System.Single value)
private System.Void UpdateShaderV(System.Single value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.String get_ClickedSfx()
protected virtual System.String get_HoveredSfx()
protected virtual System.Void OnFocus()
protected virtual System.Void OnPress()
protected virtual System.Void OnRelease()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public [async] System.Threading.Tasks.Task SpawnSlot()
public MegaCrit.Sts2.Core.Nodes.Screens.Timeline.EpochSlotState get_State()
public static MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEpochSlot Create(MegaCrit.Sts2.Core.Timeline.EpochSlotData data)
public System.Boolean get_HasSpawned()
public System.Void SetState(MegaCrit.Sts2.Core.Nodes.Screens.Timeline.EpochSlotState setState)
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEpochSlot+<SpawnSlot>d__50

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEpochSlot <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEpochSlot+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName DisableHighlight
public static readonly Godot.StringName EnableHighlight
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName RevealEpoch
public static readonly Godot.StringName SetState
public static readonly Godot.StringName UpdateBlurLod
public static readonly Godot.StringName UpdateShaderS
public static readonly Godot.StringName UpdateShaderV
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEpochSlot+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _blur
public static readonly Godot.StringName _blurPortrait
public static readonly Godot.StringName _blurShader
public static readonly Godot.StringName _chains
public static readonly Godot.StringName _era
public static readonly Godot.StringName _glowTween
public static readonly Godot.StringName _highlightVfx
public static readonly Godot.StringName _hoverTween
public static readonly Godot.StringName _hsv
public static readonly Godot.StringName _isComplete
public static readonly Godot.StringName _isGlowPulsing
public static readonly Godot.StringName _isHovered
public static readonly Godot.StringName _offscreenVfx
public static readonly Godot.StringName _outline
public static readonly Godot.StringName _portrait
public static readonly Godot.StringName _selectionReticle
public static readonly Godot.StringName _slotImage
public static readonly Godot.StringName _spawnTween
public static readonly Godot.StringName _subViewport
public static readonly Godot.StringName _subViewportContainer
public static readonly Godot.StringName ClickedSfx
public static readonly Godot.StringName eraPosition
public static readonly Godot.StringName HasSpawned
public static readonly Godot.StringName HoveredSfx
public static readonly Godot.StringName State
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEpochSlot+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEraColumn

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Timeline.EpochSlotData _data
private Godot.TextureRect _icon
private Godot.Tween _iconTween
private System.Boolean _isAnimated
private System.Boolean _labelSpawned
private Godot.Tween _labelTween
private MegaCrit.Sts2.addons.mega_text.MegaLabel _name
private Godot.Vector2 _predictedPosition
private Godot.Vector2 _prevGlobalPos
private Godot.Vector2 _prevLocalPos
private static const System.String _scenePath = "res://scenes/timeline_screen/era_column.tscn"
private Godot.Vector2 _targetPosition
private MegaCrit.Sts2.addons.mega_text.MegaLabel _year
public static readonly System.Collections.Generic.IEnumerable<System.String> assetPaths
public MegaCrit.Sts2.Core.Timeline.EpochEra era
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void RectChange()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public [async] System.Threading.Tasks.Task SaveBeforeAnimationPosition()
public [async] System.Threading.Tasks.Task SpawnNameAndYear()
public [async] System.Threading.Tasks.Task SpawnSlots(System.Boolean isAnimated)
public static MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEraColumn Create(MegaCrit.Sts2.Core.Timeline.EpochSlotData data)
public System.Void AddSlot(MegaCrit.Sts2.Core.Timeline.EpochSlotData epochSlotData)
public System.Void Init(MegaCrit.Sts2.Core.Timeline.EpochSlotData epochSlot)
public System.Void SetPredictedPosition(Godot.Vector2 setPredictedPosition)
public System.Void SpawnIcon()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEraColumn+<SaveBeforeAnimationPosition>d__22

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEraColumn <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEraColumn+<SpawnNameAndYear>d__21

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEraColumn <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEraColumn+<SpawnSlots>d__20

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEraColumn <>4__this
private System.Collections.Generic.IEnumerator<Godot.Node> <>7__wrap1
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public System.Boolean isAnimated
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEraColumn+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName RectChange
public static readonly Godot.StringName SetPredictedPosition
public static readonly Godot.StringName SpawnIcon
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEraColumn+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _icon
public static readonly Godot.StringName _iconTween
public static readonly Godot.StringName _isAnimated
public static readonly Godot.StringName _labelSpawned
public static readonly Godot.StringName _labelTween
public static readonly Godot.StringName _name
public static readonly Godot.StringName _predictedPosition
public static readonly Godot.StringName _prevGlobalPos
public static readonly Godot.StringName _prevLocalPos
public static readonly Godot.StringName _targetPosition
public static readonly Godot.StringName _year
public static readonly Godot.StringName era
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEraColumn+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NResetProgressButton

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.addons.mega_text.MegaLabel _disclaimer
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnGuiInput(Godot.InputEvent inputEvent)
private System.Void OnMouseEntered()
private System.Void OnMouseExited()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NResetProgressButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnGuiInput
public static readonly Godot.StringName OnMouseEntered
public static readonly Godot.StringName OnMouseExited
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NResetProgressButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _disclaimer
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NResetProgressButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NSlotsContainer

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private static const System.Single _bounceBackStrength = 36
private Godot.Vector2 _dragStartPosition
private Godot.Control _epochSlots
private System.Boolean _isDragging
private static const System.Single _lerpSmoothness = 20
private static const System.Single _scrollSpeed = 50
private Godot.Vector2 _targetPosition
private static const System.Single _trackpadScrollSpeed = 20
private Godot.Tween _tween
private Godot.Control _whatsMoved
System.Single GetInitX { public get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnToggleVisibility()
private System.Void ProcessGuiFocus(Godot.Control focusedControl)
private System.Void ProcessPanEvent(Godot.InputEvent inputEvent)
private System.Void ProcessScrollEvent(Godot.InputEvent inputEvent)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public [async] System.Threading.Tasks.Task LerpToSlot(System.Single slotPositionX)
public System.Single get_GetInitX()
public System.Void Reset()
public System.Void SetEnabled(System.Boolean enabled)
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _GuiInput(Godot.InputEvent inputEvent)
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NSlotsContainer+<LerpToSlot>d__20

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NSlotsContainer <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
public System.Single slotPositionX
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NSlotsContainer+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _GuiInput
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnToggleVisibility
public static readonly Godot.StringName ProcessGuiFocus
public static readonly Godot.StringName ProcessPanEvent
public static readonly Godot.StringName ProcessScrollEvent
public static readonly Godot.StringName Reset
public static readonly Godot.StringName SetEnabled
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NSlotsContainer+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _dragStartPosition
public static readonly Godot.StringName _epochSlots
public static readonly Godot.StringName _isDragging
public static readonly Godot.StringName _targetPosition
public static readonly Godot.StringName _tween
public static readonly Godot.StringName _whatsMoved
public static readonly Godot.StringName GetInitX
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NSlotsContainer+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NTimelineLineMask

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Process(System.Double delta)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NTimelineLineMask+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Process
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NTimelineLineMask+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NTimelineLineMask+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NTimelineScreen

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private MegaCrit.Sts2.Core.Nodes.CommonUi.NBackButton _backButton
private Godot.ColorRect _backstop
private Godot.Tween _backstopTween
private Godot.HBoxContainer _epochSlotContainer
private Godot.Control _inputBlocker
private MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEpochInspectScreen _inspectScreen
private System.Boolean _isUiVisible
private Godot.Control _line
private Godot.Control _lineContainer
private Godot.Tween _lineGrowTween
private static const System.String _placeEpochSparksPath = "res://scenes/timeline_screen/place_epoch_sparks.tscn"
private MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEpochSlot _queuedInspectScreen
private MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEpochReminderText _reminderText
private Godot.Control _reminderVfxHolder
private MegaCrit.Sts2.Core.Saves.ProgressState _save
private static readonly System.String _scenePath
private MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NSlotsContainer _slotsContainer
private MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NTimelineTutorial _tutorial
private System.Collections.Generic.Dictionary<MegaCrit.Sts2.Core.Timeline.EpochEra, MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEraColumn> _uniqueEpochEras
private Godot.Control _unlockScreenHolder
private System.Collections.Generic.Queue<MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockScreen> _unlockScreens
private MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockScreen <CurrentUnlockScreen>k__BackingField
System.String[] AssetPaths { public static get; }
MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockScreen CurrentUnlockScreen { public get; public set; }
Godot.Control InitialFocusedControl { protected virtual get; }
MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NTimelineScreen Instance { public static get; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task FirstTimeLogic()
private [async] System.Threading.Tasks.Task GrowTimelineAndAddEraIcons(System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEraColumn> newlyCreatedColumns)
private [async] System.Threading.Tasks.Task InitScreen()
private [async] System.Threading.Tasks.Task NavigateToRevealableSlot()
private MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEpochSlot GetSlot(MegaCrit.Sts2.Core.Timeline.EpochEra era, System.Int32 position)
private static System.Collections.Generic.IEnumerable<System.String> GetAllEraTexturePaths()
private static System.String GetEraTexturePath(MegaCrit.Sts2.Core.Timeline.EpochEra era)
private static System.Void OnBackButtonPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton obj)
private System.Boolean IsInspectScreenQueued()
private System.Collections.Generic.List<Godot.Vector2> PredictHBoxLayout(Godot.HBoxContainer hbox)
private System.Void InitLineAndIcons(System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEraColumn> newlyCreatedColumns)
private System.Void RefreshBackButton()
private System.Void ResetScreen()
protected virtual Godot.Control get_InitialFocusedControl()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnSubmenuHidden()
protected virtual System.Void OnSubmenuShown()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public [async] System.Threading.Tasks.Task AddEpochSlots(System.Collections.Generic.List<MegaCrit.Sts2.Core.Timeline.EpochSlotData> slotsToAdd, System.Boolean isAnimated)
public [async] System.Threading.Tasks.Task HideBackstopAndShowUi(System.Boolean showBackButton)
public [async] System.Threading.Tasks.Task SpawnFirstTimeTimeline()
public Godot.Control GetReminderVfxHolder()
public MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockScreen get_CurrentUnlockScreen()
public static MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NTimelineScreen Create()
public static MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NTimelineScreen get_Instance()
public static System.String[] get_AssetPaths()
public static System.ValueTuple<Godot.Texture2D, System.String> GetEraIcon(MegaCrit.Sts2.Core.Timeline.EpochEra era)
public System.Boolean IsScreenQueued()
public System.Void DisableInput()
public System.Void EnableInput()
public System.Void OpenInspectScreen(MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEpochSlot slot, System.Boolean playAnimation)
public System.Void OpenQueuedScreen()
public System.Void QueueCardUnlock(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.CardModel> cards)
public System.Void QueueCharacterUnlock<T>(MegaCrit.Sts2.Core.Timeline.EpochModel epoch) where T: [None] MegaCrit.Sts2.Core.Models.CharacterModel
public System.Void QueueMiscUnlock(System.String text)
public System.Void QueuePotionUnlock(System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.PotionModel> potions)
public System.Void QueueRelicUnlock(System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.RelicModel> relics)
public System.Void QueueTimelineExpansion(System.Collections.Generic.List<MegaCrit.Sts2.Core.Timeline.EpochSlotData> eraData)
public System.Void set_CurrentUnlockScreen(MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockScreen value)
public System.Void SetScreenDraggability()
public System.Void ShowBackstopAndHideUi()
public System.Void ShowHeaderAndActionsUi()
public virtual System.Void _Ready()
public virtual System.Void OnSubmenuClosed()
public virtual System.Void OnSubmenuOpened()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NTimelineScreen+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NTimelineScreen+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Saves.SerializableEpoch, System.Boolean> <>9__30_0
public static System.Func<MegaCrit.Sts2.Core.Timeline.EpochSlotData, System.Int32> <>9__38_0
public static System.Func<Godot.Control, System.Boolean> <>9__41_0
public static System.Func<Godot.Node, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEpochSlot>> <>9__67_0
public static System.Func<MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEpochSlot, System.Boolean> <>9__67_1
private static .cctor()
public .ctor()
internal System.Boolean <get_InitialFocusedControl>b__67_1(MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEpochSlot s)
internal System.Boolean <OnSubmenuOpened>b__30_0(MegaCrit.Sts2.Core.Saves.SerializableEpoch e)
internal System.Boolean <PredictHBoxLayout>b__41_0(Godot.Control c)
internal System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEpochSlot> <get_InitialFocusedControl>b__67_0(Godot.Node c)
internal System.Int32 <InitScreen>b__38_0(MegaCrit.Sts2.Core.Timeline.EpochSlotData a)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NTimelineScreen+<>O

类型属性：`NestedPrivate, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static System.Action<MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton> <0>__OnBackButtonPressed
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NTimelineScreen+<AddEpochSlots>d__40

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NTimelineScreen <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public System.Boolean isAnimated
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Timeline.EpochSlotData> slotsToAdd
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NTimelineScreen+<FirstTimeLogic>d__36

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NTimelineScreen <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NTimelineScreen+<GetAllEraTexturePaths>d__46

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：`System.Collections.Generic.IEnumerable<System.String>`, `System.Collections.IEnumerable`, `System.Collections.Generic.IEnumerator<System.String>`, `System.Collections.IEnumerator`, `System.IDisposable`

```text
private System.Int32 <>1__state
private System.String <>2__current
private MegaCrit.Sts2.Core.Timeline.EpochEra[] <>7__wrap1
private System.Int32 <>7__wrap2
private System.Int32 <>l__initialThreadId
System.String System.Collections.Generic.IEnumerator<System.String>.Current { private virtual get; }
System.Object System.Collections.IEnumerator.Current { private virtual get; }
public .ctor(System.Int32 <>1__state)
private virtual System.Boolean MoveNext()
private virtual System.Collections.Generic.IEnumerator<System.String> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator()
private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
private virtual System.Object System.Collections.IEnumerator.get_Current()
private virtual System.String System.Collections.Generic.IEnumerator<System.String>.get_Current()
private virtual System.Void System.Collections.IEnumerator.Reset()
private virtual System.Void System.IDisposable.Dispose()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NTimelineScreen+<GrowTimelineAndAddEraIcons>d__42

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NTimelineScreen <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEraColumn> newlyCreatedColumns
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NTimelineScreen+<HideBackstopAndShowUi>d__57

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NTimelineScreen <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
public System.Boolean showBackButton
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NTimelineScreen+<InitScreen>d__38

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NTimelineScreen <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NTimelineScreen+<NavigateToRevealableSlot>d__39

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NTimelineScreen <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NTimelineScreen+<SpawnFirstTimeTimeline>d__37

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NTimelineScreen <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NTimelineScreen+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName DisableInput
public static readonly Godot.StringName EnableInput
public static readonly Godot.StringName GetEraTexturePath
public static readonly Godot.StringName GetReminderVfxHolder
public static readonly Godot.StringName GetSlot
public static readonly Godot.StringName IsInspectScreenQueued
public static readonly Godot.StringName IsScreenQueued
public static readonly Godot.StringName OnBackButtonPressed
public static readonly Godot.StringName OnSubmenuClosed
public static readonly Godot.StringName OnSubmenuHidden
public static readonly Godot.StringName OnSubmenuOpened
public static readonly Godot.StringName OnSubmenuShown
public static readonly Godot.StringName OpenInspectScreen
public static readonly Godot.StringName OpenQueuedScreen
public static readonly Godot.StringName QueueMiscUnlock
public static readonly Godot.StringName RefreshBackButton
public static readonly Godot.StringName ResetScreen
public static readonly Godot.StringName SetScreenDraggability
public static readonly Godot.StringName ShowBackstopAndHideUi
public static readonly Godot.StringName ShowHeaderAndActionsUi
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NTimelineScreen+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+PropertyName`。

接口：

```text
public static readonly Godot.StringName _backButton
public static readonly Godot.StringName _backstop
public static readonly Godot.StringName _backstopTween
public static readonly Godot.StringName _epochSlotContainer
public static readonly Godot.StringName _inputBlocker
public static readonly Godot.StringName _inspectScreen
public static readonly Godot.StringName _isUiVisible
public static readonly Godot.StringName _line
public static readonly Godot.StringName _lineContainer
public static readonly Godot.StringName _lineGrowTween
public static readonly Godot.StringName _queuedInspectScreen
public static readonly Godot.StringName _reminderText
public static readonly Godot.StringName _reminderVfxHolder
public static readonly Godot.StringName _slotsContainer
public static readonly Godot.StringName _tutorial
public static readonly Godot.StringName _unlockScreenHolder
public static readonly Godot.StringName CurrentUnlockScreen
public static readonly Godot.StringName InitialFocusedControl
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NTimelineScreen+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NTimelineTutorial

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NAcknowledgeButton _acknowledgeButton
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _text
private MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NTimelineScreen _timeline
private Godot.Tween _tween
Godot.Control DefaultFocusedControl { public virtual get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void <AnimateTutorial>b__7_0()
private System.Void <CloseTutorial>b__6_0()
private System.Void AnimateTutorial()
private System.Void CloseTutorial(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void Init(MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NTimelineScreen screen)
public virtual Godot.Control get_DefaultFocusedControl()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NTimelineTutorial+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AnimateTutorial
public static readonly Godot.StringName CloseTutorial
public static readonly Godot.StringName Init
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NTimelineTutorial+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _acknowledgeButton
public static readonly Godot.StringName _text
public static readonly Godot.StringName _timeline
public static readonly Godot.StringName _tween
public static readonly Godot.StringName DefaultFocusedControl
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NTimelineTutorial+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NUnlockConfirmButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private Godot.Tween _hoverTween
private Godot.Tween _tween
System.String[] Hotkeys { protected virtual get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.String[] get_Hotkeys()
protected virtual System.Void OnFocus()
protected virtual System.Void OnPress()
protected virtual System.Void OnRelease()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NUnlockConfirmButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnUnfocus
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NUnlockConfirmButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _hoverTween
public static readonly Godot.StringName _tween
public static readonly Godot.StringName Hotkeys
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NUnlockConfirmButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NUnlockInfo

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private Godot.TextureRect _icon
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _label
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
public [async] System.Threading.Tasks.Task AnimInViaPaginator(System.String text)
public System.Void AnimIn(System.String text)
public System.Void HideImmediately()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NUnlockInfo+<AnimInViaPaginator>d__6

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NUnlockInfo <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
public System.String text
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NUnlockInfo+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AnimIn
public static readonly Godot.StringName HideImmediately
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NUnlockInfo+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _icon
public static readonly Godot.StringName _label
public static readonly Godot.StringName _tween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NUnlockInfo+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```
