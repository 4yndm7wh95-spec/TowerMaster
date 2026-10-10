# 测试 2 第二轮 + 测试 3 调研（mod 0.0.5）

## 这一版改了什么

1. **动态程序集登记到本 mod**：上一轮两边启动都有 ERROR「TowerMasterSummonNetAction … not associated with any mod」。现在生成动态程序集后调用 `ModManager.AssociateAssemblyWithMod`。签名是按参数类型现场拼的，日志会写「登记动态程序集：已调用 …，参数=[…]」。
2. **参数日志只记血量公式**：上一轮「格挡公式参数两边不一致」，是卡牌预览等本地界面调用导致的，不是战斗不同步。格挡、能力层数公式不再记参数。
3. **改写范围多 3 项**，让爬塔玩家拿到和单人一样的内容：
   - `PotionModel.CanThrowAtAlly`：药水不能扔给已死的塔主；
   - `CardFactory.FilterForPlayerCount`：卡牌奖励不出多人专用卡；
   - 遗物命名空间（`MassiveScroll`、`SilverCrucible`、`WingedBoots` 的 `IsAllowed`）：遗物池按单人。
4. **探针多导出**：`ModManager` 和所有名字以 Synchronizer 结尾的类型的全部成员，给测试 3「塔主自动投票」用。

## 测试步骤

和上一轮一样：A 建房（塔主），B 加入，新开一局第一幕，正常打 2 场普通战斗即可，不需要判负。中途经过的选路、奖励、事件、休息处、宝箱、商店，**都记录 A 需不需要操作才能继续**。

## 要检查的事项

**启动（TowerMaster 日志 + 游戏日志）**
- 游戏日志里那条「not associated with any mod」ERROR 是否消失。
- TowerMaster 日志的「登记动态程序集：…」那一行原文。
- 「改写 M 个」的 M，以及新增的 ★ 方法：`CanThrowAtAlly`、`FilterForPlayerCount`、3 个遗物 `IsAllowed` 是否都带 ★。
- 有没有「改写失败」或其他 ERROR/WARN。

**回归（和上一轮对照）**
- 每场开局塔主生命 0、死亡；爬塔人数 1；怪物血量等于单人。
- 测试 1b 清单与生成两边一致；没有 StateDivergence。

**测试 3 调研（只读，不改代码）**
- 对照反编译代码，**用文字描述**（不要贴大段源码）下面每个环节「等所有玩家」的逻辑：
  - 选路投票（MapSelectionSynchronizer）：怎么收集各玩家的投票，什么条件下出发，票不一致时怎么决定；
  - 战斗奖励（RewardsSetSynchronizer）：是否要每个玩家都点「继续」；
  - 宝箱（TreasureRoomRelicSynchronizer）；
  - 事件（EventSynchronizer）：多人投票选项怎么定；
  - 休息处（篝火）、商店：有没有同步等待；
  - 换幕（ActChangeSynchronizer）。
- 每一项给出：等待条件在哪个方法（文件:行号），玩家投票或确认是通过哪个方法、哪个联机动作或消息提交的（类名、方法签名），以及「替某个玩家自动提交」最自然的挂点。
- 实测中 A 在每个环节**需不需要操作**才能继续，与上面的逻辑对上。

## 要回传的东西

写进 `docs/test2-round2-result.md`：逐项结论、日志摘录、测试 3 调研结果（文字描述 + 文件行号 + 方法签名）。不提交原始日志全文和反编译代码。
