using System.Collections;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace TowerMaster;

/// <summary>
/// 测试接口（只给本机测试助手用，默认关闭）：环境变量 TOWERMASTER_BRIDGE_PORT 设了端口才启动，
/// 只监听 127.0.0.1；设了 TOWERMASTER_BRIDGE_TOKEN 时每个请求都要带 X-Token 头。
/// 协议是最简单的 HTTP/1.1 + JSON（POST 带 JSON 体，GET 不带），一个连接一个请求。
///
/// 所有碰游戏的操作都转到 Godot 主线程执行（<see cref="Dispatch"/>），网络线程只收发。
/// 操作尽量走游戏原有的路径（入队联机动作、调用界面处理函数、开发者控制台），不直接改字段。
/// 路由见 <see cref="Route"/>；接口说明见 testing/mcp/README.md。
/// </summary>
internal static class TestBridge
{
    private static TcpListener? _listener;
    private static string? _token;
    private static readonly ConcurrentQueue<Action> MainQueue = new();
    private static bool _pumping;

    public static int Port { get; private set; }

    /// <summary>主线程执行器；测试里替换为直接执行。</summary>
    internal static Func<Func<Task<object?>>, Task<object?>> Dispatch = OnMainThread;

    /// <summary>主线程上单个请求最多等多久（含 await 游戏任务）。</summary>
    internal static TimeSpan Timeout = TimeSpan.FromSeconds(20);

    internal static void StartFromEnvironment()
    {
        var portText = Environment.GetEnvironmentVariable("TOWERMASTER_BRIDGE_PORT");
        if (string.IsNullOrWhiteSpace(portText)) return;
        if (!int.TryParse(portText, out var port) || port is <= 0 or > 65535)
        {
            Log.Warn($"测试接口：TOWERMASTER_BRIDGE_PORT={portText} 不是有效端口，不启动");
            return;
        }
        Start(port, Environment.GetEnvironmentVariable("TOWERMASTER_BRIDGE_TOKEN"));
    }

    internal static void Start(int port, string? token)
    {
        Stop();
        _token = string.IsNullOrEmpty(token) ? null : token;
        _listener = new TcpListener(IPAddress.Loopback, port);
        _listener.Start();
        Port = ((IPEndPoint)_listener.LocalEndpoint).Port;
        var listener = _listener;
        _ = Task.Run(() => Serve(listener));
        Log.Info($"测试接口：已在 127.0.0.1:{Port} 监听{(_token == null ? "（没有设令牌）" : "（需要令牌）")}");
    }

    internal static void Stop()
    {
        try { _listener?.Stop(); } catch { /* 已关闭 */ }
        _listener = null;
    }

    // ---------------------------------------------------------------- 网络

    private static async Task Serve(TcpListener listener)
    {
        while (true)
        {
            TcpClient client;
            try { client = await listener.AcceptTcpClientAsync(); }
            catch { return; } // 停止监听
            _ = Task.Run(() => Handle(client));
        }
    }

    private static async Task Handle(TcpClient client)
    {
        using var _ = client;
        try
        {
            var stream = client.GetStream();
            var (method, path, headers, body) = await ReadRequest(stream);
            headers.TryGetValue("x-token", out var token);
            var (status, result) = await Route(method, path, token, body);
            var json = JsonSerializer.Serialize(result, JsonOut);
            var bytes = Encoding.UTF8.GetBytes(json);
            var head = $"HTTP/1.1 {status} {(status == 200 ? "OK" : "Error")}\r\nContent-Type: application/json; charset=utf-8\r\n" +
                       $"Content-Length: {bytes.Length}\r\nConnection: close\r\n\r\n";
            await stream.WriteAsync(Encoding.ASCII.GetBytes(head));
            await stream.WriteAsync(bytes);
        }
        catch (Exception e)
        {
            Log.Warn($"测试接口：处理请求失败：{e.Message}");
        }
    }

    private static async Task<(string Method, string Path, Dictionary<string, string> Headers, string Body)> ReadRequest(NetworkStream stream)
    {
        var buffer = new List<byte>();
        var chunk = new byte[8192];
        int headerEnd = -1;
        while (headerEnd < 0)
        {
            int n = await stream.ReadAsync(chunk);
            if (n == 0) throw new IOException("连接提前关闭");
            buffer.AddRange(chunk.AsSpan(0, n).ToArray());
            headerEnd = IndexOf(buffer, "\r\n\r\n"u8.ToArray());
            if (buffer.Count > 1 << 20) throw new IOException("请求头太大");
        }
        var headText = Encoding.ASCII.GetString(buffer.GetRange(0, headerEnd).ToArray());
        var lines = headText.Split("\r\n");
        var first = lines[0].Split(' ');
        var headers = lines.Skip(1).Select(l => l.Split(':', 2)).Where(p => p.Length == 2)
            .ToDictionary(p => p[0].Trim().ToLowerInvariant(), p => p[1].Trim());
        int length = headers.TryGetValue("content-length", out var cl) && int.TryParse(cl, out var len) ? len : 0;
        if (length > 16 << 20) throw new IOException("请求体太大");
        var bodyBytes = buffer.Skip(headerEnd + 4).ToList();
        while (bodyBytes.Count < length)
        {
            int n = await stream.ReadAsync(chunk);
            if (n == 0) break;
            bodyBytes.AddRange(chunk.AsSpan(0, n).ToArray());
        }
        return (first[0].ToUpperInvariant(), first.Length > 1 ? first[1] : "/", headers, Encoding.UTF8.GetString(bodyBytes.Take(length).ToArray()));
    }

    private static int IndexOf(List<byte> data, byte[] pattern)
    {
        for (int i = 0; i + pattern.Length <= data.Count; i++)
        {
            int j = 0;
            while (j < pattern.Length && data[i + j] == pattern[j]) j++;
            if (j == pattern.Length) return i;
        }
        return -1;
    }

    // ---------------------------------------------------------------- 主线程

    private static Task<object?> OnMainThread(Func<Task<object?>> work)
    {
        var done = new TaskCompletionSource<object?>(TaskCreationOptions.RunContinuationsAsynchronously);
        MainQueue.Enqueue(async () =>
        {
            try { done.TrySetResult(await work()); }
            catch (Exception e) { done.TrySetException(e); }
        });
        EnsurePump();
        return done.Task;
    }

    /// <summary>每帧把排队的请求拿到主线程执行。第一次从网络线程调用时用 CallDeferred 挂到主线程上。</summary>
    private static void EnsurePump()
    {
        if (_pumping) return;
        _pumping = true;
        Godot.Callable.From(() =>
        {
            ((Godot.SceneTree)Godot.Engine.GetMainLoop()).ProcessFrame += () =>
            {
                while (MainQueue.TryDequeue(out var action)) action();
            };
        }).CallDeferred();
    }

    // ---------------------------------------------------------------- 路由

    private sealed class BridgeError(int status, string code, string message) : Exception(message)
    {
        public int Status { get; } = status;
        public string Code { get; } = code;
    }

    private static BridgeError Fail(string code, string message, int status = 400) => new(status, code, message);

    internal static readonly JsonSerializerOptions JsonOut = new() { WriteIndented = false };

