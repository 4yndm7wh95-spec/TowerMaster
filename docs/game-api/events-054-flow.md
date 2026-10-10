# 普通事件镜像：0.0.55 只读调研

对象：游戏 v0.111.0，模组 6ba6645。以下文件路径以本地只读反编译目录 `decompiled/sts2/` 为根；源码未提交。签名见 `signatures/*.events-054.md`。场景只在内存读取，未导出场景或原版贴图。

## 1. 共享与独立事件

`MegaCrit.Sts2.Core.Models/EventModel.cs:54,62`：`LocTable` 默认 events，`IsShared` 默认 false。直接继承 EventModel 的普通事件扫描结果：

|共享事件|声明位置|
|---|---|
|BattlewornDummy|`MegaCrit.Sts2.Core.Models.Events/BattlewornDummy.cs:28`|
|DenseVegetation|`MegaCrit.Sts2.Core.Models.Events/DenseVegetation.cs:26`|
|FakeMerchant|`MegaCrit.Sts2.Core.Models.Events/FakeMerchant.cs:63`|
|JungleMazeAdventure|`MegaCrit.Sts2.Core.Models.Events/JungleMazeAdventure.cs:31`|
|MorphicGrove|`MegaCrit.Sts2.Core.Models.Events/MorphicGrove.cs:20`|
|PunchOff|`MegaCrit.Sts2.Core.Models.Events/PunchOff.cs:35`|
|TheLanternKey|`MegaCrit.Sts2.Core.Models.Events/TheLanternKey.cs:20`|
|WarHistorianRepy|`MegaCrit.Sts2.Core.Models.Events/WarHistorianRepy.cs:16`|

其余直接继承 EventModel 的事件（IsShared=false）：AbyssalBaths, Amalgamator, AromaOfChaos, BrainLeech, Bugslayer, ByrdonisNest, ColorfulPhilosophers, ColossalFlower, CrystalSphere, DeprecatedEvent, DollRoom, DoorsOfLightAndDark, DrowningBeacon, EndlessConveyor, FieldOfManSizedHoles, GraveOfTheForgotten, HungryForMushrooms, InfestedAutomaton, LostWisp, LuminousChoir, PotionCourier, RanwidTheElder, Reflections, RelicTrader, RoomFullOfCheese, RoundTeaParty, SapphireSeed, SelfHelpBook, SlipperyBridge, SpiralingWhirlpool, SpiritGrafter, StoneOfAllTime, SunkenStatue, SunkenTreasury, Symbiote, TabletOfTruth, TeaMaster, TheArchitect, TheFutureOfPotions, TheLegendsWereTrue, ThisOrThat, TinkerTime, TrashHeap, Trial, UnrestSite, WaterloggedScriptorium, WelcomeToWongos, Wellspring, WhisperingHollow, WoodCarvings, ZenWeaver。古人继承 AncientEventModel，未混入此列表。

`MegaCrit.Sts2.Core.Multiplayer.Game/EventSynchronizer.cs:75` 的 `void BeginEvent(EventModel, bool, Action<EventModel>?)` 在每个客户端为每名玩家 `ToMutable()`，再 `BeginEvent(player, synchronizer, isPrefinished)`。并非只在自己的机器生成自己一份。

`EventModel.cs:189–201` 的 `Task BeginEvent(Player, EventCombatSynchronizer?, bool)` 初始化 Owner、随机流、动态变量，再生成选项；非共享的种子包括玩家 slot。`EventSynchronizer.cs:194` 的 `void ChooseLocalOption(int)`：非共享先本地执行，再发 OptionIndexChosenMessage（index + Event 选项类型 + 网络 location），远端按 senderId 找到该玩家的事件副本，再执行同一索引（:175–187）。共享走 pageIndex 投票，由房主挑定投票结果，广播 SharedEventOptionChosenMessage，所有玩家执行该索引（:136、222）。

