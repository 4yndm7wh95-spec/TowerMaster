# MegaCrit.Sts2.Core.Entities.Orbs

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Entities.Orbs.OrbQueue

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.OrbModel> _orbs
private readonly MegaCrit.Sts2.Core.Entities.Players.Player _owner
private System.Int32 <Capacity>k__BackingField
public static const System.Int32 maxCapacity = 10
System.Int32 Capacity { public get; private set; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.OrbModel> Orbs { public get; }
public .ctor(MegaCrit.Sts2.Core.Entities.Players.Player owner)
private [async] System.Threading.Tasks.Task SmallWait()
private System.Void set_Capacity(System.Int32 value)
public [async] System.Threading.Tasks.Task AfterTurnStart(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext)
public [async] System.Threading.Tasks.Task BeforeTurnEnd(MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext)
public [async] System.Threading.Tasks.Task<System.Boolean> TryEnqueue(MegaCrit.Sts2.Core.Models.OrbModel orb)
public System.Boolean Remove(MegaCrit.Sts2.Core.Models.OrbModel orb)
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.OrbModel> get_Orbs()
public System.Int32 get_Capacity()
public System.Void AddCapacity(System.Int32 capacity)
public System.Void Clear()
public System.Void Insert(System.Int32 idx, MegaCrit.Sts2.Core.Models.OrbModel orb)
public System.Void RemoveCapacity(System.Int32 capacity)
```

## MegaCrit.Sts2.Core.Entities.Orbs.OrbQueue+<AfterTurnStart>d__17

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Entities.Orbs.OrbQueue <>4__this
private System.Collections.Generic.List+Enumerator<MegaCrit.Sts2.Core.Models.OrbModel> <>7__wrap1
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Entities.Orbs.OrbQueue+<BeforeTurnEnd>d__16

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Entities.Orbs.OrbQueue <>4__this
private System.Collections.Generic.List+Enumerator<MegaCrit.Sts2.Core.Models.OrbModel> <>7__wrap1
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.GameActions.Multiplayer.PlayerChoiceContext choiceContext
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Entities.Orbs.OrbQueue+<SmallWait>d__18

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Entities.Orbs.OrbQueue <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```

## MegaCrit.Sts2.Core.Entities.Orbs.OrbQueue+<TryEnqueue>d__13

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.Runtime.CompilerServices.IAsyncStateMachine`

```text
public System.Int32 <>1__state
public MegaCrit.Sts2.Core.Entities.Orbs.OrbQueue <>4__this
public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Boolean> <>t__builder
private System.Runtime.CompilerServices.TaskAwaiter <>u__1
public MegaCrit.Sts2.Core.Models.OrbModel orb
private virtual System.Void MoveNext()
private virtual System.Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
```
