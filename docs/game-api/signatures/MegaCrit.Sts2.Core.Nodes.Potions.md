# MegaCrit.Sts2.Core.Nodes.Potions

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.Potions.NPotion

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private Godot.Tween _bounceTween
private System.Threading.CancellationTokenSource _cancellationTokenSource
private Godot.Control _container
private MegaCrit.Sts2.Core.Models.PotionModel _model
private static const System.Single _newlyAcquiredFadeInDuration = 0.1
private static const System.Single _newlyAcquiredPopDistance = 40
private static const System.Single _newlyAcquiredPopDuration = 0.35
private Godot.Tween _obtainedTween
private Godot.TextureRect <Image>k__BackingField
private Godot.TextureRect <Outline>k__BackingField
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
Godot.TextureRect Image { public get; private set; }
MegaCrit.Sts2.Core.Models.PotionModel Model { public get; public set; }
Godot.TextureRect Outline { public get; private set; }
System.String ScenePath { private static get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private static System.String get_ScenePath()
private System.Void DoFlash()
private System.Void Reload()
private System.Void set_Image(Godot.TextureRect value)
private System.Void set_Outline(Godot.TextureRect value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public [async] System.Threading.Tasks.Task PlayNewlyAcquiredAnimation(System.Nullable<Godot.Vector2> startLocation)
public Godot.TextureRect get_Image()
public Godot.TextureRect get_Outline()
public MegaCrit.Sts2.Core.Models.PotionModel get_Model()
public static MegaCrit.Sts2.Core.Nodes.Potions.NPotion Create(MegaCrit.Sts2.Core.Models.PotionModel potion)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Void DoBounce()
public System.Void set_Model(MegaCrit.Sts2.Core.Models.PotionModel value)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Potions.NPotion+<PlayNewlyAcquiredAnimation>d__27

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Potions.NPotion <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__2
private System.Threading.CancellationTokenSource <cancelTokenSource>5__2
public System.Nullable<Godot.Vector2> startLocation
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Potions.NPotion+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName DoBounce
public static readonly Godot.StringName DoFlash
public static readonly Godot.StringName Reload
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Potions.NPotion+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _bounceTween
public static readonly Godot.StringName _container
public static readonly Godot.StringName _obtainedTween
public static readonly Godot.StringName Image
public static readonly Godot.StringName Outline
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Potions.NPotion+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Potions.NPotionContainer

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private System.Threading.CancellationTokenSource _cts
private MegaCrit.Sts2.Core.Nodes.Potions.NPotionHolder _focusedHolder
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Potions.NPotionHolder> _holders
private MegaCrit.Sts2.Core.Entities.Players.Player _player
private Godot.Control _potionErrorBg
private Godot.Vector2 _potionHolderInitPos
private Godot.Control _potionHolders
private Godot.Tween _potionsFullTween
private MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _potionShortcutButton
Godot.Control FirstPotionControl { public get; }
Godot.Control LastPotionControl { public get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task ShinePotions()
private System.Void <PlayAddFailedAnim>b__23_0(System.Single t)
private System.Void Add(MegaCrit.Sts2.Core.Models.PotionModel potion, System.Boolean isInitialization)
private System.Void ConnectPlayerEvents()
private System.Void Discard(MegaCrit.Sts2.Core.Models.PotionModel potion)
private System.Void DisconnectPlayerEvents()
private System.Void GrowPotionHolders(System.Int32 newMaxPotionSlots)
private System.Void OnCombatSetUp(MegaCrit.Sts2.Core.Combat.CombatState _)
private System.Void OnPotionHolderFocused(MegaCrit.Sts2.Core.Nodes.Potions.NPotionHolder holder)
private System.Void OnPotionHolderUnfocused(MegaCrit.Sts2.Core.Nodes.Potions.NPotionHolder holder)
private System.Void OnPotionProcured(MegaCrit.Sts2.Core.Models.PotionModel potion)
private System.Void OnPotionShortcutPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OnRelicsUpdated(MegaCrit.Sts2.Core.Models.RelicModel _)
private System.Void OnUsedPotionRemoved(MegaCrit.Sts2.Core.Models.PotionModel potion)
private System.Void PlayAddFailedAnim()
private System.Void PotionFtueCheck()
private System.Void RemoveUsed(MegaCrit.Sts2.Core.Models.PotionModel potion)
private System.Void UpdateNavigation()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public Godot.Control get_FirstPotionControl()
public Godot.Control get_LastPotionControl()
public System.Void AnimatePotion(MegaCrit.Sts2.Core.Models.PotionModel potion, System.Nullable<Godot.Vector2> startPosition = null)
public System.Void Initialize(MegaCrit.Sts2.Core.Runs.IRunState runState)
public System.Void OnPotionUseOrDiscardCanceled(MegaCrit.Sts2.Core.Models.PotionModel potion)
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Notification(System.Int32 what)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Potions.NPotionContainer+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Potions.NPotionContainer+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Nodes.Potions.NPotionHolder, System.Boolean> <>9__19_0
private static .cctor()
public .ctor()
internal System.Boolean <Add>b__19_0(MegaCrit.Sts2.Core.Nodes.Potions.NPotionHolder h)
```

## MegaCrit.Sts2.Core.Nodes.Potions.NPotionContainer+<>c__DisplayClass16_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Potions.NPotionContainer <>4__this
public MegaCrit.Sts2.Core.Nodes.Potions.NPotionHolder node
public .ctor()
internal System.Void <GrowPotionHolders>b__0()
internal System.Void <GrowPotionHolders>b__1()
internal System.Void <GrowPotionHolders>b__2()
internal System.Void <GrowPotionHolders>b__3()
```

## MegaCrit.Sts2.Core.Nodes.Potions.NPotionContainer+<>c__DisplayClass20_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Models.PotionModel potion
public .ctor()
internal System.Boolean <AnimatePotion>b__0(MegaCrit.Sts2.Core.Nodes.Potions.NPotionHolder n)
```

## MegaCrit.Sts2.Core.Nodes.Potions.NPotionContainer+<>c__DisplayClass21_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Models.PotionModel potion
public .ctor()
internal System.Boolean <OnPotionUseOrDiscardCanceled>b__0(MegaCrit.Sts2.Core.Nodes.Potions.NPotionHolder n)
```

## MegaCrit.Sts2.Core.Nodes.Potions.NPotionContainer+<>c__DisplayClass24_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Models.PotionModel potion
public .ctor()
internal System.Boolean <Discard>b__0(MegaCrit.Sts2.Core.Nodes.Potions.NPotionHolder n)
```

## MegaCrit.Sts2.Core.Nodes.Potions.NPotionContainer+<>c__DisplayClass25_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Models.PotionModel potion
public .ctor()
internal System.Boolean <RemoveUsed>b__0(MegaCrit.Sts2.Core.Nodes.Potions.NPotionHolder n)
```

## MegaCrit.Sts2.Core.Nodes.Potions.NPotionContainer+<ShinePotions>d__31

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Potions.NPotionContainer <>4__this
private System.Collections.Generic.List+Enumerator<MegaCrit.Sts2.Core.Nodes.Potions.NPotionHolder> <>7__wrap1
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Potions.NPotionContainer+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Notification
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName ConnectPlayerEvents
public static readonly Godot.StringName DisconnectPlayerEvents
public static readonly Godot.StringName GrowPotionHolders
public static readonly Godot.StringName OnPotionHolderFocused
public static readonly Godot.StringName OnPotionHolderUnfocused
public static readonly Godot.StringName OnPotionShortcutPressed
public static readonly Godot.StringName PlayAddFailedAnim
public static readonly Godot.StringName PotionFtueCheck
public static readonly Godot.StringName UpdateNavigation
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Potions.NPotionContainer+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _focusedHolder
public static readonly Godot.StringName _potionErrorBg
public static readonly Godot.StringName _potionHolderInitPos
public static readonly Godot.StringName _potionHolders
public static readonly Godot.StringName _potionsFullTween
public static readonly Godot.StringName _potionShortcutButton
public static readonly Godot.StringName FirstPotionControl
public static readonly Godot.StringName LastPotionControl
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Potions.NPotionContainer+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Potions.NPotionHolder

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl`。

接口：`System.IDisposable`

```text
private System.Threading.CancellationTokenSource _cancelGrayOutPotionSource
private System.Threading.CancellationTokenSource _cts
private System.Boolean _disabledUntilPotionRemoved
private Godot.TextureRect _emptyIcon
private Godot.Tween _emptyPotionTween
private Godot.Tween _hoverTween
private System.Boolean _isFocused
private System.Boolean _isUsable
private MegaCrit.Sts2.Core.Nodes.Potions.NPotionPopup _popup
private Godot.Vector2 _potionScale
private System.Boolean _potionTargeting
private MegaCrit.Sts2.Core.Nodes.Combat.NSelectionReticle _selectionReticle
private MegaCrit.Sts2.Core.Nodes.Potions.NPotion <Potion>k__BackingField
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
MegaCrit.Sts2.Core.HoverTips.HoverTip EmptyHoverTip { private static get; }
System.Boolean HasPotion { public get; }
System.Boolean IsPotionUsable { public get; }
MegaCrit.Sts2.Core.Nodes.Potions.NPotion Potion { public get; private set; }
System.String ScenePath { private static get; }
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task GrayPotionHolderUntilPlayedAfterDelay()
private [async] System.Threading.Tasks.Task TargetNode(MegaCrit.Sts2.Core.Entities.Cards.TargetType targetType)
private static MegaCrit.Sts2.Core.HoverTips.HoverTip get_EmptyHoverTip()
private static System.String get_ScenePath()
private System.Boolean ShouldCancelTargeting()
private System.Void OpenPotionPopup()
private System.Void set_Potion(MegaCrit.Sts2.Core.Nodes.Potions.NPotion value)
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
public [async] System.Threading.Tasks.Task ShineOnStartOfCombat()
public [async] System.Threading.Tasks.Task UsePotion()
public MegaCrit.Sts2.Core.Nodes.Potions.NPotion get_Potion()
public static MegaCrit.Sts2.Core.Nodes.Potions.NPotionHolder Create(System.Boolean isUsable)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Boolean get_HasPotion()
public System.Boolean get_IsPotionUsable()
public System.Void AddPotion(MegaCrit.Sts2.Core.Nodes.Potions.NPotion potion)
public System.Void CancelPotionUseOrDiscard()
public System.Void DisableUntilPotionRemoved()
public System.Void DiscardPotion()
public System.Void RemoveUsedPotion()
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Potions.NPotionHolder+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Potions.NPotionHolder+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Entities.Creatures.Creature, System.Boolean> <>9__42_0
public static System.Func<MegaCrit.Sts2.Core.Entities.Creatures.Creature, Godot.Control> <>9__42_1
private static .cctor()
public .ctor()
internal Godot.Control <TargetNode>b__42_1(MegaCrit.Sts2.Core.Entities.Creatures.Creature c)
internal System.Boolean <TargetNode>b__42_0(MegaCrit.Sts2.Core.Entities.Creatures.Creature c)
```

## MegaCrit.Sts2.Core.Nodes.Potions.NPotionHolder+<>c__DisplayClass39_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Potions.NPotionHolder <>4__this
public MegaCrit.Sts2.Core.Nodes.Potions.NPotion potionToRemove
public .ctor()
internal System.Void <RemoveUsedPotion>b__0()
```

## MegaCrit.Sts2.Core.Nodes.Potions.NPotionHolder+<>c__DisplayClass40_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Potions.NPotionHolder <>4__this
public MegaCrit.Sts2.Core.Nodes.Potions.NPotion potionToRemove
public .ctor()
internal System.Void <DiscardPotion>b__0()
```

## MegaCrit.Sts2.Core.Nodes.Potions.NPotionHolder+<GrayPotionHolderUntilPlayedAfterDelay>d__37

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Potions.NPotionHolder <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Potions.NPotionHolder+<ShineOnStartOfCombat>d__44

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Potions.NPotionHolder <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Potions.NPotionHolder+<TargetNode>d__42

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Potions.NPotionHolder <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<Godot.Node> <>u__1
private MegaCrit.Sts2.Core.Nodes.Rooms.NMerchantButton <merchantButton>5__2
private System.Boolean <merchantButtonWasDisabled>5__5
private Godot.Control <merchantScreenContext>5__4
private System.Nullable<Godot.Control+FocusBehaviorRecursiveEnum> <savedFocusBehavior>5__3
public MegaCrit.Sts2.Core.Entities.Cards.TargetType targetType
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Potions.NPotionHolder+<UsePotion>d__41

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Potions.NPotionHolder <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Potions.NPotionHolder+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AddPotion
public static readonly Godot.StringName CancelPotionUseOrDiscard
public static readonly Godot.StringName Create
public static readonly Godot.StringName DisableUntilPotionRemoved
public static readonly Godot.StringName DiscardPotion
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName OpenPotionPopup
public static readonly Godot.StringName RemoveUsedPotion
public static readonly Godot.StringName ShouldCancelTargeting
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Potions.NPotionHolder+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+PropertyName`。

接口：

```text
public static readonly Godot.StringName _disabledUntilPotionRemoved
public static readonly Godot.StringName _emptyIcon
public static readonly Godot.StringName _emptyPotionTween
public static readonly Godot.StringName _hoverTween
public static readonly Godot.StringName _isFocused
public static readonly Godot.StringName _isUsable
public static readonly Godot.StringName _popup
public static readonly Godot.StringName _potionScale
public static readonly Godot.StringName _potionTargeting
public static readonly Godot.StringName _selectionReticle
public static readonly Godot.StringName HasPotion
public static readonly Godot.StringName IsPotionUsable
public static readonly Godot.StringName Potion
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Potions.NPotionHolder+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Potions.NPotionPopup

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Nodes.Potions.NPotionPopupButton _discardButton
private MegaCrit.Sts2.Core.Nodes.Potions.NPotionHolder _holder
private Godot.Control _hoverTipBounds
private Godot.Control _popupContainer
private MegaCrit.Sts2.Core.Entities.Players.Player _subscribedPlayer
private Godot.Tween _tween
private MegaCrit.Sts2.Core.Nodes.Potions.NPotionPopupButton _useButton
private System.Boolean <IsMarkedForRemoval>k__BackingField
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
System.Boolean InACardSelectScreen { private get; }
System.Boolean IsMarkedForRemoval { public get; private set; }
System.Boolean IsUsable { public get; }
MegaCrit.Sts2.Core.Models.PotionModel Potion { private get; }
System.String ScenePath { private static get; }
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task UsePotion()
private MegaCrit.Sts2.Core.Models.PotionModel get_Potion()
private static System.String get_ScenePath()
private System.Boolean get_InACardSelectScreen()
private System.Void <UsePotion>g__DisableHolder|22_0()
private System.Void DisconnectSignals()
private System.Void OnCombatStateChanged(MegaCrit.Sts2.Core.Combat.CombatState _)
private System.Void OnDiscardButtonPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OnPlayerEndTurnStatusChanged(MegaCrit.Sts2.Core.Entities.Players.Player _, System.Boolean __)
private System.Void OnPlayerEndTurnStatusChanged(MegaCrit.Sts2.Core.Entities.Players.Player _)
private System.Void OnTurnStarted(MegaCrit.Sts2.Core.Combat.CombatState _)
private System.Void OnUseButtonPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void RefreshButtons()
private System.Void set_IsMarkedForRemoval(System.Boolean value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Potions.NPotionPopup Create(MegaCrit.Sts2.Core.Nodes.Potions.NPotionHolder holder)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Boolean get_IsMarkedForRemoval()
public System.Boolean get_IsUsable()
public System.Void Remove()
public virtual System.Void _ExitTree()
public virtual System.Void _Input(Godot.InputEvent inputEvent)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Potions.NPotionPopup+<UsePotion>d__22

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Potions.NPotionPopup <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private MegaCrit.Sts2.Core.Models.PotionModel <potion>5__2
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Potions.NPotionPopup+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Input
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName DisconnectSignals
public static readonly Godot.StringName OnDiscardButtonPressed
public static readonly Godot.StringName OnUseButtonPressed
public static readonly Godot.StringName RefreshButtons
public static readonly Godot.StringName Remove
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Potions.NPotionPopup+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _discardButton
public static readonly Godot.StringName _holder
public static readonly Godot.StringName _hoverTipBounds
public static readonly Godot.StringName _popupContainer
public static readonly Godot.StringName _tween
public static readonly Godot.StringName _useButton
public static readonly Godot.StringName InACardSelectScreen
public static readonly Godot.StringName IsMarkedForRemoval
public static readonly Godot.StringName IsUsable
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Potions.NPotionPopup+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Potions.NPotionPopupButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private Godot.TextureRect _background
private Godot.Tween _currentTween
private MegaCrit.Sts2.addons.mega_text.MegaLabel _label
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnDisable()
protected virtual System.Void OnEnable()
protected virtual System.Void OnFocus()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void SetLocKey(System.String locEntryKey)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Potions.NPotionPopupButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnDisable
public static readonly Godot.StringName OnEnable
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName SetLocKey
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Potions.NPotionPopupButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _background
public static readonly Godot.StringName _currentTween
public static readonly Godot.StringName _label
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Potions.NPotionPopupButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Potions.NPotionShortcutButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
System.String[] Hotkeys { protected virtual get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.String[] get_Hotkeys()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Potions.NPotionShortcutButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Potions.NPotionShortcutButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName Hotkeys
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Potions.NPotionShortcutButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```
