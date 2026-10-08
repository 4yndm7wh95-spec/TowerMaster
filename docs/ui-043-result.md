# 0.0.43 验收与身份/遗物/事件调研

2026-10-08；分支 `claude/optimistic-rubin-hr3eit`，代码 `c3fe834`。测试 A=100001 房主/塔主，B=100002 爬塔。仅测试和只读调查，未改 mod 代码，不作平衡结论。

## 安装与范围

实际 109 个测试通过（49+60），编译 0 warning / 0 error，安装 manifest=0.0.43，两端共用安装目录。配置从仓库覆盖，SHA256 `CE7D223D1626984CFD04F2F8E54D0CF4819EC3B6BDEB2B783F4866E23D169301`，master_cards=true。两个测试 profile 的 liuchuan is_enabled=false。未操作用户自己的游戏进程；测试实例已退出。

0.0.42 在用户切换任务前已编译测试安装并验证三轮面板重开；其完整验收合并到本报告，不把未完成部分算通过。0.0.43 先重启新局，第一局种子 104433756492959035（Underdocks），四场普通胜利后经历事件、篝火、宝箱、读档；重启读档后发生不同步。另开种子 3839936519011496069（Overgrowth），三场正常胜利，商店后第四场用原版网络控制台 `damage 999 1` 杀死 B，以验收结算。没有 room/fight/win；没有给 B 加能量或抽牌。

首次重启连接曾因 DirectConnectIP 共用配置导致 A 也读成 B=100002，握手 ID Collision；重启测试实例并在建房前更新 A、加入前更新 B 后正常。它和后面的 StateDivergence 是不同问题。

## 逐项结论

|项目|结论|证据/限制|
|---|---|---|
|开战隐藏塔主英雄|采样通过|三场两端连续截图未见塔主英雄；不是逐帧录像，不能证明所有渲染帧|
|战后塔主满血|通过|多场 tm_state 为 80/80，后续事件/篝火/商店可处理|
|战后无回血特效|不通过|胜利采样仍有两个绿色 6，其中一个出现在隐藏塔主位置；燃烧之血仍调用 Heal|
|信息条位置/可见性|不通过|两端矩形 y=1086..1145，在 1080 高逻辑视口外|
|信息条陷阱计数数据|通过|3→2 手里，盖下1，泥沼触发1；下一场清0，两端一致|
|真实悬停显示陷阱名|未覆盖|面板在屏幕外，无法实际悬停；内部名称泥沼存在|
|Boss 名称与进入 Boss 房候选对照|未覆盖|内部为乐加维林族母/瀑布巨兽；本轮未进 Boss 房，未验证候选面板|
|同进程/完全重启信息数据恢复|部分通过|手里2恢复，时间约2.4/3.9秒；屏幕外显示未修，冷启动后宝箱奖励编号不同步|
|战报 API 三种 won / show / close|通过|两端结构数据一致，截图可见，可关闭|
|真实结局自动战报|通过|原版结算出现后约1.1~1.3秒两端弹出，点看原版结算回原版|
|面板 Close→Show 3轮|通过|无已释放按钮/process_frame错误；确认召唤可正常进入战斗|
|普通战回归|通过局部|第一局4场胜利，第二局3场胜利；塔主激励、泥沼、奖励覆盖|
|无 StateDivergence|不通过|宝箱冷读档→篝火→下一战，奖励计数器差1导致一次不同步断线|

## 1. 开战及战后连续截图

每场进房前启动截图线程，确认召唤的同时交替抓 A/B 10 组；第一次观察到战斗结束后抓 A/B 8 组。包含加载黑屏、战斗开始、手牌动画、胜利动画。MCP 截图是串行采样而非每帧录像，可能漏掉很短的闪现；通过结论仅限已采样帧。

