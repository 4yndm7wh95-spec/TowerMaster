# 0.0.36 测试结果

## 结论与环境

本轮测试完成，但不通过，建议先修商店价格与非战斗房间读档恢复。未改 mod 代码。测试 A/B 均已正常退出，没有操作用户自己游玩的实例。

- 分支：claude/optimistic-rubin-hr3eit；受测提交：07057ec。
- 游戏 v0.111.0；本机双实例；塔主 NetId 100001，爬塔玩家 100002；川换皮未加载。
- 105 个测试通过（Core 47、TowerMaster 58），编译零警告、零错误；安装 manifest 0.0.36，master_cards=true。
- 仓库与安装目录 towermaster.test.json SHA256 一致：`CE7D223D1626984CFD04F2F8E54D0CF4819EC3B6BDEB2B783F4866E23D169301`。
- 所有实际入房均沿地图投票；没有使用 room/fight/win，没有强行移除或补建覆盖层。
- 为加快部分普通战与精英战，测试助手曾对爬塔玩家使用 energy 30 / draw 7，塔主也用 draw 抽到待测牌。**这些不是正常能量和抽牌，不作为平衡数据。**用户指出能量、手牌异常偏多后停止玩家端辅助；最终 Boss 场玩家端确认 3 能量、5 张手牌。Boss 未打完，效果测试后正常退出。

## 逐项结果

|项目|结论|事实|
|---|---|---|
|宝箱原版三选一|通过（首次进入）|出现筹谋/弱点暴露/迷雾等原版选牌，第一局选筹谋，塔主牌组 9→10。|
|爬塔玩家开箱|通过|塔主选择期间可开箱、提交遗物选择；第一局最终获得赤牛，第二局获得锁镰，随后可继续走地图。最终发放可能等待选牌完成，不能据此称全过程完全无等待。|
|商店买陷阱|不通过|17 点时选狂怒，报负数价格异常；召唤点没有扣、陷阱没有增加。|
|商店买行动牌|不通过|30 点时选迷雾，同样负数价格异常；牌组未增加。|
|商店跳过|通过|第二局 30 点跳过迷雾/复苏/破绽三选一，召唤点、牌组均不变，可继续。|
|真正不足 6 点|未覆盖|没有制造真实低余额；读档后显示不足 6 点实际是账本未初始化，不能算通过。|
|爬塔玩家商店操作|通过|塔主选牌时玩家能打开原版商店并购买技能药水，金币 99→47，正常离开。|
|休息处删牌|通过（首次进入）|三张候选治疗/易伤/晕眩，选治疗后 9→8；玩家可锻造防御并离开。|
|休息处跳过|通过|后续休息处跳过，塔主牌组不变；玩家正常完成休息处操作并继续。|
|同房间存档读档|不通过|休息处、宝箱重复弹选牌；商店误报余额不足；删牌/新增牌出现回退。详见下文。|
|选完后跟随地图|通过（需处理重复选择）|宝箱、休息处、商店均有后续实际投票入房；未强制关选牌层。|
|筹谋/弱点暴露/迷雾|通过|三个效果均测到，两端结果一致，详见效果记录。|
|联机摘要|通过（本轮样本）|91 条动作摘要逐行一致，没有 StateDivergence。不能替代上述功能失败。|

## 失败 1：商店价格变成种子

第一局种子 `4211521589953351819`，地图 (3,2) 商店，塔主余额 17；选狂怒陷阱。随后 (1,11) 问号转商店，余额 30，选迷雾行动牌。两次选择界面均正常关闭，但购买未成功。

第一次完整异常：

```text
[00:28:34.683] INFO 塔主回合 #6 第1回合：塔主买了 狂怒
[00:28:34.702] ERROR 塔主回合 #6 第1回合：执行 reward 失败
System.InvalidOperationException: 召唤点不足：需要 -1928408949，只有 17
   at TowerMaster.Core.SummonWallet.Spend(Int32 amount)
   at TowerMaster.MasterLedger.SpendPoints(Int32 amount, String reason)
   at TowerMaster.MasterRewards.Record(ThreatCommand c, MasterCardDef def)
   at TowerMaster.MasterRewards.Execute(ThreatCommand c, Object action, String tag)
   at TowerMaster.ThreatPhase.Execute(String payload, Object action)
```

