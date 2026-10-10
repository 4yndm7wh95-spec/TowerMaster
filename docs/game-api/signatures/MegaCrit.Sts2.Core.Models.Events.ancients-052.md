# MegaCrit.Sts2.Core.Models.Events

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Models.Events.Neow

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Models.AncientEventModel`。

接口：`System.IComparable<MegaCrit.Sts2.Core.Models.AbstractModel>`

```text
private static const System.String _cursedChoiceDoneDescriptionOverride = "NEOW.pages.DONE.CURSED.description"
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Events.EventOption> _modifierOptions
private static const System.String _positiveChoiceDoneDescriptionOverride = "NEOW.pages.DONE.POSITIVE.description"
private static const System.String _sfxCurious = "event:/sfx/npcs/neow/neow_curious"
private static const System.String _sfxSleepy = "event:/sfx/npcs/neow/neow_sleepy"
private static const System.String _sfxWelcome = "event:/sfx/npcs/neow/neow_welcome"
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Events.EventOption> AllPossibleOptions { public virtual get; }
System.String AmbientBgm { public virtual get; }
Godot.Color ButtonColor { public virtual get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Events.EventOption> CurseOptions { private get; }
Godot.Color DialogueColor { public virtual get; }
MegaCrit.Sts2.Core.Localization.LocString InitialDescription { public virtual get; }
MegaCrit.Sts2.Core.Events.EventOption LavaRockOption { private get; }
System.Collections.Generic.List<MegaCrit.Sts2.Core.Events.EventOption> ModifierOptions { private get; }
MegaCrit.Sts2.Core.Events.EventOption NeowsTalismanOption { private get; }
MegaCrit.Sts2.Core.Events.EventOption NutritiousOysterOption { private get; }
MegaCrit.Sts2.Core.Events.EventOption PomanderOption { private get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Events.EventOption> PositiveOptions { private get; }
MegaCrit.Sts2.Core.Events.EventOption SmallCapsuleOption { private get; }
MegaCrit.Sts2.Core.Events.EventOption StoneHumidifierOption { private get; }
public .ctor()
private [async] System.Threading.Tasks.Task OnModifierOptionSelected(System.Func<System.Threading.Tasks.Task> modifierFunc, System.Int32 index)
private MegaCrit.Sts2.Core.Events.EventOption get_LavaRockOption()
private MegaCrit.Sts2.Core.Events.EventOption get_NeowsTalismanOption()
private MegaCrit.Sts2.Core.Events.EventOption get_NutritiousOysterOption()
private MegaCrit.Sts2.Core.Events.EventOption get_PomanderOption()
private MegaCrit.Sts2.Core.Events.EventOption get_SmallCapsuleOption()
private MegaCrit.Sts2.Core.Events.EventOption get_StoneHumidifierOption()
private System.Boolean <GenerateInitialOptions>b__35_0(MegaCrit.Sts2.Core.Events.EventOption r)
private System.Boolean <GenerateInitialOptions>b__35_7(MegaCrit.Sts2.Core.Events.EventOption r)
private System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Events.EventOption> get_CurseOptions()
private System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Events.EventOption> get_PositiveOptions()
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Events.EventOption> get_ModifierOptions()
protected virtual MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogueSet DefineDialogues()
protected virtual System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Events.EventOption> GenerateInitialOptions()
public virtual Godot.Color get_ButtonColor()
public virtual Godot.Color get_DialogueColor()
public virtual MegaCrit.Sts2.Core.Localization.LocString get_InitialDescription()
public virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Events.EventOption> get_AllPossibleOptions()
public virtual System.String get_AmbientBgm()
```
