using System.Collections;
using HarmonyLib;
using TowerMaster.Core;

namespace TowerMaster;

/// <summary>
/// 塔主的牌组 = 塔主牌（<see cref="MasterCards"/>）：本幕等级的行动牌 + 手里的陷阱牌。原版牌组按钮里看到的就是这些。
/// - 新开一局（RunManager.SetUpNewMultiplayer 之后）：各端都把塔主的英雄牌换成第一幕的行动牌（输入相同，结果相同，不用同步）。
/// - 之后有变化（每幕挑完陷阱、陷阱触发后用掉、击倒奖励）：房主算出整副牌，发一条 deck 指令（NonCombat），各端照着换。
/// 读档不动牌组：存档里就是塔主牌。
/// </summary>
internal static class MasterDeck
{
    private static string? _lastSent;
    private static bool _patched;

    internal static void Apply(Harmony harmony)
    {
        if (_patched) return;
        _patched = true;
        var setUp = RuntimeNetAction.Required("RunManager").GetMethods(GameReflection.All).FirstOrDefault(m => m.Name == "SetUpNewMultiplayer");
        if (setUp == null) { Log.Warn("塔主牌组：找不到 RunManager.SetUpNewMultiplayer，新局不换牌组"); return; }
        harmony.Patch(setUp, postfix: new HarmonyMethod(typeof(MasterDeck).GetMethod(nameof(AfterNewRun), GameReflection.All)!));
    }

    /// <summary>换局/读档：忘掉上次发过的牌组（0.0.36 实测读档后同样的牌组不再发，实际牌组和账本对不上）。</summary>
    internal static void ResetRun() => _lastSent = null;

    /// <summary>某一幕塔主牌组的卡（行动牌 + 陷阱牌）的 key 列表。</summary>
    /// <param name="actions">行动牌（操作名）；不给就是初始 9 张加 extras。</param>
    internal static List<string> Keys(int actNo, IEnumerable<TrapCard> traps, IEnumerable<string>? extras = null, IEnumerable<string>? actions = null) =>
        (actions ?? MasterCards.StartingActions.Concat(extras ?? [])).Select(op => $"act:{op}@{Math.Clamp(actNo, 1, 3)}")
            .Concat(traps.Select(t => $"trap:{t.Id}@{Math.Clamp(t.Tier, 1, 3)}")).ToList();

    private static void AfterNewRun(object[] __args)
    {
        try
        {
            _lastSent = null;
            if (__args.FirstOrDefault(a => a?.GetType().Name == "RunState") is not { } state) return;
            var master = Master(state);
            if (master == null) { Log.Warn("塔主牌组：新局里找不到塔主"); return; }
            Replace(master, Keys(1, []), "新的一局", state);
            StripRelics(master, "新的一局");
        }
        catch (Exception e) { Log.Error("塔主牌组：新局换牌组失败（塔主仍是英雄牌）", e); }
    }

    /// <summary>房主：按账本算出整副牌，有变化就发 deck 指令。</summary>
    internal static void Publish(string reason)
    {
        if (!MasterCards.Enabled || !Test3MasterAutoPilot.LocalIsMaster) return;
        try
        {
            var keys = string.Join(",", Keys(MasterLedger.Wallet?.ActNo ?? 1, MasterLedger.Traps, actions: MasterLedger.ActionCards()));
            if (keys == _lastSent) return;
            _lastSent = keys;
            ThreatPhase.Send(new ThreatCommand(1, 0, 0, ThreatPhase.Round, "deck", MonsterId: keys));
            Log.Info($"塔主牌组：{reason}，发出新牌组（{keys.Split(',').Length} 张）");
        }
        catch (Exception e) { Log.Error("塔主牌组：发送失败", e); }
    }

    /// <summary>各端执行 deck 指令。</summary>
    internal static void Execute(string? list, string tag)
    {
        if (!MasterCards.Enabled) { Log.Warn($"{tag}：本机没开塔主牌（master_cards），忽略牌组指令——两端设置要一致"); return; }
        var state = GameReflection.Get(Test1bMixedEncounter.Run, "State");
        var master = state == null ? null : Master(state);
        if (master == null) { Log.Warn($"{tag}：找不到塔主，牌组没换"); return; }
        Replace(master, (list ?? "").Split(',', StringSplitOptions.RemoveEmptyEntries).ToList(), tag, state);
        StripRelics(master, tag); // 旧存档里塔主还带着角色遗物的，下一次换牌组时一起去掉（各端同一条指令，结果一致）
    }

