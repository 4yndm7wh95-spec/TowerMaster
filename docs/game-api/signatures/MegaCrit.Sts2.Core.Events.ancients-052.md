# MegaCrit.Sts2.Core.Events

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Events.EventLayoutType

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Events.EventLayoutType Ancient = 2
public static const MegaCrit.Sts2.Core.Events.EventLayoutType Combat = 1
public static const MegaCrit.Sts2.Core.Events.EventLayoutType Custom = 3
public static const MegaCrit.Sts2.Core.Events.EventLayoutType Default = 0
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Events.EventOption

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private MegaCrit.Sts2.Core.Localization.LocString <Description>k__BackingField
private readonly System.Boolean <DisableOnChosen>k__BackingField
private MegaCrit.Sts2.Core.Localization.LocString <HistoryName>k__BackingField
private System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.HoverTips.IHoverTip> <HoverTips>k__BackingField
private readonly System.Boolean <IsLocked>k__BackingField
private System.Boolean <IsProceed>k__BackingField
private readonly System.Func<System.Threading.Tasks.Task> <OnChosen>k__BackingField
private MegaCrit.Sts2.Core.Models.RelicModel <Relic>k__BackingField
private System.Boolean <ShouldSaveChoiceToHistory>k__BackingField
private System.Boolean <ShouldSaveVariablesToHistory>k__BackingField
private System.String <TextKey>k__BackingField
private MegaCrit.Sts2.Core.Localization.LocString <Title>k__BackingField
private System.Boolean <WasChosen>k__BackingField
private System.Func<MegaCrit.Sts2.Core.Entities.Players.Player, System.Boolean> <WillKillPlayer>k__BackingField
private System.Func<MegaCrit.Sts2.Core.Events.EventOption, System.Threading.Tasks.Task> BeforeChosen
MegaCrit.Sts2.Core.Localization.LocString Description { public get; private set; }
System.Boolean DisableOnChosen { private get; }
MegaCrit.Sts2.Core.Localization.LocString HistoryName { public get; private set; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.HoverTips.IHoverTip> HoverTips { public get; public set; }
System.Boolean IsLocked { public get; }
System.Boolean IsProceed { public get; private set; }
System.Func<System.Threading.Tasks.Task> OnChosen { private get; }
MegaCrit.Sts2.Core.Models.RelicModel Relic { public get; private set; }
System.Boolean ShouldSaveChoiceToHistory { public get; private set; }
System.Boolean ShouldSaveVariablesToHistory { public get; private set; }
System.String TextKey { public get; private set; }
MegaCrit.Sts2.Core.Localization.LocString Title { public get; private set; }
System.Boolean WasChosen { public get; private set; }
System.Func<MegaCrit.Sts2.Core.Entities.Players.Player, System.Boolean> WillKillPlayer { public get; private set; }
event System.Func<MegaCrit.Sts2.Core.Events.EventOption, System.Threading.Tasks.Task> BeforeChosen
public .ctor(MegaCrit.Sts2.Core.Events.EventOption eventOption)
public .ctor(MegaCrit.Sts2.Core.Models.EventModel eventModel, System.Func<System.Threading.Tasks.Task> onChosen, MegaCrit.Sts2.Core.Localization.LocString title, MegaCrit.Sts2.Core.Localization.LocString description, System.String textKey, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.HoverTips.IHoverTip> hoverTips)
public .ctor(MegaCrit.Sts2.Core.Models.EventModel eventModel, System.Func<System.Threading.Tasks.Task> onChosen, System.String textKey, params MegaCrit.Sts2.Core.HoverTips.IHoverTip[] hoverTips)
public .ctor(MegaCrit.Sts2.Core.Models.EventModel eventModel, System.Func<System.Threading.Tasks.Task> onChosen, System.String textKey, System.Boolean disableOnChosen = True, System.Boolean isProceed = False, params MegaCrit.Sts2.Core.HoverTips.IHoverTip[] hoverTips)
public .ctor(MegaCrit.Sts2.Core.Models.EventModel eventModel, System.Func<System.Threading.Tasks.Task> onChosen, System.String textKey, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.HoverTips.IHoverTip> hoverTips)
private System.Boolean get_DisableOnChosen()
private System.Func<System.Threading.Tasks.Task> get_OnChosen()
private System.Void AddLocVars(MegaCrit.Sts2.Core.Models.EventModel eventModel)
private System.Void set_Description(MegaCrit.Sts2.Core.Localization.LocString value)
private System.Void set_HistoryName(MegaCrit.Sts2.Core.Localization.LocString value)
private System.Void set_IsProceed(System.Boolean value)
private System.Void set_Relic(MegaCrit.Sts2.Core.Models.RelicModel value)
private System.Void set_ShouldSaveChoiceToHistory(System.Boolean value)
private System.Void set_ShouldSaveVariablesToHistory(System.Boolean value)
private System.Void set_TextKey(System.String value)
private System.Void set_Title(MegaCrit.Sts2.Core.Localization.LocString value)
private System.Void set_WasChosen(System.Boolean value)
private System.Void set_WillKillPlayer(System.Func<MegaCrit.Sts2.Core.Entities.Players.Player, System.Boolean> value)
public [async] System.Threading.Tasks.Task Chosen()
public MegaCrit.Sts2.Core.Events.EventOption ThatDecreasesMaxHp(System.Decimal value)
public MegaCrit.Sts2.Core.Events.EventOption ThatDoesDamage(System.Decimal damage)
public MegaCrit.Sts2.Core.Events.EventOption ThatHasDynamicTitle()
public MegaCrit.Sts2.Core.Events.EventOption ThatWillKillPlayerIf(System.Func<MegaCrit.Sts2.Core.Entities.Players.Player, System.Boolean> willKillPlayer)
public MegaCrit.Sts2.Core.Events.EventOption ThatWontSaveToChoiceHistory()
public MegaCrit.Sts2.Core.Events.EventOption WithOverridenHistoryName(MegaCrit.Sts2.Core.Localization.LocString historyName)
public MegaCrit.Sts2.Core.Events.EventOption WithRelic(MegaCrit.Sts2.Core.Models.RelicModel relic)
public MegaCrit.Sts2.Core.Events.EventOption WithRelic<T>(MegaCrit.Sts2.Core.Entities.Players.Player owner) where T: [None] MegaCrit.Sts2.Core.Models.RelicModel
public MegaCrit.Sts2.Core.Localization.LocString get_Description()
public MegaCrit.Sts2.Core.Localization.LocString get_HistoryName()
public MegaCrit.Sts2.Core.Localization.LocString get_Title()
public MegaCrit.Sts2.Core.Models.RelicModel get_Relic()
public static MegaCrit.Sts2.Core.Events.EventOption FromRelic(MegaCrit.Sts2.Core.Models.RelicModel relic, MegaCrit.Sts2.Core.Models.EventModel eventModel, System.Func<System.Threading.Tasks.Task> onChosen, System.String textKey)
public System.Boolean get_IsLocked()
public System.Boolean get_IsProceed()
public System.Boolean get_ShouldSaveChoiceToHistory()
public System.Boolean get_ShouldSaveVariablesToHistory()
public System.Boolean get_WasChosen()
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.HoverTips.IHoverTip> get_HoverTips()
public System.Func<MegaCrit.Sts2.Core.Entities.Players.Player, System.Boolean> get_WillKillPlayer()
public System.String get_TextKey()
public System.Void add_BeforeChosen(System.Func<MegaCrit.Sts2.Core.Events.EventOption, System.Threading.Tasks.Task> value)
public System.Void remove_BeforeChosen(System.Func<MegaCrit.Sts2.Core.Events.EventOption, System.Threading.Tasks.Task> value)
public System.Void set_HoverTips(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.HoverTips.IHoverTip> value)
public virtual System.String ToString()
```

## MegaCrit.Sts2.Core.Events.EventOption+<>c__DisplayClass66_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.Decimal damage
public .ctor()
internal System.Boolean <ThatDoesDamage>b__0(MegaCrit.Sts2.Core.Entities.Players.Player p)
```

## MegaCrit.Sts2.Core.Events.EventOption+<>c__DisplayClass67_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.Decimal value
public .ctor()
internal System.Boolean <ThatDecreasesMaxHp>b__0(MegaCrit.Sts2.Core.Entities.Players.Player p)
```

## MegaCrit.Sts2.Core.Events.EventOption+<Chosen>d__64

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Events.EventOption <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```
