# MegaCrit.Sts2.Core.Helpers

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Helpers.AscensionHelper

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
System.Double PovertyAscensionGoldMultiplier { public static get; }
private static System.String GetKey(System.Int32 level)
public static MegaCrit.Sts2.Core.HoverTips.HoverTip GetHoverTip(MegaCrit.Sts2.Core.Models.CharacterModel character, System.Int32 level, System.Boolean achievementsLocked)
public static MegaCrit.Sts2.Core.Localization.LocString GetDescription(System.Int32 level)
public static MegaCrit.Sts2.Core.Localization.LocString GetTitle(System.Int32 level)
public static System.Boolean HasAscension(MegaCrit.Sts2.Core.Entities.Ascension.AscensionLevel level)
public static System.Decimal GetValueIfAscension(MegaCrit.Sts2.Core.Entities.Ascension.AscensionLevel level, System.Decimal ascensionValue, System.Decimal fallbackValue)
public static System.Double get_PovertyAscensionGoldMultiplier()
public static System.Int32 GetValueIfAscension(MegaCrit.Sts2.Core.Entities.Ascension.AscensionLevel level, System.Int32 ascensionValue, System.Int32 fallbackValue)
public static System.Single GetValueIfAscension(MegaCrit.Sts2.Core.Entities.Ascension.AscensionLevel level, System.Single ascensionValue, System.Single fallbackValue)
```

## MegaCrit.Sts2.Core.Helpers.BadWordChecker

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static readonly System.String[] _badWords
private static .cctor()
public static System.Boolean ContainsBadWord(System.String text)
```

## MegaCrit.Sts2.Core.Helpers.CommandLineHelper

类型属性：`Public, Abstract, Sealed`；基类：`System.Object`。

接口：

```text
private static readonly Godot.Collections.Dictionary<System.String, System.String> _args
private static .cctor()
public static System.Boolean HasArg(System.String key)
public static System.Boolean TryGetValue(System.String key, out System.String value)
public static System.String GetValue(System.String key)
```

## MegaCrit.Sts2.Core.Helpers.DisplayVars

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static const System.Single maxNarrowRatio = 1.3333334
public static const System.Single maxWideRatio = 2.3888888
```

## MegaCrit.Sts2.Core.Helpers.Ease

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static const System.Single _halfPi = 1.5707964
private static const System.Single _pi = 3.1415927
private static const System.Single _tolerance = 0.001
public static System.Single BackIn(System.Single p, System.Single strength = 1)
public static System.Single BackInOut(System.Single p, System.Single strength = 1)
public static System.Single BackOut(System.Single p, System.Single strength = 1)
public static System.Single BounceIn(System.Single p)
public static System.Single BounceInOut(System.Single p)
public static System.Single BounceOut(System.Single p)
public static System.Single CircIn(System.Single p)
public static System.Single CircInOut(System.Single p)
public static System.Single CircOut(System.Single p)
public static System.Single CubicIn(System.Single p)
public static System.Single CubicInOut(System.Single p)
public static System.Single CubicOut(System.Single p)
public static System.Single ElasticIn(System.Single p)
public static System.Single ElasticInOut(System.Single p)
public static System.Single ElasticOut(System.Single p)
public static System.Single ExpoIn(System.Single p)
public static System.Single ExpoInOut(System.Single p)
public static System.Single ExpoOut(System.Single p)
public static System.Single Interpolate(System.Single p, MegaCrit.Sts2.Core.Helpers.Ease+Functions function)
public static System.Single Linear(System.Single p)
public static System.Single QuadIn(System.Single p)
public static System.Single QuadInOut(System.Single p)
public static System.Single QuadOut(System.Single p)
public static System.Single QuartIn(System.Single p)
public static System.Single QuartInOut(System.Single p)
public static System.Single QuartOut(System.Single p)
public static System.Single QuintIn(System.Single p)
public static System.Single QuintInOut(System.Single p)
public static System.Single QuintOut(System.Single p)
public static System.Single SineIn(System.Single p)
public static System.Single SineInOut(System.Single p)
public static System.Single SineOut(System.Single p)
```

