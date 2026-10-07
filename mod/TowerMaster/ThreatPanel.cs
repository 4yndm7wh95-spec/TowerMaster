using System.Collections;
using TowerMaster.Core;
using G = Godot;
using P = TowerMaster.SummonPanel;

namespace TowerMaster;

/// <summary>
/// 塔主回合界面（只在塔主电脑上），仿原版出牌：
/// - 屏幕底部一排「行动卡」（格挡、回血、力量、虚弱…），卡上是图标、名字、◆ 花费；点数不够的卡变暗。
/// - 点一张卡选中它，战场上能作用的怪或玩家头顶出现目标按钮（显示效果数值），点目标就施放；全体力量直接施放。再点同一张卡或右键取消。
/// - 左上一块小面板只放玩家信息（血量、状态、手牌），塔主据此决定。
/// - 底部右边是威胁点和「结束回合」。
/// 每条指令执行完（<see cref="ThreatPhase.Applied"/>）刷新。
/// </summary>
internal sealed class ThreatPanel : IThreatUi
{
    private enum Target { Monster, Player, None }

    /// <param name="Text">原版卡牌风格的卡面说明（关键词用 k 包起来高亮）。</param>
    /// <param name="Rules">悬停提示里补充的限制。</param>
    private sealed record ActionDef(string Op, string Name, string Icon, Target Target, Func<ThreatPrices, int> Cost,
        Func<ThreatPrices, int, Func<string, string>, string> Text, Func<ThreatPrices, string> Rules);

    private static readonly ActionDef[] Actions =
    [
        new("block", "加固", "act_block", Target.Monster, p => p.BlockCost,
            (p, act, k) => $"选择一名敌人，使其获得 {TowerMasterConfig.ByAct(p.BlockAmount, act)} 点{k("格挡")}。",
            _ => "格挡在敌人的下个回合开始时消失。"),
        new("heal", "治疗", "act_heal", Target.Monster, p => p.HealCost,
            (p, _, k) => $"选择一名敌人，使其回复 {p.HealPercent}% 最大生命值。",
            p => $"每名敌人每场战斗最多被治疗 {p.HealPerMonsterPerBattle} 次。"),
        new("strength", "激励", "act_strength", Target.Monster, p => p.StrengthCost,
            (p, act, k) => $"选择一名敌人，使其获得 {TowerMasterConfig.ByAct(p.StrengthAmount, act)} 点{k("力量")}。",
            p => $"每名敌人从塔主获得的力量（含陷阱）不超过本幕上限：{string.Join(" / ", p.StrengthCap)}。"),
        new("strength_all", "战吼", "act_strength_all", Target.None, p => p.StrengthAllCost,
            (p, _, k) => $"所有敌人获得 {p.StrengthAllAmount} 点{k("力量")}。",
            p => $"每场战斗限 {p.StrengthAllPerBattle} 次。已到力量上限的敌人不受影响。"),
        new("weak", "虚弱", "act_weak", Target.Player, p => p.DebuffCost,
            (p, _, k) => $"给予一名玩家 {p.DebuffStacks} 层{k("虚弱")}。",
            p => $"虚弱：造成的攻击伤害减少 25%。同一名玩家每回合最多被塔主施加 {p.DebuffPerPlayerPerTurn} 次减益。"),
        new("vulnerable", "易伤", "act_vulnerable", Target.Player, p => p.DebuffCost,
            (p, _, k) => $"给予一名玩家 {p.DebuffStacks} 层{k("易伤")}。",
            p => $"易伤：受到的攻击伤害增加 50%。同一名玩家每回合最多被塔主施加 {p.DebuffPerPlayerPerTurn} 次减益。"),
        new("frail", "脆弱", "act_frail", Target.Player, p => p.DebuffCost,
            (p, _, k) => $"给予一名玩家 {p.DebuffStacks} 层{k("脆弱")}。",
            p => $"脆弱：从卡牌获得的格挡减少 25%。同一名玩家每回合最多被塔主施加 {p.DebuffPerPlayerPerTurn} 次减益。"),
        new("dazed", "晕眩", "act_dazed", Target.Player, p => p.DazedCost,
            (_, _, k) => $"将 1 张{k("晕眩")}放入一名玩家的抽牌堆。",
            p => $"每场战斗最多 {p.DazedPerBattle} 次。"),
    ];

