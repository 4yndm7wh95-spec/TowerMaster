# MegaCrit.Sts2.Core.Nodes.Cards

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.Cards.NCard

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Pooling.IPoolable`

```text
private Godot.Control _ancientBanner
private Godot.TextureRect _ancientBorder
private Godot.TextureRect _ancientBorderGlassOverlay
private Godot.TextureRect _ancientPortrait
private Godot.TextureRect _ancientTextBg
private Godot.TextureRect _banner
private Godot.Material _canvasGroupBlurMaterial
private static const System.String _canvasGroupBlurMaterialPath = "res://scenes/cards/card_canvas_group_blur_material.tres"
private Godot.Material _canvasGroupMaskBlurMaterial
private static const System.String _canvasGroupMaskBlurMaterialPath = "res://scenes/cards/card_canvas_group_mask_blur_material.tres"
private Godot.Material _canvasGroupMaskMaterial
private static const System.String _canvasGroupMaskMaterialPath = "res://scenes/cards/card_canvas_group_mask_material.tres"
private Godot.Control _cardOverlay
private Godot.Node _cardVfxContainer
private System.Threading.CancellationTokenSource _cts
private Godot.Vector2 _defaultEnchantmentPosition
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _descriptionLabel
private Godot.TextureRect _enchantmentIcon
private MegaCrit.Sts2.addons.mega_text.MegaLabel _enchantmentLabel
private Godot.Control _enchantmentTab
private static const System.Int32 _enchantmentTabStarLabelOffset = 45
private Godot.TextureRect _enchantmentVfxOverride
private Godot.TextureRect _energyIcon
private MegaCrit.Sts2.addons.mega_text.MegaLabel _energyLabel
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Vfx.NRelicFlashVfx> _flashVfx
private System.Boolean _forceUnpoweredPreview
private Godot.TextureRect _frame
private static readonly Godot.StringName _h
private Godot.TextureRect _lock
private readonly MegaCrit.Sts2.Core.Localization.LocString _lockedDescription
private readonly MegaCrit.Sts2.Core.Localization.LocString _lockedTitle
private MegaCrit.Sts2.Core.Models.CardModel _model
private Godot.Node _overlayContainer
private Godot.TextureRect _portrait
private Godot.Material _portraitBlurMaterial
private static const System.String _portraitBlurMaterialPath = "res://scenes/cards/card_portrait_blur_material.tres"
private Godot.TextureRect _portraitBorder
private Godot.CanvasGroup _portraitCanvasGroup
private System.Boolean _pretendCardCanBePlayed
private MegaCrit.Sts2.Core.Entities.Creatures.Creature _previewTarget
private MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardRareGlow _rareGlow
private static readonly Godot.StringName _s
private static const System.String _scenePath = "res://scenes/cards/card.tscn"
private Godot.GpuParticles2D _sparkles
private Godot.TextureRect _starIcon
private MegaCrit.Sts2.addons.mega_text.MegaLabel _starLabel
private MegaCrit.Sts2.Core.Models.EnchantmentModel _subscribedEnchantment
private MegaCrit.Sts2.addons.mega_text.MegaLabel _titleLabel
private MegaCrit.Sts2.addons.mega_text.MegaLabel _typeLabel
private Godot.NinePatchRect _typePlaque
private static const System.Single _typePlaqueMinXSize = 61
private static const System.Single _typePlaqueXMargin = 17
private MegaCrit.Sts2.Core.Nodes.Vfx.Cards.NCardUncommonGlow _uncommonGlow
private readonly MegaCrit.Sts2.Core.Localization.LocString _unknownDescription
private readonly MegaCrit.Sts2.Core.Localization.LocString _unknownTitle
private Godot.TextureRect _unplayableEnergyIcon
private Godot.TextureRect _unplayableStarIcon
private static readonly Godot.StringName _v
private MegaCrit.Sts2.Core.Entities.UI.ModelVisibility _visibility
private Godot.Control <Body>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Cards.NCardHighlight <CardHighlight>k__BackingField
private MegaCrit.Sts2.Core.Entities.Cards.PileType <DisplayingPile>k__BackingField
private Godot.Tween <PlayPileTween>k__BackingField
private Godot.Tween <RandomizeCostTween>k__BackingField
public static readonly Godot.Vector2 defaultSize
private System.Action<MegaCrit.Sts2.Core.Models.CardModel> ModelChanged
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
Godot.Control Body { public get; private set; }
MegaCrit.Sts2.Core.Nodes.Cards.NCardHighlight CardHighlight { public get; private set; }
Godot.Node CardVfxContainer { public get; }
MegaCrit.Sts2.Core.Entities.Cards.PileType DisplayingPile { public get; private set; }
Godot.Control EnchantmentTab { public get; }
Godot.TextureRect EnchantmentVfxOverride { public get; }
MegaCrit.Sts2.Core.Models.CardModel Model { public get; public set; }
Godot.Node OverlayContainer { public get; }
Godot.Tween PlayPileTween { public get; public set; }
Godot.Tween RandomizeCostTween { private get; private set; }
MegaCrit.Sts2.Core.Entities.UI.ModelVisibility Visibility { public get; public set; }
event System.Action<MegaCrit.Sts2.Core.Models.CardModel> ModelChanged
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private Godot.Color GetTitleLabelOutlineColor()
private Godot.Tween get_RandomizeCostTween()
private static Godot.Color GetCostOutlineColorInHand(MegaCrit.Sts2.Core.Entities.Cards.CardCostColor costColor, System.Boolean pretendCardCanBePlayed, Godot.Color defaultColor)
private static Godot.Color GetCostTextColorInHand(MegaCrit.Sts2.Core.Entities.Cards.CardCostColor costColor, System.Boolean pretendCardCanBePlayed, Godot.Color defaultColor)
private System.String GetTitleText()
private System.Void <AnimMultiCardPlay>b__140_0()
private System.Void OnAfflictionChanged()
private System.Void OnEnchantmentChanged()
private System.Void OnEnchantmentStatusChanged()
private System.Void Reload()
private System.Void ReloadOverlay()
private System.Void set_Body(Godot.Control value)
private System.Void set_CardHighlight(MegaCrit.Sts2.Core.Nodes.Cards.NCardHighlight value)
private System.Void set_DisplayingPile(MegaCrit.Sts2.Core.Entities.Cards.PileType value)
private System.Void set_RandomizeCostTween(Godot.Tween value)
private System.Void SetEnchantmentStatus(MegaCrit.Sts2.Core.Entities.Enchantments.EnchantmentStatus status)
private System.Void SubscribeToEnchantment(MegaCrit.Sts2.Core.Models.EnchantmentModel model)
private System.Void SubscribeToModel(MegaCrit.Sts2.Core.Models.CardModel model)
private System.Void UnsubscribeFromEnchantment(MegaCrit.Sts2.Core.Models.EnchantmentModel model)
private System.Void UnsubscribeFromModel(MegaCrit.Sts2.Core.Models.CardModel model)
private System.Void UpdateEnchantmentVisuals()
private System.Void UpdateEnergyCostColor(MegaCrit.Sts2.Core.Entities.Cards.PileType pileType)
private System.Void UpdateEnergyCostVisuals(MegaCrit.Sts2.Core.Entities.Cards.PileType pileType)
private System.Void UpdatePortrait()
private System.Void UpdateStarCostColor(MegaCrit.Sts2.Core.Entities.Cards.PileType pileType)
private System.Void UpdateStarCostText(System.Int32 cost)
private System.Void UpdateStarCostVisuals(MegaCrit.Sts2.Core.Entities.Cards.PileType pileType)
private System.Void UpdateTitleLabel()
private System.Void UpdateTypePlaque()
private System.Void UpdateTypePlaqueSizeAndPosition()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public [async] System.Threading.Tasks.Task AnimMultiCardPlay()
public Godot.Control get_Body()
public Godot.Control get_EnchantmentTab()
public Godot.Node get_CardVfxContainer()
public Godot.Node get_OverlayContainer()
public Godot.TextureRect get_EnchantmentVfxOverride()
public Godot.Tween get_PlayPileTween()
public Godot.Vector2 GetCurrentSize()
public MegaCrit.Sts2.Core.Entities.Cards.PileType get_DisplayingPile()
public MegaCrit.Sts2.Core.Entities.UI.ModelVisibility get_Visibility()
public MegaCrit.Sts2.Core.Models.CardModel get_Model()
public MegaCrit.Sts2.Core.Nodes.Cards.NCardHighlight get_CardHighlight()
public static MegaCrit.Sts2.Core.Nodes.Cards.NCard Create(MegaCrit.Sts2.Core.Models.CardModel card, MegaCrit.Sts2.Core.Entities.UI.ModelVisibility visibility = 1)
public static MegaCrit.Sts2.Core.Nodes.Cards.NCard FindOnTable(MegaCrit.Sts2.Core.Models.CardModel card, System.Nullable<MegaCrit.Sts2.Core.Entities.Cards.PileType> overridePile = null)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public static System.Void InitPool()
public System.Void ActivateRewardScreenGlow()
public System.Void add_ModelChanged(System.Action<MegaCrit.Sts2.Core.Models.CardModel> value)
public System.Void AnimCardToPlayPile()
public System.Void FlashRelicOnCard(MegaCrit.Sts2.Core.Models.RelicModel relic)
public System.Void KillRarityGlow()
public System.Void PlayRandomizeCostAnim()
public System.Void remove_ModelChanged(System.Action<MegaCrit.Sts2.Core.Models.CardModel> value)
public System.Void set_Model(MegaCrit.Sts2.Core.Models.CardModel value)
public System.Void set_PlayPileTween(Godot.Tween value)
public System.Void set_Visibility(MegaCrit.Sts2.Core.Entities.UI.ModelVisibility value)
public System.Void SetForceUnpoweredPreview(System.Boolean forceUnpoweredPreview)
public System.Void SetPretendCardCanBePlayed(System.Boolean pretendCardCanBePlayed)
public System.Void SetPreviewTarget(MegaCrit.Sts2.Core.Entities.Creatures.Creature creature)
public System.Void ShowUpgradePreview()
public System.Void UpdateVisuals(MegaCrit.Sts2.Core.Entities.Cards.PileType pileType, MegaCrit.Sts2.Core.Entities.Cards.CardPreviewMode previewMode)
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
public virtual System.Void OnFreedToPool()
public virtual System.Void OnInstantiated()
public virtual System.Void OnReturnedFromPool()
```

## MegaCrit.Sts2.Core.Nodes.Cards.NCard+<>c__DisplayClass126_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Cards.NCard <>4__this
public System.Single offset
public .ctor()
internal System.Void <PlayRandomizeCostAnim>b__0(System.Single t)
internal System.Void <PlayRandomizeCostAnim>b__1()
```