## MegaCrit.Sts2.Core.Helpers.Ease+Functions

类型属性：`NestedPublic, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Helpers.Ease+Functions BackIn = 24
public static const MegaCrit.Sts2.Core.Helpers.Ease+Functions BackInOut = 26
public static const MegaCrit.Sts2.Core.Helpers.Ease+Functions BackOut = 25
public static const MegaCrit.Sts2.Core.Helpers.Ease+Functions BounceIn = 27
public static const MegaCrit.Sts2.Core.Helpers.Ease+Functions BounceInOut = 29
public static const MegaCrit.Sts2.Core.Helpers.Ease+Functions BounceOut = 28
public static const MegaCrit.Sts2.Core.Helpers.Ease+Functions CircIn = 15
public static const MegaCrit.Sts2.Core.Helpers.Ease+Functions CircInOut = 17
public static const MegaCrit.Sts2.Core.Helpers.Ease+Functions CircOut = 16
public static const MegaCrit.Sts2.Core.Helpers.Ease+Functions CubicIn = 3
public static const MegaCrit.Sts2.Core.Helpers.Ease+Functions CubicInOut = 5
public static const MegaCrit.Sts2.Core.Helpers.Ease+Functions CubicOut = 4
public static const MegaCrit.Sts2.Core.Helpers.Ease+Functions ElasticIn = 21
public static const MegaCrit.Sts2.Core.Helpers.Ease+Functions ElasticInOut = 23
public static const MegaCrit.Sts2.Core.Helpers.Ease+Functions ElasticOut = 22
public static const MegaCrit.Sts2.Core.Helpers.Ease+Functions ExpoIn = 18
public static const MegaCrit.Sts2.Core.Helpers.Ease+Functions ExpoInOut = 20
public static const MegaCrit.Sts2.Core.Helpers.Ease+Functions ExpoOut = 19
public static const MegaCrit.Sts2.Core.Helpers.Ease+Functions QuadIn = 0
public static const MegaCrit.Sts2.Core.Helpers.Ease+Functions QuadInOut = 2
public static const MegaCrit.Sts2.Core.Helpers.Ease+Functions QuadOut = 1
public static const MegaCrit.Sts2.Core.Helpers.Ease+Functions QuartIn = 6
public static const MegaCrit.Sts2.Core.Helpers.Ease+Functions QuartInOut = 8
public static const MegaCrit.Sts2.Core.Helpers.Ease+Functions QuartOut = 7
public static const MegaCrit.Sts2.Core.Helpers.Ease+Functions QuinInOut = 11
public static const MegaCrit.Sts2.Core.Helpers.Ease+Functions QuinOut = 10
public static const MegaCrit.Sts2.Core.Helpers.Ease+Functions QuintIn = 9
public static const MegaCrit.Sts2.Core.Helpers.Ease+Functions SineIn = 12
public static const MegaCrit.Sts2.Core.Helpers.Ease+Functions SineInOut = 14
public static const MegaCrit.Sts2.Core.Helpers.Ease+Functions SineOut = 13
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Helpers.EnergyIconHelper

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static MegaCrit.Sts2.Core.Models.IPoolModel GetPool(MegaCrit.Sts2.Core.Models.AbstractModel model)
public static System.String GetPath(MegaCrit.Sts2.Core.Models.AbstractModel model)
public static System.String GetPath(System.String prefix)
public static System.String GetPrefix(MegaCrit.Sts2.Core.Models.AbstractModel model)
```

## MegaCrit.Sts2.Core.Helpers.GlyphConverter

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static Godot.TextServer GetTextServer()
public static System.Char GlyphIdxToChar(Godot.CharFXTransform charFx)
public static System.UInt32 CharToGlyphIdx(Godot.Rid font, System.Char c)
```

## MegaCrit.Sts2.Core.Helpers.GodotTreeExtensions

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static System.Void AddChildSafely(Godot.Node parent, Godot.Node child)
public static System.Void AddSiblingSafely(Godot.Node sibling, Godot.Node child)
public static System.Void FreeChildren(Godot.Node node)
public static System.Void MoveChildSafely(Godot.Node parent, Godot.Node child, System.Int32 index)
public static System.Void MoveToFrontSafely(Godot.CanvasItem node)
public static System.Void QueueFreeSafely(Godot.Node node)
public static System.Void QueueFreeSafelyNoPool(Godot.Node node)
public static System.Void RemoveChildSafely(Godot.Node parent, Godot.Node child)
```

