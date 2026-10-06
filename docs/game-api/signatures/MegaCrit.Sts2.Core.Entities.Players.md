# MegaCrit.Sts2.Core.Entities.Players

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Entities.Players.ExtraPlayerFields

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private System.Int32 <CardShopRemovalsUsed>k__BackingField
private System.Boolean <CccomboBadgeUnlocked>k__BackingField
private System.Int32 <DamageDealt>k__BackingField
private System.Int32 <DebuffsApplied>k__BackingField
private System.Int32 <WongoPoints>k__BackingField
System.Int32 CardShopRemovalsUsed { public get; public set; }
System.Boolean CccomboBadgeUnlocked { public get; public set; }
System.Int32 DamageDealt { public get; public set; }
System.Int32 DebuffsApplied { public get; public set; }
System.Int32 WongoPoints { public get; public set; }
public .ctor()
public MegaCrit.Sts2.Core.Saves.SerializableExtraPlayerFields ToSerializable()
public static MegaCrit.Sts2.Core.Entities.Players.ExtraPlayerFields FromSerializable(MegaCrit.Sts2.Core.Saves.SerializableExtraPlayerFields save)
public System.Boolean get_CccomboBadgeUnlocked()
public System.Int32 get_CardShopRemovalsUsed()
public System.Int32 get_DamageDealt()
public System.Int32 get_DebuffsApplied()
public System.Int32 get_WongoPoints()
public System.Void set_CardShopRemovalsUsed(System.Int32 value)
public System.Void set_CccomboBadgeUnlocked(System.Boolean value)
public System.Void set_DamageDealt(System.Int32 value)
public System.Void set_DebuffsApplied(System.Int32 value)
public System.Void set_WongoPoints(System.Int32 value)
```

## MegaCrit.Sts2.Core.Entities.Players.Player

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private System.Boolean _canUseOrRemovePotions
private System.Int32 _gold
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.PotionModel> _potionSlots
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.RelicModel> _relics
private MegaCrit.Sts2.Core.Entities.Cards.CardPile[] _runPiles
private MegaCrit.Sts2.Core.Runs.IRunState _runState
private System.Int32 <BaseOrbSlotCount>k__BackingField
private readonly MegaCrit.Sts2.Core.Models.CharacterModel <Character>k__BackingField
private readonly MegaCrit.Sts2.Core.Entities.Creatures.Creature <Creature>k__BackingField
private readonly MegaCrit.Sts2.Core.Entities.Cards.CardPile <Deck>k__BackingField
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> <DiscoveredCards>k__BackingField
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> <DiscoveredEnemies>k__BackingField
private System.Collections.Generic.List<System.String> <DiscoveredEpochs>k__BackingField
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> <DiscoveredPotions>k__BackingField
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> <DiscoveredRelics>k__BackingField
private MegaCrit.Sts2.Core.Entities.Players.ExtraPlayerFields <ExtraFields>k__BackingField
private System.Boolean <IsActiveForHooks>k__BackingField
private readonly System.Int32 <MaxAscensionWhenRunStarted>k__BackingField
private System.Int32 <MaxEnergy>k__BackingField
private readonly System.UInt64 <NetId>k__BackingField
private MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState <PlayerCombatState>k__BackingField
private MegaCrit.Sts2.Core.Odds.PlayerOddsSet <PlayerOdds>k__BackingField
private MegaCrit.Sts2.Core.Random.PlayerRngSet <PlayerRng>k__BackingField
private readonly MegaCrit.Sts2.Core.Runs.RelicGrabBag <RelicGrabBag>k__BackingField
private readonly MegaCrit.Sts2.Core.Unlocks.UnlockState <UnlockState>k__BackingField
private System.Action AddPotionFailed
private System.Action CanUseOrRemovePotionsChanged
private System.Action GoldChanged
public static const System.Int32 initialMaxPotionSlotCount = 3
private System.Action<System.Int32> MaxPotionCountChanged
private System.Action<MegaCrit.Sts2.Core.Models.PotionModel> PotionDiscarded
private System.Action<MegaCrit.Sts2.Core.Models.PotionModel> PotionProcured
private System.Action<MegaCrit.Sts2.Core.Models.RelicModel> RelicObtained
private System.Action<MegaCrit.Sts2.Core.Models.RelicModel> RelicRemoved
private System.Action<MegaCrit.Sts2.Core.Models.PotionModel> UsedPotionRemoved
System.Int32 BaseOrbSlotCount { public get; public set; }
System.Boolean CanUseOrRemovePotions { public get; public set; }
MegaCrit.Sts2.Core.Models.CharacterModel Character { public get; }
MegaCrit.Sts2.Core.Entities.Creatures.Creature Creature { public get; }
MegaCrit.Sts2.Core.Entities.Cards.CardPile Deck { public get; }
System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> DiscoveredCards { public get; public set; }
System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> DiscoveredEnemies { public get; public set; }
System.Collections.Generic.List<System.String> DiscoveredEpochs { public get; public set; }
System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> DiscoveredPotions { public get; public set; }
System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> DiscoveredRelics { public get; public set; }
MegaCrit.Sts2.Core.Entities.Players.ExtraPlayerFields ExtraFields { public get; private set; }
System.Int32 Gold { public get; public set; }
System.Boolean HasOpenPotionSlots { public get; }
System.Boolean IsActiveForHooks { public get; private set; }
System.Boolean IsInventoryPopulated { private get; }
System.Boolean IsOstyAlive { public get; }
System.Boolean IsOstyMissing { public get; }
System.Int32 MaxAscensionWhenRunStarted { public get; }
System.Int32 MaxEnergy { public get; public set; }
System.Int32 MaxPotionCount { public get; }
System.UInt64 NetId { public get; }
MegaCrit.Sts2.Core.Entities.Creatures.Creature Osty { public get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Cards.CardPile> Piles { public get; }
MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState PlayerCombatState { public get; private set; }
MegaCrit.Sts2.Core.Odds.PlayerOddsSet PlayerOdds { public get; private set; }
MegaCrit.Sts2.Core.Random.PlayerRngSet PlayerRng { public get; private set; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.PotionModel> Potions { public get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.PotionModel> PotionSlots { public get; }
MegaCrit.Sts2.Core.Runs.RelicGrabBag RelicGrabBag { public get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.RelicModel> Relics { public get; }
MegaCrit.Sts2.Core.Runs.IRunState RunState { public get; public set; }
MegaCrit.Sts2.Core.Unlocks.UnlockState UnlockState { public get; }
event System.Action AddPotionFailed
event System.Action CanUseOrRemovePotionsChanged
event System.Action GoldChanged
event System.Action<System.Int32> MaxPotionCountChanged
event System.Action<MegaCrit.Sts2.Core.Models.PotionModel> PotionDiscarded
event System.Action<MegaCrit.Sts2.Core.Models.PotionModel> PotionProcured
event System.Action<MegaCrit.Sts2.Core.Models.RelicModel> RelicObtained
event System.Action<MegaCrit.Sts2.Core.Models.RelicModel> RelicRemoved
event System.Action<MegaCrit.Sts2.Core.Models.PotionModel> UsedPotionRemoved
private .ctor(MegaCrit.Sts2.Core.Models.CharacterModel character, System.UInt64 netId, System.Int32 currentHp, System.Int32 maxHp, System.Int32 maxEnergy, System.Int32 gold, System.Int32 potionSlotCount, System.Int32 orbSlotCount, MegaCrit.Sts2.Core.Runs.RelicGrabBag sharedRelicGrabBag, MegaCrit.Sts2.Core.Unlocks.UnlockState unlockState, System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> discoveredCards = null, System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> discoveredEnemies = null, System.Collections.Generic.List<System.String> discoveredEpochs = null, System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> discoveredPotions = null, System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> discoveredRelics = null)
private MegaCrit.Sts2.Core.Models.CardModel <SyncWithSerializedPlayer>b__142_0(MegaCrit.Sts2.Core.Saves.Runs.SerializableCard c)
private System.Boolean get_IsInventoryPopulated()
private System.Void LoadInventory(MegaCrit.Sts2.Core.Saves.Runs.SerializablePlayer save)
private System.Void LoadPotions(System.Collections.Generic.List<MegaCrit.Sts2.Core.Saves.Runs.SerializablePotion> serializablePotions, System.Boolean silent = False)
private System.Void OnRelicFlashed(MegaCrit.Sts2.Core.Models.RelicModel relic, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature> targets)
private System.Void PopulateDeck(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> cards, System.Boolean silent = False)
private System.Void PopulateRelics(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.RelicModel> relics, System.Boolean silent = False)
private System.Void PopulateStartingDeck()
private System.Void PopulateStartingInventory()
private System.Void PopulateStartingRelics()
private System.Void RemovePotionInternal(MegaCrit.Sts2.Core.Models.PotionModel potion)
private System.Void set_ExtraFields(MegaCrit.Sts2.Core.Entities.Players.ExtraPlayerFields value)
private System.Void set_IsActiveForHooks(System.Boolean value)
private System.Void set_PlayerCombatState(MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState value)
private System.Void set_PlayerOdds(MegaCrit.Sts2.Core.Odds.PlayerOddsSet value)
private System.Void set_PlayerRng(MegaCrit.Sts2.Core.Random.PlayerRngSet value)
private System.Void SetMaxPotionCountInternal(System.Int32 newMaxPotionCount)
public [async] System.Threading.Tasks.Task ReviveBeforeCombatEnd()
public MegaCrit.Sts2.Core.Entities.Cards.CardPile get_Deck()
public MegaCrit.Sts2.Core.Entities.Creatures.Creature get_Creature()
public MegaCrit.Sts2.Core.Entities.Creatures.Creature get_Osty()
public MegaCrit.Sts2.Core.Entities.Players.ExtraPlayerFields get_ExtraFields()
public MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState get_PlayerCombatState()
public MegaCrit.Sts2.Core.Entities.Potions.PotionProcureResult AddPotionInternal(MegaCrit.Sts2.Core.Models.PotionModel potion, System.Int32 slotIndex = -1, System.Boolean silent = False)
public MegaCrit.Sts2.Core.Models.CharacterModel get_Character()
public MegaCrit.Sts2.Core.Models.PotionModel GetPotionAtSlotIndex(System.Int32 index)
public MegaCrit.Sts2.Core.Models.RelicModel GetRelicById(MegaCrit.Sts2.Core.Models.ModelId id)
public MegaCrit.Sts2.Core.Odds.PlayerOddsSet get_PlayerOdds()
public MegaCrit.Sts2.Core.Random.PlayerRngSet get_PlayerRng()
public MegaCrit.Sts2.Core.Runs.IRunState get_RunState()
public MegaCrit.Sts2.Core.Runs.RelicGrabBag get_RelicGrabBag()
public MegaCrit.Sts2.Core.Saves.Runs.SerializablePlayer ToSerializable()
public MegaCrit.Sts2.Core.Unlocks.UnlockState get_UnlockState()
public static MegaCrit.Sts2.Core.Entities.Players.Player CreateForNewRun(MegaCrit.Sts2.Core.Models.CharacterModel character, MegaCrit.Sts2.Core.Unlocks.UnlockState unlockState, System.UInt64 netId)
public static MegaCrit.Sts2.Core.Entities.Players.Player CreateForNewRun<T>(MegaCrit.Sts2.Core.Unlocks.UnlockState unlockState, System.UInt64 netId) where T: [None] MegaCrit.Sts2.Core.Models.CharacterModel
public static MegaCrit.Sts2.Core.Entities.Players.Player FromSerializable(MegaCrit.Sts2.Core.Saves.Runs.SerializablePlayer save)
public System.Boolean get_CanUseOrRemovePotions()
public System.Boolean get_HasOpenPotionSlots()
public System.Boolean get_IsActiveForHooks()
public System.Boolean get_IsOstyAlive()
public System.Boolean get_IsOstyMissing()
public System.Boolean HasEventPet()
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Cards.CardPile> get_Piles()
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.PotionModel> get_Potions()
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.PotionModel> get_PotionSlots()
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.RelicModel> get_Relics()
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> get_DiscoveredCards()
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> get_DiscoveredEnemies()
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> get_DiscoveredPotions()
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> get_DiscoveredRelics()
public System.Collections.Generic.List<System.String> get_DiscoveredEpochs()
public System.Int32 get_BaseOrbSlotCount()
public System.Int32 get_Gold()
public System.Int32 get_MaxAscensionWhenRunStarted()
public System.Int32 get_MaxEnergy()
public System.Int32 get_MaxPotionCount()
public System.Int32 GetPotionSlotIndex(MegaCrit.Sts2.Core.Models.PotionModel model)
public System.UInt64 get_NetId()
public System.Void ActivateHooks()
public System.Void add_AddPotionFailed(System.Action value)
public System.Void add_CanUseOrRemovePotionsChanged(System.Action value)
public System.Void add_GoldChanged(System.Action value)
public System.Void add_MaxPotionCountChanged(System.Action<System.Int32> value)
public System.Void add_PotionDiscarded(System.Action<MegaCrit.Sts2.Core.Models.PotionModel> value)
public System.Void add_PotionProcured(System.Action<MegaCrit.Sts2.Core.Models.PotionModel> value)
public System.Void add_RelicObtained(System.Action<MegaCrit.Sts2.Core.Models.RelicModel> value)
public System.Void add_RelicRemoved(System.Action<MegaCrit.Sts2.Core.Models.RelicModel> value)
public System.Void add_UsedPotionRemoved(System.Action<MegaCrit.Sts2.Core.Models.PotionModel> value)
public System.Void AddRelicInternal(MegaCrit.Sts2.Core.Models.RelicModel relic, System.Int32 index = -1, System.Boolean silent = False)
public System.Void AddToMaxPotionCount(System.Int32 maxPotionCountIncrease)
public System.Void AfterCombatEnd()
public System.Void DeactivateHooks()
public System.Void DiscardPotionInternal(MegaCrit.Sts2.Core.Models.PotionModel potion, System.Boolean silent = False)
public System.Void InitializeSeed(System.String seed)
public System.Void MeltRelicInternal(MegaCrit.Sts2.Core.Models.RelicModel relic)
public System.Void OnSideSwitch()
public System.Void PopulateCombatState(MegaCrit.Sts2.Core.Random.Rng rng, MegaCrit.Sts2.Core.Combat.CombatState state)
public System.Void PopulateRelicGrabBagIfNecessary(MegaCrit.Sts2.Core.Random.Rng rng)
public System.Void remove_AddPotionFailed(System.Action value)
public System.Void remove_CanUseOrRemovePotionsChanged(System.Action value)
public System.Void remove_GoldChanged(System.Action value)
public System.Void remove_MaxPotionCountChanged(System.Action<System.Int32> value)
public System.Void remove_PotionDiscarded(System.Action<MegaCrit.Sts2.Core.Models.PotionModel> value)
public System.Void remove_PotionProcured(System.Action<MegaCrit.Sts2.Core.Models.PotionModel> value)
public System.Void remove_RelicObtained(System.Action<MegaCrit.Sts2.Core.Models.RelicModel> value)
public System.Void remove_RelicRemoved(System.Action<MegaCrit.Sts2.Core.Models.RelicModel> value)
public System.Void remove_UsedPotionRemoved(System.Action<MegaCrit.Sts2.Core.Models.PotionModel> value)
public System.Void RemoveRelicInternal(MegaCrit.Sts2.Core.Models.RelicModel relic, System.Boolean silent = False)
public System.Void RemoveUsedPotionInternal(MegaCrit.Sts2.Core.Models.PotionModel potion)
public System.Void ResetCombatState()
public System.Void set_BaseOrbSlotCount(System.Int32 value)
public System.Void set_CanUseOrRemovePotions(System.Boolean value)
public System.Void set_DiscoveredCards(System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> value)
public System.Void set_DiscoveredEnemies(System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> value)
public System.Void set_DiscoveredEpochs(System.Collections.Generic.List<System.String> value)
public System.Void set_DiscoveredPotions(System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> value)
public System.Void set_DiscoveredRelics(System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> value)
public System.Void set_Gold(System.Int32 value)
public System.Void set_MaxEnergy(System.Int32 value)
public System.Void set_RunState(MegaCrit.Sts2.Core.Runs.IRunState value)
public System.Void SubtractFromMaxPotionCount(System.Int32 maxPotionCountDecrease)
public System.Void SyncWithSerializedPlayer(MegaCrit.Sts2.Core.Saves.Runs.SerializablePlayer player)
public T GetRelic<T>() where T: [None] MegaCrit.Sts2.Core.Models.RelicModel
```

