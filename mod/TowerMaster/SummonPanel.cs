using TowerMaster.Core;
using G = Godot;

namespace TowerMaster;

/// <summary>
/// 召唤面板（只在塔主这台电脑上显示）。全部用 Godot 自带控件 + StyleBoxFlat 样式拼，不定义自己的节点类：
/// mod 程序集里的自定义节点类不一定能被引擎登记，用自带控件 + C# 事件最稳。
/// 界面挂在场景树根上的一个高层 CanvasLayer 里，半透明遮罩挡住下面的点击。
/// 中文字体借用游戏里第一个 MegaLabel 的字体（Godot 默认字体没有中文）。
/// 配色向游戏靠：深蓝底、金色描边、青绿按钮。说明文字尽量收进悬停提示，界面上只留名字和数字（用户反馈太拥挤）。
/// 可选美术资源见 <see cref="Art"/>。
/// </summary>
internal sealed class SummonPanel : ISummonUi
{
    // ---------------------------------------------------------------- 配色
    internal static readonly G.Color Backdrop = new(0.02f, 0.03f, 0.06f, 0.72f);
    internal static readonly G.Color PanelBg = new(0.075f, 0.09f, 0.13f, 0.97f);
    internal static readonly G.Color Gold = new(0.86f, 0.70f, 0.38f);
    internal static readonly G.Color GoldDim = new(0.55f, 0.45f, 0.26f);
    internal static readonly G.Color CardBg = new(0.13f, 0.16f, 0.22f);
    internal static readonly G.Color CardHover = new(0.18f, 0.22f, 0.30f);
    internal static readonly G.Color CardBorder = new(0.27f, 0.33f, 0.45f);
    internal static readonly G.Color Teal = new(0.16f, 0.42f, 0.44f);
    internal static readonly G.Color TealHover = new(0.21f, 0.52f, 0.54f);
    internal static readonly G.Color TextMain = new(0.93f, 0.91f, 0.86f);
    internal static readonly G.Color TextDim = new(0.62f, 0.64f, 0.70f);
    internal static readonly G.Color Good = new(0.45f, 0.82f, 0.52f);
    internal static readonly G.Color Bad = new(0.95f, 0.45f, 0.40f);
    internal static readonly G.Color Danger = new(0.78f, 0.28f, 0.30f);
    internal static readonly G.Color Elite = new(0.85f, 0.45f, 0.30f);
    internal static readonly G.Color Sunk = new(0.05f, 0.06f, 0.09f);

    private const float SidebarWidth = 340;
    private static readonly G.Vector2 MonsterPortrait = new(150, 104);
    private static readonly G.Vector2 BossPortrait = new(300, 150);

    private readonly SummonSession _session;
    private G.CanvasLayer? _layer;
    private G.Label? _timer;
    private G.VBoxContainer _lineup = null!, _problems = null!;
    private G.Label _emptyHint = null!, _cost = null!, _left = null!, _total = null!, _breakdown = null!;
    private G.ProgressBar _capBar = null!;
    private G.Button _confirm = null!;
    private readonly Dictionary<string, (G.Button Card, G.PanelContainer Count, G.Label CountText)> _cards = new();
    private readonly List<(G.Button Button, int Index)> _trapButtons = new();
    private ulong _lastTicks;

    public SummonPanel(SummonSession session) => _session = session;

    internal static G.SceneTree Tree => (G.SceneTree)G.Engine.GetMainLoop();

    /// <summary>
    /// 下一帧把界面层加到场景根上；如果在那之前界面已经关了（释放了），就不加。
    /// 0.0.27 实测：同一帧里开了又关的面板，延迟加入时报 Godot「Parameter "p_child" is null」。
    /// </summary>
    internal static void AddDeferred(G.Node node) =>
        G.Callable.From(() =>
        {
            if (G.GodotObject.IsInstanceValid(node) && !node.IsQueuedForDeletion() && node.GetParent() == null) Tree.Root.AddChild(node);
        }).CallDeferred();

    /// <summary>
    /// 布局：顶栏（标题、房间、召唤点）；左边是可滚动的选择区（Boss 候选 + 怪物网格）；
    /// 右边固定侧栏：本场阵容、陷阱、花费、确认按钮。说明文字都收进悬停提示，界面上只留名字和数字。
    /// </summary>
    public void Show()
    {
        // 同一个面板关了再开（0.0.41 测试接口压力调用）：先把上一次的界面和按钮登记清掉，不然改样式时碰到已释放的按钮
        Close();
        _cards.Clear();
        _trapButtons.Clear();
        _filterButtons.Clear();
        _layer = new G.CanvasLayer { Layer = 100 };
        var backdrop = new G.ColorRect { Color = Backdrop, MouseFilter = G.Control.MouseFilterEnum.Stop };
        backdrop.SetAnchorsPreset(G.Control.LayoutPreset.FullRect);
        _layer.AddChild(backdrop);

        var screen = Tree.Root.GetVisibleRect().Size;
        float width = Math.Min(1480, screen.X - 48);
        var panel = new G.PanelContainer();
        panel.AddThemeStyleboxOverride("panel", Box(PanelBg, Gold, 2, 16, 20, shadow: 24));
        panel.SetAnchorsPreset(G.Control.LayoutPreset.FullRect);
        panel.OffsetLeft = (screen.X - width) / 2;
        panel.OffsetRight = -(screen.X - width) / 2;
        panel.OffsetTop = 28;
        panel.OffsetBottom = -28;
        _layer.AddChild(panel);

        var root = new G.VBoxContainer();
        root.AddThemeConstantOverride("separation", 14);
        panel.AddChild(root);
        root.AddChild(TopBar());
        root.AddChild(Divider());

        var body = new G.HBoxContainer { SizeFlagsVertical = G.Control.SizeFlags.ExpandFill };
        body.AddThemeConstantOverride("separation", 18);
        root.AddChild(body);

        var scroll = new G.ScrollContainer
        {
            HorizontalScrollMode = G.ScrollContainer.ScrollMode.Disabled,
            SizeFlagsHorizontal = G.Control.SizeFlags.ExpandFill,
        };
        var options = new G.VBoxContainer { SizeFlagsHorizontal = G.Control.SizeFlags.ExpandFill };
        options.AddThemeConstantOverride("separation", 14);
        scroll.AddChild(options);
        body.AddChild(scroll);
        float mainWidth = width - 40 - SidebarWidth - 18 - 16; // 面板内边距、侧栏、间距、滚动条
        BuildOptions(options, mainWidth);
        body.AddChild(Sidebar());

        ApplyGameFont(_layer);
        _session.Finished -= OnFinished;
        _session.Finished += OnFinished;
        _session.Changed -= Render;
        _session.Changed += Render;
        _lastTicks = G.Time.GetTicksMsec();
        Tree.ProcessFrame += OnFrame;
        _frameHooked = true;
        AddDeferred(_layer);
        Render();
    }

