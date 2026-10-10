# MegaCrit.Sts2.Core.Nodes.Screens.Shops

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NFakeMerchantInventory

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantInventory`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void UpdateNavigation()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NFakeMerchantInventory+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Screens.Shops.NFakeMerchantInventory+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot, System.Boolean> <>9__0_0
public static System.Func<MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot, System.Boolean> <>9__0_1
public static System.Func<MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot, System.Boolean> <>9__0_2
public static System.Func<System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot>, System.Boolean> <>9__0_3
private static .cctor()
public .ctor()
internal System.Boolean <UpdateNavigation>b__0_0(MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot r)
internal System.Boolean <UpdateNavigation>b__0_1(MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot r)
internal System.Boolean <UpdateNavigation>b__0_2(MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot r)
internal System.Boolean <UpdateNavigation>b__0_3(System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot> r)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NFakeMerchantInventory+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantInventory+MethodName`。

接口：

```text
public static readonly Godot.StringName UpdateNavigation
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NFakeMerchantInventory+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantInventory+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NFakeMerchantInventory+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantInventory+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantCard

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Entities.Merchant.MerchantCardEntry _cardEntry
private Godot.Control _cardHolder
private MegaCrit.Sts2.Core.Nodes.Cards.NCard _cardNode
private Godot.Tween _hoverTween
private Godot.Node2D _saleVisual
MegaCrit.Sts2.Core.Entities.Merchant.MerchantEntry Entry { public virtual get; }
System.Boolean IsShowingUpgradedCard { public get; }
Godot.CanvasItem Visual { protected virtual get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task DoRelicFlash()
protected System.Void OnSuccessfulPurchase(MegaCrit.Sts2.Core.Entities.Merchant.PurchaseStatus _, MegaCrit.Sts2.Core.Entities.Merchant.MerchantEntry __)
protected virtual [async] System.Threading.Tasks.Task OnTryPurchase(MegaCrit.Sts2.Core.Entities.Merchant.MerchantInventory inventory)
protected virtual Godot.CanvasItem get_Visual()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void CreateHoverTip()
protected virtual System.Void OnPreview()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void UpdateVisual()
public System.Boolean get_IsShowingUpgradedCard()
public System.Void FillSlot(MegaCrit.Sts2.Core.Entities.Merchant.MerchantCardEntry cardEntry)
public System.Void OnInventoryOpened()
public virtual MegaCrit.Sts2.Core.Entities.Merchant.MerchantEntry get_Entry()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantCard+<DoRelicFlash>d__15

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantCard <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantCard+<OnTryPurchase>d__16

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantCard <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
public MegaCrit.Sts2.Core.Entities.Merchant.MerchantInventory inventory
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantCard+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName CreateHoverTip
public static readonly Godot.StringName OnInventoryOpened
public static readonly Godot.StringName OnPreview
public static readonly Godot.StringName UpdateVisual
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantCard+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot+PropertyName`。

接口：

```text
public static readonly Godot.StringName _cardHolder
public static readonly Godot.StringName _cardNode
public static readonly Godot.StringName _hoverTween
public static readonly Godot.StringName _saleVisual
public static readonly Godot.StringName IsShowingUpgradedCard
public static readonly Godot.StringName Visual
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantCard+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantCardRemoval

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot`。

接口：`System.IDisposable`

```text
private Godot.AnimationPlayer _animator
private Godot.Control _costContainer
private System.Boolean _isUnavailable
private static const System.String _locTable = "merchant_room"
private MegaCrit.Sts2.Core.Entities.Merchant.MerchantCardRemovalEntry _removalEntry
private Godot.Sprite2D _removalVisual
MegaCrit.Sts2.Core.Localization.LocString Description { private get; }
MegaCrit.Sts2.Core.Entities.Merchant.MerchantEntry Entry { public virtual get; }
MegaCrit.Sts2.Core.Localization.LocString Title { private get; }
Godot.CanvasItem Visual { protected virtual get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private MegaCrit.Sts2.Core.Localization.LocString get_Description()
private MegaCrit.Sts2.Core.Localization.LocString get_Title()
protected System.Void OnSuccessfulPurchase(MegaCrit.Sts2.Core.Entities.Merchant.PurchaseStatus _, MegaCrit.Sts2.Core.Entities.Merchant.MerchantEntry __)
protected virtual [async] System.Threading.Tasks.Task OnTryPurchase(MegaCrit.Sts2.Core.Entities.Merchant.MerchantInventory inventory)
protected virtual Godot.CanvasItem get_Visual()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void CreateHoverTip()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void UpdateVisual()
public System.Void FillSlot(MegaCrit.Sts2.Core.Entities.Merchant.MerchantCardRemovalEntry removalEntry)
public System.Void OnCardRemovalUsed()
public virtual MegaCrit.Sts2.Core.Entities.Merchant.MerchantEntry get_Entry()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantCardRemoval+<OnTryPurchase>d__17

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantCardRemoval <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
public MegaCrit.Sts2.Core.Entities.Merchant.MerchantInventory inventory
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantCardRemoval+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName CreateHoverTip
public static readonly Godot.StringName OnCardRemovalUsed
public static readonly Godot.StringName UpdateVisual
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantCardRemoval+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot+PropertyName`。

