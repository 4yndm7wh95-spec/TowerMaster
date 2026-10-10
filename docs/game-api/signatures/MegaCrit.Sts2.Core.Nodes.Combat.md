# MegaCrit.Sts2.Core.Nodes.Combat

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.Combat.NCardPlay

类型属性：`Public, Abstract, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private System.Boolean _isTryingToPlayCard
private static const System.Int32 _numCardPlayedUntilDisableFtue = 8
private static System.Int32 _totalCardsPlayedForFtue
protected Godot.Viewport _viewport
private MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder <Holder>k__BackingField
private MegaCrit.Sts2.Core.Entities.Players.Player <Player>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Combat.NCardPlay+FinishedEventHandler backing_Finished
MegaCrit.Sts2.Core.Models.CardModel Card { protected get; }
MegaCrit.Sts2.Core.Nodes.Cards.NCard CardNode { protected get; }
MegaCrit.Sts2.Core.Nodes.Combat.NCreature CardOwnerNode { protected get; }
MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder Holder { public get; protected set; }
MegaCrit.Sts2.Core.Entities.Players.Player Player { public get; protected set; }
event MegaCrit.Sts2.Core.Nodes.Combat.NCardPlay+FinishedEventHandler Finished
protected .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotSignalList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void AutoDisableCannotPlayCardFtueCheck()
private System.Void ClearTarget()
private System.Void HideEvokingOrbs()
protected MegaCrit.Sts2.Core.Models.CardModel get_Card()
protected MegaCrit.Sts2.Core.Nodes.Cards.NCard get_CardNode()
protected MegaCrit.Sts2.Core.Nodes.Combat.NCreature get_CardOwnerNode()
protected System.Void CannotPlayThisCardFtueCheck(MegaCrit.Sts2.Core.Models.CardModel card)
protected System.Void CenterCard()
protected System.Void Cleanup(System.Boolean isFinished)
protected System.Void EmitSignalFinished(System.Boolean success)
protected System.Void HideTargetingVisuals()
protected System.Void OnCreatureHover(MegaCrit.Sts2.Core.Nodes.Combat.NCreature creature)
protected System.Void OnCreatureUnhover(MegaCrit.Sts2.Core.Nodes.Combat.NCreature _)
protected System.Void set_Holder(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder value)
protected System.Void set_Player(MegaCrit.Sts2.Core.Entities.Players.Player value)
protected System.Void ShowMultiCreatureTargetingVisuals()
protected System.Void TryPlayCard(MegaCrit.Sts2.Core.Entities.Creatures.Creature target)
protected System.Void TryShowEvokingOrbs()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean HasGodotClassSignal(in Godot.NativeInterop.godot_string_name signal)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnCancelPlayCard()
protected virtual System.Void RaiseGodotClassSignalCallbacks(in Godot.NativeInterop.godot_string_name signal, Godot.NativeInterop.NativeVariantPtrArgs args)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public abstract System.Void Start()
public MegaCrit.Sts2.Core.Entities.Players.Player get_Player()
public MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder get_Holder()
public System.Void add_Finished(MegaCrit.Sts2.Core.Nodes.Combat.NCardPlay+FinishedEventHandler value)
public System.Void CancelPlayCard()
public System.Void remove_Finished(MegaCrit.Sts2.Core.Nodes.Combat.NCardPlay+FinishedEventHandler value)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCardPlay+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Combat.NCardPlay+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Entities.Creatures.Creature, System.Boolean> <>9__30_0
private static .cctor()
public .ctor()
internal System.Boolean <ShowMultiCreatureTargetingVisuals>b__30_0(MegaCrit.Sts2.Core.Entities.Creatures.Creature c)
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCardPlay+FinishedEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(System.Boolean success, System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke(System.Boolean success)
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCardPlay+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AutoDisableCannotPlayCardFtueCheck
public static readonly Godot.StringName CancelPlayCard
public static readonly Godot.StringName CenterCard
public static readonly Godot.StringName Cleanup
public static readonly Godot.StringName ClearTarget
public static readonly Godot.StringName HideEvokingOrbs
public static readonly Godot.StringName HideTargetingVisuals
public static readonly Godot.StringName OnCancelPlayCard
public static readonly Godot.StringName OnCreatureHover
public static readonly Godot.StringName OnCreatureUnhover
public static readonly Godot.StringName ShowMultiCreatureTargetingVisuals
public static readonly Godot.StringName Start
public static readonly Godot.StringName TryShowEvokingOrbs
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCardPlay+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _isTryingToPlayCard
public static readonly Godot.StringName _viewport
public static readonly Godot.StringName CardNode
public static readonly Godot.StringName CardOwnerNode
public static readonly Godot.StringName Holder
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCardPlay+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public static readonly Godot.StringName Finished
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCardPlayQueue

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Combat.NCardPlayQueue+QueueItem> _playQueue
MegaCrit.Sts2.Core.Nodes.Combat.NCardPlayQueue Instance { public static get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
private Godot.Vector2 GetPositionForQueueIndex(MegaCrit.Sts2.Core.Nodes.Cards.NCard card, System.Int32 index)
private Godot.Vector2 GetScaleForQueueIndex(System.Int32 index)
private System.Void BeforeRemoteCardPlayResumedAfterPlayerChoice(MegaCrit.Sts2.Core.GameActions.GameAction action)
private System.Void OnActionEnqueued(MegaCrit.Sts2.Core.GameActions.GameAction action)
private System.Void RemoveCardFromQueue(MegaCrit.Sts2.Core.Nodes.Cards.NCard card)
private System.Void RemoveCardFromQueue(System.Int32 index)
private System.Void RemoveCardFromQueueForCancellation(System.Int32 index, System.Boolean forceReturnToHand = False)
private System.Void TweenAllToQueuePosition()
private System.Void TweenCardForCancellation(MegaCrit.Sts2.Core.Nodes.Combat.NCardPlayQueue+QueueItem item)
private System.Void TweenCardToQueuePosition(MegaCrit.Sts2.Core.Nodes.Combat.NCardPlayQueue+QueueItem item, System.Int32 queueIndex)
private System.Void UpdateCardVisuals(MegaCrit.Sts2.Core.Nodes.Combat.NCardPlayQueue+QueueItem item)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public MegaCrit.Sts2.Core.Nodes.Cards.NCard GetCardNode(MegaCrit.Sts2.Core.Models.CardModel card)
public static MegaCrit.Sts2.Core.Nodes.Combat.NCardPlayQueue get_Instance()
public System.Void AnimOut()
public System.Void OnLocalCardPlayed(MegaCrit.Sts2.Core.GameActions.PlayCardAction action, MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder holder, MegaCrit.Sts2.Core.Models.CardModel card)
public System.Void ReAddCardAfterPlayerChoice(MegaCrit.Sts2.Core.Nodes.Cards.NCard card, MegaCrit.Sts2.Core.GameActions.GameAction action)
public System.Void RemoveCardFromQueueForCancellation(MegaCrit.Sts2.Core.GameActions.PlayCardAction action)
public System.Void RemoveCardFromQueueForCancellation(MegaCrit.Sts2.Core.Nodes.Cards.NCard card, System.Boolean forceReturnToHand = False)
public System.Void RemoveCardFromQueueForExecution(MegaCrit.Sts2.Core.Models.CardModel card)
public System.Void UpdateCardBeforeExecution(MegaCrit.Sts2.Core.GameActions.PlayCardAction playCardAction)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCardPlayQueue+<>c__DisplayClass10_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.GameActions.PlayCardAction action
public .ctor()
internal System.Boolean <RemoveCardFromQueueForCancellation>b__0(MegaCrit.Sts2.Core.Nodes.Combat.NCardPlayQueue+QueueItem i)
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCardPlayQueue+<>c__DisplayClass11_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Cards.NCard card
public .ctor()
internal System.Boolean <RemoveCardFromQueueForCancellation>b__0(MegaCrit.Sts2.Core.Nodes.Combat.NCardPlayQueue+QueueItem i)
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCardPlayQueue+<>c__DisplayClass13_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.GameActions.PlayCardAction playCardAction
public .ctor()
internal System.Boolean <UpdateCardBeforeExecution>b__0(MegaCrit.Sts2.Core.Nodes.Combat.NCardPlayQueue+QueueItem i)
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCardPlayQueue+<>c__DisplayClass14_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Models.CardModel card
public .ctor()
internal System.Boolean <RemoveCardFromQueueForExecution>b__0(MegaCrit.Sts2.Core.Nodes.Combat.NCardPlayQueue+QueueItem i)
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCardPlayQueue+<>c__DisplayClass16_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Cards.NCard card
public .ctor()
internal System.Boolean <RemoveCardFromQueue>b__0(MegaCrit.Sts2.Core.Nodes.Combat.NCardPlayQueue+QueueItem i)
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCardPlayQueue+<>c__DisplayClass19_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Models.CardModel card
public .ctor()
internal System.Boolean <GetCardNode>b__0(MegaCrit.Sts2.Core.Nodes.Combat.NCardPlayQueue+QueueItem i)
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCardPlayQueue+<>c__DisplayClass9_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.GameActions.GameAction action
public .ctor()
internal System.Boolean <BeforeRemoteCardPlayResumedAfterPlayerChoice>b__0(MegaCrit.Sts2.Core.Nodes.Combat.NCardPlayQueue+QueueItem i)
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCardPlayQueue+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AnimOut
public static readonly Godot.StringName GetPositionForQueueIndex
public static readonly Godot.StringName GetScaleForQueueIndex
public static readonly Godot.StringName RemoveCardFromQueue
public static readonly Godot.StringName RemoveCardFromQueueForCancellation
public static readonly Godot.StringName TweenAllToQueuePosition
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCardPlayQueue+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCardPlayQueue+QueueItem

类型属性：`NestedPrivate, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.GameActions.GameAction action
public MegaCrit.Sts2.Core.Nodes.Cards.NCard card
public Godot.Tween currentTween
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCardPlayQueue+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCombatCardPile

