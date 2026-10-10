# MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockCardsScreen

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockScreen`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private MegaCrit.Sts2.Core.Nodes.CommonUi.NCommonBanner _banner
private Godot.Control _cardRow
private System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.CardModel> _cards
private Godot.Tween _cardTween
private static const System.Single _cardXOffset = 350
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Cards.Holders.NGridCardHolder> _holders
private static readonly System.String _scenePath
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
Godot.Control DefaultFocusedControl { public virtual get; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnScreenClose()
protected virtual System.Void OnScreenPreClose()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockCardsScreen Create()
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Void SetCards(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.CardModel> cards)
public virtual Godot.Control get_DefaultFocusedControl()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
public virtual System.Void Open()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockCardsScreen+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockScreen+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName OnScreenClose
public static readonly Godot.StringName OnScreenPreClose
public static readonly Godot.StringName Open
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockCardsScreen+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockScreen+PropertyName`。

接口：

```text
public static readonly Godot.StringName _banner
public static readonly Godot.StringName _cardRow
public static readonly Godot.StringName _cardTween
public static readonly Godot.StringName DefaultFocusedControl
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockCardsScreen+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockScreen+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockCharacterScreen

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockScreen`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _bottomLabel
private MegaCrit.Sts2.Core.Models.CharacterModel _character
private MegaCrit.Sts2.Core.Nodes.Combat.NCreatureVisuals _creatureVisuals
private MegaCrit.Sts2.Core.Timeline.EpochModel _epoch
private Godot.GpuParticles2D _rareGlow
private static readonly System.String _scenePath
private Godot.Control _spineAnchor
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _topLabel
private Godot.Tween _tween
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnScreenClose()
protected virtual System.Void OnScreenPreClose()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockCharacterScreen Create(MegaCrit.Sts2.Core.Timeline.EpochModel epoch, MegaCrit.Sts2.Core.Models.CharacterModel character)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Void _Ready()
public virtual System.Void Open()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockCharacterScreen+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockScreen+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnScreenClose
public static readonly Godot.StringName OnScreenPreClose
public static readonly Godot.StringName Open
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockCharacterScreen+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockScreen+PropertyName`。

接口：

```text
public static readonly Godot.StringName _bottomLabel
public static readonly Godot.StringName _creatureVisuals
public static readonly Godot.StringName _rareGlow
public static readonly Godot.StringName _spineAnchor
public static readonly Godot.StringName _topLabel
public static readonly Godot.StringName _tween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockCharacterScreen+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockScreen+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockEpochScreen

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockScreen`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private Godot.Tween _cardFlyTween
private Godot.RichTextLabel _infoLabel
private static const System.Double _initDelay = 0.3
private System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Timeline.EpochModel> _unlockedEpochs
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void SetUnlocks(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Timeline.EpochModel> epochs)
public virtual System.Void _Ready()
public virtual System.Void Open()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockEpochScreen+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockScreen+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Open
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockEpochScreen+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockScreen+PropertyName`。

接口：

```text
public static readonly Godot.StringName _cardFlyTween
public static readonly Godot.StringName _infoLabel
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockEpochScreen+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockScreen+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockMiscScreen

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockScreen`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _label
private static readonly System.String _scenePath
private System.String _textToSet
private Godot.Tween _tween
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnScreenClose()
protected virtual System.Void OnScreenPreClose()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockMiscScreen Create()
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Void SetUnlocks(System.String text)
public virtual System.Void _Ready()
public virtual System.Void Open()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockMiscScreen+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockScreen+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName OnScreenClose
public static readonly Godot.StringName OnScreenPreClose
public static readonly Godot.StringName Open
public static readonly Godot.StringName SetUnlocks
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockMiscScreen+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockScreen+PropertyName`。

接口：

```text
public static readonly Godot.StringName _label
public static readonly Godot.StringName _textToSet
public static readonly Godot.StringName _tween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockMiscScreen+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockScreen+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockPotionsScreen

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockScreen`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private MegaCrit.Sts2.Core.Nodes.CommonUi.NCommonBanner _banner
private Godot.Control _potionRow
private System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.PotionModel> _potions
private static readonly Godot.Vector2 _potionScale
private Godot.Tween _potionTween
private static const System.Single _potionXOffset = 350
private static readonly System.String _scenePath
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
Godot.Control DefaultFocusedControl { public virtual get; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnScreenClose()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockPotionsScreen Create()
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Void SetPotions(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.PotionModel> potions)
public virtual Godot.Control get_DefaultFocusedControl()
public virtual System.Void _Ready()
public virtual System.Void Open()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockPotionsScreen+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockScreen+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName OnScreenClose
public static readonly Godot.StringName Open
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockPotionsScreen+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockScreen+PropertyName`。

