# 0.0.45 测试结果

用户端日期：2026-10-08。分支 `claude/optimistic-rubin-hr3eit`，代码 `cf81d23`。日志时间戳按本机原文保留。只测试和只读调查，没有修改mod代码或生成新美术资源；不作平衡结论。

## 安装与范围

- 编译成功，0 warning / 0 error；109 个测试通过（49+60）。两端manifest/ping=0.0.45；A=100001房主/塔主，B=100002爬塔。共用安装目录，川换皮禁用，未操作用户自己的游戏进程。
- 仓库配置覆盖安装配置，SHA256 `CE7D223D1626984CFD04F2F8E54D0CF4819EC3B6BDEB2B783F4866E23D169301`。JSON未显式列master_relics，TestSettings默认true；实际API enabled=true、fail_reason=null，两端生成8类遗物、115类牌。
- 两端都正常进主菜单、新局。**没有启动/开局失败，因此没有改master_relics=false重试**。这不是遗漏回退：没有出现触发该回退的情况。
- 新局种子11888251569555196454，Overgrowth。前两场及后续普通战用tm_play/tm_end_turn正常打；不加B能量/抽牌，不用room/fight/win。问号原版战为快速结束开场效果测试用了原版网络控制台`damage 999`（伤害所有敌人）；最终精英战结束塔主先手后用`damage 999 1`杀B，验收结算。上述两场不算自然难度样本。
- 自然宝箱3选1拿迷雾香炉；其余7类用tm_master_relic各发一次，已自然拿到的香炉不重复发。逐件记录获得，两端拥有相同8件；开场效果是合并持有后的验证，没有逐个关闭其他遗物做独立隔离。
- 同进程读档后8件保留，完整退出两端重启读档后8件保留，并在下一场复验首回合效果。日志重启前已另存本地，没有提交原始日志/存档。

## 结论

|项目|结论|关键事实|
|---|---|---|
|启动/类型注册|通过|两端主菜单、新局正常；8种遗物类型、24条遗物本地化|
|卡图蓝底/透明缺陷|通过A原版手牌|可打与能量不足时都是不透明深色底；原卡框蓝色可出牌轮廓仍保留，这是轮廓不是图底|
|卡图视觉设计|用户不满意，待改|用户要求更有层次，不接受简单物件icon配廉价纯色/渐变底|
|自然宝箱遗物3选1|通过|迷雾香炉/礼帽/便当三个候选，选香炉后两端Player.Relics增加|
|跳过遗物选择|补测通过|发送正常联机遗物选牌指令后用原版skip；遗物不变，无异常。不是第二次自然宝箱|
|原版遗物栏/悬停|通过临时图标|塔主头像回退图，名称/说明正确；独立8件图标尚未制作|
|点击遗物详情|不通过|招财猫复现原版时间线锁定；用户截图已收录|
|8件效果|通过已覆盖范围|+1结算、+8拿到、首回合5张/3能量、敌人3格挡、B易伤1、B隐藏陷阱数、躲陷阱5金币|
|保存恢复|通过遗物保留及冷启动效果|同进程8件保留；冷启动后8件及首回合效果复验；同进程独立下一场效果未再单独测|
|大厅身份|通过主要项|说明完整在屏幕内、进阶不被压、两端房主显示塔主头像/塔主|
|读档大厅|通过A主要项，B头像见截图|A塔主说明完整，B保留自己角色背景，房主栏按塔主标识处理|
|原版结算隐藏|通过|只有倒地B，没有上一轮站立塔主铁甲；日志明确隐藏外观|
|地图投票头像|采样未见塔主|实际打开地图再投票，两端10组截图；短瞬间不能按截图证明每一帧|
|A地图位置塔主头像|未通过视觉验收|图中只有B多人位置标记，未看到新的塔主位置头像，单人NMapMarker启用条件需再查|
|StateDivergence|0|保留两段均无不同步事件|
|摘要完整逐行一致|部分通过|运行中的54/54一致；返回菜单取消选牌后A额外一条“无对局”，完整55/54不完全一致|