**镜像风险**：同一玩家的选项顺序、数量和执行副本须在两端完全相同。只在 A 的画面换文字或回调，而 B 仍执行原版索引，会不同步。共享事件不能仅替换塔主一份：共享索引对所有玩家有效，应先跳过这 8 种或另行设计同步协议。

## 2. 自己的选项与本地化

`MegaCrit.Sts2.Core.Events/EventOption.cs:46`：构造函数 `EventOption(EventModel, Func<Task>?, LocString title, LocString description, string textKey, IEnumerable<IHoverTip>)` 可明确给标题、说明；:59 的字符串构造从 model.GetOptionTitle/GetOptionDescription 读取。:120 `Task Chosen()` 先 BeforeChosen，再 await OnChosen。

`MegaCrit.Sts2.Core.Localization/LocString.cs:9`：`LocString(string locTable, string locEntryKey)`；:51/60 检查 GetTable(table).HasEntry(key)，:68 用 SmartFormat 格式化。不是直接把中文塞入 key。

默认标题来自 events 表 `<MODEL_ID>.title`，初页正文 `<MODEL_ID>.pages.INITIAL.description`（EventModel.cs:54–58）；选项 `<MODEL_ID>.pages.<PAGE>.options.<OPTION>.title/description`（:179–186、491–498）。使用独立前缀如 TOWER_MASTER_CASINO，显式 new LocString("events", key)，给 events 表补对应条目。`MasterRelics.cs:118,150–165` 已示范 GetTable 后置补表：按表名筛选，ConditionalWeakTable 保证每个表对象只合并一次，Dictionary<string,string> → MergeWith。`LocTable.cs:23` 的 `void MergeWith(Dictionary<string,string>)` 可复用；应覆盖语言切换后新建表，不污染原版 key。

## 3. 多页与完成

`EventModel.cs:433`：`protected virtual void SetEventState(LocString description, IEnumerable<EventOption> eventOptions)` 更换 CurrentOptions、Description，发 StateChanged；无选项会设置 finished。:403 `protected void SetEventFinished(LocString)` 使用空选项，设置 IsFinished 并 EnsureCleanup。可传自己表中的 LocString，支持自己的结果页。

`MegaCrit.Sts2.Core.Models.Events/AbyssalBaths.cs:43–56` 的 `Task Immerse()` 在效果完成后 SetEventState 换第二页；:64–86 Linger 再换页；:94 的 `Task ExitBaths()` 调 SetEventFinished。不要把“先显示下一页”误当作“整个事件完成”，也不要在已经 finished 的模型上再 SetEventState。

## 4. 配图、标题与挂点

`EventModel.cs:161,294`：路径 events/<id_lower>.png，`Texture2D CreateInitialPortrait()` 从预加载缓存取图；该方法非 virtual。`MegaCrit.Sts2.Core.Nodes.Events/NEventLayout.cs:129` 获取 `%Portrait`（TextureRect）、`%Title`、`%EventDescription`；:160 `SetEvent(EventModel)` → :167 InitializeVisuals → :201 `SetPortrait(Texture2D, Texture2D?)`。

`MegaCrit.Sts2.Core.Nodes.Rooms/NEventRoom.cs:166–171`：Layout.SetEvent → SetTitle(_event.Title) → SetDescription。:190 public `SetPortrait(Texture2D)`，标题通过 Layout.SetTitle(string)（NEventLayout.cs:234）即可本地改。**仅本机显示**可在房间初始化结束、确认 local player 是塔主后替换 portrait/title，保留 B 的画面；这不会替代上面所需的两端事件逻辑同步。重绘 Description/StateChanged 后要防止被覆盖，离房恢复/清理粒子。

默认场景 `scenes/events/default_event_layout.tscn:24–41` 的 Portrait：Size **2560×1200，32:15**；offset 左-1280、上-556、右1280、下644，scale 1.04，pivot(1280,600)，KeepAspectCovered。逻辑根视口 **1920×1080**，测试截图输出 **1707×960**。因此原版大配图本就部分出屏；不能把截图边缘裁切误算成资产缺失。

