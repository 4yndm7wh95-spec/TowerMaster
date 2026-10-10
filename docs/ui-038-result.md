# 0.0.38 测试结果与用户新增需求

日期：2026-10-08。代码：`d46e155`，分支 `claude/optimistic-rubin-hr3eit`。仅测试和只读定位，未修改 mod 代码。测试助手完成全部操作，仅使用测试 A/B（塔主 100001 / 爬塔玩家 100002），未操作用户自己的游戏。川换皮未加载，使用原版铁甲战士。全程沿地图有效连线投票进房；未用 room/fight/win，也未加能量、抽牌、回血或修改战斗数值。不作胜率或平衡结论。

## 结论

| 项目 | 结果 | 依据 |
|---|---|---|
| 编译、测试、安装 | 通过 | 105 个测试通过（规则库 47、mod 58），游戏安装构建 0 错误、0 警告，manifest=0.0.38 |
| 配置覆盖 | 通过 | 仓库配置覆盖安装配置，SHA256 一致，master_cards=true |
| 三幕普通怪、精英预览 | **不通过** | 已逐页和滚动截图，多幕仍缺头、裁上半身、散件、过小，并非用户截图中的少数怪 |
| 关两个进程再读档 | 通过 | 先验证旧存档，再在本轮休息处删牌后完整重启；9 张牌、23 点/6 场完全保留 |
| 同进程读档 | 通过 | 商店新增坚壁、休息处删除易伤后分别读档，牌组和余额一致，同房间不重复弹选牌 |
| 商店买行动牌 | 通过 | 坚壁入牌组，23→17，实际扣 6 点 |
| 精英奖励 | 通过 | 自然地图精英战，多尼斯异鸟胜利；塔主三选一，选复苏后 9→10；玩家奖励有遗物、42 金币 |
| 塔主出牌 | 通过（本轮样本） | 虚弱通过原版联机出牌接口成功，两端动作摘要相同；结束塔主后玩家恢复 |
| 塔主回合拒绝 B 提交动作 | **不通过** | /combat/hand 被拒，/combat/play 和 /combat/end_turn 仍接受并入队，检查放错方法 |
| 联机一致性 | 通过（本轮覆盖） | 两个进程批次动作摘要分别 15/15、34/34 全等，StateDivergence=0 |
| 无任何日志异常 | 不通过 | 爬塔端读档 WARN、一次 Invalid Task ID、退出资源泄漏告警，详见下文 |

配置 SHA256（两份相同）：`CE7D223D1626984CFD04F2F8E54D0CF4819EC3B6BDEB2B783F4866E23D169301`。

## 1. 怪物预览：必须按整体问题处理

第一幕顶部和底部均已查看；第二、三幕列表及各幕「只看精英」均已查看。本次普通房解锁列表为第一幕 33 种（含 4 精英）、第二幕 8 种（含 2 精英）、第三幕 12 种（含 2 精英）。结论仅针对这批实际候选，不代表游戏所有模型或 Boss 预览全覆盖。卡片在滚动窗口边缘被整张切去一部分，属于滚动视口行为；以下只列卡片完整可见时，模型本身的缺失。

| 幕 | 怪物 | 观察 |
|---|---|---|
| 一 | 劫掠者刺客、劫掠者斧手、劫掠者弩手 | 仍缺头/上部，刺客只见身体与武器 |
| 一 | 淤泥旋螺 | 极小，只有分离的小点和很小主体，无法作为识别图 |
| 一 | 化石追踪者 | 多个骨架部件散开，没有完整身体 |
| 一 | 幽灵船 | 主体和帆等部件分离，取景不完整 |
| 一 | 旧日雕像 | 只见下部石座/腿，上部在卡片顶部之外 |
| 一 | 鬼祟珊瑚群 | 只见分散珊瑚部件，整体不直观；需对照原版判断组成是否合理 |
| 一 | 墨宝 | 本次能看到黑色猫形主体和亮眼，不再是用户上一轮截图那样散开的小点 |
| 一 | 蛇行扼杀者 | 本次主体盘成一体，未见上一轮的两段分离 |
| 一 | 缩小甲虫 | 身体可见；头上有白色粒子，不能仅据粒子判定缺件 |
| 二 | 棘刺蟾蜍、猎人杀手、虱虫之祖 | 明显被裁掉顶部/上半身 |
| 二 | 蜂群术士 | 头和上部缺失，主要显示腿/下身 |
| 二 | 感染棱柱 | 仅有顶边少量红色部件、蓝色碎片和影子，主体不完整 |
| 三 | 活体盾 | 腿和盾可见，头/上部被裁 |
| 三 | 虔诚雕刻师、电球头 | 上半身/头部被裁，电球头只剩腿部 |
| 三 | 失落之物、遗忘之物 | 主体贴顶且不完整，需要重新取景 |
| 三 | 猫头鹰法官、史莱姆狂战士 | 上部明显切在卡片顶边 |
| 三 | 灵魂枢纽、机甲骑士 | 精英预览缺上半部；机甲骑士主要只见双腿 |

