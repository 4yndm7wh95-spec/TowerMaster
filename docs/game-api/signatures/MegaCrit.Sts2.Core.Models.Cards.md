# MegaCrit.Sts2.Core.Models.Cards

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Models.Cards.Beckon

类型属性：`Public, Sealed, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Models.CardModel`。

接口：`System.IComparable<MegaCrit.Sts2.Core.Models.AbstractModel>`

```text
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar> CanonicalVars { protected virtual get; }
System.Boolean HasTurnEndInHandEffect { public virtual get; }
System.Int32 MaxUpgradeLevel { public virtual get; }
public .ctor()
protected virtual [async] System.Threading.Tasks.Task OnTurnEndInHand(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext)
protected virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar> get_CanonicalVars()
public virtual System.Boolean get_HasTurnEndInHandEffect()
public virtual System.Int32 get_MaxUpgradeLevel()
```

## MegaCrit.Sts2.Core.Models.Cards.Burn

类型属性：`Public, Sealed, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Models.CardModel`。

接口：`System.IComparable<MegaCrit.Sts2.Core.Models.AbstractModel>`

```text
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Cards.CardKeyword> CanonicalKeywords { public virtual get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar> CanonicalVars { protected virtual get; }
System.Collections.Generic.IEnumerable<System.String> ExtraRunAssetPaths { protected virtual get; }
System.Boolean HasTurnEndInHandEffect { public virtual get; }
System.Int32 MaxUpgradeLevel { public virtual get; }
public .ctor()
protected virtual [async] System.Threading.Tasks.Task OnTurnEndInHand(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext)
protected virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar> get_CanonicalVars()
protected virtual System.Collections.Generic.IEnumerable<System.String> get_ExtraRunAssetPaths()
public virtual System.Boolean get_HasTurnEndInHandEffect()
public virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Cards.CardKeyword> get_CanonicalKeywords()
public virtual System.Int32 get_MaxUpgradeLevel()
```

## MegaCrit.Sts2.Core.Models.Cards.Dazed

类型属性：`Public, Sealed, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Models.CardModel`。

接口：`System.IComparable<MegaCrit.Sts2.Core.Models.AbstractModel>`

```text
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Cards.CardKeyword> CanonicalKeywords { public virtual get; }
System.Int32 MaxUpgradeLevel { public virtual get; }
public .ctor()
public virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Cards.CardKeyword> get_CanonicalKeywords()
public virtual System.Int32 get_MaxUpgradeLevel()
```

## MegaCrit.Sts2.Core.Models.Cards.Debris

类型属性：`Public, Sealed, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Models.CardModel`。

接口：`System.IComparable<MegaCrit.Sts2.Core.Models.AbstractModel>`

```text
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Cards.CardKeyword> CanonicalKeywords { public virtual get; }
System.Int32 MaxUpgradeLevel { public virtual get; }
public .ctor()
protected virtual System.Threading.Tasks.Task OnPlay(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Cards.CardPlay cardPlay)
public virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Cards.CardKeyword> get_CanonicalKeywords()
public virtual System.Int32 get_MaxUpgradeLevel()
```

## MegaCrit.Sts2.Core.Models.Cards.DeprecatedCard

类型属性：`Public, Sealed, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Models.CardModel`。

接口：`System.IComparable<MegaCrit.Sts2.Core.Models.AbstractModel>`

```text
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Cards.CardKeyword> CanonicalKeywords { public virtual get; }
System.Int32 MaxUpgradeLevel { public virtual get; }
public .ctor()
protected virtual [async] System.Threading.Tasks.Task OnPlay(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Cards.CardPlay cardPlay)
public virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Cards.CardKeyword> get_CanonicalKeywords()
public virtual System.Int32 get_MaxUpgradeLevel()
```

## MegaCrit.Sts2.Core.Models.Cards.Disintegration

类型属性：`Public, Sealed, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Models.CardModel`。

接口：`System.IComparable<MegaCrit.Sts2.Core.Models.AbstractModel>`, `MegaCrit.Sts2.Core.Models.Monsters.KnowledgeDemon+IChoosable`

```text
System.Boolean CanBeGeneratedInCombat { public virtual get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar> CanonicalVars { protected virtual get; }
System.Int32 MaxUpgradeLevel { public virtual get; }
public .ctor()
protected virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar> get_CanonicalVars()
public virtual [async] System.Threading.Tasks.Task OnChosen()
public virtual System.Boolean get_CanBeGeneratedInCombat()
public virtual System.Int32 get_MaxUpgradeLevel()
```

## MegaCrit.Sts2.Core.Models.Cards.FranticEscape

类型属性：`Public, Sealed, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Models.CardModel`。

接口：`System.IComparable<MegaCrit.Sts2.Core.Models.AbstractModel>`

