using System.Collections;
using System.Reflection;
using HarmonyLib;
using TowerMaster.Core;

namespace TowerMaster;

/// <summary>
/// 塔主牌的成长和整备，全部用原版「选一张牌」界面（CardSelectCmd.FromChooseACardScreen，可以跳过），不做自建面板：
///
/// | 时机 | 塔主做什么 |
/// | 精英、Boss 战胜利后（等原版奖励界面出来） | 免费 3 选 1 拿一张新行动牌 |
/// | 宝箱房（塔主宝箱） | 免费 3 选 1 拿一件塔主遗物（候选是「遗物牌」；遗物拿完了或没生成成功就退回拿行动牌） |
/// | 商店（陷阱商店） | 花召唤点买 1 张：2 张行动牌 + 1 张陷阱牌 |
/// | 休息处 | 从牌组里删 1 张行动牌（精简牌组） |
///
/// 流程：房主定候选（按种子和房间，读档相同），发 reward 指令（NonCombat）；各端在指令里建候选、打开选牌
/// （只有塔主屏幕上能选，原版把选择同步给其它端），选完注销候选；房主记账本、发新牌组。
/// 指令字段：MonsterId = 候选（act:操作名 / trap:陷阱），Round = 等级（幕），Amount = 本次编号（读档去重），
/// Monster = 种类（0 免费拿、1 购买、2 删牌），Price = 价格。
/// </summary>
internal static class MasterRewards
{
    internal const int OfferSize = 3;
    internal const int KindFree = 0, KindBuy = 1, KindRemove = 2, KindRelic = 3;
    private static bool _patched;

    internal static void Apply(Harmony harmony)
    {
        if (_patched) return;
        _patched = true;
        var loaded = GameReflection.FindMethod("AfterRoomIsLoaded", "NMerchantRoom");
        if (loaded != null) harmony.Patch(loaded, postfix: new HarmonyMethod(typeof(MasterRewards).GetMethod(nameof(AfterMerchantLoaded), GameReflection.All)!));
        else Log.Warn("塔主商店：找不到 NMerchantRoom.AfterRoomIsLoaded，商店里塔主不能买牌");
    }

    /// <summary>候选：奖励牌池里随机 n 种（同一个房间固定）。</summary>
    internal static List<string> Offer(ulong seed, int id, int count = OfferSize, IEnumerable<string>? from = null)
    {
        var pool = (from ?? MasterCards.RewardPool).Distinct().ToList();
        var rng = new Random(unchecked((int)(seed ^ (ulong)(id * 31337 + 7))));
        for (int i = pool.Count - 1; i > 0; i--)
        {
            int j = rng.Next(i + 1);
            (pool[i], pool[j]) = (pool[j], pool[i]);
        }
        return pool.Take(count).ToList();
    }

    // ---------------------------------------------------------------- 触发（房主）

    /// <summary>精英/Boss 胜利后（读档后同一场不再发）。</summary>
    internal static void AfterWin(RoomKind room, ulong seed, int battle, int actNo)
    {
        if (!Ready() || room == RoomKind.Monster || MasterLedger.RewardTaken(battle)) return;
        var offer = Offer(seed, battle).Select(op => $"act:{op}").ToList();
        Log.Info($"塔主牌：第 {battle} 场（{room}）奖励候选 {string.Join("、", offer)}，等原版奖励界面出来后再发");
        WhenRewardsShown(() => Send(offer, actNo, battle, KindFree, 0));
    }