    /// <summary>目标按钮上的短效果。</summary>
    private static string Short(ActionDef a, ThreatPrices p, int act) => a.Op switch
    {
        "block" => $"+{TowerMasterConfig.ByAct(p.BlockAmount, act)} 格挡",
        "heal" => $"回复 {p.HealPercent}%",
        "strength" => $"+{TowerMasterConfig.ByAct(p.StrengthAmount, act)} 力量",
        "strength_all" => $"全体 +{p.StrengthAllAmount} 力量",
        "weak" => $"虚弱 {p.DebuffStacks}",
        "vulnerable" => $"易伤 {p.DebuffStacks}",
        "frail" => $"脆弱 {p.DebuffStacks}",
        _ => "+1 晕眩",
    };

    private G.CanvasLayer? _layer;
    private G.Control _targets = null!;
    private G.VBoxContainer _info = null!;
    private G.HBoxContainer _hand = null!, _points = null!;
    private G.Label _status = null!;
    private G.Label? _timer;
    private ActionDef? _selected;
    private ulong _lastTicks;
    private int _frame;

    /// <summary>正在显示的塔主回合界面（测试接口用）。</summary>
    internal static ThreatPanel? Current { get; private set; }

    /// <summary>按操作名选中行动卡；null 取消（测试接口用，和点卡/右键一样）。</summary>
    internal void SelectByOp(string? op) => Select(op == null ? null : Actions.FirstOrDefault(a => a.Op == op));

    public void Show()
    {
        Current = this;
        _layer = new G.CanvasLayer { Layer = 100 };

        _targets = new G.Control { MouseFilter = G.Control.MouseFilterEnum.Ignore };
        _targets.SetAnchorsPreset(G.Control.LayoutPreset.FullRect);
        _layer.AddChild(_targets);

        _layer.AddChild(InfoPanel());
        _layer.AddChild(BottomBar());

        ThreatPhase.Applied += Rebuild;
        _lastTicks = G.Time.GetTicksMsec();
        P.Tree.ProcessFrame += OnFrame;
        P.AddDeferred(_layer);
        Rebuild();
        P.ApplyGameFont(_layer);
    }

    public void Close()
    {
        if (_layer == null) return; // 关两次时第二次不要再解绑 ProcessFrame（Godot 会报断开不存在的连接）
        if (Current == this) Current = null;
        ThreatPhase.Applied -= Rebuild;
        P.Tree.ProcessFrame -= OnFrame;
        _layer?.QueueFree();
        _layer = null;
    }

    // ---------------------------------------------------------------- 版面

    private G.Control InfoPanel()
    {
        var panel = new G.PanelContainer { CustomMinimumSize = new G.Vector2(300, 0) };
        panel.AddThemeStyleboxOverride("panel", P.Box(new G.Color(P.PanelBg.R, P.PanelBg.G, P.PanelBg.B, 0.92f), P.GoldDim, 1, 12, 14, shadow: 12));
        panel.Position = new G.Vector2(16, 90);
        var col = new G.VBoxContainer();
        col.AddThemeConstantOverride("separation", 8);
        var head = new G.HBoxContainer();
        head.AddThemeConstantOverride("separation", 8);
        if (Art.Icon("master_portrait", 40) is { } portrait) head.AddChild(portrait);
        var titles = new G.VBoxContainer();
        titles.AddThemeConstantOverride("separation", 0);
        titles.AddChild(P.Text("塔主回合", 24, P.Gold));
        titles.AddChild(P.Text($"第 {ThreatPhase.Round} 回合", 14, P.TextDim));
        head.AddChild(titles);
        col.AddChild(head);
        _info = new G.VBoxContainer();
        _info.AddThemeConstantOverride("separation", 8);
        col.AddChild(_info);
        panel.AddChild(col);
        return panel;
    }

