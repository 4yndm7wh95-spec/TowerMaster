# MegaCrit.Sts2.Core.Rooms

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Rooms.AbstractRoom

类型属性：`Public, Abstract, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private System.Nullable<System.Int32> <Id>k__BackingField
System.Nullable<System.Int32> Id { public get; private set; }
System.Boolean IsPreFinished { public virtual get; }
System.Boolean IsVictoryRoom { public get; }
MegaCrit.Sts2.Core.Models.ModelId ModelId { public abstract get; }
MegaCrit.Sts2.Core.Rooms.RoomType RoomType { public abstract get; }
protected .ctor()
private System.Void set_Id(System.Nullable<System.Int32> value)
public abstract MegaCrit.Sts2.Core.Models.ModelId get_ModelId()
public abstract MegaCrit.Sts2.Core.Rooms.RoomType get_RoomType()
public abstract System.Threading.Tasks.Task EnterInternal(MegaCrit.Sts2.Core.Runs.IRunState runState, System.Boolean isRestoringRoomStackBase)
public abstract System.Threading.Tasks.Task Exit(MegaCrit.Sts2.Core.Runs.IRunState runState)
public abstract System.Threading.Tasks.Task Resume(MegaCrit.Sts2.Core.Rooms.AbstractRoom exitedRoom, MegaCrit.Sts2.Core.Runs.IRunState runState)
public static MegaCrit.Sts2.Core.Rooms.AbstractRoom FromSerializable(MegaCrit.Sts2.Core.Saves.Runs.SerializableRoom serializableRoom, MegaCrit.Sts2.Core.Runs.IRunState runState)
public System.Boolean get_IsVictoryRoom()
public System.Nullable<System.Int32> get_Id()
public System.Threading.Tasks.Task Enter(MegaCrit.Sts2.Core.Runs.IRunState runState, System.Boolean isRestoringRoomStackBase)
public virtual MegaCrit.Sts2.Core.Saves.Runs.SerializableRoom ToSerializable()
public virtual System.Boolean get_IsPreFinished()
```

## MegaCrit.Sts2.Core.Rooms.BackgroundAssets

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private readonly System.String <BackgroundScenePath>k__BackingField
private readonly System.Collections.Generic.List<System.String> <BgLayers>k__BackingField
private readonly System.String <FgLayer>k__BackingField
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public get; }
System.String BackgroundScenePath { public get; }
System.Collections.Generic.List<System.String> BgLayers { public get; }
System.String FgLayer { public get; }
public .ctor(System.String title, MegaCrit.Sts2.Core.Random.Rng rng)
private static System.Collections.Generic.List<System.String> SelectRandomBackgroundAssetLayers(MegaCrit.Sts2.Core.Random.Rng rng, System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>> bgLayers)
private static System.String SelectRandomForegroundAssetLayer(MegaCrit.Sts2.Core.Random.Rng rng, System.Collections.Generic.IEnumerable<System.String> fgLayer)
public System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Collections.Generic.List<System.String> get_BgLayers()
public System.String get_BackgroundScenePath()
public System.String get_FgLayer()
```

## MegaCrit.Sts2.Core.Rooms.BackgroundAssets+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Rooms.BackgroundAssets+<>c <>9
public static System.Func<System.String, System.Boolean> <>9__11_0
public static System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.List<System.String>>, System.String> <>9__12_0
private static .cctor()
public .ctor()
internal System.Boolean <get_AssetPaths>b__11_0(System.String s)
internal System.String <SelectRandomBackgroundAssetLayers>b__12_0(System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.List<System.String>> kv)
```

## MegaCrit.Sts2.Core.Rooms.CombatEventVisuals

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：`MegaCrit.Sts2.Core.Rooms.ICombatRoomVisuals`

```text
private readonly MegaCrit.Sts2.Core.Models.ActModel <Act>k__BackingField
private readonly System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature> <Allies>k__BackingField
private readonly MegaCrit.Sts2.Core.Models.EncounterModel <Encounter>k__BackingField
MegaCrit.Sts2.Core.Models.ActModel Act { public virtual get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature> Allies { public virtual get; }
MegaCrit.Sts2.Core.Models.EncounterModel Encounter { public virtual get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature> Enemies { public virtual get; }
public .ctor(MegaCrit.Sts2.Core.Models.EncounterModel encounter, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Players.Player> players, MegaCrit.Sts2.Core.Models.ActModel act)
public virtual MegaCrit.Sts2.Core.Models.ActModel get_Act()
public virtual MegaCrit.Sts2.Core.Models.EncounterModel get_Encounter()
public virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature> get_Allies()
public virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature> get_Enemies()
```

