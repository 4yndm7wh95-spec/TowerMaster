# MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.GameOverType

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.GameOverType AbandonedRun = 1
public static const MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.GameOverType CombatDeath = 3
public static const MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.GameOverType EventDeath = 2
public static const MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.GameOverType FalseVictory = 4
public static const MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.GameOverType None = 0
public static const MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.GameOverType TrueVictory = 5
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NActHistoryEntry

类型属性：`Public, BeforeFieldInit`；基类：`Godot.HBoxContainer`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.addons.mega_text.MegaLabel _actLabel
private MegaCrit.Sts2.Core.Localization.LocString _actName
private System.Int32 _baseFloorNum
private System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry> _entries
private MegaCrit.Sts2.Core.Runs.RunHistory _runHistory
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NMapPointHistoryEntry> <Entries>k__BackingField
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NMapPointHistoryEntry> Entries { public get; private set; }
System.String ScenePath { private static get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private static System.String get_ScenePath()
private System.Void set_Entries(System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NMapPointHistoryEntry> value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NActHistoryEntry Create(MegaCrit.Sts2.Core.Localization.LocString actName, MegaCrit.Sts2.Core.Runs.RunHistory runHistory, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry> logs, System.Int32 baseFloorNum)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NMapPointHistoryEntry> get_Entries()
public System.Void SetPlayer(MegaCrit.Sts2.Core.Runs.RunHistoryPlayer player)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NActHistoryEntry+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.HBoxContainer+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NActHistoryEntry+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.HBoxContainer+PropertyName`。

接口：

```text
public static readonly Godot.StringName _actLabel
public static readonly Godot.StringName _baseFloorNum
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NActHistoryEntry+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.HBoxContainer+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NDeckHistory

类型属性：`Public, BeforeFieldInit`；基类：`Godot.VBoxContainer`。

接口：`System.IDisposable`

```text
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.CardModel> _allCards
private readonly MegaCrit.Sts2.Core.Localization.LocString _cardCategories
private Godot.Control _cardContainer
private readonly MegaCrit.Sts2.Core.Localization.LocString _deckHeader
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _headerLabel
private MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NDeckHistory+HoveredEventHandler backing_Hovered
private MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NDeckHistory+UnhoveredEventHandler backing_Unhovered
event MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NDeckHistory+HoveredEventHandler Hovered
event MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NDeckHistory+UnhoveredEventHandler Unhovered
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotSignalList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnEntryFocused(MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NDeckHistoryEntry entry)
private System.Void OnEntryUnfocused(MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NDeckHistoryEntry entry)
private System.Void PopulateCards(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Saves.Runs.SerializableCard> cards)
private System.Void ShowEntry(MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NDeckHistoryEntry entry)
protected System.Void EmitSignalHovered(MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NDeckHistoryEntry deckHistoryEntry)
protected System.Void EmitSignalUnhovered(MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NDeckHistoryEntry deckHistoryEntry)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean HasGodotClassSignal(in Godot.NativeInterop.godot_string_name signal)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RaiseGodotClassSignalCallbacks(in Godot.NativeInterop.godot_string_name signal, Godot.NativeInterop.NativeVariantPtrArgs args)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void add_Hovered(MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NDeckHistory+HoveredEventHandler value)
public System.Void add_Unhovered(MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NDeckHistory+UnhoveredEventHandler value)
public System.Void LoadDeck(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Saves.Runs.SerializableCard> cards)
public System.Void remove_Hovered(MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NDeckHistory+HoveredEventHandler value)
public System.Void remove_Unhovered(MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NDeckHistory+UnhoveredEventHandler value)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NDeckHistory+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NDeckHistory+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Saves.Runs.SerializableCard, MegaCrit.Sts2.Core.Saves.Runs.SerializableCard> <>9__9_0
public static System.Func<MegaCrit.Sts2.Core.Saves.Runs.SerializableCard, System.Boolean> <>9__9_1
public static System.Func<MegaCrit.Sts2.Core.Saves.Runs.SerializableCard, System.Int32> <>9__9_2
private static .cctor()
public .ctor()
internal MegaCrit.Sts2.Core.Saves.Runs.SerializableCard <PopulateCards>b__9_0(MegaCrit.Sts2.Core.Saves.Runs.SerializableCard x)
internal System.Boolean <PopulateCards>b__9_1(MegaCrit.Sts2.Core.Saves.Runs.SerializableCard c)
internal System.Int32 <PopulateCards>b__9_2(MegaCrit.Sts2.Core.Saves.Runs.SerializableCard c)
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NDeckHistory+HoveredEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NDeckHistoryEntry deckHistoryEntry, System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke(MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NDeckHistoryEntry deckHistoryEntry)
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NDeckHistory+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.VBoxContainer+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnEntryFocused
public static readonly Godot.StringName OnEntryUnfocused
public static readonly Godot.StringName ShowEntry
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NDeckHistory+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.VBoxContainer+PropertyName`。

接口：

```text
public static readonly Godot.StringName _cardContainer
public static readonly Godot.StringName _headerLabel
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NDeckHistory+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.VBoxContainer+SignalName`。

接口：

```text
public static readonly Godot.StringName Hovered
public static readonly Godot.StringName Unhovered
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NDeckHistory+UnhoveredEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NDeckHistoryEntry deckHistoryEntry, System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke(MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NDeckHistoryEntry deckHistoryEntry)
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NDeckHistoryEntry

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private System.Int32 _amount
private MegaCrit.Sts2.Core.Nodes.Cards.NTinyCard _cardImage
private Godot.TextureRect _enchantmentImage
private Godot.MarginContainer _labelContainer
private Godot.Tween _scaleTween
private MegaCrit.Sts2.addons.mega_text.MegaLabel _titleLabel
private MegaCrit.Sts2.Core.Models.CardModel <Card>k__BackingField
private System.Collections.Generic.IEnumerable<System.Int32> <FloorsAddedToDeck>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NDeckHistoryEntry+ClickedEventHandler backing_Clicked
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
MegaCrit.Sts2.Core.Models.CardModel Card { public get; private set; }
System.Collections.Generic.IEnumerable<System.Int32> FloorsAddedToDeck { public get; private set; }
System.String ScenePath { private static get; }
event MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NDeckHistoryEntry+ClickedEventHandler Clicked
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotSignalList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private static System.String get_ScenePath()
private System.Void Reload()
private System.Void set_Card(MegaCrit.Sts2.Core.Models.CardModel value)
private System.Void set_FloorsAddedToDeck(System.Collections.Generic.IEnumerable<System.Int32> value)
protected System.Void EmitSignalClicked(MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NDeckHistoryEntry entry)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean HasGodotClassSignal(in Godot.NativeInterop.godot_string_name signal)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnFocus()
protected virtual System.Void OnRelease()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RaiseGodotClassSignalCallbacks(in Godot.NativeInterop.godot_string_name signal, Godot.NativeInterop.NativeVariantPtrArgs args)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public MegaCrit.Sts2.Core.Models.CardModel get_Card()
public static MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NDeckHistoryEntry Create(MegaCrit.Sts2.Core.Models.CardModel card, System.Int32 amount, System.Collections.Generic.IEnumerable<System.Int32> floorsAdded)
public static MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NDeckHistoryEntry Create(MegaCrit.Sts2.Core.Models.CardModel card, System.Int32 amount)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Collections.Generic.IEnumerable<System.Int32> get_FloorsAddedToDeck()
public System.Void add_Clicked(MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NDeckHistoryEntry+ClickedEventHandler value)
public System.Void remove_Clicked(MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NDeckHistoryEntry+ClickedEventHandler value)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NDeckHistoryEntry+ClickedEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NDeckHistoryEntry entry, System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke(MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NDeckHistoryEntry entry)
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NDeckHistoryEntry+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName Reload
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NDeckHistoryEntry+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _amount
public static readonly Godot.StringName _cardImage
public static readonly Godot.StringName _enchantmentImage
public static readonly Godot.StringName _labelContainer
public static readonly Godot.StringName _scaleTween
public static readonly Godot.StringName _titleLabel
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NDeckHistoryEntry+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public static readonly Godot.StringName Clicked
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NMapPointHistory

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private Godot.Control _actContainer
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NActHistoryEntry> _actHistories
Godot.Control DefaultFocusedControl { public get; }
System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NMapPointHistoryEntry> MapHistories { private get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NMapPointHistoryEntry> get_MapHistories()
private System.Void HighlightRelevantEntries(MegaCrit.Sts2.Core.Nodes.Relics.NRelicBasicHolder holder)
private System.Void HighlightRelevantEntries(MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NDeckHistoryEntry historyEntry)
private System.Void UnHighlightEntries()
private System.Void UnHighlightEntries(MegaCrit.Sts2.Core.Nodes.Relics.NRelicBasicHolder _)
private System.Void UnHighlightEntries(MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NDeckHistoryEntry _)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public Godot.Control get_DefaultFocusedControl()
public System.Void LoadHistory(MegaCrit.Sts2.Core.Runs.RunHistory history)
public System.Void SetDeckHistory(MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NDeckHistory deckHistory)
public System.Void SetPlayer(MegaCrit.Sts2.Core.Runs.RunHistoryPlayer player)
public System.Void SetRelicHistory(MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NRelicHistory relicHistory)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NMapPointHistory+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NMapPointHistory+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NActHistoryEntry, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NMapPointHistoryEntry>> <>9__3_0
private static .cctor()
public .ctor()
internal System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NMapPointHistoryEntry> <get_MapHistories>b__3_0(MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NActHistoryEntry a)
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NMapPointHistory+<>c__DisplayClass11_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.Int32 floorNumber
public .ctor()
internal System.Boolean <HighlightRelevantEntries>b__0(MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NMapPointHistoryEntry e)
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NMapPointHistory+<>c__DisplayClass12_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Relics.NRelicBasicHolder holder
public .ctor()
internal System.Boolean <HighlightRelevantEntries>b__0(MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NMapPointHistoryEntry e)
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NMapPointHistory+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName HighlightRelevantEntries
public static readonly Godot.StringName SetDeckHistory
public static readonly Godot.StringName SetRelicHistory
public static readonly Godot.StringName UnHighlightEntries
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NMapPointHistory+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _actContainer
public static readonly Godot.StringName DefaultFocusedControl
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NMapPointHistory+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NMapPointHistoryEntry

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl`。

接口：`System.IDisposable`

```text
private Godot.Tween _animateInTween
private System.Single _baseAngle
private Godot.Vector2 _baseScale
private MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry _entry
private Godot.Tween _hoverTween
private System.Boolean _hurryUp
private Godot.TextureRect _outline
private MegaCrit.Sts2.Core.Runs.RunHistoryPlayer _player
private Godot.TextureRect _questIcon
private MegaCrit.Sts2.Core.Runs.RunHistory _runHistory
private Godot.TextureRect _texture
private System.Int32 <FloorNum>k__BackingField
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
System.Int32 FloorNum { public get; private set; }
System.String ScenePath { private static get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task DoAnimateInEffects()
private [async] System.Threading.Tasks.Task DoCombatAnimateInEffects(MegaCrit.Sts2.Core.Rooms.RoomType roomType)
private [async] System.Threading.Tasks.Task PlaySfx(System.Collections.Generic.List<System.String> sfxPaths)
private static System.Collections.Generic.IEnumerable<System.String> GetAssetPaths()
private static System.String get_ScenePath()
private System.Collections.Generic.List<System.String> GetBigHitSfx(MegaCrit.Sts2.Core.Models.CharacterModel character)
private System.Collections.Generic.List<System.String> GetSmallHitSfx(MegaCrit.Sts2.Core.Models.CharacterModel character)
private System.Single GetSfxVolume()
private System.Void set_FloorNum(System.Int32 value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnFocus()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public [async] System.Threading.Tasks.Task AnimateIn(System.Int32 index)
public static MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NMapPointHistoryEntry Create(MegaCrit.Sts2.Core.Runs.RunHistory history, MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry entry, System.Int32 floorNum)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Int32 get_FloorNum()
public System.Void Highlight()
public System.Void HurryUp()
public System.Void SetPlayer(MegaCrit.Sts2.Core.Runs.RunHistoryPlayer player)
public System.Void SetupForAnimation()
public System.Void Unhighlight()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NMapPointHistoryEntry+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NMapPointHistoryEntry+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Models.EncounterModel, System.Boolean> <>9__4_0
private static .cctor()
public .ctor()
internal System.Boolean <GetAssetPaths>b__4_0(MegaCrit.Sts2.Core.Models.EncounterModel e)
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NMapPointHistoryEntry+<>c__DisplayClass23_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NMapPointHistoryEntry <>4__this
public MegaCrit.Sts2.Core.HoverTips.HoverTipAlignment alignment
public MegaCrit.Sts2.Core.Nodes.HoverTips.NHoverTipSet tip
public .ctor()
internal System.Void <OnFocus>b__0()
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NMapPointHistoryEntry+<AnimateIn>d__27

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NMapPointHistoryEntry <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public System.Int32 index
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NMapPointHistoryEntry+<DoAnimateInEffects>d__28

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NMapPointHistoryEntry <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NMapPointHistoryEntry+<DoCombatAnimateInEffects>d__29

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NMapPointHistoryEntry <>4__this
private System.Collections.Generic.List+Enumerator<MegaCrit.Sts2.Core.Models.ModelId> <>7__wrap2
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Nullable<MegaCrit.Sts2.Core.Nodes.Vfx.Utilities.ShakeStrength> <shakeStrength>5__2
public MegaCrit.Sts2.Core.Rooms.RoomType roomType
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NMapPointHistoryEntry+<GetAssetPaths>d__4

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：`System.Collections.Generic.IEnumerable<System.String>`, `System.Collections.IEnumerable`, `System.Collections.Generic.IEnumerator<System.String>`, `System.Collections.IEnumerator`, `System.IDisposable`

```text
private System.Int32 <>1__state
private System.String <>2__current
private MegaCrit.Sts2.Core.Rooms.RoomType[] <>7__wrap1
private System.Int32 <>7__wrap2
private System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Models.EncounterModel> <>7__wrap4
private System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Models.AncientEventModel> <>7__wrap6
private System.Int32 <>l__initialThreadId
private MegaCrit.Sts2.Core.Models.AncientEventModel <ancient>5__8
private MegaCrit.Sts2.Core.Models.EncounterModel <encounter>5__6
private MegaCrit.Sts2.Core.Rooms.RoomType <roomType>5__4
System.String System.Collections.Generic.IEnumerator<System.String>.Current { private virtual get; }
System.Object System.Collections.IEnumerator.Current { private virtual get; }
public .ctor(System.Int32 <>1__state)
private System.Void <>m__Finally1()
private System.Void <>m__Finally2()
private virtual System.Boolean MoveNext()
private virtual System.Collections.Generic.IEnumerator<System.String> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator()
private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
private virtual System.Object System.Collections.IEnumerator.get_Current()
private virtual System.String System.Collections.Generic.IEnumerator<System.String>.get_Current()
private virtual System.Void System.Collections.IEnumerator.Reset()
private virtual System.Void System.IDisposable.Dispose()
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NMapPointHistoryEntry+<PlaySfx>d__32

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NMapPointHistoryEntry <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Int32 <i>5__2
public System.Collections.Generic.List<System.String> sfxPaths
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NMapPointHistoryEntry+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName GetSfxVolume
public static readonly Godot.StringName Highlight
public static readonly Godot.StringName HurryUp
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName SetupForAnimation
public static readonly Godot.StringName Unhighlight
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NMapPointHistoryEntry+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+PropertyName`。

接口：

```text
public static readonly Godot.StringName _animateInTween
public static readonly Godot.StringName _baseAngle
public static readonly Godot.StringName _baseScale
public static readonly Godot.StringName _hoverTween
public static readonly Godot.StringName _hurryUp
public static readonly Godot.StringName _outline
public static readonly Godot.StringName _questIcon
public static readonly Godot.StringName _texture
public static readonly Godot.StringName FloorNum
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NMapPointHistoryEntry+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NRelicHistory

类型属性：`Public, BeforeFieldInit`；基类：`Godot.VBoxContainer`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _headerLabel
private readonly MegaCrit.Sts2.Core.Localization.LocString _relicCategories
private readonly MegaCrit.Sts2.Core.Localization.LocString _relicHeader
private Godot.Control _relicsContainer
private MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NRelicHistory+HoveredEventHandler backing_Hovered
private MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NRelicHistory+UnhoveredEventHandler backing_Unhovered
event MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NRelicHistory+HoveredEventHandler Hovered
event MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NRelicHistory+UnhoveredEventHandler Unhovered
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotSignalList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnRelicClicked(MegaCrit.Sts2.Core.Nodes.Relics.NRelic node)
private System.Void OnRelicHolderReleased(MegaCrit.Sts2.Core.Nodes.Relics.NRelicBasicHolder holder)
protected System.Void EmitSignalHovered(MegaCrit.Sts2.Core.Nodes.Relics.NRelicBasicHolder relic)
protected System.Void EmitSignalUnhovered(MegaCrit.Sts2.Core.Nodes.Relics.NRelicBasicHolder relic)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean HasGodotClassSignal(in Godot.NativeInterop.godot_string_name signal)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RaiseGodotClassSignalCallbacks(in Godot.NativeInterop.godot_string_name signal, Godot.NativeInterop.NativeVariantPtrArgs args)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void add_Hovered(MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NRelicHistory+HoveredEventHandler value)
public System.Void add_Unhovered(MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NRelicHistory+UnhoveredEventHandler value)
public System.Void LoadRelics(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Saves.Runs.SerializableRelic> relics)
public System.Void remove_Hovered(MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NRelicHistory+HoveredEventHandler value)
public System.Void remove_Unhovered(MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NRelicHistory+UnhoveredEventHandler value)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NRelicHistory+<>c__DisplayClass7_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NRelicHistory <>4__this
public MegaCrit.Sts2.Core.Nodes.Relics.NRelicBasicHolder holder
public .ctor()
internal System.Void <LoadRelics>b__0()
internal System.Void <LoadRelics>b__1()
internal System.Void <LoadRelics>b__2()
internal System.Void <LoadRelics>b__3()
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NRelicHistory+HoveredEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(MegaCrit.Sts2.Core.Nodes.Relics.NRelicBasicHolder relic, System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke(MegaCrit.Sts2.Core.Nodes.Relics.NRelicBasicHolder relic)
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NRelicHistory+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.VBoxContainer+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnRelicClicked
public static readonly Godot.StringName OnRelicHolderReleased
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NRelicHistory+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.VBoxContainer+PropertyName`。

接口：

```text
public static readonly Godot.StringName _headerLabel
public static readonly Godot.StringName _relicsContainer
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NRelicHistory+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.VBoxContainer+SignalName`。

接口：

```text
public static readonly Godot.StringName Hovered
public static readonly Godot.StringName Unhovered
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NRelicHistory+UnhoveredEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(MegaCrit.Sts2.Core.Nodes.Relics.NRelicBasicHolder relic, System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke(MegaCrit.Sts2.Core.Nodes.Relics.NRelicBasicHolder relic)
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NRunHistory

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private Godot.Control _badgeContainer
private static const System.Single _bottomScrollbarPadding = 25
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _buildLabel
private readonly MegaCrit.Sts2.Core.Localization.LocString _dateFormat
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _dateLabel
private readonly MegaCrit.Sts2.Core.Localization.LocString _dateTimeLocString
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _deathQuoteLabel
private MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NDeckHistory _deckHistory
private MegaCrit.Sts2.addons.mega_text.MegaLabel _floorLabel
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _gameModeLabel
private MegaCrit.Sts2.addons.mega_text.MegaLabel _goldLabel
private MegaCrit.Sts2.Core.Runs.RunHistory _history
private MegaCrit.Sts2.addons.mega_text.MegaLabel _hpLabel
private System.Int32 _index
private static readonly MegaCrit.Sts2.Core.Localization.LocString _leftQuote
private MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NMapPointHistory _mapPointHistory
private MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NRunHistoryArrowButton _nextButton
private Godot.Control _outOfDateVisual
private Godot.Control _playerIconContainer
private Godot.Control _potionHolder
private MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NRunHistoryArrowButton _prevButton
private MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NRelicHistory _relicHistory
private static readonly MegaCrit.Sts2.Core.Localization.LocString _rightQuote
private readonly System.Collections.Generic.List<System.String> _runNames
private static readonly System.String _scenePath
private MegaCrit.Sts2.Core.Nodes.GodotExtensions.NScrollableContainer _screenContents
private Godot.Tween _screenTween
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _seedLabel
private readonly MegaCrit.Sts2.Core.Localization.LocString _seedLocString
private MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NRunHistoryPlayerIcon _selectedPlayerIcon
private readonly MegaCrit.Sts2.Core.Localization.LocString _timeFormat
private MegaCrit.Sts2.addons.mega_text.MegaLabel _timeLabel
public static const System.String locTable = "run_history"
System.String[] AssetPaths { public static get; }
Godot.Control InitialFocusedControl { protected virtual get; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task ResizeScreen()
private static MegaCrit.Sts2.Core.Localization.LocString GetDeathDebugMessage()
private System.Threading.Tasks.Task RefreshAndSelectRun(System.Int32 index)
private System.Void DisplayRun(MegaCrit.Sts2.Core.Runs.RunHistory history)
private System.Void LoadBadges(System.Collections.Generic.List<MegaCrit.Sts2.Core.Saves.Runs.SerializableBadge> badges)
private System.Void LoadDeathQuote(MegaCrit.Sts2.Core.Runs.RunHistory history, MegaCrit.Sts2.Core.Models.ModelId characterId)
private System.Void LoadGameModeDetails(MegaCrit.Sts2.Core.Runs.RunHistory history)
private System.Void LoadGoldHpAndPotionInfo(MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NRunHistoryPlayerIcon icon)
private System.Void LoadPlayerFloor(MegaCrit.Sts2.Core.Runs.RunHistory history)
private System.Void LoadTimeDetails(MegaCrit.Sts2.Core.Runs.RunHistory history)
private System.Void OnLeftButtonButtonReleased(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OnRightButtonButtonReleased(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void SelectPlayer(MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NRunHistoryPlayerIcon playerIcon)
protected virtual Godot.Control get_InitialFocusedControl()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnSubmenuHidden()
protected virtual System.Void OnSubmenuShown()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.GameOverType GetGameOverType(MegaCrit.Sts2.Core.Runs.RunHistory history)
public static MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NRunHistory Create()
public static System.Boolean CanBeShown()
public static System.String GetDeathQuote(MegaCrit.Sts2.Core.Runs.RunHistory history, MegaCrit.Sts2.Core.Models.ModelId characterId, MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.GameOverType gameOverType)
public static System.String[] get_AssetPaths()
public virtual System.Void _Input(Godot.InputEvent inputEvent)
public virtual System.Void _Ready()
public virtual System.Void OnSubmenuOpened()
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NRunHistory+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NRunHistory+<>c <>9
public static System.Func<System.Collections.Generic.List<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry>, System.Int32> <>9__51_0
private static .cctor()
public .ctor()
internal System.Int32 <LoadPlayerFloor>b__51_0(System.Collections.Generic.List<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry> rooms)
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NRunHistory+<>c__DisplayClass48_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Entities.Players.Player player
public .ctor()
internal System.Boolean <SelectPlayer>b__0(MegaCrit.Sts2.Core.Runs.RunHistoryPlayer p)
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NRunHistory+<>c__DisplayClass50_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NRunHistoryPlayerIcon icon
public .ctor()
internal System.Boolean <LoadGoldHpAndPotionInfo>b__0(MegaCrit.Sts2.Core.Runs.RunHistoryPlayer player)
internal System.Boolean <LoadGoldHpAndPotionInfo>b__1(MegaCrit.Sts2.Core.Runs.PlayerMapPointHistoryEntry stat)
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NRunHistory+<>O

类型属性：`NestedPrivate, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static System.Func<MegaCrit.Sts2.Core.Saves.Runs.SerializablePotion, MegaCrit.Sts2.Core.Models.PotionModel> <0>__FromSerializable
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NRunHistory+<ResizeScreen>d__49

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NRunHistory <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NRunHistory+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+MethodName`。

接口：

```text
public static readonly Godot.StringName _Input
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName CanBeShown
public static readonly Godot.StringName Create
public static readonly Godot.StringName LoadGoldHpAndPotionInfo
public static readonly Godot.StringName OnLeftButtonButtonReleased
public static readonly Godot.StringName OnRightButtonButtonReleased
public static readonly Godot.StringName OnSubmenuHidden
public static readonly Godot.StringName OnSubmenuOpened
public static readonly Godot.StringName OnSubmenuShown
public static readonly Godot.StringName SelectPlayer
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NRunHistory+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+PropertyName`。

接口：

```text
public static readonly Godot.StringName _badgeContainer
public static readonly Godot.StringName _buildLabel
public static readonly Godot.StringName _dateLabel
public static readonly Godot.StringName _deathQuoteLabel
public static readonly Godot.StringName _deckHistory
public static readonly Godot.StringName _floorLabel
public static readonly Godot.StringName _gameModeLabel
public static readonly Godot.StringName _goldLabel
public static readonly Godot.StringName _hpLabel
public static readonly Godot.StringName _index
public static readonly Godot.StringName _mapPointHistory
public static readonly Godot.StringName _nextButton
public static readonly Godot.StringName _outOfDateVisual
public static readonly Godot.StringName _playerIconContainer
public static readonly Godot.StringName _potionHolder
public static readonly Godot.StringName _prevButton
public static readonly Godot.StringName _relicHistory
public static readonly Godot.StringName _screenContents
public static readonly Godot.StringName _screenTween
public static readonly Godot.StringName _seedLabel
public static readonly Godot.StringName _selectedPlayerIcon
public static readonly Godot.StringName _timeLabel
public static readonly Godot.StringName InitialFocusedControl
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NRunHistory+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NRunHistoryArrowButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NGoldArrowButton`。

接口：`System.IDisposable`

```text
private System.Boolean _isLeft
System.String[] Hotkeys { protected virtual get; }
System.Boolean IsLeft { public get; public set; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.String[] get_Hotkeys()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Boolean get_IsLeft()
public System.Void set_IsLeft(System.Boolean value)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NRunHistoryArrowButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NGoldArrowButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NRunHistoryArrowButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NGoldArrowButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _isLeft
public static readonly Godot.StringName Hotkeys
public static readonly Godot.StringName IsLeft
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NRunHistoryArrowButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NGoldArrowButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NRunHistoryPlayerIcon

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private Godot.Control _achievementLock
private Godot.Control _ascensionIcon
private MegaCrit.Sts2.addons.mega_text.MegaLabel _ascensionLabel
private static readonly Godot.Vector2 _disabledScale
private static readonly Godot.Vector2 _enabledScale
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.HoverTips.IHoverTip> _hoverTips
private Godot.ShaderMaterial _hsv
private Godot.TextureRect _icon
private static readonly Godot.StringName _s
private MegaCrit.Sts2.Core.Nodes.Combat.NSelectionReticle _selectionReticle
private Godot.Tween _tween
private static readonly Godot.StringName _v
private MegaCrit.Sts2.Core.Runs.RunHistoryPlayer <Player>k__BackingField
public static readonly System.String scenePath
MegaCrit.Sts2.Core.Runs.RunHistoryPlayer Player { public get; private set; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void set_Player(MegaCrit.Sts2.Core.Runs.RunHistoryPlayer value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnFocus()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public MegaCrit.Sts2.Core.Runs.RunHistoryPlayer get_Player()
public System.Void Deselect()
public System.Void LoadRun(MegaCrit.Sts2.Core.Runs.RunHistoryPlayer player, MegaCrit.Sts2.Core.Runs.RunHistory history)
public System.Void Select()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NRunHistoryPlayerIcon+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Deselect
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName Select
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NRunHistoryPlayerIcon+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _achievementLock
public static readonly Godot.StringName _ascensionIcon
public static readonly Godot.StringName _ascensionLabel
public static readonly Godot.StringName _hsv
public static readonly Godot.StringName _icon
public static readonly Godot.StringName _selectionReticle
public static readonly Godot.StringName _tween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NRunHistoryPlayerIcon+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```
