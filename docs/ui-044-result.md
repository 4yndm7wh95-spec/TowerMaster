# 0.0.44 测试结果

日期：2026-10-08。分支 `claude/optimistic-rubin-hr3eit`，代码 `119d157`。本轮只测试和只读定位，未修改 mod 代码，不作平衡结论。

## 安装与执行范围

- 编译成功，0 warning / 0 error，**109 个测试通过（49+60）**；安装manifest=0.0.44。
- 两个测试实例共用安装目录；A=100001 房主/塔主，B=100002 爬塔，两端/ping确认版本、身份。川换皮保持禁用，未操作用户自己的游戏进程。
- 仓库配置覆盖安装配置；SHA256 `CE7D223D1626984CFD04F2F8E54D0CF4819EC3B6BDEB2B783F4866E23D169301`，master_cards=true。
- 新局种子 `13091373478004547250`，Overgrowth。沿地图到第一幕Boss；正常普通战使用tm_play/tm_end_turn，不加B能量/抽牌，不用room/fight/win。为尽快检验精英陷阱及后续房间，精英先让B正常打3张防御触发碎甲，再用**原版网络控制台 damage 999（对所有敌人）**结束精英；Boss房按原版出场，塔主先手结束后用**damage 999 1**杀死B做结算。该精英/Boss不是自然难度样本。
- 宝箱处正常保存并完整退出两端、重开读档；用户说测试中断后又恢复到第12层奖励。每次重启前本地另存了日志。本轮报告统计分三段，不提交完整原始日志/存档。
- 测试实例最后正常退出；未提交反编译源码或游戏资源。

## 结论表

|项目|结论|实测说明|
|---|---|---|
|房主大厅隐藏角色UI|部分通过|按钮/介绍/背景隐藏，但“你是塔主”面板下半截越界，并和进阶说明区域重叠|
|房主固定角色|通过（回调测试）|后台Ironclad；对隐藏Silent按钮调用原版Select后仍Ironclad；物理鼠标点旧位置未覆盖|
|B选角/准备/开局|通过|B从Ironclad切Silent成功，再切回Ironclad，双方正常开局|
|角色按钮不显示房主标记|截图未见房主标记|B可见自己选择标记；玩家栏另有未修的问题|
|大厅玩家栏塔主头像/文字|不通过|两端房主栏仍是铁甲头像/铁甲战士|
|多人读档大厅|原样记录|房主仍为铁甲头像/角色名，A本地也为铁甲背景；该界面未处理|
|塔主原版遗物移除|通过新局|两端塔主BurningBlood去掉，B仍保留；古人新增LostCoffer在下一次deck后也去掉|
|旧0.0.43存档迁移|未覆盖|上一轮两局已结束，没有可继续的旧current_run_mp.save；不以本轮存档冒充旧版迁移|
|胜利后塔主位置绿色+6|采样通过|两场连续截图只见B回血，不见隐藏塔主第二处绿色数字；非逐帧录像|
|商店/篝火塔主英雄|通过|两端只剩B原版角色，塔主没有围坐|
|A顶栏头像/介绍|通过|换塔主头像，真实鼠标移至头像后没出现原版角色介绍|
|结算塔主英雄隐藏|不通过|关战报后两端仍有站立铁甲，和倒地B同时可见|
|地图标记|部分覆盖|静态地图仍有两个铁甲标记；投票连续截图未抓到B投票/A跟随标记同时可见的精确时刻|
|跑图历史|原样记录|两端仍显示两个铁甲图标/角色历史，不算本版回归缺陷（明确未改）|
|信息条正常位置|通过普通场景|全局矩形(1535,106)..(1902,165)，在屏幕内，不挡原顶栏按钮|
|信息条在召唤面板|部分通过|B可读；A在高层召唤遮罩下变暗，左侧少量被面板遮住，不能算完全无遮挡|
|真实悬停陷阱名|通过|实际WarpMouse定位到信息条，Godot工具提示显示本场已触发：碎甲|
|Boss名称对照|通过|信息条和召唤候选同为同族小队/墨影幻灵|
|宝箱冷读档自然流程不同步|未复现|B按画面重新开箱后Reward IDs对齐，经篝火、下一普通战正常|
|摘要/StateDivergence|通过保留三段|24/24、8/8、10/10逐行一致，共42/42；不同步事件0|

