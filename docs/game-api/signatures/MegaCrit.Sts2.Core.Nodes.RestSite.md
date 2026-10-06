# MegaCrit.Sts2.Core.Nodes.RestSite

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.RestSite.NParticleSystemUpscaler

类型属性：`Public, BeforeFieldInit`；基类：`Godot.CpuParticles2D`。

接口：`System.IDisposable`

```text
private Godot.Vector2 _originalResolution
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.RestSite.NParticleSystemUpscaler+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.CpuParticles2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.RestSite.NParticleSystemUpscaler+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.CpuParticles2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _originalResolution
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.RestSite.NParticleSystemUpscaler+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.CpuParticles2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.RestSite.NRestSiteButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private readonly System.Threading.CancellationTokenSource _cts
private Godot.Tween _currentTween
private System.Boolean _executingOption
private Godot.ShaderMaterial _hsv
private Godot.TextureRect _icon
private System.Boolean _isUnclickable
private MegaCrit.Sts2.addons.mega_text.MegaLabel _label
private Godot.Vector2 _labelPosition
private MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption _option
private Godot.Control _outline
private static readonly Godot.StringName _s
private static readonly System.String _scenePath
private static const System.Double _unfocusAnimDur = 1
private static readonly Godot.StringName _v
private Godot.Control _visuals
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption Option { public get; public set; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task AnimateIn()
private [async] System.Threading.Tasks.Task SelectOption(MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption option)
private System.Void Reload()
private System.Void UpdateShaderParam(System.Single value)
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
public MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption get_Option()
public static MegaCrit.Sts2.Core.Nodes.RestSite.NRestSiteButton Create(MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption option)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Void RefreshTextState()
public System.Void set_Option(MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption value)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.RestSite.NRestSiteButton+<AnimateIn>d__21

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.RestSite.NRestSiteButton <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.RestSite.NRestSiteButton+<SelectOption>d__26

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.RestSite.NRestSiteButton <>4__this
private System.Object <>7__wrap2
private System.Int32 <>7__wrap3
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__2
private System.Boolean <success>5__2
public MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption option
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.RestSite.NRestSiteButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName RefreshTextState
public static readonly Godot.StringName Reload
public static readonly Godot.StringName UpdateShaderParam
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.RestSite.NRestSiteButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _currentTween
public static readonly Godot.StringName _executingOption
public static readonly Godot.StringName _hsv
public static readonly Godot.StringName _icon
public static readonly Godot.StringName _isUnclickable
public static readonly Godot.StringName _label
public static readonly Godot.StringName _labelPosition
public static readonly Godot.StringName _outline
public static readonly Godot.StringName _visuals
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.RestSite.NRestSiteButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.RestSite.NRestSiteCharacter

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private System.Int32 _characterIndex
private Godot.Control _controlRoot
private System.Threading.CancellationTokenSource _cts
private static readonly Godot.StringName _globalOffset
private MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption _hoveredRestSiteOption
private Godot.Control _leftThoughtAnchor
private static readonly Godot.Vector2 _multiplayerConfirmationFlipOffset
private static readonly Godot.Vector2 _multiplayerConfirmationOffset
private static readonly System.String _multiplayerConfirmationScenePath
private static readonly Godot.StringName _noise1Panning
private static readonly Godot.StringName _noise2Panning
private MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption _restSiteOptionInThoughtBubble
private Godot.Control _rightThoughtAnchor
private static readonly Godot.StringName _s
private Godot.Control _selectedOptionConfirmation
private MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption _selectingRestSiteOption
private MegaCrit.Sts2.Core.Nodes.Combat.NSelectionReticle _selectionReticle
private System.Threading.CancellationTokenSource _thoughtBubbleGoAwayCancellation
private MegaCrit.Sts2.Core.Nodes.Vfx.NThoughtBubbleVfx _thoughtBubbleVfx
private static readonly Godot.StringName _v
private Godot.Control <Hitbox>k__BackingField
private MegaCrit.Sts2.Core.Entities.Players.Player <Player>k__BackingField
Godot.Control Hitbox { public get; private set; }
MegaCrit.Sts2.Core.Entities.Players.Player Player { public get; private set; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task DoShake()
private [async] System.Threading.Tasks.Task RemoveThoughtBubbleAfterDelay()
private Godot.Control GetRestSiteOptionAnchor()
private System.Collections.Generic.IEnumerable<Godot.Node2D> GetChildSpineNodes()
private System.Void OnFocus()
private System.Void OnUnfocus()
private System.Void RandomizeFire(Godot.ShaderMaterial mat)
private System.Void RefreshThoughtBubbleVfx()
private System.Void set_Hitbox(Godot.Control value)
private System.Void set_Player(MegaCrit.Sts2.Core.Entities.Players.Player value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public Godot.Control get_Hitbox()
public MegaCrit.Sts2.Core.Entities.Players.Player get_Player()
public static MegaCrit.Sts2.Core.Nodes.RestSite.NRestSiteCharacter Create(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Int32 characterIndex)
public System.Void Deselect()
public System.Void FlipX()
public System.Void HideFlameGlow()
public System.Void SetSelectingRestSiteOption(MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption option)
public System.Void Shake()
public System.Void ShowHoveredRestSiteOption(MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption option)
public System.Void ShowSelectedRestSiteOption(MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption option)
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.RestSite.NRestSiteCharacter+<>c__DisplayClass31_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.Action<MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState> <>9__0
public System.String animName
public .ctor()
internal System.Void <_Ready>b__0(MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState animState)
```

