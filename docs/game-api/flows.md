# 游戏流程与同步插入点

依据：游戏 v0.111.0 的本机反编译和实际程序集元数据。下列路径均相对 `decompiled/sts2/`，行号不是 Git 内可见源码；云端可用本目录签名表核对形状。流程使用自己的话转述，不复制方法体。建议挂点是开发建议，几十秒等待、断线、恢复、重放均**尚未实测**。

## 1. 进房与未知房间

| 阶段 | 方法签名/依据 | 时序与等待 |
| --- | --- | --- |
| 收地图票 | `void MapSelectionSynchronizer.PlayerVotedForMapCoord(Player player, MapLocation source, MapVote? destination)`；MegaCrit.Sts2.Core.Multiplayer.Game/MapSelectionSynchronizer.cs:48–76 | 所有玩家槽位都收到当前地图代次的票，房主才决定；错误地点/旧代次不接受 |
| 房主决定移动 | `void MapSelectionSynchronizer.MoveToMapCoord()`；同文件:84–94 | 从票中用地图选择 RNG 抽一张，构建 `MoveToMapCoordAction(Player player, MapCoord coord)`，调用 `RequestEnqueue(GameAction action)`；此方法本身不是 async |
| 执行移动 | `protected override Task MoveToMapCoordAction.ExecuteAction()`；MegaCrit.Sts2.Core.GameActions/MoveToMapCoordAction.cs:29–42；`Task NMapScreen.TravelToMapCoord(MapCoord coord)`，MegaCrit.Sts2.Core.Nodes.Screens.Map/NMapScreen.cs:730–789 | 正常界面 await TravelToMapCoord：分票动画、路径动画、await 淡出，再 await RunManager.EnterMapCoord；淡入由 RunSafely 启动。TestMode 才直接 await EnterMapCoord；队列执行器等待整个动作 |
| 坐标变房 | `Task RunManager.EnterMapCoord(MapCoord coord)`、`Task EnterMapCoordInternal(MapCoord coord, AbstractRoom? preFinishedRoom, bool saveGame)`；MegaCrit.Sts2.Core.Runs/RunManager.cs:652、682 | AddVisitedMapCoord 防重复，读取地图节点 PointType，转到 EnterMapPointInternal |
| 进房主链 | `Task RunManager.EnterMapPointInternal(int actFloor, MapPointType pointType, AbstractRoom? preFinishedRoom, bool saveGame)`；同文件:692–754 | async：await ExitCurrentRooms → StartSync → 清界面 → await WaitForSync → await SaveRun → RollRoomTypeFor → CreateRoom → Pause 执行器 → 记历史 → await EnterRoom；最后更新地图位置 |
| 构建战斗 | `AbstractRoom CreateRoom(RoomType roomType, MapPointType mapPointType=Unassigned, AbstractModel? model=null)`；同文件:757–781 | 768行取 Act.PullNextEncounter(roomType).ToMutable；构造 CombatRoom 不等于怪物已生成 |
| 进入战斗房 | `Task CombatRoom.EnterInternal(IRunState? runState, bool isRestoringRoomStackBase)`；MegaCrit.Sts2.Core.Rooms/CombatRoom.cs:94–113 | 正常战斗 await StartCombat；预完成房走另一条路径 |
| 生成与视觉 | `Task CombatRoom.StartCombat(IRunState? runState)`；同文件:169–200 | 173行 GenerateMonstersWithSlots；await LoadRoomCombatAssets；构建生物/设置战斗和房间视觉；await AfterRoomEntered。CombatManager.AfterCombatRoomLoaded 进入异步回合循环 |

`EncounterModel.GenerateMonstersWithSlots(IRunState runState)` 在 MegaCrit.Sts2.Core.Models/EncounterModel.cs:198–215 初始化遭遇 RNG，再调用 `protected abstract IReadOnlyList<(MonsterModel,string?)> GenerateMonsters()`，存下结果。更换遭遇应该在 CreateRoom/PullNextEncounter 返回阶段完成；战斗开始后再换规范模型不等于重建已生成的生物。

