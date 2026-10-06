using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using HarmonyLib;
using TowerMaster.Core;

namespace TowerMaster;

/// <summary>
/// 房主广播的召唤清单。版本 1：测试 1b 的固定两种怪物；版本 2：召唤阶段，普通房是怪物列表，
/// 精英、Boss 房是 <see cref="Encounter"/>（遭遇类名，怪物列表为空）。
/// </summary>
internal sealed record SummonPlan(int Version, int Sequence, ulong Seed, string Act, int SourceFloor, string[] Monsters, string? Encounter = null)
{
    /// <summary>内容相同（数组逐项比较；记录类型默认按引用比较数组）。</summary>
    public bool SameAs(SummonPlan? other) =>
        other != null && Version == other.Version && Sequence == other.Sequence && Seed == other.Seed
        && Act == other.Act && SourceFloor == other.SourceFloor && Monsters.SequenceEqual(other.Monsters) && Encounter == other.Encounter;
}

/// <summary>
/// 测试 1b：房主先广播两种怪物的清单，再沿游戏原有进房、生成、战斗流程执行。
/// 保底：任何一步出错都只写日志、退回原版流程，不让异常打断游戏；
/// 各客户端拿到的是同一串动作，校验结果相同，所以退回原版时各家也一致。
/// </summary>
internal static class Test1bMixedEncounter
{
    private const string Holder = "CultistsNormal";
    private static TestSettings _settings = new();
    private static PriceBook _prices = null!;
    private static int _sent;
    private static SummonPlan? _pending, _selected;
    private static readonly ConditionalWeakTable<object, SummonPlan> Plans = new();
    internal static object Run => RuntimeNetAction.Required("RunManager").GetProperty("Instance", GameReflection.All)!.GetValue(null)!;
    private static object State => GameReflection.Get(Run, "State") ?? throw new InvalidOperationException("没有进行中的对局");
    private static ulong Seed(object state) => Convert.ToUInt64(GameReflection.Get(GameReflection.Get(state, "Rng")!, "Seed"));
    private static int Floor(object state) => Convert.ToInt32(GameReflection.Get(state, "TotalFloor"));
    private static string Act(object state) => GameReflection.Get(state, "Act")!.GetType().Name;

    internal static void Configure(TestSettings settings, PriceBook prices)
    {
        _settings = settings; _prices = prices;
        _sent = 0;
        _pending = _selected = null;
        Plans.Clear();
    }

    private static bool _patched;

    internal static void Apply(Harmony harmony, TestSettings settings, PriceBook prices)
    {
        Configure(settings, prices);
        if (_patched) return; // 只挂一次：重复挂会让清单发两遍
        _patched = true;
        RuntimeNetAction.Register(harmony);
        Patch(harmony, "RequestEnqueue", "ActionQueueSynchronizer", nameof(BeforeEnqueue), true);
        Patch(harmony, "PullNextEncounter", "ActModel", nameof(SelectEncounter), false);
        Patch(harmony, "ToMutable", "EncounterModel", nameof(BindMutable), false);
        Patch(harmony, "GenerateMonsters", Holder, nameof(MixMonsters), false);
        Patch(harmony, "GenerateMonstersWithSlots", "EncounterModel", nameof(BeforeGenerate), true);
        Patch(harmony, "GenerateMonstersWithSlots", "EncounterModel", nameof(AfterGenerate), false);
        Log.Info("测试1b：房主清单动作 → 地图移动动作 → 通用场景混搭；仅测试第一幕两种怪物");
    }

    private static void Patch(Harmony harmony, string method, string type, string callback, bool prefix)
    {
        var target = GameReflection.FindMethod(method, type) ?? throw new MissingMethodException(type, method);
        var patch = new HarmonyMethod(typeof(Test1bMixedEncounter).GetMethod(callback, GameReflection.All)!);
        harmony.Patch(target, prefix: prefix ? patch : null, postfix: prefix ? null : patch);
        Log.Info($"测试1b：已挂到 {GameReflection.Describe(target)}");
    }

    /// <summary>入队前：召唤阶段开着时交给它决定是否扣住移动；否则按测试 1b 的固定清单发送。返回 false 表示扣住。</summary>
    internal static bool BeforeEnqueue(object __instance, object __0)
    {
        try
        {
            if (__0.GetType().Name == "MoveToMapCoordAction" && SummonPhase.Enabled)
                return SummonPhase.OnMoveRequested(__instance, __0);
            SendPlan(__instance, __0);
        }
        catch (Exception e) { Log.Error("测试1b：发送召唤清单失败，这一场按原版遭遇", e); }
        return true;
    }

