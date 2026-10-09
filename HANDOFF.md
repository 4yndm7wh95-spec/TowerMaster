## 0.0.44 实测 → 0.0.45：身份收尾、塔主遗物、卡图不透明底（2026-10-09）

0.0.44 实测（`docs/ui-044-result.md`）：塔主遗物移除、战后无 +6、商店/篝火/顶栏通过；信息条位置通过；宝箱冷读档正常流程不复现（上轮是测试跳过了 B 本地开箱）。
不通过：大厅说明面板位置出界；大厅玩家栏（RefreshVisuals 覆盖了 SetCharacter 后的修改）；结算画面（原版搬的是 NCreatureVisuals）；地图投票标记。
用户新反馈：塔主牌卡图底色是很亮的蓝、不能打出时透明——原因是我们的图透明底，透出卡后面的「能打出」蓝色高亮。
0.0.45：
- 大厅说明面板固定在左上；玩家栏改挂 NRemoteLobbyPlayer.RefreshVisuals；多人读档大厅（NMultiplayerLoadGameScreen）房主同样换成塔主说明。
- 结算画面：从战斗房间记下塔主 NCreature.Visuals，每帧藏。地图：NMapPoint.ShouldDisplayPlayerVote 对塔主返回 false，塔主本机 NMapMarker 换塔主头像。
- 卡图：Art.Card 把透明图标合成到不透明深色底上（行动牌紫、陷阱青、遗物金），尺寸取原卡图框贴图。
- 塔主遗物 8 件（MasterRelics）：RelicModel 子类运行时生成（与塔主牌同程序集）；Pool/Icon/IconOutline/BigIcon 前缀；loc 表 relics；RelicCmd.Obtain 各端执行。
  宝箱改为 3 选 1 遗物（候选是「遗物牌」走原版选牌界面，KindRelic=3），遗物没开成或拿完退回送牌。StripRelics 不去掉塔主遗物。
  效果：招财猫（结算 +1 点）、小金库（+8 点）、魔术师礼帽（首回合 +1 抽）、能量饮料（首回合 +1 能量）、怪物便当（首回合敌人 +3 格挡）、
  黑名单（首回合生命最高玩家易伤 1）、迷雾香炉（玩家看不到陷阱张数）、吝啬鬼钱包（躲陷阱金币减半）。信息条悬停列出塔主遗物。
  测试接口 /master/relic（MCP tm_master_relic）。图标 prompt 见 docs/art-assets.md（没有图用塔主头像）。

## 0.0.43 实测 → 0.0.44：塔主身份（大厅、商店、篝火、顶栏、结算）、去掉塔主角色遗物、信息条位置（2026-10-08）

0.0.43 实测（`docs/ui-043-result.md`）：开战采样未见塔主；战后满血；战报自动弹出通过；面板重开通过；信息条数据正确。
问题：战后仍有绿色 +6（铁甲燃烧之血 AfterCombatVictory 给塔主 Heal）；信息条按 NTopBar.Size.Y（整屏）摆到屏幕外；
商店、顶栏头像、结算画面、跑图历史仍露出塔主角色；冷读档恢复宝箱后奖励编号 A=1,2 / B=0,1 不同步（待定位）。
0.0.44：
- MasterDeck.StripRelics：新局和每次 deck 指令时用 Player.RemoveRelicInternal(silent) 去掉塔主的原版遗物（各端同时）。
- 信息条按顶栏子控件实际下沿摆（量不出按 84）。
- MasterPresence：每帧藏商店（NMerchantRoom.PlayerVisuals/_players 同序）、篝火（NRestSiteCharacter.Player）的塔主角色；结算画面里的塔主 NCreature；
  塔主本机顶栏头像换成塔主头像（NTopBarPortrait.Initialize 后），关掉头像角色说明（NTopBarPortraitTip.ShowTip）。
- MasterLobby：房主大厅自动选第一个可用角色后锁住，藏角色按钮/介绍/背景，放「你是塔主」说明；所有端角色按钮不显示房主选择标记，玩家栏房主格显示塔主头像和「塔主」。
未做：跑图历史的塔主图标；先古之民里塔主仍能选原版祝福（0.0.46 塔主祝福一起改）。

## 0.0.42 → 0.0.43：塔主开战闪现、战后回血特效（2026-10-08）

用户反馈：塔主遗物、事件/先古之民塔主玩法是必做；随便选角色当塔主很怪；开战塔主角色一闪而过、战后凭空回血特效。
0.0.43：MasterPresence 挂 NCreature._Ready，塔主角色节点一建好就藏（原来每 10 帧轮询）；ReviveBeforeCombatEnd 对塔主直接写回满血、跳过原版复活（不播回血特效、不发 Revived 事件）。
方案见 `docs/master-identity-relics-events-plan.md`（塔主身份、塔主遗物、事件镜像），等用户确认后分 0.0.44–0.0.46 做。

## 0.0.41 实测 → 0.0.42：塔主信息条、塔主战报、面板重开（2026-10-08）

0.0.41 实测（`docs/ui-041-result.md`）：图鉴式预览通过（53 只全部完整，三只散件修好，NCreature 失败 0 次）；内讧、盲盒提示排队、筛选按钮悬停通过；23/23 摘要一致。
问题：同一个召唤面板 Close 后再 Show（测试接口压力调用）碰到已释放的筛选按钮，Close 解绑了没绑过的 process_frame。
0.0.42：
- 面板重开先清掉旧按钮登记、会话事件先解再绑，Close 只解绑真的绑过的 process_frame；取景开始前再关一遍后加的粒子。
- 塔主信息条（MasterInfoHud）：挂在原版顶栏（NTopBar）下方右侧。手里陷阱张数（deck 指令里 trap: 牌数）、本场盖下（trap_info）、已触发（trap 指令，悬停看名字）、本幕候选 Boss（SummonPhase.PublicBossNames，各端自己算）。
- 塔主战报（RunReport 在 Core，可测；MasterStats 按种子记陷阱触发和塔主出牌到 *.stats.json；召唤和 Boss 从 PlanStore 清单读；RunReportPanel 挂 NGameOverScreen._Ready，1.2 秒后弹）。测试接口 /master/report（MCP tm_master_report：won/show/close）。
- 掉线：塔主=房主，原版房主断线整局断开，靠读档恢复（已验证）；挂机有限时配置。设计文档对应三项勾掉。

## 0.0.40 实测 → 0.0.41：图鉴式预览、内讧、筛选按钮、提示排队（2026-10-08）

0.0.40 实测（`docs/ui-040-result.md`）：隐藏分页取景修好（53 只候选正常）；淤泥旋螺、缩小甲虫正常；黏液大礼包、荆棘丛、金身、摇人通过；盲盒两端结果一致；27 条摘要一致。
不通过：化石追踪者、幽灵船、鬼祟珊瑚群和原版图鉴并排对照仍缺主体；内讧抛参数类型异常（CreatureCmd.Damage 挑到了群体重载）；用户反馈筛选按钮悬停变形；连打盲盒提示重叠。
0.0.41：预览改走原版图鉴流程（可变模型 + Rng + SetUpForCombat → Creature(NullCombatState) → NCreature.Create → SetupForBestiary，放进 Node2D 架子取景），失败自动退回旧做法并记 WARN；
Damage 只挑单体重载（加了测试，假游戏里群体重载在前）；筛选按钮 normal/hover/pressed 边框圆角内边距一致；提示按行排开。

## 0.0.39 实测 → 0.0.40：隐藏分页取景、粒子、测试加牌（2026-10-08）

0.0.39 实测（`docs/ui-039-result.md`）：劫掠者、旧日雕像等缺头/裁切修好；测试接口拦截通过；请客、起哄两端一致；26 条摘要一致。
问题：选怪面板默认只显示本幕，其它幕卡片隐藏时不渲染，取景量到空图就「什么都没画出来」定格（第二、三幕 20 只怪切过去很小）；淤泥旋螺被粒子柱撑成小点；
化石追踪者、幽灵船、鬼祟珊瑚群仍像散件（测试助手查了原版图鉴流程：NBestiaryLayoutDefault.Setup 用完整 NCreature + idle_loop，待对照图鉴实图判断是否本来就这样）；六张娱乐牌没拿到、原版 card 命令找不到塔主牌。
0.0.40：卡片隐藏时不量、显示出来再等 20 帧开始；空图重试 10 次再放弃；预览里关掉粒子特效；测试接口 `/master/grant`（MCP `tm_master_grant`）给塔主牌组加指定的牌（记账本、两端同步，下一场起能抽到）。
待归因：爬塔玩家端原版 NMultiplayerPlayerState.TweenLocationIconIn 用了已释放纹理（本 mod 只把塔主那一项设为不可见，不释放节点）。

## 0.0.38 实测 → 0.0.39：选怪预览重做取景、娱乐牌（2026-10-08）

0.0.38 实测（`docs/ui-038-result.md`）：重开游戏读档、同进程读档、商店、精英奖励、塔主出牌、摘要一致都通过。
不通过：选怪界面三幕多只怪仍缺头/裁上半身/散件/过小；测试接口拦截放在了查手牌而不是出牌/结束回合上。用户要求塔主牌更娱乐、可以恶搞。
0.0.39：
- 选怪预览取景重做（`SummonPanel.FitAndFreeze`）：旧的「是否被裁」用去掉 1.5% 像素后的范围判断，细长的头被当零星像素去掉、被裁看不出来，放大后也不再检查。
  现在：先按原版顺序建动画控制器再套皮肤；外观 Ready 后按点击框把怪缩到 30% 放正中；等约 0.8 秒；隔几帧量 3 次取并集（几乎不去零星像素），碰边就缩一半重量；
  放大到 88% 后再量，碰边就再缩 15%（最多 5 次）；有缩放/校正的怪在日志里记一行「取景 …」。