### 房主延迟几十秒能否实现

可以设计为房主收到全票后暂不调用 RequestEnqueue；因为尚未发出移动动作，客户端仍停留地图/旧房（具体等待提示、旅行动画由 UI 决定，未测）。不能把 void MoveToMapCoord 的普通 Harmony postfix 写成 async 就以为原方法会等待；要拦截原移动调用并保存地点/票代次，异步等到完成后只入队一次。等待期间冻结/管理改票和重复触发，离局/断线要取消；不要 Thread.Sleep 阻塞 Godot 主线程。

更可靠的全客户端屏障：房主先广播“选择阶段开始”，所有端显示本地 UI；房主收齐期望玩家的 ready/选择消息，广播完成，再入队移动。也可在移动前插入同一拥有者队列中的自定义等待 GameAction，其 ExecuteAction 在各端 await 同一个阶段完成条件；必须让解锁消息走独立消息处理，不能把解锁动作放进已阻塞的同一队列。只在房主本地 Pause 不会自动广播 pause。

### “?” 的类型与遭遇预知

RunManager.cs:723–733 在**进入坐标并同步之后**决定类型；`RoomType RollRoomTypeFor(MapPointType pointType, IEnumerable<RoomType> blacklist)`（784–802）对 Unknown 调 `UnknownMapPointOdds.Roll(IEnumerable<RoomType> blacklist, IRunState runState)`。赔率实现见 MegaCrit.Sts2.Core.Odds/UnknownMapPointOdds.cs:97 起：教程、黑名单、Hook、历史赔率和 RNG 都可能影响结果，默认并不只是战斗/事件/商店，含宝箱（精英赔率默认负值禁用，但可修改）。

已知地图节点可读 State.Map.GetPoint(coord).PointType；Monster/Elite/Boss 是可提前知道的类别，Unknown 只能知道它未知。实际规范遭遇在 CreateRoom 执行时由 PullNextEncounter 消费进度。**不要提前调用 Roll/Pull 当预览**：会改变赔率、随机流或遭遇列表游标。若要设计可提前知晓的结果，需要所有端一致地暂存真实解析结果，或另做不消费状态的快照/peek（本轮未找到公开 PeekNextEncounter API，查过 ActModel 和 RunManager）。

## 2. 回合、队列暂停与全员等待

主要类：CombatManager、CombatTurnState、PlayerCombatState、ActionExecutor、ActionQueueSet、ActionQueueSynchronizer、HookPlayerChoiceContext。

### 开始回合的实际顺序

`private Task CombatManager.StartTurn(CombatTurnState turnState, Func<Task>? actionDuringEnemyTurn=null)` 为 async；MegaCrit.Sts2.Core.Combat/CombatManager.cs:460–623。

1. 校验战斗/取消令牌，设置玩家 Phase=None；确定本侧生物和额外回合玩家。
2. 调各生物 BeforeTurnStart，await BeforeSideTurnStart；玩家侧设 Start，重置两种 ready 集合及信号。
3. 更新怪物下一步意图；await 短等待、各生物 AfterTurnStart、AfterBlockCleared。
4. 为玩家创建 HookPlayerChoiceContext，启动 `Task SetupPlayerTurn(...)`，await WaitForPauseOrCompletionWithoutAssigningTask；这里允许选择逻辑挂起，不等于保证每个抽牌 Task 已最终完成。
5. await AfterSideTurnStart、球队列 AfterTurnStart，生成回合校验；死亡/不参与本回合玩家自动 SetReadyToEndTurn。
6. 对存活玩家执行并等待 `Task RunAutoPrePlayPhase(...)`：它先 await setupPlayerTurnTask，设 AutoPrePlay，检查空手、await AfterAutoPrePlayPhaseEntered，再设 Play。
7. await CheckWinCondition；仍在战斗才 ActionExecutor.Unpause，SetCombatState(PlayPhase)，发 TurnStarted。

