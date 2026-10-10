# MegaCrit.Sts2.Core.Nodes.Rooms

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.Rooms.IRoomWithProceedButton

类型属性：`Public, ClassSemanticsMask, Abstract, BeforeFieldInit`；基类：`无`。

接口：

```text
MegaCrit.Sts2.Core.Nodes.CommonUi.NProceedButton ProceedButton { public abstract get; }
public abstract MegaCrit.Sts2.Core.Nodes.CommonUi.NProceedButton get_ProceedButton()
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NCombatBackground

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
private System.Void AddLayer(System.String layerName, System.String layerPath)
private System.Void SetBackgroundLayers(System.Collections.Generic.IReadOnlyList<System.String> backgroundLayers)
private System.Void SetForegroundLayer(System.String foregroundLayer)
private System.Void SetLayers(MegaCrit.Sts2.Core.Rooms.BackgroundAssets bg)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Rooms.NCombatBackground Create(MegaCrit.Sts2.Core.Rooms.BackgroundAssets bg)
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NCombatBackground+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName AddLayer
public static readonly Godot.StringName SetForegroundLayer
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NCombatBackground+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NCombatBackground+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NCombatBackgroundLayer

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private Godot.Control _phobiaModeVisual
private Godot.Control _visual
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void UpdatePhobiaMode()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NCombatBackgroundLayer+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName UpdatePhobiaMode
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NCombatBackgroundLayer+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _phobiaModeVisual
public static readonly Godot.StringName _visual
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NCombatBackgroundLayer+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NCombatRoom

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`, `MegaCrit.Sts2.Core.Nodes.Rooms.IRoomWithProceedButton`

