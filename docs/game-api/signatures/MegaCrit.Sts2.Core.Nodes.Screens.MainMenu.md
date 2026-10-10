# MegaCrit.Sts2.Core.Nodes.Screens.MainMenu

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NCompendiumBottomButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private Godot.Control _bgPanel
private System.Single _defaultV
private System.Single _focusV
private Godot.ShaderMaterial _hsv
private Godot.TextureRect _icon
private MegaCrit.Sts2.addons.mega_text.MegaLabel _label
private System.String _locKeyPrefix
private System.Single _pressV
private Godot.Tween _tween
private static readonly Godot.StringName _v
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void RefreshLabels()
private System.Void UpdateShaderParam(System.Single newV)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void ConnectSignals()
protected virtual System.Void OnDisable()
protected virtual System.Void OnEnable()
protected virtual System.Void OnFocus()
protected virtual System.Void OnPress()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void SetLocalization(System.String locKeyPrefix)
public virtual System.Void _Notification(System.Int32 what)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NCompendiumBottomButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Notification
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName ConnectSignals
public static readonly Godot.StringName OnDisable
public static readonly Godot.StringName OnEnable
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName RefreshLabels
public static readonly Godot.StringName SetLocalization
public static readonly Godot.StringName UpdateShaderParam
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NCompendiumBottomButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _bgPanel
public static readonly Godot.StringName _defaultV
public static readonly Godot.StringName _focusV
public static readonly Godot.StringName _hsv
public static readonly Godot.StringName _icon
public static readonly Godot.StringName _label
public static readonly Godot.StringName _locKeyPrefix
public static readonly Godot.StringName _pressV
public static readonly Godot.StringName _tween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NCompendiumBottomButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NCompendiumSubmenu

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NShortSubmenuButton _bestiaryButton
private MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NShortSubmenuButton _cardLibraryButton
private MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _confirmButton
private MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NCompendiumBottomButton _leaderboardsButton
private MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NShortSubmenuButton _potionLabButton
private MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NShortSubmenuButton _relicCollectionButton
private MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NCompendiumBottomButton _runHistoryButton
private MegaCrit.Sts2.Core.Runs.IRunState _runState
private static readonly System.String _scenePath
private MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NCompendiumBottomButton _statisticsButton
Godot.Control InitialFocusedControl { protected virtual get; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OpenBestiary(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OpenCardLibrary(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OpenLeaderboards(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OpenPotionLab(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OpenRelicCollection(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OpenRunHistory(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OpenStatistics(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
protected virtual Godot.Control get_InitialFocusedControl()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiary OpenBestiary()
public static MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NCompendiumSubmenu Create()
public System.Void Initialize(MegaCrit.Sts2.Core.Runs.IRunState runState)
public virtual System.Void _Ready()
public virtual System.Void OnSubmenuOpened()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NCompendiumSubmenu+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName OnSubmenuOpened
public static readonly Godot.StringName OpenBestiary
public static readonly Godot.StringName OpenCardLibrary
public static readonly Godot.StringName OpenLeaderboards
public static readonly Godot.StringName OpenPotionLab
public static readonly Godot.StringName OpenRelicCollection
public static readonly Godot.StringName OpenRunHistory
public static readonly Godot.StringName OpenStatistics
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NCompendiumSubmenu+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+PropertyName`。

接口：

```text
public static readonly Godot.StringName _bestiaryButton
public static readonly Godot.StringName _cardLibraryButton
public static readonly Godot.StringName _confirmButton
public static readonly Godot.StringName _leaderboardsButton
public static readonly Godot.StringName _potionLabButton
public static readonly Godot.StringName _relicCollectionButton
public static readonly Godot.StringName _runHistoryButton
public static readonly Godot.StringName _statisticsButton
public static readonly Godot.StringName InitialFocusedControl
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NCompendiumSubmenu+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NContinueRunInfo

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _ascensionLabel
private Godot.TextureRect _charIcon
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _dateLabel
private Godot.Control _errorContainer
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _goldLabel
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _healthLabel
private Godot.Vector2 _initPosition
private System.Boolean _isShown
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _progressLabel
private Godot.Control _runInfoContainer
private Godot.Tween _visTween
private System.Boolean <HasResult>k__BackingField
System.Boolean HasResult { public get; private set; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void set_HasResult(System.Boolean value)
private System.Void ShowError()
private System.Void ShowInfo(MegaCrit.Sts2.Core.Saves.SerializableRun save)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Boolean get_HasResult()
public System.Void AnimHide()
public System.Void AnimShow()
public System.Void SetResult(MegaCrit.Sts2.Core.Saves.ReadSaveResult<MegaCrit.Sts2.Core.Saves.SerializableRun> result)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NContinueRunInfo+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AnimHide
public static readonly Godot.StringName AnimShow
public static readonly Godot.StringName ShowError
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NContinueRunInfo+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _ascensionLabel
public static readonly Godot.StringName _charIcon
public static readonly Godot.StringName _dateLabel
public static readonly Godot.StringName _errorContainer
public static readonly Godot.StringName _goldLabel
public static readonly Godot.StringName _healthLabel
public static readonly Godot.StringName _initPosition
public static readonly Godot.StringName _isShown
public static readonly Godot.StringName _progressLabel
public static readonly Godot.StringName _runInfoContainer
public static readonly Godot.StringName _visTween
public static readonly Godot.StringName HasResult
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NContinueRunInfo+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NCustomRunModifiersList

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private Godot.Control _container
private MegaCrit.Sts2.Core.Entities.UI.MultiplayerUiMode _mode
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Screens.CustomRun.NRunModifierTickbox> _modifierTickboxes
private MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NCustomRunModifiersList+ModifiersChangedEventHandler backing_ModifiersChanged
Godot.Control DefaultFocusedControl { public get; }
event MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NCustomRunModifiersList+ModifiersChangedEventHandler ModifiersChanged
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotSignalList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.ModifierModel> GetAllModifiers()
private System.Void AfterModifiersChanged(MegaCrit.Sts2.Core.Nodes.Screens.CustomRun.NRunModifierTickbox tickbox)
private System.Void UntickMutuallyExclusiveModifiersForTickbox(MegaCrit.Sts2.Core.Nodes.Screens.CustomRun.NRunModifierTickbox tickbox)
protected System.Void EmitSignalModifiersChanged()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean HasGodotClassSignal(in Godot.NativeInterop.godot_string_name signal)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RaiseGodotClassSignalCallbacks(in Godot.NativeInterop.godot_string_name signal, Godot.NativeInterop.NativeVariantPtrArgs args)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public Godot.Control get_DefaultFocusedControl()
public System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.ModifierModel> GetModifiersTickedOn()
public System.Void add_ModifiersChanged(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NCustomRunModifiersList+ModifiersChangedEventHandler value)
public System.Void Initialize(MegaCrit.Sts2.Core.Entities.UI.MultiplayerUiMode mode)
public System.Void remove_ModifiersChanged(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NCustomRunModifiersList+ModifiersChangedEventHandler value)
public System.Void SetTickedModifiers(System.Collections.Generic.IReadOnlyCollection<MegaCrit.Sts2.Core.Models.ModifierModel> modifiers)
public System.Void SyncModifierList(System.Collections.Generic.IReadOnlyCollection<MegaCrit.Sts2.Core.Models.ModifierModel> modifiers)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NCustomRunModifiersList+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NCustomRunModifiersList+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Nodes.Screens.CustomRun.NRunModifierTickbox, System.Boolean> <>9__11_0
public static System.Func<MegaCrit.Sts2.Core.Nodes.Screens.CustomRun.NRunModifierTickbox, MegaCrit.Sts2.Core.Models.ModifierModel> <>9__11_1
private static .cctor()
public .ctor()
internal MegaCrit.Sts2.Core.Models.ModifierModel <GetModifiersTickedOn>b__11_1(MegaCrit.Sts2.Core.Nodes.Screens.CustomRun.NRunModifierTickbox t)
internal System.Boolean <GetModifiersTickedOn>b__11_0(MegaCrit.Sts2.Core.Nodes.Screens.CustomRun.NRunModifierTickbox t)
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NCustomRunModifiersList+<>c__DisplayClass6_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Screens.CustomRun.NRunModifierTickbox tickbox
public .ctor()
internal System.Boolean <SyncModifierList>b__0(MegaCrit.Sts2.Core.Models.ModifierModel m)
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NCustomRunModifiersList+<>c__DisplayClass7_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Screens.CustomRun.NRunModifierTickbox tickbox
public .ctor()
internal System.Boolean <SetTickedModifiers>b__0(MegaCrit.Sts2.Core.Models.ModifierModel m)
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NCustomRunModifiersList+<>c__DisplayClass9_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.Func<MegaCrit.Sts2.Core.Models.ModifierModel, System.Boolean> <>9__1
public MegaCrit.Sts2.Core.Nodes.Screens.CustomRun.NRunModifierTickbox tickbox
public .ctor()
internal System.Boolean <UntickMutuallyExclusiveModifiersForTickbox>b__0(System.Collections.Generic.IReadOnlySet<MegaCrit.Sts2.Core.Models.ModifierModel> s)
internal System.Boolean <UntickMutuallyExclusiveModifiersForTickbox>b__1(MegaCrit.Sts2.Core.Models.ModifierModel m)
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NCustomRunModifiersList+<>c__DisplayClass9_1

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Screens.CustomRun.NRunModifierTickbox otherTickbox
public .ctor()
internal System.Boolean <UntickMutuallyExclusiveModifiersForTickbox>b__2(MegaCrit.Sts2.Core.Models.ModifierModel m)
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NCustomRunModifiersList+<GetAllModifiers>d__8

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：`System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.ModifierModel>`, `System.Collections.IEnumerable`, `System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Models.ModifierModel>`, `System.Collections.IEnumerator`, `System.IDisposable`

```text
private System.Int32 <>1__state
private MegaCrit.Sts2.Core.Models.ModifierModel <>2__current
private System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Models.ModifierModel> <>7__wrap1
private System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Models.CharacterModel> <>7__wrap3
private System.Int32 <>l__initialThreadId
private MegaCrit.Sts2.Core.Models.Modifiers.CharacterCards <canonicalCharacterCardsModifier>5__3
MegaCrit.Sts2.Core.Models.ModifierModel System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Models.ModifierModel>.Current { private virtual get; }
System.Object System.Collections.IEnumerator.Current { private virtual get; }
public .ctor(System.Int32 <>1__state)
private System.Void <>m__Finally1()
private System.Void <>m__Finally2()
private virtual MegaCrit.Sts2.Core.Models.ModifierModel System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Models.ModifierModel>.get_Current()
private virtual System.Boolean MoveNext()
private virtual System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Models.ModifierModel> System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Models.ModifierModel>.GetEnumerator()
private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
private virtual System.Object System.Collections.IEnumerator.get_Current()
private virtual System.Void System.Collections.IEnumerator.Reset()
private virtual System.Void System.IDisposable.Dispose()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NCustomRunModifiersList+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AfterModifiersChanged
public static readonly Godot.StringName Initialize
public static readonly Godot.StringName UntickMutuallyExclusiveModifiersForTickbox
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NCustomRunModifiersList+ModifiersChangedEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NCustomRunModifiersList+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _container
public static readonly Godot.StringName _mode
public static readonly Godot.StringName DefaultFocusedControl
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NCustomRunModifiersList+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public static readonly Godot.StringName ModifiersChanged
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NDisclaimerProceedButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private Godot.Tween _tween
System.String[] Hotkeys { protected virtual get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.String[] get_Hotkeys()
protected virtual System.Void OnFocus()
protected virtual System.Void OnPress()
protected virtual System.Void OnRelease()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NDisclaimerProceedButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnUnfocus
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NDisclaimerProceedButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _tween
public static readonly Godot.StringName Hotkeys
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NDisclaimerProceedButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NEarlyAccessDisclaimer

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private Godot.Control _image
private Godot.Tween _tween
Godot.Control DefaultFocusedControl { public virtual get; }
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void UpdateEaDisclaimerDescription()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public [async] System.Threading.Tasks.Task CloseScreen()
public static MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NEarlyAccessDisclaimer Create()
public virtual Godot.Control get_DefaultFocusedControl()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NEarlyAccessDisclaimer+<CloseScreen>d__4

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NEarlyAccessDisclaimer <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NEarlyAccessDisclaimer+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName UpdateEaDisclaimerDescription
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NEarlyAccessDisclaimer+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _image
public static readonly Godot.StringName _tween
public static readonly Godot.StringName DefaultFocusedControl
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NEarlyAccessDisclaimer+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NJoinFriendButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private static const System.Single _defaultV = 0.9
private static readonly Godot.Vector2 _hoverScale
private static const System.Single _hoverV = 1.2
private Godot.ShaderMaterial _hsv
private static readonly Godot.Vector2 _pressScale
private Godot.Tween _tween
private static readonly Godot.StringName _v
private System.UInt64 <PlayerId>k__BackingField
public static readonly System.String scenePath
System.UInt64 PlayerId { public get; private set; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void set_PlayerId(System.UInt64 value)
private System.Void UpdateShaderParam(System.Single newV)
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
public static MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NJoinFriendButton Create(System.UInt64 playerId)
public System.UInt64 get_PlayerId()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NJoinFriendButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName UpdateShaderParam
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NJoinFriendButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _hsv
public static readonly Godot.StringName _tween
public static readonly Godot.StringName PlayerId
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NJoinFriendButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NJoinFriendRefreshButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private static const System.Single _defaultV = 0.9
private static readonly Godot.Vector2 _hoverScale
private static const System.Single _hoverV = 1.2
private Godot.ShaderMaterial _hsv
private static readonly Godot.Vector2 _pressScale
private Godot.Tween _tween
private static readonly Godot.StringName _v
private System.UInt64 <PlayerId>k__BackingField
System.String[] Hotkeys { protected virtual get; }
System.UInt64 PlayerId { public get; private set; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void set_PlayerId(System.UInt64 value)
private System.Void UpdateShaderParam(System.Single newV)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.String[] get_Hotkeys()
protected virtual System.Void OnFocus()
protected virtual System.Void OnPress()
protected virtual System.Void OnRelease()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.UInt64 get_PlayerId()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NJoinFriendRefreshButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName UpdateShaderParam
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NJoinFriendRefreshButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _hsv
public static readonly Godot.StringName _tween
public static readonly Godot.StringName Hotkeys
public static readonly Godot.StringName PlayerId
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NJoinFriendRefreshButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NJoinFriendScreen

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private Godot.Control _buttonContainer
private MegaCrit.Sts2.Core.Multiplayer.Game.JoinFlow _currentJoinFlow
private Godot.Control _loadingFriendsIndicator
private Godot.Control _loadingOverlay
private MegaCrit.Sts2.addons.mega_text.MegaLabel _noFriendsLabel
private MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NJoinFriendRefreshButton _refreshButton
private System.Threading.Tasks.Task _refreshTask
private static readonly System.String _scenePath
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
System.Boolean DebugFriendsButtons { public get; }
Godot.Control InitialFocusedControl { protected virtual get; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task FastMpJoin()
private [async] System.Threading.Tasks.Task RefreshButtonClickedAsync()
private [async] System.Threading.Tasks.Task ShowFriends()
private System.Void <_Ready>b__15_0(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NClickableControl _)
private System.Void JoinGame(MegaCrit.Sts2.Core.Multiplayer.Connection.IClientConnectionInitializer connInitializer)
private System.Void RefreshButtonClicked()
protected virtual Godot.Control get_InitialFocusedControl()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public [async] System.Threading.Tasks.Task JoinGameAsync(MegaCrit.Sts2.Core.Multiplayer.Connection.IClientConnectionInitializer connInitializer)
public static MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NJoinFriendScreen Create()
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Boolean get_DebugFriendsButtons()
public virtual System.Void _Ready()
public virtual System.Void OnSubmenuClosed()
public virtual System.Void OnSubmenuOpened()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NJoinFriendScreen+<>c__DisplayClass21_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NJoinFriendScreen <>4__this
public MegaCrit.Sts2.Core.Multiplayer.Connection.SteamClientConnectionInitializer connInitializer
public .ctor()
internal System.Void <ShowFriends>b__0(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NJoinFriendScreen+<FastMpJoin>d__18

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NJoinFriendScreen <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NJoinFriendScreen+<JoinGameAsync>d__23

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NJoinFriendScreen <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<MegaCrit.Sts2.Core.Multiplayer.Game.JoinResult> <>u__1
public MegaCrit.Sts2.Core.Multiplayer.Connection.IClientConnectionInitializer connInitializer
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NJoinFriendScreen+<RefreshButtonClickedAsync>d__20

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NJoinFriendScreen <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NJoinFriendScreen+<ShowFriends>d__21

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NJoinFriendScreen <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IEnumerable<System.UInt64>> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NJoinFriendScreen+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName OnSubmenuClosed
public static readonly Godot.StringName OnSubmenuOpened
public static readonly Godot.StringName RefreshButtonClicked
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NJoinFriendScreen+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+PropertyName`。

接口：

```text
public static readonly Godot.StringName _buttonContainer
public static readonly Godot.StringName _loadingFriendsIndicator
public static readonly Godot.StringName _loadingOverlay
public static readonly Godot.StringName _noFriendsLabel
public static readonly Godot.StringName _refreshButton
public static readonly Godot.StringName DebugFriendsButtons
public static readonly Godot.StringName InitialFocusedControl
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NJoinFriendScreen+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NJoinFriendScreenButtonLayout

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Container`。

接口：`System.IDisposable`

```text
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
private System.Void LayoutChildren()
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Notification(System.Int32 what)
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NJoinFriendScreenButtonLayout+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Container+MethodName`。

接口：

```text
public static readonly Godot.StringName _Notification
public static readonly Godot.StringName LayoutChildren
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NJoinFriendScreenButtonLayout+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Container+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NJoinFriendScreenButtonLayout+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Container+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NLogoAnimation

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private Godot.Control _bg
private System.Boolean _cancelled
private Godot.Color _logoBgColor
private Godot.Control _logoContainer
private Godot.Node2D _logoSpineNode
private static const System.String _scenePath = "res://scenes/screens/main_menu/logo_animation.tscn"
private System.Boolean _skeletonReady
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _spineSprite
private Godot.Tween _tween
System.String[] AssetPaths { public static get; }
Godot.Control DefaultFocusedControl { public virtual get; }
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public [async] System.Threading.Tasks.Task PlayAnimation(System.Threading.CancellationToken token)
public static MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NLogoAnimation Create()
public static System.String[] get_AssetPaths()
public virtual Godot.Control get_DefaultFocusedControl()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NLogoAnimation+<PlayAnimation>d__13

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NLogoAnimation <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__2
public System.Threading.CancellationToken token
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NLogoAnimation+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NLogoAnimation+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _bg
public static readonly Godot.StringName _cancelled
public static readonly Godot.StringName _logoBgColor
public static readonly Godot.StringName _logoContainer
public static readonly Godot.StringName _logoSpineNode
public static readonly Godot.StringName _skeletonReady
public static readonly Godot.StringName _tween
public static readonly Godot.StringName DefaultFocusedControl
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NLogoAnimation+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenuTextButton _abandonRunButton
private Godot.Tween _backstopTween
private MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenuBg _bg
private Godot.ShaderMaterial _blur
private Godot.Control _buttonReticleLeft
private Godot.Control _buttonReticleRight
private MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenuTextButton _compendiumButton
private MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenuTextButton _continueButton
private MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenuTextButton _lastHitButton
private static readonly Godot.StringName _lod
private static const System.String _menuMusicParam = "menu_progress"
private static readonly Godot.StringName _mixPercentage
private MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenuTextButton _multiplayerButton
private MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NOpenProfileScreenButton _openProfileScreenButton
private System.Boolean _openTimeline
private MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NPatchNotesButton _patchNotesButtonNode
private MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenuTextButton _quitButton
private MegaCrit.Sts2.Core.Saves.ReadSaveResult<MegaCrit.Sts2.Core.Saves.SerializableRun> _readRunSaveResult
private static const System.Single _reticlePadding = 28
private Godot.Tween _reticleTween
private static const System.Single _reticleYOffset = 5
private MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NContinueRunInfo _runInfo
private static const System.String _scenePath = "res://scenes/screens/main_menu.tscn"
private MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenuTextButton _settingsButton
private MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenuTextButton _singleplayerButton
private MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenuTextButton _timelineButton
private Godot.Control _timelineNotificationDot
private Godot.Window _window
private Godot.Control <BlurBackstop>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NPatchNotesScreen <PatchNotesScreen>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenuSubmenuStack <SubmenuStack>k__BackingField
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
Godot.Control BlurBackstop { private get; private set; }
MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NContinueRunInfo ContinueRunInfo { public get; }
Godot.Control DefaultFocusedControl { public virtual get; }
MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton[] MainMenuButtons { private get; }
MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NPatchNotesScreen PatchNotesScreen { public get; private set; }
MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenuSubmenuStack SubmenuStack { public get; private set; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task OnContinueButtonPressedAsync()
private [async] System.Threading.Tasks.Task OpenTimelineFromGameOverScreen()
private Godot.Control get_BlurBackstop()
private MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton[] get_MainMenuButtons()
private static [async] System.Threading.Tasks.Task ConfirmAndQuit()
private static System.Void Quit(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void <ConnectMainMenuTextButtonFocusLogic>b__48_0(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenuTextButton b)
private System.Void CheckCommandLineArgs()
private System.Void ConnectMainMenuTextButtonFocusLogic()
private System.Void DisplayLoadSaveError()
private System.Void MainMenuButtonFocused(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenuTextButton button)
private System.Void MainMenuButtonUnfocused(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenuTextButton obj)
private System.Void OnAbandonRunButtonPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OnContinueButtonPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OnSubmenuStackChanged()
private System.Void OnWindowChange(System.Boolean isAspectRatioAuto)
private System.Void OpenCompendiumSubmenu(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OpenPatchNotes(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OpenSettingsMenu(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OpenTimelineScreen(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton obj)
private System.Void set_BlurBackstop(Godot.Control value)
private System.Void set_PatchNotesScreen(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NPatchNotesScreen value)
private System.Void set_SubmenuStack(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenuSubmenuStack value)
private System.Void SingleplayerButtonPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void UpdateShaderLod(System.Single obj)
private System.Void UpdateShaderMix(System.Single obj)
private System.Void UpdateTimelineButtonBehavior()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public [async] System.Threading.Tasks.Task JoinGame(MegaCrit.Sts2.Core.Multiplayer.Connection.IClientConnectionInitializer connInitializer)
public MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NCompendiumSubmenu OpenCompendiumSubmenu()
public MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NContinueRunInfo get_ContinueRunInfo()
public MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenuSubmenuStack get_SubmenuStack()
public MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMultiplayerSubmenu OpenMultiplayerSubmenu()
public MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NPatchNotesScreen get_PatchNotesScreen()
public MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSingleplayerSubmenu OpenSingleplayerSubmenu()
public static MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu Create(System.Boolean openTimeline)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Void AbandonRun()
public System.Void DisableBackstop()
public System.Void DisableBackstopInstantly()
public System.Void EnableBackstop()
public System.Void EnableBackstopInstantly()
public System.Void OpenMultiplayerSubmenu(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
public System.Void OpenProfileScreen()
public System.Void OpenSettingsMenu()
public System.Void RefreshButtons()
public virtual Godot.Control get_DefaultFocusedControl()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton, System.Boolean> <>9__61_0
private static .cctor()
public .ctor()
internal System.Boolean <get_DefaultFocusedControl>b__61_0(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton b)
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu+<>c__DisplayClass48_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu <>4__this
public MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenuTextButton b
public .ctor()
internal System.Void <ConnectMainMenuTextButtonFocusLogic>b__1()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu+<>O

类型属性：`NestedPrivate, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static System.Action<MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton> <0>__Quit
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu+<ConfirmAndQuit>d__81

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu+<JoinGame>d__79

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.Multiplayer.Connection.IClientConnectionInitializer connInitializer
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu+<OnContinueButtonPressedAsync>d__64

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private MegaCrit.Sts2.Core.Runs.RunState <runState>5__3
private MegaCrit.Sts2.Core.Saves.SerializableRun <serializableRun>5__2
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu+<OpenTimelineFromGameOverScreen>d__51

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AbandonRun
public static readonly Godot.StringName CheckCommandLineArgs
public static readonly Godot.StringName ConnectMainMenuTextButtonFocusLogic
public static readonly Godot.StringName Create
public static readonly Godot.StringName DisableBackstop
public static readonly Godot.StringName DisableBackstopInstantly
public static readonly Godot.StringName DisplayLoadSaveError
public static readonly Godot.StringName EnableBackstop
public static readonly Godot.StringName EnableBackstopInstantly
public static readonly Godot.StringName MainMenuButtonFocused
public static readonly Godot.StringName MainMenuButtonUnfocused
public static readonly Godot.StringName OnAbandonRunButtonPressed
public static readonly Godot.StringName OnContinueButtonPressed
public static readonly Godot.StringName OnSubmenuStackChanged
public static readonly Godot.StringName OnWindowChange
public static readonly Godot.StringName OpenCompendiumSubmenu
public static readonly Godot.StringName OpenMultiplayerSubmenu
public static readonly Godot.StringName OpenPatchNotes
public static readonly Godot.StringName OpenProfileScreen
public static readonly Godot.StringName OpenSettingsMenu
public static readonly Godot.StringName OpenSingleplayerSubmenu
public static readonly Godot.StringName OpenTimelineScreen
public static readonly Godot.StringName Quit
public static readonly Godot.StringName RefreshButtons
public static readonly Godot.StringName SingleplayerButtonPressed
public static readonly Godot.StringName UpdateShaderLod
public static readonly Godot.StringName UpdateShaderMix
public static readonly Godot.StringName UpdateTimelineButtonBehavior
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _abandonRunButton
public static readonly Godot.StringName _backstopTween
public static readonly Godot.StringName _bg
public static readonly Godot.StringName _blur
public static readonly Godot.StringName _buttonReticleLeft
public static readonly Godot.StringName _buttonReticleRight
public static readonly Godot.StringName _compendiumButton
public static readonly Godot.StringName _continueButton
public static readonly Godot.StringName _lastHitButton
public static readonly Godot.StringName _multiplayerButton
public static readonly Godot.StringName _openProfileScreenButton
public static readonly Godot.StringName _openTimeline
public static readonly Godot.StringName _patchNotesButtonNode
public static readonly Godot.StringName _quitButton
public static readonly Godot.StringName _reticleTween
public static readonly Godot.StringName _runInfo
public static readonly Godot.StringName _settingsButton
public static readonly Godot.StringName _singleplayerButton
public static readonly Godot.StringName _timelineButton
public static readonly Godot.StringName _timelineNotificationDot
public static readonly Godot.StringName _window
public static readonly Godot.StringName BlurBackstop
public static readonly Godot.StringName ContinueRunInfo
public static readonly Godot.StringName DefaultFocusedControl
public static readonly Godot.StringName MainMenuButtons
public static readonly Godot.StringName PatchNotesScreen
public static readonly Godot.StringName SubmenuStack
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenuBg

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private Godot.Control _bg
private static const System.Single _bgScaleRatioThreshold = 1.5
private static readonly Godot.Vector2 _defaultBgScale
private Godot.Node2D _logo
private Godot.Tween _logoTween
private Godot.Window _window
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnWindowChange()
private System.Void ScaleBgIfNarrow(System.Single ratio)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void HideLogo()
public System.Void ShowLogo()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenuBg+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName HideLogo
public static readonly Godot.StringName OnWindowChange
public static readonly Godot.StringName ScaleBgIfNarrow
public static readonly Godot.StringName ShowLogo
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenuBg+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _bg
public static readonly Godot.StringName _logo
public static readonly Godot.StringName _logoTween
public static readonly Godot.StringName _window
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenuBg+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenuContinueButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenuTextButton`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu _mainMenu
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

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenuContinueButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenuTextButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnUnfocus
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenuContinueButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenuTextButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _mainMenu
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenuContinueButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenuTextButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenuSubmenuStack

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenuStack`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Nodes.Screens.Bestiary.NBestiary _bestiarySubmenu
private MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary.NCardLibrary _cardLibrarySubmenu
private Godot.PackedScene _characterSelectScreenScene
private MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NCharacterSelectScreen _characterSelectSubmenu
private MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NCompendiumSubmenu _compendiumSubmenu
private MegaCrit.Sts2.Core.Nodes.Screens.CustomRun.NCustomRunLoadScreen _customRunLoadScreen
private MegaCrit.Sts2.Core.Nodes.Screens.CustomRun.NCustomRunScreen _customRunScreen
private MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunLoadScreen _dailyLoadScreen
private MegaCrit.Sts2.Core.Nodes.Screens.DailyRun.NDailyRunScreen _dailyScreen
private MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NJoinFriendScreen _joinFriendSubmenu
private MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect.NMultiplayerLoadGameScreen _loadMultiplayerSubmenu
private MegaCrit.Sts2.Core.Nodes.Screens.ModdingScreen.NModdingScreen _moddingScreen
private MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMultiplayerHostSubmenu _multiplayerHostSubmenu
private MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMultiplayerSubmenu _multiplayerSubmenu
private MegaCrit.Sts2.Core.Nodes.Screens.PotionLab.NPotionLab _potionLabSubmenu
private MegaCrit.Sts2.Core.Nodes.Screens.ProfileScreen.NProfileScreen _profileScreen
private MegaCrit.Sts2.Core.Nodes.Screens.RelicCollection.NRelicCollection _relicCollectionSubmenu
private MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen.NRunHistory _runHistorySubmenu
private MegaCrit.Sts2.Core.Nodes.Screens.Settings.NSettingsScreen _settingsScreen
private Godot.PackedScene _settingsScreenScene
private MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSingleplayerSubmenu _singleplayerSubmenu
private MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen.NStatsScreen _statsScreen
private MegaCrit.Sts2.Core.Nodes.Screens.Timeline.NTimelineScreen _timelineScreen
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

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenuSubmenuStack+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenuStack+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenuSubmenuStack+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenuStack+PropertyName`。

接口：

```text
public static readonly Godot.StringName _bestiarySubmenu
public static readonly Godot.StringName _cardLibrarySubmenu
public static readonly Godot.StringName _characterSelectScreenScene
public static readonly Godot.StringName _characterSelectSubmenu
public static readonly Godot.StringName _compendiumSubmenu
public static readonly Godot.StringName _customRunLoadScreen
public static readonly Godot.StringName _customRunScreen
public static readonly Godot.StringName _dailyLoadScreen
public static readonly Godot.StringName _dailyScreen
public static readonly Godot.StringName _joinFriendSubmenu
public static readonly Godot.StringName _loadMultiplayerSubmenu
public static readonly Godot.StringName _moddingScreen
public static readonly Godot.StringName _multiplayerHostSubmenu
public static readonly Godot.StringName _multiplayerSubmenu
public static readonly Godot.StringName _potionLabSubmenu
public static readonly Godot.StringName _profileScreen
public static readonly Godot.StringName _relicCollectionSubmenu
public static readonly Godot.StringName _runHistorySubmenu
public static readonly Godot.StringName _settingsScreen
public static readonly Godot.StringName _settingsScreenScene
public static readonly Godot.StringName _singleplayerSubmenu
public static readonly Godot.StringName _statsScreen
public static readonly Godot.StringName _timelineScreen
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenuSubmenuStack+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenuStack+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenuTextButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private Godot.Color _defaultColor
private Godot.Color _downColor
private static readonly Godot.Vector2 _downScale
private static readonly Godot.StyleBoxEmpty _emptyStyleBox
private Godot.Color _hoveredColor
private static readonly Godot.Vector2 _hoverScale
private MegaCrit.Sts2.Core.Localization.LocString _locString
private static const System.Double _pressDownDur = 0.2
private Godot.Tween _tween
private static const System.Double _unhoverAnimDur = 0.5
public MegaCrit.Sts2.addons.mega_text.MegaLabel label
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task UpdatePivotOffset()
private System.Void AnimPressDown()
private System.Void AnimRelease()
private System.Void AnimUnhover()
private System.Void RefreshLabel()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void ConnectSignals()
protected virtual System.Void OnDisable()
protected virtual System.Void OnEnable()
protected virtual System.Void OnFocus()
protected virtual System.Void OnPress()
protected virtual System.Void OnRelease()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void SetLocalization(System.String locKey)
public virtual System.Void _Notification(System.Int32 what)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenuTextButton+<UpdatePivotOffset>d__16

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenuTextButton <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenuTextButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Notification
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AnimPressDown
public static readonly Godot.StringName AnimRelease
public static readonly Godot.StringName AnimUnhover
public static readonly Godot.StringName ConnectSignals
public static readonly Godot.StringName OnDisable
public static readonly Godot.StringName OnEnable
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName RefreshLabel
public static readonly Godot.StringName SetLocalization
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenuTextButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _defaultColor
public static readonly Godot.StringName _downColor
public static readonly Godot.StringName _hoveredColor
public static readonly Godot.StringName _tween
public static readonly Godot.StringName label
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenuTextButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMultiplayerHostSubmenu

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenuButton _customButton
private MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenuButton _dailyButton
private static const System.String _keyCustom = "CUSTOM_MP"
private static const System.String _keyDaily = "DAILY_MP"
private static const System.String _keyStandard = "STANDARD_MP"
private Godot.Control _loadingOverlay
private static readonly System.String _scenePath
private MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenuButton _standardButton
Godot.Control InitialFocusedControl { protected virtual get; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnCustomPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OnDailyPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OnStandardPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void RefreshButtons()
protected virtual Godot.Control get_InitialFocusedControl()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static [async] System.Threading.Tasks.Task StartHostAsync(MegaCrit.Sts2.Core.Runs.GameMode gameMode, Godot.Control loadingOverlay, MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenuStack stack)
public static MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMultiplayerHostSubmenu Create()
public System.Void StartHost(MegaCrit.Sts2.Core.Runs.GameMode gameMode)
public virtual System.Void _Ready()
public virtual System.Void OnSubmenuOpened()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMultiplayerHostSubmenu+<StartHostAsync>d__18

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Nullable<MegaCrit.Sts2.Core.Entities.Multiplayer.NetErrorInfo>> <>u__1
private MegaCrit.Sts2.Core.Multiplayer.NetHostGameService <netService>5__2
public MegaCrit.Sts2.Core.Runs.GameMode gameMode
public Godot.Control loadingOverlay
public MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenuStack stack
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMultiplayerHostSubmenu+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName OnCustomPressed
public static readonly Godot.StringName OnDailyPressed
public static readonly Godot.StringName OnStandardPressed
public static readonly Godot.StringName OnSubmenuOpened
public static readonly Godot.StringName RefreshButtons
public static readonly Godot.StringName StartHost
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMultiplayerHostSubmenu+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+PropertyName`。

接口：

```text
public static readonly Godot.StringName _customButton
public static readonly Godot.StringName _dailyButton
public static readonly Godot.StringName _loadingOverlay
public static readonly Godot.StringName _standardButton
public static readonly Godot.StringName InitialFocusedControl
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMultiplayerHostSubmenu+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMultiplayerSubmenu

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenuButton _abandonButton
private MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenuButton _hostButton
private MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenuButton _joinButton
private static const System.String _keyAbandon = "MP_ABANDON"
private static const System.String _keyHost = "HOST"
private static const System.String _keyJoin = "JOIN"
private static const System.String _keyLoad = "MP_LOAD"
private MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenuButton _loadButton
private Godot.Control _loadingOverlay
private static readonly System.String _scenePath
Godot.Control InitialFocusedControl { protected virtual get; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task StartHostAsync(MegaCrit.Sts2.Core.Saves.SerializableRun run)
private [async] System.Threading.Tasks.Task TryAbandonMultiplayerRun()
private System.Void AbandonRun(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OnHostPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OpenJoinFriendsScreen(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void StartLoad(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void UpdateButtons()
protected virtual Godot.Control get_InitialFocusedControl()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnSubmenuShown()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NJoinFriendScreen OnJoinFriendsPressed()
public static MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMultiplayerSubmenu Create()
public System.Void FastHost(MegaCrit.Sts2.Core.Runs.GameMode gameMode)
public System.Void StartHost(MegaCrit.Sts2.Core.Saves.SerializableRun run)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMultiplayerSubmenu+<StartHostAsync>d__21

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMultiplayerSubmenu <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Nullable<MegaCrit.Sts2.Core.Entities.Multiplayer.NetErrorInfo>> <>u__1
private MegaCrit.Sts2.Core.Multiplayer.NetHostGameService <netService>5__2
public MegaCrit.Sts2.Core.Saves.SerializableRun run
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMultiplayerSubmenu+<TryAbandonMultiplayerRun>d__16

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMultiplayerSubmenu <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMultiplayerSubmenu+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AbandonRun
public static readonly Godot.StringName Create
public static readonly Godot.StringName FastHost
public static readonly Godot.StringName OnHostPressed
public static readonly Godot.StringName OnJoinFriendsPressed
public static readonly Godot.StringName OnSubmenuShown
public static readonly Godot.StringName OpenJoinFriendsScreen
public static readonly Godot.StringName StartLoad
public static readonly Godot.StringName UpdateButtons
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMultiplayerSubmenu+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+PropertyName`。

接口：

```text
public static readonly Godot.StringName _abandonButton
public static readonly Godot.StringName _hostButton
public static readonly Godot.StringName _joinButton
public static readonly Godot.StringName _loadButton
public static readonly Godot.StringName _loadingOverlay
public static readonly Godot.StringName InitialFocusedControl
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMultiplayerSubmenu+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NOpenProfileScreenButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.addons.mega_text.MegaLabel _description
private static readonly MegaCrit.Sts2.Core.Localization.LocString _descriptionLoc
private MegaCrit.Sts2.Core.Nodes.Screens.ProfileScreen.NProfileIcon _profileIcon
private MegaCrit.Sts2.addons.mega_text.MegaLabel _title
private readonly MegaCrit.Sts2.Core.Localization.LocString _titleLoc
private Godot.Tween _tween
System.String[] Hotkeys { protected virtual get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void RefreshLabels()
private System.Void UpdateDescription()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.String[] get_Hotkeys()
protected virtual System.Void OnFocus()
protected virtual System.Void OnRelease()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Notification(System.Int32 what)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NOpenProfileScreenButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Notification
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName RefreshLabels
public static readonly Godot.StringName UpdateDescription
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NOpenProfileScreenButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _description
public static readonly Godot.StringName _profileIcon
public static readonly Godot.StringName _title
public static readonly Godot.StringName _tween
public static readonly Godot.StringName Hotkeys
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NOpenProfileScreenButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NPatchNotesButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private Godot.ShaderMaterial _hsv
private Godot.Control _icon
private static readonly Godot.StringName _v
System.String[] Hotkeys { protected virtual get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.String[] get_Hotkeys()
protected virtual System.Void OnFocus()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NPatchNotesButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnUnfocus
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NPatchNotesButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _hsv
public static readonly Godot.StringName _icon
public static readonly Godot.StringName Hotkeys
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NPatchNotesButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NPatchNotesScreen

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _backButton
private Godot.PackedScene _cachedScene
private System.Int32 _currentScrollLine
private MegaCrit.Sts2.addons.mega_text.MegaLabel _dateLabel
private static const System.String _engPatchNotesPath = "res://localization/eng/patch_notes"
private System.Int32 _index
private Godot.MarginContainer _marginContainer
private MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _nextButton
private System.Collections.Generic.List<System.String> _patchNotePaths
private MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _patchNotesToggle
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _patchText
private MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _prevButton
private MegaCrit.Sts2.Core.Nodes.GodotExtensions.NScrollableContainer _screenContents
private Godot.Tween _tween
private System.Boolean <IsOpen>k__BackingField
Godot.Control DefaultFocusedControl { public virtual get; }
System.Boolean IsOpen { public get; private set; }
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private static System.Boolean TryParseDate(System.String dateString, out System.String formattedDate)
private static System.String GetFileNameFromPath(System.String path)
private static System.String ReadPatchNoteFile(System.String engPatchNotePath)
private static System.String RemoveFileExtension(System.String fileName)
private System.Void <_Ready>b__18_0(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void <_Ready>b__18_1(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void <_Ready>b__18_2(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void <_Ready>b__18_3(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void <Close>b__23_0()
private System.Void Close()
private System.Void CreateNewPatchEntry()
private System.Void LoadPatchNoteText(System.String patchNotePath)
private System.Void NextPatchNote()
private System.Void PreviousPatchNote()
private System.Void set_IsOpen(System.Boolean value)
private System.Void UpdateDateLabel(System.String patchNotePath)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Boolean get_IsOpen()
public System.Void Open()
public virtual Godot.Control get_DefaultFocusedControl()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NPatchNotesScreen+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NPatchNotesScreen+<>c <>9
public static System.Func<System.String, System.String> <>9__22_0
private static .cctor()
public .ctor()
internal System.String <Open>b__22_0(System.String fileName)
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NPatchNotesScreen+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Close
public static readonly Godot.StringName CreateNewPatchEntry
public static readonly Godot.StringName GetFileNameFromPath
public static readonly Godot.StringName LoadPatchNoteText
public static readonly Godot.StringName NextPatchNote
public static readonly Godot.StringName Open
public static readonly Godot.StringName PreviousPatchNote
public static readonly Godot.StringName ReadPatchNoteFile
public static readonly Godot.StringName RemoveFileExtension
public static readonly Godot.StringName UpdateDateLabel
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NPatchNotesScreen+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _backButton
public static readonly Godot.StringName _cachedScene
public static readonly Godot.StringName _currentScrollLine
public static readonly Godot.StringName _dateLabel
public static readonly Godot.StringName _index
public static readonly Godot.StringName _marginContainer
public static readonly Godot.StringName _nextButton
public static readonly Godot.StringName _patchNotesToggle
public static readonly Godot.StringName _patchText
public static readonly Godot.StringName _prevButton
public static readonly Godot.StringName _screenContents
public static readonly Godot.StringName _tween
public static readonly Godot.StringName DefaultFocusedControl
public static readonly Godot.StringName IsOpen
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NPatchNotesScreen+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NShortSubmenuButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private Godot.Control _bgPanel
private System.Single _defaultV
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _description
private System.Single _focusV
private Godot.ShaderMaterial _hsv
private Godot.TextureRect _icon
private System.String _locKeyPrefix
private System.Single _pressV
private static readonly Godot.StringName _s
private MegaCrit.Sts2.addons.mega_text.MegaLabel _title
private Godot.Tween _tween
private static readonly Godot.StringName _v
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void RefreshLabels()
private System.Void UpdateShaderParam(System.Single newV)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void ConnectSignals()
protected virtual System.Void OnDisable()
protected virtual System.Void OnEnable()
protected virtual System.Void OnFocus()
protected virtual System.Void OnPress()
protected virtual System.Void OnRelease()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static System.String GetImagePath(System.String key)
public System.Void SetIconAndLocalization(System.String locKeyPrefix)
public virtual System.Void _Notification(System.Int32 what)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NShortSubmenuButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Notification
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName ConnectSignals
public static readonly Godot.StringName GetImagePath
public static readonly Godot.StringName OnDisable
public static readonly Godot.StringName OnEnable
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName RefreshLabels
public static readonly Godot.StringName SetIconAndLocalization
public static readonly Godot.StringName UpdateShaderParam
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NShortSubmenuButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _bgPanel
public static readonly Godot.StringName _defaultV
public static readonly Godot.StringName _description
public static readonly Godot.StringName _focusV
public static readonly Godot.StringName _hsv
public static readonly Godot.StringName _icon
public static readonly Godot.StringName _locKeyPrefix
public static readonly Godot.StringName _pressV
public static readonly Godot.StringName _title
public static readonly Godot.StringName _tween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NShortSubmenuButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSingleplayerSubmenu

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenuButton _customButton
private MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenuButton _dailyButton
private static const System.String _keyCustom = "CUSTOM"
private static const System.String _keyDaily = "DAILY"
private static const System.String _keyStandard = "STANDARD"
private static readonly System.String _scenePath
private MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenuButton _standardButton
Godot.Control InitialFocusedControl { protected virtual get; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OpenCharacterSelect(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OpenCustomScreen(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OpenDailyScreen()
private System.Void OpenDailyScreen(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void RefreshButtons()
protected virtual Godot.Control get_InitialFocusedControl()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSingleplayerSubmenu Create()
public virtual System.Void _Ready()
public virtual System.Void OnSubmenuOpened()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSingleplayerSubmenu+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName OnSubmenuOpened
public static readonly Godot.StringName OpenCharacterSelect
public static readonly Godot.StringName OpenCustomScreen
public static readonly Godot.StringName OpenDailyScreen
public static readonly Godot.StringName RefreshButtons
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSingleplayerSubmenu+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+PropertyName`。

接口：

```text
public static readonly Godot.StringName _customButton
public static readonly Godot.StringName _dailyButton
public static readonly Godot.StringName _standardButton
public static readonly Godot.StringName InitialFocusedControl
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSingleplayerSubmenu+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu

类型属性：`Public, Abstract, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private MegaCrit.Sts2.Core.Nodes.CommonUi.NBackButton _backButton
protected Godot.Control _lastFocusedControl
protected MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenuStack _stack
Godot.Control DefaultFocusedControl { public virtual get; }
Godot.Control InitialFocusedControl { protected abstract get; }
protected .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void <ConnectSignals>b__4_0(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OnScreenVisibilityChange()
protected abstract Godot.Control get_InitialFocusedControl()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void ConnectSignals()
protected virtual System.Void OnSubmenuHidden()
protected virtual System.Void OnSubmenuShown()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void HideBackButtonImmediately()
public System.Void SetStack(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenuStack stack)
public virtual Godot.Control get_DefaultFocusedControl()
public virtual System.Void _Ready()
public virtual System.Void OnSubmenuClosed()
public virtual System.Void OnSubmenuOpened()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName ConnectSignals
public static readonly Godot.StringName HideBackButtonImmediately
public static readonly Godot.StringName OnScreenVisibilityChange
public static readonly Godot.StringName OnSubmenuClosed
public static readonly Godot.StringName OnSubmenuHidden
public static readonly Godot.StringName OnSubmenuOpened
public static readonly Godot.StringName OnSubmenuShown
public static readonly Godot.StringName SetStack
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _backButton
public static readonly Godot.StringName _lastFocusedControl
public static readonly Godot.StringName _stack
public static readonly Godot.StringName DefaultFocusedControl
public static readonly Godot.StringName InitialFocusedControl
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenuButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private Godot.Control _bgPanel
private System.Single _defaultV
private MegaCrit.Sts2.addons.mega_text.MegaRichTextLabel _description
private static readonly Godot.Vector2 _hoverScale
private static const System.Single _hoverV = 1
private Godot.ShaderMaterial _hsv
private Godot.TextureRect _icon
private System.String _locKeyPrefix
private static readonly Godot.StringName _s
private Godot.Tween _scaleTween
private MegaCrit.Sts2.addons.mega_text.MegaLabel _title
private static readonly Godot.StringName _v
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void UpdateShaderParam(System.Single newV)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void ConnectSignals()
protected virtual System.Void OnDisable()
protected virtual System.Void OnEnable()
protected virtual System.Void OnFocus()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void RefreshLabels()
public System.Void SetIconAndLocalization(System.String locKeyPrefix)
public virtual System.Void _Notification(System.Int32 what)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenuButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Notification
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName ConnectSignals
public static readonly Godot.StringName OnDisable
public static readonly Godot.StringName OnEnable
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName RefreshLabels
public static readonly Godot.StringName SetIconAndLocalization
public static readonly Godot.StringName UpdateShaderParam
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenuButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _bgPanel
public static readonly Godot.StringName _defaultV
public static readonly Godot.StringName _description
public static readonly Godot.StringName _hsv
public static readonly Godot.StringName _icon
public static readonly Godot.StringName _locKeyPrefix
public static readonly Godot.StringName _scaleTween
public static readonly Godot.StringName _title
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenuButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenuStack

类型属性：`Public, Abstract, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu _mainMenu
private readonly System.Collections.Generic.Stack<MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu> _submenus
private MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenuStack+StackModifiedEventHandler backing_StackModified
System.Boolean SubmenusOpen { public get; }
event MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenuStack+StackModifiedEventHandler StackModified
protected .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotSignalList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void HideBackstop()
private System.Void ShowBackstop()
protected System.Void EmitSignalStackModified()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean HasGodotClassSignal(in Godot.NativeInterop.godot_string_name signal)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RaiseGodotClassSignalCallbacks(in Godot.NativeInterop.godot_string_name signal, Godot.NativeInterop.NativeVariantPtrArgs args)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public abstract MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu GetSubmenuType(System.Type type)
public abstract MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu PushSubmenuType(System.Type type)
public abstract T GetSubmenuType<T>() where T: [None] MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu
public abstract T PushSubmenuType<T>() where T: [None] MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu
public MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu Peek()
public System.Boolean get_SubmenusOpen()
public System.Void add_StackModified(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenuStack+StackModifiedEventHandler value)
public System.Void InitializeForMainMenu(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu mainMenu)
public System.Void Pop()
public System.Void Push(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenu screen)
public System.Void remove_StackModified(MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenuStack+StackModifiedEventHandler value)
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenuStack+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName HideBackstop
public static readonly Godot.StringName InitializeForMainMenu
public static readonly Godot.StringName Peek
public static readonly Godot.StringName Pop
public static readonly Godot.StringName Push
public static readonly Godot.StringName ShowBackstop
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenuStack+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _mainMenu
public static readonly Godot.StringName SubmenusOpen
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenuStack+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public static readonly Godot.StringName StackModified
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NSubmenuStack+StackModifiedEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke()
```