## 1. 卡图及用户美术要求

首场A手牌4张、能量2；激励可打（2费）。打出激励后能量0，其余1费卡均不可打，原版牌面仍显示不透明深紫底，没有透出地图背景或蓝色高亮底。

- 原图：[可出牌A](screenshots/ui045-cards-first-A.png)、[能量不足A](screenshots/ui045-cards-after-play-A.png)，两端对应B截图也已保存。
- 放大区域（仅裁切原截图、2倍最近邻放大，没有重画）：[可出牌图区](screenshots/ui045-card-art-playable-zoom.png)、[不可出牌图区](screenshots/ui045-card-art-unplayable-zoom.png)。
- 原版牌组：[A](screenshots/ui045-deck-A.png)含塔主行动牌和倒计时陷阱牌。[B](screenshots/ui045-deck-B.png)是B自己的原版牌组。B本机原版手牌不展示塔主手牌，不能把B底部普通牌当作塔主卡图验收；B可查询塔主数据、看到效果。
- 遗物候选：[自然宝箱A](screenshots/ui045-relic-choice-A.png)、[补测跳过候选](screenshots/ui045-relic-skip-candidate.png)。为不透明金色系底配塔主头像占位。

**用户原话（须交给Claude）**：

> 让claude设计一个更有层次感的背景，本来我们的卡牌就是一些简单的物件icon，背景再这么水就很丑很潦草了

修复“不透明”只解决渲染缺陷，不能代表完成美术设计。参考建议，供Claude把关、不强制采纳：保留原版卡框，在卡图内部用材质纹理、前后层次、局部光影和物件接触阴影承托icon；行动/陷阱/遗物可区分材质与色调。避免简单纯色块、重复廉价光圈、重特效盖住物件，也不能重新把透明背景塞回去导致蓝底透出。需要做一套真正的卡图背景设计，兼顾缩小到手牌时仍可辨认。

## 2. 自然宝箱、原版遗物栏和锁定问题

宝箱(2,8)自然弹出原版NChooseACardSelectionScreen，候选：

```text
0 TowerMasterRelicOfferFogCenser：遗物·迷雾香炉
1 TowerMasterRelicOfferMagicHat：遗物·魔术师礼帽
2 TowerMasterRelicOfferBento：遗物·怪物便当
```

选择0后，两端Player.Relics新增TowerMasterRelicFogCenser；原有招财猫、小金库保留。B正常开箱拿原版遗物、继续，未跳过B本地开箱流程。

原版栏图标目前都使用塔主头像：[A栏](screenshots/ui045-relic-inventory-A.png)，获得全部后：[真实悬停招财猫](screenshots/ui045-relic-hover-A.png)，名称“招财猫”和说明“每场战斗结算时，额外获得1召唤点。”正常。

跳过补测：本局已经拿到所有8件，后续自然宝箱会退回行动牌，没有第二个未持有遗物宝箱。通过tm_reflect调用 `MasterRewards.Send(List<string>,int,int,int,int)`，参数 `[["relic:lucky_cat","relic:magic_hat","relic:bento"],1,-9901,3,0]`，走同一个正常网络reward指令和原版选牌界面，tm_cards_pick skip=true。两端8件列表前后相同，无报错。**这是接口补测遗物选牌跳过，不是自然第二宝箱完整路径通过**。

### 用户反馈：点击被时间线锁定

> 现在遗物点进去是这样的，而且还没有设计遗物的图标样式

[用户截图](screenshots/ui045-user-relic-locked.png)显示原版“锁定——这个遗物需要在时间线中解锁才会在未来的游戏中出现”。用户截图没注明具体哪件；助手用原版GetInspectRelicScreen/Open对招财猫复现了同样页面：[助手复现](screenshots/ui045-relic-locked-reproduced.png)。悬停能读出名称/说明，不等于点击详情正常。