```text
private Godot.Control _allyContainer
private static const System.Single _alternateYPosBeginPadding = 30
private static const System.Single _centerSafeZone = 150
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Combat.NCreature> _creatureNodes
private static const System.Single _defaultPadding = 70
private Godot.Control _enemyContainer
private static const System.Single _maxAlternatingYPos = 60
private static const System.Single _minAlternatingYPos = 40
private static const System.Single _minimumAutoPadding = 5
private MegaCrit.Sts2.Core.Nodes.CommonUi.NProceedButton _proceedButton
private MegaCrit.Sts2.Core.Nodes.Vfx.NRadialBlurVfx _radialBlur
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Combat.NCreature> _removingCreatureNodes
private static const System.String _scenePath = "res://scenes/rooms/combat_room.tscn"
private MegaCrit.Sts2.Core.Rooms.ICombatRoomVisuals _visuals
private Godot.Control _waitingForOtherPlayersOverlay
private static readonly MegaCrit.Sts2.Core.Localization.LocString _waitingLoc
private Godot.Window _window
private static const System.Single _yPos = 200
private Godot.Control <BackCombatVfxContainer>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Rooms.NCombatBackground <Background>k__BackingField
private Godot.Control <BgContainer>k__BackingField
private Godot.Control <CombatVfxContainer>k__BackingField
private System.UInt64 <CreatedMsec>k__BackingField
private Godot.Control <EncounterSlots>k__BackingField
private MegaCrit.Sts2.Core.Entities.Creatures.Creature <LastTargetedCreature>k__BackingField
private MegaCrit.Sts2.Core.Rooms.CombatRoomMode <Mode>k__BackingField
private Godot.Control <SceneContainer>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Combat.NCombatUi <Ui>k__BackingField
private System.Action ProceedButtonPressed
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
Godot.Control BackCombatVfxContainer { public get; private set; }
MegaCrit.Sts2.Core.Nodes.Rooms.NCombatBackground Background { public get; private set; }
Godot.Control BgContainer { private get; private set; }
Godot.Control CombatVfxContainer { public get; private set; }
System.UInt64 CreatedMsec { public get; private set; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Nodes.Combat.NCreature> CreatureNodes { public get; }
Godot.Control DefaultFocusedControl { public virtual get; }
Godot.Control EncounterSlots { private get; private set; }
Godot.Control FocusedControlFromTopBar { public virtual get; }
MegaCrit.Sts2.Core.Nodes.Rooms.NCombatRoom Instance { public static get; }
MegaCrit.Sts2.Core.Entities.Creatures.Creature LastTargetedCreature { public get; public set; }
MegaCrit.Sts2.Core.Rooms.CombatRoomMode Mode { public get; private set; }
MegaCrit.Sts2.Core.Nodes.CommonUi.NProceedButton ProceedButton { public virtual get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Nodes.Combat.NCreature> RemovingCreatureNodes { public get; }
Godot.Control SceneContainer { public get; private set; }
MegaCrit.Sts2.Core.Nodes.Combat.NCombatUi Ui { public get; private set; }
event System.Action ProceedButtonPressed
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task RemoveCreatureWhenGone(MegaCrit.Sts2.Core.Nodes.Combat.NCreature node)
private Godot.Control get_BgContainer()
private Godot.Control get_EncounterSlots()
private static System.Void PositionLocalPlayerOsty(ref System.Single targetXPos, System.Single playerYPosition, MegaCrit.Sts2.Core.Nodes.Combat.NCreature player, MegaCrit.Sts2.Core.Nodes.Combat.NCreature osty)
private System.Void AdjustCreatureScaleForAspectRatio()
private System.Void CreateAllyNodes()
private System.Void CreateEnemyNodes()
private System.Void OnActiveScreenUpdated()
private System.Void OnCombatSetUp(MegaCrit.Sts2.Core.Combat.CombatState state)
private System.Void OnProceedButtonPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton button)
private System.Void PositionCreaturesWithSlots(System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Combat.NCreature> creatures)
private System.Void PositionEnemies(System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Combat.NCreature> creatures, System.Single scaling)
private System.Void RandomizeEnemyScalesAndHues()
private System.Void RestrictControllerNavigation(MegaCrit.Sts2.Core.Rooms.CombatRoom _)
private System.Void set_BackCombatVfxContainer(Godot.Control value)
private System.Void set_Background(MegaCrit.Sts2.Core.Nodes.Rooms.NCombatBackground value)
private System.Void set_BgContainer(Godot.Control value)
private System.Void set_CombatVfxContainer(Godot.Control value)
private System.Void set_CreatedMsec(System.UInt64 value)
private System.Void set_EncounterSlots(Godot.Control value)
private System.Void set_Mode(MegaCrit.Sts2.Core.Rooms.CombatRoomMode value)
private System.Void set_SceneContainer(Godot.Control value)
private System.Void set_Ui(MegaCrit.Sts2.Core.Nodes.Combat.NCombatUi value)
private System.Void SubscribeToCombatEvents()
private System.Void UpdateCreatureNavigation()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public Godot.Control get_BackCombatVfxContainer()
public Godot.Control get_CombatVfxContainer()
public Godot.Control get_SceneContainer()
public MegaCrit.Sts2.Core.Entities.Creatures.Creature get_LastTargetedCreature()
public MegaCrit.Sts2.Core.Nodes.Combat.NCombatUi get_Ui()
public MegaCrit.Sts2.Core.Nodes.Combat.NCreature GetCreatureNode(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public MegaCrit.Sts2.Core.Nodes.Rooms.NCombatBackground get_Background()
public MegaCrit.Sts2.Core.Rooms.CombatRoomMode get_Mode()
public static MegaCrit.Sts2.Core.Nodes.Rooms.NCombatRoom Create(MegaCrit.Sts2.Core.Rooms.ICombatRoomVisuals visuals, MegaCrit.Sts2.Core.Rooms.CombatRoomMode mode)
public static MegaCrit.Sts2.Core.Nodes.Rooms.NCombatRoom get_Instance()
public static MegaCrit.Sts2.Core.Random.Rng GenerateBackgroundRngForCurrentPoint(MegaCrit.Sts2.Core.Runs.IRunState state)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public static System.Void PositionPlayersAndPets(System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Combat.NCreature> creatureNodes, System.Single scaling, System.Boolean fullyCenterPlayers)
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Nodes.Combat.NCreature> get_CreatureNodes()
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Nodes.Combat.NCreature> get_RemovingCreatureNodes()
public System.UInt64 get_CreatedMsec()
public System.Void add_ProceedButtonPressed(System.Action value)
public System.Void AddCreature(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public System.Void EnableControllerNavigation()
public System.Void PlaySplashVfx(MegaCrit.Sts2.Core.Entities.Creatures.Creature target, Godot.Color tint)
public System.Void RadialBlur(MegaCrit.Sts2.Core.Nodes.Vfx.VfxPosition vfxPosition = 2)
public System.Void remove_ProceedButtonPressed(System.Action value)
public System.Void RemoveCreatureNode(MegaCrit.Sts2.Core.Nodes.Combat.NCreature node)
public System.Void RestrictControllerNavigation(System.Collections.Generic.IEnumerable<Godot.Control> whitelist)
public System.Void set_LastTargetedCreature(MegaCrit.Sts2.Core.Entities.Creatures.Creature value)
public System.Void SetCreatureIsInteractable(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature, System.Boolean on)
public System.Void SetUpBackground(MegaCrit.Sts2.Core.Runs.IRunState state)
public System.Void SetWaitingForOtherPlayersOverlayVisible(System.Boolean visible)
public System.Void ShakeOstyIfDead(MegaCrit.Sts2.Core.Entities.Players.Player owner)
public System.Void TransitionToActiveCombat(MegaCrit.Sts2.Core.Rooms.CombatRoom combatRoom)
public virtual Godot.Control get_DefaultFocusedControl()
public virtual Godot.Control get_FocusedControlFromTopBar()
public virtual MegaCrit.Sts2.Core.Nodes.CommonUi.NProceedButton get_ProceedButton()
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NCombatRoom+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Rooms.NCombatRoom+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Nodes.Combat.NCreature, System.Single> <>9__84_0
public static System.Func<MegaCrit.Sts2.Core.Nodes.Combat.NCreature, System.Single> <>9__85_0
public static System.Func<MegaCrit.Sts2.Core.Nodes.Combat.NCreature, System.Boolean> <>9__85_1
public static System.Func<MegaCrit.Sts2.Core.Nodes.Combat.NCreature, System.Boolean> <>9__92_0
public static System.Func<MegaCrit.Sts2.Core.Nodes.Combat.NCreature, System.Single> <>9__92_1
public static System.Func<MegaCrit.Sts2.Core.Nodes.Combat.NCreature, System.Boolean> <>9__96_0
private static .cctor()
public .ctor()
internal System.Boolean <get_FocusedControlFromTopBar>b__96_0(MegaCrit.Sts2.Core.Nodes.Combat.NCreature c)
internal System.Boolean <PositionPlayersAndPets>b__85_1(MegaCrit.Sts2.Core.Nodes.Combat.NCreature c)
internal System.Boolean <UpdateCreatureNavigation>b__92_0(MegaCrit.Sts2.Core.Nodes.Combat.NCreature c)
internal System.Single <PositionEnemies>b__84_0(MegaCrit.Sts2.Core.Nodes.Combat.NCreature n)
internal System.Single <PositionPlayersAndPets>b__85_0(MegaCrit.Sts2.Core.Nodes.Combat.NCreature n)
internal System.Single <UpdateCreatureNavigation>b__92_1(MegaCrit.Sts2.Core.Nodes.Combat.NCreature n)
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NCombatRoom+<>c__DisplayClass103_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Entities.Players.Player owner
public .ctor()
internal System.Boolean <ShakeOstyIfDead>b__0(MegaCrit.Sts2.Core.Nodes.Combat.NCreature c)
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NCombatRoom+<>c__DisplayClass81_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Creatures.Creature> allies
public .ctor()
internal System.Boolean <CreateAllyNodes>b__0(MegaCrit.Sts2.Core.Nodes.Combat.NCreature c)
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NCombatRoom+<>c__DisplayClass82_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Creatures.Creature> enemies
public .ctor()
internal System.Boolean <CreateEnemyNodes>b__0(MegaCrit.Sts2.Core.Nodes.Combat.NCreature c)
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NCombatRoom+<>c__DisplayClass85_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Combat.NCreature creature
public .ctor()
internal System.Boolean <PositionPlayersAndPets>b__2(MegaCrit.Sts2.Core.Nodes.Rooms.NCombatRoom+PlayerAndPets p)
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NCombatRoom+<>c__DisplayClass87_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Entities.Creatures.Creature creature
public .ctor()
internal System.Boolean <GetCreatureNode>b__0(MegaCrit.Sts2.Core.Nodes.Combat.NCreature c)
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NCombatRoom+<>c__DisplayClass90_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Entities.Players.Player player
public .ctor()
internal System.Boolean <AddCreature>b__0(MegaCrit.Sts2.Core.Nodes.Combat.NCreature c)
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NCombatRoom+<>O

类型属性：`NestedPrivate, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static System.Func<MegaCrit.Sts2.Core.Nodes.Combat.NCreature, System.Boolean> <0>__IsInstanceValid
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NCombatRoom+<RemoveCreatureWhenGone>d__89

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Rooms.NCombatRoom <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.Nodes.Combat.NCreature node
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NCombatRoom+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AdjustCreatureScaleForAspectRatio
public static readonly Godot.StringName CreateAllyNodes
public static readonly Godot.StringName CreateEnemyNodes
public static readonly Godot.StringName EnableControllerNavigation
public static readonly Godot.StringName OnActiveScreenUpdated
public static readonly Godot.StringName OnProceedButtonPressed
public static readonly Godot.StringName RadialBlur
public static readonly Godot.StringName RandomizeEnemyScalesAndHues
public static readonly Godot.StringName RemoveCreatureNode
public static readonly Godot.StringName SetWaitingForOtherPlayersOverlayVisible
public static readonly Godot.StringName SubscribeToCombatEvents
public static readonly Godot.StringName UpdateCreatureNavigation
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NCombatRoom+PlayerAndPets

