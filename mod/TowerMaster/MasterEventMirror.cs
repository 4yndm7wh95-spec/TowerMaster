using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using HarmonyLib;
using TowerMaster.Core;
using G = Godot;

namespace TowerMaster;

/// <summary>
/// 问号事件的塔主玩法：玩家处理原版事件时，塔主那一份换成一个塔主事件（<see cref="MasterEvents"/>，按种子 + 楼层挑）。
/// 和先古祝福同一个思路（docs/game-api/events-054-flow.md）：
/// - 原版每个客户端都给每名玩家生成一份事件、各自生成选项；选中后原版把「第几个」发给所有端，各端执行同一个选项。
///   所以塔主那份的选项在各端用同样的输入生成，同步交给原版。
/// - 选项回调各端都会跑：结果页（SetEventFinished）各端一样；召唤点、陷阱、牌组这些塔主账本只在房主（塔主）上改，
///   牌组变化照旧发 deck 指令。账本里记一个「这层事件处理过」，读档重进不会重复拿。
/// - 跳过：共享事件（选项序号对所有玩家生效，不能只换塔主的）、非默认布局（自定义/战斗）的事件、先古（另见 MasterAncient）。
/// - 画面只在塔主自己的机器上换：标题、首页说明、配图（art/event_*.png）和环境动效（MasterEventAmbience）。
/// </summary>
internal static class MasterEventMirror
{
    private sealed record Mirror(MasterEventDef Def, ulong Seed, int Floor, int ActNo)
    {
        public int RewardId => -(Floor * 10 + 8);
    }

    private static readonly ConditionalWeakTable<object, Mirror> Mirrors = new();
    private static readonly ConditionalWeakTable<object, object> MergedTables = new();
    private static bool _patched;

    /// <summary>测试用：下一次塔主事件强制用这个（两端都要设，否则选项不一致）。用一次就清掉。</summary>
    internal static string? ForceNext { get; set; }

    internal static void Apply(Harmony harmony)
    {
        if (_patched) return;
        _patched = true;
        var eventModel = GameReflection.TypesNamed("EventModel").FirstOrDefault(t => t.IsAbstract) ?? throw new TypeLoadException("EventModel");
        var ancient = GameReflection.TypesNamed("AncientEventModel").FirstOrDefault(t => t.IsAbstract);
        var after = new HarmonyMethod(typeof(MasterEventMirror).GetMethod(nameof(AfterGenerate), GameReflection.All)!);
        int count = 0;
        foreach (var type in eventModel.Assembly.GetTypes().Where(t => eventModel.IsAssignableFrom(t) && t != eventModel && (ancient == null || !ancient.IsAssignableFrom(t))))
        {
            var m = type.GetMethod("GenerateInitialOptions", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly);
            if (m == null || m.IsAbstract) continue;
            harmony.Patch(m, postfix: after);
            count++;
        }
        void Post(string method, string type, string handler)
        {
            var target = GameReflection.FindMethod(method, type);
            if (target == null) { Log.Warn($"塔主事件：找不到 {type}.{method}，塔主那边的{handler}还是原版的"); return; }
            harmony.Patch(target, postfix: new HarmonyMethod(typeof(MasterEventMirror).GetMethod(handler, GameReflection.All)!));
        }
        Post("SetTitle", "NEventRoom", nameof(AfterSetTitle));
        Post("SetDescription", "NEventRoom", nameof(AfterSetDescription));
        Post("SetEvent", "NEventLayout", nameof(AfterSetEvent));
        var getTable = RuntimeNetAction.Required("LocManager").GetMethods(GameReflection.All)
            .FirstOrDefault(m => m.Name == "GetTable" && m.GetParameters().Length == 1 && m.GetParameters()[0].ParameterType == typeof(string));
        if (getTable != null) harmony.Patch(getTable, postfix: new HarmonyMethod(typeof(MasterEventMirror).GetMethod(nameof(AfterGetTable), GameReflection.All)!));
        else Log.Warn("塔主事件：找不到 LocManager.GetTable，选项文字会显示成 key");
        Log.Info($"塔主事件：已挂到 {count} 个事件");
    }