能量与抽牌：`Task SetupPlayerTurn(CombatTurnState turnState, Player player, HookPlayerChoiceContext playerChoiceContext)`（同文件:634–680）跳过死者；Hook 决定 ResetEnergy 或 AddMaxEnergyToCurrent；播放能量声音，await AfterEnergyReset / BeforeHandDraw / AfterModifyingHandDraw；第一回合处理底牌和先天牌；await `CardPileCmd.Draw(PlayerChoiceContext choiceContext, decimal count, Player player, bool fromHandDraw=false)`（精确参数形状见 Commands 表）；最后 await AfterPlayerTurnStart。

### 抽牌后、出牌前插入等待

目标是“所有玩家抽完后统一停”，优先在 StartTurn 的 RunAutoPrePlayPhase 循环之后、603–604恢复队列之前插入 await 屏障。此时所有存活玩家 setup 已被等待，队列还没打开 PlayPhase。若只挂每个 SetupPlayerTurn/AfterPlayerTurnStart，HookPlayerChoiceContext 的 pause-or-completion 可能让整体启动继续，需要明确屏障是 per-player 还是 per-turn。

候选现成 await Hook：`Hook.AfterAutoPrePlayPhaseEntered(...)`（630行），但为每位玩家分别调用，需要统一阶段编号及参与者收集，不能假设它只运行一次。普通 postfix 返回 Task 不会自动延长原 async Task，必须真正包装/替换返回 Task 或使用游戏实际 await 的 Hook。各端采用同阶段条件，不能只房主阻塞：否则客户端可能提前能点牌并堆动作。具体 UI 点击禁止和动画表现未实测。

### 暂停机制和动作类型

`void ActionExecutor.Pause()`、`void Unpause()`（MegaCrit.Sts2.Core.GameActions/ActionExecutor.cs:66–83）改本地 `_isPaused`；`Task ExecuteActions()`（110起）选就绪动作、await WaitForUnpause，再执行；WaitForUnpause（203起）逐帧等待而不阻塞主线程。Pause **不取消已运行动作，也不保证立刻停止它的 await 后续**。`Task FinishedExecutingActions()` 等本轮执行器工作结束，不能在已暂停且存在待执行动作时盲等，避免死锁。

玩家队列暂停为另一个层次：ActionQueueSet.PauseAllPlayerQueues/UnpauseAllPlayerQueues（266、302），只挡 CombatPlayPhaseOnly 头动作；Executor 总暂停则挡全部将开始的动作。ActionQueueSet.GetReadyAction（149–220）检查阶段，**只看每个玩家的队头**。

| GameActionType | 就绪规则 | 注意 |
| --- | --- | --- |
| Combat | 只能战斗中候选；玩家队列的 play 暂停本身不挡它 | 回合末取消玩家驱动战斗动作仍可能取消；不是任意时刻都能执行 |
| CombatPlayPhaseOnly | 战斗中且该玩家队列未暂停 | 常规出牌窗口；敌回合 RequestEnqueue 会延后 |
| NonCombat | 不在战斗中的候选 | 放在战斗中的玩家队头会等待并堵同玩家后续动作 |
| Any | 两种战斗状态都可候选，玩家 play 暂停不挡 | 仍受 Executor 总暂停、队头、玩家选择等待及取消条件约束；不会自动保证副作用安全 |

依据 MegaCrit.Sts2.Core.Entities.Multiplayer/GameActionType.cs 的枚举、ActionQueueSet.cs:113–130/170–200，以及 ActionQueueSynchronizer.cs:RequestEnqueue。None 不是设计动作阶段；不要使用。

### 结束玩家回合、敌回合、下回合

`void SetReadyToEndTurn(Player player, bool canBackOut, Func<Task>? actionDuringEnemyTurn=null)`（CombatManager.cs:683）收集结束状态；`bool AllPlayersReadyToEndTurn(CombatTurnState turnState)`（788）检查全员 ready（额外回合分支也参与判断）。死亡玩家在574–579已自动 ready，并非队列完全移除该玩家。

