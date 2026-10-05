"""Hand-checked combat facts for every monster that appears in a vanilla act (v0.111.0, Ascension 0).

Read from decompiled/sts2/MegaCrit.Sts2.Core.Models.Monsters/<Class>.cs plus the powers they apply.
Fields
  role     普通 / 精英 / Boss / 召唤物 (spawned by another monster, not placed by an encounter)
  order    intent order as the state machine runs it (first move first)
  effects  what the non-damage parts do
  dmg      intent damage on the monster's first three turns, multi-hits summed, own strength
           gains from earlier turns included (that is what the intent number shows), random
           branches replaced by their expected value. Status/debuff damage is NOT included.
  ehp      extra effective HP on top of average max HP (revives, splits, damage caps, block…)
  mech     mechanic points per design.md: str(力量成长) summon(召唤) status(塞废牌)
           debuff(减益) artifact(人工制品) other(其他特殊机制); each 1–3
Summons are priced as if placed directly (they act from turn 1).
"""

M = {}


def m(cls, role, order, effects, dmg, dmg_note="", ehp=0, ehp_note="", mech_note="", **mech):
    M[cls] = dict(role=role, order=order, effects=effects, dmg=dmg, dmg_note=dmg_note,
                  ehp=ehp, ehp_note=ehp_note, mech=mech, mech_note=mech_note)


# ---------------------------------------------------------------- Act 1 · Overgrowth (密林)
m("BygoneEffigy", "精英", "沉睡 → 苏醒(+10力量) → 斩击13 循环",
  "自带缓慢：每层使其受到的攻击伤害+10%", [0, 0, 23], "第3回合斩击13+10力量",
  ehp=-30, ehp_note="缓慢使其越打越脆，约折-25%", str=3, mech_note="苏醒一次+10力量")
m("Byrdonis", "精英", "飞扑17 ↔ 啄击3×3",
  "领地意识：每个敌方回合结束+1力量", [17, 12, 19], "力量每回合+1",
  str=2, mech_note="每回合+1力量")
m("PhrogParasite", "精英", "感染(3张感染) ↔ 甩动4×4",
  "死亡时召唤4只扭动虫（首回合眩晕）", [0, 16, 0],
  ehp=76, ehp_note="死后分裂出4只扭动虫（平均19血）", summon=2, status=2,
  mech_note="死亡召唤4只；每2回合塞3张感染")
m("Wriggler", "召唤物", "污秽啃咬6 ↔ 扭动(1张感染,+2力量)；按位置交替起手",
  "由异蛙寄生虫死亡生成，生成当回合眩晕", [6, 0, 8], "按起手啃咬计；另一半起手扭动",
  status=1, str=1)
m("CeremonialBeast", "Boss", "跺地(获得横冲150) → 横冲直撞18(+2力量)循环；血量≤150时眩晕并失去力量 → 野兽咆哮(耳鸣) → 踩踏15 → 碾碎17(+3力量)循环",
  "横冲阈值随人数缩放；耳鸣：每回合只能打出一张受影响的牌", [0, 18, 20],
  str=2, debuff=2, mech_note="横冲期持续涨力量；二阶段耳鸣")
m("CubexConstruct", "普通", "蓄能(+2力量) → 重复轰击7(+2力量) → 重复轰击7(+2) → 排出5×2 → 回到重复轰击",
  "开场13格挡、1层人工制品", [0, 9, 11], ehp=13, ehp_note="开场13格挡",
  str=3, artifact=1, mech_note="几乎每回合+2力量；1层人工制品")
m("Flyconid", "普通", "首回合随机：脆弱孢子8(+2脆弱)[权重2]/猛砸11；之后随机：易伤孢子(2易伤)[3]/脆弱孢子[2]/猛砸[1]，不可连用",
  "施加易伤、脆弱", [9, 3, 4], "随机分支取期望", debuff=2)
m("Fogmog", "普通", "虚幻孢子(召唤利齿之眼) → 重击8(+1力量) → 40%重击/60%头槌14 → …",
  "召唤的利齿之眼每回合塞3张晕眩，死亡后会复活", [0, 8, 13], "第3回合取期望",
  summon=2, str=1, mech_note="召唤会复活的利齿之眼")