    private static void SendPlan(object __instance, object __0)
    {
        if (__0.GetType().Name != "MoveToMapCoordAction") return;
        var service = GameReflection.Get(__instance, "_netService")!;
        if (GameReflection.Get(service, "Type")?.ToString() == "Client") return;
        var state = State;
        var act = Act(state);
        if (!_settings.MixedMonsters.TryGetValue(act, out var monsters)) return;
        var owner = Convert.ToUInt64(GameReflection.Get(__0, "OwnerId"));
        var plan = new SummonPlan(1, ++_sent, Seed(state), act, Floor(state), monsters.ToArray());
        Validate(plan, state, false);
        var payload = JsonSerializer.Serialize(plan);
        Log.Info($"测试1b #{plan.Sequence}：房主发送 {payload}");
        // 递归调用时动作类型已变，不会再插入清单；同一个玩家队列保证它先于移动执行。
        RuntimeNetAction.Call(__instance, "RequestEnqueue", RuntimeNetAction.Create(owner, payload));
    }

    internal static void Receive(string payload, ulong owner)
    {
        if (payload.Length > 2048) throw new InvalidDataException("召唤清单过长");
        var plan = JsonSerializer.Deserialize<SummonPlan>(payload) ?? throw new InvalidDataException("空召唤清单");
        var service = GameReflection.Get(Run, "NetService")!;
        var expected = GameReflection.Get(service, "Type")?.ToString() == "Client"
            ? GameReflection.Get(service, "HostNetId") : GameReflection.Get(service, "NetId");
        if (expected == null || owner != Convert.ToUInt64(expected)) throw new InvalidDataException("召唤清单必须归属房主");
        Validate(plan, State, false);
        // 序号只用于日志：房主重启游戏后会从 1 重新编号，不能拿来判断新旧。
        // 过期清单靠种子和楼层校验拦下；同一份清单收到两次没有害处，覆盖即可。
        if (plan.SameAs(_pending)) Log.Info($"测试1b #{plan.Sequence}：重复清单，忽略");
        _pending = plan;
        Log.Info($"测试1b #{plan.Sequence}：收到清单 {payload}");
    }

    internal static void Validate(SummonPlan plan, object state, bool entered)
    {
        if (plan.Version is not (1 or 2) || plan.Sequence <= 0 || plan.Seed != Seed(state) || plan.Act != Act(state)
            || Floor(state) != plan.SourceFloor + (entered ? 1 : 0))
            throw new InvalidDataException("召唤清单版本、对局、幕或楼层不匹配");
        if (plan.Monsters == null)
            throw new InvalidDataException("清单没有怪物列表");
        if (plan.Version == 1 && (plan.Monsters.Length != 2 || plan.Monsters.Distinct().Count() != 2))
            throw new InvalidDataException("测试1b必须混搭两种不同怪物");
        if (plan.Version == 2)
        {
            // 数量、花费等规则由房主的召唤面板校验；这里只拦明显不合法的内容
            if (plan.Encounter == null && (plan.Monsters.Length is 0 or > 6))
                throw new InvalidDataException("召唤清单怪物数量不对");
            if (plan.Encounter != null && (plan.Monsters.Length > 0
                || !_prices.Acts.TryGetValue(plan.Act, out var a) || !a.Encounters.TryGetValue(plan.Encounter, out var enc) || enc.Room == RoomKind.Monster))
                throw new InvalidDataException($"清单遭遇不是本幕的精英或 Boss：{plan.Encounter}");
        }
        var monsterBase = RuntimeNetAction.Required("MonsterModel");
        foreach (var name in plan.Monsters)
        {
            var type = GameReflection.TypeNamed(name);
            if (type == null || !monsterBase.IsAssignableFrom(type) || type.IsAbstract
                || !_prices.Acts.TryGetValue(plan.Act, out var act) || !act.Monsters.ContainsKey(name))
                throw new InvalidDataException($"清单怪物不属于本幕或不存在：{name}");
        }
    }

    internal static void SelectEncounter(object __instance, ref object __result)
    {
        try { SelectEncounterCore(__instance, ref __result); }
        catch (Exception e) { Log.Error("测试1b：替换遭遇失败，这一场按原版遭遇", e); }
    }

