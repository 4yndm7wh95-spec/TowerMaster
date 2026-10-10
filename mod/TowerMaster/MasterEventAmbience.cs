using G = Godot;

namespace TowerMaster;

/// <summary>
/// 塔主事件配图上的环境动效：很少、很慢、很淡的粒子（用户：「像原版几片羽毛缓缓落下，很微弱的动效」）。
/// 不抢画面，不闪：每种同时最多十来颗，透明度不超过 0.35，淡入淡出，速度每秒十几到几十像素。
/// 粒子图全部程序生成（FxTextures：柔光点、四角星、拖尾、碎片）。
/// 用法：<see cref="Attach"/>(配图控件, 事件 id)，控件大小变了会跟着调整发射区域。接线在问号事件镜像里做。
/// </summary>
internal static class MasterEventAmbience
{
    /// <summary>一种动效：区域（按配图大小的比例，x,y,w,h）、数量、寿命、速度、方向、重力、大小、颜色、旋转。</summary>
    private sealed record Style(
        string Texture, G.Rect2 Area, int Amount, float Lifetime, float SpeedMin, float SpeedMax,
        G.Vector2 Direction, float Spread, G.Vector2 Gravity, float ScaleMin, float ScaleMax,
        G.Color Color, float Alpha, float SpinDeg = 0, float GrowTo = 1);

    private static readonly Dictionary<string, Style[]> Styles = new()
    {
        // 黑市商人：角落里暖金色的灰尘慢慢往上飘
        ["black_market"] = [new("particle_dust", new(0.05f, 0.30f, 0.90f, 0.65f), 10, 7f, 6, 14, new(0.3f, -1), 40, new(0, -2), 0.25f, 0.55f, new(1f, 0.85f, 0.55f), 0.30f)],
        // 地下赌场：筹码上偶尔一闪的小星光（原地淡入淡出，不移动）
        ["casino"] =
        [
            new("particle_spark", new(0.20f, 0.45f, 0.60f, 0.40f), 4, 2.4f, 0, 2, new(0, -1), 180, G.Vector2.Zero, 0.30f, 0.60f, new(1f, 0.90f, 0.60f), 0.35f),
            new("particle_dust", new(0.0f, 0.2f, 1f, 0.8f), 6, 8f, 4, 10, new(0, -1), 60, G.Vector2.Zero, 0.2f, 0.4f, new(0.75f, 0.55f, 1f), 0.20f),
        ],
        // 加班申请：咖啡的热气往上飘、慢慢变大变淡
        ["overtime"] = [new("particle_steam", new(0.55f, 0.55f, 0.12f, 0.05f), 5, 4.5f, 12, 20, new(0.1f, -1), 12, new(3, 0), 0.35f, 0.5f, new(1, 1, 1), 0.18f, 0, 2.2f)],
        // 怪物工会：几片小彩纸慢慢飘落、打转
        ["monster_union"] = [new("particle_confetti", new(0.0f, -0.05f, 1f, 0.05f), 7, 10f, 10, 18, new(0.15f, 1), 20, new(0, 3), 0.35f, 0.6f, new(0.9f, 0.8f, 1f), 0.32f, 90)],
        // 塔主的烦恼：头顶那团小乌云下着细雨
        ["master_worry"] = [new("particle_rain", new(0.35f, 0.12f, 0.30f, 0.04f), 9, 1.6f, 70, 90, new(0.05f, 1), 3, new(0, 20), 0.35f, 0.5f, new(0.75f, 0.8f, 1f), 0.28f)],
    };

    internal static bool Has(string eventId) => Styles.ContainsKey(eventId);

    /// <summary>给配图加上这个事件的动效。重复调用会先清掉旧的。失败只记日志（纯显示）。</summary>
    internal static void Attach(G.Control host, string eventId)
    {
        try
        {
            if (!Styles.TryGetValue(eventId, out var styles)) return;
            host.GetNodeOrNull("TowerMasterAmbience")?.QueueFree();
            var root = new G.Control { Name = "TowerMasterAmbience", MouseFilter = G.Control.MouseFilterEnum.Ignore, ClipContents = true };
            root.SetAnchorsPreset(G.Control.LayoutPreset.FullRect);
            host.AddChild(root);
            var emitters = styles.Select(s => (Style: s, Node: Emitter(s))).ToList();
            foreach (var e in emitters) root.AddChild(e.Node);
            void Fit()
            {
                var size = host.Size;
                if (size.X <= 0 || size.Y <= 0) return;
                foreach (var (s, node) in emitters)
                {
                    node.Position = new G.Vector2((s.Area.Position.X + s.Area.Size.X / 2) * size.X, (s.Area.Position.Y + s.Area.Size.Y / 2) * size.Y);
                    node.EmissionRectExtents = new G.Vector2(s.Area.Size.X * size.X / 2, Math.Max(1, s.Area.Size.Y * size.Y / 2));
                    float k = size.Y / 600f; // 速度、大小按配图高度缩放（600 高时是上面的数）
                    node.InitialVelocityMin = s.SpeedMin * k;
                    node.InitialVelocityMax = s.SpeedMax * k;
                    node.Gravity = s.Gravity * k;
                }
            }
            Fit();
            host.Resized += Fit;
            root.TreeExiting += () => { if (G.GodotObject.IsInstanceValid(host)) host.Resized -= Fit; };
        }
        catch (Exception e) { Log.Warn($"塔主事件动效：加不上（{eventId}）：{e.Message}"); }
    }

    private static G.CpuParticles2D Emitter(Style s)
    {
        var p = new G.CpuParticles2D
        {
            Amount = s.Amount,
            Lifetime = s.Lifetime,
            Preprocess = s.Lifetime, // 一打开就是「已经飘了一阵」的样子，不是从零开始喷
            Randomness = 0.5f,
            // 程序生成的粒子图（和战斗特效同一套 FxTextures，不用 imagegen 的图）
            Texture = s.Texture switch
            {
                "particle_spark" => FxTextures.Star(),
                "particle_rain" => FxTextures.Streak(),
                "particle_confetti" => FxTextures.Shard(),
                _ => FxTextures.Dot(),
            },
            EmissionShape = G.CpuParticles2D.EmissionShapeEnum.Rectangle,
            Direction = s.Direction,
            Spread = s.Spread,
            ScaleAmountMin = s.ScaleMin,
            ScaleAmountMax = s.ScaleMax,
            AngularVelocityMin = -s.SpinDeg,
            AngularVelocityMax = s.SpinDeg,
            Emitting = true,
        };
        // 淡入 → 停留 → 淡出：任何时候都不会突然出现或消失
        var ramp = new G.Gradient();
        ramp.SetColor(0, new G.Color(s.Color, 0));
        ramp.SetColor(1, new G.Color(s.Color, 0));
        ramp.AddPoint(0.25f, new G.Color(s.Color, s.Alpha));
        ramp.AddPoint(0.70f, new G.Color(s.Color, s.Alpha * 0.8f));
        p.ColorRamp = ramp;
        if (s.GrowTo != 1)
        {
            var curve = new G.Curve();
            curve.AddPoint(new G.Vector2(0, 1f / s.GrowTo));
            curve.AddPoint(new G.Vector2(1, 1));
            p.ScaleAmountCurve = curve;
        }
        return p;
    }
}
