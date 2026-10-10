using G = Godot;

namespace TowerMaster;

/// <summary>
/// 塔主出牌、埋陷阱的特效。纯显示，各端各播各的。
/// 0.0.57 起默认游戏内实时渲染（<see cref="MasterFx"/>）；设置 vfx_style="sheet" 退回旧的 8 帧序列图（art/vfx_*.png，16 帧/秒，图不存在就不播）。
/// - vfx_ward：格挡类（加固、坚壁、荆棘、金身、怪物便当、伏兵），罩在怪物脚下往上长；
/// - vfx_mark：易伤类（易伤、全体易伤、起哄、黑名单），印在玩家身上；
/// - vfx_bury：埋陷阱，所有陷阱（含空陷阱）一个样，插在怪物一侧的地面上，盖几张插几次。
/// </summary>
internal static class MasterVfx
{
    /// <summary>true = 游戏内渲染（默认）；false = 旧序列图。</summary>
    internal static bool Rendered { get; set; } = true;

    private const int Frames = 8;
    private const double Fps = 16;

    /// <summary>塔主牌打出后（各端）：按牌的种类在目标身上播特效。target 为空表示群体牌。</summary>
    internal static void AfterCard(string op, object? target)
    {
        try
        {
            switch (op)
            {
                case "block" or "thorns" or "artifact" when target != null: PlayOn(target, "vfx_ward", ground: true); break;
                case "fortify_all": foreach (var e in MasterHand.LivingEnemies()) PlayOn(e, "vfx_ward", ground: true); break;
                case "vulnerable" or "heckle" when target != null: PlayOn(target, "vfx_mark", ground: false); break;
                case "expose_all": foreach (var p in MasterHand.LivingClimbers()) PlayOn(p, "vfx_mark", ground: false); break;
                // 下一批特效（图还没有时 Play 什么都不做）
                case "strength" when target != null: PlayOn(target, "vfx_empower", ground: true); break;
                case "strength_all" or "feast": foreach (var e in MasterHand.LivingEnemies()) PlayOn(e, "vfx_empower", ground: true); break;
                case "heal" when target != null: PlayOn(target, "vfx_mend", ground: true); break;
                case "heal_all": foreach (var e in MasterHand.LivingEnemies()) PlayOn(e, "vfx_mend", ground: true); break;
                case "weak" or "sap" when target != null: PlayOn(target, "vfx_drain", ground: false); break;
                case "frail" when target != null: PlayOn(target, "vfx_frail", ground: false); break;
                case "dazed" or "slime_gift" when target != null: PlayOn(target, "vfx_daze", ground: false); break;
                case "daze_all": foreach (var p in MasterHand.LivingClimbers()) PlayOn(p, "vfx_daze", ground: false); break;
                case "call_help": if (MasterHand.LivingEnemies().LastOrDefault() is { } fresh) PlayOn(fresh, "vfx_summon", ground: true); break;
            }
        }
        catch (Exception e) { Log.Warn($"塔主特效：播放失败：{e.Message}"); }
    }

    /// <summary>预览用：在 feet（脚下）播一个特效，sheet=true 用旧序列图。</summary>
    internal static void Preview(string kind, G.Vector2 feet, float size, bool sheet)
    {
        if (!sheet) { MasterFx.Play(kind, feet, size); return; }
        bool ground = kind is "ward" or "bury" or "empower" or "mend" or "summon";
        if (ground) Play($"vfx_{kind}", feet, size * 1.25f, groundY: kind == "bury" ? 200 : 220);
        else Play($"vfx_{kind}", feet - new G.Vector2(0, size * 0.45f), size * 0.9f, groundY: null);
    }

    internal static void WardAllEnemies() { try { foreach (var e in MasterHand.LivingEnemies()) PlayOn(e, "vfx_ward", ground: true); } catch { /* 纯显示 */ } }
    internal static void MarkOn(object creature) { try { PlayOn(creature, "vfx_mark", ground: false); } catch { /* 纯显示 */ } }

