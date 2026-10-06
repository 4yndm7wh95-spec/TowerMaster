# 本机双实例实测

当前默认模式为测试 1b（0.0.2），请新开第一幕对局，预期密林 Mawler + Flyconid、暗港 CalcifiedCultist + Seapunk。安装完成后按下方 A/B 联机步骤打 3～5 场普通战斗并正常退出；测试细节见 `docs/test1b-local-verification.md`。下方固定遭遇预期仅适用于历史测试 1a。

同机两个独立进程可以检验怪物生成顺序、确定性替换、游戏锁步同步和 StateDivergence。不能覆盖跨机器运行环境差异、真实网络延迟、丢包和重连；结论应写“同机双实例通过，跨机器待验证”。

## 启动

1. 先关闭已有游戏。双击“launch-instance-A.cmd”，在新测试存档接受游戏的 mod 提示，确认塔主 mod 已加载。先单人打一场普通战斗，看到本幕固定怪物后退出。把本文件夹的 TowerMaster-A.log 和 game-A.log 另存为单人测试日志，因为下次启动会覆盖。
2. 再次启动 A，在 IP直连 mod 的个人设置中设玩家名 A、玩家 ID 100001，保存，然后选择 IP 直连方式创建大厅。
3. 双击“launch-instance-B.cmd”。在 IP mod 个人设置中设玩家名 B、玩家 ID 100002，保存。不要只改玩家名字；--clientId 用来隔离游戏存档，IP mod 自己的玩家 ID 也必须不同。
4. B 通过 IP 直连加入 127.0.0.1:33771。两个大厅窗口都应出现两名不同玩家。若使用了其他房主端口，地址中的端口也相应更改。
5. 两边选择角色并准备，连打 3～5 场普通战斗。轮流操作两个窗口出牌、结束回合和选择奖励；两边的游戏版本、mod 列表及配置必须相同。
6. 结束后关闭游戏，把本文件夹的 TowerMaster-A.log、TowerMaster-B.log、game-A.log、game-B.log 发回当前聊天。再次启动前先保存日志。

## 预期

密林 NibbitsNormal；暗港 CultistsNormal；蜂巢 MytesNormal；荣耀 AxebotsNormal。普通遭遇按类名 Normal/Weak 判断；精英和 Boss 保留原遭遇。

每场普通战斗的日志先出现“测试1 #n”选遭遇，再出现“已替换”，最后出现“生成 …”。两边对应消息的正文应一致（时间戳自然不同）。探针 WARN、ERROR、异常或 StateDivergence 都需要回传分析。

## 隔离方式及限制

启动脚本使用游戏已有 --force-steam off 和不同 --clientId 参数，分开两个测试账号的存档；IP mod 的 user://mods/DirectConnectIP/config.ini 仍共享，所以在每个已启动的实例里分别设置自己的 ID。它会把 ID 保存在各进程内存中，但重新启动时会读取最后保存的设置，应按上面的顺序重新设置。

TowerMaster 日志用 TOWERMASTER_LOG_FILE 分开。游戏输出用 --log-file 分开。脚本不修改游戏安装目录中的游戏文件。A/B 已成功加入同一大厅并完成 3 场暗港普通战斗，双端日志一致；具体结论与异常见 docs/test1a-multiplayer-result.md。若双开失败、ID 冲突或 mod 未加载，先回传现有日志，不要改游戏 DLL。

## 仓库中运行

启动脚本在 `scripts/local-test/`。双击两个 `.cmd`，或运行 `launch-instance-A.cmd -GameDir "你的游戏目录"`。也可设 `STS2_DIR`。未指定时使用本机已验证的路径。脚本自身用英文文件名，避免中文名称在批处理读取时出现编码问题。日志不提交到 Git，反馈时保留原文件。

退出游戏后再读取游戏日志：本机两实例运行期间 game-A/B.log 曾显示 0 字节，正常退出后写出完整内容。TowerMaster 日志每次启动覆盖，必须先保存。
