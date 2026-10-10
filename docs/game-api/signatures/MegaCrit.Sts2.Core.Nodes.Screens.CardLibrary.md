# MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardCostTickbox

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private System.Single _baseS
private Godot.Vector2 _baseScale
private System.Single _baseV
private System.Single _hoverScale
private System.Single _hoverV
private Godot.ShaderMaterial _hsv
private Godot.Control _image
private System.Boolean _isTicked
private Godot.Control _outline
private System.Single _pressDownScale
private static readonly Godot.StringName _s
private Godot.Tween _tween
private static readonly Godot.StringName _v
private MegaCrit.Sts2.Core.Localization.LocString <Loc>k__BackingField
System.Boolean IsTicked { public get; public set; }
MegaCrit.Sts2.Core.Localization.LocString Loc { public get; public set; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void <_Ready>b__20_0(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OnToggle()
private System.Void UpdateShaderS(System.Single value)
private System.Void UpdateShaderV(System.Single value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnFocus()
protected virtual System.Void OnPress()
protected virtual System.Void OnRelease()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public MegaCrit.Sts2.Core.Localization.LocString get_Loc()
public System.Boolean get_IsTicked()
public System.Void set_IsTicked(System.Boolean value)
public System.Void set_Loc(MegaCrit.Sts2.Core.Localization.LocString value)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardCostTickbox+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnToggle
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName UpdateShaderS
public static readonly Godot.StringName UpdateShaderV
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardCostTickbox+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _baseS
public static readonly Godot.StringName _baseScale
public static readonly Godot.StringName _baseV
public static readonly Godot.StringName _hoverScale
public static readonly Godot.StringName _hoverV
public static readonly Godot.StringName _hsv
public static readonly Godot.StringName _image
public static readonly Godot.StringName _isTicked
public static readonly Godot.StringName _outline
public static readonly Godot.StringName _pressDownScale
public static readonly Godot.StringName _tween
public static readonly Godot.StringName IsTicked
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardCostTickbox+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardLibrary

类型属性：`Public, Sealed, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private MegaCrit.Sts2.Core.Nodes.CommonUi.NCardViewSortButton _alphabetSorter
private MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardPoolFilter _ancientsFilter
private MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardTypeTickbox _attackFilter
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _cardCountLabel
private readonly MegaCrit.Sts2.Core.Localization.LocString _cardCountLocString
private readonly System.Collections.Generic.Dictionary<MegaCrit.Sts2.Core.Models.CharacterModel, MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardPoolFilter> _cardPoolFilters
private readonly System.Collections.Generic.Dictionary<MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardTypeTickbox, System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean>> _cardTypeFilters
private MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardPoolFilter _colorlessFilter
private MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardRarityTickbox _commonFilter
private readonly System.Collections.Generic.Dictionary<MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardCostTickbox, System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean>> _costFilters
private MegaCrit.Sts2.Core.Nodes.CommonUi.NCardViewSortButton _costSorter
private MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardPoolFilter _defectFilter
private static const System.Int32 _delayAfterTextFilterChangedMsec = 250
private System.Threading.CancellationTokenSource _displayCardsShortDelayCancelToken
private System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> _filter
private MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardLibraryGrid _grid
private MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardPoolFilter _ironcladFilter
private Godot.Control _lastHoveredControl
private MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardPoolFilter _miscPoolFilter
private MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardPoolFilter _necrobinderFilter
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _noResultsLabel
private readonly MegaCrit.Sts2.Core.Localization.LocString _noResultsLocString
private MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardCostTickbox _oneFilter
private MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardRarityTickbox _otherFilter
private MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardTypeTickbox _otherTypeFilter
private readonly System.Collections.Generic.Dictionary<MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardPoolFilter, System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean>> _poolFilters
private MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardTypeTickbox _powerFilter
private MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardRarityTickbox _rareFilter
private readonly System.Collections.Generic.Dictionary<MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardRarityTickbox, System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean>> _rarityFilters
private MegaCrit.Sts2.Core.Nodes.CommonUi.NCardViewSortButton _raritySorter
private MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardPoolFilter _regentFilter
private MegaCrit.Sts2.Core.Runs.IRunState _runState
private static readonly System.String _scenePath
private MegaCrit.Sts2.Core.Nodes.CommonUi.NSearchBar _searchBar
private MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardPoolFilter _silentFilter
private MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardTypeTickbox _skillFilter
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.SortingOrders> _sortingPriority
private readonly System.Collections.Generic.Dictionary<System.String, System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean>> _specialSearchbarKeywords
private MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardCostTickbox _threePlusFilter
private MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardCostTickbox _twoFilter
private MegaCrit.Sts2.Core.Nodes.CommonUi.NCardViewSortButton _typeSorter
private MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardRarityTickbox _uncommonFilter
private MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NLibraryStatTickbox _viewMultiplayerCards
private MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NLibraryStatTickbox _viewStats
private MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NLibraryStatTickbox _viewUpgrades
private MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardCostTickbox _xFilter
private MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardCostTickbox _zeroFilter
System.String[] AssetPaths { public static get; }
Godot.Control InitialFocusedControl { protected virtual get; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task DisplayCards()
private [async] System.Threading.Tasks.Task DisplayCardsAfterShortDelay()
private System.Void <_Ready>b__50_21()
private System.Void <_Ready>b__50_22()
private System.Void <_Ready>b__50_23()
private System.Void <_Ready>b__50_24()
private System.Void <_Ready>b__50_25()
private System.Void <_Ready>b__50_26()
private System.Void <_Ready>b__50_27()
private System.Void <_Ready>b__50_28()
private System.Void <_Ready>b__50_29()
private System.Void <_Ready>b__50_30()
private System.Void <_Ready>b__50_31()
private System.Void <_Ready>b__50_32()
private System.Void <_Ready>b__50_33()
private System.Void <_Ready>b__50_34()
private System.Void <_Ready>b__50_35()
private System.Void <_Ready>b__50_36()
private System.Void <_Ready>b__50_37()
private System.Void <_Ready>b__50_38()
private System.Void <_Ready>b__50_39()
private System.Void <_Ready>b__50_40()
private System.Void <_Ready>b__50_41()
private System.Void <_Ready>b__50_42()
private System.Void OnAlphabetSort(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton button)
private System.Void OnCardTypeSort(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton button)
private System.Void OnCostSort(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton button)
private System.Void OnRaritySort(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton button)
private System.Void SearchBarQueryChanged(System.String _ = "")
private System.Void SearchBarQuerySubmitted(System.String _ = "")
private System.Void ShowCardDetail(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder holder)
private System.Void ToggleFilterMultiplayerCards(MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox tickbox)
private System.Void ToggleShowStats(MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox tickbox)
private System.Void ToggleShowUpgrades(MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox tickbox)
private System.Void UpdateCardPoolFilter(MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardPoolFilter filter)
private System.Void UpdateCostFilter(MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardCostTickbox tickbox)
private System.Void UpdateFilter(System.Boolean isTextInput = False)
private System.Void UpdateRarityFilter(MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox tickbox)
private System.Void UpdateTypeFilter(MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardTypeTickbox tickbox)
protected virtual Godot.Control get_InitialFocusedControl()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardLibrary Create()
public static System.String[] get_AssetPaths()
public System.Void Initialize(MegaCrit.Sts2.Core.Runs.IRunState runState)
public virtual System.Void _Ready()
public virtual System.Void OnSubmenuClosed()
public virtual System.Void OnSubmenuOpened()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardLibrary+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardLibrary+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> <>9__50_0
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> <>9__50_1
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> <>9__50_10
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> <>9__50_11
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> <>9__50_12
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> <>9__50_13
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> <>9__50_14
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> <>9__50_15
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> <>9__50_16
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> <>9__50_17
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> <>9__50_18
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> <>9__50_19
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> <>9__50_2
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> <>9__50_20
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> <>9__50_3
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> <>9__50_4
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> <>9__50_5
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> <>9__50_6
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> <>9__50_7
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> <>9__50_8
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> <>9__50_9
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> <>9__69_0
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> <>9__69_1
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> <>9__69_2
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> <>9__69_3
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> <>9__69_4
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> <>9__70_0
public static System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> <>9__85_0
private static .cctor()
public .ctor()
internal System.Boolean <_Ready>b__50_0(MegaCrit.Sts2.Core.Models.CardModel c)
internal System.Boolean <_Ready>b__50_1(MegaCrit.Sts2.Core.Models.CardModel c)
internal System.Boolean <_Ready>b__50_10(MegaCrit.Sts2.Core.Models.CardModel c)
internal System.Boolean <_Ready>b__50_11(MegaCrit.Sts2.Core.Models.CardModel c)
internal System.Boolean <_Ready>b__50_12(MegaCrit.Sts2.Core.Models.CardModel c)
internal System.Boolean <_Ready>b__50_13(MegaCrit.Sts2.Core.Models.CardModel c)
internal System.Boolean <_Ready>b__50_14(MegaCrit.Sts2.Core.Models.CardModel c)
internal System.Boolean <_Ready>b__50_15(MegaCrit.Sts2.Core.Models.CardModel c)
internal System.Boolean <_Ready>b__50_16(MegaCrit.Sts2.Core.Models.CardModel c)
internal System.Boolean <_Ready>b__50_17(MegaCrit.Sts2.Core.Models.CardModel c)
internal System.Boolean <_Ready>b__50_18(MegaCrit.Sts2.Core.Models.CardModel c)
internal System.Boolean <_Ready>b__50_19(MegaCrit.Sts2.Core.Models.CardModel c)
internal System.Boolean <_Ready>b__50_2(MegaCrit.Sts2.Core.Models.CardModel c)
internal System.Boolean <_Ready>b__50_20(MegaCrit.Sts2.Core.Models.CardModel c)
internal System.Boolean <_Ready>b__50_3(MegaCrit.Sts2.Core.Models.CardModel c)
internal System.Boolean <_Ready>b__50_4(MegaCrit.Sts2.Core.Models.CardModel c)
internal System.Boolean <_Ready>b__50_5(MegaCrit.Sts2.Core.Models.CardModel c)
internal System.Boolean <_Ready>b__50_6(MegaCrit.Sts2.Core.Models.CardModel c)
internal System.Boolean <_Ready>b__50_7(MegaCrit.Sts2.Core.Models.CardModel c)
internal System.Boolean <_Ready>b__50_8(MegaCrit.Sts2.Core.Models.CardModel c)
internal System.Boolean <_Ready>b__50_9(MegaCrit.Sts2.Core.Models.CardModel c)
internal System.Boolean <.ctor>b__85_0(MegaCrit.Sts2.Core.Models.CardModel _)
internal System.Boolean <ShowCardDetail>b__70_0(MegaCrit.Sts2.Core.Models.CardModel c)
internal System.Boolean <UpdateFilter>b__69_0(MegaCrit.Sts2.Core.Models.CardModel _)
internal System.Boolean <UpdateFilter>b__69_1(MegaCrit.Sts2.Core.Models.CardModel _)
internal System.Boolean <UpdateFilter>b__69_2(MegaCrit.Sts2.Core.Models.CardModel _)
internal System.Boolean <UpdateFilter>b__69_3(MegaCrit.Sts2.Core.Models.CardModel c)
internal System.Boolean <UpdateFilter>b__69_4(MegaCrit.Sts2.Core.Models.CardModel c)
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardLibrary+<>c__DisplayClass50_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Entities.Cards.CardRarity keyword
public .ctor()
internal System.Boolean <_Ready>b__43(MegaCrit.Sts2.Core.Models.CardModel c)
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardLibrary+<>c__DisplayClass69_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardLibrary <>4__this
public System.Collections.Generic.List<System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean>> activeCardTypeFilter
public System.Collections.Generic.List<System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean>> activeCostFilter
public System.Collections.Generic.List<System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean>> activeRarityFilters
public System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> multiplayerCardFilter
public System.Collections.Generic.List<System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean>> poolFilter
public .ctor()
internal System.Boolean <UpdateFilter>b__5(MegaCrit.Sts2.Core.Models.CardModel c)
internal System.Boolean <UpdateFilter>g__TextFilter|6(MegaCrit.Sts2.Core.Models.CardModel card)
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardLibrary+<>c__DisplayClass69_1

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Models.CardModel c
public .ctor()
internal System.Boolean <UpdateFilter>b__10(System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> filter)
internal System.Boolean <UpdateFilter>b__7(System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> filter)
internal System.Boolean <UpdateFilter>b__8(System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> filter)
internal System.Boolean <UpdateFilter>b__9(System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> filter)
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardLibrary+<DisplayCards>d__59

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardLibrary <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Runtime.CompilerServices.YieldAwaitable+YieldAwaiter <>u__2
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardLibrary+<DisplayCardsAfterShortDelay>d__58

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardLibrary <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Threading.CancellationTokenSource <cancelToken>5__2
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardLibrary+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName OnAlphabetSort
public static readonly Godot.StringName OnCardTypeSort
public static readonly Godot.StringName OnCostSort
public static readonly Godot.StringName OnRaritySort
public static readonly Godot.StringName OnSubmenuClosed
public static readonly Godot.StringName OnSubmenuOpened
public static readonly Godot.StringName SearchBarQueryChanged
public static readonly Godot.StringName SearchBarQuerySubmitted
public static readonly Godot.StringName ShowCardDetail
public static readonly Godot.StringName ToggleFilterMultiplayerCards
public static readonly Godot.StringName ToggleShowStats
public static readonly Godot.StringName ToggleShowUpgrades
public static readonly Godot.StringName UpdateCardPoolFilter
public static readonly Godot.StringName UpdateCostFilter
public static readonly Godot.StringName UpdateFilter
public static readonly Godot.StringName UpdateRarityFilter
public static readonly Godot.StringName UpdateTypeFilter
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardLibrary+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+PropertyName`。

接口：

```text
public static readonly Godot.StringName _alphabetSorter
public static readonly Godot.StringName _ancientsFilter
public static readonly Godot.StringName _attackFilter
public static readonly Godot.StringName _cardCountLabel
public static readonly Godot.StringName _colorlessFilter
public static readonly Godot.StringName _commonFilter
public static readonly Godot.StringName _costSorter
public static readonly Godot.StringName _defectFilter
public static readonly Godot.StringName _grid
public static readonly Godot.StringName _ironcladFilter
public static readonly Godot.StringName _lastHoveredControl
public static readonly Godot.StringName _miscPoolFilter
public static readonly Godot.StringName _necrobinderFilter
public static readonly Godot.StringName _noResultsLabel
public static readonly Godot.StringName _oneFilter
public static readonly Godot.StringName _otherFilter
public static readonly Godot.StringName _otherTypeFilter
public static readonly Godot.StringName _powerFilter
public static readonly Godot.StringName _rareFilter
public static readonly Godot.StringName _raritySorter
public static readonly Godot.StringName _regentFilter
public static readonly Godot.StringName _searchBar
public static readonly Godot.StringName _silentFilter
public static readonly Godot.StringName _skillFilter
public static readonly Godot.StringName _threePlusFilter
public static readonly Godot.StringName _twoFilter
public static readonly Godot.StringName _typeSorter
public static readonly Godot.StringName _uncommonFilter
public static readonly Godot.StringName _viewMultiplayerCards
public static readonly Godot.StringName _viewStats
public static readonly Godot.StringName _viewUpgrades
public static readonly Godot.StringName _xFilter
public static readonly Godot.StringName _zeroFilter
public static readonly Godot.StringName InitialFocusedControl
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardLibrary+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardLibraryGrid

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Cards.NCardGrid`。

接口：`System.IDisposable`

```text
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.CardModel> _allCards
private System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Models.ModelId> _seenCards
private System.Boolean _showStats
private System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Models.CardModel> _unlockedCards
System.Boolean CenterGrid { protected virtual get; }
System.Boolean IsCardLibrary { protected virtual get; }
System.Boolean ShowStats { public get; public set; }
System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> VisibleCards { public get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void DisplayCards(System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.CardModel> cards, System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.SortingOrders> sortingPriority)
protected virtual MegaCrit.Sts2.Core.Entities.UI.ModelVisibility GetCardVisibility(MegaCrit.Sts2.Core.Models.CardModel card)
protected virtual System.Boolean get_CenterGrid()
protected virtual System.Boolean get_IsCardLibrary()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void AssignCardsToRow(System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Cards.Holders.NGridCardHolder> row, System.Int32 startIndex)
protected virtual System.Void InitGrid()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void UpdateGridNavigation()
public System.Boolean get_ShowStats()
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> get_VisibleCards()
public System.Void FilterCards(System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> filter, System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.SortingOrders> sortingPriority)
public System.Void FilterCards(System.Func<MegaCrit.Sts2.Core.Models.CardModel, System.Boolean> filter)
public System.Void RefreshVisibility()
public System.Void set_ShowStats(System.Boolean value)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardLibraryGrid+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardLibraryGrid+<>c <>9
public static System.Func<System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Cards.Holders.NGridCardHolder>, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Nodes.Cards.Holders.NGridCardHolder>> <>9__10_0
public static System.Func<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel>> <>9__12_1
public static System.Func<System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Cards.Holders.NGridCardHolder>, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Nodes.Cards.Holders.NGridCardHolder>> <>9__17_0
private static .cctor()
public .ctor()
internal System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> <RefreshVisibility>b__12_1(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> c)
internal System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Nodes.Cards.Holders.NGridCardHolder> <InitGrid>b__17_0(System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Cards.Holders.NGridCardHolder> r)
internal System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Nodes.Cards.Holders.NGridCardHolder> <set_ShowStats>b__10_0(System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Cards.Holders.NGridCardHolder> r)
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardLibraryGrid+<>c__DisplayClass12_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Unlocks.UnlockState unlockState
public .ctor()
internal System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.CardModel> <RefreshVisibility>b__0(MegaCrit.Sts2.Core.Models.CardPoolModel p)
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardLibraryGrid+InitialSorter

类型属性：`NestedPrivate, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Collections.Generic.IComparer<MegaCrit.Sts2.Core.Models.CardModel>`

```text
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.CardPoolModel> _cardPoolModels
public .ctor(System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.CardPoolModel> cardPoolModels)
public virtual System.Int32 Compare(MegaCrit.Sts2.Core.Models.CardModel x, MegaCrit.Sts2.Core.Models.CardModel y)
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardLibraryGrid+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Cards.NCardGrid+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName InitGrid
public static readonly Godot.StringName RefreshVisibility
public static readonly Godot.StringName UpdateGridNavigation
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardLibraryGrid+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Cards.NCardGrid+PropertyName`。

接口：

```text
public static readonly Godot.StringName _showStats
public static readonly Godot.StringName CenterGrid
public static readonly Godot.StringName IsCardLibrary
public static readonly Godot.StringName ShowStats
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardLibraryGrid+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Cards.NCardGrid+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardLibraryStats

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _label
System.String ScenePath { private static get; }
MegaCrit.Sts2.Core.Localization.LocString Victories { private static get; }
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private static MegaCrit.Sts2.Core.Localization.LocString get_Victories()
private static System.String get_ScenePath()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardLibraryStats Create()
public System.Void UpdateStats(MegaCrit.Sts2.Core.Models.CardModel card)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardLibraryStats+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardLibraryStats+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _label
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardLibraryStats+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardPoolFilter

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Nodes.Combat.NSelectionReticle _controllerSelectionReticle
private static readonly Godot.Vector2 _disabledScale
private static readonly Godot.Vector2 _enabledScale
private static const System.Single _focusedMultiplier = 1.2
private Godot.ShaderMaterial _hsv
private Godot.Control _image
private System.Boolean _isSelected
private static const System.Single _pressDownMultiplier = 0.8
private static readonly Godot.StringName _s
private Godot.Tween _tween
private static readonly Godot.StringName _v
private MegaCrit.Sts2.Core.Localization.LocString <Loc>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardPoolFilter+ToggledEventHandler backing_Toggled
System.Boolean IsSelected { public get; public set; }
MegaCrit.Sts2.Core.Localization.LocString Loc { public get; public set; }
event MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardPoolFilter+ToggledEventHandler Toggled
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotSignalList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnToggle()
protected System.Void EmitSignalToggled(MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardPoolFilter filter)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean HasGodotClassSignal(in Godot.NativeInterop.godot_string_name signal)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnFocus()
protected virtual System.Void OnPress()
protected virtual System.Void OnRelease()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RaiseGodotClassSignalCallbacks(in Godot.NativeInterop.godot_string_name signal, Godot.NativeInterop.NativeVariantPtrArgs args)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public MegaCrit.Sts2.Core.Localization.LocString get_Loc()
public System.Boolean get_IsSelected()
public System.Void add_Toggled(MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardPoolFilter+ToggledEventHandler value)
public System.Void remove_Toggled(MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardPoolFilter+ToggledEventHandler value)
public System.Void set_IsSelected(System.Boolean value)
public System.Void set_Loc(MegaCrit.Sts2.Core.Localization.LocString value)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardPoolFilter+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnToggle
public static readonly Godot.StringName OnUnfocus
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardPoolFilter+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _controllerSelectionReticle
public static readonly Godot.StringName _hsv
public static readonly Godot.StringName _image
public static readonly Godot.StringName _isSelected
public static readonly Godot.StringName _tween
public static readonly Godot.StringName IsSelected
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardPoolFilter+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public static readonly Godot.StringName Toggled
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardPoolFilter+ToggledEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardPoolFilter filter, System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke(MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardPoolFilter filter)
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardRarityTickbox

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.addons.mega_text.MegaLabel _label
private Godot.Tween _labelTween
private MegaCrit.Sts2.Core.Localization.LocString <Loc>k__BackingField
MegaCrit.Sts2.Core.Localization.LocString Loc { public get; public set; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnDisable()
protected virtual System.Void OnEnable()
protected virtual System.Void OnFocus()
protected virtual System.Void OnPress()
protected virtual System.Void OnRelease()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public MegaCrit.Sts2.Core.Localization.LocString get_Loc()
public System.Void set_Loc(MegaCrit.Sts2.Core.Localization.LocString value)
public System.Void SetLabel(System.String text)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardRarityTickbox+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnDisable
public static readonly Godot.StringName OnEnable
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName SetLabel
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardRarityTickbox+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox+PropertyName`。

接口：

```text
public static readonly Godot.StringName _label
public static readonly Godot.StringName _labelTween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardRarityTickbox+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardTypeTickbox

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private System.Single _baseS
private Godot.Vector2 _baseScale
private System.Single _baseV
private System.Single _hoverScale
private Godot.ShaderMaterial _hsv
private Godot.Control _image
private System.Boolean _isTicked
private Godot.Control _outline
private System.Single _pressDownScale
private static readonly Godot.StringName _s
private Godot.Tween _tween
private static readonly Godot.StringName _v
private MegaCrit.Sts2.Core.Localization.LocString <Loc>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardTypeTickbox+ToggledEventHandler backing_Toggled
System.Boolean IsTicked { public get; public set; }
MegaCrit.Sts2.Core.Localization.LocString Loc { public get; public set; }
event MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardTypeTickbox+ToggledEventHandler Toggled
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotSignalList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnToggle()
private System.Void UpdateShaderS(System.Single value)
private System.Void UpdateShaderV(System.Single value)
protected System.Void EmitSignalToggled(MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardTypeTickbox tickbox)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean HasGodotClassSignal(in Godot.NativeInterop.godot_string_name signal)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnFocus()
protected virtual System.Void OnPress()
protected virtual System.Void OnRelease()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RaiseGodotClassSignalCallbacks(in Godot.NativeInterop.godot_string_name signal, Godot.NativeInterop.NativeVariantPtrArgs args)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public MegaCrit.Sts2.Core.Localization.LocString get_Loc()
public System.Boolean get_IsTicked()
public System.Void add_Toggled(MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardTypeTickbox+ToggledEventHandler value)
public System.Void remove_Toggled(MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardTypeTickbox+ToggledEventHandler value)
public System.Void set_IsTicked(System.Boolean value)
public System.Void set_Loc(MegaCrit.Sts2.Core.Localization.LocString value)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardTypeTickbox+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnToggle
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName UpdateShaderS
public static readonly Godot.StringName UpdateShaderV
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardTypeTickbox+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _baseS
public static readonly Godot.StringName _baseScale
public static readonly Godot.StringName _baseV
public static readonly Godot.StringName _hoverScale
public static readonly Godot.StringName _hsv
public static readonly Godot.StringName _image
public static readonly Godot.StringName _isTicked
public static readonly Godot.StringName _outline
public static readonly Godot.StringName _pressDownScale
public static readonly Godot.StringName _tween
public static readonly Godot.StringName IsTicked
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardTypeTickbox+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public static readonly Godot.StringName Toggled
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardTypeTickbox+ToggledEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardTypeTickbox tickbox, System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke(MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardTypeTickbox tickbox)
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NClearSearchButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private Godot.Control _image
private Godot.Tween _tween
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnFocus()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NClearSearchButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnUnfocus
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NClearSearchButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _image
public static readonly Godot.StringName _tween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NClearSearchButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NLibraryStatTickbox

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.addons.mega_text.MegaLabel _label
private Godot.Tween _labelTween
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnFocus()
protected virtual System.Void OnPress()
protected virtual System.Void OnRelease()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void SetLabel(System.String text)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NLibraryStatTickbox+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName SetLabel
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NLibraryStatTickbox+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox+PropertyName`。

接口：

```text
public static readonly Godot.StringName _label
public static readonly Godot.StringName _labelTween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NLibraryStatTickbox+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.SortingOrders

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.SortingOrders AlphabetAscending = 3
public static const MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.SortingOrders AlphabetDescending = 7
public static const MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.SortingOrders Ascending = 8
public static const MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.SortingOrders CostAscending = 1
public static const MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.SortingOrders CostDescending = 5
public static const MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.SortingOrders Descending = 9
public static const MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.SortingOrders RarityAscending = 0
public static const MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.SortingOrders RarityDescending = 4
public static const MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.SortingOrders TypeAscending = 2
public static const MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.SortingOrders TypeDescending = 6
public System.Int32 value__
```
