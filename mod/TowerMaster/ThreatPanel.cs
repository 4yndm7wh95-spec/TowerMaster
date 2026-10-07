using TowerMaster.Core;
using G = Godot;
using P = TowerMaster.SummonPanel;

namespace TowerMaster;

/// <summary>
/// 塔主回合面板（只在塔主电脑上）：停靠在屏幕左边（挡住的是玩家角色，玩家信息面板里都有；怪物在右边要看得见）。
/// 版式：顶部「塔主回合」+ 威胁点；下面每只怪、每名玩家一张紧凑卡片（名字、血量一行，操作按钮一行），
/// 按钮上只写效果，花费用 ◆ 表示，说明都在悬停提示里。每条指令执行完（<see cref="ThreatPhase.Applied"/>）就重画。
/// </summary>
internal sealed class ThreatPanel : IThreatUi
{
    private G.CanvasLayer? _layer;
    private G.VBoxContainer _list = null!;
    private G.Control _points = null!;
    private G.HBoxContainer _pointsRow = null!;
    private G.Label _status = null!;
    private G.Label? _timer;
    private ulong _lastTicks;

    public void Show()
    {
        _layer = new G.CanvasLayer { Layer = 100 };
        var screen = P.Tree.Root.GetVisibleRect().Size;
        float width = Math.Min(430, screen.X * 0.30f);

        var panel = new G.PanelContainer();
        panel.AddThemeStyleboxOverride("panel", P.Box(P.PanelBg, P.Gold, 2, 14, 16, shadow: 18));
        panel.SetAnchorsPreset(G.Control.LayoutPreset.LeftWide);
        panel.OffsetLeft = 16;
        panel.OffsetRight = 16 + width;
        panel.OffsetTop = 90;
        panel.OffsetBottom = -24;
        _layer.AddChild(panel);

        var box = new G.VBoxContainer();
        box.AddThemeConstantOverride("separation", 10);
        panel.AddChild(box);

        var top = new G.HBoxContainer();
        top.AddThemeConstantOverride("separation", 10);
        if (Art.Icon("master_portrait", 44) is { } portrait) top.AddChild(portrait);
        var titles = new G.VBoxContainer();
        titles.AddThemeConstantOverride("separation", 0);
        titles.AddChild(P.Text("塔主回合", 28, P.Gold));
        titles.AddChild(P.Text($"第 {ThreatPhase.Round} 回合 · 玩家等你行动", 15, P.TextDim));
        top.AddChild(titles);
        top.AddChild(P.Spacer());
        _pointsRow = top;
        _points = new G.Control();
        top.AddChild(_points);
        if (!ThreatPhase.Unlimited)
        {
            _timer = P.Text("", 22, P.TextMain);
            top.AddChild(_timer);
        }
        box.AddChild(top);
        box.AddChild(P.Divider());

        var scroll = new G.ScrollContainer { HorizontalScrollMode = G.ScrollContainer.ScrollMode.Disabled, SizeFlagsVertical = G.Control.SizeFlags.ExpandFill };
        _list = new G.VBoxContainer { SizeFlagsHorizontal = G.Control.SizeFlags.ExpandFill };
        _list.AddThemeConstantOverride("separation", 8);
        scroll.AddChild(_list);
        box.AddChild(scroll);

        _status = P.Text("", 15, P.TextDim);
        _status.AutowrapMode = G.TextServer.AutowrapMode.WordSmart;
        box.AddChild(_status);
        var end = P.MakeButton("结束塔主回合", P.Teal, P.TealHover, P.Gold, P.TextMain, new G.Vector2(0, 54), 22);
        end.Pressed += () => ThreatPhase.EndTurn();
        box.AddChild(end);

        ThreatPhase.Applied += Rebuild;
        _lastTicks = G.Time.GetTicksMsec();
        P.Tree.ProcessFrame += OnFrame;
        P.Tree.Root.CallDeferred(G.Node.MethodName.AddChild, _layer);
        Rebuild();
        P.ApplyGameFont(_layer);
    }

    public void Close()
    {
        ThreatPhase.Applied -= Rebuild;
        P.Tree.ProcessFrame -= OnFrame;
        _layer?.QueueFree();
        _layer = null;
    }

