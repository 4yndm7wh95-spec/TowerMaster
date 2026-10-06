using System.Collections;
using System.Reflection;
using System.Reflection.Emit;
using HarmonyLib;

namespace TowerMaster;

/// <summary>
/// 测试 2：塔主仍是联机玩家，但战斗中不在场。
/// 第一版做法（尽量借用游戏现成的「死亡玩家」处理）：
/// 1. 塔主 = 房主。战斗初始化后，各客户端把塔主角色的生命直接设为 0（不走伤害流程，不触发死亡事件）。
///    死亡玩家每回合自动「准备结束回合」、不会被怪物选为目标，而「所有玩家都死才判负」也就等价于「爬塔玩家都死」。
///    战斗结束时原版会给死亡玩家回 1 血，这一版不拦，下一场开局再设为 0。
/// 2. 人数缩放只数爬塔玩家：把指定范围内「Players.Count / .Length / .Count()」的读法改成调用 <see cref="CountClimbers"/>。
///    同时把整个游戏里所有这样读人数的方法列进日志，供下一轮调整范围。
/// 每一步都只记日志不抛异常；塔主是谁只取决于联机身份，各客户端算出同一个人，所以不需要额外同步。
/// </summary>
internal static class Test2MasterOffField
{
    private static TestSettings _settings = new();
    private static readonly HashSet<string> LoggedArgs = new();

    internal static void Apply(Harmony harmony, TestSettings settings)
    {
        _settings = settings;
        PatchPlayerCounts(harmony);
        LogScalingArguments(harmony);
        PatchCombatSetUp(harmony);
    }

    // ---------------------------------------------------------------- 塔主身份

    /// <summary>塔主的联机 id：房主。单人模式返回 null（测试 2 全部不生效）。</summary>
    internal static ulong? MasterId
    {
        get
        {
            try
            {
                var service = GameReflection.Get(Test1bMixedEncounter.Run, "NetService");
                return GameReflection.Get(service!, "Type")?.ToString() switch
                {
                    "Host" => Convert.ToUInt64(GameReflection.Get(service!, "NetId")),
                    "Client" => Convert.ToUInt64(GameReflection.Get(service!, "HostNetId")),
                    _ => null,
                };
            }
            catch { return null; }
        }
    }

    /// <summary>玩家对象的联机 id；传进来的也可能是角色（Creature），就再取它的 Player。</summary>
    internal static ulong? NetIdOf(object? item)
    {
        if (item == null) return null;
        var id = GameReflection.Get(item, "NetId");
        if (id == null && GameReflection.Get(item, "Player") is { } player) id = GameReflection.Get(player, "NetId");
        return id == null ? null : Convert.ToUInt64(id);
    }

    /// <summary>只数爬塔玩家（不含塔主），至少 1。</summary>
    public static int CountClimbers(object? players)
    {
        if (players is not IEnumerable list) return 0;
        var items = list.Cast<object?>().ToList();
        var master = MasterId;
        if (master == null) return items.Count;
        int climbers = items.Count(p => NetIdOf(p) != master);
        return Math.Max(1, Math.Min(items.Count, climbers));
    }

    /// <summary>数组的 ldlen 版本（返回 native int）。</summary>
    public static nint CountClimbersLength(object? players) => CountClimbers(players);

    // ---------------------------------------------------------------- 人数缩放

    private static readonly MethodInfo CountMethod = typeof(Test2MasterOffField).GetMethod(nameof(CountClimbers))!;
    private static readonly MethodInfo LengthMethod = typeof(Test2MasterOffField).GetMethod(nameof(CountClimbersLength))!;

    /// <summary>
    /// 读玩家集合的指令：Players 属性或名字含 players 的字段。
    /// 集合是结构体时（取的是地址），不能当对象传给 <see cref="CountClimbers"/>，跳过。
    /// </summary>
    private static bool LoadsPlayers(OpCode op, object? operand) => operand switch
    {
        MethodInfo m => m.Name is "get_Players" or "get_AllPlayers" && !m.ReturnType.IsValueType,
        FieldInfo f => op != OpCodes.Ldflda && op != OpCodes.Ldsflda && !f.FieldType.IsValueType
                       && f.Name.Contains("players", StringComparison.OrdinalIgnoreCase),
        _ => false,
    };

    /// <summary>紧接着取个数的指令：Count 属性、Length（ldlen）、Enumerable.Count(x)。</summary>
    private static bool IsCount(OpCode op, object? operand) =>
        op == OpCodes.Ldlen
        || operand is MethodInfo m && (m.Name == "get_Count"
            || m.Name == "Count" && m.DeclaringType == typeof(Enumerable) && m.GetParameters().Length == 1);

