# MegaCrit.Sts2.Core.HoverTips

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.HoverTips.CardHoverTip

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：`MegaCrit.Sts2.Core.HoverTips.IHoverTip`

```text
private readonly MegaCrit.Sts2.Core.Models.CardModel <Card>k__BackingField
private readonly System.String <Id>k__BackingField
MegaCrit.Sts2.Core.Models.AbstractModel CanonicalModel { public virtual get; }
MegaCrit.Sts2.Core.Models.CardModel Card { public get; }
System.String Id { public virtual get; }
System.Boolean IsDebuff { public virtual get; }
System.Boolean IsInstanced { public virtual get; }
System.Boolean IsSmart { public virtual get; }
public .ctor(MegaCrit.Sts2.Core.Models.CardModel card)
public MegaCrit.Sts2.Core.Models.CardModel get_Card()
public virtual MegaCrit.Sts2.Core.Models.AbstractModel get_CanonicalModel()
public virtual System.Boolean get_IsDebuff()
public virtual System.Boolean get_IsInstanced()
public virtual System.Boolean get_IsSmart()
public virtual System.String get_Id()
```

## MegaCrit.Sts2.Core.HoverTips.HoverTip

类型属性：`Public, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`MegaCrit.Sts2.Core.HoverTips.IHoverTip`, `System.IEquatable<MegaCrit.Sts2.Core.HoverTips.HoverTip>`

```text
private MegaCrit.Sts2.Core.Models.AbstractModel <CanonicalModel>k__BackingField
private System.String <Description>k__BackingField
private Godot.Texture2D <Icon>k__BackingField
private System.String <Id>k__BackingField
private System.Boolean <IsDebuff>k__BackingField
private System.Boolean <IsInstanced>k__BackingField
private System.Boolean <IsSmart>k__BackingField
private System.Boolean <ShouldOverrideTextOverflow>k__BackingField
private System.String <Title>k__BackingField
MegaCrit.Sts2.Core.Models.AbstractModel CanonicalModel { public virtual get; private set; }
System.String Description { public get; private set; }
Godot.Texture2D Icon { public get; private set; }
System.String Id { public virtual get; public set; }
System.Boolean IsDebuff { public virtual get; public set; }
System.Boolean IsInstanced { public virtual get; public set; }
System.Boolean IsSmart { public virtual get; public set; }
System.Boolean ShouldOverrideTextOverflow { public get; public set; }
System.String Title { public get; private set; }
public .ctor(MegaCrit.Sts2.Core.Localization.LocString description, Godot.Texture2D icon = null)
public .ctor(MegaCrit.Sts2.Core.Localization.LocString title, MegaCrit.Sts2.Core.Localization.LocString description, Godot.Texture2D icon = null)
public .ctor(MegaCrit.Sts2.Core.Localization.LocString title, System.String description, Godot.Texture2D icon = null)
public .ctor(MegaCrit.Sts2.Core.Models.AfflictionModel affliction, MegaCrit.Sts2.Core.Localization.LocString description)
public .ctor(MegaCrit.Sts2.Core.Models.OrbModel orb, MegaCrit.Sts2.Core.Localization.LocString description)
public .ctor(MegaCrit.Sts2.Core.Models.PowerModel power, System.String description, System.Boolean isSmart)
private System.Boolean PrintMembers(System.Text.StringBuilder builder)
private System.Void set_CanonicalModel(MegaCrit.Sts2.Core.Models.AbstractModel value)
private System.Void set_Description(System.String value)
private System.Void set_Icon(Godot.Texture2D value)
private System.Void set_Title(System.String value)
public Godot.Texture2D get_Icon()
public static MegaCrit.Sts2.Core.HoverTips.HoverTipAlignment GetHoverTipAlignment(Godot.Control node, System.Single threshold = 0.75)
public static MegaCrit.Sts2.Core.HoverTips.HoverTipAlignment GetHoverTipAlignment(Godot.Node2D node, System.Single threshold = 0.75)
public static System.Boolean op_Equality(MegaCrit.Sts2.Core.HoverTips.HoverTip left, MegaCrit.Sts2.Core.HoverTips.HoverTip right)
public static System.Boolean op_Inequality(MegaCrit.Sts2.Core.HoverTips.HoverTip left, MegaCrit.Sts2.Core.HoverTips.HoverTip right)
public System.Boolean get_ShouldOverrideTextOverflow()
public System.String get_Description()
public System.String get_Title()
public System.Void set_Id(System.String value)
public System.Void set_IsDebuff(System.Boolean value)
public System.Void set_IsInstanced(System.Boolean value)
public System.Void set_IsSmart(System.Boolean value)
public System.Void set_ShouldOverrideTextOverflow(System.Boolean value)
public System.Void SetCanonicalModel(MegaCrit.Sts2.Core.Models.AbstractModel model)
public virtual MegaCrit.Sts2.Core.Models.AbstractModel get_CanonicalModel()
public virtual System.Boolean Equals(MegaCrit.Sts2.Core.HoverTips.HoverTip other)
public virtual System.Boolean Equals(System.Object obj)
public virtual System.Boolean get_IsDebuff()
public virtual System.Boolean get_IsInstanced()
public virtual System.Boolean get_IsSmart()
public virtual System.Int32 GetHashCode()
public virtual System.String get_Id()
public virtual System.String ToString()
```

## MegaCrit.Sts2.Core.HoverTips.HoverTipAlignment

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.HoverTips.HoverTipAlignment Center = 3
public static const MegaCrit.Sts2.Core.HoverTips.HoverTipAlignment Left = 1
public static const MegaCrit.Sts2.Core.HoverTips.HoverTipAlignment None = 0
public static const MegaCrit.Sts2.Core.HoverTips.HoverTipAlignment Right = 2
public System.Int32 value__
```

