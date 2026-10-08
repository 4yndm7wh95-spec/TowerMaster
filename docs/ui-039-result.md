# 0.0.39 测试报告

2026-10-08；分支 `claude/optimistic-rubin-hr3eit`，代码 `6a5df3a`。只测试、只读定位，未修改 mod 代码。测试 A=100001 房主/塔主，B=100002 爬塔玩家，桥接端口 47101/47102。用户自己的进程 11288 保持运行，未操作/退出。测试进程 26360/24392 已正常退出。川换皮未加载，角色为原版铁甲战士。

全程地图投票进房，未用 room/fight/win；未给 B 加能量、抽牌或生命。本轮不是平衡样本。给塔主两次 `draw 10` 用于抽到已合法获得的请客、起哄；另尝试原版 card 命令补临时牌，但命令找不到塔主牌，未实际加入。其余六张娱乐牌未覆盖，不能当通过。

## 结论

| 项目 | 结论 | 证据 |
|---|---|---|
| 编译、安装 | 通过 | 105 测试通过（47+58），游戏安装构建 0 错误/0 警告，manifest=0.0.39，两端 ping=.39 |
| 配置覆盖 | 通过 | 仓库文件覆盖安装文件，SHA256 一致，master_cards=true |
| 99 种卡、198 条本地化 | 通过 | 两端注册日志符合预期 |
| 预览裁切 | 部分修复 | 劫掠者、旧日雕像及高个怪主体完整度明显改善 |
| 预览散件 | 不通过 | 化石追踪者、幽灵船、鬼祟珊瑚群仍分散；淤泥旋螺只见小点/粒子 |
| 隐藏分页取景 | **不通过，已做对照** | 默认第一幕时其他幕 20 个模型记录空白并定格，后来切页过小；新面板取景前切全部则恢复大小 |
| B 暂停接口 | 通过 | hand 正常 paused=true；play/end_turn 均 invalid_phase，不入队 |
| 娱乐牌 | 部分覆盖 | 请客、起哄两端效果一致；其余六张未覆盖 |
| 同步 | 通过（覆盖范围内） | 26/26 动作摘要逐行全等，StateDivergence=0 |
| 日志完全无异常 | 不通过 | TowerMaster 两端 0 ERROR/0 WARN；B 游戏有一次已释放纹理异常，退出时另有资源泄漏诊断 |

配置两份 SHA256：`CE7D223D1626984CFD04F2F8E54D0CF4819EC3B6BDEB2B783F4866E23D169301`。

注册原文（A）：

```text
[03:55:08.920] INFO 塔主牌：已生成 99 种卡牌类型（TowerMasterBlock1 …），等 ModelDb.Init 收录
[03:56:20.731] INFO 塔主牌：本地化表 cards 补了 198 条（例 TOWER_MASTER_BLOCK1.title）
```

## 1. 三幕预览和 0.0.38 逐项对照

沿上一轮保存的种子 `17101550717777027434` 继续：休息处 (0,7)→宝箱 (0,8)→精英 (0,9)；精英召唤面板包含全部 53 个候选（第一幕 33、第二幕 8、第三幕 12，均含精英）。三幕分页、各幕精英筛选均截图；第一幕滚到底，第二/三幕整页可见。之后普通房 (0,12) 再打开面板做“早切全部”的对照。

下表“早切全部”指**新面板打开后、取景定格前点全部，等约 3 秒再切第二/三幕**。不是修改代码或模型参数。默认打开时第一幕可见，另外两幕隐藏。

