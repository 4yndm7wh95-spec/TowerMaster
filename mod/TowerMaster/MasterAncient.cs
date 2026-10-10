using System.Collections;
using System.Reflection;
using HarmonyLib;

namespace TowerMaster;

/// <summary>
/// 先古之民的塔主祝福：每幕开头玩家见先古之民选原版祝福，塔主那一份换成 3 件塔主遗物三选一。
/// 原版每个玩家各有一份古人事件（Owner = 该玩家），选项由各端各自生成（AncientEventModel.GenerateInitialOptions），
/// 选中后原版把「第几个选项」发给所有端，各端执行同一份选项。所以只要各端给塔主那份生成同样的选项，同步由原版负责：
/// - 候选：塔主还没有的塔主遗物，按种子 + 幕洗牌取 3 件（读塔主 Player.Relics，各端一致；不碰事件的 Rng）。
/// - 选项用原版 AncientEventModel.RelicOption(relic)：原版自己 RelicCmd.Obtain 给 Owner，再结束这一页。
/// - 一件都不剩时保留原版选项（极少见：8 件遗物要全拿到）。
/// 以前塔主能拿原版祝福（寻龙尺塞「探寻」进塔主牌组、给英雄遗物），0.0.51 那次黑屏就发生在这样一局里。
/// 依据：docs/game-api/ancients-052-flow.md、signatures/*.ancients-052.md。
/// </summary>
internal static class MasterAncient
{
    internal const int OfferCount = 3;
    private static bool _patched;

    internal static void Apply(Harmony harmony)
    {
        if (_patched) return;
        _patched = true;
        var ancient = GameReflection.TypesNamed("AncientEventModel").FirstOrDefault(t => t.IsAbstract)
                      ?? throw new TypeLoadException("AncientEventModel");
        var postfix = new HarmonyMethod(typeof(MasterAncient).GetMethod(nameof(AfterGenerate), GameReflection.All)!);
        var names = new List<string>();
        foreach (var type in ancient.Assembly.GetTypes().Where(t => ancient.IsAssignableFrom(t) && t != ancient))
        {
            var m = type.GetMethod("GenerateInitialOptions", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly);
            if (m == null || m.IsAbstract) continue;
            harmony.Patch(m, postfix: postfix);
            names.Add(type.Name);
        }
        Log.Info($"塔主先古祝福：已挂到 {names.Count} 个古人（{string.Join("、", names)}）");
    }

    /// <summary>这一幕给塔主的候选（各端同样的输入得到同样的结果）。</summary>
    internal static List<string> Candidates(ulong seed, int actNo, IEnumerable<string> owned) =>
        MasterRewards.Offer(seed, -(actNo * 1000 + 7), OfferCount, MasterRelics.Defs.Select(d => d.Id).Except(owned));

    private static void AfterGenerate(object __instance, ref object __result)
    {
        try
        {
            if (!MasterRelics.Enabled) return;
            var owner = GameReflection.Get(__instance, "Owner");
            if (owner == null || Test2MasterOffField.MasterId is not { } masterId || Test2MasterOffField.NetIdOf(owner) != masterId) return;
            var state = GameReflection.Get(Test1bMixedEncounter.Run, "State") ?? throw new InvalidOperationException("没有对局状态");
            var seed = Convert.ToUInt64(GameReflection.Get(GameReflection.Get(state, "Rng")!, "Seed"));
            int actNo = ThreatPhase.ActNoOf(state);
            var picks = Candidates(seed, actNo, MasterRelics.Owned());
            if (picks.Count == 0) { Log.Warn($"塔主先古祝福：塔主遗物全都有了，这次给原版祝福（{__instance.GetType().Name}）"); return; }

            var optionType = GameReflection.TypesNamed("EventOption").First();
            var relicOption = __instance.GetType().GetMethods(GameReflection.All)
                .First(m => m.Name == "RelicOption" && !m.IsGenericMethod && m.GetParameters().Length == 3 && m.GetParameters()[1].ParameterType == typeof(string));
            var addBefore = optionType.GetMethod("add_BeforeChosen", GameReflection.All)!;
            var makeHook = typeof(MasterAncient).GetMethod(nameof(Hook), GameReflection.All)!.MakeGenericMethod(optionType);
            var list = (IList)Activator.CreateInstance(typeof(List<>).MakeGenericType(optionType))!;
            foreach (var id in picks)
            {
                var relic = RuntimeNetAction.Call(MasterCards.Canonical(MasterRelics.TypeOf(id)!), "ToMutable");
                var option = relicOption.Invoke(__instance, [relic, "INITIAL", null])!;
                var chosenId = id;
                addBefore.Invoke(option, [makeHook.Invoke(null, [(Func<Task>)(() => { OnChosen(chosenId, seed, actNo); return Task.CompletedTask; })])]);
                list.Add(option);
            }
            __result = list;
            Log.Info($"塔主先古祝福：{__instance.GetType().Name}，第 {actNo} 幕，塔主的选项换成 {string.Join("、", picks.Select(p => MasterRelics.Find(p)?.Title))}");
        }
        catch (Exception e) { Log.Error("塔主先古祝福：换选项失败，塔主这次看到原版祝福", e); }
    }

    /// <summary>EventOption.BeforeChosen 的委托类型是 Func&lt;EventOption, Task&gt;，用泛型包一层。</summary>
    private static Func<T, Task> Hook<T>(Func<Task> run) => _ => run();

    /// <summary>各端：塔主选中某件遗物（原版接着会 RelicCmd.Obtain）。小金库的召唤点记在房主账本上。</summary>
    private static void OnChosen(string id, ulong seed, int actNo)
    {
        var title = MasterRelics.Find(id)?.Title ?? id;
        Log.Info($"塔主先古祝福：塔主选了「{title}」");
        if (Test3MasterAutoPilot.LocalIsMaster)
        {
            if (id == "piggy_bank")
            {
                MasterLedger.For(seed, actNo);
                MasterLedger.GainPoints(8, "小金库");
            }
        }
        else SummonPhase.Notify("塔主也拿到了祝福", $"「{title}」", "master_portrait");
    }
}