    /// <summary>处理一个请求，返回 (HTTP 状态码, JSON 对象)。网络层以外的测试直接调这个。</summary>
    internal static async Task<(int Status, object Body)> Route(string method, string path, string? token, string body)
    {
        var watch = Stopwatch.StartNew();
        try
        {
            if (_token != null && token != _token) throw Fail("unauthorized", "令牌不对（X-Token）", 401);
            var args = string.IsNullOrWhiteSpace(body) ? new JsonObject() : JsonNode.Parse(body) as JsonObject ?? throw Fail("bad_request", "请求体要是 JSON 对象");
            var route = path.Split('?')[0].TrimEnd('/');
            Func<JsonObject, Task<object?>> handler = route switch
            {
                "/ping" => _ => Main(Ping),
                "/state" => _ => Main(StateSnapshot),
                "/summon" => _ => Main(() => SummonSnapshot(RequireSession())),
                "/summon/select" => a => Main(() => SummonSelect(a)),
                "/summon/confirm" => _ => Main(SummonConfirm),
                "/summon/vanilla" => _ => Main(SummonVanilla),
                "/map/options" => _ => Main(MapOptions),
                "/map/vote" => a => Main(() => MapVote(a)),
                "/rewards/skip" => _ => Main(RewardsSkip),
                "/rewards" => _ => Main(Rewards),
                "/rewards/proceed" => _ => Main(RewardsProceed),
                "/treasure" => _ => Main(Treasure),
                "/treasure/open" => _ => Main(TreasureOpen),
                "/treasure/pick" => a => Main(() => TreasurePick(a)),
                "/event" => _ => Main(EventOptions),
                "/event/choose" => a => Main(() => EventChoose(a)),
                "/cards" => _ => Main(Cards),
                "/threat" => _ => Main(Threat),
                "/config" => _ => Main(() => System.Text.Json.Nodes.JsonNode.Parse(ModEntry.Active.ToJson())),
                "/traps" => _ => Main(Traps),
                "/master/deck" => _ => Main(MasterDeckView),
                "/master/hand" => _ => Main(MasterHandView),
                "/master/play" => a => Main(() => MasterPlay(a)),
                "/traps/draft/select" => a => Main(() => TrapDraftSelect(a)),
                "/traps/draft/confirm" => _ => Main(TrapDraftConfirm),
                "/combat/hand" => _ => Main(CombatHand),
                "/combat/play" => a => Main(() => CombatPlay(a)),
                "/combat/end_turn" => _ => Main(CombatEndTurn),
                "/threat/act" => a => Main(() => ThreatAct(a)),
                "/threat/end" => _ => Main(ThreatEnd),
                "/threat/ui" => a => Main(() => ThreatUi(a)),
                "/cards/pick" => a => Main(() => CardsPick(a)),
                "/console" => a => MainAsync(() => ConsoleCommand(a)),
                "/logs" => a => Main(() => Logs(a)),
                "/screenshot" => a => Main(() => Screenshot(a)),
                "/tree" => a => Main(() => Tree(a)),
                "/node/call" => a => MainAsync(() => NodeCall(a)),
                "/reflect" => a => MainAsync(() => Reflect(a)),
                _ => throw Fail("not_found", $"没有接口 {route}", 404),
            };
            var task = handler(args);
            if (await Task.WhenAny(task, Task.Delay(Timeout)) != task) throw Fail("timeout", $"主线程 {Timeout.TotalSeconds} 秒内没有完成（游戏卡住或在加载）", 504);
            var result = await task;
            return (200, new { ok = true, ms = watch.ElapsedMilliseconds, result });
        }
        catch (Exception e)
        {
            var inner = e is TargetInvocationException { InnerException: { } ie } ? ie : e;
            if (inner is BridgeError be) return (be.Status, new { ok = false, ms = watch.ElapsedMilliseconds, error = be.Code, message = be.Message });
            Log.Warn($"测试接口 {path}：{inner}");
            return (500, new { ok = false, ms = watch.ElapsedMilliseconds, error = "exception", message = inner.Message, type = inner.GetType().FullName });
        }
    }

    private static Task<object?> Main(Func<object?> work) => Dispatch(() => Task.FromResult(work()));
    private static Task<object?> MainAsync(Func<Task<object?>> work) => Dispatch(work);

    // ---------------------------------------------------------------- 身份、状态

    private static object? RunOrNull() { try { return Test1bMixedEncounter.Run; } catch { return null; } }
    private static object? StateOrNull() => RunOrNull() is { } run ? GameReflection.Get(run, "State") : null;

    private static object? Try(Func<object?> get) { try { return get(); } catch { return null; } }

    private static object Ping()
    {
        var net = RunOrNull() is { } run ? GameReflection.Get(run, "NetService") : null;
        return new
        {
            instance = Environment.GetEnvironmentVariable("TOWERMASTER_INSTANCE"),
            pid = Environment.ProcessId,
            port = Port,
            mod_version = ModVersion(),
            net_type = net == null ? null : Try(() => GameReflection.Get(net, "Type")?.ToString()),
            net_id = net == null ? null : Try(() => Convert.ToUInt64(GameReflection.Get(net, "NetId"))),
            is_host = Test3MasterAutoPilot.LocalIsMaster,
            in_run = StateOrNull() != null,
            mod_log = Log.FilePath,
            game_log = Environment.GetEnvironmentVariable("TOWERMASTER_GAME_LOG"),
        };
    }

    private static string? ModVersion()
    {
        try
        {
            var manifest = JsonNode.Parse(File.ReadAllText(Path.Combine(Log.ModDir, "TowerMaster.json")));
            return manifest?["version"]?.GetValue<string>();
        }
        catch { return null; }
    }

    private static object StateSnapshot()
    {
        var state = StateOrNull();
        if (state == null) return new { in_run = false };
        var coord = Try(() => GameReflection.Get(state, "CurrentMapCoord"));
        var point = Try(() => GameReflection.Get(state, "CurrentMapPoint"));
        var combat = Try(CombatState);
        var wallet = MasterLedger.Wallet;
        return new
        {
            in_run = true,
            seed = Try(() => Convert.ToUInt64(GameReflection.Get(GameReflection.Get(state, "Rng")!, "Seed")).ToString()),
            act = Try(() => GameReflection.Get(state, "Act")?.GetType().Name),
            act_floor = Try(() => GameReflection.Get(state, "ActFloor")),
            total_floor = Try(() => GameReflection.Get(state, "TotalFloor")),
            coord = coord == null ? null : CoordJson(coord),
            point_type = point == null ? null : Try(() => GameReflection.Get(point, "PointType")?.ToString()),
            room = Try(() => GameReflection.Get(state, "CurrentRoom")?.GetType().Name),
            players = (GameReflection.Get(state, "Players") as IEnumerable)?.Cast<object>().Select(PlayerJson).ToList(),
            combat = combat == null ? null : new
            {
                in_progress = Try(() => GameReflection.Get(CombatManager()!, "IsInProgress")),
                enemies = (GameReflection.Get(combat, "Enemies") as IEnumerable)?.Cast<object>().Select(CreatureJson).ToList(),
            },
            wallet = wallet == null ? null : new { points = wallet.Points, act = wallet.ActNo, battles = MasterLedger.BattlesFought },
            summon_open = SummonPhase.Current is { Done: false },
            rewards_visible = Try(() => RewardsScreen() != null) ?? false,
            master_turn_open = ThreatPhase.TurnOpen,
            draft_open = SummonPhase.Draft is { Done: false },
            paused_by_master_turn = ThreatPhase.PausedHere, // 本机玩家队列被塔主回合暂停（各端都有）
        };
    }

    private static object? CombatManager() =>
        RuntimeNetAction.Required("CombatManager").GetProperty("Instance", GameReflection.All)?.GetValue(null);

    private static object? CombatState()
    {
        var manager = CombatManager();
        return manager == null ? null : RuntimeNetAction.Call(manager, "DebugOnlyGetState");
    }

    private static object CoordJson(object coord) => new
    {
        col = Convert.ToInt32(GameReflection.Get(coord, "col")),
        row = Convert.ToInt32(GameReflection.Get(coord, "row")),
    };

    private static object PlayerJson(object player)
    {
        var creature = Try(() => GameReflection.Get(player, "Creature"));
        return new
        {
            net_id = Test2MasterOffField.NetIdOf(player),
            is_master = Test2MasterOffField.NetIdOf(player) == Test2MasterOffField.MasterId,
            gold = Try(() => GameReflection.Get(player, "Gold")),
            hp = creature == null ? null : Try(() => GameReflection.Get(creature, "CurrentHp")),
            max_hp = creature == null ? null : Try(() => GameReflection.Get(creature, "MaxHp")),
            alive = creature == null ? null : Try(() => GameReflection.Get(creature, "IsAlive")),
        };
    }

