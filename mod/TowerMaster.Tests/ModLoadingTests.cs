using Xunit;

namespace TowerMaster.Tests;

/// <summary>
/// 游戏加载 mod 时先枚举 TowerMaster.dll 的全部类型、再调用入口（ModManager.TryLoadMod）。
/// 0.0.9 引用了单独的 TowerMaster.Core.dll，枚举阶段找不到它，整个 mod 加载失败。
/// 规则库现在编进主程序集；这里守住「不再引用单独的规则库」。
/// （曾经试过在测试里另开加载上下文再加载一份 mod 来模拟，会干扰同进程里其他测试的 Harmony 补丁，已删除。）
/// </summary>
public class ModLoadingTests
{
    [Fact]
    public void ModDoesNotDependOnSeparateCoreAssembly()
    {
        var references = typeof(ModEntry).Assembly.GetReferencedAssemblies().Select(a => a.Name);
        Assert.DoesNotContain("TowerMaster.Core", references);
    }
}
