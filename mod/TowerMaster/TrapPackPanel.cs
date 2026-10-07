using TowerMaster.Core;
using G = Godot;
using P = TowerMaster.SummonPanel;

namespace TowerMaster;

/// <summary>每幕一次的陷阱包选择（3 选 1），在本幕第一个召唤面板之前弹出。样式沿用召唤面板。</summary>
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
        var screen = P.Tree.Root.GetVisibleRect().Size;
        var panel = new G.PanelContainer { CustomMinimumSize = new G.Vector2(Math.Min(1300, screen.X - 60), 0) };
        panel.AddThemeStyleboxOverride("panel", P.Box(P.PanelBg, P.Gold, 3, 14, 26, shadow: 24));
        center.AddChild(panel);

        var box = new G.VBoxContainer();
        box.AddThemeConstantOverride("separation", 14);
        panel.AddChild(box);
        box.AddChild(P.Text($"第 {choice.ActNo} 幕 · 选一个陷阱包", 38, P.Gold));
        box.AddChild(P.Text("陷阱在召唤时盖下（每张 1 召唤点，每场最多 2 张），条件满足自动触发；没触发的战后翻开收回，玩家每人得躲过金币。", 19, P.TextDim));
        box.AddChild(P.Divider());

        var row = new G.HBoxContainer();
        row.AddThemeConstantOverride("separation", 16);
        for (int i = 0; i < choice.Packs.Count; i++)
        {
            var pack = choice.Packs[i];
            var card = new G.PanelContainer { SizeFlagsHorizontal = G.Control.SizeFlags.ExpandFill };
            card.AddThemeStyleboxOverride("panel", P.Box(P.CardBg, P.CardBorder, 1, 12, 16));
            var col = new G.VBoxContainer();
            col.AddThemeConstantOverride("separation", 8);
            col.AddChild(P.Text(pack.NameZh, 28, P.TextMain));
            col.AddChild(P.Text(pack.Style, 18, P.Gold));
            foreach (var c in pack.Cards)
            {
                var line = P.Text($"· {c.Name}：{c.Describe()}", 17, P.TextMain);
                line.AutowrapMode = G.TextServer.AutowrapMode.WordSmart;
                line.CustomMinimumSize = new G.Vector2(300, 0);
                col.AddChild(line);
            }
            col.AddChild(P.Spacer());
            int index = i;
            var pick = P.MakeButton("选这个", P.Teal, P.TealHover, P.Gold, P.TextMain, new G.Vector2(0, 52), 22);
            pick.Pressed += () => choice.Pick(index);
            col.AddChild(pick);
            card.AddChild(col);
            row.AddChild(card);
        }
        box.AddChild(row);

        choice.Picked += _ => Close();
        P.ApplyGameFont(_layer);
        P.Tree.Root.CallDeferred(G.Node.MethodName.AddChild, _layer);
    }

    public void Close()
    {
        _layer?.QueueFree();
        _layer = null;
    }
}
