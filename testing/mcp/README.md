# TowerMaster 测试助手接口（阶段 A）

本机双实例自动测试用。分两层：

1. **游戏内测试接口**（`mod/TowerMaster/TestBridge.cs`）：mod 读到环境变量 `TOWERMASTER_BRIDGE_PORT` 才启动，只监听 `127.0.0.1`。
   设了 `TOWERMASTER_BRIDGE_TOKEN` 时每个请求都要带 `X-Token` 头。日志「测试接口：已在 127.0.0.1:端口 监听」。
   所有游戏操作都在 Godot 主线程执行，单个请求最多等 20 秒（超时返回 `timeout`）。
2. **MCP 服务**（`towermaster_mcp.py`，只用 Python 标准库）：把两个实例的接口包装成 MCP 工具，另外提供等待、日志对比、测速和一键跑一场。

正常游戏（不设端口）完全不开接口。

## 启动

1. `scripts/local-test/launch-instance-A.cmd`、`launch-instance-B.cmd` 现在默认分别开 47101、47102 端口，
   并设置 `TOWERMASTER_INSTANCE`、`TOWERMASTER_GAME_LOG`、截图目录 `scripts/local-test/screenshots-A|B`。
   `-BridgePort 0` 关闭接口。要令牌就先设 `TOWERMASTER_BRIDGE_TOKEN` 再启动，MCP 那边设同一个值。
2. 端口不同时复制 `instances.example.json` 为 `instances.json`（不提交）改端口。
3. 在测试助手里注册 MCP 服务，例如 Codex 的 `~/.codex/config.toml`：

   ```toml
   [mcp_servers.towermaster]
   command = "python"
   args = ["C:\\Users\\kkk\\Desktop\\tower-master-mod\\testing\\mcp\\towermaster_mcp.py"]
   ```

   也可以不走 MCP，直接命令行：`python towermaster_mcp.py call tm_instances`、
   `python towermaster_mcp.py call tm_battle "{\"point_type\":\"Monster\",\"monsters\":[\"Nibbit\"]}"`。

**身份以 `tm_instances` 返回的 `net_id`、`is_host` 为准**（塔主 = 房主 = 100001），不要按端口或窗口猜。

## 工具

| 工具 | 作用 |
|---|---|
| tm_instances | 各实例连接、NetId、是否房主、mod 版本、日志路径 |
| tm_state | 种子、幕、楼层、坐标、房间类型、玩家血量金币、战斗中的怪（类型、槽位、血量、改血前上限）、召唤点、面板是否打开 |
| tm_summon / tm_summon_select / tm_summon_confirm / tm_summon_vanilla | 读召唤面板、整份替换选择、确认、按原版出场（不填 instance 自动找房主）。不合规则时返回 `rejected_rule` 和原因 |
| tm_map_options / tm_map_vote | 下一步能去的点；本机玩家投票（入队联机投票动作，和点地图一样）。塔主默认拒绝 |
| tm_rewards / tm_rewards_proceed / tm_rewards_skip | 读正在显示的奖励组（类型、金币数、遗物）；按「继续」（Boss 奖励后换幕也用它）；跳过奖励组 |
| tm_treasure / tm_treasure_open / tm_treasure_pick | 宝箱里的遗物和序号、各玩家投票、本机现有遗物；本机点开宝箱（不要对塔主用）；选第 index 个遗物（不给 index = 跳过） |
| tm_event / tm_event_choose | 列事件（含先古之民）选项按钮；点第 index 个 |
| tm_hand / tm_play / tm_end_turn | 本机玩家的手牌、能量；打出第 index 张牌（target 给怪物下标）；结束回合。都入队原版联机动作（PlayCardAction、EndPlayerTurnAction），用来真打战斗、测塔主回合期间出牌是否被挡 |
| tm_traps / tm_trap_pack_pick | 塔主陷阱：手里的陷阱、本场盖下和没触发的、待选陷阱包；选陷阱包（每幕第一次召唤前）。盖陷阱用 tm_summon_select 的 traps（手里序号） |
| tm_threat / tm_threat_act / tm_threat_end | 塔主回合：状态（威胁点、怪、玩家手牌）、操作（block/heal/strength 给 monster 下标，strength_all，weak/vulnerable/frail/dazed 给 player）、结束 |
| tm_cards / tm_cards_pick | 选牌界面（升级、删牌等，凡是有 OnCardClicked 和 _cards 的界面）：列牌；点第 index 张，confirm=true 再按确认 |
| tm_console | 开发者控制台命令，例如 `win`（写进控制台输入框再按原版提交） |
| tm_logs | 按字节游标读 TowerMaster 日志（source=mod）或游戏日志（source=game；游戏运行中这个文件可能是空的） |
| tm_screenshot | 截该实例画面，返回 PNG 路径、尺寸、窗口模式 |
| tm_wait | 等条件：`summon_open`、`in_combat`、`master_turn_open`、`paused_by_master_turn`、`pack_choice_open`、`summon_or_pack`、`rewards_visible`、`room`、`point_type`、`total_floor_at_least`、`in_run`、`log_contains` |
| tm_compare_logs | 两端 TowerMaster 日志里清单/替换/生成/降血行逐行对比（去时间戳） |
| tm_bench | 连续调用 n 次测延迟（p50/p95/最大） |
| tm_battle | 一键：选路 → 等面板（本幕第一次先选陷阱包，pack 参数，默认 0）→ 截图 → 选怪和陷阱（traps） → 截图 → 确认 → 两端进战斗、对比怪物、截图 → 塔主回合（按 threat 列表操作后结束；不给就直接结束）→ win → 召唤点前后 → 等奖励出现并读出（read_rewards，默认开）→ 可选跳过 → 日志对比；失败时返回失败步骤 |
| tm_tree / tm_node_call / tm_reflect | 兜底：列场景树节点、调节点方法、反射读对象或调方法。给有游戏源码的助手补上还没有专门工具的操作（奖励领取、宝箱、事件、休息、商店等） |

### tm_reflect / tm_node_call 参数

- `target`：`run`（RunManager.Instance）、`state`（当前对局 RunState）、`combat`（当前战斗 CombatState）、`node:/root/...|成员`（节点；节点路径后用 `|` 接成员）、`type:类型名或全名|成员`（静态成员，也找 Godot 等非游戏程序集，例如 `type:Godot.DisplayServer`，方法用 method 传），后面 `.成员`、`[下标]`。
- `args`：数字、字符串、布尔、null 原样；枚举写名字；`{"ref": "state.Players[1]"}` 取对象；`{"new": "MapCoord", "args": [3, 1]}` 现造。
- 返回值是 Task 时默认等它完成（`await:false` 不等）。`depth` 控制展开层数（默认 1）。
- 这两个工具能直接调用任何方法，**只用于测试**；能用专门工具或原版界面路径的地方优先用它们，报告里写明用了哪条路径。

## 注意

- `tm_battle` 用 `win` 结束战斗：只能证明进房生成、扣款、奖励流程、胜利收入、下一房间同步，不能证明怪物 AI、自然难度。
- 报告里写清每场是否用了 win、是否用了反射兜底。
- 接口出错不会影响游戏；接口自身的异常写进 TowerMaster 日志（WARN「测试接口 …」）。
