using System.Text.Json;
using System.Text.Json.Serialization;

namespace TowerMaster;

/// <summary>技术验证用的开关，读 mod 目录下的 towermaster.test.json。</summary>
internal sealed class TestSettings
{
    [JsonPropertyName("test1_fixed_encounter")] public bool Test1FixedEncounter { get; set; } = true;
    [JsonPropertyName("fixed_encounters")] public Dictionary<string, string> FixedEncounters { get; set; } = new();
    [JsonPropertyName("probe")] public bool Probe { get; set; } = true;

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
