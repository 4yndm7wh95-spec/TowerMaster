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
internal sealed record SummonPlan(int Version, int Sequence, ulong Seed, string Act, int SourceFloor, string[] Monsters, string? Encounter = null, string? Coord = null)
{
    /// <summary>内容相同（数组逐项比较；记录类型默认按引用比较数组）。</summary>
    public bool SameAs(SummonPlan? other) =>
        other != null && Version == other.Version && Sequence == other.Sequence && Seed == other.Seed
        && Act == other.Act && SourceFloor == other.SourceFloor && Monsters.SequenceEqual(other.Monsters) && Encounter == other.Encounter
        && Coord == other.Coord;
}

/// <summary>
/// 测试 1b：房主先广播两种怪物的清单，再沿游戏原有进房、生成、战斗流程执行。
/// 保底：任何一步出错都只写日志、退回原版流程，不让异常打断游戏；
/// 各客户端拿到的是同一串动作，校验结果相同，所以退回原版时各家也一致。
/// </summary>
internal static class Test1bMixedEncounter
{
    /// <summary>普通房混搭的载体：无专用场景、无槽位的普通遭遇。</summary>
    private const string Holder = "CultistsNormal";
    private static TestSettings _settings = new();
    private static PriceBook _prices = null!;
    private static SummonRules _rules = null!;
    private static int _sent;
    private static SummonPlan? _pending, _selected;
    private static string? _selectedType;
    private static string? _eliteHolder;
    private static readonly ConditionalWeakTable<object, SummonPlan> Plans = new();
    /// <summary>召唤出来的怪物模型 → 「水土不服」血量倍数；创建生物时按它降血。</summary>
    private static readonly ConditionalWeakTable<object, StrongBox<double>> Weakened = new();
    internal static object Run => RuntimeNetAction.Required("RunManager").GetProperty("Instance", GameReflection.All)!.GetValue(null)!;
    private static object State => GameReflection.Get(Run, "State") ?? throw new InvalidOperationException("没有进行中的对局");
    private static ulong Seed(object state) => Convert.ToUInt64(GameReflection.Get(GameReflection.Get(state, "Rng")!, "Seed"));
    private static int Floor(object state) => Convert.ToInt32(GameReflection.Get(state, "TotalFloor"));
    private static string Act(object state) => GameReflection.Get(state, "Act")!.GetType().Name;