`Task<Func<Task>?> AwaitTurnEndAndSwitchSides(CombatTurnState turnState)`（407–456）先 await EndTurnSignalSource，必要时 await RunningAction.CompletionTask，再 await AfterAllPlayersReadyToEndTurn；之后 await BeginEnemyTurnSignalSource，并 await AfterAllPlayersReadyToBeginEnemyTurn。`Task AfterAllPlayersReadyToEndTurn(...)`（1097起）设置 EndTurnPhaseOne，等待队列及处理弃牌/回合末 Hook；`Task AfterAllPlayersReadyToBeginEnemyTurn(...)`（1349起）设 NotPlayPhase、处理阶段二并切侧。`Task ExecuteEnemyTurn(...)`（1062）执行敌方动作；EndEnemyTurn/EndEnemyTurnInternal（806、1338）处理敌方结束，再循环 StartTurn。

现成屏障：ready 集合 + TaskCompletionSource 信号是回合流程等待；`CombatStateSynchronizer.StartSync()` 与 `Task WaitForSync()`（MegaCrit.Sts2.Core.Multiplayer/CombatStateSynchronizer.cs:98–139）则为进房状态同步，不是通用“投票已齐”。它收 SyncPlayerDataMessage、房主 SyncRngMessage，CheckSyncCompleted（178起）处理完成/断线；客户端用房主 RNG 状态同步，不能复用它传自定义召唤清单或任意 UI ready 而不改协议。

## 3. 战斗状态命令

这些命令改本地模型并调用 Hook/视觉，**自身不是广播命令**。联机应在所有端相同的已排序动作或同步 Hook 中执行并 await；独自在塔主 UI 回调里调用会不同步。没找到要求 CurrentlyRunningAction 非空的统一硬校验，不等于可以任意时机改状态。PlayerChoiceContext 用真实动作/Hook 上下文，具体构造和 GenericHookGameAction 见签名表；不要用 null 假装上下文。

| 操作 | 签名、参数和依据 | 效果 |
| --- | --- | --- |
| 怪物加格挡 | `Task<decimal> CreatureCmd.GainBlock(Creature creature, decimal amount, ValueProp props, CardPlay? cardPlay, bool fast=false)`；MegaCrit.Sts2.Core.Commands/CreatureCmd.cs:483–515 | target 必须有效存活；无 applier 参数；cardPlay 可 null；props 选择会影响 Hook 修正（ValueProp 全枚举见补充的 ValueProps 表），不要省略它。触发 Before/Modify/AfterBlock Hook、格挡音效/VFX、历史；fast 改等待长度而非完全静音 |
| 怪物回血 | `Task CreatureCmd.Heal(Creature creature, decimal amount, bool playAnim=true)`；同文件:532起 | creature 非空；无 applier/cardSource；受生命上限/战斗结束规则；playAnim=false 仅跳动画分支，治疗声音仍在542行，不是无视觉/无声音保证 |
| 怪物力量 | `Task<T?> PowerCmd.Apply<T>(PlayerChoiceContext choiceContext, Creature target, decimal amount, Creature? applier, CardModel? cardSource, bool silent=false) where T:PowerModel`；MegaCrit.Sts2.Core.Commands/PowerCmd.cs:37–58 | T=StrengthPower；泛型方法从 ModelDb 取规范模板再 ToMutable/叠加；applier/cardSource 都允许 null |
| 玩家虚弱/易伤/脆弱 | 同 Apply，T 分别 WeakPower/VulnerablePower/FrailPower | target=player.Creature；能力接收、神器等 Hook 会介入，不要直接改 Amount 绕过防御。玩家 Debuff 设置 SkipNextDurationTick（PowerCmd.cs:106），持续时间因此不能只按轮数表面理解 |
| 抽牌堆塞眩晕 | `Task CardPileCmd.AddToCombatAndPreview<T>(Creature target, PileType pileType, int count, Player? creator, CardPilePosition position=Bottom) where T:CardModel`；MegaCrit.Sts2.Core.Commands/CardPileCmd.cs:1062–1090 | T=Dazed，pileType=Draw；从 target.Player/PetOwner 找玩家，死者跳过；CombatState.CreateCard<T>(player) 创建归属正确的可变牌，再 AddGeneratedCardToCombat；creator 可 null，不是牌的归属者。默认底部，可选 Random 等位置（看枚举）；预览只在该玩家本地显示 |

