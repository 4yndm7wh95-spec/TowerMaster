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

    private static int _frame;

    private static void OnFrame()
    {
        if (++_frame % 10 != 0) return; // 每 10 帧看一次就够
        try
        {
            if (Test2MasterOffField.MasterId is not { } master) return;
            HideMasterInPlayerList(master);
            var room = RuntimeNetAction.Required("NCombatRoom").GetProperty("Instance", GameReflection.All)?.GetValue(null) as G.Control;
            if (room == null || !G.GodotObject.IsInstanceValid(room) || !room.IsInsideTree()) { _decoratedRoom = null; return; }
            HideMasterCreature(room, master);
            if (!ReferenceEquals(_decoratedRoom, room)) Decorate(room);
        }
        catch (Exception e)
        {
            if (_frame % 600 == 0) Log.Warn($"塔主形象：{e.Message}");
        }
    }

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
        float height = Art.Get("master_figure") != null ? size.Y * 0.62f : size.Y * 0.30f;
        float width = height * texture.GetWidth() / Math.Max(1, texture.GetHeight());
        var figure = new G.TextureRect
        {
            Texture = texture,
            ExpandMode = G.TextureRect.ExpandModeEnum.IgnoreSize,
            StretchMode = G.TextureRect.StretchModeEnum.KeepAspectCentered,
            Size = new G.Vector2(width, height),
            Position = new G.Vector2(size.X - width - size.X * 0.02f, size.Y * 0.70f - height),
            MouseFilter = G.Control.MouseFilterEnum.Ignore,
            Modulate = new G.Color(0.85f, 0.85f, 0.95f, 0.92f),
            PivotOffset = new G.Vector2(width / 2, height),
        };
        room.AddChild(figure);
        room.MoveChild(figure, 0); // 画在怪物下面
        _figure = figure;
        _idle = figure.CreateTween().SetLoops();
        _idle.TweenProperty(figure, "position:y", figure.Position.Y - 8, 1.6).SetTrans(G.Tween.TransitionType.Sine);
        _idle.TweenProperty(figure, "position:y", figure.Position.Y, 1.6).SetTrans(G.Tween.TransitionType.Sine);
        Log.Info("塔主形象：已放到战斗房间右侧");
    }

    /// <summary>塔主施法：形象亮一下、放大一点再回来。</summary>
    public static void Cast()
    {
        try
        {
            if (_figure == null || !G.GodotObject.IsInstanceValid(_figure)) return;
            var tween = _figure.CreateTween();
            tween.TweenProperty(_figure, "modulate", new G.Color(1.4f, 1.2f, 1.6f, 1f), 0.12);
            tween.Parallel().TweenProperty(_figure, "scale", new G.Vector2(1.06f, 1.06f), 0.12);
            tween.TweenProperty(_figure, "modulate", new G.Color(0.85f, 0.85f, 0.95f, 0.92f), 0.35);
            tween.Parallel().TweenProperty(_figure, "scale", G.Vector2.One, 0.35);
        }
        catch { /* 纯显示 */ }
    }
}
