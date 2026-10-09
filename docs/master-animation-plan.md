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

### 2.1 拼法（游戏代码已经这样实现，部件图照这个规矩做就不会错位）

1. **每张部件图都是整张 512×768，部件在原来的位置**——只把这一块从 `master_figure.png` 里抠出来，**不挪、不缩放、不裁边**。
   所有部件按顺序叠起来 = 原图。（这一条保证静止时一定对齐，拼接本身不可能错位。）
2. 每个部件挂在一个「关节」上，关节放在**转轴坐标**；部件图在关节里往回挪 -转轴。所以静止时落回原位，动起来绕转轴转。
3. 子部件关节的位置 = 自己的转轴 − 父部件的转轴：灯笼挂在提灯手臂上，手臂抬起灯笼跟着走，同时灯笼还能绕握点自己摆。
4. 唯一可能「偏」的是**转轴放错**（比如肩膀的转轴放在手肘，手臂转起来会像脱臼）。所以转轴 Claude 已经量好（见 2.3），
   并且有检查工具把动画按游戏的同一套计算画出来，拆完先看预览再进游戏。

### 2.2 部件

| 文件 | 部件 | 包含 | 父部件 | z（叠放顺序） |
|---|---|---|---|---|
| `rig_smoke.png` | 烟 | 袍子下摆外面飘的紫色烟（只要烟，不要袍子） | 无 | 0（最后面） |
| `rig_body.png` | 身体 | 袍子、腰带、胸前链子、脚——去掉头/兜帽、两只手臂、灯笼之后剩下的全部，**被挡住的地方补画** | 无 | 1 |
| `rig_arm_free.png` | 空手 | 画面右边那只手臂：从肩膀到手套，连同垂下来的袖子 | body | 2 |
| `rig_head.png` | 头 | 兜帽、面具、兜帽边缘垂下的布 | body | 3 |
| `rig_arm_lantern.png` | 提灯手臂 | 画面左边举着的手臂：从肩膀到握链子的手套，**连同从手臂垂到大约 y=365 的长袖子** | body | 4 |
| `rig_lantern.png` | 灯笼 | 灯笼和链子（不含手套） | arm_lantern | 5（最前面） |

同一个像素只能属于一个部件（重叠处按「前面的部件优先」：灯笼 > 提灯手臂 > 头 > 空手 > 身体 > 烟），补画的部分除外。

### 2.3 转轴（Claude 按网格量好的，`docs/screenshots/claude-rig-guide.png` 上有十字标记）

| 部件 | 转轴（原图坐标） | 位置 |
|---|---|---|
| smoke | (260, 640) | 烟的中下部 |
| body | (300, 690) | 两脚之间 |
| arm_free | (318, 158) | 右边肩膀（袖子根） |
| head | (212, 165) | 兜帽下面的脖子 |
| arm_lantern | (165, 165) | 左边肩膀 |
| lantern | (106, 110) | 手套握住链子的地方 |

只有在抠完以后明显不在关节上（例如肩膀实际在 (170,158)）时才微调，偏差不超过 10 像素，并在报告里写明改了什么。

### 2.4 必须补画（否则动起来露洞）

拆开后被手臂、头挡住的地方是空的。`docs/screenshots/claude-rig-holes-example.png` 是**没补画**时动作最大幅度的样子（品红 = 露出来的洞）：
肩膀处、手臂后面的袍子、提灯袖子后面、兜帽后面的领口都会露洞。要用局部重绘把这些地方补成袍子/领口，风格、颜色、描边与原图一致：

- **身体**：两只手臂和袖子后面的袍子、肩膀、兜帽下面的领口和脖子，补的范围比被挡处多出 15~20 像素；
- **手臂、头**：在肩膀、脖子处多留 10~15 像素圆润的接口（转动时盖住接缝）；
- 部件边缘干净（1~2 像素柔边，不要白边黑边），四角透明。

### 2.5 描述文件 `mod/TowerMaster/art/rig_master.json`

```json
{
  "canvas": [512, 768],
  "parts": [
    { "name": "smoke",       "file": "rig_smoke.png",       "pivot": [260, 640], "z": 0, "parent": null },
    { "name": "body",        "file": "rig_body.png",        "pivot": [300, 690], "z": 1, "parent": null },
    { "name": "arm_free",    "file": "rig_arm_free.png",    "pivot": [318, 158], "z": 2, "parent": "body" },
    { "name": "head",        "file": "rig_head.png",        "pivot": [212, 165], "z": 3, "parent": "body" },
    { "name": "arm_lantern", "file": "rig_arm_lantern.png", "pivot": [165, 165], "z": 4, "parent": "body" },
    { "name": "lantern",     "file": "rig_lantern.png",     "pivot": [106, 110], "z": 5, "parent": "arm_lantern" }
  ]
}
```

动作关键帧在 `mod/TowerMaster/art/rig_anims.json`（Claude 维护，游戏和检查工具共用，不要改）。

### 2.6 检查工具（进游戏之前必须先过）

```
python testing/rig/check_rig.py
```

输出在 `testing/rig/out/`（不提交）：

| 输出 | 通过标准 |
|---|---|
| 终端「部件检查」 | ✓（尺寸 512×768、四角透明、父部件和 z 顺序正确） |
| 终端「叠回去和原图」+ `composite_diff.png` | ✓（明显不同的像素 < 3%，亮的地方只能是补画区） |
| `pivots.png` | 红十字落在肩膀、脖子、握点、两脚之间 |
| `anim_idle/cast/point/bury.gif` | 动作连贯，手臂绕肩膀转、灯笼跟着手走，没有部件飘走 |
| `holes_cast/point/bury.png`（品红底，动作最大幅度） | 人物轮廓**里面**没有品红（外轮廓边上一两个像素的毛边可以） |

`docs/screenshots/claude-rig-cast-frames.png` 是 Claude 用粗糙试拆跑出来的举灯动作（证明拼法和转轴没问题；正式部件补画后不会有缝）。

**进游戏验收**：日志「塔主动画：骨架搭好（6 个部件）」；待机在呼吸摆动；出牌、埋陷阱动作完整，和预览一致。

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
