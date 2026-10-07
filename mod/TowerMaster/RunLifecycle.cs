using HarmonyLib;

namespace TowerMaster;

/// <summary>
/// 一局的开始和结束：RunManager.CleanUp（回主菜单、断线、放弃）和 SetUpNew/SavedMultiplayer、SetUpNewSingleplayer（新开或读档）
/// 时清掉召唤、塔主回合、陷阱的本局状态。0.0.26 实测：断线后同一进程新开一局，仍显示上一局的召唤点、已打场数和「塔主回合暂停中」。
/// </summary>
internal static class RunLifecycle
{
    private static bool _patched;

    internal static void Apply(Harmony harmony)
    {
        if (_patched) return;
        _patched = true;
        var manager = RuntimeNetAction.Required("RunManager");
        var prefix = new HarmonyMethod(typeof(RunLifecycle).GetMethod(nameof(Reset), GameReflection.All)!);
        foreach (var name in new[] { "CleanUp", "SetUpNewMultiplayer", "SetUpSavedMultiplayer", "SetUpNewSingleplayer", "SetUpSavedSingleplayer" })
        {
            var method = manager.GetMethods(GameReflection.All).FirstOrDefault(m => m.Name == name && !m.IsAbstract);
            if (method == null) { Log.Warn($"局开始/结束：找不到 RunManager.{name}"); continue; }
            harmony.Patch(method, prefix: prefix);
        }
        Log.Info("局开始/结束：已挂上，换局时清掉塔主状态");
    }

    internal static void Reset(System.Reflection.MethodBase __originalMethod)
    {
        try
        {
            Log.Info($"局开始/结束（{__originalMethod?.Name}）：清掉召唤、塔主回合、陷阱的本局状态");
            ThreatPhase.ResetRun();
            SummonPhase.ResetRun();
        }
        catch (Exception e) { Log.Error("局开始/结束：清理失败", e); }
    }
}
