# MegaCrit.Sts2.Core.Entities.Cards

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Entities.Cards.ActionTargetExtensions

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static System.Boolean IsSingleTarget(MegaCrit.Sts2.Core.Entities.Cards.TargetType targetType)
```

## MegaCrit.Sts2.Core.Entities.Cards.AutoPlayType

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Entities.Cards.AutoPlayType Default = 1
public static const MegaCrit.Sts2.Core.Entities.Cards.AutoPlayType None = 0
public static const MegaCrit.Sts2.Core.Entities.Cards.AutoPlayType SlyDiscard = 2
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Entities.Cards.CardCostColor

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Entities.Cards.CardCostColor Decreased = 2
public static const MegaCrit.Sts2.Core.Entities.Cards.CardCostColor Increased = 1
public static const MegaCrit.Sts2.Core.Entities.Cards.CardCostColor InsufficientResources = 3
public static const MegaCrit.Sts2.Core.Entities.Cards.CardCostColor Unmodified = 0
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Entities.Cards.CardCreationResult

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private MegaCrit.Sts2.Core.Models.CardModel _modifiedCard
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.RelicModel> _modifyingRelics
public readonly MegaCrit.Sts2.Core.Models.CardModel originalCard
MegaCrit.Sts2.Core.Models.CardModel Card { public get; }
System.Boolean HasBeenModified { public get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.RelicModel> ModifyingRelics { public get; }
public .ctor(MegaCrit.Sts2.Core.Models.CardModel originalCard)
public MegaCrit.Sts2.Core.Models.CardModel get_Card()
public System.Boolean get_HasBeenModified()
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.RelicModel> get_ModifyingRelics()
public System.Void ModifyCard(MegaCrit.Sts2.Core.Models.CardModel card, MegaCrit.Sts2.Core.Models.RelicModel modifyingRelic)
public System.Void ModifyCard(MegaCrit.Sts2.Core.Models.CardModel card)
```

## MegaCrit.Sts2.Core.Entities.Cards.CardEnergyCost

类型属性：`Public, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private System.Int32 _base
private System.Int32 _capturedXValue
private readonly MegaCrit.Sts2.Core.Models.CardModel _card
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Cards.LocalCostModifier> _localModifiers
private readonly System.Int32 <Canonical>k__BackingField
private readonly System.Boolean <CostsX>k__BackingField
private System.Boolean <WasJustUpgraded>k__BackingField
System.Int32 Canonical { public get; }
System.Int32 CapturedXValue { public get; public set; }
System.Boolean CostsX { public get; }
System.Boolean HasLocalModifiers { public get; }
System.Boolean WasJustUpgraded { public get; private set; }
public .ctor(MegaCrit.Sts2.Core.Models.CardModel card, System.Int32 canonicalCost, System.Boolean costsX)
private System.Void set_WasJustUpgraded(System.Boolean value)
public MegaCrit.Sts2.Core.Entities.Cards.CardEnergyCost Clone(MegaCrit.Sts2.Core.Models.CardModel newCard)
public System.Boolean AfterCardPlayedCleanup()
public System.Boolean EndOfTurnCleanup()
public System.Boolean get_CostsX()
public System.Boolean get_HasLocalModifiers()
public System.Boolean get_WasJustUpgraded()
public System.Int32 get_Canonical()
public System.Int32 get_CapturedXValue()
public System.Int32 GetAmountToSpend()
public System.Int32 GetResolved()
public System.Int32 GetWithModifiers(MegaCrit.Sts2.Core.Entities.Cards.CostModifiers modifiers)
public System.Void AddThisCombat(System.Int32 amount, System.Boolean reduceOnly = False)
public System.Void AddThisTurn(System.Int32 amount, System.Boolean reduceOnly = False)
public System.Void AddThisTurnOrUntilPlayed(System.Int32 amount, System.Boolean reduceOnly = False)
public System.Void AddUntilPlayed(System.Int32 amount, System.Boolean reduceOnly = False)
public System.Void FinalizeUpgrade()
public System.Void ResetForDowngrade()
public System.Void set_CapturedXValue(System.Int32 value)
public System.Void SetCustomBaseCost(System.Int32 newBaseCost)
public System.Void SetThisCombat(System.Int32 cost, System.Boolean reduceOnly = False)
public System.Void SetThisTurn(System.Int32 cost, System.Boolean reduceOnly = False)
public System.Void SetThisTurnOrUntilPlayed(System.Int32 cost, System.Boolean reduceOnly = False)
public System.Void SetUntilPlayed(System.Int32 cost, System.Boolean reduceOnly = False)
public System.Void UpgradeBy(System.Int32 addend)
```