    /// <summary>宝箱房：塔主宝箱，免费 3 选 1。</summary>
    internal static void OnTreasure()
    {
        if (!Ready() || Room() is not var (seed, floor, act)) return;
        int id = -(floor * 10 + 1);
        if (MasterLedger.RewardTaken(id)) return;
        var relics = MasterRelics.Enabled ? MasterRelics.Defs.Select(d => d.Id).Except(MasterRelics.Owned()).ToList() : [];
        if (relics.Count > 0)
        {
            var choices = Offer(seed, id, OfferSize, relics).Select(r => $"relic:{r}").ToList();
            Notice("塔主宝箱：选一件塔主遗物（可以跳过）");
            AfterUiSettles(() => Send(choices, 1, id, KindRelic, 0));
            return;
        }
        if (!MasterRelics.Enabled) Log.Warn($"塔主宝箱：塔主遗物没开成（{MasterRelics.FailReason ?? "没有遗物类型"}），改送塔主牌");
        var offer = Offer(seed, id).Select(op => $"act:{op}").ToList();
        Notice("塔主宝箱：选一张塔主牌（可以跳过）");
        AfterUiSettles(() => Send(offer, act, id, KindFree, 0));
    }

    /// <summary>休息处：从牌组里删 1 张行动牌（牌组至少留 5 张）。</summary>
    internal static void OnRest()
    {
        if (!Ready() || Room() is not var (seed, floor, act)) return;
        int id = -(floor * 10 + 3);
        var actions = MasterLedger.ActionCards();
        if (MasterLedger.RewardTaken(id) || actions.Count <= ModEntry.Active.MasterMinDeck) return;
        var offer = Offer(seed, id, OfferSize, actions).Select(op => $"act:{op}").ToList();
        Notice("休息处：选一张塔主牌移出牌组（可以跳过）");
        AfterUiSettles(() => Send(offer, act, id, KindRemove, 0));
    }

    /// <summary>商店：花召唤点买 1 张（2 张行动牌 + 1 张手里没有的陷阱）。召唤点不够就不开。</summary>
    private static void AfterMerchantLoaded()
    {
        try
        {
            if (!Ready() || Room() is not var (seed, floor, act)) return;
            int id = -(floor * 10 + 2), price = ModEntry.Active.MasterShopPrice;
            if (MasterLedger.RewardTaken(id)) return;
            if ((MasterLedger.Wallet?.Points ?? 0) < price)
            {
                Notice($"陷阱商店：召唤点不够 {price}，这次买不了");
                return;
            }
            var traps = TrapCatalog.All.Where(t => t.Effect != TrapEffect.None && MasterLedger.Traps.All(h => h.Id != t.Id)).Select(t => t.Id);
            var offer = Offer(seed, id, 2).Select(op => $"act:{op}").Concat(Offer(seed, id + 1, 1, traps).Select(t => $"trap:{t}")).ToList();
            Notice($"陷阱商店：花 {price} 召唤点买一张塔主牌（可以跳过）");
            AfterUiSettles(() => Send(offer, act, id, KindBuy, price));
        }
        catch (Exception e) { Log.Error("塔主商店：开店失败", e); }
    }

    private static bool Ready()
    {
        if (!MasterCards.Enabled || !Test3MasterAutoPilot.LocalIsMaster) return false;
        MasterLedger.EnsureLoaded(); // 读档后先把账本读回来，再判断这个房间处理过没有、钱够不够
        return true;
    }

    private static (ulong Seed, int Floor, int Act)? Room()
    {
        var state = GameReflection.Get(Test1bMixedEncounter.Run, "State");
        if (state == null) return null;
        var seed = Convert.ToUInt64(GameReflection.Get(GameReflection.Get(state, "Rng")!, "Seed"));
        return (seed, Convert.ToInt32(GameReflection.Get(state, "TotalFloor")), ThreatPhase.ActNoOf(state));
    }

    private static void Send(List<string> offer, int act, int id, int kind, int price)
    {
        try { ThreatPhase.Send(new ThreatCommand(1, 0, 0, act, "reward", Monster: kind, MonsterId: string.Join(",", offer), Amount: id, Price: price)); }
        catch (Exception e) { Log.Error("塔主牌：发送选牌失败", e); }
    }

    /// <summary>塔主屏幕上的提示；测试里换成空操作（没有 Godot 引擎时调界面会让进程崩溃，try 拦不住）。</summary>
    internal static Action<string> NoticeSink = text => SummonPhase.Toast(text);