## MegaCrit.Sts2.Core.Rooms.CombatEventVisuals+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Rooms.CombatEventVisuals+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Entities.Players.Player, MegaCrit.Sts2.Core.Entities.Creatures.Creature> <>9__11_0
public static System.Func<System.ValueTuple<MegaCrit.Sts2.Core.Models.MonsterModel, System.String>, MegaCrit.Sts2.Core.Entities.Creatures.Creature> <>9__7_0
private static .cctor()
public .ctor()
internal MegaCrit.Sts2.Core.Entities.Creatures.Creature <.ctor>b__11_0(MegaCrit.Sts2.Core.Entities.Players.Player p)
internal MegaCrit.Sts2.Core.Entities.Creatures.Creature <get_Enemies>b__7_0(System.ValueTuple<MegaCrit.Sts2.Core.Models.MonsterModel, System.String> m)
```

## MegaCrit.Sts2.Core.Rooms.CombatRoom

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Rooms.AbstractRoom`。

接口：`MegaCrit.Sts2.Core.Rooms.ICombatRoomVisuals`

```text
private readonly System.Collections.Generic.Dictionary<MegaCrit.Sts2.Core.Entities.Players.Player, System.Collections.Generic.List<MegaCrit.Sts2.Core.Rewards.Reward>> _extraRewards
private System.Boolean _isPreFinished
private readonly MegaCrit.Sts2.Core.Combat.CombatState <CombatState>k__BackingField
private System.Single <GoldProportion>k__BackingField
private readonly MegaCrit.Sts2.Core.Models.ModelId <ParentEventId>k__BackingField
private readonly System.Boolean <ShouldCreateCombat>k__BackingField
private readonly System.Boolean <ShouldResumeParentEventAfterCombat>k__BackingField
MegaCrit.Sts2.Core.Models.ActModel Act { public virtual get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature> Allies { public virtual get; }
MegaCrit.Sts2.Core.Combat.CombatState CombatState { public get; }
MegaCrit.Sts2.Core.Models.EncounterModel Encounter { public virtual get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature> Enemies { public virtual get; }
System.Collections.Generic.IReadOnlyDictionary<MegaCrit.Sts2.Core.Entities.Players.Player, System.Collections.Generic.List<MegaCrit.Sts2.Core.Rewards.Reward>> ExtraRewards { public get; }
System.Single GoldProportion { public get; private set; }
System.Boolean IsPreFinished { public virtual get; }
MegaCrit.Sts2.Core.Models.ModelId ModelId { public virtual get; }
MegaCrit.Sts2.Core.Models.ModelId ParentEventId { public get; public set; }
MegaCrit.Sts2.Core.Rooms.RoomType RoomType { public virtual get; }
System.Boolean ShouldCreateCombat { public get; public set; }
System.Boolean ShouldResumeParentEventAfterCombat { public get; public set; }
public .ctor(MegaCrit.Sts2.Core.Combat.CombatState combatState)
public .ctor(MegaCrit.Sts2.Core.Models.EncounterModel encounter, MegaCrit.Sts2.Core.Runs.IRunState runState)
private [async] System.Threading.Tasks.Task StartCombat(MegaCrit.Sts2.Core.Runs.IRunState runState)
private [async] System.Threading.Tasks.Task StartPreFinishedCombat()
private System.Void set_GoldProportion(System.Single value)
public [async] System.Threading.Tasks.Task OfferRoomEndRewards()
public MegaCrit.Sts2.Core.Combat.CombatState get_CombatState()
public MegaCrit.Sts2.Core.Models.ModelId get_ParentEventId()
public static MegaCrit.Sts2.Core.Rooms.CombatRoom FromSerializable(MegaCrit.Sts2.Core.Saves.Runs.SerializableRoom serializableRoom, MegaCrit.Sts2.Core.Runs.IRunState runState)
public System.Boolean get_ShouldCreateCombat()
public System.Boolean get_ShouldResumeParentEventAfterCombat()
public System.Collections.Generic.IReadOnlyDictionary<MegaCrit.Sts2.Core.Entities.Players.Player, System.Collections.Generic.List<MegaCrit.Sts2.Core.Rewards.Reward>> get_ExtraRewards()
public System.Single get_GoldProportion()
public System.Void AddExtraReward(MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.Rewards.Reward reward)
public System.Void MarkPreFinished()
public System.Void OnCombatEnded()
public System.Void set_ParentEventId(MegaCrit.Sts2.Core.Models.ModelId value)
public System.Void set_ShouldCreateCombat(System.Boolean value)
public System.Void set_ShouldResumeParentEventAfterCombat(System.Boolean value)
public virtual [async] System.Threading.Tasks.Task EnterInternal(MegaCrit.Sts2.Core.Runs.IRunState runState, System.Boolean isRestoringRoomStackBase)
public virtual MegaCrit.Sts2.Core.Models.ActModel get_Act()
public virtual MegaCrit.Sts2.Core.Models.EncounterModel get_Encounter()
public virtual MegaCrit.Sts2.Core.Models.ModelId get_ModelId()
public virtual MegaCrit.Sts2.Core.Rooms.RoomType get_RoomType()
public virtual MegaCrit.Sts2.Core.Saves.Runs.SerializableRoom ToSerializable()
public virtual System.Boolean get_IsPreFinished()
public virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature> get_Allies()
public virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature> get_Enemies()
public virtual System.Threading.Tasks.Task Exit(MegaCrit.Sts2.Core.Runs.IRunState runState)
public virtual System.Threading.Tasks.Task Resume(MegaCrit.Sts2.Core.Rooms.AbstractRoom _, MegaCrit.Sts2.Core.Runs.IRunState runState)
```

