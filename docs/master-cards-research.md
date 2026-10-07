# 塔主真实卡牌接口调研（v0.111.0，2026-10-07）

按 master-cards-plan.md 第4节逐项核对。仅转述逻辑、列签名与位置，未提交源码或资源；路径均相对仓库。以下是只读依据，不等于动态生成新卡已经实测成功。类型短名均属于 MegaCrit.Sts2.Core 对应目录命名空间；Godot 类型例外。

## 1. 注入、编号、初始化时机

- `Helpers.OneTimeInitialization.ExecuteVeryEarly(): Task` 在 OneTimeInitialization.cs:51 await `ModManager.Initialize(IModManagerFileIo, ModSettings?, SemanticVersion?)`；`ExecuteEssential(): void` 在:67–73依次本地化初始化、ModelDb.Init、ModelIdSerializationCache.Init、ModelDb.InitIds、消息/动作类型初始化。mod入口早于模型与联机编号缓存。
- `Models.ModelDb.Init(Type[]? injectedModelTypes=null): void`（ModelDb.cs:329）：不给参数枚举 AllAbstractModelSubtypes，公共无参构造生成规范模型。`Inject(Type): void`（:340）只在类型尚不存在时创建并加入内容字典；不会自动 InitId，不会更新联机编号/AllCards等缓存。`InitIds(): void`（:362）遍历字典给模型设置Id。
- `GetId(Type): ModelId`（:401）、`GetCategoryType(Type): Type`（:406）、`GetEntry(Type): string`（:421）：沿基类找到直接继承AbstractModel的模型类别，entry来自类型名Slugify。不能让不同mod的新类型同名造成ID冲突。
- `AllAbstractModelSubtypes`（:64–83）合并原版列表与 `ReflectionHelper.GetSubtypesInMods<AbstractModel>()`。ReflectionHelper.cs:32–46的ModTypes缓存枚举已加载mod的assemblies及GetTypes；:59–68过滤抽象类型。ModManager.cs:786–794扫描ModInitializerAttribute并调用入口，并没有另一个自动“加卡池”流程。
- 联机编号不是仅字符串：`Multiplayer.Serialization.ModelIdSerializationCache.Init(): void`（:59起）按内容排序生成category/entry数字映射、bit大小与Hash。晚Inject虽可进字典，但不会自动纳入该缓存。建议动态类型在正常ModelDb.Init之前生成并登记程序集；不能仅靠游戏启动后Inject就宣称支持联机。ReflectionHelper/ModelDb子类型缓存建立时机、动态程序集被GetTypes枚举与归属登记必须一起验证。

## 2. 卡牌构造、成员、本地化、变量

- `CardModel(int canonicalEnergyCost, CardType type, CardRarity rarity, TargetType targetType, bool shouldShowInCardLibrary=true)` protected构造，CardModel.cs:869。动态子类需public无参构造以满足ModelDb；CardModel没有abstract OnPlay，默认空操作，所以生成类型并不自动有功能。
- `protected virtual Task OnPlay(PlayerChoiceContext, CardPlay)`（:1335）实现效果；`protected virtual void OnUpgrade()`（:1345）升级；`protected virtual bool IsPlayable`（:662）可实现无目标的可用限制；`protected virtual IEnumerable<DynamicVar> CanonicalVars`（:459）定义数值。`ShouldReceiveCombatHooks`在基类卡牌已实现（:841），是否在战斗牌堆决定能否收到钩子。
- TitleLocString（:95）与Description（:114）键为cards/Id.Entry.title、cards/Id.Entry.description。Title可override，Description本身非virtual；不能只改界面Label就覆盖牌组、日志和提示。
- `LocManager.GetTable(string): LocTable`（Localization/LocManager.cs:423），`LocTable.MergeWith(Dictionary<string,string>): void`（LocTable.cs:23）是可用运行时合并接口，重复键覆盖。需在LocManager初始化后执行，并处理切语言重新加载（不是一次合并永久生效）。官方mod资源路径由`ModManager.GetModdedLocTables(string language,string file): IEnumerable<string>`（ModManager.cs:902）枚举res://modId/localization/language/file；LocManager.cs:408–417加载后MergeWith。无PCK的动态文本可合并，但需要语言变更时重加。
- `DynamicVarSet`及CardModel.DynamicVars（:445–459）由CanonicalVars创建；`GetDescriptionForPile(PileType,Creature?=null): string`（:1099，内部:1111–1114）把DynamicVars加到LocString，再格式化。数值应使用命名DynamicVar与描述占位，而不是把可升级数值硬写死在字符串里。具体实例：`Models.Cards.StrikeIronclad.CanonicalVars`（StrikeIronclad.cs:16）建立6点DamageVar；OnPlay（:26）读取DynamicVars.Damage.BaseValue，OnUpgrade（:33）UpgradeValueBy(3m)。`Localization.DynamicVars.DamageVar(decimal damage,ValueProp props)`（DamageVar.cs:18）默认变量名Damage，另有自定义名字构造（:24）。描述占位的中文表格式未在本轮提取验证，不猜具体占位语法。

