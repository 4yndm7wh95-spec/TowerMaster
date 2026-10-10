# MegaCrit.Sts2.Core.Nodes.Vfx

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.Vfx.IDeathDelayer

类型属性：`Public, ClassSemanticsMask, Abstract, BeforeFieldInit`；基类：`无`。

接口：

```text
public abstract System.Threading.Tasks.Task GetDelayTask()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NAdditiveOverlayVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.ColorRect`。

接口：`System.IDisposable`

```text
private static readonly System.String _scenePath
private Godot.Tween _tween
private MegaCrit.Sts2.Core.Nodes.Vfx.VfxColor _vfxColor
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnTweenFinished()
private System.Void SetVfxColor()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NAdditiveOverlayVfx Create(MegaCrit.Sts2.Core.Nodes.Vfx.VfxColor vfxColor = 0)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NAdditiveOverlayVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.ColorRect+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName OnTweenFinished
public static readonly Godot.StringName SetVfxColor
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NAdditiveOverlayVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.ColorRect+PropertyName`。

接口：

```text
public static readonly Godot.StringName _tween
public static readonly Godot.StringName _vfxColor
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NAdditiveOverlayVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.ColorRect+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NAeonGlassVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _animController
private System.Single _baseScrollSpeed
private Godot.GpuParticles2D _bottomSparkParticles
private System.String _curAnimName
private Godot.GpuParticles2D _dumpParticles
private Godot.GpuParticles2D _groundChunkParticles
private Godot.GpuParticles2D _groundDustParticles
private Godot.GpuParticles2D _leakParticles
private Godot.ShaderMaterial _liquidShaderMat
private Godot.Node2D _parent
private System.Boolean _ringsSpinningNormal
private static readonly Godot.StringName _scrollSpeedString
private Godot.GpuParticles2D _shardParticles
private Godot.GpuParticles2D _topSparkParticles
private Godot.GpuParticles2D _witherParticles
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void EndDie()
private System.Void EndScrape()
private System.Void EndWither()
private System.Void OnAnimationEvent(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___, Godot.GodotObject spineEvent)
private System.Void OnAnimationStart(Godot.GodotObject spineSprite, Godot.GodotObject animationState, Godot.GodotObject trackEntry)
private System.Void ResetVfx()
private System.Void StartDie()
private System.Void StartScrape()
private System.Void StartSparks()
private System.Void StartWither()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NAeonGlassVfx+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Vfx.NAeonGlassVfx+<>c <>9
public static System.Action<MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState> <>9__15_0
private static .cctor()
public .ctor()
internal System.Void <_Ready>b__15_0(MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState animState)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NAeonGlassVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName EndDie
public static readonly Godot.StringName EndScrape
public static readonly Godot.StringName EndWither
public static readonly Godot.StringName OnAnimationEvent
public static readonly Godot.StringName OnAnimationStart
public static readonly Godot.StringName ResetVfx
public static readonly Godot.StringName StartDie
public static readonly Godot.StringName StartScrape
public static readonly Godot.StringName StartSparks
public static readonly Godot.StringName StartWither
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NAeonGlassVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _baseScrollSpeed
public static readonly Godot.StringName _bottomSparkParticles
public static readonly Godot.StringName _curAnimName
public static readonly Godot.StringName _dumpParticles
public static readonly Godot.StringName _groundChunkParticles
public static readonly Godot.StringName _groundDustParticles
public static readonly Godot.StringName _leakParticles
public static readonly Godot.StringName _liquidShaderMat
public static readonly Godot.StringName _parent
public static readonly Godot.StringName _ringsSpinningNormal
public static readonly Godot.StringName _shardParticles
public static readonly Godot.StringName _topSparkParticles
public static readonly Godot.StringName _witherParticles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NAeonGlassVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NAmalgamVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _animController
private Godot.GpuParticles2D _constantSparks1
private Godot.GpuParticles2D _constantSparks2
private Godot.GpuParticles2D _constantSparks3
private Godot.CpuParticles2D _deathBodyParticles
private Godot.Node2D _hitBoneNode
private Godot.GpuParticles2D _hitFxParticles
private Godot.GpuParticles2D _hitParticles1
private Godot.GpuParticles2D _hitParticles2
private Godot.GpuParticles2D _hitParticles3
private Godot.GpuParticles2D _laserBaseParticles
private Godot.Node _parent
private Godot.Node2D _torch1Node
private Godot.Node2D _torch2Node
private Godot.Node2D _torch3Node
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void KillTorches()
private System.Void OnAnimationEvent(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___, Godot.GodotObject spineEvent)
private System.Void PlayHit1()
private System.Void PlayHit2()
private System.Void PlayHit3()
private System.Void PlayLaserBase(System.Boolean starting)
private System.Void PlayLaserHit(System.Boolean starting)
private System.Void PoofToDeath()
private System.Void RestartTorches()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NAmalgamVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName KillTorches
public static readonly Godot.StringName OnAnimationEvent
public static readonly Godot.StringName PlayHit1
public static readonly Godot.StringName PlayHit2
public static readonly Godot.StringName PlayHit3
public static readonly Godot.StringName PlayLaserBase
public static readonly Godot.StringName PlayLaserHit
public static readonly Godot.StringName PoofToDeath
public static readonly Godot.StringName RestartTorches
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NAmalgamVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _constantSparks1
public static readonly Godot.StringName _constantSparks2
public static readonly Godot.StringName _constantSparks3
public static readonly Godot.StringName _deathBodyParticles
public static readonly Godot.StringName _hitBoneNode
public static readonly Godot.StringName _hitFxParticles
public static readonly Godot.StringName _hitParticles1
public static readonly Godot.StringName _hitParticles2
public static readonly Godot.StringName _hitParticles3
public static readonly Godot.StringName _laserBaseParticles
public static readonly Godot.StringName _parent
public static readonly Godot.StringName _torch1Node
public static readonly Godot.StringName _torch2Node
public static readonly Godot.StringName _torch3Node
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NAmalgamVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NArchitectVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _animController
private MegaCrit.Sts2.Core.Nodes.Vfx.NBasicTrail _innerTrail
private MegaCrit.Sts2.Core.Nodes.Vfx.NBasicTrail _outerTrail
private Godot.Node2D _parent
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void EndTrail()
private System.Void OnAnimationEvent(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___, Godot.GodotObject spineEvent)
private System.Void StartTrail()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NArchitectVfx+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Vfx.NArchitectVfx+<>c <>9
public static System.Action<MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState> <>9__4_0
private static .cctor()
public .ctor()
internal System.Void <_Ready>b__4_0(MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState animState)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NArchitectVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName EndTrail
public static readonly Godot.StringName OnAnimationEvent
public static readonly Godot.StringName StartTrail
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NArchitectVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _innerTrail
public static readonly Godot.StringName _outerTrail
public static readonly Godot.StringName _parent
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NArchitectVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NAxebotVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _animController
private System.Int32 _currentWeapon
private Godot.GpuParticles2D _hurtParticles1
private Godot.GpuParticles2D _hurtParticles2
private Godot.Node2D _parent
private Godot.GpuParticles2D _smokeParticlesLeft
private Godot.GpuParticles2D _smokeParticlesRight
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnAnimationEvent(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___, Godot.GodotObject spineEvent)
private System.Void TurnOffLandingSmoke()
private System.Void TurnOnDeath1()
private System.Void TurnOnDeath2()
private System.Void TurnOnHurt()
private System.Void TurnOnLandingSmoke()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NAxebotVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnAnimationEvent
public static readonly Godot.StringName TurnOffLandingSmoke
public static readonly Godot.StringName TurnOnDeath1
public static readonly Godot.StringName TurnOnDeath2
public static readonly Godot.StringName TurnOnHurt
public static readonly Godot.StringName TurnOnLandingSmoke
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NAxebotVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _currentWeapon
public static readonly Godot.StringName _hurtParticles1
public static readonly Godot.StringName _hurtParticles2
public static readonly Godot.StringName _parent
public static readonly Godot.StringName _smokeParticlesLeft
public static readonly Godot.StringName _smokeParticlesRight
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NAxebotVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NBasicTrail

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Line2D`。

接口：`System.IDisposable`

```text
private System.Int32 _maxSegments
private Godot.Node2D _target
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NBasicTrail+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Line2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NBasicTrail+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Line2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _maxSegments
public static readonly Godot.StringName _target
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NBasicTrail+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Line2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NBattlewornDummyVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private Godot.GpuParticles2D _damageParticles
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _megaSprite
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnAnimationEvent(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___, Godot.GodotObject spineEvent)
private System.Void OnDamageChips()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NBattlewornDummyVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnAnimationEvent
public static readonly Godot.StringName OnDamageChips
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NBattlewornDummyVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _damageParticles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NBattlewornDummyVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NBezierTrail

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Line2D`。

接口：`System.IDisposable`

```text
private System.Nullable<Godot.Vector2> _lastPointPosition
private static const System.Single _maxSpawnDist = 48
private static const System.Single _minSpawnDist = 12
private readonly System.Collections.Generic.List<System.Single> _pointAge
private System.Single _pointDuration
private Godot.Node2D _target
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void CreatePoint(Godot.Vector2 pointPos, System.Double delta)
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

## MegaCrit.Sts2.Core.Nodes.Vfx.NBezierTrail+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Line2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName CreatePoint
public static readonly Godot.StringName OnToggleVisibility
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NBezierTrail+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Line2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _pointDuration
public static readonly Godot.StringName _target
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NBezierTrail+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Line2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NBgGroundSpikeVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Sprite2D`。

接口：`System.IDisposable`

```text
protected System.Boolean _movingRight
private static const System.String _scenePath = "res://scenes/vfx/bg_ground_spike_vfx.tscn"
protected Godot.Vector2 _startPosition
private Godot.Tween _tween
private Godot.Vector2 _velocity
protected MegaCrit.Sts2.Core.Nodes.Vfx.VfxColor _vfxColor
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task Animate()
private System.Void SetColor()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void AdjustStartPosition()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NBgGroundSpikeVfx Create(Godot.Vector2 position, System.Boolean movingRight = True, MegaCrit.Sts2.Core.Nodes.Vfx.VfxColor vfxColor = 0)
public virtual System.Void _ExitTree()
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NBgGroundSpikeVfx+<Animate>d__11

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NBgGroundSpikeVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NBgGroundSpikeVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Sprite2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AdjustStartPosition
public static readonly Godot.StringName Create
public static readonly Godot.StringName SetColor
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NBgGroundSpikeVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Sprite2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _movingRight
public static readonly Godot.StringName _startPosition
public static readonly Godot.StringName _tween
public static readonly Godot.StringName _velocity
public static readonly Godot.StringName _vfxColor
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NBgGroundSpikeVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Sprite2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NBigSlashImpactVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private Godot.Collections.Array<Godot.GpuParticles2D> _anticipationParticles
private Godot.Node2D _corePivot
private System.Threading.CancellationTokenSource _cts
private Godot.Collections.Array<Godot.GpuParticles2D> _impactParticles
private Godot.Collections.Array<Godot.GpuParticles2D> _modulateParticles
public static readonly System.String scenePath
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task PlaySequence()
private System.Void ModulateParticles(Godot.Color tint)
private System.Void RotateCore(System.Single rotationDegrees)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NBigSlashImpactVfx Create(Godot.Vector2 targetCenterPosition, System.Single rotationDegrees, Godot.Color tint)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NBigSlashImpactVfx Create(Godot.Vector2 targetCenterPosition)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NBigSlashImpactVfx Create(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NBigSlashImpactVfx+<PlaySequence>d__13

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NBigSlashImpactVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NBigSlashImpactVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName ModulateParticles
public static readonly Godot.StringName RotateCore
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NBigSlashImpactVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _anticipationParticles
public static readonly Godot.StringName _corePivot
public static readonly Godot.StringName _impactParticles
public static readonly Godot.StringName _modulateParticles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NBigSlashImpactVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NBigSlashVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private System.Threading.CancellationTokenSource _cts
private Godot.Collections.Array<Godot.GpuParticles2D> _modulateParticles
private Godot.Collections.Array<Godot.GpuParticles2D> _slashParticles
public static readonly System.String scenePath
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task PlaySequence()
private System.Void ModulateParticles(Godot.Color tint)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NBigSlashVfx Create(Godot.Vector2 targetCenterPosition, System.Boolean facingRight, Godot.Color tint)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NBigSlashVfx Create(Godot.Vector2 targetCenterPosition, System.Boolean facingRight)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NBigSlashVfx Create(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NBigSlashVfx+<PlaySequence>d__10

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NBigSlashVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NBigSlashVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName ModulateParticles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NBigSlashVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _modulateParticles
public static readonly Godot.StringName _slashParticles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NBigSlashVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NBlockBrokenVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Sprite2D`。

接口：`System.IDisposable`

```text
private static const System.String _scenePath = "res://scenes/vfx/vfx_block_broken.tscn"
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
private System.Void OnAnimationFinished(Godot.StringName _)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NBlockBrokenVfx Create()
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NBlockBrokenVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Sprite2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName OnAnimationFinished
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NBlockBrokenVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Sprite2D+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NBlockBrokenVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Sprite2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NBlockSparkVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Nodes.Combat.NCreature _creatureNode
private Godot.Collections.Array<Godot.GpuParticles2D> _particles
private Godot.GpuParticles2D _specks
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
System.String ScenePath { private static get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task FlashAndFree()
private static System.String get_ScenePath()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NBlockSparkVfx Create(MegaCrit.Sts2.Core.Entities.Creatures.Creature target)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NBlockSparkVfx+<FlashAndFree>d__9

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NBlockSparkVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NBlockSparkVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NBlockSparkVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _creatureNode
public static readonly Godot.StringName _particles
public static readonly Godot.StringName _specks
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NBlockSparkVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NBounceSparkVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private System.Single _floorY
private static readonly Godot.Vector2 _gravity
private Godot.Node2D _particle
private static const System.String _scenePath = "res://scenes/vfx/bounce_spark_vfx.tscn"
private Godot.Vector2 _startPosition
private static const System.Single _targetAlpha = 0.8
private Godot.Tween _tween
private Godot.Vector2 _velocity
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
public static MegaCrit.Sts2.Core.Nodes.Vfx.NBounceSparkVfx Create(MegaCrit.Sts2.Core.Entities.Creatures.Creature target, MegaCrit.Sts2.Core.Nodes.Vfx.VfxColor vfxColor = 7)
public virtual System.Void _ExitTree()
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NBounceSparkVfx+<Animate>d__12

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NBounceSparkVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NBounceSparkVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NBounceSparkVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _floorY
public static readonly Godot.StringName _particle
public static readonly Godot.StringName _startPosition
public static readonly Godot.StringName _tween
public static readonly Godot.StringName _velocity
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NBounceSparkVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCardEnchantVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Models.CardModel _cardModel
private MegaCrit.Sts2.Core.Nodes.Cards.NCard _cardNode
private System.Threading.CancellationTokenSource _cts
private Godot.TextureRect _enchantmentIcon
private MegaCrit.Sts2.addons.mega_text.MegaLabel _enchantmentLabel
private Godot.GpuParticles2D _enchantmentSparkles
private static readonly Godot.StringName _progress
private Godot.Tween _tween
private Godot.Curve <EmbossCurve>k__BackingField
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
Godot.Curve EmbossCurve { public get; public set; }
System.String ScenePath { private static get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task PlayAnimation()
private static System.String get_ScenePath()
private System.Boolean <PlayAnimation>b__19_0()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public Godot.Curve get_EmbossCurve()
public static MegaCrit.Sts2.Core.Nodes.Vfx.NCardEnchantVfx Create(MegaCrit.Sts2.Core.Models.CardModel card)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Void set_EmbossCurve(Godot.Curve value)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCardEnchantVfx+<PlayAnimation>d__19

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NCardEnchantVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCardEnchantVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCardEnchantVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _cardNode
public static readonly Godot.StringName _enchantmentIcon
public static readonly Godot.StringName _enchantmentLabel
public static readonly Godot.StringName _enchantmentSparkles
public static readonly Godot.StringName _tween
public static readonly Godot.StringName EmbossCurve
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCardEnchantVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCardFlyPowerVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private readonly System.Threading.CancellationTokenSource _cancelToken
private MegaCrit.Sts2.Core.Nodes.Combat.NCreature _cardOwnerNode
private static const System.Single _initialRotationSpeed = 3.1415927
private static const System.Single _maxRotationSpeed = 157.07964
private static const System.Single _scaleOutProportion = 0.9
private Godot.Tween _scaleTween
private System.Boolean _scalingOut
private static readonly System.String _scenePath
private static const System.Single _speed = 3000
private Godot.Path2D _swooshPath
private MegaCrit.Sts2.Core.Nodes.Vfx.NCardTrailVfx _vfx
private MegaCrit.Sts2.Core.Nodes.Cards.NCard <CardNode>k__BackingField
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
MegaCrit.Sts2.Core.Nodes.Cards.NCard CardNode { public get; private set; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Single GetDurationInternal()
private System.Void set_CardNode(MegaCrit.Sts2.Core.Nodes.Cards.NCard value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public [async] System.Threading.Tasks.Task PlayAnim()
public MegaCrit.Sts2.Core.Nodes.Cards.NCard get_CardNode()
public static MegaCrit.Sts2.Core.Nodes.Vfx.NCardFlyPowerVfx Create(MegaCrit.Sts2.Core.Nodes.Cards.NCard card)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Single GetDuration()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCardFlyPowerVfx+<PlayAnim>d__22

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NCardFlyPowerVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
private System.Single <duration>5__4
private System.Single <length>5__2
private System.Double <timeAccumulator>5__3
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCardFlyPowerVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName GetDuration
public static readonly Godot.StringName GetDurationInternal
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCardFlyPowerVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _cardOwnerNode
public static readonly Godot.StringName _scaleTween
public static readonly Godot.StringName _scalingOut
public static readonly Godot.StringName _swooshPath
public static readonly Godot.StringName _vfx
public static readonly Godot.StringName CardNode
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCardFlyPowerVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCardFlyShuffleVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private System.Single _accel
private System.Single _arcDir
private readonly System.Threading.CancellationTokenSource _cancelToken
private System.Single _controlPointOffset
private System.Single _duration
private Godot.Vector2 _endPos
private Godot.Tween _fadeOutTween
private static readonly System.String _scenePath
private System.Single _speed
private Godot.Vector2 _startPos
private MegaCrit.Sts2.Core.Entities.Cards.CardPile _targetPile
private System.String _trailPath
private MegaCrit.Sts2.Core.Nodes.Vfx.NCardTrailVfx _vfx
private System.Boolean _vfxFading
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task PlayAnim()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NCardFlyShuffleVfx Create(MegaCrit.Sts2.Core.Entities.Cards.CardPile startPile, MegaCrit.Sts2.Core.Entities.Cards.CardPile targetPile, System.String trailPath)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCardFlyShuffleVfx+<PlayAnim>d__18

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NCardFlyShuffleVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__2
private System.Single <time>5__2
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCardFlyShuffleVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCardFlyShuffleVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _accel
public static readonly Godot.StringName _arcDir
public static readonly Godot.StringName _controlPointOffset
public static readonly Godot.StringName _duration
public static readonly Godot.StringName _endPos
public static readonly Godot.StringName _fadeOutTween
public static readonly Godot.StringName _speed
public static readonly Godot.StringName _startPos
public static readonly Godot.StringName _trailPath
public static readonly Godot.StringName _vfx
public static readonly Godot.StringName _vfxFading
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCardFlyShuffleVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCardFlyVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private System.Single _accel
private System.Single _arcDir
private readonly System.Threading.CancellationTokenSource _cancelToken
private MegaCrit.Sts2.Core.Nodes.Cards.NCard _card
private System.Single _controlPointOffset
private System.Single _duration
private Godot.Vector2 _endPos
private Godot.Tween _fadeOutTween
private System.Boolean _isAddingToPile
private static readonly System.String _scenePath
private System.Single _speed
private Godot.Vector2 _startPos
private System.String _trailPath
private MegaCrit.Sts2.Core.Nodes.Vfx.NCardTrailVfx _vfx
private System.Boolean _vfxFading
private System.Threading.Tasks.TaskCompletionSource <SwooshAwayCompletion>k__BackingField
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
System.Threading.Tasks.TaskCompletionSource SwooshAwayCompletion { public get; private set; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task PlayAnim()
private System.Void OnCardExitedTree()
private System.Void set_SwooshAwayCompletion(System.Threading.Tasks.TaskCompletionSource value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NCardFlyVfx Create(MegaCrit.Sts2.Core.Nodes.Cards.NCard card, MegaCrit.Sts2.Core.Entities.Cards.PileType pileType, System.Boolean isAddingToPile, System.String trailPath)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NCardFlyVfx Create(MegaCrit.Sts2.Core.Nodes.Cards.NCard card, MegaCrit.Sts2.Core.Entities.Creatures.Creature target, System.String trailPath)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Threading.Tasks.TaskCompletionSource get_SwooshAwayCompletion()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCardFlyVfx+<PlayAnim>d__26

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NCardFlyVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
private System.Single <time>5__2
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCardFlyVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName OnCardExitedTree
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCardFlyVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _accel
public static readonly Godot.StringName _arcDir
public static readonly Godot.StringName _card
public static readonly Godot.StringName _controlPointOffset
public static readonly Godot.StringName _duration
public static readonly Godot.StringName _endPos
public static readonly Godot.StringName _fadeOutTween
public static readonly Godot.StringName _isAddingToPile
public static readonly Godot.StringName _speed
public static readonly Godot.StringName _startPos
public static readonly Godot.StringName _trailPath
public static readonly Godot.StringName _vfx
public static readonly Godot.StringName _vfxFading
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCardFlyVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCardSmithVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private Godot.Control _cardContainer
private MegaCrit.Sts2.Core.Nodes.Cards.NCard _cardNode
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.CardModel> _cards
private Godot.Tween _tween
private System.Boolean _willPlaySfx
private System.Single <SfxVolume>k__BackingField
public static const System.String smithSfx = "card_smith.mp3"
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
System.String ScenePath { private static get; }
System.Single SfxVolume { public get; public set; }
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task PlayAnimation()
private [async] System.Threading.Tasks.Task PlayAnimation(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> cards)
private static System.String get_ScenePath()
private System.Void <PlayAnimation>b__19_0()
private System.Void <PlayAnimation>b__19_1()
private System.Void <PlayAnimation>b__19_2()
private System.Void <PlayAnimation>b__20_0()
private System.Void <PlayAnimation>b__20_1()
private System.Void <PlayAnimation>b__20_3()
private System.Void <PlayAnimation>b__20_5()
private System.Void PlaySubParticles(Godot.Node node)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NCardSmithVfx Create()
public static MegaCrit.Sts2.Core.Nodes.Vfx.NCardSmithVfx Create(MegaCrit.Sts2.Core.Nodes.Cards.NCard card, System.Boolean playSfx = True)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NCardSmithVfx Create(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> cards, System.Boolean playSfx = True)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Single get_SfxVolume()
public System.Void set_SfxVolume(System.Single value)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCardSmithVfx+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Vfx.NCardSmithVfx+<>c <>9
public static System.Action <>9__20_2
public static System.Action <>9__20_4
public static System.Action <>9__20_6
private static .cctor()
public .ctor()
internal System.Void <PlayAnimation>b__20_2()
internal System.Void <PlayAnimation>b__20_4()
internal System.Void <PlayAnimation>b__20_6()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCardSmithVfx+<PlayAnimation>d__19

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NCardSmithVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCardSmithVfx+<PlayAnimation>d__20

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NCardSmithVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Cards.NCard> <cardNodes>5__2
private System.Int32 <i>5__3
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> cards
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCardSmithVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName PlaySubParticles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCardSmithVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _cardContainer
public static readonly Godot.StringName _cardNode
public static readonly Godot.StringName _tween
public static readonly Godot.StringName _willPlaySfx
public static readonly Godot.StringName SfxVolume
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCardSmithVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCardTrail

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Line2D`。