    /// <summary>扫描方法体，返回「读玩家集合后马上取个数」的位置数。</summary>
    private static int CountSites(MethodBase method)
    {
        try
        {
            var body = PatchProcessor.ReadMethodBody(method).ToList();
            int sites = 0;
            for (int i = 0; i + 1 < body.Count; i++)
                if (LoadsPlayers(body[i].Key, body[i].Value) && IsCount(body[i + 1].Key, body[i + 1].Value)) sites++;
            return sites;
        }
        catch { return 0; }
    }

    private static bool InScope(MethodBase method)
    {
        var type = method.DeclaringType;
        if (type == null) return false;
        foreach (var entry in _settings.Test2ScalingScope)
        {
            if (entry.Contains('.') && !entry.StartsWith("MegaCrit"))
            {
                // 「类名.方法名」
                if (entry == $"{type.Name}.{method.Name}") return true;
            }
            else if (type.FullName?.StartsWith(entry) == true || type.Name == entry || method.Name == entry) return true;
        }
        return false;
    }

    private static IEnumerable<MethodBase> AllGameMethods() =>
        GameReflection.Types
            .Where(t => !t.IsGenericTypeDefinition && !t.IsInterface)
            .SelectMany(t =>
            {
                try
                {
                    return t.GetMethods(GameReflection.All | BindingFlags.DeclaredOnly).Cast<MethodBase>()
                        .Concat(t.GetConstructors(GameReflection.All | BindingFlags.DeclaredOnly));
                }
                catch { return []; }
            })
            .Where(m => !m.IsAbstract && !m.ContainsGenericParameters && m.GetMethodBody() != null);

    private static void PatchPlayerCounts(Harmony harmony)
    {
        var transpiler = new HarmonyMethod(typeof(Test2MasterOffField).GetMethod(nameof(Transpiler), GameReflection.All)!);
        int patched = 0, listed = 0;
        Log.Info("===== 测试2：所有「读玩家人数」的方法（★ = 已改成只数爬塔玩家） =====");
        foreach (var method in AllGameMethods())
        {
            int sites = CountSites(method);
            if (sites == 0) continue;
            listed++;
            bool scoped = InScope(method);
            if (scoped)
            {
                try { harmony.Patch(method, transpiler: transpiler); patched++; }
                catch (Exception e) { Log.Error($"测试2：改写失败 {GameReflection.Describe(method)}", e); scoped = false; }
            }
            Log.Info($"测试2 {(scoped ? "★" : "  ")} {sites} 处 {GameReflection.Describe(method)}");
        }
        Log.Info($"===== 测试2：共 {listed} 个方法读玩家人数，改写 {patched} 个 =====");
    }

    private static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
    {
        var list = instructions.ToList();
        for (int i = 0; i + 1 < list.Count; i++)
        {
            if (!LoadsPlayers(list[i].opcode, list[i].operand) || !IsCount(list[i + 1].opcode, list[i + 1].operand)) continue;
            var next = list[i + 1];
            var replacement = new CodeInstruction(OpCodes.Call, next.opcode == OpCodes.Ldlen ? LengthMethod : CountMethod);
            replacement.labels.AddRange(next.labels);
            replacement.blocks.AddRange(next.blocks);
            list[i + 1] = replacement;
        }
        return list;
    }

    /// <summary>血量缩放公式的参数打日志：看传进来的人数对不对。</summary>
    private static void LogScalingArguments(Harmony harmony)
    {
        var prefix = new HarmonyMethod(typeof(Test2MasterOffField).GetMethod(nameof(ArgsPrefix), GameReflection.All)!);
        // 只记血量公式。格挡、能力层数公式也会被卡牌预览等本地界面调用，两边次数不同，记下来反而误导对照。
        foreach (var name in new[] { "ScaleHpForMultiplayer", "ScaleMonsterHpForMultiplayer" })
        foreach (var method in GameReflection.MembersNamed(name).OfType<MethodInfo>().Where(m => !m.IsAbstract && m.GetMethodBody() != null))
        {
            try { harmony.Patch(method, prefix: prefix); }
            catch (Exception e) { Log.Warn($"测试2：挂参数日志失败 {GameReflection.Describe(method)}：{e.Message}"); }
        }
    }

