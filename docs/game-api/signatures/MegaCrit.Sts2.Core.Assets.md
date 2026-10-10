# MegaCrit.Sts2.Core.Assets

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Assets.AssetCache

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private readonly System.Collections.Concurrent.ConcurrentDictionary<System.String, Godot.Resource> _cache
private readonly System.Collections.Generic.HashSet<System.String> _failedAssets
private readonly System.Collections.Generic.HashSet<System.String> _missedCacheAssets
System.Int32 MissedCacheAssetCount { public get; }
public .ctor()
private Godot.Resource GetAsset(System.String path)
private Godot.Resource LoadAsset(System.String path)
private Godot.Resource RemoveAndGetResource(System.String key)
public Godot.CompressedTexture2D GetCompressedTexture2D(System.String path)
public Godot.Material GetMaterial(System.String path)
public Godot.PackedScene GetScene(System.String path)
public Godot.Texture2D GetTexture2D(System.String path)
public MegaCrit.Sts2.Core.Assets.AssetLoadingSession CreateSession(System.String name, System.Collections.Generic.IEnumerable<System.String> paths)
public System.Boolean ContainsKey(System.String s)
public System.Collections.Generic.IEnumerable<System.String> GetCacheKeys()
public System.Collections.Generic.IReadOnlySet<System.String> GetLoadedCacheAssets()
public System.Int32 get_MissedCacheAssetCount()
public System.Void MarkAssetFailed(System.String path)
public System.Void SetAsset(System.String path, Godot.Resource resource)
public System.Void UnloadAssets(System.Collections.Generic.IEnumerable<System.String> assetsToUnloadSet)
public System.Void UnloadMissedCacheAssets()
public TS GetAsset<TS>(System.String path) where TS: [None] Godot.Resource
```

## MegaCrit.Sts2.Core.Assets.AssetLoadException

类型属性：`Public, BeforeFieldInit`；基类：`System.Exception`。

接口：`System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.String message, System.Exception innerException)
public .ctor(System.String message)
```

## MegaCrit.Sts2.Core.Assets.AssetLoadingSession

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private readonly MegaCrit.Sts2.Core.Assets.AssetCache _assetCache
private static const System.Int32 _batchSize = 128
private readonly System.Collections.Concurrent.ConcurrentDictionary<System.String, Godot.Resource> _cache
private readonly System.Threading.Tasks.TaskCompletionSource<System.Boolean> _completionSource
private System.String _currentVfxPath
private readonly System.Collections.Generic.Queue<System.String> _finalizing
private readonly System.Collections.Generic.Queue<System.String> _loading
private readonly System.String _name
private readonly System.Diagnostics.Stopwatch _stopwatch
private readonly System.Collections.Generic.Queue<System.String> _toLoad
private System.Int32 _totalLoaded
private System.Boolean _vfxLoading
private readonly System.Collections.Generic.Queue<System.String> _vfxScenes
System.Boolean IsCompleted { public get; }
System.Threading.Tasks.Task<System.Boolean> Task { public get; }
private .ctor()
public .ctor(System.String name, System.Collections.Generic.IEnumerable<System.String> paths, System.Collections.Concurrent.ConcurrentDictionary<System.String, Godot.Resource> cache, MegaCrit.Sts2.Core.Assets.AssetCache assetCache = null)
private static System.Boolean IsVfxScene(System.String path)
private System.Void AddToCache(Godot.Resource resource, System.String path)
private System.Void CheckLoadingStatus()
private System.Void FinalizeLoading()
private System.Void ProcessLoadingQueue()
private System.Void ProcessVfxQueue()
public static MegaCrit.Sts2.Core.Assets.AssetLoadingSession Empty()
public System.Boolean get_IsCompleted()
public System.Threading.Tasks.Task WaitForCompletion()
public System.Threading.Tasks.Task<System.Boolean> get_Task()
public System.Void PrintStatus()
public System.Void Process()
```

