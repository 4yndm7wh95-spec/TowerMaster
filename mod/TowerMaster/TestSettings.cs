using System.Text.Json;
using System.Text.Json.Serialization;

namespace TowerMaster;

/// <summary>技术验证用的开关，读 mod 目录下的 towermaster.test.json。</summary>
internal sealed class TestSettings
{
    [JsonPropertyName("test1_fixed_encounter")] public bool Test1FixedEncounter { get; set; } = true;
    [JsonPropertyName("fixed_encounters")] public Dictionary<string, string> FixedEncounters { get; set; } = new();
    [JsonPropertyName("probe")] public bool Probe { get; set; } = true;
    [JsonPropertyName("test1b_mixed_encounter")] public bool Test1bMixedEncounter { get; set; }
    [JsonPropertyName("mixed_monsters")] public Dictionary<string, string[]> MixedMonsters { get; set; } = new();

    /// <summary>测试 2：塔主（房主）战斗开局退场，人数缩放只数爬塔玩家。</summary>
    [JsonPropertyName("test2_master_off_field")] public bool Test2MasterOffField { get; set; }

    /// <summary>测试 3：选路、奖励、宝箱、事件、休息处、换幕替塔主自动操作。</summary>
    [JsonPropertyName("test3_master_autopilot")] public bool Test3MasterAutoPilot { get; set; }

    /// <summary>测试 3：塔主不能领奖励、买东西、删牌、拿宝箱遗物（设计文档：不给塔主发奖励）。</summary>
    /// <summary>召唤阶段（开发第 2 步）：进普通、精英、Boss 房前塔主用召唤点选怪。开着时测试 1b 的固定混搭不再发送。</summary>
    [JsonPropertyName("summon_phase")] public bool SummonPhase { get; set; }

    /// <summary>塔主回合（开发第 3 步）：每个玩家回合开始时塔主花威胁点。需要召唤阶段开着。</summary>
    [JsonPropertyName("master_turn")] public bool MasterTurn { get; set; }

    [JsonPropertyName("test3_block_master_items")] public bool Test3BlockMasterItems { get; set; } = true;

    /// <summary>
    /// 测试 2：哪些方法里的「玩家人数」改成只数爬塔玩家。每项可以是命名空间前缀（MegaCrit 开头）、
    /// 类名、方法名或「类名.方法名」。日志里会列出全部读人数的方法，按需增减。
    /// </summary>
    [JsonPropertyName("test2_scaling_scope")] public string[] Test2ScalingScope { get; set; } =
    [
        "MegaCrit.Sts2.Core.Models.Monsters",
        "MegaCrit.Sts2.Core.Models.Powers",
        "Creature",
        "MultiplayerScalingModel",
        "PowerModel",
        "CreateCreature",
        "ScaleHpForMultiplayer",
        "ScaleMonsterHpForMultiplayer",
        "ModifyBlockMultiplicative",
        "GetScaledAmountForMultiplayer",
        // 内容按单人给：不能把药水扔给（已死的）塔主，卡牌奖励、遗物池不出多人专用内容
        "PotionModel.CanThrowAtAlly",
        "CardFactory.FilterForPlayerCount",
        "MegaCrit.Sts2.Core.Models.Relics",
    ];

    public static TestSettings Load()
    {
        var path = Path.Combine(Log.ModDir, "towermaster.test.json");
        try
        {
            var settings = JsonSerializer.Deserialize<TestSettings>(File.ReadAllText(path), new JsonSerializerOptions
            {
                ReadCommentHandling = JsonCommentHandling.Skip,
                AllowTrailingCommas = true,
            });
            return settings ?? new TestSettings();
        }
        catch (Exception e)
        {
            Log.Warn($"读不到 {path}，用默认设置：{e.Message}");
            return new TestSettings();
        }
    }
}
