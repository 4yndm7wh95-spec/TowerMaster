using TowerMaster.Core;
using G = Godot;
using P = TowerMaster.SummonPanel;

namespace TowerMaster;

/// <summary>
/// 每幕一次的陷阱包选择（3 选 1），在本幕第一个召唤面板之前弹出。
/// 每个包一张卡：包名、一句风格、每张陷阱一行「名字 · 条件 → 效果」短写，完整说明在悬停提示里。整张卡就是按钮。
/// </summary>
internal sealed class TrapPackPanel(TrapPackChoice choice) : ISummonUi
{
    private G.CanvasLayer? _layer;

    public void Show()
    {
        _layer = new G.CanvasLayer { Layer = 100 };
        var backdrop = new G.ColorRect { Color = P.Backdrop, MouseFilter = G.Control.MouseFilterEnum.Stop };
        backdrop.SetAnchorsPreset(G.Control.LayoutPreset.FullRect);
        _layer.AddChild(backdrop);

        var center = new G.CenterContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore };
        center.SetAnchorsPreset(G.Control.LayoutPreset.FullRect);
        _layer.AddChild(center);

        var box = new G.VBoxContainer();
        box.AddThemeConstantOverride("separation", 22);
        center.AddChild(box);

        var title = new G.HBoxContainer { Alignment = G.BoxContainer.AlignmentMode.Center };
        title.AddThemeConstantOverride("separation", 12);
        if (Art.Icon("icon_trap", 44) is { } icon) title.AddChild(icon);
        title.AddChild(P.Text("选择陷阱包", 40, P.Gold));
        title.AddChild(P.Text($"第 {choice.ActNo} 幕", 22, P.TextDim));
        box.AddChild(title);

        var row = new G.HBoxContainer { Alignment = G.BoxContainer.AlignmentMode.Center };
        row.AddThemeConstantOverride("separation", 20);
        for (int i = 0; i < choice.Packs.Count; i++) row.AddChild(PackCard(choice.Packs[i], i));
        box.AddChild(row);

        var hint = P.Text("陷阱在召唤时盖下，条件满足自动触发；没触发的战后收回，玩家拿躲过金币", 16, P.TextDim);
        hint.HorizontalAlignment = G.HorizontalAlignment.Center;
        box.AddChild(hint);

        choice.Picked += _ => Close();
        P.ApplyGameFont(_layer);
        P.Tree.Root.CallDeferred(G.Node.MethodName.AddChild, _layer);
    }

    private G.Button PackCard(TrapPack pack, int index)
    {
        var card = new G.Button { FocusMode = G.Control.FocusModeEnum.None, CustomMinimumSize = new G.Vector2(340, 380) };
        P.StyleCard(card, selected: false);
        card.AddThemeStyleboxOverride("normal", P.Box(P.PanelBg, P.CardBorder, 1, 14, 0));
        card.AddThemeStyleboxOverride("hover", P.Box(P.CardHover, P.Gold, 2, 14, 0));
        card.TooltipText = string.Join("\n", pack.Cards.Select(c => $"{c.Name}：{c.Describe()}"));

        var col = new G.VBoxContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore };
        col.SetAnchorsPreset(G.Control.LayoutPreset.FullRect);
        col.OffsetLeft = 22;
        col.OffsetRight = -22;
        col.OffsetTop = 22;
        col.OffsetBottom = -22;
        col.AddThemeConstantOverride("separation", 10);
        if (Art.Icon($"pack_{index}", 72) is { } art) col.AddChild(art);
        var name = P.Text(pack.NameZh, 30, P.TextMain);
        name.HorizontalAlignment = G.HorizontalAlignment.Center;
        col.AddChild(name);
        var style = P.Text(pack.Style, 16, P.Gold);
        style.HorizontalAlignment = G.HorizontalAlignment.Center;
        col.AddChild(style);
        col.AddChild(P.Divider());
        foreach (var c in pack.Cards)
        {
            var line = new G.HBoxContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore };
            line.AddThemeConstantOverride("separation", 8);
            if (Art.Icon($"trap_{c.Id}", 26) is { } trap) line.AddChild(trap);
            var n = P.Text(c.Name, 18, P.TextMain);
            n.CustomMinimumSize = new G.Vector2(86, 0);
            n.MouseFilter = G.Control.MouseFilterEnum.Ignore;
            line.AddChild(n);
            var t = P.Text(c.Short, 15, P.TextDim);
            t.MouseFilter = G.Control.MouseFilterEnum.Ignore;
            line.AddChild(t);
            col.AddChild(line);
        }
        card.AddChild(col);
        card.Pressed += () => choice.Pick(index);
        return card;
    }

    public void Close()
    {
        _layer?.QueueFree();
        _layer = null;
    }
}
