# MegaCrit.Sts2.Core.Nodes.Screens

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.Screens.CapstoneSubmenuType

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Nodes.Screens.CapstoneSubmenuType Compendium = 2
public static const MegaCrit.Sts2.Core.Nodes.Screens.CapstoneSubmenuType Feedback = 3
public static const MegaCrit.Sts2.Core.Nodes.Screens.CapstoneSubmenuType None = 0
public static const MegaCrit.Sts2.Core.Nodes.Screens.CapstoneSubmenuType PauseMenu = 4
public static const MegaCrit.Sts2.Core.Nodes.Screens.CapstoneSubmenuType Settings = 1
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Nodes.Screens.NAncientBgContainer

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private Godot.Vector2 _pos169
private Godot.Vector2 _pos219
private Godot.Vector2 _pos43
private static const System.Single _ratioMax = 2.3333
private static const System.Single _ratioMin = 1.3333
private static const System.Single _ratioNormal = 1.7777
private Godot.Vector2 _scale169
private Godot.Vector2 _scale219
private Godot.Vector2 _scale43
private Godot.Window _window
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnWindowChange()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.NAncientBgContainer+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnWindowChange
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.NAncientBgContainer+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _pos169
public static readonly Godot.StringName _pos219
public static readonly Godot.StringName _pos43
public static readonly Godot.StringName _scale169
public static readonly Godot.StringName _scale219
public static readonly Godot.StringName _scale43
public static readonly Godot.StringName _window
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.NAncientBgContainer+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.NCapstoneSubmenuStack

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.Capstones.ICapstoneScreen`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private MegaCrit.Sts2.Core.Nodes.Screens.NRunSubmenuStack <Stack>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Screens.CapstoneSubmenuType <Type>k__BackingField
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
Godot.Control DefaultFocusedControl { public virtual get; }
System.String ScenePath { private static get; }
MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType ScreenType { public virtual get; }
MegaCrit.Sts2.Core.Nodes.Screens.NRunSubmenuStack Stack { public get; private set; }
MegaCrit.Sts2.Core.Nodes.Screens.CapstoneSubmenuType Type { public get; private set; }
System.Boolean UseSharedBackstop { public virtual get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType GetCapstoneSubmenuType()
private static System.String get_ScenePath()
private System.Void OnSubmenuStackChanged()
private System.Void set_Stack(MegaCrit.Sts2.Core.Nodes.Screens.NRunSubmenuStack value)
private System.Void set_Type(MegaCrit.Sts2.Core.Nodes.Screens.CapstoneSubmenuType value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public MegaCrit.Sts2.Core.Nodes.Screens.CapstoneSubmenuType get_Type()
public MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu ShowScreen(MegaCrit.Sts2.Core.Nodes.Screens.CapstoneSubmenuType type)
public MegaCrit.Sts2.Core.Nodes.Screens.NRunSubmenuStack get_Stack()
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual Godot.Control get_DefaultFocusedControl()
public virtual MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType get_ScreenType()
public virtual System.Boolean get_UseSharedBackstop()
public virtual System.Void _Ready()
public virtual System.Void AfterCapstoneClosed()
public virtual System.Void AfterCapstoneOpened()
```