    private static object CreatureJson(object creature) => new
    {
        monster = Try(() => GameReflection.Get(creature, "Monster")?.GetType().Name),
        slot = Try(() => GameReflection.Get(creature, "SlotName")),
        hp = Try(() => GameReflection.Get(creature, "CurrentHp")),
        max_hp = Try(() => GameReflection.Get(creature, "MaxHp")),
        max_hp_before_modification = Try(() => GameReflection.Get(creature, "MonsterMaxHpBeforeModification")),
        alive = Try(() => GameReflection.Get(creature, "IsAlive")),
    };

    // ---------------------------------------------------------------- 召唤

    private static SummonSession RequireSession()
    {
        if (!Test3MasterAutoPilot.LocalIsMaster) throw Fail("not_host", "召唤只在塔主（房主）这边");
        return SummonPhase.Current is { Done: false } s ? s : throw Fail("invalid_phase", "现在没有打开的召唤面板");
    }

    internal static object SummonSnapshot(SummonSession s)
    {
        var q = s.Quote;
        return new
        {
            room = s.Room.Room.ToString(),
            act = s.Room.ActId,
            savings = s.Room.Savings,
            standard_cost = s.Room.StandardCostOverride,
            opening_protected = s.IsOpeningProtected,
            encounters = s.EncounterOptions.Select(o => new { id = o.Id, name = o.Name, allows_extras = s.EncounterAllowsExtras(o.Id) }),
            monsters = s.MonsterOptions.Select(o => new { id = o.Id, name = o.Name, price = o.Price, home_act = o.HomeAct, elite = o.IsElite, hp_factor = o.HpFactor }),
            traps = s.TrapHand.Select((t, i) => new { index = i, id = t.ToString(), name = t.Name, text = t.Describe(), cooling = s.TrapCooling(i) }),
            selected = new { encounter = s.Encounter, monsters = s.Monsters, traps = s.SelectedTraps },
            quote = new
            {
                ok = q.Ok,
                violations = q.Violations.Select(v => v.ToString()),
                problems = s.ExtraProblems.Concat(q.Violations.Select(SummonSession.Describe)),
                monster_price = q.MonsterPrice,
                crowd_tax = q.CrowdTax,
                trap_cost = q.TrapCost,
                total = q.Total,
                spend_cap = Math.Round(q.SpendCap, 2),
                left_after = s.Room.Savings - q.Total,
                lineup = q.Lineup,
            },
            can_confirm = s.CanConfirm,
        };
    }

    private static object SummonSelect(JsonObject a)
    {
        var s = RequireSession();
        var monsters = a["monsters"] is JsonArray arr ? arr.Select(n => n!.GetValue<string>()).ToList() : [];
        var traps = a["traps"] is JsonArray ta ? ta.Select(n => n!.GetValue<int>()).ToList() : null;
        var unknown = s.SetSelection(a["encounter"]?.GetValue<string>(), monsters, traps);
        if (unknown.Count > 0) throw Fail("unknown_option", $"不在可选列表里：{string.Join(", ", unknown)}");
        return SummonSnapshot(s);
    }

    private static object SummonConfirm()
    {
        var s = RequireSession();
        var before = MasterLedger.Wallet?.Points;
        var snapshot = SummonSnapshot(s);
        if (!s.Confirm()) throw Fail("rejected_rule", "不符合规则，不能确认：" + string.Join("；", s.ExtraProblems.Concat(s.Quote.Violations.Select(SummonSession.Describe))));
        return new { confirmed = true, points_before = before, points_after = MasterLedger.Wallet?.Points, summon = snapshot };
    }

    private static object SummonVanilla()
    {
        var s = RequireSession();
        var before = MasterLedger.Wallet?.Points;
        var fallback = s.FallbackQuote;
        s.UseVanilla();
        return new { vanilla = true, standard_cost = s.Room.StandardCostOverride, charged = fallback.Total, points_before = before, points_after = MasterLedger.Wallet?.Points };
    }

    // ---------------------------------------------------------------- 选路、奖励

    private static object MapOptions()
    {
        var state = StateOrNull() ?? throw Fail("invalid_phase", "不在对局里");
        var current = GameReflection.Get(state, "CurrentMapPoint");
        IEnumerable? next = current != null
            ? GameReflection.Get(current, "Children") as IEnumerable
            : Try(() => GameReflection.Get(GameReflection.Get(state, "Map")!, "StartingMapPoint")) is { } start ? new[] { start } : null;
        return new
        {
            current = current == null ? null : CoordJson(GameReflection.Get(current, "coord")!),
            next = next?.Cast<object>().Select(p => new
            {
                coord = CoordJson(GameReflection.Get(p, "coord")!),
                type = GameReflection.Get(p, "PointType")?.ToString(),
            }).ToList(),
        };
    }

    /// <summary>本机玩家投票去某个地图点：和点地图一样，入队一个 VoteForMapCoordAction（塔主不允许，塔主是自动跟投的）。</summary>
    private static object MapVote(JsonObject a)
    {
        if (Test3MasterAutoPilot.LocalIsMaster && a["force"]?.GetValue<bool>() != true)
            throw Fail("not_allowed", "塔主不能自己选路（自动跟随爬塔玩家）；要测拦截请传 force=true");
        var state = StateOrNull() ?? throw Fail("invalid_phase", "不在对局里");
        int col = a["col"]?.GetValue<int>() ?? throw Fail("bad_request", "要 col"), row = a["row"]?.GetValue<int>() ?? throw Fail("bad_request", "要 row");
        var run = RunOrNull()!;
        var player = LocalPlayer(state);
        var sync = FindMemberOfType(run, "MapSelectionSynchronizer") ?? throw Fail("exception", "找不到 MapSelectionSynchronizer", 500);
        var queue = FindMemberOfType(run, "ActionQueueSynchronizer") ?? throw Fail("exception", "找不到 ActionQueueSynchronizer", 500);
        var coordType = RuntimeNetAction.Required("MapCoord");
        var coord = Activator.CreateInstance(coordType, col, row)!;
        var voteType = RuntimeNetAction.Required("MapVote");
        var vote = Activator.CreateInstance(voteType)!;
        voteType.GetField("coord")!.SetValue(vote, coord);
        voteType.GetField("mapGenerationCount")!.SetValue(vote, GameReflection.Get(sync, "MapGenerationCount"));
        var source = GameReflection.Get(state, "MapLocation");
        var actionType = RuntimeNetAction.Required("VoteForMapCoordAction");
        var action = actionType.GetConstructors(GameReflection.All).First(c => c.GetParameters().Length == 3).Invoke([player, source, vote]);
        RuntimeNetAction.Call(queue, "RequestEnqueue", action);
        Log.Info($"测试接口：玩家 {Test2MasterOffField.NetIdOf(player)} 投票去 ({col},{row})");
        return new { voted = new { col, row }, player = Test2MasterOffField.NetIdOf(player) };
    }

    private static object RewardsSkip()
    {
        var run = RunOrNull() ?? throw Fail("invalid_phase", "不在对局里");
        var sync = FindMemberOfType(run, "RewardsSetSynchronizer") ?? throw Fail("exception", "找不到 RewardsSetSynchronizer", 500);
        RuntimeNetAction.Call(sync, "SkipLocalRewardsSet");
        return new { skipped = true };
    }

    // ---------------------------------------------------------------- 节点查找

    /// <summary>场景树里第一个类型名为 typeName 的节点（可见的优先）。</summary>
    private static Godot.Node? FindNode(string typeName, bool visibleOnly = true)
    {
        var stack = new Stack<Godot.Node>();
        stack.Push(SceneTree.Root);
        while (stack.Count > 0)
        {
            var node = stack.Pop();
            if (visibleOnly && node is Godot.CanvasItem ci && !ci.IsVisibleInTree()) continue;
            if (IsType(node, typeName)) return node;
            foreach (var child in node.GetChildren()) stack.Push(child);
        }
        return null;
    }

    /// <summary>节点的类型或它的某个基类叫这个名字。</summary>
    private static bool IsType(object node, string typeName)
    {
        for (var t = node.GetType(); t != null; t = t.BaseType)
            if (t.Name == typeName) return true;
        return false;
    }

