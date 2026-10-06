# MegaCrit.Sts2.Core.Nodes.Reaction

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.Reaction.NReaction

类型属性：`Public, BeforeFieldInit`；基类：`Godot.TextureRect`。

接口：`System.IDisposable`

```text
private static const System.String _exclamationPath = "res://images/ui/emote/exclaim.png"
private static const System.String _happyCultistPath = "res://images/ui/emote/happy_cultist.png"
private static const System.String _heartPath = "res://images/ui/emote/heart.png"
private static const System.String _questionMarkPath = "res://images/ui/emote/question.png"
private static const System.String _sadSlimePath = "res://images/ui/emote/slime_sad.png"
private static readonly System.String _scenePath
private static const System.String _skullPath = "res://images/ui/emote/skull.png"
private static const System.String _thumbDownPath = "res://images/ui/emote/thumb_down.png"
private static const System.String _thumbUpPath = "res://images/ui/emote/thumb_up.png"
MegaCrit.Sts2.Core.Entities.Multiplayer.ReactionType Type { public get; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task DoAnim()
private static Godot.Texture2D TypeToTexture(MegaCrit.Sts2.Core.Entities.Multiplayer.ReactionType type)
private static MegaCrit.Sts2.Core.Entities.Multiplayer.ReactionType TextureToType(Godot.Texture2D texture)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public MegaCrit.Sts2.Core.Entities.Multiplayer.ReactionType get_Type()
public static MegaCrit.Sts2.Core.Nodes.Reaction.NReaction Create(Godot.Texture2D reactionTexture)
public static MegaCrit.Sts2.Core.Nodes.Reaction.NReaction Create(MegaCrit.Sts2.Core.Entities.Multiplayer.ReactionType type)
public System.Void BeginAnim()
```

## MegaCrit.Sts2.Core.Nodes.Reaction.NReaction+<DoAnim>d__14

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Reaction.NReaction <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Reaction.NReaction+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.TextureRect+MethodName`。

接口：

```text
public static readonly Godot.StringName BeginAnim
public static readonly Godot.StringName Create
public static readonly Godot.StringName TextureToType
public static readonly Godot.StringName TypeToTexture
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Reaction.NReaction+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.TextureRect+PropertyName`。

接口：

```text
public static readonly Godot.StringName Type
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Reaction.NReaction+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.TextureRect+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Reaction.NReactionContainer

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Multiplayer.Game.ReactionSynchronizer _synchronizer
System.Boolean InMultiplayer { public get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void NetServiceDisconnected(MegaCrit.Sts2.Core.Entities.Multiplayer.NetErrorInfo _)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Boolean get_InMultiplayer()
public System.Void DeinitializeNetworking()
public System.Void DoLocalReaction(Godot.Texture2D tex, Godot.Vector2 position)
public System.Void DoRemoteReaction(MegaCrit.Sts2.Core.Entities.Multiplayer.ReactionType type, Godot.Vector2 position)
public System.Void InitializeNetworking(MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService netService)
public virtual System.Void _ExitTree()
```

## MegaCrit.Sts2.Core.Nodes.Reaction.NReactionContainer+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName DeinitializeNetworking
public static readonly Godot.StringName DoLocalReaction
public static readonly Godot.StringName DoRemoteReaction
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Reaction.NReactionContainer+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName InMultiplayer
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Reaction.NReactionContainer+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Reaction.NReactionWheel

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private Godot.Vector2 _centerPosition
private static const System.Single _centerRadius = 70
private MegaCrit.Sts2.Core.Nodes.Reaction.NReactionWheelWedge _downLeftWedge
private MegaCrit.Sts2.Core.Nodes.Reaction.NReactionWheelWedge _downRightWedge
private MegaCrit.Sts2.Core.Nodes.Reaction.NReactionWheelWedge _downWedge
private System.Boolean _ignoreNextMouseInput
private MegaCrit.Sts2.Core.Nodes.Reaction.NReactionWheelWedge _leftWedge
private MegaCrit.Sts2.Core.Entities.Players.Player _localPlayer
private Godot.TextureRect _marker
private static readonly Godot.StringName _reactWheel
private MegaCrit.Sts2.Core.Nodes.Reaction.NReactionWheelWedge _rightWedge
private MegaCrit.Sts2.Core.Nodes.Reaction.NReactionWheelWedge _selectedWedge
private MegaCrit.Sts2.Core.Nodes.Reaction.NReactionWheelWedge _upLeftWedge
private MegaCrit.Sts2.Core.Nodes.Reaction.NReactionWheelWedge _upRightWedge
private MegaCrit.Sts2.Core.Nodes.Reaction.NReactionWheelWedge _upWedge
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private MegaCrit.Sts2.Core.Nodes.Reaction.NReactionWheelWedge GetSelectedWedge(System.Single angle)
private System.Void HideWheel()
private System.Void MoveMarker(Godot.Vector2 relative)
private System.Void OnRunStarted(MegaCrit.Sts2.Core.Runs.RunState runState)
private System.Void React()
private System.Void WarpMouseBackToOriginalPosition()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Input(Godot.InputEvent inputEvent)
public virtual System.Void _Notification(System.Int32 what)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Reaction.NReactionWheel+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Input
public static readonly Godot.StringName _Notification
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName GetSelectedWedge
public static readonly Godot.StringName HideWheel
public static readonly Godot.StringName MoveMarker
public static readonly Godot.StringName React
public static readonly Godot.StringName WarpMouseBackToOriginalPosition
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Reaction.NReactionWheel+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _centerPosition
public static readonly Godot.StringName _downLeftWedge
public static readonly Godot.StringName _downRightWedge
public static readonly Godot.StringName _downWedge
public static readonly Godot.StringName _ignoreNextMouseInput
public static readonly Godot.StringName _leftWedge
public static readonly Godot.StringName _marker
public static readonly Godot.StringName _rightWedge
public static readonly Godot.StringName _selectedWedge
public static readonly Godot.StringName _upLeftWedge
public static readonly Godot.StringName _upRightWedge
public static readonly Godot.StringName _upWedge
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Reaction.NReactionWheel+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Reaction.NReactionWheelWedge

类型属性：`Public, BeforeFieldInit`；基类：`Godot.TextureRect`。

接口：`System.IDisposable`

```text
private static readonly Godot.Color _defaultColor
private Godot.Vector2 _defaultPosition
private Godot.Vector2 _normal
private static readonly Godot.Color _selectedColor
private Godot.TextureRect _textureRect
private Godot.Tween _tween
Godot.Texture2D Reaction { public get; }
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
public Godot.Texture2D get_Reaction()
public System.Void OnDeselected()
public System.Void OnSelected()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Reaction.NReactionWheelWedge+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.TextureRect+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnDeselected
public static readonly Godot.StringName OnSelected
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Reaction.NReactionWheelWedge+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.TextureRect+PropertyName`。

接口：

```text
public static readonly Godot.StringName _defaultPosition
public static readonly Godot.StringName _normal
public static readonly Godot.StringName _textureRect
public static readonly Godot.StringName _tween
public static readonly Godot.StringName Reaction
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Reaction.NReactionWheelWedge+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.TextureRect+SignalName`。

接口：

```text
public .ctor()
```