| 幕 | 0.0.38 列出的怪 | 0.0.38 | 0.0.39 本轮 |
|---|---|---|---|
| 一 | 劫掠者刺客 | 缺头 | 头/身体完整，修复 |
| 一 | 劫掠者斧手、劫掠者弩手 | 缺头/上部 | 头/身体完整，修复 |
| 一 | 劫掠者暴徒 | 高个需复核 | 身体和头可见 |
| 一 | 淤泥旋螺 | 极小/分离小点 | **仍不通过**：竖排粒子、小点，主体难识别 |
| 一 | 化石追踪者 | 散骨件 | **仍不通过**：散开的骨/肢体 |
| 一 | 幽灵船 | 船体和帆分离 | **仍不通过**：散件，没有完整船体 |
| 一 | 旧日雕像 | 只有下部 | 完整雕像可见，修复 |
| 一 | 鬼祟珊瑚群 | 分散部件 | 仍分散；外观是否应这样需原版图鉴实图对照，不能仅据模型名判定 |
| 一 | 墨宝 | 上轮已改善 | 完整猫形主体、亮眼；保持 |
| 一 | 蛇行扼杀者 | 上轮已成一体 | 盘曲主体完整；保持 |
| 一 | 缩小甲虫 | 身体可见/头上白粒子 | 身体完整，白粒子仍在；未把正常粒子当缺件 |
| 二 | 棘刺蟾蜍 | 上部裁切 | 默认延迟切页过小；早切全部后主体完整 |
| 二 | 猎人杀手 | 顶部裁切 | 默认过小；早切全部后完整 |
| 二 | 虱虫之祖 | 上部裁切 | 默认过小；早切全部后完整 |
| 二 | 蜂群术士 | 缺头/上部 | 默认过小；早切全部后完整头和身体 |
| 二 | 感染棱柱 | 少量顶部碎片 | 默认过小；早切全部后红色核心和周边蓝晶可见，需图鉴确认组件分布 |
| 二 | 啃咬机 | 偏小 | 默认更小；早切全部后正常可识别 |
| 三 | 活体盾 | 头/上部裁切 | 默认过小；早切全部后头、身、盾完整 |
| 三 | 虔诚雕刻师 | 上部裁切 | 默认过小；早切全部后头/肩部造型完整 |
| 三 | 电球头 | 只见腿 | 默认过小；早切全部后球形头和身体完整 |
| 三 | 失落之物、遗忘之物 | 主体贴顶/不完整 | 默认过小；早切全部后完整主体可见 |
| 三 | 猫头鹰法官 | 上部切掉 | 默认过小；早切全部后头和翅膀可见 |
| 三 | 史莱姆狂战士 | 上部切掉 | 默认过小；早切全部后完整外形 |
| 三 | 灵魂枢纽、机甲骑士 | 缺上半部 | 默认过小；早切全部后主体/双臂双腿完整 |
| 三 | 高塔炮手、咬人卷轴 | 偏小 | 默认极小；早切全部后明显改善 |

其余候选也逐页观察：第一幕小啃兽、蛮兽、飞蝇菌子、拳击构装体、多尼斯异鸟等完整；第二幕偷窃草蜢、地道虫和第三幕青蛙骑士同样存在默认隐藏页过小、早切全部后恢复的问题。结论只覆盖实际 53 个候选，不扩展到未出现在列表里的 Boss 或其他模型。

截图：

- 第一幕：[顶部](screenshots/ui039-act1-top.png)、[底部](screenshots/ui039-act1-bottom.png)、[精英](screenshots/ui039-act1-elite.png)。
- 第二幕：[默认延迟切页](screenshots/ui039-act2-top.png)、[底部](screenshots/ui039-act2-bottom.png)、[精英](screenshots/ui039-act2-elite.png)、[早切全部对照](screenshots/ui039-early-all-act2.png)。
- 第三幕：[默认延迟切页](screenshots/ui039-act3-top.png)、[底部](screenshots/ui039-act3-bottom.png)、[精英](screenshots/ui039-act3-elite.png)、[早切全部对照](screenshots/ui039-early-all-act3.png)。

### 取景日志汇总

第一张精英面板：20 个第二/三幕候选全部记录“什么都没画出来”，名字如下：

`Chomper, SpinyToad, ThievingHopper, Tunneler, HunterKiller, LouseProgenitor, Entomancer, InfestedPrism, TurretOperator, ScrollOfBiting, LivingShield, TheLost, TheForgotten, DevotedSculptor, GlobeHead, FrogKnight, OwlMagistrate, SlimedBerserker, SoulNexus, MechaKnight`。

