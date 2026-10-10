# 测试 2 实测结果（2026-10-06）

## 环境与范围

仅测试与报告，未修改代码。测试提交 6106c73；分支 claude/optimistic-rubin-hr3eit；游戏 v0.111.0、mod 0.0.4、同机 A=100001（房主/塔主）和 B=100002。dotnet test：Core 37、mod 15，合计 52 全过；真实程序集编译安装 0 警告、0 错误。安装 manifest version=0.0.4，test2_master_off_field=true。

用户正常测试第一幕暗港三场普通战斗，第三场故意让 B 死亡，两实例正常退出。日志未发现 win 命令，两端各有两次胜利和一次失败记录。密林怪物、精英、跨机器未覆盖。

## 逐项结论

| 项目 | 结论 | 证据与限制 |
| --- | --- | --- |
| 自动测试及安装 | 通过 | 52 测试全过，版本与配置核对正确 |
| 探针及人数改写 | 通过 | 两端探针全部找到，TowerMaster 日志均无 WARN/ERROR；N=122，M=14，无改写失败；122 条方法清单一致 |
| 开局塔主退场 | 通过 | 三场 A 都为 0/80、死亡=True；B 都存活；爬塔人数=1 |
| 单人怪物血量 | 通过（暗港） | 钙化邪教徒 38、41、41；海洋混混 46、46、45，均在要求范围 |
| 密林怪物血量 | 未覆盖 | Mawler 72、Flyconid 47–49 未在本轮出现 |
| 血量公式人数 | 通过（已记录调用） | 两端各 5 条 ScaleMonsterHpForMultiplayer 均 playerCount=1、actIndex=0，正文一致；参数日志每个方法只记前 5 次，第三场只有 1 条，另一只怪物调用未记录 |
| 开局日志一致 | 通过 | 两端各 15 条，去时间戳逐条一致 |
| 全部参数日志一致 | 不通过 | 两端各 15 条，但 MultiplayerScalingModel.ModifyBlockMultiplicative 的 cardPlay 参数有差异，详见原文；本轮无状态发散，不能据此判定战斗状态有误 |
| 测试 1b 清单与生成 | 通过 | 两端各 13 条收到清单/替换/开始生成/生成正文一致；3 次生成顺序正确；序号 2 为非战斗移动，仅接收清单；无 TowerMaster WARN/ERROR |
| StateDivergence | 通过（本轮未发现） | 两份游戏日志均未出现 |
| A 死亡引发异常 | 通过（本轮未发现） | 未发现 GetMe、NullReference、InvalidOperation 异常；不能将全部游戏 ERROR 忽略 |
| 网络动态程序集关联 | 不通过 | 两端启动均报告动态动作程序集未关联 mod，可能影响联机排序；原文如下，交代码负责方处理 |
| B 死亡判负 | 通过 | 两端记录 lost to encounter 并保存历史；用户确认两端都进入失败结算 |
| 塔主胜利后复活、下场又死亡 | 已观察/体验问题 | 用户称不影响游玩；A 铁甲战士战后实际 7 血，用户解释为复活 1 血再加战士被动 6 血；并非最终停在 1 血 |

## 逐场

| 普通战斗 | 清单号/生成楼层 | 原遭遇 | A 开局 | B 开局 | 怪物生命（钙化/混混） |
| --- | --- | --- | --- | --- | --- |
| 1 | 1 / 2 | SludgeSpinnerWeak | 0/80，死亡 | 80/80，存活 | 38/38、46/46 |
| 2 | 3 / 4 | CorpseSlugsWeak | 0/80，死亡 | 32/80，存活 | 41/41、46/46 |
| 3 | 4 / 5 | SeapunkWeak | 0/80，死亡 | 64/80，存活 | 41/41、45/45 |

种子 9117807924891493623；三场均生成 CalcifiedCultist + Seapunk，槽位 null。前两场日志胜利，第三场日志失败。用户报告第三场故意让 B 死亡。

