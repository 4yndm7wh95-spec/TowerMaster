# MegaCrit.Sts2.Core.Nodes.Vfx.Cards

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NBolasVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private Godot.Node2D _bola2
private Godot.Node2D _bola3
private Godot.Vector2 _controlPosition
private Godot.Vector2 _endPosition
private System.Single _rotationSpeed
private static readonly System.String _scenePath
private Godot.Vector2 _startPosition
private Godot.Tween _tween
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task FlyBolasFly()
private System.Void FollowCurve(System.Single progressPercent)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NBolasVfx Create(MegaCrit.Sts2.Core.Entities.Creatures.Creature owner, MegaCrit.Sts2.Core.Entities.Creatures.Creature target)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Void _ExitTree()
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NBolasVfx+<FlyBolasFly>d__13

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NBolasVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NBolasVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName FollowCurve
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NBolasVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _bola2
public static readonly Godot.StringName _bola3
public static readonly Godot.StringName _controlPosition
public static readonly Godot.StringName _endPosition
public static readonly Godot.StringName _rotationSpeed
public static readonly Godot.StringName _startPosition
public static readonly Godot.StringName _tween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NBolasVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardExhaustQuickVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private System.Single _anticipationDuration
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NParticlesContainer _anticipationParticlesContainer
private MegaCrit.Sts2.Core.Nodes.Cards.NCard _cardNode
private System.Boolean _isFinishing
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NParticlesContainer _particlesContainer
public static readonly System.String scenePath
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task DelayedFree()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public [async] System.Threading.Tasks.Task PlayAnimation()
public static MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardExhaustQuickVfx Create(MegaCrit.Sts2.Core.Nodes.Cards.NCard cardNode)
public virtual System.Void _ExitTree()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardExhaustQuickVfx+<DelayedFree>d__8

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardExhaustQuickVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardExhaustQuickVfx+<PlayAnimation>d__7

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardExhaustQuickVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardExhaustQuickVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName Create
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardExhaustQuickVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _anticipationDuration
public static readonly Godot.StringName _anticipationParticlesContainer
public static readonly Godot.StringName _cardNode
public static readonly Godot.StringName _isFinishing
public static readonly Godot.StringName _particlesContainer
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardExhaustQuickVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardExhaustVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Nodes.Cards.NCard _cardNode
private Godot.Control _cardParentContainer
private static readonly Godot.StringName _erosionBaseParameter
private Godot.Vector2 _erosionBaseRange
private static readonly Godot.StringName _erosionOffsetParameter
private Godot.Curve _exhaustCurve
private System.Single _exhaustDuration
private Godot.Control _materialContainer
private Godot.Vector2 _particleHeightRange
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NParticlesContainer _particlesContainer
private Godot.Vector2 _position
public static readonly System.String scenePath
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task DelayedFree()
private System.Void SetParticlesPlaying(System.Boolean isPlaying)
private System.Void SetProgress(System.Single progress)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public [async] System.Threading.Tasks.Task PlayAnimation()
public static MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardExhaustVfx Create(MegaCrit.Sts2.Core.Nodes.Cards.NCard cardNode)
public virtual System.Void _ExitTree()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardExhaustVfx+<DelayedFree>d__16

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardExhaustVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardExhaustVfx+<PlayAnimation>d__15

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardExhaustVfx <>4__this
private System.Single <>7__wrap1
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardExhaustVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName Create
public static readonly Godot.StringName SetParticlesPlaying
public static readonly Godot.StringName SetProgress
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardExhaustVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _cardNode
public static readonly Godot.StringName _cardParentContainer
public static readonly Godot.StringName _erosionBaseRange
public static readonly Godot.StringName _exhaustCurve
public static readonly Godot.StringName _exhaustDuration
public static readonly Godot.StringName _materialContainer
public static readonly Godot.StringName _particleHeightRange
public static readonly Godot.StringName _particlesContainer
public static readonly Godot.StringName _position
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardExhaustVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardRareGlow

