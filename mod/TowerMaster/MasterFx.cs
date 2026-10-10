using G = Godot;

namespace TowerMaster;

/// <summary>
/// 塔主战斗特效：全部游戏内实时渲染，不用 imagegen 的图（用户：「imagegen 的特效太廉价」「可以稍微华丽炫技一些」）。
/// 由几样程序生成的元素拼成，叠加发光（additive）：
/// - 法阵 Rune：带刻度和内圈的符文圆，旋转着展开 / 收拢（地面上压成椭圆）；
/// - 光环 Ring / 冲击波 Shock：柔边圆环放大淡出，冲击波更细更快；
/// - 光柱 Beam：从地面升起的一道柔光，升到顶后变细消失；
/// - 闪光 Flash / 光晕 Glow：瞬间亮一下 / 慢慢亮暗；
/// - 拖尾 Streak：几道光线从外往中心收（锁定感）；
/// - 粒子 Burst：CPUParticles2D 一次性喷发——拖尾火花（沿速度方向拉长）、碎片、四角星、雾气。
/// 原则：0.8～1.5 秒，开头有一下「打中」的亮点，之后靠余晖收尾；颜色按效果区分，主色和塔主的紫金一致；最亮处不超过白。
/// 位置、大小由 MasterVfx 按生物点击框算（屏幕坐标）。
/// </summary>
internal static class MasterFx
{
    private static readonly G.Color Gold = new(1f, 0.8f, 0.42f), Ice = new(0.55f, 0.82f, 1f), Crimson = new(1f, 0.28f, 0.4f),
        Violet = new(0.7f, 0.42f, 1f), Ember = new(1f, 0.5f, 0.2f), Leaf = new(0.45f, 1f, 0.6f), Smoke = new(0.32f, 0.22f, 0.42f),
        Frost = new(0.78f, 0.88f, 1f), Star = new(1f, 0.93f, 0.5f), White = new(1f, 1f, 1f);

    internal static readonly string[] Kinds = ["ward", "mark", "bury", "empower", "mend", "drain", "frail", "daze", "summon"];