对照：多尼斯异鸟、蛮兽、飞蝇菌子、小啃兽、拳击构装体、青蛙骑士等相对完整。啃咬机、高塔炮手、咬人卷轴明显较小，是否加大属于外观调整建议，不能等同于缺件。

证据：

- [第一幕顶部](screenshots/ui038-act1-top.png)、[第一幕底部](screenshots/ui038-act1-bottom.png)、[第一幕精英](screenshots/ui038-act1-elite.png)。
- [第二幕全部](screenshots/ui038-act2-top.png)、[第二幕精英](screenshots/ui038-act2-elite.png)。
- [第三幕全部](screenshots/ui038-act3-top.png)、[第三幕精英](screenshots/ui038-act3-elite.png)。

两端 TowerMaster 日志均没有「套皮肤/启动动画失败」「画不出」「自动取景失败」。**没有异常日志并不意味着预览通过**。打开时未做帧时间采样，不能给出准确卡顿量；接口响应时间也不代表渲染流畅程度。本轮不将“没有明显卡顿”作为通过结论。

只读定位供 Claude 排查（推断，尚未验证根因）：

- `mod/TowerMaster/SummonPanel.cs:603` `Portrait(...)` 在节点 Ready 之前读取 Bounds；原版 `decompiled/sts2/MegaCrit.Sts2.Core.Nodes.Combat/NCreatureVisuals.cs:154` `_Ready()` 才给 Bounds/SpineBody 赋值。需要检查创建时实际走的是 Bounds 分支还是默认 0.25 缩放。
- `SummonPanel.cs:657` `SetUpLikeCombat(...)`：套皮肤/动画的反射查找含静默跳过分支，故“无 WARN”不足以证明两步真的执行。
- `SummonPanel.cs:678` `FitAndFreeze(...)`：有限次数缩小后，即使像素仍贴视口边，也会进入放大/定格；已经被视口裁掉的部分无法从图片像素范围中恢复。截图中许多主体正好切在顶部，应重点核对完整包围盒、重试退出条件、最终缩放后是否再次检查边界。
- 原版 `NCreature.cs:310` 先生成 Animator，再 `SetUpSkin`，随后连接动画信号；预览不是完整战斗节点流程。是否必须执行额外初始化仍不确定，不能直接断言“缺头就是皮肤失败”。

## 2. 存档恢复

第一批次读取上一轮存档：种子 `17168831314051600511`，第一幕休息处 (0,10)，9 张、17 点、4 场，完整匹配，已删牌未回来。

本轮继续：普通战→商店 (1,12) 买坚壁，牌组 9→10，召唤点 23→17；同进程读档 10 张/17 点/5 场完全一致。再沿地图普通战→休息处 (0,14) 删除易伤，10→9；同进程读档 9 张/23 点/6 场一致。然后回主菜单、关闭两个测试进程、用 A/B 脚本重开、多人读档：仍是相同的 9 张/23 点/6 场；没有再弹删牌界面。

最终 9 张的 key（包括重复牌）：block×2、heal、strength、weak、dazed、scheme、daze_all、fortify_all，全部等级 @1。被删除的 vulnerable 未恢复。

日志顺序原文：

```text
[03:02:21.182] INFO 塔主账本：读档，召唤点 23，已打 6 场
[03:02:21.191] INFO 塔主牌组：读档后按账本同步牌组，发出新牌组（9 张）
```

[冷启动旧存档](screenshots/ui038-cold-loaded.png)、[本轮休息处删除后](screenshots/ui038-rest-deleted.png)。牌组一致性按 tm_master_deck 的实际 key/顺序核对，截图只作辅助。

爬塔端每次加载约 20 秒后均出现：

```text
[03:02:41.263] WARN 塔主牌：等不到读档完成（不是房主或没有对局），不同步牌组
```

房主恢复成功，实际不影响本次牌组；但爬塔端本来就不是房主，建议区分正常非房主退出与真正加载超时，避免误报。

## 3. 接口限制回归：发现检查位置错误

实际塔主 active=true 时：

```text
B /combat/hand → invalid_phase：塔主回合中，玩家出牌暂停，等塔主结束再出
B /combat/play → {"enqueued":"Bash","target_type":"AnyEnemy","target":"enemy 0"}
B /combat/play → {"enqueued":"StrikeIronclad","target_type":"AnyEnemy","target":"enemy 0"}
B /combat/end_turn → {"enqueued":"EndPlayerTurnAction","turn":1}
```

