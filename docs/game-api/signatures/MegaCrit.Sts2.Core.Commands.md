# MegaCrit.Sts2.Core.Commands

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Commands.CardCmd

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static [async] System.Threading.Tasks.Task MoveToResultPileWithoutPlaying(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Models.CardModel card)
private static System.Int32 GetTotalCardsBeingPreviewed()
private static System.Int32 PileIndexSort(System.ValueTuple<MegaCrit.Sts2.Core.Entities.Cards.CardTransformation, MegaCrit.Sts2.Core.Entities.Cards.CardPile, System.Int32, MegaCrit.Sts2.Core.Models.CardModel> value1, System.ValueTuple<MegaCrit.Sts2.Core.Entities.Cards.CardTransformation, MegaCrit.Sts2.Core.Entities.Cards.CardPile, System.Int32, MegaCrit.Sts2.Core.Models.CardModel> value2)
private static System.Threading.Tasks.Task FlashRelics(MegaCrit.Sts2.Core.Nodes.Cards.NCard node, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.RelicModel> relicsToFlash)
private static System.Threading.Tasks.TaskCompletionSource PreviewInternal(MegaCrit.Sts2.Core.Models.CardModel card, System.Boolean isAddingCardsToPile, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.RelicModel> relicsToFlash = null, System.Single time = 1.2, MegaCrit.Sts2.Core.Nodes.CommonUi.CardPreviewStyle style = 1)
public static [async] System.Threading.Tasks.Task AutoPlay(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Models.CardModel card, MegaCrit.Sts2.Core.Entities.Creatures.Creature target, MegaCrit.Sts2.Core.Entities.Cards.AutoPlayType type = 1, System.Boolean skipXCapture = False, System.Boolean skipCardPileVisuals = False)
public static [async] System.Threading.Tasks.Task Discard(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Models.CardModel card)
public static [async] System.Threading.Tasks.Task Discard(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> cards)
public static [async] System.Threading.Tasks.Task DiscardAndDraw(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> cardsToDiscard, System.Int32 cardsToDraw)
public static [async] System.Threading.Tasks.Task<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult> TransformToRandom(MegaCrit.Sts2.Core.Models.CardModel original, MegaCrit.Sts2.Core.Random.Rng rng, MegaCrit.Sts2.Core.Nodes.CommonUi.CardPreviewStyle style = 1)
public static [async] System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult>> Transform(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Cards.CardTransformation> transformations, MegaCrit.Sts2.Core.Random.Rng rng, MegaCrit.Sts2.Core.Nodes.CommonUi.CardPreviewStyle style = 1)
public static [async] System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<T>> AfflictAndPreview<T>(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> cards, System.Decimal amount, MegaCrit.Sts2.Core.Nodes.CommonUi.CardPreviewStyle style = 1) where T: [None] MegaCrit.Sts2.Core.Models.AfflictionModel
public static [async] System.Threading.Tasks.Task<System.Nullable<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult>> Exhaust(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Models.CardModel card, System.Boolean causedByEthereal = False, System.Boolean skipVisuals = False)
public static [async] System.Threading.Tasks.Task<System.Nullable<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult>> Transform(MegaCrit.Sts2.Core.Models.CardModel original, MegaCrit.Sts2.Core.Models.CardModel replacement, MegaCrit.Sts2.Core.Nodes.CommonUi.CardPreviewStyle style = 1)
public static [async] System.Threading.Tasks.Task<System.Nullable<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult>> TransformTo<T>(MegaCrit.Sts2.Core.Models.CardModel original, MegaCrit.Sts2.Core.Nodes.CommonUi.CardPreviewStyle style = 1) where T: [None] MegaCrit.Sts2.Core.Models.CardModel
public static [async] System.Threading.Tasks.Task<T> Afflict<T>(MegaCrit.Sts2.Core.Models.CardModel card, System.Decimal amount) where T: [None] MegaCrit.Sts2.Core.Models.AfflictionModel
public static MegaCrit.Sts2.Core.Models.EnchantmentModel Enchant(MegaCrit.Sts2.Core.Models.EnchantmentModel enchantment, MegaCrit.Sts2.Core.Models.CardModel card, System.Decimal amount)
public static System.Threading.Tasks.Task<MegaCrit.Sts2.Core.Models.AfflictionModel> Afflict(MegaCrit.Sts2.Core.Models.AfflictionModel affliction, MegaCrit.Sts2.Core.Models.CardModel card, System.Decimal amount)
public static System.Threading.Tasks.TaskCompletionSource Preview(MegaCrit.Sts2.Core.Models.CardModel card, System.Single time = 1.2, MegaCrit.Sts2.Core.Nodes.CommonUi.CardPreviewStyle style = 1)
public static System.Void ApplyKeyword(MegaCrit.Sts2.Core.Models.CardModel card, params MegaCrit.Sts2.Core.Entities.Cards.CardKeyword[] keywords)
public static System.Void ApplySingleTurnRetain(MegaCrit.Sts2.Core.Models.CardModel card)
public static System.Void ApplySingleTurnSly(MegaCrit.Sts2.Core.Models.CardModel card)
public static System.Void ClearAffliction(MegaCrit.Sts2.Core.Models.CardModel card)
public static System.Void ClearEnchantment(MegaCrit.Sts2.Core.Models.CardModel card)
public static System.Void Downgrade(MegaCrit.Sts2.Core.Models.CardModel card)
public static System.Void Preview(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.CardModel> cards, System.Single time = 1.2, MegaCrit.Sts2.Core.Nodes.CommonUi.CardPreviewStyle style = 1)
public static System.Void PreviewCardPileAdd(MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult result, System.Single time = 1.2, MegaCrit.Sts2.Core.Nodes.CommonUi.CardPreviewStyle style = 1)
public static System.Void PreviewCardPileAdd(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult> results, System.Single time = 1.2, MegaCrit.Sts2.Core.Nodes.CommonUi.CardPreviewStyle style = 1)
public static System.Void RemoveKeyword(MegaCrit.Sts2.Core.Models.CardModel card, params MegaCrit.Sts2.Core.Entities.Cards.CardKeyword[] keywords)
public static System.Void Upgrade(MegaCrit.Sts2.Core.Models.CardModel card, MegaCrit.Sts2.Core.Nodes.CommonUi.CardPreviewStyle style = 1)
public static System.Void Upgrade(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> cards, MegaCrit.Sts2.Core.Nodes.CommonUi.CardPreviewStyle style)
public static T Enchant<T>(MegaCrit.Sts2.Core.Models.CardModel card, System.Decimal amount) where T: [None] MegaCrit.Sts2.Core.Models.EnchantmentModel
```

## MegaCrit.Sts2.Core.Commands.CardCmd+<>c__DisplayClass0_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Models.CardModel card
public .ctor()
internal System.Boolean <AutoPlay>b__0(MegaCrit.Sts2.Core.Entities.Creatures.Creature c)
```

## MegaCrit.Sts2.Core.Commands.CardCmd+<>c__DisplayClass17_0<T>

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.CardModel> cardList
public .ctor()
internal System.Boolean <AfflictAndPreview>b__0(MegaCrit.Sts2.Core.Models.CardModel c)
```

## MegaCrit.Sts2.Core.Commands.CardCmd+<>c__DisplayClass29_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.Action<System.Threading.Tasks.Task> <>9__2
public MegaCrit.Sts2.Core.Models.CardModel card
public System.Boolean isAddingCardsToPile
public MegaCrit.Sts2.Core.Nodes.Cards.NCard node
public MegaCrit.Sts2.Core.Entities.Cards.PileType pileType
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.RelicModel> relicsToFlash
public System.Threading.Tasks.TaskCompletionSource source
public .ctor()
internal System.Void <PreviewInternal>b__0()
internal System.Void <PreviewInternal>b__1()
internal System.Void <PreviewInternal>b__2(System.Threading.Tasks.Task _)
```

## MegaCrit.Sts2.Core.Commands.CardCmd+<>O

类型属性：`NestedPrivate, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static System.Comparison<System.ValueTuple<MegaCrit.Sts2.Core.Entities.Cards.CardTransformation, MegaCrit.Sts2.Core.Entities.Cards.CardPile, System.Int32, MegaCrit.Sts2.Core.Models.CardModel>> <0>__PileIndexSort
```