    /// <summary>
    /// 播一个特效。feet：脚下地面中点；size：生物参考大小（像素，约等于身高）。身上的效果在 feet 往上半个身高处。
    /// </summary>
    internal static void Play(string kind, G.Vector2 feet, float size)
    {
        var layer = new G.CanvasLayer { Layer = 1 };
        var root = new G.Node2D { Position = feet };
        layer.AddChild(root);
        SummonPanel.Tree.Root.AddChild(layer);
        float k = Math.Clamp(size / 300f, 0.5f, 1.6f);
        var body = new G.Vector2(0, -size * 0.45f);
        var head = new G.Vector2(0, -size * 0.85f);
        float life = 1.4f;
        switch (kind)
        {
            case "ward": // 格挡：脚下冰蓝法阵转开，一层护罩从地面罩上来，碎光沿护罩往上飘
                Rune(root, G.Vector2.Zero, Ice, 70 * k, 180 * k, 1.0f, squash: 0.3f, spin: 0.8f);
                Shock(root, G.Vector2.Zero, Ice, 40 * k, 220 * k, 0.45f, squash: 0.3f);
                Bubble(root, body, Ice, size * 0.62f, 0.9f);
                Beam(root, G.Vector2.Zero, Ice, 170 * k, size * 1.05f, 0.8f, peak: 0.35f);
                Burst(root, new(0, -8 * k), "streak", Ice, 22, 0.8f, k, speed: (140, 260), dir: new(0, -1), spread: 18, gravity: new(0, -60), scale: (0.3f, 0.6f), rect: new(120 * k, 6 * k), align: true);
                Burst(root, body, "star", White, 6, 0.7f, k, speed: (10, 40), spread: 180, scale: (0.3f, 0.5f), rect: new(90 * k, 120 * k), delay: 0.2f, explosiveness: 0.3f);
                life = 1.3f;
                break;
            case "mark": // 易伤：四道红光从外面收向身体，法阵收拢锁定，锁住时一闪、碎片崩开，留一个心跳般的红光
                Streaks(root, body, Crimson, 4, 230 * k, 0.32f);
                Rune(root, body, Crimson, 200 * k, 75 * k, 0.4f, spin: -1.2f, fadeOut: 0.5f);
                Flash(root, body, White, 120 * k, delay: 0.32f);
                Shock(root, body, Crimson, 60 * k, 200 * k, 0.35f, delay: 0.32f);
                Burst(root, body, "shard", Crimson, 16, 0.6f, k, speed: (180, 320), spread: 180, scale: (0.35f, 0.65f), spin: 540, damping: 300, delay: 0.32f, align: true);
                Pulse(root, body, Crimson, 110 * k, 0.4f, times: 2, delay: 0.5f);
                life = 1.4f;
                break;
            case "bury": // 埋陷阱：紫光一闪钉进地面，冲击波压出一圈尘土，法阵一转就隐去
                Beam(root, G.Vector2.Zero, Violet, 50 * k, 220 * k, 0.35f, peak: 0.7f, down: true);
                Shock(root, G.Vector2.Zero, Violet, 20 * k, 140 * k, 0.4f, squash: 0.3f, delay: 0.12f);
                Rune(root, G.Vector2.Zero, Violet, 50 * k, 90 * k, 0.7f, squash: 0.3f, spin: 2f, delay: 0.12f);
                Burst(root, new(0, -4 * k), "dot", Smoke, 22, 0.8f, k, speed: (60, 150), dir: new(0, -1), spread: 75, gravity: new(0, 260), scale: (0.5f, 1.1f), rect: new(30 * k, 4 * k), additive: false, alpha: 0.85f, delay: 0.12f);
                Burst(root, new(0, -4 * k), "streak", Violet, 8, 0.5f, k, speed: (120, 220), dir: new(0, -1), spread: 50, scale: (0.25f, 0.4f), delay: 0.12f, align: true);
                life = 1.1f;
                break;
            case "empower": // 力量：冲击波一震，橙红火星沿光柱往上窜，身上燃起一团火光
                Shock(root, G.Vector2.Zero, Ember, 30 * k, 230 * k, 0.4f, squash: 0.3f);
                Rune(root, G.Vector2.Zero, Ember, 60 * k, 150 * k, 0.9f, squash: 0.3f, spin: 1.5f);
                Beam(root, G.Vector2.Zero, Ember, 140 * k, size * 1.1f, 0.7f, peak: 0.5f);
                Burst(root, new(0, -6 * k), "streak", Ember, 30, 0.8f, k, speed: (220, 420), dir: new(0, -1), spread: 14, gravity: new(0, -120), scale: (0.3f, 0.7f), rect: new(100 * k, 6 * k), align: true);
                Burst(root, body, "dot", Gold, 14, 0.9f, k, speed: (30, 90), dir: new(0, -1), spread: 60, gravity: new(0, -90), scale: (0.15f, 0.3f), rect: new(70 * k, 90 * k), delay: 0.15f);
                Pulse(root, body, Ember, 170 * k, 0.5f, times: 1, delay: 0.1f);
                break;
            case "mend": // 治疗：绿色光点绕着身体螺旋上升，柔光慢慢亮起，顶上一颗星一闪
                Rune(root, G.Vector2.Zero, Leaf, 60 * k, 120 * k, 1.1f, squash: 0.3f, spin: 0.6f, peak: 0.5f);
                Glow(root, body, Leaf, size * 0.9f, 1.1f, peak: 0.3f);
                Burst(root, new(0, -10 * k), "dot", Leaf, 26, 1.2f, k, speed: (50, 90), dir: new(0, -1), spread: 20, gravity: new(0, -40), scale: (0.12f, 0.28f), rect: new(80 * k, 10 * k), orbit: 0.35f, explosiveness: 0.5f);
                Burst(root, head, "star", White, 3, 0.7f, k, speed: (0, 10), spread: 180, scale: (0.5f, 0.8f), rect: new(30 * k, 20 * k), delay: 0.5f);
                life = 1.5f;
                break;
            case "drain": // 虚弱：暗紫烟圈从外往里收，光丝被吸进身体，吸完身上暗暗一沉
                Rune(root, body, Violet, 210 * k, 90 * k, 0.6f, spin: -0.8f, peak: 0.6f);
                Burst(root, body, "dot", Smoke, 26, 0.7f, k, speed: (0, 10), spread: 180, scale: (0.7f, 1.3f), rect: new(160 * k, 160 * k), radial: -520, additive: false, alpha: 0.7f, explosiveness: 1f);
                Burst(root, body, "streak", Violet, 18, 0.55f, k, speed: (0, 10), spread: 180, scale: (0.3f, 0.6f), rect: new(170 * k, 170 * k), radial: -700, explosiveness: 1f, align: true);
                Pulse(root, body, Violet, 140 * k, 0.5f, times: 1, delay: 0.5f);
                life = 1.3f;
                break;
            case "frail": // 脆弱：白光一裂，冰色碎片翻转着往下掉，地上溅起一小圈
                Flash(root, body, White, 110 * k);
                Shock(root, body, Frost, 50 * k, 170 * k, 0.3f);
                Burst(root, body, "shard", Frost, 18, 1.0f, k, speed: (90, 200), dir: new(0, -1), spread: 75, gravity: new(0, 700), scale: (0.4f, 0.8f), spin: 720, explosiveness: 0.95f);
                Shock(root, G.Vector2.Zero, Frost, 20 * k, 110 * k, 0.4f, squash: 0.3f, delay: 0.55f);
                life = 1.3f;
                break;
            case "daze": // 晕眩：头顶一圈金星打转，偶尔一闪
                Burst(root, head, "star", Star, 6, 1.4f, k, speed: (0, 0), spread: 180, scale: (0.45f, 0.65f), rect: new(80 * k, 16 * k), orbit: 0.8f, spin: 180, explosiveness: 1f);
                Burst(root, head, "dot", White, 10, 0.5f, k, speed: (40, 90), spread: 180, scale: (0.08f, 0.15f), delay: 0.2f);
                Rune(root, head, Star, 50 * k, 95 * k, 1.2f, squash: 0.35f, spin: 2.4f, peak: 0.45f);
                life = 1.6f;
                break;
            case "summon": // 召唤：两层紫金法阵反向转开，光柱冲天，碎光螺旋上升，最后一圈冲击波把怪「放」出来
                Rune(root, G.Vector2.Zero, Violet, 40 * k, 230 * k, 1.3f, squash: 0.3f, spin: 1.2f);
                Rune(root, G.Vector2.Zero, Gold, 30 * k, 140 * k, 1.1f, squash: 0.3f, spin: -1.8f, delay: 0.1f);
                Beam(root, G.Vector2.Zero, Violet, 200 * k, size * 1.4f, 1.1f, peak: 0.6f);
                Beam(root, G.Vector2.Zero, White, 70 * k, size * 1.2f, 0.7f, peak: 0.35f);
                Burst(root, new(0, -10 * k), "streak", Violet, 34, 1.1f, k, speed: (120, 260), dir: new(0, -1), spread: 16, gravity: new(0, -90), scale: (0.3f, 0.6f), rect: new(130 * k, 10 * k), orbit: 0.2f, align: true);
                Burst(root, body, "star", Gold, 8, 0.9f, k, speed: (20, 60), spread: 180, scale: (0.3f, 0.55f), rect: new(110 * k, 140 * k), delay: 0.3f, explosiveness: 0.4f);
                Flash(root, body, White, 180 * k, delay: 0.55f);
                Shock(root, G.Vector2.Zero, Violet, 60 * k, 300 * k, 0.5f, squash: 0.3f, delay: 0.55f);
                life = 1.8f;
                break;
            default:
                Log.Warn($"塔主特效：没有渲染特效 {kind}");
                break;
        }
        SummonPanel.Tree.CreateTimer(life + 0.5).Timeout += () => { if (G.GodotObject.IsInstanceValid(layer)) layer.QueueFree(); };
    }

