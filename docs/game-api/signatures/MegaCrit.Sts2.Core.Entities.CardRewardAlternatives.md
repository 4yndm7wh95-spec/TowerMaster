# MegaCrit.Sts2.Core.Entities.CardRewardAlternatives

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Entities.CardRewardAlternatives.CardRewardAlternative

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private MegaCrit.Sts2.Core.Entities.Rewards.PostAlternateCardRewardAction <AfterSelected>k__BackingField
private readonly System.String[] <Hotkeys>k__BackingField
private System.Func<System.Threading.Tasks.Task> <OnSelect>k__BackingField
private readonly System.String <OptionId>k__BackingField
MegaCrit.Sts2.Core.Entities.Rewards.PostAlternateCardRewardAction AfterSelected { public get; private set; }
System.String[] Hotkeys { public get; }
System.Func<System.Threading.Tasks.Task> OnSelect { public get; private set; }
System.String OptionId { public get; }
MegaCrit.Sts2.Core.Localization.LocString Title { public get; }
public .ctor(System.String optionId, MegaCrit.Sts2.Core.Entities.Rewards.PostAlternateCardRewardAction afterSelected)
public .ctor(System.String optionId, System.Func<System.Threading.Tasks.Task> onSelect, MegaCrit.Sts2.Core.Entities.Rewards.PostAlternateCardRewardAction afterSelected)
private System.Void set_AfterSelected(MegaCrit.Sts2.Core.Entities.Rewards.PostAlternateCardRewardAction value)
private System.Void set_OnSelect(System.Func<System.Threading.Tasks.Task> value)
public MegaCrit.Sts2.Core.Entities.Rewards.PostAlternateCardRewardAction get_AfterSelected()
public MegaCrit.Sts2.Core.Localization.LocString get_Title()
public static System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.CardRewardAlternatives.CardRewardAlternative> Generate(MegaCrit.Sts2.Core.Rewards.CardReward cardReward)
public System.Func<System.Threading.Tasks.Task> get_OnSelect()
public System.String get_OptionId()
public System.String[] get_Hotkeys()
```

## MegaCrit.Sts2.Core.Entities.CardRewardAlternatives.CardRewardAlternative+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Entities.CardRewardAlternatives.CardRewardAlternative+<>c <>9
public static System.Func<System.Threading.Tasks.Task> <>9__16_0
private static .cctor()
public .ctor()
internal System.Threading.Tasks.Task <.ctor>b__16_0()
```

## MegaCrit.Sts2.Core.Entities.CardRewardAlternatives.CardRewardAlternative+<>c__DisplayClass18_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Rewards.CardReward cardReward
public .ctor()
internal System.Threading.Tasks.Task <Generate>b__0()
```