    private void OnFrame()
    {
        var now = G.Time.GetTicksMsec();
        ThreatPhase.Tick((now - _lastTicks) / 1000.0);
        _lastTicks = now;
        if (_timer != null && _layer != null) _timer.Text = $"{Math.Ceiling(ThreatPhase.SecondsLeft)}";
    }

    private void Rebuild()
    {
        if (_layer == null || !G.GodotObject.IsInstanceValid(_list)) return;
        foreach (var child in _list.GetChildren()) child.QueueFree();
        var session = ThreatPhase.Session;
        int points = session?.Points ?? 0;

        // 威胁点读数（换掉旧的）
        int at = _points.GetIndex();
        _points.QueueFree();
        _points = P.Resource("icon_threat_point", $"{points}", "威胁点");
        _pointsRow.AddChild(_points);
        _pointsRow.MoveChild(_points, at);

        var prices = ThreatPhase.Prices;
        int act = session?.ActNo ?? 1;
        var (monsters, players) = ThreatPhase.Snapshot();

        _list.AddChild(P.Heading("怪物"));
        foreach (var m in monsters)
        {
            var (card, col) = Card();
            var stats = new List<string> { $"{m.Hp}/{m.MaxHp}" };
            if (m.Block > 0) stats.Add($"挡 {m.Block}");
            if (m.Strength != 0) stats.Add($"力 {m.Strength}");
            col.AddChild(HeadRow(m.Name, string.Join("  ", stats)));
            var row = Row();
            row.AddChild(Op($"格挡 +{TowerMasterConfig.ByAct(prices.BlockAmount, act)}", prices.BlockCost, points,
                "给这只怪加格挡", () => ThreatPhase.Act("block", m.Index)));
            row.AddChild(Op($"回血 +{Math.Max(1, m.MaxHp * prices.HealPercent / 100)}", prices.HealCost, points,
                $"回复 {prices.HealPercent}% 最大生命，这只本场还能回 {m.HealsLeft} 次", () => ThreatPhase.Act("heal", m.Index), m.HealsLeft > 0));
            row.AddChild(Op($"力量 +{TowerMasterConfig.ByAct(prices.StrengthAmount, act)}", prices.StrengthCost, points,
                $"塔主给的力量累计 {m.StrengthFromMaster}/{session?.StrengthCap ?? 0}", () => ThreatPhase.Act("strength", m.Index)));
            col.AddChild(row);
            _list.AddChild(card);
        }
        if (monsters.Count > 1)
            _list.AddChild(Op($"全体力量 +{prices.StrengthAllAmount}", prices.StrengthAllCost, points,
                $"所有怪物加力量，每场 {prices.StrengthAllPerBattle} 次", () => ThreatPhase.Act("strength_all"), stretch: true));

        _list.AddChild(P.Heading("玩家"));
        for (int i = 0; i < players.Count; i++)
        {
            var p = players[i];
            var (card, col) = Card();
            var stats = $"{p.Hp}/{p.MaxHp}" + (p.Block > 0 ? $"  挡 {p.Block}" : "");
            col.AddChild(HeadRow(players.Count > 1 ? $"玩家 {i + 1}" : "玩家", stats));
            if (p.Powers.Count > 0) col.AddChild(P.Text(string.Join("  ", p.Powers), 14, P.TextDim));
            col.AddChild(Hand(p.Hand));
            var row = Row();
            ulong id = p.NetId;
            row.AddChild(Op("虚弱", prices.DebuffCost, points, $"{prices.DebuffStacks} 层；同一玩家每回合只能上 1 次减益", () => ThreatPhase.Act("weak", player: id)));
            row.AddChild(Op("易伤", prices.DebuffCost, points, $"{prices.DebuffStacks} 层；同一玩家每回合只能上 1 次减益", () => ThreatPhase.Act("vulnerable", player: id)));
            row.AddChild(Op("脆弱", prices.DebuffCost, points, $"{prices.DebuffStacks} 层；同一玩家每回合只能上 1 次减益", () => ThreatPhase.Act("frail", player: id)));
            row.AddChild(Op("眩晕", prices.DazedCost, points, $"往抽牌堆塞 1 张眩晕，每场 {prices.DazedPerBattle} 次", () => ThreatPhase.Act("dazed", player: id)));
            col.AddChild(row);
            _list.AddChild(card);
        }
        P.ApplyGameFont(_list);
        P.ApplyGameFont(_points);
    }

