# 召唤阶段实测结果（mod 0.0.10）

## 结论与交接

**启动修复通过；本次有记录的召唤、流水、Boss替换和宝箱离开通过。仍有塔主开宝箱获得金币的问题，不能判所有目标全部通过。** 用户最初反馈“所有测试全部通过”，补充后确认“按原版出场没试过”；用户做过读档，但召唤点恢复缺少独立日志证据。其他未能由日志验证的项目分别列出，不用总体反馈替代逐项覆盖。

只负责测试和只读定位，未修改mod代码。本报告覆盖上一轮0.0.9加载失败报告；旧报告及其截图仍可从Git历史查看。本轮版本0.0.10，测试代码HEAD `c63303c`，游戏v0.111.0，分支 `claude/optimistic-rubin-hr3eit`。塔主=NetId100001=房主，爬塔玩家=100002。同机双实例，跨机器网络未验证。用户确认正常退出两端，检查时无游戏进程。

## 构建、安装与启动

- 已拉取分支，安装前确认没有游戏进程。
- dotnet test：Core39、mod29，共68个全部通过，0失败、0跳过。
- 真实GameDir编译安装成功，0警告、0错误；未发生SummonPanel.cs Godot编译错误。
- 安装目录 `C:\Users\kkk\Desktop\slaythespire\Slay the Spire 2\mods\TowerMaster`：manifest version=0.0.10，summon_phase=true，**没有TowerMaster.Core.dll**。
- 两端TowerMaster日志均为本次04:00:52启动新生成，探针全部找到、召唤阶段已启用；两端游戏日志均无ReflectionTypeLoadException或not associated with any mod。
- 本次两端TowerMaster日志没有ERROR。爬塔玩家端有宝箱默认焦点越界保护WARN；游戏日志存在其他ERROR，原文见后文。

```text
[04:01:06.214] INFO 召唤阶段：已挂到 Void MegaCrit.Sts2.Core.Combat.CombatManager.SetUpCombat(CombatState state)
[04:01:06.217] INFO 召唤阶段：已挂到 Task MegaCrit.Sts2.Core.Entities.Players.Player.ReviveBeforeCombatEnd()
[04:01:06.218] INFO 召唤阶段：已启用（塔主 = 房主）
```

## 逐项实测及覆盖

| 项目 | 结论 | 依据/限制 |
| --- | --- | --- |
| 塔主正常加载、新日志 | 通过 | 双端启动日志，无旧加载异常 |
| 普通房选择与实际出怪 | 通过 | SludgeSpinner、CorpseSlug、ThievingHopper与清单一致，双端匹配 |
| 前3场简单怪开局保护 | 部分覆盖 | 日志只有2场标为开局保护的普通战斗，不能确认从新局第1场开始完整测3场；用户总体反馈其余正常 |
| 超上限红字/确认禁用 | 用户反馈通过，未留截图 | 用户表示其余测试无问题；日志没有专门非法点击记录 |
| 30秒超时 | 未确认覆盖 | 没有超时日志，用户未单独确认实际等待到0；不能写通过 |
| 按原版出场 | 未覆盖 | 用户明确“没试过” |
| 精英选择 | 部分通过 | 选择并进房SkulkingColonyElite正常；原遭遇也是SkulkingColonyElite，不能验证“不同精英替换” |
| Boss第二候选/不同Boss | 通过（第二候选序位据用户反馈） | 日志WaterfallGiantBoss→LagavulinMatriarchBoss，实际发生不同Boss替换；日志没有面板候选序位 |
| 召唤点扣费/收入 | 通过 | 下表5场逐场算术和收入公式核对一致 |
| 宝箱领取后离开 | 通过 | 用户确认其他无问题；日志领遗物后进入休息处、精英等，旧阻塞已解除 |
| 塔主不获得宝箱金币 | **不通过** | 用户确认点开宝箱会获得金币；这是开箱自动发钱路径，不是点金币奖励 |
| 存档继续/召唤清单恢复 | 通过 | 用户确认读档做过；两端本地清单找回并再次生成 |
| 召唤点读档恢复 | 未完成独立验证 | 最终账本有18点，但没有“塔主账本：读档”行，也没有读档后再次扣费；保存成功不等于重新恢复余额已验证 |
| 回归：塔主退场、爬塔人数1、自动选路 | 通过 | 4次开局快照塔主0血死亡，爬塔人数1；跟投、换幕行存在 |
| 中文、布局、按钮、遮罩、倒计时、收入提示 | 用户总体反馈通过，截图缺失 | 未逐项给细节，未收到普通/精英面板截图；不宣称已视觉审查 |
| 爬塔玩家等待画面 | 已确认 | 用户：“正常界面”，看不到塔主选怪过程/面板；未反馈额外等待提示 |

