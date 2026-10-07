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