## MegaCrit.Sts2.Core.Commands.CardCmd+<Afflict>d__18<T>

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<T> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Models.AfflictionModel> <>u__1
public System.Decimal amount
public MegaCrit.Sts2.Core.Models.CardModel card
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CardCmd+<AfflictAndPreview>d__17<T>

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
private System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Models.CardModel> <>7__wrap2
private MegaCrit.Sts2.Core.Commands.CardCmd+<>c__DisplayClass17_0<T> <>8__1
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<T>> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<T> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
private System.Collections.Generic.List<T> <afflictions>5__2
private MegaCrit.Sts2.Core.Models.CardModel <card>5__4
public System.Decimal amount
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> cards
public MegaCrit.Sts2.Core.Nodes.CommonUi.CardPreviewStyle style
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CardCmd+<AutoPlay>d__0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
private MegaCrit.Sts2.Core.Commands.CardCmd+<>c__DisplayClass0_0 <>8__1
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult> <>u__2
private MegaCrit.Sts2.Core.Combat.ICombatState <combatState>5__2
private MegaCrit.Sts2.Core.Models.AbstractModel <preventer>5__3
public MegaCrit.Sts2.Core.Models.CardModel card
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext
public System.Boolean skipCardPileVisuals
public System.Boolean skipXCapture
public MegaCrit.Sts2.Core.Entities.Creatures.Creature target
public MegaCrit.Sts2.Core.Entities.Cards.AutoPlayType type
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CardCmd+<Discard>d__2

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.Models.CardModel card
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CardCmd+<Discard>d__3

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> cards
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CardCmd+<DiscardAndDraw>d__4

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
private System.Collections.Generic.List+Enumerator<MegaCrit.Sts2.Core.Models.CardModel> <>7__wrap5
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> <>u__3
private MegaCrit.Sts2.Core.Models.CardModel <card>5__7
private MegaCrit.Sts2.Core.Combat.ICombatState <combatState>5__3
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.CardModel> <discardCards>5__2
private MegaCrit.Sts2.Core.Entities.Cards.CardPile <discardPile>5__5
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.CardModel> <slyCards>5__4
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> cardsToDiscard
public System.Int32 cardsToDraw
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CardCmd+<Exhaust>d__6

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Nullable<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult>> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
private MegaCrit.Sts2.Core.Combat.ICombatState <combatState>5__2
private MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult <result>5__3
public MegaCrit.Sts2.Core.Models.CardModel card
public System.Boolean causedByEthereal
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext
public System.Boolean skipVisuals
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CardCmd+<MoveToResultPileWithoutPlaying>d__1

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
public MegaCrit.Sts2.Core.Models.CardModel card
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CardCmd+<Transform>d__11

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Nullable<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult>> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult>> <>u__1
public MegaCrit.Sts2.Core.Models.CardModel original
public MegaCrit.Sts2.Core.Models.CardModel replacement
public MegaCrit.Sts2.Core.Nodes.CommonUi.CardPreviewStyle style
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CardCmd+<Transform>d__13

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
private System.Collections.Generic.List+Enumerator<System.ValueTuple<MegaCrit.Sts2.Core.Entities.Cards.CardTransformation, MegaCrit.Sts2.Core.Entities.Cards.CardPile, System.Int32, MegaCrit.Sts2.Core.Models.CardModel>> <>7__wrap6
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult>> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private MegaCrit.Sts2.Core.Combat.ICombatState <combatState>5__3
private System.Int32 <i>5__13
private MegaCrit.Sts2.Core.Models.CardModel <original>5__9
private MegaCrit.Sts2.Core.Entities.Cards.CardPile <pile>5__8
private MegaCrit.Sts2.Core.Models.CardModel <replacement>5__11
private MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult <result>5__12
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult> <results>5__5
private MegaCrit.Sts2.Core.Runs.IRunState <runState>5__10
private MegaCrit.Sts2.Core.Entities.Cards.CardTransformation[] <transformationsArr>5__2
private System.Collections.Generic.List<System.ValueTuple<MegaCrit.Sts2.Core.Entities.Cards.CardTransformation, MegaCrit.Sts2.Core.Entities.Cards.CardPile, System.Int32, MegaCrit.Sts2.Core.Models.CardModel>> <transformationsWithOriginalData>5__4
private System.Collections.Generic.List<System.Threading.Tasks.Task> <vfxTasks>5__6
public MegaCrit.Sts2.Core.Random.Rng rng
public MegaCrit.Sts2.Core.Nodes.CommonUi.CardPreviewStyle style
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Cards.CardTransformation> transformations
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CardCmd+<TransformTo>d__10<T>

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Nullable<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult>> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Nullable<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult>> <>u__1
public MegaCrit.Sts2.Core.Models.CardModel original
public MegaCrit.Sts2.Core.Nodes.CommonUi.CardPreviewStyle style
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CardCmd+<TransformToRandom>d__9

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult>> <>u__1
public MegaCrit.Sts2.Core.Models.CardModel original
public MegaCrit.Sts2.Core.Random.Rng rng
public MegaCrit.Sts2.Core.Nodes.CommonUi.CardPreviewStyle style
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CardPileCmd

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static [async] System.Threading.Tasks.Task ShuffleFtueCheck()
private static [async] System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> DrawInternal(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, System.Decimal count, MegaCrit.Sts2.Core.Entities.Players.Player player, System.Boolean fromHandDraw = False)
private static Godot.Tween GetTweenForCardsChangingPiles(System.Collections.Generic.IEnumerable<System.ValueTuple<MegaCrit.Sts2.Core.Nodes.Cards.NCard, System.Nullable<MegaCrit.Sts2.Core.Entities.Cards.PileType>>> cards)
private static MegaCrit.Sts2.Core.Nodes.Cards.NCard CreateCardNodeAndUpdateVisuals(MegaCrit.Sts2.Core.Models.CardModel card, System.Nullable<MegaCrit.Sts2.Core.Entities.Cards.PileType> oldPileType, MegaCrit.Sts2.Core.Entities.Cards.PileType targetPileType, System.Boolean owningPlayerIsLocal)
private static System.Boolean CheckIfDrawIsPossibleAndShowThoughtBubbleIfNot(MegaCrit.Sts2.Core.Entities.Players.Player player)
private static System.Void AppendPileLerpTween(Godot.Tween tween, MegaCrit.Sts2.Core.Nodes.Cards.NCard cardNode, MegaCrit.Sts2.Core.Entities.Cards.PileType typePile, System.Nullable<MegaCrit.Sts2.Core.Entities.Cards.PileType> oldPile)
private static System.Void AppendPlayPileLerpTween(Godot.Tween tween, MegaCrit.Sts2.Core.Nodes.Cards.NCard cardNode, System.Nullable<MegaCrit.Sts2.Core.Entities.Cards.PileType> oldPile)
private static System.Void MoveCardNodeToNewPileBeforeTween(MegaCrit.Sts2.Core.Nodes.Cards.NCard cardNode, MegaCrit.Sts2.Core.Entities.Cards.PileType newPileType)
public static [async] System.Threading.Tasks.Task AddDuringManualCardPlay(MegaCrit.Sts2.Core.Models.CardModel card)
public static [async] System.Threading.Tasks.Task AddToCombatAndPreview<T>(MegaCrit.Sts2.Core.Entities.Creatures.Creature target, MegaCrit.Sts2.Core.Entities.Cards.PileType pileType, System.Int32 count, MegaCrit.Sts2.Core.Entities.Players.Player creator, MegaCrit.Sts2.Core.Entities.Cards.CardPilePosition position = 1) where T: [None] MegaCrit.Sts2.Core.Models.CardModel
public static [async] System.Threading.Tasks.Task AddToCombatAndPreview<T>(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature> targets, MegaCrit.Sts2.Core.Entities.Cards.PileType pileType, System.Int32 count, MegaCrit.Sts2.Core.Entities.Players.Player creator, MegaCrit.Sts2.Core.Entities.Cards.CardPilePosition position = 1) where T: [None] MegaCrit.Sts2.Core.Models.CardModel
public static [async] System.Threading.Tasks.Task AutoPlayFromDrawPile(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Players.Player player, System.Int32 count, MegaCrit.Sts2.Core.Entities.Cards.CardPilePosition position, System.Boolean forceExhaust)
public static [async] System.Threading.Tasks.Task GiveToAnotherPlayer(MegaCrit.Sts2.Core.Models.CardModel card, MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.Entities.Cards.PileType pileType, MegaCrit.Sts2.Core.Entities.Cards.CardPilePosition position = 1, MegaCrit.Sts2.Core.Models.AbstractModel clonedBy = null)
public static [async] System.Threading.Tasks.Task RemoveFromCombat(MegaCrit.Sts2.Core.Models.CardModel card, System.Boolean skipVisuals = False)
public static [async] System.Threading.Tasks.Task RemoveFromCombat(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> cards, System.Boolean skipVisuals = False)
public static [async] System.Threading.Tasks.Task RemoveFromDeck(MegaCrit.Sts2.Core.Models.CardModel card, System.Boolean showPreview = True)
public static [async] System.Threading.Tasks.Task RemoveFromDeck(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.CardModel> cards, System.Boolean showPreview = True)
public static [async] System.Threading.Tasks.Task Shuffle(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Players.Player player)
public static [async] System.Threading.Tasks.Task ShuffleIfNecessary(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Players.Player player)
public static [async] System.Threading.Tasks.Task<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult> Add(MegaCrit.Sts2.Core.Models.CardModel card, MegaCrit.Sts2.Core.Entities.Cards.CardPile newPile, MegaCrit.Sts2.Core.Entities.Cards.CardPilePosition position = 1, MegaCrit.Sts2.Core.Models.AbstractModel clonedBy = null, System.Boolean skipVisuals = False)
public static [async] System.Threading.Tasks.Task<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult> Add(MegaCrit.Sts2.Core.Models.CardModel card, MegaCrit.Sts2.Core.Entities.Cards.PileType newPileType, MegaCrit.Sts2.Core.Entities.Cards.CardPilePosition position = 1, MegaCrit.Sts2.Core.Models.AbstractModel clonedBy = null, System.Boolean skipVisuals = False)
public static [async] System.Threading.Tasks.Task<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult> AddGeneratedCardToCombat(MegaCrit.Sts2.Core.Models.CardModel card, MegaCrit.Sts2.Core.Entities.Cards.PileType newPileType, MegaCrit.Sts2.Core.Entities.Players.Player creator, MegaCrit.Sts2.Core.Entities.Cards.CardPilePosition position = 1)
public static [async] System.Threading.Tasks.Task<MegaCrit.Sts2.Core.Models.CardModel> AddCurseToDeck<T>(MegaCrit.Sts2.Core.Entities.Players.Player owner) where T: [None] MegaCrit.Sts2.Core.Models.CardModel
public static [async] System.Threading.Tasks.Task<MegaCrit.Sts2.Core.Models.CardModel> Draw(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Players.Player player)
public static [async] System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult>> AddCursesToDeck(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> curses, MegaCrit.Sts2.Core.Entities.Players.Player owner)
public static [async] System.Threading.Tasks.Task<System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult>> Add(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> cards, MegaCrit.Sts2.Core.Entities.Cards.CardPile newPile, MegaCrit.Sts2.Core.Entities.Cards.CardPilePosition position = 1, MegaCrit.Sts2.Core.Models.AbstractModel clonedBy = null, System.Boolean skipVisuals = False, System.Boolean isChangingOwners = False)
public static [async] System.Threading.Tasks.Task<System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult>> Add(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> cards, MegaCrit.Sts2.Core.Entities.Cards.PileType newPileType, MegaCrit.Sts2.Core.Entities.Cards.CardPilePosition position = 1, MegaCrit.Sts2.Core.Models.AbstractModel clonedBy = null, System.Boolean skipVisuals = False)
public static [async] System.Threading.Tasks.Task<System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult>> AddGeneratedCardsToCombat(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> cards, MegaCrit.Sts2.Core.Entities.Cards.PileType newPileType, MegaCrit.Sts2.Core.Entities.Players.Player creator, MegaCrit.Sts2.Core.Entities.Cards.CardPilePosition position = 1)
public static System.Threading.Tasks.Task DrawWithoutBlockingOnOtherPlayers(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, System.Decimal count, MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.Models.CardModel source, System.Boolean fromHandDraw = False)
public static System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> Draw(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, System.Decimal count, MegaCrit.Sts2.Core.Entities.Players.Player player, System.Boolean fromHandDraw = False)
public static System.ValueTuple<Godot.Tween, System.Boolean> GetTweenForCardsChangingPiles(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult> results, System.Boolean fromSilentAdd)
```

## MegaCrit.Sts2.Core.Commands.CardPileCmd+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Commands.CardPileCmd+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult> <>9__10_0
public static System.Func<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult, System.Boolean> <>9__10_1
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> <>9__6_0
private static .cctor()
public .ctor()
internal MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult <Add>b__10_0(MegaCrit.Sts2.Core.Models.CardModel c)
internal System.Boolean <Add>b__10_1(MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult r)
internal System.Boolean <AddGeneratedCardsToCombat>b__6_0(MegaCrit.Sts2.Core.Models.CardModel c)
```

## MegaCrit.Sts2.Core.Commands.CardPileCmd+<>c__DisplayClass1_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Cards.NCard cardNode
public .ctor()
internal System.Void <RemoveFromDeck>b__0()
```

## MegaCrit.Sts2.Core.Commands.CardPileCmd+<>c__DisplayClass11_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult> results
public .ctor()
internal System.Nullable<MegaCrit.Sts2.Core.Entities.Cards.PileType> <GetTweenForCardsChangingPiles>b__0(MegaCrit.Sts2.Core.Nodes.Cards.NCard c)
```

## MegaCrit.Sts2.Core.Commands.CardPileCmd+<>c__DisplayClass11_1

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Cards.NCard c
public .ctor()
internal System.Boolean <GetTweenForCardsChangingPiles>b__1(MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult r)
```

## MegaCrit.Sts2.Core.Commands.CardPileCmd+<>c__DisplayClass11_2

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Models.CardModel card
public .ctor()
internal System.Boolean <GetTweenForCardsChangingPiles>b__2(MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult r)
```

## MegaCrit.Sts2.Core.Commands.CardPileCmd+<>c__DisplayClass11_3

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Entities.Cards.CardPile oldPile
public MegaCrit.Sts2.Core.Entities.Cards.CardPile targetPile
public System.String trailPath
public Godot.Node vfxContainer
public .ctor()
internal System.Void <GetTweenForCardsChangingPiles>b__3()
```

## MegaCrit.Sts2.Core.Commands.CardPileCmd+<>c__DisplayClass12_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Combat.NPlayerHand handNode
public .ctor()
```

## MegaCrit.Sts2.Core.Commands.CardPileCmd+<>c__DisplayClass12_1

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Cards.NCard cardNode
public MegaCrit.Sts2.Core.Commands.CardPileCmd+<>c__DisplayClass12_0 CS$<>8__locals1
public .ctor()
internal System.Void <GetTweenForCardsChangingPiles>b__0()
internal System.Void <GetTweenForCardsChangingPiles>b__1()
internal System.Void <GetTweenForCardsChangingPiles>b__2()
internal System.Void <GetTweenForCardsChangingPiles>b__3()
```

## MegaCrit.Sts2.Core.Commands.CardPileCmd+<>c__DisplayClass12_2

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Models.CardModel card
public MegaCrit.Sts2.Core.Commands.CardPileCmd+<>c__DisplayClass12_1 CS$<>8__locals2
public MegaCrit.Sts2.Core.Entities.Cards.PileType newPileType
public System.String trailPath
public .ctor()
internal System.Void <GetTweenForCardsChangingPiles>b__4()
```

## MegaCrit.Sts2.Core.Commands.CardPileCmd+<>c__DisplayClass16_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Cards.NCard cardNode
public .ctor()
internal System.Void <AppendPlayPileLerpTween>b__0()
```

## MegaCrit.Sts2.Core.Commands.CardPileCmd+<>c__DisplayClass3_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.Boolean isInPlayQueue
public MegaCrit.Sts2.Core.Nodes.Cards.NCard node
public .ctor()
internal System.Void <RemoveFromCombat>b__0()
```

