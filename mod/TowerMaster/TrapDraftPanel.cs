using TowerMaster.Core;
using G = Godot;
using P = TowerMaster.SummonPanel;

namespace TowerMaster;

/// <summary>
/// 每幕开头自由挑陷阱（替代 0.0.24 的固定陷阱包）：一排候选陷阱卡（原版卡框，右上角数字是预算花费），
/// 点卡选中/取消；上方显示预算、张数、手牌上限；手里已有的同种卡标「已有」不能再挑。下方是手里现有的陷阱。
/// </summary>
internal sealed class TrapDraftPanel(TrapDraftChoice choice) : ISummonUi
{
    private G.CanvasLayer? _layer;
    private G.VBoxContainer _content = null!;
    private const float CardScale = 0.62f;

    public void Show()
    {
        _layer = new G.CanvasLayer { Layer = 100 };
        var backdrop = new G.ColorRect { Color = new G.Color(P.Backdrop.R, P.Backdrop.G, P.Backdrop.B, 0.88f), MouseFilter = G.Control.MouseFilterEnum.Stop };
        backdrop.SetAnchorsPreset(G.Control.LayoutPreset.FullRect);
        _layer.AddChild(backdrop);
        var center = new G.CenterContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore };
        center.SetAnchorsPreset(G.Control.LayoutPreset.FullRect);
        _layer.AddChild(center);
        _content = new G.VBoxContainer();
        _content.AddThemeConstantOverride("separation", 20);
        center.AddChild(_content);

