# MegaCrit.Sts2.Core.Nodes.Screens.CardSelection

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.ICardSelector

类型属性：`Public, ClassSemanticsMask, Abstract, BeforeFieldInit`；基类：`无`。

接口：

```text
public abstract System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> CardsSelected()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardGridSelectionScreen

类型属性：`Public, Abstract, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.Overlays.IOverlayScreen`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`, `MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.ICardSelector`

```text
protected System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.CardModel> _cards
protected readonly System.Threading.Tasks.TaskCompletionSource<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> _completionSource
protected MegaCrit.Sts2.Core.Nodes.Cards.NCardGrid _grid
protected MegaCrit.Sts2.Core.Nodes.Combat.NPeekButton _peekButton
Godot.Control DefaultFocusedControl { public virtual get; }
Godot.Control FocusedControlFromTopBar { public virtual get; }
System.Collections.Generic.IEnumerable<Godot.Control> PeekButtonTargets { protected abstract get; }
MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType ScreenType { public virtual get; }
System.Boolean UseSharedBackstop { public virtual get; }
protected .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void <ConnectSignalsAndInitGrid>b__7_0(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder h)
private System.Void <ConnectSignalsAndInitGrid>b__7_1(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder h)
private System.Void <ConnectSignalsAndInitGrid>b__7_2(MegaCrit.Sts2.Core.Nodes.Combat.NPeekButton _)
private System.Void SetPeekButtonTargets()
private System.Void ShowCardDetail(MegaCrit.Sts2.Core.Models.CardModel card)
protected abstract System.Collections.Generic.IEnumerable<Godot.Control> get_PeekButtonTargets()
protected abstract System.Void OnCardClicked(MegaCrit.Sts2.Core.Models.CardModel card)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void ConnectSignalsAndInitGrid()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual [async] System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> CardsSelected()
public virtual Godot.Control get_DefaultFocusedControl()
public virtual Godot.Control get_FocusedControlFromTopBar()
public virtual MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType get_ScreenType()
public virtual System.Boolean get_UseSharedBackstop()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
public virtual System.Void AfterOverlayClosed()
public virtual System.Void AfterOverlayHidden()
public virtual System.Void AfterOverlayOpened()
public virtual System.Void AfterOverlayShown()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardGridSelectionScreen+<CardsSelected>d__11

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardGridSelectionScreen <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardGridSelectionScreen+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AfterOverlayClosed
public static readonly Godot.StringName AfterOverlayHidden
public static readonly Godot.StringName AfterOverlayOpened
public static readonly Godot.StringName AfterOverlayShown
public static readonly Godot.StringName ConnectSignalsAndInitGrid
public static readonly Godot.StringName SetPeekButtonTargets
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardGridSelectionScreen+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _grid
public static readonly Godot.StringName _peekButton
public static readonly Godot.StringName DefaultFocusedControl
public static readonly Godot.StringName FocusedControlFromTopBar
public static readonly Godot.StringName ScreenType
public static readonly Godot.StringName UseSharedBackstop
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardGridSelectionScreen+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardRewardAlternativeButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private Godot.Tween _animInTween
private static readonly Godot.Vector2 _animOffsetPosition
private Godot.Tween _currentTween
private static readonly Godot.Vector2 _defaultScale
private static readonly Godot.Vector2 _downScale
private System.String[] _hotkeys
private static readonly Godot.Vector2 _hoverScale
private Godot.ShaderMaterial _hsv
private Godot.Variant _hsvDefault
private Godot.Variant _hsvDown
private Godot.Variant _hsvHover
private Godot.TextureRect _image
private MegaCrit.Sts2.addons.mega_text.MegaLabel _label
private System.String _optionName
private Godot.Vector2 _showPosition
private static readonly Godot.StringName _v
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
System.String[] Hotkeys { protected virtual get; }
System.String ScenePath { private static get; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private static System.String get_ScenePath()
private System.Void UpdateShaderParam(System.Single value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.String[] get_Hotkeys()
protected virtual System.Void OnFocus()
protected virtual System.Void OnPress()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardRewardAlternativeButton Create(System.String optionName, System.String hotkey)
public static MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardRewardAlternativeButton Create(System.String optionName, System.String[] hotkeys)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Void AnimateIn()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardRewardAlternativeButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AnimateIn
public static readonly Godot.StringName Create
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName UpdateShaderParam
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardRewardAlternativeButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _animInTween
public static readonly Godot.StringName _currentTween
public static readonly Godot.StringName _hotkeys
public static readonly Godot.StringName _hsv
public static readonly Godot.StringName _hsvDefault
public static readonly Godot.StringName _hsvDown
public static readonly Godot.StringName _hsvHover
public static readonly Godot.StringName _image
public static readonly Godot.StringName _label
public static readonly Godot.StringName _optionName
public static readonly Godot.StringName _showPosition
public static readonly Godot.StringName Hotkeys
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardRewardAlternativeButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardRewardSelectionScreen

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.Overlays.IOverlayScreen`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private MegaCrit.Sts2.Core.Nodes.CommonUi.NCommonBanner _banner
private static readonly Godot.Vector2 _bannerAnimPosOffset
private Godot.Tween _buttonTween
private Godot.Control _cardRow
private Godot.Tween _cardTween
private static const System.Single _cardXOffset = 350
private System.Threading.Tasks.TaskCompletionSource<System.Nullable<System.Int32>> _completionSource
private System.Threading.CancellationTokenSource _cts
private System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.CardRewardAlternatives.CardRewardAlternative> _extraOptions
private Godot.Control _inspectPrompt
private Godot.Control _lastFocusedControl
private static const System.UInt64 _noSelectionTimeMsec = 350
private System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Cards.CardCreationResult> _options
private Godot.Control _rewardAlternativesContainer
private Godot.Control _ui
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
Godot.Control DefaultFocusedControl { public virtual get; }
System.String ScenePath { private static get; }
MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType ScreenType { public virtual get; }
System.Boolean UseSharedBackstop { public virtual get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task DisableCardsForShortTimeAfterOpening()
private static System.String get_ScenePath()
private System.Void InspectCard(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder cardHolder)
private System.Void OnAlternateRewardSelected(System.Int32 index)
private System.Void PowerCardFtueCheck()
private System.Void SelectCard(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder cardHolder)
private System.Void UpdateControllerIcons()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public [async] System.Threading.Tasks.Task<System.Nullable<System.Int32>> OptionSelected()
public MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder GetCardHolder(MegaCrit.Sts2.Core.Models.CardModel card)
public static MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardRewardSelectionScreen ShowScreen(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Cards.CardCreationResult> options, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.CardRewardAlternatives.CardRewardAlternative> extraOptions)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Void RefreshOptions(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Cards.CardCreationResult> options, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.CardRewardAlternatives.CardRewardAlternative> extraOptions)
public virtual Godot.Control get_DefaultFocusedControl()
public virtual MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType get_ScreenType()
public virtual System.Boolean get_UseSharedBackstop()
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
public virtual System.Void AfterOverlayClosed()
public virtual System.Void AfterOverlayHidden()
public virtual System.Void AfterOverlayOpened()
public virtual System.Void AfterOverlayShown()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardRewardSelectionScreen+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardRewardSelectionScreen+<>c <>9
public static System.Action <>9__24_0
public static System.Func<MegaCrit.Sts2.Core.Nodes.Cards.Holders.NGridCardHolder, System.Boolean> <>9__33_0
private static .cctor()
public .ctor()
internal System.Boolean <PowerCardFtueCheck>b__33_0(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NGridCardHolder h)
internal System.Void <RefreshOptions>b__24_0()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardRewardSelectionScreen+<>c__DisplayClass24_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardRewardSelectionScreen <>4__this
public MegaCrit.Sts2.Core.Nodes.Cards.Holders.NGridCardHolder holder
public .ctor()
internal Godot.Control <RefreshOptions>b__1()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardRewardSelectionScreen+<>c__DisplayClass24_1

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardRewardSelectionScreen <>4__this
public System.Int32 capturedIndex
public .ctor()
internal System.Void <RefreshOptions>b__2(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardRewardSelectionScreen+<>c__DisplayClass26_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Models.CardModel card
public .ctor()
internal System.Boolean <GetCardHolder>b__0(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NGridCardHolder h)
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardRewardSelectionScreen+<>c__DisplayClass28_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder cardHolder
public .ctor()
internal System.Boolean <SelectCard>b__0(MegaCrit.Sts2.Core.Entities.Cards.CardCreationResult o)
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardRewardSelectionScreen+<DisableCardsForShortTimeAfterOpening>d__32

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardRewardSelectionScreen <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardRewardSelectionScreen+<OptionSelected>d__30

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardRewardSelectionScreen <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Nullable<System.Int32>> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Nullable<System.Int32>> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardRewardSelectionScreen+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AfterOverlayClosed
public static readonly Godot.StringName AfterOverlayHidden
public static readonly Godot.StringName AfterOverlayOpened
public static readonly Godot.StringName AfterOverlayShown
public static readonly Godot.StringName InspectCard
public static readonly Godot.StringName OnAlternateRewardSelected
public static readonly Godot.StringName PowerCardFtueCheck
public static readonly Godot.StringName SelectCard
public static readonly Godot.StringName UpdateControllerIcons
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardRewardSelectionScreen+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _banner
public static readonly Godot.StringName _buttonTween
public static readonly Godot.StringName _cardRow
public static readonly Godot.StringName _cardTween
public static readonly Godot.StringName _inspectPrompt
public static readonly Godot.StringName _lastFocusedControl
public static readonly Godot.StringName _rewardAlternativesContainer
public static readonly Godot.StringName _ui
public static readonly Godot.StringName DefaultFocusedControl
public static readonly Godot.StringName ScreenType
public static readonly Godot.StringName UseSharedBackstop
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardRewardSelectionScreen+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NChoiceSelectionSkipButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private Godot.Tween _animInTween
private static readonly Godot.Vector2 _animOffsetPosition
private Godot.Tween _currentTween
private static readonly Godot.Vector2 _defaultScale
private static readonly Godot.Vector2 _downScale
private static readonly Godot.Vector2 _hoverScale
private Godot.ShaderMaterial _hsv
private Godot.Variant _hsvDefault
private Godot.Variant _hsvDown
private Godot.Variant _hsvHover
private Godot.TextureRect _image
private MegaCrit.Sts2.addons.mega_text.MegaLabel _label
private System.String _optionName
private Godot.Vector2 _showPosition
private static readonly Godot.StringName _v
System.String[] Hotkeys { protected virtual get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void UpdateShaderParam(System.Single value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.String[] get_Hotkeys()
protected virtual System.Void OnFocus()
protected virtual System.Void OnPress()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void AnimateIn()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NChoiceSelectionSkipButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AnimateIn
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName UpdateShaderParam
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NChoiceSelectionSkipButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _animInTween
public static readonly Godot.StringName _currentTween
public static readonly Godot.StringName _hsv
public static readonly Godot.StringName _hsvDefault
public static readonly Godot.StringName _hsvDown
public static readonly Godot.StringName _hsvHover
public static readonly Godot.StringName _image
public static readonly Godot.StringName _label
public static readonly Godot.StringName _optionName
public static readonly Godot.StringName _showPosition
public static readonly Godot.StringName Hotkeys
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NChoiceSelectionSkipButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NChooseABundleSelectionScreen

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.Overlays.IOverlayScreen`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private MegaCrit.Sts2.Core.Nodes.CommonUi.NCommonBanner _banner
private Godot.Control _bundlePreviewCards
private Godot.Control _bundlePreviewContainer
private Godot.Control _bundleRow
private System.Collections.Generic.IReadOnlyList<System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.CardModel>> _bundles
private Godot.Tween _cardTween
private static const System.Single _cardXSpacing = 400
private readonly System.Threading.Tasks.TaskCompletionSource<System.Collections.Generic.IEnumerable<System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.CardModel>>> _completionSource
private Godot.Tween _fadeTween
private MegaCrit.Sts2.Core.Nodes.Combat.NPeekButton _peekButton
private MegaCrit.Sts2.Core.Nodes.CommonUi.NBackButton _previewCancelButton
private MegaCrit.Sts2.Core.Nodes.CommonUi.NConfirmButton _previewConfirmButton
private MegaCrit.Sts2.Core.Nodes.Cards.NCardBundle _selectedBundle
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
Godot.Control DefaultFocusedControl { public virtual get; }
System.String ScenePath { private static get; }
MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType ScreenType { public virtual get; }
System.Boolean UseSharedBackstop { public virtual get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private static System.String get_ScenePath()
private System.Void CancelSelection(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void ConfirmSelection(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OnBundleClicked(MegaCrit.Sts2.Core.Nodes.Cards.NCardBundle bundleNode)
private System.Void OpenPreviewScreen(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder cardHolder)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public [async] System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.CardModel>>> CardsSelected()
public static MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NChooseABundleSelectionScreen ShowScreen(System.Collections.Generic.IReadOnlyList<System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.CardModel>> bundles)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual Godot.Control get_DefaultFocusedControl()
public virtual MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType get_ScreenType()
public virtual System.Boolean get_UseSharedBackstop()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
public virtual System.Void AfterOverlayClosed()
public virtual System.Void AfterOverlayHidden()
public virtual System.Void AfterOverlayOpened()
public virtual System.Void AfterOverlayShown()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NChooseABundleSelectionScreen+<CardsSelected>d__26

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NChooseABundleSelectionScreen <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.CardModel>>> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IEnumerable<System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.CardModel>>> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NChooseABundleSelectionScreen+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AfterOverlayClosed
public static readonly Godot.StringName AfterOverlayHidden
public static readonly Godot.StringName AfterOverlayOpened
public static readonly Godot.StringName AfterOverlayShown
public static readonly Godot.StringName CancelSelection
public static readonly Godot.StringName ConfirmSelection
public static readonly Godot.StringName OnBundleClicked
public static readonly Godot.StringName OpenPreviewScreen
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NChooseABundleSelectionScreen+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _banner
public static readonly Godot.StringName _bundlePreviewCards
public static readonly Godot.StringName _bundlePreviewContainer
public static readonly Godot.StringName _bundleRow
public static readonly Godot.StringName _cardTween
public static readonly Godot.StringName _fadeTween
public static readonly Godot.StringName _peekButton
public static readonly Godot.StringName _previewCancelButton
public static readonly Godot.StringName _previewConfirmButton
public static readonly Godot.StringName _selectedBundle
public static readonly Godot.StringName DefaultFocusedControl
public static readonly Godot.StringName ScreenType
public static readonly Godot.StringName UseSharedBackstop
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NChooseABundleSelectionScreen+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NChooseACardSelectionScreen

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.Overlays.IOverlayScreen`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`, `MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.ICardSelector`

```text
private MegaCrit.Sts2.Core.Nodes.CommonUi.NCommonBanner _banner
private System.Boolean _canSkip
private Godot.Control _cardRow
private System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.CardModel> _cards
private System.Boolean _cardSelected
private Godot.Tween _cardTween
private static const System.Single _cardXSpacing = 340
private MegaCrit.Sts2.Core.Nodes.Combat.NCombatPilesContainer _combatPiles
private readonly System.Threading.Tasks.TaskCompletionSource<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> _completionSource
private Godot.Tween _fadeTween
private Godot.Control _inspectPrompt
private static const System.UInt64 _noSelectionTimeMsec = 350
private System.UInt64 _openedTicks
private MegaCrit.Sts2.Core.Nodes.Combat.NPeekButton _peekButton
private System.Boolean _screenComplete
private MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NChoiceSelectionSkipButton _skipButton
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
Godot.Control DefaultFocusedControl { public virtual get; }
System.String ScenePath { private static get; }
MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType ScreenType { public virtual get; }
System.Boolean UseSharedBackstop { public virtual get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private static System.String get_ScenePath()
private System.Void <_Ready>b__23_0(MegaCrit.Sts2.Core.Nodes.Combat.NPeekButton _)
private System.Void OnSkipButtonReleased(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OpenPreviewScreen(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder cardHolder)
private System.Void SelectHolder(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder cardHolder)
private System.Void UpdateControllerIcons()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NChooseACardSelectionScreen ShowScreen(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.CardModel> cards, System.Boolean canSkip)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual [async] System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> CardsSelected()
public virtual Godot.Control get_DefaultFocusedControl()
public virtual MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType get_ScreenType()
public virtual System.Boolean get_UseSharedBackstop()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
public virtual System.Void AfterOverlayClosed()
public virtual System.Void AfterOverlayHidden()
public virtual System.Void AfterOverlayOpened()
public virtual System.Void AfterOverlayShown()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NChooseACardSelectionScreen+<CardsSelected>d__27

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NChooseACardSelectionScreen <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NChooseACardSelectionScreen+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AfterOverlayClosed
public static readonly Godot.StringName AfterOverlayHidden
public static readonly Godot.StringName AfterOverlayOpened
public static readonly Godot.StringName AfterOverlayShown
public static readonly Godot.StringName OnSkipButtonReleased
public static readonly Godot.StringName OpenPreviewScreen
public static readonly Godot.StringName SelectHolder
public static readonly Godot.StringName UpdateControllerIcons
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NChooseACardSelectionScreen+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _banner
public static readonly Godot.StringName _canSkip
public static readonly Godot.StringName _cardRow
public static readonly Godot.StringName _cardSelected
public static readonly Godot.StringName _cardTween
public static readonly Godot.StringName _combatPiles
public static readonly Godot.StringName _fadeTween
public static readonly Godot.StringName _inspectPrompt
public static readonly Godot.StringName _openedTicks
public static readonly Godot.StringName _peekButton
public static readonly Godot.StringName _screenComplete
public static readonly Godot.StringName _skipButton
public static readonly Godot.StringName DefaultFocusedControl
public static readonly Godot.StringName ScreenType
public static readonly Godot.StringName UseSharedBackstop
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NChooseACardSelectionScreen+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCombatPileCardSelectScreen

类型属性：`Public, Sealed, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardGridSelectionScreen`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.Overlays.IOverlayScreen`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`, `MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.ICardSelector`

```text
private Godot.Control _bottomTextContainer
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Cards.CardCreationResult> _cardResults
private MegaCrit.Sts2.Core.Nodes.Combat.NCombatPilesContainer _combatPiles
private MegaCrit.Sts2.Core.Nodes.CommonUi.NConfirmButton _confirmButton
private System.Threading.CancellationTokenSource _cts
private System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> _filter
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _infoLabel
private System.Boolean _isSubscribedToPile
private MegaCrit.Sts2.Core.Entities.Cards.CardPile _pile
private MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs _prefs
private System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Models.CardModel> _selectedCards
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
System.Collections.Generic.IEnumerable<Godot.Control> PeekButtonTargets { protected virtual get; }
System.String ScenePath { private static get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task FlashRelicsOnModifiedCards()
private static System.String get_ScenePath()
private System.Void <_Ready>b__16_0(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void <ConnectSignalsAndInitGrid>b__19_0(MegaCrit.Sts2.Core.Nodes.Combat.NPeekButton _)
private System.Void CheckIfSelectionComplete()
private System.Void CompleteSelection()
private System.Void UnsubscribeFromPile()
private System.Void UpdateConfirmButton()
private System.Void UpdatePileContents()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Collections.Generic.IEnumerable<Godot.Control> get_PeekButtonTargets()
protected virtual System.Void ConnectSignalsAndInitGrid()
protected virtual System.Void OnCardClicked(MegaCrit.Sts2.Core.Models.CardModel card)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCombatPileCardSelectScreen Create(MegaCrit.Sts2.Core.Entities.Cards.CardPile pile, MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs prefs, System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> filter)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
public virtual System.Void AfterOverlayOpened()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCombatPileCardSelectScreen+<>c__DisplayClass23_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Entities.Cards.CardCreationResult result
public .ctor()
internal System.Boolean <FlashRelicsOnModifiedCards>b__0(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NGridCardHolder h)
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCombatPileCardSelectScreen+<>c__DisplayClass29_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.CardModel> validPileCards
public .ctor()
internal System.Boolean <UpdatePileContents>b__0(MegaCrit.Sts2.Core.Models.CardModel c)
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCombatPileCardSelectScreen+<FlashRelicsOnModifiedCards>d__23

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCombatPileCardSelectScreen <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCombatPileCardSelectScreen+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardGridSelectionScreen+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AfterOverlayOpened
public static readonly Godot.StringName CheckIfSelectionComplete
public static readonly Godot.StringName CompleteSelection
public static readonly Godot.StringName ConnectSignalsAndInitGrid
public static readonly Godot.StringName UnsubscribeFromPile
public static readonly Godot.StringName UpdateConfirmButton
public static readonly Godot.StringName UpdatePileContents
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCombatPileCardSelectScreen+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardGridSelectionScreen+PropertyName`。

接口：

```text
public static readonly Godot.StringName _bottomTextContainer
public static readonly Godot.StringName _combatPiles
public static readonly Godot.StringName _confirmButton
public static readonly Godot.StringName _infoLabel
public static readonly Godot.StringName _isSubscribedToPile
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCombatPileCardSelectScreen+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardGridSelectionScreen+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NDeckCardSelectScreen

类型属性：`Public, Sealed, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardGridSelectionScreen`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.Overlays.IOverlayScreen`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`, `MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.ICardSelector`

```text
private MegaCrit.Sts2.Core.Nodes.CommonUi.NBackButton _closeButton
private MegaCrit.Sts2.Core.Nodes.CommonUi.NConfirmButton _confirmButton
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _infoLabel
private MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs _prefs
private MegaCrit.Sts2.Core.Nodes.CommonUi.NBackButton _previewCancelButton
private Godot.Control _previewCards
private MegaCrit.Sts2.Core.Nodes.CommonUi.NConfirmButton _previewConfirmButton
private Godot.Control _previewContainer
private readonly System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Models.CardModel> _selectedCards
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
Godot.Control DefaultFocusedControl { public virtual get; }
Godot.Control FocusedControlFromTopBar { public virtual get; }
System.Collections.Generic.IEnumerable<Godot.Control> PeekButtonTargets { protected virtual get; }
System.String ScenePath { private static get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private static System.String get_ScenePath()
private System.Void <PreviewSelection>b__20_0()
private System.Void CancelSelection(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void CheckIfSelectionComplete()
private System.Void CloseSelection(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void ConfirmSelection(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void PreviewSelection()
private System.Void PreviewSelection(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void RefreshConfirmButtonVisibility()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Collections.Generic.IEnumerable<Godot.Control> get_PeekButtonTargets()
protected virtual System.Void OnCardClicked(MegaCrit.Sts2.Core.Models.CardModel card)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NDeckCardSelectScreen Create(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.CardModel> cards, MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs prefs)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual Godot.Control get_DefaultFocusedControl()
public virtual Godot.Control get_FocusedControlFromTopBar()
public virtual System.Void _Ready()
public virtual System.Void AfterOverlayHidden()
public virtual System.Void AfterOverlayShown()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NDeckCardSelectScreen+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardGridSelectionScreen+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AfterOverlayHidden
public static readonly Godot.StringName AfterOverlayShown
public static readonly Godot.StringName CancelSelection
public static readonly Godot.StringName CheckIfSelectionComplete
public static readonly Godot.StringName CloseSelection
public static readonly Godot.StringName ConfirmSelection
public static readonly Godot.StringName PreviewSelection
public static readonly Godot.StringName RefreshConfirmButtonVisibility
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NDeckCardSelectScreen+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardGridSelectionScreen+PropertyName`。

接口：

```text
public static readonly Godot.StringName _closeButton
public static readonly Godot.StringName _confirmButton
public static readonly Godot.StringName _infoLabel
public static readonly Godot.StringName _previewCancelButton
public static readonly Godot.StringName _previewCards
public static readonly Godot.StringName _previewConfirmButton
public static readonly Godot.StringName _previewContainer
public static readonly Godot.StringName DefaultFocusedControl
public static readonly Godot.StringName FocusedControlFromTopBar
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NDeckCardSelectScreen+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardGridSelectionScreen+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NDeckEnchantSelectScreen

类型属性：`Public, Sealed, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardGridSelectionScreen`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.Overlays.IOverlayScreen`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`, `MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.ICardSelector`

```text
private Godot.Control _bottomTextContainer
private MegaCrit.Sts2.Core.Nodes.CommonUi.NBackButton _closeButton
private MegaCrit.Sts2.Core.Nodes.CommonUi.NConfirmButton _confirmButton
private MegaCrit.Sts2.Core.Models.EnchantmentModel _enchantment
private System.Int32 _enchantmentAmount
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _enchantmentDescription
private Godot.Control _enchantmentDescriptionContainer
private Godot.TextureRect _enchantmentIcon
private MegaCrit.Sts2.addons.mega_text.MegaLabel _enchantmentTitle
private Godot.Control _enchantMultiPreviewContainer
private Godot.Control _enchantSinglePreviewContainer
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _infoLabel
private Godot.Control _multiPreview
private MegaCrit.Sts2.Core.Nodes.CommonUi.NBackButton _multiPreviewCancelButton
private MegaCrit.Sts2.Core.Nodes.CommonUi.NConfirmButton _multiPreviewConfirmButton
private MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs _prefs
private readonly System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Models.CardModel> _selectedCards
private MegaCrit.Sts2.Core.Nodes.Cards.NEnchantPreview _singlePreview
private MegaCrit.Sts2.Core.Nodes.CommonUi.NBackButton _singlePreviewCancelButton
private MegaCrit.Sts2.Core.Nodes.CommonUi.NConfirmButton _singlePreviewConfirmButton
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
Godot.Control DefaultFocusedControl { public virtual get; }
Godot.Control FocusedControlFromTopBar { public virtual get; }
System.Collections.Generic.IEnumerable<Godot.Control> PeekButtonTargets { protected virtual get; }
System.String ScenePath { private static get; }
System.Boolean UseSingleSelection { private get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private static System.String get_ScenePath()
private System.Boolean get_UseSingleSelection()
private System.Void CancelSelection(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void CheckIfSelectionComplete()
private System.Void CloseSelection(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void ConfirmSelection(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton inputEvent)
private System.Void PreviewSelection()
private System.Void PreviewSelection(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void RefreshConfirmButtonVisibility()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Collections.Generic.IEnumerable<Godot.Control> get_PeekButtonTargets()
protected virtual System.Void OnCardClicked(MegaCrit.Sts2.Core.Models.CardModel card)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NDeckEnchantSelectScreen ShowScreen(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.CardModel> cards, MegaCrit.Sts2.Core.Models.EnchantmentModel enchantment, System.Int32 amount, MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs prefs)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual Godot.Control get_DefaultFocusedControl()
public virtual Godot.Control get_FocusedControlFromTopBar()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NDeckEnchantSelectScreen+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardGridSelectionScreen+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName CancelSelection
public static readonly Godot.StringName CheckIfSelectionComplete
public static readonly Godot.StringName CloseSelection
public static readonly Godot.StringName ConfirmSelection
public static readonly Godot.StringName PreviewSelection
public static readonly Godot.StringName RefreshConfirmButtonVisibility
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NDeckEnchantSelectScreen+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardGridSelectionScreen+PropertyName`。

接口：

```text
public static readonly Godot.StringName _bottomTextContainer
public static readonly Godot.StringName _closeButton
public static readonly Godot.StringName _confirmButton
public static readonly Godot.StringName _enchantmentAmount
public static readonly Godot.StringName _enchantmentDescription
public static readonly Godot.StringName _enchantmentDescriptionContainer
public static readonly Godot.StringName _enchantmentIcon
public static readonly Godot.StringName _enchantmentTitle
public static readonly Godot.StringName _enchantMultiPreviewContainer
public static readonly Godot.StringName _enchantSinglePreviewContainer
public static readonly Godot.StringName _infoLabel
public static readonly Godot.StringName _multiPreview
public static readonly Godot.StringName _multiPreviewCancelButton
public static readonly Godot.StringName _multiPreviewConfirmButton
public static readonly Godot.StringName _singlePreview
public static readonly Godot.StringName _singlePreviewCancelButton
public static readonly Godot.StringName _singlePreviewConfirmButton
public static readonly Godot.StringName DefaultFocusedControl
public static readonly Godot.StringName FocusedControlFromTopBar
public static readonly Godot.StringName UseSingleSelection
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NDeckEnchantSelectScreen+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardGridSelectionScreen+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NDeckTransformSelectScreen

类型属性：`Public, Sealed, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardGridSelectionScreen`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.Overlays.IOverlayScreen`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`, `MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.ICardSelector`

```text
private Godot.Control _bottomTextContainer
private System.Func<MegaCrit.Sts2.Core.Models.CardModel, MegaCrit.Sts2.Core.Entities.Cards.CardTransformation> _cardToTransformation
private MegaCrit.Sts2.Core.Nodes.CommonUi.NBackButton _closeButton
private MegaCrit.Sts2.Core.Nodes.CommonUi.NConfirmButton _confirmButton
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _infoLabel
private MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs _prefs
private MegaCrit.Sts2.Core.Nodes.CommonUi.NBackButton _previewCancelButton
private MegaCrit.Sts2.Core.Nodes.CommonUi.NConfirmButton _previewConfirmButton
private Godot.Control _previewContainer
private readonly System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Models.CardModel> _selectedCards
private MegaCrit.Sts2.Core.Nodes.Cards.NTransformPreview _transformPreview
private MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox _viewUpgrades
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
Godot.Control DefaultFocusedControl { public virtual get; }
Godot.Control FocusedControlFromTopBar { public virtual get; }
System.Collections.Generic.IEnumerable<Godot.Control> PeekButtonTargets { protected virtual get; }
System.String ScenePath { private static get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private static System.String get_ScenePath()
private System.Void CancelSelection(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void CloseSelection(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void CompleteSelection(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void ConfirmSelection(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OnControllerStateUpdated()
private System.Void OpenPreviewScreen()
private System.Void RefreshConfirmButtonVisibility()
private System.Void ToggleShowUpgrades(MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox tickbox)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Collections.Generic.IEnumerable<Godot.Control> get_PeekButtonTargets()
protected virtual System.Void OnCardClicked(MegaCrit.Sts2.Core.Models.CardModel card)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NDeckTransformSelectScreen ShowScreen(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.CardModel> cards, System.Func<MegaCrit.Sts2.Core.Models.CardModel, MegaCrit.Sts2.Core.Entities.Cards.CardTransformation> cardToTransformation, MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs prefs)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual Godot.Control get_DefaultFocusedControl()
public virtual Godot.Control get_FocusedControlFromTopBar()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NDeckTransformSelectScreen+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardGridSelectionScreen+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName CancelSelection
public static readonly Godot.StringName CloseSelection
public static readonly Godot.StringName CompleteSelection
public static readonly Godot.StringName ConfirmSelection
public static readonly Godot.StringName OnControllerStateUpdated
public static readonly Godot.StringName OpenPreviewScreen
public static readonly Godot.StringName RefreshConfirmButtonVisibility
public static readonly Godot.StringName ToggleShowUpgrades
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NDeckTransformSelectScreen+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardGridSelectionScreen+PropertyName`。

接口：

```text
public static readonly Godot.StringName _bottomTextContainer
public static readonly Godot.StringName _closeButton
public static readonly Godot.StringName _confirmButton
public static readonly Godot.StringName _infoLabel
public static readonly Godot.StringName _previewCancelButton
public static readonly Godot.StringName _previewConfirmButton
public static readonly Godot.StringName _previewContainer
public static readonly Godot.StringName _transformPreview
public static readonly Godot.StringName _viewUpgrades
public static readonly Godot.StringName DefaultFocusedControl
public static readonly Godot.StringName FocusedControlFromTopBar
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NDeckTransformSelectScreen+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardGridSelectionScreen+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NDeckUpgradeSelectScreen

类型属性：`Public, Sealed, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardGridSelectionScreen`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.Overlays.IOverlayScreen`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`, `MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.ICardSelector`

```text
private Godot.Control _bottomTextContainer
private MegaCrit.Sts2.Core.Nodes.CommonUi.NBackButton _closeButton
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _infoLabel
private Godot.Control _multiPreview
private MegaCrit.Sts2.Core.Nodes.CommonUi.NBackButton _multiPreviewCancelButton
private MegaCrit.Sts2.Core.Nodes.CommonUi.NConfirmButton _multiPreviewConfirmButton
private MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs _prefs
private MegaCrit.Sts2.Core.Runs.IRunState _runState
private readonly System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Models.CardModel> _selectedCards
private MegaCrit.Sts2.Core.Nodes.Cards.NUpgradePreview _singlePreview
private MegaCrit.Sts2.Core.Nodes.CommonUi.NBackButton _singlePreviewCancelButton
private MegaCrit.Sts2.Core.Nodes.CommonUi.NConfirmButton _singlePreviewConfirmButton
private Godot.Control _upgradeMultiPreviewContainer
private Godot.Control _upgradeSinglePreviewContainer
private MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox _viewUpgrades
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
Godot.Control DefaultFocusedControl { public virtual get; }
Godot.Control FocusedControlFromTopBar { public virtual get; }
System.Collections.Generic.IEnumerable<Godot.Control> PeekButtonTargets { protected virtual get; }
System.String ScenePath { private static get; }
System.Boolean UseSingleSelection { private get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private static System.String get_ScenePath()
private System.Boolean get_UseSingleSelection()
private System.Void CancelSelection(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void CheckIfSelectionComplete()
private System.Void CloseSelection(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void ConfirmSelection(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OnControllerStateUpdated()
private System.Void ToggleShowUpgrades(MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox tickbox)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Collections.Generic.IEnumerable<Godot.Control> get_PeekButtonTargets()
protected virtual System.Void OnCardClicked(MegaCrit.Sts2.Core.Models.CardModel card)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NDeckUpgradeSelectScreen ShowScreen(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.CardModel> cards, MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs prefs, MegaCrit.Sts2.Core.Runs.IRunState runState)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual Godot.Control get_DefaultFocusedControl()
public virtual Godot.Control get_FocusedControlFromTopBar()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NDeckUpgradeSelectScreen+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardGridSelectionScreen+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName CancelSelection
public static readonly Godot.StringName CheckIfSelectionComplete
public static readonly Godot.StringName CloseSelection
public static readonly Godot.StringName ConfirmSelection
public static readonly Godot.StringName OnControllerStateUpdated
public static readonly Godot.StringName ToggleShowUpgrades
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NDeckUpgradeSelectScreen+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardGridSelectionScreen+PropertyName`。

接口：

```text
public static readonly Godot.StringName _bottomTextContainer
public static readonly Godot.StringName _closeButton
public static readonly Godot.StringName _infoLabel
public static readonly Godot.StringName _multiPreview
public static readonly Godot.StringName _multiPreviewCancelButton
public static readonly Godot.StringName _multiPreviewConfirmButton
public static readonly Godot.StringName _singlePreview
public static readonly Godot.StringName _singlePreviewCancelButton
public static readonly Godot.StringName _singlePreviewConfirmButton
public static readonly Godot.StringName _upgradeMultiPreviewContainer
public static readonly Godot.StringName _upgradeSinglePreviewContainer
public static readonly Godot.StringName _viewUpgrades
public static readonly Godot.StringName DefaultFocusedControl
public static readonly Godot.StringName FocusedControlFromTopBar
public static readonly Godot.StringName UseSingleSelection
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NDeckUpgradeSelectScreen+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardGridSelectionScreen+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NSimpleCardSelectScreen

类型属性：`Public, Sealed, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardGridSelectionScreen`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.Overlays.IOverlayScreen`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`, `MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.ICardSelector`

```text
private Godot.Control _bottomTextContainer
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Cards.CardCreationResult> _cardResults
private MegaCrit.Sts2.Core.Nodes.Combat.NCombatPilesContainer _combatPiles
private MegaCrit.Sts2.Core.Nodes.CommonUi.NConfirmButton _confirmButton
private System.Threading.CancellationTokenSource _cts
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _infoLabel
private MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs _prefs
private readonly System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Models.CardModel> _selectedCards
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
System.Collections.Generic.IEnumerable<Godot.Control> PeekButtonTargets { protected virtual get; }
System.String ScenePath { private static get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task FlashRelicsOnModifiedCards()
private static System.String get_ScenePath()
private System.Void <_Ready>b__14_0(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void <ConnectSignalsAndInitGrid>b__17_0(MegaCrit.Sts2.Core.Nodes.Combat.NPeekButton _)
private System.Void CheckIfSelectionComplete()
private System.Void CompleteSelection()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Collections.Generic.IEnumerable<Godot.Control> get_PeekButtonTargets()
protected virtual System.Void ConnectSignalsAndInitGrid()
protected virtual System.Void OnCardClicked(MegaCrit.Sts2.Core.Models.CardModel card)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NSimpleCardSelectScreen Create(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Entities.Cards.CardCreationResult> cards, MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs prefs)
public static MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NSimpleCardSelectScreen Create(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.CardModel> cards, MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs prefs)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
public virtual System.Void AfterOverlayOpened()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NSimpleCardSelectScreen+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NSimpleCardSelectScreen+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Entities.Cards.CardCreationResult, MegaCrit.Sts2.Core.Models.CardModel> <>9__13_1
private static .cctor()
public .ctor()
internal MegaCrit.Sts2.Core.Models.CardModel <Create>b__13_1(MegaCrit.Sts2.Core.Entities.Cards.CardCreationResult r)
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NSimpleCardSelectScreen+<>c__DisplayClass13_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.CardSelection.CardSelectorPrefs prefs
public .ctor()
internal System.Int32 <Create>b__0(MegaCrit.Sts2.Core.Entities.Cards.CardCreationResult c1, MegaCrit.Sts2.Core.Entities.Cards.CardCreationResult c2)
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NSimpleCardSelectScreen+<>c__DisplayClass21_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Entities.Cards.CardCreationResult result
public .ctor()
internal System.Boolean <FlashRelicsOnModifiedCards>b__0(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NGridCardHolder h)
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NSimpleCardSelectScreen+<FlashRelicsOnModifiedCards>d__21

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NSimpleCardSelectScreen <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NSimpleCardSelectScreen+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardGridSelectionScreen+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AfterOverlayOpened
public static readonly Godot.StringName CheckIfSelectionComplete
public static readonly Godot.StringName CompleteSelection
public static readonly Godot.StringName ConnectSignalsAndInitGrid
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NSimpleCardSelectScreen+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardGridSelectionScreen+PropertyName`。

接口：

```text
public static readonly Godot.StringName _bottomTextContainer
public static readonly Godot.StringName _combatPiles
public static readonly Godot.StringName _confirmButton
public static readonly Godot.StringName _infoLabel
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NSimpleCardSelectScreen+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.CardSelection.NCardGridSelectionScreen+SignalName`。

接口：

```text
public .ctor()
```