- 测试接口：拦截移到 /combat/play、/combat/end_turn（爬塔玩家在塔主回合中）；爬塔玩家读档后的「等不到读档完成」改成 Info。
- 8 张娱乐牌（请客、黏液大礼包、荆棘丛、金身、摇人、内讧、惊喜盲盒、起哄），见 `docs/master-cards-plan.md` 第 9 节。卡牌类型 99 种。

## 0.0.37 实测 → 0.0.38：重开游戏读档、选怪界面的怪物图（2026-10-08）

0.0.37 实测（`docs/ui-037-result.md`）：商店买陷阱/行动牌各扣 6、同进程读档（商店/宝箱/休息处）全部正确、精英奖励、119 条摘要一致、纹理异常未再现。
未过：**关掉游戏重开再读档**，账本恢复了但没重发牌组（删掉的易伤回来了）——原版 `SetUpSavedMultiplayer` 是异步的，后置补丁运行时新进程还没设好联机身份，被当成不是塔主跳过。
用户反馈：选怪界面很多怪缺头、零件散开。原因：只调了 `MonsterModel.CreateVisuals`，没像战斗里那样 `NCreatureVisuals.SetUpSkin(model)`、`MonsterModel.GenerateAnimator(SpineBody)`（皮肤没套、骨骼动画没跑）。
0.0.38：读档后等到「是房主且有对局」（最多约 20 秒）再读账本、重发牌组；选怪界面的怪物外观进场景后先套皮肤、启动动画再取景定格；测试接口在塔主回合里拒绝爬塔玩家出牌请求（0.0.37 测试脚本重复提交堆了一串）。

## 0.0.36 实测 → 0.0.37：商店价格、读档后账本（2026-10-08）

0.0.36 实测（`docs/ui-036-result.md`）：宝箱 3 选 1、休息处删牌/跳过、商店跳过、玩家同时操作、筹谋/弱点暴露/迷雾效果、91 条摘要一致都通过。两处失败：
- 商店买不了：价格放在 ThreatCommand.Seed，而 ThreatPhase.Send 统一把 Seed 改成本局种子 → 价格变成 -1928408949。→ 新字段 `Price`。
- 读档后账本没恢复（RunLifecycle 清了内存，要到下一次召唤才读）：同房间重复弹选牌、误报召唤点不够、新拿的牌存不下（Wallet 为 null 时 Save 直接返回）、牌组回退。
  → `MasterLedger.EnsureLoaded()`（按当前种子读账本）在所有非战斗选牌入口、记账、花点前调用；`SetUpSaved*` 之后立即读账本，界面稳定后按账本重发一次牌组；换局清 `MasterDeck._lastSent`。
已知未归因：爬塔玩家端两次原版 NMultiplayerPlayerState 位置图标 Tween 用了已释放的纹理（ObjectDisposedException）。

## 0.0.35 实测 → 0.0.36：宝箱、商店、休息处里的塔主（2026-10-08）

0.0.35 实测（`docs/ui-035-result.md`）通过：四次正常精英奖励都在最上层自然弹出，选牌/跳过/跟随/存档正常，衰竭、复苏、坚壁效果两端一致，92 条摘要一致。未覆盖：迷雾、弱点暴露、筹谋效果、复苏多目标。
0.0.36（用户：平衡实测等 mod 全部做好再做）：非战斗房间也给塔主事做，全部用原版「选一张牌」界面——宝箱房塔主免费 3 选 1；商店花 6 召唤点买 1 张（2 行动牌 + 1 陷阱）；休息处删 1 张行动牌（至少留 5）。见 `docs/master-cards-plan.md` 第 8 节。
测试项目加了 `NoGodotUi` 模块初始化（所有界面钩子换成空操作，防止测试进程崩溃）；测试接口序列化失败时退回文字描述不断开。

## 0.0.34 实测 → 0.0.35：塔主奖励不再被原版奖励界面盖住（2026-10-08）

0.0.34 实测（`docs/ui-034-result.md`）：75 种牌/150 条本地化、隐藏顶栏生命、选牌入牌组、跳过、存档后同场不重复、鼓动效果都通过；
**阻塞**：精英胜利后塔主的 3 选 1 先压进覆盖栈，原版 NRewardsScreen 随后压在上面，选牌被盖住，塔主跟随移动排在选牌动作后面，两端走不了（稳定复现两次）。
0.0.35：房主等原版奖励界面进了 NOverlayStack 之后（+15 帧，最多约 5 秒）才发 reward 指令，选牌界面压在奖励界面上面；
测试接口 /cards、/cards/pick 支持原版「选一张牌」界面（SelectHolder 选、OnSkipButtonReleased 跳过，MCP tm_cards_pick 加 skip）；鼓动说明去掉重复的「消耗。」。

## 0.0.33 实测 → 0.0.34：塔主牌成长（2026-10-08）

0.0.33 实测（`docs/ui-033-result.md`）全部通过：中央面板去掉、原版结束回合按钮出现、三条限制（第二次减益、力量上限、第二次战吼）在能量足够时被拒。用户：平衡实测等 mod 全部做好再做。
0.0.34：精英/Boss 战后塔主用**原版选牌界面** 3 选 1 拿新塔主牌（`MasterRewards`，7 种奖励牌：坚壁、复苏、衰竭、迷雾、弱点暴露、筹谋、鼓动，见 `docs/master-cards-plan.md` 第 7 节）；
卡牌类型 75 种（本地化 150 条）；塔主屏幕隐藏顶栏生命（塔主回合里会显示 1/80）。

## 0.0.32 实测 → 0.0.33：去掉挡手牌的面板，用原版结束回合按钮（2026-10-08）

0.0.32 实测（`docs/ui-032-result.md`）：**原版手牌出牌通了**——4 张原版手牌节点、加固/易伤/脆弱/激励两端生效、打出进弃牌堆、原版结束回合动作结束先手、下回合 1 能量 4 张、先手外塔主生命 0、三场自然胜利、同格投票跟进；用户亲手试过鼠标拖牌可用。
用户反馈：「这个挡住手牌了 能量不用显示的吧，结束回合也不应该放在这里」。截图里原版右下的结束回合按钮也没出现（回合开始时塔主还死着，原版把它藏了）。
0.0.33：塔主牌模式下不显示中央自建面板（能量看原版左下、结束用原版按钮）；塔主救活后在塔主屏幕上再调一次 `NEndTurnButton.OnTurnStarted`（失败就 `AnimIn`），让原版结束回合按钮出现。左上玩家信息保留。
未覆盖：同一玩家第二次减益、力量上限、第二次战吼。

## 0.0.31 实测 → 0.0.32：塔主回合里临时「活着」（2026-10-07）

0.0.31 实测（`docs/ui-031-result.md`）：开局正常、原版牌组按钮里是 9 张塔主牌、挑陷阱入牌组、存档读档一致 —— 牌组部分通过。
战斗出牌三个问题，前两个都因为塔主「死着」：原版抽牌跳过死者，我们手动搬的牌没有界面节点（手牌看不见）；`CardModel.OnPlayWrapper` 遇到死亡牌主直接返回（能量扣了效果没有）；原版结束回合没接上；弃牌用错了类（应为 `CardCmd.Discard`）。
0.0.32：塔主回合 begin 时把塔主生命直接写成 1（不走复活流程），原版抽牌、手牌节点、出牌效果都按活人走；end 时弃牌、写回 0、设为已准备。塔主回合里爬塔玩家暂停、怪物不行动，这段时间活着不会被打。
`EndPlayerTurnAction.ExecuteAction` 前置补丁：塔主回合中、动作属于塔主时不执行原版，房主改发 end 指令。弃牌改 `CardCmd.Discard`。

## 0.0.30 实测 → 0.0.31：塔主牌登记进对局状态（2026-10-07）

0.0.29/0.0.30 实测（`docs/ui-029-result.md`、`docs/ui-030-result.md`）：塔主牌注册成功（54 种、108 条本地化），但**开新局时两端在生成地图处空引用**（RunState.Contains 读 card.Owner.IsActiveForHooks）。测试助手查明：新牌只放进了牌组，没经 RunState 登记，Owner 为空。
0.0.31：`MasterDeck.Replace` 改用 `RunState.CreateCard(规范卡, 塔主)`（克隆、登记、设归属）再放进牌组，旧牌 `RunState.RemoveCard` 注销。假游戏的 `PopulateDeck` 改成和原版一样不设归属，并加了「牌组里的牌都要有归属、都已登记」的检查。
另：换局清掉自动驾驶的投票去重缓存（新局第一步和上一局同格时塔主不跟）；召唤面板关两次不再重复解绑 ProcessFrame。
重复订阅回归通过（三场各一条收入、无重复塔主回合）。

## 0.0.30：塔主牌默认开、开不成就明说（2026-10-07）

用户截图：游戏里仍是旧的塔主回合面板（底部行动卡、「选一张行动卡」、威胁点 2）——说明那次运行塔主牌模式没开成（设置文件里没有 master_cards，或启动注册失败被静默退回）。
0.0.30：`master_cards` 代码默认 true（旧设置文件没写也开）；启动日志写「塔主牌（原版手牌出牌）：设置 master_cards=…」；
没开成时塔主回合面板状态栏红字写原因，第一次塔主回合弹提示；`/master/deck` 返回 `fail_reason`。

## 0.0.29：塔主战斗中用原版手牌出牌（第二阶段，方案 A）（2026-10-07）

用户确认要「战斗中用原版手牌拖牌打出」并让我决定方案。选 A：塔主仍「死」着，只放开抽牌、能量、出牌。细节见 `docs/master-cards-plan.md` 第 6 节（`MasterHand`）。
`towermaster.test.json` 默认开 `master_cards`。接口 `/master/hand`、`/master/play`（MCP `tm_master_hand`、`tm_master_play`）。未在真游戏里验证。