    // ---------------------------------------------------------------- 选项（各端）

    private static void AfterGenerate(object __instance, ref object __result)
    {
        try
        {
            var owner = GameReflection.Get(__instance, "Owner");
            if (owner == null || Test2MasterOffField.MasterId is not { } masterId || Test2MasterOffField.NetIdOf(owner) != masterId) return;
            if (GameReflection.Get(__instance, "IsShared") is true) { Log.Info($"塔主事件：{__instance.GetType().Name} 是共享事件，塔主照原版"); return; }
            if (GameReflection.Get(__instance, "LayoutType")?.ToString() is { } layout && layout != "Default")
            {
                Log.Info($"塔主事件：{__instance.GetType().Name} 布局是 {layout}，塔主照原版");
                return;
            }
            var state = GameReflection.Get(Test1bMixedEncounter.Run, "State") ?? throw new InvalidOperationException("没有对局状态");
            var seed = Convert.ToUInt64(GameReflection.Get(GameReflection.Get(state, "Rng")!, "Seed"));
            int floor = Convert.ToInt32(GameReflection.Get(state, "TotalFloor"));
            var def = ForceNext is { } forced && MasterEvents.Find(forced) is { } f ? f : MasterEvents.Pick(seed, floor);
            ForceNext = null;
            var mirror = new Mirror(def, seed, floor, ThreatPhase.ActNoOf(state));
            __result = BuildOptions(__instance, mirror);
            Mirrors.AddOrUpdate(__instance, mirror);
            Log.Info($"塔主事件：第 {floor} 层 {__instance.GetType().Name}，塔主那份换成「{mirror.Def.Title}」");
        }
        catch (Exception e) { Log.Error("塔主事件：换选项失败，塔主这次看到原版事件", e); }
    }

    private static IList BuildOptions(object model, Mirror mirror)
    {
        var optionType = GameReflection.TypesNamed("EventOption").First();
        var tipType = GameReflection.TypesNamed("IHoverTip").First(t => t.IsInterface);
        var ctor = optionType.GetConstructors().First(c =>
        {
            var p = c.GetParameters();
            return p.Length == 6 && p[2].ParameterType.Name == "LocString" && p[3].ParameterType.Name == "LocString";
        });
        var noTips = Array.CreateInstance(tipType, 0);
        var list = (IList)Activator.CreateInstance(typeof(List<>).MakeGenericType(optionType))!;
        foreach (var o in mirror.Def.Options)
        {
            var key = $"{mirror.Def.LocKey}.pages.INITIAL.options.{o.Key}";
            var choice = o.Key;
            Func<Task> chosen = () => Choose(model, mirror, choice);
            var option = ctor.Invoke([model, chosen, Loc($"{key}.title"), Loc($"{key}.description"), key, noTips]);
            // 不写进原版跑图历史（历史界面按原版事件 key 查文字）
            optionType.GetMethod("ThatWontSaveToChoiceHistory")?.Invoke(option, null);
            list.Add(option);
        }
        return list;
    }

    private static object Loc(string key) => Activator.CreateInstance(RuntimeNetAction.Required("LocString"), "events", key)!;

    /// <summary>各端：执行塔主选的选项，然后结束事件（结果页）。账本只在房主上改。</summary>
    private static Task Choose(object model, Mirror mirror, string choice)
    {
        string result = choice;
        try
        {
            bool host = Test3MasterAutoPilot.LocalIsMaster;
            if (host)
            {
                MasterLedger.For(mirror.Seed, mirror.ActNo);
                if (MasterLedger.RewardTaken(mirror.RewardId)) Log.Warn($"塔主事件：第 {mirror.Floor} 层的事件已经处理过（读档？），这次不再给东西");
                else
                {
                    result = ApplyOnHost(mirror, choice);
                    MasterLedger.MarkReward(mirror.RewardId);
                }
            }
            else result = GuessForClimber(mirror, choice);
            Log.Info($"塔主事件：「{mirror.Def.Title}」塔主选了 {choice} → {result}");
            if (!host) SummonPhase.Notify($"塔主在问号房遇到了「{mirror.Def.Title}」", mirror.Def.Options.FirstOrDefault(o => o.Key == choice)?.Title ?? "", "master_portrait");
        }
        catch (Exception e) { Log.Error($"塔主事件：执行 {choice} 失败", e); }
        try
        {
            if (!mirror.Def.Results.ContainsKey(result)) result = mirror.Def.Results.Keys.First();
            var finish = model.GetType().GetMethods(GameReflection.All).First(m => m.Name == "SetEventFinished" && m.GetParameters().Length == 1);
            finish.Invoke(model, [Loc($"{mirror.Def.LocKey}.pages.{result}.description")]);
        }
        catch (Exception e) { Log.Error("塔主事件：结束事件失败（塔主可能卡在事件页）", e); }
        return Task.CompletedTask;
    }

