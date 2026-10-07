# 陷阱 0.0.22 实测结果

## 总体结论

有问题，需 Claude 修复：狂怒满足死亡条件后没有触发。其余七项指定触发效果已验证（其中升级版见下表）。未发现 StateDivergence，TowerMaster 日志没有 ERROR/WARN。游戏日志另有多人位置图标贴图已释放异常，需单独评估，不能声称日志全无异常。

环境：2026-10-06，游戏 v0.111.0/net9.0；代码 dcc68cc；同机双实例 IP 直连，塔主=房主 NetId 100001，爬塔玩家=100002。91 个单元测试通过（Core 44、TowerMaster 47）；实际游戏编译安装成功，零编译错误/警告，manifest=0.0.22，master_turn=true。未修改 mod/MCP 代码、规则配置或账本。

种子 18084647257497842757；第一幕 Underdocks，第二幕 Hive，第三幕 Glory。为覆盖不同包，同一存档跨三幕选拖延、压迫、铁壁包。实际有陷阱的战斗均使用 tm_play/tm_end_turn 完成，没有 win；无陷阱的过路战和两幕 Boss 使用 win 加速，不算自然难度测试。破绽测试用原版联机控制台 draw 5 准备四张打击，没有改游戏代码、直接写能量或卡堆，也没有 win。

## 启动出牌钩子

塔主启动原文：

```text
INFO 陷阱：已挂到 static Task MegaCrit.Sts2.Core.Hooks.Hook.AfterCardPlayed(ICombatState combatState, PlayerChoiceContext choiceContext, CardPlay cardPlay)
```

没有“找不到 Hook.AfterCardPlayed”WARN。完整类型签名：`public static async System.Threading.Tasks.Task MegaCrit.Sts2.Core.Hooks.Hook.AfterCardPlayed(MegaCrit.Sts2.Core.Combat.ICombatState combatState, MegaCrit.Sts2.Core.Context.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Cards.CardPlay cardPlay)`。依据 decompiled/sts2/MegaCrit.Sts2.Core.Hooks/Hook.cs:193；统一出牌调用在 decompiled/sts2/MegaCrit.Sts2.Core.Models/CardModel.cs:1594（await 此 Hook）。CardPlay.Card、Player、IsFirstInSeries 分别见对应 Entities.Cards/CardPlay.cs:9、:11、:25。

## 逐项结果

|项目|结论|实际证据／限制|
|---|---|---|
|第一场前选包|通过|三选一面板已截图，拖延包后 hand=mire@1/mend@1/countdown@1/bluff@1 共 4 张|
|前三场开局保护|通过|三场普通战 opening_protected=true；陷阱报价 OpeningProtectionTraps，确认 rejected_rule：开局保护：不能盖陷阱|
|第 4 场盖两张、第三张拒绝|通过|mire+mend trap_cost=2；含一只蝌蚪总费 3，余额 27→24；三张报价 TooManyTraps，确认拒绝|
|B 第一回合知道手牌数量|通过|截图显示“塔主手里有 4 张陷阱（这场盖没盖、盖了什么看不到）”，没有泄露盖牌详情|
|泥沼|通过（第 1 幕）|第 2 回合两端 DrawPile 均新增 2 张 Dazed；第 3 回合抽到／离开抽牌堆，因此不要只看之后的 DrawPile 数量|
|再生|通过（第 1 幕）|第 4 回合，最大生命 22 的蝌蚪 16→19，两端一致，15% 向下取整 +3|
|倒计时|通过（第 1 幕）|第 6 回合，最大生命 21 的蝌蚪 15→21，两端一致，30% 回复 +6|
|鼓舞|通过（第 2 幕 +1）|第 3 回合两端 StrengthPower.Amount=2，两只均受效果；截图提示|
|狂怒|不通过（第 2 幕 +1）|打死一只蝌蚪后另一只仍 18/24 存活，力量仍是鼓舞的 2；frenzy@2 仍 unfired；胜利后返回手牌并发躲过 +15，而不是触发 +3|
|碎甲|通过（第 2 幕 +1）|同回合三张防御，B 两端 FrailPower.Amount=2，截图显示触发提示|
|硬化|通过（第 3 幕 +2）|同回合第三张打击，两端 Creature.Block=11；日志 harden@3 触发。仅单怪效果实测，多怪格挡未额外覆盖|
|破绽|通过（第 3 幕 +2，补抽测试）|draw 5 后同回合四张打击，B 两端 VulnerablePower.Amount=2，截图显示触发|
|陷阱先于塔主回合|通过|泥沼、再生、倒计时、鼓舞各对应日志触发序号在同回合 begin 之前；塔主正常开放、结束|
|空陷阱／躲过奖励|通过|倒计时+空陷阱战胜后两端玩家100002金币149→164；bluff@1 返回手里；提示已截图|
|读档手牌|通过|全退出进程、继续同种子，在下一次召唤初始化后 hand 仍 bluff@1，points=30、battles=6；未重弹第一幕选包|
|第二幕再选包+1|通过|第二幕三选一出现，名称都带+1，硬化8/再生20%/倒计时35%/鼓舞2/狂怒3/碎甲2等数值；泥沼仍2，符合表而非每项都增加|
|击倒奖励抽陷阱|未覆盖|仅一名爬塔玩家，无法实现该玩家倒下、其他爬塔玩家获胜；不能把已退场塔主当队友|
|窒息、同名双陷阱只触发一张、敌方回合死亡狂怒|未覆盖|不在本轮八项指定触发的独立验证中；狂怒基础触发已失败|