## MegaCrit.Sts2.Core.Assets.AssetSets

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static System.Collections.Generic.IReadOnlySet<System.String> <Act>k__BackingField
private static readonly System.Collections.Generic.IReadOnlySet<System.String> <CommonAssets>k__BackingField
private static readonly System.Collections.Generic.IReadOnlySet<System.String> <IntroLogoAssets>k__BackingField
private static readonly System.Collections.Generic.IReadOnlySet<System.String> <MainMenuEssentials>k__BackingField
private static readonly System.Collections.Generic.IReadOnlySet<System.String> <MainMenuSet>k__BackingField
private static System.Collections.Generic.IReadOnlySet<System.String> <RunSet>k__BackingField
System.Collections.Generic.IReadOnlySet<System.String> Act { public static get; public static set; }
System.Collections.Generic.IEnumerable<System.String> CardMaterialPaths { private static get; }
System.Collections.Generic.IReadOnlySet<System.String> CommonAssets { public static get; }
System.Collections.Generic.IReadOnlySet<System.String> IntroLogoAssets { public static get; }
System.Collections.Generic.IReadOnlySet<System.String> MainMenuEssentials { public static get; }
System.Collections.Generic.IReadOnlySet<System.String> MainMenuSet { public static get; }
System.Collections.Generic.IReadOnlySet<System.String> RunSet { public static get; public static set; }
private static .cctor()
private static System.Collections.Generic.IEnumerable<System.String> get_CardMaterialPaths()
public static System.Collections.Generic.IReadOnlySet<System.String> get_Act()
public static System.Collections.Generic.IReadOnlySet<System.String> get_CommonAssets()
public static System.Collections.Generic.IReadOnlySet<System.String> get_IntroLogoAssets()
public static System.Collections.Generic.IReadOnlySet<System.String> get_MainMenuEssentials()
public static System.Collections.Generic.IReadOnlySet<System.String> get_MainMenuSet()
public static System.Collections.Generic.IReadOnlySet<System.String> get_RunSet()
public static System.Void set_Act(System.Collections.Generic.IReadOnlySet<System.String> value)
public static System.Void set_RunSet(System.Collections.Generic.IReadOnlySet<System.String> value)
```

## MegaCrit.Sts2.Core.Assets.AssetSets+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Assets.AssetSets+<>c <>9
private static .cctor()
public .ctor()
internal System.Collections.Generic.IEnumerable<System.String> <.cctor>b__22_0(MegaCrit.Sts2.Core.Rewards.RewardType t)
internal System.Collections.Generic.IEnumerable<System.String> <.cctor>b__22_1(System.Collections.Generic.IEnumerable<System.String> s)
internal System.Collections.Generic.IEnumerable<System.String> <.cctor>b__22_2(MegaCrit.Sts2.Core.Models.CharacterModel character)
internal System.Collections.Generic.IEnumerable<System.String> <.cctor>b__22_3(System.Collections.Generic.IEnumerable<System.String> s)
```

## MegaCrit.Sts2.Core.Assets.AtlasManager

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static readonly System.Collections.Concurrent.ConcurrentDictionary<System.String, MegaCrit.Sts2.Core.Assets.AtlasManager+AtlasData> _atlases
private static readonly System.String[] _essentialAtlases
private static readonly System.Text.Json.JsonSerializerOptions _jsonOptions
private static readonly System.String[] _knownAtlases
private static readonly System.Threading.Lock _loadLock
private static readonly System.Collections.Concurrent.ConcurrentDictionary<System.String, Godot.AtlasTexture> _spriteCache
private static .cctor()
private static Godot.AtlasTexture CreateAtlasTexture(MegaCrit.Sts2.Core.Assets.AtlasManager+SpriteInfo spriteInfo)
private static System.String NormalizeSpriteKey(System.String filename)
private static System.Void LoadAtlasInternal(System.String atlasName)
public static Godot.AtlasTexture GetSprite(System.String atlasName, System.String spriteName)
public static System.Boolean HasSprite(System.String atlasName, System.String spriteName)
public static System.Boolean IsAtlasLoaded(System.String atlasName)
public static System.Int32 GetSpriteCount(System.String atlasName)
public static System.Void Clear()
public static System.Void LoadAllAtlases()
public static System.Void LoadAtlas(System.String atlasName)
public static System.Void LoadEssentialAtlases()
```

## MegaCrit.Sts2.Core.Assets.AtlasManager+<>c__DisplayClass10_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Assets.AtlasManager+SpriteInfo spriteInfo
public .ctor()
internal Godot.AtlasTexture <GetSprite>b__0(System.String _)
```

