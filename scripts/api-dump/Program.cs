using System.Reflection;
using System.Text;
using System.Security.Cryptography;

// 只读元数据上下文；不运行游戏构造函数或静态初始化器。
var dll = Path.GetFullPath(args[0]);
var output = Path.GetFullPath(args[1]);
var paths = Directory.GetFiles(Path.GetDirectoryName(dll)!, "*.dll")
    .Concat(Directory.GetFiles(System.Runtime.InteropServices.RuntimeEnvironment.GetRuntimeDirectory(), "*.dll"))
    .GroupBy(Path.GetFileName, StringComparer.OrdinalIgnoreCase).Select(g => g.First()).ToArray();
using var context = new MetadataLoadContext(new PathAssemblyResolver(paths), "System.Private.CoreLib");
var assembly = context.LoadFromAssemblyPath(dll);
var targetFramework=assembly.GetCustomAttributesData().FirstOrDefault(a=>a.AttributeType.FullName=="System.Runtime.Versioning.TargetFrameworkAttribute")?.ConstructorArguments.FirstOrDefault().Value?.ToString()??"未找到";
var types = assembly.GetTypes(); // 缺依赖即失败，不能悄悄导出不完整结果。
var gameVersion = args.Length > 3 ? args[3] : "v0.111.0";
var core = new HashSet<string>{"Combat","Commands","GameActions","GameActions.Multiplayer","Multiplayer.Game","Runs","Rooms","Map","Localization","Helpers","ValueProps","Random","HoverTips","Assets"};
var models = new HashSet<string>{"AbstractModel","MonsterModel","EncounterModel","ActModel","PowerModel","CardModel","RelicModel","PotionModel","ModelDb"};
var powers = new HashSet<string>{"StrengthPower","WeakPower","VulnerablePower","FrailPower","ArtifactPower"};
// 程序集确实存在 MegaCrit.sts2 的大小写变体，保留输出原名但纳入界面范围。
bool Under(Type t, string ns) => string.Equals(t.Namespace, ns, StringComparison.OrdinalIgnoreCase) || (t.Namespace?.StartsWith(ns + ".", StringComparison.OrdinalIgnoreCase) ?? false);
var selected = new HashSet<Type>(types.Where(t => {
    var ns = t.Namespace ?? "";
    return core.Contains(ns.Replace("MegaCrit.Sts2.Core.", "")) || Under(t,"MegaCrit.Sts2.Core.Localization") || Under(t,"MegaCrit.Sts2.Core.Entities") || Under(t,"MegaCrit.Sts2.Core.Nodes")
        || (ns == "MegaCrit.Sts2.Core.Models" && models.Contains(t.Name))
        || (ns == "MegaCrit.Sts2.Core.Models.Powers" && powers.Contains(t.Name));
}));
// 状态牌通过基类和 CardType getter 的 IL enum 常量判定，不猜牌名。
var cardType = types.Single(t => t.FullName == "MegaCrit.Sts2.Core.Entities.Cards.CardType");
var status = cardType.GetField("Status")?.GetRawConstantValue() ?? throw new Exception("CardType.Status 未找到");
var statusNumber = Convert.ToInt32(status);
bool IsStatus(Type t) {
    var getter = t.GetProperty("Type", BindingFlags.Public|BindingFlags.NonPublic|BindingFlags.Instance)?.GetMethod;
    var il = getter?.GetMethodBody()?.GetILAsByteArray();
    if (il == null) return false;
    // 编译器生成的简单枚举 getter：ldc.i4.*; ret，可带 nop。
    var b = il.Where(x => x != 0x00).ToArray();
    return b.Length == 2 && b[1] == 0x2a && b[0] >= 0x15 && b[0] <= 0x1e && b[0]-0x16 == statusNumber
        || il.Length == 3 && il[0] == 0x1f && (sbyte)il[1] == statusNumber && il[2] == 0x2a;
}
var sourceCards = args.Length > 2 ? args[2].Split(',', StringSplitOptions.RemoveEmptyEntries).ToHashSet() : new HashSet<string>();
var statusCards = types.Where(t => t.Namespace == "MegaCrit.Sts2.Core.Models.Cards" && (IsStatus(t) || sourceCards.Contains(t.Name))).ToArray();
if (!statusCards.Any(t => t.Name == "Dazed")) throw new Exception("状态牌识别未包含 Dazed，请检查更新后的 getter IL");
foreach (var t in statusCards) selected.Add(t);
foreach (var t in selected.ToArray()) {
    if (t.Namespace == "MegaCrit.Sts2.Core.Models.Powers" || t.Namespace == "MegaCrit.Sts2.Core.Models.Cards")
        for (var b=t.BaseType;b!=null && b.Assembly==assembly;b=b.BaseType) selected.Add(b);
}
const BindingFlags flags = BindingFlags.Public|BindingFlags.NonPublic|BindingFlags.Instance|BindingFlags.Static|BindingFlags.DeclaredOnly;
string T(Type t) => t.IsByRef ? T(t.GetElementType()!)+"&" : t.IsPointer ? T(t.GetElementType()!)+"*" : t.IsArray ? T(t.GetElementType()!)+"["+new string(',',t.GetArrayRank()-1)+"]" : t.IsGenericParameter ? t.Name : t.IsGenericType ? System.Text.RegularExpressions.Regex.Replace(t.GetGenericTypeDefinition().FullName??t.Name,"`[0-9]+","")+"<"+string.Join(", ",t.GetGenericArguments().Select(T))+">" : t.FullName??t.Name;
string Access(MethodBase m) => m.IsPublic?"public":m.IsFamilyOrAssembly?"protected internal":m.IsFamilyAndAssembly?"private protected":m.IsFamily?"protected":m.IsAssembly?"internal":"private";
string Mods(MethodBase m) => Access(m)+(m.IsStatic?" static":"")+(m.IsAbstract?" abstract":m.IsVirtual?" virtual":"");
string Literal(object? x) => x==null?"null":x is string s?"\""+s.Replace("\"","\\\"")+"\"":x is char c?"'"+c+"'":Convert.ToString(x,System.Globalization.CultureInfo.InvariantCulture)??"null";
string P(ParameterInfo p) => (p.GetCustomAttributesData().Any(a=>a.AttributeType.FullName=="System.ParamArrayAttribute")?"params ":"")+(p.IsOut?"out ":p.ParameterType.IsByRef?(p.IsIn?"in ":"ref "):"")+T(p.ParameterType.IsByRef?p.ParameterType.GetElementType()!:p.ParameterType)+" "+p.Name+(p.HasDefaultValue?" = "+Literal(p.RawDefaultValue):"");
string M(MethodBase m) {
    var asyncMark=m.GetCustomAttributesData().Any(a=>a.AttributeType.FullName=="System.Runtime.CompilerServices.AsyncStateMachineAttribute")?" [async]":"";
    var mi=m as MethodInfo;
    var generic=mi?.IsGenericMethodDefinition==true?"<"+string.Join(", ",mi.GetGenericArguments().Select(a=>a.Name))+">":"";
    var text=Mods(m)+asyncMark+" "+(mi==null?"":T(mi.ReturnType)+" ")+m.Name+generic+"("+string.Join(", ",m.GetParameters().Select(P))+")";
    if(mi?.IsGenericMethodDefinition==true)foreach(var a in mi.GetGenericArguments())text+=" where "+a.Name+": ["+a.GenericParameterAttributes+"] "+string.Join(", ",a.GetGenericParameterConstraints().Select(T));
    return text.TrimEnd();
}
Directory.CreateDirectory(output);
var hash=Convert.ToHexString(SHA256.HashData(File.ReadAllBytes(dll)));
foreach(var group in selected.GroupBy(t=>t.Namespace??"global").OrderBy(g=>g.Key)) {
    var sb=new StringBuilder($"# {group.Key}\n\n游戏 {gameVersion}；程序集 {assembly.GetName()}；SHA256 `{hash}`。\n\n元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。\n");
    foreach(var t in group.OrderBy(T)) {
        sb.AppendLine($"\n## {T(t)}\n\n类型属性：`{t.Attributes}`；基类：`{(t.BaseType==null?"无":T(t.BaseType))}`。\n\n接口：{string.Join(", ",t.GetInterfaces().Select(x=>"`"+T(x)+"`"))}\n\n```text");
        foreach(var f in t.GetFields(flags).OrderBy(f=>f.Name)) {
            var access=f.IsPublic?"public":f.IsFamilyOrAssembly?"protected internal":f.IsFamilyAndAssembly?"private protected":f.IsFamily?"protected":f.IsAssembly?"internal":"private";
            sb.AppendLine(access+(f.IsStatic?" static":"")+(f.IsLiteral?" const":f.IsInitOnly?" readonly":"")+" "+T(f.FieldType)+" "+f.Name+(f.IsLiteral?" = "+Literal(f.GetRawConstantValue()):""));
        }
        foreach(var p in t.GetProperties(flags).OrderBy(p=>p.Name))sb.AppendLine(T(p.PropertyType)+" "+p.Name+(p.GetIndexParameters().Length>0?"["+string.Join(", ",p.GetIndexParameters().Select(P))+"]":"")+" { "+(p.GetMethod==null?"":Mods(p.GetMethod)+" get; ")+(p.SetMethod==null?"":Mods(p.SetMethod)+" set; ")+"}");
        foreach(var e in t.GetEvents(flags).OrderBy(e=>e.Name))sb.AppendLine("event "+T(e.EventHandlerType!)+" "+e.Name);
        foreach(var c in t.GetConstructors(flags).OrderBy(M))sb.AppendLine(M(c));
        foreach(var m in t.GetMethods(flags).OrderBy(M))sb.AppendLine(M(m));
        sb.AppendLine("```");
    }
    // Windows 文件名不区分大小写；保留命名空间原名，变体另加后缀防止覆盖。
    var fileName=group.Key+(group.Key.StartsWith("MegaCrit.sts2.",StringComparison.Ordinal)?".case-variant":"")+".md";
    File.WriteAllText(Path.Combine(output,fileName),sb.ToString().Replace("\r\n","\n"),new UTF8Encoding(false));
}
Console.WriteLine($"导出 {selected.Count} 类型、{selected.Select(t=>t.Namespace).Distinct().Count()} 命名空间；状态牌：{string.Join(", ",statusCards.Select(t=>t.Name))}");
Console.WriteLine("TargetFramework: "+targetFramework);