## 0.0.27 实测 → 0.0.28：修重复订阅；塔主真实卡牌第一阶段（2026-10-07）

0.0.27 实测（`docs/ui-027-result.md`）：换局清理生效、新局账本 12 点 0 场、三场正常对局两端「动作摘要」34 行完全一致、无不同步。
**新问题**：换局后战斗收入执行两次、塔主回合重复开（读档后三次）。原因（测试助手查得准）：CombatManager 是进程单例，`ResetRun` 把「已订阅」标记清了却没摘掉旧回调，下一场又挂一遍。
0.0.28：`ResetRun` 不再清订阅标记；订阅前先 `RemoveEventHandler` 同一个回调（双保险）。另外面板延迟加入场景时先检查是否已关闭（Godot「p_child is null」），塔主回合面板关两次不再重复解绑 ProcessFrame（「disconnect a nonexistent connection」）。

**塔主真实卡牌**：测试助手完成 13 条接口调研（`docs/master-cards-research.md`）。第一阶段实现（开关 `master_cards`）：启动时注册 54 种真 CardModel、新局塔主牌组换成塔主牌、挑陷阱/战后同步牌组、原版牌组界面可见、卡图换成 art 图、说明进本地化表。战斗中用原版手牌出牌是第二阶段，见 `docs/master-cards-plan.md` 第 5 节。
接口：`/master/deck`（MCP `tm_master_deck`）。状态摘要加了每名玩家牌组张数 `k`。

## 0.0.26 实测 → 0.0.27：换局清理、同步排查日志、塔主真实卡牌方案（2026-10-07）

0.0.26 实测（`docs/ui-026-result.md`）：选陷阱网格一行 7 张、完整句式文案、新默认值都对；原版 Dazed 中文就是「晕眩」。问题：
- 快速推进（玩家回合没就绪就 win、地图投票排队）后第三场开局 StateDivergence，首个不一致在本 mod 的动作之后。原因未定：本 mod 的召唤和塔主指令共用一个动作类型，日志看不出是哪条。→ 0.0.27 每条本 mod 动作执行后两端各记一行「动作摘要 #ID 操作｜层、回合、每只敌人血/格挡/能力、每名玩家血/格挡/金币/能量/牌堆数/能力」（`StateDigest`），下次对比日志能定位第一个不一样的值。
- 断线后同一进程新开一局：仍是「塔主回合暂停中」、账本显示上一局的点数和场数。→ `RunLifecycle` 挂 `RunManager.CleanUp` 和 `SetUpNew/Saved*`：关面板、恢复暂停的队列、清召唤/塔主回合/陷阱的本局状态、账本只清内存。
- **用户纠正需求**：要塔主真正的卡牌（游戏里的 CardModel，原版牌组界面能看到、原版手牌和拖拽目标打出），不是借卡框的面板。方案和要调研的 13 个接口问题见 `docs/master-cards-plan.md`；等测试助手查完反编译源码再实现。

## 0.0.25 实测 → 0.0.26：平衡复审、选陷阱版面、原版式卡牌文案（2026-10-07）

0.0.25 实测（`docs/ui-025-result.md`、`docs/balance-review-request.md`）：原版卡框能用（模板 Alchemize）、目标按钮在头顶、冷却有效、默认隐藏复活后事件不再报错。问题：选陷阱候选竖排成一列超出屏幕（HFlowContainer 在 CenterContainer 里没有宽度）；卡面文案太简略；机器人不会玩，用户停掉机器人平衡测试，要我按理解复审数值；第二幕选陷阱停留几分钟后塔主端 D3D12 设备丢失（未能归因）。

0.0.26：
- **平衡复审**（`docs/balance-review.md`，全部是「设计暂定」）：普通房上限 1.6→1.35，精英房 1.5→1.3、折扣 0.7→0.85、另加 4→3，Boss 另加 2.0→1.0；战果每 15 血 +1、每场最多 +2；击倒 +5→+3；威胁点**按回合解锁**（第 1 回合 2/3/3，之后每回合 +1）、开局保护 3 场最多 2 点；加力量 1/1/2、每只上限 2/3/4；躲过 15→10，空陷阱翻开不给金币，第 1 回合公开盖了几张；硬化 4/6/8、窒息门槛 5、鼓舞 1/1/2、狂怒 1/2/2、倒计时第 5 回合 25/30/35%。基础收入、开局 12、跨幕惩罚不动。
- **缺陷修复**：陷阱加力量原来绕过力量上限（现在房主按每只截断，指令带 `Monsters`/`Amounts`）；力量/回血按 `Enemies` 下标记账，怪死后下标变（现在 `ThreatPhase.KeyOf` 固定编号）；`balance_sim.py` 把暗港当第二幕（现在密林/暗港 → 蜂巢 → 荣耀）。
- **选陷阱界面**重写：上（标题、统计、一行提示）/ 中（网格，列数和卡大小按屏幕算，7 张一般一行放下，放不下分行、再不行滚动）/ 下（手里已有、确认）三段固定；卡只建一次，选中/取消只改边框、标记、明暗（不再每次点击重建 7 张原版卡场景）；悬停放大。
- **卡牌文案学原版**：陷阱卡「当一名玩家在一个回合内打出第 3 张技能牌时，给予该玩家 2 层脆弱。」；行动卡改名加固/治疗/激励/战吼/虚弱/易伤/脆弱/晕眩，说明「选择一名敌人，使其获得 6 点格挡。」等；关键词金色；限制条件放悬停提示（`TrapDef.Rules`、`ActionDef.Rules`）。行动卡放大到 0.46 并悬停放大 1.6 倍。
- 「眩晕」统一改称「晕眩」（原版 Dazed 的中文名待实测核对）。
- 接口：`/threat` 多了 `points_total`、`points_remaining`；日志「测试3 换幕」的数字改称「原版参数」（不是幕数）。

## 0.0.24 实测 → 0.0.25：自由选陷阱、原版卡框、平衡测试工具（2026-10-07）

0.0.24 实测（`docs/ui-024-result.md`）：塔主全身像在右侧、不复活流程能走完；狂怒、躲过、宝箱、Boss 追加、同步都通过。问题和用户要求：
- 塔主一直死着 → 原版事件走「死亡玩家」分支报 ERROR（EventModel.BeginEvent:207–210）。**改为默认让塔主按原版复活**（他在战斗和玩家列表里都隐藏了，玩家看不到），开关 `master_stay_dead`。
- 目标按钮在玩家胸前 → 改取 Hitbox 和 Visuals.Bounds 里更高的上沿，用画布变换换算到屏幕。
- 用户不要固定陷阱包 → **自由选陷阱**（`TrapDraft`）：每幕随机 6 种候选 + 空陷阱，预算 5（每种花 0~3），最多挑 3 张，手牌上限 6，手里同种不重复，新一幕手里的陷阱自动升级；上一场盖过的种类这一场冷却。击倒奖励抽手里没有的。
- 用户要原版卡牌框架 → `VanillaCard`：运行时实例化游戏的 card.tscn，套一张原版无色技能卡的卡框，再改标题、说明、费用、类型字、插画；失败退回自绘。行动卡和选陷阱都用它。**没在真游戏里验证过**，风险：NCard 套模型后可能延迟刷新文字、卡框颜色不对等。
- 用户要平衡测试 → `BalanceLog`（每场一行 JSON）、`towermaster.config.json`（不改代码调数值，`ModEntry.LoadConfig`）、`scripts/balance_sim.py`（离线经济模拟）、MCP `tm_autoplay`（固定策略机器人）、`tm_balance`（汇总）。方案见 `docs/balance-plan.md`。
- 接口：/traps/draft/select、/traps/draft/confirm、/threat/ui（选中/取消行动卡，截图用）、/config、/logs source=balance；/combat/hand 加 type、hp、alive。

## 0.0.23 实测 → 0.0.24：交互改版 + 塔主独立形象（2026-10-07）

0.0.23 实测（`docs/ui-023-result.md`）：狂怒修好、躲过奖励、同步都通过；18 张美术资源已生成提交（`mod/TowerMaster/art/`）。用户反馈：面板「挺一般」，要更舒服、门槛更低的交互；召唤要按幕分类、按费用筛选；陷阱包做成可点开的卡牌包；塔主尽快变成站在怪物一侧的独立形象，不再是死掉的英雄、战后不复活回血。

0.0.24：
- **塔主形象**（`MasterPresence`）：战斗中隐藏塔主那名玩家的角色节点和左上角玩家列表里的塔主；战斗房间右侧怪物身后放 `art/master_figure.png`（没有就用头像），轻微浮动，塔主行动/陷阱触发时闪一下。战后不复活塔主（`Player.ReviveBeforeCombatEnd` 对塔主跳过，开关 `master_stay_dead`，默认开）——**风险**：塔主一直死着可能影响选路/事件/休息流程，要实测。
- **塔主回合改成出牌式**（`ThreatPanel` 重写）：底部一排行动卡（图标、名字、◆ 花费），点卡后战场上能作用的怪/玩家头顶出现目标按钮（位置取 NCombatRoom.CreatureNodes 的 Hitbox），点目标施放；右键取消。左上小面板只放玩家血量、状态、手牌。
- **召唤面板**：幕分页（默认本幕）、费用筛选（1/2/3/4+）、只看精英；陷阱改成带图小卡；侧栏「总花费」大字 + 明细一行 + 怪物上限条 + 剩余。
- **陷阱包**：三个合着的包（包图、名字、风格）→ 点开展开成一排陷阱卡（图、名字、条件 ↓ 效果）→「就选这包」/「换一个看看」。
- 美术第二批：`master_figure` 全身像、8 个行动卡图标，prompt 在 `docs/art-assets.md`。
- 没有用原版的卡牌节点（NCard 需要在游戏里注册自定义卡牌模型，风险大），而是在我们的界面里做成卡牌样式和「选卡→点目标」的原版式操作。

