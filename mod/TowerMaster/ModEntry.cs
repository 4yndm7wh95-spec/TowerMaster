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
        if (settings.Test2MasterOffField)
        {
            Test2MasterOffField.Apply(harmony, settings);
            MasterPresence.Apply(harmony, settings.MasterStayDead);
        }
        if (settings.Test3MasterAutoPilot) Test3MasterAutoPilot.Apply(harmony, settings);
        // 召唤阶段要用测试 1b 的清单通道（上面已经挂好），塔主身份沿用测试 2
        var config = LoadConfig();
        if (settings.SummonPhase && settings.Test1bMixedEncounter) SummonPhase.Apply(harmony, config, prices);
        else if (settings.SummonPhase) Log.Warn("召唤阶段需要 test1b_mixed_encounter 开着（复用它的清单通道），没有启用");
        if (settings.MasterTurn && settings.SummonPhase && settings.Test1bMixedEncounter) ThreatPhase.Apply(harmony, config, prices);
        else if (settings.MasterTurn) Log.Warn("塔主回合需要 summon_phase 和 test1b_mixed_encounter 开着，没有启用");

        // 测试接口：只有设了 TOWERMASTER_BRIDGE_PORT 才启动（本机测试助手用）
        try { TestBridge.StartFromEnvironment(); }
        catch (Exception e) { Log.Error("测试接口启动失败", e); }
    }

    /// <summary>
    /// 平衡数值：mod 目录下 towermaster.config.json（可以只写要改的字段，其余用默认值），没有就全用默认值。
    /// 改完要重启游戏；两台电脑都要放同一份（塔主那台起作用，客户端只执行指令，但保持一致免得混淆）。
    /// </summary>
    internal static TowerMasterConfig LoadConfig()
    {
        var path = Path.Combine(Log.ModDir, "towermaster.config.json");
        try
        {
            if (File.Exists(path))
            {
                var config = TowerMasterConfig.FromJson(File.ReadAllText(path));
                Log.Info($"平衡数值：读取 {path}");
                return Active = config;
            }
        }
        catch (Exception e) { Log.Error($"平衡数值：{path} 读不了，用默认值", e); }
        return Active = new TowerMasterConfig();
    }

    /// <summary>当前生效的数值（测试接口读）。</summary>
    internal static TowerMasterConfig Active { get; private set; } = new();

    private static Assembly? ResolveFromModDir(object? sender, ResolveEventArgs args)
    {
        var path = Path.Combine(Log.ModDir, new AssemblyName(args.Name).Name + ".dll");
        return File.Exists(path) ? Assembly.LoadFrom(path) : null;
    }
}