## MegaCrit.Sts2.Core.Assets.AtlasManager+AtlasData

类型属性：`NestedPrivate, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private readonly System.Collections.Generic.Dictionary<System.String, Godot.Texture2D> <PageTextures>k__BackingField
private readonly System.Collections.Generic.Dictionary<System.String, MegaCrit.Sts2.Core.Assets.AtlasManager+SpriteInfo> <SpriteMap>k__BackingField
private readonly MegaCrit.Sts2.Core.Assets.TpSheetData <TpSheet>k__BackingField
System.Collections.Generic.Dictionary<System.String, Godot.Texture2D> PageTextures { public get; public set; }
System.Collections.Generic.Dictionary<System.String, MegaCrit.Sts2.Core.Assets.AtlasManager+SpriteInfo> SpriteMap { public get; public set; }
MegaCrit.Sts2.Core.Assets.TpSheetData TpSheet { public get; public set; }
public .ctor()
public MegaCrit.Sts2.Core.Assets.TpSheetData get_TpSheet()
public System.Collections.Generic.Dictionary<System.String, Godot.Texture2D> get_PageTextures()
public System.Collections.Generic.Dictionary<System.String, MegaCrit.Sts2.Core.Assets.AtlasManager+SpriteInfo> get_SpriteMap()
public System.Void set_PageTextures(System.Collections.Generic.Dictionary<System.String, Godot.Texture2D> value)
public System.Void set_SpriteMap(System.Collections.Generic.Dictionary<System.String, MegaCrit.Sts2.Core.Assets.AtlasManager+SpriteInfo> value)
public System.Void set_TpSheet(MegaCrit.Sts2.Core.Assets.TpSheetData value)
```

## MegaCrit.Sts2.Core.Assets.AtlasManager+SpriteInfo

类型属性：`NestedPrivate, BeforeFieldInit`；基类：`System.Object`。

接口：`System.IEquatable<MegaCrit.Sts2.Core.Assets.AtlasManager+SpriteInfo>`

```text
private readonly Godot.Texture2D <Atlas>k__BackingField
private readonly MegaCrit.Sts2.Core.Assets.TpSheetSprite <Sprite>k__BackingField
Godot.Texture2D Atlas { public get; public set; }
System.Type EqualityContract { protected virtual get; }
MegaCrit.Sts2.Core.Assets.TpSheetSprite Sprite { public get; public set; }
protected .ctor(MegaCrit.Sts2.Core.Assets.AtlasManager+SpriteInfo original)
public .ctor(Godot.Texture2D Atlas, MegaCrit.Sts2.Core.Assets.TpSheetSprite Sprite)
protected virtual System.Boolean PrintMembers(System.Text.StringBuilder builder)
protected virtual System.Type get_EqualityContract()
public Godot.Texture2D get_Atlas()
public MegaCrit.Sts2.Core.Assets.TpSheetSprite get_Sprite()
public static System.Boolean op_Equality(MegaCrit.Sts2.Core.Assets.AtlasManager+SpriteInfo left, MegaCrit.Sts2.Core.Assets.AtlasManager+SpriteInfo right)
public static System.Boolean op_Inequality(MegaCrit.Sts2.Core.Assets.AtlasManager+SpriteInfo left, MegaCrit.Sts2.Core.Assets.AtlasManager+SpriteInfo right)
public System.Void Deconstruct(out Godot.Texture2D Atlas, out MegaCrit.Sts2.Core.Assets.TpSheetSprite Sprite)
public System.Void set_Atlas(Godot.Texture2D value)
public System.Void set_Sprite(MegaCrit.Sts2.Core.Assets.TpSheetSprite value)
public virtual MegaCrit.Sts2.Core.Assets.AtlasManager+SpriteInfo <Clone>$()
public virtual System.Boolean Equals(MegaCrit.Sts2.Core.Assets.AtlasManager+SpriteInfo other)
public virtual System.Boolean Equals(System.Object obj)
public virtual System.Int32 GetHashCode()
public virtual System.String ToString()
```

