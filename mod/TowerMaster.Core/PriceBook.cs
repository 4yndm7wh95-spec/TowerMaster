using System.Text.Json;
using System.Text.Json.Serialization;

namespace TowerMaster.Core;

public enum RoomKind { Monster, Elite, Boss }

public enum MonsterRole { Normal, Elite, Boss, Summon }

/// <summary>
/// 召唤价表，读自 data/price_book.json（由 scripts/build_tables.py 生成）。
/// 幕用游戏里的幕类名标识：Overgrowth、Underdocks、Hive、Glory。
/// </summary>
public sealed class PriceBook
{
    [JsonPropertyName("version")] public string Version { get; set; } = "";
    [JsonPropertyName("acts")] public Dictionary<string, ActPrices> Acts { get; set; } = new();

    public static PriceBook FromJson(string json)
    {
        var book = JsonSerializer.Deserialize<PriceBook>(json, Options)
                   ?? throw new InvalidDataException("price_book.json 为空");
        foreach (var (id, act) in book.Acts) act.Id = id;
        return book;
    }

    public static PriceBook Load(string path) => FromJson(File.ReadAllText(path));

    public ActPrices Act(string actId) =>
        Acts.TryGetValue(actId, out var act) ? act : throw new KeyNotFoundException($"价格表里没有幕 {actId}");

    private static readonly JsonSerializerOptions Options = new()
    {
        Converters = { new JsonStringEnumConverter() },
    };
}

public sealed class ActPrices
{
    [JsonIgnore] public string Id { get; set; } = "";
    [JsonPropertyName("act_no")] public int ActNo { get; set; }
    [JsonPropertyName("name_zh")] public string NameZh { get; set; } = "";
    [JsonPropertyName("monsters")] public Dictionary<string, MonsterPrice> Monsters { get; set; } = new();
    [JsonPropertyName("encounters")] public Dictionary<string, EncounterInfo> Encounters { get; set; } = new();

    public bool TryPrice(string monster, out int price)
    {
        price = Monsters.TryGetValue(monster, out var m) ? m.Price : 0;
        return price > 0;
    }

    public int Price(string monster) =>
        Monsters.TryGetValue(monster, out var m) ? m.Price : throw new KeyNotFoundException($"{Id} 的价格表里没有怪物 {monster}");

    /// <summary>本幕普通（非简单）遭遇的平均标准开销，用于 Boss 房额外召唤上限。</summary>
    public double AverageNormalStandardCost
    {
        get
        {
            var costs = Encounters.Values.Where(e => e.Room == RoomKind.Monster && !e.Weak).Select(e => e.StandardCost).ToList();
            return costs.Count == 0 ? 0 : costs.Average();
        }
    }
}

public sealed class MonsterPrice
{
    [JsonPropertyName("name_zh")] public string NameZh { get; set; } = "";
    [JsonPropertyName("role")] public MonsterRole Role { get; set; }
    /// <summary>是否出现在本幕的原版简单遭遇里（开局保护只能用这些）。</summary>
    [JsonPropertyName("weak_pool")] public bool WeakPool { get; set; }
    [JsonPropertyName("price")] public int Price { get; set; }
}

public sealed class EncounterInfo
{
    [JsonPropertyName("name_zh")] public string NameZh { get; set; } = "";
    [JsonPropertyName("room")] public RoomKind Room { get; set; }
    [JsonPropertyName("weak")] public bool Weak { get; set; }
    [JsonPropertyName("lineups")] public List<Lineup> Lineups { get; set; } = new();
    /// <summary>期望标准开销（随机组合按概率平均）。实际对局里用实际生成的组合算 <see cref="SummonRules.StandardCost"/>。</summary>
    [JsonPropertyName("standard_cost")] public double StandardCost { get; set; }

    public int MaxLineupSize => Lineups.Count == 0 ? 0 : Lineups.Max(l => l.Monsters.Count);
}

public sealed class Lineup
{
    [JsonPropertyName("p")] public double P { get; set; }
    [JsonPropertyName("monsters")] public List<string> Monsters { get; set; } = new();
}