    private G.Control BottomBar()
    {
        var bar = new G.PanelContainer();
        bar.AddThemeStyleboxOverride("panel", P.Box(new G.Color(0.04f, 0.05f, 0.08f, 0.90f), P.GoldDim, 1, 16, 12, shadow: 16));
        bar.SetAnchorsPreset(G.Control.LayoutPreset.CenterBottom);
        bar.GrowHorizontal = G.Control.GrowDirection.Both;
        bar.GrowVertical = G.Control.GrowDirection.Begin;
        bar.OffsetBottom = -14;

        var row = new G.HBoxContainer();
        row.AddThemeConstantOverride("separation", 16);
        _hand = new G.HBoxContainer();
        _hand.AddThemeConstantOverride("separation", 8);
        row.AddChild(_hand);

        var side = new G.VBoxContainer { CustomMinimumSize = new G.Vector2(170, 0), Alignment = G.BoxContainer.AlignmentMode.Center };
        side.AddThemeConstantOverride("separation", 8);
        _points = new G.HBoxContainer { Alignment = G.BoxContainer.AlignmentMode.Center };
        side.AddChild(_points);
        _status = P.Text("选一张行动卡", 14, P.TextDim);
        _status.HorizontalAlignment = G.HorizontalAlignment.Center;
        _status.AutowrapMode = G.TextServer.AutowrapMode.WordSmart;
        _status.CustomMinimumSize = new G.Vector2(170, 0);
        side.AddChild(_status);
        if (!ThreatPhase.Unlimited)
        {
            _timer = P.Text("", 18, P.TextMain);
            _timer.HorizontalAlignment = G.HorizontalAlignment.Center;
            side.AddChild(_timer);
        }
        var end = P.MakeButton("结束回合", P.Teal, P.TealHover, P.Gold, P.TextMain, new G.Vector2(170, 48), 20);
        end.Pressed += () => ThreatPhase.EndTurn();
        side.AddChild(end);
        row.AddChild(side);
        bar.AddChild(row);
        return bar;
    }

    // ---------------------------------------------------------------- 刷新

    private void OnFrame()
    {
        var now = G.Time.GetTicksMsec();
        ThreatPhase.Tick((now - _lastTicks) / 1000.0);
        _lastTicks = now;
        if (_layer == null) return;
        if (_timer != null) _timer.Text = $"{Math.Ceiling(ThreatPhase.SecondsLeft)} 秒";
        if (++_frame % 15 == 0 && _selected != null) PlaceTargets(); // 怪物动画会挪位置，隔一会儿重新对齐目标按钮
        if (G.Input.IsMouseButtonPressed(G.MouseButton.Right) && _selected != null) Select(null);
    }

    private void Rebuild()
    {
        if (_layer == null || !G.GodotObject.IsInstanceValid(_hand)) return;
        var session = ThreatPhase.Session;
        int points = session?.Points ?? 0;
        var prices = ThreatPhase.Prices;
        int act = session?.ActNo ?? 1;

        foreach (var child in _points.GetChildren()) child.QueueFree();
        if (Art.Icon("icon_threat_point", 30) is { } icon) _points.AddChild(icon);
        _points.AddChild(P.Text($"{points}", 30, P.Gold));
        int later = (session?.Remaining ?? 0) - points;
        if (later > 0) _points.AddChild(P.Text($"+{later}", 16, P.TextDim));
        _points.TooltipText = $"现在能用 {points} 威胁点" + (later > 0 ? $"；还有 {later} 点在之后的回合解锁（每回合 +{ModEntry.Active.ThreatReleasePerTurn}）" : "") + "\n没用完的点数留到之后的回合。";

        foreach (var child in _hand.GetChildren()) child.QueueFree();
        var (monsters, _) = ThreatPhase.Snapshot();
        foreach (var a in Actions)
        {
            if (a.Op == "strength_all" && monsters.Count < 2) continue;
            _hand.AddChild(ActionCard(a, prices, act, points));
        }

        RebuildInfo();
        if (_selected != null && (session?.Points ?? 0) < _selected.Cost(prices)) _selected = null;
        PlaceTargets();
        P.ApplyGameFont(_layer);
    }

