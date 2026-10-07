using System.Collections;

namespace TowerMaster;

/// <summary>
/// 同步排查用的状态摘要：房间、回合、每只敌人（类名、血、格挡、能力）、每名玩家（血、格挡、金币、能量、手牌/抽牌/弃牌数、能力）。
/// 两端在同一个动作后各记一行，格式一样，可以直接逐字对比。只读，不改任何状态。
/// </summary>
internal static class StateDigest
{
    internal static string Describe()
    {
        var run = Test1bMixedEncounter.Run;
        var state = GameReflection.Get(run, "State");
        if (state == null) return "无对局";
        var parts = new List<string> { $"层{GameReflection.Get(state, "TotalFloor")}" };
        var combat = ThreatPhase.CombatState();
        if (combat != null)
        {
            parts.Add($"回合{GameReflection.Get(combat, "RoundNumber")}/{GameReflection.Get(combat, "CurrentSide")}");
            var enemies = (GameReflection.Get(combat, "Enemies") as IEnumerable)?.Cast<object>() ?? [];
            parts.Add("敌[" + string.Join(" ", enemies.Select(Creature)) + "]");
        }
        var players = (GameReflection.Get(state, "Players") as IEnumerable)?.Cast<object>() ?? [];
        parts.Add("玩家[" + string.Join(" ", players.Select(Player)) + "]");
        return string.Join(" ", parts);
    }

    private static string Creature(object c) =>
        $"{GameReflection.Get(c, "Monster")?.GetType().Name ?? "?"}:{GameReflection.Get(c, "CurrentHp")}/{GameReflection.Get(c, "MaxHp")}"
        + $"b{GameReflection.Get(c, "Block")}{Powers(c)}";

    private static string Player(object p)
    {
        var id = Test2MasterOffField.NetIdOf(p);
        var c = GameReflection.Get(p, "Creature");
        var pcs = GameReflection.Get(p, "PlayerCombatState");
        string piles = pcs == null ? "" : $" e{GameReflection.Get(pcs, "Energy")} h{Count(pcs, "Hand")} d{Count(pcs, "DrawPile")} x{Count(pcs, "DiscardPile")}";
        return $"{id}:{(c == null ? "-" : $"{GameReflection.Get(c, "CurrentHp")}/{GameReflection.Get(c, "MaxHp")}b{GameReflection.Get(c, "Block")}")}"
               + $" g{GameReflection.Get(p, "Gold")}{piles}{(c == null ? "" : Powers(c))}";
    }

    private static string Count(object pcs, string pile)
    {
        var cards = GameReflection.Get(pcs, pile) is { } p ? GameReflection.Get(p, "Cards") as IEnumerable : null;
        return cards == null ? "?" : cards.Cast<object>().Count().ToString();
    }

    private static string Powers(object creature)
    {
        var powers = (GameReflection.Get(creature, "Powers") as IEnumerable)?.Cast<object>()
            .Select(p => $"{p.GetType().Name.Replace("Power", "")}{GameReflection.Get(p, "Amount")}").ToList();
        return powers == null || powers.Count == 0 ? "" : "{" + string.Join(",", powers) + "}";
    }
}