类型属性：`Public, BeforeFieldInit`；基类：`Godot.GpuParticles2D`。

接口：`System.IDisposable`

```text
private static readonly System.String _scenePath
private Godot.Tween _tween
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardRareGlow Create()
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Void Kill()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardRareGlow+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.GpuParticles2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName Kill
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardRareGlow+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.GpuParticles2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _tween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardRareGlow+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.GpuParticles2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardRemoveVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private System.Single _anticipationDuration
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NParticlesContainer _anticipationParticles
private MegaCrit.Sts2.Core.Nodes.Cards.NCard _cardNode
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NParticlesContainer _cardParticles
private System.Single _slashEndDelay
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NParticlesContainer _slashEndParticles
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NParticlesContainer _slashStartParticles
public static const System.Single deleteCardDelay = 0.4
public static readonly System.String scenePath
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task DelayedFree()
private [async] System.Threading.Tasks.Task PlayAnimation()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardRemoveVfx Create(MegaCrit.Sts2.Core.Nodes.Cards.NCard cardNode)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardRemoveVfx+<DelayedFree>d__12

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardRemoveVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardRemoveVfx+<PlayAnimation>d__11

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardRemoveVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardRemoveVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardRemoveVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _anticipationDuration
public static readonly Godot.StringName _anticipationParticles
public static readonly Godot.StringName _cardNode
public static readonly Godot.StringName _cardParticles
public static readonly Godot.StringName _slashEndDelay
public static readonly Godot.StringName _slashEndParticles
public static readonly Godot.StringName _slashStartParticles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardRemoveVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardTransformShineVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private Godot.CurveXyzTexture _anticipationScaleCurve
private Godot.Control _borderGlow
private MegaCrit.Sts2.Core.Nodes.Cards.NCard _cardNode
private MegaCrit.Sts2.Core.Models.CardModel _endCard
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NParticlesContainer _endParticles
private System.Single _endParticlesDelay
private System.Single _glowFadeDuration
private System.Single _glowTopScale
private static Godot.Vector2 _originalCardScale
private Godot.Control _overlay
private System.Single _overlayHideDuration
private System.Single _overlayIdleDuration
private System.Single _overlayIdleShortDuration
private System.Single _overlayShowDuration
private System.Single _overlayShowShortDuration
private System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.RelicModel> _relicsToFlash
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NParticlesContainer _revealParticles
private Godot.CurveXyzTexture _revealScaleCurve
private System.Single _shineDelay
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NParticlesContainer _shineParticles
private Godot.Tween _tween
private Godot.Color _whiteClear
private Godot.Color _whiteOpaque
public static readonly System.String scenePath
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task AnimatingCardScale(Godot.CurveXyzTexture curve, System.Single duration)
private [async] System.Threading.Tasks.Task DelayedFree()
private [async] System.Threading.Tasks.Task<System.Boolean> WaitAndInterruptIfNecessary(System.Single seconds, MegaCrit.Sts2.Core.Nodes.Cards.NCard cardNode)
private static System.Void UpdateCard(MegaCrit.Sts2.Core.Nodes.Cards.NCard cardNode, MegaCrit.Sts2.Core.Models.CardModel endCard)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public [async] System.Threading.Tasks.Task PlayAnimation(System.Boolean shortVersion = False)
public [async] System.Threading.Tasks.Task PlayAnimationWithoutWaitingForEnd(System.Boolean shortVersion = False)
public [async] System.Threading.Tasks.Task PlayShineAndReveal()
public [async] System.Threading.Tasks.Task PlayUntilCardUpdate(System.Boolean shortVersion = False)
public static MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardTransformShineVfx Create(MegaCrit.Sts2.Core.Nodes.Cards.NCard cardNode, MegaCrit.Sts2.Core.Models.CardModel endCard, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.RelicModel> relicsToFlash)
public virtual System.Void _ExitTree()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardTransformShineVfx+<AnimatingCardScale>d__33

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardTransformShineVfx <>4__this
private System.Single <>7__wrap1
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
public Godot.CurveXyzTexture curve
public System.Single duration
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardTransformShineVfx+<DelayedFree>d__32

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardTransformShineVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardTransformShineVfx+<PlayAnimation>d__30

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardTransformShineVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public System.Boolean shortVersion
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardTransformShineVfx+<PlayAnimationWithoutWaitingForEnd>d__31

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardTransformShineVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public System.Boolean shortVersion
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardTransformShineVfx+<PlayShineAndReveal>d__29

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardTransformShineVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardTransformShineVfx+<PlayUntilCardUpdate>d__28

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardTransformShineVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
public System.Boolean shortVersion
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardTransformShineVfx+<WaitAndInterruptIfNecessary>d__26

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardTransformShineVfx <>4__this
private System.Single <>7__wrap1
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Boolean> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
public MegaCrit.Sts2.Core.Nodes.Cards.NCard cardNode
public System.Single seconds
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardTransformShineVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardTransformShineVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _anticipationScaleCurve
public static readonly Godot.StringName _borderGlow
public static readonly Godot.StringName _cardNode
public static readonly Godot.StringName _endParticles
public static readonly Godot.StringName _endParticlesDelay
public static readonly Godot.StringName _glowFadeDuration
public static readonly Godot.StringName _glowTopScale
public static readonly Godot.StringName _overlay
public static readonly Godot.StringName _overlayHideDuration
public static readonly Godot.StringName _overlayIdleDuration
public static readonly Godot.StringName _overlayIdleShortDuration
public static readonly Godot.StringName _overlayShowDuration
public static readonly Godot.StringName _overlayShowShortDuration
public static readonly Godot.StringName _revealParticles
public static readonly Godot.StringName _revealScaleCurve
public static readonly Godot.StringName _shineDelay
public static readonly Godot.StringName _shineParticles
public static readonly Godot.StringName _tween
public static readonly Godot.StringName _whiteClear
public static readonly Godot.StringName _whiteOpaque
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardTransformShineVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardUncommonGlow

类型属性：`Public, BeforeFieldInit`；基类：`Godot.GpuParticles2D`。

接口：`System.IDisposable`

```text
private static readonly System.String _scenePath
private Godot.Tween _tween
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardUncommonGlow Create()
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Void Kill()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardUncommonGlow+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.GpuParticles2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName Kill
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardUncommonGlow+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.GpuParticles2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _tween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardUncommonGlow+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.GpuParticles2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NFanOfKnivesVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private static const System.Double _fanDuration = 0.8
private static const System.String _fanOfKnivesSfx = "event:/sfx/characters/silent/silent_fan_of_knives"
private Godot.Tween _fanTween
private static readonly System.String _scenePath
private Godot.Node2D _shiv1
private Godot.Node2D _shiv2
private Godot.Node2D _shiv3
private Godot.Node2D _shiv4
private Godot.Node2D _shiv5
private Godot.Node2D _shiv6
private Godot.Node2D _shiv7
private Godot.Node2D _shiv8
private Godot.Node2D _shiv9
private readonly System.Collections.Generic.List<Godot.Node2D> _shivs
private Godot.Vector2 _spawnPosition
private Godot.Tween _spawnTween
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task Animate()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NFanOfKnivesVfx Create(MegaCrit.Sts2.Core.Entities.Creatures.Creature target)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NFanOfKnivesVfx+<Animate>d__21

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NFanOfKnivesVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NFanOfKnivesVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NFanOfKnivesVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _fanTween
public static readonly Godot.StringName _shiv1
public static readonly Godot.StringName _shiv2
public static readonly Godot.StringName _shiv3
public static readonly Godot.StringName _shiv4
public static readonly Godot.StringName _shiv5
public static readonly Godot.StringName _shiv6
public static readonly Godot.StringName _shiv7
public static readonly Godot.StringName _shiv8
public static readonly Godot.StringName _shiv9
public static readonly Godot.StringName _spawnPosition
public static readonly Godot.StringName _spawnTween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NFanOfKnivesVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NHellraiserAttackVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
private System.Void OnTweenFinished()
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NHellraiserAttackVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnTweenFinished
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NHellraiserAttackVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NHellraiserAttackVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NHellraiserSwordVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private static readonly System.String _scenePath
private Godot.TextureRect _sword
private static readonly Godot.StringName _swordStr
public System.Single posY
public Godot.Color targetColor
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnTweenFinished()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NHellraiserSwordVfx Create()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NHellraiserSwordVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName OnTweenFinished
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NHellraiserSwordVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _sword
public static readonly Godot.StringName posY
public static readonly Godot.StringName targetColor
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NHellraiserSwordVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NHellraiserVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private System.Threading.CancellationTokenSource _cts
private System.Single _duration
private static const System.String _hellraiserSfxPath = "event:/sfx/characters/ironclad/ironclad_hellraiser"
private static readonly System.String _scenePath
private Godot.Vector2 _spawnPosition
private System.Int32 _swordAmount
private static readonly Godot.Vector2 _vfxOffset
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task SelfDestruct()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NHellraiserVfx Create(MegaCrit.Sts2.Core.Entities.Creatures.Creature target)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NHellraiserVfx+<SelfDestruct>d__12

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NHellraiserVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NHellraiserVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NHellraiserVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _duration
public static readonly Godot.StringName _spawnPosition
public static readonly Godot.StringName _swordAmount
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NHellraiserVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NNightmareHandsVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private System.Threading.CancellationTokenSource _cts
private static readonly System.String _scenePath
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
private [async] System.Threading.Tasks.Task SelfDestruct()
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NNightmareHandsVfx Create()
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NNightmareHandsVfx+<SelfDestruct>d__7

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NNightmareHandsVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NNightmareHandsVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NNightmareHandsVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NNightmareHandsVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NSpikeSplashVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private System.Threading.CancellationTokenSource _cts
private System.Single _duration
private static readonly System.String _scenePath
private Godot.Vector2 _spawnPosition
private System.Int32 _spikeAmount
private MegaCrit.Sts2.Core.Nodes.Vfx.VfxColor _vfxColor
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task SelfDestruct()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NSpikeSplashVfx Create(MegaCrit.Sts2.Core.Entities.Creatures.Creature target, MegaCrit.Sts2.Core.Nodes.Vfx.VfxColor vfxColor = 0)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NSpikeSplashVfx+<SelfDestruct>d__9

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NSpikeSplashVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NSpikeSplashVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NSpikeSplashVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _duration
public static readonly Godot.StringName _spawnPosition
public static readonly Godot.StringName _spikeAmount
public static readonly Godot.StringName _vfxColor
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NSpikeSplashVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NSpookyHandVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private System.Single _canPauseTimer
private System.Single _duration
private System.Single _elapsedPauseTime
private System.Single _intensity
private System.Boolean _isPaused
private System.Single _originalRotation
private System.Int32 _pauseCounter
private static const System.Single _pauseDuration = 0.05
private System.Single _speed
private Godot.Vector2 _targetScale
private System.Single _timer
private System.Int32 _totalPauses
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void AnimateIn()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NSpookyHandVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AnimateIn
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NSpookyHandVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _canPauseTimer
public static readonly Godot.StringName _duration
public static readonly Godot.StringName _elapsedPauseTime
public static readonly Godot.StringName _intensity
public static readonly Godot.StringName _isPaused
public static readonly Godot.StringName _originalRotation
public static readonly Godot.StringName _pauseCounter
public static readonly Godot.StringName _speed
public static readonly Godot.StringName _targetScale
public static readonly Godot.StringName _timer
public static readonly Godot.StringName _totalPauses
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NSpookyHandVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```