**本轮普通房和精英房截图均未收到**，因此docs/screenshots中没有新增面板证据；不能用上一轮加载错误截图代替。

## 召唤点流水

账本第一次初始化在第一幕精英附近，日志SourceFloor=10，并非从新局首房开始记录。初始10点，第一幕上限30，第二幕上限45。以下列“标准开销”是日志打印值；Boss虽然打印7，实际花费0且没有节约收入，符合免费出场，显示含义建议开发者核对。

| 序号/位置 | 类型与选择 | 标准开销 | 入场前余额 | 花费 | 扣后余额 | 收入（基础/节约/战果） | 胜利后余额 | 核算 |
| --- | --- | --- | --- | --- | --- | --- | --- | --- |
| #1 / 第一幕SourceFloor10 | Elite / SkulkingColonyElite | 13 | 10 | 9 | 1 | +6（4/2/0） | 7/30 | 10−9+6=7 |
| #2 / 第一幕SourceFloor11 | Monster / SludgeSpinner，开局保护 | 3 | 7 | 2 | 5 | +4（4/0/0） | 9/30 | 7−2+4=9 |
| #3 / 第一幕SourceFloor12 | Monster / CorpseSlug，开局保护 | 3 | 9 | 2 | 7 | +4（4/0/0） | 11/30 | 9−2+4=11 |
| #4 / 第一幕SourceFloor15 | Boss / LagavulinMatriarchBoss | 7（显示值） | 11 | 0 | 11 | +4（4/0/0） | 15/30 | 11−0+4=15 |
| #5 / 第二幕SourceFloor17 | Monster / ThievingHopper | 6 | 15 | 4 | 11 | +7（5/1/1） | 18/45 | 15−4+7=18 |

收入核对 `mod/TowerMaster.Core/Economy.cs`：节约为(标准−怪物花费)/2向下取整、最多3，Boss不发节约；每掉10血得1战果。#1节约(13−9)/2=2，掉血2不加战果；#2/#3差1向下取整0、掉血0；#5差2得到1、掉血11得到1。未记录击倒收入或超上限作废。换幕余额15不变，上限升到45，最后18与账本文件一致。

```text
[06:52:59.482] INFO 塔主账本：新的一局，召唤点 10
[06:53:15.183] INFO 召唤阶段：确认 SkulkingColonyElite，花费 9，剩余 1
[06:53:25.927] INFO 召唤阶段：战斗收入 +6（基础 4，节约 2，战果 0），召唤点 7/30；玩家掉血 2，击倒 []，有奖励 []
[06:54:39.045] INFO 召唤阶段：确认 LagavulinMatriarchBoss，花费 0，剩余 11
[06:54:55.588] INFO 塔主账本：进入第 2 幕，上限 45
[06:55:21.488] INFO 召唤阶段：战斗收入 +7（基础 5，节约 1，战果 1），召唤点 18/45；玩家掉血 11，击倒 []，有奖励 []
```

## 双端同步与读档证据

去时间戳后，两端收到清单5行完全一致、已替换5行完全一致、普通怪生成4行完全一致（3次首次生成+1次读档重建），开局20行完全一致（4场快照；Boss未输出此快照，不能虚构）。5条房主发送清单只出现在塔主端。实际精英与Boss替换：

```text
[06:53:15.844] INFO 召唤清单 #1：已替换 SkulkingColonyElite → SkulkingColonyElite
[06:54:39.682] INFO 召唤清单 #4：已替换 WaterfallGiantBoss → LagavulinMatriarchBoss
[06:56:19.824] INFO 测试1b #5：从本地文件找回清单（读档？）
[06:56:19.825] INFO 测试1b #5：开始生成，楼层=18
[06:56:19.826] INFO 测试1b #5：生成 [(ThievingHopper:MONSTER.THIEVING_HOPPER, null)]
```

