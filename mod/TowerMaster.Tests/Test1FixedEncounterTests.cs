using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Models.Encounters;
using MegaCrit.Sts2.Core.Rooms;
using Xunit;

namespace TowerMaster.Tests;

/// <summary>用假的 sts2 程序集跑一遍真正的 Harmony 补丁，验证测试 1a 的反射流程。</summary>
public class Test1FixedEncounterTests
{
    private static readonly object InitLock = new();
    private static bool _initialized;

    private static void InitMod()
    {
        lock (InitLock)
        {
            if (_initialized) return;
            _ = typeof(CombatRoom).Assembly; // 确保假 sts2 已加载
            Log.Init();
            GameProbe.Run();
            Test1FixedEncounter.Apply(new HarmonyLib.Harmony("towermaster.test1a"), new TestSettings
            {
                Test1FixedEncounter = true,
                FixedEncounters = new() { ["Overgrowth"] = "NibbitsNormal", ["Underdocks"] = "CultistsNormal" },
            }, TowerMaster.Core.PriceBook.Load(Path.Combine(Log.ModDir, "price_book.data")));
            _initialized = true;
        }
    }

    private static string LogText() => File.ReadAllText(Path.Combine(Log.ModDir, "TowerMaster.log"));

    [Fact]
    public void ReplacesNormalRoomEncounterBeforeMonstersAreGenerated()
    {
        InitMod();
        var room = new CombatRoom((EncounterModel)new ActModel(ModelDb.Encounter<MawlerNormal>()).PullNextEncounter(RoomType.Monster).ToMutable());
        room.StartCombat();

        Assert.IsType<NibbitsNormal>(room.Encounter);
        Assert.True(room.Encounter.IsMutable);
        Assert.NotSame(ModelDb.Encounter<NibbitsNormal>(), room.Encounter);
        Assert.Equal(new[] { ("Nibbit", (string?)"front"), ("Nibbit", (string?)"back") }, room.Encounter.MonstersWithSlots.Select(m => (m.Monster.GetType().Name, m.Slot)));

        var log = LogText();
        Assert.Contains("已替换 MawlerNormal → NibbitsNormal", log);
        Assert.Contains("生成 NibbitsNormal → [(Nibbit:MONSTER.NIBBIT, front), (Nibbit:MONSTER.NIBBIT, back)]", log);
        Assert.True(log.IndexOf("已替换 MawlerNormal") < log.IndexOf("生成 NibbitsNormal"));
    }

    [Fact]
    public void LeavesEliteRoomsAlone()
    {
        InitMod();
        var room = new CombatRoom((EncounterModel)new ActModel(ModelDb.Encounter<BygoneEffigyElite>()).PullNextEncounter(RoomType.Elite).ToMutable());
        room.StartCombat();
        Assert.IsType<BygoneEffigyElite>(room.Encounter);
        Assert.Equal("BygoneEffigy", room.Encounter.MonstersWithSlots.Single().Monster.GetType().Name);
    }

    [Fact]
    public void ProbeFindsWhatTheFakeGameHas()
    {
        InitMod();
        var log = LogText();
        Assert.Contains("类型 MegaCrit.Sts2.Core.Rooms.CombatRoom", log);
        Assert.Contains("static T MegaCrit.Sts2.Core.Models.ModelDb.Encounter<T>()", log);
        Assert.Contains("ActModel.PullNextEncounter", log);
    }
}