接口：`System.IDisposable`

```text
private System.Nullable<Godot.Vector2> _lastPointPosition
private static const System.Single _maxSpawnDist = 48
private static const System.Single _minSpawnDist = 12
private Godot.Node2D _parent
private readonly System.Collections.Generic.List<System.Single> _pointAge
private System.Single _pointDuration
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void CreatePoint(Godot.Vector2 pointPos, System.Double delta)
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

## MegaCrit.Sts2.Core.Nodes.Vfx.NCardTrail+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Line2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName CreatePoint
public static readonly Godot.StringName OnToggleVisibility
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCardTrail+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Line2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _parent
public static readonly Godot.StringName _pointDuration
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCardTrail+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Line2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCardTrailVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private Godot.Control _nodeToFollow
private Godot.Node2D _sprites
private Godot.Tween _tween
private System.Boolean _updateSprites
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void StopParticles(Godot.Tween tween)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public [async] System.Threading.Tasks.Task FadeOut()
public static MegaCrit.Sts2.Core.Nodes.Vfx.NCardTrailVfx Create(Godot.Control card, System.String characterTrailPath)
public virtual System.Void _ExitTree()
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCardTrailVfx+<FadeOut>d__7

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NCardTrailVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCardTrailVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName StopParticles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCardTrailVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _nodeToFollow
public static readonly Godot.StringName _sprites
public static readonly Godot.StringName _tween
public static readonly Godot.StringName _updateSprites
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCardTrailVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCardTransformVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Models.CardModel _endCard
private System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.RelicModel> _relicsToFlash
private MegaCrit.Sts2.Core.Models.CardModel _startCard
private Godot.Tween _tween
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
System.String ScenePath { private static get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task PlayAnimation()
private [async] System.Threading.Tasks.Task<System.Boolean> WaitAndInterruptIfNecessary(System.Single seconds, MegaCrit.Sts2.Core.Nodes.Cards.NCard cardNode)
private static System.String get_ScenePath()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NCardTransformVfx Create(MegaCrit.Sts2.Core.Models.CardModel startCard, MegaCrit.Sts2.Core.Models.CardModel endCard, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.RelicModel> relicsToFlash)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCardTransformVfx+<PlayAnimation>d__12

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NCardTransformVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
private MegaCrit.Sts2.Core.Nodes.Cards.NCard <cardNode>5__2
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCardTransformVfx+<WaitAndInterruptIfNecessary>d__10

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NCardTransformVfx <>4__this
private System.Single <>7__wrap1
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Boolean> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
public MegaCrit.Sts2.Core.Nodes.Cards.NCard cardNode
public System.Single seconds
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCardTransformVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCardTransformVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _tween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCardTransformVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCardUpgradeVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Models.CardModel _card
private System.Threading.CancellationTokenSource _cts
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
System.String ScenePath { private static get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
private [async] System.Threading.Tasks.Task PlayAnimation()
private static System.String get_ScenePath()
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NCardUpgradeVfx Create(MegaCrit.Sts2.Core.Models.CardModel card)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCardUpgradeVfx+<PlayAnimation>d__9

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NCardUpgradeVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private MegaCrit.Sts2.Core.Nodes.Cards.NCard <cardNode>5__2
private MegaCrit.Sts2.Core.Entities.Cards.PileType <pileType>5__3
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCardUpgradeVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCardUpgradeVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCardUpgradeVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCeremonialBeastVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Vfx.IDeathDelayer`

```text
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _animController
private Godot.GpuParticles2D _deathParticles
private readonly System.Threading.Tasks.TaskCompletionSource _deathTask
private Godot.CpuParticles2D _energyParticlesBack
private Godot.CpuParticles2D _energyParticlesFront
private Godot.Vector2 _globalPlowEndTarget
private Godot.Vector2 _globalPlowTarget
private Godot.Node2D _parent
private Godot.Node2D _plowEndTarget
private Godot.Node2D _plowStartTarget
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task FinishTaskWhenDeathParticlesFinished()
private System.Void OnAnimationEvent(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___, Godot.GodotObject spineEvent)
private System.Void OnPlowEnd()
private System.Void OnPlowStart()
private System.Void TurnOffEnergyParticles()
private System.Void TurnOnDeathParticles()
private System.Void TurnOnEnergyParticles()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Threading.Tasks.Task GetDelayTask()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCeremonialBeastVfx+<FinishTaskWhenDeathParticlesFinished>d__14

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NCeremonialBeastVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCeremonialBeastVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnAnimationEvent
public static readonly Godot.StringName OnPlowEnd
public static readonly Godot.StringName OnPlowStart
public static readonly Godot.StringName TurnOffEnergyParticles
public static readonly Godot.StringName TurnOnDeathParticles
public static readonly Godot.StringName TurnOnEnergyParticles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCeremonialBeastVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _deathParticles
public static readonly Godot.StringName _energyParticlesBack
public static readonly Godot.StringName _energyParticlesFront
public static readonly Godot.StringName _globalPlowEndTarget
public static readonly Godot.StringName _globalPlowTarget
public static readonly Godot.StringName _parent
public static readonly Godot.StringName _plowEndTarget
public static readonly Godot.StringName _plowStartTarget
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCeremonialBeastVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCubexConstructVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _animController
private MegaCrit.Sts2.Core.Nodes.Vfx.NLaserVfx _laser
private Godot.Node2D _parent
private Godot.Node2D _rings
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void <_Ready>b__4_0(MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState animState)
private System.Void EndLaser()
private System.Void OnAnimationEvent(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___, Godot.GodotObject spineEvent)
private System.Void StartLaser()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCubexConstructVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName EndLaser
public static readonly Godot.StringName OnAnimationEvent
public static readonly Godot.StringName StartLaser
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCubexConstructVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _laser
public static readonly Godot.StringName _parent
public static readonly Godot.StringName _rings
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NCubexConstructVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDaggerSprayFlurryVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private static readonly Godot.StringName _color
private System.Threading.CancellationTokenSource _cts
private Godot.Collections.Array<Godot.GpuParticles2D> _modulateParticles
private Godot.Collections.Array<Godot.GpuParticles2D> _particles
public static readonly System.String scenePath
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task PlaySequence()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NDaggerSprayFlurryVfx Create(Godot.Vector2 targetCenter, Godot.Color tint, System.Boolean goingRight)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NDaggerSprayFlurryVfx Create(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature, Godot.Color tint, System.Boolean goingRight)
public System.Void ApplyTint(Godot.Color tint)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDaggerSprayFlurryVfx+<PlaySequence>d__10

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NDaggerSprayFlurryVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDaggerSprayFlurryVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName ApplyTint
public static readonly Godot.StringName Create
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDaggerSprayFlurryVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _modulateParticles
public static readonly Godot.StringName _particles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDaggerSprayFlurryVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDaggerSprayImpactVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private System.Threading.CancellationTokenSource _cts
private System.Single _impactDelay
private Godot.Collections.Array<Godot.GpuParticles2D> _modulateParticles
private Godot.Collections.Array<Godot.GpuParticles2D> _particles
public static readonly System.String scenePath
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task PlaySequence()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NDaggerSprayImpactVfx Create(Godot.Vector2 targetCenter, Godot.Color tint, System.Boolean goingRight)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NDaggerSprayImpactVfx Create(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature, Godot.Color tint, System.Boolean goingRight)
public System.Void ApplyTint(Godot.Color tint)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDaggerSprayImpactVfx+<PlaySequence>d__10

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NDaggerSprayImpactVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDaggerSprayImpactVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName ApplyTint
public static readonly Godot.StringName Create
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDaggerSprayImpactVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _impactDelay
public static readonly Godot.StringName _modulateParticles
public static readonly Godot.StringName _particles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDaggerSprayImpactVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDamageBlockedVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private static readonly MegaCrit.Sts2.Core.Localization.LocString _blockedLoc
private MegaCrit.Sts2.addons.mega_text.MegaLabel _label
private Godot.Tween _tween
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
System.String ScenePath { private static get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task BlockAnim()
private static System.String get_ScenePath()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NDamageBlockedVfx Create(MegaCrit.Sts2.Core.Entities.Creatures.Creature target)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDamageBlockedVfx+<BlockAnim>d__10

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NDamageBlockedVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDamageBlockedVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDamageBlockedVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _label
public static readonly Godot.StringName _tween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDamageBlockedVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDamageNumVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private Godot.Vector2 _globalSpawnPosition
private static readonly Godot.Vector2 _gravity
private static readonly Godot.Vector2 _positionOffset
private static readonly System.String _scenePath
private System.String _text
private Godot.Tween _tween
private Godot.Vector2 _velocity
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task AnimVfx()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NDamageNumVfx Create(Godot.Vector2 globalPosition, System.Int32 damage)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NDamageNumVfx Create(MegaCrit.Sts2.Core.Entities.Creatures.Creature target, MegaCrit.Sts2.Core.Entities.Creatures.DamageResult result)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NDamageNumVfx Create(MegaCrit.Sts2.Core.Entities.Creatures.Creature target, System.Int32 damage, System.Boolean requireInteractable = True)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Void _ExitTree()
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDamageNumVfx+<AnimVfx>d__13

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NDamageNumVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDamageNumVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDamageNumVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _globalSpawnPosition
public static readonly Godot.StringName _text
public static readonly Godot.StringName _tween
public static readonly Godot.StringName _velocity
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDamageNumVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDecimillipedeRocksVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private readonly System.Threading.CancellationTokenSource _cancelToken
private Godot.Node2D[] _rocks
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task Play(System.Threading.CancellationToken cancellationToken)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDecimillipedeRocksVfx+<Play>d__4

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NDecimillipedeRocksVfx <>4__this
private Godot.Node2D[] <>7__wrap1
private System.Int32 <>7__wrap2
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private Godot.Node2D <rock>5__4
public System.Threading.CancellationToken cancellationToken
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDecimillipedeRocksVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDecimillipedeRocksVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _rocks
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDecimillipedeRocksVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDecimillipedeSegmentVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _animController
private Godot.CpuParticles2D[] _damageParticleNodes
private static readonly Godot.StringName _direction
private static readonly Godot.StringName _opacity
private Godot.Node2D _parent
private readonly Godot.Vector2 _particleGravity
private System.Single _particleSpeedScale
private Godot.Vector2 _particleVelocityMinMax
private Godot.Node2D[] _sprayNodes
private readonly System.Collections.Generic.List<Godot.Vector2> _sprayNodeScales
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void EndRegenerate()
private System.Void OnAnimationEvent(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___, Godot.GodotObject animEvent)
private System.Void Wither()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void Regenerate()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDecimillipedeSegmentVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName EndRegenerate
public static readonly Godot.StringName OnAnimationEvent
public static readonly Godot.StringName Regenerate
public static readonly Godot.StringName Wither
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDecimillipedeSegmentVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _damageParticleNodes
public static readonly Godot.StringName _parent
public static readonly Godot.StringName _particleGravity
public static readonly Godot.StringName _particleSpeedScale
public static readonly Godot.StringName _particleVelocityMinMax
public static readonly Godot.StringName _sprayNodes
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDecimillipedeSegmentVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDesaturateTransitionVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private Godot.Tween _tween
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
System.String ScenePath { private static get; }
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private static System.String get_ScenePath()
private System.Void <Animate>b__8_0()
private System.Void Animate()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NDesaturateTransitionVfx Create()
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDesaturateTransitionVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Animate
public static readonly Godot.StringName Create
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDesaturateTransitionVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _tween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDesaturateTransitionVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDevotedSculptorVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _animController
private Godot.GpuParticles2D _attackParticles
private Godot.Node2D _parent
private Godot.GpuParticles2D _voiceParticles
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnAnimationEvent(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___, Godot.GodotObject spineEvent)
private System.Void StartAttack()
private System.Void StartVoice()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDevotedSculptorVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnAnimationEvent
public static readonly Godot.StringName StartAttack
public static readonly Godot.StringName StartVoice
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDevotedSculptorVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _attackParticles
public static readonly Godot.StringName _parent
public static readonly Godot.StringName _voiceParticles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDevotedSculptorVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDoomOverlayVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.BackBufferCopy`。

接口：`System.IDisposable`

```text
private static MegaCrit.Sts2.Core.Nodes.Vfx.NDoomOverlayVfx _instance
private static readonly System.String _scenePath
private Godot.Tween _tween
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnTweenFinished()
private System.Void PlayVfx()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NDoomOverlayVfx GetOrCreate()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDoomOverlayVfx+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Vfx.NDoomOverlayVfx+<>c <>9
public static System.Action <>9__5_0
private static .cctor()
public .ctor()
internal System.Void <PlayVfx>b__5_0()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDoomOverlayVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.BackBufferCopy+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName GetOrCreate
public static readonly Godot.StringName OnTweenFinished
public static readonly Godot.StringName PlayVfx
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDoomOverlayVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.BackBufferCopy+PropertyName`。

接口：

```text
public static readonly Godot.StringName _tween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDoomOverlayVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.BackBufferCopy+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDoomSubEmitterVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private System.Int32 _baseParticleDensity
private Godot.Collections.Array<Godot.Vector2> _baseScales
private System.Single _baseSpearRegionWidth
private System.Single _curScaleX
private System.Single _dumbHackBecauseOfHowTexturerectsWork
private Godot.Collections.Array<System.Int32> _indeces
private System.Single _innerMargin
private System.Boolean _isOn
private System.Single _maxSpearSize
private System.Single _maxSpearTime
private System.Single _minSpearSize
private System.Single _minSpearTime
private System.Single _outerMargin
private Godot.GpuParticles2D _particlesToKeepDense
private System.Single _rotationHackForSameDumbReason
private Godot.Collections.Array<Godot.Node2D> _scalableLayers
private System.Single _spearAngleIntensity
private System.Single _spearFixedHScale
private Godot.Collections.Array<Godot.TextureRect> _spears
private System.Double _time
private Godot.Tween _tween
private Godot.Node2D _verticalShrinkingLayer
System.Single CurScaleX { public get; public set; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void <ShowOrHide>b__28_0()
private System.Void FireAllSpears()
private System.Void FireSpear(Godot.TextureRect textureRect = null)
private System.Void SetVisibility(System.Boolean isOn)
private System.Void UpdateWidth(System.Single width)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Single get_CurScaleX()
public System.Void set_CurScaleX(System.Single value)
public System.Void ShowOrHide(System.Single widthScale, System.Single tweenTime)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDoomSubEmitterVfx+<>c__DisplayClass26_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Vfx.NDoomSubEmitterVfx <>4__this
public Godot.TextureRect textureRect
public .ctor()
internal System.Void <FireSpear>b__0()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDoomSubEmitterVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName FireAllSpears
public static readonly Godot.StringName FireSpear
public static readonly Godot.StringName SetVisibility
public static readonly Godot.StringName ShowOrHide
public static readonly Godot.StringName UpdateWidth
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDoomSubEmitterVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _baseParticleDensity
public static readonly Godot.StringName _baseScales
public static readonly Godot.StringName _baseSpearRegionWidth
public static readonly Godot.StringName _curScaleX
public static readonly Godot.StringName _dumbHackBecauseOfHowTexturerectsWork
public static readonly Godot.StringName _indeces
public static readonly Godot.StringName _innerMargin
public static readonly Godot.StringName _isOn
public static readonly Godot.StringName _maxSpearSize
public static readonly Godot.StringName _maxSpearTime
public static readonly Godot.StringName _minSpearSize
public static readonly Godot.StringName _minSpearTime
public static readonly Godot.StringName _outerMargin
public static readonly Godot.StringName _particlesToKeepDense
public static readonly Godot.StringName _rotationHackForSameDumbReason
public static readonly Godot.StringName _scalableLayers
public static readonly Godot.StringName _spearAngleIntensity
public static readonly Godot.StringName _spearFixedHScale
public static readonly Godot.StringName _spears
public static readonly Godot.StringName _time
public static readonly Godot.StringName _tween
public static readonly Godot.StringName _verticalShrinkingLayer
public static readonly Godot.StringName CurScaleX
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDoomSubEmitterVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDoomVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Nodes.Vfx.NDoomSubEmitterVfx _back
private System.Threading.CancellationToken _cancelToken
private MegaCrit.Sts2.Core.Nodes.Combat.NCreatureVisuals _creatureVisuals
private static const System.Single _doomVfxSize = 260
private MegaCrit.Sts2.Core.Nodes.Vfx.NDoomSubEmitterVfx _front
private Godot.Vector2 _position
private System.Boolean _shouldDie
private Godot.Vector2 _size
private Godot.Tween _tween
private readonly System.Threading.CancellationTokenSource <VfxCancellationToken>k__BackingField
private System.Threading.Tasks.Task <VfxTask>k__BackingField
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
System.String ScenePath { private static get; }
System.Threading.CancellationTokenSource VfxCancellationToken { private get; }
System.Threading.Tasks.Task VfxTask { public get; private set; }
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task PlayVfx(MegaCrit.Sts2.Core.Nodes.Combat.NCreatureVisuals creatureVisuals, Godot.Vector2 position, Godot.Vector2 size, System.Boolean shouldDie)
private [async] System.Threading.Tasks.Task PlayVfxInternal()
private [async] System.Threading.Tasks.Task Reparent(Godot.Node creatureNode, Godot.Node newParent)
private static System.String get_ScenePath()
private System.Threading.CancellationTokenSource get_VfxCancellationToken()
private System.Void set_VfxTask(System.Threading.Tasks.Task value)
private System.Void ShowOrHideParticles(System.Single widthScale, System.Single tweenTime)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NDoomVfx Create(MegaCrit.Sts2.Core.Nodes.Combat.NCreatureVisuals creatureVisuals, Godot.Vector2 position, Godot.Vector2 size, System.Boolean shouldDie)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Threading.Tasks.Task get_VfxTask()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDoomVfx+<>c__DisplayClass26_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.Boolean removeCompleted
public .ctor()
internal System.Boolean <Reparent>b__0()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDoomVfx+<PlayVfx>d__23

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NDoomVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private Godot.Node2D <creatureBody>5__2
private Godot.Vector2 <creatureOffset>5__3
private Godot.Vector2 <originalGlobalScale>5__4
public MegaCrit.Sts2.Core.Nodes.Combat.NCreatureVisuals creatureVisuals
public Godot.Vector2 position
public System.Boolean shouldDie
public Godot.Vector2 size
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDoomVfx+<PlayVfxInternal>d__24

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NDoomVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDoomVfx+<Reparent>d__26

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NDoomVfx <>4__this
private MegaCrit.Sts2.Core.Nodes.Vfx.NDoomVfx+<>c__DisplayClass26_0 <>8__1
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
private Godot.Callable <reparent>5__2
public Godot.Node creatureNode
public Godot.Node newParent
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDoomVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName ShowOrHideParticles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDoomVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _back
public static readonly Godot.StringName _creatureVisuals
public static readonly Godot.StringName _front
public static readonly Godot.StringName _position
public static readonly Godot.StringName _shouldDie
public static readonly Godot.StringName _size
public static readonly Godot.StringName _tween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NDoomVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NEntomancerVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _animController
private Godot.GpuParticles2D _attackingBugParticles
private Godot.Vector2 _basePosition
private Godot.Node2D _parent
private System.Boolean _swarming
private Godot.GpuParticles2D _swarmParticles
private Godot.Node2D _swarmTargetNode
private Godot.Tween _swarmTween
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void CancelSwarmAttack()
private System.Void CompleteSwarmAttack()
private System.Void LaunchSwarm()
private System.Void OnAnimationEvent(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___, Godot.GodotObject spineEvent)
private System.Void TurnOffSwarm()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NEntomancerVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName CancelSwarmAttack
public static readonly Godot.StringName CompleteSwarmAttack
public static readonly Godot.StringName LaunchSwarm
public static readonly Godot.StringName OnAnimationEvent
public static readonly Godot.StringName TurnOffSwarm
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NEntomancerVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _attackingBugParticles
public static readonly Godot.StringName _basePosition
public static readonly Godot.StringName _parent
public static readonly Godot.StringName _swarming
public static readonly Godot.StringName _swarmParticles
public static readonly Godot.StringName _swarmTargetNode
public static readonly Godot.StringName _swarmTween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NEntomancerVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NEpochHighlightVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
public static readonly System.String scenePath
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NEpochHighlightVfx Create()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NEpochHighlightVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName Create
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NEpochHighlightVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NEpochHighlightVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NEpochOffscreenVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private System.Boolean _showVfx
private MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEpochSlot _slot
private Godot.Tween _tween
private System.Single _viewportSizeX
public static readonly System.String scenePath
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
public static MegaCrit.Sts2.Core.Nodes.Vfx.NEpochOffscreenVfx Create(MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NEpochSlot slot)
public virtual System.Void _ExitTree()
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NEpochOffscreenVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NEpochOffscreenVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _showVfx
public static readonly Godot.StringName _slot
public static readonly Godot.StringName _tween
public static readonly Godot.StringName _viewportSizeX
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NEpochOffscreenVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NEpochSlotParticle

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Sprite2D`。