## MegaCrit.Sts2.Core.Assets.AtlasResourceLoader

类型属性：`Public, BeforeFieldInit`；基类：`Godot.ResourceFormatLoader`。

接口：`System.IDisposable`

```text
private static const System.String _atlasBasePath = "res://images/atlases/"
private static readonly System.Text.RegularExpressions.Regex _pathPattern
private static const System.String _spritesSuffix = ".sprites/"
private static readonly Godot.StringName _typeAtlasTexture
private static readonly Godot.StringName _typeResource
private static readonly Godot.StringName _typeTexture2D
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
private static Godot.Texture2D LoadFallback(System.String atlasName, System.String spriteName)
private static Godot.Variant GetMissingTexture(System.String atlasName)
private static System.Boolean HasFallback(System.String atlasName, System.String spriteName)
private static System.Boolean IsSpritePath(System.String path)
private static System.String GetCardFallbackPath(System.String spriteName)
private static System.String GetFallbackPath(System.String atlasName, System.String spriteName)
private static System.String GetPotionFallbackPath(System.String spriteName)
private static System.String GetPowerFallbackPath(System.String spriteName)
private static System.String GetRelicFallbackPath(System.String spriteName)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static System.ValueTuple<System.String, System.String> ParsePath(System.String path)
public virtual Godot.Variant _Load(System.String path, System.String originalPath, System.Boolean useSubThreads, System.Int32 cacheMode)
public virtual System.Boolean _Exists(System.String path)
public virtual System.Boolean _HandlesType(Godot.StringName type)
public virtual System.Boolean _RecognizePath(System.String path, Godot.StringName type)
public virtual System.String _GetResourceType(System.String path)
public virtual System.String[] _GetDependencies(System.String path, System.Boolean addTypes)
public virtual System.String[] _GetRecognizedExtensions()
```

## MegaCrit.Sts2.Core.Assets.AtlasResourceLoader+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.ResourceFormatLoader+MethodName`。

接口：

