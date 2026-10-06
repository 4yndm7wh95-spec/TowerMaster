# MegaCrit.Sts2.Core.Nodes.GodotExtensions

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl`。

接口：`System.IDisposable`

```text
protected MegaCrit.Sts2.Core.Nodes.CommonUi.NHotkeyIcon _hotkeyIcon
System.String ClickedSfx { protected virtual get; }
System.String ControllerIconHotkey { protected virtual get; }
System.Boolean HasControllerHotkey { private get; }
System.String[] Hotkeys { protected virtual get; }
System.String HoveredSfx { protected virtual get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Boolean get_HasControllerHotkey()
protected System.Void RegisterHotkeys()
protected System.Void UnregisterHotkeys()
protected System.Void UpdateControllerButton()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.String get_ClickedSfx()
protected virtual System.String get_ControllerIconHotkey()
protected virtual System.String get_HoveredSfx()
protected virtual System.String[] get_Hotkeys()
protected virtual System.Void ConnectSignals()
protected virtual System.Void GetControllerIconNode()
protected virtual System.Void OnDisable()
protected virtual System.Void OnEnable()
protected virtual System.Void OnFocus()
protected virtual System.Void OnPress()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Input(Godot.InputEvent inputEvent)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Input
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName ConnectSignals
public static readonly Godot.StringName GetControllerIconNode
public static readonly Godot.StringName OnDisable
public static readonly Godot.StringName OnEnable
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName RegisterHotkeys
public static readonly Godot.StringName UnregisterHotkeys
public static readonly Godot.StringName UpdateControllerButton
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+PropertyName`。

接口：

```text
public static readonly Godot.StringName _hotkeyIcon
public static readonly Godot.StringName ClickedSfx
public static readonly Godot.StringName ControllerIconHotkey
public static readonly Godot.StringName HasControllerHotkey
public static readonly Godot.StringName Hotkeys
public static readonly Godot.StringName HoveredSfx
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private Godot.Vector2 _beginDragPosition
private static readonly Godot.StyleBoxEmpty _blankFocusStyle
protected System.Single _ignoreDragThreshold
private System.Boolean _isControllerFocused
private System.Boolean _isControllerNavigable
protected System.Boolean _isEnabled
private System.Boolean _isHovered
private System.Boolean _isPressed
private System.Boolean <IsFocused>k__BackingField
private MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+FocusedEventHandler backing_Focused
private MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+MousePressedEventHandler backing_MousePressed
private MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+MouseReleasedEventHandler backing_MouseReleased
private MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+ReleasedEventHandler backing_Released
private MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+UnfocusedEventHandler backing_Unfocused
System.Boolean AllowFocusWhileDisabled { protected virtual get; }
System.Boolean IsEnabled { public get; }
System.Boolean IsFocused { protected get; private set; }
event MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+FocusedEventHandler Focused
event MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+MousePressedEventHandler MousePressed
event MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+MouseReleasedEventHandler MouseReleased
event MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+ReleasedEventHandler Released
event MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+UnfocusedEventHandler Unfocused
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotSignalList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void <Enable>b__42_0()
private System.Void HandleMousePress(Godot.InputEvent inputEvent)
private System.Void HandleMouseRelease(Godot.InputEvent inputEvent)
private System.Void OnFocusHandler()
private System.Void OnHoverHandler()
private System.Void OnUnFocusHandler()
private System.Void OnUnhoverHandler()
private System.Void OnVisibilityChanged()
private System.Void RefreshFocus()
private System.Void set_IsFocused(System.Boolean value)
protected System.Boolean get_IsFocused()
protected System.Void CheckMouseDragThreshold(Godot.InputEvent inputEvent)
protected System.Void EmitSignalFocused(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl button)
protected System.Void EmitSignalMousePressed(Godot.InputEvent inputEvent)
protected System.Void EmitSignalMouseReleased(Godot.InputEvent inputEvent)
protected System.Void EmitSignalReleased(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl button)
protected System.Void EmitSignalUnfocused(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl button)
protected System.Void OnPressHandler()
protected System.Void OnReleaseHandler()
protected virtual System.Boolean get_AllowFocusWhileDisabled()
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
protected virtual System.Void OnUnfocus()
protected virtual System.Void RaiseGodotClassSignalCallbacks(in Godot.NativeInterop.godot_string_name signal, Godot.NativeInterop.NativeVariantPtrArgs args)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Boolean get_IsEnabled()
public System.Void add_Focused(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+FocusedEventHandler value)
public System.Void add_MousePressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+MousePressedEventHandler value)
public System.Void add_MouseReleased(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+MouseReleasedEventHandler value)
public System.Void add_Released(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+ReleasedEventHandler value)
public System.Void add_Unfocused(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+UnfocusedEventHandler value)
public System.Void DebugPress()
public System.Void DebugRelease()
public System.Void Disable()
public System.Void Enable()
public System.Void ForceClick()
public System.Void remove_Focused(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+FocusedEventHandler value)
public System.Void remove_MousePressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+MousePressedEventHandler value)
public System.Void remove_MouseReleased(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+MouseReleasedEventHandler value)
public System.Void remove_Released(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+ReleasedEventHandler value)
public System.Void remove_Unfocused(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+UnfocusedEventHandler value)
public System.Void SetEnabled(System.Boolean enabled)
public virtual System.Void _GuiInput(Godot.InputEvent inputEvent)
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+FocusedEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl button, System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl button)
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _GuiInput
public static readonly Godot.StringName CheckMouseDragThreshold
public static readonly Godot.StringName ConnectSignals
public static readonly Godot.StringName DebugPress
public static readonly Godot.StringName DebugRelease
public static readonly Godot.StringName Disable
public static readonly Godot.StringName Enable
public static readonly Godot.StringName ForceClick
public static readonly Godot.StringName HandleMousePress
public static readonly Godot.StringName HandleMouseRelease
public static readonly Godot.StringName OnDisable
public static readonly Godot.StringName OnEnable
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnFocusHandler
public static readonly Godot.StringName OnHoverHandler
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnPressHandler
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnReleaseHandler
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName OnUnFocusHandler
public static readonly Godot.StringName OnUnhoverHandler
public static readonly Godot.StringName OnVisibilityChanged
public static readonly Godot.StringName RefreshFocus
public static readonly Godot.StringName SetEnabled
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+MousePressedEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(Godot.InputEvent inputEvent, System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke(Godot.InputEvent inputEvent)
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+MouseReleasedEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(Godot.InputEvent inputEvent, System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke(Godot.InputEvent inputEvent)
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _beginDragPosition
public static readonly Godot.StringName _ignoreDragThreshold
public static readonly Godot.StringName _isControllerFocused
public static readonly Godot.StringName _isControllerNavigable
public static readonly Godot.StringName _isEnabled
public static readonly Godot.StringName _isHovered
public static readonly Godot.StringName _isPressed
public static readonly Godot.StringName AllowFocusWhileDisabled
public static readonly Godot.StringName IsEnabled
public static readonly Godot.StringName IsFocused
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+ReleasedEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl button, System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl button)
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public static readonly Godot.StringName Focused
public static readonly Godot.StringName MousePressed
public static readonly Godot.StringName MouseReleased
public static readonly Godot.StringName Released
public static readonly Godot.StringName Unfocused
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+UnfocusedEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl button, System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl button)
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.NDropdown

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl`。

接口：`System.IDisposable`

```text
protected Godot.Control _currentOptionHighlight
protected MegaCrit.Sts2.addons.mega_text.MegaLabel _currentOptionLabel
private MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _dismisser
private Godot.Control _dropdownContainer
protected Godot.Control _dropdownItems
private System.Boolean _isHovered
private System.Boolean _isOpen
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnDismisserClicked(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton obj)
private System.Void OnVisibilityChange()
private System.Void OpenDropdown()
protected System.Void ClearDropdownItems()
protected System.Void CloseDropdown()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void ConnectSignals()
protected virtual System.Void OnRelease()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Input(Godot.InputEvent inputEvent)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.NDropdown+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+MethodName`。

接口：

```text
public static readonly Godot.StringName _Input
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName ClearDropdownItems
public static readonly Godot.StringName CloseDropdown
public static readonly Godot.StringName ConnectSignals
public static readonly Godot.StringName OnDismisserClicked
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnVisibilityChange
public static readonly Godot.StringName OpenDropdown
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.NDropdown+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+PropertyName`。

接口：

```text
public static readonly Godot.StringName _currentOptionHighlight
public static readonly Godot.StringName _currentOptionLabel
public static readonly Godot.StringName _dismisser
public static readonly Godot.StringName _dropdownContainer
public static readonly Godot.StringName _dropdownItems
public static readonly Godot.StringName _isHovered
public static readonly Godot.StringName _isOpen
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.NDropdown+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.NMegaLineEdit

