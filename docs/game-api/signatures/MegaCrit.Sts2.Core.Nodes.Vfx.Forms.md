# MegaCrit.Sts2.Core.Nodes.Vfx.Forms

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NDemonFormVfx

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NFormVfx`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NParticlesContainer _effectTriggeredParticles
private static readonly System.String _scenePath
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
public static MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NDemonFormVfx Create(MegaCrit.Sts2.Core.Entities.Creatures.Creature target)
public virtual System.Void OnEffectTriggered()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NDemonFormVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NFormVfx+MethodName`。

接口：

```text
public static readonly Godot.StringName OnEffectTriggered
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NDemonFormVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NFormVfx+PropertyName`。

接口：

```text
public static readonly Godot.StringName _effectTriggeredParticles
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NDemonFormVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NFormVfx+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NEchoFormVfx

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NFormVfx`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NSpineSpriteBoneFollower _boneFollower
private System.String _defectBoneName
private Godot.Gradient _echoFormLinesSelfModulateGradient
private Godot.Node2D _echoLines
private Godot.Node2D _glow
private Godot.Gradient _glowSelfModulateGradient
private System.String _ironcladBoneName
private System.String _necrobinderBoneName
private System.String _regentBoneName
private static readonly System.String _scenePath
private System.String _silentBoneName
private Godot.GpuParticles2D _speckParticles
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NSpineSpriteCopier _spineCopier
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NValueRamp _valueRamp
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void UpdateModulates(System.Single progress)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SetSpineSprite(MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite spineSprite, Godot.Node2D sourceNode)
public static MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NEchoFormVfx Create(MegaCrit.Sts2.Core.Entities.Creatures.Creature target)
public virtual System.Void _Process(System.Double delta)
public virtual System.Void SetActive(System.Boolean isActive)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NEchoFormVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NFormVfx+MethodName`。

接口：

```text
public static readonly Godot.StringName _Process
public static readonly Godot.StringName SetActive
public static readonly Godot.StringName UpdateModulates
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NEchoFormVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NFormVfx+PropertyName`。

接口：

```text
public static readonly Godot.StringName _boneFollower
public static readonly Godot.StringName _defectBoneName
public static readonly Godot.StringName _echoFormLinesSelfModulateGradient
public static readonly Godot.StringName _echoLines
public static readonly Godot.StringName _glow
public static readonly Godot.StringName _glowSelfModulateGradient
public static readonly Godot.StringName _ironcladBoneName
public static readonly Godot.StringName _necrobinderBoneName
public static readonly Godot.StringName _regentBoneName
public static readonly Godot.StringName _silentBoneName
public static readonly Godot.StringName _speckParticles
public static readonly Godot.StringName _spineCopier
public static readonly Godot.StringName _valueRamp
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NEchoFormVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NFormVfx+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NFormVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
protected System.Boolean _isActive
protected MegaCrit.Sts2.Core.Entities.Players.Player _owner
protected System.String _testBoneName
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SetSpineSprite(MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite spineSprite, Godot.Node2D sourceNode)
public System.Void ForceSetSpineSprite(Godot.Node2D sourceNode)
public System.Void ForceTestBoneName(System.String testBoneName)
public virtual System.Void Initialize(MegaCrit.Sts2.Core.Entities.Players.Player owner)
public virtual System.Void OnEffectTriggered()
public virtual System.Void SetActive(System.Boolean isActive)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NFormVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName ForceSetSpineSprite
public static readonly Godot.StringName ForceTestBoneName
public static readonly Godot.StringName OnEffectTriggered
public static readonly Godot.StringName SetActive
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NFormVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _isActive
public static readonly Godot.StringName _testBoneName
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NFormVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NReaperFormVfx

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NFormVfx`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NSpineSpriteBoneFollower _boneFollower
private System.String _defectBoneName
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NParticlesContainer _effectTriggeredParticles
private System.String _ironcladBoneName
private System.String _necrobinderBoneName
private System.String _regentBoneName
private static readonly System.String _scenePath
private System.String _silentBoneName
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
protected virtual System.Void SetSpineSprite(MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite spineSprite, Godot.Node2D sourceNode)
public static MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NReaperFormVfx Create(MegaCrit.Sts2.Core.Entities.Creatures.Creature target)
public virtual System.Void OnEffectTriggered()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NReaperFormVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NFormVfx+MethodName`。

接口：

