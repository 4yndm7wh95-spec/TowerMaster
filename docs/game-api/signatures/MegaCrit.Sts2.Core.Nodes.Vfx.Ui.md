# MegaCrit.Sts2.Core.Nodes.Vfx.Ui

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.Vfx.Ui.NEpochChains

类型属性：`Public, BeforeFieldInit`；基类：`Godot.TextureRect`。

接口：`System.IDisposable`

```text
private Godot.ShaderMaterial _asShaderMaterial
private Godot.Curve _brightEnabledCurve
private static readonly Godot.StringName _brightEnabledString
private System.Single _duration
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NParticlesContainer _endParticles
private Godot.Curve _erosionBaseCurve
private static readonly Godot.StringName _erosionBaseString
private Godot.Curve _erosionEnabledCurve
private static readonly Godot.StringName _erosionEnabledString
private Godot.Collections.Array<MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NParticlesContainer> _particles
private Godot.Curve _particlesCurve
private System.Int32 _previousParticleIndex
private MegaCrit.Sts2.Core.Nodes.Vfx.Ui.NEpochChains+OnAnimationFinishedEventHandler backing_OnAnimationFinished
event MegaCrit.Sts2.Core.Nodes.Vfx.Ui.NEpochChains+OnAnimationFinishedEventHandler OnAnimationFinished
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotSignalList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void SetProperties(System.Single interpolation)
private System.Void UpdateParticles(System.Int32 index)
protected System.Void EmitSignalOnAnimationFinished()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean HasGodotClassSignal(in Godot.NativeInterop.godot_string_name signal)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RaiseGodotClassSignalCallbacks(in Godot.NativeInterop.godot_string_name signal, Godot.NativeInterop.NativeVariantPtrArgs args)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public [async] System.Threading.Tasks.Task Unlocking(System.Single duration)
public System.Void add_OnAnimationFinished(MegaCrit.Sts2.Core.Nodes.Vfx.Ui.NEpochChains+OnAnimationFinishedEventHandler value)
public System.Void remove_OnAnimationFinished(MegaCrit.Sts2.Core.Nodes.Vfx.Ui.NEpochChains+OnAnimationFinishedEventHandler value)
public System.Void Unlock()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Ui.NEpochChains+<Unlocking>d__16

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.Ui.NEpochChains <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
private Godot.Material <originalMaterial>5__3
private System.Double <timer>5__2
public System.Single duration
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Ui.NEpochChains+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.TextureRect+MethodName`。

接口：

```text
public static readonly Godot.StringName SetProperties
public static readonly Godot.StringName Unlock
public static readonly Godot.StringName UpdateParticles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Ui.NEpochChains+OnAnimationFinishedEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Ui.NEpochChains+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.TextureRect+PropertyName`。

接口：

```text
public static readonly Godot.StringName _asShaderMaterial
public static readonly Godot.StringName _brightEnabledCurve
public static readonly Godot.StringName _duration
public static readonly Godot.StringName _endParticles
public static readonly Godot.StringName _erosionBaseCurve
public static readonly Godot.StringName _erosionEnabledCurve
public static readonly Godot.StringName _particles
public static readonly Godot.StringName _particlesCurve
public static readonly Godot.StringName _previousParticleIndex
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Ui.NEpochChains+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.TextureRect+SignalName`。

接口：

```text
public static readonly Godot.StringName OnAnimationFinished
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Ui.NFailedJoinVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _label
private static readonly System.String _scenePath
private Godot.Tween _tween
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task PlayAndSelfDestruct()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.Ui.NFailedJoinVfx Create(System.String text)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Ui.NFailedJoinVfx+<PlayAndSelfDestruct>d__5

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.Ui.NFailedJoinVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Ui.NFailedJoinVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Ui.NFailedJoinVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _label
public static readonly Godot.StringName _tween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Ui.NFailedJoinVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Ui.NGaseousScreenVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.AspectRatioContainer`。

接口：`System.IDisposable`