    // ---------------------------------------------------------------- 元素

    private static G.CanvasItemMaterial Additive() => new() { BlendMode = G.CanvasItemMaterial.BlendModeEnum.Add };

    private static G.Sprite2D Sprite(G.Node2D root, G.Texture2D tex, G.Vector2 at, G.Color color)
    {
        var s = new G.Sprite2D { Texture = tex, Position = at, Material = Additive(), Modulate = new G.Color(color, 0) };
        root.AddChild(s);
        return s;
    }

    private static G.Tween After(G.Node node, float delay)
    {
        var t = node.CreateTween();
        if (delay > 0) t.TweenInterval(delay);
        return t;
    }

    /// <summary>符文法阵：半径 from → to，边转边展开（或收拢），然后淡出。</summary>
    private static void Rune(G.Node2D root, G.Vector2 at, G.Color color, float from, float to, float duration,
        float squash = 1f, float spin = 1f, float delay = 0, float peak = 0.85f, float fadeOut = 0.6f)
    {
        // 地面上的法阵：外面套一个压扁的节点，里面的图自己转，转起来仍是椭圆
        var holder = new G.Node2D { Position = at, Scale = new G.Vector2(1, squash) };
        root.AddChild(holder);
        var tex = FxTextures.Rune();
        float baseR = tex.GetWidth() / 2f;
        var s = Sprite(holder, tex, G.Vector2.Zero, color);
        s.Scale = G.Vector2.One * (from / baseR);
        var t = After(s, delay);
        t.TweenProperty(s, "modulate:a", peak, duration * 0.2f);
        t.Parallel().TweenProperty(s, "scale", G.Vector2.One * (to / baseR), duration * 0.55f).SetEase(G.Tween.EaseType.Out).SetTrans(G.Tween.TransitionType.Back);
        t.Parallel().TweenProperty(s, "rotation", spin * duration, duration);
        t.Parallel().TweenProperty(s, "modulate:a", 0f, duration * fadeOut).SetDelay(duration * (1 - fadeOut));
    }

