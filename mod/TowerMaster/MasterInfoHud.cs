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

    /// <summary>信息条的两行文字和悬停说明。</summary>
    internal static (string Line1, string Line2, string Tip) Describe(IReadOnlyList<string> bosses)
    {
        var hand = TrapsInHand >= 0 ? $"{TrapsInHand}" : "?";
        bool inFight = EnsureFight();
        var line1 = inFight ? $"塔主陷阱  手里 {hand} · 本场盖下 {_placed} · 已触发 {Triggered.Count}" : $"塔主陷阱  手里 {hand}";
        var line2 = bosses.Count > 0 ? $"本幕 Boss：{string.Join(" / ", bosses)}" : "";
        var tip = "塔主手里的陷阱牌张数公开，内容保密。\n每场战斗开始时公开塔主盖下几张（可能有空陷阱诈唬），触发时所有人都会看到。"
                  + (Triggered.Count > 0 ? $"\n本场已触发：{string.Join("、", Triggered)}" : "")
                  + (bosses.Count > 0 ? "\n本幕的 Boss 会是这几个之一，塔主进 Boss 房时挑一个。" : "");
        return (line1, line2, tip);
    }

    // ---------------------------------------------------------------- 界面

    private static G.Control? _bar;
    private static G.PanelContainer? _panel;
    private static G.Label? _line1, _line2;
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

            var (line1, line2, tip) = Describe(_bosses);
            _line1!.Text = line1;
            _line2!.Text = line2;
            _line2.Visible = line2.Length > 0;
            _panel!.TooltipText = tip;
            _panel.Visible = _bar.IsVisibleInTree();
            _panel.ResetSize();
            _panel.Position = new G.Vector2(_bar.Size.X - _panel.Size.X - 18, _bar.Size.Y + 6);
        }
        catch (Exception e)
        {
            if (_frames % 600 == 0) Log.Warn($"塔主信息条：刷新失败：{e.Message}");
        }
    }

    private static void Hide()
    {
        if (_panel != null && G.GodotObject.IsInstanceValid(_panel)) _panel.Visible = false;
    }

    private static void Build(G.Control bar)
    {
        if (_panel != null && G.GodotObject.IsInstanceValid(_panel)) _panel.QueueFree();
        _panel = new G.PanelContainer { MouseFilter = G.Control.MouseFilterEnum.Pass, ZIndex = 1 };
        var sb = SummonPanel.Box(new G.Color(0.075f, 0.09f, 0.13f, 0.86f), SummonPanel.GoldDim, 1, 10, 0);
        sb.ContentMarginLeft = sb.ContentMarginRight = 12;
        sb.ContentMarginTop = sb.ContentMarginBottom = 5;
        _panel.AddThemeStyleboxOverride("panel", sb);
        var box = new G.VBoxContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore };
        box.AddThemeConstantOverride("separation", 2);
        _line1 = SummonPanel.Text("", 17, SummonPanel.Gold);
        _line2 = SummonPanel.Text("", 15, SummonPanel.TextDim);
        foreach (var l in new[] { _line1, _line2 }) { l.MouseFilter = G.Control.MouseFilterEnum.Ignore; l.HorizontalAlignment = G.HorizontalAlignment.Right; box.AddChild(l); }
        _panel.AddChild(box);
        SummonPanel.ApplyGameFont(_panel);
        bar.AddChild(_panel);
        Log.Info("塔主信息条：挂到原版顶栏下方");
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
