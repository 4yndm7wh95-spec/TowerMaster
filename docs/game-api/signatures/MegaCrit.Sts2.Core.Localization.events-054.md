# MegaCrit.Sts2.Core.Localization

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。


## MegaCrit.Sts2.Core.Localization.LocManager

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static readonly System.Collections.Generic.Dictionary<System.String, System.String> _cultureCodeByLanguage
private static readonly System.Globalization.CultureInfo _englishCultureInfo
private System.Collections.Generic.Dictionary<System.String, MegaCrit.Sts2.Core.Localization.LocTable> _engTables
private static readonly System.Collections.Generic.Dictionary<System.String, System.String> _gameToWeblateLanguage
private System.Collections.Generic.Dictionary<System.String, System.Int32> _languageKeyCount
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Localization.LocManager+LocaleChangeCallback> _localeChangeCallbacks
private static SmartFormat.SmartFormatter _smartFormatter
private MegaCrit.Sts2.Core.Localization.LocManager+PreOverrideState _stateBeforeOverridingWithEnglish
private static readonly System.ValueTuple<System.String, System.String>[] _supportedLanguages
private System.Collections.Generic.Dictionary<System.String, MegaCrit.Sts2.Core.Localization.LocTable> _tables
private static const System.String _weblateProjectSlug = "slaythespire2"
private static readonly System.Collections.Generic.Dictionary<System.String, System.String> _weblateToGameLanguage
private System.Globalization.CultureInfo <CultureInfo>k__BackingField
private static MegaCrit.Sts2.Core.Localization.LocManager <Instance>k__BackingField
private System.String <Language>k__BackingField
private static readonly System.Collections.Generic.List<System.String> <Languages>k__BackingField
private System.Boolean <OverridesActive>k__BackingField
private System.StringComparer <StringComparer>k__BackingField
private System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Localization.LocValidationError> <ValidationErrors>k__BackingField
public static const System.String locOverrideDir = "user://localization_override"
System.Globalization.CultureInfo CultureInfo { public get; private set; }
MegaCrit.Sts2.Core.Localization.LocManager Instance { public static get; private static set; }
System.String Language { public get; private set; }
System.Collections.Generic.List<System.String> Languages { public static get; }
System.String LocalizationAssetDir { private static get; }
System.Boolean OverridesActive { public get; private set; }
System.StringComparer StringComparer { public get; private set; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Localization.LocValidationError> ValidationErrors { public get; private set; }
private static .cctor()
public .ctor()
private static System.Boolean TryLoadOverrideFile(System.String overrideFilePath, MegaCrit.Sts2.Core.Localization.LocTable locTable, System.Collections.Generic.List<MegaCrit.Sts2.Core.Localization.LocValidationError> validationErrors)
private static System.Boolean TryLoadWeblateNestedOverrides(System.String globalizedOverrideDir, System.String language, System.String filename, MegaCrit.Sts2.Core.Localization.LocTable locTable, System.Collections.Generic.List<MegaCrit.Sts2.Core.Localization.LocValidationError> validationErrors)
private static System.Collections.Generic.Dictionary<System.String, System.String> LoadTable(System.String path)
private static System.Collections.Generic.IEnumerable<System.String> ListLocalizationFiles(System.String path)
private static System.Globalization.CultureInfo GetCultureInfoSafe(System.String name)
private static System.String ConvertToW(System.String input)
private static System.String get_LocalizationAssetDir()
private static System.String ToString(System.Collections.Generic.Dictionary<System.String, System.Object> variables)
private static System.ValueTuple<System.Collections.Generic.Dictionary<System.String, MegaCrit.Sts2.Core.Localization.LocTable>, System.Boolean, System.Collections.Generic.List<MegaCrit.Sts2.Core.Localization.LocValidationError>> LoadTablesFromPath(System.String language, System.Boolean allowOverride = True)
private static System.Void set_Instance(MegaCrit.Sts2.Core.Localization.LocManager value)
private System.Globalization.CultureInfo CultureInfoFromThreeLetterCode(System.String language)
private System.Void LoadLocCompletionFile()
private System.Void LoadLocFormatters()
private System.Void set_CultureInfo(System.Globalization.CultureInfo value)
private System.Void set_Language(System.String value)
private System.Void set_OverridesActive(System.Boolean value)
private System.Void set_StringComparer(System.StringComparer value)
private System.Void set_ValidationErrors(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Localization.LocValidationError> value)
private System.Void SetLanguageInternal(System.String language, System.Collections.Generic.Dictionary<System.String, MegaCrit.Sts2.Core.Localization.LocTable> tables, System.Boolean overridesActive, System.Collections.Generic.List<MegaCrit.Sts2.Core.Localization.LocValidationError> validationErrors)
private System.Void TriggerLocaleChange()
public MegaCrit.Sts2.Core.Localization.LocTable GetTable(System.String name)
public static MegaCrit.Sts2.Core.Localization.LocManager get_Instance()
public static System.Collections.Generic.List<System.String> get_Languages()
public static System.Void Initialize()
public System.Boolean get_OverridesActive()
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Localization.LocValidationError> get_ValidationErrors()
public System.Globalization.CultureInfo get_CultureInfo()
public System.Single GetLanguageCompletion(System.String language)
public System.String get_Language()
public System.String SmartFormat(MegaCrit.Sts2.Core.Localization.LocString locString, System.Collections.Generic.Dictionary<System.String, System.Object> variables)
public System.StringComparer get_StringComparer()
public System.Void SetLanguage(System.String language)
public System.Void StartOverridingLanguageAsEnglish()
public System.Void StopOverridingLanguageAsEnglish()
public System.Void SubscribeToLocaleChange(MegaCrit.Sts2.Core.Localization.LocManager+LocaleChangeCallback callback)
public System.Void UnsubscribeToLocaleChange(MegaCrit.Sts2.Core.Localization.LocManager+LocaleChangeCallback callback)
```

## MegaCrit.Sts2.Core.Localization.LocString

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：`System.IComparable<MegaCrit.Sts2.Core.Localization.LocString>`

```text
private readonly System.Collections.Generic.Dictionary<System.String, System.Object> _variables
private System.String <locEntryKey>P
private System.String <locTable>P
System.Boolean IsEmpty { public get; }
System.Object Item[System.String key] { private get; private set; }
System.String LocEntryKey { public get; }
System.String LocTable { public get; }
System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object> Variables { public get; }
public .ctor(System.String locTable, System.String locEntryKey)
private System.Object get_Item(System.String key)
private System.Void set_Item(System.String key, System.Object value)
public static MegaCrit.Sts2.Core.Localization.LocString GetIfExists(System.String table, System.String key)
public static MegaCrit.Sts2.Core.Localization.LocString GetRandomWithPrefix(System.String table, System.String keyPrefix, MegaCrit.Sts2.Core.Random.Rng rng = null)
public static MegaCrit.Sts2.Core.Localization.LocString KeyPathToLocString(System.String keyPath)
public static System.Boolean Exists(System.String table, System.String key)
public static System.Boolean IsNullOrWhitespace(MegaCrit.Sts2.Core.Localization.LocString locString)
public static System.Void SubscribeToLocaleChange(MegaCrit.Sts2.Core.Localization.LocManager+LocaleChangeCallback callback)
public static System.Void UnsubscribeToLocaleChange(MegaCrit.Sts2.Core.Localization.LocManager+LocaleChangeCallback callback)
public System.Boolean Exists()
public System.Boolean get_IsEmpty()
public System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object> get_Variables()
public System.String get_LocEntryKey()
public System.String get_LocTable()
public System.String GetFormattedText()
public System.String GetRawText()
public System.Void Add(MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar dynamicVar)
public System.Void Add(System.String name, MegaCrit.Sts2.Core.Localization.LocString variable)
public System.Void Add(System.String name, System.Boolean variable)
public System.Void Add(System.String name, System.Collections.Generic.IList<System.String> variable)
public System.Void Add(System.String name, System.Decimal variable)
public System.Void Add(System.String name, System.String variable)
public System.Void AddObj(System.String name, System.Object variable)
public System.Void AddVariablesFrom(MegaCrit.Sts2.Core.Localization.LocString smartDescription)
public virtual System.Int32 CompareTo(MegaCrit.Sts2.Core.Localization.LocString other)
public virtual System.String ToString()
```

## MegaCrit.Sts2.Core.Localization.LocTable

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private readonly MegaCrit.Sts2.Core.Localization.LocTable _fallback
private readonly System.String _name
private readonly System.Collections.Generic.Dictionary<System.String, System.String> _translations
System.Collections.Generic.IEnumerable<System.String> Keys { public get; }
public .ctor(System.String name, System.Collections.Generic.Dictionary<System.String, System.String> data, MegaCrit.Sts2.Core.Localization.LocTable fallback = null)
public MegaCrit.Sts2.Core.Localization.LocString GetLocString(System.String key)
public System.Boolean HasEntry(System.String key)
public System.Boolean IsLocalKey(System.String key)
public System.Collections.Generic.IEnumerable<System.String> get_Keys()
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Localization.LocString> GetLocStringsWithPrefix(System.String keyPrefix)
public System.String GetRawText(System.String key)
public System.Void MergeWith(System.Collections.Generic.Dictionary<System.String, System.String> otherTable)
```

