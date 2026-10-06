# 测试 1a 本机核对记录（实测前）

仓库：C:\Users\kkk\Desktop\tower-master-mod
分支：claude/optimistic-rubin-hr3eit，已切换并拉取。
以下依据文件均以仓库路径为根。

| 猜测 | 核对结论与修改 | 反编译依据 |
| --- | --- | --- |
| ModInitializer 入口 | 正确：特性放在类上，传静态无参 Init 的名字；只去掉猜测注释。游戏命名空间仍只在入口出现。 | decompiled/sts2/MegaCrit.Sts2.Core.Modding/ModInitializerAttribute.cs:3、5、10；ModManager.cs:787、873、876、892 |
| ModelDb 与可变副本 | 正确：Encounter<T>() 返回规范模型；EncounterModel.ToMutable() 创建可变副本。游戏建 CombatRoom 时要求可变模型。现挂点返回规范模型，由游戏原流程 ToMutable。 | decompiled/sts2/MegaCrit.Sts2.Core.Models/ModelDb.cs:505；EncounterModel.cs:259；AbstractModel.cs:33；decompiled/sts2/MegaCrit.Sts2.Core.Runs/RunManager.cs:768；decompiled/sts2/MegaCrit.Sts2.Core.Rooms/CombatRoom.cs:55、57 |
| StartCombat 生成时机 | 普通地图战斗的前提正确，但原补丁寻找房间自身遭遇字段错误：CombatRoom.Encounter 转发到 CombatState.Encounter。改挂 ActModel.PullNextEncounter 返回值，在房间和战斗状态创建之前替换。事件战斗另有提前生成路径，测试 1a 不改事件战斗。FakeSts2 同步改为 CombatState 结构和选遭遇后创建可变副本。 | CombatRoom.cs:33、35、169、173；decompiled/sts2/MegaCrit.Sts2.Core.Combat/CombatState.cs:27、55、76；ActModel.cs:341；RunManager.cs:768；decompiled/sts2/MegaCrit.Sts2.Core.Multiplayer.Game/EventCombatSynchronizer.cs:61 |
| manifest | 错误：dll 字段不是游戏的加载开关，改 has_dll=true、has_pck=false、dependencies=[]、affects_gameplay=true。DLL 名为 id + .dll。affects_gameplay=true 进入联机握手列表。 | ModManifest.cs:30–40、45、82；ModManager.cs:738–741、916–925；decompiled/sts2/MegaCrit.Sts2.Core.Multiplayer/PeerVersionInfo.cs:32 |

IP直连 manifest 参照：C:\Users\kkk\Desktop\slaythespire\Slay the Spire 2\mods\[IP直连1.4.0][v0.111]\DirectConnectIP.json，字段 dependencies/has_pck/has_dll/affects_gameplay 与游戏 ModManifest 一致。

另修日志稳定性：AbstractModel.ToString() 包含进程内对象哈希（AbstractModel.cs:1045–1047），生成日志改记录模型 ID，避免两进程同样怪物被误判为不同。相同目标遭遇也记录“已替换”，便于每场三行对照。探针保留 ScaleHpForMultiplayer 并增加 ScaleMonsterHpForMultiplayer（Creature.cs:644、336），两者都存在。

游戏目标框架：实际 sts2.dll 的 TargetFrameworkAttribute 序列化值为 .NETCoreApp,Version=v9.0 / .NET 9.0；反编译工程 decompiled/sts2/sts2.csproj:5 同为 net9.0。TowerMaster.Core、TowerMaster 和测试工程/FakeSts2 均改 net9.0。

游戏目录：C:\Users\kkk\Desktop\slaythespire\Slay the Spire 2
Harmony：data_sts2_windows_x86_64\0Harmony.dll 已存在，直接引用游戏版本，无需复制其他 Harmony 到 mod。
安装目录：游戏目录\mods\TowerMaster（ModManager.cs:82 对应 exe 旁的 mods）。
编译安装：dotnet build TowerMaster -p:GameDir="C:\Users\kkk\Desktop\slaythespire\Slay the Spire 2" -p:Install=true，已成功，0 警告、0 错误。只写入自己的 mod 文件。

实测尚未开始，不记为通过；收到日志后再核对探针 WARN、每场选遭遇/替换/生成顺序和双端一致性、StateDivergence 与异常。按用户最新要求先同步当前修正和详细记录；双实例通过后继续追加实测结论。

验证：最终 `cd mod && dotnet test` 全部通过，TowerMaster.Core.Tests 37 个、TowerMaster.Tests 3 个，0 失败、0 跳过。测试用 NuGet Harmony 从 2.3.3 升至与游戏一致的 2.4.2；2.3.3 在 net9.0 上出现 LocalBuilder 抽象类实例化错误。官方依据：https://github.com/pardeike/Harmony/releases 。探针额外记录 IPacketSerializable 的 Serialize/Deserialize 签名（decompiled/sts2/MegaCrit.Sts2.Core.Multiplayer.Serialization/IPacketSerializable.cs:3、5、7），供测试 1b 从实际日志摘录。

实机发现的 JSON 扫描问题：ModManager.cs:346–372 递归扫描所有 .json，ModManager.cs:388–398 会把含 version、无 id 的价格表当成错误 manifest。配置去掉注释后可被跳过；安装价格表改名 price_book.data，内容仍为 JSON，ModEntry 使用新名。安装目标清理自己的旧 price_book.json；仓库源 data/price_book.json 和 Core 测试数据保持原名。修正后 40 个测试再次全部通过。