接口：

```text
public static readonly Godot.StringName _banner
public static readonly Godot.StringName _potionRow
public static readonly Godot.StringName _potionTween
public static readonly Godot.StringName DefaultFocusedControl
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockPotionsScreen+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockScreen+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockRelicsScreen

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockScreen`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private MegaCrit.Sts2.Core.Nodes.CommonUi.NCommonBanner _banner
private Godot.Control _relicRow
private System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.RelicModel> _relics
private static readonly Godot.Vector2 _relicScale
private Godot.Tween _relicTween
private static const System.Single _relicXOffset = 350
private static readonly System.String _scenePath
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
Godot.Control DefaultFocusedControl { public virtual get; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnScreenClose()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockRelicsScreen Create()
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Void SetRelics(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.RelicModel> relics)
public virtual Godot.Control get_DefaultFocusedControl()
public virtual System.Void _Ready()
public virtual System.Void Open()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockRelicsScreen+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockScreen+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName OnScreenClose
public static readonly Godot.StringName Open
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockRelicsScreen+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockScreen+PropertyName`。

接口：

```text
public static readonly Godot.StringName _banner
public static readonly Godot.StringName _relicRow
public static readonly Godot.StringName _relicTween
public static readonly Godot.StringName DefaultFocusedControl
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockRelicsScreen+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockScreen+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockScreen

类型属性：`Public, Abstract, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private Godot.Tween _tween
private MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NUnlockConfirmButton _unlockConfirmButton
Godot.Control DefaultFocusedControl { public virtual get; }
protected .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void <ConnectSignals>b__3_0(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl _)
private System.Void <Open>b__4_0()
protected [async] System.Threading.Tasks.Task Close()
protected System.Void ConnectSignals()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnScreenClose()
protected virtual System.Void OnScreenPreClose()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual Godot.Control get_DefaultFocusedControl()
public virtual System.Void _Ready()
public virtual System.Void Open()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockScreen+<Close>d__5

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockScreen <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockScreen+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName ConnectSignals
public static readonly Godot.StringName OnScreenClose
public static readonly Godot.StringName OnScreenPreClose
public static readonly Godot.StringName Open
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockScreen+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _tween
public static readonly Godot.StringName _unlockConfirmButton
public static readonly Godot.StringName DefaultFocusedControl
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockScreen+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockTimelineScreen

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockScreen`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Timeline.EpochSlotData> _erasToUnlock
private static readonly System.String _scenePath
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
private [async] System.Threading.Tasks.Task AnimateExpansion()
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockTimelineScreen Create()
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Void SetUnlocks(System.Collections.Generic.List<MegaCrit.Sts2.Core.Timeline.EpochSlotData> eras)
public virtual System.Void _Ready()
public virtual System.Void Open()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockTimelineScreen+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockTimelineScreen+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Timeline.EpochSlotData, System.Int32> <>9__6_0
private static .cctor()
public .ctor()
internal System.Int32 <SetUnlocks>b__6_0(MegaCrit.Sts2.Core.Timeline.EpochSlotData a)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockTimelineScreen+<AnimateExpansion>d__8

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockTimelineScreen <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockTimelineScreen+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockScreen+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName Open
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockTimelineScreen+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockScreen+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockTimelineScreen+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens.NUnlockScreen+SignalName`。

接口：

```text
public .ctor()
```
