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
        var loaded = new HarmonyMethod(typeof(RunLifecycle).GetMethod(nameof(AfterSavedRun), GameReflection.All)!);
        foreach (var name in new[] { "CleanUp", "SetUpNewMultiplayer", "SetUpSavedMultiplayer", "SetUpNewSingleplayer", "SetUpSavedSingleplayer" })
        {
            var method = manager.GetMethods(GameReflection.All).FirstOrDefault(m => m.Name == name && !m.IsAbstract);
            if (method == null) { Log.Warn($"局开始/结束：找不到 RunManager.{name}"); continue; }
            harmony.Patch(method, prefix: prefix, postfix: name.StartsWith("SetUpSaved") ? loaded : null);
        }
        Log.Info("局开始/结束：已挂上，换局时清掉塔主状态");
    }

    /// <summary>
    /// 读档之后（塔主）：马上把账本读回来；等界面稳定后按账本重发一次牌组——原版存档是进房时存的，
    /// 之后在这个房间选的牌只在账本里（0.0.36 实测读档后牌组回退）。
    /// </summary>
    internal static void AfterSavedRun()
    {
        try
        {
            // 原版 SetUpSavedMultiplayer 是异步的：这里运行时，重开游戏后的读档还没设好联机身份（0.0.37 实测：关游戏重开读档，
            // 被当成不是塔主而跳过，删掉的牌回来了）。所以等到「是房主且有对局」再读账本、重发牌组。
            MasterRewards.WhenTrue(() => Test3MasterAutoPilot.LocalIsMaster && GameReflection.Get(Test1bMixedEncounter.Run, "State") != null, () =>
            {
                MasterLedger.EnsureLoaded();
                if (MasterCards.Enabled) MasterDeck.Publish("读档后按账本同步牌组");
            });
        }
        catch (Exception e) { Log.Error("读档：恢复塔主账本失败", e); }
    }

    internal static void Reset(System.Reflection.MethodBase __originalMethod)
    {
        try
        {
            Log.Info($"局开始/结束（{__originalMethod?.Name}）：清掉召唤、塔主回合、陷阱的本局状态");
            ThreatPhase.ResetRun();
            SummonPhase.ResetRun();
            MasterDeck.ResetRun();
            Test3MasterAutoPilot.ResetRun();
        }
        catch (Exception e) { Log.Error("局开始/结束：清理失败", e); }
    }
}