本批插图使用 2560×1200 RGB PNG。预览接口先测试 width=2560/height=1200，再以同纵横比 1280×600 补拍完整构图 GIF；后者用于锚点和克制程度验收，未冒称实际场景节点尺寸。

## 5. 环境动效

`EventModel.cs:169–173,309`：`HasVfx` 查路径存在；`Node2D CreateVfx()` 从 scenes/vfx/events/<id>_vfx 取 PackedScene 并实例化；固定 VfxOffset=(268,49)。NEventLayout.InitializeVisuals (:181–186) → Layout.AddVfxAnchoredToPortrait(node) (:217) → **挂在 Portrait 下**，再赋 VfxOffset，不是 VfxContainer。

只读原版场景数字（未拷贝场景和纹理）。显式设置值列出；未写的 Godot 默认值没有凭记忆补成数字。

|原版例子/节点|数量、寿命|速度/重力|缩放/透明度|发射区（局部）|
|---|---|---|---|---|
|byrdonis_nest feathers|3；11s（:316–320）|初速124.04；重力(0,130,0)（:185–189）|scale .2–.6（:193–194）；透明度曲线需结合材质，不等同固定 alpha|球半径1，shape_scale(100,1,1)（:182–184）|
|byrdonis_nest feathers_foreground|10；15s（:325–329）|重力(0,130,0)（:235）|color alpha .486275（:240）|box extents(1,1,1)×shape_scale(1200,1,1)（:230–232）|
|abyssal_baths water_drop|10；6s（:108–112）|重力(0,98,0)（:38）|scale_max2.5（:41），颜色 ramp|box extents(800,1,1)（:34–35）|
|potion_courier sparkle|2；4s（:399–403）|gravity0，spread180（:86–89）|scale .4–.6（:90–91），颜色 ramp|球半径1×shape_scale(40,20,1)（:81–83）|
|potion_courier idle_specks|30；15s（:477–481）|重力(0,-200,0)（:345）|scale .1–.2；alpha .0392157（:346–349）|box extents(800,1,1)（:343–344）|

上述数字分别属于 `scenes/vfx/events/<id>_vfx.tscn`。本模组数值在 MasterEventAmbience.cs:23–40（速度基准600高；Fit在:59–83按高度缩放）。数量5–10、最大 alpha .18–.35、淡入淡出无硬闪；不能仅比粒子数量就断言视觉强度，粒子贴图大小、alpha、发射范围也影响感知。实际观感和修正建议见 ui-055-result.md。

## 6. 事件战的影响与跳过范围

`EventModel.cs:454,459`：`EnterCombatWithoutExitingEvent(EncounterModel, IReadOnlyList<Reward>, bool)` 仅允许共享；恢复父事件却用 Combat layout 会抛异常。触发 EnteringEventCombat，清 LocalOwnerNode，再 ReadyToEnterCombat。

`EventCombatSynchronizer.cs:76–94` 按玩家 slot 收每人的 encounter、额外奖励、resume 标志；等 **所有成员** 到齐才 EnterCombat (:97)。每个成员的 encounter 与 resume 须一致（:105–116），父 EventModel 不一致会卡住或报错。:127 调 RunManager.EnterRoomWithoutExitingCurrentRoom，CombatRoom.ParentEventId 保留父事件；shouldResume 影响战后返回。

普通事件中实际使用此路径的 5 种：BattlewornDummy（:54/60/66，resume=true）、DenseVegetation（:104,false）、FakeMerchant（:161,false）、PunchOff（:135,false）、TheLanternKey（:54,false）。**镜像首版应明确跳过这些事件，且建议一并跳过全部共享事件**。不能让塔主只获得自己的结果页而未送 ReadyToEnterCombat：B 会永远等塔主。父事件恢复也须保留原版结束顺序。其它原版独立事件仍需要同样两端执行塔主的镜像回调，不能只改 A 的显示。
