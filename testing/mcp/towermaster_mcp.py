#!/usr/bin/env python3
"""TowerMaster 测试助手 MCP 服务（只用 Python 标准库）。

每个游戏实例里的 TowerMaster mod 在 TOWERMASTER_BRIDGE_PORT 指定的本机端口上开一个测试接口；
这个脚本把它们包装成 MCP 工具，并提供跨实例的等待、日志对比、测速和一键跑一场召唤战斗。

用法：
  python towermaster_mcp.py                      # 作为 MCP 服务（stdio）运行
  python towermaster_mcp.py list                 # 列出工具
  python towermaster_mcp.py call tm_instances    # 命令行直接调用一个工具
  python towermaster_mcp.py call tm_state '{"instance":"B"}'

实例配置：同目录 instances.json（可用 TOWERMASTER_MCP_INSTANCES 指定别的文件），没有就用
  {"A": {"port": 47101}, "B": {"port": 47102}}
令牌：实例配置里的 "token"，或环境变量 TOWERMASTER_BRIDGE_TOKEN。
"""
from __future__ import annotations

import json
import os
import re
import statistics
import sys
import time
import urllib.error
import urllib.request
from typing import Any, Callable

HERE = os.path.dirname(os.path.abspath(__file__))
DEFAULT_INSTANCES = {"A": {"port": 47101}, "B": {"port": 47102}}
# 本机接口不走代理（系统或环境变量里的代理会把 127.0.0.1 也转出去）
OPENER = urllib.request.build_opener(urllib.request.ProxyHandler({}))
COMPARE_KEYWORDS = ["收到清单", "已替换", "开始生成", "：生成 ", "水土不服", "找回", "塔主回合 #"]  # 陷阱触发、躲过也记在「塔主回合 #」行里


class ToolError(Exception):
    pass


# ---------------------------------------------------------------- 连接


def load_instances() -> dict[str, dict]:
    path = os.environ.get("TOWERMASTER_MCP_INSTANCES") or os.path.join(HERE, "instances.json")
    if os.path.exists(path):
        with open(path, encoding="utf-8") as f:
            return json.load(f)
    return DEFAULT_INSTANCES


def call(instance: str, route: str, body: dict | None = None, timeout: float = 30) -> dict:
    """调一个实例的接口，返回 result；接口报错时抛 ToolError（带错误码和说明）。"""
    instances = load_instances()
    if instance not in instances:
        raise ToolError(f"没有实例 {instance}，可用：{', '.join(instances)}")
    cfg = instances[instance]
    url = f"http://127.0.0.1:{cfg['port']}{route}"
    data = json.dumps(body or {}).encode("utf-8")
    req = urllib.request.Request(url, data=data, method="POST", headers={"Content-Type": "application/json"})
    token = cfg.get("token") or os.environ.get("TOWERMASTER_BRIDGE_TOKEN")
    if token:
        req.add_header("X-Token", token)
    try:
        with OPENER.open(req, timeout=timeout) as resp:
            payload = json.loads(resp.read().decode("utf-8"))
    except urllib.error.HTTPError as e:
        try:
            payload = json.loads(e.read().decode("utf-8"))
        except Exception:
            raise ToolError(f"{instance}{route}: HTTP {e.code}")
    except (urllib.error.URLError, ConnectionError, TimeoutError) as e:
        raise ToolError(f"{instance}{route}: 连不上（disconnected）：{e}")
    if not payload.get("ok"):
        raise ToolError(f"{instance}{route}: {payload.get('error')}：{payload.get('message')}")
    return payload["result"]


def host_instance() -> str:
    for name in load_instances():
        try:
            if call(name, "/ping", timeout=5).get("is_host"):
                return name
        except ToolError:
            continue
    raise ToolError("找不到房主（塔主）实例：都没连上或都不是房主")


def climber_instances() -> list[str]:
    result = []
    for name in load_instances():
        try:
            if not call(name, "/ping", timeout=5).get("is_host"):
                result.append(name)
        except ToolError:
            continue
    return result


# ---------------------------------------------------------------- 等待


def check_condition(instance: str, cond: dict) -> tuple[bool, Any]:
    """返回 (是否满足, 最后看到的状态)。条件字段全部满足才算满足。"""
    state = call(instance, "/state")
    ok = True
    for key, want in cond.items():
        if key == "summon_open":
            ok &= bool(state.get("summon_open")) == want
        elif key == "summon_or_draft":  # 召唤面板或选陷阱，哪个先出来都算
            ok &= bool(state.get("summon_open") or state.get("draft_open")) == want
        elif key == "draft_open":
            ok &= bool(state.get("draft_open")) == want
        elif key == "in_combat":
            ok &= bool((state.get("combat") or {}).get("in_progress")) == want
        elif key == "room":
            ok &= state.get("room") == want
        elif key == "point_type":
            ok &= state.get("point_type") == want
        elif key == "total_floor_at_least":
            ok &= (state.get("total_floor") or 0) >= want
        elif key == "paused_by_master_turn":
            ok &= bool(state.get("paused_by_master_turn")) == want
        elif key == "master_turn_open":
            ok &= bool(state.get("master_turn_open")) == want
        elif key == "rewards_visible":
            ok &= bool(state.get("rewards_visible")) == want
        elif key == "in_run":
            ok &= bool(state.get("in_run")) == want
        elif key == "log_contains":
            text = read_log(instance, cond.get("source", "mod"))
            ok &= want in text
        elif key == "source":
            continue
        else:
            raise ToolError(f"不认识的等待条件 {key}")
    return ok, state


