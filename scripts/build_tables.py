"""Build monsters.csv, encounters.csv, prices.csv and encounter_costs.csv.

战力 = 有效血量/10 + 前3回合意图伤害/6 + 机制分            (design.md「数值」)
召唤价 = max(1, round(战力 × 幕系数 [× 精英系数]))
标准开销 = Σ召唤价 + 群体税(第2只起 +1,+2,+3…)              (design.md「防滥用规则」)
幕系数：让该幕普通(非简单)遭遇的平均标准开销 = 1.2 × 该幕基础收入。
精英系数：只用幕系数时第一幕精英只有 4~8 点，达不到 design.md 的 10–12，所以精英怪再乘一个
统一的精英系数，按第一幕精英平均 11 点校准。原版多怪精英组按「一个精英遭遇」算，组内不收群体税。
"""
import csv
import itertools
import json
import math
import pathlib
import sys

sys.path.insert(0, str(pathlib.Path(__file__).parent))
from monster_curated import EXCLUDED, M, SUMMON_ACTS  # noqa: E402

ROOT = pathlib.Path(__file__).resolve().parent.parent
DATA = json.loads((ROOT / "data" / "extracted.json").read_text(encoding="utf-8"))
MON, ENC, ACTS = DATA["monsters"], DATA["encounters"], DATA["acts"]

ACT_ZH = {"Overgrowth": "第一幕·密林", "Underdocks": "第一幕·暗港", "Hive": "第二幕·蜂巢", "Glory": "第三幕·荣耀"}
ACT_NO = {"Overgrowth": 1, "Underdocks": 1, "Hive": 2, "Glory": 3}
BASE_INCOME = {1: 4, 2: 5, 3: 6}
TARGET_RATIO = 1.2          # 标准战斗 ≈ 1.2 × 一场收入
ELITE_TARGET_ACT1 = 11      # design.md：第一幕精英遭遇 10–12
ROOM_ZH = {"Monster": "普通", "Elite": "精英", "Boss": "Boss"}
MECH_KEYS = [("str", "力量成长"), ("summon", "召唤"), ("status", "塞废牌"), ("debuff", "减益"),
             ("artifact", "人工制品"), ("other", "其他")]

# Random lineups: list of (probability, [monster classes]).
SLIME_S, SLIME_M = ["LeafSlimeS", "TwigSlimeS"], ["LeafSlimeM", "TwigSlimeM"]
RANDOM_LINEUPS = {
    "SlimesNormal": [(1, ["TwigSlimeM", "LeafSlimeM", "LeafSlimeS", "TwigSlimeS"])],
    "SlimesWeak": [(0.5, ["LeafSlimeS", mid, "TwigSlimeS"]) for mid in SLIME_M],
    "FlyconidNormal": [(0.5, [mid, "Flyconid"]) for mid in SLIME_M],
    "SlitheringStranglerNormal":
        [(1 / 3, ["SnappingJaxfruit", "SlitheringStrangler"])]
        + [(1 / 6, [mid, "SlitheringStrangler"]) for mid in SLIME_M]
        + [(1 / 12, [a, b, "SlitheringStrangler"]) for a in SLIME_S for b in SLIME_S],
    "RubyRaidersNormal": [(1 / 10, list(c)) for c in itertools.combinations(
        ["AxeRubyRaider", "AssassinRubyRaider", "BruteRubyRaider", "CrossbowRubyRaider", "TrackerRubyRaider"], 3)],
    "BowlbugsNormal": [(1 / 3, ["BowlbugRock", *c]) for c in itertools.combinations(
        ["BowlbugEgg", "BowlbugSilk", "BowlbugNectar"], 2)],
    "BowlbugsWeak": [(0.5, ["BowlbugRock", b]) for b in ["BowlbugEgg", "BowlbugNectar"]],
    "DecimillipedeElite": [(1, ["DecimillipedeSegment"] * 3)],
}


def lineups(enc_cls):
    if enc_cls in RANDOM_LINEUPS:
        return RANDOM_LINEUPS[enc_cls]
    return [(1, ENC[enc_cls]["generated"])]


def rnd(x):
    return int(math.floor(x + 0.5))


def crowd_tax(n):
    return n * (n - 1) // 2


# ------------------------------------------------------------------ monster facts
def hp_avg(cls):
    src = MON[cls]
    return (src["hp_min"] + src["hp_max"]) / 2