## MegaCrit.Sts2.Core.Nodes.RestSite.NRestSiteCharacter+<DoShake>d__43

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.RestSite.NRestSiteCharacter <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
private Godot.Vector2 <originalPosition>5__3
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.ScreenPunchInstance <shake>5__2
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.RestSite.NRestSiteCharacter+<GetChildSpineNodes>d__46

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：`System.Collections.Generic.IEnumerable<Godot.Node2D>`, `System.Collections.IEnumerable`, `System.Collections.Generic.IEnumerator<Godot.Node2D>`, `System.Collections.IEnumerator`, `System.IDisposable`

```text
private System.Int32 <>1__state
private Godot.Node2D <>2__current
public MegaCrit.Sts2.Core.Nodes.RestSite.NRestSiteCharacter <>4__this
private System.Collections.Generic.IEnumerator<Godot.Node2D> <>7__wrap1
private System.Int32 <>l__initialThreadId
Godot.Node2D System.Collections.Generic.IEnumerator<Godot.Node2D>.Current { private virtual get; }
System.Object System.Collections.IEnumerator.Current { private virtual get; }
public .ctor(System.Int32 <>1__state)
private System.Void <>m__Finally1()
private virtual Godot.Node2D System.Collections.Generic.IEnumerator<Godot.Node2D>.get_Current()
private virtual System.Boolean MoveNext()
private virtual System.Collections.Generic.IEnumerator<Godot.Node2D> System.Collections.Generic.IEnumerable<Godot.Node2D>.GetEnumerator()
private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
private virtual System.Object System.Collections.IEnumerator.get_Current()
private virtual System.Void System.Collections.IEnumerator.Reset()
private virtual System.Void System.IDisposable.Dispose()
```

## MegaCrit.Sts2.Core.Nodes.RestSite.NRestSiteCharacter+<RemoveThoughtBubbleAfterDelay>d__45

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.RestSite.NRestSiteCharacter <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.RestSite.NRestSiteCharacter+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Deselect
public static readonly Godot.StringName FlipX
public static readonly Godot.StringName GetRestSiteOptionAnchor
public static readonly Godot.StringName HideFlameGlow
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName RandomizeFire
public static readonly Godot.StringName RefreshThoughtBubbleVfx
public static readonly Godot.StringName Shake
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.RestSite.NRestSiteCharacter+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _characterIndex
public static readonly Godot.StringName _controlRoot
public static readonly Godot.StringName _leftThoughtAnchor
public static readonly Godot.StringName _rightThoughtAnchor
public static readonly Godot.StringName _selectedOptionConfirmation
public static readonly Godot.StringName _selectionReticle
public static readonly Godot.StringName _thoughtBubbleVfx
public static readonly Godot.StringName Hitbox
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.RestSite.NRestSiteCharacter+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```