- 第1场：[A 开战](screenshots/ui043-battle1-start-9-A.png)、[B 开战](screenshots/ui043-battle1-start-9-B.png)
- 第2场：[A 开战](screenshots/ui043-battle2-start-9-A.png)、[B 开战](screenshots/ui043-battle2-start-9-B.png)
- 第3场：[A 开战](screenshots/ui043-battle3-start-9-A.png)、[B 开战](screenshots/ui043-battle3-start-9-B.png)
- 全部序列：ui043-battle{1,2,3}-start-{0..9}-{A,B}、victory-{0..7}-{A,B}。

三场采样中只有 B 的铁甲英雄，右侧为塔主自定义立绘，没有第二个原版英雄。B 仍位于原多人阵型中的一个位置，不见新的明显异常偏移；未以原版单人截图量化空位距离。

**回血残留**：[第1场 A 胜利瞬间](screenshots/ui043-battle1-victory-0-A.png) 有两处绿色 6，B 旁一处，原塔主位置一处；B 端对应序列可复查。满血写回不能阻止另一个原版遗物钩子再播 Heal。只读定位 `decompiled/sts2/MegaCrit.Sts2.Core.Models.Relics/BurningBlood.cs:16` 的 `Task AfterCombatVictory(CombatRoom _)`：Owner 不死就 Flash，并 await CreatureCmd.Heal(Owner.Creature, 6)。这与隐藏塔主已写满血但仍有绿色数字吻合；不能断言所有角色遗物均如此。

第一局前3场战后塔主均80/80，第四场之后事件、篝火也未走死亡提示。第二局商店可离开。原版 generic event death ERROR 在保留日志中没有出现。

## 2. 信息条越界与内部内容

**稳定可复现的位置错误**：两端信息条全局矩形 `(1535,1086)`、大小 `(367,59)`、结束 `(1902,1145)`；逻辑视口1920×1080。MasterInfoHud.Tick 用 `_bar.Size.Y + 6` 作 y，NTopBar 的节点尺寸是整屏高度，不是屏上约80像素的顶栏带高度。因此 UI 被放在屏幕下方；两端节点 Text/Visible 有值，截图不可见。只读位置 `mod/TowerMaster/MasterInfoHud.cs:118` 附近 Tick 的 Position 计算；建议 Claude 按实际顶栏内容或固定锚点计算，而非整屏 Control.Size。未做临时位移兜底，也未改代码。

各场景都已两端截图，均不显示信息条，故不能以“不遮挡”冒充位置验收通过：

|场景|A|B|
|---|---|---|
|地图|[A](screenshots/ui043-map-second-A.png)|[B](screenshots/ui043-map-second-B.png)|
|战斗|[A](screenshots/ui043-trap-trigger-A.png)|[B](screenshots/ui043-trap-trigger-B.png)|
|商店|[A](screenshots/ui043-shop-A.png)|[B](screenshots/ui043-shop-B.png)|
|原版牌组|[A](screenshots/ui043-deck-A.png)|[B](screenshots/ui043-deck-B.png)|
|召唤面板|[A](screenshots/ui043-summon-A.png)|[B](screenshots/ui043-summon-B.png)|

计数：第一局挑硬化、泥沼、空陷阱，手里3；前三场没盖，本场盖下0/已触发0。第4场盖泥沼，tm_traps.hand=2，信息 Text手里2/本场盖下1/已触发0；第2回合泥沼触发后已触发1，Triggered=[泥沼]，tm_traps.fired_count=1。两端一致。冷读档后下一场塔主端已清为盖下0/触发0；B随后因奖励编号不同步退出，不能给它的下一场显示算通过。

同进程回菜单读档手里2恢复：最后采样约2.41秒（从两端点击准备结束后计时）；完全退出两个进程重开读档约3.87秒。开始可能为-1/“?”，随后牌组重发恢复。内部牌组/战报记录保留；实际屏幕上的恢复仍不通过。截图：[同进程 A/B](screenshots/ui043-load-same-A.png)、[冷启动 A](screenshots/ui043-load-cold-A.png)、[冷启动 B](screenshots/ui043-load-cold-B.png)。本幕 Boss 内部显示乐加维林族母/瀑布巨兽，未实际走到Boss房。