m("EyeWithTeeth", "召唤物", "牵制(3张晕眩) 循环", "幻象：被击杀后下回合回满复活；随从", [0, 0, 0],
  status=2)
m("FuzzyWurmCrawler", "普通", "酸液黏球4 → 吸入(+7力量) → 酸液黏球 → …", "", [4, 0, 11],
  str=3, mech_note="每3回合+7力量")
m("Inklet", "普通", "两侧：刺击3 → 随机(锐利凝视10/旋风2×3) → 刺击…；中间：旋风起手",
  "滑溜1：第1次受到的伤害降为1（随人数缩放）", [3, 7, 5], "两侧与中间位置取平均",
  ehp=5, ehp_note="滑溜吃掉第一下伤害")
m("Mawler", "普通", "爪击4×2 → 随机(狂乱撕扯14 / 怒吼(3易伤,只用一次) / 爪击，不可连用)",
  "施加3层易伤", [8, 7, 8], "随机取期望", debuff=2)
m("Nibbit", "普通", "单只：顶撞12 → 切割6(+5格挡) → 哈气(+2力量)；成对时前排切割起手、后排哈气起手",
  "", [12, 6, 2], "单只/前排/后排平均约20", str=1)
m("LeafSlimeS", "普通", "冲撞3 / 黏液(1张黏液) 随机交替", "", [2, 1, 2], "随机交替取期望", status=1)
m("TwigSlimeS", "普通", "冲撞4 循环", "", [4, 4, 4])
m("LeafSlimeM", "普通", "黏糊射击(2张黏液) ↔ 团块射击8", "", [0, 8, 0], status=2)
m("TwigSlimeM", "普通", "黏糊射击(1张黏液) → 随机(戳刺扑击11 / 黏糊射击，后者不可连用)", "", [0, 11, 6],
  status=1)
m("ShrinkerBeetle", "普通", "缩小 → 大啃7 → 践踏13 → 大啃…",
  "缩小：目标攻击伤害-30%，持续到甲虫死亡", [0, 7, 13], debuff=3, mech_note="永久-30%攻击伤害")
m("SlitheringStrangler", "普通", "缠身(3层缠身) → 随机(重击7+5格挡 / 甩动12) → 缠身…",
  "缠身：玩家每回合结束受3点伤害，直到扼杀者死亡", [0, 10, 0], "缠身伤害不计入意图", debuff=2)
m("SnappingJaxfruit", "普通", "能量球3(+2力量) 循环", "", [3, 5, 7], str=2)
m("VineShambler", "普通", "挥击6×2 → 紧绕藤蔓8(纠缠) → 大啃16 → …",
  "纠缠：本回合攻击牌费用+1", [12, 8, 16], debuff=2)
m("AssassinRubyRaider", "普通", "致命射击10 循环", "", [10, 10, 10])
m("AxeRubyRaider", "普通", "挥砍5(+5格挡) → 挥砍5(+5格挡) → 大力挥舞12", "", [5, 5, 12], ehp=5,
  ehp_note="格挡")
m("BruteRubyRaider", "普通", "殴打7 ↔ 怒吼(+3力量)", "", [7, 0, 10], str=2)
m("CrossbowRubyRaider", "普通", "装填(3格挡) ↔ 射击14", "", [0, 14, 0])
m("TrackerRubyRaider", "普通", "追踪(2脆弱) → 放狗1×8 循环", "", [0, 8, 8], debuff=1)
m("KinFollower", "Boss", "快斩5 → 回旋镖2×2 → 力量之舞(+2力量)；一只以力量之舞起手",
  "随从", [4, 4, 4], "两种起手平均约12", str=1)
m("KinPriest", "Boss", "脆弱法球8(1脆弱) → 虚弱法球8(1虚弱) → 灵魂光束3×3 → 黑暗仪式(+2力量)",
  "", [8, 8, 9], debuff=1, str=1)
