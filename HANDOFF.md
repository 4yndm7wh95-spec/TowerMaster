## 测试 3 第一版（2026-10-06，0.0.6，待实测）

测试 2 第二轮实测通过（`docs/test2-round2-result.md`）：动态程序集登记后 ERROR 消失，人数改写 19 个，新增 5 项都带 ★，回归正常。Codex 的只读调研给出了各同步器的等待逻辑和挂点。

据此实现测试 3（`mod/TowerMaster/Test3MasterAutoPilot.cs`）：塔主 = 房主，全部在房主自己的客户端上，用原有接口提交塔主自己的选择。
- 选路：B 的投票执行后入队同目的地的塔主 `VoteForMapCoordAction`。
- 奖励：`SkipLocalRewardsSet`。
- 宝箱：`SkipRelicLocally`。
- 共享事件：`ChooseLocalOption` 跟投。
- 休息处：`BeforeLocalRestSiteExited`。
- 换幕：`SetLocalPlayerReady`。
- 每步只记日志不抛异常，失败时退回手动。
- 已知限制：
  - 多名爬塔玩家时，塔主跟随最近一个投票的人，会给这个人的票多一份权重。
  - 非共享事件不自动选。
- 假同步器上 4 个新测试通过（共 57 个）。测试步骤见 `docs/test3-plan.md`。

## 测试 2 实测结果与第二轮（2026-10-06，0.0.5）

**第一轮实测（0.0.4，详见 `docs/test2-result.md`）通过**：塔主每场开局生命 0、死亡；爬塔人数 1；暗港怪物血量等于单人；B 死亡两边都判负；回合不等 A；怪物只打 B；无 StateDivergence。全游戏共 122 个方法读玩家人数，改写 14 个。
- 塔主战后被原版复活（1 血 + 铁甲战士被动），下一场再退场。用户认为不影响游玩，先不处理。
- 选路、领奖励要等 A 操作：留给测试 3（塔主自动投票）。

**第二轮改动（0.0.5，待实测，见 `docs/test2-round2-plan.md`）**
- 动态程序集调用 `ModManager.AssociateAssemblyWithMod` 登记到本 mod（`mod/TowerMaster/ModAssociation.cs`），消除「not associated with any mod」ERROR。签名未知，按参数类型现场拼。
- 参数日志只记血量公式：格挡公式的「两边参数不一致」来自本地卡牌预览，不是不同步。
- 改写范围加 `PotionModel.CanThrowAtAlly`、`CardFactory.FilterForPlayerCount`、遗物命名空间。
- 探针导出 `ModManager` 和全部 *Synchronizer 类型，并请 Codex 用文字描述各同步器的等待逻辑，供测试 3 使用。

## 测试 2 第一版（2026-10-06，云端，0.0.4，待实测）

塔主 = 房主。战斗初始化后各客户端把塔主角色生命写成 0，借用游戏现成的「死亡玩家」处理：自动准备结束回合、不被选为目标、判负变成只看爬塔玩家。人数缩放：在配置范围内，用 Harmony 改写把「读玩家人数」换成只数爬塔玩家。启动日志列出全游戏所有读玩家人数的方法，下一轮按实测调整范围（`towermaster.test.json` 的 `test2_scaling_scope`）。代码在 `mod/TowerMaster/Test2MasterOffField.cs`，假游戏程序集上 4 个新测试通过（共 52 个）。

**已知风险**
- 改写后的人数如果被拿来当随机下标（例如 `Players[rng.Next(Players.Count)]`），会少一个可选下标。1 对 1 时可能总是选到塔主（已死），表现为怪物打空。实测时注意观察。
- 塔主角色是「死亡」状态，画面上可能显示为倒地。纯装饰的塔主形象以后再做。

测试步骤和观察项见 `docs/test2-plan.md`。

## 测试 1b 保底机制（2026-10-06，云端，0.0.3）

**1b 结论**：用户补充说明，第一场在用 win 之前正常打了几个回合，双方都有造成和受到伤害；之后领奖励、进下一房、第二场生成也正常。所以怪物行动、伤害结算这些战斗同步已经覆盖，**1b 不再单独补测**，测试 2 时保持 1b 开启顺带验证。

