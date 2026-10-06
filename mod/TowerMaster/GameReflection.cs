using System.Reflection;
using System.Text;

namespace TowerMaster;

/// <summary>
/// 用名字在游戏程序集里找类型和成员。技术验证阶段不写死命名空间和签名：
/// 游戏更新改了命名空间也能找到，找不到时日志里会写清楚缺了什么。
/// </summary>
internal static class GameReflection
{
    public const BindingFlags All = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;

    private static Assembly? _game;
    private static Type[]? _types;

    /// <summary>
    /// 游戏程序集：优先取和本 mod 同一个加载上下文里的 sts2（游戏把 mod 加载进自己的上下文），
    /// 进程里有别的 sts2 副本时（例如其他工具另行加载）不会挂错地方。
    /// </summary>
    public static Assembly Game => _game ??=
        System.Runtime.Loader.AssemblyLoadContext.GetLoadContext(typeof(GameReflection).Assembly)?.Assemblies
            .FirstOrDefault(a => a.GetName().Name == "sts2")
        ?? AppDomain.CurrentDomain.GetAssemblies().FirstOrDefault(a => a.GetName().Name == "sts2")
        ?? throw new InvalidOperationException("没找到游戏程序集 sts2");

    public static Type[] Types
    {
        get
        {
            if (_types != null) return _types;
            try { _types = Game.GetTypes(); }
            catch (ReflectionTypeLoadException e) { _types = e.Types.Where(t => t != null).ToArray()!; }
            return _types;
        }
    }

    /// <summary>按类名（不含命名空间）找类型；有重名时返回全部。</summary>
    public static List<Type> TypesNamed(string name) => Types.Where(t => t.Name == name).ToList();

    public static Type? TypeNamed(string name) => Types.FirstOrDefault(t => t.Name == name);

    /// <summary>在所有类型里找声明了这个名字的成员（方法、属性、字段）。</summary>
    public static List<MemberInfo> MembersNamed(string name) =>
        Types.SelectMany(t => SafeMembers(t).Where(m => m.Name == name)).ToList();

    /// <summary>找唯一一个声明了这个名字的方法；有多个时取第一个并在日志里提醒。</summary>
    public static MethodInfo? FindMethod(string name, string? declaringType = null)
    {
        var methods = Types.Where(t => declaringType == null || t.Name == declaringType)
            .SelectMany(t => SafeMembers(t).OfType<MethodInfo>().Where(m => m.Name == name && !m.IsAbstract))
            .ToList();
        if (methods.Count > 1) Log.Warn($"{declaringType}.{name} 有 {methods.Count} 个，取第一个：{Describe(methods[0])}");
        return methods.FirstOrDefault();
    }

    private static IEnumerable<MemberInfo> SafeMembers(Type t)
    {
        try { return t.GetMembers(All | BindingFlags.DeclaredOnly); }
        catch { return []; }
    }

    // ---------------------------------------------------------------- 读写对象

    /// <summary>读属性或字段（含基类、非公开）。</summary>
    public static object? Get(object obj, string name)
    {
        for (var t = obj.GetType(); t != null; t = t.BaseType)
        {
            var p = t.GetProperty(name, All | BindingFlags.DeclaredOnly);
            if (p != null && p.GetIndexParameters().Length == 0 && p.CanRead) return p.GetValue(obj);
            var f = t.GetField(name, All | BindingFlags.DeclaredOnly);
            if (f != null) return f.GetValue(obj);
        }
        return null;
    }

    /// <summary>找出对象上「类型能装下 value」的属性或字段，返回它们的名字和当前值。</summary>
    public static List<(string Name, Type Type, object? Value)> SlotsAssignableFrom(object obj, Type valueType)
    {
        var result = new List<(string, Type, object?)>();
        for (var t = obj.GetType(); t != null; t = t.BaseType)
        {
            foreach (var f in t.GetFields(All | BindingFlags.DeclaredOnly).Where(f => !f.IsStatic && f.FieldType.IsAssignableFrom(valueType)))
                result.Add((f.Name, f.FieldType, f.GetValue(obj)));
        }
        return result;
    }

    /// <summary>写字段（含基类、非公开）。自动属性请传它的后备字段名 &lt;Name&gt;k__BackingField。</summary>
    public static bool SetField(object obj, string name, object? value)
    {
        for (var t = obj.GetType(); t != null; t = t.BaseType)
        {
            var f = t.GetField(name, All | BindingFlags.DeclaredOnly);
            if (f == null) continue;
            f.SetValue(obj, value);
            return true;
        }
        return false;
    }

    // ---------------------------------------------------------------- 描述

    public static string Describe(MemberInfo m) => m switch
    {
        MethodInfo mi => $"{(mi.IsStatic ? "static " : "")}{TypeName(mi.ReturnType)} {mi.DeclaringType?.FullName}.{mi.Name}"
                         + (mi.IsGenericMethodDefinition ? $"<{string.Join(", ", mi.GetGenericArguments().Select(a => a.Name))}>" : "")
                         + $"({string.Join(", ", mi.GetParameters().Select(p => $"{TypeName(p.ParameterType)} {p.Name}"))})",
        PropertyInfo pi => $"property {TypeName(pi.PropertyType)} {pi.DeclaringType?.FullName}.{pi.Name}",
        FieldInfo fi => $"field {(fi.IsStatic ? "static " : "")}{TypeName(fi.FieldType)} {fi.DeclaringType?.FullName}.{fi.Name}",
        ConstructorInfo ci => $"ctor {ci.DeclaringType?.FullName}({string.Join(", ", ci.GetParameters().Select(p => $"{TypeName(p.ParameterType)} {p.Name}"))})",
        _ => $"{m.MemberType} {m.DeclaringType?.FullName}.{m.Name}",
    };

    public static string TypeName(Type t)
    {
        if (!t.IsGenericType) return t.Name;
        var sb = new StringBuilder(t.Name[..t.Name.IndexOf('`')]);
        sb.Append('<').Append(string.Join(", ", t.GetGenericArguments().Select(TypeName))).Append('>');
        return sb.ToString();
    }

    /// <summary>把对象简单展开成一行文本（集合逐项、元组逐项），用于日志对照。</summary>
    public static string Dump(object? value, int depth = 0)
    {
        if (value == null) return "null";
        if (value is string s) return s;
        if (value.GetType().IsPrimitive || value is decimal || value.GetType().IsEnum) return value.ToString() ?? "";
        if (depth > 2) return value.GetType().Name;
        var type = value.GetType();
        if (type.FullName?.StartsWith("System.ValueTuple") == true)
            return "(" + string.Join(", ", type.GetFields().Select(f => Dump(f.GetValue(value), depth + 1))) + ")";
        if (value is System.Collections.IEnumerable list)
            return "[" + string.Join(", ", list.Cast<object?>().Select(v => Dump(v, depth + 1))) + "]";
        // 游戏模型的 ToString 含进程内对象哈希，联机对照只记录稳定的模型 ID。
        var id = Get(value, "Id");
        if (id != null) return $"{type.Name}:{id}";
        var text = value.ToString();
        return text == type.FullName ? type.Name : $"{type.Name}:{text}";
    }
}
