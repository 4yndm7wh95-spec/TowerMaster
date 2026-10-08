using System.Runtime.CompilerServices;

namespace TowerMaster.Tests;

/// <summary>测试进程里没有 Godot 引擎：把所有会碰界面的钩子换成空操作（调到 Godot 原生接口会让测试进程直接崩溃）。</summary>
internal static class NoGodotUi
{
    [ModuleInitializer]
    internal static void Init()
    {
        MasterHand.ShowHand = _ => { };
        MasterRewards.WhenRewardsShown = send => send();
        MasterRewards.AfterUiSettles = send => send();
        MasterRewards.NoticeSink = _ => { };
    }
}