## MegaCrit.Sts2.Core.Nodes.Screens.NCapstoneSubmenuStack+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AfterCapstoneClosed
public static readonly Godot.StringName AfterCapstoneOpened
public static readonly Godot.StringName GetCapstoneSubmenuType
public static readonly Godot.StringName OnSubmenuStackChanged
public static readonly Godot.StringName ShowScreen
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.NCapstoneSubmenuStack+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName DefaultFocusedControl
public static readonly Godot.StringName ScreenType
public static readonly Godot.StringName Stack
public static readonly Godot.StringName Type
public static readonly Godot.StringName UseSharedBackstop
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.NCapstoneSubmenuStack+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.NCardPileScreen

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.Capstones.ICapstoneScreen`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _backButton
private Godot.ColorRect _background
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _bottomLabel
private System.String[] _closeHotkeys
private Godot.Tween _currentTween
private MegaCrit.Sts2.Core.Nodes.Cards.NCardGrid _grid
private MegaCrit.Sts2.Core.Entities.Cards.CardPile <Pile>k__BackingField
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
Godot.Control DefaultFocusedControl { public virtual get; }
MegaCrit.Sts2.Core.Entities.Cards.CardPile Pile { public get; private set; }
System.String ScenePath { private static get; }
MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType ScreenType { public virtual get; }
System.Boolean UseSharedBackstop { public virtual get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private static System.String get_ScenePath()
private System.Void OnPileContentsChanged()
private System.Void OnReturnButtonPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void set_Pile(MegaCrit.Sts2.Core.Entities.Cards.CardPile value)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public MegaCrit.Sts2.Core.Entities.Cards.CardPile get_Pile()
public static MegaCrit.Sts2.Core.Nodes.Screens.NCardPileScreen ShowScreen(MegaCrit.Sts2.Core.Entities.Cards.CardPile pile, System.String[] closeHotkeys)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual Godot.Control get_DefaultFocusedControl()
public virtual MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType get_ScreenType()
public virtual System.Boolean get_UseSharedBackstop()
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
public virtual System.Void AfterCapstoneClosed()
public virtual System.Void AfterCapstoneOpened()
```

## MegaCrit.Sts2.Core.Nodes.Screens.NCardPileScreen+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Screens.NCardPileScreen+<>c <>9
public static System.Comparison<MegaCrit.Sts2.Core.Models.CardModel> <>9__20_0
private static .cctor()
public .ctor()
internal System.Int32 <OnPileContentsChanged>b__20_0(MegaCrit.Sts2.Core.Models.CardModel c1, MegaCrit.Sts2.Core.Models.CardModel c2)
```

## MegaCrit.Sts2.Core.Nodes.Screens.NCardPileScreen+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AfterCapstoneClosed
public static readonly Godot.StringName AfterCapstoneOpened
public static readonly Godot.StringName OnPileContentsChanged
public static readonly Godot.StringName OnReturnButtonPressed
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.NCardPileScreen+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _backButton
public static readonly Godot.StringName _background
public static readonly Godot.StringName _bottomLabel
public static readonly Godot.StringName _closeHotkeys
public static readonly Godot.StringName _currentTween
public static readonly Godot.StringName _grid
public static readonly Godot.StringName DefaultFocusedControl
public static readonly Godot.StringName ScreenType
public static readonly Godot.StringName UseSharedBackstop
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.NCardPileScreen+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.NCardsViewScreen

类型属性：`Public, Abstract, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.Capstones.ICapstoneScreen`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
protected MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _backButton
private Godot.ColorRect _background
private Godot.RichTextLabel _bottomLabel
protected System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.CardModel> _cards
protected MegaCrit.Sts2.Core.Nodes.Cards.NCardGrid _grid
protected MegaCrit.Sts2.Core.Localization.LocString _infoText
private MegaCrit.Sts2.Core.Nodes.Screens.NInspectCardScreen _inspectCardScreen
private MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox _showUpgrades
Godot.Control DefaultFocusedControl { public virtual get; }
Godot.Control FocusedControlFromTopBar { public virtual get; }
MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType ScreenType { public abstract get; }
System.Boolean UseSharedBackstop { public virtual get; }
protected .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnControllerStateUpdated()
private System.Void OnInspectVisibilityChanged()
private System.Void ToggleShowUpgrades(MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox tickbox)
protected System.Void OnReturnButtonPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
protected System.Void ShowCardDetail(MegaCrit.Sts2.Core.Models.CardModel cardModel)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void ConnectSignals()
protected virtual System.Void OnInspectCardHidden()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public abstract MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType get_ScreenType()
public virtual Godot.Control get_DefaultFocusedControl()
public virtual Godot.Control get_FocusedControlFromTopBar()
public virtual System.Boolean get_UseSharedBackstop()
public virtual System.Void _Ready()
public virtual System.Void AfterCapstoneClosed()
public virtual System.Void AfterCapstoneOpened()
```