    private void OnFinished(SummonSession _) => Close();
    private bool _frameHooked;

    public void Close()
    {
        // 只解绑真的绑过的（Godot 解绑不存在的连接会报 ERROR：0.0.29 关两次、0.0.41 Show 中途失败后关）
        if (_frameHooked) Tree.ProcessFrame -= OnFrame;
        _frameHooked = false;
        if (_layer != null && G.GodotObject.IsInstanceValid(_layer)) _layer.QueueFree();
        _layer = null;
    }

    // ---------------------------------------------------------------- 顶栏

    private G.Control TopBar()
    {
        var room = _session.Room;
        var (roomName, roomColor) = room.Room switch
        {
            RoomKind.Elite => ("精英房 · 七折", Elite),
            RoomKind.Boss => ("Boss 房", Danger),
            _ => ("普通房", Teal),
        };
        var bar = new G.HBoxContainer();
        bar.AddThemeConstantOverride("separation", 12);
        if (Art.Icon("icon_summon", 40) is { } icon) bar.AddChild(icon);
        bar.AddChild(Text("召唤", 34, Gold));
        bar.AddChild(Chip(roomName, roomColor, TextMain));
        if (_session.IsOpeningProtected)
        {
            var chip = Chip("开局保护", new G.Color(0.12f, 0.24f, 0.18f), Good);
            chip.TooltipText = "前几场只能用本幕普通怪，花费上限较低，不能盖陷阱";
            chip.MouseFilter = G.Control.MouseFilterEnum.Pass;
            bar.AddChild(chip);
        }
        bar.AddChild(Spacer());
        if (!_session.Unlimited)
        {
            _timer = Text("", 26, TextMain);
            bar.AddChild(_timer);
        }
        bar.AddChild(Resource("icon_summon_point", $"{room.Savings}", "召唤点"));
        return bar;
    }

    /// <summary>资源读数：图标（没有就用文字标签）+ 大号数字。</summary>
    internal static G.Control Resource(string icon, string value, string label)
    {
        var box = new G.PanelContainer();
        box.AddThemeStyleboxOverride("panel", Box(new G.Color(0.20f, 0.17f, 0.09f), GoldDim, 1, 12, 0));
        var row = new G.HBoxContainer();
        row.AddThemeConstantOverride("separation", 8);
        var margin = new G.MarginContainer();
        foreach (var (side, v) in new[] { ("margin_left", 14), ("margin_right", 14), ("margin_top", 4), ("margin_bottom", 4) })
            margin.AddThemeConstantOverride(side, v);
        if (Art.Icon(icon, 30) is { } tex) row.AddChild(tex);
        else row.AddChild(Text(label, 18, GoldDim));
        var number = Text(value, 28, Gold);
        row.AddChild(number);
        margin.AddChild(row);
        box.AddChild(margin);
        box.TooltipText = label;
        return box;
    }

    // ---------------------------------------------------------------- 选择区

    private void BuildOptions(G.VBoxContainer box, float width)
    {
        if (_session.Room.Room == RoomKind.Boss)
        {
            box.AddChild(Heading("Boss（免费）"));
            box.AddChild(Grid(_session.EncounterOptions, Math.Max(1, (int)(width / (BossPortrait.X + 30))), BossPortrait));
            box.AddChild(Heading("另加怪物"));
        }
        box.AddChild(FilterBar());
        int columns = Math.Max(3, (int)((width + 10) / (MonsterPortrait.X + 30)));
        box.AddChild(Grid(_session.MonsterOptions, columns, MonsterPortrait));
        ApplyFilter();
    }

    // ---------------------------------------------------------------- 筛选：幕、费用、精英

    private int _actFilter = -1;   // 0 = 全部；-1 = 还没定（默认本幕）
    private int _costFilter;       // 0 = 全部，1/2/3 = 正好这么多，4 = 4 点以上
    private bool _eliteOnly;
    private readonly List<(G.Button Button, Func<bool> On)> _filterButtons = new();

    /// <summary>幕分页 + 费用 + 精英。只是隐藏卡片，不影响已选的阵容。</summary>
    private G.Control FilterBar()
    {
        var acts = _session.MonsterOptions.Select(o => o.HomeAct).Distinct().Order().ToList();
        if (_actFilter < 0) _actFilter = acts.Contains(_session.ActNo) && acts.Count > 1 ? _session.ActNo : 0;
        var row = new G.HFlowContainer();
        row.AddThemeConstantOverride("h_separation", 6);
        row.AddThemeConstantOverride("v_separation", 6);
        if (acts.Count > 1)
        {
            row.AddChild(FilterButton("全部", () => _actFilter == 0, () => _actFilter = 0));
            foreach (var a in acts)
                row.AddChild(FilterButton($"第{"一二三"[Math.Clamp(a, 1, 3) - 1]}幕", () => _actFilter == a, () => _actFilter = a));
            row.AddChild(new G.Control { CustomMinimumSize = new G.Vector2(14, 0) });
        }
        row.AddChild(Text("费用", 15, TextDim));
        row.AddChild(FilterButton("全部", () => _costFilter == 0, () => _costFilter = 0));
        foreach (var c in new[] { 1, 2, 3, 4 })
            row.AddChild(FilterButton(c == 4 ? "4+" : $"{c}", () => _costFilter == c, () => _costFilter = c));
        if (_session.MonsterOptions.Any(o => o.IsElite))
        {
            row.AddChild(new G.Control { CustomMinimumSize = new G.Vector2(14, 0) });
            row.AddChild(FilterButton("只看精英", () => _eliteOnly, () => _eliteOnly = !_eliteOnly));
        }
        return row;
    }

    private G.Button FilterButton(string text, Func<bool> on, Action toggle)
    {
        var button = MakeButton(text, Sunk, CardHover, CardBorder, TextDim, new G.Vector2(0, 32), 15);
        button.Pressed += () => { toggle(); ApplyFilter(); };
        _filterButtons.Add((button, on));
        return button;
    }

    private void ApplyFilter()
    {
        foreach (var option in _session.MonsterOptions)
        {
            if (!_cards.TryGetValue(option.Id, out var entry)) continue;
            bool show = (_actFilter <= 0 || option.HomeAct == _actFilter)
                        && (_costFilter == 0 || (_costFilter == 4 ? option.Price >= 4 : option.Price == _costFilter))
                        && (!_eliteOnly || option.IsElite);
            entry.Card.Visible = show;
        }
        foreach (var (button, on) in _filterButtons)
        {
            // 各状态的边框、圆角、内边距要一样：原来只改了 normal，悬停时换回 MakeButton 的粗边框大内边距，按钮变形（0.0.40 用户反馈）
            bool active = on();
            var bg = active ? new G.Color(0.24f, 0.19f, 0.10f) : Sunk;
            var border = active ? Gold : CardBorder;
            button.AddThemeStyleboxOverride("normal", Box(bg, border, 1, 8, 10));
            button.AddThemeStyleboxOverride("hover", Box(active ? bg.Lightened(0.12f) : CardHover, active ? Gold : TextDim, 1, 8, 10));
            button.AddThemeStyleboxOverride("pressed", Box(active ? bg : CardHover, Gold, 1, 8, 10));
            button.AddThemeColorOverride("font_color", active ? Gold : TextDim);
            button.AddThemeColorOverride("font_hover_color", active ? Gold : G.Colors.White);
            button.AddThemeColorOverride("font_pressed_color", Gold);
        }
    }

