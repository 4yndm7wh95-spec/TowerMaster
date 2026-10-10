# 测试接口0.0.18验收

代码cb5d8d1，manifest0.0.18；81测试全过，实际安装零警告零错误。使用同一MCP模块的CLI/导入模式，未注册全局stdio服务。身份A100001Host、B100002Client验证正确。所有战斗使用win，无mod代码修改。

## 新工具

|工具|结果|证据|
|---|---|---|
|tm_rewards|通过|普通10金币，精英40金币+Anchor|
|tm_wait rewards_visible|通过|批量战斗自动等奖励就绪，没有提前skip异常|
|tm_rewards_proceed|通过|普通/精英离开奖励，Boss后实际换幕到Hive|
|tm_treasure_open(B)|通过|chest_opened=true|
|tm_treasure|通过|箱内模型/序号、投票、my_relics可读|
|tm_treasure_pick index0|通过|B真实新增Vambrace，A不变|
|tm_event|通过|先古和2个问号事件文字可读|
|tm_event_choose|通过|执行选项，额外升级卡牌界面需兜底|
|tm_reflect类型全名|通过|target=type:Godot.DisplayServer\|，method=WindowGetMode，args=[0]返回Fullscreen|
|tm_battle|通过|自动奖励读取；约4.43–5.05秒一场，部分额外流程约5秒|
|tm_compare_logs|通过|最终清单/替换/生成一致，无StateDivergence|

反射返回签名：static WindowMode Godot.DisplayServer.WindowGetMode(Int32 windowId)。上一轮全名类型找不到问题已修。

事件choose返回chosen但path为空；操作确实成功，建议返回值保留真实节点/事件ID方便证据定位。

额外卡牌升级的实际兜底：/root/Game/RootSceneContainer/Run/GlobalUi/OverlayScreensContainer/NDeckUpgradeSelectScreen节点，OnCardClicked(CardModel card)，args=[{ref:node:同路径|_cards[0]}]；再ConfirmSelection(NButton _)，args=[null]。依据decompiled/sts2/MegaCrit.Sts2.Core.Nodes.Screens.CardSelection/NDeckUpgradeSelectScreen.cs:199、294。没有直接改牌或状态。可追加专门卡牌选择工具。

预览列表滚动：tm_tree找ScrollContainer后tm_node_call set_ScrollVertical(Int32 value)，位置0/400/800/1200/1600/2200/9999，每次截图。匿名节点名动态变化，未写死进产品代码。

## 效率及限制

新增奖励等待明显改善，单场批量约4.4–5秒（含settle_s=1两次与游戏等待），本轮未重新做100次bench，不能把这个当API单次测速。用户面板打开轻微卡顿但接受。

主要阶段A/B操作可以自动进行。商店/休息经map_vote继续，未完整验证其UI必需操作。禁加Boss不存在、部分预览异常、完整自然战斗和平衡未覆盖，详见[summon-phase-result.md](summon-phase-result.md)。本轮两端mod ERROR/WARN=0，运行中游戏ERROR=0，StateDivergence=0。退出阶段资源泄漏详见另一报告。

已保存普通/精英/Boss截图及普通房全列表多位置截图；仅提交报告和测试截图，不提交原始日志、资源或反编译源码。
