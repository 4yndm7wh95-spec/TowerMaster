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

    /// <summary>
    /// 塔主战后不复活。0.0.24 实测：塔主一直死着，进事件时原版走「死亡玩家」分支报 ERROR、塔主的事件没结束。
    /// 塔主在战斗里和玩家列表里都已经隐藏，复活与否玩家看不到，所以默认让他按原版复活（只是看不见）。
    /// </summary>
    [JsonPropertyName("master_stay_dead")] public bool MasterStayDead { get; set; }
    /// <summary>塔主遗物（运行时生成 RelicModel 子类）。万一导致游戏起不来，设 false 关掉，宝箱退回送塔主牌。</summary>
    [JsonPropertyName("master_relics")] public bool MasterRelics { get; set; } = true;
    /// <summary>问号事件里塔主那份换成塔主事件（黑市、赌场等）。</summary>
    [JsonPropertyName("master_events")] public bool MasterEvents { get; set; } = true;
    /// <summary>塔主战斗特效：render = 游戏内实时渲染（默认），sheet = 旧的 8 帧序列图。</summary>
    [JsonPropertyName("vfx_style")] public string VfxStyle { get; set; } = "render";

    /// <summary>
    /// 塔主的真实卡牌（第一阶段）：启动时注册塔主牌，新局把塔主牌组换成塔主牌，原版牌组界面能看到。
    /// 会往游戏的模型库里加新卡类型，两台电脑必须一致（都开或都关），否则联机编号对不上。
    /// </summary>
    /// 0.0.30 起默认开（用户要原版手牌出牌；旧的设置文件里没有这一项时也开）。
    [JsonPropertyName("master_cards")] public bool MasterCards { get; set; } = true;

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