```text
private Godot.Curve _alphaMultiplierCurve
private static readonly Godot.StringName _alphaMultiplierString
private System.Single _duration
private Godot.Curve _erosionCurve
private static readonly Godot.StringName _erosionString
private Godot.ColorRect _gfx
private Godot.ShaderMaterial _materialCopy
private Godot.Curve _minBaseAlphaCurve
private static readonly Godot.StringName _minBaseAlphaString
private Godot.Curve _noiseAOffsetCurve
private static readonly Godot.StringName _noiseAOffsetString
private System.Single _noiseAOffsetY
private Godot.Curve _noiseBOffsetCurve
private static readonly Godot.StringName _noiseBOffsetString
private System.Single _noiseBOffsetY
private Godot.Material _originalMaterial
private static readonly System.String _scenePath
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task PlaySequence()
private System.Void Play()
private System.Void SetProperties(System.Single interpolation)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.Ui.NGaseousScreenVfx Create()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Ui.NGaseousScreenVfx+<PlaySequence>d__21

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.Ui.NGaseousScreenVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
private System.Double <timer>5__2
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Ui.NGaseousScreenVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.AspectRatioContainer+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName Play
public static readonly Godot.StringName SetProperties
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Ui.NGaseousScreenVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.AspectRatioContainer+PropertyName`。

接口：

```text
public static readonly Godot.StringName _alphaMultiplierCurve
public static readonly Godot.StringName _duration
public static readonly Godot.StringName _erosionCurve
public static readonly Godot.StringName _gfx
public static readonly Godot.StringName _materialCopy
public static readonly Godot.StringName _minBaseAlphaCurve
public static readonly Godot.StringName _noiseAOffsetCurve
public static readonly Godot.StringName _noiseAOffsetY
public static readonly Godot.StringName _noiseBOffsetCurve
public static readonly Godot.StringName _noiseBOffsetY
public static readonly Godot.StringName _originalMaterial
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Ui.NGaseousScreenVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.AspectRatioContainer+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Ui.NLowHpBorderVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.ColorRect`。

接口：`System.IDisposable`

```text
private Godot.Curve _alphaMultiplierCurve
private static readonly Godot.StringName _alphaMultiplierString
private System.Double _currentTimer
private System.Single _duration
private Godot.Gradient _gradient
private System.Boolean _isPlaying
private static readonly Godot.StringName _mainColorString
private Godot.ShaderMaterial _materialCopy
private static readonly Godot.StringName _noiseInitialOffsetString
private Godot.Curve _noiseOffsetCurve
private Godot.Material _originalMaterial
public static readonly System.String scenePath
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task PlaySequence()
private System.Void RandomizeInitialOffset()
private System.Void SetProperties(System.Single interpolation)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Vfx.Ui.NLowHpBorderVfx Create()
public System.Void Play()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Ui.NLowHpBorderVfx+<PlaySequence>d__17

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.Ui.NLowHpBorderVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Ui.NLowHpBorderVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.ColorRect+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName Play
public static readonly Godot.StringName RandomizeInitialOffset
public static readonly Godot.StringName SetProperties
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Ui.NLowHpBorderVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.ColorRect+PropertyName`。

接口：

```text
public static readonly Godot.StringName _alphaMultiplierCurve
public static readonly Godot.StringName _currentTimer
public static readonly Godot.StringName _duration
public static readonly Godot.StringName _gradient
public static readonly Godot.StringName _isPlaying
public static readonly Godot.StringName _materialCopy
public static readonly Godot.StringName _noiseOffsetCurve
public static readonly Godot.StringName _originalMaterial
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Ui.NLowHpBorderVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.ColorRect+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Ui.NPowerAppliedBuffVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private System.Threading.CancellationTokenSource _cts
private Godot.Collections.Array<Godot.GpuParticles2D> _particles
private static readonly System.String _scenePath
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
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
public static MegaCrit.Sts2.Core.Nodes.Vfx.Ui.NPowerAppliedBuffVfx Create(Godot.Vector2 globalPosition)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Ui.NPowerAppliedBuffVfx+<PlaySequence>d__8

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.Ui.NPowerAppliedBuffVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Ui.NPowerAppliedBuffVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Ui.NPowerAppliedBuffVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _particles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Ui.NPowerAppliedBuffVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Ui.NPowerAppliedDebuffVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private System.Threading.CancellationTokenSource _cts
private Godot.Collections.Array<Godot.GpuParticles2D> _particles
public static readonly System.String scenePath
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
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
public static MegaCrit.Sts2.Core.Nodes.Vfx.Ui.NPowerAppliedDebuffVfx Create(Godot.Vector2 globalPosition)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Ui.NPowerAppliedDebuffVfx+<PlaySequence>d__7

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Vfx.Ui.NPowerAppliedDebuffVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Ui.NPowerAppliedDebuffVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Ui.NPowerAppliedDebuffVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _particles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Ui.NPowerAppliedDebuffVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```
