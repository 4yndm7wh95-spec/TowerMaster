# MegaCrit.Sts2.Core.Localization

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Localization.DynamicVarType

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Localization.DynamicVarType BaseDynamic = 1
public static const MegaCrit.Sts2.Core.Localization.DynamicVarType Bool = 5
public static const MegaCrit.Sts2.Core.Localization.DynamicVarType Decimal = 3
public static const MegaCrit.Sts2.Core.Localization.DynamicVarType DynamicString = 2
public static const MegaCrit.Sts2.Core.Localization.DynamicVarType None = 0
public static const MegaCrit.Sts2.Core.Localization.DynamicVarType String = 4
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Localization.LanguageCode

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private readonly System.String <Code>k__BackingField
System.String Code { public get; }
public .ctor(System.String code)
public System.Boolean IsValid()
public System.String get_Code()
public virtual System.String ToString()
```

## MegaCrit.Sts2.Core.Localization.LocException

类型属性：`Public, BeforeFieldInit`；基类：`System.Exception`。

接口：`System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.String message, System.Exception e)
public .ctor(System.String message)
```

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

## MegaCrit.Sts2.Core.Localization.LocManager+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Localization.LocManager+<>c <>9
public static System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.String> <>9__52_0
public static System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String> <>9__57_0
public static System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String> <>9__57_1
public static System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String> <>9__57_2
public static System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String> <>9__57_3
public static System.Func<System.String, System.Boolean> <>9__60_0
private static .cctor()
public .ctor()
internal System.Boolean <ListLocalizationFiles>b__60_0(System.String s)
internal System.String <.cctor>b__67_0(System.Collections.Generic.KeyValuePair<System.String, System.String> kvp)
internal System.String <.cctor>b__67_1(System.Collections.Generic.KeyValuePair<System.String, System.String> kvp)
internal System.String <.cctor>b__67_2(System.ValueTuple<System.String, System.String> entry)
internal System.String <.cctor>b__67_3(System.ValueTuple<System.String, System.String> entry)
internal System.String <.cctor>b__67_4(System.ValueTuple<System.String, System.String> entry)
internal System.String <LoadTablesFromPath>b__57_0(System.Collections.Generic.KeyValuePair<System.String, System.String> kvp)
internal System.String <LoadTablesFromPath>b__57_1(System.Collections.Generic.KeyValuePair<System.String, System.String> kvp)
internal System.String <LoadTablesFromPath>b__57_2(System.Collections.Generic.KeyValuePair<System.String, System.String> kvp)
internal System.String <LoadTablesFromPath>b__57_3(System.Collections.Generic.KeyValuePair<System.String, System.String> kvp)
internal System.String <ToString>b__52_0(System.Collections.Generic.KeyValuePair<System.String, System.Object> kp)
```

## MegaCrit.Sts2.Core.Localization.LocManager+<>c__DisplayClass50_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.String errorPattern
public .ctor()
internal System.Void <SmartFormat>b__0(Sentry.Scope scope)
```

## MegaCrit.Sts2.Core.Localization.LocManager+LocaleChangeCallback

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke()
```

## MegaCrit.Sts2.Core.Localization.LocManager+PreOverrideState

类型属性：`NestedPrivate, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.String language
public System.Boolean overridesActive
public System.Collections.Generic.Dictionary<System.String, MegaCrit.Sts2.Core.Localization.LocTable> tables
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Localization.LocValidationError> validationErrors
public .ctor()
```

## MegaCrit.Sts2.Core.Localization.LocManagerSerializerContext

类型属性：`BeforeFieldInit`；基类：`System.Text.Json.Serialization.JsonSerializerContext`。

接口：`System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver`, `System.Text.Json.Serialization.Metadata.IBuiltInJsonTypeInfoResolver`