Power 的非泛型 `Task Apply(PlayerChoiceContext choiceContext, PowerModel power, Creature target, decimal amount, Creature? applier, CardModel? cardSource, bool silent=false)`（61–119）要求可变 power；会查找叠层、修正 amount、触发 BeforeApplied/AfterApplied 和多种 Hook。ApplyInternal 驱动能力图标/闪烁等，silent 不应被理解为“关闭所有 Hook 和等待”；精确声音取决于具体能力/视觉订阅，通用 Apply 内没有统一 SfxCmd 调用，未找到所有五种能力的统一音效保证。

## 4. GameAction 从本地到全端

核心接口 `INetAction : IPacketSerializable`，`GameAction ToGameAction(Player player)`；`GameAction` 抽象 `ulong OwnerId`、`GameActionType ActionType`、`Task ExecuteAction()`、`INetAction ToNetAction()`。完整可见性、构造与其他成员见 GameActions 及 GameActions.Multiplayer 表。

1. 客户端 `ActionQueueSynchronizer.RequestEnqueue(GameAction action)` 将 ToNetAction 与当前地点装入 RequestEnqueueActionMessage 发房主。
2. 房主 HandleRequestEnqueueActionMessage 以 senderId 映射 Player，调用 ToGameAction；普通请求不能凭自己的序列化 payload 任意指定另一个拥有者。
3. 房主 EnqueueAction 广播 ActionEnqueuedMessage（playerId/location/action），并本地 EnqueueWithoutSynchronizing。
4. 客户端 HandleActionEnqueuedMessage 用 message.playerId 重建相同拥有者动作，入相同玩家队列。
5. 队列给动作全局递增 Id，每个玩家 FIFO；从**各玩家可执行队头**取 Id 最小者，并非把全体动作无条件按 Id 执行（被暂停或选择等待的队头可被另一玩家绕过）。
6. ActionExecutor await GameAction.Execute；GameAction 管理执行/暂停选择/完成信号。各端执行同样命令，生成校验。

依据：MegaCrit.Sts2.Core.GameActions.Multiplayer/ActionQueueSynchronizer.cs:RequestEnqueue/201–215/HandleRequestEnqueueActionMessage/HandleActionEnqueuedMessage/316–323；ActionQueueSet.cs:86–138/149–220；MegaCrit.Sts2.Core.GameActions/ActionExecutor.cs:110–180；GameAction.cs:65–115。地点消息经 RunLocationTargetedMessageBuffer 处理，进房阶段必须考虑旧地点消息不能立即应用。

### 死亡拥有者能否执行

NetActionToGameAction（316–323）只检查玩家是否存在，没有 IsDead 拦截；队列 Enqueue/GetReadyAction 也不统一检查 Creature.IsDead。因此已死塔主仍可以有非战斗/Any/Combat 动作。但死亡后通常已 ready/end-turn，该队列可能在“取消玩家驱动战斗动作”状态；自定义普通 GameAction 默认被 IsGameActionPlayerDriven（ActionQueueSet.cs:140–146）视为玩家驱动，Combat/CombatPlayPhaseOnly 可被回合末取消。NonCombat 在战斗中不能执行。

房主 RequestEnqueue 发送者/重建身份自然是塔主，所以以死塔主身份入队是可行的结构；如果要求敌方回合立即生效，需检查 RequestEnqueue 的 play-phase 延后条件和取消阶段。不能把当前测试1b的 NonCombat 动作原样搬到战斗内；选择 Any 或受控 Hook 类型，并确保目标玩家/生物是有效对象，不调用针对本地活玩家的出牌 UI。这里是源码可行性，未做已死塔主战斗命令实测。

全端等待推荐：同步自定义 GameAction 的 ExecuteAction await 一个有阶段Id/地点/取消策略的 ready 屏障；解锁由不依赖该动作队列的消息处理完成。超时不是玩家自动同意；房主需同步宣布超时策略。不要在每端各自 Task.Delay(30s) 后随机进入不同路径。

