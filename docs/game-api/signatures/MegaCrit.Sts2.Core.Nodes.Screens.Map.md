# MegaCrit.Sts2.Core.Nodes.Screens.Map

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.Screens.Map.DrawingMode

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Nodes.Screens.Map.DrawingMode Drawing = 1
public static const MegaCrit.Sts2.Core.Nodes.Screens.Map.DrawingMode Erasing = 2
public static const MegaCrit.Sts2.Core.Nodes.Screens.Map.DrawingMode None = 0
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.MapSplitVoteAnimation

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private MegaCrit.Sts2.Core.Entities.Players.Player _currentlyHighlightedPlayer
private System.Collections.Generic.Dictionary<MegaCrit.Sts2.Core.Map.MapCoord, MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapPoint> _mapPointDictionary
private MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapScreen _mapScreen
private MegaCrit.Sts2.Core.Runs.RunState _runState
private System.Collections.Generic.List<MegaCrit.Sts2.Core.Entities.Players.Player> _sortedPlayers
private System.Int32 _ticks
private MegaCrit.Sts2.Core.Entities.Players.Player _winner
public .ctor(MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapScreen mapScreen, MegaCrit.Sts2.Core.Runs.RunState runState, System.Collections.Generic.Dictionary<MegaCrit.Sts2.Core.Map.MapCoord, MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapPoint> mapPointDictionary)
private System.Int32 <TryPlay>b__8_2(System.Collections.Generic.KeyValuePair<MegaCrit.Sts2.Core.Entities.Players.Player, System.Nullable<MegaCrit.Sts2.Core.Map.MapCoord>> p)
private System.Int32 MapCoordComparer(System.Nullable<MegaCrit.Sts2.Core.Map.MapCoord> a, System.Nullable<MegaCrit.Sts2.Core.Map.MapCoord> b)
private System.Void HighlightPlayer(MegaCrit.Sts2.Core.Entities.Players.Player player)
private System.Void TickSplitVoteAnimation(System.Single value)
public [async] System.Threading.Tasks.Task TryPlay(MegaCrit.Sts2.Core.Map.MapCoord selectedCoord)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.MapSplitVoteAnimation+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Screens.Map.MapSplitVoteAnimation+<>c <>9
public static System.Func<System.Collections.Generic.KeyValuePair<MegaCrit.Sts2.Core.Entities.Players.Player, System.Nullable<MegaCrit.Sts2.Core.Map.MapCoord>>, System.Boolean> <>9__8_0
public static System.Func<System.Collections.Generic.KeyValuePair<MegaCrit.Sts2.Core.Entities.Players.Player, System.Nullable<MegaCrit.Sts2.Core.Map.MapCoord>>, System.Nullable<MegaCrit.Sts2.Core.Map.MapCoord>> <>9__8_1
public static System.Func<System.Collections.Generic.KeyValuePair<MegaCrit.Sts2.Core.Entities.Players.Player, System.Nullable<MegaCrit.Sts2.Core.Map.MapCoord>>, MegaCrit.Sts2.Core.Entities.Players.Player> <>9__8_3
private static .cctor()
public .ctor()
internal MegaCrit.Sts2.Core.Entities.Players.Player <TryPlay>b__8_3(System.Collections.Generic.KeyValuePair<MegaCrit.Sts2.Core.Entities.Players.Player, System.Nullable<MegaCrit.Sts2.Core.Map.MapCoord>> p)
internal System.Boolean <TryPlay>b__8_0(System.Collections.Generic.KeyValuePair<MegaCrit.Sts2.Core.Entities.Players.Player, System.Nullable<MegaCrit.Sts2.Core.Map.MapCoord>> p)
internal System.Nullable<MegaCrit.Sts2.Core.Map.MapCoord> <TryPlay>b__8_1(System.Collections.Generic.KeyValuePair<MegaCrit.Sts2.Core.Entities.Players.Player, System.Nullable<MegaCrit.Sts2.Core.Map.MapCoord>> p)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.MapSplitVoteAnimation+<TryPlay>d__8

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.Map.MapSplitVoteAnimation <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
public MegaCrit.Sts2.Core.Map.MapCoord selectedCoord
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NAncientMapPoint

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapPoint`。

接口：`System.IDisposable`

```text
private System.Single _elapsedTime
private Godot.TextureRect _icon
private Godot.TextureRect _outline
private static const System.Single _pulseSpeed = 4
private static const System.Single _scaleAmount = 0.05
private static const System.Single _scaleBase = 1
private Godot.Tween _tween
System.String AncientMapPointPath { private static get; }
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
Godot.Vector2 DownScale { protected virtual get; }
Godot.Color HoveredColor { protected virtual get; }
Godot.Vector2 HoverScale { protected virtual get; }
Godot.Material TargetMaterial { private get; }
Godot.Color TraveledColor { protected virtual get; }
Godot.Color UntravelableColor { protected virtual get; }
System.String UntravelableMaterialPath { private static get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private Godot.Material get_TargetMaterial()
private static System.String get_AncientMapPointPath()
private static System.String get_UntravelableMaterialPath()
private System.Void AnimHover()
private System.Void AnimPressDown()
private System.Void AnimUnhover()
protected virtual Godot.Color get_HoveredColor()
protected virtual Godot.Color get_TraveledColor()
protected virtual Godot.Color get_UntravelableColor()
protected virtual Godot.Vector2 get_DownScale()
protected virtual Godot.Vector2 get_HoverScale()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnFocus()
protected virtual System.Void OnPress()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RefreshColorInstantly()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.Map.NAncientMapPoint Create(MegaCrit.Sts2.Core.Map.MapPoint point, MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapScreen screen, MegaCrit.Sts2.Core.Runs.IRunState runState)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
public virtual System.Void OnSelected()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NAncientMapPoint+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapPoint+MethodName`。

接口：

```text
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AnimHover
public static readonly Godot.StringName AnimPressDown
public static readonly Godot.StringName AnimUnhover
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnSelected
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName RefreshColorInstantly
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NAncientMapPoint+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapPoint+PropertyName`。

接口：

```text
public static readonly Godot.StringName _elapsedTime
public static readonly Godot.StringName _icon
public static readonly Godot.StringName _outline
public static readonly Godot.StringName _tween
public static readonly Godot.StringName DownScale
public static readonly Godot.StringName HoveredColor
public static readonly Godot.StringName HoverScale
public static readonly Godot.StringName TargetMaterial
public static readonly Godot.StringName TraveledColor
public static readonly Godot.StringName UntravelableColor
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NAncientMapPoint+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapPoint+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NBaseMapDrawingButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
public .ctor()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NBaseMapDrawingButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NBaseMapDrawingButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NBaseMapDrawingButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NBossMapPoint

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapPoint`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Models.ActModel _act
private MegaCrit.Sts2.Core.Bindings.MegaSpine.MegaSprite _animController
private static readonly Godot.StringName _blackLayerColor
private Godot.Tween _hoverTween
private static readonly Godot.StringName _mapColor
private Godot.ShaderMaterial _material
private Godot.TextureRect _placeholderImage
private Godot.TextureRect _placeholderOutline
private Godot.Node2D _spineSprite
private Godot.Node2D _spriteContainer
private System.Boolean _usesSpine
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
System.String BossMapPointPath { private static get; }
Godot.Vector2 DownScale { protected virtual get; }
Godot.Color HoveredColor { protected virtual get; }
Godot.Vector2 HoverScale { protected virtual get; }
Godot.Color TraveledColor { protected virtual get; }
Godot.Color UntravelableColor { protected virtual get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private static System.String get_BossMapPointPath()
protected virtual Godot.Color get_HoveredColor()
protected virtual Godot.Color get_TraveledColor()
protected virtual Godot.Color get_UntravelableColor()
protected virtual Godot.Vector2 get_DownScale()
protected virtual Godot.Vector2 get_HoverScale()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnFocus()
protected virtual System.Void OnPress()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RefreshColorInstantly()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.Map.NBossMapPoint Create(MegaCrit.Sts2.Core.Map.MapPoint point, MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapScreen screen, MegaCrit.Sts2.Core.Runs.IRunState runState)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public virtual System.Void _Ready()
public virtual System.Void OnSelected()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NBossMapPoint+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapPoint+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnSelected
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName RefreshColorInstantly
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NBossMapPoint+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapPoint+PropertyName`。

接口：

```text
public static readonly Godot.StringName _hoverTween
public static readonly Godot.StringName _material
public static readonly Godot.StringName _placeholderImage
public static readonly Godot.StringName _placeholderOutline
public static readonly Godot.StringName _spineSprite
public static readonly Godot.StringName _spriteContainer
public static readonly Godot.StringName _usesSpine
public static readonly Godot.StringName DownScale
public static readonly Godot.StringName HoveredColor
public static readonly Godot.StringName HoverScale
public static readonly Godot.StringName TraveledColor
public static readonly Godot.StringName UntravelableColor
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NBossMapPoint+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapPoint+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NControllerMapDrawingInput

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawingInput`。

接口：`System.IDisposable`

```text
private Godot.Control _cursor
private Godot.Texture2D _cursorTex
private Godot.Texture2D _cursorTiltedTex
private Godot.Vector2 _direction
private Godot.Vector2 _drawingIconPos
private Godot.Vector2 _eraserIconPos
private System.Boolean _isPressed
private static const System.String _scenePath = "res://scenes/screens/map/controller_map_drawing_input.tscn"
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnGuiFocusChanged(Godot.Control _)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawingInput Create()
public virtual System.Void _Input(Godot.InputEvent input)
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NControllerMapDrawingInput+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawingInput+MethodName`。

接口：

```text
public static readonly Godot.StringName _Input
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName OnGuiFocusChanged
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NControllerMapDrawingInput+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawingInput+PropertyName`。

接口：

```text
public static readonly Godot.StringName _cursor
public static readonly Godot.StringName _cursorTex
public static readonly Godot.StringName _cursorTiltedTex
public static readonly Godot.StringName _direction
public static readonly Godot.StringName _drawingIconPos
public static readonly Godot.StringName _eraserIconPos
public static readonly Godot.StringName _isPressed
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NControllerMapDrawingInput+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawingInput+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapBg

类型属性：`Public, BeforeFieldInit`；基类：`Godot.VBoxContainer`。

接口：`System.IDisposable`

```text
private static const System.Single _adjustY = -1540
private static const System.Single _defaultY = -1620
private MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawings _drawings
private static const System.Single _fourByThree = 1.3333334
private Godot.TextureRect _mapBot
private Godot.TextureRect _mapMid
private Godot.TextureRect _mapTop
private System.Single _offsetX
private MegaCrit.Sts2.Core.Runs.IRunState _runState
private static const System.Single _sixteenByNine = 1.7777778
private Godot.Window _window
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnVisibilityChanged()
private System.Void OnWindowChange()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void Initialize(MegaCrit.Sts2.Core.Runs.IRunState runState)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapBg+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.VBoxContainer+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnVisibilityChanged
public static readonly Godot.StringName OnWindowChange
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapBg+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.VBoxContainer+PropertyName`。

接口：

```text
public static readonly Godot.StringName _drawings
public static readonly Godot.StringName _mapBot
public static readonly Godot.StringName _mapMid
public static readonly Godot.StringName _mapTop
public static readonly Godot.StringName _offsetX
public static readonly Godot.StringName _window
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapBg+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.VBoxContainer+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapClearButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private static readonly Godot.Color _activeColor
private Godot.Control _drawingToolHolder
private static readonly Godot.StringName _glowImagePath
private MegaCrit.Sts2.Core.HoverTips.HoverTip _hoverTip
private Godot.TextureRect _icon
private static readonly Godot.StringName _imagePath
private static readonly Godot.Color _inactiveColor
private Godot.Tween _tween
private static .cctor()
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

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapClearButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnUnfocus
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapClearButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _drawingToolHolder
public static readonly Godot.StringName _icon
public static readonly Godot.StringName _tween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapClearButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private static readonly Godot.Color _activeColor
private Godot.Control _drawingToolHolder
private static readonly Godot.StringName _glowImagePath
private MegaCrit.Sts2.Core.HoverTips.HoverTip _hoverTip
private Godot.TextureRect _icon
private static readonly Godot.StringName _imagePath
private static readonly Godot.Color _inactiveColor
private System.Boolean _isDrawing
private Godot.Tween _tween
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnControllerUpdated()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnFocus()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Void SetIsDrawing(System.Boolean isDrawing)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnControllerUpdated
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName SetIsDrawing
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _drawingToolHolder
public static readonly Godot.StringName _icon
public static readonly Godot.StringName _isDrawing
public static readonly Godot.StringName _tween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawingInput

类型属性：`Public, Abstract, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
protected MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawings _drawings
private MegaCrit.Sts2.Core.Nodes.Screens.Map.DrawingMode <DrawingMode>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawingInput+FinishedEventHandler backing_Finished
MegaCrit.Sts2.Core.Nodes.Screens.Map.DrawingMode DrawingMode { public get; private set; }
event MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawingInput+FinishedEventHandler Finished
protected .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotSignalList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void set_DrawingMode(MegaCrit.Sts2.Core.Nodes.Screens.Map.DrawingMode value)
protected System.Void EmitSignalFinished()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean HasGodotClassSignal(in Godot.NativeInterop.godot_string_name signal)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RaiseGodotClassSignalCallbacks(in Godot.NativeInterop.godot_string_name signal, Godot.NativeInterop.NativeVariantPtrArgs args)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public MegaCrit.Sts2.Core.Nodes.Screens.Map.DrawingMode get_DrawingMode()
public static MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawingInput Create(MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawings drawings, MegaCrit.Sts2.Core.Nodes.Screens.Map.DrawingMode drawingMode, System.Boolean stopOnMouseRelease = False)
public System.Void add_Finished(MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawingInput+FinishedEventHandler value)
public System.Void remove_Finished(MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawingInput+FinishedEventHandler value)
public System.Void StopDrawing()
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawingInput+FinishedEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawingInput+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Create
public static readonly Godot.StringName StopDrawing
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawingInput+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _drawings
public static readonly Godot.StringName DrawingMode
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawingInput+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public static readonly Godot.StringName Finished
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawings

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Nodes.CommonUi.NCursorManager _cursorManager
private Godot.Vector2 _defaultSize
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawings+DrawingState> _drawingStates
private Godot.Material _eraserMaterial
private System.Boolean _initialized
private MegaCrit.Sts2.Core.Multiplayer.Game.PeerInput.PeerInputSynchronizer _inputSynchronizer
private System.UInt64 _lastMessageMsec
private Godot.PackedScene _lineDrawScene
private static readonly System.String _lineDrawScenePath
private Godot.PackedScene _lineEraseScene
private static readonly System.String _lineEraseScenePath
private static const System.Single _minimumPointDistance = 2
private static const System.Int32 _minUpdateMsec = 50
private MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService _netService
private MegaCrit.Sts2.Core.Runs.IPlayerCollection _playerCollection
private static readonly System.String _playerDrawingPath
private MegaCrit.Sts2.Core.Multiplayer.Messages.Game.Flavor.MapDrawingMessage _queuedMessage
private System.Threading.Tasks.Task _sendMessageTask
public static readonly Godot.Vector2 drawingCursorHotspot
public static const System.String drawingCursorPath = "res://images/packed/common_ui/cursor_quill.png"
public static const System.String drawingCursorTiltedPath = "res://images/packed/common_ui/cursor_quill_tilted.png"
public static readonly Godot.Vector2 erasingCursorHotspot
public static const System.String erasingCursorPath = "res://images/packed/common_ui/cursor_eraser.png"
public static const System.String erasingCursorTiltedPath = "res://images/packed/common_ui/cursor_eraser_tilted.png"
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
System.Collections.Generic.IEnumerable<System.String> SelfAssetPaths { private static get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task QueueSyncMessage(System.Int32 delayMsec)
private [async] System.Threading.Tasks.Task SendSyncMessageAfterSmallDelay()
private [async] System.Threading.Tasks.Task SetVisibleLater(MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawings+DrawingState state)
private Godot.Line2D CreateLineForPlayer(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Boolean isErasing)
private Godot.Vector2 FromNetPosition(Godot.Vector2 pos)
private Godot.Vector2 ToNetPosition(Godot.Vector2 pos)
private MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawings+DrawingState GetDrawingStateForPlayer(System.UInt64 playerId)
private static System.Collections.Generic.IEnumerable<System.String> get_SelfAssetPaths()
private System.Boolean ShouldShowMapDrawing(MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawings+DrawingState state)
private System.Void BeginLine(MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawings+DrawingState state, Godot.Vector2 position, System.Nullable<MegaCrit.Sts2.Core.Nodes.Screens.Map.DrawingMode> overrideDrawingMode)
private System.Void ClearAllLinesForPlayer(MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawings+DrawingState state)
private System.Void HandleClearMapDrawingsMessage(MegaCrit.Sts2.Core.Multiplayer.Messages.Game.Flavor.ClearMapDrawingsMessage message, System.UInt64 senderId)
private System.Void HandleDrawingMessage(MegaCrit.Sts2.Core.Multiplayer.Messages.Game.Flavor.MapDrawingMessage message, System.UInt64 senderId)
private System.Void HandleMapDrawingModeChangedMessage(MegaCrit.Sts2.Core.Multiplayer.Messages.Game.Flavor.MapDrawingModeChangedMessage message, System.UInt64 senderId)
private System.Void OnPlayerScreenChanged(System.UInt64 playerId, MegaCrit.Sts2.Core.Entities.Multiplayer.NetScreenType oldScreenType)
private System.Void QueueOrSendEvent(MegaCrit.Sts2.Core.Multiplayer.Game.PeerInput.NetMapDrawingEvent ev)
private System.Void SendSyncMessage()
private System.Void SetDrawingMode(MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawings+DrawingState state, MegaCrit.Sts2.Core.Nodes.Screens.Map.DrawingMode drawingMode)
private System.Void StopDrawingLine(MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawings+DrawingState state)
private System.Void TrySendSyncMessage()
private System.Void UpdateCurrentLinePosition(MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawings+DrawingState state, Godot.Vector2 position)
private System.Void UpdateLocalCursor()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public MegaCrit.Sts2.Core.Nodes.Screens.Map.DrawingMode GetDrawingMode(System.UInt64 playerId)
public MegaCrit.Sts2.Core.Nodes.Screens.Map.DrawingMode GetLocalDrawingMode(System.Boolean useOverride = True)
public MegaCrit.Sts2.Core.Saves.MapDrawing.SerializableMapDrawings GetSerializableMapDrawings()
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Boolean IsDrawing(System.UInt64 playerId)
public System.Boolean IsLocalDrawing()
public System.Void BeginLineLocal(Godot.Vector2 position, System.Nullable<MegaCrit.Sts2.Core.Nodes.Screens.Map.DrawingMode> overrideDrawingMode)
public System.Void ClearAllLines()
public System.Void ClearDrawnLinesLocal()
public System.Void Initialize(MegaCrit.Sts2.Core.Multiplayer.Game.INetGameService netService, MegaCrit.Sts2.Core.Runs.IPlayerCollection playerCollection, MegaCrit.Sts2.Core.Multiplayer.Game.PeerInput.PeerInputSynchronizer inputSynchronizer)
public System.Void LoadDrawings(MegaCrit.Sts2.Core.Saves.MapDrawing.SerializableMapDrawings drawings)
public System.Void RepositionBasedOnBackground(Godot.Control mapBg)
public System.Void SetDrawingModeLocal(MegaCrit.Sts2.Core.Nodes.Screens.Map.DrawingMode drawingMode)
public System.Void StopLineLocal()
public System.Void UpdateCurrentLinePositionLocal(Godot.Vector2 position)
public System.Void UpdateVisibilityFromSettings()
public virtual System.Void _Notification(System.Int32 what)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawings+<>c__DisplayClass52_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.UInt64 playerId
public .ctor()
internal System.Boolean <GetDrawingStateForPlayer>b__0(MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawings+DrawingState s)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawings+<QueueSyncMessage>d__62

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawings <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public System.Int32 delayMsec
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawings+<SendSyncMessageAfterSmallDelay>d__63

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawings <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.YieldAwaitable+YieldAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawings+<SetVisibleLater>d__53

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawings <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
public MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawings+DrawingState state
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawings+DrawingState

类型属性：`NestedPrivate, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public Godot.Line2D currentlyDrawingLine
public MegaCrit.Sts2.Core.Nodes.Screens.Map.DrawingMode drawingMode
public Godot.TextureRect drawingTexture
public Godot.SubViewport drawViewport
public System.Nullable<MegaCrit.Sts2.Core.Nodes.Screens.Map.DrawingMode> overrideDrawingMode
public System.UInt64 playerId
MegaCrit.Sts2.Core.Nodes.Screens.Map.DrawingMode CurrentDrawingMode { public get; }
System.Boolean IsDrawing { public get; }
public .ctor()
public MegaCrit.Sts2.Core.Nodes.Screens.Map.DrawingMode get_CurrentDrawingMode()
public System.Boolean get_IsDrawing()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawings+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _Notification
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName ClearAllLines
public static readonly Godot.StringName ClearDrawnLinesLocal
public static readonly Godot.StringName FromNetPosition
public static readonly Godot.StringName GetDrawingMode
public static readonly Godot.StringName GetLocalDrawingMode
public static readonly Godot.StringName IsDrawing
public static readonly Godot.StringName IsLocalDrawing
public static readonly Godot.StringName OnPlayerScreenChanged
public static readonly Godot.StringName RepositionBasedOnBackground
public static readonly Godot.StringName SendSyncMessage
public static readonly Godot.StringName SetDrawingModeLocal
public static readonly Godot.StringName StopLineLocal
public static readonly Godot.StringName ToNetPosition
public static readonly Godot.StringName TrySendSyncMessage
public static readonly Godot.StringName UpdateCurrentLinePositionLocal
public static readonly Godot.StringName UpdateLocalCursor
public static readonly Godot.StringName UpdateVisibilityFromSettings
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawings+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _cursorManager
public static readonly Godot.StringName _defaultSize
public static readonly Godot.StringName _eraserMaterial
public static readonly Godot.StringName _initialized
public static readonly Godot.StringName _lastMessageMsec
public static readonly Godot.StringName _lineDrawScene
public static readonly Godot.StringName _lineEraseScene
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawings+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapEraseButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private static readonly Godot.Color _activeColor
private Godot.Control _drawingToolHolder
private static readonly Godot.StringName _glowImagePath
private MegaCrit.Sts2.Core.HoverTips.HoverTip _hoverTip
private Godot.TextureRect _icon
private static readonly Godot.StringName _imagePath
private static readonly Godot.Color _inactiveColor
private System.Boolean _isErasing
private Godot.Tween _tween
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void OnControllerUpdated()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnFocus()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Void SetIsErasing(System.Boolean isErasing)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapEraseButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnControllerUpdated
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName SetIsErasing
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapEraseButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _drawingToolHolder
public static readonly Godot.StringName _icon
public static readonly Godot.StringName _isErasing
public static readonly Godot.StringName _tween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapEraseButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapLegendItem

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private static readonly Godot.Vector2 _hoverScale
private MegaCrit.Sts2.Core.HoverTips.HoverTip _hoverTip
private Godot.TextureRect _icon
private MegaCrit.Sts2.Core.Map.MapPointType _pointType
private Godot.Tween _scaleDownTween
private static const System.Single _unhoverAnimDur = 0.5
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void SetLocalizedFields(System.String name)
private System.Void SetMapPointType(System.String name)
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

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapLegendItem+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName SetLocalizedFields
public static readonly Godot.StringName SetMapPointType
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapLegendItem+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _icon
public static readonly Godot.StringName _pointType
public static readonly Godot.StringName _scaleDownTween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapLegendItem+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapMarker

类型属性：`Public, BeforeFieldInit`；基类：`Godot.TextureRect`。

接口：`System.IDisposable`

```text
private System.Boolean _isEnabled
private Godot.Vector2 _posOffset
private Godot.Tween _tween
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Void <HideMapPoint>b__6_0()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Void HideMapPoint()
public System.Void Initialize(MegaCrit.Sts2.Core.Entities.Players.Player player)
public System.Void ResetMapPoint()
public System.Void SetMapPoint(MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapPoint node)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapMarker+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.TextureRect+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName HideMapPoint
public static readonly Godot.StringName ResetMapPoint
public static readonly Godot.StringName SetMapPoint
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapMarker+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.TextureRect+PropertyName`。

接口：

```text
public static readonly Godot.StringName _isEnabled
public static readonly Godot.StringName _posOffset
public static readonly Godot.StringName _tween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapMarker+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.TextureRect+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapPoint

类型属性：`Public, Abstract, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
protected MegaCrit.Sts2.Core.Nodes.Combat.NSelectionReticle _controllerSelectionReticle
protected Godot.Color _outlineColor
protected static const System.Double _pressDownDur = 0.3
protected MegaCrit.Sts2.Core.Runs.IRunState _runState
protected MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapScreen _screen
private MegaCrit.Sts2.Core.Map.MapPointState _state
protected static const System.Double _unhoverAnimDur = 0.5
private MegaCrit.Sts2.Core.Map.MapPoint <Point>k__BackingField
private MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer <VoteContainer>k__BackingField
System.Boolean AllowFocusWhileDisabled { protected virtual get; }
Godot.Vector2 DownScale { protected abstract get; }
Godot.Color HoveredColor { protected abstract get; }
Godot.Vector2 HoverScale { protected abstract get; }
System.Boolean IsTravelable { protected get; }
MegaCrit.Sts2.Core.Map.MapPoint Point { public get; protected set; }
MegaCrit.Sts2.Core.Map.MapPointState State { public get; public set; }
Godot.Color TargetColor { protected get; }
Godot.Color TraveledColor { protected abstract get; }
Godot.Color UntravelableColor { protected abstract get; }
MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer VoteContainer { public get; public set; }
protected .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private System.Boolean ShouldDisplayPlayerVote(MegaCrit.Sts2.Core.Entities.Players.Player player)
protected abstract Godot.Color get_HoveredColor()
protected abstract Godot.Color get_TraveledColor()
protected abstract Godot.Color get_UntravelableColor()
protected abstract Godot.Vector2 get_DownScale()
protected abstract Godot.Vector2 get_HoverScale()
protected Godot.Color get_TargetColor()
protected System.Boolean get_IsTravelable()
protected System.Boolean IsInputAllowed()
protected System.Void set_Point(MegaCrit.Sts2.Core.Map.MapPoint value)
protected virtual System.Boolean get_AllowFocusWhileDisabled()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void ConnectSignals()
protected virtual System.Void OnFocus()
protected virtual System.Void OnRelease()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RefreshColorInstantly()
protected virtual System.Void RefreshState()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public MegaCrit.Sts2.Core.Map.MapPoint get_Point()
public MegaCrit.Sts2.Core.Map.MapPointState get_State()
public MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer get_VoteContainer()
public System.Void RefreshVisualsInstantly()
public System.Void set_State(MegaCrit.Sts2.Core.Map.MapPointState value)
public System.Void set_VoteContainer(MegaCrit.Sts2.Core.Nodes.CommonUi.NMultiplayerVoteContainer value)
public virtual System.Void _Ready()
public virtual System.Void OnSelected()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapPoint+<>c__DisplayClass43_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapPoint <>4__this
public MegaCrit.Sts2.Core.Nodes.HoverTips.NHoverTipSet tip
public .ctor()
internal System.Void <OnFocus>b__0()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapPoint+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName ConnectSignals
public static readonly Godot.StringName IsInputAllowed
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnSelected
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName RefreshColorInstantly
public static readonly Godot.StringName RefreshState
public static readonly Godot.StringName RefreshVisualsInstantly
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapPoint+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _controllerSelectionReticle
public static readonly Godot.StringName _outlineColor
public static readonly Godot.StringName _screen
public static readonly Godot.StringName _state
public static readonly Godot.StringName AllowFocusWhileDisabled
public static readonly Godot.StringName DownScale
public static readonly Godot.StringName HoveredColor
public static readonly Godot.StringName HoverScale
public static readonly Godot.StringName IsTravelable
public static readonly Godot.StringName State
public static readonly Godot.StringName TargetColor
public static readonly Godot.StringName TraveledColor
public static readonly Godot.StringName UntravelableColor
public static readonly Godot.StringName VoteContainer
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapPoint+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapScreen

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`, `MegaCrit.Sts2.Core.Multiplayer.Game.PeerInput.INetCursorPositionTranslator`

```text
private Godot.Tween _actAnimTween
private MegaCrit.Sts2.Core.Nodes.CommonUi.NBackButton _backButton
private Godot.Control _backstop
private MegaCrit.Sts2.Core.Nodes.Screens.Map.NBossMapPoint _bossPointNode
private System.Boolean _canInterruptAnim
private System.Single _controllerScrollAmount
private System.Single _distX
private System.Single _distY
private MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawingInput _drawingInput
private Godot.Control _drawingTools
private MegaCrit.Sts2.Core.Nodes.CommonUi.NHotkeyIcon _drawingToolsHotkeyIcon
private System.Boolean _hasPlayedAnimation
private System.Boolean _isDragging
private System.Boolean _isInputDisabled
private MegaCrit.Sts2.Core.Nodes.CommonUi.NHotkeyIcon _legendHotkeyIcon
private Godot.Control _legendItems
private MegaCrit.Sts2.Core.Map.ActMap _map
private readonly System.Double _mapAnimDuration
private readonly System.Double _mapAnimStartDelay
private MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapBg _mapBgContainer
private MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapClearButton _mapClearButton
private Godot.Control _mapContainer
private MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawButton _mapDrawingButton
private MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapEraseButton _mapErasingButton
private Godot.Control _mapLegend
private readonly System.Collections.Generic.Dictionary<MegaCrit.Sts2.Core.Map.MapCoord, MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapPoint> _mapPointDictionary
private System.Single _mapScrollAnimTimer
private static const System.String _mapTickScenePath = "res://scenes/ui/map_dot.tscn"
private MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapMarker _marker
private static const System.Single _pathAngleJitter = 0.1
private static const System.Single _pathPosJitter = 3
private readonly System.Collections.Generic.Dictionary<System.ValueTuple<MegaCrit.Sts2.Core.Map.MapCoord, MegaCrit.Sts2.Core.Map.MapCoord>, System.Collections.Generic.IReadOnlyList<Godot.TextureRect>> _paths
private Godot.Control _pathsContainer
private static const System.Single _pointJitterX = 21
private static const System.Single _pointJitterY = 25
private Godot.Control _points
private Godot.Tween _promptTween
private MegaCrit.Sts2.Core.Runs.RunState _runState
private static const System.Single _scrollLimitBottom = -600
private static const System.Single _scrollLimitTop = 1800
private MegaCrit.Sts2.Core.Nodes.Screens.Map.NBossMapPoint _secondBossPointNode
private MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapShareButton _shareButton
private Godot.Vector2 _startDragPos
private MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapPoint _startingPointNode
private Godot.Vector2 _targetDragPos
private static const System.Single _tickDist = 22
private static readonly Godot.Vector2 _tickTraveledScale
private static const System.Single _totalHeight = 2325
private static const System.Single _totalWidth = 1050
private Godot.Tween _tween
private MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawings <Drawings>k__BackingField
private System.Boolean <IsDebugTravelEnabled>k__BackingField
private System.Boolean <IsOpen>k__BackingField
private System.Boolean <IsTravelEnabled>k__BackingField
private System.Boolean <IsTraveling>k__BackingField
private readonly System.Collections.Generic.Dictionary<MegaCrit.Sts2.Core.Entities.Players.Player, System.Nullable<MegaCrit.Sts2.Core.Map.MapCoord>> <PlayerVoteDictionary>k__BackingField
private MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapScreen+ClosedEventHandler backing_Closed
private MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapScreen+OpenedEventHandler backing_Opened
private System.Action<MegaCrit.Sts2.Core.Map.MapPointType> PointTypeHighlighted
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
Godot.Control DefaultFocusedControl { public virtual get; }
MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawings Drawings { public get; private set; }
MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapScreen Instance { public static get; }
System.Boolean IsDebugTravelEnabled { public get; private set; }
System.Boolean IsOpen { public get; private set; }
System.Boolean IsTravelEnabled { public get; private set; }
System.Boolean IsTraveling { public get; public set; }
System.Single MapLegendX { private get; }
System.Collections.Generic.Dictionary<MegaCrit.Sts2.Core.Entities.Players.Player, System.Nullable<MegaCrit.Sts2.Core.Map.MapCoord>> PlayerVoteDictionary { public get; }
event MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapScreen+ClosedEventHandler Closed
event MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapScreen+OpenedEventHandler Opened
event System.Action<MegaCrit.Sts2.Core.Map.MapPointType> PointTypeHighlighted
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotSignalList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task AnimClose()
private [async] System.Threading.Tasks.Task DisableInputVeryBriefly()
private [async] System.Threading.Tasks.Task MapFtueCheck()
private [async] System.Threading.Tasks.Task StartOfActAnim()
private Godot.Error <_Ready>b__82_0()
private Godot.Vector2 GetLineEndpoint(MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapPoint point)
private Godot.Vector2 GetMapPositionFromNetPosition(Godot.Vector2 netPosition)
private MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapPoint <SetMap>b__85_0(MegaCrit.Sts2.Core.Map.MapPoint p)
private System.Boolean <get_DefaultFocusedControl>b__132_1(MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapPoint mp)
private System.Boolean <OnLegendHotkeyPressed>b__134_0(MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapLegendItem c)
private System.Boolean CanScroll()
private System.Collections.Generic.IReadOnlyList<Godot.TextureRect> CreatePath(Godot.Vector2 start, Godot.Vector2 end)
private System.Single get_MapLegendX()
private System.Void <OnMapDrawingButtonPressed>b__126_0()
private System.Void <OnMapErasingButtonPressed>b__127_0()
private System.Void <ProcessMouseDrawingEvent>b__105_0()
private System.Void DrawPaths(MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapPoint mapPointNode, MegaCrit.Sts2.Core.Map.MapPoint mapPoint)
private System.Void InitMapPrompt()
private System.Void InitMapVotes()
private System.Void OnBackButtonPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OnCapstoneChanged()
private System.Void OnClearMapDrawingButtonPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OnDrawingToolsHotkeyPressed()
private System.Void OnLegendHotkeyPressed()
private System.Void OnMapDrawingButtonPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OnMapErasingButtonPressed(MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton _)
private System.Void OnPlayerVoteCancelled(MegaCrit.Sts2.Core.Entities.Players.Player player)
private System.Void OnPlayerVoteChanged(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Nullable<MegaCrit.Sts2.Core.Multiplayer.Game.MapVote> oldLocation, System.Nullable<MegaCrit.Sts2.Core.Multiplayer.Game.MapVote> newLocation)
private System.Void OnPlayerVoteChangedInternal(MegaCrit.Sts2.Core.Entities.Players.Player player, System.Nullable<MegaCrit.Sts2.Core.Map.MapCoord> oldCoord, System.Nullable<MegaCrit.Sts2.Core.Map.MapCoord> newCoord)
private System.Void OnVisibilityChanged()
private System.Void PlayStartOfActAnimation()
private System.Void ProcessControllerEvent(Godot.InputEvent inputEvent)
private System.Void ProcessMouseDrawingEvent(Godot.InputEvent inputEvent)
private System.Void ProcessMouseEvent(Godot.InputEvent inputEvent)
private System.Void ProcessScrollEvent(Godot.InputEvent inputEvent)
private System.Void RecalculateTravelability()
private System.Void RemoveAllMapPointsAndPaths()
private System.Void set_Drawings(MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawings value)
private System.Void set_IsDebugTravelEnabled(System.Boolean value)
private System.Void set_IsOpen(System.Boolean value)
private System.Void set_IsTravelEnabled(System.Boolean value)
private System.Void SetInterruptable()
private System.Void TryCancelStartOfActAnim()
private System.Void UpdateDrawingButtonStates()
private System.Void UpdateHotkeyDisplay()
private System.Void UpdateScrollPosition(System.Double delta)
protected System.Void EmitSignalClosed()
protected System.Void EmitSignalOpened()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean HasGodotClassSignal(in Godot.NativeInterop.godot_string_name signal)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RaiseGodotClassSignalCallbacks(in Godot.NativeInterop.godot_string_name signal, Godot.NativeInterop.NativeVariantPtrArgs args)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public [async] System.Threading.Tasks.Task TravelToMapCoord(MegaCrit.Sts2.Core.Map.MapCoord coord)
public MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawings get_Drawings()
public MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapScreen Open(System.Boolean isOpenedFromTopBar = False)
public static MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapScreen get_Instance()
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Boolean get_IsDebugTravelEnabled()
public System.Boolean get_IsOpen()
public System.Boolean get_IsTravelEnabled()
public System.Boolean get_IsTraveling()
public System.Boolean IsNodeOnScreen(MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapPoint mapPoint)
public System.Collections.Generic.Dictionary<MegaCrit.Sts2.Core.Entities.Players.Player, System.Nullable<MegaCrit.Sts2.Core.Map.MapCoord>> get_PlayerVoteDictionary()
public System.Void add_Closed(MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapScreen+ClosedEventHandler value)
public System.Void add_Opened(MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapScreen+OpenedEventHandler value)
public System.Void add_PointTypeHighlighted(System.Action<MegaCrit.Sts2.Core.Map.MapPointType> value)
public System.Void CleanUp()
public System.Void Close(System.Boolean animateOut = True)
public System.Void HighlightPointType(MegaCrit.Sts2.Core.Map.MapPointType pointType)
public System.Void Initialize(MegaCrit.Sts2.Core.Runs.RunState runState)
public System.Void InitMarker(MegaCrit.Sts2.Core.Map.MapCoord coord)
public System.Void OnMapPointSelectedLocally(MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapPoint point)
public System.Void PingMapCoord(MegaCrit.Sts2.Core.Map.MapCoord coord, MegaCrit.Sts2.Core.Entities.Players.Player player)
public System.Void RefreshAllMapPointVotes()
public System.Void RefreshAllPointVisuals()
public System.Void remove_Closed(MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapScreen+ClosedEventHandler value)
public System.Void remove_Opened(MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapScreen+OpenedEventHandler value)
public System.Void remove_PointTypeHighlighted(System.Action<MegaCrit.Sts2.Core.Map.MapPointType> value)
public System.Void set_IsTraveling(System.Boolean value)
public System.Void SetDebugTravelEnabled(System.Boolean enabled)
public System.Void SetMap(MegaCrit.Sts2.Core.Map.ActMap map, System.UInt64 seed, System.Boolean clearDrawings)
public System.Void SetTravelEnabled(System.Boolean enabled)
public virtual Godot.Control get_DefaultFocusedControl()
public virtual Godot.Vector2 GetNetPositionFromScreenPosition(Godot.Vector2 screenPosition)
public virtual Godot.Vector2 GetScreenPositionFromNetPosition(Godot.Vector2 netPosition)
public virtual System.Void _GuiInput(Godot.InputEvent inputEvent)
public virtual System.Void _Input(Godot.InputEvent inputEvent)
public virtual System.Void _Notification(System.Int32 what)
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapScreen+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapScreen+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapPoint, System.Boolean> <>9__123_0
public static System.Func<MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapPoint, System.Boolean> <>9__132_0
public static System.Func<MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapPoint, System.Boolean> <>9__134_1
private static .cctor()
public .ctor()
internal System.Boolean <get_DefaultFocusedControl>b__132_0(MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapPoint n)
internal System.Boolean <OnLegendHotkeyPressed>b__134_1(MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapPoint n)
internal System.Boolean <Open>b__123_0(MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapPoint n)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapScreen+<AnimClose>d__122

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapScreen <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapScreen+<DisableInputVeryBriefly>d__118

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapScreen <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapScreen+<MapFtueCheck>d__114

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapScreen <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapScreen+<StartOfActAnim>d__112

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapScreen <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapScreen+<TravelToMapCoord>d__95

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapScreen <>4__this
private System.Collections.Generic.IEnumerator<Godot.TextureRect> <>7__wrap4
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private System.Threading.Tasks.Task <fadeOutTask>5__3
private MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapPoint <node>5__2
private Godot.TextureRect <tick>5__6
private System.Single <waitPerTick>5__4
public MegaCrit.Sts2.Core.Map.MapCoord coord
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapScreen+ClosedEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapScreen+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+MethodName`。

接口：

```text
public static readonly Godot.StringName _GuiInput
public static readonly Godot.StringName _Input
public static readonly Godot.StringName _Notification
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName CanScroll
public static readonly Godot.StringName CleanUp
public static readonly Godot.StringName Close
public static readonly Godot.StringName GetLineEndpoint
public static readonly Godot.StringName GetMapPositionFromNetPosition
public static readonly Godot.StringName GetNetPositionFromScreenPosition
public static readonly Godot.StringName GetScreenPositionFromNetPosition
public static readonly Godot.StringName HighlightPointType
public static readonly Godot.StringName InitMapPrompt
public static readonly Godot.StringName InitMapVotes
public static readonly Godot.StringName IsNodeOnScreen
public static readonly Godot.StringName OnBackButtonPressed
public static readonly Godot.StringName OnCapstoneChanged
public static readonly Godot.StringName OnClearMapDrawingButtonPressed
public static readonly Godot.StringName OnDrawingToolsHotkeyPressed
public static readonly Godot.StringName OnLegendHotkeyPressed
public static readonly Godot.StringName OnMapDrawingButtonPressed
public static readonly Godot.StringName OnMapErasingButtonPressed
public static readonly Godot.StringName OnMapPointSelectedLocally
public static readonly Godot.StringName OnVisibilityChanged
public static readonly Godot.StringName Open
public static readonly Godot.StringName PlayStartOfActAnimation
public static readonly Godot.StringName ProcessControllerEvent
public static readonly Godot.StringName ProcessMouseDrawingEvent
public static readonly Godot.StringName ProcessMouseEvent
public static readonly Godot.StringName ProcessScrollEvent
public static readonly Godot.StringName RecalculateTravelability
public static readonly Godot.StringName RefreshAllMapPointVotes
public static readonly Godot.StringName RefreshAllPointVisuals
public static readonly Godot.StringName RemoveAllMapPointsAndPaths
public static readonly Godot.StringName SetDebugTravelEnabled
public static readonly Godot.StringName SetInterruptable
public static readonly Godot.StringName SetTravelEnabled
public static readonly Godot.StringName TryCancelStartOfActAnim
public static readonly Godot.StringName UpdateDrawingButtonStates
public static readonly Godot.StringName UpdateHotkeyDisplay
public static readonly Godot.StringName UpdateScrollPosition
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapScreen+OpenedEventHandler

类型属性：`NestedPublic, Sealed`；基类：`System.MulticastDelegate`。

接口：`System.ICloneable`, `System.Runtime.Serialization.ISerializable`

```text
public .ctor(System.Object object, System.IntPtr method)
public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, System.Object object)
public virtual System.Void EndInvoke(System.IAsyncResult result)
public virtual System.Void Invoke()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapScreen+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+PropertyName`。

接口：

```text
public static readonly Godot.StringName _actAnimTween
public static readonly Godot.StringName _backButton
public static readonly Godot.StringName _backstop
public static readonly Godot.StringName _bossPointNode
public static readonly Godot.StringName _canInterruptAnim
public static readonly Godot.StringName _controllerScrollAmount
public static readonly Godot.StringName _distX
public static readonly Godot.StringName _distY
public static readonly Godot.StringName _drawingInput
public static readonly Godot.StringName _drawingTools
public static readonly Godot.StringName _drawingToolsHotkeyIcon
public static readonly Godot.StringName _hasPlayedAnimation
public static readonly Godot.StringName _isDragging
public static readonly Godot.StringName _isInputDisabled
public static readonly Godot.StringName _legendHotkeyIcon
public static readonly Godot.StringName _legendItems
public static readonly Godot.StringName _mapAnimDuration
public static readonly Godot.StringName _mapAnimStartDelay
public static readonly Godot.StringName _mapBgContainer
public static readonly Godot.StringName _mapClearButton
public static readonly Godot.StringName _mapContainer
public static readonly Godot.StringName _mapDrawingButton
public static readonly Godot.StringName _mapErasingButton
public static readonly Godot.StringName _mapLegend
public static readonly Godot.StringName _mapScrollAnimTimer
public static readonly Godot.StringName _marker
public static readonly Godot.StringName _pathsContainer
public static readonly Godot.StringName _points
public static readonly Godot.StringName _promptTween
public static readonly Godot.StringName _secondBossPointNode
public static readonly Godot.StringName _shareButton
public static readonly Godot.StringName _startDragPos
public static readonly Godot.StringName _startingPointNode
public static readonly Godot.StringName _targetDragPos
public static readonly Godot.StringName _tween
public static readonly Godot.StringName DefaultFocusedControl
public static readonly Godot.StringName Drawings
public static readonly Godot.StringName IsDebugTravelEnabled
public static readonly Godot.StringName IsOpen
public static readonly Godot.StringName IsTravelEnabled
public static readonly Godot.StringName IsTraveling
public static readonly Godot.StringName MapLegendX
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapScreen+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Control+SignalName`。

接口：

```text
public static readonly Godot.StringName Closed
public static readonly Godot.StringName Opened
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapShareButton

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton`。

接口：`System.IDisposable`

```text
private static readonly Godot.Color _activeButtonColor
private static readonly Godot.Color _activeLabelColor
private Godot.TextureRect _buttonImage
private MegaCrit.Sts2.Core.HoverTips.HoverTip _hoverTip
private static readonly Godot.Color _inactiveButtonColor
private static readonly Godot.Color _inactiveLabelColor
private MegaCrit.Sts2.addons.mega_text.MegaLabel _label
private Godot.Control _labelContainer
private Godot.Control _mapBgContainer
private Godot.Control _mapContainer
private MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapScreen _mapScreen
private Godot.SubViewport _subViewport
private MegaCrit.Sts2.addons.mega_text.MegaLabel _toast
private Godot.Vector2 _toastPosition
private Godot.Tween _tween
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
internal static System.Void <CopyMapScreenshot>g__Borrow|21_0(Godot.Control node, Godot.Node tempParent, ref MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapShareButton+<>c__DisplayClass21_0  = null)
private [async] System.Threading.Tasks.Task CopyMapScreenshot()
private static [async] System.Threading.Tasks.Task ShowConfirmation(System.String screenshotPath)
private System.Void ShowToast(MegaCrit.Sts2.Core.Localization.LocString locString)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnFocus()
protected virtual System.Void OnRelease()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public System.Boolean IsTakingScreenshot()
public System.Void Initialize(MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapScreen mapScreen, Godot.Control mapContainer, Godot.Control mapBgContainer)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapShareButton+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapShareButton+<>c <>9
public static System.Func<System.ValueTuple<Godot.Control, Godot.Node, Godot.Node, Godot.Vector2, System.Int32>, System.Int32> <>9__21_1
private static .cctor()
public .ctor()
internal System.Int32 <CopyMapScreenshot>b__21_1(System.ValueTuple<Godot.Control, Godot.Node, Godot.Node, Godot.Vector2, System.Int32> entry)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapShareButton+<>c__DisplayClass21_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：

```text
public System.Collections.Generic.List<System.ValueTuple<Godot.Control, Godot.Node, Godot.Node, Godot.Vector2, System.Int32>> borrowed
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapShareButton+<CopyMapScreenshot>d__21

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapShareButton <>4__this
private MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapShareButton+<>c__DisplayClass21_0 <>8__1
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Single> <>u__1
private System.Object <>u__2
private Godot.Control <debugInfo>5__3
private MegaCrit.Sts2.Core.Nodes.Relics.NRelicInventory <relicInventory>5__4
private Godot.Control <subViewportParent>5__6
private Godot.Control <topBar>5__2
private System.Single <topBarSize>5__5
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapShareButton+<ShowConfirmation>d__22

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter<System.Boolean> <>u__1
public System.String screenshotPath
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapShareButton+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+MethodName`。

接口：

```text
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName Initialize
public static readonly Godot.StringName IsTakingScreenshot
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnRelease
public static readonly Godot.StringName OnUnfocus
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapShareButton+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+PropertyName`。

接口：

```text
public static readonly Godot.StringName _buttonImage
public static readonly Godot.StringName _label
public static readonly Godot.StringName _labelContainer
public static readonly Godot.StringName _mapBgContainer
public static readonly Godot.StringName _mapContainer
public static readonly Godot.StringName _mapScreen
public static readonly Godot.StringName _subViewport
public static readonly Godot.StringName _toast
public static readonly Godot.StringName _toastPosition
public static readonly Godot.StringName _tween
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapShareButton+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.GodotExtensions.NButton+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMouseHeldMapDrawingInput

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawingInput`。

接口：`System.IDisposable`

```text
Godot.MouseButton ListeningButton { private get; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private Godot.MouseButton get_ListeningButton()
private System.Void ProcessMouseDrawingEvent(Godot.InputEvent inputEvent)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Input(Godot.InputEvent inputEvent)
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMouseHeldMapDrawingInput+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawingInput+MethodName`。

接口：

```text
public static readonly Godot.StringName _Input
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName ProcessMouseDrawingEvent
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMouseHeldMapDrawingInput+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawingInput+PropertyName`。

接口：

```text
public static readonly Godot.StringName ListeningButton
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMouseHeldMapDrawingInput+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawingInput+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMouseModeMapDrawingInput

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawingInput`。

接口：`System.IDisposable`

```text
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
private System.Void ProcessMouseDrawingEvent(Godot.InputEvent inputEvent)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public virtual System.Void _Input(Godot.InputEvent inputEvent)
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMouseModeMapDrawingInput+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawingInput+MethodName`。

接口：

```text
public static readonly Godot.StringName _Input
public static readonly Godot.StringName ProcessMouseDrawingEvent
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMouseModeMapDrawingInput+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawingInput+PropertyName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NMouseModeMapDrawingInput+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapDrawingInput+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NNormalMapPoint

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapPoint`。

接口：`System.IDisposable`

```text
private MegaCrit.Sts2.Core.Nodes.Vfx.NMapCircleVfx _circleVfx
private System.Single _elapsedTime
private Godot.TextureRect _icon
private Godot.Control _iconContainer
private static readonly Godot.StringName _mapColor
private Godot.TextureRect _outline
private static const System.Single _pulseSpeed = 4
private Godot.Tween _pulseTween
private Godot.TextureRect _questIcon
private static const System.Single _scaleAmount = 0.25
private static const System.Single _scaleBase = 1.2
private Godot.Tween _tween
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
Godot.Vector2 DownScale { protected virtual get; }
Godot.Color HoveredColor { protected virtual get; }
Godot.Vector2 HoverScale { protected virtual get; }
System.String ScenePath { private static get; }
Godot.Color TraveledColor { protected virtual get; }
Godot.Color UntravelableColor { protected virtual get; }
private static .cctor()
public .ctor()
internal static System.Boolean InvokeGodotClassStaticMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private static System.String get_ScenePath()
private static System.String IconName(MegaCrit.Sts2.Core.Map.MapPointType pointType)
private static System.String IconPath(System.String filename)
private static System.String OutlinePath(System.String filename)
private static System.String UnknownIconPath(MegaCrit.Sts2.Core.Rooms.RoomType pointType)
private static System.String UnknownOutlinePath(MegaCrit.Sts2.Core.Rooms.RoomType pointType)
private System.Void AnimHover()
private System.Void AnimPressDown()
private System.Void AnimUnhover()
private System.Void OnHighlightPointType(MegaCrit.Sts2.Core.Map.MapPointType pointType)
private System.Void RefreshMarkedIconVisibility()
private System.Void ShowCircleVfx(System.Boolean playAnim)
private System.Void UpdateIcon()
protected virtual Godot.Color get_HoveredColor()
protected virtual Godot.Color get_TraveledColor()
protected virtual Godot.Color get_UntravelableColor()
protected virtual Godot.Vector2 get_DownScale()
protected virtual Godot.Vector2 get_HoverScale()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void OnFocus()
protected virtual System.Void OnPress()
protected virtual System.Void OnUnfocus()
protected virtual System.Void RefreshColorInstantly()
protected virtual System.Void RefreshState()
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Screens.Map.NNormalMapPoint Create(MegaCrit.Sts2.Core.Map.MapPoint point, MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapScreen screen, MegaCrit.Sts2.Core.Runs.IRunState runState)
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public System.Void SetAngle(System.Single degrees)
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Process(System.Double delta)
public virtual System.Void _Ready()
public virtual System.Void OnSelected()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NNormalMapPoint+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapPoint+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Process
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName AnimHover
public static readonly Godot.StringName AnimPressDown
public static readonly Godot.StringName AnimUnhover
public static readonly Godot.StringName IconName
public static readonly Godot.StringName IconPath
public static readonly Godot.StringName OnFocus
public static readonly Godot.StringName OnHighlightPointType
public static readonly Godot.StringName OnPress
public static readonly Godot.StringName OnSelected
public static readonly Godot.StringName OnUnfocus
public static readonly Godot.StringName OutlinePath
public static readonly Godot.StringName RefreshColorInstantly
public static readonly Godot.StringName RefreshMarkedIconVisibility
public static readonly Godot.StringName RefreshState
public static readonly Godot.StringName SetAngle
public static readonly Godot.StringName ShowCircleVfx
public static readonly Godot.StringName UnknownIconPath
public static readonly Godot.StringName UnknownOutlinePath
public static readonly Godot.StringName UpdateIcon
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NNormalMapPoint+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapPoint+PropertyName`。

接口：

```text
public static readonly Godot.StringName _circleVfx
public static readonly Godot.StringName _elapsedTime
public static readonly Godot.StringName _icon
public static readonly Godot.StringName _iconContainer
public static readonly Godot.StringName _outline
public static readonly Godot.StringName _pulseTween
public static readonly Godot.StringName _questIcon
public static readonly Godot.StringName _tween
public static readonly Godot.StringName DownScale
public static readonly Godot.StringName HoveredColor
public static readonly Godot.StringName HoverScale
public static readonly Godot.StringName TraveledColor
public static readonly Godot.StringName UntravelableColor
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Screens.Map.NNormalMapPoint+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Nodes.Screens.Map.NMapPoint+SignalName`。

接口：

```text
public .ctor()
```
