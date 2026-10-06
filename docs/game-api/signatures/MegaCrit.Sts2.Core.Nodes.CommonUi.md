# MegaCrit.Sts2.Core.Nodes.CommonUi

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.CommonUi.CardPreviewStyle

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Nodes.CommonUi.CardPreviewStyle EventLayout = 3
public static const MegaCrit.Sts2.Core.Nodes.CommonUi.CardPreviewStyle GridLayout = 4
public static const MegaCrit.Sts2.Core.Nodes.CommonUi.CardPreviewStyle HorizontalLayout = 1
public static const MegaCrit.Sts2.Core.Nodes.CommonUi.CardPreviewStyle MessyLayout = 2
public static const MegaCrit.Sts2.Core.Nodes.CommonUi.CardPreviewStyle None = 0
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NAbandonRunConfirmPopup

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu _mainMenuNode
private static readonly System.String _scenePath
private Godot.Tween _tween
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
public static MegaCrit.Sts2.Core.Nodes.CommonUi.NAbandonRunConfirmPopup Create(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu mainMenu)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual Godot.Control get_DefaultFocusedControl()
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NAbandonRunConfirmPopup+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName OnNoButtonPressed
public static readonly Godot.StringName OnYesButtonPressed
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NAbandonRunConfirmPopup+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _mainMenuNode
public static readonly Godot.StringName _tween
public static readonly Godot.StringName _verticalPopup
public static readonly Godot.StringName DefaultFocusedControl
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NAbandonRunConfirmPopup+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NBackButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private static const System.Double _animInOutDur = 0.35
private Godot.Control _buttonImage
private Godot.Color _defaultOutlineColor
private Godot.Color _downColor
private static readonly Godot.Vector2 _downScale
private static readonly Godot.Vector2 _hideOffset
private Godot.Vector2 _hidePos
private Godot.Color _hoveredOutlineColor
private static readonly Godot.Vector2 _hoverScale
private Godot.Tween _hoverTween
private Godot.Tween _moveTween
private Godot.Control _outline
private Godot.Color _outlineColor
private Godot.Color _outlineTransparentColor
private Godot.Vector2 _posOffset
private Godot.Vector2 _showPos
System.String ClickedSfx { protected virtual get; }
System.String ControllerIconHotkey { protected virtual get; }
System.String[] Hotkeys { protected virtual get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnWindowChange()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.String get_ClickedSfx()
protected virtual System.String get_ControllerIconHotkey()
protected virtual System.String[] get_Hotkeys()
protected virtual System.Void OnDisable()
protected virtual System.Void OnEnable()
protected virtual System.Void OnFocus()
protected virtual System.Void OnPress()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void MoveToHidePosition()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NBackButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName MoveToHidePosition
public static readonly Godot.StringName OnDisable
public static readonly Godot.StringName OnEnable
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName OnWindowChange
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NBackButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _buttonImage
public static readonly Godot.StringName _defaultOutlineColor
public static readonly Godot.StringName _downColor
public static readonly Godot.StringName _hidePos
public static readonly Godot.StringName _hoveredOutlineColor
public static readonly Godot.StringName _hoverTween
public static readonly Godot.StringName _moveTween
public static readonly Godot.StringName _outline
public static readonly Godot.StringName _outlineColor
public static readonly Godot.StringName _outlineTransparentColor
public static readonly Godot.StringName _posOffset
public static readonly Godot.StringName _showPos
public static readonly Godot.StringName ClickedSfx
public static readonly Godot.StringName ControllerIconHotkey
public static readonly Godot.StringName Hotkeys
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NBackButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NCardPreviewContainer

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
private System.Void ReformatElements(Godot.Node _)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NCardPreviewContainer+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName ReformatElements
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NCardPreviewContainer+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NCardPreviewContainer+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NCardViewSortButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private Godot.Control _button
private static readonly Godot.StringName _h
private Godot.ShaderMaterial _hsv
private System.Boolean _isDescending
private MegaCrit.Sts2.addons.mega_text.MegaLabel _label
private static readonly Godot.StringName _s
private MegaCrit.Sts2.Core.Nodes.Combat.NSelectionReticle _selectionReticle
private Godot.TextureRect _sortIcon
private Godot.Tween _tween
private static readonly Godot.StringName _v
System.Boolean IsDescending { public get; public set; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnToggle()
private System.Void UpdateShaderS(System.Single value)
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
public System.Boolean get_IsDescending()
public System.Void set_IsDescending(System.Boolean value)
public System.Void SetHue(Godot.ShaderMaterial mat)
public System.Void SetLabel(System.String text)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NCardViewSortButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnToggle
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName SetHue
public static readonly Godot.StringName SetLabel
public static readonly Godot.StringName UpdateShaderS
public static readonly Godot.StringName UpdateShaderV
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NCardViewSortButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _button
public static readonly Godot.StringName _hsv
public static readonly Godot.StringName _isDescending
public static readonly Godot.StringName _label
public static readonly Godot.StringName _selectionReticle
public static readonly Godot.StringName _sortIcon
public static readonly Godot.StringName _tween
public static readonly Godot.StringName IsDescending
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NCardViewSortButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NCommonBanner

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private static readonly Godot.Vector2 _hideOffset
private Godot.Vector2 _hidePos
private Godot.Vector2 _imgOffset
private Godot.Tween _labelTween
private Godot.Vector2 _showPos
private Godot.Tween _tween
public MegaCrit.Sts2.addons.mega_text.MegaLabel label
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
public System.Void AnimateIn()
public System.Void AnimateOut()
public System.Void ChangeText(System.String text)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NCommonBanner+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AnimateIn
public static readonly Godot.StringName AnimateOut
public static readonly Godot.StringName ChangeText
public static readonly Godot.StringName OnWindowChange
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NCommonBanner+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _hidePos
public static readonly Godot.StringName _imgOffset
public static readonly Godot.StringName _labelTween
public static readonly Godot.StringName _showPos
public static readonly Godot.StringName _tween
public static readonly Godot.StringName label
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NCommonBanner+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NConfirmButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private static const System.Single _animInOutDur = 0.35
private Godot.Control _buttonImage
private Godot.Color _defaultOutlineColor
private Godot.Color _downColor
private static readonly Godot.Vector2 _downScale
private static readonly Godot.Vector2 _hideOffset
private Godot.Vector2 _hidePos
private System.String[] _hotkeys
private Godot.Color _hoveredOutlineColor
private static readonly Godot.Vector2 _hoverScale
private Godot.Tween _moveTween
private Godot.Control _outline
private Godot.Color _outlineColor
private Godot.Color _outlineTransparentColor
private Godot.Vector2 _posOffset
private System.Threading.CancellationTokenSource _pressDownCancelToken
private static const System.Single _pressDownDur = 0.25
private Godot.Vector2 _showPos
private System.Threading.CancellationTokenSource _unhoverAnimCancelToken
private static const System.Single _unhoverAnimDur = 0.5
private Godot.Viewport _viewport
System.String[] Hotkeys { protected virtual get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task AnimPressDown(System.Threading.CancellationTokenSource cancelToken)
private [async] System.Threading.Tasks.Task AnimUnhover(System.Threading.CancellationTokenSource cancelToken)
private System.Void OnWindowChange()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.String[] get_Hotkeys()
protected virtual System.Void OnDisable()
protected virtual System.Void OnEnable()
protected virtual System.Void OnFocus()
protected virtual System.Void OnPress()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void OverrideHotkeys(System.String[] hotkeys)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NConfirmButton+<AnimPressDown>d__32

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.CommonUi.NConfirmButton <>4__this
private System.Single <>7__wrap1
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
public System.Threading.CancellationTokenSource cancelToken
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NConfirmButton+<AnimUnhover>d__30

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.CommonUi.NConfirmButton <>4__this
private System.Single <>7__wrap4
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
private Godot.Color <startButtonColor>5__3
private Godot.Color <startColor>5__4
private Godot.Vector2 <startScale>5__2
public System.Threading.CancellationTokenSource cancelToken
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NConfirmButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnDisable
public static readonly Godot.StringName OnEnable
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName OnWindowChange
public static readonly Godot.StringName OverrideHotkeys
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NConfirmButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _buttonImage
public static readonly Godot.StringName _defaultOutlineColor
public static readonly Godot.StringName _downColor
public static readonly Godot.StringName _hidePos
public static readonly Godot.StringName _hotkeys
public static readonly Godot.StringName _hoveredOutlineColor
public static readonly Godot.StringName _moveTween
public static readonly Godot.StringName _outline
public static readonly Godot.StringName _outlineColor
public static readonly Godot.StringName _outlineTransparentColor
public static readonly Godot.StringName _posOffset
public static readonly Godot.StringName _showPos
public static readonly Godot.StringName _viewport
public static readonly Godot.StringName Hotkeys
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NConfirmButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NControllerManager

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.ControllerInput.IControllerInputStrategy _inputStrategy
private System.Boolean _inputTypeCheckingDisabled
private MegaCrit.Sts2.addons.mega_text.MegaLabel _label
private Godot.Vector2 _lastMousePosition
private Godot.Tween _notifyTween
private static readonly Godot.Vector2 _offscreenPos
private static const System.Single _warpDisplacementThresholdSq = 250000
private MegaCrit.Sts2.Core.ControllerInput.InputType <InputType>k__BackingField
private MegaCrit.Sts2.Core.Nodes.CommonUi.NControllerManager+ControllerDetectedEventHandler backing_ControllerDetected
private MegaCrit.Sts2.Core.Nodes.CommonUi.NControllerManager+ControllerTypeChangedEventHandler backing_ControllerTypeChanged
private MegaCrit.Sts2.Core.Nodes.CommonUi.NControllerManager+MouseDetectedEventHandler backing_MouseDetected
MegaCrit.Sts2.Core.ControllerInput.ControllerMappingType ControllerMappingType { public get; }
System.Collections.Generic.Dictionary<Godot.StringName, Godot.StringName> GetDefaultControllerInputMap { public get; }
MegaCrit.Sts2.Core.ControllerInput.InputType InputType { public get; private set; }
MegaCrit.Sts2.Core.Nodes.CommonUi.NControllerManager Instance { public static get; }
System.Boolean IsUsingDirectionalNavigation { public get; }
System.Boolean ShouldAllowControllerRebinding { public get; }
System.Boolean ShouldShowInputGlyphs { public get; }
event MegaCrit.Sts2.Core.Nodes.CommonUi.NControllerManager+ControllerDetectedEventHandler ControllerDetected
event MegaCrit.Sts2.Core.Nodes.CommonUi.NControllerManager+ControllerTypeChangedEventHandler ControllerTypeChanged
event MegaCrit.Sts2.Core.Nodes.CommonUi.NControllerManager+MouseDetectedEventHandler MouseDetected
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotSignalList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void CheckForArrowKeyInput(Godot.InputEvent inputEvent)
private System.Void CheckForControllerInput(Godot.InputEvent inputEvent)
private System.Void CheckForMouseInput(Godot.InputEvent inputEvent)
private System.Void ControlModeChanged()
private System.Void OnScreenContextChanged()
private System.Void set_InputType(MegaCrit.Sts2.Core.ControllerInput.InputType value)
private System.Void SwitchToMouseMode()
protected System.Void EmitSignalControllerDetected()
protected System.Void EmitSignalControllerTypeChanged()
protected System.Void EmitSignalMouseDetected()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean HasGodotClassSignal(in Godot.NativeInterop.godot_string_name signal)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RaiseGodotClassSignalCallbacks(in Godot.NativeInterop.godot_string_name signal, Godot.NativeInterop.NativeVariantPtrArgs args)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public [async] System.Threading.Tasks.Task Init()
public Godot.Texture2D GetHotkeyIcon(System.String hotkey)
public Godot.Vector2 GetLeftAnalogStickDirection()
public MegaCrit.Sts2.Core.ControllerInput.ControllerMappingType get_ControllerMappingType()
public MegaCrit.Sts2.Core.ControllerInput.InputType get_InputType()
public static MegaCrit.Sts2.Core.Nodes.CommonUi.NControllerManager get_Instance()
public System.Boolean get_IsUsingDirectionalNavigation()
public System.Boolean get_ShouldAllowControllerRebinding()
public System.Boolean get_ShouldShowInputGlyphs()
public System.Collections.Generic.Dictionary<Godot.StringName, Godot.StringName> get_GetDefaultControllerInputMap()
public System.Void add_ControllerDetected(MegaCrit.Sts2.Core.Nodes.CommonUi.NControllerManager+ControllerDetectedEventHandler value)
public System.Void add_ControllerTypeChanged(MegaCrit.Sts2.Core.Nodes.CommonUi.NControllerManager+ControllerTypeChangedEventHandler value)
public System.Void add_MouseDetected(MegaCrit.Sts2.Core.Nodes.CommonUi.NControllerManager+MouseDetectedEventHandler value)
public System.Void ForceMouseMode()
public System.Void OnControllerTypeChanged()
public System.Void remove_ControllerDetected(MegaCrit.Sts2.Core.Nodes.CommonUi.NControllerManager+ControllerDetectedEventHandler value)
public System.Void remove_ControllerTypeChanged(MegaCrit.Sts2.Core.Nodes.CommonUi.NControllerManager+ControllerTypeChangedEventHandler value)
public System.Void remove_MouseDetected(MegaCrit.Sts2.Core.Nodes.CommonUi.NControllerManager+MouseDetectedEventHandler value)
public System.Void StartListeningForRebind()
public System.Void StopListeningForRebind()
public virtual System.Void _ExitTree()
public virtual System.Void _Input(Godot.InputEvent inputEvent)
public virtual System.Void _Process(System.Double delta)
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NControllerManager+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.CommonUi.NControllerManager+<>c <>9
public static System.Action <>9__33_0
private static .cctor()
public .ctor()
internal System.Void <OnScreenContextChanged>b__33_0()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NControllerManager+<>c__DisplayClass28_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public Godot.InputEvent inputEvent
public .ctor()
internal System.Boolean <CheckForControllerInput>b__0(Godot.StringName i)
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NControllerManager+<Init>d__22

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.CommonUi.NControllerManager <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NControllerManager+ControllerDetectedEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NControllerManager+ControllerTypeChangedEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NControllerManager+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Input
public static readonly Godot.StringName _Process
public static readonly Godot.StringName CheckForArrowKeyInput
public static readonly Godot.StringName CheckForControllerInput
public static readonly Godot.StringName CheckForMouseInput
public static readonly Godot.StringName ControlModeChanged
public static readonly Godot.StringName ForceMouseMode
public static readonly Godot.StringName GetHotkeyIcon
public static readonly Godot.StringName GetLeftAnalogStickDirection
public static readonly Godot.StringName OnControllerTypeChanged
public static readonly Godot.StringName OnScreenContextChanged
public static readonly Godot.StringName StartListeningForRebind
public static readonly Godot.StringName StopListeningForRebind
public static readonly Godot.StringName SwitchToMouseMode
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NControllerManager+MouseDetectedEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NControllerManager+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _inputTypeCheckingDisabled
public static readonly Godot.StringName _label
public static readonly Godot.StringName _lastMousePosition
public static readonly Godot.StringName _notifyTween
public static readonly Godot.StringName ControllerMappingType
public static readonly Godot.StringName InputType
public static readonly Godot.StringName IsUsingDirectionalNavigation
public static readonly Godot.StringName ShouldAllowControllerRebinding
public static readonly Godot.StringName ShouldShowInputGlyphs
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NControllerManager+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public static readonly Godot.StringName ControllerDetected
public static readonly Godot.StringName ControllerTypeChanged
public static readonly Godot.StringName MouseDetected
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NCursorManager

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private Godot.Image _cursorInspect
private Godot.Image _cursorNotTilted
private Godot.Image _cursorTilted
private static readonly Godot.Vector2 _defaultHotSpot
private static readonly Godot.Vector2 _inspectHotSpot
private System.Boolean _isDown
private System.Boolean _isUsingController
private Godot.Image _lastSetCursor
private Godot.Image _overriddenCursorNotTilted
private Godot.Image _overriddenCursorTilted
private System.Nullable<Godot.Vector2> _overriddenHotSpot
private System.Boolean _shouldShowCursor
Godot.Image CursorNotTilted { private get; }
Godot.Image CursorTilted { private get; }
Godot.Vector2 HotSpot { private get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private Godot.Image get_CursorNotTilted()
private Godot.Image get_CursorTilted()
private Godot.Vector2 get_HotSpot()
private System.Void OnControllerDetected()
private System.Void OnMouseDetected()
private System.Void RefreshCursorShown()
private System.Void SetIsUsingController(System.Boolean isUsingController)
private System.Void UpdateCursor()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void OverrideCursor(Godot.Image cursorTilted, Godot.Image cursorNotTilted, Godot.Vector2 hotspot)
public System.Void SetCursorShown(System.Boolean show)
public System.Void StopOverridingCursor()
public virtual System.Void _EnterTree()
public virtual System.Void _Input(Godot.InputEvent inputEvent)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NCursorManager+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _Input
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnControllerDetected
public static readonly Godot.StringName OnMouseDetected
public static readonly Godot.StringName OverrideCursor
public static readonly Godot.StringName RefreshCursorShown
public static readonly Godot.StringName SetCursorShown
public static readonly Godot.StringName SetIsUsingController
public static readonly Godot.StringName StopOverridingCursor
public static readonly Godot.StringName UpdateCursor
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NCursorManager+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _cursorInspect
public static readonly Godot.StringName _cursorNotTilted
public static readonly Godot.StringName _cursorTilted
public static readonly Godot.StringName _isDown
public static readonly Godot.StringName _isUsingController
public static readonly Godot.StringName _lastSetCursor
public static readonly Godot.StringName _overriddenCursorNotTilted
public static readonly Godot.StringName _overriddenCursorTilted
public static readonly Godot.StringName _shouldShowCursor
public static readonly Godot.StringName CursorNotTilted
public static readonly Godot.StringName CursorTilted
public static readonly Godot.StringName HotSpot
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NCursorManager+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NDisconnectConfirmPopup

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _description
private MegaCrit.Sts2.addons.mega_text.MegaLabel _header
private MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu _mainMenuNode
private MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _noButton
private static readonly System.String _scenePath
private MegaCrit.Sts2.Core.Nodes.CommonUi.NVerticalPopup _verticalPopup
private MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _yesButton
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
public static MegaCrit.Sts2.Core.Nodes.CommonUi.NDisconnectConfirmPopup Create()
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual Godot.Control get_DefaultFocusedControl()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NDisconnectConfirmPopup+MethodName

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

## MegaCrit.Sts2.Core.Nodes.CommonUi.NDisconnectConfirmPopup+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _description
public static readonly Godot.StringName _header
public static readonly Godot.StringName _mainMenuNode
public static readonly Godot.StringName _noButton
public static readonly Godot.StringName _verticalPopup
public static readonly Godot.StringName _yesButton
public static readonly Godot.StringName DefaultFocusedControl
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NDisconnectConfirmPopup+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NDropdownContainer

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private System.Single _contentHeight
private Godot.VBoxContainer _dropdownItems
private System.Boolean _isDragging
private System.Single _maxHeight
private MegaCrit.Sts2.Core.Nodes.CommonUi.NDropdownScrollbar _scrollbar
private Godot.Control _scrollbarTrain
private System.Single _scrollLimitBottom
private static const System.Single _scrollLimitTop = 0
private Godot.Vector2 _startDragPos
private Godot.Vector2 _targetDragPos
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Boolean IsScrollbarNeeded()
private System.Void OnVisibilityChange()
private System.Void ProcessGuiFocus(Godot.Control focusedControl)
private System.Void ProcessMouseEvent(Godot.InputEvent inputEvent)
private System.Void ProcessScrollEvent(Godot.InputEvent inputEvent)
private System.Void UpdateScrollbar()
private System.Void UpdateScrollPosition(System.Double delta)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void RefreshLayout()
public System.Void UpdatePositionBasedOnTrain(System.Single trainPosition)
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _GuiInput(Godot.InputEvent inputEvent)
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NDropdownContainer+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _GuiInput
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName IsScrollbarNeeded
public static readonly Godot.StringName OnVisibilityChange
public static readonly Godot.StringName ProcessGuiFocus
public static readonly Godot.StringName ProcessMouseEvent
public static readonly Godot.StringName ProcessScrollEvent
public static readonly Godot.StringName RefreshLayout
public static readonly Godot.StringName UpdatePositionBasedOnTrain
public static readonly Godot.StringName UpdateScrollbar
public static readonly Godot.StringName UpdateScrollPosition
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NDropdownContainer+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _contentHeight
public static readonly Godot.StringName _dropdownItems
public static readonly Godot.StringName _isDragging
public static readonly Godot.StringName _maxHeight
public static readonly Godot.StringName _scrollbar
public static readonly Godot.StringName _scrollbarTrain
public static readonly Godot.StringName _scrollLimitBottom
public static readonly Godot.StringName _startDragPos
public static readonly Godot.StringName _targetDragPos
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NDropdownContainer+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NDropdownItem

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private Godot.ColorRect _highlight
protected MegaCrit.Sts2.addons.mega_text.MegaLabel _label
protected MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _richLabel
private MegaCrit.Sts2.Core.Nodes.CommonUi.NDropdownItem+SelectedEventHandler backing_Selected
System.String Text { public get; public set; }
event MegaCrit.Sts2.Core.Nodes.CommonUi.NDropdownItem+SelectedEventHandler Selected
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotSignalList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected System.Void EmitSignalSelected(MegaCrit.Sts2.Core.Nodes.CommonUi.NDropdownItem cardHolder)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean HasGodotClassSignal(in Godot.NativeInterop.godot_string_name signal)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnFocus()
protected virtual System.Void OnPress()
protected virtual System.Void OnRelease()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RaiseGodotClassSignalCallbacks(in Godot.NativeInterop.godot_string_name signal, Godot.NativeInterop.NativeVariantPtrArgs args)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.String get_Text()
public System.Void add_Selected(MegaCrit.Sts2.Core.Nodes.CommonUi.NDropdownItem+SelectedEventHandler value)
public System.Void remove_Selected(MegaCrit.Sts2.Core.Nodes.CommonUi.NDropdownItem+SelectedEventHandler value)
public System.Void set_Text(System.String value)
public System.Void UnhoverSelection()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NDropdownItem+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName UnhoverSelection
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NDropdownItem+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _highlight
public static readonly Godot.StringName _label
public static readonly Godot.StringName _richLabel
public static readonly Godot.StringName Text
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NDropdownItem+SelectedEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(MegaCrit.Sts2.Core.Nodes.CommonUi.NDropdownItem cardHolder, System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke(MegaCrit.Sts2.Core.Nodes.CommonUi.NDropdownItem cardHolder)
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NDropdownItem+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public static readonly Godot.StringName Selected
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NDropdownScrollbar

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Nodes.CommonUi.NDropdownContainer _dropdownContainer
private System.Single _scrollLimitBottom
private System.Single _scrollLimitTop
private Godot.Vector2 _startDragPos
private Godot.Vector2 _targetDragPos
private Godot.Control _train
public System.Boolean hasControl
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void ClampTrain()
private System.Void OnShow()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnFocus()
protected virtual System.Void OnPress()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void RefreshTrainBounds()
public System.Void SetTrainPositionFromPercentage(System.Single percentage)
public virtual System.Void _GuiInput(Godot.InputEvent inputEvent)
public virtual System.Void _Input(Godot.InputEvent inputEvent)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NDropdownScrollbar+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _GuiInput
public static readonly Godot.StringName _Input
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName ClampTrain
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnShow
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName RefreshTrainBounds
public static readonly Godot.StringName SetTrainPositionFromPercentage
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NDropdownScrollbar+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _dropdownContainer
public static readonly Godot.StringName _scrollLimitBottom
public static readonly Godot.StringName _scrollLimitTop
public static readonly Godot.StringName _startDragPos
public static readonly Godot.StringName _targetDragPos
public static readonly Godot.StringName _train
public static readonly Godot.StringName hasControl
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NDropdownScrollbar+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NErrorPopup

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NVerticalPopup`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private System.String _body
private MegaCrit.Sts2.Core.Localization.LocString _cancel
private static readonly System.String _scenePath
private System.Boolean _showReportBugButton
private System.String _title
private MegaCrit.Sts2.Core.Nodes.CommonUi.NVerticalPopup _verticalPopup
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
Godot.Control DefaultFocusedControl { public virtual get; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task OpenFeedbackScreen()
private System.Void OnCancelButtonPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OnOkButtonPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OnReportBugButtonPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Localization.LocString GetLocStringForReason(MegaCrit.Sts2.Core.Entities.Multiplayer.NetError reason, System.Boolean isHost)
public static MegaCrit.Sts2.Core.Localization.LocString LocStringFromNetError(MegaCrit.Sts2.Core.Entities.Multiplayer.NetErrorInfo info, out System.Boolean showReportBugButton)
public static MegaCrit.Sts2.Core.Nodes.CommonUi.NErrorPopup Create(MegaCrit.Sts2.Core.Entities.Multiplayer.NetErrorInfo info)
public static MegaCrit.Sts2.Core.Nodes.CommonUi.NErrorPopup Create(MegaCrit.Sts2.Core.Localization.LocString title, MegaCrit.Sts2.Core.Localization.LocString body, MegaCrit.Sts2.Core.Localization.LocString cancel, System.Boolean showReportBugButton)
public static MegaCrit.Sts2.Core.Nodes.CommonUi.NErrorPopup Create(System.String title, System.String body, System.Boolean showReportBugButton)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual Godot.Control get_DefaultFocusedControl()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NErrorPopup+<OpenFeedbackScreen>d__19

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.CommonUi.NErrorPopup <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Object <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
private Godot.SceneTree <sceneTree>5__2
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NErrorPopup+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NVerticalPopup+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName OnCancelButtonPressed
public static readonly Godot.StringName OnOkButtonPressed
public static readonly Godot.StringName OnReportBugButtonPressed
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NErrorPopup+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NVerticalPopup+PropertyName`。

接口：

```text
public static readonly Godot.StringName _body
public static readonly Godot.StringName _showReportBugButton
public static readonly Godot.StringName _title
public static readonly Godot.StringName _verticalPopup
public static readonly Godot.StringName DefaultFocusedControl
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NErrorPopup+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NVerticalPopup+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NGlobalUi

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private static const System.Single _maxNarrowRatio = 1.3333334
private static const System.Single _maxWideRatio = 2.3888888
private Godot.Window _window
private Godot.Control <AboveTopBarVfxContainer>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Screens.Capstones.NCapstoneContainer <CapstoneContainer>k__BackingField
private Godot.Control <CardPreviewContainer>k__BackingField
private Godot.Control <DebugInfo>k__BackingField
private Godot.Control <EventCardPreviewContainer>k__BackingField
private MegaCrit.Sts2.Core.Nodes.CommonUi.NGridCardPreviewContainer <GridCardPreviewContainer>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapScreen <MapScreen>k__BackingField
private MegaCrit.Sts2.Core.Nodes.CommonUi.NMessyCardPreviewContainer <MessyCardPreviewContainer>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerStateContainer <MultiplayerPlayerContainer>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Screens.Overlays.NOverlayStack <Overlays>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Relics.NRelicInventory <RelicInventory>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Screens.NCapstoneSubmenuStack <SubmenuStack>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Combat.NTargetManager <TargetManager>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerTimeoutOverlay <TimeoutOverlay>k__BackingField
private MegaCrit.Sts2.Core.Nodes.CommonUi.NTopBar <TopBar>k__BackingField
Godot.Control AboveTopBarVfxContainer { public get; private set; }
MegaCrit.Sts2.Core.Nodes.Screens.Capstones.NCapstoneContainer CapstoneContainer { public get; private set; }
Godot.Control CardPreviewContainer { public get; private set; }
Godot.Control DebugInfo { public get; private set; }
Godot.Control EventCardPreviewContainer { public get; private set; }
MegaCrit.Sts2.Core.Nodes.CommonUi.NGridCardPreviewContainer GridCardPreviewContainer { public get; private set; }
MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapScreen MapScreen { public get; private set; }
MegaCrit.Sts2.Core.Nodes.CommonUi.NMessyCardPreviewContainer MessyCardPreviewContainer { public get; private set; }
MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerStateContainer MultiplayerPlayerContainer { public get; private set; }
MegaCrit.Sts2.Core.Nodes.Screens.Overlays.NOverlayStack Overlays { public get; private set; }
MegaCrit.Sts2.Core.Nodes.Relics.NRelicInventory RelicInventory { public get; private set; }
MegaCrit.Sts2.Core.Nodes.Screens.NCapstoneSubmenuStack SubmenuStack { public get; private set; }
MegaCrit.Sts2.Core.Nodes.Combat.NTargetManager TargetManager { public get; private set; }
MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerTimeoutOverlay TimeoutOverlay { public get; private set; }
MegaCrit.Sts2.Core.Nodes.CommonUi.NTopBar TopBar { public get; private set; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnWindowChange()
private System.Void set_AboveTopBarVfxContainer(Godot.Control value)
private System.Void set_CapstoneContainer(MegaCrit.Sts2.Core.Nodes.Screens.Capstones.NCapstoneContainer value)
private System.Void set_CardPreviewContainer(Godot.Control value)
private System.Void set_DebugInfo(Godot.Control value)
private System.Void set_EventCardPreviewContainer(Godot.Control value)
private System.Void set_GridCardPreviewContainer(MegaCrit.Sts2.Core.Nodes.CommonUi.NGridCardPreviewContainer value)
private System.Void set_MapScreen(MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapScreen value)
private System.Void set_MessyCardPreviewContainer(MegaCrit.Sts2.Core.Nodes.CommonUi.NMessyCardPreviewContainer value)
private System.Void set_MultiplayerPlayerContainer(MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerStateContainer value)
private System.Void set_Overlays(MegaCrit.Sts2.Core.Nodes.Screens.Overlays.NOverlayStack value)
private System.Void set_RelicInventory(MegaCrit.Sts2.Core.Nodes.Relics.NRelicInventory value)
private System.Void set_SubmenuStack(MegaCrit.Sts2.Core.Nodes.Screens.NCapstoneSubmenuStack value)
private System.Void set_TargetManager(MegaCrit.Sts2.Core.Nodes.Combat.NTargetManager value)
private System.Void set_TimeoutOverlay(MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerTimeoutOverlay value)
private System.Void set_TopBar(MegaCrit.Sts2.Core.Nodes.CommonUi.NTopBar value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public Godot.Control get_AboveTopBarVfxContainer()
public Godot.Control get_CardPreviewContainer()
public Godot.Control get_DebugInfo()
public Godot.Control get_EventCardPreviewContainer()
public MegaCrit.Sts2.Core.Nodes.Combat.NTargetManager get_TargetManager()
public MegaCrit.Sts2.Core.Nodes.CommonUi.NGridCardPreviewContainer get_GridCardPreviewContainer()
public MegaCrit.Sts2.Core.Nodes.CommonUi.NMessyCardPreviewContainer get_MessyCardPreviewContainer()
public MegaCrit.Sts2.Core.Nodes.CommonUi.NTopBar get_TopBar()
public MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerStateContainer get_MultiplayerPlayerContainer()
public MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerTimeoutOverlay get_TimeoutOverlay()
public MegaCrit.Sts2.Core.Nodes.Relics.NRelicInventory get_RelicInventory()
public MegaCrit.Sts2.Core.Nodes.Screens.Capstones.NCapstoneContainer get_CapstoneContainer()
public MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapScreen get_MapScreen()
public MegaCrit.Sts2.Core.Nodes.Screens.NCapstoneSubmenuStack get_SubmenuStack()
public MegaCrit.Sts2.Core.Nodes.Screens.Overlays.NOverlayStack get_Overlays()
public System.Void Initialize(MegaCrit.Sts2.Core.Runs.RunState runState)
public System.Void ReparentCard(MegaCrit.Sts2.Core.Nodes.Cards.NCard card)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NGlobalUi+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnWindowChange
public static readonly Godot.StringName ReparentCard
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NGlobalUi+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _window
public static readonly Godot.StringName AboveTopBarVfxContainer
public static readonly Godot.StringName CapstoneContainer
public static readonly Godot.StringName CardPreviewContainer
public static readonly Godot.StringName DebugInfo
public static readonly Godot.StringName EventCardPreviewContainer
public static readonly Godot.StringName GridCardPreviewContainer
public static readonly Godot.StringName MapScreen
public static readonly Godot.StringName MessyCardPreviewContainer
public static readonly Godot.StringName MultiplayerPlayerContainer
public static readonly Godot.StringName Overlays
public static readonly Godot.StringName RelicInventory
public static readonly Godot.StringName SubmenuStack
public static readonly Godot.StringName TargetManager
public static readonly Godot.StringName TimeoutOverlay
public static readonly Godot.StringName TopBar
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NGlobalUi+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NGoldArrowButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private Godot.Tween _animTween
private Godot.Vector2 _hoverScale
private Godot.ShaderMaterial _hsv
protected Godot.TextureRect _icon
private static readonly Godot.StringName _v
private System.Single _valueDefault
private System.Single _valueHovered
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
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
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NGoldArrowButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName UpdateShaderParam
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NGoldArrowButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _animTween
public static readonly Godot.StringName _hoverScale
public static readonly Godot.StringName _hsv
public static readonly Godot.StringName _icon
public static readonly Godot.StringName _valueDefault
public static readonly Godot.StringName _valueHovered
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NGoldArrowButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NGridCardPreviewContainer

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private System.Nullable<System.Int32> _forcedMaxColumns
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
private System.Void CheckAnyChildrenPresent(Godot.Node _)
private System.Void ReformatElements(Godot.Node _)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void ForceMaxColumnsUntilEmpty(System.Int32 maxColumns)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NGridCardPreviewContainer+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName CheckAnyChildrenPresent
public static readonly Godot.StringName ForceMaxColumnsUntilEmpty
public static readonly Godot.StringName ReformatElements
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NGridCardPreviewContainer+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NGridCardPreviewContainer+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NHotkeyIcon

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private Godot.TextureRect _controllerIcon
private MegaCrit.Sts2.addons.mega_text.MegaLabel _keyboardHotkeyLabel
private Godot.Control _keyboardIcon
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void UpdateInput(System.String input)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NHotkeyIcon+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName UpdateInput
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NHotkeyIcon+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _controllerIcon
public static readonly Godot.StringName _keyboardHotkeyLabel
public static readonly Godot.StringName _keyboardIcon
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NHotkeyIcon+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NHotkeyManager

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private System.Collections.Generic.Dictionary<Godot.Node, System.Action> _blockingScreens
private readonly System.Collections.Generic.Dictionary<Godot.StringName, System.Collections.Generic.List<System.Action>> _hotkeyPressedBindings
private readonly System.Collections.Generic.Dictionary<Godot.StringName, System.Collections.Generic.List<System.Action>> _hotkeyReleasedBindings
MegaCrit.Sts2.Core.Nodes.CommonUi.NHotkeyManager Instance { public static get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.CommonUi.NHotkeyManager get_Instance()
public System.Void AddBlockingScreen(Godot.Node screen)
public System.Void ClearHotkeys()
public System.Void PushHotkeyPressedBinding(System.String hotkey, System.Action action)
public System.Void PushHotkeyReleasedBinding(System.String hotkey, System.Action action)
public System.Void RemoveBlockingScreen(Godot.Node screen)
public System.Void RemoveHotkeyPressedBinding(System.String hotkey, System.Action action)
public System.Void RemoveHotkeyReleasedBinding(System.String hotkey, System.Action action)
public virtual System.Void _UnhandledInput(Godot.InputEvent inputEvent)
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NHotkeyManager+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.CommonUi.NHotkeyManager+<>c <>9
public static System.Action <>9__10_0
private static .cctor()
public .ctor()
internal System.Void <AddBlockingScreen>b__10_0()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NHotkeyManager+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _UnhandledInput
public static readonly Godot.StringName AddBlockingScreen
public static readonly Godot.StringName ClearHotkeys
public static readonly Godot.StringName RemoveBlockingScreen
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NHotkeyManager+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NHotkeyManager+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NInputManager

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private System.Collections.Generic.Dictionary<Godot.StringName, Godot.StringName> _controllerInputMap
private readonly System.Collections.Generic.Dictionary<Godot.Key, Godot.StringName> _debugInputMap
private System.Collections.Generic.Dictionary<Godot.StringName, Godot.Key> _fKbInputMap
private System.Collections.Generic.Dictionary<Godot.StringName, Godot.Key> _mKbInputMap
private MegaCrit.Sts2.Core.Nodes.CommonUi.NControllerManager <ControllerManager>k__BackingField
private MegaCrit.Sts2.Core.Nodes.CommonUi.NInputManager+InputReboundEventHandler backing_InputRebound
public static readonly System.Collections.Generic.IReadOnlyList<Godot.StringName> remappableControllerInputs
public static readonly System.Collections.Generic.IReadOnlyList<Godot.StringName> remappableKbOnlyInputs
public static readonly System.Collections.Generic.IReadOnlyList<Godot.StringName> remappableMKbInputs
MegaCrit.Sts2.Core.Nodes.CommonUi.NControllerManager ControllerManager { public get; private set; }
System.Collections.Generic.Dictionary<Godot.StringName, Godot.Key> DefaultHotkeyInputMap { private static get; }
System.Collections.Generic.Dictionary<Godot.StringName, Godot.Key> DefaultKbOnlyInputMap { private static get; }
MegaCrit.Sts2.Core.Nodes.CommonUi.NInputManager Instance { public static get; }
event MegaCrit.Sts2.Core.Nodes.CommonUi.NInputManager+InputReboundEventHandler InputRebound
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotSignalList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task Init()
private static System.Collections.Generic.Dictionary<Godot.StringName, Godot.Key> get_DefaultHotkeyInputMap()
private static System.Collections.Generic.Dictionary<Godot.StringName, Godot.Key> get_DefaultKbOnlyInputMap()
private System.Void EnsureEndTurnAndConfirmControllerInputAreTheSame(Godot.StringName input, Godot.StringName controllerInput)
private System.Void EnsureEndTurnAndConfirmMkbKeyAreTheSame(Godot.StringName input, Godot.Key shortcutKey)
private System.Void OnControllerTypeChanged()
private System.Void ProcessDebugKeyInput(Godot.InputEvent inputEvent)
private System.Void ProcessFkbInput(Godot.InputEvent inputEvent)
private System.Void ProcessHotkeyInput(Godot.InputEvent inputEvent)
private System.Void SaveControllerInputMapping()
private System.Void SaveFKbInputMapping()
private System.Void SaveMKbInputMapping()
private System.Void set_ControllerManager(MegaCrit.Sts2.Core.Nodes.CommonUi.NControllerManager value)
protected System.Void EmitSignalInputRebound()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean HasGodotClassSignal(in Godot.NativeInterop.godot_string_name signal)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RaiseGodotClassSignalCallbacks(in Godot.NativeInterop.godot_string_name signal, Godot.NativeInterop.NativeVariantPtrArgs args)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public Godot.Key GetCurrentHotkey(Godot.StringName input)
public Godot.Key GetKbOnlyHotkey(Godot.StringName input)
public Godot.Key GetMKbHotkey(Godot.StringName input)
public Godot.Texture2D GetHotkeyIcon(System.String hotkey)
public MegaCrit.Sts2.Core.Nodes.CommonUi.NControllerManager get_ControllerManager()
public static MegaCrit.Sts2.Core.Nodes.CommonUi.NInputManager get_Instance()
public static System.Collections.Generic.Dictionary<Godot.StringName, Godot.StringName> MergeSavedControllerBindings(System.Collections.Generic.Dictionary<Godot.StringName, Godot.StringName> defaults, System.Collections.Generic.Dictionary<System.String, System.String> savedMapping)
public System.Void add_InputRebound(MegaCrit.Sts2.Core.Nodes.CommonUi.NInputManager+InputReboundEventHandler value)
public System.Void ModifyControllerButton(Godot.StringName input, Godot.StringName controllerInput)
public System.Void ModifyKbOnlyKey(Godot.StringName input, Godot.Key shortcutKey)
public System.Void ModifyMKbKey(Godot.StringName input, Godot.Key shortcutKey)
public System.Void remove_InputRebound(MegaCrit.Sts2.Core.Nodes.CommonUi.NInputManager+InputReboundEventHandler value)
public System.Void ResetToDefaults()
public virtual System.Void _EnterTree()
public virtual System.Void _Ready()
public virtual System.Void _UnhandledInput(Godot.InputEvent inputEvent)
public virtual System.Void _UnhandledKeyInput(Godot.InputEvent inputEvent)
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NInputManager+<>c__DisplayClass31_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public Godot.Key shortcutKey
public .ctor()
internal System.Boolean <ModifyMKbKey>b__0(System.Collections.Generic.KeyValuePair<Godot.StringName, Godot.Key> kvp)
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NInputManager+<>c__DisplayClass33_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public Godot.Key shortcutKey
public .ctor()
internal System.Boolean <ModifyKbOnlyKey>b__0(System.Collections.Generic.KeyValuePair<Godot.StringName, Godot.Key> kvp)
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NInputManager+<>c__DisplayClass34_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public Godot.StringName controllerInput
public .ctor()
internal System.Boolean <ModifyControllerButton>b__0(System.Collections.Generic.KeyValuePair<Godot.StringName, Godot.StringName> kvp)
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NInputManager+<Init>d__20

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.CommonUi.NInputManager <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NInputManager+InputReboundEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NInputManager+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName _UnhandledInput
public static readonly Godot.StringName _UnhandledKeyInput
public static readonly Godot.StringName EnsureEndTurnAndConfirmControllerInputAreTheSame
public static readonly Godot.StringName EnsureEndTurnAndConfirmMkbKeyAreTheSame
public static readonly Godot.StringName GetCurrentHotkey
public static readonly Godot.StringName GetHotkeyIcon
public static readonly Godot.StringName GetKbOnlyHotkey
public static readonly Godot.StringName GetMKbHotkey
public static readonly Godot.StringName ModifyControllerButton
public static readonly Godot.StringName ModifyKbOnlyKey
public static readonly Godot.StringName ModifyMKbKey
public static readonly Godot.StringName OnControllerTypeChanged
public static readonly Godot.StringName ProcessDebugKeyInput
public static readonly Godot.StringName ProcessFkbInput
public static readonly Godot.StringName ProcessHotkeyInput
public static readonly Godot.StringName ResetToDefaults
public static readonly Godot.StringName SaveControllerInputMapping
public static readonly Godot.StringName SaveFKbInputMapping
public static readonly Godot.StringName SaveMKbInputMapping
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NInputManager+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName ControllerManager
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NInputManager+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public static readonly Godot.StringName InputRebound
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NLoadingOverlay

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NLoadingOverlay+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NLoadingOverlay+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NLoadingOverlay+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NMessyCardPreviewContainer

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private System.Single _currentMaxPosition
private static const System.Int32 _resetNewCardMsec = 2000
private System.UInt64 _resetNewCardTimer
private System.Collections.Generic.IEnumerator<Godot.Vector2> _samples
private static const System.Single _spacing = 150
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void PositionNewChild(Godot.Node node)
private System.Void ResetSamples()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NMessyCardPreviewContainer+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName PositionNewChild
public static readonly Godot.StringName ResetSamples
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NMessyCardPreviewContainer+PoissonDiscSampler

类型属性：`NestedPublic, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private readonly System.Collections.Generic.List<Godot.Vector2> _activeSamples
private readonly System.Single _cellSize
private readonly Godot.Vector2[,] _grid
private static const System.Int32 _maxAttempts = 30
private readonly System.Single _radius2
private readonly Godot.Rect2 _rect
public .ctor(System.Single width, System.Single height, System.Single radius)
private Godot.Vector2 AddSample(Godot.Vector2 sample)
private System.Boolean IsFarEnough(Godot.Vector2 sample)
public System.Collections.Generic.IEnumerator<Godot.Vector2> Samples()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NMessyCardPreviewContainer+PoissonDiscSampler+<Samples>d__8

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：`System.Collections.Generic.IEnumerator<Godot.Vector2>`, `System.Collections.IEnumerator`, `System.IDisposable`

```text
private System.Int32 <>1__state
private Godot.Vector2 <>2__current
public MegaCrit.Sts2.Core.Nodes.CommonUi.NMessyCardPreviewContainer+PoissonDiscSampler <>4__this
private System.Boolean <found>5__3
private System.Int32 <i>5__2
Godot.Vector2 System.Collections.Generic.IEnumerator<Godot.Vector2>.Current { private virtual get; }
System.Object System.Collections.IEnumerator.Current { private virtual get; }
public .ctor(System.Int32 <>1__state)
private virtual Godot.Vector2 System.Collections.Generic.IEnumerator<Godot.Vector2>.get_Current()
private virtual System.Boolean MoveNext()
private virtual System.Object System.Collections.IEnumerator.get_Current()
private virtual System.Void System.Collections.IEnumerator.Reset()
private virtual System.Void System.IDisposable.Dispose()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NMessyCardPreviewContainer+PoissonDiscSampler+GridPos

类型属性：`NestedPrivate, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：

```text
public readonly System.Int32 x
public readonly System.Int32 y
public .ctor(Godot.Vector2 sample, System.Single cellSize)
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NMessyCardPreviewContainer+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _currentMaxPosition
public static readonly Godot.StringName _resetNewCardTimer
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NMessyCardPreviewContainer+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NMiscConfirmButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private static const System.Single _animInOutDur = 0.35
private Godot.Control _buttonImage
private Godot.Color _downColor
private static readonly Godot.Vector2 _downScale
private Godot.Vector2 _hidePos
private static readonly Godot.Vector2 _hoverScale
private Godot.Tween _moveTween
private System.Threading.CancellationTokenSource _pressDownCancelToken
private static const System.Single _pressDownDur = 0.25
private Godot.Vector2 _showPos
private System.Threading.CancellationTokenSource _unhoverAnimCancelToken
private static const System.Single _unhoverAnimDur = 0.5
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task AnimPressDown(System.Threading.CancellationTokenSource cancelToken)
private [async] System.Threading.Tasks.Task AnimUnhover(System.Threading.CancellationTokenSource cancelToken)
private System.Void OnWindowChange()
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
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NMiscConfirmButton+<AnimPressDown>d__21

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.CommonUi.NMiscConfirmButton <>4__this
private System.Single <>7__wrap1
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
public System.Threading.CancellationTokenSource cancelToken
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NMiscConfirmButton+<AnimUnhover>d__19

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.CommonUi.NMiscConfirmButton <>4__this
private System.Single <>7__wrap3
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
private Godot.Color <startButtonColor>5__3
private Godot.Vector2 <startScale>5__2
public System.Threading.CancellationTokenSource cancelToken
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NMiscConfirmButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnDisable
public static readonly Godot.StringName OnEnable
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName OnWindowChange
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NMiscConfirmButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _buttonImage
public static readonly Godot.StringName _downColor
public static readonly Godot.StringName _hidePos
public static readonly Godot.StringName _moveTween
public static readonly Godot.StringName _showPos
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NMiscConfirmButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NModalContainer

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private Godot.ColorRect _backstop
private Godot.Tween _backstopTween
private static MegaCrit.Sts2.Core.Nodes.CommonUi.NModalContainer <Instance>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext <OpenModal>k__BackingField
MegaCrit.Sts2.Core.Nodes.CommonUi.NModalContainer Instance { public static get; private static set; }
MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext OpenModal { public get; private set; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private static System.Void set_Instance(MegaCrit.Sts2.Core.Nodes.CommonUi.NModalContainer value)
private System.Boolean <HideBackstop>b__14_0()
private System.Void set_OpenModal(MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext get_OpenModal()
public static MegaCrit.Sts2.Core.Nodes.CommonUi.NModalContainer get_Instance()
public System.Void Add(Godot.Node modalToCreate, System.Boolean showBackstop = True)
public System.Void Clear()
public System.Void HideBackstop()
public System.Void ShowBackstop()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NModalContainer+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Add
public static readonly Godot.StringName Clear
public static readonly Godot.StringName HideBackstop
public static readonly Godot.StringName ShowBackstop
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NModalContainer+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _backstop
public static readonly Godot.StringName _backstopTween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NModalContainer+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Players.Player> _allPlayers
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer+VoteIcon> _iconsAnimatingOut
private MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer+PlayerVotedDelegate _playerVotedDelegate
private static const System.String _voteIconPath = "ui/multiplayer_vote_icon"
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer+VoteIcon> _votes
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Players.Player> Players { public get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
private System.Void AnimVoteIn(MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer+VoteIcon vote, System.Boolean animate)
private System.Void AnimVoteOut(MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer+VoteIcon vote, System.Boolean animate)
private System.Void RemoveVoteAfterAnimation(MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer+VoteIcon vote)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Players.Player> get_Players()
public System.Int32 GetVoteIndex(MegaCrit.Sts2.Core.Entities.Players.Player player)
public System.Void BouncePlayers()
public System.Void Initialize(MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer+PlayerVotedDelegate del, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Players.Player> players)
public System.Void RefreshPlayerVotes(System.Boolean animate = True)
public System.Void SetPlayerHighlighted(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Boolean isHighlighted)
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer+VoteIcon, MegaCrit.Sts2.Core.Entities.Players.Player> <>9__9_0
private static .cctor()
public .ctor()
internal MegaCrit.Sts2.Core.Entities.Players.Player <get_Players>b__9_0(MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer+VoteIcon v)
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer+<>c__DisplayClass12_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Entities.Players.Player player
public .ctor()
internal System.Boolean <RefreshPlayerVotes>b__0(MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer+VoteIcon p)
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer+<>c__DisplayClass13_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Entities.Players.Player player
public .ctor()
internal System.Boolean <GetVoteIndex>b__0(MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer+VoteIcon v)
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer+<>c__DisplayClass14_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Entities.Players.Player player
public .ctor()
internal System.Boolean <SetPlayerHighlighted>b__0(MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer+VoteIcon v)
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer+<>c__DisplayClass16_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer+VoteIcon vote
public .ctor()
internal System.Boolean <AnimVoteIn>b__0(MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer+VoteIcon i)
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer+<>c__DisplayClass17_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer <>4__this
public MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer+VoteIcon vote
public .ctor()
internal System.Void <AnimVoteOut>b__0()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName BouncePlayers
public static readonly Godot.StringName RefreshPlayerVotes
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer+PlayerVotedDelegate

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.Boolean EndInvoke(System.IAsyncResult result)
public virtual System.Boolean Invoke(MegaCrit.Sts2.Core.Entities.Players.Player player)
public virtual System.IAsyncResult BeginInvoke(MegaCrit.Sts2.Core.Entities.Players.Player player, System.AsyncCallback callback, System.Object object)
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer+VoteIcon

类型属性：`NestedPrivate, BeforeFieldInit`；基类：`System.Object`。

接口：`System.IEquatable<MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer+VoteIcon>`

```text
public Godot.TextureRect node
public MegaCrit.Sts2.Core.Entities.Players.Player player
public Godot.Tween tween
System.Type EqualityContract { protected virtual get; }
protected .ctor(MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer+VoteIcon original)
public .ctor()
protected virtual System.Boolean PrintMembers(System.Text.StringBuilder builder)
protected virtual System.Type get_EqualityContract()
public static System.Boolean op_Equality(MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer+VoteIcon left, MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer+VoteIcon right)
public static System.Boolean op_Inequality(MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer+VoteIcon left, MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer+VoteIcon right)
public virtual MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer+VoteIcon <Clone>$()
public virtual System.Boolean Equals(MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer+VoteIcon other)
public virtual System.Boolean Equals(System.Object obj)
public virtual System.Int32 GetHashCode()
public virtual System.String ToString()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NPopupYesNoButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private System.Single _baseS
private System.Single _baseV
private static readonly Godot.Color _goldOutline
private Godot.ShaderMaterial _hsv
private Godot.Control _image
private System.Boolean _isFocused
private System.Boolean _isYes
private MegaCrit.Sts2.addons.mega_text.MegaLabel _label
private Godot.Control _outline
private Godot.CanvasItemMaterial _outlineMaterial
private static readonly Godot.StringName _s
private Godot.Tween _tween
private static readonly Godot.StringName _v
private Godot.Control _visuals
System.String[] Hotkeys { protected virtual get; }
System.Boolean IsYes { public get; public set; }
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
protected virtual System.String[] get_Hotkeys()
protected virtual System.Void OnFocus()
protected virtual System.Void OnPress()
protected virtual System.Void OnRelease()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Boolean get_IsYes()
public System.Void DisconnectHotkeys()
public System.Void set_IsYes(System.Boolean value)
public System.Void SetText(System.String text)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NPopupYesNoButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName DisconnectHotkeys
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName SetText
public static readonly Godot.StringName UpdateShaderS
public static readonly Godot.StringName UpdateShaderV
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NPopupYesNoButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _baseS
public static readonly Godot.StringName _baseV
public static readonly Godot.StringName _hsv
public static readonly Godot.StringName _image
public static readonly Godot.StringName _isFocused
public static readonly Godot.StringName _isYes
public static readonly Godot.StringName _label
public static readonly Godot.StringName _outline
public static readonly Godot.StringName _outlineMaterial
public static readonly Godot.StringName _tween
public static readonly Godot.StringName _visuals
public static readonly Godot.StringName Hotkeys
public static readonly Godot.StringName IsYes
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NPopupYesNoButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NProceedButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private Godot.Tween _animTween
private Godot.Control _buttonImage
private Godot.Color _defaultOutlineColor
private Godot.Color _downColor
private System.Single _elapsedTime
private Godot.Tween _glowTween
private static readonly Godot.Vector2 _hidePosRatio
private Godot.Color _hoveredOutlineColor
private static readonly Godot.Vector2 _hoverScale
private Godot.Tween _hoverTween
private Godot.ShaderMaterial _hsv
private MegaCrit.Sts2.addons.mega_text.MegaLabel _label
private Godot.Control _outline
private Godot.Color _outlineColor
private Godot.Color _outlineTransparentColor
private static readonly Godot.StringName _s
private System.Boolean _shouldPulse
private static readonly Godot.Vector2 _showPosRatio
private static readonly Godot.StringName _v
private Godot.Viewport _viewport
private System.Boolean <IsSkip>k__BackingField
Godot.Vector2 HidePos { private get; }
System.String[] Hotkeys { protected virtual get; }
System.Boolean IsSkip { public get; private set; }
MegaCrit.Sts2.Core.Localization.LocString ProceedLoc { public static get; }
Godot.Vector2 ShowPos { private get; }
MegaCrit.Sts2.Core.Localization.LocString SkipLoc { public static get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private Godot.Vector2 get_HidePos()
private Godot.Vector2 get_ShowPos()
private System.Void DebugToggleVisibility()
private System.Void set_IsSkip(System.Boolean value)
private System.Void StartGlowTween()
private System.Void StopGlowTween()
private System.Void UpdateShaderS(System.Single value)
private System.Void UpdateShaderV(System.Single value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.String[] get_Hotkeys()
protected virtual System.Void OnDisable()
protected virtual System.Void OnEnable()
protected virtual System.Void OnFocus()
protected virtual System.Void OnPress()
protected virtual System.Void OnRelease()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Localization.LocString get_ProceedLoc()
public static MegaCrit.Sts2.Core.Localization.LocString get_SkipLoc()
public System.Boolean get_IsSkip()
public System.Void SetPulseState(System.Boolean isPulsing)
public System.Void UpdateText(MegaCrit.Sts2.Core.Localization.LocString loc)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NProceedButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName DebugToggleVisibility
public static readonly Godot.StringName OnDisable
public static readonly Godot.StringName OnEnable
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName SetPulseState
public static readonly Godot.StringName StartGlowTween
public static readonly Godot.StringName StopGlowTween
public static readonly Godot.StringName UpdateShaderS
public static readonly Godot.StringName UpdateShaderV
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NProceedButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _animTween
public static readonly Godot.StringName _buttonImage
public static readonly Godot.StringName _defaultOutlineColor
public static readonly Godot.StringName _downColor
public static readonly Godot.StringName _elapsedTime
public static readonly Godot.StringName _glowTween
public static readonly Godot.StringName _hoveredOutlineColor
public static readonly Godot.StringName _hoverTween
public static readonly Godot.StringName _hsv
public static readonly Godot.StringName _label
public static readonly Godot.StringName _outline
public static readonly Godot.StringName _outlineColor
public static readonly Godot.StringName _outlineTransparentColor
public static readonly Godot.StringName _shouldPulse
public static readonly Godot.StringName _viewport
public static readonly Godot.StringName HidePos
public static readonly Godot.StringName Hotkeys
public static readonly Godot.StringName IsSkip
public static readonly Godot.StringName ShowPos
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NProceedButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NSaveIndicator

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private Godot.Tween _tween
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void SavedGame()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NSaveIndicator+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName SavedGame
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NSaveIndicator+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _tween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NSaveIndicator+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NScrollbarTrain

类型属性：`Public, BeforeFieldInit`；基类：`Godot.TextureRect`。

接口：`System.IDisposable`

```text
private Godot.Tween _tween
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
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

## MegaCrit.Sts2.Core.Nodes.CommonUi.NScrollbarTrain+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.TextureRect+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnMouseEntered
public static readonly Godot.StringName OnMouseExited
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NScrollbarTrain+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.TextureRect+PropertyName`。

接口：

```text
public static readonly Godot.StringName _tween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NScrollbarTrain+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.TextureRect+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NSearchBar

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _clearButton
private Godot.LineEdit _textArea
private MegaCrit.Sts2.Core.Nodes.CommonUi.NSearchBar+QueryChangedEventHandler backing_QueryChanged
private MegaCrit.Sts2.Core.Nodes.CommonUi.NSearchBar+QuerySubmittedEventHandler backing_QuerySubmitted
System.String Text { public get; }
Godot.LineEdit TextArea { public get; }
event MegaCrit.Sts2.Core.Nodes.CommonUi.NSearchBar+QueryChangedEventHandler QueryChanged
event MegaCrit.Sts2.Core.Nodes.CommonUi.NSearchBar+QuerySubmittedEventHandler QuerySubmitted
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotSignalList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private static System.Text.RegularExpressions.Regex ConsecutiveSpaces()
private static System.Text.RegularExpressions.Regex HtmlTags()
private static System.Text.RegularExpressions.Regex NonSpaceWhitespaceCharacters()
private System.Void ClearText(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void TextSubmitted(System.String _)
private System.Void TextUpdated(System.String _)
protected System.Void EmitSignalQueryChanged(System.String query)
protected System.Void EmitSignalQuerySubmitted(System.String query)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean HasGodotClassSignal(in Godot.NativeInterop.godot_string_name signal)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RaiseGodotClassSignalCallbacks(in Godot.NativeInterop.godot_string_name signal, Godot.NativeInterop.NativeVariantPtrArgs args)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public Godot.LineEdit get_TextArea()
public static System.String Normalize(System.String text)
public static System.String RemoveHtmlTags(System.String text)
public System.String get_Text()
public System.Void add_QueryChanged(MegaCrit.Sts2.Core.Nodes.CommonUi.NSearchBar+QueryChangedEventHandler value)
public System.Void add_QuerySubmitted(MegaCrit.Sts2.Core.Nodes.CommonUi.NSearchBar+QuerySubmittedEventHandler value)
public System.Void ClearText()
public System.Void remove_QueryChanged(MegaCrit.Sts2.Core.Nodes.CommonUi.NSearchBar+QueryChangedEventHandler value)
public System.Void remove_QuerySubmitted(MegaCrit.Sts2.Core.Nodes.CommonUi.NSearchBar+QuerySubmittedEventHandler value)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NSearchBar+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName ClearText
public static readonly Godot.StringName Normalize
public static readonly Godot.StringName RemoveHtmlTags
public static readonly Godot.StringName TextSubmitted
public static readonly Godot.StringName TextUpdated
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NSearchBar+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _clearButton
public static readonly Godot.StringName _textArea
public static readonly Godot.StringName Text
public static readonly Godot.StringName TextArea
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NSearchBar+QueryChangedEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(System.String query, System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke(System.String query)
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NSearchBar+QuerySubmittedEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(System.String query, System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke(System.String query)
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NSearchBar+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public static readonly Godot.StringName QueryChanged
public static readonly Godot.StringName QuerySubmitted
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NSettingsScreenPopup

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private Godot.ColorRect _backstop
private MegaCrit.Sts2.Core.Localization.LocString _description
private MegaCrit.Sts2.Core.Localization.LocString _header
private static readonly System.String _scenePath
private MegaCrit.Sts2.Core.Nodes.CommonUi.NVerticalPopup <VerticalPopup>k__BackingField
Godot.Control DefaultFocusedControl { public virtual get; }
MegaCrit.Sts2.Core.Nodes.CommonUi.NVerticalPopup VerticalPopup { public get; private set; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnYesButtonPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void set_VerticalPopup(MegaCrit.Sts2.Core.Nodes.CommonUi.NVerticalPopup value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public MegaCrit.Sts2.Core.Nodes.CommonUi.NVerticalPopup get_VerticalPopup()
public static MegaCrit.Sts2.Core.Nodes.CommonUi.NSettingsScreenPopup Create(MegaCrit.Sts2.Core.Localization.LocString header, MegaCrit.Sts2.Core.Localization.LocString description)
public virtual Godot.Control get_DefaultFocusedControl()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NSettingsScreenPopup+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.CommonUi.NSettingsScreenPopup+<>c <>9
public static System.Action<MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton> <>9__9_0
private static .cctor()
public .ctor()
internal System.Void <_Ready>b__9_0(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NSettingsScreenPopup+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnYesButtonPressed
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NSettingsScreenPopup+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _backstop
public static readonly Godot.StringName DefaultFocusedControl
public static readonly Godot.StringName VerticalPopup
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NSettingsScreenPopup+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private Godot.Vector2 _baseScale
private System.Single _hoverScale
private System.Single _hoverV
private Godot.ShaderMaterial _hsv
private Godot.Control _imageContainer
private System.Boolean _isTicked
private Godot.Control _notTickedImage
private System.Single _pressDownScale
private Godot.Control _tickedImage
private Godot.Tween _tween
private static readonly Godot.StringName _v
private MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox+ToggledEventHandler backing_Toggled
System.Boolean IsTicked { public get; public set; }
event MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox+ToggledEventHandler Toggled
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotSignalList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void UpdateShaderV(System.Single value)
protected System.Void EmitSignalToggled(MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox tickbox)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean HasGodotClassSignal(in Godot.NativeInterop.godot_string_name signal)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void ConnectSignals()
protected virtual System.Void OnDisable()
protected virtual System.Void OnEnable()
protected virtual System.Void OnFocus()
protected virtual System.Void OnPress()
protected virtual System.Void OnRelease()
protected virtual System.Void OnTick()
protected virtual System.Void OnUnfocus()
protected virtual System.Void OnUntick()
protected virtual System.Void RaiseGodotClassSignalCallbacks(in Godot.NativeInterop.godot_string_name signal, Godot.NativeInterop.NativeVariantPtrArgs args)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Boolean get_IsTicked()
public System.Void add_Toggled(MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox+ToggledEventHandler value)
public System.Void ForceToggleTick()
public System.Void remove_Toggled(MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox+ToggledEventHandler value)
public System.Void set_IsTicked(System.Boolean value)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName ConnectSignals
public static readonly Godot.StringName ForceToggleTick
public static readonly Godot.StringName OnDisable
public static readonly Godot.StringName OnEnable
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnTick
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName OnUntick
public static readonly Godot.StringName UpdateShaderV
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _baseScale
public static readonly Godot.StringName _hoverScale
public static readonly Godot.StringName _hoverV
public static readonly Godot.StringName _hsv
public static readonly Godot.StringName _imageContainer
public static readonly Godot.StringName _isTicked
public static readonly Godot.StringName _notTickedImage
public static readonly Godot.StringName _pressDownScale
public static readonly Godot.StringName _tickedImage
public static readonly Godot.StringName _tween
public static readonly Godot.StringName IsTicked
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public static readonly Godot.StringName Toggled
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox+ToggledEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox tickbox, System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke(MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox tickbox)
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NTopBar

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private Godot.Control _achievementLock
private Godot.ShaderMaterial _ascensionHsv
private Godot.Control _ascensionIcon
private MegaCrit.Sts2.addons.mega_text.MegaLabel _ascensionLabel
private static readonly Godot.Color _blueLabelOutline
private MegaCrit.Sts2.Core.Nodes.Screens.Capstones.NCapstoneContainer _capstoneContainer
private static readonly Godot.StringName _fontOutlineTheme
private static readonly Godot.StringName _h
private Godot.Tween _hideTween
private System.Boolean _isDebugHidden
private Godot.Control _modifiersContainer
private MegaCrit.Sts2.Core.Entities.Players.Player _player
private static readonly Godot.Color _redLabelOutline
private static readonly Godot.StringName _v
private Godot.Control <ActiveScreenProxy>k__BackingField
private MegaCrit.sts2.Core.Nodes.TopBar.NTopBarBossIcon <BossIcon>k__BackingField
private MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarDeckButton <Deck>k__BackingField
private MegaCrit.sts2.Core.Nodes.TopBar.NTopBarFloorIcon <FloorIcon>k__BackingField
private MegaCrit.sts2.Core.Nodes.TopBar.NTopBarGold <Gold>k__BackingField
private MegaCrit.sts2.Core.Nodes.TopBar.NTopBarHp <Hp>k__BackingField
private MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarMapButton <Map>k__BackingField
private MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarPauseButton <Pause>k__BackingField
private MegaCrit.sts2.Core.Nodes.TopBar.NTopBarPortrait <Portrait>k__BackingField
private MegaCrit.sts2.Core.Nodes.TopBar.NTopBarPortraitTip <PortraitTip>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Potions.NPotionContainer <PotionContainer>k__BackingField
private MegaCrit.sts2.Core.Nodes.TopBar.NTopBarRoomIcon <RoomIcon>k__BackingField
private MegaCrit.Sts2.Core.Nodes.TopBar.NRunTimer <Timer>k__BackingField
private Godot.Node <TrailContainer>k__BackingField
Godot.Control ActiveScreenProxy { public get; private set; }
MegaCrit.sts2.Core.Nodes.TopBar.NTopBarBossIcon BossIcon { public get; private set; }
MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarDeckButton Deck { public get; private set; }
MegaCrit.sts2.Core.Nodes.TopBar.NTopBarFloorIcon FloorIcon { public get; private set; }
MegaCrit.sts2.Core.Nodes.TopBar.NTopBarGold Gold { public get; private set; }
MegaCrit.sts2.Core.Nodes.TopBar.NTopBarHp Hp { public get; private set; }
MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarMapButton Map { public get; private set; }
MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarPauseButton Pause { public get; private set; }
MegaCrit.sts2.Core.Nodes.TopBar.NTopBarPortrait Portrait { public get; private set; }
MegaCrit.sts2.Core.Nodes.TopBar.NTopBarPortraitTip PortraitTip { public get; private set; }
MegaCrit.Sts2.Core.Nodes.Potions.NPotionContainer PotionContainer { public get; private set; }
MegaCrit.sts2.Core.Nodes.TopBar.NTopBarRoomIcon RoomIcon { public get; private set; }
MegaCrit.Sts2.Core.Nodes.TopBar.NRunTimer Timer { public get; private set; }
Godot.Node TrailContainer { public get; private set; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void DebugHideTopBar()
private System.Void MaxPotionsChanged(System.Int32 _)
private System.Void OnRelicsUpdated(MegaCrit.Sts2.Core.Models.RelicModel _)
private System.Void set_ActiveScreenProxy(Godot.Control value)
private System.Void set_BossIcon(MegaCrit.sts2.Core.Nodes.TopBar.NTopBarBossIcon value)
private System.Void set_Deck(MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarDeckButton value)
private System.Void set_FloorIcon(MegaCrit.sts2.Core.Nodes.TopBar.NTopBarFloorIcon value)
private System.Void set_Gold(MegaCrit.sts2.Core.Nodes.TopBar.NTopBarGold value)
private System.Void set_Hp(MegaCrit.sts2.Core.Nodes.TopBar.NTopBarHp value)
private System.Void set_Map(MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarMapButton value)
private System.Void set_Pause(MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarPauseButton value)
private System.Void set_Portrait(MegaCrit.sts2.Core.Nodes.TopBar.NTopBarPortrait value)
private System.Void set_PortraitTip(MegaCrit.sts2.Core.Nodes.TopBar.NTopBarPortraitTip value)
private System.Void set_PotionContainer(MegaCrit.Sts2.Core.Nodes.Potions.NPotionContainer value)
private System.Void set_RoomIcon(MegaCrit.sts2.Core.Nodes.TopBar.NTopBarRoomIcon value)
private System.Void set_Timer(MegaCrit.Sts2.Core.Nodes.TopBar.NRunTimer value)
private System.Void set_TrailContainer(Godot.Node value)
private System.Void ToggleAnimState(Godot.Node _)
private System.Void UpdateNavigation()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public Godot.Control get_ActiveScreenProxy()
public Godot.Node get_TrailContainer()
public MegaCrit.Sts2.Core.Nodes.Potions.NPotionContainer get_PotionContainer()
public MegaCrit.Sts2.Core.Nodes.TopBar.NRunTimer get_Timer()
public MegaCrit.sts2.Core.Nodes.TopBar.NTopBarBossIcon get_BossIcon()
public MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarDeckButton get_Deck()
public MegaCrit.sts2.Core.Nodes.TopBar.NTopBarFloorIcon get_FloorIcon()
public MegaCrit.sts2.Core.Nodes.TopBar.NTopBarGold get_Gold()
public MegaCrit.sts2.Core.Nodes.TopBar.NTopBarHp get_Hp()
public MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarMapButton get_Map()
public MegaCrit.Sts2.Core.Nodes.TopBar.NTopBarPauseButton get_Pause()
public MegaCrit.sts2.Core.Nodes.TopBar.NTopBarPortrait get_Portrait()
public MegaCrit.sts2.Core.Nodes.TopBar.NTopBarPortraitTip get_PortraitTip()
public MegaCrit.sts2.Core.Nodes.TopBar.NTopBarRoomIcon get_RoomIcon()
public System.Void AnimHide()
public System.Void AnimShow()
public System.Void Initialize(MegaCrit.Sts2.Core.Runs.IRunState runState)
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Input(Godot.InputEvent inputEvent)
public virtual System.Void _Notification(System.Int32 what)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NTopBar+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.CommonUi.NTopBar+<>c <>9
public static System.Action <>9__70_0
private static .cctor()
public .ctor()
internal System.Void <_Ready>b__70_0()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NTopBar+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Input
public static readonly Godot.StringName _Notification
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AnimHide
public static readonly Godot.StringName AnimShow
public static readonly Godot.StringName DebugHideTopBar
public static readonly Godot.StringName MaxPotionsChanged
public static readonly Godot.StringName ToggleAnimState
public static readonly Godot.StringName UpdateNavigation
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NTopBar+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _achievementLock
public static readonly Godot.StringName _ascensionHsv
public static readonly Godot.StringName _ascensionIcon
public static readonly Godot.StringName _ascensionLabel
public static readonly Godot.StringName _capstoneContainer
public static readonly Godot.StringName _hideTween
public static readonly Godot.StringName _isDebugHidden
public static readonly Godot.StringName _modifiersContainer
public static readonly Godot.StringName ActiveScreenProxy
public static readonly Godot.StringName BossIcon
public static readonly Godot.StringName Deck
public static readonly Godot.StringName FloorIcon
public static readonly Godot.StringName Gold
public static readonly Godot.StringName Hp
public static readonly Godot.StringName Map
public static readonly Godot.StringName Pause
public static readonly Godot.StringName Portrait
public static readonly Godot.StringName PortraitTip
public static readonly Godot.StringName PotionContainer
public static readonly Godot.StringName RoomIcon
public static readonly Godot.StringName Timer
public static readonly Godot.StringName TrailContainer
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NTopBar+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NVerticalPopup

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private System.Nullable<Godot.Callable> _noCallable
private System.Boolean _nodesAreSet
private static readonly System.String _scenePath
private System.Nullable<Godot.Callable> _yesCallable
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel <BodyLabel>k__BackingField
private MegaCrit.Sts2.Core.Nodes.CommonUi.NPopupYesNoButton <NoButton>k__BackingField
private MegaCrit.Sts2.addons.mega_text.MegaLabel <TitleLabel>k__BackingField
private MegaCrit.Sts2.Core.Nodes.CommonUi.NPopupYesNoButton <YesButton>k__BackingField
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel BodyLabel { private get; private set; }
MegaCrit.Sts2.Core.Nodes.CommonUi.NPopupYesNoButton NoButton { public get; private set; }
MegaCrit.Sts2.addons.mega_text.MegaLabel TitleLabel { private get; private set; }
MegaCrit.Sts2.Core.Nodes.CommonUi.NPopupYesNoButton YesButton { public get; private set; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private MegaCrit.Sts2.addons.mega_text.MegaLabel get_TitleLabel()
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel get_BodyLabel()
private System.Void Close(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void EnsureNodesAreSet()
private System.Void set_BodyLabel(MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel value)
private System.Void set_NoButton(MegaCrit.Sts2.Core.Nodes.CommonUi.NPopupYesNoButton value)
private System.Void set_TitleLabel(MegaCrit.Sts2.addons.mega_text.MegaLabel value)
private System.Void set_YesButton(MegaCrit.Sts2.Core.Nodes.CommonUi.NPopupYesNoButton value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public MegaCrit.Sts2.Core.Nodes.CommonUi.NPopupYesNoButton get_NoButton()
public MegaCrit.Sts2.Core.Nodes.CommonUi.NPopupYesNoButton get_YesButton()
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Void DisconnectHotkeys()
public System.Void DisconnectSignals()
public System.Void HideNoButton()
public System.Void InitNoButton(MegaCrit.Sts2.Core.Localization.LocString noButton, System.Action<MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton> onPressed)
public System.Void InitYesButton(MegaCrit.Sts2.Core.Localization.LocString yesButton, System.Action<MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton> onPressed)
public System.Void SetText(MegaCrit.Sts2.Core.Localization.LocString title, MegaCrit.Sts2.Core.Localization.LocString body)
public System.Void SetText(System.String title, System.String body)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NVerticalPopup+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Close
public static readonly Godot.StringName DisconnectHotkeys
public static readonly Godot.StringName DisconnectSignals
public static readonly Godot.StringName EnsureNodesAreSet
public static readonly Godot.StringName HideNoButton
public static readonly Godot.StringName SetText
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NVerticalPopup+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _nodesAreSet
public static readonly Godot.StringName BodyLabel
public static readonly Godot.StringName NoButton
public static readonly Godot.StringName TitleLabel
public static readonly Godot.StringName YesButton
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.CommonUi.NVerticalPopup+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```