## 3. 战报

第一局4场、召唤5只蟾蜍蝌蚪、泥沼1次、塔主激励1张，与操作对应，Boss=[]（没有进Boss）。tm_master_report 不给 won、won=true、won=false 各一次，两端返回的全部字段相同。show=true 能打开，close=true 能关。不给 won 时，尚未结束且 B 活着，会显示“爬塔者获胜”，这是当前 API 自动判断“爬塔者未全灭”的行为，不代表提前产生真实胜利结算。

[默认战报 A](screenshots/ui043-report-auto-A.png)、[强制塔主胜 A](screenshots/ui043-report-won-A.png)、[强制爬塔胜 A](screenshots/ui043-report-lost-A.png)，对应 B 图均同前缀。

第二局正常胜利3场，第四场塔主先手结束后，先查 Creatures 确认 B 在 index1，使用原版联机控制台 **damage 999 1** 杀死 B；不是自然死亡，不用它推导平衡。原版 NGameOverScreen 约0.25秒首次被观察到，A战报约1.32秒、B约1.58秒（均从控制台请求返回附近计时）；相对于原版结算出现约1.1~1.3秒，符合1.2秒计时器。标题为塔主获胜！，真实称号为佛系塔主（第二局没出塔主牌、没触发陷阱），不要把标题和称号混为一项。

- [A 自动战报](screenshots/ui043-gameover-report-A.png) / [B 自动战报](screenshots/ui043-gameover-report-B.png)
- 点击原按钮“看原版结算”后：[A原版](screenshots/ui043-gameover-original-A.png) / [B原版](screenshots/ui043-gameover-original-B.png)
- 第二局战报：4场、4只树叶史莱姆（小）、0陷阱、0塔主牌，两端一致。

## 4. 面板重开

对 `type:TowerMaster.SummonPhase|_openUi` Close→等0.25秒→Show→等0.5秒，连续3轮成功。最后正常选怪确认，战斗正常结束；原版筛选建成并正常使用（0.0.42阶段另有费用1按钮回调验证）。没有上轮 disposed Godot.Button 或 process_frame nonexistent connection 异常。0.0.43正常选择后进战也成功。本轮没另外把缩小甲虫独立取景放大检查，记未覆盖，不能声称细线已消失。

## 5. 不同步：冷读宝箱导致奖励计数器不同

**复现路径（第一局）**：前三场普通胜利→两个事件→第4场盖泥沼并胜利→篝火跳过删牌、B休息→同进程回菜单读档→宝箱塔主跳过选牌，B开箱选遗物并继续→保存回菜单、关闭A/B→重开多人读档恢复宝箱→下一格篝火，塔主跳过删牌、B休息→B投票普通战(3,10)。校验发生在离开篝火，B被退回主菜单。没有回合中途 win，也没连发B出牌。

原文：

```text
[ERROR] State divergence detected! Checksum with ID 0 for client 100002 doesn't match host's!
Context: Exiting rest site room. Local: 4212498652. Remote: 3346932100.
```

A/B状态dump逐行比较，实质差异只有：

```text
A: Choice IDs: 1
A: Reward IDs: 1,2
B: Choice IDs: 1
B: Reward IDs: 0,1
```

其余玩家血量/牌组/遗物、RNG计数和状态一致。奖励组日志摘录：

```text
A [DEBUG] [RewardsSetSynchronizer] Beginning rewards set Id: 0 Owner: 100001 Rewards:
A [DEBUG] [RewardsSetSynchronizer] Beginning rewards set Id: 0 Owner: 100002 Rewards:
A [DEBUG] [RewardsSetSynchronizer] Beginning rewards set Id: 1 Owner: 100002 Rewards:
B [DEBUG] [RewardsSetSynchronizer] Beginning rewards set Id: 0 Owner: 100002 Rewards:
```