## MegaCrit.Sts2.Core.Rooms.CombatRoom+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Rooms.CombatRoom+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Rewards.Reward, MegaCrit.Sts2.Core.Saves.Runs.SerializableReward> <>9__43_0
private static .cctor()
public .ctor()
internal MegaCrit.Sts2.Core.Saves.Runs.SerializableReward <ToSerializable>b__43_0(MegaCrit.Sts2.Core.Rewards.Reward r)
```

## MegaCrit.Sts2.Core.Rooms.CombatRoom+<>c__DisplayClass39_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Entities.Players.Player player
public .ctor()
internal MegaCrit.Sts2.Core.Rewards.Reward <FromSerializable>b__0(MegaCrit.Sts2.Core.Saves.Runs.SerializableReward sr)
```

## MegaCrit.Sts2.Core.Rooms.CombatRoom+<EnterInternal>d__40

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Rooms.CombatRoom <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public System.Boolean isRestoringRoomStackBase
public MegaCrit.Sts2.Core.Runs.IRunState runState
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Rooms.CombatRoom+<OfferRoomEndRewards>d__49

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Rooms.CombatRoom <>4__this
private System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Entities.Players.Player> <>7__wrap2
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Rewards.RewardsSet> <>7__wrap3
private System.Collections.Generic.List+Enumerator<MegaCrit.Sts2.Core.Rewards.RewardsSet> <>7__wrap4
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Rewards.RewardsSet> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
private MegaCrit.Sts2.Core.Rewards.RewardsSet <reward>5__6
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Rewards.RewardsSet> <rewards>5__2
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Rooms.CombatRoom+<StartCombat>d__46

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Rooms.CombatRoom <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.Runs.IRunState runState
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Rooms.CombatRoom+<StartPreFinishedCombat>d__48

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Rooms.CombatRoom <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Rooms.CombatRoomMode

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Rooms.CombatRoomMode ActiveCombat = 0
public static const MegaCrit.Sts2.Core.Rooms.CombatRoomMode FinishedCombat = 1
public System.Int32 value__
public static const MegaCrit.Sts2.Core.Rooms.CombatRoomMode VisualOnly = 2
```

## MegaCrit.Sts2.Core.Rooms.EventRoom

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Rooms.AbstractRoom`。

