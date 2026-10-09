# 塔主动作与特效：方案和制作说明（0.0.49 修订）

需求：`master-animation-vfx-request.md`、`ui-048-user-followup.md`。用户纠正：「塔主的动作不应该只有几帧，我要的是完整的动画」。
0.0.48 的「三张关键姿势换图」方案作废（那两张姿势图留着当参考，不接入）。三条特效序列（埋牌、护盾、靶心）风格通过，已经接入游戏。

## 1. 方案：切件骨骼动画（Claude 的决定）

**为什么不用生图逐帧画**：生图每一帧都会重新画一遍角色，脸、金饰、衣褶每帧都不一样，连起来会抖、闪，像廉价动图；
而且一个动作要 20~30 帧，三个动作就是近百张，根本对不齐。

**做法**：和原版角色（Spine 骨骼）同一个思路——把现在这张塔主立绘拆成 6 块，每块绕自己的「关节」转动、移动，
代码按关键帧以 60 帧/秒连续播放。所有帧都是同一套画，**完全一致、不会抖**，动作是真正连续的（起手 → 出手 → 停顿 → 收势 → 回到待机）。

代码已经写好（`mod/TowerMaster/MasterRig.cs`），缺的只是拆好的部件图和一个描述文件。没有部件图时游戏照常用静态立绘。

| 动画 | 时长 | 过程 | 什么时候播 |
|---|---|---|---|
| 待机 idle | 循环 | 呼吸起伏 3 像素、头微微点、灯笼轻轻摆、空手和烟慢慢飘 | 一直播 |
| 举灯 cast | 1.1 秒 | 灯先往下一沉（蓄力）→ 高高举起、灯笼变亮、身体微微挺起 → 停 0.25 秒 → 放回 | 给怪物加料、召唤、盲盒 |
| 推灯 point | 1.0 秒 | 灯往回收 → 朝玩家方向一推、身体前倾 → 停 → 收回 | 给玩家减益、塞牌 |
| 埋陷阱 bury | 1.2 秒 | 俯身、空着的手往下一甩（这一刻飞出埋牌特效）→ 起身 | 每场开始盖陷阱时（所有陷阱一个样） |

动作幅度小：身体几度、手臂 15~22 度。特效在「出手」那一刻在目标身上播放（护盾、靶心），埋牌特效插在怪物一侧地面上，盖几张插几张。

## 2. 要做的部件图（测试助手用图像处理完成，不需要重新画角色）

**来源**：`mod/TowerMaster/art/master_figure.png`（512×768，朝左）。每个部件输出成 **同样 512×768、同样位置** 的透明 PNG：
把这一块从立绘里抠出来，放在原来的位置，其他地方全透明。这样叠起来就是原图。

| 文件 | 部件 | 包含 | 关节（转轴，原图坐标，近似值，以实际为准） | 父部件 | 叠放顺序 |
|---|---|---|---|---|---|
| `rig_smoke.png` | 烟 | 袍子下摆外面飘的紫色烟（只要烟，不要袍子） | (256, 650) | 无 | 0（最后面） |
| `rig_body.png` | 身体 | 袍子、腰带、胸前链子、脚——**去掉**头/兜帽、两只手臂、灯笼之后剩下的全部 | (256, 700) 两脚之间 | 无 | 1 |
| `rig_arm_free.png` | 空手 | 画面右边那只手臂：从肩膀到手套，连同袖子 | (335, 215) 肩膀 | body | 2 |
| `rig_head.png` | 头 | 兜帽、面具、兜帽边缘垂下的布 | (222, 180) 脖子 | body | 3 |
| `rig_arm_lantern.png` | 提灯手臂 | 画面左边举着的手臂：从肩膀到握链子的手套，连同垂下来的袖子 | (175, 150) 肩膀 | body | 4 |
| `rig_lantern.png` | 灯笼 | 灯笼和链子（不含手） | (116, 96) 链子和手套接触的地方 | arm_lantern | 5（最前面） |

**关键要求**：

1. **补画被挡住的部分**：拆开以后，原来被手臂、头挡住的地方会露出空洞（例如身体上手臂后面的袍子、兜帽下面的脖子和领口）。
   要用图像编辑（局部重绘/inpainting）把空洞补成合理的袍子、领口，**风格、颜色、描边和原图一致**。补的范围比被挡的地方多出 15~20 像素，
   这样手臂转 20 度时也不会露出透明的洞。
