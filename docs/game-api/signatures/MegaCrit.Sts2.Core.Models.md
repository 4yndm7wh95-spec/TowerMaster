# MegaCrit.Sts2.Core.Models

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Models.AbstractModel

类型属性：`Public, Abstract, BeforeFieldInit`；基类：`System.Object`。

接口：`System.IComparable<MegaCrit.Sts2.Core.Models.AbstractModel>`

```text
private System.Int32 <CategorySortingId>k__BackingField
private System.Int32 <EntrySortingId>k__BackingField
private readonly MegaCrit.Sts2.Core.Models.ModelId <Id>k__BackingField
private System.Boolean <IsMutable>k__BackingField
private System.Action<MegaCrit.Sts2.Core.Models.AbstractModel> ExecutionFinished
System.Int32 CategorySortingId { public get; private set; }
System.Int32 EntrySortingId { public get; private set; }
MegaCrit.Sts2.Core.Models.ModelId Id { public get; }
System.Boolean IsCanonical { public get; }
System.Boolean IsMock { public virtual get; }
System.Boolean IsMutable { public get; private set; }
System.Boolean PreviewOutsideOfCombat { public virtual get; }
System.Boolean ShouldReceiveCombatHooks { public abstract get; }
event System.Action<MegaCrit.Sts2.Core.Models.AbstractModel> ExecutionFinished
protected .ctor()
private System.Void set_CategorySortingId(System.Int32 value)
private System.Void set_EntrySortingId(System.Int32 value)
private System.Void set_IsMutable(System.Boolean value)
protected System.Void NeverEverCallThisOutsideOfTests_SetIsMutable(System.Boolean isMutable)
protected virtual System.Void AfterCloned()
protected virtual System.Void DeepCloneFields()
public abstract System.Boolean get_ShouldReceiveCombatHooks()
public MegaCrit.Sts2.Core.Models.AbstractModel ClonePreservingMutability()
public MegaCrit.Sts2.Core.Models.AbstractModel MutableClone()
public MegaCrit.Sts2.Core.Models.ModelId get_Id()
public System.Boolean get_IsCanonical()
public System.Boolean get_IsMutable()
public System.Int32 get_CategorySortingId()
public System.Int32 get_EntrySortingId()
public System.Void add_ExecutionFinished(System.Action<MegaCrit.Sts2.Core.Models.AbstractModel> value)
public System.Void AssertCanonical()
public System.Void AssertMutable()
public System.Void InitId(MegaCrit.Sts2.Core.Models.ModelId id)
public System.Void InvokeExecutionFinished()
public System.Void remove_ExecutionFinished(System.Action<MegaCrit.Sts2.Core.Models.AbstractModel> value)
public virtual MegaCrit.Sts2.Core.Entities.Cards.CardLocation ModifyCardPlayResultLocation(MegaCrit.Sts2.Core.Models.CardModel card, System.Boolean isAutoPlay, MegaCrit.Sts2.Core.Entities.Cards.ResourceInfo resources, MegaCrit.Sts2.Core.Entities.Cards.CardLocation cardLocation)
public virtual MegaCrit.Sts2.Core.Entities.Cards.CardRarity ModifyMerchantCardRarity(MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.Entities.Cards.CardRarity rarity)
public virtual MegaCrit.Sts2.Core.Entities.Creatures.Creature ModifyUnblockedDamageTarget(MegaCrit.Sts2.Core.Entities.Creatures.Creature target, System.Decimal amount, MegaCrit.Sts2.Core.ValueProps.ValueProp props, MegaCrit.Sts2.Core.Entities.Creatures.Creature dealer)
public virtual MegaCrit.Sts2.Core.Map.ActMap ModifyGeneratedMap(MegaCrit.Sts2.Core.Runs.IRunState runState, MegaCrit.Sts2.Core.Map.ActMap map, System.Int32 actIndex)
public virtual MegaCrit.Sts2.Core.Map.ActMap ModifyGeneratedMapLate(MegaCrit.Sts2.Core.Runs.IRunState runState, MegaCrit.Sts2.Core.Map.ActMap map, System.Int32 actIndex)
public virtual MegaCrit.Sts2.Core.Models.EventModel ModifyNextEvent(MegaCrit.Sts2.Core.Models.EventModel currentEvent)
public virtual MegaCrit.Sts2.Core.Runs.CardCreationOptions ModifyCardRewardCreationOptions(MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.Runs.CardCreationOptions options)
public virtual MegaCrit.Sts2.Core.Runs.CardCreationOptions ModifyCardRewardCreationOptionsLate(MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.Runs.CardCreationOptions options)
public virtual System.Boolean get_IsMock()
public virtual System.Boolean get_PreviewOutsideOfCombat()
public virtual System.Boolean ShouldAddToDeck(MegaCrit.Sts2.Core.Models.CardModel card)
public virtual System.Boolean ShouldAfflict(MegaCrit.Sts2.Core.Models.CardModel card, MegaCrit.Sts2.Core.Models.AfflictionModel affliction)
public virtual System.Boolean ShouldAllowAncient(MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.Models.AncientEventModel ancient)
public virtual System.Boolean ShouldAllowFreeTravel()
public virtual System.Boolean ShouldAllowHitting(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public virtual System.Boolean ShouldAllowMerchantCardRemoval(MegaCrit.Sts2.Core.Entities.Players.Player player)
public virtual System.Boolean ShouldAllowSelectingMoreCardRewards(MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.Rewards.CardReward cardReward)
public virtual System.Boolean ShouldAllowTargeting(MegaCrit.Sts2.Core.Entities.Creatures.Creature target)
public virtual System.Boolean ShouldClearBlock(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public virtual System.Boolean ShouldCreatureBeRemovedFromCombatAfterDeath(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public virtual System.Boolean ShouldDie(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public virtual System.Boolean ShouldDieLate(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public virtual System.Boolean ShouldDisableRemainingRestSiteOptions(MegaCrit.Sts2.Core.Entities.Players.Player player)
public virtual System.Boolean ShouldDraw(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Boolean fromHandDraw)
public virtual System.Boolean ShouldEtherealTrigger(MegaCrit.Sts2.Core.Models.CardModel card)
public virtual System.Boolean ShouldFlush(MegaCrit.Sts2.Core.Entities.Players.Player player)
public virtual System.Boolean ShouldForcePotionReward(MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.Rooms.RoomType roomType)
public virtual System.Boolean ShouldGainStars(System.Decimal amount, MegaCrit.Sts2.Core.Entities.Players.Player player)
public virtual System.Boolean ShouldGenerateTreasure(MegaCrit.Sts2.Core.Entities.Players.Player player)
public virtual System.Boolean ShouldPayExcessEnergyCostWithStars(MegaCrit.Sts2.Core.Entities.Players.Player player)
public virtual System.Boolean ShouldPlay(MegaCrit.Sts2.Core.Models.CardModel card, MegaCrit.Sts2.Core.Entities.Cards.AutoPlayType autoPlayType)
public virtual System.Boolean ShouldPlayerResetEnergy(MegaCrit.Sts2.Core.Entities.Players.Player player)
public virtual System.Boolean ShouldPowerBeRemovedOnDeath(MegaCrit.Sts2.Core.Models.PowerModel power)
public virtual System.Boolean ShouldProceedToNextMapPoint()
public virtual System.Boolean ShouldProcurePotion(MegaCrit.Sts2.Core.Models.PotionModel potion, MegaCrit.Sts2.Core.Entities.Players.Player player)
public virtual System.Boolean ShouldRefillMerchantEntry(MegaCrit.Sts2.Core.Entities.Merchant.MerchantEntry entry, MegaCrit.Sts2.Core.Entities.Players.Player player)
public virtual System.Boolean ShouldStopCombatFromEnding()
public virtual System.Boolean ShouldTakeExtraTurn(MegaCrit.Sts2.Core.Entities.Players.Player player)
public virtual System.Boolean TryModifyCardBeingAddedToDeck(MegaCrit.Sts2.Core.Models.CardModel card, out MegaCrit.Sts2.Core.Models.CardModel newCard)
public virtual System.Boolean TryModifyCardBeingAddedToDeckLate(MegaCrit.Sts2.Core.Models.CardModel card, out MegaCrit.Sts2.Core.Models.CardModel newCard)
public virtual System.Boolean TryModifyCardRewardAlternatives(MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.Rewards.CardReward cardReward, System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.CardRewardAlternatives.CardRewardAlternative> alternatives)
public virtual System.Boolean TryModifyCardRewardOptions(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Cards.CardCreationResult> cardRewardOptions, MegaCrit.Sts2.Core.Runs.CardCreationOptions creationOptions)
public virtual System.Boolean TryModifyCardRewardOptionsLate(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Cards.CardCreationResult> cardRewardOptions, MegaCrit.Sts2.Core.Runs.CardCreationOptions creationOptions)
public virtual System.Boolean TryModifyEnergyCostInCombat(MegaCrit.Sts2.Core.Models.CardModel card, System.Decimal originalCost, out System.Decimal modifiedCost)
public virtual System.Boolean TryModifyEnergyCostInCombatLate(MegaCrit.Sts2.Core.Models.CardModel card, System.Decimal originalCost, out System.Decimal modifiedCost)
public virtual System.Boolean TryModifyKeywordsInCombat(MegaCrit.Sts2.Core.Models.CardModel card, System.Collections.Generic.ISet<MegaCrit.Sts2.Core.Entities.Cards.CardKeyword> keywords)
public virtual System.Boolean TryModifyPowerAmountReceived(MegaCrit.Sts2.Core.Models.PowerModel canonicalPower, MegaCrit.Sts2.Core.Entities.Creatures.Creature target, System.Decimal amount, MegaCrit.Sts2.Core.Entities.Creatures.Creature applier, out System.Decimal modifiedAmount)
public virtual System.Boolean TryModifyRestSiteHealRewards(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Collections.Generic.List<MegaCrit.Sts2.Core.Rewards.Reward> rewards, System.Boolean isMimicked)
public virtual System.Boolean TryModifyRestSiteOptions(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Collections.Generic.ICollection<MegaCrit.Sts2.Core.Entities.RestSite.RestSiteOption> options)
public virtual System.Boolean TryModifyRewards(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Collections.Generic.List<MegaCrit.Sts2.Core.Rewards.Reward> rewards, MegaCrit.Sts2.Core.Rooms.AbstractRoom room)
public virtual System.Boolean TryModifyRewardsLate(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Collections.Generic.List<MegaCrit.Sts2.Core.Rewards.Reward> rewards, MegaCrit.Sts2.Core.Rooms.AbstractRoom room)
public virtual System.Boolean TryModifyStarCost(MegaCrit.Sts2.Core.Models.CardModel card, System.Decimal originalCost, out System.Decimal modifiedCost)
public virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> ModifyMerchantCardPool(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> options)
public virtual System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Localization.LocString> ModifyExtraRestSiteHealText(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Localization.LocString> currentExtraText)
public virtual System.Collections.Generic.IReadOnlySet<MegaCrit.Sts2.Core.Rooms.RoomType> ModifyUnknownMapPointRoomTypes(System.Collections.Generic.IReadOnlySet<MegaCrit.Sts2.Core.Rooms.RoomType> roomTypes)
public virtual System.Decimal ModifyBlockAdditive(MegaCrit.Sts2.Core.Entities.Creatures.Creature target, System.Decimal block, MegaCrit.Sts2.Core.ValueProps.ValueProp props, MegaCrit.Sts2.Core.Models.CardModel cardSource, MegaCrit.Sts2.Core.Entities.Cards.CardPlay cardPlay)
public virtual System.Decimal ModifyBlockMultiplicative(MegaCrit.Sts2.Core.Entities.Creatures.Creature target, System.Decimal block, MegaCrit.Sts2.Core.ValueProps.ValueProp props, MegaCrit.Sts2.Core.Models.CardModel cardSource, MegaCrit.Sts2.Core.Entities.Cards.CardPlay cardPlay)
public virtual System.Decimal ModifyCardRewardUpgradeOdds(MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.Models.CardModel card, System.Decimal odds)
public virtual System.Decimal ModifyDamageAdditive(MegaCrit.Sts2.Core.Entities.Creatures.Creature target, System.Decimal amount, MegaCrit.Sts2.Core.ValueProps.ValueProp props, MegaCrit.Sts2.Core.Entities.Creatures.Creature dealer, MegaCrit.Sts2.Core.Models.CardModel cardSource, MegaCrit.Sts2.Core.Entities.Cards.CardPlay cardPlay)
public virtual System.Decimal ModifyDamageCap(MegaCrit.Sts2.Core.Entities.Creatures.Creature target, MegaCrit.Sts2.Core.ValueProps.ValueProp props, MegaCrit.Sts2.Core.Entities.Creatures.Creature dealer, MegaCrit.Sts2.Core.Models.CardModel cardSource, MegaCrit.Sts2.Core.Entities.Cards.CardPlay cardPlay)
public virtual System.Decimal ModifyDamageMultiplicative(MegaCrit.Sts2.Core.Entities.Creatures.Creature target, System.Decimal amount, MegaCrit.Sts2.Core.ValueProps.ValueProp props, MegaCrit.Sts2.Core.Entities.Creatures.Creature dealer, MegaCrit.Sts2.Core.Models.CardModel cardSource, MegaCrit.Sts2.Core.Entities.Cards.CardPlay cardPlay)
public virtual System.Decimal ModifyEnergyGain(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Decimal amount)
public virtual System.Decimal ModifyGoldGained(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Decimal amount)
public virtual System.Decimal ModifyHandDraw(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Decimal count)
public virtual System.Decimal ModifyHandDrawLate(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Decimal count)
public virtual System.Decimal ModifyHpLostAfterOsty(MegaCrit.Sts2.Core.Entities.Creatures.Creature target, System.Decimal amount, MegaCrit.Sts2.Core.ValueProps.ValueProp props, MegaCrit.Sts2.Core.Entities.Creatures.Creature dealer, MegaCrit.Sts2.Core.Models.CardModel cardSource)
public virtual System.Decimal ModifyHpLostAfterOstyLate(MegaCrit.Sts2.Core.Entities.Creatures.Creature target, System.Decimal amount, MegaCrit.Sts2.Core.ValueProps.ValueProp props, MegaCrit.Sts2.Core.Entities.Creatures.Creature dealer, MegaCrit.Sts2.Core.Models.CardModel cardSource)
public virtual System.Decimal ModifyHpLostBeforeOsty(MegaCrit.Sts2.Core.Entities.Creatures.Creature target, System.Decimal amount, MegaCrit.Sts2.Core.ValueProps.ValueProp props, MegaCrit.Sts2.Core.Entities.Creatures.Creature dealer, MegaCrit.Sts2.Core.Models.CardModel cardSource)
public virtual System.Decimal ModifyHpLostBeforeOstyLate(MegaCrit.Sts2.Core.Entities.Creatures.Creature target, System.Decimal amount, MegaCrit.Sts2.Core.ValueProps.ValueProp props, MegaCrit.Sts2.Core.Entities.Creatures.Creature dealer, MegaCrit.Sts2.Core.Models.CardModel cardSource)
public virtual System.Decimal ModifyMaxEnergy(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Decimal amount)
public virtual System.Decimal ModifyMerchantPrice(MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.Entities.Merchant.MerchantEntry entry, System.Decimal cost)
public virtual System.Decimal ModifyOrbValue(MegaCrit.Sts2.Core.Models.OrbModel orb, System.Decimal value)
public virtual System.Decimal ModifyPowerAmountGivenAdditive(MegaCrit.Sts2.Core.Models.PowerModel power, MegaCrit.Sts2.Core.Entities.Creatures.Creature giver, System.Decimal amount, MegaCrit.Sts2.Core.Entities.Creatures.Creature target, MegaCrit.Sts2.Core.Models.CardModel cardSource)
public virtual System.Decimal ModifyPowerAmountGivenMultiplicative(MegaCrit.Sts2.Core.Models.PowerModel power, MegaCrit.Sts2.Core.Entities.Creatures.Creature giver, System.Decimal amount, MegaCrit.Sts2.Core.Entities.Creatures.Creature target, MegaCrit.Sts2.Core.Models.CardModel cardSource)
public virtual System.Decimal ModifyRestSiteHealAmount(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature, System.Decimal amount)
public virtual System.Decimal ModifySummonAmount(MegaCrit.Sts2.Core.Entities.Players.Player summoner, System.Decimal amount, MegaCrit.Sts2.Core.Models.AbstractModel source)
public virtual System.Int32 CompareTo(MegaCrit.Sts2.Core.Models.AbstractModel other)
public virtual System.Int32 ModifyAttackHitCount(MegaCrit.Sts2.Core.Commands.Builders.AttackCommand attack, System.Int32 hitCount)
public virtual System.Int32 ModifyCardPlayCount(MegaCrit.Sts2.Core.Models.CardModel card, MegaCrit.Sts2.Core.Entities.Creatures.Creature target, System.Int32 playCount)
public virtual System.Int32 ModifyOrbPassiveTriggerCounts(MegaCrit.Sts2.Core.Models.OrbModel orb, System.Int32 triggerCount)
public virtual System.Int32 ModifyXValue(MegaCrit.Sts2.Core.Models.CardModel card, System.Int32 originalValue)
public virtual System.Single ModifyOddsIncreaseForUnrolledRoomType(MegaCrit.Sts2.Core.Rooms.RoomType roomType, System.Single oddsIncrease)
public virtual System.String ToString()
public virtual System.Threading.Tasks.Task AfterActEntered()
public virtual System.Threading.Tasks.Task AfterAddToDeckPrevented(MegaCrit.Sts2.Core.Models.CardModel card)
public virtual System.Threading.Tasks.Task AfterAttack(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Commands.Builders.AttackCommand command)
public virtual System.Threading.Tasks.Task AfterAutoPostPlayPhaseEntered(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Players.Player player)
public virtual System.Threading.Tasks.Task AfterAutoPrePlayPhaseEntered(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Players.Player player)
public virtual System.Threading.Tasks.Task AfterAutoPrePlayPhaseEnteredEarly(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Players.Player player)
public virtual System.Threading.Tasks.Task AfterAutoPrePlayPhaseEnteredLate(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Players.Player player)
public virtual System.Threading.Tasks.Task AfterBlockBroken(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Creatures.Creature target, MegaCrit.Sts2.Core.Entities.Creatures.Creature breaker)
public virtual System.Threading.Tasks.Task AfterBlockCleared(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public virtual System.Threading.Tasks.Task AfterBlockGained(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature, System.Decimal amount, MegaCrit.Sts2.Core.ValueProps.ValueProp props, MegaCrit.Sts2.Core.Models.CardModel cardSource)
public virtual System.Threading.Tasks.Task AfterCardChangedPiles(MegaCrit.Sts2.Core.Models.CardModel card, MegaCrit.Sts2.Core.Entities.Cards.PileType oldPileType, MegaCrit.Sts2.Core.Models.AbstractModel clonedBy)
public virtual System.Threading.Tasks.Task AfterCardChangedPilesLate(MegaCrit.Sts2.Core.Models.CardModel card, MegaCrit.Sts2.Core.Entities.Cards.PileType oldPileType, MegaCrit.Sts2.Core.Models.AbstractModel clonedBy)
public virtual System.Threading.Tasks.Task AfterCardDiscarded(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Models.CardModel card)
public virtual System.Threading.Tasks.Task AfterCardDrawn(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Models.CardModel card, System.Boolean fromHandDraw)
public virtual System.Threading.Tasks.Task AfterCardDrawnEarly(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Models.CardModel card, System.Boolean fromHandDraw)
public virtual System.Threading.Tasks.Task AfterCardEnteredCombat(MegaCrit.Sts2.Core.Models.CardModel card)
public virtual System.Threading.Tasks.Task AfterCardExhausted(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Models.CardModel card, System.Boolean causedByEthereal)
public virtual System.Threading.Tasks.Task AfterCardGeneratedForCombat(MegaCrit.Sts2.Core.Models.CardModel card, MegaCrit.Sts2.Core.Entities.Players.Player creator)
public virtual System.Threading.Tasks.Task AfterCardPlayed(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Cards.CardPlay cardPlay)
public virtual System.Threading.Tasks.Task AfterCardPlayedLate(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Cards.CardPlay cardPlay)
public virtual System.Threading.Tasks.Task AfterCombatEnd(MegaCrit.Sts2.Core.Rooms.CombatRoom room)
public virtual System.Threading.Tasks.Task AfterCombatVictory(MegaCrit.Sts2.Core.Rooms.CombatRoom room)
public virtual System.Threading.Tasks.Task AfterCombatVictoryEarly(MegaCrit.Sts2.Core.Rooms.CombatRoom room)
public virtual System.Threading.Tasks.Task AfterCreatureAddedToCombat(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public virtual System.Threading.Tasks.Task AfterCurrentHpChanged(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature, System.Decimal delta)
public virtual System.Threading.Tasks.Task AfterDamageGiven(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Creatures.Creature dealer, MegaCrit.Sts2.Core.Entities.Creatures.DamageResult result, MegaCrit.Sts2.Core.ValueProps.ValueProp props, MegaCrit.Sts2.Core.Entities.Creatures.Creature target, MegaCrit.Sts2.Core.Models.CardModel cardSource)
public virtual System.Threading.Tasks.Task AfterDamageReceived(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Creatures.Creature target, MegaCrit.Sts2.Core.Entities.Creatures.DamageResult result, MegaCrit.Sts2.Core.ValueProps.ValueProp props, MegaCrit.Sts2.Core.Entities.Creatures.Creature dealer, MegaCrit.Sts2.Core.Models.CardModel cardSource)
public virtual System.Threading.Tasks.Task AfterDamageReceivedLate(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Creatures.Creature target, MegaCrit.Sts2.Core.Entities.Creatures.DamageResult result, MegaCrit.Sts2.Core.ValueProps.ValueProp props, MegaCrit.Sts2.Core.Entities.Creatures.Creature dealer, MegaCrit.Sts2.Core.Models.CardModel cardSource)
public virtual System.Threading.Tasks.Task AfterDeath(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Creatures.Creature creature, System.Boolean wasRemovalPrevented, System.Single deathAnimLength)
public virtual System.Threading.Tasks.Task AfterDiedToDoom(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> creatures)
public virtual System.Threading.Tasks.Task AfterEnergyReset(MegaCrit.Sts2.Core.Entities.Players.Player player)
public virtual System.Threading.Tasks.Task AfterEnergyResetLate(MegaCrit.Sts2.Core.Entities.Players.Player player)
public virtual System.Threading.Tasks.Task AfterEnergySpent(MegaCrit.Sts2.Core.Models.CardModel card, System.Int32 amount)
public virtual System.Threading.Tasks.Task AfterFlush(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Players.Player player, System.Collections.Generic.IReadOnlyCollection<MegaCrit.Sts2.Core.Models.CardModel> flushedCards, System.Collections.Generic.IReadOnlyCollection<MegaCrit.Sts2.Core.Models.CardModel> retainedCards)
public virtual System.Threading.Tasks.Task AfterForge(System.Decimal amount, MegaCrit.Sts2.Core.Entities.Players.Player forger, MegaCrit.Sts2.Core.Models.AbstractModel source)
public virtual System.Threading.Tasks.Task AfterGoldGained(MegaCrit.Sts2.Core.Entities.Players.Player player)
public virtual System.Threading.Tasks.Task AfterHandEmptied(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Players.Player player)
public virtual System.Threading.Tasks.Task AfterItemPurchased(MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.Entities.Merchant.MerchantEntry itemPurchased, System.Int32 goldSpent)
public virtual System.Threading.Tasks.Task AfterMapGenerated(MegaCrit.Sts2.Core.Map.ActMap map, System.Int32 actIndex)
public virtual System.Threading.Tasks.Task AfterModifyingBlockAmount(System.Decimal modifiedAmount, MegaCrit.Sts2.Core.Models.CardModel cardSource, MegaCrit.Sts2.Core.Entities.Cards.CardPlay cardPlay)
public virtual System.Threading.Tasks.Task AfterModifyingCardPlayCount(MegaCrit.Sts2.Core.Models.CardModel card)
public virtual System.Threading.Tasks.Task AfterModifyingCardPlayResultLocation(MegaCrit.Sts2.Core.Models.CardModel card, MegaCrit.Sts2.Core.Entities.Cards.CardLocation cardLocation)
public virtual System.Threading.Tasks.Task AfterModifyingCardRewardOptions()
public virtual System.Threading.Tasks.Task AfterModifyingDamageAmount(MegaCrit.Sts2.Core.Models.CardModel cardSource)
public virtual System.Threading.Tasks.Task AfterModifyingEnergyGain()
public virtual System.Threading.Tasks.Task AfterModifyingGoldGained(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Decimal amount)
public virtual System.Threading.Tasks.Task AfterModifyingHandDraw()
public virtual System.Threading.Tasks.Task AfterModifyingHpLostAfterOsty()
public virtual System.Threading.Tasks.Task AfterModifyingHpLostBeforeOsty()
public virtual System.Threading.Tasks.Task AfterModifyingOrbPassiveTriggerCount(MegaCrit.Sts2.Core.Models.OrbModel orb)
public virtual System.Threading.Tasks.Task AfterModifyingPowerAmountGiven(MegaCrit.Sts2.Core.Models.PowerModel power)
public virtual System.Threading.Tasks.Task AfterModifyingPowerAmountReceived(MegaCrit.Sts2.Core.Models.PowerModel power)
public virtual System.Threading.Tasks.Task AfterModifyingRewards()
public virtual System.Threading.Tasks.Task AfterOrbChanneled(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.Models.OrbModel orb)
public virtual System.Threading.Tasks.Task AfterOrbEvoked(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Models.OrbModel orb, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature> targets)
public virtual System.Threading.Tasks.Task AfterOstyRevived(MegaCrit.Sts2.Core.Entities.Creatures.Creature osty)
public virtual System.Threading.Tasks.Task AfterPlayerTurnStart(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Players.Player player)
public virtual System.Threading.Tasks.Task AfterPlayerTurnStartEarly(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Players.Player player)
public virtual System.Threading.Tasks.Task AfterPlayerTurnStartLate(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Players.Player player)
public virtual System.Threading.Tasks.Task AfterPotionDiscarded(MegaCrit.Sts2.Core.Models.PotionModel potion)
public virtual System.Threading.Tasks.Task AfterPotionProcured(MegaCrit.Sts2.Core.Models.PotionModel potion)
public virtual System.Threading.Tasks.Task AfterPotionUsed(MegaCrit.Sts2.Core.Models.PotionModel potion, MegaCrit.Sts2.Core.Entities.Creatures.Creature target)
public virtual System.Threading.Tasks.Task AfterPowerAmountChanged(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Models.PowerModel power, System.Decimal amount, MegaCrit.Sts2.Core.Entities.Creatures.Creature applier, MegaCrit.Sts2.Core.Models.CardModel cardSource)
public virtual System.Threading.Tasks.Task AfterPreventingBlockClear(MegaCrit.Sts2.Core.Models.AbstractModel preventer, MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public virtual System.Threading.Tasks.Task AfterPreventingDeath(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public virtual System.Threading.Tasks.Task AfterPreventingDraw()
public virtual System.Threading.Tasks.Task AfterRestSiteHeal(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Boolean isMimicked)
public virtual System.Threading.Tasks.Task AfterRestSiteSmith(MegaCrit.Sts2.Core.Entities.Players.Player player)
public virtual System.Threading.Tasks.Task AfterRewardTaken(MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.Rewards.Reward reward)
public virtual System.Threading.Tasks.Task AfterRoomEntered(MegaCrit.Sts2.Core.Rooms.AbstractRoom room)
public virtual System.Threading.Tasks.Task AfterShuffle(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Players.Player shuffler)
public virtual System.Threading.Tasks.Task AfterSideTurnEnd(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Combat.CombatSide side, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature> participants)
public virtual System.Threading.Tasks.Task AfterSideTurnEndLate(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Combat.CombatSide side, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature> participants)
public virtual System.Threading.Tasks.Task AfterSideTurnStart(MegaCrit.Sts2.Core.Combat.CombatSide side, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> participants, MegaCrit.Sts2.Core.Combat.ICombatState combatState)
public virtual System.Threading.Tasks.Task AfterSideTurnStartLate(MegaCrit.Sts2.Core.Combat.CombatSide side, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> participants, MegaCrit.Sts2.Core.Combat.ICombatState combatState)
public virtual System.Threading.Tasks.Task AfterStarsGained(System.Int32 amount, MegaCrit.Sts2.Core.Entities.Players.Player gainer)
public virtual System.Threading.Tasks.Task AfterStarsSpent(System.Int32 amount, MegaCrit.Sts2.Core.Entities.Players.Player spender)
public virtual System.Threading.Tasks.Task AfterSummon(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Players.Player summoner, System.Decimal amount)
public virtual System.Threading.Tasks.Task AfterTakingExtraTurn(MegaCrit.Sts2.Core.Entities.Players.Player player)
public virtual System.Threading.Tasks.Task AfterTargetingBlockedVfx(MegaCrit.Sts2.Core.Entities.Creatures.Creature blocker)
public virtual System.Threading.Tasks.Task BeforeAttack(MegaCrit.Sts2.Core.Commands.Builders.AttackCommand command)
public virtual System.Threading.Tasks.Task BeforeBlockGained(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature, System.Decimal amount, MegaCrit.Sts2.Core.ValueProps.ValueProp props, MegaCrit.Sts2.Core.Models.CardModel cardSource)
public virtual System.Threading.Tasks.Task BeforeCardAutoPlayed(MegaCrit.Sts2.Core.Models.CardModel card, MegaCrit.Sts2.Core.Entities.Creatures.Creature target, MegaCrit.Sts2.Core.Entities.Cards.AutoPlayType type)
public virtual System.Threading.Tasks.Task BeforeCardPlayed(MegaCrit.Sts2.Core.Entities.Cards.CardPlay cardPlay)
public virtual System.Threading.Tasks.Task BeforeCardRemoved(MegaCrit.Sts2.Core.Models.CardModel card)
public virtual System.Threading.Tasks.Task BeforeCombatRewardOffered(MegaCrit.Sts2.Core.Rewards.RewardsSet rewards, MegaCrit.Sts2.Core.Rooms.CombatRoom room)
public virtual System.Threading.Tasks.Task BeforeCombatStart()
public virtual System.Threading.Tasks.Task BeforeCombatStartLate()
public virtual System.Threading.Tasks.Task BeforeDamageReceived(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Creatures.Creature target, System.Decimal amount, MegaCrit.Sts2.Core.ValueProps.ValueProp props, MegaCrit.Sts2.Core.Entities.Creatures.Creature dealer, MegaCrit.Sts2.Core.Models.CardModel cardSource)
public virtual System.Threading.Tasks.Task BeforeDeath(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public virtual System.Threading.Tasks.Task BeforeFlush(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Players.Player player)
public virtual System.Threading.Tasks.Task BeforeFlushLate(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Players.Player player)
public virtual System.Threading.Tasks.Task BeforeHandDraw(MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Combat.ICombatState combatState)
public virtual System.Threading.Tasks.Task BeforeHandDrawLate(MegaCrit.Sts2.Core.Entities.Players.Player player, MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Combat.ICombatState combatState)
public virtual System.Threading.Tasks.Task BeforePotionUsed(MegaCrit.Sts2.Core.Models.PotionModel potion, MegaCrit.Sts2.Core.Entities.Creatures.Creature target)
public virtual System.Threading.Tasks.Task BeforePowerAmountChanged(MegaCrit.Sts2.Core.Models.PowerModel power, System.Decimal amount, MegaCrit.Sts2.Core.Entities.Creatures.Creature target, MegaCrit.Sts2.Core.Entities.Creatures.Creature applier, MegaCrit.Sts2.Core.Models.CardModel cardSource)
public virtual System.Threading.Tasks.Task BeforeRoomEntered(MegaCrit.Sts2.Core.Rooms.AbstractRoom room)
public virtual System.Threading.Tasks.Task BeforeSideTurnEnd(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Combat.CombatSide side, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature> participants)
public virtual System.Threading.Tasks.Task BeforeSideTurnEndEarly(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Combat.CombatSide side, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature> participants)
public virtual System.Threading.Tasks.Task BeforeSideTurnEndVeryEarly(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Combat.CombatSide side, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature> participants)
public virtual System.Threading.Tasks.Task BeforeSideTurnStart(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Combat.CombatSide side, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Creatures.Creature> participants, MegaCrit.Sts2.Core.Combat.ICombatState combatState)
public virtual System.Void ModifyMerchantCardCreationResults(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Cards.CardCreationResult> cards)
public virtual System.Void ModifyShuffleOrder(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.CardModel> cards, System.Boolean isInitialShuffle)
```