    private static List<Godot.Node> FindNodes(string typeName)
    {
        var found = new List<Godot.Node>();
        var stack = new Stack<Godot.Node>();
        stack.Push(SceneTree.Root);
        while (stack.Count > 0)
        {
            var node = stack.Pop();
            if (node is Godot.CanvasItem ci && !ci.IsVisibleInTree()) continue;
            if (IsType(node, typeName)) found.Add(node);
            var children = node.GetChildren();
            for (int i = children.Count - 1; i >= 0; i--) stack.Push(children[i]);
        }
        return found;
    }

    // ---------------------------------------------------------------- 奖励界面

    /// <summary>正在显示、且已经有奖励组的奖励界面（NRewardsScreen）。</summary>
    private static Godot.Node? RewardsScreen() =>
        FindNode("NRewardsScreen") is { } screen && GameReflection.Get(screen, "_rewardsSet") != null ? screen : null;

    private static object Rewards()
    {
        var screen = RewardsScreen();
        if (screen == null) return new { visible = false };
        var set = GameReflection.Get(screen, "_rewardsSet")!;
        var rewards = (GameReflection.Get(set, "Rewards") as IEnumerable)?.Cast<object>().Select((r, i) => new
        {
            index = i,
            type = r.GetType().Name,
            gold = Try(() => GameReflection.Get(r, "Amount")),
            relic = Try(() => GameReflection.Get(r, "Relic")?.GetType().Name),
            detail = ToJson(r, 0),
        }).ToList();
        return new { visible = true, path = screen.GetPath().ToString(), rewards };
    }

    /// <summary>奖励界面的「继续」按钮（NRewardsScreen.OnProceedButtonPressed）。</summary>
    private static object RewardsProceed()
    {
        var screen = FindNode("NRewardsScreen") ?? throw Fail("invalid_phase", "没有显示奖励界面");
        RuntimeNetAction.Call(screen, "OnProceedButtonPressed", [null]);
        return new { proceeded = true };
    }

    // ---------------------------------------------------------------- 宝箱

    private static object TreasureSync() =>
        FindMemberOfType(RunOrNull() ?? throw Fail("invalid_phase", "不在对局里"), "TreasureRoomRelicSynchronizer")
        ?? throw Fail("exception", "找不到 TreasureRoomRelicSynchronizer", 500);

    /// <summary>宝箱状态：宝箱里的遗物（序号、类型）、每个玩家的投票、本机玩家现有遗物（领取前后对比用）。</summary>
    private static object Treasure()
    {
        var state = StateOrNull() ?? throw Fail("invalid_phase", "不在对局里");
        var sync = TreasureSync();
        var relics = (GameReflection.Get(sync, "CurrentRelics") as IEnumerable)?.Cast<object>()
            .Select((r, i) => new { index = i, relic = r.GetType().Name }).ToList();
        var players = (GameReflection.Get(state, "Players") as IEnumerable)!.Cast<object>().ToList();
        var votes = players.Select(p => new
        {
            net_id = Test2MasterOffField.NetIdOf(p),
            vote = Try(() => ToJson(RuntimeNetAction.Call(sync, "GetPlayerVote", p), 1)),
        }).ToList();
        var room = FindNode("NTreasureRoom");
        return new
        {
            in_treasure_room = room != null,
            chest_opened = room == null ? null : GameReflection.Get(room, "_hasChestBeenOpened"),
            relics,
            votes,
            my_relics = (GameReflection.Get(LocalPlayer(state), "Relics") as IEnumerable)?.Cast<object>().Select(r => r.GetType().Name).ToList(),
        };
    }

    /// <summary>本机玩家点开宝箱（NTreasureRoom.OnChestButtonReleased）。塔主那边是自动开的。</summary>
    private static object TreasureOpen()
    {
        var room = FindNode("NTreasureRoom") ?? throw Fail("invalid_phase", "不在宝箱房");
        RuntimeNetAction.Call(room, "OnChestButtonReleased", [null]);
        return new { opened = GameReflection.Get(room, "_hasChestBeenOpened") };
    }

    /// <summary>本机玩家选宝箱里第 index 个遗物；index 省略或 null 表示跳过（TreasureRoomRelicSynchronizer.PickRelicLocally）。</summary>
    private static object TreasurePick(JsonObject a)
    {
        var sync = TreasureSync();
        int? index = a["index"]?.GetValue<int>();
        RuntimeNetAction.Call(sync, "PickRelicLocally", index);
        return new { picked = index };
    }

    // ---------------------------------------------------------------- 事件

    private static List<Godot.Node> EventButtons() =>
        FindNodes("NEventOptionButton"); // 先古之民的选项按钮也是它的子类

    private static object EventOptions() => new
    {
        options = EventButtons().Select((b, i) => new
        {
            index = i,
            path = b.GetPath().ToString(),
            type = b.GetType().Name,
            text = string.Join(" / ", Texts(b)),
            disabled = Try(() => GameReflection.Get(b, "IsEnabled") is false || GameReflection.Get(b, "_isEnabled") is false),
        }).ToList(),
    };

    /// <summary>点第 index 个事件选项（NEventOptionButton.OnRelease，和鼠标点一样）。</summary>
    private static object EventChoose(JsonObject a)
    {
        int index = a["index"]?.GetValue<int>() ?? throw Fail("bad_request", "要 index");
        var buttons = EventButtons();
        if (index < 0 || index >= buttons.Count) throw Fail("bad_request", $"只有 {buttons.Count} 个选项");
        var path = buttons[index].GetPath().ToString(); // 点完按钮可能被移出场景树，先记下
        var text = string.Join(" / ", Texts(buttons[index]));
        RuntimeNetAction.Call(buttons[index], "OnRelease");
        return new { chosen = index, path, text };
    }

    // ---------------------------------------------------------------- 出牌（本机玩家，走原版联机动作）

    private static object CombatHand()
    {
        var state = StateOrNull() ?? throw Fail("invalid_phase", "不在对局里");
        var player = LocalPlayer(state);
        var pcs = GameReflection.Get(player, "PlayerCombatState") ?? throw Fail("invalid_phase", "不在战斗中");
        var cards = (GameReflection.Get(GameReflection.Get(pcs, "Hand")!, "Cards") as IEnumerable)!.Cast<object>()
            .Select((c, i) => new
            {
                index = i,
                card = c.GetType().Name,
                type = Try(() => GameReflection.Get(c, "Type")?.ToString()),
                title = Try(() => GameReflection.Get(c, "Title")?.ToString()),
                target_type = Try(() => GameReflection.Get(c, "TargetType")?.ToString()),
                cost = Try(() => GameReflection.Get(c, "EnergyCost") is { } e ? ToJson(e, 0) : null),
            }).ToList();
        var enemies = (GameReflection.Get(CombatState()!, "Enemies") as IEnumerable)!.Cast<object>()
            .Select((e, i) => new { index = i, monster = Try(() => GameReflection.Get(e, "Monster")?.GetType().Name), hp = Try(() => GameReflection.Get(e, "CurrentHp")) }).ToList();
        var me = GameReflection.Get(player, "Creature");
        return new
        {
            hp = me == null ? null : Try(() => GameReflection.Get(me, "CurrentHp")),
            alive = me == null ? null : Try(() => GameReflection.Get(me, "IsAlive")),
            energy = Try(() => GameReflection.Get(pcs, "Energy")),
            turn = Try(() => GameReflection.Get(pcs, "TurnNumber")),
            paused_by_master_turn = ThreatPhase.PausedHere,
            hand = cards,
            enemies,
        };
    }