```text
public static readonly Godot.StringName _Exists
public static readonly Godot.StringName _GetDependencies
public static readonly Godot.StringName _GetRecognizedExtensions
public static readonly Godot.StringName _GetResourceType
public static readonly Godot.StringName _HandlesType
public static readonly Godot.StringName _Load
public static readonly Godot.StringName _RecognizePath
public static readonly Godot.StringName GetCardFallbackPath
public static readonly Godot.StringName GetFallbackPath
public static readonly Godot.StringName GetMissingTexture
public static readonly Godot.StringName GetPotionFallbackPath
public static readonly Godot.StringName GetPowerFallbackPath
public static readonly Godot.StringName GetRelicFallbackPath
public static readonly Godot.StringName HasFallback
public static readonly Godot.StringName IsSpritePath
public static readonly Godot.StringName LoadFallback
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Assets.AtlasResourceLoader+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.ResourceFormatLoader+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Assets.AtlasResourceLoader+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.ResourceFormatLoader+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Assets.PreloadManager

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static readonly MegaCrit.Sts2.Core.Assets.AssetCache <Cache>k__BackingField
private static System.Boolean <Enabled>k__BackingField
MegaCrit.Sts2.Core.Assets.AssetCache Cache { public static get; }
System.Boolean Enabled { public static get; public static set; }
private static .cctor()
private static [async] System.Threading.Tasks.Task LoadRoomAssets(System.String roomName, System.Collections.Generic.IEnumerable<System.String> additionalAssets)
private static [async] System.Threading.Tasks.Task<MegaCrit.Sts2.Core.Assets.AssetLoadingSession> LoadAssetSets(System.String name, params System.Collections.Generic.IEnumerable<System.String>[] assetSets)
private static MegaCrit.Sts2.Core.Assets.AssetLoadingSession LoadAssets(System.Collections.Generic.IEnumerable<System.String> assetPaths, System.String name)
private static System.Collections.Generic.IEnumerable<System.String> GetCombatAssetPaths(MegaCrit.Sts2.Core.Models.EncounterModel encounter, MegaCrit.Sts2.Core.Runs.IRunState runState)
private static System.Collections.Generic.IEnumerable<System.String> GetRunAssetPaths(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CharacterModel> characters, System.Boolean isMultiplayer)
public static [async] System.Threading.Tasks.Task LoadActAssets(MegaCrit.Sts2.Core.Models.ActModel act)
public static [async] System.Threading.Tasks.Task LoadCommonAndMainMenuAssets()
public static [async] System.Threading.Tasks.Task LoadLogoAnimation()
public static [async] System.Threading.Tasks.Task LoadMainMenuAssets()
public static [async] System.Threading.Tasks.Task LoadMainMenuEssentials()
public static [async] System.Threading.Tasks.Task LoadRoomCombatAssets(MegaCrit.Sts2.Core.Models.EncounterModel encounter, MegaCrit.Sts2.Core.Runs.IRunState runState)
public static [async] System.Threading.Tasks.Task LoadRoomEventAssets(MegaCrit.Sts2.Core.Models.EventModel eventModel, MegaCrit.Sts2.Core.Runs.IRunState runState)
public static [async] System.Threading.Tasks.Task LoadRoomMerchantAssets()
public static [async] System.Threading.Tasks.Task LoadRoomRestSite(MegaCrit.Sts2.Core.Models.ActModel actModel, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption> restSiteOptions)
public static [async] System.Threading.Tasks.Task LoadRoomTreasureAssets(MegaCrit.Sts2.Core.Models.ActModel actModel)
public static [async] System.Threading.Tasks.Task LoadRunAssets(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CharacterModel> characters)
public static MegaCrit.Sts2.Core.Assets.AssetCache get_Cache()
public static System.Boolean get_Enabled()
public static System.Void set_Enabled(System.Boolean value)
```