接口：

```text
private System.Boolean _isPreFinished
private readonly MegaCrit.Sts2.Core.Models.EventModel <CanonicalEvent>k__BackingField
private readonly System.Action<MegaCrit.Sts2.Core.Models.EventModel> <OnStart>k__BackingField
MegaCrit.Sts2.Core.Models.EventModel CanonicalEvent { public get; }
System.Boolean IsPreFinished { public virtual get; }
MegaCrit.Sts2.Core.Models.EventModel LocalMutableEvent { public get; }
MegaCrit.Sts2.Core.Models.ModelId ModelId { public virtual get; }
System.Action<MegaCrit.Sts2.Core.Models.EventModel> OnStart { private get; public set; }
MegaCrit.Sts2.Core.Rooms.RoomType RoomType { public virtual get; }
public .ctor(MegaCrit.Sts2.Core.Models.EventModel eventModel)
public .ctor(MegaCrit.Sts2.Core.Saves.Runs.SerializableRoom serializableRoom)
private System.Action<MegaCrit.Sts2.Core.Models.EventModel> get_OnStart()
private System.Void OnEventStateChanged(MegaCrit.Sts2.Core.Models.EventModel eventModel)
public MegaCrit.Sts2.Core.Models.EventModel get_CanonicalEvent()
public MegaCrit.Sts2.Core.Models.EventModel get_LocalMutableEvent()
public System.Void MarkPreFinished()
public System.Void set_OnStart(System.Action<MegaCrit.Sts2.Core.Models.EventModel> value)
public virtual [async] System.Threading.Tasks.Task EnterInternal(MegaCrit.Sts2.Core.Runs.IRunState runState, System.Boolean isRestoringRoomStackBase)
public virtual [async] System.Threading.Tasks.Task Exit(MegaCrit.Sts2.Core.Runs.IRunState runState)
public virtual MegaCrit.Sts2.Core.Models.ModelId get_ModelId()
public virtual MegaCrit.Sts2.Core.Rooms.RoomType get_RoomType()
public virtual MegaCrit.Sts2.Core.Saves.Runs.SerializableRoom ToSerializable()
public virtual System.Boolean get_IsPreFinished()
public virtual System.Threading.Tasks.Task Resume(MegaCrit.Sts2.Core.Rooms.AbstractRoom exitedRoom, MegaCrit.Sts2.Core.Runs.IRunState runState)
```

## MegaCrit.Sts2.Core.Rooms.EventRoom+<EnterInternal>d__18

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Rooms.EventRoom <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private MegaCrit.Sts2.Core.Models.EventModel <localEvent>5__3
private System.Boolean <preloadsAfterCombatState>5__2
public System.Boolean isRestoringRoomStackBase
public MegaCrit.Sts2.Core.Runs.IRunState runState
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Rooms.EventRoom+<Exit>d__19

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Rooms.EventRoom <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Rooms.ICombatRoomVisuals

类型属性：`Public, ClassSemanticsMask, Abstract, BeforeFieldInit`；基类：`无`。

接口：

```text
MegaCrit.Sts2.Core.Models.ActModel Act { public abstract get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature> Allies { public abstract get; }
MegaCrit.Sts2.Core.Models.EncounterModel Encounter { public abstract get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature> Enemies { public abstract get; }
public abstract MegaCrit.Sts2.Core.Models.ActModel get_Act()
public abstract MegaCrit.Sts2.Core.Models.EncounterModel get_Encounter()
public abstract System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature> get_Allies()
public abstract System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature> get_Enemies()
```

## MegaCrit.Sts2.Core.Rooms.MapRoom

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Rooms.AbstractRoom`。

接口：

```text
MegaCrit.Sts2.Core.Models.ModelId ModelId { public virtual get; }
MegaCrit.Sts2.Core.Rooms.RoomType RoomType { public virtual get; }
public .ctor()
public virtual MegaCrit.Sts2.Core.Models.ModelId get_ModelId()
public virtual MegaCrit.Sts2.Core.Rooms.RoomType get_RoomType()
public virtual System.Threading.Tasks.Task EnterInternal(MegaCrit.Sts2.Core.Runs.IRunState runState, System.Boolean isRestoringRoomStackBase)
public virtual System.Threading.Tasks.Task Exit(MegaCrit.Sts2.Core.Runs.IRunState runState)
public virtual System.Threading.Tasks.Task Resume(MegaCrit.Sts2.Core.Rooms.AbstractRoom _, MegaCrit.Sts2.Core.Runs.IRunState runState)
```

## MegaCrit.Sts2.Core.Rooms.MerchantRoom

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Rooms.AbstractRoom`。