接口：

```text
public static readonly Godot.StringName _animator
public static readonly Godot.StringName _costContainer
public static readonly Godot.StringName _isUnavailable
public static readonly Godot.StringName _removalVisual
public static readonly Godot.StringName Visual
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantCardRemoval+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantCharacter

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
private System.Void <_Ready>b__0_0(MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState _)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void PlayAnimation(System.String anim, System.Boolean loop = False)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantCharacter+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName PlayAnimation
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantCharacter+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantCharacter+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantDialogue

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private Godot.Sprite2D _bubble
private Godot.Node2D _dialogueBox
private MegaCrit.Sts2.Core.Entities.Merchant.MerchantDialogueSet _dialogueSet
private static readonly Godot.StringName _h
private Godot.ShaderMaterial _hsv
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _label
private static readonly Godot.StringName _s
private Godot.Tween _tween
private static readonly Godot.StringName _v
private static readonly Godot.Vector2 _xRange
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void ShowRandom(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Localization.LocString> lines)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void Initialize(MegaCrit.Sts2.Core.Entities.Merchant.MerchantDialogueSet dialogueSet)
public System.Void ShowForPurchaseAttempt(MegaCrit.Sts2.Core.Entities.Merchant.PurchaseStatus status)
public System.Void ShowOnInventoryOpen()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantDialogue+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName ShowForPurchaseAttempt
public static readonly Godot.StringName ShowOnInventoryOpen
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantDialogue+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _bubble
public static readonly Godot.StringName _dialogueBox
public static readonly Godot.StringName _hsv
public static readonly Godot.StringName _label
public static readonly Godot.StringName _tween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantDialogue+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantHand

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _animController
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaBone _bone
private Godot.FastNoiseLite _noise
private Godot.Node2D _parent
private Godot.Control _rug
private Godot.Vector2 _startPos
private System.Threading.CancellationTokenSource _stopPointingToken
private Godot.Control _targetNode
private Godot.Vector2 _targetOffset
private Godot.Vector2 _targetPos
private System.Single _time
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task WaitAndReturn(System.Threading.CancellationTokenSource cancelToken, System.Single lingerTime)
private System.Void <_Ready>b__11_0(MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState animState)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void PointAtTarget(Godot.Control target, Godot.Vector2 offset)
public System.Void StopPointing(System.Single lingerTime)
public virtual System.Void _ExitTree()
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantHand+<WaitAndReturn>d__16

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantHand <>4__this
private System.Single <>7__wrap1
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
public System.Threading.CancellationTokenSource cancelToken
public System.Single lingerTime
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantHand+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName PointAtTarget
public static readonly Godot.StringName StopPointing
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantHand+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _noise
public static readonly Godot.StringName _parent
public static readonly Godot.StringName _rug
public static readonly Godot.StringName _startPos
public static readonly Godot.StringName _targetNode
public static readonly Godot.StringName _targetOffset
public static readonly Godot.StringName _targetPos
public static readonly Godot.StringName _time
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantHand+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantInventory

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private MegaCrit.Sts2.Core.Nodes.CommonUi.NBackButton _backButton
private Godot.ColorRect _backstop
private MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantCardRemoval _cardRemovalNode
private Godot.Control _characterCardContainer
private static const System.Single _closedPosition = -1000
private Godot.Control _colorlessCardContainer
private Godot.Control _inputBlocker
private Godot.Tween _inventoryTween
private System.Boolean _isInputBlocked
private MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot _lastSlot
private MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantDialogue _merchantDialogue
private static const System.Single _openPosition = 80
private Godot.Control _potionContainer
protected Godot.Control _relicContainer
private Godot.Control _slotsContainer
private MegaCrit.Sts2.Core.Entities.Merchant.MerchantInventory <Inventory>k__BackingField
private System.Boolean <IsOpen>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantHand <MerchantHand>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantInventory+InventoryClosedEventHandler backing_InventoryClosed
Godot.Control DefaultFocusedControl { public virtual get; }
MegaCrit.Sts2.Core.Entities.Merchant.MerchantInventory Inventory { public get; private set; }
System.Boolean IsOpen { public get; private set; }
MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantHand MerchantHand { public get; private set; }
event MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantInventory+InventoryClosedEventHandler InventoryClosed
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotSignalList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task DoOpenAnimation()
private Godot.Control GetClosestStockedSlot(System.Int32 idx, System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot> row)
private System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantCard> GetCardSlots()
private System.Void <_Ready>b__28_0(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void Close()
private System.Void OnActiveScreenUpdated()
private System.Void OnPurchaseCompleted(MegaCrit.Sts2.Core.Entities.Merchant.PurchaseStatus status, MegaCrit.Sts2.Core.Entities.Merchant.MerchantEntry entry)
private System.Void set_Inventory(MegaCrit.Sts2.Core.Entities.Merchant.MerchantInventory value)
private System.Void set_IsOpen(System.Boolean value)
private System.Void set_MerchantHand(MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantHand value)
private System.Void SubscribeToEntries()
private System.Void UpdateHorizontalNavigation()
private System.Void UpdateVerticalNavigation()
protected System.Void EmitSignalInventoryClosed()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean HasGodotClassSignal(in Godot.NativeInterop.godot_string_name signal)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RaiseGodotClassSignalCallbacks(in Godot.NativeInterop.godot_string_name signal, Godot.NativeInterop.NativeVariantPtrArgs args)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void UpdateNavigation()
public MegaCrit.Sts2.Core.Entities.Merchant.MerchantInventory get_Inventory()
public MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantHand get_MerchantHand()
public System.Boolean get_IsOpen()
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot> GetAllSlots()
public System.Void add_InventoryClosed(MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantInventory+InventoryClosedEventHandler value)
public System.Void BlockInput()
public System.Void Initialize(MegaCrit.Sts2.Core.Entities.Merchant.MerchantInventory inventory, MegaCrit.Sts2.Core.Entities.Merchant.MerchantDialogueSet dialogue)
public System.Void OnCardRemovalUsed()
public System.Void Open()
public System.Void remove_InventoryClosed(MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantInventory+InventoryClosedEventHandler value)
public System.Void UnblockInput()
public virtual Godot.Control get_DefaultFocusedControl()
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantInventory+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantInventory+<>c <>9
public static System.Func<System.Collections.Generic.IEnumerable<Godot.Node>, System.Collections.Generic.IEnumerable<Godot.Node>> <>9__39_0
public static System.Func<MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot, System.Boolean> <>9__41_0
public static System.Func<MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot, System.Boolean> <>9__41_1
public static System.Func<MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot, System.Boolean> <>9__41_2
public static System.Func<MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot, System.Boolean> <>9__41_3
public static System.Func<MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot, System.Boolean> <>9__48_0
private static .cctor()
public .ctor()
internal System.Boolean <get_DefaultFocusedControl>b__48_0(MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot s)
internal System.Boolean <UpdateHorizontalNavigation>b__41_0(MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot c)
internal System.Boolean <UpdateHorizontalNavigation>b__41_1(MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot c)
internal System.Boolean <UpdateHorizontalNavigation>b__41_2(MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot c)
internal System.Boolean <UpdateHorizontalNavigation>b__41_3(MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot c)
internal System.Collections.Generic.IEnumerable<Godot.Node> <GetCardSlots>b__39_0(System.Collections.Generic.IEnumerable<Godot.Node> n)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantInventory+<>c__DisplayClass31_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantInventory <>4__this
public MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot slot
public .ctor()
internal System.Void <Initialize>b__0()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantInventory+<>c__DisplayClass36_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Entities.Merchant.MerchantEntry entry
public MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot lastSlot
public .ctor()
internal System.Boolean <OnPurchaseCompleted>b__0(MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot s)
internal System.Boolean <OnPurchaseCompleted>b__1(MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot s)
internal System.Single <OnPurchaseCompleted>b__2(MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot s)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantInventory+<DoOpenAnimation>d__34

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantInventory <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantInventory+InventoryClosedEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantInventory+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName BlockInput
public static readonly Godot.StringName Close
public static readonly Godot.StringName OnActiveScreenUpdated
public static readonly Godot.StringName OnCardRemovalUsed
public static readonly Godot.StringName Open
public static readonly Godot.StringName SubscribeToEntries
public static readonly Godot.StringName UnblockInput
public static readonly Godot.StringName UpdateHorizontalNavigation
public static readonly Godot.StringName UpdateNavigation
public static readonly Godot.StringName UpdateVerticalNavigation
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantInventory+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _backButton
public static readonly Godot.StringName _backstop
public static readonly Godot.StringName _cardRemovalNode
public static readonly Godot.StringName _characterCardContainer
public static readonly Godot.StringName _colorlessCardContainer
public static readonly Godot.StringName _inputBlocker
public static readonly Godot.StringName _inventoryTween
public static readonly Godot.StringName _isInputBlocked
public static readonly Godot.StringName _lastSlot
public static readonly Godot.StringName _merchantDialogue
public static readonly Godot.StringName _potionContainer
public static readonly Godot.StringName _relicContainer
public static readonly Godot.StringName _slotsContainer
public static readonly Godot.StringName DefaultFocusedControl
public static readonly Godot.StringName IsOpen
public static readonly Godot.StringName MerchantHand
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantInventory+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public static readonly Godot.StringName InventoryClosed
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantPotion

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Models.PotionModel _potion
private MegaCrit.Sts2.Core.Entities.Merchant.MerchantPotionEntry _potionEntry
private Godot.Control _potionHolder
private MegaCrit.Sts2.Core.Nodes.Potions.NPotion _potionNode
private Godot.Vector2 _potionNodePosition
MegaCrit.Sts2.Core.Entities.Merchant.MerchantEntry Entry { public virtual get; }
Godot.CanvasItem Visual { protected virtual get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected System.Void OnSuccessfulPurchase(MegaCrit.Sts2.Core.Entities.Merchant.PurchaseStatus _, MegaCrit.Sts2.Core.Entities.Merchant.MerchantEntry __)
protected virtual [async] System.Threading.Tasks.Task OnTryPurchase(MegaCrit.Sts2.Core.Entities.Merchant.MerchantInventory inventory)
protected virtual Godot.CanvasItem get_Visual()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void CreateHoverTip()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void UpdateVisual()
public System.Void FillSlot(MegaCrit.Sts2.Core.Entities.Merchant.MerchantPotionEntry potionEntry)
public virtual MegaCrit.Sts2.Core.Entities.Merchant.MerchantEntry get_Entry()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantPotion+<OnTryPurchase>d__12

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantPotion <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
public MegaCrit.Sts2.Core.Entities.Merchant.MerchantInventory inventory
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantPotion+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName CreateHoverTip
public static readonly Godot.StringName UpdateVisual
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantPotion+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot+PropertyName`。