## MegaCrit.Sts2.Core.Helpers.GodotTreeExtensions+<>c__DisplayClass5_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Pooling.IPoolable poolable
public .ctor()
internal System.Void <QueueFreeSafely>b__0()
```

## MegaCrit.Sts2.Core.Helpers.GrabBag+<>c__DisplayClass8_0<T>

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.Func<T, System.Boolean> predicate
public .ctor()
internal System.Boolean <GrabIndex>b__0(System.ValueTuple<T, System.Double> e)
```

## MegaCrit.Sts2.Core.Helpers.GrabBag<T>

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private readonly System.Collections.Generic.List<System.ValueTuple<T, System.Double>> _entries
private System.Double _totalWeight
System.Int32 Count { public get; }
public .ctor()
private System.Int32 GrabIndex(MegaCrit.Sts2.Core.Random.Rng rng, System.Func<T, System.Boolean> predicate)
private System.Int32 GrabIndex(MegaCrit.Sts2.Core.Random.Rng rng)
private System.Void Remove(System.Int32 index)
public System.Boolean Any()
public System.Int32 get_Count()
public System.Void Add(T element, System.Double weight)
public T Grab(MegaCrit.Sts2.Core.Random.Rng rng, System.Func<T, System.Boolean> predicate = null)
public T GrabAndRemove(MegaCrit.Sts2.Core.Random.Rng rng, System.Func<T, System.Boolean> predicate = null)
```

## MegaCrit.Sts2.Core.Helpers.HandLayoutHelper

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static System.Int32 IndexOf<T>(System.Collections.Generic.IReadOnlyList<T> list, T item, System.Collections.Generic.EqualityComparer<T> comparer) where T: [None]
public static System.Int32 GetInsertIndex<T>(System.Collections.Generic.IReadOnlyList<T> pileOrder, System.Collections.Generic.IEnumerable<T> presentCards, T target) where T: [None]
```

## MegaCrit.Sts2.Core.Helpers.HandPosHelper

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static readonly Godot.Vector2 _baseScale
private static readonly System.Single[][] _cardAngleData
private static readonly Godot.Vector2[][] _cardPositionData
private static const System.Single _offsetY = -50
private static .cctor()
public static Godot.Vector2 GetPosition(System.Int32 handSize, System.Int32 cardIndex)
public static Godot.Vector2 GetScale(System.Int32 handSize)
public static System.Single GetAngle(System.Int32 handSize, System.Int32 cardIndex)
```

## MegaCrit.Sts2.Core.Helpers.ImageHelper

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static System.String GetRoomIconSuffix(MegaCrit.Sts2.Core.Map.MapPointType mapPointType, MegaCrit.Sts2.Core.Rooms.RoomType roomType, MegaCrit.Sts2.Core.Models.ModelId modelId)
public static System.String GetImagePath(System.String innerPath)
public static System.String GetRoomIconOutlinePath(MegaCrit.Sts2.Core.Map.MapPointType mapPointType, MegaCrit.Sts2.Core.Rooms.RoomType roomType, MegaCrit.Sts2.Core.Models.ModelId modelId)
public static System.String GetRoomIconPath(MegaCrit.Sts2.Core.Map.MapPointType mapPointType, MegaCrit.Sts2.Core.Rooms.RoomType roomType, MegaCrit.Sts2.Core.Models.ModelId modelId)
```