m("Vantom", "Boss", "墨迹7 → 墨水长枪6×2 → 肢解26(3张伤口) → 准备(+2力量) 循环",
  "滑溜8：前8次受伤都降为1（随人数缩放）", [7, 12, 26],
  ehp=48, ehp_note="滑溜8次约挡48伤害", status=2, str=1)

# ---------------------------------------------------------------- Act 1 · Underdocks (暗港)
m("CorpseSlug", "普通", "鞭打3×2 → 扑上8 → 黏液(2脆弱)，同组错开起手",
  "贪食4：队友死亡时自身眩晕一回合并+4力量", [6, 8, 0], "三种起手的3回合总和相同(14)",
  debuff=1, str=1)
m("CalcifiedCultist", "普通", "念咒(仪式2) → 黑暗打击9 循环", "仪式：施加后的下一个回合起每回合末+2力量",
  [0, 9, 11], str=3)
m("DampCultist", "普通", "念咒(仪式5) → 黑暗打击1 循环", "仪式5", [0, 1, 6], str=3)
m("FossilStalker", "普通", "缠上12起手，之后随机(冲撞9+1脆弱 / 缠上12 / 甩动3×2)",
  "吸取3：每次攻击造成伤害后+3力量（多段按段计）", [12, 13, 15], "假设约半数攻击被格挡",
  str=3, debuff=1)
m("GremlinMerc", "普通", "拿来7×2 → 双重猛击6×2(2虚弱) → 嘿嘿8(+2力量)",
  "偷窃：每次出手偷每名玩家最多20金；死亡后召唤卑鄙地精与胖地精", [14, 12, 8],
  ehp=12, ehp_note="死后出现卑鄙地精(12血)", summon=2, debuff=1, other=1,
  mech_note="偷金币；死后召唤")
m("SneakyGremlin", "召唤物", "醒来(眩晕) → 冲撞9 循环", "", [0, 9, 9])
m("FatGremlin", "召唤物", "醒来(眩晕) → 逃跑", "带着偷走的金币逃跑", [0, 0, 0], other=1)
m("HauntedShip", "普通", "纠缠(3虚弱+5张晕眩) → 扫击13 → 践踏4×3 → 扫击…", "", [0, 13, 12],
  debuff=2, status=2)
m("LivingFog", "普通", "先进毒气8(雾霾) → 膨胀5(召唤气态炸弹) → 超级毒气爆炸8 → 膨胀…",
  "雾霾：打出技能后其余技能被雾化无法打出", [8, 5, 8], summon=2, debuff=2)
m("GasBomb", "召唤物", "爆炸8后自毁", "随从", [8, 0, 0])
m("PunchConstruct", "普通", "准备就绪(10格挡) → 快速拳5×2(1脆弱) → 强力拳14 → …", "1层人工制品",
  [0, 10, 14], ehp=10, ehp_note="10格挡", artifact=1, debuff=1)
m("Seapunk", "普通", "海洋踢11 → 回旋踢2×4 → 吐泡泡(7格挡+1力量)", "", [11, 8, 0], ehp=7,
  ehp_note="格挡", str=1)
m("SewerClam", "普通", "喷射10 ↔ 增压(+4力量)", "镀层8（每回合末获得格挡，逐回合-1）", [10, 0, 14],
  ehp=21, ehp_note="镀层8+7+6", str=2)
m("SludgeSpinner", "普通", "喷油8(1虚弱)起手，之后随机(喷油/砸击11/狂怒6+3力量，不可连用)", "",
  [8, 9, 10], "随机取期望", debuff=1, str=1)
m("Toadpole", "普通", "前排：带刺(+2荆棘) → 吐刺3×3 → 旋转7；后排：旋转起手", "荆棘2", [0, 9, 7],
  other=1)
m("TwoTailedRat", "普通", "随机(抓挠8 / 疾病啃咬6 / 尖声嘶吼1脆弱 / 呼唤后援)，两回合后75%呼唤后援",
  "呼唤后援：再召唤一只双尾鼠（全组最多3次）", [5, 5, 2], "随机取期望", summon=2, debuff=1)