## 3. 卡池、视觉和生成隔离

- `virtual CardPoolModel CardModel.Pool`（CardModel.cs:282–302）先查ModelDb.AllCardPools包含ID的池，再MockCardPool；都不在则InvalidProgramException。可以override返回自建池/指定池，但“返回无色池”不等于自动加入该池AllCards。
- `virtual CardPoolModel VisualCardPool`（:304）默认Pool，参与frame/energy icon/material（:240、:274）；逻辑卡池与视觉可分离。
- `CardPoolModel.GenerateAllCards(): CardModel[]` protected abstract（CardPoolModel.cs:53）；还需Title、EnergyColorName、CardFrameMaterialPath、DeckEntryCardColor、IsColorless（:18–49）；AllCards/AllCardIds有缓存，:55 InvalidateCardCache只针对该池。
- `ModelDb.AllCards`（ModelDb.cs:96）来自注册卡池和所有角色StartingDeck，不是字典内所有CardModel。AllSharedCardPools（:100）显式列出七个原版共享池，AllCharacters（:113）显式列出五个原版角色，AllCharacterCardPools（:111）取这五个角色的CardPool；单独Inject自建池不会自动加进上述列表。较安全方向是Pool/VisualCardPool显式指定，塔主卡不加入普通角色奖励/商店池，再定向加入塔主Deck。
- `CanBeGeneratedInCombat`、`CanBeGeneratedByModifiers`默认true（:528–530）；图鉴开关ShouldShowInCardLibrary为构造参数（:664、:875），不是禁生成开关。`Factories.CardFactory.FilterForCombat(IEnumerable<CardModel>): IEnumerable<CardModel>`（CardFactory.cs:117）过滤前者及Basic/Ancient/Event稀有度；`CreateForReward(Player,int,CardCreationOptions)`（:69）与`CreateForMerchant(Player,IEnumerable<CardModel>,CardType/CardRarity)`（:34/:56）从传入候选生成，不能假定两布尔能覆盖商店奖励。
- `GetDefaultTransformationOptions(CardModel,bool)`（:122）读取卡自己的Pool；`CardPoolModel.GetUnlockedCards(UnlockState,CardMultiplayerConstraint)`（:67）处理解锁及多人限制。普通奖励、商店、变化、战斗随机生成、修饰器都需逐路径隔离。是否在普通库出现与是否可在塔主牌组中看见是两件事。

## 4. 卡图与文件贴图

