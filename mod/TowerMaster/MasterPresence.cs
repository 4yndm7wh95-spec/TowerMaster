using System.Collections;
using HarmonyLib;
using G = Godot;

namespace TowerMaster;

/// <summary>
/// 塔主在画面上的样子（用户要求：塔主不再是一个死掉的玩家，而是站在怪物一侧的独立形象）。纯显示，不改游戏状态，各端各画各的。
/// - 战斗里隐藏塔主那名玩家的角色节点（NCreature），屏幕左上角玩家列表里也隐藏塔主那一项。
/// - 在怪物身后（战斗房间右侧）放塔主形象：art/master_figure.png（没有就用头像 master_portrait.png），轻微上下浮动；
///   塔主回合操作、陷阱触发时闪一下（<see cref="Cast"/>）。
/// - 战斗结束：原版 Player.ReviveBeforeCombatEnd 会复活塔主并在他原来的位置播回血特效（用户反馈「凭空回血」）。
///   改成对塔主直接写回生命（不播动画、不发复活事件）；开关 <see cref="StayDead"/> 打开时干脆不复活。
/// - 塔主的角色节点在它 _Ready 时就藏起来（原来每 10 帧轮询，开战第一下会闪一下，用户反馈）。
/// </summary>
internal static class MasterPresence
{
    private static bool _patched;
    private static G.Control? _figure;
    private static G.Node? _decoratedRoom;
    private static G.Tween? _idle;

    /// <summary>战后不复活塔主。默认关：一直死着会让原版事件走死亡分支（0.0.24 实测），而塔主已经隐藏，复活玩家也看不到。</summary>
    public static bool StayDead { get; set; }

    /// <summary>每帧检查战斗房间（只做显示）；测试里不挂。</summary>
    internal static void Apply(Harmony harmony, bool stayDead)
    {
        StayDead = stayDead;
        if (_patched) return;
        _patched = true;
        var revive = GameReflection.FindMethod("ReviveBeforeCombatEnd", "Player");
        if (revive != null)
        {
            harmony.Patch(revive, prefix: new HarmonyMethod(typeof(MasterPresence).GetMethod(nameof(SkipMasterRevive), GameReflection.All)!) { priority = Priority.First });
            Log.Info($"塔主形象：战后{(stayDead ? "不复活塔主" : "悄悄复活塔主（不播回血特效）")}，已挂到 {GameReflection.Describe(revive)}");
        }
        else Log.Warn("塔主形象：找不到 Player.ReviveBeforeCombatEnd，战后塔主位置会播回血特效");
        var portrait = GameReflection.FindMethod("Initialize", "NTopBarPortrait");
        if (portrait != null)
        {
            try { harmony.Patch(portrait, postfix: new HarmonyMethod(typeof(MasterPresence).GetMethod(nameof(AfterTopBarPortrait), GameReflection.All)!)); }
            catch (Exception e) { Log.Warn($"塔主形象：挂顶栏头像失败，塔主顶栏仍显示角色头像：{e.Message}"); }
        }
        var vote = GameReflection.FindMethod("ShouldDisplayPlayerVote", "NMapPoint");
        if (vote != null)
        {
            try { harmony.Patch(vote, postfix: new HarmonyMethod(typeof(MasterPresence).GetMethod(nameof(AfterShouldDisplayVote), GameReflection.All)!)); }
            catch (Exception e) { Log.Warn($"塔主形象：挂地图投票标记失败，地图上仍显示塔主的角色标记：{e.Message}"); }
        }
        var marker = GameReflection.FindMethod("Initialize", "NMapMarker");
        if (marker != null)
        {
            try { harmony.Patch(marker, postfix: new HarmonyMethod(typeof(MasterPresence).GetMethod(nameof(AfterMapMarker), GameReflection.All)!)); }
            catch (Exception e) { Log.Warn($"塔主形象：挂地图位置标记失败：{e.Message}"); }
        }
        var ready = GameReflection.FindMethod("_Ready", "NCreature");
        if (ready != null)
        {
            try { harmony.Patch(ready, postfix: new HarmonyMethod(typeof(MasterPresence).GetMethod(nameof(AfterCreatureReady), GameReflection.All)!)); }
            catch (Exception e) { Log.Warn($"塔主形象：挂 NCreature._Ready 失败，开战时塔主可能闪一下：{e.Message}"); }
        }
        try
        {
            ((G.SceneTree)G.Engine.GetMainLoop()).ProcessFrame += OnFrame;
        }
        catch (Exception e) { Log.Warn($"塔主形象：挂每帧检查失败，画面上不会显示塔主形象：{e.Message}"); }
    }

