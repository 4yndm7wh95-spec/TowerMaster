# 测试接口阶段 A 验收（0.0.17）

代码81018be，游戏v0.111.0，本机A/B双实例。81个测试通过（41+40）；真实编译安装零警告零错误，manifest0.0.17。使用Python命令行/导入同一模块方式调用工具实现，未注册全局MCP，也未验收stdio协议。没有改mod或MCP代码。

## 身份及接通

A：47101，net_id100001、Host、is_host=true；B：47102，net_id100002、Client。两端mod_version0.0.17；种子2220966056932320891，第一幕Underdocks。监听原文：

```text
[09:50:02.797] INFO 测试接口：已在 127.0.0.1:47101 监听（没有设令牌）
[09:50:02.657] INFO 测试接口：已在 127.0.0.1:47102 监听（没有设令牌）
```

建房加入由用户完成，先古之民选择后改由助手自动推进。map投票接口能从商店/事件/休息直接入队移动，报告这些路径时不把它当成所有继续按钮均已验证。

## 工具逐项

|工具|结果|说明|
|---|---|---|
|tm_instances|通过|进入联机后身份正确；主菜单net_id=null正常|
|tm_state|通过|两端玩家与enemies可读；客户端wallet=null符合本地账本实现|
|tm_map_options|通过|下一步坐标和房间类型可读|
|tm_map_vote(B)|通过|已连续选路；实际入队联机投票|
|tm_summon|通过|列表、幕、精英标志、折扣、保护和报价可读|
|tm_summon_select|通过|整份设置成功；超限返回can_confirm=false|
|tm_summon_confirm|通过|合法选择扣款；超限rejected_rule|
|tm_summon_vanilla|通过|第一幕3、第二幕6点扣款正确|
|tm_console win(B)|通过|返回Enqueued而不是直接完成；wait确认战斗结束|
|tm_rewards_skip|有时序限制|奖励出现前调用报异常，稍后重试成功|
|tm_logs|通过|游标、more、text可读；退出前游戏日志可能未刷盘|
|tm_screenshot|通过|指定实例、PNG、尺寸及Windowed/Fullscreen返回正确|
|tm_wait|通过|等召唤打开及战斗开始/结束；能超时返回最后状态|
|tm_compare_logs|通过|截至本轮结束两端相关行一致；只比较所列关键词，不等于全状态证明|
|tm_bench|通过|各端/state及/ping各100次，见下表|
|tm_battle|通过|实际完成批量选路/截图/召唤/win/跳奖励；约6–7秒一场|
|tm_tree/node_call|通过|先古、事件、宝箱、Boss奖励继续及全屏切换节点可调用|
|tm_reflect|部分通过|读奖励与遗物成功；type目标解析/类型查找有失败，见下|

错误原文：

```text
A/summon/confirm: rejected_rule：不符合规则，不能确认：开局保护：花费超过本场上限
B/rewards/skip: exception：Tried to skip reward set for player 100002, but they are not currently viewing any reward set!
A/reflect: not_found：没有类型 Godot
A/reflect: not_found：没有类型 DisplayServer
```

使用type:Godot.DisplayServer调用WindowSetMode被拆成Godot；短名DisplayServer也未找到。正确可用替代是/root/Game节点ToggleFullscreen，无参数。建议类型全名解析和非游戏程序集检索单独改进，不是本地修复。

首次批量脚本选了总价4的组合，上限3.9，确认被拦；脚本没有及时中止，随后等战斗15秒超时。这是本地测试脚本错误，不是游戏挂死或tm_wait缺陷，后改为单怪立即完成。浮点3.9000000000000004出现在接口，建议显示/返回报价精度整理。

奖励等待：in_combat=false早于奖励界面可用。批量settle_s=2成功，固定睡眠仍不如专门rewards_visible条件可靠；建议增加该条件、奖励读取/领取专门工具。不能自动重试领奖等非幂等动作。

## 测速

冷/热混合单次采样，未控制前后台；A约33ms节拍、B更快可能与窗口帧调度有关，未证实原因。下表为每组100次的本机实测，不含AI决策/外部工具启动时间。

|实例/路由|n|p50 ms|p95 ms|最大 ms|
|---|---:|---:|---:|---:|
|A/ping|100|33.3|33.4|33.6|
|A/state|100|33.3|33.5|42.0|
|B/ping|100|6.2|12.3|18.7|
|B/state|100|9.0|12.2|13.1|

