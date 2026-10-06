# 塔主回合 0.0.20 测试结果（阻断，待修复）

## 环境与操作

游戏 v0.111.0，分支 claude/optimistic-rubin-hr3eit，代码 c476974；本机双实例，塔主 NetId 100001、爬塔玩家 100002。85 个测试全部通过（Core 41、TowerMaster 44），真实游戏编译安装成功，零警告零错误，manifest 0.0.20，master_turn=true。未修改 mod 或 MCP 代码。本次战斗没有使用 win。

初次种子 17710710670978326178，第一幕普通房小啃兽 43 血，塔主威胁点 3，第一回合开始后约 20 秒自动结束，超时流程已观察到。随后重启新局种子 7490775933630920629，第一幕 Underdocks，普通房 SludgeSpinnerWeak，淤泥旋螺 38 血；选择按原版出场，召唤点 12→9，标准开销 3。两端塔主 0/80 死亡、爬塔人数 1。

## 逐项结论

|项目|结论|证据及限制|
|---|---|---|
|普通房威胁点 3、回合开始|通过|两端有开始日志，房主 /threat points=3|
|塔主查看手牌|接口通过，画面待核验|/threat 返回玩家 100002 的五张手牌，保存两端截图|
|20 秒超时结束|通过|第一回合开始到结束约 20 秒，结束原因为超时|
|取消倒计时|运行时设置成功，持久配置不通过|见下节；第二回合 /threat seconds_left=null|
|塔主期间出牌／结束回合排队|未覆盖|第一回合已超时；第二回合出牌请求之前客户端已触发断线，不能作为有效测试|
|格挡+力量、耗尽点自动结束|未覆盖|不同步中断，未施加|
|次回合点耗尽跳过|未覆盖|未耗尽威胁点|
|虚弱／易伤／脆弱／眩晕／回血／全体力量与重复限制|未覆盖|阻断后停止|
|塔主回合 win、后续战斗|未覆盖|阻断后停止|
|精英 4／Boss 5|未覆盖|未到达|
|两端无 StateDivergence|不通过|第二回合开始时客户端被踢回主菜单|
|自然战斗平衡|未覆盖|只验证动作路径，不作为平衡样本|

## 阻断：第二回合开始校验不同步

操作顺序：第一回合超时恢复后，通过原版 ActionQueueSynchronizer.RequestEnqueue(GameAction) 入队 PlayCardAction，使怪物 38→32；再入队 EndPlayerTurnAction，玩家受到伤害 80→72；第二回合塔主开始时出现 StateDivergence。没有修改玩家血量、能量、卡堆或绕过联机队列。

房主错误摘录：

```text
[ERROR] State divergence detected! Checksum with ID 9 for client 100002 doesn't match host's!
Context: After player turn start. Local: 3882655920. Remote: 1639731926.
```

客户端错误摘录：

```text
[ERROR] State divergence message received for player 100001 checksum ID 9! (We are Client 100002)
Context: finished action execution TowerMasterSummonGameAction. Local: 1639731926. Remote: 3882655920.
```

两端 LOCAL STATE DUMP 比较：房主 Last executed action ID 为空，客户端为 9；玩家 100002 都在 Turn 2 Phase Start，房主 Energy 3、客户端 Energy 2；房主五张新牌在 Hand，客户端对应牌仍在 Draw。其余完整日志保留本地，不提交。注意 dump 是报错处理时获取，不能直接当作最初校验快照；差异支持时序问题方向，但不证明根因。

只读依据：decompiled/sts2/MegaCrit.Sts2.Core.Combat/CombatManager.cs:569 在玩家回合开始流程生成 After player turn start 校验；:604 切到 PlayPhase；:606 触发 TurnStarted。mod/TowerMaster/ThreatPhase.cs:130 订阅 TurnStarted，:143 处理开始，:274 请求入队动态动作。建议 Claude 检查新 begin 动作和回合开始校验是否以一致顺序生成编号／状态，及异步执行是否提前跨过抽牌和回合阶段。尚未进行无运行时配置修改的第二回合对照复现，结论是疑似时序冲突，不是已证明代码根因。

原版解除暂停位置：decompiled/sts2/MegaCrit.Sts2.Core.GameActions.Multiplayer/ActionQueueSynchronizer.cs:87（NotInCombat），:108（PlayPhase），均调用 ActionQueueSet.UnpauseAllPlayerQueues；定义在同命名空间 ActionQueueSet.cs:302。此轮尚未证明塔主回合期间直接出牌。

客户端之后有“Attempted to send message ... while ... is not connected!”两类 ERROR：ChecksumDataMessage，以及 RequestEnqueueActionMessage（CARD.BASH index15 target2）。后者是测试接口在断线已经发生后请求出牌导致的次生错误，不作为不同步原因。

TowerMaster 两端截至中断未出现 ERROR/WARN；游戏日志已有上述不同步及断线后发送错误。第二回合开始行两端一致；由于发生断线，没有完成整轮验收。

## MCP 原版出牌调用路径

已实际执行成功：target=run.ActionQueueSynchronizer，method=RequestEnqueue；参数 new PlayCardAction(ref state.Players[1].PlayerCombatState.Hand.Cards[0], ref combat.Enemies[0])。攻击目标必须按牌的 TargetType 设置，不能所有牌都传怪物。构造签名依据 decompiled/sts2/MegaCrit.Sts2.Core.GameActions/PlayCardAction.cs:37。

结束回合：同 target/method；new EndPlayerTurnAction(ref state.Players[1], ref state.Players[1].PlayerCombatState.TurnNumber)。原版按钮入队依据 decompiled/sts2/MegaCrit.Sts2.Core.Nodes.Combat/NEndTurnButton.cs:443。反射请求返回成功只代表入队调用成功，需另查执行状态和日志。

## 用户需求：删除倒计时

用户明确要求后续删除倒计时及其显示。此前测试者将 master_turn_seconds=0 加到安装后的 towermaster.test.json，误以为重启会生效；已向用户纠正。TestSettings 没有此字段，ModEntry.cs:43 直接 new TowerMasterConfig，:46 传给 ThreatPhase，所以测试配置额外字段被忽略，重启后仍 20 秒。

经用户取消限时授权，通过两端测试接口：target=type:TowerMaster.ThreatPhase|_config，method=set_MasterTurnSeconds，args=[0]，运行时设置成功，第二回合 seconds_left=null。没有改代码，但此修改不持久，重启需重新设置。请 Claude 删除自动超时、倒计时文字和计时进度条，或按最终产品需求接入配置。ThreatPanel.cs:97–98 仍无条件更新计时文字／条。测试报告必须保留这一干预，不能声称原默认配置完整通过。

## 截图与下一步

截图 docs/screenshots/master-turn-0.0.20-first-A.png、master-turn-0.0.20-first-B.png：重启新局第一回合（当时仍默认限时）。未提交完整日志、反编译源码、资源。请先修复／复现第二回合不同步，再重测暂停出牌和所有未覆盖项目。本轮验收不通过。
