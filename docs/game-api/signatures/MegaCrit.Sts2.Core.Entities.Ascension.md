# MegaCrit.Sts2.Core.Entities.Ascension

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Entities.Ascension.AscensionLevel

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Entities.Ascension.AscensionLevel AscendersBane = 5
public static const MegaCrit.Sts2.Core.Entities.Ascension.AscensionLevel DeadlyEnemies = 9
public static const MegaCrit.Sts2.Core.Entities.Ascension.AscensionLevel DoubleBoss = 10
public static const MegaCrit.Sts2.Core.Entities.Ascension.AscensionLevel Inflation = 6
public static const MegaCrit.Sts2.Core.Entities.Ascension.AscensionLevel None = 0
public static const MegaCrit.Sts2.Core.Entities.Ascension.AscensionLevel Poverty = 3
public static const MegaCrit.Sts2.Core.Entities.Ascension.AscensionLevel Scarcity = 7
public static const MegaCrit.Sts2.Core.Entities.Ascension.AscensionLevel SwarmingElites = 1
public static const MegaCrit.Sts2.Core.Entities.Ascension.AscensionLevel TightBelt = 4
public static const MegaCrit.Sts2.Core.Entities.Ascension.AscensionLevel ToughEnemies = 8
public System.Int32 value__
public static const MegaCrit.Sts2.Core.Entities.Ascension.AscensionLevel WearyTraveler = 2
```

## MegaCrit.Sts2.Core.Entities.Ascension.AscensionManager

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private readonly System.Int32 _level
public static const System.Int32 maxAscensionAllowed = 10
public .ctor(MegaCrit.Sts2.Core.Entities.Ascension.AscensionLevel level)
public .ctor(System.Int32 level)
public System.Boolean HasLevel(MegaCrit.Sts2.Core.Entities.Ascension.AscensionLevel level)
public System.Void ApplyEffectsTo(MegaCrit.Sts2.Core.Entities.Players.Player player)
```
