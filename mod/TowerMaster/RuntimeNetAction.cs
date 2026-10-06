using System.Reflection;
using System.Reflection.Emit;
using HarmonyLib;

namespace TowerMaster;

/// <summary>按当前游戏的类型名字生成接口适配层，不在源码里绑定游戏命名空间。</summary>
public static class RuntimeNetAction
{
    internal static Type NetType { get; private set; } = null!;
    internal static Type ActionType { get; private set; } = null!;

    internal static void Register(Harmony harmony)
    {
        if (NetType != null) return;
        var net = Required("INetAction");
        var gameAction = Required("GameAction");
        var module = AssemblyBuilder.DefineDynamicAssembly(new AssemblyName("TowerMaster.Runtime"), AssemblyBuilderAccess.Run)
            .DefineDynamicModule("TowerMaster.Runtime");
        var nt = module.DefineType("TowerMasterSummonNetAction", TypeAttributes.Public | TypeAttributes.Sealed);
        nt.AddInterfaceImplementation(net);
        nt.DefineDefaultConstructor(MethodAttributes.Public);
        nt.DefineField("Payload", typeof(string), FieldAttributes.Public);
        foreach (var method in net.GetInterfaces().Append(net).SelectMany(t => t.GetMethods()).DistinctBy(m => m.Name))
        {
            var bridge = method.Name switch
            {
                "Serialize" => nameof(Serialize), "Deserialize" => nameof(Deserialize),
                "ToGameAction" => nameof(ToGameAction),
                _ => throw new MissingMethodException($"未知联机接口成员 {method.Name}"),
            };
            Forward(nt, method, bridge, true);
        }
        NetType = nt.CreateType()!;

        var at = module.DefineType("TowerMasterSummonGameAction", TypeAttributes.Public | TypeAttributes.Sealed, gameAction);
        var ctor = at.DefineConstructor(MethodAttributes.Public, CallingConventions.Standard, Type.EmptyTypes);
        var cil = ctor.GetILGenerator();
        cil.Emit(OpCodes.Ldarg_0);
        // 基类同时存在静态初始化器和无参实例构造，必须只查询实例构造。
        var baseCtor = gameAction.GetConstructor(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance, Type.EmptyTypes)
            ?? throw new MissingMethodException("GameAction", ".ctor()");
        cil.Emit(OpCodes.Call, baseCtor);
        cil.Emit(OpCodes.Ret);
        at.DefineField("Payload", typeof(string), FieldAttributes.Public);
        at.DefineField("Owner", typeof(ulong), FieldAttributes.Public);
        foreach (var method in gameAction.GetMethods(GameReflection.All).Where(m => m.IsAbstract))
        {
            var bridge = method.Name switch
            {
                "get_OwnerId" => nameof(Owner), "get_ActionType" => nameof(Kind),
                "ExecuteAction" => nameof(Execute), "ToNetAction" => nameof(ToNetAction),
                _ => throw new MissingMethodException($"未知动作抽象成员 {method.Name}"),
            };
            Forward(at, method, bridge, false);
        }
        ActionType = at.CreateType()!;
        // 动态程序集要登记到本 mod 名下，否则游戏给联机类型排序时报错（测试 2 实测）。
        ModAssociation.Associate(NetType.Assembly);

        // ReflectionHelper 只扫描 mod 的静态程序集，在其类型清单中补入动态接口实现。
        var getter = Required("ReflectionHelper").GetProperty("ModTypes", GameReflection.All)?.GetMethod
            ?? throw new MissingMethodException("ReflectionHelper.ModTypes");
        harmony.Patch(getter, postfix: new HarmonyMethod(typeof(RuntimeNetAction).GetMethod(nameof(ModTypesPostfix), GameReflection.All)!));
        Log.Info($"测试1b：已注册 {NetType.Name}，动作={ActionType.Name}");
    }

    private static void ModTypesPostfix(ref Type[] __result) =>
        __result = __result.Concat(new[] { NetType }).Distinct().ToArray();

