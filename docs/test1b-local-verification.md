# 测试 1b：跨遭遇混搭与房主清单广播

## 当前状态

版本 0.0.2 已实现，原有 40 个测试和新增 4 个测试全部通过（Core 37、mod 7）。使用真实游戏程序集编译、安装成功（0 警告、0 错误）。首次安装的 DLL 占用问题在关闭游戏后解决；两份 DLL、manifest 和测试配置的安装哈希均与构建产物一致。尚未完成真实游戏启动和双实例实测，不能据此宣布联机通过。

## 实现与依据

以下反编译路径相对于 decompiled/sts2/，仅供本机核查，不提交反编译文件。

- 房主在地图移动动作入队前插入召唤清单动作，沿用游戏的动作广播和玩家队列。依据 MegaCrit.Sts2.Core.Multiplayer.Game/MapSelectionSynchronizer.cs:99–113、MegaCrit.Sts2.Core.GameActions.Multiplayer/ActionQueueSynchronizer.cs:124–151、201–214、316–326。
- 使用 Reflection.Emit 实现游戏 INetAction 和 GameAction，按名字寻找类型，避免增加游戏类型的编译期依赖。依据 MegaCrit.Sts2.Core.GameActions.Multiplayer/INetAction.cs:8–11、MegaCrit.Sts2.Core.Multiplayer.Serialization/IPacketSerializable.cs:3–7；通过 ReflectionHelper.ModTypes 注册，依据 MegaCrit.Sts2.Core.Helpers/ReflectionHelper.cs:36–53 和 MegaCrit.Sts2.Core.Multiplayer.Serialization/NetTypeCache.cs:20–34。真实游戏中的注册和传输仍需实测。
- 清单包含版本、序号、种子、幕、移动前楼层和两种怪物。接收时检查房主身份、对局、楼层、怪物和重复序号；客户端使用房主清单。非普通房间不替换，未配置的幕不启用混搭。
- PullNextEncounter 返回通用场景载体 CultistsNormal，再将清单关联到其可变副本。依据 MegaCrit.Sts2.Core.Runs/RunManager.cs:768 和 MegaCrit.Sts2.Core.Models/EncounterModel.cs:259–264。
- 保留 GenerateMonstersWithSlots 的种子初始化，只在载体 GenerateMonsters 返回后替换怪物列表。依据 MegaCrit.Sts2.Core.Rooms/CombatRoom.cs:169–173、MegaCrit.Sts2.Core.Models/EncounterModel.cs:198–215。每只怪物由 ModelDb.Monster<T>() 取得规范模型后 ToMutable，依据 MegaCrit.Sts2.Core.Models/MonsterModel.cs:353。
- CultistsNormal 使用无专用场景、无指定槽位的布局；游戏会自动排列怪物。依据 MegaCrit.Sts2.Core.Models/EncounterModel.cs:129–131 和 MegaCrit.Sts2.Core.Nodes.Rooms/NCombatRoom.cs:344–367、381。

## 改动范围

新增 RuntimeNetAction.cs、Test1bMixedEncounter.cs；扩展 TestSettings 和入口模式选择；配置默认开启测试 1b 并关闭 1a。manifest 版本改为 0.0.2，仍 affects_gameplay=true。

FakeSts2 增加怪物规范模型/可变副本、生成包装方法、动作队列、网络接口和包读写结构。保留原有 3 个 mod 测试，新增 4 个覆盖动态接口与序列化往返、房主动作顺序及混搭生成、客户端采用房主清单，以及错误身份/楼层/怪物/重复消息拒绝。假包读写只模拟字符串往返，不能代替真实网络验证。

## 用户实测步骤

安装完成后仍使用原有 A/B 启动脚本及不同玩家 ID，B 加入 127.0.0.1:33771。必须新开一局，先只测试第一幕，打 3～5 场普通战斗后正常退出两个窗口。

密林预期 Mawler + Flyconid；暗港预期 CalcifiedCultist + Seapunk。每场都是两种不同怪物。精英和 Boss 保留原遭遇。

检查两边“收到清单 / 已替换 / 开始生成 / 生成”正文逐条一致，且收到清单、替换先于生成；“房主发送”只在房主出现。检查探针 WARN、异常及 StateDivergence。保留四份 A/B 日志，再启动会覆盖。

同机双实例通过仅证明该环境中的动作传输和战斗同步，跨机器、延迟、丢包、重连和读档尚未覆盖。实测发现问题后修复、重跑测试、重新安装，再重复本流程。
