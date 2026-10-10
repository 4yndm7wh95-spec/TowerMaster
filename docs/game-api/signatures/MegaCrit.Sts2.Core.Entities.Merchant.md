# MegaCrit.Sts2.Core.Entities.Merchant

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Entities.Merchant.MerchantCardEntry

类型属性：`Public, Sealed, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Entities.Merchant.MerchantEntry`。

接口：

```text
private readonly System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> _cardPool
private readonly System.Nullable<MegaCrit.Sts2.Core.Entities.Cards.CardRarity> _cardRarity
private readonly System.Nullable<MegaCrit.Sts2.Core.Entities.Cards.CardType> _cardType
private readonly MegaCrit.Sts2.Core.Entities.Merchant.MerchantInventory _inventory
private MegaCrit.Sts2.Core.Entities.Cards.CardCreationResult <CreationResult>k__BackingField
private System.Boolean <IsOnSale>k__BackingField
MegaCrit.Sts2.Core.Entities.Cards.CardCreationResult CreationResult { public get; private set; }
System.Boolean IsOnSale { public get; private set; }
System.Boolean IsStocked { public virtual get; }
public .ctor(MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.Entities.Merchant.MerchantInventory inventory, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> cardPool, MegaCrit.Sts2.Core.Entities.Cards.CardRarity cardRarity)
public .ctor(MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.Entities.Merchant.MerchantInventory inventory, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> cardPool, MegaCrit.Sts2.Core.Entities.Cards.CardType cardType)
private static System.Int32 GetCost(MegaCrit.Sts2.Core.Models.CardModel card)
private System.Void set_CreationResult(MegaCrit.Sts2.Core.Entities.Cards.CardCreationResult value)
private System.Void set_IsOnSale(System.Boolean value)
protected virtual [async] System.Threading.Tasks.Task<System.ValueTuple<System.Boolean, System.Int32>> OnTryPurchase(MegaCrit.Sts2.Core.Entities.Merchant.MerchantInventory inventory, System.Boolean ignoreCost)
protected virtual System.Void ClearAfterPurchase()
protected virtual System.Void RestockAfterPurchase(MegaCrit.Sts2.Core.Entities.Merchant.MerchantInventory inventory)
protected virtual System.Void UpdateEntry()
public MegaCrit.Sts2.Core.Entities.Cards.CardCreationResult get_CreationResult()
public System.Boolean get_IsOnSale()
public System.Void Populate()
public System.Void SetOnSale()
public virtual System.Boolean get_IsStocked()
public virtual System.Void CalcCost()
```

