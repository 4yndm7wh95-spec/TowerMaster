# 测试 1a 同机双实例实测结果（2026-10-05）

结论：本机 v0.111.0、IP直连 1.4.0，玩家 A=100001、B=100002，两独立游戏实例完成 3 场暗港普通战斗，固定遭遇替换和同步验证通过。跨机器、跨幕以及真实网络条件仍待验证。

| 核验项目 | A | B |
| --- | --- | --- |
| 探针 WARN/ERROR | 0 | 0 |
| 普通遭遇替换 | 3 场 | 3 场 |
| 日志中的战斗结束 | 3 次 | 3 次 |
| 选遭遇→替换→生成 | 每场顺序正确 | 每场顺序正确 |
| StateDivergence | 未发现 | 未发现 |

两边 9 条战斗消息正文逐条完全一致，时间戳除外。三场原遭遇依次是 ToadpolesWeak、SeapunkWeak、SludgeSpinnerWeak，均替换为 CultistsNormal。生成组合均为 CalcifiedCultist:MONSTER.CALCIFIED_CULTIST 与 DampCultist:MONSTER.DAMP_CULTIST，槽位都是 null。用户报告画面和战斗过程正常。

配置 JSON 的解析异常和价格表被误认成 manifest 的错误在本次日志均未再出现。TowerMaster 两端成功初始化。

## 必须保留的异常记录

不能把全部游戏日志称为“无异常”：

- B 在成功握手前，出现两条旧单人存档删除失败、ENet 握手身份不匹配、加入失败和 DirectClient 的 ID Collision(100001)。这些均早于双方成功握手和新联机战斗；当前记录没有证据将它们归因于 TowerMaster 的遭遇替换。
- A 先前连接尝试出现 HandshakeTimeout，随后重新握手成功。
- 两边退出时都有 Godot 的 RID、shader 和资源未释放错误。这是退出阶段的资源清理记录，尚未定位来源，不是本次战斗中的不同步证据。
- 游戏提示 TowerMaster 未声明 min_game_version；该提示不是探针 WARN，当前没有阻止加载。
- 成功加入后的 3 场战斗阶段，没有发现 ERROR、异常或 StateDivergence。

原始日志保存在本次聊天输出目录的 game-multiplayer-A/B.log、TowerMaster-multiplayer-A/B.log，不提交原始运行日志。核验 JSON 中保存其 SHA-256 和逐场对照结果。

下一步：测试 1b，跨遭遇混搭怪物，并用自定义 INetAction 广播召唤清单。当前尚未实现，先处理站位/场景和确定性顺序；HANDOFF 最前面已保留本次真实探针摘录的接口签名。