第二场tm_battle总耗时6.57秒（含两次settle_s=2、截图、游戏等待），逐步骤：

|步骤|秒|
|---|---:|
|map_options|0.01|
|map_vote|0.01|
|wait_summon|0.28|
|summon_panel|0.03|
|screenshot_panel|0.1|
|summon_select|0.0|
|screenshot_selected|0.07|
|summon_confirm|0.04|
|wait_combat_host|1.1|
|wait_combat_climber|0.01|
|screenshot_combat|0.5|
|console_win|0.0|
|wait_combat_end|0.28|
|rewards_skip|0.01|

其余成功批量战斗约6.49–6.89秒。结论：接口读取足够快，固定批量测试可用；首次源码调查、逐步工具调用、AI往返显著拖慢整体体验。用户要求减少思考与中间停顿，本轮后续改为批量；不要把请求毫秒延迟当作整个验收耗时。

## 已找到可用调用路径（供开发专门工具）

以下通过tm_node_call/tm_reflect调用，保持原有UI处理/联机提交路径；没有直接改血量或怪物字段。节点后缀自动编号跨运行变化，专门工具应按节点类型/稳定对象定位，不硬编码@Control编号。

- 先古/普通事件：MegaCrit.Sts2.Core.Nodes.Events.NEventOptionButton.OnRelease()，无参数。先古路径/root/Game/RootSceneContainer/Run/RoomContainer/EventRoom/EventContainer/AncientEventLayout/ContentContainer/Content/OptionsContainer/AncientEventOptionButton；普通事件路径为DefaultEventLayout/VBoxContainer/OptionsContainer/EventOptionButton。依据NEventOptionButton.cs:254–283，内部走NEventRoom.OptionButtonClicked(Option,Index)。建议提供event_options/select(index)而不是让助手猜按钮。
- 爬塔玩家开宝箱：MegaCrit.Sts2.Core.Nodes.Rooms.NTreasureRoom.OnChestButtonReleased(NButton _)，args=[null]，路径/root/Game/RootSceneContainer/Run/RoomContainer/TreasureRoom。依据NTreasureRoom.cs:203。仅对B调用，A等待自动。
- 宝箱选择：MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NTreasureRoomRelicHolder.OnRelease()，无参数；路径TreasureRoom/RelicCollection/Container/MultiplayerRelicHolder1。此调用返回成功，但没证实实际获得遗物；不得等同领取通过。需要工具列出每槽真实Relic/Index/可选状态及玩家投票/最终获奖。
- 精英奖励读取：tm_reflect target=node:/root/Game/RootSceneContainer/Run/GlobalUi/OverlayScreensContainer/RewardsScreen|_rewardsSet，depth=2。Rewards里读出GoldReward.Amount=38、RelicReward.Relic=Whetstone。依据NRewardsScreen.cs:159、225–231。
- Boss胜利继续换幕：MegaCrit.Sts2.Core.Nodes.Screens.NRewardsScreen.OnProceedButtonPressed(NButton _)，args=[null]，同上RewardsScreen路径；依据NRewardsScreen.cs:420。已真实进入Hive第二幕。
- 全屏切换：MegaCrit.Sts2.Core.Nodes.NGame.ToggleFullscreen()，路径/root/Game，args=[]；已得到Windowed1699×955和Fullscreen1707×960截图。
- 玩家遗物读取：tm_reflect target=state.Players[1].Relics，depth=0；能列出模型类型。但未保存宝箱前后完整比对，当前仅BurningBlood/LavaRock，不能证明这次宝箱获得遗物。

## 阶段 A 结论和后续

阶段A基本可用，能替代大量手动选怪/win/日志工作；完整MCP stdio注册兼容尚未测试。需要补奖励就绪条件、奖励领取/宝箱状态专门工具、类型全名解析。召唤阶段实测见[summon-phase-result.md](summon-phase-result.md)。禁加Boss候选不存在、宝箱遗物真正到手仍未覆盖，不写成全部通过。退出后核对：两端运行中游戏ERROR=0，StateDivergence=0；A的TowerMaster WARN=0，B有1条奖励未就绪的接口WARN。退出泄漏ERROR原文见召唤报告。
