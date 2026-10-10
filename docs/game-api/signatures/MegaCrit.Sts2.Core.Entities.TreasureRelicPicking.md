# MegaCrit.Sts2.Core.Entities.TreasureRelicPicking

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Entities.TreasureRelicPicking.RelicPickingFight

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Players.Player> playersInvolved
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.TreasureRelicPicking.RelicPickingFightRound> rounds
public .ctor()
```

## MegaCrit.Sts2.Core.Entities.TreasureRelicPicking.RelicPickingFightMove

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Entities.TreasureRelicPicking.RelicPickingFightMove Paper = 1
public static const MegaCrit.Sts2.Core.Entities.TreasureRelicPicking.RelicPickingFightMove Rock = 0
public static const MegaCrit.Sts2.Core.Entities.TreasureRelicPicking.RelicPickingFightMove Scissors = 2
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Entities.TreasureRelicPicking.RelicPickingFightRound

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.Collections.Generic.List<System.Nullable<MegaCrit.Sts2.Core.Entities.TreasureRelicPicking.RelicPickingFightMove>> moves
public .ctor()
```

## MegaCrit.Sts2.Core.Entities.TreasureRelicPicking.RelicPickingResult

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Entities.TreasureRelicPicking.RelicPickingFight fight
public MegaCrit.Sts2.Core.Entities.Players.Player player
public MegaCrit.Sts2.Core.Models.RelicModel relic
public MegaCrit.Sts2.Core.Entities.TreasureRelicPicking.RelicPickingResultType type
public .ctor()
private static MegaCrit.Sts2.Core.Entities.TreasureRelicPicking.RelicPickingFightMove GetLosingMove(MegaCrit.Sts2.Core.Entities.TreasureRelicPicking.RelicPickingFightMove move1, MegaCrit.Sts2.Core.Entities.TreasureRelicPicking.RelicPickingFightMove move2)
public static MegaCrit.Sts2.Core.Entities.TreasureRelicPicking.RelicPickingResult GenerateRelicFight(System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Players.Player> players, MegaCrit.Sts2.Core.Models.RelicModel relic, System.Func<MegaCrit.Sts2.Core.Entities.TreasureRelicPicking.RelicPickingFightMove> generateMove)
```

## MegaCrit.Sts2.Core.Entities.TreasureRelicPicking.RelicPickingResultType

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Entities.TreasureRelicPicking.RelicPickingResultType ConsolationPrize = 2
public static const MegaCrit.Sts2.Core.Entities.TreasureRelicPicking.RelicPickingResultType FoughtOver = 1
public static const MegaCrit.Sts2.Core.Entities.TreasureRelicPicking.RelicPickingResultType OnlyOnePlayerVoted = 0
public static const MegaCrit.Sts2.Core.Entities.TreasureRelicPicking.RelicPickingResultType Skipped = 3
public System.Int32 value__
```
