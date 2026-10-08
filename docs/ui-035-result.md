# 0.0.35 塔主奖励与新牌实测

## 结论

**0.0.34 的奖励覆盖/卡住问题回归通过。** 两局共四次精英胜利，塔主三选一均自然出现在最上层；专用 `/cards`、`/cards/pick` 可以列牌、选择和跳过。选牌/跳过后均能继续正常走地图。本轮没有移除覆盖层、手动关闭地图或直接调用选牌节点的兜底。

衰竭、复苏、坚壁已实际打出，两端效果一致；鼓动候选说明只显示一行“消耗。”。迷雾、弱点暴露、筹谋的效果未覆盖，不能宣称全部新牌通过。全程 92 条动作摘要去时间戳后完全一致，StateDivergence 为 0。

## 环境与手段

- 拉取代码：`e0099e0`，分支 `claude/optimistic-rubin-hr3eit`，manifest `0.0.35`。
- 测试 104/104：Core 47、TowerMaster 57。编译安装 0 警告、0 错误。
- 仓库 `towermaster.test.json` 覆盖安装文件，双方共用安装目录，SHA256 均为 `CE7D223D1626984CFD04F2F8E54D0CF4819EC3B6BDEB2B783F4866E23D169301`，`master_cards=true`。
- 只操作测试桥 A/47101（NetId 100001、房主）与 B/47102（100002），未操作用户自己的游戏。川换皮未加载；截图为原版铁甲战士。两个测试实例最终通过 `NGame.Quit()` 正常退出。
- 两局全沿地图投票进入房间；无 room/fight/win，无机器人接口。普通战通过原版 `PlayCardAction` 出牌、`EndPlayerTurnAction` 结束回合。
- 四场精英选旧日雕像，B 使用 `energy 30`、`draw 7` 辅助，多回合需要时再次执行；仍由攻击牌实际击杀。这些场次不用于平衡结论。
- 为抽到奖励牌，对塔主使用 `draw 6`/`draw 7`；复苏的第 2 回合另使用 `energy 1`、`energy 3`。第一次复苏尝试早于加能量动作执行完毕被拒，等待生效后成功。这里只验证效果，不验证默认能量下的强度。
- 只读反射用于覆盖栈顺序、能力层数、怪物格挡；没有用反射生成新牌、修改规则或直接应用效果。

启动两端都有：

```text
塔主牌（原版手牌出牌）：设置 master_cards=True
塔主牌：已生成 75 种卡牌类型（TowerMasterBlock1 …），等 ModelDb.Init 收录
塔主牌：本地化表 cards 补了 150 条（例 TOWER_MASTER_BLOCK1.title）
```

## 奖励自然流程

第一局种子 `13773383162230189834`，第一幕 Overgrowth。精英坐标 `(5,9)`、`(3,13)`；正常经过普通战、休息处、事件、宝箱、商店。

第二局种子 `6755132031294623499`，第一幕 Underdocks。精英坐标 `(5,6)`、`(4,10)`；途中问号房自然出现化石追踪者战斗。没有用控制台直接创建精英房。

| 局/场次 | 候选（接口读取的顺序） | 操作 | 塔主牌组 | 自然跟随 |
|---|---|---|---|---|
| 第一局第 6 场精英 | 迷雾、衰竭、鼓动 | `/cards/pick index=1` | 9→10，增加衰竭 | B 投票 `(5,10)`，两端进入该普通战 |
| 第一局第 9 场精英 | 复苏、鼓动、筹谋 | `/cards/pick skip=true` | 10→10，完整牌组与跳过前相同 | B 投票 `(3,14)`，两端进入休息处 |
| 第二局第 4 场精英 | 复苏、迷雾、鼓动 | `/cards/pick index=0` | 9→10，增加复苏 | B 投票 `(4,7)`，两端进入问号战斗 |
| 第二局第 6 场精英 | 坚壁、衰竭、鼓动 | `/cards/pick index=0` | 10→11，增加坚壁 | 两端经过 `(4,11)` 休息处，再到 `(5,12)` 普通战 |

四次房主日志均显示在第 17 帧观察到原版奖励界面，随后发塔主奖励：