    /// <summary>埋陷阱：在怪物一侧地面上插 count 张（间隔 0.2 秒）。</summary>
    internal static void Bury(int count)
    {
        try
        {
            if (count <= 0 || !Rendered && Art.Get("vfx_bury") == null) return;
            var rects = MasterHand.LivingEnemies().Select(Rect).OfType<G.Rect2>().ToList();
            if (rects.Count == 0) return;
            float left = rects.Min(r => r.Position.X), right = rects.Max(r => r.End.X), ground = rects.Max(r => r.End.Y);
            var rng = new Random();
            for (int i = 0; i < count; i++)
            {
                float x = left + (right - left) * (count == 1 ? 0.5f : (i + 0.5f) / count) + rng.Next(-30, 31);
                float size = Math.Clamp((right - left) / Math.Max(2, count) * 0.9f, 140, 220);
                var at = new G.Vector2(x, ground + size * 0.05f);
                SummonPanel.Tree.CreateTimer(0.2 * i + 0.01).Timeout += () =>
                {
                    if (Rendered) MasterFx.Play("bury", at, size * 1.3f);
                    else Play("vfx_bury", at, size, groundY: 200);
                };
            }
        }
        catch (Exception e) { Log.Warn($"塔主特效：埋陷阱特效失败：{e.Message}"); }
    }

    private static void PlayOn(object creature, string sheet, bool ground)
    {
        if (Rect(creature) is not { } r) return;
        if (Rendered)
        {
            MasterFx.Play(sheet["vfx_".Length..], new G.Vector2(r.Position.X + r.Size.X / 2, r.End.Y), Math.Clamp(r.Size.Y, 140, 420));
            return;
        }
        float size = Math.Clamp(Math.Max(r.Size.X, r.Size.Y) * (ground ? 1.25f : 0.9f), 120, 420);
        if (ground) Play(sheet, new G.Vector2(r.Position.X + r.Size.X / 2, r.End.Y), size, groundY: 220);
        else Play(sheet, r.Position + r.Size / 2, size, groundY: null);
    }

    /// <summary>生物在屏幕上的矩形（点击框）。</summary>
    private static G.Rect2? Rect(object creature)
    {
        var room = RuntimeNetAction.Required("NCombatRoom").GetProperty("Instance", GameReflection.All)?.GetValue(null);
        if (room == null) return null;
        var node = room.GetType().GetMethods(GameReflection.All).FirstOrDefault(m => m.Name == "GetCreatureNode" && m.GetParameters().Length == 1)?.Invoke(room, [creature]);
        if (node == null) return null;
        var box = GameReflection.Get(node, "Hitbox") as G.Control ?? node as G.Control;
        if (box == null) return null;
        var t = box.GetGlobalTransformWithCanvas();
        return new G.Rect2(t.Origin, box.Size * t.Scale);
    }

    /// <summary>
    /// 在屏幕坐标 at 播一条序列：groundY 给了就是「这帧里地面线的 y」，让地面线对齐 at；没给就是帧中心对齐 at。
    /// </summary>
    private static void Play(string sheet, G.Vector2 at, float size, int? groundY)
    {
        if (Art.Get(sheet) is not { } texture) return;
        float frameW = texture.GetWidth() / (float)Frames, frameH = texture.GetHeight();
        float scale = size / frameW;
        var layer = new G.CanvasLayer { Layer = 1 };
        var rect = new G.TextureRect
        {
            MouseFilter = G.Control.MouseFilterEnum.Ignore,
            ExpandMode = G.TextureRect.ExpandModeEnum.IgnoreSize,
            StretchMode = G.TextureRect.StretchModeEnum.Scale,
            Size = new G.Vector2(frameW, frameH) * scale,
        };
        float anchorY = groundY.HasValue ? groundY.Value * scale : frameH * scale / 2;
        rect.Position = new G.Vector2(at.X - frameW * scale / 2, at.Y - anchorY);
        var atlas = new G.AtlasTexture { Atlas = texture, Region = new G.Rect2(0, 0, frameW, frameH) };
        rect.Texture = atlas;
        layer.AddChild(rect);
        SummonPanel.Tree.Root.AddChild(layer);
        int frame = 0;
        var timer = new G.Timer { WaitTime = 1 / Fps, Autostart = true };
        timer.Timeout += () =>
        {
            frame++;
            if (frame >= Frames || !G.GodotObject.IsInstanceValid(rect)) { layer.QueueFree(); return; }
            atlas.Region = new G.Rect2(frame * frameW, 0, frameW, frameH);
        };
        layer.AddChild(timer);
    }
}
