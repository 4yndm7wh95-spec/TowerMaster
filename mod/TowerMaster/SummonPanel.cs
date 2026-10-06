using TowerMaster.Core;
using G = Godot;

namespace TowerMaster;

/// <summary>
/// 召唤面板（只在塔主这台电脑上显示）。全部用 Godot 自带控件拼，不定义自己的节点类：
/// mod 程序集里的自定义节点类不一定能被引擎登记，用自带控件 + C# 事件最稳。
/// 界面挂在场景树根上的一个高层 CanvasLayer 里，半透明遮罩挡住下面的点击。
/// 中文字体借用游戏里第一个 MegaLabel 的字体（Godot 默认字体没有中文）。
/// </summary>
internal sealed class SummonPanel : ISummonUi
{
    private const int FontSize = 22;
    private readonly SummonSession _session;
    private G.CanvasLayer? _layer;
    private G.Label _timer = null!, _quote = null!;
    private G.HFlowContainer _chosen = null!;
    private G.Button _confirm = null!;
    private readonly List<G.Button> _optionButtons = new();
    private ulong _lastTicks;

    public SummonPanel(SummonSession session) => _session = session;

    private static G.SceneTree Tree => (G.SceneTree)G.Engine.GetMainLoop();

    public void Show()
    {
        _layer = new G.CanvasLayer { Layer = 100 };

        var backdrop = new G.ColorRect { Color = new G.Color(0, 0, 0, 0.65f), MouseFilter = G.Control.MouseFilterEnum.Stop };
        backdrop.SetAnchorsPreset(G.Control.LayoutPreset.FullRect);
        _layer.AddChild(backdrop);

        var center = new G.CenterContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore };
        center.SetAnchorsPreset(G.Control.LayoutPreset.FullRect);
        _layer.AddChild(center);

        var panel = new G.PanelContainer { CustomMinimumSize = new G.Vector2(1100, 760) };
        center.AddChild(panel);
        var margin = new G.MarginContainer();
        foreach (var side in new[] { "margin_left", "margin_right", "margin_top", "margin_bottom" }) margin.AddThemeConstantOverride(side, 24);
        panel.AddChild(margin);
        var box = new G.VBoxContainer();
        box.AddThemeConstantOverride("separation", 14);
        margin.AddChild(box);

        var room = _session.Room;
        var roomName = room.Room switch { RoomKind.Elite => "精英房", RoomKind.Boss => "Boss 房", _ => "普通房" };
        box.AddChild(Text($"塔主 · 召唤阶段　{roomName}", 30));

        var header = new G.HBoxContainer();
        header.AddChild(Text($"召唤点 {room.Savings}　标准开销 {_session.Room.StandardCostOverride ?? 0}" +
                             (_session.IsOpeningProtected ? "　（开局保护：只能用简单遭遇的怪物，不超过标准开销）" : "")));
        header.AddChild(new G.Control { SizeFlagsHorizontal = G.Control.SizeFlags.ExpandFill });
        _timer = Text("");
        header.AddChild(_timer);
        box.AddChild(header);

        box.AddChild(Text(room.Room switch
        {
            RoomKind.Monster => "点击怪物加入本场；点击下方已选的怪物移除。",
            RoomKind.Elite => "选择一个精英遭遇。",
            _ => "选择一个 Boss（免费出场）。",
        }));

        var scroll = new G.ScrollContainer { SizeFlagsVertical = G.Control.SizeFlags.ExpandFill, CustomMinimumSize = new G.Vector2(0, 330) };
        var grid = new G.GridContainer { Columns = 4, SizeFlagsHorizontal = G.Control.SizeFlags.ExpandFill };
        grid.AddThemeConstantOverride("h_separation", 10);
        grid.AddThemeConstantOverride("v_separation", 10);
        scroll.AddChild(grid);
        box.AddChild(scroll);
        foreach (var option in _session.Options)
        {
            var button = MakeButton(room.Room == RoomKind.Boss ? option.Name : $"{option.Name}　{option.Price} 点");
            button.CustomMinimumSize = new G.Vector2(250, 56);
            var id = option.Id;
            button.Pressed += () => { _session.Click(id); Render(); };
            button.SetMeta("id", id);
            _optionButtons.Add(button);
            grid.AddChild(button);
        }

        if (room.Room == RoomKind.Monster)
        {
            box.AddChild(Text("已选："));
            _chosen = new G.HFlowContainer();
            box.AddChild(_chosen);
        }

        _quote = Text("");
        _quote.AutowrapMode = G.TextServer.AutowrapMode.WordSmart;
        box.AddChild(_quote);

        var buttons = new G.HBoxContainer { Alignment = G.BoxContainer.AlignmentMode.End };
        buttons.AddThemeConstantOverride("separation", 16);
        var vanilla = MakeButton("按原版出场");
        vanilla.Pressed += () => _session.UseVanilla();
        _confirm = MakeButton("确认召唤");
        _confirm.Pressed += () => _session.Confirm();
        buttons.AddChild(vanilla);
        buttons.AddChild(_confirm);
        box.AddChild(buttons);

