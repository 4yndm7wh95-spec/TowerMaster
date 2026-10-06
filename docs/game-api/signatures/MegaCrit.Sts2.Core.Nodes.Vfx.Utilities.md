# MegaCrit.Sts2.Core.Nodes.Vfx.Utilities

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.DialogueSide

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.DialogueSide Left = 1
public static const MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.DialogueSide None = 0
public static const MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.DialogueSide Right = 2
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.DialogueStyle

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.DialogueStyle None = 0
public static const MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.DialogueStyle Speech = 2
public static const MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.DialogueStyle Thought = 1
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.LocalizedTexture

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Resource`。

接口：`System.IDisposable`

```text
private Godot.Collections.Dictionary<System.String, Godot.Texture2D> _textures
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Boolean TryGetTexture(out Godot.Texture2D texture)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.LocalizedTexture+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Resource+MethodName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.LocalizedTexture+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Resource+PropertyName`。

接口：

```text
public static readonly Godot.StringName _textures
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.LocalizedTexture+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Resource+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NHitStop

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private System.Threading.CancellationTokenSource _cancelToken
private static const System.Single _minTimeScale = 0.1
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
private [async] System.Threading.Tasks.Task HitStopTask(MegaCrit.Sts2.Core.Helpers.Ease+Functions easing, System.Single seconds)
private MegaCrit.Sts2.Core.Helpers.Ease+Functions EaseForStrength(MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.ShakeStrength strength)
private System.Single SecondsForDuration(MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.ShakeDuration duration)
private System.Void SetTimeScale(System.Single timeScale)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void DoHitStop(MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.ShakeStrength strength, MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.ShakeDuration duration)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NHitStop+<HitStopTask>d__3

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NHitStop <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
private System.UInt64 <lastTicks>5__2
private System.Single <timer>5__3
public MegaCrit.Sts2.Core.Helpers.Ease+Functions easing
public System.Single seconds
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NHitStop+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName DoHitStop
public static readonly Godot.StringName EaseForStrength
public static readonly Godot.StringName SecondsForDuration
public static readonly Godot.StringName SetTimeScale
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NHitStop+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NHitStop+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NParticlesContainer

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private Godot.Collections.Array<Godot.GpuParticles2D> _particles
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void Restart()
public System.Void SetEmitting(System.Boolean emitting)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NParticlesContainer+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName Restart
public static readonly Godot.StringName SetEmitting
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NParticlesContainer+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _particles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NParticlesContainer+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NScreenShake

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private readonly System.Collections.Generic.Dictionary<MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.ShakeDuration, System.Double> _duration
private System.Single _multiplier
private Godot.Vector2 _originalTargetPosition
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.ScreenRumbleInstance _rumbleInstance
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.ScreenPunchInstance _shakeInstance
private readonly System.Collections.Generic.Dictionary<MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.ShakeStrength, System.Single> _strength
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.ScreenTraumaRumble _traumaRumble
private Godot.Control <ShakeTarget>k__BackingField
Godot.Control ShakeTarget { public get; private set; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void set_ShakeTarget(Godot.Control value)
private System.Void StopRumble()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public Godot.Control get_ShakeTarget()
public System.Void AddTrauma(MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.ShakeStrength strength)
public System.Void ClearTarget()
public System.Void Rumble(MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.ShakeStrength strength, MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.ShakeDuration duration, MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.RumbleStyle style)
public System.Void SetMultiplier(System.Single multiplier)
public System.Void SetTarget(Godot.Control targetScreen)
public System.Void Shake(MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.ShakeStrength strength, MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.ShakeDuration duration, System.Single degAngle)
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NScreenShake+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AddTrauma
public static readonly Godot.StringName ClearTarget
public static readonly Godot.StringName Rumble
public static readonly Godot.StringName SetMultiplier
public static readonly Godot.StringName SetTarget
public static readonly Godot.StringName Shake
public static readonly Godot.StringName StopRumble
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NScreenShake+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _multiplier
public static readonly Godot.StringName _originalTargetPosition
public static readonly Godot.StringName ShakeTarget
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NScreenShake+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NShaker

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private System.Single _frequency
private System.Single _maxPosOffset
private System.Single _maxRotOffset
private Godot.Vector2 _previousShakePos
private System.Single _previousShakeRot
private Godot.Vector2 _shakePos
private System.Single _shakeRot
private System.Single _strength
private Godot.Node2D _target
private System.Single _timer
System.Single Strength { public get; public set; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void SetTargetTransform(Godot.Vector2 position, System.Single rotation)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Single get_Strength()
public System.Void set_Strength(System.Single value)
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NShaker+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName SetTargetTransform
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NShaker+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _frequency
public static readonly Godot.StringName _maxPosOffset
public static readonly Godot.StringName _maxRotOffset
public static readonly Godot.StringName _previousShakePos
public static readonly Godot.StringName _previousShakeRot
public static readonly Godot.StringName _shakePos
public static readonly Godot.StringName _shakeRot
public static readonly Godot.StringName _strength
public static readonly Godot.StringName _target
public static readonly Godot.StringName _timer
public static readonly Godot.StringName Strength
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NShaker+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NSpineSpriteBoneFollower

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private System.String _boneName
private System.Single _interpolationSpeed
private System.Boolean _snap
private Godot.Node2D _target
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _targetSprite
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void SetSpineSprite(Godot.Node2D target, System.String boneName)
public System.Void SetSpineSprite(MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite spineSprite, System.String boneName)
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NSpineSpriteBoneFollower+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName SetSpineSprite
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NSpineSpriteBoneFollower+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _boneName
public static readonly Godot.StringName _interpolationSpeed
public static readonly Godot.StringName _snap
public static readonly Godot.StringName _target
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NSpineSpriteBoneFollower+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NSpineSpriteCopier

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _selfSpineSprite
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _targetSpineSprite
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
private System.Void OnAnimationStart(Godot.GodotObject spineSprite, Godot.GodotObject animationState, Godot.GodotObject trackEntry)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void Initialize(MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite targetSprite, Godot.Node2D sourceNode)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NSpineSpriteCopier+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName OnAnimationStart
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NSpineSpriteCopier+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NSpineSpriteCopier+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NSpriteAnimator

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Sprite2D`。

接口：`System.IDisposable`

```text
private readonly System.Threading.CancellationTokenSource _cancelToken
private System.Single _fps
private Godot.Texture2D[] _frames
private System.Boolean _loop
private System.Boolean _randomizeRotation
private Godot.Vector2 _rotationRange
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task PlayAnimation()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NSpriteAnimator+<PlayAnimation>d__8

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NSpriteAnimator <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Int32 <i>5__2
private System.Int32 <interval>5__3
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NSpriteAnimator+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Sprite2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NSpriteAnimator+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Sprite2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _fps
public static readonly Godot.StringName _frames
public static readonly Godot.StringName _loop
public static readonly Godot.StringName _randomizeRotation
public static readonly Godot.StringName _rotationRange
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NSpriteAnimator+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Sprite2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NTrail2D

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Line2D`。

接口：`System.IDisposable`

```text
private System.Boolean _isActive
private System.Int32 _maxSegments
private Godot.Node2D _parent
private readonly System.Collections.Generic.List<Godot.Vector2> _pointQueue
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private Godot.Vector2 <_Process>b__6_0(Godot.Vector2 point)
private System.Void OnToggleVisibility()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NTrail2D+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Line2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnToggleVisibility
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NTrail2D+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Line2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _isActive
public static readonly Godot.StringName _maxSegments
public static readonly Godot.StringName _parent
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NTrail2D+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Line2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NValueRamp

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private System.Single _currentValue
private System.Boolean _didForceValueThisFrame
private System.Boolean _isIncreasing
private Godot.Curve _rampCurve
private System.Single _rampSpeed
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Boolean TryProcess(System.Double delta, out System.Single returnValue)
public System.Void ForceValue(System.Single forcedValue)
public System.Void SetIncreasing(System.Boolean isIncreasing)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NValueRamp+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName ForceValue
public static readonly Godot.StringName SetIncreasing
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NValueRamp+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _currentValue
public static readonly Godot.StringName _didForceValueThisFrame
public static readonly Godot.StringName _isIncreasing
public static readonly Godot.StringName _rampCurve
public static readonly Godot.StringName _rampSpeed
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NValueRamp+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NVfxParticleSystem

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private System.Single _lifetime
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void AfterExpired()
private System.Void TryPlayParticles(Godot.Node node)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NVfxParticleSystem+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AfterExpired
public static readonly Godot.StringName TryPlayParticles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NVfxParticleSystem+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _lifetime
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NVfxParticleSystem+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NVfxProjectile

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private System.Boolean _alignToVelocity
private Godot.GpuParticles2D[] _particles
private Godot.Node2D _projectileHead
System.Boolean AlignToVelocity { public get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Boolean get_AlignToVelocity()
public System.Void SetEmitting(System.Boolean emitting)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NVfxProjectile+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName SetEmitting
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NVfxProjectile+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _alignToVelocity
public static readonly Godot.StringName _particles
public static readonly Godot.StringName _projectileHead
public static readonly Godot.StringName AlignToVelocity
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NVfxProjectile+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NVfxProjectileHandler

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private Godot.Vector2 _destinationGlobalPosition
private Godot.Callable _endAction
private Godot.Vector2 _heightOffsetRange
private System.String _impactParticlesScenePath
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NVfxProjectile _loadedProjectile
private Godot.Curve[] _movementCurves
private Godot.Curve[] _pathHeightOffsets
private System.String _projectileScenePath
private Godot.Vector2 _sourceGlobalPosition
private Godot.Vector2 _travelTimeRange
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task DelayedFree()
private [async] System.Threading.Tasks.Task PlaySequence()
private System.Void SpawnImpactVfx(Godot.Vector2 spawnPosition)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NVfxProjectileHandler Create(System.String handlerScenePath, System.String projectileScenePath, Godot.Vector2 sourceGlobalPosition, Godot.Vector2 destinationGlobalPosition, Godot.Callable endAction)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NVfxProjectileHandler+<DelayedFree>d__15

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NVfxProjectileHandler <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NVfxProjectileHandler+<PlaySequence>d__13

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NVfxProjectileHandler <>4__this
private System.Single <>7__wrap6
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
private Godot.Curve <chosenHeightCurve>5__6
private Godot.Curve <chosenMovementCurve>5__5
private Godot.Vector2 <normal>5__2
private System.Single <projectileDuration>5__3
private System.Single <projectileHeightOffset>5__4
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NVfxProjectileHandler+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName SpawnImpactVfx
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NVfxProjectileHandler+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _destinationGlobalPosition
public static readonly Godot.StringName _endAction
public static readonly Godot.StringName _heightOffsetRange
public static readonly Godot.StringName _impactParticlesScenePath
public static readonly Godot.StringName _loadedProjectile
public static readonly Godot.StringName _movementCurves
public static readonly Godot.StringName _pathHeightOffsets
public static readonly Godot.StringName _projectileScenePath
public static readonly Godot.StringName _sourceGlobalPosition
public static readonly Godot.StringName _travelTimeRange
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NVfxProjectileHandler+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NVfxSpine

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private System.String _animation
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void <_Ready>b__1_0(MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState animState)
private System.Void AnimationEnded(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NVfxSpine+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AnimationEnded
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NVfxSpine+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _animation
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NVfxSpine+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.RumbleStyle

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.RumbleStyle Drunk = 2
public static const MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.RumbleStyle None = 0
public static const MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.RumbleStyle Rumble = 1
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.ScreenPunchInstance

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.ShakeInstance`。

接口：

```text
public .ctor(System.Single strength, System.Double duration, System.Single degAngle)
public System.Void Cancel()
public virtual Godot.Vector2 Update(System.Double delta)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.ScreenRumbleInstance

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.ShakeInstance`。

接口：

```text
private readonly Godot.FastNoiseLite _noise
private readonly System.Single _randomOffset
private readonly System.Single _speed
private readonly MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.RumbleStyle _style
private Godot.Vector2 _targetOffset
public .ctor(System.Single strength, System.Double duration, System.Single speedMultiplier, MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.RumbleStyle style)
public virtual Godot.Vector2 Update(System.Double delta)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.ScreenTraumaRumble

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static const System.Single _decayRate = 2
private System.Double _duration
private static const System.Single _maxShake = 50
private System.Single _multiplier
private readonly Godot.FastNoiseLite _noise
private static const System.Single _rumbleAmount = 200
private static const System.Single _speed = 1000
private System.Single _trauma
public .ctor()
public Godot.Vector2 Update(System.Double delta)
public System.Void AddTrauma(MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.ShakeStrength amount)
public System.Void SetMultiplier(System.Single multiplier)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.ShakeDuration

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.ShakeDuration Forever = 4
public static const MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.ShakeDuration Long = 3
public static const MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.ShakeDuration None = 0
public static const MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.ShakeDuration Normal = 2
public static const MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.ShakeDuration Short = 1
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.ShakeInstance

类型属性：`Public, Abstract, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
protected System.Single _angle
protected System.Double _duration
protected System.Single _ease
protected System.Double _startDuration
protected System.Single _strength
private System.Boolean <IsDone>k__BackingField
System.Boolean IsDone { public get; protected set; }
System.Single WiggleSpeed { protected static get; }
protected .ctor()
protected static System.Single get_WiggleSpeed()
protected System.Void set_IsDone(System.Boolean value)
public abstract Godot.Vector2 Update(System.Double delta)
public System.Boolean get_IsDone()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.ShakeStrength

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.ShakeStrength Medium = 3
public static const MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.ShakeStrength None = 0
public static const MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.ShakeStrength Strong = 4
public static const MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.ShakeStrength TooMuch = 5
public System.Int32 value__
public static const MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.ShakeStrength VeryWeak = 1
public static const MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.ShakeStrength Weak = 2
```
