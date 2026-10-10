using G = Godot;

namespace TowerMaster;

/// <summary>
/// 可选美术资源：mod 目录下 art/名字.png。有就用，没有返回 null（界面退回纯文字/色块）。
/// 不放进游戏的资源包，所以不用游戏导入，直接从文件读成贴图；读过的缓存起来。
/// 文件清单见 docs/art-assets.md。
/// </summary>
internal static class Art
{
    private static readonly Dictionary<string, G.Texture2D?> Cache = new();

    public static G.Texture2D? Get(string name)
    {
        if (Cache.TryGetValue(name, out var cached)) return cached;
        G.Texture2D? texture = null;
        try
        {
            var path = Path.Combine(Log.ModDir, "art", name + ".png");
            if (File.Exists(path))
            {
                var image = G.Image.LoadFromFile(path);
                if (image != null && !image.IsEmpty()) texture = G.ImageTexture.CreateFromImage(image);
            }
        }
        catch (Exception e) { Log.Warn($"美术资源 {name} 读取失败：{e.Message}"); }
        Cache[name] = texture;
        return texture;
    }

    private static readonly Dictionary<string, G.Texture2D?> CardCache = new();

    /// <summary>卡图底的三种风格：行动牌（塔主的法术，紫）、陷阱（地牢铁器，青）、遗物（宝物架，金）。</summary>
    internal enum CardKind { Action, Trap, Relic }

    /// <summary>
    /// 卡图：原版卡图是一整张不透明的画；我们的图标是透明底的单个物件。直接塞进卡图框会透出卡后面的「能打出」高亮（0.0.44 用户反馈），
    /// 只铺一层渐变又显得「很水、潦草」（0.0.45 用户反馈）。所以按「一幅画」分层合成：
    /// 1. 背景：有 art/card_bg_{action|trap|relic}.png（绘制的场景图）就铺满；没有就程序生成——色调渐变 + 噪声质感 + 每种牌自己的纹样
    ///    （行动：符文法阵；陷阱：铁格栅；遗物：丝绒褶皱和金粉）+ 地面（远暗近亮的台面）+ 四角压暗；
    /// 2. 物件后面一圈柔光（把物件从背景里托出来）；3. 物件落在台面上的接触阴影；4. 物件的投影（模糊、偏右下）；
    /// 5. 物件本身；6. 顶部一道冷光边。结果不透明；同一张图同一尺寸只合成一次。
    /// </summary>
    public static G.Texture2D? Card(string name, G.Vector2I size, CardKind kind)
    {
        if (size.X < 16 || size.Y < 16) size = new G.Vector2I(500, 380);
        var key = $"{name}|{size.X}x{size.Y}|{kind}";
        if (CardCache.TryGetValue(key, out var cached)) return cached;
        G.Texture2D? result = null;
        try
        {
            if (Get(name) is { } icon && icon.GetImage() is { } source && !source.IsEmpty())
                result = G.ImageTexture.CreateFromImage(Compose(source, size.X, size.Y, kind));
        }
        catch (Exception e) { Log.Warn($"卡图 {name} 合成失败，用原图：{e.Message}"); result = Get(name); }
        CardCache[key] = result;
        return result;
    }

    private readonly record struct Palette(G.Color Top, G.Color Bottom, G.Color Glow, G.Color Accent);

    private static Palette PaletteOf(CardKind kind) => kind switch
    {
        CardKind.Trap => new(new(0.13f, 0.24f, 0.27f), new(0.03f, 0.06f, 0.07f), new(0.45f, 0.85f, 0.80f), new(0.55f, 0.70f, 0.72f)),
        CardKind.Relic => new(new(0.30f, 0.20f, 0.11f), new(0.07f, 0.04f, 0.03f), new(1.00f, 0.80f, 0.45f), new(0.95f, 0.75f, 0.35f)),
        _ => new(new(0.22f, 0.14f, 0.32f), new(0.05f, 0.03f, 0.08f), new(0.75f, 0.55f, 1.00f), new(0.90f, 0.72f, 0.40f)),
    };