**新增保底**（都是少见情况，正常流程不受影响）：
- **出错不卡游戏**：1b 所有补丁都包了异常保护。任何一步失败只写 ERROR/WARN 日志，退回原版遭遇或载体遭遇原本的怪物。
  - 进普通房前没收到清单（读档、重连）：按原版遭遇，不再抛异常。
  - 清单不合格（不是房主、楼层或种子不对、怪物不存在）：只记「拒收召唤清单」，不再让动作执行抛异常。各客户端执行同一个动作、校验结果相同，所以退回原版时各家也一致。
- **重启后序号不冲突**：去掉「序号必须递增」的检查，序号只用于日志。过期清单靠种子和楼层校验拦下；同一份清单收到两次，覆盖即可。
- **读档找回混搭**：替换遭遇时把清单按「种子 + 进房楼层」写进本地文件（`mods/TowerMaster/towermaster.plans.json`；设了 `TOWERMASTER_LOG_FILE` 时放在日志旁边，按实例区分），只保留当前这局。生成怪物时如果是载体遭遇、但没有经过选遭遇流程，就按种子和楼层从文件找回清单。
  - **未在真游戏验证**：读档后是否重新走 `GenerateMonstersWithSlots`、楼层是否等于进房楼层，要实测确认。
  - 风险：只有一边有这个文件（例如换了电脑）时，读档后两边怪物会不同。技术验证阶段可以接受，正式版应改成把清单存进游戏存档或由房主重新广播。
- 自动测试：Core 37 个 + mod 11 个，全部通过（云端用 .NET 10 运行时向前兼容跑 net9.0）。

## 测试 1b 实测阶段结果（2026-10-05：广播与两次混搭生成一致，完整战斗待补测）

单人 Mawler + Flyconid 混搭已确认。双实例两端 9 条接收/替换/生成消息正文完全一致，探针无 WARN/ERROR，无 StateDivergence，自定义动作在真实游戏传输及执行成功。本轮实际为 2 场普通房和 1 个事件房；第一场使用 win 命令，第二场开始后退出，未达到 3～5 场完整战斗要求。连接前握手/ID 冲突及退出资源泄漏异常另行记录，不能宣布整份日志无异常。详细证据及补测步骤见 `docs/test1b-multiplayer-result.md`。

## 测试 1b 实现进度（2026-10-05）

0.0.2 实现第一幕跨遭遇混搭和自定义 INetAction 房主清单广播；保留按名字反射，动态生成游戏接口和动作类型。密林 Mawler + Flyconid，暗港 CalcifiedCultist + Seapunk。原有 40 个测试与新增 4 个测试全部通过。真实程序集编译、安装成功（0 警告、0 错误），已核对安装 DLL、manifest 和配置与构建产物哈希一致；真实游戏启动和联机尚待验证。

实现细节、反编译依据、改动清单及用户实测步骤见 `docs/test1b-local-verification.md`。下方 1a 的“1b 尚未实现”是当时的历史状态。

## 测试 1a 实测结果（2026-10-05：同机双实例通过，跨机器待验证）

### 当前结论

- **同机双实例测试 1a 通过**：v0.111.0、IP直连 1.4.0，A=100001、B=100002，暗港 3 场普通战斗，两端分别记录 3 次战斗结束。用户确认画面和战斗过程正常。
- 两端探针全部找到，TowerMaster 日志均无 WARN/ERROR。
- 每场“选遭遇 / 已替换 / 生成”的 9 条正文逐条完全一致（排除时间戳），每场替换都先于生成。
- 原遭遇依次为 ToadpolesWeak、SeapunkWeak、SludgeSpinnerWeak，均替换为 CultistsNormal，生成 CalcifiedCultist 与 DampCultist（槽位 null）。这轮联机测试在暗港，不是先前单人密林的小啃兽。
- 两份游戏日志均未发现 StateDivergence；成功握手后的 3 场战斗阶段没有发现 ERROR 或异常。测试配置解析和价格表误认 manifest 两处加载问题已在重启后的真实日志中确认消失。
- **完整游戏日志仍有异常**：B 成功加入前发生旧单人存档删除失败、握手身份不匹配和玩家 ID 冲突；A 有一次 HandshakeTimeout 后重连成功。两边退出时有引擎 RID/shader/资源未释放错误，来源尚未定位。不能描述成“整份日志无异常”。另有未声明 min_game_version 的加载提示。
- 之前单人密林的 NibbitsWeak → NibbitsNormal 和两只小啃兽生成顺序也已验证。
- 结论仅覆盖本机双实例和此次 3 场暗港战斗；跨机器、跨幕、延迟、丢包和重连稳定性仍待验证。测试 1b 的怪物混搭、塔主选择和自定义消息尚未实现。
- 详细逐场结果及异常分类：`docs/test1a-multiplayer-result.md`。原始日志仅保存在本机聊天输出目录，未上传。

