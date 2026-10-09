using System.Text.Json;
using G = Godot;

namespace TowerMaster;

/// <summary>
/// 塔主的完整动画（用户：「塔主的动作不应该只有几帧，我要的是完整的动画」）。
///
/// 做法是「切件骨骼」（原版角色用的 Spine 也是这个思路）：把塔主立绘拆成几块（身体、头、提灯的手臂、灯笼、空着的手、烟），
/// 每块是和立绘同尺寸、同位置的透明 PNG，再给每块一个转轴。代码按关键帧连续转动/移动这些块，
/// 60 帧/秒平滑播放：同一套画，帧帧一致，不会像逐帧生图那样抖。
///
/// 部件和转轴写在 art/rig_master.json（制作说明见 docs/master-animation-plan.md）。缺文件就返回 null，继续用静态立绘。
///
/// 动画：
/// - idle（循环）：呼吸起伏、头微动、灯笼轻摆、袖子和烟慢慢飘；
/// - cast（举灯，给怪物加料，1.1 秒）：灯先往下一沉蓄力 → 高高举起、灯笼变亮 → 停一下 → 放回；
/// - point（推灯，给玩家添堵，1.0 秒）：灯先往回收 → 朝玩家方向一推、身体前倾 → 停 → 收回；
/// - bury（埋陷阱，1.2 秒）：俯身、空着的手往下一甩（这时放埋牌特效）→ 起身。
/// 动作幅度都小（几度到二十几度），从 idle 出发、回到 idle，不会跳。
/// </summary>
internal sealed class MasterRig
{
    private sealed record PartDef(string Name, string File, float[] Pivot, int Z, string? Parent);
    private sealed record RigDef(int[] Canvas, PartDef[] Parts);

    /// <summary>一个关键帧：时间（秒）、转角（度）、位移、缩放、灯笼亮度。</summary>
    private readonly record struct Key(float T, float Rot = 0, float X = 0, float Y = 0, float S = 1, float Glow = 1);

    private readonly Dictionary<string, G.Node2D> _joints = new();
    private readonly Dictionary<string, G.Vector2> _rest = new();
    private readonly G.Node2D _root;
    private string _anim = "idle";
    private double _animStart, _clock;
    private Action? _onHit;
    private bool _hitFired;

    public G.Control View { get; }

    private MasterRig(G.Control view, G.Node2D root) { View = view; _root = root; }