```text
private System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Collections.Generic.Dictionary<System.String, System.Int32>> _DictionaryStringInt32
private System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Collections.Generic.Dictionary<System.String, System.String>> _DictionaryStringString
private System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Int32> _Int32
private System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.String> _String
private static readonly MegaCrit.Sts2.Core.Localization.LocManagerSerializerContext <Default>k__BackingField
private readonly System.Text.Json.JsonSerializerOptions <GeneratedSerializerOptions>k__BackingField
private static const System.Reflection.BindingFlags InstanceMemberBindingFlags = 52
private static readonly System.Text.Json.JsonSerializerOptions s_defaultOptions
MegaCrit.Sts2.Core.Localization.LocManagerSerializerContext Default { public static get; }
System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Collections.Generic.Dictionary<System.String, System.Int32>> DictionaryStringInt32 { public get; }
System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Collections.Generic.Dictionary<System.String, System.String>> DictionaryStringString { public get; }
System.Text.Json.JsonSerializerOptions GeneratedSerializerOptions { protected virtual get; }
System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Int32> Int32 { public get; }
System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.String> String { public get; }
private static .cctor()
public .ctor()
public .ctor(System.Text.Json.JsonSerializerOptions options)
private static System.Boolean TryGetTypeInfoForRuntimeCustomConverter<TJsonMetadataType>(System.Text.Json.JsonSerializerOptions options, out System.Text.Json.Serialization.Metadata.JsonTypeInfo<TJsonMetadataType> jsonTypeInfo) where TJsonMetadataType: [None]
private static System.Text.Json.Serialization.JsonConverter ExpandConverter(System.Type type, System.Text.Json.Serialization.JsonConverter converter, System.Text.Json.JsonSerializerOptions options, System.Boolean validateCanConvert = True)
private static System.Text.Json.Serialization.JsonConverter GetRuntimeConverterForType(System.Type type, System.Text.Json.JsonSerializerOptions options)
private System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Collections.Generic.Dictionary<System.String, System.Int32>> Create_DictionaryStringInt32(System.Text.Json.JsonSerializerOptions options)
private System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Collections.Generic.Dictionary<System.String, System.String>> Create_DictionaryStringString(System.Text.Json.JsonSerializerOptions options)
private System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Int32> Create_Int32(System.Text.Json.JsonSerializerOptions options)
private System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.String> Create_String(System.Text.Json.JsonSerializerOptions options)
private System.Void DictionaryStringInt32SerializeHandler(System.Text.Json.Utf8JsonWriter writer, System.Collections.Generic.Dictionary<System.String, System.Int32> value)
private System.Void DictionaryStringStringSerializeHandler(System.Text.Json.Utf8JsonWriter writer, System.Collections.Generic.Dictionary<System.String, System.String> value)
private virtual System.Text.Json.Serialization.Metadata.JsonTypeInfo global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver.GetTypeInfo(System.Type type, System.Text.Json.JsonSerializerOptions options)
protected virtual System.Text.Json.JsonSerializerOptions get_GeneratedSerializerOptions()
public static MegaCrit.Sts2.Core.Localization.LocManagerSerializerContext get_Default()
public System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Collections.Generic.Dictionary<System.String, System.Int32>> get_DictionaryStringInt32()
public System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Collections.Generic.Dictionary<System.String, System.String>> get_DictionaryStringString()
public System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Int32> get_Int32()
public System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.String> get_String()
public virtual System.Text.Json.Serialization.Metadata.JsonTypeInfo GetTypeInfo(System.Type type)
```

## MegaCrit.Sts2.Core.Localization.LocManagerSerializerContext+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Localization.LocManagerSerializerContext+<>c <>9
public static System.Func<System.Collections.Generic.Dictionary<System.String, System.Int32>> <>9__3_0
public static System.Func<System.Collections.Generic.Dictionary<System.String, System.String>> <>9__8_0
private static .cctor()
public .ctor()
internal System.Collections.Generic.Dictionary<System.String, System.Int32> <Create_DictionaryStringInt32>b__3_0()
internal System.Collections.Generic.Dictionary<System.String, System.String> <Create_DictionaryStringString>b__8_0()
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

## MegaCrit.Sts2.Core.Localization.LocStringVariablesJsonConverter

类型属性：`Public, BeforeFieldInit`；基类：`System.Text.Json.Serialization.JsonConverter<System.Collections.Generic.Dictionary<System.String, System.Object>>`。

接口：

```text
public .ctor()
public virtual System.Collections.Generic.Dictionary<System.String, System.Object> Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
public virtual System.Void Write(System.Text.Json.Utf8JsonWriter writer, System.Collections.Generic.Dictionary<System.String, System.Object> varDict, System.Text.Json.JsonSerializerOptions options)
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

## MegaCrit.Sts2.Core.Localization.LocTable+<>c__DisplayClass9_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Localization.LocTable <>4__this
public System.Func<System.String, System.Boolean> <>9__2
public System.String keyPrefix
public .ctor()
internal MegaCrit.Sts2.Core.Localization.LocString <GetLocStringsWithPrefix>b__1(System.String k)
internal System.Boolean <GetLocStringsWithPrefix>b__0(System.String k)
internal System.Boolean <GetLocStringsWithPrefix>b__2(System.String k)
```

## MegaCrit.Sts2.Core.Localization.LocTextLabel