缩放/校正仅淤泥旋螺有非零次数日志：

```text
[03:59:14.488] INFO 召唤面板：SludgeSpinner 取景 缩小 4 次、校正 1 次，范围 (67, 2), (13, 95)
[04:18:13.623] INFO 召唤面板：SludgeSpinner 取景 缩小 4 次、校正 0 次，范围 (68, 23), (13, 34)
```

其他候选没有非零次数行；代码在无缩小/校正时不记该行，不能把“没日志”当成没执行。没有“套皮肤/启动动画失败”“自动取景失败”。

**对照后的定位推断：** `SummonPanel.cs:205` 默认本幕筛选，`:236` `ApplyFilter()` 隐藏其他幕 Card；`:692` `FitAndFreeze(...)` 在空图时直接 `Freeze("什么都没画出来")`，禁用后续更新。实际截图与“隐藏项未渲染就判空并永久跳过取景”吻合。早切全部后这 20 个模型正常大小，显著支持此解释；建议 Claude 检查隐藏时的 SubViewport 渲染/延后取景，不只继续调统一缩放比例。未做 FPS 采样，打开面板的精确卡顿时间未确认。

## 2. 原版图鉴只读路径（供 Claude 实现参考）

所有路径相对仓库，均为本机 v0.111.0 反编译定位；只转述，不提交源码。普通怪，包括化石追踪者、幽灵船、鬼祟珊瑚群走默认布局。未在原版游戏里另开图鉴拍实图，所以不宣称原版实际显示已对照通过。

| 类/签名 | 文件:行 | 自己的话转述 |
|---|---|---|
| `NBestiary.SelectMonster(NBestiaryEntry entry)` | `decompiled/sts2/MegaCrit.Sts2.Core.Nodes.Screens.Bestiary/NBestiary.cs:730` | 选条目，清旧布局，根据条目创建/复用布局，加进布局容器，调用 Setup，生成动作按钮。Setup 调用在 781 行。 |
| `BestiaryEntry.CreateLayoutNode(NBestiary bestiary)` | `.../MegaCrit.Sts2.Core.Nodes.Screens.Bestiary/BestiaryEntry.cs:62` | KaiserCrab/Decimillipede 用专用布局，其余默认 NBestiaryLayoutDefault。 |
| `NBestiaryLayoutDefault.Setup(BestiaryEntry entry, Tween tween)` | `.../MegaCrit.Sts2.Core.Nodes.Screens.Bestiary/NBestiaryLayoutDefault.cs:63` | 规范怪 ToMutable，设 RNG/RunRng，SetUpForCombat；创建 Enemy Creature，CombatState 为 NullCombatState；NCreature.Create，挂到容器；SetupForBestiary；竖直位置用半个 Hitbox 高度；淡入；GenerateBestiaryMoveList。 |
| `MonsterModel.SetUpForCombat()` | `.../MegaCrit.Sts2.Core.Models/MonsterModel.cs:363` | 初始化移动状态机、标记本回合生成。 |
| `NCreature.Create(Creature entity)` | `.../MegaCrit.Sts2.Core.Nodes.Combat/NCreature.cs:245` | 实例化完整 NCreature 场景，设 Entity，由实体创建 Visuals。不是只实例化外观。 |
| `Creature.CreateVisuals()` | `.../MegaCrit.Sts2.Core.Entities.Creatures/Creature.cs:345` | 怪物委托 Monster.CreateVisuals。 |
| `MonsterModel.CreateVisuals()` | `.../MegaCrit.Sts2.Core.Models/MonsterModel.cs:240` | 从场景缓存实例化 VisualsPath 的 NCreatureVisuals；异常时用错误外观回退。 |
| `NCreatureVisuals._Ready()` | `.../MegaCrit.Sts2.Core.Nodes.Combat/NCreatureVisuals.cs:154` | 取 Visuals/Bounds/标记节点；Spine 怪建 MegaSprite，骨骼数据不存在则禁用 Spine。 |
| `NCreature._Ready()` | `.../MegaCrit.Sts2.Core.Nodes.Combat/NCreature.cs:257` | 加入 Visuals、位置归零；有 Spine 时 GenerateAnimator，再 SetUpSkin，再连接动画信号；更新 Bounds 和恐惧替代外观。核心顺序在 310–313。 |
| `NCreatureVisuals.SetUpSkin(MonsterModel model)` | `.../MegaCrit.Sts2.Core.Nodes.Combat/NCreatureVisuals.cs:224` | SpineBody/骨骼存在才调用 model.SetupSkins。 |
| `CreatureAnimator(AnimState initialState, MegaSprite spineController)` | `.../MegaCrit.Sts2.Core.Animation/CreatureAnimator.cs:35` | 连接动画信号并进入初始状态；idle_loop 会偏移播放位置，并 Update/Apply 骨骼。 |
| `NCreature.SetupForBestiary()` | `.../MegaCrit.Sts2.Core.Nodes.Combat/NCreature.cs:999` | 隐藏血条与意图，标记图鉴状态。不是取景算法。 |
| `NCreature.UpdateBounds(Node boundsContainer)` | `.../MegaCrit.Sts2.Core.Nodes.Combat/NCreature.cs:385` | 根据 Bounds、Visuals.Scale 更新 Hitbox/框选/意图/状态栏位置。 |
| `NBestiary.PlayMoveAnim(IEnumerable<NCreature> creatures, BestiaryMonsterMove move)` | `.../MegaCrit.Sts2.Core.Nodes.Screens.Bestiary/NBestiary.cs:861` | 点动作时按 move.animId 播放非循环动画，结束后排回 idle_loop；不是统一冻结零件。 |

