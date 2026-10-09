using System.Collections;
using System.Reflection;
using System.Reflection.Emit;
using HarmonyLib;
using G = Godot;

namespace TowerMaster;

/// <summary>一件塔主遗物。</summary>
internal sealed record MasterRelicDef(string Id, string TypeName, string Title, string Description, string Flavor);

/// <summary>
/// 塔主遗物：原版真遗物（RelicModel 子类，运行时生成，和塔主牌同一个动态程序集、同一时机进 ModelDb），
/// 用原版 RelicCmd.Obtain 给塔主，出现在塔主自己的原版遗物栏、存进存档。
/// - 效果不走原版遗物钩子：各处规则代码检查「塔主有没有这件遗物」（<see cref="Has"/>，读塔主 Player.Relics，各端一致）。
/// - RelicModel.Pool 不是虚方法（按 ModelDb.AllRelicPools 查，查不到会抛异常）：Harmony 前缀给我们的遗物返回一个原版池，不把它们加进任何池，
///   所以不会被原版随机拿到。图标 Icon/IconOutline/BigIcon 同样用前缀换成 art/relic_*.png（没有就用塔主头像）。
/// - 名字、说明、风味文字合并进本地化表 relics（{Entry}.title / .description / .flavor）。
/// - 来源：塔主宝箱 3 选 1（候选用「遗物牌」走原版选牌界面，见 MasterRewards；选中后各端执行 Obtain）。
/// 依据：docs/ui-043-result.md 7.3。
/// </summary>
public static class MasterRelics
{
    internal static readonly MasterRelicDef[] Defs =
    [
        new("lucky_cat", "TowerMasterRelicLuckyCat", "招财猫", "每场战斗结算时，额外获得 1 召唤点。", "它的爪子一直在招手。招的是谁，就不好说了。"),
        new("piggy_bank", "TowerMasterRelicPiggyBank", "小金库", "拿到时，立即获得 8 召唤点（不超过上限）。", "塔主的私房钱。"),
        new("magic_hat", "TowerMasterRelicMagicHat", "魔术师礼帽", "每场战斗的第一个塔主回合，多抽 1 张牌。", "里面不止有兔子。"),
        new("energy_drink", "TowerMasterRelicEnergyDrink", "能量饮料", "每场战斗的第一个塔主回合，多 1 点能量。", "塔主也要加班。"),
        new("bento", "TowerMasterRelicBento", "怪物便当", "每场战斗的第一个塔主回合，所有敌人获得 3 点格挡。", "吃饱了才有力气挨打。"),
        new("blacklist", "TowerMasterRelicBlacklist", "黑名单", "每场战斗的第一个塔主回合，给予当前生命最高的玩家 1 层易伤。", "上面的名字每天都在变。"),
        new("fog_censer", "TowerMasterRelicFogCenser", "迷雾香炉", "玩家看不到塔主手里有几张陷阱、本场盖了几张。", "烟雾里什么都可能有。也可能什么都没有。"),
        new("stingy_purse", "TowerMasterRelicStingyPurse", "吝啬鬼钱包", "玩家躲过陷阱拿到的金币减半。", "进去容易，出来难。"),
    ];

    private static readonly Dictionary<Type, MasterRelicDef> ByType = new();
    private static readonly Dictionary<string, Type> ById = new();
    private static readonly ConditionalWeakTableSet Merged = new();

    /// <summary>没生成成功的原因（宝箱退回送塔主牌）。</summary>
    internal static string? FailReason { get; set; }
    internal static bool Enabled => ById.Count > 0 && FailReason == null;

    internal static MasterRelicDef? DefOf(object? relic) => relic != null && ByType.TryGetValue(relic.GetType(), out var d) ? d : null;
    internal static MasterRelicDef? Find(string id) => Defs.FirstOrDefault(d => d.Id == id);
    internal static bool IsOurs(object relic) => ByType.ContainsKey(relic.GetType());

    // ---------------------------------------------------------------- 生成类型（MasterCards.Register 里调，ModelDb.Init 之前）

    internal static List<Type> Emit(ModuleBuilder module, Harmony harmony)
    {
        var relicModel = GameReflection.TypesNamed("RelicModel").FirstOrDefault(t => t.IsAbstract) ?? throw new TypeLoadException("RelicModel");
        var baseCtor = relicModel.GetConstructors(GameReflection.All).FirstOrDefault(c => c.GetParameters().Length == 0)
                       ?? throw new MissingMethodException("RelicModel", ".ctor()");
        var rarity = MasterCards.AllMethods(relicModel).FirstOrDefault(m => m.Name == "get_Rarity")
                     ?? throw new MissingMethodException("RelicModel", "get_Rarity");
        var handler = typeof(MasterRelics).GetMethod(nameof(Rarity), BindingFlags.Public | BindingFlags.Static)!;
        var fallback = typeof(MasterRelics).GetMethod(nameof(Default), BindingFlags.Public | BindingFlags.Static)!;
        var types = new List<Type>();
        foreach (var def in Defs)
        {
            var tb = module.DefineType(def.TypeName, TypeAttributes.Public | TypeAttributes.Sealed, relicModel);
            var c = tb.DefineConstructor(MethodAttributes.Public, CallingConventions.Standard, Type.EmptyTypes);
            var il = c.GetILGenerator();
            il.Emit(OpCodes.Ldarg_0);
            il.Emit(OpCodes.Call, baseCtor);
            il.Emit(OpCodes.Ret);
            MasterCards.Override(tb, rarity, handler);
            foreach (var m in MasterCards.AllMethods(relicModel).Where(m => m.IsAbstract && m.Name != "get_Rarity"))
            {
                if (types.Count == 0) Log.Warn($"塔主遗物：RelicModel 的抽象成员 {m.Name} 用默认值实现");
                MasterCards.Override(tb, m, fallback);
            }
            var type = tb.CreateType()!;
            types.Add(type);
            ByType[type] = def;
            ById[def.Id] = type;
        }
        Patch(harmony, relicModel);
        Log.Info($"塔主遗物：已生成 {types.Count} 种遗物类型");
        return types;
    }

