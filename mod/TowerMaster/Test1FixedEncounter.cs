using System.Reflection;
using HarmonyLib;
using TowerMaster.Core;

namespace TowerMaster;

/// <summary>
/// 测试 1a：所有普通房间换成 towermaster.test.json 里本幕的固定遭遇。
/// 各客户端都按同一份文件替换，不需要联机消息；用来确认「替换后两边一致、不报不同步」。
/// 做法：ActModel.PullNextEncounter 返回后替换规范遭遇，游戏再创建可变副本和战斗房间。
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

        var pullEncounter = GameReflection.FindMethod("PullNextEncounter", "ActModel");
        if (pullEncounter == null) { Log.Error("测试1：找不到 ActModel.PullNextEncounter，跳过"); return; }
        harmony.Patch(pullEncounter, postfix: new HarmonyMethod(Method(nameof(PullNextEncounterPostfix))));
        Log.Info($"测试1：已挂到 {GameReflection.Describe(pullEncounter)}");

        var generate = GameReflection.FindMethod("GenerateMonstersWithSlots");
        if (generate == null) { Log.Warn("测试1：找不到 GenerateMonstersWithSlots，不记录生成结果"); return; }
        harmony.Patch(generate, postfix: new HarmonyMethod(Method(nameof(GeneratePostfix))));
        Log.Info($"测试1：已挂到 {GameReflection.Describe(generate)}");
    }

    private static MethodInfo Method(string name) =>
        typeof(Test1FixedEncounter).GetMethod(name, BindingFlags.Static | BindingFlags.NonPublic)!;

    private static void PullNextEncounterPostfix(object __instance, ref object __result)
    {
        try
        {
            _combats++;
            var current = __result;
            string original = current!.GetType().Name;
            var act = _prices?.Acts.Values.FirstOrDefault(a => a.Encounters.ContainsKey(original));
            Log.Info($"测试1 #{_combats}：选遭遇={__instance.GetType().Name} 原遭遇={original} 幕={act?.Id ?? "?"}");

            if (!_settings.Test1FixedEncounter) return;
            if (!(original.EndsWith("Normal") || original.EndsWith("Weak"))) { Log.Info("测试1：不是普通房，不替换"); return; }
            if (act == null || !_settings.FixedEncounters.TryGetValue(act.Id, out var wanted)) { Log.Warn("测试1：不知道本幕该换成什么"); return; }

            var replacement = GetEncounterModel(wanted, current);
            if (replacement == null) return;
            __result = replacement;
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

        // ModelDb 返回规范遭遇；PullNextEncounter 的调用方负责 ToMutable。
        var getter = modelDb.GetMethods(BindingFlags.Public | BindingFlags.Static)
            .FirstOrDefault(m => m.Name == "Encounter" && m.IsGenericMethodDefinition && m.GetParameters().Length == 0);
        if (getter == null) { Log.Error("测试1：ModelDb 上没有 Encounter<T>()，看探针日志改 GetEncounterModel"); return null; }
        var model = getter.MakeGenericMethod(type).Invoke(null, null);
        if (model == null) { Log.Error($"测试1：ModelDb.Encounter<{typeName}>() 返回 null"); return null; }

        if (GameReflection.Get(original, "IsMutable") is true)
        {
            var toMutable = model.GetType().GetMethod("ToMutable", BindingFlags.Public | BindingFlags.Instance, Type.EmptyTypes);
            if (toMutable == null) { Log.Error("测试1：找不到 ToMutable()，保留原遭遇"); return null; }
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
