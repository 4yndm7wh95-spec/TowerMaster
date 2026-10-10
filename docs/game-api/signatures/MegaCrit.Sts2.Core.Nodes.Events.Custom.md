# MegaCrit.Sts2.Core.Nodes.Events.Custom

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.Events.Custom.NFakeMerchant

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Events.ICustomEventNode`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private static const System.Single _animVariance = 0.5
private Godot.Control _characterContainer
private System.Threading.CancellationTokenSource _cts
private MegaCrit.Sts2.Core.Entities.Merchant.MerchantDialogueSet _dialogue
private MegaCrit.Sts2.Core.Models.Events.FakeMerchant _event
private Godot.Control _inputBlocker
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Players.Player> _players
private MegaCrit.Sts2.Core.Nodes.CommonUi.NProceedButton _proceedButton
private MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantInventory <Inventory>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Rooms.NMerchantButton <MerchantButton>k__BackingField
MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext CurrentScreenContext { public virtual get; }
Godot.Control DefaultFocusedControl { public virtual get; }
MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantInventory Inventory { public get; private set; }
MegaCrit.Sts2.Core.Nodes.Rooms.NMerchantButton MerchantButton { public get; private set; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task ShowWelcomeDialogue()
private System.Void <OpenInventory>b__29_0()
private System.Void AfterRoomIsLoaded()
private System.Void HideScreen(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OnActiveScreenUpdated()
private System.Void OnMerchantOpened(MegaCrit.Sts2.Core.Nodes.Rooms.NMerchantButton _)
private System.Void OpenInventory()
private System.Void set_Inventory(MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantInventory value)
private System.Void set_MerchantButton(MegaCrit.Sts2.Core.Nodes.Rooms.NMerchantButton value)
private System.Void ShowProceedButton()
private System.Void StartCharacterAnimation(MegaCrit.Sts2.Core.Nodes.Combat.NCreatureVisuals visuals)
private System.Void ToggleMerchantTrack()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public [async] System.Threading.Tasks.Task FoulPotionThrown()
public MegaCrit.Sts2.Core.Nodes.Rooms.NMerchantButton get_MerchantButton()
public MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantInventory get_Inventory()
public System.Void BlockInput()
public System.Void UnblockInput()
public virtual Godot.Control get_DefaultFocusedControl()
public virtual MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext get_CurrentScreenContext()
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
public virtual System.Void Initialize(MegaCrit.Sts2.Core.Models.EventModel eventModel)
```

## MegaCrit.Sts2.Core.Nodes.Events.Custom.NFakeMerchant+<FoulPotionThrown>d__22

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Events.Custom.NFakeMerchant <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Events.Custom.NFakeMerchant+<ShowWelcomeDialogue>d__25

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Events.Custom.NFakeMerchant <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private MegaCrit.Sts2.Core.Localization.LocString <line>5__2
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Events.Custom.NFakeMerchant+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AfterRoomIsLoaded
public static readonly Godot.StringName BlockInput
public static readonly Godot.StringName HideScreen
public static readonly Godot.StringName OnActiveScreenUpdated
public static readonly Godot.StringName OnMerchantOpened
public static readonly Godot.StringName OpenInventory
public static readonly Godot.StringName ShowProceedButton
public static readonly Godot.StringName StartCharacterAnimation
public static readonly Godot.StringName ToggleMerchantTrack
public static readonly Godot.StringName UnblockInput
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Events.Custom.NFakeMerchant+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _characterContainer
public static readonly Godot.StringName _inputBlocker
public static readonly Godot.StringName _proceedButton
public static readonly Godot.StringName DefaultFocusedControl
public static readonly Godot.StringName Inventory
public static readonly Godot.StringName MerchantButton
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Events.Custom.NFakeMerchant+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```