类型属性：`Public, BeforeFieldInit`；基类：`Godot.LineEdit`。

接口：`System.IDisposable`

```text
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
private System.Void OpenKeyboard()
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _GuiInput(Godot.InputEvent inputEvent)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.NMegaLineEdit+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.LineEdit+MethodName`。

接口：

```text
public static readonly Godot.StringName _GuiInput
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OpenKeyboard
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.NMegaLineEdit+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.LineEdit+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.NMegaLineEdit+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.LineEdit+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.NMegaTextEdit

类型属性：`Public, BeforeFieldInit`；基类：`Godot.TextEdit`。

接口：`System.IDisposable`

```text
private System.Boolean _isEditing
private MegaCrit.Sts2.Core.Nodes.Combat.NSelectionReticle _selectionReticle
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnFocus()
private System.Void OnUnfocus()
private System.Void OpenKeyboard()
private System.Void StopEditing()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Boolean IsEditing()
public System.Void RefreshFont()
public virtual System.Void _GuiInput(Godot.InputEvent inputEvent)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.NMegaTextEdit+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.TextEdit+MethodName`。

接口：

```text
public static readonly Godot.StringName _GuiInput
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName IsEditing
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName OpenKeyboard
public static readonly Godot.StringName RefreshFont
public static readonly Godot.StringName StopEditing
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.NMegaTextEdit+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.TextEdit+PropertyName`。

接口：

```text
public static readonly Godot.StringName _isEditing
public static readonly Godot.StringName _selectionReticle
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.NMegaTextEdit+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.TextEdit+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.NodeUtil

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static [async] System.Threading.Tasks.Task AwaitProcessFrameNonThrowing(Godot.Node node, System.Threading.CancellationTokenSource cts)
public static [async] System.Threading.Tasks.Task<System.Single> AwaitProcessFrame(Godot.Node node, System.Threading.CancellationToken ct = null)
public static Godot.SceneTree GetTreeOrNull(Godot.Node node)
public static System.Boolean IsDescendant(Godot.Node parent, Godot.Node candidate)
public static System.Boolean IsValid(Godot.Node node)
public static System.Collections.Generic.IEnumerable<T> GetChildrenRecursive<T>(Godot.Node node) where T: [None]
public static System.Threading.Tasks.Task AwaitSignal(Godot.GodotObject source, Godot.StringName signal, Godot.Node owner)
public static System.Threading.Tasks.Task<T> AwaitSignal<T>(Godot.GodotObject source, Godot.StringName signal, Godot.Node owner) where T: [ReferenceTypeConstraint]
public static System.Void TryGrabFocus(Godot.Control control)
public static T GetAncestorOfType<T>(Godot.Node node) where T: [None]
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.NodeUtil+<>c__DisplayClass5_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public Godot.Control control
public .ctor()
internal System.Void <TryGrabFocus>b__0()
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.NodeUtil+<>c__DisplayClass7_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public Godot.Callable callable
public Godot.Node owner
public System.Boolean resolved
public Godot.StringName signal
public Godot.GodotObject source
public System.Threading.Tasks.TaskCompletionSource tcs
public .ctor()
internal System.Void <AwaitSignal>g__OnExiting|1()
internal System.Void <AwaitSignal>g__OnSignal|0()
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.NodeUtil+<>c__DisplayClass8_0<T>

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public Godot.Callable callable
public Godot.Node owner
public System.Boolean resolved
public Godot.StringName signal
public Godot.GodotObject source
public System.Threading.Tasks.TaskCompletionSource<T> tcs
public .ctor()
internal System.Void <AwaitSignal>g__OnExiting|1()
internal System.Void <AwaitSignal>g__OnSignal|0(T obj)
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.NodeUtil+<AwaitProcessFrame>d__0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Single> <>t__builder
private System.Object <>u__1
public System.Threading.CancellationToken ct
public Godot.Node node
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.NodeUtil+<AwaitProcessFrameNonThrowing>d__1

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Object <>u__2
public System.Threading.CancellationTokenSource cts
public Godot.Node node
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.NodeUtil+<GetChildrenRecursive>d__9<T>

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：`System.Collections.Generic.IEnumerable<T>`, `System.Collections.IEnumerable`, `System.Collections.Generic.IEnumerator<T>`, `System.Collections.IEnumerator`, `System.IDisposable`

