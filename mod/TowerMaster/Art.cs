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

    /// <summary>
    /// 卡图：原版卡图是一整张不透明的画，我们的图标是透明底。直接塞进卡图框，透明处会透出卡后面的
    /// 「能打出」蓝色高亮，不能打出时又变成透明（用户反馈「底色很亮的蓝、不能出时透明」）。
    /// 所以先画一张不透明的深色底（上亮下暗、四角压暗），再把图标居中贴上去。size 用原卡图框的贴图尺寸。
    /// tint 是底色主调（行动牌偏紫、陷阱偏青、遗物偏金），同一张图同一尺寸只合成一次。
    /// </summary>
    public static G.Texture2D? Card(string name, G.Vector2I size, G.Color tint)
    {
        if (size.X < 16 || size.Y < 16) size = new G.Vector2I(500, 380);
        var key = $"{name}|{size.X}x{size.Y}|{tint.ToHtml()}";
        if (CardCache.TryGetValue(key, out var cached)) return cached;
        G.Texture2D? result = null;
        try
        {
            if (Get(name) is { } icon && icon.GetImage() is { } source && !source.IsEmpty())
            {
                var bg = G.Image.CreateEmpty(size.X, size.Y, false, G.Image.Format.Rgba8);
                var center = new G.Vector2(size.X * 0.5f, size.Y * 0.42f);
                float maxD = new G.Vector2(size.X * 0.5f, size.Y * 0.58f).Length();
                var top = tint.Lightened(0.08f);
                var bottom = new G.Color(0.05f, 0.05f, 0.08f);
                for (int y = 0; y < size.Y; y++)
                {
                    var row = top.Lerp(bottom, (float)y / size.Y * 0.85f);
                    for (int x = 0; x < size.X; x++)
                    {
                        float d = new G.Vector2(x, y).DistanceTo(center) / maxD;
                        var c = row.Lerp(bottom, Math.Clamp((d - 0.35f) * 0.9f, 0f, 0.75f)); // 四周压暗
                        c.A = 1;
                        bg.SetPixel(x, y, c);
                    }
                }
                var art = (G.Image)source.Duplicate();
                if (art.GetFormat() != G.Image.Format.Rgba8) art.Convert(G.Image.Format.Rgba8);
                float scale = Math.Min(size.X * 0.82f / art.GetWidth(), size.Y * 0.86f / art.GetHeight());
                int w = Math.Max(1, (int)(art.GetWidth() * scale)), h = Math.Max(1, (int)(art.GetHeight() * scale));
                art.Resize(w, h, G.Image.Interpolation.Lanczos);
                bg.BlendRect(art, new G.Rect2I(0, 0, w, h), new G.Vector2I((size.X - w) / 2, (size.Y - h) / 2));
                result = G.ImageTexture.CreateFromImage(bg);
            }
        }
        catch (Exception e) { Log.Warn($"卡图 {name} 合成失败，用原图：{e.Message}"); result = Get(name); }
        CardCache[key] = result;
        return result;
    }

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