    /// <summary>
    /// 本机玩家打出第 index 张手牌：和点牌一样入队 PlayCardAction(CardModel, Creature 目标)。
    /// target 是 Enemies 下标；不需要目标的牌不给 target。只代表入队，打没打出去看 /combat/hand 和日志。
    /// </summary>
    private static object CombatPlay(JsonObject a)
    {
        var state = StateOrNull() ?? throw Fail("invalid_phase", "不在对局里");
        var player = LocalPlayer(state);
        var pcs = GameReflection.Get(player, "PlayerCombatState") ?? throw Fail("invalid_phase", "不在战斗中");
        var cards = (GameReflection.Get(GameReflection.Get(pcs, "Hand")!, "Cards") as IEnumerable)!.Cast<object>().ToList();
        int index = a["index"]?.GetValue<int>() ?? throw Fail("bad_request", "要 index");
        if (index < 0 || index >= cards.Count) throw Fail("bad_request", $"手牌只有 {cards.Count} 张");
        // 按牌的 TargetType 定目标（0.0.21 实测：给「自身」牌传怪物目标，原版取消这张牌并报 ERROR）：
        // 单体敌人牌用给的 target，没给就打第一只活着的怪；指定友方的牌打自己；其他（自身、全体、随机、无）不给目标
        var targetType = GameReflection.Get(cards[index], "TargetType")?.ToString();
        object? target = null;
        var enemies = (GameReflection.Get(CombatState()!, "Enemies") as IEnumerable)!.Cast<object>().ToList();
        if (targetType == "AnyEnemy")
        {
            if (a["target"]?.GetValue<int>() is { } t)
            {
                if (t < 0 || t >= enemies.Count) throw Fail("bad_request", $"只有 {enemies.Count} 只怪");
                target = enemies[t];
            }
            else target = enemies.FirstOrDefault(e => GameReflection.Get(e, "IsAlive") is true)
                          ?? throw Fail("invalid_phase", "没有活着的怪可以打");
        }
        else if (targetType is "AnyAlly" or "AnyPlayer") target = GameReflection.Get(player, "Creature");
        var type = RuntimeNetAction.Required("PlayCardAction");
        var ctor = type.GetConstructors(GameReflection.All).First(c => c.GetParameters().Length == 2 && c.GetParameters()[0].ParameterType.Name == "CardModel");
        var action = ctor.Invoke([cards[index], target]);
        RuntimeNetAction.Call(GameReflection.Get(RunOrNull()!, "ActionQueueSynchronizer")!, "RequestEnqueue", action);
        return new { enqueued = cards[index].GetType().Name, target_type = targetType, target = target == null ? null : enemies.IndexOf(target) is var i && i >= 0 ? $"enemy {i}" : "self" };
    }

    /// <summary>本机玩家结束回合：入队 EndPlayerTurnAction(Player, 回合数)，和按结束回合按钮一样。</summary>
    private static object CombatEndTurn()
    {
        var state = StateOrNull() ?? throw Fail("invalid_phase", "不在对局里");
        var player = LocalPlayer(state);
        var pcs = GameReflection.Get(player, "PlayerCombatState") ?? throw Fail("invalid_phase", "不在战斗中");
        int turn = Convert.ToInt32(GameReflection.Get(pcs, "TurnNumber"));
        var type = RuntimeNetAction.Required("EndPlayerTurnAction");
        var action = type.GetConstructors(GameReflection.All).First(c => c.GetParameters().Length == 2).Invoke([player, turn]);
        RuntimeNetAction.Call(GameReflection.Get(RunOrNull()!, "ActionQueueSynchronizer")!, "RequestEnqueue", action);
        return new { enqueued = "EndPlayerTurnAction", turn };
    }

    // ---------------------------------------------------------------- 陷阱（塔主）

    /// <summary>塔主牌：是否注册、每名玩家牌组里的卡（类型、标题、编号、本地化说明有没有）。</summary>
    private static object MasterDeckView()
    {
        var state = GameReflection.Get(Test1bMixedEncounter.Run, "State");
        var cards = state == null ? null : (GameReflection.Get(state, "Players") as System.Collections.IEnumerable)?.Cast<object>().Select(p => new
        {
            player = Test2MasterOffField.NetIdOf(p),
            deck = (GameReflection.Get(GameReflection.Get(p, "Deck")!, "Cards") as System.Collections.IEnumerable)?.Cast<object>().Select(c => new
            {
                type = c.GetType().Name,
                title = GameReflection.Get(c, "Title")?.ToString(),
                master_card = MasterCards.DefOf(c)?.Key,
            }).ToList(),
        }).ToList();
        return new { registered = MasterCards.Enabled, fail_reason = MasterCards.FailReason, types = MasterCards.Types.Count, players = cards };
    }

    /// <summary>塔主战斗中的手牌（塔主牌模式）：能量、是否塔主回合、每张牌能不能打。</summary>
    private static object MasterHandView()
    {
        var master = MasterHand.MasterPlayer();
        var pcs = master == null ? null : GameReflection.Get(master, "PlayerCombatState");
        if (pcs == null) return new { active = MasterHand.Active, error = "塔主没有战斗状态（不在战斗中？）" };
        List<object> Pile(string name) => (GameReflection.Get(GameReflection.Get(pcs, name)!, "Cards") as System.Collections.IEnumerable)?.Cast<object>().ToList() ?? [];
        return new
        {
            active = MasterHand.Active,
            energy = GameReflection.Get(pcs, "Energy"),
            hand = Pile("Hand").Select((c, i) => new
            {
                index = i,
                title = GameReflection.Get(c, "Title")?.ToString(),
                key = MasterCards.DefOf(c)?.Key,
                target = GameReflection.Get(c, "TargetType")?.ToString(),
                can_play = CanPlay(c),
            }),
            draw_pile = Pile("DrawPile").Count,
            discard_pile = Pile("DiscardPile").Count,
        };
    }

    private static object CanPlay(object card)
    {
        var m = card.GetType().GetMethods(GameReflection.All).FirstOrDefault(x => x.Name == "CanPlay" && x.GetParameters().Length == 2);
        if (m == null) return "unknown";
        var args = new object?[] { null, null };
        bool ok = (bool)m.Invoke(card, args)!;
        return ok ? true : $"false:{args[0]}";
    }

    /// <summary>塔主打出手牌第 index 张（和在原版手牌上拖牌一样走 CardModel.TryManualPlay）。monster = 敌人下标，player = 玩家联机 id。</summary>
    private static object MasterPlay(System.Text.Json.Nodes.JsonObject a)
    {
        var master = MasterHand.MasterPlayer() ?? throw new InvalidOperationException("找不到塔主");
        var pcs = GameReflection.Get(master, "PlayerCombatState") ?? throw new InvalidOperationException("塔主不在战斗中");
        var hand = (GameReflection.Get(GameReflection.Get(pcs, "Hand")!, "Cards") as System.Collections.IEnumerable)!.Cast<object>().ToList();
        int index = a["index"]?.GetValue<int>() ?? 0;
        if (index < 0 || index >= hand.Count) return new { error = "unknown_option", message = $"手牌只有 {hand.Count} 张" };
        var card = hand[index];
        object? target = null;
        if (a["monster"] is { } mi && ThreatPhase.CombatState() is { } combat)
            target = (GameReflection.Get(combat, "Enemies") as System.Collections.IEnumerable)?.Cast<object>().ElementAtOrDefault(mi.GetValue<int>());
        else if (a["player"] is { } pi)
        {
            var state = GameReflection.Get(Test1bMixedEncounter.Run, "State");
            var p = (GameReflection.Get(state!, "Players") as System.Collections.IEnumerable)?.Cast<object>().FirstOrDefault(x => Test2MasterOffField.NetIdOf(x) == pi.GetValue<ulong>());
            target = p == null ? null : GameReflection.Get(p, "Creature");
        }
        var play = card.GetType().GetMethods(GameReflection.All).First(x => x.Name == "TryManualPlay" && x.GetParameters().Length == 1);
        bool ok = (bool)play.Invoke(card, [target])!;
        return new { played = ok, title = GameReflection.Get(card, "Title")?.ToString(), can_play = CanPlay(card) };
    }

    private static object Traps()
    {
        if (!Test3MasterAutoPilot.LocalIsMaster) throw Fail("not_host", "陷阱只在塔主（房主）这边");
        var tracker = TrapPhase.Tracker;
        var draft = SummonPhase.Draft is { Done: false } c ? c.Draft : null;
        return new
        {
            hand = MasterLedger.Traps.Select((t, i) => new { index = i, id = t.ToString(), name = t.Name, text = t.Describe(), cooling = MasterLedger.LastPlaced.Contains(t.Id) }),
            last_placed = MasterLedger.LastPlaced,
            placed_this_combat = tracker?.Placed.Select(t => t.ToString()),
            unfired_this_combat = tracker?.Unfired.Select(t => t.ToString()),
            fired_count = tracker?.FiredCount,
            draft = draft == null ? null : DraftJson(draft),
        };
    }

