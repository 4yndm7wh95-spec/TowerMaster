# MegaCrit.Sts2.Core.ValueProps

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.ValueProps.BlockProps

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static const MegaCrit.Sts2.Core.ValueProps.ValueProp card = 8
public static const MegaCrit.Sts2.Core.ValueProps.ValueProp cardUnpowered = 12
public static const MegaCrit.Sts2.Core.ValueProps.ValueProp monsterMove = 8
public static const MegaCrit.Sts2.Core.ValueProps.ValueProp nonCardUnpowered = 4
```

## MegaCrit.Sts2.Core.ValueProps.DamageProps

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static const MegaCrit.Sts2.Core.ValueProps.ValueProp card = 8
public static const MegaCrit.Sts2.Core.ValueProps.ValueProp cardHpLoss = 14
public static const MegaCrit.Sts2.Core.ValueProps.ValueProp cardUnpowered = 12
public static const MegaCrit.Sts2.Core.ValueProps.ValueProp monsterMove = 8
public static const MegaCrit.Sts2.Core.ValueProps.ValueProp nonCardHpLoss = 6
public static const MegaCrit.Sts2.Core.ValueProps.ValueProp nonCardUnpowered = 4
```

## MegaCrit.Sts2.Core.ValueProps.ValueProp

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.ValueProps.ValueProp Move = 8
public static const MegaCrit.Sts2.Core.ValueProps.ValueProp SkipHurtAnim = 16
public static const MegaCrit.Sts2.Core.ValueProps.ValueProp Unblockable = 2
public static const MegaCrit.Sts2.Core.ValueProps.ValueProp Unpowered = 4
public System.Int32 value__
```

## MegaCrit.Sts2.Core.ValueProps.ValuePropExtensions

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static System.Boolean IsCardOrMonsterMove(MegaCrit.Sts2.Core.ValueProps.ValueProp props)
public static System.Boolean IsPoweredAttack(MegaCrit.Sts2.Core.ValueProps.ValueProp props)
public static System.Boolean IsPoweredCardOrMonsterMoveBlock(MegaCrit.Sts2.Core.ValueProps.ValueProp props)
```
