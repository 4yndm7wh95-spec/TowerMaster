# 交接记录

## 第二次会话（2026-10-05，云端环境）：规则核心库

云端容器里**没有游戏本体，也没有 `decompiled/`、`tools/`**（被 .gitignore 排除），所以第 1 步的联机实测做不了。这次先做了不依赖游戏的部分：把设计文档里的规则写成纯 C# 库，加单元测试。mod 本体以后直接引用它。

### 新增
- `mod/TowerMaster.sln`（.NET 8 SDK：`cd mod && dotnet test`，目前 37 个测试全过）
  - `TowerMaster.Core/TowerMasterConfig.cs`：所有可调数值，默认值即设计文档第一版。JSON 读写（snake_case，允许注释，没写的字段保留默认值）。
  - `TowerMaster.Core/PriceBook.cs`：读 `data/price_book.json`。
  - `TowerMaster.Core/SummonRules.cs`：召唤阶段校验和报价——标准开销、群体税、普通/精英/Boss 房花费上限、场上数量与同名上限、开局保护、陷阱数量与费用、超时回退、候选 Boss。
  - `TowerMaster.Core/Economy.cs`（`SummonWallet`）：召唤点收入结算（基础×人数系数、节约、战果、击倒奖励及连续击倒规则）、储蓄上限、换幕截断。
  - `TowerMaster.Core/ThreatSession.cs`：一场战斗的威胁点发放与价目表、各项次数限制、力量累计上限（威胁点 + 陷阱合并）。
- `scripts/build_tables.py` 现在顺带生成 `data/price_book.json`（每幕可召唤的怪物、召唤价、原版遭遇组合和标准开销）。重跑结果与 CSV 一致（Linux 下只有换行符不同，别提交那种改动）。
- 设计文档已换成用户上传的新版（新增「每幕开头公开 2 个候选 Boss」「未完成事项与开发建议」等）。

### 规则细节里我自己定的地方（设计文档没写，需要确认）
- **普通房只能召唤本幕「普通」怪**；怪物召唤出来的小怪（扭动虫、炸弹等，`role=Summon`）不单卖。
- **精英房**：塔主选本幕任一精英遭遇，价格 = 它的标准开销；遭遇本体算 1 个单位，另加小怪从 +1 起收群体税；「小怪 ≤ 4 点」含群体税；总价 ≤ 原房间标准开销 × 1.5。
- **Boss 房**：候选 Boss 第 1 个是游戏本来为这一幕选好的 Boss（超时按它出场），另 1 个用种子随机从本幕其他 Boss 里抽。另加小怪同样从 +1 起收税。Boss 房没有节约奖励。
- **场上数量上限只约束塔主的召唤**：原版组合（超时回退）不受限。例：密林「一大群史莱姆」4 只，1 对 1 时上限 3，塔主自己摆不出这一组。
- 陷阱费用不算进单场花费上限，也不影响节约奖励。
- 连续击倒：上一场被击倒的玩家这一场再被击倒不给奖励（连续三场也只有第一场给）。
- 单只加力量超上限时**拒绝且不扣点**；陷阱给的力量自动截断到上限；全体加力量跳过已到上限的怪，全满时拒绝。
- 回血量 = 最大生命 × 10% 向下取整，至少 1；人数系数乘完向下取整（第二幕 2 人 5×1.25=6）。

### 测试 1a 的 mod（`mod/TowerMaster/`，已写好，待本机实测）
- **做什么**：所有普通房间（遭遇类名以 Normal/Weak 结尾）在 `CombatRoom.StartCombat` 执行前，把房间里的遭遇换成 `towermaster.test.json` 里本幕的固定遭遇（密林 NibbitsNormal、暗港 CultistsNormal、蜂巢 MytesNormal、荣耀 AxebotsNormal）。两边按同一份文件替换，**不需要联机消息**，只检验「替换后是否同步」。
- **全用反射**：按名字找类和方法，不写死命名空间。只有入口 `[ModInitializer]` 是按 GAME 条件编译的猜测写法。
- **探针**：启动时把 HANDOFF 记的类和方法在当前版本里的签名写进 mod 目录的 `TowerMaster.log`，`ModelDb`、`INetAction`、`INetMessage`、`ModInitializerAttribute` 会列出全部成员。缺什么会写 WARN。
- **云端验证**：`mod/FakeSts2` 是按 HANDOFF 结构仿造的假 `sts2` 程序集，`mod/TowerMaster.Tests` 用真 Harmony 把补丁打上去跑了一遍（3 个测试通过）。**真游戏的结构可能不同，以探针日志为准。**
- **编译安装**：`cd mod && dotnet build TowerMaster -p:GameDir="<游戏目录>" -p:Install=true`。
  - 会复制到 `<游戏目录>\mods\TowerMaster`；mod 目录不对就加 `-p:ModsDir=...`。
  - `TowerMaster.json`（manifest）是猜的格式，照「IP直连」mod 的 manifest 改。
- **可能要在本机修的地方**（对照 `decompiled/`）：
  1. `ModEntry.cs` 的 `[ModInitializer]` 写法和命名空间。
  2. `Test1FixedEncounter.GetEncounterModel`：猜的是 `ModelDb.Encounter<T>()`，以及可变副本用 `IsMutable`/`ToMutable()`。
  3. 如果怪物不是在 `StartCombat` 里生成的（日志里「生成 …」那行出现在「测试1 #n」之前），就要换挂点，比如 `Act.PullNextEncounter` 的返回值。
- **判定通过**：两台电脑 `TowerMaster.log` 里每场的「已替换」「生成 …」行一致，画面上怪物、血量、意图一致，连打几场不报 `StateDivergence`。

### 下一步（需要在装了游戏的本机做）
1. 第 1 步技术验证，按下面「第 1 步建议的验证顺序」。mod 工程另建 `mod/TowerMaster/`，引用游戏的 `sts2.dll`、GodotSharp、0Harmony 和 `TowerMaster.Core`；目标框架要跟游戏一致（先查 `sts2.dll` 的 TargetFramework，Core 现在是 net8.0，必要时改）。
2. 用 Core 接上：召唤清单广播（自定义 `INetAction`）→ 各客户端 `SummonRules.Quote` 校验 → `SummonWallet.Spend`；战斗结束 `SettleBattle`；候选 Boss 用游戏的种子随机数调 `PickBossCandidates`。
3. 还没做：陷阱牌（第二版）、日志、塔主等级预设、默认配置文件导出。

---

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