## MegaCrit.Sts2.Core.Entities.Players.Player+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Entities.Players.Player+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Models.PotionModel, MegaCrit.Sts2.Core.Models.PotionModel> <>9__138_0
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, MegaCrit.Sts2.Core.Saves.Runs.SerializableCard> <>9__141_0
public static System.Func<MegaCrit.Sts2.Core.Models.RelicModel, MegaCrit.Sts2.Core.Saves.Runs.SerializableRelic> <>9__141_1
public static System.Func<MegaCrit.Sts2.Core.Models.PotionModel, System.Int32, MegaCrit.Sts2.Core.Saves.Runs.SerializablePotion> <>9__141_2
public static System.Func<MegaCrit.Sts2.Core.Models.RelicModel, MegaCrit.Sts2.Core.Models.RelicModel> <>9__159_0
public static System.Func<MegaCrit.Sts2.Core.Models.PotionModel, System.Boolean> <>9__74_0
public static System.Func<MegaCrit.Sts2.Core.Models.RelicModel, System.Boolean> <>9__81_0
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> <>9__81_1
public static System.Func<MegaCrit.Sts2.Core.Models.PotionModel, System.Boolean> <>9__90_0
private static .cctor()
public .ctor()
internal MegaCrit.Sts2.Core.Models.PotionModel <PopulateStartingInventory>b__138_0(MegaCrit.Sts2.Core.Models.PotionModel p)
internal MegaCrit.Sts2.Core.Models.RelicModel <PopulateStartingRelics>b__159_0(MegaCrit.Sts2.Core.Models.RelicModel r)
internal MegaCrit.Sts2.Core.Saves.Runs.SerializableCard <ToSerializable>b__141_0(MegaCrit.Sts2.Core.Models.CardModel c)
internal MegaCrit.Sts2.Core.Saves.Runs.SerializablePotion <ToSerializable>b__141_2(MegaCrit.Sts2.Core.Models.PotionModel p, System.Int32 i)
internal MegaCrit.Sts2.Core.Saves.Runs.SerializableRelic <ToSerializable>b__141_1(MegaCrit.Sts2.Core.Models.RelicModel r)
internal System.Boolean <get_HasOpenPotionSlots>b__90_0(MegaCrit.Sts2.Core.Models.PotionModel p)
internal System.Boolean <get_Potions>b__74_0(MegaCrit.Sts2.Core.Models.PotionModel p)
internal System.Boolean <HasEventPet>b__81_0(MegaCrit.Sts2.Core.Models.RelicModel r)
internal System.Boolean <HasEventPet>b__81_1(MegaCrit.Sts2.Core.Models.CardModel c)
```

## MegaCrit.Sts2.Core.Entities.Players.Player+<>c__146<T>

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Entities.Players.Player+<>c__146<T> <>9
public static System.Func<MegaCrit.Sts2.Core.Models.RelicModel, System.Boolean> <>9__146_0
private static .cctor()
public .ctor()
internal System.Boolean <GetRelic>b__146_0(MegaCrit.Sts2.Core.Models.RelicModel r)
```

