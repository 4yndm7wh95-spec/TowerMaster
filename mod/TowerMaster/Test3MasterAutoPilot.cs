using System.Collections;
using System.Reflection;
using HarmonyLib;

namespace TowerMaster;

/// <summary>
/// 测试 3：非战斗环节替塔主自动操作，爬塔玩家不用等塔主。
/// 塔主 = 房主，所以全部在房主自己的客户端上做：用游戏原有的本地接口或动作队列提交「塔主自己的」选择，
/// 走原版同步通道，不改别的玩家的票（依据见 docs/test2-round2-result.md「测试 3 只读调研」）。
///
/// | 环节 | 触发 | 塔主做什么 |
/// | 选路 | 爬塔玩家的投票执行后 | 入队一张同目的地的塔主投票（VoteForMapCoordAction） |
/// | 战斗奖励 | 奖励集合建立后 | SkipLocalRewardsSet（塔主不领奖励） |
/// | 宝箱 | BeginRelicPicking 后 | SkipRelicLocally |
/// | 共享事件 | 爬塔玩家对某页投票后 | ChooseLocalOption 投同一选项 |
/// | 休息处 | BeginRestSite 后 | BeforeLocalRestSiteExited（跳过） |
/// | 换幕 | 爬塔玩家准备后 | SetLocalPlayerReady |
///
/// 另外拦住塔主的手动操作（塔主的选择只能由上面的自动跟随提交）：
/// | 手动选路 | NMapScreen.OnMapPointSelectedLocally | 直接忽略（用户要求，测试 3 实测） |
/// | 领奖励、买东西、删牌、拿宝箱遗物 | SelectLocalReward、OnTryPurchaseWrapper、DoLocalMerchantCardRemoval、PickRelicLocally | 返回失败（设计文档：不给塔主发奖励；开关 test3_block_master_items） |
///
/// 多名爬塔玩家时塔主跟随「最近一个投票的爬塔玩家」，会让这名玩家的票多一份权重；技术验证先这样，正式版再定。
/// 每一步都只记日志不抛异常，失败时退回「需要塔主手动操作」。
/// </summary>
internal static class Test3MasterAutoPilot
{
    private static string? _lastMapVote;
    private static string? _lastEventVote;
    private static string? _lastActReady;

    private static bool _blockItems = true;

    internal static void Apply(Harmony harmony, TestSettings settings)
    {
        _blockItems = settings.Test3BlockMasterItems;
        Prefix(harmony, "OnMapPointSelectedLocally", "NMapScreen", nameof(BlockManualMapVote));
        if (_blockItems)
        {
            Prefix(harmony, "SelectLocalReward", "RewardsSetSynchronizer", nameof(BlockTask));
            Prefix(harmony, "OnTryPurchaseWrapper", "MerchantEntry", nameof(BlockTask));
            Prefix(harmony, "DoLocalMerchantCardRemoval", "OneOffSynchronizer", nameof(BlockTask));
            Prefix(harmony, "PickRelicLocally", "TreasureRoomRelicSynchronizer", nameof(BlockRelicPick));
        }
        _lastMapVote = _lastEventVote = _lastActReady = null;
        Postfix(harmony, "PlayerVotedForMapCoord", "MapSelectionSynchronizer", nameof(AfterMapVote));
        Postfix(harmony, "BeginRewardsSet", "RewardsSetSynchronizer", nameof(AfterBeginRewards));
        Postfix(harmony, "BeginRelicPicking", "TreasureRoomRelicSynchronizer", nameof(AfterBeginRelicPicking));
        Postfix(harmony, "PlayerVotedForSharedOptionIndex", "EventSynchronizer", nameof(AfterSharedEventVote));
        Postfix(harmony, "BeginRestSite", "RestSiteSynchronizer", nameof(AfterBeginRestSite));
        Postfix(harmony, "OnPlayerReady", "ActChangeSynchronizer", nameof(AfterActReady));

        // 宝箱界面的两个原版异常（测试 3 第二轮实测）：不修会让爬塔玩家卡在宝箱里
        Finalizer(harmony, "get_DefaultFocusedControl", "NTreasureRoomRelicCollection", nameof(TreasureFocusFinalizer));
        Finalizer(harmony, "_Input", "NHandImageCollection", nameof(HandInputFinalizer));
    }

    private static void Finalizer(Harmony harmony, string method, string type, string callback)
    {
        var target = GameReflection.FindMethod(method, type);
        if (target == null) { Log.Warn($"测试3：找不到 {type}.{method}，宝箱可能卡住"); return; }
        try
        {
            harmony.Patch(target, finalizer: new HarmonyMethod(typeof(Test3MasterAutoPilot).GetMethod(callback, GameReflection.All)!));
            Log.Info($"测试3：已加异常保护 {GameReflection.Describe(target)}");
        }
        catch (Exception e) { Log.Error($"测试3：给 {type}.{method} 加异常保护失败", e); }
    }

