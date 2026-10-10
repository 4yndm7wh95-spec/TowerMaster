# MegaCrit.Sts2.Core.Nodes.Debug.Multiplayer

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.Debug.Multiplayer.NMultiplayerTest

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.IStartRunLobbyListener`

```text
private System.Boolean _beginningRun
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Debug.Multiplayer.NMultiplayerTest+CharacterContainer> _characterContainers
private MegaCrit.Sts2.Core.Nodes.Debug.Multiplayer.NMultiplayerTestCharacterPaginator _characterPaginator
private System.Threading.CancellationTokenSource _cts
private MegaCrit.Sts2.Core.Nodes.NGame _game
private Godot.TextEdit _idField
private System.Boolean _ignoreReplayModelIdHash
private Godot.TextEdit _ipField
private Godot.Control _loadingPanel
private MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby _lobby
private readonly MegaCrit.Sts2.Core.Saves.Runs.SerializablePlayer _localPlayerData
private static const System.UInt16 _port = 33771
private Godot.Button _readyButton
private Godot.Control _readyIndicator
private MegaCrit.Sts2.Core.Nodes.Debug.IBootstrapSettings _settings
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task BeginRunAsync(System.String seed, System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ActModel> acts)
private [async] System.Threading.Tasks.Task BeginRunAsyncWrapper(System.String seed, System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ActModel> acts)
private [async] System.Threading.Tasks.Task<System.Boolean> StartHost(System.Boolean steam)
private static [async] System.Threading.Tasks.Task RunReplay(MegaCrit.Sts2.Core.Multiplayer.Replay.CombatReplay replay, Godot.SceneTree sceneTree, System.Int32 playerIndex)
private System.Boolean ValidateReplay(MegaCrit.Sts2.Core.Multiplayer.Replay.CombatReplay replay)
private System.Void AddGame()
private System.Void AfterMultiplayerStarted()
private System.Void ChooseReplay(System.Action<System.String> action)
private System.Void ChooseReplayToLoad()
private System.Void ChooseReplayToSave()
private System.Void Disconnect(MegaCrit.Sts2.Core.Entities.Multiplayer.NetError reason)
private System.Void HostButtonPressed()
private System.Void JoinButtonPressed()
private System.Void LoadReplay(System.String path)
private System.Void OnCharacterChanged(MegaCrit.Sts2.Core.Models.CharacterModel model)
private System.Void ReadyButtonPressed()
private System.Void WriteReplayAsSave(System.String path)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public [async] System.Threading.Tasks.Task JoinToHost(MegaCrit.Sts2.Core.Multiplayer.Connection.IClientConnectionInitializer initializer)
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
public virtual System.Void AscensionChanged()
public virtual System.Void BeginRun(System.String seed, System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ActModel> acts, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel> __)
public virtual System.Void LocalPlayerDisconnected(MegaCrit.Sts2.Core.Entities.Multiplayer.NetErrorInfo info)
public virtual System.Void MaxAscensionChanged()
public virtual System.Void ModifiersChanged()
public virtual System.Void PlayerChanged(MegaCrit.Sts2.Core.Entities.Multiplayer.StartRunLobbyPlayer player, System.Boolean isRandomCharacterResolution)
public virtual System.Void PlayerConnected(MegaCrit.Sts2.Core.Entities.Multiplayer.StartRunLobbyPlayer player)
public virtual System.Void RemotePlayerDisconnected(MegaCrit.Sts2.Core.Entities.Multiplayer.StartRunLobbyPlayer player)
public virtual System.Void SeedChanged()
```

## MegaCrit.Sts2.Core.Nodes.Debug.Multiplayer.NMultiplayerTest+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Debug.Multiplayer.NMultiplayerTest+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, MegaCrit.Sts2.Core.Saves.Runs.SerializableCard> <>9__22_0
public static System.Func<MegaCrit.Sts2.Core.Models.RelicModel, MegaCrit.Sts2.Core.Saves.Runs.SerializableRelic> <>9__22_1
public static System.Func<MegaCrit.Sts2.Core.Entities.Multiplayer.StartRunLobbyPlayer, MegaCrit.Sts2.Core.Entities.Players.Player> <>9__25_0
public static System.Func<MegaCrit.Sts2.Core.Models.ActModel, MegaCrit.Sts2.Core.Models.ActModel> <>9__25_1
public static System.Func<MegaCrit.Sts2.Core.Entities.Players.Player, MegaCrit.Sts2.Core.Models.CharacterModel> <>9__25_2
public static System.Func<MegaCrit.Sts2.Core.Entities.Multiplayer.StartRunLobbyPlayer, System.UInt64> <>9__29_0
public static System.Func<MegaCrit.Sts2.Core.Entities.Players.Player, MegaCrit.Sts2.Core.Models.CharacterModel> <>9__35_0
private static .cctor()
public .ctor()
internal MegaCrit.Sts2.Core.Entities.Players.Player <BeginRunAsync>b__25_0(MegaCrit.Sts2.Core.Entities.Multiplayer.StartRunLobbyPlayer p)
internal MegaCrit.Sts2.Core.Models.ActModel <BeginRunAsync>b__25_1(MegaCrit.Sts2.Core.Models.ActModel a)
internal MegaCrit.Sts2.Core.Models.CharacterModel <BeginRunAsync>b__25_2(MegaCrit.Sts2.Core.Entities.Players.Player p)
internal MegaCrit.Sts2.Core.Models.CharacterModel <RunReplay>b__35_0(MegaCrit.Sts2.Core.Entities.Players.Player p)
internal MegaCrit.Sts2.Core.Saves.Runs.SerializableCard <ReadyButtonPressed>b__22_0(MegaCrit.Sts2.Core.Models.CardModel c)
internal MegaCrit.Sts2.Core.Saves.Runs.SerializableRelic <ReadyButtonPressed>b__22_1(MegaCrit.Sts2.Core.Models.RelicModel r)
internal System.UInt64 <AfterMultiplayerStarted>b__29_0(MegaCrit.Sts2.Core.Entities.Multiplayer.StartRunLobbyPlayer p)
```

