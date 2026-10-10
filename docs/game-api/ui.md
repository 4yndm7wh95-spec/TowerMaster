# 界面接口与只读玩家数据

游戏 v0.111.0；所有源码定位相对 `decompiled/sts2/`。以下是静态调研，示例是自己的短伪代码，不是已经跑过的 mod 实现。节点必须在 Godot 主线程操作，模型改动另走同步动作。完整可见性和参数见 signatures。

## 1. 场景结构

六个指定界面及实例引用的子场景共 29 份节点结构见 [scene-trees.md](scene-trees.md)。每张表包含节点名、根相对路径、Godot 类型或实例引用、脚本路径、锚点、偏移、最小大小、输入过滤等场景显式值。

| 界面类型 | PCK 内路径 | 代码定位 |
| --- | --- | --- |
| NCombatRoom | scenes/rooms/combat_room.tscn | MegaCrit.Sts2.Core.Nodes.Rooms/NCombatRoom.cs:183、202，AssetPaths / Create |
| NMapScreen | scenes/screens/map/map_screen.tscn | MegaCrit.Sts2.Core.Nodes.Screens.Map/NMapScreen.cs:730，TravelToMapCoord |
| NRewardsScreen | scenes/screens/rewards_screen.tscn | 类型完整成员见 Nodes.Screens 表；通过 Overlay 栈管理 |
| NTopBar | scenes/ui/top_bar.tscn | MegaCrit.Sts2.Core.Nodes.CommonUi/NTopBar.cs；其头像 NTopBarPortrait 的实际命名空间是 **MegaCrit.sts2.Core.Nodes.TopBar**，sts2 小写，表文件加 `.case-variant` 后缀避免 Windows 文件覆盖 |
| NCard | scenes/cards/card.tscn | MegaCrit.Sts2.Core.Nodes.Cards/NCard.cs:396、502 |
| NPlayerHand | scenes/combat/player_hand.tscn | MegaCrit.Sts2.Core.Nodes.Combat/NPlayerHand.cs；手牌内部卡节点运行时加入 |

表中空白属性表示场景没有显式声明，不能当作零；真实尺寸还受父容器、继承场景、视口和运行时布局影响。实例内部树另表列出，未合并父场景对实例子节点的覆盖；没有把动画轨道、贴图、材质或资源正文提交。NCombatRoom 的怪物位置还受代码布局影响，见 NCombatRoom.cs:344–381；静态树不是战斗运行时最终截图。

## 2. 窗口、输入与基础控件

### 叠放与关闭

`NOverlayStack : Control` 管理 `IOverlayScreen` 栈；`void Push(IOverlayScreen screen)`（MegaCrit.Sts2.Core.Nodes.Screens.Overlays/NOverlayStack.cs:113）、`void Remove(IOverlayScreen screen)`（144）、`void Clear()`（180）、`IOverlayScreen? Peek()`（235）。Push 将屏幕加入节点树并更新背景遮挡/当前屏幕；Remove 处理栈和焦点。不要仅 QueueFree 节点却留下栈记录。HideOverlays/ShowOverlays（188/194）是暂时隐藏，不等于弹出。

`NModalContainer` 是单个模态容器，不是任意多层栈：`void Add(Node modalToCreate, bool showBackstop=true)`（MegaCrit.Sts2.Core.Nodes.CommonUi/NModalContainer.cs:61）要求节点实现 IScreenContext；已经 OpenModal 时记录 WARN 并拒绝。`void Clear()`（77）释放除 Backstop 外的子节点、清空 OpenModal 并刷新 ActiveScreenContext。ShowBackstop/HideBackstop（91/100）切换 MouseFilter Stop/Ignore 和遮罩透明度。

另有 `NCapstoneContainer.Open(ICapstoneScreen screen)` / `Close()`（MegaCrit.Sts2.Core.Nodes.Screens.Capstones/NCapstoneContainer.cs:116/154），用于牌组等覆盖界面；不要把 Overlay、Modal、Capstone 当同一个容器。`ActiveScreenContext.GetCurrentScreen()`（MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext/ActiveScreenContext.cs:29–125）按反馈、模态、检查界面、主菜单、Capstone、地图、Overlay、房间等优先级挑当前屏幕；`Update()`（24）通知订阅者重新选焦点。

### 输入与按钮

Godot 的 Control GUI 输入结合 MouseFilter 和覆盖节点阻挡鼠标；游戏还用 IScreenContext、ActiveScreenContext、NInputManager、NControllerManager 管理手柄焦点/热键。模态遮罩挡鼠标**不保证屏蔽所有自定义 `_Input` 热键**，新增界面须检查当前屏幕上下文；本轮未实测自定义热键和模态同时开启。

