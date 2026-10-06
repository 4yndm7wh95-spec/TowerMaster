# 测试 2 第二轮与测试 3 只读调研结果（2026-10-06）

## 环境与范围

测试代码提交 4656e76，分支 claude/optimistic-rubin-hr3eit，游戏 v0.111.0、mod 0.0.5、同机 A=100001（房主/塔主）、B=100002。只读调研及测试，未修改代码；本轮仅提交此报告。

dotnet test：Core 37、mod 16，合计 53 全过。真实程序集编译安装成功，0 警告、0 错误；安装目录 C:\Users\kkk\Desktop\slaythespire\Slay the Spire 2\mods\TowerMaster，安装 manifest version=0.0.5。

计划要求两场普通战斗；实际日志记录暗港三场普通战斗胜利，并进入 TerrorEelElite，未记录精英胜负；未发现 win 命令。用户确认选路、战斗奖励、事件、商店仍需要操作 A，休息处未遇到。宝箱和商店具体操作待补充；换幕未覆盖。

## 逐项结论

| 项目 | 结论 | 证据 |
| --- | --- | --- |
| 安装与自动测试 | 通过 | 53 全过，0.0.5 安装确认正确 |
| 动态程序集登记 | 通过 | 两端登记调用正文相同；游戏日志 not associated with any mod ERROR 均消失 |
| 人数改写 | 通过（启动挂钩） | 两端 N=122，M=19；新增五个方法都带 ★；无改写失败 |
| 探针/自身日志 | 通过 | 两份 TowerMaster 日志无 WARN/ERROR，探针全部找到 |
| 新增药水/卡牌/遗物实际内容 | 未覆盖 | ★ 只证明改写成功，未专项验证药水投掷或奖励池内容 |
| 塔主退场与人数 | 通过 | 三场普通战斗及精英开局 A=0/80、死亡=True，B 存活，爬塔人数=1；两端 19 条开局消息正文一致 |
| 单人血量 | 通过（暗港普通怪） | 钙化邪教徒三场均 40；海洋混混 44、45、45，均在指定单人范围；密林未覆盖，精英无本轮基准，不能据 140 血自行宣布通过 |
| 缩放参数 | 通过（记录范围） | 两端各 5 条均 playerCount=1、actIndex=0，正文一致；仅血量参数，无格挡参数；前五次限额导致后续调用未记录 |
| 混搭与清单 | 通过 | 两端各 16 条收到清单/替换/开始生成/生成正文一致，三场替换先于生成；序号 1、2、6 是普通战斗，其他为非普通移动 |
| StateDivergence | 通过（本轮未发现） | 两份游戏日志均无此项；无 GetMe/NullReference/InvalidOperation 异常 |
| 其他游戏异常 | 存在，报告不修复 | A 建房阶段 ENet host 创建失败及 Host already destroyed；后续成功入局。两端还有 mod 元数据、DirectConnectIP 托管兼容、资源缓存、动画缺失与退出资源泄漏提示 |
| 塔主全流程无需操作 | 不通过/测试 3 待实现 | 用户确认选路、奖励、事件、商店均需要操作 A；休息处、换幕及宝箱尚无完整实测结论 |

## 日志摘录

两端登记行正文一致（原文保留 A 时间戳）：

```text
[01:28:23.208] INFO 登记动态程序集：已调用 static Void MegaCrit.Sts2.Core.Modding.ModManager.AssociateAssemblyWithMod(String modId, Assembly assembly)，参数=[TowerMaster, RuntimeAssembly:TowerMaster.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]
```

新增五项（去时间戳，A/B 一致）：

```text
测试2 ★ 1 处 Boolean MegaCrit.Sts2.Core.Models.PotionModel.CanThrowAtAlly()
测试2 ★ 1 处 Boolean MegaCrit.Sts2.Core.Models.Relics.MassiveScroll.IsAllowed(IRunState runState)
测试2 ★ 1 处 Boolean MegaCrit.Sts2.Core.Models.Relics.SilverCrucible.IsAllowed(IRunState runState)
测试2 ★ 1 处 Boolean MegaCrit.Sts2.Core.Models.Relics.WingedBoots.IsAllowed(IRunState runState)
测试2 ★ 1 处 static IEnumerable<CardModel> MegaCrit.Sts2.Core.Factories.CardFactory.FilterForPlayerCount(IRunState runState, IEnumerable<CardModel> options)
===== 测试2：共 122 个方法读玩家人数，改写 19 个 =====
```