这是有意各提交一次的负例测试，不是脚本连续重试。塔主结束后，前面的 Bash 进入实际执行（能量 3→1，敌人血量下降）；第二场的攻击和结束动作也在恢复后执行。因此不符合用户要求的“提交时拒绝”。后续正常操作始终先看塔主 active，再结束塔主，等待玩家阶段；未用失败重试堆积请求。

只读定位：`mod/TowerMaster/TestBridge.cs:633` `CombatHand()` 的第 637 行放了暂停检查；`CombatPlay(JsonObject)` 第 669 行开始的执行路径没有此检查，`CombatEndTurn()` 第 701 行开始也没有。请 Claude 修正位置，并允许只读手牌查询返回 paused 状态。

## 4. 战斗与精英回归

旧存档继续打两场普通战（树叶史莱姆小），一场测试塔主虚弱，日志效果两端一致，均胜利。另开新局种子 `17101550717777027434`，沿地图：

`(3,1)普通 → (3,2)普通 → (2,3)商店跳过 → (1,4)普通 → (0,5)普通 → (0,6)精英`。

普通房前三场选蟾蜍蝌蚪，第四场树叶史莱姆小；精英选多尼斯异鸟，未使用房间/战斗跳转或 win。精英自然打到第 5 回合胜利；玩家战后 25/80。期间一次涅奥之怒打开原版弃牌堆选择，用原版 `NCombatPileCardSelectScreen.CompleteSelection()` 确认可选 0 张的选择，继续正常动作。这是原版选择回调，不是改牌堆或强行结束战斗。简化测试出牌不是平衡样本。

精英战后：塔主候选迷雾、复苏、弱点暴露，选择复苏后 9→10 张；爬塔玩家奖励含 42 金币、SkillPotion、BeatingRemnant 遗物和卡牌奖励。这里只确认奖励生成，不把跳过玩家奖励界面当成已领取金币/遗物。

[精英召唤](screenshots/ui038-elite-panel.png)、[塔主精英奖励](screenshots/ui038-elite-reward.png)。

两批次去时间戳后的全部「动作摘要」：15/15、34/34，逐行完全一致，包含选牌后牌组数量。两端所有保留日志 StateDivergence=0；本轮无掉线或黑屏。

## 5. 日志异常统计与原文

| 范围 | TowerMaster A ERROR/WARN | TowerMaster B ERROR/WARN | 游戏 A ERROR/WARN | 游戏 B ERROR/WARN | StateDivergence |
|---|---:|---:|---:|---:|---:|
| 第一进程批次，退出前归档 | 0/1 | 0/3 | 0/189 | 1/62 | 两端 0 |
| 第二进程批次，正常退出后 | 0/0 | 0/1 | 12/217 | 12/72 | 两端 0 |

按包含 ERROR、WARN/WARNING 的日志行计数，并非独立异常种类。第一批次退出前已保存；该批次的退出资源诊断未纳入，不能与第二批次直接比较增长。第二批次结束前游戏 ERROR 为 0/0，12/12 全在退出清理时产生。

塔主唯一 WARN 为测试助手首次尝试用 GodotObject.Set 设置滚动条时参数绑定失败，随后改用属性 setter 成功，属于调用方式问题：

```text
[02:43:25.006] WARN 测试接口 /node/call：System.Text.Json.JsonException: The JSON value could not be converted to Godot.StringName. Path: $ | LineNumber: 0 | BytePositionInLine: 17.
```

爬塔端四条 WARN 均为上面的非房主读档超时提示。两端没有套皮肤/启动动画失败 WARN。

第一批次 B 的游戏 ERROR 出现在回主菜单资源预加载附近，之后正常加载并继续测试，未复现为黑屏：

```text
ERROR: Invalid Task ID
   at: wait_for_task_completion (core/object/worker_thread_pool.cpp:418)
   C# backtrace (most recent call first):
       [0] void Godot.Bridge.ScriptManagerBridge.GetOrLoadOrCreateScriptForType(System.Type, Godot.NativeInterop.godot_ref*)
```

其余堆栈包括 ScriptManagerBridge.UpdateScriptClassInfo、godotsharp_internal_reload_registered_script、GetOrCreateScriptBridgeForType、GetOrCreateScriptBridgeForPath。未确定是否 mod 引起，不应直接归因于本轮修复。

退出时两端都有 RID/shader/resource 未释放信息，未伴随本轮运行中崩溃。A/B 分别 12 条 ERROR，详见下列实际错误行（只摘错误，不提交原始日志全文）：

游戏 A：

