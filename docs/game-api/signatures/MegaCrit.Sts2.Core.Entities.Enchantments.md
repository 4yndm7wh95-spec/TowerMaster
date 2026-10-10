# MegaCrit.Sts2.Core.Entities.Enchantments

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Entities.Enchantments.EnchantmentOption

类型属性：`Public, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：

```text
public readonly MegaCrit.Sts2.Core.Models.EnchantmentModel enchantment
public readonly System.Int32 maxAmount
public readonly System.Int32 minAmount
public .ctor(MegaCrit.Sts2.Core.Models.EnchantmentModel enchantment, System.Int32 minAmount, System.Int32 maxAmount)
```

## MegaCrit.Sts2.Core.Entities.Enchantments.EnchantmentStatus

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Entities.Enchantments.EnchantmentStatus Disabled = 1
public static const MegaCrit.Sts2.Core.Entities.Enchantments.EnchantmentStatus Normal = 0
public System.Int32 value__
```
