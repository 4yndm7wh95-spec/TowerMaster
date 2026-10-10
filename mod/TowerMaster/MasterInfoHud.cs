using G = Godot;

namespace TowerMaster;

/// <summary>
/// 玩家看到的塔主信息（设计文档「信息规则」：塔主手里的陷阱数、本场盖下几张、已触发的陷阱、本幕两个候选 Boss）。
/// 一条小信息条挂在原版顶栏下方右侧（作为顶栏的子节点，跟着原版界面的层级走，不盖地图、牌组这些原版界面）。
/// 数据都来自各端本来就会执行的指令：deck（牌组里的陷阱牌）、trap_info（本场盖下几张）、trap（触发）；候选 Boss 各端自己算。
/// </summary>
internal static class MasterInfoHud
{
    // ---------------------------------------------------------------- 数据（不碰 Godot，测试里也能调）

    /// <summary>塔主手里的陷阱张数：deck 指令里 trap: 开头的牌数；没收到过 deck 时用 trap_info 带的数；都没有是 -1。</summary>
    internal static int TrapsInHand { get; private set; } = -1;
    private static WeakReference<object>? _fight;
    private static int _placed;
    private static readonly List<string> Triggered = new();

    /// <summary>塔主身边的陷阱托盘用：手里张数（看不到为 -1）、本场盖下张数（看不到为 -1）、已触发的名字。</summary>
    internal static (int Hand, int Placed, IReadOnlyList<string> Fired, bool InFight) TrayState()
    {
        bool fog = !Test3MasterAutoPilot.LocalIsMaster && MasterRelics.Has("fog_censer");
        bool inFight = EnsureFight();
        return (fog ? -1 : TrapsInHand, fog ? -1 : _placed, Triggered, inFight);
    }

    /// <summary>战斗里塔主身边有托盘时，信息条不再重复显示「本场」。</summary>
    internal static bool TrayShown { get; set; }

    internal static void ResetRun()
    {
        TrapsInHand = -1;
        _fight = null;
        _placed = 0;
        Triggered.Clear();
    }

    internal static void OnDeck(IEnumerable<string> keys) => TrapsInHand = keys.Count(k => k.StartsWith("trap:", StringComparison.Ordinal));

    internal static void OnTrapInfo(int placed, int handLeft)
    {
        EnsureFight();
        _placed = placed;
        if (handLeft >= 0) TrapsInHand = handLeft;
    }

    internal static void OnTrapTriggered(string name)
    {
        EnsureFight();
        Triggered.Add(name);
    }

    /// <summary>换了一场战斗就清掉上一场的盖下/触发记录（按战斗状态对象区分）。</summary>
    private static bool EnsureFight()
    {
        var combat = SafeCombat();
        if (combat == null) return false;
        if (_fight != null && _fight.TryGetTarget(out var old) && ReferenceEquals(old, combat)) return true;
        _fight = new WeakReference<object>(combat);
        _placed = 0;
        Triggered.Clear();
        return true;
    }

    private static object? SafeCombat()
    {
        try
        {
            var combat = ThreatPhase.CombatState();
            return combat != null && GameReflection.Get(combat, "RoundNumber") is { } r && Convert.ToInt32(r) > 0 ? combat : null;
        }
        catch { return null; }
    }

    /// <summary>信息条显示的内容。Placed = -1 表示看不到（迷雾香炉）。</summary>
    internal sealed record HudView(string Hand, int Placed, int Fired, bool InFight, string Bosses, string Tip);

    /// <summary>
    /// 信息条内容（0.0.47 重做，用户反馈「字多、难懂、不好看」）：只放图标和数字，说明全在悬停提示里用大白话写。
    /// </summary>
    internal static HudView Describe(IReadOnlyList<string> bosses)
    {
        bool fog = !Test3MasterAutoPilot.LocalIsMaster && MasterRelics.Has("fog_censer"); // 塔主遗物「迷雾香炉」：玩家看不到张数
        var hand = TrapsInHand >= 0 && !fog ? $"{TrapsInHand}" : "?";
        bool inFight = EnsureFight();
        var relics = MasterRelics.Owned().Select(id => MasterRelics.Find(id)?.Title).OfType<string>().ToList();
        var tip = new List<string> { $"塔主手里有 {hand} 张陷阱牌（是什么保密）。" };
        if (inFight)
        {
            tip.Add(fog ? "迷雾香炉在冒烟，看不清这场盖了几张。" : $"这场盖下了 {_placed} 张，已经触发 {Triggered.Count} 张（红色的）。");
            if (!fog) tip.Add("※盖下的里面可能有空陷阱，只是吓唬人。");
        }
        if (Triggered.Count > 0) tip.Add($"触发过：{string.Join("、", Triggered)}");
        if (bosses.Count > 0) tip.Add($"这一幕的 Boss 会是 {string.Join(" 或 ", bosses)}，塔主到 Boss 房时挑一个。");
        if (relics.Count > 0) tip.Add($"塔主的遗物：{string.Join("、", relics)}");
        return new HudView(hand, fog ? -1 : _placed, Triggered.Count, inFight, string.Join(" / ", bosses), string.Join("\n", tip));
    }

