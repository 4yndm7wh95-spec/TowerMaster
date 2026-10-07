using System.Net.Http;
using System.Text;
using Xunit;

namespace TowerMaster.Tests;

/// <summary>测试接口的网络层：本机端口、令牌、JSON 往返。</summary>
public class TestBridgeTests
{
    [Fact]
    public async Task ServesJsonOverLoopbackWithToken()
    {
        Log.Init();
        TestBridge.Dispatch = work => work();
        TestBridge.Start(0, "secret");
        try
        {
            using var http = new HttpClient { BaseAddress = new Uri($"http://127.0.0.1:{TestBridge.Port}") };
            var denied = await http.PostAsync("/logs", new StringContent("{}", Encoding.UTF8, "application/json"));
            Assert.Equal(401, (int)denied.StatusCode);

            var request = new HttpRequestMessage(HttpMethod.Post, "/logs") { Content = new StringContent("""{"source":"mod","cursor":0}""", Encoding.UTF8, "application/json") };
            request.Headers.Add("X-Token", "secret");
            var response = await http.SendAsync(request);
            var text = await response.Content.ReadAsStringAsync();
            Assert.Equal(200, (int)response.StatusCode);
            Assert.Contains("\"ok\":true", text);
            Assert.Contains("\"cursor\":", text);
        }
        finally { TestBridge.Stop(); TestBridge.Start(0, null); TestBridge.Stop(); }
    }

    [Fact]
    public void ConvertsArgumentsAndDumpsObjects()
    {
        Assert.Equal(3, TestBridge.ConvertArg(System.Text.Json.Nodes.JsonNode.Parse("3"), typeof(int)));
        Assert.Equal(DayOfWeek.Friday, TestBridge.ConvertArg(System.Text.Json.Nodes.JsonNode.Parse("\"Friday\""), typeof(DayOfWeek)));
        Assert.Null(TestBridge.ConvertArg(null, typeof(int?)));
        var dumped = (Dictionary<string, object?>)TestBridge.ToJson(new Uri("http://x/"), 0)!;
        Assert.Equal("x", dumped["Host"]);
    }
}

public class ConfigFileTests
{
    [Fact]
    public void ExampleConfigParsesWithDefaults()
    {
        var dir = AppContext.BaseDirectory;
        while (dir != null && !File.Exists(Path.Combine(dir, "TowerMaster", "towermaster.config.example.json"))) dir = Path.GetDirectoryName(dir);
        Assert.NotNull(dir);
        var config = TowerMaster.Core.TowerMasterConfig.FromJson(File.ReadAllText(Path.Combine(dir!, "TowerMaster", "towermaster.config.example.json")));
        var defaults = new TowerMaster.Core.TowerMasterConfig();
        Assert.Equal(defaults.ToJson(), config.ToJson()); // 示例里写的都是当前默认值
    }
}
