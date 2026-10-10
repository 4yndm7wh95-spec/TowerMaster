using HarmonyLib;
using TowerMaster.Core;
using G = Godot;

namespace TowerMaster;

/// <summary>
/// 一局结束（原版结算画面 NGameOverScreen 出现）时，在上面先弹一张「塔主战报」：谁赢了、塔主召唤/陷阱/出牌统计、一个搞笑称号。
/// 点「看原版结算」关掉，下面就是原版画面。各端都弹（数据各端一样，见 <see cref="MasterStats"/>）。
/// </summary>
internal static class RunReportPanel
{
    private static G.CanvasLayer? _layer;

    internal static void Apply(Harmony harmony)
    {
        var target = GameReflection.FindMethod("_Ready", "NGameOverScreen");
        if (target == null) { Log.Warn("塔主战报：找不到 NGameOverScreen._Ready，不弹战报"); return; }
        try
        {
            harmony.Patch(target, postfix: new HarmonyMethod(typeof(RunReportPanel).GetMethod(nameof(AfterGameOver), GameReflection.All)!));
            Log.Info("塔主战报：已挂到原版结算画面");
        }
        catch (Exception e) { Log.Error("塔主战报：挂结算画面失败", e); }
    }

    private static void AfterGameOver(object __instance)
    {
        try
        {
            if (__instance is G.Node screen) MasterPresence.WatchGameOver(screen);
            if (Test2MasterOffField.MasterId == null) return;
            if (GameReflection.Get(Test1bMixedEncounter.Run, "State") is not { } state) { Log.Warn("塔主战报：结算时没有对局状态，不弹"); return; }
            var input = MasterStats.Collect(state);
            // 等原版结算动画先出来一点再盖上去；这期间回了菜单/开了新局就不弹（0.0.47 实测旧战报挂到新局）
            int generation = ++_generation;
            SummonPanel.Tree.CreateTimer(1.2).Timeout += () => { if (generation == _generation) Show(RunReport.Build(input)); };
            Log.Info($"塔主战报：{(input.MasterWon ? "塔主赢" : "爬塔者赢")}，{input.Fights} 场，召唤 {input.Summoned.Count}，陷阱 {input.Traps.Count}，出牌 {input.Cards.Count}");
        }
        catch (Exception e) { Log.Error("塔主战报：生成失败（原版结算不受影响）", e); }
    }

    private static int _generation;

    /// <summary>换局/回菜单：关掉战报，作废还没弹出的那次。</summary>
    internal static void ResetRun()
    {
        _generation++;
        Close();
    }

    internal static void Close()
    {
        if (_layer != null && G.GodotObject.IsInstanceValid(_layer)) _layer.QueueFree();
        _layer = null;
    }

    internal static void Show(RunReportView view)
    {
        Close();
        var layer = new G.CanvasLayer { Layer = 110 };
        _layer = layer;
        var backdrop = new G.ColorRect { Color = SummonPanel.Backdrop, MouseFilter = G.Control.MouseFilterEnum.Stop };
        backdrop.SetAnchorsPreset(G.Control.LayoutPreset.FullRect);
        layer.AddChild(backdrop);

        var center = new G.CenterContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore };
        center.SetAnchorsPreset(G.Control.LayoutPreset.FullRect);
        layer.AddChild(center);
        var won = view.Title.StartsWith("塔主", StringComparison.Ordinal);
        var accent = won ? SummonPanel.Gold : SummonPanel.Teal;
        var panel = new G.PanelContainer { CustomMinimumSize = new G.Vector2(620, 0) };
        panel.AddThemeStyleboxOverride("panel", SummonPanel.Box(SummonPanel.PanelBg, accent, 2, 16, 28, shadow: 24));
        center.AddChild(panel);

        var box = new G.VBoxContainer();
        box.AddThemeConstantOverride("separation", 12);
        panel.AddChild(box);
        var title = SummonPanel.Text(view.Title, 44, won ? SummonPanel.Gold : SummonPanel.TextMain);
        title.HorizontalAlignment = G.HorizontalAlignment.Center;
        box.AddChild(title);
        var sub = SummonPanel.Text(view.Subtitle, 17, Ui.NoteColor);
        sub.HorizontalAlignment = G.HorizontalAlignment.Center;
        box.AddChild(sub);

        // 称号
        var honor = new G.PanelContainer();
        honor.AddThemeStyleboxOverride("panel", SummonPanel.Box(new G.Color(0.24f, 0.19f, 0.10f), SummonPanel.Gold, 1, 12, 12));
        var honorBox = new G.VBoxContainer();
        var honorName = SummonPanel.Text($"称号：{view.Honor}", 30, SummonPanel.Gold);
        honorName.HorizontalAlignment = G.HorizontalAlignment.Center;
        var honorWhy = SummonPanel.Text(view.HonorReason, 16, Ui.NoteColor);
        honorWhy.HorizontalAlignment = G.HorizontalAlignment.Center;
        honorBox.AddChild(honorName);
        honorBox.AddChild(honorWhy);
        honor.AddChild(honorBox);
        box.AddChild(honor);

        var grid = new G.GridContainer { Columns = 2 };
        grid.AddThemeConstantOverride("h_separation", 24);
        grid.AddThemeConstantOverride("v_separation", 8);
        foreach (var (label, value) in view.Lines)
        {
            var l = Ui.Label(label, 16);
            l.SizeFlagsVertical = G.Control.SizeFlags.ShrinkCenter;
            grid.AddChild(l);
            var v = Ui.Body(value, 19);
            v.AutowrapMode = G.TextServer.AutowrapMode.WordSmart;
            v.CustomMinimumSize = new G.Vector2(420, 0);
            grid.AddChild(v);
        }
        box.AddChild(grid);

        var button = SummonPanel.MakeButton("看原版结算", SummonPanel.Teal, SummonPanel.TealHover, SummonPanel.Teal, SummonPanel.TextMain, new G.Vector2(240, 52), 20);
        button.SizeFlagsHorizontal = G.Control.SizeFlags.ShrinkCenter;
        button.Pressed += Close;
        box.AddChild(button);

        SummonPanel.ApplyGameFont(layer);
        SummonPanel.AddDeferred(layer);
    }
}