```text
public static readonly Godot.StringName OnEffectTriggered
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NReaperFormVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NFormVfx+PropertyName`。

接口：

```text
public static readonly Godot.StringName _boneFollower
public static readonly Godot.StringName _defectBoneName
public static readonly Godot.StringName _effectTriggeredParticles
public static readonly Godot.StringName _ironcladBoneName
public static readonly Godot.StringName _necrobinderBoneName
public static readonly Godot.StringName _regentBoneName
public static readonly Godot.StringName _silentBoneName
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NReaperFormVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NFormVfx+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NSerpentFormVfx

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NFormVfx`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NSpineSpriteBoneFollower _boneFollower
private System.String _defectBoneName
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NParticlesContainer _effectTriggeredParticles
private System.String _ironcladBoneName
private System.String _necrobinderBoneName
private System.String _regentBoneName
private static readonly System.String _scenePath
private System.String _silentBoneName
private Godot.Node2D _snakesContainer
private Godot.Gradient _snakesModulateGradient
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NValueRamp _valueRamp
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void UpdateSnakesContainerModulate(System.Single progress)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SetSpineSprite(MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite spineSprite, Godot.Node2D sourceNode)
public static MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NSerpentFormVfx Create(MegaCrit.Sts2.Core.Entities.Creatures.Creature target)
public virtual System.Void _Process(System.Double delta)
public virtual System.Void Initialize(MegaCrit.Sts2.Core.Entities.Players.Player owner)
public virtual System.Void OnEffectTriggered()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NSerpentFormVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NFormVfx+MethodName`。

接口：

```text
public static readonly Godot.StringName _Process
public static readonly Godot.StringName OnEffectTriggered
public static readonly Godot.StringName UpdateSnakesContainerModulate
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NSerpentFormVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NFormVfx+PropertyName`。

接口：

```text
public static readonly Godot.StringName _boneFollower
public static readonly Godot.StringName _defectBoneName
public static readonly Godot.StringName _effectTriggeredParticles
public static readonly Godot.StringName _ironcladBoneName
public static readonly Godot.StringName _necrobinderBoneName
public static readonly Godot.StringName _regentBoneName
public static readonly Godot.StringName _silentBoneName
public static readonly Godot.StringName _snakesContainer
public static readonly Godot.StringName _snakesModulateGradient
public static readonly Godot.StringName _valueRamp
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NSerpentFormVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NFormVfx+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NVoidFormVfx

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NFormVfx`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NSpineSpriteBoneFollower _boneFollower
private System.String _defectBoneName
private Godot.Node2D _glow
private Godot.Gradient _glowSelfModulateGradient
private System.String _ironcladBoneName
private System.String _necrobinderBoneName
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NParticlesContainer _powerActiveParticles
private System.String _regentBoneName
private static readonly System.String _scenePath
private System.String _silentBoneName
private Godot.Node2D[] _swords
private Godot.Vector2 _swordsScaleRange
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NValueRamp _valueRamp
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void UpdateVfx(System.Single progress)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SetSpineSprite(MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite spineSprite, Godot.Node2D sourceNode)
public static MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NVoidFormVfx Create(MegaCrit.Sts2.Core.Entities.Creatures.Creature target)
public virtual System.Void _Process(System.Double delta)
public virtual System.Void Initialize(MegaCrit.Sts2.Core.Entities.Players.Player owner)
public virtual System.Void SetActive(System.Boolean isActive)
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NVoidFormVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NFormVfx+MethodName`。

接口：

```text
public static readonly Godot.StringName _Process
public static readonly Godot.StringName SetActive
public static readonly Godot.StringName UpdateVfx
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NVoidFormVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NFormVfx+PropertyName`。

接口：

```text
public static readonly Godot.StringName _boneFollower
public static readonly Godot.StringName _defectBoneName
public static readonly Godot.StringName _glow
public static readonly Godot.StringName _glowSelfModulateGradient
public static readonly Godot.StringName _ironcladBoneName
public static readonly Godot.StringName _necrobinderBoneName
public static readonly Godot.StringName _powerActiveParticles
public static readonly Godot.StringName _regentBoneName
public static readonly Godot.StringName _silentBoneName
public static readonly Godot.StringName _swords
public static readonly Godot.StringName _swordsScaleRange
public static readonly Godot.StringName _valueRamp
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NVoidFormVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NFormVfx+SignalName`。

接口：

```text
public .ctor()
```
