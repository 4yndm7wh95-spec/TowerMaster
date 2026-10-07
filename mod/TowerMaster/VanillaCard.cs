using System.Collections;
using G = Godot;

namespace TowerMaster;

/// <summary>塔主卡牌的卡面内容。</summary>
internal sealed record CardFace(string Title, string Description, string Type, string Cost, string? Art);

/// <summary>
/// 用原版卡牌的框架画塔主的卡（用户要求「用原版卡牌框架新做卡牌」）：
/// 运行时实例化游戏自己的卡牌场景 res://scenes/cards/card.tscn（不拷贝任何游戏资源），先套一张原版卡（取它的卡框、横幅、
/// 类型牌等贴图），再把标题、说明、费用、类型字和插画换成塔主卡的内容。
/// 不注册新的 CardModel（那要改游戏的模型库，联机风险大），所以这些卡只是界面，点击由我们自己处理。
/// 任何一步失败就返回 null，调用方退回自绘的卡片。
/// </summary>
internal static class VanillaCard
{
    private const string ScenePath = "res://scenes/cards/card.tscn";
    private static G.PackedScene? _scene;
    private static object? _template;
    private static bool _failed;

    /// <summary>原版卡的原始尺寸（NCard.defaultSize，读不到就用 300×422）。</summary>
    public static G.Vector2 BaseSize
    {
        get
        {
            try
            {
                if (RuntimeNetAction.Required("NCard").GetField("defaultSize", GameReflection.All)?.GetValue(null) is G.Vector2 v && v.X > 0) return v;
            }
            catch { /* 用默认 */ }
            return new G.Vector2(300, 422);
        }
    }

    /// <summary>做一张缩放过的原版卡，放在固定大小的容器里（容器不接收鼠标，由外面的按钮接）。失败返回 null。</summary>
    public static G.Control? Create(CardFace face, float scale)
    {
        if (_failed) return null;
        try
        {
            _scene ??= G.ResourceLoader.Load<G.PackedScene>(ScenePath);
            if (_scene == null) throw new InvalidOperationException($"读不到 {ScenePath}");
            var size = BaseSize * scale;
            var holder = new G.Control { CustomMinimumSize = size, MouseFilter = G.Control.MouseFilterEnum.Ignore };
            var card = _scene.Instantiate<G.Control>();
            card.MouseFilter = G.Control.MouseFilterEnum.Ignore;
            card.Scale = new G.Vector2(scale, scale);
            card.Position = size / 2; // 原版卡的子节点围着原点摆
            holder.AddChild(card);
            card.Ready += () =>
            {
                Populate(card, face);
                // 原版可能延迟刷新文字，稍后再覆盖一次
                SummonPanel.Tree.CreateTimer(0.05).Timeout += () => { if (G.GodotObject.IsInstanceValid(card)) Populate(card, face, setModel: false); };
            };
            return holder;
        }
        catch (Exception e)
        {
            _failed = true;
            Log.Warn($"原版卡牌框架不可用，改用自绘卡片：{e.InnerException?.Message ?? e.Message}");
            return null;
        }
    }

    private static void Populate(G.Control card, CardFace face, bool setModel = true)
    {
        try
        {
            if (setModel && Template() is { } model) card.GetType().GetProperty("Model")?.SetValue(card, model);
            SetText(card, "CardContainer/TitleLabel", face.Title);
            SetText(card, "CardContainer/TypePlaque/TypeLabel", face.Type);
            SetText(card, "CardContainer/EnergyIcon/EnergyLabel", face.Cost);
            if (card.GetNodeOrNull<G.RichTextLabel>("CardContainer/DescriptionLabel") is { } desc)
            {
                desc.BbcodeEnabled = true;
                desc.Text = $"[center]{face.Description}[/center]";
            }
            Hide(card, "CardContainer/StarIcon");
            Hide(card, "CardContainer/Enchantment");
            Hide(card, "CardContainer/Lock");
            if (face.Art != null && Art.Get(face.Art) is { } texture && card.GetNodeOrNull<G.TextureRect>("CardContainer/PortraitCanvasGroup/Portrait") is { } portrait)
            {
                portrait.Texture = texture;
                portrait.ExpandMode = G.TextureRect.ExpandModeEnum.IgnoreSize;
                portrait.StretchMode = G.TextureRect.StretchModeEnum.KeepAspectCentered;
            }
        }
        catch (Exception e) { Log.Warn($"原版卡牌框架：填卡面失败：{e.Message}"); }
    }

    private static void SetText(G.Node card, string path, string text)
    {
        if (card.GetNodeOrNull<G.Label>(path) is { } label) label.Text = text;
    }

    private static void Hide(G.Node card, string path)
    {
        if (card.GetNodeOrNull<G.CanvasItem>(path) is { } item) item.Visible = false;
    }

    /// <summary>拿一张原版无色技能卡当卡框模板（找不到无色的就用第一张技能卡）。</summary>
    private static object? Template()
    {
        if (_template != null) return _template;
        try
        {
            var all = RuntimeNetAction.Required("ModelDb").GetProperty("AllCards", GameReflection.All)?.GetValue(null) as IEnumerable;
            var cards = all?.Cast<object>().ToList() ?? [];
            bool IsSkill(object c) => GameReflection.Get(c, "Type")?.ToString() == "Skill";
            bool IsColorless(object c) => (GameReflection.Get(c, "Pool")?.GetType().Name ?? "").Contains("Colorless");
            _template = cards.FirstOrDefault(c => IsSkill(c) && IsColorless(c)) ?? cards.FirstOrDefault(IsSkill) ?? cards.FirstOrDefault();
            Log.Info($"原版卡牌框架：卡框模板 {_template?.GetType().Name ?? "无"}");
        }
        catch (Exception e) { Log.Warn($"原版卡牌框架：找不到模板卡：{e.Message}"); }
        return _template;
    }
}