`NClickableControl : Control`（MegaCrit.Sts2.Core.Nodes.GodotExtensions/NClickableControl.cs:13）提供 `Released(NClickableControl button)`、Focused、Unfocused、MousePressed/MouseReleased 信号；`_GuiInput(InputEvent)`（336）接鼠标和 MegaInput.select，OnReleaseHandler（291）在按下后释放时发 Released。Enable/Disable/SetEnabled 控制可用状态；ForceClick 是强制调用，不适合拿来绕过业务禁用。

`NButton : NClickableControl`（同目录/NButton.cs:14）增加点击/悬浮音效和热键；它不是 Godot.Button，也没有统一静态 Create 工厂。最小自定义普通按钮可以创建 NButton、设置 Control 尺寸、添加文字子节点、订阅 Released 后加入父容器；完整美术按钮应实例化相应场景。**派生类 `_Ready` 不能调用 base._Ready**：86–94会抛 InvalidOperationException，应调用受保护 ConnectSignals（96）；GetControllerIconNode（107）可查找 `%HotkeyIcon`。热键注册/卸载见171/184，退出节点树时清理。

### 字体、主题、颜色

原版文字常用 `MegaCrit.Sts2.addons.mega_text.MegaLabel`，`void SetTextAutoSize(string text)`（MegaCrit.Sts2.addons.mega_text/MegaLabel.cs:155）；其主题键见同目录 ThemeConstants.cs。字体走 Godot Theme/主题 override 和场景资源，而不是统一一个全局 Font 字段。`FontManager.GetSubstituteFont(string language, FontType type)`（MegaCrit.Sts2.Core.Localization.Fonts/FontManager.cs:29）与 `ApplyLocaleFontSubstitution(this Control control, FontType fontType, StringName themeFontName)`（FontControlUtils.cs:8）处理中文等语言替代字体，Fonts 及 FontPathSets 签名也已导出。颜色常量见 MegaCrit.Sts2.Core.Helpers/StsColors.cs；实际界面色也可来自场景 Modulate/主题，不能只凭常量推定最终色。

### 悬浮提示与本地化

`NHoverTipSet.CreateAndShow(Control owner, IHoverTip hoverTip, HoverTipAlignment alignment=None)` / IEnumerable 重载（MegaCrit.Sts2.Core.Nodes.HoverTips/NHoverTipSet.cs:114/119），`Remove(Control owner)`（377）。在 Focused/鼠标进入时创建，Unfocused/移出/节点退出时 Remove；同 owner 的旧提示会替换。`HoverTip(LocString title, LocString description, Texture2D? icon=null)`（MegaCrit.Sts2.Core.HoverTips/HoverTip.cs:41）或标题 LocString + string 描述（54）；支持由 PowerModel 等构造，完整重载见补充 HoverTips 表。

`LocString(string locTable,string locEntryKey)`（MegaCrit.Sts2.Core.Localization/LocString.cs:9）定位表/键；`GetFormattedText()`（62）解析变量格式，`GetRawText()`（67）拿模板，Add 重载（101起）添加变量。LocManager 管理语言表；仅构造 LocString 不会自动注册缺失键。mod 可以直接使用 Godot.Label.Text 或 MegaLabel.SetTextAutoSize 的普通 string；这绕过翻译表，中文仍需适当字体。未找到一个普遍适用的“纯字符串 LocString”构造重载，不要把文字误当表名。

## 3. 从模型到显示节点的最小路径

| 需求 | 已确认接口和最小步骤 | 边界 |
| --- | --- | --- |
| 一张卡 | `NCard? NCard.Create(CardModel card, ModelVisibility visibility=Visible)`，NCard.cs:502–513；从 NodePool 得节点并赋 Model/Visibility，再加入自己的展示容器 | TestMode 返回 null；Create 不自动变成手牌可出牌控件，交互通常还有 Holder。展示他人手牌应另建节点，不能把已有手牌节点移走 |
| 怪物形象 | `NCreatureVisuals MonsterModel.CreateVisuals()`，MegaCrit.Sts2.Core.Models/MonsterModel.cs:240–256；从 VisualsPath 场景实例化，失败用 fallback | **未找到通用 MonsterModel 头像 Texture2D 接口**。查过 MonsterModel 全成员、Nodes 全文 Portrait/MonsterIcon 和 AtlasResourceLoader；CreateVisuals 是完整角色视觉，不是头像。若一定要圆形头像，可由开发方设计 SubViewport 截取视觉或自有图标，裁剪/动画初始化未验证 |
| 能力小图标 | `Texture2D PowerModel.Icon` / `string PackedIconPath`，PowerModel.cs:100–110；把 Icon 赋给 Godot.TextureRect.Texture 并设置大小即可 | Icon 是 atlas .tres；大图用 BigIcon（112）及 ResolvedBigIconPath（114起）回退逻辑，不要假设原始 png 一定存在 |
| 原版带数量能力节点 | `NPower Create(PowerModel power)`，MegaCrit.Sts2.Core.Nodes.Combat/NPower.cs:109；实例化场景后以真实能力模型初始化 | 战斗中能力模型包含 Owner/Amount 等状态，不能凭规范模板充当已施加能力；纯选择菜单图标优先 TextureRect |