    /// <summary>冲击波：细圆环快速放大淡出。</summary>
    private static void Shock(G.Node2D root, G.Vector2 at, G.Color color, float from, float to, float duration, float squash = 1f, float delay = 0)
    {
        var tex = FxTextures.Ring(0.06f);
        float baseR = tex.GetWidth() / 2f;
        var s = Sprite(root, tex, at, color);
        s.Scale = new G.Vector2(from / baseR, from / baseR * squash);
        var t = After(s, delay);
        t.TweenProperty(s, "modulate:a", 1f, 0.04f);
        t.TweenProperty(s, "scale", new G.Vector2(to / baseR, to / baseR * squash), duration).SetEase(G.Tween.EaseType.Out).SetTrans(G.Tween.TransitionType.Expo);
        t.Parallel().TweenProperty(s, "modulate:a", 0f, duration).SetEase(G.Tween.EaseType.In);
    }

    /// <summary>护罩：竖着的椭圆光环从小罩上来，停一下再散开淡出。</summary>
    private static void Bubble(G.Node2D root, G.Vector2 at, G.Color color, float radius, float duration)
    {
        var tex = FxTextures.Ring(0.18f);
        float baseR = tex.GetWidth() / 2f;
        var s = Sprite(root, tex, at, color);
        var full = new G.Vector2(radius / baseR * 0.8f, radius / baseR);
        s.Scale = full * 0.6f;
        var t = s.CreateTween();
        t.TweenProperty(s, "modulate:a", 0.55f, duration * 0.25f);
        t.Parallel().TweenProperty(s, "scale", full, duration * 0.3f).SetEase(G.Tween.EaseType.Out).SetTrans(G.Tween.TransitionType.Back);
        t.TweenInterval(duration * 0.2f);
        t.TweenProperty(s, "modulate:a", 0f, duration * 0.5f);
        t.Parallel().TweenProperty(s, "scale", full * 1.12f, duration * 0.5f);
        var glow = Sprite(root, FxTextures.Dot(), at, color);
        glow.Scale = full * (tex.GetWidth() / (float)FxTextures.Dot().GetWidth());
        var g = glow.CreateTween();
        g.TweenProperty(glow, "modulate:a", 0.18f, duration * 0.3f);
        g.TweenProperty(glow, "modulate:a", 0f, duration * 0.7f);
    }

    /// <summary>光柱：底边在 at，宽 width、高 height，升起后变细淡出。down=true 时从上往下砸。</summary>
    private static void Beam(G.Node2D root, G.Vector2 at, G.Color color, float width, float height, float duration, float peak = 0.5f, bool down = false)
    {
        var tex = FxTextures.Beam();
        var s = new G.Sprite2D { Texture = tex, Material = Additive(), Modulate = new G.Color(color, 0), Offset = new G.Vector2(0, -tex.GetHeight() / 2f), Position = at };
        root.AddChild(s);
        float sx = width / tex.GetWidth(), sy = height / tex.GetHeight();
        s.Scale = new G.Vector2(sx, down ? sy : sy * 0.2f);
        var t = s.CreateTween();
        t.TweenProperty(s, "modulate:a", peak, duration * 0.2f);
        t.Parallel().TweenProperty(s, "scale:y", sy, duration * 0.3f).SetEase(G.Tween.EaseType.Out).SetTrans(G.Tween.TransitionType.Cubic);
        t.TweenProperty(s, "modulate:a", 0f, duration * 0.7f);
        t.Parallel().TweenProperty(s, "scale:x", sx * 0.25f, duration * 0.7f).SetEase(G.Tween.EaseType.In);
    }

