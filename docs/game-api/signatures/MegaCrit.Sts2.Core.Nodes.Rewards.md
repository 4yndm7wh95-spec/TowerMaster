# MegaCrit.Sts2.Core.Nodes.Rewards

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.Rewards.NLinkedRewardSet

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private Godot.Control _chainsContainer
private Godot.Control _rewardContainer
private MegaCrit.Sts2.Core.Nodes.Screens.NRewardsScreen _rewardsScreen
private MegaCrit.Sts2.Core.Rewards.LinkedRewardSet <LinkedRewardSet>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Rewards.NLinkedRewardSet+RewardClaimedEventHandler backing_RewardClaimed
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
System.String ChainImagePath { private static get; }
MegaCrit.Sts2.Core.Rewards.LinkedRewardSet LinkedRewardSet { public get; private set; }
System.String ScenePath { private static get; }
event MegaCrit.Sts2.Core.Nodes.Rewards.NLinkedRewardSet+RewardClaimedEventHandler RewardClaimed
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotSignalList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private static System.String get_ChainImagePath()
private static System.String get_ScenePath()
private System.Void GetReward()
private System.Void Reload()
private System.Void set_LinkedRewardSet(MegaCrit.Sts2.Core.Rewards.LinkedRewardSet value)
private System.Void SetReward(MegaCrit.Sts2.Core.Rewards.LinkedRewardSet linkedReward)
protected System.Void EmitSignalRewardClaimed(MegaCrit.Sts2.Core.Nodes.Rewards.NLinkedRewardSet linkedRewardSet)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean HasGodotClassSignal(in Godot.NativeInterop.godot_string_name signal)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RaiseGodotClassSignalCallbacks(in Godot.NativeInterop.godot_string_name signal, Godot.NativeInterop.NativeVariantPtrArgs args)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public MegaCrit.Sts2.Core.Rewards.LinkedRewardSet get_LinkedRewardSet()
public static MegaCrit.Sts2.Core.Nodes.Rewards.NLinkedRewardSet Create(MegaCrit.Sts2.Core.Rewards.LinkedRewardSet linkedReward, MegaCrit.Sts2.Core.Nodes.Screens.NRewardsScreen screen)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Void add_RewardClaimed(MegaCrit.Sts2.Core.Nodes.Rewards.NLinkedRewardSet+RewardClaimedEventHandler value)
public System.Void remove_RewardClaimed(MegaCrit.Sts2.Core.Nodes.Rewards.NLinkedRewardSet+RewardClaimedEventHandler value)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Rewards.NLinkedRewardSet+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName GetReward
public static readonly Godot.StringName Reload
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Rewards.NLinkedRewardSet+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _chainsContainer
public static readonly Godot.StringName _rewardContainer
public static readonly Godot.StringName _rewardsScreen
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Rewards.NLinkedRewardSet+RewardClaimedEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(MegaCrit.Sts2.Core.Nodes.Rewards.NLinkedRewardSet linkedRewardSet, System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke(MegaCrit.Sts2.Core.Nodes.Rewards.NLinkedRewardSet linkedRewardSet)
```

## MegaCrit.Sts2.Core.Nodes.Rewards.NLinkedRewardSet+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public static readonly Godot.StringName RewardClaimed
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Rewards.NRewardButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private Godot.TextureRect _background
private Godot.Tween _currentTween
private static readonly Godot.StringName _defaultColor
private static readonly Godot.StringName _fontOutlineColor
private Godot.ShaderMaterial _hsv
private Godot.Variant _hsvDefault
private Godot.Variant _hsvDown
private Godot.Variant _hsvHover
private Godot.Control _iconContainer
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _label
private MegaCrit.Sts2.Core.Nodes.Combat.NSelectionReticle _reticle
private static readonly Godot.StringName _v
private MegaCrit.Sts2.Core.Rewards.Reward <Reward>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Rewards.NRewardButton+RewardClaimedEventHandler backing_RewardClaimed
private MegaCrit.Sts2.Core.Nodes.Rewards.NRewardButton+RewardSkippedEventHandler backing_RewardSkipped
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
MegaCrit.Sts2.Core.Rewards.Reward Reward { public get; private set; }
System.String ScenePath { private static get; }
event MegaCrit.Sts2.Core.Nodes.Rewards.NRewardButton+RewardClaimedEventHandler RewardClaimed
event MegaCrit.Sts2.Core.Nodes.Rewards.NRewardButton+RewardSkippedEventHandler RewardSkipped
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotSignalList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task GetReward()
private static System.String get_ScenePath()
private System.Void Reload()
private System.Void set_Reward(MegaCrit.Sts2.Core.Rewards.Reward value)
private System.Void SetReward(MegaCrit.Sts2.Core.Rewards.Reward reward)
private System.Void UpdateShaderParam(System.Single value)
protected System.Void EmitSignalRewardClaimed(MegaCrit.Sts2.Core.Nodes.Rewards.NRewardButton button)
protected System.Void EmitSignalRewardSkipped(MegaCrit.Sts2.Core.Nodes.Rewards.NRewardButton button)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean HasGodotClassSignal(in Godot.NativeInterop.godot_string_name signal)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnFocus()
protected virtual System.Void OnPress()
protected virtual System.Void OnRelease()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RaiseGodotClassSignalCallbacks(in Godot.NativeInterop.godot_string_name signal, Godot.NativeInterop.NativeVariantPtrArgs args)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public MegaCrit.Sts2.Core.Rewards.Reward get_Reward()
public static MegaCrit.Sts2.Core.Nodes.Rewards.NRewardButton Create(MegaCrit.Sts2.Core.Rewards.Reward reward, MegaCrit.Sts2.Core.Nodes.Screens.NRewardsScreen screen)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Void add_RewardClaimed(MegaCrit.Sts2.Core.Nodes.Rewards.NRewardButton+RewardClaimedEventHandler value)
public System.Void add_RewardSkipped(MegaCrit.Sts2.Core.Nodes.Rewards.NRewardButton+RewardSkippedEventHandler value)
public System.Void remove_RewardClaimed(MegaCrit.Sts2.Core.Nodes.Rewards.NRewardButton+RewardClaimedEventHandler value)
public System.Void remove_RewardSkipped(MegaCrit.Sts2.Core.Nodes.Rewards.NRewardButton+RewardSkippedEventHandler value)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Rewards.NRewardButton+<GetReward>d__26

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Rewards.NRewardButton <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Rewards.NRewardButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName Reload
public static readonly Godot.StringName UpdateShaderParam
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Rewards.NRewardButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _background
public static readonly Godot.StringName _currentTween
public static readonly Godot.StringName _hsv
public static readonly Godot.StringName _hsvDefault
public static readonly Godot.StringName _hsvDown
public static readonly Godot.StringName _hsvHover
public static readonly Godot.StringName _iconContainer
public static readonly Godot.StringName _label
public static readonly Godot.StringName _reticle
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Rewards.NRewardButton+RewardClaimedEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(MegaCrit.Sts2.Core.Nodes.Rewards.NRewardButton button, System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke(MegaCrit.Sts2.Core.Nodes.Rewards.NRewardButton button)
```

## MegaCrit.Sts2.Core.Nodes.Rewards.NRewardButton+RewardSkippedEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(MegaCrit.Sts2.Core.Nodes.Rewards.NRewardButton button, System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke(MegaCrit.Sts2.Core.Nodes.Rewards.NRewardButton button)
```

## MegaCrit.Sts2.Core.Nodes.Rewards.NRewardButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public static readonly Godot.StringName RewardClaimed
public static readonly Godot.StringName RewardSkipped
private static .cctor()
public .ctor()
```