    private static void ArgsPrefix(MethodBase __originalMethod, object[] __args)
    {
        try
        {
            var key = $"{__originalMethod.DeclaringType?.Name}.{__originalMethod.Name}";
            lock (LoggedArgs)
            {
                if (LoggedArgs.Count(k => k.StartsWith(key + "#")) >= 5) return; // 每个方法只记前 5 次
                LoggedArgs.Add($"{key}#{LoggedArgs.Count}");
            }
            var parameters = __originalMethod.GetParameters();
            var text = string.Join(", ", parameters.Select((p, i) => $"{p.Name}={GameReflection.Dump(i < __args.Length ? __args[i] : null)}"));
            Log.Info($"测试2 参数 {key}({text})");
        }
        catch { /* 只是日志 */ }
    }

    // ---------------------------------------------------------------- 战斗开局：塔主角色退场

    private static void PatchCombatSetUp(Harmony harmony)
    {
        var setUp = GameReflection.FindMethod("SetUpCombat", "CombatManager") ?? GameReflection.FindMethod("SetUpCombat");
        if (setUp == null) { Log.Error("测试2：找不到 SetUpCombat，塔主不会退场"); return; }
        harmony.Patch(setUp, postfix: new HarmonyMethod(typeof(Test2MasterOffField).GetMethod(nameof(AfterSetUp), GameReflection.All)!));
        Log.Info($"测试2：已挂到 {GameReflection.Describe(setUp)}");
    }

    private static void AfterSetUp(object? __instance, object[] __args)
    {
        try
        {
            var master = MasterId;
            if (master == null) { Log.Info("测试2：单人模式，不处理"); return; }
            var state = FindCombatState(__instance, __args);
            var players = PlayersOf(state);
            if (players.Count == 0) { Log.Error("测试2：找不到本场的玩家列表"); return; }

            foreach (var player in players)
            {
                var creature = GameReflection.Get(player, "Creature") ?? player;
                bool isMaster = NetIdOf(player) == master;
                if (isMaster && _settings.Test2MasterOffField) SetHpZero(creature);
                Log.Info($"测试2 开局 玩家 {NetIdOf(player)}{(isMaster ? "（塔主）" : "")}：" +
                         $"生命={GameReflection.Get(creature, "CurrentHp")}/{GameReflection.Get(creature, "MaxHp")} 死亡={GameReflection.Get(creature, "IsDead")}");
            }
            Log.Info($"测试2 开局 爬塔人数={CountClimbers(players)}");
            foreach (var enemy in EnemiesOf(state))
                Log.Info($"测试2 开局 怪物 {GameReflection.Dump(GameReflection.Get(enemy, "Monster") ?? enemy)}：" +
                         $"生命={GameReflection.Get(enemy, "CurrentHp")}/{GameReflection.Get(enemy, "MaxHp")} 格挡={GameReflection.Get(enemy, "Block")}");
        }
        catch (Exception e)
        {
            Log.Error("测试2：开局处理失败", e);
        }
    }

    private static object? FindCombatState(object? instance, object[] args)
    {
        foreach (var arg in args)
            if (arg?.GetType().Name == "CombatState") return arg;
        if (instance == null) return null;
        foreach (var name in new[] { "CombatState", "State", "_combatState", "_state" })
            if (GameReflection.Get(instance, name) is { } s && s.GetType().Name == "CombatState") return s;
        return null;
    }

    private static List<object> PlayersOf(object? state)
    {
        object? players = state == null ? null : GameReflection.Get(state, "Players");
        players ??= GameReflection.Get(GameReflection.Get(Test1bMixedEncounter.Run, "State")!, "Players");
        return players is IEnumerable list ? list.Cast<object>().ToList() : [];
    }

    private static List<object> EnemiesOf(object? state)
    {
        if (state == null) return [];
        foreach (var name in new[] { "Enemies", "Monsters", "EnemyCreatures" })
            if (GameReflection.Get(state, name) is IEnumerable list) return list.Cast<object>().ToList();
        return [];
    }

    /// <summary>直接把生命写成 0：先找 CurrentHp 的 setter（含非公开），再找后备字段。</summary>
    private static void SetHpZero(object creature)
    {
        for (var t = creature.GetType(); t != null; t = t.BaseType)
        {
            var prop = t.GetProperty("CurrentHp", GameReflection.All | BindingFlags.DeclaredOnly);
            if (prop?.SetMethod != null)
            {
                prop.SetValue(creature, Convert.ChangeType(0, prop.PropertyType));
                return;
            }
            foreach (var field in new[] { "<CurrentHp>k__BackingField", "_currentHp", "currentHp" })
            {
                var f = t.GetField(field, GameReflection.All | BindingFlags.DeclaredOnly);
                if (f == null) continue;
                f.SetValue(creature, Convert.ChangeType(0, f.FieldType));
                return;
            }
        }
        Log.Error($"测试2：{creature.GetType().Name} 上找不到能写的 CurrentHp");
    }
}