## MegaCrit.Sts2.Core.HoverTips.HoverTipExtensions

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static System.Void MegaTryAddingTip(System.Collections.Generic.ICollection<MegaCrit.Sts2.Core.HoverTips.IHoverTip> tips, MegaCrit.Sts2.Core.HoverTips.IHoverTip tip)
```

## MegaCrit.Sts2.Core.HoverTips.HoverTipExtensions+<>c__DisplayClass0_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.HoverTips.IHoverTip tip
public .ctor()
internal System.Boolean <MegaTryAddingTip>b__0(MegaCrit.Sts2.Core.HoverTips.IHoverTip t)
```

## MegaCrit.Sts2.Core.HoverTips.HoverTipFactory

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static readonly System.Collections.Generic.Dictionary<MegaCrit.Sts2.Core.Entities.Cards.CardKeyword, MegaCrit.Sts2.Core.HoverTips.HoverTip> _keywordHoverTips
private static readonly System.Collections.Generic.Dictionary<MegaCrit.Sts2.Core.Models.ModelId, MegaCrit.Sts2.Core.HoverTips.HoverTip> _potionHoverTips
private static .cctor()
private static MegaCrit.Sts2.Core.HoverTips.IHoverTip ForEnergyWithIconPath(System.String path)
private static MegaCrit.Sts2.Core.Localization.LocString L10NStatic(System.String entry)
public static MegaCrit.Sts2.Core.HoverTips.IHoverTip ForEnergy(MegaCrit.Sts2.Core.Entities.Players.Player player)
public static MegaCrit.Sts2.Core.HoverTips.IHoverTip ForEnergy(MegaCrit.Sts2.Core.Models.CardModel card)
public static MegaCrit.Sts2.Core.HoverTips.IHoverTip ForEnergy(MegaCrit.Sts2.Core.Models.PotionModel potion)
public static MegaCrit.Sts2.Core.HoverTips.IHoverTip ForEnergy(MegaCrit.Sts2.Core.Models.PowerModel power)
public static MegaCrit.Sts2.Core.HoverTips.IHoverTip ForEnergy(MegaCrit.Sts2.Core.Models.RelicModel relic)
public static MegaCrit.Sts2.Core.HoverTips.IHoverTip FromCard(MegaCrit.Sts2.Core.Models.CardModel card, System.Boolean upgrade = False)
public static MegaCrit.Sts2.Core.HoverTips.IHoverTip FromCard<T>(System.Boolean upgrade = False) where T: [None] MegaCrit.Sts2.Core.Models.CardModel
public static MegaCrit.Sts2.Core.HoverTips.IHoverTip FromKeyword(MegaCrit.Sts2.Core.Entities.Cards.CardKeyword keyword)
public static MegaCrit.Sts2.Core.HoverTips.IHoverTip FromOrb<T>() where T: [None] MegaCrit.Sts2.Core.Models.OrbModel
public static MegaCrit.Sts2.Core.HoverTips.IHoverTip FromPotion(MegaCrit.Sts2.Core.Models.PotionModel model)
public static MegaCrit.Sts2.Core.HoverTips.IHoverTip FromPotion<T>() where T: [None] MegaCrit.Sts2.Core.Models.PotionModel
public static MegaCrit.Sts2.Core.HoverTips.IHoverTip FromPower(MegaCrit.Sts2.Core.Models.PowerModel model, System.Nullable<System.Int32> amount = null)
public static MegaCrit.Sts2.Core.HoverTips.IHoverTip FromPower<T>(System.Nullable<System.Int32> amount = null) where T: [None] MegaCrit.Sts2.Core.Models.PowerModel
public static MegaCrit.Sts2.Core.HoverTips.IHoverTip Static(MegaCrit.Sts2.Core.HoverTips.StaticHoverTip tip, params MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar[] vars)
public static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.HoverTips.IHoverTip> FromAffliction<T>(System.Int32 amount = 1) where T: [None] MegaCrit.Sts2.Core.Models.AfflictionModel
public static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.HoverTips.IHoverTip> FromCardWithCardHoverTips<T>(System.Boolean upgrade = False) where T: [None] MegaCrit.Sts2.Core.Models.CardModel
public static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.HoverTips.IHoverTip> FromEnchantment<T>(System.Int32 amount = 1) where T: [None] MegaCrit.Sts2.Core.Models.EnchantmentModel
public static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.HoverTips.IHoverTip> FromForge()
public static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.HoverTips.IHoverTip> FromPowerWithPowerHoverTips<T>(System.Nullable<System.Int32> amount = null) where T: [None] MegaCrit.Sts2.Core.Models.PowerModel
public static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.HoverTips.IHoverTip> FromRelic(MegaCrit.Sts2.Core.Models.RelicModel relic)
public static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.HoverTips.IHoverTip> FromRelic<T>() where T: [None] MegaCrit.Sts2.Core.Models.RelicModel
public static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.HoverTips.IHoverTip> FromRelicExcludingItself(MegaCrit.Sts2.Core.Models.RelicModel relic)
public static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.HoverTips.IHoverTip> FromRelicExcludingItself<T>() where T: [None] MegaCrit.Sts2.Core.Models.RelicModel
```

## MegaCrit.Sts2.Core.HoverTips.IHoverTip

类型属性：`Public, ClassSemanticsMask, Abstract, BeforeFieldInit`；基类：`无`。

接口：

```text
private static readonly System.String _summonDynamicId
private static readonly System.String _summonStaticId
MegaCrit.Sts2.Core.Models.AbstractModel CanonicalModel { public abstract get; }
System.String Id { public abstract get; }
System.Boolean IsDebuff { public abstract get; }
System.Boolean IsInstanced { public abstract get; }
System.Boolean IsSmart { public abstract get; }
private static .cctor()
public abstract MegaCrit.Sts2.Core.Models.AbstractModel get_CanonicalModel()
public abstract System.Boolean get_IsDebuff()
public abstract System.Boolean get_IsInstanced()
public abstract System.Boolean get_IsSmart()
public abstract System.String get_Id()
public static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.HoverTips.IHoverTip> RemoveDupes(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.HoverTips.IHoverTip> tips)
```

## MegaCrit.Sts2.Core.HoverTips.IHoverTip+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.HoverTips.IHoverTip+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.HoverTips.IHoverTip, System.Boolean> <>9__12_0
public static System.Predicate<MegaCrit.Sts2.Core.HoverTips.IHoverTip> <>9__12_1
private static .cctor()
public .ctor()
internal System.Boolean <RemoveDupes>b__12_0(MegaCrit.Sts2.Core.HoverTips.IHoverTip tip)
internal System.Boolean <RemoveDupes>b__12_1(MegaCrit.Sts2.Core.HoverTips.IHoverTip tip)
```

