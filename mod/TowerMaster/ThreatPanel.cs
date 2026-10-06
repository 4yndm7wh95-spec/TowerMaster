using TowerMaster.Core;
using G = Godot;
using P = TowerMaster.SummonPanel;

namespace TowerMaster;

/// <summary>
/// 塔主回合面板（只在塔主电脑上）：停靠在屏幕左边（挡住的是玩家角色，玩家的信息面板里都有；怪物在右边要看得见）；列出活着的怪和每名玩家（含手牌），
/// 每项旁边是可以花威胁点的按钮。每条指令执行完（<see cref="ThreatPhase.Applied"/>）就重画列表。
/// 样式沿用召唤面板。
/// </summary>
internal sealed class ThreatPanel : IThreatUi
{
    private G.CanvasLayer? _layer;
    private G.VBoxContainer _list = null!;
    private G.Label _points = null!, _status = null!;
    private G.Label? _timer;
    private G.ProgressBar? _timerBar;
    private ulong _lastTicks;

    public void Show()
    {
        _layer = new G.CanvasLayer { Layer = 100 };
        var screen = P.Tree.Root.GetVisibleRect().Size;
        float width = Math.Min(560, screen.X * 0.36f);

        var panel = new G.PanelContainer();
        panel.AddThemeStyleboxOverride("panel", P.Box(P.PanelBg, P.Gold, 3, 14, 18, shadow: 18));
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
        top.AddChild(P.Text($"塔主回合 · 第 {ThreatPhase.Round} 回合", 30, P.Gold));
        top.AddChild(P.Spacer());
        _points = P.Text("", 26, P.TextMain);
        top.AddChild(_points);
        box.AddChild(top);
        box.AddChild(P.Text("玩家暂停出牌，等你结束。看手牌，给怪加强或给玩家上减益。", 17, P.TextDim));
        if (!ThreatPhase.Unlimited)
        {
            var row = new G.HBoxContainer();
            row.AddThemeConstantOverride("separation", 10);
            _timerBar = P.Bar(ThreatPhase.TotalSeconds, ThreatPhase.TotalSeconds, P.Gold, 8);
            _timerBar.SizeFlagsHorizontal = G.Control.SizeFlags.ExpandFill;
            _timerBar.SizeFlagsVertical = G.Control.SizeFlags.ShrinkCenter;
            row.AddChild(_timerBar);
            _timer = P.Text("", 22, P.TextMain);
            row.AddChild(_timer);
            box.AddChild(row);
        }
        box.AddChild(P.Divider());

        var scroll = new G.ScrollContainer { HorizontalScrollMode = G.ScrollContainer.ScrollMode.Disabled, SizeFlagsVertical = G.Control.SizeFlags.ExpandFill };
        _list = new G.VBoxContainer { SizeFlagsHorizontal = G.Control.SizeFlags.ExpandFill };
        _list.AddThemeConstantOverride("separation", 10);
        scroll.AddChild(_list);
        box.AddChild(scroll);

        box.AddChild(P.Divider());
        _status = P.Text("", 18, P.TextDim);
        _status.AutowrapMode = G.TextServer.AutowrapMode.WordSmart;
        box.AddChild(_status);
        var end = P.MakeButton("结束塔主回合", P.Teal, P.TealHover, P.Gold, P.TextMain, new G.Vector2(0, 56), 24);
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
        if (_timer == null || _timerBar == null || _layer == null) return;
        _timer.Text = $"{Math.Ceiling(ThreatPhase.SecondsLeft)}";
        _timerBar.Value = ThreatPhase.SecondsLeft;
    }

