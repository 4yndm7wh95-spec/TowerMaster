"""塔主切件动画检查工具（只需要 Pillow）。

和游戏里 MasterRig.cs 用同一套拼法、同一份关键帧（art/rig_master.json + art/rig_anims.json），
所以这里看到的预览就是游戏里的样子。用法：

    python testing/rig/check_rig.py                # 检查部件 + 生成全部预览
    python testing/rig/check_rig.py --guide        # 只画「关节和部件范围示意图」（拆图前看）

输出在 testing/rig/out/：
- guide.png          关节位置示意（拆图前照着它切）
- composite_diff.png 部件叠回去和原图的差异（越黑越好；亮的地方是补画区或拼错了）
- pivots.png         每个部件的转轴十字（检查转轴是不是在肩膀/脖子/握点上）
- anim_*.gif         待机和三个动作的预览（深色底）
- holes_*.png        每个动作摆到最大幅度时，用品红底画一遍：露出品红 = 有缝/有洞，要补画

拼法（和游戏一致）：
1. 每张部件图都是整张 512×768，部件在原来的位置（只抠图，不挪、不裁）。叠在一起 = 原图。
2. 每个部件一个关节，放在它的转轴坐标；部件图在关节里往回挪 -转轴，所以静止时正好落回原位。
3. 子部件关节的位置 = 自己的转轴 − 父部件的转轴；父部件转动时子部件跟着走。
4. 关节变换 = 平移(位置 + 动作位移) · 旋转(角度，正数顺时针) · 缩放。
"""
import json, math, os, sys
from PIL import Image, ImageDraw, ImageChops

ROOT = os.path.dirname(os.path.dirname(os.path.dirname(os.path.abspath(__file__))))
ART = os.path.join(ROOT, "mod", "TowerMaster", "art")
OUT = os.path.join(os.path.dirname(os.path.abspath(__file__)), "out")
for i, a in enumerate(sys.argv):  # --art 目录 / --out 目录（试拆的部件放别处时用）
    if a == "--art" and i + 1 < len(sys.argv): ART = sys.argv[i + 1]
    if a == "--out" and i + 1 < len(sys.argv): OUT = sys.argv[i + 1]

# 拆图前的建议转轴（原图 512×768 坐标，Claude 按网格量的；拆完按实际微调后写进 rig_master.json）
GUIDE = {
    "smoke":       ((260, 640), None,          "烟：袍子下摆外飘的紫烟"),
    "body":        ((300, 690), None,          "身体：两脚之间"),
    "arm_free":    ((318, 158), "body",        "空手：右边肩膀（袖子根部）"),
    "head":        ((212, 165), "body",        "头：兜帽下的脖子"),
    "arm_lantern": ((165, 165), "body",        "提灯手臂：左边肩膀"),
    "lantern":     ((106, 110), "arm_lantern", "灯笼：手套握链子的地方"),
}


def mat(a=1, b=0, c=0, d=0, e=1, f=0):
    return [[a, b, c], [d, e, f], [0, 0, 1]]


def mul(m, n):
    return [[sum(m[i][k] * n[k][j] for k in range(3)) for j in range(3)] for i in range(3)]


def T(x, y): return mat(1, 0, x, 0, 1, y)
def S(s): return mat(s, 0, 0, 0, s, 0)


def R(deg):
    r = math.radians(deg)
    return mat(math.cos(r), -math.sin(r), 0, math.sin(r), math.cos(r), 0)  # y 朝下时正角 = 顺时针，和 Godot 一样


def inv(m):
    a, b, c = m[0]; d, e, f = m[1]
    det = a * e - b * d
    ia, ib, id_, ie = e / det, -b / det, -d / det, a / det
    return (ia, ib, -(ia * c + ib * f), id_, ie, -(id_ * c + ie * f))


def load():
    rig = json.load(open(os.path.join(ART, "rig_master.json"), encoding="utf-8"))
    anims_path = os.path.join(ART, "rig_anims.json")
    if not os.path.exists(anims_path): anims_path = os.path.join(ROOT, "mod", "TowerMaster", "art", "rig_anims.json")
    anims = json.load(open(anims_path, encoding="utf-8"))
    parts = sorted(rig["parts"], key=lambda p: p["z"])
    images = {p["name"]: Image.open(os.path.join(ART, p["file"])).convert("RGBA") for p in parts}
    return rig, anims, parts, images