类型属性：`Public, Abstract, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private static const System.Double _animDuration = 0.5
private Godot.Tween _bumpTween
private MegaCrit.Sts2.addons.mega_text.MegaLabel _countLabel
private System.Int32 _currentCount
private static readonly Godot.Color _downColor
protected MegaCrit.Sts2.Core.Localization.LocString _emptyPileMessage
protected Godot.Vector2 _hidePosition
private static readonly Godot.Vector2 _hoverScale
private Godot.Control _icon
private MegaCrit.Sts2.Core.Entities.Players.Player _localPlayer
private MegaCrit.Sts2.Core.Entities.Cards.CardPile _pile
private Godot.Tween _positionTween
private static const System.Double _pressDownDur = 0.25
protected Godot.Vector2 _showPosition
private static const System.Double _unhoverAnimDur = 0.5
MegaCrit.Sts2.Core.Entities.Cards.PileType Pile { protected abstract get; }
private static .cctor()
protected .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void RemoveCard()
protected abstract MegaCrit.Sts2.Core.Entities.Cards.PileType get_Pile()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void AddCard()
protected virtual System.Void ConnectSignals()
protected virtual System.Void OnFocus()
protected virtual System.Void OnPress()
protected virtual System.Void OnRelease()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SetAnimInOutPositions()
public System.Void AnimOut()
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
public virtual System.Void AnimIn()
public virtual System.Void Initialize(MegaCrit.Sts2.Core.Entities.Players.Player player)
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCombatCardPile+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AddCard
public static readonly Godot.StringName AnimIn
public static readonly Godot.StringName AnimOut
public static readonly Godot.StringName ConnectSignals
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName RemoveCard
public static readonly Godot.StringName SetAnimInOutPositions
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCombatCardPile+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _bumpTween
public static readonly Godot.StringName _countLabel
public static readonly Godot.StringName _currentCount
public static readonly Godot.StringName _hidePosition
public static readonly Godot.StringName _icon
public static readonly Godot.StringName _positionTween
public static readonly Godot.StringName _showPosition
public static readonly Godot.StringName Pile
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCombatCardPile+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCombatPilesContainer

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Nodes.Combat.NDiscardPileButton _discardPile
private MegaCrit.Sts2.Core.Nodes.Combat.NDrawPileButton _drawPile
private MegaCrit.Sts2.Core.Nodes.Combat.NExhaustPileButton _exhaustPile
public static readonly System.String scenePath
MegaCrit.Sts2.Core.Nodes.Combat.NDiscardPileButton DiscardPile { public get; }
MegaCrit.Sts2.Core.Nodes.Combat.NDrawPileButton DrawPile { public get; }
MegaCrit.Sts2.Core.Nodes.Combat.NExhaustPileButton ExhaustPile { public get; }
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
public MegaCrit.Sts2.Core.Nodes.Combat.NDiscardPileButton get_DiscardPile()
public MegaCrit.Sts2.Core.Nodes.Combat.NDrawPileButton get_DrawPile()
public MegaCrit.Sts2.Core.Nodes.Combat.NExhaustPileButton get_ExhaustPile()
public System.Void AnimIn()
public System.Void AnimOut()
public System.Void Disable()
public System.Void Enable()
public System.Void Initialize(MegaCrit.Sts2.Core.Entities.Players.Player player)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCombatPilesContainer+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AnimIn
public static readonly Godot.StringName AnimOut
public static readonly Godot.StringName Disable
public static readonly Godot.StringName Enable
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCombatPilesContainer+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _discardPile
public static readonly Godot.StringName _drawPile
public static readonly Godot.StringName _exhaustPile
public static readonly Godot.StringName DiscardPile
public static readonly Godot.StringName DrawPile
public static readonly Godot.StringName ExhaustPile
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCombatPilesContainer+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCombatSceneContainer

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private Godot.Control _bgContainer
private static const System.Single _maxNarrowRatio = 1.3333334
private static const System.Single _sixteenByNine = 1.7777778
private Godot.Window _window
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnWindowChange()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCombatSceneContainer+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnWindowChange
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCombatSceneContainer+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _bgContainer
public static readonly Godot.StringName _window
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCombatSceneContainer+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCombatStartBanner

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private Godot.ColorRect _colorRect
private MegaCrit.Sts2.addons.mega_text.MegaLabel _label
private static readonly System.String _scenePath
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task AnimateVfx()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Combat.NCombatStartBanner Create()
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCombatStartBanner+<AnimateVfx>d__7

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Combat.NCombatStartBanner <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCombatStartBanner+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCombatStartBanner+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _colorRect
public static readonly Godot.StringName _label
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCombatStartBanner+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCombatUi

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Nodes.Combat.NCombatPilesContainer _combatPilesContainer
private readonly System.Threading.CancellationTokenSource _cts
private MegaCrit.Sts2.Core.Nodes.Combat.NEnergyCounter _energyCounter
private static System.Boolean _isDebugHidden
private static System.Boolean _isDebugHidingHand
private static System.Boolean _isDebugSlowRewards
private System.Int32 _originalHandChildIndex
private readonly System.Collections.Generic.Dictionary<MegaCrit.Sts2.Core.Nodes.Cards.NCard, Godot.Vector2> _originalPlayContainerCardPositions
private readonly System.Collections.Generic.Dictionary<MegaCrit.Sts2.Core.Nodes.Cards.NCard, Godot.Vector2> _originalPlayContainerCardScales
private Godot.Tween _playContainerPeekModeTween
private MegaCrit.Sts2.Core.Nodes.Combat.NStarCounter _starCounter
private MegaCrit.Sts2.Core.Combat.CombatState _state
private Godot.Control <CardPreviewContainer>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Combat.NEndTurnButton <EndTurnButton>k__BackingField
private Godot.Control <EnergyCounterContainer>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Combat.NPlayerHand <Hand>k__BackingField
private static System.Boolean <IsDebugHideMpIntents>k__BackingField
private static System.Boolean <IsDebugHideMpTargetingUi>k__BackingField
private static System.Boolean <IsDebugHideTargetingUi>k__BackingField
private static System.Boolean <IsDebugHideTextVfx>k__BackingField
private static System.Boolean <IsDebugHidingHpBar>k__BackingField
private static System.Boolean <IsDebugHidingIntent>k__BackingField
private static System.Boolean <IsDebugHidingPlayContainer>k__BackingField
private MegaCrit.Sts2.Core.Nodes.CommonUi.NMessyCardPreviewContainer <MessyCardPreviewContainer>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Combat.NPingButton <PingButton>k__BackingField
private Godot.Control <PlayContainer>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Combat.NCardPlayQueue <PlayQueue>k__BackingField
private System.Action DebugToggleHpBar
private System.Action DebugToggleIntent
Godot.Control CardPreviewContainer { public get; private set; }
MegaCrit.Sts2.Core.Nodes.Combat.NDiscardPileButton DiscardPile { public get; }
MegaCrit.Sts2.Core.Nodes.Combat.NDrawPileButton DrawPile { public get; }
MegaCrit.Sts2.Core.Nodes.Combat.NEndTurnButton EndTurnButton { public get; private set; }
Godot.Control EnergyCounterContainer { public get; private set; }
MegaCrit.Sts2.Core.Nodes.Combat.NExhaustPileButton ExhaustPile { public get; }
MegaCrit.Sts2.Core.Nodes.Combat.NPlayerHand Hand { public get; private set; }
System.Boolean IsDebugHideMpIntents { public static get; private static set; }
System.Boolean IsDebugHideMpTargetingUi { public static get; private static set; }
System.Boolean IsDebugHideTargetingUi { public static get; private static set; }
System.Boolean IsDebugHideTextVfx { public static get; private static set; }
System.Boolean IsDebugHidingHpBar { public static get; private static set; }
System.Boolean IsDebugHidingIntent { public static get; private static set; }
System.Boolean IsDebugHidingPlayContainer { public static get; private static set; }
MegaCrit.Sts2.Core.Nodes.CommonUi.NMessyCardPreviewContainer MessyCardPreviewContainer { public get; private set; }
MegaCrit.Sts2.Core.Nodes.Combat.NPingButton PingButton { private get; private set; }
Godot.Control PlayContainer { public get; private set; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Nodes.Cards.NCard> PlayContainerCards { private get; }
MegaCrit.Sts2.Core.Nodes.Combat.NCardPlayQueue PlayQueue { public get; private set; }
event System.Action DebugToggleHpBar
event System.Action DebugToggleIntent
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task ShowRewards(MegaCrit.Sts2.Core.Rooms.CombatRoom room)
private MegaCrit.Sts2.Core.Nodes.Combat.NPingButton get_PingButton()
private static System.Void set_IsDebugHideMpIntents(System.Boolean value)
private static System.Void set_IsDebugHideMpTargetingUi(System.Boolean value)
private static System.Void set_IsDebugHideTargetingUi(System.Boolean value)
private static System.Void set_IsDebugHideTextVfx(System.Boolean value)
private static System.Void set_IsDebugHidingHpBar(System.Boolean value)
private static System.Void set_IsDebugHidingIntent(System.Boolean value)
private static System.Void set_IsDebugHidingPlayContainer(System.Boolean value)
private System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Nodes.Cards.NCard> get_PlayContainerCards()
private System.Void AnimIn()
private System.Void DebugHideCombatUi()
private System.Void DisconnectSignals()
private System.Void OnCombatEnded(MegaCrit.Sts2.Core.Rooms.CombatRoom combatRoom)
private System.Void OnCombatWon(MegaCrit.Sts2.Core.Rooms.CombatRoom room)
private System.Void OnPeekButtonToggled(MegaCrit.Sts2.Core.Nodes.Combat.NPeekButton peekButton)
private System.Void PostCombatCleanUp()
private System.Void set_CardPreviewContainer(Godot.Control value)
private System.Void set_EndTurnButton(MegaCrit.Sts2.Core.Nodes.Combat.NEndTurnButton value)
private System.Void set_EnergyCounterContainer(Godot.Control value)
private System.Void set_Hand(MegaCrit.Sts2.Core.Nodes.Combat.NPlayerHand value)
private System.Void set_MessyCardPreviewContainer(MegaCrit.Sts2.Core.Nodes.CommonUi.NMessyCardPreviewContainer value)
private System.Void set_PingButton(MegaCrit.Sts2.Core.Nodes.Combat.NPingButton value)
private System.Void set_PlayContainer(Godot.Control value)
private System.Void set_PlayQueue(MegaCrit.Sts2.Core.Nodes.Combat.NCardPlayQueue value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public [async] System.Threading.Tasks.Task ProceedWithoutRewards()
public Godot.Control get_CardPreviewContainer()
public Godot.Control get_EnergyCounterContainer()
public Godot.Control get_PlayContainer()
public MegaCrit.Sts2.Core.Nodes.Cards.NCard GetCardFromPlayContainer(MegaCrit.Sts2.Core.Models.CardModel model)
public MegaCrit.Sts2.Core.Nodes.Combat.NCardPlayQueue get_PlayQueue()
public MegaCrit.Sts2.Core.Nodes.Combat.NDiscardPileButton get_DiscardPile()
public MegaCrit.Sts2.Core.Nodes.Combat.NDrawPileButton get_DrawPile()
public MegaCrit.Sts2.Core.Nodes.Combat.NEndTurnButton get_EndTurnButton()
public MegaCrit.Sts2.Core.Nodes.Combat.NExhaustPileButton get_ExhaustPile()
public MegaCrit.Sts2.Core.Nodes.Combat.NPlayerHand get_Hand()
public MegaCrit.Sts2.Core.Nodes.CommonUi.NMessyCardPreviewContainer get_MessyCardPreviewContainer()
public static System.Boolean get_IsDebugHideMpIntents()
public static System.Boolean get_IsDebugHideMpTargetingUi()
public static System.Boolean get_IsDebugHideTargetingUi()
public static System.Boolean get_IsDebugHideTextVfx()
public static System.Boolean get_IsDebugHidingHpBar()
public static System.Boolean get_IsDebugHidingIntent()
public static System.Boolean get_IsDebugHidingPlayContainer()
public System.Void Activate(MegaCrit.Sts2.Core.Combat.CombatState state)
public System.Void add_DebugToggleHpBar(System.Action value)
public System.Void add_DebugToggleIntent(System.Action value)
public System.Void AddToPlayContainer(MegaCrit.Sts2.Core.Nodes.Cards.NCard card)
public System.Void AnimOut()
public System.Void Deactivate()
public System.Void Disable()
public System.Void Enable()
public System.Void OnHandSelectModeEntered()
public System.Void OnHandSelectModeExited()
public System.Void OnPeekButtonReady(MegaCrit.Sts2.Core.Nodes.Combat.NPeekButton peekButton)
public System.Void remove_DebugToggleHpBar(System.Action value)
public System.Void remove_DebugToggleIntent(System.Action value)
public virtual System.Void _ExitTree()
public virtual System.Void _Input(Godot.InputEvent inputEvent)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCombatUi+<>c__DisplayClass92_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Models.CardModel model
public .ctor()
internal System.Boolean <GetCardFromPlayContainer>b__0(MegaCrit.Sts2.Core.Nodes.Cards.NCard n)
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCombatUi+<ProceedWithoutRewards>d__95

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Combat.NCombatUi <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCombatUi+<ShowRewards>d__96

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Combat.NCombatUi <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.Rooms.CombatRoom room
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCombatUi+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Input
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AddToPlayContainer
public static readonly Godot.StringName AnimIn
public static readonly Godot.StringName AnimOut
public static readonly Godot.StringName Deactivate
public static readonly Godot.StringName DebugHideCombatUi
public static readonly Godot.StringName Disable
public static readonly Godot.StringName DisconnectSignals
public static readonly Godot.StringName Enable
public static readonly Godot.StringName OnHandSelectModeEntered
public static readonly Godot.StringName OnHandSelectModeExited
public static readonly Godot.StringName OnPeekButtonReady
public static readonly Godot.StringName OnPeekButtonToggled
public static readonly Godot.StringName PostCombatCleanUp
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCombatUi+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _combatPilesContainer
public static readonly Godot.StringName _energyCounter
public static readonly Godot.StringName _originalHandChildIndex
public static readonly Godot.StringName _playContainerPeekModeTween
public static readonly Godot.StringName _starCounter
public static readonly Godot.StringName CardPreviewContainer
public static readonly Godot.StringName DiscardPile
public static readonly Godot.StringName DrawPile
public static readonly Godot.StringName EndTurnButton
public static readonly Godot.StringName EnergyCounterContainer
public static readonly Godot.StringName ExhaustPile
public static readonly Godot.StringName Hand
public static readonly Godot.StringName MessyCardPreviewContainer
public static readonly Godot.StringName PingButton
public static readonly Godot.StringName PlayContainer
public static readonly Godot.StringName PlayQueue
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCombatUi+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NControllerCardPlay

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Combat.NCardPlay`。

接口：`System.IDisposable`

```text
private Godot.Callable _onCreatureHoverCallable
private Godot.Callable _onCreatureUnhoverCallable
private System.Boolean _signalsConnected
private MegaCrit.Sts2.Core.Nodes.Combat.NControllerCardPlay+CanceledEventHandler backing_Canceled
private MegaCrit.Sts2.Core.Nodes.Combat.NControllerCardPlay+ConfirmedEventHandler backing_Confirmed
event MegaCrit.Sts2.Core.Nodes.Combat.NControllerCardPlay+CanceledEventHandler Canceled
event MegaCrit.Sts2.Core.Nodes.Combat.NControllerCardPlay+ConfirmedEventHandler Confirmed
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotSignalList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task SingleCreatureTargeting(MegaCrit.Sts2.Core.Entities.Cards.TargetType targetType)
private System.Void <MultiCreatureTargeting>b__11_0()
private System.Void DisconnectTargetingSignals()
private System.Void MultiCreatureTargeting()
protected System.Void EmitSignalCanceled()
protected System.Void EmitSignalConfirmed()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean HasGodotClassSignal(in Godot.NativeInterop.godot_string_name signal)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnCancelPlayCard()
protected virtual System.Void RaiseGodotClassSignalCallbacks(in Godot.NativeInterop.godot_string_name signal, Godot.NativeInterop.NativeVariantPtrArgs args)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Combat.NControllerCardPlay Create(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder holder)
public System.Void add_Canceled(MegaCrit.Sts2.Core.Nodes.Combat.NControllerCardPlay+CanceledEventHandler value)
public System.Void add_Confirmed(MegaCrit.Sts2.Core.Nodes.Combat.NControllerCardPlay+ConfirmedEventHandler value)
public System.Void remove_Canceled(MegaCrit.Sts2.Core.Nodes.Combat.NControllerCardPlay+CanceledEventHandler value)
public System.Void remove_Confirmed(MegaCrit.Sts2.Core.Nodes.Combat.NControllerCardPlay+ConfirmedEventHandler value)
public virtual System.Void _ExitTree()
public virtual System.Void _Input(Godot.InputEvent inputEvent)
public virtual System.Void Start()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NControllerCardPlay+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Combat.NControllerCardPlay+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Entities.Creatures.Creature, System.Boolean> <>9__8_0
public static System.Func<MegaCrit.Sts2.Core.Entities.Creatures.Creature, MegaCrit.Sts2.Core.Nodes.Combat.NCreature> <>9__8_2
public static System.Func<MegaCrit.Sts2.Core.Nodes.Combat.NCreature, Godot.Control> <>9__8_4
public static System.Func<MegaCrit.Sts2.Core.Nodes.Combat.NCreature, System.Boolean> <>9__8_5
private static .cctor()
public .ctor()
internal Godot.Control <SingleCreatureTargeting>b__8_4(MegaCrit.Sts2.Core.Nodes.Combat.NCreature n)
internal MegaCrit.Sts2.Core.Nodes.Combat.NCreature <SingleCreatureTargeting>b__8_2(MegaCrit.Sts2.Core.Entities.Creatures.Creature c)
internal System.Boolean <SingleCreatureTargeting>b__8_0(MegaCrit.Sts2.Core.Entities.Creatures.Creature c)
internal System.Boolean <SingleCreatureTargeting>b__8_5(MegaCrit.Sts2.Core.Nodes.Combat.NCreature c)
```