def wait_for(instance: str, cond: dict, timeout_s: float = 30, interval: float = 0.25) -> dict:
    start = time.time()
    last = None
    while True:
        ok, last = check_condition(instance, cond)
        if ok:
            return {"met": True, "waited_s": round(time.time() - start, 2), "state": last}
        if time.time() - start > timeout_s:
            raise ToolError(f"timeout：{instance} 等 {json.dumps(cond, ensure_ascii=False)} 超过 {timeout_s} 秒；最后状态 {json.dumps(last, ensure_ascii=False)[:800]}")
        time.sleep(interval)


# ---------------------------------------------------------------- 日志


def read_log(instance: str, source: str = "mod", cursor: int = 0) -> str:
    chunks = []
    while True:
        r = call(instance, "/logs", {"source": source, "cursor": cursor, "max_bytes": 1 << 20})
        chunks.append(r["text"])
        cursor = r["cursor"]
        if not r["more"]:
            return "".join(chunks)


TIMESTAMP = re.compile(r"^\[\d\d:\d\d:\d\d\.\d{3}\]\s*")


def compare_logs(instances: list[str], keywords: list[str]) -> dict:
    per = {}
    for name in instances:
        lines = [TIMESTAMP.sub("", l) for l in read_log(name).splitlines()]
        per[name] = [l for l in lines if any(k in l for k in keywords)]
    names = list(per)
    base = per[names[0]]
    diffs = []
    for other in names[1:]:
        lines = per[other]
        for i in range(max(len(base), len(lines))):
            a = base[i] if i < len(base) else None
            b = lines[i] if i < len(lines) else None
            if a != b:
                diffs.append({"index": i, names[0]: a, other: b})
    return {
        "equal": not diffs,
        "counts": {k: len(v) for k, v in per.items()},
        "diffs": diffs[:30],
        "lines": per[names[0]][-40:],
    }


# ---------------------------------------------------------------- 一场战斗