    private void RebuildInfo()
    {
        foreach (var child in _info.GetChildren()) child.QueueFree();
        var (_, players) = ThreatPhase.Snapshot();
        for (int i = 0; i < players.Count; i++)
        {
            var p = players[i];
            var card = new G.PanelContainer();
            card.AddThemeStyleboxOverride("panel", P.Box(P.CardBg, P.CardBorder, 1, 10, 10));
            var col = new G.VBoxContainer();
            col.AddThemeConstantOverride("separation", 5);
            var head = new G.HBoxContainer();
            var name = P.Text(players.Count > 1 ? $"玩家 {i + 1}" : "玩家", 18, P.TextMain);
            name.SizeFlagsHorizontal = G.Control.SizeFlags.ExpandFill;
            head.AddChild(name);
            head.AddChild(P.Text($"{p.Hp}/{p.MaxHp}" + (p.Block > 0 ? $"  挡{p.Block}" : ""), 15, P.TextDim));
            col.AddChild(head);
            if (p.Powers.Count > 0) col.AddChild(P.Text(string.Join("  ", p.Powers), 13, P.TextDim));
            var hand = new G.HFlowContainer();
            hand.AddThemeConstantOverride("h_separation", 4);
            hand.AddThemeConstantOverride("v_separation", 4);
            if (p.Hand.Count == 0) hand.AddChild(P.Text("手牌看不到", 13, P.TextDim));
            foreach (var c in p.Hand) hand.AddChild(P.Badge(c, P.Sunk, P.TextMain));
            col.AddChild(hand);
            card.AddChild(col);
            _info.AddChild(card);
        }
    }