## 1. 大厅

截图：[A建房未加入](screenshots/ui044-lobby-host-before-join.png)、[加入后A](screenshots/ui044-lobby-settled-A.png)、[加入后B](screenshots/ui044-lobby-settled-B.png)。

A的角色按钮、介绍和大背景确实消失，说明面板确实出现。但说明面板顶部在画面偏下，后面几行落到屏幕底部以外；其顶部范围接触进阶面板，不能判“面板完全不挡进阶”通过。准备/出发按钮位于右下仍可用，玩家栏在左上可见。

只读定位：`mod/TowerMaster/MasterLobby.cs` 的 Notice() 将holder设CenterLeft锚点又给Position=(120,260)，可能将中线偏移当绝对屏幕位置；建议Claude检查锚点与偏移，不改代码。后台实际查询为Ironclad。调用隐藏SILENT_button.Select后A仍Ironclad，B同一Select调用可切到Silent，再切回Ironclad。该测试经过原版选择回调，**没有实际系统鼠标点击旧坐标**，不要把两者混为一项。

**玩家栏不通过**：两端房主的名字仍A，角色一行仍铁甲战士，头像仍铁甲。`MasterLobby.AfterRemotePlayerCharacter` 挂在SetCharacter后，但原版 `decompiled/sts2/MegaCrit.Sts2.Core.Nodes.Multiplayer/NRemoteLobbyPlayer.cs:136` 的OnPlayerChanged调用SetCharacter后，:142又调用RefreshVisuals；:154 RefreshVisuals重新写入原版_character.Title和IconTexture。SetCharacter后置修改会被后续RefreshVisuals覆盖，且_Ready :133本来直接RefreshVisuals。建议Claude把显示修正在最终刷新后执行；这是源码顺序解释，未修改实现。

多人读档截图：[A](screenshots/ui044-load-lobby-A.png)、[B](screenshots/ui044-load-lobby-B.png)。房主那格仍铁甲。A还保留铁甲角色背景/数据；本版明确未专门处理此界面。

所有“塔主大厅”日志（包括冷读档及最后恢复进程；后两段没有该前缀）：

**A**

```text
[10:26:27.181] INFO 塔主大厅：建房，本机是塔主 100001
[10:26:27.304] INFO 塔主大厅：房主后台固定角色 Ironclad，角色界面换成塔主说明
```

**B**

```text
[10:26:29.314] INFO 塔主大厅：加入大厅，房主（塔主）100001
```

## 2. 遗物和回血

新局进古人时，两端只读 `state.Players[0].Relics=[]`，B的`state.Players[1].Relics=[BurningBlood]`。当前tm_state接口不返回遗物列表，故用tm_reflect读取真实Player.Relics补验，不把缺少字段当空列表。古人处塔主得到LostCoffer后，第一次召唤的deck同步又把它去掉，两端日志一致：

**A**

```text
[10:30:37.772] INFO 塔主牌组：新的一局，去掉塔主的原版遗物 BurningBlood
[10:33:24.332] INFO 塔主牌组：塔主回合 #1 第0回合，去掉塔主的原版遗物 LostCoffer
```

**B**

```text
[10:30:37.790] INFO 塔主牌组：新的一局，去掉塔主的原版遗物 BurningBlood
[10:33:24.669] INFO 塔主牌组：塔主回合 #1 第0回合，去掉塔主的原版遗物 LostCoffer
```

两场胜利瞬间抓A/B连续8组，图名ui044-battle{1,2}-victory-{0..7}-{A,B}。只看到B正常燃烧之血回血，没有上一轮空位第二个绿色6。代表：[第一场A](screenshots/ui044-battle1-victory-0-A.png)、[第一场B](screenshots/ui044-battle1-victory-0-B.png)。截图是串行采样，不能证明没采到的每一帧。