- `virtual string PortraitPath`（CardModel.cs:130）、`virtual string BetaPortraitPath`（:132）、`protected virtual string PortraitPngPath`（:136）；`Texture2D Portrait`（:144）是非virtual ResourceLoader.Load，HasPortrait（:140）通过ResourceLoader.Exists检查PNG路径。
- 默认卡图使用atlas的tres，不是任意Texture2D字段。不能override Portrait直接返回ImageTexture。外部art/*.png能否作为ResourceLoader可读路径、预加载与导入资源一致性尚未实测，不能保证直接绝对路径可用。
- 可选路线是正确资源路径/资源加载器，或在NCard设置模型后的贴图绑定挂点替换；后者仍需同步牌组、预览、图鉴等所有卡图展示。已找到 `Nodes.Cards.NCard.UpdatePortrait(): void` private（NCard.cs:916）：:920读取Model.Portrait，普通卡:923赋给%Portrait，古老卡:934赋给%AncientPortrait；`UpdateVisuals(PileType,CardPreviewMode): void`（:557/:569）会重新调用它。因此仅改一次节点贴图会被后续刷新覆盖。外部PNG资源加载仍未动态验证，不应修改游戏资源。

## 5. 开局牌组与确定性替换

- `CharacterModel.StartingDeck: IEnumerable<CardModel>` abstract（Models/CharacterModel.cs:80）。`Player.PopulateStartingInventory(): void` private（Entities.Players/Player.cs:242）要求尚未加入RunState，然后调用`PopulateStartingDeck(): void`（:555），逐张ToMutable、FloorAddedToDeck=1，`PopulateDeck(IEnumerable<CardModel>,bool silent=false): void`（:567）经Deck.AddInternal加入并设归属；已有牌会报错。
- 不要改Character规范模型StartingDeck影响所有同角色玩家。建议在新局完成Player实例构建且身份已明确之后、首次存档/进战斗前，对NetId100001那一个Player的Deck做确定性替换；各端相同顺序与ID，不消耗各自非同步随机数。加载存档不能再次用新局牌覆盖。
- `Player.PopulateCombatState(Rng,CombatState): void`（:619）克隆Deck.Cards，设置DeckVersion，加入DrawPile并洗牌。因此永久牌组里的陷阱默认也会进战斗，必须额外过滤。
- `NDeckViewScreen.ShowScreen(Player): NDeckViewScreen?`（Nodes.Screens/NDeckViewScreen.cs:96）；其初始化:161取PileType.Deck.GetPile(_player)。真正改Deck才会在原版牌组按钮看到，不是换自制面板。

## 6. 单玩家抽牌、能量钩子

- `Hook.ModifyHandDraw(ICombatState,Player,decimal originalCardCount,out IEnumerable<AbstractModel>): decimal`（Hooks/Hook.cs:1339）；CombatManager.cs:659以5m为基础调用。`AbstractModel.ModifyHandDraw(Player,decimal): decimal`与Late（AbstractModel.cs:716/:721）可按玩家身份返回4或保持原值。
- `Hook.ModifyMaxEnergy(ICombatState,Player,decimal): decimal`（:1415）；PlayerCombatState.MaxEnergy（Entities.Players/PlayerCombatState.cs:88）调用它。`Hook.ModifyEnergyGain(ICombatState,Player,decimal,out IEnumerable<AbstractModel>): decimal`（:1276），PlayerCmd.cs:29在能量增减路径调用；AbstractModel对应virtual成员:696/:746。
- “最大能量”与“实际本回合发能量”不能混为一谈；需在回合开始路径控制发放，而非把所有能量获得（药水、遗物、卡牌）一律改成固定值。只改塔主由传入Player筛选，但hook模型必须实际进入参与钩子的集合；随便建一张不在战斗牌堆的卡不能期望收到hook。

## 7. 目标类型与队友

`Entities.Cards.TargetType`（TargetType.cs:3–15）：None、Self、AnyEnemy、AllEnemies、RandomEnemy、AnyPlayer、AnyAlly、AllAllies、TargetedNoCreature、Osty。

- `NTargetManager.AllowedToTargetCreature(Creature): bool` private（Nodes.Combat/NTargetManager.cs:418）：AnyEnemy仅活敌人；AnyPlayer仅活玩家；AnyAlly仅活玩家且排除本机玩家。`NCardPlay.TryPlayCard(Creature?): void`（NCardPlay.cs:118）走TryManualPlay。
- `CardModel.IsValidTarget(Creature?): bool`（:1407）检查活着、AnyEnemy敌对side、AnyAlly同side；`CanPlay(out UnplayableReason,out AbstractModel?): bool`（:1375）对AnyAlly还要求活PlayerCreatures数量大于1，否则NoLivingAllies。
- 关键风险：塔主当前死亡退场，只有一名活爬塔玩家时AnyAlly会被上述人数门槛拒绝，即使界面目标存在。必须处理真实活塔主的隐藏方式或专门调整可用判定，不能仅把TargetType改成AnyAlly。
- AnyPlayer虽然目标管理器支持，CardModel非null目标校验默认只接受AnyEnemy/AnyAlly，不能认定普通牌直接换AnyPlayer就能用。要核对具体使用路径；方案优先AnyAlly，但处理塔主死亡/人数门槛。

## 8. 只暂停部分玩家队列

- `ActionQueueSet.PauseAllPlayerQueues(): void`（GameActions.Multiplayer/ActionQueueSet.cs:266），`UnpauseAllPlayerQueues(): void`（:302）、`ActionQueueIsPaused(ulong): bool`（:297）。未找到公共PausePlayerQueue接口。
- private `GetQueue(ulong): ActionQueue`（:457）；内部ActionQueue（:15）有isPaused（:27），可以反射取得目标队列改标志，但这属于私有接口方案，必须所有客户端同动作/时机操作并恢复，不能只改主机。
- 调度:188只在isPaused且动作类型CombatPlayPhaseOnly时阻止该队列；不会拦所有NonCombat/Any。原版UnpauseAll会清掉标志。塔主先手不能只调用PauseAll，再期待自己的原版PlayCardAction执行；应暂停爬塔玩家队列、允许塔主队列，并处理全局恢复与断线清理。反射私有标志可行性未在真实新卡中实测。

## 9. 结束回合与先手结束

- `NEndTurnButton.CallReleaseLogic(): void`（Nodes.Combat/NEndTurnButton.cs:415，RequestEnqueue在:427），创建 `EndPlayerTurnAction(Player,int turnNumber)`（GameActions/EndPlayerTurnAction.cs:22）；`ExecuteAction(): Task`（:28）核对TurnNumber后调用 `PlayerCmd.EndTurn(Player,bool canBackOut,Func<Task>? actionDuringEnemyTurn=null)`（Commands/PlayerCmd.cs:218）。动作类型CombatPlayPhaseOnly。
- `CombatManager.SetReadyToEndTurn(Player,bool,Func<Task>?=null): void`（CombatManager.cs:683）、`IsPlayerReadyToEndTurn(Player): bool`（:765）、private `AllPlayersReadyToEndTurn(CombatTurnState): bool`（:789）按Ready人数等于State.Players.Count决定整轮结束。
- 可在EndPlayerTurnAction.ExecuteAction的确定性执行层对塔主识别，转换成先手完成/恢复其他队列；不要只截本机按钮。若不把塔主加入Ready集合，整轮就可能一直等它；如果提前SetReady，又需确认下一轮重置和重复按键行为。必须同时设计“先手结束”和“整轮已准备”两种语义，原版没有独立塔主阶段。

## 10. 打牌同步与可用校验

- `CardModel.TryManualPlay(Creature?): bool`（:1432）先CanPlayTargeting，再EnqueueManualPlay；`CanPlayTargeting(Creature?): bool`（:1359）。
- `PlayCardAction.ExecuteAction(): Task`（GameActions/PlayCardAction.cs:58）在各端查资源/目标，:81再次CanPlay和IsValidTarget，:99 await OnPlayWrapper。`CardModel.OnPlayWrapper(PlayerChoiceContext,Creature?,bool,ResourceInfo,bool=false): Task`（:1487）在:1562调用并等待OnPlay。
- 不是房主单端施效果再另广播。每端都执行同一卡效果，禁止OnPlay里再次发一条重复施效果的自定义动作。CanPlay/目标限制既有发起端也有执行端，状态须一致；随机与副作用不能放在可用性查询里。

## 11. 不可打出与陷阱移出抽牌堆

- `CardModel.CanonicalKeywords: IEnumerable<CardKeyword>` virtual（:423），可返回Unplayable；CanPlay（:1386附近）发现该关键词给HasUnplayableKeyword。这只禁止打出，不禁止抽到。
- `Hook.BeforeCombatStart(IRunState,ICombatState?): Task`（Hook.cs:220）依次调用模型的BeforeCombatStart与Late；`AbstractModel.BeforeCombatStart(): Task`（:251）及Late（:256）。可在战斗克隆之后、洗牌/抽牌前过滤陷阱；具体挂点需对照PopulateCombatState与CombatRoom.StartCombat调用顺序，不应直接假定任意BeforeCombatStart已拿到完整克隆堆。
- `CardModel.RemoveFromCurrentPile(bool silent=false): void`（:1293）/`RemoveFromState(): void`（:1299）能移除战斗副本；永久Deck保持。更直接挂Player.PopulateCombatState末尾过滤DrawPile，再核对NetCombatCardDb注册与随机序列，避免先洗入陷阱后移除改变普通牌洗牌序列。

## 12. 存档、未知类型、图鉴成就风险

- `CardModel.ToSerializable(): SerializableCard`（:1810）、`FromSerializable(SerializableCard): CardModel`（:1823）；SerializableCard（Saves.Runs/SerializableCard.cs:12–31）保存ModelId、升级等级、附魔、SavedProperties、加入楼层，Serialize/Deserialize用模型ID数字缓存。
- `SaveUtil.CardOrDeprecated(ModelId): CardModel`（Saves/SaveUtil.cs:32）缺模型回退DeprecatedCard；因此缺失类型不一定立刻崩溃，但原卡功能和升级等会丢失。直接ModelDb.GetById<T>(ModelId)（:435）仍会抛ModelNotFoundException。不能向用户承诺卸载后存档无损。
- 两端需同版本/相同类型与编号，动态类型名要稳定；自定义持久状态要用SavedProperty机制且可序列化。升级、重连、跨版本恢复必须单独测试。
- ShouldShowInCardLibrary不是控制牌组屏幕开关。新卡是否被图鉴发现/解锁进度统计、全收集成就计数影响尚未逐成就核对；保持图鉴隐藏并隔离池可减少影响，但不能宣称零影响。mod本身affects_gameplay=true，与原版存档/成就区分也需遵循游戏mod流程。

## 13. 本机其它mod先例

川换皮安装目录“刘川 战士 动画测试版 20260914 新待机与打击特效 v2”只有liuchuan.json与liuchuan.pck，manifest has_dll=false、affects_gameplay=false，纯视觉。没有C# CardModel注入先例可用，不能据此推断真实新卡实现。

已反编译的DirectConnectIP是联机/UI和存档补丁，检索其ModelDb.Inject/CardModel未找到新卡实现。本地decompiled只有sts2、DirectConnectIP、pck；Mesugaki_Regent、quickRestart2、mvm其他已装mod未在本轮解包/反编译，不能判定是否注册新内容。第13项为“已查两项未找到，其他未覆盖”，不编造先例。

## 开发前必须解决

1. 启动时注册模型和联机ID，而不是晚Inject；本地化切语言与视觉资源加载。
2. 明确独立逻辑池、不污染生成路径、永久Deck与战斗DrawPile分离。
3. 当前死亡塔主无法直接当作普通AnyAlly牌主，暂停和Ready逻辑需要配套重设计。
4. 用真实卡打一次、原版牌组看一次、两端对比、存档/重连一次后，再宣称接入完成。

## 文件定位约定

上述 `X.cs:行号` 均以同段给出的命名空间定位，例如 `Models/CardModel.cs` 的实际路径为 `decompiled/sts2/MegaCrit.Sts2.Core.Models/CardModel.cs`；`Nodes.Cards/NCard.cs` 为 `decompiled/sts2/MegaCrit.Sts2.Core.Nodes.Cards/NCard.cs`。未另写命名空间的 Hook.cs 位于 `MegaCrit.Sts2.Core.Hooks`，ModManager.cs 位于 `MegaCrit.Sts2.Core.Modding`，ReflectionHelper.cs 位于 `MegaCrit.Sts2.Core.Helpers`。源码行号基于本机 v0.111.0 反编译输出，游戏更新后须重查。