类型属性：`NestedPrivate, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：

```text
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Combat.NCreature> pets
public MegaCrit.Sts2.Core.Nodes.Combat.NCreature player
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NCombatRoom+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _allyContainer
public static readonly Godot.StringName _enemyContainer
public static readonly Godot.StringName _proceedButton
public static readonly Godot.StringName _radialBlur
public static readonly Godot.StringName _waitingForOtherPlayersOverlay
public static readonly Godot.StringName _window
public static readonly Godot.StringName BackCombatVfxContainer
public static readonly Godot.StringName Background
public static readonly Godot.StringName BgContainer
public static readonly Godot.StringName CombatVfxContainer
public static readonly Godot.StringName CreatedMsec
public static readonly Godot.StringName DefaultFocusedControl
public static readonly Godot.StringName EncounterSlots
public static readonly Godot.StringName FocusedControlFromTopBar
public static readonly Godot.StringName Mode
public static readonly Godot.StringName ProceedButton
public static readonly Godot.StringName SceneContainer
public static readonly Godot.StringName Ui
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NCombatRoom+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NEventRoom

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Events.EventOption> _connectedOptions
private readonly System.Threading.CancellationTokenSource _cts
private MegaCrit.Sts2.Core.Models.EventModel _event
private MegaCrit.Sts2.Core.Nodes.NSceneContainer _eventContainer
private System.Boolean _isPreFinished
private MegaCrit.Sts2.Core.Runs.IRunState _runState
private static const System.String _scenePath = "res://scenes/rooms/event_room.tscn"
private Godot.Control <VfxContainer>k__BackingField
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
MegaCrit.Sts2.Core.Nodes.Events.ICustomEventNode CustomEventNode { public get; }
Godot.Control DefaultFocusedControl { public virtual get; }
MegaCrit.Sts2.Core.Nodes.Rooms.NCombatRoom EmbeddedCombatRoom { public get; }
MegaCrit.Sts2.Core.Nodes.Rooms.NEventRoom Instance { public static get; }
MegaCrit.Sts2.Core.Nodes.Events.NEventLayout Layout { public get; }
Godot.Control VfxContainer { public get; private set; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task BeforeOptionChosen(MegaCrit.Sts2.Core.Events.EventOption option)
private [async] System.Threading.Tasks.Task SetupLayout()
private MegaCrit.Sts2.Core.Localization.LocString GetDescriptionOrFallback()
private System.Void DisableOptionButtons()
private System.Void OnActiveScreenUpdated()
private System.Void OnEnteringEventCombat()
private System.Void RefreshEventState(MegaCrit.Sts2.Core.Models.EventModel eventModel)
private System.Void set_VfxContainer(Godot.Control value)
private System.Void SetDescription(MegaCrit.Sts2.Core.Localization.LocString description)
private System.Void SetOptions(MegaCrit.Sts2.Core.Models.EventModel eventModel)
private System.Void SetTitle(MegaCrit.Sts2.Core.Localization.LocString title)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public Godot.Control get_VfxContainer()
public MegaCrit.Sts2.Core.Nodes.Events.ICustomEventNode get_CustomEventNode()
public MegaCrit.Sts2.Core.Nodes.Events.NEventLayout get_Layout()
public MegaCrit.Sts2.Core.Nodes.Rooms.NCombatRoom get_EmbeddedCombatRoom()
public static MegaCrit.Sts2.Core.Nodes.Rooms.NEventRoom Create(MegaCrit.Sts2.Core.Models.EventModel eventModel, MegaCrit.Sts2.Core.Runs.IRunState runState, System.Boolean isPreFinished)
public static MegaCrit.Sts2.Core.Nodes.Rooms.NEventRoom get_Instance()
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public static System.Threading.Tasks.Task Proceed()
public System.Void OptionButtonClicked(MegaCrit.Sts2.Core.Events.EventOption option, System.Int32 index)
public System.Void SetPortrait(Godot.Texture2D portrait)
public virtual Godot.Control get_DefaultFocusedControl()
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NEventRoom+<>O

类型属性：`NestedPrivate, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static System.Func<System.Threading.Tasks.Task> <0>__Proceed
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NEventRoom+<BeforeOptionChosen>d__31

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Rooms.NEventRoom <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.Events.EventOption option
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NEventRoom+<SetupLayout>d__25

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Rooms.NEventRoom <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NEventRoom+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName DisableOptionButtons
public static readonly Godot.StringName OnActiveScreenUpdated
public static readonly Godot.StringName OnEnteringEventCombat
public static readonly Godot.StringName SetPortrait
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NEventRoom+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _eventContainer
public static readonly Godot.StringName _isPreFinished
public static readonly Godot.StringName DefaultFocusedControl
public static readonly Godot.StringName EmbeddedCombatRoom
public static readonly Godot.StringName Layout
public static readonly Godot.StringName VfxContainer
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NEventRoom+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NMapRoom

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private MegaCrit.Sts2.Core.Models.ActModel _act
private System.Int32 _actIndex
private static const System.String _scenePath = "res://scenes/rooms/map_room.tscn"
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
Godot.Control DefaultFocusedControl { public virtual get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void ReopenMap()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Rooms.NMapRoom Create(MegaCrit.Sts2.Core.Models.ActModel act, System.Int32 actIndex)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual Godot.Control get_DefaultFocusedControl()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NMapRoom+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName ReopenMap
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NMapRoom+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _actIndex
public static readonly Godot.StringName DefaultFocusedControl
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NMapRoom+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NMerchantButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private System.Boolean _focusedWhileTargeting
private MegaCrit.Sts2.Core.Nodes.Combat.NSelectionReticle _merchantSelectionReticle
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSkeleton _merchantSkeleton
private System.Boolean <IsLocalPlayerDead>k__BackingField
private System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Localization.LocString> <PlayerDeadLines>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Rooms.NMerchantButton+MerchantOpenedEventHandler backing_MerchantOpened
System.String[] Hotkeys { protected virtual get; }
System.Boolean IsLocalPlayerDead { public get; public set; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Localization.LocString> PlayerDeadLines { public get; public set; }
event MegaCrit.Sts2.Core.Nodes.Rooms.NMerchantButton+MerchantOpenedEventHandler MerchantOpened
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotSignalList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void RefreshFocus()
protected System.Void EmitSignalMerchantOpened(MegaCrit.Sts2.Core.Nodes.Rooms.NMerchantButton merchantButton)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean HasGodotClassSignal(in Godot.NativeInterop.godot_string_name signal)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.String[] get_Hotkeys()
protected virtual System.Void OnFocus()
protected virtual System.Void OnRelease()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RaiseGodotClassSignalCallbacks(in Godot.NativeInterop.godot_string_name signal, Godot.NativeInterop.NativeVariantPtrArgs args)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public MegaCrit.Sts2.Core.Nodes.Vfx.NSpeechBubbleVfx PlayDialogue(MegaCrit.Sts2.Core.Localization.LocString line, System.Double duration = 2)
public System.Boolean get_IsLocalPlayerDead()
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Localization.LocString> get_PlayerDeadLines()
public System.Void add_MerchantOpened(MegaCrit.Sts2.Core.Nodes.Rooms.NMerchantButton+MerchantOpenedEventHandler value)
public System.Void remove_MerchantOpened(MegaCrit.Sts2.Core.Nodes.Rooms.NMerchantButton+MerchantOpenedEventHandler value)
public System.Void set_IsLocalPlayerDead(System.Boolean value)
public System.Void set_PlayerDeadLines(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Localization.LocString> value)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NMerchantButton+<>c__DisplayClass14_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Rooms.NMerchantButton <>4__this
public MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite sprite
public .ctor()
internal System.Void <_Ready>b__0(MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaAnimationState animState)
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NMerchantButton+MerchantOpenedEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(MegaCrit.Sts2.Core.Nodes.Rooms.NMerchantButton merchantButton, System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke(MegaCrit.Sts2.Core.Nodes.Rooms.NMerchantButton merchantButton)
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NMerchantButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName RefreshFocus
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NMerchantButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _focusedWhileTargeting
public static readonly Godot.StringName _merchantSelectionReticle
public static readonly Godot.StringName Hotkeys
public static readonly Godot.StringName IsLocalPlayerDead
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NMerchantButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public static readonly Godot.StringName MerchantOpened
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NMerchantRoom

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`, `MegaCrit.Sts2.Core.Nodes.Rooms.IRoomWithProceedButton`

```text
private static const System.Single _animVariance = 0.5
private Godot.Control _characterContainer
private MegaCrit.Sts2.Core.Entities.Merchant.MerchantDialogueSet _dialogue
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Players.Player> _players
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantCharacter> _playerVisuals
private MegaCrit.Sts2.Core.Nodes.CommonUi.NProceedButton _proceedButton
private static readonly System.String _scenePath
private MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantInventory <Inventory>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Rooms.NMerchantButton <MerchantButton>k__BackingField
private MegaCrit.Sts2.Core.Rooms.MerchantRoom <Room>k__BackingField
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
Godot.Control DefaultFocusedControl { public virtual get; }
MegaCrit.Sts2.Core.Nodes.Rooms.NMerchantRoom Instance { public static get; }
MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantInventory Inventory { public get; private set; }
MegaCrit.Sts2.Core.Nodes.Rooms.NMerchantButton MerchantButton { public get; private set; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantCharacter> PlayerVisuals { public get; }
MegaCrit.Sts2.Core.Nodes.CommonUi.NProceedButton ProceedButton { public virtual get; }
MegaCrit.Sts2.Core.Rooms.MerchantRoom Room { public get; private set; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Boolean MerchantFtueCheck()
private System.Void <OpenInventory>b__37_0()
private System.Void AfterRoomIsLoaded()
private System.Void HideScreen(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OnActiveScreenUpdated()
private System.Void OnMerchantOpened(MegaCrit.Sts2.Core.Nodes.Rooms.NMerchantButton _)
private System.Void set_Inventory(MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantInventory value)
private System.Void set_MerchantButton(MegaCrit.Sts2.Core.Nodes.Rooms.NMerchantButton value)
private System.Void set_Room(MegaCrit.Sts2.Core.Rooms.MerchantRoom value)
private System.Void ToggleMerchantTrack()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public MegaCrit.Sts2.Core.Nodes.Rooms.NMerchantButton get_MerchantButton()
public MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantInventory get_Inventory()
public MegaCrit.Sts2.Core.Rooms.MerchantRoom get_Room()
public static MegaCrit.Sts2.Core.Nodes.Rooms.NMerchantRoom Create(MegaCrit.Sts2.Core.Rooms.MerchantRoom room, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Players.Player> players)
public static MegaCrit.Sts2.Core.Nodes.Rooms.NMerchantRoom get_Instance()
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantCharacter> get_PlayerVisuals()
public System.Void FoulPotionThrown(MegaCrit.Sts2.Core.Models.Potions.FoulPotion potion)
public System.Void OpenInventory()
public virtual Godot.Control get_DefaultFocusedControl()
public virtual MegaCrit.Sts2.Core.Nodes.CommonUi.NProceedButton get_ProceedButton()
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NMerchantRoom+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AfterRoomIsLoaded
public static readonly Godot.StringName HideScreen
public static readonly Godot.StringName MerchantFtueCheck
public static readonly Godot.StringName OnActiveScreenUpdated
public static readonly Godot.StringName OnMerchantOpened
public static readonly Godot.StringName OpenInventory
public static readonly Godot.StringName ToggleMerchantTrack
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NMerchantRoom+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _characterContainer
public static readonly Godot.StringName _proceedButton
public static readonly Godot.StringName DefaultFocusedControl
public static readonly Godot.StringName Inventory
public static readonly Godot.StringName MerchantButton
public static readonly Godot.StringName ProceedButton
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NMerchantRoom+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NRestSiteRoom

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`, `MegaCrit.Sts2.Core.Nodes.Rooms.IRoomWithProceedButton`

```text
private readonly System.Collections.Generic.List<Godot.Control> _characterContainers
private Godot.Control _choicesContainer
private Godot.Control _choicesScreen
private Godot.Tween _choicesTween
private readonly System.Threading.CancellationTokenSource _cts
private Godot.Tween _descriptionPositionTween
private Godot.Tween _descriptionTween
private static System.Boolean _isDebugUiVisible
private Godot.Control _lastFocused
private static const System.Single _lowDescriptionYPos = 885
private System.Single _originalDescriptionYPos
private MegaCrit.Sts2.Core.Nodes.CommonUi.NProceedButton _proceedButton
private Godot.Control _restSiteLighting
private MegaCrit.Sts2.Core.Rooms.RestSiteRoom _room
private System.Boolean _roomExiting
private MegaCrit.Sts2.Core.Runs.IRunState _runState
private static const System.String _scenePath = "res://scenes/rooms/rest_site_room.tscn"
private Godot.Control <BgContainer>k__BackingField
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.RestSite.NRestSiteCharacter> <Characters>k__BackingField
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel <Description>k__BackingField
private MegaCrit.Sts2.addons.mega_text.MegaLabel <Header>k__BackingField
public readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.RestSite.NRestSiteCharacter> characterAnims
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
Godot.Control BgContainer { private get; private set; }
System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.RestSite.NRestSiteCharacter> Characters { public get; }
Godot.Control DefaultFocusedControl { public virtual get; }
MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel Description { private get; private set; }
MegaCrit.Sts2.addons.mega_text.MegaLabel Header { private get; private set; }
MegaCrit.Sts2.Core.Nodes.Rooms.NRestSiteRoom Instance { public static get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption> Options { public get; }
MegaCrit.Sts2.Core.Nodes.CommonUi.NProceedButton ProceedButton { public virtual get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task AfterSelectingOptionAsync(MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption option)
private [async] System.Threading.Tasks.Task HideChoices(System.Threading.CancellationToken ct)
private [async] System.Threading.Tasks.Task ShowChoices(System.Threading.CancellationToken ct)
private [async] System.Threading.Tasks.Task ShowFtueIfNeeded()
private Godot.Control get_BgContainer()
private MegaCrit.Sts2.addons.mega_text.MegaLabel get_Header()
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel get_Description()
private System.Void ExtinguishFireIfAble()
private System.Void OnActiveScreenUpdated()
private System.Void OnAfterPlayerSelectedRestSiteOption(MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption option, System.Boolean success, System.UInt64 playerId)
private System.Void OnBeforePlayerSelectedRestSiteOption(MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption option, System.UInt64 playerId)
private System.Void OnPlayerChangedHoveredRestSiteOption(System.UInt64 playerId)
private System.Void OnProceedButtonReleased(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void RestSiteButtonHovered(MegaCrit.Sts2.Core.Nodes.RestSite.NRestSiteButton button)
private System.Void RestSiteButtonUnhovered(MegaCrit.Sts2.Core.Nodes.RestSite.NRestSiteButton button)
private System.Void set_BgContainer(Godot.Control value)
private System.Void set_Description(MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel value)
private System.Void set_Header(MegaCrit.Sts2.addons.mega_text.MegaLabel value)
private System.Void ShowProceedButton()
private System.Void UpdateRestSiteOptions()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public MegaCrit.Sts2.Core.Nodes.RestSite.NRestSiteButton GetButtonForOption(MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption option)
public MegaCrit.Sts2.Core.Nodes.RestSite.NRestSiteCharacter GetCharacterForPlayer(MegaCrit.Sts2.Core.Entities.Players.Player player)
public static MegaCrit.Sts2.Core.Nodes.Rooms.NRestSiteRoom Create(MegaCrit.Sts2.Core.Rooms.RestSiteRoom room, MegaCrit.Sts2.Core.Runs.IRunState runState)
public static MegaCrit.Sts2.Core.Nodes.Rooms.NRestSiteRoom get_Instance()
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption> get_Options()
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.RestSite.NRestSiteCharacter> get_Characters()
public System.Void AfterSelectingOption(MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption option)
public System.Void AnimateDescriptionDown()
public System.Void AnimateDescriptionUp()
public System.Void BeforeExitingRoom()
public System.Void DisableOptions()
public System.Void EnableOptions()
public System.Void FadeOutOptionDescription()
public System.Void SetText(System.String formattedText)
public virtual Godot.Control get_DefaultFocusedControl()
public virtual MegaCrit.Sts2.Core.Nodes.CommonUi.NProceedButton get_ProceedButton()
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Input(Godot.InputEvent inputEvent)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NRestSiteRoom+<>c__DisplayClass55_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.UInt64 playerId
public .ctor()
internal System.Boolean <OnPlayerChangedHoveredRestSiteOption>b__0(MegaCrit.Sts2.Core.Nodes.RestSite.NRestSiteCharacter c)
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NRestSiteRoom+<>c__DisplayClass56_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.UInt64 playerId
public .ctor()
internal System.Boolean <OnBeforePlayerSelectedRestSiteOption>b__0(MegaCrit.Sts2.Core.Nodes.RestSite.NRestSiteCharacter c)
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NRestSiteRoom+<>c__DisplayClass57_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.UInt64 playerId
public .ctor()
internal System.Boolean <OnAfterPlayerSelectedRestSiteOption>b__0(MegaCrit.Sts2.Core.Nodes.RestSite.NRestSiteCharacter c)
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NRestSiteRoom+<AfterSelectingOptionAsync>d__60

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Rooms.NRestSiteRoom <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption option
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NRestSiteRoom+<HideChoices>d__68

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Rooms.NRestSiteRoom <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public System.Threading.CancellationToken ct
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NRestSiteRoom+<ShowChoices>d__67

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Rooms.NRestSiteRoom <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public System.Threading.CancellationToken ct
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NRestSiteRoom+<ShowFtueIfNeeded>d__46

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Rooms.NRestSiteRoom <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NRestSiteRoom+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Input
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AnimateDescriptionDown
public static readonly Godot.StringName AnimateDescriptionUp
public static readonly Godot.StringName BeforeExitingRoom
public static readonly Godot.StringName DisableOptions
public static readonly Godot.StringName EnableOptions
public static readonly Godot.StringName ExtinguishFireIfAble
public static readonly Godot.StringName FadeOutOptionDescription
public static readonly Godot.StringName OnActiveScreenUpdated
public static readonly Godot.StringName OnPlayerChangedHoveredRestSiteOption
public static readonly Godot.StringName OnProceedButtonReleased
public static readonly Godot.StringName RestSiteButtonHovered
public static readonly Godot.StringName RestSiteButtonUnhovered
public static readonly Godot.StringName SetText
public static readonly Godot.StringName ShowProceedButton
public static readonly Godot.StringName UpdateRestSiteOptions
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NRestSiteRoom+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _choicesContainer
public static readonly Godot.StringName _choicesScreen
public static readonly Godot.StringName _choicesTween
public static readonly Godot.StringName _descriptionPositionTween
public static readonly Godot.StringName _descriptionTween
public static readonly Godot.StringName _lastFocused
public static readonly Godot.StringName _originalDescriptionYPos
public static readonly Godot.StringName _proceedButton
public static readonly Godot.StringName _restSiteLighting
public static readonly Godot.StringName _roomExiting
public static readonly Godot.StringName BgContainer
public static readonly Godot.StringName DefaultFocusedControl
public static readonly Godot.StringName Description
public static readonly Godot.StringName Header
public static readonly Godot.StringName ProceedButton
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NRestSiteRoom+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NTreasureRoom

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`, `MegaCrit.Sts2.Core.Nodes.Rooms.IRoomWithProceedButton`

```text
private MegaCrit.Sts2.Core.Nodes.CommonUi.NCommonBanner _banner
private MegaCrit.Sts2.Core.Nodes.TreasureRooms.NTreasureButton _chestButton
private System.Threading.CancellationTokenSource _cts
private Godot.GpuParticles2D _goldParticles
private System.Boolean _hasChestBeenOpened
private System.Boolean _isRelicCollectionOpen
private MegaCrit.Sts2.Core.Nodes.CommonUi.NProceedButton _proceedButton
private MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NTreasureRoomRelicCollection _relicCollection
private MegaCrit.Sts2.Core.Rooms.TreasureRoom _room
private MegaCrit.Sts2.Core.Runs.IRunState _runState
private static readonly System.String _scenePath
private MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer _skipVoteContainer
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
Godot.Control DefaultFocusedControl { public virtual get; }
MegaCrit.Sts2.Core.Nodes.CommonUi.NProceedButton ProceedButton { public virtual get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task EnableSkipAfterDelay(System.Single delay, System.Threading.CancellationToken token)
private [async] System.Threading.Tasks.Task OpenChest()
private [async] System.Threading.Tasks.Task RelicFtueCheck()
private System.Boolean IsPlayerVotingForSkip(MegaCrit.Sts2.Core.Entities.Players.Player player)
private System.Void OnActiveScreenChanged()
private System.Void OnChestButtonReleased(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OnMouseEntered()
private System.Void OnMouseExited()
private System.Void OnProceedButtonPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OnProceedButtonReleased(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void RefreshVotes()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Rooms.NTreasureRoom Create(MegaCrit.Sts2.Core.Rooms.TreasureRoom room, MegaCrit.Sts2.Core.Runs.IRunState runState)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual Godot.Control get_DefaultFocusedControl()
public virtual MegaCrit.Sts2.Core.Nodes.CommonUi.NProceedButton get_ProceedButton()
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NTreasureRoom+<EnableSkipAfterDelay>d__27

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Rooms.NTreasureRoom <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public System.Single delay
public System.Threading.CancellationToken token
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NTreasureRoom+<OpenChest>d__26

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Rooms.NTreasureRoom <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Int32> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
private System.Threading.CancellationTokenSource <cancelSource>5__2
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NTreasureRoom+<RelicFtueCheck>d__28

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Rooms.NTreasureRoom <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NTreasureRoom+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnActiveScreenChanged
public static readonly Godot.StringName OnChestButtonReleased
public static readonly Godot.StringName OnMouseEntered
public static readonly Godot.StringName OnMouseExited
public static readonly Godot.StringName OnProceedButtonPressed
public static readonly Godot.StringName OnProceedButtonReleased
public static readonly Godot.StringName RefreshVotes
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NTreasureRoom+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _banner
public static readonly Godot.StringName _chestButton
public static readonly Godot.StringName _goldParticles
public static readonly Godot.StringName _hasChestBeenOpened
public static readonly Godot.StringName _isRelicCollectionOpen
public static readonly Godot.StringName _proceedButton
public static readonly Godot.StringName _relicCollection
public static readonly Godot.StringName _skipVoteContainer
public static readonly Godot.StringName DefaultFocusedControl
public static readonly Godot.StringName ProceedButton
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Rooms.NTreasureRoom+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```
