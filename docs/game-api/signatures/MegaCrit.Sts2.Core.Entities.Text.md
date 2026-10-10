# MegaCrit.Sts2.Core.Entities.Text

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Entities.Text.BbcodeObject

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：`System.IEquatable<MegaCrit.Sts2.Core.Entities.Text.BbcodeObject>`

```text
public System.String tag
public System.String text
public MegaCrit.Sts2.Core.Entities.Text.BbcodeObjectType type
System.Type EqualityContract { protected virtual get; }
protected .ctor(MegaCrit.Sts2.Core.Entities.Text.BbcodeObject original)
public .ctor()
protected virtual System.Boolean PrintMembers(System.Text.StringBuilder builder)
protected virtual System.Type get_EqualityContract()
public static System.Boolean op_Equality(MegaCrit.Sts2.Core.Entities.Text.BbcodeObject left, MegaCrit.Sts2.Core.Entities.Text.BbcodeObject right)
public static System.Boolean op_Inequality(MegaCrit.Sts2.Core.Entities.Text.BbcodeObject left, MegaCrit.Sts2.Core.Entities.Text.BbcodeObject right)
public virtual MegaCrit.Sts2.Core.Entities.Text.BbcodeObject <Clone>$()
public virtual System.Boolean Equals(MegaCrit.Sts2.Core.Entities.Text.BbcodeObject other)
public virtual System.Boolean Equals(System.Object obj)
public virtual System.Int32 GetHashCode()
public virtual System.String ToString()
```

## MegaCrit.Sts2.Core.Entities.Text.BbcodeObjectType

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Entities.Text.BbcodeObjectType BeginTag = 1
public static const MegaCrit.Sts2.Core.Entities.Text.BbcodeObjectType EndTag = 2
public static const MegaCrit.Sts2.Core.Entities.Text.BbcodeObjectType Text = 0
public System.Int32 value__
```
