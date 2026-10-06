# 召唤阶段0.0.11实测：StateDivergence与重连黑屏

## 结论

**本轮不通过，联机被不同步中断，爬塔玩家重连后一直黑屏。** 用户报告玩家B出现多人数据不同步；日志确定爬塔玩家=100002、塔主/房主=100001。只做测试和只读分析，未修改代码。交由Claude修复后再继续剩余验收。

版本0.0.11，游戏v0.111.0，测试代码fa95443。68个测试全部通过（Core39+mod29），真实游戏编译安装成功、0警告0错误，manifest0.0.11。新启动日志正常、召唤已启用。此次实际上继续了之前的存档：seed仍15584742761026350208，启动从第二幕已有房间重建，并非新开第一幕；这不影响下面不同步的实际证据。

## 不同步发生在哪里

爬塔玩家game-B.log:1394起：

```text
[ERROR] State divergence message received for player 100001 checksum ID 7! (We are Client 100002)
Context: Exiting event room EVENT.FIELD_OF_MAN_SIZED_HOLES. Local: 1282962384. Remote: 1816849326.
```

随后明确断线原因StateDivergence。触发校验的是离开事件FIELD_OF_MAN_SIZED_HOLES，不是此次召唤清单发送时。比较该报错中LOCAL STATE DUMP与REMOTE STATE DUMP：**唯一打印出的差异是奖励编号**。

| 项目 | 爬塔玩家本地状态 | 房主远端状态 |
| --- | --- | --- |
| Choice IDs | 1,7 | 1,7 |
| Reward IDs | **4,5** | **3,4** |
| 塔主金币 | 325 | 325 |
| 爬塔玩家金币 | 187 | 187 |
| 其余转储字段 | 玩家遗物、药水、随机流/计数等逐行一致 | 同左 |

这是状态转储可见差异，不意味着没有未转储的其他内部状态；不能将不同步泛归于网速，也不能说金币已经两端不一致。

## 首次奖励编号分叉：前一个宝箱

两端奖励集合序列起初一致（两名玩家先后创建Id0、Id1、Id2）。CRYSTAL_SPHERE事件的爬塔玩家奖励集合Id3也一致。之后第二幕(3,9)的宝箱：

- 塔主日志07:25:33.410只有“塔主跳过遗物”，随后07:25:36.843跟投前进；这次没有“塔主不拿开箱金币”行，也没有创建宝箱空奖励组。
- 爬塔玩家游戏日志1209/1211行在塔主遗物跳过动作之后，额外创建Owner100001的Id3空奖励组、Owner100002的Id4空奖励组。
- 房主日志没有这两组；因此各玩家nextId在爬塔玩家端多1。下一事件离开校验读出4,5 vs3,4。

原文（爬塔玩家端）：

```text
[DEBUG] [RewardsSetSynchronizer] Beginning rewards set Id: 3 Owner: 100001 Rewards: 
[DEBUG] [RewardsSetSynchronizer] Reward set Id: 3 Owner: 100001 Rewards:  completed with state: Completed
[DEBUG] [RewardsSetSynchronizer] Beginning rewards set Id: 4 Owner: 100002 Rewards: 
[DEBUG] [RewardsSetSynchronizer] Reward set Id: 4 Owner: 100002 Rewards:  completed with state: Completed
```

## 源码依据与候选根因（未修复）

以下反编译路径相对decompiled/sts2，只用自己的话转述：

1. MegaCrit.Sts2.Core.Nodes.Rooms/NTreasureRoom.cs:219–237：本地OpenChest流程依次DoNormalRewards、DoExtraRewardsIfNeeded、初始化遗物与焦点。未在该端打开宝箱UI，就可能不执行其额外奖励建立步骤。
2. MegaCrit.Sts2.Core.Rooms/TreasureRoom.cs:66起：DoExtraRewardsIfNeeded遍历所有玩家、GenerateForRoomEnd并Offer奖励组，即使内容为空也有建立奖励集合的流程。
3. MegaCrit.Sts2.Core.Multiplayer.Game/RewardsSetSynchronizer.cs:108–109：BeginRewardsSet赋值当前玩家nextId后递增；空奖励组也会消费编号。
4. mod/TowerMaster/Test3MasterAutoPilot.cs:49、185起：奖励自动跳过发生在BeginRewardsSet之后，不能让未创建组的另一端补建；248附近宝箱自动SkipRelicLocally也不等于执行整个OpenChest/额外奖励流程。
5. 新BlockTreasureGold只拦DoLocalTreasureRoomRewards（mod/TowerMaster/Test3MasterAutoPilot.cs:225起），它不会主动同步或建立ExtraRewards。