## MegaCrit.Sts2.Core.Assets.PreloadManager+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Assets.PreloadManager+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Models.CharacterModel, System.String> <>9__11_0
public static System.Func<MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption, System.Collections.Generic.IEnumerable<System.String>> <>9__17_0
public static System.Func<System.Collections.Generic.IEnumerable<System.String>, System.Collections.Generic.IEnumerable<System.String>> <>9__19_0
public static System.Func<MegaCrit.Sts2.Core.Models.CardPoolModel, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> <>9__21_0
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> <>9__21_1
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Collections.Generic.IEnumerable<System.String>> <>9__21_2
public static System.Func<MegaCrit.Sts2.Core.Models.CharacterModel, System.Collections.Generic.IEnumerable<System.String>> <>9__21_3
public static System.Func<MegaCrit.Sts2.Core.Models.CharacterModel, System.Collections.Generic.IEnumerable<System.String>> <>9__21_4
public static System.Func<MegaCrit.Sts2.Core.Models.EnchantmentModel, System.String> <>9__21_5
public static System.Func<System.String, System.Boolean> <>9__21_6
public static System.Func<MegaCrit.Sts2.Core.Models.CardPoolModel, System.String> <>9__21_7
public static System.Func<System.Collections.Generic.IEnumerable<System.String>, System.Collections.Generic.IEnumerable<System.String>> <>9__21_8
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Collections.Generic.IEnumerable<System.String>> <>9__21_9
public static System.Func<System.Collections.Generic.IEnumerable<System.String>, System.Collections.Generic.IEnumerable<System.String>> <>9__22_0
private static .cctor()
public .ctor()
internal System.Boolean <GetRunAssetPaths>b__21_1(MegaCrit.Sts2.Core.Models.CardModel card)
internal System.Boolean <GetRunAssetPaths>b__21_6(System.String p)
internal System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> <GetRunAssetPaths>b__21_0(MegaCrit.Sts2.Core.Models.CardPoolModel pool)
internal System.Collections.Generic.IEnumerable<System.String> <GetCombatAssetPaths>b__22_0(System.Collections.Generic.IEnumerable<System.String> s)
internal System.Collections.Generic.IEnumerable<System.String> <GetRunAssetPaths>b__21_2(MegaCrit.Sts2.Core.Models.CardModel card)
internal System.Collections.Generic.IEnumerable<System.String> <GetRunAssetPaths>b__21_3(MegaCrit.Sts2.Core.Models.CharacterModel c)
internal System.Collections.Generic.IEnumerable<System.String> <GetRunAssetPaths>b__21_4(MegaCrit.Sts2.Core.Models.CharacterModel c)
internal System.Collections.Generic.IEnumerable<System.String> <GetRunAssetPaths>b__21_8(System.Collections.Generic.IEnumerable<System.String> s)
internal System.Collections.Generic.IEnumerable<System.String> <GetRunAssetPaths>b__21_9(MegaCrit.Sts2.Core.Models.CardModel card)
internal System.Collections.Generic.IEnumerable<System.String> <LoadAssetSets>b__19_0(System.Collections.Generic.IEnumerable<System.String> set)
internal System.Collections.Generic.IEnumerable<System.String> <LoadRoomRestSite>b__17_0(MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption s)
internal System.String <GetRunAssetPaths>b__21_5(MegaCrit.Sts2.Core.Models.EnchantmentModel e)
internal System.String <GetRunAssetPaths>b__21_7(MegaCrit.Sts2.Core.Models.CardPoolModel p)
internal System.String <LoadRunAssets>b__11_0(MegaCrit.Sts2.Core.Models.CharacterModel c)
```

## MegaCrit.Sts2.Core.Assets.PreloadManager+<LoadActAssets>d__12

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Assets.AssetLoadingSession> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
public MegaCrit.Sts2.Core.Models.ActModel act
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Assets.PreloadManager+<LoadAssetSets>d__19

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<MegaCrit.Sts2.Core.Assets.AssetLoadingSession> <>t__builder
private System.Runtime.CompilerServices.YieldAwaitable+YieldAwaiter <>u__1
private System.Collections.Generic.IEnumerable<System.String> <needLoaded>5__2
public System.Collections.Generic.IEnumerable<System.String>[] assetSets
public System.String name
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Assets.PreloadManager+<LoadCommonAndMainMenuAssets>d__9

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Assets.AssetLoadingSession> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Assets.PreloadManager+<LoadLogoAnimation>d__7

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Assets.AssetLoadingSession> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Assets.PreloadManager+<LoadMainMenuAssets>d__10

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Assets.AssetLoadingSession> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Assets.PreloadManager+<LoadMainMenuEssentials>d__8

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Assets.AssetLoadingSession> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Assets.PreloadManager+<LoadRoomAssets>d__18

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Assets.AssetLoadingSession> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
public System.Collections.Generic.IEnumerable<System.String> additionalAssets
public System.String roomName
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Assets.PreloadManager+<LoadRoomCombatAssets>d__14

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.Models.EncounterModel encounter
public MegaCrit.Sts2.Core.Runs.IRunState runState
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Assets.PreloadManager+<LoadRoomEventAssets>d__13

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.Models.EventModel eventModel
public MegaCrit.Sts2.Core.Runs.IRunState runState
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Assets.PreloadManager+<LoadRoomMerchantAssets>d__16

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Assets.PreloadManager+<LoadRoomRestSite>d__17

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.Models.ActModel actModel
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption> restSiteOptions
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Assets.PreloadManager+<LoadRoomTreasureAssets>d__15

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.Models.ActModel actModel
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Assets.PreloadManager+<LoadRunAssets>d__11

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Assets.AssetLoadingSession> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CharacterModel> characters
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Assets.TpSheetData

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Assets.TpSheetTexture> <Textures>k__BackingField
System.Collections.Generic.List<MegaCrit.Sts2.Core.Assets.TpSheetTexture> Textures { public get; public set; }
public .ctor()
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Assets.TpSheetTexture> get_Textures()
public System.Void set_Textures(System.Collections.Generic.List<MegaCrit.Sts2.Core.Assets.TpSheetTexture> value)
```

