# MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.FeedbackData

类型属性：`Public, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：

```text
public System.String category
public System.String commit
public System.String description
public System.String gameVersion
public System.Boolean isFullConsole
public System.Boolean isModded
public System.String lang
public System.String platformBranch
public System.String sessionId
public System.String uniqueId
```

## MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NFeedbackCategoryDropdown

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NDropdown`。

接口：`System.IDisposable`

```text
private static readonly System.String[] _baseCategories
private static readonly MegaCrit.Sts2.Core.Localization.LocString[] _baseCategoryLoc
private System.String[] _categories
private MegaCrit.Sts2.Core.Localization.LocString[] _categoryLoc
private System.Int32 _currentCategoryIndex
private Godot.PackedScene _dropdownItemScene
private MegaCrit.Sts2.Core.Nodes.Combat.NSelectionReticle _selectionReticle
System.String CurrentCategory { public get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
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
public System.String get_CurrentCategory()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NFeedbackCategoryDropdown+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NDropdown+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnDropdownItemSelected
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName PopulateOptions
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NFeedbackCategoryDropdown+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NDropdown+PropertyName`。

接口：

```text
public static readonly Godot.StringName _categories
public static readonly Godot.StringName _currentCategoryIndex
public static readonly Godot.StringName _dropdownItemScene
public static readonly Godot.StringName _selectionReticle
public static readonly Godot.StringName CurrentCategory
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NFeedbackCategoryDropdown+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NDropdown+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NFeedbackCategoryDropdownItem

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NDropdownItem`。

接口：`System.IDisposable`

```text
private System.Int32 <CategoryIndex>k__BackingField
System.Int32 CategoryIndex { public get; private set; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void set_CategoryIndex(System.Int32 value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Int32 get_CategoryIndex()
public System.Void Init(System.Int32 categoryIndex, System.String localizedCategory)
```

## MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NFeedbackCategoryDropdownItem+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NDropdownItem+MethodName`。

接口：

```text
public static readonly Godot.StringName Init
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NFeedbackCategoryDropdownItem+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NDropdownItem+PropertyName`。

接口：

```text
public static readonly Godot.StringName CategoryIndex
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NFeedbackCategoryDropdownItem+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NDropdownItem+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NFeedbackScreenOpener

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private static MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NFeedbackScreenOpener <Instance>k__BackingField
MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NFeedbackScreenOpener Instance { public static get; private static set; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
private static System.Void set_Instance(MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NFeedbackScreenOpener value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public [async] System.Threading.Tasks.Task OpenFeedbackScreen()
public static MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NFeedbackScreenOpener get_Instance()
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Input(Godot.InputEvent inputEvent)
```

## MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NFeedbackScreenOpener+<OpenFeedbackScreen>d__7

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NFeedbackScreenOpener <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
private Godot.Image <screenshot>5__2
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NFeedbackScreenOpener+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Input
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NFeedbackScreenOpener+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NFeedbackScreenOpener+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Nodes.Combat.NSelectionReticle _selectionReticle
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnFocus()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnUnfocus
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _selectionReticle
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackCartoon

类型属性：`Public, BeforeFieldInit`；基类：`Godot.TextureRect`。

接口：`System.IDisposable`

```text
private static readonly System.Single _rot1
private static readonly System.Single _rot2
private Godot.Tween _tween
public System.Boolean opposite
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void SetRotation1()
public System.Void SetRotation2()
```

## MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackCartoon+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.TextureRect+MethodName`。

接口：

```text
public static readonly Godot.StringName SetRotation1
public static readonly Godot.StringName SetRotation2
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackCartoon+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.TextureRect+PropertyName`。

接口：