    /// <summary>塔主战后：直接写回满血（原版复活会播动画和回血特效）；StayDead 时不复活。</summary>
    internal static bool SkipMasterRevive(object __instance, ref Task __result)
    {
        if (Test2MasterOffField.MasterId is not { } master || Test2MasterOffField.NetIdOf(__instance) != master) return true;
        __result = Task.CompletedTask;
        if (StayDead) return false;
        try
        {
            if (GameReflection.Get(__instance, "Creature") is { } creature)
                Test2MasterOffField.SetHp(creature, Math.Max(1, Convert.ToInt32(GameReflection.Get(creature, "MaxHp") ?? 1)));
        }
        catch (Exception e) { Log.Warn($"塔主形象：战后写回塔主生命失败：{e.Message}"); }
        return false;
    }

    /// <summary>塔主的角色节点一建好就藏（各端，纯显示）。</summary>
    private static void AfterCreatureReady(object __instance)
    {
        try
        {
            if (Test2MasterOffField.MasterId is not { } master || __instance is not G.CanvasItem item) return;
            var player = GameReflection.Get(__instance, "Entity") is { } entity ? GameReflection.Get(entity, "Player") : null;
            if (player != null && Test2MasterOffField.NetIdOf(player) == master) item.Visible = false;
        }
        catch { /* 纯显示，轮询还会再藏一次 */ }
    }

    /// <summary>塔主本机顶栏左上的角色头像换成塔主头像，关掉角色说明提示（0.0.43：塔主顶栏仍是铁甲头像）。</summary>
    private static void AfterTopBarPortrait(object __instance, object[] __args)
    {
        try
        {
            if (Test2MasterOffField.MasterId is not { } master || __args.FirstOrDefault() is not { } player || Test2MasterOffField.NetIdOf(player) != master) return;
            if (__instance is not G.Node node || Art.Get("master_portrait") is not { } texture) return;
            int replaced = 0;
            var stack = new Stack<G.Node>();
            stack.Push(node);
            while (stack.Count > 0)
            {
                var n = stack.Pop();
                if (n is G.TextureRect rect && rect.Texture != null) { rect.Texture = texture; replaced++; }
                foreach (var child in n.GetChildren()) stack.Push(child);
            }
            Log.Info($"塔主形象：顶栏头像换成塔主（{replaced} 处）");
        }
        catch (Exception e) { Log.Warn($"塔主形象：换顶栏头像失败：{e.Message}"); }
    }

    /// <summary>地图格子上不显示塔主的投票头像（塔主自动跟随，不是真的在投票）。</summary>
    private static void AfterShouldDisplayVote(object[] __args, ref bool __result)
    {
        if (__result && Test2MasterOffField.MasterId is { } master && __args.FirstOrDefault() is { } player && Test2MasterOffField.NetIdOf(player) == master)
            __result = false;
    }

    /// <summary>塔主本机地图上的位置标记换成塔主头像。</summary>
    private static void AfterMapMarker(object __instance, object[] __args)
    {
        try
        {
            if (Test2MasterOffField.MasterId is not { } master || __args.FirstOrDefault() is not { } player || Test2MasterOffField.NetIdOf(player) != master) return;
            if (__instance is G.TextureRect rect && Art.Get("master_portrait") is { } tex) rect.Texture = tex;
        }
        catch { /* 纯显示 */ }
    }

    private static int _frame;

    private static void OnFrame()
    {
        _frame++;
        try
        {
            if (Test2MasterOffField.MasterId is not { } master) return;
            HideInRooms(master); // 每帧：都是静态 Instance，便宜；隔几帧才藏会闪一下
            if (_frame % 10 != 0) return; // 下面的遍历每 10 帧一次
            HideMasterInPlayerList(master);
            HidePortraitTip(master);
            var room = RuntimeNetAction.Required("NCombatRoom").GetProperty("Instance", GameReflection.All)?.GetValue(null) as G.Control;
            if (room == null || !G.GodotObject.IsInstanceValid(room) || !room.IsInsideTree()) { _decoratedRoom = null; return; }
            HideMasterCreature(room, master);
            if (!ReferenceEquals(_decoratedRoom, room)) Decorate(room);
            if (_frame % 10 == 0) UpdateTray();
        }
        catch (Exception e)
        {
            if (_frame % 600 == 0) Log.Warn($"塔主形象：{e.Message}");
        }
    }