    /// <summary>
    /// 去掉塔主身上的原版遗物（角色初始遗物）。塔主不是那个角色，遗物还会生效：铁甲的燃烧之血战后给隐藏的塔主回 6 血，
    /// 原塔主位置飘绿色数字（0.0.43 实测）。用 Player.RemoveRelicInternal(relic, silent: true)，不播动画；各端在同一时刻执行。
    /// </summary>
    internal static void StripRelics(object master, string reason)
    {
        try
        {
            var relics = (GameReflection.Get(master, "Relics") as IEnumerable)?.Cast<object>().ToList() ?? [];
            if (relics.Count == 0) return;
            var remove = master.GetType().GetMethods(GameReflection.All).First(m => m.Name == "RemoveRelicInternal" && m.GetParameters().Length == 2);
            foreach (var relic in relics) remove.Invoke(master, [relic, true]);
            Log.Info($"塔主牌组：{reason}，去掉塔主的原版遗物 {string.Join("、", relics.Select(r => r.GetType().Name))}");
        }
        catch (Exception e) { Log.Warn($"塔主牌组：去掉塔主原版遗物失败（战后可能飘回血数字）：{e.InnerException?.Message ?? e.Message}"); }
    }

    private static object? Master(object state)
    {
        var id = Test2MasterOffField.MasterId;
        if (id == null) return null;
        return (GameReflection.Get(state, "Players") as IEnumerable)?.Cast<object>().FirstOrDefault(p => Test2MasterOffField.NetIdOf(p) == id);
    }

    /// <summary>
    /// 清空塔主的牌组，换成这些卡。牌必须经对局状态登记（RunState.CreateCard：克隆、登记、设归属），
    /// 旧牌要 RunState.RemoveCard 注销——0.0.29/0.0.30 实测只放进牌组不登记时，新牌没有 Owner，
    /// 开局生成地图遍历钩子监听者（RunState.Contains 读 card.Owner.IsActiveForHooks）空引用，两端开不了局。
    /// </summary>
    internal static void Replace(object player, IReadOnlyList<string> keys, string reason, object? runState = null)
    {
        var state = runState ?? GameReflection.Get(Test1bMixedEncounter.Run, "State") ?? throw new InvalidOperationException("没有对局状态");
        var deck = GameReflection.Get(player, "Deck") ?? throw new InvalidOperationException("玩家没有 Deck");
        var old = (GameReflection.Get(deck, "Cards") as IEnumerable)?.Cast<object>().ToList() ?? [];
        RuntimeNetAction.Call(deck, "Clear", true);
        var remove = state.GetType().GetMethods(GameReflection.All).FirstOrDefault(m => m.Name == "RemoveCard" && m.GetParameters().Length == 1);
        foreach (var card in old)
        {
            try { remove?.Invoke(state, [card]); }
            catch (Exception e) { Log.Warn($"塔主牌组：注销旧牌 {card.GetType().Name} 失败：{e.InnerException?.Message ?? e.Message}"); }
        }
        var create = state.GetType().GetMethods(GameReflection.All).First(m => m.Name == "CreateCard" && !m.IsGenericMethod && m.GetParameters().Length == 2);
        foreach (var key in keys)
        {
            var type = MasterCards.TypeOf(key) ?? throw new KeyNotFoundException($"没有塔主牌 {key}");
            var card = create.Invoke(state, [MasterCards.Canonical(type), player])!;
            RuntimeNetAction.Call(deck, "AddInternal", card, -1, true);
        }
        MasterInfoHud.OnDeck(keys);
        Log.Info($"塔主牌组：{reason}，换成 {keys.Count} 张：{string.Join("、", keys.Select(k => MasterCards.TypeOf(k) is { } t ? MasterCards.DefOf(MasterCards.Canonical(t))?.Title : k))}");
    }
}