    internal static G.Label Heading(string text)
    {
        var label = Text(text, 17, TextDim);
        label.AddThemeConstantOverride("outline_size", 0);
        return label;
    }

    private G.GridContainer Grid(IReadOnlyList<SummonOption> options, int columns, G.Vector2 portraitSize)
    {
        var grid = new G.GridContainer { Columns = columns, SizeFlagsHorizontal = G.Control.SizeFlags.ExpandFill };
        grid.AddThemeConstantOverride("h_separation", 10);
        grid.AddThemeConstantOverride("v_separation", 10);
        foreach (var option in options) grid.AddChild(OptionCard(option, portraitSize));
        return grid;
    }

    /// <summary>卡片：形象在上，名字在下；价格、数量、精英、跨幕标记都是形象上的小角标，详细说明放悬停提示。</summary>
    private G.Button OptionCard(SummonOption option, G.Vector2 portraitSize)
    {
        bool isEncounter = _session.EncounterOptions.Contains(option);
        var card = new G.Button
        {
            FocusMode = G.Control.FocusModeEnum.None,
            CustomMinimumSize = new G.Vector2(portraitSize.X + 16, portraitSize.Y + 44),
            SizeFlagsHorizontal = G.Control.SizeFlags.ExpandFill,
            TooltipText = Tooltip(option, isEncounter),
        };
        StyleCard(card, selected: false);

        var column = new G.VBoxContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore };
        column.SetAnchorsPreset(G.Control.LayoutPreset.FullRect);
        column.OffsetLeft = 8;
        column.OffsetRight = -8;
        column.OffsetTop = 8;
        column.OffsetBottom = -6;
        column.AddThemeConstantOverride("separation", 4);

        // 形象 + 角标
        var stage = new G.Control { CustomMinimumSize = portraitSize, MouseFilter = G.Control.MouseFilterEnum.Ignore, SizeFlagsHorizontal = G.Control.SizeFlags.ExpandFill };
        var monsterId = isEncounter ? _session.LeadMonsterOf(option.Id) : option.Id;
        if (monsterId != null && Portrait(monsterId, portraitSize) is { } portrait)
        {
            portrait.AnchorLeft = portrait.AnchorRight = 0.5f;
            portrait.OffsetLeft = -portraitSize.X / 2;
            portrait.OffsetRight = portraitSize.X / 2;
            portrait.OffsetTop = 0;
            portrait.OffsetBottom = portraitSize.Y;
            stage.AddChild(portrait);
        }
        var price = Badge(isEncounter ? "免费" : $"{option.Price}", new G.Color(0.20f, 0.17f, 0.09f, 0.95f), Gold);
        price.SetAnchorsPreset(G.Control.LayoutPreset.TopRight);
        price.GrowHorizontal = G.Control.GrowDirection.Begin;
        stage.AddChild(price);

        var count = Badge("", new G.Color(0.86f, 0.70f, 0.38f), new G.Color(0.1f, 0.08f, 0.04f));
        count.SetAnchorsPreset(G.Control.LayoutPreset.TopLeft);
        count.Visible = false;
        stage.AddChild(count);