    /// <summary>
    /// 宝箱默认焦点：原版用「玩家在整局里的座位号」去取遗物槽列表。塔主跳过后只摆出一个遗物，
    /// 座位号 1 的爬塔玩家就越界了，打开宝箱的流程中断，继续按钮再也不出现。越界时改为返回第一个遗物槽。
    /// </summary>
    private static Exception? TreasureFocusFinalizer(Exception? __exception, object __instance, ref Godot.Control? __result)
    {
        if (__exception is not ArgumentOutOfRangeException) return __exception;
        var holders = GameReflection.Get(__instance, "_holdersInUse") as IList;
        __result = holders is { Count: > 0 } ? holders[0] as Godot.Control : GameReflection.Get(__instance, "SingleplayerRelicHolder") as Godot.Control;
        Log.Warn($"测试3 宝箱：默认焦点越界（遗物槽 {holders?.Count ?? 0} 个），改用第一个遗物槽");
        return null;
    }

    /// <summary>宝箱手部动画的输入处理：退出联机后本地身份已清空，原版会报「Nullable object must have a value」。忽略这一种。</summary>
    private static Exception? HandInputFinalizer(Exception? __exception) =>
        __exception is InvalidOperationException e && e.Message.Contains("Nullable object must have a value") ? null : __exception;

    private static void Prefix(Harmony harmony, string method, string type, string callback)
    {
        var target = GameReflection.FindMethod(method, type);
        if (target == null) { Log.Warn($"测试3：找不到 {type}.{method}，塔主仍能手动操作这一项"); return; }
        try
        {
            harmony.Patch(target, prefix: new HarmonyMethod(typeof(Test3MasterAutoPilot).GetMethod(callback, GameReflection.All)!));
            Log.Info($"测试3：已拦截 {GameReflection.Describe(target)}");
        }
        catch (Exception e) { Log.Error($"测试3：拦截 {type}.{method} 失败", e); }
    }

    private static void Postfix(Harmony harmony, string method, string type, string callback)
    {
        var target = GameReflection.FindMethod(method, type);
        if (target == null) { Log.Warn($"测试3：找不到 {type}.{method}，这一环节仍要塔主手动操作"); return; }
        try
        {
            harmony.Patch(target, postfix: new HarmonyMethod(typeof(Test3MasterAutoPilot).GetMethod(callback, GameReflection.All)!));
            Log.Info($"测试3：已挂到 {GameReflection.Describe(target)}");
        }
        catch (Exception e) { Log.Error($"测试3：挂 {type}.{method} 失败", e); }
    }

    // ---------------------------------------------------------------- 身份

    /// <summary>本机就是塔主（房主）。</summary>
    internal static bool LocalIsMaster
    {
        get
        {
            try { return GameReflection.Get(GameReflection.Get(Test1bMixedEncounter.Run, "NetService")!, "Type")?.ToString() == "Host"; }
            catch { return false; }
        }
    }

    private static bool IsMaster(object? player) =>
        Test2MasterOffField.MasterId is { } master && Test2MasterOffField.NetIdOf(player) == master;

    /// <summary>当前楼层，用来区分不同房间里同样编号的选项。</summary>
    private static string Floor() =>
        GameReflection.Dump(GameReflection.Get(GameReflection.Get(Test1bMixedEncounter.Run, "State")!, "TotalFloor"));

    private static object? MasterPlayer()
    {
        var master = Test2MasterOffField.MasterId;
        var players = GameReflection.Get(GameReflection.Get(Test1bMixedEncounter.Run, "State")!, "Players") as IEnumerable;
        return players?.Cast<object>().FirstOrDefault(p => Test2MasterOffField.NetIdOf(p) == master);
    }

    /// <summary>在对象（一层）上找某个类型名的成员值。</summary>
    private static object? FindMemberOfType(object owner, string typeName)
    {
        for (var t = owner.GetType(); t != null; t = t.BaseType)
        {
            foreach (var f in t.GetFields(GameReflection.All | BindingFlags.DeclaredOnly))
                if (!f.IsStatic && f.FieldType.Name == typeName && f.GetValue(owner) is { } v) return v;
            foreach (var p in t.GetProperties(GameReflection.All | BindingFlags.DeclaredOnly))
                if (p.PropertyType.Name == typeName && p.GetIndexParameters().Length == 0 && p.GetMethod is { IsStatic: false }
                    && p.GetValue(owner) is { } v) return v;
        }
        return null;
    }

    private static void CallLocal(object synchronizer, string method, params object?[] args)
    {
        RuntimeNetAction.Call(synchronizer, method, args);
    }

    // ---------------------------------------------------------------- 选路

    private static void AfterMapVote(object __instance, object[] __args)
    {
        try
        {
            if (!LocalIsMaster) return;
            var (player, source, destination) = (__args[0], __args[1], __args.Length > 2 ? __args[2] : null);
            if (IsMaster(player)) return; // 塔主自己的票执行时不再跟投
            var key = $"{GameReflection.Dump(source)}→{GameReflection.Dump(destination)}";
            if (key == _lastMapVote) return;

            var master = MasterPlayer() ?? throw new InvalidOperationException("找不到塔主的 Player");
            var queue = FindMemberOfType(Test1bMixedEncounter.Run, "ActionQueueSynchronizer")
                        ?? throw new InvalidOperationException("找不到 ActionQueueSynchronizer");
            var actionType = RuntimeNetAction.Required("VoteForMapCoordAction");
            var ctor = actionType.GetConstructors(GameReflection.All).First(c => c.GetParameters().Length == 3);
            var action = ctor.Invoke([master, source, destination]);
            _lastMapVote = key;
            RuntimeNetAction.Call(queue, "RequestEnqueue", action);
            Log.Info($"测试3 选路：跟随玩家 {Test2MasterOffField.NetIdOf(player)} 投票 {key}");
        }
        catch (Exception e) { Log.Error("测试3 选路：自动投票失败，需要塔主手动选路", e); }
    }