    private static object? _rarity;
    public static object? Rarity(object self, object?[] args)
    {
        if (_rarity != null) return _rarity;
        var type = RuntimeNetAction.Required("RelicRarity");
        _rarity = Enum.GetNames(type).Contains("Event") ? Enum.Parse(type, "Event") : Enum.GetValues(type).GetValue(0);
        return _rarity;
    }

    public static object? Default(object self, object?[] args) => null;

    private static void Patch(Harmony harmony, Type relicModel)
    {
        void Prefix(string getter, string handler)
        {
            var m = relicModel.GetProperty(getter, GameReflection.All)?.GetMethod;
            if (m == null) { Log.Warn($"塔主遗物：RelicModel 没有 {getter}"); return; }
            harmony.Patch(m, prefix: new HarmonyMethod(typeof(MasterRelics).GetMethod(handler, GameReflection.All)!) { priority = Priority.First });
        }
        Prefix("Pool", nameof(PoolPrefix));
        Prefix("Icon", nameof(IconPrefix));
        Prefix("IconOutline", nameof(IconPrefix));
        Prefix("BigIcon", nameof(IconPrefix));
        var getTable = RuntimeNetAction.Required("LocManager").GetMethods(GameReflection.All)
            .FirstOrDefault(m => m.Name == "GetTable" && m.GetParameters().Length == 1 && m.GetParameters()[0].ParameterType == typeof(string));
        if (getTable != null) harmony.Patch(getTable, postfix: new HarmonyMethod(typeof(MasterRelics).GetMethod(nameof(AfterGetTable), GameReflection.All)!));
    }

    private static object? _pool;

    private static bool PoolPrefix(object __instance, ref object? __result)
    {
        if (!IsOurs(__instance)) return true;
        _pool ??= (RuntimeNetAction.Required("ModelDb").GetProperty("AllRelicPools", GameReflection.All)?.GetValue(null) as IEnumerable)?.Cast<object>()
            .OrderBy(p => p.GetType().Name.Contains("Shared") ? 0 : 1).FirstOrDefault();
        __result = _pool;
        return _pool == null; // 实在没有池就让原版去查（会抛异常，日志里能看到）
    }

    private static bool IconPrefix(object __instance, ref G.Texture2D? __result)
    {
        if (DefOf(__instance) is not { } def) return true;
        __result = Art.Get("relic_" + def.Id) ?? Art.Get("master_portrait");
        return __result == null;
    }

    private static void AfterGetTable(object? __result, object[] __args)
    {
        try
        {
            if (__result == null || __args[0] as string != "relics" || !Merged.Add(__result)) return;
            var entries = new Dictionary<string, string>();
            foreach (var (type, def) in ByType)
            {
                var entry = MasterCards.Entry(type);
                entries[$"{entry}.title"] = def.Title;
                entries[$"{entry}.description"] = def.Description;
                entries[$"{entry}.flavor"] = def.Flavor;
            }
            RuntimeNetAction.Call(__result, "MergeWith", entries);
            Log.Info($"塔主遗物：本地化表 relics 补了 {entries.Count} 条");
        }
        catch (Exception e) { Log.Warn($"塔主遗物：补本地化失败：{e.Message}"); }
    }

    // ---------------------------------------------------------------- 拥有、获得（各端）

    /// <summary>塔主有没有这件遗物（读塔主 Player.Relics，各端一致；测试里没有遗物）。</summary>
    internal static bool Has(string id)
    {
        try
        {
            if (!Enabled || MasterHand.MasterPlayer() is not { } master) return false;
            return (GameReflection.Get(master, "Relics") as IEnumerable)?.Cast<object>().Any(r => DefOf(r)?.Id == id) == true;
        }
        catch { return false; }
    }

    internal static List<string> Owned()
    {
        try
        {
            if (!Enabled || MasterHand.MasterPlayer() is not { } master) return [];
            return (GameReflection.Get(master, "Relics") as IEnumerable)?.Cast<object>().Select(r => DefOf(r)?.Id).OfType<string>().ToList() ?? [];
        }
        catch { return []; }
    }

    /// <summary>给塔主一件遗物：ModelDb 规范实例 → ToMutable → RelicCmd.Obtain（原版不广播，所以各端在同一条指令里各自执行）。</summary>
    internal static async Task Obtain(object master, string id, string tag)
    {
        if (!ById.TryGetValue(id, out var type)) { Log.Warn($"{tag}：没有塔主遗物 {id}"); return; }
        var relic = RuntimeNetAction.Call(MasterCards.Canonical(type), "ToMutable");
        var obtain = RuntimeNetAction.Required("RelicCmd").GetMethods(BindingFlags.Public | BindingFlags.Static)
            .First(m => m.Name == "Obtain" && !m.IsGenericMethod && m.GetParameters().Length == 3);
        await (Task)obtain.Invoke(null, [relic, master, -1])!;
        Log.Info($"{tag}：塔主获得遗物「{Find(id)?.Title}」");
    }

    /// <summary>引用相等的「处理过」集合（本地化表对象）。</summary>
    private sealed class ConditionalWeakTableSet
    {
        private readonly System.Runtime.CompilerServices.ConditionalWeakTable<object, object> _t = new();
        public bool Add(object o)
        {
            if (_t.TryGetValue(o, out _)) return false;
            _t.Add(o, true);
            return true;
        }
    }
}
