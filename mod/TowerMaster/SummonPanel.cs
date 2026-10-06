using TowerMaster.Core;
using G = Godot;

namespace TowerMaster;

/// <summary>
/// 召唤面板（只在塔主这台电脑上显示）。全部用 Godot 自带控件 + StyleBoxFlat 样式拼，不定义自己的节点类：
/// mod 程序集里的自定义节点类不一定能被引擎登记，用自带控件 + C# 事件最稳。
/// 界面挂在场景树根上的一个高层 CanvasLayer 里，半透明遮罩挡住下面的点击。
/// 中文字体借用游戏里第一个 MegaLabel 的字体（Godot 默认字体没有中文）。
/// 配色向游戏靠：深蓝底、金色描边、青绿按钮。
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

    private readonly SummonSession _session;
    private G.CanvasLayer? _layer;
    private G.Label? _timer;
    private G.Label _status = null!, _emptyHint = null!;
    private G.ProgressBar? _timerBar;
    private G.ProgressBar _capBar = null!;
    private G.HFlowContainer? _chosen;
    private G.VBoxContainer _problems = null!;
    private G.Button _confirm = null!;
    private readonly Dictionary<string, (G.Button Card, G.Label Count)> _cards = new();
    private readonly Dictionary<string, G.Label> _stats = new();
    private ulong _lastTicks;
    private readonly double _totalSeconds;

    public SummonPanel(SummonSession session)
    {
        _session = session;
        _totalSeconds = Math.Max(1, session.SecondsLeft);
    }

    internal static G.SceneTree Tree => (G.SceneTree)G.Engine.GetMainLoop();

    public void Show()
    {
        _layer = new G.CanvasLayer { Layer = 100 };

        var backdrop = new G.ColorRect { Color = Backdrop, MouseFilter = G.Control.MouseFilterEnum.Stop };
        backdrop.SetAnchorsPreset(G.Control.LayoutPreset.FullRect);
        _layer.AddChild(backdrop);

        // 面板固定占满窗口高度（留边），中间只有怪物列表滚动；底部的阵容、花费、按钮永远看得见
        var screen = Tree.Root.GetVisibleRect().Size;
        float width = Math.Min(1400, screen.X - 60);
        var panel = new G.PanelContainer();
        panel.AddThemeStyleboxOverride("panel", Box(PanelBg, Gold, 3, 14, 22, shadow: 24));
        panel.SetAnchorsPreset(G.Control.LayoutPreset.FullRect);
        panel.OffsetLeft = (screen.X - width) / 2;
        panel.OffsetRight = -(screen.X - width) / 2;
        panel.OffsetTop = 24;
        panel.OffsetBottom = -24;
        _layer.AddChild(panel);

        var box = new G.VBoxContainer();
        box.AddThemeConstantOverride("separation", 12);
        panel.AddChild(box);

        BuildHeader(box);
        box.AddChild(Divider());
        var scroll = new G.ScrollContainer
        {
            HorizontalScrollMode = G.ScrollContainer.ScrollMode.Disabled,
            SizeFlagsVertical = G.Control.SizeFlags.ExpandFill,
        };
        var options = new G.VBoxContainer { SizeFlagsHorizontal = G.Control.SizeFlags.ExpandFill };
        options.AddThemeConstantOverride("separation", 12);
        scroll.AddChild(options);
        box.AddChild(scroll);
        BuildOptions(options);
        box.AddChild(Divider());
        BuildChosenTray(box);
        BuildSummary(box);
        BuildButtons(box);

        ApplyGameFont(_layer);
        _session.Finished += _ => Close();
        _session.Changed += Render;
        _lastTicks = G.Time.GetTicksMsec();
        Tree.ProcessFrame += OnFrame;
        Tree.Root.CallDeferred(G.Node.MethodName.AddChild, _layer);
        Render();
        OnFrame();
    }

    public void Close()
    {
        Tree.ProcessFrame -= OnFrame;
        _layer?.QueueFree();
        _layer = null;
    }

    // ---------------------------------------------------------------- 各区块

    private void BuildHeader(G.VBoxContainer box)
    {
        var room = _session.Room;
        var (roomName, roomColor) = room.Room switch
        {
            RoomKind.Elite => ("精英房", new G.Color(0.85f, 0.45f, 0.30f)),
            RoomKind.Boss => ("Boss 房", new G.Color(0.80f, 0.30f, 0.35f)),
            _ => ("普通房", Teal),
        };

        var top = new G.HBoxContainer();
        top.AddThemeConstantOverride("separation", 16);
        var titles = new G.VBoxContainer();
        titles.AddThemeConstantOverride("separation", 2);
        titles.AddChild(Text("召唤阶段", 40, Gold));
        titles.AddChild(Text(room.Room switch
        {
            RoomKind.Monster => "挑选这场战斗的怪物（任何一幕的怪都可以）",
            RoomKind.Elite => "精英房是优惠房：所有怪打折，最多一只精英",
            _ => "选一个 Boss（免费），还可以另加怪物",
        }, 20, TextDim));
        top.AddChild(titles);
        top.AddChild(Spacer());

        if (!_session.Unlimited) // 默认不限时（用户要求去掉倒计时）；配置里设了秒数才显示
        {
            var timerBox = new G.VBoxContainer { CustomMinimumSize = new G.Vector2(170, 0) };
            timerBox.AddThemeConstantOverride("separation", 4);
            _timer = Text("", 40, TextMain);
            _timer.HorizontalAlignment = G.HorizontalAlignment.Right;
            timerBox.AddChild(_timer);
            _timerBar = Bar(_totalSeconds, _totalSeconds, Gold, 8);
            timerBox.AddChild(_timerBar);
            top.AddChild(timerBox);
        }
        box.AddChild(top);

        var chips = new G.HFlowContainer();
        chips.AddThemeConstantOverride("h_separation", 10);
        chips.AddThemeConstantOverride("v_separation", 8);
        chips.AddChild(Chip(roomName, roomColor, TextMain));
        chips.AddChild(Chip($"召唤点 {room.Savings}", new G.Color(0.20f, 0.17f, 0.09f), Gold, GoldDim));
        if (room.Room != RoomKind.Boss)
            chips.AddChild(Chip($"标准开销 {room.StandardCostOverride ?? 0}", CardBg, TextMain, CardBorder));
        if (room.Room == RoomKind.Elite)
            chips.AddChild(Chip("全场七折", new G.Color(0.30f, 0.14f, 0.10f), new G.Color(1f, 0.75f, 0.55f), new G.Color(0.6f, 0.35f, 0.25f)));
        if (_session.IsOpeningProtected)
            chips.AddChild(Chip("开局保护：只能用本幕普通怪，花费上限较低", new G.Color(0.12f, 0.24f, 0.18f), Good, new G.Color(0.25f, 0.45f, 0.30f)));
        box.AddChild(chips);
    }

    private void BuildOptions(G.VBoxContainer box)
    {
        var room = _session.Room.Room;
        if (room == RoomKind.Boss)
        {
            box.AddChild(Text("选择 Boss（免费）", 21, Gold));
            box.AddChild(OptionGrid(_session.EncounterOptions, 3, new G.Vector2(400, 150)));
            box.AddChild(Text("另加怪物（可选；有专用场景的 Boss 不能另加）", 21, Gold));
        }
        box.AddChild(OptionGrid(_session.MonsterOptions, 5, new G.Vector2(230, 150)));
    }

    /// <summary>一组卡片网格（外面整个选项区一起滚动）。</summary>
    private G.Control OptionGrid(IReadOnlyList<SummonOption> options, int columns, G.Vector2 portraitSize)
    {
        var grid = new G.GridContainer { Columns = columns, SizeFlagsHorizontal = G.Control.SizeFlags.ExpandFill };
        grid.AddThemeConstantOverride("h_separation", 12);
        grid.AddThemeConstantOverride("v_separation", 12);
        foreach (var option in options) grid.AddChild(OptionCard(option, portraitSize));
        return grid;
    }

    private G.Button OptionCard(SummonOption option, G.Vector2 portraitSize)
    {
        bool isEncounter = _session.EncounterOptions.Contains(option);
        var card = new G.Button
        {
            FocusMode = G.Control.FocusModeEnum.None,
            CustomMinimumSize = new G.Vector2(portraitSize.X + 24, portraitSize.Y + 104),
            SizeFlagsHorizontal = G.Control.SizeFlags.ExpandFill,
        };
        StyleCard(card, selected: false);

        var margin = new G.MarginContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore };
        margin.SetAnchorsPreset(G.Control.LayoutPreset.FullRect);
        foreach (var side in new[] { "margin_left", "margin_right", "margin_top", "margin_bottom" }) margin.AddThemeConstantOverride(side, 10);
        var column = new G.VBoxContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore };
        column.AddThemeConstantOverride("separation", 6);

        // 怪物形象：Boss 画本体
        var monsterId = isEncounter ? _session.LeadMonsterOf(option.Id) : option.Id;
        var portrait = monsterId == null ? null : Portrait(monsterId, portraitSize);
        if (portrait != null) column.AddChild(portrait);

        var row = new G.HBoxContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore };
        row.AddThemeConstantOverride("separation", 8);
        var name = Text(option.Name, 21, TextMain);
        name.SizeFlagsHorizontal = G.Control.SizeFlags.ExpandFill;
        name.VerticalAlignment = G.VerticalAlignment.Center;
        name.ClipText = true;
        name.MouseFilter = G.Control.MouseFilterEnum.Ignore;
        row.AddChild(name);
        var count = Text("", 20, Gold);
        count.VerticalAlignment = G.VerticalAlignment.Center;
        count.MouseFilter = G.Control.MouseFilterEnum.Ignore;
        row.AddChild(count);
        row.AddChild(Chip(isEncounter ? "免费" : $"{option.Price} 点", new G.Color(0.20f, 0.17f, 0.09f), Gold, GoldDim));
        column.AddChild(row);

        // Boss 卡片标出能不能另加怪
        if (isEncounter)
        {
            var tags = new G.HBoxContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore };
            tags.AddChild(_session.EncounterAllowsExtras(option.Id)
                ? Chip("可以另加怪", new G.Color(0.12f, 0.24f, 0.18f), Good)
                : Chip("专用场景 · 不能另加怪", new G.Color(0.30f, 0.12f, 0.12f), new G.Color(1f, 0.65f, 0.6f)));
            column.AddChild(tags);
        }
        // 标签：精英、跨幕（带「水土不服」血量）
        else
        {
            var tags = new G.HBoxContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore };
            tags.AddThemeConstantOverride("separation", 6);
            if (option.IsElite) tags.AddChild(Chip("精英", new G.Color(0.30f, 0.14f, 0.10f), new G.Color(1f, 0.75f, 0.55f)));
            if (option.HpFactor < 1) // 后面幕的怪：水土不服，血量打折
                tags.AddChild(Chip($"第{option.HomeAct}幕 · 生命{option.HpFactor * 100:0}%", new G.Color(0.10f, 0.18f, 0.28f), new G.Color(0.65f, 0.80f, 1f)));
            else if (option.HomeAct != _session.ActNo)
                tags.AddChild(Chip($"第{option.HomeAct}幕", CardBg, TextDim));
            column.AddChild(tags);
        }

        margin.AddChild(column);
        card.AddChild(margin);
        var id = option.Id;
        card.Pressed += () => _session.Click(id); // 选择变化时 Changed 事件会刷新面板
        _cards[id] = (card, count);
        return card;
    }

    /// <summary>
    /// 怪物形象：游戏没有现成的怪物头像图（图鉴也是现场摆出战斗模型），所以把战斗模型（MonsterModel.CreateVisuals）
    /// 放进一个小视口里画，按模型的 Bounds 缩放、居中。失败就返回 null，卡片只显示文字。
    /// </summary>
    private static G.Control? Portrait(string monsterId, G.Vector2 size)
    {
        try
        {
            var model = Test1bMixedEncounter.Model("Monster", monsterId);
            var create = model.GetType().GetMethod("CreateVisuals", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance, Type.EmptyTypes);
            if (create?.Invoke(model, null) is not G.Node2D visuals) return null;

            var viewport = new G.SubViewport
            {
                TransparentBg = true,
                Disable3D = true,
                Size = new G.Vector2I((int)size.X, (int)size.Y),
                RenderTargetUpdateMode = G.SubViewport.UpdateMode.Always,
            };
            viewport.AddChild(visuals);

            // 先按点击框（Bounds）缩得很小、放在正中画几帧（高个子、带特效的怪画出来常比点击框大很多），
            // 再读出实际画了像素的范围，按这个范围缩放、脚底贴底；见 FitAndFreeze
            if (GameReflection.Get(visuals, "Bounds") is G.Control bounds && bounds.Size.X > 1 && bounds.Size.Y > 1)
            {
                float scale = Math.Min(size.X * 0.30f / bounds.Size.X, size.Y * 0.30f / bounds.Size.Y);
                visuals.Scale = new G.Vector2(scale, scale);
                visuals.Position = size / 2 - (bounds.Position + bounds.Size / 2) * scale;
            }
            else
            {
                visuals.Scale = new G.Vector2(0.25f, 0.25f);
                visuals.Position = size / 2;
            }

            var container = new G.SubViewportContainer
            {
                Stretch = true,
                CustomMinimumSize = size,
                MouseFilter = G.Control.MouseFilterEnum.Ignore,
            };
            container.AddChild(viewport);
            FitAndFreeze(viewport, visuals, _portraits++);
            return container;
        }
        catch (Exception e)
        {
            Log.Warn($"召唤面板：画不出 {monsterId} 的形象，只显示名字：{e.InnerException?.Message ?? e.Message}");
            return null;
        }
    }

    private static int _portraits;

    /// <summary>
    /// 自动取景：画几帧后读视口图片里不透明像素的范围（Image.GetUsedRect），按它放大到视口 90%、水平居中、底部贴近下沿，
    /// 再画几帧后定格（视口不再重画、模型暂停处理），十几张卡片同时开着也几乎没有持续开销，代价是怪物不会动。
    /// 读到的范围碰到视口边（说明还是太大被裁了）就再缩小一半重来，最多 3 次。
    /// 每张卡片错开几帧，免得同一帧里几十次从显卡读图卡一下。
    /// </summary>
    private static void FitAndFreeze(G.SubViewport viewport, G.Node2D visuals, int order)
    {
        // 有的怪开场有入场动画（碎片飞入、从水里升起），太早量会量到碎片；等约 0.6 秒再量
        int wait = 36 + order % 12, tries = 0;
        bool fitted = false;
        void Tick()
        {
            if (!G.GodotObject.IsInstanceValid(viewport) || !G.GodotObject.IsInstanceValid(visuals)) { Tree.ProcessFrame -= Tick; return; }
            if (--wait > 0) return;
            if (fitted)
            {
                Tree.ProcessFrame -= Tick;
                viewport.RenderTargetUpdateMode = G.SubViewport.UpdateMode.Disabled;
                visuals.ProcessMode = G.Node.ProcessModeEnum.Disabled;
                return;
            }
            try
            {
                var size = new G.Vector2(viewport.Size.X, viewport.Size.Y);
                var used = OpaqueRect(viewport.GetTexture().GetImage());
                if (used.Size.X <= 0 || used.Size.Y <= 0) { fitted = true; wait = 1; return; } // 什么都没画出来，保持原样
                bool clipped = used.Position.X <= 0 || used.Position.Y <= 0 || used.End.X >= size.X || used.End.Y >= size.Y;
                if (clipped && ++tries < 3)
                {
                    Rescale(visuals, 0.5f, size / 2, size / 2); // 以视口中心缩小一半再量
                    wait = 3;
                    return;
                }
                var rect = new G.Rect2(used.Position, used.Size);
                float f = Math.Min(size.X * 0.90f / rect.Size.X, size.Y * 0.90f / rect.Size.Y);
                f = Math.Min(f, 6f); // 很小的怪也别放大到糊
                var center = rect.Position + rect.Size / 2;
                var target = new G.Vector2(size.X / 2, size.Y * 0.96f - rect.Size.Y * f / 2);
                Rescale(visuals, f, center, target);
            }
            catch (Exception e)
            {
                Log.Warn($"召唤面板：自动取景失败，保持原样：{e.Message}");
            }
            fitted = true;
            wait = 3;
        }
        Tree.ProcessFrame += Tick;
    }

    /// <summary>
    /// 不透明像素的范围，去掉两头各 1.5% 的零星像素（飘散的粒子、远处的小特效），免得一点火星把主体缩得很小。
    /// </summary>
    private static G.Rect2I OpaqueRect(G.Image image)
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
        int trim = (int)(total * 0.015);
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

    private void BuildChosenTray(G.VBoxContainer box)
    {
        var tray = new G.PanelContainer();
        tray.AddThemeStyleboxOverride("panel", Box(new G.Color(0.05f, 0.06f, 0.09f), CardBorder, 1, 10, 14));
        var inner = new G.VBoxContainer();
        inner.AddThemeConstantOverride("separation", 8);
        inner.AddChild(Text(_session.Room.Room == RoomKind.Boss ? "另加的怪（点击移除）" : "本场阵容（点击移除）", 19, TextDim));
        _chosen = new G.HFlowContainer { CustomMinimumSize = new G.Vector2(0, 44) };
        _chosen.AddThemeConstantOverride("h_separation", 10);
        _chosen.AddThemeConstantOverride("v_separation", 8);
        inner.AddChild(_chosen);
        _emptyHint = Text(_session.Room.Room == RoomKind.Boss ? "不另加怪物也可以" : "还没有选择怪物——点击上面的怪物加入", 20, TextDim);
        inner.AddChild(_emptyHint);
        tray.AddChild(inner);
        box.AddChild(tray);
    }

    private void BuildSummary(G.VBoxContainer box)
    {
        {
            var stats = new G.HBoxContainer();
            stats.AddThemeConstantOverride("separation", 12);
            foreach (var (key, label) in new[] { ("price", "召唤价"), ("tax", "群体税"), ("total", "合计 / 上限"), ("left", "确认后剩余") })
            {
                var cell = new G.PanelContainer { SizeFlagsHorizontal = G.Control.SizeFlags.ExpandFill };
                cell.AddThemeStyleboxOverride("panel", Box(CardBg, CardBorder, 1, 10, 12));
                var v = new G.VBoxContainer();
                v.AddThemeConstantOverride("separation", 0);
                v.AddChild(Text(label, 18, TextDim));
                var value = Text("0", 30, TextMain);
                v.AddChild(value);
                cell.AddChild(v);
                _stats[key] = value;
                stats.AddChild(cell);
            }
            box.AddChild(stats);
            _capBar = Bar(1, 0, Good, 10);
            box.AddChild(_capBar);
        }

    }

    private void BuildButtons(G.VBoxContainer box)
    {
        var buttons = new G.HBoxContainer();
        buttons.AddThemeConstantOverride("separation", 16);
        // 左边是规则提示，右边是按钮，省一行高度
        var notes = new G.VBoxContainer { SizeFlagsHorizontal = G.Control.SizeFlags.ExpandFill, Alignment = G.BoxContainer.AlignmentMode.Center };
        notes.AddThemeConstantOverride("separation", 2);
        _status = Text("", 21, Good);
        notes.AddChild(_status);
        _problems = new G.VBoxContainer();
        _problems.AddThemeConstantOverride("separation", 2);
        notes.AddChild(_problems);
        buttons.AddChild(notes);
        var vanilla = MakeButton("按原版出场", CardBg, CardHover, CardBorder, TextMain, new G.Vector2(220, 60));
        vanilla.Pressed += () => _session.UseVanilla();
        _confirm = MakeButton("确认召唤", Teal, TealHover, Gold, TextMain, new G.Vector2(280, 60), 26);
        _confirm.Pressed += () => _session.Confirm();
        buttons.AddChild(vanilla);
        buttons.AddChild(_confirm);
        box.AddChild(buttons);
    }

    // ---------------------------------------------------------------- 刷新

    private void OnFrame()
    {
        var now = G.Time.GetTicksMsec();
        _session.Tick((now - _lastTicks) / 1000.0);
        _lastTicks = now;
        if (_session.Done || _timer == null || _timerBar == null) return;
        var left = _session.SecondsLeft;
        _timer.Text = $"{Math.Ceiling(left)}";
        _timerBar.Value = left;
        var urgent = left <= 10;
        _timer.AddThemeColorOverride("font_color", urgent ? Bad : TextMain);
        _timerBar.AddThemeStyleboxOverride("fill", Box(urgent ? Bad : Gold, urgent ? Bad : Gold, 0, 4, 0));
    }

    private void Render()
    {
        if (_session.Done) return;
        var room = _session.Room.Room;
        var quote = _session.Quote;

        foreach (var (id, (card, count)) in _cards)
        {
            bool isEncounter = _session.EncounterOptions.Any(o => o.Id == id);
            int n = isEncounter ? (_session.Encounter == id ? 1 : 0) : _session.Monsters.Count(m => m == id);
            count.Text = !isEncounter && n > 0 ? $"×{n}" : "";
            StyleCard(card, n > 0);
            if (!isEncounter) // 选了不能另加怪的 Boss：怪物卡片变灰、点不了
            {
                card.Disabled = !_session.BossAllowsExtras;
                card.Modulate = new G.Color(1, 1, 1, _session.BossAllowsExtras ? 1f : 0.35f);
            }
        }

        if (_chosen != null && _emptyHint != null)
        {
            foreach (var child in _chosen.GetChildren()) child.QueueFree();
            for (int i = 0; i < _session.Monsters.Count; i++)
            {
                int index = i;
                var b = MakeButton($"{_session.NameOf(_session.Monsters[i])}  ✕", new G.Color(0.20f, 0.17f, 0.09f), new G.Color(0.30f, 0.24f, 0.12f), GoldDim, Gold, new G.Vector2(0, 42), 20);
                b.Pressed += () => _session.RemoveAt(index);
                ApplyGameFont(b);
                _chosen.AddChild(b);
            }
            _emptyHint.Visible = _session.Monsters.Count == 0;
            if (room == RoomKind.Boss)
                _emptyHint.Text = _session.BossAllowsExtras ? "不另加怪物也可以" : "这个 Boss 有专用场景，不能另加怪物";
        }

        {
            int left = _session.Room.Savings - quote.Total;
            _stats["price"].Text = $"{quote.MonsterPrice}";
            _stats["tax"].Text = $"{quote.CrowdTax}";
            _stats["total"].Text = $"{quote.MonsterSpend} / {quote.SpendCap:0.#}";
            _stats["left"].Text = $"{left}";
            bool overCap = quote.MonsterSpend > quote.SpendCap + 1e-9;
            _stats["total"].AddThemeColorOverride("font_color", overCap ? Bad : TextMain);
            _stats["left"].AddThemeColorOverride("font_color", left < 0 ? Bad : Gold);
            _capBar.MaxValue = Math.Max(1, quote.SpendCap);
            _capBar.Value = Math.Min(quote.MonsterSpend, _capBar.MaxValue);
            _capBar.AddThemeStyleboxOverride("fill", Box(overCap ? Bad : Good, overCap ? Bad : Good, 0, 5, 0));
        }

        foreach (var child in _problems.GetChildren()) child.QueueFree();
        bool emptyOnly = quote.Violations.Count == 1 && quote.Violations[0] == SummonViolation.EmptyRoom;
        if (_session.ExtraProblems.Count > 0 || !quote.Ok && !emptyOnly)
        {
            _status.Text = "";
            foreach (var problem in _session.ExtraProblems.Concat(quote.Violations.Select(SummonSession.Describe)))
            {
                var line = Text("✗ " + problem, 20, Bad);
                ApplyGameFont(line);
                _problems.AddChild(line);
            }
        }
        else if (quote.Ok)
        {
            _status.Text = room == RoomKind.Boss ? "✓ 可以召唤（Boss 免费，另加的怪照价）" : "✓ 符合规则，可以召唤";
            _status.AddThemeColorOverride("font_color", Good);
        }
        else if (emptyOnly)
        {
            _status.Text = "至少召唤一只怪物";
            _status.AddThemeColorOverride("font_color", TextDim);
        }
        _confirm.Disabled = !_session.CanConfirm;
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
    public static void ShowToast(string text, double seconds = 6)
    {
        var layer = new G.CanvasLayer { Layer = 101 };
        var holder = new G.CenterContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore };
        holder.SetAnchorsPreset(G.Control.LayoutPreset.TopWide);
        holder.Position = new G.Vector2(0, 90);
        var panel = new G.PanelContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore };
        panel.AddThemeStyleboxOverride("panel", Box(PanelBg, Gold, 2, 12, 16, shadow: 12));
        var label = Text(text, 24, Gold);
        label.MouseFilter = G.Control.MouseFilterEnum.Ignore;
        panel.AddChild(label);
        holder.AddChild(panel);
        layer.AddChild(holder);
        ApplyGameFont(layer);
        Tree.Root.CallDeferred(G.Node.MethodName.AddChild, layer);
        Tree.CreateTimer(seconds).Timeout += () => layer.QueueFree();
    }
}