## MegaCrit.Sts2.Core.Commands.CardPileCmd+<Add>d__10

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
private System.Collections.Generic.List+Enumerator<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult> <>7__wrap6
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult>> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__2
private MegaCrit.Sts2.Core.Models.CardModel <card>5__5
private System.Int32 <i>5__3
private System.Boolean <isFullHandAdd>5__6
private MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult <result>5__4
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult> <results>5__2
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> cards
public MegaCrit.Sts2.Core.Models.AbstractModel clonedBy
public System.Boolean isChangingOwners
public MegaCrit.Sts2.Core.Entities.Cards.CardPile newPile
public MegaCrit.Sts2.Core.Entities.Cards.CardPilePosition position
public System.Boolean skipVisuals
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CardPileCmd+<Add>d__7

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult> <>u__1
public MegaCrit.Sts2.Core.Models.CardModel card
public MegaCrit.Sts2.Core.Models.AbstractModel clonedBy
public MegaCrit.Sts2.Core.Entities.Cards.PileType newPileType
public MegaCrit.Sts2.Core.Entities.Cards.CardPilePosition position
public System.Boolean skipVisuals
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CardPileCmd+<Add>d__8

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult>> <>u__1
public MegaCrit.Sts2.Core.Models.CardModel card
public MegaCrit.Sts2.Core.Models.AbstractModel clonedBy
public MegaCrit.Sts2.Core.Entities.Cards.CardPile newPile
public MegaCrit.Sts2.Core.Entities.Cards.CardPilePosition position
public System.Boolean skipVisuals
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CardPileCmd+<Add>d__9

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult>> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult>> <>u__1
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> cards
public MegaCrit.Sts2.Core.Models.AbstractModel clonedBy
public MegaCrit.Sts2.Core.Entities.Cards.PileType newPileType
public MegaCrit.Sts2.Core.Entities.Cards.CardPilePosition position
public System.Boolean skipVisuals
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CardPileCmd+<AddCursesToDeck>d__29

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
private System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Models.CardModel> <>7__wrap2
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult>> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult> <>u__1
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult> <results>5__2
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> curses
public MegaCrit.Sts2.Core.Entities.Players.Player owner
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CardPileCmd+<AddCurseToDeck>d__28<T>

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<MegaCrit.Sts2.Core.Models.CardModel> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult>> <>u__1
public MegaCrit.Sts2.Core.Entities.Players.Player owner
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CardPileCmd+<AddDuringManualCardPlay>d__13

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
private MegaCrit.Sts2.Core.Entities.Cards.CardPile <oldPile>5__2
public MegaCrit.Sts2.Core.Models.CardModel card
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CardPileCmd+<AddGeneratedCardsToCombat>d__6

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
private System.Collections.Generic.List+Enumerator<MegaCrit.Sts2.Core.Models.CardModel> <>7__wrap3
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult> <>7__wrap5
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult>> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
private MegaCrit.Sts2.Core.Models.CardModel <card>5__5
private MegaCrit.Sts2.Core.Combat.ICombatState <combatState>5__2
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult> <results>5__3
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> cards
public MegaCrit.Sts2.Core.Entities.Players.Player creator
public MegaCrit.Sts2.Core.Entities.Cards.PileType newPileType
public MegaCrit.Sts2.Core.Entities.Cards.CardPilePosition position
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CardPileCmd+<AddGeneratedCardToCombat>d__5

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult>> <>u__1
public MegaCrit.Sts2.Core.Models.CardModel card
public MegaCrit.Sts2.Core.Entities.Players.Player creator
public MegaCrit.Sts2.Core.Entities.Cards.PileType newPileType
public MegaCrit.Sts2.Core.Entities.Cards.CardPilePosition position
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CardPileCmd+<AddToCombatAndPreview>d__26<T>

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
private System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Entities.Creatures.Creature> <>7__wrap1
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public System.Int32 count
public MegaCrit.Sts2.Core.Entities.Players.Player creator
public MegaCrit.Sts2.Core.Entities.Cards.PileType pileType
public MegaCrit.Sts2.Core.Entities.Cards.CardPilePosition position
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature> targets
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CardPileCmd+<AddToCombatAndPreview>d__27<T>

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
private MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult[] <>7__wrap4
private System.Int32 <>7__wrap5
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
private System.Int32 <i>5__4
private MegaCrit.Sts2.Core.Entities.Players.Player <player>5__2
private MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult[] <statusCards>5__3
public System.Int32 count
public MegaCrit.Sts2.Core.Entities.Players.Player creator
public MegaCrit.Sts2.Core.Entities.Cards.PileType pileType
public MegaCrit.Sts2.Core.Entities.Cards.CardPilePosition position
public MegaCrit.Sts2.Core.Entities.Creatures.Creature target
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CardPileCmd+<AutoPlayFromDrawPile>d__23

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
private System.Collections.Generic.List+Enumerator<MegaCrit.Sts2.Core.Models.CardModel> <>7__wrap4
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult> <>u__2
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.CardModel> <cards>5__2
private MegaCrit.Sts2.Core.Entities.Cards.CardPile <drawPile>5__3
private System.Int32 <i>5__4
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext
public System.Int32 count
public System.Boolean forceExhaust
public MegaCrit.Sts2.Core.Entities.Players.Player player
public MegaCrit.Sts2.Core.Entities.Cards.CardPilePosition position
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CardPileCmd+<Draw>d__18

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<MegaCrit.Sts2.Core.Models.CardModel> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> <>u__1
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext
public MegaCrit.Sts2.Core.Entities.Players.Player player
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CardPileCmd+<DrawInternal>d__21

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult> <>u__2
private MegaCrit.Sts2.Core.Models.CardModel <card>5__8
private MegaCrit.Sts2.Core.Combat.ICombatState <combatState>5__2
private MegaCrit.Sts2.Core.Entities.Cards.CardPile <drawPile>5__5
private System.Int32 <drawsRequested>5__6
private MegaCrit.Sts2.Core.Entities.Cards.CardPile <hand>5__4
private System.Int32 <i>5__7
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.CardModel> <result>5__3
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext
public System.Decimal count
public System.Boolean fromHandDraw
public MegaCrit.Sts2.Core.Entities.Players.Player player
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CardPileCmd+<GiveToAnotherPlayer>d__4

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult>> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__2
private MegaCrit.Sts2.Core.Nodes.Cards.NCard <cardNode>5__2
private System.Boolean <islocalPlayerTheReceivingPlayer>5__4
private System.Nullable<MegaCrit.Sts2.Core.Entities.Cards.PileType> <oldPileType>5__3
public MegaCrit.Sts2.Core.Models.CardModel card
public MegaCrit.Sts2.Core.Models.AbstractModel clonedBy
public MegaCrit.Sts2.Core.Entities.Cards.PileType pileType
public MegaCrit.Sts2.Core.Entities.Players.Player player
public MegaCrit.Sts2.Core.Entities.Cards.CardPilePosition position
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CardPileCmd+<RemoveFromCombat>d__2

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.Models.CardModel card
public System.Boolean skipVisuals
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CardPileCmd+<RemoveFromCombat>d__3

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
private System.Collections.Generic.Dictionary+Enumerator<MegaCrit.Sts2.Core.Models.CardModel, MegaCrit.Sts2.Core.Entities.Cards.CardPile> <>7__wrap4
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
private MegaCrit.Sts2.Core.Combat.ICombatState <combatState>5__2
private MegaCrit.Sts2.Core.Models.CardModel <oldCard>5__6
private System.Collections.Generic.Dictionary<MegaCrit.Sts2.Core.Models.CardModel, MegaCrit.Sts2.Core.Entities.Cards.CardPile> <oldPiles>5__4
private MegaCrit.Sts2.Core.Runs.IRunState <runState>5__3
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> cards
public System.Boolean skipVisuals
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CardPileCmd+<RemoveFromDeck>d__0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.Models.CardModel card
public System.Boolean showPreview
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CardPileCmd+<RemoveFromDeck>d__1

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
private System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Models.CardModel> <>7__wrap1
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private MegaCrit.Sts2.Core.Models.CardModel <card>5__3
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.CardModel> cards
public System.Boolean showPreview
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CardPileCmd+<Shuffle>d__22

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
private System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult> <>7__wrap6
private System.Collections.Generic.List+Enumerator<Godot.Tween> <>7__wrap7
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult>> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__3
private System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Models.CardModel> <drawPileCards>5__4
private System.Single <randomTimeBetweenCardAdds>5__3
private System.Single <timeBetweenCardAdds>5__2
private System.Collections.Generic.List<Godot.Tween> <tweens>5__6
private System.Single <waitTimeAccumulator>5__5
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext
public MegaCrit.Sts2.Core.Entities.Players.Player player
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CardPileCmd+<ShuffleFtueCheck>d__25

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CardPileCmd+<ShuffleIfNecessary>d__24

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext
public MegaCrit.Sts2.Core.Entities.Players.Player player
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CardSelectCmd

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static readonly System.Collections.Generic.Stack<MegaCrit.Sts2.Core.TestSupport.ICardSelector> _localSelectorStack
private static readonly System.Collections.Generic.Stack<MegaCrit.Sts2.Core.TestSupport.ICardSelector> _selectorStack
MegaCrit.Sts2.Core.TestSupport.ICardSelector LocalSelector { public static get; }
MegaCrit.Sts2.Core.TestSupport.ICardSelector Selector { public static get; }
private static .cctor()
private static System.Boolean ShouldSelectLocalCard(MegaCrit.Sts2.Core.Entities.Players.Player player)
private static System.Void LogChoice(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> cards)
private static System.Void ReportSoftlock()
private static System.Void UndoEndTurnIfNecessary(MegaCrit.Sts2.Core.Entities.Players.Player player)
public static [async] System.Threading.Tasks.Task<MegaCrit.Sts2.Core.Models.CardModel> FromChooseACardScreen(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext context, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.CardModel> cards, MegaCrit.Sts2.Core.Entities.Players.Player player, System.Boolean canSkip = False)
public static [async] System.Threading.Tasks.Task<MegaCrit.Sts2.Core.Models.CardModel> FromHandForUpgrade(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext context, MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.Models.AbstractModel source)
public static [async] System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> FromChooseABundleScreen(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Collections.Generic.IReadOnlyList<System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.CardModel>> bundles)
public static [async] System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> FromCombatPile(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext context, MegaCrit.Sts2.Core.Entities.Cards.CardPile pile, MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs prefs, System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> filter)
public static [async] System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> FromCombatPile(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext context, MegaCrit.Sts2.Core.Entities.Cards.CardPile pile, MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs prefs)
public static [async] System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> FromDeckForEnchantment(MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.Models.EnchantmentModel enchantment, System.Int32 amount, MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs prefs)
public static [async] System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> FromDeckForEnchantment(MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.Models.EnchantmentModel enchantment, System.Int32 amount, System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> additionalFilter, MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs prefs)
public static [async] System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> FromDeckForEnchantment(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.CardModel> cards, MegaCrit.Sts2.Core.Models.EnchantmentModel enchantment, System.Int32 amount, MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs prefs)
public static [async] System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> FromDeckForTransformation(MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs prefs, System.Func<MegaCrit.Sts2.Core.Models.CardModel, MegaCrit.Sts2.Core.Entities.Cards.CardTransformation> cardToTransformation = null)
public static [async] System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> FromDeckForUpgrade(MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs prefs)
public static [async] System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> FromDeckGeneric(MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs prefs, System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> filter = null, System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Int32> sortingOrder = null)
public static [async] System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> FromHand(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext context, MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs prefs, System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> filter, MegaCrit.Sts2.Core.Models.AbstractModel source)
public static [async] System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> FromHandForDiscard(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext context, MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs prefs, System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> filter, MegaCrit.Sts2.Core.Models.AbstractModel source)
public static [async] System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> FromSimpleGrid(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext context, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.CardModel> cardsIn, MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs prefs)
public static [async] System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> FromSimpleGridForRewards(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext context, System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Cards.CardCreationResult> cards, MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs prefs)
public static MegaCrit.Sts2.Core.TestSupport.ICardSelector get_LocalSelector()
public static MegaCrit.Sts2.Core.TestSupport.ICardSelector get_Selector()
public static System.IDisposable PushSelector(MegaCrit.Sts2.Core.TestSupport.ICardSelector selector, System.Boolean localOnly = False)
public static System.IDisposable SuspendSelectorForTest(System.Boolean localOnly = False)
public static System.IDisposable UseSelector(MegaCrit.Sts2.Core.TestSupport.ICardSelector selector, System.Boolean localOnly = False)
public static System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> FromDeckForRemoval(MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs prefs, System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> filter = null)
public static System.Void Reset()
```

## MegaCrit.Sts2.Core.Commands.CardSelectCmd+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Commands.CardSelectCmd+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Entities.Cards.CardCreationResult, MegaCrit.Sts2.Core.Models.CardModel> <>9__17_0
public static System.Func<MegaCrit.Sts2.Core.Entities.Cards.CardCreationResult, MegaCrit.Sts2.Core.Models.CardModel> <>9__17_1
public static System.Func<MegaCrit.Sts2.Core.Entities.Cards.CardCreationResult, MegaCrit.Sts2.Core.Models.CardModel> <>9__17_2
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> <>9__19_0
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, MegaCrit.Sts2.Core.Entities.Cards.CardRarity> <>9__20_0
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, MegaCrit.Sts2.Core.Models.ModelId> <>9__20_1
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, MegaCrit.Sts2.Core.Entities.Cards.CardRarity> <>9__20_2
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, MegaCrit.Sts2.Core.Models.ModelId> <>9__20_3
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> <>9__21_0
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> <>9__22_0
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, MegaCrit.Sts2.Core.Entities.Cards.CardTransformation> <>9__22_1
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Int32, <>f__AnonymousType0<MegaCrit.Sts2.Core.Models.CardModel, System.Int32>> <>9__25_1
public static System.Func<<>f__AnonymousType0<MegaCrit.Sts2.Core.Models.CardModel, System.Int32>, MegaCrit.Sts2.Core.Models.CardModel> <>9__25_2
public static System.Func<<>f__AnonymousType0<MegaCrit.Sts2.Core.Models.CardModel, System.Int32>, System.Int32> <>9__25_3
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> <>9__28_0
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> <>9__29_0
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> <>9__30_0
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> <>9__30_1
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.String> <>9__32_0
private static .cctor()
public .ctor()
internal <>f__AnonymousType0<MegaCrit.Sts2.Core.Models.CardModel, System.Int32> <FromDeckForEnchantment>b__25_1(MegaCrit.Sts2.Core.Models.CardModel card, System.Int32 index)
internal MegaCrit.Sts2.Core.Entities.Cards.CardRarity <FromCombatPile>b__20_0(MegaCrit.Sts2.Core.Models.CardModel c)
internal MegaCrit.Sts2.Core.Entities.Cards.CardRarity <FromCombatPile>b__20_2(MegaCrit.Sts2.Core.Models.CardModel c)
internal MegaCrit.Sts2.Core.Entities.Cards.CardTransformation <FromDeckForTransformation>b__22_1(MegaCrit.Sts2.Core.Models.CardModel c)
internal MegaCrit.Sts2.Core.Models.CardModel <FromDeckForEnchantment>b__25_2(<>f__AnonymousType0<MegaCrit.Sts2.Core.Models.CardModel, System.Int32> x)
internal MegaCrit.Sts2.Core.Models.CardModel <FromSimpleGridForRewards>b__17_0(MegaCrit.Sts2.Core.Entities.Cards.CardCreationResult c)
internal MegaCrit.Sts2.Core.Models.CardModel <FromSimpleGridForRewards>b__17_1(MegaCrit.Sts2.Core.Entities.Cards.CardCreationResult c)
internal MegaCrit.Sts2.Core.Models.CardModel <FromSimpleGridForRewards>b__17_2(MegaCrit.Sts2.Core.Entities.Cards.CardCreationResult c)
internal MegaCrit.Sts2.Core.Models.ModelId <FromCombatPile>b__20_1(MegaCrit.Sts2.Core.Models.CardModel c)
internal MegaCrit.Sts2.Core.Models.ModelId <FromCombatPile>b__20_3(MegaCrit.Sts2.Core.Models.CardModel c)
internal System.Boolean <FromCombatPile>b__19_0(MegaCrit.Sts2.Core.Models.CardModel _)
internal System.Boolean <FromDeckForTransformation>b__22_0(MegaCrit.Sts2.Core.Models.CardModel c)
internal System.Boolean <FromDeckForUpgrade>b__21_0(MegaCrit.Sts2.Core.Models.CardModel c)
internal System.Boolean <FromHand>b__28_0(MegaCrit.Sts2.Core.Models.CardModel _)
internal System.Boolean <FromHandForDiscard>b__29_0(MegaCrit.Sts2.Core.Models.CardModel c)
internal System.Boolean <FromHandForUpgrade>b__30_0(MegaCrit.Sts2.Core.Models.CardModel c)
internal System.Boolean <FromHandForUpgrade>b__30_1(MegaCrit.Sts2.Core.Models.CardModel c)
internal System.Int32 <FromDeckForEnchantment>b__25_3(<>f__AnonymousType0<MegaCrit.Sts2.Core.Models.CardModel, System.Int32> x)
internal System.String <LogChoice>b__32_0(MegaCrit.Sts2.Core.Models.CardModel c)
```