    private static G.Image Compose(G.Image source, int w, int h, CardKind kind)
    {
        var pal = PaletteOf(kind);
        var icon = (G.Image)source.Duplicate();
        if (icon.GetFormat() != G.Image.Format.Rgba8) icon.Convert(G.Image.Format.Rgba8);
        var used = icon.GetUsedRect(); // 物件实际画了东西的范围（去掉透明边）
        if (used.Size.X > 4 && used.Size.Y > 4) icon = icon.GetRegion(used);
        float scale = Math.Min(w * 0.70f / icon.GetWidth(), h * 0.74f / icon.GetHeight());
        int iw = Math.Max(1, (int)(icon.GetWidth() * scale)), ih = Math.Max(1, (int)(icon.GetHeight() * scale));
        icon.Resize(iw, ih, G.Image.Interpolation.Lanczos);
        float groundY = h * 0.80f;                       // 台面（物件「放」在这条线上）
        int ix = (w - iw) / 2, iy = (int)(groundY - ih + ih * 0.04f);
        if (iy < h * 0.06f) iy = (int)(h * 0.06f);
        float cx = w / 2f, cy = iy + ih * 0.5f;

        var px = new float[w * h * 3];
        // 1. 背景
        if (Get("card_bg_" + kind.ToString().ToLowerInvariant()) is { } bgTex && bgTex.GetImage() is { } bgImg && !bgImg.IsEmpty())
        {
            var bg = (G.Image)bgImg.Duplicate();
            if (bg.GetFormat() != G.Image.Format.Rgba8) bg.Convert(G.Image.Format.Rgba8);
            float s = Math.Max((float)w / bg.GetWidth(), (float)h / bg.GetHeight()); // 铺满、居中裁
            bg.Resize(Math.Max(w, (int)Math.Ceiling(bg.GetWidth() * s)), Math.Max(h, (int)Math.Ceiling(bg.GetHeight() * s)), G.Image.Interpolation.Lanczos);
            int ox = (bg.GetWidth() - w) / 2, oy = (bg.GetHeight() - h) / 2;
            var d = bg.GetData();
            int bw = bg.GetWidth();
            for (int y = 0; y < h; y++)
            for (int x = 0; x < w; x++)
            {
                int si = ((y + oy) * bw + x + ox) * 4, di = (y * w + x) * 3;
                px[di] = d[si] / 255f; px[di + 1] = d[si + 1] / 255f; px[di + 2] = d[si + 2] / 255f;
            }
        }
        else ProceduralBackground(px, w, h, kind, pal, groundY, cx, cy);

        // 2. 物件后面的柔光
        float glowR = Math.Max(iw, ih) * 0.75f;
        for (int y = 0; y < h; y++)
        for (int x = 0; x < w; x++)
        {
            float dx = (x - cx) / glowR, dy = (y - cy) / (glowR * 0.9f);
            float t = 1 - Math.Clamp(MathF.Sqrt(dx * dx + dy * dy), 0, 1);
            float a = t * t * 0.55f;
            // 台面上被照亮的一片
            if (y > groundY)
            {
                float fdx = (x - cx) / (w * 0.42f), fdy = (y - (groundY + h * 0.07f)) / (h * 0.11f);
                float ft = Math.Clamp(1 - MathF.Sqrt(fdx * fdx + fdy * fdy), 0, 1);
                a += ft * ft * 0.30f;
            }
            int i = (y * w + x) * 3;
            px[i] += pal.Glow.R * a; px[i + 1] += pal.Glow.G * a; px[i + 2] += pal.Glow.B * a;
        }
        // 3. 接触阴影（台面上的椭圆）
        float sx = iw * 0.42f, sy = Math.Max(6, h * 0.035f), scy = iy + ih - ih * 0.02f;
        for (int y = Math.Max(0, (int)(scy - sy * 2)); y < Math.Min(h, (int)(scy + sy * 2)); y++)
        for (int x = Math.Max(0, (int)(cx - sx * 1.6f)); x < Math.Min(w, (int)(cx + sx * 1.6f)); x++)
        {
            float dx = (x - cx) / sx, dy = (y - scy) / sy;
            float t = 1 - Math.Clamp(MathF.Sqrt(dx * dx + dy * dy) / 1.5f, 0, 1);
            float k = 1 - t * t * 0.65f;
            int i = (y * w + x) * 3;
            px[i] *= k; px[i + 1] *= k; px[i + 2] *= k;
        }
        // 4. 物件投影：缩小再放大当模糊，往右下偏
        var shadow = (G.Image)icon.Duplicate();
        shadow.Resize(Math.Max(1, iw / 6), Math.Max(1, ih / 6), G.Image.Interpolation.Bilinear);
        shadow.Resize(iw, ih, G.Image.Interpolation.Bilinear);
        var sd = shadow.GetData();
        int offX = Math.Max(3, w / 80), offY = Math.Max(4, h / 50);
        for (int y = 0; y < ih; y++)
        for (int x = 0; x < iw; x++)
        {
            int tx = ix + x + offX, ty = iy + y + offY;
            if (tx < 0 || ty < 0 || tx >= w || ty >= h) continue;
            float a = sd[(y * iw + x) * 4 + 3] / 255f * 0.55f;
            int i = (ty * w + tx) * 3;
            px[i] *= 1 - a; px[i + 1] *= 1 - a; px[i + 2] *= 1 - a;
        }
        // 5. 物件
        var id = icon.GetData();
        for (int y = 0; y < ih; y++)
        for (int x = 0; x < iw; x++)
        {
            int tx = ix + x, ty = iy + y;
            if (tx < 0 || ty < 0 || tx >= w || ty >= h) continue;
            int si = (y * iw + x) * 4;
            float a = id[si + 3] / 255f;
            if (a <= 0) continue;
            int i = (ty * w + tx) * 3;
            px[i] = px[i] * (1 - a) + id[si] / 255f * a;
            px[i + 1] = px[i + 1] * (1 - a) + id[si + 1] / 255f * a;
            px[i + 2] = px[i + 2] * (1 - a) + id[si + 2] / 255f * a;
        }
        // 6. 顶部冷光边
        int rim = Math.Max(3, h / 30);
        for (int y = 0; y < rim; y++)
        {
            float a = (1 - (float)y / rim) * 0.18f;
            for (int x = 0; x < w; x++)
            {
                int i = (y * w + x) * 3;
                px[i] += a * 0.8f; px[i + 1] += a * 0.85f; px[i + 2] += a;
            }
        }

        var bytes = new byte[w * h * 4];
        for (int p = 0, q = 0; p < w * h; p++, q += 3)
        {
            bytes[p * 4] = (byte)(Math.Clamp(px[q], 0, 1) * 255);
            bytes[p * 4 + 1] = (byte)(Math.Clamp(px[q + 1], 0, 1) * 255);
            bytes[p * 4 + 2] = (byte)(Math.Clamp(px[q + 2], 0, 1) * 255);
            bytes[p * 4 + 3] = 255;
        }
        return G.Image.CreateFromData(w, h, false, G.Image.Format.Rgba8, bytes);
    }

