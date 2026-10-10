# 测试 3 第二轮实测结果（mod 0.0.7）

## 结论与交接

**本轮未全部通过：宝箱出现阻塞游玩的问题，应优先交给开发者修复。** 塔主手动选路、领取战斗奖励、商店操作与领取宝箱遗物的限制有效。先古之民与部分问号事件仍能给塔主物品，属于当前“塔主物品一直不变”目标的覆盖缺口；用户已明确希望后续为塔主另做事件和商店设计，不应据此直接把所有事件一律禁掉。

本报告只记录测试和只读定位，没有修改 mod 代码。用户已正常关闭两个实例。对应说明为 `docs/test3-round2-plan.md`；游戏 v0.111.0。同机双实例，**塔主=NetId 100001（房主），爬塔玩家=100002**，下文按身份称呼。此会话日志中 TowerMaster-A 为100001、TowerMaster-B为100002，身份根据开局日志和游戏联机动作确认，不沿用历史窗口命名推断。

本次读取的 TowerMaster 日志开始于2026-10-06 02:20:36，游戏退出日志到02:25附近；游戏日志部分时间使用另一时区（07:xx），用动作和位置对齐。安装目录 manifest `version=0.0.7`，配置 `test1b_mixed_encounter=true`、`test2_master_off_field=true`、`test3_master_autopilot=true`、`test3_block_master_items=true`。本次补报告没有重新编译、安装或运行单元测试，不能补写“59个测试已通过”。

## 用户画面观察

| 项目 | 结论 | 实测观察/边界 |
| --- | --- | --- |
| 塔主手动选路线 | 通过 | 用户确认塔主已不能选择路线；日志有跟投和手动点击被忽略 |
| 战斗结束领取卡牌、金币、药水 | 通过 | 用户确认这些均不能领取；日志有 SelectLocalReward 已拦下 |
| 商店操作 | 通过 | 用户确认塔主不能操作；日志分别记录购买与删牌被拦下 |
| 塔主拿宝箱遗物 | 通过 | 宝箱只出现一个遗物，塔主不能拿 |
| 爬塔玩家领完宝箱后继续 | **不通过，阻塞** | 用户确认爬塔玩家拿到唯一遗物后卡在宝箱界面，继续按钮完全没有出现；塔主端有继续按钮，但塔主不能选路线，仍无法推进。日志存在相关焦点异常 |
| 先古之民“贪婪”及部分问号事件 | 部分不通过/待单独设计 | 用户确认塔主仍可参与并取得金币等；事件名称按用户描述保留，不推断全部对应游戏ModelId。日志确认 TRASH_HEAP 两人分别选择 GRAB |
| 塔主牌组、遗物、金币、药水始终不变 | 不通过 | 事件还能给塔主物品；未导出完整前后库存，不能量化所有变化或断言药水/遗物也经事件变化 |
| 共享投票事件自动跟投 | 未覆盖 | 用户确认未到过共享投票事件；本轮没有“测试3 事件：”运行行，非共享事件不算此项 |
| 休息处 | 未覆盖 | 用户确认未到过休息处；本轮没有“测试3 休息处：”运行行，上一轮观察不算本轮 |
| 第一幕Boss奖励、换幕、第二幕战斗 | 未覆盖 | 用户确认未到过Boss/第二幕；日志止于第一幕宝箱，没有“测试3 换幕：”运行行或第二幕战斗记录 |
| 塔主停在奖励/事件界面后切房 | 部分覆盖 | 实际到达后续战斗/商店/事件；用户未逐一确认所有残留界面的画面状态，宝箱发生卡住，不能判所有切房正常 |

用户后续设计意图：给塔主单独设计先古之民的三项事件、问号特殊事件，以及商店可购买的卡牌等。它们是后续开发需求，本轮没有实现或验收；当前商店禁用行为按0.0.7测试要求通过。

## 启动、自动操作及日志摘录

两端探针均“全部找到”；TowerMaster 日志均未发现 WARN/ERROR、“改写失败”或“测试3 …失败”。两端人数改写统计均为 `共122个方法读玩家人数，改写19个`；游戏日志均未出现 `not associated with any mod`。这些结论不代表游戏日志没有异常，宝箱异常见后文。

塔主启动摘录：

```text
[02:20:46.860] INFO ===== 探针：全部找到 =====
[02:20:46.872] INFO 登记动态程序集：已调用 static Void MegaCrit.Sts2.Core.Modding.ModManager.AssociateAssemblyWithMod(String modId, Assembly assembly)，参数=[TowerMaster, RuntimeAssembly:TowerMaster.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]
[02:20:48.928] INFO ===== 测试2：共 122 个方法读玩家人数，改写 19 个 =====
```

各类运行行（挂钩安装行不算实际完成该环节）：