0.0.43旧存档：当前profile只有progress/history，没有那两局未结束current_run_mp.save，故本项未覆盖。本轮后来冷读的是新0.0.44存档，不能替代旧版迁移验收。

## 3. 身份复查

|场景|A|B|画面事实|
|---|---|---|---|
|商店|[A](screenshots/ui044-shop-A.png)|[B](screenshots/ui044-shop-B.png)|只剩一个原版英雄；可见NMerchantCharacter各端一个|
|篝火|[A](screenshots/ui044-rest-after-A.png)|[B](screenshots/ui044-rest-after-B.png)|只有B围坐，另一侧空，没有塔主英雄|
|宝箱|[A](screenshots/ui044-treasure-A.png)|[B](screenshots/ui044-treasure-B.png)|宝箱/奖励原版画面，未见塔主英雄；冷读B恢复成未开宝箱|
|问号事件|[A](screenshots/ui044-event-A.png)|[B](screenshots/ui044-event-B.png)|原版事件图文和选项，未见塔主战斗英雄|
|顶栏头像|[真实悬停A](screenshots/ui044-portrait-hover.png)|B保持自己铁甲头像|A换塔主头像，未出现角色介绍|
|结算|[稳定A](screenshots/ui044-gameover-stable-A.png)|[稳定B](screenshots/ui044-gameover-stable-B.png)|仍有站立铁甲/倒地铁甲，不通过|
|地图|[A](screenshots/ui044-map-A.png)|[B](screenshots/ui044-map-B.png)|古人地图底部可见两个铁甲标记；不是实际投票瞬间|
|历史|[A](screenshots/ui044-history-A.png)|[B](screenshots/ui044-history-B.png)|仍原版铁甲角色/图标，未改部分原样记录|

地图投票时另外启动两端6组连续截图（ui044-map-vote-{0..5}-{A,B}），但抓到的是篝火/转场，未捕获短暂投票标记；不以静态地图冒充投票跟随验收。

结算采用Boss正常沿地图进房、按原版出场，结束塔主先手后对B执行原版网络控制台 `damage 999 1`（Creatures索引1为B）。战报出现，点“看原版结算”关掉后仍有站立铁甲。稍后稳定截图亦如此。

**只读原因**：`NGameOverScreen.MoveCreaturesToDifferentLayerAndDisableUi()`（`decompiled/sts2/MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen/NGameOverScreen.cs:765`）拿NCreature.Visuals，:832 Reparent的对象是 **NCreatureVisuals**，不是NCreature。MasterPresence.HideCreaturesUnder只找GameOver子树中的NCreature，因此漏掉已经移过去的英雄外观。实测NCreature节点仍在CombatRoom/AllyContainer，WatchGameOver指向GlobalUi/OverlayScreensContainer/GameOverScreen。建议保留Player/Visuals对应关系并隐藏正确的Visuals；不要靠遍历GameOver下NCreature来判断已隐藏。未改代码。

## 4. 信息条

两端信息条全局矩形一致（1920×1080逻辑视口）：

```text
Position=(1535,106)
Size=(367,59)
End=(1902,165)
```

在地图、战斗、商店、牌组查看截图中位于原版顶栏下方右侧，没有遮住顶栏地图/牌组/设置按钮、手牌或地图图例。文本宽度可能因内容变化而变化；上述为带本场计数的实测矩形。

- 地图：ui044-map-A/B；战斗：ui044-battle1-start-9-A/B；商店：ui044-shop-A/B；牌组：ui044-deck-A/B。
- 召唤：ui044-boss-panel-A/B。A信息条处在CanvasLayer100召唤面板之下，背景遮罩使其变暗，左侧少量内容被面板盖住；B没有房主召唤面板所以完整可读。普通场景定位修复通过，召唤时“完整可见”只能部分通过。
- 碎甲：盖1张，手里0；B原版手牌恰有3张防御，正常打出后两端已触发1。没有给B加能量或抽牌来触发。
- 真悬停：[截图](screenshots/ui044-hud-real-hover.png)。通过DisplayServer.WindowMoveToForeground + Input.WarpMouse，把信息条逻辑中心经GetViewportTransform换为窗口坐标。GetGlobalMousePosition=(1717.5396,135)在矩形内，原版Godot tooltip出现“本场已触发：碎甲”。没有用MouseEntered信号代替指针。
- Boss：沿地图进入(3,15)后，tm_summon.encounters=[TheKinBoss同族小队,VantomBoss墨影幻灵]；两端信息条也同族小队/墨影幻灵。后台数据、截图一致。[A候选](screenshots/ui044-boss-panel-A.png)、[B信息条](screenshots/ui044-boss-panel-B.png)。