```text
System.Boolean CanBeGeneratedInCombat { public virtual get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.HoverTips.IHoverTip> ExtraHoverTips { protected virtual get; }
System.Int32 MaxUpgradeLevel { public virtual get; }
public .ctor()
private MegaCrit.Sts2.Core.Entities.Creatures.Creature GetSandpitEnemy()
private System.Boolean <OnPlay>b__7_0(MegaCrit.Sts2.Core.Models.Powers.SandpitPower s)
protected virtual [async] System.Threading.Tasks.Task OnPlay(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Cards.CardPlay cardPlay)
protected virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.HoverTips.IHoverTip> get_ExtraHoverTips()
public virtual System.Boolean get_CanBeGeneratedInCombat()
public virtual System.Int32 get_MaxUpgradeLevel()
```

## MegaCrit.Sts2.Core.Models.Cards.Infection

类型属性：`Public, Sealed, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Models.CardModel`。

接口：`System.IComparable<MegaCrit.Sts2.Core.Models.AbstractModel>`

```text
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Cards.CardKeyword> CanonicalKeywords { public virtual get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar> CanonicalVars { protected virtual get; }
System.Boolean HasBuiltInOverlay { public virtual get; }
System.Boolean HasTurnEndInHandEffect { public virtual get; }
System.Int32 MaxUpgradeLevel { public virtual get; }
public .ctor()
protected virtual [async] System.Threading.Tasks.Task OnTurnEndInHand(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext)
protected virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar> get_CanonicalVars()
public virtual System.Boolean get_HasBuiltInOverlay()
public virtual System.Boolean get_HasTurnEndInHandEffect()
public virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Cards.CardKeyword> get_CanonicalKeywords()
public virtual System.Int32 get_MaxUpgradeLevel()
```

## MegaCrit.Sts2.Core.Models.Cards.MindRot

类型属性：`Public, Sealed, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Models.CardModel`。

接口：`System.IComparable<MegaCrit.Sts2.Core.Models.AbstractModel>`, `MegaCrit.Sts2.Core.Models.Monsters.KnowledgeDemon+IChoosable`

```text
System.Boolean CanBeGeneratedInCombat { public virtual get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar> CanonicalVars { protected virtual get; }
System.Int32 MaxUpgradeLevel { public virtual get; }
public .ctor()
protected virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar> get_CanonicalVars()
public virtual [async] System.Threading.Tasks.Task OnChosen()
public virtual System.Boolean get_CanBeGeneratedInCombat()
public virtual System.Int32 get_MaxUpgradeLevel()
```

## MegaCrit.Sts2.Core.Models.Cards.Slimed

类型属性：`Public, Sealed, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Models.CardModel`。

接口：`System.IComparable<MegaCrit.Sts2.Core.Models.AbstractModel>`

```text
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Cards.CardKeyword> CanonicalKeywords { public virtual get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar> CanonicalVars { protected virtual get; }
System.Int32 MaxUpgradeLevel { public virtual get; }
public .ctor()
protected virtual [async] System.Threading.Tasks.Task OnPlay(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Cards.CardPlay cardPlay)
protected virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar> get_CanonicalVars()
public virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Cards.CardKeyword> get_CanonicalKeywords()
public virtual System.Int32 get_MaxUpgradeLevel()
```

## MegaCrit.Sts2.Core.Models.Cards.Sloth

类型属性：`Public, Sealed, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Models.CardModel`。

接口：`System.IComparable<MegaCrit.Sts2.Core.Models.AbstractModel>`, `MegaCrit.Sts2.Core.Models.Monsters.KnowledgeDemon+IChoosable`

```text
System.Boolean CanBeGeneratedInCombat { public virtual get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar> CanonicalVars { protected virtual get; }
System.Int32 MaxUpgradeLevel { public virtual get; }
public .ctor()
protected virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar> get_CanonicalVars()
public virtual [async] System.Threading.Tasks.Task OnChosen()
public virtual System.Boolean get_CanBeGeneratedInCombat()
public virtual System.Int32 get_MaxUpgradeLevel()
```

## MegaCrit.Sts2.Core.Models.Cards.Soot

类型属性：`Public, Sealed, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Models.CardModel`。

接口：`System.IComparable<MegaCrit.Sts2.Core.Models.AbstractModel>`

```text
System.Boolean CanBeGeneratedInCombat { public virtual get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Cards.CardKeyword> CanonicalKeywords { public virtual get; }
System.Int32 MaxUpgradeLevel { public virtual get; }
public .ctor()
public virtual System.Boolean get_CanBeGeneratedInCombat()
public virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Cards.CardKeyword> get_CanonicalKeywords()
public virtual System.Int32 get_MaxUpgradeLevel()
```

## MegaCrit.Sts2.Core.Models.Cards.Toxic

类型属性：`Public, Sealed, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Models.CardModel`。

