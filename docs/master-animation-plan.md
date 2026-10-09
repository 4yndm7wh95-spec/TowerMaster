# 塔主动作与特效：方案和生图说明（0.0.48）

需求见 `master-animation-vfx-request.md`：埋陷阱要有统一、不泄密的动作和特效；塔主每种出牌要有小幅动作和独立特效；塔主在怪物后面。

## 1. 做法（Claude 的决定）

**不做逐帧角色动画。** 生图工具画十几帧同一个角色，脸、衣褶、金饰每帧都会变，播放时会抖、显得廉价。改成：

1. **姿势换图 + 程序动作**：塔主只画 3 张「关键姿势」（站立已有，再加「举灯施法」「伸手指点」），同一画布、同一位置。
   出牌时：交叉淡入目标姿势（0.08 秒）→ 用补间做小幅动作（前倾 6 像素、放大 3%、灯笼辉光一闪）→ 停 0.25 秒 → 淡回站立。动作小、短、克制。
2. **特效用序列帧**：特效本来就是「变化的光和形状」，逐帧画不怕不一致。每个特效一条 8 帧横向序列图，在目标身上播放（16 帧/秒，0.5 秒）。
3. **分类共用**：同一类动作共用一个姿势，特效按效果区分颜色和形状，玩家一眼看出「给谁、什么效果」。

| 塔主行动 | 姿势 | 特效（落点） | 共用 |
|---|---|---|---|
| 加固、坚壁、怪物便当（格挡） | 举灯施法 | `vfx_ward`：钢蓝色六角护盾从地面升起罩住怪物 | 格挡类共用 |
| 激励、全体激励（力量） | 举灯施法 | `vfx_empower`：暗红色符文从脚下升起、拳形火焰一闪 | 力量类共用 |
| 治疗、全体治疗、请客 | 举灯施法 | `vfx_mend`：绿色藤蔓缠绕上升、叶片散开 | 回复类共用 |
| 荆棘丛 / 金身 | 举灯施法 | `vfx_ward` 换色：荆棘深绿 / 金色 | 复用护盾特效、换色 |
| 易伤、起哄、黑名单 | 伸手指点 | `vfx_mark`：红色裂纹靶心印在玩家身上，碎裂一下 | 易伤类共用 |
| 虚弱、挫敌 | 伸手指点 | `vfx_drain`：紫黑锁链从上方垂下缠一圈后消散 | 虚弱类共用 |
| 脆弱 | 伸手指点 | `vfx_mark` 换色：冰蓝色碎盾 | 复用 |
| 晕眩、黏液大礼包 | 伸手指点 | `vfx_daze`：一张牌形光片飞入玩家身体，带旋转星星 | 塞牌类共用 |
| 摇人 | 举灯施法 | `vfx_summon`：紫色召唤法阵在落点展开 | — |
| 惊喜盲盒 | 举灯施法 | `vfx_gamble`：金色骰子在塔主灯笼前翻滚，落定 | — |
| **埋陷阱（所有陷阱、空陷阱一样）** | 伸手指点（指向地面） | `vfx_bury`：一张背面朝上的暗金牌从塔主手边飞出，插进怪物一侧地面，地面泛起一圈墨色涟漪后合拢 | 所有陷阱同一个，不泄密 |

**埋陷阱为什么不泄密**：只有一种动作、一种特效、一种颜色、一个音效；张数靠「插进去几张」体现（每张间隔 0.2 秒播一次），空陷阱完全一样。

**图层**：塔主姿势图和塔主放在一起（怪物后面）；特效画在目标上方（战斗特效层），不挡手牌和意图（播放 0.5 秒就消失）。

## 2. 先做样例（这一批只生成 5 个，验收风格后再批量）

1. `master_pose_cast.png`（举灯施法）
2. `master_pose_point.png`（伸手指点）
3. `vfx_bury.png`（埋陷阱，8 帧）
4. `vfx_ward.png`（护盾，8 帧）
5. `vfx_mark.png`（靶心印记，8 帧）