def check_parts(rig, parts, images):
    ok = True
    w, h = rig["canvas"]
    names = [p["name"] for p in parts]
    for need in GUIDE:
        if need not in names:
            print(f"✗ 缺部件 {need}"); ok = False
    for p in parts:
        im = images[p["name"]]
        if im.size != (w, h):
            print(f"✗ {p['file']} 尺寸 {im.size}，必须是 {w}×{h}（整张、原位，不能裁）"); ok = False
        corners = [im.getpixel(c)[3] for c in [(0, 0), (w - 1, 0), (0, h - 1), (w - 1, h - 1)]]
        if max(corners) > 0:
            print(f"✗ {p['file']} 四角不透明 {corners}"); ok = False
        if im.getbbox() is None:
            print(f"✗ {p['file']} 是空的"); ok = False
        if p["parent"] and p["parent"] not in names:
            print(f"✗ {p['name']} 的父部件 {p['parent']} 不存在"); ok = False
        if p["parent"]:
            parent = next(x for x in parts if x["name"] == p["parent"])
            if parent["z"] >= p["z"]:
                print(f"✗ {p['name']} 的 z 必须比父部件 {p['parent']} 大"); ok = False
    print("✓ 部件检查通过" if ok else "部件检查有问题（见上）")
    return ok


def sample(keys, t):
    if t <= keys[0][0]: return keys[0]
    for i in range(1, len(keys)):
        if t > keys[i][0]: continue
        a, b = keys[i - 1], keys[i]
        u = (t - a[0]) / max(1e-4, b[0] - a[0]); u = u * u * (3 - 2 * u)
        return [a[j] + (b[j] - a[j]) * u for j in range(6)]
    return keys[-1]


def idle_of(anims, name, w):
    ch = anims["idle"].get(name, {})
    def c(n):
        v = ch.get(n); return v[0] * math.sin(v[1] * w + v[2]) if v else 0
    return [0, c("rot"), c("x"), c("y"), 1 + c("s"), 1 + c("glow")]


def pose(anims, anim, t, clock):
    """每个部件的 [转角, x, y, 缩放, 亮度]（待机 + 动作，和游戏一样叠加）。"""
    out = {}
    act = anims["actions"].get(anim) if anim != "idle" else None
    for name in GUIDE:
        i = idle_of(anims, name, clock)
        a = sample(act["parts"][name], t) if act and name in act["parts"] else [0, 0, 0, 0, 1, 1]
        out[name] = (i[1] + a[1], i[2] + a[2], i[3] + a[3], i[4] * a[4], i[5] * a[5])
    return out


def render(rig, parts, images, poses, bg=(30, 33, 44, 255), scale=0.6):
    w, h = rig["canvas"]
    canvas = Image.new("RGBA", (w, h), bg)
    world = {}
    pivots = {p["name"]: p["pivot"] for p in parts}
    for p in parts:
        name = p["name"]
        px, py = p["pivot"]
        parent = p["parent"]
        ppx, ppy = pivots[parent] if parent else (0, 0)
        rot, ox, oy, s, glow = poses.get(name, (0, 0, 0, 1, 1))
        local = mul(mul(T(px - ppx + ox, py - ppy + oy), R(rot)), S(s))
        m = mul(world[parent], local) if parent else local
        world[name] = m
        sprite_m = mul(m, T(-px, -py))
        im = images[name]
        if glow != 1:
            r, g, b, a = im.split()
            r, g, b = [ch.point(lambda v: min(255, int(v * glow))) for ch in (r, g, b)]
            im = Image.merge("RGBA", (r, g, b, a))
        layer = im.transform((w, h), Image.AFFINE, inv(sprite_m), resample=Image.BICUBIC)
        canvas.alpha_composite(layer)
    return canvas.resize((int(w * scale), int(h * scale)), Image.LANCZOS)


def gif(rig, anims, parts, images, anim, path):
    length = 3.4 if anim == "idle" else anims["actions"][anim]["length"] + 0.3
    frames = []
    for i in range(int(length * 30)):
        t = i / 30
        frames.append(render(rig, parts, images, pose(anims, anim, t, t)).convert("P", palette=Image.ADAPTIVE))
    frames[0].save(path, save_all=True, append_images=frames[1:], duration=33, loop=0)


