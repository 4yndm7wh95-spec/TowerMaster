using TowerMaster.Core;

namespace TowerMaster.Core.Tests;

public class MasterEventsTests
{
    [Fact]
    public void PickIsDeterministicAndCoversAllEvents()
    {
        Assert.Equal(MasterEvents.Pick(123, 5).Id, MasterEvents.Pick(123, 5).Id);
        var seen = Enumerable.Range(1, 200).Select(f => MasterEvents.Pick(987654321, f).Id).Distinct().Count();
        Assert.Equal(MasterEvents.All.Count, seen);
        var wins = Enumerable.Range(1, 400).Count(f => MasterEvents.GambleWins(42, f));
        Assert.InRange(wins, 150, 250);
        Assert.Equal(-1, MasterEvents.Index(1, 1, 1, 0));
    }

    [Fact]
    public void LocEntriesAreCompleteAndSafeForFormatter()
    {
        var entries = MasterEvents.LocEntries();
        foreach (var e in MasterEvents.All)
        {
            Assert.True(entries.ContainsKey($"{e.LocKey}.title"));
            Assert.True(entries.ContainsKey($"{e.LocKey}.pages.INITIAL.description"));
            Assert.InRange(e.Options.Count, 2, 3);
            foreach (var o in e.Options) Assert.True(entries.ContainsKey($"{e.LocKey}.pages.INITIAL.options.{o.Key}.title"));
        }
        // 游戏的本地化用 SmartFormat，花括号会被当成变量
        Assert.DoesNotContain(entries.Values, v => v.Contains('{') || v.Contains('}'));
    }
}