    /// <summary>闪光：一瞬间的亮点（0.18 秒）。</summary>
    private static void Flash(G.Node2D root, G.Vector2 at, G.Color color, float size, float delay = 0)
    {
        var s = Sprite(root, FxTextures.Star(), at, color);
        s.Scale = G.Vector2.One * (size / FxTextures.Star().GetWidth()) * 0.5f;
        var t = After(s, delay);
        t.TweenProperty(s, "modulate:a", 0.9f, 0.05f);
        t.Parallel().TweenProperty(s, "scale", G.Vector2.One * (size / FxTextures.Star().GetWidth()) * 1.3f, 0.18f).SetEase(G.Tween.EaseType.Out);
        t.Parallel().TweenProperty(s, "rotation", 0.5f, 0.18f);
        t.TweenProperty(s, "modulate:a", 0f, 0.13f);
        Glow(root, at, color, size * 1.4f, 0.3f, delay: delay, peak: 0.5f);
    }

    /// <summary>光晕：慢慢亮起再暗下去。</summary>
    private static void Glow(G.Node2D root, G.Vector2 at, G.Color color, float size, float duration, float delay = 0, float peak = 0.4f)
    {
        var s = Sprite(root, FxTextures.Dot(), at, color);
        s.Scale = G.Vector2.One * (size / FxTextures.Dot().GetWidth());
        var t = After(s, delay);
        t.TweenProperty(s, "modulate:a", peak, duration * 0.3f);
        t.TweenProperty(s, "modulate:a", 0f, duration * 0.7f);
    }

    /// <summary>心跳：光晕亮暗 times 次。</summary>
    private static void Pulse(G.Node2D root, G.Vector2 at, G.Color color, float size, float each, int times, float delay = 0)
    {
        var s = Sprite(root, FxTextures.Dot(), at, color);
        s.Scale = G.Vector2.One * (size / FxTextures.Dot().GetWidth());
        var t = After(s, delay);
        for (int i = 0; i < times; i++)
        {
            t.TweenProperty(s, "modulate:a", 0.5f, each * 0.3f).SetTrans(G.Tween.TransitionType.Sine);
            t.TweenProperty(s, "modulate:a", 0f, each * 0.7f).SetTrans(G.Tween.TransitionType.Sine);
        }
    }

    /// <summary>拖尾：count 道光线从 distance 外沿不同角度收向 at（锁定）。</summary>
    private static void Streaks(G.Node2D root, G.Vector2 at, G.Color color, int count, float distance, float duration)
    {
        var tex = FxTextures.Streak();
        for (int i = 0; i < count; i++)
        {
            float angle = MathF.PI / 4 + i * MathF.Tau / count;
            var dir = new G.Vector2(MathF.Cos(angle), MathF.Sin(angle));
            var s = Sprite(root, tex, at + dir * distance, color);
            s.Rotation = angle + MathF.PI / 2;
            s.Scale = new G.Vector2(0.8f, distance / tex.GetHeight() * 0.8f);
            var t = s.CreateTween();
            t.TweenProperty(s, "modulate:a", 0.95f, duration * 0.3f);
            t.Parallel().TweenProperty(s, "position", at + dir * distance * 0.15f, duration).SetEase(G.Tween.EaseType.In).SetTrans(G.Tween.TransitionType.Cubic);
            t.Parallel().TweenProperty(s, "scale:y", distance / tex.GetHeight() * 0.25f, duration).SetEase(G.Tween.EaseType.In);
            t.TweenProperty(s, "modulate:a", 0f, 0.08f);
        }
    }

