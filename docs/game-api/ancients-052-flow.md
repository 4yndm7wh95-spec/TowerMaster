# 先古祝福与黑屏等待链（0.0.52，只读）

游戏 v0.111.0；以下路径均相对 `decompiled/sts2/`，源码不提交。签名文件 `signatures/*.ancients-052.md` 是程序集元数据导出，只有签名、无方法体。继承方法需同时看 NEventLayout / EventModel。

## 选项完成与多人离开

1. `MegaCrit.Sts2.Core.Models.Events/Neow.cs:217`，`protected override IReadOnlyList<EventOption> GenerateInitialOptions()`：普通模式从允许的负面祝福取一个，再从排除冲突后的正面祝福随机取两个，返回三个选项（283–285）。`AllPossibleOptions` 在49行；寻龙尺在 CurseOptions 中。不是固定三件。
2. `MegaCrit.Sts2.Core.Models/AncientEventModel.cs:166`，`GenerateInitialOptionsWrapper()` 保存 GeneratedOptions；182行 `SetInitialEventState()` 构造初始页面。Owner 是各玩家对应的模型所有者。
3. `MegaCrit.Sts2.Core.Nodes.Rooms/NEventRoom.cs:212`，`SetOptions(EventModel)` 将 CurrentOptions 交给布局；完成时替换为 Proceed。229行 `OptionButtonClicked(EventOption,int)` 调用 EventSynchronizer，Proceed 是单独的本地地图动作。
4. `MegaCrit.Sts2.Core.Multiplayer.Game/EventSynchronizer.cs:234`，`ChooseOptionForEvent(Player,int)` 找该玩家的 EventModel，把 `EventOption.Chosen()` 的任务加入 `_pendingOptionTasks`（247）。共享事件先收集投票；非共享古人事件每人独立选择。不能只看本地页面已结束就假定远端完成。
5. `MegaCrit.Sts2.Core.Events/EventOption.cs:120`，`public async Task Chosen()`：先设置 WasChosen，再 await BeforeChosen（127），然后 await OnChosen（129）。共享动画路径为 `NEventRoom.BeforeOptionChosen` → `NEventLayout.BeforeSharedOptionChosen`（315）→ `EventSplitVoteAnimation.TryPlay`（33/50），等待 Tween 完成。
6. `AncientEventModel.cs:238`，`RelicOption(RelicModel,string,string?)` 包装 OnChosen：await `RelicCmd.Obtain`，再 Done（245）。`Done():220` → `EventModel.SetEventFinished(LocString):403` → `SetEventState(LocString,IEnumerable<EventOption>):433`；空选项使 IsFinished=true（449），发 StateChanged（451）。这就是该玩家祝福完成的标记。
7. `MegaCrit.Sts2.Core.Rooms/EventRoom.cs:118`，`OnEventStateChanged(EventModel)`：只有所有玩家古人模型 IsFinished 才 MarkPreFinished 并保存。`NEventRoom.Proceed():283` 开地图并启用旅行，本身没有 await 全员选项任务。实际离开时 `EventRoom.Exit(IRunState?):81` 仍须 await 全部待处理选项任务（83），故页面完成/地图出现和真正离房完成是不同时间点。

## MoveToMapCoordAction 的完整上层等待链

`MegaCrit.Sts2.Core.GameActions/MoveToMapCoordAction.cs:29`，`ExecuteAction()`：地图关闭时 await FadeOut（33）→ EnterMapCoord（34）→ fire-and-forget FadeIn（35）；地图打开时 await `NMapScreen.TravelToMapCoord(MapCoord):730`（39）。后者依次 await MapSplitVoteAnimation.TryPlay（741）、Cmd.Wait（773）、fadeOutTask（782）、EnterMapCoord（783），再启动淡入。

`MegaCrit.Sts2.Core.Runs/RunManager.cs:682`，`EnterMapCoordInternal(MapCoord,AbstractRoom?,bool)` → `EnterMapPointInternal(int,MapPointType,AbstractRoom?,bool):691`：

- 705 await ExitCurrentRooms → `ExitCurrentRoom():941` /949 await 当前 AbstractRoom.Exit。
- 708 StartSync；710 ClearScreens；713 await CombatStateSynchronizer.WaitForSync；717 await SaveRun(null)。
- 736暂停 ActionExecutor，创建房间；747 await EnterRoom（恢复事件战使用742/743）。`EnterRoom():1012` 再 ExitCurrentRooms 后 EnterRoomInternal。
- `EnterRoomInternal(AbstractRoom,bool):954` 中985 await Hook.BeforeRoomEntered，987 await room.Enter。`AbstractRoom.Enter:32` 转 EnterInternal；战斗房 `CombatRoom.EnterInternal:94` → StartCombat（113），其内部等待战斗资源预加载（177）、AfterRoomEntered Hook（200）。
- `RunManager.FadeOut():849` 等待测试委托（856）或 `NTransition.RoomFadeOut():190`；`FadeIn(bool):833` 同理等待 RoomFadeIn（845）。正常动作的最终 FadeIn 不在 ExecuteAction 的 await 链内，但自身停住仍会黑屏。

潜在无限等待点（代码风险，不是已确定根因）：