def power(cls):
    c = M[cls]
    ehp = hp_avg(cls) + c["ehp"]
    return ehp / 10 + sum(c["dmg"]) / 6 + sum(c["mech"].values())


INTENT_ZH = {"defend": "格挡", "buff": "增益", "debuff": "减益", "carddebuff": "卡牌减益", "summon": "召唤",
             "stun": "眩晕", "sleep": "沉睡", "heal": "回血", "escape": "逃跑", "hidden": "无"}


def fmt_moves(cls):
    parts = []
    for mv in MON[cls]["moves"]:
        bits = []
        for kind, val, hits in mv["intents"]:
            if kind == "attack":
                bits.append(f"攻击{val if val is not None else '?'}" + (f"×{hits}" if hits and hits > 1 else "")
                            + ("×N(递增)" if hits is None else ""))
            elif kind == "deathblow":
                bits.append(f"自爆{val}")
            elif kind == "status":
                bits.append(f"塞{val}张状态牌" if val else "塞状态牌")
            else:
                bits.append(INTENT_ZH.get(kind, kind))
        title = mv["title"] or mv["id"]
        parts.append(f"{title}[{mv['id']}]: {' + '.join(bits) or '无'}")
    return "；".join(parts)


# ------------------------------------------------------------------ act membership
def monster_acts():
    acts = {}
    weak = {}
    for act, info in ACTS.items():
        for enc in info["encounters"]:
            for _, lu in lineups(enc):
                for mcls in lu:
                    acts.setdefault(mcls, set()).add(act)
                    if ENC[enc]["is_weak"]:
                        weak.setdefault(mcls, set()).add(act)
    for mcls, a in SUMMON_ACTS.items():
        acts.setdefault(mcls, set()).update(a)
    return acts, weak


ACT_ORDER = list(ACT_ZH)


def act_label(acts):
    return " / ".join(ACT_ZH[a] for a in ACT_ORDER if a in acts)


# ------------------------------------------------------------------ calibration
ELITE_MULT = 1.0  # set by main() after calibration


def price(cls, k):
    mult = ELITE_MULT if M[cls]["role"] == "精英" else 1.0
    return max(1, rnd(power(cls) * k * mult))


def encounter_cost(enc_cls, k):
    """Expected standard cost (with crowd tax) and expected base price sum."""
    is_elite = ENC[enc_cls]["room_type"] == "Elite"
    total = base = 0.0
    for p, lu in lineups(enc_cls):
        s = sum(price(c, k) for c in lu)
        base += p * s
        total += p * (s + (0 if is_elite else crowd_tax(len(lu))))
    return total, base


def calibrate_elite(k1):
    global ELITE_MULT
    encs = [e for a, info in ACTS.items() if ACT_NO[a] == 1 for e in info["encounters"]
            if ENC[e]["room_type"] == "Elite"]
    best = None
    for i in range(100, 501):
        ELITE_MULT = i / 100
        mean = sum(encounter_cost(e, k1)[0] for e in encs) / len(encs)
        if best is None or abs(mean - ELITE_TARGET_ACT1) < best[0] - 1e-9:
            best = (abs(mean - ELITE_TARGET_ACT1), ELITE_MULT, mean)
    ELITE_MULT = best[1]
    return best[1], best[2]


def normal_encounters(act_no):
    return [e for a, info in ACTS.items() if ACT_NO[a] == act_no for e in info["encounters"]
            if ENC[e]["room_type"] == "Monster" and not ENC[e]["is_weak"]]


def calibrate(act_no, with_tax=True):
    target = TARGET_RATIO * BASE_INCOME[act_no]
    encs = normal_encounters(act_no)
    best = None
    for i in range(10, 1001):
        k = i / 1000
        mean = sum(encounter_cost(e, k)[0 if with_tax else 1] for e in encs) / len(encs)
        err = abs(mean - target)
        if best is None or err < best[0] - 1e-9:
            best = (err, k, mean)
    return best[1], best[2], target


