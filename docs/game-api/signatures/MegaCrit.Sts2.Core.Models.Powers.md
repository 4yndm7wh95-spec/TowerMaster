# MegaCrit.Sts2.Core.Models.Powers

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Models.Powers.ArtifactPower

类型属性：`Public, Sealed, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Models.PowerModel`。

接口：`System.IComparable<MegaCrit.Sts2.Core.Models.AbstractModel>`

```text
System.Boolean ShouldScaleInMultiplayer { public virtual get; }
MegaCrit.Sts2.Core.Entities.Powers.PowerStackType StackType { public virtual get; }
MegaCrit.Sts2.Core.Entities.Powers.PowerType Type { public virtual get; }
public .ctor()
public virtual [async] System.Threading.Tasks.Task AfterModifyingPowerAmountReceived(MegaCrit.Sts2.Core.Models.PowerModel power)
public virtual MegaCrit.Sts2.Core.Entities.Powers.PowerStackType get_StackType()
public virtual MegaCrit.Sts2.Core.Entities.Powers.PowerType get_Type()
public virtual System.Boolean get_ShouldScaleInMultiplayer()
public virtual System.Boolean TryModifyPowerAmountReceived(MegaCrit.Sts2.Core.Models.PowerModel canonicalPower, MegaCrit.Sts2.Core.Entities.Creatures.Creature target, System.Decimal amount, MegaCrit.Sts2.Core.Entities.Creatures.Creature _, out System.Decimal modifiedAmount)
public virtual System.Decimal GetScaledAmountForMultiplayer(MegaCrit.Sts2.Core.Combat.ICombatState combatState, MegaCrit.Sts2.Core.Entities.Creatures.Creature applier, System.Decimal amount, MegaCrit.Sts2.Core.Entities.Creatures.Creature target, MegaCrit.Sts2.Core.Models.CardModel cardSource)
```

## MegaCrit.Sts2.Core.Models.Powers.FrailPower

类型属性：`Public, Sealed, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Models.PowerModel`。

接口：`System.IComparable<MegaCrit.Sts2.Core.Models.AbstractModel>`

```text
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.HoverTips.IHoverTip> ExtraHoverTips { protected virtual get; }
MegaCrit.Sts2.Core.Entities.Powers.PowerStackType StackType { public virtual get; }
MegaCrit.Sts2.Core.Entities.Powers.PowerType Type { public virtual get; }
public .ctor()
protected virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.HoverTips.IHoverTip> get_ExtraHoverTips()
public virtual [async] System.Threading.Tasks.Task AfterSideTurnEnd(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Combat.CombatSide side, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature> participants)
public virtual MegaCrit.Sts2.Core.Entities.Powers.PowerStackType get_StackType()
public virtual MegaCrit.Sts2.Core.Entities.Powers.PowerType get_Type()
public virtual System.Decimal ModifyBlockMultiplicative(MegaCrit.Sts2.Core.Entities.Creatures.Creature target, System.Decimal block, MegaCrit.Sts2.Core.ValueProps.ValueProp props, MegaCrit.Sts2.Core.Models.CardModel cardSource, MegaCrit.Sts2.Core.Entities.Cards.CardPlay cardPlay)
```

## MegaCrit.Sts2.Core.Models.Powers.StrengthPower

类型属性：`Public, Sealed, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Models.PowerModel`。

接口：`System.IComparable<MegaCrit.Sts2.Core.Models.AbstractModel>`

```text
System.Boolean AllowNegative { public virtual get; }
MegaCrit.Sts2.Core.Entities.Powers.PowerStackType StackType { public virtual get; }
MegaCrit.Sts2.Core.Entities.Powers.PowerType Type { public virtual get; }
public .ctor()
public virtual MegaCrit.Sts2.Core.Entities.Powers.PowerStackType get_StackType()
public virtual MegaCrit.Sts2.Core.Entities.Powers.PowerType get_Type()
public virtual System.Boolean get_AllowNegative()
public virtual System.Decimal ModifyDamageAdditive(MegaCrit.Sts2.Core.Entities.Creatures.Creature target, System.Decimal amount, MegaCrit.Sts2.Core.ValueProps.ValueProp props, MegaCrit.Sts2.Core.Entities.Creatures.Creature dealer, MegaCrit.Sts2.Core.Models.CardModel cardSource, MegaCrit.Sts2.Core.Entities.Cards.CardPlay cardPlay)
```

## MegaCrit.Sts2.Core.Models.Powers.VulnerablePower

类型属性：`Public, Sealed, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Models.PowerModel`。

接口：`System.IComparable<MegaCrit.Sts2.Core.Models.AbstractModel>`

```text
private static const System.String _damageIncrease = "DamageIncrease"
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar> CanonicalVars { protected virtual get; }
MegaCrit.Sts2.Core.Entities.Powers.PowerStackType StackType { public virtual get; }
MegaCrit.Sts2.Core.Entities.Powers.PowerType Type { public virtual get; }
public .ctor()
protected virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar> get_CanonicalVars()
public virtual [async] System.Threading.Tasks.Task AfterSideTurnEnd(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Combat.CombatSide side, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature> participants)
public virtual MegaCrit.Sts2.Core.Entities.Powers.PowerStackType get_StackType()
public virtual MegaCrit.Sts2.Core.Entities.Powers.PowerType get_Type()
public virtual System.Decimal ModifyDamageMultiplicative(MegaCrit.Sts2.Core.Entities.Creatures.Creature target, System.Decimal amount, MegaCrit.Sts2.Core.ValueProps.ValueProp props, MegaCrit.Sts2.Core.Entities.Creatures.Creature dealer, MegaCrit.Sts2.Core.Models.CardModel cardSource, MegaCrit.Sts2.Core.Entities.Cards.CardPlay cardPlay)
```

## MegaCrit.Sts2.Core.Models.Powers.WeakPower

类型属性：`Public, Sealed, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Models.PowerModel`。

接口：`System.IComparable<MegaCrit.Sts2.Core.Models.AbstractModel>`

```text
private static const System.String _damageDecrease = "DamageDecrease"
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar> CanonicalVars { protected virtual get; }
MegaCrit.Sts2.Core.Entities.Powers.PowerStackType StackType { public virtual get; }
MegaCrit.Sts2.Core.Entities.Powers.PowerType Type { public virtual get; }
public .ctor()
protected virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar> get_CanonicalVars()
public virtual [async] System.Threading.Tasks.Task AfterSideTurnEnd(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Combat.CombatSide side, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature> participants)
public virtual MegaCrit.Sts2.Core.Entities.Powers.PowerStackType get_StackType()
public virtual MegaCrit.Sts2.Core.Entities.Powers.PowerType get_Type()
public virtual System.Decimal ModifyDamageMultiplicative(MegaCrit.Sts2.Core.Entities.Creatures.Creature target, System.Decimal amount, MegaCrit.Sts2.Core.ValueProps.ValueProp props, MegaCrit.Sts2.Core.Entities.Creatures.Creature dealer, MegaCrit.Sts2.Core.Models.CardModel cardSource, MegaCrit.Sts2.Core.Entities.Cards.CardPlay cardPlay)
```
