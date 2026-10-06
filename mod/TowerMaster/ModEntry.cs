using System.Reflection;
using System.Runtime.CompilerServices;
using HarmonyLib;
using TowerMaster.Core;
#if GAME
using MegaCrit.Sts2.Core.Modding; // 游戏入口特性，仅此处引用游戏命名空间
#endif

namespace TowerMaster;

#if GAME
[ModInitializer(nameof(Init))] // ModManager 按类上的特性调用静态无参入口
#endif
public static class ModEntry
{
    public const string HarmonyId = "towermaster";

    public static void Init()
    {
        // 规则库已编进本程序集；依赖解析留着兜底其他放在 mod 目录里的程序集（如 nuget 版 0Harmony）。
        AppDomain.CurrentDomain.AssemblyResolve += ResolveFromModDir;
        Log.Init();
        try { Start(); }
        catch (Exception e) { Log.Error("初始化失败", e); }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void Start()
    {
        Log.Info($"TowerMaster {typeof(ModEntry).Assembly.GetName().Version} 加载，目录 {Log.ModDir}");
        var settings = TestSettings.Load();
        var prices = PriceBook.Load(Path.Combine(Log.ModDir, "price_book.data"));
        Log.Info($"价格表 {prices.Version}，{prices.Acts.Count} 幕");

        if (settings.Probe) GameProbe.Run();

        var harmony = new Harmony(HarmonyId);
        if (settings.Test1bMixedEncounter) Test1bMixedEncounter.Apply(harmony, settings, prices);
        else Test1FixedEncounter.Apply(harmony, settings, prices);
        if (settings.Test2MasterOffField) Test2MasterOffField.Apply(harmony, settings);
        if (settings.Test3MasterAutoPilot) Test3MasterAutoPilot.Apply(harmony, settings);
        // 召唤阶段要用测试 1b 的清单通道（上面已经挂好），塔主身份沿用测试 2
        if (settings.SummonPhase && settings.Test1bMixedEncounter) SummonPhase.Apply(harmony, new TowerMasterConfig(), prices);
        else if (settings.SummonPhase) Log.Warn("召唤阶段需要 test1b_mixed_encounter 开着（复用它的清单通道），没有启用");
    }

    private static Assembly? ResolveFromModDir(object? sender, ResolveEventArgs args)
    {
        var path = Path.Combine(Log.ModDir, new AssemblyName(args.Name).Name + ".dll");
        return File.Exists(path) ? Assembly.LoadFrom(path) : null;
    }
}