三场普通战斗开局两端一致，B 生命依次 80/80、55/80、38/80。首场摘录：

```text
测试2 参数 Creature.ScaleMonsterHpForMultiplayer(encounter=CultistsNormal:ENCOUNTER.CULTISTS_NORMAL, playerCount=1, actIndex=0)
测试2 开局 玩家 100001（塔主）：生命=0/80 死亡=True
测试2 开局 玩家 100002：生命=80/80 死亡=False
测试2 开局 爬塔人数=1
测试2 开局 怪物 CalcifiedCultist:MONSTER.CALCIFIED_CULTIST：生命=40/40 格挡=0
测试2 开局 怪物 Seapunk:MONSTER.SEAPUNK：生命=44/44 格挡=0
```

A 建房阶段原文摘录（后续恢复成功，不属于程序集登记错误）：

```text
ERROR: Couldn't create an ENet host.
   at: _create (modules/enet/enet_connection.cpp:318)
[WARN] [DirectHost] Failed to create host on 0.0.0.0:33771: CantCreate
ERROR: Host already destroyed.
   at: destroy (modules/enet/enet_connection.cpp:74)
```

两端还出现 low_health_loop 动画缺失 WARN，退出 RID/shader/资源未释放 ERROR，来源未定位。不能描述为游戏日志完全无错误。

## 测试 3 只读调研

以下路径相对于仓库 decompiled/sts2/。签名已与本轮 TowerMaster 探针导出的同步器成员对照；动作与消息来自反编译。挂点为调研建议，未经实现或实测；不能仅在一个客户端直接写另一个玩家的投票字段，否则会绕过同步。优先由塔主自己的客户端经原有动作/消息提交自己的选择，并检查本轮地点、页号、已有票和重复提交。

### 1. 选路投票

MapSelectionSynchronizer.cs（MegaCrit.Sts2.Core.Multiplayer.Game/）48–76 的 `void PlayerVotedForMapCoord(Player player, MapLocation source, MapVote? destination)` 按玩家槽位收票，拒绝错误地点和旧地图代次；72 行要求每个槽位都有当前代次的票，且由房主决定出发。84–94 的 `MoveToMapCoord()` 用固定种子的 RNG 从全部票中随机抽一张，再入队移动；不是多数票，票相同时自然得到同一点，票不同时按票抽选。

提交入口为 MegaCrit.Sts2.Core.Nodes.Screens.Map/NMapScreen.cs:660–673 的 `void OnMapPointSelectedLocally(NMapPoint point)`；入队 `VoteForMapCoordAction(Player player, MapLocation source, MapVote? destination)`，其 `Task ExecuteAction()` 调用同步器，`INetAction ToNetAction()` 返回 NetVoteForMapCoordAction（MegaCrit.Sts2.Core.GameActions/VoteForMapCoordAction.cs:23–41）。

自然挂点：收到爬塔玩家有效投票之后，在房主且塔主尚未投票时，入队塔主拥有的同目的地 VoteForMapCoordAction。应经 ActionQueueSynchronizer.RequestEnqueue(GameAction action) 同步，避免在 PlayerVotedForMapCoord 内无限递归；多爬塔玩家时需先定义塔主跟随谁，不能擅自把随机选择改为多数票。实测：选路需要 A，符合全员收票条件。

### 2. 战斗奖励

RewardsSetSynchronizer 并没有“所有人点继续”的单一闸门。MegaCrit.Sts2.Core.Multiplayer.Game/RewardsSetSynchronizer.cs:105–136 的 `Task BeginRewardsSet(RewardsSet set)` 为每位玩家自己的奖励栈创建完成任务；240–245 要求该集合 AllRewardsSuccessfullySelected，或通过跳过在273–285完成集合。`Task<bool> SelectLocalReward(Reward reward)`（139–160）发 RewardSelectedMessage；`void SkipLocalRewardsSet()`（163–172）发 RewardSetSkippedMessage。消息带 location/setId，玩家身份来自 senderId，不能只填一个假 playerId 代替他人。