        choice.Changed += Rebuild;
        choice.Confirmed += _ => Close();
        Rebuild();
        P.Tree.Root.CallDeferred(G.Node.MethodName.AddChild, _layer);
    }

    public void Close()
    {
        choice.Changed -= Rebuild;
        _layer?.QueueFree();
        _layer = null;
    }

    private void Rebuild()
    {
        if (_layer == null) return;
        foreach (var child in _content.GetChildren()) child.QueueFree();
        var d = choice.Draft;

        var title = new G.HBoxContainer { Alignment = G.BoxContainer.AlignmentMode.Center };
        title.AddThemeConstantOverride("separation", 12);
        if (Art.Icon("icon_trap", 44) is { } icon) title.AddChild(icon);
        title.AddChild(P.Text("挑选陷阱", 40, P.Gold));
        title.AddChild(P.Text($"第 {d.ActNo} 幕", 20, P.TextDim));
        _content.AddChild(title);

        var stats = new G.HBoxContainer { Alignment = G.BoxContainer.AlignmentMode.Center };
        stats.AddThemeConstantOverride("separation", 12);
        stats.AddChild(Stat("预算", $"{d.Spent} / {d.Budget}", d.Spent > d.Budget));
        stats.AddChild(Stat("本幕挑", $"{d.Picked.Count} / {d.MaxPicks}", false));
        stats.AddChild(Stat("手牌", $"{d.Hand.Count + d.Picked.Count} / {d.HandLimit}", false));
        _content.AddChild(stats);

        var row = new G.HFlowContainer { Alignment = G.FlowContainer.AlignmentMode.Center };
        row.AddThemeConstantOverride("h_separation", 14);
        row.AddThemeConstantOverride("v_separation", 14);
        for (int i = 0; i < d.Offer.Count; i++) row.AddChild(OfferCard(i));
        _content.AddChild(row);

        if (d.Hand.Count > 0)
        {
            var hand = new G.HBoxContainer { Alignment = G.BoxContainer.AlignmentMode.Center };
            hand.AddThemeConstantOverride("separation", 6);
            hand.AddChild(P.Text("手里已有", 15, P.TextDim));
            foreach (var c in d.Hand)
            {
                var mini = P.TrapMiniCard(c, 56);
                mini.MouseFilter = G.Control.MouseFilterEnum.Pass;
                mini.FocusMode = G.Control.FocusModeEnum.None;
                hand.AddChild(mini);
            }
            _content.AddChild(hand);
        }

        var buttons = new G.HBoxContainer { Alignment = G.BoxContainer.AlignmentMode.Center };
        var confirm = P.MakeButton(d.Picked.Count == 0 ? "这一幕不挑了" : $"就要这 {d.Picked.Count} 张", P.Teal, P.TealHover, P.Gold, P.TextMain, new G.Vector2(280, 56), 24);
        confirm.Disabled = d.Problems.Count > 0;
        confirm.Pressed += () => choice.Confirm();
        buttons.AddChild(confirm);
        _content.AddChild(buttons);
        P.ApplyGameFont(_layer);
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

    /// <summary>候选卡：原版卡框（失败退回自绘卡）；选中金框上抬，已有/买不起变暗。</summary>
    private G.Button OfferCard(int index)
    {
        var d = choice.Draft;
        var card = d.Offer[index];
        bool picked = d.Picked.Contains(index);
        bool owned = d.Owned(index);
        bool available = picked || d.CanAdd(index);
        var size = VanillaCard.BaseSize * CardScale;
        var button = new G.Button
        {
            FocusMode = G.Control.FocusModeEnum.None,
            CustomMinimumSize = size + new G.Vector2(12, 12),
            TooltipText = $"{card.Name}：{card.Describe()}\n预算花费 {card.Def.DraftCost}" + (owned ? "\n手里已有同种，不能重复" : ""),
        };
        var border = picked ? P.Gold : P.CardBorder;
        foreach (var state in new[] { "normal", "hover", "pressed", "disabled" })
            button.AddThemeStyleboxOverride(state, P.Box(picked ? new G.Color(0.24f, 0.19f, 0.10f, 0.6f) : new G.Color(0, 0, 0, 0), state == "hover" ? P.Gold : border, picked ? 3 : state == "hover" ? 2 : 0, 16, 0));
        button.AddThemeStyleboxOverride("focus", new G.StyleBoxEmpty());

        var face = new CardFace(card.Name, $"{card.Def.ShortWhen}\n→ {card.Def.ShortWhat(card.Tier)}", "陷阱", $"{card.Def.DraftCost}", $"trap_{card.Id}");
        var view = VanillaCard.Create(face, CardScale) ?? TrapDraftFallback(card);
        view.Position = new G.Vector2(6, 6);
        button.AddChild(view);
        if (owned || !available) button.Modulate = new G.Color(1, 1, 1, 0.4f);
        if (owned || picked)
        {
            var tag = P.Badge(owned ? "已有" : "已选", owned ? P.Sunk : P.Gold, owned ? P.TextDim : new G.Color(0.1f, 0.08f, 0.04f));
            tag.Position = new G.Vector2(10, size.Y - 20);
            button.AddChild(tag);
        }
        button.Pressed += () => choice.Toggle(index);
        return button;
    }

    private static G.Control TrapDraftFallback(TrapCard card)
    {
        var view = TrapPackCardView(card);
        view.MouseFilter = G.Control.MouseFilterEnum.Ignore;
        return view;
    }

    /// <summary>自绘陷阱卡（原版卡框不可用时）：图、名字、条件 ↓ 效果，右上角预算花费。</summary>
    internal static G.Control TrapPackCardView(TrapCard card)
    {
        var size = VanillaCard.BaseSize * CardScale;
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
        var art = new G.CenterContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore, CustomMinimumSize = new G.Vector2(0, size.Y * 0.42f) };
        if (Art.Icon($"trap_{card.Id}", size.Y * 0.38f) is { } image) art.AddChild(image);
        col.AddChild(art);
        foreach (var (text, color, fs) in new[] { (card.Def.ShortWhen, P.TextDim, 15), ("↓", P.GoldDim, 13), (card.Def.ShortWhat(card.Tier), P.Gold, 18) })
        {
            var l = P.Text(text, fs, color);
            l.HorizontalAlignment = G.HorizontalAlignment.Center;
            col.AddChild(l);
        }
        panel.AddChild(col);
        return panel;
    }
}
