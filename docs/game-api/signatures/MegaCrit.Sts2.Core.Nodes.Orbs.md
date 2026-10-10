# MegaCrit.Sts2.Core.Nodes.Orbs

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.Orbs.NDarkOrbVfx

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Orbs.NOrbVfx`。

接口：`System.IDisposable`

```text
private Godot.Node2D _darkBg
private System.Single _darkBgNormalScale
private System.Single _darkBgSuperchargedScale
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NParticlesContainer _superchargedParticles
private System.Single _superchargeThreshold
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void UpdateDarkBgSize(System.Boolean isSupercharged)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnEvokeInternal(Godot.Vector2 targetVfxSpawnPosition)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void OnPassiveActivated(System.Decimal passiveVal, System.Decimal evokeVal)
```

## MegaCrit.Sts2.Core.Nodes.Orbs.NDarkOrbVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Orbs.NOrbVfx+MethodName`。

接口：

```text
public static readonly Godot.StringName OnEvokeInternal
public static readonly Godot.StringName UpdateDarkBgSize
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Orbs.NDarkOrbVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Orbs.NOrbVfx+PropertyName`。

接口：

```text
public static readonly Godot.StringName _darkBg
public static readonly Godot.StringName _darkBgNormalScale
public static readonly Godot.StringName _darkBgSuperchargedScale
public static readonly Godot.StringName _superchargedParticles
public static readonly Godot.StringName _superchargeThreshold
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Orbs.NDarkOrbVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Orbs.NOrbVfx+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Orbs.NFrostOrbVfx

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Orbs.NOrbVfx`。

接口：`System.IDisposable`

```text
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void OnEvokeInternal(Godot.Vector2 targetVfxSpawnPosition)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void OnPassiveActivated(System.Decimal passiveVal, System.Decimal evokeVal)
```

## MegaCrit.Sts2.Core.Nodes.Orbs.NFrostOrbVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Orbs.NOrbVfx+MethodName`。

接口：

```text
public static readonly Godot.StringName OnEvokeInternal
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Orbs.NFrostOrbVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Orbs.NOrbVfx+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Orbs.NFrostOrbVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Orbs.NOrbVfx+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Orbs.NGlassOrbVfx

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Orbs.NOrbVfx`。

接口：`System.IDisposable`

```text
private static readonly Godot.StringName _aberrationStrengthString
private System.Single _basePassiveChromaticAberrationStength
private System.Decimal _basePassiveVal
private Godot.GpuParticles2D _passiveChromaticAberration
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void ShowPassiveImpact(Godot.Vector2 targetVfxSpawnPosition)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasFocusPower()
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnEvokeInternal(Godot.Vector2 targetVfxSpawnPosition)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void ShowPassiveImpact(Godot.Vector2[] targetVfxSpawnPositions)
public virtual System.Void AfterPassiveActivated(System.Decimal passiveVal, System.Decimal evokeVal)
public virtual System.Void OnPassiveActivated(System.Decimal passiveVal, System.Decimal evokeVal)
```

## MegaCrit.Sts2.Core.Nodes.Orbs.NGlassOrbVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Orbs.NOrbVfx+MethodName`。

接口：

```text
public static readonly Godot.StringName HasFocusPower
public static readonly Godot.StringName OnEvokeInternal
public static readonly Godot.StringName ShowPassiveImpact
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Orbs.NGlassOrbVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Orbs.NOrbVfx+PropertyName`。

接口：

```text
public static readonly Godot.StringName _basePassiveChromaticAberrationStength
public static readonly Godot.StringName _passiveChromaticAberration
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Orbs.NGlassOrbVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Orbs.NOrbVfx+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Orbs.NLightningOrbVfx

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Orbs.NOrbVfx`。

接口：`System.IDisposable`

```text
public .ctor()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void OnPassiveActivated(System.Decimal passiveVal, System.Decimal evokeVal)
```