接口：`System.IDisposable`

```text
private static const System.Double _checkRate = 0.25
private static const System.Single _deleteDistance = 1500
private System.Single _speed
private Godot.Control _target
private System.Double _timer
public static readonly System.String scenePath
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
public static MegaCrit.Sts2.Core.Nodes.Vfx.NEpochSlotParticle Create(Godot.Control target)
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NEpochSlotParticle+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Sprite2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NEpochSlotParticle+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Sprite2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _speed
public static readonly Godot.StringName _target
public static readonly Godot.StringName _timer
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NEpochSlotParticle+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Sprite2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NFakeMerchantVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _megaSprite
private Godot.GpuParticles2D _particles
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnAnimationEvent(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___, Godot.GodotObject spineEvent)
private System.Void OnParticlesEnd()
private System.Void OnParticlesStart()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NFakeMerchantVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnAnimationEvent
public static readonly Godot.StringName OnParticlesEnd
public static readonly Godot.StringName OnParticlesStart
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NFakeMerchantVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _particles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NFakeMerchantVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NFgGroundSpikeVfx

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Vfx.NBgGroundSpikeVfx`。

接口：`System.IDisposable`

```text
private static const System.String _scenePath = "res://scenes/vfx/fg_ground_spike_vfx.tscn"
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void AdjustStartPosition()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NFgGroundSpikeVfx Create(Godot.Vector2 position, System.Boolean movingRight = True, MegaCrit.Sts2.Core.Nodes.Vfx.VfxColor vfxColor = 0)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NFgGroundSpikeVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Vfx.NBgGroundSpikeVfx+MethodName`。

接口：

```text
public static readonly Godot.StringName AdjustStartPosition
public static readonly Godot.StringName Create
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NFgGroundSpikeVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Vfx.NBgGroundSpikeVfx+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NFgGroundSpikeVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Vfx.NBgGroundSpikeVfx+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NFireBurningVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private System.Threading.CancellationTokenSource _cts
private Godot.Collections.Array<Godot.GpuParticles2D> _endParticles
private Godot.Collections.Array<Godot.GpuParticles2D> _startParticles
public static readonly System.String scenePath
Godot.Color DefaultColor { private static get; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task PlaySequence()
private static Godot.Color get_DefaultColor()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NFireBurningVfx Create(Godot.Vector2 targetFloorPosition, System.Single scaleFactor, System.Boolean goingRight, Godot.Color tint)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NFireBurningVfx Create(Godot.Vector2 targetFloorPosition, System.Single scaleFactor, System.Boolean goingRight)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NFireBurningVfx Create(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature, System.Single scaleFactor, System.Boolean goingRight)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NFireBurningVfx+<PlaySequence>d__11

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NFireBurningVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NFireBurningVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NFireBurningVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _endParticles
public static readonly Godot.StringName _startParticles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NFireBurningVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NFireBurstVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private System.Threading.CancellationTokenSource _cts
private Godot.Collections.Array<Godot.GpuParticles2D> _modulateParticles
private Godot.Collections.Array<Godot.GpuParticles2D> _particles
public static readonly System.String scenePath
Godot.Color DefaultColor { private static get; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task PlaySequence()
private static Godot.Color get_DefaultColor()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NFireBurstVfx Create(Godot.Vector2 targetFloorPosition, System.Single scaleFactor, Godot.Color tint)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NFireBurstVfx Create(Godot.Vector2 targetFloorPosition, System.Single scaleFactor)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NFireBurstVfx Create(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature, System.Single scaleFactor)
public System.Void ApplyTint(Godot.Color tint)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NFireBurstVfx+<PlaySequence>d__12

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NFireBurstVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NFireBurstVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName ApplyTint
public static readonly Godot.StringName Create
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NFireBurstVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _modulateParticles
public static readonly Godot.StringName _particles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NFireBurstVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NFireSmokePuffVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private Godot.GpuParticles2D _clouds
private System.Threading.CancellationTokenSource _cts
private Godot.GpuParticles2D _ember
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
System.String ScenePath { private static get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task DeleteAfterComplete()
private static System.String get_ScenePath()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NFireSmokePuffVfx Create(MegaCrit.Sts2.Core.Entities.Creatures.Creature target)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NFireSmokePuffVfx+<DeleteAfterComplete>d__10

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NFireSmokePuffVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NFireSmokePuffVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NFireSmokePuffVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _clouds
public static readonly Godot.StringName _ember
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NFireSmokePuffVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NFlyconidSporesVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _animController
private Godot.CpuParticles2D _frailSpores
private Godot.Node2D _parent
private Godot.CpuParticles2D _vulnerableSpores
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnAnimationEvent(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___, Godot.GodotObject spineEvent)
private System.Void OnAnimationStart(Godot.GodotObject spineSprite, Godot.GodotObject animationState, Godot.GodotObject trackEntry)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void SetSporeTypeIsVulnerable(System.Boolean isVulnerable)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NFlyconidSporesVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnAnimationEvent
public static readonly Godot.StringName OnAnimationStart
public static readonly Godot.StringName SetSporeTypeIsVulnerable
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NFlyconidSporesVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _frailSpores
public static readonly Godot.StringName _parent
public static readonly Godot.StringName _vulnerableSpores
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NFlyconidSporesVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NFogmogVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private Godot.GpuParticles2D _dustLeftParticles
private Godot.GpuParticles2D _dustRightParticles
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _megaSprite
private Godot.GpuParticles2D _thrustParicles
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void EndThrust()
private System.Void OnAnimationEvent(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___, Godot.GodotObject spineEvent)
private System.Void StartThrust()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NFogmogVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName EndThrust
public static readonly Godot.StringName OnAnimationEvent
public static readonly Godot.StringName StartThrust
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NFogmogVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _dustLeftParticles
public static readonly Godot.StringName _dustRightParticles
public static readonly Godot.StringName _thrustParicles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NFogmogVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NFollowCursor

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

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

## MegaCrit.Sts2.Core.Nodes.Vfx.NFollowCursor+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _Process
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NFollowCursor+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NFollowCursor+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NFossilStalkerVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _animController
private Godot.GpuParticles2D _debuffParticles
private Godot.Node2D _parent
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnAnimationEvent(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___, Godot.GodotObject spineEvent)
private System.Void OnAnimationStart(Godot.GodotObject spineSprite, Godot.GodotObject animationState, Godot.GodotObject trackEntry)
private System.Void StartDebuff()
private System.Void StopDebuff()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NFossilStalkerVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnAnimationEvent
public static readonly Godot.StringName OnAnimationStart
public static readonly Godot.StringName StartDebuff
public static readonly Godot.StringName StopDebuff
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NFossilStalkerVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _debuffParticles
public static readonly Godot.StringName _parent
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NFossilStalkerVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NFullscreenTextVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private System.Threading.CancellationTokenSource _cts
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
private [async] System.Threading.Tasks.Task SelfDestruct()
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NFullscreenTextVfx Create(System.String text)
public virtual System.Void _ExitTree()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NFullscreenTextVfx+<SelfDestruct>d__3

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NFullscreenTextVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NFullscreenTextVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName Create
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NFullscreenTextVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NFullscreenTextVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NFuzzyWurmCrawlerSpitTrailVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _animController
private System.Boolean _isKeyDown
private Godot.Node2D _parent
private Godot.CpuParticles2D _trailParticles
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnAnimationEvent(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___, Godot.GodotObject spineEvent)
private System.Void OnAnimationStart(Godot.GodotObject spineSprite, Godot.GodotObject animationState, Godot.GodotObject trackEntry)
private System.Void TurnOffTrail()
private System.Void TurnOnTrail()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NFuzzyWurmCrawlerSpitTrailVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnAnimationEvent
public static readonly Godot.StringName OnAnimationStart
public static readonly Godot.StringName TurnOffTrail
public static readonly Godot.StringName TurnOnTrail
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NFuzzyWurmCrawlerSpitTrailVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _isKeyDown
public static readonly Godot.StringName _parent
public static readonly Godot.StringName _trailParticles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NFuzzyWurmCrawlerSpitTrailVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NGainEpochVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private System.Threading.CancellationTokenSource _cts
private Godot.Control _epoch
private MegaCrit.Sts2.addons.mega_text.MegaLabel _label
private MegaCrit.Sts2.Core.Timeline.EpochModel _model
private Godot.TextureRect _portrait
private Godot.Tween _tween
private static System.Int32 _vfxCount
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
System.String ScenePath { private static get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task AnimateVfx()
private static System.String get_ScenePath()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NGainEpochVfx Create(MegaCrit.Sts2.Core.Timeline.EpochModel model)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NGainEpochVfx+<AnimateVfx>d__12

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NGainEpochVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__2
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NGainEpochVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NGainEpochVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _epoch
public static readonly Godot.StringName _label
public static readonly Godot.StringName _portrait
public static readonly Godot.StringName _tween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NGainEpochVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NGasBombVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private Godot.GpuParticles2D _bitParticles
private Godot.GpuParticles2D _dotParticles
private Godot.GpuParticles2D _explodePuffParticles
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _megaSprite
private Godot.GpuParticles2D _puffParticles
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnAnimationEvent(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___, Godot.GodotObject spineEvent)
private System.Void OnBurst()
private System.Void OnDissipate()
private System.Void OnIdleParticles()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NGasBombVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnAnimationEvent
public static readonly Godot.StringName OnBurst
public static readonly Godot.StringName OnDissipate
public static readonly Godot.StringName OnIdleParticles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NGasBombVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _bitParticles
public static readonly Godot.StringName _dotParticles
public static readonly Godot.StringName _explodePuffParticles
public static readonly Godot.StringName _puffParticles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NGasBombVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NGaseousImpactVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private System.Threading.CancellationTokenSource _cts
private Godot.Collections.Array<Godot.GpuParticles2D> _impactParticles
public static readonly System.String scenePath
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task PlaySequence()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NGaseousImpactVfx Create(Godot.Vector2 targetCenter, Godot.Color tint)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NGaseousImpactVfx Create(MegaCrit.Sts2.Core.Combat.CombatSide side, MegaCrit.Sts2.Core.Combat.ICombatState combatState, Godot.Color tint)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NGaseousImpactVfx Create(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature, Godot.Color tint)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NGaseousImpactVfx+<PlaySequence>d__8

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NGaseousImpactVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NGaseousImpactVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NGaseousImpactVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _impactParticles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NGaseousImpactVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NGoopyImpactVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private System.Threading.CancellationTokenSource _cts
private Godot.Collections.Array<Godot.GpuParticles2D> _impactParticles
public static readonly System.String scenePath
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task PlaySequence()
private System.Void ModulateParticles(Godot.Color tint)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NGoopyImpactVfx Create(Godot.Vector2 targetCenterPosition, Godot.Color tint)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NGoopyImpactVfx Create(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NGoopyImpactVfx+<PlaySequence>d__8

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NGoopyImpactVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NGoopyImpactVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName ModulateParticles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NGoopyImpactVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _impactParticles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NGoopyImpactVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NGrandFinaleImpactVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NParticlesContainer _centerParticles
private System.Threading.CancellationTokenSource _cts
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NParticlesContainer _groundParticles
public static readonly System.String scenePath
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task PlaySequence()
private System.Void InitializePositions(Godot.Vector2 targetCenterPosition, Godot.Vector2 targetGroundPosition)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NGrandFinaleImpactVfx Create(Godot.Vector2 targetCenterPosition, Godot.Vector2 targetGroundPosition)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NGrandFinaleImpactVfx Create(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NGrandFinaleImpactVfx+<PlaySequence>d__9

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NGrandFinaleImpactVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NGrandFinaleImpactVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName InitializePositions
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NGrandFinaleImpactVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _centerParticles
public static readonly Godot.StringName _groundParticles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NGrandFinaleImpactVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NGrandFinaleVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private static readonly System.Single _anticipationDuration
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NParticlesContainer _anticipationParticles
private System.Threading.CancellationTokenSource _cts
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NParticlesContainer _endParticles
private static readonly System.Single _hitDuration
private static readonly System.Single _slashDuration
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NParticlesContainer _slashParticles
private Godot.Node2D _spotlight
private static readonly System.Single _spotlightDuration
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NParticlesContainer _spotlightParticles
public static readonly System.String scenePath
public static readonly System.Single totalAnticipationDuration
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task PlaySequence()
private System.Void Initialize(Godot.Vector2 playerPosition)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NGrandFinaleVfx Create(Godot.Vector2 playerPosition)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NGrandFinaleVfx Create(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NGrandFinaleVfx+<PlaySequence>d__17

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NGrandFinaleVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NGrandFinaleVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName Initialize
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NGrandFinaleVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _anticipationParticles
public static readonly Godot.StringName _endParticles
public static readonly Godot.StringName _slashParticles
public static readonly Godot.StringName _spotlight
public static readonly Godot.StringName _spotlightParticles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NGrandFinaleVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NGroundFireVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private Godot.GpuParticles2D _ember
private Godot.GpuParticles2D _flameSprites
private static readonly Godot.StringName _innerColor
private Godot.Node2D _mainFire
private static readonly Godot.StringName _outerColor
private static readonly System.String _scenePath
private Godot.Tween _tween
private MegaCrit.Sts2.Core.Nodes.Vfx.VfxColor _vfxColor
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task AnimateIn()
private System.Void ApplyColor()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NGroundFireVfx Create(MegaCrit.Sts2.Core.Entities.Creatures.Creature target, MegaCrit.Sts2.Core.Nodes.Vfx.VfxColor color = 0)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NGroundFireVfx+<AnimateIn>d__14

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NGroundFireVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
private System.Threading.Tasks.Task <emberDone>5__2
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NGroundFireVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName ApplyColor
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NGroundFireVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _ember
public static readonly Godot.StringName _flameSprites
public static readonly Godot.StringName _mainFire
public static readonly Godot.StringName _tween
public static readonly Godot.StringName _vfxColor
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NGroundFireVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NHauntedShipVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private Godot.GpuParticles2D _eyeParticles1
private Godot.GpuParticles2D _eyeParticles2
private Godot.GpuParticles2D _eyeParticles3
private Godot.GpuParticles2D _headParticles1
private Godot.GpuParticles2D _headParticles2
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _megaSprite
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnAnimationEvent(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___, Godot.GodotObject spineEvent)
private System.Void OnEyeBubblesEnd()
private System.Void OnEyeBubblesStart()
private System.Void OnHeadBubblesEnd()
private System.Void OnHeadBubblesStart()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NHauntedShipVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnAnimationEvent
public static readonly Godot.StringName OnEyeBubblesEnd
public static readonly Godot.StringName OnEyeBubblesStart
public static readonly Godot.StringName OnHeadBubblesEnd
public static readonly Godot.StringName OnHeadBubblesStart
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NHauntedShipVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _eyeParticles1
public static readonly Godot.StringName _eyeParticles2
public static readonly Godot.StringName _eyeParticles3
public static readonly Godot.StringName _headParticles1
public static readonly Godot.StringName _headParticles2
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NHauntedShipVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NHealNumVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Nodes.Combat.NCreature _creatureNode
private static readonly System.Single _deceleration
private static readonly Godot.Vector2 _positionOffset
private static readonly System.String _scenePath
private System.String _text
private Godot.Tween _tween
private Godot.Vector2 _velocity
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task AnimVfx()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NHealNumVfx Create(MegaCrit.Sts2.Core.Entities.Creatures.Creature target, System.Decimal amount)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Void _ExitTree()
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NHealNumVfx+<AnimVfx>d__11

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NHealNumVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NHealNumVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NHealNumVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _creatureNode
public static readonly Godot.StringName _text
public static readonly Godot.StringName _tween
public static readonly Godot.StringName _velocity
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NHealNumVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NHeavyBluntVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private Godot.Collections.Array<Godot.GpuParticles2D> _anticipationParticles
private Godot.Vector2 _debugPosition
private Godot.Collections.Array<Godot.GpuParticles2D> _impactParticles
public static readonly System.String scenePath
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task PlaySequence()
private [async] System.Threading.Tasks.Task WaitForSeconds(System.Single duration)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NHeavyBluntVfx Create(Godot.Vector2 debugPosition)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NHeavyBluntVfx+<PlaySequence>d__6

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NHeavyBluntVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NHeavyBluntVfx+<WaitForSeconds>d__7

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NHeavyBluntVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
private System.Double <timer>5__2
public System.Single duration
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NHeavyBluntVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NHeavyBluntVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _anticipationParticles
public static readonly Godot.StringName _debugPosition
public static readonly Godot.StringName _impactParticles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NHeavyBluntVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NHitSparkVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Nodes.Combat.NCreature _creatureNode
private Godot.Collections.Array<Godot.GpuParticles2D> _particles
private Godot.GpuParticles2D _specks
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
System.String ScenePath { private static get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task FlashAndFree()
private static System.String get_ScenePath()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NHitSparkVfx Create(MegaCrit.Sts2.Core.Entities.Creatures.Creature target, System.Boolean requireInteractable = True)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NHitSparkVfx+<FlashAndFree>d__9

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NHitSparkVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NHitSparkVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NHitSparkVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _creatureNode
public static readonly Godot.StringName _particles
public static readonly Godot.StringName _specks
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NHitSparkVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NHorizontalLinesVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.GpuParticles2D`。

接口：`System.IDisposable`