**只读原因和位置**：

- `decompiled/sts2/MegaCrit.Sts2.Core.Nodes.Screens.InspectScreens/NInspectRelicScreen.cs:159`，`void Open(IReadOnlyList<RelicModel>,RelicModel)` 从SaveManager生成UnlockState，:163/164填 `_allUnlockedRelics`。
- 同文件:274附近 `UpdateRelicDisplay()`，:277判断该集合是否包含relicModel.CanonicalInstance；不包含就换锁图和LOCKED_DESCRIPTION。
- `decompiled/sts2/MegaCrit.Sts2.Core.Unlocks/UnlockState.cs:63`，`IEnumerable<RelicModel> Relics` 只来自ModelDb.AllRelicPools.GetUnlockedRelics。
- `MasterRelics`故意不把这8件加入普通池，以防原版随机获得；给Pool属性返回一个共享池并不代表它真的在池的遗物列表里。因此已获得、已Seen，也仍未进入这份“解锁遗物”集合。

建议Claude针对MasterRelics.IsOurs处理原版详情的解锁/展示规则，保留普通遗物逻辑；**不要为了消除锁定把塔主遗物随便加入玩家普通随机池**。本轮没有用unlock all掩盖问题。

### 图标与旁路观察

8件仍全是塔主头像，这是本版Art.Get("relic_...")缺图时的回退，符合本轮临时显示检查，但不满足用户新的独立图标设计要求。需要给招财猫、小金库、礼帽、能量饮料、便当、黑名单、香炉、钱包分别设计可辨认图标，塔主头像只应是临时兜底。没有在本测试任务中擅自生成/替换资源。

A遗物栏还短暂保留已剥离的原版LostCoffer图标，而Player.Relics实际只有塔主遗物；冷启动重建栏后该残留消失。只读 `Player.RemoveRelicInternal(RelicModel,bool silent=false)`（Entities.Players/Player.cs:376）在silent=true时不发RelicRemoved，而NRelicInventory靠这个事件移除节点。建议检查StripRelics的静默删除是否需另外刷新UI。宝箱A还可看到原版铁甲手臂动画，本轮不把它计为完整身份替换已完成。

## 3. 8件遗物效果

两端均持有同顺序8件：lucky_cat、piggy_bank、fog_censer、magic_hat、energy_drink、bento、blacklist、stingy_purse；真实类型是各自TowerMasterRelic*子类，不是显示假图标。香炉来自自然宝箱，其余7件来自tm_master_relic。

|遗物|实测|限制/证据|
|---|---|---|
|lucky_cat|第一战结算额外+1，钱包最终26；提示内有招财猫+1|首战默认初始12，小金库+8至20，花1至19，原收入6+猫1=26；满30后猫实际+0符合上限|
|piggy_bank|账本立即+8到20，未超过30|日志明确+8；没有专门在余额接近上限时重新获取一件测试边界|
|magic_hat|首回合5张|未持有时首回合4张，持有后5；冷启动后复验5|
|energy_drink|首回合3能量|第一幕未持有时2，持有后3；冷启动后3|
|bento|开场每个存活敌人+3格挡|问号战两只敌人均有开场日志/画面；冷启动后一只敌人两端Block=3|
|blacklist|B有VulnerablePower、Amount=1|本机只有一个爬塔玩家，最高血选择成立；多玩家排序/同血平手未覆盖|
|fog_censer|A手里1/盖下0，B手里?/盖下?|B提示“塔主的迷雾香炉在冒烟……看不清盖了几张陷阱”|
|stingy_purse|未触发倒计时陷阱奖励5金币|普通原奖励10减半，B110→115两端一致；1回合打赢未到第5回合触发|

首回合效果截图：[A](screenshots/ui045-effects-first-A.png)、[B](screenshots/ui045-effects-first-B.png)。冷启动复验：[A](screenshots/ui045-cold-effects-A.png)、[B](screenshots/ui045-cold-effects-B.png)。B图同时捕获迷雾、便当、黑名单三条提示。精确读取冷启动后A/B：手牌5、energy3、combat.Enemies[0].Block=3、B第一个Power为VulnerablePower且Amount=1。

