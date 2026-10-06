# MegaCrit.Sts2.Core.Nodes.Screens.Bestiary

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.BestiaryEntry

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Models.EncounterModel encounterModel
public MegaCrit.Sts2.Core.Models.MonsterModel monsterModel
public MegaCrit.Sts2.Core.Rooms.RoomType roomType
public .ctor()
public MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryLayout CreateLayoutNode(MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiary bestiary)
public static MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.BestiaryEntry FromEncounter(MegaCrit.Sts2.Core.Models.EncounterModel encounter, MegaCrit.Sts2.Core.Rooms.RoomType type)
public static MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.BestiaryEntry FromMonster(MegaCrit.Sts2.Core.Models.MonsterModel monster, MegaCrit.Sts2.Core.Models.EncounterModel encounter, MegaCrit.Sts2.Core.Rooms.RoomType type)
public System.Boolean CanReuseLayout(MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryLayout layout)
public System.Boolean IsDiscovered(System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Models.ModelId> discoveredMonsterIds, System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Models.ModelId> discoveredEncounterIds)
public System.String GetEncounterTitle()
public System.String GetEntryTitle()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiary

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private static readonly Godot.Vector2 _arrowOffset
private Godot.Tween _arrowTween
private Godot.VBoxContainer _bestiaryList
private Godot.Control _characterIcon
private MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryCharacterFilter _currentFilter
private MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryLayout _currentLayout
private Godot.Control _dialogueBubble
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _dialogueLabel
private Godot.Control _dialogueLine
private Godot.TextureRect _dialogueTail
private static const System.String _dialogueTailPath = "res://images/ui/dialogue_tail.png"
private Godot.TextureRect _dialogueTailShadow
private Godot.Tween _dialogueTween
private System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Models.ModelId> _discoveredEncounterIds
private System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Models.ModelId> _discoveredMonsterIds
private MegaCrit.Sts2.addons.mega_text.MegaLabel _epithet
private Godot.Control _filterContainer
private static readonly Godot.StringName _filterLeftHotkey
private static readonly Godot.StringName _filterRightHotkey
private Godot.TextureRect _iconOutlineTexture
private Godot.TextureRect _iconTexture
private System.Boolean _initSelectionArrow
private System.Boolean _isStatsMode
private Godot.Control _layoutContainer
private static readonly MegaCrit.Sts2.Core.Localization.LocString _locked
private MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryModeButton _modeButton
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _monsterNameLabel
private Godot.Control _moveContainer
private Godot.Control _moveList
private MegaCrit.Sts2.Core.Nodes.CommonUi.NHotkeyIcon _pageLeftIcon
private MegaCrit.Sts2.Core.Nodes.CommonUi.NHotkeyIcon _pageRightIcon
private Godot.Control _previousScreenshakeTarget
private MegaCrit.Sts2.Core.Saves.SerializableProgress _progress
private static readonly System.String _scenePath
private MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryEntry _selectedEntry
private Godot.Control _selectionArrow
private MegaCrit.Sts2.Core.Nodes.GodotExtensions.NScrollableContainer _sidebar
private Godot.Control _statsContainer
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _statsLabel
private static const System.String _thoughtTailPath = "res://images/ui/thought_tail.png"
private Godot.Tween _tween
private Godot.Control <BackVfxContainer>k__BackingField
private static MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiary <Instance>k__BackingField
private Godot.Control <VfxContainer>k__BackingField
System.String[] AssetPaths { public static get; }
Godot.Control BackVfxContainer { public get; private set; }
Godot.Control InitialFocusedControl { protected virtual get; }
MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiary Instance { public static get; private static set; }
Godot.Control Layout { public get; }
Godot.Control VfxContainer { public get; private set; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task InitializeSelectorArrow(MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryEntry entry)
private MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryMoveButton CreateBestiaryMoveButton(MegaCrit.Sts2.Core.Models.BestiaryMonsterMove move, System.Int32 moveIndex)
private static System.Void PlayMoveAnim(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Nodes.Combat.NCreature> creatures, MegaCrit.Sts2.Core.Models.BestiaryMonsterMove move)
private static System.Void set_Instance(MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiary value)
private System.Void AddAct(MegaCrit.Sts2.Core.Models.ActModel act)
private System.Void AddEntries(System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.BestiaryEntry> entries)
private System.Void AddEvents()
private System.Void AddFilter(MegaCrit.Sts2.Core.Models.CharacterModel character)
private System.Void CreateEntries()
private System.Void CreateFilters()
private System.Void DisableMoveButtonHotkeys()
private System.Void DisableStatsModeHotkeys()
private System.Void DisplayCharacterData()
private System.Void EnableMoveButtonHotkeys()
private System.Void EnableStatsModeHotkeys()
private System.Void FilterLeft()
private System.Void FilterRight()
private System.Void HideDialogue()
private System.Void OnCharacterFilterSelected(MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryCharacterFilter selectedFilter)
private System.Void OnMonsterClicked(MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryEntry entry)
private System.Void OnMoveButtonClicked(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton button)
private System.Void RefreshStatisticsText()
private System.Void SelectFilter(MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryCharacterFilter filter)
private System.Void SelectMonster(MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryEntry entry)
private System.Void set_BackVfxContainer(Godot.Control value)
private System.Void set_VfxContainer(Godot.Control value)
private System.Void ShowDialogue()
private System.Void ShowMovesPanel()
private System.Void ShowStatsPanel()
private System.Void ToggleMode(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void UpdateDialogueBubbleStyle()
private System.Void UpdatePageIcons()
protected virtual Godot.Control get_InitialFocusedControl()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public Godot.Control get_BackVfxContainer()
public Godot.Control get_Layout()
public Godot.Control get_VfxContainer()
public Godot.Vector2 GetSideCenter()
public Godot.Vector2 GetSideFloor()
public MegaCrit.Sts2.Core.Nodes.Combat.NCreature GetCreatureNode(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public static MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiary Create()
public static MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiary get_Instance()
public static System.Boolean CanBeShown()
public static System.String[] get_AssetPaths()
public virtual System.Void _Ready()
public virtual System.Void OnSubmenuClosed()
public virtual System.Void OnSubmenuOpened()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiary+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiary+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Saves.EnemyStats, System.Boolean> <>9__73_0
public static System.Func<MegaCrit.Sts2.Core.Saves.EnemyStats, MegaCrit.Sts2.Core.Models.ModelId> <>9__73_1
public static System.Func<MegaCrit.Sts2.Core.Saves.EncounterStats, System.Boolean> <>9__73_2
public static System.Func<MegaCrit.Sts2.Core.Saves.EncounterStats, MegaCrit.Sts2.Core.Models.ModelId> <>9__73_3
public static System.Func<MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryEntry, System.Boolean> <>9__73_4
public static System.Comparison<MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.BestiaryEntry> <>9__79_0
public static System.Func<MegaCrit.Sts2.Core.Saves.EnemyStats, System.Boolean> <>9__95_0
private static .cctor()
public .ctor()
internal MegaCrit.Sts2.Core.Models.ModelId <CreateEntries>b__73_1(MegaCrit.Sts2.Core.Saves.EnemyStats e)
internal MegaCrit.Sts2.Core.Models.ModelId <CreateEntries>b__73_3(MegaCrit.Sts2.Core.Saves.EncounterStats e)
internal System.Boolean <CanBeShown>b__95_0(MegaCrit.Sts2.Core.Saves.EnemyStats e)
internal System.Boolean <CreateEntries>b__73_0(MegaCrit.Sts2.Core.Saves.EnemyStats e)
internal System.Boolean <CreateEntries>b__73_2(MegaCrit.Sts2.Core.Saves.EncounterStats e)
internal System.Boolean <CreateEntries>b__73_4(MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryEntry e)
internal System.Int32 <AddEntries>b__79_0(MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.BestiaryEntry e1, MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.BestiaryEntry e2)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiary+<>c__DisplayClass66_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.BestiaryEntry entry
public .ctor()
internal System.Boolean <RefreshStatisticsText>b__0(MegaCrit.Sts2.Core.Saves.EnemyStats e)
internal System.Boolean <RefreshStatisticsText>b__1(MegaCrit.Sts2.Core.Saves.EncounterStats e)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiary+<>c__DisplayClass66_1

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryCharacterFilter filter
public .ctor()
internal System.Boolean <RefreshStatisticsText>b__2(MegaCrit.Sts2.Core.Saves.FightStats f)
internal System.Boolean <RefreshStatisticsText>b__3(MegaCrit.Sts2.Core.Saves.FightStats f)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiary+<InitializeSelectorArrow>d__83

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiary <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Object <>u__1
public MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryEntry entry
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiary+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AddEvents
public static readonly Godot.StringName CanBeShown
public static readonly Godot.StringName Create
public static readonly Godot.StringName CreateEntries
public static readonly Godot.StringName CreateFilters
public static readonly Godot.StringName DisableMoveButtonHotkeys
public static readonly Godot.StringName DisableStatsModeHotkeys
public static readonly Godot.StringName DisplayCharacterData
public static readonly Godot.StringName EnableMoveButtonHotkeys
public static readonly Godot.StringName EnableStatsModeHotkeys
public static readonly Godot.StringName FilterLeft
public static readonly Godot.StringName FilterRight
public static readonly Godot.StringName GetSideCenter
public static readonly Godot.StringName GetSideFloor
public static readonly Godot.StringName HideDialogue
public static readonly Godot.StringName OnCharacterFilterSelected
public static readonly Godot.StringName OnMonsterClicked
public static readonly Godot.StringName OnMoveButtonClicked
public static readonly Godot.StringName OnSubmenuClosed
public static readonly Godot.StringName OnSubmenuOpened
public static readonly Godot.StringName RefreshStatisticsText
public static readonly Godot.StringName SelectFilter
public static readonly Godot.StringName SelectMonster
public static readonly Godot.StringName ShowDialogue
public static readonly Godot.StringName ShowMovesPanel
public static readonly Godot.StringName ShowStatsPanel
public static readonly Godot.StringName ToggleMode
public static readonly Godot.StringName UpdateDialogueBubbleStyle
public static readonly Godot.StringName UpdatePageIcons
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiary+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+PropertyName`。

接口：

```text
public static readonly Godot.StringName _arrowTween
public static readonly Godot.StringName _bestiaryList
public static readonly Godot.StringName _characterIcon
public static readonly Godot.StringName _currentFilter
public static readonly Godot.StringName _currentLayout
public static readonly Godot.StringName _dialogueBubble
public static readonly Godot.StringName _dialogueLabel
public static readonly Godot.StringName _dialogueLine
public static readonly Godot.StringName _dialogueTail
public static readonly Godot.StringName _dialogueTailShadow
public static readonly Godot.StringName _dialogueTween
public static readonly Godot.StringName _epithet
public static readonly Godot.StringName _filterContainer
public static readonly Godot.StringName _iconOutlineTexture
public static readonly Godot.StringName _iconTexture
public static readonly Godot.StringName _initSelectionArrow
public static readonly Godot.StringName _isStatsMode
public static readonly Godot.StringName _layoutContainer
public static readonly Godot.StringName _modeButton
public static readonly Godot.StringName _monsterNameLabel
public static readonly Godot.StringName _moveContainer
public static readonly Godot.StringName _moveList
public static readonly Godot.StringName _pageLeftIcon
public static readonly Godot.StringName _pageRightIcon
public static readonly Godot.StringName _previousScreenshakeTarget
public static readonly Godot.StringName _selectedEntry
public static readonly Godot.StringName _selectionArrow
public static readonly Godot.StringName _sidebar
public static readonly Godot.StringName _statsContainer
public static readonly Godot.StringName _statsLabel
public static readonly Godot.StringName _tween
public static readonly Godot.StringName BackVfxContainer
public static readonly Godot.StringName InitialFocusedControl
public static readonly Godot.StringName Layout
public static readonly Godot.StringName VfxContainer
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiary+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryCharacterFilter

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Nodes.Combat.NSelectionReticle _controllerSelectionReticle
private static readonly Godot.Vector2 _disabledScale
private static readonly Godot.Vector2 _enabledScale
private static const System.Single _focusedMultiplier = 1.2
private Godot.ShaderMaterial _hsv
private Godot.TextureRect _image
private System.Boolean _isLocked
private System.Boolean _isSelected
private static const System.Single _pressDownMultiplier = 0.8
private static readonly Godot.StringName _s
private static readonly System.String _scenePath
private Godot.Tween _tween
private static readonly Godot.StringName _v
private MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryCharacterFilter+ToggledEventHandler backing_Toggled
public MegaCrit.Sts2.Core.Models.CharacterModel character
public System.Int32 deaths
public System.Int32 kills
MegaCrit.Sts2.Core.Localization.LocString BestiaryKillQuote { public get; }
System.String BestiarySeenQuote { public get; }
System.Boolean IsLocked { public get; public set; }
System.Boolean IsSelected { public get; public set; }
System.Int32 Total { public get; }
System.String WinRate { public get; }
System.Double WinRateValue { private get; }
event MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryCharacterFilter+ToggledEventHandler Toggled
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotSignalList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Double get_WinRateValue()
private System.Void OnToggle()
private System.Void SetLockedState()
protected System.Void EmitSignalToggled(MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryCharacterFilter filter)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean HasGodotClassSignal(in Godot.NativeInterop.godot_string_name signal)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnFocus()
protected virtual System.Void OnPress()
protected virtual System.Void OnRelease()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RaiseGodotClassSignalCallbacks(in Godot.NativeInterop.godot_string_name signal, Godot.NativeInterop.NativeVariantPtrArgs args)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public MegaCrit.Sts2.Core.Localization.LocString get_BestiaryKillQuote()
public static MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryCharacterFilter Create(MegaCrit.Sts2.Core.Models.CharacterModel character)
public System.Boolean get_IsLocked()
public System.Boolean get_IsSelected()
public System.Int32 get_Total()
public System.String get_BestiarySeenQuote()
public System.String get_WinRate()
public System.Void add_Toggled(MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryCharacterFilter+ToggledEventHandler value)
public System.Void Deselect()
public System.Void remove_Toggled(MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryCharacterFilter+ToggledEventHandler value)
public System.Void set_IsLocked(System.Boolean value)
public System.Void set_IsSelected(System.Boolean value)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryCharacterFilter+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Deselect
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnToggle
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName SetLockedState
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryCharacterFilter+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _controllerSelectionReticle
public static readonly Godot.StringName _hsv
public static readonly Godot.StringName _image
public static readonly Godot.StringName _isLocked
public static readonly Godot.StringName _isSelected
public static readonly Godot.StringName _tween
public static readonly Godot.StringName BestiarySeenQuote
public static readonly Godot.StringName deaths
public static readonly Godot.StringName IsLocked
public static readonly Godot.StringName IsSelected
public static readonly Godot.StringName kills
public static readonly Godot.StringName Total
public static readonly Godot.StringName WinRate
public static readonly Godot.StringName WinRateValue
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryCharacterFilter+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public static readonly Godot.StringName Toggled
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryCharacterFilter+ToggledEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryCharacterFilter filter, System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke(MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryCharacterFilter filter)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryEntry

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private Godot.Color _defaultColor
private Godot.Control _highlight
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _label
private Godot.Tween _tween
private Godot.TextureRect _underConstructionIcon
private MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.BestiaryEntry <Entry>k__BackingField
private System.Boolean <IsDiscovered>k__BackingField
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.BestiaryEntry Entry { public get; private set; }
System.String HoveredSfx { protected virtual get; }
System.Boolean IsDiscovered { public get; private set; }
System.Boolean IsUnderConstruction { public get; }
System.String ScenePath { private static get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private static System.String get_ScenePath()
private System.Void set_Entry(MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.BestiaryEntry value)
private System.Void set_IsDiscovered(System.Boolean value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.String get_HoveredSfx()
protected virtual System.Void OnFocus()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.BestiaryEntry get_Entry()
public static MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryEntry Create(MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.BestiaryEntry entry, System.Boolean isDiscovered)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Boolean get_IsDiscovered()
public System.Boolean get_IsUnderConstruction()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryEntry+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnUnfocus
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryEntry+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _defaultColor
public static readonly Godot.StringName _highlight
public static readonly Godot.StringName _label
public static readonly Godot.StringName _tween
public static readonly Godot.StringName _underConstructionIcon
public static readonly Godot.StringName HoveredSfx
public static readonly Godot.StringName IsDiscovered
public static readonly Godot.StringName IsUnderConstruction
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryEntry+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryLabelDivider

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _nameLabel
private MegaCrit.Sts2.Core.Localization.LocString <LocString>k__BackingField
MegaCrit.Sts2.Core.Localization.LocString LocString { private get; private set; }
System.String ScenePath { private static get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private MegaCrit.Sts2.Core.Localization.LocString get_LocString()
private static System.String get_ScenePath()
private System.Void set_LocString(MegaCrit.Sts2.Core.Localization.LocString value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnFocus()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryLabelDivider Create(MegaCrit.Sts2.Core.Localization.LocString locString)
public static MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryLabelDivider Create(MegaCrit.Sts2.Core.Models.ActModel act)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryLabelDivider+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnUnfocus
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryLabelDivider+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _nameLabel
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryLabelDivider+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryLayout

类型属性：`Public, Abstract, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
protected .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public abstract System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Nodes.Combat.NCreature> GetCreatures()
public abstract System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.BestiaryMonsterMove> Setup(MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.BestiaryEntry entry, Godot.Tween tween)
public abstract System.Void Cleanup()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryLayout+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName Cleanup
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryLayout+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryLayout+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryLayoutDecimillipede

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryLayout`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiary _bestiary
private Godot.Control _creatureContainer
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Combat.NCreature> _creatures
private Godot.Control _encounterSlots
private Godot.Control _encounterVisuals
private static readonly System.String _scenePath
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task AnimAttack()
private [async] System.Threading.Tasks.Task AnimDie()
private [async] System.Threading.Tasks.Task AnimReattach()
private MegaCrit.Sts2.Core.Localization.LocString GetBestiaryMoveName(System.String moveId)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryLayoutDecimillipede Create(MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiary bestiary)
public virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Nodes.Combat.NCreature> GetCreatures()
public virtual System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.BestiaryMonsterMove> Setup(MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.BestiaryEntry entry, Godot.Tween tween)
public virtual System.Void _Ready()
public virtual System.Void Cleanup()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryLayoutDecimillipede+<AnimAttack>d__11

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryLayoutDecimillipede <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryLayoutDecimillipede+<AnimDie>d__13

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryLayoutDecimillipede <>4__this
private System.Collections.Generic.List+Enumerator<MegaCrit.Sts2.Core.Nodes.Combat.NCreature> <>7__wrap1
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryLayoutDecimillipede+<AnimReattach>d__12

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryLayoutDecimillipede <>4__this
private System.Collections.Generic.List+Enumerator<MegaCrit.Sts2.Core.Nodes.Combat.NCreature> <>7__wrap1
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryLayoutDecimillipede+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryLayout+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Cleanup
public static readonly Godot.StringName Create
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryLayoutDecimillipede+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryLayout+PropertyName`。

接口：

```text
public static readonly Godot.StringName _bestiary
public static readonly Godot.StringName _creatureContainer
public static readonly Godot.StringName _encounterSlots
public static readonly Godot.StringName _encounterVisuals
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryLayoutDecimillipede+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryLayout+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryLayoutDefault

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryLayout`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Nodes.Combat.NCreature _creature
private Godot.Control _creatureContainer
private static readonly System.String _scenePath
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryLayoutDefault Create()
public virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Nodes.Combat.NCreature> GetCreatures()
public virtual System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.BestiaryMonsterMove> Setup(MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.BestiaryEntry entry, Godot.Tween tween)
public virtual System.Void _Ready()
public virtual System.Void Cleanup()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryLayoutDefault+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryLayout+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Cleanup
public static readonly Godot.StringName Create
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryLayoutDefault+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryLayout+PropertyName`。

接口：

```text
public static readonly Godot.StringName _creature
public static readonly Godot.StringName _creatureContainer
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryLayoutDefault+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryLayout+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryLayoutKaiserCrab

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryLayout`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Nodes.Vfx.Backgrounds.NKaiserCrabBossBackground _background
private Godot.Vector2 _backgroundPosition
private MegaCrit.Sts2.Core.Nodes.Combat.NCreature _creature
private static readonly System.String _scenePath
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryLayoutKaiserCrab Create()
public System.Threading.Tasks.Task AnimDie()
public System.Threading.Tasks.Task AnimHurt()
public virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Nodes.Combat.NCreature> GetCreatures()
public virtual System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.BestiaryMonsterMove> Setup(MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.BestiaryEntry entry, Godot.Tween tween)
public virtual System.Void _Ready()
public virtual System.Void Cleanup()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryLayoutKaiserCrab+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryLayout+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Cleanup
public static readonly Godot.StringName Create
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryLayoutKaiserCrab+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryLayout+PropertyName`。

接口：

```text
public static readonly Godot.StringName _background
public static readonly Godot.StringName _backgroundPosition
public static readonly Godot.StringName _creature
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryLayoutKaiserCrab+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryLayout+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryModeButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.addons.mega_text.MegaLabel _modeLabel
private Godot.Tween _tween
System.String ClickedSfx { protected virtual get; }
System.String ControllerIconHotkey { protected virtual get; }
System.String[] Hotkeys { protected virtual get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.String get_ClickedSfx()
protected virtual System.String get_ControllerIconHotkey()
protected virtual System.String[] get_Hotkeys()
protected virtual System.Void OnFocus()
protected virtual System.Void OnPress()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void SetLabel(System.String str)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryModeButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName SetLabel
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryModeButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _modeLabel
public static readonly Godot.StringName _tween
public static readonly Godot.StringName ClickedSfx
public static readonly Godot.StringName ControllerIconHotkey
public static readonly Godot.StringName Hotkeys
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryModeButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryMoveButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private Godot.Control _buttonAnimator
private Godot.Tween _clickTween
private System.String[] _hotkeys
private MegaCrit.Sts2.addons.mega_text.MegaLabel _label
private static readonly System.String _scenePath
private Godot.Tween _tween
private MegaCrit.Sts2.Core.Models.BestiaryMonsterMove <Move>k__BackingField
System.String ClickedSfx { protected virtual get; }
System.String[] Hotkeys { protected virtual get; }
System.String HoveredSfx { protected virtual get; }
MegaCrit.Sts2.Core.Models.BestiaryMonsterMove Move { public get; private set; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void set_Move(MegaCrit.Sts2.Core.Models.BestiaryMonsterMove value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.String get_ClickedSfx()
protected virtual System.String get_HoveredSfx()
protected virtual System.String[] get_Hotkeys()
protected virtual System.Void OnFocus()
protected virtual System.Void OnPress()
protected virtual System.Void OnRelease()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public MegaCrit.Sts2.Core.Models.BestiaryMonsterMove get_Move()
public static MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryMoveButton Create(MegaCrit.Sts2.Core.Models.BestiaryMonsterMove move, Godot.StringName setHotkey)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryMoveButton+MethodName

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

## MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryMoveButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _buttonAnimator
public static readonly Godot.StringName _clickTween
public static readonly Godot.StringName _hotkeys
public static readonly Godot.StringName _label
public static readonly Godot.StringName _tween
public static readonly Godot.StringName ClickedSfx
public static readonly Godot.StringName Hotkeys
public static readonly Godot.StringName HoveredSfx
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiaryMoveButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```