    private static (G.PanelContainer, G.VBoxContainer) Card()
    {
        var card = new G.PanelContainer();
        card.AddThemeStyleboxOverride("panel", P.Box(P.CardBg, P.CardBorder, 1, 10, 10));
        var col = new G.VBoxContainer();
        col.AddThemeConstantOverride("separation", 6);
        card.AddChild(col);
        return (card, col);
    }

    private static G.HBoxContainer HeadRow(string name, string stats)
    {
        var head = new G.HBoxContainer();
        var label = P.Text(name, 19, P.TextMain);
        label.SizeFlagsHorizontal = G.Control.SizeFlags.ExpandFill;
        label.ClipText = true;
        head.AddChild(label);
        head.AddChild(P.Text(stats, 16, P.TextDim));
        return head;
    }

    /// <summary>手牌：一排小牌名，放不下就换行。</summary>
    private static G.Control Hand(IReadOnlyList<string> hand)
    {
        var flow = new G.HFlowContainer();
        flow.AddThemeConstantOverride("h_separation", 4);
        flow.AddThemeConstantOverride("v_separation", 4);
        if (hand.Count == 0) flow.AddChild(P.Text("手牌看不到", 14, P.TextDim));
        foreach (var name in hand)
            flow.AddChild(P.Badge(name, P.Sunk, P.TextMain));
        return flow;
    }

    private static G.HBoxContainer Row()
    {
        var row = new G.HBoxContainer();
        row.AddThemeConstantOverride("separation", 6);
        return row;
    }

    /// <summary>操作按钮：效果 + ◆（花费），说明放悬停提示；点数不够或用完了就变灰。</summary>
    private G.Button Op(string label, int cost, int points, string tip, Func<(bool Ok, string Message)> act, bool available = true, bool stretch = true)
    {
        var button = P.MakeButton($"{label} {new string('◆', cost)}", new G.Color(0.20f, 0.17f, 0.09f), new G.Color(0.30f, 0.24f, 0.12f), P.GoldDim, P.Gold, new G.Vector2(0, 36), 15);
        if (stretch) button.SizeFlagsHorizontal = G.Control.SizeFlags.ExpandFill;
        button.TooltipText = $"{tip}\n花费 {cost} 威胁点";
        button.Disabled = points < cost || !available;
        button.Pressed += () =>
        {
            var (ok, message) = act();
            _status.Text = ok ? "" : "✗ " + message;
            _status.AddThemeColorOverride("font_color", P.Bad);
            if (ok) Rebuild(); // 指令执行完还会再刷新一次
        };
        return button;
    }

    // ---------------------------------------------------------------- 爬塔玩家的提示条

    private static G.CanvasLayer? _banner;

    /// <summary>爬塔玩家屏幕上方的「塔主回合」提示。</summary>
    public static void SetBanner(bool visible)
    {
        if (!visible)
        {
            _banner?.QueueFree();
            _banner = null;
            return;
        }
        if (_banner != null) return;
        _banner = new G.CanvasLayer { Layer = 99 };
        var holder = new G.CenterContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore };
        holder.SetAnchorsPreset(G.Control.LayoutPreset.TopWide);
        holder.Position = new G.Vector2(0, 110);
        var panel = new G.PanelContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore };
        panel.AddThemeStyleboxOverride("panel", P.Box(new G.Color(0.22f, 0.07f, 0.09f, 0.92f), P.Gold, 2, 12, 12, shadow: 10));
        var row = new G.HBoxContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore };
        row.AddThemeConstantOverride("separation", 10);
        if (Art.Icon("master_portrait", 34) is { } icon) row.AddChild(icon);
        var label = P.Text("塔主行动中…", 24, P.Gold);
        label.MouseFilter = G.Control.MouseFilterEnum.Ignore;
        row.AddChild(label);
        panel.AddChild(row);
        holder.AddChild(panel);
        _banner.AddChild(holder);
        P.ApplyGameFont(_banner);
        P.Tree.Root.CallDeferred(G.Node.MethodName.AddChild, _banner);
    }
}