    /// <summary>房主：按选项改塔主账本，返回结果页 key。</summary>
    private static string ApplyOnHost(Mirror m, string choice)
    {
        int Pick(int salt, int count) => MasterEvents.Index(m.Seed, m.Floor, salt, count);
        string tag = $"塔主事件「{m.Def.Title}」";
        switch (m.Def.Id, choice)
        {
            case ("black_market", "BUY"):
            {
                if (!MasterLedger.SpendPoints(MasterEvents.BlackMarketPrice, tag)) return "BROKE";
                var op = MasterCards.RewardPool[Pick(3, MasterCards.RewardPool.Length)];
                MasterLedger.AddExtraCard(op, tag);
                MasterDeck.Publish(tag);
                Notice("黑市买到了", CardTitle(op));
                return "BUY";
            }
            case ("casino", "GAMBLE"):
                if (MasterEvents.GambleWins(m.Seed, m.Floor)) { MasterLedger.GainPoints(MasterEvents.GambleWin, tag); return "WIN"; }
                MasterLedger.SpendPoints(Math.Min(MasterEvents.GambleLose, MasterLedger.Wallet?.Points ?? 0), tag);
                return "LOSE";
            case ("overtime", "WORK"):
            {
                var upgradable = MasterLedger.Traps.Select((t, i) => (t, i)).Where(x => x.t.Tier < 3).Select(x => x.i).ToList();
                if (upgradable.Count == 0) { MasterLedger.GainPoints(MasterEvents.OvertimeConsolation, tag); return "WORK_NONE"; }
                if (MasterLedger.UpgradeTrap(upgradable[Pick(4, upgradable.Count)], tag) is { } card) Notice("加班成果", $"{card.Name}");
                return "WORK";
            }
            case ("overtime", "SLACK"):
                MasterLedger.GainPoints(MasterEvents.SlackPoints, tag);
                return "SLACK";
            case ("monster_union", "HIRE"):
            {
                if (MasterLedger.Traps.Count >= ModEntry.Active.TrapHandLimit) return "FULL";
                var owned = MasterLedger.Traps.Select(t => t.Id).ToHashSet();
                var pool = TrapCatalog.All.Where(d => d.Id != "bluff" && !owned.Contains(d.Id)).ToList();
                if (pool.Count == 0) return "FULL";
                if (!MasterLedger.SpendPoints(MasterEvents.UnionFee, tag)) return "BROKE";
                var trap = new TrapCard(pool[Pick(5, pool.Count)].Id, Math.Clamp(m.ActNo, 1, 3));
                MasterLedger.AddTraps([trap], tag);
                MasterDeck.Publish(tag);
                Notice("工会派来的陷阱", trap.Name);
                return "HIRE";
            }
            case ("master_worry", "TOSS"):
            {
                var actions = MasterLedger.ActionCards();
                if (actions.Count <= ModEntry.Active.MasterMinDeck) return "TOSS_NONE";
                var op = actions[Pick(6, actions.Count)];
                MasterLedger.RemoveAction(m.RewardId, op);
                MasterDeck.Publish(tag);
                Notice("扔掉了", CardTitle(op));
                return "TOSS";
            }
            case ("master_worry", "COPY"):
            {
                var actions = MasterLedger.ActionCards();
                if (actions.Count == 0 || !MasterLedger.SpendPoints(MasterEvents.CopyPrice, tag)) return "BROKE";
                var op = actions[Pick(7, actions.Count)];
                MasterLedger.AddExtraCard(op, tag);
                MasterDeck.Publish(tag);
                Notice("复印了", CardTitle(op));
                return "COPY";
            }
            default:
                return choice; // 离开、不赌、不交会费：没有效果
        }
    }