    private static void Notice(string text)
    {
        Log.Info($"塔主牌：{text}");
        NoticeSink(text);
    }

    // ---------------------------------------------------------------- 时机

    /// <summary>等原版战斗奖励界面压进覆盖栈之后再发（0.0.34 实测：先发会被它盖住、两端卡住）。测试里直接发。</summary>
    internal static Action<Action> WhenRewardsShown = send => WaitFrames(send, RewardsScreenShown, 15, 300, "原版奖励界面");

    /// <summary>等条件成立（最多约 20 秒）再做；测试里条件成立就直接做。</summary>
    internal static Action<Func<bool>, Action> WhenTrue = (ready, act) => WaitFrames(act, ready, 30, 1200, "读档完成");

    /// <summary>非战斗房间：等房间界面稳定（约半秒）再发。测试里直接发。</summary>
    internal static Action<Action> AfterUiSettles = send => WaitFrames(send, () => true, 30, 30, "房间界面");

    private static void WaitFrames(Action send, Func<bool> ready, int settle, int max, string what)
    {
        if (Godot.Engine.GetMainLoop() is not Godot.SceneTree tree) { send(); return; }
        int frames = 0, seenAt = -1;
        void Tick()
        {
            frames++;
            if (seenAt < 0 && ready()) seenAt = frames;
            if ((seenAt >= 0 && frames - seenAt >= settle) || frames > max)
            {
                tree.ProcessFrame -= Tick;
                if (seenAt < 0 && what == "读档完成")
                {
                    // 爬塔玩家那边本来就不是房主，正常；房主等不到才是问题
                    if (Test2MasterOffField.MasterId is { } host && RunNetId() == host) Log.Warn("塔主牌：读档后等了约 20 秒对局还没就绪，没有同步牌组");
                    else Log.Info("塔主牌：本机不是塔主，读档后不需要同步牌组");
                    return;
                }
                Log.Info(seenAt >= 0 ? $"塔主牌：{what}已就绪（第 {seenAt} 帧），打开塔主选牌" : $"塔主牌：没等到{what}，直接打开塔主选牌");
                send();
            }
        }
        tree.ProcessFrame += Tick;
    }

    private static ulong? RunNetId()
    {
        try { return Convert.ToUInt64(GameReflection.Get(GameReflection.Get(Test1bMixedEncounter.Run, "NetService")!, "NetId")); }
        catch { return null; }
    }

    private static bool RewardsScreenShown()
    {
        try
        {
            var stack = GameReflection.TypeNamed("NOverlayStack")?.GetProperty("Instance", GameReflection.All)?.GetValue(null);
            if (stack != null && GameReflection.Get(stack, "_overlays") is IEnumerable overlays)
                return overlays.Cast<object>().Any(o => o.GetType().Name == "NRewardsScreen");
        }
        catch { /* 退回 false，按超时发 */ }
        return false;
    }

    // ---------------------------------------------------------------- 执行（各端）