        var tags = new G.HBoxContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore };
        tags.AddThemeConstantOverride("separation", 4);
        tags.SetAnchorsPreset(G.Control.LayoutPreset.BottomLeft);
        tags.GrowVertical = G.Control.GrowDirection.Begin;
        if (isEncounter)
        {
            if (!_session.EncounterAllowsExtras(option.Id)) tags.AddChild(Badge("不能另加", new G.Color(0.30f, 0.12f, 0.12f, 0.95f), new G.Color(1f, 0.65f, 0.6f)));
        }
        else
        {
            if (option.IsElite) tags.AddChild(Badge("精英", new G.Color(0.35f, 0.15f, 0.10f, 0.95f), new G.Color(1f, 0.75f, 0.55f)));
            if (option.HomeAct != _session.ActNo) tags.AddChild(Badge(Roman(option.HomeAct), new G.Color(0.10f, 0.18f, 0.28f, 0.95f), new G.Color(0.65f, 0.80f, 1f)));
        }
        stage.AddChild(tags);
        column.AddChild(stage);

        var name = Text(option.Name, 17, TextMain);
        name.HorizontalAlignment = G.HorizontalAlignment.Center;
        name.ClipText = true;
        name.TextOverrunBehavior = G.TextServer.OverrunBehavior.TrimEllipsis;
        name.MouseFilter = G.Control.MouseFilterEnum.Ignore;
        column.AddChild(name);

        card.AddChild(column);
        var id = option.Id;
        card.Pressed += () => _session.Click(id);
        _cards[id] = (card, count, (G.Label)count.GetChild(0));
        return card;
    }

    private string Tooltip(SummonOption option, bool isEncounter)
    {
        if (isEncounter)
            return $"{option.Name}\n免费出场" + (_session.EncounterAllowsExtras(option.Id) ? "，可以另加怪物" : "\n有专用场景，不能另加怪物");
        var lines = new List<string> { option.Name, $"召唤价 {option.Price} 点" };
        if (option.IsElite) lines.Add("精英（每场最多一只）");
        if (option.HomeAct != _session.ActNo)
            lines.Add(option.HpFactor < 1 ? $"第 {option.HomeAct} 幕的怪：生命 {option.HpFactor * 100:0}%" : $"第 {option.HomeAct} 幕的怪");
        return string.Join("\n", lines);
    }

    private static string Roman(int act) => act switch { 1 => "I", 2 => "II", 3 => "III", _ => act.ToString() };

    /// <summary>形象上的小角标。</summary>
    internal static G.PanelContainer Badge(string text, G.Color bg, G.Color fg)
    {
        var badge = new G.PanelContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore };
        var sb = Box(bg, bg, 0, 9, 0);
        sb.ContentMarginLeft = sb.ContentMarginRight = 8;
        sb.ContentMarginTop = sb.ContentMarginBottom = 1;
        badge.AddThemeStyleboxOverride("panel", sb);
        var label = Text(text, 15, fg);
        label.MouseFilter = G.Control.MouseFilterEnum.Ignore;
        badge.AddChild(label);
        return badge;
    }

    // ---------------------------------------------------------------- 侧栏

    private G.Control Sidebar()
    {
        var side = new G.PanelContainer { CustomMinimumSize = new G.Vector2(SidebarWidth, 0) };
        side.AddThemeStyleboxOverride("panel", Box(Sunk, CardBorder, 1, 12, 16));
        var col = new G.VBoxContainer();
        col.AddThemeConstantOverride("separation", 10);
        side.AddChild(col);

        col.AddChild(Heading(_session.Room.Room == RoomKind.Boss ? "另加的怪" : "本场阵容"));
        var lineupScroll = new G.ScrollContainer { HorizontalScrollMode = G.ScrollContainer.ScrollMode.Disabled, SizeFlagsVertical = G.Control.SizeFlags.ExpandFill };
        var lineupBox = new G.VBoxContainer { SizeFlagsHorizontal = G.Control.SizeFlags.ExpandFill };
        lineupBox.AddThemeConstantOverride("separation", 6);
        _lineup = new G.VBoxContainer();
        _lineup.AddThemeConstantOverride("separation", 4);
        lineupBox.AddChild(_lineup);
        _emptyHint = Text(_session.Room.Room == RoomKind.Boss ? "可以不加" : "点左边的怪加入", 16, TextDim);
        lineupBox.AddChild(_emptyHint);
        lineupScroll.AddChild(lineupBox);
        col.AddChild(lineupScroll);

        BuildTraps(col);

        col.AddChild(Divider());
        // 总花费最醒目；下面一行小字拆开；怪物花费有上限，用进度条
        var totalRow = new G.HBoxContainer();
        totalRow.AddChild(Text("总花费", 18, TextDim));
        totalRow.AddChild(Spacer());
        _total = Text("0", 30, TextMain);
        totalRow.AddChild(_total);
        col.AddChild(totalRow);
        _breakdown = Text("", 14, TextDim);
        col.AddChild(_breakdown);
        var capRow = new G.HBoxContainer();
        capRow.AddChild(Text("怪物上限", 14, TextDim));
        capRow.AddChild(Spacer());
        _cost = Text("0 / 0", 14, TextDim);
        capRow.AddChild(_cost);
        col.AddChild(capRow);
        _capBar = Bar(1, 0, Good, 6);
        col.AddChild(_capBar);
        var leftRow = new G.HBoxContainer();
        leftRow.AddChild(Text("确认后剩余", 18, TextDim));
        leftRow.AddChild(Spacer());
        _left = Text("0", 30, Gold);
        leftRow.AddChild(_left);
        col.AddChild(leftRow);

        _problems = new G.VBoxContainer();
        _problems.AddThemeConstantOverride("separation", 2);
        col.AddChild(_problems);

        _confirm = MakeButton("确认召唤", Teal, TealHover, Gold, TextMain, new G.Vector2(0, 58), 24);
        _confirm.Pressed += () => _session.Confirm();
        col.AddChild(_confirm);
        var vanilla = MakeButton("按原版出场", Sunk, CardHover, CardBorder, TextDim, new G.Vector2(0, 40), 17);
        vanilla.TooltipText = "不自己选，按这个房间原版的怪出场，花标准开销";
        vanilla.Pressed += () => _session.UseVanilla();
        col.AddChild(vanilla);
        return side;
    }

    /// <summary>陷阱：手里每张一个开关，悬停看条件和效果。开局保护期间只显示一行说明。</summary>
    private void BuildTraps(G.VBoxContainer col)
    {
        if (_session.TrapHand.Count == 0) return;
        col.AddChild(Divider());
        var head = new G.HBoxContainer();
        head.AddChild(Heading("盖陷阱"));
        head.AddChild(Spacer());
        head.AddChild(Text("每张 1 点 · 最多 2", 15, TextDim));
        col.AddChild(head);
        if (_session.IsOpeningProtected)
        {
            col.AddChild(Text("开局保护中，不能盖", 16, TextDim));
            return;
        }
        var flow = new G.HFlowContainer();
        flow.AddThemeConstantOverride("h_separation", 6);
        flow.AddThemeConstantOverride("v_separation", 6);
        for (int i = 0; i < _session.TrapHand.Count; i++)
        {
            var card = _session.TrapHand[i];
            var button = TrapMiniCard(card);
            if (_session.TrapCooling(i)) // 上一场盖过同种：这一场冷却
            {
                button.Disabled = true;
                button.Modulate = new G.Color(1, 1, 1, 0.4f);
                button.TooltipText += "\n上一场盖过，这一场冷却";
            }
            int index = i;
            button.Pressed += () => _session.ToggleTrap(index);
            _trapButtons.Add((button, i));
            flow.AddChild(button);
        }
        col.AddChild(flow);
    }

    /// <summary>陷阱小卡：上面图，下面名字；说明在悬停提示。选中时红框（Render 里设）。</summary>
    internal static G.Button TrapMiniCard(TrapCard card, float width = 72)
    {
        var button = new G.Button
        {
            FocusMode = G.Control.FocusModeEnum.None,
            CustomMinimumSize = new G.Vector2(width, width * 1.3f),
            TooltipText = $"{card.Name}\n{card.Describe()}\n{card.Def.Rules(ModEntry.Active.DodgeRewardGold)}",
        };
        StyleCard(button, false);
        var col = new G.VBoxContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore, Alignment = G.BoxContainer.AlignmentMode.Center };
        col.SetAnchorsPreset(G.Control.LayoutPreset.FullRect);
        col.AddThemeConstantOverride("separation", 2);
        var art = new G.CenterContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore, CustomMinimumSize = new G.Vector2(0, width * 0.7f) };
        if (Art.Icon($"trap_{card.Id}", width * 0.62f) is { } icon) art.AddChild(icon);
        else art.AddChild(Text(card.Def.NameZh[..1], (int)(width * 0.36f), Gold));
        col.AddChild(art);
        var name = Text(card.Name, 14, TextMain);
        name.HorizontalAlignment = G.HorizontalAlignment.Center;
        name.ClipText = true;
        name.MouseFilter = G.Control.MouseFilterEnum.Ignore;
        col.AddChild(name);
        button.AddChild(col);
        return button;
    }

    // ---------------------------------------------------------------- 刷新

    private void OnFrame()
    {
        var now = G.Time.GetTicksMsec();
        _session.Tick((now - _lastTicks) / 1000.0);
        _lastTicks = now;
        if (_session.Done || _timer == null) return;
        _timer.Text = $"{Math.Ceiling(_session.SecondsLeft)} 秒";
        _timer.AddThemeColorOverride("font_color", _session.SecondsLeft <= 10 ? Bad : TextMain);
    }

    private void Render()
    {
        if (_session.Done || _layer == null) return;
        var quote = _session.Quote;

        foreach (var (id, (card, count, countText)) in _cards)
        {
            bool isEncounter = _session.EncounterOptions.Any(o => o.Id == id);
            int n = isEncounter ? (_session.Encounter == id ? 1 : 0) : _session.Monsters.Count(m => m == id);
            count.Visible = !isEncounter && n > 0;
            countText.Text = $"×{n}";
            StyleCard(card, n > 0);
            if (!isEncounter)
            {
                card.Disabled = !_session.BossAllowsExtras;
                card.Modulate = new G.Color(1, 1, 1, _session.BossAllowsExtras ? 1f : 0.35f);
            }
        }

        foreach (var (button, index) in _trapButtons)
        {
            bool on = _session.SelectedTraps.Contains(index);
            button.AddThemeStyleboxOverride("normal", Box(on ? new G.Color(0.30f, 0.12f, 0.14f) : CardBg, on ? Bad : CardBorder, on ? 3 : 1, 10, 0));
            button.AddThemeStyleboxOverride("hover", Box(on ? new G.Color(0.36f, 0.15f, 0.17f) : CardHover, on ? Bad : GoldDim, on ? 3 : 1, 10, 0));
        }

        foreach (var child in _lineup.GetChildren()) child.QueueFree();
        for (int i = 0; i < _session.Monsters.Count; i++)
        {
            int index = i;
            var id = _session.Monsters[i];
            var price = _session.MonsterOptions.FirstOrDefault(o => o.Id == id)?.Price ?? 0;
            _lineup.AddChild(LineupRow(_session.NameOf(id), $"{price}", () => _session.RemoveAt(index)));
        }
        _emptyHint.Visible = _session.Monsters.Count == 0;
        if (_session.Room.Room == RoomKind.Boss && !_session.BossAllowsExtras) _emptyHint.Text = "这个 Boss 不能另加";
        else if (_session.Room.Room == RoomKind.Boss) _emptyHint.Text = "可以不加";
        ApplyGameFont(_lineup);

        bool overCap = quote.MonsterSpend > quote.SpendCap + 1e-9;
        int left = _session.Room.Savings - quote.Total;
        _total.Text = $"{quote.Total}";
        _breakdown.Text = $"怪物 {quote.MonsterPrice} · 群体税 {quote.CrowdTax}" + (quote.TrapCost > 0 ? $" · 陷阱 {quote.TrapCost}" : "");
        _cost.Text = $"{quote.MonsterSpend} / {quote.SpendCap:0.#}";
        _cost.AddThemeColorOverride("font_color", overCap ? Bad : TextMain);
        _cost.TooltipText = $"怪物 {quote.MonsterPrice} + 群体税 {quote.CrowdTax}" + (quote.TrapCost > 0 ? $" + 陷阱 {quote.TrapCost}" : "") +
                            $"\n怪物花费上限 {quote.SpendCap:0.#}";
        _cost.MouseFilter = G.Control.MouseFilterEnum.Pass;
        _capBar.MaxValue = Math.Max(1, quote.SpendCap);
        _capBar.Value = Math.Min(quote.MonsterSpend, _capBar.MaxValue);
        _capBar.AddThemeStyleboxOverride("fill", Box(overCap ? Bad : Good, overCap ? Bad : Good, 0, 4, 0));
        _left.Text = $"{left}";
        _left.AddThemeColorOverride("font_color", left < 0 ? Bad : Gold);

        foreach (var child in _problems.GetChildren()) child.QueueFree();
        var problems = _session.ExtraProblems
            .Concat(quote.Violations.Where(v => v != SummonViolation.EmptyRoom).Select(SummonSession.Describe)).ToList();
        foreach (var problem in problems)
        {
            var line = Text("✗ " + problem, 16, Bad);
            line.AutowrapMode = G.TextServer.AutowrapMode.WordSmart;
            ApplyGameFont(line);
            _problems.AddChild(line);
        }
        _confirm.Disabled = !_session.CanConfirm;
    }

    /// <summary>侧栏阵容的一行：名字、价格、移除。</summary>
    private static G.Control LineupRow(string name, string price, Action remove)
    {
        var row = new G.PanelContainer();
        row.AddThemeStyleboxOverride("panel", Box(CardBg, CardBorder, 1, 8, 0));
        var h = new G.HBoxContainer();
        h.AddThemeConstantOverride("separation", 8);
        var margin = new G.MarginContainer();
        foreach (var (side, v) in new[] { ("margin_left", 10), ("margin_right", 4), ("margin_top", 2), ("margin_bottom", 2) })
            margin.AddThemeConstantOverride(side, v);
        var label = Text(name, 17, TextMain);
        label.SizeFlagsHorizontal = G.Control.SizeFlags.ExpandFill;
        label.VerticalAlignment = G.VerticalAlignment.Center;
        h.AddChild(label);
        var cost = Text(price, 17, Gold);
        cost.VerticalAlignment = G.VerticalAlignment.Center;
        h.AddChild(cost);
        var x = MakeButton("✕", CardBg, Danger, CardBorder, TextDim, new G.Vector2(32, 30), 15);
        x.Pressed += remove;
        h.AddChild(x);
        margin.AddChild(h);
        row.AddChild(margin);
        return row;
    }

    /// <summary>
    /// 怪物形象：游戏没有现成的怪物头像图（图鉴也是现场摆出战斗模型），所以把战斗模型放进一个小视口里画，自动取景后定格。
    /// 0.0.41 起照原版图鉴（NBestiaryLayoutDefault.Setup）建完整的 NCreature：可变模型 → 随机数 → SetUpForCombat →
    /// Creature（NullCombatState）→ NCreature.Create → SetupForBestiary。只建外观（CreateVisuals）时化石追踪者、幽灵船、
    /// 鬼祟珊瑚群缺主体、零件散开（0.0.40 和图鉴并排对照）。这条路走不通就退回只建外观。失败返回 null，卡片只显示文字。
    /// </summary>
    private static G.Control? Portrait(string monsterId, G.Vector2 size)
    {
        try
        {
            var model = Test1bMixedEncounter.Model("Monster", monsterId);
            var viewport = new G.SubViewport
            {
                TransparentBg = true,
                Disable3D = true,
                Size = new G.Vector2I((int)size.X, (int)size.Y),
                RenderTargetUpdateMode = G.SubViewport.UpdateMode.Always,
            };
            var rig = (_creaturePathBroken ? null : CreatureRig(model, monsterId, size)) ?? VisualsRig(model, monsterId, size);
            if (rig == null) return null;
            viewport.AddChild(rig);

            var container = new G.SubViewportContainer
            {
                Stretch = true,
                CustomMinimumSize = size,
                MouseFilter = G.Control.MouseFilterEnum.Ignore,
            };
            container.AddChild(viewport);
            FitAndFreeze(viewport, rig, _portraits++, monsterId);
            return container;
        }
        catch (Exception e)
        {
            Log.Warn($"召唤面板：画不出 {monsterId} 的形象，只显示名字：{e.InnerException?.Message ?? e.Message}");
            return null;
        }
    }

    private static bool _creaturePathBroken;

    /// <summary>原版图鉴的做法：完整 NCreature，放在一个 Node2D 架子里（取景只动架子）。</summary>
    private static G.Node2D? CreatureRig(object canonical, string monsterId, G.Vector2 size)
    {
        try
        {
            var monster = canonical.GetType().GetMethod("ToMutable", Type.EmptyTypes)?.Invoke(canonical, null) ?? throw new MissingMethodException("MonsterModel.ToMutable");
            var rngType = GameReflection.TypesNamed("Rng").FirstOrDefault(t => t.Namespace == "MegaCrit.Sts2.Core.Random") ?? throw new TypeLoadException("Rng");
            var rng = rngType.GetConstructor([typeof(ulong)])?.Invoke([(ulong)(uint)monsterId.GetHashCode()])
                      ?? Activator.CreateInstance(rngType, [(ulong)1]);
            GameReflection.Set(monster, "Rng", rng);
            RuntimeNetAction.Call(monster, "SetUpForCombat");

            var creatureType = GameReflection.TypesNamed("Creature").First(t => t.Namespace == "MegaCrit.Sts2.Core.Entities.Creatures");
            var ctor = creatureType.GetConstructors().First(c => c.GetParameters().Length == 3 && c.GetParameters()[0].ParameterType.Name == "MonsterModel");
            var side = Enum.ToObject(ctor.GetParameters()[1].ParameterType, 2); // CombatSide.Enemy
            var creature = ctor.Invoke([monster, side, null]);
            var nullState = GameReflection.TypesNamed("NullCombatState").First().GetProperty("Instance", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static)!.GetValue(null);
            GameReflection.Set(creature, "CombatState", nullState);

            var create = RuntimeNetAction.Required("NCreature").GetMethod("Create", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static)
                         ?? throw new MissingMethodException("NCreature.Create");
            if (create.Invoke(null, [creature]) is not G.Control node) throw new InvalidOperationException("NCreature.Create 没返回节点");
            node.MouseFilter = G.Control.MouseFilterEnum.Ignore;
            var rig = new G.Node2D();
            rig.AddChild(node);
            node.Ready += () =>
            {
                try
                {
                    RuntimeNetAction.Call(node, "SetupForBestiary");
                    Quiet(node);
                    InitialPlace(rig, GameReflection.Get(node, "Visuals") is G.Node visuals ? GameReflection.Get(visuals, "Bounds") as G.Control : null, size);
                }
                catch (Exception e) { Log.Warn($"召唤面板：{monsterId} 图鉴式初始化后半段失败，按原样显示：{e.InnerException?.Message ?? e.Message}"); }
            };
            return rig;
        }
        catch (Exception e)
        {
            _creaturePathBroken = true; // 一只走不通，其他的大概也走不通：之后都直接用旧做法，免得刷屏
            Log.Warn($"召唤面板：{monsterId} 按原版图鉴建 NCreature 失败，退回只建外观：{e.InnerException?.Message ?? e.Message}");
            return null;
        }
    }

    /// <summary>旧做法（0.0.37–0.0.40）：只建外观（MonsterModel.CreateVisuals），自己建动画控制器、套皮肤。</summary>
    private static G.Node2D? VisualsRig(object model, string monsterId, G.Vector2 size)
    {
        var create = model.GetType().GetMethod("CreateVisuals", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance, Type.EmptyTypes);
        if (create?.Invoke(model, null) is not G.Node2D visuals) return null;
        var rig = new G.Node2D();
        rig.AddChild(visuals);
        visuals.Ready += () =>
        {
            SetUpLikeCombat(visuals, model, monsterId);
            Quiet(visuals);
            InitialPlace(rig, GameReflection.Get(visuals, "Bounds") as G.Control, size);
        };
        return rig;
    }

    /// <summary>
    /// 先按点击框（Bounds）缩到视口的 30%、放在正中（高个子、带特效的怪画出来常比点击框大很多），之后 FitAndFreeze 再按实际像素取景。
    /// </summary>
    private static void InitialPlace(G.Node2D rig, G.Control? bounds, G.Vector2 size)
    {
        rig.Scale = G.Vector2.One;
        rig.Position = G.Vector2.Zero;
        if (bounds != null && bounds.Size.X > 1 && bounds.Size.Y > 1)
        {
            var rect = bounds.GetGlobalRect(); // 架子没缩放时，视口里的坐标
            float scale = Math.Min(size.X * 0.30f / rect.Size.X, size.Y * 0.30f / rect.Size.Y);
            rig.Scale = new G.Vector2(scale, scale);
            rig.Position = size / 2 - (rect.Position + rect.Size / 2) * scale;
        }
        else
        {
            rig.Scale = new G.Vector2(0.25f, 0.25f);
            rig.Position = size / 2;
        }
    }

    /// <summary>预览里不要粒子特效（会把取景范围撑大，淤泥旋螺被粒子柱挤成小点），也不要任何控件吃鼠标。</summary>
    private static void Quiet(G.Node root)
    {
        var stack = new Stack<G.Node>();
        stack.Push(root);
        while (stack.Count > 0)
        {
            var n = stack.Pop();
            if (n is G.GpuParticles2D gpu) { gpu.Emitting = false; gpu.Visible = false; }
            else if (n is G.CpuParticles2D cpu) { cpu.Emitting = false; cpu.Visible = false; }
            else if (n is G.Control c) c.MouseFilter = G.Control.MouseFilterEnum.Ignore;
            foreach (var child in n.GetChildren()) stack.Push(child);
        }
    }

    private static int _portraits;
    private static readonly System.Runtime.CompilerServices.ConditionalWeakTable<G.Node, object> Animators = new();

    private static void SetUpLikeCombat(G.Node2D visuals, object model, string monsterId)
    {
        try
        {
            var skinModel = model;
            try { if (GameReflection.Get(model, "IsMutable") is false && model.GetType().GetMethod("ToMutable", Type.EmptyTypes) is { } m) skinModel = m.Invoke(model, null) ?? model; }
            catch { /* 用规范模型 */ }
            // 原版 NCreature 的顺序：先建动画控制器，再套皮肤（0.0.38 测试助手查 NCreature.cs:310）
            var spine = GameReflection.Get(visuals, "SpineBody");
            if (spine == null) Log.Info($"召唤面板：{monsterId} 没有骨骼动画（SpineBody 为空），按原样显示");
            else if (skinModel.GetType().GetMethod("GenerateAnimator", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance)?.Invoke(skinModel, [spine]) is { } animator)
                Animators.AddOrUpdate(visuals, animator); // 留住动画控制器，别被回收
            else Log.Info($"召唤面板：{monsterId} 没有建出动画控制器");
            var setUpSkin = visuals.GetType().GetMethod("SetUpSkin", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
            if (setUpSkin == null) Log.Info($"召唤面板：{monsterId} 外观没有 SetUpSkin");
            else setUpSkin.Invoke(visuals, [skinModel]);
        }
        catch (Exception e) { Log.Warn($"召唤面板：{monsterId} 套皮肤/启动动画失败，按原样显示：{e.InnerException?.Message ?? e.Message}"); }
    }

    /// <summary>
    /// 自动取景：画几帧后读视口图片里不透明像素的范围（Image.GetUsedRect），按它放大到视口 90%、水平居中、底部贴近下沿，
    /// 再画几帧后定格（视口不再重画、模型暂停处理），十几张卡片同时开着也几乎没有持续开销，代价是怪物不会动。
    /// 读到的范围碰到视口边（说明还是太大被裁了）就再缩小一半重来，最多 3 次。
    /// 每张卡片错开几帧，免得同一帧里几十次从显卡读图卡一下。
    /// </summary>
    private static void FitAndFreeze(G.SubViewport viewport, G.Node2D visuals, int order, string monsterId = "")
    {
        // 0.0.38 实测很多怪缺头/上半身：旧做法用去掉 1.5% 像素后的范围判断「有没有被裁」，细长的头被当成零星像素去掉了，
        // 被裁也看不出来；放大后也不再检查。新做法：
        // 1. 等约 0.8 秒（入场动画、骨骼摆好）；2. 隔几帧量 3 次取并集（动画在动）；碰到视口边就缩小一半重来；
        // 3. 按并集放大到 88%、脚底贴近下沿；4. 放大后再量，碰边就再缩 15% 直到完整；5. 定格。
        int wait = 48 + order % 12, samples = 0, shrinks = 0, checks = 0, empties = 0;
        bool shown = false;
        var union = new G.Rect2I();
        string phase = "measure";
        void Freeze(string note)
        {
            Tree.ProcessFrame -= Tick;
            viewport.RenderTargetUpdateMode = G.SubViewport.UpdateMode.Disabled;
            visuals.ProcessMode = G.Node.ProcessModeEnum.Disabled;
            if (note.Length > 0) Log.Info($"召唤面板：{monsterId} 取景 {note}");
        }
        void Tick()
        {
            if (!G.GodotObject.IsInstanceValid(viewport) || !G.GodotObject.IsInstanceValid(visuals)) { Tree.ProcessFrame -= Tick; return; }
            // 隐藏的卡片（别的幕分页、筛掉的）不渲染，量出来是空的（0.0.39 实测第二、三幕 20 只怪因此定格成很小）：等它显示出来再开始量
            if (viewport.GetParent() is G.CanvasItem holder && !holder.IsVisibleInTree()) { shown = false; return; }
            if (!shown) { shown = true; wait = Math.Max(wait, 20); }
            if (--wait > 0) return;
            try
            {
                // 有的粒子是动画跑起来后才加的（缩小甲虫头上的白粒子，0.0.41 实测），量之前再关一遍
                if (phase == "measure" && samples == 0) Quiet(visuals);
                var size = new G.Vector2(viewport.Size.X, viewport.Size.Y);
                var used = OpaqueRect(viewport.GetTexture().GetImage(), 0.002);
                bool Touches(G.Rect2I r) => r.Position.X <= 1 || r.Position.Y <= 1 || r.End.X >= size.X - 1 || r.End.Y >= size.Y - 1;
                if (phase == "measure")
                {
                    if (used.Size.X <= 0 || used.Size.Y <= 0)
                    {
                        if (++empties < 10) { wait = 6; return; } // 可能还没画出来，再等等
                        Freeze("什么都没画出来");
                        return;
                    }
                    union = samples == 0 ? used : union.Merge(used);
                    if (Touches(used) && shrinks < 4)
                    {
                        Rescale(visuals, 0.5f, size / 2, size / 2); // 太大被裁：以视口中心缩小一半，重新量
                        shrinks++;
                        samples = 0;
                        wait = 4;
                        return;
                    }
                    if (++samples < 3) { wait = 6; return; }
                    var rect = new G.Rect2(union.Position, union.Size);
                    float f = Math.Min(Math.Min(size.X * 0.88f / rect.Size.X, size.Y * 0.88f / rect.Size.Y), 6f); // 很小的怪也别放大到糊
                    var center = rect.Position + rect.Size / 2;
                    var target = new G.Vector2(size.X / 2, Math.Max(size.Y * 0.95f - rect.Size.Y * f / 2, rect.Size.Y * f / 2 + size.Y * 0.03f));
                    Rescale(visuals, f, center, target);
                    phase = "verify";
                    wait = 4;
                    return;
                }
                // verify：放大后还碰边就缩小 15% 再看
                if (used.Size.X > 0 && Touches(used) && ++checks <= 5)
                {
                    var c = new G.Vector2(used.Position.X + used.Size.X / 2f, used.Position.Y + used.Size.Y / 2f);
                    Rescale(visuals, 0.85f, c, new G.Vector2(size.X / 2, size.Y / 2));
                    wait = 4;
                    return;
                }
                Freeze(checks > 0 || shrinks > 0 ? $"缩小 {shrinks} 次、校正 {checks} 次，范围 {used}" : "");
            }
            catch (Exception e)
            {
                Log.Warn($"召唤面板：{monsterId} 自动取景失败，保持原样：{e.Message}");
                Freeze("");
            }
        }
        Tree.ProcessFrame += Tick;
    }

    /// <summary>
    /// 不透明像素的范围，去掉两头各 1.5% 的零星像素（飘散的粒子、远处的小特效），免得一点火星把主体缩得很小。
    /// </summary>
    private static G.Rect2I OpaqueRect(G.Image image, double trimRatio = 0.015)
    {
        if (image.GetFormat() != G.Image.Format.Rgba8) image.Convert(G.Image.Format.Rgba8);
        int w = image.GetWidth(), h = image.GetHeight();
        var data = image.GetData();
        var rows = new int[h];
        var cols = new int[w];
        int total = 0;
        for (int y = 0; y < h; y++)
        for (int x = 0; x < w; x++)
        {
            if (data[(y * w + x) * 4 + 3] < 40) continue;
            rows[y]++;
            cols[x]++;
            total++;
        }
        if (total == 0) return new G.Rect2I();
        int trim = (int)(total * trimRatio);
        (int lo, int hi) Range(int[] counts)
        {
            int lo = 0, hi = counts.Length - 1, acc = 0;
            while (lo < hi && acc + counts[lo] <= trim) acc += counts[lo++];
            acc = 0;
            while (hi > lo && acc + counts[hi] <= trim) acc += counts[hi--];
            return (lo, hi);
        }
        var (x0, x1) = Range(cols);
        var (y0, y1) = Range(rows);
        return new G.Rect2I(x0, y0, x1 - x0 + 1, y1 - y0 + 1);
    }

    /// <summary>把模型放大 f 倍，同时让视口里原来在 from 的点移到 to。</summary>
    private static void Rescale(G.Node2D visuals, float f, G.Vector2 from, G.Vector2 to)
    {
        visuals.Position = to - (from - visuals.Position) * f;
        visuals.Scale *= f;
    }


    // ---------------------------------------------------------------- 样式工具

    internal static G.StyleBoxFlat Box(G.Color bg, G.Color border, int borderWidth, int radius, float padding, int shadow = 0)
    {
        var sb = new G.StyleBoxFlat { BgColor = bg, BorderColor = border };
        sb.SetBorderWidthAll(borderWidth);
        sb.SetCornerRadiusAll(radius);
        sb.SetContentMarginAll(padding);
        if (shadow > 0)
        {
            sb.ShadowColor = new G.Color(0, 0, 0, 0.55f);
            sb.ShadowSize = shadow;
        }
        return sb;
    }

    internal static void StyleCard(G.Button card, bool selected)
    {
        var border = selected ? Gold : CardBorder;
        var width = selected ? 3 : 1;
        card.AddThemeStyleboxOverride("normal", Box(selected ? new G.Color(0.20f, 0.20f, 0.20f) : CardBg, border, width, 10, 0));
        card.AddThemeStyleboxOverride("hover", Box(CardHover, selected ? Gold : GoldDim, width, 10, 0));
        card.AddThemeStyleboxOverride("pressed", Box(CardHover, Gold, 3, 10, 0));
        card.AddThemeStyleboxOverride("disabled", Box(CardBg, CardBorder, 1, 10, 0));
        card.AddThemeStyleboxOverride("focus", new G.StyleBoxEmpty());
    }

    internal static G.Button MakeButton(string text, G.Color bg, G.Color hover, G.Color border, G.Color fg, G.Vector2 size, int fontSize = 22)
    {
        var button = new G.Button { Text = text, FocusMode = G.Control.FocusModeEnum.None, CustomMinimumSize = size };
        button.AddThemeFontSizeOverride("font_size", fontSize);
        button.AddThemeStyleboxOverride("normal", Box(bg, border, 2, 10, 14));
        button.AddThemeStyleboxOverride("hover", Box(hover, border, 2, 10, 14));
        button.AddThemeStyleboxOverride("pressed", Box(hover, Gold, 3, 10, 14));
        button.AddThemeStyleboxOverride("disabled", Box(new G.Color(0.12f, 0.13f, 0.16f), new G.Color(0.22f, 0.24f, 0.28f), 2, 10, 14));
        button.AddThemeStyleboxOverride("focus", new G.StyleBoxEmpty());
        button.AddThemeColorOverride("font_color", fg);
        button.AddThemeColorOverride("font_hover_color", G.Colors.White);
        button.AddThemeColorOverride("font_pressed_color", Gold);
        button.AddThemeColorOverride("font_disabled_color", new G.Color(0.45f, 0.46f, 0.50f));
        return button;
    }

    internal static G.PanelContainer Chip(string text, G.Color bg, G.Color fg, G.Color? border = null)
    {
        var chip = new G.PanelContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore, SizeFlagsVertical = G.Control.SizeFlags.ShrinkCenter };
        var sb = Box(bg, border ?? bg, border == null ? 0 : 1, 14, 0);
        sb.ContentMarginLeft = sb.ContentMarginRight = 12;
        sb.ContentMarginTop = sb.ContentMarginBottom = 3;
        chip.AddThemeStyleboxOverride("panel", sb);
        var label = Text(text, 19, fg);
        label.MouseFilter = G.Control.MouseFilterEnum.Ignore;
        chip.AddChild(label);
        return chip;
    }

    internal static G.ProgressBar Bar(double max, double value, G.Color fill, int height)
    {
        var bar = new G.ProgressBar
        {
            MinValue = 0, MaxValue = max, Value = value, ShowPercentage = false,
            CustomMinimumSize = new G.Vector2(0, height), MouseFilter = G.Control.MouseFilterEnum.Ignore,
        };
        bar.AddThemeStyleboxOverride("background", Box(new G.Color(0.05f, 0.06f, 0.09f), CardBorder, 1, height / 2, 0));
        bar.AddThemeStyleboxOverride("fill", Box(fill, fill, 0, height / 2, 0));
        return bar;
    }

    internal static G.ColorRect Divider() =>
        new() { Color = new G.Color(Gold.R, Gold.G, Gold.B, 0.35f), CustomMinimumSize = new G.Vector2(0, 2), MouseFilter = G.Control.MouseFilterEnum.Ignore };

    internal static G.Control Spacer() => new() { SizeFlagsHorizontal = G.Control.SizeFlags.ExpandFill, MouseFilter = G.Control.MouseFilterEnum.Ignore };

    internal static G.Label Text(string text, int size, G.Color? color = null)
    {
        var label = new G.Label { Text = text };
        label.AddThemeFontSizeOverride("font_size", size);
        if (color != null) label.AddThemeColorOverride("font_color", color.Value);
        return label;
    }

    // ---------------------------------------------------------------- 字体

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

    internal static void ApplyGameFont(G.Node root)
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

    /// <summary>屏幕上方显示几秒的提示条（战斗收入等）。</summary>
    /// <summary>正在显示的提示占了哪些行：连着出几张盲盒时提示往下排，不叠在一起（0.0.40 实测重叠）。</summary>
    private static readonly HashSet<int> ToastSlots = [];

    public static void ShowToast(string text, double seconds = 6)
    {
        int slot = 0;
        while (ToastSlots.Contains(slot)) slot++;
        ToastSlots.Add(slot);
        var layer = new G.CanvasLayer { Layer = 101 };
        var holder = new G.CenterContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore };
        holder.SetAnchorsPreset(G.Control.LayoutPreset.TopWide);
        holder.Position = new G.Vector2(0, 90 + slot % 6 * 72);
        var panel = new G.PanelContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore };
        panel.AddThemeStyleboxOverride("panel", Box(PanelBg, Gold, 2, 12, 16, shadow: 12));
        var label = Text(text, 24, Gold);
        label.MouseFilter = G.Control.MouseFilterEnum.Ignore;
        panel.AddChild(label);
        holder.AddChild(panel);
        layer.AddChild(holder);
        ApplyGameFont(layer);
        AddDeferred(layer);
        Tree.CreateTimer(seconds).Timeout += () => { ToastSlots.Remove(slot); layer.QueueFree(); };
    }
}