## MegaCrit.Sts2.Core.Commands.CardSelectCmd+<>c__DisplayClass17_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Cards.CardCreationResult> cards
public .ctor()
internal MegaCrit.Sts2.Core.Models.CardModel <FromSimpleGridForRewards>b__5(System.Int32 i)
internal System.Int32 <FromSimpleGridForRewards>b__3(MegaCrit.Sts2.Core.Models.CardModel c)
```

## MegaCrit.Sts2.Core.Commands.CardSelectCmd+<>c__DisplayClass17_1

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Models.CardModel c
public .ctor()
internal System.Boolean <FromSimpleGridForRewards>b__4(MegaCrit.Sts2.Core.Entities.Cards.CardCreationResult r)
```

## MegaCrit.Sts2.Core.Commands.CardSelectCmd+<>c__DisplayClass18_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.CardModel> cards
public .ctor()
internal MegaCrit.Sts2.Core.Models.CardModel <FromSimpleGrid>b__1(System.Int32 i)
internal System.Int32 <FromSimpleGrid>b__0(MegaCrit.Sts2.Core.Models.CardModel c)
```

## MegaCrit.Sts2.Core.Commands.CardSelectCmd+<>c__DisplayClass24_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> additionalFilter
public MegaCrit.Sts2.Core.Models.EnchantmentModel enchantment
public .ctor()
internal System.Boolean <FromDeckForEnchantment>b__0(MegaCrit.Sts2.Core.Models.CardModel c)
```

## MegaCrit.Sts2.Core.Commands.CardSelectCmd+<>c__DisplayClass25_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Models.EnchantmentModel enchantment
public .ctor()
internal System.Boolean <FromDeckForEnchantment>b__0(MegaCrit.Sts2.Core.Models.CardModel c)
```

## MegaCrit.Sts2.Core.Commands.CardSelectCmd+<>c__DisplayClass25_1

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.Collections.Generic.Dictionary<MegaCrit.Sts2.Core.Models.CardModel, System.Int32> indexMap
public .ctor()
internal System.Int32 <FromDeckForEnchantment>b__4(MegaCrit.Sts2.Core.Models.CardModel c)
```

## MegaCrit.Sts2.Core.Commands.CardSelectCmd+<>c__DisplayClass26_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.CardModel> deck
public System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> filter
public .ctor()
internal System.Boolean <FromDeckForRemoval>b__0(MegaCrit.Sts2.Core.Models.CardModel c)
internal System.Int32 <FromDeckForRemoval>b__1(MegaCrit.Sts2.Core.Models.CardModel c)
```

## MegaCrit.Sts2.Core.Commands.CardSelectCmd+<FromChooseABundleScreen>d__31

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IEnumerable<System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.CardModel>>> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult> <>u__2
private System.UInt32 <choiceId>5__2
public System.Collections.Generic.IReadOnlyList<System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.CardModel>> bundles
public MegaCrit.Sts2.Core.Entities.Players.Player player
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CardSelectCmd+<FromChooseACardScreen>d__16

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<MegaCrit.Sts2.Core.Models.CardModel> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult> <>u__3
private System.UInt32 <choiceId>5__3
private MegaCrit.Sts2.Core.Models.CardModel <result>5__2
public System.Boolean canSkip
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.CardModel> cards
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext context
public MegaCrit.Sts2.Core.Entities.Players.Player player
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CardSelectCmd+<FromCombatPile>d__19

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> <>u__1
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext context
public MegaCrit.Sts2.Core.Entities.Cards.CardPile pile
public MegaCrit.Sts2.Core.Entities.Players.Player player
public MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs prefs
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CardSelectCmd+<FromCombatPile>d__20

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> <>u__2
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult> <>u__3
private System.Nullable<System.UInt32> <choiceId>5__3
private System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> <result>5__2
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext context
public System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> filter
public MegaCrit.Sts2.Core.Entities.Cards.CardPile pile
public MegaCrit.Sts2.Core.Entities.Players.Player player
public MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs prefs
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CardSelectCmd+<FromDeckForEnchantment>d__23

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> <>u__1
public System.Int32 amount
public MegaCrit.Sts2.Core.Models.EnchantmentModel enchantment
public MegaCrit.Sts2.Core.Entities.Players.Player player
public MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs prefs
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CardSelectCmd+<FromDeckForEnchantment>d__24

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> <>u__1
public System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> additionalFilter
public System.Int32 amount
public MegaCrit.Sts2.Core.Models.EnchantmentModel enchantment
public MegaCrit.Sts2.Core.Entities.Players.Player player
public MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs prefs
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CardSelectCmd+<FromDeckForEnchantment>d__25

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult> <>u__2
private System.UInt32 <choiceId>5__3
private MegaCrit.Sts2.Core.Entities.Players.Player <player>5__2
public System.Int32 amount
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.CardModel> cards
public MegaCrit.Sts2.Core.Models.EnchantmentModel enchantment
public MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs prefs
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CardSelectCmd+<FromDeckForTransformation>d__22

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult> <>u__2
private System.UInt32 <choiceId>5__2
public System.Func<MegaCrit.Sts2.Core.Models.CardModel, MegaCrit.Sts2.Core.Entities.Cards.CardTransformation> cardToTransformation
public MegaCrit.Sts2.Core.Entities.Players.Player player
public MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs prefs
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CardSelectCmd+<FromDeckForUpgrade>d__21

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult> <>u__2
private System.UInt32 <choiceId>5__2
public MegaCrit.Sts2.Core.Entities.Players.Player player
public MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs prefs
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CardSelectCmd+<FromDeckGeneric>d__27

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult> <>u__2
private System.UInt32 <choiceId>5__2
public System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> filter
public MegaCrit.Sts2.Core.Entities.Players.Player player
public MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs prefs
public System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Int32> sortingOrder
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CardSelectCmd+<FromHand>d__28

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> <>u__2
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult> <>u__3
private System.Nullable<System.UInt32> <choiceId>5__3
private System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> <result>5__2
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext context
public System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> filter
public MegaCrit.Sts2.Core.Entities.Players.Player player
public MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs prefs
public MegaCrit.Sts2.Core.Models.AbstractModel source
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CardSelectCmd+<FromHandForDiscard>d__29

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> <>u__1
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext context
public System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> filter
public MegaCrit.Sts2.Core.Entities.Players.Player player
public MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs prefs
public MegaCrit.Sts2.Core.Models.AbstractModel source
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CardSelectCmd+<FromHandForUpgrade>d__30

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<MegaCrit.Sts2.Core.Models.CardModel> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> <>u__2
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult> <>u__3
private System.Nullable<System.UInt32> <choiceId>5__2
private MegaCrit.Sts2.Core.Models.CardModel <result>5__3
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext context
public MegaCrit.Sts2.Core.Entities.Players.Player player
public MegaCrit.Sts2.Core.Models.AbstractModel source
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CardSelectCmd+<FromSimpleGrid>d__18

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
private MegaCrit.Sts2.Core.Commands.CardSelectCmd+<>c__DisplayClass18_0 <>8__1
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> <>u__2
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult> <>u__3
private System.Nullable<System.UInt32> <choiceId>5__3
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.CardModel> <result>5__2
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.CardModel> cardsIn
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext context
public MegaCrit.Sts2.Core.Entities.Players.Player player
public MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs prefs
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CardSelectCmd+<FromSimpleGridForRewards>d__17

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
private MegaCrit.Sts2.Core.Commands.CardSelectCmd+<>c__DisplayClass17_0 <>8__1
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> <>u__2
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult> <>u__3
private System.Nullable<System.UInt32> <choiceId>5__3
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.CardModel> <result>5__2
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Cards.CardCreationResult> cards
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext context
public MegaCrit.Sts2.Core.Entities.Players.Player player
public MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs prefs
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CardSelectCmd+NoOpScope

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：`System.IDisposable`

```text
public .ctor()
public virtual System.Void Dispose()
```

## MegaCrit.Sts2.Core.Commands.CardSelectCmd+RestoreSelectorScope

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：`System.IDisposable`

```text
private System.Boolean _disposed
private readonly MegaCrit.Sts2.Core.TestSupport.ICardSelector _saved
private readonly System.Collections.Generic.Stack<MegaCrit.Sts2.Core.TestSupport.ICardSelector> _stack
public .ctor(System.Collections.Generic.Stack<MegaCrit.Sts2.Core.TestSupport.ICardSelector> stack, MegaCrit.Sts2.Core.TestSupport.ICardSelector saved)
public virtual System.Void Dispose()
```

## MegaCrit.Sts2.Core.Commands.CardSelectCmd+SelectorScope

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：`System.IDisposable`

```text
private System.Boolean _disposed
private readonly System.Collections.Generic.Stack<MegaCrit.Sts2.Core.TestSupport.ICardSelector> _stack
public .ctor(System.Collections.Generic.Stack<MegaCrit.Sts2.Core.TestSupport.ICardSelector> stack)
public virtual System.Void Dispose()
```

## MegaCrit.Sts2.Core.Commands.CardSelectCmd+StackedSelectorScope

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：`System.IDisposable`

```text
private System.Boolean _disposed
private readonly MegaCrit.Sts2.Core.TestSupport.ICardSelector _selector
private readonly System.Collections.Generic.Stack<MegaCrit.Sts2.Core.TestSupport.ICardSelector> _stack
public .ctor(System.Collections.Generic.Stack<MegaCrit.Sts2.Core.TestSupport.ICardSelector> stack, MegaCrit.Sts2.Core.TestSupport.ICardSelector selector)
public virtual System.Void Dispose()
```

## MegaCrit.Sts2.Core.Commands.Cmd

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static [async] System.Threading.Tasks.Task WaitInternal(Godot.SceneTreeTimer timer, System.Threading.CancellationToken cancellationToken)
public static [async] System.Threading.Tasks.Task CustomScaledWait(System.Single fastSeconds, System.Single standardSeconds, System.Boolean ignoreCombatEnd = False, System.Threading.CancellationToken cancellationToken = null)
public static [async] System.Threading.Tasks.Task Wait(System.Single seconds, System.Threading.CancellationToken cancelToken, System.Boolean ignoreCombatEnd = False)
public static System.Threading.Tasks.Task Wait(System.Single seconds, System.Boolean ignoreCombatEnd = False)
```

