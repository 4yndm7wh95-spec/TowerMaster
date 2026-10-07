using System.Collections;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using HarmonyLib;
using TowerMaster.Core;
using G = Godot;

namespace TowerMaster;

/// <summary>一张塔主牌的定义。Key 形如「act:block@2」「trap:harden@1」（@ 后是等级：行动牌 = 幕数，陷阱 = 陷阱等级）。</summary>
internal sealed record MasterCardDef(string Key, string TypeName, string Title, string Description, int Cost,
    int CardType, int TargetType, bool Unplayable, string Art, string Op, int Tier);

/// <summary>
/// 塔主的真实卡牌（用户要求：塔主的牌是游戏里真正的牌，原版牌组界面能看到，不是借卡框的面板）。
///
/// 做法（依据 docs/master-cards-research.md）：
/// - mod 入口在 ModelDb.Init 之前运行（OneTimeInitialization.ExecuteVeryEarly → ModManager.Initialize），
///   所以在入口里用 Reflection.Emit 生成 CardModel 子类，挂到 ReflectionHelper.ModTypes 的结果里，
///   ModelDb.Init 就会像原版卡一样建规范实例、编号，联机编号缓存（ModelIdSerializationCache）也包含它们。
/// - 每张牌一个类型（行动牌 9 种 × 3 幕，陷阱 10 种 × 3 级）：说明文字固定，不用 DynamicVar。
/// - 标题重写 Title；说明合并进本地化表 cards（LocTable.MergeWith，在 LocManager.GetTable 之后补）。
/// - 卡池（Pool / VisualCardPool）借无色卡池，但不加进卡池列表，所以不会出现在奖励、商店、随机生成里；图鉴不显示。
/// - 卡图：PortraitPath 用原版的「缺图」路径保证能加载，NCard.UpdatePortrait 之后换成 mod 目录 art/*.png。
/// - 陷阱牌带「不能打出」关键词。
/// 第一阶段只做到「牌组里是塔主牌」；战斗中用原版手牌打出要等塔主在战斗里活着（见 docs/master-cards-plan.md 第二阶段）。
/// 类是 public：动态生成的卡牌类型要调用这里的 public 静态方法，跨程序集调 internal 类会被拒绝。
/// </summary>
public static class MasterCards
{
    private static readonly Dictionary<Type, MasterCardDef> ByType = new();
    private static readonly Dictionary<string, Type> ByKey = new();
    private static Type[] _types = [];
    private static bool _registered;

    internal static bool Enabled => _registered;
    internal static IReadOnlyCollection<Type> Types => _types;
    internal static MasterCardDef? DefOf(object? card) => card != null && ByType.TryGetValue(card.GetType(), out var d) ? d : null;
    public static Type? TypeOf(string key) => ByKey.GetValueOrDefault(key);

    // ---------------------------------------------------------------- 牌表

    private static readonly (string Op, string Name, string Art, int Target)[] ActionOps =
    [
        ("block", "加固", "act_block", 2), ("heal", "治疗", "act_heal", 2), ("strength", "激励", "act_strength", 2),
        ("strength_all", "战吼", "act_strength_all", 3), ("weak", "虚弱", "act_weak", 6), ("vulnerable", "易伤", "act_vulnerable", 6),
        ("frail", "脆弱", "act_frail", 6), ("dazed", "晕眩", "act_dazed", 6),
    ];

    /// <summary>新一局塔主的牌组（每幕换成对应等级）。</summary>
    internal static readonly string[] StartingActions = ["block", "block", "heal", "strength", "strength_all", "weak", "vulnerable", "frail", "dazed"];

