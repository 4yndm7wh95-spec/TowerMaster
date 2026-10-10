# MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NBadge

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Localization.LocString _description
private Godot.Control _hoverNode
private MegaCrit.Sts2.Core.HoverTips.HoverTip _hoverTip
private static readonly System.String _scenePath
private MegaCrit.Sts2.Core.Nodes.Combat.NSelectionReticle _selectionReticle
private static const System.String _table = "badges"
private MegaCrit.Sts2.Core.Localization.LocString _title
private Godot.Tween _tween
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private static Godot.Texture2D GetBadgeBaseTexture(MegaCrit.Sts2.Core.Models.Badges.BadgeRarity rarity)
private static System.String GetRarityPrefix(MegaCrit.Sts2.Core.Models.Badges.BadgeRarity rarity)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnFocus()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public [async] System.Threading.Tasks.Task AnimateIn()
public static MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NBadge Create(MegaCrit.Sts2.Core.Models.Badges.Badge badgeModel)
public static MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NBadge Create(System.String id, MegaCrit.Sts2.Core.Models.Badges.BadgeRarity rarity)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NBadge+<AnimateIn>d__12

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NBadge <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NBadge+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName GetBadgeBaseTexture
public static readonly Godot.StringName GetRarityPrefix
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnUnfocus
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NBadge+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _hoverNode
public static readonly Godot.StringName _selectionReticle
public static readonly Godot.StringName _tween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NBadge+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NDiscoveredItem

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.HoverTips.HoverTip _hoverTip
private static readonly Godot.Vector2 _hoverTipOffset
private MegaCrit.Sts2.addons.mega_text.MegaLabel _label
private MegaCrit.Sts2.Core.Nodes.Combat.NSelectionReticle _selectionReticle
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnFocus()
protected virtual System.Void OnPress()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void SetHoverTip(MegaCrit.Sts2.Core.HoverTips.HoverTip hoverTip)
public System.Void SetText(System.String str)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NDiscoveredItem+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName SetText
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NDiscoveredItem+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _label
public static readonly Godot.StringName _selectionReticle
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NDiscoveredItem+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NGameOverContinueButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private static const System.Single _hoverS = 1.2
private Godot.Tween _hoverTween
private static const System.Single _hoverV = 1.4
private Godot.ShaderMaterial _hsv
private static const System.Single _pressDownS = 1
private static const System.Single _pressDownV = 1
private static readonly Godot.StringName _s
private Godot.Vector2 _showPosition
private Godot.Tween _tween
private static const System.Single _unhoverS = 1
private static const System.Single _unhoverV = 1
private static readonly Godot.StringName _v
System.String[] Hotkeys { protected virtual get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void UpdateShaderS(System.Single value)
private System.Void UpdateShaderV(System.Single value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.String[] get_Hotkeys()
protected virtual System.Void OnDisable()
protected virtual System.Void OnEnable()
protected virtual System.Void OnFocus()
protected virtual System.Void OnPress()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NGameOverContinueButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnDisable
public static readonly Godot.StringName OnEnable
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName UpdateShaderS
public static readonly Godot.StringName UpdateShaderV
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NGameOverContinueButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _hoverTween
public static readonly Godot.StringName _hsv
public static readonly Godot.StringName _showPosition
public static readonly Godot.StringName _tween
public static readonly Godot.StringName Hotkeys
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NGameOverContinueButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NGameOverScreen

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.Overlays.IOverlayScreen`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private Godot.ColorRect _backstop
private Godot.ShaderMaterial _backstopMaterial
private Godot.Control _badgeContainer
private MegaCrit.Sts2.Core.Nodes.CommonUi.NCommonBanner _banner
private MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NGameOverContinueButton _continueButton
private Godot.Control _creatureContainer
private readonly System.Threading.CancellationTokenSource _cts
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _deathQuote
private MegaCrit.Sts2.addons.mega_text.MegaLabel _discoveryLabel
private System.String _encounterQuote
private Godot.ColorRect _fullBlackBackstop
private MegaCrit.Sts2.Core.Runs.RunHistory _history
private System.Boolean _isAnimatingSummary
private MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunLeaderboard _leaderboard
private MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NGameOverContinueButton _leaderboardButton
private MegaCrit.Sts2.Core.Entities.Players.Player _localPlayer
private MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NReturnToMainMenuButton _mainMenuButton
private Godot.Tween _quoteTween
private MegaCrit.Sts2.Core.Runs.RunState _runState
private System.Int32 _score
private Godot.Control _scoreBar
private Godot.Control _scoreFg
private Godot.GridContainer _scoreLineContainer
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NScoreLine> _scoreLines
private MegaCrit.Sts2.addons.mega_text.MegaLabel _scoreProgress
private System.Int32 _scoreThreshold
private Godot.Control _screenshakeContainer
private MegaCrit.Sts2.Core.Saves.SerializableRun _serializableRun
private Godot.ColorRect _summaryBackstop
private MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NRunSummary _summaryContainer
private static readonly Godot.StringName _threshold
private Godot.Control _uiNode
private MegaCrit.Sts2.addons.mega_text.MegaLabel _unlocksRemaining
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _victoryDamageLabel
private MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NViewRunButton _viewRunButton
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
Godot.Control DefaultFocusedControl { public virtual get; }
Godot.Control FocusedControlFromTopBar { public virtual get; }
System.String ScenePath { private static get; }
MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType ScreenType { public virtual get; }
System.Boolean UseSharedBackstop { public virtual get; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task AnimateBadges()
private [async] System.Threading.Tasks.Task AnimateDiscoveries()
private [async] System.Threading.Tasks.Task AnimateIn()
private [async] System.Threading.Tasks.Task AnimateInQuote()
private [async] System.Threading.Tasks.Task AnimateRunSummary()
private [async] System.Threading.Tasks.Task AnimateScoreBar()
private [async] System.Threading.Tasks.Task AnimateScoreLines()
private [async] System.Threading.Tasks.Task TransitionOutToMainMenu()
private [async] System.Threading.Tasks.Task TransitionOutToTimeline()
private static System.String get_ScenePath()
private System.Boolean DiscoveredAnyEpochs()
private System.Int32 <AnimateScoreLines>b__49_1(MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry e)
private System.String GetAscensionMulti(System.Int32 ascension)
private System.Void AddScoreLine(System.String locEntryKey, System.String locAmountKey = null, System.Int32 amount = 0, System.String scoreLabel = "ERROR", System.String iconPath = null)
private System.Void HideSummary()
private System.Void InitializeBannerAndQuote()
private System.Void MoveCreaturesToDifferentLayerAndDisableUi()
private System.Void OnMainMenuButtonPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OpenRunHistoryScreen(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OpenSummaryScreen(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OpenTimeline()
private System.Void PlayUnlockSfx()
private System.Void ReturnToMainMenu()
private System.Void SaveBadgesToProgress(System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.Badges.Badge> badgesToSave)
private System.Void ShowLeaderboard(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void TweenScore(System.Int32 value)
private System.Void UpdateBackstopMaterial(System.Single value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NGameOverScreen Create(MegaCrit.Sts2.Core.Runs.RunState runState, MegaCrit.Sts2.Core.Saves.SerializableRun serializableRun)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public static System.Int32 GetScoreThreshold(System.Int32 unlocksRemaining)
public virtual Godot.Control get_DefaultFocusedControl()
public virtual Godot.Control get_FocusedControlFromTopBar()
public virtual MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType get_ScreenType()
public virtual System.Boolean get_UseSharedBackstop()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
public virtual System.Void AfterOverlayClosed()
public virtual System.Void AfterOverlayHidden()
public virtual System.Void AfterOverlayOpened()
public virtual System.Void AfterOverlayShown()
```

## MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NGameOverScreen+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NGameOverScreen+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Entities.Players.Player, System.UInt64> <>9__48_0
public static System.Func<System.Collections.Generic.List<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry>, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry>> <>9__49_0
public static System.Func<MegaCrit.Sts2.Core.Nodes.Combat.NCreature, MegaCrit.Sts2.Core.Nodes.Combat.NCreatureVisuals> <>9__67_0
public static System.Comparison<MegaCrit.Sts2.Core.Nodes.Combat.NCreature> <>9__67_1
private static .cctor()
public .ctor()
internal MegaCrit.Sts2.Core.Nodes.Combat.NCreatureVisuals <MoveCreaturesToDifferentLayerAndDisableUi>b__67_0(MegaCrit.Sts2.Core.Nodes.Combat.NCreature c)
internal System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry> <AnimateScoreLines>b__49_0(System.Collections.Generic.List<MegaCrit.Sts2.Core.Runs.History.MapPointHistoryEntry> actEntries)
internal System.Int32 <MoveCreaturesToDifferentLayerAndDisableUi>b__67_1(MegaCrit.Sts2.Core.Nodes.Combat.NCreature c1, MegaCrit.Sts2.Core.Nodes.Combat.NCreature c2)
internal System.UInt64 <AnimateRunSummary>b__48_0(MegaCrit.Sts2.Core.Entities.Players.Player p)
```

## MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NGameOverScreen+<>c__DisplayClass51_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Models.Badges.Badge badge
public .ctor()
internal System.Boolean <SaveBadgesToProgress>b__0(MegaCrit.Sts2.Core.Saves.BadgeStats b)
```

## MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NGameOverScreen+<AnimateBadges>d__50

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NGameOverScreen <>4__this
private System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NBadge> <>7__wrap1
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NGameOverScreen+<AnimateDiscoveries>d__59

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NGameOverScreen <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NGameOverScreen+<AnimateIn>d__68

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NGameOverScreen <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private Godot.Tween <backstopTween>5__2
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NGameOverScreen+<AnimateInQuote>d__45

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NGameOverScreen <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter <>u__2
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NGameOverScreen+<AnimateRunSummary>d__48

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NGameOverScreen <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NGameOverScreen+<AnimateScoreBar>d__53

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NGameOverScreen <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private System.Int32 <currentScore>5__3
private System.Int32 <newThreshold>5__5
private Godot.Tween <scoreTween>5__4
private System.Int32 <unlocksRemaining>5__2
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NGameOverScreen+<AnimateScoreLines>d__49

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NGameOverScreen <>4__this
private System.Collections.Generic.List+Enumerator<MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NScoreLine> <>7__wrap1
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NGameOverScreen+<TransitionOutToMainMenu>d__65

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NGameOverScreen+<TransitionOutToTimeline>d__64

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NGameOverScreen+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AddScoreLine
public static readonly Godot.StringName AfterOverlayClosed
public static readonly Godot.StringName AfterOverlayHidden
public static readonly Godot.StringName AfterOverlayOpened
public static readonly Godot.StringName AfterOverlayShown
public static readonly Godot.StringName DiscoveredAnyEpochs
public static readonly Godot.StringName GetAscensionMulti
public static readonly Godot.StringName GetScoreThreshold
public static readonly Godot.StringName HideSummary
public static readonly Godot.StringName InitializeBannerAndQuote
public static readonly Godot.StringName MoveCreaturesToDifferentLayerAndDisableUi
public static readonly Godot.StringName OnMainMenuButtonPressed
public static readonly Godot.StringName OpenRunHistoryScreen
public static readonly Godot.StringName OpenSummaryScreen
public static readonly Godot.StringName OpenTimeline
public static readonly Godot.StringName PlayUnlockSfx
public static readonly Godot.StringName ReturnToMainMenu
public static readonly Godot.StringName ShowLeaderboard
public static readonly Godot.StringName TweenScore
public static readonly Godot.StringName UpdateBackstopMaterial
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NGameOverScreen+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+PropertyName`。

接口：

```text
public static readonly Godot.StringName _backstop
public static readonly Godot.StringName _backstopMaterial
public static readonly Godot.StringName _badgeContainer
public static readonly Godot.StringName _banner
public static readonly Godot.StringName _continueButton
public static readonly Godot.StringName _creatureContainer
public static readonly Godot.StringName _deathQuote
public static readonly Godot.StringName _discoveryLabel
public static readonly Godot.StringName _encounterQuote
public static readonly Godot.StringName _fullBlackBackstop
public static readonly Godot.StringName _isAnimatingSummary
public static readonly Godot.StringName _leaderboard
public static readonly Godot.StringName _leaderboardButton
public static readonly Godot.StringName _mainMenuButton
public static readonly Godot.StringName _quoteTween
public static readonly Godot.StringName _score
public static readonly Godot.StringName _scoreBar
public static readonly Godot.StringName _scoreFg
public static readonly Godot.StringName _scoreLineContainer
public static readonly Godot.StringName _scoreProgress
public static readonly Godot.StringName _scoreThreshold
public static readonly Godot.StringName _screenshakeContainer
public static readonly Godot.StringName _summaryBackstop
public static readonly Godot.StringName _summaryContainer
public static readonly Godot.StringName _uiNode
public static readonly Godot.StringName _unlocksRemaining
public static readonly Godot.StringName _victoryDamageLabel
public static readonly Godot.StringName _viewRunButton
public static readonly Godot.StringName DefaultFocusedControl
public static readonly Godot.StringName FocusedControlFromTopBar
public static readonly Godot.StringName ScreenType
public static readonly Godot.StringName UseSharedBackstop
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NGameOverScreen+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NReturnToMainMenuButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private static const System.Single _hoverS = 1.2
private Godot.Tween _hoverTween
private static const System.Single _hoverV = 1.4
private Godot.ShaderMaterial _hsv
private MegaCrit.Sts2.addons.mega_text.MegaLabel _label
private static readonly MegaCrit.Sts2.Core.Localization.LocString _mainMenuLoc
private static const System.Single _pressDownS = 1
private static const System.Single _pressDownV = 1
private static readonly Godot.StringName _s
private Godot.Vector2 _showPosition
private Godot.Tween _tween
private static const System.Single _unhoverS = 1
private static const System.Single _unhoverV = 1
private static readonly Godot.StringName _v
System.String[] Hotkeys { protected virtual get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void HideButton()
private System.Void UpdateShaderS(System.Single value)
private System.Void UpdateShaderV(System.Single value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.String[] get_Hotkeys()
protected virtual System.Void OnDisable()
protected virtual System.Void OnEnable()
protected virtual System.Void OnFocus()
protected virtual System.Void OnPress()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void SetLabelForUnlock()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NReturnToMainMenuButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName HideButton
public static readonly Godot.StringName OnDisable
public static readonly Godot.StringName OnEnable
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName SetLabelForUnlock
public static readonly Godot.StringName UpdateShaderS
public static readonly Godot.StringName UpdateShaderV
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NReturnToMainMenuButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _hoverTween
public static readonly Godot.StringName _hsv
public static readonly Godot.StringName _label
public static readonly Godot.StringName _showPosition
public static readonly Godot.StringName _tween
public static readonly Godot.StringName Hotkeys
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NReturnToMainMenuButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NRunSummary

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NDiscoveredItem _discoveredCards
private Godot.Control _discoveredContents
private MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NDiscoveredItem _discoveredEnemies
private MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NDiscoveredItem _discoveredEpochs
private MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NDiscoveredItem _discoveredPotions
private MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NDiscoveredItem _discoveredRelics
private Godot.Control _discoveryContainer
private Godot.Control _discoveryHeader
private static const System.Int32 _maxItemsToList = 10
private Godot.Tween _tween
private Godot.Tween _waitTween
Godot.Control DefaultFocusedControl { public get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task DiscoveryAnimHelper(Godot.Control node)
private static System.String GetDiscoveryBodyText<T>(System.Collections.Generic.List<T> discoveredIds, System.Func<T, System.String> getTitle, System.String locTable, System.String locKey, System.String countParam) where T: [None]
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public [async] System.Threading.Tasks.Task AnimateInDiscoveries(MegaCrit.Sts2.Core.Runs.RunState runState, System.Threading.CancellationToken ct)
public Godot.Control get_DefaultFocusedControl()
public System.Void SetControllerNav(Godot.Control focusNeighborTop)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NRunSummary+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NRunSummary+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Models.ModelId, System.String> <>9__11_0
public static System.Func<MegaCrit.Sts2.Core.Models.ModelId, System.String> <>9__11_1
public static System.Func<MegaCrit.Sts2.Core.Models.ModelId, System.String> <>9__11_2
public static System.Func<MegaCrit.Sts2.Core.Models.ModelId, System.String> <>9__11_3
public static System.Func<Godot.Control, System.Boolean> <>9__16_0
public static System.Func<Godot.Control, System.Boolean> <>9__17_0
private static .cctor()
public .ctor()
internal System.Boolean <get_DefaultFocusedControl>b__16_0(Godot.Control c)
internal System.Boolean <SetControllerNav>b__17_0(Godot.Control c)
internal System.String <AnimateInDiscoveries>b__11_0(MegaCrit.Sts2.Core.Models.ModelId id)
internal System.String <AnimateInDiscoveries>b__11_1(MegaCrit.Sts2.Core.Models.ModelId id)
internal System.String <AnimateInDiscoveries>b__11_2(MegaCrit.Sts2.Core.Models.ModelId id)
internal System.String <AnimateInDiscoveries>b__11_3(MegaCrit.Sts2.Core.Models.ModelId id)
```

## MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NRunSummary+<AnimateInDiscoveries>d__11

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NRunSummary <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private MegaCrit.Sts2.Core.Entities.Players.Player <player>5__2
public System.Threading.CancellationToken ct
public MegaCrit.Sts2.Core.Runs.RunState runState
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NRunSummary+<DiscoveryAnimHelper>d__12

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NRunSummary <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
public Godot.Control node
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NRunSummary+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName SetControllerNav
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NRunSummary+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _discoveredCards
public static readonly Godot.StringName _discoveredContents
public static readonly Godot.StringName _discoveredEnemies
public static readonly Godot.StringName _discoveredEpochs
public static readonly Godot.StringName _discoveredPotions
public static readonly Godot.StringName _discoveredRelics
public static readonly Godot.StringName _discoveryContainer
public static readonly Godot.StringName _discoveryHeader
public static readonly Godot.StringName _tween
public static readonly Godot.StringName _waitTween
public static readonly Godot.StringName DefaultFocusedControl
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NRunSummary+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NScoreLine

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private static readonly System.String _scenePath
private Godot.Tween _tween
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
public [async] System.Threading.Tasks.Task AnimateIn()
public static MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NScoreLine Create(System.String label, System.String score, Godot.Texture2D icon = null)
public virtual System.Void _ExitTree()
```

## MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NScoreLine+<AnimateIn>d__3

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NScoreLine <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NScoreLine+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName Create
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NScoreLine+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _tween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NScoreLine+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NViewRunButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private static const System.Single _hoverS = 1.2
private Godot.Tween _hoverTween
private static const System.Single _hoverV = 1.4
private Godot.ShaderMaterial _hsv
private static const System.Single _pressDownS = 1
private static const System.Single _pressDownV = 1
private static readonly Godot.StringName _s
private Godot.Vector2 _showPosition
private Godot.Tween _tween
private static const System.Single _unhoverS = 1
private static const System.Single _unhoverV = 1
private static readonly Godot.StringName _v
System.String[] Hotkeys { protected virtual get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void UpdateShaderS(System.Single value)
private System.Void UpdateShaderV(System.Single value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.String[] get_Hotkeys()
protected virtual System.Void OnDisable()
protected virtual System.Void OnEnable()
protected virtual System.Void OnFocus()
protected virtual System.Void OnPress()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NViewRunButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnDisable
public static readonly Godot.StringName OnEnable
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName UpdateShaderS
public static readonly Godot.StringName UpdateShaderV
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NViewRunButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _hoverTween
public static readonly Godot.StringName _hsv
public static readonly Godot.StringName _showPosition
public static readonly Godot.StringName _tween
public static readonly Godot.StringName Hotkeys
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NViewRunButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```