    // ---------------------------------------------------------------- 界面

    private static G.Control? _bar;
    private static G.PanelContainer? _panel;
    private static G.Label? _hand, _bossLine;
    private static G.HBoxContainer? _fightRow, _pips;
    private static G.Control? _bossRow;
    private static string _pipKey = "";
    private static string _lastTip = "";
    private static int _frames;
    private static string _bossKey = "";
    private static IReadOnlyList<string> _bosses = [];

    internal static void Start()
    {
        try { G.Callable.From(() => SummonPanel.Tree.ProcessFrame += Tick).CallDeferred(); }
        catch (Exception e) { Log.Warn($"塔主信息条：启动失败（不影响游戏）：{e.Message}"); }
    }

    private static void Tick()
    {
        if (++_frames % 20 != 0) return;
        try
        {
            var state = GameReflection.Get(Test1bMixedEncounter.Run, "State");
            if (state == null || Test2MasterOffField.MasterId == null) { Hide(); return; }
            if (_bar == null || !G.GodotObject.IsInstanceValid(_bar) || !_bar.IsInsideTree())
            {
                _bar = Find(SummonPanel.Tree.Root, "NTopBar") as G.Control;
                if (_bar == null) { Hide(); return; }
            }
            if (_panel == null || !G.GodotObject.IsInstanceValid(_panel) || _panel.GetParent() != _bar) Build(_bar);

            // 候选 Boss 每幕才变：按种子+幕缓存
            var key = $"{GameReflection.Get(state, "Act")?.GetType().Name}|{System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(state)}";
            if (key != _bossKey) { _bossKey = key; _bosses = SummonPhase.PublicBossNames(); }

            var view = Describe(_bosses);
            _hand!.Text = view.Hand;
            _fightRow!.Visible = view.InFight && !TrayShown;
            var pipKey = $"{view.Placed}/{view.Fired}";
            if (pipKey != _pipKey) { _pipKey = pipKey; Pips(view.Placed, view.Fired); }
            _bossLine!.Text = view.Bosses;
            _bossRow!.Visible = view.Bosses.Length > 0;
            var tip = view.Tip;
            if (tip != _lastTip) { _lastTip = tip; Ui.Tip(_panel!, "塔主的情报\n" + tip); }
            _panel!.Visible = _bar.IsVisibleInTree();
            _panel.ResetSize();
            // NTopBar 节点是整屏大小（0.0.43 实测按它的高度摆到了屏幕外），按顶栏带子里按钮的实际下沿摆
            _panel.Position = new G.Vector2(_bar.Size.X - _panel.Size.X - 18, BandBottom(_bar) + 6);
        }
        catch (Exception e)
        {
            if (_frames % 600 == 0) Log.Warn($"塔主信息条：刷新失败：{e.Message}");
        }
    }

    /// <summary>顶栏带子的下沿（相对 NTopBar）：直接子节点里高度不到 200 的可见控件的最低处；量不出来按 84。</summary>
    private static float BandBottom(G.Control bar)
    {
        float bottom = 0;
        foreach (var child in bar.GetChildren())
        {
            if (child is not G.Control c || c == _panel || !c.Visible || c.Size.Y <= 1 || c.Size.Y >= 200) continue;
            bottom = Math.Max(bottom, c.Position.Y + c.Size.Y * c.Scale.Y);
        }
        return bottom is > 20 and < 240 ? bottom : 84;
    }

    private static void Hide()
    {
        if (_panel != null && G.GodotObject.IsInstanceValid(_panel)) _panel.Visible = false;
    }