| 环节 | 塔主日志证据 | 判断 |
| --- | --- | --- |
| 选路 | 跟随100002投票；手动选路被忽略 | 实际触发 |
| 奖励 | 跳过本次奖励；未显示的组无需跳过；领取被拦下 | 实际触发 |
| 宝箱 | 跳过遗物；手动领取被拦下 | 自动跳过实际触发，但整体房间流程失败 |
| 商店 | OnTryPurchaseWrapper 与 DoLocalMerchantCardRemoval 被拦下 | 实际触发 |
| 事件、休息处、换幕 | 只有启动安装相关挂钩；无对应“测试3 …：”运行行 | 不判运行成功 |

```text
[02:23:37.433] INFO 测试3 物品：塔主不能 MerchantEntry.OnTryPurchaseWrapper，已拦下
[02:23:39.232] INFO 测试3 物品：塔主不能 OneOffSynchronizer.DoLocalMerchantCardRemoval，已拦下
[02:24:35.736] INFO 测试3 物品：塔主不能 RewardsSetSynchronizer.SelectLocalReward，已拦下
[02:24:56.969] INFO 测试3 选路：跟随玩家 100002 投票 MapLocation:act 0 coord (5, 7)→MapVote:MapVote (gen: 1 coord: (6, 8))
[02:24:57.802] INFO 测试3 宝箱：塔主跳过遗物
[02:25:00.670] INFO 测试3 宝箱：塔主不能拿遗物，已拦下
[02:25:08.859] INFO 测试3 选路：塔主不能手动选路，已忽略（会自动跟随爬塔玩家）
```

目的地方面，两端收到并进入的宝箱位置为第一幕 `(6,8)`；与塔主跟随爬塔玩家的票一致。没有逐次比对完整所有地图投票消息，因此仅以该样例确认，不扩大为所有可能分票情形通过。

非共享事件实际选择摘录（塔主游戏日志）：

```text
[DEBUG] [EventSynchronizer] Option index 1 chosen for player 100001 in event EVENT.TRASH_HEAP. Choice key: TRASH_HEAP.pages.INITIAL.options.GRAB
[DEBUG] [EventSynchronizer] Option index 1 chosen for player 100002 in event EVENT.TRASH_HEAP. Choice key: TRASH_HEAP.pages.INITIAL.options.GRAB
```

这是两人各自选项的记录，不是共享事件自动跟投证据；塔主获得金币等由用户画面观察确认。

## 战斗与同步回归

去掉每行时间戳后逐行对比：两端“收到清单”8行完全一致；“已替换”“开始生成”“生成”各4行完全一致。Sequence 2/4/6/8有清单但无混搭生成记录，不能把8份清单当8场战斗；实际记录4场混搭战斗，Sequence 1/3/5/7。

两端“测试2 开局”20行完全一致，每场均塔主生命0/80、死亡=True，爬塔玩家存活，爬塔人数=1。

| 清单序号 / 楼层 | 爬塔玩家开局生命 | CalcifiedCultist | Seapunk |
| --- | --- | --- | --- |
| 1 / 2 | 80/80 | 39/39 | 44/44 |
| 3 / 4 | 51/80 | 39/39 | 46/46 |
| 5 / 6 | 38/80 | 39/39 | 44/44 |
| 7 / 8 | 35/80 | 40/40 | 46/46 |

血量均在单人预期范围（钙化邪教徒38–41、海洋混混44–46）。人数缩放参数实际打印的5行两边一致，均 `playerCount=1, actIndex=0`；最后一场没有新增参数行，不能虚构它。每场生成行都在对应清单与“开始生成”之后。

```text
[02:24:45.899] INFO 测试1b #7：已替换 FossilStalkerNormal → CultistsNormal，清单=[CalcifiedCultist, Seapunk]
[02:24:45.900] INFO 测试1b #7：开始生成，楼层=8
[02:24:45.902] INFO 测试1b #7：生成 [(CalcifiedCultist:MONSTER.CALCIFIED_CULTIST, null), (Seapunk:MONSTER.SEAPUNK, null)]
[02:24:46.041] INFO 测试2 开局 玩家 100001（塔主）：生命=0/80 死亡=True
[02:24:46.041] INFO 测试2 开局 玩家 100002：生命=35/80 死亡=False
[02:24:46.042] INFO 测试2 开局 爬塔人数=1
```

两端游戏日志 `StateDivergence` 命中0；只说明本次日志未发现这个报错，不能因此否定宝箱界面bug。

## 宝箱阻塞：事实、报错和只读定位

### 发生经过

1. 塔主自动发送空 index 的 NetPickRelicAction（跳过）；两端记录塔主 skipped relic。
2. 爬塔玩家打开宝箱时，其游戏日志出现 DefaultFocusedControl 索引越界，调用链含 OpenChest。
3. 随后爬塔玩家仍能请求领取 index0；两端执行动作，游戏日志确认取到 `RELIC.ORICHALCUM`。用户确认拿完遗物后爬塔玩家端没有出现继续按钮，卡在宝箱界面；塔主端有按钮，但不能靠塔主选路推进。
4. 两端在用户退出附近又记录 NHandImageCollection._Input 的 Nullable 空值异常。其出现时机不能证明它就是领取后卡住的首要原因。