本次两份mod日志启动时间均04:00:52，没出现新的mod进程启动。因此有“游戏存档继续/清单重建”的证据，不是“退出进程后全新加载并恢复钱包”的完整证据。`MasterLedger.For`只在Wallet为空或seed变化时加载本地账本（mod/TowerMaster/MasterLedger.cs:39起）；同进程继续可能仍用内存Wallet。最后本地文件内容摘要：Seed=15584742761026350208，Points=18，ActNo=2，Battles=5，KnockedDown=[]。未提交原始账本。

两端游戏日志StateDivergence命中0；此结论限定同机现有日志，不能写“无任何异常”。

## 宝箱金币问题与修复回归

爬塔玩家日志实际触发保护：

```text
[06:52:27.203] WARN 测试3 宝箱：默认焦点越界（遗物槽 1 个），改用第一个遗物槽
```

两端游戏日志没有上一轮宝箱ArgumentOutOfRangeException或NHandImageCollection Nullable异常。遗物被爬塔玩家领取，随后可继续进房，用户确认旧阻塞解除。**塔主仍能通过点开宝箱获得金币**，与“塔主不领物品”的目标不符。

只读定位（自己的转述，源码路径相对decompiled/sts2）：

- MegaCrit.Sts2.Core.Nodes.Rooms/NTreasureRoom.cs:219–232：开箱先执行房间普通奖励，之后才初始化遗物选择。
- MegaCrit.Sts2.Core.Rooms/TreasureRoom.cs:61–64：DoNormalRewards转到OneOffSynchronizer.DoLocalTreasureRoomRewards。
- MegaCrit.Sts2.Core.Multiplayer.Game/OneOffSynchronizer.cs:93–101：发TreasureChestOpenedMessage并为本地玩家执行奖励；103–110远端按senderId同样执行。
- 同文件113–131：ShouldGenerateTreasure允许后，用玩家Rewards RNG决定金币，再直接await PlayerCmd.GainGold；不是GoldReward/SelectLocalReward领取路径。
- MegaCrit.Sts2.Core.Commands/PlayerCmd.cs:104：`Task GainGold(decimal amount, Player player, bool wasStolenBack=false)`。
- mod/TowerMaster/Test3MasterAutoPilot.cs:41–44当前物品拦截覆盖战斗奖励、购买、删牌、宝箱遗物，没有覆盖这个直接发钱路径。

因此当前选择奖励/遗物拦截无法挡住开箱金币，和用户观察吻合。建议Claude针对塔主的宝箱奖励路径设计一致的跳过，不影响爬塔玩家开箱、RNG、联机消息和继续流程；本机未实施。现有日志没有塔主金币前后数值，不能声称精确获得数量。

## 所有ERROR原文

下列摘录保留本轮两份游戏日志的全部ERROR块（ERROR行及其后附带调用链/诊断，到空行或下一条日志；不提交日志全文）。TowerMaster日志无ERROR。启动连接ID Collision发生在成功进入本轮联机之前；商店悬浮提示重复键发生在游玩期间，用户未反馈阻塞；断线后发送MapDrawingModeChangedMessage发生在结束/返回菜单附近；资源释放ERROR发生在退出时。没有证据把这些都归因于TowerMaster，仍原样交开发者检查。

### 塔主（game-A.log）

本地日志第2143行：

```text
ERROR: 1 RID allocations of type 'N26RendererEnvironmentStorage11EnvironmentE' were leaked at exit.
```

本地日志第2144行：

```text
ERROR: 5 shaders of type CanvasShaderRD were never freed
   at: ~ShaderRD (servers/rendering/renderer_rd/shader_rd.cpp:1044)
```

本地日志第2146行：

```text
ERROR: 30 RID allocations of type 'N10RendererRD16ParticlesStorage9ParticlesE' were leaked at exit.
```

本地日志第2147行：

```text
ERROR: 1 shaders of type ParticlesShaderRD were never freed
   at: ~ShaderRD (servers/rendering/renderer_rd/shader_rd.cpp:1044)
```

本地日志第2149行：

```text
ERROR: 30 RID allocations of type 'N10RendererRD11MeshStorage4MeshE' were leaked at exit.
```

本地日志第2150行：

```text
ERROR: 88 RID allocations of type 'N10RendererRD15MaterialStorage8MaterialE' were leaked at exit.
```

本地日志第2151行：