## 5. 宝箱冷读档与上一轮结论修正

**重要修正**：上一轮0.0.43只证明“读档后B未重新开箱、测试助手直接用tm_map_vote离开”造成奖励计数不同步，未证明正常按原版画面走流程也必现。那次我遗漏了B冷读后仍是闭合宝箱的状态，直接投票绕过了重新开箱。本轮按实际画面重新开箱后没有不同步；不能把上一轮异常直接归为自然游戏冷读档必现bug。此更正优先于ui-043-result.md中当时的归因。

### 本轮路径及计数

宝箱(5,8)正常：塔主自动开箱、跳过塔主选牌，B开箱拿遗物→保存退出两端→重启多人读档，稳定恢复宝箱→B按画面重新开箱拿遗物→下一普通战(5,9)正常胜利→篝火(4,10)正常休息、塔主跳过删牌→下一普通战(3,11)正常胜利。上轮种子的“宝箱直接接篝火”本轮路线没有，因此本轮中间多一场正常战，不声称坐标完全相同。

冷读稳定时B画面是**未打开的宝箱**：[B截图](screenshots/ui044-cold-stable-B.png)。塔主已自动打开；该时刻计数可暂时不同，不能在B本地开箱前做全局等价验收。

|观察时刻|A Reward IDs|B Reward IDs|Choice IDs|
|---|---|---|---|
|读档后A自动开箱，B未开|[1,1]|[0,0]|未在此时采Choice|
|B重新开箱后|[1,1]|[1,1]|未在此时采Choice|
|下一战结束、篝火处理完|[2,3]|[2,3]|两端[1]|
|离开篝火、下一战结束|按原版BeginRewardsSet继续推进|两端同顺序|无不同步ERROR|

真实读取方法：tm_reflect `run.RewardsSetSynchronizer.GetNextRewardIds()`、`run.PlayerChoiceSynchronizer.ChoiceIds`。后续摘要也一致，StateDivergence=0。没有手工写Reward IDs来对齐。

从本次冷启动读档到离开篝火/下一战的所有Beginning rewards set原文如下（没有发生出错，记录到下一战结束为止）：

**A**

```text
[DEBUG] [RewardsSetSynchronizer] Beginning rewards set Id: 0 Owner: 100001 Rewards: 
[DEBUG] [RewardsSetSynchronizer] Beginning rewards set Id: 0 Owner: 100002 Rewards: 
[DEBUG] [RewardsSetSynchronizer] Beginning rewards set Id: 1 Owner: 100001 Rewards: MegaCrit.Sts2.Core.Rewards.GoldReward,MegaCrit.Sts2.Core.Rewards.PotionReward,MegaCrit.Sts2.Core.Rewards.CardReward
[DEBUG] [RewardsSetSynchronizer] Beginning rewards set Id: 1 Owner: 100002 Rewards: MegaCrit.Sts2.Core.Rewards.GoldReward,MegaCrit.Sts2.Core.Rewards.CardReward
[DEBUG] [RewardsSetSynchronizer] Beginning rewards set Id: 2 Owner: 100002 Rewards: 
[DEBUG] [RewardsSetSynchronizer] Beginning rewards set Id: 2 Owner: 100001 Rewards: MegaCrit.Sts2.Core.Rewards.GoldReward,MegaCrit.Sts2.Core.Rewards.PotionReward,MegaCrit.Sts2.Core.Rewards.CardReward
[DEBUG] [RewardsSetSynchronizer] Beginning rewards set Id: 3 Owner: 100002 Rewards: MegaCrit.Sts2.Core.Rewards.GoldReward,MegaCrit.Sts2.Core.Rewards.CardReward
```