## MegaCrit.Sts2.Core.Nodes.Cards.NCard+<AnimMultiCardPlay>d__140

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Cards.NCard <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Cards.NCard+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName ActivateRewardScreenGlow
public static readonly Godot.StringName AnimCardToPlayPile
public static readonly Godot.StringName GetCostOutlineColorInHand
public static readonly Godot.StringName GetCostTextColorInHand
public static readonly Godot.StringName GetCurrentSize
public static readonly Godot.StringName GetTitleLabelOutlineColor
public static readonly Godot.StringName GetTitleText
public static readonly Godot.StringName InitPool
public static readonly Godot.StringName KillRarityGlow
public static readonly Godot.StringName OnAfflictionChanged
public static readonly Godot.StringName OnEnchantmentChanged
public static readonly Godot.StringName OnEnchantmentStatusChanged
public static readonly Godot.StringName OnFreedToPool
public static readonly Godot.StringName OnInstantiated
public static readonly Godot.StringName OnReturnedFromPool
public static readonly Godot.StringName PlayRandomizeCostAnim
public static readonly Godot.StringName Reload
public static readonly Godot.StringName ReloadOverlay
public static readonly Godot.StringName SetEnchantmentStatus
public static readonly Godot.StringName SetForceUnpoweredPreview
public static readonly Godot.StringName SetPretendCardCanBePlayed
public static readonly Godot.StringName ShowUpgradePreview
public static readonly Godot.StringName UpdateEnchantmentVisuals
public static readonly Godot.StringName UpdateEnergyCostColor
public static readonly Godot.StringName UpdateEnergyCostVisuals
public static readonly Godot.StringName UpdatePortrait
public static readonly Godot.StringName UpdateStarCostColor
public static readonly Godot.StringName UpdateStarCostText
public static readonly Godot.StringName UpdateStarCostVisuals
public static readonly Godot.StringName UpdateTitleLabel
public static readonly Godot.StringName UpdateTypePlaque
public static readonly Godot.StringName UpdateTypePlaqueSizeAndPosition
public static readonly Godot.StringName UpdateVisuals
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Cards.NCard+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _ancientBanner
public static readonly Godot.StringName _ancientBorder
public static readonly Godot.StringName _ancientBorderGlassOverlay
public static readonly Godot.StringName _ancientPortrait
public static readonly Godot.StringName _ancientTextBg
public static readonly Godot.StringName _banner
public static readonly Godot.StringName _canvasGroupBlurMaterial
public static readonly Godot.StringName _canvasGroupMaskBlurMaterial
public static readonly Godot.StringName _canvasGroupMaskMaterial
public static readonly Godot.StringName _cardOverlay
public static readonly Godot.StringName _cardVfxContainer
public static readonly Godot.StringName _defaultEnchantmentPosition
public static readonly Godot.StringName _descriptionLabel
public static readonly Godot.StringName _enchantmentIcon
public static readonly Godot.StringName _enchantmentLabel
public static readonly Godot.StringName _enchantmentTab
public static readonly Godot.StringName _enchantmentVfxOverride
public static readonly Godot.StringName _energyIcon
public static readonly Godot.StringName _energyLabel
public static readonly Godot.StringName _forceUnpoweredPreview
public static readonly Godot.StringName _frame
public static readonly Godot.StringName _lock
public static readonly Godot.StringName _overlayContainer
public static readonly Godot.StringName _portrait
public static readonly Godot.StringName _portraitBlurMaterial
public static readonly Godot.StringName _portraitBorder
public static readonly Godot.StringName _portraitCanvasGroup
public static readonly Godot.StringName _pretendCardCanBePlayed
public static readonly Godot.StringName _rareGlow
public static readonly Godot.StringName _sparkles
public static readonly Godot.StringName _starIcon
public static readonly Godot.StringName _starLabel
public static readonly Godot.StringName _titleLabel
public static readonly Godot.StringName _typeLabel
public static readonly Godot.StringName _typePlaque
public static readonly Godot.StringName _uncommonGlow
public static readonly Godot.StringName _unplayableEnergyIcon
public static readonly Godot.StringName _unplayableStarIcon
public static readonly Godot.StringName _visibility
public static readonly Godot.StringName Body
public static readonly Godot.StringName CardHighlight
public static readonly Godot.StringName CardVfxContainer
public static readonly Godot.StringName DisplayingPile
public static readonly Godot.StringName EnchantmentTab
public static readonly Godot.StringName EnchantmentVfxOverride
public static readonly Godot.StringName OverlayContainer
public static readonly Godot.StringName PlayPileTween
public static readonly Godot.StringName RandomizeCostTween
public static readonly Godot.StringName Visibility
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Cards.NCard+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Cards.NCardBundle

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private Godot.Control _cardHolder
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Cards.NCard> _cardNodes
private static const System.Single _cardSeparation = 45
private Godot.Tween _cardTween
private readonly Godot.Vector2 _hoverScale
private Godot.Tween _hoverTween
private System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.CardModel> <Bundle>k__BackingField
private MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl <Hitbox>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Cards.NCardBundle+ClickedEventHandler backing_Clicked
public readonly Godot.Vector2 smallScale
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.CardModel> Bundle { public get; private set; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Nodes.Cards.NCard> CardNodes { public get; }
MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl Hitbox { public get; private set; }
System.String ScenePath { private static get; }
event MegaCrit.Sts2.Core.Nodes.Cards.NCardBundle+ClickedEventHandler Clicked
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotSignalList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private static System.String get_ScenePath()
private System.Void OnClicked(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl _)
private System.Void OnFocused(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl _)
private System.Void OnUnfocused(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl _)
private System.Void set_Bundle(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.CardModel> value)
private System.Void set_Hitbox(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl value)
protected System.Void EmitSignalClicked(MegaCrit.Sts2.Core.Nodes.Cards.NCardBundle cardHolder)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean HasGodotClassSignal(in Godot.NativeInterop.godot_string_name signal)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RaiseGodotClassSignalCallbacks(in Godot.NativeInterop.godot_string_name signal, Godot.NativeInterop.NativeVariantPtrArgs args)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl get_Hitbox()
public static MegaCrit.Sts2.Core.Nodes.Cards.NCardBundle Create(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.CardModel> bundle)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.CardModel> get_Bundle()
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Nodes.Cards.NCard> get_CardNodes()
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Nodes.Cards.NCard> RemoveCardNodes()
public System.Void add_Clicked(MegaCrit.Sts2.Core.Nodes.Cards.NCardBundle+ClickedEventHandler value)
public System.Void ReAddCardNodes()
public System.Void remove_Clicked(MegaCrit.Sts2.Core.Nodes.Cards.NCardBundle+ClickedEventHandler value)
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Cards.NCardBundle+ClickedEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(MegaCrit.Sts2.Core.Nodes.Cards.NCardBundle cardHolder, System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke(MegaCrit.Sts2.Core.Nodes.Cards.NCardBundle cardHolder)
```

## MegaCrit.Sts2.Core.Nodes.Cards.NCardBundle+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnClicked
public static readonly Godot.StringName OnFocused
public static readonly Godot.StringName OnUnfocused
public static readonly Godot.StringName ReAddCardNodes
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Cards.NCardBundle+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _cardHolder
public static readonly Godot.StringName _cardTween
public static readonly Godot.StringName _hoverScale
public static readonly Godot.StringName _hoverTween
public static readonly Godot.StringName Hitbox
public static readonly Godot.StringName smallScale
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Cards.NCardBundle+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public static readonly Godot.StringName Clicked
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Cards.NCardGrid

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private System.Threading.Tasks.Task _animatingOutTask
private static const System.Single _bottomMargin = 320
protected readonly System.Collections.Generic.List<System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Cards.Holders.NGridCardHolder>> _cardRows
protected readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.CardModel> _cards
private System.Boolean _cardsAnimatingOutForSetCards
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.CardModel> _cardsCache
protected Godot.Vector2 _cardSize
private System.Threading.CancellationTokenSource _cts
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.CardModel> _highlightedCards
private System.Boolean _isDragging
private System.Boolean _isShowingUpgrades
private MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder _lastFocusedHolder
private System.Boolean _needsReinit
private MegaCrit.Sts2.Core.Entities.Cards.PileType _pileType
private MegaCrit.Sts2.Core.Nodes.GodotExtensions.NScrollbar _scrollbar
private System.Boolean _scrollbarPressed
protected Godot.Control _scrollContainer
private System.Boolean _scrollingEnabled
private System.Threading.CancellationTokenSource _setCardsCancellation
private System.Int32 _slidingWindowCardIndex
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.CardModel> _sortedCardsCache
private System.Collections.Generic.Dictionary<MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.SortingOrders, System.Func<MegaCrit.Sts2.Core.Models.CardModel, MegaCrit.Sts2.Core.Models.CardModel, System.Int32>> _sortingAlgorithms
private System.Single _startDrag
private System.Single _targetDrag
private static const System.Single _topMargin = 80
private System.Int32 <DisplayedRows>k__BackingField
private System.Int32 <YOffset>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Cards.NCardGrid+HolderAltPressedEventHandler backing_HolderAltPressed
private MegaCrit.Sts2.Core.Nodes.Cards.NCardGrid+HolderPressedEventHandler backing_HolderPressed
System.Boolean CanScroll { private get; }
System.Single CardPadding { protected get; }
System.Boolean CenterGrid { protected virtual get; }
System.Int32 Columns { protected get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Nodes.Cards.Holders.NGridCardHolder> CurrentlyDisplayedCardHolders { public get; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> CurrentlyDisplayedCards { public get; }
Godot.Control DefaultFocusedControl { public get; }
System.Int32 DisplayedRows { private get; private set; }
Godot.Control FocusedControlFromTopBar { public get; }
System.Boolean IsAnimatingOut { public get; }
System.Boolean IsCardLibrary { protected virtual get; }
System.Boolean IsShowingUpgrades { public get; public set; }
System.Single ScrollLimitBottom { private get; }
System.Single ScrollLimitTop { protected get; }
System.Collections.Generic.Dictionary<MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.SortingOrders, System.Func<MegaCrit.Sts2.Core.Models.CardModel, MegaCrit.Sts2.Core.Models.CardModel, System.Int32>> SortingAlgorithms { private get; }
System.Int32 YOffset { public get; public set; }
event MegaCrit.Sts2.Core.Nodes.Cards.NCardGrid+HolderAltPressedEventHandler HolderAltPressed
event MegaCrit.Sts2.Core.Nodes.Cards.NCardGrid+HolderPressedEventHandler HolderPressed
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotSignalList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task AnimateIn()
private [async] System.Threading.Tasks.Task AnimateOutInternal()
private [async] System.Threading.Tasks.Task InitGrid(System.Threading.Tasks.Task taskToWaitOn)
private Godot.Vector2 GetContainedCardsSize()
private System.Boolean get_CanScroll()
private System.Collections.Generic.Dictionary<MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.SortingOrders, System.Func<MegaCrit.Sts2.Core.Models.CardModel, MegaCrit.Sts2.Core.Models.CardModel, System.Int32>> get_SortingAlgorithms()
private System.Int32 <get_SortingAlgorithms>b__2_0(MegaCrit.Sts2.Core.Models.CardModel a, MegaCrit.Sts2.Core.Models.CardModel b)
private System.Int32 <get_SortingAlgorithms>b__2_4(MegaCrit.Sts2.Core.Models.CardModel a, MegaCrit.Sts2.Core.Models.CardModel b)
private System.Int32 <get_SortingAlgorithms>b__2_8(MegaCrit.Sts2.Core.Models.CardModel a, MegaCrit.Sts2.Core.Models.CardModel b)
private System.Int32 <get_SortingAlgorithms>b__2_9(MegaCrit.Sts2.Core.Models.CardModel a, MegaCrit.Sts2.Core.Models.CardModel b)
private System.Int32 CalculateRowsNeeded()
private System.Int32 CompareCardVisibility(MegaCrit.Sts2.Core.Models.CardModel a, MegaCrit.Sts2.Core.Models.CardModel b)
private System.Int32 get_DisplayedRows()
private System.Int32 GetCardRarityComparisonValue(MegaCrit.Sts2.Core.Models.CardModel a)
private System.Int32 GetTotalRowCount()
private System.Single get_ScrollLimitBottom()
private System.Void <ConnectSignals>b__63_0(Godot.InputEvent _)
private System.Void <ConnectSignals>b__63_1(Godot.InputEvent _)
private System.Void AllocateCardHolders()
private System.Void OnHolderAltPressed(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder holder)
private System.Void OnHolderPressed(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder holder)
private System.Void ProcessGuiFocus(Godot.Control focusedControl)
private System.Void ProcessMouseEvent(Godot.InputEvent inputEvent)
private System.Void ProcessScrollEvent(Godot.InputEvent inputEvent)
private System.Void ReallocateAbove(System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Cards.Holders.NGridCardHolder> row)
private System.Void ReallocateAll()
private System.Void ReallocateBelow(System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Cards.Holders.NGridCardHolder> row)
private System.Void ReflowColumns()
private System.Void set_DisplayedRows(System.Int32 value)
private System.Void UpdateGridPositions(System.Int32 index)
private System.Void UpdateScrollLimitBottom()
private System.Void UpdateScrollPosition(System.Double delta)
protected System.Int32 get_Columns()
protected System.Single get_CardPadding()
protected System.Single get_ScrollLimitTop()
protected System.Void EmitSignalHolderAltPressed(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder card)
protected System.Void EmitSignalHolderPressed(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder card)
protected virtual MegaCrit.Sts2.Core.Entities.UI.ModelVisibility GetCardVisibility(MegaCrit.Sts2.Core.Models.CardModel card)
protected virtual System.Boolean get_CenterGrid()
protected virtual System.Boolean get_IsCardLibrary()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean HasGodotClassSignal(in Godot.NativeInterop.godot_string_name signal)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void AssignCardsToRow(System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Cards.Holders.NGridCardHolder> row, System.Int32 startIndex)
protected virtual System.Void ConnectSignals()
protected virtual System.Void InitGrid()
protected virtual System.Void RaiseGodotClassSignalCallbacks(in Godot.NativeInterop.godot_string_name signal, Godot.NativeInterop.NativeVariantPtrArgs args)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void UpdateGridNavigation()
public Godot.Control get_DefaultFocusedControl()
public Godot.Control get_FocusedControlFromTopBar()
public MegaCrit.Sts2.Core.Nodes.Cards.Holders.NGridCardHolder GetCardHolder(MegaCrit.Sts2.Core.Models.CardModel model)
public MegaCrit.Sts2.Core.Nodes.Cards.NCard GetCardNode(MegaCrit.Sts2.Core.Models.CardModel model)
public System.Boolean get_IsAnimatingOut()
public System.Boolean get_IsShowingUpgrades()
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> get_CurrentlyDisplayedCards()
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Nodes.Cards.Holders.NGridCardHolder> get_CurrentlyDisplayedCardHolders()
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Nodes.Cards.Holders.NGridCardHolder> GetTopRowOfCardNodes()
public System.Int32 get_YOffset()
public System.Threading.Tasks.Task AnimateOut()
public System.Void add_HolderAltPressed(MegaCrit.Sts2.Core.Nodes.Cards.NCardGrid+HolderAltPressedEventHandler value)
public System.Void add_HolderPressed(MegaCrit.Sts2.Core.Nodes.Cards.NCardGrid+HolderPressedEventHandler value)
public System.Void ClearGrid()
public System.Void HighlightCard(MegaCrit.Sts2.Core.Models.CardModel card)
public System.Void InsetForTopBar()
public System.Void remove_HolderAltPressed(MegaCrit.Sts2.Core.Nodes.Cards.NCardGrid+HolderAltPressedEventHandler value)
public System.Void remove_HolderPressed(MegaCrit.Sts2.Core.Nodes.Cards.NCardGrid+HolderPressedEventHandler value)
public System.Void set_IsShowingUpgrades(System.Boolean value)
public System.Void set_YOffset(System.Int32 value)
public System.Void SetCanScroll(System.Boolean canScroll)
public System.Void SetCards(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.CardModel> cardsToDisplay, MegaCrit.Sts2.Core.Entities.Cards.PileType pileType, System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.SortingOrders> sortingPriority, System.Threading.Tasks.Task taskToWaitOn = null)
public System.Void SetScrollPosition(System.Single scrollY)
public System.Void UnhighlightCard(MegaCrit.Sts2.Core.Models.CardModel card)
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _GuiInput(Godot.InputEvent inputEvent)
public virtual System.Void _Notification(System.Int32 what)
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Cards.NCardGrid+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Cards.NCardGrid+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, MegaCrit.Sts2.Core.Models.CardModel, System.Int32> <>9__2_1
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, MegaCrit.Sts2.Core.Models.CardModel, System.Int32> <>9__2_2
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, MegaCrit.Sts2.Core.Models.CardModel, System.Int32> <>9__2_3
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, MegaCrit.Sts2.Core.Models.CardModel, System.Int32> <>9__2_5
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, MegaCrit.Sts2.Core.Models.CardModel, System.Int32> <>9__2_6
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, MegaCrit.Sts2.Core.Models.CardModel, System.Int32> <>9__2_7
public static System.Func<System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Cards.Holders.NGridCardHolder>, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Nodes.Cards.Holders.NGridCardHolder>> <>9__47_0
public static System.Func<MegaCrit.Sts2.Core.Nodes.Cards.Holders.NGridCardHolder, MegaCrit.Sts2.Core.Models.CardModel> <>9__49_0
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, MegaCrit.Sts2.Core.Models.CardModel> <>9__78_1
public static System.Func<System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Cards.Holders.NGridCardHolder>, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Nodes.Cards.Holders.NGridCardHolder>> <>9__80_0
public static System.Func<System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Cards.Holders.NGridCardHolder>, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Nodes.Cards.Holders.NGridCardHolder>> <>9__81_0
public static System.Func<System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Cards.Holders.NGridCardHolder>, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Nodes.Cards.Holders.NGridCardHolder>> <>9__88_0
private static .cctor()
public .ctor()
internal MegaCrit.Sts2.Core.Models.CardModel <get_CurrentlyDisplayedCards>b__49_0(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NGridCardHolder h)
internal MegaCrit.Sts2.Core.Models.CardModel <SetCards>b__78_1(MegaCrit.Sts2.Core.Models.CardModel c)
internal System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Nodes.Cards.Holders.NGridCardHolder> <AnimateIn>b__81_0(System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Cards.Holders.NGridCardHolder> c)
internal System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Nodes.Cards.Holders.NGridCardHolder> <AnimateOutInternal>b__80_0(System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Cards.Holders.NGridCardHolder> c)
internal System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Nodes.Cards.Holders.NGridCardHolder> <get_CurrentlyDisplayedCardHolders>b__47_0(System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Cards.Holders.NGridCardHolder> r)
internal System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Nodes.Cards.Holders.NGridCardHolder> <GetCardHolder>b__88_0(System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Cards.Holders.NGridCardHolder> row)
internal System.Int32 <get_SortingAlgorithms>b__2_1(MegaCrit.Sts2.Core.Models.CardModel a, MegaCrit.Sts2.Core.Models.CardModel b)
internal System.Int32 <get_SortingAlgorithms>b__2_2(MegaCrit.Sts2.Core.Models.CardModel a, MegaCrit.Sts2.Core.Models.CardModel b)
internal System.Int32 <get_SortingAlgorithms>b__2_3(MegaCrit.Sts2.Core.Models.CardModel a, MegaCrit.Sts2.Core.Models.CardModel b)
internal System.Int32 <get_SortingAlgorithms>b__2_5(MegaCrit.Sts2.Core.Models.CardModel a, MegaCrit.Sts2.Core.Models.CardModel b)
internal System.Int32 <get_SortingAlgorithms>b__2_6(MegaCrit.Sts2.Core.Models.CardModel a, MegaCrit.Sts2.Core.Models.CardModel b)
internal System.Int32 <get_SortingAlgorithms>b__2_7(MegaCrit.Sts2.Core.Models.CardModel a, MegaCrit.Sts2.Core.Models.CardModel b)
```

## MegaCrit.Sts2.Core.Nodes.Cards.NCardGrid+<>c__DisplayClass78_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Cards.NCardGrid <>4__this
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.SortingOrders> sortingPriority
public .ctor()
internal System.Int32 <SetCards>b__0(MegaCrit.Sts2.Core.Models.CardModel x, MegaCrit.Sts2.Core.Models.CardModel y)
```

## MegaCrit.Sts2.Core.Nodes.Cards.NCardGrid+<>c__DisplayClass88_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Models.CardModel model
public .ctor()
internal System.Boolean <GetCardHolder>b__1(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NGridCardHolder h)
```

## MegaCrit.Sts2.Core.Nodes.Cards.NCardGrid+<AnimateIn>d__81

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Cards.NCardGrid <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
private Godot.Tween <tween>5__2
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Cards.NCardGrid+<AnimateOutInternal>d__80

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Cards.NCardGrid <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Cards.NCardGrid+<InitGrid>d__82

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Cards.NCardGrid <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public System.Threading.Tasks.Task taskToWaitOn
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Cards.NCardGrid+HolderAltPressedEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder card, System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder card)
```

## MegaCrit.Sts2.Core.Nodes.Cards.NCardGrid+HolderPressedEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder card, System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder card)
```

## MegaCrit.Sts2.Core.Nodes.Cards.NCardGrid+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _GuiInput
public static readonly Godot.StringName _Notification
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AllocateCardHolders
public static readonly Godot.StringName CalculateRowsNeeded
public static readonly Godot.StringName ClearGrid
public static readonly Godot.StringName ConnectSignals
public static readonly Godot.StringName GetContainedCardsSize
public static readonly Godot.StringName GetTotalRowCount
public static readonly Godot.StringName InitGrid
public static readonly Godot.StringName InsetForTopBar
public static readonly Godot.StringName OnHolderAltPressed
public static readonly Godot.StringName OnHolderPressed
public static readonly Godot.StringName ProcessGuiFocus
public static readonly Godot.StringName ProcessMouseEvent
public static readonly Godot.StringName ProcessScrollEvent
public static readonly Godot.StringName ReallocateAll
public static readonly Godot.StringName ReflowColumns
public static readonly Godot.StringName SetCanScroll
public static readonly Godot.StringName SetScrollPosition
public static readonly Godot.StringName UpdateGridNavigation
public static readonly Godot.StringName UpdateGridPositions
public static readonly Godot.StringName UpdateScrollLimitBottom
public static readonly Godot.StringName UpdateScrollPosition
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Cards.NCardGrid+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _cardsAnimatingOutForSetCards
public static readonly Godot.StringName _cardSize
public static readonly Godot.StringName _isDragging
public static readonly Godot.StringName _isShowingUpgrades
public static readonly Godot.StringName _lastFocusedHolder
public static readonly Godot.StringName _needsReinit
public static readonly Godot.StringName _pileType
public static readonly Godot.StringName _scrollbar
public static readonly Godot.StringName _scrollbarPressed
public static readonly Godot.StringName _scrollContainer
public static readonly Godot.StringName _scrollingEnabled
public static readonly Godot.StringName _slidingWindowCardIndex
public static readonly Godot.StringName _startDrag
public static readonly Godot.StringName _targetDrag
public static readonly Godot.StringName CanScroll
public static readonly Godot.StringName CardPadding
public static readonly Godot.StringName CenterGrid
public static readonly Godot.StringName Columns
public static readonly Godot.StringName DefaultFocusedControl
public static readonly Godot.StringName DisplayedRows
public static readonly Godot.StringName FocusedControlFromTopBar
public static readonly Godot.StringName IsAnimatingOut
public static readonly Godot.StringName IsCardLibrary
public static readonly Godot.StringName IsShowingUpgrades
public static readonly Godot.StringName ScrollLimitBottom
public static readonly Godot.StringName ScrollLimitTop
public static readonly Godot.StringName YOffset
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Cards.NCardGrid+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public static readonly Godot.StringName HolderAltPressed
public static readonly Godot.StringName HolderPressed
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Cards.NCardHighlight

类型属性：`Public, BeforeFieldInit`；基类：`Godot.TextureRect`。

接口：`System.IDisposable`

```text
private Godot.Tween _curTween
private Godot.ShaderMaterial _shaderMaterial
private static readonly Godot.StringName _shaderParameterWidth
public static readonly Godot.Color gold
public static readonly Godot.Color playableColor
public static readonly Godot.Color red
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Single GetShaderParameter()
private System.Void SetShaderParameter(System.Single val)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void AnimFlash()
public System.Void AnimHide()
public System.Void AnimHideInstantly()
public System.Void AnimShow()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Cards.NCardHighlight+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.TextureRect+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AnimFlash
public static readonly Godot.StringName AnimHide
public static readonly Godot.StringName AnimHideInstantly
public static readonly Godot.StringName AnimShow
public static readonly Godot.StringName GetShaderParameter
public static readonly Godot.StringName SetShaderParameter
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Cards.NCardHighlight+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.TextureRect+PropertyName`。

接口：

```text
public static readonly Godot.StringName _curTween
public static readonly Godot.StringName _shaderMaterial
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Cards.NCardHighlight+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.TextureRect+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Cards.NEnchantPreview

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private Godot.Control _after
private Godot.Control _arrows
private Godot.Control _before
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void RemoveExistingCards()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void Init(MegaCrit.Sts2.Core.Models.CardModel card, MegaCrit.Sts2.Core.Models.EnchantmentModel canonicalEnchantment, System.Int32 amount)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Cards.NEnchantPreview+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName RemoveExistingCards
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Cards.NEnchantPreview+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _after
public static readonly Godot.StringName _arrows
public static readonly Godot.StringName _before
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Cards.NEnchantPreview+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Cards.NTinyCard

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private Godot.TextureRect _cardBack
private Godot.Control _cardBanner
private Godot.TextureRect _cardPortrait
private Godot.TextureRect _cardPortraitShadow
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private Godot.Color GetBannerColor(MegaCrit.Sts2.Core.Entities.Cards.CardRarity rarity)
private System.Void SetBannerColor(MegaCrit.Sts2.Core.Entities.Cards.CardRarity rarity)
private System.Void SetCardBackColor(MegaCrit.Sts2.Core.Models.CardPoolModel cardPool)
private System.Void SetCardPortraitShape(MegaCrit.Sts2.Core.Entities.Cards.CardType type)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void Set(MegaCrit.Sts2.Core.Models.CardPoolModel cardPool, MegaCrit.Sts2.Core.Entities.Cards.CardType type, MegaCrit.Sts2.Core.Entities.Cards.CardRarity rarity)
public System.Void SetCard(MegaCrit.Sts2.Core.Models.CardModel card)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Cards.NTinyCard+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName GetBannerColor
public static readonly Godot.StringName SetBannerColor
public static readonly Godot.StringName SetCardPortraitShape
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Cards.NTinyCard+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _cardBack
public static readonly Godot.StringName _cardBanner
public static readonly Godot.StringName _cardPortrait
public static readonly Godot.StringName _cardPortraitShadow
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Cards.NTinyCard+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Cards.NTransformPreview

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private Godot.Control _after
private Godot.Control _arrows
private Godot.Control _before
private System.Threading.CancellationTokenSource _cancelTokenSource
Godot.Vector2 SelectedCardPosition { public get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task CycleThroughCards(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NPreviewCardHolder holder, MegaCrit.Sts2.Core.Entities.Cards.CardPile cardPile, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> possibleTransformations)
private System.Void RemoveExistingCards()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public Godot.Vector2 get_SelectedCardPosition()
public System.Void Initialize(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Entities.Cards.CardTransformation> cardTransformations)
public System.Void Uninitialize()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Cards.NTransformPreview+<CycleThroughCards>d__10

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Cards.NTransformPreview <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Int32 <cardIndex>5__3
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.CardModel> <cards>5__2
public MegaCrit.Sts2.Core.Entities.Cards.CardPile cardPile
public MegaCrit.Sts2.Core.Nodes.Cards.Holders.NPreviewCardHolder holder
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> possibleTransformations
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Cards.NTransformPreview+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName RemoveExistingCards
public static readonly Godot.StringName Uninitialize
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Cards.NTransformPreview+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _after
public static readonly Godot.StringName _arrows
public static readonly Godot.StringName _before
public static readonly Godot.StringName SelectedCardPosition
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Cards.NTransformPreview+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Cards.NUpgradePreview

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private Godot.Control _after
private Godot.Control _arrows
private Godot.Control _before
private MegaCrit.Sts2.Core.Models.CardModel _card
MegaCrit.Sts2.Core.Models.CardModel Card { public get; public set; }
Godot.Control DefaultFocusedControl { public get; }
Godot.Vector2 SelectedCardPosition { public get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void Reload()
private System.Void RemoveExistingCards()
private System.Void ReturnCard(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder holder)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public Godot.Control get_DefaultFocusedControl()
public Godot.Vector2 get_SelectedCardPosition()
public MegaCrit.Sts2.Core.Models.CardModel get_Card()
public System.Void set_Card(MegaCrit.Sts2.Core.Models.CardModel value)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Cards.NUpgradePreview+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Reload
public static readonly Godot.StringName RemoveExistingCards
public static readonly Godot.StringName ReturnCard
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Cards.NUpgradePreview+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _after
public static readonly Godot.StringName _arrows
public static readonly Godot.StringName _before
public static readonly Godot.StringName DefaultFocusedControl
public static readonly Godot.StringName SelectedCardPosition
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Cards.NUpgradePreview+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```