    /// <summary>读部件、搭骨架；缺东西返回 null。height = 画面上塔主的高度（像素）。</summary>
    internal static MasterRig? TryCreate(float height)
    {
        try
        {
            var path = Path.Combine(Log.ModDir, "art", "rig_master.json");
            if (!File.Exists(path)) return null;
            var def = JsonSerializer.Deserialize<RigDef>(File.ReadAllText(path), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            if (def == null || def.Parts.Length == 0) return null;
            float scale = height / def.Canvas[1];
            var view = new G.Control { MouseFilter = G.Control.MouseFilterEnum.Ignore, Size = new G.Vector2(def.Canvas[0], def.Canvas[1]) * scale };
            var root = new G.Node2D { Scale = new G.Vector2(scale, scale) };
            view.AddChild(root);
            var rig = new MasterRig(view, root);
            foreach (var p in def.Parts.OrderBy(p => p.Z))
            {
                var texture = Art.Get(Path.GetFileNameWithoutExtension(p.File));
                if (texture == null) { Log.Warn($"塔主动画：缺部件图 {p.File}，用静态立绘"); return null; }
                var pivot = new G.Vector2(p.Pivot[0], p.Pivot[1]);
                var parentPivot = p.Parent != null && def.Parts.FirstOrDefault(x => x.Name == p.Parent) is { } pp ? new G.Vector2(pp.Pivot[0], pp.Pivot[1]) : G.Vector2.Zero;
                // 前后顺序只靠添加顺序（按 Z 从小到大）：不设 ZIndex，免得跳出怪物所在的图层
                var joint = new G.Node2D { Name = p.Name, Position = pivot - parentPivot };
                joint.AddChild(new G.Sprite2D { Texture = texture, Centered = false, Position = -pivot });
                G.Node parent = p.Parent != null && rig._joints.TryGetValue(p.Parent, out var pj) ? pj : root;
                parent.AddChild(joint);
                rig._joints[p.Name] = joint;
                rig._rest[p.Name] = joint.Position;
            }
            SummonPanel.Tree.ProcessFrame += rig.Tick;
            view.TreeExiting += () => SummonPanel.Tree.ProcessFrame -= rig.Tick;
            Log.Info($"塔主动画：骨架搭好（{rig._joints.Count} 个部件）");
            return rig;
        }
        catch (Exception e)
        {
            Log.Warn($"塔主动画：骨架没搭成，用静态立绘：{e.Message}");
            return null;
        }
    }

    /// <summary>播一个动作（cast / point / bury），播完回到 idle。onHit 在动作「出手」那一刻调用（放特效）。</summary>
    internal void Play(string anim, Action? onHit = null)
    {
        if (!Tracks.ContainsKey(anim)) return;
        _anim = anim;
        _animStart = _clock;
        _onHit = onHit;
        _hitFired = false;
    }

    // 转角：Godot 里正数是顺时针。塔主朝左（面向玩家），提灯的手举在左上方：
    // 提灯手臂顺时针转 = 把灯举高（给怪物加料）；逆时针转 = 把灯往前（玩家方向）推（给玩家添堵）。
    // 空着的手垂在右下方：顺时针转 = 往下、往前一甩（埋陷阱）。
    private static readonly Dictionary<string, (float Length, float Hit, Dictionary<string, Key[]> Parts)> Tracks = new()
    {
        ["cast"] = (1.1f, 0.4f, new()
        {
            ["body"] = [new(0), new(0.25f, Rot: 1.5f, Y: 3), new(0.4f, Rot: -1.5f, Y: -4), new(0.65f, Rot: -1.5f, Y: -4), new(1.1f)],
            ["head"] = [new(0), new(0.25f, Rot: 2), new(0.4f, Rot: -3), new(0.65f, Rot: -3), new(1.1f)],
            ["arm_lantern"] = [new(0), new(0.25f, Rot: -6), new(0.4f, Rot: 16), new(0.65f, Rot: 14), new(1.1f)],
            ["lantern"] = [new(0), new(0.25f, Rot: 5), new(0.4f, Rot: -12, Glow: 1.8f), new(0.65f, Rot: -6, Glow: 1.6f), new(1.1f)],
            ["arm_free"] = [new(0), new(0.25f, Rot: 4), new(0.4f, Rot: -8), new(0.65f, Rot: -8), new(1.1f)],
        }),
        ["point"] = (1.0f, 0.38f, new()
        {
            ["body"] = [new(0), new(0.22f, Rot: 1.5f, X: 3), new(0.38f, Rot: -3, X: -8), new(0.6f, Rot: -3, X: -8), new(1.0f)],
            ["head"] = [new(0), new(0.22f, Rot: 2), new(0.38f, Rot: -5), new(0.6f, Rot: -5), new(1.0f)],
            ["arm_lantern"] = [new(0), new(0.22f, Rot: 6), new(0.38f, Rot: -20), new(0.6f, Rot: -18), new(1.0f)],
            ["lantern"] = [new(0), new(0.22f, Rot: -4), new(0.38f, Rot: 14, Glow: 1.5f), new(0.6f, Rot: 6, Glow: 1.3f), new(1.0f)],
            ["arm_free"] = [new(0), new(0.38f, Rot: 6), new(1.0f)],
        }),
        ["bury"] = (1.2f, 0.5f, new()
        {
            ["body"] = [new(0), new(0.3f, Rot: -1.5f, Y: 6), new(0.5f, Rot: -3, X: -4, Y: 10), new(0.75f, Rot: -2, Y: 8), new(1.2f)],
            ["head"] = [new(0), new(0.3f, Rot: -5), new(0.5f, Rot: -8), new(0.75f, Rot: -6), new(1.2f)],
            ["arm_free"] = [new(0), new(0.3f, Rot: -10), new(0.5f, Rot: 22), new(0.75f, Rot: 18), new(1.2f)],
            ["arm_lantern"] = [new(0), new(0.5f, Rot: 4), new(1.2f)],
            ["lantern"] = [new(0), new(0.5f, Rot: -6, Glow: 1.4f), new(1.2f)],
        }),
    };

    private void Tick()
    {
        if (!G.GodotObject.IsInstanceValid(_root)) return;
        _clock += SummonPanel.Tree.Root.GetProcessDeltaTime();
        float t = (float)(_clock - _animStart);
        Dictionary<string, Key[]>? track = null;
        if (_anim != "idle" && Tracks.TryGetValue(_anim, out var a))
        {
            if (!_hitFired && t >= a.Hit) { _hitFired = true; try { _onHit?.Invoke(); } catch { /* 纯显示 */ } }
            if (t >= a.Length) _anim = "idle";
            else track = a.Parts;
        }
        foreach (var (name, joint) in _joints)
        {
            // idle：每个部件不同相位的慢正弦，叠在动作上
            float w = (float)_clock;
            var idle = name switch
            {
                "body" => new Key(0, Rot: MathF.Sin(w * 1.9f) * 0.6f, Y: MathF.Sin(w * 1.9f) * 3f),
                "head" => new Key(0, Rot: MathF.Sin(w * 1.9f + 0.6f) * 1.2f),
                "arm_lantern" => new Key(0, Rot: MathF.Sin(w * 1.9f + 0.3f) * 1.5f),
                "lantern" => new Key(0, Rot: MathF.Sin(w * 1.4f) * 4f, Glow: 1f + MathF.Sin(w * 2.6f) * 0.08f),
                "arm_free" => new Key(0, Rot: MathF.Sin(w * 1.9f + 1.1f) * 2f),
                "smoke" => new Key(0, X: MathF.Sin(w * 0.9f) * 4f, S: 1f + MathF.Sin(w * 1.3f) * 0.02f),
                _ => new Key(0),
            };
            var act = track != null && track.TryGetValue(name, out var keys) ? Sample(keys, t) : new Key(0);
            joint.RotationDegrees = idle.Rot + act.Rot;
            joint.Position = _rest[name] + new G.Vector2(idle.X + act.X, idle.Y + act.Y);
            joint.Scale = new G.Vector2(idle.S * act.S, idle.S * act.S);
            if (name == "lantern")
            {
                float glow = idle.Glow * act.Glow;
                joint.Modulate = new G.Color(glow, glow, glow, 1);
            }
        }
    }

    /// <summary>两个关键帧之间用缓入缓出（smoothstep）插值。</summary>
    private static Key Sample(Key[] keys, float t)
    {
        if (t <= keys[0].T) return keys[0];
        for (int i = 1; i < keys.Length; i++)
        {
            if (t > keys[i].T) continue;
            var a = keys[i - 1];
            var b = keys[i];
            float u = (t - a.T) / Math.Max(0.0001f, b.T - a.T);
            u = u * u * (3 - 2 * u);
            return new Key(t, a.Rot + (b.Rot - a.Rot) * u, a.X + (b.X - a.X) * u, a.Y + (b.Y - a.Y) * u, a.S + (b.S - a.S) * u, a.Glow + (b.Glow - a.Glow) * u);
        }
        return keys[^1];
    }
}
