# MegaCrit.Sts2.Core.Nodes.Screens.Credits

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.Screens.Credits.NCreditsScreen

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private static const System.Single _autoScrollSpeed = 80
private MegaCrit.Sts2.Core.Nodes.CommonUi.NBackButton _backButton
private System.Boolean _canClose
private System.Boolean _exitingScreen
private static const System.Single _lerpSmoothness = 20
private static readonly System.String _scenePath
private Godot.Control _screenContents
private static const System.Single _scrollSpeed = 50
private static const System.String _table = "credits"
private System.Single _targetPosition
private static const System.Single _trackpadScrollSpeed = 20
private Godot.Tween _tween
Godot.Control DefaultFocusedControl { public virtual get; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task EnableScreenExit()
private [async] System.Threading.Tasks.Task FadeAndExitScreen()
private static System.String ShuffleOneColumn(System.String input)
private static System.ValueTuple<System.String, System.String> SplitTwoColumnMultiRole(System.String input)
private System.ValueTuple<System.String, System.String, System.String> SplitThreeColumnPlaytesters(System.String input)
private System.ValueTuple<System.String, System.String> SplitTwoColumn(System.String input)
private System.Void CloseScreenDebug()
private System.Void InitAdditionalProgramming()
private System.Void InitAdditionalVfx()
private System.Void InitComposer()
private System.Void InitConsultants()
private System.Void InitExitMessage()
private System.Void InitFmod()
private System.Void InitGodot()
private System.Void InitLocalization()
private System.Void InitMarketingSupport()
private System.Void InitMegaCrit()
private System.Void InitModdingSupport()
private System.Void InitPlaytesters()
private System.Void InitSpine()
private System.Void InitTrailer()
private System.Void InitTwitchExtension()
private System.Void InitVoices()
private System.Void ProcessScrollEvent(Godot.InputEvent inputEvent)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.Credits.NCreditsScreen Create()
public virtual Godot.Control get_DefaultFocusedControl()
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _GuiInput(Godot.InputEvent inputEvent)
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Credits.NCreditsScreen+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Screens.Credits.NCreditsScreen+<>c <>9
public static System.Func<System.String, System.String> <>9__41_0
public static System.Func<System.String, System.Boolean> <>9__41_1
public static System.Func<System.String, System.String> <>9__42_0
public static System.Func<System.String, System.Boolean> <>9__42_1
public static System.Func<System.String, System.String> <>9__43_0
private static .cctor()
public .ctor()
internal System.Boolean <SplitThreeColumnPlaytesters>b__42_1(System.String p)
internal System.Boolean <SplitTwoColumn>b__41_1(System.String p)
internal System.String <SplitThreeColumnPlaytesters>b__42_0(System.String p)
internal System.String <SplitTwoColumn>b__41_0(System.String p)
internal System.String <SplitTwoColumnMultiRole>b__43_0(System.String r)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Credits.NCreditsScreen+<EnableScreenExit>d__34

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.Credits.NCreditsScreen <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Credits.NCreditsScreen+<FadeAndExitScreen>d__36

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.Credits.NCreditsScreen <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Credits.NCreditsScreen+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _GuiInput
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName CloseScreenDebug
public static readonly Godot.StringName Create
public static readonly Godot.StringName InitAdditionalProgramming
public static readonly Godot.StringName InitAdditionalVfx
public static readonly Godot.StringName InitComposer
public static readonly Godot.StringName InitConsultants
public static readonly Godot.StringName InitExitMessage
public static readonly Godot.StringName InitFmod
public static readonly Godot.StringName InitGodot
public static readonly Godot.StringName InitLocalization
public static readonly Godot.StringName InitMarketingSupport
public static readonly Godot.StringName InitMegaCrit
public static readonly Godot.StringName InitModdingSupport
public static readonly Godot.StringName InitPlaytesters
public static readonly Godot.StringName InitSpine
public static readonly Godot.StringName InitTrailer
public static readonly Godot.StringName InitTwitchExtension
public static readonly Godot.StringName InitVoices
public static readonly Godot.StringName ProcessScrollEvent
public static readonly Godot.StringName ShuffleOneColumn
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Credits.NCreditsScreen+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _backButton
public static readonly Godot.StringName _canClose
public static readonly Godot.StringName _exitingScreen
public static readonly Godot.StringName _screenContents
public static readonly Godot.StringName _targetPosition
public static readonly Godot.StringName _tween
public static readonly Godot.StringName DefaultFocusedControl
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Credits.NCreditsScreen+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```
