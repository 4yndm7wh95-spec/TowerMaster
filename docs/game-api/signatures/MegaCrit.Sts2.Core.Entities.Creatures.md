# MegaCrit.Sts2.Core.Entities.Creatures

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Entities.Creatures.Creature

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private System.Int32 _block
private System.Int32 _currentHp
private System.Int32 _maxHp
private MegaCrit.Sts2.Core.Entities.Players.Player _petOwner
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.PowerModel> _powers
private System.Nullable<System.UInt32> <CombatId>k__BackingField
private MegaCrit.Sts2.Core.Combat.ICombatState <CombatState>k__BackingField
private MegaCrit.Sts2.Core.Entities.Creatures.HpDisplay <HpDisplay>k__BackingField
private readonly MegaCrit.Sts2.Core.Models.MonsterModel <Monster>k__BackingField
private System.Nullable<System.Int32> <MonsterMaxHpBeforeModification>k__BackingField
private readonly MegaCrit.Sts2.Core.Entities.Players.Player <Player>k__BackingField
private readonly MegaCrit.Sts2.Core.Combat.CombatSide <Side>k__BackingField
private System.String <SlotName>k__BackingField
private System.Action<System.Int32, System.Int32> BlockChanged
private System.Action<System.Int32, System.Int32> CurrentHpChanged
private System.Action<MegaCrit.Sts2.Core.Entities.Creatures.Creature> Died
private System.Action<System.Int32, System.Int32> MaxHpChanged
private System.Action<MegaCrit.Sts2.Core.Models.PowerModel> PowerApplied
private System.Action<MegaCrit.Sts2.Core.Models.PowerModel, System.Boolean> PowerDecreased
private System.Action<MegaCrit.Sts2.Core.Models.PowerModel, System.Int32, System.Boolean> PowerIncreased
private System.Action<MegaCrit.Sts2.Core.Models.PowerModel> PowerRemoved
private System.Action<MegaCrit.Sts2.Core.Entities.Creatures.Creature> Revived
System.Int32 Block { public get; private set; }
System.Boolean CanReceivePowers { public get; }
System.Nullable<System.UInt32> CombatId { public get; public set; }
MegaCrit.Sts2.Core.Combat.ICombatState CombatState { public get; public set; }
System.Int32 CurrentHp { public get; private set; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.HoverTips.IHoverTip> HoverTips { public get; }
MegaCrit.Sts2.Core.Entities.Creatures.HpDisplay HpDisplay { public get; public set; }
System.Boolean IsAlive { public get; }
System.Boolean IsDead { public get; }
System.Boolean IsEnemy { public get; }
System.Boolean IsHittable { public get; }
System.Boolean IsMonster { public get; }
System.Boolean IsPet { public get; }
System.Boolean IsPlayer { public get; }
System.Boolean IsPrimaryEnemy { public get; }
System.Boolean IsSecondaryEnemy { public get; }
System.Boolean IsStunned { public get; }
System.String LogName { public get; }
System.Int32 MaxHp { public get; private set; }
MegaCrit.Sts2.Core.Models.ModelId ModelId { public get; }
MegaCrit.Sts2.Core.Models.MonsterModel Monster { public get; }
System.Nullable<System.Int32> MonsterMaxHpBeforeModification { public get; private set; }
System.String Name { public get; }
MegaCrit.Sts2.Core.Entities.Players.Player PetOwner { public get; public set; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> Pets { public get; }
MegaCrit.Sts2.Core.Entities.Players.Player Player { public get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.PowerModel> Powers { public get; }
MegaCrit.Sts2.Core.Combat.CombatSide Side { public get; }
System.String SlotName { public get; public set; }
event System.Action<System.Int32, System.Int32> BlockChanged
event System.Action<System.Int32, System.Int32> CurrentHpChanged
event System.Action<MegaCrit.Sts2.Core.Entities.Creatures.Creature> Died
event System.Action<System.Int32, System.Int32> MaxHpChanged
event System.Action<MegaCrit.Sts2.Core.Models.PowerModel> PowerApplied
event System.Action<MegaCrit.Sts2.Core.Models.PowerModel, System.Boolean> PowerDecreased
event System.Action<MegaCrit.Sts2.Core.Models.PowerModel, System.Int32, System.Boolean> PowerIncreased
event System.Action<MegaCrit.Sts2.Core.Models.PowerModel> PowerRemoved
event System.Action<MegaCrit.Sts2.Core.Entities.Creatures.Creature> Revived
public .ctor(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Int32 currentHp, System.Int32 maxHp)
public .ctor(MegaCrit.Sts2.Core.Models.MonsterModel monster, MegaCrit.Sts2.Core.Combat.CombatSide side, System.String slotName)
private [async] System.Threading.Tasks.Task ClearBlock()
private System.Void set_Block(System.Int32 value)
private System.Void set_CurrentHp(System.Int32 value)
private System.Void set_MaxHp(System.Int32 value)
private System.Void set_MonsterMaxHpBeforeModification(System.Nullable<System.Int32> value)
public [async] System.Threading.Tasks.Task AfterAddedToRoom()
public [async] System.Threading.Tasks.Task AfterTurnStart(MegaCrit.Sts2.Core.Combat.CombatSide side)
public [async] System.Threading.Tasks.Task TakeTurn()
public Godot.Control GetBackVfxContainer()
public Godot.Control GetVfxContainer()
public MegaCrit.Sts2.Core.Combat.CombatSide get_Side()
public MegaCrit.Sts2.Core.Combat.ICombatState get_CombatState()
public MegaCrit.Sts2.Core.Entities.Creatures.DamageResult LoseHpInternal(System.Decimal amount, MegaCrit.Sts2.Core.ValueProps.ValueProp props)
public MegaCrit.Sts2.Core.Entities.Creatures.HpDisplay get_HpDisplay()
public MegaCrit.Sts2.Core.Entities.Players.Player get_PetOwner()
public MegaCrit.Sts2.Core.Entities.Players.Player get_Player()
public MegaCrit.Sts2.Core.Models.ModelId get_ModelId()
public MegaCrit.Sts2.Core.Models.MonsterModel get_Monster()
public MegaCrit.Sts2.Core.Models.PowerModel GetPower(MegaCrit.Sts2.Core.Models.ModelId id)
public MegaCrit.Sts2.Core.Models.PowerModel GetPowerById(MegaCrit.Sts2.Core.Models.ModelId id)
public MegaCrit.Sts2.Core.Nodes.Combat.NCreature GetCreatureNode()
public MegaCrit.Sts2.Core.Nodes.Combat.NCreatureVisuals CreateVisuals()
public static System.Decimal ScaleHpForMultiplayer(System.Decimal hp, MegaCrit.Sts2.Core.Models.EncounterModel encounter, System.Int32 playerCount, System.Int32 actIndex)
public System.Boolean get_CanReceivePowers()
public System.Boolean get_IsAlive()
public System.Boolean get_IsDead()
public System.Boolean get_IsEnemy()
public System.Boolean get_IsHittable()
public System.Boolean get_IsMonster()
public System.Boolean get_IsPet()
public System.Boolean get_IsPlayer()
public System.Boolean get_IsPrimaryEnemy()
public System.Boolean get_IsSecondaryEnemy()
public System.Boolean get_IsStunned()
public System.Boolean HasPower(MegaCrit.Sts2.Core.Models.ModelId id)
public System.Boolean HasPower<T>() where T: [None] MegaCrit.Sts2.Core.Models.PowerModel
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.HoverTips.IHoverTip> get_HoverTips()
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.PowerModel> GetPowerInstances(MegaCrit.Sts2.Core.Models.ModelId id)
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.PowerModel> RemoveAllPowersAfterDeath()
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.PowerModel> RemoveAllPowersInternalExcept(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.PowerModel> except = null)
public System.Collections.Generic.IEnumerable<T> GetPowerInstances<T>() where T: [None] MegaCrit.Sts2.Core.Models.PowerModel
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> get_Pets()
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.PowerModel> get_Powers()
public System.Decimal DamageBlockInternal(System.Decimal amount, MegaCrit.Sts2.Core.ValueProps.ValueProp props)
public System.Double GetHpPercentRemaining()
public System.Int32 get_Block()
public System.Int32 get_CurrentHp()
public System.Int32 get_MaxHp()
public System.Int32 GetPowerAmount<T>() where T: [None] MegaCrit.Sts2.Core.Models.PowerModel
public System.Nullable<System.Int32> get_MonsterMaxHpBeforeModification()
public System.Nullable<System.UInt32> get_CombatId()
public System.String get_LogName()
public System.String get_Name()
public System.String get_SlotName()
public System.Void add_BlockChanged(System.Action<System.Int32, System.Int32> value)
public System.Void add_CurrentHpChanged(System.Action<System.Int32, System.Int32> value)
public System.Void add_Died(System.Action<MegaCrit.Sts2.Core.Entities.Creatures.Creature> value)
public System.Void add_MaxHpChanged(System.Action<System.Int32, System.Int32> value)
public System.Void add_PowerApplied(System.Action<MegaCrit.Sts2.Core.Models.PowerModel> value)
public System.Void add_PowerDecreased(System.Action<MegaCrit.Sts2.Core.Models.PowerModel, System.Boolean> value)
public System.Void add_PowerIncreased(System.Action<MegaCrit.Sts2.Core.Models.PowerModel, System.Int32, System.Boolean> value)
public System.Void add_PowerRemoved(System.Action<MegaCrit.Sts2.Core.Models.PowerModel> value)
public System.Void add_Revived(System.Action<MegaCrit.Sts2.Core.Entities.Creatures.Creature> value)
public System.Void ApplyPowerInternal(MegaCrit.Sts2.Core.Models.PowerModel power)
public System.Void BeforeTurnStart(MegaCrit.Sts2.Core.Combat.CombatSide side)
public System.Void GainBlockInternal(System.Decimal amount)
public System.Void HealInternal(System.Decimal amount)
public System.Void InvokeDiedEvent()
public System.Void InvokePowerModified(MegaCrit.Sts2.Core.Models.PowerModel power, System.Int32 change, System.Boolean silent)
public System.Void LoseBlockInternal(System.Decimal amount)
public System.Void OnSideSwitch()
public System.Void PrepareForNextTurn(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature> targets, System.Boolean rollNewMove = True)
public System.Void remove_BlockChanged(System.Action<System.Int32, System.Int32> value)
public System.Void remove_CurrentHpChanged(System.Action<System.Int32, System.Int32> value)
public System.Void remove_Died(System.Action<MegaCrit.Sts2.Core.Entities.Creatures.Creature> value)
public System.Void remove_MaxHpChanged(System.Action<System.Int32, System.Int32> value)
public System.Void remove_PowerApplied(System.Action<MegaCrit.Sts2.Core.Models.PowerModel> value)
public System.Void remove_PowerDecreased(System.Action<MegaCrit.Sts2.Core.Models.PowerModel, System.Boolean> value)
public System.Void remove_PowerIncreased(System.Action<MegaCrit.Sts2.Core.Models.PowerModel, System.Int32, System.Boolean> value)
public System.Void remove_PowerRemoved(System.Action<MegaCrit.Sts2.Core.Models.PowerModel> value)
public System.Void remove_Revived(System.Action<MegaCrit.Sts2.Core.Entities.Creatures.Creature> value)
public System.Void RemovePowerInternal(MegaCrit.Sts2.Core.Models.PowerModel power)
public System.Void Reset()
public System.Void ScaleMonsterHpForMultiplayer(MegaCrit.Sts2.Core.Models.EncounterModel encounter, System.Int32 playerCount, System.Int32 actIndex)
public System.Void set_CombatId(System.Nullable<System.UInt32> value)
public System.Void set_CombatState(MegaCrit.Sts2.Core.Combat.ICombatState value)
public System.Void set_HpDisplay(MegaCrit.Sts2.Core.Entities.Creatures.HpDisplay value)
public System.Void set_PetOwner(MegaCrit.Sts2.Core.Entities.Players.Player value)
public System.Void set_SlotName(System.String value)
public System.Void SetCurrentHpInternal(System.Decimal amount)
public System.Void SetMaxHpInternal(System.Decimal amount)
public System.Void SetNodeVisible(System.Boolean visible)
public System.Void SetUniqueMonsterHpValue(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> creaturesOnSide, MegaCrit.Sts2.Core.Random.Rng rng)
public System.Void StunInternal(System.Func<System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature>, System.Threading.Tasks.Task> stunMove, System.String nextMoveId)
public T GetPower<T>() where T: [None] MegaCrit.Sts2.Core.Models.PowerModel
public virtual System.String ToString()
```

## MegaCrit.Sts2.Core.Entities.Creatures.Creature+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Entities.Creatures.Creature+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Entities.Creatures.Creature, System.Int32> <>9__107_0
public static System.Func<MegaCrit.Sts2.Core.Models.PowerModel, System.Boolean> <>9__136_0
public static System.Func<MegaCrit.Sts2.Core.Models.PowerModel, System.Boolean> <>9__98_0
private static .cctor()
public .ctor()
internal System.Boolean <get_IsSecondaryEnemy>b__98_0(MegaCrit.Sts2.Core.Models.PowerModel p)
internal System.Boolean <RemoveAllPowersAfterDeath>b__136_0(MegaCrit.Sts2.Core.Models.PowerModel p)
internal System.Int32 <SetUniqueMonsterHpValue>b__107_0(MegaCrit.Sts2.Core.Entities.Creatures.Creature e)
```

## MegaCrit.Sts2.Core.Entities.Creatures.Creature+<>c__124<T>

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Entities.Creatures.Creature+<>c__124<T> <>9
public static System.Func<MegaCrit.Sts2.Core.Models.PowerModel, System.Boolean> <>9__124_0
private static .cctor()
public .ctor()
internal System.Boolean <HasPower>b__124_0(MegaCrit.Sts2.Core.Models.PowerModel p)
```

## MegaCrit.Sts2.Core.Entities.Creatures.Creature+<>c__126<T>

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Entities.Creatures.Creature+<>c__126<T> <>9
public static System.Func<MegaCrit.Sts2.Core.Models.PowerModel, System.Boolean> <>9__126_0
private static .cctor()
public .ctor()
internal System.Boolean <GetPower>b__126_0(MegaCrit.Sts2.Core.Models.PowerModel p)
```

## MegaCrit.Sts2.Core.Entities.Creatures.Creature+<>c__DisplayClass125_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Models.ModelId id
public .ctor()
internal System.Boolean <HasPower>b__0(MegaCrit.Sts2.Core.Models.PowerModel p)
```

## MegaCrit.Sts2.Core.Entities.Creatures.Creature+<>c__DisplayClass127_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Models.ModelId id
public .ctor()
internal System.Boolean <GetPower>b__0(MegaCrit.Sts2.Core.Models.PowerModel p)
```

## MegaCrit.Sts2.Core.Entities.Creatures.Creature+<>c__DisplayClass129_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Models.ModelId id
public .ctor()
internal System.Boolean <GetPowerInstances>b__0(MegaCrit.Sts2.Core.Models.PowerModel p)
```

## MegaCrit.Sts2.Core.Entities.Creatures.Creature+<>c__DisplayClass130_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Models.ModelId id
public .ctor()
internal System.Boolean <GetPowerById>b__0(MegaCrit.Sts2.Core.Models.PowerModel p)
```

## MegaCrit.Sts2.Core.Entities.Creatures.Creature+<>c__DisplayClass132_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Models.PowerModel power
public .ctor()
internal System.Boolean <ApplyPowerInternal>b__0(MegaCrit.Sts2.Core.Models.PowerModel p)
```

## MegaCrit.Sts2.Core.Entities.Creatures.Creature+<AfterAddedToRoom>d__110

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Entities.Creatures.Creature <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Entities.Creatures.Creature+<AfterTurnStart>d__138

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Entities.Creatures.Creature <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.Combat.CombatSide side
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Entities.Creatures.Creature+<ClearBlock>d__141

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Entities.Creatures.Creature <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Entities.Creatures.Creature+<TakeTurn>d__140

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Entities.Creatures.Creature <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Entities.Creatures.DamageResult

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private System.Int32 <BlockedDamage>k__BackingField
private readonly System.Int32 <OverkillDamage>k__BackingField
private readonly MegaCrit.Sts2.Core.ValueProps.ValueProp <Props>k__BackingField
private readonly MegaCrit.Sts2.Core.Entities.Creatures.Creature <Receiver>k__BackingField
private readonly System.Int32 <UnblockedDamage>k__BackingField
private System.Boolean <WasBlockBroken>k__BackingField
private System.Boolean <WasFullyBlocked>k__BackingField
private readonly System.Boolean <WasTargetKilled>k__BackingField
System.Int32 BlockedDamage { public get; public set; }
System.Int32 OverkillDamage { public get; public set; }
MegaCrit.Sts2.Core.ValueProps.ValueProp Props { public get; }
MegaCrit.Sts2.Core.Entities.Creatures.Creature Receiver { public get; }
System.Int32 TotalDamage { public get; }
System.Int32 UnblockedDamage { public get; public set; }
System.Boolean WasBlockBroken { public get; public set; }
System.Boolean WasFullyBlocked { public get; public set; }
System.Boolean WasTargetKilled { public get; public set; }
public .ctor(MegaCrit.Sts2.Core.Entities.Creatures.Creature receiver, MegaCrit.Sts2.Core.ValueProps.ValueProp props)
public MegaCrit.Sts2.Core.Entities.Creatures.Creature get_Receiver()
public MegaCrit.Sts2.Core.ValueProps.ValueProp get_Props()
public System.Boolean get_WasBlockBroken()
public System.Boolean get_WasFullyBlocked()
public System.Boolean get_WasTargetKilled()
public System.Int32 get_BlockedDamage()
public System.Int32 get_OverkillDamage()
public System.Int32 get_TotalDamage()
public System.Int32 get_UnblockedDamage()
public System.Void set_BlockedDamage(System.Int32 value)
public System.Void set_OverkillDamage(System.Int32 value)
public System.Void set_UnblockedDamage(System.Int32 value)
public System.Void set_WasBlockBroken(System.Boolean value)
public System.Void set_WasFullyBlocked(System.Boolean value)
public System.Void set_WasTargetKilled(System.Boolean value)
```

## MegaCrit.Sts2.Core.Entities.Creatures.HpDisplay

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Entities.Creatures.HpDisplay InfiniteWithNumbers = 1
public static const MegaCrit.Sts2.Core.Entities.Creatures.HpDisplay InfiniteWithoutNumbers = 2
public static const MegaCrit.Sts2.Core.Entities.Creatures.HpDisplay Normal = 0
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Entities.Creatures.HpDisplayExtensions

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static System.Boolean IsInfinite(MegaCrit.Sts2.Core.Entities.Creatures.HpDisplay display)
public static System.Boolean ShowsNumbers(MegaCrit.Sts2.Core.Entities.Creatures.HpDisplay display)
```

## MegaCrit.Sts2.Core.Entities.Creatures.SummonResult

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private readonly System.Decimal <Amount>k__BackingField
private readonly MegaCrit.Sts2.Core.Entities.Creatures.Creature <Creature>k__BackingField
System.Decimal Amount { public get; public set; }
MegaCrit.Sts2.Core.Entities.Creatures.Creature Creature { public get; public set; }
public .ctor(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature, System.Decimal amount)
public MegaCrit.Sts2.Core.Entities.Creatures.Creature get_Creature()
public System.Decimal get_Amount()
public System.Void set_Amount(System.Decimal value)
public System.Void set_Creature(MegaCrit.Sts2.Core.Entities.Creatures.Creature value)
```