```text
[23:04:25.964] INFO 塔主牌：原版奖励界面已出现（第 17 帧），发塔主奖励
[23:06:59.401] INFO 塔主牌：原版奖励界面已出现（第 17 帧），发塔主奖励
[23:13:52.311] INFO 塔主牌：原版奖励界面已出现（第 17 帧），发塔主奖励
[23:19:55.507] INFO 塔主牌：原版奖励界面已出现（第 17 帧），发塔主奖励
```

前两次只读 `_overlays` 得到同一顺序（从底到顶）：

1. `NRewardsScreen`：`/root/Game/RootSceneContainer/Run/GlobalUi/OverlayScreensContainer/RewardsScreen`
2. `NChooseACardSelectionScreen`：`/root/Game/RootSceneContainer/Run/GlobalUi/OverlayScreensContainer/NChooseACardSelectionScreen`

`/cards` 返回 `visible=true`、`screen=NChooseACardSelectionScreen`、`can_skip=true` 和三张候选。选牌后 `/cards.visible=false`，塔主 `/rewards.visible=true`：自然回到下层原版奖励。B 的原版奖励也可正常继续。选牌期间 B 能看到自己的奖励，不是黑屏。

两端结果日志一致（下面各列房主/爬塔玩家时间）：

```text
[23:05:09.994] INFO 塔主回合 #20 第1回合：塔主奖励 选了 衰竭
[23:05:10.009] INFO 塔主回合 #20 第1回合：塔主奖励 选了 衰竭
[23:07:00.835] INFO 塔主回合 #34 第1回合：塔主奖励 跳过
[23:07:00.870] INFO 塔主回合 #34 第1回合：塔主奖励 跳过
[23:14:55.704] INFO 塔主回合 #54 第1回合：塔主奖励 选了 复苏
[23:14:55.729] INFO 塔主回合 #54 第1回合：塔主奖励 选了 复苏
[23:21:01.613] INFO 塔主回合 #70 第1回合：塔主奖励 选了 坚壁
[23:21:01.642] INFO 塔主回合 #70 第1回合：塔主奖励 选了 坚壁
```

牌组动作摘要也一致：第一局 `#232 threat:deck` 的塔主 `k10`、爬塔玩家 `k10`；跳过后的 `#307 threat:reward` 仍为 `k10/k10`。第二局 `#97 threat:deck` 为 `k10/k11`，`#184 threat:deck` 为 `k11/k11`。`k` 是各自的牌组张数，要求同一玩家在两端相同，不要求两个不同玩家互相相等。

截图：

- [第一次自然三选一](screenshots/ui035-first-choice.png)（也能核对鼓动只有一行消耗）
- [B 同时显示原版奖励](screenshots/ui035-B-choice.png)
- [选后塔主下一房间](screenshots/ui035-follow-A.png)、[爬塔玩家同一房间](screenshots/ui035-follow-B.png)
- [第二次自然三选一](screenshots/ui035-second-choice.png)、[跳过后正常进入休息处](screenshots/ui035-after-skip-follow.png)
- [第三次候选](screenshots/ui035-third-choice.png)、[第四次候选](screenshots/ui035-fourth-choice.png)

## 新牌效果

| 卡牌 | 结论 | 实测 |
|---|---|---|
| 衰竭 | 通过 | 第一局下一场普通战，对 B 打出；两端 B 的 `WeakPower=1`、`FrailPower=1`。能量 2 点支付后进入弃牌。 |
| 复苏 | 通过（辅助能量） | 第二局化石追踪者自然战斗，B 先打三张打击将怪物 51→33；第 2 回合抽到复苏并补能量，打出后两端均 33→37。此场只有一只怪，全体多目标回血未覆盖。 |
| 坚壁 | 通过 | 第二局 `(5,12)` 普通战召唤两只蟾蜍蝌蚪，抽到坚壁并支付 2 能量；两端两只怪的格挡均 0→4。 |
| 迷雾 | 效果未覆盖 | 两次出现在候选，未选入牌组；不能用普通“晕眩”代替本牌验证。 |
| 弱点暴露 | 未覆盖 | 四次候选未出现。 |
| 筹谋 | 效果未覆盖 | 第二次候选出现，但按本轮要求用该场验证跳过，未入牌组。 |
| 鼓动文案 | 通过 | 多次候选截图只显示“获得 1 点能量。”及一行原版金色“消耗。”；本轮没有再次打出鼓动。 |

