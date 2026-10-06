using System.Reflection;
using System.Runtime.CompilerServices;
using HarmonyLib;
using TowerMaster.Core;
#if GAME
using MegaCrit.Sts2.Core.Modding; // 猜测：ModInitializer 特性所在命名空间，编译报错就看探针日志里 ModInitializerAttribute 的全名
#endif

namespace TowerMaster;

#if GAME
[ModInitializer(nameof(Init))] // 猜测的写法，对照反编译代码里的 ModInitializerAttribute 和 ModManager 修正
#endif
public static class ModEntry
{
    public const string HarmonyId = "towermaster";

    public static void Init()
    {
        // 先挂依赖解析，再碰 TowerMaster.Core 里的类型（Start 不内联，保证这之后才加载 Core）。
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
        var prices = PriceBook.Load(Path.Combine(Log.ModDir, "price_book.json"));
        Log.Info($"价格表 {prices.Version}，{prices.Acts.Count} 幕");

        if (settings.Probe) GameProbe.Run();

        var harmony = new Harmony(HarmonyId);
        Test1FixedEncounter.Apply(harmony, settings, prices);
    }

    private static Assembly? ResolveFromModDir(object? sender, ResolveEventArgs args)
    {
        var path = Path.Combine(Log.ModDir, new AssemblyName(args.Name).Name + ".dll");
        return File.Exists(path) ? Assembly.LoadFrom(path) : null;
    }
}