```text
ERROR: 6 RID allocations of type 'N10RendererRD15MaterialStorage6ShaderE' were leaked at exit.
```

本地日志第2152行：

```text
ERROR: 186 RID allocations of type 'N10RendererRD14TextureStorage7TextureE' were leaked at exit.
```

本地日志第2157行：

```text
ERROR: 390 RID allocations of type 'PN18TextServerAdvanced22ShapedTextDataAdvancedE' were leaked at exit.
```

本地日志第2158行：

```text
ERROR: 10 RID allocations of type 'PN18TextServerAdvanced12FontAdvancedE' were leaked at exit.
```

本地日志第2159行：

```text
ERROR: 8 RID allocations of type 'PN18TextServerAdvanced27FontAdvancedLinkedVariationE' were leaked at exit.
```

本地日志第2162行：

```text
ERROR: 234 resources still in use at exit (run with --verbose for details).
   at: clear (core/io/resource.cpp:795)
```

### 爬塔玩家（game-B.log）

本地日志第200行：

```text
[ERROR] [DirectClient] Handshake rejected: ID Collision (100002)
   at DirectConnectIP.Network.DirectClient.WaitForHandshakeResponse(List`1 bufferedPackets, String endpoint, CancellationToken cancelToken)
   at System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1.AsyncStateMachineBox`1.ExecutionContextCallback(Object s)
   at System.Threading.ExecutionContext.RunInternal(ExecutionContext executionContext, ContextCallback callback, Object state)
   at System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1.AsyncStateMachineBox`1.MoveNext(Thread threadPoolThread)
   at System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1.AsyncStateMachineBox`1.MoveNext()
   at Godot.GodotSynchronizationContext.ExecutePendingContinuations()
   at Godot.Bridge.ScriptManagerBridge.FrameCallback()
```

本地日志第1273行：