    /// <summary>
    /// 商店、篝火、结算画面里的塔主角色（0.0.43 实测商店里两个铁甲、结算画面有塔主的铁甲）。
    /// 商店 NMerchantRoom.PlayerVisuals 和 _players 同顺序；篝火 NRestSiteCharacter.Player；结算画面的 NCreature 看 Entity.Player。
    /// </summary>
    private static void HideInRooms(ulong master)
    {
        if (Instance("NMerchantRoom") is { } shop)
        {
            var players = (GameReflection.Get(shop, "_players") as IEnumerable)?.Cast<object>().ToList();
            var visuals = (GameReflection.Get(shop, "PlayerVisuals") as IEnumerable)?.Cast<object>().ToList();
            if (players != null && visuals != null)
                for (int i = 0; i < players.Count && i < visuals.Count; i++)
                    if (Test2MasterOffField.NetIdOf(players[i]) == master && visuals[i] is G.CanvasItem v && v.Visible) { v.Visible = false; Log.Info("塔主形象：藏起商店里的塔主角色"); }
        }
        if (Instance("NRestSiteRoom") is { } rest && GameReflection.Get(rest, "Characters") is IEnumerable characters)
            foreach (var c in characters.Cast<object>())
                if (c is G.CanvasItem v && v.Visible && Test2MasterOffField.NetIdOf(GameReflection.Get(c, "Player")) == master) { v.Visible = false; Log.Info("塔主形象：藏起篝火边的塔主角色"); }
        if (_gameOver != null && G.GodotObject.IsInstanceValid(_gameOver))
        {
            if (_masterVisuals != null && G.GodotObject.IsInstanceValid(_masterVisuals) && _masterVisuals.Visible) _masterVisuals.Visible = false;
            if (_frame % 5 == 0) HideCreaturesUnder(_gameOver, master);
        }
    }

    private static G.Node? _gameOver;
    private static G.CanvasItem? _masterVisuals;

    /// <summary>
    /// 结算画面出现时登记一下（RunReportPanel 调）。原版 NGameOverScreen.MoveCreaturesToDifferentLayerAndDisableUi 把各角色的
    /// NCreatureVisuals（不是 NCreature）搬到结算画面里（0.0.44 实测塔主的铁甲站在结算画面上），所以先从战斗房间记下塔主的外观节点，之后每帧藏。
    /// </summary>
    internal static void WatchGameOver(G.Node screen)
    {
        _gameOver = screen;
        _masterVisuals = null;
        try
        {
            if (Test2MasterOffField.MasterId is not { } master) return;
            var room = RuntimeNetAction.Required("NCombatRoom").GetProperty("Instance", GameReflection.All)?.GetValue(null);
            if (room == null || GameReflection.Get(room, "CreatureNodes") is not IEnumerable nodes) return;
            foreach (var node in nodes.Cast<object>())
            {
                var player = GameReflection.Get(node, "Entity") is { } e ? GameReflection.Get(e, "Player") : null;
                if (player == null || Test2MasterOffField.NetIdOf(player) != master) continue;
                _masterVisuals = GameReflection.Get(node, "Visuals") as G.CanvasItem;
                if (_masterVisuals != null) _masterVisuals.Visible = false;
            }
            Log.Info($"塔主形象：结算画面{(_masterVisuals != null ? "藏起塔主角色外观" : "没找到塔主角色外观（不在战斗里结束？）")}");
        }
        catch (Exception e) { Log.Warn($"塔主形象：结算画面藏塔主失败：{e.Message}"); }
    }

    private static void HideCreaturesUnder(G.Node root, ulong master)
    {
        var stack = new Stack<G.Node>();
        stack.Push(root);
        while (stack.Count > 0)
        {
            var n = stack.Pop();
            if (n.GetType().Name == "NCreature")
            {
                var player = GameReflection.Get(n, "Entity") is { } e ? GameReflection.Get(e, "Player") : null;
                if (n is G.CanvasItem v && v.Visible && player != null && Test2MasterOffField.NetIdOf(player) == master) v.Visible = false;
                continue;
            }
            foreach (var child in n.GetChildren()) stack.Push(child);
        }
    }

