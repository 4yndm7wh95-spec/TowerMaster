using System.Collections;
using TowerMaster.Core;

namespace TowerMaster;

/// <summary>伏击选项。</summary>
internal sealed record AmbushOption(string Id, string Title, string Description, string Art);

/// <summary>
/// 问号房伏击（用户：「问号房出怪应该纳入特殊事件，想一个更有意思的处理方式，而不是简单当普通怪物房」）。
///
/// 问号房走到最后是一场战斗时，原版的遭遇照常出场（专用场景、事件战都不动），塔主没有召唤阶段，
/// 而是在第一个塔主回合开头三选一一张「伏击牌」（原版选牌界面，可以跳过），玩家看到「问号房里有埋伏！」：
/// - 援军：叫一只本幕小怪加入战斗（和摇人同一张名单）；
/// - 伏兵：所有怪物获得 1 点力量和 5 点格挡；
/// - 买路钱：每名玩家失去 10 金币，塔主得到 3 召唤点。
/// 只在地图上的问号点、当前房间是战斗房时触发（事件里打起来的事件战不算）；每场一次，读档不重复（账本记号）。
/// 指令 ambush 是 CombatPlayPhaseOnly（和 begin 一样排在出牌阶段），选牌和效果各端一致。
/// </summary>
internal static class MasterAmbush
{
    internal const int TollGold = 10, TollPoints = 3, BraceStrength = 1, BraceBlock = 5;

    internal static readonly AmbushOption[] Options =
    [
        new("reinforce", "援军", "叫一只本幕小怪加入这场战斗。", "icon_summon"),
        new("brace", "伏兵", $"所有怪物获得 {BraceStrength} 点力量和 {BraceBlock} 点格挡。", "act_strength_all"),
        new("toll", "买路钱", $"每名玩家失去 {TollGold} 金币，塔主得到 {TollPoints} 召唤点。", "icon_summon_point"),
    ];

    /// <summary>房主：第 1 回合 begin 之后调用；是问号房的战斗就发伏击选牌。</summary>
    internal static void OfferIfAmbushRoom()
    {
        try
        {
            if (!MasterCards.Enabled || !Test3MasterAutoPilot.LocalIsMaster) return;
            if (GameReflection.Get(Test1bMixedEncounter.Run, "State") is not { } state || !IsAmbushRoom(state)) return;
            MasterLedger.EnsureLoaded();
            int floor = Convert.ToInt32(GameReflection.Get(state, "TotalFloor") ?? 0);
            int id = -(floor * 10 + 5);
            if (MasterLedger.RewardTaken(id)) return;
            var offer = string.Join(",", Options.Select(o => $"ambush:{o.Id}"));
            ThreatPhase.Send(new ThreatCommand(1, 0, 0, 1, "ambush", Monster: MasterRewards.KindAmbush, MonsterId: offer, Amount: id));
            Log.Info($"问号房伏击：第 {floor} 层是问号房里的战斗，塔主三选一");
        }
        catch (Exception e) { Log.Error("问号房伏击：发选项失败（这场照原版打）", e); }
    }

    /// <summary>地图点是问号、当前房间是战斗房（不是事件里的战斗）。</summary>
    internal static bool IsAmbushRoom(object state)
    {
        var point = GameReflection.Get(state, "CurrentMapPoint");
        var type = point == null ? null : GameReflection.Get(point, "PointType")?.ToString();
        var room = GameReflection.Get(state, "CurrentRoom")?.GetType().Name;
        return type == "Unknown" && room == "CombatRoom";
    }

    /// <summary>各端：执行选中的伏击效果。</summary>
    internal static async Task Apply(string id, object action, string tag)
    {
        var option = Options.FirstOrDefault(o => o.Id == id);
        if (option == null) { Log.Warn($"{tag}：不认识的伏击 {id}"); return; }
        var state = GameReflection.Get(Test1bMixedEncounter.Run, "State");
        switch (id)
        {
            case "reinforce":
                if (ThreatPhase.CombatState() is { } combat && MasterCards.CallHelpMonster(state == null ? 1 : ThreatPhase.ActNoOf(state)) is { } monster)
                    await ThreatPhase.AddMonster(monster, combat);
                else Log.Warn($"{tag}：伏击·援军找不到能叫的小怪");
                break;
            case "brace":
            {
                var context = Activator.CreateInstance(RuntimeNetAction.Required("GameActionPlayerChoiceContext"), action)!;
                foreach (var e in MasterHand.LivingEnemies().ToList())
                {
                    await ThreatPhase.ApplyPowerWith("StrengthPower", context, e, BraceStrength);
                    MasterHand.RecordStrength(e, BraceStrength);
                    await ThreatPhase.GainBlock(e, BraceBlock);
                }
                MasterVfx.WardAllEnemies();
                break;
            }
            case "toll":
                if (state != null)
                {
                    var lose = RuntimeNetAction.Required("PlayerCmd").GetMethods(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static)
                        .First(m => m.Name == "LoseGold" && m.GetParameters().Length == 3);
                    var lossType = lose.GetParameters()[2];
                    foreach (var p in (GameReflection.Get(state, "Players") as IEnumerable)?.Cast<object>() ?? [])
                    {
                        if (Test2MasterOffField.NetIdOf(p) == Test2MasterOffField.MasterId) continue;
                        int gold = Convert.ToInt32(GameReflection.Get(p, "Gold") ?? 0);
                        if (gold > 0) await (Task)lose.Invoke(null, [(decimal)Math.Min(TollGold, gold), p, lossType.HasDefaultValue ? lossType.DefaultValue : Enum.ToObject(lossType.ParameterType, 2)])!;
                    }
                }
                break;
        }
        Log.Info($"{tag}：问号房伏击，塔主选了「{option.Title}」");
        SummonPhase.Notify("问号房里有埋伏！", $"塔主选了「{option.Title}」：{option.Description}", "icon_trap");
        MasterPresence.Cast();
    }

    internal static void Skipped(string tag)
    {
        Log.Info($"{tag}：问号房伏击，塔主放了玩家一马");
        if (!Test3MasterAutoPilot.LocalIsMaster) SummonPhase.Notify("问号房里静悄悄的", "塔主这次没有埋伏", "icon_trap");
    }
}