def main():
    acts_of, weak_of = monster_acts()
    missing = [c for c in acts_of if c not in M and c not in EXCLUDED]
    assert not missing, f"monsters in acts without curated data: {missing}"

    k = {}
    calib_rows = []
    for act_no in (1, 2, 3):
        k_tax, mean_tax, target = calibrate(act_no, True)
        k_raw, mean_raw, _ = calibrate(act_no, False)
        k[act_no] = k_tax
        calib_rows.append((act_no, target, k_tax, mean_tax, k_raw, mean_raw))
    elite_mult, elite_mean = calibrate_elite(k[1])

    out = ROOT
    # monsters.csv
    with open(out / "monsters.csv", "w", newline="", encoding="utf-8-sig") as f:
        w = csv.writer(f)
        w.writerow(["类名", "中文名", "英文名", "所属幕", "类型", "简单遭遇池", "最小血量", "最大血量", "平均血量",
                    "额外有效血量", "有效血量", "有效血量说明", "招式(意图)", "意图顺序", "特殊效果",
                    "T1伤害", "T2伤害", "T3伤害", "前3回合伤害", "伤害说明",
                    *[n for _, n in MECH_KEYS], "机制分合计", "机制说明", "战力", "源文件"])
        for cls in sorted(M, key=lambda c: (min(ACT_ORDER.index(a) for a in acts_of[c]), M[c]["role"], c)):
            c, src = M[cls], MON[cls]
            mech = [c["mech"].get(key, 0) for key, _ in MECH_KEYS]
            w.writerow([cls, src["name_zh"], src["name_en"], act_label(acts_of[cls]), c["role"],
                        "是" if cls in weak_of else "", src["hp_min"], src["hp_max"], hp_avg(cls),
                        c["ehp"], hp_avg(cls) + c["ehp"], c["ehp_note"], fmt_moves(cls), c["order"], c["effects"],
                        *c["dmg"], sum(c["dmg"]), c["dmg_note"], *mech, sum(mech), c["mech_note"],
                        round(power(cls), 2), src["file"]])

    # encounters.csv
    with open(out / "encounters.csv", "w", newline="", encoding="utf-8-sig") as f:
        w = csv.writer(f)
        w.writerow(["幕", "遭遇类名", "中文名", "房间类型", "简单遭遇", "怪物数", "怪物组合(概率)", "源文件"])
        for act in ACT_ORDER:
            for enc in ACTS[act]["encounters"]:
                lus = lineups(enc)
                combo = " | ".join(
                    (f"{p:.0%} " if len(lus) > 1 else "") + " + ".join(MON[c]["name_zh"] for c in lu) for p, lu in lus)
                counts = sorted({len(lu) for _, lu in lus})
                w.writerow([ACT_ZH[act], enc, ENC[enc]["name_zh"], ROOM_ZH[ENC[enc]["room_type"]],
                            "是" if ENC[enc]["is_weak"] else "", "/".join(map(str, counts)), combo,
                            f"decompiled/sts2/MegaCrit.Sts2.Core.Models.Encounters/{enc}.cs"])

    # prices.csv
    with open(out / "prices.csv", "w", newline="", encoding="utf-8-sig") as f:
        w = csv.writer(f)
        w.writerow(["幕", "中文名", "类名", "类型", "简单遭遇池", "有效血量", "前3回合伤害", "机制分", "战力", "幕系数",
                    "精英系数", "召唤价"])
        for act in ACT_ORDER:
            n = ACT_NO[act]
            rows = [c for c in M if act in acts_of[c]]
            for cls in sorted(rows, key=lambda c: (["普通", "精英", "Boss", "召唤物"].index(M[c]["role"]), -power(c))):
                c = M[cls]
                w.writerow([ACT_ZH[act], MON[cls]["name_zh"], cls, c["role"], "是" if act in weak_of.get(cls, ()) else "",
                            hp_avg(cls) + c["ehp"], sum(c["dmg"]), sum(c["mech"].values()), round(power(cls), 2), k[n],
                            ELITE_MULT if c["role"] == "精英" else "", price(cls, k[n])])

    # encounter_costs.csv
    cap = {"Monster": 1.6, "Elite": 1.5}
    with open(out / "encounter_costs.csv", "w", newline="", encoding="utf-8-sig") as f:
        w = csv.writer(f)
        w.writerow(["幕", "遭遇", "中文名", "房间类型", "简单遭遇", "怪物数", "召唤价合计(期望)", "群体税", "标准开销(期望)",
                    "单场上限", "构成(召唤价)"])
        for act in ACT_ORDER:
            n = ACT_NO[act]
            for enc in ACTS[act]["encounters"]:
                total, base = encounter_cost(enc, k[n])
                rt = ENC[enc]["room_type"]
                lus = lineups(enc)
                parts = " | ".join(" + ".join(f"{MON[c]['name_zh']}{price(c, k[n])}" for c in lu)
                                   for _, lu in lus[:4]) + (" | …" if len(lus) > 4 else "")
                w.writerow([ACT_ZH[act], enc, ENC[enc]["name_zh"], ROOM_ZH[rt], "是" if ENC[enc]["is_weak"] else "",
                            "/".join(map(str, sorted({len(lu) for _, lu in lus}))), round(base, 2),
                            round(total - base, 2), round(total, 2),
                            round(total * cap[rt], 1) if rt in cap else "", parts])

    # console summary
    print("幕 | 目标 | 幕系数(含群体税) 普通均值 | 幕系数(不含税) 普通均值")
    for act_no, target, kt, mt, kr, mr in calib_rows:
        print(f"{act_no} | {target:.1f} | {kt:.3f} {mt:.2f} | {kr:.3f} {mr:.2f}")
    for act in ACT_ORDER:
        n = ACT_NO[act]
        by = {}
        for enc in ACTS[act]["encounters"]:
            rt = ENC[enc]["room_type"] + ("-weak" if ENC[enc]["is_weak"] else "")
            by.setdefault(rt, []).append(encounter_cost(enc, k[n])[0])
        print(ACT_ZH[act], {r: round(sum(v) / len(v), 2) for r, v in by.items()})
    print(f"精英系数 {ELITE_MULT}（第一幕精英平均 {elite_mean:.2f}）")
    (ROOT / "data" / "calibration.json").write_text(json.dumps(
        {"k": k, "elite_mult": ELITE_MULT, "rows": calib_rows}, ensure_ascii=False, indent=1), encoding="utf-8")
    write_price_book(k, acts_of, weak_of)