## MegaCrit.Sts2.Core.Entities.Players.Player+<>c__DisplayClass147_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Models.ModelId id
public .ctor()
internal System.Boolean <GetRelicById>b__0(MegaCrit.Sts2.Core.Models.RelicModel r)
```

## MegaCrit.Sts2.Core.Entities.Players.Player+<>O

类型属性：`NestedPrivate, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static System.Func<MegaCrit.Sts2.Core.Saves.Runs.SerializableCard, MegaCrit.Sts2.Core.Models.CardModel> <0>__FromSerializable
public static System.Func<MegaCrit.Sts2.Core.Saves.Runs.SerializableRelic, MegaCrit.Sts2.Core.Models.RelicModel> <1>__FromSerializable
```

## MegaCrit.Sts2.Core.Entities.Players.Player+<ReviveBeforeCombatEnd>d__164

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Entities.Players.Player <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private System.Int32 _energy
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Creatures.Creature> _pets
private MegaCrit.Sts2.Core.Combat.PlayerTurnPhase _phase
private MegaCrit.Sts2.Core.Entities.Cards.CardPile[] _piles
private readonly MegaCrit.Sts2.Core.Entities.Players.Player _player
private System.Int32 _stars
private readonly MegaCrit.Sts2.Core.Entities.Cards.CardPile <DiscardPile>k__BackingField
private readonly MegaCrit.Sts2.Core.Entities.Cards.CardPile <DrawPile>k__BackingField
private readonly MegaCrit.Sts2.Core.Entities.Cards.CardPile <ExhaustPile>k__BackingField
private readonly MegaCrit.Sts2.Core.Entities.Cards.CardPile <Hand>k__BackingField
private readonly MegaCrit.Sts2.Core.Entities.Orbs.OrbQueue <OrbQueue>k__BackingField
private readonly MegaCrit.Sts2.Core.Entities.Cards.CardPile <PlayPile>k__BackingField
private System.Int32 <TurnNumber>k__BackingField
private System.Action<System.Int32, System.Int32> EnergyChanged
private System.Action PlayerTurnPhaseChanged
private System.Action<System.Int32, System.Int32> StarsChanged
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> AllCards { public get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Cards.CardPile> AllPiles { public get; }
MegaCrit.Sts2.Core.Entities.Cards.CardPile DiscardPile { public get; }
MegaCrit.Sts2.Core.Entities.Cards.CardPile DrawPile { public get; }
System.Int32 Energy { public get; public set; }
MegaCrit.Sts2.Core.Entities.Cards.CardPile ExhaustPile { public get; }
MegaCrit.Sts2.Core.Entities.Cards.CardPile Hand { public get; }
System.Int32 MaxEnergy { public get; }
MegaCrit.Sts2.Core.Entities.Orbs.OrbQueue OrbQueue { public get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> Pets { public get; }
MegaCrit.Sts2.Core.Combat.PlayerTurnPhase Phase { public get; public set; }
MegaCrit.Sts2.Core.Entities.Cards.CardPile PlayPile { public get; }
System.Int32 Stars { public get; public set; }
System.Int32 TurnNumber { public get; private set; }
event System.Action<System.Int32, System.Int32> EnergyChanged
event System.Action PlayerTurnPhaseChanged
event System.Action<System.Int32, System.Int32> StarsChanged
public .ctor(MegaCrit.Sts2.Core.Entities.Players.Player player)
private System.Void OnPetDied(MegaCrit.Sts2.Core.Entities.Creatures.Creature pet)
private System.Void set_TurnNumber(System.Int32 value)
public MegaCrit.Sts2.Core.Combat.PlayerTurnPhase get_Phase()
public MegaCrit.Sts2.Core.Entities.Cards.CardPile get_DiscardPile()
public MegaCrit.Sts2.Core.Entities.Cards.CardPile get_DrawPile()
public MegaCrit.Sts2.Core.Entities.Cards.CardPile get_ExhaustPile()
public MegaCrit.Sts2.Core.Entities.Cards.CardPile get_Hand()
public MegaCrit.Sts2.Core.Entities.Cards.CardPile get_PlayPile()
public MegaCrit.Sts2.Core.Entities.Creatures.Creature GetPet<T>() where T: [None] MegaCrit.Sts2.Core.Models.MonsterModel
public MegaCrit.Sts2.Core.Entities.Orbs.OrbQueue get_OrbQueue()
public System.Boolean HasCardsToPlay()
public System.Boolean HasEnoughResourcesFor(MegaCrit.Sts2.Core.Models.CardModel card, out MegaCrit.Sts2.Core.Entities.Cards.UnplayableReason reason)
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> get_AllCards()
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Cards.CardPile> get_AllPiles()
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> get_Pets()
public System.Int32 get_Energy()
public System.Int32 get_MaxEnergy()
public System.Int32 get_Stars()
public System.Int32 get_TurnNumber()
public System.Void add_EnergyChanged(System.Action<System.Int32, System.Int32> value)
public System.Void add_PlayerTurnPhaseChanged(System.Action value)
public System.Void add_StarsChanged(System.Action<System.Int32, System.Int32> value)
public System.Void AddMaxEnergyToCurrent()
public System.Void AddPetInternal(MegaCrit.Sts2.Core.Entities.Creatures.Creature pet)
public System.Void AfterCombatEnd()
public System.Void EndOfTurnCleanup()
public System.Void GainEnergy(System.Decimal amount)
public System.Void GainStars(System.Decimal amount)
public System.Void IncrementTurnNumber()
public System.Void LoseEnergy(System.Decimal amount)
public System.Void LoseStars(System.Decimal amount)
public System.Void RecalculateCardValues()
public System.Void remove_EnergyChanged(System.Action<System.Int32, System.Int32> value)
public System.Void remove_PlayerTurnPhaseChanged(System.Action value)
public System.Void remove_StarsChanged(System.Action<System.Int32, System.Int32> value)
public System.Void ResetEnergy()
public System.Void set_Energy(System.Int32 value)
public System.Void set_Phase(MegaCrit.Sts2.Core.Combat.PlayerTurnPhase value)
public System.Void set_Stars(System.Int32 value)
```

## MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Entities.Cards.CardPile, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> <>9__42_0
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> <>9__68_0
private static .cctor()
public .ctor()
internal System.Boolean <HasCardsToPlay>b__68_0(MegaCrit.Sts2.Core.Models.CardModel c)
internal System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> <get_AllCards>b__42_0(MegaCrit.Sts2.Core.Entities.Cards.CardPile p)
```

## MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState+<>c__65<T>

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Entities.Players.PlayerCombatState+<>c__65<T> <>9
public static System.Func<MegaCrit.Sts2.Core.Entities.Creatures.Creature, System.Boolean> <>9__65_0
private static .cctor()
public .ctor()
internal System.Boolean <GetPet>b__65_0(MegaCrit.Sts2.Core.Entities.Creatures.Creature p)
```