只读推断：塔主读档恢复宝箱后自动开箱，A额外建立奖励组，B恢复已开宝箱没有走同样过程。需 Claude 对照 NTreasureRoom 恢复/开箱及 Test3MasterAutoPilot.AfterTreasureRoomReady；本轮仅一次复现，不能称已证明每种存档都必现。

动作摘要：冷启动阶段A有5条、B3条，共同前3条完全一致；B断开后缺少A的 trap_info / begin。**没有找到断开前一条同编号、不同内容的摘要**，因为摘要不记录原版奖励编号计数器；不能把共同摘要一致当作原版checksum一致。重新开的第二局18/18摘要逐行一致。

保留日志内StateDivergence有一次实际事件：A两条ERROR（比较不匹配、收到差异消息），B一条ERROR（收到差异消息）及断线原因。按文本出现次数计数会包含消息类型/堆栈，故这里报告实际事件1次，不把多行堆栈当多次故障。

**日志保留限制**：首次冷重启前的0.0.43四场原始日志被启动器覆盖，截图、状态JSON和战报仍保存。本报告全部逐行摘要/ERROR统计针对冷重启后的保留日志；不能宣称重启前全日志零异常。已在这次不同步出现时立即复制日志到工作目录，此后未覆盖，未提交全文。

## 6. 日志摘录

以下为保留的0.0.43冷启动到第二局结算两端所有“塔主信息条”“塔主战报”“悄悄复活塔主”“写回塔主生命失败”行，以及所有TowerMaster ERROR/WARN。写回失败0、战报生成失败0。第一进程日志已覆盖的限制见上节。

### A

```text
[08:52:45.847] INFO 塔主形象：战后悄悄复活塔主（不播回血特效），已挂到 Task MegaCrit.Sts2.Core.Entities.Players.Player.ReviveBeforeCombatEnd()
[08:52:45.921] INFO 塔主战报：已挂到原版结算画面
[08:53:05.818] INFO 塔主信息条：挂到原版顶栏下方
[09:09:52.712] INFO 塔主信息条：挂到原版顶栏下方
[09:17:56.572] INFO 塔主战报：塔主赢，4 场，召唤 4，陷阱 0，出牌 0
```

### B

```text
[08:52:45.714] INFO 塔主形象：战后悄悄复活塔主（不播回血特效），已挂到 Task MegaCrit.Sts2.Core.Entities.Players.Player.ReviveBeforeCombatEnd()
[08:52:45.777] INFO 塔主战报：已挂到原版结算画面
[08:53:05.684] INFO 塔主信息条：挂到原版顶栏下方
[08:56:09.934] WARN 测试接口 /reflect：System.ArgumentException: Array was not a one-dimensional array.
   at System.Array.GetValue(Int32 index)
   at TowerMaster.TestBridge.Resolve(String target)
   at TowerMaster.TestBridge.Reflect(JsonObject a)
   at TowerMaster.TestBridge.<>c__DisplayClass17_0.<<OnMainThread>b__0>d.MoveNext()
--- End of stack trace from previous location ---
   at TowerMaster.TestBridge.Route(String method, String path, String token, String body)
[09:09:52.718] INFO 塔主信息条：挂到原版顶栏下方
[09:17:56.810] INFO 塔主战报：塔主赢，4 场，召唤 4，陷阱 0，出牌 0
```

B唯一TowerMaster WARN来自测试助手尝试用一维索引读取二维 Map.Grid，路径使用错误；改成 GetPoint(int,int) 后读取成功。它不是游戏自然流程异常。A ERROR/WARN=0/0；B=0/1。原版游戏的 StateDivergence ERROR 已单列，不能因为 mod ERROR=0 就说无报错。

## 7. 只读调研：大厅、身份、遗物、事件

以下文件/行号基于本地 v0.111.0 `decompiled/sts2/`。不提交这些源码文件；只提交成员签名、位置和文字描述。运行时造遗物方案是只读推断，未实施新遗物。

### 7.1 大厅选择/准备/开局