## MegaCrit.Sts2.Core.Entities.Merchant.MerchantCardEntry+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Entities.Merchant.MerchantCardEntry+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Entities.Merchant.MerchantCardEntry, MegaCrit.Sts2.Core.Models.CardModel> <>9__15_0
private static .cctor()
public .ctor()
internal MegaCrit.Sts2.Core.Models.CardModel <Populate>b__15_0(MegaCrit.Sts2.Core.Entities.Merchant.MerchantCardEntry e)
```

## MegaCrit.Sts2.Core.Entities.Merchant.MerchantCardEntry+<OnTryPurchase>d__21

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Entities.Merchant.MerchantCardEntry <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.ValueTuple<System.Boolean, System.Int32>> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
public System.Boolean ignoreCost
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Entities.Merchant.MerchantCardRemovalEntry

类型属性：`Public, Sealed, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Entities.Merchant.MerchantEntry`。

接口：

```text
private System.Boolean <Used>k__BackingField
System.Int32 BaseCost { private static get; }
System.Boolean IsStocked { public virtual get; }
System.Int32 PriceIncrease { public static get; }
System.Boolean Used { public get; private set; }
public .ctor(MegaCrit.Sts2.Core.Entities.Players.Player player)
private [async] System.Threading.Tasks.Task<System.ValueTuple<System.Boolean, System.Int32>> OnTryPurchase(MegaCrit.Sts2.Core.Entities.Merchant.MerchantInventory inventory, System.Boolean ignoreCost, System.Boolean cancelable)
private static System.Int32 get_BaseCost()
private System.Void set_Used(System.Boolean value)
protected virtual [async] System.Threading.Tasks.Task<System.ValueTuple<System.Boolean, System.Int32>> OnTryPurchase(MegaCrit.Sts2.Core.Entities.Merchant.MerchantInventory inventory, System.Boolean ignoreCost)
protected virtual System.Void ClearAfterPurchase()
protected virtual System.Void RestockAfterPurchase(MegaCrit.Sts2.Core.Entities.Merchant.MerchantInventory inventory)
public [async] System.Threading.Tasks.Task<System.Boolean> OnTryPurchaseWrapper(MegaCrit.Sts2.Core.Entities.Merchant.MerchantInventory inventory, System.Boolean ignoreCost = False, System.Boolean cancelable = True)
public static System.Int32 get_PriceIncrease()
public System.Boolean get_Used()
public System.Void SetUsed()
public virtual System.Boolean get_IsStocked()
public virtual System.Void CalcCost()
```

## MegaCrit.Sts2.Core.Entities.Merchant.MerchantCardRemovalEntry+<OnTryPurchase>d__13

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Entities.Merchant.MerchantCardRemovalEntry <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.ValueTuple<System.Boolean, System.Int32>> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.ValueTuple<System.Boolean, System.Int32>> <>u__1
public System.Boolean ignoreCost
public MegaCrit.Sts2.Core.Entities.Merchant.MerchantInventory inventory
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Entities.Merchant.MerchantCardRemovalEntry+<OnTryPurchase>d__14

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Entities.Merchant.MerchantCardRemovalEntry <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.ValueTuple<System.Boolean, System.Int32>> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private System.Int32 <goldToSpend>5__2
public System.Boolean cancelable
public System.Boolean ignoreCost
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Entities.Merchant.MerchantCardRemovalEntry+<OnTryPurchaseWrapper>d__12

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Entities.Merchant.MerchantCardRemovalEntry <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Boolean> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.ValueTuple<System.Boolean, System.Int32>> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
private System.Boolean <success>5__2
public System.Boolean cancelable
public System.Boolean ignoreCost
public MegaCrit.Sts2.Core.Entities.Merchant.MerchantInventory inventory
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Entities.Merchant.MerchantDialogueSet

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Localization.LocString> _foulPotionLines
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Localization.LocString> _openInventoryLines
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Localization.LocString> _playerDeadLines
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Localization.LocString> _purchaseFailureForbiddenLines
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Localization.LocString> _purchaseFailureGoldLines
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Localization.LocString> _purchaseFailureSpaceLines
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Localization.LocString> _purchaseSuccessLines
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Localization.LocString> _welcomeLines
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Localization.LocString> FoulPotionLines { public get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Localization.LocString> OpenInventoryLines { public get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Localization.LocString> PlayerDeadLines { public get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Localization.LocString> WelcomeLines { public get; }
public .ctor()
public static MegaCrit.Sts2.Core.Entities.Merchant.MerchantDialogueSet CreateFromLocStrings(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Localization.LocString> locStrings)
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Localization.LocString> get_FoulPotionLines()
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Localization.LocString> get_OpenInventoryLines()
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Localization.LocString> get_PlayerDeadLines()
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Localization.LocString> get_WelcomeLines()
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Localization.LocString> GetPurchaseSuccessLines(MegaCrit.Sts2.Core.Entities.Merchant.PurchaseStatus status)
```

## MegaCrit.Sts2.Core.Entities.Merchant.MerchantEntry

