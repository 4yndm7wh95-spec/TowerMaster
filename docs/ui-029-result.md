# 0.0.29 实测结果（2026-10-07）

代码ba0c7a6，103个测试通过（47+56），编译安装0警告0错误。初次安装使用仓库新配置 master_cards=true；川换皮禁用。本机双实例，塔主100001、爬塔玩家100002，全程助手操作。

## 真实塔主牌：阻塞

两端启动正常并有54类型登记，建房加入正常；开始新局后两端均在地图生成时NullReferenceException，InternalError退出到菜单。因此按用户预案，仅把安装目录配置master_cards改为false，正常退出重启两端，只做第一部分。没有修改mod代码。

启动原文（塔主）：

```text
[08:42:55.259] INFO 塔主牌：已生成 54 种卡牌类型（TowerMasterBlock1 …），等 ModelDb.Init 收录
[08:44:09.496] INFO 塔主牌组：新的一局，换成 9 张：加固、加固、治疗、激励、战吼、虚弱、易伤、脆弱、晕眩
```

两端游戏错误关键段落：

```text
[ERROR] Exception starting multiplayer run : System.NullReferenceException: Object reference not set to an instance of an object.
   at MegaCrit.Sts2.Core.Runs.RunState.Contains(AbstractModel model)
   at MegaCrit.Sts2.Core.Runs.RunState.IterateHookListeners(ICombatState childCombatState)+MoveNext()
   at MegaCrit.Sts2.Core.Hooks.Hook.ModifyGeneratedMap(IRunState runState, ActMap map, Int32 actIndex)
   at MegaCrit.Sts2.Core.Runs.RunManager.GenerateMap()
   at MegaCrit.Sts2.Core.Runs.RunManager.SetActInternal(Int32 actIndex)
```

源码依据：decompiled/sts2/MegaCrit.Sts2.Core.Runs/RunState.cs:367遍历玩家Deck，:495 Contains检查，:525读取cardModel.Owner.IsActiveForHooks；mod/TowerMaster/MasterDeck.cs:79 Replace直接ToMutable并PopulateDeck，未见给这些新卡设置Owner；CardPile.AddInternal（decompiled/sts2/MegaCrit.Sts2.Core.Entities.Cards/CardPile.cs:67）只加入列表，Player.PopulateDeck（decompiled/sts2/MegaCrit.Sts2.Core.Entities.Players/Player.cs:567）也只AddInternal。RunState.AddCard（:259/:263）才明确设置Owner。这与新牌Owner为空导致Contains失败吻合，交由开发者确认修复，未修改代码。

真实牌组查看、108条本地化、挑陷阱后入牌组、第二幕升级、原版拖牌、tm_master_play、各项限制、手牌清理及同步：全部因新局失败未覆盖，不作通过结论。

## 重复订阅回归（master_cards=false）

开第一局进入塔主阶段 → B返回菜单，同进程新局 → 正常打完2场 → 存档返回菜单读档 → 再自然打完1场。未用机器人或win。

新局种子17543646014700146014；两场分别2回合，读档后第三场3回合。各战每个回合只有一次开始，旧的“上一个塔主回合还没结束”WARN为0。三次胜利各只有一条收入：

```text
[08:57:59.187] INFO 召唤阶段：战斗收入 +6（基础 5，节约 1，战果 0），召唤点 17/30；玩家掉血 0，击倒 []，有奖励 []
[09:00:45.637] INFO 召唤阶段：战斗收入 +6（基础 5，节约 1，战果 0），召唤点 22/30；玩家掉血 0，击倒 []，有奖励 []
[09:02:34.374] INFO 塔主账本：读档，召唤点 22，已打 2 场
[09:05:25.566] INFO 召唤阶段：战斗收入 +6（基础 5，节约 1，战果 0），召唤点 27/30；玩家掉血 0，击倒 []，有奖励 []
```

账本12，扣1+6→17，扣1+6→22，读档22/2场，扣1+6→27。重复订阅回归通过本样本。

两端动作摘要19/19行完全一致；TowerMaster ERROR/WARN两端均0，StateDivergence均0。游戏p_child is null均0；但塔主游戏仍有2次disconnect a nonexistent connection，爬塔玩家0，不能判该问题已全部消失。退出时Godot资源未释放输出另计，未作为mod ERROR。

## 额外换局问题

同进程新局首步投票(3,1)与前一局相同时没有前进，改投合法(0,1)即恢复。mod/TowerMaster/Test3MasterAutoPilot.cs:29缓存_lastMapVote，AfterMapVote:195–196按source/destination字符串去重；RunLifecycle.Reset:28未清该缓存。此为高度吻合的调查线索，应新局重测并由开发者修复，未修改代码。

本轮真实卡牌测试受阻，报告供修复；用户随后要求测试0.0.30，新一轮将重新安装master_cards=true，不沿用false配置。