### 猜测核对和代码依据

反编译路径以下均相对于仓库；decompiled/ 和 tools/ 为本机只读依据，不提交。

1. **入口猜测正确**：命名空间 `MegaCrit.Sts2.Core.Modding`，类上的 `[ModInitializer(nameof(Init))]` 指向静态无参方法。依据 `decompiled/sts2/MegaCrit.Sts2.Core.Modding/ModInitializerAttribute.cs:3、5、10`，`ModManager.cs:787、873–898`。入口之外仍按类型名字反射。
2. **模型猜测正确**：`ModelDb.Encounter<T>()` 返回规范模型（`MegaCrit.Sts2.Core.Models/ModelDb.cs:505`）；`IsMutable` 位于 `AbstractModel.cs:33`，`EncounterModel.ToMutable()` 位于 `EncounterModel.cs:259–264`。游戏在 `MegaCrit.Sts2.Core.Runs/RunManager.cs:768` 取遭遇后 ToMutable；房间构造在 `MegaCrit.Sts2.Core.Rooms/CombatRoom.cs:55–58` 要求可变模型。找不到可变转换时保留原遭遇，避免规范模型进入战斗。
3. **生成时机的普通地图前提正确，原存储结构猜测错误**：`CombatRoom.cs:33、35` 的 Encounter 转发到 CombatState，房间本身没有预想的遭遇字段；`MegaCrit.Sts2.Core.Combat/CombatState.cs:27、55–79` 保存遭遇。普通战斗在 `CombatRoom.cs:169–173` 生成；事件有提前生成路径 `MegaCrit.Sts2.Core.Multiplayer.Game/EventCombatSynchronizer.cs:61`。测试 1a 改挂 `ActModel.PullNextEncounter` 后置补丁（`MegaCrit.Sts2.Core.Models/ActModel.cs:341`），返回规范模型，让游戏继续原有创建副本/房间流程。事件战斗不在此次替换范围。FakeSts2 与 3 个补丁测试同步采用该结构和参数。
4. **manifest 猜测错误**：`dll` 不是加载字段；`ModManifest.cs:30–40` 使用 has_pck、has_dll、affects_gameplay，`ModManager.cs:738–741` 加载 id + .dll，`ModManager.cs:916–925` 和 `MegaCrit.Sts2.Core.Multiplayer/PeerVersionInfo.cs:32` 将影响玩法的 mod 放入握手列表。已参照 IP直连 1.4.0 manifest 修正。
5. **日志必须稳定**：`MegaCrit.Sts2.Core.Models/AbstractModel.cs:1045–1047` 的 ToString 包含进程内哈希，生成行改用稳定 Id。即便原遭遇已是目标，也记录“已替换”，方便每场三行核对。探针补充血量应用方法与 IPacketSerializable，保留原有缩放公式方法。
6. **数据不能误触 manifest 扫描**：`ModManager.cs:346–372` 递归扫 JSON，`:388–398` 判断身份字段。测试配置使用标准无注释 JSON；安装价格表改成 price_book.data，安装时只清理我方旧 price_book.json。源数据仍是 data/price_book.json。

### 本机环境、格式和验证