## 画面观察

用户逐项口头确认如下；画面来源为用户观察，未由自动日志独立确认全部视觉细节。

| 观察 | 结论 | 用户反馈 |
| --- | --- | --- |
| A 不参与出牌 | 通过；站立表现记录为体验现象 | A 战斗中仍站着，不能出牌 |
| 回合无需等 A | 通过 | B 结束回合后不用等 A 即进入怪物回合 |
| 怪物目标 | 通过（用户观察） | 怪物只打 B；未单独描述每次攻击是否打空，打空细项未覆盖 |
| 战后复活及奖励 | 实际行为已确认；最终 1 血预期不通过 | A 有奖励界面；铁甲战士实际 7 血，用户解释为复活 1 血加战后恢复 6 血。恢复顺序本身未从日志证明 |
| 选路、领奖等待 | 不通过（塔主完全旁观目标；测试 3 待处理） | 用户明确表示需要等待；是否永久卡死未覆盖，不把正常等待写成永久卡死 |
| B 死亡结算 | 通过 | 第三场故意让 B 死亡后 A、B 都进入失败结算 |

用户对整体游玩评价“没什么问题”，认为塔主每场胜利复活、下场死亡虽奇怪但不影响游玩。

## 日志摘录

### 开局与血量参数（A，移除时间戳；对应 B 一致）

```text
测试2 参数 Creature.ScaleMonsterHpForMultiplayer(encounter=CultistsNormal:ENCOUNTER.CULTISTS_NORMAL, playerCount=1, actIndex=0)
测试2 参数 Creature.ScaleMonsterHpForMultiplayer(encounter=CultistsNormal:ENCOUNTER.CULTISTS_NORMAL, playerCount=1, actIndex=0)
测试2 开局 玩家 100001（塔主）：生命=0/80 死亡=True
测试2 开局 玩家 100002：生命=80/80 死亡=False
测试2 开局 爬塔人数=1
测试2 开局 怪物 CalcifiedCultist:MONSTER.CALCIFIED_CULTIST：生命=38/38 格挡=0
测试2 开局 怪物 Seapunk:MONSTER.SEAPUNK：生命=46/46 格挡=0
测试2 参数 Creature.ScaleMonsterHpForMultiplayer(encounter=CultistsNormal:ENCOUNTER.CULTISTS_NORMAL, playerCount=1, actIndex=0)
测试2 参数 Creature.ScaleMonsterHpForMultiplayer(encounter=CultistsNormal:ENCOUNTER.CULTISTS_NORMAL, playerCount=1, actIndex=0)
测试2 开局 玩家 100001（塔主）：生命=0/80 死亡=True
测试2 开局 玩家 100002：生命=32/80 死亡=False
测试2 开局 爬塔人数=1
测试2 开局 怪物 CalcifiedCultist:MONSTER.CALCIFIED_CULTIST：生命=41/41 格挡=0
测试2 开局 怪物 Seapunk:MONSTER.SEAPUNK：生命=46/46 格挡=0
测试2 参数 Creature.ScaleMonsterHpForMultiplayer(encounter=CultistsNormal:ENCOUNTER.CULTISTS_NORMAL, playerCount=1, actIndex=0)
测试2 开局 玩家 100001（塔主）：生命=0/80 死亡=True
测试2 开局 玩家 100002：生命=64/80 死亡=False
测试2 开局 爬塔人数=1
测试2 开局 怪物 CalcifiedCultist:MONSTER.CALCIFIED_CULTIST：生命=41/41 格挡=0
测试2 开局 怪物 Seapunk:MONSTER.SEAPUNK：生命=45/45 格挡=0
```

### 参数差异原文（两端分别列出）

A