## MegaCrit.Sts2.Core.Entities.Cards.CardEnergyCost+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Entities.Cards.CardEnergyCost+<>c <>9
public static System.Predicate<MegaCrit.Sts2.Core.Entities.Cards.LocalCostModifier> <>9__31_0
public static System.Predicate<MegaCrit.Sts2.Core.Entities.Cards.LocalCostModifier> <>9__32_0
public static System.Func<MegaCrit.Sts2.Core.Entities.Cards.LocalCostModifier, MegaCrit.Sts2.Core.Entities.Cards.LocalCostModifier> <>9__37_0
private static .cctor()
public .ctor()
internal MegaCrit.Sts2.Core.Entities.Cards.LocalCostModifier <Clone>b__37_0(MegaCrit.Sts2.Core.Entities.Cards.LocalCostModifier m)
internal System.Boolean <AfterCardPlayedCleanup>b__32_0(MegaCrit.Sts2.Core.Entities.Cards.LocalCostModifier m)
internal System.Boolean <EndOfTurnCleanup>b__31_0(MegaCrit.Sts2.Core.Entities.Cards.LocalCostModifier m)
```

## MegaCrit.Sts2.Core.Entities.Cards.CardKeyword

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Entities.Cards.CardKeyword Eternal = 7
public static const MegaCrit.Sts2.Core.Entities.Cards.CardKeyword Ethereal = 2
public static const MegaCrit.Sts2.Core.Entities.Cards.CardKeyword Exhaust = 1
public static const MegaCrit.Sts2.Core.Entities.Cards.CardKeyword Innate = 3
public static const MegaCrit.Sts2.Core.Entities.Cards.CardKeyword None = 0
public static const MegaCrit.Sts2.Core.Entities.Cards.CardKeyword Retain = 5
public static const MegaCrit.Sts2.Core.Entities.Cards.CardKeyword Sly = 6
public static const MegaCrit.Sts2.Core.Entities.Cards.CardKeyword Unplayable = 4
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Entities.Cards.CardKeywordExtensions

类型属性：`Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static readonly MegaCrit.Sts2.Core.Localization.LocString _period
private static .cctor()
public static MegaCrit.Sts2.Core.Localization.LocString GetDescription(MegaCrit.Sts2.Core.Entities.Cards.CardKeyword keyword)
public static MegaCrit.Sts2.Core.Localization.LocString GetTitle(MegaCrit.Sts2.Core.Entities.Cards.CardKeyword keyword)
public static System.String GetCardText(MegaCrit.Sts2.Core.Entities.Cards.CardKeyword keyword)
public static System.String GetLocKeyPrefix(MegaCrit.Sts2.Core.Entities.Cards.CardKeyword keyword)
```

## MegaCrit.Sts2.Core.Entities.Cards.CardKeywordOrder

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Entities.Cards.CardKeyword[] afterDescription
public static readonly MegaCrit.Sts2.Core.Entities.Cards.CardKeyword[] beforeDescription
private static .cctor()
```

## MegaCrit.Sts2.Core.Entities.Cards.CardLocation

类型属性：`Public, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.IEquatable<MegaCrit.Sts2.Core.Entities.Cards.CardLocation>`

```text
public MegaCrit.Sts2.Core.Entities.Cards.PileType pileType
public MegaCrit.Sts2.Core.Entities.Players.Player player
public MegaCrit.Sts2.Core.Entities.Cards.CardPilePosition position
public .ctor(MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.Entities.Cards.PileType pileType, MegaCrit.Sts2.Core.Entities.Cards.CardPilePosition position)
private System.Boolean PrintMembers(System.Text.StringBuilder builder)
public static System.Boolean op_Equality(MegaCrit.Sts2.Core.Entities.Cards.CardLocation left, MegaCrit.Sts2.Core.Entities.Cards.CardLocation right)
public static System.Boolean op_Inequality(MegaCrit.Sts2.Core.Entities.Cards.CardLocation left, MegaCrit.Sts2.Core.Entities.Cards.CardLocation right)
public virtual System.Boolean Equals(MegaCrit.Sts2.Core.Entities.Cards.CardLocation other)
public virtual System.Boolean Equals(System.Object obj)
public virtual System.Int32 GetHashCode()
public virtual System.String ToString()
```