普通战斗“继续”入口 MegaCrit.Sts2.Core.Nodes.Screens/NRewardsScreen.cs:420–464。普通 terminal 分支经 `Task RunManager.ProceedFromTerminalRewardsScreen()`（MegaCrit.Sts2.Core.Runs/RunManager.cs:1142–1161）打开本地地图，不等待全员奖励；离开房间前 RunManager.cs:947 调 `RewardsSetSynchronizer.BeforeLeavingRoom()`，该方法305–324会自动同步跳过本地剩余奖励。Boss/胜利房分支则进入换幕全员准备逻辑。

自然挂点：塔主的 BeginRewardsSet 已入栈之后，按确定策略在本地调用 SkipLocalRewardsSet（注意嵌套奖励、不可跳过集合和延后到 UI 建立完成），然后正常进入地图并补地图票；不能把“奖励集合完成”当成“地图已出发”。实测：用户说奖励需要操作 A；这可能包含 A 打开地图及投票，现有观察不能证明普通奖励有独立全员继续闸门。

### 3. 宝箱

MegaCrit.Sts2.Core.Multiplayer.Game/TreasureRoomRelicSynchronizer.cs:68 的 `void BeginRelicPicking()` 建立每位玩家票；`void OnPicked(Player player, int? index)`（142–184）在170行要求全部 voteReceived 才执行 AwardRelics。index=null 是明确跳过，也是有效票；不是没有提交。187–226按遗物分组分配；多人争同一遗物时生成争抢结果，未投某遗物的玩家也参与后续补偿分配逻辑。

`void PickRelicLocally(int? index)`（118–139）入队 `PickRelicAction(Player player, int? relicIndex)`；`void SkipRelicLocally()`（113–115）传 null。动作 ExecuteAction 调 OnPicked，ToNetAction 返回 NetPickRelicAction（MegaCrit.Sts2.Core.GameActions/PickRelicAction.cs:25–43）。开箱本身走 OneOffSynchronizer/TreasureChestOpenedMessage，不等每个人各开一次。

自然挂点：BeginRelicPicking 已初始化且宝箱有遗物时，塔主本地执行 SkipRelicLocally，或房主按标准队列提交塔主 PickRelicAction(null)。须避免未建立 CurrentRelics 时触发警告以及重复提交；空宝箱走 CompleteWithNoRelics。实测：宝箱待确认，不能按源码推定为已测。

### 4. 事件

共享事件 MegaCrit.Sts2.Core.Multiplayer.Game/EventSynchronizer.cs:117–135 的 `void PlayerVotedForSharedOptionIndex(Player player, uint optionIndex, uint pageIndex)` 按页收票，132行要求全部玩家都有票并由房主选择。`void ChooseSharedEventOption()`（140–156）用固定种子从所有票随机抽选，通过 SharedEventOptionChosenMessage 广播，再执行每位玩家的选项。`void ChooseLocalOption(int index)`（191–215）共享分支发 VotedForSharedEventOptionMessage；非共享分支发 OptionIndexChosenMessage(type=Event)，分别执行各自事件，没有同样的全员选项投票闸门。

离开事件 MegaCrit.Sts2.Core.Rooms/EventRoom.cs:81–89 等 `Task EventSynchronizer.AwaitPendingOptionTasks()`；同步器314–318等待当前 pending 选项任务，不等所有人都点同一个选项。MegaCrit.Sts2.Core.Nodes.Rooms/NEventRoom.cs:283–287 的 `Task Proceed()` 打开地图，后续仍需要全员地图票。

自然挂点：共享事件收到爬塔玩家当前页投票后，塔主本地经 ChooseLocalOption 跟投；非共享事件在 BeginEvent 建好塔主事件后选择合法可用的安全选项，不能固定索引0，因为代价、牌选择和后续奖励可能另有等待任务。按页和地点去重。实测：用户事件需 A；日志有 SelfHelpBook、BrainLeech，BrainLeech 明确 shared=False，两玩家都提交选项；不能把它当成共享投票实际验证。

### 5. 休息处

MegaCrit.Sts2.Core.Multiplayer.Game/RestSiteSynchronizer.cs:90–102 的 `void BeginRestSite()` 为每位玩家建选项及完成任务；`Task AfterAllRestSitesCompleted()`（234–239）逐个等每人的任务。MegaCrit.Sts2.Core.Rooms/RestSiteRoom.cs:41–45 在 Exit 调 `void BeforeLocalRestSiteExited()`，然后等全部完成。