| 等待 | 完成来源 / 风险 | 文件:行 |
| --- | --- | --- |
| 旧事件退出 | EventSynchronizer.AwaitPendingOptionTasks() → Task.WhenAll，无超时；任一选项中的选牌/动画/钩子任务不结束就不能离房 | EventRoom.cs:83；EventSynchronizer.cs:314/318 |
| 多人房间同步 | WaitForSync() await `_syncCompletionSource.Task`（139）；收到所有大厅成员的玩家同步数据及 RNG 后 CheckSyncCompleted 才完成；断线也重检查，无等待超时 | MegaCrit.Sts2.Core.Multiplayer/CombatStateSynchronizer.cs:128/178 |
| 投票/淡出/淡入 Tween | AwaitFinished(Tween,Node) 等 Finished 或 owner.TreeExiting；Kill 不保证 Finished，owner还在树上时可能留下任务 | MapSplitVoteAnimation.cs:70；EventSplitVoteAnimation.cs:50；NTransition.cs:219/271；Nodes.GodotExtensions/TweenHelper.cs:23/29–43 |
| 事件选牌 / 钩子 | 选项委托可 await CardSelectCmd，等待本地选择或多人选择同步；Hook.BeforeRoomEntered/AfterRoomEntered 可由任意模型返回未完成任务 | EventModel.cs:503；RunManager.cs:985；CombatRoom.cs:200 |
| 存档 / 资源 / 延迟 | SaveRun、LoadRoomCombatAssets、Cmd.Wait、测试转场委托也在链内；需看实际任务状态，不能统称都是事件问题 | RunManager.cs:717/840/856；CombatRoom.cs:177；NMapScreen.cs:773 |

`NEventRoom._ExitTree():142` 取消自身 CTS；SetupLayout（156/170）中的0.2秒等待有取消令牌。它不是 EventRoom.Exit 中等待选项的那个任务。上轮黑屏仍保留旧 NEventRoom，与停在 ExitCurrentRooms 或在 ClearScreens 前的阶段相容，但仅凭节点存在不足以确定是哪条 await。

## 寻龙尺与探寻是否会留下永久等待

`MegaCrit.Sts2.Core.Models.Relics/DowsingRod.cs:20`，`public override async Task AfterObtained()`：22创建 Owner 的 Dowsing；23 await CardPileCmd.Add 到 Deck；随后预览加入。无自定义进房/离房 Hook。

`MegaCrit.Sts2.Core.Models.Cards/Dowsing.cs:48` 构造为 Quest、不能打出；`public override async Task BeforeRoomEntered(AbstractRoom):53`：不在 Deck 或房间栈深度>1直接返回（55–58），仅 Unknown 点计数（61–62），第五次才 await `CardCmd.TransformTo<Abundance>(this)`（68–69）。第一次普通怪房不会变牌，也没有独立 TCS 或离房回调。

`mod/TowerMaster/MasterDeck.cs:106` Replace：111 Deck.Clear(true)，112起从 RunState 移除旧牌。`Entities.Cards/CardPile.cs:132` Clear 是同步 RemoveInternal，silent=true 不发 CardRemoved；`Runs/RunState.cs:268` RemoveCard 同步从 `_allCards` 删除并 Owner=null。以上删除本身没有 await、也不会自动取消一个此前已启动的选项任务。

因此，已完成获取后再移除探寻，没有看到能直接制造永久等待的逻辑；若在 RelicCmd.Obtain / CardPileCmd.Add 的任务尚未完成时更换牌组，仍可能影响其旧引用，需实际任务证据。`Commands/RelicCmd.cs:23/43` 等待 AfterObtained；`CardPileCmd.Add` 的 AfterCardChangedPiles（449）及可选动画（436）也应检查。不能据此断言寻龙尺就是黑屏根因。

## 原版详情的全局状态与 Escape

`MegaCrit.Sts2.Core.Nodes.Screens/NInspectCardScreen.cs:165`，`Open(List<CardModel>,int,bool=false)`：Visible=true、MouseFilter=Stop；194更新 ActiveScreenContext，添加 blocking screen，开启输入；绑定 cancel/pauseAndBack 到 Close。没有设置 Engine.TimeScale、SceneTree.Paused，也没有暂停游戏动作队列。

`Close():204`：禁用按钮/输入、清提示；0.25秒Tween后 Visible=false 并更新 ActiveScreenContext（224–225）；随即移除两个快捷键绑定和 blocking screen（227–229）。检查恢复应等关闭动画结束，不能在同一帧以 Visible 判失败。

`Nodes.CommonUi/NHotkeyManager.cs:145`，`_UnhandledInput(InputEvent)` 对每个匹配动作找最后一个有效绑定，CallDeferred 并 SetInputAsHandled（164–165）。不是广播给所有界面；一个按键若同时映射多个动作仍需看绑定表。详情 `_Input:233` 左右翻页也标记 handled。本轮 Escape 未导致返回菜单或地图，实测恢复正确；没有证据证明 Escape 导致上轮黑屏。

## 下一次黑屏应优先记录

同时读取两端 ActionExecutor 当前动作、EventSynchronizer `_pendingOptionTasks` 各任务 IsCompleted/Status、CombatStateSynchronizer 的 TCS 与已收成员、NTransition 的Tween运行状态/透明度，以及当前房间栈；按以上顺序定位第一条未完成等待。此次只读调研未改游戏或mod代码。

古人布局选项按钮：Nodes.Events/NAncientEventLayout.cs:302 AnimateButtonsIn() 遍历继承的 OptionButtons；该类不重新定义选项执行逻辑，选项刷新与按钮列表来自 NEventLayout，执行入口仍在 NEventRoom.OptionButtonClicked。签名同时导出三者以免遗漏继承。
