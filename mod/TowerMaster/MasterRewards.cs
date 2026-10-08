using System.Collections;
using System.Reflection;

namespace TowerMaster;

/// <summary>
/// 塔主牌的成长：精英、Boss 战胜利后，塔主像玩家拿卡牌奖励一样 3 选 1（可以跳过），选中的加进牌组。
/// 用原版的选牌界面 CardSelectCmd.FromChooseACardScreen（药水、事件里「选一张牌」用的那个），不做自建面板。
/// 流程：房主定候选（按种子和场次，各局不同、读档相同），发 reward 指令（NonCombat）；各端在指令里建候选牌、
/// 打开选牌（只有塔主自己的屏幕上能选，原版负责把选择同步给其它端），选完注销候选牌；房主记账本、发新牌组。
/// </summary>
internal static class MasterRewards
{
    internal const int OfferSize = 3;

    /// <summary>候选：奖励牌池里随机 3 种（同一场固定）。</summary>
    internal static List<string> Offer(ulong seed, int battle)
    {
        var pool = MasterCards.RewardPool.ToList();
        var rng = new Random(unchecked((int)(seed ^ (ulong)(battle * 31337 + 7))));
        for (int i = pool.Count - 1; i > 0; i--)
        {
            int j = rng.Next(i + 1);
            (pool[i], pool[j]) = (pool[j], pool[i]);
        }
        return pool.Take(OfferSize).ToList();
    }

    /// <summary>房主：精英/Boss 胜利后发奖励（读档后同一场不再发）。</summary>
    internal static void AfterWin(Core.RoomKind room, ulong seed, int battle, int actNo)
    {
        if (!MasterCards.Enabled || !Test3MasterAutoPilot.LocalIsMaster || room == Core.RoomKind.Monster || MasterLedger.RewardTaken(battle)) return;
        var offer = Offer(seed, battle);
        ThreatPhase.Send(new ThreatCommand(1, 0, 0, actNo, "reward", MonsterId: string.Join(",", offer), Amount: battle));
        Log.Info($"塔主牌：第 {battle} 场（{room}）奖励候选 {string.Join("、", offer)}");
    }

    /// <summary>各端执行 reward 指令。</summary>
    internal static async Task Execute(ThreatCommand c, object action, string tag)
    {
        var state = GameReflection.Get(Test1bMixedEncounter.Run, "State");
        var master = MasterHand.MasterPlayer();
        if (state == null || master == null) { Log.Warn($"{tag}：找不到塔主，奖励跳过"); return; }
        var cardModel = GameReflection.TypesNamed("CardModel").First(t => t.IsAbstract);
        var create = state.GetType().GetMethods(GameReflection.All).First(m => m.Name == "CreateCard" && !m.IsGenericMethod && m.GetParameters().Length == 2);
        var remove = state.GetType().GetMethods(GameReflection.All).FirstOrDefault(m => m.Name == "RemoveCard" && m.GetParameters().Length == 1);
        var list = (IList)Activator.CreateInstance(typeof(List<>).MakeGenericType(cardModel))!;
        foreach (var op in (c.MonsterId ?? "").Split(',', StringSplitOptions.RemoveEmptyEntries))
            if (MasterCards.TypeOf($"act:{op}@{Math.Clamp(c.Round, 1, 3)}") is { } type)
                list.Add(create.Invoke(state, [MasterCards.Canonical(type), master]));
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
        catch (Exception e) { Log.Error($"{tag}：塔主奖励选牌失败（这次没有奖励）", e); }
        finally
        {
            foreach (var card in list) // 候选牌只是展示用：都注销，选中的由牌组指令按规范重建
            {
                try { remove?.Invoke(state, [card]); } catch { /* 已经不在了 */ }
            }
        }
        var op2 = MasterCards.DefOf(chosen)?.Op;
        Log.Info($"{tag}：塔主奖励 {(op2 != null ? $"选了 {MasterCards.DefOf(chosen)!.Title}" : "跳过")}");
        if (Test3MasterAutoPilot.LocalIsMaster)
        {
            MasterLedger.TakeReward(c.Amount, op2);
            if (op2 != null) MasterDeck.Publish("塔主选了奖励牌");
        }
    }
}