## MegaCrit.Sts2.Core.Helpers.MathHelper

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static const System.Single degToRad = 0.0174533
public static Godot.Vector2 BezierCurve(Godot.Vector2 v0, Godot.Vector2 v1, Godot.Vector2 c0, System.Single t)
public static Godot.Vector2 Clamp(Godot.Vector2 input, System.Single min, System.Single max)
public static Godot.Vector2 SmoothDamp(Godot.Vector2 current, Godot.Vector2 target, ref Godot.Vector2 currentVelocity, System.Single smoothTime, System.Single deltaTime, System.Single maxSpeed = Infinity)
public static System.Single GetAngle(Godot.Vector2 vector)
public static System.Single Remap(System.Single value, System.Single from1, System.Single to1, System.Single from2, System.Single to2)
public static System.Single SmoothDamp(System.Single current, System.Single target, ref System.Single currentVelocity, System.Single smoothTime, System.Single deltaTime, System.Single maxSpeed = Infinity)
```

## MegaCrit.Sts2.Core.Helpers.NonInteractiveMode

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static System.Func<System.Boolean> <AutoSlayerCheck>k__BackingField
System.Func<System.Boolean> AutoSlayerCheck { public static get; public static set; }
System.Boolean IsActive { public static get; }
private static .cctor()
public static System.Boolean get_IsActive()
public static System.Func<System.Boolean> get_AutoSlayerCheck()
public static System.Void set_AutoSlayerCheck(System.Func<System.Boolean> value)
```

## MegaCrit.Sts2.Core.Helpers.NonInteractiveMode+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Helpers.NonInteractiveMode+<>c <>9
private static .cctor()
public .ctor()
internal System.Boolean <.cctor>b__6_0()
```

## MegaCrit.Sts2.Core.Helpers.OneTimeInitialization

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static MegaCrit.Sts2.Core.Assets.AtlasResourceLoader _atlasResourceLoader
private static MegaCrit.Sts2.Core.Helpers.OneTimeInitialization+State _state
private static MegaCrit.Sts2.Core.Saves.ReadSaveResult<MegaCrit.Sts2.Core.Saves.SettingsSave> <SettingsReadResult>k__BackingField
MegaCrit.Sts2.Core.Saves.ReadSaveResult<MegaCrit.Sts2.Core.Saves.SettingsSave> SettingsReadResult { public static get; private static set; }
private static System.Void PrewarmJit()
private static System.Void set_SettingsReadResult(MegaCrit.Sts2.Core.Saves.ReadSaveResult<MegaCrit.Sts2.Core.Saves.SettingsSave> value)
public static [async] System.Threading.Tasks.Task ExecuteVeryEarly()
public static MegaCrit.Sts2.Core.Saves.ReadSaveResult<MegaCrit.Sts2.Core.Saves.SettingsSave> get_SettingsReadResult()
public static System.Void ExecuteDeferred()
public static System.Void ExecuteEssential()
```

## MegaCrit.Sts2.Core.Helpers.OneTimeInitialization+<ExecuteVeryEarly>d__7

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Helpers.OneTimeInitialization+State

类型属性：`NestedPrivate, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Helpers.OneTimeInitialization+State Done = 3
public static const MegaCrit.Sts2.Core.Helpers.OneTimeInitialization+State Essential = 2
public static const MegaCrit.Sts2.Core.Helpers.OneTimeInitialization+State None = 0
public System.Int32 value__
public static const MegaCrit.Sts2.Core.Helpers.OneTimeInitialization+State VeryEarly = 1
```

## MegaCrit.Sts2.Core.Helpers.Really

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static const System.Int32 bigNumber = 999999999
```

## MegaCrit.Sts2.Core.Helpers.ReflectionHelper

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static System.Type[] _allTypes
private static System.Type[] _modTypes
public static const System.Reflection.BindingFlags allAccessLevels = 52
System.Type[] AllTypes { public static get; }
System.Type[] ModTypes { public static get; }
System.Boolean SubtypesAvailable { public static get; }
private static System.Collections.Generic.IEnumerable<System.Type> GetSubtypesFromList(System.Collections.Generic.IList<System.Type> list, System.Type parentType)
public static System.Boolean get_SubtypesAvailable()
public static System.Boolean InheritsOrImplements(System.Type derived, System.Type baseType)
public static System.Collections.Generic.IEnumerable<System.Type> GetSubtypes(System.Type parentType)
public static System.Collections.Generic.IEnumerable<System.Type> GetSubtypes<T>() where T: [ReferenceTypeConstraint]
public static System.Collections.Generic.IEnumerable<System.Type> GetSubtypesFromAssembly(System.Reflection.Assembly assembly, System.Type parentType)
public static System.Collections.Generic.IEnumerable<System.Type> GetSubtypesInMods(System.Type parentType)
public static System.Collections.Generic.IEnumerable<System.Type> GetSubtypesInMods<T>() where T: [ReferenceTypeConstraint]
public static System.Type[] get_AllTypes()
public static System.Type[] get_ModTypes()
```

