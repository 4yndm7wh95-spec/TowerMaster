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

    /// <summary>
    /// 用真正的塔主牌模型（MasterCards 生成的 CardModel）做原版卡面：标题、说明、卡图、类型都由原版按模型画，
    /// 不再套模板卡改字（0.0.48 用户：「这些卡牌就应该照抄原版」）。cost 不为空时把左上角费用改成这个数（例如挑陷阱的花费）。
    /// </summary>
    public static G.Control? CreateFor(object model, float scale, string? cost = null)
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
            card.Position = size / 2;
            holder.AddChild(card);
            card.Ready += () =>
            {
                try
                {
                    card.GetType().GetProperty("Model")?.SetValue(card, model);
                    // 设 Model 只刷新卡图和类型，标题、说明要 UpdateVisuals 才写（0.0.50 实测不调就显示 Broken Card）
                    Refresh(card);
                }
                catch (Exception e) { Log.Warn($"原版卡牌框架：绑定塔主牌模型失败：{e.InnerException?.Message ?? e.Message}"); }
                if (cost != null)
                {
                    // UpdateVisuals 会把左上角写回模型费用：刷新之后再写挑选花费，过一会儿再写一次防止后续刷新盖掉
                    void SetCost()
                    {
                        if (!G.GodotObject.IsInstanceValid(card)) return;
                        if (card.GetNodeOrNull<G.CanvasItem>("CardContainer/EnergyIcon") is { } icon) icon.Visible = true;
                        SetText(card, "CardContainer/EnergyIcon/EnergyLabel", cost);
                    }
                    SetCost();
                    SummonPanel.Tree.CreateTimer(0.05).Timeout += SetCost;
                    SummonPanel.Tree.CreateTimer(0.3).Timeout += SetCost;
                }
            };
            return holder;
        }
        catch (Exception e)
        {
            Log.Warn($"原版卡牌框架：塔主牌卡面失败：{e.InnerException?.Message ?? e.Message}");
            return null;
        }
    }

    /// <summary>原版 NCard.UpdateVisuals(PileType.None, CardPreviewMode.Normal)：按模型写标题、说明、费用。</summary>
    private static void Refresh(G.Control card)
    {
        var m = card.GetType().GetMethods(GameReflection.All).FirstOrDefault(x => x.Name == "UpdateVisuals" && x.GetParameters().Length == 2);
        if (m == null) { Log.Warn("原版卡牌框架：找不到 NCard.UpdateVisuals，卡面文字可能不对"); return; }
        var ps = m.GetParameters();
        object Arg(Type t, string name) => Enum.GetNames(t).Contains(name) ? Enum.Parse(t, name) : Enum.GetValues(t).GetValue(0)!;
        m.Invoke(card, [Arg(ps[0].ParameterType, "None"), Arg(ps[1].ParameterType, "Normal")]);
    }

    /// <summary>右键查看：打开原版卡牌详情（NGame.GetInspectCardScreen().Open），可以左右翻看同一组牌。</summary>
    public static void Inspect(IEnumerable<object> models, int index)
    {
        try
        {
            var cardModel = GameReflection.TypesNamed("CardModel").First(t => t.IsAbstract);
            var list = (IList)Activator.CreateInstance(typeof(List<>).MakeGenericType(cardModel))!;
            foreach (var m in models) list.Add(m);
            var game = RuntimeNetAction.Required("NGame").GetProperty("Instance", GameReflection.All)?.GetValue(null) ?? throw new InvalidOperationException("没有 NGame");
            var screen = RuntimeNetAction.Call(game, "GetInspectCardScreen");
            screen.GetType().GetMethods(GameReflection.All).First(m => m.Name == "Open" && m.GetParameters().Length == 3).Invoke(screen, [list, index, false]);
        }
        catch (Exception e) { Log.Warn($"原版卡牌详情打开失败：{e.InnerException?.Message ?? e.Message}"); }
    }

    /// <summary>给控件加右键查看。</summary>
    public static void RightClickInspect(G.Control control, Func<IReadOnlyList<object>> models, int index)
    {
        control.GuiInput += ev =>
        {
            if (ev is G.InputEventMouseButton { ButtonIndex: G.MouseButton.Right, Pressed: true })
            {
                Inspect(models(), index);
                control.AcceptEvent();
            }
        };
    }

    /// <summary>卡面关键词高亮（原版卡牌说明里关键词是金色）。</summary>
    public static string Kw(string word) => $"[color=#efc851]{word}[/color]";

    /// <summary>
    /// 像原版手牌一样：鼠标移到卡上时放大、抬起、盖在相邻卡上面，移开复原（小卡上的字也能看清）。
    /// trigger 是接收鼠标的按钮，holder 是 <see cref="Create"/> 返回的容器。
    /// </summary>
    public static void HoverZoom(G.Control trigger, G.Control holder, float zoom, float lift = 0)
    {
        if (holder.GetChildCount() == 0 || holder.GetChild(0) is not G.Control card) return;
        var baseScale = card.Scale;
        var basePos = card.Position;
        G.Tween? tween = null;
        void To(G.Vector2 scale, G.Vector2 position, int z)
        {
            if (!G.GodotObject.IsInstanceValid(card) || !card.IsInsideTree()) return;
            tween?.Kill();
            holder.ZIndex = z;
            tween = card.CreateTween().SetParallel();
            tween.TweenProperty(card, "scale", scale, 0.08);
            tween.TweenProperty(card, "position", position, 0.08);
        }
        float up = (zoom - 1) * holder.CustomMinimumSize.Y / 2 + lift;
        trigger.MouseEntered += () => To(baseScale * zoom, basePos - new G.Vector2(0, up), 20);
        trigger.MouseExited += () => To(baseScale, basePos, 0);
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