    internal static List<MasterCardDef> BuildDefs(ThreatPrices p)
    {
        var defs = new List<MasterCardDef>();
        foreach (var (op, name, art, target) in ActionOps)
            for (int act = 1; act <= 3; act++)
            {
                int cost = op switch
                {
                    "block" => p.BlockCost, "heal" => p.HealCost, "strength" => p.StrengthCost, "strength_all" => p.StrengthAllCost,
                    "dazed" => p.DazedCost, _ => p.DebuffCost,
                };
                string desc = op switch
                {
                    "block" => $"选择一名敌人，使其获得 {TowerMasterConfig.ByAct(p.BlockAmount, act)} 点格挡。",
                    "heal" => $"选择一名敌人，使其回复 {p.HealPercent}% 最大生命值。\n每名敌人每场战斗最多 {p.HealPerMonsterPerBattle} 次。",
                    "strength" => $"选择一名敌人，使其获得 {TowerMasterConfig.ByAct(p.StrengthAmount, act)} 点力量。",
                    "strength_all" => $"所有敌人获得 {p.StrengthAllAmount} 点力量。\n每场战斗限 {p.StrengthAllPerBattle} 次。",
                    "weak" => $"给予一名玩家 {p.DebuffStacks} 层虚弱。",
                    "vulnerable" => $"给予一名玩家 {p.DebuffStacks} 层易伤。",
                    "frail" => $"给予一名玩家 {p.DebuffStacks} 层脆弱。",
                    _ => "将 1 张晕眩放入一名玩家的抽牌堆。",
                };
                defs.Add(new($"act:{op}@{act}", $"TowerMaster{Pascal(op)}{act}", act > 1 ? $"{name}+{act - 1}" : name, desc,
                    cost, CardType: 2, target, Unplayable: false, art, op, act));
            }
        foreach (var t in TrapCatalog.All)
            for (int tier = 1; tier <= 3; tier++)
            {
                var card = new TrapCard(t.Id, tier);
                defs.Add(new($"trap:{t.Id}@{tier}", $"TowerMasterTrap{Pascal(t.Id)}{tier}", card.Name, "陷阱。召唤时盖下。\n" + card.Describe(),
                    -1, CardType: 2, TargetType: 0, Unplayable: true, $"trap_{t.Id}", "trap", tier));
            }
        return defs;
    }

    private static string Pascal(string id) => string.Concat(id.Split('_').Select(w => char.ToUpperInvariant(w[0]) + w[1..]));

    // ---------------------------------------------------------------- 注册（mod 入口，ModelDb.Init 之前）

    internal static void Register(Harmony harmony, TowerMasterConfig config)
    {
        if (_registered) return;
        var cardModel = GameReflection.TypesNamed("CardModel").FirstOrDefault(t => t.IsAbstract) ?? throw new TypeLoadException("CardModel");
        var ctor = cardModel.GetConstructors(GameReflection.All).FirstOrDefault(c => c.GetParameters().Length == 5)
                   ?? throw new MissingMethodException("CardModel", ".ctor(int, CardType, CardRarity, TargetType, bool)");
        var module = AssemblyBuilder.DefineDynamicAssembly(new AssemblyName("TowerMaster.Cards"), AssemblyBuilderAccess.Run)
            .DefineDynamicModule("TowerMaster.Cards");

        var overrides = new Dictionary<string, string>
        {
            ["get_Title"] = nameof(Title),
            ["get_PortraitPath"] = nameof(PortraitPath),
            ["get_Pool"] = nameof(Pool),
            ["get_VisualCardPool"] = nameof(Pool),
            ["get_CanonicalKeywords"] = nameof(Keywords),
            ["get_CanBeGeneratedInCombat"] = nameof(False),
            ["get_CanBeGeneratedByModifiers"] = nameof(False),
            ["get_MaxUpgradeLevel"] = nameof(Zero),
            ["OnPlay"] = nameof(OnPlay),
        };
        var virtuals = AllMethods(cardModel).Where(m => m.IsVirtual && !m.IsFinal).ToList();
        var types = new List<Type>();
        foreach (var def in BuildDefs(config.Threat))
        {
            var tb = module.DefineType(def.TypeName, TypeAttributes.Public | TypeAttributes.Sealed, cardModel);
            var c = tb.DefineConstructor(MethodAttributes.Public, CallingConventions.Standard, Type.EmptyTypes);
            var il = c.GetILGenerator();
            il.Emit(OpCodes.Ldarg_0);
            il.Emit(OpCodes.Ldc_I4, def.Cost);
            il.Emit(OpCodes.Ldc_I4, def.CardType);
            il.Emit(OpCodes.Ldc_I4, 7); // CardRarity.Token：不属于任何正常稀有度，避免被当成可生成的牌
            il.Emit(OpCodes.Ldc_I4, def.TargetType);
            il.Emit(OpCodes.Ldc_I4_0); // shouldShowInCardLibrary = false
            il.Emit(OpCodes.Call, ctor);
            il.Emit(OpCodes.Ret);
            foreach (var (name, handler) in overrides)
            {
                var original = virtuals.FirstOrDefault(m => m.Name == name);
                if (original == null) { if (types.Count == 0) Log.Warn($"塔主牌：CardModel 没有可重写的 {name}，跳过"); continue; }
                Override(tb, original, handler);
            }
            foreach (var m in AllMethods(cardModel).Where(m => m.IsAbstract && !overrides.ContainsKey(m.Name)))
                Override(tb, m, nameof(Default)); // 万一还有抽象成员：返回默认值（日志里列出来）
            var type = tb.CreateType()!;
            types.Add(type);
            ByType[type] = def;
            ByKey[def.Key] = type;
        }
        foreach (var m in AllMethods(cardModel).Where(m => m.IsAbstract)) Log.Warn($"塔主牌：CardModel 的抽象成员 {m.Name} 用默认值实现");
        _types = types.ToArray();
        ModAssociation.Associate(types[0].Assembly);
        var getter = RuntimeNetAction.Required("ReflectionHelper").GetProperty("ModTypes", GameReflection.All)?.GetMethod
                     ?? throw new MissingMethodException("ReflectionHelper.ModTypes");
        harmony.Patch(getter, postfix: new HarmonyMethod(typeof(MasterCards).GetMethod(nameof(ModTypesPostfix), GameReflection.All)!));
        PatchLoc(harmony);
        PatchPortrait(harmony);
        MasterDeck.Apply(harmony);
        _registered = true;
        Log.Info($"塔主牌：已生成 {types.Count} 种卡牌类型（{types[0].Name} …），等 ModelDb.Init 收录");
    }

