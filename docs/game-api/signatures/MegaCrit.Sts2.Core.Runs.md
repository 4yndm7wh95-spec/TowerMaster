# MegaCrit.Sts2.Core.Runs

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Runs.CardCreationFlags

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Runs.CardCreationFlags ForceRarityOddsChange = 64
public static const MegaCrit.Sts2.Core.Runs.CardCreationFlags IsCardReward = 128
public static const MegaCrit.Sts2.Core.Runs.CardCreationFlags IsFromCombat = 256
public static const MegaCrit.Sts2.Core.Runs.CardCreationFlags NoCardModelModifications = 32
public static const MegaCrit.Sts2.Core.Runs.CardCreationFlags NoCardPoolModifications = 16
public static const MegaCrit.Sts2.Core.Runs.CardCreationFlags NoHookUpgrades = 4
public static const MegaCrit.Sts2.Core.Runs.CardCreationFlags NoModifications = -1
public static const MegaCrit.Sts2.Core.Runs.CardCreationFlags NoModifyHooks = 8
public static const MegaCrit.Sts2.Core.Runs.CardCreationFlags NoRarityModification = 1
public static const MegaCrit.Sts2.Core.Runs.CardCreationFlags NoUpgradeRoll = 2
public static const MegaCrit.Sts2.Core.Runs.CardCreationFlags NoUpgrades = 6
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Runs.CardCreationOptions

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：`System.IEquatable<MegaCrit.Sts2.Core.Runs.CardCreationOptions>`

```text
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.CardPoolModel> _cardPools
private System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> <CardPoolFilter>k__BackingField
private MegaCrit.Sts2.Core.Runs.CardCreationFlags <Flags>k__BackingField
private MegaCrit.Sts2.Core.Runs.CardRarityOddsType <RarityOdds>k__BackingField
private MegaCrit.Sts2.Core.Random.Rng <RngOverride>k__BackingField
private MegaCrit.Sts2.Core.Runs.CardCreationSource <Source>k__BackingField
System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> CardPoolFilter { public get; private set; }
System.Collections.Generic.IReadOnlyCollection<MegaCrit.Sts2.Core.Models.CardPoolModel> CardPools { public get; }
System.Type EqualityContract { protected virtual get; }
MegaCrit.Sts2.Core.Runs.CardCreationFlags Flags { public get; private set; }
MegaCrit.Sts2.Core.Runs.CardRarityOddsType RarityOdds { public get; private set; }
MegaCrit.Sts2.Core.Random.Rng RngOverride { public get; private set; }
MegaCrit.Sts2.Core.Runs.CardCreationSource Source { public get; private set; }
protected .ctor(MegaCrit.Sts2.Core.Runs.CardCreationOptions original)
public .ctor(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardPoolModel> cardPools, MegaCrit.Sts2.Core.Runs.CardCreationSource source, MegaCrit.Sts2.Core.Runs.CardRarityOddsType rarityOdds, System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> cardPoolFilter = null)
private System.Void set_CardPoolFilter(System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> value)
private System.Void set_Flags(MegaCrit.Sts2.Core.Runs.CardCreationFlags value)
private System.Void set_RarityOdds(MegaCrit.Sts2.Core.Runs.CardRarityOddsType value)
private System.Void set_RngOverride(MegaCrit.Sts2.Core.Random.Rng value)
private System.Void set_Source(MegaCrit.Sts2.Core.Runs.CardCreationSource value)
protected virtual System.Boolean PrintMembers(System.Text.StringBuilder builder)
protected virtual System.Type get_EqualityContract()
public MegaCrit.Sts2.Core.Random.Rng get_RngOverride()
public MegaCrit.Sts2.Core.Runs.CardCreationFlags get_Flags()
public MegaCrit.Sts2.Core.Runs.CardCreationOptions WithCardPools(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardPoolModel> pools)
public MegaCrit.Sts2.Core.Runs.CardCreationOptions WithFilter(System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> filter)
public MegaCrit.Sts2.Core.Runs.CardCreationOptions WithFlags(MegaCrit.Sts2.Core.Runs.CardCreationFlags flag)
public MegaCrit.Sts2.Core.Runs.CardCreationOptions WithRarityOdds(MegaCrit.Sts2.Core.Runs.CardRarityOddsType rarityOdds)
public MegaCrit.Sts2.Core.Runs.CardCreationOptions WithRngOverride(MegaCrit.Sts2.Core.Random.Rng rng)
public MegaCrit.Sts2.Core.Runs.CardCreationSource get_Source()
public MegaCrit.Sts2.Core.Runs.CardRarityOddsType get_RarityOdds()
public static MegaCrit.Sts2.Core.Runs.CardCreationOptions ForNonCombatWithDefaultOdds(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardPoolModel> cardPools, System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> cardPoolFilter = null)
public static MegaCrit.Sts2.Core.Runs.CardCreationOptions ForNonCombatWithUniformOdds(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardPoolModel> cardPools, System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> cardPoolFilter = null)
public static MegaCrit.Sts2.Core.Runs.CardCreationOptions ForRoom(MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.Rooms.RoomType roomType)
public static System.Boolean op_Equality(MegaCrit.Sts2.Core.Runs.CardCreationOptions left, MegaCrit.Sts2.Core.Runs.CardCreationOptions right)
public static System.Boolean op_Inequality(MegaCrit.Sts2.Core.Runs.CardCreationOptions left, MegaCrit.Sts2.Core.Runs.CardCreationOptions right)
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> GetPossibleCards(MegaCrit.Sts2.Core.Entities.Players.Player player)
public System.Collections.Generic.IReadOnlyCollection<MegaCrit.Sts2.Core.Models.CardPoolModel> get_CardPools()
public System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> get_CardPoolFilter()
public System.Nullable<MegaCrit.Sts2.Core.Entities.Cards.CardRarity> TryGetSingleRarityInPool()
public virtual MegaCrit.Sts2.Core.Runs.CardCreationOptions <Clone>$()
public virtual System.Boolean Equals(MegaCrit.Sts2.Core.Runs.CardCreationOptions other)
public virtual System.Boolean Equals(System.Object obj)
public virtual System.Int32 GetHashCode()
public virtual System.String ToString()
```

## MegaCrit.Sts2.Core.Runs.CardCreationOptions+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Runs.CardCreationOptions+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Models.CardPoolModel, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> <>9__35_0
private static .cctor()
public .ctor()
internal System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> <TryGetSingleRarityInPool>b__35_0(MegaCrit.Sts2.Core.Models.CardPoolModel c)
```

## MegaCrit.Sts2.Core.Runs.CardCreationOptions+<>c__DisplayClass29_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Runs.CardCreationOptions <>4__this
public MegaCrit.Sts2.Core.Entities.Players.Player player
public .ctor()
internal System.Boolean <GetPossibleCards>b__1(MegaCrit.Sts2.Core.Models.CardModel c)
internal System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> <GetPossibleCards>b__0(MegaCrit.Sts2.Core.Models.CardPoolModel p)
```

## MegaCrit.Sts2.Core.Runs.CardCreationOptions+<>c__DisplayClass35_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Runs.CardCreationOptions <>4__this
public MegaCrit.Sts2.Core.Models.CardModel first
public .ctor()
internal System.Boolean <TryGetSingleRarityInPool>b__1(MegaCrit.Sts2.Core.Models.CardModel c)
internal System.Boolean <TryGetSingleRarityInPool>b__2(MegaCrit.Sts2.Core.Models.CardModel c)
```

## MegaCrit.Sts2.Core.Runs.CardCreationSource

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Runs.CardCreationSource Encounter = 1
public static const MegaCrit.Sts2.Core.Runs.CardCreationSource None = 0
public static const MegaCrit.Sts2.Core.Runs.CardCreationSource Other = 3
public static const MegaCrit.Sts2.Core.Runs.CardCreationSource Shop = 2
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Runs.CardRarityOddsType

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Runs.CardRarityOddsType BossEncounter = 3
public static const MegaCrit.Sts2.Core.Runs.CardRarityOddsType EliteEncounter = 2
public static const MegaCrit.Sts2.Core.Runs.CardRarityOddsType None = 0
public static const MegaCrit.Sts2.Core.Runs.CardRarityOddsType RegularEncounter = 1
public static const MegaCrit.Sts2.Core.Runs.CardRarityOddsType Shop = 4
public static const MegaCrit.Sts2.Core.Runs.CardRarityOddsType Uniform = 5
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Runs.ExtraRunFields

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private System.Boolean <FreedRepy>k__BackingField
private System.Boolean <StartedWithNeow>k__BackingField
private System.Int32 <TestSubjectKills>k__BackingField
System.Boolean FreedRepy { public get; public set; }
System.Boolean StartedWithNeow { public get; public set; }
System.Int32 TestSubjectKills { public get; public set; }
public .ctor()
public MegaCrit.Sts2.Core.Saves.Runs.SerializableExtraRunFields ToSerializable()
public static MegaCrit.Sts2.Core.Runs.ExtraRunFields FromSerializable(MegaCrit.Sts2.Core.Saves.Runs.SerializableExtraRunFields save)
public System.Boolean get_FreedRepy()
public System.Boolean get_StartedWithNeow()
public System.Int32 get_TestSubjectKills()
public System.Void set_FreedRepy(System.Boolean value)
public System.Void set_StartedWithNeow(System.Boolean value)
public System.Void set_TestSubjectKills(System.Int32 value)
```

