# MegaCrit.Sts2.Core.Entities.Potions

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Entities.Potions.PotionBody

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Entities.Potions.PotionBody Anvil = 1
public static const MegaCrit.Sts2.Core.Entities.Potions.PotionBody Bolt = 2
public static const MegaCrit.Sts2.Core.Entities.Potions.PotionBody Card = 3
public static const MegaCrit.Sts2.Core.Entities.Potions.PotionBody Cube = 4
public static const MegaCrit.Sts2.Core.Entities.Potions.PotionBody Diamond = 5
public static const MegaCrit.Sts2.Core.Entities.Potions.PotionBody Eye = 6
public static const MegaCrit.Sts2.Core.Entities.Potions.PotionBody Fairy = 7
public static const MegaCrit.Sts2.Core.Entities.Potions.PotionBody Fat = 8
public static const MegaCrit.Sts2.Core.Entities.Potions.PotionBody FatDiamond = 9
public static const MegaCrit.Sts2.Core.Entities.Potions.PotionBody Flask = 10
public static const MegaCrit.Sts2.Core.Entities.Potions.PotionBody Ghost = 11
public static const MegaCrit.Sts2.Core.Entities.Potions.PotionBody Heart = 12
public static const MegaCrit.Sts2.Core.Entities.Potions.PotionBody Moon = 13
public static const MegaCrit.Sts2.Core.Entities.Potions.PotionBody None = 0
public static const MegaCrit.Sts2.Core.Entities.Potions.PotionBody Shield = 14
public static const MegaCrit.Sts2.Core.Entities.Potions.PotionBody Snecko = 15
public static const MegaCrit.Sts2.Core.Entities.Potions.PotionBody Sphere = 16
public static const MegaCrit.Sts2.Core.Entities.Potions.PotionBody Spiky = 17
public static const MegaCrit.Sts2.Core.Entities.Potions.PotionBody Thin = 18
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Entities.Potions.PotionBodyExtensions

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static readonly System.Collections.Generic.Dictionary<System.ValueTuple<MegaCrit.Sts2.Core.Entities.Potions.PotionBody, MegaCrit.Sts2.Core.Entities.Potions.PotionOverlay>, System.String> _potionOverlayMap
private static .cctor()
public static System.String GetBodyPath(MegaCrit.Sts2.Core.Entities.Potions.PotionBody body)
public static System.String GetGradientPath(MegaCrit.Sts2.Core.Entities.Potions.PotionBody body)
public static System.String GetJuicePath(MegaCrit.Sts2.Core.Entities.Potions.PotionBody body)
public static System.String GetOverlayPath(MegaCrit.Sts2.Core.Entities.Potions.PotionBody body, MegaCrit.Sts2.Core.Entities.Potions.PotionOverlay overlay)
```

## MegaCrit.Sts2.Core.Entities.Potions.PotionOverlay

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Entities.Potions.PotionOverlay Bubbles = 1
public static const MegaCrit.Sts2.Core.Entities.Potions.PotionOverlay Curve = 2
public static const MegaCrit.Sts2.Core.Entities.Potions.PotionOverlay None = 0
public static const MegaCrit.Sts2.Core.Entities.Potions.PotionOverlay Sparkle = 3
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Entities.Potions.PotionProcureFailureReason

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Entities.Potions.PotionProcureFailureReason None = 0
public static const MegaCrit.Sts2.Core.Entities.Potions.PotionProcureFailureReason NotAllowed = 2
public static const MegaCrit.Sts2.Core.Entities.Potions.PotionProcureFailureReason TooFull = 1
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Entities.Potions.PotionProcureResult

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Entities.Potions.PotionProcureFailureReason failureReason
public MegaCrit.Sts2.Core.Models.PotionModel potion
public System.Boolean success
public .ctor()
```

## MegaCrit.Sts2.Core.Entities.Potions.PotionRarity

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Entities.Potions.PotionRarity Common = 1
public static const MegaCrit.Sts2.Core.Entities.Potions.PotionRarity Event = 4
public static const MegaCrit.Sts2.Core.Entities.Potions.PotionRarity None = 0
public static const MegaCrit.Sts2.Core.Entities.Potions.PotionRarity Rare = 3
public static const MegaCrit.Sts2.Core.Entities.Potions.PotionRarity Token = 5
public static const MegaCrit.Sts2.Core.Entities.Potions.PotionRarity Uncommon = 2
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Entities.Potions.PotionRarityExtensions

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static MegaCrit.Sts2.Core.Localization.LocString ToLocString(MegaCrit.Sts2.Core.Entities.Potions.PotionRarity potionRarity)
```

## MegaCrit.Sts2.Core.Entities.Potions.PotionUsage

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Entities.Potions.PotionUsage AnyTime = 2
public static const MegaCrit.Sts2.Core.Entities.Potions.PotionUsage Automatic = 3
public static const MegaCrit.Sts2.Core.Entities.Potions.PotionUsage CombatOnly = 1
public static const MegaCrit.Sts2.Core.Entities.Potions.PotionUsage None = 0
public System.Int32 value__
```
