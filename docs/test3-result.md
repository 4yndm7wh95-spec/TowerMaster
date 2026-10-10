# 测试 3 实测结果（2026-10-06）

## 环境与身份

测试提交 dfb5983，mod 0.0.6，游戏 v0.111.0，同机双实例。57 个测试全部通过（Core 37、mod 20），编译安装 0 警告、0 错误；安装 manifest version=0.0.6，test3_master_autopilot=true。仅测试与报告，不改代码。

**文件名与角色身份相反**：game-B.log 记录 DirectHost started ... ID 100001，game-A.log 记录 DirectClient Connected to host 100001。因此 TowerMaster-B.log 是房主/塔主日志，TowerMaster-A.log 是爬塔客户端日志。以下按 NetId 判断，塔主=100001、爬塔玩家=100002；用户口头的 A 指塔主，B 指爬塔玩家。

## 各环节结论

| 环节 | 结论 | 证据、观察与限制 |
| --- | --- | --- |
| 选路自动跟随 | 通过（本轮记录路径） | 房主 11 条“测试3 选路”跟随玩家100002；地图日志的出发坐标与该玩家投票相同，两方票相同 |
| 禁止塔主手动选路 | 不通过/新增明确需求 | 用户实测塔主仍能先手选择路线，并明确要求直接禁止；塔主先投不同票与爬塔玩家随后投票的冲突情况未测，不断言会走错路 |
| 战斗奖励自动跳过 | 不通过（有异常），部分跳过有效 | 房主4条“塔主跳过本次奖励”，共6次自动跳过失败（含宝箱奖励时2次）；用户明确说跳过后奖励失效，不碰塔主不会自动领取。异常原文见下 |
| 宝箱 | 自动跳过遗物已触发；无须手动继续仅部分覆盖 | 房主有“测试3 宝箱：塔主跳过遗物”，随后奖励跳过报错2次。用户说手动可拿金币/遗物，不能宣布塔主无法获得物品 |
| 共享事件 | 未覆盖 | 没有执行期“测试3 事件”行；仅有挂钩启动行。不能据此宣布失败或通过 |
| 非共享事件 | 部分观察，未覆盖完全自动 | 本版说明不自动选；用户表示很多环节不用手动操作，未逐项确认事件是否需要操作或画面状态 |
| 休息处 | 自动跳过触发；离开过程有日志证据 | 房主有“测试3 休息处：塔主跳过”，随后地图继续到(3,7)。用户说塔主没有“交换按钮”（原话，未解释为具体控件）；未明确回答是否完全不碰塔主即可离开，因此纯旁观画面结论未确认 |
| 商店 | 自动选路有证据；手动购买仍允许 | 用户明确塔主有金币后能手动买牌。不能把有自动投票等同于禁止购买；未逐项确认是否存在等待 |
| 换幕 | 未覆盖 | 用户明确未测；无执行期“测试3 换幕”行 |
| 切房画面 | 未覆盖 | 尚未得到塔主停在奖励/事件后切房是否正常的明确反馈；不由无异常日志推定视觉正常 |

## 塔主物品观察与需求

用户明确：获得卡牌、金币、遗物需要在塔主窗口手动领取；自动跳过后奖励确实失效。塔主可以手动从宝箱获得金币/遗物，战后仍能看到卡牌奖励，有金币后可在商店手动购牌。药水领取未明确观察。本轮包含人为操作塔主，不能声明全程完全不碰塔主已经验证。

用户新增要求：**禁止塔主手动选路线，保留后台跟随爬塔玩家投票。** 交 Claude 实现，不在本地测试端修改代码。是否同时禁止手动领取/购买物品需由玩法设计决定；本轮只记录它仍被允许。

## 回归

两端各27条“测试2 开局”正文完全一致（去时间戳）；4场普通战斗与1次其他遭遇开局塔主均0/80、死亡=True，爬塔人数1；爬塔玩家存活。暗港普通怪血量：钙化邪教徒41、38、40、39；海洋混混44、46、46、44，均在单人范围。最后PhantasmalGardener四只生命30、29、26、31，无本轮单人基准，不能判数值通过。密林未覆盖。

两端各22条“收到清单/已替换/开始生成/生成”正文完全一致，4次普通混搭均接收和替换先于生成。两端血量参数记录的5次调用均playerCount=1；后续调用因前5次日志限额未记录。

两份游戏日志均未发现 StateDivergence、not associated with any mod、[ERROR] 或 Exception 段；**TowerMaster房主日志自身有6次奖励异常，不能描述为没有错误。** 非房主日志没有运行期测试3自动操作行，符合只在房主执行的设计。另有游戏资源缓存/动画缺失及退出资源泄漏提示；来源未定位。

## 报错与自动操作原文