资源设施：`PreloadManager.Cache`（MegaCrit.Sts2.Core.Assets/PreloadManager.cs:23）、`AssetCache.GetScene(string path)` / `GetTexture2D(string path)`（AssetCache.cs:128/133）。GetAsset 的缓存缺失加载走 ResourceLoader，并可能输出 Asset not cached WARN（34–51）；应在正式界面出现前安排预加载或自己的资源加载。模型规范/可变副本用 AbstractModel/ModelDb 表核对；仅显示不要随意修改规范模型。NodePool 生命周期见 Helpers 表，池化 NCard 的回收应遵循原版节点机制，不能假设普通 QueueFree 等同归还池。

短伪代码（纯显示，不改变牌归属）：

```text
从 runState.Players 选择 NetId 对应玩家
读取 player.PlayerCombatState.Hand.Cards
为每张牌调用 NCard.Create(card, Visible)
非 null 的节点加入自己的容器，设置位置和缩放
关闭界面时按游戏节点池机制移除这些展示节点
```

## 4. 所有玩家的当前数据

入口 `RunManager.Instance.State`，具体形状见 Runs 表；`RunState.Players : IReadOnlyList<Player>`（MegaCrit.Sts2.Core.Runs/RunState.cs:39）。**以 Player.NetId 对齐联机身份**，不能用窗口名或列表索引推定塔主。状态同步后的模型包含所有玩家的数据，读取他人手牌无需改 LocalContext.GetMe。

| 数据 | 路径/类型 | 源码定位 |
| --- | --- | --- |
| 手/抽/弃/消耗牌 | `player.PlayerCombatState.Hand / DrawPile / DiscardPile / ExhaustPile` → `CardPile.Cards : IReadOnlyList<CardModel>` | MegaCrit.Sts2.Core.Entities.Players/PlayerCombatState.cs:47–53；MegaCrit.Sts2.Core.Entities.Cards/CardPile.cs:22 |
| 整副永久牌组 | `player.Deck.Cards` | Player.cs:137 |
| 血量 | `player.Creature.CurrentHp / MaxHp`；int | Player.cs:46；MegaCrit.Sts2.Core.Entities.Creatures/Creature.cs:60/81 |
| 当前能量 | `player.PlayerCombatState.Energy` | PlayerCombatState.cs:71；最大能量 Player.MaxEnergy，Player.cs:139 |
| 金币 | `player.Gold`；int | Player.cs:92 |
| 遗物 | `player.Relics : IReadOnlyList<RelicModel>` | Player.cs:80 |
| 药水与空槽 | `player.PotionSlots : IReadOnlyList<PotionModel?>`；Potions 仅非空项 | Player.cs:82/84 |

PlayerCombatState 战斗外可能 null（Player.cs:76）；死亡/战斗结束时节点可能移除，先检查模型与当前房间。牌堆顺序就是当前模型顺序；读取不会消费 RNG。可订阅 Creature.CurrentHpChanged/MaxHpChanged（Creature.cs:281/283）、Player.GoldChanged/RelicObtained/RelicRemoved（Player.cs:165–179）刷新；牌堆/能量事件完整签名见对应表。UI 本地读取不改变状态，但跨端显示应等同一同步阶段，不能以未同步的加载中状态作为游戏决策。

## 5. 可参考的调试界面

`NDevConsole : Panel`（MegaCrit.Sts2.Core.Nodes.Debug/NDevConsole.cs:22）；`static CanvasLayer? Create()`（158）从缓存场景创建，TestMode 返回 null；进入树限制单实例。它展示原版 CanvasLayer、输入框、日志输出、开关输入和命令提交的组织方式，不保证发行版任意上下文都允许启用。

业务命令层在 MegaCrit.Sts2.Core.DevConsole/ 与 MegaCrit.Sts2.Core.DevConsole.ConsoleCommands/，如 ActConsoleCmd.cs:50 的幕生成调用；这些命令会改变游戏，不是此次调研要执行的接口。更多现成测试/调试节点可在 signatures 的 Nodes.Debug、Nodes.Debug.Multiplayer 等实际文件中查找（以索引为准）；未实际打开游戏调试面板测试。开发自定义界面应参考 Overlay/Modal 结构，并明确只读显示与同步操作的边界。