动画细节：`FossilStalker.GenerateAnimator(MegaSprite)` 在其文件 95 行，`HauntedShip.GenerateAnimator(MegaSprite)` 在 85 行，`SkulkingColony.GenerateAnimator(MegaSprite)` 在 104 行；三者初始状态都是循环 `idle_loop`，再各自注册攻击/受击/死亡等状态。模型基类 `MonsterModel.GenerateAnimator(MegaSprite)` 在 417 行也默认 idle_loop。不要把任意攻击动画/入场中间帧当成静态预览。

缩放：默认图鉴 Setup 的 C# 路径没有本 mod 那种“读图片像素→自动缩放至卡片→定格”的算法；它保留外观场景缩放，用 Hitbox 半高定位，完整 Creature 维护 Bounds。场景本身/布局容器的最终缩放属性本轮未解析，不能给出统一缩放数值。若复用图鉴流程，需验证 NullCombatState、事件订阅清理、怪物 RNG 和额外节点成本，不能把图鉴创建的 Creature 加进真实战斗状态。

## 3. 暂停接口

塔主回合 active=true，B：`/combat/hand` 正常返回 `paused_by_master_turn=true`、5 张牌、3 能量；分别只提交一次出牌和结束回合，均返回：

```text
B/combat/play: invalid_phase：塔主回合中，玩家出牌暂停，等塔主结束再出
B/combat/end_turn: invalid_phase：塔主回合中，玩家出牌暂停，等塔主结束再出
```

两次拒绝后，B 手里仍 5 张、3 能量，敌人血量未变化；塔主结束后没有这两项的遗留动作自动打出。随后正常提交 B 的牌能执行。上轮“读手牌被拒、出牌却入队”已修复。

## 4. 娱乐牌覆盖

