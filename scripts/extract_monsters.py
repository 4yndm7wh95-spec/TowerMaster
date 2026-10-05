"""Pull machine-readable facts out of the decompiled monster/encounter/act classes.

Only things that can be read reliably by pattern are extracted here (HP, move list with
intents, encounter composition, act membership). Turn-by-turn damage and mechanic scoring
need judgement and live in monster_curated.py.

All numbers are the base (Ascension 0) values: for AscensionHelper.GetValueIfAscension(level, a, b)
the game uses `a` when that ascension is active and `b` otherwise.
"""
import json
import pathlib
import re

ROOT = pathlib.Path(__file__).resolve().parent.parent
SRC = ROOT / "decompiled" / "sts2"
LOC = ROOT / "decompiled" / "pck" / "localization"


def snake(name: str) -> str:
    return re.sub(r"(?<=[a-z0-9])(?=[A-Z])", "_", name).upper()


def load_loc(table: str, lang: str = "zhs") -> dict:
    return json.loads((LOC / lang / f"{table}.json").read_text(encoding="utf-8"))


ASC = re.compile(r"AscensionHelper\.GetValueIfAscension\(AscensionLevel\.\w+,\s*(-?\d+),\s*(-?\d+)\)")


def props_of(text: str) -> dict:
    """Map property name -> raw expression for `X => expr;` members."""
    out = {}
    for m in re.finditer(r"(?:public|private|protected)[^\n=]*?\b(\w+)\s*=>\s*([^;]+);", text):
        out[m.group(1)] = m.group(2).strip()
    for m in re.finditer(r"const int (\w+) = (-?\d+);", text):
        out[m.group(1)] = m.group(2)
    return out


def resolve(expr: str, props: dict, depth: int = 0):
    """Evaluate a numeric expression at Ascension 0; returns int or None."""
    if depth > 5 or expr is None:
        return None
    expr = expr.strip()
    if re.fullmatch(r"-?\d+m?", expr):
        return int(expr.rstrip("m"))
    m = ASC.fullmatch(expr)
    if m:
        return int(m.group(2))
    m = re.fullmatch(r"(.+?)\s*\+\s*(\w+)", expr)
    if m and m.group(2) == "RespawnMaxHpBonus":  # Axebot: first body has no bonus
        return resolve(m.group(1), props, depth + 1)
    if re.fullmatch(r"\w+", expr) and expr in props:
        return resolve(props[expr], props, depth + 1)
    m = re.fullmatch(r"\(\)\s*=>\s*(\w+)", expr)
    if m:
        return resolve(m.group(1), props, depth + 1)
    return None


INTENT = re.compile(r"new (\w+Intent)\(([^()]*(?:\([^()]*\)[^()]*)*)\)")


def parse_intents(arg_text: str, props: dict) -> list:
    res = []
    for m in INTENT.finditer(arg_text):
        kind, args = m.group(1), [a.strip() for a in m.group(2).split(",")] if m.group(2).strip() else []
        if kind == "SingleAttackIntent":
            res.append(("attack", resolve(args[0], props), 1))
        elif kind == "MultiAttackIntent":
            res.append(("attack", resolve(args[0], props), resolve(args[1], props) if len(args) > 1 else None))
        elif kind == "DeathBlowIntent":
            res.append(("deathblow", resolve(args[0], props), 1))
        else:
            res.append((kind.replace("Intent", "").lower(), resolve(args[0], props) if args and "strong" not in args[0] else None, None))
    return res


def extract_monsters() -> dict:
    loc = load_loc("monsters")
    out = {}
    for f in sorted((SRC / "MegaCrit.Sts2.Core.Models.Monsters").glob("*.cs")):
        text = f.read_text(encoding="utf-8")
        cls = f.stem
        props = props_of(text)
        key = snake(cls)
        moves = []
        for m in re.finditer(r'new MoveState\("(\w+)",\s*([^,()]+(?:\([^)]*\)[^,()]*)?),?\s*(.*?)\)\s*(?:\{|;|\)|$)', text, re.M):
            move_id = m.group(1)
            line = text[m.start(): text.find("\n", m.start())]
            loc_key = f"{key}.moves.{move_id.removesuffix('_MOVE')}.title"
            moves.append({
                "id": move_id,
                "title": loc.get(loc_key) or loc.get(f"{key}.moves.{move_id}.title") or "",
                "intents": parse_intents(line, props),
            })
        out[cls] = {
            "class": cls,
            "name_zh": loc.get(f"{key}.name", ""),
            "name_en": load_loc("monsters", "eng").get(f"{key}.name", ""),
            "hp_min": resolve(props.get("MinInitialHp"), props),
            "hp_max": resolve(props.get("MaxInitialHp"), props),
            "moves": moves,
            "file": f"decompiled/sts2/MegaCrit.Sts2.Core.Models.Monsters/{f.name}",
        }
    return out


def extract_encounters() -> dict:
    loc = load_loc("encounters")
    out = {}
    for f in sorted((SRC / "MegaCrit.Sts2.Core.Models.Encounters").glob("*.cs")):
        text = f.read_text(encoding="utf-8")
        rt = re.search(r"RoomType => RoomType\.(\w+)", text)
        gen = text[text.find("GenerateMonsters()"):] if "GenerateMonsters()" in text else ""
        out[f.stem] = {
            "class": f.stem,
            "name_zh": loc.get(f"{snake(f.stem)}.title", ""),
            "room_type": rt.group(1) if rt else None,
            "is_weak": "IsWeak => true" in text,
            "generated": re.findall(r"Monster<(\w+)>\(\)", gen),
        }
    return out


def extract_acts() -> dict:
    out = {}
    for name in ("Overgrowth", "Underdocks", "Hive", "Glory"):
        text = (SRC / "MegaCrit.Sts2.Core.Models.Acts" / f"{name}.cs").read_text(encoding="utf-8")
        body = text[text.find("GenerateAllEncounters"):]
        out[name] = {
            "index": int(re.search(r"Index => (\d+)", text).group(1)),
            "weak_count": int(re.search(r"NumberOfWeakEncounters => (\d+)", text).group(1)),
            "encounters": re.findall(r"Encounter<(\w+)>\(\)", body[: body.find("}")]),
        }
    return out


if __name__ == "__main__":
    data = {"monsters": extract_monsters(), "encounters": extract_encounters(), "acts": extract_acts()}
    dst = ROOT / "data" / "extracted.json"
    dst.parent.mkdir(exist_ok=True)
    dst.write_text(json.dumps(data, ensure_ascii=False, indent=1), encoding="utf-8")
    print(f"{len(data['monsters'])} monsters, {len(data['encounters'])} encounters -> {dst}")