    private static object DraftJson(Core.TrapDraft d) => new
    {
        act = d.ActNo,
        budget = d.Budget,
        spent = d.Spent,
        max_picks = d.MaxPicks,
        hand_limit = d.HandLimit,
        picked = d.Picked,
        problems = d.Problems.Select(p => p.ToString()),
        offer = d.Offer.Select((t, i) => new { index = i, id = t.ToString(), name = t.Name, cost = t.Def.DraftCost, text = t.Describe(), owned = d.Owned(i), can_add = d.CanAdd(i) }),
    };

    /// <summary>选陷阱：整份替换选择（picks 是候选序号）。</summary>
    private static object TrapDraftSelect(JsonObject a)
    {
        var choice = SummonPhase.Draft is { Done: false } c ? c : throw Fail("invalid_phase", "现在没有要选的陷阱");
        var picks = a["picks"] is JsonArray arr ? arr.Select(n => n!.GetValue<int>()).ToList() : [];
        if (!choice.Set(picks)) throw Fail("rejected_rule", "这样选不行（超预算、超张数、手牌满或已有同种）");
        return DraftJson(choice.Draft);
    }

    private static object TrapDraftConfirm()
    {
        var choice = SummonPhase.Draft is { Done: false } c ? c : throw Fail("invalid_phase", "现在没有要选的陷阱");
        var names = choice.Draft.Picked.Select(i => choice.Draft.Offer[i].ToString()).ToList();
        if (!choice.Confirm()) throw Fail("rejected_rule", "选择不合规则");
        return new { confirmed = names, hand = MasterLedger.Traps.Select(t => t.ToString()), summon_open = SummonPhase.Current is { Done: false } };
    }

    // ---------------------------------------------------------------- 塔主回合

    private static object Threat()
    {
        if (!Test3MasterAutoPilot.LocalIsMaster) throw Fail("not_host", "塔主回合只在塔主（房主）这边");
        var (monsters, players) = ThreatPhase.Snapshot();
        return new
        {
            open = ThreatPhase.TurnOpen,
            round = ThreatPhase.Round,
            points = ThreatPhase.Session?.Points,
            points_total = ThreatPhase.Session?.Total,
            points_remaining = ThreatPhase.Session?.Remaining,
            seconds_left = ThreatPhase.Unlimited ? (double?)null : Math.Round(ThreatPhase.SecondsLeft, 1),
            strength_cap = ThreatPhase.Session?.StrengthCap,
            monsters = monsters.Select(m => new { index = m.Index, id = m.Id, name = m.Name, hp = m.Hp, max_hp = m.MaxHp, block = m.Block, strength = m.Strength, strength_from_master = m.StrengthFromMaster, heals_left = m.HealsLeft }),
            players = players.Select(p => new { net_id = p.NetId, hp = p.Hp, max_hp = p.MaxHp, block = p.Block, hand = p.Hand, powers = p.Powers }),
            ops = new[] { "block(monster)", "heal(monster)", "strength(monster)", "strength_all", "weak(player)", "vulnerable(player)", "frail(player)", "dazed(player)" },
        };
    }

    /// <summary>塔主回合操作（和面板按钮一样走 ThreatPhase.Act）。</summary>
    private static object ThreatAct(JsonObject a)
    {
        if (!Test3MasterAutoPilot.LocalIsMaster) throw Fail("not_host", "塔主回合只在塔主（房主）这边");
        if (!ThreatPhase.TurnOpen) throw Fail("invalid_phase", "现在不是塔主回合");
        var op = a["op"]?.GetValue<string>() ?? throw Fail("bad_request", "要 op");
        var before = ThreatPhase.Session?.Points;
        var (ok, message) = ThreatPhase.Act(op, a["monster"]?.GetValue<int>() ?? -1, a["player"]?.GetValue<ulong>() ?? 0);
        if (!ok) throw Fail("rejected_rule", message);
        return new { op, message, points_before = before, points_after = ThreatPhase.Session?.Points, still_open = ThreatPhase.TurnOpen };
    }

    /// <summary>操作塔主回合界面（截图用）：select 选中一张行动卡（显示战场目标按钮），cancel 取消。</summary>
    private static object ThreatUi(JsonObject a)
    {
        if (ThreatPanel.Current is not { } panel) throw Fail("invalid_phase", "塔主回合界面没有打开");
        var op = a["select"]?.GetValue<string>();
        panel.SelectByOp(op);
        return new { selected = op };
    }

    private static object ThreatEnd()
    {
        if (!ThreatPhase.TurnOpen) throw Fail("invalid_phase", "现在不是塔主回合");
        ThreatPhase.EndTurn("测试接口");
        return new { ended = true, points_left = ThreatPhase.Session?.Points };
    }

    // ---------------------------------------------------------------- 选牌界面（升级、删牌、变化等）

    /// <summary>正在显示的选牌界面：有 OnCardClicked(一个参数) 方法和 _cards 列表的节点（例如 NDeckUpgradeSelectScreen）。</summary>
    private static Godot.Node? CardScreen()
    {
        var stack = new Stack<Godot.Node>();
        stack.Push(SceneTree.Root);
        while (stack.Count > 0)
        {
            var node = stack.Pop();
            if (node is Godot.CanvasItem ci && !ci.IsVisibleInTree()) continue;
            if (node.GetType().GetMethods(GameReflection.All).Any(m => m.Name == "OnCardClicked" && m.GetParameters().Length == 1)
                && Try(() => GameReflection.Get(node, "_cards")) is IEnumerable) return node;
            foreach (var child in node.GetChildren()) stack.Push(child);
        }
        return null;
    }

    private static object Cards()
    {
        var screen = CardScreen();
        if (screen == null) return new { visible = false };
        var cards = (GameReflection.Get(screen, "_cards") as IEnumerable)!.Cast<object>()
            .Select((c, i) => new { index = i, card = c.GetType().Name, upgraded = Try(() => GameReflection.Get(c, "IsUpgraded")) }).ToList();
        return new { visible = true, screen = screen.GetType().Name, path = screen.GetPath().ToString(), cards };
    }

    /// <summary>点选第 index 张牌（和鼠标点一样）；confirm=true 时再按确认（ConfirmSelection）。</summary>
    private static object CardsPick(JsonObject a)
    {
        var screen = CardScreen() ?? throw Fail("invalid_phase", "没有显示选牌界面");
        int index = a["index"]?.GetValue<int>() ?? throw Fail("bad_request", "要 index");
        var cards = (GameReflection.Get(screen, "_cards") as IEnumerable)!.Cast<object>().ToList();
        if (index < 0 || index >= cards.Count) throw Fail("bad_request", $"只有 {cards.Count} 张牌");
        RuntimeNetAction.Call(screen, "OnCardClicked", cards[index]);
        bool confirmed = false;
        if (a["confirm"]?.GetValue<bool>() == true)
        {
            var confirm = screen.GetType().GetMethods(GameReflection.All).FirstOrDefault(m => m.Name == "ConfirmSelection" && m.GetParameters().Length <= 1)
                          ?? throw Fail("unsupported", $"{screen.GetType().Name} 没有 ConfirmSelection");
            confirm.Invoke(screen, confirm.GetParameters().Length == 1 ? [null] : []);
            confirmed = true;
        }
        return new { picked = index, card = cards[index].GetType().Name, confirmed, screen = screen.GetType().Name };
    }

    private static IEnumerable<string> Texts(Godot.Node root)
    {
        var stack = new Stack<Godot.Node>();
        stack.Push(root);
        while (stack.Count > 0)
        {
            var node = stack.Pop();
            if (NodeText(node) is { Length: > 0 } t) yield return t;
            foreach (var child in node.GetChildren()) stack.Push(child);
        }
    }