接口：

```text
public static readonly Godot.StringName _potionHolder
public static readonly Godot.StringName _potionNode
public static readonly Godot.StringName _potionNodePosition
public static readonly Godot.StringName Visual
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantPotion+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantRelic

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Nodes.Relics.NRelic+IconSize _iconSize
private MegaCrit.Sts2.Core.Models.RelicModel _relic
private MegaCrit.Sts2.Core.Entities.Merchant.MerchantRelicEntry _relicEntry
private Godot.Control _relicHolder
private MegaCrit.Sts2.Core.Nodes.Relics.NRelic _relicNode
private Godot.Vector2 _relicNodePosition
MegaCrit.Sts2.Core.Entities.Merchant.MerchantEntry Entry { public virtual get; }
Godot.CanvasItem Visual { protected virtual get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnSuccessfulPurchase(MegaCrit.Sts2.Core.Entities.Merchant.PurchaseStatus _, MegaCrit.Sts2.Core.Entities.Merchant.MerchantEntry __)
protected virtual [async] System.Threading.Tasks.Task OnTryPurchase(MegaCrit.Sts2.Core.Entities.Merchant.MerchantInventory inventory)
protected virtual Godot.CanvasItem get_Visual()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void CreateHoverTip()
protected virtual System.Void OnPreview()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void UpdateVisual()
public System.Void FillSlot(MegaCrit.Sts2.Core.Entities.Merchant.MerchantRelicEntry relicEntry)
public virtual MegaCrit.Sts2.Core.Entities.Merchant.MerchantEntry get_Entry()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantRelic+<OnTryPurchase>d__13

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantRelic <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
public MegaCrit.Sts2.Core.Entities.Merchant.MerchantInventory inventory
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantRelic+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName CreateHoverTip
public static readonly Godot.StringName OnPreview
public static readonly Godot.StringName UpdateVisual
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantRelic+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot+PropertyName`。