def run_battle(args: dict) -> dict:
    """爬塔玩家选路 → 塔主面板选怪、截图、确认 → 两边进战斗对比怪物 → win → 等战斗结束、核对收入。"""
    host = args.get("host") or host_instance()
    climber = args.get("climber") or (climber_instances() or [None])[0]
    if not climber:
        raise ToolError("找不到爬塔玩家实例")
    steps: list[dict] = []
    t0 = time.time()

    def step(name: str, fn: Callable[[], Any]) -> Any:
        s = time.time()
        try:
            value = fn()
        except ToolError as e:
            steps.append({"step": name, "ok": False, "error": str(e), "s": round(time.time() - s, 2)})
            raise ToolError(json.dumps({"failed_at": name, "steps": steps}, ensure_ascii=False))
        steps.append({"step": name, "ok": True, "s": round(time.time() - s, 2)})
        return value

    # 1. 选路
    if args.get("col") is not None and args.get("row") is not None:
        target = {"col": args["col"], "row": args["row"]}
    else:
        options = step("map_options", lambda: call(climber, "/map/options"))
        want = args.get("point_type")
        nexts = [n for n in options.get("next") or [] if want is None or n["type"] == want]
        if not nexts:
            raise ToolError(f"下一步没有 {want or '任何'} 房间：{options}")
        target = nexts[0]["coord"]
    step("map_vote", lambda: call(climber, "/map/vote", target))

    # 2. 召唤
    summon = step("wait_summon", lambda: wait_for(host, {"summon_or_draft": True}, args.get("timeout_s", 60)))
    if summon["state"].get("draft_open"):  # 本幕第一次召唤前先挑陷阱
        result_pack = step("trap_draft", lambda: draft(host, args.get("draft")))
        summon = step("wait_summon_after_draft", lambda: wait_for(host, {"summon_open": True}, args.get("timeout_s", 60)))
    else:
        result_pack = None
    before = summon["state"].get("wallet")
    panel = step("summon_panel", lambda: call(host, "/summon"))
    shots = []
    prefix = args.get("screenshot_prefix", f"floor{summon['state'].get('total_floor')}")
    if args.get("screenshot", True):
        prefix = args.get("screenshot_prefix", f"floor{summon['state'].get('total_floor')}")
        shots.append(step("screenshot_panel", lambda: call(host, "/screenshot", {"name": f"{prefix}-panel"})))
    if args.get("vanilla"):
        confirm = step("summon_vanilla", lambda: call(host, "/summon/vanilla"))
    else:
        if args.get("monsters") is not None or args.get("encounter"):
            sel = step("summon_select", lambda: call(host, "/summon/select", {"encounter": args.get("encounter"), "monsters": args.get("monsters") or [], "traps": args.get("traps") or []}))
            if args.get("screenshot", True):
                shots.append(step("screenshot_selected", lambda: call(host, "/screenshot", {"name": f"{prefix}-selected"})))
            if not sel["can_confirm"]:
                raise ToolError(json.dumps({"failed_at": "summon_select", "quote": sel["quote"], "steps": steps}, ensure_ascii=False))
        confirm = step("summon_confirm", lambda: call(host, "/summon/confirm"))

    # 3. 进战斗，两边对比
    point = panel["room"]
    step("wait_combat_host", lambda: wait_for(host, {"in_combat": True}, args.get("timeout_s", 60)))
    step("wait_combat_climber", lambda: wait_for(climber, {"in_combat": True}, args.get("timeout_s", 60)))
    time.sleep(args.get("settle_s", 1.0))  # 等开场动画、降血写完
    sh = call(host, "/state")
    sc = call(climber, "/state")
    enemies_host = (sh.get("combat") or {}).get("enemies")
    enemies_climber = (sc.get("combat") or {}).get("enemies")
    if args.get("screenshot", True):
        shots.append(step("screenshot_combat", lambda: call(climber, "/screenshot", {"name": f"{prefix}-combat"})))

    result = {
        "trap_draft": result_pack,
        "host": host,
        "climber": climber,
        "room": point,
        "summon": confirm,
        "wallet_before": before,
        "enemies_host": enemies_host,
        "enemies_climber": enemies_climber,
        "enemies_equal": enemies_host == enemies_climber,
        "screenshots": [s["path"] for s in shots],
    }

    # 4. 塔主回合：玩家队列暂停期间 win 会排队等着，所以先按 threat 列表操作再结束
    try:  # 第一回合开始（开场动画后）才开塔主回合；没有威胁点时不会开
        wait_for(host, {"master_turn_open": True}, args.get("master_turn_wait_s", 6))
        opened = True
    except ToolError:
        opened = False
    result["master_turn_opened"] = opened
    if opened:
        result["threat"] = []
        for op in args.get("threat") or []:
            result["threat"].append(step(f"threat_{op.get('op')}", lambda op=op: call(host, "/threat/act", op)))
        if call(host, "/state").get("master_turn_open"):
            step("threat_end", lambda: call(host, "/threat/end"))
        result["threat_state"] = call(host, "/threat")

    # 5. 结束战斗：autoplay=true 时用机器人真打，否则 win
    if args.get("autoplay"):
        result["autoplay"] = step("autoplay", lambda: autoplay_battle({"instance": climber, "host": host,
                                  "policy": args.get("policy", "attack"), "master_policy": args.get("master_policy", "greedy")}))
        step("wait_combat_end", lambda: wait_for(host, {"in_combat": False}, args.get("timeout_s", 60)))
        time.sleep(args.get("settle_s", 1.0))
        result["wallet_after"] = call(host, "/state").get("wallet")
    elif args.get("win", True):
        step("console_win", lambda: call(climber, "/console", {"command": "win"}))
        step("wait_combat_end", lambda: wait_for(host, {"in_combat": False}, args.get("timeout_s", 60)))
        time.sleep(args.get("settle_s", 1.0))
        result["wallet_after"] = call(host, "/state").get("wallet")
        if args.get("read_rewards", True) or args.get("skip_rewards", False):
            step("wait_rewards", lambda: wait_for(climber, {"rewards_visible": True}, args.get("timeout_s", 60)))
            result["rewards"] = step("read_rewards", lambda: call(climber, "/rewards")).get("rewards")
        if args.get("skip_rewards", False):
            step("rewards_skip", lambda: call(climber, "/rewards/skip"))
    result["compare_logs"] = compare_logs([host, climber], COMPARE_KEYWORDS)
    result["steps"] = steps
    result["total_s"] = round(time.time() - t0, 2)
    return result


def draft(host: str, picks: list[int] | None) -> dict:
    """挑陷阱：给了 picks 就按序号选；没给就按候选顺序尽量挑（预算、张数内能加就加）。然后确认。"""
    info = call(host, "/traps").get("draft") or {}
    if picks is None:
        picks, spent = [], 0
        for o in info.get("offer", []):
            if o["owned"] or len(picks) >= info["max_picks"] or spent + o["cost"] > info["budget"]:
                continue
            picks.append(o["index"])
            spent += o["cost"]
    call(host, "/traps/draft/select", {"picks": picks})
    return call(host, "/traps/draft/confirm")