## MegaCrit.Sts2.Core.HoverTips.IHoverTip+<>c__DisplayClass12_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.HoverTips.IHoverTip hoverTip
public .ctor()
internal System.Boolean <RemoveDupes>b__2(MegaCrit.Sts2.Core.HoverTips.IHoverTip tip)
```

## MegaCrit.Sts2.Core.HoverTips.StaticHoverTip

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.HoverTips.StaticHoverTip Block = 5
public static const MegaCrit.Sts2.Core.HoverTips.StaticHoverTip CardReward = 9
public static const MegaCrit.Sts2.Core.HoverTips.StaticHoverTip Channeling = 2
public static const MegaCrit.Sts2.Core.HoverTips.StaticHoverTip Cook = 16
public static const MegaCrit.Sts2.Core.HoverTips.StaticHoverTip Energy = 7
public static const MegaCrit.Sts2.Core.HoverTips.StaticHoverTip Evoke = 3
public static const MegaCrit.Sts2.Core.HoverTips.StaticHoverTip Fatal = 6
public static const MegaCrit.Sts2.Core.HoverTips.StaticHoverTip Forge = 10
public static const MegaCrit.Sts2.Core.HoverTips.StaticHoverTip None = 0
public static const MegaCrit.Sts2.Core.HoverTips.StaticHoverTip ReplayDynamic = 14
public static const MegaCrit.Sts2.Core.HoverTips.StaticHoverTip ReplayStatic = 15
public static const MegaCrit.Sts2.Core.HoverTips.StaticHoverTip Stun = 8
public static const MegaCrit.Sts2.Core.HoverTips.StaticHoverTip SummonDynamic = 12
public static const MegaCrit.Sts2.Core.HoverTips.StaticHoverTip SummonStatic = 13
public static const MegaCrit.Sts2.Core.HoverTips.StaticHoverTip Transform = 4
public System.Int32 value__
```
