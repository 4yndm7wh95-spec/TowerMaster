using HarmonyLib;
using G = Godot;

namespace TowerMaster;

/// <summary>
/// 联机大厅里的塔主身份（用户反馈「随便选个角色都能当塔主很奇怪」）。原版开局要求每名玩家都有角色，所以房主后台仍固定一个角色，只是谁都看不到：
/// - 房主（塔主）：大厅建好后自动选第一个可用角色，之后不能再换；角色按钮、角色介绍、角色背景藏起来，换成「你是塔主」说明面板。
///   用原版 NCharacterSelectScreen.SelectCharacter 选（会走 StartRunLobby.SetLocalCharacter 同步），准备/出发流程不变。
/// - 所有人：角色按钮上不显示房主的选择标记（RefreshButtonSelectionForPlayer 跳过房主）；玩家栏里房主那一格显示塔主头像和「塔主」。
/// 依据：docs/ui-043-result.md 7.1（NCharacterSelectScreen.cs:647/485、StartRunLobby.cs:593/642、NGame.cs:871）。
/// </summary>
internal static class MasterLobby
{
    private static ulong? _hostId;
    private static G.Node? _hostScreen;
    private static bool _allowSelect;

    internal static void Apply(Harmony harmony)
    {
        Patch(harmony, "InitializeMultiplayerAsHost", "NCharacterSelectScreen", postfix: nameof(AfterHostInit));
        Patch(harmony, "InitializeMultiplayerAsClient", "NCharacterSelectScreen", postfix: nameof(AfterClientInit));
        Patch(harmony, "SelectCharacter", "NCharacterSelectScreen", prefix: nameof(BeforeSelectCharacter));
        Patch(harmony, "RefreshButtonSelectionForPlayer", "NCharacterSelectScreen", prefix: nameof(BeforeRefreshButtonSelection));
        // 玩家栏：原版 OnPlayerChanged 先 SetCharacter 再 RefreshVisuals，改在 RefreshVisuals 之后（0.0.44 实测挂 SetCharacter 被覆盖）
        Patch(harmony, "RefreshVisuals", "NRemoteLobbyPlayer", postfix: nameof(AfterRemotePlayerCharacter));
        Patch(harmony, "InitializeAsHost", "NMultiplayerLoadGameScreen", postfix: nameof(AfterLoadHostInit));
        Patch(harmony, "InitializeAsClient", "NMultiplayerLoadGameScreen", postfix: nameof(AfterClientInit));
    }

    private static void Patch(Harmony harmony, string method, string type, string? prefix = null, string? postfix = null)
    {
        var target = GameReflection.FindMethod(method, type);
        if (target == null) { Log.Warn($"塔主大厅：找不到 {type}.{method}，大厅里塔主身份这一处不生效"); return; }
        try
        {
            harmony.Patch(target,
                prefix: prefix == null ? null : new HarmonyMethod(typeof(MasterLobby).GetMethod(prefix, GameReflection.All)!),
                postfix: postfix == null ? null : new HarmonyMethod(typeof(MasterLobby).GetMethod(postfix, GameReflection.All)!));
        }
        catch (Exception e) { Log.Error($"塔主大厅：挂 {type}.{method} 失败", e); }
    }

    private static ulong? HostIdOf(object? service)
    {
        try
        {
            return GameReflection.Get(service!, "Type")?.ToString() switch
            {
                "Host" => Convert.ToUInt64(GameReflection.Get(service!, "NetId")),
                "Client" => Convert.ToUInt64(GameReflection.Get(service!, "HostNetId")),
                _ => null,
            };
        }
        catch { return null; }
    }

    private static ulong? HostId => _hostId ?? Test2MasterOffField.MasterId;

    private static void AfterClientInit(object[] __args)
    {
        _hostScreen = null;
        _hostId = HostIdOf(__args.FirstOrDefault());
        Log.Info($"塔主大厅：加入大厅，房主（塔主）{_hostId}");
    }

    private static void AfterHostInit(object __instance, object[] __args)
    {
        _hostId = HostIdOf(__args.FirstOrDefault());
        if (__instance is not G.Node screen) return;
        _hostScreen = screen;
        Log.Info($"塔主大厅：建房，本机是塔主 {_hostId}");
        int frames = 0;
        void Tick()
        {
            if (!G.GodotObject.IsInstanceValid(screen) || ++frames > 600)
            {
                SummonPanel.Tree.ProcessFrame -= Tick;
                if (frames > 600) Log.Warn("塔主大厅：10 秒内没等到角色按钮，房主大厅保持原版");
                return;
            }
            if (!screen.IsInsideTree() || frames < 3) return;
            try
            {
                if (!SetUpHost(screen)) return;
            }
            catch (Exception e) { Log.Error("塔主大厅：房主大厅改造失败（还能按原版选角色）", e); }
            SummonPanel.Tree.ProcessFrame -= Tick;
        }
        SummonPanel.Tree.ProcessFrame += Tick;
    }

    /// <summary>多人读档大厅（房主）：藏角色介绍和背景，放塔主说明（读档不用选角色）。</summary>
    private static void AfterLoadHostInit(object __instance, object[] __args)
    {
        _hostId = HostIdOf(__args.FirstOrDefault());
        _hostScreen = null;
        if (__instance is not G.Control screen) return;
        Log.Info($"塔主大厅：读档建房，本机是塔主 {_hostId}");
        int frames = 0;
        void Tick()
        {
            if (!G.GodotObject.IsInstanceValid(screen) || ++frames > 600) { SummonPanel.Tree.ProcessFrame -= Tick; return; }
            if (!screen.IsInsideTree() || frames < 3) return;
            SummonPanel.Tree.ProcessFrame -= Tick;
            try
            {
                foreach (var name in new[] { "_infoPanel", "_bgContainer" })
                    if (GameReflection.Get(screen, name) is G.CanvasItem item) item.Visible = false;
                screen.AddChild(Notice(loading: true));
                Log.Info("塔主大厅：读档大厅角色界面换成塔主说明");
            }
            catch (Exception e) { Log.Error("塔主大厅：读档大厅改造失败", e); }
        }
        SummonPanel.Tree.ProcessFrame += Tick;
    }