**B**

```text
[DEBUG] [RewardsSetSynchronizer] Beginning rewards set Id: 0 Owner: 100001 Rewards: 
[DEBUG] [RewardsSetSynchronizer] Beginning rewards set Id: 0 Owner: 100002 Rewards: 
[DEBUG] [RewardsSetSynchronizer] Beginning rewards set Id: 1 Owner: 100001 Rewards: MegaCrit.Sts2.Core.Rewards.GoldReward,MegaCrit.Sts2.Core.Rewards.PotionReward,MegaCrit.Sts2.Core.Rewards.CardReward
[DEBUG] [RewardsSetSynchronizer] Beginning rewards set Id: 1 Owner: 100002 Rewards: MegaCrit.Sts2.Core.Rewards.GoldReward,MegaCrit.Sts2.Core.Rewards.CardReward
[DEBUG] [RewardsSetSynchronizer] Beginning rewards set Id: 2 Owner: 100002 Rewards: 
[DEBUG] [RewardsSetSynchronizer] Beginning rewards set Id: 2 Owner: 100001 Rewards: MegaCrit.Sts2.Core.Rewards.GoldReward,MegaCrit.Sts2.Core.Rewards.PotionReward,MegaCrit.Sts2.Core.Rewards.CardReward
[DEBUG] [RewardsSetSynchronizer] Beginning rewards set Id: 3 Owner: 100002 Rewards: MegaCrit.Sts2.Core.Rewards.GoldReward,MegaCrit.Sts2.Core.Rewards.CardReward
```

塔主读档恢复时自动开箱确实执行，原文：

**A**

```text
[10:57:15.382] INFO 测试3 宝箱：塔主自动开箱（保证各端奖励编号一致）
```

**B**

```text

```

### 原版调用顺序（只读）

1. `TreasureRoom.EnterInternal(IRunState?,bool)`（decompiled/sts2/MegaCrit.Sts2.Core.Rooms/TreasureRoom.cs:34）预载、创建NTreasureRoom、SetCurrentRoom、Hook.AfterRoomEntered，然后BeginRelicPicking。恢复也重建节点，不直接恢复这个节点的“已打开”UI状态。
2. `NTreasureRoom._Ready()`（Nodes.Rooms/NTreasureRoom.cs:133）建立箱子/按钮/遗物容器，没有自动为两端都调用OpenChest。
3. `Test3MasterAutoPilot.AfterTreasureRoomReady`（mod/TowerMaster/Test3MasterAutopilot.cs:268）只对LocalIsMaster安排1.5秒后原版OnChestButtonReleased；检查_hasChestBeenOpened为false才调用。重建节点时该标记也是初始false，所以恢复时A会自动开箱。
4. B恢复时也有新的闭合箱子，但没有塔主auto补丁，需玩家正常点开。`OnChestButtonReleased`（NTreasureRoom.cs:201附近）→async OpenChest :219 → await DoNormalRewards → await DoExtraRewardsIfNeeded →初始化遗物选择→选完更新Proceed/地图旅行。
5. `TreasureRoom.DoExtraRewardsIfNeeded()` :66 遍历所有Player生成各自RewardsSet，每个客户端本地都Offer；`RewardsSet.Offer()`（Core.Rewards/RewardsSet.cs:119）走BeginRewardsSet；`RewardsSetSynchronizer.BeginRewardsSet(RewardsSet)`（Multiplayer.Game/RewardsSetSynchronizer.cs:105）为Owner分配nextId并加1。即使奖励为空，也消耗一个编号。
6. 因此A已经点开/B尚未点开的中间时刻[1,1]对[0,0]可出现；B补走同一路径后自然对齐。测试接口投票绕过原版旅行可用性时可能把中间状态带出房；建议Claude对tm_map_vote加IsTravelEnabled/房间已完成检查，测试助手也必须先完成当前本地房间。不要直接以只读计数一时不同要求复制改写计数。

