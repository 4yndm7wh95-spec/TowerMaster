# MegaCrit.Sts2.Core.Nodes.Audio

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.Audio.ActBankLoadRetry

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static const System.Int32 maxAttempts = 3
public static const System.Int32 retryDelayMs = 50
private static System.Void ReportToSentry(System.String bankPath, MegaCrit.Sts2.Core.Nodes.Audio.ActBankLoadRetry+LoadOutcome outcome)
public static System.Boolean Run(System.String bankPath, System.Func<System.Boolean> loadAttempt, System.Action<System.Int32> sleep = null, System.Action<System.String, MegaCrit.Sts2.Core.Nodes.Audio.ActBankLoadRetry+LoadOutcome> report = null)
```

## MegaCrit.Sts2.Core.Nodes.Audio.ActBankLoadRetry+<>c__DisplayClass4_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.String bankPath
public MegaCrit.Sts2.Core.Nodes.Audio.ActBankLoadRetry+LoadOutcome outcome
public System.String result
public .ctor()
internal System.Void <ReportToSentry>b__0(Sentry.Scope scope)
```

## MegaCrit.Sts2.Core.Nodes.Audio.ActBankLoadRetry+<>O

类型属性：`NestedPrivate, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static System.Action<System.Int32> <0>__Sleep
public static System.Action<System.String, MegaCrit.Sts2.Core.Nodes.Audio.ActBankLoadRetry+LoadOutcome> <1>__ReportToSentry
```

## MegaCrit.Sts2.Core.Nodes.Audio.ActBankLoadRetry+LoadOutcome

类型属性：`NestedPublic, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.IEquatable<MegaCrit.Sts2.Core.Nodes.Audio.ActBankLoadRetry+LoadOutcome>`

```text
private readonly System.Int32 <Attempts>k__BackingField
private readonly System.Boolean <Loaded>k__BackingField
System.Int32 Attempts { public get; public set; }
System.Boolean Loaded { public get; public set; }
public .ctor(System.Boolean Loaded, System.Int32 Attempts)
private System.Boolean PrintMembers(System.Text.StringBuilder builder)
public static System.Boolean op_Equality(MegaCrit.Sts2.Core.Nodes.Audio.ActBankLoadRetry+LoadOutcome left, MegaCrit.Sts2.Core.Nodes.Audio.ActBankLoadRetry+LoadOutcome right)
public static System.Boolean op_Inequality(MegaCrit.Sts2.Core.Nodes.Audio.ActBankLoadRetry+LoadOutcome left, MegaCrit.Sts2.Core.Nodes.Audio.ActBankLoadRetry+LoadOutcome right)
public System.Boolean get_Loaded()
public System.Int32 get_Attempts()
public System.Void Deconstruct(out System.Boolean Loaded, out System.Int32 Attempts)
public System.Void set_Attempts(System.Int32 value)
public System.Void set_Loaded(System.Boolean value)
public virtual System.Boolean Equals(MegaCrit.Sts2.Core.Nodes.Audio.ActBankLoadRetry+LoadOutcome other)
public virtual System.Boolean Equals(System.Object obj)
public virtual System.Int32 GetHashCode()
public virtual System.String ToString()
```

