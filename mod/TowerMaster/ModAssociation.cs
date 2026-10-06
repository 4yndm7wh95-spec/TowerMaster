using System.Collections;
using System.Reflection;

namespace TowerMaster;

/// <summary>
/// 把运行时生成的程序集登记到本 mod 名下。游戏给联机类型排序编号时要知道每个类型属于哪个 mod，
/// 不登记会报「not associated with any mod」，提示排序可能出错（测试 2 实测日志）。
/// 不知道 ModManager.AssociateAssemblyWithMod 的确切签名，按参数类型现场拼参数，日志里写清楚怎么调的。
/// </summary>
internal static class ModAssociation
{
    public const string ModId = "TowerMaster";

    public static void Associate(Assembly dynamicAssembly)
    {
        try
        {
            var manager = GameReflection.TypeNamed("ModManager");
            var method = manager?.GetMethods(GameReflection.All).FirstOrDefault(m => m.Name == "AssociateAssemblyWithMod");
            if (manager == null || method == null) { Log.Warn("登记动态程序集：找不到 ModManager.AssociateAssemblyWithMod"); return; }

            object? target = null;
            if (!method.IsStatic)
            {
                target = GameReflection.Get(manager, "Instance") ?? FindStatic(manager, manager);
                if (target == null) { Log.Warn($"登记动态程序集：{GameReflection.Describe(method)} 是实例方法，找不到 ModManager 实例"); return; }
            }

            var args = new List<object?>();
            foreach (var p in method.GetParameters())
            {
                if (p.ParameterType == typeof(Assembly)) args.Add(dynamicAssembly);
                else if (p.ParameterType == typeof(string)) args.Add(ModId);
                else if (FindOurMod(manager, p.ParameterType) is { } mod) args.Add(mod);
                else if (p.HasDefaultValue) args.Add(p.DefaultValue);
                else { Log.Warn($"登记动态程序集：不知道参数 {p.ParameterType.Name} {p.Name} 该传什么（{GameReflection.Describe(method)}）"); return; }
            }
            method.Invoke(target, args.ToArray());
            Log.Info($"登记动态程序集：已调用 {GameReflection.Describe(method)}，参数=[{string.Join(", ", args.Select(a => GameReflection.Dump(a)))}]");
        }
        catch (Exception e)
        {
            Log.Error("登记动态程序集失败", e);
        }
    }

    /// <summary>在 ModManager 的静态字段、属性（含集合、字典的值）里找代表本 mod 的对象。</summary>
    private static object? FindOurMod(Type manager, Type modType)
    {
        foreach (var value in StaticValues(manager))
        {
            if (value == null) continue;
            if (modType.IsInstanceOfType(value) && IsOurs(value)) return value;
            if (value is IDictionary dict)
            {
                foreach (var v in dict.Values) if (v != null && modType.IsInstanceOfType(v) && IsOurs(v)) return v;
            }
            else if (value is IEnumerable list and not string)
            {
                foreach (var v in list) if (v != null && modType.IsInstanceOfType(v) && IsOurs(v)) return v;
            }
        }
        return null;
    }

    private static object? FindStatic(Type owner, Type valueType) =>
        StaticValues(owner).FirstOrDefault(v => v != null && valueType.IsInstanceOfType(v));

    private static IEnumerable<object?> StaticValues(Type owner)
    {
        const BindingFlags flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static;
        foreach (var f in owner.GetFields(flags)) yield return Safe(() => f.GetValue(null));
        foreach (var p in owner.GetProperties(flags).Where(p => p.GetIndexParameters().Length == 0))
            yield return Safe(() => p.GetValue(null));
    }

    /// <summary>对象（或它的 manifest 一层）上有值为本 mod id 的字符串，或指向本 mod 的程序集。</summary>
    private static bool IsOurs(object mod, int depth = 0)
    {
        foreach (var member in mod.GetType().GetMembers(GameReflection.All))
        {
            object? v = member switch
            {
                FieldInfo f when !f.IsStatic => Safe(() => f.GetValue(mod)),
                PropertyInfo p when p.GetIndexParameters().Length == 0 && p.GetMethod is { IsStatic: false } => Safe(() => p.GetValue(mod)),
                _ => null,
            };
            if (v is string s && s == ModId) return true;
            if (v is Assembly a && a == typeof(ModAssociation).Assembly) return true;
            if (depth == 0 && v != null && !v.GetType().IsPrimitive && v is not string && v.GetType().Namespace?.StartsWith("MegaCrit") == true
                && IsOurs(v, 1)) return true;
        }
        return false;
    }

    private static object? Safe(Func<object?> get)
    {
        try { return get(); } catch { return null; }
    }
}