## MegaCrit.Sts2.Core.Runs.GameMode

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Runs.GameMode Custom = 3
public static const MegaCrit.Sts2.Core.Runs.GameMode Daily = 2
public static const MegaCrit.Sts2.Core.Runs.GameMode None = 0
public static const MegaCrit.Sts2.Core.Runs.GameMode Standard = 1
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Runs.GameModeExtension

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static System.Boolean AreAchievementsAndEpochsLocked(MegaCrit.Sts2.Core.Runs.GameMode gameMode)
```

## MegaCrit.Sts2.Core.Runs.ICardScope

类型属性：`Public, ClassSemanticsMask, Abstract, BeforeFieldInit`；基类：`无`。

接口：

```text
public abstract MegaCrit.Sts2.Core.Models.CardModel CloneCard(MegaCrit.Sts2.Core.Models.CardModel mutableCard)
public abstract MegaCrit.Sts2.Core.Models.CardModel CreateCard(MegaCrit.Sts2.Core.Models.CardModel canonicalCard, MegaCrit.Sts2.Core.Entities.Players.Player owner)
public abstract System.Void AddCard(MegaCrit.Sts2.Core.Models.CardModel mutableCard, MegaCrit.Sts2.Core.Entities.Players.Player owner)
public abstract System.Void RemoveCard(MegaCrit.Sts2.Core.Models.CardModel card)
public abstract T CreateCard<T>(MegaCrit.Sts2.Core.Entities.Players.Player owner) where T: [None] MegaCrit.Sts2.Core.Models.CardModel
public static MegaCrit.Sts2.Core.Runs.ICardScope DebugOnlyGet(MegaCrit.Sts2.Core.Entities.Cards.CardScope scope)
```

## MegaCrit.Sts2.Core.Runs.IPlayerCollection

类型属性：`Public, ClassSemanticsMask, Abstract, BeforeFieldInit`；基类：`无`。

接口：

```text
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Players.Player> Players { public abstract get; }
public abstract MegaCrit.Sts2.Core.Entities.Players.Player GetPlayer(System.UInt64 netId)
public abstract System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Players.Player> get_Players()
public abstract System.Int32 GetPlayerSlotIndex(MegaCrit.Sts2.Core.Entities.Players.Player player)
```

## MegaCrit.Sts2.Core.Runs.IRunState

类型属性：`Public, ClassSemanticsMask, Abstract, BeforeFieldInit`；基类：`无`。

接口：`MegaCrit.Sts2.Core.Runs.ICardScope`, `MegaCrit.Sts2.Core.Runs.IPlayerCollection`

```text
MegaCrit.Sts2.Core.Models.ActModel Act { public abstract get; }
System.Int32 ActFloor { public abstract get; public abstract set; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel> Acts { public abstract get; }
System.Int32 AscensionLevel { public abstract get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.BadgeModel> BadgeModels { public abstract get; }
MegaCrit.Sts2.Core.Rooms.AbstractRoom BaseRoom { public abstract get; }
MegaCrit.Sts2.Core.Entities.Cards.CardMultiplayerConstraint CardMultiplayerConstraint { public virtual get; }
System.Int32 CurrentActIndex { public abstract get; public abstract set; }
System.Nullable<MegaCrit.Sts2.Core.Map.MapCoord> CurrentMapCoord { public abstract get; }
MegaCrit.Sts2.Core.Map.MapPoint CurrentMapPoint { public abstract get; }
MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry CurrentMapPointHistoryEntry { public abstract get; }
MegaCrit.Sts2.Core.Rooms.AbstractRoom CurrentRoom { public abstract get; }
System.Int32 CurrentRoomCount { public abstract get; }
MegaCrit.Sts2.Core.Runs.ExtraRunFields ExtraFields { public abstract get; }
MegaCrit.Sts2.Core.Runs.GameMode GameMode { public abstract get; }
System.Boolean IsGameOver { public abstract get; }
MegaCrit.Sts2.Core.Map.ActMap Map { public abstract get; public abstract set; }
MegaCrit.Sts2.Core.Runs.MapLocation MapLocation { public abstract get; }
System.Collections.Generic.IReadOnlyList<System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry>> MapPointHistory { public abstract get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel> Modifiers { public abstract get; }
MegaCrit.Sts2.Core.Models.Singleton.MultiplayerScalingModel MultiplayerScalingModel { public abstract get; }
MegaCrit.Sts2.Core.Odds.RunOddsSet Odds { public abstract get; }
MegaCrit.Sts2.Core.Runs.RunRngSet Rng { public abstract get; }
MegaCrit.Sts2.Core.Runs.RunLocation RunLocation { public abstract get; }
MegaCrit.Sts2.Core.Runs.RelicGrabBag SharedRelicGrabBag { public abstract get; }
System.Int32 TotalFloor { public abstract get; }
MegaCrit.Sts2.Core.Unlocks.UnlockState UnlockState { public abstract get; }
public abstract MegaCrit.Sts2.Core.Map.ActMap get_Map()
public abstract MegaCrit.Sts2.Core.Map.MapPoint get_CurrentMapPoint()
public abstract MegaCrit.Sts2.Core.Models.ActModel get_Act()
public abstract MegaCrit.Sts2.Core.Models.CardModel LoadCard(MegaCrit.Sts2.Core.Saves.Runs.SerializableCard serializableCard, MegaCrit.Sts2.Core.Entities.Players.Player owner)
public abstract MegaCrit.Sts2.Core.Models.Singleton.MultiplayerScalingModel get_MultiplayerScalingModel()
public abstract MegaCrit.Sts2.Core.Odds.RunOddsSet get_Odds()
public abstract MegaCrit.Sts2.Core.Rooms.AbstractRoom get_BaseRoom()
public abstract MegaCrit.Sts2.Core.Rooms.AbstractRoom get_CurrentRoom()
public abstract MegaCrit.Sts2.Core.Runs.ExtraRunFields get_ExtraFields()
public abstract MegaCrit.Sts2.Core.Runs.GameMode get_GameMode()
public abstract MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry get_CurrentMapPointHistoryEntry()
public abstract MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry GetHistoryEntryFor(MegaCrit.Sts2.Core.Runs.MapLocation location)
public abstract MegaCrit.Sts2.Core.Runs.MapLocation get_MapLocation()
public abstract MegaCrit.Sts2.Core.Runs.RelicGrabBag get_SharedRelicGrabBag()
public abstract MegaCrit.Sts2.Core.Runs.RunLocation get_RunLocation()
public abstract MegaCrit.Sts2.Core.Runs.RunRngSet get_Rng()
public abstract MegaCrit.Sts2.Core.Unlocks.UnlockState get_UnlockState()
public abstract System.Boolean ContainsCard(MegaCrit.Sts2.Core.Models.CardModel card)
public abstract System.Boolean get_IsGameOver()
public abstract System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AbstractModel> IterateHookListeners(MegaCrit.Sts2.Core.Combat.ICombatState childCombatState)
public abstract System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel> get_Acts()
public abstract System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.BadgeModel> get_BadgeModels()
public abstract System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel> get_Modifiers()
public abstract System.Collections.Generic.IReadOnlyList<System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry>> get_MapPointHistory()
public abstract System.Int32 get_ActFloor()
public abstract System.Int32 get_AscensionLevel()
public abstract System.Int32 get_CurrentActIndex()
public abstract System.Int32 get_CurrentRoomCount()
public abstract System.Int32 get_TotalFloor()
public abstract System.Int32 GetAndIncrementNextRoomId()
public abstract System.Nullable<MegaCrit.Sts2.Core.Map.MapCoord> get_CurrentMapCoord()
public abstract System.Void AppendToMapPointHistory(MegaCrit.Sts2.Core.Map.MapPointType mapPointType, MegaCrit.Sts2.Core.Rooms.RoomType initialRoomType, MegaCrit.Sts2.Core.Models.ModelId modelId)
public abstract System.Void set_ActFloor(System.Int32 value)
public abstract System.Void set_CurrentActIndex(System.Int32 value)
public abstract System.Void set_Map(MegaCrit.Sts2.Core.Map.ActMap value)
public static MegaCrit.Sts2.Core.Runs.IRunState GetFrom(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature> creatures)
public virtual MegaCrit.Sts2.Core.Entities.Cards.CardMultiplayerConstraint get_CardMultiplayerConstraint()
```

## MegaCrit.Sts2.Core.Runs.IRunState+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Runs.IRunState+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Entities.Creatures.Creature, System.Boolean> <>9__63_0
public static System.Func<MegaCrit.Sts2.Core.Entities.Creatures.Creature, System.Boolean> <>9__63_1
public static System.Func<MegaCrit.Sts2.Core.Entities.Creatures.Creature, System.Boolean> <>9__63_2
private static .cctor()
public .ctor()
internal System.Boolean <GetFrom>b__63_0(MegaCrit.Sts2.Core.Entities.Creatures.Creature c)
internal System.Boolean <GetFrom>b__63_1(MegaCrit.Sts2.Core.Entities.Creatures.Creature c)
internal System.Boolean <GetFrom>b__63_2(MegaCrit.Sts2.Core.Entities.Creatures.Creature c)
```

## MegaCrit.Sts2.Core.Runs.MapLocation

类型属性：`Public, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.IEquatable<MegaCrit.Sts2.Core.Runs.MapLocation>`, `System.IComparable<MegaCrit.Sts2.Core.Runs.MapLocation>`, `MegaCrit.Sts2.Core.Multiplayer.Serialization.IPacketSerializable`

```text
public System.Int32 actIndex
public System.Nullable<MegaCrit.Sts2.Core.Map.MapCoord> coord
public .ctor(System.Nullable<MegaCrit.Sts2.Core.Map.MapCoord> coord, System.Int32 actIndex)
public static System.Boolean op_Equality(MegaCrit.Sts2.Core.Runs.MapLocation first, MegaCrit.Sts2.Core.Runs.MapLocation second)
public static System.Boolean op_Inequality(MegaCrit.Sts2.Core.Runs.MapLocation first, MegaCrit.Sts2.Core.Runs.MapLocation second)
public virtual System.Boolean Equals(MegaCrit.Sts2.Core.Runs.MapLocation other)
public virtual System.Boolean Equals(System.Object obj)
public virtual System.Int32 CompareTo(MegaCrit.Sts2.Core.Runs.MapLocation other)
public virtual System.Int32 GetHashCode()
public virtual System.String ToString()
public virtual System.Void Deserialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketReader reader)
public virtual System.Void Serialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketWriter writer)
```

## MegaCrit.Sts2.Core.Runs.NullRunState

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：`MegaCrit.Sts2.Core.Runs.IRunState`, `MegaCrit.Sts2.Core.Runs.ICardScope`, `MegaCrit.Sts2.Core.Runs.IPlayerCollection`

```text
private static readonly MegaCrit.Sts2.Core.Runs.NullRunState <Instance>k__BackingField
MegaCrit.Sts2.Core.Models.ActModel Act { public virtual get; }
System.Int32 ActFloor { public virtual get; public virtual set; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel> Acts { public virtual get; }
System.Int32 AscensionLevel { public virtual get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.BadgeModel> BadgeModels { public virtual get; }
MegaCrit.Sts2.Core.Rooms.AbstractRoom BaseRoom { public virtual get; }
System.Int32 CurrentActIndex { public virtual get; public virtual set; }
System.Nullable<MegaCrit.Sts2.Core.Map.MapCoord> CurrentMapCoord { public virtual get; }
MegaCrit.Sts2.Core.Map.MapPoint CurrentMapPoint { public virtual get; }
MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry CurrentMapPointHistoryEntry { public virtual get; }
MegaCrit.Sts2.Core.Rooms.AbstractRoom CurrentRoom { public virtual get; }
System.Int32 CurrentRoomCount { public virtual get; }
MegaCrit.Sts2.Core.Runs.ExtraRunFields ExtraFields { public virtual get; }
MegaCrit.Sts2.Core.Runs.GameMode GameMode { public virtual get; }
MegaCrit.Sts2.Core.Runs.NullRunState Instance { public static get; }
System.Boolean IsGameOver { public virtual get; }
MegaCrit.Sts2.Core.Map.ActMap Map { public virtual get; public virtual set; }
MegaCrit.Sts2.Core.Runs.MapLocation MapLocation { public virtual get; }
System.Collections.Generic.IReadOnlyList<System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry>> MapPointHistory { public virtual get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel> Modifiers { public virtual get; }
MegaCrit.Sts2.Core.Models.Singleton.MultiplayerScalingModel MultiplayerScalingModel { public virtual get; }
MegaCrit.Sts2.Core.Odds.RunOddsSet Odds { public virtual get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Players.Player> Players { public virtual get; }
MegaCrit.Sts2.Core.Runs.RunRngSet Rng { public virtual get; }
MegaCrit.Sts2.Core.Runs.RunLocation RunLocation { public virtual get; }
MegaCrit.Sts2.Core.Runs.RelicGrabBag SharedRelicGrabBag { public virtual get; }
System.Int32 TotalFloor { public virtual get; }
MegaCrit.Sts2.Core.Unlocks.UnlockState UnlockState { public virtual get; }
private .ctor()
private static .cctor()
public static MegaCrit.Sts2.Core.Runs.NullRunState get_Instance()
public virtual MegaCrit.Sts2.Core.Entities.Players.Player GetPlayer(System.UInt64 netId)
public virtual MegaCrit.Sts2.Core.Map.ActMap get_Map()
public virtual MegaCrit.Sts2.Core.Map.MapPoint get_CurrentMapPoint()
public virtual MegaCrit.Sts2.Core.Models.ActModel get_Act()
public virtual MegaCrit.Sts2.Core.Models.CardModel CloneCard(MegaCrit.Sts2.Core.Models.CardModel mutableCard)
public virtual MegaCrit.Sts2.Core.Models.CardModel CreateCard(MegaCrit.Sts2.Core.Models.CardModel canonicalCard, MegaCrit.Sts2.Core.Entities.Players.Player owner)
public virtual MegaCrit.Sts2.Core.Models.CardModel LoadCard(MegaCrit.Sts2.Core.Saves.Runs.SerializableCard serializableCard, MegaCrit.Sts2.Core.Entities.Players.Player owner)
public virtual MegaCrit.Sts2.Core.Models.Singleton.MultiplayerScalingModel get_MultiplayerScalingModel()
public virtual MegaCrit.Sts2.Core.Odds.RunOddsSet get_Odds()
public virtual MegaCrit.Sts2.Core.Rooms.AbstractRoom get_BaseRoom()
public virtual MegaCrit.Sts2.Core.Rooms.AbstractRoom get_CurrentRoom()
public virtual MegaCrit.Sts2.Core.Runs.ExtraRunFields get_ExtraFields()
public virtual MegaCrit.Sts2.Core.Runs.GameMode get_GameMode()
public virtual MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry get_CurrentMapPointHistoryEntry()
public virtual MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry GetHistoryEntryFor(MegaCrit.Sts2.Core.Runs.MapLocation location)
public virtual MegaCrit.Sts2.Core.Runs.MapLocation get_MapLocation()
public virtual MegaCrit.Sts2.Core.Runs.RelicGrabBag get_SharedRelicGrabBag()
public virtual MegaCrit.Sts2.Core.Runs.RunLocation get_RunLocation()
public virtual MegaCrit.Sts2.Core.Runs.RunRngSet get_Rng()
public virtual MegaCrit.Sts2.Core.Unlocks.UnlockState get_UnlockState()
public virtual System.Boolean ContainsCard(MegaCrit.Sts2.Core.Models.CardModel card)
public virtual System.Boolean get_IsGameOver()
public virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AbstractModel> IterateHookListeners(MegaCrit.Sts2.Core.Combat.ICombatState childCombatState)
public virtual System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Players.Player> get_Players()
public virtual System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel> get_Acts()
public virtual System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.BadgeModel> get_BadgeModels()
public virtual System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel> get_Modifiers()
public virtual System.Collections.Generic.IReadOnlyList<System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry>> get_MapPointHistory()
public virtual System.Int32 get_ActFloor()
public virtual System.Int32 get_AscensionLevel()
public virtual System.Int32 get_CurrentActIndex()
public virtual System.Int32 get_CurrentRoomCount()
public virtual System.Int32 get_TotalFloor()
public virtual System.Int32 GetAndIncrementNextRoomId()
public virtual System.Int32 GetPlayerSlotIndex(MegaCrit.Sts2.Core.Entities.Players.Player player)
public virtual System.Nullable<MegaCrit.Sts2.Core.Map.MapCoord> get_CurrentMapCoord()
public virtual System.Void AddCard(MegaCrit.Sts2.Core.Models.CardModel mutableCard, MegaCrit.Sts2.Core.Entities.Players.Player owner)
public virtual System.Void AppendToMapPointHistory(MegaCrit.Sts2.Core.Map.MapPointType mapPointType, MegaCrit.Sts2.Core.Rooms.RoomType initialRoomType, MegaCrit.Sts2.Core.Models.ModelId modelId)
public virtual System.Void RemoveCard(MegaCrit.Sts2.Core.Models.CardModel card)
public virtual System.Void set_ActFloor(System.Int32 value)
public virtual System.Void set_CurrentActIndex(System.Int32 value)
public virtual System.Void set_Map(MegaCrit.Sts2.Core.Map.ActMap value)
public virtual T CreateCard<T>(MegaCrit.Sts2.Core.Entities.Players.Player owner) where T: [None] MegaCrit.Sts2.Core.Models.CardModel
```

## MegaCrit.Sts2.Core.Runs.PlayerMapPointHistoryEntry

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：`MegaCrit.Sts2.Core.Multiplayer.Serialization.IPacketSerializable`

```text
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Runs.History.AncientChoiceHistoryEntry> <AncientChoices>k__BackingField
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> <BoughtColorless>k__BackingField
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> <BoughtPotions>k__BackingField
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> <BoughtRelics>k__BackingField
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Runs.History.CardChoiceHistoryEntry> <CardChoices>k__BackingField
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Runs.History.CardEnchantmentHistoryEntry> <CardsEnchanted>k__BackingField
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Saves.Runs.SerializableCard> <CardsGained>k__BackingField
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Saves.Runs.SerializableCard> <CardsRemoved>k__BackingField
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Runs.History.CardTransformationHistoryEntry> <CardsTransformed>k__BackingField
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> <CompletedQuests>k__BackingField
private System.Int32 <CurrentGold>k__BackingField
private System.Int32 <CurrentHp>k__BackingField
private System.Int32 <DamageTaken>k__BackingField
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> <DowngradedCards>k__BackingField
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Runs.History.EventOptionHistoryEntry> <EventChoices>k__BackingField
private System.Int32 <GoldGained>k__BackingField
private System.Int32 <GoldLost>k__BackingField
private System.Int32 <GoldSpent>k__BackingField
private System.Int32 <GoldStolen>k__BackingField
private System.Int32 <HpHealed>k__BackingField
private System.Boolean <IsAffectedByFurCoat>k__BackingField
private System.Int32 <MaxHp>k__BackingField
private System.Int32 <MaxHpGained>k__BackingField
private System.Int32 <MaxHpLost>k__BackingField
private System.UInt64 <PlayerId>k__BackingField
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Runs.History.ModelChoiceHistoryEntry> <PotionChoices>k__BackingField
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> <PotionDiscarded>k__BackingField
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> <PotionUsed>k__BackingField
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Runs.History.ModelChoiceHistoryEntry> <RelicChoices>k__BackingField
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> <RelicsRemoved>k__BackingField
private System.Collections.Generic.List<System.String> <RestSiteChoices>k__BackingField
private System.Int32 <StolenLoot>k__BackingField
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> <UpgradedCards>k__BackingField
System.Collections.Generic.List<MegaCrit.Sts2.Core.Runs.History.AncientChoiceHistoryEntry> AncientChoices { public get; public set; }
System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> BoughtColorless { public get; public set; }
System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> BoughtPotions { public get; public set; }
System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> BoughtRelics { public get; public set; }
System.Collections.Generic.List<MegaCrit.Sts2.Core.Runs.History.CardChoiceHistoryEntry> CardChoices { public get; public set; }
System.Collections.Generic.List<MegaCrit.Sts2.Core.Runs.History.CardEnchantmentHistoryEntry> CardsEnchanted { public get; public set; }
System.Collections.Generic.List<MegaCrit.Sts2.Core.Saves.Runs.SerializableCard> CardsGained { public get; public set; }
System.Collections.Generic.List<MegaCrit.Sts2.Core.Saves.Runs.SerializableCard> CardsRemoved { public get; public set; }
System.Collections.Generic.List<MegaCrit.Sts2.Core.Runs.History.CardTransformationHistoryEntry> CardsTransformed { public get; public set; }
System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> CompletedQuests { public get; public set; }
System.Int32 CurrentGold { public get; public set; }
System.Int32 CurrentHp { public get; public set; }
System.Int32 DamageTaken { public get; public set; }
System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> DowngradedCards { public get; public set; }
System.Collections.Generic.List<MegaCrit.Sts2.Core.Runs.History.EventOptionHistoryEntry> EventChoices { public get; public set; }
System.Int32 GoldGained { public get; public set; }
System.Int32 GoldLost { public get; public set; }
System.Int32 GoldSpent { public get; public set; }
System.Int32 GoldStolen { public get; public set; }
System.Int32 HpHealed { public get; public set; }
System.Boolean IsAffectedByFurCoat { public get; public set; }
System.Int32 MaxHp { public get; public set; }
System.Int32 MaxHpGained { public get; public set; }
System.Int32 MaxHpLost { public get; public set; }
System.UInt64 PlayerId { public get; public set; }
System.Collections.Generic.List<MegaCrit.Sts2.Core.Runs.History.ModelChoiceHistoryEntry> PotionChoices { public get; public set; }
System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> PotionDiscarded { public get; public set; }
System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> PotionUsed { public get; public set; }
System.Collections.Generic.List<MegaCrit.Sts2.Core.Runs.History.ModelChoiceHistoryEntry> RelicChoices { public get; public set; }
System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> RelicsRemoved { public get; public set; }
System.Collections.Generic.List<System.String> RestSiteChoices { public get; public set; }
System.Int32 StolenLoot { public get; public set; }
System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> UpgradedCards { public get; public set; }
System.Boolean WasMugged { public get; }
public .ctor()
public MegaCrit.Sts2.Core.Localization.LocString GetAncientPickedChoiceLoc()
public MegaCrit.Sts2.Core.Runs.PlayerMapPointHistoryEntry Anonymized()
public System.Boolean get_IsAffectedByFurCoat()
public System.Boolean get_WasMugged()
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Localization.LocString> GetAncientSkippedChoiceLoc()
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> get_BoughtColorless()
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> get_BoughtPotions()
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> get_BoughtRelics()
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> get_CompletedQuests()
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> get_DowngradedCards()
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> get_PotionDiscarded()
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> get_PotionUsed()
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> get_RelicsRemoved()
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> get_UpgradedCards()
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Runs.History.AncientChoiceHistoryEntry> get_AncientChoices()
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Runs.History.CardChoiceHistoryEntry> get_CardChoices()
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Runs.History.CardEnchantmentHistoryEntry> get_CardsEnchanted()
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Runs.History.CardTransformationHistoryEntry> get_CardsTransformed()
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Runs.History.EventOptionHistoryEntry> get_EventChoices()
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Runs.History.ModelChoiceHistoryEntry> get_PotionChoices()
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Runs.History.ModelChoiceHistoryEntry> get_RelicChoices()
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Saves.Runs.SerializableCard> get_CardsGained()
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Saves.Runs.SerializableCard> get_CardsRemoved()
public System.Collections.Generic.List<System.String> get_RestSiteChoices()
public System.Int32 get_CurrentGold()
public System.Int32 get_CurrentHp()
public System.Int32 get_DamageTaken()
public System.Int32 get_GoldGained()
public System.Int32 get_GoldLost()
public System.Int32 get_GoldSpent()
public System.Int32 get_GoldStolen()
public System.Int32 get_HpHealed()
public System.Int32 get_MaxHp()
public System.Int32 get_MaxHpGained()
public System.Int32 get_MaxHpLost()
public System.Int32 get_StolenLoot()
public System.UInt64 get_PlayerId()
public System.Void MarkLootReturned(System.Int32 amount = 1)
public System.Void MarkLootStolen(System.Int32 amount = 1)
public System.Void set_AncientChoices(System.Collections.Generic.List<MegaCrit.Sts2.Core.Runs.History.AncientChoiceHistoryEntry> value)
public System.Void set_BoughtColorless(System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> value)
public System.Void set_BoughtPotions(System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> value)
public System.Void set_BoughtRelics(System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> value)
public System.Void set_CardChoices(System.Collections.Generic.List<MegaCrit.Sts2.Core.Runs.History.CardChoiceHistoryEntry> value)
public System.Void set_CardsEnchanted(System.Collections.Generic.List<MegaCrit.Sts2.Core.Runs.History.CardEnchantmentHistoryEntry> value)
public System.Void set_CardsGained(System.Collections.Generic.List<MegaCrit.Sts2.Core.Saves.Runs.SerializableCard> value)
public System.Void set_CardsRemoved(System.Collections.Generic.List<MegaCrit.Sts2.Core.Saves.Runs.SerializableCard> value)
public System.Void set_CardsTransformed(System.Collections.Generic.List<MegaCrit.Sts2.Core.Runs.History.CardTransformationHistoryEntry> value)
public System.Void set_CompletedQuests(System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> value)
public System.Void set_CurrentGold(System.Int32 value)
public System.Void set_CurrentHp(System.Int32 value)
public System.Void set_DamageTaken(System.Int32 value)
public System.Void set_DowngradedCards(System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> value)
public System.Void set_EventChoices(System.Collections.Generic.List<MegaCrit.Sts2.Core.Runs.History.EventOptionHistoryEntry> value)
public System.Void set_GoldGained(System.Int32 value)
public System.Void set_GoldLost(System.Int32 value)
public System.Void set_GoldSpent(System.Int32 value)
public System.Void set_GoldStolen(System.Int32 value)
public System.Void set_HpHealed(System.Int32 value)
public System.Void set_IsAffectedByFurCoat(System.Boolean value)
public System.Void set_MaxHp(System.Int32 value)
public System.Void set_MaxHpGained(System.Int32 value)
public System.Void set_MaxHpLost(System.Int32 value)
public System.Void set_PlayerId(System.UInt64 value)
public System.Void set_PotionChoices(System.Collections.Generic.List<MegaCrit.Sts2.Core.Runs.History.ModelChoiceHistoryEntry> value)
public System.Void set_PotionDiscarded(System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> value)
public System.Void set_PotionUsed(System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> value)
public System.Void set_RelicChoices(System.Collections.Generic.List<MegaCrit.Sts2.Core.Runs.History.ModelChoiceHistoryEntry> value)
public System.Void set_RelicsRemoved(System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> value)
public System.Void set_RestSiteChoices(System.Collections.Generic.List<System.String> value)
public System.Void set_StolenLoot(System.Int32 value)
public System.Void set_UpgradedCards(System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> value)
public virtual System.Void Deserialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketReader reader)
public virtual System.Void Serialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketWriter writer)
```

## MegaCrit.Sts2.Core.Runs.PlayerMapPointHistoryEntry+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Runs.PlayerMapPointHistoryEntry+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Runs.History.AncientChoiceHistoryEntry, System.Boolean> <>9__132_0
public static System.Func<MegaCrit.Sts2.Core.Runs.History.AncientChoiceHistoryEntry, System.Boolean> <>9__133_0
public static System.Func<MegaCrit.Sts2.Core.Runs.History.AncientChoiceHistoryEntry, MegaCrit.Sts2.Core.Localization.LocString> <>9__133_1
private static .cctor()
public .ctor()
internal MegaCrit.Sts2.Core.Localization.LocString <GetAncientSkippedChoiceLoc>b__133_1(MegaCrit.Sts2.Core.Runs.History.AncientChoiceHistoryEntry o)
internal System.Boolean <GetAncientPickedChoiceLoc>b__132_0(MegaCrit.Sts2.Core.Runs.History.AncientChoiceHistoryEntry o)
internal System.Boolean <GetAncientSkippedChoiceLoc>b__133_0(MegaCrit.Sts2.Core.Runs.History.AncientChoiceHistoryEntry o)
```

## MegaCrit.Sts2.Core.Runs.RelicGrabBag

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private readonly System.Collections.Generic.Dictionary<MegaCrit.Sts2.Core.Entities.Relics.RelicRarity, System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.RelicModel>> _deques
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.RelicModel> _mpFallbackDequeue
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.RelicModel> _originalRelics
private static readonly System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Entities.Relics.RelicRarity> _rarities
private readonly System.Boolean _refreshAllowed
System.Boolean IsPopulated { public get; }
private static .cctor()
public .ctor()
public .ctor(System.Boolean refreshAllowed)
private System.Boolean DequeHasAnyRelics(System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.RelicModel> deque, System.Func<MegaCrit.Sts2.Core.Models.RelicModel, System.Boolean> filter)
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.RelicModel> GetAvailableDeque(MegaCrit.Sts2.Core.Entities.Relics.RelicRarity rarity, MegaCrit.Sts2.Core.Runs.IRunState runState, System.Func<MegaCrit.Sts2.Core.Models.RelicModel, System.Boolean> filter)
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.RelicModel> GetDeque(MegaCrit.Sts2.Core.Entities.Relics.RelicRarity rarity)
private System.Void RefreshRarity(MegaCrit.Sts2.Core.Entities.Relics.RelicRarity rarity)
private System.Void RemoveDisallowedRelicsFromDeques(MegaCrit.Sts2.Core.Runs.IRunState runState)
public MegaCrit.Sts2.Core.Models.RelicModel PullFromBack(MegaCrit.Sts2.Core.Entities.Relics.RelicRarity rarity, System.Func<MegaCrit.Sts2.Core.Models.RelicModel, System.Boolean> filter, MegaCrit.Sts2.Core.Runs.IRunState runState)
public MegaCrit.Sts2.Core.Models.RelicModel PullFromFront(MegaCrit.Sts2.Core.Entities.Relics.RelicRarity rarity, MegaCrit.Sts2.Core.Runs.IRunState runState)
public MegaCrit.Sts2.Core.Models.RelicModel PullFromFront(MegaCrit.Sts2.Core.Entities.Relics.RelicRarity rarity, System.Func<MegaCrit.Sts2.Core.Models.RelicModel, System.Boolean> filter, MegaCrit.Sts2.Core.Runs.IRunState runState)
public MegaCrit.Sts2.Core.Saves.Runs.SerializableRelicGrabBag ToSerializable()
public static MegaCrit.Sts2.Core.Runs.RelicGrabBag FromSerializable(MegaCrit.Sts2.Core.Saves.Runs.SerializableRelicGrabBag save)
public System.Boolean Contains(MegaCrit.Sts2.Core.Models.RelicModel relic)
public System.Boolean get_IsPopulated()
public System.Boolean HasAvailableRelics(MegaCrit.Sts2.Core.Runs.IRunState runState)
public System.Void LoadFromSerializable(MegaCrit.Sts2.Core.Saves.Runs.SerializableRelicGrabBag save)
public System.Void MoveToFallback(MegaCrit.Sts2.Core.Models.RelicModel toRemove)
public System.Void Populate(MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.Random.Rng rng)
public System.Void Populate(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.RelicModel> relics, MegaCrit.Sts2.Core.Random.Rng rng)
public System.Void Remove(MegaCrit.Sts2.Core.Models.RelicModel relic)
public System.Void Remove<T>() where T: [None] MegaCrit.Sts2.Core.Models.RelicModel
```

## MegaCrit.Sts2.Core.Runs.RelicGrabBag+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Runs.RelicGrabBag+<>c <>9
public static System.Predicate<MegaCrit.Sts2.Core.Models.RelicModel> <>9__10_0
public static System.Func<MegaCrit.Sts2.Core.Models.RelicModel, System.Boolean> <>9__12_0
public static System.Func<MegaCrit.Sts2.Core.Models.RelicModel, MegaCrit.Sts2.Core.Models.ModelId> <>9__21_0
public static System.Func<MegaCrit.Sts2.Core.Models.RelicModel, System.Boolean> <>9__5_1
private static .cctor()
public .ctor()
internal MegaCrit.Sts2.Core.Models.ModelId <ToSerializable>b__21_0(MegaCrit.Sts2.Core.Models.RelicModel r)
internal System.Boolean <HasAvailableRelics>b__5_1(MegaCrit.Sts2.Core.Models.RelicModel _)
internal System.Boolean <Populate>b__10_0(MegaCrit.Sts2.Core.Models.RelicModel r)
internal System.Boolean <PullFromFront>b__12_0(MegaCrit.Sts2.Core.Models.RelicModel _)
```

## MegaCrit.Sts2.Core.Runs.RelicGrabBag+<>c__DisplayClass16_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.Predicate<MegaCrit.Sts2.Core.Models.RelicModel> <>9__0
public MegaCrit.Sts2.Core.Models.RelicModel relic
public .ctor()
internal System.Boolean <Remove>b__0(MegaCrit.Sts2.Core.Models.RelicModel r)
```

## MegaCrit.Sts2.Core.Runs.RelicGrabBag+<>c__DisplayClass5_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Runs.IRunState runState
public .ctor()
internal System.Boolean <HasAvailableRelics>b__0(MegaCrit.Sts2.Core.Models.RelicModel r)
```

## MegaCrit.Sts2.Core.Runs.RunHistory

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：`MegaCrit.Sts2.Core.Saves.ISaveSchema`

```text
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> <Acts>k__BackingField
private readonly System.Int32 <Ascension>k__BackingField
private readonly System.String <BuildId>k__BackingField
private readonly MegaCrit.Sts2.Core.Runs.GameMode <GameMode>k__BackingField
private readonly MegaCrit.Sts2.Core.Models.ModelId <KilledByEncounter>k__BackingField
private readonly MegaCrit.Sts2.Core.Models.ModelId <KilledByEvent>k__BackingField
private readonly System.Collections.Generic.List<System.Collections.Generic.List<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry>> <MapPointHistory>k__BackingField
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Saves.Runs.SerializableModifier> <Modifiers>k__BackingField
private readonly MegaCrit.Sts2.Core.Platform.PlatformType <PlatformType>k__BackingField
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Runs.RunHistoryPlayer> <Players>k__BackingField
private readonly System.Single <RunTime>k__BackingField
private System.Int32 <SchemaVersion>k__BackingField
private readonly System.String <Seed>k__BackingField
private readonly System.Int64 <StartTime>k__BackingField
private readonly System.Boolean <WasAbandoned>k__BackingField
private readonly System.Boolean <Win>k__BackingField
System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> Acts { public get; public set; }
System.Int32 Ascension { public get; public set; }
System.String BuildId { public get; public set; }
MegaCrit.Sts2.Core.Runs.GameMode GameMode { public get; public set; }
MegaCrit.Sts2.Core.Models.ModelId KilledByEncounter { public get; public set; }
MegaCrit.Sts2.Core.Models.ModelId KilledByEvent { public get; public set; }
System.Collections.Generic.List<System.Collections.Generic.List<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry>> MapPointHistory { public get; public set; }
System.Collections.Generic.List<MegaCrit.Sts2.Core.Saves.Runs.SerializableModifier> Modifiers { public get; public set; }
MegaCrit.Sts2.Core.Platform.PlatformType PlatformType { public get; public set; }
System.Collections.Generic.List<MegaCrit.Sts2.Core.Runs.RunHistoryPlayer> Players { public get; public set; }
System.Single RunTime { public get; public set; }
System.Int32 SchemaVersion { public virtual get; public virtual set; }
System.String Seed { public get; public set; }
System.Int64 StartTime { public get; public set; }
System.Boolean WasAbandoned { public get; public set; }
System.Boolean Win { public get; public set; }
public .ctor()
public MegaCrit.Sts2.Core.Models.ModelId get_KilledByEncounter()
public MegaCrit.Sts2.Core.Models.ModelId get_KilledByEvent()
public MegaCrit.Sts2.Core.Platform.PlatformType get_PlatformType()
public MegaCrit.Sts2.Core.Runs.GameMode get_GameMode()
public System.Boolean get_WasAbandoned()
public System.Boolean get_Win()
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> get_Acts()
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Runs.RunHistoryPlayer> get_Players()
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Saves.Runs.SerializableModifier> get_Modifiers()
public System.Collections.Generic.List<System.Collections.Generic.List<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry>> get_MapPointHistory()
public System.Int32 get_Ascension()
public System.Int64 get_StartTime()
public System.Single get_RunTime()
public System.String get_BuildId()
public System.String get_Seed()
public System.Void set_Acts(System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModelId> value)
public System.Void set_Ascension(System.Int32 value)
public System.Void set_BuildId(System.String value)
public System.Void set_GameMode(MegaCrit.Sts2.Core.Runs.GameMode value)
public System.Void set_KilledByEncounter(MegaCrit.Sts2.Core.Models.ModelId value)
public System.Void set_KilledByEvent(MegaCrit.Sts2.Core.Models.ModelId value)
public System.Void set_MapPointHistory(System.Collections.Generic.List<System.Collections.Generic.List<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry>> value)
public System.Void set_Modifiers(System.Collections.Generic.List<MegaCrit.Sts2.Core.Saves.Runs.SerializableModifier> value)
public System.Void set_PlatformType(MegaCrit.Sts2.Core.Platform.PlatformType value)
public System.Void set_Players(System.Collections.Generic.List<MegaCrit.Sts2.Core.Runs.RunHistoryPlayer> value)
public System.Void set_RunTime(System.Single value)
public System.Void set_Seed(System.String value)
public System.Void set_StartTime(System.Int64 value)
public System.Void set_WasAbandoned(System.Boolean value)
public System.Void set_Win(System.Boolean value)
public virtual System.Int32 get_SchemaVersion()
public virtual System.Void set_SchemaVersion(System.Int32 value)
```

## MegaCrit.Sts2.Core.Runs.RunHistoryPlayer

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Saves.Runs.SerializableBadge> <Badges>k__BackingField
private readonly MegaCrit.Sts2.Core.Models.ModelId <Character>k__BackingField
private System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Saves.Runs.SerializableCard> <Deck>k__BackingField
private readonly System.UInt64 <Id>k__BackingField
private System.Int32 <MaxPotionSlotCount>k__BackingField
private System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Saves.Runs.SerializablePotion> <Potions>k__BackingField
private System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Saves.Runs.SerializableRelic> <Relics>k__BackingField
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Saves.Runs.SerializableBadge> Badges { public get; public set; }
MegaCrit.Sts2.Core.Models.ModelId Character { public get; public set; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Saves.Runs.SerializableCard> Deck { public get; public set; }
System.UInt64 Id { public get; public set; }
System.Int32 MaxPotionSlotCount { public get; public set; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Saves.Runs.SerializablePotion> Potions { public get; public set; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Saves.Runs.SerializableRelic> Relics { public get; public set; }
public .ctor()
public MegaCrit.Sts2.Core.Models.ModelId get_Character()
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Saves.Runs.SerializableBadge> get_Badges()
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Saves.Runs.SerializableCard> get_Deck()
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Saves.Runs.SerializablePotion> get_Potions()
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Saves.Runs.SerializableRelic> get_Relics()
public System.Int32 get_MaxPotionSlotCount()
public System.UInt64 get_Id()
public System.Void set_Badges(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Saves.Runs.SerializableBadge> value)
public System.Void set_Character(MegaCrit.Sts2.Core.Models.ModelId value)
public System.Void set_Deck(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Saves.Runs.SerializableCard> value)
public System.Void set_Id(System.UInt64 value)
public System.Void set_MaxPotionSlotCount(System.Int32 value)
public System.Void set_Potions(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Saves.Runs.SerializablePotion> value)
public System.Void set_Relics(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Saves.Runs.SerializableRelic> value)
```

## MegaCrit.Sts2.Core.Runs.RunHistoryUtilities

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static MegaCrit.Sts2.Core.Runs.GameMode GetGameMode(MegaCrit.Sts2.Core.Saves.SerializableRun run)
private static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Saves.Runs.SerializableBadge> GetBadgesForPlayer(MegaCrit.Sts2.Core.Saves.SerializableRun run, MegaCrit.Sts2.Core.Saves.Runs.SerializablePlayer player, System.Boolean won, System.Boolean isAbandoned)
public static System.Void CreateRunHistoryEntry(MegaCrit.Sts2.Core.Saves.SerializableRun run, System.Boolean victory, System.Boolean isAbandoned, MegaCrit.Sts2.Core.Platform.PlatformType platformType)
```

## MegaCrit.Sts2.Core.Runs.RunHistoryUtilities+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Runs.RunHistoryUtilities+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Saves.Runs.SerializableActModel, MegaCrit.Sts2.Core.Models.ModelId> <>9__0_0
private static .cctor()
public .ctor()
internal MegaCrit.Sts2.Core.Models.ModelId <CreateRunHistoryEntry>b__0_0(MegaCrit.Sts2.Core.Saves.Runs.SerializableActModel a)
```

## MegaCrit.Sts2.Core.Runs.RunLocation

类型属性：`Public, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.IEquatable<MegaCrit.Sts2.Core.Runs.RunLocation>`, `System.IComparable<MegaCrit.Sts2.Core.Runs.RunLocation>`, `MegaCrit.Sts2.Core.Multiplayer.Serialization.IPacketSerializable`

```text
public MegaCrit.Sts2.Core.Runs.MapLocation mapLocation
public System.Nullable<System.Int32> roomId
public .ctor(MegaCrit.Sts2.Core.Runs.MapLocation mapLocation, System.Nullable<System.Int32> roomId)
public .ctor(System.Int32 actIndex, System.Nullable<MegaCrit.Sts2.Core.Map.MapCoord> coord, System.Nullable<System.Int32> roomId)
public static System.Boolean op_Equality(MegaCrit.Sts2.Core.Runs.RunLocation first, MegaCrit.Sts2.Core.Runs.RunLocation second)
public static System.Boolean op_Inequality(MegaCrit.Sts2.Core.Runs.RunLocation first, MegaCrit.Sts2.Core.Runs.RunLocation second)
public virtual System.Boolean Equals(MegaCrit.Sts2.Core.Runs.RunLocation other)
public virtual System.Boolean Equals(System.Object obj)
public virtual System.Int32 CompareTo(MegaCrit.Sts2.Core.Runs.RunLocation other)
public virtual System.Int32 GetHashCode()
public virtual System.String ToString()
public virtual System.Void Deserialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketReader reader)
public virtual System.Void Serialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketWriter writer)
```

## MegaCrit.Sts2.Core.Runs.RunManager

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：`MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.IRunLobbyListener`

```text
private System.Int64 _activeRunTime
private System.Boolean _isPaused
private System.Int32 _numReloads
private System.Int64 _prevSessionRunTime
private System.Boolean _runHistoryWasUploaded
private System.Int64 _startOfCurrentActiveRunTime
private System.Int64 _startTime
private MegaCrit.Sts2.Core.Multiplayer.Game.ActChangeSynchronizer <ActChangeSynchronizer>k__BackingField
private MegaCrit.Sts2.Core.GameActions.ActionExecutor <ActionExecutor>k__BackingField
private MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSet <ActionQueueSet>k__BackingField
private MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSynchronizer <ActionQueueSynchronizer>k__BackingField
private MegaCrit.Sts2.Core.Entities.Ascension.AscensionManager <AscensionManager>k__BackingField
private MegaCrit.Sts2.Core.Multiplayer.Game.ChecksumTracker <ChecksumTracker>k__BackingField
private MegaCrit.Sts2.Core.Multiplayer.Replay.CombatReplayWriter <CombatReplayWriter>k__BackingField
private MegaCrit.Sts2.Core.Multiplayer.CombatStateSynchronizer <CombatStateSynchronizer>k__BackingField
private System.Nullable<System.DateTimeOffset> <DailyTime>k__BackingField
private MegaCrit.Sts2.Core.Multiplayer.Game.EventSynchronizer <EventSynchronizer>k__BackingField
private MegaCrit.Sts2.Core.Multiplayer.Game.FlavorSynchronizer <FlavorSynchronizer>k__BackingField
private System.Boolean <ForceDiscoveryOrderModifications>k__BackingField
private MegaCrit.Sts2.Core.Runs.RunHistory <History>k__BackingField
private MegaCrit.Sts2.Core.Multiplayer.Game.PeerInput.HoveredModelTracker <HoveredModelTracker>k__BackingField
private MegaCrit.Sts2.Core.Multiplayer.Game.PeerInput.PeerInputSynchronizer <InputSynchronizer>k__BackingField
private static readonly MegaCrit.Sts2.Core.Runs.RunManager <Instance>k__BackingField
private System.Boolean <IsAbandoned>k__BackingField
private System.Boolean <IsCleaningUp>k__BackingField
private MegaCrit.Sts2.Core.Saves.MapDrawing.SerializableMapDrawings <MapDrawingsToLoad>k__BackingField
private MegaCrit.Sts2.Core.Multiplayer.Game.MapSelectionSynchronizer <MapSelectionSynchronizer>k__BackingField
private MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService <NetService>k__BackingField
private MegaCrit.Sts2.Core.Multiplayer.Game.OneOffSynchronizer <OneOffSynchronizer>k__BackingField
private MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceSynchronizer <PlayerChoiceSynchronizer>k__BackingField
private MegaCrit.Sts2.Core.Multiplayer.Game.RestSiteSynchronizer <RestSiteSynchronizer>k__BackingField
private MegaCrit.Sts2.Core.Multiplayer.Game.RewardsSetSynchronizer <RewardsSetSynchronizer>k__BackingField
private MegaCrit.Sts2.Core.Multiplayer.Game.RewardSynchronizer <RewardSynchronizer>k__BackingField
private MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.RunLobby <RunLobby>k__BackingField
private MegaCrit.Sts2.Core.Multiplayer.Game.RunLocationTargetedMessageBuffer <RunLocationTargetedBuffer>k__BackingField
private System.Collections.Generic.Dictionary<System.Int32, MegaCrit.Sts2.Core.Saves.Runs.SerializableActMap> <SavedMapsToLoad>k__BackingField
private System.Boolean <ShouldSave>k__BackingField
private MegaCrit.Sts2.Core.Runs.RunState <State>k__BackingField
private MegaCrit.Sts2.Core.Multiplayer.Game.TreasureRoomRelicSynchronizer <TreasureRoomRelicSynchronizer>k__BackingField
private System.Int64 <WinTime>k__BackingField
private System.Action ActEntered
public System.Action debugAfterCombatRewardsOverride
private System.Action RoomEntered
private System.Action RoomExited
private System.Action<MegaCrit.Sts2.Core.Runs.RunState> RunStarted
private System.Func<System.Threading.Tasks.Task> TestFadeIn
private System.Func<System.Threading.Tasks.Task> TestFadeOut
MegaCrit.Sts2.Core.Multiplayer.Game.ActChangeSynchronizer ActChangeSynchronizer { public get; private set; }
MegaCrit.Sts2.Core.GameActions.ActionExecutor ActionExecutor { public get; private set; }
MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSet ActionQueueSet { public get; private set; }
MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSynchronizer ActionQueueSynchronizer { public get; private set; }
MegaCrit.Sts2.Core.Entities.Ascension.AscensionManager AscensionManager { public get; private set; }
MegaCrit.Sts2.Core.Multiplayer.Game.ChecksumTracker ChecksumTracker { public get; private set; }
MegaCrit.Sts2.Core.Multiplayer.Replay.CombatReplayWriter CombatReplayWriter { public get; private set; }
MegaCrit.Sts2.Core.Multiplayer.CombatStateSynchronizer CombatStateSynchronizer { public get; private set; }
System.Nullable<System.DateTimeOffset> DailyTime { public get; private set; }
MegaCrit.Sts2.Core.Multiplayer.Game.EventSynchronizer EventSynchronizer { public get; private set; }
MegaCrit.Sts2.Core.Multiplayer.Game.FlavorSynchronizer FlavorSynchronizer { public get; private set; }
System.Boolean ForceDiscoveryOrderModifications { public get; public set; }
MegaCrit.Sts2.Core.Runs.RunHistory History { public get; public set; }
MegaCrit.Sts2.Core.Multiplayer.Game.PeerInput.HoveredModelTracker HoveredModelTracker { public get; private set; }
MegaCrit.Sts2.Core.Multiplayer.Game.PeerInput.PeerInputSynchronizer InputSynchronizer { public get; private set; }
MegaCrit.Sts2.Core.Runs.RunManager Instance { public static get; }
System.Boolean IsAbandoned { public get; private set; }
System.Boolean IsCleaningUp { public get; private set; }
System.Boolean IsGameOver { public get; }
System.Boolean IsInProgress { public get; }
System.Boolean IsPaused { public get; public set; }
System.Boolean IsSingleplayerOrFakeMultiplayer { public get; }
MegaCrit.Sts2.Core.Saves.MapDrawing.SerializableMapDrawings MapDrawingsToLoad { public get; public set; }
MegaCrit.Sts2.Core.Multiplayer.Game.MapSelectionSynchronizer MapSelectionSynchronizer { public get; private set; }
MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService NetService { public get; private set; }
MegaCrit.Sts2.Core.Multiplayer.Game.OneOffSynchronizer OneOffSynchronizer { public get; private set; }
MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceSynchronizer PlayerChoiceSynchronizer { public get; private set; }
MegaCrit.Sts2.Core.Multiplayer.Game.RestSiteSynchronizer RestSiteSynchronizer { public get; private set; }
MegaCrit.Sts2.Core.Multiplayer.Game.RewardsSetSynchronizer RewardsSetSynchronizer { public get; private set; }
MegaCrit.Sts2.Core.Multiplayer.Game.RewardSynchronizer RewardSynchronizer { public get; private set; }
MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.RunLobby RunLobby { public get; private set; }
MegaCrit.Sts2.Core.Multiplayer.Game.RunLocationTargetedMessageBuffer RunLocationTargetedBuffer { public get; private set; }
System.Int64 RunTime { public get; }
System.Collections.Generic.Dictionary<System.Int32, MegaCrit.Sts2.Core.Saves.Runs.SerializableActMap> SavedMapsToLoad { public get; public set; }
System.Boolean ShouldSave { public get; private set; }
MegaCrit.Sts2.Core.Runs.RunState State { private get; private set; }
MegaCrit.Sts2.Core.Multiplayer.Game.TreasureRoomRelicSynchronizer TreasureRoomRelicSynchronizer { public get; private set; }
System.Int64 WinTime { public get; public set; }
event System.Action ActEntered
event System.Action RoomEntered
event System.Action RoomExited
event System.Action<MegaCrit.Sts2.Core.Runs.RunState> RunStarted
event System.Func<System.Threading.Tasks.Task> TestFadeIn
event System.Func<System.Threading.Tasks.Task> TestFadeOut
private .ctor()
private static .cctor()
private [async] System.Threading.Tasks.Task AbandonInternal()
private [async] System.Threading.Tasks.Task EnterRoomInternal(MegaCrit.Sts2.Core.Rooms.AbstractRoom room, System.Boolean isRestoringRoomStackBase = False)
private [async] System.Threading.Tasks.Task ExitCurrentRooms()
private [async] System.Threading.Tasks.Task GuaranteeKillAllPlayers()
private [async] System.Threading.Tasks.Task ResumePreviousRoom()
private [async] System.Threading.Tasks.Task ReturnToMainMenuWithError(MegaCrit.Sts2.Core.Entities.Multiplayer.NetErrorInfo info)
private [async] System.Threading.Tasks.Task<MegaCrit.Sts2.Core.Rooms.AbstractRoom> ExitCurrentRoom()
private MegaCrit.Sts2.Core.Rooms.AbstractRoom CreateRoom(MegaCrit.Sts2.Core.Rooms.RoomType roomType, MegaCrit.Sts2.Core.Map.MapPointType mapPointType = 0, MegaCrit.Sts2.Core.Models.AbstractModel model = null)
private MegaCrit.Sts2.Core.Rooms.RoomType RollRoomTypeFor(MegaCrit.Sts2.Core.Map.MapPointType pointType, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Rooms.RoomType> blacklist)
private MegaCrit.Sts2.Core.Runs.RunState get_State()
private static System.Void CheckUpdateEnemyDiscoveryAfterLoss(MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.Models.ModelId monster)
private System.Boolean TryGetRoomTypeForTutorial(MegaCrit.Sts2.Core.Map.MapPointType pointType, out MegaCrit.Sts2.Core.Rooms.RoomType roomType)
private System.Threading.Tasks.Task EnterMapCoordInternal(MegaCrit.Sts2.Core.Map.MapCoord coord, MegaCrit.Sts2.Core.Rooms.AbstractRoom preFinishedRoom, System.Boolean saveGame)
private System.Void AfterMapLocationChanged()
private System.Void ClearScreens()
private System.Void InitializeNewRun()
private System.Void InitializeRunLobby(MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService netService, MegaCrit.Sts2.Core.Runs.RunState state, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Multiplayer.RunLobbyPlayer> players)
private System.Void InitializeSavedRun(MegaCrit.Sts2.Core.Saves.SerializableRun save)
private System.Void InitializeShared(MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService netService, MegaCrit.Sts2.Core.Multiplayer.Game.PeerInput.PeerInputSynchronizer inputSynchronizer, System.Boolean shouldSave, System.Nullable<System.DateTimeOffset> dailyTime, System.Int64 startTime, System.Int64 runTime, System.Int64 winTime, System.Int32 numReloads)
private System.Void RemotePlayerDisconnected(System.UInt64 playerId)
private System.Void SendPostActionChecksum(MegaCrit.Sts2.Core.GameActions.GameAction action)
private System.Void set_ActChangeSynchronizer(MegaCrit.Sts2.Core.Multiplayer.Game.ActChangeSynchronizer value)
private System.Void set_ActionExecutor(MegaCrit.Sts2.Core.GameActions.ActionExecutor value)
private System.Void set_ActionQueueSet(MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSet value)
private System.Void set_ActionQueueSynchronizer(MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSynchronizer value)
private System.Void set_AscensionManager(MegaCrit.Sts2.Core.Entities.Ascension.AscensionManager value)
private System.Void set_ChecksumTracker(MegaCrit.Sts2.Core.Multiplayer.Game.ChecksumTracker value)
private System.Void set_CombatReplayWriter(MegaCrit.Sts2.Core.Multiplayer.Replay.CombatReplayWriter value)
private System.Void set_CombatStateSynchronizer(MegaCrit.Sts2.Core.Multiplayer.CombatStateSynchronizer value)
private System.Void set_DailyTime(System.Nullable<System.DateTimeOffset> value)
private System.Void set_EventSynchronizer(MegaCrit.Sts2.Core.Multiplayer.Game.EventSynchronizer value)
private System.Void set_FlavorSynchronizer(MegaCrit.Sts2.Core.Multiplayer.Game.FlavorSynchronizer value)
private System.Void set_HoveredModelTracker(MegaCrit.Sts2.Core.Multiplayer.Game.PeerInput.HoveredModelTracker value)
private System.Void set_InputSynchronizer(MegaCrit.Sts2.Core.Multiplayer.Game.PeerInput.PeerInputSynchronizer value)
private System.Void set_IsAbandoned(System.Boolean value)
private System.Void set_IsCleaningUp(System.Boolean value)
private System.Void set_MapSelectionSynchronizer(MegaCrit.Sts2.Core.Multiplayer.Game.MapSelectionSynchronizer value)
private System.Void set_NetService(MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService value)
private System.Void set_OneOffSynchronizer(MegaCrit.Sts2.Core.Multiplayer.Game.OneOffSynchronizer value)
private System.Void set_PlayerChoiceSynchronizer(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceSynchronizer value)
private System.Void set_RestSiteSynchronizer(MegaCrit.Sts2.Core.Multiplayer.Game.RestSiteSynchronizer value)
private System.Void set_RewardsSetSynchronizer(MegaCrit.Sts2.Core.Multiplayer.Game.RewardsSetSynchronizer value)
private System.Void set_RewardSynchronizer(MegaCrit.Sts2.Core.Multiplayer.Game.RewardSynchronizer value)
private System.Void set_RunLobby(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.RunLobby value)
private System.Void set_RunLocationTargetedBuffer(MegaCrit.Sts2.Core.Multiplayer.Game.RunLocationTargetedMessageBuffer value)
private System.Void set_ShouldSave(System.Boolean value)
private System.Void set_State(MegaCrit.Sts2.Core.Runs.RunState value)
private System.Void set_TreasureRoomRelicSynchronizer(MegaCrit.Sts2.Core.Multiplayer.Game.TreasureRoomRelicSynchronizer value)
private System.Void SetStartedWithNeowFlag()
private System.Void StateDiverged(System.UInt64 divergedFrom, MegaCrit.Sts2.Core.Entities.Multiplayer.NetFullCombatState state)
private System.Void UpdatePlayerStatsInMapPointHistory()
private System.Void UpdateRichPresence()
private virtual System.Void MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.IRunLobbyListener.RunAbandoned()
public [async] System.Threading.Tasks.Task EnterAct(System.Int32 currentActIndex, System.Boolean doTransition = True)
public [async] System.Threading.Tasks.Task EnterMapCoordDebug(MegaCrit.Sts2.Core.Map.MapCoord coord, MegaCrit.Sts2.Core.Rooms.RoomType roomType, MegaCrit.Sts2.Core.Map.MapPointType pointType = 0, MegaCrit.Sts2.Core.Models.AbstractModel model = null, System.Boolean showTransition = True)
public [async] System.Threading.Tasks.Task EnterMapPointInternal(System.Int32 actFloor, MegaCrit.Sts2.Core.Map.MapPointType pointType, MegaCrit.Sts2.Core.Rooms.AbstractRoom preFinishedRoom, System.Boolean saveGame)
public [async] System.Threading.Tasks.Task EnterNextAct()
public [async] System.Threading.Tasks.Task EnterRoom(MegaCrit.Sts2.Core.Rooms.AbstractRoom room)
public [async] System.Threading.Tasks.Task EnterRoomWithoutExitingCurrentRoom(MegaCrit.Sts2.Core.Rooms.AbstractRoom room, System.Boolean fadeToBlack)
public [async] System.Threading.Tasks.Task FadeIn(System.Boolean showTransition = True)
public [async] System.Threading.Tasks.Task FadeOut()
public [async] System.Threading.Tasks.Task FinalizeStartingRelics()
public [async] System.Threading.Tasks.Task GenerateMap()
public [async] System.Threading.Tasks.Task LoadIntoLatestMapCoord(MegaCrit.Sts2.Core.Rooms.AbstractRoom preFinishedRoom)
public [async] System.Threading.Tasks.Task ProceedFromTerminalRewardsScreen()
public [async] System.Threading.Tasks.Task SetActInternal(System.Int32 actIndex)
public [async] System.Threading.Tasks.Task SetUpSavedMultiplayer(MegaCrit.Sts2.Core.Runs.RunState state, MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.LoadRunLobby lobby)
public [async] System.Threading.Tasks.Task SetUpSavedSingleplayer(MegaCrit.Sts2.Core.Runs.RunState state, MegaCrit.Sts2.Core.Saves.SerializableRun save)
public [async] System.Threading.Tasks.Task WinRun()
public [async] System.Threading.Tasks.Task<MegaCrit.Sts2.Core.Rooms.AbstractRoom> EnterRoomDebug(MegaCrit.Sts2.Core.Rooms.RoomType roomType, MegaCrit.Sts2.Core.Map.MapPointType pointType = 0, MegaCrit.Sts2.Core.Models.AbstractModel model = null, System.Boolean showTransition = True)
public MegaCrit.Sts2.Core.Entities.Ascension.AscensionManager get_AscensionManager()
public MegaCrit.Sts2.Core.GameActions.ActionExecutor get_ActionExecutor()
public MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSet get_ActionQueueSet()
public MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionQueueSynchronizer get_ActionQueueSynchronizer()
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceSynchronizer get_PlayerChoiceSynchronizer()
public MegaCrit.Sts2.Core.Multiplayer.CombatStateSynchronizer get_CombatStateSynchronizer()
public MegaCrit.Sts2.Core.Multiplayer.Game.ActChangeSynchronizer get_ActChangeSynchronizer()
public MegaCrit.Sts2.Core.Multiplayer.Game.ChecksumTracker get_ChecksumTracker()
public MegaCrit.Sts2.Core.Multiplayer.Game.EventSynchronizer get_EventSynchronizer()
public MegaCrit.Sts2.Core.Multiplayer.Game.FlavorSynchronizer get_FlavorSynchronizer()
public MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService get_NetService()
public MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.RunLobby get_RunLobby()
public MegaCrit.Sts2.Core.Multiplayer.Game.MapSelectionSynchronizer get_MapSelectionSynchronizer()
public MegaCrit.Sts2.Core.Multiplayer.Game.OneOffSynchronizer get_OneOffSynchronizer()
public MegaCrit.Sts2.Core.Multiplayer.Game.PeerInput.HoveredModelTracker get_HoveredModelTracker()
public MegaCrit.Sts2.Core.Multiplayer.Game.PeerInput.PeerInputSynchronizer get_InputSynchronizer()
public MegaCrit.Sts2.Core.Multiplayer.Game.RestSiteSynchronizer get_RestSiteSynchronizer()
public MegaCrit.Sts2.Core.Multiplayer.Game.RewardsSetSynchronizer get_RewardsSetSynchronizer()
public MegaCrit.Sts2.Core.Multiplayer.Game.RewardSynchronizer get_RewardSynchronizer()
public MegaCrit.Sts2.Core.Multiplayer.Game.RunLocationTargetedMessageBuffer get_RunLocationTargetedBuffer()
public MegaCrit.Sts2.Core.Multiplayer.Game.TreasureRoomRelicSynchronizer get_TreasureRoomRelicSynchronizer()
public MegaCrit.Sts2.Core.Multiplayer.Replay.CombatReplayWriter get_CombatReplayWriter()
public MegaCrit.Sts2.Core.Runs.RunHistory get_History()
public MegaCrit.Sts2.Core.Runs.RunState DebugOnlyGetState()
public MegaCrit.Sts2.Core.Runs.RunState Launch()
public MegaCrit.Sts2.Core.Saves.MapDrawing.SerializableMapDrawings get_MapDrawingsToLoad()
public MegaCrit.Sts2.Core.Saves.SerializableRun OnEnded(System.Boolean isVictory)
public MegaCrit.Sts2.Core.Saves.SerializableRun ToSave(MegaCrit.Sts2.Core.Rooms.AbstractRoom preFinishedRoom)
public static MegaCrit.Sts2.Core.Runs.RunManager get_Instance()
public static MegaCrit.Sts2.Core.Saves.SerializableRun CanonicalizeSave(MegaCrit.Sts2.Core.Saves.SerializableRun save, System.UInt64 localPlayerId)
public static System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Rooms.RoomType> BuildRoomTypeBlacklist(MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry previousMapPointEntry, System.Collections.Generic.IReadOnlyCollection<MegaCrit.Sts2.Core.Map.MapPoint> nextMapPoints)
public System.Boolean get_ForceDiscoveryOrderModifications()
public System.Boolean get_IsAbandoned()
public System.Boolean get_IsCleaningUp()
public System.Boolean get_IsGameOver()
public System.Boolean get_IsInProgress()
public System.Boolean get_IsPaused()
public System.Boolean get_IsSingleplayerOrFakeMultiplayer()
public System.Boolean get_ShouldSave()
public System.Boolean HasAscension(MegaCrit.Sts2.Core.Entities.Ascension.AscensionLevel level)
public System.Boolean ShouldApplyTutorialModifications()
public System.Collections.Generic.Dictionary<System.Int32, MegaCrit.Sts2.Core.Saves.Runs.SerializableActMap> get_SavedMapsToLoad()
public System.Int64 get_RunTime()
public System.Int64 get_WinTime()
public System.Nullable<System.DateTimeOffset> get_DailyTime()
public System.String GetLocalCharacterEnergyIconPrefix()
public System.Threading.Tasks.Task EnterMapCoord(MegaCrit.Sts2.Core.Map.MapCoord coord)
public System.Void Abandon()
public System.Void add_ActEntered(System.Action value)
public System.Void add_RoomEntered(System.Action value)
public System.Void add_RoomExited(System.Action value)
public System.Void add_RunStarted(System.Action<MegaCrit.Sts2.Core.Runs.RunState> value)
public System.Void add_TestFadeIn(System.Func<System.Threading.Tasks.Task> value)
public System.Void add_TestFadeOut(System.Func<System.Threading.Tasks.Task> value)
public System.Void ApplyAscensionEffects(MegaCrit.Sts2.Core.Entities.Players.Player player)
public System.Void CleanUp(System.Boolean graceful = True)
public System.Void GenerateRooms()
public System.Void remove_ActEntered(System.Action value)
public System.Void remove_RoomEntered(System.Action value)
public System.Void remove_RoomExited(System.Action value)
public System.Void remove_RunStarted(System.Action<MegaCrit.Sts2.Core.Runs.RunState> value)
public System.Void remove_TestFadeIn(System.Func<System.Threading.Tasks.Task> value)
public System.Void remove_TestFadeOut(System.Func<System.Threading.Tasks.Task> value)
public System.Void set_ForceDiscoveryOrderModifications(System.Boolean value)
public System.Void set_History(MegaCrit.Sts2.Core.Runs.RunHistory value)
public System.Void set_IsPaused(System.Boolean value)
public System.Void set_MapDrawingsToLoad(MegaCrit.Sts2.Core.Saves.MapDrawing.SerializableMapDrawings value)
public System.Void set_SavedMapsToLoad(System.Collections.Generic.Dictionary<System.Int32, MegaCrit.Sts2.Core.Saves.Runs.SerializableActMap> value)
public System.Void set_WinTime(System.Int64 value)
public System.Void SetUpNewMultiplayer(MegaCrit.Sts2.Core.Runs.RunState state, MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby lobby, System.Boolean shouldSave, System.Nullable<System.DateTimeOffset> dailyTime = null)
public System.Void SetUpNewSingleplayer(MegaCrit.Sts2.Core.Runs.RunState state, System.Boolean shouldSave, System.Nullable<System.DateTimeOffset> dailyTime = null)
public System.Void SetUpReplay(MegaCrit.Sts2.Core.Runs.RunState state, MegaCrit.Sts2.Core.Multiplayer.Replay.CombatReplay replay, System.UInt64 playerIdToLoad)
public System.Void SetUpTest(MegaCrit.Sts2.Core.Runs.RunState state, MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService gameService, System.Boolean disableCombatStateSync = True, System.Boolean shouldSave = False)
public System.Void WriteReplay(System.Boolean stopRecording)
public virtual MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.ClientRejoinResponseMessage GetRejoinMessage()
public virtual System.Void LocalPlayerDisconnected(MegaCrit.Sts2.Core.Entities.Multiplayer.NetErrorInfo info)
```

## MegaCrit.Sts2.Core.Runs.RunManager+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Runs.RunManager+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Entities.Multiplayer.StartRunLobbyPlayer, MegaCrit.Sts2.Core.Entities.Multiplayer.RunLobbyPlayer> <>9__170_0
public static System.Func<MegaCrit.Sts2.Core.Entities.Multiplayer.LoadRunLobbyPlayer, MegaCrit.Sts2.Core.Entities.Multiplayer.RunLobbyPlayer> <>9__172_0
public static System.Func<MegaCrit.Sts2.Core.Saves.Runs.SerializablePlayer, System.UInt64> <>9__181_1
public static System.Func<MegaCrit.Sts2.Core.Models.ActModel, MegaCrit.Sts2.Core.Saves.Runs.SerializableActModel, MegaCrit.Sts2.Core.Saves.Runs.SerializableActModel> <>9__181_2
public static System.Func<MegaCrit.Sts2.Core.Models.ModifierModel, MegaCrit.Sts2.Core.Saves.Runs.SerializableModifier> <>9__181_3
public static System.Func<MegaCrit.Sts2.Core.Entities.Players.Player, MegaCrit.Sts2.Core.Saves.Runs.SerializablePlayer> <>9__181_4
public static System.Func<System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry>, System.Collections.Generic.List<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry>> <>9__181_5
public static System.Func<MegaCrit.Sts2.Core.Map.MapPoint, System.Boolean> <>9__182_0
public static System.Func<MegaCrit.Sts2.Core.Models.ModifierModel, MegaCrit.Sts2.Core.Saves.Runs.SerializableModifier> <>9__183_0
public static System.Func<MegaCrit.Sts2.Core.Entities.Players.Player, MegaCrit.Sts2.Core.Saves.Runs.SerializablePlayer> <>9__183_1
public static System.Func<System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry>, System.Collections.Generic.List<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry>> <>9__183_2
public static System.Func<System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry>, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry>> <>9__195_0
public static System.Func<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry, System.Boolean> <>9__195_1
private static .cctor()
public .ctor()
internal MegaCrit.Sts2.Core.Entities.Multiplayer.RunLobbyPlayer <SetUpNewMultiplayer>b__170_0(MegaCrit.Sts2.Core.Entities.Multiplayer.StartRunLobbyPlayer p)
internal MegaCrit.Sts2.Core.Entities.Multiplayer.RunLobbyPlayer <SetUpSavedMultiplayer>b__172_0(MegaCrit.Sts2.Core.Entities.Multiplayer.LoadRunLobbyPlayer p)
internal MegaCrit.Sts2.Core.Saves.Runs.SerializableActModel <CanonicalizeSave>b__181_2(MegaCrit.Sts2.Core.Models.ActModel act, MegaCrit.Sts2.Core.Saves.Runs.SerializableActModel savedAct)
internal MegaCrit.Sts2.Core.Saves.Runs.SerializableModifier <CanonicalizeSave>b__181_3(MegaCrit.Sts2.Core.Models.ModifierModel m)
internal MegaCrit.Sts2.Core.Saves.Runs.SerializableModifier <ToSave>b__183_0(MegaCrit.Sts2.Core.Models.ModifierModel m)
internal MegaCrit.Sts2.Core.Saves.Runs.SerializablePlayer <CanonicalizeSave>b__181_4(MegaCrit.Sts2.Core.Entities.Players.Player p)
internal MegaCrit.Sts2.Core.Saves.Runs.SerializablePlayer <ToSave>b__183_1(MegaCrit.Sts2.Core.Entities.Players.Player p)
internal System.Boolean <BuildRoomTypeBlacklist>b__182_0(MegaCrit.Sts2.Core.Map.MapPoint p)
internal System.Boolean <TryGetRoomTypeForTutorial>b__195_1(MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry e)
internal System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry> <TryGetRoomTypeForTutorial>b__195_0(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry> l)
internal System.Collections.Generic.List<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry> <CanonicalizeSave>b__181_5(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry> l)
internal System.Collections.Generic.List<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry> <ToSave>b__183_2(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry> l)
internal System.UInt64 <CanonicalizeSave>b__181_1(MegaCrit.Sts2.Core.Saves.Runs.SerializablePlayer p)
```

## MegaCrit.Sts2.Core.Runs.RunManager+<>c__DisplayClass173_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Multiplayer.NetReplayGameService netService
public .ctor()
internal MegaCrit.Sts2.Core.Entities.Multiplayer.RunLobbyPlayer <SetUpReplay>b__0(MegaCrit.Sts2.Core.Entities.Players.Player p)
```

## MegaCrit.Sts2.Core.Runs.RunManager+<>c__DisplayClass174_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService gameService
public .ctor()
internal MegaCrit.Sts2.Core.Entities.Multiplayer.RunLobbyPlayer <SetUpTest>b__0(MegaCrit.Sts2.Core.Entities.Players.Player p)
```

## MegaCrit.Sts2.Core.Runs.RunManager+<>c__DisplayClass181_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.UInt64 localPlayerId
public .ctor()
internal System.Boolean <CanonicalizeSave>b__0(MegaCrit.Sts2.Core.Saves.Runs.SerializablePlayer p)
```

## MegaCrit.Sts2.Core.Runs.RunManager+<>c__DisplayClass186_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Models.ActModel act
public .ctor()
internal System.Boolean <GenerateRooms>b__0(MegaCrit.Sts2.Core.Models.EncounterModel e)
```

## MegaCrit.Sts2.Core.Runs.RunManager+<AbandonInternal>d__216

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Runs.RunManager <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Runs.RunManager+<EnterAct>d__208

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Runs.RunManager <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private MegaCrit.Sts2.Core.Multiplayer.Game.NetLoadingHandle <loadHandle>5__2
public System.Int32 currentActIndex
public System.Boolean doTransition
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Runs.RunManager+<EnterMapCoordDebug>d__199

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Runs.RunManager <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Rooms.AbstractRoom> <>u__1
public MegaCrit.Sts2.Core.Map.MapCoord coord
public MegaCrit.Sts2.Core.Models.AbstractModel model
public MegaCrit.Sts2.Core.Map.MapPointType pointType
public MegaCrit.Sts2.Core.Rooms.RoomType roomType
public System.Boolean showTransition
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Runs.RunManager+<EnterMapPointInternal>d__192

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Runs.RunManager <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private MegaCrit.Sts2.Core.Rooms.CombatRoom <combatRoom>5__3
private MegaCrit.Sts2.Core.Multiplayer.Game.NetLoadingHandle <loadHandle>5__2
public System.Int32 actFloor
public MegaCrit.Sts2.Core.Map.MapPointType pointType
public MegaCrit.Sts2.Core.Rooms.AbstractRoom preFinishedRoom
public System.Boolean saveGame
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Runs.RunManager+<EnterNextAct>d__206

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Runs.RunManager <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private MegaCrit.Sts2.Core.Multiplayer.Game.NetLoadingHandle <loadHandle>5__2
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Runs.RunManager+<EnterRoom>d__204

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Runs.RunManager <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.Rooms.AbstractRoom room
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Runs.RunManager+<EnterRoomDebug>d__200

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Runs.RunManager <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<MegaCrit.Sts2.Core.Rooms.AbstractRoom> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private MegaCrit.Sts2.Core.Multiplayer.Game.NetLoadingHandle <loadHandle>5__2
private MegaCrit.Sts2.Core.Rooms.AbstractRoom <room>5__3
public MegaCrit.Sts2.Core.Models.AbstractModel model
public MegaCrit.Sts2.Core.Map.MapPointType pointType
public MegaCrit.Sts2.Core.Rooms.RoomType roomType
public System.Boolean showTransition
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Runs.RunManager+<EnterRoomInternal>d__203

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Runs.RunManager <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Boolean <runExternalEffects>5__2
public System.Boolean isRestoringRoomStackBase
public MegaCrit.Sts2.Core.Rooms.AbstractRoom room
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Runs.RunManager+<EnterRoomWithoutExitingCurrentRoom>d__205

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Runs.RunManager <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private MegaCrit.Sts2.Core.Multiplayer.Game.NetLoadingHandle <loadHandle>5__2
public System.Boolean fadeToBlack
public MegaCrit.Sts2.Core.Rooms.AbstractRoom room
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Runs.RunManager+<ExitCurrentRoom>d__202

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Runs.RunManager <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<MegaCrit.Sts2.Core.Rooms.AbstractRoom> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private MegaCrit.Sts2.Core.Rooms.AbstractRoom <currentRoom>5__2
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Runs.RunManager+<ExitCurrentRooms>d__201

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Runs.RunManager <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Rooms.AbstractRoom> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Runs.RunManager+<FadeIn>d__196

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Runs.RunManager <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public System.Boolean showTransition
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Runs.RunManager+<FadeOut>d__197

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Runs.RunManager <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Runs.RunManager+<FinalizeStartingRelics>d__185

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Runs.RunManager <>4__this
private System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Entities.Players.Player> <>7__wrap1
private System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Models.RelicModel> <>7__wrap2
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Runs.RunManager+<GenerateMap>d__188

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Runs.RunManager <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private MegaCrit.Sts2.Core.Map.ActMap <map>5__2
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Runs.RunManager+<GuaranteeKillAllPlayers>d__217

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Runs.RunManager <>4__this
private System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Entities.Players.Player> <>7__wrap1
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Runs.RunManager+<LoadIntoLatestMapCoord>d__190

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Runs.RunManager <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.Rooms.AbstractRoom preFinishedRoom
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Runs.RunManager+<ProceedFromTerminalRewardsScreen>d__211

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Runs.RunManager <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Runs.RunManager+<ResumePreviousRoom>d__212

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Runs.RunManager <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Rooms.AbstractRoom> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Runs.RunManager+<ReturnToMainMenuWithError>d__229

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Runs.RunManager <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.Entities.Multiplayer.NetErrorInfo info
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Runs.RunManager+<SetActInternal>d__209

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Runs.RunManager <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public System.Int32 actIndex
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Runs.RunManager+<SetUpSavedMultiplayer>d__172

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Runs.RunManager <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private MegaCrit.Sts2.Core.Saves.SerializableRun <save>5__2
public MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.LoadRunLobby lobby
public MegaCrit.Sts2.Core.Runs.RunState state
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Runs.RunManager+<SetUpSavedSingleplayer>d__171

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Runs.RunManager <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.Saves.SerializableRun save
public MegaCrit.Sts2.Core.Runs.RunState state
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Runs.RunManager+<WinRun>d__207

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Runs.RunManager <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Runs.RunRngSet

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static readonly MegaCrit.Sts2.Core.Runs.RunRngSet _mockInstance
private readonly System.Collections.Generic.Dictionary<MegaCrit.Sts2.Core.Entities.Rngs.RunRngType, MegaCrit.Sts2.Core.Random.Rng> _rngs
private readonly System.UInt64 <Seed>k__BackingField
private readonly System.String <StringSeed>k__BackingField
MegaCrit.Sts2.Core.Random.Rng CombatCardGeneration { public get; }
MegaCrit.Sts2.Core.Random.Rng CombatCardSelection { public get; }
MegaCrit.Sts2.Core.Random.Rng CombatEnergyCosts { public get; }
MegaCrit.Sts2.Core.Random.Rng CombatOrbGeneration { public get; }
MegaCrit.Sts2.Core.Random.Rng CombatPotionGeneration { public get; }
MegaCrit.Sts2.Core.Random.Rng CombatTargets { public get; }
MegaCrit.Sts2.Core.Random.Rng MonsterAi { public get; }
MegaCrit.Sts2.Core.Random.Rng Niche { public get; }
System.UInt64 Seed { public get; }
MegaCrit.Sts2.Core.Random.Rng Shuffle { public get; }
System.String StringSeed { public get; }
MegaCrit.Sts2.Core.Random.Rng TreasureRoomRelics { public get; }
MegaCrit.Sts2.Core.Random.Rng UnknownMapPoint { public get; }
MegaCrit.Sts2.Core.Random.Rng UpFront { public get; }
private static .cctor()
public .ctor(MegaCrit.Sts2.Core.Random.Rng rng)
public .ctor(System.String seed)
private MegaCrit.Sts2.Core.Random.Rng CreateRng(MegaCrit.Sts2.Core.Entities.Rngs.RunRngType rngType)
public MegaCrit.Sts2.Core.Random.Rng get_CombatCardGeneration()
public MegaCrit.Sts2.Core.Random.Rng get_CombatCardSelection()
public MegaCrit.Sts2.Core.Random.Rng get_CombatEnergyCosts()
public MegaCrit.Sts2.Core.Random.Rng get_CombatOrbGeneration()
public MegaCrit.Sts2.Core.Random.Rng get_CombatPotionGeneration()
public MegaCrit.Sts2.Core.Random.Rng get_CombatTargets()
public MegaCrit.Sts2.Core.Random.Rng get_MonsterAi()
public MegaCrit.Sts2.Core.Random.Rng get_Niche()
public MegaCrit.Sts2.Core.Random.Rng get_Shuffle()
public MegaCrit.Sts2.Core.Random.Rng get_TreasureRoomRelics()
public MegaCrit.Sts2.Core.Random.Rng get_UnknownMapPoint()
public MegaCrit.Sts2.Core.Random.Rng get_UpFront()
public MegaCrit.Sts2.Core.Random.Rng GetRng(MegaCrit.Sts2.Core.Entities.Rngs.RunRngType rngType)
public MegaCrit.Sts2.Core.Saves.Runs.SerializableRunRngSet ToSerializable()
public static MegaCrit.Sts2.Core.Runs.RunRngSet FromSave(MegaCrit.Sts2.Core.Saves.Runs.SerializableRunRngSet save)
public static MegaCrit.Sts2.Core.Runs.RunRngSet GetMockInstance()
public System.String get_StringSeed()
public System.UInt64 get_Seed()
public System.Void LoadFromSerializable(MegaCrit.Sts2.Core.Saves.Runs.SerializableRunRngSet save)
public System.Void MockRng(MegaCrit.Sts2.Core.Entities.Rngs.RunRngType rngType, System.UInt64 seed)
```

## MegaCrit.Sts2.Core.Runs.RunState

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：`MegaCrit.Sts2.Core.Runs.IRunState`, `MegaCrit.Sts2.Core.Runs.ICardScope`, `MegaCrit.Sts2.Core.Runs.IPlayerCollection`

```text
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.CardModel> _allCards
private System.Int32 _currentActIndex
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Rooms.AbstractRoom> _currentRooms
private readonly System.Collections.Generic.List<System.Collections.Generic.List<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry>> _mapPointHistory
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Players.Player> _players
private readonly System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Models.ModelId> _visitedEventIds
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Map.MapCoord> _visitedMapCoords
private System.Int32 <ActFloor>k__BackingField
private System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel> <Acts>k__BackingField
private readonly System.Int32 <AscensionLevel>k__BackingField
private System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.BadgeModel> <BadgeModels>k__BackingField
private MegaCrit.Sts2.Core.Runs.ExtraRunFields <ExtraFields>k__BackingField
private readonly MegaCrit.Sts2.Core.Runs.GameMode <GameMode>k__BackingField
private MegaCrit.Sts2.Core.Map.ActMap <Map>k__BackingField
private System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel> <Modifiers>k__BackingField
private MegaCrit.Sts2.Core.Models.Singleton.MultiplayerScalingModel <MultiplayerScalingModel>k__BackingField
private System.Int32 <NextRoomId>k__BackingField
private readonly MegaCrit.Sts2.Core.Odds.RunOddsSet <Odds>k__BackingField
private readonly MegaCrit.Sts2.Core.Runs.RunRngSet <Rng>k__BackingField
private readonly MegaCrit.Sts2.Core.Runs.RelicGrabBag <SharedRelicGrabBag>k__BackingField
private readonly MegaCrit.Sts2.Core.Unlocks.UnlockState <UnlockState>k__BackingField
MegaCrit.Sts2.Core.Models.ActModel Act { public virtual get; }
System.Int32 ActFloor { public virtual get; public virtual set; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel> Acts { public virtual get; private set; }
System.Int32 AscensionLevel { public virtual get; public set; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.BadgeModel> BadgeModels { public virtual get; private set; }
MegaCrit.Sts2.Core.Rooms.AbstractRoom BaseRoom { public virtual get; }
System.Int32 CurrentActIndex { public virtual get; public virtual set; }
System.Nullable<MegaCrit.Sts2.Core.Map.MapCoord> CurrentMapCoord { public virtual get; }
MegaCrit.Sts2.Core.Map.MapPoint CurrentMapPoint { public virtual get; }
MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry CurrentMapPointHistoryEntry { public virtual get; }
MegaCrit.Sts2.Core.Rooms.AbstractRoom CurrentRoom { public virtual get; }
System.Int32 CurrentRoomCount { public virtual get; }
MegaCrit.Sts2.Core.Runs.ExtraRunFields ExtraFields { public virtual get; private set; }
MegaCrit.Sts2.Core.Runs.GameMode GameMode { public virtual get; public set; }
System.Boolean IsGameOver { public virtual get; }
MegaCrit.Sts2.Core.Map.ActMap Map { public virtual get; public virtual set; }
MegaCrit.Sts2.Core.Runs.MapLocation MapLocation { public virtual get; }
System.Collections.Generic.IReadOnlyList<System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry>> MapPointHistory { public virtual get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel> Modifiers { public virtual get; private set; }
MegaCrit.Sts2.Core.Models.Singleton.MultiplayerScalingModel MultiplayerScalingModel { public virtual get; private set; }
System.Int32 NextRoomId { public get; private set; }
MegaCrit.Sts2.Core.Odds.RunOddsSet Odds { public virtual get; public set; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Players.Player> Players { public virtual get; }
MegaCrit.Sts2.Core.Runs.RunRngSet Rng { public virtual get; public set; }
MegaCrit.Sts2.Core.Runs.RunLocation RunLocation { public virtual get; }
MegaCrit.Sts2.Core.Runs.RelicGrabBag SharedRelicGrabBag { public virtual get; public set; }
System.Int32 TotalFloor { public virtual get; }
MegaCrit.Sts2.Core.Unlocks.UnlockState UnlockState { public virtual get; public set; }
System.Collections.Generic.IReadOnlySet<MegaCrit.Sts2.Core.Models.ModelId> VisitedEventIds { public get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Map.MapCoord> VisitedMapCoords { public get; }
private .ctor(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Players.Player> players, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel> acts, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel> modifiers, MegaCrit.Sts2.Core.Runs.GameMode gameMode, System.Int32 currentActIndex, MegaCrit.Sts2.Core.Runs.RunRngSet rng, MegaCrit.Sts2.Core.Odds.RunOddsSet odds, MegaCrit.Sts2.Core.Runs.RelicGrabBag sharedRelicGrabBag, System.Int32 ascensionLevel)
private static MegaCrit.Sts2.Core.Runs.RunState CreateShared(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Players.Player> players, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel> acts, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel> modifiers, MegaCrit.Sts2.Core.Runs.GameMode gameMode, System.Int32 currentActIndex, MegaCrit.Sts2.Core.Runs.RunRngSet rng, MegaCrit.Sts2.Core.Odds.RunOddsSet odds, MegaCrit.Sts2.Core.Runs.RelicGrabBag sharedRelicGrabBag, System.Int32 ascensionLevel)
private static System.Boolean Contains(MegaCrit.Sts2.Core.Models.AbstractModel model)
private System.Void AddCard(MegaCrit.Sts2.Core.Models.CardModel card)
private System.Void set_Acts(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel> value)
private System.Void set_BadgeModels(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.BadgeModel> value)
private System.Void set_ExtraFields(MegaCrit.Sts2.Core.Runs.ExtraRunFields value)
private System.Void set_Modifiers(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel> value)
private System.Void set_MultiplayerScalingModel(MegaCrit.Sts2.Core.Models.Singleton.MultiplayerScalingModel value)
private System.Void set_NextRoomId(System.Int32 value)
public MegaCrit.Sts2.Core.Rooms.AbstractRoom PopCurrentRoom()
public static MegaCrit.Sts2.Core.Runs.RunState CreateForNewRun(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Players.Player> players, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel> acts, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel> modifiers, MegaCrit.Sts2.Core.Runs.GameMode gameMode, System.Int32 ascensionLevel, System.String seed)
public static MegaCrit.Sts2.Core.Runs.RunState CreateForTest(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Players.Player> players = null, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel> acts = null, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel> modifiers = null, MegaCrit.Sts2.Core.Runs.GameMode gameMode = 1, System.Int32 ascensionLevel = 0, System.String seed = null)
public static MegaCrit.Sts2.Core.Runs.RunState FromSerializable(MegaCrit.Sts2.Core.Saves.SerializableRun save)
public System.Boolean AddVisitedMapCoord(MegaCrit.Sts2.Core.Map.MapCoord coord)
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Map.MapCoord> get_VisitedMapCoords()
public System.Collections.Generic.IReadOnlySet<MegaCrit.Sts2.Core.Models.ModelId> get_VisitedEventIds()
public System.Int32 get_NextRoomId()
public System.Int32 GetPlayerSlotIndex(System.UInt64 netId)
public System.Void AddModifierDebug(MegaCrit.Sts2.Core.Models.ModifierModel modifier)
public System.Void AddPlayerDebug(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Int32 index)
public System.Void AddVisitedEvent(MegaCrit.Sts2.Core.Models.EventModel eventModel)
public System.Void ClearVisitedMapCoordsDebug()
public System.Void PushRoom(MegaCrit.Sts2.Core.Rooms.AbstractRoom room)
public System.Void RemoveStaleVisitedMapCoords(MegaCrit.Sts2.Core.Map.ActMap map)
public System.Void set_AscensionLevel(System.Int32 value)
public System.Void set_GameMode(MegaCrit.Sts2.Core.Runs.GameMode value)
public System.Void set_Odds(MegaCrit.Sts2.Core.Odds.RunOddsSet value)
public System.Void set_Rng(MegaCrit.Sts2.Core.Runs.RunRngSet value)
public System.Void set_SharedRelicGrabBag(MegaCrit.Sts2.Core.Runs.RelicGrabBag value)
public System.Void set_UnlockState(MegaCrit.Sts2.Core.Unlocks.UnlockState value)
public System.Void SetActDebug(MegaCrit.Sts2.Core.Models.ActModel act)
public virtual MegaCrit.Sts2.Core.Entities.Players.Player GetPlayer(System.UInt64 netId)
public virtual MegaCrit.Sts2.Core.Map.ActMap get_Map()
public virtual MegaCrit.Sts2.Core.Map.MapPoint get_CurrentMapPoint()
public virtual MegaCrit.Sts2.Core.Models.ActModel get_Act()
public virtual MegaCrit.Sts2.Core.Models.CardModel CloneCard(MegaCrit.Sts2.Core.Models.CardModel mutableCard)
public virtual MegaCrit.Sts2.Core.Models.CardModel CreateCard(MegaCrit.Sts2.Core.Models.CardModel canonicalCard, MegaCrit.Sts2.Core.Entities.Players.Player owner)
public virtual MegaCrit.Sts2.Core.Models.CardModel LoadCard(MegaCrit.Sts2.Core.Saves.Runs.SerializableCard serializableCard, MegaCrit.Sts2.Core.Entities.Players.Player owner)
public virtual MegaCrit.Sts2.Core.Models.Singleton.MultiplayerScalingModel get_MultiplayerScalingModel()
public virtual MegaCrit.Sts2.Core.Odds.RunOddsSet get_Odds()
public virtual MegaCrit.Sts2.Core.Rooms.AbstractRoom get_BaseRoom()
public virtual MegaCrit.Sts2.Core.Rooms.AbstractRoom get_CurrentRoom()
public virtual MegaCrit.Sts2.Core.Runs.ExtraRunFields get_ExtraFields()
public virtual MegaCrit.Sts2.Core.Runs.GameMode get_GameMode()
public virtual MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry get_CurrentMapPointHistoryEntry()
public virtual MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry GetHistoryEntryFor(MegaCrit.Sts2.Core.Runs.MapLocation location)
public virtual MegaCrit.Sts2.Core.Runs.MapLocation get_MapLocation()
public virtual MegaCrit.Sts2.Core.Runs.RelicGrabBag get_SharedRelicGrabBag()
public virtual MegaCrit.Sts2.Core.Runs.RunLocation get_RunLocation()
public virtual MegaCrit.Sts2.Core.Runs.RunRngSet get_Rng()
public virtual MegaCrit.Sts2.Core.Unlocks.UnlockState get_UnlockState()
public virtual System.Boolean ContainsCard(MegaCrit.Sts2.Core.Models.CardModel card)
public virtual System.Boolean get_IsGameOver()
public virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AbstractModel> IterateHookListeners(MegaCrit.Sts2.Core.Combat.ICombatState childCombatState)
public virtual System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Players.Player> get_Players()
public virtual System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel> get_Acts()
public virtual System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.BadgeModel> get_BadgeModels()
public virtual System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel> get_Modifiers()
public virtual System.Collections.Generic.IReadOnlyList<System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry>> get_MapPointHistory()
public virtual System.Int32 get_ActFloor()
public virtual System.Int32 get_AscensionLevel()
public virtual System.Int32 get_CurrentActIndex()
public virtual System.Int32 get_CurrentRoomCount()
public virtual System.Int32 get_TotalFloor()
public virtual System.Int32 GetAndIncrementNextRoomId()
public virtual System.Int32 GetPlayerSlotIndex(MegaCrit.Sts2.Core.Entities.Players.Player player)
public virtual System.Nullable<MegaCrit.Sts2.Core.Map.MapCoord> get_CurrentMapCoord()
public virtual System.Void AddCard(MegaCrit.Sts2.Core.Models.CardModel card, MegaCrit.Sts2.Core.Entities.Players.Player owner)
public virtual System.Void AppendToMapPointHistory(MegaCrit.Sts2.Core.Map.MapPointType mapPointType, MegaCrit.Sts2.Core.Rooms.RoomType initialRoomType, MegaCrit.Sts2.Core.Models.ModelId roomModelId)
public virtual System.Void RemoveCard(MegaCrit.Sts2.Core.Models.CardModel card)
public virtual System.Void set_ActFloor(System.Int32 value)
public virtual System.Void set_CurrentActIndex(System.Int32 value)
public virtual System.Void set_Map(MegaCrit.Sts2.Core.Map.ActMap value)
public virtual T CreateCard<T>(MegaCrit.Sts2.Core.Entities.Players.Player owner) where T: [None] MegaCrit.Sts2.Core.Models.CardModel
```

## MegaCrit.Sts2.Core.Runs.RunState+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Runs.RunState+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Entities.Players.Player, MegaCrit.Sts2.Core.Unlocks.UnlockState> <>9__100_0
public static System.Func<MegaCrit.Sts2.Core.Models.RelicModel, System.Boolean> <>9__118_0
public static System.Func<System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry>, System.Int32> <>9__37_0
public static System.Func<MegaCrit.Sts2.Core.Entities.Players.Player, System.Boolean> <>9__51_0
public static System.Func<MegaCrit.Sts2.Core.Models.ActModel, MegaCrit.Sts2.Core.Models.ActModel> <>9__98_0
public static System.Func<MegaCrit.Sts2.Core.Models.BadgeModel, MegaCrit.Sts2.Core.Models.BadgeModel> <>9__99_0
private static .cctor()
public .ctor()
internal MegaCrit.Sts2.Core.Models.ActModel <CreateForTest>b__98_0(MegaCrit.Sts2.Core.Models.ActModel a)
internal MegaCrit.Sts2.Core.Models.BadgeModel <CreateShared>b__99_0(MegaCrit.Sts2.Core.Models.BadgeModel m)
internal MegaCrit.Sts2.Core.Unlocks.UnlockState <.ctor>b__100_0(MegaCrit.Sts2.Core.Entities.Players.Player p)
internal System.Boolean <get_IsGameOver>b__51_0(MegaCrit.Sts2.Core.Entities.Players.Player p)
internal System.Boolean <IterateHookListeners>b__118_0(MegaCrit.Sts2.Core.Models.RelicModel r)
internal System.Int32 <get_TotalFloor>b__37_0(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry> c)
```

## MegaCrit.Sts2.Core.Runs.RunState+<>c__DisplayClass102_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.UInt64 netId
public .ctor()
internal System.Boolean <GetPlayerSlotIndex>b__0(MegaCrit.Sts2.Core.Entities.Players.Player p)
```

## MegaCrit.Sts2.Core.Runs.RunState+<>c__DisplayClass103_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.UInt64 netId
public .ctor()
internal System.Boolean <GetPlayer>b__0(MegaCrit.Sts2.Core.Entities.Players.Player p)
```

## MegaCrit.Sts2.Core.Runs.RunState+<>c__DisplayClass121_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Map.ActMap map
public .ctor()
internal System.Boolean <RemoveStaleVisitedMapCoords>b__0(MegaCrit.Sts2.Core.Map.MapCoord coord)
```

## MegaCrit.Sts2.Core.Runs.RunState+<>O

类型属性：`NestedPrivate, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static System.Func<MegaCrit.Sts2.Core.Saves.Runs.SerializablePlayer, MegaCrit.Sts2.Core.Entities.Players.Player> <0>__FromSerializable
public static System.Func<MegaCrit.Sts2.Core.Saves.Runs.SerializableActModel, MegaCrit.Sts2.Core.Models.ActModel> <1>__FromSave
public static System.Func<MegaCrit.Sts2.Core.Saves.Runs.SerializableModifier, MegaCrit.Sts2.Core.Models.ModifierModel> <2>__FromSerializable
```

## MegaCrit.Sts2.Core.Runs.RunState+<IterateHookListeners>d__118

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：`System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AbstractModel>`, `System.Collections.IEnumerable`, `System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Models.AbstractModel>`, `System.Collections.IEnumerator`, `System.IDisposable`

```text
private System.Int32 <>1__state
private MegaCrit.Sts2.Core.Models.AbstractModel <>2__current
public MegaCrit.Sts2.Core.Combat.ICombatState <>3__childCombatState
public MegaCrit.Sts2.Core.Runs.RunState <>4__this
private System.Collections.Generic.List+Enumerator<MegaCrit.Sts2.Core.Models.AbstractModel> <>7__wrap1
private System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Models.AbstractModel> <>7__wrap2
private System.Int32 <>l__initialThreadId
private MegaCrit.Sts2.Core.Combat.ICombatState childCombatState
MegaCrit.Sts2.Core.Models.AbstractModel System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Models.AbstractModel>.Current { private virtual get; }
System.Object System.Collections.IEnumerator.Current { private virtual get; }
public .ctor(System.Int32 <>1__state)
private System.Void <>m__Finally1()
private System.Void <>m__Finally2()
private System.Void <>m__Finally3()
private virtual MegaCrit.Sts2.Core.Models.AbstractModel System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Models.AbstractModel>.get_Current()
private virtual System.Boolean MoveNext()
private virtual System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Models.AbstractModel> System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AbstractModel>.GetEnumerator()
private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
private virtual System.Object System.Collections.IEnumerator.get_Current()
private virtual System.Void System.Collections.IEnumerator.Reset()
private virtual System.Void System.IDisposable.Dispose()
```

## MegaCrit.Sts2.Core.Runs.ScoreUtility

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static const System.Int32 clientScore = -999999999
private static System.Int32 CalculateScore(System.Collections.Generic.IReadOnlyList<System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry>> history, System.Int32 ascension, System.Boolean won, System.Int32 playerCount)
public static MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.DecodedDailyScore DecodeDailyScore(System.Int32 encodedScore)
public static System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.Badges.Badge> GetBadges(MegaCrit.Sts2.Core.Saves.SerializableRun run, System.UInt64 playerId, System.Boolean won)
public static System.Int32 CalculateDailyScore(MegaCrit.Sts2.Core.Saves.SerializableRun run, System.UInt64 localPlayerNetId, System.Boolean isVictory)
public static System.Int32 CalculateScore(MegaCrit.Sts2.Core.Runs.IRunState runState, System.Boolean won)
public static System.Int32 CalculateScore(MegaCrit.Sts2.Core.Saves.SerializableRun run, System.Boolean won)
public static System.Int32 GetBossesSlainCount(System.Collections.Generic.IReadOnlyList<System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry>> history, System.Boolean won)
public static System.Int32 GetElitesKilledCount(System.Collections.Generic.IReadOnlyList<System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry>> history)
public static System.Int32 GetScoreForBossesSlain(System.Int32 bossCount)
public static System.Int32 GetScoreForElitesKilled(System.Int32 elitesKilled)
public static System.Int32 GetScoreForFloor(System.Collections.Generic.IReadOnlyList<System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry>> history)
public static System.Int32 GetScoreForGoldGained(System.Collections.Generic.IReadOnlyList<System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry>> history, System.Int32 playerCount)
```

## MegaCrit.Sts2.Core.Runs.ScoreUtility+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Runs.ScoreUtility+<>c <>9
public static System.Func<System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry>, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry>> <>9__5_0
public static System.Func<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Runs.History.MapPointRoomHistoryEntry>> <>9__5_1
public static System.Func<MegaCrit.Sts2.Core.Runs.History.MapPointRoomHistoryEntry, System.Boolean> <>9__5_2
public static System.Func<System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry>, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry>> <>9__9_0
public static System.Func<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Runs.PlayerMapPointHistoryEntry>> <>9__9_1
public static System.Func<MegaCrit.Sts2.Core.Runs.PlayerMapPointHistoryEntry, System.Int32> <>9__9_2
private static .cctor()
public .ctor()
internal System.Boolean <GetElitesKilledCount>b__5_2(MegaCrit.Sts2.Core.Runs.History.MapPointRoomHistoryEntry r)
internal System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry> <GetElitesKilledCount>b__5_0(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry> actEntries)
internal System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry> <GetScoreForGoldGained>b__9_0(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry> actEntries)
internal System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Runs.History.MapPointRoomHistoryEntry> <GetElitesKilledCount>b__5_1(MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry e)
internal System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Runs.PlayerMapPointHistoryEntry> <GetScoreForGoldGained>b__9_1(MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry e)
internal System.Int32 <GetScoreForGoldGained>b__9_2(MegaCrit.Sts2.Core.Runs.PlayerMapPointHistoryEntry p)
```