B真实悬停信息条：[截图](screenshots/ui045-hud-relic-hover-B.png)。tooltip原文包含：

```text
塔主遗物：招财猫、小金库、迷雾香炉、魔术师礼帽、能量饮料、怪物便当、黑名单、吝啬鬼钱包
```

**收入显示小问题**：首战余额实际增加7（原收入6+猫1），提示标题仍“战斗收入+6”，括号里却另列“招财猫+1”。wallet正确，标题的总数没含猫。`SummonPhase.cs`结算文本仍取income.Credited，cat单独增加后只拼进括号。建议标题加上cat，避免玩家以为算账不一致；这是显示核对，不是平衡结论。

### 保存与恢复

同进程回主菜单读档后8件列表完整，原版遗物栏可继续显示。随后完全退出A/B重启，多人读档后8件仍完整；下一战上述5张/3能量/+3格挡/易伤1/香炉隐藏均复验，两端一致。未独立在同进程读档后再打一场（立即进行了冷重启），所以该子项的效果复验不能算独立样本。小金库是拿到时加8，读档不再重复加8。

## 4. 身份复查

- 新大厅：[A](screenshots/ui045-lobby-joined-A.png)、[B](screenshots/ui045-lobby-joined-B.png)。A说明面板全部在屏幕内、位于左上，进阶说明和出发按钮不被覆盖。两端左上A一格显示塔主头像/“塔主”，B保留自己的角色。
- 多人读档大厅：[A](screenshots/ui045-load-lobby-A.png)、[B](screenshots/ui045-load-lobby-B.png)。A为完整塔主说明，B仍自己铁甲背景，房主栏不再把塔主当原英雄。
- 真实结算：沿地图进精英房(3,13)，召唤旧日雕像，先确认combat.in_progress=true，再结束塔主先手，对B执行网络控制台damage9991。两端自动战报正常；点“看原版结算”后：[A](screenshots/ui045-gameover-original-A.png)、[B](screenshots/ui045-gameover-original-B.png)，没有上一轮站立塔主铁甲，只有倒地B和敌人/塔主自绘立绘。对应隐藏日志附后。
- 测试脚本先误把问号(4,12)当战斗，实际它是商店；第一次damage请求排入队列后显示“This doesn't appear to be a combat!”。这次没有杀B、不算结算测试；后来在确认精英战进行中才正式执行。截图文件最终已用真实结算覆盖，报告不把商店截图算结算证据。
- 地图：打开原版地图后连续抓两端10组ui045-map-vote-{0..9}-{A,B}，再正常B投票/A跟随。采样未见塔主投票头像；短暂投票显示不是逐帧记录。[A静态位置](screenshots/ui045-map-position-A.png)只见B多人位置标记，没有塔主头像，**A位置头像不能判通过**。原版NMapMarker.Initialize(Player)（Nodes.Screens.Map/NMapMarker.cs:49）设置_isEnabled为Players.Count==1；联机时该单人marker本就不启用。补丁换其贴图不自动解决联机位置标记。建议Claude查多人位置图标真实路径，不把可见B的铁甲图标误认成塔主图标。

## 5. 摘要、ERROR/WARN及启动日志

日志分为冷重启前、冷启动后的最终进程；两段分别保留，原始全文不提交。

|日志段|A摘要|B摘要|完整逐行一致|运行中摘要一致|
|---|---:|---:|---|---|
|新局到同进程读档，冷启动前|39|39|是|39/39|
|冷启动到最终结算/回菜单|16|15|否|15/15|
|合计|55|54|不能说全日志一致|54/54|

多的一条是A在返回菜单取消未完成商店选牌后写出的：

```text
INFO 动作摘要 #24 threat:reward｜无对局
```

