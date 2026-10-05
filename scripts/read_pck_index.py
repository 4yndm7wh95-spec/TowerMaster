"""List files inside a Godot 4 .pck (read-only) and optionally extract matches to an output dir."""
import struct, sys, os, re
pck, pattern, outdir = sys.argv[1], sys.argv[2], (sys.argv[3] if len(sys.argv) > 3 else None)
with open(pck, 'rb') as f:
    magic = f.read(4); assert magic == b'GDPC', magic
    fmt, vmaj, vmin, vpat = struct.unpack('<4I', f.read(16))
    flags = 0; file_base = 0; dir_off = None
    if fmt >= 2:
        flags, file_base = struct.unpack('<IQ', f.read(12))
    if fmt >= 3:
        dir_off, = struct.unpack('<Q', f.read(8))
    print(f'format={fmt} godot={vmaj}.{vmin}.{vpat} flags={flags:#x} file_base={file_base} dir={dir_off}', file=sys.stderr)
    if flags & 1: sys.exit('encrypted directory')
    if dir_off is not None: f.seek(dir_off)
    else: f.read(16 * 4)
    count, = struct.unpack('<I', f.read(4))
    rx = re.compile(pattern)
    entries = []
    for _ in range(count):
        n, = struct.unpack('<I', f.read(4)); path = f.read(n).rstrip(b'\0').decode('utf-8', 'replace')
        off, size = struct.unpack('<QQ', f.read(16)); f.read(16); fl, = struct.unpack('<I', f.read(4))
        if rx.search(path): entries.append((path, off, size, fl))
    for path, off, size, fl in entries:
        print(f'{path}\t{size}\t{"ENC" if fl & 1 else ""}')
        if outdir and not fl & 1:
            f.seek(file_base + off); data = f.read(size)
            dst = os.path.join(outdir, path.replace('res://', '')); os.makedirs(os.path.dirname(dst), exist_ok=True)
            open(dst, 'wb').write(data)