## 狂怒复现及只读定位

第二幕首战盖 rally@2 + frenzy@2，召唤两只蝌蚪（25/24 血）。第 1 回合三张打击把第一只打到 7；第 2 回合不攻击；第 3 回合鼓舞先施加力量 2，再用打击击杀第一只。继续一张打击攻击剩余蝌蚪，实际只剩一只 18/24；两端力量仍 2，陷阱 fired_count=1、unfired=[frenzy@2]。进入下一回合、正常打赢后狂怒仍未触发，作为没触发陷阱返还并给爬塔玩家 15 金币。不是只观察过早：额外出牌、下一回合、胜利收尾均没有狂怒触发日志。

只读依据：mod/TowerMaster/TrapPhase.cs 的 CheckDeaths 扫描 combat.Enemies 内 IsDead 数量；AfterCardPlayed 和 RoundStarted 才调用检查。游戏 decompiled/sts2/MegaCrit.Sts2.Core.Commands/CreatureCmd.cs:398 调用 Hook.AfterDeath，:402–406 移除死亡 creature；decompiled/sts2/MegaCrit.Sts2.Core.Combat/CombatState.cs:161 RemoveCreature，:173 从 _enemies 移除，:37 Enemies 返回此列表。因此出牌后再扫描 Enemies 可能已看不到死者，与本轮现象吻合。建议挂实际死亡钩子，或保存战斗初始怪物引用／比较离场前后的 ID；只是建议，没有改代码。

## 读档与持久化注意

刚回存档时 tm_traps 显示 hand=[]、wallet=null，因为账本还未被召唤流程初始化；进入下一普通战选择阶段，hand=[bluff@1]，wallet points=30/act1/battles6，且无 pack_choice。测试必须在初始化之后断言，不能误报手牌丢失。完整退出前后日志分别保存在本地 work/traps-0.0.22/before-reload 和 scripts/local-test，不提交原始文件。

## 两端日志摘录

以下每行两端去时间戳完全对应，序号在重启后重新从 1 计数：

```text
（读档前）
INFO 塔主回合 #19 第2回合：陷阱 mire@1 触发，数值 2
INFO 塔主回合 #24 第4回合：陷阱 mend@1 触发，数值 15
INFO 塔主回合 #40 第6回合：陷阱 countdown@1 触发，数值 30
INFO 塔主回合 #45 第7回合：躲过陷阱 空陷阱，每名玩家 +15 金币
（读档后）
INFO 塔主回合 #12 第3回合：陷阱 rally@2 触发，数值 2
INFO 塔主回合 #17 第4回合：躲过陷阱 狂怒+1，每名玩家 +15 金币
INFO 塔主回合 #21 第1回合：陷阱 brittle@2 触发，玩家 100002，数值 2
INFO 塔主回合 #48 第1回合：陷阱 harden@3 触发，玩家 100002，数值 11
INFO 塔主回合 #57 第5回合：躲过陷阱 破绽+2，每名玩家 +15 金币
INFO 塔主回合 #61 第1回合：陷阱 exposed@3 触发，玩家 100002，数值 2
```

每场完成后调用 tm_compare_logs 返回 equal=true；退出后又对两段完整文件做核对，两端对应记录一致。由于正文只摘录证据，不提交所有日志。

