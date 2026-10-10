# 塔主回合 0.0.21 实测结果

## 环境与总体结论

2026-10-06；游戏 v0.111.0；代码 3b64e37；同机双实例 IP 直连，塔主=100001（房主），爬塔玩家=100002。真实游戏编译安装成功，零编译警告/错误，manifest=0.0.21、master_turn=true。dotnet test 85 个通过（Core 41、TowerMaster 44）。默认不限时，本轮没有反射改规则配置，没有修改 mod 或测试接口代码。

核心不同步回归通过：第一场普通战用 tm_play/tm_end_turn 打完 5 回合，不用 win；前 3 回合均出现塔主回合，之后威胁点耗尽跳过。两端塔主回合 37 条日志去时间戳完全一致。本轮含普通战 7 场、精英 2 场、Boss 1 场；除首场外以 win 加速，不据此声称 AI/平衡验证完整。

种子 1045745583437700037，第一幕 Underdocks。首场蟾蜍蝌蚪 22/23 血。塔主回合左侧面板和爬塔玩家上方提示均已截图核验，没有倒计时，不遮挡右侧怪物。塔主能看到爬塔玩家五张手牌文字。两端截图尺寸分别 1707×960、1920×1080（接口报告 Fullscreen）。

## 逐项结论

|事项|结果|证据／限制|
|---|---|---|
|第 3 回合不同步回归|通过|首场打到第 5 回合；未用 win，前 3 回合日志对应，未触发断线|
|塔主回合暂停牌和结束回合|通过|第 2 回合能量 3、手牌五张、怪物 22 血；入队打击+结束回合后仍不变；解除后怪物 16 血，进入第 3 回合|
|第 1 回合防御出牌|测试操作无效|误给 Self 牌传怪物 target=0，被取消，见 ERROR 原文；不能作为有效出牌样本|
|格挡／单体力量|通过|第 3 回合蝌蚪下标 1 两端格挡 6、StrengthPower 1；威胁点 3→2→0 自动结束|
|回血|通过|第二场噬尸蛞蝓最大生命 26，伤后 22→24，两端一致，花 1 点|
|虚弱／易伤／脆弱|通过|分别施加 1 层；两端对应 Power 类型一致，易伤直接读取 Amount=1；其他层数亦由执行日志核对|
|同玩家同回合第二次减益|通过|虚弱后再易伤，rejected_rule：这名玩家本回合已经上过减益；不扣点|
|塞眩晕|通过|两端 DrawPile 相同位置新增 Dazed；下一回合手牌含晕眩；花 1 点|
|全体力量|通过（单怪阵容）|第四场幽灵船与第一场精英均施加 +1；精英两端读取 StrengthPower.Amount=1；多怪全体效果未单独覆盖|
|威胁点耗尽／后续跳过|通过|第一场第 4、5 回合没有威胁点了，跳过；第二场回血后也耗尽自动结束|
|面板左侧／无倒计时|通过|已目视核验暂停截图，结束按钮固定底部，手牌文字可见|
|塔主回合进行中 win|有限通过／行为需确认|win 入爬塔玩家队列被暂停，10 秒仍未结束；手动结束塔主回合后约 0.53 秒出现奖励，下一场正常。并未覆盖强制中断正在开放的塔主回合后的兜底清理|
|第一幕精英威胁点 4|通过|鬼祟珊瑚群、恐惧鳗鱼两场均 4|
|第一幕 Boss 威胁点 5|通过|瀑布巨兽 240 血，威胁点 5，已截图|
|用户真实打 2 场与主观平衡|未覆盖|首场为助手真实出牌，其他 win；不当作用户体验结论|

## 暂停与自然战斗详细记录

第一场：第 1 回合手牌防御/打击/打击/打击/打击，能量 3，暂停 true。误传防御 target=0 和结束回合，暂停时状态不变。结束塔主回合后防御因无效目标取消，结束回合继续，第 2 回合玩家 73 血。

第 2 回合暂停 true，能量 3，手牌五张。tm_play index=2 target=0（打击），再 tm_end_turn，等待约 0.5 秒，能量、手牌、怪物血量 22/23 不变。塔主结束后排队打击执行，目标 22→16，敌人回合正常，第 3 回合玩家 62 血。第 3 回合塔主给另一只蝌蚪格挡 6 和力量 1，花完 3 点；之后正常攻击直到第 5 回合获胜。最低观察血量 35，胜利燃烧之血恢复到 41；80→41 净掉血 39。测试故意跳防御和等待，不宜用于定量平衡评价。