    /// <summary>程序生成的背景（没有绘制背景图时）：渐变 + 噪声质感 + 纹样 + 台面 + 四角压暗。</summary>
    private static void ProceduralBackground(float[] px, int w, int h, CardKind kind, Palette pal, float groundY, float cx, float cy)
    {
        float ringR = h * 0.40f;
        for (int y = 0; y < h; y++)
        {
            float fy = (float)y / h;
            for (int x = 0; x < w; x++)
            {
                float fx = (float)x / w;
                // 渐变：上亮下暗；台面以下再亮一点（近处被光照到），交界处一条暗线当「台沿」
                float t = Math.Clamp(fy * 1.05f, 0, 1);
                float r = Lerp(pal.Top.R, pal.Bottom.R, t), g = Lerp(pal.Top.G, pal.Bottom.G, t), b = Lerp(pal.Top.B, pal.Bottom.B, t);
                float edge = (y - groundY) / h;
                if (edge > 0) { float k = 1.0f - edge * 1.6f; r *= k; g *= k; b *= k; }
                else if (edge > -0.012f) { r *= 0.6f; g *= 0.6f; b *= 0.6f; }
                // 从上方打下来的一道光
                float beam = Math.Clamp(1 - MathF.Abs(x - cx) / (w * (0.18f + fy * 0.30f)), 0, 1) * Math.Clamp(1 - fy * 1.1f, 0, 1);
                beam = beam * beam * 0.10f;
                r += pal.Glow.R * beam; g += pal.Glow.G * beam; b += pal.Glow.B * beam;
                // 质感：三层值噪声（石面/旧纸的斑驳）
                float n = Fbm(x / 34f, y / 34f) * 0.55f + Fbm(x / 9f + 40, y / 9f + 17) * 0.45f;
                float tex = 0.80f + n * 0.40f;
                r *= tex; g *= tex; b *= tex;
                // 纹样
                float add = 0;
                switch (kind)
                {
                    case CardKind.Action: // 物件后面的符文法阵：两道圆环 + 一圈刻痕
                    {
                        float d = MathF.Sqrt((x - cx) * (x - cx) + (y - cy) * (y - cy) * 1.6f);
                        float ring = MathF.Max(Band(d, ringR, 2.2f), Band(d, ringR * 0.86f, 1.4f) * 0.7f);
                        float ang = MathF.Atan2(y - cy, x - cx);
                        float ticks = Band(d, ringR * 0.93f, 3.5f) * (MathF.Sin(ang * 24) > 0.6f ? 1 : 0);
                        add = (ring * 0.42f + ticks * 0.30f) * (edge < 0 ? 1 : 0.25f);
                        break;
                    }
                    case CardKind.Trap: // 地牢铁格栅：斜向网格，台面以下是石砖缝
                    {
                        float u = (x + y) / 26f, v = (x - y) / 26f;
                        float grid = MathF.Max(Line(u), Line(v));
                        float bricks = edge > 0 ? MathF.Max(Line(y / 22f), Line(x / 48f + (((int)(y / 22f)) % 2) * 0.5f)) : 0;
                        add = edge > 0 ? -bricks * 0.25f : grid * 0.11f;
                        break;
                    }
                    case CardKind.Relic: // 丝绒褶皱 + 金粉
                    {
                        float fold = MathF.Sin(fx * 26 + MathF.Sin(fy * 7) * 2.2f) * 0.5f + 0.5f;
                        add = (fold - 0.5f) * 0.26f;
                        if (Hash(x, y) > 0.9975f) add += 0.55f;
                        break;
                    }
                }
                r += add * pal.Accent.R; g += add * pal.Accent.G; b += add * pal.Accent.B;
                // 四角压暗
                float vx = fx - 0.5f, vy = fy - 0.45f;
                float vig = 1 - Math.Clamp((vx * vx * 1.6f + vy * vy * 2.2f) * 1.5f, 0, 0.75f);
                int i = (y * w + x) * 3;
                px[i] = r * vig; px[i + 1] = g * vig; px[i + 2] = b * vig;
            }
        }
    }