def balance_summary(instance: str) -> dict:
    """读塔主的平衡记录（每场一行 JSON），按幕、房间汇总。"""
    text = read_log(instance, "balance")
    rows = [json.loads(l) for l in text.splitlines() if l.strip()]
    groups: dict[str, list] = {}
    for r in rows:
        groups.setdefault(f"act{r.get('act_no')}-{r.get('room')}", []).append(r)

    def avg(xs):
        return round(sum(xs) / len(xs), 2) if xs else None

    summary = {}
    for key, rs in sorted(groups.items()):
        summary[key] = {
            "battles": len(rs),
            "won": sum(1 for r in rs if r.get("result") == "won"),
            "avg_damage_taken": avg([r.get("damage_taken", 0) for r in rs]),
            "avg_rounds": avg([r.get("rounds", 0) for r in rs]),
            "avg_standard_cost": avg([r.get("standard_cost", 0) for r in rs]),
            "avg_monster_spend": avg([r.get("monster_spend", 0) for r in rs]),
            "avg_spawned_hp": avg([r.get("spawned_hp", 0) for r in rs]),
            "avg_threat_spent": avg([r.get("threat_spent", 0) for r in rs]),
            "threat_allotted": avg([r.get("threat_allotted", 0) for r in rs]),
            "traps_placed": sum(len(r.get("traps_placed", [])) for r in rs),
            "traps_fired": sum(len(r.get("traps_fired", [])) for r in rs),
            "knockdowns": sum(len(r.get("knocked_down", [])) for r in rs),
            "vanilla_summons": sum(1 for r in rs if r.get("summon") == "vanilla"),
        }
    points = [(r.get("battle_index"), r.get("points_after_battle")) for r in rows]
    return {"rows": len(rows), "groups": summary, "points_curve": points, "last": rows[-3:]}


# ---------------------------------------------------------------- 自动打牌（平衡测试用，策略固定、可重复）


def _energy(hand: dict) -> int:
    e = hand.get("energy")
    try:
        return int(e)
    except (TypeError, ValueError):
        return 0


def master_turn(host: str, policy: str) -> list:
    """塔主回合策略：none 什么都不做；greedy 先给血最多的怪加力量，再给血最少的怪加格挡，最后给玩家上易伤/虚弱；
    debuff 只上减益和眩晕。点数用完或没得做就结束。"""
    done = []
    for _ in range(12):
        t = call(host, "/threat")
        if not t.get("open"):
            return done
        points = t.get("points") or 0
        monsters, players = t.get("monsters") or [], t.get("players") or []
        tries = []
        if policy == "greedy" and monsters:
            strong = max(monsters, key=lambda m: m["hp"])
            weak = min(monsters, key=lambda m: m["hp"])
            if points >= 2:
                tries.append({"op": "strength", "monster": strong["index"]})
            tries.append({"op": "block", "monster": weak["index"]})
        if policy in ("greedy", "debuff") and players:
            p = players[0]["net_id"]
            tries += [{"op": "vulnerable", "player": p}, {"op": "weak", "player": p}, {"op": "dazed", "player": p}]
        acted = False
        for op in tries:
            try:
                call(host, "/threat/act", op)
                done.append(op["op"])
                acted = True
                time.sleep(0.3)
                break
            except ToolError:
                continue
        if not acted:
            break
    try:
        if call(host, "/threat").get("open"):
            call(host, "/threat/end")
    except ToolError:
        pass
    return done


def autoplay_turn(inst: str, policy: str, host: str | None, master_policy: str) -> dict:
    """爬塔玩家打一回合：等塔主回合结束；按策略顺序反复尝试出牌（出不去的跳过），直到一轮都出不去；然后结束回合。
    策略：attack 先攻击后技能；block 先技能后攻击。不看怪物意图——这是固定基准，不是最优打法。"""
    played, master_ops = [], []
    for _ in range(120):  # 最多等 60 秒塔主回合
        if host and call(host, "/state").get("master_turn_open"):
            master_ops += master_turn(host, master_policy)
        if not call(inst, "/state").get("paused_by_master_turn"):
            break
        time.sleep(0.5)
    first = ("Attack", "Skill", "Power") if policy == "attack" else ("Skill", "Power", "Attack")
    for _ in range(12):
        hand = call(inst, "/combat/hand")
        if _energy(hand) <= 0 and not any(c.get("type") == "Power" for c in hand["hand"]):
            break
        cards = sorted(hand["hand"], key=lambda c: first.index(c["type"]) if c.get("type") in first else 9)
        progressed = False
        for c in cards:
            if c.get("type") in ("Status", "Curse"):
                continue
            before = len(hand["hand"])
            try:
                call(inst, "/combat/play", {"index": c["index"]})
            except ToolError:
                continue
            time.sleep(0.7)
            after = call(inst, "/combat/hand")
            if len(after["hand"]) < before or _energy(after) < _energy(hand):
                played.append(c.get("title") or c["card"])
                progressed = True
                break
        if not progressed:
            break
        if not (call(inst, "/state").get("combat") or {}).get("in_progress"):
            return {"played": played, "master": master_ops, "ended": True}
    try:
        call(inst, "/combat/end_turn")
    except ToolError:
        pass
    return {"played": played, "master": master_ops, "ended": False}


