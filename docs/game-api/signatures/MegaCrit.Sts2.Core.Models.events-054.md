# MegaCrit.Sts2.Core.Models

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。


## MegaCrit.Sts2.Core.Models.EventModel

类型属性：`Public, Abstract, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Models.AbstractModel`。

接口：`System.IComparable<MegaCrit.Sts2.Core.Models.AbstractModel>`

```text
private MegaCrit.Sts2.Core.Models.EventModel _canonicalInstance
private System.Boolean _cleanupCalled
protected MegaCrit.Sts2.Core.Multiplayer.Game.EventCombatSynchronizer _combatSynchronizer
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Events.EventOption> _currentOptions
private MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVarSet _dynamicVars
protected static const System.String _initialPageKey = "INITIAL"
private System.Boolean _isFinished
private MegaCrit.Sts2.Core.Localization.LocString <Description>k__BackingField
private Godot.Control <Node>k__BackingField
private MegaCrit.Sts2.Core.Entities.Players.Player <Owner>k__BackingField
private MegaCrit.Sts2.Core.Random.Rng <Rng>k__BackingField
private System.Action EnteringEventCombat
private System.Action<MegaCrit.Sts2.Core.Models.EventModel> StateChanged
System.String BackgroundScenePath { private get; }
Godot.Color ButtonColor { public virtual get; }
MegaCrit.Sts2.Core.Models.EncounterModel CanonicalEncounter { public virtual get; }
MegaCrit.Sts2.Core.Models.EventModel CanonicalInstance { public get; private set; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar> CanonicalVars { protected virtual get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Events.EventOption> CurrentOptions { public get; }
MegaCrit.Sts2.Core.Localization.LocString Description { public get; private set; }
MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVarSet DynamicVars { public get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Localization.LocString> GameInfoOptions { public virtual get; }
System.Boolean HasPhobiaModePortrait { public get; }
System.Boolean HasVfx { public get; }
MegaCrit.Sts2.Core.Localization.LocString InitialDescription { public virtual get; }
System.String InitialPhobiaModePortraitPath { private get; }
System.String InitialPortraitPath { private get; }
System.Boolean IsDeterministic { public virtual get; }
System.Boolean IsFinished { public get; private set; }
System.Boolean IsShared { public virtual get; }
System.String LayoutScenePath { private get; }
MegaCrit.Sts2.Core.Events.EventLayoutType LayoutType { public virtual get; }
System.String LocTable { public virtual get; }
Godot.Control Node { public get; private set; }
MegaCrit.Sts2.Core.Entities.Players.Player Owner { public get; private set; }
MegaCrit.Sts2.Core.Random.Rng Rng { public get; private set; }
System.Boolean ShouldReceiveCombatHooks { public virtual get; }
MegaCrit.Sts2.Core.Localization.LocString Title { public get; }
Godot.Vector2 VfxOffset { public static get; }
System.String VfxPath { private get; }
event System.Action EnteringEventCombat
event System.Action<MegaCrit.Sts2.Core.Models.EventModel> StateChanged
protected .ctor()
private MegaCrit.Sts2.Core.Localization.LocString <get_GameInfoOptions>b__59_1(System.String k)
private System.Boolean <get_GameInfoOptions>b__59_0(System.String k)
private System.String get_BackgroundScenePath()
private System.String get_InitialPhobiaModePortraitPath()
private System.String get_InitialPortraitPath()
private System.String get_LayoutScenePath()
private System.String get_VfxPath()
private System.String OptionKey(System.String pageName, System.String optionName)
private System.Void set_CanonicalInstance(MegaCrit.Sts2.Core.Models.EventModel value)
private System.Void set_Description(MegaCrit.Sts2.Core.Localization.LocString value)
private System.Void set_IsFinished(System.Boolean value)
private System.Void set_Node(Godot.Control value)
private System.Void set_Owner(MegaCrit.Sts2.Core.Entities.Players.Player value)
private System.Void set_Rng(MegaCrit.Sts2.Core.Random.Rng value)
protected [async] System.Threading.Tasks.Task SelectCardsToAddToDeckFromGrid(System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Cards.CardCreationResult> cards, MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs prefs)
protected abstract System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Events.EventOption> GenerateInitialOptions()
protected MegaCrit.Sts2.Core.Events.EventOption RelicOption(MegaCrit.Sts2.Core.Models.RelicModel relic, System.Func<System.Threading.Tasks.Task> onChosen, System.String pageName = "INITIAL")
protected MegaCrit.Sts2.Core.Events.EventOption RelicOption<T>(System.Func<System.Threading.Tasks.Task> onChosen, System.String pageName = "INITIAL") where T: [None] MegaCrit.Sts2.Core.Models.RelicModel
protected MegaCrit.Sts2.Core.Localization.LocString L10NLookup(System.String entryName)
protected System.String InitialOptionKey(System.String optionName)
protected System.Void ClearCurrentOptions()
protected System.Void EnterCombatWithoutExitingEvent(MegaCrit.Sts2.Core.Models.EncounterModel canonicalEncounter, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Rewards.Reward> extraRewards, System.Boolean shouldResumeAfterCombat)
protected System.Void EnterCombatWithoutExitingEvent<T>(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Rewards.Reward> extraRewards, System.Boolean shouldResumeAfterCombat) where T: [None] MegaCrit.Sts2.Core.Models.EncounterModel
protected System.Void ReplaceNullOptions(System.Collections.Generic.List<MegaCrit.Sts2.Core.Events.EventOption> options)
protected System.Void SetEventFinished(MegaCrit.Sts2.Core.Localization.LocString description)
protected virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar> get_CanonicalVars()
protected virtual System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Events.EventOption> GenerateInitialOptionsWrapper()
protected virtual System.Threading.Tasks.Task BeforeEventStarted(System.Boolean isPreFinished)
protected virtual System.Void AfterCloned()
protected virtual System.Void DeepCloneFields()
protected virtual System.Void OnEventFinished()
protected virtual System.Void SetEventState(MegaCrit.Sts2.Core.Localization.LocString description, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Events.EventOption> eventOptions)
protected virtual System.Void SetInitialEventState(System.Boolean isPreFinished)
public [async] System.Threading.Tasks.Task BeginEvent(MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.Multiplayer.Game.EventCombatSynchronizer combatSynchronizer, System.Boolean isPreFinished)
public Godot.Control get_Node()
public Godot.Node2D CreateVfx()
public Godot.PackedScene CreateBackgroundScene()
public Godot.PackedScene CreateScene()
public Godot.Texture2D CreateInitialPhobiaModePortrait()
public Godot.Texture2D CreateInitialPortrait()
public MegaCrit.Sts2.Core.Entities.Players.Player get_Owner()
public MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVarSet get_DynamicVars()
public MegaCrit.Sts2.Core.Localization.LocString get_Description()
public MegaCrit.Sts2.Core.Localization.LocString get_Title()
public MegaCrit.Sts2.Core.Localization.LocString GetOptionDescription(System.String key)
public MegaCrit.Sts2.Core.Localization.LocString GetOptionTitle(System.String key)
public MegaCrit.Sts2.Core.Models.EventModel get_CanonicalInstance()
public MegaCrit.Sts2.Core.Models.EventModel ToMutable()
public MegaCrit.Sts2.Core.Random.Rng get_Rng()
public MegaCrit.Sts2.Core.Rooms.ICombatRoomVisuals CreateCombatRoomVisuals(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Players.Player> players, MegaCrit.Sts2.Core.Models.ActModel act)
public static Godot.Vector2 get_VfxOffset()
public System.Boolean get_HasPhobiaModePortrait()
public System.Boolean get_HasVfx()
public System.Boolean get_IsFinished()
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Events.EventOption> get_CurrentOptions()
public System.Void add_EnteringEventCombat(System.Action value)
public System.Void add_StateChanged(System.Action<MegaCrit.Sts2.Core.Models.EventModel> value)
public System.Void EnsureCleanup()
public System.Void remove_EnteringEventCombat(System.Action value)
public System.Void remove_StateChanged(System.Action<MegaCrit.Sts2.Core.Models.EventModel> value)
public System.Void SetNode(Godot.Control node)
public virtual Godot.Color get_ButtonColor()
public virtual MegaCrit.Sts2.Core.Events.EventLayoutType get_LayoutType()
public virtual MegaCrit.Sts2.Core.Localization.LocString get_InitialDescription()
public virtual MegaCrit.Sts2.Core.Models.EncounterModel get_CanonicalEncounter()
public virtual System.Boolean get_IsDeterministic()
public virtual System.Boolean get_IsShared()
public virtual System.Boolean get_ShouldReceiveCombatHooks()
public virtual System.Boolean IsAllowed(MegaCrit.Sts2.Core.Runs.IRunState runState)
public virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Localization.LocString> get_GameInfoOptions()
public virtual System.Collections.Generic.IEnumerable<System.String> GetAssetPaths(MegaCrit.Sts2.Core.Runs.IRunState runState)
public virtual System.String get_LocTable()
public virtual System.Threading.Tasks.Task AfterEventStarted()
public virtual System.Threading.Tasks.Task Resume(MegaCrit.Sts2.Core.Rooms.AbstractRoom exitedRoom)
public virtual System.Void CalculateVars()
public virtual System.Void OnRoomEnter()
```