## MegaCrit.Sts2.Core.Assets.TpSheetRect

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private System.Int32 <H>k__BackingField
private System.Int32 <W>k__BackingField
private System.Int32 <X>k__BackingField
private System.Int32 <Y>k__BackingField
System.Int32 H { public get; public set; }
System.Int32 W { public get; public set; }
System.Int32 X { public get; public set; }
System.Int32 Y { public get; public set; }
public .ctor()
public System.Int32 get_H()
public System.Int32 get_W()
public System.Int32 get_X()
public System.Int32 get_Y()
public System.Void set_H(System.Int32 value)
public System.Void set_W(System.Int32 value)
public System.Void set_X(System.Int32 value)
public System.Void set_Y(System.Int32 value)
```

## MegaCrit.Sts2.Core.Assets.TpSheetSize

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private System.Int32 <H>k__BackingField
private System.Int32 <W>k__BackingField
System.Int32 H { public get; public set; }
System.Int32 W { public get; public set; }
public .ctor()
public System.Int32 get_H()
public System.Int32 get_W()
public System.Void set_H(System.Int32 value)
public System.Void set_W(System.Int32 value)
```

## MegaCrit.Sts2.Core.Assets.TpSheetSprite

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private System.String <Filename>k__BackingField
private MegaCrit.Sts2.Core.Assets.TpSheetRect <Margin>k__BackingField
private MegaCrit.Sts2.Core.Assets.TpSheetRect <Region>k__BackingField
System.String Filename { public get; public set; }
MegaCrit.Sts2.Core.Assets.TpSheetRect Margin { public get; public set; }
MegaCrit.Sts2.Core.Assets.TpSheetRect Region { public get; public set; }
public .ctor()
public MegaCrit.Sts2.Core.Assets.TpSheetRect get_Margin()
public MegaCrit.Sts2.Core.Assets.TpSheetRect get_Region()
public System.String get_Filename()
public System.Void set_Filename(System.String value)
public System.Void set_Margin(MegaCrit.Sts2.Core.Assets.TpSheetRect value)
public System.Void set_Region(MegaCrit.Sts2.Core.Assets.TpSheetRect value)
```

## MegaCrit.Sts2.Core.Assets.TpSheetTexture

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private System.String <Image>k__BackingField
private MegaCrit.Sts2.Core.Assets.TpSheetSize <Size>k__BackingField
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Assets.TpSheetSprite> <Sprites>k__BackingField
System.String Image { public get; public set; }
MegaCrit.Sts2.Core.Assets.TpSheetSize Size { public get; public set; }
System.Collections.Generic.List<MegaCrit.Sts2.Core.Assets.TpSheetSprite> Sprites { public get; public set; }
public .ctor()
public MegaCrit.Sts2.Core.Assets.TpSheetSize get_Size()
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Assets.TpSheetSprite> get_Sprites()
public System.String get_Image()
public System.Void set_Image(System.String value)
public System.Void set_Size(MegaCrit.Sts2.Core.Assets.TpSheetSize value)
public System.Void set_Sprites(System.Collections.Generic.List<MegaCrit.Sts2.Core.Assets.TpSheetSprite> value)
```