def autoplay_battle(args: dict) -> dict:
    """自动打完一整场：每回合 autoplay_turn，直到战斗结束（赢或玩家倒下）或超过回合上限。"""
    inst = args.get("instance") or (climber_instances() or [None])[0]
    host = args.get("host") or host_instance()
    policy = args.get("policy", "attack")
    master_policy = args.get("master_policy", "greedy")
    turns = []
    t0 = time.time()
    for turn in range(args.get("max_turns", 30)):
        state = call(inst, "/state")
        if not (state.get("combat") or {}).get("in_progress"):
            break
        try:
            turn_no = call(inst, "/combat/hand").get("turn")
        except ToolError:
            turn_no = None
        turns.append(autoplay_turn(inst, policy, host, master_policy))
        # 等敌人回合结束、下一个玩家回合开始（回合数变了）或战斗结束
        for _ in range(80):
            time.sleep(0.5)
            st = call(inst, "/state")
            if not (st.get("combat") or {}).get("in_progress"):
                break
            try:
                if call(inst, "/combat/hand").get("turn") != turn_no:
                    break
            except ToolError:
                break
    end = call(inst, "/state")
    me = next((p for p in end.get("players") or [] if not p.get("is_master")), {})
    return {"turns": len(turns), "result": "lost" if me.get("alive") is False else "won_or_running",
            "hp": me.get("hp"), "detail": turns, "s": round(time.time() - t0, 1)}


def bench(instance: str, route: str, n: int) -> dict:
    times = []
    for _ in range(n):
        s = time.perf_counter()
        r = call(instance, route)
        times.append((time.perf_counter() - s) * 1000)
    times.sort()
    return {
        "route": route,
        "n": n,
        "p50_ms": round(statistics.median(times), 1),
        "p95_ms": round(times[int(len(times) * 0.95) - 1], 1),
        "max_ms": round(times[-1], 1),
    }


# ---------------------------------------------------------------- 工具表

S = {"type": "string"}
I = {"type": "integer"}
B = {"type": "boolean"}
INST = {"instance": {"type": "string", "description": "实例名（instances.json 里的键，如 A、B）"}}


def tool(name: str, description: str, props: dict, required: list[str], fn: Callable[[dict], Any]) -> dict:
    return {"name": name, "description": description, "props": props, "required": required, "fn": fn}


def host_or(args: dict) -> str:
    return args.get("instance") or host_instance()