## 0.0.22 实测 → 0.0.23：狂怒修复 + 界面重做（2026-10-07）

0.0.22 实测（`docs/traps-result.md`）：出牌钩子挂上了（`MegaCrit.Sts2.Core.Hooks.Hook.AfterCardPlayed(ICombatState, PlayerChoiceContext, CardPlay)`）；泥沼、再生、倒计时、鼓舞、碎甲、硬化、破绽、躲过奖励、读档、第二幕选包都通过；无 StateDivergence。
狂怒没触发：原版死掉的怪会从 `CombatState.Enemies` 里移除（CreatureCmd → CombatState.RemoveCreature），按 IsDead 数不到。改为记住见过的每只怪，列表里没了（且不在 EscapedCreatures）或 IsDead 都算死亡。

用户反馈界面太丑、字太多、太挤，0.0.23 重做三个面板：
- 召唤面板：顶栏（标题、房间、开局保护、召唤点）；左边怪物网格（小卡：形象 + 名字，价格/数量/精英/幕数是角标，说明在悬停提示）；右边固定侧栏（阵容、陷阱开关、花费条、剩余、错误、确认/按原版）。
- 塔主回合面板：更窄；每只怪/玩家一张紧凑卡（名字+数值一行、按钮一行，花费用 ◆），手牌是小标签，说明在悬停提示。
- 陷阱包面板：三张大卡（整张可点），每张陷阱一行「名字 + 短条件 → 短效果」。
- 提示文字全部缩短。
- 可选美术资源：`Art.cs` 从 mod 目录 art/*.png 读，缺了退回文字；清单和生图 prompt 在 `docs/art-assets.md`（用户说可以让 Codex 用 imagegen 生成）。

## 陷阱牌（2026-10-07，0.0.22，待实测）

用户让我继续做。说明和测试点见 `docs/traps-plan.md`。
- 规则库 `Traps.cs`（TrapCatalog、TrapTracker）；mod `TrapPhase`、`TrapPackPanel`、召唤面板陷阱区、`MasterLedger` 存手里陷阱和选包记录。
- 效果走 ThreatPhase 指令：trap / trap_info（CombatPlayPhaseOnly）、trap_dodge（NonCombat）。
- 出牌检测挂 `Hook.AfterCardPlayed`（按名字找，签名未在 docs/game-api 里，需实测确认）；敌人死亡靠出牌后和回合开始时检查。
- 接口：/traps、/traps/pack/pick、/summon/select 的 traps；MCP tm_traps、tm_trap_pack_pick，tm_battle 自动选包（pack）和盖陷阱（traps）。
- 没做：陷阱商店、塔主宝箱、升级陷阱、召唤增援/药水/少抽牌类陷阱、陷阱牌面美术。

## 0.0.21 实测通过（2026-10-06）

塔主回合：不同步已修（首场 5 回合不用 win，两端 37 条塔主回合日志一致，StateDivergence 0）；暂停期间出牌、结束回合会排队，塔主结束后执行；格挡、力量、回血、虚弱/易伤/脆弱、眩晕、全体力量都通过；同回合第二次减益被拒；精英 4 点、Boss 5 点；面板左侧、无倒计时。
小问题：控制台 win 在塔主回合中也会排队（tm_battle 已先结束塔主回合）；爬塔玩家有 2 次原版多人位置图标 CompressedTexture2D 已释放异常（NMultiplayerPlayerState.TweenLocationIconIn），未归因。
接口：tm_play 按牌的 TargetType 自动定目标（之前给自身牌传怪物目标会被原版取消）。

## 0.0.20 实测 → 0.0.21（塔主回合不同步修复）

0.0.20 实测：第一回合正常（威胁点 3、看得到手牌、超时结束）；第二回合开始 StateDivergence（校验 ID 9：房主「After player turn start」，客户端「finished action execution TowerMasterSummonGameAction」，客户端手牌还在抽牌堆）。
原因：begin 是 Any，客户端在回合开始流程里（还没发牌）就执行了，多生成一个校验。0.0.21 改为 CombatPlayPhaseOnly（ThreatPhase.ActionKind）。
用户要求去掉倒计时：MasterTurnSeconds 默认 0。面板移到左边。接口加出牌/结束回合（PlayCardAction(CardModel, Creature)、EndPlayerTurnAction(Player, int)）。

## 塔主回合 + 威胁点（2026-10-06，0.0.20，待实测）

用户让我先做、做好一起测。说明和测试点见 `docs/master-turn-plan.md`。
- `ThreatPhase`（房主判定 + 联机指令 + 各端执行），`ThreatPanel`（右侧面板、爬塔玩家提示条），`ThreatSession.HealsLeft`。
- 暂停玩家用 `ActionQueueSet.PauseAllPlayerQueues`；指令动作类型 Any（`RuntimeNetAction.Kind` 按 payload 前缀区分）。
- 测试接口：/threat、/threat/act、/threat/end，state.master_turn_open；MCP tm_threat*，tm_battle 先处理塔主回合再 win。
- 风险：原版可能在回合中途 Unpause；死掉的塔主拥有的 Any 动作在回合末可能被取消；暂停期间玩家点牌的界面表现未知。

## 0.0.18 实测 → 0.0.19（2026-10-06）

0.0.18 实测：宝箱真正领到遗物（B 多了臂甲，塔主不变，日志「塔主不播分遗物动画」，无 AnimateRelicAwards ERROR）；奖励读取、继续、Boss 后换幕、事件选择通过；Boss + 2 只另加怪再次通过；暴徒、棘刺蟾蜍取景完整；单场自动约 4.4–5 秒；StateDivergence 0。
问题：幽灵船太小，淤泥旋螺、化石追踪者、墨宝、遗忘之物只画出碎片（推测入场动画没放完就量了）。
0.0.19：取景等 36 帧再量、裁掉零星像素；接口加选牌工具。

## 0.0.17 实测 → 0.0.18（2026-10-06，待实测）

0.0.17 实测：接口阶段 A 基本可用（/state p95 约 33ms（A，帧节拍）/12ms（B），tm_battle 一场约 6.5 秒）；开局保护、按原版扣款、跨幕降血、精英+小怪（金币 38、遗物）、Boss + 2 只另加怪（生成、站位、扣款）通过；StateDivergence 0。
所有 Boss 能否另加：CeremonialBeast、Vantom、LagavulinMatriarch、SoulFysh、WaterfallGiant、KnowledgeDemon、TheInsatiable、Aeonglass、TestSubject 可；TheKin、KaiserCrab、Queen 不可。所以「Boss + 另加怪」大多数 Boss 都能用。
未完成：宝箱遗物真正领到（之前用节点 OnRelease 没生效）、不能另加的 Boss 的界面、怪物形象头部被裁。

0.0.18：形象自动取景（`SummonPanel.FitAndFreeze`，Image.GetUsedRect）；接口加 rewards、treasure、event、rewards_visible，反射类型全名。

## 0.0.16 实测 → 0.0.17：Boss 另加怪、宝箱动画、测试接口阶段 A（2026-10-06，待实测）

修复：
- Boss 房数量上限把 Boss 遭遇算 1 个单位（`SummonRules.Quote` 的 units）。
- 专用场景 Boss（`SummonPhase.IsSceneless` 为假）不能另加：`SummonSession.Click` 拦住、换 Boss 时清空，面板标注、变灰；问题列表合并显示。
  **待确认**：如果各幕 Boss 大多有专用场景，「Boss + 另加怪」基本用不上，需要研究能否把另加怪摆进专用场景（看 0.0.17 日志「所有 Boss：…」）。
- 塔主跳过 `NTreasureRoomRelicCollection.OnRelicsAwarded`（只是动画），直接 TrySetResult 完成任务。根因推测：塔主跳过挑选后本地遗物槽和结果对不上，未拿源码确认。
- 「超时」日志标签。

测试接口（用户要求，需求见 `docs/testing-mcp-handoff.md`）：
- 游戏内 `TestBridge`：TcpListener + 最简 HTTP/JSON，主线程队列（ProcessFrame 里取）。接口：ping、state、summon（读/选/确认/按原版）、map/options、map/vote、rewards/skip、console、logs、screenshot、tree、node/call、reflect。
- `testing/mcp/towermaster_mcp.py`：stdio MCP + 命令行，工具 tm_*，含 tm_wait、tm_compare_logs、tm_bench、tm_battle。
- 启动脚本加 `-BridgePort`（默认 47101/47102）和相关环境变量。
- 没有在真实游戏里跑过：选路投票、跳过奖励、控制台、截图这些游戏路径都要实测；不行时测试助手可以先用 tm_reflect/tm_node_call 兜底，并告诉我正确的调用路径。

## 测试助手 MCP 需求交接（2026-10-06）

用户希望用轻量 MCP 自动跑本机双实例测试，允许控制台 win，不需要 AI 逐关思考打法。详细需求、社区参考、工具接口、批量用例、速度验收和开发优先级见 [docs/testing-mcp-handoff.md](docs/testing-mcp-handoff.md)。这次仅整理资料，未改 mod 代码或实现 MCP。

0.0.16 实测结果已提交 3b13147，见 [docs/summon-phase-result.md](docs/summon-phase-result.md)：开局12/收入5、账本和两端生成通过；塔主宝箱动画有运行异常；Boss追加因同族小队本体数量占满上限未完成。用户已结束手工测试，未覆盖项在报告中列出。先调查这些问题，再实现最小测试接口补足覆盖。

## 0.0.15 实测反馈 → 0.0.16（2026-10-06，待实测）

0.0.15 实测（`docs/summon-phase-result.md`）：两端清单、生成、降血完全一致，StateDivergence 0；精英载体奖励有遗物。问题：
- Boss 面板超出屏幕、确认按钮看不见（两层滚动区嵌套）→ 面板固定占满窗口高度，只有中间选项区滚动，底部阵容/花费/按钮固定。
- 高个子怪物形象超出卡片 → 点击框缩到 62% 高、脚底贴底。
- Boss 另加怪最终广播 Monsters=[]（截图里选了方柱构装体）：代码路径有单元测试覆盖，推测测试者移除了或没点到确认；0.0.16 重测。

平衡（用户确认）：
- 开局 12 点，基础收入 5/6/7（第一幕普通战平均标准开销约 4.8，原来收入 4 照原版出怪也会越打越少）。
- 开局保护放宽：本幕所有普通怪、上限标准开销 × 1.3（`OpeningSpendCapMultiplier`，`SummonRules.OpeningAllows`）。
- 水土不服不变。

## 召唤规则大改（2026-10-06，0.0.15，待实测）

用户要求：
- 每个房间都能召唤任何幕的怪（Boss 除外）；
- 精英房做成优惠房；
- Boss 房可另加怪；
- 去掉倒计时。

规则写进设计文档「召唤规则变更」。

实现要点：
- **价格表**多导出 `all_monsters`（每只普通、精英怪的有效血量、伤害、机制分、首次出现的幕）。规则库 `SummonRules.SummonPrice` 现算价格，`HpFactor` 算「水土不服」。
- **精英房载体**：`Test1bMixedEncounter.EliteHolder`，即任何幕里按名字排第一个、无专用场景的精英遭遇。房间类型跟着遭遇走（`EncounterModel.RoomType`），所以不能用普通载体。
- **生成后改列表**：不再挂载体的 `GenerateMonsters`。改在 `GenerateMonstersWithSlots` 之后改写 `_monstersWithSlots`：载体整表替换，Boss 追加。
- **降血**：在 `CombatState.CreateCreature` 之后直接写 `_maxHp`、`_currentHp`。
- 测试共 75 个。

## 第 2 步：召唤阶段第一版（2026-10-06，0.0.13）

**0.0.12 实测**：
- 外骨骼混搭后开战卡死：它靠槽位名决定行动。
- 墨影幻灵的召唤物要专用场景槽位。
- 重连后怪物变回原版。

0.0.13 的处理：
- 普通房只列可混搭的怪：出现在本幕无场景、无槽位普通遭遇里的。
- 精英、Boss 与原版相同时不替换。
- 清单按坐标存，重连找回。
- 怪物卡片用 SubViewport 画战斗模型（`MonsterModel.CreateVisuals`，按 `Bounds` 缩放）。

**0.0.11 实测 StateDivergence**（`docs/summon-phase-result.md`）：
- 原因：原版每个客户端在自己点开宝箱时给所有玩家各建一个额外奖励集合（消耗奖励编号）。塔主没点开时房主少建，编号分叉。
- 0.0.12：塔主进宝箱房后自动点开（`NTreasureRoom._Ready` 后 1.5 秒调 `OnChestButtonReleased`）。
- **教训：任何「每个客户端本地各做一次、但影响共享状态」的原版流程，塔主那边都不能省略，只能让它做完再拦掉给塔主的东西。**
- 重连黑屏未确诊，下一轮先停用本 mod 对照原版。

**0.0.10 实测基本通过**（`docs/summon-phase-result.md`）：启动正常；召唤、清单两边一致、Boss 替换、5 场召唤点流水逐场对得上；宝箱能离开；读档后混搭找回。
- 0.0.11 修复：塔主开宝箱拿金币（跳过 `DoLocalTreasureRoomRewards`）；Boss 标准开销显示为 0。
- 0.0.11 按用户反馈重做召唤面板外观，仍只用 Godot 自带控件和 StyleBoxFlat。
- 仍未覆盖：按原版出场、超时、换成不同精英、全新进程读档恢复召唤点、面板截图。
- 日志里其余 ERROR 不是 mod 引起的：退出时 Godot 资源泄漏、商店悬浮提示重复键、断线后发地图画线消息。

**0.0.9 加载失败**（`docs/summon-phase-result.md`）：游戏 `ModManager.TryLoadMod` 在调用入口前就 `GetTypes()`。新代码有规则库的枚举（值类型）字段，枚举类型时就要加载 TowerMaster.Core.dll，而入口里注册的依赖解析还没执行。
- 0.0.10：规则库源码直接编进 TowerMaster.dll（csproj 的 `Compile Include="..\TowerMaster.Core\*.cs"`），不再单独出 Core DLL；测试守住「主程序集不引用 TowerMaster.Core」。
- **以后不要再给 mod 加单独的依赖 DLL**，除非在入口之前就能解析到。
- GameReflection 取游戏程序集时优先取同一加载上下文里的 sts2。

测试 3 第二轮（`docs/test3-round2-result.md`）：
- 禁止塔主选路、领奖励、用商店、拿宝箱遗物都通过。
- **宝箱卡住**：爬塔玩家拿完遗物后没有继续按钮。原版取默认焦点时用座位号越界；0.0.9 加异常保护，越界时返回第一个遗物槽。
- 先古之民、部分「?」事件仍能给塔主物品。用户的想法是以后给塔主另做先古之民三选一、特殊事件和商店，所以**不要一律禁掉事件**。
- 共享事件、休息处、换幕本轮没遇到。

Codex 整理了游戏接口资料 `docs/game-api/`（签名表、流程、界面），以后先查这里，不用再猜签名。

召唤阶段（`SummonPhase`、`SummonSession`、`SummonPanel`、`MasterLedger`）：
- 地图投票到齐、房主入队移动时，若目的地是普通、精英或 Boss 房，就扣住移动，在塔主屏幕弹出 Godot 面板（30 秒）。
- 确认后扣召唤点、广播 v2 召唤清单（复用测试 1b 通道，普通房怪物列表；精英、Boss 房遭遇类名），再放行移动；超时或「按原版出场」扣标准开销。
- 胜利后结算收入并提示。账本按局存本地文件。
- 简化：标准开销用本幕同类房间平均值（进房前拿不到原版遭遇）；精英、Boss 房不另加小怪；候选 Boss 没公开给玩家；「?」战斗不召唤。
- 面板只用 Godot 自带控件 + C# 事件，不定义自定义节点类；中文字体借游戏的 MegaLabel。云端编译用 nuget GodotSharp 4.5.1，游戏里用游戏自带的。
- 规则库加了 `StandardCostOverride`、`AverageStandardCost`、钱包存档恢复。
- 自动测试 66 个（Core 39 + mod 27）。面板本身只能实测，测试步骤见 `docs/summon-phase-plan.md`。
- 测试 3 第二轮的实测结果 Codex 还没推送。

## 测试 3 第二轮（2026-10-06，0.0.7，待实测）

第一轮实测（`docs/test3-result.md`）：
- 选路自动跟随 11 次全部正确，休息处、宝箱自动跳过生效。
- 奖励自动跳过有「not currently viewing any reward set」异常，但实际无害。
- 共享事件、换幕没覆盖到。
- 注意：脚本 A/B 和身份反了，以 NetId 为准，塔主 = 100001 = 房主。

第二轮改动：
- 禁止塔主手动选路（用户要求）：拦 `NMapScreen.OnMapPointSelectedLocally`。
- 塔主不能领东西（设计文档，开关 `test3_block_master_items`）：拦 `SelectLocalReward`、`MerchantEntry.OnTryPurchaseWrapper`、`DoLocalMerchantCardRemoval`，`PickRelicLocally` 只放行跳过。
- 奖励「还没显示」的异常改为普通日志。
- 新增 2 个测试（共 59 个）。测试步骤见 `docs/test3-round2-plan.md`。

## 测试 3 第一版（2026-10-06，0.0.6，待实测）

测试 2 第二轮实测通过（`docs/test2-round2-result.md`）：动态程序集登记后 ERROR 消失，人数改写 19 个，新增 5 项都带 ★，回归正常。Codex 的只读调研给出了各同步器的等待逻辑和挂点。

据此实现测试 3（`mod/TowerMaster/Test3MasterAutoPilot.cs`）：塔主 = 房主，全部在房主自己的客户端上，用原有接口提交塔主自己的选择。
- 选路：B 的投票执行后入队同目的地的塔主 `VoteForMapCoordAction`。
- 奖励：`SkipLocalRewardsSet`。
- 宝箱：`SkipRelicLocally`。
- 共享事件：`ChooseLocalOption` 跟投。
- 休息处：`BeforeLocalRestSiteExited`。
- 换幕：`SetLocalPlayerReady`。
- 每步只记日志不抛异常，失败时退回手动。
- 已知限制：
  - 多名爬塔玩家时，塔主跟随最近一个投票的人，会给这个人的票多一份权重。
  - 非共享事件不自动选。
- 假同步器上 4 个新测试通过（共 57 个）。测试步骤见 `docs/test3-plan.md`。

## 测试 2 实测结果与第二轮（2026-10-06，0.0.5）

**第一轮实测（0.0.4，详见 `docs/test2-result.md`）通过**：塔主每场开局生命 0、死亡；爬塔人数 1；暗港怪物血量等于单人；B 死亡两边都判负；回合不等 A；怪物只打 B；无 StateDivergence。全游戏共 122 个方法读玩家人数，改写 14 个。
- 塔主战后被原版复活（1 血 + 铁甲战士被动），下一场再退场。用户认为不影响游玩，先不处理。
- 选路、领奖励要等 A 操作：留给测试 3（塔主自动投票）。

**第二轮改动（0.0.5，待实测，见 `docs/test2-round2-plan.md`）**
- 动态程序集调用 `ModManager.AssociateAssemblyWithMod` 登记到本 mod（`mod/TowerMaster/ModAssociation.cs`），消除「not associated with any mod」ERROR。签名未知，按参数类型现场拼。
- 参数日志只记血量公式：格挡公式的「两边参数不一致」来自本地卡牌预览，不是不同步。
- 改写范围加 `PotionModel.CanThrowAtAlly`、`CardFactory.FilterForPlayerCount`、遗物命名空间。
- 探针导出 `ModManager` 和全部 *Synchronizer 类型，并请 Codex 用文字描述各同步器的等待逻辑，供测试 3 使用。

## 测试 2 第一版（2026-10-06，云端，0.0.4，待实测）

塔主 = 房主。战斗初始化后各客户端把塔主角色生命写成 0，借用游戏现成的「死亡玩家」处理：自动准备结束回合、不被选为目标、判负变成只看爬塔玩家。人数缩放：在配置范围内，用 Harmony 改写把「读玩家人数」换成只数爬塔玩家。启动日志列出全游戏所有读玩家人数的方法，下一轮按实测调整范围（`towermaster.test.json` 的 `test2_scaling_scope`）。代码在 `mod/TowerMaster/Test2MasterOffField.cs`，假游戏程序集上 4 个新测试通过（共 52 个）。

**已知风险**
- 改写后的人数如果被拿来当随机下标（例如 `Players[rng.Next(Players.Count)]`），会少一个可选下标。1 对 1 时可能总是选到塔主（已死），表现为怪物打空。实测时注意观察。
- 塔主角色是「死亡」状态，画面上可能显示为倒地。纯装饰的塔主形象以后再做。

测试步骤和观察项见 `docs/test2-plan.md`。

## 测试 1b 保底机制（2026-10-06，云端，0.0.3）

**1b 结论**：用户补充说明，第一场在用 win 之前正常打了几个回合，双方都有造成和受到伤害；之后领奖励、进下一房、第二场生成也正常。所以怪物行动、伤害结算这些战斗同步已经覆盖，**1b 不再单独补测**，测试 2 时保持 1b 开启顺带验证。

**新增保底**（都是少见情况，正常流程不受影响）：
- **出错不卡游戏**：1b 所有补丁都包了异常保护。任何一步失败只写 ERROR/WARN 日志，退回原版遭遇或载体遭遇原本的怪物。
  - 进普通房前没收到清单（读档、重连）：按原版遭遇，不再抛异常。
  - 清单不合格（不是房主、楼层或种子不对、怪物不存在）：只记「拒收召唤清单」，不再让动作执行抛异常。各客户端执行同一个动作、校验结果相同，所以退回原版时各家也一致。
- **重启后序号不冲突**：去掉「序号必须递增」的检查，序号只用于日志。过期清单靠种子和楼层校验拦下；同一份清单收到两次，覆盖即可。
- **读档找回混搭**：替换遭遇时把清单按「种子 + 进房楼层」写进本地文件（`mods/TowerMaster/towermaster.plans.json`；设了 `TOWERMASTER_LOG_FILE` 时放在日志旁边，按实例区分），只保留当前这局。生成怪物时如果是载体遭遇、但没有经过选遭遇流程，就按种子和楼层从文件找回清单。
  - **未在真游戏验证**：读档后是否重新走 `GenerateMonstersWithSlots`、楼层是否等于进房楼层，要实测确认。
  - 风险：只有一边有这个文件（例如换了电脑）时，读档后两边怪物会不同。技术验证阶段可以接受，正式版应改成把清单存进游戏存档或由房主重新广播。
- 自动测试：Core 37 个 + mod 11 个，全部通过（云端用 .NET 10 运行时向前兼容跑 net9.0）。

## 测试 1b 实测阶段结果（2026-10-05：广播与两次混搭生成一致，完整战斗待补测）

单人 Mawler + Flyconid 混搭已确认。双实例两端 9 条接收/替换/生成消息正文完全一致，探针无 WARN/ERROR，无 StateDivergence，自定义动作在真实游戏传输及执行成功。本轮实际为 2 场普通房和 1 个事件房；第一场使用 win 命令，第二场开始后退出，未达到 3～5 场完整战斗要求。连接前握手/ID 冲突及退出资源泄漏异常另行记录，不能宣布整份日志无异常。详细证据及补测步骤见 `docs/test1b-multiplayer-result.md`。

## 测试 1b 实现进度（2026-10-05）

0.0.2 实现第一幕跨遭遇混搭和自定义 INetAction 房主清单广播；保留按名字反射，动态生成游戏接口和动作类型。密林 Mawler + Flyconid，暗港 CalcifiedCultist + Seapunk。原有 40 个测试与新增 4 个测试全部通过。真实程序集编译、安装成功（0 警告、0 错误），已核对安装 DLL、manifest 和配置与构建产物哈希一致；真实游戏启动和联机尚待验证。

实现细节、反编译依据、改动清单及用户实测步骤见 `docs/test1b-local-verification.md`。下方 1a 的“1b 尚未实现”是当时的历史状态。

## 测试 1a 实测结果（2026-10-05：同机双实例通过，跨机器待验证）

### 当前结论

- **同机双实例测试 1a 通过**：v0.111.0、IP直连 1.4.0，A=100001、B=100002，暗港 3 场普通战斗，两端分别记录 3 次战斗结束。用户确认画面和战斗过程正常。
- 两端探针全部找到，TowerMaster 日志均无 WARN/ERROR。
- 每场“选遭遇 / 已替换 / 生成”的 9 条正文逐条完全一致（排除时间戳），每场替换都先于生成。
- 原遭遇依次为 ToadpolesWeak、SeapunkWeak、SludgeSpinnerWeak，均替换为 CultistsNormal，生成 CalcifiedCultist 与 DampCultist（槽位 null）。这轮联机测试在暗港，不是先前单人密林的小啃兽。
- 两份游戏日志均未发现 StateDivergence；成功握手后的 3 场战斗阶段没有发现 ERROR 或异常。测试配置解析和价格表误认 manifest 两处加载问题已在重启后的真实日志中确认消失。
- **完整游戏日志仍有异常**：B 成功加入前发生旧单人存档删除失败、握手身份不匹配和玩家 ID 冲突；A 有一次 HandshakeTimeout 后重连成功。两边退出时有引擎 RID/shader/资源未释放错误，来源尚未定位。不能描述成“整份日志无异常”。另有未声明 min_game_version 的加载提示。
- 之前单人密林的 NibbitsWeak → NibbitsNormal 和两只小啃兽生成顺序也已验证。
- 结论仅覆盖本机双实例和此次 3 场暗港战斗；跨机器、跨幕、延迟、丢包和重连稳定性仍待验证。测试 1b 的怪物混搭、塔主选择和自定义消息尚未实现。
- 详细逐场结果及异常分类：`docs/test1a-multiplayer-result.md`。原始日志仅保存在本机聊天输出目录，未上传。

### 猜测核对和代码依据

反编译路径以下均相对于仓库；decompiled/ 和 tools/ 为本机只读依据，不提交。

1. **入口猜测正确**：命名空间 `MegaCrit.Sts2.Core.Modding`，类上的 `[ModInitializer(nameof(Init))]` 指向静态无参方法。依据 `decompiled/sts2/MegaCrit.Sts2.Core.Modding/ModInitializerAttribute.cs:3、5、10`，`ModManager.cs:787、873–898`。入口之外仍按类型名字反射。
2. **模型猜测正确**：`ModelDb.Encounter<T>()` 返回规范模型（`MegaCrit.Sts2.Core.Models/ModelDb.cs:505`）；`IsMutable` 位于 `AbstractModel.cs:33`，`EncounterModel.ToMutable()` 位于 `EncounterModel.cs:259–264`。游戏在 `MegaCrit.Sts2.Core.Runs/RunManager.cs:768` 取遭遇后 ToMutable；房间构造在 `MegaCrit.Sts2.Core.Rooms/CombatRoom.cs:55–58` 要求可变模型。找不到可变转换时保留原遭遇，避免规范模型进入战斗。
3. **生成时机的普通地图前提正确，原存储结构猜测错误**：`CombatRoom.cs:33、35` 的 Encounter 转发到 CombatState，房间本身没有预想的遭遇字段；`MegaCrit.Sts2.Core.Combat/CombatState.cs:27、55–79` 保存遭遇。普通战斗在 `CombatRoom.cs:169–173` 生成；事件有提前生成路径 `MegaCrit.Sts2.Core.Multiplayer.Game/EventCombatSynchronizer.cs:61`。测试 1a 改挂 `ActModel.PullNextEncounter` 后置补丁（`MegaCrit.Sts2.Core.Models/ActModel.cs:341`），返回规范模型，让游戏继续原有创建副本/房间流程。事件战斗不在此次替换范围。FakeSts2 与 3 个补丁测试同步采用该结构和参数。
4. **manifest 猜测错误**：`dll` 不是加载字段；`ModManifest.cs:30–40` 使用 has_pck、has_dll、affects_gameplay，`ModManager.cs:738–741` 加载 id + .dll，`ModManager.cs:916–925` 和 `MegaCrit.Sts2.Core.Multiplayer/PeerVersionInfo.cs:32` 将影响玩法的 mod 放入握手列表。已参照 IP直连 1.4.0 manifest 修正。
5. **日志必须稳定**：`MegaCrit.Sts2.Core.Models/AbstractModel.cs:1045–1047` 的 ToString 包含进程内哈希，生成行改用稳定 Id。即便原遭遇已是目标，也记录“已替换”，方便每场三行核对。探针补充血量应用方法与 IPacketSerializable，保留原有缩放公式方法。
6. **数据不能误触 manifest 扫描**：`ModManager.cs:346–372` 递归扫 JSON，`:388–398` 判断身份字段。测试配置使用标准无注释 JSON；安装价格表改成 price_book.data，安装时只清理我方旧 price_book.json。源数据仍是 data/price_book.json。

### 本机环境、格式和验证

- 游戏实际 TargetFrameworkAttribute 为 `.NETCoreApp,Version=v9.0`（.NET 9.0），反编译工程 `decompiled/sts2/sts2.csproj:5` 同为 net9.0。Core、mod、测试和 FakeSts2 均已改 net9.0。
- 游戏目录：`C:\Users\kkk\Desktop\slaythespire\Slay the Spire 2`。
- mod 目录：上述目录的 `mods\TowerMaster`。只安装自己的 mod 文件，未修改游戏本体。
- 游戏自带 `data_sts2_windows_x86_64\0Harmony.dll`，文件版本 2.4.2.0；实机直接引用。无游戏的测试构建由 NuGet Harmony 2.3.3 升到 2.4.2，修复 net9.0 下 LocalBuilder 抽象类实例化错误。
- `cd mod && dotnet test`：Core 37 个、补丁测试 3 个全部通过，0 失败、0 跳过。
- `dotnet build TowerMaster -p:GameDir="C:\Users\kkk\Desktop\slaythespire\Slay the Spire 2" -p:Install=true` 编译安装已成功。游戏运行时锁住 mod DLL，更新前必须退出游戏。

实际 manifest：

```json
{
  "id": "TowerMaster",
  "name": "塔主 TowerMaster",
  "version": "0.0.1",
  "author": "brooks",
  "description": "1 名塔主对抗 1–3 名爬塔玩家（技术验证版）",
  "dependencies": [],
  "has_pck": false,
  "has_dll": true,
  "affects_gameplay": true
}
```

### 同机双实例工具

`scripts/local-test/` 收录两个英文文件名的 cmd/PowerShell 启动脚本及 README。可传 GameDir 或设 STS2_DIR，默认本机游戏路径。英文内部脚本名避免已遇到的中文批处理编码故障；失败时窗口保留报错。

两实例用 `--force-steam off` 和不同 `--clientId` 隔离游戏存档；TowerMaster 用 `TOWERMASTER_LOG_FILE` 分开日志，游戏用 `--log-file` 分开输出。默认运行 mod 时仍在 mod 目录写 TowerMaster.log。IP mod 的配置仍共享，各实例需在个人设置分别设 ID 100001/100002；重启后会读最后保存的配置，不能只改昵称。A 建 IP 大厅，B 连 127.0.0.1:33771。依据：`NGame.cs:1082–1090`、`NullPlatformUtilStrategy.cs:29`、`UserDataPathProvider.cs:30–42`；本机 IP mod 的 `ModConfigManager.cs:106、129–130`、`DirectHost.cs:200`、`JoinServerScreen.cs:216`。

同机测试能检验确定性与锁步同步，不能覆盖跨机器运行环境或真实网络延迟/丢包。本次已重启确认我方 JSON 加载异常消失，并完成 3 场双端正文对照。下一步推进测试 1b；跨机器测试仍需补做。

### 测试 1b 所需签名（摘自本次真实探针日志）

```text
static T MegaCrit.Sts2.Core.Models.ModelDb.Monster<T>()
static T MegaCrit.Sts2.Core.Models.ModelDb.Encounter<T>()
EncounterModel MegaCrit.Sts2.Core.Models.ActModel.PullNextEncounter(RoomType roomType)
Void MegaCrit.Sts2.Core.Models.EncounterModel.GenerateMonstersWithSlots(IRunState runState)
property IReadOnlyList<ValueTuple<MonsterModel, String>> MegaCrit.Sts2.Core.Models.EncounterModel.MonstersWithSlots
Creature MegaCrit.Sts2.Core.Combat.CombatState.CreateCreature(MonsterModel monster, CombatSide side, String slot)
GameAction MegaCrit.Sts2.Core.GameActions.Multiplayer.INetAction.ToGameAction(Player player)
Void MegaCrit.Sts2.Core.Multiplayer.Serialization.IPacketSerializable.Serialize(PacketWriter writer)
Void MegaCrit.Sts2.Core.Multiplayer.Serialization.IPacketSerializable.Deserialize(PacketReader reader)
```

探针会继续输出 INetMessage 的 ShouldBroadcast、Mode、LogLevel、ShouldBuffer。测试 1b 将用自定义 INetAction 广播召唤清单，再验证跨遭遇混搭的站位和场景；这些仍未实现。需要的其他成员应继续从真实探针提取，不能把云端猜测写作已确认签名。

详细核对：`docs/test1a-local-verification.md`。双实例步骤：`scripts/local-test/README.md`。

---

# 交接记录

## 第二次会话（2026-10-05，云端环境）：规则核心库

云端容器里**没有游戏本体，也没有 `decompiled/`、`tools/`**（被 .gitignore 排除），所以第 1 步的联机实测做不了。这次先做了不依赖游戏的部分：把设计文档里的规则写成纯 C# 库，加单元测试。mod 本体以后直接引用它。

### 新增
- `mod/TowerMaster.sln`（.NET 8 SDK：`cd mod && dotnet test`，目前 37 个测试全过）
  - `TowerMaster.Core/TowerMasterConfig.cs`：所有可调数值，默认值即设计文档第一版。JSON 读写（snake_case，允许注释，没写的字段保留默认值）。
  - `TowerMaster.Core/PriceBook.cs`：读 `data/price_book.json`。
  - `TowerMaster.Core/SummonRules.cs`：召唤阶段校验和报价——标准开销、群体税、普通/精英/Boss 房花费上限、场上数量与同名上限、开局保护、陷阱数量与费用、超时回退、候选 Boss。
  - `TowerMaster.Core/Economy.cs`（`SummonWallet`）：召唤点收入结算（基础×人数系数、节约、战果、击倒奖励及连续击倒规则）、储蓄上限、换幕截断。
  - `TowerMaster.Core/ThreatSession.cs`：一场战斗的威胁点发放与价目表、各项次数限制、力量累计上限（威胁点 + 陷阱合并）。
- `scripts/build_tables.py` 现在顺带生成 `data/price_book.json`（每幕可召唤的怪物、召唤价、原版遭遇组合和标准开销）。重跑结果与 CSV 一致（Linux 下只有换行符不同，别提交那种改动）。
- 设计文档已换成用户上传的新版（新增「每幕开头公开 2 个候选 Boss」「未完成事项与开发建议」等）。

### 规则细节里我自己定的地方（设计文档没写，需要确认）
- **普通房只能召唤本幕「普通」怪**；怪物召唤出来的小怪（扭动虫、炸弹等，`role=Summon`）不单卖。
- **精英房**：塔主选本幕任一精英遭遇，价格 = 它的标准开销；遭遇本体算 1 个单位，另加小怪从 +1 起收群体税；「小怪 ≤ 4 点」含群体税；总价 ≤ 原房间标准开销 × 1.5。
- **Boss 房**：候选 Boss 第 1 个是游戏本来为这一幕选好的 Boss（超时按它出场），另 1 个用种子随机从本幕其他 Boss 里抽。另加小怪同样从 +1 起收税。Boss 房没有节约奖励。
- **场上数量上限只约束塔主的召唤**：原版组合（超时回退）不受限。例：密林「一大群史莱姆」4 只，1 对 1 时上限 3，塔主自己摆不出这一组。
- 陷阱费用不算进单场花费上限，也不影响节约奖励。
- 连续击倒：上一场被击倒的玩家这一场再被击倒不给奖励（连续三场也只有第一场给）。
- 单只加力量超上限时**拒绝且不扣点**；陷阱给的力量自动截断到上限；全体加力量跳过已到上限的怪，全满时拒绝。
- 回血量 = 最大生命 × 10% 向下取整，至少 1；人数系数乘完向下取整（第二幕 2 人 5×1.25=6）。

### 测试 1a 的 mod（`mod/TowerMaster/`，已写好，待本机实测）
- **做什么**：所有普通房间（遭遇类名以 Normal/Weak 结尾）在 `CombatRoom.StartCombat` 执行前，把房间里的遭遇换成 `towermaster.test.json` 里本幕的固定遭遇（密林 NibbitsNormal、暗港 CultistsNormal、蜂巢 MytesNormal、荣耀 AxebotsNormal）。两边按同一份文件替换，**不需要联机消息**，只检验「替换后是否同步」。
- **全用反射**：按名字找类和方法，不写死命名空间。只有入口 `[ModInitializer]` 是按 GAME 条件编译的猜测写法。
- **探针**：启动时把 HANDOFF 记的类和方法在当前版本里的签名写进 mod 目录的 `TowerMaster.log`，`ModelDb`、`INetAction`、`INetMessage`、`ModInitializerAttribute` 会列出全部成员。缺什么会写 WARN。
- **云端验证**：`mod/FakeSts2` 是按 HANDOFF 结构仿造的假 `sts2` 程序集，`mod/TowerMaster.Tests` 用真 Harmony 把补丁打上去跑了一遍（3 个测试通过）。**真游戏的结构可能不同，以探针日志为准。**
- **编译安装**：`cd mod && dotnet build TowerMaster -p:GameDir="<游戏目录>" -p:Install=true`。
  - 会复制到 `<游戏目录>\mods\TowerMaster`；mod 目录不对就加 `-p:ModsDir=...`。
  - `TowerMaster.json`（manifest）是猜的格式，照「IP直连」mod 的 manifest 改。
- **可能要在本机修的地方**（对照 `decompiled/`）：
  1. `ModEntry.cs` 的 `[ModInitializer]` 写法和命名空间。
  2. `Test1FixedEncounter.GetEncounterModel`：猜的是 `ModelDb.Encounter<T>()`，以及可变副本用 `IsMutable`/`ToMutable()`。
  3. 如果怪物不是在 `StartCombat` 里生成的（日志里「生成 …」那行出现在「测试1 #n」之前），就要换挂点，比如 `Act.PullNextEncounter` 的返回值。
- **判定通过**：两台电脑 `TowerMaster.log` 里每场的「已替换」「生成 …」行一致，画面上怪物、血量、意图一致，连打几场不报 `StateDivergence`。

### 下一步（需要在装了游戏的本机做）
1. 第 1 步技术验证，按下面「第 1 步建议的验证顺序」。mod 工程另建 `mod/TowerMaster/`，引用游戏的 `sts2.dll`、GodotSharp、0Harmony 和 `TowerMaster.Core`；目标框架要跟游戏一致（先查 `sts2.dll` 的 TargetFramework，Core 现在是 net8.0，必要时改）。
2. 用 Core 接上：召唤清单广播（自定义 `INetAction`）→ 各客户端 `SummonRules.Quote` 校验 → `SummonWallet.Spend`；战斗结束 `SettleBattle`；候选 Boss 用游戏的种子随机数调 `PickBossCandidates`。
3. 还没做：陷阱牌（第二版）、日志、塔主等级预设、默认配置文件导出。

---

# 第一步交接记录（2026-10-05）

游戏版本 v0.111.0（release_info.json），主程序集 `data_sts2_windows_x86_64/sts2.dll`。

## 已完成
- `decompiled/sts2.dll`：程序集副本；`decompiled/sts2/`：ilspycmd 11.1 反编译出的工程（3537 个 .cs）。
- `decompiled/pck/localization/{zhs,eng}/{monsters,encounters,powers}.json`：从 .pck 里只读提取的本地化文件。
- `tools/ilspycmd/`：本机没有 .NET SDK，所以从 nuget.org 下载 ilspycmd 包，直接用 .NET 10 运行时运行。
- 脚本（用 `py` 运行）：
  - `scripts/extract_monsters.py`：从代码里读出血量、招式、意图、遭遇组成和各幕遭遇列表，生成 `data/extracted.json`。
  - `scripts/monster_curated.py`：人工核对的数据，包括前 3 回合伤害、有效血量修正和机制分，每项附理由。
  - `scripts/build_tables.py`：生成 `monsters.csv`、`encounters.csv`、`prices.csv`、`encounter_costs.csv`，并做系数校准。
- 校准结果：幕系数 0.218 / 0.192 / 0.176（含群体税），校准目标是普通遭遇平均标准开销 = 1.2 × 基础收入。
- 精英系数 2.35：只用幕系数时，第一幕精英只有 4–8 点，达不到设计的 10–12，所以精英怪再乘这个系数。原版多怪精英组内不收群体税。
- 校准后精英平均：第一幕 11、第二幕 13.7、第三幕 18。

## 与 design.md 不一致的地方
- 鬼祟珊瑚群每回合最多掉 20 血，不是 15。
- 第一幕有两个版本：密林 Overgrowth 和暗港 Underdocks。
- 原版联机里怪物攻击打所有玩家（`AttackCommand.FromMonster` → `TargetingAllOpponents`），本来就没有「攻击谁」的选择。

## 第 4 项结论：联机技术验证的方向

**一句话结论：** 「替换敌人组合」好做，「塔主不上场」是真正的难点，但有可行路线。

1. **替换敌人组合（可行，难度低）**
   - 怪物组合在每个客户端上用种子各自算出（`CombatRoom.StartCombat` → `GenerateMonstersWithSlots`），各家结果一致。
   - 做法：塔主在玩家进房前，用 mod 自定义的 `INetAction` 把召唤清单广播出去；各客户端在 `StartCombat` 前打补丁，用这份清单替换 `MonstersWithSlots`。
   - 跨遭遇混搭怪物时，站位槽位（`Slots`/场景）要另做一套通用布局，属于小风险。
2. **塔主回合（可行）**
   - 在 `CombatManager.StartTurn` 的 `RunAutoPrePlayPhase` 之后、`ActionExecutor.Unpause` 之前插入一个所有客户端都等待的阶段。
   - 增益、减益走自定义 `INetAction`，所有客户端都会按同一顺序执行。
   - 20 秒超时必须由房主判定并广播，不能各家本地计时，否则会不同步。
3. **塔主身份（主要风险）**
   - 游戏到处默认「每个连进来的人都是上场的 Player」。
   - 动作必须归属某个 Player；`LocalContext.GetMe` 找不到本地玩家会直接抛异常（64 处调用）；6 个同步器要等所有玩家。
   - 因此**不建议把塔主从 Player 列表里删掉**。建议让塔主仍是 Player，再打以下补丁：
     - **人数缩放只数爬塔玩家**：怪物血量 `Creature.ScaleHpForMultiplayer`，怪物格挡 `MultiplayerScalingModel.ModifyBlockMultiplicative`，能力层数 `PowerModel.GetScaledAmountForMultiplayer`，以及怪物代码里直接用 `Players.Count` 的地方（如知识恶魔、瀑布巨兽的回血）。
     - **战斗中塔主角色不在场**：塔主角色应视为不可选中、不受伤。注意：原版怪物攻击打所有玩家，群体效果也会算到塔主身上。
     - **胜负判定**：现在是 `RunState.Players.All(IsDead)` 才判负（`CreatureCmd.cs:326`），塔主活着就永远不会判负，必须改成只看爬塔玩家。
     - **复活与准备**：战斗结束会给死去的玩家回 1 血（`Player.ReviveBeforeCombatEnd`），要跳过塔主。死去的玩家每回合会被自动标记为「准备结束回合」，塔主也可以借用这个机制。
     - **非战斗环节**：选路、事件、篝火、奖励、宝箱、换幕这些同步器里，替塔主自动投票、自动跳过，并且不给塔主发奖励。
     - **大厅**：最多 4 人正好是 1 名塔主 + 3 名爬塔玩家。加入时会强制分配角色，需要给塔主一个占位角色或在界面上隐藏。
4. **兼容性**
   - 所有人必须装完全相同的 mod：消息类型按名字排序编号，握手时也会比对 mod 列表。
   - 本机游戏目录装了「IP直连」联机 mod，它走 ENet 传输层，可能和本 mod 冲突，需要实测。

**第 1 步建议的验证顺序：**
1. 1 对 1 联机，只把对方的敌人组合替换成固定清单，确认两边一致、不报 StateDivergence。
2. 塔主角色开局移出战斗，同时修好人数缩放和胜负判定。
3. 补上同步器的自动投票。

## 联机代码定位（细节）
- **加入房间**：`Multiplayer.Game.Lobby/StartRunLobby.cs` 中的 `HandleClientLobbyJoinRequestMessage` 和 `TryAddPlayerInFirstAvailableSlot`。
  - slotId 只占 2 bit，最多 4 人。
  - 每个加入者都会自动分到一个角色。
  - 传输层有 Steam 和 ENet（IP 直连）两种。
  - 握手时会比对「影响玩法的 mod 列表」（`PeerVersionInfo`）。
- **开局**：`Nodes/NGame.cs:873` 的 `StartNewMultiplayerRun` 会把大厅里的每个人都建成一个 `Player`。
- **怪物生成**：
  - 遭遇在 `RunManager.cs:768` 由 `Act.PullNextEncounter` 选出。
  - `Rooms/CombatRoom.cs` 的 `StartCombat` 调用 `Encounter.GenerateMonstersWithSlots`，用种子 + 楼层算出组合，所有客户端结果一致。
  - 然后 `CreateCreature` 生成怪物，再走 `CombatManager.SetUpCombat`。
  - 战斗中召唤怪物用 `CreatureCmd.Add`。
- **回合流程**：`Combat/CombatManager.cs` 的 `StartTurn`。
  - 顺序：发能量、抽牌（`SetupPlayerTurn`）→ `RunAutoPrePlayPhase` → `ActionExecutor.Unpause` + `PlayPhase`。
  - **「塔主回合」应插在抽牌之后、Unpause 之前。**
  - 所有人准备结束回合（`SetReadyToEndTurn`）后切到敌方，`ExecuteEnemyTurn` 让怪物按顺序 `TakeTurn`。
  - 已死亡的玩家每回合开始时会被自动标记为「准备结束回合」。
- **同步方式**：由房主中转的确定性锁步（lockstep），并有校验和（`ChecksumTracker`）检测不同步。
  - 客户端发 `RequestEnqueueActionMessage`，房主广播 `ActionEnqueuedMessage`，所有客户端各自执行。
  - 动作必须属于某个 `Player`（`ActionQueueSynchronizer` 里的 `GetPlayer(actionOwnerId)`）。
  - **mod 可以注册自定义 `INetMessage` 和 `INetAction`**（`ReflectionHelper.GetSubtypesInMods`）。类型按名字排序编号，所以所有人的 mod 必须完全一致。
- **mod 加载**：`Modding/ModManager.cs` 自带支持 manifest json、dll/pck、`ModInitializer` 和 Harmony。
- **人数缩放**：
  - 怪物血量 × 人数 × 1.1 / 1.2 / 1.2（第三幕 Boss 1.3），见 `Creature.ScaleHpForMultiplayer` 和 `MultiplayerScalingModel`。
  - 怪物格挡、12 种能力的层数也按人数缩放。
- **「塔主不上场」的主要难点**：
  - `LocalContext.GetMe` 在本地玩家不在玩家列表里时会直接抛异常，共 41 个文件、64 处调用。
  - 选路、事件、篝火、奖励、宝箱、换幕这些同步器都要等所有玩家。
  - **建议方向**：塔主仍作为联机 Player 存在，但战斗中视为不在场。需要打补丁的地方：
    - 人数缩放改为只数爬塔玩家。
    - 各同步器自动替塔主投票或跳过塔主。
    - 战斗开局把塔主的角色移出场。
    - 这条路仍需实测验证。