ROLE_EN = {"普通": "Normal", "精英": "Elite", "Boss": "Boss", "召唤物": "Summon"}


def write_price_book(k, acts_of, weak_of):
    """mod/TowerMaster.Core 读取的价格表：每幕可召唤的怪物、召唤价，以及每个原版遭遇的组合与标准开销。"""
    book = {"version": "v0.111.0", "act_coefficient": k, "elite_multiplier": ELITE_MULT, "acts": {}}
    for act in ACT_ORDER:
        n = ACT_NO[act]
        monsters = {}
        for cls in sorted(c for c in M if act in acts_of[c]):
            monsters[cls] = {"name_zh": MON[cls]["name_zh"], "role": ROLE_EN[M[cls]["role"]],
                             "weak_pool": act in weak_of.get(cls, ()), "price": price(cls, k[n])}
        encounters = {}
        for enc in ACTS[act]["encounters"]:
            encounters[enc] = {"name_zh": ENC[enc]["name_zh"], "room": ENC[enc]["room_type"],
                               "weak": ENC[enc]["is_weak"],
                               "lineups": [{"p": round(p, 6), "monsters": lu} for p, lu in lineups(enc)],
                               "standard_cost": round(encounter_cost(enc, k[n])[0], 2)}
        book["acts"][act] = {"act_no": n, "name_zh": ACT_ZH[act], "monsters": monsters, "encounters": encounters}
    # 召唤阶段：任何房间都能召唤任何幕的普通、精英怪，价格按战力现算（跨幕怪还有血量折扣），所以导出战力的组成
    all_monsters = {}
    for cls, c in M.items():
        if c["role"] not in ("普通", "精英"):
            continue
        all_monsters[cls] = {"name_zh": MON[cls]["name_zh"], "role": ROLE_EN[c["role"]],
                             "home_act": min(ACT_NO[a] for a in acts_of[cls]),
                             "ehp": round(hp_avg(cls) + c["ehp"], 2), "damage": sum(c["dmg"]),
                             "mechanics": sum(c["mech"].values())}
    book["all_monsters"] = dict(sorted(all_monsters.items()))
    (ROOT / "data" / "price_book.json").write_text(
        json.dumps(book, ensure_ascii=False, indent=1) + "\n", encoding="utf-8")


if __name__ == "__main__":
    main()