    internal static void Configure(TestSettings settings, PriceBook prices)
    {
        _settings = settings; _prices = prices;
        _rules = new SummonRules(new TowerMasterConfig(), prices);
        _sent = 0;
        _pending = _selected = null;
        _selectedType = _eliteHolder = null;
        Plans.Clear();
        Weakened.Clear();
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
        Patch(harmony, "GenerateMonstersWithSlots", "EncounterModel", nameof(BeforeGenerate), true);
        Patch(harmony, "GenerateMonstersWithSlots", "EncounterModel", nameof(AfterGenerate), false);
        Patch(harmony, "CreateCreature", "CombatState", nameof(AfterCreateCreature), false);
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
        var plan = new SummonPlan(1, ++_sent, Seed(state), act, Floor(state), monsters.ToArray(), Coord: CoordKey(GameReflection.Get(__0, "_destination")));
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

    /// <summary>地图坐标写成 "列,行"；拿不到时为 null。</summary>
    internal static string? CoordKey(object? coord) =>
        coord == null || GameReflection.Get(coord, "col") is not { } col || GameReflection.Get(coord, "row") is not { } row ? null : $"{col},{row}";

    /// <param name="checkFloor">重连恢复时按坐标找回的清单，楼层可能已经变了，不查楼层。</param>
    internal static void Validate(SummonPlan plan, object state, bool entered, bool checkFloor = true)
    {
        if (plan.Version is not (1 or 2) || plan.Sequence <= 0 || plan.Seed != Seed(state) || plan.Act != Act(state)
            || checkFloor && Floor(state) != plan.SourceFloor + (entered ? 1 : 0))
            throw new InvalidDataException("召唤清单版本、对局、幕或楼层不匹配");
        if (plan.Monsters == null)
            throw new InvalidDataException("清单没有怪物列表");
        if (plan.Version == 1 && (plan.Monsters.Length != 2 || plan.Monsters.Distinct().Count() != 2))
            throw new InvalidDataException("测试1b必须混搭两种不同怪物");
        if (plan.Version == 2)
        {
            // 数量、花费等规则由房主的召唤面板校验；这里只拦明显不合法的内容
            if (plan.Monsters.Length > 6 || plan.Encounter == null && plan.Monsters.Length == 0)
                throw new InvalidDataException("召唤清单怪物数量不对");
            if (plan.Encounter != null
                && (!_prices.Acts.TryGetValue(plan.Act, out var a) || !a.Encounters.TryGetValue(plan.Encounter, out var enc) || enc.Room != RoomKind.Boss))
                throw new InvalidDataException($"清单遭遇不是本幕的 Boss：{plan.Encounter}");
        }
        var monsterBase = RuntimeNetAction.Required("MonsterModel");
        foreach (var name in plan.Monsters)
        {
            var type = GameReflection.TypeNamed(name);
            // 版本 1（测试 1b）只能用本幕的怪；版本 2（召唤阶段）任何幕的普通、精英怪都行
            bool known = plan.Version == 1
                ? _prices.Acts.TryGetValue(plan.Act, out var act) && act.Monsters.ContainsKey(name)
                : _rules.IsSummonable(name);
            if (type == null || !monsterBase.IsAssignableFrom(type) || type.IsAbstract || !known)
                throw new InvalidDataException($"清单怪物不能召唤或不存在：{name}");
        }
    }

    internal static void SelectEncounter(object __instance, ref object __result)
    {
        try { SelectEncounterCore(__instance, ref __result); }
        catch (Exception e) { Log.Error("测试1b：替换遭遇失败，这一场按原版遭遇", e); }
    }

    /// <summary>原版遭遇的房间类型（按价格表查；查不到按名字猜）。</summary>
    private static RoomKind RoomOf(string encounter) =>
        _prices.Acts.Values.Select(a => a.Encounters.GetValueOrDefault(encounter)).FirstOrDefault(e => e != null)?.Room
        ?? (encounter.EndsWith("Boss") ? RoomKind.Boss : encounter.EndsWith("Elite") ? RoomKind.Elite : RoomKind.Monster);

    /// <summary>
    /// 精英房混搭的载体：任何一幕里第一个（按名字排序）无专用场景、无槽位的精英遭遇。
    /// 用精英遭遇当载体，房间类型、奖励（遗物、金币）就还是精英的；各端按同样的数据选出同一个。
    /// </summary>
    private static string? EliteHolder => _eliteHolder ??= _prices.Acts.Values
        .SelectMany(a => a.Encounters).Where(e => e.Value.Room == RoomKind.Elite).Select(e => e.Key)
        .Distinct().Order(StringComparer.Ordinal).FirstOrDefault(SummonPhase.IsSceneless);

    private static void SelectEncounterCore(object __instance, ref object __result)
    {
        var name = __result.GetType().Name;
        var room = RoomOf(name);
        if (room == RoomKind.Monster && !SummonPhase.Enabled && !_settings.MixedMonsters.ContainsKey(__instance.GetType().Name)) return;

        var plan = _pending;
        _pending = null;
        bool restored = false;
        if (plan == null)
        {
            // 重连或读档重建房间：没有经过清单动作，按「种子 + 幕 + 地图坐标」从本地文件找回
            plan = RestoreByCoord();
            restored = plan != null;
        }
        if (plan == null)
        {
            if (room != RoomKind.Monster) return;
            if (SummonPhase.Enabled) Log.Info($"测试1b：这一场没有召唤清单（塔主按原版出场或「?」房间），按原版遭遇 {name}");
            else Log.Warn($"测试1b：进普通房前没有收到召唤清单（读档、重连？），这一场按原版遭遇 {name}");
            return;
        }
        Validate(plan, State, false, checkFloor: !restored);
        if (restored) Log.Info($"测试1b #{plan.Sequence}：重连或读档，按坐标 {plan.Coord} 找回召唤清单");

        if (room == RoomKind.Boss)
        {
            ReplaceBoss(name, plan, restored, ref __result);
            return;
        }
        if (plan.Encounter != null) { Log.Warn($"测试1b #{plan.Sequence}：清单是 Boss，但这是{room}房 {name}，按原版"); return; }

        var holderName = room == RoomKind.Elite ? EliteHolder : Holder;
        if (holderName == null) { Log.Error($"测试1b #{plan.Sequence}：找不到无专用场景的精英遭遇当载体，这一场按原版 {name}"); return; }
        var holder = Model("Encounter", holderName);
        if (GameReflection.Get(holder, "HasScene") is not false
            || ((IEnumerable)GameReflection.Get(holder, "Slots")!).Cast<object>().Any())
            throw new InvalidOperationException($"混搭载体 {holderName} 必须使用无槽位的通用场景");
        __result = holder;
        _selected = plan;
        _selectedType = holderName;
        if (!restored) PlanStore.Save(plan);
        Log.Info($"测试1b #{plan.Sequence}：已替换 {name} → {holderName}，清单=[{string.Join(", ", plan.Monsters)}]");
    }

    private static SummonPlan? RestoreByCoord()
    {
        var state = State;
        var coord = CoordKey(GameReflection.Get(state, "CurrentMapCoord"));
        return coord == null ? null : PlanStore.FindByCoord(Seed(state), Act(state), coord);
    }

    /// <summary>
    /// Boss 房：塔主选的 Boss 和原版不同就换掉（游戏随后自己创建可变副本、生成怪物），相同就不动；
    /// 清单里另加的怪在生成后追加到 Boss 后面（<see cref="AfterGenerate"/>）。
    /// </summary>
    private static void ReplaceBoss(string name, SummonPlan plan, bool restored, ref object __result)
    {
        if (plan.Encounter == null) return;
        if (!restored) PlanStore.Save(plan);
        if (plan.Encounter == name) Log.Info($"召唤清单 #{plan.Sequence}：塔主选的就是原版 {name}，不替换");
        else
        {
            __result = Model("Encounter", plan.Encounter);
            Log.Info($"召唤清单 #{plan.Sequence}：已替换 {name} → {plan.Encounter}");
        }
        if (plan.Monsters.Length > 0)
        {
            _selected = plan;
            _selectedType = plan.Encounter;
        }
    }

    private static void BindMutable(object __instance, object __result)
    {
        try
        {
            if (_selected == null || __instance.GetType().Name != _selectedType) return;
            Plans.AddOrUpdate(__result, _selected);
            _selected = null;
            _selectedType = null;
        }
        catch (Exception e) { Log.Error("测试1b：关联召唤清单失败", e); }
    }

    private static bool IsHolder(object encounter) => encounter.GetType().Name is var n && (n == Holder || n == EliteHolder);

    private static void BeforeGenerate(object __instance, object __0)
    {
        try
        {
            if (!Plans.TryGetValue(__instance, out var plan))
            {
                // 读档或重开战斗时没有经过选遭遇：按种子和楼层从本地文件找回清单。
                if (!IsHolder(__instance)) return;
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

    /// <summary>
    /// 生成之后改怪物列表：载体（普通、精英房）整个换成清单里的怪；Boss 房在 Boss 后面追加。
    /// 每只召唤的怪记下「水土不服」血量倍数，创建生物时降血（<see cref="AfterCreateCreature"/>）。
    /// </summary>
    private static void AfterGenerate(object __instance)
    {
        try
        {
            if (!Plans.TryGetValue(__instance, out var plan)) return;
            Plans.Remove(__instance);
            var monsterType = RuntimeNetAction.Required("MonsterModel");
            var tuple = typeof(ValueTuple<,>).MakeGenericType(monsterType, typeof(string));
            var list = (IList)Activator.CreateInstance(typeof(List<>).MakeGenericType(tuple))!;
            if (!IsHolder(__instance) && GameReflection.Get(__instance, "MonstersWithSlots") is IEnumerable existing)
                foreach (var item in existing) list.Add(item); // Boss 本体保留

            int actNo = _prices.Act(plan.Act).ActNo;
            foreach (var name in plan.Monsters)
            {
                var mutable = RuntimeNetAction.Call(Model("Monster", name), "ToMutable");
                double factor = plan.Version == 2 ? _rules.HpFactor(name, actNo) : 1;
                if (factor < 1) Weakened.AddOrUpdate(mutable, new StrongBox<double>(factor));
                list.Add(Activator.CreateInstance(tuple, mutable, null));
            }
            SetMonstersWithSlots(__instance, list);
            Log.Info($"测试1b #{plan.Sequence}：生成 {GameReflection.Dump(GameReflection.Get(__instance, "MonstersWithSlots"))}");
        }
        catch (Exception e) { Log.Error("测试1b：改写怪物列表失败，这一场按遭遇原本的怪物", e); }
    }

    /// <summary>写回遭遇的怪物列表：游戏里是私有字段 _monstersWithSlots，假游戏里是私有 setter。</summary>
    private static void SetMonstersWithSlots(object encounter, object list)
    {
        for (var t = encounter.GetType(); t != null; t = t.BaseType)
        {
            var prop = t.GetProperty("MonstersWithSlots", GameReflection.All | BindingFlags.DeclaredOnly);
            if (prop?.SetMethod != null) { prop.SetValue(encounter, list); return; }
            foreach (var field in new[] { "_monstersWithSlots", "<MonstersWithSlots>k__BackingField" })
            {
                var f = t.GetField(field, GameReflection.All | BindingFlags.DeclaredOnly);
                if (f != null) { f.SetValue(encounter, list); return; }
            }
        }
        throw new MissingFieldException("EncounterModel", "_monstersWithSlots");
    }

    /// <summary>「水土不服」：跨幕召唤的怪创建成生物后，最大生命和当前生命乘倍数（各端用同一个清单算出同一个数）。</summary>
    private static void AfterCreateCreature(object[] __args, object? __result)
    {
        try
        {
            if (__result == null || __args.Length == 0 || __args[0] == null || !Weakened.TryGetValue(__args[0], out var box)) return;
            int max = Convert.ToInt32(GameReflection.Get(__result, "MaxHp"));
            int weakened = Math.Max(1, (int)Math.Round(max * box.Value, MidpointRounding.AwayFromZero));
            foreach (var field in new[] { "_maxHp", "<MaxHp>k__BackingField" }) if (GameReflection.SetField(__result, field, weakened)) break;
            foreach (var field in new[] { "_currentHp", "<CurrentHp>k__BackingField" }) if (GameReflection.SetField(__result, field, weakened)) break;
            Log.Info($"召唤：{__args[0].GetType().Name} 水土不服，生命 {max} → {weakened}");
        }
        catch (Exception e) { Log.Error("召唤：调整跨幕怪物生命失败（这只怪满血出场）", e); }
    }

    internal static object Model(string getter, string typeName) => RuntimeNetAction.Required("ModelDb")
        .GetMethods(BindingFlags.Public | BindingFlags.Static).Single(m => m.Name == getter && m.IsGenericMethodDefinition && m.GetParameters().Length == 0)
        .MakeGenericMethod(RuntimeNetAction.Required(typeName)).Invoke(null, null)!;
}
