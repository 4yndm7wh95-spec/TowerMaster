# MegaCrit.Sts2.Core.Entities.Intents

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Entities.Intents.IntentAnimData

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static readonly System.Collections.Generic.Dictionary<System.String, MegaCrit.Sts2.Core.Entities.Intents.IntentAnimData+InternalData> _data
public static const System.String attack1 = "attack_1"
public static const System.String attack2 = "attack_2"
public static const System.String attack3 = "attack_3"
public static const System.String attack4 = "attack_4"
public static const System.String attack5 = "attack_5"
public static const System.String buff = "buff"
public static const System.String cardDebuff = "card_debuff"
public static const System.String deathBlow = "death_blow"
public static const System.String debuff = "debuff"
public static const System.String defend = "defend"
public static const System.String escape = "escape"
public static const System.String heal = "heal"
public static const System.String hidden = "hidden"
public static const System.String sleep = "sleep"
public static const System.String status = "status"
public static const System.String stun = "stun"
public static const System.String summon = "summon"
public static const System.String unknown = "unknown"
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
private static .cctor()
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public static System.Int32 GetAnimationFrameCount(System.String animation)
public static System.String GetAnimationFrame(System.String animation, System.Int32 frame)
```

## MegaCrit.Sts2.Core.Entities.Intents.IntentAnimData+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Entities.Intents.IntentAnimData+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Entities.Intents.IntentAnimData+InternalData, System.Collections.Generic.IEnumerable<System.String>> <>9__21_0
private static .cctor()
public .ctor()
internal System.Collections.Generic.IEnumerable<System.String> <get_AssetPaths>b__21_0(MegaCrit.Sts2.Core.Entities.Intents.IntentAnimData+InternalData v)
```

## MegaCrit.Sts2.Core.Entities.Intents.IntentAnimData+InternalData

类型属性：`NestedPrivate, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：

```text
public System.String[] frames
public .ctor(System.String prefix, System.Int32 frameCount)
public .ctor(System.String singleFrameName)
```