TOOLS = [
    tool("tm_instances", "列出所有实例：连接、NetId、是否房主、mod 版本、日志路径。先调这个确认身份。", {}, [],
         lambda a: {name: _ping_safe(name) for name in load_instances()}),
    tool("tm_state", "读一个实例的状态：种子、幕、楼层、坐标、房间、玩家血量金币、战斗中的怪、召唤点、召唤面板是否打开。", INST, ["instance"],
         lambda a: call(a["instance"], "/state")),
    tool("tm_summon", "读塔主召唤面板：可选怪物（编号、价格、幕、精英、血量倍数）、候选 Boss、当前选择和报价。不填 instance 自动找房主。", INST, [],
         lambda a: call(host_or(a), "/summon")),
    tool("tm_summon_select", "设置召唤选择（整份替换，重复调用不叠加）。encounter 只在 Boss 房用。返回报价和能否确认。",
         {**INST, "encounter": S, "monsters": {"type": "array", "items": S}, "traps": {"type": "array", "items": I, "description": "要盖的陷阱：手里的序号（见 tm_summon 的 traps）"}}, ["monsters"],
         lambda a: call(host_or(a), "/summon/select", {"encounter": a.get("encounter"), "monsters": a["monsters"], "traps": a.get("traps") or []})),
    tool("tm_summon_confirm", "确认召唤（不合规则时报 rejected_rule）。返回扣点前后。", INST, [],
         lambda a: call(host_or(a), "/summon/confirm")),
    tool("tm_summon_vanilla", "塔主按原版出场（手动回退，扣标准开销）。", INST, [],
         lambda a: call(host_or(a), "/summon/vanilla")),
    tool("tm_map_options", "当前地图点和下一步能去的点（坐标、类型）。", INST, ["instance"],
         lambda a: call(a["instance"], "/map/options")),
    tool("tm_map_vote", "本机玩家投票去某个地图点（和点地图一样入队联机投票）。塔主默认拒绝，force=true 用来测拦截。",
         {**INST, "col": I, "row": I, "force": B}, ["instance", "col", "row"],
         lambda a: call(a["instance"], "/map/vote", {"col": a["col"], "row": a["row"], "force": a.get("force", False)})),
    tool("tm_rewards_skip", "本机玩家跳过当前显示的奖励组。", INST, ["instance"],
         lambda a: call(a["instance"], "/rewards/skip")),
    tool("tm_rewards", "读本机正在显示的奖励组：每项类型、金币数、遗物。没显示时 visible=false。", INST, ["instance"],
         lambda a: call(a["instance"], "/rewards")),
    tool("tm_rewards_proceed", "按奖励界面的「继续」（Boss 奖励后换幕也用这个）。", INST, ["instance"],
         lambda a: call(a["instance"], "/rewards/proceed")),
    tool("tm_treasure", "宝箱状态：宝箱里的遗物（序号、类型）、各玩家投票、本机玩家现有遗物（领取前后对比）。", INST, ["instance"],
         lambda a: call(a["instance"], "/treasure")),
    tool("tm_treasure_open", "本机玩家点开宝箱（塔主那边会自动开，不要对塔主用）。", INST, ["instance"],
         lambda a: call(a["instance"], "/treasure/open")),
    tool("tm_treasure_pick", "本机玩家选宝箱第 index 个遗物；不给 index 表示跳过。", {**INST, "index": I}, ["instance"],
         lambda a: call(a["instance"], "/treasure/pick", {"index": a.get("index")})),
    tool("tm_event", "列出当前事件（含先古之民）的选项按钮：序号、文字、是否禁用。", INST, ["instance"],
         lambda a: call(a["instance"], "/event")),
    tool("tm_event_choose", "点第 index 个事件选项（和鼠标点一样）。", {**INST, "index": I}, ["instance", "index"],
         lambda a: call(a["instance"], "/event/choose", {"index": a["index"]})),
    tool("tm_cards", "读正在显示的选牌界面（升级、删牌等）：界面类型、每张牌的序号和类型。", INST, ["instance"],
         lambda a: call(a["instance"], "/cards")),
    tool("tm_cards_pick", "在选牌界面点第 index 张牌（和鼠标点一样）；confirm=true 再按确认。", {**INST, "index": I, "confirm": B}, ["instance", "index"],
         lambda a: call(a["instance"], "/cards/pick", {"index": a["index"], "confirm": a.get("confirm", False)})),
    tool("tm_hand", "本机玩家手牌（序号、类型、标题、目标类型、费用）、能量、回合数、怪物下标，以及是否正被塔主回合暂停。", INST, ["instance"],
         lambda a: call(a["instance"], "/combat/hand")),
    tool("tm_play", "本机玩家打出第 index 张手牌（入队原版 PlayCardAction）；单体攻击牌可给 target（怪物下标，不给就打第一只活着的怪），其他牌的目标按牌的类型自动处理。只代表入队，用 tm_hand 看是否打出。",
         {**INST, "index": I, "target": I}, ["instance", "index"],
         lambda a: call(a["instance"], "/combat/play", {k: a[k] for k in ("index", "target") if k in a})),
    tool("tm_end_turn", "本机玩家结束回合（入队原版 EndPlayerTurnAction）。", INST, ["instance"],
         lambda a: call(a["instance"], "/combat/end_turn")),
    tool("tm_master_deck", "塔主牌（master_cards 开着时）：是否注册、类型数，以及每名玩家牌组里的卡（类型、标题、塔主牌 key）。", INST, [],
         lambda a: call(host_or(a), "/master/deck")),
    tool("tm_master_hand", "塔主战斗中的手牌（塔主牌模式）：是否塔主回合、能量、每张牌（序号、标题、目标类型、能不能打及原因）、抽牌/弃牌堆张数。", INST, [],
         lambda a: call(host_or(a), "/master/hand")),
    tool("tm_master_play", "塔主打出手牌第 index 张（等同原版拖牌，走 TryManualPlay）：给怪用 monster=敌人下标，给玩家用 player=联机 id。",
         {**INST, "index": I, "monster": I, "player": I}, ["index"],
         lambda a: call(host_or(a), "/master/play", {k: a[k] for k in ("index", "monster", "player") if a.get(k) is not None})),
    tool("tm_traps", "塔主陷阱：手里的陷阱（序号、名字、说明）、本场盖下/没触发的、待选的陷阱包。", INST, [],
         lambda a: call(host_or(a), "/traps")),
    tool("tm_trap_draft", "每幕开头挑陷阱：picks 给候选序号（见 tm_traps 的 draft.offer）；不给就按顺序在预算内自动挑。会确认。", {**INST, "picks": {"type": "array", "items": I}}, [],
         lambda a: draft(host_or(a), a.get("picks"))),
    tool("tm_threat_ui", "塔主回合界面：select=行动卡操作名（显示战场目标按钮，截图用）；不给就取消选择。", {**INST, "select": S}, [],
         lambda a: call(host_or(a), "/threat/ui", {"select": a.get("select")})),
    tool("tm_autoplay", "自动打完一整场（平衡测试用的固定基准机器人）：policy=attack|block（爬塔玩家出牌顺序），master_policy=none|greedy|debuff（塔主回合花威胁点的策略）。返回回合数、结果、每回合出的牌和塔主操作。",
         {**INST, "host": S, "policy": S, "master_policy": S, "max_turns": I}, [],
         autoplay_battle),
    tool("tm_balance", "读塔主的平衡记录（每场战斗一行），按幕和房间汇总：场数、胜场、平均掉血、回合数、花费、威胁点、陷阱、击倒、召唤点曲线。", INST, [],
         lambda a: balance_summary(host_or(a))),
    tool("tm_threat", "塔主回合状态（塔主实例）：是否进行中、第几回合、威胁点、剩余秒数、活着的怪（下标、血、格挡、力量、剩余回血次数）、玩家（血、手牌、状态）。", INST, [],
         lambda a: call(host_or(a), "/threat")),
    tool("tm_threat_act", "塔主回合操作：op=block/heal/strength（给 monster 下标）、strength_all、weak/vulnerable/frail/dazed（给 player 联机 id）。不合规则返回 rejected_rule。",
         {**INST, "op": S, "monster": I, "player": I}, ["op"],
         lambda a: call(host_or(a), "/threat/act", {k: a[k] for k in ("op", "monster", "player") if k in a})),
    tool("tm_threat_end", "结束塔主回合，玩家恢复出牌。", INST, [],
         lambda a: call(host_or(a), "/threat/end")),
    tool("tm_console", "执行开发者控制台命令（例如 win），走原版控制台提交。", {**INST, "command": S}, ["instance", "command"],
         lambda a: call(a["instance"], "/console", {"command": a["command"]})),
    tool("tm_logs", "按游标读日志增量。source=mod（TowerMaster 日志）或 game（游戏日志，需启动脚本设 TOWERMASTER_GAME_LOG）。返回新游标。",
         {**INST, "source": S, "cursor": I, "max_bytes": I}, ["instance"],
         lambda a: call(a["instance"], "/logs", {k: a[k] for k in ("source", "cursor", "max_bytes") if k in a})),
    tool("tm_screenshot", "截这个实例当前画面，存成 PNG，返回路径、尺寸、窗口模式。", {**INST, "name": S}, ["instance"],
         lambda a: call(a["instance"], "/screenshot", {"name": a.get("name")} if a.get("name") else {})),
    tool("tm_tree", "列场景树节点（路径、类型、可见、文字），contains 按类型名或节点名过滤。给知道游戏源码的助手找按钮用。",
         {**INST, "contains": S, "visible_only": B, "max": I, "root": S}, ["instance"],
         lambda a: call(a["instance"], "/tree", {k: a[k] for k in ("contains", "visible_only", "max", "root") if k in a})),
    tool("tm_node_call", "调用场景树节点上的方法（可私有）。args 见 README（数字/字符串/枚举名/{ref}/{new}）。",
         {**INST, "path": S, "method": S, "args": {"type": "array"}, "await": B, "depth": I}, ["instance", "path", "method"],
         lambda a: call(a["instance"], "/node/call", {k: a[k] for k in ("path", "method", "args", "await", "depth") if k in a})),
    tool("tm_reflect", "反射读对象或调方法：target 以 run/state/combat/node:路径/type:类型名 开头，用 .成员 [下标] 往下走。没有 method 就读值。",
         {**INST, "target": S, "method": S, "args": {"type": "array"}, "await": B, "depth": I}, ["instance", "target"],
         lambda a: call(a["instance"], "/reflect", {k: a[k] for k in ("target", "method", "args", "await", "depth") if k in a})),
    tool("tm_wait", "等一个实例满足条件：summon_open、in_combat、master_turn_open、paused_by_master_turn、draft_open、summon_or_draft、rewards_visible、room、point_type、total_floor_at_least、in_run、log_contains（可配 source）。超时返回最后状态。",
         {**INST, "condition": {"type": "object"}, "timeout_s": {"type": "number"}}, ["instance", "condition"],
         lambda a: wait_for(a["instance"], a["condition"], a.get("timeout_s", 30))),
    tool("tm_compare_logs", "对比各实例 TowerMaster 日志里清单、替换、生成、降血相关的行（去掉时间戳），列出差异。",
         {"instances": {"type": "array", "items": S}, "keywords": {"type": "array", "items": S}}, [],
         lambda a: compare_logs(a.get("instances") or list(load_instances()), a.get("keywords") or COMPARE_KEYWORDS)),
    tool("tm_bench", "测接口延迟：连续调 n 次，给 p50/p95/最大毫秒。route 默认 /state。",
         {**INST, "route": S, "n": I}, ["instance"],
         lambda a: bench(a["instance"], a.get("route", "/state"), a.get("n", 100))),
    tool("tm_battle", "一键跑一场：爬塔玩家选路（col/row 或 point_type 取第一个）→ 塔主选怪（monsters/encounter，或 vanilla=true）→ 截图 → 确认 → 两端对比怪物 → win → 召唤点前后 → 日志对比。失败时返回失败的步骤。",
         {"host": S, "climber": S, "col": I, "row": I, "point_type": S, "monsters": {"type": "array", "items": S}, "encounter": S,
          "vanilla": B, "win": B, "autoplay": B, "policy": S, "master_policy": S, "draft": {"type": "array", "items": I, "description": "本幕第一次召唤前挑陷阱的候选序号；不给就自动挑"}, "traps": {"type": "array", "items": I}, "read_rewards": B, "threat": {"type": "array", "items": {"type": "object"}, "description": "第一回合塔主回合里依次执行的操作，如 [{\"op\":\"block\",\"monster\":0}]；做完自动结束塔主回合"}, "skip_rewards": B, "screenshot": B, "screenshot_prefix": S, "timeout_s": {"type": "number"}, "settle_s": {"type": "number"}}, [],
         run_battle),
]