## MegaCrit.Sts2.Core.Models.ActModel

类型属性：`Public, Abstract, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Models.AbstractModel`。

接口：`System.IComparable<MegaCrit.Sts2.Core.Models.AbstractModel>`

```text
private System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.EncounterModel> _allBossEncounters
private System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.EncounterModel> _allEliteEncounters
private System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.EncounterModel> _allEncounters
private System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.MonsterModel> _allMonsters
private System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.EncounterModel> _allRegularEncounters
private System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.EncounterModel> _allWeakEncounters
private MegaCrit.Sts2.Core.Models.ActModel _canonicalInstance
protected MegaCrit.Sts2.Core.Rooms.RoomSet _rooms
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.AncientEventModel> _sharedAncientSubset
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AncientEventModel> AllAncients { public abstract get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.EncounterModel> AllBossEncounters { public get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.EncounterModel> AllEliteEncounters { public get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.EncounterModel> AllEncounters { public get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.EventModel> AllEvents { public abstract get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.MonsterModel> AllMonsters { public get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.EncounterModel> AllRegularEncounters { public get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.EncounterModel> AllWeakEncounters { public get; }
System.String AmbientSfx { public abstract get; }
MegaCrit.Sts2.Core.Models.AncientEventModel Ancient { public get; }
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public get; }
System.String BackgroundScenePath { public get; }
System.Int32 BaseNumberOfRooms { protected abstract get; }
System.String[] BgMusicOptions { public abstract get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.EncounterModel> BossDiscoveryOrder { public abstract get; }
MegaCrit.Sts2.Core.Models.EncounterModel BossEncounter { public get; }
MegaCrit.Sts2.Core.Models.ActModel CanonicalInstance { public get; private set; }
System.String ChestOpenSfx { public abstract get; }
MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSkeletonDataResource ChestSpineResource { public virtual get; }
System.String ChestSpineResourcePath { public virtual get; }
System.String ChestSpineSkinNameNormal { public abstract get; }
System.String ChestSpineSkinNameStroke { public abstract get; }
MegaCrit.Sts2.Core.Achievements.Achievement DefeatedAllEnemiesAchievement { public get; }
System.String FilePathIdentifier { protected get; }
System.Boolean HasSecondBoss { public get; }
System.Int32 Index { public abstract get; }
System.Boolean IsDefault { public abstract get; }
Godot.Color MapBgColor { public abstract get; }
Godot.Texture2D MapBotBg { public get; }
System.String MapBotBgPath { public get; }
Godot.Texture2D MapMidBg { public get; }
System.String MapMidBgPath { public get; }
Godot.Texture2D MapTopBg { public get; }
System.String MapTopBgPath { public get; }
Godot.Color MapTraveledColor { public abstract get; }
Godot.Color MapUntraveledColor { public abstract get; }
System.String[] MusicBankPaths { public abstract get; }
System.Int32 NumberOfWeakEncounters { protected virtual get; }
System.String RestSiteBackgroundPath { public get; }
MegaCrit.Sts2.Core.Models.EncounterModel SecondBossEncounter { public get; }
System.Boolean ShouldReceiveCombatHooks { public virtual get; }
MegaCrit.Sts2.Core.Localization.LocString Title { public get; }
protected .ctor()
private static System.Void AddWithoutRepeatingTags(System.Collections.Generic.ICollection<MegaCrit.Sts2.Core.Models.EncounterModel> encounters, MegaCrit.Sts2.Core.Helpers.GrabBag<MegaCrit.Sts2.Core.Models.EncounterModel> grabBag, MegaCrit.Sts2.Core.Random.Rng rng)
private System.Boolean <ValidateRoomsAfterLoad>b__95_0(MegaCrit.Sts2.Core.Models.EncounterModel e)
private System.Boolean <ValidateRoomsAfterLoad>b__95_1(MegaCrit.Sts2.Core.Models.EncounterModel e)
private System.Void set_CanonicalInstance(MegaCrit.Sts2.Core.Models.ActModel value)
protected abstract System.Int32 get_BaseNumberOfRooms()
protected abstract System.Void ApplyActDiscoveryOrderModifications(MegaCrit.Sts2.Core.Unlocks.UnlockState unlockState)
protected System.String get_FilePathIdentifier()
protected System.String GetFullLayerPath(System.String layerName)
protected virtual System.Int32 get_NumberOfWeakEncounters()
protected virtual System.Void DeepCloneFields()
public abstract Godot.Color get_MapBgColor()
public abstract Godot.Color get_MapTraveledColor()
public abstract Godot.Color get_MapUntraveledColor()
public abstract MegaCrit.Sts2.Core.Map.MapPointTypeCounts GetMapPointTypes(MegaCrit.Sts2.Core.Random.Rng mapRng)
public abstract System.Boolean get_IsDefault()
public abstract System.Boolean IsUnlocked(MegaCrit.Sts2.Core.Unlocks.UnlockState unlockState)
public abstract System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AncientEventModel> get_AllAncients()
public abstract System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AncientEventModel> GetUnlockedAncients(MegaCrit.Sts2.Core.Unlocks.UnlockState state)
public abstract System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.EncounterModel> GenerateAllEncounters()
public abstract System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.EncounterModel> get_BossDiscoveryOrder()
public abstract System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.EventModel> get_AllEvents()
public abstract System.Int32 get_Index()
public abstract System.String get_AmbientSfx()
public abstract System.String get_ChestOpenSfx()
public abstract System.String get_ChestSpineSkinNameNormal()
public abstract System.String get_ChestSpineSkinNameStroke()
public abstract System.String[] get_BgMusicOptions()
public abstract System.String[] get_MusicBankPaths()
public Godot.Control CreateRestSiteBackground()
public Godot.Texture2D get_MapBotBg()
public Godot.Texture2D get_MapMidBg()
public Godot.Texture2D get_MapTopBg()
public MegaCrit.Sts2.Core.Achievements.Achievement get_DefeatedAllEnemiesAchievement()
public MegaCrit.Sts2.Core.Localization.LocString get_Title()
public MegaCrit.Sts2.Core.Map.ActMap CreateMap(MegaCrit.Sts2.Core.Runs.RunState runState, System.Boolean replaceTreasureWithElites)
public MegaCrit.Sts2.Core.Models.ActModel get_CanonicalInstance()
public MegaCrit.Sts2.Core.Models.ActModel ToMutable()
public MegaCrit.Sts2.Core.Models.AncientEventModel get_Ancient()
public MegaCrit.Sts2.Core.Models.EncounterModel get_BossEncounter()
public MegaCrit.Sts2.Core.Models.EncounterModel get_SecondBossEncounter()
public MegaCrit.Sts2.Core.Models.EncounterModel PullNextEncounter(MegaCrit.Sts2.Core.Rooms.RoomType roomType)
public MegaCrit.Sts2.Core.Models.EventModel PullAncient()
public MegaCrit.Sts2.Core.Models.EventModel PullNextEvent(MegaCrit.Sts2.Core.Runs.RunState runState)
public MegaCrit.Sts2.Core.Rooms.BackgroundAssets GenerateBackgroundAssets(MegaCrit.Sts2.Core.Random.Rng rng)
public MegaCrit.Sts2.Core.Saves.Runs.SerializableActModel ToSave()
public static MegaCrit.Sts2.Core.Models.ActModel FromSave(MegaCrit.Sts2.Core.Saves.Runs.SerializableActModel save)
public static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.ActModel> GetRandomList(MegaCrit.Sts2.Core.Random.Rng rng, MegaCrit.Sts2.Core.Unlocks.UnlockState unlockState, System.Boolean isMultiplayer)
public static System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel> GetDefaultList()
public System.Boolean get_HasSecondBoss()
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.EncounterModel> get_AllBossEncounters()
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.EncounterModel> get_AllEliteEncounters()
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.EncounterModel> get_AllEncounters()
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.EncounterModel> get_AllRegularEncounters()
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.EncounterModel> get_AllWeakEncounters()
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.MonsterModel> get_AllMonsters()
public System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Collections.Generic.IEnumerable<System.String> GetAllBackgroundLayerPaths()
public System.Int32 GetNumberOfFloors(System.Boolean isMultiplayer)
public System.Int32 GetNumberOfRooms(System.Boolean isMultiplayer)
public System.String get_BackgroundScenePath()
public System.String get_MapBotBgPath()
public System.String get_MapMidBgPath()
public System.String get_MapTopBgPath()
public System.String get_RestSiteBackgroundPath()
public System.Void ApplyDiscoveryOrderModifications(MegaCrit.Sts2.Core.Unlocks.UnlockState unlockState)
public System.Void GenerateRooms(MegaCrit.Sts2.Core.Random.Rng rng, MegaCrit.Sts2.Core.Unlocks.UnlockState unlockState, System.Boolean isMultiplayer = False)
public System.Void MarkRoomVisited(MegaCrit.Sts2.Core.Rooms.RoomType roomType)
public System.Void RemoveEventFromSet(MegaCrit.Sts2.Core.Models.EventModel eventModel)
public System.Void SetBossEncounter(MegaCrit.Sts2.Core.Models.EncounterModel encounter)
public System.Void SetSecondBossEncounter(MegaCrit.Sts2.Core.Models.EncounterModel encounter)
public System.Void SetSharedAncientSubset(System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.AncientEventModel> sharedAncientSubset)
public System.Void ValidateRoomsAfterLoad(MegaCrit.Sts2.Core.Random.Rng rng)
public virtual MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSkeletonDataResource get_ChestSpineResource()
public virtual System.Boolean get_ShouldReceiveCombatHooks()
public virtual System.String get_ChestSpineResourcePath()
```