**高可信候选原因：塔主自动跳遗物后无需打开本地宝箱，但爬塔玩家打开宝箱时会为所有玩家建立空奖励集合，造成两端奖励序号不同。** 本次日志直接证明集合创建分叉；尚未增加UI探针记录“用户是否点开第二个宝箱”，因此具体未调用OpenChest的触发动作仍需Claude确认，不能说新增金币拦截本身已被证明是唯一根因。

建议把宝箱奖励集合创建放到每端都一致执行的同步流程，明确一次性/重复打开/空奖励/存档恢复；仅忽略校验、将异常吞掉或只同步余额不能修复奖励序号。保持塔主不拿金币/遗物，同时确保爬塔玩家正常领取继续。未实施任何修复。

## 重连黑屏

用户：爬塔玩家断线后连接回来一直黑屏。日志确认：

- 房主收到100002重新连接与ClientRejoinRequestMessage，之后收到sync player message。
- 爬塔玩家已连接房主、收到ClientRejoinResponseMessage并登记运行消息，位置恢复到act1 coord(3,11)，完成角色和Hive资源预加载。
- 此后没有新的进房完成/战斗运行记录，用户退出两端。不是握手一直失败的同一情况。

**具体黑屏根因未确诊。** 需要检查恢复入房时的CombatStateSynchronizer屏障、期待玩家/RNG数据、房主重连响应和淡入完成。RunManager.cs:692–754、887–921、1025–1046都有await WaitForSync/进入房间/淡入链；CombatStateSynchronizer.cs:128–139、178起等待所有lobby玩家数据及rngSet。现有日志没有足够信号确定卡在哪个await，不把它写成已证实的同一根因。

## 本轮已确认与未覆盖

- 账本日志实际恢复：读档召唤点18，已打5场。该值与0.0.10退出前账本18一致，真实新进程加载已验证。
- 一次第二幕普通召唤：ThievingHopper+Ovicopter，花费9，18→9；收入5（基础5、节约0、战果0），9→14，上限45。双端收到清单/替换/生成一致，开局塔主0血死亡、爬塔人数1。
- 07:25:17.977实际记录“测试3 宝箱：塔主不拿开箱金币，已跳过”；不同步转储两端塔主金币均325。没有开箱前金币快照，不能只凭当前325证明金币数前后不变。
- 普通/精英/Boss面板截图、外观意见、按原版出场、超时、不同精英、Boss标准0等本轮没有完成验收；本次被阻塞中止，不迁移上一轮通过结论。
- 两端TowerMaster日志未见ERROR/WARN。StateDivergence发生在游戏日志，不能据mod日志无ERROR宣布通过。

## 错误原文摘录

只摘相关报错与连接状态，不提交原始日志全文或状态转储全文。爬塔玩家启动早期还有ID Collision，之后已正常连接，与运行期StateDivergence区别记录：

```text
[ERROR] [DirectClient] Handshake rejected: ID Collision (100002)
[INFO] [RunLobby] Disconnected. Reason: StateDivergence
```

重连日志关键行：

```text
[INFO] [DirectClient] Connected to host 100001
[DEBUG] [RunLocationTargetedMessageBuffer] Run location changed to act 1 coord (3, 11) room 0 (previously at: act 1 coord (3, 10) room 0), checking if we have enqueued messages
[DEBUG] [RunLocationTargetedMessageBuffer] Run location changed to act 1 coord (3, 11) room 0 (previously at: act 1 coord (3, 11) room 0), checking if we have enqueued messages
[INFO] [DirectClient] Connected to host 100001
[INFO] [JoinFlow] Sending ClientRequestRejoinMessage and waiting for rejoin response message
[INFO] [NetMessageBus] Received message MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby.ClientRejoinResponseMessage, sending to 1 handlers
[DEBUG] [RunLocationTargetedMessageBuffer] Run location changed to act 1 coord (3, 11) room  (previously at: act 0 coord (null) room ), checking if we have enqueued messages
```

游戏退出另有Godot RID/shader/resource泄漏ERROR，与发生不同步的奖励编号差异不是同一证据；未改游戏资源。原始日志已在本机工作目录备份，尚未提交。
