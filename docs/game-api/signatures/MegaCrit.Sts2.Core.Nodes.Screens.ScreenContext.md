# MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.ActiveScreenContext

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.ActiveScreenContext _instance
private System.Action Updated
MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.ActiveScreenContext Instance { public static get; }
event System.Action Updated
public .ctor()
public MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext GetCurrentScreen()
public static MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.ActiveScreenContext get_Instance()
public System.Boolean IsCurrent(MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext screen)
public System.Void add_Updated(System.Action value)
public System.Void FocusOnDefaultControl()
public System.Void remove_Updated(System.Action value)
public System.Void Update()
```

## MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext

类型属性：`Public, ClassSemanticsMask, Abstract, BeforeFieldInit`；基类：`无`。

接口：

```text
Godot.Control DefaultFocusedControl { public abstract get; }
Godot.Control FocusedControlFromTopBar { public virtual get; }
public abstract Godot.Control get_DefaultFocusedControl()
public virtual Godot.Control get_FocusedControlFromTopBar()
```

## MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.ScreenContextUtils

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static System.Void UpdateControllerNavEnabled<T>(T screenContext) where T: [None] Godot.Control, MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext.IScreenContext
```