|类/方法签名|文件:行号|关键顺序|
|---|---|---|
|NCharacterSelectScreen.SelectCharacter(NCharacterSelectButton, CharacterModel)|MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect/NCharacterSelectScreen.cs:647|设置所选按钮、角色背景/标题/遗物等，再把选择交给lobby；应区别本地角色UI和联机模型状态|
|StartRunLobby.SetLocalCharacter(CharacterModel)|MegaCrit.Sts2.Core.Multiplayer.Game.Lobby/StartRunLobby.cs:593|ChangeCharacter(NetId,character)，发送LobbyPlayerChangedCharacterMessage，再更新单人进阶|
|StartRunLobby.ChangeCharacter(ulong, CharacterModel, bool=false)|同文件:389|修改对应StartRunLobbyPlayer.character，再通知LobbyListener.PlayerChanged|
|NCharacterSelectScreen.OnEmbarkPressed(NButton)|NCharacterSelectScreen.cs:485|检查转场延迟，lobby.SetReady(true)，进入等待准备UI|
|StartRunLobby.SetReady(bool)|StartRunLobby.cs:642|本地isReady改写并发LobbyPlayerSetReadyMessage，调用BeginRunForAllPlayersIfAllReady|
|StartRunLobby.BeginRunForAllPlayersIfAllReady()|同文件:667|全员ready时房主启动；IsAboutToBeginGame:688/698 检查所有玩家准备|
|StartRunLobby.BeginRunForAllPlayers(string,List<ModifierModel>)|同文件:406|房主发LobbyBeginRunMessage（含玩家列表、角色、seed、act1），再本地启动|
|StartRunLobby.BeginRunLocally(string,List<ModifierModel>)|同文件:434|按种子选幕/解析随机角色、缓冲消息、LobbyListener.BeginRun（465）|
|NGame.StartNewMultiplayerRun(StartRunLobby,bool,IReadOnlyList<ActModel>,IReadOnlyList<ModifierModel>,string,int,DateTimeOffset?=null)|MegaCrit.Sts2.Core.Nodes/NGame.cs:871|873 从lobby.Players逐个Player.CreateForNewRun(p.character,UnlockState.FromSerializable(...),p.id)，然后RunState.CreateForNewRun|

远端图标：`NCharacterSelectScreen.PlayerChanged(StartRunLobbyPlayer,bool)` 784 → `RefreshButtonSelectionForPlayer(StartRunLobbyPlayer)` 795 → 对每个角色按钮 `OnRemotePlayerSelected(ulong)` / Deselected。`NCharacterSelectButton.cs:351` 添加远端ID并RefreshState；`RefreshPlayerIcons()` :459 根据远端选择名单画图标。不要只遮房主窗口的按钮，B看到的角色标记也需特殊处理。

**最小改法建议**：房主大厅初始化后，通过原版SetLocalCharacter固定一个已解锁、非Random角色，保持原版有效character和ready流程；房主本地SelectCharacter入口拒绝更换，并覆盖本地背景/角色说明为塔主。远端RefreshButtonSelectionForPlayer针对房主ID跳过普通角色选中标记，远端玩家栏显示塔主图标。防止准备/随机解析重新覆盖后台固定角色。不要把character设null或删房主Player；原版建RunState、存档、动画预加载都依赖它。若客户端伪造房主选角消息，还需在lobby处理消息处约束，UI遮罩本身不是联机状态保证。

### 7.2 跑图身份露出（两端实际截图）