第二次原文（堆栈与上面相同）：

```text
[00:38:40.683] ERROR 塔主回合 #33 第1回合：执行 reward 失败
System.InvalidOperationException: 召唤点不足：需要 -1928408949，只有 30
```

只读定位：`mod/TowerMaster/MasterRewards.cs:115` 的 Send 把价格放入 ThreatCommand 的 Seed；`ThreatPhase.cs:343` 的 Send 在第 347 行统一把 Seed 改为本局种子；`MasterRewards.cs:218` 又把 Seed 转 int 当价格。该种子转 Int32 正好是 -1928408949。建议开发端分离价格与随机种子字段，并保证执行失败不提前记录“买了”。本轮没有修改。

截图：[陷阱商店](screenshots/ui036-shop-trap-before.png)、[行动牌商店](screenshots/ui036-shop-action-before.png)、[跳过样本](screenshots/ui036-shop-skip.png)、[玩家可购买](screenshots/ui036-shop-B-active.png)。

## 失败 2：读档账本恢复晚、奖励重复、牌组回退

复现方式均为同进程返回主菜单，再以原版多人读档大厅恢复同一存档，没有改存档。

1. 第一局 (5,6) 休息处：余额 27，选治疗后塔主 9→8；读档后塔主恢复 9 张、治疗回来，host `/state` 钱包为 null；稍等原版界面加载后，同一休息处三选一再次出现。跳过才继续。
2. 随后 (3,8) 宝箱：选筹谋，塔主 9→10，但 host 钱包仍 null。下一战结束才出现下面的读档日志，筹谋消失、牌组变为 8 张（恢复了旧删牌记录）。
3. 第一局 (1,11) 商店读档：此前余额 30，读档后 host 钱包 null，直接出现“不够 6”提示、不弹选牌。下一商店也如此。
4. 第二局种子 `10101370747170466727`，(2,8) 宝箱，余额 29，选弱点暴露；同房间读档后钱包 null、同样的三选一重复出现。再次选弱点暴露后，实际牌组仍不含它；之后拿到另一张精英奖励迷雾，牌组重新发布才恢复弱点暴露。

```text
[00:37:09.415] INFO 塔主账本：读档，召唤点 27，已打 3 场
[00:39:29.515] INFO 塔主牌：陷阱商店：召唤点不够 6，这次买不了
```

只读定位与解释：

- `RunLifecycle.cs:19` 对 CleanUp、SetUpSavedMultiplayer 等执行清理；`MasterLedger.cs:136` Configure 清空钱包、额外牌、删牌与奖励标记。
- `MasterLedger.cs:152` For 才从账本文件恢复上述状态；非战斗奖励入口没有先确保这一步完成。`MasterRewards.cs:92` 把 null 钱包当 0，导致误报不足。
- `MasterLedger.cs:194` 钱包 null 时 Save 直接返回，所以这段时间新增的非战斗奖励不能持久化，随后恢复旧账本又覆盖它。
- `MasterDeck.cs:37` 在新局路径清 `_lastSent`，而 `MasterDeck.cs:53` 相同键串不再发布。读档后实际牌组与缓存可能不一致，解释第二局再次选牌却没补回牌的现象；建议开发端核对读档时缓存清理与发布顺序。

第二局存在测试准备污染：先古之民原版选包为塔主加了 Taunt/IronWave/Inferno 三张英雄牌，宝箱前实际为 12 张；第一次发布弱点暴露后变成 10 张塔主牌，而不是 12→13。读档后回到含三张英雄牌的 12 张，之后迷雾奖励发布为 11 张塔主牌。这里把实际计数如实列出，不把 12→10 当正常新增结果。