效果截图：[衰竭](screenshots/ui035-sap-effect.png)、[复苏回复后](screenshots/ui035-heal-confirmed.png)、[坚壁两只怪格挡](screenshots/ui035-fortify-all.png)。

## 存档与同步

第一局跳过第二次精英奖励、进入 `(3,14)` 休息处后，双方返回主菜单，同进程原版多人读档。种子、位置一致；塔主完整牌组与读档前 JSON 相同（10 张、衰竭仍在）。没有重新弹出已完成精英的选牌界面。之后另开第二局继续奖励测试。

- 两端完整 92 条“动作摘要 #”去时间戳后逐条完全相同。
- 退出后用原 `compare_logs` 对比实现读取落盘日志（只在本地进程替换日志读取函数，没有改仓库代码）：摘要/清单/替换/开始生成/降血关键词共 137 行/端，`equal=true`、`diffs=[]`。
- 两端游戏日志 `StateDivergence` 0、`[ERROR]` 0；没有断线、黑屏、奖励阻塞或战斗结束卡住。

## 警告与测试调用问题

| 日志 | ERROR | WARN |
|---|---:|---:|
| 塔主 TowerMaster | 0 | 1 |
| 爬塔玩家 TowerMaster | 0 | 0 |
| 塔主游戏 | 0 | 759 |
| 爬塔玩家游戏 | 0 | 132 |

唯一 mod WARN 来自测试助手尝试 `/reflect depth=2` 序列化整个 Powers 集合，而非衰竭打出失败：

```text
[23:05:39.872] WARN 测试接口：处理请求失败：Serialization and deserialization of 'System.IntPtr' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.result.value.
```

该请求返回 `Remote end closed connection without response`，两个游戏进程实际仍在，出牌已完成。改为只读具体 `Powers[index].Id` 和 `.Amount` 即可取得两端虚弱/脆弱 1；没有修改 mod。

游戏 WARN 分类：塔主资源未缓存 724、包缓冲扩容 25、manifest 未声明最低版本 4、IP 直连离线提示 2，其余 4；爬塔玩家资源未缓存 106、扩容 19、最低版本 4，其余 3。代表性资源包括 `weak_power.png`、`frail_power.png`、原版卡牌/持牌节点、顶栏角色轮廓、怪物场景；有显示且未见对应 ERROR。非资源警告还包括 IP 直连战斗托管 API 不兼容、leaderboards.save 不存在、Steam Input 未初始化，均应保留为事实，不能称日志零警告。

塔主另有一条旧坐标投票 WARN：

```text
[WARN] [MapSelectionSynchronizer] Received map vote from player 100002 for source act 0 coord (6, 1), but we're currently accepting votes for act 0 coord (6, 2)
```

测试助手在第一局进入第二普通房的批次未等待塔主阶段就绪，曾重复提交同一张牌，随后停止并确认阶段后恢复；也重复提交过已移动的坐标。这些属于本轮调用时序污染，已披露，不能据此认定产品存在选路/出牌缺陷。后续操作每次等塔主阶段和牌堆变化再继续；92 条摘要仍完全一致。

另有选牌/奖励接口请求发送过早的 `invalid_phase`、第二局召唤树叶史莱姆（不在 Underdocks 开局列表）的 `unknown_option`，纠正调用时机/选项后完成；未使用任何覆盖层兜底。

## 交接

奖励覆盖修复可交回 Claude：四次正常地图精英流程通过，专用选牌接口可用，选择、跳过、下一格跟随和存档均通过。后续还需补测迷雾、弱点暴露、筹谋效果，以及复苏多目标。测试接口可另考虑对反射对象进行安全序列化；本轮没有改任何 mod 代码，也没有提交原始日志、反编译源码或游戏资源。