m("SkulkingColony", "精英", "猛冲14 → 猛冲14 → 惯性9(+2力量) → 穿刺戳击7×2 → …",
  "硬化外壳20：每回合最多失去20血（随人数缩放）", [14, 14, 9],
  ehp=37, ehp_note="每回合最多掉20血，按第一幕约30伤害/回合折算×1.5", str=1)
m("TerrorEel", "精英", "撞击16 ↔ 撕扯3×3(+6活力)；血量≤70时眩晕一回合 → 恐吓(99层易伤)",
  "尖啸70：半血触发；之后玩家永久易伤", [16, 9, 22], "活力6加到下一次撞击",
  debuff=2, str=1, mech_note="半血后99易伤，但先自晕一回合")
m("PhantasmalGardener", "精英", "啃咬5 → 甩动7 → 猛晃1×3 → 变大(+2力量)，4只按位置错开起手",
  "易惊6：每回合首次受击获得6格挡（随人数缩放）", [5, 4, 4], "4个起手平均约13",
  ehp=12, ehp_note="易惊格挡约2次", str=1)
m("WaterfallGiant", "Boss", "增压(蒸汽喷发15) → 践踏15(1虚弱) → 撞击10 → 虹吸(回10血/人) → 压力枪20(每次+5) → 增压冲击13 → 践踏…",
  "每个动作+3蒸汽；死亡后进入引爆状态，下回合造成等于蒸汽层数的伤害", [0, 15, 10],
  ehp=10, ehp_note="虹吸回血", debuff=1, other=3, mech_note="死后爆炸")
m("SoulFysh", "Boss", "呼唤(2张召唤牌) → 排气16 → 凝视7(+1召唤牌) → 消逝(2层无实体) → 尖叫13(3易伤) → …",
  "", [0, 16, 7], ehp=40, ehp_note="无实体2回合", status=3, debuff=2)
m("LagavulinMatriarch", "Boss", "沉睡(最多3回合，受伤即醒并晕一回合) → 斩击19 → 开膛破肚9×2 → 斩击12(+12格挡) → 灵魂汲取(-2力量-2敏捷，自身+2力量)",
  "沉睡时镀层12", [0, 0, 19], "假设第1回合就被打醒", ehp=12, ehp_note="镀层12",
  debuff=3, str=1, mech_note="永久偷力量和敏捷")

# ---------------------------------------------------------------- Act 2 · Hive (蜂巢)
m("BowlbugEgg", "普通", "啃咬7(+7格挡) 循环", "", [7, 7, 7], ehp=7, ehp_note="格挡")
m("BowlbugNectar", "普通", "撕扯3 → 强化(+15力量) → 撕扯 循环", "", [3, 0, 18], str=3)
m("BowlbugRock", "普通", "头槌15 循环", "失衡：攻击被完全格挡时自身眩晕", [15, 15, 15])
m("BowlbugSilk", "普通", "毒性喷吐(1虚弱) ↔ 撕扯4×2", "", [0, 8, 0], debuff=1)
m("Chomper", "普通", "猛夹8×2 ↔ 尖锐鸣叫(3张晕眩)，同组一只先鸣叫", "2层人工制品", [8, 8, 8],
  "两种起手平均", artifact=2, status=2)
m("DecimillipedeSegment", "精英", "紧缠8(1虚弱) → 胀大6(+2力量) → 扭动5×2 循环，3节错开起手",
  "接续25：被击杀后只要还有别的节活着，下回合回25血复活；三节都死才结束", [8, 8, 10],
  "三种起手平均约26", ehp=17, ehp_note="通常先死的两节各复活一次(25)，摊到每节", str=1, debuff=1)
m("Entomancer", "精英", "蜜蜂3×7 → 矛击18 → 喷射信息素(蜂巢+1、+1力量) → …",
  "私人蜂巢：每次被攻击，往攻击者抽牌堆塞晕眩", [21, 18, 0], status=2, str=1)
m("Exoskeleton", "普通", "按位置：忙乱1×3 / 啃食8 / 激怒(+2力量) / 随机起手，之后随机",
  "坚不可摧9：单次受到伤害最多9", [5, 5, 4], "4个位置平均约14",
  ehp=8, ehp_note="单次伤害上限9，约+30%", str=1)