没有执行完全不装TowerMaster的双普通玩家对照：唯一可用的游戏控制桥随TowerMaster移除也会失效，且用户要求全部由助手、持续用接口测试。没有把“关闭部分功能但仍装TowerMaster”冒充无mod基线。本轮正常有mod路径未复现不同步，但不能外推所有宝箱/遗物/存档条件。

## 6. 回归及日志总计

日志在冷启动前、中断重启前、最终进程分别本地保存，不重启覆盖后再声称全轮零异常。

|日志段|A摘要|B摘要|逐行比较|StateDivergence实际事件|TowerMaster ERROR/WARN|
|---|---:|---:|---|---:|---|
|新局→宝箱保存退出|24|24|一致|0|A0/0、B0/0|
|冷读宝箱→篝火→下一战（中断前）|8|8|一致|0|A0/0、B0/0|
|中断后读档→Boss→结算|10|10|一致|0|A0/0、B0/0|
|合计|42|42|一致|0|两端0/0|

本轮TowerMaster没有ERROR/WARN，所以无这类原文可贴；不把INFO里怪物名包含“Wurm”等文本误计成WARN。游戏日志也没有StateDivergence错误。正常普通战至少两场已完成；后续多场普通战同样沿地图出牌获胜。精英和Boss的控制台辅助手段已在范围中注明，不作胜率/强度判断。

只读辅助摘录（本轮新局去遗物、藏房间身份、信息条、战报）：

**before-cold / A**

```text
[10:30:38.993] INFO 塔主形象：顶栏头像换成塔主（1 处）
[10:30:39.282] INFO 塔主信息条：挂到原版顶栏下方
[10:37:24.621] INFO 塔主形象：藏起商店里的塔主角色
```

**before-cold / B**

```text
[10:30:39.326] INFO 塔主信息条：挂到原版顶栏下方
[10:37:24.621] INFO 塔主形象：藏起商店里的塔主角色
```

**interrupted / A**

```text
[10:57:13.521] INFO 塔主形象：顶栏头像换成塔主（1 处）
[10:57:13.633] INFO 塔主信息条：挂到原版顶栏下方
[11:09:31.123] INFO 塔主形象：藏起篝火边的塔主角色
```

**interrupted / B**

```text
[10:57:13.325] INFO 塔主信息条：挂到原版顶栏下方
[11:09:31.147] INFO 塔主形象：藏起篝火边的塔主角色
```

**final / A**

```text
[22:23:58.314] INFO 塔主形象：顶栏头像换成塔主（1 处）
[22:23:58.658] INFO 塔主信息条：挂到原版顶栏下方
[22:25:07.006] INFO 塔主形象：藏起篝火边的塔主角色
[22:26:04.121] INFO 塔主战报：塔主赢，8 场，召唤 8，陷阱 1，出牌 1
```

**final / B**

```text
[22:23:58.807] INFO 塔主信息条：挂到原版顶栏下方
[22:25:07.060] INFO 塔主形象：藏起篝火边的塔主角色
[22:26:04.242] INFO 塔主战报：塔主赢，8 场，召唤 8，陷阱 1，出牌 1
```

## 未覆盖与交接重点

- 没有0.0.43未结束存档，旧存档遗物移除未实测；已验证新局及后续deck同机制剥离。
- 旧角色按钮坐标的物理鼠标点未做，原版Select回调拒绝已做；地图投票跟随瞬间的标记没抓到，不能以静态图代替。
- 无mod对照未做，理由见上；正常重开箱有mod路径已无不同步。本轮最重要的是纠正此前MCP跳过本地开箱的测试路径。
- Claude优先检查大厅说明锚点、把玩家栏特殊显示放到最终RefreshVisuals之后、结算隐藏NCreatureVisuals而非只找NCreature。信息条召唤面板遮挡可按产品意图判断。
- 只提交本报告和ui044-*截图。原始日志、存档、反编译源码、游戏资源保留本地或未提交。
