# MegaCrit.Sts2.Core.Random

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Random.MegaRandom

类型属性：`Public, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static const System.Double _incrDouble = 1.1102230246251565E-16
private static const System.Single _incrFloat = 5.9604645E-08
private System.UInt64 _s0
private System.UInt64 _s1
private System.UInt64 _s2
private System.UInt64 _s3
public .ctor(MegaCrit.Sts2.Core.Saves.SerializableRng serializable)
public .ctor(System.UInt64 seed)
private System.Int32 NextInner(System.Int32 maxValue)
private System.Int64 NextInner(System.Int64 maxValue)
private System.UInt64 NextULongInner()
public static System.UInt64 Splitmix64(ref System.UInt64 x)
public System.Boolean NextBool()
public System.Double NextDouble()
public System.Int32 Next(System.Int32 maxValue)
public System.Int32 Next(System.Int32 minValue, System.Int32 maxValue)
public System.Int32 NextInt()
public System.Single NextFloat()
public System.UInt32 NextUInt()
public System.UInt64 NextULong()
public System.Void FillSerializableState(MegaCrit.Sts2.Core.Saves.SerializableRng rng)
public System.Void NextBytes(System.Span<System.Byte> span)
public System.Void Reinitialise(MegaCrit.Sts2.Core.Saves.SerializableRng serializable)
public System.Void Reinitialise(System.UInt64 seed)
```

## MegaCrit.Sts2.Core.Random.PlayerRngSet

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private readonly System.Collections.Generic.Dictionary<MegaCrit.Sts2.Core.Entities.Rngs.PlayerRngType, MegaCrit.Sts2.Core.Random.Rng> _rngs
private readonly System.UInt64 <Seed>k__BackingField
MegaCrit.Sts2.Core.Random.Rng Rewards { public get; }
System.UInt64 Seed { public get; }
MegaCrit.Sts2.Core.Random.Rng Shops { public get; }
MegaCrit.Sts2.Core.Random.Rng Transformations { public get; }
public .ctor(System.UInt64 seed)
private MegaCrit.Sts2.Core.Random.Rng CreateRng(MegaCrit.Sts2.Core.Entities.Rngs.PlayerRngType rngType)
public MegaCrit.Sts2.Core.Random.Rng get_Rewards()
public MegaCrit.Sts2.Core.Random.Rng get_Shops()
public MegaCrit.Sts2.Core.Random.Rng get_Transformations()
public MegaCrit.Sts2.Core.Random.Rng GetRng(MegaCrit.Sts2.Core.Entities.Rngs.PlayerRngType rngType)
public MegaCrit.Sts2.Core.Saves.SerializablePlayerRngSet ToSerializable()
public static MegaCrit.Sts2.Core.Random.PlayerRngSet FromSerializable(MegaCrit.Sts2.Core.Saves.SerializablePlayerRngSet save)
public System.UInt64 get_Seed()
public System.Void LoadFromSerializable(MegaCrit.Sts2.Core.Saves.SerializablePlayerRngSet save)
```

## MegaCrit.Sts2.Core.Random.Rng

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private System.Int32 _counter
private readonly MegaCrit.Sts2.Core.Random.MegaRandom _random
private static readonly MegaCrit.Sts2.Core.Random.Rng <Chaotic>k__BackingField
MegaCrit.Sts2.Core.Random.Rng Chaotic { public static get; }
private static .cctor()
public .ctor(MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.Models.ModelId id, System.UInt64 mixin = 0)
public .ctor(MegaCrit.Sts2.Core.Saves.SerializableRng serializable)
public .ctor(System.UInt64 seed = 0)
public .ctor(System.UInt64 seed, System.String name)
public MegaCrit.Sts2.Core.Saves.SerializableRng ToSerializable()
public static MegaCrit.Sts2.Core.Random.Rng get_Chaotic()
public static T WeightedNextItem<T>(System.Single randInput, System.Collections.Generic.IEnumerable<T> items, System.Func<T, System.Single> weightFetcher, T fallback) where T: [None]
public System.Boolean NextBool()
public System.Double NextDouble()
public System.Double NextDouble(System.Double min, System.Double max)
public System.Double NextGaussianDouble(System.Double mean = 0, System.Double stdDev = 1, System.Double min = 0, System.Double max = 1)
public System.Int32 NextGaussianInt(System.Int32 mean, System.Int32 stdDev, System.Int32 min, System.Int32 max)
public System.Int32 NextInt(System.Int32 maxExclusive = 2147483647)
public System.Int32 NextInt(System.Int32 minInclusive, System.Int32 maxExclusive)
public System.Single NextFloat(System.Single max = 1)
public System.Single NextFloat(System.Single min, System.Single max)
public System.Single NextGaussianFloat(System.Single mean = 0, System.Single stdDev = 1, System.Single min = 0, System.Single max = 1)
public System.UInt32 NextUnsignedInt(System.UInt32 maxExclusive = 4294967295)
public System.UInt32 NextUnsignedInt(System.UInt32 minInclusive, System.UInt32 maxExclusive)
public System.UInt64 NextUnsignedLong()
public System.UInt64 NextUnsignedLong(System.UInt64 maxExclusive)
public System.UInt64 NextUnsignedLong(System.UInt64 minInclusive, System.UInt64 maxExclusive)
public System.Void LoadFromSerializable(MegaCrit.Sts2.Core.Saves.SerializableRng serializable)
public System.Void Shuffle<T>(System.Collections.Generic.IList<T> list) where T: [None]
public T NextItem<T>(System.Collections.Generic.IEnumerable<T> items) where T: [None]
public T WeightedNextItem<T>(System.Collections.Generic.IEnumerable<T> items, System.Func<T, System.Single> weightFetcher) where T: [None]
```