    private static void Forward(TypeBuilder type, MethodInfo original, string callback, bool isInterface)
    {
        var flags = MethodAttributes.Virtual | MethodAttributes.HideBySig;
        flags |= original.IsPublic || isInterface ? MethodAttributes.Public : MethodAttributes.Family;
        if (isInterface) flags |= MethodAttributes.NewSlot | MethodAttributes.Final;
        if (original.IsSpecialName) flags |= MethodAttributes.SpecialName;
        var parameters = original.GetParameters();
        var method = type.DefineMethod(original.Name, flags, original.ReturnType, parameters.Select(p => p.ParameterType).ToArray());
        var il = method.GetILGenerator();
        il.Emit(OpCodes.Ldarg_0);
        for (int i = 0; i < parameters.Length; i++)
        {
            il.Emit(OpCodes.Ldarg, i + 1);
            if (parameters[i].ParameterType.IsValueType) il.Emit(OpCodes.Box, parameters[i].ParameterType);
        }
        var bridge = typeof(RuntimeNetAction).GetMethod(callback, BindingFlags.Public | BindingFlags.Static)!;
        il.Emit(OpCodes.Call, bridge);
        if (original.ReturnType != typeof(void) && bridge.ReturnType != original.ReturnType)
            il.Emit(original.ReturnType.IsValueType ? OpCodes.Unbox_Any : OpCodes.Castclass, original.ReturnType);
        il.Emit(OpCodes.Ret);
        type.DefineMethodOverride(method, original);
    }

    internal static Type Required(string name) => GameReflection.TypeNamed(name) ?? throw new TypeLoadException(name);
    internal static object Call(object target, string name, params object?[] args) =>
        target.GetType().GetMethods(GameReflection.All).Single(m => m.Name == name && !m.IsGenericMethod && m.GetParameters().Length == args.Length)
            .Invoke(target, args)!;
    internal static string Payload(object action) => (string)action.GetType().GetField("Payload")!.GetValue(action)!;
    internal static object Create(ulong owner, string payload)
    {
        var action = Activator.CreateInstance(ActionType)!;
        action.GetType().GetField("Owner")!.SetValue(action, owner);
        action.GetType().GetField("Payload")!.SetValue(action, payload);
        return action;
    }

    // 这些公共回调供动态程序集调用，实际游戏对象仍通过反射访问。
    public static void Serialize(object action, object writer) => Call(writer, "WriteString", Payload(action));
    public static void Deserialize(object action, object reader) => action.GetType().GetField("Payload")!.SetValue(action, Call(reader, "ReadString"));
    public static object ToGameAction(object action, object player) => Create(Convert.ToUInt64(GameReflection.Get(player, "NetId")), Payload(action));
    public static object ToNetAction(object action)
    {
        var net = Activator.CreateInstance(NetType)!;
        NetType.GetField("Payload")!.SetValue(net, Payload(action));
        return net;
    }
    public static ulong Owner(object action) => (ulong)action.GetType().GetField("Owner")!.GetValue(action)!;
    /// <summary>召唤清单在战斗外执行（NonCombat）；塔主回合指令要在玩家队列暂停时也能执行（Any）。</summary>
    public static object Kind(object action) =>
        Enum.Parse(Required("GameActionType"), Payload(action).StartsWith(ThreatPhase.Prefix) ? ThreatPhase.ActionKind(Payload(action)) : "NonCombat");
    public static Task Execute(object action)
    {
        if (Payload(action).StartsWith(ThreatPhase.Prefix)) return ThreatPhase.Execute(Payload(action), action);
        // 清单不合格只记日志：各客户端执行同一个动作、得到同样的校验结果，都退回原版遭遇。
        try { Test1bMixedEncounter.Receive(Payload(action), Owner(action)); }
        catch (Exception e) { Log.Warn($"测试1b：拒收召唤清单（{e.Message}），下一场按原版遭遇"); }
        return Task.CompletedTask;
    }
}