    private static object? Instance(string type)
    {
        var node = RuntimeNetAction.Required(type).GetProperty("Instance", GameReflection.All)?.GetValue(null) as G.Node;
        return node != null && G.GodotObject.IsInstanceValid(node) && node.IsInsideTree() ? node : null;
    }

    /// <summary>塔主本机顶栏头像的悬停说明是角色介绍，关掉（顶栏换局会重建，节点失效就重新找）。</summary>
    private static void HidePortraitTip(ulong master)
    {
        if (!Test3MasterAutoPilot.LocalIsMaster) return;
        if (_tip == null || !G.GodotObject.IsInstanceValid(_tip) || !_tip.IsInsideTree())
        {
            _tip = null;
            var stack = new Stack<G.Node>();
            stack.Push(((G.SceneTree)G.Engine.GetMainLoop()).Root);
            int visited = 0;
            while (stack.Count > 0 && visited++ < 4000 && _tip == null)
            {
                var n = stack.Pop();
                if (n.GetType().Name == "NTopBarPortraitTip") { _tip = n; break; }
                foreach (var child in n.GetChildren()) stack.Push(child);
            }
        }
        if (_tip != null && GameReflection.Get(_tip, "ShowTip") is true)
            try { GameReflection.Set(_tip, "ShowTip", false); } catch { /* 下次再试 */ }
    }

    private static G.Node? _tip;

    private static void HideMasterCreature(G.Control room, ulong master)
    {
        if (GameReflection.Get(room, "CreatureNodes") is not IEnumerable nodes) return;
        foreach (var node in nodes.Cast<object>())
        {
            if (node is not G.CanvasItem item || !item.Visible) continue;
            var entity = GameReflection.Get(node, "Entity");
            var player = entity == null ? null : GameReflection.Get(entity, "Player");
            if (player != null && Test2MasterOffField.NetIdOf(player) == master) item.Visible = false;
        }
    }

    private static void HideMasterInPlayerList(ulong master)
    {
        var stack = new Stack<G.Node>();
        stack.Push(((G.SceneTree)G.Engine.GetMainLoop()).Root);
        int visited = 0;
        while (stack.Count > 0 && visited++ < 4000)
        {
            var node = stack.Pop();
            if (node.GetType().Name == "NMultiplayerPlayerState")
            {
                if (node is G.CanvasItem item && item.Visible && Test2MasterOffField.NetIdOf(GameReflection.Get(node, "Player")) == master)
                    item.Visible = false;
                continue;
            }
            foreach (var child in node.GetChildren()) stack.Push(child);
        }
    }

    /// <summary>在战斗房间右侧、怪物身后放塔主形象。</summary>
    private static void Decorate(G.Control room)
    {
        _decoratedRoom = room;
        var texture = Art.Get("master_figure") ?? Art.Get("master_portrait");
        if (texture == null) return;
        var size = room.Size;
        float height = Art.Get("master_figure") != null ? size.Y * 0.56f : size.Y * 0.30f;
        float width = height * texture.GetWidth() / Math.Max(1, texture.GetHeight());
        // 有切件骨骼（art/rig_master.json）就用会动的塔主，没有就用静态立绘
        _rig = Art.Get("master_figure") != null ? MasterRig.TryCreate(height) : null;
        G.Control figure = _rig?.View ?? new G.TextureRect
        {
            Texture = texture,
            ExpandMode = G.TextureRect.ExpandModeEnum.IgnoreSize,
            StretchMode = G.TextureRect.StretchModeEnum.KeepAspectCentered,
        };
        figure.Size = new G.Vector2(width, height);
        figure.Position = new G.Vector2(size.X - width - size.X * 0.02f, size.Y * 0.70f - height);
        figure.MouseFilter = G.Control.MouseFilterEnum.Ignore;
        figure.Modulate = new G.Color(0.80f, 0.80f, 0.92f, 0.85f);
        figure.PivotOffset = new G.Vector2(width / 2, height);
        // 画在怪物后面（用户反馈塔主挡住怪物）。0.0.47 实测：怪物所在的 EnemyContainer 在 CombatSceneContainer（ZIndex -10）里面，
        // 有效层级是 -10，单给塔主设 -9 反而在怪物前面。所以把塔主放进 EnemyContainer 的父节点、排在 EnemyContainer 前面：
        // 和怪物同一层，按顺序先画，背景（同容器里更前面的节点）仍在它后面。
        var enemies = (GameReflection.Get(room, "EnemyContainer") ?? GameReflection.Get(room, "_enemyContainer")) as G.Node;
        var local = figure.Position;
        if (enemies?.GetParent() is G.CanvasItem parent)
        {
            var global = room.GetGlobalTransform() * local;
            parent.AddChild(figure);
            parent.MoveChild(figure, enemies.GetIndex());
            figure.GlobalPosition = global;
            Log.Info($"塔主形象：放进 {parent.Name}，排在 {enemies.Name} 前面（怪物后面）");
        }
        else
        {
            figure.ZIndex = -9;
            room.AddChild(figure);
            room.MoveChild(figure, 0);
            Log.Warn("塔主形象：找不到怪物容器 EnemyContainer，塔主可能盖住怪物");
        }
        _figure = figure;
        try { BuildTray(room, figure); }
        catch (Exception e) { Log.Warn($"塔主形象：陷阱托盘没建成：{e.Message}"); }
        if (_rig == null) // 骨骼自己会呼吸摆动；静态立绘才用整体上下浮动
        {
            _idle = figure.CreateTween().SetLoops();
            _idle.TweenProperty(figure, "position:y", figure.Position.Y - 8, 1.6).SetTrans(G.Tween.TransitionType.Sine);
            _idle.TweenProperty(figure, "position:y", figure.Position.Y, 1.6).SetTrans(G.Tween.TransitionType.Sine);
        }
        Log.Info($"塔主形象：已放到战斗房间右侧（{(_rig != null ? "骨骼动画" : "静态立绘")}）");
    }

