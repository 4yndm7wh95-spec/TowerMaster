# 0.0.25 界面验收与自动测试结果

## 结论

界面部分通过，不能整体验收通过：原版卡牌框架成功启用，行动目标按钮已移到头顶，陷阱冷却有效；自由挑陷阱布局在全屏下退化为单列，后面的候选卡和确认按钮超出屏幕，需要修复。

仅测试、只读定位和本地配置/调用调整，未修改 mod 或 MCP 源码。用户协助进入最初先古之民界面后外出；后续操作、重开局、出牌、事件、退出等由助手经测试接口完成，未使用 Computer Use，早期 UI 与机器人阶段未使用 win；机器人停止后的功能回归使用 win 跳过精英/Boss 战，明确排除平衡样本。

## 环境

- 被测提交 b1adc4b，分支 claude/optimistic-rubin-hr3eit，manifest 0.0.25；游戏 v0.111.0/net9.0，本机双实例。
- 94 个测试通过：Core 46、TowerMaster 48。编译安装成功，0 警告、0 错误，安装目录 art 的既有 27 张图齐全。
- master_turn=true；master_stay_dead 未配置，默认 false。UI 阶段默认威胁点，基准/召唤阶段通过安装目录配置设为 0；具体平衡配置和样本见 balance-results.md。
- 两端日志确认：`[INFO] Skipping loading mod liuchuan, it is set to disabled in settings`。截图使用原版铁甲战士，未再使用川换皮。
- 塔主 100001 为房主，爬塔玩家 100002。重启后 IP 直连读取共享身份配置，助手用其 UpdateProfile 设置两进程身份，并在开局后核验；详情见自动化限制。

## 界面逐项验收

| 项目 | 结论 | 证据 |
|---|---|---|
| 自由挑陷阱原版卡框 | 通过框架，布局不通过 | ui025-draft-initial/selected：标题、配图、类型牌、费用、说明均显示，模板 Alchemize。7 张候选呈长单列，确认按钮在屏幕外。 |
| 费用位置 | 与要求不同 | 使用原版左上角费用圆标，并非测试说明要求的右上角；需决定沿用原版还是另调位置。 |
| 预算/张数/手牌、已选 | 通过已测项 | 预算 0/5→4/5、本幕挑 0/3→3/3、手牌 0/6→3/6；碎甲显示金边及“已选”。“已有”标记未在后续幕实测。 |
| 超预算、超张数拒绝 | 通过接口规则 | picks=[2,3,5] 总成本 6 超过预算 5，拒绝；一次选 6 项亦拒绝。返回原因见下文。未验证屏幕外候选的鼠标命中。 |
| 确认进召唤 | 通过接口流程 | 选择 [0,4,5] 后 confirm 返回 brittle@1、mire@1、rally@1 和 summon_open=true。可见界面的确认按钮本身不可达，不应因此记成布局通过。 |
| 每幕开头的选牌 | 第一幕覆盖 | 多次新局第一幕验证；第二、第三幕没有独立验收，不以同一实现推断通过。 |
| 塔主行动卡原版框架 | 通过显示 | ui025-weak-target、block-target：八张原版框架行动卡位于底部，费用和说明显示，没有回退自绘日志。 |
| 怪物/玩家头顶目标 | 通过本轮画面 | tm_threat_ui select=block/weak 分别截图，虚弱按钮位于原版铁甲战士头部上方；怪物目标同样在上方。 |
| 取消选中 | 通过接口返回 | 不带 select 调用 tm_threat_ui 返回 selected=null。取消后截图采于回合结束，不能作为独立的视觉取消证据。 |
| 上一场陷阱冷却 | 通过 | ui025-trap-cooldown-correct：碎甲变暗，cooling=true；选择它的当前序号 2 被 unknown_option 拒绝。注意手牌序号会因收回重排，必须重新读取。 |
| 默认隐藏复活 | 通过本轮已走流程 | 获胜后塔主生命 7/80、存活 true（铁甲战士复活 1 血再回血 6），战斗中只显示爬塔玩家英雄与右侧塔主形象，玩家列表无塔主。事件可继续。 |
| 通用死亡事件 ERROR 回归 | 以最终日志统计为准 | 本轮已测事件未再观察到该错误；完整计数在文末。 |
| 用户主观意见 | 未覆盖 | 用户外出，未收到本轮新界面的外观评价；不要求其回来协助测试。 |