```text
ERROR: 1 RID allocations of type 'N26RendererEnvironmentStorage11EnvironmentE' were leaked at exit.
ERROR: 5 shaders of type CanvasShaderRD were never freed
ERROR: 25 RID allocations of type 'N10RendererRD16ParticlesStorage9ParticlesE' were leaked at exit.
ERROR: 1 shaders of type ParticlesShaderRD were never freed
ERROR: 25 RID allocations of type 'N10RendererRD11MeshStorage4MeshE' were leaked at exit.
ERROR: 71 RID allocations of type 'N10RendererRD15MaterialStorage8MaterialE' were leaked at exit.
ERROR: 6 RID allocations of type 'N10RendererRD15MaterialStorage6ShaderE' were leaked at exit.
ERROR: 179 RID allocations of type 'N10RendererRD14TextureStorage7TextureE' were leaked at exit.
ERROR: 331 RID allocations of type 'PN18TextServerAdvanced22ShapedTextDataAdvancedE' were leaked at exit.
ERROR: 10 RID allocations of type 'PN18TextServerAdvanced12FontAdvancedE' were leaked at exit.
ERROR: 8 RID allocations of type 'PN18TextServerAdvanced27FontAdvancedLinkedVariationE' were leaked at exit.
ERROR: 229 resources still in use at exit (run with --verbose for details).
```

游戏 B：

```text
ERROR: 1 RID allocations of type 'N26RendererEnvironmentStorage11EnvironmentE' were leaked at exit.
ERROR: 5 shaders of type CanvasShaderRD were never freed
ERROR: 8 RID allocations of type 'N10RendererRD16ParticlesStorage9ParticlesE' were leaked at exit.
ERROR: 1 shaders of type ParticlesShaderRD were never freed
ERROR: 8 RID allocations of type 'N10RendererRD11MeshStorage4MeshE' were leaked at exit.
ERROR: 19 RID allocations of type 'N10RendererRD15MaterialStorage8MaterialE' were leaked at exit.
ERROR: 6 RID allocations of type 'N10RendererRD15MaterialStorage6ShaderE' were leaked at exit.
ERROR: 184 RID allocations of type 'N10RendererRD14TextureStorage7TextureE' were leaked at exit.
ERROR: 106 RID allocations of type 'PN18TextServerAdvanced22ShapedTextDataAdvancedE' were leaked at exit.
ERROR: 10 RID allocations of type 'PN18TextServerAdvanced12FontAdvancedE' were leaked at exit.
ERROR: 7 RID allocations of type 'PN18TextServerAdvanced27FontAdvancedLinkedVariationE' were leaked at exit.
ERROR: 232 resources still in use at exit (run with --verbose for details).
```

常见 WARN 为 Asset not cached、网络 packet writer 扩容、Byrdonis FMOD 参数缺失：

```text
WARNING: FMOD parameter 'EnemyImpact_Intensity' not found on event 'event:/sfx/enemy/enemy_attacks/byrdonis/byrdonis_hurt'
[WARN] Warning: Packet writer is growing from 65536 bytes to 131072 bytes!
[WARN] Asset not cached: res://scenes/creature_visuals/sludge_spinner.tscn
```

## 6. 用户追加的塔主卡牌设计方向（交给 Claude）

用户原话：

> 让claude对塔主卡牌再调整调整，可以是再设计点卡牌 可以是对现在的卡牌修改，毕竟这是个联机mod 和朋友玩的 娱乐为主 可以加一些比较恶搞的 搞笑的牌或者特殊机制也可以的

> 你有啥想法也可以提供一下，让他做一些参考 但不一定直接采纳

请 Claude 自主检查、重新设计，不限于调现有数值。娱乐性、朋友间互动、出乎意料的局面是方向；保留之前的真实原版牌组/手牌/出牌框架，不回退成仿卡牌按钮面板。以下仅测试助手可选建议，不是用户强制方案，也未验证实现可行性或平衡性：

1. **临时换剧本**：改变怪物本回合意图，立即公开新意图，让玩家重新安排出牌。同步动作必须一致，不能偷偷变更已执行动作。
2. **有奖挑战**：给玩家一个可拒绝的小目标，成功获金币或临时资源；塔主花资源提高挑战奖励/难度。不要把普通操作变成强制罚款。
3. **损友礼物**：送一张强力临时牌，附带明确公开的小副作用，是否使用由玩家决定。避免强制打乱牌组导致永久损失。
4. **怪物内讧**：牺牲一只小怪的行动来强化另一只，或让怪物互相伤害换资源，形成有趣取舍。

建议把笑点放在可理解、可反制的战局变化上，避免长期锁操作、频繁强制弹窗、文字恶搞但功能重复。具体牌名、触发、费用、上限、持续时间、随机范围由 Claude 判断；不要求直接采纳这些点子。

用户本轮还强调：“还有很多怪展示的不全”“不止是我这里截图的”。请优先修整体预览管线，并用全候选截图验收，不只给截图中某几只写特例。
