# 测试 1b 同机双实例阶段结果（2026-10-05）

## 结论及覆盖范围

游戏 v0.111.0、TowerMaster 0.0.2、IP 直连 A=100001/B=100002。用户确认两端怪物相同、操作未见问题。单人截图和日志确认 Mawler + Flyconid 混搭生成。

本次双实例确认自定义 INetAction 已在真实游戏完成广播、反序列化和执行：房主有 3 次发送，客户端无发送；两边各 3 次接收。移除时间戳后，两端 9 条接收/替换/开始生成/生成正文完全一致。两次普通房生成均在接收与替换之后。

实际覆盖 **2 场普通战斗的生成、1 个事件房**，不是 3 场普通战斗。第一场游戏日志记录客户端 ConsoleCmdGameAction 的 win 命令；第二场在开始阶段退出。退出流程也产生 Combat ended，不能将该行计数当作完成战斗。尚未满足 3～5 场完整普通战斗的验收要求，不宣布测试 1b 全部通过。

| 清单序号 | 移动前楼层 | 结果 |
| --- | --- | --- |
| 1 | 1 | SlimesWeak → CultistsNormal；Mawler + Flyconid，生成楼层 2 |
| 2 | 2 | AromaOfChaos 事件房，无普通遭遇替换或混搭生成 |
| 3 | 3 | NibbitsWeak → CultistsNormal；Mawler + Flyconid，生成楼层 4 |

两边种子均为 8475379956557153421，怪物稳定 ID 分别为 MONSTER.MAWLER、MONSTER.FLYCONID，槽位均为 null。

## 日志异常

- 两份 TowerMaster 日志探针全部找到，无 WARN/ERROR，动态动作注册和所有挂钩成功。
- 两份游戏日志均未发现 StateDivergence。成功联机后的已观察战斗阶段未发现异常或 ERROR。
- 成功入局前，B 曾错误创建大厅，随后发生 ENet 握手 ID 不匹配、ClientConnectionFailedException、两次 ID Collision (100002)；A 出现 HandshakeTimeout。后续成功联机并执行清单，仍需将这些问题与战斗阶段区分记录。
- 游戏日志仍有资源未缓存、PacketWriter 扩容提示，以及正常退出时的 RID/shader/资源泄漏错误；来源未定位，不声称整份游戏日志无异常。

## 修复与下一步

首次单人仅出现原版一只怪的原因和构造函数反射修复见 test1b-local-verification.md；修复已推送，44 个自动测试通过，真实编译安装成功。

下一轮新开双实例第一幕对局，完整打完至少 3 场普通战斗，保留正常出牌、敌方行动、奖励及进下一房的过程；避免用 win 命令替代战斗。正常退出后核对清单、生成顺序、同步与异常。跨机器、暗港混搭、跨幕、读档、断线重连尚未验证。

原始日志已保存在本机输出目录 TowerMaster-test1b-multiplayer-A/B.log、game-test1b-multiplayer-A/B.log，不提交日志或反编译代码。