2. **关节处要有重叠**：手臂、头的部件在关节附近多保留 10~15 像素（肩膀、脖子处是圆润的接口），转动时接缝不露缝。
3. 每个部件四周透明，边缘干净（1~2 像素柔边，不要白边、黑边）。
4. 叠在一起（按顺序 0→5）和原图逐像素比较，除了补画的地方以外几乎没有差别。
5. 关节坐标：按实际抠的结果确定转轴（肩膀圆心、脖子中心、链子挂点、两脚之间），写进下面的描述文件。

**描述文件** `mod/TowerMaster/art/rig_master.json`（字段名不能改）：

```json
{
  "canvas": [512, 768],
  "parts": [
    { "name": "smoke",       "file": "rig_smoke.png",       "pivot": [256, 650], "z": 0, "parent": null },
    { "name": "body",        "file": "rig_body.png",        "pivot": [256, 700], "z": 1, "parent": null },
    { "name": "arm_free",    "file": "rig_arm_free.png",    "pivot": [335, 215], "z": 2, "parent": "body" },
    { "name": "head",        "file": "rig_head.png",        "pivot": [222, 180], "z": 3, "parent": "body" },
    { "name": "arm_lantern", "file": "rig_arm_lantern.png", "pivot": [175, 150], "z": 4, "parent": "body" },
    { "name": "lantern",     "file": "rig_lantern.png",     "pivot": [116, 96],  "z": 5, "parent": "arm_lantern" }
  ]
}
```

`name` 必须是这 6 个（代码按名字找动作）；父部件的 `z` 要比子部件小。

**验收**：游戏里战斗时日志有「塔主动画：骨架搭好（6 个部件）」；塔主待机时在轻轻呼吸摆动；出牌、埋陷阱时看得到完整动作、没有缝、没有透明洞、不抖。
用测试接口打几张牌，录一段（或连续截图）给用户看。

## 3. 特效序列（已有 3 条通过，下一批 6 条）

已经接入：`vfx_bury`（埋陷阱）、`vfx_ward`（格挡类：加固、坚壁、荆棘、金身、怪物便当、伏兵）、`vfx_mark`（易伤类：易伤、全体易伤、起哄、黑名单）。

下一批（格式和已通过的三条完全一样：8 帧横条，每帧 256×256，总 2048×256，透明底，每帧中心/地面线一致，风格同前三条）：

| 文件 | 用于 | 内容（逐帧：出现 → 最亮 → 消散） |
|---|---|---|
| `vfx_empower.png` | 力量类（激励、全体激励、伏兵、请客） | 地面一圈暗红符文亮起 → 往上升起一团暗红火焰、隐约成拳头形状 → 火星散开消失；地面线 y=220，中间留空看得见怪物 |
| `vfx_mend.png` | 回复类（治疗、全体治疗） | 绿色藤蔓从地面螺旋长上来 → 开出几片发光叶子 → 叶子散开、光点上浮消失；地面线 y=220 |
| `vfx_drain.png` | 虚弱类（虚弱、挫敌） | 上方垂下三条紫黑色锁链 → 在身体中部缠一圈、收紧 → 锁链碎成紫色碎屑落下；中心 y=120 |
| `vfx_frail.png` | 脆弱 | 一面冰蓝色小盾出现在身体前 → 出现裂纹 → 碎成冰片散开；中心 y=120 |
| `vfx_daze.png` | 塞晕眩/黏液（晕眩、全体晕眩、黏液大礼包） | 一张发光的牌形光片从右上方飞来 → 没入身体，冒出一圈旋转的小星星 → 星星淡出；中心 y=120 |
| `vfx_summon.png` | 摇人、伏击·援军 | 地上展开一个紫色召唤法阵（圆环 + 符文）→ 中心冒起紫烟柱 → 烟散开、法阵淡出；地面线 y=220 |

每条的 prompt 按已通过的 3.5 那条的格式写（每帧具体描述、透明底、不画角色本身、深色背景上可读、不要纯白闪光），风格前缀同上。

### 附：已通过的三条特效 prompt（新特效照这个格式写）

#### `vfx_bury.png` — 埋陷阱（8 帧序列）