## MegaCrit.Sts2.Core.Nodes.Debug.Multiplayer.NMultiplayerTest+<>O

类型属性：`NestedPrivate, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static System.Action <0>__DeleteCloudSaves
```

## MegaCrit.Sts2.Core.Nodes.Debug.Multiplayer.NMultiplayerTest+<BeginRunAsync>d__25

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Debug.Multiplayer.NMultiplayerTest <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Rooms.AbstractRoom> <>u__2
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Runs.RunState> <>u__3
private MegaCrit.Sts2.Core.Multiplayer.Game.NetLoadingHandle <loadHandle>5__2
private MegaCrit.Sts2.Core.Runs.RunState <runState>5__3
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ActModel> acts
public System.String seed
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Debug.Multiplayer.NMultiplayerTest+<BeginRunAsyncWrapper>d__24

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Debug.Multiplayer.NMultiplayerTest <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ActModel> acts
public System.String seed
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Debug.Multiplayer.NMultiplayerTest+<JoinToHost>d__28

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Debug.Multiplayer.NMultiplayerTest <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Multiplayer.Game.JoinResult> <>u__1
private MegaCrit.Sts2.Core.Multiplayer.Game.JoinFlow <joinFlow>5__2
public MegaCrit.Sts2.Core.Multiplayer.Connection.IClientConnectionInitializer initializer
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Debug.Multiplayer.NMultiplayerTest+<RunReplay>d__35

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
private System.Collections.Generic.List+Enumerator<MegaCrit.Sts2.Core.Multiplayer.Replay.CombatReplayEvent> <>7__wrap2
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__2
private MegaCrit.Sts2.Core.GameActions.GameAction <action>5__5
private MegaCrit.Sts2.Core.Multiplayer.Replay.CombatReplayEvent <replayEvent>5__4
private MegaCrit.Sts2.Core.Runs.RunState <runState>5__2
public System.Int32 playerIndex
public MegaCrit.Sts2.Core.Multiplayer.Replay.CombatReplay replay
public Godot.SceneTree sceneTree
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Debug.Multiplayer.NMultiplayerTest+<StartHost>d__27

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Debug.Multiplayer.NMultiplayerTest <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Boolean> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Nullable<MegaCrit.Sts2.Core.Entities.Multiplayer.NetErrorInfo>> <>u__1
private MegaCrit.Sts2.Core.Multiplayer.NetHostGameService <netService>5__2
public System.Boolean steam
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Debug.Multiplayer.NMultiplayerTest+CharacterContainer

类型属性：`NestedPrivate, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：

```text
public Godot.TextureRect characterImage
public Godot.Label playerName
```

## MegaCrit.Sts2.Core.Nodes.Debug.Multiplayer.NMultiplayerTest+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AddGame
public static readonly Godot.StringName AfterMultiplayerStarted
public static readonly Godot.StringName AscensionChanged
public static readonly Godot.StringName ChooseReplayToLoad
public static readonly Godot.StringName ChooseReplayToSave
public static readonly Godot.StringName Disconnect
public static readonly Godot.StringName HostButtonPressed
public static readonly Godot.StringName JoinButtonPressed
public static readonly Godot.StringName LoadReplay
public static readonly Godot.StringName MaxAscensionChanged
public static readonly Godot.StringName ModifiersChanged
public static readonly Godot.StringName ReadyButtonPressed
public static readonly Godot.StringName SeedChanged
public static readonly Godot.StringName WriteReplayAsSave
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Debug.Multiplayer.NMultiplayerTest+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _beginningRun
public static readonly Godot.StringName _characterPaginator
public static readonly Godot.StringName _game
public static readonly Godot.StringName _idField
public static readonly Godot.StringName _ignoreReplayModelIdHash
public static readonly Godot.StringName _ipField
public static readonly Godot.StringName _loadingPanel
public static readonly Godot.StringName _readyButton
public static readonly Godot.StringName _readyIndicator
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Debug.Multiplayer.NMultiplayerTest+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Debug.Multiplayer.NMultiplayerTestCharacterPaginator

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NPaginator`。

接口：`System.IDisposable`

```text
private readonly MegaCrit.Sts2.Core.Models.CharacterModel[] _characters
private System.Action<MegaCrit.Sts2.Core.Models.CharacterModel> CharacterChanged
MegaCrit.Sts2.Core.Models.CharacterModel Character { public get; }
event System.Action<MegaCrit.Sts2.Core.Models.CharacterModel> CharacterChanged
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void OnIndexChanged(System.Int32 index)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public MegaCrit.Sts2.Core.Models.CharacterModel get_Character()
public System.Void add_CharacterChanged(System.Action<MegaCrit.Sts2.Core.Models.CharacterModel> value)
public System.Void remove_CharacterChanged(System.Action<MegaCrit.Sts2.Core.Models.CharacterModel> value)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Debug.Multiplayer.NMultiplayerTestCharacterPaginator+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NPaginator+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnIndexChanged
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Debug.Multiplayer.NMultiplayerTestCharacterPaginator+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NPaginator+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Debug.Multiplayer.NMultiplayerTestCharacterPaginator+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Settings.NPaginator+SignalName`。

接口：

```text
public .ctor()
```