```text
private System.Int32 <>1__state
private T <>2__current
public Godot.Node <>3__node
private System.Collections.Generic.IEnumerator<Godot.Node> <>7__wrap1
private System.Collections.Generic.IEnumerator<T> <>7__wrap3
private System.Int32 <>l__initialThreadId
private Godot.Node <child>5__3
private Godot.Node node
T System.Collections.Generic.IEnumerator<T>.Current { private virtual get; }
System.Object System.Collections.IEnumerator.Current { private virtual get; }
public .ctor(System.Int32 <>1__state)
private System.Void <>m__Finally1()
private System.Void <>m__Finally2()
private virtual System.Boolean MoveNext()
private virtual System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
private virtual System.Object System.Collections.IEnumerator.get_Current()
private virtual System.Void System.Collections.IEnumerator.Reset()
private virtual System.Void System.IDisposable.Dispose()
private virtual T System.Collections.Generic.IEnumerator<T>.get_Current()
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.NScrollableContainer

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private Godot.Control _content
private System.Single _controllerScrollAmount
private System.Boolean _disableScrollingIfContentFits
private System.Boolean _isDragging
private System.Single _paddingBottom
private System.Single _paddingTop
private System.Boolean _scrollbarPressed
private System.Single _startDragPosY
private System.Single _targetDragPosY
private MegaCrit.Sts2.Core.Nodes.GodotExtensions.NScrollbar <Scrollbar>k__BackingField
MegaCrit.Sts2.Core.Nodes.GodotExtensions.NScrollbar Scrollbar { public get; private set; }
System.Single ScrollLimitBottom { private get; }
System.Single ScrollViewportSize { private get; }
System.Single ScrollViewportTop { private get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Single get_ScrollLimitBottom()
private System.Single get_ScrollViewportSize()
private System.Single get_ScrollViewportTop()
private System.Void <_Ready>b__19_0(Godot.InputEvent _)
private System.Void <_Ready>b__19_1(Godot.InputEvent _)
private System.Void ProcessControllerEvent(Godot.InputEvent inputEvent)
private System.Void ProcessGuiFocus(Godot.Control focusedControl)
private System.Void ProcessMouseEvent(Godot.InputEvent inputEvent)
private System.Void ProcessScrollEvent(Godot.InputEvent inputEvent)
private System.Void set_Scrollbar(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NScrollbar value)
private System.Void UpdateScrollLimitBottom()
private System.Void UpdateScrollPosition(System.Double delta)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public MegaCrit.Sts2.Core.Nodes.GodotExtensions.NScrollbar get_Scrollbar()
public System.Void DisableScrollingIfContentFits()
public System.Void InstantlyScrollToTop()
public System.Void SetContent(Godot.Control content, System.Single paddingTop = 0, System.Single paddingBottom = 0)
public System.Void UpdatePadding(System.Single paddingTop = 0, System.Single paddingBottom = 0)
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _GuiInput(Godot.InputEvent inputEvent)
public virtual System.Void _Input(Godot.InputEvent inputEvent)
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.NScrollableContainer+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _GuiInput
public static readonly Godot.StringName _Input
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName DisableScrollingIfContentFits
public static readonly Godot.StringName InstantlyScrollToTop
public static readonly Godot.StringName ProcessControllerEvent
public static readonly Godot.StringName ProcessGuiFocus
public static readonly Godot.StringName ProcessMouseEvent
public static readonly Godot.StringName ProcessScrollEvent
public static readonly Godot.StringName SetContent
public static readonly Godot.StringName UpdatePadding
public static readonly Godot.StringName UpdateScrollLimitBottom
public static readonly Godot.StringName UpdateScrollPosition
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.NScrollableContainer+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _content
public static readonly Godot.StringName _controllerScrollAmount
public static readonly Godot.StringName _disableScrollingIfContentFits
public static readonly Godot.StringName _isDragging
public static readonly Godot.StringName _paddingBottom
public static readonly Godot.StringName _paddingTop
public static readonly Godot.StringName _scrollbarPressed
public static readonly Godot.StringName _startDragPosY
public static readonly Godot.StringName _targetDragPosY
public static readonly Godot.StringName Scrollbar
public static readonly Godot.StringName ScrollLimitBottom
public static readonly Godot.StringName ScrollViewportSize
public static readonly Godot.StringName ScrollViewportTop
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.NScrollableContainer+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.NScrollbar

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Range`。