| 卡 | 获取/辅助 | 实测两端结果 | 结论 |
|---|---|---|---|
| 请客 | 宝箱 (0,8) 三选一合法获得；塔主 draw 10 抽到 | B 49→54 HP，敌旧日雕像 Strength 0→1；两端摘要相同 | 通过（第一幕、单爬塔玩家、单敌样本） |
| 起哄 | 精英 (0,9) 三选一合法获得；塔主 draw 10 抽到 | B 得 Vulnerable1，手牌 5→6，塔主 0 费；两端相同 | 通过（单玩家样本） |
| 黏液大礼包 | 未取得 | 弃牌堆实际增加未验证 | 未覆盖 |
| 荆棘丛 | 出现在精英候选，实际选了起哄 | 未打出 | 未覆盖 |
| 金身 | 未取得 | 未打出 | 未覆盖 |
| 摇人 | 未取得；临时 card 命令失败 | 增援、能被击杀、第二次拒绝未验证 | 未覆盖 |
| 内讧 | 出现在精英候选，实际选了起哄 | 未打出 | 未覆盖 |
| 惊喜盲盒 | 未取得；临时 card 命令失败 | 随机提示与结果未验证 | 未覆盖 |

[请客](screenshots/ui039-feast.png)、[起哄](screenshots/ui039-heckle.png)。

关键摘要原文（去掉时间戳；A/B 同行相同）：

```text
INFO 动作摘要 #22 threat:end｜层10 回合1/Player 敌[BygoneEffigy:127/127b0{Slow1,Strength1}] 玩家[100001:0/80b0 g99 k11 e2 h0 d1 x10 100002:54/80b0 g145 k11 e3 h5 d6 x0]
INFO 动作摘要 #80 threat:end｜层13 回合1/Player 敌[LeafSlimeS:12/12b0] 玩家[100001:0/80b0 g99 k12 e2 h0 d2 x10 100002:36/80b0 g145 k13 e3 h6 d7 x0{Vulnerable1}]
```

原版临时卡补充尝试：`card TOWER_MASTER_CALL_HELP1`、`card TOWER_MASTER_GAMBLE1` 返回 `Card '...' not found`，未加入牌，也未增加能量。只读原因：`CardConsoleCmd.Process(Player?, string[])` 在 `decompiled/sts2/MegaCrit.Sts2.Core.DevConsole.ConsoleCommands/CardConsoleCmd.cs:23` 通过 ModelDb.AllCards 查找；`ModelDb.cs:96` AllCards 汇总普通卡池/角色初始牌，塔主牌刻意不属于这些池。此结果不能据以认定注册失败，99 种类型/198 本地化及合法奖励卡都正常。

建议给后续测试桥增加“同步给塔主临时测试手牌”的专门工具（仅测试环境、走原版联机动作、登记 Owner/ICardScope、不写永久账本），便于覆盖六张随机未拿到的牌；本轮没有自行实现或注入此功能。未覆盖的项不能用静态代码检查替代效果验收。

正常完成：地图精英旧日雕像，以及 (0,12) 单树叶史莱姆小、(0,13) 两只树叶史莱姆小；战斗均正常结束。精英中原版涅奥之怒的弃牌堆选择使用原版 CompleteSelection 回调确认（可选 0 张），未跳过战斗。没有把机器人表现用于胜率结论。

## 5. 同步和日志异常

两端 26 条全部动作摘要去时间戳逐行完全一致，StateDivergence=0。TowerMaster 两端 ERROR=0、WARN=0；“找不到/失败”仅控制台输出上述未入普通池的卡找不到，不存在娱乐牌实际出牌的“效果失败”。

| 日志范围 | 游戏 A ERROR/WARN | 游戏 B ERROR/WARN |
|---|---:|---:|
| 测试结束、退出前 | 0 / 220 | 1 / 54 |
| 两测试进程正常退出后 | 12 / 226 | 13 / 59 |

按 ERROR、WARN/WARNING 行数统计，并非独立种类。两端各 12 条新增 ERROR 都是退出时 RID/Shader/资源未释放诊断，不是战斗中断。常见 WARN 为 Asset not cached、网络 packet writer 扩容；原版资源告警不能算作“无异常”。原始日志只保留在本机，不提交。

B 的运行中 ERROR：在沿地图从 (0,12) 转到 (0,13) 普通房、召唤动作到达前出现，和上一轮记录过的远端位置图标纹理释放问题同类。其后两端继续正常战斗，无 StateDivergence，尚未确定归因。

