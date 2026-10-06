# MegaCrit.Sts2.Core.Localization.DynamicVars

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Localization.DynamicVars.BlockVar

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar`。

接口：`System.IConvertible`

```text
private readonly MegaCrit.Sts2.Core.ValueProps.ValueProp <Props>k__BackingField
public static const System.String defaultName = "Block"
MegaCrit.Sts2.Core.ValueProps.ValueProp Props { public get; }
public .ctor(System.Decimal block, MegaCrit.Sts2.Core.ValueProps.ValueProp props)
public .ctor(System.String name, System.Decimal block, MegaCrit.Sts2.Core.ValueProps.ValueProp props)
public MegaCrit.Sts2.Core.ValueProps.ValueProp get_Props()
public virtual System.Void UpdateCardPreview(MegaCrit.Sts2.Core.Models.CardModel card, MegaCrit.Sts2.Core.Entities.Cards.CardPreviewMode previewMode, MegaCrit.Sts2.Core.Entities.Creatures.Creature target, System.Boolean runGlobalHooks)
```

## MegaCrit.Sts2.Core.Localization.DynamicVars.BoolVar

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar`。

接口：`System.IConvertible`

```text
System.Boolean BoolVal { public get; public set; }
public .ctor(System.String name, System.Boolean value)
public .ctor(System.String name)
public System.Boolean get_BoolVal()
public System.Void set_BoolVal(System.Boolean value)
```

## MegaCrit.Sts2.Core.Localization.DynamicVars.CalculatedBlockVar

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Localization.DynamicVars.CalculatedVar`。

接口：`System.IConvertible`

```text
private readonly MegaCrit.Sts2.Core.ValueProps.ValueProp <Props>k__BackingField
public static const System.String defaultName = "CalculatedBlock"
MegaCrit.Sts2.Core.ValueProps.ValueProp Props { public get; }
public .ctor(MegaCrit.Sts2.Core.ValueProps.ValueProp props)
public MegaCrit.Sts2.Core.ValueProps.ValueProp get_Props()
public virtual System.Void UpdateCardPreview(MegaCrit.Sts2.Core.Models.CardModel card, MegaCrit.Sts2.Core.Entities.Cards.CardPreviewMode previewMode, MegaCrit.Sts2.Core.Entities.Creatures.Creature target, System.Boolean runGlobalHooks)
```

## MegaCrit.Sts2.Core.Localization.DynamicVars.CalculatedDamageVar

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Localization.DynamicVars.CalculatedVar`。

接口：`System.IConvertible`

```text
private System.Boolean <IsFromOsty>k__BackingField
private readonly MegaCrit.Sts2.Core.ValueProps.ValueProp <Props>k__BackingField
public static const System.String defaultName = "CalculatedDamage"
System.Boolean IsFromOsty { public get; private set; }
MegaCrit.Sts2.Core.ValueProps.ValueProp Props { public get; }
public .ctor(MegaCrit.Sts2.Core.ValueProps.ValueProp props)
private System.Void set_IsFromOsty(System.Boolean value)
protected virtual MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar GetExtraVar()
public MegaCrit.Sts2.Core.Localization.DynamicVars.CalculatedDamageVar FromOsty()
public MegaCrit.Sts2.Core.ValueProps.ValueProp get_Props()
public System.Boolean get_IsFromOsty()
public virtual System.Void UpdateCardPreview(MegaCrit.Sts2.Core.Models.CardModel card, MegaCrit.Sts2.Core.Entities.Cards.CardPreviewMode previewMode, MegaCrit.Sts2.Core.Entities.Creatures.Creature target, System.Boolean runGlobalHooks)
```