## 截图与工具限制

截图 docs/screenshots/traps-022-*：第一／第二幕选包、保护、B 手里数量提示、回合开始触发、躲过奖励、鼓舞和未触发狂怒、碎甲、破绽。硬化时读取过两端格挡11，但早期脚本复用截图文件名导致截图被后续回合覆盖，未提交覆盖图来冒充硬化瞬间，证据采用实测数值和两端执行日志。

选包、盖牌、出牌、结束回合、宝箱、事件用专门接口；休息处走已查原版 NRestSiteButton.OnRelease；效果数值用只读反射读取。不改规则和 mod。破绽补抽依据 DrawConsoleCmd.IsNetworked=true（decompiled/sts2/MegaCrit.Sts2.Core.DevConsole.ConsoleCommands/DrawConsoleCmd.cs:19），命令为 draw 5；牌仍由 tm_play 入队原版动作。

## 最终日志统计

最终退出后核对两段完整日志：读档前两端各 48 条塔主回合记录、读档后各 67 条，分别完全一致；两段两端 StateDivergence 均 0。TowerMaster 日志 ERROR/WARN 均 0。游戏日志的非同步问题如实记录如下。

|阶段|来源|ERROR 行数|WARN/WARNING 行数|
|---|---|---:|---:|
|读档前|塔主游戏|12|272|
|读档前|爬塔玩家游戏|13|84|
|读档后|塔主游戏|12|818|
|读档后|爬塔玩家游戏|16|130|

统计包括游戏结构化日志和 Godot 原生 ERROR:/WARNING:。塔主两次 12 条均是退出资源泄漏；爬塔玩家读档前 1 次、读档后 4 次 ObjectDisposedException，其他也是退出泄漏。WARN 主要有 Asset not cached、low_health_loop 动画缺失、网络包扩容、其他已安装模组声明及退出泄漏。不把所有警告归因于 TowerMaster；本轮没有隔离其他模组作归因对照。

### 爬塔玩家多人位置图标异常（共 5 次，同一调用栈）

```text
ERROR: System.ObjectDisposedException: Cannot access a disposed object.
Object name: 'Godot.CompressedTexture2D'.
   at Godot.GodotObject.GetPtr(GodotObject instance)
   at Godot.TextureRect.SetTexture(Texture2D texture)
   at MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerState.<>c__DisplayClass93_0.<TweenLocationIconIn>b__0()
   at Godot.Callable.<From>g__Trampoline|11_0[TResult](Object delegateObj, NativeVariantPtrArgs args, godot_variant& ret)
   at Godot.DelegateUtils.InvokeWithVariantArgs(IntPtr delegateGCHandle, Void* trampoline, godot_variant** args, Int32 argc, godot_variant* outRet)
```

没有造成 StateDivergence，也没有阻断继续测试，来源在原版多人图标 Tween 回调；是否和模组资源缓存相关尚不确定，交给开发者评估。

### 退出资源泄漏 ERROR 摘录（每个阶段原文完整列出此类别）

读档前 塔主：

```text
ERROR: 1 RID allocations of type 'N26RendererEnvironmentStorage11EnvironmentE' were leaked at exit.
ERROR: 5 shaders of type CanvasShaderRD were never freed
ERROR: 25 RID allocations of type 'N10RendererRD16ParticlesStorage9ParticlesE' were leaked at exit.
ERROR: 1 shaders of type ParticlesShaderRD were never freed
ERROR: 25 RID allocations of type 'N10RendererRD11MeshStorage4MeshE' were leaked at exit.
ERROR: 78 RID allocations of type 'N10RendererRD15MaterialStorage8MaterialE' were leaked at exit.
ERROR: 6 RID allocations of type 'N10RendererRD15MaterialStorage6ShaderE' were leaked at exit.
ERROR: 185 RID allocations of type 'N10RendererRD14TextureStorage7TextureE' were leaked at exit.
ERROR: 311 RID allocations of type 'PN18TextServerAdvanced22ShapedTextDataAdvancedE' were leaked at exit.
ERROR: 10 RID allocations of type 'PN18TextServerAdvanced12FontAdvancedE' were leaked at exit.
ERROR: 8 RID allocations of type 'PN18TextServerAdvanced27FontAdvancedLinkedVariationE' were leaked at exit.
ERROR: 232 resources still in use at exit (run with --verbose for details).
```

读档前 爬塔玩家：