        ApplyGameFont(_layer);
        _session.Finished += _ => Close();
        _lastTicks = G.Time.GetTicksMsec();
        Tree.ProcessFrame += OnFrame;
        Tree.Root.CallDeferred(G.Node.MethodName.AddChild, _layer);
        Render();
    }

    public void Close()
    {
        Tree.ProcessFrame -= OnFrame;
        _layer?.QueueFree();
        _layer = null;
    }

    private void OnFrame()
    {
        var now = G.Time.GetTicksMsec();
        _session.Tick((now - _lastTicks) / 1000.0);
        _lastTicks = now;
        if (!_session.Done) _timer.Text = $"剩余 {Math.Ceiling(_session.SecondsLeft)} 秒";
    }

    private void Render()
    {
        if (_session.Done) return;
        var room = _session.Room.Room;
        var quote = _session.Quote;

        foreach (var b in _optionButtons)
        {
            // 精英、Boss 房：高亮当前选中的那一个
            if (room != RoomKind.Monster) b.Modulate = (string)b.GetMeta("id") == _session.Encounter ? new G.Color(1, 0.9f, 0.5f) : G.Colors.White;
        }

        if (room == RoomKind.Monster)
        {
            foreach (var child in _chosen.GetChildren()) child.QueueFree();
            for (int i = 0; i < _session.Monsters.Count; i++)
            {
                int index = i;
                var b = MakeButton($"{_session.NameOf(_session.Monsters[i])} ✕");
                b.Pressed += () => { _session.RemoveAt(index); Render(); };
                ApplyGameFont(b);
                _chosen.AddChild(b);
            }
        }

        var lines = new List<string>();
        lines.Add(room == RoomKind.Boss
            ? "Boss 免费出场。"
            : $"召唤价 {quote.MonsterPrice} + 群体税 {quote.CrowdTax} = {quote.MonsterSpend}　（单场上限 {quote.SpendCap:0.#}）　确认后剩余 {_session.Room.Savings - quote.Total}");
        lines.AddRange(quote.Violations.Select(v => "✗ " + SummonSession.Describe(v)));
        _quote.Text = string.Join("\n", lines);
        _quote.AddThemeColorOverride("font_color", quote.Ok ? G.Colors.White : new G.Color(1, 0.55f, 0.5f));
        _confirm.Disabled = !quote.Ok;
    }

    // ---------------------------------------------------------------- 控件与字体

    private static G.Label Text(string text, int size = FontSize)
    {
        var label = new G.Label { Text = text };
        label.AddThemeFontSizeOverride("font_size", size);
        return label;
    }

    private static G.Button MakeButton(string text)
    {
        var button = new G.Button { Text = text, FocusMode = G.Control.FocusModeEnum.None };
        button.AddThemeFontSizeOverride("font_size", FontSize);
        return button;
    }

    private static G.Font? _gameFont;

    /// <summary>找游戏里的 MegaLabel 借字体；找不到就用默认字体（中文可能显示成方块，日志里会提示）。</summary>
    private static G.Font? GameFont()
    {
        if (_gameFont != null) return _gameFont;
        var stack = new Stack<G.Node>();
        stack.Push(Tree.Root);
        int visited = 0;
        while (stack.Count > 0 && visited++ < 20000)
        {
            var node = stack.Pop();
            if (node is G.Label label && node.GetType().Name == "MegaLabel")
            {
                _gameFont = label.GetThemeFont("font");
                if (_gameFont != null) return _gameFont;
            }
            foreach (var child in node.GetChildren()) stack.Push(child);
        }
        Log.Warn("召唤面板：没找到游戏字体，中文可能显示不出来");
        return null;
    }

    private static void ApplyGameFont(G.Node root)
    {
        var font = GameFont();
        if (font == null) return;
        var stack = new Stack<G.Node>();
        stack.Push(root);
        while (stack.Count > 0)
        {
            var node = stack.Pop();
            if (node is G.Control control) control.AddThemeFontOverride("font", font);
            foreach (var child in node.GetChildren()) stack.Push(child);
        }
    }

    // ---------------------------------------------------------------- 结算提示

    /// <summary>屏幕上方显示几秒的一行字（战斗收入等）。</summary>
    public static void ShowToast(string text, double seconds = 6)
    {
        var layer = new G.CanvasLayer { Layer = 101 };
        var label = Text(text, 26);
        label.HorizontalAlignment = G.HorizontalAlignment.Center;
        label.SetAnchorsPreset(G.Control.LayoutPreset.CenterTop);
        label.Position = new G.Vector2(-600, 90);
        label.Size = new G.Vector2(1200, 50);
        label.AddThemeColorOverride("font_outline_color", G.Colors.Black);
        label.AddThemeConstantOverride("outline_size", 8);
        layer.AddChild(label);
        ApplyGameFont(layer);
        Tree.Root.CallDeferred(G.Node.MethodName.AddChild, layer);
        Tree.CreateTimer(seconds).Timeout += () => layer.QueueFree();
    }
}