首场塔主行动：第 1、2 回合不花点，手动结束；第 3 回合格挡 1 点、力量 2 点，之后不再参与。召唤点首场 12→9（按原版标准费 3），收入 +8（基础 5+战果 3）→17。

第二场：虚弱 1 点+眩晕 1 点，第二次减益被拒；手动结束后用一张打击制造伤害、结束回合；第二回合回血 1 点，22→24，耗尽后 win。第三场第一回合易伤 1 点，第二回合脆弱 1 点；此时威胁点剩 1，win 排队，塔主手动结束后才获胜。第四场全体力量 3 点耗尽后 win。后续通过原版地图路线、事件选择、休息及宝箱进入精英和 Boss，未跳地图、未改血量或卡堆。

## 两端回合日志（每端均完整对应）

```text
INFO 塔主回合 #1 第1回合：开始，玩家暂停出牌
INFO 塔主回合 #2 第1回合：结束，玩家继续
INFO 塔主回合 #3 第2回合：开始，玩家暂停出牌
INFO 塔主回合 #4 第2回合：结束，玩家继续
INFO 塔主回合 #5 第3回合：开始，玩家暂停出牌
INFO 塔主回合 #6 第3回合：加格挡 Toadpole[1] 6
INFO 塔主回合 #7 第3回合：加力量 Toadpole[1] 1
INFO 塔主回合 #8 第3回合：结束，玩家继续
INFO 塔主回合 #9 第1回合：开始，玩家暂停出牌
INFO 塔主回合 #10 第1回合：虚弱 玩家 100002 1
INFO 塔主回合 #11 第1回合：塞眩晕 玩家 100002 1
INFO 塔主回合 #12 第1回合：结束，玩家继续
INFO 塔主回合 #13 第2回合：开始，玩家暂停出牌
INFO 塔主回合 #14 第2回合：回血 CorpseSlug[0] 2
INFO 塔主回合 #15 第2回合：结束，玩家继续
INFO 塔主回合 #16 第1回合：开始，玩家暂停出牌
INFO 塔主回合 #17 第1回合：易伤 玩家 100002 1
INFO 塔主回合 #18 第1回合：结束，玩家继续
INFO 塔主回合 #19 第2回合：开始，玩家暂停出牌
INFO 塔主回合 #20 第2回合：脆弱 玩家 100002 1
INFO 塔主回合 #21 第2回合：结束，玩家继续
INFO 塔主回合 #22 第1回合：开始，玩家暂停出牌
INFO 塔主回合 #23 第1回合：全体力量 1 → [0]
INFO 塔主回合 #24 第1回合：结束，玩家继续
INFO 塔主回合 #25 第1回合：开始，玩家暂停出牌
INFO 塔主回合 #26 第1回合：结束，玩家继续
INFO 塔主回合 #27 第1回合：开始，玩家暂停出牌
INFO 塔主回合 #28 第1回合：结束，玩家继续
INFO 塔主回合 #29 第1回合：开始，玩家暂停出牌
INFO 塔主回合 #30 第1回合：全体力量 1 → [0]
INFO 塔主回合 #31 第1回合：结束，玩家继续
INFO 塔主回合 #32 第1回合：开始，玩家暂停出牌
INFO 塔主回合 #33 第1回合：结束，玩家继续
INFO 塔主回合 #34 第1回合：开始，玩家暂停出牌
INFO 塔主回合 #35 第1回合：结束，玩家继续
INFO 塔主回合 #36 第1回合：开始，玩家暂停出牌
INFO 塔主回合 #37 第1回合：结束，玩家继续
```

每场结束调用 tm_compare_logs，最终 equal=true，A/B 各 37 条；此轮所有战斗选择按原版出场，因此没有自定义召唤清单／降血行，不能说覆盖了跨幕召唤回归。

## 接口与原版路径

战斗使用 tm_hand、tm_play、tm_end_turn，等待 paused_by_master_turn=true。塔主操作使用 tm_threat_act/end。只读反射读取实际 Creature.Block、Powers、DrawPile.Cards；没有改对象状态。过休息处用 NRestSiteButton.OnRelease()，读取 Option 确认为 HealRestSiteOption（decompiled/sts2/MegaCrit.Sts2.Core.Nodes.RestSite/NRestSiteButton.cs:173），其余使用专门接口。

建议测试接口根据 card.TargetType 校验／自动处理目标，Self 牌不要接受怪物目标；避免测试误操作直接制造游戏 ERROR。只报告，未改代码。

## 截图

- master-turn-021-paused-A/B.png：第一场第 1 回合，暂停提示、左侧面板及排队牌。
- master-turn-021-effects-A/B.png：第一场第 3 回合格挡／力量。
- master-turn-021-elite-A/B.png：精英威胁点与力量。
- master-turn-021-boss-A/B.png：Boss 威胁点 5 和面板。

