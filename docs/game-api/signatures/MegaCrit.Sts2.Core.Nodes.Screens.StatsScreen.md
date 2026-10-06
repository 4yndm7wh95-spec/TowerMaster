# MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NAchievementHolder

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Achievements.Achievement _achievement
private Godot.TextureRect _border
private Godot.ShaderMaterial _borderHsv
private MegaCrit.Sts2.addons.mega_text.MegaLabel _date
private static readonly Godot.StringName _h
private Godot.TextureRect _icon
private Godot.ShaderMaterial _iconHsv
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _infoLabel
private Godot.TextureRect _lock
private static readonly Godot.StringName _s
private static const System.String _scenePath = "screens/stats_screen/achievement_holder"
private Godot.Tween _tween
private static readonly Godot.StringName _v
private System.Boolean <IsUnlocked>k__BackingField
System.Boolean IsUnlocked { public get; private set; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void set_IsUnlocked(System.Boolean value)
private System.Void SetDateLabel()
private System.Void SetLockVisuals()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NAchievementHolder Create(MegaCrit.Sts2.Core.Achievements.Achievement achievement)
public static System.String GetPathForAchievement(System.Enum achievement)
public System.Boolean get_IsUnlocked()
public System.Void RefreshUnlocked()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NAchievementHolder+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName RefreshUnlocked
public static readonly Godot.StringName SetDateLabel
public static readonly Godot.StringName SetLockVisuals
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NAchievementHolder+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _achievement
public static readonly Godot.StringName _border
public static readonly Godot.StringName _borderHsv
public static readonly Godot.StringName _date
public static readonly Godot.StringName _icon
public static readonly Godot.StringName _iconHsv
public static readonly Godot.StringName _infoLabel
public static readonly Godot.StringName _lock
public static readonly Godot.StringName _tween
public static readonly Godot.StringName IsUnlocked
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NAchievementHolder+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NAchievementsGrid

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private Godot.Control _achievementsContainer
private System.Boolean _isDragging
private System.Boolean _scrollbarPressed
private Godot.Vector2 _startDragPos
private Godot.Vector2 _targetDragPos
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
Godot.Control DefaultFocusedControl { public get; }
System.Single ScrollLimitBottom { private get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Single get_ScrollLimitBottom()
private System.Void OnAchievementsChanged()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public Godot.Control get_DefaultFocusedControl()
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NAchievementsGrid+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NAchievementsGrid+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Achievements.Achievement, System.String> <>9__1_0
private static .cctor()
public .ctor()
internal System.String <get_AssetPaths>b__1_0(MegaCrit.Sts2.Core.Achievements.Achievement a)
```

## MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NAchievementsGrid+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnAchievementsChanged
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NAchievementsGrid+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _achievementsContainer
public static readonly Godot.StringName _isDragging
public static readonly Godot.StringName _scrollbarPressed
public static readonly Godot.StringName _startDragPos
public static readonly Godot.StringName _targetDragPos
public static readonly Godot.StringName DefaultFocusedControl
public static readonly Godot.StringName ScrollLimitBottom
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NAchievementsGrid+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NCharacterStats

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private static readonly System.String _chainIconPath
private Godot.Control _characterIcon
private MegaCrit.Sts2.Core.Saves.CharacterStats _characterStats
private MegaCrit.Sts2.addons.mega_text.MegaLabel _nameLabel
private MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NStatEntry _playtimeEntry
private static readonly System.String _playtimeIconPath
private Godot.Node _statsContainer
private MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NStatEntry _streakEntry
private MegaCrit.Sts2.addons.mega_text.MegaLabel _unlocksLabel
private MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NStatEntry _winLossEntry
private static readonly System.String _winLossIconPath
System.String[] AssetPaths { public static get; }
System.String ScenePath { private static get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NStatEntry CreateSection(System.String imgUrl)
private static System.String get_ScenePath()
private System.Void LoadStats()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NCharacterStats Create(MegaCrit.Sts2.Core.Saves.CharacterStats characterStats)
public static System.String[] get_AssetPaths()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NCharacterStats+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName CreateSection
public static readonly Godot.StringName LoadStats
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NCharacterStats+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _characterIcon
public static readonly Godot.StringName _nameLabel
public static readonly Godot.StringName _playtimeEntry
public static readonly Godot.StringName _statsContainer
public static readonly Godot.StringName _streakEntry
public static readonly Godot.StringName _unlocksLabel
public static readonly Godot.StringName _winLossEntry
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NCharacterStats+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NGeneralStatsGrid

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NStatEntry _achievementsEntry
private static readonly System.String _achievementsIconPath
private static readonly System.String _ancientsIconPath
private MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NStatEntry _cardsEntry
private static readonly System.String _cardsIconPath
private Godot.Control _characterStatContainer
private MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NStatEntry _eventsEntry
private static readonly System.String _eventsIconPath
private Godot.Node _gridContainer
private MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NStatEntry _monsterEntry
private static readonly System.String _monsterIconPath
private MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NStatEntry _playtimeEntry
private static readonly System.String _playtimeIconPath
private MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NStatEntry _potionEntry
private static readonly System.String _potionIconPath
private MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NStatEntry _relicEntry
private static readonly System.String _relicIconPath
private Godot.Tween _screenTween
private MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NStatEntry _streakEntry
private static readonly System.String _streakIconPath
private MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NStatEntry _winLossEntry
private static readonly System.String _winLossIconPath
System.String[] AssetPaths { public static get; }
Godot.Control DefaultFocusedControl { public get; }
MegaCrit.Sts2.Core.HoverTips.HoverTip PlaytimeTip { private static get; }
MegaCrit.Sts2.Core.HoverTips.HoverTip WinsLossesTip { private static get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NStatEntry CreateSection(System.String imgUrl)
private static MegaCrit.Sts2.Core.HoverTips.HoverTip get_PlaytimeTip()
private static MegaCrit.Sts2.Core.HoverTips.HoverTip get_WinsLossesTip()
private System.Void CreateCharacterSection(MegaCrit.Sts2.Core.Saves.ProgressState progressSave, MegaCrit.Sts2.Core.Models.ModelId id)
private System.Void SetupHoverTips()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public Godot.Control get_DefaultFocusedControl()
public static System.String[] get_AssetPaths()
public System.Void LoadStats()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NGeneralStatsGrid+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NGeneralStatsGrid+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Saves.SerializableEpoch, System.Boolean> <>9__30_0
public static System.Func<MegaCrit.Sts2.Core.Models.EventModel, MegaCrit.Sts2.Core.Models.ModelId> <>9__30_2
private static .cctor()
public .ctor()
internal MegaCrit.Sts2.Core.Models.ModelId <LoadStats>b__30_2(MegaCrit.Sts2.Core.Models.EventModel e)
internal System.Boolean <LoadStats>b__30_0(MegaCrit.Sts2.Core.Saves.SerializableEpoch epoch)
```

## MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NGeneralStatsGrid+<>c__DisplayClass30_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Saves.ProgressState progressSave
public .ctor()
internal System.Boolean <LoadStats>b__1(System.String id)
```

## MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NGeneralStatsGrid+<>c__DisplayClass30_1

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.String id
public .ctor()
internal System.Boolean <LoadStats>b__3(MegaCrit.Sts2.Core.Saves.SerializableEpoch epoch)
```

## MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NGeneralStatsGrid+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName CreateSection
public static readonly Godot.StringName LoadStats
public static readonly Godot.StringName SetupHoverTips
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NGeneralStatsGrid+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _achievementsEntry
public static readonly Godot.StringName _cardsEntry
public static readonly Godot.StringName _characterStatContainer
public static readonly Godot.StringName _eventsEntry
public static readonly Godot.StringName _gridContainer
public static readonly Godot.StringName _monsterEntry
public static readonly Godot.StringName _playtimeEntry
public static readonly Godot.StringName _potionEntry
public static readonly Godot.StringName _relicEntry
public static readonly Godot.StringName _screenTween
public static readonly Godot.StringName _streakEntry
public static readonly Godot.StringName _winLossEntry
public static readonly Godot.StringName DefaultFocusedControl
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NGeneralStatsGrid+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NShareStatsButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private Godot.Control _image
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnFocus()
protected virtual System.Void OnPress()
protected virtual System.Void OnRelease()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NShareStatsButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnUnfocus
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NShareStatsButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _image
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NShareStatsButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NStatEntry

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _bottomLabel
private MegaCrit.Sts2.Core.Nodes.Combat.NSelectionReticle _controllerFocusReticle
private System.Nullable<MegaCrit.Sts2.Core.HoverTips.HoverTip> _hoverTip
private Godot.TextureRect _icon
private System.String _imgUrl
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _topLabel
private Godot.Tween _tween
System.String ScenePath { private static get; }
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private static System.String get_ScenePath()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnFocus()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NStatEntry Create(System.String imgUrl)
public System.Void SetBottomText(System.String text)
public System.Void SetHoverTip(MegaCrit.Sts2.Core.HoverTips.HoverTip hoverTip)
public System.Void SetTopText(System.String text)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NStatEntry+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName SetBottomText
public static readonly Godot.StringName SetTopText
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NStatEntry+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+PropertyName`。

接口：

```text
public static readonly Godot.StringName _bottomLabel
public static readonly Godot.StringName _controllerFocusReticle
public static readonly Godot.StringName _icon
public static readonly Godot.StringName _imgUrl
public static readonly Godot.StringName _topLabel
public static readonly Godot.StringName _tween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NStatEntry+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NStatsScreen

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTab _achievementsTab
private static readonly System.String _scenePath
private Godot.Tween _screenTween
private MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NGeneralStatsGrid _statsGrid
private MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTab _statsTab
private MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NStatsTabManager _statsTabManager
System.String[] AssetPaths { public static get; }
Godot.Control InitialFocusedControl { protected virtual get; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void <_Ready>b__9_0(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl _)
private System.Void OpenAchievementsMenu()
private System.Void OpenStatsMenu()
protected virtual Godot.Control get_InitialFocusedControl()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NStatsScreen Create()
public static System.String[] get_AssetPaths()
public virtual System.Void _Ready()
public virtual System.Void OnSubmenuOpened()
```

## MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NStatsScreen+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName OnSubmenuOpened
public static readonly Godot.StringName OpenAchievementsMenu
public static readonly Godot.StringName OpenStatsMenu
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NStatsScreen+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+PropertyName`。

接口：

```text
public static readonly Godot.StringName _achievementsTab
public static readonly Godot.StringName _screenTween
public static readonly Godot.StringName _statsGrid
public static readonly Godot.StringName _statsTab
public static readonly Godot.StringName _statsTabManager
public static readonly Godot.StringName InitialFocusedControl
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NStatsScreen+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NStatsTabManager

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTab _currentTab
private Godot.Control _tabContainer
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTab> _tabs
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void SwitchToTab(MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsTab tab)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void ResetTabs()
public virtual System.Void _Input(Godot.InputEvent inputEvent)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NStatsTabManager+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Input
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName ResetTabs
public static readonly Godot.StringName SwitchToTab
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NStatsTabManager+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _currentTab
public static readonly Godot.StringName _tabContainer
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NStatsTabManager+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```