接口：`System.IDisposable`

```text
private System.Single _currentHandlePosition
private System.Single _currentVelocity
private Godot.Control _handle
private System.Boolean _isDragging
private MegaCrit.Sts2.Core.Nodes.GodotExtensions.NScrollbar+MousePressedEventHandler backing_MousePressed
private MegaCrit.Sts2.Core.Nodes.GodotExtensions.NScrollbar+MouseReleasedEventHandler backing_MouseReleased
event MegaCrit.Sts2.Core.Nodes.GodotExtensions.NScrollbar+MousePressedEventHandler MousePressed
event MegaCrit.Sts2.Core.Nodes.GodotExtensions.NScrollbar+MouseReleasedEventHandler MouseReleased
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotSignalList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void SetValueBasedOnMousePosition(Godot.Vector2 mousePosition)
private System.Void UpdateHandlePosition()
protected System.Void EmitSignalMousePressed(Godot.InputEvent inputEvent)
protected System.Void EmitSignalMouseReleased(Godot.InputEvent inputEvent)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean HasGodotClassSignal(in Godot.NativeInterop.godot_string_name signal)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RaiseGodotClassSignalCallbacks(in Godot.NativeInterop.godot_string_name signal, Godot.NativeInterop.NativeVariantPtrArgs args)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void add_MousePressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NScrollbar+MousePressedEventHandler value)
public System.Void add_MouseReleased(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NScrollbar+MouseReleasedEventHandler value)
public System.Void remove_MousePressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NScrollbar+MousePressedEventHandler value)
public System.Void remove_MouseReleased(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NScrollbar+MouseReleasedEventHandler value)
public System.Void SetValueWithoutAnimation(System.Double value)
public virtual System.Void _GuiInput(Godot.InputEvent inputEvent)
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.NScrollbar+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Range+MethodName`。