    /// <summary>行动卡：竖版小卡，上面图标（没有图就用大字），下面名字和 ◆ 花费。选中时抬高、金边。</summary>
    private G.Button ActionCard(ActionDef a, ThreatPrices prices, int act, int points)
    {
        int cost = a.Cost(prices);
        bool selected = _selected?.Op == a.Op;
        var card = new G.Button
        {
            FocusMode = G.Control.FocusModeEnum.None,
            CustomMinimumSize = new G.Vector2(96, 132),
            Disabled = points < cost,
            TooltipText = $"{a.Name}（{cost} 威胁点）\n{a.Text(prices, act, w => w)}\n{a.Rules(prices)}",
        };
        var bg = selected ? new G.Color(0.24f, 0.19f, 0.10f) : P.CardBg;
        card.AddThemeStyleboxOverride("normal", P.Box(bg, selected ? P.Gold : P.CardBorder, selected ? 3 : 1, 10, 0));
        card.AddThemeStyleboxOverride("hover", P.Box(P.CardHover, P.Gold, 2, 10, 0));
        card.AddThemeStyleboxOverride("pressed", P.Box(P.CardHover, P.Gold, 3, 10, 0));
        card.AddThemeStyleboxOverride("disabled", P.Box(new G.Color(0.09f, 0.10f, 0.13f), new G.Color(0.18f, 0.20f, 0.24f), 1, 10, 0));
        card.AddThemeStyleboxOverride("focus", new G.StyleBoxEmpty());

        // 原版卡框（失败就用下面的自绘小卡）
        var face = new CardFace(a.Name, a.Text(prices, act, VanillaCard.Kw), "塔主", $"{cost}", a.Icon);
        if (VanillaCard.Create(face, 0.46f) is { } vanilla)
        {
            if (!card.Disabled) VanillaCard.HoverZoom(card, vanilla, 1.6f, 10);
            card.CustomMinimumSize = vanilla.CustomMinimumSize + new G.Vector2(8, 8);
            vanilla.Position = new G.Vector2(4, selected ? -14 : 4); // 选中的卡抬起来
            card.AddChild(vanilla);
            card.AddThemeStyleboxOverride("normal", P.Box(new G.Color(0, 0, 0, 0), selected ? P.Gold : new G.Color(0, 0, 0, 0), selected ? 3 : 0, 14, 0));
            card.AddThemeStyleboxOverride("hover", P.Box(new G.Color(1, 1, 1, 0.04f), P.Gold, 2, 14, 0));
            card.AddThemeStyleboxOverride("disabled", P.Box(new G.Color(0, 0, 0, 0), new G.Color(0, 0, 0, 0), 0, 14, 0));
            if (card.Disabled) card.Modulate = new G.Color(0.6f, 0.6f, 0.6f, 0.6f);
            card.Pressed += () =>
            {
                if (a.Target == Target.None) { Do(a.Op); return; }
                Select(_selected?.Op == a.Op ? null : a);
            };
            return card;
        }

        var col = new G.VBoxContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore, Alignment = G.BoxContainer.AlignmentMode.Center };
        col.SetAnchorsPreset(G.Control.LayoutPreset.FullRect);
        col.AddThemeConstantOverride("separation", 4);
        var iconBox = new G.CenterContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore, CustomMinimumSize = new G.Vector2(0, 62) };
        if (Art.Icon(a.Icon, 56) is { } icon) iconBox.AddChild(icon);
        else iconBox.AddChild(P.Text(a.Name[..1], 36, P.Gold));
        col.AddChild(iconBox);
        var name = P.Text(a.Name, 17, card.Disabled ? P.TextDim : P.TextMain);
        name.HorizontalAlignment = G.HorizontalAlignment.Center;
        name.MouseFilter = G.Control.MouseFilterEnum.Ignore;
        col.AddChild(name);
        var costLabel = P.Text(new string('◆', cost), 14, card.Disabled ? P.TextDim : P.Gold);
        costLabel.HorizontalAlignment = G.HorizontalAlignment.Center;
        costLabel.MouseFilter = G.Control.MouseFilterEnum.Ignore;
        col.AddChild(costLabel);
        card.AddChild(col);

        card.Pressed += () =>
        {
            if (a.Target == Target.None) { Do(a.Op); return; }
            Select(_selected?.Op == a.Op ? null : a);
        };
        return card;
    }

    private void Select(ActionDef? action)
    {
        _selected = action;
        _status.Text = action == null ? "选一张行动卡" : action.Target == Target.Monster ? "点一只怪" : "点一名玩家";
        _status.AddThemeColorOverride("font_color", P.TextDim);
        Rebuild();
    }

    private void Do(string op, int monster = -1, ulong player = 0)
    {
        var (ok, message) = ThreatPhase.Act(op, monster, player);
        _status.Text = ok ? "✓ " + ThreatPhase.OpName(op) : "✗ " + message;
        _status.AddThemeColorOverride("font_color", ok ? P.Good : P.Bad);
        _selected = null;
        Rebuild(); // 指令执行完还会再刷新一次
    }

    // ---------------------------------------------------------------- 战场上的目标按钮

    /// <summary>选中行动卡后，在每个能作用的怪或玩家头顶放一个目标按钮（位置取原版 NCreature 的点击框）。</summary>
    private void PlaceTargets()
    {
        if (!G.GodotObject.IsInstanceValid(_targets)) return;
        foreach (var child in _targets.GetChildren()) child.QueueFree();
        if (_selected == null || ThreatPhase.CombatState() is not { } combat) return;
        var prices = ThreatPhase.Prices;
        int act = ThreatPhase.Session?.ActNo ?? 1;
        var (monsters, players) = ThreatPhase.Snapshot();
        var enemies = (GameReflection.Get(combat, "Enemies") as IEnumerable)?.Cast<object>().ToList() ?? [];

        foreach (var (node, entity) in CreatureNodes())
        {
            if (_selected.Target == Target.Monster)
            {
                int index = enemies.FindIndex(e => ReferenceEquals(e, entity));
                var view = monsters.FirstOrDefault(m => m.Index == index);
                if (index < 0 || view == null) continue;
                string label = _selected.Op == "heal" ? $"+{Math.Max(1, view.MaxHp * prices.HealPercent / 100)} 生命" : Short(_selected, prices, act);
                bool usable = _selected.Op != "heal" || view.HealsLeft > 0;
                AddTarget(node, label, usable, () => Do(_selected!.Op, monster: index));
            }
            else if (_selected.Target == Target.Player)
            {
                var player = GameReflection.Get(entity, "Player");
                var id = player == null ? null : Test2MasterOffField.NetIdOf(player);
                if (id == null || players.All(p => p.NetId != id)) continue;
                ulong netId = id.Value;
                AddTarget(node, Short(_selected, prices, act), true, () => Do(_selected!.Op, player: netId));
            }
        }
        P.ApplyGameFont(_targets);
    }

    private void AddTarget(G.Control node, string label, bool usable, Action act)
    {
        // 头顶：取点击框和形象边框（Visuals.Bounds）里更高的那个上沿（0.0.24 实测只用点击框时，玩家的按钮落在胸前）
        var rects = new List<G.Rect2>();
        if (GameReflection.Get(node, "Hitbox") is G.Control hitbox) rects.Add(ScreenRect(hitbox));
        if (GameReflection.Get(node, "Visuals") is { } visuals && GameReflection.Get(visuals, "Bounds") is G.Control bounds) rects.Add(ScreenRect(bounds));
        if (rects.Count == 0) rects.Add(ScreenRect(node));
        float top = rects.Min(r => r.Position.Y);
        float centerX = rects[0].Position.X + rects[0].Size.X / 2;
        var button = P.MakeButton($"▼ {label}", usable ? new G.Color(0.30f, 0.12f, 0.14f) : P.Sunk, P.Danger, P.Gold, usable ? P.TextMain : P.TextDim, new G.Vector2(140, 40), 17);
        button.Disabled = !usable;
        button.Position = new G.Vector2(centerX - 70, Math.Max(80, top - 50));
        button.Pressed += act;
        _targets.AddChild(button);
    }

    /// <summary>控件在屏幕上的矩形（含所在画布的变换和缩放）。</summary>
    private static G.Rect2 ScreenRect(G.Control control)
    {
        var t = control.GetGlobalTransformWithCanvas();
        return new G.Rect2(t.Origin, control.Size * t.Scale);
    }

    /// <summary>战斗房间里所有可见的角色节点和它们对应的 Creature。</summary>
    private static IEnumerable<(G.Control Node, object Entity)> CreatureNodes()
    {
        var room = RuntimeNetAction.Required("NCombatRoom").GetProperty("Instance", GameReflection.All)?.GetValue(null);
        if (room == null || GameReflection.Get(room, "CreatureNodes") is not IEnumerable nodes) yield break;
        foreach (var node in nodes.Cast<object>())
            if (node is G.Control control && control.IsVisibleInTree() && GameReflection.Get(node, "Entity") is { } entity)
                yield return (control, entity);
    }

    // ---------------------------------------------------------------- 爬塔玩家的提示条

    private static G.CanvasLayer? _banner;

    /// <summary>爬塔玩家屏幕上方的「塔主行动中」提示。</summary>
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
        P.AddDeferred(_banner);
    }
}