    // ---------------------------------------------------------------- 陷阱托盘（塔主脚边）

    private static G.Control? _tray;
    private static G.Label? _trayCount;
    private static G.HBoxContainer? _trayPlaced;
    private static string _trayKey = "";

    /// <summary>
    /// 用图形代替文字（用户：「塔主手里有几张牌，完全可以在塔主旁边用卡牌再标个数字」）：
    /// 塔主脚边一叠牌背 + 数字 = 手里的陷阱张数；右边每张盖下的陷阱一张小牌背，触发了变红、歪一点。
    /// 放在战斗房间里塔主脚下（怪物、血条、手牌、结束回合按钮之外），说明在悬停。
    /// </summary>
    private static void BuildTray(G.Control room, G.Control figure)
    {
        var tray = new G.HBoxContainer { MouseFilter = G.Control.MouseFilterEnum.Pass, ZIndex = 5 };
        tray.AddThemeConstantOverride("separation", 10);
        var stack = new G.Control { CustomMinimumSize = new G.Vector2(54, 64), MouseFilter = G.Control.MouseFilterEnum.Ignore };
        for (int i = 2; i >= 0; i--) // 三张错开叠起来像一叠牌
        {
            var back = CardBack(40, 56, false, false);
            back.Position = new G.Vector2(i * 4, 6 - i * 3);
            stack.AddChild(back);
        }
        var badge = new G.PanelContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore, Position = new G.Vector2(30, 36) };
        badge.AddThemeStyleboxOverride("panel", SummonPanel.Box(new G.Color(0.10f, 0.08f, 0.04f, 0.95f), SummonPanel.Gold, 1, 11, 0));
        _trayCount = Ui.Value("0", 18, SummonPanel.Gold);
        _trayCount.HorizontalAlignment = G.HorizontalAlignment.Center;
        _trayCount.CustomMinimumSize = new G.Vector2(24, 0);
        badge.AddChild(_trayCount);
        stack.AddChild(badge);
        tray.AddChild(stack);
        _trayPlaced = new G.HBoxContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore, Alignment = G.BoxContainer.AlignmentMode.Center };
        _trayPlaced.AddThemeConstantOverride("separation", 6);
        tray.AddChild(_trayPlaced);
        room.AddChild(tray);
        var rect = figure.GetGlobalRect();
        tray.GlobalPosition = new G.Vector2(rect.Position.X + rect.Size.X * 0.30f, rect.End.Y - 30);
        _tray = tray;
        _trayKey = "";
        MasterInfoHud.TrayShown = true;
    }

    /// <summary>一张小牌背：深蓝底金边，中间一个陷阱牌背图标；fired = 已触发（红、歪）；dim = 看不到/空位。</summary>
    private static G.Control CardBack(float w, float h, bool fired, bool dim)
    {
        var card = new G.PanelContainer { CustomMinimumSize = new G.Vector2(w, h), Size = new G.Vector2(w, h), MouseFilter = G.Control.MouseFilterEnum.Ignore };
        card.AddThemeStyleboxOverride("panel", SummonPanel.Box(fired ? new G.Color(0.45f, 0.10f, 0.12f) : new G.Color(0.07f, 0.09f, 0.16f),
            fired ? new G.Color(1f, 0.5f, 0.45f) : SummonPanel.Gold, 2, 5, 0, shadow: 4));
        if (Art.Icon("icon_trap", Math.Min(w, h) * 0.75f) is { } icon)
        {
            var center = new G.CenterContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore };
            center.AddChild(icon);
            card.AddChild(center);
        }
        if (fired) { card.PivotOffset = new G.Vector2(w / 2, h / 2); card.RotationDegrees = -10; }
        if (dim) card.Modulate = new G.Color(1, 1, 1, 0.45f);
        return card;
    }

    private static void UpdateTray()
    {
        if (_tray == null || !G.GodotObject.IsInstanceValid(_tray) || !_tray.IsInsideTree()) { MasterInfoHud.TrayShown = false; return; }
        var (hand, placed, fired, inFight) = MasterInfoHud.TrayState();
        var key = $"{hand}/{placed}/{fired.Count}/{inFight}";
        if (key == _trayKey) return;
        _trayKey = key;
        _trayCount!.Text = hand >= 0 ? $"{hand}" : "?";
        foreach (var child in _trayPlaced!.GetChildren()) child.QueueFree();
        if (placed < 0) _trayPlaced.AddChild(Ui.Value("?", 20));
        else for (int i = 0; i < placed; i++) _trayPlaced.AddChild(CardBack(28, 40, i < fired.Count, false));
        var tip = new List<string> { "塔主的陷阱", $"左边一叠：塔主手里还有 {(hand >= 0 ? hand.ToString() : "?")} 张陷阱牌。" };
        tip.Add(placed < 0 ? "迷雾香炉在冒烟，看不清这场盖了几张。" : placed == 0 ? "这场没盖陷阱。" : $"右边：这场盖下了 {placed} 张，红色的已经触发。");
        if (fired.Count > 0) tip.Add($"※触发过：{string.Join("、", fired)}");
        if (placed > 0) tip.Add("※里面可能有空陷阱，只是吓唬人。");
        Ui.Tip(_tray, string.Join("\n", tip));
    }

    /// <summary>塔主施法：形象亮一下、放大一点再回来。</summary>
    private static MasterRig? _rig;

    /// <summary>
    /// 塔主做一个动作：cast（举灯施法，给怪物加料）、point（伸手指点，给玩家添堵）、bury（埋陷阱）。
    /// 有骨骼就播完整动画，onHit 在出手那一刻调用；没有就亮一下，onHit 立刻调用。
    /// </summary>
    public static void Act(string anim, Action? onHit = null)
    {
        try
        {
            if (_rig != null && _figure != null && G.GodotObject.IsInstanceValid(_figure)) { _rig.Play(anim, onHit); return; }
            Cast();
        }
        catch { /* 纯显示 */ }
        onHit?.Invoke();
    }

    /// <summary>出牌对应的动作：给玩家的减益、塞牌是指点，其余（给怪物加料、召唤、盲盒）是举灯。</summary>
    internal static string PoseOf(string op) => op is "weak" or "vulnerable" or "frail" or "dazed" or "sap" or "daze_all" or "expose_all" or "slime_gift" or "heckle"
        ? "point" : "cast";

    public static void Cast()
    {
        try
        {
            if (_figure == null || !G.GodotObject.IsInstanceValid(_figure)) return;
            var tween = _figure.CreateTween();
            tween.TweenProperty(_figure, "modulate", new G.Color(1.4f, 1.2f, 1.6f, 1f), 0.12);
            tween.Parallel().TweenProperty(_figure, "scale", new G.Vector2(1.06f, 1.06f), 0.12);
            tween.TweenProperty(_figure, "modulate", new G.Color(0.80f, 0.80f, 0.92f, 0.85f), 0.35);
            tween.Parallel().TweenProperty(_figure, "scale", G.Vector2.One, 0.35);
        }
        catch { /* 纯显示 */ }
    }
}