def holes(rig, anims, parts, images, anim, path):
    act = anims["actions"][anim]
    # 取动作里转角最大的那一刻
    best_t, best = 0, -1
    for i in range(int(act["length"] * 60)):
        t = i / 60
        mag = sum(abs(v[0]) for v in pose(anims, anim, t, 0).values())
        if mag > best: best, best_t = mag, t
    img = render(rig, parts, images, pose(anims, anim, best_t, 0), bg=(255, 0, 255, 255), scale=1.0)
    img.save(path)
    print(f"  {anim}：最大幅度在 {best_t:.2f} 秒，品红底图 {os.path.basename(path)}（看人物内部有没有品红）")


def guide():
    src = Image.open(os.path.join(ROOT, "mod", "TowerMaster", "art", "master_figure.png")).convert("RGBA")
    bg = Image.new("RGBA", src.size, (30, 33, 44, 255)); bg.alpha_composite(src)
    big = bg.resize((src.width * 2, src.height * 2), Image.LANCZOS)
    d = ImageDraw.Draw(big)
    colors = {"smoke": (180, 120, 255), "body": (255, 255, 255), "arm_free": (80, 220, 255), "head": (255, 220, 80),
              "arm_lantern": (120, 255, 120), "lantern": (255, 120, 120)}
    for name, ((x, y), parent, text) in GUIDE.items():
        c = colors[name] + (255,)
        X, Y = x * 2, y * 2
        d.ellipse([X - 10, Y - 10, X + 10, Y + 10], outline=c, width=3)
        d.line([X - 18, Y, X + 18, Y], fill=c, width=2); d.line([X, Y - 18, X, Y + 18], fill=c, width=2)
        d.text((X + 14, Y - 26), f"{name} ({x},{y})", fill=c)
        if parent:
            px, py = GUIDE[parent][0]
            d.line([X, Y, px * 2, py * 2], fill=c[:3] + (120,), width=1)
    big.save(os.path.join(OUT, "guide.png"))
    print("已生成 guide.png（转轴位置；连线 = 挂在哪个父部件上）")


def main():
    os.makedirs(OUT, exist_ok=True)
    if "--guide" in sys.argv:
        guide(); return
    guide()
    rig, anims, parts, images = load()
    if not check_parts(rig, parts, images):
        print("先修好部件再看预览"); return
    # 静止叠回去和原图比
    rest = render(rig, parts, images, {}, bg=(0, 0, 0, 0), scale=1.0)
    orig = Image.open(os.path.join(ROOT, "mod", "TowerMaster", "art", "master_figure.png")).convert("RGBA")
    diff = ImageChops.difference(rest, orig).convert("L")
    diff.point(lambda v: min(255, v * 4)).save(os.path.join(OUT, "composite_diff.png"))
    mask = orig.split()[3].point(lambda a: 255 if a > 128 else 0)
    hist = diff.histogram(mask)
    total = sum(hist) or 1
    bad = sum(hist[25:]) / total
    print(f"{'✓' if bad < 0.03 else '✗'} 叠回去和原图：{bad:.1%} 的人物像素差得明显（< 3% 才算对齐；亮的地方看 composite_diff.png）")
    piv = render(rig, parts, images, {}, scale=1.0)
    d = ImageDraw.Draw(piv)
    for p in parts:
        x, y = p["pivot"]
        d.line([x - 12, y, x + 12, y], fill=(255, 60, 60, 255), width=2); d.line([x, y - 12, x, y + 12], fill=(255, 60, 60, 255), width=2)
        d.text((x + 8, y - 16), p["name"], fill=(255, 220, 80, 255))
    piv.save(os.path.join(OUT, "pivots.png"))
    for anim in ["idle"] + [a for a in anims["actions"] if not a.startswith("_")]:
        gif(rig, anims, parts, images, anim, os.path.join(OUT, f"anim_{anim}.gif"))
        print(f"已生成 anim_{anim}.gif")
        if anim != "idle":
            holes(rig, anims, parts, images, anim, os.path.join(OUT, f"holes_{anim}.png"))


if __name__ == "__main__":
    main()