接口：`System.IComparable<MegaCrit.Sts2.Core.Models.AbstractModel>`

```text
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Cards.CardKeyword> CanonicalKeywords { public virtual get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar> CanonicalVars { protected virtual get; }
System.Boolean HasTurnEndInHandEffect { public virtual get; }
System.Int32 MaxUpgradeLevel { public virtual get; }
public .ctor()
protected virtual [async] System.Threading.Tasks.Task OnTurnEndInHand(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext)
protected virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar> get_CanonicalVars()
public virtual System.Boolean get_HasTurnEndInHandEffect()
public virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Cards.CardKeyword> get_CanonicalKeywords()
public virtual System.Int32 get_MaxUpgradeLevel()
```

## MegaCrit.Sts2.Core.Models.Cards.Void

类型属性：`Public, Sealed, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Models.CardModel`。

接口：`System.IComparable<MegaCrit.Sts2.Core.Models.AbstractModel>`

```text
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Cards.CardKeyword> CanonicalKeywords { public virtual get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar> CanonicalVars { protected virtual get; }
System.Int32 MaxUpgradeLevel { public virtual get; }
public .ctor()
protected virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar> get_CanonicalVars()
public virtual [async] System.Threading.Tasks.Task AfterCardDrawn(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Models.CardModel card, System.Boolean fromHandDraw)
public virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Cards.CardKeyword> get_CanonicalKeywords()
public virtual System.Int32 get_MaxUpgradeLevel()
```

## MegaCrit.Sts2.Core.Models.Cards.WasteAway

类型属性：`Public, Sealed, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Models.CardModel`。

接口：`System.IComparable<MegaCrit.Sts2.Core.Models.AbstractModel>`, `MegaCrit.Sts2.Core.Models.Monsters.KnowledgeDemon+IChoosable`

```text
System.Boolean CanBeGeneratedInCombat { public virtual get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar> CanonicalVars { protected virtual get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.HoverTips.IHoverTip> ExtraHoverTips { protected virtual get; }
System.Int32 MaxUpgradeLevel { public virtual get; }
public .ctor()
protected virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.HoverTips.IHoverTip> get_ExtraHoverTips()
protected virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar> get_CanonicalVars()
public virtual [async] System.Threading.Tasks.Task OnChosen()
public virtual System.Boolean get_CanBeGeneratedInCombat()
public virtual System.Int32 get_MaxUpgradeLevel()
```

## MegaCrit.Sts2.Core.Models.Cards.Wither

类型属性：`Public, Sealed, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Models.CardModel`。

接口：`System.IComparable<MegaCrit.Sts2.Core.Models.AbstractModel>`

```text
private System.Int32 _fakeUpgradeLevel
System.String[] AllPortraitPaths { public virtual get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Cards.CardKeyword> CanonicalKeywords { public virtual get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar> CanonicalVars { protected virtual get; }
System.Collections.Generic.IEnumerable<System.String> ExtraRunAssetPaths { protected virtual get; }
System.Int32 FakeUpgradeLevel { private get; private set; }
System.Boolean HasTurnEndInHandEffect { public virtual get; }
System.Int32 MaxUpgradeLevel { public virtual get; }
System.String PortraitPath { public virtual get; }
System.String PortraitPngPath { protected virtual get; }
System.String Title { public virtual get; }
public .ctor()
private System.Int32 get_FakeUpgradeLevel()
private System.String GetPortraitFilename(System.Int32 witherLevel)
private System.String GetPortraitPath(System.Int32 witherLevel)
private System.String GetPortraitPngPath(System.Int32 witherLevel)
private System.Void set_FakeUpgradeLevel(System.Int32 value)
protected virtual [async] System.Threading.Tasks.Task OnTurnEndInHand(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext)
protected virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar> get_CanonicalVars()
protected virtual System.Collections.Generic.IEnumerable<System.String> get_ExtraRunAssetPaths()
protected virtual System.String get_PortraitPngPath()
public System.Void FakeUpgrade()
public virtual System.Boolean get_HasTurnEndInHandEffect()
public virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Cards.CardKeyword> get_CanonicalKeywords()
public virtual System.Int32 get_MaxUpgradeLevel()
public virtual System.String get_PortraitPath()
public virtual System.String get_Title()
public virtual System.String[] get_AllPortraitPaths()
```

## MegaCrit.Sts2.Core.Models.Cards.Wound

类型属性：`Public, Sealed, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Models.CardModel`。

接口：`System.IComparable<MegaCrit.Sts2.Core.Models.AbstractModel>`

```text
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Cards.CardKeyword> CanonicalKeywords { public virtual get; }
System.Int32 MaxUpgradeLevel { public virtual get; }
public .ctor()
public virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Cards.CardKeyword> get_CanonicalKeywords()
public virtual System.Int32 get_MaxUpgradeLevel()
```