- 游戏实际 TargetFrameworkAttribute 为 `.NETCoreApp,Version=v9.0`（.NET 9.0），反编译工程 `decompiled/sts2/sts2.csproj:5` 同为 net9.0。Core、mod、测试和 FakeSts2 均已改 net9.0。
- 游戏目录：`C:\Users\kkk\Desktop\slaythespire\Slay the Spire 2`。
- mod 目录：上述目录的 `mods\TowerMaster`。只安装自己的 mod 文件，未修改游戏本体。
- 游戏自带 `data_sts2_windows_x86_64\0Harmony.dll`，文件版本 2.4.2.0；实机直接引用。无游戏的测试构建由 NuGet Harmony 2.3.3 升到 2.4.2，修复 net9.0 下 LocalBuilder 抽象类实例化错误。
- `cd mod && dotnet test`：Core 37 个、补丁测试 3 个全部通过，0 失败、0 跳过。
- `dotnet build TowerMaster -p:GameDir="C:\Users\kkk\Desktop\slaythespire\Slay the Spire 2" -p:Install=true` 编译安装已成功。游戏运行时锁住 mod DLL，更新前必须退出游戏。

实际 manifest：

```json
{
  "id": "TowerMaster",
  "name": "塔主 TowerMaster",
  "version": "0.0.1",
  "author": "brooks",
  "description": "1 名塔主对抗 1–3 名爬塔玩家（技术验证版）",
  "dependencies": [],
  "has_pck": false,
  "has_dll": true,
  "affects_gameplay": true
}
```

### 同机双实例工具

`scripts/local-test/` 收录两个英文文件名的 cmd/PowerShell 启动脚本及 README。可传 GameDir 或设 STS2_DIR，默认本机游戏路径。英文内部脚本名避免已遇到的中文批处理编码故障；失败时窗口保留报错。

两实例用 `--force-steam off` 和不同 `--clientId` 隔离游戏存档；TowerMaster 用 `TOWERMASTER_LOG_FILE` 分开日志，游戏用 `--log-file` 分开输出。默认运行 mod 时仍在 mod 目录写 TowerMaster.log。IP mod 的配置仍共享，各实例需在个人设置分别设 ID 100001/100002；重启后会读最后保存的配置，不能只改昵称。A 建 IP 大厅，B 连 127.0.0.1:33771。依据：`NGame.cs:1082–1090`、`NullPlatformUtilStrategy.cs:29`、`UserDataPathProvider.cs:30–42`；本机 IP mod 的 `ModConfigManager.cs:106、129–130`、`DirectHost.cs:200`、`JoinServerScreen.cs:216`。

同机测试能检验确定性与锁步同步，不能覆盖跨机器运行环境或真实网络延迟/丢包。本次已重启确认我方 JSON 加载异常消失，并完成 3 场双端正文对照。下一步推进测试 1b；跨机器测试仍需补做。

### 测试 1b 所需签名（摘自本次真实探针日志）

```text
static T MegaCrit.Sts2.Core.Models.ModelDb.Monster<T>()
static T MegaCrit.Sts2.Core.Models.ModelDb.Encounter<T>()
EncounterModel MegaCrit.Sts2.Core.Models.ActModel.PullNextEncounter(RoomType roomType)
Void MegaCrit.Sts2.Core.Models.EncounterModel.GenerateMonstersWithSlots(IRunState runState)
property IReadOnlyList<ValueTuple<MonsterModel, String>> MegaCrit.Sts2.Core.Models.EncounterModel.MonstersWithSlots
Creature MegaCrit.Sts2.Core.Combat.CombatState.CreateCreature(MonsterModel monster, CombatSide side, String slot)
GameAction MegaCrit.Sts2.Core.GameActions.Multiplayer.INetAction.ToGameAction(Player player)
Void MegaCrit.Sts2.Core.Multiplayer.Serialization.IPacketSerializable.Serialize(PacketWriter writer)
Void MegaCrit.Sts2.Core.Multiplayer.Serialization.IPacketSerializable.Deserialize(PacketReader reader)
```

探针会继续输出 INetMessage 的 ShouldBroadcast、Mode、LogLevel、ShouldBuffer。测试 1b 将用自定义 INetAction 广播召唤清单，再验证跨遭遇混搭的站位和场景；这些仍未实现。需要的其他成员应继续从真实探针提取，不能把云端猜测写作已确认签名。

详细核对：`docs/test1a-local-verification.md`。双实例步骤：`scripts/local-test/README.md`。

---

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
