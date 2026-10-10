# MegaCrit.Sts2.Core.Nodes.Pooling

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.Pooling.INodePool

类型属性：`Public, ClassSemanticsMask, Abstract, BeforeFieldInit`；基类：`无`。

接口：

```text
public abstract MegaCrit.Sts2.Core.Nodes.Pooling.IPoolable Get()
public abstract System.Void Free(MegaCrit.Sts2.Core.Nodes.Pooling.IPoolable poolable)
```

## MegaCrit.Sts2.Core.Nodes.Pooling.IPoolable

类型属性：`Public, ClassSemanticsMask, Abstract, BeforeFieldInit`；基类：`无`。

接口：

```text
public abstract System.Void OnFreedToPool()
public abstract System.Void OnInstantiated()
public abstract System.Void OnReturnedFromPool()
```

## MegaCrit.Sts2.Core.Nodes.Pooling.NodePool

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static System.Collections.Generic.Dictionary<System.Type, MegaCrit.Sts2.Core.Nodes.Pooling.INodePool> _pools
private static .cctor()
public .ctor()
public static MegaCrit.Sts2.Core.Nodes.Pooling.IPoolable Get(System.Type type)
public static MegaCrit.Sts2.Core.Nodes.Pooling.NodePool<T> Init<T>(System.String scenePath, System.Int32 prewarmCount) where T: [None] Godot.Node, MegaCrit.Sts2.Core.Nodes.Pooling.IPoolable
public static System.Void Free(MegaCrit.Sts2.Core.Nodes.Pooling.IPoolable poolable)
public static System.Void Free<T>(T obj) where T: [None] Godot.Node, MegaCrit.Sts2.Core.Nodes.Pooling.IPoolable
public static T Get<T>() where T: [None] Godot.Node, MegaCrit.Sts2.Core.Nodes.Pooling.IPoolable
```

## MegaCrit.Sts2.Core.Nodes.Pooling.NodePool<T>

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：`MegaCrit.Sts2.Core.Nodes.Pooling.INodePool`

```text
private static Godot.Variant _callableStr
private readonly System.Collections.Generic.List<T> _freeObjects
private static Godot.Variant _nameStr
private System.String _scenePath
private static Godot.Variant _signalStr
private readonly System.Collections.Generic.HashSet<T> _usedObjects
System.Collections.Generic.IReadOnlyList<T> DebugFreeObjects { public get; }
private static .cctor()
public .ctor(System.String scenePath, System.Int32 prewarmCount = 0)
private System.Void DisconnectIncomingAndOutgoingSignals(Godot.Node obj)
private System.Void DisconnectSignal(Godot.Callable callable, Godot.Signal signal)
private T Instantiate()
private virtual MegaCrit.Sts2.Core.Nodes.Pooling.IPoolable MegaCrit.Sts2.Core.Nodes.Pooling.INodePool.Get()
private virtual System.Void MegaCrit.Sts2.Core.Nodes.Pooling.INodePool.Free(MegaCrit.Sts2.Core.Nodes.Pooling.IPoolable poolable)
public System.Collections.Generic.IReadOnlyList<T> get_DebugFreeObjects()
public System.Void Free(T obj)
public T Get()
```