## 5. 随机数流与隔离

`RunRngSet` 由 StringSeed 计算稳定 Seed，枚举流名 snake_case 后 `new Rng(Seed,name)`；每流独立状态，能 ToSerializable/FromSave。依据 MegaCrit.Sts2.Core.Runs/RunRngSet.cs:21–43/55–102，MegaCrit.Sts2.Core.Entities.Rngs/RunRngType.cs；MegaCrit.Sts2.Core.Random/Rng.cs:19/35–36（带名字构造将名字确定性 hash 混入 seed）。

| RunRngType / 属性 | 名字 | 用途（按调用点归纳） |
| --- | --- | --- |
| UpFront | up_front | 幕遭遇/遗物袋等前置生成；RunManager.cs:396–399、584。地图另走 Act.CreateMap，不等于全部地图直接消费此流 |
| Shuffle | shuffle | 洗牌 |
| UnknownMapPoint | unknown_map_point | “?”房间赔率抽取 |
| CombatCardGeneration | combat_card_generation | 战斗生成随机牌 |
| CombatPotionGeneration | combat_potion_generation | 战斗生成药水 |
| CombatCardSelection | combat_card_selection | 战斗随机挑牌 |
| CombatEnergyCosts | combat_energy_costs | 随机能量费用 |
| CombatTargets | combat_targets | 随机战斗目标 |
| MonsterAi | monster_ai | 怪物随机行动/决策 |
| Niche | niche | 小范围特殊随机，不适合作为 mod 私有保留流 |
| CombatOrbs / CombatOrbGeneration | combat_orbs | 战斗球生成 |
| TreasureRoomRelics | treasure_room_relics | 宝箱遗物 |

上述是流的设计用途，所有调用点不是本表的穷举。地图选票另外由 MapSelectionSynchronizer 的 `new Rng(runState.Rng.Seed,"map_point_selection")`（39–45）隔离；共享事件有自己的 multiplayer option selection RNG；遭遇生成也有自己的局部 seed。**不要用原版 Niche 当新功能随机流**，它不是空白流。

调用点样例（均相对 decompiled/sts2）：Shuffle：MegaCrit.Sts2.Core.Commands/CardPileCmd.cs:945；CombatCardSelection：同文件:1010；CombatTargets：CardCmd.cs:60；CombatCardGeneration：MegaCrit.Sts2.Core.Models.Cards/Abundance.cs:31；CombatPotionGeneration：Alchemize.cs:24；CombatEnergyCosts：MegaCrit.Sts2.Core.Models.Enchantments/Slither.cs:61；MonsterAi：MegaCrit.Sts2.Core.Models/MonsterModel.cs:371；Niche：MegaCrit.Sts2.Core.Combat/CombatState.cs:139；CombatOrbGeneration：MegaCrit.Sts2.Core.Models.Cards/Chaos.cs:27；TreasureRoomRelics：MegaCrit.Sts2.Core.Runs/RunManager.cs:363。

最安全的 mod 方案：房主用独立、稳定定义的算法/seed（run seed + mod命名空间 + 阶段序号）生成结果，通过自定义同步动作广播最终选择清单；客户端验证并应用同一结果，不再额外抽。若各端必须独立抽，使用同版本游戏 `Rng(ulong seed,string name)` 和唯一名（如 towermaster.selection.v1），完全一致的规范候选排序与调用次数；不要 string.GetHashCode、系统时钟、UI触发次数、字典不稳定顺序。独立流需自己记录计数/状态用于读档重连和重放，游戏 RunRngSet 不自动保存 mod 外部实例。所有选择动作需有可重复验证的阶段序号；死亡玩家跳过分支不要造成各端不同抽数。

## 未确认范围

几十秒等待期间的网络断线/加载超时、UI动画、跨端特殊动作排序和读档恢复都未实测。源码没有公开的无副作用“?”预览/PeekNextEncounter 在所查位置；需要更深搜索或代码方自行设计，不能当作存在。所有等待建议都要求真实 await 链，不能依赖普通 Harmony async postfix 的假等待。