```text
public static readonly Godot.StringName _tween
public static readonly Godot.StringName opposite
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackCartoon+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.TextureRect+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackEmojiButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private static readonly Godot.Color _defaultColor
private System.Boolean _isSelected
private MegaCrit.Sts2.Core.Nodes.Combat.NSelectionReticle _selectionReticle
private Godot.Tween _tween
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnFocus()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void FlashError()
public System.Void SetSelected(System.Boolean isSelected)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackEmojiButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName FlashError
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName SetSelected
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackEmojiButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _isSelected
public static readonly Godot.StringName _selectionReticle
public static readonly Godot.StringName _tween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackEmojiButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackFlower

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private static const System.String _anticipationImage = "res://images/atlases/compressed.sprites/feedback/flower_anticipation.tres"
private static const System.String _noddingImage = "res://images/atlases/compressed.sprites/feedback/flower_happy.tres"
private static const System.String _normalImage = "res://images/atlases/compressed.sprites/feedback/flower.tres"
private Godot.Vector2 _originalPosition
private Godot.Tween _tween
private MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackCartoon <Cartoon>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackFlower+State <MyState>k__BackingField
MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackCartoon Cartoon { public get; private set; }
MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackFlower+State MyState { public get; private set; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void set_Cartoon(MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackCartoon value)
private System.Void set_MyState(MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackFlower+State value)
private System.Void SetRandomPosition()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackCartoon get_Cartoon()
public MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackFlower+State get_MyState()
public System.Void SetState(MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackFlower+State state)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackFlower+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName SetRandomPosition
public static readonly Godot.StringName SetState
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackFlower+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _originalPosition
public static readonly Godot.StringName _tween
public static readonly Godot.StringName Cartoon
public static readonly Godot.StringName MyState
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackFlower+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackFlower+State

类型属性：`NestedPublic, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackFlower+State Anticipation = 2
public static const MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackFlower+State Nodding = 1
public static const MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackFlower+State NoddingFast = 3
public static const MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackFlower+State None = 0
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackScreen

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private MegaCrit.Sts2.Core.Nodes.CommonUi.NBackButton _backButton
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackCartoon> _cartoons
private MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NFeedbackCategoryDropdown _categoryDropdown
private MegaCrit.Sts2.addons.mega_text.MegaLabel _categoryLabel
private static const System.String _defaultUrl = "https://feedback.sts2.megacrit.com/feedback"
private System.Int32 _descriptionCaretColumn
private System.Int32 _descriptionCaretLine
private MegaCrit.Sts2.Core.Nodes.GodotExtensions.NMegaTextEdit _descriptionInput
private System.String _descriptionText
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackEmojiButton> _emojiButtons
private MegaCrit.Sts2.addons.mega_text.MegaLabel _emojiLabel
private MegaCrit.Sts2.addons.mega_text.MegaLabel _failedLabel
private MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackFlower _flower
private static readonly System.Net.Http.HttpClient _httpClient
private System.UInt64 _lastClosedMsec
private Godot.Control _mainPanel
private static const System.Int32 _maxDescriptionChars = 8000
private Godot.Vector2 _originalSuccessPosition
private MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _returnToGameButton
private MegaCrit.Sts2.addons.mega_text.MegaLabel _returnToGameHoverLabel
private MegaCrit.Sts2.addons.mega_text.MegaLabel _returnToGameLabel
private System.Threading.Tasks.TaskCompletionSource _runInBackgroundTaskSource
private static readonly System.String _scenePath
private System.Threading.CancellationTokenSource _screenClosedCancelToken
private System.Byte[] _screenshotBytes
private MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackEmojiButton _selectedEmoteButton
private Godot.Control _sendBackstop
private MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _sendButton
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _sendingLabel
private MegaCrit.Sts2.addons.mega_text.MegaLabel _sendLabel
private Godot.Control _sendPanel
private MegaCrit.Sts2.addons.mega_text.MegaLabel _successLabel
private static const System.Single _superWiggleTime = 0.25
private static readonly System.String _url
private Godot.Tween _wiggleTween
Godot.Control DefaultFocusedControl { public virtual get; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task OnFeedbackFailed()
private [async] System.Threading.Tasks.Task OnFeedbackSuccess()
private [async] System.Threading.Tasks.Task SendFeedbackWrapper()
private static [async] System.Threading.Tasks.Task<System.Boolean> SendFeedback(MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.FeedbackData data, System.IO.Stream screenshotStream, System.IO.Stream logsMemoryStream)
private static System.Net.Http.MultipartFormDataContent BuildMultipartContent(MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.FeedbackData data, System.IO.Stream screenshotStream, System.IO.Stream logsStream)
private static System.String ExceptionMessageWithInner(System.Exception ex)
private System.Void <_Ready>b__36_0(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void ClearInput()
private System.Void Close()
private System.Void EmojiButtonSelected(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton button)
private System.Void OnDescriptionChanged()
private System.Void ReturnToGameFocused(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl _)
private System.Void ReturnToGameSelected(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void ReturnToGameUnfocused(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl _)
private System.Void SendButtonFocused(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl _)
private System.Void SendButtonSelected(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void SendButtonUnfocused(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl _)
private System.Void SetSelectedEmoji(MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackEmojiButton button)
private System.Void WiggleCartoons1()
private System.Void WiggleCartoons2()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackScreen Create()
public System.Void Open()
public System.Void Relocalize()
public System.Void SetScreenshot(Godot.Image screenshot)
public virtual Godot.Control get_DefaultFocusedControl()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackScreen+<OnFeedbackFailed>d__55

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackScreen <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackScreen+<OnFeedbackSuccess>d__56

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackScreen <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackScreen+<SendFeedback>d__52

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Boolean> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Net.Http.HttpResponseMessage> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<System.String> <>u__2
private System.Runtime.CompilerServices.TaskAwaiter <>u__3
private System.Int32 <attempt>5__5
private System.Int32[] <delaysMs>5__3
private System.Net.Http.MultipartFormDataContent <formContent>5__2
private System.Net.Http.HttpResponseMessage <response>5__6
private System.String <sentryMessage>5__4
public MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.FeedbackData data
public System.IO.Stream logsMemoryStream
public System.IO.Stream screenshotStream
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackScreen+<SendFeedbackWrapper>d__51

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackScreen <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__2
private System.Threading.Tasks.Task<System.Boolean> <sendTask>5__2
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackScreen+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName ClearInput
public static readonly Godot.StringName Close
public static readonly Godot.StringName Create
public static readonly Godot.StringName EmojiButtonSelected
public static readonly Godot.StringName OnDescriptionChanged
public static readonly Godot.StringName Open
public static readonly Godot.StringName Relocalize
public static readonly Godot.StringName ReturnToGameFocused
public static readonly Godot.StringName ReturnToGameSelected
public static readonly Godot.StringName ReturnToGameUnfocused
public static readonly Godot.StringName SendButtonFocused
public static readonly Godot.StringName SendButtonSelected
public static readonly Godot.StringName SendButtonUnfocused
public static readonly Godot.StringName SetScreenshot
public static readonly Godot.StringName SetSelectedEmoji
public static readonly Godot.StringName WiggleCartoons1
public static readonly Godot.StringName WiggleCartoons2
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackScreen+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _backButton
public static readonly Godot.StringName _categoryDropdown
public static readonly Godot.StringName _categoryLabel
public static readonly Godot.StringName _descriptionCaretColumn
public static readonly Godot.StringName _descriptionCaretLine
public static readonly Godot.StringName _descriptionInput
public static readonly Godot.StringName _descriptionText
public static readonly Godot.StringName _emojiLabel
public static readonly Godot.StringName _failedLabel
public static readonly Godot.StringName _flower
public static readonly Godot.StringName _lastClosedMsec
public static readonly Godot.StringName _mainPanel
public static readonly Godot.StringName _originalSuccessPosition
public static readonly Godot.StringName _returnToGameButton
public static readonly Godot.StringName _returnToGameHoverLabel
public static readonly Godot.StringName _returnToGameLabel
public static readonly Godot.StringName _screenshotBytes
public static readonly Godot.StringName _selectedEmoteButton
public static readonly Godot.StringName _sendBackstop
public static readonly Godot.StringName _sendButton
public static readonly Godot.StringName _sendingLabel
public static readonly Godot.StringName _sendLabel
public static readonly Godot.StringName _sendPanel
public static readonly Godot.StringName _successLabel
public static readonly Godot.StringName _wiggleTween
public static readonly Godot.StringName DefaultFocusedControl
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen.NSendFeedbackScreen+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```
