# MegaCrit.Sts2.Core.Nodes.Cards.Holders

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder

类型属性：`Public, Abstract, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private Godot.InputEventMouseButton _currentPressedAction
protected MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl _hitbox
protected Godot.Tween _hoverTween
protected System.Boolean _isClickable
protected System.Boolean _isFocused
protected System.Boolean _isHovered
private MegaCrit.Sts2.Core.Nodes.Cards.NCard <CardNode>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder+AltPressedEventHandler backing_AltPressed
private MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder+PressedEventHandler backing_Pressed
public static readonly Godot.Vector2 smallScale
System.Boolean CanBeFocused { protected get; }
MegaCrit.Sts2.Core.Models.CardModel CardModel { public virtual get; }
MegaCrit.Sts2.Core.Nodes.Cards.NCard CardNode { public get; protected set; }
MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl Hitbox { public get; }
Godot.Vector2 HoverScale { protected virtual get; }
System.Boolean IsShowingUpgradedCard { public virtual get; }
Godot.Vector2 SmallScale { public virtual get; }
event MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder+AltPressedEventHandler AltPressed
event MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder+PressedEventHandler Pressed
private static .cctor()
protected .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotSignalList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void <ConnectSignals>b__27_0(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl _)
private System.Void <ConnectSignals>b__27_1(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl _)
private System.Void EmitAltPressed()
private System.Void EmitPressed()
private System.Void OnChildExitingTree(Godot.Node node)
protected System.Boolean get_CanBeFocused()
protected System.Void ClearHoverTips()
protected System.Void ConnectSignals()
protected System.Void EmitSignalAltPressed(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder cardHolder)
protected System.Void EmitSignalPressed(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder cardHolder)
protected System.Void RefreshFocusState()
protected System.Void set_CardNode(MegaCrit.Sts2.Core.Nodes.Cards.NCard value)
protected virtual Godot.Vector2 get_HoverScale()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean HasGodotClassSignal(in Godot.NativeInterop.godot_string_name signal)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void CreateHoverTips()
protected virtual System.Void DoCardHoverEffects(System.Boolean isHovered)
protected virtual System.Void OnCardReassigned()
protected virtual System.Void OnFocus()
protected virtual System.Void OnMousePressed(Godot.InputEvent inputEvent)
protected virtual System.Void OnMouseReleased(Godot.InputEvent inputEvent)
protected virtual System.Void OnUnfocus()
protected virtual System.Void RaiseGodotClassSignalCallbacks(in Godot.NativeInterop.godot_string_name signal, Godot.NativeInterop.NativeVariantPtrArgs args)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SetCard(MegaCrit.Sts2.Core.Nodes.Cards.NCard node)
public MegaCrit.Sts2.Core.Nodes.Cards.NCard get_CardNode()
public MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl get_Hitbox()
public System.Void add_AltPressed(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder+AltPressedEventHandler value)
public System.Void add_Pressed(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder+PressedEventHandler value)
public System.Void ReassignToCard(MegaCrit.Sts2.Core.Models.CardModel cardModel, MegaCrit.Sts2.Core.Entities.Cards.PileType pileType, MegaCrit.Sts2.Core.Entities.Creatures.Creature target, MegaCrit.Sts2.Core.Entities.UI.ModelVisibility visibility)
public System.Void remove_AltPressed(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder+AltPressedEventHandler value)
public System.Void remove_Pressed(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder+PressedEventHandler value)
public System.Void SetClickable(System.Boolean isClickable)
public virtual Godot.Vector2 get_SmallScale()
public virtual MegaCrit.Sts2.Core.Models.CardModel get_CardModel()
public virtual System.Boolean get_IsShowingUpgradedCard()
public virtual System.Void _GuiInput(Godot.InputEvent inputEvent)
public virtual System.Void _Ready()
public virtual System.Void Clear()
```

## MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder+AltPressedEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder cardHolder, System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder cardHolder)
```

## MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _GuiInput
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Clear
public static readonly Godot.StringName ClearHoverTips
public static readonly Godot.StringName ConnectSignals
public static readonly Godot.StringName CreateHoverTips
public static readonly Godot.StringName DoCardHoverEffects
public static readonly Godot.StringName EmitAltPressed
public static readonly Godot.StringName EmitPressed
public static readonly Godot.StringName OnCardReassigned
public static readonly Godot.StringName OnChildExitingTree
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnMousePressed
public static readonly Godot.StringName OnMouseReleased
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName RefreshFocusState
public static readonly Godot.StringName SetCard
public static readonly Godot.StringName SetClickable
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder+PressedEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder cardHolder, System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder cardHolder)
```

## MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _currentPressedAction
public static readonly Godot.StringName _hitbox
public static readonly Godot.StringName _hoverTween
public static readonly Godot.StringName _isClickable
public static readonly Godot.StringName _isFocused
public static readonly Godot.StringName _isHovered
public static readonly Godot.StringName CanBeFocused
public static readonly Godot.StringName CardNode
public static readonly Godot.StringName Hitbox
public static readonly Godot.StringName HoverScale
public static readonly Godot.StringName IsShowingUpgradedCard
public static readonly Godot.StringName SmallScale
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public static readonly Godot.StringName AltPressed
public static readonly Godot.StringName Pressed
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolderHitbox

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
System.String ClickedSfx { protected virtual get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.String get_ClickedSfx()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolderHitbox+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolderHitbox+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName ClickedSfx
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolderHitbox+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Cards.Holders.NGridCardHolder

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Pooling.IPoolable`

```text
private MegaCrit.Sts2.Core.Models.CardModel _baseCard
private System.Boolean _isPreviewingUpgrade
private MegaCrit.Sts2.Core.Models.CardModel _upgradedCard
private MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardLibraryStats <CardLibraryStats>k__BackingField
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardLibraryStats CardLibraryStats { public get; private set; }
MegaCrit.Sts2.Core.Models.CardModel CardModel { public virtual get; }
System.Boolean IsShowingUpgradedCard { public virtual get; }
System.String ScenePath { private static get; }
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private static System.String get_ScenePath()
private System.Void set_CardLibraryStats(MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardLibraryStats value)
private System.Void UpdateCardModel()
private System.Void UpdateName()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnCardReassigned()
protected virtual System.Void OnFocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SetCard(MegaCrit.Sts2.Core.Nodes.Cards.NCard node)
public MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardLibraryStats get_CardLibraryStats()
public static MegaCrit.Sts2.Core.Nodes.Cards.Holders.NGridCardHolder Create(MegaCrit.Sts2.Core.Nodes.Cards.NCard cardNode)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public static System.Void InitPool()
public System.Void EnsureCardLibraryStatsExists()
public System.Void SetIsPreviewingUpgrade(System.Boolean showUpgradePreview)
public virtual MegaCrit.Sts2.Core.Models.CardModel get_CardModel()
public virtual System.Boolean get_IsShowingUpgradedCard()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
public virtual System.Void OnFreedToPool()
public virtual System.Void OnInstantiated()
public virtual System.Void OnReturnedFromPool()
```

## MegaCrit.Sts2.Core.Nodes.Cards.Holders.NGridCardHolder+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName EnsureCardLibraryStatsExists
public static readonly Godot.StringName InitPool
public static readonly Godot.StringName OnCardReassigned
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnFreedToPool
public static readonly Godot.StringName OnInstantiated
public static readonly Godot.StringName OnReturnedFromPool
public static readonly Godot.StringName SetCard
public static readonly Godot.StringName SetIsPreviewingUpgrade
public static readonly Godot.StringName UpdateCardModel
public static readonly Godot.StringName UpdateName
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Cards.Holders.NGridCardHolder+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder+PropertyName`。

接口：

```text
public static readonly Godot.StringName _isPreviewingUpgrade
public static readonly Godot.StringName CardLibraryStats
public static readonly Godot.StringName IsShowingUpgradedCard
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Cards.Holders.NGridCardHolder+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder`。

接口：`System.IDisposable`

```text
private System.Threading.CancellationTokenSource _angleCancelToken
private static const System.Single _angleSnapThreshold = 0.1
private Godot.Control _flash
private Godot.Tween _flashTween
private MegaCrit.Sts2.Core.Nodes.Combat.NPlayerHand _hand
private MegaCrit.Sts2.addons.mega_text.MegaLabel _handIndexLabel
private static const System.Single _moveSpeed = 7
private System.Threading.CancellationTokenSource _positionCancelToken
private static const System.Single _positionSnapThreshold = 1
private static const System.Single _reenableHitboxThreshold = 200
private static const System.Single _rotateSpeed = 10
private System.Threading.CancellationTokenSource _scaleCancelToken
private static const System.Single _scaleSnapThreshold = 0.002
private static const System.Single _scaleSpeed = 8
private System.Single _targetAngle
private Godot.Vector2 _targetPosition
private Godot.Vector2 _targetScale
private System.Boolean <InSelectMode>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder+HolderFocusedEventHandler backing_HolderFocused
private MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder+HolderMouseClickedEventHandler backing_HolderMouseClicked
private MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder+HolderUnfocusedEventHandler backing_HolderUnfocused
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
System.Boolean InSelectMode { public get; public set; }
System.String ScenePath { private static get; }
System.Boolean ShouldGlowGold { private get; }
System.Boolean ShouldGlowRed { private get; }
System.Single TargetAngle { public get; }
Godot.Vector2 TargetPosition { public get; }
event MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder+HolderFocusedEventHandler HolderFocused
event MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder+HolderMouseClickedEventHandler HolderMouseClicked
event MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder+HolderUnfocusedEventHandler HolderUnfocused
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotSignalList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task AnimAngle(System.Threading.CancellationTokenSource cancelToken)
private [async] System.Threading.Tasks.Task AnimPosition(System.Threading.CancellationTokenSource cancelToken)
private [async] System.Threading.Tasks.Task AnimScale(System.Threading.CancellationTokenSource cancelToken)
private static System.String get_ScenePath()
private System.Boolean get_ShouldGlowGold()
private System.Boolean get_ShouldGlowRed()
private System.Void OnModelChanged(MegaCrit.Sts2.Core.Models.CardModel oldModel)
private System.Void StopAnimations()
private System.Void SubscribeToEvents(MegaCrit.Sts2.Core.Models.CardModel card)
private System.Void UnsubscribeFromEvents(MegaCrit.Sts2.Core.Models.CardModel card)
protected System.Void EmitSignalHolderFocused(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder cardHolder)
protected System.Void EmitSignalHolderMouseClicked(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder cardHolder)
protected System.Void EmitSignalHolderUnfocused(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder cardHolder)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean HasGodotClassSignal(in Godot.NativeInterop.godot_string_name signal)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void DoCardHoverEffects(System.Boolean isHovered)
protected virtual System.Void OnFocus()
protected virtual System.Void OnMousePressed(Godot.InputEvent inputEvent)
protected virtual System.Void OnMouseReleased(Godot.InputEvent inputEvent)
protected virtual System.Void OnUnfocus()
protected virtual System.Void RaiseGodotClassSignalCallbacks(in Godot.NativeInterop.godot_string_name signal, Godot.NativeInterop.NativeVariantPtrArgs args)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SetCard(MegaCrit.Sts2.Core.Nodes.Cards.NCard node)
public Godot.Vector2 get_TargetPosition()
public static MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder Create(MegaCrit.Sts2.Core.Nodes.Cards.NCard card, MegaCrit.Sts2.Core.Nodes.Combat.NPlayerHand hand)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Boolean get_InSelectMode()
public System.Single get_TargetAngle()
public System.Void add_HolderFocused(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder+HolderFocusedEventHandler value)
public System.Void add_HolderMouseClicked(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder+HolderMouseClickedEventHandler value)
public System.Void add_HolderUnfocused(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder+HolderUnfocusedEventHandler value)
public System.Void BeginDrag()
public System.Void CancelDrag()
public System.Void Flash()
public System.Void remove_HolderFocused(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder+HolderFocusedEventHandler value)
public System.Void remove_HolderMouseClicked(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder+HolderMouseClickedEventHandler value)
public System.Void remove_HolderUnfocused(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder+HolderUnfocusedEventHandler value)
public System.Void set_InSelectMode(System.Boolean value)
public System.Void SetAngleInstantly(System.Single setAngle)
public System.Void SetDefaultTargets()
public System.Void SetIndexLabel(System.Int32 i)
public System.Void SetScaleInstantly(Godot.Vector2 setScale)
public System.Void SetTargetAngle(System.Single angle)
public System.Void SetTargetPosition(Godot.Vector2 position)
public System.Void SetTargetScale(Godot.Vector2 scale)
public System.Void UpdateCard()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
public virtual System.Void Clear()
```

## MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder+<AnimAngle>d__48

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public System.Threading.CancellationTokenSource cancelToken
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder+<AnimPosition>d__50

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public System.Threading.CancellationTokenSource cancelToken
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder+<AnimScale>d__49

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public System.Threading.CancellationTokenSource cancelToken
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder+HolderFocusedEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder cardHolder, System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder cardHolder)
```

## MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder+HolderMouseClickedEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder cardHolder, System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder cardHolder)
```

## MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder+HolderUnfocusedEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder cardHolder, System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder cardHolder)
```

## MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName BeginDrag
public static readonly Godot.StringName CancelDrag
public static readonly Godot.StringName Clear
public static readonly Godot.StringName Create
public static readonly Godot.StringName DoCardHoverEffects
public static readonly Godot.StringName Flash
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnMousePressed
public static readonly Godot.StringName OnMouseReleased
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName SetAngleInstantly
public static readonly Godot.StringName SetCard
public static readonly Godot.StringName SetDefaultTargets
public static readonly Godot.StringName SetIndexLabel
public static readonly Godot.StringName SetScaleInstantly
public static readonly Godot.StringName SetTargetAngle
public static readonly Godot.StringName SetTargetPosition
public static readonly Godot.StringName SetTargetScale
public static readonly Godot.StringName StopAnimations
public static readonly Godot.StringName UpdateCard
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder+PropertyName`。

接口：

```text
public static readonly Godot.StringName _flash
public static readonly Godot.StringName _flashTween
public static readonly Godot.StringName _hand
public static readonly Godot.StringName _handIndexLabel
public static readonly Godot.StringName _targetAngle
public static readonly Godot.StringName _targetPosition
public static readonly Godot.StringName _targetScale
public static readonly Godot.StringName InSelectMode
public static readonly Godot.StringName ShouldGlowGold
public static readonly Godot.StringName ShouldGlowRed
public static readonly Godot.StringName TargetAngle
public static readonly Godot.StringName TargetPosition
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder+SignalName`。