    /// <summary>一次性粒子喷发。速度、重力、范围按 k 缩放。align：粒子沿速度方向拉长（拖尾火花）。</summary>
    private static void Burst(G.Node2D root, G.Vector2 at, string texture, G.Color color, int amount, float lifetime, float k,
        (float Min, float Max) speed, G.Vector2? dir = null, float spread = 180, G.Vector2? gravity = null, (float Min, float Max)? scale = null,
        G.Vector2? rect = null, float radial = 0, float orbit = 0, float spin = 0, float damping = 0, float delay = 0,
        float explosiveness = 0.85f, bool additive = true, float alpha = 1f, bool align = false)
    {
        var p = new G.CpuParticles2D
        {
            Position = at,
            Amount = amount,
            Lifetime = lifetime,
            OneShot = true,
            Explosiveness = explosiveness,
            Randomness = 0.4f,
            LifetimeRandomness = 0.3f,
            Emitting = delay <= 0,
            Texture = texture switch
            {
                "shard" => FxTextures.Shard(),
                "streak" => FxTextures.Streak(),
                "star" => FxTextures.Star(),
                _ => FxTextures.Dot(),
            },
            Direction = dir ?? new G.Vector2(0, -1),
            Spread = spread,
            Gravity = (gravity ?? G.Vector2.Zero) * k,
            InitialVelocityMin = speed.Min * k,
            InitialVelocityMax = speed.Max * k,
            RadialAccelMin = radial * k,
            RadialAccelMax = radial * k,
            OrbitVelocityMin = orbit,
            OrbitVelocityMax = orbit,
            AngularVelocityMin = -spin,
            AngularVelocityMax = spin,
            DampingMin = damping * k,
            DampingMax = damping * k,
            ScaleAmountMin = (scale?.Min ?? 0.3f) * k,
            ScaleAmountMax = (scale?.Max ?? 0.6f) * k,
            LocalCoords = true,
        };
        if (align) p.ParticleFlagAlignY = true; // 粒子的纵轴（拖尾图的长边）顺着速度方向
        if (rect is { } r)
        {
            p.EmissionShape = G.CpuParticles2D.EmissionShapeEnum.Rectangle;
            p.EmissionRectExtents = r;
        }
        if (additive) p.Material = Additive();
        var ramp = new G.Gradient();
        ramp.SetColor(0, new G.Color(color, 0));
        ramp.SetColor(1, new G.Color(color, 0));
        ramp.AddPoint(0.08f, new G.Color(color, alpha));
        ramp.AddPoint(0.6f, new G.Color(color, alpha * 0.75f));
        p.ColorRamp = ramp;
        // 粒子先大后小（收尾时变细）
        var curve = new G.Curve();
        curve.AddPoint(new G.Vector2(0, 1));
        curve.AddPoint(new G.Vector2(1, 0.35f));
        p.ScaleAmountCurve = curve;
        root.AddChild(p);
        if (delay > 0) SummonPanel.Tree.CreateTimer(delay).Timeout += () => { if (G.GodotObject.IsInstanceValid(p)) p.Emitting = true; };
    }
}

/// <summary>特效用的程序生成纹理（白色，染色靠 Modulate / 粒子颜色），生成一次缓存。</summary>
internal static class FxTextures
{
    private static G.Texture2D? _dot, _beam, _shard, _streak, _star, _rune;
    private static readonly Dictionary<int, G.Texture2D> Rings = new();

    private static G.Texture2D Make(int w, int h, Func<float, float, float> alpha)
    {
        var bytes = new byte[w * h * 4];
        for (int y = 0; y < h; y++)
        for (int x = 0; x < w; x++)
        {
            int i = (y * w + x) * 4;
            bytes[i] = bytes[i + 1] = bytes[i + 2] = 255;
            bytes[i + 3] = (byte)(Math.Clamp(alpha((x + 0.5f) / w, (y + 0.5f) / h), 0, 1) * 255);
        }
        return G.ImageTexture.CreateFromImage(G.Image.CreateFromData(w, h, false, G.Image.Format.Rgba8, bytes));
    }

    private static float Smooth(float a) { a = Math.Clamp(a, 0, 1); return a * a * (3 - 2 * a); }

    /// <summary>u,v (0..1) → 以中心为原点的半径（0..1 到边）和角度。</summary>
    private static (float R, float A) Polar(float u, float v)
    {
        float x = u * 2 - 1, y = v * 2 - 1;
        return (MathF.Sqrt(x * x + y * y), MathF.Atan2(y, x));
    }

