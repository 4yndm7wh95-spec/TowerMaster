# 美术资源清单（可选，界面已支持）

放到 `mod/TowerMaster/art/`，文件名必须一致（小写、下划线）。编译安装时自动拷到 `mods/TowerMaster/art/`；界面运行时读取，**缺哪张都能运行**（退回文字）。

## 统一要求（每张都要满足）

- **格式**：PNG，**透明背景**（RGBA）。如果生图工具不能直接出透明图，就让它画在纯白或纯品红（#FF00FF）平底上，再用脚本抠掉背景（边缘留 1–2 像素柔边，不要有白边/色边）。
- **原创**：不要拿游戏自带图片改，也不要要求“照搬杀戮尖塔的某张图”。只参考风格。
- **构图**：单个主体居中，四周留约 8% 空白，**不要文字、不要边框、不要阴影投到画布外**。
- **可读性**：缩到 32×32 时还认得出轮廓。
- 生成后按下表尺寸缩放（高质量缩放），提交到 `mod/TowerMaster/art/`，再按「验收」截图。

**通用风格前缀**（每条 prompt 前面都加上）：

> Hand-painted 2D game icon in the style of a dark-fantasy roguelike deckbuilder (similar mood to Slay the Spire 2): bold dark ink outlines, painterly brush texture, slightly exaggerated chunky shapes, muted deep-blue and charcoal palette with warm antique-gold accents, soft rim light from the upper left, single centered subject, transparent background, no text, no frame, no drop shadow outside the subject, crisp silhouette readable at 32 pixels.

塔主的统一形象（头像、提示条都用它）：一个**高大的兜帽监视者**，深蓝长袍、金色镶边，脸隐在兜帽阴影里，只露出一张**古铜色无表情面具**和两点**琥珀色发光的眼睛**；手里提一盏用铁链挂着的灯笼，灯里是旋转的紫金色符文。气质：冷静、掌控一切、像下棋的人，不是怪物。

## 清单

| 文件名 | 尺寸 | 用在哪里 | 主体 prompt（接在风格前缀后面） |
|---|---|---|---|
| `icon_summon.png` | 128×128 | 召唤面板标题旁 | A glowing summoning circle seen at a slight angle: an antique-gold ring engraved with runes, violet light rising from its center like smoke, two tiny clawed silhouettes emerging from the light. |
| `icon_summon_point.png` | 128×128 | 召唤点数字旁（召唤面板右上角） | A faceted violet soul-crystal set in an antique-gold claw mount, glowing softly from inside, a small rune carved on its face; reads like a currency gem. |
| `icon_threat_point.png` | 128×128 | 威胁点数字旁（塔主回合面板） | A blood-red ember shaped like a narrowed eye, burning inside a small black iron brazier with gold rivets; menacing, compact, symmetrical. |
| `icon_trap.png` | 128×128 | 选陷阱包标题旁 | The back of a face-down card, deep navy with an antique-gold border, centered emblem of a closed iron bear-trap wrapped in a single chain, faint violet glow at the seams. |
| `master_portrait.png` | 256×256 | 塔主回合面板标题、玩家屏幕「塔主行动中」提示 | Bust portrait of the Tower Master: a tall hooded overseer in deep-blue robes with gold trim, face hidden in hood shadow except an expressionless bronze mask with two glowing amber eyes, holding up a chained lantern with swirling violet-gold runes inside; calm, commanding, three-quarter view facing right. |
| `pack_0.png` | 256×256 | 「铁壁包」卡（惩罚连续进攻） | A heavy iron tower shield studded with spikes, a cracked sword bouncing off it with sparks; cold steel-blue and gold. |
| `pack_1.png` | 256×256 | 「拖延包」卡（拖长战斗、消耗玩家） | An ornate gold hourglass half-sunk in dark swamp mud, sand running painfully slow, thin vines creeping up the frame; murky green and gold. |
| `pack_2.png` | 256×256 | 「压迫包」卡（让怪物越打越强） | A monstrous clawed fist gripping a war drum, red veins glowing, the drum skin bulging with power; deep crimson and gold. |
| `trap_harden.png` | 128×128 | 陷阱「硬化」（3 张攻击 → 敌人加格挡） | A stone shield instantly crusting over with crystal armor where three arrows strike it. |
| `trap_exposed.png` | 128×128 | 陷阱「破绽」（4 张攻击 → 该玩家易伤） | A cracked breastplate with a glowing red crack-line target mark, as if an opening was revealed. |
| `trap_brittle.png` | 128×128 | 陷阱「碎甲」（3 张技能 → 该玩家脆弱） | A small round buckler shattering into brittle shards, pale blue fragments flying. |
| `trap_stifle.png` | 128×128 | 陷阱「窒息」（6 张牌 → 该玩家虚弱） | A hand of playing cards being tightly bound by a dark smoky noose, the cards wilting. |
| `trap_rally.png` | 128×128 | 陷阱「鼓舞」（第 3 回合 → 敌人加力量） | A tattered monster war banner on a spear, a glowing red claw emblem, wind-whipped. |
| `trap_frenzy.png` | 128×128 | 陷阱「狂怒」（敌人死亡 → 其余敌人加力量） | A cracked skull with red rage fire bursting out of the eye sockets. |
| `trap_mire.png` | 128×128 | 陷阱「泥沼」（第 2 回合 → 塞眩晕） | A bubbling pool of thick dark-green mud with dizzy spiral swirls rising from it. |
| `trap_mend.png` | 128×128 | 陷阱「再生」（第 4 回合 → 敌人回血） | A writhing green vine stitching a monster wound closed, soft green healing glow. |
| `trap_countdown.png` | 128×128 | 陷阱「倒计时」（第 6 回合 → 敌人大回血） | An iron pocket clock with a skull face, its hand at the last mark, green life-light leaking from the case. |
| `trap_bluff.png` | 128×128 | 空陷阱（诈唬） | An empty iron bear-trap, sprung shut on nothing, a small curl of harmless smoke; a sly feeling. |

