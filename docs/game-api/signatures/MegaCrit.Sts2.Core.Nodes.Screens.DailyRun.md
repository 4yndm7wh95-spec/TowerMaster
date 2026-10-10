# MegaCrit.Sts2.Core.Nodes.Screens.DailyRun

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.DecodedDailyScore

类型属性：`Public, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：

```text
public System.Int32 badges
public System.Int32 floors
public System.Boolean isValid
public System.Int32 runTime
public System.Int32 victory
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunCharacterContainer

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.addons.mega_text.MegaLabel _ascensionLabel
private static readonly MegaCrit.Sts2.Core.Localization.LocString _ascensionLoc
private MegaCrit.Sts2.addons.mega_text.MegaLabel _ascensionNumberLabel
private Godot.Control _characterIconContainer
private MegaCrit.Sts2.addons.mega_text.MegaLabel _characterNameLabel
private MegaCrit.Sts2.addons.mega_text.MegaLabel _playerNameLabel
private Godot.Control _readyIndicator
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void Fill(MegaCrit.Sts2.Core.Models.CharacterModel character, System.UInt64 playerId, System.Int32 ascension, MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService netService)
public System.Void SetIsReady(System.Boolean isReady)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunCharacterContainer+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName SetIsReady
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunCharacterContainer+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _ascensionLabel
public static readonly Godot.StringName _ascensionNumberLabel
public static readonly Godot.StringName _characterIconContainer
public static readonly Godot.StringName _characterNameLabel
public static readonly Godot.StringName _playerNameLabel
public static readonly Godot.StringName _readyIndicator
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunCharacterContainer+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunLeaderboard

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private System.Int32 _currentIndex
private System.Int32 _currentPage
private static const System.Int32 _defaultGlobalIndex = -4
private static readonly MegaCrit.Sts2.Core.Localization.LocString _fetchingScoreLoc
private static readonly MegaCrit.Sts2.Core.Localization.LocString _friendsLoc
private MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NGlobalRankTickbox _globalTickbox
private System.Boolean _hasNegativeScore
private System.Nullable<System.DateTimeOffset> _leaderboardTime
private MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NLeaderboardPageArrow _leftArrow
private System.Threading.CancellationTokenSource _loadCts
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _loadingIndicator
private static const System.Int32 _maxEntries = 10
private MegaCrit.Sts2.addons.mega_text.MegaLabel _noFriendsIndicator
private MegaCrit.Sts2.addons.mega_text.MegaLabel _noScoresIndicator
private Godot.Control _noScoreUploadIndicator
private MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NLeaderboardDayPaginator _paginator
private readonly System.Collections.Generic.List<System.UInt64> _playersInRun
private MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NLeaderboardPageArrow _rightArrow
private static readonly System.String _scenePath
private Godot.VBoxContainer _scoreContainer
private static readonly MegaCrit.Sts2.Core.Localization.LocString _scoreLoc
private Godot.Control _separators
private static readonly MegaCrit.Sts2.Core.Localization.LocString _titleLoc
private System.DateTimeOffset _todaysDailyTime
System.String[] AssetPaths { public static get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task LoadLeaderboard(System.DateTimeOffset dateTime, System.Int32 page, MegaCrit.Sts2.Core.Leaderboard.LeaderboardQueryType queryType, System.Boolean initialLoad)
private [async] System.Threading.Tasks.Task QueryFriendScores(MegaCrit.Sts2.Core.Leaderboard.ILeaderboardHandle handle, System.DateTimeOffset dateTime, System.Int32 page, System.Threading.CancellationToken ct)
private [async] System.Threading.Tasks.Task QueryGlobalScores(MegaCrit.Sts2.Core.Leaderboard.ILeaderboardHandle handle, System.DateTimeOffset dateTime, System.Boolean initialLoad, System.Threading.CancellationToken ct)
private System.Void <_Ready>b__26_0()
private System.Void <_Ready>b__26_1()
private System.Void ChangePage(System.Int32 _ = 0)
private System.Void ClearEntries()
private System.Void FillEntries(System.Collections.Generic.List<MegaCrit.Sts2.Core.Leaderboard.LeaderboardEntry> entries)
private System.Void NavigateGlobalRank()
private System.Void SetLocalizedText()
private System.Void SetPage(System.Int32 page)
private System.Void ToggleGlobalRank(MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox tickbox)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static System.String[] get_AssetPaths()
public System.Void Cleanup()
public System.Void Initialize(System.DateTimeOffset dateTime, System.Collections.Generic.IEnumerable<System.UInt64> playersInRun, System.Boolean allowPagination)
public System.Void SetDay(System.DateTimeOffset dateTime)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunLeaderboard+<LoadLeaderboard>d__35

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunLeaderboard <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Leaderboard.ILeaderboardHandle[]> <>u__2
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Leaderboard.ILeaderboardHandle> <>u__3
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__4
private System.Threading.CancellationToken <ct>5__2
private MegaCrit.Sts2.Core.Leaderboard.ILeaderboardHandle <handle>5__7
private System.Boolean <hasLeftLeaderboard>5__8
private System.Threading.Tasks.Task<MegaCrit.Sts2.Core.Leaderboard.ILeaderboardHandle> <leftTask>5__5
private System.Threading.Tasks.Task<MegaCrit.Sts2.Core.Leaderboard.ILeaderboardHandle> <mainTask>5__4
private System.Nullable<System.DateTimeOffset> <rightLeaderboardTime>5__3
private System.Threading.Tasks.Task<MegaCrit.Sts2.Core.Leaderboard.ILeaderboardHandle> <rightTask>5__6
public System.DateTimeOffset dateTime
public System.Boolean initialLoad
public System.Int32 page
public MegaCrit.Sts2.Core.Leaderboard.LeaderboardQueryType queryType
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunLeaderboard+<QueryFriendScores>d__36

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunLeaderboard <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.List<MegaCrit.Sts2.Core.Leaderboard.LeaderboardEntry>> <>u__1
public System.Threading.CancellationToken ct
public System.DateTimeOffset dateTime
public MegaCrit.Sts2.Core.Leaderboard.ILeaderboardHandle handle
public System.Int32 page
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunLeaderboard+<QueryGlobalScores>d__37

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunLeaderboard <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.List<MegaCrit.Sts2.Core.Leaderboard.LeaderboardEntry>> <>u__1
public System.Threading.CancellationToken ct
public System.DateTimeOffset dateTime
public MegaCrit.Sts2.Core.Leaderboard.ILeaderboardHandle handle
public System.Boolean initialLoad
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunLeaderboard+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName ChangePage
public static readonly Godot.StringName Cleanup
public static readonly Godot.StringName ClearEntries
public static readonly Godot.StringName NavigateGlobalRank
public static readonly Godot.StringName SetLocalizedText
public static readonly Godot.StringName SetPage
public static readonly Godot.StringName ToggleGlobalRank
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunLeaderboard+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _currentIndex
public static readonly Godot.StringName _currentPage
public static readonly Godot.StringName _globalTickbox
public static readonly Godot.StringName _hasNegativeScore
public static readonly Godot.StringName _leftArrow
public static readonly Godot.StringName _loadingIndicator
public static readonly Godot.StringName _noFriendsIndicator
public static readonly Godot.StringName _noScoresIndicator
public static readonly Godot.StringName _noScoreUploadIndicator
public static readonly Godot.StringName _paginator
public static readonly Godot.StringName _rightArrow
public static readonly Godot.StringName _scoreContainer
public static readonly Godot.StringName _separators
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunLeaderboard+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunLeaderboardHeader

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.addons.mega_text.MegaLabel _name
private MegaCrit.Sts2.addons.mega_text.MegaLabel _rank
private static readonly System.String _scenePath
private MegaCrit.Sts2.addons.mega_text.MegaLabel _score
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
public static MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunLeaderboardHeader Create()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunLeaderboardHeader+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunLeaderboardHeader+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _name
public static readonly Godot.StringName _rank
public static readonly Godot.StringName _score
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunLeaderboardHeader+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunLeaderboardRow

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.addons.mega_text.MegaLabel _badges
private MegaCrit.Sts2.Core.Leaderboard.LeaderboardEntry _entry
private MegaCrit.Sts2.addons.mega_text.MegaLabel _floor
private System.Boolean _isYou
private MegaCrit.Sts2.addons.mega_text.MegaLabel _name
private MegaCrit.Sts2.addons.mega_text.MegaLabel _rank
private static readonly System.String _scenePath
private MegaCrit.Sts2.addons.mega_text.MegaLabel _time
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private static System.String FormatHoursAndMinutes(System.Int32 value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunLeaderboardRow Create(MegaCrit.Sts2.Core.Leaderboard.LeaderboardEntry entry, System.Boolean isYou)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunLeaderboardRow+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunLeaderboardRow+<>c <>9
public static System.Func<System.UInt64, System.String> <>9__9_0
private static .cctor()
public .ctor()
internal System.String <_Ready>b__9_0(System.UInt64 id)
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunLeaderboardRow+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName FormatHoursAndMinutes
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunLeaderboardRow+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _badges
public static readonly Godot.StringName _floor
public static readonly Godot.StringName _isYou
public static readonly Godot.StringName _name
public static readonly Godot.StringName _rank
public static readonly Godot.StringName _time
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunLeaderboardRow+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunLeaderboardSeparator

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private static readonly System.String _scenePath
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunLeaderboardSeparator Create()
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunLeaderboardSeparator+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName Create
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunLeaderboardSeparator+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunLeaderboardSeparator+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunLoadScreen

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`, `MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.ILoadRunLobbyListener`

```text
private static readonly MegaCrit.Sts2.Core.Localization.LocString _ascensionLoc
private MegaCrit.Sts2.Core.Nodes.CommonUi.NBackButton _backButton
private MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunCharacterContainer _characterContainer
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _dateLabel
private MegaCrit.Sts2.Core.Nodes.CommonUi.NConfirmButton _embarkButton
private MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunLeaderboard _leaderboard
private MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.LoadRunLobby _lobby
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunScreenModifier> _modifierContainers
private Godot.Control _modifiersContainer
private MegaCrit.Sts2.addons.mega_text.MegaLabel _modifiersTitleLabel
private Godot.Control _readyAndWaitingContainer
private MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteLoadLobbyPlayerContainer _remotePlayerContainer
private static readonly System.String _scenePath
private MegaCrit.Sts2.Core.Nodes.CommonUi.NBackButton _unreadyButton
public static readonly System.String dateFormat
System.String[] AssetPaths { public static get; }
Godot.Control InitialFocusedControl { protected virtual get; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task StartRun()
private System.Boolean <InitializeDisplay>b__25_0(MegaCrit.Sts2.Core.Saves.Runs.SerializablePlayer p)
private System.Boolean <StartRun>b__32_0(MegaCrit.Sts2.Core.Saves.Runs.SerializablePlayer p)
private System.Void AfterMultiplayerStarted()
private System.Void CleanUpLobby(System.Boolean disconnectSession, MegaCrit.Sts2.Core.Entities.Multiplayer.NetError error = 1)
private System.Void InitializeDisplay()
private System.Void OnEmbarkPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OnUnreadyPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void RemoteClientFailedToConnectToLocalHost(System.UInt64 sender, MegaCrit.Sts2.Core.Entities.Multiplayer.NetErrorInfo info)
private System.Void UpdateRichPresence()
protected virtual Godot.Control get_InitialFocusedControl()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunLoadScreen Create()
public static System.String[] get_AssetPaths()
public System.Void InitializeAsClient(MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService gameService, MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.ClientLoadJoinResponseMessage message)
public System.Void InitializeAsHost(MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService gameService, MegaCrit.Sts2.Core.Saves.SerializableRun run)
public virtual [async] System.Threading.Tasks.Task<System.Boolean> ShouldAllowRunToBegin()
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
public virtual System.Void BeginRun()
public virtual System.Void LocalPlayerDisconnected(MegaCrit.Sts2.Core.Entities.Multiplayer.NetErrorInfo info)
public virtual System.Void OnSubmenuClosed()
public virtual System.Void OnSubmenuOpened()
public virtual System.Void PlayerConnected(MegaCrit.Sts2.Core.Entities.Multiplayer.LoadRunLobbyPlayer player)
public virtual System.Void PlayerReadyChanged(System.UInt64 playerId)
public virtual System.Void RemotePlayerDisconnected(System.UInt64 playerId)
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunLoadScreen+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunLoadScreen+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Saves.Runs.SerializablePlayer, System.UInt64> <>9__23_0
private static .cctor()
public .ctor()
internal System.UInt64 <OnSubmenuOpened>b__23_0(MegaCrit.Sts2.Core.Saves.Runs.SerializablePlayer p)
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunLoadScreen+<ShouldAllowRunToBegin>d__31

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunLoadScreen <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Boolean> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunLoadScreen+<StartRun>d__32

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunLoadScreen <>4__this
private System.Object <>7__wrap1
private System.Int32 <>7__wrap2
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private MegaCrit.Sts2.Core.Runs.RunState <runState>5__4
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunLoadScreen+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+MethodName`。

接口：

```text
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AfterMultiplayerStarted
public static readonly Godot.StringName BeginRun
public static readonly Godot.StringName CleanUpLobby
public static readonly Godot.StringName Create
public static readonly Godot.StringName InitializeDisplay
public static readonly Godot.StringName OnEmbarkPressed
public static readonly Godot.StringName OnSubmenuClosed
public static readonly Godot.StringName OnSubmenuOpened
public static readonly Godot.StringName OnUnreadyPressed
public static readonly Godot.StringName PlayerReadyChanged
public static readonly Godot.StringName RemotePlayerDisconnected
public static readonly Godot.StringName UpdateRichPresence
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunLoadScreen+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+PropertyName`。

接口：

```text
public static readonly Godot.StringName _backButton
public static readonly Godot.StringName _characterContainer
public static readonly Godot.StringName _dateLabel
public static readonly Godot.StringName _embarkButton
public static readonly Godot.StringName _leaderboard
public static readonly Godot.StringName _modifiersContainer
public static readonly Godot.StringName _modifiersTitleLabel
public static readonly Godot.StringName _readyAndWaitingContainer
public static readonly Godot.StringName _remotePlayerContainer
public static readonly Godot.StringName _unreadyButton
public static readonly Godot.StringName InitialFocusedControl
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunLoadScreen+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunScoreWarning

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl`。

接口：`System.IDisposable`

```text
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void OnFocus()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunScoreWarning+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnUnfocus
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunScoreWarning+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunScoreWarning+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunScreen

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`, `MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.IStartRunLobbyListener`

```text
private MegaCrit.Sts2.Core.Nodes.CommonUi.NBackButton _backButton
private MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunCharacterContainer _characterContainer
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _dateLabel
private MegaCrit.Sts2.addons.mega_text.MegaLabel _disclaimer
private MegaCrit.Sts2.Core.Nodes.CommonUi.NConfirmButton _embarkButton
private System.DateTimeOffset _endOfDay
private System.Nullable<System.Int32> _lastSetTimeLeftSecond
private MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunLeaderboard _leaderboard
private MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby _lobby
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunScreenModifier> _modifierContainers
private Godot.Control _modifiersContainer
private MegaCrit.Sts2.addons.mega_text.MegaLabel _modifiersTitleLabel
private MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService _netService
private Godot.Control _readyAndWaitingContainer
private MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteLobbyPlayerContainer _remotePlayerContainer
private static readonly System.String _scenePath
private static readonly System.String _timeLeftFormat
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _timeLeftLabel
private static readonly MegaCrit.Sts2.Core.Localization.LocString _timeLeftLoc
private MegaCrit.Sts2.addons.mega_text.MegaLabel _titleLabel
private MegaCrit.Sts2.Core.Nodes.CommonUi.NBackButton _unreadyButton
public static readonly System.String dateFormat
System.String[] AssetPaths { public static get; }
Godot.Control InitialFocusedControl { protected virtual get; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task SetupLobbyForHostOrSingleplayer()
private [async] System.Threading.Tasks.Task<MegaCrit.Sts2.Core.Daily.TimeServerResult> GetTimeServerTime()
private System.DateTimeOffset GetServerRelativeTime()
private System.Void AfterLobbyInitialized()
private System.Void CleanUpLobby(System.Boolean disconnectSession, MegaCrit.Sts2.Core.Entities.Multiplayer.NetError error = 1)
private System.Void InitializeDisplay()
private System.Void InitializeLeaderboard()
private System.Void OnEmbarkPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OnUnreadyPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void RemoteClientFailedToConnectToLocalHost(System.UInt64 sender, MegaCrit.Sts2.Core.Entities.Multiplayer.NetErrorInfo info)
private System.Void SetIsLoading(System.Boolean isLoading)
private System.Void SetupLobbyParams(MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby lobby)
private System.Void UpdateRichPresence()
protected virtual Godot.Control get_InitialFocusedControl()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public [async] System.Threading.Tasks.Task StartNewMultiplayerRun(System.String seed, System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ActModel> acts, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel> modifiers)
public [async] System.Threading.Tasks.Task StartNewSingleplayerRun(System.String seed, System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ActModel> acts, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel> modifiers)
public static MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunScreen Create()
public static System.String[] get_AssetPaths()
public System.Void InitializeMultiplayerAsClient(MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService gameService, MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.ClientLobbyJoinResponseMessage message)
public System.Void InitializeMultiplayerAsHost(MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService gameService)
public System.Void InitializeSingleplayer()
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
public virtual System.Void AscensionChanged()
public virtual System.Void BeginRun(System.String seed, System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ActModel> acts, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel> modifiers)
public virtual System.Void LocalPlayerDisconnected(MegaCrit.Sts2.Core.Entities.Multiplayer.NetErrorInfo info)
public virtual System.Void MaxAscensionChanged()
public virtual System.Void ModifiersChanged()
public virtual System.Void OnSubmenuClosed()
public virtual System.Void OnSubmenuOpened()
public virtual System.Void PlayerChanged(MegaCrit.Sts2.Core.Entities.Multiplayer.StartRunLobbyPlayer player, System.Boolean isRandomCharacterResolution)
public virtual System.Void PlayerConnected(MegaCrit.Sts2.Core.Entities.Multiplayer.StartRunLobbyPlayer player)
public virtual System.Void RemotePlayerDisconnected(MegaCrit.Sts2.Core.Entities.Multiplayer.StartRunLobbyPlayer player)
public virtual System.Void SeedChanged()
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunScreen+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunScreen+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Entities.Multiplayer.StartRunLobbyPlayer, System.UInt64> <>9__33_0
public static System.Func<MegaCrit.Sts2.Core.Entities.Multiplayer.StartRunLobbyPlayer, MegaCrit.Sts2.Core.Models.CharacterModel> <>9__37_0
public static System.Func<MegaCrit.Sts2.Core.Entities.Multiplayer.StartRunLobbyPlayer, System.UInt64> <>9__57_0
private static .cctor()
public .ctor()
internal MegaCrit.Sts2.Core.Models.CharacterModel <SetupLobbyParams>b__37_0(MegaCrit.Sts2.Core.Entities.Multiplayer.StartRunLobbyPlayer p)
internal System.UInt64 <AfterLobbyInitialized>b__57_0(MegaCrit.Sts2.Core.Entities.Multiplayer.StartRunLobbyPlayer p)
internal System.UInt64 <InitializeLeaderboard>b__33_0(MegaCrit.Sts2.Core.Entities.Multiplayer.StartRunLobbyPlayer p)
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunScreen+<>c__DisplayClass37_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby lobby
public .ctor()
internal System.Boolean <SetupLobbyParams>b__1(MegaCrit.Sts2.Core.Models.ModifierModel m)
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunScreen+<GetTimeServerTime>d__35

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<MegaCrit.Sts2.Core.Daily.TimeServerResult> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Nullable<MegaCrit.Sts2.Core.Daily.TimeServerResult>> <>u__1
private System.Nullable<MegaCrit.Sts2.Core.Daily.TimeServerResult> <result>5__2
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunScreen+<SetupLobbyForHostOrSingleplayer>d__34

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunScreen <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Daily.TimeServerResult> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunScreen+<StartNewMultiplayerRun>d__54

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunScreen <>4__this
private System.Object <>7__wrap1
private System.Int32 <>7__wrap2
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Runs.RunState> <>u__2
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ActModel> acts
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel> modifiers
public System.String seed
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunScreen+<StartNewSingleplayerRun>d__53

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunScreen <>4__this
private System.Object <>7__wrap1
private System.Int32 <>7__wrap2
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Runs.RunState> <>u__2
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ActModel> acts
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel> modifiers
public System.String seed
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunScreen+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+MethodName`。

接口：

```text
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AfterLobbyInitialized
public static readonly Godot.StringName AscensionChanged
public static readonly Godot.StringName CleanUpLobby
public static readonly Godot.StringName Create
public static readonly Godot.StringName InitializeDisplay
public static readonly Godot.StringName InitializeLeaderboard
public static readonly Godot.StringName InitializeSingleplayer
public static readonly Godot.StringName MaxAscensionChanged
public static readonly Godot.StringName ModifiersChanged
public static readonly Godot.StringName OnEmbarkPressed
public static readonly Godot.StringName OnSubmenuClosed
public static readonly Godot.StringName OnSubmenuOpened
public static readonly Godot.StringName OnUnreadyPressed
public static readonly Godot.StringName SeedChanged
public static readonly Godot.StringName SetIsLoading
public static readonly Godot.StringName UpdateRichPresence
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunScreen+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+PropertyName`。

接口：

```text
public static readonly Godot.StringName _backButton
public static readonly Godot.StringName _characterContainer
public static readonly Godot.StringName _dateLabel
public static readonly Godot.StringName _disclaimer
public static readonly Godot.StringName _embarkButton
public static readonly Godot.StringName _leaderboard
public static readonly Godot.StringName _modifiersContainer
public static readonly Godot.StringName _modifiersTitleLabel
public static readonly Godot.StringName _readyAndWaitingContainer
public static readonly Godot.StringName _remotePlayerContainer
public static readonly Godot.StringName _timeLeftLabel
public static readonly Godot.StringName _titleLabel
public static readonly Godot.StringName _unreadyButton
public static readonly Godot.StringName InitialFocusedControl
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunScreen+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunScreenModifier

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _description
private Godot.TextureRect _icon
private static readonly MegaCrit.Sts2.Core.Localization.LocString _modifierLoc
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void Fill(MegaCrit.Sts2.Core.Models.ModifierModel modifier)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunScreenModifier+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunScreenModifier+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _description
public static readonly Godot.StringName _icon
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunScreenModifier+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NGlobalRankTickbox

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.addons.mega_text.MegaLabel _label
private Godot.Tween _labelTween
System.String[] Hotkeys { protected virtual get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.String[] get_Hotkeys()
protected virtual System.Void OnFocus()
protected virtual System.Void OnPress()
protected virtual System.Void OnRelease()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void SetLabel(System.String text)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NGlobalRankTickbox+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName SetLabel
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NGlobalRankTickbox+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox+PropertyName`。

接口：

```text
public static readonly Godot.StringName _label
public static readonly Godot.StringName _labelTween
public static readonly Godot.StringName Hotkeys
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NGlobalRankTickbox+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NLeaderboardDayPaginator

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private static const System.Single _animDistance = 90
private static const System.Double _animDuration = 0.25
private System.DateTimeOffset _currentDay
protected MegaCrit.Sts2.addons.mega_text.MegaLabel _label
private MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunLeaderboard _leaderboard
private MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NLeaderboardPageArrow _leftArrow
private MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NLeaderboardPageArrow _rightArrow
private MegaCrit.Sts2.Core.Nodes.Combat.NSelectionReticle _selectionReticle
private Godot.Tween _tween
private MegaCrit.Sts2.addons.mega_text.MegaLabel _vfxLabel
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void DayChangeHelper(System.Boolean pagedLeft)
private System.Void OnDayChanged(System.Boolean changeLeaderboardDay)
private System.Void OnFocus()
private System.Void OnUnfocus()
private System.Void PageLeft()
private System.Void PageRight()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void Disable()
public System.Void Enable(System.Boolean leftArrowEnabled, System.Boolean rightArrowEnabled)
public System.Void Initialize(MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunLeaderboard leaderboard, System.DateTimeOffset dateTime, System.Boolean showArrows)
public virtual System.Void _GuiInput(Godot.InputEvent input)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NLeaderboardDayPaginator+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _GuiInput
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName DayChangeHelper
public static readonly Godot.StringName Disable
public static readonly Godot.StringName Enable
public static readonly Godot.StringName OnDayChanged
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName PageLeft
public static readonly Godot.StringName PageRight
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NLeaderboardDayPaginator+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _label
public static readonly Godot.StringName _leaderboard
public static readonly Godot.StringName _leftArrow
public static readonly Godot.StringName _rightArrow
public static readonly Godot.StringName _selectionReticle
public static readonly Godot.StringName _tween
public static readonly Godot.StringName _vfxLabel
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NLeaderboardDayPaginator+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NLeaderboardPageArrow

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private Godot.Vector2 _baseScale
private System.String[] _hotkeys
private Godot.ShaderMaterial _hsv
private Godot.TextureRect _image
private System.Boolean _isLeftArrow
private System.Action _onRelease
private Godot.Tween _tween
private static readonly Godot.StringName _v
System.String[] Hotkeys { protected virtual get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
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
protected virtual System.Void OnRelease()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void Connect(System.Action onRelease)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NLeaderboardPageArrow+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnDisable
public static readonly Godot.StringName OnEnable
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName UpdateShaderV
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NLeaderboardPageArrow+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _baseScale
public static readonly Godot.StringName _hotkeys
public static readonly Godot.StringName _hsv
public static readonly Godot.StringName _image
public static readonly Godot.StringName _isLeftArrow
public static readonly Godot.StringName _tween
public static readonly Godot.StringName Hotkeys
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NLeaderboardPageArrow+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```
