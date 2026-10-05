# 第一步交接记录（2026-10-05）

游戏版本 v0.111.0（release_info.json），主程序集 `data_sts2_windows_x86_64/sts2.dll`。

## 已完成
- `decompiled/sts2.dll`：程序集副本；`decompiled/sts2/`：ilspycmd 11.1 反编译出的工程（3537 个 .cs）。
- `decompiled/pck/localization/{zhs,eng}/{monsters,encounters,powers}.json`：从 .pck 里只读提取的本地化文件。
- `tools/ilspycmd/`：本机没有 .NET SDK，所以从 nuget.org 下载 ilspycmd 包，直接用 .NET 10 运行时运行。
- 脚本（用 `py` 运行）：
  - `scripts/extract_monsters.py`：从代码里读出血量、招式、意图、遭遇组成和各幕遭遇列表，生成 `data/extracted.json`。
  - `scripts/monster_curated.py`：人工核对的数据，包括前 3 回合伤害、有效血量修正和机制分，每项附理由。
  - `scripts/build_tables.py`：生成 `monsters.csv`、`encounters.csv`、`prices.csv`、`encounter_costs.csv`，并做系数校准。
- 校准结果：幕系数 0.218 / 0.192 / 0.176（含群体税），校准目标是普通遭遇平均标准开销 = 1.2 × 基础收入。
- 精英系数 2.35：只用幕系数时，第一幕精英只有 4–8 点，达不到设计的 10–12，所以精英怪再乘这个系数。原版多怪精英组内不收群体税。
- 校准后精英平均：第一幕 11、第二幕 13.7、第三幕 18。

## 与 design.md 不一致的地方
- 鬼祟珊瑚群每回合最多掉 20 血，不是 15。
- 第一幕有两个版本：密林 Overgrowth 和暗港 Underdocks。
- 原版联机里怪物攻击打所有玩家（`AttackCommand.FromMonster` → `TargetingAllOpponents`），本来就没有「攻击谁」的选择。

## 第 4 项结论：联机技术验证的方向

**一句话结论：** 「替换敌人组合」好做，「塔主不上场」是真正的难点，但有可行路线。

1. **替换敌人组合（可行，难度低）**
   - 怪物组合在每个客户端上用种子各自算出（`CombatRoom.StartCombat` → `GenerateMonstersWithSlots`），各家结果一致。
   - 做法：塔主在玩家进房前，用 mod 自定义的 `INetAction` 把召唤清单广播出去；各客户端在 `StartCombat` 前打补丁，用这份清单替换 `MonstersWithSlots`。
   - 跨遭遇混搭怪物时，站位槽位（`Slots`/场景）要另做一套通用布局，属于小风险。
2. **塔主回合（可行）**
   - 在 `CombatManager.StartTurn` 的 `RunAutoPrePlayPhase` 之后、`ActionExecutor.Unpause` 之前插入一个所有客户端都等待的阶段。
   - 增益、减益走自定义 `INetAction`，所有客户端都会按同一顺序执行。
   - 20 秒超时必须由房主判定并广播，不能各家本地计时，否则会不同步。
3. **塔主身份（主要风险）**
   - 游戏到处默认「每个连进来的人都是上场的 Player」。
   - 动作必须归属某个 Player；`LocalContext.GetMe` 找不到本地玩家会直接抛异常（64 处调用）；6 个同步器要等所有玩家。
   - 因此**不建议把塔主从 Player 列表里删掉**。建议让塔主仍是 Player，再打以下补丁：
     - **人数缩放只数爬塔玩家**：怪物血量 `Creature.ScaleHpForMultiplayer`，怪物格挡 `MultiplayerScalingModel.ModifyBlockMultiplicative`，能力层数 `PowerModel.GetScaledAmountForMultiplayer`，以及怪物代码里直接用 `Players.Count` 的地方（如知识恶魔、瀑布巨兽的回血）。
     - **战斗中塔主角色不在场**：塔主角色应视为不可选中、不受伤。注意：原版怪物攻击打所有玩家，群体效果也会算到塔主身上。
     - **胜负判定**：现在是 `RunState.Players.All(IsDead)` 才判负（`CreatureCmd.cs:326`），塔主活着就永远不会判负，必须改成只看爬塔玩家。
     - **复活与准备**：战斗结束会给死去的玩家回 1 血（`Player.ReviveBeforeCombatEnd`），要跳过塔主。死去的玩家每回合会被自动标记为「准备结束回合」，塔主也可以借用这个机制。
     - **非战斗环节**：选路、事件、篝火、奖励、宝箱、换幕这些同步器里，替塔主自动投票、自动跳过，并且不给塔主发奖励。
     - **大厅**：最多 4 人正好是 1 名塔主 + 3 名爬塔玩家。加入时会强制分配角色，需要给塔主一个占位角色或在界面上隐藏。