接口：

```text
private static MegaCrit.Sts2.Core.Entities.Merchant.MerchantDialogueSet _dialogue
private MegaCrit.Sts2.Core.Runs.IRunState _runState
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Merchant.MerchantInventory> <Inventories>k__BackingField
MegaCrit.Sts2.Core.Entities.Merchant.MerchantDialogueSet Dialogue { public static get; }
System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Merchant.MerchantInventory> Inventories { public get; private set; }
MegaCrit.Sts2.Core.Models.ModelId ModelId { public virtual get; }
MegaCrit.Sts2.Core.Rooms.RoomType RoomType { public virtual get; }
public .ctor()
private System.Void set_Inventories(System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Merchant.MerchantInventory> value)
public MegaCrit.Sts2.Core.Entities.Merchant.MerchantInventory GetLocalInventory()
public static MegaCrit.Sts2.Core.Entities.Merchant.MerchantDialogueSet get_Dialogue()
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Merchant.MerchantInventory> get_Inventories()
public virtual [async] System.Threading.Tasks.Task EnterInternal(MegaCrit.Sts2.Core.Runs.IRunState runState, System.Boolean isRestoringRoomStackBase)
public virtual MegaCrit.Sts2.Core.Models.ModelId get_ModelId()
public virtual MegaCrit.Sts2.Core.Rooms.RoomType get_RoomType()
public virtual System.Threading.Tasks.Task Exit(MegaCrit.Sts2.Core.Runs.IRunState runState)
public virtual System.Threading.Tasks.Task Resume(MegaCrit.Sts2.Core.Rooms.AbstractRoom _, MegaCrit.Sts2.Core.Runs.IRunState runState)
```

