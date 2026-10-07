using TowerMaster.Core;
using G = Godot;
using P = TowerMaster.SummonPanel;

namespace TowerMaster;

/// <summary>
/// 每幕一次的陷阱包选择，做成「卡牌包」：先看到三个合着的包（包图、名字、一句风格），
/// 点开一个包，展开成一排陷阱卡（图、名字、条件 → 效果），再决定「选这个包」或「换一个看看」。
/// </summary>
internal sealed class TrapPackPanel(TrapPackChoice choice) : ISummonUi
{
    private G.CanvasLayer? _layer;
    private G.VBoxContainer _content = null!;
    private int _open = -1;

    public void Show()
    {
        _layer = new G.CanvasLayer { Layer = 100 };
        var backdrop = new G.ColorRect { Color = new G.Color(P.Backdrop.R, P.Backdrop.G, P.Backdrop.B, 0.85f), MouseFilter = G.Control.MouseFilterEnum.Stop };
        backdrop.SetAnchorsPreset(G.Control.LayoutPreset.FullRect);
        _layer.AddChild(backdrop);

        var center = new G.CenterContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore };
        center.SetAnchorsPreset(G.Control.LayoutPreset.FullRect);
        _layer.AddChild(center);
        _content = new G.VBoxContainer { Alignment = G.BoxContainer.AlignmentMode.Center };
        _content.AddThemeConstantOverride("separation", 26);
        center.AddChild(_content);

        choice.Picked += _ => Close();
        Rebuild();
        P.Tree.Root.CallDeferred(G.Node.MethodName.AddChild, _layer);
    }

    public void Close()
    {
        _layer?.QueueFree();
        _layer = null;
    }

    private void Rebuild()
    {
        if (_layer == null) return;
        foreach (var child in _content.GetChildren()) child.QueueFree();
        if (_open < 0) BuildClosed();
        else BuildOpen(choice.Packs[_open]);
        P.ApplyGameFont(_layer);
    }

    private G.Control Title(string text, string sub)
    {
        var title = new G.HBoxContainer { Alignment = G.BoxContainer.AlignmentMode.Center };
        title.AddThemeConstantOverride("separation", 12);
        if (Art.Icon("icon_trap", 44) is { } icon) title.AddChild(icon);
        title.AddChild(P.Text(text, 40, P.Gold));
        title.AddChild(P.Text(sub, 20, P.TextDim));
        return title;
    }

    // ---------------------------------------------------------------- 三个合着的包

    private void BuildClosed()
    {
        _content.AddChild(Title("选择陷阱包", $"第 {choice.ActNo} 幕 · 点开看看"));
        var row = new G.HBoxContainer { Alignment = G.BoxContainer.AlignmentMode.Center };
        row.AddThemeConstantOverride("separation", 28);
        for (int i = 0; i < choice.Packs.Count; i++) row.AddChild(PackCover(choice.Packs[i], i));
        _content.AddChild(row);
    }

    private G.Button PackCover(TrapPack pack, int index)
    {
        var card = new G.Button { FocusMode = G.Control.FocusModeEnum.None, CustomMinimumSize = new G.Vector2(270, 360), TooltipText = "点开看看这包里的陷阱" };
        card.AddThemeStyleboxOverride("normal", P.Box(P.PanelBg, P.GoldDim, 2, 18, 0, shadow: 14));
        card.AddThemeStyleboxOverride("hover", P.Box(P.CardHover, P.Gold, 3, 18, 0, shadow: 18));
        card.AddThemeStyleboxOverride("pressed", P.Box(P.CardHover, P.Gold, 3, 18, 0));
        card.AddThemeStyleboxOverride("focus", new G.StyleBoxEmpty());

        var col = new G.VBoxContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore, Alignment = G.BoxContainer.AlignmentMode.Center };
        col.SetAnchorsPreset(G.Control.LayoutPreset.FullRect);
        col.AddThemeConstantOverride("separation", 10);
        var art = new G.CenterContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore, CustomMinimumSize = new G.Vector2(0, 190) };
        if (Art.Icon($"pack_{index}", 180) is { } image) art.AddChild(image);
        else art.AddChild(P.Text("？", 90, P.GoldDim));
        col.AddChild(art);
        col.AddChild(Centered(P.Text(pack.NameZh, 30, P.TextMain)));
        col.AddChild(Centered(P.Text(pack.Style, 16, P.Gold)));
        col.AddChild(Centered(P.Text($"{pack.Cards.Count} 张陷阱", 14, P.TextDim)));
        card.AddChild(col);
        card.Pressed += () => { _open = index; Rebuild(); };
        return card;
    }

    // ---------------------------------------------------------------- 展开的一包

    private void BuildOpen(TrapPack pack)
    {
        _content.AddChild(Title(pack.NameZh, pack.Style));
        var row = new G.HBoxContainer { Alignment = G.BoxContainer.AlignmentMode.Center };
        row.AddThemeConstantOverride("separation", 18);
        foreach (var card in pack.Cards) row.AddChild(TrapCardView(card));
        _content.AddChild(row);

        var buttons = new G.HBoxContainer { Alignment = G.BoxContainer.AlignmentMode.Center };
        buttons.AddThemeConstantOverride("separation", 16);
        var back = P.MakeButton("换一个看看", P.Sunk, P.CardHover, P.CardBorder, P.TextDim, new G.Vector2(200, 54), 20);
        back.Pressed += () => { _open = -1; Rebuild(); };
        buttons.AddChild(back);
        var pick = P.MakeButton("就选这包", P.Teal, P.TealHover, P.Gold, P.TextMain, new G.Vector2(260, 54), 24);
        int index = _open;
        pick.Pressed += () => choice.Pick(index);
        buttons.AddChild(pick);
        _content.AddChild(buttons);
    }

    /// <summary>一张陷阱卡：深色卡面、金边，上面图，下面名字、触发条件、效果。</summary>
    internal static G.Control TrapCardView(TrapCard card)
    {
        var panel = new G.PanelContainer { CustomMinimumSize = new G.Vector2(190, 270), TooltipText = card.Describe(), MouseFilter = G.Control.MouseFilterEnum.Pass };
        panel.AddThemeStyleboxOverride("panel", P.Box(new G.Color(0.10f, 0.11f, 0.16f), P.Gold, 2, 14, 14, shadow: 10));
        var col = new G.VBoxContainer { Alignment = G.BoxContainer.AlignmentMode.Begin, MouseFilter = G.Control.MouseFilterEnum.Ignore };
        col.AddThemeConstantOverride("separation", 8);
        col.AddChild(Centered(P.Text(card.Name, 22, P.TextMain)));
        var art = new G.CenterContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore, CustomMinimumSize = new G.Vector2(0, 110) };
        if (Art.Icon($"trap_{card.Id}", 104) is { } image) art.AddChild(image);
        else art.AddChild(P.Text(card.Def.NameZh[..1], 60, P.GoldDim));
        col.AddChild(art);
        col.AddChild(P.Divider());
        col.AddChild(Centered(P.Text(card.Def.ShortWhen, 16, P.TextDim)));
        col.AddChild(Centered(P.Text("↓", 14, P.GoldDim)));
        col.AddChild(Centered(P.Text(card.Def.ShortWhat(card.Tier), 19, P.Gold)));
        panel.AddChild(col);
        return panel;
    }

    private static G.Label Centered(G.Label label)
    {
        label.HorizontalAlignment = G.HorizontalAlignment.Center;
        label.MouseFilter = G.Control.MouseFilterEnum.Ignore;
        return label;
    }
}