```text
[01:01:38.202] INFO 测试2 参数 MultiplayerScalingModel.ModifyBlockMultiplicative(target=Creature:Creature PlayerId 100002, block=5, props=Move, cardSource=DefendIronclad:CARD.DEFEND_IRONCLAD, cardPlay=null)
[01:01:38.587] INFO 测试2 参数 MultiplayerScalingModel.ModifyBlockMultiplicative(target=Creature:Creature PlayerId 100002, block=5, props=Move, cardSource=DefendIronclad:CARD.DEFEND_IRONCLAD, cardPlay=null)
[01:01:38.589] INFO 测试2 参数 MultiplayerScalingModel.ModifyBlockMultiplicative(target=Creature:Creature PlayerId 100002, block=5, props=Move, cardSource=DefendIronclad:CARD.DEFEND_IRONCLAD, cardPlay=null)
[01:01:38.591] INFO 测试2 参数 MultiplayerScalingModel.ModifyBlockMultiplicative(target=Creature:Creature PlayerId 100002, block=5, props=Move, cardSource=DefendIronclad:CARD.DEFEND_IRONCLAD, cardPlay=CardPlay)
[01:01:54.864] INFO 测试2 参数 MultiplayerScalingModel.ModifyBlockMultiplicative(target=Creature:Creature PlayerId 100002, block=5, props=Move, cardSource=DefendIronclad:CARD.DEFEND_IRONCLAD, cardPlay=null)
```

B

```text
[01:00:36.310] INFO 测试2 参数 MultiplayerScalingModel.ModifyBlockMultiplicative(target=Creature:Creature PlayerId 100002, block=5, props=Move, cardSource=DefendIronclad:CARD.DEFEND_IRONCLAD, cardPlay=null)
[01:00:36.312] INFO 测试2 参数 MultiplayerScalingModel.ModifyBlockMultiplicative(target=Creature:Creature PlayerId 100002, block=5, props=Move, cardSource=DefendIronclad:CARD.DEFEND_IRONCLAD, cardPlay=null)
[01:00:36.319] INFO 测试2 参数 MultiplayerScalingModel.ModifyBlockMultiplicative(target=Creature:Creature PlayerId 100002, block=5, props=Move, cardSource=DefendIronclad:CARD.DEFEND_IRONCLAD, cardPlay=null)
[01:00:36.330] INFO 测试2 参数 MultiplayerScalingModel.ModifyBlockMultiplicative(target=Creature:Creature PlayerId 100002, block=5, props=Move, cardSource=DefendIronclad:CARD.DEFEND_IRONCLAD, cardPlay=null)
[01:00:36.397] INFO 测试2 参数 MultiplayerScalingModel.ModifyBlockMultiplicative(target=Creature:Creature PlayerId 100002, block=5, props=Move, cardSource=DefendIronclad:CARD.DEFEND_IRONCLAD, cardPlay=null)
```

### 两端共同启动 ERROR（原文，game-A.log:69，game-B.log:69）

```text
[ERROR] Attempting to register type TowerMasterSummonNetAction in assembly TowerMaster.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null, but it is not associated with any mod! You may need to call ModManager.AssociateAssemblyWithMod to manually register the assembly. Type sorting may break because of this, causing errors in multiplayer.
   at MegaCrit.Sts2.Core.Multiplayer.Serialization.ContentSorter`1.Sort(IEnumerable`1 types, Func`2 getId, Boolean affectsGameplayAtEnd)
   at MegaCrit.Sts2.Core.Multiplayer.Serialization.NetTypeCache`1..ctor(List`1 types)
   at MegaCrit.Sts2.Core.GameActions.Multiplayer.ActionTypes.Initialize()
   at MegaCrit.Sts2.Core.Helpers.OneTimeInitialization.ExecuteEssential()
   at MegaCrit.Sts2.Core.Nodes.NGame.GameStartup()
   at System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[TStateMachine](TStateMachine& stateMachine)