## 日志与拒绝原文

```text
INFO 原版卡牌框架：卡框模板 Alchemize
A/traps/draft/select: rejected_rule：这样选不行（超预算、超张数、手牌满或已有同种）
A/summon/select: unknown_option：不在可选列表里：陷阱序号 2（不存在或冷却中）
```

本轮未看到“原版卡牌框架不可用，改用自绘卡片”或“填卡面失败”。引用为短日志摘录，未提交原始日志。

## 只读定位：选牌布局

mod/TowerMaster/TrapDraftPanel.cs:23–27 创建全屏 CenterContainer 与无明确宽度的 VBox；:63 创建 HFlowContainer，没有为它限定可用宽度，也没有滚动容器。实际截图显示按单卡宽度换行，整体高度远大于屏幕。建议 Claude 给候选区确定宽度/高度和滚动区域，固定顶部统计及底部确认按钮。本轮没有改实现。

## 自动化问题、处理方式与报告边界

1. tm_autoplay 的“回合编号变了”不能证明抽牌和出牌阶段已就绪。首次默认配置战斗多次空过，最终死亡，该场不进入正式平衡对比。助手额外检查 CombatManager.PlayerActionsDisabled=false、IsPlayerReadyToEndTurn=false、手牌已出现、塔主暂停已解除，再出牌。
2. 原机器人会尝试不可支付的牌，日志出现 PlayCardAction Canceled ERROR。后续调用增加费用过滤、等手牌/能量变化，保持 attack/block 的类别排序；使用 tm_play/tm_end_turn 自然打，不调用 win。正式结果是“同策略、外部调用修正后的机器人”，不能宣称未经修正的 tm_autoplay 已通过验收。
3. 燃烧 Brand 要消耗手牌，tm_cards 返回 visible=false，而动作已是 GatheringPlayerChoice。只读依据：decompiled/sts2/MegaCrit.Sts2.Core.Models.Cards/Brand.cs:36–47，OnPlay 内调用 CardSelectCmd.FromHand。助手调用 NPlayerHand.SelectCardInSimpleMode(NHandCardHolder)，再 OnSelectModeConfirmButtonPressed(NButton)，恢复动作。对应源码 NPlayerHand.cs:904、:981。需要专用“手牌选择”工具，不能只覆盖弹窗选牌。
4. RoomFullOfCheese 的第一项需要选两张牌；早期调度未完成选择即投下一房，导致两端黑屏，room=null，MoveToMapCoordAction 长期 Executing。截图 room-stuck-A/B。依据 EventRoom.cs:81–83：Exit 要 await EventSynchronizer.AwaitPendingOptionTasks；RoomFullOfCheese.cs:37–44：Gorge 要 await 选两张。该次操作顺序错误，不能据此认定 mod 自发黑屏。后续先完成事件，优先选无需选牌的可用选项；该卡住样本不计有效场数。
5. 重启后 DirectConnectIP 读取公共配置中的 100002，而非启动参数 100001；身份重复导致加入不成功。调用 DirectConnectIP.ModEntry.Config.UpdateProfile(string, ulong) 分别设置 A/100001、B/100002；签名依据 decompiled/DirectConnectIP/DirectConnectIP.Helpers/ModConfigManager.cs:192。失败大厅还会占用旧监听，IPv4 绑定失败后落到 IPv6，IPv4 客户端超时。退出进程清理后恢复；后续退出未开始的大厅先调用 CleanUpLobby，成功开局后核验身份。未改 IP 直连代码或资源。
6. 从卡住状态返回主菜单时 B 出现 ExitCurrentRooms NullReference 与未连接时发送校验消息等错误；这是取消未完成操作后的清理异常，另列，不能隐藏。

有缺口的接口建议：新局建房加入与身份隔离、明确的“玩家可以出牌”等待条件、可支付判断与动作完成等待、手牌选择和多选确认、事件已结束条件。这样才适合无人值守批量平衡测试。


## 后续功能回归与中止（2026-10-07）