## MegaCrit.Sts2.Core.Entities.Cards.CardMultiplayerConstraint

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Entities.Cards.CardMultiplayerConstraint MultiplayerOnly = 1
public static const MegaCrit.Sts2.Core.Entities.Cards.CardMultiplayerConstraint None = 0
public static const MegaCrit.Sts2.Core.Entities.Cards.CardMultiplayerConstraint SingleplayerOnly = 2
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Entities.Cards.CardPile

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.CardModel> _cards
private readonly MegaCrit.Sts2.Core.Entities.Cards.PileType <Type>k__BackingField
private System.Action<MegaCrit.Sts2.Core.Models.CardModel> CardAdded
private System.Action CardAddFinished
private System.Action<MegaCrit.Sts2.Core.Models.CardModel> CardRemoved
private System.Action CardRemoveFinished
private System.Action ContentsChanged
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.CardModel> Cards { public get; }
System.Boolean IsCombatPile { public get; }
System.Boolean IsEmpty { public get; }
System.Int32 MaxCardsInHand { public static get; }
MegaCrit.Sts2.Core.Entities.Cards.PileType Type { public get; }
System.Int32 UpgradableCardCount { public get; }
event System.Action<MegaCrit.Sts2.Core.Models.CardModel> CardAdded
event System.Action CardAddFinished
event System.Action<MegaCrit.Sts2.Core.Models.CardModel> CardRemoved
event System.Action CardRemoveFinished
event System.Action ContentsChanged
public .ctor(MegaCrit.Sts2.Core.Entities.Cards.PileType type)
public MegaCrit.Sts2.Core.Entities.Cards.PileType get_Type()
public static MegaCrit.Sts2.Core.Entities.Cards.CardPile Get(MegaCrit.Sts2.Core.Entities.Cards.PileType type, MegaCrit.Sts2.Core.Entities.Players.Player player)
public static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> GetCards(MegaCrit.Sts2.Core.Entities.Players.Player player, params MegaCrit.Sts2.Core.Entities.Cards.PileType[] piles)
public static System.Int32 get_MaxCardsInHand()
public System.Boolean get_IsCombatPile()
public System.Boolean get_IsEmpty()
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.CardModel> get_Cards()
public System.Int32 get_UpgradableCardCount()
public System.Void add_CardAdded(System.Action<MegaCrit.Sts2.Core.Models.CardModel> value)
public System.Void add_CardAddFinished(System.Action value)
public System.Void add_CardRemoved(System.Action<MegaCrit.Sts2.Core.Models.CardModel> value)
public System.Void add_CardRemoveFinished(System.Action value)
public System.Void add_ContentsChanged(System.Action value)
public System.Void AddInternal(MegaCrit.Sts2.Core.Models.CardModel card, System.Int32 index = -1, System.Boolean silent = False)
public System.Void Clear(System.Boolean silent = False)
public System.Void InvokeCardAddFinished()
public System.Void InvokeCardRemoved(MegaCrit.Sts2.Core.Models.CardModel card)
public System.Void InvokeCardRemoveFinished()
public System.Void InvokeContentsChanged()
public System.Void MoveToBottomInternal(MegaCrit.Sts2.Core.Models.CardModel card)
public System.Void MoveToTopInternal(MegaCrit.Sts2.Core.Models.CardModel card)
public System.Void RandomizeOrderInternal(MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.Random.Rng rng, MegaCrit.Sts2.Core.Combat.CombatState state)
public System.Void remove_CardAdded(System.Action<MegaCrit.Sts2.Core.Models.CardModel> value)
public System.Void remove_CardAddFinished(System.Action value)
public System.Void remove_CardRemoved(System.Action<MegaCrit.Sts2.Core.Models.CardModel> value)
public System.Void remove_CardRemoveFinished(System.Action value)
public System.Void remove_ContentsChanged(System.Action value)
public System.Void RemoveInternal(MegaCrit.Sts2.Core.Models.CardModel card, System.Boolean silent = False)
```

## MegaCrit.Sts2.Core.Entities.Cards.CardPile+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Entities.Cards.CardPile+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> <>9__29_0
private static .cctor()
public .ctor()
internal System.Boolean <get_UpgradableCardCount>b__29_0(MegaCrit.Sts2.Core.Models.CardModel card)
```