## MegaCrit.Sts2.Core.Models.CardModel

类型属性：`Public, Abstract, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Models.AbstractModel`。

接口：`System.IComparable<MegaCrit.Sts2.Core.Models.AbstractModel>`

```text
private System.Int32 _baseReplayCount
private System.Int32 _baseStarCost
private MegaCrit.Sts2.Core.Models.CardModel _canonicalInstance
private MegaCrit.Sts2.Core.Models.CardModel _cloneOf
private System.Int32 _currentPlayIndex
private MegaCrit.Sts2.Core.Entities.Creatures.Creature _currentTarget
private System.Int32 _currentUpgradeLevel
private MegaCrit.Sts2.Core.Models.CardModel _deckVersion
private MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVarSet _dynamicVars
private MegaCrit.Sts2.Core.Entities.Cards.CardEnergyCost _energyCost
private System.Boolean _exhaustOnNextPlay
private System.Nullable<System.Int32> _floorAddedToDeck
private System.Boolean _hasSingleTurnRetain
private System.Boolean _hasSingleTurnSly
private System.Boolean _isDupe
private System.Boolean _isEnchantmentPreview
private System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Entities.Cards.CardKeyword> _keywords
private System.Int32 _lastStarsSpent
private MegaCrit.Sts2.Core.Entities.Players.Player _owner
private MegaCrit.Sts2.Core.Models.CardPoolModel _pool
private System.Boolean _starCostSet
private System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Entities.Cards.CardTag> _tags
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Cards.TemporaryCardCost> _temporaryStarCosts
private MegaCrit.Sts2.Core.Localization.LocString _titleLocString
private MegaCrit.Sts2.Core.Entities.Cards.CardUpgradePreviewType _upgradePreviewType
private System.Boolean _wasStarCostJustUpgraded
private MegaCrit.Sts2.Core.Models.AfflictionModel <Affliction>k__BackingField
private readonly System.Int32 <CanonicalEnergyCost>k__BackingField
private MegaCrit.Sts2.Core.Models.EnchantmentModel <Enchantment>k__BackingField
private System.Boolean <HasBeenRemovedFromState>k__BackingField
private readonly MegaCrit.Sts2.Core.Entities.Cards.CardRarity <Rarity>k__BackingField
private readonly System.Boolean <ShouldShowInCardLibrary>k__BackingField
private readonly MegaCrit.Sts2.Core.Entities.Cards.TargetType <TargetType>k__BackingField
private readonly MegaCrit.Sts2.Core.Entities.Cards.CardType <Type>k__BackingField
private System.Action AfflictionChanged
private System.Action Drawn
private System.Action EnchantmentChanged
private System.Action EnergyCostChanged
private System.Action Forged
private System.Action KeywordsChanged
private System.Action Played
private System.Action ReplayCountChanged
private System.Action StarCostChanged
private System.Action Upgraded
MegaCrit.Sts2.Core.Models.AfflictionModel Affliction { public get; private set; }
System.Collections.Generic.IEnumerable<System.String> AllPortraitPaths { public virtual get; }
Godot.Texture2D AncientBorder { public get; }
System.String AncientBorderPath { private static get; }
Godot.Texture2D AncientTextBg { public get; }
System.String AncientTextBgPath { private get; }
Godot.Material BannerMaterial { public get; }
System.String BannerMaterialPath { private get; }
Godot.Texture2D BannerTexture { public get; }
System.String BannerTexturePath { private get; }
System.Int32 BaseReplayCount { public get; public set; }
System.Int32 BaseStarCost { public get; private set; }
System.String BetaPortraitPath { public virtual get; }
System.String BetaPortraitPngPath { private get; }
System.Boolean CanBeGeneratedByModifiers { public virtual get; }
System.Boolean CanBeGeneratedInCombat { public virtual get; }
System.Int32 CanonicalEnergyCost { protected virtual get; }
MegaCrit.Sts2.Core.Models.CardModel CanonicalInstance { public get; private set; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Cards.CardKeyword> CanonicalKeywords { public virtual get; }
System.Int32 CanonicalStarCost { public virtual get; }
System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Entities.Cards.CardTag> CanonicalTags { protected virtual get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar> CanonicalVars { protected virtual get; }
MegaCrit.Sts2.Core.Runs.ICardScope CardScope { public get; }
MegaCrit.Sts2.Core.Models.CardModel CloneOf { public get; }
MegaCrit.Sts2.Core.Combat.ICombatState CombatState { public get; }
System.Int32 CurrentPlayIndex { public get; private set; }
System.Int32 CurrentStarCost { public virtual get; }
MegaCrit.Sts2.Core.Entities.Creatures.Creature CurrentTarget { public get; private set; }
System.Int32 CurrentUpgradeLevel { public get; private set; }
MegaCrit.Sts2.Core.Models.CardModel DeckVersion { public get; public set; }
MegaCrit.Sts2.Core.Localization.LocString Description { public get; }
MegaCrit.Sts2.Core.Models.CardModel DupeOf { public get; }
MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVarSet DynamicVars { public get; }
MegaCrit.Sts2.Core.Models.EnchantmentModel Enchantment { public get; private set; }
MegaCrit.Sts2.Core.Entities.Cards.CardEnergyCost EnergyCost { public get; }
MegaCrit.Sts2.Core.HoverTips.IHoverTip EnergyHoverTip { protected get; }
Godot.Texture2D EnergyIcon { public get; }
System.String EnergyIconPath { private get; }
System.Boolean ExhaustOnNextPlay { public get; public set; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.HoverTips.IHoverTip> ExtraHoverTips { protected virtual get; }
System.Collections.Generic.IEnumerable<System.String> ExtraRunAssetPaths { protected virtual get; }
System.Nullable<System.Int32> FloorAddedToDeck { public get; public set; }
Godot.Texture2D Frame { public get; }
Godot.Material FrameMaterial { public get; }
System.String FramePath { private get; }
System.Boolean GainsBlock { public virtual get; }
System.Boolean HasBeenRemovedFromState { public get; public set; }
System.Boolean HasBetaPortrait { public get; }
System.Boolean HasBuiltInOverlay { public virtual get; }
System.Boolean HasEnergyCostX { protected virtual get; }
System.Boolean HasPortrait { public get; }
System.Boolean HasSingleTurnRetain { private get; private set; }
System.Boolean HasSingleTurnSly { private get; private set; }
System.Boolean HasStarCostX { public virtual get; }
System.Boolean HasTurnEndInHandEffect { public virtual get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.HoverTips.IHoverTip> HoverTips { public get; }
System.Boolean IsBasicStrikeOrDefend { public virtual get; }
System.Boolean IsClone { public get; }
System.Boolean IsDupe { public get; private set; }
System.Boolean IsEnchantmentPreview { public get; public set; }
System.Boolean IsInCombat { public get; }
System.Boolean IsPlayable { protected virtual get; }
System.Boolean IsRemovable { public get; }
System.Boolean IsSlyThisTurn { public get; }
System.Boolean IsTransformable { public get; }
System.Boolean IsUpgradable { public get; }
System.Boolean IsUpgraded { public get; }
System.Collections.Generic.IReadOnlySet<MegaCrit.Sts2.Core.Entities.Cards.CardKeyword> Keywords { public get; }
System.Int32 LastStarsSpent { public get; public set; }
System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Entities.Cards.CardKeyword> LocalKeywords { private get; }
System.Int32 MaxUpgradeLevel { public virtual get; }
System.String MissingPortraitPath { public static get; }
MegaCrit.Sts2.Core.Entities.Cards.CardMultiplayerConstraint MultiplayerConstraint { public virtual get; }
MegaCrit.Sts2.Core.Entities.Cards.OrbEvokeType OrbEvokeType { public virtual get; }
System.String OverlayPath { public get; }
MegaCrit.Sts2.Core.Entities.Players.Player Owner { public get; public set; }
MegaCrit.Sts2.Core.Entities.Cards.CardPile Pile { public get; }
MegaCrit.Sts2.Core.Models.CardPoolModel Pool { public virtual get; }
Godot.Texture2D Portrait { public get; }
Godot.Texture2D PortraitBorder { public get; }
System.String PortraitBorderPath { private get; }
System.String PortraitPath { public virtual get; }
System.String PortraitPngPath { protected virtual get; }
MegaCrit.Sts2.Core.Entities.Cards.CardRarity Rarity { public virtual get; }
System.Collections.Generic.IEnumerable<System.String> RunAssetPaths { public get; }
MegaCrit.Sts2.Core.Runs.IRunState RunState { public get; }
MegaCrit.Sts2.Core.Localization.LocString SelectionScreenPrompt { protected get; }
System.Boolean ShouldGlowGold { public get; }
System.Boolean ShouldGlowGoldInternal { protected virtual get; }
System.Boolean ShouldGlowRed { public get; }
System.Boolean ShouldGlowRedInternal { protected virtual get; }
System.Boolean ShouldReceiveCombatHooks { public virtual get; }
System.Boolean ShouldRetainThisTurn { public get; }
System.Boolean ShouldShowInCardLibrary { public get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Cards.CardTag> Tags { public virtual get; }
MegaCrit.Sts2.Core.Entities.Cards.TargetType TargetType { public virtual get; }
MegaCrit.Sts2.Core.Entities.Cards.TemporaryCardCost TemporaryStarCost { public get; }
System.String Title { public virtual get; }
MegaCrit.Sts2.Core.Localization.LocString TitleLocString { public get; }
MegaCrit.Sts2.Core.Entities.Cards.CardType Type { public virtual get; }
MegaCrit.Sts2.Core.Entities.Cards.CardUpgradePreviewType UpgradePreviewType { public get; public set; }
MegaCrit.Sts2.Core.Models.CardPoolModel VisualCardPool { public virtual get; }
System.Boolean WasStarCostJustUpgraded { public get; }
event System.Action AfflictionChanged
event System.Action Drawn
event System.Action EnchantmentChanged
event System.Action EnergyCostChanged
event System.Action Forged
event System.Action KeywordsChanged
event System.Action Played
event System.Action ReplayCountChanged
event System.Action StarCostChanged
event System.Action Upgraded
protected .ctor(System.Int32 canonicalEnergyCost, MegaCrit.Sts2.Core.Entities.Cards.CardType type, MegaCrit.Sts2.Core.Entities.Cards.CardRarity rarity, MegaCrit.Sts2.Core.Entities.Cards.TargetType targetType, System.Boolean shouldShowInCardLibrary = True)
private [async] System.Threading.Tasks.Task PlayPowerCardFlyVfx()
private [async] System.Threading.Tasks.Task SpendEnergy(System.Int32 amount)
private [async] System.Threading.Tasks.Task SpendStars(System.Int32 amount)
private static System.String get_AncientBorderPath()
private System.Boolean <get_Pile>b__107_0(MegaCrit.Sts2.Core.Entities.Cards.CardPile p)
private System.Boolean <get_Pool>b__99_0(MegaCrit.Sts2.Core.Models.CardPoolModel pool)
private System.Boolean <UpgradeStarCostBy>b__301_0(MegaCrit.Sts2.Core.Entities.Cards.TemporaryCardCost c)
private System.Boolean get_HasSingleTurnRetain()
private System.Boolean get_HasSingleTurnSly()
private System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Entities.Cards.CardKeyword> get_LocalKeywords()
private System.String get_AncientTextBgPath()
private System.String get_BannerMaterialPath()
private System.String get_BannerTexturePath()
private System.String get_BetaPortraitPngPath()
private System.String get_EnergyIconPath()
private System.String get_FramePath()
private System.String get_PortraitBorderPath()
private System.String GetDescriptionForPile(MegaCrit.Sts2.Core.Entities.Cards.PileType pileType, MegaCrit.Sts2.Core.Models.CardModel+DescriptionPreviewType previewType, MegaCrit.Sts2.Core.Entities.Creatures.Creature target = null)
private System.Void AddTemporaryStarCost(MegaCrit.Sts2.Core.Entities.Cards.TemporaryCardCost cost)
private System.Void EnqueueManualPlay(MegaCrit.Sts2.Core.Entities.Creatures.Creature target)
private System.Void set_Affliction(MegaCrit.Sts2.Core.Models.AfflictionModel value)
private System.Void set_BaseStarCost(System.Int32 value)
private System.Void set_CanonicalInstance(MegaCrit.Sts2.Core.Models.CardModel value)
private System.Void set_CurrentPlayIndex(System.Int32 value)
private System.Void set_CurrentTarget(MegaCrit.Sts2.Core.Entities.Creatures.Creature value)
private System.Void set_CurrentUpgradeLevel(System.Int32 value)
private System.Void set_Enchantment(MegaCrit.Sts2.Core.Models.EnchantmentModel value)
private System.Void set_HasSingleTurnRetain(System.Boolean value)
private System.Void set_HasSingleTurnSly(System.Boolean value)
private System.Void set_IsDupe(System.Boolean value)
protected [async] System.Threading.Tasks.Task<System.Int32> GeneratePlayCount(MegaCrit.Sts2.Core.Combat.ICombatState combatState, MegaCrit.Sts2.Core.Entities.Creatures.Creature target)
protected MegaCrit.Sts2.Core.HoverTips.IHoverTip get_EnergyHoverTip()
protected MegaCrit.Sts2.Core.Localization.LocString get_SelectionScreenPrompt()
protected System.Void MockSetEnergyCost(MegaCrit.Sts2.Core.Entities.Cards.CardEnergyCost cost)
protected System.Void NeverEverCallThisOutsideOfTests_ClearOwner()
protected System.Void UpgradeStarCostBy(System.Int32 addend)
protected virtual MegaCrit.Sts2.Core.Entities.Cards.CardLocation GetResultLocationForCardPlay()
protected virtual System.Boolean get_HasEnergyCostX()
protected virtual System.Boolean get_IsPlayable()
protected virtual System.Boolean get_ShouldGlowGoldInternal()
protected virtual System.Boolean get_ShouldGlowRedInternal()
protected virtual System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Entities.Cards.CardTag> get_CanonicalTags()
protected virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.HoverTips.IHoverTip> get_ExtraHoverTips()
protected virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar> get_CanonicalVars()
protected virtual System.Collections.Generic.IEnumerable<System.String> get_ExtraRunAssetPaths()
protected virtual System.Int32 get_CanonicalEnergyCost()
protected virtual System.String get_PortraitPngPath()
protected virtual System.Threading.Tasks.Task OnPlay(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Cards.CardPlay cardPlay)
protected virtual System.Threading.Tasks.Task OnTurnEndInHand(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext)
protected virtual System.Void AddExtraArgsToDescription(MegaCrit.Sts2.Core.Localization.LocString description)
protected virtual System.Void AfterCloned()
protected virtual System.Void AfterDeserialized()
protected virtual System.Void AfterDowngraded()
protected virtual System.Void DeepCloneFields()
protected virtual System.Void OnUpgrade()
public [async] System.Threading.Tasks.Task MoveToResultPileWithoutPlaying(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext)
public [async] System.Threading.Tasks.Task OnPlayWrapper(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Creatures.Creature target, System.Boolean isAutoPlay, MegaCrit.Sts2.Core.Entities.Cards.ResourceInfo resources, System.Boolean skipCardPileVisuals = False)
public [async] System.Threading.Tasks.Task<System.ValueTuple<System.Int32, System.Int32>> SpendResources()
public Godot.Control CreateOverlay()
public Godot.Material get_BannerMaterial()
public Godot.Material get_FrameMaterial()
public Godot.Texture2D get_AncientBorder()
public Godot.Texture2D get_AncientTextBg()
public Godot.Texture2D get_BannerTexture()
public Godot.Texture2D get_EnergyIcon()
public Godot.Texture2D get_Frame()
public Godot.Texture2D get_Portrait()
public Godot.Texture2D get_PortraitBorder()
public MegaCrit.Sts2.Core.Combat.ICombatState get_CombatState()
public MegaCrit.Sts2.Core.Entities.Cards.CardEnergyCost get_EnergyCost()
public MegaCrit.Sts2.Core.Entities.Cards.CardPile get_Pile()
public MegaCrit.Sts2.Core.Entities.Cards.CardUpgradePreviewType get_UpgradePreviewType()
public MegaCrit.Sts2.Core.Entities.Cards.TemporaryCardCost get_TemporaryStarCost()
public MegaCrit.Sts2.Core.Entities.Creatures.Creature get_CurrentTarget()
public MegaCrit.Sts2.Core.Entities.Players.Player get_Owner()
public MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVarSet get_DynamicVars()
public MegaCrit.Sts2.Core.Localization.LocString get_Description()
public MegaCrit.Sts2.Core.Localization.LocString get_TitleLocString()
public MegaCrit.Sts2.Core.Models.AfflictionModel get_Affliction()
public MegaCrit.Sts2.Core.Models.CardModel CreateClone()
public MegaCrit.Sts2.Core.Models.CardModel CreateCloneForPlayer(MegaCrit.Sts2.Core.Entities.Players.Player player)
public MegaCrit.Sts2.Core.Models.CardModel CreateDupe(MegaCrit.Sts2.Core.Entities.Players.Player newOwner)
public MegaCrit.Sts2.Core.Models.CardModel get_CanonicalInstance()
public MegaCrit.Sts2.Core.Models.CardModel get_CloneOf()
public MegaCrit.Sts2.Core.Models.CardModel get_DeckVersion()
public MegaCrit.Sts2.Core.Models.CardModel get_DupeOf()
public MegaCrit.Sts2.Core.Models.CardModel ToMutable()
public MegaCrit.Sts2.Core.Models.EnchantmentModel get_Enchantment()
public MegaCrit.Sts2.Core.Runs.ICardScope get_CardScope()
public MegaCrit.Sts2.Core.Runs.IRunState get_RunState()
public MegaCrit.Sts2.Core.Saves.Runs.SerializableCard ToSerializable()
public static MegaCrit.Sts2.Core.Models.CardModel FromSerializable(MegaCrit.Sts2.Core.Saves.Runs.SerializableCard save)
public static System.String get_MissingPortraitPath()
public System.Boolean CanPlay()
public System.Boolean CanPlay(out MegaCrit.Sts2.Core.Entities.Cards.UnplayableReason reason, out MegaCrit.Sts2.Core.Models.AbstractModel preventer)
public System.Boolean CanPlayTargeting(MegaCrit.Sts2.Core.Entities.Creatures.Creature target)
public System.Boolean CostsEnergyOrStars(System.Boolean includeGlobalModifiers)
public System.Boolean get_ExhaustOnNextPlay()
public System.Boolean get_HasBeenRemovedFromState()
public System.Boolean get_HasBetaPortrait()
public System.Boolean get_HasPortrait()
public System.Boolean get_IsClone()
public System.Boolean get_IsDupe()
public System.Boolean get_IsEnchantmentPreview()
public System.Boolean get_IsInCombat()
public System.Boolean get_IsRemovable()
public System.Boolean get_IsSlyThisTurn()
public System.Boolean get_IsTransformable()
public System.Boolean get_IsUpgradable()
public System.Boolean get_IsUpgraded()
public System.Boolean get_ShouldGlowGold()
public System.Boolean get_ShouldGlowRed()
public System.Boolean get_ShouldRetainThisTurn()
public System.Boolean get_ShouldShowInCardLibrary()
public System.Boolean get_WasStarCostJustUpgraded()
public System.Boolean IsValidTarget(MegaCrit.Sts2.Core.Entities.Creatures.Creature target)
public System.Boolean TryManualPlay(MegaCrit.Sts2.Core.Entities.Creatures.Creature target)
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.HoverTips.IHoverTip> get_HoverTips()
public System.Collections.Generic.IEnumerable<System.String> get_RunAssetPaths()
public System.Collections.Generic.IReadOnlySet<MegaCrit.Sts2.Core.Entities.Cards.CardKeyword> get_Keywords()
public System.Collections.Generic.IReadOnlySet<MegaCrit.Sts2.Core.Entities.Cards.CardKeyword> GetKeywordsWithSources(MegaCrit.Sts2.Core.Entities.Cards.KeywordSources sources)
public System.Int32 get_BaseReplayCount()
public System.Int32 get_BaseStarCost()
public System.Int32 get_CurrentPlayIndex()
public System.Int32 get_CurrentUpgradeLevel()
public System.Int32 get_LastStarsSpent()
public System.Int32 GetEnchantedReplayCount()
public System.Int32 GetStarCostThisCombat()
public System.Int32 GetStarCostWithModifiers()
public System.Int32 ResolveEnergyXValue()
public System.Int32 ResolveStarXValue()
public System.Nullable<System.Int32> get_FloorAddedToDeck()
public System.String get_OverlayPath()
public System.String GetDescriptionForPile(MegaCrit.Sts2.Core.Entities.Cards.PileType pileType, MegaCrit.Sts2.Core.Entities.Creatures.Creature target = null)
public System.String GetDescriptionForUpgradePreview()
public System.Threading.Tasks.Task OnTurnEndInHandWrapper(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext)
public System.Void add_AfflictionChanged(System.Action value)
public System.Void add_Drawn(System.Action value)
public System.Void add_EnchantmentChanged(System.Action value)
public System.Void add_EnergyCostChanged(System.Action value)
public System.Void add_Forged(System.Action value)
public System.Void add_KeywordsChanged(System.Action value)
public System.Void add_Played(System.Action value)
public System.Void add_ReplayCountChanged(System.Action value)
public System.Void add_StarCostChanged(System.Action value)
public System.Void add_Upgraded(System.Action value)
public System.Void AddKeyword(MegaCrit.Sts2.Core.Entities.Cards.CardKeyword keyword)
public System.Void AfflictInternal(MegaCrit.Sts2.Core.Models.AfflictionModel affliction, System.Decimal amount)
public System.Void AfterForged()
public System.Void ClearAfflictionInternal()
public System.Void ClearEnchantmentInternal()
public System.Void DowngradeInternal()
public System.Void EnchantInternal(MegaCrit.Sts2.Core.Models.EnchantmentModel enchantment, System.Decimal amount)
public System.Void EndOfTurnCleanup()
public System.Void FinalizeUpgradeInternal()
public System.Void GiveSingleTurnRetain()
public System.Void GiveSingleTurnSly()
public System.Void GiveToAnotherPlayer(MegaCrit.Sts2.Core.Entities.Players.Player player)
public System.Void InvokeDrawn()
public System.Void InvokeEnergyCostChanged()
public System.Void remove_AfflictionChanged(System.Action value)
public System.Void remove_Drawn(System.Action value)
public System.Void remove_EnchantmentChanged(System.Action value)
public System.Void remove_EnergyCostChanged(System.Action value)
public System.Void remove_Forged(System.Action value)
public System.Void remove_KeywordsChanged(System.Action value)
public System.Void remove_Played(System.Action value)
public System.Void remove_ReplayCountChanged(System.Action value)
public System.Void remove_StarCostChanged(System.Action value)
public System.Void remove_Upgraded(System.Action value)
public System.Void RemoveFromCurrentPile(System.Boolean silent = False)
public System.Void RemoveFromState()
public System.Void RemoveKeyword(MegaCrit.Sts2.Core.Entities.Cards.CardKeyword keyword)
public System.Void set_BaseReplayCount(System.Int32 value)
public System.Void set_DeckVersion(MegaCrit.Sts2.Core.Models.CardModel value)
public System.Void set_ExhaustOnNextPlay(System.Boolean value)
public System.Void set_FloorAddedToDeck(System.Nullable<System.Int32> value)
public System.Void set_HasBeenRemovedFromState(System.Boolean value)
public System.Void set_IsEnchantmentPreview(System.Boolean value)
public System.Void set_LastStarsSpent(System.Int32 value)
public System.Void set_Owner(MegaCrit.Sts2.Core.Entities.Players.Player value)
public System.Void set_UpgradePreviewType(MegaCrit.Sts2.Core.Entities.Cards.CardUpgradePreviewType value)
public System.Void SetStarCostThisCombat(System.Int32 cost)
public System.Void SetStarCostThisTurn(System.Int32 cost)
public System.Void SetStarCostUntilPlayed(System.Int32 cost)
public System.Void SetToFreeThisCombat()
public System.Void SetToFreeThisTurn()
public System.Void UpdateDynamicVarPreview(MegaCrit.Sts2.Core.Entities.Cards.CardPreviewMode previewMode, MegaCrit.Sts2.Core.Entities.Creatures.Creature target, MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVarSet dynamicVarSet)
public System.Void UpgradeInternal()
public virtual MegaCrit.Sts2.Core.Entities.Cards.CardMultiplayerConstraint get_MultiplayerConstraint()
public virtual MegaCrit.Sts2.Core.Entities.Cards.CardRarity get_Rarity()
public virtual MegaCrit.Sts2.Core.Entities.Cards.CardType get_Type()
public virtual MegaCrit.Sts2.Core.Entities.Cards.OrbEvokeType get_OrbEvokeType()
public virtual MegaCrit.Sts2.Core.Entities.Cards.TargetType get_TargetType()
public virtual MegaCrit.Sts2.Core.Models.CardPoolModel get_Pool()
public virtual MegaCrit.Sts2.Core.Models.CardPoolModel get_VisualCardPool()
public virtual System.Boolean get_CanBeGeneratedByModifiers()
public virtual System.Boolean get_CanBeGeneratedInCombat()
public virtual System.Boolean get_GainsBlock()
public virtual System.Boolean get_HasBuiltInOverlay()
public virtual System.Boolean get_HasStarCostX()
public virtual System.Boolean get_HasTurnEndInHandEffect()
public virtual System.Boolean get_IsBasicStrikeOrDefend()
public virtual System.Boolean get_ShouldReceiveCombatHooks()
public virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Cards.CardKeyword> get_CanonicalKeywords()
public virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Cards.CardTag> get_Tags()
public virtual System.Collections.Generic.IEnumerable<System.String> get_AllPortraitPaths()
public virtual System.Int32 CompareTo(MegaCrit.Sts2.Core.Models.AbstractModel other)
public virtual System.Int32 get_CanonicalStarCost()
public virtual System.Int32 get_CurrentStarCost()
public virtual System.Int32 get_MaxUpgradeLevel()
public virtual System.String get_BetaPortraitPath()
public virtual System.String get_PortraitPath()
public virtual System.String get_Title()
public virtual System.Threading.Tasks.Task OnEnqueuePlayVfx(MegaCrit.Sts2.Core.Entities.Creatures.Creature target)
public virtual System.Void AfterCreated()
public virtual System.Void AfterTransformedFrom()
public virtual System.Void AfterTransformedTo()
```