|位置|本轮事实|原版节点/代码|
|---|---|---|
|篝火|两端房间截图；A被删牌3选1遮罩部分覆盖，不能看清全部围坐角色；此部分视觉确认不完整|NRestSiteRoom / NRestSiteCharacter；Rooms/NRestSiteRoom.cs:220 为所有runState.Players逐个Create(player,index)|
|商店|两端均有两个铁甲角色，塔主后台角色明确仍露出|NMerchantRoom / NMerchantCharacter；Rooms/NMerchantRoom.cs:188 从每个player.Character.MerchantAnimPath实例化|
|宝箱|两端截图；A选牌覆盖，画面未见明确玩家英雄主体，但不能泛化所有宝箱场景|NTreasureRoom / NTreasureRoomRelicCollection；Rooms/NTreasureRoom.cs:121 Create(TreasureRoom,IRunState)|
|问号事件|两端DefaultEventLayout事件图，不是角色战斗立绘；顶栏仍铁甲头像|NEventRoom / NEventLayout / NEventOptionButton；Rooms/NEventRoom.cs:156 SetupLayout|
|先古之民|两端截图仍原版祝福选项，标题/对话依赖Owner.Character；顶栏仍铁甲|NAncientEventLayout / NAncientDialogueLine；Events/NAncientEventLayout.cs:251 Create(line,event,Owner.Character)|
|地图玩家标记|地图截图已收集，但静态图没有投票中的塔主标记，实际投票图标未覆盖|NMapScreen.PlayerVoteDictionary:346、OnPlayerVoteChangedInternal（约690）；各MapPoint vote UI须按Player身份处理|
|顶栏头像/名字|A仍铁甲头像；B左上列表塔主项隐藏，自己的B名字可见|NTopBarPortraitTip/NTopBarPortrait；NMultiplayerPlayerState._Ready :251 用Player.Character.IconTexture|
|结算|关战报后两端原版画面可见两位铁甲（站立/倒地），塔主身份仍不独立|NGameOverScreen + 房间角色节点；Screens.GameOverScreen/NGameOverScreen.cs:403 保存localPlayer；战斗场景原有角色会被结算恢复|
|跑图历史|两端都显示两个铁甲图标和铁甲死亡文本；塔主牌名出现但缩略图为缺失图标，需要另跟进|NRunHistory / NRunHistoryPlayerIcon；Screens.RunHistoryScreen/NRunHistoryPlayerIcon.cs:98 LoadRun，101从RunHistoryPlayer.Character取角色；NRunHistory.cs:350 DisplayRun|

截图：ui043-rest-A/B、treasure-A/B、event-A/B、ancient-A/B、shop-A/B、map-second-A/B、deck-A/B、gameover-original-A/B、history-A/B。上述“未清楚”项目不算已隐藏，通过当前截图应优先修商店、顶栏、结算、历史。

### 7.3 真遗物的运行时子类