    // ---------------------------------------------------------------- 战斗奖励

    private static void AfterBeginRewards(object __instance)
    {
        try
        {
            if (!LocalIsMaster) return;
            CallLocal(__instance, "SkipLocalRewardsSet");
            Log.Info("测试3 奖励：塔主跳过本次奖励");
        }
        catch (TargetInvocationException e) when (e.InnerException is InvalidOperationException inner
                                                  && inner.Message.Contains("not currently viewing"))
        {
            // 一场会建立多个奖励集合，有的建立时还没显示出来，游戏拒绝跳过。实测无害：显示出来的那组已经跳过，
            // 剩下的离开房间时游戏会自动跳过（RewardsSetSynchronizer.BeforeLeavingRoom）。
            Log.Info("测试3 奖励：这一组奖励还没显示，不用跳过");
        }
        catch (Exception e) { Log.Error("测试3 奖励：自动跳过失败，塔主可以手动跳过", e); }
    }

    // ---------------------------------------------------------------- 拦住塔主的手动操作

    private static bool BlockManualMapVote()
    {
        if (!LocalIsMaster) return true;
        Log.Info("测试3 选路：塔主不能手动选路，已忽略（会自动跟随爬塔玩家）");
        return false;
    }

    /// <summary>返回 Task&lt;bool&gt; 的领取、购买、删牌：塔主一律失败。</summary>
    private static bool BlockTask(MethodBase __originalMethod, ref Task<bool> __result)
    {
        if (!LocalIsMaster) return true;
        __result = Task.FromResult(false);
        Log.Info($"测试3 物品：塔主不能 {__originalMethod.DeclaringType?.Name}.{__originalMethod.Name}，已拦下");
        return false;
    }

    /// <summary>宝箱：塔主只能跳过（index = null），选具体遗物一律拦下；开始选遗物时已经自动跳过了。</summary>
    private static bool BlockRelicPick(object[] __args)
    {
        if (!LocalIsMaster || __args.Length == 0 || __args[0] == null) return true;
        Log.Info("测试3 宝箱：塔主不能拿遗物，已拦下");
        return false;
    }

    // ---------------------------------------------------------------- 宝箱

    private static void AfterBeginRelicPicking(object __instance)
    {
        try
        {
            if (!LocalIsMaster) return;
            CallLocal(__instance, "SkipRelicLocally");
            Log.Info("测试3 宝箱：塔主跳过遗物");
        }
        catch (Exception e) { Log.Error("测试3 宝箱：自动跳过失败，需要塔主手动跳过", e); }
    }

    // ---------------------------------------------------------------- 共享事件

    private static void AfterSharedEventVote(object __instance, object[] __args)
    {
        try
        {
            if (!LocalIsMaster) return;
            var (player, option, page) = (__args[0], Convert.ToInt32(__args[1]), Convert.ToInt32(__args[2]));
            if (IsMaster(player)) return;
            var key = $"{Floor()}:{page}:{option}";
            if (key == _lastEventVote) return;
            _lastEventVote = key;
            CallLocal(__instance, "ChooseLocalOption", option);
            Log.Info($"测试3 事件：跟随玩家 {Test2MasterOffField.NetIdOf(player)} 投第 {page} 页选项 {option}");
        }
        catch (Exception e) { Log.Error("测试3 事件：自动投票失败，需要塔主手动选择", e); }
    }

    // ---------------------------------------------------------------- 休息处

    private static void AfterBeginRestSite(object __instance)
    {
        try
        {
            if (!LocalIsMaster) return;
            CallLocal(__instance, "BeforeLocalRestSiteExited");
            Log.Info("测试3 休息处：塔主跳过");
        }
        catch (Exception e) { Log.Error("测试3 休息处：自动跳过失败，需要塔主手动选择", e); }
    }

    // ---------------------------------------------------------------- 换幕

    private static void AfterActReady(object __instance, object[] __args)
    {
        try
        {
            if (!LocalIsMaster || IsMaster(__args[0])) return;
            var key = GameReflection.Dump(__args[1]);
            if (key == _lastActReady) return;
            _lastActReady = key;
            CallLocal(__instance, "SetLocalPlayerReady");
            Log.Info($"测试3 换幕：跟随玩家 {Test2MasterOffField.NetIdOf(__args[0])} 准备，第 {__args[1]} 幕");
        }
        catch (Exception e) { Log.Error("测试3 换幕：自动准备失败，需要塔主手动继续", e); }
    }
}