类型属性：`Public, Abstract, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
protected System.Int32 _cost
protected readonly MegaCrit.Sts2.Core.Entities.Players.Player _player
private System.Action EntryUpdated
private System.Action<MegaCrit.Sts2.Core.Entities.Merchant.PurchaseStatus, MegaCrit.Sts2.Core.Entities.Merchant.MerchantEntry> PurchaseCompleted
private System.Action<MegaCrit.Sts2.Core.Entities.Merchant.PurchaseStatus> PurchaseFailed
System.Int32 Cost { public get; }
System.Boolean EnoughGold { public get; }
System.Boolean IsStocked { public abstract get; }
event System.Action EntryUpdated
event System.Action<MegaCrit.Sts2.Core.Entities.Merchant.PurchaseStatus, MegaCrit.Sts2.Core.Entities.Merchant.MerchantEntry> PurchaseCompleted
event System.Action<MegaCrit.Sts2.Core.Entities.Merchant.PurchaseStatus> PurchaseFailed
protected .ctor(MegaCrit.Sts2.Core.Entities.Players.Player player)
protected abstract System.Threading.Tasks.Task<System.ValueTuple<System.Boolean, System.Int32>> OnTryPurchase(MegaCrit.Sts2.Core.Entities.Merchant.MerchantInventory inventory, System.Boolean ignoreCost)
protected abstract System.Void ClearAfterPurchase()
protected abstract System.Void RestockAfterPurchase(MegaCrit.Sts2.Core.Entities.Merchant.MerchantInventory inventory)
protected virtual System.Void UpdateEntry()
public [async] System.Threading.Tasks.Task<System.Boolean> OnTryPurchaseWrapper(MegaCrit.Sts2.Core.Entities.Merchant.MerchantInventory inventory, System.Boolean ignoreCost = False)
public abstract System.Boolean get_IsStocked()
public abstract System.Void CalcCost()
public System.Boolean get_EnoughGold()
public System.Int32 get_Cost()
public System.Void add_EntryUpdated(System.Action value)
public System.Void add_PurchaseCompleted(System.Action<MegaCrit.Sts2.Core.Entities.Merchant.PurchaseStatus, MegaCrit.Sts2.Core.Entities.Merchant.MerchantEntry> value)
public System.Void add_PurchaseFailed(System.Action<MegaCrit.Sts2.Core.Entities.Merchant.PurchaseStatus> value)
public System.Void InvokePurchaseCompleted(MegaCrit.Sts2.Core.Entities.Merchant.MerchantEntry entry)
public System.Void InvokePurchaseFailed(MegaCrit.Sts2.Core.Entities.Merchant.PurchaseStatus status)
public System.Void OnMerchantInventoryUpdated()
public System.Void remove_EntryUpdated(System.Action value)
public System.Void remove_PurchaseCompleted(System.Action<MegaCrit.Sts2.Core.Entities.Merchant.PurchaseStatus, MegaCrit.Sts2.Core.Entities.Merchant.MerchantEntry> value)
public System.Void remove_PurchaseFailed(System.Action<MegaCrit.Sts2.Core.Entities.Merchant.PurchaseStatus> value)
```