## 3. 生图 prompt（每条都自足，可以直接用）

### 3.1 `master_pose_cast.png` — 举灯施法

> **用 `mod/TowerMaster/art/master_figure.png` 作为参考图（图像编辑/保持角色一致）。**
>
> Full-body illustration of the exact same character as the reference image: a tall hooded overseer called the Tower Master. Keep every design detail identical to the reference: deep indigo-blue layered robe with ragged hem dissolving into violet smoke, antique-gold trim with circular rune medallions and crescent-moon symbols, gold chains and hanging diamond pendants across the chest, a wide gold-buckled belt, a bronze expressionless mask with two glowing amber eyes deep inside the hood, dark leather gloves, and an ornate hexagonal gold lantern on a short chain containing swirling magenta-violet runes.
>
> Pose: the same three-quarter view facing LEFT as the reference, same height and same position on the canvas (feet at the same spot near the bottom center). The RIGHT arm (on the viewer's left) is RAISED, holding the lantern up at head height and slightly forward toward the left, as if casting a spell; the lantern glows brighter than in the reference with a soft violet-gold halo. The LEFT hand (viewer's right) is open, palm turned slightly outward at waist height. Body leans forward only a little (about 5 degrees); the head tilts slightly down toward the left. The robe hem and smoke flow slightly backward (to the right) as if from a gentle gust.
>
> Style: hand-painted 2D dark-fantasy game character art matching the reference exactly — bold dark ink outlines, painterly brush texture, muted deep-blue and charcoal with warm antique-gold accents, soft rim light from the upper left. Canvas 512×768 px, fully transparent background (real alpha), no ground, no cast shadow, no text, no frame, no extra characters or props. The figure must occupy the same bounding area as the reference (about x 48–463, y 61–706) so the two images can be cross-faded without the character jumping.

### 3.2 `master_pose_point.png` — 伸手指点

> **用 `master_figure.png` 作为参考图。** Same character, same costume details, same canvas size and placement as in 3.1 (copy the whole first paragraph of 3.1 for the character description).
>
> Pose: three-quarter view facing LEFT. The lantern hangs lower from the RIGHT hand (viewer's left) at hip height, glowing softly. The LEFT arm (viewer's right) is extended forward and slightly across the body toward the LEFT, index finger pointing at something in the distance at chest height — a calm, commanding gesture, not a violent one. A faint violet wisp trails from the fingertip. Shoulders turned a little more toward the viewer than in the reference; the head looks along the pointing arm. Robe and smoke settle downward (no gust).
>
> Style, canvas, transparency and bounding-area requirements identical to 3.1.

### 3.3 `vfx_bury.png` — 埋陷阱（8 帧序列）

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

### 3.4 `vfx_ward.png` — 护盾（8 帧序列）

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

### 3.5 `vfx_mark.png` — 靶心印记（8 帧序列）

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

## 4. 落地规范（给 Claude 写代码 / 给助手验收）

- 文件放 `mod/TowerMaster/art/`，名字如上。姿势图 512×768；特效 2048×256（8 × 256）。
- 验收：透明底（四角 alpha 0）；姿势图和 `master_figure.png` 叠在一起交替显示时人物不跳位（脚的位置、头的位置偏差 < 8 像素）；特效每帧的中心和地面线一致。
- 播放：姿势淡入 0.08 秒 → 停 0.25 秒 → 淡回 0.2 秒；特效 16 帧/秒播一次，最后一帧后删除；连续出牌时姿势不重复叠加（正在播就重新计时），特效各自独立播放。
- 埋陷阱：每盖一张播一次 `vfx_bury`，落点是怪物一侧地面上随机偏移（±60 像素，各端用同一个种子），间隔 0.2 秒。
- 生成后先只提交这 5 个样例，截图给用户看风格，再批量做表里其余特效（`vfx_empower`、`vfx_mend`、`vfx_drain`、`vfx_daze`、`vfx_summon`、`vfx_gamble`）。