- 类型：`MegaCrit.Sts2.Core.Models.RelicModel : AbstractModel`。RelicModel文件未声明显式构造函数，使用隐式无参构造，调用基类 `protected AbstractModel()`（AbstractModel.cs:49）；基类从真实类型ModelDb.GetId获取ID并拒绝重复canonical实例。因此不要自行反复new已登记类型，走ModelDb canonical→ToMutable。
- 必须重写 `public abstract RelicRarity Rarity { get; }`（RelicModel.cs:168）。`ShouldReceiveCombatHooks` 在RelicModel :388 已实现true，不必再重写；所需效果可重写AbstractModel继承的Hook或RelicModel.AfterObtained/AfterRemoved。
- 建议重写 `Title` :44（可选，自定义LocString），`PackedIconPath` :126、`protected PackedIconOutlinePath` :128、`protected BigIconPath` :130；Icon/IconOutline用ResourceLoader，BigIcon走PreloadManager.Cache。路径存在并不保证大图已预载，需处理缓存或沿当前卡图桥接。
- `CanonicalVars` :275 可按效果重写；`Task AfterObtained()` :500 默认实现；描述来自 relics 表的 `<ENTRY>.description`，标题`.title`，Flavor `.flavor`（:67）。参照MasterCards.PatchLoc :493，改为relics表稳定merge，包含动态变量而非把数字硬写多处。
- **重要差异：`RelicModel.Pool` :170 是非virtual**，从ModelDb.AllRelicPools找包含Id的第一个池。不能照CardModel.get_Pool动态override。若不给某池收录，调用Pool可能First抛异常；应设计塔主专属RelicPoolModel，或明确拦截该非virtual getter。RelicPoolModel.cs:37 的 `protected abstract IEnumerable<RelicModel> GenerateAllRelics()` 需实现；AllRelics/AllRelicIds分别 :20/:33 缓存。新池只注入类型不代表进入ModelDb.AllRelicPools（ModelDb.cs:190由角色池和固定shared池组成）。
- 稀有度 `RelicRarity` 值 None/Starter/Common/Uncommon/Rare/Shop/Event/Ancient（Entities.Relics/RelicRarity.cs:3）。Rarity.Event/Ancient不自动隔离随机抽取，真正生成范围来自遗物池/GrabBag；应避免塔主遗物进玩家普通池。ModelDb.AllRelics :186 由池+角色开局遗物聚合，也影响图鉴/统计。
- 命令 `public static async Task<T> RelicCmd.Obtain<T>(Player) where T:RelicModel`（Commands/RelicCmd.cs:16）；`public static async Task<RelicModel> Obtain(RelicModel,Player,int index=-1)` :21。它要求mutable，先记历史→player.AddRelicInternal→非stackable从GrabBag移除→本机AnimateRelic/音效/MarkRelicAsSeen→FloorAddedToDeck→await AfterObtained。**该方法自己不广播网络消息**，模组应发送稳定遗物ID/玩家ID指令，在所有客户端同一顺序await Obtain；仅在房主调用会不同步。
- UI `NRelicInventory.Initialize(RunState)`（Nodes.Relics/NRelicInventory.cs:125）绑定LocalContext.GetMe，订阅RelicObtained/Removed（:137），`Add(RelicModel,bool,int=-1)` :167 创建 `NRelicInventoryHolder.Create`，holder里的NRelic显示Icon/Outline/提示；原版栏只显示本机玩家。塔主的真遗物会自然出现在A原版栏，无需另画假图标，但对方查看需要另外的身份展示入口。
- 对照 `mod/TowerMaster/MasterCards.cs:150..210`：可复用Reflection.Emit动态程序集/子类、公开无参构造、ModAssociation.Associate、ReflectionHelper.ModTypes扩展。遗物构造没有CardModel五参数；只需调用实际可访问无参基构造。必须实现Rarity并按需求override图标/变量/效果，不要用所有抽象成员返回默认值掩盖未来版本变化。
- `ModelDb.Init(Type[]? injectedModelTypes=null)` :329 / `Inject(Type)` :340 按Type造canonical入字典；`InitIds()` :362 依赖ModelIdSerializationCache。两端类型集和排序必须完全一致，尽量沿当前ModTypes在原版初始化前登记。若晚Inject，需重新审计网络ID cache，不推断仅Inject就足够。
- 风险：存档必须先登记相同类型/ID再反序列化；代码改名/删除会破坏旧存档。图鉴/成就/历史会访问池、图标、Loc和Character统计，拿自定义遗物时MarkRelicAsSeen也会进入原版进度。专属遗物应明确是否进入图鉴，不要污染普通随机池；大图/Outline、本地化/可变owner缺一都可能在UI正常游戏时出错。未实际造新Relic测试，以上可行性为源码推断。

### 7.4 事件与先古之民