    private static IEnumerable<MethodInfo> AllMethods(Type type)
    {
        var seen = new HashSet<string>();
        for (var t = type; t != null && t != typeof(object); t = t.BaseType)
            foreach (var m in t.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly))
                if (seen.Add(m.Name + "(" + string.Join(",", m.GetParameters().Select(p => p.ParameterType.FullName)) + ")")) yield return m;
    }

    private static void ModTypesPostfix(ref Type[] __result) => __result = __result.Concat(_types).Distinct().ToArray();

    /// <summary>重写一个虚方法：把 this 和参数打包成 object[]，转给 <see cref="MasterCards"/> 的静态方法 handler(object self, object?[] args)。</summary>
    private static void Override(TypeBuilder tb, MethodInfo original, string handler)
    {
        var access = original.Attributes & MethodAttributes.MemberAccessMask;
        if (access == MethodAttributes.FamORAssem) access = MethodAttributes.Family; // 跨程序集重写 protected internal 只能写 protected
        var attrs = access | MethodAttributes.Virtual | MethodAttributes.HideBySig | (original.Attributes & MethodAttributes.SpecialName);
        var ps = original.GetParameters();
        var mb = tb.DefineMethod(original.Name, attrs, original.ReturnType, ps.Select(p => p.ParameterType).ToArray());
        var il = mb.GetILGenerator();
        il.Emit(OpCodes.Ldarg_0);
        il.Emit(OpCodes.Ldc_I4, ps.Length);
        il.Emit(OpCodes.Newarr, typeof(object));
        for (int i = 0; i < ps.Length; i++)
        {
            il.Emit(OpCodes.Dup);
            il.Emit(OpCodes.Ldc_I4, i);
            il.Emit(OpCodes.Ldarg, i + 1);
            if (ps[i].ParameterType.IsValueType) il.Emit(OpCodes.Box, ps[i].ParameterType);
            il.Emit(OpCodes.Stelem_Ref);
        }
        il.Emit(OpCodes.Call, typeof(MasterCards).GetMethod(handler, BindingFlags.Public | BindingFlags.Static)!);
        if (original.ReturnType == typeof(void)) il.Emit(OpCodes.Pop);
        else if (original.ReturnType.IsValueType)
        {
            // handler 返回 null 时给默认值
            var local = il.DeclareLocal(typeof(object));
            var notNull = il.DefineLabel();
            var end = il.DefineLabel();
            il.Emit(OpCodes.Stloc, local);
            il.Emit(OpCodes.Ldloc, local);
            il.Emit(OpCodes.Brtrue_S, notNull);
            var tmp = il.DeclareLocal(original.ReturnType);
            il.Emit(OpCodes.Ldloca, tmp);
            il.Emit(OpCodes.Initobj, original.ReturnType);
            il.Emit(OpCodes.Ldloc, tmp);
            il.Emit(OpCodes.Br_S, end);
            il.MarkLabel(notNull);
            il.Emit(OpCodes.Ldloc, local);
            il.Emit(OpCodes.Unbox_Any, original.ReturnType);
            il.MarkLabel(end);
        }
        else il.Emit(OpCodes.Castclass, original.ReturnType);
        il.Emit(OpCodes.Ret);
        tb.DefineMethodOverride(mb, original);
    }

    // ---------------------------------------------------------------- 重写的成员（动态类型调用，必须 public）

    public static object? Title(object self, object?[] args) => DefOf(self)?.Title;

    private static string? _missingPortrait;
    public static object? PortraitPath(object self, object?[] args)
    {
        _missingPortrait ??= GameReflection.TypesNamed("CardModel").First(t => t.IsAbstract)
            .GetProperty("MissingPortraitPath", GameReflection.All)?.GetValue(null) as string ?? "";
        return _missingPortrait;
    }

    private static object? _pool;
    public static object? Pool(object self, object?[] args)
    {
        if (_pool != null) return _pool;
        var pools = RuntimeNetAction.Required("ModelDb").GetProperty("AllSharedCardPools", GameReflection.All)?.GetValue(null) as IEnumerable;
        _pool = pools?.Cast<object>().FirstOrDefault(p => p.GetType().Name.Contains("Colorless"))
                ?? throw new InvalidOperationException("塔主牌：找不到无色卡池");
        return _pool;
    }

    private static Array? _unplayable, _noKeywords;
    public static object? Keywords(object self, object?[] args)
    {
        var keyword = RuntimeNetAction.Required("CardKeyword");
        if (DefOf(self)?.Unplayable == true)
        {
            if (_unplayable == null)
            {
                _unplayable = Array.CreateInstance(keyword, 1);
                _unplayable.SetValue(Enum.Parse(keyword, "Unplayable"), 0);
            }
            return _unplayable;
        }
        return _noKeywords ??= Array.CreateInstance(keyword, 0);
    }

    public static object? False(object self, object?[] args) => false;
    public static object? Zero(object self, object?[] args) => 0;
    public static object? Default(object self, object?[] args) => null;

    /// <summary>打出塔主牌（各端都执行，原版 PlayCardAction 负责同步）。第二阶段塔主能在战斗中出牌后才会走到这里。</summary>
    public static object? OnPlay(object self, object?[] args) => Play(self, args[0]!, args[1]!);

    private static async Task Play(object self, object context, object cardPlay)
    {
        var def = DefOf(self);
        if (def == null || def.Unplayable) return;
        var target = GameReflection.Get(cardPlay, "Target");
        var p = ModEntry.Active.Threat;
        try
        {
            switch (def.Op)
            {
                case "block" when target != null:
                    await ThreatPhase.GainBlock(target, TowerMasterConfig.ByAct(p.BlockAmount, def.Tier));
                    break;
                case "heal" when target != null:
                    await ThreatPhase.Heal(target, Math.Max(1, Convert.ToInt32(GameReflection.Get(target, "MaxHp")) * p.HealPercent / 100));
                    break;
                case "strength" when target != null:
                    await ThreatPhase.ApplyPowerWith("StrengthPower", context, target, TowerMasterConfig.ByAct(p.StrengthAmount, def.Tier));
                    break;
                case "strength_all":
                    if (ThreatPhase.CombatState() is { } combat)
                        foreach (var e in ((GameReflection.Get(combat, "Enemies") as IEnumerable)?.Cast<object>() ?? []).ToList())
                            if (GameReflection.Get(e, "IsDead") is not true) await ThreatPhase.ApplyPowerWith("StrengthPower", context, e, p.StrengthAllAmount);
                    break;
                case "weak" or "vulnerable" or "frail" when target != null:
                    await ThreatPhase.ApplyPowerWith(def.Op switch { "weak" => "WeakPower", "vulnerable" => "VulnerablePower", _ => "FrailPower" },
                        context, target, p.DebuffStacks);
                    break;
                case "dazed" when target != null:
                    await ThreatPhase.AddDazed(target);
                    break;
            }
            Log.Info($"塔主牌：打出 {def.Title}{(target != null ? $" → {GameReflection.Get(target, "Monster")?.GetType().Name ?? Test2MasterOffField.NetIdOf(target)?.ToString()}" : "")}");
        }
        catch (Exception e) { Log.Error($"塔主牌：{def.Title} 效果失败", e); }
    }

    // ---------------------------------------------------------------- 本地化：cards 表里补标题和说明

    private static readonly ConditionalWeakTable<object, object> Merged = new();

    private static void PatchLoc(Harmony harmony)
    {
        var getTable = RuntimeNetAction.Required("LocManager").GetMethods(GameReflection.All)
            .FirstOrDefault(m => m.Name == "GetTable" && m.GetParameters().Length == 1 && m.GetParameters()[0].ParameterType == typeof(string));
        if (getTable == null) { Log.Warn("塔主牌：找不到 LocManager.GetTable，卡牌说明会缺"); return; }
        harmony.Patch(getTable, postfix: new HarmonyMethod(typeof(MasterCards).GetMethod(nameof(AfterGetTable), GameReflection.All)!));
    }

    private static void AfterGetTable(object? __result, object[] __args)
    {
        try
        {
            if (__result == null || __args[0] as string != "cards" || Merged.TryGetValue(__result, out _)) return;
            Merged.Add(__result, true); // 先登记，免得 MergeWith 里再调 GetTable 时递归
            var entries = new Dictionary<string, string>();
            foreach (var (type, def) in ByType)
            {
                var entry = Entry(type);
                entries[$"{entry}.title"] = def.Title;
                entries[$"{entry}.description"] = def.Description;
            }
            RuntimeNetAction.Call(__result, "MergeWith", entries);
            Log.Info($"塔主牌：本地化表 cards 补了 {entries.Count} 条（例 {entries.Keys.First()}）");
        }
        catch (Exception e) { Log.Warn($"塔主牌：补本地化失败：{e.Message}"); }
    }

    internal static string Entry(Type type) =>
        RuntimeNetAction.Required("ModelDb").GetMethod("GetEntry", GameReflection.All, [typeof(Type)])?.Invoke(null, [type]) as string ?? type.Name;

    // ---------------------------------------------------------------- 卡图：原版卡面刷新卡图后换成我们的图

    private static void PatchPortrait(Harmony harmony)
    {
        var update = GameReflection.FindMethod("UpdatePortrait", "NCard");
        if (update == null) { Log.Warn("塔主牌：找不到 NCard.UpdatePortrait，卡图用原版缺图"); return; }
        harmony.Patch(update, postfix: new HarmonyMethod(typeof(MasterCards).GetMethod(nameof(AfterUpdatePortrait), GameReflection.All)!));
    }

    private static void AfterUpdatePortrait(object __instance)
    {
        try
        {
            if (DefOf(GameReflection.Get(__instance, "Model")) is not { } def || Art.Get(def.Art) is not { } texture) return;
            if (__instance is G.Node node && node.GetNodeOrNull<G.TextureRect>("%Portrait") is { } portrait) portrait.Texture = texture;
        }
        catch (Exception e) { Log.Warn($"塔主牌：换卡图失败：{e.Message}"); }
    }

    /// <summary>规范实例（ModelDb 里的那一份）。</summary>
    internal static object Canonical(Type type) =>
        RuntimeNetAction.Required("ModelDb").GetMethods(GameReflection.All)
            .First(m => m.Name == "Get" && !m.IsGenericMethod && m.GetParameters().Length == 1 && m.GetParameters()[0].ParameterType == typeof(Type))
            .Invoke(null, [type])!;
}