    private static void SelectEncounterCore(object __instance, ref object __result)
    {
        var name = __result.GetType().Name;
        if (!(name.EndsWith("Normal") || name.EndsWith("Weak")))
        {
            ReplaceEliteOrBoss(name, ref __result);
            return;
        }
        if (!SummonPhase.Enabled && !_settings.MixedMonsters.ContainsKey(__instance.GetType().Name)) return;
        if (_pending == null) { Log.Warn($"测试1b：进普通房前没有收到召唤清单（读档、重连？），这一场按原版遭遇 {name}"); return; }
        var plan = _pending;
        _pending = null;
        Validate(plan, State, false);
        if (plan.Encounter != null) { Log.Warn($"测试1b #{plan.Sequence}：清单是精英或 Boss，但这是普通房 {name}，按原版"); return; }
        var holder = Model("Encounter", Holder);
        if (GameReflection.Get(holder, "HasScene") is not false
            || ((IEnumerable)GameReflection.Get(holder, "Slots")!).Cast<object>().Any())
            throw new InvalidOperationException("混搭载体必须使用无槽位的通用场景");
        __result = holder;
        _selected = plan;
        PlanStore.Save(plan);
        Log.Info($"测试1b #{plan.Sequence}：已替换 {name} → {Holder}，清单=[{string.Join(", ", plan.Monsters)}]");
    }

    /// <summary>精英、Boss 房：清单里有遭遇就整个换掉（游戏随后自己创建可变副本、生成怪物）。</summary>
    private static void ReplaceEliteOrBoss(string name, ref object __result)
    {
        var plan = _pending;
        _pending = null;
        if (plan?.Encounter == null) return;
        Validate(plan, State, false);
        var room = _prices.Acts[plan.Act].Encounters[plan.Encounter].Room;
        var originalRoom = _prices.Acts.Values.Select(a => a.Encounters.GetValueOrDefault(name)).FirstOrDefault(e => e != null)?.Room;
        if (originalRoom != null && originalRoom != room)
        {
            Log.Warn($"召唤清单 #{plan.Sequence}：清单是 {room}，房间是 {originalRoom}（{name}），按原版");
            return;
        }
        __result = Model("Encounter", plan.Encounter);
        Log.Info($"召唤清单 #{plan.Sequence}：已替换 {name} → {plan.Encounter}");
    }

    private static void BindMutable(object __instance, object __result)
    {
        try
        {
            if (__instance.GetType().Name != Holder || _selected == null) return;
            Plans.AddOrUpdate(__result, _selected);
            _selected = null;
        }
        catch (Exception e) { Log.Error("测试1b：关联召唤清单失败", e); }
    }

    private static void BeforeGenerate(object __instance, object __0)
    {
        try
        {
            if (!Plans.TryGetValue(__instance, out var plan))
            {
                // 读档或重开战斗时没有经过选遭遇：按种子和楼层从本地文件找回清单。
                if (__instance.GetType().Name != Holder) return;
                plan = PlanStore.Find(Seed(__0), Floor(__0));
                if (plan == null) return;
                Plans.AddOrUpdate(__instance, plan);
                Log.Info($"测试1b #{plan.Sequence}：从本地文件找回清单（读档？）");
            }
            Validate(plan, __0, true);
            Log.Info($"测试1b #{plan.Sequence}：开始生成，楼层={Floor(__0)}");
        }
        catch (Exception e)
        {
            Plans.Remove(__instance);
            Log.Error("测试1b：生成前校验失败，这一场按载体遭遇原本的怪物", e);
        }
    }

    private static void MixMonsters(object __instance, ref object __result)
    {
        try { MixMonstersCore(__instance, ref __result); }
        catch (Exception e) { Log.Error("测试1b：混搭怪物失败，这一场按载体遭遇原本的怪物", e); }
    }

    private static void MixMonstersCore(object __instance, ref object __result)
    {
        if (!Plans.TryGetValue(__instance, out var plan)) return;
        var monsterType = RuntimeNetAction.Required("MonsterModel");
        var tuple = typeof(ValueTuple<,>).MakeGenericType(monsterType, typeof(string));
        var list = (IList)Activator.CreateInstance(typeof(List<>).MakeGenericType(tuple))!;
        foreach (var name in plan.Monsters)
        {
            var mutable = RuntimeNetAction.Call(Model("Monster", name), "ToMutable");
            list.Add(Activator.CreateInstance(tuple, mutable, null));
        }
        __result = list;
    }

    private static void AfterGenerate(object __instance)
    {
        try
        {
            if (!Plans.TryGetValue(__instance, out var plan)) return;
            Log.Info($"测试1b #{plan.Sequence}：生成 {GameReflection.Dump(GameReflection.Get(__instance, "MonstersWithSlots"))}");
            Plans.Remove(__instance);
        }
        catch (Exception e) { Log.Error("测试1b：记录生成结果失败", e); }
    }

    private static object Model(string getter, string typeName) => RuntimeNetAction.Required("ModelDb")
        .GetMethods(BindingFlags.Public | BindingFlags.Static).Single(m => m.Name == getter && m.IsGenericMethodDefinition && m.GetParameters().Length == 0)
        .MakeGenericMethod(RuntimeNetAction.Required(typeName)).Invoke(null, null)!;
}
