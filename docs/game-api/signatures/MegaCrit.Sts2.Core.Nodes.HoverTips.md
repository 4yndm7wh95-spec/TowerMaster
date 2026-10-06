# MegaCrit.Sts2.Core.Nodes.HoverTips

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.HoverTips.NHoverTipCardContainer

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private static const System.String _cardHoverTipScenePath = "res://scenes/ui/card_hover_tip.tscn"
private static const System.Single _padding = 4
System.Collections.Generic.IEnumerable<Godot.Control> Tips { private get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
private System.Collections.Generic.IEnumerable<Godot.Control> get_Tips()
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void Add(MegaCrit.Sts2.Core.HoverTips.CardHoverTip cardTip)
public System.Void LayoutResizeAndReposition(Godot.Vector2 globalStartLocation, MegaCrit.Sts2.Core.HoverTips.HoverTipAlignment alignment)
```

## MegaCrit.Sts2.Core.Nodes.HoverTips.NHoverTipCardContainer+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName LayoutResizeAndReposition
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.HoverTips.NHoverTipCardContainer+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.HoverTips.NHoverTipCardContainer+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.HoverTips.NHoverTipSet

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private static readonly System.Collections.Generic.Dictionary<Godot.Control, MegaCrit.Sts2.Core.Nodes.HoverTips.NHoverTipSet> _activeHoverTips
private MegaCrit.Sts2.Core.Nodes.HoverTips.NHoverTipCardContainer _cardHoverTipContainer
private static readonly Godot.StringName _cardHoverTipContainerStr
private static const System.String _debuffMatPath = "res://materials/ui/hover_tip_debuff.tres"
private Godot.Vector2 _extraOffset
private Godot.Vector2 _followOffset
private System.Boolean _followOwner
private static const System.Single _hoverTipSpacing = 5
private static const System.Single _hoverTipWidth = 360
private Godot.Control _owner
private Godot.VFlowContainer _textHoverTipContainer
private static readonly Godot.StringName _textHoverTipContainerStr
private static const System.String _tipScenePath = "res://scenes/ui/hover_tip.tscn"
private static const System.String _tipSetScenePath = "res://scenes/ui/hover_tip_set.tscn"
public static System.Boolean shouldBlockHoverTips
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
Godot.Vector2 CardHoverTipDimensions { private get; }
Godot.Node HoverTipsContainer { private static get; }
Godot.Vector2 TextHoverTipDimensions { private get; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private Godot.Vector2 get_CardHoverTipDimensions()
private Godot.Vector2 get_TextHoverTipDimensions()
private static Godot.Node get_HoverTipsContainer()
private System.Void CorrectHorizontalOverflow()
private System.Void CorrectVerticalOverflow()
private System.Void Init(Godot.Control owner, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.HoverTips.IHoverTip> hoverTips)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.HoverTips.NHoverTipSet CreateAndShow(Godot.Control owner, MegaCrit.Sts2.Core.HoverTips.IHoverTip hoverTip, MegaCrit.Sts2.Core.HoverTips.HoverTipAlignment alignment = 0)
public static MegaCrit.Sts2.Core.Nodes.HoverTips.NHoverTipSet CreateAndShow(Godot.Control owner, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.HoverTips.IHoverTip> hoverTips, MegaCrit.Sts2.Core.HoverTips.HoverTipAlignment alignment = 0)
public static MegaCrit.Sts2.Core.Nodes.HoverTips.NHoverTipSet CreateAndShowMapPointHistory(Godot.Control owner, MegaCrit.Sts2.Core.Nodes.HoverTips.NMapPointHistoryHoverTip historyHoverTip)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public static System.Void Clear()
public static System.Void Remove(Godot.Control owner)
public System.Void SetAlignment(Godot.Control node, MegaCrit.Sts2.Core.HoverTips.HoverTipAlignment alignment)
public System.Void SetAlignmentForCardHolder(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder holder)
public System.Void SetAlignmentForRelic(MegaCrit.Sts2.Core.Nodes.Relics.NRelic relic)
public System.Void SetExtraFollowOffset(Godot.Vector2 offset)
public System.Void SetFollowOwner()
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.HoverTips.NHoverTipSet+<>c__DisplayClass25_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public Godot.Control owner
public .ctor()
internal System.Void <CreateAndShow>b__0()
```

## MegaCrit.Sts2.Core.Nodes.HoverTips.NHoverTipSet+<>c__DisplayClass26_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public Godot.Control owner
public .ctor()
internal System.Void <CreateAndShowMapPointHistory>b__0()
```

## MegaCrit.Sts2.Core.Nodes.HoverTips.NHoverTipSet+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Clear
public static readonly Godot.StringName CorrectHorizontalOverflow
public static readonly Godot.StringName CorrectVerticalOverflow
public static readonly Godot.StringName CreateAndShowMapPointHistory
public static readonly Godot.StringName Remove
public static readonly Godot.StringName SetAlignment
public static readonly Godot.StringName SetAlignmentForCardHolder
public static readonly Godot.StringName SetAlignmentForRelic
public static readonly Godot.StringName SetExtraFollowOffset
public static readonly Godot.StringName SetFollowOwner
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.HoverTips.NHoverTipSet+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _cardHoverTipContainer
public static readonly Godot.StringName _extraOffset
public static readonly Godot.StringName _followOffset
public static readonly Godot.StringName _followOwner
public static readonly Godot.StringName _owner
public static readonly Godot.StringName _textHoverTipContainer
public static readonly Godot.StringName CardHoverTipDimensions
public static readonly Godot.StringName TextHoverTipDimensions
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.HoverTips.NHoverTipSet+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.HoverTips.NMapPointHistoryHoverTip

类型属性：`Public, BeforeFieldInit`；基类：`Godot.MarginContainer`。

接口：`System.IDisposable`

```text
private Godot.RichTextLabel _actionStats
private static const System.String _cardIconPath = "res://images/packed/sprite_fonts/card_icon.png"
private static const System.String _chestIconPath = "res://images/packed/sprite_fonts/chest_icon.png"
private readonly MegaCrit.Sts2.Core.Localization.LocString _chose
private readonly MegaCrit.Sts2.Core.Localization.LocString _combatStats
private readonly MegaCrit.Sts2.Core.Localization.LocString _damaged
private readonly MegaCrit.Sts2.Core.Localization.LocString _downgraded
private readonly MegaCrit.Sts2.Core.Localization.LocString _enchanted
private MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry _entry
private System.Int32 _floorNum
private readonly MegaCrit.Sts2.Core.Localization.LocString _floorTitle
private readonly MegaCrit.Sts2.Core.Localization.LocString _goldGained
private static const System.String _goldIconPath = "res://images/packed/sprite_fonts/gold_icon.png"
private readonly MegaCrit.Sts2.Core.Localization.LocString _goldLost
private readonly MegaCrit.Sts2.Core.Localization.LocString _goldSpent
private readonly MegaCrit.Sts2.Core.Localization.LocString _goldStolen
private readonly MegaCrit.Sts2.Core.Localization.LocString _healed
private readonly MegaCrit.Sts2.Core.Localization.LocString _mapPointPlayerStatsLoc
private readonly MegaCrit.Sts2.Core.Localization.LocString _mapPointRoomStatsLoc
private readonly MegaCrit.Sts2.Core.Localization.LocString _maxHpGained
private readonly MegaCrit.Sts2.Core.Localization.LocString _maxHpLost
private readonly MegaCrit.Sts2.Core.Localization.LocString _obtained
private System.UInt64 _playerId
private Godot.RichTextLabel _playerStats
private static const System.String _potionIconPath = "res://images/packed/sprite_fonts/potion_icon.png"
private readonly MegaCrit.Sts2.Core.Localization.LocString _quests
private readonly MegaCrit.Sts2.Core.Localization.LocString _removed
private System.Collections.Generic.List<Godot.RichTextLabel> _rewardRows
private readonly MegaCrit.Sts2.Core.Localization.LocString _rewardsHeaderLoc
private Godot.Control _rewardStatsContainer
private static const System.String _roomHistoryTipScenePath = "res://scenes/ui/map_point_history_hover_tip.tscn"
private Godot.RichTextLabel _roomStats
private readonly MegaCrit.Sts2.Core.Localization.LocString _skipped
private readonly MegaCrit.Sts2.Core.Localization.LocString _skippedHeaderLoc
private System.Collections.Generic.List<Godot.RichTextLabel> _skippedRows
private Godot.Control _skippedStatsContainer
private MegaCrit.Sts2.addons.mega_text.MegaLabel _titleLabel
private readonly MegaCrit.Sts2.Core.Localization.LocString _transformed
private readonly MegaCrit.Sts2.Core.Localization.LocString _turns
private readonly MegaCrit.Sts2.Core.Localization.LocString _upgraded
private readonly MegaCrit.Sts2.Core.Localization.LocString _used
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Boolean <_Ready>b__44_0(MegaCrit.Sts2.Core.Runs.PlayerMapPointHistoryEntry e)
private System.Void PopulateActionStats(MegaCrit.Sts2.Core.Runs.PlayerMapPointHistoryEntry playerEntry)
private System.Void PopulateRewardAndSkippedEntries(MegaCrit.Sts2.Core.Runs.PlayerMapPointHistoryEntry playerEntry)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.HoverTips.NMapPointHistoryHoverTip Create(System.Int32 floorNum, System.UInt64 playerId, MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry historyEntry)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.HoverTips.NMapPointHistoryHoverTip+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.HoverTips.NMapPointHistoryHoverTip+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Runs.History.MapPointRoomHistoryEntry, System.Boolean> <>9__45_0
private static .cctor()
public .ctor()
internal System.Boolean <PopulateActionStats>b__45_0(MegaCrit.Sts2.Core.Runs.History.MapPointRoomHistoryEntry r)
```

## MegaCrit.Sts2.Core.Nodes.HoverTips.NMapPointHistoryHoverTip+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.MarginContainer+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.HoverTips.NMapPointHistoryHoverTip+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.MarginContainer+PropertyName`。

接口：

```text
public static readonly Godot.StringName _actionStats
public static readonly Godot.StringName _floorNum
public static readonly Godot.StringName _playerId
public static readonly Godot.StringName _playerStats
public static readonly Godot.StringName _rewardStatsContainer
public static readonly Godot.StringName _roomStats
public static readonly Godot.StringName _skippedStatsContainer
public static readonly Godot.StringName _titleLabel
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.HoverTips.NMapPointHistoryHoverTip+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.MarginContainer+SignalName`。

接口：

```text
public .ctor()
```