截图：[休息处](screenshots/ui036-rest-choice.png)、[首次宝箱](screenshots/ui036-treasure-choice.png)、[第二局宝箱](screenshots/ui036-treasure2-choice.png)、[读档重复宝箱选择](screenshots/ui036-treasure-reload-repeat.png)。

## 新牌效果

- 筹谋：第一幕实测抽 1 张；打出前两端手牌 8、抽牌堆 0、弃牌堆 2；打出后手牌仍 8、抽牌堆 1、弃牌堆 1，符合出一张再抽一张，并重洗弃牌堆的过程。不是第一幕抽 2 张。只读 `MasterCards.cs:71` 与 `:364` 对应本幕数值。
- 弱点暴露：最终 Boss 场塔主用 draw 找牌，打出花 2 能量；两端玩家均出现 1 层 VULNERABLE_POWER。
- 迷雾：同场塔主再用 draw 找牌，花 1 能量；两端玩家抽牌堆 5→6，包含相同位置的 DAZED，完整牌 ID 序列一致。
- 上述 Boss 玩家端没有加能量或抽牌，确认 3 能量、5 手牌；塔主结束后玩家可正常行动。未声称 Boss 战胜利。

截图：[筹谋](screenshots/ui036-scheme-effect.png)、[弱点暴露/玩家正常手牌](screenshots/ui036-expose-effect.png)、[迷雾](screenshots/ui036-daze-effect.png)、[后续跟随塔主端](screenshots/ui036-final-follow-A.png)、[玩家端](screenshots/ui036-final-follow-B.png)。

## 日志回归与其他异常

按去除时间戳后的整行比较：动作摘要 91/91、收到清单 12/12、已替换 12/12、开始生成 11/11，均完全一致；两端本轮没有水土不服行。两端 StateDivergence 均为 0。

|日志|ERROR 行数|WARN 行数|
|---|---:|---:|
|TowerMaster 塔主|2|0|
|TowerMaster 玩家|0|0|
|游戏 塔主|12|671|
|游戏 玩家|14|174|

以上按包含 ERROR/WARN 单词的日志行统计，不代表独立事故数。游戏塔主 12 条 ERROR 均为正常退出时的 RID/shader/resource 未释放汇总；玩家另有两次运行期纹理已释放异常，其余 12 条同为退出资源汇总。WARN 大量为 Asset not cached、包缓冲增长；未证明由本轮新功能独立引起，不能报“零异常”。

两次纹理异常的相同主要堆栈原文：

```text
ERROR: System.ObjectDisposedException: Cannot access a disposed object.
Object name: 'Godot.CompressedTexture2D'.
   at Godot.GodotObject.GetPtr(GodotObject instance)
   at Godot.TextureRect.SetTexture(Texture2D texture)
   at MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerState.<>c__DisplayClass93_0.<TweenLocationIconIn>b__0()
   at Godot.Callable.<From>g__Trampoline|11_0[TResult](Object delegateObj, NativeVariantPtrArgs args, godot_variant& ret)
   at Godot.DelegateUtils.InvokeWithVariantArgs(IntPtr delegateGCHandle, Void* trampoline, godot_variant** args, Int32 argc, godot_variant* outRet)
```

本轮调用失误也单独记录：一次在商店选择尚未完成时提前投了未来房间坐标，产生待处理召唤；通过原版回菜单读档恢复后重新按合法地图坐标走。还有先古之民选包未完成、升级确认方法参数不完整造成的接口错误，均修正调用后继续。没有把这些当作产品故障，也没有用强制覆盖层兜底。

## 给 Claude 的处理顺序

1. 修 reward 的价格字段被 Seed 覆盖，验证买陷阱与买行动牌都真正扣 6、真正入手。
2. 读档进入任何非战斗房间前恢复账本/奖励标记；核对实际牌组与发布缓存，重测宝箱、商店、休息处同房间读档。
3. 单独排查玩家位置图标 Tween 持有已释放纹理的问题；本轮仅定位堆栈，归因未确定。
4. 修后补真正余额不足 6 的商店、完整 Boss 胜利和跨进程读档；这些本轮未覆盖。
