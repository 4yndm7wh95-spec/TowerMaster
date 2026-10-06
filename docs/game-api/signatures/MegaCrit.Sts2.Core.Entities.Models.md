# MegaCrit.Sts2.Core.Entities.Models

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Entities.Models.DeterministicModelComparer

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：`System.Collections.Generic.IComparer<MegaCrit.Sts2.Core.Models.AbstractModel>`

```text
private static readonly MegaCrit.Sts2.Core.Entities.Models.DeterministicModelComparer <Instance>k__BackingField
MegaCrit.Sts2.Core.Entities.Models.DeterministicModelComparer Instance { public static get; }
private .ctor()
private static .cctor()
private static MegaCrit.Sts2.Core.Entities.Creatures.Creature GetOwner(MegaCrit.Sts2.Core.Models.AbstractModel model)
private static System.Int32 CompareCardModelsWithSameOwnerAndId(MegaCrit.Sts2.Core.Models.CardModel cardModel1, MegaCrit.Sts2.Core.Models.CardModel cardModel2)
private static System.Int32 CompareModelsWithSameOwnerAndId(MegaCrit.Sts2.Core.Models.AbstractModel model1, MegaCrit.Sts2.Core.Models.AbstractModel model2)
public static MegaCrit.Sts2.Core.Entities.Models.DeterministicModelComparer get_Instance()
public virtual System.Int32 Compare(MegaCrit.Sts2.Core.Models.AbstractModel model1, MegaCrit.Sts2.Core.Models.AbstractModel model2)
```

## MegaCrit.Sts2.Core.Entities.Models.PlayerChoiceType

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Entities.Models.PlayerChoiceType CanonicalCard = 1
public static const MegaCrit.Sts2.Core.Entities.Models.PlayerChoiceType CombatCard = 2
public static const MegaCrit.Sts2.Core.Entities.Models.PlayerChoiceType DeckCard = 3
public static const MegaCrit.Sts2.Core.Entities.Models.PlayerChoiceType Index = 6
public static const MegaCrit.Sts2.Core.Entities.Models.PlayerChoiceType MutableCard = 4
public static const MegaCrit.Sts2.Core.Entities.Models.PlayerChoiceType None = 0
public static const MegaCrit.Sts2.Core.Entities.Models.PlayerChoiceType Player = 5
public System.Int32 value__
```