## MegaCrit.Sts2.Core.Rooms.MerchantRoom+<EnterInternal>d__13

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Rooms.MerchantRoom <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public System.Boolean isRestoringRoomStackBase
public MegaCrit.Sts2.Core.Runs.IRunState runState
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Rooms.RestSiteRoom

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Rooms.AbstractRoom`。

接口：

```text
private MegaCrit.Sts2.Core.Multiplayer.Game.RestSiteSynchronizer _synchronizer
MegaCrit.Sts2.Core.Models.ModelId ModelId { public virtual get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption> Options { public get; }
MegaCrit.Sts2.Core.Rooms.RoomType RoomType { public virtual get; }
public .ctor()
private System.Void ShowRoomNode(MegaCrit.Sts2.Core.Runs.IRunState runState)
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption> get_Options()
public virtual [async] System.Threading.Tasks.Task EnterInternal(MegaCrit.Sts2.Core.Runs.IRunState runState, System.Boolean isRestoringRoomStackBase)
public virtual [async] System.Threading.Tasks.Task Exit(MegaCrit.Sts2.Core.Runs.IRunState runState)
public virtual MegaCrit.Sts2.Core.Models.ModelId get_ModelId()
public virtual MegaCrit.Sts2.Core.Rooms.RoomType get_RoomType()
public virtual System.Threading.Tasks.Task Resume(MegaCrit.Sts2.Core.Rooms.AbstractRoom _, MegaCrit.Sts2.Core.Runs.IRunState runState)
```

## MegaCrit.Sts2.Core.Rooms.RestSiteRoom+<EnterInternal>d__7

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Rooms.RestSiteRoom <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public System.Boolean isRestoringRoomStackBase
public MegaCrit.Sts2.Core.Runs.IRunState runState
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Rooms.RestSiteRoom+<Exit>d__8

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Rooms.RoomSet

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private MegaCrit.Sts2.Core.Models.AncientEventModel _ancient
private MegaCrit.Sts2.Core.Models.EncounterModel _boss
private MegaCrit.Sts2.Core.Models.EncounterModel <SecondBoss>k__BackingField
public System.Int32 bossEncountersVisited
public readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.EncounterModel> eliteEncounters
public System.Int32 eliteEncountersVisited
public readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.EventModel> events
public System.Int32 eventsVisited
public readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.EncounterModel> normalEncounters
public System.Int32 normalEncountersVisited
MegaCrit.Sts2.Core.Models.AncientEventModel Ancient { public get; public set; }
MegaCrit.Sts2.Core.Models.EncounterModel Boss { public get; public set; }
System.Boolean HasAncient { public get; }
System.Boolean HasSecondBoss { public get; }
MegaCrit.Sts2.Core.Models.EncounterModel NextBossEncounter { public get; }
MegaCrit.Sts2.Core.Models.EncounterModel NextEliteEncounter { public get; }
MegaCrit.Sts2.Core.Models.EventModel NextEvent { public get; }
MegaCrit.Sts2.Core.Models.EncounterModel NextNormalEncounter { public get; }
MegaCrit.Sts2.Core.Models.EncounterModel SecondBoss { public get; public set; }
public .ctor()
public MegaCrit.Sts2.Core.Models.AncientEventModel get_Ancient()
public MegaCrit.Sts2.Core.Models.EncounterModel get_Boss()
public MegaCrit.Sts2.Core.Models.EncounterModel get_NextBossEncounter()
public MegaCrit.Sts2.Core.Models.EncounterModel get_NextEliteEncounter()
public MegaCrit.Sts2.Core.Models.EncounterModel get_NextNormalEncounter()
public MegaCrit.Sts2.Core.Models.EncounterModel get_SecondBoss()
public MegaCrit.Sts2.Core.Models.EventModel get_NextEvent()
public MegaCrit.Sts2.Core.Saves.Runs.SerializableRoomSet ToSave()
public static MegaCrit.Sts2.Core.Rooms.RoomSet FromSave(MegaCrit.Sts2.Core.Saves.Runs.SerializableRoomSet save)
public static System.Void SwapToOrCreateAtIndex<TBaseModel, TSpecificModel>(System.Collections.Generic.List<TBaseModel> list, System.Int32 desiredIndex) where TBaseModel: [None] MegaCrit.Sts2.Core.Models.AbstractModel where TSpecificModel: [None] TBaseModel
public System.Boolean get_HasAncient()
public System.Boolean get_HasSecondBoss()
public System.Void EnsureNextEventIsValid(MegaCrit.Sts2.Core.Runs.RunState runState)
public System.Void MarkVisited(MegaCrit.Sts2.Core.Rooms.RoomType roomType)
public System.Void set_Ancient(MegaCrit.Sts2.Core.Models.AncientEventModel value)
public System.Void set_Boss(MegaCrit.Sts2.Core.Models.EncounterModel value)
public System.Void set_SecondBoss(MegaCrit.Sts2.Core.Models.EncounterModel value)
```

## MegaCrit.Sts2.Core.Rooms.RoomSet+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Rooms.RoomSet+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Models.EventModel, MegaCrit.Sts2.Core.Models.ModelId> <>9__33_0
public static System.Func<MegaCrit.Sts2.Core.Models.EncounterModel, MegaCrit.Sts2.Core.Models.ModelId> <>9__33_1
public static System.Func<MegaCrit.Sts2.Core.Models.EncounterModel, MegaCrit.Sts2.Core.Models.ModelId> <>9__33_2
public static System.Func<MegaCrit.Sts2.Core.Models.EventModel, System.Boolean> <>9__34_0
public static System.Func<MegaCrit.Sts2.Core.Models.EncounterModel, System.Boolean> <>9__34_1
public static System.Func<MegaCrit.Sts2.Core.Models.EncounterModel, System.Boolean> <>9__34_2
private static .cctor()
public .ctor()
internal MegaCrit.Sts2.Core.Models.ModelId <ToSave>b__33_0(MegaCrit.Sts2.Core.Models.EventModel e)
internal MegaCrit.Sts2.Core.Models.ModelId <ToSave>b__33_1(MegaCrit.Sts2.Core.Models.EncounterModel e)
internal MegaCrit.Sts2.Core.Models.ModelId <ToSave>b__33_2(MegaCrit.Sts2.Core.Models.EncounterModel e)
internal System.Boolean <FromSave>b__34_0(MegaCrit.Sts2.Core.Models.EventModel e)
internal System.Boolean <FromSave>b__34_1(MegaCrit.Sts2.Core.Models.EncounterModel e)
internal System.Boolean <FromSave>b__34_2(MegaCrit.Sts2.Core.Models.EncounterModel e)
```

## MegaCrit.Sts2.Core.Rooms.RoomSet+<>c__35<TBaseModel, TSpecificModel>

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Rooms.RoomSet+<>c__35<TBaseModel, TSpecificModel> <>9
public static System.Predicate<TBaseModel> <>9__35_0
private static .cctor()
public .ctor()
internal System.Boolean <SwapToOrCreateAtIndex>b__35_0(TBaseModel elem)
```

## MegaCrit.Sts2.Core.Rooms.RoomSet+<>O

类型属性：`NestedPrivate, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static System.Func<MegaCrit.Sts2.Core.Models.ModelId, MegaCrit.Sts2.Core.Models.EventModel> <0>__EventOrDeprecated
public static System.Func<MegaCrit.Sts2.Core.Models.ModelId, MegaCrit.Sts2.Core.Models.EncounterModel> <1>__EncounterOrDeprecated
```

## MegaCrit.Sts2.Core.Rooms.RoomType

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Rooms.RoomType Boss = 3
public static const MegaCrit.Sts2.Core.Rooms.RoomType Elite = 2
public static const MegaCrit.Sts2.Core.Rooms.RoomType Event = 6
public static const MegaCrit.Sts2.Core.Rooms.RoomType Map = 8
public static const MegaCrit.Sts2.Core.Rooms.RoomType Monster = 1
public static const MegaCrit.Sts2.Core.Rooms.RoomType RestSite = 7
public static const MegaCrit.Sts2.Core.Rooms.RoomType Shop = 5
public static const MegaCrit.Sts2.Core.Rooms.RoomType Treasure = 4
public static const MegaCrit.Sts2.Core.Rooms.RoomType Unassigned = 0
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Rooms.RoomTypeExtensions

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static System.Boolean IsCombatRoom(MegaCrit.Sts2.Core.Rooms.RoomType room)
```

## MegaCrit.Sts2.Core.Rooms.TreasureRoom

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Rooms.AbstractRoom`。

接口：

```text
private MegaCrit.Sts2.Core.Runs.IRunState _runState
MegaCrit.Sts2.Core.Models.ModelId ModelId { public virtual get; }
MegaCrit.Sts2.Core.Rooms.RoomType RoomType { public virtual get; }
public .ctor(System.Int32 actIndex)
public [async] System.Threading.Tasks.Task DoExtraRewardsIfNeeded()
public System.Threading.Tasks.Task<System.Int32> DoNormalRewards()
public virtual [async] System.Threading.Tasks.Task EnterInternal(MegaCrit.Sts2.Core.Runs.IRunState runState, System.Boolean isRestoringRoomStackBase)
public virtual MegaCrit.Sts2.Core.Models.ModelId get_ModelId()
public virtual MegaCrit.Sts2.Core.Rooms.RoomType get_RoomType()
public virtual System.Threading.Tasks.Task Exit(MegaCrit.Sts2.Core.Runs.IRunState runState)
public virtual System.Threading.Tasks.Task Resume(MegaCrit.Sts2.Core.Rooms.AbstractRoom _, MegaCrit.Sts2.Core.Runs.IRunState runState)
```

## MegaCrit.Sts2.Core.Rooms.TreasureRoom+<DoExtraRewardsIfNeeded>d__10

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Rooms.TreasureRoom <>4__this
private System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Entities.Players.Player> <>7__wrap3
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Rewards.RewardsSet> <>7__wrap4
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Rewards.RewardsSet> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
private System.Threading.Tasks.Task <localTask>5__2
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Rewards.RewardsSet> <rewards>5__3
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Rooms.TreasureRoom+<EnterInternal>d__6

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Rooms.TreasureRoom <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public System.Boolean isRestoringRoomStackBase
public MegaCrit.Sts2.Core.Runs.IRunState runState
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```