```text
private System.Double _duration
private System.Boolean _isMovingRight
private Godot.ParticleProcessMaterial _mat
private static readonly System.String _scenePath
private Godot.Tween _tween
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task PlayAnim()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NHorizontalLinesVfx Create(Godot.Color color, System.Double duration = 2, System.Boolean movingRightwards = True)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NHorizontalLinesVfx+<PlayAnim>d__10

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NHorizontalLinesVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NHorizontalLinesVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.GpuParticles2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NHorizontalLinesVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.GpuParticles2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _duration
public static readonly Godot.StringName _isMovingRight
public static readonly Godot.StringName _mat
public static readonly Godot.StringName _tween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NHorizontalLinesVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.GpuParticles2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NHunterKillerVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _megaSprite
private Godot.GpuParticles2D _particles
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnAnimationEvent(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___, Godot.GodotObject spineEvent)
private System.Void OnAnimationStart(Godot.GodotObject spineSprite, Godot.GodotObject animationState, Godot.GodotObject trackEntry)
private System.Void OnParticlesEnd()
private System.Void OnParticlesStart()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NHunterKillerVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnAnimationEvent
public static readonly Godot.StringName OnAnimationStart
public static readonly Godot.StringName OnParticlesEnd
public static readonly Godot.StringName OnParticlesStart
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NHunterKillerVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _particles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NHunterKillerVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NHyperbeamImpactVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private System.Threading.CancellationTokenSource _cts
private Godot.Collections.Array<Godot.GpuParticles2D> _impactEndParticles
private Godot.Collections.Array<Godot.GpuParticles2D> _impactStartParticles
public static readonly System.String scenePath
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task PlaySequence()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NHyperbeamImpactVfx Create(Godot.Vector2 hyperbeamSourcePosition, Godot.Vector2 targetCenterPosition)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NHyperbeamImpactVfx Create(MegaCrit.Sts2.Core.Entities.Creatures.Creature owner, MegaCrit.Sts2.Core.Entities.Creatures.Creature target)
public System.Void ApplyRotation(Godot.Vector2 sourcePosition, Godot.Vector2 targetPosition)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NHyperbeamImpactVfx+<PlaySequence>d__9

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NHyperbeamImpactVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NHyperbeamImpactVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName ApplyRotation
public static readonly Godot.StringName Create
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NHyperbeamImpactVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _impactEndParticles
public static readonly Godot.StringName _impactStartParticles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NHyperbeamImpactVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NHyperbeamVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private Godot.Collections.Array<Godot.GpuParticles2D> _anticipationParticles
private System.Threading.CancellationTokenSource _cts
private static const System.String _hyperbeamSfxPath = "event:/sfx/characters/defect/defect_hyperbeam"
private Godot.Node2D _laserContainer
private Godot.Collections.Array<Godot.GpuParticles2D> _laserEndParticles
private Godot.Line2D _laserLine
private Godot.Collections.Array<Godot.GpuParticles2D> _laserParticles
public static readonly System.Single hyperbeamAnticipationDuration
public static readonly System.Single hyperbeamLaserDuration
public static readonly System.String scenePath
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task PlaySequence()
private System.Void ShowLaser(System.Boolean showing)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NHyperbeamVfx Create(Godot.Vector2 defectEyePosition, Godot.Vector2 mainTargetCenterPosition)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NHyperbeamVfx Create(MegaCrit.Sts2.Core.Entities.Creatures.Creature owner, MegaCrit.Sts2.Core.Entities.Creatures.Creature target)
public System.Void ApplyRotation(Godot.Vector2 sourcePosition, Godot.Vector2 targetPosition)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NHyperbeamVfx+<PlaySequence>d__16

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NHyperbeamVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NHyperbeamVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName ApplyRotation
public static readonly Godot.StringName Create
public static readonly Godot.StringName ShowLaser
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NHyperbeamVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _anticipationParticles
public static readonly Godot.StringName _laserContainer
public static readonly Godot.StringName _laserEndParticles
public static readonly Godot.StringName _laserLine
public static readonly Godot.StringName _laserParticles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NHyperbeamVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NIroncladVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private Godot.TextureRect _eyeFireTex
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _megaSprite
private Godot.Node2D _parent
private Godot.ShaderMaterial _slashShaderMat
private Godot.Vector2 _slashStepBase
private static readonly Godot.StringName _step
private Godot.Tween _tween
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnAnimationEvent(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___, Godot.GodotObject spineEvent)
private System.Void OnAnimationStart(Godot.GodotObject spineSprite, Godot.GodotObject animationState, Godot.GodotObject trackEntry)
private System.Void OnAttackSlash()
private System.Void OnCastEyes()
private System.Void OnClearVfx()
private System.Void OnHeavySlash()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NIroncladVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnAnimationEvent
public static readonly Godot.StringName OnAnimationStart
public static readonly Godot.StringName OnAttackSlash
public static readonly Godot.StringName OnCastEyes
public static readonly Godot.StringName OnClearVfx
public static readonly Godot.StringName OnHeavySlash
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NIroncladVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _eyeFireTex
public static readonly Godot.StringName _parent
public static readonly Godot.StringName _slashShaderMat
public static readonly Godot.StringName _slashStepBase
public static readonly Godot.StringName _tween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NIroncladVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NItemThrowVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private static const System.Single _baseItemSize = 80
private System.Single _flightTime
private System.Single _heightMultiplier
private Godot.Curve _horizontalCurve
private Godot.Sprite2D _itemSprite
private Godot.Curve _rotationInfluenceCurve
private System.Single _rotationMultiplier
private Godot.Vector2 _sourcePosition
private Godot.Vector2 _targetPosition
private Godot.Curve _verticalCurve
public static readonly System.String scenePath
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task ThrowItem()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NItemThrowVfx Create(Godot.Vector2 sourcePosition, Godot.Vector2 targetPosition, Godot.Texture2D itemTexture, System.Nullable<Godot.Vector2> scale = null)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NItemThrowVfx+<ThrowItem>d__13

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NItemThrowVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
private System.Double <timer>5__2
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NItemThrowVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NItemThrowVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _flightTime
public static readonly Godot.StringName _heightMultiplier
public static readonly Godot.StringName _horizontalCurve
public static readonly Godot.StringName _itemSprite
public static readonly Godot.StringName _rotationInfluenceCurve
public static readonly Godot.StringName _rotationMultiplier
public static readonly Godot.StringName _sourcePosition
public static readonly Godot.StringName _targetPosition
public static readonly Godot.StringName _verticalCurve
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NItemThrowVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NKaiserCrabBossExplosionVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private Godot.GpuParticles2D _explosionParticles
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _megaSprite
private Godot.Node2D _parent
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnAnimationEvent(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___, Godot.GodotObject spineEvent)
private System.Void OnLeftEmbersStart()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NKaiserCrabBossExplosionVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnAnimationEvent
public static readonly Godot.StringName OnLeftEmbersStart
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NKaiserCrabBossExplosionVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _explosionParticles
public static readonly Godot.StringName _parent
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NKaiserCrabBossExplosionVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NKaiserCrabBossVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private Godot.Node2D _leftArmExplosionPosition
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _megaSprite
private Godot.Node2D _parent
private Godot.GpuParticles2D _plowChunkParticles
private Godot.GpuParticles2D _regenSplatParticles
private Godot.GpuParticles2D _smokeParticles
private Godot.GpuParticles2D _sparkParticles
private Godot.GpuParticles2D _spittleParticles
private Godot.GpuParticles2D _steamParticles1
private Godot.GpuParticles2D _steamParticles2
private Godot.GpuParticles2D _steamParticles3
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnAnimationEvent(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___, Godot.GodotObject spineEvent)
private System.Void OnAnimationStart(Godot.GodotObject spineSprite, Godot.GodotObject animationState, Godot.GodotObject trackEntry)
private System.Void OnChargeSteamEnd()
private System.Void OnChargeSteamStart()
private System.Void OnClawLExplode()
private System.Void OnDeathSpitEnd()
private System.Void OnDeathSpitStart()
private System.Void OnLeftEmbersStart()
private System.Void OnPlowChunksEnd()
private System.Void OnPlowChunksStart()
private System.Void OnRegenSplatsEnd()
private System.Void OnRegenSplatsStart()
private System.Void OnRocketThrustEnd()
private System.Void OnRocketThrustStart()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NKaiserCrabBossVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnAnimationEvent
public static readonly Godot.StringName OnAnimationStart
public static readonly Godot.StringName OnChargeSteamEnd
public static readonly Godot.StringName OnChargeSteamStart
public static readonly Godot.StringName OnClawLExplode
public static readonly Godot.StringName OnDeathSpitEnd
public static readonly Godot.StringName OnDeathSpitStart
public static readonly Godot.StringName OnLeftEmbersStart
public static readonly Godot.StringName OnPlowChunksEnd
public static readonly Godot.StringName OnPlowChunksStart
public static readonly Godot.StringName OnRegenSplatsEnd
public static readonly Godot.StringName OnRegenSplatsStart
public static readonly Godot.StringName OnRocketThrustEnd
public static readonly Godot.StringName OnRocketThrustStart
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NKaiserCrabBossVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _leftArmExplosionPosition
public static readonly Godot.StringName _parent
public static readonly Godot.StringName _plowChunkParticles
public static readonly Godot.StringName _regenSplatParticles
public static readonly Godot.StringName _smokeParticles
public static readonly Godot.StringName _sparkParticles
public static readonly Godot.StringName _spittleParticles
public static readonly Godot.StringName _steamParticles1
public static readonly Godot.StringName _steamParticles2
public static readonly Godot.StringName _steamParticles3
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NKaiserCrabBossVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NKinFollowerVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _animController
private Godot.GpuParticles2D _hay
private Godot.Node2D _parent
private MegaCrit.Sts2.Core.Nodes.Vfx.NBasicTrail _trail1
private MegaCrit.Sts2.Core.Nodes.Vfx.NBasicTrail _trail2
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void EndTrail1()
private System.Void EndTrail2()
private System.Void OnAnimationEvent(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___, Godot.GodotObject spineEvent)
private System.Void StartHay()
private System.Void StartTrail1()
private System.Void StartTrail2()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NKinFollowerVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName EndTrail1
public static readonly Godot.StringName EndTrail2
public static readonly Godot.StringName OnAnimationEvent
public static readonly Godot.StringName StartHay
public static readonly Godot.StringName StartTrail1
public static readonly Godot.StringName StartTrail2
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NKinFollowerVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _hay
public static readonly Godot.StringName _parent
public static readonly Godot.StringName _trail1
public static readonly Godot.StringName _trail2
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NKinFollowerVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NKinPriestBeamVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private Godot.Vector2 _baseBeamScale
private Godot.Sprite2D _beam
private Godot.Node2D _beamHolder
private static const System.Single _beamMaxLengthScale = 4
private static const System.Single _endRotation = -1
private Godot.Tween _lengthTween
private Godot.Tween _rotationTween
private static const System.Single _startRotation = 1
private Godot.GpuParticles2D _staticParticles
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnTweenComplete()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void Fire()
public virtual System.Void _ExitTree()
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NKinPriestBeamVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Fire
public static readonly Godot.StringName OnTweenComplete
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NKinPriestBeamVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _baseBeamScale
public static readonly Godot.StringName _beam
public static readonly Godot.StringName _beamHolder
public static readonly Godot.StringName _lengthTween
public static readonly Godot.StringName _rotationTween
public static readonly Godot.StringName _staticParticles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NKinPriestBeamVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NKinPriestGrenadeVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private readonly System.Threading.CancellationTokenSource _cancelToken
private Godot.GpuParticles2D _cryptoParticles
private Godot.GpuParticles2D _explosionBase
private Godot.GpuParticles2D _noiseParticles
private static readonly System.String _scenePath
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task Play()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NKinPriestGrenadeVfx Create(MegaCrit.Sts2.Core.Entities.Creatures.Creature target)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NKinPriestGrenadeVfx+<Play>d__7

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NKinPriestGrenadeVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NKinPriestGrenadeVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NKinPriestGrenadeVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _cryptoParticles
public static readonly Godot.StringName _explosionBase
public static readonly Godot.StringName _noiseParticles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NKinPriestGrenadeVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NKinPriestVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _animController
private MegaCrit.Sts2.Core.Nodes.Vfx.NKinPriestBeamVfx _beamVfx
private Godot.Node2D _parent
private Godot.GpuParticles2D _sparkParticles
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void EndSparks()
private System.Void FireLaser()
private System.Void OnAnimationEvent(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___, Godot.GodotObject spineEvent)
private System.Void StartSparks()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NKinPriestVfx+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Vfx.NKinPriestVfx+<>c <>9
public static System.Action<MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState> <>9__4_0
private static .cctor()
public .ctor()
internal System.Void <_Ready>b__4_0(MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState animState)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NKinPriestVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName EndSparks
public static readonly Godot.StringName FireLaser
public static readonly Godot.StringName OnAnimationEvent
public static readonly Godot.StringName StartSparks
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NKinPriestVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _beamVfx
public static readonly Godot.StringName _parent
public static readonly Godot.StringName _sparkParticles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NKinPriestVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NKnowledgeDemonVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _animController
private Godot.GpuParticles2D _damageParticles
private Godot.GpuParticles2D _emberParticles
private Godot.GpuParticles2D _explosionParticles
private Godot.Node2D _fireNode1
private Godot.Node2D _fireNode2
private Godot.Node2D _fireNode3
private Godot.Node2D _fireNode4
private Godot.Node2D _parent
private Godot.GpuParticles2D _thinEmberParticles
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnAnimationEvent(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___, Godot.GodotObject spineEvent)
private System.Void OnAnimationStart(Godot.GodotObject spineSprite, Godot.GodotObject animationState, Godot.GodotObject trackEntry)
private System.Void OnBurningEnd()
private System.Void OnBurningStart()
private System.Void OnEmbersEnd()
private System.Void OnEmbersStart()
private System.Void OnExplode()
private System.Void OnTakeDamage()
private System.Void OnThinEmbersEnd()
private System.Void OnThinEmbersStart()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NKnowledgeDemonVfx+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Vfx.NKnowledgeDemonVfx+<>c <>9
public static System.Action<MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState> <>9__10_0
private static .cctor()
public .ctor()
internal System.Void <_Ready>b__10_0(MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState animState)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NKnowledgeDemonVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnAnimationEvent
public static readonly Godot.StringName OnAnimationStart
public static readonly Godot.StringName OnBurningEnd
public static readonly Godot.StringName OnBurningStart
public static readonly Godot.StringName OnEmbersEnd
public static readonly Godot.StringName OnEmbersStart
public static readonly Godot.StringName OnExplode
public static readonly Godot.StringName OnTakeDamage
public static readonly Godot.StringName OnThinEmbersEnd
public static readonly Godot.StringName OnThinEmbersStart
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NKnowledgeDemonVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _damageParticles
public static readonly Godot.StringName _emberParticles
public static readonly Godot.StringName _explosionParticles
public static readonly Godot.StringName _fireNode1
public static readonly Godot.StringName _fireNode2
public static readonly Godot.StringName _fireNode3
public static readonly Godot.StringName _fireNode4
public static readonly Godot.StringName _parent
public static readonly Godot.StringName _thinEmberParticles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NKnowledgeDemonVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NLargeMagicMissileVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private Godot.Node2D _anticipationContainer
private System.Single _anticipationDuration
private Godot.Collections.Array<Godot.GpuParticles2D> _anticipationParticles
private System.Threading.CancellationTokenSource _cts
private Godot.Collections.Array<Godot.GpuParticles2D> _impactParticles
private Godot.Collections.Array<Godot.GpuParticles2D> _modulateParticles
private Godot.Node2D _projectileContainer
private Godot.Node2D _projectileEndPoint
private System.Single _projectileOffset
private Godot.Collections.Array<Godot.GpuParticles2D> _projectileParticles
private Godot.Collections.Array<Godot.GpuParticles2D> _projectileStartParticles
private Godot.Node2D _projectileStartPoint
private System.Single <WaitTime>k__BackingField
public static readonly System.String scenePath
System.Single WaitTime { public get; private set; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task PlaySequence()
private Godot.Vector2 GetProjectileDirection()
private Godot.Vector2 GetTopPosition(Godot.Vector2 projectileDirection)
private System.Void Initialize()
private System.Void ModulateParticles(Godot.Color tint)
private System.Void set_WaitTime(System.Single value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NLargeMagicMissileVfx Create(Godot.Vector2 targetFloorPosition, Godot.Color tint)
public System.Single get_WaitTime()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NLargeMagicMissileVfx+<PlaySequence>d__24

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NLargeMagicMissileVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__2
private System.Double <timer>5__2
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NLargeMagicMissileVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName GetProjectileDirection
public static readonly Godot.StringName GetTopPosition
public static readonly Godot.StringName Initialize
public static readonly Godot.StringName ModulateParticles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NLargeMagicMissileVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _anticipationContainer
public static readonly Godot.StringName _anticipationDuration
public static readonly Godot.StringName _anticipationParticles
public static readonly Godot.StringName _impactParticles
public static readonly Godot.StringName _modulateParticles
public static readonly Godot.StringName _projectileContainer
public static readonly Godot.StringName _projectileEndPoint
public static readonly Godot.StringName _projectileOffset
public static readonly Godot.StringName _projectileParticles
public static readonly Godot.StringName _projectileStartParticles
public static readonly Godot.StringName _projectileStartPoint
public static readonly Godot.StringName WaitTime
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NLargeMagicMissileVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NLaserVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _animController
private Godot.Node2D _animNode
private static readonly Godot.StringName _color
private Godot.Node2D _targetingBone
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void SetLaserColor(Godot.Color color)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void ExtendLaser(Godot.Vector2 targetPos)
public System.Void ResetLaser()
public System.Void RetractLaser()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NLaserVfx+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Vfx.NLaserVfx+<>c <>9
public static System.Action<MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState> <>9__4_0
private static .cctor()
public .ctor()
internal System.Void <_Ready>b__4_0(MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState animState)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NLaserVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName ExtendLaser
public static readonly Godot.StringName ResetLaser
public static readonly Godot.StringName RetractLaser
public static readonly Godot.StringName SetLaserColor
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NLaserVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _animNode
public static readonly Godot.StringName _targetingBone
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NLaserVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NLineBurstVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.GpuParticles2D`。

接口：`System.IDisposable`