接口：

```text
public static readonly Godot.StringName _iconSize
public static readonly Godot.StringName _relicHolder
public static readonly Godot.StringName _relicNode
public static readonly Godot.StringName _relicNodePosition
public static readonly Godot.StringName Visual
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantRelic+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot

类型属性：`Public, Abstract, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
protected MegaCrit.Sts2.addons.mega_text.MegaLabel _costLabel
protected MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl _hitbox
private static readonly Godot.Vector2 _hoverScale
private Godot.Tween _hoverTween
private System.Boolean _ignoreMouseRelease
private System.Boolean _isHovered
private MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantInventory _merchantRug
private System.Nullable<System.Single> _originalVisualPosition
private Godot.Tween _purchaseFailedTween
private static readonly Godot.Vector2 _smallScale
private MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot+HoveredEventHandler backing_Hovered
private MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot+UnhoveredEventHandler backing_Unhovered
MegaCrit.Sts2.Core.Entities.Merchant.MerchantEntry Entry { public abstract get; }
MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl Hitbox { public get; }
MegaCrit.Sts2.Core.Entities.Players.Player Player { protected get; }
Godot.CanvasItem Visual { protected abstract get; }
event MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot+HoveredEventHandler Hovered
event MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot+UnhoveredEventHandler Unhovered
private static .cctor()
protected .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotSignalList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task OnSelected()
private System.Void OnFocus()
private System.Void OnMerchantHandHovered(MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot _)
private System.Void OnMerchantHandUnhovered(MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot _)
private System.Void OnMousePressed(Godot.InputEvent inputEvent)
private System.Void OnMouseReleased(Godot.InputEvent inputEvent)
private System.Void OnUnfocus()
private System.Void WiggleAnimation(System.Single progress)
protected abstract Godot.CanvasItem get_Visual()
protected abstract System.Threading.Tasks.Task OnTryPurchase(MegaCrit.Sts2.Core.Entities.Merchant.MerchantInventory inventory)
protected abstract System.Void CreateHoverTip()
protected MegaCrit.Sts2.Core.Entities.Players.Player get_Player()
protected System.Void ClearHoverTip()
protected System.Void EmitSignalHovered(MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot slot)
protected System.Void EmitSignalUnhovered(MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot slot)
protected System.Void OnPurchaseFailed(MegaCrit.Sts2.Core.Entities.Merchant.PurchaseStatus status)
protected System.Void TriggerMerchantHandToPointHere()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean HasGodotClassSignal(in Godot.NativeInterop.godot_string_name signal)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void ConnectSignals()
protected virtual System.Void OnPreview()
protected virtual System.Void RaiseGodotClassSignalCallbacks(in Godot.NativeInterop.godot_string_name signal, Godot.NativeInterop.NativeVariantPtrArgs args)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void UpdateVisual()
public abstract MegaCrit.Sts2.Core.Entities.Merchant.MerchantEntry get_Entry()
public MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl get_Hitbox()
public System.Void add_Hovered(MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot+HoveredEventHandler value)
public System.Void add_Unhovered(MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot+UnhoveredEventHandler value)
public System.Void Initialize(MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantInventory rug)
public System.Void remove_Hovered(MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot+HoveredEventHandler value)
public System.Void remove_Unhovered(MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot+UnhoveredEventHandler value)
public virtual System.Void _ExitTree()
public virtual System.Void _GuiInput(Godot.InputEvent inputEvent)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot+<OnSelected>d__29

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot+HoveredEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot slot, System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke(MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot slot)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _GuiInput
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName ClearHoverTip
public static readonly Godot.StringName ConnectSignals
public static readonly Godot.StringName CreateHoverTip
public static readonly Godot.StringName Initialize
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnMerchantHandHovered
public static readonly Godot.StringName OnMerchantHandUnhovered
public static readonly Godot.StringName OnMousePressed
public static readonly Godot.StringName OnMouseReleased
public static readonly Godot.StringName OnPreview
public static readonly Godot.StringName OnPurchaseFailed
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName TriggerMerchantHandToPointHere
public static readonly Godot.StringName UpdateVisual
public static readonly Godot.StringName WiggleAnimation
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _costLabel
public static readonly Godot.StringName _hitbox
public static readonly Godot.StringName _hoverTween
public static readonly Godot.StringName _ignoreMouseRelease
public static readonly Godot.StringName _isHovered
public static readonly Godot.StringName _merchantRug
public static readonly Godot.StringName _purchaseFailedTween
public static readonly Godot.StringName Hitbox
public static readonly Godot.StringName Visual
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public static readonly Godot.StringName Hovered
public static readonly Godot.StringName Unhovered
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot+UnhoveredEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot slot, System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke(MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot slot)
```