m("HunterKiller", "普通", "嫩化黏液(嫩化) → 随机(啃咬17 / 刺穿7×3)",
  "嫩化：每打出一张牌本回合-1力量-1敏捷", [0, 19, 20], debuff=2)
m("InfestedPrism", "精英", "刺击15 → 辐射11(+11格挡) → 旋风5×3 → 脉动8(+20格挡,+火花)",
  "生命火花2：玩家技能牌被污染，打出后受到的攻击伤害+2", [15, 11, 15],
  ehp=11, ehp_note="格挡", debuff=2)
m("LouseProgenitor", "普通", "吐网炮9(2脆弱) → 蜷身成长(14格挡,+5力量) → 猛扑14 → …",
  "蜷缩14：首次被攻击后获得14格挡", [9, 0, 19], ehp=28, ehp_note="蜷缩14+成长格挡14",
  str=2, debuff=1)
m("Myte", "普通", "1号位：浓毒(2张毒素入手) → 啃咬13 → 吸吮4(+2力量)；2号位吸吮起手", "",
  [2, 7, 9], "两个位置平均约18", status=2, str=1)
m("Ovicopter", "普通", "产卵(3个结实的卵) → 猛砸16 → 嫩化7(2易伤) → 场上≤3只则再产卵，否则+3力量",
  "", [0, 16, 7], summon=3, debuff=1)
m("ToughEgg", "召唤物", "孵化 → 啃咬4 循环", "孵化后变为19~22血的幼体；随从", [0, 4, 4])
m("SlumberingBeetle", "普通", "打鼾(沉睡3) → 出击16(+2力量) 循环",
  "沉睡时镀层15；受3次伤害或3回合后醒来", [0, 0, 16], "假设被打醒", ehp=15,
  ehp_note="镀层15", str=2)
m("SpinyToad", "普通", "伸出尖刺(5荆棘) → 尖刺爆破23 → 吐舌17 → …", "", [0, 23, 17], other=1)
m("TheObscura", "普通", "幻象(召唤寄生惧魔) → 随机(锐利凝视10 / 起航:全体+3力量 / 硬化攻击6+6格挡)",
  "", [0, 5, 7], summon=3, str=1, mech_note="召唤会复活的寄生惧魔")
m("Parafright", "召唤物", "砸击16 循环", "幻象：被击杀后回满复活；随从", [16, 16, 16])
m("ThievingHopper", "普通", "偷盗17(偷一张牌) → 振翅(5层) → 帽子戏法21 → 抢夺14 → 逃跑",
  "振翅：受到的攻击伤害减半，被打5次后眩晕；5回合后逃跑，偷的牌就没了", [17, 0, 21],
  ehp=20, ehp_note="振翅减伤", other=2, mech_note="偷牌")
m("Tunneler", "普通", "啃咬13 → 钻洞(32格挡且保留) → 下方攻击23 循环；格挡被打破则眩晕", "",
  [13, 0, 23], ehp=32, ehp_note="钻洞格挡")
m("TheInsatiable", "Boss", "液化地面(流沙4 + 6张狂乱逃脱) → 撕扯8×2 → 前扑啃咬28 → 分泌唾液(+2力量) → 撕扯…",
  "流沙：倒计时结束会吞掉玩家", [0, 16, 28], status=3, other=2)
m("KnowledgeDemon", "Boss", "知识的诅咒(玩家二选一诅咒) → 抽打17 → 知识过载8×3 → 思考11(回30血/人,+2力量) → 前3次诅咒后不再诅咒",
  "", [0, 17, 24], ehp=30, ehp_note="思考回血", debuff=3, str=1)
m("Crusher", "Boss", "撕扯12 → 巨化打击4 → 虫蛰6×2(2虚弱2脆弱) → 适应(+2力量) → 戒备打击12(+18格挡)",
  "螃蟹之怒：另一只钳子死后获得力量和大量格挡", [12, 4, 12], debuff=2, str=1)