```text
ERROR: System.ArgumentException: An item with the same key has already been added. Key: <Control#1645794564085>
   at System.Collections.Generic.Dictionary`2.TryInsert(TKey key, TValue value, InsertionBehavior behavior)
   at MegaCrit.Sts2.Core.Nodes.HoverTips.NHoverTipSet.CreateAndShow(Control owner, IEnumerable`1 hoverTips, HoverTipAlignment alignment)
   at MegaCrit.Sts2.Core.Nodes.HoverTips.NHoverTipSet.CreateAndShow(Control owner, IHoverTip hoverTip, HoverTipAlignment alignment)
   at MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantCardRemoval.CreateHoverTip()
   at MegaCrit.Sts2.Core.Nodes.Screens.Shops.NMerchantSlot.OnFocus()
   at Godot.Callable.<From>g__Trampoline|1_0(Object delegateObj, NativeVariantPtrArgs args, godot_variant& ret)
   at Godot.DelegateUtils.InvokeWithVariantArgs(IntPtr delegateGCHandle, Void* trampoline, godot_variant** args, Int32 argc, godot_variant* outRet)
   at: void Godot.NativeInterop.ExceptionUtils.LogException(System.Exception) (:0)
   C# backtrace (most recent call first):
       [0] void Godot.GD.PushError(string)
       [1] void Godot.NativeInterop.ExceptionUtils.LogException(System.Exception)
       [2] void Godot.DelegateUtils.InvokeWithVariantArgs(nint, System.Void*, Godot.NativeInterop.godot_variant**, int, Godot.NativeInterop.godot_variant*)
```

本地日志第2202行：

```text
[ERROR] Attempted to send message MegaCrit.Sts2.Core.Multiplayer.Messages.Game.Flavor.MapDrawingModeChangedMessage while MegaCrit.Sts2.Core.Multiplayer.NetClientGameService is not connected!
   at MegaCrit.Sts2.Core.Multiplayer.NetClientGameService.SendMessage[T](T message)
   at MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawings.SetDrawingModeLocal(DrawingMode drawingMode)
   at MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapScreen.OnVisibilityChanged()
   at Godot.Callable.<From>g__Trampoline|1_0(Object delegateObj, NativeVariantPtrArgs args, godot_variant& ret)
   at Godot.DelegateUtils.InvokeWithVariantArgs(IntPtr delegateGCHandle, Void* trampoline, godot_variant** args, Int32 argc, godot_variant* outRet)
   at Godot.NativeCalls.godot_icall_1_14(IntPtr method, IntPtr ptr, godot_bool arg1)
   at Godot.CanvasItem.SetVisible(Boolean visible)
   at MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapScreen.Close(Boolean animateOut)
   at MegaCrit.Sts2.Core.Runs.RunManager.ReturnToMainMenuWithError(NetErrorInfo info)
   at System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[TStateMachine](TStateMachine& stateMachine)
   at MegaCrit.Sts2.Core.Runs.RunManager.ReturnToMainMenuWithError(NetErrorInfo info)
   at MegaCrit.Sts2.Core.Runs.RunManager.LocalPlayerDisconnected(NetErrorInfo info)
   at MegaCrit.Sts2.Core.Multiplayer.Game.Lobby.RunLobby.OnDisconnected(NetErrorInfo info)
   at MegaCrit.Sts2.Core.Multiplayer.NetClientGameService.OnDisconnectedFromHost(UInt64 hostNetId, NetErrorInfo info)
   at DirectConnectIP.Network.DirectClient.TriggerDisconnect(NetErrorInfo errorInfo)
   at DirectConnectIP.Network.DirectClient.Update()
   at MegaCrit.Sts2.Core.Multiplayer.NetClientGameService.Update()
   at Godot.Node.InvokeGodotClassMethod(godot_string_name& method, NativeVariantPtrArgs args, godot_variant& ret)
   at Godot.Control.InvokeGodotClassMethod(godot_string_name& method, NativeVariantPtrArgs args, godot_variant& ret)
   at MegaCrit.Sts2.Core.Nodes.NRun.InvokeGodotClassMethod(godot_string_name& method, NativeVariantPtrArgs args, godot_variant& ret)
   at Godot.Bridge.CSharpInstanceBridge.Call(IntPtr godotObjectGCHandle, godot_string_name* method, godot_variant** args, Int32 argCount, godot_variant_call_error* refCallError, godot_variant* ret)
```

本地日志第2245行：

```text
ERROR: 1 RID allocations of type 'N26RendererEnvironmentStorage11EnvironmentE' were leaked at exit.
```

本地日志第2246行：

```text
ERROR: 5 shaders of type CanvasShaderRD were never freed
   at: ~ShaderRD (servers/rendering/renderer_rd/shader_rd.cpp:1044)
```

本地日志第2248行：

```text
ERROR: 15 RID allocations of type 'N10RendererRD16ParticlesStorage9ParticlesE' were leaked at exit.
```

本地日志第2249行：

```text
ERROR: 1 shaders of type ParticlesShaderRD were never freed
   at: ~ShaderRD (servers/rendering/renderer_rd/shader_rd.cpp:1044)
```

本地日志第2251行：

```text
ERROR: 15 RID allocations of type 'N10RendererRD11MeshStorage4MeshE' were leaked at exit.
```

本地日志第2252行：

```text
ERROR: 28 RID allocations of type 'N10RendererRD15MaterialStorage8MaterialE' were leaked at exit.
```

本地日志第2253行：

```text
ERROR: 6 RID allocations of type 'N10RendererRD15MaterialStorage6ShaderE' were leaked at exit.
```

本地日志第2254行：

```text
ERROR: 176 RID allocations of type 'N10RendererRD14TextureStorage7TextureE' were leaked at exit.
```

本地日志第2267行：

```text
ERROR: 248 RID allocations of type 'PN18TextServerAdvanced22ShapedTextDataAdvancedE' were leaked at exit.
```

本地日志第2268行：

```text
ERROR: 8 RID allocations of type 'PN18TextServerAdvanced12FontAdvancedE' were leaked at exit.
```

本地日志第2269行：

```text
ERROR: 3 RID allocations of type 'PN18TextServerAdvanced27FontAdvancedLinkedVariationE' were leaked at exit.
```

本地日志第2272行：

```text
ERROR: 218 resources still in use at exit (run with --verbose for details).
   at: clear (core/io/resource.cpp:795)
```

## 后续

本轮报告已整理；交Claude处理塔主宝箱金币以及评估其他错误。若要宣称完整验收，还需补：按原版出场、超时证据、不同精英替换、从新局首场开始的3场开局保护、全新进程恢复召唤点及普通/精英截图。用户不需要为了提交当前问题继续游玩；未覆盖项目保留在报告中。
