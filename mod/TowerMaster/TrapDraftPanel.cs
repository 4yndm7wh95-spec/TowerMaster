using TowerMaster.Core;
using G = Godot;
using P = TowerMaster.SummonPanel;

namespace TowerMaster;

/// <summary>
/// 每幕开头自由挑陷阱：候选陷阱卡（原版卡框，左上角费用 = 预算花费）排成适配屏幕的多列网格，点卡选中/取消。
/// 版面固定三段：顶部标题和统计（预算、本幕张数、手牌），中间候选区（放不下时可以滚动），底部手里已有的陷阱和确认按钮。
/// 卡只在打开时做一次（原版卡场景比较重），选中/取消只改边框、标记和明暗，不重建卡。
/// </summary>
internal sealed class TrapDraftPanel(TrapDraftChoice choice) : ISummonUi
{
    private const float MaxCardScale = 0.72f;
    private const float MinCardScale = 0.5f;
    private const int Gap = 18;

    private sealed record Slot(G.Button Button, G.Control Badge, G.Label BadgeLabel);

    private G.CanvasLayer? _layer;
    private G.HBoxContainer _stats = null!, _hand = null!;
    private G.Button _confirm = null!;
    private readonly List<Slot> _slots = new();

    public void Show()
    {
        var d = choice.Draft;
        _layer = new G.CanvasLayer { Layer = 100 };
        var backdrop = new G.ColorRect { Color = new G.Color(P.Backdrop.R, P.Backdrop.G, P.Backdrop.B, 0.9f), MouseFilter = G.Control.MouseFilterEnum.Stop };
        backdrop.SetAnchorsPreset(G.Control.LayoutPreset.FullRect);
        _layer.AddChild(backdrop);

        var screen = P.Tree.Root.GetVisibleRect().Size;
        var margin = new G.MarginContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore };
        margin.SetAnchorsPreset(G.Control.LayoutPreset.FullRect);
        foreach (var (side, v) in new[] { ("margin_left", 48), ("margin_right", 48), ("margin_top", 28), ("margin_bottom", 24) })
            margin.AddThemeConstantOverride(side, v);
        _layer.AddChild(margin);
        var page = new G.VBoxContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore };
        page.AddThemeConstantOverride("separation", 14);
        margin.AddChild(page);

        // 顶部：标题 + 统计
        var title = new G.HBoxContainer { Alignment = G.BoxContainer.AlignmentMode.Center };
        title.AddThemeConstantOverride("separation", 12);
        if (Art.Icon("icon_trap", 40) is { } icon) title.AddChild(icon);
        title.AddChild(P.Text("挑选陷阱", 36, P.Gold));
        title.AddChild(P.Text($"第 {d.ActNo} 幕", 20, P.TextDim));
        page.AddChild(title);
        _stats = new G.HBoxContainer { Alignment = G.BoxContainer.AlignmentMode.Center };
        _stats.AddThemeConstantOverride("separation", 12);
        page.AddChild(_stats);
        var hint = P.Text("点卡牌选中或取消。左上角的数字是预算花费；鼠标停在卡上可以看完整规则。", 15, P.TextDim);
        hint.HorizontalAlignment = G.HorizontalAlignment.Center;
        page.AddChild(hint);

        // 中间：候选网格（放不下就滚动）
        float headerH = 150 + 56, footerH = 170;
        var (columns, scale) = Layout(d.Offer.Count, screen.X - 96, screen.Y - 52 - headerH - footerH);
        var scroll = new G.ScrollContainer
        {
            SizeFlagsVertical = G.Control.SizeFlags.ExpandFill,
            HorizontalScrollMode = G.ScrollContainer.ScrollMode.Disabled,
        };
        page.AddChild(scroll);
        var pad = new G.MarginContainer { SizeFlagsHorizontal = G.Control.SizeFlags.ExpandFill, SizeFlagsVertical = G.Control.SizeFlags.ExpandFill, MouseFilter = G.Control.MouseFilterEnum.Ignore };
        pad.AddThemeConstantOverride("margin_top", 44); // 悬停放大的卡会往上长，留出空间免得被滚动区裁掉
        pad.AddThemeConstantOverride("margin_bottom", 12);
        scroll.AddChild(pad);
        var center = new G.CenterContainer { SizeFlagsHorizontal = G.Control.SizeFlags.ExpandFill, SizeFlagsVertical = G.Control.SizeFlags.ExpandFill, MouseFilter = G.Control.MouseFilterEnum.Ignore };
        pad.AddChild(center);
        var grid = new G.GridContainer { Columns = columns };
        grid.AddThemeConstantOverride("h_separation", Gap);
        grid.AddThemeConstantOverride("v_separation", Gap);
        center.AddChild(grid);
        for (int i = 0; i < d.Offer.Count; i++)
        {
            var slot = OfferCard(i, scale);
            _slots.Add(slot);
            grid.AddChild(slot.Button);
        }

        // 底部：手里已有 + 确认
        var footer = new G.VBoxContainer { CustomMinimumSize = new G.Vector2(0, footerH - 20) };
        footer.AddThemeConstantOverride("separation", 10);
        _hand = new G.HBoxContainer { Alignment = G.BoxContainer.AlignmentMode.Center };
        _hand.AddThemeConstantOverride("separation", 6);
        footer.AddChild(_hand);
        var buttons = new G.HBoxContainer { Alignment = G.BoxContainer.AlignmentMode.Center };
        _confirm = P.MakeButton("", P.Teal, P.TealHover, P.Gold, P.TextMain, new G.Vector2(300, 56), 24);
        _confirm.Pressed += () => choice.Confirm();
        buttons.AddChild(_confirm);
        footer.AddChild(buttons);
        page.AddChild(footer);

        choice.Changed += Refresh;
        choice.Confirmed += _ => Close();
        BuildHand();
        Refresh();
        P.ApplyGameFont(_layer);
        P.Tree.Root.CallDeferred(G.Node.MethodName.AddChild, _layer);
    }

    public void Close()
    {
        choice.Changed -= Refresh;
        _slots.Clear();
        _layer?.QueueFree();
        _layer = null;
    }

    /// <summary>
    /// 列数和卡的缩放：尽量一行放下；放不下就分几行，每行张数尽量平均（7 张 → 4 + 3），卡在最小缩放以上尽量大。
    /// </summary>
    internal static (int Columns, float Scale) Layout(int count, float width, float height)
    {
        var size = VanillaCard.BaseSize;
        count = Math.Max(1, count);
        for (int rows = 1; rows <= count; rows++)
        {
            int columns = (int)Math.Ceiling(count / (double)rows);
            float byWidth = (width - Gap * (columns - 1)) / columns / (size.X + 12);
            float byHeight = (height - Gap * (rows - 1)) / rows / (size.Y + 12);
            float scale = Math.Min(MaxCardScale, Math.Min(byWidth, byHeight));
            if (scale >= MinCardScale) return (columns, scale);
        }
        // 屏幕太小：按最小缩放排，靠滚动
        int fit = Math.Max(1, (int)((width + Gap) / (size.X * MinCardScale + 12 + Gap)));
        return (Math.Min(fit, count), MinCardScale);
    }

    private void Refresh()
    {
        if (_layer == null) return;
        var d = choice.Draft;
        foreach (var child in _stats.GetChildren()) child.QueueFree();
        _stats.AddChild(Stat("预算", $"{d.Spent} / {d.Budget}", d.Spent > d.Budget));
        _stats.AddChild(Stat("本幕挑", $"{d.Picked.Count} / {d.MaxPicks}", false));
        _stats.AddChild(Stat("手牌", $"{d.Hand.Count + d.Picked.Count} / {d.HandLimit}", false));
        P.ApplyGameFont(_stats);

        for (int i = 0; i < _slots.Count; i++) Style(_slots[i], i);

        _confirm.Text = d.Picked.Count == 0 ? "这一幕不挑了" : $"就要这 {d.Picked.Count} 张";
        _confirm.Disabled = d.Problems.Count > 0;
    }

    private void BuildHand()
    {
        var d = choice.Draft;
        if (d.Hand.Count == 0) { _hand.AddChild(P.Text("手里还没有陷阱", 15, P.TextDim)); return; }
        _hand.AddChild(P.Text("手里已有", 15, P.TextDim));
        foreach (var c in d.Hand)
        {
            var mini = P.TrapMiniCard(c, 56);
            mini.MouseFilter = G.Control.MouseFilterEnum.Pass;
            mini.FocusMode = G.Control.FocusModeEnum.None;
            _hand.AddChild(mini);
        }
    }

    private static G.Control Stat(string label, string value, bool bad)
    {
        var box = new G.PanelContainer();
        box.AddThemeStyleboxOverride("panel", P.Box(P.Sunk, P.CardBorder, 1, 10, 0));
        var m = new G.MarginContainer();
        foreach (var (side, v) in new[] { ("margin_left", 14), ("margin_right", 14), ("margin_top", 4), ("margin_bottom", 4) })
            m.AddThemeConstantOverride(side, v);
        var row = new G.HBoxContainer();
        row.AddThemeConstantOverride("separation", 8);
        row.AddChild(P.Text(label, 16, P.TextDim));
        row.AddChild(P.Text(value, 22, bad ? P.Bad : P.Gold));
        m.AddChild(row);
        box.AddChild(m);
        return box;
    }

    /// <summary>候选卡：原版卡框（失败退回自绘卡），鼠标停留时放大；状态由 <see cref="Style"/> 设置。</summary>
    private Slot OfferCard(int index, float scale)
    {
        var card = choice.Draft.Offer[index];
        var size = VanillaCard.BaseSize * scale;
        var button = new G.Button
        {
            FocusMode = G.Control.FocusModeEnum.None,
            CustomMinimumSize = size + new G.Vector2(12, 12),
            TooltipText = $"{card.Name}（预算花费 {card.Def.DraftCost}）\n{card.Describe()}\n{card.Def.Rules(ModEntry.Active.DodgeRewardGold)}",
        };
        button.AddThemeStyleboxOverride("focus", new G.StyleBoxEmpty());
        var face = new CardFace(card.Name, card.Describe(VanillaCard.Kw), "陷阱", $"{card.Def.DraftCost}", $"trap_{card.Id}");
        var view = VanillaCard.Create(face, scale);
        if (view != null) VanillaCard.HoverZoom(button, view, 1.18f, 8);
        view ??= TrapPackCardView(card, scale);
        view.Position = new G.Vector2(6, 6);
        button.AddChild(view);

        var badgeLabel = P.Text("", 15, P.TextMain);
        var badge = new G.PanelContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore, Visible = false, ZIndex = 30 };
        badge.AddChild(badgeLabel);
        badge.Position = new G.Vector2(14, size.Y - 26);
        button.AddChild(badge);
        button.Pressed += () => choice.Toggle(index);
        return new Slot(button, badge, badgeLabel);
    }

    /// <summary>选中：金框、暖底、「已选」；手里已有：暗、「已有」；挑不了（超预算、张数满）：暗。</summary>
    private void Style(Slot slot, int index)
    {
        var d = choice.Draft;
        bool picked = d.Picked.Contains(index);
        bool owned = d.Owned(index);
        bool available = picked || d.CanAdd(index);
        var bg = picked ? new G.Color(0.24f, 0.19f, 0.10f, 0.6f) : new G.Color(0, 0, 0, 0);
        foreach (var state in new[] { "normal", "hover", "pressed", "disabled" })
        {
            var border = picked || state == "hover" ? P.Gold : P.CardBorder;
            int width = picked ? 3 : state == "hover" ? 2 : 0;
            slot.Button.AddThemeStyleboxOverride(state, P.Box(bg, border, width, 16, 0));
        }
        slot.Button.Modulate = owned || !available ? new G.Color(1, 1, 1, 0.45f) : G.Colors.White;
        slot.Badge.Visible = owned || picked;
        slot.BadgeLabel.Text = owned ? " 已有 " : " 已选 ";
        slot.BadgeLabel.AddThemeColorOverride("font_color", owned ? P.TextDim : new G.Color(0.1f, 0.08f, 0.04f));
        slot.Badge.AddThemeStyleboxOverride("panel", P.Box(owned ? P.Sunk : P.Gold, owned ? P.CardBorder : P.Gold, 1, 8, 2));
    }

    /// <summary>自绘陷阱卡（原版卡框不可用时）：名字、费用、图、完整说明。</summary>
    internal static G.Control TrapPackCardView(TrapCard card, float scale)
    {
        var size = VanillaCard.BaseSize * scale;
        var panel = new G.PanelContainer { CustomMinimumSize = size, MouseFilter = G.Control.MouseFilterEnum.Ignore };
        panel.AddThemeStyleboxOverride("panel", P.Box(new G.Color(0.10f, 0.11f, 0.16f), P.Gold, 2, 14, 12, shadow: 8));
        var col = new G.VBoxContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore };
        col.AddThemeConstantOverride("separation", 6);
        var head = new G.HBoxContainer();
        var name = P.Text(card.Name, 20, P.TextMain);
        name.SizeFlagsHorizontal = G.Control.SizeFlags.ExpandFill;
        head.AddChild(name);
        head.AddChild(P.Badge($"{card.Def.DraftCost}", new G.Color(0.20f, 0.17f, 0.09f), P.Gold));
        col.AddChild(head);
        var art = new G.CenterContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore, CustomMinimumSize = new G.Vector2(0, size.Y * 0.4f) };
        if (Art.Icon($"trap_{card.Id}", size.Y * 0.36f) is { } image) art.AddChild(image);
        col.AddChild(art);
        var text = P.Text(card.Describe(), 15, P.TextMain);
        text.HorizontalAlignment = G.HorizontalAlignment.Center;
        text.AutowrapMode = G.TextServer.AutowrapMode.WordSmart;
        text.CustomMinimumSize = new G.Vector2(size.X - 24, 0);
        col.AddChild(text);
        panel.AddChild(col);
        return panel;
    }
}