```

其他游戏提示：存在资源未缓存、PacketWriter 扩容、low_health_loop 动画缺失以及退出时 RID/shader/资源泄漏 ERROR。来源未定位，未修改任何代码。

### 胜负原文

A

```text
[INFO] CHARACTER.IRONCLAD has won against encounter ENCOUNTER.CULTISTS_NORMAL. That's 4 wins
[INFO] CHARACTER.IRONCLAD has won against encounter ENCOUNTER.CULTISTS_NORMAL. That's 5 wins
[INFO] CHARACTER.IRONCLAD has lost to encounter ENCOUNTER.CULTISTS_NORMAL. That's 3 losses
```

B

```text
[INFO] CHARACTER.IRONCLAD has won against encounter ENCOUNTER.CULTISTS_NORMAL. That's 4 wins
[INFO] CHARACTER.IRONCLAD has won against encounter ENCOUNTER.CULTISTS_NORMAL. That's 5 wins
[INFO] CHARACTER.IRONCLAD has lost to encounter ENCOUNTER.CULTISTS_NORMAL. That's 1 losses
```

## 全部读玩家人数方法（完整清单）

两端列表一致；★ 为已改写，未带 ★ 为未改写。以下为 A 的完整 122 条，保留签名和读取处数。

```text
测试2    1 处 Void MegaCrit.Sts2.Core.Saves.Managers.ProgressSaveManager.UpdateWithRunData(SerializableRun serializableRun, Boolean victory)
测试2    1 处 Void MegaCrit.Sts2.Core.Runs.RunManager.GenerateRooms()
测试2    1 处 Boolean MegaCrit.Sts2.Core.Runs.RunManager.TryGetRoomTypeForTutorial(MapPointType pointType, RoomType& roomType)
测试2    1 处 Void MegaCrit.Sts2.Core.Runs.RunManager.UpdateRichPresence()
测试2    1 处 Boolean MegaCrit.Sts2.Core.Runs.RunState.get_IsGameOver()
测试2    1 处 static Int32 MegaCrit.Sts2.Core.Runs.ScoreUtility.CalculateScore(IRunState runState, Boolean won)
测试2    1 处 static Int32 MegaCrit.Sts2.Core.Runs.ScoreUtility.CalculateScore(SerializableRun run, Boolean won)
测试2    1 处 static List<Badge> MegaCrit.Sts2.Core.Runs.ScoreUtility.GetBadges(SerializableRun run, UInt64 playerId, Boolean won)
测试2    2 处 static Void MegaCrit.Sts2.Core.Runs.Metrics.MetricUtilities.UploadRunMetricsInternal(SerializableRun run, Boolean isVictory, UInt64 localPlayerId)
测试2    1 处 Void MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.ClientLoadJoinResponseMessage.Serialize(PacketWriter writer)
测试2    1 处 Boolean MegaCrit.Sts2.Core.Multiplayer.Game.ActChangeSynchronizer.IsWaitingForOtherPlayers()
测试2    1 处 Void MegaCrit.Sts2.Core.Multiplayer.Game.ActChangeSynchronizer.MoveToNextAct()
测试2    1 处 ctor MegaCrit.Sts2.Core.Multiplayer.Game.ActChangeSynchronizer(RunState runState)
测试2    1 处 Void MegaCrit.Sts2.Core.Multiplayer.Game.EventSynchronizer.BeginEvent(EventModel canonicalEvent, Boolean isPrefinished, Action<EventModel> debugOnStart)
测试2    1 处 Void MegaCrit.Sts2.Core.Multiplayer.Game.MapSelectionSynchronizer.OnLocationChanged(MapLocation location)
测试2    1 处 ctor MegaCrit.Sts2.Core.Multiplayer.Game.RewardsSetSynchronizer(RunLocationTargetedMessageBuffer messageBuffer, INetGameService netService, IPlayerCollection playerCollection, UInt64 localPlayerId)
测试2    1 处 Void MegaCrit.Sts2.Core.Multiplayer.Game.TreasureRoomRelicSynchronizer.BeginRelicPicking()
测试2    1 处 Void MegaCrit.Sts2.Core.Multiplayer.Game.TreasureRoomRelicSynchronizer.OnPicked(Player player, Nullable<Int32> index)
测试2    1 处 RelicModel MegaCrit.Sts2.Core.Multiplayer.Game.TreasureRoomRelicSynchronizer.TryGetRelicForTutorial(Player player)
测试2    1 处 Int32 MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.LoadRunLobby.get_PlayerCount()
测试2    2 处 Boolean MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.LoadRunLobby.IsAboutToBeginGame()
测试2    1 处 Void MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.LoadRunLobby.RemoveConnectingPlayer(UInt64 playerId)
测试2    2 处 Void MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby.HandleClientLobbyJoinRequestMessage(ClientLobbyJoinRequestMessage message, UInt64 senderId)
测试2    1 处 Void MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby.BeginRunLocally(String seed, List<ModifierModel> modifiers)
测试2    1 处 Void MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby.UpdatePreferredAscension()
测试2    2 处 Boolean MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby.IsAboutToBeginGame()
测试2    1 处 Void MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby.OnConnectedToClientAsHost(UInt64 playerId)
测试2    1 处 Void MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.StartRunLobby.RemoveConnectingPlayer(UInt64 playerId)
测试2    1 处 LocString MegaCrit.Sts2.Core.MonsterMoves.Intents.AbstractIntent.GetIntentDescription(IEnumerable<Creature> targets, Creature owner)
测试2    1 处 Boolean MegaCrit.Sts2.Core.Models.PotionModel.CanThrowAtAlly()
测试2 ★ 1 处 Decimal MegaCrit.Sts2.Core.Models.PowerModel.GetScaledAmountForMultiplayer(ICombatState combatState, Creature applier, Decimal amount, Creature target, CardModel cardSource)
测试2 ★ 2 处 IEnumerable<IHoverTip> MegaCrit.Sts2.Core.Models.PowerModel.get_HoverTips()
测试2    1 处 static Boolean MegaCrit.Sts2.Core.Models.RelicModel.IsBeforeAct3TreasureChest(IRunState runState)
测试2 ★ 1 处 Decimal MegaCrit.Sts2.Core.Models.Singleton.MultiplayerScalingModel.ModifyBlockMultiplicative(Creature target, Decimal block, ValueProp props, CardModel cardSource, CardPlay cardPlay)
测试2    1 处 Boolean MegaCrit.Sts2.Core.Models.Relics.MassiveScroll.IsAllowed(IRunState runState)
测试2    1 处 Boolean MegaCrit.Sts2.Core.Models.Relics.SilverCrucible.IsAllowed(IRunState runState)
测试2    1 处 Boolean MegaCrit.Sts2.Core.Models.Relics.WingedBoots.IsAllowed(IRunState runState)
测试2 ★ 1 处 Decimal MegaCrit.Sts2.Core.Models.Powers.ArtifactPower.GetScaledAmountForMultiplayer(ICombatState combatState, Creature applier, Decimal amount, Creature target, CardModel cardSource)
测试2 ★ 1 处 Decimal MegaCrit.Sts2.Core.Models.Powers.BufferPower.GetScaledAmountForMultiplayer(ICombatState combatState, Creature applier, Decimal amount, Creature target, CardModel cardSource)
测试2 ★ 1 处 Task MegaCrit.Sts2.Core.Models.Powers.PlatingPower.AfterApplied(Creature applier, CardModel cardSource)
测试2 ★ 1 处 Decimal MegaCrit.Sts2.Core.Models.Powers.PlatingPower.GetScaledAmountForMultiplayer(ICombatState combatState, Creature applier, Decimal amount, Creature target, CardModel cardSource)
测试2 ★ 1 处 Decimal MegaCrit.Sts2.Core.Models.Powers.SkittishPower.GetScaledAmountForMultiplayer(ICombatState combatState, Creature applier, Decimal amount, Creature target, CardModel cardSource)
测试2 ★ 1 处 Decimal MegaCrit.Sts2.Core.Models.Powers.SlipperyPower.GetScaledAmountForMultiplayer(ICombatState combatState, Creature applier, Decimal amount, Creature target, CardModel cardSource)
测试2    1 处 ActMap MegaCrit.Sts2.Core.Models.Modifiers.BigGameHunter.ModifyGeneratedMap(IRunState runState, ActMap map, Int32 actIndex)
测试2    1 处 IReadOnlyList<EventOption> MegaCrit.Sts2.Core.Models.Events.BattlewornDummy.GenerateInitialOptions()
测试2    1 处 Boolean MegaCrit.Sts2.Core.Models.Events.DenseVegetation.IsAllowed(IRunState runState)
测试2    1 处 Boolean MegaCrit.Sts2.Core.Models.Events.FakeMerchant.IsAllowed(IRunState runState)
测试2    1 处 Boolean MegaCrit.Sts2.Core.Models.Events.JungleMazeAdventure.IsAllowed(IRunState runState)
测试2    1 处 Boolean MegaCrit.Sts2.Core.Models.Events.WarHistorianRepy.get_ShouldGetSecondReward()
测试2    1 处 ctor MegaCrit.Sts2.Core.Map.GoldenPathActMap(IRunState runState)
测试2    1 处 ctor MegaCrit.Sts2.Core.Map.SpoilsActMap(IRunState runState, MapPointTypeCounts mapPointTypeCountsOverride)
测试2    1 处 static StandardActMap MegaCrit.Sts2.Core.Map.StandardActMap.CreateFor(RunState runState, Boolean replaceTreasureWithElites)
测试2    1 处 static IEnumerable<CardModel> MegaCrit.Sts2.Core.Factories.CardFactory.FilterForPlayerCount(IRunState runState, IEnumerable<CardModel> options)
测试2    1 处 Void MegaCrit.Sts2.Core.Events.EventOption.AddLocVars(EventModel eventModel)
测试2    1 处 static List<RestSiteOption> MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption.Generate(Player player)
测试2    1 处 CmdResult MegaCrit.Sts2.Core.DevConsole.ConsoleCommands.ActConsoleCmd.Process(Player issuingPlayer, String[] args)
测试2    1 处 Void MegaCrit.Sts2.Core.Combat.CombatManager.SetReadyToBeginEnemyTurn(Player player, Func<Task> actionDuringEnemyTurn)
测试2    1 处 Boolean MegaCrit.Sts2.Core.Combat.CombatManager.AllPlayersReadyToEndTurn(CombatTurnState turnState)
测试2 ★ 1 处 Creature MegaCrit.Sts2.Core.Combat.CombatState.CreateCreature(MonsterModel monster, CombatSide side, String slot)
测试2    2 处 Int32 MegaCrit.Sts2.Core.Audio.Debug.NDebugAudioManager.Play(String streamName, Single volume, PitchVariance variance)
测试2    1 处 Void MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NHandImageCollection.Initialize(IRunState runState)
测试2    1 处 Void MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NHandImageCollection._Input(InputEvent inputEvent)
测试2    1 处 Void MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NHandImageCollection.ProcessGuiFocus(Control focusedControl)
测试2    1 处 Void MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NRunHistory.DisplayRun(RunHistory history)
测试2    1 处 Void MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NRunHistory.SelectPlayer(NRunHistoryPlayerIcon playerIcon)
测试2    1 处 Void MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NRunHistory.LoadGameModeDetails(RunHistory history)
测试2    1 处 Void MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NRunHistoryPlayerIcon.LoadRun(RunHistoryPlayer player, RunHistory history)
测试2    3 处 Void MegaCrit.Sts2.Core.Nodes.Screens.Map.MapSplitVoteAnimation.TickSplitVoteAnimation(Single value)
测试2    1 处 Void MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapMarker.Initialize(Player player)
测试2    1 处 Void MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapScreen.OnMapPointSelectedLocally(NMapPoint point)
测试2    1 处 Void MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapScreen.OnPlayerVoteChangedInternal(Player player, Nullable<MapCoord> oldCoord, Nullable<MapCoord> newCoord)
测试2    1 处 Void MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NContinueRunInfo.ShowInfo(SerializableRun save)
测试2    1 处 Void MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunScreen.SetupLobbyParams(StartRunLobby lobby)
测试2    1 处 Void MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunScreen.UpdateRichPresence()
测试2    1 处 Void MegaCrit.Sts2.Core.Nodes.Screens.CustomRun.NCustomRunScreen.UpdateRichPresence()
测试2    1 处 Void MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NCharacterSelectButton.RefreshState()
测试2    2 处 Void MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NCharacterSelectButton.RefreshOutline()
测试2    1 处 Void MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NCharacterSelectButton.RefreshPlayerIcons()
测试2    1 处 Void MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NCharacterSelectScreen.UpdateRichPresence()
测试2    1 处 Void MegaCrit.Sts2.Core.Nodes.Rooms.NEventRoom.SetDescription(LocString description)
测试2    2 处 Void MegaCrit.Sts2.Core.Nodes.Rooms.NMerchantRoom.AfterRoomIsLoaded()
测试2    1 处 Void MegaCrit.Sts2.Core.Nodes.Rooms.NRestSiteRoom._Ready()
测试2    1 处 Void MegaCrit.Sts2.Core.Nodes.Rooms.NRestSiteRoom.OnPlayerChangedHoveredRestSiteOption(UInt64 playerId)
测试2    1 处 Void MegaCrit.Sts2.Core.Nodes.Rooms.NRestSiteRoom.OnBeforePlayerSelectedRestSiteOption(RestSiteOption option, UInt64 playerId)
测试2    1 处 Void MegaCrit.Sts2.Core.Nodes.Rooms.NRestSiteRoom.OnAfterPlayerSelectedRestSiteOption(RestSiteOption option, Boolean success, UInt64 playerId)
测试2    1 处 Void MegaCrit.Sts2.Core.Nodes.Rooms.NTreasureRoom._Ready()
测试2    1 处 Void MegaCrit.Sts2.Core.Nodes.Rooms.NTreasureRoom.OnProceedButtonPressed(NButton _)
测试2    1 处 Void MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerStateContainer.Initialize(RunState runState)
测试2    1 处 Void MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteLoadLobbyPlayerContainer.Initialize(LoadRunLobby runLobby, Boolean displayLocalPlayer)
测试2    1 处 Void MegaCrit.Sts2.Core.Nodes.Multiplayer.NRemoteLobbyPlayerContainer.RefreshSoloLabelVisibility()
测试2    3 处 Void MegaCrit.Sts2.Core.Nodes.Events.EventSplitVoteAnimation.TickSplitVoteAnimation(Single value)
测试2    1 处 Void MegaCrit.Sts2.Core.Nodes.Events.NEventLayout.AddOptions(IEnumerable<EventOption> options)
测试2    1 处 Void MegaCrit.Sts2.Core.Nodes.Events.NEventOptionButton.OnRelease()
测试2    2 处 Void MegaCrit.Sts2.Core.Nodes.Events.Custom.NFakeMerchant.AfterRoomIsLoaded()
测试2    2 处 Void MegaCrit.Sts2.Core.Nodes.Debug.Multiplayer.NMultiplayerTest.WriteReplayAsSave(String path)
测试2    1 处 Void MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer.RefreshPlayerVotes(Boolean animate)
测试2    1 处 Void MegaCrit.Sts2.Core.Nodes.CommonUi.NTopBar.Initialize(IRunState runState)
测试2    1 处 Void MegaCrit.Sts2.Core.Nodes.Combat.NCreature._Ready()
测试2    1 处 Boolean MegaCrit.Sts2.Core.Runs.RunState+<IterateHookListeners>d__118.MoveNext()
测试2    1 处 Void MegaCrit.Sts2.Core.Rooms.CombatRoom+<EnterInternal>d__40.MoveNext()
测试2    2 处 Void MegaCrit.Sts2.Core.Multiplayer.CombatStateSynchronizer+<WaitForSync>d__18.MoveNext()
测试2 ★ 1 处 Void MegaCrit.Sts2.Core.Models.Monsters.KnowledgeDemon+<PonderMove>d__42.MoveNext()
测试2 ★ 1 处 Void MegaCrit.Sts2.Core.Models.Monsters.TestSubject+<Revive>d__81.MoveNext()
测试2 ★ 1 处 Void MegaCrit.Sts2.Core.Models.Monsters.ToughEgg+<Hatch>d__36.MoveNext()
测试2 ★ 1 处 Void MegaCrit.Sts2.Core.Models.Monsters.WaterfallGiant+<SiphonMove>d__73.MoveNext()
测试2    1 处 Void MegaCrit.Sts2.Core.Models.Events.FakeMerchant+<FoulPotionThrown>d__23.MoveNext()
测试2    1 处 Void MegaCrit.Sts2.Core.Models.Events.WarHistorianRepy+<RemoveLanternKeysForInitialChoice>d__12.MoveNext()
测试2    2 处 Void MegaCrit.Sts2.Core.Debug.FileDropHandler+<OnRunHistoryDropped>d__1.MoveNext()
测试2    1 处 Void MegaCrit.Sts2.Core.Daily.DailyRunUtility+<UploadScore>d__0.MoveNext()
测试2    1 处 Void MegaCrit.Sts2.Core.Commands.CreatureCmd+<KillWithoutCheckingWinCondition>d__15.MoveNext()
测试2    1 处 Void MegaCrit.Sts2.Core.Commands.PowerCmd+<Apply>d__2.MoveNext()
测试2    1 处 Boolean MegaCrit.Sts2.Core.Combat.CombatState+<IterateHookListeners>d__69.MoveNext()
测试2    2 处 Void MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NHandImageCollection+<DoFight>d__20.MoveNext()
测试2    2 处 Void MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NTreasureRoomRelicCollection+<AnimateRelicAwards>d__31.MoveNext()
测试2    1 处 Void MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen.NGameOverScreen+<AnimateScoreLines>d__49.MoveNext()
测试2    3 处 Void MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunLeaderboard+<LoadLeaderboard>d__35.MoveNext()
测试2    2 处 Void MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunLoadScreen+<ShouldAllowRunToBegin>d__31.MoveNext()
测试2    1 处 Void MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunScreen+<StartNewSingleplayerRun>d__53.MoveNext()
测试2    2 处 Void MegaCrit.Sts2.Core.Nodes.Screens.CustomRun.NCustomRunLoadScreen+<ShouldAllowRunToBegin>d__26.MoveNext()
测试2    2 处 Void MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NMultiplayerLoadGameScreen+<ShouldAllowRunToBegin>d__33.MoveNext()
测试2    1 处 Void MegaCrit.Sts2.Core.Nodes.Rooms.NEventRoom+<BeforeOptionChosen>d__31.MoveNext()
测试2    1 处 Void MegaCrit.Sts2.Core.Nodes.Rooms.NTreasureRoom+<OpenChest>d__26.MoveNext()
```

原始四份日志已保存在本机 outputs/TowerMaster-test2-A/B.log、game-test2-A/B.log，不提交原始日志全文或反编译代码。运行产生的未跟踪 TowerMaster-A/B.plans.json 不纳入提交。