```text
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
System.String ScenePath { private static get; }
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
private [async] System.Threading.Tasks.Task DeleteAfterComplete()
private static System.String get_ScenePath()
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NLineBurstVfx Create(Godot.Vector2 position)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NLineBurstVfx Create(MegaCrit.Sts2.Core.Entities.Creatures.Creature target)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NLineBurstVfx+<DeleteAfterComplete>d__7

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NLineBurstVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NLineBurstVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.GpuParticles2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NLineBurstVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.GpuParticles2D+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NLineBurstVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.GpuParticles2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NLiquidOverlayVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private System.Threading.CancellationTokenSource _cts
private MegaCrit.Sts2.Core.Entities.Creatures.Creature _targetCreature
private Godot.Color _tint
public static readonly System.String scenePath
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task PlayVfx()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NLiquidOverlayVfx Create(MegaCrit.Sts2.Core.Entities.Creatures.Creature targetCreature, Godot.Color tint)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NLiquidOverlayVfx+<PlayVfx>d__7

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NLiquidOverlayVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NLiquidOverlayVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NLiquidOverlayVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _tint
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NLiquidOverlayVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NLivingGasVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private static readonly Godot.StringName _alphaStep
private Godot.GpuParticles2D _attackPuffParticles
private Godot.GpuParticles2D _attackSparkParticles
private Godot.GpuParticles2D _debuffPuffParticles
private Godot.GpuParticles2D _gasPuffParticles
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _megaSprite
private Godot.Node2D _parent
private System.Collections.Generic.List<Godot.ShaderMaterial> _smokeMaterials
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSlotNode _smokeSlot1
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSlotNode _smokeSlot2
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSlotNode _smokeSlot3
private System.Collections.Generic.List<Godot.Vector2> _smokeSteps
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void DissipateFunction(System.Single t)
private System.Void OnAnimationEvent(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___, Godot.GodotObject spineEvent)
private System.Void OnAttackEnd()
private System.Void OnAttackStart()
private System.Void OnDeathBreathEnd()
private System.Void OnDeathBreathStart()
private System.Void OnDebuffEnd()
private System.Void OnDebuffStart()
private System.Void OnDissipate()
private System.Void OnHurtEnd()
private System.Void OnHurtStart()
private System.Void OnReconstitute()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NLivingGasVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName DissipateFunction
public static readonly Godot.StringName OnAnimationEvent
public static readonly Godot.StringName OnAttackEnd
public static readonly Godot.StringName OnAttackStart
public static readonly Godot.StringName OnDeathBreathEnd
public static readonly Godot.StringName OnDeathBreathStart
public static readonly Godot.StringName OnDebuffEnd
public static readonly Godot.StringName OnDebuffStart
public static readonly Godot.StringName OnDissipate
public static readonly Godot.StringName OnHurtEnd
public static readonly Godot.StringName OnHurtStart
public static readonly Godot.StringName OnReconstitute
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NLivingGasVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _attackPuffParticles
public static readonly Godot.StringName _attackSparkParticles
public static readonly Godot.StringName _debuffPuffParticles
public static readonly Godot.StringName _gasPuffParticles
public static readonly Godot.StringName _parent
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NLivingGasVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NLostAndForgottenVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _animController
private Godot.GpuParticles2D _dustParticles
private Godot.Node2D _parent
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnAnimationEvent(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___, Godot.GodotObject spineEvent)
private System.Void OnAnimationStart(Godot.GodotObject spineSprite, Godot.GodotObject animationState, Godot.GodotObject trackEntry)
private System.Void OnDustStart()
private System.Void OnDustStop()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NLostAndForgottenVfx+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Vfx.NLostAndForgottenVfx+<>c <>9
public static System.Action<MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState> <>9__3_0
private static .cctor()
public .ctor()
internal System.Void <_Ready>b__3_0(MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState animState)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NLostAndForgottenVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnAnimationEvent
public static readonly Godot.StringName OnAnimationStart
public static readonly Godot.StringName OnDustStart
public static readonly Godot.StringName OnDustStop
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NLostAndForgottenVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _dustParticles
public static readonly Godot.StringName _parent
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NLostAndForgottenVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NMapCircleVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private static const System.Double _animInterval = 0.041666666666666664
private Godot.TextureRect _image
private MegaCrit.Sts2.Core.Map.MapCoord _mapCoord
private static const System.String _path = "res://scenes/vfx/map_circle_vfx.tscn"
private System.Boolean _playAnim
private MegaCrit.Sts2.Core.Runs.IRunState _runState
private static readonly System.String[] _textures
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task AnimateSprite()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NMapCircleVfx Create(MegaCrit.Sts2.Core.Runs.IRunState runState, MegaCrit.Sts2.Core.Map.MapCoord mapCoord, System.Boolean playAnim)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NMapCircleVfx+<AnimateSprite>d__10

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NMapCircleVfx <>4__this
private System.String[] <>7__wrap1
private System.Int32 <>7__wrap2
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NMapCircleVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NMapCircleVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _image
public static readonly Godot.StringName _playAnim
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NMapCircleVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NMapNodeSelectVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private readonly System.Threading.CancellationTokenSource _cancelToken
private System.Double _lifeTimer
private Godot.GpuParticles2D _particles
private static const System.String _path = "res://scenes/vfx/map_node_select_vfx.tscn"
private static readonly System.String[] _textures
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task Play()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NMapNodeSelectVfx Create(System.Single scaleMultiplier)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NMapNodeSelectVfx+<Play>d__10

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NMapNodeSelectVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NMapNodeSelectVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NMapNodeSelectVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _lifeTimer
public static readonly Godot.StringName _particles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NMapNodeSelectVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NMapPingVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

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
private [async] System.Threading.Tasks.Task PlayAnim()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NMapPingVfx Create()
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NMapPingVfx+<PlayAnim>d__7

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NMapPingVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NMapPingVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NMapPingVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _tween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NMapPingVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NMechaKnightVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _animController
private Godot.GpuParticles2D _cinderParticles
private Godot.GpuParticles2D _engineParticles
private Godot.GpuParticles2D _engineParticlesDark
private Godot.GpuParticles2D _flameThrowerParticlesDark
private Godot.GpuParticles2D _flameThrowerParticlesLight
private Godot.GpuParticles2D _glowParticles
private Godot.Node2D _parent
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnAnimationEvent(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___, Godot.GodotObject spineEvent)
private System.Void OnAnimationStart(Godot.GodotObject spineSprite, Godot.GodotObject animationState, Godot.GodotObject trackEntry)
private System.Void TurnOffEngine()
private System.Void TurnOffFlameThrower()
private System.Void TurnOnEngine()
private System.Void TurnOnFlameThrower()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NMechaKnightVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnAnimationEvent
public static readonly Godot.StringName OnAnimationStart
public static readonly Godot.StringName TurnOffEngine
public static readonly Godot.StringName TurnOffFlameThrower
public static readonly Godot.StringName TurnOnEngine
public static readonly Godot.StringName TurnOnFlameThrower
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NMechaKnightVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _cinderParticles
public static readonly Godot.StringName _engineParticles
public static readonly Godot.StringName _engineParticlesDark
public static readonly Godot.StringName _flameThrowerParticlesDark
public static readonly Godot.StringName _flameThrowerParticlesLight
public static readonly Godot.StringName _glowParticles
public static readonly Godot.StringName _parent
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NMechaKnightVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NMinionDiveBombVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private System.Threading.CancellationTokenSource _cts
private Godot.Vector2 _destinationOffset
private Godot.Vector2 _destinationPosition
private Godot.Node2D _fallingTrail
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NParticlesContainer _fallingVfx
private System.Single _fallingVfxEntryTime
private System.Single _flightTime
private Godot.Curve _horizontalCurve
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NParticlesContainer _impactVfx
private System.Single _maxHeight
private Godot.Collections.Array<System.String> _minionAnimations
private Godot.AnimationPlayer _minionAnimator
private Godot.Sprite2D _minionSprite
private Godot.Collections.Array<Godot.Texture2D> _minionTextures
private Godot.Collections.Array<MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NParticlesContainer> _minionVfx
private System.Int32 _previousIndex
private Godot.Vector2 _sourceOffset
private Godot.Vector2 _sourcePosition
private Godot.Curve _textureCurve
private Godot.Curve _verticalCurve
public static readonly System.String scenePath
Godot.Vector2 DestinationFinalPosition { private get; }
Godot.Vector2 SourceFinalPosition { private get; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task PlaySequence()
private Godot.Vector2 get_DestinationFinalPosition()
private Godot.Vector2 get_SourceFinalPosition()
private System.Void Initialize(Godot.Vector2 sourcePosition, Godot.Vector2 destinationPosition)
private System.Void SetMinionVisible(System.Boolean visible)
private System.Void UpdateMinionSprite(System.Int32 index)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NMinionDiveBombVfx Create(Godot.Vector2 playerCenterPosition, Godot.Vector2 targetFloorPosition)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NMinionDiveBombVfx Create(MegaCrit.Sts2.Core.Entities.Creatures.Creature owner, MegaCrit.Sts2.Core.Entities.Creatures.Creature target)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NMinionDiveBombVfx+<PlaySequence>d__32

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NMinionDiveBombVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
private Godot.Vector2 <endPos>5__3
private System.Boolean <isPlayingFallingVfx>5__5
private Godot.Vector2 <startPos>5__2
private System.Double <timer>5__4
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NMinionDiveBombVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName Initialize
public static readonly Godot.StringName SetMinionVisible
public static readonly Godot.StringName UpdateMinionSprite
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NMinionDiveBombVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _destinationOffset
public static readonly Godot.StringName _destinationPosition
public static readonly Godot.StringName _fallingTrail
public static readonly Godot.StringName _fallingVfx
public static readonly Godot.StringName _fallingVfxEntryTime
public static readonly Godot.StringName _flightTime
public static readonly Godot.StringName _horizontalCurve
public static readonly Godot.StringName _impactVfx
public static readonly Godot.StringName _maxHeight
public static readonly Godot.StringName _minionAnimations
public static readonly Godot.StringName _minionAnimator
public static readonly Godot.StringName _minionSprite
public static readonly Godot.StringName _minionTextures
public static readonly Godot.StringName _minionVfx
public static readonly Godot.StringName _previousIndex
public static readonly Godot.StringName _sourceOffset
public static readonly Godot.StringName _sourcePosition
public static readonly Godot.StringName _textureCurve
public static readonly Godot.StringName _verticalCurve
public static readonly Godot.StringName DestinationFinalPosition
public static readonly Godot.StringName SourceFinalPosition
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NMinionDiveBombVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NMirrorVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private Godot.Sprite2D _mask1
private Godot.Sprite2D _mask2
private Godot.Sprite2D _mask3
private Godot.FastNoiseLite _noise
private static const System.Single _noiseSpeed = 2
private Godot.Control _reflection1
private Godot.Control _reflection2
private Godot.Control _reflection3
private System.Single _totalTime
System.String ScenePath { private static get; }
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private static System.String get_ScenePath()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NMirrorVfx Create()
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NMirrorVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NMirrorVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _mask1
public static readonly Godot.StringName _mask2
public static readonly Godot.StringName _mask3
public static readonly Godot.StringName _noise
public static readonly Godot.StringName _reflection1
public static readonly Godot.StringName _reflection2
public static readonly Godot.StringName _reflection3
public static readonly Godot.StringName _totalTime
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NMirrorVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NMonsterDeathVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private System.Threading.CancellationToken _cancelToken
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Combat.NCreature> _creatureNodes
private static const System.String _deathSfx = "event:/sfx/enemy/enemy_fade"
private System.Collections.Generic.List<Godot.Control> _hitboxes
private static const System.Single _minTweenDuration = 2.5
private static const System.Single _refLength = 0.1
private static const System.Single _refTweenDuration = 2.5
private static const System.String _shaderParamThreshold = "shader_parameter/threshold"
private static const System.Single _tweenStartValue = 0
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
System.String ScenePath { private static get; }
public .ctor()
private [async] System.Threading.Tasks.Task PlayVfxInternal()
private static System.String get_ScenePath()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public [async] System.Threading.Tasks.Task PlayVfx()
public static MegaCrit.Sts2.Core.Nodes.Vfx.NMonsterDeathVfx Create(MegaCrit.Sts2.Core.Nodes.Combat.NCreature creatureNode, System.Threading.CancellationToken cancelToken)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NMonsterDeathVfx Create(System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Combat.NCreature> creatureNodes)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NMonsterDeathVfx+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Vfx.NMonsterDeathVfx+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Nodes.Combat.NCreature, Godot.Control> <>9__14_0
private static .cctor()
public .ctor()
internal Godot.Control <Create>b__14_0(MegaCrit.Sts2.Core.Nodes.Combat.NCreature c)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NMonsterDeathVfx+<PlayVfx>d__15

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NMonsterDeathVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NMonsterDeathVfx+<PlayVfxInternal>d__16

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NMonsterDeathVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private Godot.Tween <tween>5__2
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NMonsterDeathVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NMonsterDeathVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NMonsterDeathVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NMyteVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _animController
private static const System.Single _attackHeight = 150
private Godot.Node2D _parent
private MegaCrit.Sts2.Core.Entities.Creatures.Creature _target
private Godot.Node2D _targetBone
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnAnimationEvent(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___, Godot.GodotObject spineEvent)
private System.Void StartCast()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void SetTarget(MegaCrit.Sts2.Core.Entities.Creatures.Creature target)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NMyteVfx+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Vfx.NMyteVfx+<>c <>9
public static System.Action<MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState> <>9__5_0
private static .cctor()
public .ctor()
internal System.Void <_Ready>b__5_0(MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState animState)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NMyteVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnAnimationEvent
public static readonly Godot.StringName StartCast
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NMyteVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _parent
public static readonly Godot.StringName _targetBone
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NMyteVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NNecrobinderVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _animController
private Godot.Node2D _headRef
private Godot.GpuParticles2D _hurtParticles
private Godot.GpuParticles2D _lowHealthParticles
private static readonly Godot.StringName _masterStepString
private static readonly Godot.StringName _opactyString
private Godot.Node2D _parent
private Godot.GpuParticles2D _scytheFireParticles1
private Godot.GpuParticles2D _scytheFireParticles2
private System.Single _slashOpacityBase
private Godot.ShaderMaterial _slashShaderMat
private System.Single _slashStepBase
private Godot.Tween _tween
private Godot.Tween _tween2
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnAnimationEvent(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___, Godot.GodotObject spineEvent)
private System.Void OnAttackSlashStart()
private System.Void OnHurtParticlesStart()
private System.Void OnLowHealthEnd()
private System.Void OnLowHealthStart()
private System.Void OnScytheFlame1()
private System.Void OnScytheFlame2()
private System.Void UpdateFlameVisibility(Godot.GodotObject spineSprite, Godot.GodotObject animationState, Godot.GodotObject trackEntry)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NNecrobinderVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnAnimationEvent
public static readonly Godot.StringName OnAttackSlashStart
public static readonly Godot.StringName OnHurtParticlesStart
public static readonly Godot.StringName OnLowHealthEnd
public static readonly Godot.StringName OnLowHealthStart
public static readonly Godot.StringName OnScytheFlame1
public static readonly Godot.StringName OnScytheFlame2
public static readonly Godot.StringName UpdateFlameVisibility
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NNecrobinderVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _headRef
public static readonly Godot.StringName _hurtParticles
public static readonly Godot.StringName _lowHealthParticles
public static readonly Godot.StringName _parent
public static readonly Godot.StringName _scytheFireParticles1
public static readonly Godot.StringName _scytheFireParticles2
public static readonly Godot.StringName _slashOpacityBase
public static readonly Godot.StringName _slashShaderMat
public static readonly Godot.StringName _slashStepBase
public static readonly Godot.StringName _tween
public static readonly Godot.StringName _tween2
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NNecrobinderVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NOilSpillVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _animController
private static const System.Int32 _deathSprayAmount = 500
private Godot.GpuParticles2D _droolParticles
private Godot.Node2D _parent
private Godot.GpuParticles2D _rainDropParticles
private static const System.Int32 _slamSprayAmount = 800
private static const System.Single _slamSprayLifetime = 0.75
private static const System.Int32 _sprayAttackAmount = 2000
private Godot.GpuParticles2D _sprayParticles
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnAnimationEvent(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___, Godot.GodotObject spineEvent)
private System.Void OnAnimationStart(Godot.GodotObject spineSprite, Godot.GodotObject animationState, Godot.GodotObject trackEntry)
private System.Void TurnOffDeathSpray()
private System.Void TurnOffDrool()
private System.Void TurnOffSlamSpray()
private System.Void TurnOffSprayAttack()
private System.Void TurnOnDeathSpray()
private System.Void TurnOnDrool()
private System.Void TurnOnSlamSpray()
private System.Void TurnOnSprayAttack()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NOilSpillVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnAnimationEvent
public static readonly Godot.StringName OnAnimationStart
public static readonly Godot.StringName TurnOffDeathSpray
public static readonly Godot.StringName TurnOffDrool
public static readonly Godot.StringName TurnOffSlamSpray
public static readonly Godot.StringName TurnOffSprayAttack
public static readonly Godot.StringName TurnOnDeathSpray
public static readonly Godot.StringName TurnOnDrool
public static readonly Godot.StringName TurnOnSlamSpray
public static readonly Godot.StringName TurnOnSprayAttack
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NOilSpillVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _droolParticles
public static readonly Godot.StringName _parent
public static readonly Godot.StringName _rainDropParticles
public static readonly Godot.StringName _sprayParticles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NOilSpillVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NParafrightVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _megaSprite
private Godot.GpuParticles2D _particles
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnAnimationEvent(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___, Godot.GodotObject spineEvent)
private System.Void OnParticlesEnd()
private System.Void OnParticlesStart()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NParafrightVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnAnimationEvent
public static readonly Godot.StringName OnParticlesEnd
public static readonly Godot.StringName OnParticlesStart
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NParafrightVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _particles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NParafrightVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NPhantasmalGardenerVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _megaSprite
private Godot.GpuParticles2D _spewParticles
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnAnimationEvent(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___, Godot.GodotObject spineEvent)
private System.Void OnSpewEnd()
private System.Void OnSpewStart()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NPhantasmalGardenerVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnAnimationEvent
public static readonly Godot.StringName OnSpewEnd
public static readonly Godot.StringName OnSpewStart
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NPhantasmalGardenerVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _spewParticles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NPhantasmalGardenerVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NPhrogParasiteVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _animController
private Godot.GpuParticles2D _bubbleParticlesA
private Godot.GpuParticles2D _bubbleParticlesB
private Godot.GpuParticles2D _bubbleParticlesC
private Godot.GpuParticles2D _gooParticlesDeath
private Godot.Node2D _parent
private Godot.GpuParticles2D _wormParticlesDeath
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnAnimationEvent(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___, Godot.GodotObject spineEvent)
private System.Void OnAnimationStart(Godot.GodotObject spineSprite, Godot.GodotObject animationState, Godot.GodotObject trackEntry)
private System.Void StartExplode()
private System.Void TurnOffInfect()
private System.Void TurnOnInfect()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NPhrogParasiteVfx+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Vfx.NPhrogParasiteVfx+<>c <>9
public static System.Action<MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState> <>9__7_0
private static .cctor()
public .ctor()
internal System.Void <_Ready>b__7_0(MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState animState)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NPhrogParasiteVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnAnimationEvent
public static readonly Godot.StringName OnAnimationStart
public static readonly Godot.StringName StartExplode
public static readonly Godot.StringName TurnOffInfect
public static readonly Godot.StringName TurnOnInfect
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NPhrogParasiteVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _bubbleParticlesA
public static readonly Godot.StringName _bubbleParticlesB
public static readonly Godot.StringName _bubbleParticlesC
public static readonly Godot.StringName _gooParticlesDeath
public static readonly Godot.StringName _parent
public static readonly Godot.StringName _wormParticlesDeath
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NPhrogParasiteVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NPoisonImpactVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private System.Threading.CancellationTokenSource _cts
private Godot.Node2D _horizontalSmokeContainer
private Godot.Collections.Array<Godot.GpuParticles2D> _impactParticles
public static readonly System.String scenePath
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task PlaySequence()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NPoisonImpactVfx Create(Godot.Vector2 targetCenter)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NPoisonImpactVfx Create(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NPoisonImpactVfx+<PlaySequence>d__8

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NPoisonImpactVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NPoisonImpactVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NPoisonImpactVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _horizontalSmokeContainer
public static readonly Godot.StringName _impactParticles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NPoisonImpactVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NPotionFlashVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private Godot.Control _flash
System.String ScenePath { public static get; }
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task FlashAndFree()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NPotionFlashVfx Create(MegaCrit.Sts2.Core.Nodes.Potions.NPotion originPotion)
public static System.String get_ScenePath()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NPotionFlashVfx+<FlashAndFree>d__5

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NPotionFlashVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NPotionFlashVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NPotionFlashVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _flash
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NPotionFlashVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NPowerAppliedVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private System.Int32 _amount
private Godot.TextureRect _icon
private Godot.TextureRect _iconEcho
private System.Boolean _isBuff
private MegaCrit.Sts2.Core.Models.PowerModel _power
private MegaCrit.Sts2.addons.mega_text.MegaLabel _powerField
private static const System.String _scenePath = "res://scenes/vfx/power_applied_vfx.tscn"
private Godot.Tween _spriteTween
private Godot.Tween _textTween
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task StartVfx()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NPowerAppliedVfx Create(MegaCrit.Sts2.Core.Models.PowerModel power, System.Int32 amount, System.Boolean isBuff)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NPowerAppliedVfx+<StartVfx>d__14

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NPowerAppliedVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NPowerAppliedVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NPowerAppliedVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _amount
public static readonly Godot.StringName _icon
public static readonly Godot.StringName _iconEcho
public static readonly Godot.StringName _isBuff
public static readonly Godot.StringName _powerField
public static readonly Godot.StringName _spriteTween
public static readonly Godot.StringName _textTween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NPowerAppliedVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NPowerFlashVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Models.PowerModel _power
private static const System.String _scenePath = "res://scenes/vfx/power_flash_vfx.tscn"
private Godot.Sprite2D _sprite
private Godot.Tween _spriteTween
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task StartVfx()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NPowerFlashVfx Create(MegaCrit.Sts2.Core.Models.PowerModel power)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NPowerFlashVfx+<StartVfx>d__8

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NPowerFlashVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NPowerFlashVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NPowerFlashVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _sprite
public static readonly Godot.StringName _spriteTween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NPowerFlashVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NPowerRemovedVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private Godot.Tween _positionTween
private MegaCrit.Sts2.Core.Models.PowerModel _power
private MegaCrit.Sts2.addons.mega_text.MegaLabel _powerField
private static const System.String _scenePath = "res://scenes/vfx/power_removed_vfx.tscn"
private Godot.TextureRect _sprite
private Godot.Tween _textTween
private Godot.Control _vfxContainer
private static MegaCrit.Sts2.Core.Localization.LocString _wearsOffLoc
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task StartVfx()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NPowerRemovedVfx Create(MegaCrit.Sts2.Core.Models.PowerModel power)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NPowerRemovedVfx+<StartVfx>d__12

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NPowerRemovedVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NPowerRemovedVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NPowerRemovedVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _positionTween
public static readonly Godot.StringName _powerField
public static readonly Godot.StringName _sprite
public static readonly Godot.StringName _textTween
public static readonly Godot.StringName _vfxContainer
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NPowerRemovedVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NPowerUpVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private Godot.Sprite2D _backVfx
private Godot.Control _creatureVisuals
private System.Single _timer
private static const System.Single _vfxDuration = 1
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
System.String GhostlyScenePath { private static get; }
System.String NormalScenePath { private static get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private static MegaCrit.Sts2.Core.Nodes.Vfx.NPowerUpVfx CreatePowerUpVfx(MegaCrit.Sts2.Core.Entities.Creatures.Creature target, System.String scenePath)
private static System.String get_GhostlyScenePath()
private static System.String get_NormalScenePath()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NPowerUpVfx CreateGhostly(MegaCrit.Sts2.Core.Entities.Creatures.Creature target)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NPowerUpVfx CreateNormal(MegaCrit.Sts2.Core.Entities.Creatures.Creature target)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NPowerUpVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NPowerUpVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _backVfx
public static readonly Godot.StringName _creatureVisuals
public static readonly Godot.StringName _timer
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NPowerUpVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NQueenVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _animController
private Godot.Node2D _spineNode
private Godot.GpuParticles2D _sprayParticles
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void EndAttack()
private System.Void OnAnimationEvent(Godot.GodotObject sprite, Godot.GodotObject animationState, Godot.GodotObject trackEntry, Godot.GodotObject eventObject)
private System.Void OnAnimationStart(Godot.GodotObject spineSprite, Godot.GodotObject animationState, Godot.GodotObject trackEntry)
private System.Void StartAttack()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NQueenVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName EndAttack
public static readonly Godot.StringName OnAnimationEvent
public static readonly Godot.StringName OnAnimationStart
public static readonly Godot.StringName StartAttack
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NQueenVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _spineNode
public static readonly Godot.StringName _sprayParticles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NQueenVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NRadialBlurVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.BackBufferCopy`。