```text
ERROR: System.ObjectDisposedException: Cannot access a disposed object.
Object name: 'Godot.CompressedTexture2D'.
   at Godot.GodotObject.GetPtr(GodotObject instance)
   at Godot.TextureRect.SetTexture(Texture2D texture)
   at MegaCrit.Sts2.Core.Nodes.Multiplayer.NMultiplayerPlayerState.<>c__DisplayClass93_0.<TweenLocationIconIn>b__0()
   at Godot.Callable.<From>g__Trampoline|11_0[TResult](Object delegateObj, NativeVariantPtrArgs args, godot_variant& ret)
   at Godot.DelegateUtils.InvokeWithVariantArgs(IntPtr delegateGCHandle, Void* trampoline, godot_variant** args, Int32 argc, godot_variant* outRet)
   at: void Godot.NativeInterop.ExceptionUtils.LogException(System.Exception) (:0)
```

退出资源 ERROR 摘录：

A：

```text
ERROR: 1 RID allocations of type 'N26RendererEnvironmentStorage11EnvironmentE' were leaked at exit.
ERROR: 5 shaders of type CanvasShaderRD were never freed
ERROR: 27 RID allocations of type 'N10RendererRD16ParticlesStorage9ParticlesE' were leaked at exit.
ERROR: 1 shaders of type ParticlesShaderRD were never freed
ERROR: 27 RID allocations of type 'N10RendererRD11MeshStorage4MeshE' were leaked at exit.
ERROR: 74 RID allocations of type 'N10RendererRD15MaterialStorage8MaterialE' were leaked at exit.
ERROR: 6 RID allocations of type 'N10RendererRD15MaterialStorage6ShaderE' were leaked at exit.
ERROR: 179 RID allocations of type 'N10RendererRD14TextureStorage7TextureE' were leaked at exit.
ERROR: 350 RID allocations of type 'PN18TextServerAdvanced22ShapedTextDataAdvancedE' were leaked at exit.
ERROR: 9 RID allocations of type 'PN18TextServerAdvanced12FontAdvancedE' were leaked at exit.
ERROR: 7 RID allocations of type 'PN18TextServerAdvanced27FontAdvancedLinkedVariationE' were leaked at exit.
ERROR: 228 resources still in use at exit (run with --verbose for details).
```

B：

```text
ERROR: 1 RID allocations of type 'N26RendererEnvironmentStorage11EnvironmentE' were leaked at exit.
ERROR: 5 shaders of type CanvasShaderRD were never freed
ERROR: 19 RID allocations of type 'N10RendererRD16ParticlesStorage9ParticlesE' were leaked at exit.
ERROR: 1 shaders of type ParticlesShaderRD were never freed
ERROR: 19 RID allocations of type 'N10RendererRD11MeshStorage4MeshE' were leaked at exit.
ERROR: 60 RID allocations of type 'N10RendererRD15MaterialStorage8MaterialE' were leaked at exit.
ERROR: 6 RID allocations of type 'N10RendererRD15MaterialStorage6ShaderE' were leaked at exit.
ERROR: 183 RID allocations of type 'N10RendererRD14TextureStorage7TextureE' were leaked at exit.
ERROR: 242 RID allocations of type 'PN18TextServerAdvanced22ShapedTextDataAdvancedE' were leaked at exit.
ERROR: 9 RID allocations of type 'PN18TextServerAdvanced12FontAdvancedE' were leaked at exit.
ERROR: 7 RID allocations of type 'PN18TextServerAdvanced27FontAdvancedLinkedVariationE' were leaked at exit.
ERROR: 225 resources still in use at exit (run with --verbose for details).
```

## 交接重点

优先修隐藏分页取景判空即冻结的流程，并按全部 53 候选验证；散件继续对照原版完整 Creature 图鉴流程。接口暂停检查已经通过。两张实测娱乐牌通过，六张明确未覆盖，需继续针对性验收。B 的位置图标已释放纹理异常保留为待归因问题，不把 26 条同步一致扩展为“完全没有错误”。