4. **兼容性**
   - 所有人必须装完全相同的 mod：消息类型按名字排序编号，握手时也会比对 mod 列表。
   - 本机游戏目录装了「IP直连」联机 mod，它走 ENet 传输层，可能和本 mod 冲突，需要实测。

**第 1 步建议的验证顺序：**
1. 1 对 1 联机，只把对方的敌人组合替换成固定清单，确认两边一致、不报 StateDivergence。
2. 塔主角色开局移出战斗，同时修好人数缩放和胜负判定。
3. 补上同步器的自动投票。

## 联机代码定位（细节）
- **加入房间**：`Multiplayer.Game.Lobby/StartRunLobby.cs` 中的 `HandleClientLobbyJoinRequestMessage` 和 `TryAddPlayerInFirstAvailableSlot`。
  - slotId 只占 2 bit，最多 4 人。
  - 每个加入者都会自动分到一个角色。
  - 传输层有 Steam 和 ENet（IP 直连）两种。
  - 握手时会比对「影响玩法的 mod 列表」（`PeerVersionInfo`）。
- **开局**：`Nodes/NGame.cs:873` 的 `StartNewMultiplayerRun` 会把大厅里的每个人都建成一个 `Player`。
- **怪物生成**：
  - 遭遇在 `RunManager.cs:768` 由 `Act.PullNextEncounter` 选出。
  - `Rooms/CombatRoom.cs` 的 `StartCombat` 调用 `Encounter.GenerateMonstersWithSlots`，用种子 + 楼层算出组合，所有客户端结果一致。
  - 然后 `CreateCreature` 生成怪物，再走 `CombatManager.SetUpCombat`。
  - 战斗中召唤怪物用 `CreatureCmd.Add`。
- **回合流程**：`Combat/CombatManager.cs` 的 `StartTurn`。
  - 顺序：发能量、抽牌（`SetupPlayerTurn`）→ `RunAutoPrePlayPhase` → `ActionExecutor.Unpause` + `PlayPhase`。
  - **「塔主回合」应插在抽牌之后、Unpause 之前。**
  - 所有人准备结束回合（`SetReadyToEndTurn`）后切到敌方，`ExecuteEnemyTurn` 让怪物按顺序 `TakeTurn`。
  - 已死亡的玩家每回合开始时会被自动标记为「准备结束回合」。
- **同步方式**：由房主中转的确定性锁步（lockstep），并有校验和（`ChecksumTracker`）检测不同步。
  - 客户端发 `RequestEnqueueActionMessage`，房主广播 `ActionEnqueuedMessage`，所有客户端各自执行。
  - 动作必须属于某个 `Player`（`ActionQueueSynchronizer` 里的 `GetPlayer(actionOwnerId)`）。
  - **mod 可以注册自定义 `INetMessage` 和 `INetAction`**（`ReflectionHelper.GetSubtypesInMods`）。类型按名字排序编号，所以所有人的 mod 必须完全一致。
- **mod 加载**：`Modding/ModManager.cs` 自带支持 manifest json、dll/pck、`ModInitializer` 和 Harmony。
- **人数缩放**：
  - 怪物血量 × 人数 × 1.1 / 1.2 / 1.2（第三幕 Boss 1.3），见 `Creature.ScaleHpForMultiplayer` 和 `MultiplayerScalingModel`。
  - 怪物格挡、12 种能力的层数也按人数缩放。
- **「塔主不上场」的主要难点**：
  - `LocalContext.GetMe` 在本地玩家不在玩家列表里时会直接抛异常，共 41 个文件、64 处调用。
  - 选路、事件、篝火、奖励、宝箱、换幕这些同步器都要等所有玩家。
  - **建议方向**：塔主仍作为联机 Player 存在，但战斗中视为不在场。需要打补丁的地方：
    - 人数缩放改为只数爬塔玩家。
    - 各同步器自动替塔主投票或跳过塔主。
    - 战斗开局把塔主的角色移出场。
    - 这条路仍需实测验证。
