#!/usr/bin/env python3
"""召唤点经济离线模拟（不跑游戏，用价格表 + 配置默认值算账）。

用法：python scripts/balance_sim.py [--climbers 1] [--policy standard|cap|save] [--config mod/.../towermaster.config.json]

模拟一局三幕的典型路线（每幕 7 场普通 + 2 精英 + 1 Boss，第一幕前 3 场开局保护），塔主按策略花点：
- standard：每场花标准开销（原版强度）
- cap：每场花到单场上限（最大压迫）
- save：普通房花标准的 70%，省下来砸精英和 Boss
输出每场前后的召唤点、花费、收入、作废，以及每幕汇总。战果奖励按每场玩家掉血估计（--damage，默认 12）。
"""
import argparse, json, math, os

ROOT = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))

DEFAULTS = {
    "starting_summon_points": 12, "base_income": [5, 6, 7], "climber_income_factor": [1.0, 1.25, 1.5],
    "savings_bonus_divisor": 2, "savings_bonus_max": 3, "damage_per_bonus_point": 15, "damage_bonus_max": 2,
    "savings_cap": [30, 45, 60],
    "normal_spend_cap_multiplier": 1.35, "elite_spend_cap_multiplier": 1.3, "opening_spend_cap_multiplier": 1.3,
    "boss_extra_spend_cap_multiplier": 1.0, "opening_protection_battles": 3, "elite_room_discount": 0.85,
}


def by_act(values, act):
    return values[min(max(act, 1), len(values)) - 1]


def main():
    ap = argparse.ArgumentParser()
    ap.add_argument("--climbers", type=int, default=1)
    ap.add_argument("--policy", default="standard", choices=["standard", "cap", "save"])
    ap.add_argument("--damage", type=float, default=12, help="每场玩家合计掉血（估计战果奖励）")
    ap.add_argument("--config", default=None)
    ap.add_argument("--act1", default="Overgrowth", choices=["Overgrowth", "Underdocks"])
    a = ap.parse_args()
    cfg = dict(DEFAULTS)
    if a.config:
        with open(a.config, encoding="utf-8") as f:
            cfg.update(json.load(f))
    book = json.load(open(os.path.join(ROOT, "data", "price_book.json"), encoding="utf-8"))

    # 第一幕是密林或暗港（--act1 选），之后是蜂巢、荣耀
    acts = [(k, book["acts"][k]) for k in (a.act1, "Hive", "Glory")]
    points = cfg["starting_summon_points"]
    battles = 0
    print(f"策略 {a.policy}，爬塔 {a.climbers} 人，开局 {points} 点\n")
    print("幕 场 房间   标准  上限  花费  收入  作废  余额")
    for act_no, (act_id, act) in enumerate(acts, start=1):
        enc = act["encounters"]
        normal = [e["standard_cost"] for e in enc.values() if e["room"] == "Monster" and not e.get("weak")]
        weak = [e["standard_cost"] for e in enc.values() if e["room"] == "Monster" and e.get("weak")]
        elite = [e["standard_cost"] for e in enc.values() if e["room"] == "Elite"]
        avg_n, avg_w, avg_e = (round(sum(x) / len(x)) if x else 0 for x in (normal, weak, elite))
        cap = by_act(cfg["savings_cap"], act_no)
        points = min(points, cap)
        spent_act = wasted_act = income_act = 0
        rooms = ["Monster"] * 4 + ["Elite"] + ["Monster"] * 3 + ["Elite", "Boss"]
        for room in rooms:
            opening = act_no == 1 and room == "Monster" and battles < cfg["opening_protection_battles"]
            if room == "Monster":
                std = avg_w if opening else avg_n
                spend_cap = std * (cfg["opening_spend_cap_multiplier"] if opening else cfg["normal_spend_cap_multiplier"])
            elif room == "Elite":
                std = avg_e
                spend_cap = std * cfg["elite_spend_cap_multiplier"]
            else:
                std = 0
                spend_cap = sum(normal) / max(1, len(normal)) * cfg["boss_extra_spend_cap_multiplier"]
            if a.policy == "standard":
                want = std if room != "Boss" else 0
            elif a.policy == "cap":
                want = math.floor(spend_cap)
            else:
                want = math.floor(std * 0.7) if room == "Monster" else math.floor(spend_cap)
            spend = min(want, points)
            points -= spend
            base = math.floor(by_act(cfg["base_income"], act_no) * by_act(cfg["climber_income_factor"], a.climbers))
            saving = min(cfg["savings_bonus_max"], max(0, (std - spend) // cfg["savings_bonus_divisor"])) if room == "Monster" else 0
            damage = min(cfg["damage_bonus_max"], math.floor(a.damage / cfg["damage_per_bonus_point"]))
            income = base + saving + damage
            credited = min(income, cap - points)
            wasted = income - credited
            points += credited
            battles += 1
            spent_act += spend
            wasted_act += wasted
            income_act += credited
            print(f"{act_no:>2} {battles:>2} {room:<6} {std:>4} {spend_cap:>5.1f} {spend:>5} {credited:>5} {wasted:>5} {points:>5}")
        print(f"   第{act_no}幕：花 {spent_act}，入账 {income_act}，作废 {wasted_act}，幕末余额 {points}（上限 {cap}）\n")


if __name__ == "__main__":
    main()