    /// <summary>柔光点：中心最亮，平方衰减。</summary>
    internal static G.Texture2D Dot() => _dot ??= Make(64, 64, (u, v) => { float a = 1 - Polar(u, v).R; return a <= 0 ? 0 : a * a; });

    /// <summary>柔边圆环（半径 0.88 处最亮）。width：环宽占半径的比例。</summary>
    internal static G.Texture2D Ring(float width)
    {
        int key = (int)MathF.Round(width * 100);
        if (Rings.TryGetValue(key, out var t)) return t;
        return Rings[key] = Make(256, 256, (u, v) => Smooth(1 - MathF.Abs(Polar(u, v).R - 0.88f) / width));
    }

    /// <summary>
    /// 符文法阵：外圈细环 + 内圈细环，中间一圈 24 道刻度、6 个小圆点，最里面一个六芒星的三角线条。
    /// </summary>
    internal static G.Texture2D Rune() => _rune ??= Make(512, 512, (u, v) =>
    {
        var (r, a) = Polar(u, v);
        float line(float at, float w) => Smooth(1 - MathF.Abs(r - at) / w);
        float alpha = line(0.95f, 0.018f) + 0.8f * line(0.9f, 0.008f) + 0.9f * line(0.68f, 0.012f);
        // 刻度：24 道，长短交替
        float seg = a / MathF.Tau * 24;
        float tick = Smooth(1 - MathF.Abs(seg - MathF.Round(seg)) * 2 / 0.12f);
        bool longTick = ((int)MathF.Round(seg) & 1) == 0;
        if (r > (longTick ? 0.72f : 0.78f) && r < 0.87f) alpha += 0.7f * tick;
        // 6 个小圆点
        float six = a / MathF.Tau * 6;
        float da = (six - MathF.Round(six)) * MathF.Tau / 6 * 0.8f;
        float dr = r - 0.8f;
        alpha += Smooth(1 - MathF.Sqrt(da * da + dr * dr) / 0.03f);
        // 六芒星：两个等边三角形，内切于 0.62 的圆
        float x = u * 2 - 1, y = v * 2 - 1;
        float tri(float rot)
        {
            float best = 1;
            for (int i = 0; i < 3; i++)
            {
                float ang = rot + i * MathF.Tau / 3;
                float d = MathF.Abs(x * MathF.Cos(ang) + y * MathF.Sin(ang) - 0.31f); // 三角形边到中心距离 = 外接圆半径 0.62 / 2
                best = MathF.Min(best, d);
            }
            return r < 0.64f ? Smooth(1 - best / 0.009f) : 0;
        }
        alpha += 0.55f * (tri(MathF.PI / 2) + tri(-MathF.PI / 2));
        return Math.Clamp(alpha, 0, 1);
    });

    /// <summary>光柱：底部最亮往上渐隐，左右柔边。</summary>
    internal static G.Texture2D Beam() => _beam ??= Make(64, 256, (u, v) =>
    {
        float side = 1 - MathF.Abs(u * 2 - 1);
        return side * side * MathF.Pow(v, 1.4f);
    });

    /// <summary>碎片：细长菱形。</summary>
    internal static G.Texture2D Shard() => _shard ??= Make(24, 40, (u, v) => (1 - (MathF.Abs(u * 2 - 1) / 0.9f + MathF.Abs(v * 2 - 1))) * 6);

    /// <summary>拖尾：竖长的光线，中间最亮、两头渐隐。</summary>
    internal static G.Texture2D Streak() => _streak ??= Make(16, 96, (u, v) =>
    {
        float side = 1 - MathF.Abs(u * 2 - 1);
        float len = 1 - MathF.Abs(v * 2 - 1);
        return side * side * Smooth(len * 1.4f);
    });

    /// <summary>四角星：十字细光 + 中心亮点。</summary>
    internal static G.Texture2D Star() => _star ??= Make(64, 64, (u, v) =>
    {
        float x = MathF.Abs(u * 2 - 1), y = MathF.Abs(v * 2 - 1);
        float arms = MathF.Max(Smooth(1 - x / 0.08f) * (1 - y), Smooth(1 - y / 0.08f) * (1 - x));
        float core = 1 - MathF.Sqrt(x * x + y * y) / 0.35f;
        return MathF.Max(arms, core <= 0 ? 0 : core * core);
    });
}
