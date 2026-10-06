# MegaCrit.Sts2.Core.Entities.RestSite

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Entities.RestSite.CloneRestSiteOption

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption`。

接口：

```text
MegaCrit.Sts2.Core.Localization.LocString Description { public virtual get; }
System.String OptionId { public virtual get; }
public .ctor(MegaCrit.Sts2.Core.Entities.Players.Player owner)
private System.Boolean <DoRemotePostSelectVfx>b__7_0(MegaCrit.Sts2.Core.Nodes.RestSite.NRestSiteCharacter c)
public virtual [async] System.Threading.Tasks.Task<System.Boolean> OnSelect()
public virtual MegaCrit.Sts2.Core.Localization.LocString get_Description()
public virtual System.String get_OptionId()
public virtual System.Threading.Tasks.Task DoLocalPostSelectVfx(System.Threading.CancellationToken ct = null)
public virtual System.Threading.Tasks.Task DoRemotePostSelectVfx()
```

## MegaCrit.Sts2.Core.Entities.RestSite.CloneRestSiteOption+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Entities.RestSite.CloneRestSiteOption+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> <>9__5_0
private static .cctor()
public .ctor()
internal System.Boolean <OnSelect>b__5_0(MegaCrit.Sts2.Core.Models.CardModel c)
```

## MegaCrit.Sts2.Core.Entities.RestSite.CloneRestSiteOption+<OnSelect>d__5

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Entities.RestSite.CloneRestSiteOption <>4__this
private System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Models.CardModel> <>7__wrap2
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult> <>7__wrap3
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Boolean> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult> <>u__1
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult> <results>5__2
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Entities.RestSite.CookRestSiteOption

类型属性：`Public, Sealed, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption`。

接口：

```text
private static const System.Int32 _cardsToRemove = 2
private static const System.Int32 _maxHpGain = 5
MegaCrit.Sts2.Core.Localization.LocString Description { public virtual get; }
System.Boolean IsEnabled { public virtual get; }
System.String OptionId { public virtual get; }
public .ctor(MegaCrit.Sts2.Core.Entities.Players.Player owner)
private static System.Int32 GetRemovableCardCount(MegaCrit.Sts2.Core.Entities.Players.Player player)
public virtual [async] System.Threading.Tasks.Task<System.Boolean> OnSelect()
public virtual MegaCrit.Sts2.Core.Localization.LocString get_Description()
public virtual System.Boolean get_IsEnabled()
public virtual System.String get_OptionId()
```

## MegaCrit.Sts2.Core.Entities.RestSite.CookRestSiteOption+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Entities.RestSite.CookRestSiteOption+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> <>9__10_0
private static .cctor()
public .ctor()
internal System.Boolean <GetRemovableCardCount>b__10_0(MegaCrit.Sts2.Core.Models.CardModel c)
```

## MegaCrit.Sts2.Core.Entities.RestSite.CookRestSiteOption+<OnSelect>d__9

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Entities.RestSite.CookRestSiteOption <>4__this
private System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Models.CardModel> <>7__wrap1
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Boolean> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Entities.RestSite.DigRestSiteOption

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption`。

接口：

```text
System.String OptionId { public virtual get; }
public .ctor(MegaCrit.Sts2.Core.Entities.Players.Player owner)
private System.Boolean <DoRemotePostSelectVfx>b__5_0(MegaCrit.Sts2.Core.Nodes.RestSite.NRestSiteCharacter c)
public virtual [async] System.Threading.Tasks.Task<System.Boolean> OnSelect()
public virtual System.String get_OptionId()
public virtual System.Threading.Tasks.Task DoLocalPostSelectVfx(System.Threading.CancellationToken ct = null)
public virtual System.Threading.Tasks.Task DoRemotePostSelectVfx()
```