领取摘录（爬塔玩家游戏日志）：

```text
[DEBUG] [TreasureRoomRelicSynchronizer] Relic index 0 (RELIC.ORICHALCUM (18890413)) is being picked by local player 100002
[DEBUG] [TreasureRoomRelicSynchronizer] Player MegaCrit.Sts2.Core.Entities.Players.Player picked relic at index 0: RELIC.ORICHALCUM (18890413)
```

### 相关报错原文

爬塔玩家 `game-B.log:3061` 起（保留异常和关键原文调用链）：

```text
[ERROR] System.ArgumentOutOfRangeException: Index was out of range. Must be non-negative and less than the size of the collection. (Parameter 'index')
   at System.Collections.Generic.List`1.get_Item(Int32 index)
   at MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NTreasureRoomRelicCollection.get_DefaultFocusedControl()
   at MegaCrit.Sts2.Core.Nodes.Rooms.NTreasureRoom.get_DefaultFocusedControl()
   at MegaCrit.Sts2.Core.Nodes.Rooms.NTreasureRoom.OpenChest()
   at MegaCrit.Sts2.Core.Helpers.TaskHelper.LogTaskExceptions(Task task)
   at MegaCrit.Sts2.Core.Helpers.TaskHelper.LogTaskExceptions(Task task)
   at System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[TStateMachine](TStateMachine& stateMachine)
   at MegaCrit.Sts2.Core.Helpers.TaskHelper.LogTaskExceptions(Task task)
   at MegaCrit.Sts2.Core.Nodes.Rooms.NTreasureRoom.OnChestButtonReleased(NButton _)
```

两端退出附近，塔主 `game-A.log:2657`、爬塔玩家 `game-B.log:3129`，相同异常及调用链：

```text
ERROR: System.InvalidOperationException: Nullable object must have a value.
   at MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NHandImageCollection._Input(InputEvent inputEvent)
   at Godot.Node.InvokeGodotClassMethod(godot_string_name& method, NativeVariantPtrArgs args, godot_variant& ret)
   at Godot.Control.InvokeGodotClassMethod(godot_string_name& method, NativeVariantPtrArgs args, godot_variant& ret)
   at MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic.NHandImageCollection.InvokeGodotClassMethod(godot_string_name& method, NativeVariantPtrArgs args, godot_variant& ret)
   at Godot.Bridge.CSharpInstanceBridge.Call(IntPtr godotObjectGCHandle, godot_string_name* method, godot_variant** args, Int32 argCount, godot_variant_call_error* refCallError, godot_variant* ret)
```

### 源码定位（推论，未修复）

均相对 `decompiled/sts2/`，仅转述，不复制方法体：

- `MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic/NTreasureRoomRelicCollection.cs:109–118`：DefaultFocusedControl 只检查 holder列表是否空，随后用玩家在完整RunState中的slot索引访问列表。若holder只剩1个而爬塔玩家slot为1，就会越界；本次没有额外探针直接打印slot/holder数量，因此这是与现象吻合的候选原因，不是最终确诊。
- `MegaCrit.Sts2.Core.Nodes.Rooms/NTreasureRoom.cs:219–254`：OpenChest先禁用继续按钮，初始化遗物界面后在237行取默认焦点；后面才等待遗物选择结束并重新启用继续按钮。237附近抛异常会中断后续流程，可解释“还能拿遗物但无法继续”。应重点检查单人holder布局与完整多人slot的组合。
- `MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic/NHandImageCollection.cs:146–184`：输入处理直接读取LocalContext.NetId.Value；退出/联机身份释放之后仍收到输入时有空值风险。结合错误出现在Quit附近，这是退出时机候选原因，未确认具体触发分支。

开发者应优先处理宝箱UI焦点/继续流程，不能只凭“同步动作完成”或“塔主跳过遗物”判房间正常结束。未改任何实现。

## 其他日志与覆盖限制

爬塔玩家游戏日志开局连接尝试有 ENet 握手ID不匹配、Could not connect 和 DirectClient ID Collision(100002)；后续成功进入本次联机，不能与宝箱运行期异常混为一谈。退出时还有Godot资源/RID释放警告，以及Asset not cached WARN；不声称游戏日志无ERROR/WARN。没有重新验证不同电脑网络、断线重连、Boss/跨幕。

原始四份日志只在本机读取，不提交全文。报告逐项结论以用户观察和本次日志证据为限；缺少观察/运行行的项目保留未覆盖，不将历史轮次通过迁移到本轮。
