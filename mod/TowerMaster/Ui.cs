using P = TowerMaster.SummonPanel;
using G = Godot;

namespace TowerMaster;

/// <summary>
/// 文字层级和悬停说明（0.0.48，用户反馈「本场、没盖字体一样颜色一样字号一样，没有区别」「注释要像注释」「提示框文字发糊」）。
///
/// 五种文字，各有用途，界面上只用这几种：
/// | 用途 | 样子 |
/// | Title 标题 | 大号、金色、带描边 |
/// | Label 标签（这是什么） | 小号、偏暖的灰、不抢眼 |
/// | Value 数值/状态（是多少、怎么样） | 中大号、亮白或金色，明显比标签重 |
/// | Body 正文 | 常规、浅色 |
/// | Note 注释（补充说明、规则细节） | 小号、偏冷的灰蓝，左边一道细竖线，一看就是「旁注」 |
///
/// 悬停说明不用 Godot 自带的 TooltipText：自带提示框在游戏的缩放下发糊、也用不上游戏字体。
/// 改为自己画一块小牌子（游戏字体、主界面里按实际像素画），标题 + 正文 + 注释三层。
/// 文本约定：第一行是标题；以「※」开头的行是注释；其余是正文。
/// </summary>
internal static class Ui
{
    internal static readonly G.Color LabelColor = new(0.66f, 0.62f, 0.54f);
    internal static readonly G.Color NoteColor = new(0.58f, 0.66f, 0.76f);
    internal static readonly G.Color NoteBar = new(0.36f, 0.48f, 0.62f);

    internal static G.Label Title(string text, int size = 30) => Styled(text, size, P.Gold, outline: 6);
    internal static G.Label Label(string text, int size = 14) => Styled(text, size, LabelColor, outline: 3);
    internal static G.Label Value(string text, int size = 22, G.Color? color = null) => Styled(text, size, color ?? P.TextMain, outline: 5);
    internal static G.Label Body(string text, int size = 17) => Styled(text, size, P.TextMain, outline: 3);

    /// <summary>注释：左边一道细竖线 + 小号冷灰字。</summary>
    internal static G.Control Note(string text, int size = 14, float width = 0)
    {
        var row = new G.HBoxContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore };
        row.AddThemeConstantOverride("separation", 8);
        row.AddChild(new G.ColorRect { Color = NoteBar, CustomMinimumSize = new G.Vector2(2, 0), MouseFilter = G.Control.MouseFilterEnum.Ignore });
        var label = Styled(text, size, NoteColor, outline: 2);
        label.SizeFlagsHorizontal = G.Control.SizeFlags.ExpandFill;
        if (width > 0)
        {
            label.AutowrapMode = G.TextServer.AutowrapMode.WordSmart;
            label.CustomMinimumSize = new G.Vector2(width, 0);
        }
        row.AddChild(label);
        return row;
    }

    private static G.Label Styled(string text, int size, G.Color color, int outline)
    {
        var label = P.Text(text, size, color);
        label.MouseFilter = G.Control.MouseFilterEnum.Ignore;
        label.AddThemeConstantOverride("outline_size", outline);
        label.AddThemeColorOverride("font_outline_color", new G.Color(0, 0, 0, 0.85f));
        return label;
    }

    // ---------------------------------------------------------------- 悬停说明

    private static readonly System.Runtime.CompilerServices.ConditionalWeakTable<G.Control, string[]> Tips = new();
    private static G.CanvasLayer? _layer;
    private static G.PanelContainer? _panel;
    private static G.Control? _owner;
    private static int _showToken;

    /// <summary>给控件挂悬停说明（第一行标题，「※」开头是注释）。重复调用只换文字。空文本 = 不显示。</summary>
    internal static void Tip(G.Control control, string text)
    {
        control.TooltipText = "";
        bool attached = Tips.TryGetValue(control, out _);
        Tips.AddOrUpdate(control, [text]);
        if (_owner == control && _panel != null && G.GodotObject.IsInstanceValid(_panel)) Show(control); // 正在显示就刷新
        if (attached) return;
        if (control.MouseFilter == G.Control.MouseFilterEnum.Ignore) control.MouseFilter = G.Control.MouseFilterEnum.Pass;
        control.MouseEntered += () =>
        {
            int token = ++_showToken;
            P.Tree.CreateTimer(0.3).Timeout += () => { if (token == _showToken && G.GodotObject.IsInstanceValid(control) && control.IsVisibleInTree()) Show(control); };
        };
        control.MouseExited += () => { _showToken++; if (_owner == control) Hide(); };
        control.TreeExiting += () => { if (_owner == control) Hide(); };
    }

    private static void Show(G.Control control)
    {
        if (!Tips.TryGetValue(control, out var holder) || holder[0].Length == 0) return;
        Hide();
        _owner = control;
        _layer = new G.CanvasLayer { Layer = 128 };
        var panel = new G.PanelContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore };
        var sb = P.Box(new G.Color(0.05f, 0.06f, 0.09f, 0.96f), new G.Color(0.55f, 0.45f, 0.26f, 0.8f), 1, 10, 0, shadow: 8);
        sb.ContentMarginLeft = sb.ContentMarginRight = 14; sb.ContentMarginTop = 10; sb.ContentMarginBottom = 12;
        panel.AddThemeStyleboxOverride("panel", sb);
        var col = new G.VBoxContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore };
        col.AddThemeConstantOverride("separation", 6);
        var lines = holder[0].Split('\n', StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < lines.Length; i++)
        {
            var line = lines[i].Trim();
            if (i == 0) col.AddChild(Value(line, 19, P.Gold));
            else if (line.StartsWith('※')) { if (line.Length > 1) col.AddChild(Note(line[1..].Trim(), 14, 320)); }
            else
            {
                var body = Body(line, 16);
                body.AutowrapMode = G.TextServer.AutowrapMode.WordSmart;
                body.CustomMinimumSize = new G.Vector2(330, 0);
                col.AddChild(body);
            }
        }
        panel.AddChild(col);
        _layer.AddChild(panel);
        _panel = panel;
        P.ApplyGameFont(_layer);
        P.Tree.Root.AddChild(_layer);
        panel.ResetSize();
        // 鼠标右下方；靠右/靠下放不下就翻到另一边
        var screen = P.Tree.Root.GetVisibleRect().Size;
        var mouse = P.Tree.Root.GetMousePosition();
        var size = panel.GetCombinedMinimumSize();
        var pos = mouse + new G.Vector2(18, 22);
        if (pos.X + size.X > screen.X - 8) pos.X = mouse.X - size.X - 12;
        if (pos.Y + size.Y > screen.Y - 8) pos.Y = mouse.Y - size.Y - 12;
        panel.Position = new G.Vector2(Math.Max(8, pos.X), Math.Max(8, pos.Y));
    }

    internal static void Hide()
    {
        _owner = null;
        if (_layer != null && G.GodotObject.IsInstanceValid(_layer)) _layer.QueueFree();
        _layer = null;
        _panel = null;
    }
}