    private static object LocalPlayer(object state)
    {
        var net = GameReflection.Get(RunOrNull()!, "NetService")!;
        var id = Convert.ToUInt64(GameReflection.Get(net, "NetId"));
        return (GameReflection.Get(state, "Players") as IEnumerable)!.Cast<object>().FirstOrDefault(p => Test2MasterOffField.NetIdOf(p) == id)
               ?? throw Fail("exception", $"找不到本机玩家 {id}", 500);
    }

    private static object? FindMemberOfType(object owner, string typeName)
    {
        for (var t = owner.GetType(); t != null; t = t.BaseType)
        {
            foreach (var f in t.GetFields(GameReflection.All | BindingFlags.DeclaredOnly))
                if (!f.IsStatic && f.FieldType.Name == typeName && f.GetValue(owner) is { } v) return v;
            foreach (var p in t.GetProperties(GameReflection.All | BindingFlags.DeclaredOnly))
                if (p.PropertyType.Name == typeName && p.GetIndexParameters().Length == 0 && p.GetMethod is { IsStatic: false }
                    && p.GetValue(owner) is { } v) return v;
        }
        return null;
    }

    // ---------------------------------------------------------------- 控制台

    /// <summary>开发者控制台命令（例如 win）：把命令写进控制台输入框再按原版提交，联机命令照原版广播。</summary>
    private static async Task<object?> ConsoleCommand(JsonObject a)
    {
        var command = a["command"]?.GetValue<string>() ?? throw Fail("bad_request", "要 command");
        var type = RuntimeNetAction.Required("NDevConsole");
        var console = type.GetProperty("Instance", GameReflection.All)!.GetValue(null);
        if (console == null)
        {
            if (type.GetMethod("Create", GameReflection.All)?.Invoke(null, null) is not Godot.Node layer)
                throw Fail("unsupported", "这个版本不能创建开发者控制台");
            SceneTree.Root.AddChild(layer);
            await SceneTree.ToSignal(SceneTree, Godot.SceneTree.SignalName.ProcessFrame);
            console = type.GetProperty("Instance", GameReflection.All)!.GetValue(null) ?? throw Fail("unsupported", "控制台没有初始化");
        }
        if (GameReflection.Get(console, "_inputBuffer") is not Godot.LineEdit input) throw Fail("unsupported", "找不到控制台输入框");
        input.Text = command;
        RuntimeNetAction.Call(console, "ProcessCommand");
        Log.Info($"测试接口：控制台 {command}");
        var output = GameReflection.Get(console, "_outputBuffer") is Godot.RichTextLabel o ? o.GetParsedText() : "";
        return new { command, output_tail = output.Length > 600 ? output[^600..] : output };
    }

    // ---------------------------------------------------------------- 日志、截图

