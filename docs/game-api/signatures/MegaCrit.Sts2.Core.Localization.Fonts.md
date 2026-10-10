# MegaCrit.Sts2.Core.Localization.Fonts

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Localization.Fonts.FontControlUtils

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static System.Void ApplyLocaleFontSubstitution(Godot.Control control, MegaCrit.Sts2.Core.Localization.Fonts.FontType fontType, Godot.StringName themeFontName)
```

## MegaCrit.Sts2.Core.Localization.Fonts.FontManager

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static readonly System.Collections.Generic.IReadOnlyDictionary<System.String, MegaCrit.Sts2.Core.Localization.Fonts.FontPathSet> _languageFontPathSets
private static readonly System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<MegaCrit.Sts2.Core.Localization.Fonts.FontType, Godot.Font>> _localeFonts
private static readonly MegaCrit.Sts2.Core.Localization.Fonts.FontPathSet _russian
private static .cctor()
private static Godot.Font GetFontForLanguage(System.String language, MegaCrit.Sts2.Core.Localization.Fonts.FontType type)
public static Godot.Font GetSubstituteFont(System.String language, MegaCrit.Sts2.Core.Localization.Fonts.FontType type)
public static System.Boolean NeedsFontSubstitution(System.String language)
public static System.Void ClearCache()
```

## MegaCrit.Sts2.Core.Localization.Fonts.FontPathSet

类型属性：`Public, Abstract, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
protected .ctor()
public abstract System.String GetPath(MegaCrit.Sts2.Core.Localization.Fonts.FontType type)
```

## MegaCrit.Sts2.Core.Localization.Fonts.FontType

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Localization.Fonts.FontType Bold = 1
public static const MegaCrit.Sts2.Core.Localization.Fonts.FontType Italic = 2
public static const MegaCrit.Sts2.Core.Localization.Fonts.FontType Regular = 0
public System.Int32 value__
```
