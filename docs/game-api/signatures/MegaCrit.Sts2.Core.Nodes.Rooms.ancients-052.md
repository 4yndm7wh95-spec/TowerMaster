# MegaCrit.Sts2.Core.Nodes.Rooms

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.Rooms.NEventRoom

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Control`。

接口：`System.IDisposable`, `MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext`

```text
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Events.EventOption> _connectedOptions
private readonly System.Threading.CancellationTokenSource _cts
private MegaCrit.Sts2.Core.Models.EventModel _event
private MegaCrit.Sts2.Core.Nodes.NSceneContainer _eventContainer
private System.Boolean _isPreFinished
private MegaCrit.Sts2.Core.Runs.IRunState _runState
private static const System.String _scenePath = "res://scenes/rooms/event_room.tscn"
private Godot.Control <VfxContainer>k__BackingField
System.Collections.Generic.IEnumerable<System.String> AssetPaths { public static get; }
MegaCrit.Sts2.Core.Nodes.Events.ICustomEventNode CustomEventNode { public get; }
Godot.Control DefaultFocusedControl { public virtual get; }
MegaCrit.Sts2.Core.Nodes.Rooms.NCombatRoom EmbeddedCombatRoom { public get; }
MegaCrit.Sts2.Core.Nodes.Rooms.NEventRoom Instance { public static get; }
MegaCrit.Sts2.Core.Nodes.Events.NEventLayout Layout { public get; }
Godot.Control VfxContainer { public get; private set; }
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private [async] System.Threading.Tasks.Task BeforeOptionChosen(MegaCrit.Sts2.Core.Events.EventOption option)
private [async] System.Threading.Tasks.Task SetupLayout()
private MegaCrit.Sts2.Core.Localization.LocString GetDescriptionOrFallback()
private System.Void DisableOptionButtons()
private System.Void OnActiveScreenUpdated()
private System.Void OnEnteringEventCombat()
private System.Void RefreshEventState(MegaCrit.Sts2.Core.Models.EventModel eventModel)
private System.Void set_VfxContainer(Godot.Control value)
private System.Void SetDescription(MegaCrit.Sts2.Core.Localization.LocString description)
private System.Void SetOptions(MegaCrit.Sts2.Core.Models.EventModel eventModel)
private System.Void SetTitle(MegaCrit.Sts2.Core.Localization.LocString title)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public Godot.Control get_VfxContainer()
public MegaCrit.Sts2.Core.Nodes.Events.ICustomEventNode get_CustomEventNode()
public MegaCrit.Sts2.Core.Nodes.Events.NEventLayout get_Layout()
public MegaCrit.Sts2.Core.Nodes.Rooms.NCombatRoom get_EmbeddedCombatRoom()
public static MegaCrit.Sts2.Core.Nodes.Rooms.NEventRoom Create(MegaCrit.Sts2.Core.Models.EventModel eventModel, MegaCrit.Sts2.Core.Runs.IRunState runState, System.Boolean isPreFinished)
public static MegaCrit.Sts2.Core.Nodes.Rooms.NEventRoom get_Instance()
public static System.Collections.Generic.IEnumerable<System.String> get_AssetPaths()
public static System.Threading.Tasks.Task Proceed()
public System.Void OptionButtonClicked(MegaCrit.Sts2.Core.Events.EventOption option, System.Int32 index)
public System.Void SetPortrait(Godot.Texture2D portrait)
public virtual Godot.Control get_DefaultFocusedControl()
public virtual System.Void _EnterTree()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```