类型属性：`Public, BeforeFieldInit`；基类：`Godot.RichTextLabel`。

接口：`System.IDisposable`

```text
private System.String _localizationKey
private System.String _localizationTable
private MegaCrit.Sts2.Core.Localization.LocString _locString
System.String LocalizationKey { public get; public set; }
System.String LocalizationTable { public get; public set; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void UpdateLocalization()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.String get_LocalizationKey()
public System.String get_LocalizationTable()
public System.Void set_LocalizationKey(System.String value)
public System.Void set_LocalizationTable(System.String value)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Localization.LocTextLabel+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.RichTextLabel+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName UpdateLocalization
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Localization.LocTextLabel+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.RichTextLabel+PropertyName`。

接口：

```text
public static readonly Godot.StringName _localizationKey
public static readonly Godot.StringName _localizationTable
public static readonly Godot.StringName LocalizationKey
public static readonly Godot.StringName LocalizationTable
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Localization.LocTextLabel+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.RichTextLabel+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Localization.LocValidationError

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：`System.IEquatable<MegaCrit.Sts2.Core.Localization.LocValidationError>`

```text
private readonly System.String <ErrorMessage>k__BackingField
private readonly System.String <FilePath>k__BackingField
private readonly System.String <Key>k__BackingField
System.Type EqualityContract { protected virtual get; }
System.String ErrorMessage { public get; public set; }
System.String FilePath { public get; public set; }
System.String Key { public get; public set; }
protected .ctor(MegaCrit.Sts2.Core.Localization.LocValidationError original)
public .ctor(System.String FilePath, System.String Key, System.String ErrorMessage)
protected virtual System.Boolean PrintMembers(System.Text.StringBuilder builder)
protected virtual System.Type get_EqualityContract()
public static System.Boolean op_Equality(MegaCrit.Sts2.Core.Localization.LocValidationError left, MegaCrit.Sts2.Core.Localization.LocValidationError right)
public static System.Boolean op_Inequality(MegaCrit.Sts2.Core.Localization.LocValidationError left, MegaCrit.Sts2.Core.Localization.LocValidationError right)
public System.String get_ErrorMessage()
public System.String get_FilePath()
public System.String get_Key()
public System.Void Deconstruct(out System.String FilePath, out System.String Key, out System.String ErrorMessage)
public System.Void set_ErrorMessage(System.String value)
public System.Void set_FilePath(System.String value)
public System.Void set_Key(System.String value)
public virtual MegaCrit.Sts2.Core.Localization.LocValidationError <Clone>$()
public virtual System.Boolean Equals(MegaCrit.Sts2.Core.Localization.LocValidationError other)
public virtual System.Boolean Equals(System.Object obj)
public virtual System.Int32 GetHashCode()
public virtual System.String ToString()
```

## MegaCrit.Sts2.Core.Localization.LocValidator

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static System.Boolean ValidateFormatString(System.String text, out System.String errorMessage)
```

## MegaCrit.Sts2.Core.Localization.SerializableDynamicVar