接口：`System.IDisposable`

```text
private static readonly Godot.StringName _blurCenterx
private Godot.ShaderMaterial _blurShader
private Godot.Control _rect
private Godot.Tween _tween
private MegaCrit.Sts2.Core.Nodes.Vfx.VfxPosition _vfxPosition
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
public System.Void Activate(MegaCrit.Sts2.Core.Nodes.Vfx.VfxPosition vfxPosition = 2)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NRadialBlurVfx+<Animate>d__8

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NRadialBlurVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NRadialBlurVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.BackBufferCopy+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Activate
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NRadialBlurVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.BackBufferCopy+PropertyName`。

接口：

```text
public static readonly Godot.StringName _blurShader
public static readonly Godot.StringName _rect
public static readonly Godot.StringName _tween
public static readonly Godot.StringName _vfxPosition
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NRadialBlurVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.BackBufferCopy+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NRainVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.GpuParticles2D`。

接口：`System.IDisposable`

```text
System.String ScenePath { private static get; }
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
private static System.String get_ScenePath()
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NRainVfx Create()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NRainVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.GpuParticles2D+MethodName`。

接口：

```text
public static readonly Godot.StringName Create
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NRainVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.GpuParticles2D+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NRainVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.GpuParticles2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NRegentVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _animController
private Godot.GpuParticles2D _attackParticlesLarge
private Godot.GpuParticles2D _attackParticlesSmall
private Godot.GpuParticles2D _attackParticlesSmall2
private System.Int32 _curWeapon
private Godot.GpuParticles2D _deathParticlesArm
private Godot.GpuParticles2D _deathParticlesBack
private Godot.GpuParticles2D _deathParticlesChest
private Godot.GpuParticles2D _deathParticlesLeg
private Godot.GpuParticles2D _deathParticlesLegL
private Godot.GpuParticles2D _explosionParticles
private Godot.Node2D _parent
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _weapon
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _weapon2
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState _weaponAnimState
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState _weaponAnimState2
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void <_Ready>b__16_0(MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState animState)
private System.Void <_Ready>b__16_1(MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState animState)
private System.Void Attack()
private System.Void DisableExplode()
private System.Void Explode()
private System.Void OnAnimationEvent(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___, Godot.GodotObject spineEvent)
private System.Void OnAnimationStart(Godot.GodotObject spineSprite, Godot.GodotObject animationState, Godot.GodotObject trackEntry)
private System.Void TurnOffDying()
private System.Void TurnOnDying()
private System.Void TurnOnDying2()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NRegentVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Attack
public static readonly Godot.StringName DisableExplode
public static readonly Godot.StringName Explode
public static readonly Godot.StringName OnAnimationEvent
public static readonly Godot.StringName OnAnimationStart
public static readonly Godot.StringName TurnOffDying
public static readonly Godot.StringName TurnOnDying
public static readonly Godot.StringName TurnOnDying2
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NRegentVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _attackParticlesLarge
public static readonly Godot.StringName _attackParticlesSmall
public static readonly Godot.StringName _attackParticlesSmall2
public static readonly Godot.StringName _curWeapon
public static readonly Godot.StringName _deathParticlesArm
public static readonly Godot.StringName _deathParticlesBack
public static readonly Godot.StringName _deathParticlesChest
public static readonly Godot.StringName _deathParticlesLeg
public static readonly Godot.StringName _deathParticlesLegL
public static readonly Godot.StringName _explosionParticles
public static readonly Godot.StringName _parent
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NRegentVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NRelicFlashVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Models.RelicModel _relic
private static const System.String _scenePath = "res://scenes/vfx/relic_flash_vfx.tscn"
private Godot.TextureRect _sprite
private Godot.TextureRect _sprite2
private Godot.TextureRect _sprite3
private MegaCrit.Sts2.Core.Entities.Creatures.Creature _target
private static readonly Godot.Vector2 _targetScale
private Godot.Tween _tween
public static const System.Single activationDuration = 1
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task StartVfx()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NRelicFlashVfx Create(MegaCrit.Sts2.Core.Models.RelicModel relic, MegaCrit.Sts2.Core.Entities.Creatures.Creature target)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NRelicFlashVfx Create(MegaCrit.Sts2.Core.Models.RelicModel relic)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NRelicFlashVfx+<StartVfx>d__15

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NRelicFlashVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NRelicFlashVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NRelicFlashVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _sprite
public static readonly Godot.StringName _sprite2
public static readonly Godot.StringName _sprite3
public static readonly Godot.StringName _tween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NRelicFlashVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NRestSiteFireVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private Godot.Vector2 _baseScale
private System.Single _baseSkew
private Godot.Collections.Array<Godot.CpuParticles2D> _cpuGlowParticles
private System.Boolean _enabled
private System.Single _extinguishTime
private Godot.Collections.Array<Godot.GpuParticles2D> _gpuSparkParticles
private System.Single _maxFlickerScale
private System.Single _maxFlickerTime
private System.Single _maxSkew
private System.Single _maxSkewTime
private System.Single _minFlickerScale
private System.Single _minFlickerTime
private System.Single _minSkew
private System.Single _minSkewTime
private Godot.Tween _scaleTweenRef
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void Flicker()
private System.Void Sway()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void Extinguish()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NRestSiteFireVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Extinguish
public static readonly Godot.StringName Flicker
public static readonly Godot.StringName Sway
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NRestSiteFireVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _baseScale
public static readonly Godot.StringName _baseSkew
public static readonly Godot.StringName _cpuGlowParticles
public static readonly Godot.StringName _enabled
public static readonly Godot.StringName _extinguishTime
public static readonly Godot.StringName _gpuSparkParticles
public static readonly Godot.StringName _maxFlickerScale
public static readonly Godot.StringName _maxFlickerTime
public static readonly Godot.StringName _maxSkew
public static readonly Godot.StringName _maxSkewTime
public static readonly Godot.StringName _minFlickerScale
public static readonly Godot.StringName _minFlickerTime
public static readonly Godot.StringName _minSkew
public static readonly Godot.StringName _minSkewTime
public static readonly Godot.StringName _scaleTweenRef
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NRestSiteFireVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NRestSmokeVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private Godot.GpuParticles2D _clouds
private System.Threading.CancellationTokenSource _cts
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
System.String ScenePath { private static get; }
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task DeleteWhenFinished()
private static System.String get_ScenePath()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NRestSmokeVfx Create()
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NRestSmokeVfx+<DeleteWhenFinished>d__9

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NRestSmokeVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NRestSmokeVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NRestSmokeVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _clouds
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NRestSmokeVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NRollingBoulderVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private Godot.Sprite2D _boulder
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Creatures.Creature> _creatures
private System.Decimal _damage
private System.Nullable<Godot.Vector2> _debugFinalPosition
private static readonly System.Decimal _halfScaleDamage
private static const System.Single _maxRotationSpeed = 1000
private static const System.Single _maxScale = 1.5
private static const System.Single _maxTimeToImpact = 0.5
private static const System.Single _maxXOffset = 1000
private static const System.Single _minRotationSpeed = 600
private static const System.Single _minTimeToImpact = 0.25
private static const System.Single _minXOffset = 600
private static readonly System.String _scenePath
private Godot.Sprite2D _shadow
private Godot.GpuParticles2D _slamBehind
private Godot.GpuParticles2D _slamFront
private MegaCrit.Sts2.Core.Nodes.Vfx.NRollingBoulderVfx+FinishedEventHandler backing_Finished
private MegaCrit.Sts2.Core.Nodes.Vfx.NRollingBoulderVfx+HitCreatureEventHandler backing_HitCreature
System.String[] AssetPaths { public static get; }
event MegaCrit.Sts2.Core.Nodes.Vfx.NRollingBoulderVfx+FinishedEventHandler Finished
event MegaCrit.Sts2.Core.Nodes.Vfx.NRollingBoulderVfx+HitCreatureEventHandler HitCreature
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotSignalList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task PlayAnim(System.Single timeToImpact, System.Single xOffset, System.Single rotationSpeed)
private System.Void CleanUpBeforeEarlyExit()
protected System.Void EmitSignalFinished()
protected System.Void EmitSignalHitCreature(MegaCrit.Sts2.Core.Nodes.Combat.NCreature creature)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean HasGodotClassSignal(in Godot.NativeInterop.godot_string_name signal)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RaiseGodotClassSignalCallbacks(in Godot.NativeInterop.godot_string_name signal, Godot.NativeInterop.NativeVariantPtrArgs args)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NRollingBoulderVfx Create(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature> creatures, System.Decimal damage, System.Nullable<Godot.Vector2> debugFinalPosition = null)
public static System.String[] get_AssetPaths()
public System.Void add_Finished(MegaCrit.Sts2.Core.Nodes.Vfx.NRollingBoulderVfx+FinishedEventHandler value)
public System.Void add_HitCreature(MegaCrit.Sts2.Core.Nodes.Vfx.NRollingBoulderVfx+HitCreatureEventHandler value)
public System.Void remove_Finished(MegaCrit.Sts2.Core.Nodes.Vfx.NRollingBoulderVfx+FinishedEventHandler value)
public System.Void remove_HitCreature(MegaCrit.Sts2.Core.Nodes.Vfx.NRollingBoulderVfx+HitCreatureEventHandler value)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NRollingBoulderVfx+<PlayAnim>d__22

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NRollingBoulderVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Creatures.Creature> <creaturesHit>5__5
private System.Boolean <firstImpact>5__10
private Godot.Vector2 <impactPoint>5__6
private Godot.Vector2 <initialBoulderPosition>5__2
private Godot.Vector2 <initialShadowOffset>5__3
private Godot.Vector2 <initialShadowScale>5__4
private System.Single <timer>5__9
private Godot.Vector2 <velocity>5__8
private System.Single <yAccel>5__7
public System.Single rotationSpeed
public System.Single timeToImpact
public System.Single xOffset
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NRollingBoulderVfx+FinishedEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NRollingBoulderVfx+HitCreatureEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(MegaCrit.Sts2.Core.Nodes.Combat.NCreature creature, System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke(MegaCrit.Sts2.Core.Nodes.Combat.NCreature creature)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NRollingBoulderVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName CleanUpBeforeEarlyExit
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NRollingBoulderVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _boulder
public static readonly Godot.StringName _shadow
public static readonly Godot.StringName _slamBehind
public static readonly Godot.StringName _slamFront
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NRollingBoulderVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public static readonly Godot.StringName Finished
public static readonly Godot.StringName HitCreature
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NScratchVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private Godot.Collections.Array<Godot.GpuParticles2D> _anticipationParticles
private System.Threading.CancellationTokenSource _cts
private Godot.Collections.Array<Godot.GpuParticles2D> _impactParticles
public static readonly System.String scenePath
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task PlaySequence()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NScratchVfx Create(Godot.Vector2 targetCenterPosition, System.Boolean goingRight)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NScratchVfx Create(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature, System.Boolean goingRight)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NScratchVfx+<PlaySequence>d__8

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NScratchVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NScratchVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NScratchVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _anticipationParticles
public static readonly Godot.StringName _impactParticles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NScratchVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NScreamVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private Godot.Collections.Array<Godot.GpuParticles2D> _continuousParticles
private System.Threading.CancellationTokenSource _cts
private System.Single _duration
private Godot.Collections.Array<Godot.GpuParticles2D> _oneShotParticles
public static readonly System.String scenePath
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task PlaySequence()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NScreamVfx Create(Godot.Vector2 position)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NScreamVfx+<PlaySequence>d__8

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NScreamVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NScreamVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NScreamVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _continuousParticles
public static readonly Godot.StringName _duration
public static readonly Godot.StringName _oneShotParticles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NScreamVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSeapunkVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _animController
private Godot.GpuParticles2D _bubbleParticles
private Godot.Node2D _parent
private Godot.GpuParticles2D _weedParticles
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnAnimationEvent(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___, Godot.GodotObject spineEvent)
private System.Void StartBubbles()
private System.Void StartWeeds()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSeapunkVfx+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Vfx.NSeapunkVfx+<>c <>9
public static System.Action<MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState> <>9__4_0
private static .cctor()
public .ctor()
internal System.Void <_Ready>b__4_0(MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState animState)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSeapunkVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnAnimationEvent
public static readonly Godot.StringName StartBubbles
public static readonly Godot.StringName StartWeeds
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSeapunkVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _bubbleParticles
public static readonly Godot.StringName _parent
public static readonly Godot.StringName _weedParticles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSeapunkVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSewerClamVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private Godot.GpuParticles2D _buffParticles
private Godot.GpuParticles2D _chompParticles
private static const System.Single _coralScaleAmount = 0.2
private static const System.Single _coralTweenDelay = 0.5
private Godot.GpuParticles2D _deathParticles
private System.Boolean _keyDown
private static const System.Single _maxCoralScale = 1.5
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _megaSprite
private System.Boolean _onState
private Godot.Node2D _scaleNode
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnAnimationEvent(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___, Godot.GodotObject spineEvent)
private System.Void OnChomp()
private System.Void OnDarknessEnd()
private System.Void OnDarknessStart()
private System.Void OnDeathEnd()
private System.Void OnDeathStart()
private System.Void OnGrow()
private System.Void ScaleCoralTo(System.Single targetScale)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSewerClamVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnAnimationEvent
public static readonly Godot.StringName OnChomp
public static readonly Godot.StringName OnDarknessEnd
public static readonly Godot.StringName OnDarknessStart
public static readonly Godot.StringName OnDeathEnd
public static readonly Godot.StringName OnDeathStart
public static readonly Godot.StringName OnGrow
public static readonly Godot.StringName ScaleCoralTo
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSewerClamVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _buffParticles
public static readonly Godot.StringName _chompParticles
public static readonly Godot.StringName _deathParticles
public static readonly Godot.StringName _keyDown
public static readonly Godot.StringName _onState
public static readonly Godot.StringName _scaleNode
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSewerClamVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NShivThrowVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private static readonly Godot.StringName _color
private System.Threading.CancellationTokenSource _cts
private Godot.Collections.Array<Godot.GpuParticles2D> _impactParticles
private Godot.Collections.Array<Godot.GpuParticles2D> _modulateParticles
private Godot.Collections.Array<Godot.GpuParticles2D> _throwParticles
public static readonly System.String scenePath
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task PlaySequence()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NShivThrowVfx Create(Godot.Vector2 throwerCenterPosition, Godot.Vector2 targetCenterPosition, Godot.Color tint)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NShivThrowVfx Create(MegaCrit.Sts2.Core.Entities.Creatures.Creature owner, MegaCrit.Sts2.Core.Entities.Creatures.Creature target, Godot.Color tint)
public System.Void ApplyRotation(Godot.Vector2 throwerPosition, Godot.Vector2 targetPosition)
public System.Void ApplyTint(Godot.Color tint)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NShivThrowVfx+<PlaySequence>d__12

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NShivThrowVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NShivThrowVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName ApplyRotation
public static readonly Godot.StringName ApplyTint
public static readonly Godot.StringName Create
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NShivThrowVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _impactParticles
public static readonly Godot.StringName _modulateParticles
public static readonly Godot.StringName _throwParticles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NShivThrowVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSkulkingColonyVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _megaSprite
private Godot.GpuParticles2D _particles1
private Godot.GpuParticles2D _poofParticles
private Godot.GpuParticles2D _wideParticles
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void DamageHandler()
private System.Void DeathHandler()
private System.Void OnAnimationEvent(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___, Godot.GodotObject spineEvent)
private System.Void PoofHandler()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSkulkingColonyVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName DamageHandler
public static readonly Godot.StringName DeathHandler
public static readonly Godot.StringName OnAnimationEvent
public static readonly Godot.StringName PoofHandler
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSkulkingColonyVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _particles1
public static readonly Godot.StringName _poofParticles
public static readonly Godot.StringName _wideParticles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSkulkingColonyVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSleepingVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private Godot.Collections.Array<Godot.GpuParticles2D> _burstParticles
private Godot.Collections.Array<Godot.GpuParticles2D> _continuousParticles
private System.Threading.CancellationTokenSource _cts
private static readonly Godot.StringName _direction
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.LocalizedTexture _localizedZTexture
private Godot.GpuParticles2D _zParticles
public static readonly System.String scenePath
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task Stopping()
private System.Void Play()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NSleepingVfx Create(Godot.Vector2 targetTalkPosition, System.Boolean goingRight = True)
public System.Void SetFloatingDirection(System.Boolean goingRight)
public System.Void Stop()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSleepingVfx+<Stopping>d__13

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NSleepingVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSleepingVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName Play
public static readonly Godot.StringName SetFloatingDirection
public static readonly Godot.StringName Stop
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSleepingVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _burstParticles
public static readonly Godot.StringName _continuousParticles
public static readonly Godot.StringName _localizedZTexture
public static readonly Godot.StringName _zParticles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSleepingVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSlimedBerserkerVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _animController
private Godot.GpuParticles2D _gooParticlesL
private Godot.GpuParticles2D _gooParticlesR
private Godot.GpuParticles2D _gooParticlesVomit
private Godot.Node2D _parent
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnAnimationEvent(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___, Godot.GodotObject spineEvent)
private System.Void StartGooParticles()
private System.Void StartVomitParticles()
private System.Void StopGooParticles()
private System.Void StopVomitParticles()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSlimedBerserkerVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnAnimationEvent
public static readonly Godot.StringName StartGooParticles
public static readonly Godot.StringName StartVomitParticles
public static readonly Godot.StringName StopGooParticles
public static readonly Godot.StringName StopVomitParticles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSlimedBerserkerVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _gooParticlesL
public static readonly Godot.StringName _gooParticlesR
public static readonly Godot.StringName _gooParticlesVomit
public static readonly Godot.StringName _parent
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSlimedBerserkerVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSmallMagicMissileVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private Godot.Node2D _anticipationContainer
private System.Single _anticipationDuration
private Godot.Collections.Array<Godot.GpuParticles2D> _anticipationParticles
private System.Threading.CancellationTokenSource _cts
private Godot.Collections.Array<Godot.GpuParticles2D> _impactParticles
private Godot.Collections.Array<Godot.GpuParticles2D> _modulateParticles
private Godot.Node2D _projectileContainer
private Godot.Node2D _projectileEndPoint
private System.Single _projectileOffset
private Godot.Collections.Array<Godot.GpuParticles2D> _projectileParticles
private Godot.Collections.Array<Godot.GpuParticles2D> _projectileStartParticles
private Godot.Node2D _projectileStartPoint
private System.Single <WaitTime>k__BackingField
public static readonly System.String scenePath
System.Single WaitTime { public get; private set; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task PlaySequence()
private Godot.Vector2 GetProjectileDirection()
private Godot.Vector2 GetTopPosition(Godot.Vector2 projectileDirection)
private System.Void Initialize()
private System.Void ModulateParticles(Godot.Color tint)
private System.Void set_WaitTime(System.Single value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NSmallMagicMissileVfx Create(Godot.Vector2 targetCenterPosition, Godot.Color tint)
public System.Single get_WaitTime()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSmallMagicMissileVfx+<PlaySequence>d__24

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NSmallMagicMissileVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__2
private System.Double <timer>5__2
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSmallMagicMissileVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName GetProjectileDirection
public static readonly Godot.StringName GetTopPosition
public static readonly Godot.StringName Initialize
public static readonly Godot.StringName ModulateParticles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSmallMagicMissileVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _anticipationContainer
public static readonly Godot.StringName _anticipationDuration
public static readonly Godot.StringName _anticipationParticles
public static readonly Godot.StringName _impactParticles
public static readonly Godot.StringName _modulateParticles
public static readonly Godot.StringName _projectileContainer
public static readonly Godot.StringName _projectileEndPoint
public static readonly Godot.StringName _projectileOffset
public static readonly Godot.StringName _projectileParticles
public static readonly Godot.StringName _projectileStartParticles
public static readonly Godot.StringName _projectileStartPoint
public static readonly Godot.StringName WaitTime
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSmallMagicMissileVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSmokePuffVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private Godot.GpuParticles2D _clouds
private MegaCrit.Sts2.Core.Nodes.Vfx.NSmokePuffVfx+SmokePuffColor _color
private System.Threading.CancellationTokenSource _cts
private Godot.GpuParticles2D _ember
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
System.String ScenePath { private static get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task DeleteAfterComplete()
private static System.String get_ScenePath()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NSmokePuffVfx Create(MegaCrit.Sts2.Core.Entities.Creatures.Creature target, MegaCrit.Sts2.Core.Nodes.Vfx.NSmokePuffVfx+SmokePuffColor puffColor)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSmokePuffVfx+<DeleteAfterComplete>d__11

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NSmokePuffVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSmokePuffVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSmokePuffVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _clouds
public static readonly Godot.StringName _color
public static readonly Godot.StringName _ember
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSmokePuffVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSmokePuffVfx+SmokePuffColor

类型属性：`NestedPublic, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Nodes.Vfx.NSmokePuffVfx+SmokePuffColor Green = 0
public static const MegaCrit.Sts2.Core.Nodes.Vfx.NSmokePuffVfx+SmokePuffColor Purple = 1
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSmokyVignetteVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private Godot.Color _highlightColor
private Godot.Control _highlights
private static const System.String _path = "res://scenes/vfx/whole_screen/vfx_smoky_vignette.tscn"
private Godot.Color _targetColor
private Godot.Tween _tween
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task Animate(System.Boolean fadeIn)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NSmokyVignetteVfx Create(Godot.Color tint, Godot.Color highlightColor)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Void Reset(Godot.Color tint, Godot.Color highlightColor)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSmokyVignetteVfx+<Animate>d__10

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NSmokyVignetteVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
public System.Boolean fadeIn
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSmokyVignetteVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName Reset
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSmokyVignetteVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _highlightColor
public static readonly Godot.StringName _highlights
public static readonly Godot.StringName _targetColor
public static readonly Godot.StringName _tween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSmokyVignetteVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSnappingJaxfruitVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _animController
private static const System.Single _attackHeight = 130
private Godot.GpuParticles2D _blobParticles
private Godot.GpuParticles2D _glowParticles
private Godot.Node2D _parent
private Godot.Node2D _projectileBone
private MegaCrit.Sts2.Core.Entities.Creatures.Creature _target
private Godot.Node2D _targetBone
private MegaCrit.Sts2.Core.Nodes.Vfx.NBasicTrail _trail
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnAnimationEvent(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___, Godot.GodotObject spineEvent)
private System.Void OnAnimationStart(Godot.GodotObject spineSprite, Godot.GodotObject animationState, Godot.GodotObject trackEntry)
private System.Void ResetCast()
private System.Void StartCast()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void SetTarget(MegaCrit.Sts2.Core.Entities.Creatures.Creature target)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSnappingJaxfruitVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnAnimationEvent
public static readonly Godot.StringName OnAnimationStart
public static readonly Godot.StringName ResetCast
public static readonly Godot.StringName StartCast
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSnappingJaxfruitVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _blobParticles
public static readonly Godot.StringName _glowParticles
public static readonly Godot.StringName _parent
public static readonly Godot.StringName _projectileBone
public static readonly Godot.StringName _targetBone
public static readonly Godot.StringName _trail
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSnappingJaxfruitVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSoulFyshVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private static readonly Godot.StringName _amount
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _animController
private Godot.ShaderMaterial _beckonShaderMat
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSlotNode _beckonSlotNode
private Godot.Node2D _parent
private Godot.ShaderMaterial _soundShaderMat
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSlotNode _soundSlotNode
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void EndBeckon()
private System.Void EndSoundwave()
private System.Void OnAnimationEvent(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___, Godot.GodotObject spineEvent)
private System.Void StartBeckon()
private System.Void StartSoundwave()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSoulFyshVfx+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Vfx.NSoulFyshVfx+<>c <>9
public static System.Action<MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState> <>9__7_0
private static .cctor()
public .ctor()
internal System.Void <_Ready>b__7_0(MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState animState)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSoulFyshVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName EndBeckon
public static readonly Godot.StringName EndSoundwave
public static readonly Godot.StringName OnAnimationEvent
public static readonly Godot.StringName StartBeckon
public static readonly Godot.StringName StartSoundwave
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSoulFyshVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _beckonShaderMat
public static readonly Godot.StringName _parent
public static readonly Godot.StringName _soundShaderMat
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSoulFyshVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSoulNexusVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private Godot.TextureRect _fireTexture
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _megaSprite
private MegaCrit.Sts2.Core.Nodes.Vfx.NBasicTrail _trail1
private MegaCrit.Sts2.Core.Nodes.Vfx.NBasicTrail _trail2
private MegaCrit.Sts2.Core.Nodes.Vfx.NBasicTrail _trail3
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void EndPath1()
private System.Void EndPath2()
private System.Void EndPath3()
private System.Void OnAnimationEvent(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___, Godot.GodotObject spineEvent)
private System.Void ShowFire(System.Boolean show)
private System.Void StartPath1()
private System.Void StartPath2()
private System.Void StartPath3()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSoulNexusVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName EndPath1
public static readonly Godot.StringName EndPath2
public static readonly Godot.StringName EndPath3
public static readonly Godot.StringName OnAnimationEvent
public static readonly Godot.StringName ShowFire
public static readonly Godot.StringName StartPath1
public static readonly Godot.StringName StartPath2
public static readonly Godot.StringName StartPath3
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSoulNexusVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _fireTexture
public static readonly Godot.StringName _trail1
public static readonly Godot.StringName _trail2
public static readonly Godot.StringName _trail3
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSoulNexusVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSovereignBladeVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _animController
private Godot.Tween _attackTween
private Godot.Node2D _bladeGlow
private System.Single _bladeSize
private Godot.GpuParticles2D _chargeParticles
private Godot.TextureRect _detail
private static const System.Single _detailThreshold = 0.66
private Godot.GpuParticles2D _forgeSparks
private Godot.Tween _glowTween
private Godot.TextureRect _hilt
private Godot.TextureRect _hilt2
private static const System.Single _hiltThreshold = 0.3
private Godot.Control _hitbox
private MegaCrit.Sts2.Core.Nodes.HoverTips.NHoverTipSet _hoverTip
private System.Boolean _isAttacking
private System.Boolean _isBehindCharacter
private System.Boolean _isFocused
private System.Boolean _isForging
private System.Boolean _isKeyPressed
private Godot.Path2D _orbitPath
private static const System.Single _orbitSpeed = 60
private MegaCrit.Sts2.Core.Entities.Players.Player _owner
private Godot.Tween _scaleTween
private static readonly System.String _scenePath
private MegaCrit.Sts2.Core.Nodes.Combat.NSelectionReticle _selectionReticle
private Godot.GpuParticles2D _slashParticles
private Godot.Tween _sparkDelay
private Godot.GpuParticles2D _spawnFlames
private Godot.GpuParticles2D _spawnFlamesBack
private Godot.GpuParticles2D _spikeCircle
private Godot.GpuParticles2D _spikeCircle2
private Godot.GpuParticles2D _spikeParticles
private Godot.GpuParticles2D _spikeParticles2
private Godot.Node2D _spineNode
private Godot.Vector2 _targetOrbitPosition
private System.Single _testCharge
private Godot.Line2D _trail
private Godot.Tween _trailFadeTween
private Godot.Vector2 _trailStart
private MegaCrit.Sts2.Core.Models.CardModel <Card>k__BackingField
private System.Double <OrbitProgress>k__BackingField
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
MegaCrit.Sts2.Core.Models.CardModel Card { public get; private set; }
System.Double OrbitProgress { public get; public set; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void CleanupAttack()
private System.Void CleanupForge()
private System.Void EndSlash()
private System.Void FireFlames()
private System.Void FireSparks()
private System.Void OnFocused()
private System.Void OnOwnerDied(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
private System.Void OnTargetingBegan()
private System.Void OnTargetingEnded()
private System.Void OnUnfocused()
private System.Void set_Card(MegaCrit.Sts2.Core.Models.CardModel value)
private System.Void UpdateHoverTip()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public MegaCrit.Sts2.Core.Models.CardModel get_Card()
public static MegaCrit.Sts2.Core.Nodes.Vfx.NSovereignBladeVfx Create(MegaCrit.Sts2.Core.Models.CardModel card)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Double get_OrbitProgress()
public System.Void Attack(Godot.Vector2 targetPos)
public System.Void Forge(System.Single bladeDamage = 0, System.Boolean showFlames = False)
public System.Void RemoveSovereignBlade()
public System.Void set_OrbitProgress(System.Double value)
public virtual System.Void _ExitTree()
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSovereignBladeVfx+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Vfx.NSovereignBladeVfx+<>c <>9
public static System.Action<MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState> <>9__49_0
private static .cctor()
public .ctor()
internal System.Void <_Ready>b__49_0(MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState animState)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSovereignBladeVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Attack
public static readonly Godot.StringName CleanupAttack
public static readonly Godot.StringName CleanupForge
public static readonly Godot.StringName EndSlash
public static readonly Godot.StringName FireFlames
public static readonly Godot.StringName FireSparks
public static readonly Godot.StringName Forge
public static readonly Godot.StringName OnFocused
public static readonly Godot.StringName OnTargetingBegan
public static readonly Godot.StringName OnTargetingEnded
public static readonly Godot.StringName OnUnfocused
public static readonly Godot.StringName RemoveSovereignBlade
public static readonly Godot.StringName UpdateHoverTip
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSovereignBladeVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _attackTween
public static readonly Godot.StringName _bladeGlow
public static readonly Godot.StringName _bladeSize
public static readonly Godot.StringName _chargeParticles
public static readonly Godot.StringName _detail
public static readonly Godot.StringName _forgeSparks
public static readonly Godot.StringName _glowTween
public static readonly Godot.StringName _hilt
public static readonly Godot.StringName _hilt2
public static readonly Godot.StringName _hitbox
public static readonly Godot.StringName _hoverTip
public static readonly Godot.StringName _isAttacking
public static readonly Godot.StringName _isBehindCharacter
public static readonly Godot.StringName _isFocused
public static readonly Godot.StringName _isForging
public static readonly Godot.StringName _isKeyPressed
public static readonly Godot.StringName _orbitPath
public static readonly Godot.StringName _scaleTween
public static readonly Godot.StringName _selectionReticle
public static readonly Godot.StringName _slashParticles
public static readonly Godot.StringName _sparkDelay
public static readonly Godot.StringName _spawnFlames
public static readonly Godot.StringName _spawnFlamesBack
public static readonly Godot.StringName _spikeCircle
public static readonly Godot.StringName _spikeCircle2
public static readonly Godot.StringName _spikeParticles
public static readonly Godot.StringName _spikeParticles2
public static readonly Godot.StringName _spineNode
public static readonly Godot.StringName _targetOrbitPosition
public static readonly Godot.StringName _testCharge
public static readonly Godot.StringName _trail
public static readonly Godot.StringName _trailFadeTween
public static readonly Godot.StringName _trailStart
public static readonly Godot.StringName OrbitProgress
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSovereignBladeVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSpectralKnightVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _animController
private Godot.GpuParticles2D _cinderParticles
private Godot.GpuParticles2D _flameParticlesAdd
private Godot.GpuParticles2D _flameParticlesFlat
private Godot.Node2D _parent
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnAnimationEvent(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___, Godot.GodotObject spineEvent)
private System.Void OnAnimationStart(Godot.GodotObject spineSprite, Godot.GodotObject animationState, Godot.GodotObject trackEntry)
private System.Void TurnOffFire()
private System.Void TurnOnFire()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSpectralKnightVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnAnimationEvent
public static readonly Godot.StringName OnAnimationStart
public static readonly Godot.StringName TurnOffFire
public static readonly Godot.StringName TurnOnFire
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSpectralKnightVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _cinderParticles
public static readonly Godot.StringName _flameParticlesAdd
public static readonly Godot.StringName _flameParticlesFlat
public static readonly Godot.StringName _parent
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSpectralKnightVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSpeechBubbleVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private Godot.Sprite2D _bubble
private Godot.Control _container
private Godot.Node2D _contents
private System.Single _elapsedTime
private static readonly Godot.StringName _h
private Godot.ShaderMaterial _hsv
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _label
private static const System.String _path = "res://scenes/vfx/vfx_speech_bubble.tscn"
private static readonly Godot.StringName _s
private Godot.Sprite2D _shadow
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.DialogueSide _side
private static const System.Single _spawnProportionToEdgeOfHitbox = 0.75
private static const System.Single _spawnProportionToTopOfHitbox = 0.75
private Godot.Vector2 _startPos
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.DialogueStyle _style
private System.String _text
private Godot.Tween _tween
private static readonly Godot.StringName _v
private MegaCrit.Sts2.Core.Nodes.Vfx.VfxColor _vfxColor
private static const System.Single _waveAmplitude = 2
private static const System.Single _waveFrequency = 4.5
private System.Double <SecondsToDisplay>k__BackingField
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
System.Double SecondsToDisplay { public get; private set; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task AnimateSpeechBubble()
private [async] System.Threading.Tasks.Task AnimOutInternal()
private static Godot.Vector2 GetCreatureSpeechPosition(MegaCrit.Sts2.Core.Entities.Creatures.Creature speaker)
private static MegaCrit.Sts2.Core.Nodes.Vfx.NSpeechBubbleVfx CreateInternal(System.String text, MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.DialogueSide side, System.Double secondsToDisplay)
private System.Void set_SecondsToDisplay(System.Double value)
private System.Void SetSpeechBubbleColor()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public [async] System.Threading.Tasks.Task AnimOut()
public static MegaCrit.Sts2.Core.Nodes.Vfx.NSpeechBubbleVfx Create(System.String text, MegaCrit.Sts2.Core.Entities.Creatures.Creature speaker, System.Double secondsToDisplay, MegaCrit.Sts2.Core.Nodes.Vfx.VfxColor vfxColor = 5)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NSpeechBubbleVfx Create(System.String text, MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.DialogueSide side, Godot.Vector2 globalPosition, System.Double secondsToDisplay, MegaCrit.Sts2.Core.Nodes.Vfx.VfxColor vfxColor = 5)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Double get_SecondsToDisplay()
public virtual System.Void _ExitTree()
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSpeechBubbleVfx+<AnimateSpeechBubble>d__32

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NSpeechBubbleVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSpeechBubbleVfx+<AnimOut>d__33

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NSpeechBubbleVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSpeechBubbleVfx+<AnimOutInternal>d__34

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NSpeechBubbleVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSpeechBubbleVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName CreateInternal
public static readonly Godot.StringName SetSpeechBubbleColor
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSpeechBubbleVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _bubble
public static readonly Godot.StringName _container
public static readonly Godot.StringName _contents
public static readonly Godot.StringName _elapsedTime
public static readonly Godot.StringName _hsv
public static readonly Godot.StringName _label
public static readonly Godot.StringName _shadow
public static readonly Godot.StringName _side
public static readonly Godot.StringName _startPos
public static readonly Godot.StringName _style
public static readonly Godot.StringName _text
public static readonly Godot.StringName _tween
public static readonly Godot.StringName _vfxColor
public static readonly Godot.StringName SecondsToDisplay
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSpeechBubbleVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSpinyToadVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _animController
private Godot.Node2D _parent
private Godot.GpuParticles2D _spineParticles
private Godot.GpuParticles2D _spineSubParticles
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnAnimationEvent(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___, Godot.GodotObject spineEvent)
private System.Void StartExplosion()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSpinyToadVfx+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Vfx.NSpinyToadVfx+<>c <>9
public static System.Action<MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState> <>9__4_0
private static .cctor()
public .ctor()
internal System.Void <_Ready>b__4_0(MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState animState)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSpinyToadVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnAnimationEvent
public static readonly Godot.StringName StartExplosion
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSpinyToadVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _parent
public static readonly Godot.StringName _spineParticles
public static readonly Godot.StringName _spineSubParticles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSpinyToadVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSplashVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private System.Threading.CancellationTokenSource _cts
private Godot.Collections.Array<Godot.GpuParticles2D> _particles
private Godot.Color _tint
public static readonly System.String scenePath
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task PlayVfx()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NSplashVfx Create(Godot.Vector2 targetPosition, Godot.Color tint)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSplashVfx+<PlayVfx>d__7

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NSplashVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSplashVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSplashVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _particles
public static readonly Godot.StringName _tint
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSplashVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSpookyScreamVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private Godot.Collections.Array<Godot.GpuParticles2D> _continuousParticles
private System.Threading.CancellationTokenSource _cts
private System.Single _duration
private Godot.Collections.Array<Godot.GpuParticles2D> _oneShotParticles
public static readonly System.String scenePath
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task PlaySequence()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NSpookyScreamVfx Create(Godot.Vector2 position)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSpookyScreamVfx+<PlaySequence>d__8

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NSpookyScreamVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSpookyScreamVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSpookyScreamVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _continuousParticles
public static readonly Godot.StringName _duration
public static readonly Godot.StringName _oneShotParticles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSpookyScreamVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSporeImpactVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private System.Threading.CancellationTokenSource _cts
private Godot.Collections.Array<Godot.GpuParticles2D> _impactParticles
private Godot.Node2D _poofPivot
private Godot.Vector2 _scaleRange
public static readonly System.String scenePath
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task PlaySequence()
private System.Void Initialize()
private System.Void ModulateParticles(Godot.Color tint)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NSporeImpactVfx Create(Godot.Vector2 targetGroundPosition, Godot.Color tint)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NSporeImpactVfx Create(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature, Godot.Color color)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSporeImpactVfx+<PlaySequence>d__11

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NSporeImpactVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSporeImpactVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName Initialize
public static readonly Godot.StringName ModulateParticles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSporeImpactVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _impactParticles
public static readonly Godot.StringName _poofPivot
public static readonly Godot.StringName _scaleRange
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSporeImpactVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NStabVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private Godot.Vector2 _creatureCenter
private System.Boolean _facingEnemies
private Godot.Node2D _primaryVfx
private static const System.String _scenePath = "res://scenes/vfx/stab_vfx.tscn"
private Godot.Node2D _secondaryVfx
private Godot.Tween _tween
private MegaCrit.Sts2.Core.Nodes.Vfx.VfxColor _vfxColor
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task Animate()
private Godot.Vector2 GenerateSpawnPosition()
private System.Void SetColor()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NStabVfx Create(MegaCrit.Sts2.Core.Entities.Creatures.Creature target, System.Boolean facingEnemies = False, MegaCrit.Sts2.Core.Nodes.Vfx.VfxColor vfxColor = 0)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NStabVfx+<Animate>d__12

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NStabVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NStabVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName GenerateSpawnPosition
public static readonly Godot.StringName SetColor
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NStabVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _creatureCenter
public static readonly Godot.StringName _facingEnemies
public static readonly Godot.StringName _primaryVfx
public static readonly Godot.StringName _secondaryVfx
public static readonly Godot.StringName _tween
public static readonly Godot.StringName _vfxColor
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NStabVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NStarryImpactVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private System.Threading.CancellationTokenSource _cts
private Godot.Collections.Array<Godot.GpuParticles2D> _particles
public static readonly System.String scenePath
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task PlaySequence()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NStarryImpactVfx Create(Godot.Vector2 position)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NStarryImpactVfx+<PlaySequence>d__6

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NStarryImpactVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NStarryImpactVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NStarryImpactVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _particles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NStarryImpactVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NStunnedVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Entities.Creatures.Creature _creature
private MegaCrit.Sts2.addons.mega_text.MegaLabel _label
private Godot.Tween _positionTween
private static const System.String _scenePath = "res://scenes/vfx/stunned_vfx.tscn"
private static MegaCrit.Sts2.Core.Localization.LocString _stunnedLoc
private Godot.Tween _textTween
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task StartVfx()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NStunnedVfx Create(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NStunnedVfx+<StartVfx>d__10

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NStunnedVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NStunnedVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NStunnedVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _label
public static readonly Godot.StringName _positionTween
public static readonly Godot.StringName _textTween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NStunnedVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSweepingBeamImpactVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private System.Threading.CancellationTokenSource _cts
private Godot.Collections.Array<Godot.GpuParticles2D> _impactParticles
public static readonly System.String scenePath
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task PlaySequence()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NSweepingBeamImpactVfx Create(Godot.Vector2 targetCenter)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NSweepingBeamImpactVfx Create(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSweepingBeamImpactVfx+<PlaySequence>d__7

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NSweepingBeamImpactVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSweepingBeamImpactVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSweepingBeamImpactVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _impactParticles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSweepingBeamImpactVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSweepingBeamVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private System.Threading.CancellationTokenSource _cts
private Godot.Collections.Array<Godot.GpuParticles2D> _emittingParticles
private Godot.Collections.Array<Godot.GpuParticles2D> _endParticles
private Godot.Collections.Array<Godot.GpuParticles2D> _startParticles
private System.Single _sweepDuration
private Godot.Curve _sweepingIndexCurve
private Godot.Collections.Array<Godot.GpuParticles2D> _sweepingParticles
private Godot.Collections.Array<Godot.Vector2> _targetCenterPositions
public static readonly System.String scenePath
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task PlaySequence()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NSweepingBeamVfx Create(Godot.Vector2 defectEyeCenter, Godot.Collections.Array<Godot.Vector2> targetCenterPositions)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NSweepingBeamVfx Create(MegaCrit.Sts2.Core.Entities.Creatures.Creature owner, System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Creatures.Creature> targets)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSweepingBeamVfx+<PlaySequence>d__13

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NSweepingBeamVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
private System.Boolean <playedImpactParticles>5__3
private System.Int32 <previousSweepIndex>5__4
private System.Double <timer>5__2
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSweepingBeamVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSweepingBeamVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _emittingParticles
public static readonly Godot.StringName _endParticles
public static readonly Godot.StringName _startParticles
public static readonly Godot.StringName _sweepDuration
public static readonly Godot.StringName _sweepingIndexCurve
public static readonly Godot.StringName _sweepingParticles
public static readonly Godot.StringName _targetCenterPositions
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NSweepingBeamVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NTestSubjectBurnVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.ColorRect`。

接口：`System.IDisposable`

```text
private static readonly System.String _scenePath
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NTestSubjectBurnVfx Create()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NTestSubjectBurnVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.ColorRect+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NTestSubjectBurnVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.ColorRect+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NTestSubjectBurnVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.ColorRect+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NTestSubjectVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _animController
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _backBurnVfxController
private Godot.TextureRect _burnFire1
private Godot.Vector2 _burnFire1Scale
private Godot.TextureRect _burnFire2
private Godot.Vector2 _burnFire2Scale
private Godot.TextureRect _burnFire3
private Godot.Vector2 _burnFire3Scale
private Godot.Node2D _burnParticleContainer
private Godot.GpuParticles2D _burnParticleFountain
private Godot.Vector2 _burnParticleGlobalScale
private Godot.GpuParticles2D _burnParticles
private Godot.Tween _burnTween1
private Godot.Tween _burnTween2
private Godot.Tween _burnTween3
private Godot.GpuParticles2D _dizzyParticles
private System.Boolean _doingThing
private Godot.GpuParticles2D _emberParticles
private Godot.GpuParticles2D _flameParticles
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _frontBurnVfxController
private System.Boolean _keyDown
private Godot.GpuParticles2D _neckParticles
private Godot.Node2D _parent
private Godot.GpuParticles2D _targetedBurnParticle
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void ClearBurnFire()
private System.Void OnAnimationEvent(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___, Godot.GodotObject spineEvent)
private System.Void OnEndBurnVfx()
private System.Void OnEndDizzies()
private System.Void OnEndFlames()
private System.Void OnSquirtNeck()
private System.Void OnStartBurnVfx()
private System.Void OnStartDizzies()
private System.Void OnStartEmbers()
private System.Void OnStartFlames()
private System.Void PlayAnim1()
private System.Void TweenOutBurnFire()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NTestSubjectVfx+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Vfx.NTestSubjectVfx+<>c <>9
public static System.Action<MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState> <>9__24_0
public static System.Action<MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState> <>9__24_1
public static System.Action<MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState> <>9__24_2
private static .cctor()
public .ctor()
internal System.Void <_Ready>b__24_0(MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState animState)
internal System.Void <_Ready>b__24_1(MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState animState)
internal System.Void <_Ready>b__24_2(MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState animState)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NTestSubjectVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName ClearBurnFire
public static readonly Godot.StringName OnAnimationEvent
public static readonly Godot.StringName OnEndBurnVfx
public static readonly Godot.StringName OnEndDizzies
public static readonly Godot.StringName OnEndFlames
public static readonly Godot.StringName OnSquirtNeck
public static readonly Godot.StringName OnStartBurnVfx
public static readonly Godot.StringName OnStartDizzies
public static readonly Godot.StringName OnStartEmbers
public static readonly Godot.StringName OnStartFlames
public static readonly Godot.StringName PlayAnim1
public static readonly Godot.StringName TweenOutBurnFire
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NTestSubjectVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _burnFire1
public static readonly Godot.StringName _burnFire1Scale
public static readonly Godot.StringName _burnFire2
public static readonly Godot.StringName _burnFire2Scale
public static readonly Godot.StringName _burnFire3
public static readonly Godot.StringName _burnFire3Scale
public static readonly Godot.StringName _burnParticleContainer
public static readonly Godot.StringName _burnParticleFountain
public static readonly Godot.StringName _burnParticleGlobalScale
public static readonly Godot.StringName _burnParticles
public static readonly Godot.StringName _burnTween1
public static readonly Godot.StringName _burnTween2
public static readonly Godot.StringName _burnTween3
public static readonly Godot.StringName _dizzyParticles
public static readonly Godot.StringName _doingThing
public static readonly Godot.StringName _emberParticles
public static readonly Godot.StringName _flameParticles
public static readonly Godot.StringName _keyDown
public static readonly Godot.StringName _neckParticles
public static readonly Godot.StringName _parent
public static readonly Godot.StringName _targetedBurnParticle
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NTestSubjectVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NTheInsatiableVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _animController
private Godot.GpuParticles2D _baseBlastParticles
private Godot.CpuParticles2D[] _continuousParticles
private Godot.Node2D _parent
private Godot.CpuParticles2D _salivaCloudParticles
private Godot.CpuParticles2D _salivaDroolParticles
private Godot.CpuParticles2D _salivaFountainParticles
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnAnimationEvent(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___, Godot.GodotObject spineEvent)
private System.Void OnAnimationStart(Godot.GodotObject spineSprite, Godot.GodotObject animationState, Godot.GodotObject trackEntry)
private System.Void TurnOffBaseBlast()
private System.Void TurnOffContinuousParticles()
private System.Void TurnOffDrool()
private System.Void TurnOffSaliva()
private System.Void TurnOnBaseBlast()
private System.Void TurnOnDrool()
private System.Void TurnOnSaliva()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NTheInsatiableVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnAnimationEvent
public static readonly Godot.StringName OnAnimationStart
public static readonly Godot.StringName TurnOffBaseBlast
public static readonly Godot.StringName TurnOffContinuousParticles
public static readonly Godot.StringName TurnOffDrool
public static readonly Godot.StringName TurnOffSaliva
public static readonly Godot.StringName TurnOnBaseBlast
public static readonly Godot.StringName TurnOnDrool
public static readonly Godot.StringName TurnOnSaliva
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NTheInsatiableVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _baseBlastParticles
public static readonly Godot.StringName _continuousParticles
public static readonly Godot.StringName _parent
public static readonly Godot.StringName _salivaCloudParticles
public static readonly Godot.StringName _salivaDroolParticles
public static readonly Godot.StringName _salivaFountainParticles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NTheInsatiableVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NTheObscuraVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _megaSprite
private Godot.GpuParticles2D _particles
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnAnimationEvent(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___, Godot.GodotObject spineEvent)
private System.Void OnParticlesEnd()
private System.Void OnParticlesStart()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NTheObscuraVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnAnimationEvent
public static readonly Godot.StringName OnParticlesEnd
public static readonly Godot.StringName OnParticlesStart
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NTheObscuraVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _particles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NTheObscuraVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NThinSliceVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private Godot.Vector2 _creatureCenter
private System.Threading.CancellationTokenSource _cts
private static const System.String _scenePath = "res://scenes/vfx/thin_slice_vfx.tscn"
private Godot.GpuParticles2D _slash
private Godot.GpuParticles2D _sparkle
private MegaCrit.Sts2.Core.Nodes.Vfx.VfxColor _vfxColor
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task SelfDestruct()
private Godot.Vector2 GenerateSpawnPosition()
private System.Single GetAngle()
private System.Void SetColor()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NThinSliceVfx Create(MegaCrit.Sts2.Core.Entities.Creatures.Creature target, MegaCrit.Sts2.Core.Nodes.Vfx.VfxColor vfxColor = 6)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NThinSliceVfx+<SelfDestruct>d__14

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NThinSliceVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NThinSliceVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName GenerateSpawnPosition
public static readonly Godot.StringName GetAngle
public static readonly Godot.StringName SetColor
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NThinSliceVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _creatureCenter
public static readonly Godot.StringName _slash
public static readonly Godot.StringName _sparkle
public static readonly Godot.StringName _vfxColor
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NThinSliceVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NThoughtBubbleVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private Godot.Control _container
private Godot.Node2D _contents
private System.Threading.CancellationTokenSource _cts
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _label
private static const System.String _path = "res://scenes/vfx/vfx_thought_bubble.tscn"
private System.Nullable<System.Double> _secondsToDisplay
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.DialogueSide _side
private static const System.Single _spawnProportionToEdgeOfHitbox = 0.75
private static const System.Single _spawnProportionToTopOfHitbox = 0.75
private System.Nullable<Godot.Vector2> _startPos
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.DialogueStyle _style
private Godot.Node2D _tail
private System.String _text
private Godot.Texture2D _texture
private Godot.TextureRect _textureRect
private Godot.Tween _tween
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task AnimateThoughtBubble()
private static MegaCrit.Sts2.Core.Nodes.Vfx.NThoughtBubbleVfx CreateInternal(System.String text, Godot.Texture2D texture, MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.DialogueSide side, System.Nullable<System.Double> secondsToDisplay)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public [async] System.Threading.Tasks.Task GoAway()
public static Godot.Vector2 GetCreatureSpeechPosition(MegaCrit.Sts2.Core.Entities.Creatures.Creature speaker)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NThoughtBubbleVfx Create(Godot.Texture2D texture, MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.DialogueSide side, System.Nullable<System.Double> secondsToDisplay)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NThoughtBubbleVfx Create(System.String text, MegaCrit.Sts2.Core.Entities.Creatures.Creature speaker, System.Nullable<System.Double> secondsToDisplay)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NThoughtBubbleVfx Create(System.String text, MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.DialogueSide side, System.Nullable<System.Double> secondsToDisplay)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Void SetTexture(Godot.Texture2D texture)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NThoughtBubbleVfx+<AnimateThoughtBubble>d__22

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NThoughtBubbleVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NThoughtBubbleVfx+<GoAway>d__24

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NThoughtBubbleVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NThoughtBubbleVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName SetTexture
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NThoughtBubbleVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _container
public static readonly Godot.StringName _contents
public static readonly Godot.StringName _label
public static readonly Godot.StringName _side
public static readonly Godot.StringName _style
public static readonly Godot.StringName _tail
public static readonly Godot.StringName _text
public static readonly Godot.StringName _texture
public static readonly Godot.StringName _textureRect
public static readonly Godot.StringName _tween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NThoughtBubbleVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NUiFlashVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private Godot.Color _modulate
private static const System.String _scenePath = "res://scenes/vfx/ui_flash_vfx.tscn"
private Godot.Tween _spriteTween
private Godot.Texture2D _texture
private Godot.TextureRect _textureRect
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
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
public [async] System.Threading.Tasks.Task StartVfx()
public static MegaCrit.Sts2.Core.Nodes.Vfx.NUiFlashVfx Create(Godot.Texture2D tex, Godot.Color modulate)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NUiFlashVfx+<StartVfx>d__8

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NUiFlashVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NUiFlashVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NUiFlashVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _modulate
public static readonly Godot.StringName _spriteTween
public static readonly Godot.StringName _texture
public static readonly Godot.StringName _textureRect
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NUiFlashVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NVantomVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _animController
private Godot.GpuParticles2D _deathExplosionParticles
private Godot.GpuParticles2D _deathSprayParticles
private Godot.GpuParticles2D _deathSprayParticlesBack
private Godot.Node2D _parent
private Godot.GpuParticles2D _sprayParticles
private static readonly Godot.StringName _step
private Godot.ShaderMaterial _tailShaderMat
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void <DissolveTail>b__11_0()
private System.Void DeathExplode()
private System.Void DissolveTail()
private System.Void EndDeathSpray()
private System.Void EndSpray()
private System.Void OnAnimationEvent(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___, Godot.GodotObject spineEvent)
private System.Void OnAnimationStart(Godot.GodotObject spineSprite, Godot.GodotObject animationState, Godot.GodotObject trackEntry)
private System.Void StartDeathSpray()
private System.Void StartSpray()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NVantomVfx+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Vfx.NVantomVfx+<>c <>9
public static System.Action<MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState> <>9__8_0
private static .cctor()
public .ctor()
internal System.Void <_Ready>b__8_0(MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState animState)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NVantomVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName DeathExplode
public static readonly Godot.StringName DissolveTail
public static readonly Godot.StringName EndDeathSpray
public static readonly Godot.StringName EndSpray
public static readonly Godot.StringName OnAnimationEvent
public static readonly Godot.StringName OnAnimationStart
public static readonly Godot.StringName StartDeathSpray
public static readonly Godot.StringName StartSpray
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NVantomVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _deathExplosionParticles
public static readonly Godot.StringName _deathSprayParticles
public static readonly Godot.StringName _deathSprayParticlesBack
public static readonly Godot.StringName _parent
public static readonly Godot.StringName _sprayParticles
public static readonly Godot.StringName _tailShaderMat
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NVantomVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NVfxSpawner

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Input(Godot.InputEvent inputEvent)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NVfxSpawner+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Input
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NVfxSpawner+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NVfxSpawner+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NVineShamblerVinesVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _backVinesAnimController
private Godot.Node2D _backVinesNode
private Godot.GpuParticles2D _dirtBlast1
private Godot.GpuParticles2D _dirtBlast2
private Godot.GpuParticles2D _dirtBlast3
private Godot.GpuParticles2D _dirtBlast4
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _frontVinesAnimController
private Godot.Node2D _frontVinesNode
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void AnimationEnded(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___)
private System.Void OnFrontEvent(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___, Godot.GodotObject spineEvent)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NVineShamblerVinesVfx+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Vfx.NVineShamblerVinesVfx+<>c <>9
public static System.Action<MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState> <>9__8_1
public static System.Action<MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState> <>9__8_2
private static .cctor()
public .ctor()
internal System.Void <_Ready>b__8_1(MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState animState)
internal System.Void <_Ready>b__8_2(MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState animState)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NVineShamblerVinesVfx+<>c__DisplayClass8_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Vfx.NVineShamblerVinesVfx <>4__this
public Godot.Vector2 backVineOffset
public .ctor()
internal System.Void <_Ready>b__0()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NVineShamblerVinesVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AnimationEnded
public static readonly Godot.StringName OnFrontEvent
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NVineShamblerVinesVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _backVinesNode
public static readonly Godot.StringName _dirtBlast1
public static readonly Godot.StringName _dirtBlast2
public static readonly Godot.StringName _dirtBlast3
public static readonly Godot.StringName _dirtBlast4
public static readonly Godot.StringName _frontVinesNode
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NVineShamblerVinesVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NWaterfallGiantVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _animController
private Godot.GpuParticles2D _dropletParticles
private System.Boolean _isDead
private Godot.ParticleProcessMaterial _leakProcMat1
private Godot.ParticleProcessMaterial _leakProcMat2
private Godot.ParticleProcessMaterial _leakProcMat3
private Godot.GpuParticles2D _mistParticles
private Godot.GpuParticles2D _mouthParticles
private Godot.Node2D _parent
private Godot.GpuParticles2D _steam1Particles
private Godot.GpuParticles2D _steam2Particles
private Godot.GpuParticles2D _steam3Particles
private Godot.GpuParticles2D _steam4Particles
private Godot.GpuParticles2D _steam5Particles
private Godot.GpuParticles2D _steam6Particles
private Godot.GpuParticles2D _steamLeakParticles1
private Godot.GpuParticles2D _steamLeakParticles2
private Godot.GpuParticles2D _steamLeakParticles3
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void Buildup1()
private System.Void Buildup2()
private System.Void Buildup3()
private System.Void ClearDeathSteam()
private System.Void EmitGracefully(Godot.GpuParticles2D emitter)
private System.Void EndSteam1()
private System.Void EndSteam2()
private System.Void EndSteam3()
private System.Void EndSteam5()
private System.Void EndWaterfall()
private System.Void Explode()
private System.Void OnAnimationEvent(Godot.GodotObject _, Godot.GodotObject __, Godot.GodotObject ___, Godot.GodotObject spineEvent)
private System.Void StartSteam1()
private System.Void StartSteam2()
private System.Void StartSteam3()
private System.Void StartSteam5()
private System.Void StartWaterfall()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NWaterfallGiantVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Buildup1
public static readonly Godot.StringName Buildup2
public static readonly Godot.StringName Buildup3
public static readonly Godot.StringName ClearDeathSteam
public static readonly Godot.StringName EmitGracefully
public static readonly Godot.StringName EndSteam1
public static readonly Godot.StringName EndSteam2
public static readonly Godot.StringName EndSteam3
public static readonly Godot.StringName EndSteam5
public static readonly Godot.StringName EndWaterfall
public static readonly Godot.StringName Explode
public static readonly Godot.StringName OnAnimationEvent
public static readonly Godot.StringName StartSteam1
public static readonly Godot.StringName StartSteam2
public static readonly Godot.StringName StartSteam3
public static readonly Godot.StringName StartSteam5
public static readonly Godot.StringName StartWaterfall
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NWaterfallGiantVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _dropletParticles
public static readonly Godot.StringName _isDead
public static readonly Godot.StringName _leakProcMat1
public static readonly Godot.StringName _leakProcMat2
public static readonly Godot.StringName _leakProcMat3
public static readonly Godot.StringName _mistParticles
public static readonly Godot.StringName _mouthParticles
public static readonly Godot.StringName _parent
public static readonly Godot.StringName _steam1Particles
public static readonly Godot.StringName _steam2Particles
public static readonly Godot.StringName _steam3Particles
public static readonly Godot.StringName _steam4Particles
public static readonly Godot.StringName _steam5Particles
public static readonly Godot.StringName _steam6Particles
public static readonly Godot.StringName _steamLeakParticles1
public static readonly Godot.StringName _steamLeakParticles2
public static readonly Godot.StringName _steamLeakParticles3
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NWaterfallGiantVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NWormyImpactVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private Godot.Node2D _centerPivot
private System.Threading.CancellationTokenSource _cts
private Godot.Node2D _groundPivot
private Godot.Collections.Array<Godot.GpuParticles2D> _particles
public static readonly System.String scenePath
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task PlaySequence()
private System.Void Initialize(Godot.Vector2 targetGroundPosition, Godot.Vector2 targetCenterPosition)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NWormyImpactVfx Create(Godot.Vector2 targetGroundPosition, Godot.Vector2 targetCenterPosition)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NWormyImpactVfx Create(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NWormyImpactVfx+<PlaySequence>d__10

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.NWormyImpactVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NWormyImpactVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName Initialize
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NWormyImpactVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _centerPivot
public static readonly Godot.StringName _groundPivot
public static readonly Godot.StringName _particles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.NWormyImpactVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.PlayerFullscreenHealVfx

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static readonly System.String _scenePath
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
private static .cctor()
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public static System.Void Play(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Decimal healAmount, Godot.Control vfxContainer)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.PlayerHurtVignetteHelper

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static MegaCrit.Sts2.Core.Nodes.Vfx.Ui.NLowHpBorderVfx _currentVfx
public static System.Void Play()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.VfxColor

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Nodes.Vfx.VfxColor Black = 4
public static const MegaCrit.Sts2.Core.Nodes.Vfx.VfxColor Blue = 2
public static const MegaCrit.Sts2.Core.Nodes.Vfx.VfxColor Cyan = 6
public static const MegaCrit.Sts2.Core.Nodes.Vfx.VfxColor DarkGray = 10
public static const MegaCrit.Sts2.Core.Nodes.Vfx.VfxColor Gold = 7
public static const MegaCrit.Sts2.Core.Nodes.Vfx.VfxColor Green = 1
public static const MegaCrit.Sts2.Core.Nodes.Vfx.VfxColor Orange = 8
public static const MegaCrit.Sts2.Core.Nodes.Vfx.VfxColor Purple = 3
public static const MegaCrit.Sts2.Core.Nodes.Vfx.VfxColor Red = 0
public static const MegaCrit.Sts2.Core.Nodes.Vfx.VfxColor Swamp = 9
public System.Int32 value__
public static const MegaCrit.Sts2.Core.Nodes.Vfx.VfxColor White = 5
```

## MegaCrit.Sts2.Core.Nodes.Vfx.VfxDuration

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Nodes.Vfx.VfxDuration Custom = 6
public static const MegaCrit.Sts2.Core.Nodes.Vfx.VfxDuration Forever = 7
public static const MegaCrit.Sts2.Core.Nodes.Vfx.VfxDuration Long = 4
public static const MegaCrit.Sts2.Core.Nodes.Vfx.VfxDuration None = 0
public static const MegaCrit.Sts2.Core.Nodes.Vfx.VfxDuration Short = 2
public static const MegaCrit.Sts2.Core.Nodes.Vfx.VfxDuration Standard = 3
public System.Int32 value__
public static const MegaCrit.Sts2.Core.Nodes.Vfx.VfxDuration VeryLong = 5
public static const MegaCrit.Sts2.Core.Nodes.Vfx.VfxDuration VeryShort = 1
```

## MegaCrit.Sts2.Core.Nodes.Vfx.VfxPosition

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Nodes.Vfx.VfxPosition Center = 2
public static const MegaCrit.Sts2.Core.Nodes.Vfx.VfxPosition Left = 1
public static const MegaCrit.Sts2.Core.Nodes.Vfx.VfxPosition None = 0
public static const MegaCrit.Sts2.Core.Nodes.Vfx.VfxPosition Right = 3
public System.Int32 value__
```