接口：

```text
public static readonly Godot.StringName HolderFocused
public static readonly Godot.StringName HolderMouseClicked
public static readonly Godot.StringName HolderUnfocused
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Cards.Holders.NPreviewCardHolder

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder`。

接口：`System.IDisposable`

```text
private Godot.Vector2 _originalScale
private System.Boolean _scaleOnHover
private System.Boolean _showHoverTips
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
Godot.Vector2 HoverScale { protected virtual get; }
System.Boolean IsShowingUpgradedCard { public virtual get; }
System.String ScenePath { private static get; }
Godot.Vector2 SmallScale { public virtual get; }
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private static System.String get_ScenePath()
private System.Void Initialize(MegaCrit.Sts2.Core.Nodes.Cards.NCard card, System.Boolean showHoverTips, System.Boolean scaleOnHover)
protected virtual Godot.Vector2 get_HoverScale()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void CreateHoverTips()
protected virtual System.Void OnFocus()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Cards.Holders.NPreviewCardHolder Create(MegaCrit.Sts2.Core.Nodes.Cards.NCard card, System.Boolean showHoverTips, System.Boolean scaleOnHover)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Void SetCardScale(Godot.Vector2 scale)
public virtual Godot.Vector2 get_SmallScale()
public virtual System.Boolean get_IsShowingUpgradedCard()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Cards.Holders.NPreviewCardHolder+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName CreateHoverTips
public static readonly Godot.StringName Initialize
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName SetCardScale
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Cards.Holders.NPreviewCardHolder+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder+PropertyName`。

接口：

```text
public static readonly Godot.StringName _originalScale
public static readonly Godot.StringName _scaleOnHover
public static readonly Godot.StringName _showHoverTips
public static readonly Godot.StringName HoverScale
public static readonly Godot.StringName IsShowingUpgradedCard
public static readonly Godot.StringName SmallScale
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Cards.Holders.NPreviewCardHolder+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Cards.Holders.NSelectedHandCardHolder

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder`。

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
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void CreateHoverTips()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Cards.Holders.NSelectedHandCardHolder Create(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder originalHolder)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Cards.Holders.NSelectedHandCardHolder+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName CreateHoverTips
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Cards.Holders.NSelectedHandCardHolder+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder+PropertyName`。

接口：

```text
public static readonly Godot.StringName _tween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Cards.Holders.NSelectedHandCardHolder+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder+SignalName`。

接口：

```text
public .ctor()
```