    /// <summary>
    /// 样子：一块半透明深色小牌子，右上角对齐。
    /// 第一行：陷阱牌背图标 + 手里张数（大号金字）；战斗中右边再跟「本场」和一排小方块，每块是一张盖下的陷阱，触发了就变红。
    /// 第二行：小字「Boss」+ 本幕两个候选的名字。
    /// </summary>
    private static void Build(G.Control bar)
    {
        if (_panel != null && G.GodotObject.IsInstanceValid(_panel)) _panel.QueueFree();
        _pipKey = "";
        _lastTip = "";
        _panel = new G.PanelContainer { MouseFilter = G.Control.MouseFilterEnum.Pass, ZIndex = 1 };
        var sb = SummonPanel.Box(new G.Color(0.05f, 0.06f, 0.09f, 0.78f), new G.Color(0.55f, 0.45f, 0.26f, 0.6f), 1, 12, 0);
        sb.ContentMarginLeft = 10; sb.ContentMarginRight = 14; sb.ContentMarginTop = 4; sb.ContentMarginBottom = 6;
        _panel.AddThemeStyleboxOverride("panel", sb);
        var box = new G.VBoxContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore };
        box.AddThemeConstantOverride("separation", 0);

        var top = new G.HBoxContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore, Alignment = G.BoxContainer.AlignmentMode.End };
        top.AddThemeConstantOverride("separation", 6);
        if (Art.Icon("icon_trap", 30) is { } icon) top.AddChild(icon);
        _hand = Ui.Value("?", 24, SummonPanel.Gold);
        top.AddChild(_hand);
        _fightRow = new G.HBoxContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore };
        _fightRow.AddThemeConstantOverride("separation", 6);
        _fightRow.AddChild(new G.Control { CustomMinimumSize = new G.Vector2(6, 0), MouseFilter = G.Control.MouseFilterEnum.Ignore });
        var fightLabel = Ui.Label("本场", 13);
        fightLabel.SizeFlagsVertical = G.Control.SizeFlags.ShrinkCenter;
        _fightRow.AddChild(fightLabel);
        _pips = new G.HBoxContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore, Alignment = G.BoxContainer.AlignmentMode.Center };
        _pips.AddThemeConstantOverride("separation", 4);
        _fightRow.AddChild(_pips);
        top.AddChild(_fightRow);
        box.AddChild(top);

        var bossRow = new G.HBoxContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore, Alignment = G.BoxContainer.AlignmentMode.End };
        bossRow.AddThemeConstantOverride("separation", 6);
        var bossLabel = Ui.Label("Boss", 13);
        bossLabel.SizeFlagsVertical = G.Control.SizeFlags.ShrinkCenter;
        bossRow.AddChild(bossLabel);
        _bossLine = Ui.Body("", 15);
        bossRow.AddChild(_bossLine);
        _bossRow = bossRow;
        box.AddChild(bossRow);

        foreach (var n in box.FindChildren("*", "Label", true, false)) if (n is G.Control c) c.MouseFilter = G.Control.MouseFilterEnum.Ignore;
        _panel.AddChild(box);
        SummonPanel.ApplyGameFont(_panel);
        bar.AddChild(_panel);
        Log.Info("塔主信息条：挂到原版顶栏下方");
    }

    /// <summary>本场盖下的陷阱：每张一个小牌背方块，触发的变红；看不到（迷雾香炉）就是一个问号。</summary>
    private static void Pips(int placed, int fired)
    {
        foreach (var child in _pips!.GetChildren()) child.QueueFree();
        if (placed < 0) { _pips.AddChild(Ui.Value("?", 18)); return; }
        if (placed == 0) { _pips.AddChild(Ui.Value("没盖", 16)); return; } // 状态值：比左边的标签「本场」大、亮
        for (int i = 0; i < placed; i++)
        {
            bool hit = i < fired;
            var pip = new G.Panel { CustomMinimumSize = new G.Vector2(13, 18), MouseFilter = G.Control.MouseFilterEnum.Ignore };
            pip.AddThemeStyleboxOverride("panel", SummonPanel.Box(hit ? new G.Color(0.78f, 0.28f, 0.30f) : new G.Color(0.10f, 0.12f, 0.18f),
                hit ? new G.Color(1f, 0.55f, 0.5f) : SummonPanel.Gold, 1, 3, 0));
            _pips.AddChild(pip);
        }
    }

    private static G.Node? Find(G.Node root, string typeName)
    {
        var stack = new Stack<G.Node>();
        stack.Push(root);
        while (stack.Count > 0)
        {
            var node = stack.Pop();
            if (node.GetType().Name == typeName) return node;
            foreach (var child in node.GetChildren()) stack.Push(child);
        }
        return null;
    }
}
