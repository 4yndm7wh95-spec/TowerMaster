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
    int CardType, int TargetType, bool Unplayable, string Art, string Op, int Tier, bool Exhaust = false);

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

    /// <summary>塔主牌模式开着（注册成功后为真；测试里可以关掉，注册本身不能撤销）。</summary>
    internal static bool Enabled { get; set; }

    /// <summary>没开成塔主牌的原因（设置关着或注册失败），塔主回合面板上直接显示，免得悄悄退回旧面板。</summary>
    internal static string? FailReason { get; set; }
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

    /// <summary>精英/Boss 战后塔主 3 选 1 的奖励牌（不在初始牌组里）。</summary>
    internal static readonly string[] RewardPool = ["fortify_all", "heal_all", "sap", "daze_all", "expose_all", "scheme", "surge",
        "feast", "slime_gift", "thorns", "artifact", "call_help", "infight", "gamble", "heckle"];

    /// <summary>奖励牌：操作名、名字、卡图、目标类型（3 所有敌人、6 一名队友、7 所有队友、1 自己）、费用。</summary>
    private static readonly (string Op, string Name, string Art, int Target, int Cost)[] RewardOps =
    [
        ("fortify_all", "坚壁", "act_block", 3, 2), ("heal_all", "复苏", "act_heal", 3, 2), ("sap", "衰竭", "act_weak", 6, 2),
        ("daze_all", "迷雾", "act_dazed", 7, 1), ("expose_all", "弱点暴露", "act_vulnerable", 7, 2),
        ("scheme", "筹谋", "icon_trap", 1, 0), ("surge", "鼓动", "icon_threat_point", 1, 0),
        // 0.0.39 娱乐牌（用户：和朋友玩、娱乐为主，可以恶搞）：笑点放在看得懂、能应对的场面变化上
        ("feast", "请客", "act_heal", 0, 1), ("slime_gift", "黏液大礼包", "act_dazed", 6, 1), ("thorns", "荆棘丛", "act_block", 2, 1),
        ("artifact", "金身", "act_block", 2, 1), ("call_help", "摇人", "master_portrait", 0, 2), ("infight", "内讧", "act_strength", 2, 1),
        ("gamble", "惊喜盲盒", "icon_trap", 0, 0), ("heckle", "起哄", "act_vulnerable", 6, 0),
    ];

    internal static int FeastHeal(int tier) => new[] { 5, 7, 9 }[Math.Clamp(tier, 1, 3) - 1];
    internal static int SlimeCount(int tier) => tier >= 3 ? 3 : 2;
    internal static int ThornsAmount(int tier) => new[] { 3, 4, 5 }[Math.Clamp(tier, 1, 3) - 1];
    internal static int ArtifactAmount(int tier) => tier >= 3 ? 2 : 1;
    internal static int InfightDamage(int tier) => new[] { 6, 8, 10 }[Math.Clamp(tier, 1, 3) - 1];
    internal const int CallHelpMaxEnemies = 5;
    /// <summary>「摇人」各幕召唤的小怪（按顺序取第一个游戏里有的）。</summary>
    internal static readonly string[][] CallHelpMonsters = [["LeafSlimeS", "TwigSlimeS", "Inklet"], ["BowlbugEgg", "Exoskeleton", "BowlbugSilk"], ["PunchConstruct", "ScrollOfBiting", "TurretOperator"]];

    internal static int FortifyAmount(int tier) => new[] { 4, 6, 8 }[Math.Clamp(tier, 1, 3) - 1];
    internal const int HealAllPercent = 8;
    internal static int SchemeDraw(int tier) => tier >= 2 ? 2 : 1;

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
        foreach (var (op, name, art, target, cost) in RewardOps)
            for (int act = 1; act <= 3; act++)
            {
                string desc = op switch
                {
                    "fortify_all" => $"所有敌人获得 {FortifyAmount(act)} 点格挡。",
                    "heal_all" => $"所有敌人回复 {HealAllPercent}% 最大生命值。\n计入每名敌人每场的治疗次数。",
                    "sap" => "给予一名玩家 1 层虚弱和 1 层脆弱。",
                    "daze_all" => "将 1 张晕眩放入每名玩家的抽牌堆。\n计入每场的晕眩次数。",
                    "expose_all" => "给予每名玩家 1 层易伤。",
                    "scheme" => $"抽 {SchemeDraw(act)} 张牌。",
                    "feast" => $"每名玩家回复 {FeastHeal(act)} 点生命。\n所有敌人获得 1 点力量。",
                    "slime_gift" => $"将 {SlimeCount(act)} 张黏液放入一名玩家的弃牌堆。",
                    "thorns" => $"选择一名敌人，使其获得 {ThornsAmount(act)} 层荆棘。",
                    "artifact" => $"选择一名敌人，使其获得 {ArtifactAmount(act)} 层人工制品。",
                    "call_help" => $"召唤一只本幕的小怪加入战斗。\n每场战斗限 1 次，场上最多 {CallHelpMaxEnemies} 名敌人。",
                    "infight" => $"选择一名敌人，使其受到 {InfightDamage(act)} 点伤害。\n其余敌人各获得 1 点力量。",
                    "gamble" => "随机发生一件事：所有敌人获得 5 点格挡，或每名玩家获得 1 层虚弱，或每名玩家抽 1 张牌，或塔主获得 2 点能量。",
                    "heckle" => "给予一名玩家 1 层易伤。\n该玩家抽 1 张牌。",
                    _ => "获得 1 点能量。", // 「消耗。」由原版按关键词自动加（0.0.34 实测写了会重复）
                };
                defs.Add(new($"act:{op}@{act}", $"TowerMaster{Pascal(op)}{act}", act > 1 ? $"{name}+{act - 1}" : name, desc,
                    cost, CardType: 2, target, Unplayable: false, art, op, act, Exhaust: op == "surge"));
            }
        foreach (var t in TrapCatalog.All)
            for (int tier = 1; tier <= 3; tier++)
            {
                var card = new TrapCard(t.Id, tier);
                defs.Add(new($"trap:{t.Id}@{tier}", $"TowerMasterTrap{Pascal(t.Id)}{tier}", card.Name, "陷阱。召唤时盖下。\n" + card.Describe(),
                    -1, CardType: 2, TargetType: 0, Unplayable: true, $"trap_{t.Id}", "trap", tier));
            }
        // 遗物牌：只在塔主宝箱的原版选牌界面里当候选（选中后各端给塔主真遗物，见 MasterRelics），不进牌组
        foreach (var r in MasterRelics.Defs)
            defs.Add(new($"relic:{r.Id}@1", $"TowerMasterRelicOffer{Pascal(r.Id)}", $"遗物·{r.Title}", r.Description,
                -1, CardType: 2, TargetType: 0, Unplayable: true, $"relic_{r.Id}", "relic", 1));
        return defs;
    }

    private static string Pascal(string id) => string.Concat(id.Split('_').Select(w => char.ToUpperInvariant(w[0]) + w[1..]));

    // ---------------------------------------------------------------- 注册（mod 入口，ModelDb.Init 之前）

    internal static void Register(Harmony harmony, TowerMasterConfig config)
    {
        if (_registered) { Enabled = true; return; }
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
        if (!MasterRelics.Allowed) MasterRelics.FailReason = "towermaster.test.json 里 master_relics 是 false";
        else try { types.AddRange(MasterRelics.Emit(module, harmony)); }
        catch (Exception e) { MasterRelics.FailReason = e.InnerException?.Message ?? e.Message; Log.Error("塔主遗物：生成遗物类型失败（宝箱退回送塔主牌）", e); }
        _types = types.ToArray();
        ModAssociation.Associate(types[0].Assembly);
        var getter = RuntimeNetAction.Required("ReflectionHelper").GetProperty("ModTypes", GameReflection.All)?.GetMethod
                     ?? throw new MissingMethodException("ReflectionHelper.ModTypes");
        harmony.Patch(getter, postfix: new HarmonyMethod(typeof(MasterCards).GetMethod(nameof(ModTypesPostfix), GameReflection.All)!));
        PatchLoc(harmony);
        PatchPortrait(harmony);
        MasterDeck.Apply(harmony);
        MasterHand.Apply(harmony);
        MasterRewards.Apply(harmony);
        _registered = true;
        Enabled = true;
        Log.Info($"塔主牌：已生成 {types.Count} 种卡牌类型（{types[0].Name} …），等 ModelDb.Init 收录");
    }

    internal static IEnumerable<MethodInfo> AllMethods(Type type)
    {
        var seen = new HashSet<string>();
        for (var t = type; t != null && t != typeof(object); t = t.BaseType)
            foreach (var m in t.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly))
                if (seen.Add(m.Name + "(" + string.Join(",", m.GetParameters().Select(p => p.ParameterType.FullName)) + ")")) yield return m;
    }

    private static void ModTypesPostfix(ref Type[] __result) => __result = __result.Concat(_types).Distinct().ToArray();

    /// <summary>重写一个虚方法：把 this 和参数打包成 object[]，转给 <see cref="MasterCards"/> 的静态方法 handler(object self, object?[] args)。</summary>
    private static void Override(TypeBuilder tb, MethodInfo original, string handler) =>
        Override(tb, original, typeof(MasterCards).GetMethod(handler, BindingFlags.Public | BindingFlags.Static)!);

    /// <summary>同上，处理方法可以在别的类（必须 public static object? X(object self, object?[] args)）。</summary>
    internal static void Override(TypeBuilder tb, MethodInfo original, MethodInfo handler)
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
        il.Emit(OpCodes.Call, handler);
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

    private static Array? _unplayable, _exhaust, _noKeywords;
    public static object? Keywords(object self, object?[] args)
    {
        var keyword = RuntimeNetAction.Required("CardKeyword");
        Array One(string name)
        {
            var a = Array.CreateInstance(keyword, 1);
            a.SetValue(Enum.Parse(keyword, name), 0);
            return a;
        }
        var def = DefOf(self);
        if (def?.Unplayable == true) return _unplayable ??= One("Unplayable");
        if (def?.Exhaust == true) return _exhaust ??= One("Exhaust");
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
        MasterStats.RecordCard(def.Title);
        var target = GameReflection.Get(cardPlay, "Target");
        var p = ModEntry.Active.Threat;
        try
        {
            switch (def.Op)
            {
                case "block" when target != null:
                    await ThreatPhase.GainBlock(target, TowerMasterConfig.ByAct(p.BlockAmount, def.Tier));
                    MasterHand.Record(def, target, 0);
                    break;
                case "heal" when target != null:
                    await ThreatPhase.Heal(target, Math.Max(1, Convert.ToInt32(GameReflection.Get(target, "MaxHp")) * p.HealPercent / 100));
                    MasterHand.Record(def, target, 0);
                    break;
                case "strength" when target != null:
                    await ThreatPhase.ApplyPowerWith("StrengthPower", context, target, TowerMasterConfig.ByAct(p.StrengthAmount, def.Tier));
                    MasterHand.Record(def, target, TowerMasterConfig.ByAct(p.StrengthAmount, def.Tier));
                    break;
                case "strength_all":
                    if (ThreatPhase.CombatState() is { } combat)
                        foreach (var e in ((GameReflection.Get(combat, "Enemies") as IEnumerable)?.Cast<object>() ?? []).ToList())
                        {
                            // 已到上限的怪跳过
                            if (GameReflection.Get(e, "IsDead") is true || MasterHand.StrengthOf(e) + p.StrengthAllAmount > TowerMasterConfig.ByAct(p.StrengthCap, def.Tier)) continue;
                            await ThreatPhase.ApplyPowerWith("StrengthPower", context, e, p.StrengthAllAmount);
                            MasterHand.RecordStrength(e, p.StrengthAllAmount, fromCard: true);
                        }
                    MasterHand.Record(def, null, 0);
                    break;
                case "weak" or "vulnerable" or "frail" when target != null:
                    await ThreatPhase.ApplyPowerWith(def.Op switch { "weak" => "WeakPower", "vulnerable" => "VulnerablePower", _ => "FrailPower" },
                        context, target, p.DebuffStacks);
                    MasterHand.Record(def, target, 0);
                    break;
                case "dazed" when target != null:
                    await ThreatPhase.AddDazed(target);
                    MasterHand.Record(def, target, 0);
                    break;
                case "fortify_all":
                    foreach (var e in MasterHand.LivingEnemies().ToList()) await ThreatPhase.GainBlock(e, FortifyAmount(def.Tier));
                    break;
                case "heal_all":
                    foreach (var e in MasterHand.LivingEnemies().ToList())
                    {
                        if (!MasterHand.Allowed(def with { Op = "heal" }, e)) continue; // 治疗次数用完的跳过
                        await ThreatPhase.Heal(e, Math.Max(1, Convert.ToInt32(GameReflection.Get(e, "MaxHp")) * HealAllPercent / 100));
                        MasterHand.Record(def with { Op = "heal" }, e, 0);
                    }
                    break;
                case "sap" when target != null:
                    await ThreatPhase.ApplyPowerWith("WeakPower", context, target, 1);
                    await ThreatPhase.ApplyPowerWith("FrailPower", context, target, 1);
                    MasterHand.Record(def with { Op = "weak" }, target, 0);
                    break;
                case "daze_all":
                    foreach (var c in MasterHand.LivingClimbers().ToList()) await ThreatPhase.AddDazed(c);
                    MasterHand.Record(def with { Op = "dazed" }, null, 0);
                    break;
                case "expose_all":
                    foreach (var c in MasterHand.LivingClimbers().ToList())
                    {
                        if (!MasterHand.Allowed(def with { Op = "vulnerable" }, c)) continue; // 本回合已经被上过减益的跳过
                        await ThreatPhase.ApplyPowerWith("VulnerablePower", context, c, 1);
                        MasterHand.Record(def with { Op = "vulnerable" }, c, 0);
                    }
                    break;
                case "scheme" when MasterHand.MasterPlayer() is { } m:
                    await (Task)RuntimeNetAction.Required("CardPileCmd").GetMethods(BindingFlags.Public | BindingFlags.Static)
                        .First(x => x.Name == "Draw" && x.GetParameters().Length == 4 && x.GetParameters()[1].ParameterType == typeof(decimal))
                        .Invoke(null, [context, (decimal)SchemeDraw(def.Tier), m, false])!;
                    break;
                case "feast":
                    foreach (var c in MasterHand.LivingClimbers().ToList()) await ThreatPhase.Heal(c, FeastHeal(def.Tier));
                    foreach (var e in MasterHand.LivingEnemies().ToList())
                        if (MasterHand.StrengthOf(e) + 1 <= TowerMasterConfig.ByAct(p.StrengthCap, def.Tier))
                        {
                            await ThreatPhase.ApplyPowerWith("StrengthPower", context, e, 1);
                            MasterHand.RecordStrength(e, 1, fromCard: true);
                        }
                    break;
                case "slime_gift" when target != null:
                    await ThreatPhase.AddStatus("Slimed", target, "Discard", SlimeCount(def.Tier));
                    break;
                case "thorns" when target != null:
                    await ThreatPhase.ApplyPowerWith("ThornsPower", context, target, ThornsAmount(def.Tier));
                    break;
                case "artifact" when target != null:
                    await ThreatPhase.ApplyPowerWith("ArtifactPower", context, target, ArtifactAmount(def.Tier));
                    break;
                case "call_help":
                    if (ThreatPhase.CombatState() is { } combatState && CallHelpMonster(def.Tier) is { } monster)
                    {
                        await ThreatPhase.AddMonster(monster, combatState);
                        MasterHand.Record(def, null, 0);
                    }
                    else Log.Warn("塔主牌：摇人找不到可召唤的小怪");
                    break;
                case "infight" when target != null:
                    await ThreatPhase.Damage(context, target, InfightDamage(def.Tier));
                    foreach (var e in MasterHand.LivingEnemies().Where(e => !ReferenceEquals(e, target)).ToList())
                        if (MasterHand.StrengthOf(e) + 1 <= TowerMasterConfig.ByAct(p.StrengthCap, def.Tier))
                        {
                            await ThreatPhase.ApplyPowerWith("StrengthPower", context, e, 1);
                            MasterHand.RecordStrength(e, 1, fromCard: true);
                        }
                    break;
                case "gamble":
                {
                    int roll = MasterHand.Roll(4); // 各端同一个种子、同一次计数，结果一样
                    Log.Info($"塔主牌：惊喜盲盒开出第 {roll + 1} 种");
                    switch (roll)
                    {
                        case 0:
                            foreach (var e in MasterHand.LivingEnemies().ToList()) await ThreatPhase.GainBlock(e, 5);
                            break;
                        case 1:
                            foreach (var c in MasterHand.LivingClimbers().ToList()) await ThreatPhase.ApplyPowerWith("WeakPower", context, c, 1);
                            break;
                        case 2:
                            foreach (var c in MasterHand.LivingClimbers().ToList())
                                if (GameReflection.Get(c, "Player") is { } pl) await DrawFor(context, pl, 1);
                            break;
                        default:
                            if (MasterHand.MasterPlayer() is { } mp)
                                await (Task)RuntimeNetAction.Required("PlayerCmd").GetMethods(BindingFlags.Public | BindingFlags.Static)
                                    .First(x => x.Name == "GainEnergy" && x.GetParameters().Length == 2).Invoke(null, [2m, mp])!;
                            break;
                    }
                    try { SummonPhase.Toast(new[] { "惊喜盲盒：敌人全体 +5 格挡", "惊喜盲盒：每名玩家 1 层虚弱", "惊喜盲盒：每名玩家抽 1 张牌（塔主亏了）", "惊喜盲盒：塔主 +2 能量" }[roll]); }
                    catch { /* 测试里没有界面 */ }
                    break;
                }
                case "heckle" when target != null:
                    await ThreatPhase.ApplyPowerWith("VulnerablePower", context, target, 1);
                    MasterHand.Record(def with { Op = "vulnerable" }, target, 0);
                    if (GameReflection.Get(target, "Player") is { } hp) await DrawFor(context, hp, 1);
                    break;
                case "surge" when MasterHand.MasterPlayer() is { } m:
                    await (Task)RuntimeNetAction.Required("PlayerCmd").GetMethods(BindingFlags.Public | BindingFlags.Static)
                        .First(x => x.Name == "GainEnergy" && x.GetParameters().Length == 2).Invoke(null, [1m, m])!;
                    break;
            }
            Log.Info($"塔主牌：打出 {def.Title}{(target != null ? $" → {GameReflection.Get(target, "Monster")?.GetType().Name ?? Test2MasterOffField.NetIdOf(target)?.ToString()}" : "")}");
        }
        catch (Exception e) { Log.Error($"塔主牌：{def.Title} 效果失败", e); }
    }

    private static Task DrawFor(object context, object player, int count) =>
        (Task)RuntimeNetAction.Required("CardPileCmd").GetMethods(BindingFlags.Public | BindingFlags.Static)
            .First(x => x.Name == "Draw" && x.GetParameters().Length == 4 && x.GetParameters()[1].ParameterType == typeof(decimal))
            .Invoke(null, [context, (decimal)count, player, false])!;

    /// <summary>「摇人」：本幕小怪列表里第一个游戏里有的，做成可变实例。</summary>
    private static object? CallHelpMonster(int tier)
    {
        foreach (var id in CallHelpMonsters[Math.Clamp(tier, 1, 3) - 1])
        {
            try
            {
                if (GameReflection.TypeNamed(id) == null) continue;
                var canonical = Test1bMixedEncounter.Model("Monster", id);
                return canonical.GetType().GetMethod("ToMutable", Type.EmptyTypes)?.Invoke(canonical, null) ?? canonical;
            }
            catch { /* 试下一个 */ }
        }
        return null;
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

    private static G.Vector2I _portraitSize = new(500, 380);

    private static void AfterUpdatePortrait(object __instance)
    {
        try
        {
            if (DefOf(GameReflection.Get(__instance, "Model")) is not { } def) return;
            if (__instance is not G.Node node || node.GetNodeOrNull<G.TextureRect>("%Portrait") is not { } portrait) return;
            // 原卡图框贴图（缺图图）的尺寸 = 卡图该有的尺寸；我们的透明图标贴到不透明底上再放进去
            var size = portrait.Texture is { } old && old.GetWidth() > 16 ? new G.Vector2I(old.GetWidth(), old.GetHeight()) : _portraitSize;
            if (size.X > 16) _portraitSize = size;
            var tint = def.Op switch
            {
                "trap" => new G.Color(0.10f, 0.24f, 0.28f),
                "relic" => new G.Color(0.30f, 0.23f, 0.10f),
                _ => new G.Color(0.20f, 0.13f, 0.28f),
            };
            if ((Art.Card(def.Art, size, tint) ?? (def.Op == "relic" ? Art.Card("master_portrait", size, tint) : null)) is { } texture) portrait.Texture = texture;
        }
        catch (Exception e) { Log.Warn($"塔主牌：换卡图失败：{e.Message}"); }
    }

    /// <summary>规范实例（ModelDb 里的那一份）。</summary>
    internal static object Canonical(Type type) =>
        RuntimeNetAction.Required("ModelDb").GetMethods(GameReflection.All)
            .First(m => m.Name == "Get" && !m.IsGenericMethod && m.GetParameters().Length == 1 && m.GetParameters()[0].ParameterType == typeof(Type))
            .Invoke(null, [type])!;
}