接口：

```text
public static readonly Godot.StringName _GuiInput
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName SetValueBasedOnMousePosition
public static readonly Godot.StringName SetValueWithoutAnimation
public static readonly Godot.StringName UpdateHandlePosition
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.NScrollbar+MousePressedEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(Godot.InputEvent inputEvent, System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke(Godot.InputEvent inputEvent)
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.NScrollbar+MouseReleasedEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(Godot.InputEvent inputEvent, System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke(Godot.InputEvent inputEvent)
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.NScrollbar+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Range+PropertyName`。

接口：

```text
public static readonly Godot.StringName _currentHandlePosition
public static readonly Godot.StringName _currentVelocity
public static readonly Godot.StringName _handle
public static readonly Godot.StringName _isDragging
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.NScrollbar+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Range+SignalName`。

接口：

```text
public static readonly Godot.StringName MousePressed
public static readonly Godot.StringName MouseReleased
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.NSlider

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Range`。

接口：`System.IDisposable`

```text
private System.Single _currentHandlePosition
private System.Single _currentVelocity
private Godot.Control _handle
private System.Boolean _isDragging
private MegaCrit.Sts2.Core.Nodes.GodotExtensions.NSlider+MousePressedEventHandler backing_MousePressed
private MegaCrit.Sts2.Core.Nodes.GodotExtensions.NSlider+MouseReleasedEventHandler backing_MouseReleased
event MegaCrit.Sts2.Core.Nodes.GodotExtensions.NSlider+MousePressedEventHandler MousePressed
event MegaCrit.Sts2.Core.Nodes.GodotExtensions.NSlider+MouseReleasedEventHandler MouseReleased
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotSignalList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void SetValueBasedOnMousePosition(Godot.Vector2 mousePosition)
private System.Void UpdateHandlePosition()
protected System.Void EmitSignalMousePressed(Godot.InputEvent inputEvent)
protected System.Void EmitSignalMouseReleased(Godot.InputEvent inputEvent)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean HasGodotClassSignal(in Godot.NativeInterop.godot_string_name signal)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RaiseGodotClassSignalCallbacks(in Godot.NativeInterop.godot_string_name signal, Godot.NativeInterop.NativeVariantPtrArgs args)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void add_MousePressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NSlider+MousePressedEventHandler value)
public System.Void add_MouseReleased(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NSlider+MouseReleasedEventHandler value)
public System.Void remove_MousePressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NSlider+MousePressedEventHandler value)
public System.Void remove_MouseReleased(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NSlider+MouseReleasedEventHandler value)
public System.Void SetValueWithoutAnimation(System.Double value)
public virtual System.Void _GuiInput(Godot.InputEvent inputEvent)
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.NSlider+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Range+MethodName`。

