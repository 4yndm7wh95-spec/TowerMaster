using System.Text;

namespace TowerMaster;

/// <summary>写到 mod 目录下的 TowerMaster.log（每次启动清空）。两台电脑的日志对照着看。</summary>
internal static class Log
{
    private static readonly object Lock = new();
    private static string? _path;

    /// <summary>当前日志文件；同机双实例时每个实例不同，可用来派生其他按实例区分的文件。</summary>
    public static string? FilePath => _path;

    public static string ModDir => Path.GetDirectoryName(typeof(Log).Assembly.Location) ?? ".";

    public static void Init()
    {
        // 同机双实例测试可分别指定日志文件，默认仍写到 mod 目录。
        _path = Environment.GetEnvironmentVariable("TOWERMASTER_LOG_FILE") ?? Path.Combine(ModDir, "TowerMaster.log");
        try { File.WriteAllText(_path, $"TowerMaster 日志 {DateTime.Now:yyyy-MM-dd HH:mm:ss}\n", Encoding.UTF8); }
        catch { _path = null; }
    }

    public static void Info(string message) => Write("INFO", message);
    public static void Warn(string message) => Write("WARN", message);
    public static void Error(string message, Exception? e = null) => Write("ERROR", e == null ? message : $"{message}\n{e}");

    private static void Write(string level, string message)
    {
        var line = $"[{DateTime.Now:HH:mm:ss.fff}] {level} {message}\n";
        lock (Lock)
        {
            if (_path != null)
            {
                try { File.AppendAllText(_path, line, Encoding.UTF8); } catch { /* 日志失败不影响游戏 */ }
            }
        }
        Console.Write(line);
    }
}