def _ping_safe(name: str) -> dict:
    try:
        return {"connected": True, **call(name, "/ping", timeout=5)}
    except ToolError as e:
        return {"connected": False, "error": str(e)}


def tool_list() -> list[dict]:
    return [{"name": t["name"], "description": t["description"],
             "inputSchema": {"type": "object", "properties": t["props"], "required": t["required"]}} for t in TOOLS]


def run_tool(name: str, args: dict) -> Any:
    for t in TOOLS:
        if t["name"] == name:
            return t["fn"](args or {})
    raise ToolError(f"没有工具 {name}")


# ---------------------------------------------------------------- MCP（stdio，按行 JSON-RPC）


def serve() -> None:
    for line in sys.stdin:
        line = line.strip()
        if not line:
            continue
        try:
            msg = json.loads(line)
        except json.JSONDecodeError:
            continue
        mid = msg.get("id")
        method = msg.get("method")
        if mid is None:  # 通知
            continue
        try:
            if method == "initialize":
                result = {
                    "protocolVersion": (msg.get("params") or {}).get("protocolVersion", "2024-11-05"),
                    "capabilities": {"tools": {}},
                    "serverInfo": {"name": "towermaster-test", "version": "0.1.0"},
                }
            elif method == "ping":
                result = {}
            elif method == "tools/list":
                result = {"tools": tool_list()}
            elif method == "tools/call":
                params = msg.get("params") or {}
                try:
                    value = run_tool(params.get("name"), params.get("arguments") or {})
                    result = {"content": [{"type": "text", "text": json.dumps(value, ensure_ascii=False, indent=1)}], "isError": False}
                except ToolError as e:
                    result = {"content": [{"type": "text", "text": str(e)}], "isError": True}
            else:
                send({"jsonrpc": "2.0", "id": mid, "error": {"code": -32601, "message": f"不支持 {method}"}})
                continue
            send({"jsonrpc": "2.0", "id": mid, "result": result})
        except Exception as e:  # 工具里的意外错误也要回给客户端，不能让服务退出
            send({"jsonrpc": "2.0", "id": mid, "error": {"code": -32000, "message": f"{type(e).__name__}: {e}"}})


def send(obj: dict) -> None:
    sys.stdout.write(json.dumps(obj, ensure_ascii=False) + "\n")
    sys.stdout.flush()


def main(argv: list[str]) -> int:
    if len(argv) <= 1:
        serve()
        return 0
    if argv[1] == "list":
        for t in tool_list():
            print(f"{t['name']}: {t['description']}")
        return 0
    if argv[1] == "call" and len(argv) >= 3:
        args = json.loads(argv[3]) if len(argv) > 3 else {}
        try:
            print(json.dumps(run_tool(argv[2], args), ensure_ascii=False, indent=1))
            return 0
        except ToolError as e:
            print(f"错误：{e}", file=sys.stderr)
            return 1
    print(__doc__)
    return 2


if __name__ == "__main__":
    if hasattr(sys.stdout, "reconfigure"):
        sys.stdout.reconfigure(encoding="utf-8")
        sys.stdin.reconfigure(encoding="utf-8")
    sys.exit(main(sys.argv))