    internal static async Task Execute(ThreatCommand c, object action, string tag)
    {
        var state = GameReflection.Get(Test1bMixedEncounter.Run, "State");
        var master = MasterHand.MasterPlayer();
        if (state == null || master == null) { Log.Warn($"{tag}：找不到塔主，选牌跳过"); return; }
        int tier = Math.Clamp(c.Round, 1, 3);
        var cardModel = GameReflection.TypesNamed("CardModel").First(t => t.IsAbstract);
        var create = state.GetType().GetMethods(GameReflection.All).First(m => m.Name == "CreateCard" && !m.IsGenericMethod && m.GetParameters().Length == 2);
        var remove = state.GetType().GetMethods(GameReflection.All).FirstOrDefault(m => m.Name == "RemoveCard" && m.GetParameters().Length == 1);
        var list = (IList)Activator.CreateInstance(typeof(List<>).MakeGenericType(cardModel))!;
        foreach (var entry in (c.MonsterId ?? "").Split(',', StringSplitOptions.RemoveEmptyEntries))
        {
            var key = (entry.Contains(':') ? entry : "act:" + entry) + $"@{tier}"; // 0.0.34 的指令只写操作名
            if (MasterCards.TypeOf(key) is { } type) list.Add(create.Invoke(state, [MasterCards.Canonical(type), master]));
        }
        if (list.Count == 0) return;

        object? chosen = null;
        try
        {
            var choose = RuntimeNetAction.Required("CardSelectCmd").GetMethods(BindingFlags.Public | BindingFlags.Static)
                .First(m => m.Name == "FromChooseACardScreen" && m.GetParameters().Length == 4);
            var context = Activator.CreateInstance(RuntimeNetAction.Required("GameActionPlayerChoiceContext"), action)!;
            var task = (Task)choose.Invoke(null, [context, list, master, true])!;
            await task;
            chosen = task.GetType().GetProperty("Result")?.GetValue(task);
        }
        catch (Exception e) when (e is OperationCanceledException || e.InnerException is OperationCanceledException)
        {
            Log.Info($"{tag}：塔主选牌界面被关掉（回菜单/换房间），这次跳过");
        }
        catch (Exception e) { Log.Error($"{tag}：塔主选牌失败（这次跳过）", e); }
        finally
        {
            foreach (var card in list) // 候选牌只是展示用：都注销，牌组由 deck 指令按规范重建
            {
                try { remove?.Invoke(state, [card]); } catch { /* 已经不在了 */ }
            }
        }
        var def = MasterCards.DefOf(chosen);
        string verb = c.Monster switch { KindBuy => "选中要买", KindRemove => "选中要删", _ => "选了" };
        Log.Info($"{tag}：塔主{(def != null ? $"{verb} {def.Title}" : "跳过")}");
        if (def?.Op == "relic") // 遗物：各端在同一条指令里各自给塔主（原版 RelicCmd.Obtain 不广播）
        {
            var relicId = RelicId(def);
            try { await MasterRelics.Obtain(master, relicId, tag); }
            catch (Exception e) { Log.Error($"{tag}：给塔主遗物 {relicId} 失败", e); }
        }
        if (Test3MasterAutoPilot.LocalIsMaster) Record(c, def);
    }

    private static string RelicId(MasterCardDef def) => def.Key["relic:".Length..].Split('@')[0];

    /// <summary>房主记账本、发新牌组。</summary>
    private static void Record(ThreatCommand c, MasterCardDef? def)
    {
        MasterLedger.EnsureLoaded();
        if (def == null) { MasterLedger.MarkReward(c.Amount); return; }
        if (def.Op == "relic")
        {
            MasterLedger.MarkReward(c.Amount);
            if (RelicId(def) == "piggy_bank") MasterLedger.GainPoints(8, "小金库");
            return;
        }
        if (c.Monster == KindRemove) MasterLedger.RemoveAction(c.Amount, def.Op);
        else
        {
            if (c.Monster == KindBuy && !MasterLedger.SpendPoints(c.Price, $"陷阱商店买 {def.Title}"))
            {
                Log.Warn($"塔主商店：召唤点不够，没买成 {def.Title}");
                MasterLedger.MarkReward(c.Amount);
                return;
            }
            if (def.Op == "trap")
            {
                var trap = TrapCatalog.Parse(def.Key["trap:".Length..]);
                if (MasterLedger.Traps.Count < ModEntry.Active.TrapHandLimit) MasterLedger.AddTraps([trap], "陷阱商店");
                else Log.Warn("塔主商店：陷阱手牌满了，这张没放进手里");
                MasterLedger.MarkReward(c.Amount);
            }
            else MasterLedger.TakeReward(c.Amount, def.Op);
        }
        MasterDeck.Publish(c.Monster switch { KindBuy => "陷阱商店买牌", KindRemove => "休息处删牌", _ => "塔主拿了新牌" });
    }
}