## MegaCrit.Sts2.Core.Commands.Cmd+<CustomScaledWait>d__3

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public System.Threading.CancellationToken cancellationToken
public System.Single fastSeconds
public System.Boolean ignoreCombatEnd
public System.Single standardSeconds
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.Cmd+<Wait>d__1

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public System.Threading.CancellationToken cancelToken
public System.Boolean ignoreCombatEnd
public System.Single seconds
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.Cmd+<WaitInternal>d__2

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public System.Threading.CancellationToken cancellationToken
public Godot.SceneTreeTimer timer
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CreatureCmd

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static [async] System.Threading.Tasks.Task KillWithoutCheckingWinCondition(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature, System.Boolean force, System.Int32 recursion = 0)
public static [async] System.Threading.Tasks.Task Add(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public static [async] System.Threading.Tasks.Task GainMaxHp(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature, System.Decimal amount)
public static [async] System.Threading.Tasks.Task Heal(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature, System.Decimal amount, System.Boolean playAnim = True)
public static [async] System.Threading.Tasks.Task Kill(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature, System.Boolean force = False)
public static [async] System.Threading.Tasks.Task Kill(System.Collections.Generic.IReadOnlyCollection<MegaCrit.Sts2.Core.Entities.Creatures.Creature> creatures, System.Boolean force = False)
public static [async] System.Threading.Tasks.Task LoseBlock(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Creatures.Creature target, System.Decimal amount, MegaCrit.Sts2.Core.Entities.Creatures.Creature remover)
public static [async] System.Threading.Tasks.Task LoseMaxHp(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Creatures.Creature creature, System.Decimal amount, System.Boolean isFromCard)
public static [async] System.Threading.Tasks.Task SetCurrentHp(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature, System.Decimal amount)
public static [async] System.Threading.Tasks.Task SetMaxAndCurrentHp(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature, System.Decimal amount)
public static [async] System.Threading.Tasks.Task Stun(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature, System.String nextMoveId = null)
public static [async] System.Threading.Tasks.Task TriggerAnim(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature, System.String triggerName, System.Single waitTime)
public static [async] System.Threading.Tasks.Task<MegaCrit.Sts2.Core.Entities.Creatures.Creature> Add(MegaCrit.Sts2.Core.Models.MonsterModel monster, MegaCrit.Sts2.Core.Combat.ICombatState combatState, MegaCrit.Sts2.Core.Combat.CombatSide side = 2, System.String slotName = null)
public static [async] System.Threading.Tasks.Task<MegaCrit.Sts2.Core.Entities.Creatures.Creature> Add<T>(MegaCrit.Sts2.Core.Combat.ICombatState combatState, System.String slotName = null) where T: [None] MegaCrit.Sts2.Core.Models.MonsterModel
public static [async] System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>> Damage(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Creatures.Creature target, MegaCrit.Sts2.Core.Localization.DynamicVars.DamageVar damageVar, MegaCrit.Sts2.Core.Entities.Creatures.Creature dealer, MegaCrit.Sts2.Core.Models.CardModel cardSource, MegaCrit.Sts2.Core.Entities.Cards.CardPlay cardPlay)
public static [async] System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>> Damage(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Creatures.Creature target, MegaCrit.Sts2.Core.Localization.DynamicVars.DamageVar damageVar, MegaCrit.Sts2.Core.Entities.Creatures.Creature dealer)
public static [async] System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>> Damage(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Creatures.Creature target, MegaCrit.Sts2.Core.Localization.DynamicVars.DamageVar damageVar, MegaCrit.Sts2.Core.Models.CardModel cardSource, MegaCrit.Sts2.Core.Entities.Cards.CardPlay cardPlay)
public static [async] System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>> Damage(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Creatures.Creature target, System.Decimal amount, MegaCrit.Sts2.Core.ValueProps.ValueProp props, MegaCrit.Sts2.Core.Entities.Creatures.Creature dealer, MegaCrit.Sts2.Core.Models.CardModel cardSource, MegaCrit.Sts2.Core.Entities.Cards.CardPlay cardPlay)
public static [async] System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>> Damage(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Creatures.Creature target, System.Decimal amount, MegaCrit.Sts2.Core.ValueProps.ValueProp props, MegaCrit.Sts2.Core.Entities.Creatures.Creature dealer)
public static [async] System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>> Damage(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Creatures.Creature target, System.Decimal amount, MegaCrit.Sts2.Core.ValueProps.ValueProp props, MegaCrit.Sts2.Core.Models.CardModel cardSource, MegaCrit.Sts2.Core.Entities.Cards.CardPlay cardPlay)
public static [async] System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>> Damage(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature> targets, MegaCrit.Sts2.Core.Localization.DynamicVars.DamageVar damageVar, MegaCrit.Sts2.Core.Entities.Creatures.Creature dealer, MegaCrit.Sts2.Core.Models.CardModel cardSource, MegaCrit.Sts2.Core.Entities.Cards.CardPlay cardPlay)
public static [async] System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>> Damage(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature> targets, MegaCrit.Sts2.Core.Localization.DynamicVars.DamageVar damageVar, MegaCrit.Sts2.Core.Entities.Creatures.Creature dealer)
public static [async] System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>> Damage(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature> targets, System.Decimal amount, MegaCrit.Sts2.Core.ValueProps.ValueProp props, MegaCrit.Sts2.Core.Entities.Creatures.Creature dealer, MegaCrit.Sts2.Core.Models.CardModel cardSource, MegaCrit.Sts2.Core.Entities.Cards.CardPlay cardPlay)
public static [async] System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>> Damage(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature> targets, System.Decimal amount, MegaCrit.Sts2.Core.ValueProps.ValueProp props, MegaCrit.Sts2.Core.Entities.Creatures.Creature dealer)
public static [async] System.Threading.Tasks.Task<System.Decimal> GainBlock(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature, MegaCrit.Sts2.Core.Localization.DynamicVars.BlockVar blockVar, MegaCrit.Sts2.Core.Entities.Cards.CardPlay cardPlay, System.Boolean fast = False)
public static [async] System.Threading.Tasks.Task<System.Decimal> GainBlock(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature, System.Decimal amount, MegaCrit.Sts2.Core.ValueProps.ValueProp props, MegaCrit.Sts2.Core.Entities.Cards.CardPlay cardPlay, System.Boolean fast = False)
public static [async] System.Threading.Tasks.Task<System.Decimal> SetMaxHp(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature, System.Decimal amount)
public static System.Threading.Tasks.Task Escape(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature, System.Boolean removeCreatureNode = True)
public static System.Threading.Tasks.Task Stun(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature, System.Func<System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature>, System.Threading.Tasks.Task> stunMove, System.String nextMoveId = null)
```

## MegaCrit.Sts2.Core.Commands.CreatureCmd+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Commands.CreatureCmd+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult, System.Boolean> <>9__12_1
public static System.Func<MegaCrit.Sts2.Core.Entities.Creatures.Creature, System.Boolean> <>9__14_0
public static System.Func<MegaCrit.Sts2.Core.Entities.Players.Player, System.Boolean> <>9__14_1
public static System.Func<MegaCrit.Sts2.Core.Entities.Creatures.Creature, System.Boolean> <>9__15_0
public static System.Func<MegaCrit.Sts2.Core.Entities.Creatures.Creature, System.Boolean> <>9__15_1
public static System.Func<MegaCrit.Sts2.Core.Entities.Players.Player, MegaCrit.Sts2.Core.Entities.Creatures.Creature> <>9__2_0
public static System.Func<System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature>, System.Threading.Tasks.Task> <>9__26_0
private static .cctor()
public .ctor()
internal MegaCrit.Sts2.Core.Entities.Creatures.Creature <Add>b__2_0(MegaCrit.Sts2.Core.Entities.Players.Player p)
internal System.Boolean <Damage>b__12_1(MegaCrit.Sts2.Core.Entities.Creatures.DamageResult r)
internal System.Boolean <Kill>b__14_0(MegaCrit.Sts2.Core.Entities.Creatures.Creature c)
internal System.Boolean <Kill>b__14_1(MegaCrit.Sts2.Core.Entities.Players.Player p)
internal System.Boolean <KillWithoutCheckingWinCondition>b__15_0(MegaCrit.Sts2.Core.Entities.Creatures.Creature t)
internal System.Boolean <KillWithoutCheckingWinCondition>b__15_1(MegaCrit.Sts2.Core.Entities.Creatures.Creature t)
internal System.Threading.Tasks.Task <Stun>b__26_0(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> _)
```

## MegaCrit.Sts2.Core.Commands.CreatureCmd+<>c__DisplayClass12_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.ValueProps.ValueProp props
public .ctor()
internal MegaCrit.Sts2.Core.Entities.Creatures.DamageResult <Damage>b__0(MegaCrit.Sts2.Core.Entities.Creatures.Creature t)
```

## MegaCrit.Sts2.Core.Commands.CreatureCmd+<>c__DisplayClass20_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Entities.Creatures.Creature creature
public .ctor()
internal System.Boolean <Heal>b__0(MegaCrit.Sts2.Core.Nodes.RestSite.NRestSiteCharacter c)
```

## MegaCrit.Sts2.Core.Commands.CreatureCmd+<>c__DisplayClass27_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Entities.Creatures.Creature creature
public System.Func<System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature>, System.Threading.Tasks.Task> stunMove
public .ctor()
internal [async] System.Threading.Tasks.Task <Stun>g__Wrapper|0(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> c)
```

## MegaCrit.Sts2.Core.Commands.CreatureCmd+<>c__DisplayClass27_0+<<Stun>g__Wrapper|0>d

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Commands.CreatureCmd+<>c__DisplayClass27_0 <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> c
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CreatureCmd+<>c__DisplayClass27_1

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Vfx.NStunnedVfx vfx
public Godot.Node vfxContainer
public .ctor()
internal System.Void <Stun>b__1()
```

## MegaCrit.Sts2.Core.Commands.CreatureCmd+<Add>d__0<T>

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<MegaCrit.Sts2.Core.Entities.Creatures.Creature> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private MegaCrit.Sts2.Core.Entities.Creatures.Creature <creature>5__2
public MegaCrit.Sts2.Core.Combat.ICombatState combatState
public System.String slotName
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CreatureCmd+<Add>d__1

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<MegaCrit.Sts2.Core.Entities.Creatures.Creature> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private MegaCrit.Sts2.Core.Entities.Creatures.Creature <creature>5__2
public MegaCrit.Sts2.Core.Combat.ICombatState combatState
public MegaCrit.Sts2.Core.Models.MonsterModel monster
public MegaCrit.Sts2.Core.Combat.CombatSide side
public System.String slotName
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CreatureCmd+<Add>d__2

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private MegaCrit.Sts2.Core.Combat.ICombatState <combatState>5__2
public MegaCrit.Sts2.Core.Entities.Creatures.Creature creature
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CreatureCmd+<Damage>d__10

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>> <>u__1
public System.Decimal amount
public MegaCrit.Sts2.Core.Entities.Cards.CardPlay cardPlay
public MegaCrit.Sts2.Core.Models.CardModel cardSource
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext
public MegaCrit.Sts2.Core.Entities.Creatures.Creature dealer
public MegaCrit.Sts2.Core.ValueProps.ValueProp props
public MegaCrit.Sts2.Core.Entities.Creatures.Creature target
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CreatureCmd+<Damage>d__11

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>> <>u__1
public MegaCrit.Sts2.Core.Entities.Cards.CardPlay cardPlay
public MegaCrit.Sts2.Core.Models.CardModel cardSource
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext
public MegaCrit.Sts2.Core.Localization.DynamicVars.DamageVar damageVar
public MegaCrit.Sts2.Core.Entities.Creatures.Creature dealer
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature> targets
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CreatureCmd+<Damage>d__12

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
private System.Collections.Generic.List+Enumerator<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult> <>7__wrap18
private System.Collections.Generic.List+Enumerator<MegaCrit.Sts2.Core.Entities.Creatures.Creature> <>7__wrap6
private MegaCrit.Sts2.Core.Commands.CreatureCmd+<>c__DisplayClass12_0 <>8__1
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Decimal <blockedDamage>5__10
private MegaCrit.Sts2.Core.Combat.ICombatState <combatState>5__4
private System.Int32 <damage>5__20
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult> <damageResults>5__14
private System.Collections.Generic.List<System.Threading.Tasks.Task> <hitTriggers>5__17
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Creatures.Creature> <killedCreatures>5__6
private System.Decimal <modifiedAmount>5__9
private MegaCrit.Sts2.Core.Entities.Creatures.Creature <originalTarget>5__8
private System.Decimal <originalTargetDamage>5__18
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult> <results>5__2
private MegaCrit.Sts2.Core.Runs.IRunState <runState>5__5
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Creatures.Creature> <targetList>5__3
private System.Decimal <unblockedDamage>5__11
private MegaCrit.Sts2.Core.Entities.Creatures.DamageResult <unblockedDamageResult>5__13
private MegaCrit.Sts2.Core.Entities.Creatures.Creature <unblockedDamageTarget>5__12
private System.Boolean <wasBlockBroken>5__15
private System.Boolean <wasFullyBlocked>5__16
public System.Decimal amount
public MegaCrit.Sts2.Core.Entities.Cards.CardPlay cardPlay
public MegaCrit.Sts2.Core.Models.CardModel cardSource
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext
public MegaCrit.Sts2.Core.Entities.Creatures.Creature dealer
public MegaCrit.Sts2.Core.ValueProps.ValueProp props
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature> targets
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CreatureCmd+<Damage>d__3

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>> <>u__1
public MegaCrit.Sts2.Core.Entities.Cards.CardPlay cardPlay
public MegaCrit.Sts2.Core.Models.CardModel cardSource
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext
public MegaCrit.Sts2.Core.Localization.DynamicVars.DamageVar damageVar
public MegaCrit.Sts2.Core.Entities.Creatures.Creature target
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CreatureCmd+<Damage>d__4

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>> <>u__1
public System.Decimal amount
public MegaCrit.Sts2.Core.Entities.Cards.CardPlay cardPlay
public MegaCrit.Sts2.Core.Models.CardModel cardSource
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext
public MegaCrit.Sts2.Core.ValueProps.ValueProp props
public MegaCrit.Sts2.Core.Entities.Creatures.Creature target
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CreatureCmd+<Damage>d__5

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>> <>u__1
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext
public MegaCrit.Sts2.Core.Localization.DynamicVars.DamageVar damageVar
public MegaCrit.Sts2.Core.Entities.Creatures.Creature dealer
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature> targets
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CreatureCmd+<Damage>d__6

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>> <>u__1
public System.Decimal amount
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext
public MegaCrit.Sts2.Core.Entities.Creatures.Creature dealer
public MegaCrit.Sts2.Core.ValueProps.ValueProp props
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature> targets
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CreatureCmd+<Damage>d__7

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>> <>u__1
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext
public MegaCrit.Sts2.Core.Localization.DynamicVars.DamageVar damageVar
public MegaCrit.Sts2.Core.Entities.Creatures.Creature dealer
public MegaCrit.Sts2.Core.Entities.Creatures.Creature target
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CreatureCmd+<Damage>d__8

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>> <>u__1
public System.Decimal amount
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext
public MegaCrit.Sts2.Core.Entities.Creatures.Creature dealer
public MegaCrit.Sts2.Core.ValueProps.ValueProp props
public MegaCrit.Sts2.Core.Entities.Creatures.Creature target
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CreatureCmd+<Damage>d__9

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>> <>u__1
public MegaCrit.Sts2.Core.Entities.Cards.CardPlay cardPlay
public MegaCrit.Sts2.Core.Models.CardModel cardSource
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext
public MegaCrit.Sts2.Core.Localization.DynamicVars.DamageVar damageVar
public MegaCrit.Sts2.Core.Entities.Creatures.Creature dealer
public MegaCrit.Sts2.Core.Entities.Creatures.Creature target
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CreatureCmd+<GainBlock>d__17

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Decimal> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Decimal> <>u__1
public MegaCrit.Sts2.Core.Localization.DynamicVars.BlockVar blockVar
public MegaCrit.Sts2.Core.Entities.Cards.CardPlay cardPlay
public MegaCrit.Sts2.Core.Entities.Creatures.Creature creature
public System.Boolean fast
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CreatureCmd+<GainBlock>d__18

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Decimal> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private MegaCrit.Sts2.Core.Combat.ICombatState <combatState>5__2
private System.Decimal <modifiedAmount>5__3
public System.Decimal amount
public MegaCrit.Sts2.Core.Entities.Cards.CardPlay cardPlay
public MegaCrit.Sts2.Core.Entities.Creatures.Creature creature
public System.Boolean fast
public MegaCrit.Sts2.Core.ValueProps.ValueProp props
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CreatureCmd+<GainMaxHp>d__22

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Decimal> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
public System.Decimal amount
public MegaCrit.Sts2.Core.Entities.Creatures.Creature creature
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CreatureCmd+<Heal>d__20

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
private MegaCrit.Sts2.Core.Commands.CreatureCmd+<>c__DisplayClass20_0 <>8__1
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Decimal <amountHealed>5__3
private System.Boolean <wasDead>5__2
public System.Decimal amount
public MegaCrit.Sts2.Core.Entities.Creatures.Creature creature
public System.Boolean playAnim
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CreatureCmd+<Kill>d__13

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.Entities.Creatures.Creature creature
public System.Boolean force
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CreatureCmd+<Kill>d__14

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
private System.Collections.Generic.List+Enumerator<MegaCrit.Sts2.Core.Entities.Creatures.Creature> <>7__wrap2
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private MegaCrit.Sts2.Core.Runs.IRunState <runState>5__2
public System.Collections.Generic.IReadOnlyCollection<MegaCrit.Sts2.Core.Entities.Creatures.Creature> creatures
public System.Boolean force
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CreatureCmd+<KillWithoutCheckingWinCondition>d__15

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
private System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Models.PowerModel> <>7__wrap8
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private MegaCrit.Sts2.Core.Combat.ICombatState <combatState>5__3
private System.Boolean <isPrimaryEnemy>5__8
private System.Nullable<MegaCrit.Sts2.Core.Combat.CombatId> <killCombatId>5__2
private MegaCrit.Sts2.Core.Entities.Players.Player <player>5__10
private MegaCrit.Sts2.Core.Models.AbstractModel <preventer>5__5
private MegaCrit.Sts2.Core.Runs.IRunState <runState>5__4
private System.Boolean <shouldRemoveFromCombat>5__6
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Creatures.Creature> <teammates>5__7
public MegaCrit.Sts2.Core.Entities.Creatures.Creature creature
public System.Boolean force
public System.Int32 recursion
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CreatureCmd+<LoseBlock>d__19

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public System.Decimal amount
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext
public MegaCrit.Sts2.Core.Entities.Creatures.Creature remover
public MegaCrit.Sts2.Core.Entities.Creatures.Creature target
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CreatureCmd+<LoseMaxHp>d__23

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.DamageResult>> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<System.Decimal> <>u__2
private System.Decimal <newMaxHp>5__2
public System.Decimal amount
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext
public MegaCrit.Sts2.Core.Entities.Creatures.Creature creature
public System.Boolean isFromCard
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CreatureCmd+<SetCurrentHp>d__21

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public System.Decimal amount
public MegaCrit.Sts2.Core.Entities.Creatures.Creature creature
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CreatureCmd+<SetMaxAndCurrentHp>d__25

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Decimal> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
public System.Decimal amount
public MegaCrit.Sts2.Core.Entities.Creatures.Creature creature
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CreatureCmd+<SetMaxHp>d__24

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Decimal> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Int32 <newMaxHp>5__3
private System.Int32 <oldMaxHp>5__2
public System.Decimal amount
public MegaCrit.Sts2.Core.Entities.Creatures.Creature creature
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CreatureCmd+<Stun>d__26

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.Entities.Creatures.Creature creature
public System.String nextMoveId
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.CreatureCmd+<TriggerAnim>d__28

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.Entities.Creatures.Creature creature
public System.String triggerName
public System.Single waitTime
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.DamageCmd

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static MegaCrit.Sts2.Core.Commands.Builders.AttackCommand Attack(MegaCrit.Sts2.Core.Localization.DynamicVars.CalculatedDamageVar calculatedDamageVar)
public static MegaCrit.Sts2.Core.Commands.Builders.AttackCommand Attack(System.Decimal damagePerHit)
```

## MegaCrit.Sts2.Core.Commands.ForgeCmd

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static const System.String _forgeInitialSfx = "event:/sfx/characters/regent/regent_forge"
private static const System.String _forgeRefineSfx = "event:/sfx/characters/regent/regent_refine"
private static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.Cards.SovereignBlade> GetSovereignBlades(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Boolean includeExhausted)
private static System.Void IncreaseSovereignBladeDamage(System.Decimal amount, MegaCrit.Sts2.Core.Entities.Players.Player player)
private static System.Void PreviewSovereignBlade(System.Collections.Generic.IReadOnlyCollection<MegaCrit.Sts2.Core.Models.Cards.SovereignBlade> blades)
public static [async] System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.Cards.SovereignBlade>> Forge(System.Decimal amount, MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.Models.AbstractModel source)
public static System.Void PlayCombatRoomForgeVfx(MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.Models.CardModel card)
```

## MegaCrit.Sts2.Core.Commands.ForgeCmd+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Commands.ForgeCmd+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Models.Cards.SovereignBlade, System.Boolean> <>9__5_0
public static System.Func<MegaCrit.Sts2.Core.Models.Cards.SovereignBlade, System.Boolean> <>9__5_1
private static .cctor()
public .ctor()
internal System.Boolean <PreviewSovereignBlade>b__5_0(MegaCrit.Sts2.Core.Models.Cards.SovereignBlade c)
internal System.Boolean <PreviewSovereignBlade>b__5_1(MegaCrit.Sts2.Core.Models.Cards.SovereignBlade c)
```

## MegaCrit.Sts2.Core.Commands.ForgeCmd+<>c__DisplayClass4_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.Boolean includeExhausted
public .ctor()
internal System.Boolean <GetSovereignBlades>b__0(MegaCrit.Sts2.Core.Models.CardModel c)
```

## MegaCrit.Sts2.Core.Commands.ForgeCmd+<Forge>d__2

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.Cards.SovereignBlade>> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.Cards.SovereignBlade> <blades>5__2
private MegaCrit.Sts2.Core.Models.Cards.SovereignBlade <sovereignBlade>5__3
public System.Decimal amount
public MegaCrit.Sts2.Core.Entities.Players.Player player
public MegaCrit.Sts2.Core.Models.AbstractModel source
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.MapCmd

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static System.Void SetBossEncounter(MegaCrit.Sts2.Core.Runs.IRunState runState, MegaCrit.Sts2.Core.Models.EncounterModel boss)
```

## MegaCrit.Sts2.Core.Commands.OrbCmd

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static [async] System.Threading.Tasks.Task Evoke(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.Models.OrbModel evokedOrb, System.Boolean dequeue = True)
public static [async] System.Threading.Tasks.Task Channel(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Models.OrbModel orb, MegaCrit.Sts2.Core.Entities.Players.Player player)
public static [async] System.Threading.Tasks.Task Channel<T>(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Players.Player player) where T: [None] MegaCrit.Sts2.Core.Models.OrbModel
public static [async] System.Threading.Tasks.Task EvokeLast(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Players.Player player, System.Boolean dequeue = True)
public static [async] System.Threading.Tasks.Task EvokeNext(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Players.Player player, System.Boolean dequeue = True)
public static [async] System.Threading.Tasks.Task Passive(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Models.OrbModel orb, MegaCrit.Sts2.Core.Entities.Creatures.Creature target, System.Boolean countAffectedByHooks = False)
public static System.Threading.Tasks.Task AddSlots(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Int32 amount)
public static System.Void RemoveSlots(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Int32 amount)
```

## MegaCrit.Sts2.Core.Commands.OrbCmd+<Channel>d__2<T>

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext
public MegaCrit.Sts2.Core.Entities.Players.Player player
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.OrbCmd+<Channel>d__3

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__2
private MegaCrit.Sts2.Core.Combat.ICombatState <combatState>5__2
private MegaCrit.Sts2.Core.Entities.Orbs.OrbQueue <orbQueue>5__3
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext
public MegaCrit.Sts2.Core.Models.OrbModel orb
public MegaCrit.Sts2.Core.Entities.Players.Player player
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.OrbCmd+<Evoke>d__6

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature>> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
private System.Boolean <removed>5__2
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext
public System.Boolean dequeue
public MegaCrit.Sts2.Core.Models.OrbModel evokedOrb
public MegaCrit.Sts2.Core.Entities.Players.Player player
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.OrbCmd+<EvokeLast>d__5

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private MegaCrit.Sts2.Core.Models.OrbModel <orb>5__2
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext
public System.Boolean dequeue
public MegaCrit.Sts2.Core.Entities.Players.Player player
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.OrbCmd+<EvokeNext>d__4

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private MegaCrit.Sts2.Core.Models.OrbModel <orb>5__2
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext
public System.Boolean dequeue
public MegaCrit.Sts2.Core.Entities.Players.Player player
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.OrbCmd+<Passive>d__7

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext
public System.Boolean countAffectedByHooks
public MegaCrit.Sts2.Core.Models.OrbModel orb
public MegaCrit.Sts2.Core.Entities.Creatures.Creature target
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.OstyCmd

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static [async] System.Threading.Tasks.Task<MegaCrit.Sts2.Core.Entities.Creatures.SummonResult> Summon(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Players.Player summoner, System.Decimal amount, MegaCrit.Sts2.Core.Models.AbstractModel source)
```

## MegaCrit.Sts2.Core.Commands.OstyCmd+<>c__DisplayClass0_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Entities.Players.Player summoner
public .ctor()
internal System.Boolean <Summon>b__0(MegaCrit.Sts2.Core.Entities.Creatures.Creature c)
```

## MegaCrit.Sts2.Core.Commands.OstyCmd+<Summon>d__0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
private MegaCrit.Sts2.Core.Commands.OstyCmd+<>c__DisplayClass0_0 <>8__1
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<MegaCrit.Sts2.Core.Entities.Creatures.SummonResult> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Entities.Creatures.Creature> <>u__2
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Models.Powers.DieForYouPower> <>u__3
private System.Runtime.CompilerServices.TaskAwaiter<System.Decimal> <>u__4
private MegaCrit.Sts2.Core.Combat.ICombatState <combatState>5__2
private System.Boolean <isReviving>5__4
private MegaCrit.Sts2.Core.Entities.Creatures.Creature <osty>5__3
private MegaCrit.Sts2.Core.Nodes.Combat.NCreature <ostyNode>5__5
public System.Decimal amount
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext
public MegaCrit.Sts2.Core.Models.AbstractModel source
public MegaCrit.Sts2.Core.Entities.Players.Player summoner
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.PlayerCmd

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static const System.String goldLargeSfx = "event:/sfx/ui/gold/gold_3"
public static const System.String goldMediumSfx = "event:/sfx/ui/gold/gold_2"
public static const System.String goldSmallSfx = "event:/sfx/ui/gold/gold_1"
public static [async] System.Threading.Tasks.Task AddPet(MegaCrit.Sts2.Core.Entities.Creatures.Creature pet, MegaCrit.Sts2.Core.Entities.Players.Player player)
public static [async] System.Threading.Tasks.Task GainEnergy(System.Decimal amount, MegaCrit.Sts2.Core.Entities.Players.Player player)
public static [async] System.Threading.Tasks.Task GainGold(System.Decimal amount, MegaCrit.Sts2.Core.Entities.Players.Player player, System.Boolean wasStolenBack = False)
public static [async] System.Threading.Tasks.Task GainStars(System.Decimal amount, MegaCrit.Sts2.Core.Entities.Players.Player player)
public static [async] System.Threading.Tasks.Task MimicRestSiteHeal(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Boolean playSfx = True)
public static [async] System.Threading.Tasks.Task SetEnergy(System.Decimal amount, MegaCrit.Sts2.Core.Entities.Players.Player player)
public static [async] System.Threading.Tasks.Task SetGold(System.Decimal amount, MegaCrit.Sts2.Core.Entities.Players.Player player)
public static [async] System.Threading.Tasks.Task SetStars(System.Decimal amount, MegaCrit.Sts2.Core.Entities.Players.Player player)
public static [async] System.Threading.Tasks.Task<MegaCrit.Sts2.Core.Entities.Creatures.Creature> AddPet<T>(MegaCrit.Sts2.Core.Entities.Players.Player player) where T: [None] MegaCrit.Sts2.Core.Models.MonsterModel
public static System.Threading.Tasks.Task GainMaxPotionCount(System.Int32 amount, MegaCrit.Sts2.Core.Entities.Players.Player player)
public static System.Threading.Tasks.Task LoseEnergy(System.Decimal amount, MegaCrit.Sts2.Core.Entities.Players.Player player)
public static System.Threading.Tasks.Task LoseGold(System.Decimal amount, MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.Entities.Gold.GoldLossType goldLossType = 2)
public static System.Threading.Tasks.Task LoseMaxPotionCount(System.Int32 amount, MegaCrit.Sts2.Core.Entities.Players.Player player)
public static System.Threading.Tasks.Task LoseStars(System.Decimal amount, MegaCrit.Sts2.Core.Entities.Players.Player player)
public static System.Void CompleteQuest(MegaCrit.Sts2.Core.Models.CardModel questCard)
public static System.Void EndTurn(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Boolean canBackOut, System.Func<System.Threading.Tasks.Task> actionDuringEnemyTurn = null)
```

## MegaCrit.Sts2.Core.Commands.PlayerCmd+<AddPet>d__14<T>

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<MegaCrit.Sts2.Core.Entities.Creatures.Creature> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private MegaCrit.Sts2.Core.Entities.Creatures.Creature <pet>5__2
public MegaCrit.Sts2.Core.Entities.Players.Player player
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.PlayerCmd+<AddPet>d__15

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.Entities.Creatures.Creature pet
public MegaCrit.Sts2.Core.Entities.Players.Player player
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.PlayerCmd+<GainEnergy>d__3

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Decimal <finalAmount>5__2
public System.Decimal amount
public MegaCrit.Sts2.Core.Entities.Players.Player player
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.PlayerCmd+<GainGold>d__9

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private MegaCrit.Sts2.Core.Runs.IRunState <runState>5__2
public System.Decimal amount
public MegaCrit.Sts2.Core.Entities.Players.Player player
public System.Boolean wasStolenBack
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.PlayerCmd+<GainStars>d__6

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public System.Decimal amount
public MegaCrit.Sts2.Core.Entities.Players.Player player
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.PlayerCmd+<MimicRestSiteHeal>d__16

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.Entities.Players.Player player
public System.Boolean playSfx
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.PlayerCmd+<SetEnergy>d__5

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public System.Decimal amount
public MegaCrit.Sts2.Core.Entities.Players.Player player
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.PlayerCmd+<SetGold>d__11

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public System.Decimal amount
public MegaCrit.Sts2.Core.Entities.Players.Player player
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.PlayerCmd+<SetStars>d__8

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public System.Decimal amount
public MegaCrit.Sts2.Core.Entities.Players.Player player
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.PotionCmd

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static [async] System.Threading.Tasks.Task Discard(MegaCrit.Sts2.Core.Models.PotionModel potion)
public static [async] System.Threading.Tasks.Task<MegaCrit.Sts2.Core.Entities.Potions.PotionProcureResult> TryToProcure(MegaCrit.Sts2.Core.Models.PotionModel potion, MegaCrit.Sts2.Core.Entities.Players.Player player, System.Int32 slotIndex = -1)
public static [async] System.Threading.Tasks.Task<MegaCrit.Sts2.Core.Entities.Potions.PotionProcureResult> TryToProcure<T>(MegaCrit.Sts2.Core.Entities.Players.Player player) where T: [None] MegaCrit.Sts2.Core.Models.PotionModel
```

## MegaCrit.Sts2.Core.Commands.PotionCmd+<Discard>d__2

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.Models.PotionModel potion
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.PotionCmd+<TryToProcure>d__0<T>

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<MegaCrit.Sts2.Core.Entities.Potions.PotionProcureResult> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Entities.Potions.PotionProcureResult> <>u__1
public MegaCrit.Sts2.Core.Entities.Players.Player player
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.PotionCmd+<TryToProcure>d__1

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<MegaCrit.Sts2.Core.Entities.Potions.PotionProcureResult> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private MegaCrit.Sts2.Core.Entities.Potions.PotionProcureResult <result>5__2
public MegaCrit.Sts2.Core.Entities.Players.Player player
public MegaCrit.Sts2.Core.Models.PotionModel potion
public System.Int32 slotIndex
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.PowerCmd

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static [async] System.Threading.Tasks.Task Apply(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Models.PowerModel power, MegaCrit.Sts2.Core.Entities.Creatures.Creature target, System.Decimal amount, MegaCrit.Sts2.Core.Entities.Creatures.Creature applier, MegaCrit.Sts2.Core.Models.CardModel cardSource, System.Boolean silent = False)
public static [async] System.Threading.Tasks.Task Decrement(MegaCrit.Sts2.Core.Models.PowerModel power)
public static [async] System.Threading.Tasks.Task Remove(MegaCrit.Sts2.Core.Models.PowerModel power)
public static [async] System.Threading.Tasks.Task Remove<T>(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature) where T: [None] MegaCrit.Sts2.Core.Models.PowerModel
public static [async] System.Threading.Tasks.Task TickDownDuration(MegaCrit.Sts2.Core.Models.PowerModel power)
public static [async] System.Threading.Tasks.Task<System.Collections.Generic.IReadOnlyList<T>> Apply<T>(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature> targets, System.Decimal amount, MegaCrit.Sts2.Core.Entities.Creatures.Creature applier, MegaCrit.Sts2.Core.Models.CardModel cardSource, System.Boolean silent = False) where T: [None] MegaCrit.Sts2.Core.Models.PowerModel
public static [async] System.Threading.Tasks.Task<System.Int32> ModifyAmount(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Models.PowerModel power, System.Decimal offset, MegaCrit.Sts2.Core.Entities.Creatures.Creature applier, MegaCrit.Sts2.Core.Models.CardModel cardSource, System.Boolean silent = False)
public static [async] System.Threading.Tasks.Task<T> Apply<T>(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Creatures.Creature target, System.Decimal amount, MegaCrit.Sts2.Core.Entities.Creatures.Creature applier, MegaCrit.Sts2.Core.Models.CardModel cardSource, System.Boolean silent = False) where T: [None] MegaCrit.Sts2.Core.Models.PowerModel
public static MegaCrit.Sts2.Core.Models.PowerModel FindExistingInstanceForStacking(MegaCrit.Sts2.Core.Models.PowerModel basePower, MegaCrit.Sts2.Core.Entities.Creatures.Creature target, MegaCrit.Sts2.Core.Entities.Creatures.Creature applier)
```

## MegaCrit.Sts2.Core.Commands.PowerCmd+<>c__DisplayClass3_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Entities.Creatures.Creature applier
public .ctor()
internal System.Boolean <FindExistingInstanceForStacking>b__0(MegaCrit.Sts2.Core.Models.PowerModel p)
```

## MegaCrit.Sts2.Core.Commands.PowerCmd+<Apply>d__0<T>

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
private System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Entities.Creatures.Creature> <>7__wrap2
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.IReadOnlyList<T>> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<T> <>u__1
private System.Collections.Generic.List<T> <powers>5__2
public System.Decimal amount
public MegaCrit.Sts2.Core.Entities.Creatures.Creature applier
public MegaCrit.Sts2.Core.Models.CardModel cardSource
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext
public System.Boolean silent
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature> targets
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.PowerCmd+<Apply>d__1<T>

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<T> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<System.Int32> <>u__2
private MegaCrit.Sts2.Core.Models.PowerModel <power>5__2
public System.Decimal amount
public MegaCrit.Sts2.Core.Entities.Creatures.Creature applier
public MegaCrit.Sts2.Core.Models.CardModel cardSource
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext
public System.Boolean silent
public MegaCrit.Sts2.Core.Entities.Creatures.Creature target
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.PowerCmd+<Apply>d__2

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Int32> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
private MegaCrit.Sts2.Core.Combat.ICombatState <combatState>5__2
private System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AbstractModel> <givenModifiers>5__4
private System.Decimal <modifiedAmount>5__3
private System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AbstractModel> <receivedModifiers>5__5
public System.Decimal amount
public MegaCrit.Sts2.Core.Entities.Creatures.Creature applier
public MegaCrit.Sts2.Core.Models.CardModel cardSource
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext
public MegaCrit.Sts2.Core.Models.PowerModel power
public System.Boolean silent
public MegaCrit.Sts2.Core.Entities.Creatures.Creature target
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.PowerCmd+<Decrement>d__4

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Int32> <>u__1
public MegaCrit.Sts2.Core.Models.PowerModel power
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.PowerCmd+<ModifyAmount>d__6

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Int32> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private MegaCrit.Sts2.Core.Combat.ICombatState <combatState>5__3
private System.Decimal <modifiedOffset>5__4
private System.Int32 <newAmount>5__6
private MegaCrit.Sts2.Core.Entities.Creatures.Creature <owner>5__2
private System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AbstractModel> <receivedModifiers>5__5
public MegaCrit.Sts2.Core.Entities.Creatures.Creature applier
public MegaCrit.Sts2.Core.Models.CardModel cardSource
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext
public System.Decimal offset
public MegaCrit.Sts2.Core.Models.PowerModel power
public System.Boolean silent
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.PowerCmd+<Remove>d__7<T>

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.Entities.Creatures.Creature creature
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.PowerCmd+<Remove>d__8

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.Models.PowerModel power
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.PowerCmd+<TickDownDuration>d__5

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.Models.PowerModel power
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.RelicCmd

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static [async] System.Threading.Tasks.Task Melt(MegaCrit.Sts2.Core.Models.RelicModel relic)
public static [async] System.Threading.Tasks.Task Remove(MegaCrit.Sts2.Core.Models.RelicModel relic)
public static [async] System.Threading.Tasks.Task<MegaCrit.Sts2.Core.Models.RelicModel> Obtain(MegaCrit.Sts2.Core.Models.RelicModel relic, MegaCrit.Sts2.Core.Entities.Players.Player player, System.Int32 index = -1)
public static [async] System.Threading.Tasks.Task<MegaCrit.Sts2.Core.Models.RelicModel> Replace(MegaCrit.Sts2.Core.Models.RelicModel original, MegaCrit.Sts2.Core.Models.RelicModel replace)
public static [async] System.Threading.Tasks.Task<T> Obtain<T>(MegaCrit.Sts2.Core.Entities.Players.Player player) where T: [None] MegaCrit.Sts2.Core.Models.RelicModel
```

## MegaCrit.Sts2.Core.Commands.RelicCmd+<Melt>d__4

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.Models.RelicModel relic
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.RelicCmd+<Obtain>d__0<T>

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<T> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Models.RelicModel> <>u__1
public MegaCrit.Sts2.Core.Entities.Players.Player player
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.RelicCmd+<Obtain>d__1

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<MegaCrit.Sts2.Core.Models.RelicModel> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public System.Int32 index
public MegaCrit.Sts2.Core.Entities.Players.Player player
public MegaCrit.Sts2.Core.Models.RelicModel relic
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.RelicCmd+<Remove>d__2

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.Models.RelicModel relic
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.RelicCmd+<Replace>d__3

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<MegaCrit.Sts2.Core.Models.RelicModel> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Models.RelicModel> <>u__2
private System.Int32 <indexOfOriginal>5__3
private MegaCrit.Sts2.Core.Entities.Players.Player <player>5__2
public MegaCrit.Sts2.Core.Models.RelicModel original
public MegaCrit.Sts2.Core.Models.RelicModel replace
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.RelicSelectCmd

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static System.Boolean ShouldSelectLocalRelic(MegaCrit.Sts2.Core.Entities.Players.Player player)
public static [async] System.Threading.Tasks.Task<MegaCrit.Sts2.Core.Models.RelicModel> FromChooseARelicScreen(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.RelicModel> relics)
```

## MegaCrit.Sts2.Core.Commands.RelicSelectCmd+<FromChooseARelicScreen>d__1

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<MegaCrit.Sts2.Core.Models.RelicModel> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.RelicModel>> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult> <>u__2
private System.UInt32 <choiceId>5__2
public MegaCrit.Sts2.Core.Entities.Players.Player player
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.RelicModel> relics
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.RewardsCmd

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static [async] System.Threading.Tasks.Task OfferCustom(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Collections.Generic.List<MegaCrit.Sts2.Core.Rewards.Reward> rewards)
public static [async] System.Threading.Tasks.Task OfferForRoomEnd(MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.Rooms.AbstractRoom room)
public static [async] System.Threading.Tasks.Task<MegaCrit.Sts2.Core.Rewards.RewardsSet> GenerateCustom(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Collections.Generic.List<MegaCrit.Sts2.Core.Rewards.Reward> rewards)
public static [async] System.Threading.Tasks.Task<MegaCrit.Sts2.Core.Rewards.RewardsSet> GenerateForRoomEnd(MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.Rooms.AbstractRoom room)
```

## MegaCrit.Sts2.Core.Commands.RewardsCmd+<GenerateCustom>d__3

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<MegaCrit.Sts2.Core.Rewards.RewardsSet> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private MegaCrit.Sts2.Core.Rewards.RewardsSet <set>5__2
public MegaCrit.Sts2.Core.Entities.Players.Player player
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Rewards.Reward> rewards
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.RewardsCmd+<GenerateForRoomEnd>d__2

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<MegaCrit.Sts2.Core.Rewards.RewardsSet> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private MegaCrit.Sts2.Core.Rewards.RewardsSet <set>5__2
public MegaCrit.Sts2.Core.Entities.Players.Player player
public MegaCrit.Sts2.Core.Rooms.AbstractRoom room
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.RewardsCmd+<OfferCustom>d__1

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.Entities.Players.Player player
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Rewards.Reward> rewards
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.RewardsCmd+<OfferForRoomEnd>d__0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.Entities.Players.Player player
public MegaCrit.Sts2.Core.Rooms.AbstractRoom room
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Commands.SfxCmd

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static System.Void Play(System.String sfx, System.Single volume = 1)
public static System.Void Play(System.String sfx, System.String param, System.Single val, System.Single volume = 1)
public static System.Void PlayCardSwooshSfx(MegaCrit.Sts2.Core.Entities.Cards.CardPile currentPile, MegaCrit.Sts2.Core.Entities.Cards.CardPile prevPile = null)
public static System.Void PlayDamage(MegaCrit.Sts2.Core.Models.MonsterModel monster, System.Int32 damageAmount)
public static System.Void PlayDeath(MegaCrit.Sts2.Core.Entities.Players.Player player)
public static System.Void PlayDeath(MegaCrit.Sts2.Core.Models.MonsterModel monster)
public static System.Void PlayLoop(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature, System.String sfx, System.String loopParam, System.Single loopStopValue)
public static System.Void PlayLoop(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature, System.String sfx)
public static System.Void PlayLoop(System.String sfx, System.Boolean usesLoopParam = True)
public static System.Void SetParam(System.String sfx, System.String param, System.Single value)
public static System.Void StopLoop(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature, System.String sfx)
public static System.Void StopLoop(System.String sfx)
```

## MegaCrit.Sts2.Core.Commands.TalkCmd

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static System.Double GetDuration(MegaCrit.Sts2.Core.Nodes.Vfx.VfxDuration duration)
private static System.Int32 GetRawCharCount(System.String bbcodeText)
public static MegaCrit.Sts2.Core.Nodes.Vfx.NSpeechBubbleVfx Play(MegaCrit.Sts2.Core.Localization.LocString line, MegaCrit.Sts2.Core.Entities.Creatures.Creature speaker, MegaCrit.Sts2.Core.Nodes.Vfx.VfxColor vfxColor, MegaCrit.Sts2.Core.Nodes.Vfx.VfxDuration duration = 6)
```

## MegaCrit.Sts2.Core.Commands.ThinkCmd

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static const System.Double _defaultTimePerCharacter = 0.08
private static const System.Double _minTimeToDisplay = 1.5
public static System.Void Play(MegaCrit.Sts2.Core.Localization.LocString line, MegaCrit.Sts2.Core.Entities.Creatures.Creature speaker, System.Double secondsToDisplay = -1)
```

## MegaCrit.Sts2.Core.Commands.VfxCmd

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static const System.String adrenalinePath = "vfx/vfx_adrenaline"
public static const System.String bitePath = "vfx/vfx_bite"
public static const System.String blockPath = "vfx/vfx_block"
public static const System.String bloodyImpactPath = "vfx/vfx_bloody_impact"
public static const System.String bluntPath = "vfx/vfx_attack_blunt"
public static const System.String chainPath = "vfx/vfx_chain"
public static const System.String coinExplosionJumboPath = "vfx/vfx_coin_explosion_jumbo"
public static const System.String coinExplosionRegularPath = "vfx/vfx_coin_explosion_regular"
public static const System.String coinExplosionSmallPath = "vfx/vfx_coin_explosion_small"
public static const System.String daggerSprayPath = "vfx/vfx_dagger_spray"
public static const System.String daggerThrowPath = "vfx/vfx_dagger_throw"
public static const System.String dramaticStabPath = "vfx/vfx_dramatic_stab"
public static const System.String flyingSlashPath = "vfx/vfx_flying_slash"
public static const System.String gazePath = "vfx/vfx_gaze"
public static const System.String giantHorizontalSlashPath = "vfx/vfx_giant_horizontal_slash"
public static const System.String healPath = "vfx/vfx_cross_heal"
public static const System.String heavyBluntPath = "vfx/vfx_heavy_blunt"
public static const System.String hellraiserSwordVfxPath = "vfx/hellraiser_attack_vfx"
public static const System.String lightningPath = "vfx/vfx_attack_lightning"
public static const System.String rockShatterPath = "vfx/vfx_rock_shatter"
public static const System.String sandyImpactPath = "vfx/vfx_sandy_impact"
public static const System.String scratchPath = "vfx/vfx_scratch"
public static const System.String screamVfx = "vfx/vfx_scream"
public static const System.String slashPath = "vfx/vfx_attack_slash"
public static const System.String slimeImpactVfxPath = "vfx/vfx_slime_impact"
public static const System.String spookyScreamVfx = "vfx/vfx_spooky_scream"
public static const System.String starryImpactVfx = "vfx/vfx_starry_impact"
public static const System.String thrashPath = "vfx/vfx_thrash"
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
public static Godot.Node2D PlayNonCombatVfx(Godot.Node container, Godot.Vector2 position, System.String path)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public static System.Nullable<Godot.Vector2> GetSideCenter(MegaCrit.Sts2.Core.Combat.CombatSide side, MegaCrit.Sts2.Core.Combat.ICombatState combatState)
public static System.Nullable<Godot.Vector2> GetSideCenterFloor(MegaCrit.Sts2.Core.Combat.CombatSide side, MegaCrit.Sts2.Core.Combat.ICombatState combatState)
public static System.Void PlayFullScreenInCombat(System.String path, MegaCrit.Sts2.Core.Entities.Creatures.Creature spawner)
public static System.Void PlayOnCreature(MegaCrit.Sts2.Core.Entities.Creatures.Creature target, System.String path)
public static System.Void PlayOnCreatureCenter(MegaCrit.Sts2.Core.Entities.Creatures.Creature target, System.String path)
public static System.Void PlayOnCreatureCenters(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature> targets, System.String path)
public static System.Void PlayOnCreatures(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature> targets, System.String path)
public static System.Void PlayOnSide(MegaCrit.Sts2.Core.Combat.CombatSide side, System.String path, MegaCrit.Sts2.Core.Combat.ICombatState combatState)
public static System.Void PlayVfx(Godot.Vector2 position, System.String path, Godot.Control vfxContainer)
```

## MegaCrit.Sts2.Core.Commands.VfxCmd+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Commands.VfxCmd+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Entities.Creatures.Creature, System.Boolean> <>9__31_0
public static System.Func<MegaCrit.Sts2.Core.Entities.Creatures.Creature, System.Boolean> <>9__32_0
private static .cctor()
public .ctor()
internal System.Boolean <GetSideCenter>b__31_0(MegaCrit.Sts2.Core.Entities.Creatures.Creature c)
internal System.Boolean <GetSideCenterFloor>b__32_0(MegaCrit.Sts2.Core.Entities.Creatures.Creature c)
```

## MegaCrit.Sts2.Core.Commands.VfxCmd+<>O

类型属性：`NestedPrivate, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static System.Func<System.String, System.String> <0>__GetScenePath
```