> A horizontal sprite sheet of 8 animation frames, each frame 256×256 px, total image 2048×256 px, fully transparent background (real alpha), no grid lines, no text, no frame numbers. All frames share the same ground line at y = 200 px inside each frame and the same horizontal center x = 128 px.
>
> Subject: a single face-down playing card (deep navy back with an antique-gold border and a small closed iron bear-trap emblem in the center — no other markings, no color coding) being planted into the ground, followed by a dark ink-like ripple.
> - Frame 1: the card enters from the upper right, tilted 30°, small (about 60 px tall), with a faint violet motion trail.
> - Frame 2: card larger (90 px), tilting toward vertical, trail longer.
> - Frame 3: card vertical, its bottom edge touching the ground line at the center; a tiny burst of dark dust.
> - Frame 4: card half sunk into the ground; a flat elliptical ring of dark indigo ink spreads on the ground (width 80 px).
> - Frame 5: card only the top quarter visible; ink ring 140 px wide, faint gold sparks at the rim.
> - Frame 6: card gone; ink ring 190 px wide, thinner, sparks fading.
> - Frame 7: ring 220 px wide, almost transparent, a few drifting violet motes.
> - Frame 8: nearly empty — only 2–3 faint motes (alpha ~20%).
>
> Style: hand-painted dark-fantasy game VFX, painterly, muted indigo and antique gold, no bright neon, no white flash, readable over a dark dungeon background. The card back must look identical in every frame where it is visible. Do not show any hint of what the trap is.

#### `vfx_ward.png` — 护盾（8 帧序列）

> Horizontal sprite sheet, 8 frames of 256×256 px (2048×256 total), transparent background, no text/grid. Shared ground line y = 220, center x = 128.
>
> Subject: a protective hexagonal ward rising around a creature (the creature itself is NOT drawn — leave the center empty).
> - Frame 1: a thin steel-blue hexagon outline appears flat on the ground (ellipse 120×30 px).
> - Frame 2: the hexagon outline lifts into a short translucent prism wall (40 px tall), faint runes on its faces.
> - Frame 3: prism 120 px tall, steel-blue glass with gold edge lines, soft inner glow.
> - Frame 4: full height 180 px, brightest frame, a gold rune glints on the front face.
> - Frame 5: same size, glow 70%.
> - Frame 6: the prism starts dissolving from the top into small blue hexagonal shards.
> - Frame 7: mostly shards drifting upward, 40% opacity.
> - Frame 8: a few faint shards, 15% opacity.
>
> Style: hand-painted dark-fantasy VFX, cold steel-blue with antique-gold accents, semi-transparent glass look, no pure white, center of each frame transparent so the monster stays visible through it.

#### `vfx_mark.png` — 靶心印记（8 帧序列）

> Horizontal sprite sheet, 8 frames of 256×256 px (2048×256 total), transparent background, no text/grid. Center x = 128, mark center y = 120.
>
> Subject: a cursed target mark stamped onto a hero (the hero is NOT drawn).
> - Frame 1: a small blood-red rune circle (40 px) appears, faint.
> - Frame 2: it expands to 120 px, with a crosshair of four short red spikes pointing inward.
> - Frame 3: brightest: concentric red rings with a dark crack running through the center, a small dark-red flash.
> - Frame 4: the rings contract slightly (100 px), cracks spread outward like broken glass.
> - Frame 5: crack fragments drift outward, the ring at 60% opacity.
> - Frame 6: ring fades to 35%, fragments small.
> - Frame 7: only faint red embers.
> - Frame 8: almost empty, 10% embers.
>
> Style: hand-painted dark-fantasy VFX, deep crimson and black with a thin antique-gold rim, menacing but not gory, readable over both dark and mid-tone backgrounds, no white flash.

## 4. 特效落地规范（已实现）

- 文件放 `mod/TowerMaster/art/`，名字如上。姿势图 512×768；特效 2048×256（8 × 256）。
- 验收：透明底（四角 alpha 0）；姿势图和 `master_figure.png` 叠在一起交替显示时人物不跳位（脚的位置、头的位置偏差 < 8 像素）；特效每帧的中心和地面线一致。
- 播放：姿势淡入 0.08 秒 → 停 0.25 秒 → 淡回 0.2 秒；特效 16 帧/秒播一次，最后一帧后删除；连续出牌时姿势不重复叠加（正在播就重新计时），特效各自独立播放。
- 埋陷阱：每盖一张播一次 `vfx_bury`，落点是怪物一侧地面上随机偏移（±60 像素，各端用同一个种子），间隔 0.2 秒。
- 生成后先只提交这 5 个样例，截图给用户看风格，再批量做表里其余特效（`vfx_empower`、`vfx_mend`、`vfx_drain`、`vfx_daze`、`vfx_summon`、`vfx_gamble`）。