```text
ERROR: 1 RID allocations of type 'N26RendererEnvironmentStorage11EnvironmentE' were leaked at exit.
ERROR: 5 shaders of type CanvasShaderRD were never freed
ERROR: 1 RID allocations of type 'N10RendererRD16ParticlesStorage9ParticlesE' were leaked at exit.
ERROR: 1 shaders of type ParticlesShaderRD were never freed
ERROR: 1 RID allocations of type 'N10RendererRD11MeshStorage4MeshE' were leaked at exit.
ERROR: 10 RID allocations of type 'N10RendererRD15MaterialStorage8MaterialE' were leaked at exit.
ERROR: 6 RID allocations of type 'N10RendererRD15MaterialStorage6ShaderE' were leaked at exit.
ERROR: 31 RID allocations of type 'N10RendererRD14TextureStorage7TextureE' were leaked at exit.
ERROR: 12 RID allocations of type 'PN18TextServerAdvanced22ShapedTextDataAdvancedE' were leaked at exit.
ERROR: 4 RID allocations of type 'PN18TextServerAdvanced12FontAdvancedE' were leaked at exit.
ERROR: 5 RID allocations of type 'PN18TextServerAdvanced27FontAdvancedLinkedVariationE' were leaked at exit.
ERROR: 66 resources still in use at exit (run with --verbose for details).
```

读档后 塔主：

```text
ERROR: 1 RID allocations of type 'N26RendererEnvironmentStorage11EnvironmentE' were leaked at exit.
ERROR: 5 shaders of type CanvasShaderRD were never freed
ERROR: 26 RID allocations of type 'N10RendererRD16ParticlesStorage9ParticlesE' were leaked at exit.
ERROR: 1 shaders of type ParticlesShaderRD were never freed
ERROR: 26 RID allocations of type 'N10RendererRD11MeshStorage4MeshE' were leaked at exit.
ERROR: 82 RID allocations of type 'N10RendererRD15MaterialStorage8MaterialE' were leaked at exit.
ERROR: 6 RID allocations of type 'N10RendererRD15MaterialStorage6ShaderE' were leaked at exit.
ERROR: 185 RID allocations of type 'N10RendererRD14TextureStorage7TextureE' were leaked at exit.
ERROR: 331 RID allocations of type 'PN18TextServerAdvanced22ShapedTextDataAdvancedE' were leaked at exit.
ERROR: 10 RID allocations of type 'PN18TextServerAdvanced12FontAdvancedE' were leaked at exit.
ERROR: 8 RID allocations of type 'PN18TextServerAdvanced27FontAdvancedLinkedVariationE' were leaked at exit.
ERROR: 233 resources still in use at exit (run with --verbose for details).
```

读档后 爬塔玩家：

```text
ERROR: 1 RID allocations of type 'N26RendererEnvironmentStorage11EnvironmentE' were leaked at exit.
ERROR: 5 shaders of type CanvasShaderRD were never freed
ERROR: 5 RID allocations of type 'N10RendererRD16ParticlesStorage9ParticlesE' were leaked at exit.
ERROR: 1 shaders of type ParticlesShaderRD were never freed
ERROR: 5 RID allocations of type 'N10RendererRD11MeshStorage4MeshE' were leaked at exit.
ERROR: 14 RID allocations of type 'N10RendererRD15MaterialStorage8MaterialE' were leaked at exit.
ERROR: 6 RID allocations of type 'N10RendererRD15MaterialStorage6ShaderE' were leaked at exit.
ERROR: 171 RID allocations of type 'N10RendererRD14TextureStorage7TextureE' were leaked at exit.
ERROR: 65 RID allocations of type 'PN18TextServerAdvanced22ShapedTextDataAdvancedE' were leaked at exit.
ERROR: 8 RID allocations of type 'PN18TextServerAdvanced12FontAdvancedE' were leaked at exit.
ERROR: 3 RID allocations of type 'PN18TextServerAdvanced27FontAdvancedLinkedVariationE' were leaked at exit.
ERROR: 210 resources still in use at exit (run with --verbose for details).
```

## 交接结论

本轮测试与只读调查完成，可以交给 Claude。优先修复狂怒的死亡检测；其余七项在所列幕／等级／阵容下通过。不要把第一幕数值未单独测到的升级牌、多怪全体效果、击倒奖励、敌方回合死亡、窒息等写成全部覆盖。原版多人图标贴图异常建议单独跟踪。