类型属性：`Public, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`MegaCrit.Sts2.Core.Multiplayer.Serialization.IPacketSerializable`

```text
public System.Boolean boolValue
public System.Decimal decimalValue
public System.String stringValue
public MegaCrit.Sts2.Core.Localization.DynamicVarType type
public static System.Nullable<MegaCrit.Sts2.Core.Localization.SerializableDynamicVar> FromDynamicVar(System.Object var)
public System.Object ToDynamicVar(System.String name)
public virtual System.Void Deserialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketReader reader)
public virtual System.Void Serialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketWriter writer)
```

## MegaCrit.Sts2.Core.Localization.SerializableDynamicVarDictionarySerializerContext

类型属性：`BeforeFieldInit`；基类：`System.Text.Json.Serialization.JsonSerializerContext`。

接口：`System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver`, `System.Text.Json.Serialization.Metadata.IBuiltInJsonTypeInfoResolver`

```text
private System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Boolean> _Boolean
private System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Decimal> _Decimal
private System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Collections.Generic.Dictionary<System.String, MegaCrit.Sts2.Core.Localization.SerializableDynamicVar>> _DictionaryStringSerializableDynamicVar
private System.Text.Json.Serialization.Metadata.JsonTypeInfo<MegaCrit.Sts2.Core.Localization.DynamicVarType> _DynamicVarType
private System.Text.Json.Serialization.Metadata.JsonTypeInfo<MegaCrit.Sts2.Core.Localization.SerializableDynamicVar> _SerializableDynamicVar
private System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.String> _String
private static readonly MegaCrit.Sts2.Core.Localization.SerializableDynamicVarDictionarySerializerContext <Default>k__BackingField
private readonly System.Text.Json.JsonSerializerOptions <GeneratedSerializerOptions>k__BackingField
private static const System.Reflection.BindingFlags InstanceMemberBindingFlags = 52
private static readonly System.Text.Json.JsonEncodedText PropName_bool_value
private static readonly System.Text.Json.JsonEncodedText PropName_decimal_value
private static readonly System.Text.Json.JsonEncodedText PropName_string_value
private static readonly System.Text.Json.JsonEncodedText PropName_type
private static readonly System.Text.Json.JsonSerializerOptions s_defaultOptions
System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Boolean> Boolean { public get; }
System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Decimal> Decimal { public get; }
MegaCrit.Sts2.Core.Localization.SerializableDynamicVarDictionarySerializerContext Default { public static get; }
System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Collections.Generic.Dictionary<System.String, MegaCrit.Sts2.Core.Localization.SerializableDynamicVar>> DictionaryStringSerializableDynamicVar { public get; }
System.Text.Json.Serialization.Metadata.JsonTypeInfo<MegaCrit.Sts2.Core.Localization.DynamicVarType> DynamicVarType { public get; }
System.Text.Json.JsonSerializerOptions GeneratedSerializerOptions { protected virtual get; }
System.Text.Json.Serialization.Metadata.JsonTypeInfo<MegaCrit.Sts2.Core.Localization.SerializableDynamicVar> SerializableDynamicVar { public get; }
System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.String> String { public get; }
private static .cctor()
public .ctor()
public .ctor(System.Text.Json.JsonSerializerOptions options)
private static System.Boolean TryGetTypeInfoForRuntimeCustomConverter<TJsonMetadataType>(System.Text.Json.JsonSerializerOptions options, out System.Text.Json.Serialization.Metadata.JsonTypeInfo<TJsonMetadataType> jsonTypeInfo) where TJsonMetadataType: [None]
private static System.Text.Json.Serialization.JsonConverter ExpandConverter(System.Type type, System.Text.Json.Serialization.JsonConverter converter, System.Text.Json.JsonSerializerOptions options, System.Boolean validateCanConvert = True)
private static System.Text.Json.Serialization.JsonConverter GetRuntimeConverterForType(System.Type type, System.Text.Json.JsonSerializerOptions options)
private static System.Text.Json.Serialization.Metadata.JsonPropertyInfo[] SerializableDynamicVarPropInit(System.Text.Json.JsonSerializerOptions options)
private System.Text.Json.Serialization.Metadata.JsonTypeInfo<MegaCrit.Sts2.Core.Localization.DynamicVarType> Create_DynamicVarType(System.Text.Json.JsonSerializerOptions options)
private System.Text.Json.Serialization.Metadata.JsonTypeInfo<MegaCrit.Sts2.Core.Localization.SerializableDynamicVar> Create_SerializableDynamicVar(System.Text.Json.JsonSerializerOptions options)
private System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Boolean> Create_Boolean(System.Text.Json.JsonSerializerOptions options)
private System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Collections.Generic.Dictionary<System.String, MegaCrit.Sts2.Core.Localization.SerializableDynamicVar>> Create_DictionaryStringSerializableDynamicVar(System.Text.Json.JsonSerializerOptions options)
private System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Decimal> Create_Decimal(System.Text.Json.JsonSerializerOptions options)
private System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.String> Create_String(System.Text.Json.JsonSerializerOptions options)
private System.Void DictionaryStringSerializableDynamicVarSerializeHandler(System.Text.Json.Utf8JsonWriter writer, System.Collections.Generic.Dictionary<System.String, MegaCrit.Sts2.Core.Localization.SerializableDynamicVar> value)
private System.Void SerializableDynamicVarSerializeHandler(System.Text.Json.Utf8JsonWriter writer, MegaCrit.Sts2.Core.Localization.SerializableDynamicVar value)
private virtual System.Text.Json.Serialization.Metadata.JsonTypeInfo global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver.GetTypeInfo(System.Type type, System.Text.Json.JsonSerializerOptions options)
protected virtual System.Text.Json.JsonSerializerOptions get_GeneratedSerializerOptions()
public static MegaCrit.Sts2.Core.Localization.SerializableDynamicVarDictionarySerializerContext get_Default()
public System.Text.Json.Serialization.Metadata.JsonTypeInfo<MegaCrit.Sts2.Core.Localization.DynamicVarType> get_DynamicVarType()
public System.Text.Json.Serialization.Metadata.JsonTypeInfo<MegaCrit.Sts2.Core.Localization.SerializableDynamicVar> get_SerializableDynamicVar()
public System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Boolean> get_Boolean()
public System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Collections.Generic.Dictionary<System.String, MegaCrit.Sts2.Core.Localization.SerializableDynamicVar>> get_DictionaryStringSerializableDynamicVar()
public System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Decimal> get_Decimal()
public System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.String> get_String()
public virtual System.Text.Json.Serialization.Metadata.JsonTypeInfo GetTypeInfo(System.Type type)
```

## MegaCrit.Sts2.Core.Localization.SerializableDynamicVarDictionarySerializerContext+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Localization.SerializableDynamicVarDictionarySerializerContext+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Localization.SerializableDynamicVar> <>9__15_0
public static System.Func<System.Reflection.ICustomAttributeProvider> <>9__15_2
public static System.Func<System.Object, MegaCrit.Sts2.Core.Localization.DynamicVarType> <>9__16_0
public static System.Action<System.Object, MegaCrit.Sts2.Core.Localization.DynamicVarType> <>9__16_1
public static System.Action<System.Object, System.String> <>9__16_10
public static System.Func<System.Reflection.ICustomAttributeProvider> <>9__16_11
public static System.Func<System.Reflection.ICustomAttributeProvider> <>9__16_2
public static System.Func<System.Object, System.Decimal> <>9__16_3
public static System.Action<System.Object, System.Decimal> <>9__16_4
public static System.Func<System.Reflection.ICustomAttributeProvider> <>9__16_5
public static System.Func<System.Object, System.Boolean> <>9__16_6
public static System.Action<System.Object, System.Boolean> <>9__16_7
public static System.Func<System.Reflection.ICustomAttributeProvider> <>9__16_8
public static System.Func<System.Object, System.String> <>9__16_9
public static System.Func<System.Collections.Generic.Dictionary<System.String, MegaCrit.Sts2.Core.Localization.SerializableDynamicVar>> <>9__21_0
private static .cctor()
public .ctor()
internal MegaCrit.Sts2.Core.Localization.DynamicVarType <SerializableDynamicVarPropInit>b__16_0(System.Object obj)
internal MegaCrit.Sts2.Core.Localization.SerializableDynamicVar <Create_SerializableDynamicVar>b__15_0()
internal System.Boolean <SerializableDynamicVarPropInit>b__16_6(System.Object obj)
internal System.Collections.Generic.Dictionary<System.String, MegaCrit.Sts2.Core.Localization.SerializableDynamicVar> <Create_DictionaryStringSerializableDynamicVar>b__21_0()
internal System.Decimal <SerializableDynamicVarPropInit>b__16_3(System.Object obj)
internal System.Reflection.ICustomAttributeProvider <Create_SerializableDynamicVar>b__15_2()
internal System.Reflection.ICustomAttributeProvider <SerializableDynamicVarPropInit>b__16_11()
internal System.Reflection.ICustomAttributeProvider <SerializableDynamicVarPropInit>b__16_2()
internal System.Reflection.ICustomAttributeProvider <SerializableDynamicVarPropInit>b__16_5()
internal System.Reflection.ICustomAttributeProvider <SerializableDynamicVarPropInit>b__16_8()
internal System.String <SerializableDynamicVarPropInit>b__16_9(System.Object obj)
internal System.Void <SerializableDynamicVarPropInit>b__16_1(System.Object obj, MegaCrit.Sts2.Core.Localization.DynamicVarType value)
internal System.Void <SerializableDynamicVarPropInit>b__16_10(System.Object obj, System.String value)
internal System.Void <SerializableDynamicVarPropInit>b__16_4(System.Object obj, System.Decimal value)
internal System.Void <SerializableDynamicVarPropInit>b__16_7(System.Object obj, System.Boolean value)
```

## MegaCrit.Sts2.Core.Localization.SerializableDynamicVarDictionarySerializerContext+<>c__DisplayClass15_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.Text.Json.JsonSerializerOptions options
public .ctor()
internal System.Text.Json.Serialization.Metadata.JsonPropertyInfo[] <Create_SerializableDynamicVar>b__1(System.Text.Json.Serialization.JsonSerializerContext _)
```

## MegaCrit.Sts2.Core.Localization.UpgradeDisplay

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Localization.UpgradeDisplay Normal = 0
public static const MegaCrit.Sts2.Core.Localization.UpgradeDisplay Upgraded = 1
public static const MegaCrit.Sts2.Core.Localization.UpgradeDisplay UpgradePreview = 2
public System.Int32 value__
```
