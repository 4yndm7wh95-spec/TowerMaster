namespace TowerMaster.Core;

/// <summary>一局结束时塔主战报的原始数据（各端都能凑出同样的一份）。</summary>
/// <param name="MasterWon">爬塔玩家全灭 = 塔主赢。</param>
/// <param name="Summoned">每场召唤的怪（中文名，一只一项，同一场召唤两只就出现两次）。</param>
/// <param name="Bosses">塔主挑的 Boss（中文名）。</param>
/// <param name="Traps">触发过的陷阱（名字，可能带 +1/+2）。</param>
/// <param name="Cards">塔主打出的牌（名字，可能带 +1/+2）。</param>
public sealed record RunReportInput(bool MasterWon, int Floor, int Fights, IReadOnlyList<string> Summoned,
    IReadOnlyList<string> Bosses, IReadOnlyList<string> Traps, IReadOnlyList<string> Cards);

public sealed record RunReportView(string Title, string Subtitle, string Honor, string HonorReason, IReadOnlyList<(string Label, string Value)> Lines);

/// <summary>
/// 塔主战报：把一局里塔主干过的事总结成几行，再按数据颁一个（多半是搞笑的）称号。娱乐向，不影响规则。
/// </summary>
public static class RunReport
{
    /// <summary>「摇人+1」「摇人+2」都算「摇人」。</summary>
    public static string BaseName(string name)
    {
        int plus = name.LastIndexOf('+');
        return plus > 0 && int.TryParse(name[(plus + 1)..], out _) ? name[..plus] : name;
    }

    /// <summary>出现最多的一项和次数；空列表返回 null。次数相同按名字排，保证各端一样。</summary>
    public static (string Name, int Count)? Top(IEnumerable<string> items) =>
        items.Select(BaseName).GroupBy(x => x).OrderByDescending(g => g.Count()).ThenBy(g => g.Key, StringComparer.Ordinal)
            .Select(g => ((string, int)?)(g.Key, g.Count())).FirstOrDefault();

    public static RunReportView Build(RunReportInput r)
    {
        var lines = new List<(string, string)>
        {
            ("战斗", $"{r.Fights} 场，打到第 {r.Floor} 层"),
            ("召唤怪物", r.Summoned.Count == 0 ? "一只没召（全按原版出场）" : $"{r.Summoned.Count} 只" + (Top(r.Summoned) is { } m ? $"，最爱 {m.Name} ×{m.Count}" : "")),
        };
        if (r.Bosses.Count > 0) lines.Add(("挑的 Boss", string.Join("、", r.Bosses)));
        lines.Add(("陷阱触发", r.Traps.Count == 0 ? "0 次" : $"{r.Traps.Count} 次" + (Top(r.Traps) is { } t ? $"，最得意 {t.Name} ×{t.Count}" : "")));
        lines.Add(("塔主出牌", r.Cards.Count == 0 ? "0 张" : $"{r.Cards.Count} 张" + (Top(r.Cards) is { } c ? $"，最常用 {c.Name} ×{c.Count}" : "")));
        var (honor, reason) = Honor(r);
        return new RunReportView(
            r.MasterWon ? "塔主获胜！" : "爬塔者获胜",
            r.MasterWon ? "爬塔者全军覆没。塔主本局战报：" : "塔主还是没拦住。塔主本局战报：",
            honor, reason, lines);
    }

    private static int Count(IEnumerable<string> items, string name) => items.Count(x => BaseName(x) == name);

    /// <summary>称号：按顺序第一个满足的；都不满足给保底称号。</summary>
    private static (string, string) Honor(RunReportInput r)
    {
        int gamble = Count(r.Cards, "惊喜盲盒"), callHelp = Count(r.Cards, "摇人"), heckle = Count(r.Cards, "起哄");
        int slime = Count(r.Cards, "黏液大礼包"), feast = Count(r.Cards, "请客");
        if (gamble >= 3) return ("赌狗塔主", $"开了 {gamble} 次惊喜盲盒，命运全交给骰子");
        if (callHelp >= 3) return ("摇人专业户", $"摇了 {callHelp} 次人，塔里的怪都认识你");
        if (slime >= 3) return ("黏液快递员", $"送出 {slime} 份黏液大礼包，签收率 100%");
        if (heckle >= 3) return ("气氛组组长", $"起哄 {heckle} 次，全场最吵");
        if (feast >= 3) return ("慷慨的东道主", $"请客 {feast} 次，怪物吃得很饱");
        if (r.Traps.Count >= 6) return ("陷阱艺术家", $"陷阱触发 {r.Traps.Count} 次，步步惊心");
        if (r.Cards.Count == 0 && r.Traps.Count == 0) return ("佛系塔主", "全程没出牌、没触发陷阱，主打一个陪伴");
        if (r.Summoned.Count >= r.Fights * 3 && r.Fights > 0) return ("人海战术家", $"平均每场召唤 {(double)r.Summoned.Count / r.Fights:0.#} 只怪");
        return r.MasterWon ? ("冷酷的塔主", "赢就完事了") : ("尽力了的塔主", "下次一定");
    }
}