## MegaCrit.Sts2.Core.Entities.RestSite.DigRestSiteOption+<OnSelect>d__3

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Entities.RestSite.DigRestSiteOption <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Boolean> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Models.RelicModel> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Entities.RestSite.HatchRestSiteOption

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption`。

接口：

```text
System.String OptionId { public virtual get; }
public .ctor(MegaCrit.Sts2.Core.Entities.Players.Player owner)
private System.Boolean <DoRemotePostSelectVfx>b__5_0(MegaCrit.Sts2.Core.Nodes.RestSite.NRestSiteCharacter c)
public virtual [async] System.Threading.Tasks.Task<System.Boolean> OnSelect()
public virtual System.String get_OptionId()
public virtual System.Threading.Tasks.Task DoLocalPostSelectVfx(System.Threading.CancellationToken ct = null)
public virtual System.Threading.Tasks.Task DoRemotePostSelectVfx()
```

## MegaCrit.Sts2.Core.Entities.RestSite.HatchRestSiteOption+<OnSelect>d__3

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Entities.RestSite.HatchRestSiteOption <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Boolean> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Models.Relics.Byrdpip> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Entities.RestSite.HealRestSiteOption

类型属性：`Public, Sealed, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption`。

接口：

```text
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public virtual get; }
MegaCrit.Sts2.Core.Localization.LocString Description { public virtual get; }
System.String OptionId { public virtual get; }
public .ctor(MegaCrit.Sts2.Core.Entities.Players.Player owner)
public static [async] System.Threading.Tasks.Task ExecuteRestSiteHeal(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Boolean isMimicked)
public static System.Decimal GetBaseHealAmount(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public static System.Decimal GetHealAmount(MegaCrit.Sts2.Core.Entities.Players.Player player)
public static System.Void PlayRestSiteHealSfx()
public virtual [async] System.Threading.Tasks.Task DoLocalPostSelectVfx(System.Threading.CancellationToken ct = null)
public virtual [async] System.Threading.Tasks.Task<System.Boolean> OnSelect()
public virtual MegaCrit.Sts2.Core.Localization.LocString get_Description()
public virtual System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.String get_OptionId()
public virtual System.Threading.Tasks.Task DoRemotePostSelectVfx()
```

## MegaCrit.Sts2.Core.Entities.RestSite.HealRestSiteOption+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Entities.RestSite.HealRestSiteOption+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Localization.LocString, System.String> <>9__6_0
private static .cctor()
public .ctor()
internal System.String <get_Description>b__6_0(MegaCrit.Sts2.Core.Localization.LocString s)
```

## MegaCrit.Sts2.Core.Entities.RestSite.HealRestSiteOption+<DoLocalPostSelectVfx>d__9

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public System.Threading.CancellationToken ct
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Entities.RestSite.HealRestSiteOption+<ExecuteRestSiteHeal>d__13

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public System.Boolean isMimicked
public MegaCrit.Sts2.Core.Entities.Players.Player player
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Entities.RestSite.HealRestSiteOption+<OnSelect>d__8

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Entities.RestSite.HealRestSiteOption <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Boolean> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Entities.RestSite.KindleRestSiteOption

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption`。

接口：

```text
MegaCrit.Sts2.Core.Localization.LocString Description { public virtual get; }
System.String OptionId { public virtual get; }
public .ctor(MegaCrit.Sts2.Core.Entities.Players.Player owner)
private System.Boolean <PlayKindleVfx>b__8_0(MegaCrit.Sts2.Core.Nodes.RestSite.NRestSiteCharacter c)
private System.Void PlayKindleVfx()
public virtual MegaCrit.Sts2.Core.Localization.LocString get_Description()
public virtual System.String get_OptionId()
public virtual System.Threading.Tasks.Task DoLocalPostSelectVfx(System.Threading.CancellationToken ct = null)
public virtual System.Threading.Tasks.Task DoRemotePostSelectVfx()
public virtual System.Threading.Tasks.Task<System.Boolean> OnSelect()
```

## MegaCrit.Sts2.Core.Entities.RestSite.LiftRestSiteOption

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption`。

接口：

```text
MegaCrit.Sts2.Core.Localization.LocString Description { public virtual get; }
System.String OptionId { public virtual get; }
public .ctor(MegaCrit.Sts2.Core.Entities.Players.Player owner)
private System.Boolean <DoRemotePostSelectVfx>b__7_0(MegaCrit.Sts2.Core.Nodes.RestSite.NRestSiteCharacter c)
public virtual [async] System.Threading.Tasks.Task<System.Boolean> OnSelect()
public virtual MegaCrit.Sts2.Core.Localization.LocString get_Description()
public virtual System.String get_OptionId()
public virtual System.Threading.Tasks.Task DoLocalPostSelectVfx(System.Threading.CancellationToken ct = null)
public virtual System.Threading.Tasks.Task DoRemotePostSelectVfx()
```

## MegaCrit.Sts2.Core.Entities.RestSite.LiftRestSiteOption+<OnSelect>d__5

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Entities.RestSite.LiftRestSiteOption <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Boolean> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Entities.RestSite.MendRestSiteOption

类型属性：`Public, Sealed, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption`。

接口：

```text
private MegaCrit.Sts2.Core.Localization.LocString _description
private static const System.String _hasTargetKey = "HasTarget"
private readonly MegaCrit.Sts2.Core.Localization.DynamicVars.HealVar _healVar
private static const System.String _playerNameKey = "Name"
MegaCrit.Sts2.Core.Localization.LocString Description { public virtual get; }
System.String OptionId { public virtual get; }
public .ctor(MegaCrit.Sts2.Core.Entities.Players.Player owner)
private MegaCrit.Sts2.Core.Entities.Players.Player NodeToPlayer(Godot.Node node)
private System.Boolean <OnSelect>b__10_0(MegaCrit.Sts2.Core.Nodes.RestSite.NRestSiteCharacter c)
private System.Boolean AllowHoveringNode(Godot.Node node)
private System.Boolean ShouldCancelTargeting()
private System.Void OnNodeHovered(Godot.Node node)
private System.Void OnNodeUnhovered(Godot.Node _)
public static System.Decimal GetHealAmount(MegaCrit.Sts2.Core.Entities.Players.Player player)
public virtual [async] System.Threading.Tasks.Task<System.Boolean> OnSelect()
public virtual MegaCrit.Sts2.Core.Localization.LocString get_Description()
public virtual System.String get_OptionId()
```

## MegaCrit.Sts2.Core.Entities.RestSite.MendRestSiteOption+<OnSelect>d__10

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Entities.RestSite.MendRestSiteOption <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Boolean> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<Godot.Node> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.GameActions.PlayerChoiceResult> <>u__2
private System.Runtime.CompilerServices.TaskAwaiter <>u__3
private System.UInt32 <choiceId>5__2
private MegaCrit.Sts2.Core.Entities.Players.Player <target>5__3
private MegaCrit.Sts2.Core.Nodes.Combat.NTargetManager <targetManager>5__5
private System.Boolean <usingController>5__4
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption

类型属性：`Public, Abstract, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private readonly MegaCrit.Sts2.Core.Entities.Players.Player <Owner>k__BackingField
public static System.Func<MegaCrit.Sts2.Core.Entities.Players.Player, System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption>> generateForTests
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public virtual get; }
MegaCrit.Sts2.Core.Localization.LocString Description { public virtual get; }
Godot.Texture2D Icon { public get; }
System.String IconPath { private get; }
System.Boolean IsEnabled { public virtual get; }
System.String OptionId { public abstract get; }
MegaCrit.Sts2.Core.Entities.Players.Player Owner { protected get; }
MegaCrit.Sts2.Core.Localization.LocString Title { public get; }
protected .ctor(MegaCrit.Sts2.Core.Entities.Players.Player owner)
private System.String get_IconPath()
protected MegaCrit.Sts2.Core.Entities.Players.Player get_Owner()
public abstract System.String get_OptionId()
public abstract System.Threading.Tasks.Task<System.Boolean> OnSelect()
public Godot.Texture2D get_Icon()
public MegaCrit.Sts2.Core.Localization.LocString get_Title()
public static System.Boolean op_Equality(MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption left, MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption right)
public static System.Boolean op_Inequality(MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption left, MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption right)
public static System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption> Generate(MegaCrit.Sts2.Core.Entities.Players.Player player)
public virtual MegaCrit.Sts2.Core.Localization.LocString get_Description()
public virtual System.Boolean Equals(System.Object obj)
public virtual System.Boolean get_IsEnabled()
public virtual System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Int32 GetHashCode()
public virtual System.Threading.Tasks.Task DoLocalPostSelectVfx(System.Threading.CancellationToken ct = null)
public virtual System.Threading.Tasks.Task DoRemotePostSelectVfx()
```

## MegaCrit.Sts2.Core.Entities.RestSite.SmithRestSiteOption

类型属性：`Public, Sealed, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption`。

接口：

```text
private System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> _selection
private System.Int32 <SmithCount>k__BackingField
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public virtual get; }
MegaCrit.Sts2.Core.Localization.LocString Description { public virtual get; }
System.Boolean IsEnabled { public virtual get; }
System.String OptionId { public virtual get; }
System.Int32 SmithCount { public get; public set; }
public .ctor(MegaCrit.Sts2.Core.Entities.Players.Player owner)
private System.Boolean <DoRemotePostSelectVfx>b__16_0(MegaCrit.Sts2.Core.Nodes.RestSite.NRestSiteCharacter c)
public System.Int32 get_SmithCount()
public System.Void set_SmithCount(System.Int32 value)
public virtual [async] System.Threading.Tasks.Task DoLocalPostSelectVfx(System.Threading.CancellationToken ct = null)
public virtual [async] System.Threading.Tasks.Task<System.Boolean> OnSelect()
public virtual MegaCrit.Sts2.Core.Localization.LocString get_Description()
public virtual System.Boolean get_IsEnabled()
public virtual System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.String get_OptionId()
public virtual System.Threading.Tasks.Task DoRemotePostSelectVfx()
```

## MegaCrit.Sts2.Core.Entities.RestSite.SmithRestSiteOption+<DoLocalPostSelectVfx>d__15

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Entities.RestSite.SmithRestSiteOption <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public System.Threading.CancellationToken ct
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Entities.RestSite.SmithRestSiteOption+<OnSelect>d__14

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Entities.RestSite.SmithRestSiteOption <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Boolean> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```