## MegaCrit.Sts2.Core.Nodes.Orbs.NLightningOrbVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Orbs.NOrbVfx+MethodName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Orbs.NLightningOrbVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Orbs.NOrbVfx+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Orbs.NLightningOrbVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Orbs.NOrbVfx+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Orbs.NOrb

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl`。

接口：`System.IDisposable`

```text
private Godot.Control _bounds
private Godot.Tween _curTween
private MegaCrit.Sts2.addons.mega_text.MegaLabel _evokeLabel
private System.Boolean _isLocal
private Godot.Control _labelContainer
private MegaCrit.Sts2.Core.Nodes.Orbs.NOrbVfx _orbVfx
private Godot.TextureRect _outline
private MegaCrit.Sts2.addons.mega_text.MegaLabel _passiveLabel
private MegaCrit.Sts2.Core.Nodes.Combat.NSelectionReticle _selectionReticle
private Godot.Node2D _sprite
private Godot.Control _visualContainer
private MegaCrit.Sts2.Core.Models.OrbModel <Model>k__BackingField
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
MegaCrit.Sts2.Core.Models.OrbModel Model { public get; private set; }
System.String ScenePath { private static get; }
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private static System.String get_ScenePath()
private System.Void set_Model(MegaCrit.Sts2.Core.Models.OrbModel value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnFocus()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public MegaCrit.Sts2.Core.Models.OrbModel get_Model()
public static MegaCrit.Sts2.Core.Nodes.Orbs.NOrb Create(System.Boolean isLocal, MegaCrit.Sts2.Core.Models.OrbModel model)
public static MegaCrit.Sts2.Core.Nodes.Orbs.NOrb Create(System.Boolean isLocal)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Void ReplaceOrb(MegaCrit.Sts2.Core.Models.OrbModel model)
public System.Void UpdateVisuals(System.Boolean isEvoking)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Orbs.NOrb+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Orbs.NOrb+<>c <>9
public static System.Action<MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState> <>9__23_0
private static .cctor()
public .ctor()
internal System.Void <UpdateVisuals>b__23_0(MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState animState)
```

## MegaCrit.Sts2.Core.Nodes.Orbs.NOrb+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName UpdateVisuals
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Orbs.NOrb+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+PropertyName`。

接口：

```text
public static readonly Godot.StringName _bounds
public static readonly Godot.StringName _curTween
public static readonly Godot.StringName _evokeLabel
public static readonly Godot.StringName _isLocal
public static readonly Godot.StringName _labelContainer
public static readonly Godot.StringName _orbVfx
public static readonly Godot.StringName _outline
public static readonly Godot.StringName _passiveLabel
public static readonly Godot.StringName _selectionReticle
public static readonly Godot.StringName _sprite
public static readonly Godot.StringName _visualContainer
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Orbs.NOrb+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Orbs.NOrbManager

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private static const System.Single _angleOffset = -25
private MegaCrit.Sts2.Core.Nodes.Combat.NCreature _creatureNode
private Godot.Tween _curTween
private static const System.Single _maxRadius = 300
private static const System.Single _minRadius = 225
private Godot.Control _orbContainer
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Orbs.NOrb> _orbs
private static const System.Single _range = 150
private static const System.Single _tweenSpeed = 0.45
private System.Boolean <IsLocal>k__BackingField
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
Godot.Control DefaultFocusOwner { public get; }
System.Boolean IsLocal { public get; private set; }
MegaCrit.Sts2.Core.Entities.Players.Player Player { private get; }
System.String ScenePath { private static get; }
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private MegaCrit.Sts2.Core.Entities.Players.Player get_Player()
private static System.String get_ScenePath()
private System.Void OnCombatSetup(MegaCrit.Sts2.Core.Combat.CombatState _)
private System.Void OnCombatStateChanged(MegaCrit.Sts2.Core.Combat.CombatState _)
private System.Void set_IsLocal(System.Boolean value)
private System.Void TweenLayout()
private System.Void UpdateControllerNavigation()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public Godot.Control get_DefaultFocusOwner()
public static MegaCrit.Sts2.Core.Nodes.Orbs.NOrbManager Create(MegaCrit.Sts2.Core.Nodes.Combat.NCreature creature, System.Boolean isLocal)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Boolean get_IsLocal()
public System.Void AddOrbAnim()
public System.Void AddSlotAnim(System.Int32 amount)
public System.Void ClearOrbs()
public System.Void EvokeOrbAnim(MegaCrit.Sts2.Core.Models.OrbModel orb)
public System.Void RemoveSlotAnim(System.Int32 amount)
public System.Void ReplaceOrb(MegaCrit.Sts2.Core.Models.OrbModel oldOrb, MegaCrit.Sts2.Core.Models.OrbModel newOrb)
public System.Void UpdateVisuals(MegaCrit.Sts2.Core.Entities.Cards.OrbEvokeType evokeType)
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Orbs.NOrbManager+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Orbs.NOrbManager+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Nodes.Orbs.NOrb, System.Boolean> <>9__27_0
public static System.Func<MegaCrit.Sts2.Core.Nodes.Orbs.NOrb, System.Boolean> <>9__27_1
public static System.Func<Godot.Node, System.Boolean> <>9__27_2
private static .cctor()
public .ctor()
internal System.Boolean <AddOrbAnim>b__27_0(MegaCrit.Sts2.Core.Nodes.Orbs.NOrb node)
internal System.Boolean <AddOrbAnim>b__27_1(MegaCrit.Sts2.Core.Nodes.Orbs.NOrb node)
internal System.Boolean <AddOrbAnim>b__27_2(Godot.Node node)
```

## MegaCrit.Sts2.Core.Nodes.Orbs.NOrbManager+<>c__DisplayClass28_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Models.OrbModel orb
public .ctor()
internal System.Boolean <EvokeOrbAnim>b__0(MegaCrit.Sts2.Core.Nodes.Orbs.NOrb node)
```

## MegaCrit.Sts2.Core.Nodes.Orbs.NOrbManager+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AddOrbAnim
public static readonly Godot.StringName AddSlotAnim
public static readonly Godot.StringName ClearOrbs
public static readonly Godot.StringName Create
public static readonly Godot.StringName RemoveSlotAnim
public static readonly Godot.StringName TweenLayout
public static readonly Godot.StringName UpdateControllerNavigation
public static readonly Godot.StringName UpdateVisuals
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Orbs.NOrbManager+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _creatureNode
public static readonly Godot.StringName _curTween
public static readonly Godot.StringName _orbContainer
public static readonly Godot.StringName DefaultFocusOwner
public static readonly Godot.StringName IsLocal
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Orbs.NOrbManager+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Orbs.NOrbVfx

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private System.String _evokeVfxSceneName
private static System.String _evokeVfxScenePath
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NParticlesContainer _focusedParticles
protected System.Boolean _forcedFocusPower
protected MegaCrit.Sts2.Core.Models.OrbModel _orbModel
private Godot.Control _overrideCombatVfxContainer
protected Godot.Node2D _overridePlayerNode
protected MegaCrit.Sts2.Core.Entities.Players.Player _owner
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NParticlesContainer _passiveActivatedFocusedParticles
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NParticlesContainer _passiveActivatedParticles
private Godot.Tween _shakeTween
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NShaker _spineShaker
Godot.Control VfxContainer { protected get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnEvoke(MegaCrit.Sts2.Core.Entities.Creatures.Creature[] targets)
private System.Void SpawnEvokeVfx()
protected Godot.Control get_VfxContainer()
protected Godot.Vector2 GetPlayerVfxPosition()
protected System.Void OnPowerApplied(MegaCrit.Sts2.Core.Models.PowerModel powerModel)
protected System.Void OnPowerDecreased(MegaCrit.Sts2.Core.Models.PowerModel powerModel, System.Boolean silent)
protected System.Void OnPowerIncreased(MegaCrit.Sts2.Core.Models.PowerModel powerModel, System.Int32 amount, System.Boolean silent)
protected System.Void ShakeOrb(System.Single initialStrength, System.Single duration)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasFocusPower()
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnEvokeInternal(Godot.Vector2 targetVfxSpawnPosition)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void UpdateFocusPowerState()
public System.Void Initialize(MegaCrit.Sts2.Core.Models.OrbModel orbModel)
public System.Void OnEvoke(Godot.Vector2[] targetVfxSpawnPositions)
public System.Void OnEvoke(MegaCrit.Sts2.Core.Nodes.Combat.NCreature[] targets)
public System.Void OnPassiveActivated()
public System.Void SetOverrideCombatVfxContainer(Godot.Control overrideCombatVfxContainer)
public System.Void SetOverridePlayerNode(Godot.Node2D overridePlayerNode)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
public virtual System.Void AfterPassiveActivated(System.Decimal passiveVal, System.Decimal evokeVal)
public virtual System.Void OnPassiveActivated(System.Decimal passiveVal, System.Decimal evokeVal)
public virtual System.Void SetForcedFocusPower(System.Boolean forcedFocusPower)
```

## MegaCrit.Sts2.Core.Nodes.Orbs.NOrbVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName GetPlayerVfxPosition
public static readonly Godot.StringName HasFocusPower
public static readonly Godot.StringName OnEvoke
public static readonly Godot.StringName OnEvokeInternal
public static readonly Godot.StringName OnPassiveActivated
public static readonly Godot.StringName SetForcedFocusPower
public static readonly Godot.StringName SetOverrideCombatVfxContainer
public static readonly Godot.StringName SetOverridePlayerNode
public static readonly Godot.StringName ShakeOrb
public static readonly Godot.StringName SpawnEvokeVfx
public static readonly Godot.StringName UpdateFocusPowerState
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Orbs.NOrbVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _evokeVfxSceneName
public static readonly Godot.StringName _focusedParticles
public static readonly Godot.StringName _forcedFocusPower
public static readonly Godot.StringName _overrideCombatVfxContainer
public static readonly Godot.StringName _overridePlayerNode
public static readonly Godot.StringName _passiveActivatedFocusedParticles
public static readonly Godot.StringName _passiveActivatedParticles
public static readonly Godot.StringName _shakeTween
public static readonly Godot.StringName _spineShaker
public static readonly Godot.StringName VfxContainer
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Orbs.NOrbVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Orbs.NPlasmaOrbVfx

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Orbs.NOrbVfx`。

接口：`System.IDisposable`

```text
private Godot.Vector2 _projectileOffsetRange
private System.Single _projectileSpawnInterval
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task SpawnProjectile(System.Int32 count, Godot.Vector2 targetPosition)
private Godot.Vector2 GetRandomOffset()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnEvokeInternal(Godot.Vector2 targetVfxSpawnPosition)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void OnPassiveActivated(System.Decimal passiveVal, System.Decimal evokeVal)
```

## MegaCrit.Sts2.Core.Nodes.Orbs.NPlasmaOrbVfx+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Orbs.NPlasmaOrbVfx+<>c <>9
public static System.Action <>9__4_0
private static .cctor()
public .ctor()
internal System.Void <SpawnProjectile>b__4_0()
```

## MegaCrit.Sts2.Core.Nodes.Orbs.NPlasmaOrbVfx+<SpawnProjectile>d__4

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Orbs.NPlasmaOrbVfx <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Int32 <i>5__2
public System.Int32 count
public Godot.Vector2 targetPosition
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Orbs.NPlasmaOrbVfx+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Orbs.NOrbVfx+MethodName`。

接口：

```text
public static readonly Godot.StringName GetRandomOffset
public static readonly Godot.StringName OnEvokeInternal
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Orbs.NPlasmaOrbVfx+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Orbs.NOrbVfx+PropertyName`。

接口：

```text
public static readonly Godot.StringName _projectileOffsetRange
public static readonly Godot.StringName _projectileSpawnInterval
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Orbs.NPlasmaOrbVfx+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Orbs.NOrbVfx+SignalName`。

接口：

```text
public .ctor()
```