下面全部执行期测试3消息来自 TowerMaster-B.log（实际房主）。错误调用栈原文也保留，便于 Claude 定位；不提交日志全文。
```text
[01:50:18.644] INFO 测试3 选路：跟随玩家 100002 投票 MapLocation:act 0 coord (3, 0)→MapVote:MapVote (gen: 1 coord: (3, 1))
[01:50:43.273] INFO 测试3 奖励：塔主跳过本次奖励
[01:50:43.296] ERROR 测试3 奖励：自动跳过失败，塔主可以手动跳过
[01:50:48.834] INFO 测试3 选路：跟随玩家 100002 投票 MapLocation:act 0 coord (3, 1)→MapVote:MapVote (gen: 1 coord: (3, 2))
[01:51:11.291] INFO 测试3 奖励：塔主跳过本次奖励
[01:51:11.296] ERROR 测试3 奖励：自动跳过失败，塔主可以手动跳过
[01:51:13.763] INFO 测试3 选路：跟随玩家 100002 投票 MapLocation:act 0 coord (3, 2)→MapVote:MapVote (gen: 1 coord: (3, 3))
[01:51:42.854] INFO 测试3 奖励：塔主跳过本次奖励
[01:51:42.859] ERROR 测试3 奖励：自动跳过失败，塔主可以手动跳过
[01:52:02.771] INFO 测试3 选路：跟随玩家 100002 投票 MapLocation:act 0 coord (3, 3)→MapVote:MapVote (gen: 1 coord: (2, 4))
[01:52:06.250] INFO 测试3 选路：跟随玩家 100002 投票 MapLocation:act 0 coord (2, 4)→MapVote:MapVote (gen: 1 coord: (3, 5))
[01:52:32.012] INFO 测试3 奖励：塔主跳过本次奖励
[01:52:32.022] ERROR 测试3 奖励：自动跳过失败，塔主可以手动跳过
[01:52:36.278] INFO 测试3 选路：跟随玩家 100002 投票 MapLocation:act 0 coord (3, 5)→MapVote:MapVote (gen: 1 coord: (4, 6))
[01:52:36.972] INFO 测试3 休息处：塔主跳过
[01:52:45.805] INFO 测试3 选路：跟随玩家 100002 投票 MapLocation:act 0 coord (4, 6)→MapVote:MapVote (gen: 1 coord: (3, 7))
[01:52:56.393] INFO 测试3 选路：跟随玩家 100002 投票 MapLocation:act 0 coord (3, 7)→MapVote:MapVote (gen: 1 coord: (3, 8))
[01:52:57.352] INFO 测试3 宝箱：塔主跳过遗物
[01:52:59.340] ERROR 测试3 奖励：自动跳过失败，塔主可以手动跳过
[01:52:59.341] ERROR 测试3 奖励：自动跳过失败，塔主可以手动跳过
[01:53:04.105] INFO 测试3 选路：跟随玩家 100002 投票 MapLocation:act 0 coord (3, 8)→MapVote:MapVote (gen: 1 coord: (3, 9))
[01:53:12.233] INFO 测试3 选路：跟随玩家 100002 投票 MapLocation:act 0 coord (3, 9)→MapVote:MapVote (gen: 1 coord: (3, 10))
```

首次失败调用栈（其他失败同类）：

```text
[01:50:43.296] ERROR 测试3 奖励：自动跳过失败，塔主可以手动跳过
System.Reflection.TargetInvocationException: Exception has been thrown by the target of an invocation.
 ---> System.InvalidOperationException: Tried to skip reward set for player 100001, but they are not currently viewing any reward set!
   at MegaCrit.Sts2.Core.Multiplayer.Game.RewardsSetSynchronizer.SkipRewardsSetOnStackTopForPlayer(Player player)
   at MegaCrit.Sts2.Core.Multiplayer.Game.RewardsSetSynchronizer.SkipLocalRewardsSet()
   at InvokeStub_RewardsSetSynchronizer.SkipLocalRewardsSet(Object, Object, IntPtr*)
   at System.Reflection.MethodBaseInvoker.InvokeWithNoArgs(Object obj, BindingFlags invokeAttr)
   --- End of inner exception stack trace ---
   at System.Reflection.MethodBaseInvoker.InvokeWithNoArgs(Object obj, BindingFlags invokeAttr)
   at System.Reflection.RuntimeMethodInfo.Invoke(Object obj, BindingFlags invokeAttr, Binder binder, Object[] parameters, CultureInfo culture)
   at System.Reflection.MethodBase.Invoke(Object obj, Object[] parameters)
   at TowerMaster.RuntimeNetAction.Call(Object target, String name, Object[] args)
   at TowerMaster.Test3MasterAutoPilot.CallLocal(Object synchronizer, String method, Object[] args)
```

## 交接结论

本轮测试与报告已完成，可交给 Claude。需要处理奖励自动跳过的 InvalidOperationException（当前无奖励集合仍尝试跳过），并按用户要求禁止塔主手动选路线；其他未覆盖项在下一轮确认。本地不修复。原始日志保存在 outputs/TowerMaster-test3-A/B.log、game-test3-A/B.log，不提交全文、反编译代码或运行生成的 plans.json。