## MegaCrit.Sts2.Core.Nodes.Screens.NCardsViewScreen+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AfterCapstoneClosed
public static readonly Godot.StringName AfterCapstoneOpened
public static readonly Godot.StringName ConnectSignals
public static readonly Godot.StringName OnControllerStateUpdated
public static readonly Godot.StringName OnInspectCardHidden
public static readonly Godot.StringName OnInspectVisibilityChanged
public static readonly Godot.StringName OnReturnButtonPressed
public static readonly Godot.StringName ToggleShowUpgrades
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.NCardsViewScreen+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _backButton
public static readonly Godot.StringName _background
public static readonly Godot.StringName _bottomLabel
public static readonly Godot.StringName _grid
public static readonly Godot.StringName _inspectCardScreen
public static readonly Godot.StringName _showUpgrades
public static readonly Godot.StringName DefaultFocusedControl
public static readonly Godot.StringName FocusedControlFromTopBar
public static readonly Godot.StringName ScreenType
public static readonly Godot.StringName UseSharedBackstop
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.NCardsViewScreen+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.NChooseARelicSelection

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.Overlays.IOverlayScreen`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private MegaCrit.Sts2.Core.Nodes.CommonUi.NCommonBanner _banner
private Godot.Tween _cardTween
private readonly System.Threading.Tasks.TaskCompletionSource<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.RelicModel>> _completionSource
private Godot.Tween _fadeTween
private Godot.Control _relicRow
private System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.RelicModel> _relics
private System.Boolean _relicSelected
private static const System.Single _relicXSpacing = 200
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
private System.Void OnSkipButtonReleased(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void SelectHolder(MegaCrit.Sts2.Core.Nodes.Relics.NRelicBasicHolder relicHolder)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public [async] System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.RelicModel>> RelicsSelected()
public static MegaCrit.Sts2.Core.Nodes.Screens.NChooseARelicSelection ShowScreen(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.RelicModel> relics)
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

## MegaCrit.Sts2.Core.Nodes.Screens.NChooseARelicSelection+<RelicsSelected>d__20

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.NChooseARelicSelection <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.RelicModel>> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.RelicModel>> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.NChooseARelicSelection+MethodName

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
public static readonly Godot.StringName SelectHolder
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.NChooseARelicSelection+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _banner
public static readonly Godot.StringName _cardTween
public static readonly Godot.StringName _fadeTween
public static readonly Godot.StringName _relicRow
public static readonly Godot.StringName _relicSelected
public static readonly Godot.StringName _screenComplete
public static readonly Godot.StringName _skipButton
public static readonly Godot.StringName DefaultFocusedControl
public static readonly Godot.StringName ScreenType
public static readonly Godot.StringName UseSharedBackstop
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.NChooseARelicSelection+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.NDeckViewScreen

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.NCardsViewScreen`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.Capstones.ICapstoneScreen`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private MegaCrit.Sts2.Core.Nodes.CommonUi.NCardViewSortButton _alphabetSorter
private Godot.Control _bg
private MegaCrit.Sts2.Core.Nodes.CommonUi.NCardViewSortButton _costSorter
private MegaCrit.Sts2.Core.Nodes.CommonUi.NCardViewSortButton _obtainedSorter
private MegaCrit.Sts2.Core.Entities.Cards.CardPile _pile
private MegaCrit.Sts2.Core.Entities.Players.Player _player
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.SortingOrders> _sortingPriority
private MegaCrit.Sts2.Core.Nodes.CommonUi.NCardViewSortButton _typeSorter
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
System.String ScenePath { private static get; }
MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType ScreenType { public virtual get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private static System.String get_ScenePath()
private System.Void <ConnectSignals>b__16_0(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder h)
private System.Void <ConnectSignals>b__16_1(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder h)
private System.Void DisplayCards()
private System.Void OnAlphabetSort(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton button)
private System.Void OnCardTypeSort(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton button)
private System.Void OnCostSort(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton button)
private System.Void OnObtainedSort(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton button)
private System.Void OnPileContentsChanged()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void ConnectSignals()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.NDeckViewScreen ShowScreen(MegaCrit.Sts2.Core.Entities.Players.Player player)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType get_ScreenType()
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
public virtual System.Void AfterCapstoneClosed()
```