    private static float Lerp(float a, float b, float t) => a + (b - a) * t;
    private static float Band(float d, float r, float width) => MathF.Max(0, 1 - MathF.Abs(d - r) / width);
    private static float Line(float u) { float f = u - MathF.Floor(u); return MathF.Max(0, 1 - MathF.Min(f, 1 - f) * 14); }

    private static float Hash(int x, int y)
    {
        uint n = (uint)(x * 374761393 + y * 668265263);
        n = (n ^ (n >> 13)) * 1274126177;
        return (n ^ (n >> 16)) / (float)uint.MaxValue;
    }

    private static float Noise(float x, float y)
    {
        int xi = (int)MathF.Floor(x), yi = (int)MathF.Floor(y);
        float fx = x - xi, fy = y - yi;
        fx = fx * fx * (3 - 2 * fx); fy = fy * fy * (3 - 2 * fy);
        float a = Hash(xi, yi), b = Hash(xi + 1, yi), c = Hash(xi, yi + 1), d = Hash(xi + 1, yi + 1);
        return Lerp(Lerp(a, b, fx), Lerp(c, d, fx), fy);
    }

    private static float Fbm(float x, float y) => Noise(x, y) * 0.5f + Noise(x * 2.1f, y * 2.1f) * 0.3f + Noise(x * 4.3f, y * 4.3f) * 0.2f;

    /// <summary>有图标就返回一个固定大小的 TextureRect，没有返回 null。</summary>
    public static G.TextureRect? Icon(string name, float size)
    {
        var texture = Get(name);
        if (texture == null) return null;
        return new G.TextureRect
        {
            Texture = texture,
            ExpandMode = G.TextureRect.ExpandModeEnum.IgnoreSize,
            StretchMode = G.TextureRect.StretchModeEnum.KeepAspectCentered,
            CustomMinimumSize = new G.Vector2(size, size),
            MouseFilter = G.Control.MouseFilterEnum.Ignore,
            SizeFlagsVertical = G.Control.SizeFlags.ShrinkCenter,
        };
    }
}