## MegaCrit.Sts2.Core.Nodes.Audio.NAudioManager

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private Godot.Node _audioNode
private static readonly Godot.StringName _playLoop
private static readonly Godot.StringName _playMusic
private static readonly Godot.StringName _playOneShot
private static readonly Godot.StringName _setAmbienceVolume
private static readonly Godot.StringName _setBgmVolume
private static readonly Godot.StringName _setMasterVolume
private static readonly Godot.StringName _setParam
private static readonly Godot.StringName _setSfxVolume
private static readonly Godot.StringName _stopAllLoops
private static readonly Godot.StringName _stopLoop
private static readonly Godot.StringName _stopMusic
private static readonly Godot.StringName _updateMusicParameterCallback
MegaCrit.Sts2.Core.Nodes.Audio.NAudioManager Instance { public static get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Audio.NAudioManager get_Instance()
public System.Void PlayLoop(System.String path, System.Boolean usesLoopParam)
public System.Void PlayMusic(System.String music)
public System.Void PlayOneShot(System.String path, System.Collections.Generic.Dictionary<System.String, System.Single> parameters, System.Single volume = 1)
public System.Void PlayOneShot(System.String path, System.Single volume = 1)
public System.Void SetAmbienceVol(System.Single volume)
public System.Void SetBgmVol(System.Single volume)
public System.Void SetMasterVol(System.Single volume)
public System.Void SetParam(System.String path, System.String param, System.Single value)
public System.Void SetSfxVol(System.Single volume)
public System.Void StopAllLoops()
public System.Void StopLoop(System.String path)
public System.Void StopMusic()
public System.Void UpdateMusicParameter(System.String parameter, System.String value)
public virtual System.Void _EnterTree()
```

## MegaCrit.Sts2.Core.Nodes.Audio.NAudioManager+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _EnterTree
public static readonly Godot.StringName PlayLoop
public static readonly Godot.StringName PlayMusic
public static readonly Godot.StringName PlayOneShot
public static readonly Godot.StringName SetAmbienceVol
public static readonly Godot.StringName SetBgmVol
public static readonly Godot.StringName SetMasterVol
public static readonly Godot.StringName SetParam
public static readonly Godot.StringName SetSfxVol
public static readonly Godot.StringName StopAllLoops
public static readonly Godot.StringName StopLoop
public static readonly Godot.StringName StopMusic
public static readonly Godot.StringName UpdateMusicParameter
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Audio.NAudioManager+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _audioNode
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Audio.NAudioManager+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController

类型属性：`Public, BeforeFieldInit`；基类：`Godot.Node`。

接口：`System.IDisposable`

```text
private static const System.String _bgMusicRngName = "bg_music"
private System.String _currentAmbience
private System.String _currentTrack
private System.String _failedTrack
private static const System.String _loadActBankCallback = "load_act_bank"
private static const System.String _musicProgressParameter = "Progress"
private Godot.Node _proxy
private MegaCrit.Sts2.Core.Runs.IRunState _runState
private static readonly Godot.StringName _stopAmbience
private static readonly Godot.StringName _stopMusic
private static const System.String _unloadActBanksCallback = "unload_act_banks"
private static const System.String _updateAmbienceCallback = "update_ambience"
private static const System.String _updateCampfireAmbienceCallback = "update_campfire_ambience"
private static const System.String _updateCustomTrack = "update_custom_track"
private static const System.String _updateGlobalParameterCallback = "update_global_parameter"
private static const System.String _updateMusicCallback = "update_music"
private static const System.String _updateMusicParameterCallback = "update_music_parameter"
MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController Instance { public static get; }
private static .cctor()
public .ctor()
internal static System.Collections.Generic.List<Godot.Bridge.MethodInfo> GetGodotMethodList()
internal static System.Collections.Generic.List<Godot.Bridge.PropertyInfo> GetGodotPropertyList()
private MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController+MusicProgressTrack GetTrack(MegaCrit.Sts2.Core.Rooms.RoomType roomType)
private System.Boolean LoadActBank(System.String bankPath, System.String verifyEvent)
private System.Void UnloadActBanks()
private System.Void UpdateTrack(System.String label, System.Single trackIndex)
protected virtual System.Boolean GetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, out Godot.NativeInterop.godot_variant value)
protected virtual System.Boolean HasGodotClassMethod(in Godot.NativeInterop.godot_string_name method)
protected virtual System.Boolean InvokeGodotClassMethod(in Godot.NativeInterop.godot_string_name method, Godot.NativeInterop.NativeVariantPtrArgs args, out Godot.NativeInterop.godot_variant ret)
protected virtual System.Boolean SetGodotClassPropertyValue(in Godot.NativeInterop.godot_string_name name, in Godot.NativeInterop.godot_variant value)
protected virtual System.Void RestoreGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
protected virtual System.Void SaveGodotObjectData(Godot.Bridge.GodotSerializationInfo info)
public static MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController get_Instance()
public static System.Nullable<MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController+MusicSelection> ResolveMusic(System.String currentTrack, System.String[] options, System.String[] bankPaths, System.UInt64 seed)
public System.Void PlayCustomMusic(System.String customMusic)
public System.Void SetRunState(MegaCrit.Sts2.Core.Runs.IRunState runState)
public System.Void StopCustomMusic()
public System.Void StopMusic()
public System.Void ToggleMerchantTrack()
public System.Void TriggerCampfireGoingOut()
public System.Void TriggerEliteSecondPhase()
public System.Void UpdateAmbience()
public System.Void UpdateCustomTrack(System.String customTrack, System.Single label)
public System.Void UpdateMusic()
public System.Void UpdateMusicParameter(System.String label, System.Single trackIndex)
public System.Void UpdateTrack()
public virtual System.Void _ExitTree()
public virtual System.Void _Ready()
```

## MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController+<>c__DisplayClass39_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController <>4__this
public System.String bankPath
public System.String verifyEvent
public .ctor()
internal System.Boolean <LoadActBank>b__0()
```

## MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController+CampfireState

类型属性：`NestedPrivate, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController+CampfireState Off = 1
public static const MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController+CampfireState On = 0
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController+MethodName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+MethodName`。

接口：

```text
public static readonly Godot.StringName _ExitTree
public static readonly Godot.StringName _Ready
public static readonly Godot.StringName GetTrack
public static readonly Godot.StringName LoadActBank
public static readonly Godot.StringName PlayCustomMusic
public static readonly Godot.StringName StopCustomMusic
public static readonly Godot.StringName StopMusic
public static readonly Godot.StringName ToggleMerchantTrack
public static readonly Godot.StringName TriggerCampfireGoingOut
public static readonly Godot.StringName TriggerEliteSecondPhase
public static readonly Godot.StringName UnloadActBanks
public static readonly Godot.StringName UpdateAmbience
public static readonly Godot.StringName UpdateCustomTrack
public static readonly Godot.StringName UpdateMusic
public static readonly Godot.StringName UpdateMusicParameter
public static readonly Godot.StringName UpdateTrack
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController+MusicProgressTrack

类型属性：`NestedPrivate, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController+MusicProgressTrack CombatEnd = 7
public static const MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController+MusicProgressTrack Elite = 6
public static const MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController+MusicProgressTrack Elite2 = 8
public static const MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController+MusicProgressTrack Enemy = 1
public static const MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController+MusicProgressTrack Init = 0
public static const MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController+MusicProgressTrack Merchant = 2
public static const MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController+MusicProgressTrack MerchantEnd = 9
public static const MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController+MusicProgressTrack Rest = 3
public static const MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController+MusicProgressTrack Treasure = 5
public static const MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController+MusicProgressTrack Unknown = 4
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController+MusicSelection

类型属性：`NestedPublic, SequentialLayout, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.IEquatable<MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController+MusicSelection>`

```text
private readonly System.String <BankPath>k__BackingField
private readonly System.String <Track>k__BackingField
System.String BankPath { public get; public set; }
System.String Track { public get; public set; }
public .ctor(System.String Track, System.String BankPath)
private System.Boolean PrintMembers(System.Text.StringBuilder builder)
public static System.Boolean op_Equality(MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController+MusicSelection left, MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController+MusicSelection right)
public static System.Boolean op_Inequality(MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController+MusicSelection left, MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController+MusicSelection right)
public System.String get_BankPath()
public System.String get_Track()
public System.Void Deconstruct(out System.String Track, out System.String BankPath)
public System.Void set_BankPath(System.String value)
public System.Void set_Track(System.String value)
public virtual System.Boolean Equals(MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController+MusicSelection other)
public virtual System.Boolean Equals(System.Object obj)
public virtual System.Int32 GetHashCode()
public virtual System.String ToString()
```

## MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController+PropertyName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+PropertyName`。

接口：

```text
public static readonly Godot.StringName _currentAmbience
public static readonly Godot.StringName _currentTrack
public static readonly Godot.StringName _failedTrack
public static readonly Godot.StringName _proxy
private static .cctor()
public .ctor()
```

## MegaCrit.Sts2.Core.Nodes.Audio.NRunMusicController+SignalName

类型属性：`NestedPublic, BeforeFieldInit`；基类：`Godot.Node+SignalName`。

接口：

```text
public .ctor()
```