`Task<bool> ChooseLocalOption(int index)`（159–169）发 OptionIndexChosenMessage(type=RestSite)，`Task<bool> ChooseOption(Player player, int optionIndex)`（172–214）执行效果并清除选项，清空才完成；`void BeforeLocalRestSiteExited()`（217–230）跳过本地剩余选项，发送 RestSiteSkippedMessage。消息接收126–135清空发送者选项并完成任务。

自然挂点：BeginRestSite 初始化完后，塔主本地调用 BeforeLocalRestSiteExited 自动跳过剩余选项，随后正常打开地图并投票；跳过比选择升级等带额外交互的选项更直接，但是否需要塔主休息收益应先由代码方确定策略。实测：未遇到，未覆盖。

### 6. 商店

在已检查的 MerchantRoom 与 NMerchantRoom 中未发现“所有玩家购买/确认完”的独立全员闸门。MegaCrit.Sts2.Core.Nodes.Rooms/NMerchantRoom.cs:120–133 的继续按钮接 `void HideScreen(NButton _)`，开启地图旅行；202–206 的 HideScreen 在 MerchantFtueCheck 未拦截时打开地图（教程分支需要单独注意）。MegaCrit.Sts2.Core.Rooms/MerchantRoom.cs:70 起的 `Task Exit(IRunState? runState)` 记录库存历史，未等待全员完成购买。真正离店出发仍受 MapSelectionSynchronizer.cs:72 的全员票限制。

购买为每人自己的库存：`Task<bool> MerchantEntry.OnTryPurchaseWrapper(MerchantInventory? inventory, bool ignoreCost=false)`（MegaCrit.Sts2.Core.Entities.Merchant/MerchantEntry.cs:65）执行实际购买；CardEntry.cs:139–140、PotionEntry.cs:86–87、RelicEntry.cs:60–61经 RewardSynchronizer 同步金币和获得物品。对应探针签名为 `void SyncLocalGoldLost(int goldLost)`、`void SyncLocalObtainedCard(CardModel card)`、`void SyncLocalObtainedRelic(RelicModel relic)`、`void SyncLocalObtainedPotion(PotionModel potion)`；使用 GoldLostMessage、RewardObtainedMessage（MegaCrit.Sts2.Core.Multiplayer.Game/RewardSynchronizer.cs:68–168）。删牌另有 `Task<bool> OneOffSynchronizer.DoLocalMerchantCardRemoval(int goldCost, bool cancelable=true)` 与 MerchantCardRemovalMessage（OneOffSynchronizer.cs:55–64）。这些都不是商店离开投票。

自然挂点：共用地图自动投票，必要时让塔主本地 HideScreen/打开地图，不必伪造购买或删牌。实测：用户说商店需 A，但尚未区分购物动作与继续/地图票；不能据此宣布源码存在购物全员等待。

### 7. 换幕

MegaCrit.Sts2.Core.Multiplayer.Game/ActChangeSynchronizer.cs:57–72 的 `void OnPlayerReady(Player player, int actIndex)` 标记槽位，69行要求全部 ready，76–85的 MoveToNextAct 才推进。`bool IsWaitingForOtherPlayers()`（44–54）供 UI 显示等待。`void SetLocalPlayerReady()`（34–40）入队 `VoteToMoveToNextActAction(Player player, int currentActIndex)`；动作 ExecuteAction 调 OnPlayerReady，ToNetAction 返回 NetVoteToMoveToNextActAction（MegaCrit.Sts2.Core.GameActions/VoteToMoveToNextActAction.cs:23–41）。Boss 奖励继续入口 NRewardsScreen.cs:426–439显示等待并提交。

自然挂点：塔主 Boss 奖励可离开、或第一位爬塔玩家有效准备后，为塔主入队同幕号的 VoteToMoveToNextActAction；不能在房间刚创建就提交，否则会提前触发或留下错误幕号票。需兼顾第二 Boss 与 victory 房分支。实测：只在第一幕，未覆盖换幕。

## 证据保存与限制

原始日志仅保存在本机 outputs/TowerMaster-test2-round2-A/B.log、game-test2-round2-A/B.log，未提交全文、反编译代码或自动产生的 plans.json。所有自动提交建议仅为调研，交代码方评估和实现。跨机器、不同网络环境、真正塔主自动旁观尚未测试。