## MegaCrit.Sts2.Core.Entities.Cards.CardPile+<>c__DisplayClass31_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Entities.Players.Player player
public .ctor()
internal System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> <GetCards>b__0(MegaCrit.Sts2.Core.Entities.Cards.PileType p)
```

## MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult

类型属性：`Public, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：

```text
public MegaCrit.Sts2.Core.Models.CardModel cardAdded
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.AbstractModel> modifyingModels
public MegaCrit.Sts2.Core.Entities.Cards.CardPile oldPile
public System.Boolean success
public MegaCrit.Sts2.Core.Entities.Cards.PileType targetPile
```

## MegaCrit.Sts2.Core.Entities.Cards.CardPilePosition

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Entities.Cards.CardPilePosition Bottom = 1
public static const MegaCrit.Sts2.Core.Entities.Cards.CardPilePosition None = 0
public static const MegaCrit.Sts2.Core.Entities.Cards.CardPilePosition Random = 3
public static const MegaCrit.Sts2.Core.Entities.Cards.CardPilePosition Top = 2
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Entities.Cards.CardPlay

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private readonly MegaCrit.Sts2.Core.Models.CardModel <Card>k__BackingField
private readonly System.Boolean <IsAutoPlay>k__BackingField
private readonly System.Int32 <PlayCount>k__BackingField
private readonly MegaCrit.Sts2.Core.Entities.Players.Player <Player>k__BackingField
private readonly System.Int32 <PlayIndex>k__BackingField
private readonly MegaCrit.Sts2.Core.Entities.Cards.ResourceInfo <Resources>k__BackingField
private readonly MegaCrit.Sts2.Core.Entities.Cards.PileType <ResultPile>k__BackingField
private readonly MegaCrit.Sts2.Core.Entities.Creatures.Creature <Target>k__BackingField
MegaCrit.Sts2.Core.Models.CardModel Card { public get; public set; }
System.Boolean IsAutoPlay { public get; public set; }
System.Boolean IsFirstInSeries { public get; }
System.Boolean IsLastInSeries { public get; }
System.Int32 PlayCount { public get; public set; }
MegaCrit.Sts2.Core.Entities.Players.Player Player { public get; public set; }
System.Int32 PlayIndex { public get; public set; }
MegaCrit.Sts2.Core.Entities.Cards.ResourceInfo Resources { public get; public set; }
MegaCrit.Sts2.Core.Entities.Cards.PileType ResultPile { public get; public set; }
MegaCrit.Sts2.Core.Entities.Creatures.Creature Target { public get; public set; }
public .ctor()
public MegaCrit.Sts2.Core.Entities.Cards.PileType get_ResultPile()
public MegaCrit.Sts2.Core.Entities.Cards.ResourceInfo get_Resources()
public MegaCrit.Sts2.Core.Entities.Creatures.Creature get_Target()
public MegaCrit.Sts2.Core.Entities.Players.Player get_Player()
public MegaCrit.Sts2.Core.Models.CardModel get_Card()
public System.Boolean get_IsAutoPlay()
public System.Boolean get_IsFirstInSeries()
public System.Boolean get_IsLastInSeries()
public System.Int32 get_PlayCount()
public System.Int32 get_PlayIndex()
public System.Void set_Card(MegaCrit.Sts2.Core.Models.CardModel value)
public System.Void set_IsAutoPlay(System.Boolean value)
public System.Void set_PlayCount(System.Int32 value)
public System.Void set_Player(MegaCrit.Sts2.Core.Entities.Players.Player value)
public System.Void set_PlayIndex(System.Int32 value)
public System.Void set_Resources(MegaCrit.Sts2.Core.Entities.Cards.ResourceInfo value)
public System.Void set_ResultPile(MegaCrit.Sts2.Core.Entities.Cards.PileType value)
public System.Void set_Target(MegaCrit.Sts2.Core.Entities.Creatures.Creature value)
```

## MegaCrit.Sts2.Core.Entities.Cards.CardPreviewMode

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Entities.Cards.CardPreviewMode MultiCreatureTargeting = 3
public static const MegaCrit.Sts2.Core.Entities.Cards.CardPreviewMode None = 0
public static const MegaCrit.Sts2.Core.Entities.Cards.CardPreviewMode Normal = 1
public static const MegaCrit.Sts2.Core.Entities.Cards.CardPreviewMode Upgrade = 2
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Entities.Cards.CardRarity

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Entities.Cards.CardRarity Ancient = 5
public static const MegaCrit.Sts2.Core.Entities.Cards.CardRarity Basic = 1
public static const MegaCrit.Sts2.Core.Entities.Cards.CardRarity Common = 2
public static const MegaCrit.Sts2.Core.Entities.Cards.CardRarity Curse = 9
public static const MegaCrit.Sts2.Core.Entities.Cards.CardRarity Event = 6
public static const MegaCrit.Sts2.Core.Entities.Cards.CardRarity None = 0
public static const MegaCrit.Sts2.Core.Entities.Cards.CardRarity Quest = 10
public static const MegaCrit.Sts2.Core.Entities.Cards.CardRarity Rare = 4
public static const MegaCrit.Sts2.Core.Entities.Cards.CardRarity Status = 8
public static const MegaCrit.Sts2.Core.Entities.Cards.CardRarity Token = 7
public static const MegaCrit.Sts2.Core.Entities.Cards.CardRarity Uncommon = 3
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Entities.Cards.CardRarityExtensions

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static MegaCrit.Sts2.Core.Entities.Cards.CardRarity GetNextHighestRarityWithWrapping(MegaCrit.Sts2.Core.Entities.Cards.CardRarity cardRarity)
public static MegaCrit.Sts2.Core.Localization.LocString ToLocString(MegaCrit.Sts2.Core.Entities.Cards.CardRarity cardRarity)
```