## MegaCrit.Sts2.Core.Models.EncounterModel

类型属性：`Public, Abstract, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Models.AbstractModel`。

接口：`System.IComparable<MegaCrit.Sts2.Core.Models.AbstractModel>`

```text
private MegaCrit.Sts2.Core.Rooms.BackgroundAssets _backgroundAssets
private MegaCrit.Sts2.Core.Models.EncounterModel _canonicalInstance
private static const System.String _locTable = "encounters"
private System.Collections.Generic.IReadOnlyList<System.ValueTuple<MegaCrit.Sts2.Core.Models.MonsterModel, System.String>> _monstersWithSlots
private MegaCrit.Sts2.Core.Random.Rng _rng
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.MonsterModel> _spawnedEnemies
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.MonsterModel> AllPossibleMonsters { public abstract get; }
System.String AmbientSfx { public virtual get; }
System.String BossNodePath { public virtual get; }
MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSkeletonDataResource BossNodeSpineResource { public virtual get; }
MegaCrit.Sts2.Core.Models.EncounterModel CanonicalInstance { public get; private set; }
System.String CustomBgm { public virtual get; }
MegaCrit.Sts2.Core.Localization.LocString CustomRewardDescription { public get; }
System.Collections.Generic.IEnumerable<System.String> ExtraAssetPaths { public virtual get; }
System.Boolean FullyCenterPlayers { public virtual get; }
System.Boolean HasAmbientSfx { public get; }
System.Boolean HasBgm { public get; }
System.Boolean HasCustomBackground { protected virtual get; }
System.Boolean HasScene { public virtual get; }
System.Boolean HaveMonstersBeenGenerated { public get; }
System.Boolean IsWeak { public virtual get; }
System.Collections.Generic.IEnumerable<System.String> MapNodeAssetPaths { public get; }
System.Int32 MaxGoldReward { public virtual get; }
System.Int32 MinGoldReward { public virtual get; }
System.Collections.Generic.IReadOnlyList<System.ValueTuple<MegaCrit.Sts2.Core.Models.MonsterModel, System.String>> MonstersWithSlots { public get; }
MegaCrit.Sts2.Core.Random.Rng Rng { protected get; }
MegaCrit.Sts2.Core.Rooms.RoomType RoomType { public abstract get; }
System.String ScenePath { private get; }
System.Boolean ShouldGiveRewards { public virtual get; }
System.Boolean ShouldReceiveCombatHooks { public virtual get; }
System.Collections.Generic.IReadOnlyList<System.String> Slots { public virtual get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.MonsterModel> SpawnedEnemies { public get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Encounters.EncounterTag> Tags { public virtual get; }
MegaCrit.Sts2.Core.Localization.LocString Title { public get; }
protected .ctor()
private MegaCrit.Sts2.Core.Rooms.BackgroundAssets CreateBackgroundAssetsForCustom(MegaCrit.Sts2.Core.Random.Rng rng)
private MegaCrit.Sts2.Core.Rooms.BackgroundAssets GetBackgroundAssets(MegaCrit.Sts2.Core.Models.ActModel parentAct, MegaCrit.Sts2.Core.Random.Rng rng)
private static MegaCrit.Sts2.Core.Localization.LocString L10NLookup(System.String key)
private System.String get_ScenePath()
private System.Void set_CanonicalInstance(MegaCrit.Sts2.Core.Models.EncounterModel value)
protected abstract System.Collections.Generic.IReadOnlyList<System.ValueTuple<MegaCrit.Sts2.Core.Models.MonsterModel, System.String>> GenerateMonsters()
protected MegaCrit.Sts2.Core.Random.Rng get_Rng()
protected virtual System.Boolean get_HasCustomBackground()
public abstract MegaCrit.Sts2.Core.Rooms.RoomType get_RoomType()
public abstract System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.MonsterModel> get_AllPossibleMonsters()
public Godot.Control CreateScene()
public MegaCrit.Sts2.Core.Localization.LocString get_CustomRewardDescription()
public MegaCrit.Sts2.Core.Localization.LocString get_Title()
public MegaCrit.Sts2.Core.Localization.LocString GetLossMessageFor(MegaCrit.Sts2.Core.Models.CharacterModel character)
public MegaCrit.Sts2.Core.Models.EncounterModel get_CanonicalInstance()
public MegaCrit.Sts2.Core.Models.EncounterModel ToMutable()
public MegaCrit.Sts2.Core.Nodes.Rooms.NCombatBackground CreateBackground(MegaCrit.Sts2.Core.Models.ActModel parentAct, MegaCrit.Sts2.Core.Random.Rng rng)
public System.Boolean get_HasAmbientSfx()
public System.Boolean get_HasBgm()
public System.Boolean get_HaveMonstersBeenGenerated()
public System.Boolean SharesTagsWith(MegaCrit.Sts2.Core.Models.EncounterModel other)
public System.Collections.Generic.IEnumerable<System.String> get_MapNodeAssetPaths()
public System.Collections.Generic.IEnumerable<System.String> GetAssetPaths(MegaCrit.Sts2.Core.Runs.IRunState runState)
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.MonsterModel> get_SpawnedEnemies()
public System.Collections.Generic.IReadOnlyList<System.ValueTuple<MegaCrit.Sts2.Core.Models.MonsterModel, System.String>> get_MonstersWithSlots()
public System.String GetNextSlot(MegaCrit.Sts2.Core.Combat.ICombatState combatState)
public System.Void DebugRandomizeRng()
public System.Void GenerateMonstersWithSlots(MegaCrit.Sts2.Core.Runs.IRunState runState)
public System.Void OnCreatureSpawned(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public virtual Godot.Vector2 GetCameraOffset()
public virtual MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSkeletonDataResource get_BossNodeSpineResource()
public virtual System.Boolean get_FullyCenterPlayers()
public virtual System.Boolean get_HasScene()
public virtual System.Boolean get_IsWeak()
public virtual System.Boolean get_ShouldGiveRewards()
public virtual System.Boolean get_ShouldReceiveCombatHooks()
public virtual System.Collections.Generic.Dictionary<System.String, System.String> SaveCustomState()
public virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Encounters.EncounterTag> get_Tags()
public virtual System.Collections.Generic.IEnumerable<System.String> get_ExtraAssetPaths()
public virtual System.Collections.Generic.IReadOnlyList<System.String> get_Slots()
public virtual System.Int32 get_MaxGoldReward()
public virtual System.Int32 get_MinGoldReward()
public virtual System.Single CalculateGoldProportion(MegaCrit.Sts2.Core.Combat.CombatState combatState)
public virtual System.Single GetCameraScaling()
public virtual System.String get_AmbientSfx()
public virtual System.String get_BossNodePath()
public virtual System.String get_CustomBgm()
public virtual System.Void LoadCustomState(System.Collections.Generic.Dictionary<System.String, System.String> state)
```

