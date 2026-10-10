"""只读 Godot PCK，导出节点结构及布局属性；不导出资源或场景原文。"""
import argparse, hashlib, re, struct
from pathlib import Path

p = argparse.ArgumentParser()
p.add_argument('pck')
p.add_argument('--output', default='docs/game-api/scene-trees.md')
p.add_argument('--game-version', default='v0.111.0')
a = p.parse_args()
targets = ['scenes/rooms/combat_room.tscn', 'scenes/screens/map/map_screen.tscn',
           'scenes/screens/rewards_screen.tscn', 'scenes/ui/top_bar.tscn',
           'scenes/cards/card.tscn', 'scenes/combat/player_hand.tscn']
with open(a.pck, 'rb') as f:
    if f.read(4) != b'GDPC': raise ValueError('不是独立 GDPC 文件')
    fmt, major, minor, patch = struct.unpack('<4I', f.read(16))
    flags, base = struct.unpack('<IQ', f.read(12)) if fmt >= 2 else (0, 0)
    if flags & 1: raise ValueError('加密目录，无法读取')
    if fmt >= 3: f.seek(struct.unpack('<Q', f.read(8))[0])
    else: f.read(64)
    count, = struct.unpack('<I', f.read(4))
    entries = {}
    for _ in range(count):
        n, = struct.unpack('<I', f.read(4))
        name = f.read(n).rstrip(b'\0').decode('utf-8')
        off, size = struct.unpack('<QQ', f.read(16))
        f.read(16)
        enc, = struct.unpack('<I', f.read(4))
        entries[name.removeprefix('res://')] = off, size, enc
    out = ['# 场景节点结构（游戏 '+a.game_version+'）', '',
           'PCK 只读解析。仅记录节点元数据及布局数值，不包含资源或场景全文。实例节点类型来自外部场景引用；其内部树需递归查看被引用场景，此表不伪造展开。运行时添加的节点不在静态树中。', '']
    # 递归记录实例引用的外部场景，保留引用关系而不伪造父实例的布局覆盖。
    for target in targets:
        out += ['## ' + target, '']
        if target not in entries:
            out += ['未找到；已查询独立 PCK 文件索引。', '']; continue
        off, size, enc = entries[target]
        if enc & 1: raise ValueError('加密资源：'+target)
        f.seek(base+off)
        data = f.read(size)
        text = data.decode('utf-8')
        external = {m[2]: (m[0], m[1]) for m in re.findall(r'\[ext_resource type="([^"]+)"[^\n]*path="([^"]+)"[^\n]*id="([^"]+)"', text)}
        out += ['资源 SHA256 `' + hashlib.sha256(data).hexdigest() + '`。', '',
                '| 节点名 | 节点路径（根相对） | 类型/实例引用 | 布局与输入属性 |', '| --- | --- | --- | --- |']
        for m in re.finditer(r'^\[node ([^\n]+)\]\s*\n(.*?)(?=^\[|\Z)', text, re.M|re.S):
            header, body = m.groups()
            attrs = dict(re.findall(r'(\w+)="([^"]*)"', header))
            name, parent = attrs['name'], attrs.get('parent')
            nodepath = '/' if parent is None else (parent.rstrip('/')+'/' if parent!='.' else '')+name
            instance = re.search(r'instance=ExtResource\("([^"]+)"\)', header)
            kind = attrs.get('type', '实例')
            if instance:
                ref = external.get(instance[1], ('未知','未找到外部引用'))
                kind += ' → ' + ref[1]
                dep = ref[1].removeprefix('res://')
                if dep in entries and dep.endswith('.tscn') and dep not in targets: targets.append(dep)
            script = re.search(r'^script = ExtResource\("([^"]+)"\)', body, re.M)
            if script: kind += ' / 脚本 ' + external.get(script[1], ('','未知'))[1]
            props=[]
            for line in body.splitlines():
                if re.match(r'^(anchors_preset|anchor_\w+|offset_\w+|grow_\w+|size_flags_\w+|custom_minimum_size|position|scale|mouse_filter|layout_mode|visible|unique_name_in_owner)\s*=', line): props.append(line.strip())
            out.append('| `'+name+'` | `'+nodepath+'` | `'+kind+'` | '+ '; '.join(props).replace('|','\\|') +' |')
        out.append('')
Path(a.output).parent.mkdir(parents=True, exist_ok=True)
Path(a.output).write_text('\n'.join(out), encoding='utf-8')
print('Scene trees: '+a.output)