机器人按用户要求停止。随后仅用接口测试流程，使用控制台 win 跳过当前精英和第一幕 Boss，不能将这些场次算作自然战斗或平衡数据。精英奖励接口读到金币 40 与 EternalFeather 遗物；此为本场奖励读取，不是混搭精英条件的验收。

- 休息处可继续，塔主日志“测试3 休息处：塔主跳过”；第一次接口操作后延迟才切换，重复点选出现 HealRestSiteOption 不在列表的错误，属于测试重复提交，不能判定完全无异常。
- Boss 奖励之后 B 调用继续，自动进入第二幕 Hive；A 自动准备，没有要求操作塔主。日志“测试3 换幕：跟随玩家 100002 准备，第 0 幕”；显示的幕数值得开发核对，但实际已进入第二幕。
- 第二幕第一次召唤前再次出现选陷阱：act=2、budget=5、max_picks=3、hand_limit=6，候选为 +1，截图 ui025-act2-draft-A.png。候选仍竖排成一列，标题和后续卡/确认按钮超屏，再次不通过。当前手牌为空，owned=false，“已有”标记仍未覆盖。
- 用户原话：“这界面不对吧”“怎么全竖着呢”；要求：“让他把卡牌的表述学原版的表述”。文案与布局要求已推送 balance-review-request.md。
- 崩溃前最后一次两端 tm_compare_logs equal=true；并非所有未执行的回归均已通过。第三幕选牌、后续目标效果复测未覆盖。

## 塔主端崩溃

用户报告 A 崩掉。A 进程已退出，B 仍在运行；没有重启 A，原始日志已保存到本地 work/logs-ui025-crash，未提交。A 游戏日志最后：

```text
ERROR: D3D12 device lost in command_queue_execute_and_present.
Adapter: NVIDIA GeForce RTX 4060 Laptop GPU
Original HRESULT: 0x887a0005
Device removed reason: DXGI_ERROR_DEVICE_REMOVED (0x887a0005)
at: _check_device_removed (drivers/d3d12/rendering_device_driver_d3d12.cpp:6325)
```

直接失败点是图形设备丢失，不是日志中的托管 mod 异常。不能仅凭此判断驱动、资源压力、Godot 或 mod 渲染谁是根因。没有找到对应的 Windows Application 事件记录。本轮不自行改渲染参数、驱动或 mod。

时间线：第二幕 OROBAS 事件选择炼金箱 → B 投票下一普通房 → 塔主打开第二幕选陷阱并扣住移动 → 页面停留数分钟 → A D3D12 设备丢失 → B 断开并返回主菜单。塔主 mod 日志最后是“召唤阶段：Monster 房，幕 Hive，召唤点 20，标准开销 6，扣住移动”。两种日志时钟不同，不能直接将时间字符串相减。

B 断开清理阶段出现：
```text
[ERROR] Attempted to send message MegaCrit.Sts2.Core.Multiplayer.Messages.Game.Flavor.MapDrawingModeChangedMessage while MegaCrit.Sts2.Core.Multiplayer.NetClientGameService is not connected!
ERROR: System.ObjectDisposedException: Cannot access a disposed object.
```

需开发侧先修选陷阱布局，并检查卡面预览节点生命周期、关闭释放与第二幕重建，之后同场景复测。图形设备错误需进一步对照验证，当前不能归因于布局超屏。

## 最终日志统计口径

统计崩溃时保存的当前进程日志，包含早期机器人/清理/重复操作；不是成功场次独立计数。ERROR/WARN 按包含对应标记的行计数，不等于异常事件数。未合并更早的已归档进程日志。

| 日志 | ERROR 行 | WARN 行 | StateDivergence 字样 | 通用死亡事件错误字样 |
|---|---:|---:|---:|---:|
| 游戏 A | 9 | 1577 | 0 | 0 |
| 游戏 B | 17 | 463 | 0 | 0 |
| TowerMaster A | 0 | 0 | 0 | 0 |
| TowerMaster B | 0 | 0 | 0 | 0 |

WARN 主要包含大量 Asset not cached 等资源警告，不能宣称游戏日志无异常。ERROR 包含前述 PlayCardAction Canceled、清理异常、重复休息提交与最终设备丢失。平衡测试终止原因与开发复审要求详见 balance-review-request.md，现有机器人数据不用于调数值。