    private void Rebuild()
    {
        if (_layer == null || !G.GodotObject.IsInstanceValid(_list)) return;
        foreach (var child in _list.GetChildren()) child.QueueFree();
        var session = ThreatPhase.Session;
        _points.Text = $"威胁点 {session?.Points ?? 0}";
        var prices = ThreatPhase.Prices;
        int act = session?.ActNo ?? 1;
        var (monsters, players) = ThreatPhase.Snapshot();

        _list.AddChild(P.Text("怪物", 21, P.Gold));
        foreach (var m in monsters)
        {
            var card = Card();
            var col = (G.VBoxContainer)card.GetChild(0);
            var head = new G.HBoxContainer();
            var name = P.Text(m.Name, 21, P.TextMain);
            name.SizeFlagsHorizontal = G.Control.SizeFlags.ExpandFill;
            head.AddChild(name);
            head.AddChild(P.Text($"生命 {m.Hp}/{m.MaxHp}" + (m.Block > 0 ? $" · 格挡 {m.Block}" : "") + (m.Strength != 0 ? $" · 力量 {m.Strength}" : ""), 18, P.TextDim));
            col.AddChild(head);
            var buttons = Row();
            buttons.AddChild(Op($"格挡 +{TowerMasterConfig.ByAct(prices.BlockAmount, act)}", prices.BlockCost, () => ThreatPhase.Act("block", m.Index)));
            buttons.AddChild(Op($"回血 +{Math.Max(1, m.MaxHp * prices.HealPercent / 100)}（剩{m.HealsLeft}次）", prices.HealCost, () => ThreatPhase.Act("heal", m.Index)));
            buttons.AddChild(Op($"力量 +{TowerMasterConfig.ByAct(prices.StrengthAmount, act)}（{m.StrengthFromMaster}/{session?.StrengthCap ?? 0}）", prices.StrengthCost, () => ThreatPhase.Act("strength", m.Index)));
            col.AddChild(buttons);
            _list.AddChild(card);
        }
        if (monsters.Count > 1)
            _list.AddChild(Op($"所有怪物力量 +{prices.StrengthAllAmount}（每场 {prices.StrengthAllPerBattle} 次）", prices.StrengthAllCost, () => ThreatPhase.Act("strength_all")));

        _list.AddChild(P.Text("玩家", 21, P.Gold));
        foreach (var p in players)
        {
            var card = Card();
            var col = (G.VBoxContainer)card.GetChild(0);
            var head = new G.HBoxContainer();
            var name = P.Text($"玩家 {p.NetId}", 21, P.TextMain);
            name.SizeFlagsHorizontal = G.Control.SizeFlags.ExpandFill;
            head.AddChild(name);
            head.AddChild(P.Text($"生命 {p.Hp}/{p.MaxHp}" + (p.Block > 0 ? $" · 格挡 {p.Block}" : ""), 18, P.TextDim));
            col.AddChild(head);
            var hand = P.Text("手牌：" + (p.Hand.Count == 0 ? "（看不到）" : string.Join("、", p.Hand)), 17, P.TextMain);
            hand.AutowrapMode = G.TextServer.AutowrapMode.WordSmart;
            col.AddChild(hand);
            if (p.Powers.Count > 0) col.AddChild(P.Text("状态：" + string.Join("、", p.Powers), 16, P.TextDim));
            var buttons = Row();
            ulong id = p.NetId;
            buttons.AddChild(Op("虚弱", prices.DebuffCost, () => ThreatPhase.Act("weak", player: id)));
            buttons.AddChild(Op("易伤", prices.DebuffCost, () => ThreatPhase.Act("vulnerable", player: id)));
            buttons.AddChild(Op("脆弱", prices.DebuffCost, () => ThreatPhase.Act("frail", player: id)));
            buttons.AddChild(Op("塞眩晕", prices.DazedCost, () => ThreatPhase.Act("dazed", player: id)));
            col.AddChild(buttons);
            _list.AddChild(card);
        }
        P.ApplyGameFont(_list);
    }

    private static G.PanelContainer Card()
    {
        var card = new G.PanelContainer();
        card.AddThemeStyleboxOverride("panel", P.Box(P.CardBg, P.CardBorder, 1, 10, 12));
        var col = new G.VBoxContainer();
        col.AddThemeConstantOverride("separation", 6);
        card.AddChild(col);
        return card;
    }

    private static G.HFlowContainer Row()
    {
        var row = new G.HFlowContainer();
        row.AddThemeConstantOverride("h_separation", 8);
        row.AddThemeConstantOverride("v_separation", 6);
        return row;
    }

    private G.Button Op(string label, int cost, Func<(bool Ok, string Message)> act)
    {
        var button = P.MakeButton($"{label} · {cost}点", new G.Color(0.20f, 0.17f, 0.09f), new G.Color(0.30f, 0.24f, 0.12f), P.GoldDim, P.Gold, new G.Vector2(0, 40), 17);
        button.Disabled = (ThreatPhase.Session?.Points ?? 0) < cost;
        button.Pressed += () =>
        {
            var (ok, message) = act();
            _status.Text = (ok ? "✓ " : "✗ ") + message;
            _status.AddThemeColorOverride("font_color", ok ? P.Good : P.Bad);
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
        holder.Position = new G.Vector2(0, 150);
        var panel = new G.PanelContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore };
        panel.AddThemeStyleboxOverride("panel", P.Box(new G.Color(0.25f, 0.08f, 0.10f, 0.92f), P.Gold, 2, 12, 16, shadow: 12));
        var label = P.Text("塔主回合：塔主正在行动，稍等再出牌", 26, P.Gold);
        label.MouseFilter = G.Control.MouseFilterEnum.Ignore;
        panel.AddChild(label);
        holder.AddChild(panel);
        _banner.AddChild(holder);
        P.ApplyGameFont(_banner);
        P.Tree.Root.CallDeferred(G.Node.MethodName.AddChild, _banner);
    }
}