    /// <summary>从游标（字节位置）开始读日志；文件变短（重开）时从头读。</summary>
    private static object Logs(JsonObject a)
    {
        var source = a["source"]?.GetValue<string>() ?? "mod";
        var path = source switch
        {
            "mod" => Log.FilePath,
            "game" => Environment.GetEnvironmentVariable("TOWERMASTER_GAME_LOG"),
            "balance" => BalanceLog.FilePath,
            _ => throw Fail("bad_request", "source 只能是 mod、game 或 balance"),
        };
        if (string.IsNullOrEmpty(path) || !File.Exists(path)) throw Fail("unsupported", $"没有 {source} 日志文件（game 日志要设 TOWERMASTER_GAME_LOG）");
        long cursor = a["cursor"]?.GetValue<long>() ?? 0;
        int max = a["max_bytes"]?.GetValue<int>() ?? 256 * 1024;
        using var file = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite | FileShare.Delete);
        bool reset = cursor > file.Length;
        if (reset) cursor = 0;
        file.Seek(cursor, SeekOrigin.Begin);
        var buffer = new byte[Math.Min(max, file.Length - cursor)];
        int read = file.Read(buffer, 0, buffer.Length);
        // 不在 UTF-8 字符中间截断：退回到最后一个完整行
        int end = read;
        if (cursor + read < file.Length) { int nl = Array.LastIndexOf(buffer, (byte)'\n', Math.Max(0, read - 1)); if (nl >= 0) end = nl + 1; }
        return new { source, path, cursor = cursor + end, reset, more = cursor + end < file.Length, text = Encoding.UTF8.GetString(buffer, 0, end) };
    }

    private static Godot.SceneTree SceneTree => (Godot.SceneTree)Godot.Engine.GetMainLoop();

    private static object Screenshot(JsonObject a)
    {
        var name = a["name"]?.GetValue<string>() ?? DateTime.Now.ToString("HHmmss_fff");
        if (name.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0) throw Fail("bad_request", "name 里有不能用作文件名的字符");
        var dir = Environment.GetEnvironmentVariable("TOWERMASTER_BRIDGE_SHOTS") ?? Path.Combine(Log.ModDir, "screenshots");
        Directory.CreateDirectory(dir);
        var path = Path.Combine(dir, name + ".png");
        var image = SceneTree.Root.GetTexture().GetImage();
        var error = image.SavePng(path);
        if (error != Godot.Error.Ok) throw Fail("exception", $"保存截图失败：{error}", 500);
        return new { path, width = image.GetWidth(), height = image.GetHeight(), window_mode = Godot.DisplayServer.WindowGetMode().ToString() };
    }

    // ---------------------------------------------------------------- 场景树、反射（给知道游戏源码的测试助手兜底用）

    private static object Tree(JsonObject a)
    {
        var filter = a["contains"]?.GetValue<string>();
        bool visibleOnly = a["visible_only"]?.GetValue<bool>() ?? true;
        int max = a["max"]?.GetValue<int>() ?? 200;
        var root = a["root"]?.GetValue<string>() is { } rp ? SceneTree.Root.GetNodeOrNull(rp) ?? throw Fail("not_found", $"没有节点 {rp}", 404) : SceneTree.Root;
        var found = new List<object>();
        var stack = new Stack<Godot.Node>();
        stack.Push(root);
        while (stack.Count > 0 && found.Count < max)
        {
            var node = stack.Pop();
            bool visible = node is not Godot.CanvasItem ci || ci.IsVisibleInTree();
            if (visibleOnly && !visible) continue;
            var typeName = node.GetType().Name;
            if (filter == null || typeName.Contains(filter, StringComparison.OrdinalIgnoreCase) || node.Name.ToString().Contains(filter, StringComparison.OrdinalIgnoreCase))
                found.Add(new { path = node.GetPath().ToString(), type = typeName, name = node.Name.ToString(), visible, text = NodeText(node) });
            var children = node.GetChildren();
            for (int i = children.Count - 1; i >= 0; i--) stack.Push(children[i]);
        }
        return new { count = found.Count, truncated = found.Count >= max, nodes = found };
    }

    private static string? NodeText(Godot.Node node)
    {
        var text = node switch
        {
            Godot.RichTextLabel r => r.GetParsedText(),
            Godot.Label l => l.Text,
            Godot.Button b => b.Text,
            Godot.LineEdit e => e.Text,
            _ => null,
        };
        return text is { Length: > 80 } ? text[..80] + "…" : text;
    }

    private static async Task<object?> NodeCall(JsonObject a)
    {
        var path = a["path"]?.GetValue<string>() ?? throw Fail("bad_request", "要 path");
        var node = SceneTree.Root.GetNodeOrNull(path) ?? throw Fail("not_found", $"没有节点 {path}", 404);
        return await Invoke(node, a);
    }

    /// <summary>
    /// 反射读写：target 是路径，开头是 run（RunManager.Instance）、state（当前对局）、combat（当前战斗）、
    /// node:/root/...（场景树节点）或 type:类型名（静态成员），后面用 .成员 和 [下标] 往下走。
    /// 给了 method 就调用它（参数见 <see cref="ConvertArg"/>），否则返回目标的内容。
    /// </summary>
    private static async Task<object?> Reflect(JsonObject a)
    {
        var target = a["target"]?.GetValue<string>() ?? throw Fail("bad_request", "要 target");
        var (obj, staticType) = Resolve(target);
        if (a["method"] != null) return await Invoke(obj, a, staticType);
        return new { value = ToJson(obj, a["depth"]?.GetValue<int>() ?? 1) };
    }

    private static async Task<object?> Invoke(object? obj, JsonObject a, Type? staticType = null)
    {
        var name = a["method"]?.GetValue<string>() ?? throw Fail("bad_request", "要 method");
        var args = a["args"] as JsonArray ?? new JsonArray();
        var type = staticType ?? obj?.GetType() ?? throw Fail("bad_request", "目标是 null");
        var flags = GameReflection.All | (staticType != null ? BindingFlags.Static : BindingFlags.Instance);
        MethodInfo? method = null;
        for (var t = type; t != null && method == null; t = t.BaseType)
            method = t.GetMethods(flags | BindingFlags.DeclaredOnly).FirstOrDefault(m => m.Name == name && m.GetParameters().Length == args.Count);
        if (method == null) throw Fail("not_found", $"{type.Name} 没有 {args.Count} 个参数的方法 {name}", 404);
        var parameters = method.GetParameters();
        var values = parameters.Select((p, i) => ConvertArg(args[i], p.ParameterType)).ToArray();
        var result = method.Invoke(staticType != null ? null : obj, values);
        if (result is Task task && a["await"]?.GetValue<bool>() != false)
        {
            await task;
            result = task.GetType().IsGenericType ? task.GetType().GetProperty("Result")!.GetValue(task) : null;
        }
        return new { method = GameReflection.Describe(method), value = ToJson(result, a["depth"]?.GetValue<int>() ?? 1) };
    }

    private static (object? Obj, Type? StaticType) Resolve(string target)
    {
        var parts = SplitPath(target);
        object? obj;
        Type? staticType = null;
        var head = parts[0];
        if (head == "run") obj = RunOrNull();
        else if (head == "state") obj = StateOrNull();
        else if (head == "combat") obj = CombatState();
        else if (head.StartsWith("node:")) obj = SceneTree.Root.GetNodeOrNull(head[5..]) ?? throw Fail("not_found", $"没有节点 {head[5..]}", 404);
        else if (head.StartsWith("type:"))
        {
            staticType = AnyType(head[5..]) ?? throw Fail("not_found", $"没有类型 {head[5..]}", 404);
            obj = null;
        }
        else throw Fail("bad_request", "target 要以 run、state、combat、node:路径 或 type:类型名 开头");

        foreach (var part in parts.Skip(1))
        {
            if (part.StartsWith('['))
            {
                int index = int.Parse(part[1..^1]);
                obj = obj is IList list ? list[index] : (obj as IEnumerable)?.Cast<object?>().ElementAt(index);
            }
            else if (staticType != null)
            {
                var member = (MemberInfo?)staticType.GetProperty(part, GameReflection.All | BindingFlags.Static) ?? staticType.GetField(part, GameReflection.All | BindingFlags.Static);
                obj = member switch
                {
                    PropertyInfo p => p.GetValue(null),
                    FieldInfo f => f.GetValue(null),
                    _ => throw Fail("not_found", $"{staticType.Name} 没有静态成员 {part}", 404),
                };
                staticType = null;
            }
            else
            {
                if (obj == null) throw Fail("not_found", $"走到 {part} 之前就是 null", 404);
                obj = GameReflection.Get(obj, part);
            }
        }
        return (obj, staticType);
    }

    /// <summary>按短名或全名找类型：先找游戏程序集，再找所有已加载的程序集（例如 Godot.DisplayServer）。</summary>
    private static Type? AnyType(string name)
    {
        var game = GameReflection.Types.FirstOrDefault(t => t.FullName == name) ?? GameReflection.TypeNamed(name);
        if (game != null) return game;
        foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
        {
            Type[] types;
            try { types = assembly.GetTypes(); } catch (ReflectionTypeLoadException e) { types = e.Types.Where(t => t != null).ToArray()!; }
            var hit = types.FirstOrDefault(t => t.FullName == name) ?? types.FirstOrDefault(t => t.Name == name);
            if (hit != null) return hit;
        }
        return null;
    }

    private static List<string> SplitPath(string target)
    {
        // node:/root/a/b 里的 / 和 . 不拆；后面 .x[0].y 照常拆
        string head = target, rest = "";
        // node: 和 type: 后面可能有 / 和 .（节点路径、类型全名），用 | 接成员
        int cut = target.StartsWith("node:") || target.StartsWith("type:") ? target.IndexOf('|') : target.IndexOfAny(['.', '[']);
        if (cut >= 0) { head = target[..cut]; rest = target[cut..].TrimStart('|'); }
        var parts = new List<string> { head };
        var sb = new StringBuilder();
        foreach (var ch in rest)
        {
            if (ch == '.') { if (sb.Length > 0) parts.Add(sb.ToString()); sb.Clear(); }
            else if (ch == '[') { if (sb.Length > 0) parts.Add(sb.ToString()); sb.Clear(); sb.Append(ch); }
            else if (ch == ']') { sb.Append(ch); parts.Add(sb.ToString()); sb.Clear(); }
            else sb.Append(ch);
        }
        if (sb.Length > 0) parts.Add(sb.ToString());
        return parts;
    }

    /// <summary>
    /// JSON 参数转成方法参数：数字、字符串、布尔、null 直接转；枚举用名字；
    /// {"ref": "路径"} 取路径上的对象；{"new": "类型名", "args": [...]} 现造一个（例如 MapCoord）。
    /// </summary>
    internal static object? ConvertArg(JsonNode? node, Type type)
    {
        var target = Nullable.GetUnderlyingType(type) ?? type;
        if (node == null) return null;
        if (node is JsonObject o)
        {
            if (o["ref"] is { } r) return Resolve(r.GetValue<string>()).Obj;
            if (o["new"] is { } n)
            {
                var t = AnyType(n.GetValue<string>()) ?? throw Fail("not_found", $"没有类型 {n}", 404);
                var ctorArgs = o["args"] as JsonArray ?? new JsonArray();
                var ctor = t.GetConstructors(GameReflection.All).FirstOrDefault(c => c.GetParameters().Length == ctorArgs.Count)
                           ?? throw Fail("not_found", $"{t.Name} 没有 {ctorArgs.Count} 个参数的构造函数", 404);
                return ctor.Invoke(ctor.GetParameters().Select((p, i) => ConvertArg(ctorArgs[i], p.ParameterType)).ToArray());
            }
            throw Fail("bad_request", "对象参数只支持 {\"ref\":…} 或 {\"new\":…}");
        }
        if (target.IsEnum) return Enum.Parse(target, node.GetValue<string>());
        if (target == typeof(string)) return node.GetValue<string>();
        if (target == typeof(object)) return node.GetValue<JsonElement>().ToString();
        return node.Deserialize(target);
    }

    /// <summary>对象转成 JSON 能表达的东西：基本类型照写，列表最多 50 项，其他对象列出公开属性和字段（depth 层）。</summary>
    internal static object? ToJson(object? value, int depth)
    {
        switch (value)
        {
            case null: return null;
            case string or bool or char: return value;
            case Enum e: return e.ToString();
            case IFormattable f when value.GetType().IsPrimitive || value is decimal: return value;
            case Godot.Node n: return new Dictionary<string, object?> { ["$type"] = n.GetType().Name, ["path"] = n.IsInsideTree() ? n.GetPath().ToString() : null };
        }
        if (value is IEnumerable seq)
        {
            if (depth < 0) return $"[{value.GetType().Name}]";
            return seq.Cast<object?>().Take(50).Select(v => ToJson(v, depth - 1)).ToList();
        }
        var type = value.GetType();
        var result = new Dictionary<string, object?> { ["$type"] = GameReflection.TypeName(type) };
        if (depth < 0) { result["$text"] = Try(value.ToString); return result; }
        foreach (var p in type.GetProperties(BindingFlags.Public | BindingFlags.Instance).Where(p => p.GetIndexParameters().Length == 0).Take(60))
            result[p.Name] = Try(() => ToJson(p.GetValue(value), depth - 1));
        foreach (var f in type.GetFields(BindingFlags.Public | BindingFlags.Instance).Take(60))
            result[f.Name] = Try(() => ToJson(f.GetValue(value), depth - 1));
        return result;
    }
}