## MegaCrit.Sts2.Core.Helpers.ReflectionHelper+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Helpers.ReflectionHelper+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Modding.Mod, System.Collections.Generic.IEnumerable<System.Reflection.Assembly>> <>9__8_0
public static System.Func<System.Reflection.Assembly, System.Collections.Generic.IEnumerable<System.Type>> <>9__8_1
private static .cctor()
public .ctor()
internal System.Collections.Generic.IEnumerable<System.Reflection.Assembly> <get_ModTypes>b__8_0(MegaCrit.Sts2.Core.Modding.Mod m)
internal System.Collections.Generic.IEnumerable<System.Type> <get_ModTypes>b__8_1(System.Reflection.Assembly a)
```

## MegaCrit.Sts2.Core.Helpers.ReflectionHelper+<>c__DisplayClass12_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.Type parentType
public .ctor()
internal System.Boolean <GetSubtypesFromList>b__0(System.Type type)
```

## MegaCrit.Sts2.Core.Helpers.SceneHelper

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static Godot.PackedScene Load(System.String innerPath)
public static System.String GetScenePath(System.String innerPath)
public static T Instantiate<T>(System.String innerPath) where T: [None] Godot.Node
```

## MegaCrit.Sts2.Core.Helpers.ScrollHelper

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static const System.Single _panScrollSpeed = 50
private static const System.Single _scrollAmount = 40
public static const System.Single bounceBackStrength = 12
public static const System.Single dragLerpSpeed = 15
public static const System.Single snapThreshold = 0.5
public static System.Single GetDragForScrollEvent(Godot.InputEvent inputEvent)
```

## MegaCrit.Sts2.Core.Helpers.SeedHelper

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static const System.String _characters = "0123456789ABCDEFGHJKLMNPQRSTUVWXYZ"
public static const System.Int32 seedDefaultLength = 12
public static System.String CanonicalizeSeed(System.String seed)
public static System.String GetRandomSeed(MegaCrit.Sts2.Core.Random.Rng rng = null, System.Int32 length = 12)
```

## MegaCrit.Sts2.Core.Helpers.SpineNodeExtensions

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static const System.Int32 _spineReadyWarnThresholdFrames = 600
private static [async] System.Threading.Tasks.Task WaitForSpineReady(Godot.Node host, MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite sprite, System.Action<MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState> onReady)
public static System.Void RunWhenSpineReady(Godot.Node host, MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite sprite, System.Action<MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState> onReady)
```

## MegaCrit.Sts2.Core.Helpers.SpineNodeExtensions+<WaitForSpineReady>d__2

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
private System.Int32 <framesWaited>5__2
public Godot.Node host
public System.Action<MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState> onReady
public MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite sprite
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Helpers.StringHelper

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static System.Byte[] _stringHashCache
private static System.Text.RegularExpressions.Regex CamelCaseRegex()
private static System.Text.RegularExpressions.Regex SnakeCaseRegex()
private static System.Text.RegularExpressions.Regex SpecialCharRegex()
private static System.Text.RegularExpressions.Regex WhitespaceRegex()
public static MegaCrit.Sts2.Core.Localization.LocString RatioFormat(System.Int32 numerator, System.Int32 denominator)
public static MegaCrit.Sts2.Core.Localization.LocString RatioFormat(System.String numerator, System.String denominator)
public static System.Int32 GetDeterministicHashCodeOld(System.String str)
public static System.String Capitalize(System.String input)
public static System.String CompactText(System.String text)
public static System.String EscapeBbcodeTags(System.String text)
public static System.String Radix(System.Int32 value)
public static System.String Slugify(System.String txt)
public static System.String SnakeCase(System.String txt)
public static System.String StripBbCode(System.String text)
public static System.String Unslugify(System.String txt)
public static System.UInt64 GetDeterministicHashCode(System.String str)
```

## MegaCrit.Sts2.Core.Helpers.StringHelper+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Helpers.StringHelper+<>c <>9
public static System.Text.RegularExpressions.MatchEvaluator <>9__7_0
private static .cctor()
public .ctor()
internal System.String <Unslugify>b__7_0(System.Text.RegularExpressions.Match match)
```