m("Rocket", "Boss", "瞄准十字3 → 精准光束18 → 蓄能(+2力量) → 激光31 → 重新充能",
  "包围：从背后受到的伤害×1.5", [3, 18, 0], str=1, other=1)

# ---------------------------------------------------------------- Act 3 · Glory (荣耀)
m("Axebot", "普通", "上勾锤击14(2虚弱2脆弱) ↔ 两连击10×2",
  "存货2：被击杀后原地重生两次(+10/+20最大生命)，重生体以启动(格挡+力量)起手", [14, 20, 14],
  ehp=178, ehp_note="重生两次：84+94", debuff=2, str=1)
m("DevotedSculptor", "普通", "禁忌唱诵(仪式9) → 猛烈攻击12 循环", "", [0, 12, 21], str=3)
m("Fabricator", "普通", "随机(组装:召唤1防御+1进攻机器人 / 组装打击18+召唤进攻机器人)；场上满4只则瓦解11",
  "", [9, 9, 9], "随机取期望", summon=3)
m("Zapbot", "召唤物", "电击14 循环", "高压2：每回合末+2力量；随从", [14, 16, 18], str=2)
m("Stabbot", "召唤物", "戳刺11(1脆弱) 循环", "随从", [11, 11, 11], debuff=1)
m("Guardbot", "召唤物", "守护：给组装师15格挡", "随从", [0, 0, 0], other=1)
m("Noisebot", "召唤物", "噪音(2张晕眩) 循环", "随从", [0, 0, 0], status=2)
m("FrogKnight", "普通", "吐舌13(2脆弱) → 惩恶一击21 → 为了女王(+5力量) → 吐舌…；半血以下改用甲虫冲锋35一次",
  "镀层15", [13, 21, 0], ehp=42, ehp_note="镀层15+14+13", str=2, debuff=1)
m("GlobeHead", "普通", "电击掌13(2脆弱) → 生成闪电6×3 → 电涌爆发16(+2力量)",
  "电流6：能力牌被附加电击，打出时自己受6伤害", [13, 18, 16], debuff=2, str=1)
m("OwlMagistrate", "普通", "法官审查16 → 猛啄袭击4×6 → 飞法行为(翱翔:受伤减半) → 裁决33(4易伤)", "",
  [16, 24, 0], ehp=25, ehp_note="翱翔一回合减伤", debuff=1)
m("ScrollOfBiting", "普通", "大啃14 → 更多牙齿(+2力量) → 咀嚼5×2 → 随机，3只错开起手",
  "纸割2：造成未格挡伤害时玩家失去2最大生命", [10, 8, 10], "三种起手平均约28",
  other=2, str=1)
m("SlimedBerserker", "普通", "喷吐脓水(10张黏液) → 狂怒连击4×4 → 汲取之拥(3虚弱,+3力量) → 窒息30 → …",
  "", [0, 16, 0], status=3, debuff=1, str=1)
m("TheLost", "普通", "致残雾霾(玩家-2力量,自身+2) ↔ 眼部激光4×2", "死亡时归还偷走的力量", [0, 12, 0],
  debuff=2, str=1)
m("TheForgotten", "普通", "瘴气(玩家-2敏捷,自身+2敏捷,8格挡) ↔ 恐惧13+敏捷", "死亡时归还偷走的敏捷",
  [0, 15, 0], ehp=16, ehp_note="瘴气格挡", debuff=2)
m("TurretOperator", "普通", "弹雨3×5 → 弹雨3×5 → 装弹(+1力量)", "", [15, 15, 0])
m("LivingShield", "普通", "盾击6（有队友时）；队友全死后改为砸击16(+3力量)",
  "壁垒25：每个玩家回合开始给高塔炮手25格挡", [6, 6, 6], ehp=50,
  ehp_note="壁垒替炮手挡约50伤害（计在盾上）", other=2)
m("FlailKnight", "精英", "撞击15起手，之后随机(战争吟唱+3力量 / 连枷9×2 / 撞击15)", "", [15, 11, 13],
  "随机取期望", str=1)
