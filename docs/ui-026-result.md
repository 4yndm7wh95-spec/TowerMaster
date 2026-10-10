# 0.0.26 界面与规则测试（2026-10-07，部分完成）

结论：界面网格修复已观察到；默认配置与已测开局规则符合说明。但快速跳过战斗时出现 StateDivergence，断线后同进程新局残留暂停/账本状态，当前测试中止。不能宣称本轮全部通过，剩余项目未覆盖。本地未修改代码。

## 环境与安装

被测提交 82db16f，manifest=0.0.26。97 个测试通过（Core 47、TowerMaster 50），编译安装 0 警告/0 错误。master_turn=true。上一轮安装目录 towermaster.config.json 已改名备份，/config 读取新默认值。两端 liuchuan 设置禁用；助手经接口设 A=100001 房主、B=100002，全部操作自行完成。未调用 tm_autoplay 或固定策略机器人。

## 界面与产品需求

| 项目 | 结论 |
|---|---|
| 第一幕网格 | 通过已看画面：7 张一行，标题、统计、确认可见，修复上一轮竖排超屏 |
| 窗口/全屏 | 两种模式已截图：Fullscreen 1707×960；Windowed 1920×1080。界面按打开时计算尺寸，模式切换后未独立重建验收 |
| 选中/取消 | 通过节点 Pressed 信号测试，狂怒选中后取消，再选碎甲/狂怒；picked 与金框/标记可检查。不是物理鼠标点击验收 |
| 确认 | 经可见 Button 的 Pressed 信号进入召唤，未用 draft/confirm 跳过按钮。鼠标坐标命中未覆盖；不能记成实际鼠标点击通过 |
| 悬停 | MouseEntered 信号触发截图，非实际鼠标悬停；放大截图已保存，提示实际鼠标显示与所有边缘裁切未完整覆盖 |
| 文案 | 陷阱完整句式，关键词金色；Dazed 实际中文为“晕眩” |
| 行动目标 | block 选中截图，取消接口返回正常；行动卡悬停和 +N 提示未独立完成验收 |
| 第二幕/已有/预算变暗 | 未覆盖：断线前未进入第二幕；没有实测“已有”和超预算后的完整视觉变化 |

原版中文核对：LocManager.Instance.SmartFormat(new LocString("cards", "DAZED.title"), null) 返回“晕眩”。这是只读调用。

重要需求更正：用户要真正的塔主专属 CardModel/牌组/原版操作体系，能在牌组看到，替代英雄卡牌；当前只借用 card.tscn 和 Alchemize 卡框放在自建面板里，不能称为已满足需求。用户澄清已写 balance-review-request.md、提交 4931488。

## 已测规则

/config 的新值符合文档：普通上限1.35、精英折扣0.85/上限1.3/另加3、Boss另加1.0；收入5/6/7、初始12、战果每15血+1/最多2、击倒3；威胁总3/4/5、首轮2/3/3、逐轮+1、保护2；力量1/1/2、上限2/3/4；躲过10。尚未逐项对所有字段作独立战斗验证。

第一场普通房开局保护标准3，上限3.9。两只 FossilStalker 总价7（怪物6、群体税1），can_confirm=false，violations=[OpeningProtectionCost]，提示“开局保护：花费超过本场上限”。这是保护规则，不能冒充第四场 OverSpendCap 验证。

第一场 /threat 第1、2、3回合 points=2、points_total=2、points_remaining=2，助手每回合主动结束、未消耗威胁点。后续普通房解锁、精英/Boss报价、力量上限与 Amounts=0、空陷阱10金币及提示未覆盖。

## 不同步及新局残留

第一次接口启动过早，ReturnToMainMenu 打断 Logo 异步启动，A 出现 GameStartupError/取消调用栈和致命错误弹窗；已归档并退出重启。等待菜单启动完成后没有该弹窗。不能把该次操作错误归因于 mod 加载失败。

后续首场自然战斗正常；快速推进第二、第三场，曾在玩家回合尚未就绪时执行 win，且地图投票进入队列。第三场淤泥旋螺开局附近两端不同步，首个 ID32：

```text
[ERROR] State divergence detected! Checksum with ID 32 for client 100002 doesn't match host's!
Context: finished action execution TowerMasterSummonGameAction. Local: 305405132. Remote: 1171254527.
```

后续 ID33/34 也不一致，B 断开；随后控制台调用出现未连接时发送 RequestEnqueueActionMessage。状态转储中首次双方最后动作 ID 为35与37，生命值相同。时机与动作顺序值得排查，但尚不能确定是接口调度、win时机还是 mod 动作同步缺陷。win 仅用于非对照流程推进，不计为自然对局。

断线后助手通过 ReturnToMainMenu 重建大厅/新局，种子655804503154396331，两端在先古之民界面，却 paused_by_master_turn=true，A账本 points=13、battles=2，而不是新局12点/0场；B ErrorPopup 仍保留。用户“又掉线了”的截图对应上一场淤泥旋螺弹窗，日志未新增第二次不同步。重新建局未清理的状态必须单列，不能继续用这一状态验收。

## 稳定性与未覆盖

nvidia-smi 可用，单次采样2738MiB、GPU39%。没有完成第二幕选陷阱停留10分钟/30秒采样，也未完成5次开关显存趋势，不能得出设备丢失回归通过。R1/R2/R3及相匹配自然对照未完成；不出胜率或调参结论。

截图列表：
- ui026-action-target.png
- ui026-draft-fullscreen.png
- ui026-draft-hover.png
- ui026-draft-selected.png
- ui026-draft-windowed.png