截图位于 docs/screenshots/。不提交完整原始日志、反编译源码或游戏资源。

## 日志最终核验

已正常退出两个实例后核验，StateDivergence / State divergence 两端均 0。两端 37 条塔主回合记录仍完全一致。结论：本轮不同步修复和主要塔主回合功能通过；不能声称所有日志无错误。

|来源|塔主|爬塔玩家|
|---|---:|---:|
|TowerMaster ERROR / WARN|0 / 0|0 / 0|
|游戏结构化 [ERROR] / [WARN]|1 / 505|1 / 109|
|Godot 原生 ERROR: / WARNING:|12 / 5|4 / 3|
|StateDivergence|0|0|

游戏 WARN 分类：塔主 Asset not cached 463、low_health_loop 缺失 22、网络包扩容 9、其他 11；爬塔玩家分别 70、22、7、10。其他包含已装模组的版本声明等；游戏有其他模组，不把所有警告归因于塔主。原生退出警告包括资源/RID泄漏。

### 测试操作引起的无效目标错误（两端）

第一次防御测试误传怪物目标，原版取消该牌，两端各一条结构化 ERROR；这是测试输入错误，后续打击排队测试有效。原文：

```text
[ERROR] GameAction PlayCardAction card: CARD.DEFEND_IRONCLAD (54014712) index: 10 targetid: 2 finished execution, but was in state Canceled! The task probably kept executing in a paused state without properly resuming.
[ERROR] GameAction PlayCardAction card: CARD.DEFEND_IRONCLAD (41099582) index: 10 targetid: 2 finished execution, but was in state Canceled! The task probably kept executing in a paused state without properly resuming.
```

### 爬塔玩家贴图已释放异常（2 次，待开发者判断归因）

发生在进入第一场精英前后及后续休息处附近，调用栈位于原版多人位置图标动画。未见 StateDivergence，后续精英、普通房、Boss 完成。没有足够证据证明由本轮塔主回合引起，不忽略该错误：

```text
ERROR: System.ObjectDisposedException: Cannot access a disposed object.
Object name: 'Godot.CompressedTexture2D'.
   at Godot.GodotObject.GetPtr(GodotObject instance)
   at Godot.TextureRect.SetTexture(Texture2D texture)
   at MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerState.<>c__DisplayClass93_0.<TweenLocationIconIn>b__0()
```

### 正常退出时 Godot 资源泄漏错误

以下原生 ERROR 原文统计在上表，发生于退出，未用它们断言战斗失败；未做只开塔主模组的归因对照。

```text
实例 A（塔主）：
ERROR: 1 RID allocations of type 'N26RendererEnvironmentStorage11EnvironmentE' were leaked at exit.
ERROR: 5 shaders of type CanvasShaderRD were never freed
ERROR: 29 RID allocations of type 'N10RendererRD16ParticlesStorage9ParticlesE' were leaked at exit.
ERROR: 1 shaders of type ParticlesShaderRD were never freed
ERROR: 29 RID allocations of type 'N10RendererRD11MeshStorage4MeshE' were leaked at exit.
ERROR: 94 RID allocations of type 'N10RendererRD15MaterialStorage8MaterialE' were leaked at exit.
ERROR: 6 RID allocations of type 'N10RendererRD15MaterialStorage6ShaderE' were leaked at exit.
ERROR: 185 RID allocations of type 'N10RendererRD14TextureStorage7TextureE' were leaked at exit.
ERROR: 349 RID allocations of type 'PN18TextServerAdvanced22ShapedTextDataAdvancedE' were leaked at exit.
ERROR: 10 RID allocations of type 'PN18TextServerAdvanced12FontAdvancedE' were leaked at exit.
ERROR: 8 RID allocations of type 'PN18TextServerAdvanced27FontAdvancedLinkedVariationE' were leaked at exit.
ERROR: 225 resources still in use at exit (run with --verbose for details).
实例 B（爬塔玩家）：
ERROR: 1 RID allocations of type 'N26RendererEnvironmentStorage11EnvironmentE' were leaked at exit.
ERROR: 1 resources still in use at exit (run with --verbose for details).
```

## 交接

本轮测试结束，可交给 Claude。建议确认两点：测试控制台 win 是否应允许越过塔主暂停（目前需结束塔主回合才执行，未死锁）；多人位置图标 CompressedTexture2D 异常是否需要修复。第一回合的防御错误由测试者无效目标造成，不当成同步回归失败。可选的用户自然两场和平衡主观感受未覆盖，未收到额外画面反馈。