## 第二批（0.0.24 新增）

| 文件名 | 尺寸 | 用在哪里 | 主体 prompt（接在风格前缀后面） |
|---|---|---|---|
| `master_figure.png` | 512×768（竖版） | **战斗里站在怪物身后、屏幕最右侧的塔主全身形象**（替代原来那个死掉的英雄） | Full-body standing figure of the Tower Master (same character as master_portrait: tall hooded overseer, deep-blue robes with antique-gold trim, expressionless bronze mask with two glowing amber eyes), facing LEFT toward the battlefield, holding the chained rune-lantern raised in one hand, robe hem fading into wisps of violet smoke at the feet, slightly translucent ghostly presence, imposing but calm; full body visible head to toe with margin, transparent background. |
| `act_block.png` | 128×128 | 塔主行动卡「格挡」 | A thick iron kite shield glowing with a pale-blue protective rune. |
| `act_heal.png` | 128×128 | 行动卡「回血」 | A dark-green monster heart wrapped in healing vines, soft green glow. |
| `act_strength.png` | 128×128 | 行动卡「力量」 | A clenched monstrous claw fist with red veins and a rising red aura. |
| `act_strength_all.png` | 128×128 | 行动卡「全体力量」 | Three monstrous claw fists raised together, red war-aura spreading behind them. |
| `act_weak.png` | 128×128 | 行动卡「虚弱」 | A cracked, drooping sword with its blade wilting like a dead flower, dull grey-green tint. |
| `act_vulnerable.png` | 128×128 | 行动卡「易伤」 | A broken breastplate with a glowing red crosshair over the crack. |
| `act_frail.png` | 128×128 | 行动卡「脆弱」 | A thin wooden buckler splintering apart, pale shards falling. |
| `act_dazed.png` | 128×128 | 行动卡「眩晕」 | A playing card with a dizzy violet spiral on its face, little stars circling it. |

## 验收

1. 文件名、尺寸、透明背景都对（用脚本检查 PNG 有 alpha 通道、四角像素透明）。
2. 安装后打开：召唤面板（右上角召唤点图标、标题图标、陷阱按钮图标）、选陷阱包面板（标题图标、三个包图、每行陷阱小图标）、塔主回合面板（头像、威胁点图标）、爬塔玩家的「塔主行动中」提示条。各截一张图。
3. 小图标在 26–30 像素显示时还认得出；风格彼此统一（同一套线条粗细、配色、光照）。不统一的重画。

## 塔主遗物图标（0.0.45 起，128×128，透明底）

没有图时遗物栏、遗物牌都用塔主头像代替。风格同上；遗物是「塔主的私人物件」，金色/深蓝为主，带一点搞笑感。

| 文件名 | 遗物 | 主体 prompt |
|---|---|---|
| `relic_lucky_cat.png` | 招财猫 | A small porcelain beckoning cat with one paw raised, deep-blue glaze with gold trim, holding a violet soul-crystal coin, a mischievous grin. |
| `relic_piggy_bank.png` | 小金库 | A chubby iron piggy bank with gold rivets and a coin slot glowing violet, a tiny padlock on its side. |
| `relic_magic_hat.png` | 魔术师礼帽 | A tall battered top hat, deep-blue with a gold band, a few playing cards fanning out of it with violet sparkles. |
| `relic_energy_drink.png` | 能量饮料 | A dented metal can with a lightning-bolt rune in gold, violet fizz spilling from the opened tab. |
| `relic_bento.png` | 怪物便当 | A wooden lunch box with the lid half open, inside a slime-green rice ball, a bone and an eyeball; a gold chopstick pair on top. |
| `relic_blacklist.png` | 黑名单 | A rolled black parchment with a red wax seal, a few names crossed out in red ink, a gold quill stuck through it. |
| `relic_fog_censer.png` | 迷雾香炉 | An ornate gold censer on a chain, thick grey-violet fog pouring out and hiding its lower half. |
| `relic_stingy_purse.png` | 吝啬鬼钱包 | A tightly cinched leather coin purse with a gold drawstring tied into an absurd knot, a single coin peeking out. |
