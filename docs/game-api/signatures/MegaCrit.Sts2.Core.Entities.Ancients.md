# MegaCrit.Sts2.Core.Entities.Ancients

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogue

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static const System.String _locTable = "ancients"
private readonly MegaCrit.Sts2.Core.Entities.Ancients.ArchitectAttackers <EndAttackers>k__BackingField
private System.Boolean <IsRepeating>k__BackingField
private readonly System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogueLine> <Lines>k__BackingField
private readonly MegaCrit.Sts2.Core.Entities.Ancients.ArchitectAttackers <StartAttackers>k__BackingField
private readonly System.Nullable<System.Int32> <VisitIndex>k__BackingField
MegaCrit.Sts2.Core.Entities.Ancients.ArchitectAttackers EndAttackers { public get; public set; }
System.Boolean IsRepeating { public get; public set; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogueLine> Lines { public get; }
MegaCrit.Sts2.Core.Entities.Ancients.ArchitectAttackers StartAttackers { public get; public set; }
System.Nullable<System.Int32> VisitIndex { public get; public set; }
public .ctor(params System.String[] sfxPaths)
private static System.Boolean HasRepeatingSuffix(System.String baseKey)
public MegaCrit.Sts2.Core.Entities.Ancients.ArchitectAttackers get_EndAttackers()
public MegaCrit.Sts2.Core.Entities.Ancients.ArchitectAttackers get_StartAttackers()
public System.Boolean get_IsRepeating()
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogueLine> get_Lines()
public System.Nullable<System.Int32> get_VisitIndex()
public System.Void PopulateLines(System.String ancientEntry, System.String charEntry, System.Int32 dialogueIndex)
public System.Void set_EndAttackers(MegaCrit.Sts2.Core.Entities.Ancients.ArchitectAttackers value)
public System.Void set_IsRepeating(System.Boolean value)
public System.Void set_StartAttackers(MegaCrit.Sts2.Core.Entities.Ancients.ArchitectAttackers value)
public System.Void set_VisitIndex(System.Nullable<System.Int32> value)
```

## MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogue+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogue+<>c <>9
public static System.Func<System.String, MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogueLine> <>9__20_0
private static .cctor()
public .ctor()
internal MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogueLine <.ctor>b__20_0(System.String sfx)
```

## MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogueLine

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private readonly System.String _sfxPath
private MegaCrit.Sts2.Core.Localization.LocString <LineText>k__BackingField
private MegaCrit.Sts2.Core.Localization.LocString <NextButtonText>k__BackingField
private MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogueSpeaker <Speaker>k__BackingField
public static const System.String sfxFallbackPath = "event:/sfx/ui/enchant_simple"
MegaCrit.Sts2.Core.Localization.LocString LineText { public get; public set; }
MegaCrit.Sts2.Core.Localization.LocString NextButtonText { public get; public set; }
MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogueSpeaker Speaker { public get; public set; }
public .ctor(System.String sfxPath)
public MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogueSpeaker get_Speaker()
public MegaCrit.Sts2.Core.Localization.LocString get_LineText()
public MegaCrit.Sts2.Core.Localization.LocString get_NextButtonText()
public System.String GetSfxOrFallbackPath()
public System.Void set_LineText(MegaCrit.Sts2.Core.Localization.LocString value)
public System.Void set_NextButtonText(MegaCrit.Sts2.Core.Localization.LocString value)
public System.Void set_Speaker(MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogueSpeaker value)
```

## MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogueSet

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private readonly System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogue> <AgnosticDialogues>k__BackingField
private readonly System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogue>> <CharacterDialogues>k__BackingField
private readonly MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogue <FirstVisitEverDialogue>k__BackingField
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogue> AgnosticDialogues { public get; public set; }
System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogue>> CharacterDialogues { public get; public set; }
MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogue FirstVisitEverDialogue { public get; public set; }
public .ctor()
private static System.Void AddRepeatingDialogues(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogue> source, System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogue> destination, System.Int32 charVisits)
public MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogue get_FirstVisitEverDialogue()
public System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogue>> get_CharacterDialogues()
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogue> GetAllDialogues()
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogue> GetValidDialogues(MegaCrit.Sts2.Core.Models.ModelId characterId, System.Int32 charVisits, System.Int32 totalVisits, System.Boolean allowAnyCharacterDialogues)
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogue> get_AgnosticDialogues()
public System.Void PopulateLocKeys(System.String ancientEntry)
public System.Void set_AgnosticDialogues(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogue> value)
public System.Void set_CharacterDialogues(System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogue>> value)
public System.Void set_FirstVisitEverDialogue(MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogue value)
```

## MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogueSet+<>c__DisplayClass13_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.Int32 charVisits
public .ctor()
internal System.Boolean <GetValidDialogues>b__0(MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogue d)
internal System.Boolean <GetValidDialogues>b__1(MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogue d)
```

## MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogueSet+<GetAllDialogues>d__12

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：`System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogue>`, `System.Collections.IEnumerable`, `System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogue>`, `System.Collections.IEnumerator`, `System.IDisposable`

```text
private System.Int32 <>1__state
private MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogue <>2__current
public MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogueSet <>4__this
private System.Collections.Generic.Dictionary+ValueCollection+Enumerator<System.String, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogue>> <>7__wrap1
private System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogue> <>7__wrap2
private System.Int32 <>l__initialThreadId
MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogue System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogue>.Current { private virtual get; }
System.Object System.Collections.IEnumerator.Current { private virtual get; }
public .ctor(System.Int32 <>1__state)
private System.Void <>m__Finally1()
private System.Void <>m__Finally2()
private System.Void <>m__Finally3()
private virtual MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogue System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogue>.get_Current()
private virtual System.Boolean MoveNext()
private virtual System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogue> System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogue>.GetEnumerator()
private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
private virtual System.Object System.Collections.IEnumerator.get_Current()
private virtual System.Void System.Collections.IEnumerator.Reset()
private virtual System.Void System.IDisposable.Dispose()
```

## MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogueSpeaker

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogueSpeaker Ancient = 1
public static const MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogueSpeaker Character = 2
public static const MegaCrit.Sts2.Core.Entities.Ancients.AncientDialogueSpeaker None = 0
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Entities.Ancients.ArchitectAttackers

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Entities.Ancients.ArchitectAttackers Architect = 2
public static const MegaCrit.Sts2.Core.Entities.Ancients.ArchitectAttackers Both = 3
public static const MegaCrit.Sts2.Core.Entities.Ancients.ArchitectAttackers None = 0
public static const MegaCrit.Sts2.Core.Entities.Ancients.ArchitectAttackers Player = 1
public System.Int32 value__
```