## MegaCrit.Sts2.Core.Nodes.Screens.NDeckViewScreen+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.NCardsViewScreen+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AfterCapstoneClosed
public static readonly Godot.StringName ConnectSignals
public static readonly Godot.StringName DisplayCards
public static readonly Godot.StringName OnAlphabetSort
public static readonly Godot.StringName OnCardTypeSort
public static readonly Godot.StringName OnCostSort
public static readonly Godot.StringName OnObtainedSort
public static readonly Godot.StringName OnPileContentsChanged
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.NDeckViewScreen+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.NCardsViewScreen+PropertyName`。

接口：

```text
public static readonly Godot.StringName _alphabetSorter
public static readonly Godot.StringName _bg
public static readonly Godot.StringName _costSorter
public static readonly Godot.StringName _obtainedSorter
public static readonly Godot.StringName _typeSorter
public static readonly Godot.StringName ScreenType
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.NDeckViewScreen+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.NCardsViewScreen+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.NInspectCardScreen

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private static const System.Double _arrowButtonDelay = 0.1
private MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _backstop
private MegaCrit.Sts2.Core.Nodes.Cards.NCard _card
private Godot.Vector2 _cardPosition
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.CardModel> _cards
private Godot.Tween _cardTween
private Godot.Control _hoverTipRect
private System.Int32 _index
private MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _leftButton
private System.Single _leftButtonX
private Godot.Tween _openTween
private MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _rightButton
private System.Single _rightButtonX
private static readonly System.String _scenePath
private MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox _upgradeTickbox
private System.Boolean _viewAllUpgraded
System.String[] AssetPaths { public static get; }
Godot.Control DefaultFocusedControl { public virtual get; }
System.Boolean IsShowingUpgradedCard { private get; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Boolean get_IsShowingUpgradedCard()
private System.Void <_Ready>b__21_0(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void <_Ready>b__21_1(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void <Close>b__23_0()
private System.Void OnBackstopPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OnLeftButtonReleased()
private System.Void OnRightButtonReleased()
private System.Void SetCard(System.Int32 index)
private System.Void ToggleShowUpgrade(MegaCrit.Sts2.Core.Nodes.CommonUi.NTickbox _)
private System.Void UpdateCardDisplay()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.NInspectCardScreen Create()
public static System.String[] get_AssetPaths()
public System.Void Close()
public System.Void Open(System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.CardModel> cards, System.Int32 index, System.Boolean viewAllUpgraded = False)
public virtual Godot.Control get_DefaultFocusedControl()
public virtual System.Void _Input(Godot.InputEvent inputEvent)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.NInspectCardScreen+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Input
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Close
public static readonly Godot.StringName Create
public static readonly Godot.StringName OnBackstopPressed
public static readonly Godot.StringName OnLeftButtonReleased
public static readonly Godot.StringName OnRightButtonReleased
public static readonly Godot.StringName SetCard
public static readonly Godot.StringName ToggleShowUpgrade
public static readonly Godot.StringName UpdateCardDisplay
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.NInspectCardScreen+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _backstop
public static readonly Godot.StringName _card
public static readonly Godot.StringName _cardPosition
public static readonly Godot.StringName _cardTween
public static readonly Godot.StringName _hoverTipRect
public static readonly Godot.StringName _index
public static readonly Godot.StringName _leftButton
public static readonly Godot.StringName _leftButtonX
public static readonly Godot.StringName _openTween
public static readonly Godot.StringName _rightButton
public static readonly Godot.StringName _rightButtonX
public static readonly Godot.StringName _upgradeTickbox
public static readonly Godot.StringName _viewAllUpgraded
public static readonly Godot.StringName DefaultFocusedControl
public static readonly Godot.StringName IsShowingUpgradedCard
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.NInspectCardScreen+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.NRewardsScreen

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.Overlays.IOverlayScreen`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private System.Boolean _disableProceedForever
private Godot.Tween _fadeTween
private MegaCrit.Sts2.addons.mega_text.MegaLabel _headerLabel
private System.Boolean _isTerminal
private Godot.Control _lastRewardFocused
private MegaCrit.Sts2.Core.Nodes.CommonUi.NProceedButton _proceedButton
private readonly System.Collections.Generic.List<Godot.Control> _rewardButtons
private Godot.Control _rewardContainerMask
private Godot.Control _rewardsContainer
private MegaCrit.Sts2.Core.Rewards.RewardsSet _rewardsSet
private Godot.Control _rewardsWindow
private MegaCrit.Sts2.Core.Runs.IRunState _runState
private MegaCrit.Sts2.Core.Nodes.GodotExtensions.NScrollbar _scrollbar
private System.Boolean _scrollbarPressed
private static const System.Int32 _scrollbarThreshold = 400
private static const System.Single _scrollLimitTop = 35
private System.Boolean _skipDisallowed
private readonly System.Collections.Generic.List<Godot.Control> _skippedRewardButtons
private Godot.Vector2 _targetDragPos
private Godot.Control _waitingForOtherPlayersOverlay
private static readonly MegaCrit.Sts2.Core.Localization.LocString _waitingLoc
private System.Boolean <IsComplete>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Screens.NRewardsScreen+CompletedEventHandler backing_Completed
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
System.Boolean CanScroll { private get; }
Godot.Control DefaultFocusedControl { public virtual get; }
Godot.Control FocusedControlFromTopBar { public virtual get; }
System.Boolean IsComplete { public get; private set; }
System.String ScenePath { private static get; }
MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType ScreenType { public virtual get; }
System.Single ScrollLimitBottom { private get; }
System.Boolean UseSharedBackstop { public virtual get; }
event MegaCrit.Sts2.Core.Nodes.Screens.NRewardsScreen+CompletedEventHandler Completed
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotSignalList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task RelicFtueCheck()
private [async] System.Threading.Tasks.Task RewardFtueCheck()
private static System.String get_ScenePath()
private System.Boolean get_CanScroll()
private System.Single get_ScrollLimitBottom()
private System.Void <_Ready>b__37_0(Godot.InputEvent _)
private System.Void <_Ready>b__37_1(Godot.InputEvent _)
private System.Void <_Ready>b__37_2()
private System.Void BeforeRoomExit()
private System.Void OnProceedButtonPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void ProcessGuiFocus(Godot.Control focusedControl)
private System.Void ProcessScrollEvent(Godot.InputEvent inputEvent)
private System.Void RemoveButton(Godot.Control button)
private System.Void set_IsComplete(System.Boolean value)
private System.Void TryEnableProceedButton()
private System.Void UpdateScreenState()
private System.Void UpdateScrollPosition(System.Double delta)
protected System.Void EmitSignalCompleted()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean HasGodotClassSignal(in Godot.NativeInterop.godot_string_name signal)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RaiseGodotClassSignalCallbacks(in Godot.NativeInterop.godot_string_name signal, Godot.NativeInterop.NativeVariantPtrArgs args)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.NRewardsScreen ShowScreen(MegaCrit.Sts2.Core.Rewards.RewardsSet set, System.Boolean isTerminal, MegaCrit.Sts2.Core.Runs.IRunState runState)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Boolean get_IsComplete()
public System.Void add_Completed(MegaCrit.Sts2.Core.Nodes.Screens.NRewardsScreen+CompletedEventHandler value)
public System.Void HideWaitingForPlayersScreen()
public System.Void remove_Completed(MegaCrit.Sts2.Core.Nodes.Screens.NRewardsScreen+CompletedEventHandler value)
public System.Void RewardCollectedFrom(Godot.Control button)
public System.Void RewardSkippedFrom(Godot.Control button)
public virtual Godot.Control get_DefaultFocusedControl()
public virtual Godot.Control get_FocusedControlFromTopBar()
public virtual MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType get_ScreenType()
public virtual System.Boolean get_UseSharedBackstop()
public virtual System.Void _GuiInput(Godot.InputEvent inputEvent)
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
public virtual System.Void AfterOverlayClosed()
public virtual System.Void AfterOverlayHidden()
public virtual System.Void AfterOverlayOpened()
public virtual System.Void AfterOverlayShown()
```

## MegaCrit.Sts2.Core.Nodes.Screens.NRewardsScreen+<>c__DisplayClass37_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Screens.NRewardsScreen <>4__this
public Godot.Control option
public .ctor()
internal Godot.Control <_Ready>b__3()
```

## MegaCrit.Sts2.Core.Nodes.Screens.NRewardsScreen+<RelicFtueCheck>d__38

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.NRewardsScreen <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.NRewardsScreen+<RewardFtueCheck>d__57

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.NRewardsScreen <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.NRewardsScreen+CompletedEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke()
```

## MegaCrit.Sts2.Core.Nodes.Screens.NRewardsScreen+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _GuiInput
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AfterOverlayClosed
public static readonly Godot.StringName AfterOverlayHidden
public static readonly Godot.StringName AfterOverlayOpened
public static readonly Godot.StringName AfterOverlayShown
public static readonly Godot.StringName BeforeRoomExit
public static readonly Godot.StringName HideWaitingForPlayersScreen
public static readonly Godot.StringName OnProceedButtonPressed
public static readonly Godot.StringName ProcessGuiFocus
public static readonly Godot.StringName ProcessScrollEvent
public static readonly Godot.StringName RemoveButton
public static readonly Godot.StringName RewardCollectedFrom
public static readonly Godot.StringName RewardSkippedFrom
public static readonly Godot.StringName TryEnableProceedButton
public static readonly Godot.StringName UpdateScreenState
public static readonly Godot.StringName UpdateScrollPosition
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.NRewardsScreen+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _disableProceedForever
public static readonly Godot.StringName _fadeTween
public static readonly Godot.StringName _headerLabel
public static readonly Godot.StringName _isTerminal
public static readonly Godot.StringName _lastRewardFocused
public static readonly Godot.StringName _proceedButton
public static readonly Godot.StringName _rewardContainerMask
public static readonly Godot.StringName _rewardsContainer
public static readonly Godot.StringName _rewardsWindow
public static readonly Godot.StringName _scrollbar
public static readonly Godot.StringName _scrollbarPressed
public static readonly Godot.StringName _skipDisallowed
public static readonly Godot.StringName _targetDragPos
public static readonly Godot.StringName _waitingForOtherPlayersOverlay
public static readonly Godot.StringName CanScroll
public static readonly Godot.StringName DefaultFocusedControl
public static readonly Godot.StringName FocusedControlFromTopBar
public static readonly Godot.StringName IsComplete
public static readonly Godot.StringName ScreenType
public static readonly Godot.StringName ScrollLimitBottom
public static readonly Godot.StringName UseSharedBackstop
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.NRewardsScreen+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public static readonly Godot.StringName Completed
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.NRunSubmenuStack

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenuStack`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiary _bestiarySubmenu
private MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardLibrary _cardLibrarySubmenu
private MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NCompendiumSubmenu _compendiumSubmenu
private MegaCrit.Sts2.Core.Nodes.Screens.PauseMenu.NPauseMenu _pauseMenu
private Godot.PackedScene _pauseMenuScene
private MegaCrit.Sts2.Core.Nodes.Screens.PotionLab.NPotionLab _potionLabSubmenu
private MegaCrit.Sts2.Core.Nodes.Screens.RelicCollection.NRelicCollection _relicCollectionSubmenu
private MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NRunHistory _runHistoryScreen
private Godot.PackedScene _runHistoryScreenScene
private MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsScreen _settingsScreen
private Godot.PackedScene _settingsScreenScene
private MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NStatsScreen _statsScreen
private Godot.PackedScene _statsScreenScene
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu GetSubmenuType(System.Type type)
public virtual MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu PushSubmenuType(System.Type type)
public virtual System.Void _Ready()
public virtual T GetSubmenuType<T>() where T: [None] MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu
public virtual T PushSubmenuType<T>() where T: [None] MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu
```

## MegaCrit.Sts2.Core.Nodes.Screens.NRunSubmenuStack+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenuStack+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.NRunSubmenuStack+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenuStack+PropertyName`。

接口：

```text
public static readonly Godot.StringName _bestiarySubmenu
public static readonly Godot.StringName _cardLibrarySubmenu
public static readonly Godot.StringName _compendiumSubmenu
public static readonly Godot.StringName _pauseMenu
public static readonly Godot.StringName _pauseMenuScene
public static readonly Godot.StringName _potionLabSubmenu
public static readonly Godot.StringName _relicCollectionSubmenu
public static readonly Godot.StringName _runHistoryScreen
public static readonly Godot.StringName _runHistoryScreenScene
public static readonly Godot.StringName _settingsScreen
public static readonly Godot.StringName _settingsScreenScene
public static readonly Godot.StringName _statsScreen
public static readonly Godot.StringName _statsScreenScene
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.NRunSubmenuStack+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenuStack+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.NShareButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.NShareButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.NShareButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.NShareButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.NSimpleCardsViewScreen

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.NCardsViewScreen`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.Capstones.ICapstoneScreen`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult> _cardResults
private MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _confirmButton
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
System.String ScenePath { private static get; }
MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType ScreenType { public virtual get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task FlashRelicsOnModifiedCards()
private static System.String get_ScenePath()
private System.Void <ConnectSignals>b__9_0(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NCardHolder h)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void ConnectSignals()
protected virtual System.Void OnInspectCardHidden()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.NCardsViewScreen ShowScreen(System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult> cards, MegaCrit.Sts2.Core.Localization.LocString infoText)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType get_ScreenType()
public virtual System.Void _Ready()
public virtual System.Void AfterCapstoneOpened()
```

## MegaCrit.Sts2.Core.Nodes.Screens.NSimpleCardsViewScreen+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Screens.NSimpleCardsViewScreen+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult, MegaCrit.Sts2.Core.Models.CardModel> <>9__10_0
private static .cctor()
public .ctor()
internal MegaCrit.Sts2.Core.Models.CardModel <ShowScreen>b__10_0(MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult c)
```

## MegaCrit.Sts2.Core.Nodes.Screens.NSimpleCardsViewScreen+<>c__DisplayClass13_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Entities.Cards.CardPileAddResult result
public .ctor()
internal System.Boolean <FlashRelicsOnModifiedCards>b__0(MegaCrit.Sts2.Core.Nodes.Cards.Holders.NGridCardHolder h)
```

## MegaCrit.Sts2.Core.Nodes.Screens.NSimpleCardsViewScreen+<FlashRelicsOnModifiedCards>d__13

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.NSimpleCardsViewScreen <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.NSimpleCardsViewScreen+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.NCardsViewScreen+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AfterCapstoneOpened
public static readonly Godot.StringName ConnectSignals
public static readonly Godot.StringName OnInspectCardHidden
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.NSimpleCardsViewScreen+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.NCardsViewScreen+PropertyName`。

接口：

```text
public static readonly Godot.StringName _confirmButton
public static readonly Godot.StringName ScreenType
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.NSimpleCardsViewScreen+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.NCardsViewScreen+SignalName`。

接口：

```text
public .ctor()
```