接口：

```text
public static readonly Godot.StringName _GuiInput
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName SetValueBasedOnMousePosition
public static readonly Godot.StringName SetValueWithoutAnimation
public static readonly Godot.StringName UpdateHandlePosition
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.NSlider+MousePressedEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(Godot.InputEvent inputEvent, System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke(Godot.InputEvent inputEvent)
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.NSlider+MouseReleasedEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(Godot.InputEvent inputEvent, System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke(Godot.InputEvent inputEvent)
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.NSlider+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Range+PropertyName`。

接口：

```text
public static readonly Godot.StringName _currentHandlePosition
public static readonly Godot.StringName _currentVelocity
public static readonly Godot.StringName _handle
public static readonly Godot.StringName _isDragging
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.NSlider+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Range+SignalName`。

接口：

```text
public static readonly Godot.StringName MousePressed
public static readonly Godot.StringName MouseReleased
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.TweenHelper

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static System.Threading.Tasks.Task<System.Boolean> AwaitFinishedInternal(Godot.Tween tween, Godot.Node owner)
public static [async] System.Threading.Tasks.Task<System.Boolean> AwaitFinished(Godot.Tween tween, Godot.Node owner)
public static System.Threading.Tasks.Task AwaitFinished(Godot.Tween tween, System.Threading.CancellationToken ct)
public static System.Void FastForwardToCompletion(Godot.Tween t)
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.TweenHelper+<>c__DisplayClass2_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public Godot.Node owner
public System.Boolean resolved
public System.Threading.Tasks.TaskCompletionSource<System.Boolean> tcs
public Godot.Tween tween
public .ctor()
internal System.Void <AwaitFinishedInternal>g__OnExiting|1()
internal System.Void <AwaitFinishedInternal>g__OnFinished|0()
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.TweenHelper+<>c__DisplayClass3_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.Threading.CancellationToken ct
public System.Threading.CancellationTokenRegistration ctr
public System.Threading.Tasks.TaskCompletionSource tcs
public Godot.Tween tween
public System.Int32 unsubscribed
public .ctor()
internal System.Void <AwaitFinished>b__0()
internal System.Void <AwaitFinished>g__OnFinished|1()
```

## MegaCrit.Sts2.Core.Nodes.GodotExtensions.TweenHelper+<AwaitFinished>d__1

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Boolean> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
public Godot.Node owner
public Godot.Tween tween
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```