## MegaCrit.Sts2.Core.Localization.DynamicVars.CalculatedVar

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar`。

接口：`System.IConvertible`

```text
private System.Func<MegaCrit.Sts2.Core.Models.CardModel, MegaCrit.Sts2.Core.Entities.Creatures.Creature, System.Decimal> _multiplierCalc
public .ctor(System.String name)
private System.Void UpdateValues()
protected virtual MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar GetBaseVar()
protected virtual MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar GetExtraVar()
protected virtual System.Decimal GetBaseValueForIConvertible()
public MegaCrit.Sts2.Core.Localization.DynamicVars.CalculatedVar WithMultiplier(System.Func<MegaCrit.Sts2.Core.Models.CardModel, MegaCrit.Sts2.Core.Entities.Creatures.Creature, System.Decimal> multiplierCalc)
public System.Decimal Calculate(MegaCrit.Sts2.Core.Entities.Creatures.Creature target)
public System.Void RecalculateForUpgradeOrEnchant()
public virtual System.String ToString()
public virtual System.Void SetOwner(MegaCrit.Sts2.Core.Models.AbstractModel owner)
public virtual System.Void UpdateCardPreview(MegaCrit.Sts2.Core.Models.CardModel card, MegaCrit.Sts2.Core.Entities.Cards.CardPreviewMode previewMode, MegaCrit.Sts2.Core.Entities.Creatures.Creature target, System.Boolean runGlobalHooks)
```

## MegaCrit.Sts2.Core.Localization.DynamicVars.CalculationBaseVar

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar`。

接口：`System.IConvertible`

```text
public static const System.String defaultName = "CalculationBase"
public .ctor(System.Decimal baseValue)
```

## MegaCrit.Sts2.Core.Localization.DynamicVars.CalculationExtraVar

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar`。

接口：`System.IConvertible`

```text
public static const System.String defaultName = "CalculationExtra"
public .ctor(System.Decimal baseValue)
```

## MegaCrit.Sts2.Core.Localization.DynamicVars.CardsVar

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar`。

接口：`System.IConvertible`

```text
public static const System.String defaultName = "Cards"
public .ctor(System.Int32 cards)
public .ctor(System.String name, System.Int32 cards)
```

