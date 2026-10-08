using TowerMaster.Core;
using Xunit;

namespace TowerMaster.Core.Tests;

public class RunReportTests
{
    [Fact]
    public void SummarisesAndPicksAFunnyHonor()
    {
        var view = RunReport.Build(new RunReportInput(true, 12, 4, ["小啃兽", "小啃兽", "蛤蟆蝌蚪"], ["史莱姆之王"],
            ["加固", "加固+1", "狂怒"], ["惊喜盲盒", "惊喜盲盒+1", "惊喜盲盒", "格挡"]));
        Assert.Equal("塔主获胜！", view.Title);
        Assert.Equal("赌狗塔主", view.Honor);
        Assert.Contains(view.Lines, l => l.Label == "召唤怪物" && l.Value.Contains("小啃兽 ×2"));
        Assert.Contains(view.Lines, l => l.Label == "陷阱触发" && l.Value.Contains("加固 ×2"));
        Assert.Contains(view.Lines, l => l.Label == "挑的 Boss" && l.Value == "史莱姆之王");
    }

    [Fact]
    public void QuietMasterAndTies()
    {
        var view = RunReport.Build(new RunReportInput(false, 3, 2, [], [], [], []));
        Assert.Equal("爬塔者获胜", view.Title);
        Assert.Equal("佛系塔主", view.Honor);
        Assert.Equal(("A", 1), RunReport.Top(["B", "A"])); // 次数相同按名字排，各端一致
        Assert.Equal("摇人", RunReport.BaseName("摇人+2"));
        Assert.Equal("4+", RunReport.BaseName("4+"));
    }
}
