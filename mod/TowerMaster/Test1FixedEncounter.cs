using System.Reflection;
using HarmonyLib;
using TowerMaster.Core;

namespace TowerMaster;

/// <summary>
/// 测试 1a：所有普通房间换成 towermaster.test.json 里本幕的固定遭遇。
/// 各客户端都按同一份文件替换，不需要联机消息；用来确认「替换后两边一致、不报不同步」。
/// 做法：CombatRoom.StartCombat 执行前，把房间对象里存遭遇的字段换掉（StartCombat 里才按种子生成怪物）。
/// 全程用反射，不依赖游戏类型的编译期签名；哪一步失败日志里都有原因。
/// </summary>
internal static class Test1FixedEncounter
{
    private static TestSettings _settings = new();
    private static PriceBook? _prices;
    private static int _combats;

    public static void Apply(Harmony harmony, TestSettings settings, PriceBook prices)
    {
        _settings = settings;
        _prices = prices;

        var startCombat = GameReflection.FindMethod("StartCombat", "CombatRoom");
        if (startCombat == null) { Log.Error("测试1：找不到 CombatRoom.StartCombat，跳过"); return; }
        harmony.Patch(startCombat, prefix: new HarmonyMethod(Method(nameof(StartCombatPrefix))));
        Log.Info($"测试1：已挂到 {GameReflection.Describe(startCombat)}");

        var generate = GameReflection.FindMethod("GenerateMonstersWithSlots");
        if (generate == null) { Log.Warn("测试1：找不到 GenerateMonstersWithSlots，不记录生成结果"); return; }
        harmony.Patch(generate, postfix: new HarmonyMethod(Method(nameof(GeneratePostfix))));
        Log.Info($"测试1：已挂到 {GameReflection.Describe(generate)}");
    }

    private static MethodInfo Method(string name) =>
        typeof(Test1FixedEncounter).GetMethod(name, BindingFlags.Static | BindingFlags.NonPublic)!;

    /// <summary>遭遇模型的基类：随便拿一个已知遭遇类的基类。</summary>
    private static Type? EncounterBase =>
        GameReflection.TypeNamed("EncounterModel") ?? GameReflection.TypeNamed("MawlerNormal")?.BaseType;

    private static void StartCombatPrefix(object __instance)
    {
        try
        {
            _combats++;
            var baseType = EncounterBase;
            if (baseType == null) { Log.Error("测试1：找不到遭遇基类"); return; }

            // 房间对象上存着遭遇的字段（自动属性的后备字段也在这里）。
            var slots = GameReflection.SlotsAssignableFrom(__instance, baseType).Where(s => s.Value != null).ToList();
            if (slots.Count != 1)
            {
                Log.Error($"测试1 #{_combats}：房间上存遭遇的字段有 {slots.Count} 个，无法确定：" +
                          string.Join("; ", slots.Select(s => $"{s.Name}={s.Value?.GetType().Name}")));
                return;
            }
            var (field, _, current) = slots[0];
            string original = current!.GetType().Name;
            var act = _prices?.Acts.Values.FirstOrDefault(a => a.Encounters.ContainsKey(original));
            Log.Info($"测试1 #{_combats}：房间={__instance.GetType().Name} 原遭遇={original} 幕={act?.Id ?? "?"} 字段={field}");

            if (!_settings.Test1FixedEncounter) return;
            if (!(original.EndsWith("Normal") || original.EndsWith("Weak"))) { Log.Info("测试1：不是普通房，不替换"); return; }
            if (act == null || !_settings.FixedEncounters.TryGetValue(act.Id, out var wanted)) { Log.Warn("测试1：不知道本幕该换成什么"); return; }
            if (wanted == original) { Log.Info("测试1：本来就是目标遭遇"); return; }

            var replacement = GetEncounterModel(wanted, current);
            if (replacement == null) return;
            GameReflection.SetField(__instance, field, replacement);
            Log.Info($"测试1 #{_combats}：已替换 {original} → {replacement.GetType().Name}");
        }
        catch (Exception e)
        {
            Log.Error("测试1：替换失败", e);
        }
    }

    /// <summary>从 ModelDb 取遭遇模型；原遭遇是可变副本时也转成可变副本。</summary>
    private static object? GetEncounterModel(string typeName, object original)
    {
        var type = GameReflection.TypeNamed(typeName);
        var modelDb = GameReflection.TypeNamed("ModelDb");
        if (type == null || modelDb == null) { Log.Error($"测试1：找不到类型 {typeName} 或 ModelDb"); return null; }

        // 猜测：ModelDb.Encounter<T>()。不对的话看探针日志里 ModelDb 的全部成员，改这里。
        var getter = modelDb.GetMethods(BindingFlags.Public | BindingFlags.Static)
            .FirstOrDefault(m => m.Name == "Encounter" && m.IsGenericMethodDefinition && m.GetParameters().Length == 0);
        if (getter == null) { Log.Error("测试1：ModelDb 上没有 Encounter<T>()，看探针日志改 GetEncounterModel"); return null; }
        var model = getter.MakeGenericMethod(type).Invoke(null, null);
        if (model == null) { Log.Error($"测试1：ModelDb.Encounter<{typeName}>() 返回 null"); return null; }

        if (GameReflection.Get(original, "IsMutable") is true)
        {
            var toMutable = model.GetType().GetMethod("ToMutable", BindingFlags.Public | BindingFlags.Instance, Type.EmptyTypes);
            if (toMutable == null) Log.Warn("测试1：原遭遇是可变副本，但找不到 ToMutable()，直接用规范模型");
            else model = toMutable.Invoke(model, null) ?? model;
        }
        return model;
    }

    /// <summary>记录生成出来的怪物组合。两台电脑的这一行应该完全一样。</summary>
    private static void GeneratePostfix(object __instance)
    {
        try
        {
            Log.Info($"测试1 #{_combats}：生成 {__instance.GetType().Name} → {GameReflection.Dump(GameReflection.Get(__instance, "MonstersWithSlots"))}");
        }
        catch (Exception e)
        {
            Log.Error("测试1：记录生成结果失败", e);
        }
    }
}