    /// <summary>爬塔玩家的机器上没有塔主账本：能算的照算（赌场），其余按「成功」那一页（玩家看不到塔主的事件页，只影响日志）。</summary>
    private static string GuessForClimber(Mirror m, string choice) => (m.Def.Id, choice) switch
    {
        ("casino", "GAMBLE") => MasterEvents.GambleWins(m.Seed, m.Floor) ? "WIN" : "LOSE",
        _ => choice,
    };

    private static void Notice(string title, string detail) => SummonPhase.Notify(title, detail, "master_portrait");

    private static string CardTitle(string op) =>
        MasterCards.TypeOf($"act:{op}@1") is { } t ? MasterCards.DefOf(MasterCards.Canonical(t))?.Title ?? op : op;

    // ---------------------------------------------------------------- 画面（只在塔主自己的机器上）

    private static Mirror? LocalMirror(object? model) =>
        model != null && Test3MasterAutoPilot.LocalIsMaster && Mirrors.TryGetValue(model, out var m) ? m : null;

    private static void AfterSetTitle(object __instance)
    {
        try
        {
            if (LocalMirror(GameReflection.Get(__instance, "_event")) is not { } m) return;
            if (GameReflection.Get(__instance, "Layout") is { } layout) RuntimeNetAction.Call(layout, "SetTitle", m.Def.Title);
        }
        catch (Exception e) { Log.Warn($"塔主事件：换标题失败：{e.Message}"); }
    }

    /// <summary>首页说明换成塔主事件的；结果页本来就是我们的 key，不动。</summary>
    private static void AfterSetDescription(object __instance, object[] __args)
    {
        try
        {
            if (LocalMirror(GameReflection.Get(__instance, "_event")) is not { } m) return;
            var key = __args.FirstOrDefault() is { } loc ? GameReflection.Get(loc, "LocEntryKey") as string : null;
            if (key != null && key.StartsWith(m.Def.LocKey, StringComparison.Ordinal)) return;
            if (GameReflection.Get(__instance, "Layout") is { } layout) RuntimeNetAction.Call(layout, "SetDescription", m.Def.Description);
        }
        catch (Exception e) { Log.Warn($"塔主事件：换说明失败：{e.Message}"); }
    }

    /// <summary>配图换成塔主事件的，去掉原版事件挂在配图上的动效，换上我们的。</summary>
    private static void AfterSetEvent(object __instance, object[] __args)
    {
        try
        {
            if (LocalMirror(__args.FirstOrDefault()) is not { } m) return;
            if (Art.Get($"event_{m.Def.Id}") is not { } texture) { Log.Warn($"塔主事件：没有配图 event_{m.Def.Id}.png，用原版的"); return; }
            RuntimeNetAction.Call(__instance, "RemoveNodesOnPortrait");
            var setPortrait = __instance.GetType().GetMethods(GameReflection.All).First(x => x.Name == "SetPortrait" && x.GetParameters().Length == 2);
            setPortrait.Invoke(__instance, [texture, null]);
            if (GameReflection.Get(__instance, "_portrait") is G.Control portrait) MasterEventAmbience.Attach(portrait, m.Def.Id);
            Log.Info($"塔主事件：配图换成 event_{m.Def.Id}.png");
        }
        catch (Exception e) { Log.Warn($"塔主事件：换配图失败：{e.Message}"); }
    }

    private static void AfterGetTable(object? __result, object[] __args)
    {
        try
        {
            if (__result == null || __args[0] as string != "events") return;
            if (!MergedTables.TryAdd(__result, true)) return; // 每个表对象只补一次（换语言会新建表）
            var entries = MasterEvents.LocEntries();
            RuntimeNetAction.Call(__result, "MergeWith", entries);
            Log.Info($"塔主事件：本地化表 events 补了 {entries.Count} 条");
        }
        catch (Exception e) { Log.Warn($"塔主事件：补本地化失败：{e.Message}"); }
    }
}