    /// <summary>房主：选第一个可用角色、藏角色相关界面、放塔主说明。按钮还没建好返回 false（下一帧再试）。</summary>
    private static bool SetUpHost(G.Node screen)
    {
        if (GameReflection.Get(screen, "_charButtonContainer") is not G.Control buttons) return false;
        var random = GameReflection.Get(screen, "_randomCharacterButton");
        var first = buttons.FindChildren("*", "", true, false).Cast<G.Node>()
            .FirstOrDefault(b => b.GetType().Name == "NCharacterSelectButton" && !ReferenceEquals(b, random)
                                 && GameReflection.Get(b, "IsLocked") is not true && GameReflection.Get(b, "Character") != null);
        if (first == null) return false;
        if (GameReflection.Get(screen, "_selectedButton") == null)
        {
            _allowSelect = true;
            try { RuntimeNetAction.Call(screen, "SelectCharacter", first, GameReflection.Get(first, "Character")); }
            finally { _allowSelect = false; }
        }
        foreach (var name in new[] { "_charButtonContainer", "_infoPanel", "_bgContainer" })
            if (GameReflection.Get(screen, name) is G.CanvasItem item) item.Visible = false;
        if (screen is G.Control root) root.AddChild(Notice());
        Log.Info($"塔主大厅：房主后台固定角色 {GameReflection.Get(first, "Character")?.GetType().Name}，角色界面换成塔主说明");
        return true;
    }

    private static G.Control Notice(bool loading = false)
    {
        // 左上固定位置（0.0.44 用 CenterLeft 锚点加偏移，实际落到屏幕下半、压住进阶说明、下半截出界）
        var holder = new G.MarginContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore };
        holder.SetAnchorsPreset(G.Control.LayoutPreset.TopLeft);
        holder.Position = new G.Vector2(110, 150);
        var panel = new G.PanelContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore, CustomMinimumSize = new G.Vector2(720, 0) };
        panel.AddThemeStyleboxOverride("panel", SummonPanel.Box(SummonPanel.PanelBg, SummonPanel.Gold, 2, 16, 28, shadow: 20));
        var box = new G.VBoxContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore };
        box.AddThemeConstantOverride("separation", 14);
        var head = new G.HBoxContainer { MouseFilter = G.Control.MouseFilterEnum.Ignore };
        head.AddThemeConstantOverride("separation", 18);
        if (Art.Get("master_portrait") is { } tex)
            head.AddChild(new G.TextureRect { Texture = tex, ExpandMode = G.TextureRect.ExpandModeEnum.IgnoreSize, StretchMode = G.TextureRect.StretchModeEnum.KeepAspectCentered, CustomMinimumSize = new G.Vector2(80, 80), MouseFilter = G.Control.MouseFilterEnum.Ignore });
        head.AddChild(SummonPanel.Text("你是塔主", 40, SummonPanel.Gold));
        box.AddChild(head);
        foreach (var line in new[]
                 {
                     "你不上场打牌，这座塔归你管。",
                     "· 每场战斗前：花召唤点挑怪物、盖陷阱。",
                     "· 战斗中的塔主回合：用塔主牌给怪物加料、给玩家添堵。",
                     "· 宝箱、商店、篝火、事件：塔主也有自己的收获。",
                     loading ? "读档继续：大家都准备后按出发。" : "爬塔玩家都选好角色并准备后，按出发开始。",
                 })
        {
            var label = SummonPanel.Text(line, 20, SummonPanel.TextMain);
            label.MouseFilter = G.Control.MouseFilterEnum.Ignore;
            box.AddChild(label);
        }
        panel.AddChild(box);
        holder.AddChild(panel);
        SummonPanel.ApplyGameFont(holder);
        return holder;
    }

    /// <summary>房主固定角色后不能再换（点角色按钮、随机按钮都不响应）。</summary>
    private static bool BeforeSelectCharacter(object __instance)
    {
        if (_allowSelect || _hostScreen == null || !ReferenceEquals(__instance, _hostScreen)) return true;
        return GameReflection.Get(__instance, "_selectedButton") == null; // 还没选上时放行（兜底），选上后锁住
    }

    /// <summary>角色按钮上不显示房主（塔主）的选择标记。</summary>
    private static bool BeforeRefreshButtonSelection(object[] __args)
    {
        try
        {
            if (HostId is not { } host || __args.FirstOrDefault() is not { } player) return true;
            return Convert.ToUInt64(GameReflection.Get(player, "id")) != host;
        }
        catch { return true; }
    }

    /// <summary>玩家栏里房主那一格：塔主头像、「塔主」。</summary>
    private static void AfterRemotePlayerCharacter(object __instance)
    {
        try
        {
            if (HostId is not { } host || Convert.ToUInt64(GameReflection.Get(__instance, "PlayerId")) != host) return;
            if (GameReflection.Get(__instance, "_characterIcon") is G.TextureRect icon && Art.Get("master_portrait") is { } tex) icon.Texture = tex;
            if (GameReflection.Get(__instance, "_characterLabel") is { } label) GameReflection.Set(label, "Text", "塔主");
        }
        catch (Exception e) { Log.Warn($"塔主大厅：玩家栏塔主标记失败：{e.Message}"); }
    }
}