## MegaCrit.Sts2.Core.Helpers.StsColors

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly Godot.Color aqua
public static readonly Godot.Color blue
public static readonly Godot.Color blueGlow
public static readonly Godot.Color bossNodeUntraveled
public static readonly Godot.Color cardTitleOutlineCommon
public static readonly Godot.Color cardTitleOutlineCurse
public static readonly Godot.Color cardTitleOutlineQuest
public static readonly Godot.Color cardTitleOutlineRare
public static readonly Godot.Color cardTitleOutlineSpecial
public static readonly Godot.Color cardTitleOutlineStatus
public static readonly Godot.Color cardTitleOutlineUncommon
public static readonly Godot.Color cream
public static readonly Godot.Color darkBlue
public static readonly Godot.Color defaultEnergyCostOutline
public static readonly Godot.Color defaultStarCostOutline
public static readonly Godot.Color disabledRed
public static readonly Godot.Color disabledTextForPotionPopup
public static readonly Godot.Color disabledTopBarButton
public static readonly Godot.Color energyBlue
public static readonly Godot.Color energyBlueOutline
public static readonly Godot.Color energyGreenOutline
public static readonly Godot.Color exhaustGray
public static readonly Godot.Color gold
public static readonly Godot.Color gray
public static readonly Godot.Color green
public static readonly Godot.Color halfTransparentBlack
public static readonly Godot.Color halfTransparentCream
public static readonly Godot.Color halfTransparentWhite
public static readonly Godot.Color hpBarBackground
public static readonly Godot.Color legendText
public static readonly Godot.Color lightGray
public static readonly Godot.Color merchantBlue
public static readonly Godot.Color ninetyPercentBlack
public static readonly Godot.Color orange
public static readonly Godot.Color pathDotTraveled
public static readonly Godot.Color pink
public static readonly Godot.Color placeholderGrayTabButton
public static readonly Godot.Color purple
public static readonly Godot.Color quarterTransparentBlack
public static readonly Godot.Color quarterTransparentWhite
public static readonly Godot.Color red
public static readonly Godot.Color redGlow
public static readonly Godot.Color rewardLabelGoldOutline
public static readonly Godot.Color rewardLabelOutline
public static readonly Godot.Color screenBackdrop
public static readonly Godot.Color settingTabsButtonOutline
public static readonly Godot.Color settingTabsButtonOutlineFiftyPercent
public static readonly Godot.Color targetingArrowAlly
public static readonly Godot.Color targetingArrowEnemy
public static readonly Godot.Color transparentBlack
public static readonly Godot.Color transparentWhite
public static readonly Godot.Color unplayableEnergyCostOutline
private static .cctor()
```

## MegaCrit.Sts2.Core.Helpers.TaskHelper

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static System.Action<System.Exception> UnobservedFault
event System.Action<System.Exception> UnobservedFault
private static [async] System.Threading.Tasks.Task LogTaskExceptions(System.Threading.Tasks.Task task)
public static [async] System.Threading.Tasks.Task WhenAny(params System.Threading.Tasks.Task[] tasks)
public static System.Threading.Tasks.Task RunSafely(System.Threading.Tasks.Task task)
public static System.Void add_UnobservedFault(System.Action<System.Exception> value)
public static System.Void remove_UnobservedFault(System.Action<System.Exception> value)
```

## MegaCrit.Sts2.Core.Helpers.TaskHelper+<LogTaskExceptions>d__4

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public System.Threading.Tasks.Task task
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Helpers.TaskHelper+<WhenAny>d__5

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Threading.Tasks.Task> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
public System.Threading.Tasks.Task[] tasks
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Helpers.TimeFormatting

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static System.String Format(System.Single time)
```
