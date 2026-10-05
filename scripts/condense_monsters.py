"""Strip presentation code from decompiled monster classes so the gameplay logic is easy to read."""
import re, sys, pathlib
src = pathlib.Path(sys.argv[1]); out = pathlib.Path(sys.argv[2])
DROP = re.compile(r'^\s*(using |namespace |\.(With(AttackerAnim|AttackerFx|HitFx|HitVfx|Sfx|NoAttackerAnim|WaitBefore)|OnlyPlayAnimOnce)|await Cmd\.Wait|SfxCmd\.|NCombatRoom|VfxCmd|CreatureCmd\.TriggerAnim|//)')
SKIP_PROP = re.compile(r'(Sfx|Vfx|Anim|Spine|Skin|Scene|Visuals|AssetPaths|Padding|HpBarSize|Phobia|ShouldFade|ShouldDisappear|DeathAnim|CanChangeScale|Camera|HurtAnimation)\b.*=>')
def strip_method(text, name_re):
    # remove whole methods matching name_re by brace counting
    out=[]; lines=text.split('\n'); i=0
    while i < len(lines):
        if re.match(r'\s*(public|private|protected|internal)\b', lines[i]) and re.search(name_re, lines[i]) and '(' in lines[i] and not lines[i].strip().endswith(';'):
            depth=0; started=False
            while i < len(lines):
                depth += lines[i].count('{') - lines[i].count('}')
                if '{' in lines[i]: started=True
                i+=1
                if started and depth<=0: break
            continue
        out.append(lines[i]); i+=1
    return '\n'.join(out)
buf=[]
for f in sorted(src.glob('*.cs')):
    t=f.read_text(encoding='utf-8')
    t=strip_method(t, r'(GenerateAnimator|SetupSkins|GenerateBestiaryMoveList|ShouldShowMoveInBestiary|OnDieToDoom|SetupVisuals|PlayAnim|UpdateVisual|AnimTrack)')
    lines=[l for l in t.split('\n') if l.strip() and not DROP.search(l) and not SKIP_PROP.search(l)]
    buf.append(f'##### {f.stem}\n' + '\n'.join(l.replace('\t','  ') for l in lines))
out.write_text('\n'.join(buf), encoding='utf-8')
print(len('\n'.join(buf).split('\n')))
# collapse trivial auto-property bodies: { get { return _x; } set { AssertMutable(); _x = value; } }
txt = out.read_text(encoding='utf-8')
txt = re.sub(r'\n\s*\{\n\s*get\n\s*\{\n\s*return [^;]+;\n\s*\}\n\s*(private |protected )?set\n\s*\{\n\s*AssertMutable\(\);\n\s*[^;]+ = value;\n\s*\}\n\s*\}', ' { get; set; }', txt)
out.write_text(txt, encoding='utf-8')
print(len(txt.split('\n')))