m("SpectralKnight", "精英", "恶咒(诅咒手牌:虚无) → 灵魂斩击15 → 随机(灵魂斩击 / 灵魂火焰3×3)",
  "恶咒：玩家的牌获得虚无", [0, 15, 12], debuff=2)
m("MagiKnight", "精英", "强力护盾6(+5格挡) → 抑制(降级已升级的牌) → 撞击10 → 准备(格挡) → 魔法炸弹35 → 撞击…",
  "", [6, 0, 10], ehp=5, ehp_note="格挡", debuff=2)
m("MechaKnight", "精英", "冲锋25 → 喷火器8(4张灼伤入手) → 举起蓄力(15格挡,+5力量) → 重斩35 → 喷火器…",
  "3层人工制品", [25, 8, 0], ehp=15, ehp_note="格挡", artifact=2, status=3, str=2)
m("SoulNexus", "精英", "灵魂灼烧29起手，之后随机(灵魂灼烧 / 大漩涡6×4 / 汲取生命18+2易伤2虚弱)，不可连用",
  "", [29, 21, 25], "随机取期望", debuff=2)
m("Queen", "Boss", "傀儡之线(束缚3) → 你是我的了(99脆弱/虚弱/易伤) → 为我尽力燃烧吧(聚合体+1力量,自身20格挡)直到聚合体死亡 → 将头砍下3×5 → 处决15 → 激怒(+2力量)",
  "束缚：每回合限制可打出的牌", [0, 0, 0], ehp=20, ehp_note="格挡", debuff=3, str=1)
m("TorchHeadAmalgam", "Boss", "强力冲撞26 → 冲撞18 → 光束8×3 → 冲撞14 → 冲撞14 → 光束…", "随从",
  [26, 18, 24])
m("TestSubject", "Boss", "噬咬20 ↔ 颅骨重击14(1易伤)；第一次死亡复活为200血，多次爪击10×(3,4,5…)；第二次复活300血：撕碎10×3 → 大扑击45 → 灼烧咆哮(3张灼伤,+2力量)",
  "激怒2：玩家每打出技能牌+2力量", [20, 14, 20], ehp=500, ehp_note="两次复活：200+300",
  str=3, debuff=1)
m("Aeonglass", "Boss", "消退22(+33格挡) → 眼部激光11×2 → 加大力度(凋零牌+3力量,每次+1) → …",
  "凋零存在：每名玩家每打6张牌获得一张凋零；3层人工制品", [22, 22, 0], ehp=33,
  ehp_note="格挡", artifact=2, str=2, status=2, debuff=1)

# Event-only / test / pet classes are deliberately left out of pricing:
EXCLUDED = {
    "Architect": "事件", "FakeMerchantMonster": "事件", "MysteriousKnight": "事件",
    "BattleFriendV1": "事件假人", "BattleFriendV2": "事件假人", "BattleFriendV3": "事件假人",
    "Byrdpip": "玩家宠物", "PaelsLegion": "玩家宠物", "Osty": "玩家宠物",
    "BigDummy": "测试", "OneHpMonster": "测试", "TenHpMonster": "测试", "DeprecatedMonster": "测试",
    "SingleAttackMoveMonster": "测试", "MultiAttackMoveMonster": "测试",
    "TheAdversaryMkOne": "未使用", "TheAdversaryMkTwo": "未使用", "TheAdversaryMkThree": "未使用",
    "DecimillipedeSegmentFront": "合并到DecimillipedeSegment",
    "DecimillipedeSegmentMiddle": "合并到DecimillipedeSegment",
    "DecimillipedeSegmentBack": "合并到DecimillipedeSegment",
}

# Which summons belong to which act pool (they never appear in an encounter's starting lineup).
SUMMON_ACTS = {
    "Wriggler": ["Overgrowth"], "EyeWithTeeth": ["Overgrowth"],
    "SneakyGremlin": ["Underdocks"], "FatGremlin": ["Underdocks"], "GasBomb": ["Underdocks"],
    "ToughEgg": ["Hive"], "Parafright": ["Hive"],
    "Zapbot": ["Glory"], "Stabbot": ["Glory"], "Guardbot": ["Glory"], "Noisebot": ["Glory"],
}