## MegaCrit.Sts2.Core.Models.ModelDb

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.AchievementModel> _achievements
private static System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ActModel> _acts
private static System.Collections.Generic.List<System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ActModel>> _actsByIndex
private static System.Type[] _allAbstractModelSubtypes
private static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardPoolModel> _allCardPools
private static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> _allCards
private static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardPoolModel> _allCharacterCardPools
private static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.PotionPoolModel> _allCharacterPotionPools
private static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.RelicPoolModel> _allCharacterRelicPools
private static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.EncounterModel> _allEncounters
private static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.EventModel> _allEvents
private static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.PotionPoolModel> _allPotionPools
private static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.PotionModel> _allPotions
private static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.PowerModel> _allPowers
private static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.RelicModel> _allRelics
private static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.EventModel> _allSharedEvents
private static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.PotionPoolModel> _allSharedPotionPools
private static System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.BadgeModel> _badges
private static readonly System.Collections.Generic.Dictionary<MegaCrit.Sts2.Core.Models.ModelId, MegaCrit.Sts2.Core.Models.AbstractModel> _contentById
private static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.EncounterModel> _eventEncounters
private static const System.Int32 _initialCapacity = 4096
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.AchievementModel> Achievements { public static get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.ActModel> Acts { public static get; }
System.Collections.Generic.IReadOnlyList<System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel>> ActsByIndex { public static get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AbstractModel> All { public static get; }
System.Type[] AllAbstractModelSubtypes { public static get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AncientEventModel> AllAncients { public static get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardPoolModel> AllCardPools { public static get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> AllCards { public static get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardPoolModel> AllCharacterCardPools { public static get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.PotionPoolModel> AllCharacterPotionPools { public static get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.RelicPoolModel> AllCharacterRelicPools { public static get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CharacterModel> AllCharacters { public static get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.EncounterModel> AllEncounters { public static get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.EventModel> AllEvents { public static get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.PotionPoolModel> AllPotionPools { public static get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.PotionModel> AllPotions { public static get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.PowerModel> AllPowers { public static get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.RelicPoolModel> AllRelicPools { public static get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.RelicModel> AllRelics { public static get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AncientEventModel> AllSharedAncients { public static get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardPoolModel> AllSharedCardPools { public static get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.EventModel> AllSharedEvents { public static get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.PotionPoolModel> AllSharedPotionPools { private static get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.RelicPoolModel> AllSharedRelicPools { private static get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.BadgeModel> BadgeModels { public static get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel> BadModifiers { public static get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.RelicPoolModel> CharacterRelicPools { public static get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AfflictionModel> DebugAfflictions { public static get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.EnchantmentModel> DebugEnchantments { public static get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.EncounterModel> EventEncounters { public static get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel> GoodModifiers { public static get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.MonsterModel> Monsters { public static get; }
System.Collections.Generic.IReadOnlyList<System.Collections.Generic.IReadOnlySet<MegaCrit.Sts2.Core.Models.ModifierModel>> MutuallyExclusiveModifiers { public static get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.OrbModel> Orbs { public static get; }
private static .cctor()
private static MegaCrit.Sts2.Core.Models.AbstractModel Get(System.Type type)
private static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.PotionPoolModel> get_AllSharedPotionPools()
private static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.RelicPoolModel> get_AllSharedRelicPools()
private static T Get<T>() where T: [None] MegaCrit.Sts2.Core.Models.AbstractModel
public static MegaCrit.Sts2.Core.Models.ModelId GetId(System.Type type)
public static MegaCrit.Sts2.Core.Models.ModelId GetId<T>() where T: [None] MegaCrit.Sts2.Core.Models.AbstractModel
public static MegaCrit.Sts2.Core.Models.OrbModel DebugOrb(System.Type type)
public static MegaCrit.Sts2.Core.Models.PowerModel DebugPower(System.Type type)
public static System.Boolean Contains(System.Type type)
public static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AbstractModel> get_All()
public static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.ActModel> get_Acts()
public static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AfflictionModel> get_DebugAfflictions()
public static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AncientEventModel> get_AllAncients()
public static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.AncientEventModel> get_AllSharedAncients()
public static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> get_AllCards()
public static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardPoolModel> get_AllCardPools()
public static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardPoolModel> get_AllCharacterCardPools()
public static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardPoolModel> get_AllSharedCardPools()
public static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CharacterModel> get_AllCharacters()
public static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.EnchantmentModel> get_DebugEnchantments()
public static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.EncounterModel> get_AllEncounters()
public static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.EncounterModel> get_EventEncounters()
public static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.EventModel> get_AllEvents()
public static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.EventModel> get_AllSharedEvents()
public static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.MonsterModel> get_Monsters()
public static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.OrbModel> get_Orbs()
public static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.PotionModel> get_AllPotions()
public static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.PotionPoolModel> get_AllCharacterPotionPools()
public static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.PotionPoolModel> get_AllPotionPools()
public static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.PowerModel> get_AllPowers()
public static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.RelicModel> get_AllRelics()
public static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.RelicPoolModel> get_AllCharacterRelicPools()
public static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.RelicPoolModel> get_AllRelicPools()
public static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.RelicPoolModel> get_CharacterRelicPools()
public static System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.AchievementModel> get_Achievements()
public static System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.BadgeModel> get_BadgeModels()
public static System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel> get_BadModifiers()
public static System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ModifierModel> get_GoodModifiers()
public static System.Collections.Generic.IReadOnlyList<System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.ActModel>> get_ActsByIndex()
public static System.Collections.Generic.IReadOnlyList<System.Collections.Generic.IReadOnlySet<MegaCrit.Sts2.Core.Models.ModifierModel>> get_MutuallyExclusiveModifiers()
public static System.String GetCategory(System.Type type)
public static System.String GetEntry(System.Type type)
public static System.Type GetCategoryType(System.Type type)
public static System.Type[] get_AllAbstractModelSubtypes()
public static System.Void Init(System.Type[] injectedModelTypes = null)
public static System.Void InitIds()
public static System.Void Inject(System.Type type)
public static System.Void Preload()
public static System.Void Remove(System.Type type)
public static System.Void ResetForTest()
public static T Achievement<T>() where T: [None] MegaCrit.Sts2.Core.Models.AchievementModel
public static T Act<T>() where T: [None] MegaCrit.Sts2.Core.Models.ActModel
public static T Affliction<T>() where T: [None] MegaCrit.Sts2.Core.Models.AfflictionModel
public static T AncientEvent<T>() where T: [None] MegaCrit.Sts2.Core.Models.AncientEventModel
public static T Badge<T>() where T: [None] MegaCrit.Sts2.Core.Models.BadgeModel
public static T Card<T>() where T: [None] MegaCrit.Sts2.Core.Models.CardModel
public static T CardPool<T>() where T: [None] MegaCrit.Sts2.Core.Models.CardPoolModel
public static T Character<T>() where T: [None] MegaCrit.Sts2.Core.Models.CharacterModel
public static T Enchantment<T>() where T: [None] MegaCrit.Sts2.Core.Models.EnchantmentModel
public static T Encounter<T>() where T: [None] MegaCrit.Sts2.Core.Models.EncounterModel
public static T Event<T>() where T: [None] MegaCrit.Sts2.Core.Models.EventModel
public static T GetById<T>(MegaCrit.Sts2.Core.Models.ModelId id) where T: [None] MegaCrit.Sts2.Core.Models.AbstractModel
public static T GetByIdOrNull<T>(MegaCrit.Sts2.Core.Models.ModelId id) where T: [None] MegaCrit.Sts2.Core.Models.AbstractModel
public static T Modifier<T>() where T: [None] MegaCrit.Sts2.Core.Models.ModifierModel
public static T Monster<T>() where T: [None] MegaCrit.Sts2.Core.Models.MonsterModel
public static T Orb<T>() where T: [None] MegaCrit.Sts2.Core.Models.OrbModel
public static T Potion<T>() where T: [None] MegaCrit.Sts2.Core.Models.PotionModel
public static T PotionPool<T>() where T: [None] MegaCrit.Sts2.Core.Models.PotionPoolModel
public static T Power<T>() where T: [None] MegaCrit.Sts2.Core.Models.PowerModel
public static T Relic<T>() where T: [None] MegaCrit.Sts2.Core.Models.RelicModel
public static T RelicPool<T>() where T: [None] MegaCrit.Sts2.Core.Models.RelicPoolModel
public static T Singleton<T>() where T: [None] MegaCrit.Sts2.Core.Models.SingletonModel
```

## MegaCrit.Sts2.Core.Models.MonsterModel

类型属性：`Public, Abstract, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Models.AbstractModel`。

接口：`System.IComparable<MegaCrit.Sts2.Core.Models.AbstractModel>`

```text
private MegaCrit.Sts2.Core.Models.MonsterModel _canonicalInstance
private MegaCrit.Sts2.Core.Entities.Creatures.Creature _creature
private static readonly System.String _fallbackVisualsPath
private System.Boolean _isPerformingMove
protected static const System.String _locTableName = "monsters"
private MegaCrit.Sts2.Core.MonsterMoves.MonsterMoveStateMachine.MonsterMoveStateMachine _moveStateMachine
private MegaCrit.Sts2.Core.Random.Rng _rng
private MegaCrit.Sts2.Core.Runs.RunRngSet _runRng
private System.Boolean _spawnedThisTurn
private MegaCrit.Sts2.Core.MonsterMoves.MonsterMoveStateMachine.MoveState <NextMove>k__BackingField
public static readonly Godot.Vector2 defaultDeathVfxPadding
public static const System.String stunnedMoveId = "STUNNED"
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public virtual get; }
System.String AttackSfx { protected virtual get; }
System.Boolean CanChangeScale { public virtual get; }
MegaCrit.Sts2.Core.Models.MonsterModel CanonicalInstance { public get; private set; }
System.String CastSfx { protected virtual get; }
MegaCrit.Sts2.Core.Combat.ICombatState CombatState { public get; }
MegaCrit.Sts2.Core.Entities.Creatures.Creature Creature { public get; public set; }
System.Single DeathAnimLengthOverride { public virtual get; }
System.String DeathSfx { public virtual get; }
Godot.Vector2 ExtraDeathVfxPadding { public virtual get; }
System.Boolean HasDeathAnimLengthOverride { public get; }
System.Boolean HasDeathSfx { public virtual get; }
System.Boolean HasHurtSfx { public virtual get; }
System.Boolean HasPhobiaSpineSkin { protected virtual get; }
System.Single HpBarSizeReduction { public virtual get; }
System.Single HurtAnimationTrackOffsetForDoom { public virtual get; }
System.String HurtSfx { public virtual get; }
System.Boolean IntendsToAttack { public get; }
System.Boolean IsHealthBarVisible { public virtual get; }
System.Boolean IsPerformingMove { public get; private set; }
System.Int32 MaxInitialHp { public abstract get; }
System.Int32 MinInitialHp { public abstract get; }
MegaCrit.Sts2.Core.MonsterMoves.MonsterMoveStateMachine.MonsterMoveStateMachine MoveStateMachine { public get; private set; }
MegaCrit.Sts2.Core.MonsterMoves.MonsterMoveStateMachine.MoveState NextMove { public get; private set; }
MegaCrit.Sts2.Core.Random.Rng Rng { public get; public set; }
MegaCrit.Sts2.Core.Runs.RunRngSet RunRng { public get; public set; }
System.Boolean ShouldDisappearFromDoom { public virtual get; }
System.Boolean ShouldFadeAfterDeath { public virtual get; }
System.Boolean ShouldReceiveCombatHooks { public virtual get; }
System.Boolean ShouldShowInCompendium { public virtual get; }
System.Boolean SpawnedThisTurn { public get; private set; }
System.String TakeDamageSfx { public virtual get; }
MegaCrit.Sts2.Core.Audio.DamageSfxType TakeDamageSfxType { public virtual get; }
MegaCrit.Sts2.Core.Localization.LocString Title { public virtual get; }
System.String VisualsPath { protected virtual get; }
private static .cctor()
protected .ctor()
private MegaCrit.Sts2.Core.Nodes.Combat.NCreatureVisuals CreateFallbackVisuals()
private System.Collections.Generic.IEnumerable<System.String> GetAllMoves(MegaCrit.Sts2.Core.MonsterMoves.MonsterMoveStateMachine.MonsterMoveStateMachine machine)
private System.Collections.Generic.List<MegaCrit.Sts2.Core.MonsterMoves.Intents.AbstractIntent> GetIntents()
private System.Void set_CanonicalInstance(MegaCrit.Sts2.Core.Models.MonsterModel value)
private System.Void set_IsPerformingMove(System.Boolean value)
private System.Void set_MoveStateMachine(MegaCrit.Sts2.Core.MonsterMoves.MonsterMoveStateMachine.MonsterMoveStateMachine value)
private System.Void set_NextMove(MegaCrit.Sts2.Core.MonsterMoves.MonsterMoveStateMachine.MoveState value)
private System.Void set_SpawnedThisTurn(System.Boolean value)
protected abstract MegaCrit.Sts2.Core.MonsterMoves.MonsterMoveStateMachine.MonsterMoveStateMachine GenerateMoveStateMachine()
protected MegaCrit.Sts2.Core.Localization.LocString GetBestiaryMoveName(System.String moveId)
protected virtual System.Boolean get_HasPhobiaSpineSkin()
protected virtual System.Boolean ShouldShowMoveInBestiary(System.String moveStateId)
protected virtual System.String get_AttackSfx()
protected virtual System.String get_CastSfx()
protected virtual System.String get_VisualsPath()
public [async] System.Threading.Tasks.Task PerformMove()
public abstract System.Int32 get_MaxInitialHp()
public abstract System.Int32 get_MinInitialHp()
public MegaCrit.Sts2.Core.Combat.ICombatState get_CombatState()
public MegaCrit.Sts2.Core.Entities.Creatures.Creature get_Creature()
public MegaCrit.Sts2.Core.Models.MonsterModel get_CanonicalInstance()
public MegaCrit.Sts2.Core.Models.MonsterModel ToMutable()
public MegaCrit.Sts2.Core.MonsterMoves.MonsterMoveStateMachine.MonsterMoveStateMachine get_MoveStateMachine()
public MegaCrit.Sts2.Core.MonsterMoves.MonsterMoveStateMachine.MoveState get_NextMove()
public MegaCrit.Sts2.Core.Nodes.Combat.NCreatureVisuals CreateVisuals()
public MegaCrit.Sts2.Core.Random.Rng get_Rng()
public MegaCrit.Sts2.Core.Runs.RunRngSet get_RunRng()
public static MegaCrit.Sts2.Core.Localization.LocString L10NMonsterLookup(System.String entryName)
public System.Boolean get_HasDeathAnimLengthOverride()
public System.Boolean get_IntendsToAttack()
public System.Boolean get_IsPerformingMove()
public System.Boolean get_SpawnedThisTurn()
public System.Void OnPhobiaModeToggled(System.Boolean isOn, MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite spine, MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSkeleton skeleton)
public System.Void OnSideSwitch()
public System.Void ResetStateMachine()
public System.Void RollMove(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature> targets)
public System.Void set_Creature(MegaCrit.Sts2.Core.Entities.Creatures.Creature value)
public System.Void set_Rng(MegaCrit.Sts2.Core.Random.Rng value)
public System.Void set_RunRng(MegaCrit.Sts2.Core.Runs.RunRngSet value)
public System.Void SetMoveImmediate(MegaCrit.Sts2.Core.MonsterMoves.MonsterMoveStateMachine.MoveState state, System.Boolean forceTransition = False)
public System.Void SetUpForCombat()
public virtual Godot.Vector2 get_ExtraDeathVfxPadding()
public virtual MegaCrit.Sts2.Core.Animation.CreatureAnimator GenerateAnimator(MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite controller)
public virtual MegaCrit.Sts2.Core.Audio.DamageSfxType get_TakeDamageSfxType()
public virtual MegaCrit.Sts2.Core.Localization.LocString get_Title()
public virtual System.Boolean get_CanChangeScale()
public virtual System.Boolean get_HasDeathSfx()
public virtual System.Boolean get_HasHurtSfx()
public virtual System.Boolean get_IsHealthBarVisible()
public virtual System.Boolean get_ShouldDisappearFromDoom()
public virtual System.Boolean get_ShouldFadeAfterDeath()
public virtual System.Boolean get_ShouldReceiveCombatHooks()
public virtual System.Boolean get_ShouldShowInCompendium()
public virtual System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.BestiaryMonsterMove> GenerateBestiaryMoveList(MegaCrit.Sts2.Core.Nodes.Combat.NCreatureVisuals creatureVisuals)
public virtual System.Single get_DeathAnimLengthOverride()
public virtual System.Single get_HpBarSizeReduction()
public virtual System.Single get_HurtAnimationTrackOffsetForDoom()
public virtual System.String get_DeathSfx()
public virtual System.String get_HurtSfx()
public virtual System.String get_TakeDamageSfx()
public virtual System.Threading.Tasks.Task AfterAddedToRoom()
public virtual System.Void BeforeRemovedFromRoom()
public virtual System.Void OnDieToDoom()
public virtual System.Void SetupSkins(MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite spine, MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSkeleton skeleton)
```

## MegaCrit.Sts2.Core.Models.PotionModel

类型属性：`Public, Abstract, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Models.AbstractModel`。

接口：`System.IComparable<MegaCrit.Sts2.Core.Models.AbstractModel>`

```text
private MegaCrit.Sts2.Core.Models.PotionModel _canonicalInstance
private MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVarSet _dynamicVars
private MegaCrit.Sts2.Core.Entities.Players.Player _owner
private System.Boolean <HasBeenRemovedFromState>k__BackingField
private System.Boolean <IsQueued>k__BackingField
private System.Action BeforeUse
public static const System.String locTable = "potions"
System.Boolean CanBeGeneratedInCombat { public virtual get; }
MegaCrit.Sts2.Core.Models.PotionModel CanonicalInstance { public get; private set; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar> CanonicalVars { protected virtual get; }
MegaCrit.Sts2.Core.Localization.LocString Description { private get; }
MegaCrit.Sts2.Core.Localization.LocString DynamicDescription { public get; }
MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVarSet DynamicVars { public get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.HoverTips.IHoverTip> ExtraHoverTips { public virtual get; }
System.Boolean HasBeenRemovedFromState { public get; private set; }
MegaCrit.Sts2.Core.HoverTips.HoverTip HoverTip { public get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.HoverTips.IHoverTip> HoverTips { public get; }
Godot.Texture2D Image { public get; }
System.String ImagePath { public get; }
System.Boolean IsQueued { public get; private set; }
Godot.Texture2D LargeImage { public get; }
System.String LargeImagePath { public get; }
Godot.Texture2D Outline { public get; }
System.String OutlinePath { public get; }
MegaCrit.Sts2.Core.Entities.Players.Player Owner { public get; public set; }
System.String PackedImagePath { private get; }
System.String PackedOutlinePath { private get; }
System.Boolean PassesCustomUsabilityCheck { public virtual get; }
MegaCrit.Sts2.Core.Models.PotionPoolModel Pool { public get; }
MegaCrit.Sts2.Core.Entities.Potions.PotionRarity Rarity { public abstract get; }
MegaCrit.Sts2.Core.Localization.LocString SelectionScreenPrompt { public get; }
System.Boolean ShouldReceiveCombatHooks { public virtual get; }
MegaCrit.Sts2.Core.Entities.Cards.TargetType TargetType { public abstract get; }
MegaCrit.Sts2.Core.Localization.LocString Title { public get; }
MegaCrit.Sts2.Core.Entities.Potions.PotionUsage Usage { public abstract get; }
event System.Action BeforeUse
protected .ctor()
private MegaCrit.Sts2.Core.Localization.LocString get_Description()
private System.Boolean <get_Pool>b__35_0(MegaCrit.Sts2.Core.Models.PotionPoolModel p)
private System.String get_PackedImagePath()
private System.String get_PackedOutlinePath()
private System.Void set_CanonicalInstance(MegaCrit.Sts2.Core.Models.PotionModel value)
private System.Void set_HasBeenRemovedFromState(System.Boolean value)
private System.Void set_IsQueued(System.Boolean value)
protected static System.Void AssertValidForTargetedPotion(MegaCrit.Sts2.Core.Entities.Creatures.Creature target)
protected virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar> get_CanonicalVars()
protected virtual System.Threading.Tasks.Task OnUse(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Creatures.Creature target)
protected virtual System.Void AfterCloned()
public [async] System.Threading.Tasks.Task OnUseWrapper(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext, MegaCrit.Sts2.Core.Entities.Creatures.Creature target)
public abstract MegaCrit.Sts2.Core.Entities.Cards.TargetType get_TargetType()
public abstract MegaCrit.Sts2.Core.Entities.Potions.PotionRarity get_Rarity()
public abstract MegaCrit.Sts2.Core.Entities.Potions.PotionUsage get_Usage()
public Godot.Texture2D get_Image()
public Godot.Texture2D get_LargeImage()
public Godot.Texture2D get_Outline()
public MegaCrit.Sts2.Core.Entities.Players.Player get_Owner()
public MegaCrit.Sts2.Core.HoverTips.HoverTip get_HoverTip()
public MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVarSet get_DynamicVars()
public MegaCrit.Sts2.Core.Localization.LocString get_DynamicDescription()
public MegaCrit.Sts2.Core.Localization.LocString get_SelectionScreenPrompt()
public MegaCrit.Sts2.Core.Localization.LocString get_Title()
public MegaCrit.Sts2.Core.Models.PotionModel get_CanonicalInstance()
public MegaCrit.Sts2.Core.Models.PotionModel ToMutable()
public MegaCrit.Sts2.Core.Models.PotionPoolModel get_Pool()
public MegaCrit.Sts2.Core.Saves.Runs.SerializablePotion ToSerializable(System.Int32 slotIndex)
public static MegaCrit.Sts2.Core.Models.PotionModel FromSerializable(MegaCrit.Sts2.Core.Saves.Runs.SerializablePotion save)
public System.Boolean CanThrowAtAlly()
public System.Boolean get_HasBeenRemovedFromState()
public System.Boolean get_IsQueued()
public System.Boolean IsValidTarget(MegaCrit.Sts2.Core.Entities.Creatures.Creature target)
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.HoverTips.IHoverTip> get_HoverTips()
public System.String get_ImagePath()
public System.String get_LargeImagePath()
public System.String get_OutlinePath()
public System.Void add_BeforeUse(System.Action value)
public System.Void AfterUsageCanceled()
public System.Void Discard()
public System.Void EnqueueManualUse(MegaCrit.Sts2.Core.Entities.Creatures.Creature target)
public System.Void remove_BeforeUse(System.Action value)
public System.Void RemoveBeforeUse()
public System.Void set_Owner(MegaCrit.Sts2.Core.Entities.Players.Player value)
public virtual System.Boolean get_CanBeGeneratedInCombat()
public virtual System.Boolean get_PassesCustomUsabilityCheck()
public virtual System.Boolean get_ShouldReceiveCombatHooks()
public virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.HoverTips.IHoverTip> get_ExtraHoverTips()
```

## MegaCrit.Sts2.Core.Models.PowerModel

类型属性：`Public, Abstract, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Models.AbstractModel`。

接口：`System.IComparable<MegaCrit.Sts2.Core.Models.AbstractModel>`

```text
private System.Int32 _amount
private System.Int32 _amountOnTurnStart
private MegaCrit.Sts2.Core.Entities.Creatures.Creature _applier
private MegaCrit.Sts2.Core.Models.PowerModel _canonicalInstance
protected static readonly Godot.Color _debuffAmountLabelColor
private MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVarSet _dynamicVars
private System.Object _internalData
protected static readonly Godot.Color _normalAmountLabelColor
private MegaCrit.Sts2.Core.Entities.Creatures.Creature _owner
private System.String _resolvedBigIconPath
private System.Boolean _skipNextDurationTick
private MegaCrit.Sts2.Core.Entities.Creatures.Creature _target
private System.Action DisplayAmountChanged
private System.Action<MegaCrit.Sts2.Core.Models.PowerModel> Flashed
public static const System.String locTable = "powers"
private System.Action PulsingStarted
private System.Action PulsingStopped
private System.Action Removed
System.Boolean AllowNegative { public virtual get; }
System.Int32 Amount { public get; private set; }
Godot.Color AmountLabelColor { public virtual get; }
System.Int32 AmountOnTurnStart { public get; public set; }
MegaCrit.Sts2.Core.Entities.Creatures.Creature Applier { public get; public set; }
System.String BigBetaIconPath { private get; }
Godot.Texture2D BigIcon { public get; }
System.String BigIconPath { private get; }
MegaCrit.Sts2.Core.Models.PowerModel CanonicalInstance { private get; private set; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar> CanonicalVars { protected virtual get; }
MegaCrit.Sts2.Core.Combat.ICombatState CombatState { public get; }
MegaCrit.Sts2.Core.Localization.LocString Description { public virtual get; }
System.Int32 DisplayAmount { public virtual get; }
MegaCrit.Sts2.Core.HoverTips.HoverTip DumbHoverTip { public get; }
MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVarSet DynamicVars { public get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.HoverTips.IHoverTip> ExtraHoverTips { protected virtual get; }
System.Boolean HasRemoteDescription { public get; }
System.Boolean HasSmartDescription { public get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.HoverTips.IHoverTip> HoverTips { public get; }
Godot.Texture2D Icon { public get; }
System.String IconPath { public get; }
MegaCrit.Sts2.Core.Entities.Powers.PowerInstanceType InstanceType { public virtual get; }
System.Boolean IsVisible { public get; }
System.Boolean IsVisibleInternal { protected virtual get; }
System.String MissingIconPath { private static get; }
MegaCrit.Sts2.Core.Entities.Creatures.Creature Owner { public get; private set; }
System.Boolean OwnerIsSecondaryEnemy { public virtual get; }
System.String PackedIconPath { public get; }
MegaCrit.Sts2.Core.Localization.LocString RemoteDescription { public get; }
System.String RemoteDescriptionLocKey { protected virtual get; }
System.String ResolvedBigIconPath { public get; }
MegaCrit.Sts2.Core.Localization.LocString SelectionScreenPrompt { protected get; }
System.Boolean ShouldPlayVfx { public virtual get; }
System.Boolean ShouldReceiveCombatHooks { public virtual get; }
System.Boolean ShouldScaleInMultiplayer { public virtual get; }
System.Boolean SkipNextDurationTick { public get; public set; }
MegaCrit.Sts2.Core.Localization.LocString SmartDescription { public get; }
System.String SmartDescriptionLocKey { protected virtual get; }
MegaCrit.Sts2.Core.Entities.Powers.PowerStackType StackType { public abstract get; }
MegaCrit.Sts2.Core.Entities.Creatures.Creature Target { public get; public set; }
MegaCrit.Sts2.Core.Localization.LocString Title { public virtual get; }
MegaCrit.Sts2.Core.Entities.Powers.PowerType Type { public abstract get; }
MegaCrit.Sts2.Core.Entities.Powers.PowerType TypeForCurrentAmount { public get; }
event System.Action DisplayAmountChanged
event System.Action<MegaCrit.Sts2.Core.Models.PowerModel> Flashed
event System.Action PulsingStarted
event System.Action PulsingStopped
event System.Action Removed
private static .cctor()
protected .ctor()
private MegaCrit.Sts2.Core.Models.PowerModel get_CanonicalInstance()
private static System.String get_MissingIconPath()
private System.String get_BigBetaIconPath()
private System.String get_BigIconPath()
private System.Void AddDumbVariablesToDescription(MegaCrit.Sts2.Core.Localization.LocString description, System.Nullable<System.Int32> amountOverride = null)
private System.Void set_Amount(System.Int32 value)
private System.Void set_CanonicalInstance(MegaCrit.Sts2.Core.Models.PowerModel value)
private System.Void set_Owner(MegaCrit.Sts2.Core.Entities.Creatures.Creature value)
protected MegaCrit.Sts2.Core.Localization.LocString get_SelectionScreenPrompt()
protected System.Void Flash()
protected System.Void InvokeDisplayAmountChanged()
protected T GetInternalData<T>() where T: [None]
protected virtual System.Boolean get_IsVisibleInternal()
protected virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.HoverTips.IHoverTip> get_ExtraHoverTips()
protected virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar> get_CanonicalVars()
protected virtual System.Object InitInternalData()
protected virtual System.String get_RemoteDescriptionLocKey()
protected virtual System.String get_SmartDescriptionLocKey()
protected virtual System.Void AfterCloned()
protected virtual System.Void DeepCloneFields()
public abstract MegaCrit.Sts2.Core.Entities.Powers.PowerStackType get_StackType()
public abstract MegaCrit.Sts2.Core.Entities.Powers.PowerType get_Type()
public Godot.Texture2D get_BigIcon()
public Godot.Texture2D get_Icon()
public MegaCrit.Sts2.Core.Combat.ICombatState get_CombatState()
public MegaCrit.Sts2.Core.Entities.Creatures.Creature get_Applier()
public MegaCrit.Sts2.Core.Entities.Creatures.Creature get_Owner()
public MegaCrit.Sts2.Core.Entities.Creatures.Creature get_Target()
public MegaCrit.Sts2.Core.Entities.Powers.PowerType get_TypeForCurrentAmount()
public MegaCrit.Sts2.Core.Entities.Powers.PowerType GetTypeForAmount(System.Decimal customAmount)
public MegaCrit.Sts2.Core.HoverTips.HoverTip get_DumbHoverTip()
public MegaCrit.Sts2.Core.HoverTips.HoverTip GetDumbHoverTip(System.Nullable<System.Int32> amountOverride = null)
public MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVarSet get_DynamicVars()
public MegaCrit.Sts2.Core.Localization.LocString get_RemoteDescription()
public MegaCrit.Sts2.Core.Localization.LocString get_SmartDescription()
public MegaCrit.Sts2.Core.Models.PowerModel ToMutable(System.Int32 initialAmount = 0)
public System.Boolean get_HasRemoteDescription()
public System.Boolean get_HasSmartDescription()
public System.Boolean get_IsVisible()
public System.Boolean get_SkipNextDurationTick()
public System.Boolean ShouldRemoveDueToAmount()
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.HoverTips.IHoverTip> get_HoverTips()
public System.Int32 get_Amount()
public System.Int32 get_AmountOnTurnStart()
public System.String get_IconPath()
public System.String get_PackedIconPath()
public System.String get_ResolvedBigIconPath()
public System.Void add_DisplayAmountChanged(System.Action value)
public System.Void add_Flashed(System.Action<MegaCrit.Sts2.Core.Models.PowerModel> value)
public System.Void add_PulsingStarted(System.Action value)
public System.Void add_PulsingStopped(System.Action value)
public System.Void add_Removed(System.Action value)
public System.Void ApplyInternal(MegaCrit.Sts2.Core.Entities.Creatures.Creature owner, System.Decimal amount, System.Boolean silent = False)
public System.Void remove_DisplayAmountChanged(System.Action value)
public System.Void remove_Flashed(System.Action<MegaCrit.Sts2.Core.Models.PowerModel> value)
public System.Void remove_PulsingStarted(System.Action value)
public System.Void remove_PulsingStopped(System.Action value)
public System.Void remove_Removed(System.Action value)
public System.Void RemoveInternal()
public System.Void set_AmountOnTurnStart(System.Int32 value)
public System.Void set_Applier(MegaCrit.Sts2.Core.Entities.Creatures.Creature value)
public System.Void set_SkipNextDurationTick(System.Boolean value)
public System.Void set_Target(MegaCrit.Sts2.Core.Entities.Creatures.Creature value)
public System.Void SetAmount(System.Int32 amount, System.Boolean silent = False)
public System.Void StartPulsing()
public System.Void StopPulsing()
public virtual Godot.Color get_AmountLabelColor()
public virtual MegaCrit.Sts2.Core.Entities.Powers.PowerInstanceType get_InstanceType()
public virtual MegaCrit.Sts2.Core.Localization.LocString get_Description()
public virtual MegaCrit.Sts2.Core.Localization.LocString get_Title()
public virtual System.Boolean get_AllowNegative()
public virtual System.Boolean get_OwnerIsSecondaryEnemy()
public virtual System.Boolean get_ShouldPlayVfx()
public virtual System.Boolean get_ShouldReceiveCombatHooks()
public virtual System.Boolean get_ShouldScaleInMultiplayer()
public virtual System.Boolean ShouldOwnerDeathTriggerFatal()
public virtual System.Boolean ShouldPowerBeRemovedAfterOwnerDeath()
public virtual System.Decimal GetScaledAmountForMultiplayer(MegaCrit.Sts2.Core.Combat.ICombatState combatState, MegaCrit.Sts2.Core.Entities.Creatures.Creature applier, System.Decimal amount, MegaCrit.Sts2.Core.Entities.Creatures.Creature target, MegaCrit.Sts2.Core.Models.CardModel cardSource)
public virtual System.Int32 get_DisplayAmount()
public virtual System.Threading.Tasks.Task AfterApplied(MegaCrit.Sts2.Core.Entities.Creatures.Creature applier, MegaCrit.Sts2.Core.Models.CardModel cardSource)
public virtual System.Threading.Tasks.Task AfterRemoved(MegaCrit.Sts2.Core.Entities.Creatures.Creature oldOwner)
public virtual System.Threading.Tasks.Task BeforeApplied(MegaCrit.Sts2.Core.Entities.Creatures.Creature target, System.Decimal amount, MegaCrit.Sts2.Core.Entities.Creatures.Creature applier, MegaCrit.Sts2.Core.Models.CardModel cardSource)
```

## MegaCrit.Sts2.Core.Models.RelicModel

类型属性：`Public, Abstract, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Models.AbstractModel`。

接口：`System.IComparable<MegaCrit.Sts2.Core.Models.AbstractModel>`

```text
private MegaCrit.Sts2.Core.Models.RelicModel _canonicalInstance
private MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVarSet _dynamicVars
private System.Int32 _floorAddedToDeck
private System.Boolean _isMelted
private static readonly Godot.StringName _isUsed
private System.Boolean _isWax
private static readonly Godot.StringName _isWaxStr
protected static const System.String _locTable = "relics"
private MegaCrit.Sts2.Core.Entities.Players.Player _owner
private static readonly Godot.StringName _pulse
private System.String _resolvedBigIconPath
private MegaCrit.Sts2.Core.Entities.Relics.RelicStatus _status
private System.Boolean <HasBeenRemovedFromState>k__BackingField
private System.Int32 <StackCount>k__BackingField
private System.Action DisplayAmountChanged
private System.Action<MegaCrit.Sts2.Core.Models.RelicModel, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature>> Flashed
private System.Action StatusChanged
MegaCrit.Sts2.Core.Localization.LocString AdditionalRestSiteHealText { protected get; }
System.Boolean AddsPet { public virtual get; }
System.String BigBetaIconPath { private get; }
Godot.Texture2D BigIcon { public get; }
System.String BigIconPath { protected virtual get; }
MegaCrit.Sts2.Core.Models.RelicModel CanonicalInstance { public get; private set; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar> CanonicalVars { protected virtual get; }
MegaCrit.Sts2.Core.Localization.LocString Description { private get; }
System.Int32 DisplayAmount { public virtual get; }
MegaCrit.Sts2.Core.Localization.LocString DynamicDescription { public get; }
MegaCrit.Sts2.Core.Localization.LocString DynamicEventDescription { public get; }
MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVarSet DynamicVars { public get; }
MegaCrit.Sts2.Core.Localization.LocString EventDescription { protected get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.HoverTips.IHoverTip> ExtraHoverTips { protected virtual get; }
System.String FlashSfx { public virtual get; }
MegaCrit.Sts2.Core.Localization.LocString Flavor { public get; }
System.Int32 FloorAddedToDeck { public get; public set; }
System.Boolean HasBeenRemovedFromState { public get; private set; }
System.Boolean HasUponPickupEffect { public virtual get; }
MegaCrit.Sts2.Core.HoverTips.HoverTip HoverTip { public get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.HoverTips.IHoverTip> HoverTips { public get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.HoverTips.IHoverTip> HoverTipsExcludingRelic { public get; }
Godot.Texture2D Icon { public get; }
System.String IconBaseName { protected virtual get; }
Godot.Texture2D IconOutline { public get; }
System.String IconPath { public get; }
System.Boolean IsAllowedInShops { public virtual get; }
System.Boolean IsMelted { public get; public set; }
System.Boolean IsStackable { public virtual get; }
System.Boolean IsTradable { public get; }
System.Boolean IsUsedUp { public virtual get; }
System.Boolean IsWax { public get; public set; }
System.Int32 MerchantCost { public virtual get; }
System.String MissingIconPath { private static get; }
MegaCrit.Sts2.Core.Entities.Players.Player Owner { public get; public set; }
System.String PackedIconOutlinePath { protected virtual get; }
System.String PackedIconPath { public virtual get; }
MegaCrit.Sts2.Core.Models.RelicPoolModel Pool { public get; }
MegaCrit.Sts2.Core.Entities.Relics.RelicRarity Rarity { public abstract get; }
System.String ResolvedBigIconPath { private get; }
MegaCrit.Sts2.Core.Localization.LocString SelectionScreenPrompt { protected get; }
System.Boolean ShouldFlashOnPlayer { public virtual get; }
System.Boolean ShouldReceiveCombatHooks { public virtual get; }
System.Boolean ShowCounter { public virtual get; }
System.Boolean SpawnsPets { public virtual get; }
System.Int32 StackCount { public get; private set; }
MegaCrit.Sts2.Core.Entities.Relics.RelicStatus Status { public get; public set; }
MegaCrit.Sts2.Core.Localization.LocString Title { public virtual get; }
event System.Action DisplayAmountChanged
event System.Action<MegaCrit.Sts2.Core.Models.RelicModel, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature>> Flashed
event System.Action StatusChanged
private static .cctor()
protected .ctor()
private MegaCrit.Sts2.Core.Localization.LocString get_Description()
private static System.String get_MissingIconPath()
private System.Boolean <get_Pool>b__46_0(MegaCrit.Sts2.Core.Models.RelicPoolModel p)
private System.String get_BigBetaIconPath()
private System.String get_ResolvedBigIconPath()
private System.Void set_CanonicalInstance(MegaCrit.Sts2.Core.Models.RelicModel value)
private System.Void set_HasBeenRemovedFromState(System.Boolean value)
private System.Void set_StackCount(System.Int32 value)
protected MegaCrit.Sts2.Core.Localization.LocString get_AdditionalRestSiteHealText()
protected MegaCrit.Sts2.Core.Localization.LocString get_EventDescription()
protected MegaCrit.Sts2.Core.Localization.LocString get_SelectionScreenPrompt()
protected static MegaCrit.Sts2.Core.Localization.LocString L10NLookup(System.String entryName)
protected static System.Boolean IsBeforeAct3TreasureChest(MegaCrit.Sts2.Core.Runs.IRunState runState)
protected System.Void InvokeDisplayAmountChanged()
protected System.Void RelicIconChanged()
protected virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.HoverTips.IHoverTip> get_ExtraHoverTips()
protected virtual System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVar> get_CanonicalVars()
protected virtual System.String get_BigIconPath()
protected virtual System.String get_IconBaseName()
protected virtual System.String get_PackedIconOutlinePath()
protected virtual System.Void AfterCloned()
protected virtual System.Void DeepCloneFields()
public abstract MegaCrit.Sts2.Core.Entities.Relics.RelicRarity get_Rarity()
public Godot.Texture2D get_BigIcon()
public Godot.Texture2D get_Icon()
public Godot.Texture2D get_IconOutline()
public MegaCrit.Sts2.Core.Entities.Players.Player get_Owner()
public MegaCrit.Sts2.Core.Entities.Relics.RelicStatus get_Status()
public MegaCrit.Sts2.Core.HoverTips.HoverTip get_HoverTip()
public MegaCrit.Sts2.Core.Localization.DynamicVars.DynamicVarSet get_DynamicVars()
public MegaCrit.Sts2.Core.Localization.LocString get_DynamicDescription()
public MegaCrit.Sts2.Core.Localization.LocString get_DynamicEventDescription()
public MegaCrit.Sts2.Core.Localization.LocString get_Flavor()
public MegaCrit.Sts2.Core.Models.RelicModel get_CanonicalInstance()
public MegaCrit.Sts2.Core.Models.RelicModel ToMutable()
public MegaCrit.Sts2.Core.Models.RelicPoolModel get_Pool()
public MegaCrit.Sts2.Core.Saves.Runs.SerializableRelic ToSerializable()
public static MegaCrit.Sts2.Core.Models.RelicModel FromSerializable(MegaCrit.Sts2.Core.Saves.Runs.SerializableRelic save)
public System.Boolean get_HasBeenRemovedFromState()
public System.Boolean get_IsMelted()
public System.Boolean get_IsTradable()
public System.Boolean get_IsWax()
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.HoverTips.IHoverTip> get_HoverTips()
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.HoverTips.IHoverTip> get_HoverTipsExcludingRelic()
public System.Int32 get_FloorAddedToDeck()
public System.Int32 get_StackCount()
public System.String get_IconPath()
public System.Void add_DisplayAmountChanged(System.Action value)
public System.Void add_Flashed(System.Action<MegaCrit.Sts2.Core.Models.RelicModel, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature>> value)
public System.Void add_StatusChanged(System.Action value)
public System.Void Flash()
public System.Void Flash(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature> targets)
public System.Void IncrementStackCount()
public System.Void remove_DisplayAmountChanged(System.Action value)
public System.Void remove_Flashed(System.Action<MegaCrit.Sts2.Core.Models.RelicModel, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Creatures.Creature>> value)
public System.Void remove_StatusChanged(System.Action value)
public System.Void RemoveInternal()
public System.Void set_FloorAddedToDeck(System.Int32 value)
public System.Void set_IsMelted(System.Boolean value)
public System.Void set_IsWax(System.Boolean value)
public System.Void set_Owner(MegaCrit.Sts2.Core.Entities.Players.Player value)
public System.Void set_Status(MegaCrit.Sts2.Core.Entities.Relics.RelicStatus value)
public System.Void UpdateTexture(Godot.TextureRect texture)
public virtual MegaCrit.Sts2.Core.Localization.LocString get_Title()
public virtual System.Boolean get_AddsPet()
public virtual System.Boolean get_HasUponPickupEffect()
public virtual System.Boolean get_IsAllowedInShops()
public virtual System.Boolean get_IsStackable()
public virtual System.Boolean get_IsUsedUp()
public virtual System.Boolean get_ShouldFlashOnPlayer()
public virtual System.Boolean get_ShouldReceiveCombatHooks()
public virtual System.Boolean get_ShowCounter()
public virtual System.Boolean get_SpawnsPets()
public virtual System.Boolean IsAllowed(MegaCrit.Sts2.Core.Runs.IRunState runState)
public virtual System.Boolean IsAllowedAtNeow(MegaCrit.Sts2.Core.Entities.Players.Player player)
public virtual System.Int32 get_DisplayAmount()
public virtual System.Int32 get_MerchantCost()
public virtual System.String get_FlashSfx()
public virtual System.String get_PackedIconPath()
public virtual System.Threading.Tasks.Task AfterObtained()
public virtual System.Threading.Tasks.Task AfterRemoved()
```