## MegaCrit.Sts2.Core.Localization.DynamicVars.DamageVar

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar`。

接口：`System.IConvertible`

```text
private MegaCrit.Sts2.Core.ValueProps.ValueProp <Props>k__BackingField
public static const System.String defaultName = "Damage"
MegaCrit.Sts2.Core.ValueProps.ValueProp Props { public get; public set; }
public .ctor(System.Decimal damage, MegaCrit.Sts2.Core.ValueProps.ValueProp props)
public .ctor(System.String name, System.Decimal damage, MegaCrit.Sts2.Core.ValueProps.ValueProp props)
public MegaCrit.Sts2.Core.ValueProps.ValueProp get_Props()
public System.Void set_Props(MegaCrit.Sts2.Core.ValueProps.ValueProp value)
public virtual System.Void UpdateCardPreview(MegaCrit.Sts2.Core.Models.CardModel card, MegaCrit.Sts2.Core.Entities.Cards.CardPreviewMode previewMode, MegaCrit.Sts2.Core.Entities.Creatures.Creature target, System.Boolean runGlobalHooks)
```

## MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：`System.IConvertible`

```text
private System.Decimal _baseValue
private System.Decimal _enchantedValue
protected MegaCrit.Sts2.Core.Models.AbstractModel _owner
private System.Decimal _previewValue
private readonly System.String <Name>k__BackingField
private System.Boolean <WasJustUpgraded>k__BackingField
System.Decimal BaseValue { public get; public set; }
System.Decimal EnchantedValue { public get; public set; }
System.Int32 IntValue { public get; }
System.String Name { public get; }
System.Decimal PreviewValue { public get; public set; }
System.Boolean WasJustUpgraded { public get; protected set; }
public .ctor(System.String name, System.Decimal baseValue)
protected System.Void set_WasJustUpgraded(System.Boolean value)
protected virtual System.Decimal GetBaseValueForIConvertible()
public MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar Clone()
public System.Boolean get_WasJustUpgraded()
public System.Decimal get_BaseValue()
public System.Decimal get_EnchantedValue()
public System.Decimal get_PreviewValue()
public System.Int32 get_IntValue()
public System.Object GetSourceValue(SmartFormat.Core.Extensions.ISelectorInfo selector)
public System.String get_Name()
public System.String ToHighlightedString(System.Boolean inverse)
public System.Void FinalizeUpgrade()
public System.Void ResetToBase()
public System.Void set_BaseValue(System.Decimal value)
public System.Void set_EnchantedValue(System.Decimal value)
public System.Void set_PreviewValue(System.Decimal value)
public System.Void UpgradeValueBy(System.Decimal addend)
public virtual System.Boolean ToBoolean(System.IFormatProvider provider)
public virtual System.Byte ToByte(System.IFormatProvider provider)
public virtual System.Char ToChar(System.IFormatProvider provider)
public virtual System.DateTime ToDateTime(System.IFormatProvider provider)
public virtual System.Decimal ToDecimal(System.IFormatProvider provider)
public virtual System.Double ToDouble(System.IFormatProvider provider)
public virtual System.Int16 ToInt16(System.IFormatProvider provider)
public virtual System.Int32 ToInt32(System.IFormatProvider provider)
public virtual System.Int64 ToInt64(System.IFormatProvider provider)
public virtual System.Object ToType(System.Type conversionType, System.IFormatProvider provider)
public virtual System.SByte ToSByte(System.IFormatProvider provider)
public virtual System.Single ToSingle(System.IFormatProvider provider)
public virtual System.String ToString()
public virtual System.String ToString(System.IFormatProvider provider)
public virtual System.TypeCode GetTypeCode()
public virtual System.UInt16 ToUInt16(System.IFormatProvider provider)
public virtual System.UInt32 ToUInt32(System.IFormatProvider provider)
public virtual System.UInt64 ToUInt64(System.IFormatProvider provider)
public virtual System.Void SetOwner(MegaCrit.Sts2.Core.Models.AbstractModel owner)
public virtual System.Void UpdateCardPreview(MegaCrit.Sts2.Core.Models.CardModel card, MegaCrit.Sts2.Core.Entities.Cards.CardPreviewMode previewMode, MegaCrit.Sts2.Core.Entities.Creatures.Creature target, System.Boolean runGlobalHooks)
```

## MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVarSet

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：`System.Collections.Generic.IReadOnlyDictionary<System.String, MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar>`, `System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar>>`, `System.Collections.IEnumerable`, `System.Collections.Generic.IReadOnlyCollection<System.Collections.Generic.KeyValuePair<System.String, MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar>>`

```text
private readonly System.Collections.Generic.Dictionary<System.String, MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar> _vars
MegaCrit.Sts2.Core.Localization.DynamicVars.BlockVar Block { public get; }
MegaCrit.Sts2.Core.Localization.DynamicVars.CalculatedBlockVar CalculatedBlock { public get; }
MegaCrit.Sts2.Core.Localization.DynamicVars.CalculatedDamageVar CalculatedDamage { public get; }
MegaCrit.Sts2.Core.Localization.DynamicVars.CalculationBaseVar CalculationBase { public get; }
MegaCrit.Sts2.Core.Localization.DynamicVars.CalculationExtraVar CalculationExtra { public get; }
MegaCrit.Sts2.Core.Localization.DynamicVars.CardsVar Cards { public get; }
System.Int32 Count { public virtual get; }
MegaCrit.Sts2.Core.Localization.DynamicVars.DamageVar Damage { public get; }
MegaCrit.Sts2.Core.Localization.DynamicVars.PowerVar<MegaCrit.Sts2.Core.Models.Powers.DexterityPower> Dexterity { public get; }
MegaCrit.Sts2.Core.Localization.DynamicVars.PowerVar<MegaCrit.Sts2.Core.Models.Powers.DoomPower> Doom { public get; }
MegaCrit.Sts2.Core.Localization.DynamicVars.EnergyVar Energy { public get; }
MegaCrit.Sts2.Core.Localization.DynamicVars.ExtraDamageVar ExtraDamage { public get; }
MegaCrit.Sts2.Core.Localization.DynamicVars.ForgeVar Forge { public get; }
MegaCrit.Sts2.Core.Localization.DynamicVars.GoldVar Gold { public get; }
MegaCrit.Sts2.Core.Localization.DynamicVars.HealVar Heal { public get; }
MegaCrit.Sts2.Core.Localization.DynamicVars.HpLossVar HpLoss { public get; }
MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar Item[System.String key] { public virtual get; }
System.Collections.Generic.IEnumerable<System.String> Keys { public virtual get; }
MegaCrit.Sts2.Core.Localization.DynamicVars.MaxHpVar MaxHp { public get; }
MegaCrit.Sts2.Core.Localization.DynamicVars.OstyDamageVar OstyDamage { public get; }
MegaCrit.Sts2.Core.Localization.DynamicVars.PowerVar<MegaCrit.Sts2.Core.Models.Powers.PoisonPower> Poison { public get; }
MegaCrit.Sts2.Core.Localization.DynamicVars.RepeatVar Repeat { public get; }
MegaCrit.Sts2.Core.Localization.DynamicVars.StarsVar Stars { public get; }
MegaCrit.Sts2.Core.Localization.DynamicVars.PowerVar<MegaCrit.Sts2.Core.Models.Powers.StrengthPower> Strength { public get; }
MegaCrit.Sts2.Core.Localization.DynamicVars.SummonVar Summon { public get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar> Values { public virtual get; }
MegaCrit.Sts2.Core.Localization.DynamicVars.PowerVar<MegaCrit.Sts2.Core.Models.Powers.VulnerablePower> Vulnerable { public get; }
MegaCrit.Sts2.Core.Localization.DynamicVars.PowerVar<MegaCrit.Sts2.Core.Models.Powers.WeakPower> Weak { public get; }
public .ctor(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar> vars)
private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
public MegaCrit.Sts2.Core.Localization.DynamicVars.BlockVar get_Block()
public MegaCrit.Sts2.Core.Localization.DynamicVars.CalculatedBlockVar get_CalculatedBlock()
public MegaCrit.Sts2.Core.Localization.DynamicVars.CalculatedDamageVar get_CalculatedDamage()
public MegaCrit.Sts2.Core.Localization.DynamicVars.CalculationBaseVar get_CalculationBase()
public MegaCrit.Sts2.Core.Localization.DynamicVars.CalculationExtraVar get_CalculationExtra()
public MegaCrit.Sts2.Core.Localization.DynamicVars.CardsVar get_Cards()
public MegaCrit.Sts2.Core.Localization.DynamicVars.DamageVar get_Damage()
public MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVarSet Clone(MegaCrit.Sts2.Core.Models.AbstractModel model)
public MegaCrit.Sts2.Core.Localization.DynamicVars.EnergyVar get_Energy()
public MegaCrit.Sts2.Core.Localization.DynamicVars.ExtraDamageVar get_ExtraDamage()
public MegaCrit.Sts2.Core.Localization.DynamicVars.ForgeVar get_Forge()
public MegaCrit.Sts2.Core.Localization.DynamicVars.GoldVar get_Gold()
public MegaCrit.Sts2.Core.Localization.DynamicVars.HealVar get_Heal()
public MegaCrit.Sts2.Core.Localization.DynamicVars.HpLossVar get_HpLoss()
public MegaCrit.Sts2.Core.Localization.DynamicVars.MaxHpVar get_MaxHp()
public MegaCrit.Sts2.Core.Localization.DynamicVars.OstyDamageVar get_OstyDamage()
public MegaCrit.Sts2.Core.Localization.DynamicVars.PowerVar<MegaCrit.Sts2.Core.Models.Powers.DexterityPower> get_Dexterity()
public MegaCrit.Sts2.Core.Localization.DynamicVars.PowerVar<MegaCrit.Sts2.Core.Models.Powers.DoomPower> get_Doom()
public MegaCrit.Sts2.Core.Localization.DynamicVars.PowerVar<MegaCrit.Sts2.Core.Models.Powers.PoisonPower> get_Poison()
public MegaCrit.Sts2.Core.Localization.DynamicVars.PowerVar<MegaCrit.Sts2.Core.Models.Powers.StrengthPower> get_Strength()
public MegaCrit.Sts2.Core.Localization.DynamicVars.PowerVar<MegaCrit.Sts2.Core.Models.Powers.VulnerablePower> get_Vulnerable()
public MegaCrit.Sts2.Core.Localization.DynamicVars.PowerVar<MegaCrit.Sts2.Core.Models.Powers.WeakPower> get_Weak()
public MegaCrit.Sts2.Core.Localization.DynamicVars.RepeatVar get_Repeat()
public MegaCrit.Sts2.Core.Localization.DynamicVars.StarsVar get_Stars()
public MegaCrit.Sts2.Core.Localization.DynamicVars.SummonVar get_Summon()
public System.Void AddTo(MegaCrit.Sts2.Core.Localization.LocString str)
public System.Void ClearPreview()
public System.Void FinalizeUpgrade()
public System.Void InitializeWithOwner(MegaCrit.Sts2.Core.Models.AbstractModel model)
public System.Void RecalculateForUpgradeOrEnchant()
public virtual MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar get_Item(System.String key)
public virtual System.Boolean ContainsKey(System.String key)
public virtual System.Boolean TryGetValue(System.String key, out MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar value)
public virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar> get_Values()
public virtual System.Collections.Generic.IEnumerable<System.String> get_Keys()
public virtual System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String, MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar>> GetEnumerator()
public virtual System.Int32 get_Count()
```

## MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVarSet+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVarSet+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar, MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar> <>9__67_0
private static .cctor()
public .ctor()
internal MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar <Clone>b__67_0(MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar v)
```

## MegaCrit.Sts2.Core.Localization.DynamicVars.EnergyVar

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar`。

接口：`System.IConvertible`

```text
private System.String <ColorPrefix>k__BackingField
public static const System.String defaultName = "Energy"
System.String ColorPrefix { public get; public set; }
public .ctor(System.Int32 energy)
public .ctor(System.String name, System.Int32 energy)
public System.String get_ColorPrefix()
public System.Void set_ColorPrefix(System.String value)
```

## MegaCrit.Sts2.Core.Localization.DynamicVars.ExtraDamageVar

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar`。

接口：`System.IConvertible`

```text
private System.Boolean <IsFromOsty>k__BackingField
public static const System.String defaultName = "ExtraDamage"
System.Boolean IsFromOsty { public get; private set; }
public .ctor(System.Decimal damage)
private System.Void set_IsFromOsty(System.Boolean value)
public MegaCrit.Sts2.Core.Localization.DynamicVars.ExtraDamageVar FromOsty()
public System.Boolean get_IsFromOsty()
public virtual System.Void UpdateCardPreview(MegaCrit.Sts2.Core.Models.CardModel card, MegaCrit.Sts2.Core.Entities.Cards.CardPreviewMode previewMode, MegaCrit.Sts2.Core.Entities.Creatures.Creature target, System.Boolean runGlobalHooks)
```

## MegaCrit.Sts2.Core.Localization.DynamicVars.ForgeVar

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar`。

接口：`System.IConvertible`

```text
public static const System.String defaultName = "Forge"
public .ctor(System.Int32 forge)
public .ctor(System.String name, System.Int32 forge)
```

## MegaCrit.Sts2.Core.Localization.DynamicVars.GoldVar

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar`。

接口：`System.IConvertible`

```text
public static const System.String defaultName = "Gold"
public .ctor(System.Int32 gold)
public .ctor(System.String name, System.Int32 gold)
```

## MegaCrit.Sts2.Core.Localization.DynamicVars.HealVar

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar`。

接口：`System.IConvertible`

```text
public static const System.String defaultName = "Heal"
public .ctor(System.Decimal healAmount)
public .ctor(System.String name, System.Decimal healAmount)
```

## MegaCrit.Sts2.Core.Localization.DynamicVars.HpLossVar

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar`。

接口：`System.IConvertible`

```text
public static const System.String defaultName = "HpLoss"
public .ctor(System.Decimal hpLoss)
public .ctor(System.String name, System.Decimal hpLoss)
```

## MegaCrit.Sts2.Core.Localization.DynamicVars.IfUpgradedVar

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar`。

接口：`System.IConvertible`

```text
public static const System.String defaultName = "IfUpgraded"
public MegaCrit.Sts2.Core.Localization.UpgradeDisplay upgradeDisplay
public .ctor(MegaCrit.Sts2.Core.Localization.UpgradeDisplay upgradeDisplay)
public .ctor(System.String name, System.Decimal amount)
```

## MegaCrit.Sts2.Core.Localization.DynamicVars.IntVar

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar`。

接口：`System.IConvertible`

```text
public .ctor(System.String name, System.Decimal amount)
```

## MegaCrit.Sts2.Core.Localization.DynamicVars.MaxHpVar

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar`。

接口：`System.IConvertible`

```text
public static const System.String defaultName = "MaxHp"
public .ctor(System.Decimal maxHp)
public .ctor(System.String name, System.Decimal maxHp)
```

## MegaCrit.Sts2.Core.Localization.DynamicVars.OstyDamageVar

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar`。

接口：`System.IConvertible`

```text
private MegaCrit.Sts2.Core.ValueProps.ValueProp <Props>k__BackingField
public static const System.String defaultName = "OstyDamage"
MegaCrit.Sts2.Core.ValueProps.ValueProp Props { public get; public set; }
public .ctor(System.Decimal damage, MegaCrit.Sts2.Core.ValueProps.ValueProp props)
public .ctor(System.String name, System.Decimal damage, MegaCrit.Sts2.Core.ValueProps.ValueProp props)
public MegaCrit.Sts2.Core.ValueProps.ValueProp get_Props()
public System.Void set_Props(MegaCrit.Sts2.Core.ValueProps.ValueProp value)
public virtual System.Void UpdateCardPreview(MegaCrit.Sts2.Core.Models.CardModel card, MegaCrit.Sts2.Core.Entities.Cards.CardPreviewMode previewMode, MegaCrit.Sts2.Core.Entities.Creatures.Creature target, System.Boolean runGlobalHooks)
```

## MegaCrit.Sts2.Core.Localization.DynamicVars.PowerVar<T>

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar`。

接口：`System.IConvertible`

```text
public .ctor(System.Decimal powerAmount)
public .ctor(System.String name, System.Decimal powerAmount)
public virtual System.Void UpdateCardPreview(MegaCrit.Sts2.Core.Models.CardModel card, MegaCrit.Sts2.Core.Entities.Cards.CardPreviewMode previewMode, MegaCrit.Sts2.Core.Entities.Creatures.Creature target, System.Boolean runGlobalHooks)
```

## MegaCrit.Sts2.Core.Localization.DynamicVars.RepeatVar

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar`。

接口：`System.IConvertible`

```text
public static const System.String defaultName = "Repeat"
public .ctor(System.Int32 times)
public .ctor(System.String name, System.Int32 times)
```

## MegaCrit.Sts2.Core.Localization.DynamicVars.StarsVar

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar`。

接口：`System.IConvertible`

```text
public static const System.String defaultName = "Stars"
public .ctor(System.Int32 stars)
public .ctor(System.String name, System.Int32 stars)
```

## MegaCrit.Sts2.Core.Localization.DynamicVars.StringVar

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar`。

接口：`System.IConvertible`

```text
private System.String <StringValue>k__BackingField
System.String StringValue { public get; public set; }
public .ctor(System.String name, System.String baseValue = "")
public System.String get_StringValue()
public System.Void set_StringValue(System.String value)
public virtual System.String ToString()
```

## MegaCrit.Sts2.Core.Localization.DynamicVars.SummonVar

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar`。

接口：`System.IConvertible`

```text
public static const System.String defaultName = "Summon"
public .ctor(System.Decimal summonAmount)
public .ctor(System.String name, System.Decimal summonAmount)
public virtual System.Void UpdateCardPreview(MegaCrit.Sts2.Core.Models.CardModel card, MegaCrit.Sts2.Core.Entities.Cards.CardPreviewMode previewMode, MegaCrit.Sts2.Core.Entities.Creatures.Creature target, System.Boolean runGlobalHooks)
```