## MegaCrit.Sts2.Core.Nodes.Combat.NControllerCardPlay+<>c__DisplayClass8_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Combat.NControllerCardPlay <>4__this
public MegaCrit.Sts2.Core.Entities.Creatures.Creature owner
public .ctor()
internal System.Boolean <SingleCreatureTargeting>b__1(MegaCrit.Sts2.Core.Entities.Creatures.Creature c)
internal System.Boolean <SingleCreatureTargeting>b__3()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NControllerCardPlay+<SingleCreatureTargeting>d__8

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Combat.NControllerCardPlay <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<Godot.Node> <>u__1
public MegaCrit.Sts2.Core.Entities.Cards.TargetType targetType
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Combat.NControllerCardPlay+CanceledEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NControllerCardPlay+ConfirmedEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NControllerCardPlay+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Combat.NCardPlay+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Input
public static readonly Godot.StringName Create
public static readonly Godot.StringName DisconnectTargetingSignals
public static readonly Godot.StringName MultiCreatureTargeting
public static readonly Godot.StringName OnCancelPlayCard
public static readonly Godot.StringName Start
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NControllerCardPlay+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Combat.NCardPlay+PropertyName`。

接口：

```text
public static readonly Godot.StringName _onCreatureHoverCallable
public static readonly Godot.StringName _onCreatureUnhoverCallable
public static readonly Godot.StringName _signalsConnected
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NControllerCardPlay+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Combat.NCardPlay+SignalName`。

接口：

```text
public static readonly Godot.StringName Canceled
public static readonly Godot.StringName Confirmed
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCreature

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private Godot.Tween _intentFadeTween
private System.Boolean _isInBestiary
private System.Boolean _isInMultiselect
private System.Boolean _isRemotePlayerOrPet
private Godot.Tween _scaleTween
private static readonly System.String _scenePath
private MegaCrit.Sts2.Core.Nodes.Combat.NSelectionReticle _selectionReticle
private readonly System.Collections.Generic.Dictionary<System.String, System.ValueTuple<System.String, System.Single>> _sfxLoops
private Godot.Tween _shakeTween
private MegaCrit.Sts2.Core.Animation.CreatureAnimator _spineAnimator
private MegaCrit.Sts2.Core.Nodes.Combat.NCreatureStateDisplay _stateDisplay
private System.Single _tempScale
private System.Threading.Tasks.Task <DeathAnimationTask>k__BackingField
private readonly System.Threading.CancellationTokenSource <DeathAnimCancelToken>k__BackingField
private MegaCrit.Sts2.Core.Entities.Creatures.Creature <Entity>k__BackingField
private Godot.Control <Hitbox>k__BackingField
private Godot.Control <IntentContainer>k__BackingField
private System.Boolean <IsFocused>k__BackingField
private System.Boolean <IsInteractable>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Orbs.NOrbManager <OrbManager>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerIntentHandler <PlayerIntentHandler>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Combat.NCreatureVisuals <Visuals>k__BackingField
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
Godot.Node2D Body { public get; }
System.Threading.Tasks.Task DeathAnimationTask { public get; public set; }
System.Threading.CancellationTokenSource DeathAnimCancelToken { public get; }
MegaCrit.Sts2.Core.Entities.Creatures.Creature Entity { public get; private set; }
System.Boolean HasSpineAnimation { public get; }
Godot.Control Hitbox { public get; private set; }
Godot.Control IntentContainer { public get; private set; }
System.Boolean IsFocused { public get; private set; }
System.Boolean IsInteractable { public get; private set; }
System.Boolean IsPlayingDeathAnimation { public get; }
MegaCrit.Sts2.Core.Nodes.Orbs.NOrbManager OrbManager { public get; private set; }
MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerIntentHandler PlayerIntentHandler { public get; private set; }
Godot.Vector2 PowerAppliedVfxPositionOffset { public static get; }
Godot.Vector2 PowerAppliedVfxSpawnPosition { public get; }
MegaCrit.Sts2.Core.Bindings.MegaSpine.SpineAnimationAccess SpineAnimation { public get; }
Godot.Vector2 VfxSpawnPosition { public get; }
MegaCrit.Sts2.Core.Nodes.Combat.NCreatureVisuals Visuals { public get; private set; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task AnimDie(System.Boolean shouldRemove, System.Threading.CancellationToken cancelToken)
private System.Threading.Tasks.Task RevealIntents()
private System.Void <AnimShake>b__113_0(System.Single t)
private System.Void <OstyScaleToSize>b__111_0()
private System.Void AnimTempRevive()
private System.Void ConnectSpineAnimatorSignals()
private System.Void DoScaleTween(Godot.Vector2 scale)
private System.Void ImmediatelySetIdle()
private System.Void OnCombatEnded(MegaCrit.Sts2.Core.Rooms.CombatRoom _)
private System.Void OnFocus()
private System.Void OnPowerApplied(MegaCrit.Sts2.Core.Models.PowerModel power)
private System.Void OnPowerFlashed(MegaCrit.Sts2.Core.Models.PowerModel power)
private System.Void OnPowerIncreased(MegaCrit.Sts2.Core.Models.PowerModel power, System.Int32 amount, System.Boolean silent)
private System.Void OnPowerRemoved(MegaCrit.Sts2.Core.Models.PowerModel power)
private System.Void OnUnfocus()
private System.Void set_Entity(MegaCrit.Sts2.Core.Entities.Creatures.Creature value)
private System.Void set_Hitbox(Godot.Control value)
private System.Void set_IntentContainer(Godot.Control value)
private System.Void set_IsFocused(System.Boolean value)
private System.Void set_IsInteractable(System.Boolean value)
private System.Void set_OrbManager(MegaCrit.Sts2.Core.Nodes.Orbs.NOrbManager value)
private System.Void set_PlayerIntentHandler(MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerIntentHandler value)
private System.Void set_Visuals(MegaCrit.Sts2.Core.Nodes.Combat.NCreatureVisuals value)
private System.Void SetOrbManagerPosition()
private System.Void ShowCreatureHoverTips(MegaCrit.Sts2.Core.Combat.CombatState _)
private System.Void SubscribeToPower(MegaCrit.Sts2.Core.Models.PowerModel power)
private System.Void UnsubscribeFromPower(MegaCrit.Sts2.Core.Models.PowerModel power)
private System.Void UpdateBounds(Godot.Node boundsContainer)
private System.Void UpdateBounds(System.String boundsNodeName)
private System.Void UpdatePhobiaMode()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public [async] System.Threading.Tasks.Task PerformIntent()
public [async] System.Threading.Tasks.Task RefreshIntents()
public Godot.Control get_Hitbox()
public Godot.Control get_IntentContainer()
public Godot.Node2D get_Body()
public Godot.Tween AnimDisableUi()
public Godot.Tween AnimEnableUi()
public Godot.Vector2 get_PowerAppliedVfxSpawnPosition()
public Godot.Vector2 get_VfxSpawnPosition()
public Godot.Vector2 GetBottomOfHitbox()
public Godot.Vector2 GetTopOfHitbox()
public MegaCrit.Sts2.Core.Bindings.MegaSpine.SpineAnimationAccess get_SpineAnimation()
public MegaCrit.Sts2.Core.Entities.Creatures.Creature get_Entity()
public MegaCrit.Sts2.Core.Nodes.Combat.NCreatureVisuals get_Visuals()
public MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerIntentHandler get_PlayerIntentHandler()
public MegaCrit.Sts2.Core.Nodes.Orbs.NOrbManager get_OrbManager()
public static Godot.Vector2 get_PowerAppliedVfxPositionOffset()
public static Godot.Vector2 GetOstyOffsetFromPlayer(MegaCrit.Sts2.Core.Entities.Creatures.Creature osty)
public static MegaCrit.Sts2.Core.Nodes.Combat.NCreature Create(MegaCrit.Sts2.Core.Entities.Creatures.Creature entity)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Boolean get_HasSpineAnimation()
public System.Boolean get_IsFocused()
public System.Boolean get_IsInteractable()
public System.Boolean get_IsPlayingDeathAnimation()
public System.Single GetCurrentAnimationLength()
public System.Single GetCurrentAnimationTimeRemaining()
public System.Single StartDeathAnim(System.Boolean shouldRemove)
public System.Threading.CancellationTokenSource get_DeathAnimCancelToken()
public System.Threading.Tasks.Task get_DeathAnimationTask()
public System.Threading.Tasks.Task UpdateIntent(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature> targets)
public System.Void AnimHideIntent(System.Double delay = 0)
public System.Void AnimShake()
public System.Void DisableInteractionForDeath()
public System.Void HideHoverTips()
public System.Void HideMultiselectReticle()
public System.Void HideSingleSelectReticle()
public System.Void OnTargetingStarted()
public System.Void OstyScaleToSize(System.Single ostyHealth, System.Double duration)
public System.Void ScaleTo(System.Single size, System.Double duration)
public System.Void set_DeathAnimationTask(System.Threading.Tasks.Task value)
public System.Void SetAnimationTrigger(System.String trigger)
public System.Void SetDefaultScaleTo(System.Single size, System.Single duration)
public System.Void SetRemotePlayerFocused(System.Boolean remotePlayerFocused)
public System.Void SetScaleAndHue(System.Single scale, System.Single hue)
public System.Void SetupForBestiary()
public System.Void ShowHoverTips(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.HoverTips.IHoverTip> hoverTips)
public System.Void ShowMultiselectReticle()
public System.Void ShowSingleSelectReticle()
public System.Void StartReviveAnim()
public System.Void StartSfxLoop(System.String sfxName, System.String loopParam, System.Single loopStopValue)
public System.Void StartSfxLoop(System.String sfxName)
public System.Void StopAllSfxLoops()
public System.Void StopSfxLoop(System.String sfxName)
public System.Void ToggleIsInteractable(System.Boolean on)
public System.Void TrackBlockStatus(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public System.Void UpdateNavigation()
public T GetSpecialNode<T>(System.String name) where T: [None] Godot.Node
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCreature+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Combat.NCreature+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Entities.Players.Player, MegaCrit.Sts2.Core.Entities.Creatures.Creature> <>9__79_0
private static .cctor()
public .ctor()
internal MegaCrit.Sts2.Core.Entities.Creatures.Creature <RefreshIntents>b__79_0(MegaCrit.Sts2.Core.Entities.Players.Player p)
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCreature+<>c__DisplayClass91_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Vfx.NPowerAppliedVfx vfx
public .ctor()
internal System.Void <OnPowerIncreased>b__0()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCreature+<>c__DisplayClass91_1

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Vfx.Ui.NPowerAppliedBuffVfx buffVfx
public .ctor()
internal System.Void <OnPowerIncreased>b__1()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCreature+<>c__DisplayClass91_2

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Vfx.Ui.NPowerAppliedDebuffVfx debuffVfx
public .ctor()
internal System.Void <OnPowerIncreased>b__2()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCreature+<>c__DisplayClass92_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Vfx.NPowerRemovedVfx vfx
public .ctor()
internal System.Void <OnPowerRemoved>b__0()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCreature+<>c__DisplayClass93_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Vfx.NPowerFlashVfx vfx
public .ctor()
internal System.Void <OnPowerFlashed>b__0()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCreature+<AnimDie>d__106

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Combat.NCreature <>4__this
private System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Nodes.Vfx.IDeathDelayer> <>7__wrap3
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__2
private Godot.Tween <disableUiTween>5__2
private System.Threading.Tasks.Task <fadeVfx>5__3
public System.Threading.CancellationToken cancelToken
public System.Boolean shouldRemove
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCreature+<PerformIntent>d__78

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Combat.NCreature <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCreature+<RefreshIntents>d__79

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Combat.NCreature <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCreature+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AnimDisableUi
public static readonly Godot.StringName AnimEnableUi
public static readonly Godot.StringName AnimHideIntent
public static readonly Godot.StringName AnimShake
public static readonly Godot.StringName AnimTempRevive
public static readonly Godot.StringName ConnectSpineAnimatorSignals
public static readonly Godot.StringName DisableInteractionForDeath
public static readonly Godot.StringName DoScaleTween
public static readonly Godot.StringName GetBottomOfHitbox
public static readonly Godot.StringName GetCurrentAnimationLength
public static readonly Godot.StringName GetCurrentAnimationTimeRemaining
public static readonly Godot.StringName GetTopOfHitbox
public static readonly Godot.StringName HideHoverTips
public static readonly Godot.StringName HideMultiselectReticle
public static readonly Godot.StringName HideSingleSelectReticle
public static readonly Godot.StringName ImmediatelySetIdle
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnTargetingStarted
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName OstyScaleToSize
public static readonly Godot.StringName ScaleTo
public static readonly Godot.StringName SetAnimationTrigger
public static readonly Godot.StringName SetDefaultScaleTo
public static readonly Godot.StringName SetOrbManagerPosition
public static readonly Godot.StringName SetRemotePlayerFocused
public static readonly Godot.StringName SetScaleAndHue
public static readonly Godot.StringName SetupForBestiary
public static readonly Godot.StringName ShowMultiselectReticle
public static readonly Godot.StringName ShowSingleSelectReticle
public static readonly Godot.StringName StartDeathAnim
public static readonly Godot.StringName StartReviveAnim
public static readonly Godot.StringName StartSfxLoop
public static readonly Godot.StringName StopAllSfxLoops
public static readonly Godot.StringName StopSfxLoop
public static readonly Godot.StringName ToggleIsInteractable
public static readonly Godot.StringName UpdateBounds
public static readonly Godot.StringName UpdateNavigation
public static readonly Godot.StringName UpdatePhobiaMode
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCreature+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _intentFadeTween
public static readonly Godot.StringName _isInBestiary
public static readonly Godot.StringName _isInMultiselect
public static readonly Godot.StringName _isRemotePlayerOrPet
public static readonly Godot.StringName _scaleTween
public static readonly Godot.StringName _selectionReticle
public static readonly Godot.StringName _shakeTween
public static readonly Godot.StringName _stateDisplay
public static readonly Godot.StringName _tempScale
public static readonly Godot.StringName Body
public static readonly Godot.StringName HasSpineAnimation
public static readonly Godot.StringName Hitbox
public static readonly Godot.StringName IntentContainer
public static readonly Godot.StringName IsFocused
public static readonly Godot.StringName IsInteractable
public static readonly Godot.StringName IsPlayingDeathAnimation
public static readonly Godot.StringName OrbManager
public static readonly Godot.StringName PlayerIntentHandler
public static readonly Godot.StringName PowerAppliedVfxSpawnPosition
public static readonly Godot.StringName VfxSpawnPosition
public static readonly Godot.StringName Visuals
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCreature+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCreatureStateDisplay

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Entities.Creatures.Creature _blockTrackingCreature
private MegaCrit.Sts2.Core.Entities.Creatures.Creature _creature
private Godot.Vector2 _creatureSize
private MegaCrit.Sts2.Core.Nodes.Combat.NHealthBar _healthBar
private static readonly Godot.Vector2 _healthBarAnimOffset
private Godot.Tween _hoverTween
private Godot.Control _hpBarHitbox
private Godot.Control _nameplateContainer
private MegaCrit.Sts2.addons.mega_text.MegaLabel _nameplateLabel
private Godot.Vector2 _originalPosition
private MegaCrit.Sts2.Core.Nodes.Combat.NPowerContainer _powerContainer
private Godot.Tween _showHideTween
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Boolean <AnimateOut>b__28_0()
private System.Void AnimateInBlock(System.Int32 oldBlock, System.Int32 blockGain)
private System.Void DebugToggleVisibility()
private System.Void OnBlockTrackingCreatureBlockChanged(System.Int32 oldBlock, System.Int32 blockGain)
private System.Void OnCombatStateChanged(MegaCrit.Sts2.Core.Combat.CombatState _)
private System.Void OnCreatureDied(MegaCrit.Sts2.Core.Entities.Creatures.Creature _)
private System.Void OnCreatureRevived(MegaCrit.Sts2.Core.Entities.Creatures.Creature _)
private System.Void OnHovered()
private System.Void OnUnhovered()
private System.Void RefreshValues()
private System.Void SubscribeToCreatureEvents()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void AnimateIn(MegaCrit.Sts2.Core.Entities.UI.HealthBarAnimMode mode)
public System.Void AnimateOut()
public System.Void HideImmediately()
public System.Void HideNameplate()
public System.Void SetCreature(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public System.Void SetCreatureBounds(Godot.Control bounds)
public System.Void ShowNameplate()
public System.Void TrackBlockStatus(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCreatureStateDisplay+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AnimateIn
public static readonly Godot.StringName AnimateInBlock
public static readonly Godot.StringName AnimateOut
public static readonly Godot.StringName DebugToggleVisibility
public static readonly Godot.StringName HideImmediately
public static readonly Godot.StringName HideNameplate
public static readonly Godot.StringName OnBlockTrackingCreatureBlockChanged
public static readonly Godot.StringName OnHovered
public static readonly Godot.StringName OnUnhovered
public static readonly Godot.StringName RefreshValues
public static readonly Godot.StringName SetCreatureBounds
public static readonly Godot.StringName ShowNameplate
public static readonly Godot.StringName SubscribeToCreatureEvents
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCreatureStateDisplay+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _creatureSize
public static readonly Godot.StringName _healthBar
public static readonly Godot.StringName _hoverTween
public static readonly Godot.StringName _hpBarHitbox
public static readonly Godot.StringName _nameplateContainer
public static readonly Godot.StringName _nameplateLabel
public static readonly Godot.StringName _originalPosition
public static readonly Godot.StringName _powerContainer
public static readonly Godot.StringName _showHideTween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCreatureStateDisplay+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCreatureVisuals

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private static const System.Double _baseLiquidOverlayDuration = 1
private Godot.Node2D _body
private System.Threading.CancellationTokenSource _cts
private Godot.ShaderMaterial _currentLiquidOverlayMaterial
private static readonly Godot.StringName _h
private System.Single _hue
private System.Double _liquidOverlayTimer
private static readonly Godot.StringName _overlayInfluence
private Godot.Node2D _phobiaModeBody
private Godot.Material _savedNormalMaterial
private static readonly Godot.StringName _tint
private Godot.Control <Bounds>k__BackingField
private System.Single <DefaultScale>k__BackingField
private Godot.Control <FormVfxHolder>k__BackingField
private Godot.Marker2D <IntentPosition>k__BackingField
private Godot.Marker2D <OrbPosition>k__BackingField
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite <SpineBody>k__BackingField
private Godot.Marker2D <TalkPosition>k__BackingField
private Godot.Marker2D <VfxSpawnPosition>k__BackingField
Godot.Node2D Body { public get; }
Godot.Control Bounds { public get; private set; }
System.Single DefaultScale { public get; public set; }
Godot.Control FormVfxHolder { public get; private set; }
System.Boolean HasSpineAnimation { public get; }
Godot.Marker2D IntentPosition { public get; private set; }
System.Boolean IsSpineNode { private get; }
System.Boolean IsUsingPhobiaModeBody { public get; }
Godot.Marker2D OrbPosition { public get; private set; }
MegaCrit.Sts2.Core.Bindings.MegaSpine.SpineAnimationAccess SpineAnimation { public get; }
MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite SpineBody { public get; private set; }
Godot.Marker2D TalkPosition { public get; private set; }
Godot.Marker2D VfxSpawnPosition { public get; private set; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task ApplyLiquidOverlayInternal(Godot.Color tint)
private System.Boolean get_IsSpineNode()
private System.Void set_Bounds(Godot.Control value)
private System.Void set_FormVfxHolder(Godot.Control value)
private System.Void set_IntentPosition(Godot.Marker2D value)
private System.Void set_OrbPosition(Godot.Marker2D value)
private System.Void set_SpineBody(MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite value)
private System.Void set_TalkPosition(Godot.Marker2D value)
private System.Void set_VfxSpawnPosition(Godot.Marker2D value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public Godot.Control get_Bounds()
public Godot.Control get_FormVfxHolder()
public Godot.Marker2D get_IntentPosition()
public Godot.Marker2D get_OrbPosition()
public Godot.Marker2D get_TalkPosition()
public Godot.Marker2D get_VfxSpawnPosition()
public Godot.Node2D get_Body()
public Godot.Node2D GetCurrentBody()
public MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite get_SpineBody()
public MegaCrit.Sts2.Core.Bindings.MegaSpine.SpineAnimationAccess get_SpineAnimation()
public System.Boolean get_HasSpineAnimation()
public System.Boolean get_IsUsingPhobiaModeBody()
public System.Boolean IsPlayingHurtAnimation()
public System.Boolean IsPlayingIdleAnimation()
public System.Single get_DefaultScale()
public System.Void AddFormVfx(MegaCrit.Sts2.Core.Nodes.Vfx.Forms.NFormVfx formVfx)
public System.Void RemoveFormVfx()
public System.Void set_DefaultScale(System.Single value)
public System.Void SetScaleAndHue(System.Single scale, System.Single hue)
public System.Void SetUpSkin(MegaCrit.Sts2.Core.Models.MonsterModel model)
public System.Void TryApplyLiquidOverlay(Godot.Color tint)
public System.Void UpdatePhobiaMode(MegaCrit.Sts2.Core.Models.MonsterModel model)
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCreatureVisuals+<ApplyLiquidOverlayInternal>d__65

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Combat.NCreatureVisuals <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
public Godot.Color tint
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCreatureVisuals+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AddFormVfx
public static readonly Godot.StringName GetCurrentBody
public static readonly Godot.StringName IsPlayingHurtAnimation
public static readonly Godot.StringName IsPlayingIdleAnimation
public static readonly Godot.StringName RemoveFormVfx
public static readonly Godot.StringName SetScaleAndHue
public static readonly Godot.StringName TryApplyLiquidOverlay
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCreatureVisuals+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _body
public static readonly Godot.StringName _currentLiquidOverlayMaterial
public static readonly Godot.StringName _hue
public static readonly Godot.StringName _liquidOverlayTimer
public static readonly Godot.StringName _phobiaModeBody
public static readonly Godot.StringName _savedNormalMaterial
public static readonly Godot.StringName Body
public static readonly Godot.StringName Bounds
public static readonly Godot.StringName DefaultScale
public static readonly Godot.StringName FormVfxHolder
public static readonly Godot.StringName HasSpineAnimation
public static readonly Godot.StringName IntentPosition
public static readonly Godot.StringName IsSpineNode
public static readonly Godot.StringName IsUsingPhobiaModeBody
public static readonly Godot.StringName OrbPosition
public static readonly Godot.StringName TalkPosition
public static readonly Godot.StringName VfxSpawnPosition
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NCreatureVisuals+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NDiscardPileButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Combat.NCombatCardPile`。

接口：`System.IDisposable`

```text
System.String[] Hotkeys { protected virtual get; }
MegaCrit.Sts2.Core.Entities.Cards.PileType Pile { protected virtual get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual MegaCrit.Sts2.Core.Entities.Cards.PileType get_Pile()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.String[] get_Hotkeys()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SetAnimInOutPositions()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NDiscardPileButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Combat.NCombatCardPile+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName SetAnimInOutPositions
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NDiscardPileButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Combat.NCombatCardPile+PropertyName`。

接口：

```text
public static readonly Godot.StringName Hotkeys
public static readonly Godot.StringName Pile
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NDiscardPileButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Combat.NCombatCardPile+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NDrawPileButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Combat.NCombatCardPile`。

接口：`System.IDisposable`

```text
System.String[] Hotkeys { protected virtual get; }
MegaCrit.Sts2.Core.Entities.Cards.PileType Pile { protected virtual get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual MegaCrit.Sts2.Core.Entities.Cards.PileType get_Pile()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.String[] get_Hotkeys()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SetAnimInOutPositions()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NDrawPileButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Combat.NCombatCardPile+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName SetAnimInOutPositions
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NDrawPileButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Combat.NCombatCardPile+PropertyName`。

接口：

```text
public static readonly Godot.StringName Hotkeys
public static readonly Godot.StringName Pile
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NDrawPileButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Combat.NCombatCardPile+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NEndTurnButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Combat.CombatState _combatState
private MegaCrit.Sts2.Core.Nodes.Combat.NCombatUi _combatUi
private static readonly MegaCrit.Sts2.Core.Localization.LocString _endTurnLoc
private System.Int32 _endTurnWithNoPlayableCardsCount
private static const System.Single _flyInOutDuration = 0.5
private static const System.Int32 _ftueDisableEndTurnCount = 3
private Godot.Control _glow
private Godot.Tween _glowEnableTween
private Godot.Texture2D _glowTexture
private Godot.Control _glowVfx
private Godot.Tween _glowVfxTween
private static readonly Godot.Vector2 _hidePosRatio
private static readonly Godot.Vector2 _hoverTipOffset
private Godot.Tween _hoverTween
private Godot.ShaderMaterial _hsv
private Godot.TextureRect _image
private System.Boolean _isShiny
private MegaCrit.Sts2.addons.mega_text.MegaLabel _label
private MegaCrit.Sts2.Core.Nodes.Combat.NEndTurnLongPressBar _longPressBar
private Godot.Texture2D _normalTexture
private MegaCrit.Sts2.Core.Entities.Cards.CardPile _playerHand
private MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer _playerIconContainer
private Godot.Tween _positionTween
private System.Single _pulseTimer
private static readonly Godot.Vector2 _showPosRatio
private MegaCrit.Sts2.Core.Nodes.Combat.NEndTurnButton+State _state
private static readonly Godot.StringName _v
private Godot.Viewport _viewport
private Godot.Control _visuals
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
System.Boolean CanTurnBeEnded { private get; }
System.String EndTurnButtonGlowPath { private static get; }
System.String EndTurnButtonPath { private static get; }
Godot.Vector2 HidePos { private get; }
System.String[] Hotkeys { protected virtual get; }
Godot.Vector2 ShowPos { private get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private Godot.Vector2 get_HidePos()
private Godot.Vector2 get_ShowPos()
private static System.String get_EndTurnButtonGlowPath()
private static System.String get_EndTurnButtonPath()
private System.Boolean get_CanTurnBeEnded()
private System.Boolean HasPlayableCard()
private System.Boolean PlayerCanTakeAction(MegaCrit.Sts2.Core.Entities.Players.Player player)
private System.Boolean ShouldDisplayPlayerIcon(MegaCrit.Sts2.Core.Entities.Players.Player player)
private System.Boolean ShouldShowPlayableCardsFtue()
private System.Void AfterPlayerEndedTurn(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Boolean canBackOut)
private System.Void AfterPlayerUnendedTurn(MegaCrit.Sts2.Core.Entities.Players.Player player)
private System.Void AnimIn()
private System.Void AnimOut()
private System.Void GlowPulse()
private System.Void OnAboutToSwitchToEnemyTurn(MegaCrit.Sts2.Core.Combat.CombatState _)
private System.Void OnCombatStateChanged(MegaCrit.Sts2.Core.Combat.CombatState combatState)
private System.Void OnTurnStarted(MegaCrit.Sts2.Core.Combat.CombatState state)
private System.Void SetState(MegaCrit.Sts2.Core.Nodes.Combat.NEndTurnButton+State newState)
private System.Void StartOrStopPulseVfx()
private System.Void UpdateShaderV(System.Single value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.String[] get_Hotkeys()
protected virtual System.Void OnDisable()
protected virtual System.Void OnEnable()
protected virtual System.Void OnFocus()
protected virtual System.Void OnPress()
protected virtual System.Void OnRelease()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Void CallReleaseLogic()
public System.Void Initialize(MegaCrit.Sts2.Core.Combat.CombatState state)
public System.Void OnCombatEnded()
public System.Void RefreshEnabled()
public System.Void SecretEndTurnLogicViaFtue()
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NEndTurnButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AnimIn
public static readonly Godot.StringName AnimOut
public static readonly Godot.StringName CallReleaseLogic
public static readonly Godot.StringName GlowPulse
public static readonly Godot.StringName HasPlayableCard
public static readonly Godot.StringName OnCombatEnded
public static readonly Godot.StringName OnDisable
public static readonly Godot.StringName OnEnable
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName RefreshEnabled
public static readonly Godot.StringName SecretEndTurnLogicViaFtue
public static readonly Godot.StringName SetState
public static readonly Godot.StringName ShouldShowPlayableCardsFtue
public static readonly Godot.StringName StartOrStopPulseVfx
public static readonly Godot.StringName UpdateShaderV
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NEndTurnButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _combatUi
public static readonly Godot.StringName _endTurnWithNoPlayableCardsCount
public static readonly Godot.StringName _glow
public static readonly Godot.StringName _glowEnableTween
public static readonly Godot.StringName _glowTexture
public static readonly Godot.StringName _glowVfx
public static readonly Godot.StringName _glowVfxTween
public static readonly Godot.StringName _hoverTween
public static readonly Godot.StringName _hsv
public static readonly Godot.StringName _image
public static readonly Godot.StringName _isShiny
public static readonly Godot.StringName _label
public static readonly Godot.StringName _longPressBar
public static readonly Godot.StringName _normalTexture
public static readonly Godot.StringName _playerIconContainer
public static readonly Godot.StringName _positionTween
public static readonly Godot.StringName _pulseTimer
public static readonly Godot.StringName _state
public static readonly Godot.StringName _viewport
public static readonly Godot.StringName _visuals
public static readonly Godot.StringName CanTurnBeEnded
public static readonly Godot.StringName HidePos
public static readonly Godot.StringName Hotkeys
public static readonly Godot.StringName ShowPos
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NEndTurnButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NEndTurnButton+State

类型属性：`NestedPrivate, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Nodes.Combat.NEndTurnButton+State Disabled = 1
public static const MegaCrit.Sts2.Core.Nodes.Combat.NEndTurnButton+State Enabled = 0
public static const MegaCrit.Sts2.Core.Nodes.Combat.NEndTurnButton+State Hidden = 2
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Nodes.Combat.NEndTurnLongPressBar

类型属性：`Public, BeforeFieldInit`；基类：`Godot.ColorRect`。

接口：`System.IDisposable`

```text
private System.Boolean _enabled
private MegaCrit.Sts2.Core.Nodes.Combat.NEndTurnButton _endTurnButton
private System.Boolean _isPressed
private static const System.Double _longPressDuration = 0.5
private Godot.Control _outline
private System.Double _pressTimer
private static const System.Single _targetWidth = 204
private Godot.Tween _tween
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task PlayAnim()
private System.Void RecalculateBar()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void CancelPress()
public System.Void Init(MegaCrit.Sts2.Core.Nodes.Combat.NEndTurnButton endTurnButton)
public System.Void StartPress()
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NEndTurnLongPressBar+<PlayAnim>d__14

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Combat.NEndTurnLongPressBar <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Combat.NEndTurnLongPressBar+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.ColorRect+MethodName`。

接口：

```text
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName CancelPress
public static readonly Godot.StringName Init
public static readonly Godot.StringName RecalculateBar
public static readonly Godot.StringName StartPress
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NEndTurnLongPressBar+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.ColorRect+PropertyName`。

接口：

```text
public static readonly Godot.StringName _enabled
public static readonly Godot.StringName _endTurnButton
public static readonly Godot.StringName _isPressed
public static readonly Godot.StringName _outline
public static readonly Godot.StringName _pressTimer
public static readonly Godot.StringName _tween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NEndTurnLongPressBar+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.ColorRect+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NEnemyTurnBanner

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.addons.mega_text.MegaLabel _label
private static readonly System.String _scenePath
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task Display()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Combat.NEnemyTurnBanner Create()
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NEnemyTurnBanner+<Display>d__6

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Combat.NEnemyTurnBanner <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Combat.NEnemyTurnBanner+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NEnemyTurnBanner+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _label
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NEnemyTurnBanner+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NEnergyCounter

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private static const System.Single _animDuration = 0.6
private Godot.Tween _animInTween
private Godot.Tween _animOutTween
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NParticlesContainer _backVfx
private static const System.String _darkenedMatPath = "res://materials/ui/energy_orb_dark.tres"
private MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.NParticlesContainer _frontVfx
private static readonly Godot.Vector2 _hidePosition
private MegaCrit.Sts2.Core.HoverTips.HoverTip _hoverTip
private MegaCrit.Sts2.addons.mega_text.MegaLabel _label
private Godot.Control _layers
private MegaCrit.Sts2.Core.Entities.Players.Player _player
private Godot.Control _rotationLayers
private static readonly Godot.Vector2 _showPosition
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
Godot.Color OutlineColor { private get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private Godot.Color get_OutlineColor()
private System.Void OnCombatStateChanged(MegaCrit.Sts2.Core.Combat.CombatState combatState)
private System.Void OnEnergyChanged(System.Int32 oldEnergy, System.Int32 newEnergy)
private System.Void OnHovered()
private System.Void OnUnhovered()
private System.Void RefreshLabel()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Combat.NEnergyCounter Create(MegaCrit.Sts2.Core.Entities.Players.Player player)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Void AnimIn()
public System.Void AnimOut()
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NEnergyCounter+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AnimIn
public static readonly Godot.StringName AnimOut
public static readonly Godot.StringName OnEnergyChanged
public static readonly Godot.StringName OnHovered
public static readonly Godot.StringName OnUnhovered
public static readonly Godot.StringName RefreshLabel
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NEnergyCounter+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _animInTween
public static readonly Godot.StringName _animOutTween
public static readonly Godot.StringName _backVfx
public static readonly Godot.StringName _frontVfx
public static readonly Godot.StringName _label
public static readonly Godot.StringName _layers
public static readonly Godot.StringName _rotationLayers
public static readonly Godot.StringName OutlineColor
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NEnergyCounter+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NExhaustPileButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Combat.NCombatCardPile`。

接口：`System.IDisposable`

```text
private static readonly Godot.Vector2 _hideOffset
private Godot.Vector2 _posOffset
private Godot.Viewport _viewport
System.String[] Hotkeys { protected virtual get; }
MegaCrit.Sts2.Core.Entities.Cards.PileType Pile { protected virtual get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual MegaCrit.Sts2.Core.Entities.Cards.PileType get_Pile()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.String[] get_Hotkeys()
protected virtual System.Void AddCard()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SetAnimInOutPositions()
public virtual System.Void _Ready()
public virtual System.Void AnimIn()
public virtual System.Void Initialize(MegaCrit.Sts2.Core.Entities.Players.Player player)
```

## MegaCrit.Sts2.Core.Nodes.Combat.NExhaustPileButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Combat.NCombatCardPile+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AddCard
public static readonly Godot.StringName AnimIn
public static readonly Godot.StringName SetAnimInOutPositions
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NExhaustPileButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Combat.NCombatCardPile+PropertyName`。

接口：

```text
public static readonly Godot.StringName _posOffset
public static readonly Godot.StringName _viewport
public static readonly Godot.StringName Hotkeys
public static readonly Godot.StringName Pile
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NExhaustPileButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Combat.NCombatCardPile+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NHealthBar

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private static readonly Godot.Vector2 _blockAnimOffset
private Godot.Control _blockContainer
private static readonly Godot.Color _blockHpForegroundColor
private MegaCrit.Sts2.addons.mega_text.MegaLabel _blockLabel
private Godot.Control _blockOutline
private static readonly Godot.Color _blockOutlineColor
private MegaCrit.Sts2.Core.Entities.Creatures.Creature _blockTrackingCreature
private Godot.Tween _blockTween
private MegaCrit.Sts2.Core.Entities.Creatures.Creature _creature
private System.Int32 _currentHpOnLastRefresh
private static readonly Godot.Color _defaultFontColor
private static readonly Godot.Color _defaultFontOutlineColor
private Godot.Control _doomForeground
private System.Single _expectedMaxFgWidth
private static const System.Single _foregroundContainerInset = 10
private readonly MegaCrit.Sts2.Core.Localization.LocString _healthBarDead
private Godot.Control _hpForeground
private Godot.Control _hpForegroundContainer
private MegaCrit.Sts2.addons.mega_text.MegaLabel _hpLabel
private Godot.Tween _hpLabelFadeTween
private Godot.Control _hpMiddleground
private Godot.TextureRect _infinityTex
private static readonly Godot.Color _invincibleForegroundColor
private static readonly Godot.Color _invincibleOutlineColor
private System.Int32 _maxHpOnLastRefresh
private Godot.Tween _middlegroundTween
private static const System.Single _minSize = 12
private Godot.Vector2 _originalBlockPosition
private Godot.Control _poisonForeground
private static readonly Godot.Color _redForegroundColor
private Godot.Control <HpBarContainer>k__BackingField
Godot.Control HpBarContainer { public get; private set; }
System.Single MaxFgWidth { private get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Boolean IsDoomLethal(System.Int32 doomAmount, System.Int32 poisonDamage)
private System.Boolean IsPoisonLethal(System.Int32 poisonDamage)
private System.Single get_MaxFgWidth()
private System.Single GetFgWidth(System.Int32 amount, System.Single maxFgWidth)
private System.Single GetFgWidth(System.Int32 amount)
private System.Void DebugToggleVisibility()
private System.Void RefreshBlockUi()
private System.Void RefreshForeground()
private System.Void RefreshMiddleground()
private System.Void RefreshText()
private System.Void set_HpBarContainer(Godot.Control value)
private System.Void SetHpBarContainerSizeWithOffsets(Godot.Vector2 size)
private System.Void SetHpBarContainerSizeWithOffsetsImmediately(Godot.Vector2 size)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public Godot.Control get_HpBarContainer()
public System.Void AnimateInBlock(System.Int32 oldBlock, System.Int32 blockGain)
public System.Void FadeInHpLabel(System.Single duration)
public System.Void FadeOutHpLabel(System.Single duration, System.Single finalAlpha)
public System.Void RefreshValues()
public System.Void SetCreature(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public System.Void TrackBlockStatus(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public System.Void UpdateLayoutForCreatureBounds(Godot.Control bounds)
public System.Void UpdateWidthRelativeToReferenceValue(System.Single refMaxHp, System.Single refWidth)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NHealthBar+<>c__DisplayClass41_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Combat.NHealthBar <>4__this
public Godot.Vector2 size
public .ctor()
internal System.Void <SetHpBarContainerSizeWithOffsets>b__0()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NHealthBar+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AnimateInBlock
public static readonly Godot.StringName DebugToggleVisibility
public static readonly Godot.StringName FadeInHpLabel
public static readonly Godot.StringName FadeOutHpLabel
public static readonly Godot.StringName GetFgWidth
public static readonly Godot.StringName IsDoomLethal
public static readonly Godot.StringName IsPoisonLethal
public static readonly Godot.StringName RefreshBlockUi
public static readonly Godot.StringName RefreshForeground
public static readonly Godot.StringName RefreshMiddleground
public static readonly Godot.StringName RefreshText
public static readonly Godot.StringName RefreshValues
public static readonly Godot.StringName SetHpBarContainerSizeWithOffsets
public static readonly Godot.StringName SetHpBarContainerSizeWithOffsetsImmediately
public static readonly Godot.StringName UpdateLayoutForCreatureBounds
public static readonly Godot.StringName UpdateWidthRelativeToReferenceValue
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NHealthBar+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _blockContainer
public static readonly Godot.StringName _blockLabel
public static readonly Godot.StringName _blockOutline
public static readonly Godot.StringName _blockTween
public static readonly Godot.StringName _currentHpOnLastRefresh
public static readonly Godot.StringName _doomForeground
public static readonly Godot.StringName _expectedMaxFgWidth
public static readonly Godot.StringName _hpForeground
public static readonly Godot.StringName _hpForegroundContainer
public static readonly Godot.StringName _hpLabel
public static readonly Godot.StringName _hpLabelFadeTween
public static readonly Godot.StringName _hpMiddleground
public static readonly Godot.StringName _infinityTex
public static readonly Godot.StringName _maxHpOnLastRefresh
public static readonly Godot.StringName _middlegroundTween
public static readonly Godot.StringName _originalBlockPosition
public static readonly Godot.StringName _poisonForeground
public static readonly Godot.StringName HpBarContainer
public static readonly Godot.StringName MaxFgWidth
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NHealthBar+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NIntent

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private static const System.Int32 _animationFps = 15
private System.Nullable<System.Int32> _animationFrame
private readonly System.Collections.Generic.List<Godot.Texture2D> _animationFrames
private System.String _animationName
private static const System.Single _bobDistance = 10
private static const System.Single _bobOffset = 8
private static const System.Single _bobSpeed = 3.1415927
private MegaCrit.Sts2.Core.Nodes.Rooms.NCombatRoom _combatRoom
private MegaCrit.Sts2.Core.MonsterMoves.Intents.AbstractIntent _intent
private Godot.Control _intentHolder
private Godot.CpuParticles2D _intentParticle
private Godot.Sprite2D _intentSprite
private System.Boolean _isFrozen
private MegaCrit.Sts2.Core.Entities.Creatures.Creature _owner
private static const System.String _scenePath = "res://scenes/combat/intent.tscn"
private System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature> _targets
private System.Single _timeAccumulator
private System.Single _timeOffset
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _valueLabel
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void DebugToggleVisibility()
private System.Void OnCombatStateChanged(MegaCrit.Sts2.Core.Combat.CombatState _)
private System.Void OnHovered()
private System.Void OnUnhovered()
private System.Void UpdateVisuals()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Combat.NIntent Create(System.Single startTime)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Void PlayPerform()
public System.Void SetFrozen(System.Boolean isFrozen)
public System.Void UpdateIntent(MegaCrit.Sts2.Core.MonsterMoves.Intents.AbstractIntent intent, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature> targets, MegaCrit.Sts2.Core.Entities.Creatures.Creature owner)
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NIntent+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName DebugToggleVisibility
public static readonly Godot.StringName OnHovered
public static readonly Godot.StringName OnUnhovered
public static readonly Godot.StringName PlayPerform
public static readonly Godot.StringName SetFrozen
public static readonly Godot.StringName UpdateVisuals
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NIntent+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _animationName
public static readonly Godot.StringName _combatRoom
public static readonly Godot.StringName _intentHolder
public static readonly Godot.StringName _intentParticle
public static readonly Godot.StringName _intentSprite
public static readonly Godot.StringName _isFrozen
public static readonly Godot.StringName _timeAccumulator
public static readonly Godot.StringName _timeOffset
public static readonly Godot.StringName _valueLabel
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NIntent+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NMouseCardPlay

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Combat.NCardPlay`。

接口：`System.IDisposable`

```text
private System.Threading.CancellationTokenSource _cancellationTokenSource
private Godot.StringName _cancelShortcut
private static const System.Single _cancelZoneScreenProportion = 0.95
private System.Single _dragStartYPosition
private static const System.Single _fakeLowerEnterPlayZoneDistance = 100
private static const System.Single _fakeUpperEnterPlayZoneDistance = 50
private System.Boolean _hasLeftCardCancelZoneOnce
private System.Boolean _isLeftMouseDown
private Godot.Callable _onCreatureHoverCallable
private Godot.Callable _onCreatureUnhoverCallable
private static const System.Single _playZoneScreenProportion = 0.75
private System.Boolean _signalsConnected
private System.Boolean _skipStartCardDrag
private MegaCrit.Sts2.Core.Entities.Creatures.Creature _target
System.Single CancelZoneThreshold { private get; }
System.Single PlayZoneThreshold { private get; }
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task LerpToMouse(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder cardHolder)
private [async] System.Threading.Tasks.Task MultiCreatureTargeting(MegaCrit.Sts2.Core.Nodes.Combat.TargetMode targetMode)
private [async] System.Threading.Tasks.Task SingleCreatureTargeting(MegaCrit.Sts2.Core.Nodes.Combat.TargetMode targetMode, MegaCrit.Sts2.Core.Entities.Cards.TargetType targetType)
private [async] System.Threading.Tasks.Task StartAsync()
private [async] System.Threading.Tasks.Task StartCardDrag()
private [async] System.Threading.Tasks.Task TargetSelection(MegaCrit.Sts2.Core.Nodes.Combat.TargetMode targetMode)
private System.Boolean <MultiCreatureTargeting>b__28_0()
private System.Boolean <MultiCreatureTargeting>b__28_1()
private System.Boolean <SingleCreatureTargeting>b__26_0()
private System.Boolean IsCardInCancelZone()
private System.Boolean IsCardInPlayZone()
private System.Single get_CancelZoneThreshold()
private System.Single get_PlayZoneThreshold()
private System.Void DisconnectTargetingSignals()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnCancelPlayCard()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Combat.NMouseCardPlay Create(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder holder, Godot.StringName cancelShortcut, System.Boolean wasStartedWithShortcut)
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Input(Godot.InputEvent inputEvent)
public virtual System.Void Start()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NMouseCardPlay+<LerpToMouse>d__30

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Combat.NMouseCardPlay <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
public MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder cardHolder
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Combat.NMouseCardPlay+<MultiCreatureTargeting>d__28

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Combat.NMouseCardPlay <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Boolean <isShowingTargetingVisuals>5__2
private System.Func<System.Boolean> <shouldFinishTargeting>5__3
public MegaCrit.Sts2.Core.Nodes.Combat.TargetMode targetMode
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Combat.NMouseCardPlay+<SingleCreatureTargeting>d__26

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Combat.NMouseCardPlay <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<Godot.Node> <>u__1
public MegaCrit.Sts2.Core.Nodes.Combat.TargetMode targetMode
public MegaCrit.Sts2.Core.Entities.Cards.TargetType targetType
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Combat.NMouseCardPlay+<StartAsync>d__23

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Combat.NMouseCardPlay <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Combat.NMouseCardPlay+<StartCardDrag>d__24

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Combat.NMouseCardPlay <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Combat.NMouseCardPlay+<TargetSelection>d__25

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Combat.NMouseCardPlay <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.Nodes.Combat.TargetMode targetMode
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Combat.NMouseCardPlay+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Combat.NCardPlay+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Input
public static readonly Godot.StringName Create
public static readonly Godot.StringName DisconnectTargetingSignals
public static readonly Godot.StringName IsCardInCancelZone
public static readonly Godot.StringName IsCardInPlayZone
public static readonly Godot.StringName OnCancelPlayCard
public static readonly Godot.StringName Start
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NMouseCardPlay+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Combat.NCardPlay+PropertyName`。

接口：

```text
public static readonly Godot.StringName _cancelShortcut
public static readonly Godot.StringName _dragStartYPosition
public static readonly Godot.StringName _hasLeftCardCancelZoneOnce
public static readonly Godot.StringName _isLeftMouseDown
public static readonly Godot.StringName _onCreatureHoverCallable
public static readonly Godot.StringName _onCreatureUnhoverCallable
public static readonly Godot.StringName _signalsConnected
public static readonly Godot.StringName _skipStartCardDrag
public static readonly Godot.StringName CancelZoneThreshold
public static readonly Godot.StringName PlayZoneThreshold
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NMouseCardPlay+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Combat.NCardPlay+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NPeekButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private Godot.TextureRect _flash
private readonly System.Collections.Generic.List<Godot.Control> _hiddenTargets
private Godot.Tween _hoverTween
private MegaCrit.Sts2.Core.Nodes.Screens.Overlays.IOverlayScreen _overlayScreenParent
private static readonly Godot.StringName _pulseStrength
private readonly System.Collections.Generic.List<Godot.Control> _targets
private Godot.Control _visuals
private Godot.Tween _wiggleTween
private Godot.Marker2D <CurrentCardMarker>k__BackingField
private System.Boolean <IsPeeking>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Combat.NPeekButton+ToggledEventHandler backing_Toggled
Godot.Marker2D CurrentCardMarker { public get; private set; }
System.String[] Hotkeys { protected virtual get; }
System.Boolean IsPeeking { public get; private set; }
event MegaCrit.Sts2.Core.Nodes.Combat.NPeekButton+ToggledEventHandler Toggled
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotSignalList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void <Wiggle>b__23_0(System.Single t)
private System.Void <Wiggle>b__23_1(System.Single t)
private System.Void OnCombatRoomReady()
private System.Void OnOverlayStackChanged()
private System.Void set_CurrentCardMarker(Godot.Marker2D value)
private System.Void set_IsPeeking(System.Boolean value)
protected System.Void EmitSignalToggled(MegaCrit.Sts2.Core.Nodes.Combat.NPeekButton peekButton)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean HasGodotClassSignal(in Godot.NativeInterop.godot_string_name signal)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.String[] get_Hotkeys()
protected virtual System.Void OnDisable()
protected virtual System.Void OnEnable()
protected virtual System.Void OnFocus()
protected virtual System.Void OnPress()
protected virtual System.Void OnRelease()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RaiseGodotClassSignalCallbacks(in Godot.NativeInterop.godot_string_name signal, Godot.NativeInterop.NativeVariantPtrArgs args)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public Godot.Marker2D get_CurrentCardMarker()
public System.Boolean get_IsPeeking()
public System.Void add_Toggled(MegaCrit.Sts2.Core.Nodes.Combat.NPeekButton+ToggledEventHandler value)
public System.Void AddTargets(params Godot.Control[] targets)
public System.Void remove_Toggled(MegaCrit.Sts2.Core.Nodes.Combat.NPeekButton+ToggledEventHandler value)
public System.Void SetPeeking(System.Boolean isPeeking)
public System.Void Wiggle()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NPeekButton+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Combat.NPeekButton+<>c <>9
public static System.Func<Godot.Control, System.Boolean> <>9__25_0
private static .cctor()
public .ctor()
internal System.Boolean <SetPeeking>b__25_0(Godot.Control t)
```

## MegaCrit.Sts2.Core.Nodes.Combat.NPeekButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AddTargets
public static readonly Godot.StringName OnCombatRoomReady
public static readonly Godot.StringName OnDisable
public static readonly Godot.StringName OnEnable
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnOverlayStackChanged
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName SetPeeking
public static readonly Godot.StringName Wiggle
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NPeekButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _flash
public static readonly Godot.StringName _hoverTween
public static readonly Godot.StringName _visuals
public static readonly Godot.StringName _wiggleTween
public static readonly Godot.StringName CurrentCardMarker
public static readonly Godot.StringName Hotkeys
public static readonly Godot.StringName IsPeeking
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NPeekButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public static readonly Godot.StringName Toggled
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NPeekButton+ToggledEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(MegaCrit.Sts2.Core.Nodes.Combat.NPeekButton peekButton, System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke(MegaCrit.Sts2.Core.Nodes.Combat.NPeekButton peekButton)
```

## MegaCrit.Sts2.Core.Nodes.Combat.NPingButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private static const System.Double _flyInOutDuration = 0.5
private static readonly Godot.Vector2 _hidePosRatio
private Godot.Tween _hoverTween
private Godot.ShaderMaterial _hsv
private Godot.TextureRect _image
private MegaCrit.Sts2.addons.mega_text.MegaLabel _label
private Godot.Tween _positionTween
private System.Threading.CancellationTokenSource _showCancelTokenSource
private static readonly Godot.Vector2 _showPosRatio
private MegaCrit.Sts2.Core.Nodes.Combat.NPingButton+State _state
private static readonly Godot.StringName _v
private Godot.Viewport _viewport
private Godot.Control _visuals
Godot.Vector2 HidePos { private get; }
System.String[] Hotkeys { protected virtual get; }
Godot.Vector2 ShowPos { private get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task AnimInAfterDelay()
private Godot.Vector2 get_HidePos()
private Godot.Vector2 get_ShowPos()
private System.Void AfterPlayerEndedTurn(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Boolean _)
private System.Void AfterPlayerUnendedTurn(MegaCrit.Sts2.Core.Entities.Players.Player player)
private System.Void AnimIn()
private System.Void AnimOut()
private System.Void OnAboutToSwitchToEnemyTurn(MegaCrit.Sts2.Core.Combat.CombatState _)
private System.Void SetState(MegaCrit.Sts2.Core.Nodes.Combat.NPingButton+State newState)
private System.Void UpdateShaderV(System.Single value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.String[] get_Hotkeys()
protected virtual System.Void OnDisable()
protected virtual System.Void OnEnable()
protected virtual System.Void OnFocus()
protected virtual System.Void OnPress()
protected virtual System.Void OnRelease()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void OnCombatEnded()
public System.Void RefreshEnabled()
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NPingButton+<AnimInAfterDelay>d__24

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Combat.NPingButton <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Combat.NPingButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AnimIn
public static readonly Godot.StringName AnimOut
public static readonly Godot.StringName OnCombatEnded
public static readonly Godot.StringName OnDisable
public static readonly Godot.StringName OnEnable
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName RefreshEnabled
public static readonly Godot.StringName SetState
public static readonly Godot.StringName UpdateShaderV
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NPingButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _hoverTween
public static readonly Godot.StringName _hsv
public static readonly Godot.StringName _image
public static readonly Godot.StringName _label
public static readonly Godot.StringName _positionTween
public static readonly Godot.StringName _state
public static readonly Godot.StringName _viewport
public static readonly Godot.StringName _visuals
public static readonly Godot.StringName HidePos
public static readonly Godot.StringName Hotkeys
public static readonly Godot.StringName ShowPos
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NPingButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NPingButton+State

类型属性：`NestedPrivate, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Nodes.Combat.NPingButton+State Disabled = 1
public static const MegaCrit.Sts2.Core.Nodes.Combat.NPingButton+State Enabled = 0
public static const MegaCrit.Sts2.Core.Nodes.Combat.NPingButton+State Hidden = 2
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Nodes.Combat.NPlayerHand

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private Godot.Tween _animEnableTween
private Godot.Tween _animInTween
private Godot.Tween _animOutTween
private MegaCrit.Sts2.Core.Combat.CombatState _combatState
private MegaCrit.Sts2.Core.Nodes.Combat.NCardPlay _currentCardPlay
private MegaCrit.Sts2.Core.Nodes.Combat.NPlayerHand+Mode _currentMode
private System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> _currentSelectionFilter
private static readonly Godot.Color _disableModulate
private static readonly Godot.Vector2 _disablePosition
private System.Int32 _draggedHolderIndex
private static const System.Double _enableDisableDuration = 0.2
private static readonly Godot.Vector2 _hidePosition
private readonly System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder> _holdersAwaitingQueue
private System.Boolean _isDisabled
private System.Int32 _lastFocusedHolderIdx
private MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs _prefs
private Godot.StringName[] _selectCardShortcuts
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.CardModel> _selectedCards
private Godot.Tween _selectedCardScaleTween
private MegaCrit.Sts2.Core.Nodes.Combat.NSelectedHandCardContainer _selectedHandCardContainer
private System.Threading.Tasks.TaskCompletionSource<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> _selectionCompletionSource
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _selectionHeader
private Godot.Control _selectModeBackstop
private MegaCrit.Sts2.Core.Nodes.CommonUi.NConfirmButton _selectModeConfirmButton
private static const System.Single _showHideAnimDuration = 0.8
private static readonly Godot.Vector2 _showPosition
private MegaCrit.Sts2.Core.Nodes.Cards.NUpgradePreview _upgradePreview
private Godot.Control _upgradePreviewContainer
private Godot.Control <CardHolderContainer>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder <FocusedHolder>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Combat.NPeekButton <PeekButton>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Combat.NPlayerHand+ModeChangedEventHandler backing_ModeChanged
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder> ActiveHolders { public get; }
Godot.Control CardHolderContainer { public get; private set; }
MegaCrit.Sts2.Core.Nodes.Combat.NPlayerHand+Mode CurrentMode { public get; private set; }
Godot.Control DefaultFocusedControl { public get; }
MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder FocusedHolder { public get; private set; }
System.Boolean HasDraggedHolder { private get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder> Holders { private get; }
System.Boolean InCardPlay { public get; }
MegaCrit.Sts2.Core.Nodes.Combat.NPlayerHand Instance { public static get; }
System.Boolean IsInCardSelection { public get; }
MegaCrit.Sts2.Core.Nodes.Combat.NPeekButton PeekButton { public get; private set; }
System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> SelectModeGoldGlowOverride { public get; }
event MegaCrit.Sts2.Core.Nodes.Combat.NPlayerHand+ModeChangedEventHandler ModeChanged
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotSignalList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Boolean AreCardActionsAllowed()
private System.Boolean CanPlayCards()
private System.Boolean get_HasDraggedHolder()
private System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder> get_Holders()
private System.Int32 GetHandInsertIndex(MegaCrit.Sts2.Core.Models.CardModel card)
private System.Void <_Ready>b__59_0()
private System.Void AddCardHolder(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder holder, System.Int32 index)
private System.Void AfterCardsSelected(MegaCrit.Sts2.Core.Models.AbstractModel source)
private System.Void AnimDisable()
private System.Void AnimEnable()
private System.Void CancelHandSelectionIfNecessary()
private System.Void CheckIfSelectionComplete()
private System.Void OnCardDeselected(Godot.Node _)
private System.Void OnCardSelected(Godot.Node _)
private System.Void OnCombatEnded(MegaCrit.Sts2.Core.Rooms.CombatRoom _)
private System.Void OnCombatStateChanged(MegaCrit.Sts2.Core.Combat.CombatState state)
private System.Void OnHolderFocused(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder holder)
private System.Void OnHolderPressed(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder holder)
private System.Void OnHolderUnfocused(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder holder)
private System.Void OnPeekButtonToggled(MegaCrit.Sts2.Core.Nodes.Combat.NPeekButton button)
private System.Void OnPlayerActionsDisabledChanged(MegaCrit.Sts2.Core.Combat.CombatState state)
private System.Void OnPlayerUnendedTurn(MegaCrit.Sts2.Core.Entities.Players.Player player)
private System.Void OnSelectModeConfirmButtonPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OnSelectModeSourceFinished(MegaCrit.Sts2.Core.Models.AbstractModel source)
private System.Void RefreshLayout()
private System.Void RefreshSelectModeConfirmButton()
private System.Void ReturnHolderToHand(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder holder)
private System.Void RevalidateSelectionAfterStateChange()
private System.Void SelectCardInSimpleMode(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder holder)
private System.Void SelectCardInUpgradeMode(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder holder)
private System.Void set_CardHolderContainer(Godot.Control value)
private System.Void set_CurrentMode(MegaCrit.Sts2.Core.Nodes.Combat.NPlayerHand+Mode value)
private System.Void set_FocusedHolder(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder value)
private System.Void set_PeekButton(MegaCrit.Sts2.Core.Nodes.Combat.NPeekButton value)
private System.Void StartCardPlay(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder holder, System.Boolean startedViaShortcut)
private System.Void UpdateHandDisabledState(MegaCrit.Sts2.Core.Combat.ICombatState state)
private System.Void UpdateSelectedCardContainer(System.Int32 count)
private System.Void UpdateSelectModeCardVisibility()
protected System.Void EmitSignalModeChanged()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean HasGodotClassSignal(in Godot.NativeInterop.godot_string_name signal)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RaiseGodotClassSignalCallbacks(in Godot.NativeInterop.godot_string_name signal, Godot.NativeInterop.NativeVariantPtrArgs args)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public [async] System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> SelectCards(MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs prefs, System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> filter, MegaCrit.Sts2.Core.Models.AbstractModel source, MegaCrit.Sts2.Core.Nodes.Combat.NPlayerHand+Mode mode = 2)
public Godot.Control get_CardHolderContainer()
public Godot.Control get_DefaultFocusedControl()
public MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder GetCardHolder(MegaCrit.Sts2.Core.Models.CardModel card)
public MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder Add(MegaCrit.Sts2.Core.Nodes.Cards.NCard card, System.Int32 index = -1)
public MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder get_FocusedHolder()
public MegaCrit.Sts2.Core.Nodes.Cards.NCard GetCard(MegaCrit.Sts2.Core.Models.CardModel card)
public MegaCrit.Sts2.Core.Nodes.Combat.NPeekButton get_PeekButton()
public MegaCrit.Sts2.Core.Nodes.Combat.NPlayerHand+Mode get_CurrentMode()
public static MegaCrit.Sts2.Core.Nodes.Combat.NPlayerHand get_Instance()
public System.Boolean get_InCardPlay()
public System.Boolean get_IsInCardSelection()
public System.Boolean IsAwaitingPlay(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder holder)
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder> get_ActiveHolders()
public System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> get_SelectModeGoldGlowOverride()
public System.Void add_ModeChanged(MegaCrit.Sts2.Core.Nodes.Combat.NPlayerHand+ModeChangedEventHandler value)
public System.Void AnimIn()
public System.Void AnimOut()
public System.Void CancelAllCardPlay()
public System.Void DeselectCard(MegaCrit.Sts2.Core.Nodes.Cards.NCard card)
public System.Void DisableControllerNavigation()
public System.Void EnableControllerNavigation()
public System.Void FlashPlayableHolders()
public System.Void ForceRefreshCardIndices()
public System.Void remove_ModeChanged(MegaCrit.Sts2.Core.Nodes.Combat.NPlayerHand+ModeChangedEventHandler value)
public System.Void Remove(MegaCrit.Sts2.Core.Models.CardModel card)
public System.Void RemoveCardHolder(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder holder)
public System.Void TryCancelCardPlay(MegaCrit.Sts2.Core.Models.CardModel card)
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
public virtual System.Void _UnhandledInput(Godot.InputEvent input)
```

## MegaCrit.Sts2.Core.Nodes.Combat.NPlayerHand+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Combat.NPlayerHand+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder, System.Boolean> <>9__56_0
public static System.Func<MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder, System.Boolean> <>9__68_0
public static System.Func<MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder, MegaCrit.Sts2.Core.Models.CardModel> <>9__68_1
private static .cctor()
public .ctor()
internal MegaCrit.Sts2.Core.Models.CardModel <GetHandInsertIndex>b__68_1(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder holder)
internal System.Boolean <get_ActiveHolders>b__56_0(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder child)
internal System.Boolean <GetHandInsertIndex>b__68_0(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder holder)
```

## MegaCrit.Sts2.Core.Nodes.Combat.NPlayerHand+<>c__DisplayClass64_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Models.CardModel card
public .ctor()
internal System.Boolean <GetCardHolder>b__0(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder h)
```

## MegaCrit.Sts2.Core.Nodes.Combat.NPlayerHand+<>c__DisplayClass90_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Combat.NPlayerHand <>4__this
public MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder holder
public .ctor()
internal System.Void <StartCardPlay>b__0(System.Boolean success)
```

## MegaCrit.Sts2.Core.Nodes.Combat.NPlayerHand+<>c__DisplayClass94_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> filter
public .ctor()
internal System.Boolean <RevalidateSelectionAfterStateChange>b__0(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder h)
```

## MegaCrit.Sts2.Core.Nodes.Combat.NPlayerHand+<SelectCards>d__83

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Combat.NPlayerHand <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> <>u__1
private Godot.Tween <tween>5__2
private System.Boolean <wasDisabled>5__3
public System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> filter
public MegaCrit.Sts2.Core.Nodes.Combat.NPlayerHand+Mode mode
public MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs prefs
public MegaCrit.Sts2.Core.Models.AbstractModel source
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Combat.NPlayerHand+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName _UnhandledInput
public static readonly Godot.StringName Add
public static readonly Godot.StringName AddCardHolder
public static readonly Godot.StringName AnimDisable
public static readonly Godot.StringName AnimEnable
public static readonly Godot.StringName AnimIn
public static readonly Godot.StringName AnimOut
public static readonly Godot.StringName AreCardActionsAllowed
public static readonly Godot.StringName CancelAllCardPlay
public static readonly Godot.StringName CancelHandSelectionIfNecessary
public static readonly Godot.StringName CanPlayCards
public static readonly Godot.StringName CheckIfSelectionComplete
public static readonly Godot.StringName DeselectCard
public static readonly Godot.StringName DisableControllerNavigation
public static readonly Godot.StringName EnableControllerNavigation
public static readonly Godot.StringName FlashPlayableHolders
public static readonly Godot.StringName ForceRefreshCardIndices
public static readonly Godot.StringName IsAwaitingPlay
public static readonly Godot.StringName OnCardDeselected
public static readonly Godot.StringName OnCardSelected
public static readonly Godot.StringName OnHolderFocused
public static readonly Godot.StringName OnHolderPressed
public static readonly Godot.StringName OnHolderUnfocused
public static readonly Godot.StringName OnPeekButtonToggled
public static readonly Godot.StringName OnSelectModeConfirmButtonPressed
public static readonly Godot.StringName RefreshLayout
public static readonly Godot.StringName RefreshSelectModeConfirmButton
public static readonly Godot.StringName RemoveCardHolder
public static readonly Godot.StringName ReturnHolderToHand
public static readonly Godot.StringName RevalidateSelectionAfterStateChange
public static readonly Godot.StringName SelectCardInSimpleMode
public static readonly Godot.StringName SelectCardInUpgradeMode
public static readonly Godot.StringName StartCardPlay
public static readonly Godot.StringName UpdateSelectedCardContainer
public static readonly Godot.StringName UpdateSelectModeCardVisibility
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NPlayerHand+Mode

类型属性：`NestedPublic, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Nodes.Combat.NPlayerHand+Mode None = 0
public static const MegaCrit.Sts2.Core.Nodes.Combat.NPlayerHand+Mode Play = 1
public static const MegaCrit.Sts2.Core.Nodes.Combat.NPlayerHand+Mode SimpleSelect = 2
public static const MegaCrit.Sts2.Core.Nodes.Combat.NPlayerHand+Mode UpgradeSelect = 3
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Nodes.Combat.NPlayerHand+ModeChangedEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NPlayerHand+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _animEnableTween
public static readonly Godot.StringName _animInTween
public static readonly Godot.StringName _animOutTween
public static readonly Godot.StringName _currentCardPlay
public static readonly Godot.StringName _currentMode
public static readonly Godot.StringName _draggedHolderIndex
public static readonly Godot.StringName _isDisabled
public static readonly Godot.StringName _lastFocusedHolderIdx
public static readonly Godot.StringName _selectCardShortcuts
public static readonly Godot.StringName _selectedCardScaleTween
public static readonly Godot.StringName _selectedHandCardContainer
public static readonly Godot.StringName _selectionHeader
public static readonly Godot.StringName _selectModeBackstop
public static readonly Godot.StringName _selectModeConfirmButton
public static readonly Godot.StringName _upgradePreview
public static readonly Godot.StringName _upgradePreviewContainer
public static readonly Godot.StringName CardHolderContainer
public static readonly Godot.StringName CurrentMode
public static readonly Godot.StringName DefaultFocusedControl
public static readonly Godot.StringName FocusedHolder
public static readonly Godot.StringName HasDraggedHolder
public static readonly Godot.StringName InCardPlay
public static readonly Godot.StringName IsInCardSelection
public static readonly Godot.StringName PeekButton
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NPlayerHand+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public static readonly Godot.StringName ModeChanged
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NPlayerTurnBanner

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.addons.mega_text.MegaLabel _label
private System.Int32 _roundNumber
private static readonly System.String _scenePath
private MegaCrit.Sts2.addons.mega_text.MegaLabel _turnLabel
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task Display()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Combat.NPlayerTurnBanner Create(System.Int32 roundNumber)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NPlayerTurnBanner+<Display>d__8

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Combat.NPlayerTurnBanner <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Combat.NPlayerTurnBanner+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NPlayerTurnBanner+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _label
public static readonly Godot.StringName _roundNumber
public static readonly Godot.StringName _turnLabel
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NPlayerTurnBanner+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NPower

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.addons.mega_text.MegaLabel _amountLabel
private Godot.Tween _animInTween
private Godot.TextureRect _icon
private MegaCrit.Sts2.Core.Models.PowerModel _model
private Godot.CpuParticles2D _powerFlash
private static readonly Godot.StringName _pulse
private MegaCrit.Sts2.Core.Nodes.Combat.NPowerContainer <Container>k__BackingField
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
MegaCrit.Sts2.Core.Nodes.Combat.NPowerContainer Container { public get; public set; }
MegaCrit.Sts2.Core.Models.PowerModel Model { public get; public set; }
System.String ScenePath { private static get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private static System.String get_ScenePath()
private System.Void FlashPower()
private System.Void OnDisplayAmountChanged()
private System.Void OnHovered()
private System.Void OnOwnerDied(MegaCrit.Sts2.Core.Entities.Creatures.Creature _)
private System.Void OnOwnerRevived(MegaCrit.Sts2.Core.Entities.Creatures.Creature _)
private System.Void OnPowerFlashed(MegaCrit.Sts2.Core.Models.PowerModel _)
private System.Void OnPowerRemoved()
private System.Void OnPulsingStarted()
private System.Void OnPulsingStopped()
private System.Void OnUnhovered()
private System.Void RefreshAmount()
private System.Void Reload()
private System.Void ShowPowerHoverTips(MegaCrit.Sts2.Core.Combat.CombatState _)
private System.Void SubscribeToModelEvents()
private System.Void UnsubscribeFromModelEvents()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public MegaCrit.Sts2.Core.Models.PowerModel get_Model()
public MegaCrit.Sts2.Core.Nodes.Combat.NPowerContainer get_Container()
public static MegaCrit.Sts2.Core.Nodes.Combat.NPower Create(MegaCrit.Sts2.Core.Models.PowerModel power)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Void set_Container(MegaCrit.Sts2.Core.Nodes.Combat.NPowerContainer value)
public System.Void set_Model(MegaCrit.Sts2.Core.Models.PowerModel value)
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NPower+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName FlashPower
public static readonly Godot.StringName OnDisplayAmountChanged
public static readonly Godot.StringName OnHovered
public static readonly Godot.StringName OnPowerRemoved
public static readonly Godot.StringName OnPulsingStarted
public static readonly Godot.StringName OnPulsingStopped
public static readonly Godot.StringName OnUnhovered
public static readonly Godot.StringName RefreshAmount
public static readonly Godot.StringName Reload
public static readonly Godot.StringName SubscribeToModelEvents
public static readonly Godot.StringName UnsubscribeFromModelEvents
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NPower+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _amountLabel
public static readonly Godot.StringName _animInTween
public static readonly Godot.StringName _icon
public static readonly Godot.StringName _powerFlash
public static readonly Godot.StringName Container
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NPower+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NPowerContainer

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Entities.Creatures.Creature _creature
private System.Nullable<Godot.Vector2> _originalPosition
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Combat.NPower> _powerNodes
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
private System.Void Add(MegaCrit.Sts2.Core.Models.PowerModel power)
private System.Void ConnectCreatureSignals()
private System.Void OnPowerApplied(MegaCrit.Sts2.Core.Models.PowerModel power)
private System.Void OnPowerRemoved(MegaCrit.Sts2.Core.Models.PowerModel power)
private System.Void Remove(MegaCrit.Sts2.Core.Models.PowerModel power)
private System.Void UpdatePositions()
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void SetCreature(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public System.Void SetCreatureBounds(Godot.Control bounds)
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NPowerContainer+<>c__DisplayClass8_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Models.PowerModel power
public .ctor()
internal System.Boolean <Remove>b__0(MegaCrit.Sts2.Core.Nodes.Combat.NPower n)
```

## MegaCrit.Sts2.Core.Nodes.Combat.NPowerContainer+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName ConnectCreatureSignals
public static readonly Godot.StringName SetCreatureBounds
public static readonly Godot.StringName UpdatePositions
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NPowerContainer+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NPowerContainer+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NRemoteTargetingIndicator

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private static const System.Single _defaultAlpha = 0.5
private Godot.Vector2 _fromPosition
private System.Boolean _isTargetingCreature
private Godot.Line2D _line
private Godot.Line2D _lineBack
private MegaCrit.Sts2.Core.Entities.Players.Player _player
private static const System.Int32 _segmentCount = 100
private static const System.Single _targetingAlpha = 1
private Godot.Vector2 _toPosition
private Godot.Tween _tween
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void DoTargetingCreatureTween(System.Boolean isTargetingCreature)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void Initialize(MegaCrit.Sts2.Core.Entities.Players.Player player)
public System.Void StartDrawingFrom(Godot.Vector2 from)
public System.Void StopDrawing()
public System.Void UpdateDrawingTo(Godot.Vector2 position)
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NRemoteTargetingIndicator+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName DoTargetingCreatureTween
public static readonly Godot.StringName StartDrawingFrom
public static readonly Godot.StringName StopDrawing
public static readonly Godot.StringName UpdateDrawingTo
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NRemoteTargetingIndicator+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _fromPosition
public static readonly Godot.StringName _isTargetingCreature
public static readonly Godot.StringName _line
public static readonly Godot.StringName _lineBack
public static readonly Godot.StringName _toPosition
public static readonly Godot.StringName _tween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NRemoteTargetingIndicator+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NSelectedHandCardContainer

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Nodes.Combat.NPlayerHand <Hand>k__BackingField
MegaCrit.Sts2.Core.Nodes.Combat.NPlayerHand Hand { public get; public set; }
System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Cards.Holders.NSelectedHandCardHolder> Holders { public get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void DeselectHolder(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder holder)
private System.Void OnFocus()
private System.Void RefreshHolderPositions()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public MegaCrit.Sts2.Core.Nodes.Cards.Holders.NSelectedHandCardHolder Add(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NHandCardHolder originalHolder)
public MegaCrit.Sts2.Core.Nodes.Combat.NPlayerHand get_Hand()
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Cards.Holders.NSelectedHandCardHolder> get_Holders()
public System.Void DeselectCard(MegaCrit.Sts2.Core.Models.CardModel card)
public System.Void set_Hand(MegaCrit.Sts2.Core.Nodes.Combat.NPlayerHand value)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NSelectedHandCardContainer+<>c__DisplayClass10_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Models.CardModel card
public .ctor()
internal System.Boolean <DeselectCard>b__0(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NSelectedHandCardHolder child)
```

## MegaCrit.Sts2.Core.Nodes.Combat.NSelectedHandCardContainer+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Add
public static readonly Godot.StringName DeselectHolder
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName RefreshHolderPositions
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NSelectedHandCardContainer+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName Hand
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NSelectedHandCardContainer+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NSelectionReticle

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private readonly System.Threading.CancellationTokenSource _cancelToken
private Godot.Tween _currentTween
private System.Boolean <IsSelected>k__BackingField
System.Boolean IsSelected { public get; private set; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void set_IsSelected(System.Boolean value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Boolean get_IsSelected()
public System.Void OnDeselect()
public System.Void OnSelect()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NSelectionReticle+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnDeselect
public static readonly Godot.StringName OnSelect
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NSelectionReticle+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _currentTween
public static readonly Godot.StringName IsSelected
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NSelectionReticle+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NStarCounter

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private System.Int32 _displayedStarCount
private MegaCrit.Sts2.Core.HoverTips.HoverTip _hoverTip
private Godot.ShaderMaterial _hsv
private Godot.Tween _hsvTween
private Godot.Control _icon
private System.Boolean _isListeningToCombatState
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _label
private System.Single _lerpingStarCount
private MegaCrit.Sts2.Core.Entities.Players.Player _player
private Godot.Control _rotationLayers
private static readonly Godot.StringName _s
private static readonly System.String _starGainVfxPath
private static readonly Godot.StringName _v
private System.Single _velocity
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void ConnectStarsChangedSignal()
private System.Void OnHovered()
private System.Void OnStarsChanged(System.Int32 oldStars, System.Int32 newStars)
private System.Void OnUnhovered()
private System.Void RefreshVisibility()
private System.Void SetStarCountText(System.Int32 stars)
private System.Void UpdateShaderV(System.Single value)
private System.Void UpdateStarCount(System.Int32 oldCount, System.Int32 newCount)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Void Initialize(MegaCrit.Sts2.Core.Entities.Players.Player player)
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NStarCounter+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName ConnectStarsChangedSignal
public static readonly Godot.StringName OnHovered
public static readonly Godot.StringName OnStarsChanged
public static readonly Godot.StringName OnUnhovered
public static readonly Godot.StringName RefreshVisibility
public static readonly Godot.StringName SetStarCountText
public static readonly Godot.StringName UpdateShaderV
public static readonly Godot.StringName UpdateStarCount
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NStarCounter+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _displayedStarCount
public static readonly Godot.StringName _hsv
public static readonly Godot.StringName _hsvTween
public static readonly Godot.StringName _icon
public static readonly Godot.StringName _isListeningToCombatState
public static readonly Godot.StringName _label
public static readonly Godot.StringName _lerpingStarCount
public static readonly Godot.StringName _rotationLayers
public static readonly Godot.StringName _velocity
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NStarCounter+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NTargetingArrow

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private Godot.Sprite2D _arrowHead
private static readonly Godot.Vector2 _arrowHeadDefaultScale
private static readonly Godot.Vector2 _arrowHeadHoverScale
private Godot.Tween _arrowHeadTween
private System.Nullable<Godot.Vector2> _currentArrowPos
private System.Boolean _followMouse
private Godot.Control _fromControl
private Godot.Vector2 _fromPos
private System.Boolean _initialized
private static readonly System.String _segmentBlockPath
private static const System.Int32 _segmentCount = 19
private static readonly System.String _segmentHeadPath
private Godot.Sprite2D[] _segments
private static const System.Single _segmentScaleEnd = 0.42
private static const System.Single _segmentScaleStart = 0.28
private Godot.Vector2 _toPosition
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
Godot.Vector2 From { private get; }
Godot.Texture2D SegmentBlock { private static get; }
Godot.Texture2D SegmentHead { private static get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private Godot.Vector2 get_From()
private static Godot.Texture2D get_SegmentBlock()
private static Godot.Texture2D get_SegmentHead()
private System.Void UpdateArrowPosition(Godot.Vector2 targetPos)
private System.Void UpdateSegments(Godot.Vector2 initialPos, Godot.Vector2 finalPos, Godot.Vector2 controlPoint)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Void SetHighlightingOff()
public System.Void SetHighlightingOn(System.Boolean isEnemy)
public System.Void StartDrawingFrom(Godot.Control control, System.Boolean usingController)
public System.Void StartDrawingFrom(Godot.Vector2 from, System.Boolean usingController)
public System.Void StopDrawing()
public System.Void UpdateDrawingTo(Godot.Vector2 position)
public virtual System.Void _ExitTree()
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NTargetingArrow+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName SetHighlightingOff
public static readonly Godot.StringName SetHighlightingOn
public static readonly Godot.StringName StartDrawingFrom
public static readonly Godot.StringName StopDrawing
public static readonly Godot.StringName UpdateArrowPosition
public static readonly Godot.StringName UpdateDrawingTo
public static readonly Godot.StringName UpdateSegments
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NTargetingArrow+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _arrowHead
public static readonly Godot.StringName _arrowHeadTween
public static readonly Godot.StringName _followMouse
public static readonly Godot.StringName _fromControl
public static readonly Godot.StringName _fromPos
public static readonly Godot.StringName _initialized
public static readonly Godot.StringName _segments
public static readonly Godot.StringName _toPosition
public static readonly Godot.StringName From
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NTargetingArrow+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NTargetManager

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node2D`。

接口：`System.IDisposable`

```text
private System.Threading.Tasks.TaskCompletionSource<Godot.Node> _completionSource
private System.Func<System.Boolean> _exitEarlyCondition
private System.Func<Godot.Node, System.Boolean> _nodeFilter
private MegaCrit.Sts2.Core.Nodes.Combat.NTargetingArrow _targetingArrow
private MegaCrit.Sts2.Core.Nodes.Combat.TargetMode _targetMode
private MegaCrit.Sts2.Core.Entities.Cards.TargetType _validTargetsType
private Godot.Node <HoveredNode>k__BackingField
private System.Int64 <LastTargetingFinishedFrame>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Combat.NTargetManager+CreatureHoveredEventHandler backing_CreatureHovered
private MegaCrit.Sts2.Core.Nodes.Combat.NTargetManager+CreatureUnhoveredEventHandler backing_CreatureUnhovered
private MegaCrit.Sts2.Core.Nodes.Combat.NTargetManager+NodeHoveredEventHandler backing_NodeHovered
private MegaCrit.Sts2.Core.Nodes.Combat.NTargetManager+NodeUnhoveredEventHandler backing_NodeUnhovered
private MegaCrit.Sts2.Core.Nodes.Combat.NTargetManager+TargetingBeganEventHandler backing_TargetingBegan
private MegaCrit.Sts2.Core.Nodes.Combat.NTargetManager+TargetingEndedEventHandler backing_TargetingEnded
Godot.Node HoveredNode { private get; private set; }
MegaCrit.Sts2.Core.Nodes.Combat.NTargetManager Instance { public static get; }
System.Boolean IsInSelection { public get; }
System.Int64 LastTargetingFinishedFrame { public get; public set; }
event MegaCrit.Sts2.Core.Nodes.Combat.NTargetManager+CreatureHoveredEventHandler CreatureHovered
event MegaCrit.Sts2.Core.Nodes.Combat.NTargetManager+CreatureUnhoveredEventHandler CreatureUnhovered
event MegaCrit.Sts2.Core.Nodes.Combat.NTargetManager+NodeHoveredEventHandler NodeHovered
event MegaCrit.Sts2.Core.Nodes.Combat.NTargetManager+NodeUnhoveredEventHandler NodeUnhovered
event MegaCrit.Sts2.Core.Nodes.Combat.NTargetManager+TargetingBeganEventHandler TargetingBegan
event MegaCrit.Sts2.Core.Nodes.Combat.NTargetManager+TargetingEndedEventHandler TargetingEnded
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotSignalList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private Godot.Node get_HoveredNode()
private System.Boolean AllowedToTargetCreature(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
private System.Void FinishTargeting(System.Boolean cancel)
private System.Void OnCombatEnded(MegaCrit.Sts2.Core.Rooms.CombatRoom _)
private System.Void OnCreatureHovered(MegaCrit.Sts2.Core.Nodes.Combat.NCreature creature)
private System.Void OnCreatureUnhovered(MegaCrit.Sts2.Core.Nodes.Combat.NCreature creature)
private System.Void set_HoveredNode(Godot.Node value)
protected System.Void EmitSignalCreatureHovered(MegaCrit.Sts2.Core.Nodes.Combat.NCreature creature)
protected System.Void EmitSignalCreatureUnhovered(MegaCrit.Sts2.Core.Nodes.Combat.NCreature creature)
protected System.Void EmitSignalNodeHovered(Godot.Node node)
protected System.Void EmitSignalNodeUnhovered(Godot.Node node)
protected System.Void EmitSignalTargetingBegan()
protected System.Void EmitSignalTargetingEnded()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean HasGodotClassSignal(in Godot.NativeInterop.godot_string_name signal)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RaiseGodotClassSignalCallbacks(in Godot.NativeInterop.godot_string_name signal, Godot.NativeInterop.NativeVariantPtrArgs args)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public [async] System.Threading.Tasks.Task<Godot.Node> SelectionFinished()
public static MegaCrit.Sts2.Core.Nodes.Combat.NTargetManager get_Instance()
public System.Boolean AllowedToTargetNode(Godot.Node node)
public System.Boolean get_IsInSelection()
public System.Int64 get_LastTargetingFinishedFrame()
public System.Void add_CreatureHovered(MegaCrit.Sts2.Core.Nodes.Combat.NTargetManager+CreatureHoveredEventHandler value)
public System.Void add_CreatureUnhovered(MegaCrit.Sts2.Core.Nodes.Combat.NTargetManager+CreatureUnhoveredEventHandler value)
public System.Void add_NodeHovered(MegaCrit.Sts2.Core.Nodes.Combat.NTargetManager+NodeHoveredEventHandler value)
public System.Void add_NodeUnhovered(MegaCrit.Sts2.Core.Nodes.Combat.NTargetManager+NodeUnhoveredEventHandler value)
public System.Void add_TargetingBegan(MegaCrit.Sts2.Core.Nodes.Combat.NTargetManager+TargetingBeganEventHandler value)
public System.Void add_TargetingEnded(MegaCrit.Sts2.Core.Nodes.Combat.NTargetManager+TargetingEndedEventHandler value)
public System.Void CancelTargeting()
public System.Void OnNodeHovered(Godot.Node node)
public System.Void OnNodeUnhovered(Godot.Node node)
public System.Void remove_CreatureHovered(MegaCrit.Sts2.Core.Nodes.Combat.NTargetManager+CreatureHoveredEventHandler value)
public System.Void remove_CreatureUnhovered(MegaCrit.Sts2.Core.Nodes.Combat.NTargetManager+CreatureUnhoveredEventHandler value)
public System.Void remove_NodeHovered(MegaCrit.Sts2.Core.Nodes.Combat.NTargetManager+NodeHoveredEventHandler value)
public System.Void remove_NodeUnhovered(MegaCrit.Sts2.Core.Nodes.Combat.NTargetManager+NodeUnhoveredEventHandler value)
public System.Void remove_TargetingBegan(MegaCrit.Sts2.Core.Nodes.Combat.NTargetManager+TargetingBeganEventHandler value)
public System.Void remove_TargetingEnded(MegaCrit.Sts2.Core.Nodes.Combat.NTargetManager+TargetingEndedEventHandler value)
public System.Void set_LastTargetingFinishedFrame(System.Int64 value)
public System.Void StartTargeting(MegaCrit.Sts2.Core.Entities.Cards.TargetType validTargetsType, Godot.Control control, MegaCrit.Sts2.Core.Nodes.Combat.TargetMode startingMode, System.Func<System.Boolean> exitEarlyCondition, System.Func<Godot.Node, System.Boolean> nodeFilter)
public System.Void StartTargeting(MegaCrit.Sts2.Core.Entities.Cards.TargetType validTargetsType, Godot.Vector2 startPosition, MegaCrit.Sts2.Core.Nodes.Combat.TargetMode startingMode, System.Func<System.Boolean> exitEarlyCondition, System.Func<Godot.Node, System.Boolean> nodeFilter)
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Input(Godot.InputEvent inputEvent)
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NTargetManager+<SelectionFinished>d__32

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Combat.NTargetManager <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Godot.Node> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<Godot.Node> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Combat.NTargetManager+CreatureHoveredEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(MegaCrit.Sts2.Core.Nodes.Combat.NCreature creature, System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke(MegaCrit.Sts2.Core.Nodes.Combat.NCreature creature)
```

## MegaCrit.Sts2.Core.Nodes.Combat.NTargetManager+CreatureUnhoveredEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(MegaCrit.Sts2.Core.Nodes.Combat.NCreature creature, System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke(MegaCrit.Sts2.Core.Nodes.Combat.NCreature creature)
```

## MegaCrit.Sts2.Core.Nodes.Combat.NTargetManager+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Input
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AllowedToTargetNode
public static readonly Godot.StringName CancelTargeting
public static readonly Godot.StringName FinishTargeting
public static readonly Godot.StringName OnCreatureHovered
public static readonly Godot.StringName OnCreatureUnhovered
public static readonly Godot.StringName OnNodeHovered
public static readonly Godot.StringName OnNodeUnhovered
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NTargetManager+NodeHoveredEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(Godot.Node node, System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke(Godot.Node node)
```

## MegaCrit.Sts2.Core.Nodes.Combat.NTargetManager+NodeUnhoveredEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(Godot.Node node, System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke(Godot.Node node)
```

## MegaCrit.Sts2.Core.Nodes.Combat.NTargetManager+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+PropertyName`。

接口：

```text
public static readonly Godot.StringName _targetingArrow
public static readonly Godot.StringName _targetMode
public static readonly Godot.StringName _validTargetsType
public static readonly Godot.StringName HoveredNode
public static readonly Godot.StringName IsInSelection
public static readonly Godot.StringName LastTargetingFinishedFrame
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NTargetManager+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node2D+SignalName`。

接口：

```text
public static readonly Godot.StringName CreatureHovered
public static readonly Godot.StringName CreatureUnhovered
public static readonly Godot.StringName NodeHovered
public static readonly Godot.StringName NodeUnhovered
public static readonly Godot.StringName TargetingBegan
public static readonly Godot.StringName TargetingEnded
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NTargetManager+TargetingBeganEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke()
```

## MegaCrit.Sts2.Core.Nodes.Combat.NTargetManager+TargetingEndedEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke()
```

## MegaCrit.Sts2.Core.Nodes.Combat.TargetMode

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Nodes.Combat.TargetMode ClickMouseToTarget = 2
public static const MegaCrit.Sts2.Core.Nodes.Combat.TargetMode Controller = 3
public static const MegaCrit.Sts2.Core.Nodes.Combat.TargetMode None = 0
public static const MegaCrit.Sts2.Core.Nodes.Combat.TargetMode ReleaseMouseToTarget = 1
public System.Int32 value__
```