## MegaCrit.Sts2.Core.Entities.Merchant.MerchantEntry+<OnTryPurchaseWrapper>d__23

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Entities.Merchant.MerchantEntry <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Boolean> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.ValueTuple<System.Boolean, System.Int32>> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
private System.Boolean <success>5__2
public System.Boolean ignoreCost
public MegaCrit.Sts2.Core.Entities.Merchant.MerchantInventory inventory
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Entities.Merchant.MerchantInventory

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Merchant.MerchantCardEntry> _characterCardEntries
private static readonly MegaCrit.Sts2.Core.Entities.Cards.CardType[] _coloredCardTypes
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Merchant.MerchantCardEntry> _colorlessCardEntries
private static readonly MegaCrit.Sts2.Core.Entities.Cards.CardRarity[] _colorlessCardRarities
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Merchant.MerchantPotionEntry> _potionEntries
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Merchant.MerchantRelicEntry> _relicEntries
private MegaCrit.Sts2.Core.Entities.Merchant.MerchantCardRemovalEntry <CardRemovalEntry>k__BackingField
private readonly MegaCrit.Sts2.Core.Entities.Players.Player <Player>k__BackingField
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Merchant.MerchantEntry> AllEntries { public get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Merchant.MerchantCardEntry> CardEntries { public get; }
MegaCrit.Sts2.Core.Entities.Merchant.MerchantCardRemovalEntry CardRemovalEntry { public get; private set; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Merchant.MerchantCardEntry> CharacterCardEntries { public get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Merchant.MerchantCardEntry> ColorlessCardEntries { public get; }
MegaCrit.Sts2.Core.Entities.Players.Player Player { public get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Merchant.MerchantPotionEntry> PotionEntries { public get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Merchant.MerchantRelicEntry> RelicEntries { public get; }
private static .cctor()
public .ctor(MegaCrit.Sts2.Core.Entities.Players.Player player)
private System.Void PopulateCharacterCardEntries()
private System.Void PopulateColorlessCardEntries()
private System.Void PopulatePotionEntries()
private System.Void PopulateRelicEntries()
private System.Void set_CardRemovalEntry(MegaCrit.Sts2.Core.Entities.Merchant.MerchantCardRemovalEntry value)
private System.Void UpdateEntries(MegaCrit.Sts2.Core.Entities.Merchant.PurchaseStatus _, MegaCrit.Sts2.Core.Entities.Merchant.MerchantEntry __)
public MegaCrit.Sts2.Core.Entities.Merchant.MerchantCardRemovalEntry get_CardRemovalEntry()
public MegaCrit.Sts2.Core.Entities.Players.Player get_Player()
public static MegaCrit.Sts2.Core.Entities.Merchant.MerchantInventory CreateForNormalMerchant(MegaCrit.Sts2.Core.Entities.Players.Player player)
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Merchant.MerchantCardEntry> get_CardEntries()
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Merchant.MerchantEntry> get_AllEntries()
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Merchant.MerchantCardEntry> get_CharacterCardEntries()
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Merchant.MerchantCardEntry> get_ColorlessCardEntries()
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Merchant.MerchantPotionEntry> get_PotionEntries()
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Merchant.MerchantRelicEntry> get_RelicEntries()
public System.Void AddRelicEntry(MegaCrit.Sts2.Core.Entities.Merchant.MerchantRelicEntry entry)
```

## MegaCrit.Sts2.Core.Entities.Merchant.MerchantInventory+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Entities.Merchant.MerchantInventory+<>c <>9
public static System.Func<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Merchant.MerchantEntry>, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Merchant.MerchantEntry>> <>9__22_0
private static .cctor()
public .ctor()
internal System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Merchant.MerchantEntry> <get_AllEntries>b__22_0(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Merchant.MerchantEntry> e)
```

## MegaCrit.Sts2.Core.Entities.Merchant.MerchantPotionEntry

类型属性：`Public, Sealed, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Entities.Merchant.MerchantEntry`。

接口：

```text
private MegaCrit.Sts2.Core.Models.PotionModel <Model>k__BackingField
System.Boolean IsStocked { public virtual get; }
MegaCrit.Sts2.Core.Models.PotionModel Model { public get; private set; }
public .ctor(MegaCrit.Sts2.Core.Entities.Players.Player player)
public .ctor(MegaCrit.Sts2.Core.Models.PotionModel potion, MegaCrit.Sts2.Core.Entities.Players.Player player)
private static System.Int32 GetCost(MegaCrit.Sts2.Core.Entities.Potions.PotionRarity rarity)
private System.Void FillSlot(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.PotionModel> blacklist)
private System.Void set_Model(MegaCrit.Sts2.Core.Models.PotionModel value)
protected virtual [async] System.Threading.Tasks.Task<System.ValueTuple<System.Boolean, System.Int32>> OnTryPurchase(MegaCrit.Sts2.Core.Entities.Merchant.MerchantInventory inventory, System.Boolean ignoreCost)
protected virtual System.Void ClearAfterPurchase()
protected virtual System.Void RestockAfterPurchase(MegaCrit.Sts2.Core.Entities.Merchant.MerchantInventory inventory)
public MegaCrit.Sts2.Core.Models.PotionModel get_Model()
public virtual System.Boolean get_IsStocked()
public virtual System.Void CalcCost()
```

## MegaCrit.Sts2.Core.Entities.Merchant.MerchantPotionEntry+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Entities.Merchant.MerchantPotionEntry+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Entities.Merchant.MerchantPotionEntry, MegaCrit.Sts2.Core.Models.PotionModel> <>9__13_0
private static .cctor()
public .ctor()
internal MegaCrit.Sts2.Core.Models.PotionModel <RestockAfterPurchase>b__13_0(MegaCrit.Sts2.Core.Entities.Merchant.MerchantPotionEntry e)
```

## MegaCrit.Sts2.Core.Entities.Merchant.MerchantPotionEntry+<OnTryPurchase>d__11

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Entities.Merchant.MerchantPotionEntry <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.ValueTuple<System.Boolean, System.Int32>> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Entities.Potions.PotionProcureResult> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
public System.Boolean ignoreCost
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Entities.Merchant.MerchantRelicEntry

类型属性：`Public, Sealed, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Entities.Merchant.MerchantEntry`。

接口：

```text
private MegaCrit.Sts2.Core.Models.RelicModel <Model>k__BackingField
System.Boolean IsStocked { public virtual get; }
MegaCrit.Sts2.Core.Models.RelicModel Model { public get; private set; }
public .ctor(MegaCrit.Sts2.Core.Entities.Relics.RelicRarity rarity, MegaCrit.Sts2.Core.Entities.Players.Player player)
public .ctor(MegaCrit.Sts2.Core.Models.RelicModel relic, MegaCrit.Sts2.Core.Entities.Players.Player player)
private System.Void FillSlot(MegaCrit.Sts2.Core.Entities.Relics.RelicRarity rarity, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.RelicModel> blacklist = null)
private System.Void set_Model(MegaCrit.Sts2.Core.Models.RelicModel value)
private System.Void SetModel(MegaCrit.Sts2.Core.Models.RelicModel model)
protected virtual [async] System.Threading.Tasks.Task<System.ValueTuple<System.Boolean, System.Int32>> OnTryPurchase(MegaCrit.Sts2.Core.Entities.Merchant.MerchantInventory inventory, System.Boolean ignoreCost)
protected virtual System.Void ClearAfterPurchase()
protected virtual System.Void RestockAfterPurchase(MegaCrit.Sts2.Core.Entities.Merchant.MerchantInventory inventory)
public MegaCrit.Sts2.Core.Models.RelicModel get_Model()
public virtual System.Boolean get_IsStocked()
public virtual System.Void CalcCost()
```

## MegaCrit.Sts2.Core.Entities.Merchant.MerchantRelicEntry+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Entities.Merchant.MerchantRelicEntry+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Entities.Merchant.MerchantRelicEntry, MegaCrit.Sts2.Core.Models.RelicModel> <>9__13_0
private static .cctor()
public .ctor()
internal MegaCrit.Sts2.Core.Models.RelicModel <RestockAfterPurchase>b__13_0(MegaCrit.Sts2.Core.Entities.Merchant.MerchantRelicEntry e)
```

## MegaCrit.Sts2.Core.Entities.Merchant.MerchantRelicEntry+<>c__DisplayClass8_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.RelicModel> blacklist
public .ctor()
internal System.Boolean <FillSlot>b__0(MegaCrit.Sts2.Core.Models.RelicModel r)
```

## MegaCrit.Sts2.Core.Entities.Merchant.MerchantRelicEntry+<OnTryPurchase>d__11

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Entities.Merchant.MerchantRelicEntry <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.ValueTuple<System.Boolean, System.Int32>> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Models.RelicModel> <>u__2
public System.Boolean ignoreCost
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Entities.Merchant.PurchaseStatus

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Entities.Merchant.PurchaseStatus FailureForbidden = 3
public static const MegaCrit.Sts2.Core.Entities.Merchant.PurchaseStatus FailureGold = 1
public static const MegaCrit.Sts2.Core.Entities.Merchant.PurchaseStatus FailureOutOfStock = 4
public static const MegaCrit.Sts2.Core.Entities.Merchant.PurchaseStatus FailureSpace = 2
public static const MegaCrit.Sts2.Core.Entities.Merchant.PurchaseStatus Success = 0
public System.Int32 value__
```