没有发现运行中同一条指令内容不同。不同步实际事件0，两端游戏日志无StateDivergence ERROR。取消清理后日志多一条，不应为了漂亮的“全过”删掉。

TowerMaster全部ERROR/WARN：冷启动前A/B均0/0；最终A ERROR1/WARN0，B ERROR0/WARN0。唯一错误是上述测试脚本返回主菜单取消仍打开的选牌，原文堆栈：

```text
[23:15:57.022] ERROR 塔主回合 #8 第1回合：塔主选牌失败（这次跳过）
System.Threading.Tasks.TaskCanceledException: A task was canceled.
   at MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NChooseACardSelectionScreen.CardsSelected()
   at MegaCrit.Sts2.Core.Commands.CardSelectCmd.FromChooseACardScreen(PlayerChoiceContext context, IReadOnlyList`1 cards, Player player, Boolean canSkip)
   at TowerMaster.MasterRewards.Execute(ThreatCommand c, Object action, String tag)
```

这不是启动模型注册失败，也不是宝箱自然选遗物失败；仍应建议Claude将预期取消单独处理为清理路径，避免玩家正常回菜单出现误导性“选牌失败”ERROR。本轮没有因此关闭master_relics。

所有以“塔主遗物”开头的日志行（同一信息不同进程保留；重复获取/开场效果另列）：

**before-cold / A**

```text
[22:50:46.560] INFO 塔主遗物：已生成 8 种遗物类型
[22:51:03.374] INFO 塔主遗物：本地化表 relics 补了 24 条
```

**before-cold / B**

```text
[22:50:46.542] INFO 塔主遗物：已生成 8 种遗物类型
[22:51:04.270] INFO 塔主遗物：本地化表 relics 补了 24 条
```

**final / A**

```text
[23:08:38.318] INFO 塔主遗物：已生成 8 种遗物类型
[23:15:57.932] INFO 塔主遗物：本地化表 relics 补了 24 条
```

**final / B**

```text
[23:08:38.490] INFO 塔主遗物：已生成 8 种遗物类型
[23:15:59.629] INFO 塔主遗物：本地化表 relics 补了 24 条
```

获得/首回合效果/结算隐藏的针对性原文：

**before-cold / A**

```text
[22:52:18.828] INFO 塔主回合 #1 第0回合：塔主获得遗物「招财猫」
[22:52:19.424] INFO 塔主回合 #2 第0回合：塔主获得遗物「小金库」
[22:52:19.430] INFO 塔主账本：小金库（测试接口），召唤点 +8（想加 8），现在 20
[22:53:39.512] INFO 塔主账本：招财猫，召唤点 +1（想加 1），现在 26
[22:54:00.190] INFO 塔主账本：招财猫，召唤点 +0（想加 1），现在 30
[22:55:58.599] INFO 塔主账本：招财猫，召唤点 +0（想加 1），现在 30
[22:56:11.292] INFO 塔主账本：招财猫，召唤点 +0（想加 1），现在 30
[22:59:26.032] INFO 塔主回合 #21 第1回合：塔主获得遗物「迷雾香炉」
[22:59:28.458] INFO 塔主回合 #22 第1回合：塔主获得遗物「魔术师礼帽」
[22:59:29.000] INFO 塔主回合 #23 第1回合：塔主获得遗物「能量饮料」
[22:59:29.525] INFO 塔主回合 #24 第1回合：塔主获得遗物「怪物便当」
[22:59:30.051] INFO 塔主回合 #25 第1回合：塔主获得遗物「黑名单」
[22:59:30.610] INFO 塔主回合 #26 第1回合：塔主获得遗物「吝啬鬼钱包」
[23:04:35.040] INFO 塔主回合 #28 第1回合：怪物便当，所有敌人 +3 格挡
[23:04:35.142] INFO 塔主回合 #28 第1回合：黑名单，玩家 100002 易伤 1
[23:05:45.256] INFO 塔主账本：招财猫，召唤点 +0（想加 1），现在 30
[23:05:50.569] INFO 塔主回合 #31 第1回合：怪物便当，所有敌人 +3 格挡
[23:05:50.670] INFO 塔主回合 #31 第1回合：黑名单，玩家 100002 易伤 1
[23:05:58.755] INFO 塔主账本：招财猫，召唤点 +0（想加 1），现在 30
```

**before-cold / B**

```text
[22:52:18.847] INFO 塔主回合 #1 第0回合：塔主获得遗物「招财猫」
[22:52:19.451] INFO 塔主回合 #2 第0回合：塔主获得遗物「小金库」
[22:59:26.050] INFO 塔主回合 #21 第1回合：塔主获得遗物「迷雾香炉」
[22:59:28.477] INFO 塔主回合 #22 第1回合：塔主获得遗物「魔术师礼帽」
[22:59:29.020] INFO 塔主回合 #23 第1回合：塔主获得遗物「能量饮料」
[22:59:29.544] INFO 塔主回合 #24 第1回合：塔主获得遗物「怪物便当」
[22:59:30.070] INFO 塔主回合 #25 第1回合：塔主获得遗物「黑名单」
[22:59:30.632] INFO 塔主回合 #26 第1回合：塔主获得遗物「吝啬鬼钱包」
[23:04:35.021] INFO 塔主回合 #28 第1回合：怪物便当，所有敌人 +3 格挡
[23:04:35.123] INFO 塔主回合 #28 第1回合：黑名单，玩家 100002 易伤 1
[23:05:50.528] INFO 塔主回合 #31 第1回合：怪物便当，所有敌人 +3 格挡
[23:05:50.630] INFO 塔主回合 #31 第1回合：黑名单，玩家 100002 易伤 1
```

**final / A**

```text
[23:11:02.246] INFO 塔主回合 #3 第1回合：怪物便当，所有敌人 +3 格挡
[23:11:02.401] INFO 塔主回合 #3 第1回合：黑名单，玩家 100002 易伤 1
[23:11:17.494] INFO 塔主账本：招财猫，召唤点 +0（想加 1），现在 30
[23:20:02.453] INFO 塔主回合 #13 第1回合：怪物便当，所有敌人 +3 格挡
[23:20:02.554] INFO 塔主回合 #13 第1回合：黑名单，玩家 100002 易伤 1
[23:20:04.817] INFO 塔主形象：结算画面藏起塔主角色外观
```

**final / B**

```text
[23:11:02.120] INFO 塔主回合 #3 第1回合：怪物便当，所有敌人 +3 格挡
[23:11:02.253] INFO 塔主回合 #3 第1回合：黑名单，玩家 100002 易伤 1
[23:20:02.595] INFO 塔主回合 #13 第1回合：怪物便当，所有敌人 +3 格挡
[23:20:02.728] INFO 塔主回合 #13 第1回合：黑名单，玩家 100002 易伤 1
[23:20:04.930] INFO 塔主形象：结算画面藏起塔主角色外观
```

## 交接给Claude

1. 优先修自定义遗物详情误锁：原版Inspect界面的unlock集合不包含塔主遗物，已经明确复现，不需要用户解锁时间线或控制台unlock all。
2. 给8件遗物设计各自的图标；现有全部塔主头像只作为兜底。顺带检查静默移除原版遗物后UI残留LostCoffer。
3. 按用户原话重做有层次、有材质与光影的卡图背景，保持不透明，保留原版卡框；不要把渲染缺陷修复等同于美术完成。
4. 修收入标题不含招财猫额外收益；找联机地图实际位置标记路径；把正常选牌取消从ERROR分离出来。

未覆盖：启动关闭master_relics对照不触发所以没做；第二次自然遗物宝箱跳过未做（原版联机UI已补测）；多爬塔玩家黑名单排序、piggy_bank近上限获取边界、同进程读档后独立一场效果。所有这些均不冒充通过，不作胜率/强度结论。只提交报告与ui045-*截图。