## MegaCrit.Sts2.Core.Entities.Cards.CardScope

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Entities.Cards.CardScope Combat = 2
public static const MegaCrit.Sts2.Core.Entities.Cards.CardScope None = 0
public static const MegaCrit.Sts2.Core.Entities.Cards.CardScope Run = 1
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Entities.Cards.CardTag

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Entities.Cards.CardTag Defend = 2
public static const MegaCrit.Sts2.Core.Entities.Cards.CardTag Minion = 3
public static const MegaCrit.Sts2.Core.Entities.Cards.CardTag None = 0
public static const MegaCrit.Sts2.Core.Entities.Cards.CardTag OstyAttack = 4
public static const MegaCrit.Sts2.Core.Entities.Cards.CardTag Shiv = 5
public static const MegaCrit.Sts2.Core.Entities.Cards.CardTag Strike = 1
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Entities.Cards.CardTransformation

类型属性：`Public, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：

```text
private readonly System.Boolean <IsInCombat>k__BackingField
private readonly MegaCrit.Sts2.Core.Models.CardModel <Original>k__BackingField
private readonly MegaCrit.Sts2.Core.Models.CardModel <Replacement>k__BackingField
private readonly System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> <ReplacementOptions>k__BackingField
System.Boolean IsInCombat { public get; }
MegaCrit.Sts2.Core.Models.CardModel Original { public get; }
MegaCrit.Sts2.Core.Models.CardModel Replacement { public get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> ReplacementOptions { public get; }
public .ctor(MegaCrit.Sts2.Core.Models.CardModel original, MegaCrit.Sts2.Core.Models.CardModel replacement)
public .ctor(MegaCrit.Sts2.Core.Models.CardModel original, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> options)
public .ctor(MegaCrit.Sts2.Core.Models.CardModel original)
private static System.Void AssertTransformable(MegaCrit.Sts2.Core.Models.CardModel card)
public MegaCrit.Sts2.Core.Models.CardModel get_Original()
public MegaCrit.Sts2.Core.Models.CardModel get_Replacement()
public MegaCrit.Sts2.Core.Models.CardModel GetReplacement(MegaCrit.Sts2.Core.Random.Rng rng)
public System.Boolean get_IsInCombat()
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Cards.CardTransformation> Yield()
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> get_ReplacementOptions()
```

## MegaCrit.Sts2.Core.Entities.Cards.CardTransformation+<Yield>d__16

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：`System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Cards.CardTransformation>`, `System.Collections.IEnumerable`, `System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Entities.Cards.CardTransformation>`, `System.Collections.IEnumerator`, `System.IDisposable`

```text
private System.Int32 <>1__state
private MegaCrit.Sts2.Core.Entities.Cards.CardTransformation <>2__current
public MegaCrit.Sts2.Core.Entities.Cards.CardTransformation <>3__<>4__this
public MegaCrit.Sts2.Core.Entities.Cards.CardTransformation <>4__this
private System.Int32 <>l__initialThreadId
MegaCrit.Sts2.Core.Entities.Cards.CardTransformation System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Entities.Cards.CardTransformation>.Current { private virtual get; }
System.Object System.Collections.IEnumerator.Current { private virtual get; }
public .ctor(System.Int32 <>1__state)
private virtual MegaCrit.Sts2.Core.Entities.Cards.CardTransformation System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Entities.Cards.CardTransformation>.get_Current()
private virtual System.Boolean MoveNext()
private virtual System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Entities.Cards.CardTransformation> System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Cards.CardTransformation>.GetEnumerator()
private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
private virtual System.Object System.Collections.IEnumerator.get_Current()
private virtual System.Void System.Collections.IEnumerator.Reset()
private virtual System.Void System.IDisposable.Dispose()
```

## MegaCrit.Sts2.Core.Entities.Cards.CardType

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Entities.Cards.CardType Attack = 1
public static const MegaCrit.Sts2.Core.Entities.Cards.CardType Curse = 5
public static const MegaCrit.Sts2.Core.Entities.Cards.CardType None = 0
public static const MegaCrit.Sts2.Core.Entities.Cards.CardType Power = 3
public static const MegaCrit.Sts2.Core.Entities.Cards.CardType Quest = 6
public static const MegaCrit.Sts2.Core.Entities.Cards.CardType Skill = 2
public static const MegaCrit.Sts2.Core.Entities.Cards.CardType Status = 4
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Entities.Cards.CardTypeExtensions

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static MegaCrit.Sts2.Core.Localization.LocString ToLocString(MegaCrit.Sts2.Core.Entities.Cards.CardType cardType)
```

## MegaCrit.Sts2.Core.Entities.Cards.CardUpgradePreviewType

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Entities.Cards.CardUpgradePreviewType Combat = 2
public static const MegaCrit.Sts2.Core.Entities.Cards.CardUpgradePreviewType Deck = 1
public static const MegaCrit.Sts2.Core.Entities.Cards.CardUpgradePreviewType None = 0
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Entities.Cards.CardUpgradePreviewTypeExtensions

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static System.Boolean IsPreview(MegaCrit.Sts2.Core.Entities.Cards.CardUpgradePreviewType previewType)
```

## MegaCrit.Sts2.Core.Entities.Cards.CostModifiers

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Entities.Cards.CostModifiers All = -1
public static const MegaCrit.Sts2.Core.Entities.Cards.CostModifiers Global = 4
public static const MegaCrit.Sts2.Core.Entities.Cards.CostModifiers Local = 2
public static const MegaCrit.Sts2.Core.Entities.Cards.CostModifiers None = 0
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Entities.Cards.KeywordSources

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Entities.Cards.KeywordSources All = -1
public static const MegaCrit.Sts2.Core.Entities.Cards.KeywordSources Global = 4
public static const MegaCrit.Sts2.Core.Entities.Cards.KeywordSources Local = 2
public static const MegaCrit.Sts2.Core.Entities.Cards.KeywordSources None = 0
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Entities.Cards.LocalCostModifier

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private System.Int32 <Amount>k__BackingField
private readonly MegaCrit.Sts2.Core.Entities.Cards.LocalCostModifierExpiration <Expiration>k__BackingField
private readonly System.Boolean <IsReduceOnly>k__BackingField
private readonly MegaCrit.Sts2.Core.Entities.Cards.LocalCostType <Type>k__BackingField
System.Int32 Amount { public get; public set; }
MegaCrit.Sts2.Core.Entities.Cards.LocalCostModifierExpiration Expiration { public get; }
System.Boolean IsReduceOnly { public get; }
MegaCrit.Sts2.Core.Entities.Cards.LocalCostType Type { public get; }
public .ctor(System.Int32 amount, MegaCrit.Sts2.Core.Entities.Cards.LocalCostType type, MegaCrit.Sts2.Core.Entities.Cards.LocalCostModifierExpiration expiration, System.Boolean reduceOnly)
public MegaCrit.Sts2.Core.Entities.Cards.LocalCostModifier Clone()
public MegaCrit.Sts2.Core.Entities.Cards.LocalCostModifierExpiration get_Expiration()
public MegaCrit.Sts2.Core.Entities.Cards.LocalCostType get_Type()
public System.Boolean get_IsReduceOnly()
public System.Int32 get_Amount()
public System.Int32 Modify(System.Int32 currentCost)
public System.Void set_Amount(System.Int32 value)
```

## MegaCrit.Sts2.Core.Entities.Cards.LocalCostModifierExpiration

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Entities.Cards.LocalCostModifierExpiration EndOfCombat = 0
public static const MegaCrit.Sts2.Core.Entities.Cards.LocalCostModifierExpiration EndOfTurn = 2
public System.Int32 value__
public static const MegaCrit.Sts2.Core.Entities.Cards.LocalCostModifierExpiration WhenPlayed = 4
```

## MegaCrit.Sts2.Core.Entities.Cards.LocalCostType

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Entities.Cards.LocalCostType Absolute = 1
public static const MegaCrit.Sts2.Core.Entities.Cards.LocalCostType None = 0
public static const MegaCrit.Sts2.Core.Entities.Cards.LocalCostType Relative = 2
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Entities.Cards.OrbEvokeType

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Entities.Cards.OrbEvokeType All = 2
public static const MegaCrit.Sts2.Core.Entities.Cards.OrbEvokeType Front = 1
public static const MegaCrit.Sts2.Core.Entities.Cards.OrbEvokeType None = 0
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Entities.Cards.PileType

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Entities.Cards.PileType Deck = 6
public static const MegaCrit.Sts2.Core.Entities.Cards.PileType Discard = 3
public static const MegaCrit.Sts2.Core.Entities.Cards.PileType Draw = 1
public static const MegaCrit.Sts2.Core.Entities.Cards.PileType Exhaust = 4
public static const MegaCrit.Sts2.Core.Entities.Cards.PileType Hand = 2
public static const MegaCrit.Sts2.Core.Entities.Cards.PileType None = 0
public static const MegaCrit.Sts2.Core.Entities.Cards.PileType Play = 5
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Entities.Cards.PileTypeExtensions

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static Godot.Vector2 GetTargetPosition(MegaCrit.Sts2.Core.Entities.Cards.PileType pileType, MegaCrit.Sts2.Core.Nodes.Cards.NCard node)
public static MegaCrit.Sts2.Core.Entities.Cards.CardPile GetPile(MegaCrit.Sts2.Core.Entities.Cards.PileType pileType, MegaCrit.Sts2.Core.Entities.Players.Player player)
public static System.Boolean IsCombatPile(MegaCrit.Sts2.Core.Entities.Cards.PileType pileType)
```

## MegaCrit.Sts2.Core.Entities.Cards.ResourceInfo

类型属性：`Public, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：

```text
private readonly System.Int32 <EnergySpent>k__BackingField
private readonly System.Int32 <EnergyValue>k__BackingField
private readonly System.Int32 <StarsSpent>k__BackingField
private readonly System.Int32 <StarValue>k__BackingField
System.Int32 EnergySpent { public get; public set; }
System.Int32 EnergyValue { public get; public set; }
System.Int32 StarsSpent { public get; public set; }
System.Int32 StarValue { public get; public set; }
public System.Int32 get_EnergySpent()
public System.Int32 get_EnergyValue()
public System.Int32 get_StarsSpent()
public System.Int32 get_StarValue()
public System.Void set_EnergySpent(System.Int32 value)
public System.Void set_EnergyValue(System.Int32 value)
public System.Void set_StarsSpent(System.Int32 value)
public System.Void set_StarValue(System.Int32 value)
```

## MegaCrit.Sts2.Core.Entities.Cards.TargetType

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Entities.Cards.TargetType AllAllies = 7
public static const MegaCrit.Sts2.Core.Entities.Cards.TargetType AllEnemies = 3
public static const MegaCrit.Sts2.Core.Entities.Cards.TargetType AnyAlly = 6
public static const MegaCrit.Sts2.Core.Entities.Cards.TargetType AnyEnemy = 2
public static const MegaCrit.Sts2.Core.Entities.Cards.TargetType AnyPlayer = 5
public static const MegaCrit.Sts2.Core.Entities.Cards.TargetType None = 0
public static const MegaCrit.Sts2.Core.Entities.Cards.TargetType Osty = 9
public static const MegaCrit.Sts2.Core.Entities.Cards.TargetType RandomEnemy = 4
public static const MegaCrit.Sts2.Core.Entities.Cards.TargetType Self = 1
public static const MegaCrit.Sts2.Core.Entities.Cards.TargetType TargetedNoCreature = 8
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Entities.Cards.TemporaryCardCost

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private System.Boolean <ClearsWhenCardIsPlayed>k__BackingField
private System.Boolean <ClearsWhenTurnEnds>k__BackingField
private System.Int32 <Cost>k__BackingField
System.Boolean ClearsWhenCardIsPlayed { public get; private set; }
System.Boolean ClearsWhenTurnEnds { public get; private set; }
System.Int32 Cost { public get; private set; }
public .ctor()
private System.Void set_ClearsWhenCardIsPlayed(System.Boolean value)
private System.Void set_ClearsWhenTurnEnds(System.Boolean value)
private System.Void set_Cost(System.Int32 value)
public static MegaCrit.Sts2.Core.Entities.Cards.TemporaryCardCost ThisCombat(System.Int32 cost)
public static MegaCrit.Sts2.Core.Entities.Cards.TemporaryCardCost ThisTurn(System.Int32 cost)
public static MegaCrit.Sts2.Core.Entities.Cards.TemporaryCardCost UntilPlayed(System.Int32 cost)
public System.Boolean get_ClearsWhenCardIsPlayed()
public System.Boolean get_ClearsWhenTurnEnds()
public System.Int32 get_Cost()
```

## MegaCrit.Sts2.Core.Entities.Cards.TemporaryCardCostOffset

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private System.Boolean <ClearsWhenCardIsPlayed>k__BackingField
private System.Boolean <ClearsWhenTurnEnds>k__BackingField
private System.Int32 <Offset>k__BackingField
System.Boolean ClearsWhenCardIsPlayed { public get; private set; }
System.Boolean ClearsWhenTurnEnds { public get; private set; }
System.Int32 Offset { public get; private set; }
public .ctor()
private System.Void set_ClearsWhenCardIsPlayed(System.Boolean value)
private System.Void set_ClearsWhenTurnEnds(System.Boolean value)
private System.Void set_Offset(System.Int32 value)
public static MegaCrit.Sts2.Core.Entities.Cards.TemporaryCardCostOffset ThisCombat(System.Int32 offset)
public static MegaCrit.Sts2.Core.Entities.Cards.TemporaryCardCostOffset ThisTurn(System.Int32 offset)
public static MegaCrit.Sts2.Core.Entities.Cards.TemporaryCardCostOffset UntilPlayed(System.Int32 offset)
public System.Boolean get_ClearsWhenCardIsPlayed()
public System.Boolean get_ClearsWhenTurnEnds()
public System.Int32 get_Offset()
```

## MegaCrit.Sts2.Core.Entities.Cards.UnplayableReason

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Entities.Cards.UnplayableReason BlockedByCardLogic = 8
public static const MegaCrit.Sts2.Core.Entities.Cards.UnplayableReason BlockedByHook = 4
public static const MegaCrit.Sts2.Core.Entities.Cards.UnplayableReason EnergyCostTooHigh = 16
public static const MegaCrit.Sts2.Core.Entities.Cards.UnplayableReason HasUnplayableKeyword = 2
public static const MegaCrit.Sts2.Core.Entities.Cards.UnplayableReason NoLivingAllies = 64
public static const MegaCrit.Sts2.Core.Entities.Cards.UnplayableReason None = 0
public static const MegaCrit.Sts2.Core.Entities.Cards.UnplayableReason StarCostTooHigh = 32
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Entities.Cards.UnplayableReasonExtensions

类型属性：`Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static MegaCrit.Sts2.Core.Localization.LocString GetPlayerDialogueLine(MegaCrit.Sts2.Core.Entities.Cards.UnplayableReason reason, MegaCrit.Sts2.Core.Models.AbstractModel preventer = null)
public static System.Boolean HasResourceCostReason(MegaCrit.Sts2.Core.Entities.Cards.UnplayableReason reason)
```
