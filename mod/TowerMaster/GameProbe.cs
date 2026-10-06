namespace TowerMaster;

/// <summary>
/// 启动探针：检查 HANDOFF.md「联机代码定位」里记的类和方法在当前游戏版本里是否存在，把签名写进日志。
/// 游戏更新后先看这一段日志：缺了哪个就先修哪个。
/// </summary>
internal static class GameProbe
{
    /// <summary>（成员名, 用途）。成员在哪个类里由探针自己找。</summary>
    private static readonly (string Member, string Purpose)[] Members =
    [
        ("StartCombat", "测试1：战斗开始"),
        ("GenerateMonstersWithSlots", "测试1：按种子生成怪物组合"),
        ("MonstersWithSlots", "测试1：生成好的怪物组合"),
        ("PullNextEncounter", "测试1：选出下一个遭遇，生成前替换"),
        ("CreateCreature", "生成怪物"),
        ("SetUpCombat", "战斗初始化"),
        ("StartTurn", "回合开始：塔主回合插入点"),
        ("RunAutoPrePlayPhase", "回合开始：塔主回合插入点"),
        ("SetReadyToEndTurn", "准备结束回合"),
        ("ExecuteEnemyTurn", "敌方回合"),
        ("ScaleHpForMultiplayer", "测试2：怪物血量人数缩放公式"),
        ("ScaleMonsterHpForMultiplayer", "测试2：应用怪物血量人数缩放"),
        ("ModifyBlockMultiplicative", "测试2：怪物格挡人数缩放"),
        ("GetScaledAmountForMultiplayer", "测试2：能力层数人数缩放"),
        ("ReviveBeforeCombatEnd", "测试2：战斗结束复活"),
        ("GetMe", "测试2：找本地玩家（塔主不在场会抛异常）"),
        ("StartNewMultiplayerRun", "开局建 Player"),
        ("HandleClientLobbyJoinRequestMessage", "大厅加入"),
        ("TryAddPlayerInFirstAvailableSlot", "大厅分配位置"),
        ("GetSubtypesInMods", "mod 注册联机消息"),
    ];

    private static readonly (string Type, string Purpose)[] Types =
    [
        ("CombatRoom", "战斗房间"),
        ("ModelDb", "取怪物、遭遇模型"),
        ("INetAction", "自定义联机动作（广播召唤清单、塔主操作）"),
        ("INetMessage", "自定义联机消息"),
        ("IPacketSerializable", "测试1b：联机动作的序列化接口"),
        ("ChecksumTracker", "不同步检测"),
        ("ActionQueueSynchronizer", "动作队列同步"),
        ("ModInitializerAttribute", "mod 入口"),
        ("MultiplayerScalingModel", "人数缩放"),
    ];

    /// <summary>这些类型把全部成员签名都写出来，后面写补丁要用。</summary>
    private static readonly string[] DumpAllMembers =
    [
        "ModelDb", "INetAction", "INetMessage", "IPacketSerializable", "ModInitializerAttribute",
        // 测试 2：塔主退场、胜负、复活、人数缩放要用
        "Player", "Creature", "CombatState", "CombatManager", "MultiplayerScalingModel", "CreatureCmd", "LocalContext",
    ];

    public static void Run()
    {
        Log.Info($"===== 探针：游戏程序集 {GameReflection.Game.GetName()}，{GameReflection.Types.Length} 个类型 =====");
        int missing = 0;

        foreach (var (name, purpose) in Types)
        {
            var found = GameReflection.TypesNamed(name);
            if (found.Count == 0) { missing++; Log.Warn($"缺类型 {name}（{purpose}）"); continue; }
            foreach (var t in found) Log.Info($"类型 {t.FullName}（{purpose}）基类={t.BaseType?.Name}");
        }

        foreach (var (name, purpose) in Members)
        {
            var found = GameReflection.MembersNamed(name);
            if (found.Count == 0) { missing++; Log.Warn($"缺成员 {name}（{purpose}）"); continue; }
            foreach (var m in found) Log.Info($"成员 {GameReflection.Describe(m)}（{purpose}）");
        }

        foreach (var typeName in DumpAllMembers)
        foreach (var t in GameReflection.TypesNamed(typeName))
        {
            Log.Info($"----- {t.FullName} 全部成员 -----");
            foreach (var m in t.GetMembers(GameReflection.All | System.Reflection.BindingFlags.DeclaredOnly))
                Log.Info("  " + GameReflection.Describe(m));
        }

        Log.Info(missing == 0 ? "===== 探针：全部找到 =====" : $"===== 探针：缺 {missing} 项，见上面的 WARN =====");
    }
}