|入口/签名|文件:行号|顺序|
|---|---|---|
|EventRoom.EnterInternal(IRunState?,bool)|Rooms/EventRoom.cs:47|先预载事件资源→EventSynchronizer.BeginEvent→订阅事件状态→取localEvent→必要时生成事件内战斗→NEventRoom.Create/SetCurrentRoom→await Hook.AfterRoomEntered→await AfterEventStarted|
|EventSynchronizer.BeginEvent(EventModel,bool=false,Action<EventModel>?=null)|Multiplayer.Game/EventSynchronizer.cs:72|清旧事件/票/任务，每个Player各复制一个mutable事件，BeginEvent(player,...)，不是一个事件Owner共享所有玩家|
|EventModel.BeginEvent(Player,EventCombatSynchronizer?,bool)|Models/EventModel.cs:189|设置Owner/Rng→await BeforeEventStarted→CalculateVars→若Owner死触发generic death，否则生成初始选项。死分支 :206左右|
|NEventRoom.Create(EventModel,IRunState?,bool)|Nodes.Rooms/NEventRoom.cs:106|创建当前本机事件节点；SetupLayout() :156 绑定事件、标题、说明、古人对话、SetOptions|
|NEventRoom.OptionButtonClicked(EventOption,int)|同文件:229|Proceed直接运行option.Chosen；其余ChooseLocalOption；非共享先清按钮|
|EventSynchronizer.ChooseLocalOption(int)|EventSynchronizer.cs:191|共享发VotedForSharedEventOptionMessage（页号/选项/位置）；非共享发OptionIndexChosenMessage并只执行当前玩家事件|
|PlayerVotedForSharedOptionIndex(Player,uint,uint)|同文件:117|按playerSlot存票，全部HasValue且房主才ChooseSharedEventOption|
|ChooseSharedEventOption()|同文件:140|房主从票中用专用RNG选择，广播SharedEventOptionChosenMessage；所有端ChooseOptionForSharedEvent(uint) :219 执行每位玩家同选项并换页|
|EventSplitVoteAnimation.TryPlay(NEventOptionButton)|Nodes.Events/EventSplitVoteAnimation.cs:33|多个不同按钮有票才播放选择动画；不是网络决策入口，只展示投票结果|

先古之民是 `AncientEventModel : EventModel`，LocTable=ancients (:34)，LayoutType=Ancient (:96)，`abstract IEnumerable<EventOption> AllPossibleOptions` :120，生成祝福选项由具体古人模型负责。NEventRoom.SetupLayout :175 使用Owner.Character/访问次数选对白；NAncientEventLayout :251 将Character交给NAncientDialogueLine；祝福仍走原版EventOption.Chosen/遗物或牌命令，不是另外一套网络系统。

当前塔主仍是原版Player，所以**共享事件原版确实会等塔主票**。现有mod `Test3MasterAutoPilot.AfterSharedEventVote`（mod/TowerMaster/Test3MasterAutopilot.cs:325）在B投某页后，房主用ChooseLocalOption投同项；后续镜像事件应保留或明确替代此行为，否则B可被卡住。非共享每人独立Owner，B完成后塔主自动地图跟随能离开；本轮两个问号事件正常离开，未遇到共享投票事件，不能把共享跟投算本轮实测通过。先古之民本轮A仍能看到/手选原版祝福，不能当作已实现塔主专属祝福。

**镜像选择挂点建议（只读方案）**：按EventRoom.EnterInternal / Hook.AfterRoomEntered确认房间与种子后，在本机塔主UI创建独立面板；最好等NEventRoom.SetupLayout完成再弹，避免原版节点/转场覆盖。将身份判断限定本机塔主，数据结果经模组联机指令在两端提交，使用独立RNG流。不要替换EventSynchronizer._events或让独立面板选项混进原版共享页号；保留B的原版事件和塔主必要的原版跟投/完成。镜像是否必须等塔主提交后才能换房要设计明确：若必须等，单独房间完成标记与确定性同步屏障；若不等，离房前提交/自动跳过，防止UI晚回调修改新房。存档按seed+act+coord记录已选，读档不要重复派奖；本轮奖励ID不同步说明不要借原版RewardsSet作为仅房主的独立选择计数器。

## 未覆盖/证据限制

- Boss房真实候选对照和Boss战报非空列表；本轮没有打到Boss。
- 信息条因越界无法真实悬停；地图投票中塔主标记未抓到，篝火/宝箱A截图有覆盖层，不推断全部英雄已隐藏。
- 开战所有帧不能用串行截图证明；回血残留已有正向截图所以明确不通过。
- 首次冷重启前日志被覆盖，不能给出整轮无异常结论；保留冷启动后的明确不同步已原文记录。
- 只读遗物方案未实施；没有提交源码/游戏资源/原始日志。截图含游戏画面，是用户指定测试证据。
