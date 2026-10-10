# MegaCrit.Sts2.Core.Multiplayer.Game

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。


## MegaCrit.Sts2.Core.Multiplayer.Game.EventCombatSynchronizer

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private MegaCrit.Sts2.Core.Models.EventModel _canonicalEvent
private readonly MegaCrit.Sts2.Core.Logging.Logger _logger
private readonly MegaCrit.Sts2.Core.Runs.IRunState _runState
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Multiplayer.Game.EventCombatSynchronizer+EventCombatState> _states
private MegaCrit.Sts2.Core.Combat.CombatState <CombatStateForLayout>k__BackingField
private MegaCrit.Sts2.Core.Models.EncounterModel <MutableEncounterForLayout>k__BackingField
MegaCrit.Sts2.Core.Combat.CombatState CombatStateForLayout { public get; private set; }
MegaCrit.Sts2.Core.Models.EncounterModel MutableEncounterForLayout { public get; private set; }
public .ctor(MegaCrit.Sts2.Core.Runs.IPlayerCollection playerCollection, MegaCrit.Sts2.Core.Runs.IRunState runState)
private MegaCrit.Sts2.Core.Combat.CombatState CreateCombatState(MegaCrit.Sts2.Core.Models.EncounterModel mutableEncounter)
private System.Void EnterCombat()
private System.Void set_CombatStateForLayout(MegaCrit.Sts2.Core.Combat.CombatState value)
private System.Void set_MutableEncounterForLayout(MegaCrit.Sts2.Core.Models.EncounterModel value)
public MegaCrit.Sts2.Core.Combat.CombatState get_CombatStateForLayout()
public MegaCrit.Sts2.Core.Models.EncounterModel get_MutableEncounterForLayout()
public System.Void InitializeForEvent(MegaCrit.Sts2.Core.Models.EventModel localEvent)
public System.Void ReadyToEnterCombat(MegaCrit.Sts2.Core.Models.EncounterModel canonicalEncounter, MegaCrit.Sts2.Core.Entities.Players.Player player, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Rewards.Reward> extraRewards, System.Boolean shouldResumeAfterCombat)
public System.Void ResetState()
```

## MegaCrit.Sts2.Core.Multiplayer.Game.EventSynchronizer

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Models.EventModel _canonicalEvent
private readonly MegaCrit.Sts2.Core.Multiplayer.Game.EventCombatSynchronizer _combatSynchronizer
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.EventModel> _events
private readonly System.UInt64 _localPlayerId
private readonly MegaCrit.Sts2.Core.Logging.Logger _logger
private readonly MegaCrit.Sts2.Core.Multiplayer.Game.RunLocationTargetedMessageBuffer _messageBuffer
private readonly MegaCrit.Sts2.Core.Random.Rng _multiplayerOptionSelectionRng
private readonly MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService _netService
private System.UInt32 _pageIndex
private readonly System.Collections.Generic.List<System.Threading.Tasks.Task> _pendingOptionTasks
private readonly MegaCrit.Sts2.Core.Runs.IPlayerCollection _playerCollection
private readonly System.Collections.Generic.List<System.Nullable<System.UInt32>> _playerVotes
private System.Action<MegaCrit.Sts2.Core.Entities.Players.Player> PlayerVoteChanged
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.EventModel> Events { public get; }
System.Boolean IsShared { public get; }
MegaCrit.Sts2.Core.Entities.Players.Player LocalPlayer { private get; }
event System.Action<MegaCrit.Sts2.Core.Entities.Players.Player> PlayerVoteChanged
public .ctor(MegaCrit.Sts2.Core.Multiplayer.Game.RunLocationTargetedMessageBuffer messageBuffer, MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService netService, MegaCrit.Sts2.Core.Runs.IPlayerCollection playerCollection, MegaCrit.Sts2.Core.Runs.IRunState runState, System.UInt64 localPlayerId, System.UInt64 seed)
private MegaCrit.Sts2.Core.Entities.Players.Player get_LocalPlayer()
private System.Void ChooseOptionForEvent(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Int32 optionIndex)
private System.Void ChooseOptionForSharedEvent(System.UInt32 optionIndex)
private System.Void ChooseSharedEventOption()
private System.Void ClearPlayerVotes()
private System.Void HandleEventOptionChosenMessage(MegaCrit.Sts2.Core.Multiplayer.Messages.Game.Sync.OptionIndexChosenMessage message, System.UInt64 senderId)
private System.Void HandleSharedEventOptionChosenMessage(MegaCrit.Sts2.Core.Multiplayer.Messages.Game.Sync.SharedEventOptionChosenMessage message, System.UInt64 senderId)
private System.Void HandleVotedForSharedEventOptionMessage(MegaCrit.Sts2.Core.Multiplayer.Messages.Game.Sync.VotedForSharedEventOptionMessage message, System.UInt64 senderId)
private System.Void PlayerVotedForSharedOptionIndex(MegaCrit.Sts2.Core.Entities.Players.Player player, System.UInt32 optionIndex, System.UInt32 pageIndex)
private System.Void SaveEventOptionToHistory(MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.Events.EventOption option)
public [async] System.Threading.Tasks.Task AwaitPendingOptionTasks()
public MegaCrit.Sts2.Core.Models.EventModel GetEventForPlayer(MegaCrit.Sts2.Core.Entities.Players.Player player)
public MegaCrit.Sts2.Core.Models.EventModel GetLocalEvent()
public System.Boolean get_IsShared()
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.EventModel> get_Events()
public System.Nullable<System.UInt32> GetPlayerVote(MegaCrit.Sts2.Core.Entities.Players.Player player)
public System.Void add_PlayerVoteChanged(System.Action<MegaCrit.Sts2.Core.Entities.Players.Player> value)
public System.Void BeforeExitingRoom()
public System.Void BeginEvent(MegaCrit.Sts2.Core.Models.EventModel canonicalEvent, System.Boolean isPrefinished = False, System.Action<MegaCrit.Sts2.Core.Models.EventModel> debugOnStart = null)
public System.Void ChooseLocalOption(System.Int32 index)
public System.Void GenerateInternalCombatStateIfNecessary(MegaCrit.Sts2.Core.Models.EventModel localEvent)
public System.Void remove_PlayerVoteChanged(System.Action<MegaCrit.Sts2.Core.Entities.Players.Player> value)
public System.Void ResumeEvents(MegaCrit.Sts2.Core.Rooms.AbstractRoom exitedRoom)
public virtual System.Void Dispose()
```

