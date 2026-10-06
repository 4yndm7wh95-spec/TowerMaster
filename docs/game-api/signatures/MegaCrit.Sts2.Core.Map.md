# MegaCrit.Sts2.Core.Map

游戏 v0.111.0；程序集 sts2, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null；SHA256 `0861BFA1DF347538D932F22D580E75420F08082792EB914E53B4882764ACDBE9`。

元数据反射导出，无方法体。仅列每个类型自身声明成员（含编译器生成及非公开）；继承成员沿基类/接口检索，属性访问器也列于方法。`[async]` 来自 AsyncStateMachineAttribute；Task 返回不必然有该标记。可空注解原始特性不在此表重建。枚举默认参数可能显示底层数字，枚举字段列出所有具名值。

## MegaCrit.Sts2.Core.Map.ActMap

类型属性：`Public, Abstract, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public readonly System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Map.MapPoint> startMapPoints
MegaCrit.Sts2.Core.Map.MapPoint BossMapPoint { public abstract get; }
MegaCrit.Sts2.Core.Map.MapPoint[,] Grid { protected abstract get; }
MegaCrit.Sts2.Core.Map.MapPoint SecondBossMapPoint { public virtual get; }
MegaCrit.Sts2.Core.Map.MapPoint StartingMapPoint { public abstract get; }
protected .ctor()
protected abstract MegaCrit.Sts2.Core.Map.MapPoint[,] get_Grid()
public abstract MegaCrit.Sts2.Core.Map.MapPoint get_BossMapPoint()
public abstract MegaCrit.Sts2.Core.Map.MapPoint get_StartingMapPoint()
public MegaCrit.Sts2.Core.Map.MapPoint GetPoint(System.Int32 col, System.Int32 row)
public System.Boolean HasPoint(MegaCrit.Sts2.Core.Map.MapCoord coord)
public System.Boolean IsInMap(MegaCrit.Sts2.Core.Map.MapPoint mapPoint)
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Map.MapPoint> GetAllMapPoints()
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Map.MapPoint> GetPointsInRow(System.Int32 row)
public System.Int32 GetColumnCount()
public System.Int32 GetRowCount()
public virtual MegaCrit.Sts2.Core.Map.MapPoint get_SecondBossMapPoint()
public virtual MegaCrit.Sts2.Core.Map.MapPoint GetPoint(MegaCrit.Sts2.Core.Map.MapCoord coord)
```

## MegaCrit.Sts2.Core.Map.ActMap+<GetAllMapPoints>d__11

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：`System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Map.MapPoint>`, `System.Collections.IEnumerable`, `System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Map.MapPoint>`, `System.Collections.IEnumerator`, `System.IDisposable`

```text
private System.Int32 <>1__state
private MegaCrit.Sts2.Core.Map.MapPoint <>2__current
public MegaCrit.Sts2.Core.Map.ActMap <>4__this
private System.Int32 <>l__initialThreadId
private System.Int32 <c>5__2
private System.Int32 <r>5__3
MegaCrit.Sts2.Core.Map.MapPoint System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Map.MapPoint>.Current { private virtual get; }
System.Object System.Collections.IEnumerator.Current { private virtual get; }
public .ctor(System.Int32 <>1__state)
private virtual MegaCrit.Sts2.Core.Map.MapPoint System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Map.MapPoint>.get_Current()
private virtual System.Boolean MoveNext()
private virtual System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Map.MapPoint> System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Map.MapPoint>.GetEnumerator()
private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
private virtual System.Object System.Collections.IEnumerator.get_Current()
private virtual System.Void System.Collections.IEnumerator.Reset()
private virtual System.Void System.IDisposable.Dispose()
```

## MegaCrit.Sts2.Core.Map.ActMap+<GetPointsInRow>d__12

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：`System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Map.MapPoint>`, `System.Collections.IEnumerable`, `System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Map.MapPoint>`, `System.Collections.IEnumerator`, `System.IDisposable`

```text
private System.Int32 <>1__state
private MegaCrit.Sts2.Core.Map.MapPoint <>2__current
public System.Int32 <>3__row
public MegaCrit.Sts2.Core.Map.ActMap <>4__this
private System.Int32 <>l__initialThreadId
private System.Int32 <c>5__2
private System.Int32 row
MegaCrit.Sts2.Core.Map.MapPoint System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Map.MapPoint>.Current { private virtual get; }
System.Object System.Collections.IEnumerator.Current { private virtual get; }
public .ctor(System.Int32 <>1__state)
private virtual MegaCrit.Sts2.Core.Map.MapPoint System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Map.MapPoint>.get_Current()
private virtual System.Boolean MoveNext()
private virtual System.Collections.Generic.IEnumerator<MegaCrit.Sts2.Core.Map.MapPoint> System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Map.MapPoint>.GetEnumerator()
private virtual System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
private virtual System.Object System.Collections.IEnumerator.get_Current()
private virtual System.Void System.Collections.IEnumerator.Reset()
private virtual System.Void System.IDisposable.Dispose()
```

## MegaCrit.Sts2.Core.Map.GoldenPathActMap

类型属性：`Public, Sealed, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Map.ActMap`。

接口：

```text
private readonly MegaCrit.Sts2.Core.Map.MapPointType[] _defaultPointTypes
private static const System.Int32 _middle = 3
private static const System.Int32 _width = 7
private readonly MegaCrit.Sts2.Core.Map.MapPoint <BossMapPoint>k__BackingField
private readonly MegaCrit.Sts2.Core.Map.MapPoint[,] <Grid>k__BackingField
private readonly MegaCrit.Sts2.Core.Map.MapPoint <StartingMapPoint>k__BackingField
MegaCrit.Sts2.Core.Map.MapPoint BossMapPoint { public virtual get; }
MegaCrit.Sts2.Core.Map.MapPoint[,] Grid { protected virtual get; }
MegaCrit.Sts2.Core.Map.MapPoint StartingMapPoint { public virtual get; }
public .ctor(MegaCrit.Sts2.Core.Runs.IRunState runState)
protected virtual MegaCrit.Sts2.Core.Map.MapPoint[,] get_Grid()
public virtual MegaCrit.Sts2.Core.Map.MapPoint get_BossMapPoint()
public virtual MegaCrit.Sts2.Core.Map.MapPoint get_StartingMapPoint()
```

## MegaCrit.Sts2.Core.Map.MapCoord

类型属性：`Public, SequentialLayout, Sealed, Serializable, BeforeFieldInit`；基类：`System.ValueType`。

接口：`System.IEquatable<MegaCrit.Sts2.Core.Map.MapCoord>`, `System.IComparable<MegaCrit.Sts2.Core.Map.MapCoord>`, `MegaCrit.Sts2.Core.Multiplayer.Serialization.IPacketSerializable`

```text
public System.Int32 col
public System.Int32 row
public .ctor(System.Int32 col, System.Int32 row)
public static System.Boolean op_Equality(MegaCrit.Sts2.Core.Map.MapCoord first, MegaCrit.Sts2.Core.Map.MapCoord second)
public static System.Boolean op_Inequality(MegaCrit.Sts2.Core.Map.MapCoord first, MegaCrit.Sts2.Core.Map.MapCoord second)
public virtual System.Boolean Equals(MegaCrit.Sts2.Core.Map.MapCoord other)
public virtual System.Boolean Equals(System.Object obj)
public virtual System.Int32 CompareTo(MegaCrit.Sts2.Core.Map.MapCoord other)
public virtual System.Int32 GetHashCode()
public virtual System.String ToString()
public virtual System.Void Deserialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketReader reader)
public virtual System.Void Serialize(MegaCrit.Sts2.Core.Multiplayer.Serialization.PacketWriter writer)
```

## MegaCrit.Sts2.Core.Map.MapPathPruning

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static System.Boolean AnyOverlappingSegments(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Map.MapPoint[]> existingSegments, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Map.MapPoint> segment)
private static System.Boolean BreakAParentChildRelationshipInAnySegment(System.Collections.Generic.List<MegaCrit.Sts2.Core.Map.MapPoint[]> matches)
private static System.Boolean BreakAParentChildRelationshipInSegment(MegaCrit.Sts2.Core.Map.MapPoint[] segment)
private static System.Boolean IsInMap(MegaCrit.Sts2.Core.Map.MapPoint[,] grid, MegaCrit.Sts2.Core.Map.MapPoint mapPoint)
private static System.Boolean IsRemoved(MegaCrit.Sts2.Core.Map.MapPoint[,] grid, MegaCrit.Sts2.Core.Map.MapPoint mapPoint)
private static System.Boolean IsValidSegmentEndMapPoint(MegaCrit.Sts2.Core.Map.MapPoint endMapPoint)
private static System.Boolean IsValidSegmentStartMapPoint(MegaCrit.Sts2.Core.Map.MapPoint startMapPoint)
private static System.Boolean OverlappingSegment(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Map.MapPoint> a, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Map.MapPoint> b)
private static System.Boolean PrunePaths(MegaCrit.Sts2.Core.Map.MapPoint[,] grid, System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Map.MapPoint> startMapPoints, System.Collections.Generic.IEnumerable<System.Collections.Generic.List<MegaCrit.Sts2.Core.Map.MapPoint[]>> matchingSegments, MegaCrit.Sts2.Core.Random.Rng rng)
private static System.Boolean PruneSegment(MegaCrit.Sts2.Core.Map.MapPoint[,] grid, System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Map.MapPoint> startMapPoints, MegaCrit.Sts2.Core.Map.MapPoint[] segment)
private static System.Boolean RepairPointType(MegaCrit.Sts2.Core.Map.ActMap map, MegaCrit.Sts2.Core.Map.MapPointType type, System.Int32 targetCount, MegaCrit.Sts2.Core.Random.Rng rng, System.Func<MegaCrit.Sts2.Core.Map.MapPointType, MegaCrit.Sts2.Core.Map.MapPoint, System.Boolean> isValidPointType)
private static System.Collections.Generic.List<System.Collections.Generic.List<MegaCrit.Sts2.Core.Map.MapPoint[]>> GetDuplicateSegments(System.Collections.Generic.IDictionary<System.String, System.Collections.Generic.List<MegaCrit.Sts2.Core.Map.MapPoint[]>> segments)
private static System.Int32 PruneAllButLast(MegaCrit.Sts2.Core.Map.MapPoint[,] grid, System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Map.MapPoint> startMapPoints, System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Map.MapPoint[]> matches)
private static System.String GenerateSegmentKey(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Map.MapPoint> segment)
private static System.Void AddSegmentsToDictionary(System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Map.MapPoint> path, System.Collections.Generic.IDictionary<System.String, System.Collections.Generic.List<MegaCrit.Sts2.Core.Map.MapPoint[]>> segments)
private static System.Void RemovePoint(MegaCrit.Sts2.Core.Map.MapPoint[,] grid, System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Map.MapPoint> startMapPoints, MegaCrit.Sts2.Core.Map.MapPoint mapPoint)
public static System.Boolean RepairPrunedPointTypes(MegaCrit.Sts2.Core.Map.ActMap map, MegaCrit.Sts2.Core.Map.MapPointTypeCounts pointTypeCounts, MegaCrit.Sts2.Core.Random.Rng rng, System.Func<MegaCrit.Sts2.Core.Map.MapPointType, MegaCrit.Sts2.Core.Map.MapPoint, System.Boolean> isValidPointType)
public static System.Collections.Generic.List<System.Collections.Generic.List<MegaCrit.Sts2.Core.Map.MapPoint[]>> FindMatchingSegments(MegaCrit.Sts2.Core.Map.MapPoint startingMapPoint)
public static System.Collections.Generic.List<System.Collections.Generic.List<MegaCrit.Sts2.Core.Map.MapPoint>> FindAllPaths(MegaCrit.Sts2.Core.Map.MapPoint currentMapPoint)
public static System.Void PruneAndRepair(MegaCrit.Sts2.Core.Map.MapPoint[,] grid, System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Map.MapPoint> startMapPoints, MegaCrit.Sts2.Core.Map.ActMap map, MegaCrit.Sts2.Core.Map.MapPointTypeCounts pointTypeCounts, MegaCrit.Sts2.Core.Random.Rng rng, System.Func<MegaCrit.Sts2.Core.Map.MapPointType, MegaCrit.Sts2.Core.Map.MapPoint, System.Boolean> isValidPointType)
public static System.Void PruneDuplicateSegments(MegaCrit.Sts2.Core.Map.MapPoint[,] grid, System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Map.MapPoint> startMapPoints, MegaCrit.Sts2.Core.Map.MapPoint startingMapPoint, MegaCrit.Sts2.Core.Random.Rng rng)
```

## MegaCrit.Sts2.Core.Map.MapPathPruning+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Map.MapPathPruning+<>c <>9
public static System.Func<System.Collections.Generic.List<MegaCrit.Sts2.Core.Map.MapPoint[]>, System.Boolean> <>9__12_0
public static System.Func<MegaCrit.Sts2.Core.Map.MapPoint, System.Boolean> <>9__15_1
public static System.Func<MegaCrit.Sts2.Core.Map.MapPoint, System.Boolean> <>9__15_3
public static System.Func<MegaCrit.Sts2.Core.Map.MapPoint, System.Boolean> <>9__2_1
public static System.Func<MegaCrit.Sts2.Core.Map.MapPoint, System.Int32> <>9__9_0
private static .cctor()
public .ctor()
internal System.Boolean <GetDuplicateSegments>b__12_0(System.Collections.Generic.List<MegaCrit.Sts2.Core.Map.MapPoint[]> segmentList)
internal System.Boolean <PruneSegment>b__15_1(MegaCrit.Sts2.Core.Map.MapPoint n)
internal System.Boolean <PruneSegment>b__15_3(MegaCrit.Sts2.Core.Map.MapPoint c)
internal System.Boolean <RepairPointType>b__2_1(MegaCrit.Sts2.Core.Map.MapPoint p)
internal System.Int32 <GenerateSegmentKey>b__9_0(MegaCrit.Sts2.Core.Map.MapPoint point)
```

## MegaCrit.Sts2.Core.Map.MapPathPruning+<>c__DisplayClass10_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Map.MapPoint> segment
public .ctor()
internal System.Boolean <AnyOverlappingSegments>b__0(MegaCrit.Sts2.Core.Map.MapPoint[] existingSegment)
```

## MegaCrit.Sts2.Core.Map.MapPathPruning+<>c__DisplayClass15_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.Func<MegaCrit.Sts2.Core.Map.MapPoint, System.Boolean> <>9__0
public System.Func<MegaCrit.Sts2.Core.Map.MapPoint, System.Boolean> <>9__2
public MegaCrit.Sts2.Core.Map.MapPoint[,] grid
public MegaCrit.Sts2.Core.Map.MapPoint[] segment
public .ctor()
internal System.Boolean <PruneSegment>b__0(MegaCrit.Sts2.Core.Map.MapPoint n)
internal System.Boolean <PruneSegment>b__2(MegaCrit.Sts2.Core.Map.MapPoint c)
```

## MegaCrit.Sts2.Core.Map.MapPathPruning+<>c__DisplayClass2_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Map.MapPointType type
public .ctor()
internal System.Boolean <RepairPointType>b__0(MegaCrit.Sts2.Core.Map.MapPoint p)
```

## MegaCrit.Sts2.Core.Map.MapPoint

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：`System.IComparable<MegaCrit.Sts2.Core.Map.MapPoint>`

```text
private readonly System.Collections.Generic.List<MegaCrit.Sts2.Core.Models.AbstractModel> _quests
private System.Boolean <CanBeModified>k__BackingField
private readonly System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Map.MapPoint> <Children>k__BackingField
private MegaCrit.Sts2.Core.Map.MapPointType <PointType>k__BackingField
public MegaCrit.Sts2.Core.Map.MapCoord coord
private System.Action NodeMarkedChanged
public readonly System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Map.MapPoint> parents
System.Boolean CanBeModified { public get; public set; }
System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Map.MapPoint> Children { public get; }
MegaCrit.Sts2.Core.Map.MapPointType PointType { public get; public set; }
System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.AbstractModel> Quests { public get; }
event System.Action NodeMarkedChanged
public .ctor(System.Int32 col, System.Int32 row)
private System.Boolean Equals(MegaCrit.Sts2.Core.Map.MapPoint other)
private System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Map.MapPoint> GetAllDescendants()
private System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Map.MapPoint> BuildPath(System.Collections.Generic.IReadOnlyDictionary<MegaCrit.Sts2.Core.Map.MapPoint, MegaCrit.Sts2.Core.Map.MapPoint> parentPoint, MegaCrit.Sts2.Core.Map.MapPoint target)
public MegaCrit.Sts2.Core.Map.MapPoint GetCommonAncestor(MegaCrit.Sts2.Core.Map.MapPoint b)
public MegaCrit.Sts2.Core.Map.MapPoint GetFirstCommonDescendant(MegaCrit.Sts2.Core.Map.MapPoint b)
public MegaCrit.Sts2.Core.Map.MapPoint LeftChild()
public MegaCrit.Sts2.Core.Map.MapPoint RightChild()
public MegaCrit.Sts2.Core.Map.MapPointType get_PointType()
public System.Boolean get_CanBeModified()
public System.Boolean IsAdjacentLeft(MegaCrit.Sts2.Core.Map.MapPoint sibling)
public System.Boolean IsAdjacentRight(MegaCrit.Sts2.Core.Map.MapPoint sibling)
public System.Boolean IsDescendantPathSame(MegaCrit.Sts2.Core.Map.MapPoint other)
public System.Boolean IsInTheSameRow(MegaCrit.Sts2.Core.Map.MapPoint sibling)
public System.Boolean IsToTheLeft(MegaCrit.Sts2.Core.Map.MapPoint sibling)
public System.Boolean IsToTheRight(MegaCrit.Sts2.Core.Map.MapPoint sibling)
public System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Map.MapPoint> get_Children()
public System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Map.MapPoint> GetAllAncestors()
public System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Map.MapPoint> BFS_FindPath(MegaCrit.Sts2.Core.Map.MapPoint target)
public System.Collections.Generic.IReadOnlyList<MegaCrit.Sts2.Core.Models.AbstractModel> get_Quests()
public System.Int32 GetLastJunctionLength()
public System.Void add_NodeMarkedChanged(System.Action value)
public System.Void AddChildPoint(MegaCrit.Sts2.Core.Map.MapPoint child)
public System.Void AddQuest(MegaCrit.Sts2.Core.Models.AbstractModel model)
public System.Void remove_NodeMarkedChanged(System.Action value)
public System.Void RemoveChildPoint(MegaCrit.Sts2.Core.Map.MapPoint child)
public System.Void RemoveQuest(MegaCrit.Sts2.Core.Models.AbstractModel model)
public System.Void set_CanBeModified(System.Boolean value)
public System.Void set_PointType(MegaCrit.Sts2.Core.Map.MapPointType value)
public virtual System.Int32 CompareTo(MegaCrit.Sts2.Core.Map.MapPoint other)
public virtual System.String ToString()
```

## MegaCrit.Sts2.Core.Map.MapPoint+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Map.MapPoint+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Map.MapPoint, System.Boolean> <>9__39_0
public static System.Func<MegaCrit.Sts2.Core.Map.MapPoint, MegaCrit.Sts2.Core.Map.MapPointType> <>9__39_1
public static System.Func<MegaCrit.Sts2.Core.Map.MapPoint, System.Boolean> <>9__39_2
public static System.Func<MegaCrit.Sts2.Core.Map.MapPoint, MegaCrit.Sts2.Core.Map.MapPointType> <>9__39_3
private static .cctor()
public .ctor()
internal MegaCrit.Sts2.Core.Map.MapPointType <IsDescendantPathSame>b__39_1(MegaCrit.Sts2.Core.Map.MapPoint n)
internal MegaCrit.Sts2.Core.Map.MapPointType <IsDescendantPathSame>b__39_3(MegaCrit.Sts2.Core.Map.MapPoint n)
internal System.Boolean <IsDescendantPathSame>b__39_0(MegaCrit.Sts2.Core.Map.MapPoint n)
internal System.Boolean <IsDescendantPathSame>b__39_2(MegaCrit.Sts2.Core.Map.MapPoint n)
```

## MegaCrit.Sts2.Core.Map.MapPointState

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Map.MapPointState None = 0
public static const MegaCrit.Sts2.Core.Map.MapPointState Travelable = 1
public static const MegaCrit.Sts2.Core.Map.MapPointState Traveled = 2
public static const MegaCrit.Sts2.Core.Map.MapPointState Untravelable = 3
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Map.MapPointType

类型属性：`Public, Sealed`；基类：`System.Enum`。

接口：`System.IComparable`, `System.ISpanFormattable`, `System.IFormattable`, `System.IConvertible`

```text
public static const MegaCrit.Sts2.Core.Map.MapPointType Ancient = 8
public static const MegaCrit.Sts2.Core.Map.MapPointType Boss = 7
public static const MegaCrit.Sts2.Core.Map.MapPointType Elite = 6
public static const MegaCrit.Sts2.Core.Map.MapPointType Monster = 5
public static const MegaCrit.Sts2.Core.Map.MapPointType RestSite = 4
public static const MegaCrit.Sts2.Core.Map.MapPointType Shop = 2
public static const MegaCrit.Sts2.Core.Map.MapPointType Treasure = 3
public static const MegaCrit.Sts2.Core.Map.MapPointType Unassigned = 0
public static const MegaCrit.Sts2.Core.Map.MapPointType Unknown = 1
public System.Int32 value__
```

## MegaCrit.Sts2.Core.Map.MapPointTypeCounts

类型属性：`Public, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private readonly System.Int32 <NumOfElites>k__BackingField
private readonly System.Int32 <NumOfRests>k__BackingField
private readonly System.Int32 <NumOfShops>k__BackingField
private readonly System.Int32 <NumOfUnknowns>k__BackingField
private readonly System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Map.MapPointType> <PointTypesThatIgnoreRules>k__BackingField
System.Int32 NumOfElites { public get; public set; }
System.Int32 NumOfRests { public get; }
System.Int32 NumOfShops { public get; }
System.Int32 NumOfUnknowns { public get; }
System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Map.MapPointType> PointTypesThatIgnoreRules { public get; public set; }
public .ctor(MegaCrit.Sts2.Core.Map.ActMap existingMap)
public .ctor(System.Int32 unknownCount, System.Int32 restCount)
public static System.Int32 StandardRandomUnknownCount(MegaCrit.Sts2.Core.Random.Rng rng)
public System.Boolean ShouldIgnoreMapPointRulesForMapPointType(MegaCrit.Sts2.Core.Map.MapPointType pointType)
public System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Map.MapPointType> get_PointTypesThatIgnoreRules()
public System.Int32 get_NumOfElites()
public System.Int32 get_NumOfRests()
public System.Int32 get_NumOfShops()
public System.Int32 get_NumOfUnknowns()
public System.Void set_NumOfElites(System.Int32 value)
public System.Void set_PointTypesThatIgnoreRules(System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Map.MapPointType> value)
```

## MegaCrit.Sts2.Core.Map.MapPointTypeCounts+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Map.MapPointTypeCounts+<>c <>9
public static System.Func<MegaCrit.Sts2.Core.Map.MapPoint, System.Boolean> <>9__20_0
public static System.Func<MegaCrit.Sts2.Core.Map.MapPoint, System.Boolean> <>9__20_1
private static .cctor()
public .ctor()
internal System.Boolean <.ctor>b__20_0(MegaCrit.Sts2.Core.Map.MapPoint p)
internal System.Boolean <.ctor>b__20_1(MegaCrit.Sts2.Core.Map.MapPoint p)
```

## MegaCrit.Sts2.Core.Map.MapPostProcessing

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
private static System.Boolean IsColumnEmpty(MegaCrit.Sts2.Core.Map.MapPoint[,] grid, System.Int32 col)
private static System.Collections.Generic.HashSet<System.Int32> GetAllowedPositions(MegaCrit.Sts2.Core.Map.MapPoint node, System.Int32 totalColumns)
private static System.Collections.Generic.HashSet<System.Int32> GetNeighborAllowedPositions(System.Int32 column, System.Int32 totalColumns)
private static System.Int32 ComputeGap(System.Int32 candidateCol, System.Collections.Generic.List<MegaCrit.Sts2.Core.Map.MapPoint> rowNodes, MegaCrit.Sts2.Core.Map.MapPoint currentNode)
public static MegaCrit.Sts2.Core.Map.MapPoint[,] CenterGrid(MegaCrit.Sts2.Core.Map.MapPoint[,] grid)
public static MegaCrit.Sts2.Core.Map.MapPoint[,] SpreadAdjacentMapPoints(MegaCrit.Sts2.Core.Map.MapPoint[,] grid)
public static MegaCrit.Sts2.Core.Map.MapPoint[,] StraightenPaths(MegaCrit.Sts2.Core.Map.MapPoint[,] grid)
```

## MegaCrit.Sts2.Core.Map.MapTravel

类型属性：`Public, Abstract, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Map.MapPoint> GetTravelablePointsFrom(MegaCrit.Sts2.Core.Runs.IRunState runState, MegaCrit.Sts2.Core.Map.MapPoint currentPoint)
```

## MegaCrit.Sts2.Core.Map.MockCraftedActMap

类型属性：`Public, Sealed, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Map.ActMap`。

接口：

```text
private readonly MegaCrit.Sts2.Core.Map.MapPoint <BossMapPoint>k__BackingField
private readonly MegaCrit.Sts2.Core.Map.MapPoint[,] <Grid>k__BackingField
private readonly MegaCrit.Sts2.Core.Map.MapPoint <StartingMapPoint>k__BackingField
MegaCrit.Sts2.Core.Map.MapPoint BossMapPoint { public virtual get; }
MegaCrit.Sts2.Core.Map.MapPoint[,] Grid { protected virtual get; }
MegaCrit.Sts2.Core.Map.MapPoint StartingMapPoint { public virtual get; }
public .ctor(System.Int32 width, System.Int32 height, MegaCrit.Sts2.Core.Map.MapPoint startingPoint, MegaCrit.Sts2.Core.Map.MapPoint bossPoint)
protected virtual MegaCrit.Sts2.Core.Map.MapPoint[,] get_Grid()
public System.Void Put(System.Int32 col, System.Int32 row, MegaCrit.Sts2.Core.Map.MapPointType type = 5)
public virtual MegaCrit.Sts2.Core.Map.MapPoint get_BossMapPoint()
public virtual MegaCrit.Sts2.Core.Map.MapPoint get_StartingMapPoint()
```

## MegaCrit.Sts2.Core.Map.MockSinglePointActMap

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Map.ActMap`。

接口：

```text
private readonly MegaCrit.Sts2.Core.Map.MapPoint _currentMapPoint
private readonly MegaCrit.Sts2.Core.Map.MapPoint <BossMapPoint>k__BackingField
private readonly MegaCrit.Sts2.Core.Map.MapPoint[,] <Grid>k__BackingField
private readonly MegaCrit.Sts2.Core.Map.MapPoint <StartingMapPoint>k__BackingField
MegaCrit.Sts2.Core.Map.MapPoint BossMapPoint { public virtual get; }
MegaCrit.Sts2.Core.Map.MapPoint[,] Grid { protected virtual get; }
MegaCrit.Sts2.Core.Map.MapPoint StartingMapPoint { public virtual get; }
public .ctor()
protected virtual MegaCrit.Sts2.Core.Map.MapPoint[,] get_Grid()
public System.Void MockCurrentMapPointType(MegaCrit.Sts2.Core.Map.MapPointType pointType)
public virtual MegaCrit.Sts2.Core.Map.MapPoint get_BossMapPoint()
public virtual MegaCrit.Sts2.Core.Map.MapPoint get_StartingMapPoint()
public virtual MegaCrit.Sts2.Core.Map.MapPoint GetPoint(MegaCrit.Sts2.Core.Map.MapCoord coord)
```

## MegaCrit.Sts2.Core.Map.NullActMap

类型属性：`Public, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Map.ActMap`。

接口：

```text
private readonly MegaCrit.Sts2.Core.Map.MapPoint <BossMapPoint>k__BackingField
private readonly MegaCrit.Sts2.Core.Map.MapPoint[,] <Grid>k__BackingField
private static readonly MegaCrit.Sts2.Core.Map.NullActMap <Instance>k__BackingField
private readonly MegaCrit.Sts2.Core.Map.MapPoint <StartingMapPoint>k__BackingField
MegaCrit.Sts2.Core.Map.MapPoint BossMapPoint { public virtual get; }
MegaCrit.Sts2.Core.Map.MapPoint[,] Grid { protected virtual get; }
MegaCrit.Sts2.Core.Map.NullActMap Instance { public static get; }
MegaCrit.Sts2.Core.Map.MapPoint StartingMapPoint { public virtual get; }
private static .cctor()
public .ctor()
protected virtual MegaCrit.Sts2.Core.Map.MapPoint[,] get_Grid()
public static MegaCrit.Sts2.Core.Map.NullActMap get_Instance()
public virtual MegaCrit.Sts2.Core.Map.MapPoint get_BossMapPoint()
public virtual MegaCrit.Sts2.Core.Map.MapPoint get_StartingMapPoint()
```

## MegaCrit.Sts2.Core.Map.SavedActMap

类型属性：`Public, Sealed, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Map.ActMap`。

接口：

```text
private readonly MegaCrit.Sts2.Core.Map.MapPoint <BossMapPoint>k__BackingField
private readonly MegaCrit.Sts2.Core.Map.MapPoint[,] <Grid>k__BackingField
private readonly MegaCrit.Sts2.Core.Map.MapPoint <SecondBossMapPoint>k__BackingField
private readonly MegaCrit.Sts2.Core.Map.MapPoint <StartingMapPoint>k__BackingField
MegaCrit.Sts2.Core.Map.MapPoint BossMapPoint { public virtual get; }
MegaCrit.Sts2.Core.Map.MapPoint[,] Grid { protected virtual get; }
MegaCrit.Sts2.Core.Map.MapPoint SecondBossMapPoint { public virtual get; }
MegaCrit.Sts2.Core.Map.MapPoint StartingMapPoint { public virtual get; }
public .ctor(MegaCrit.Sts2.Core.Saves.Runs.SerializableActMap saved)
private static MegaCrit.Sts2.Core.Map.MapPoint CreatePoint(MegaCrit.Sts2.Core.Saves.Runs.SerializableMapPoint saved)
private static System.Void WireChildren(MegaCrit.Sts2.Core.Saves.Runs.SerializableMapPoint savedPoint, System.Collections.Generic.Dictionary<MegaCrit.Sts2.Core.Map.MapCoord, MegaCrit.Sts2.Core.Map.MapPoint> lookup)
private static System.Void WireChildren(System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Saves.Runs.SerializableMapPoint> points, System.Collections.Generic.Dictionary<MegaCrit.Sts2.Core.Map.MapCoord, MegaCrit.Sts2.Core.Map.MapPoint> lookup)
protected virtual MegaCrit.Sts2.Core.Map.MapPoint[,] get_Grid()
public virtual MegaCrit.Sts2.Core.Map.MapPoint get_BossMapPoint()
public virtual MegaCrit.Sts2.Core.Map.MapPoint get_SecondBossMapPoint()
public virtual MegaCrit.Sts2.Core.Map.MapPoint get_StartingMapPoint()
```

## MegaCrit.Sts2.Core.Map.SpoilsActMap

类型属性：`Public, Sealed, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Map.ActMap`。

接口：

```text
private static readonly System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Map.MapPointType> _childMapPointRestrictions
private static readonly System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Map.MapPointType> _lowerMapPointRestrictions
private readonly System.Int32 _mapLength
private static const System.Int32 _mapWidth = 7
private static readonly System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Map.MapPointType> _parentMapPointRestrictions
private static const System.Int32 _pathCount = 7
private readonly MegaCrit.Sts2.Core.Map.MapPointTypeCounts _pointTypeCounts
private readonly MegaCrit.Sts2.Core.Random.Rng _rng
private static readonly System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Map.MapPointType> _siblingPointTypeRestrictions
private readonly System.Int32 _treasureRow
private static readonly System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Map.MapPointType> _upperMapPointRestrictions
private readonly MegaCrit.Sts2.Core.Map.MapPoint <BossMapPoint>k__BackingField
private readonly MegaCrit.Sts2.Core.Map.MapPoint[,] <Grid>k__BackingField
private readonly MegaCrit.Sts2.Core.Map.MapPoint <StartingMapPoint>k__BackingField
MegaCrit.Sts2.Core.Map.MapPoint BossMapPoint { public virtual get; }
MegaCrit.Sts2.Core.Map.MapPoint[,] Grid { protected virtual get; }
MegaCrit.Sts2.Core.Map.MapPoint StartingMapPoint { public virtual get; }
private static .cctor()
public .ctor(MegaCrit.Sts2.Core.Runs.IRunState runState, MegaCrit.Sts2.Core.Map.MapPointTypeCounts mapPointTypeCountsOverride = null)
private MegaCrit.Sts2.Core.Map.MapCoord GenerateNextCoord(MegaCrit.Sts2.Core.Map.MapPoint current)
private MegaCrit.Sts2.Core.Map.MapPoint GetOrCreatePoint(System.Int32 col, System.Int32 row)
private MegaCrit.Sts2.Core.Map.MapPointType GetNextValidPointType(System.Collections.Generic.Queue<MegaCrit.Sts2.Core.Map.MapPointType> pointTypesQueue, MegaCrit.Sts2.Core.Map.MapPoint mapPoint)
private static System.Boolean IsValidForLower(MegaCrit.Sts2.Core.Map.MapPointType pointType, MegaCrit.Sts2.Core.Map.MapPoint mapPoint)
private static System.Boolean IsValidWithChildren(MegaCrit.Sts2.Core.Map.MapPointType pointType, MegaCrit.Sts2.Core.Map.MapPoint mapPoint)
private static System.Boolean IsValidWithParents(MegaCrit.Sts2.Core.Map.MapPointType pointType, MegaCrit.Sts2.Core.Map.MapPoint mapPoint)
private static System.Boolean IsValidWithSiblings(MegaCrit.Sts2.Core.Map.MapPointType pointType, MegaCrit.Sts2.Core.Map.MapPoint mapPoint)
private static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Map.MapPoint> GetSiblings(MegaCrit.Sts2.Core.Map.MapPoint mapPoint)
private System.Boolean <AssignRemainingTypesToRandomPoints>b__29_0(MegaCrit.Sts2.Core.Map.MapPoint p)
private System.Boolean HasInvalidCrossover(MegaCrit.Sts2.Core.Map.MapPoint current, System.Int32 targetCol)
private System.Boolean IsValidForUpper(MegaCrit.Sts2.Core.Map.MapPointType pointType, MegaCrit.Sts2.Core.Map.MapPoint mapPoint)
private System.Boolean IsValidPointType(MegaCrit.Sts2.Core.Map.MapPointType pointType, MegaCrit.Sts2.Core.Map.MapPoint mapPoint)
private System.Collections.Generic.List<System.Int32> BuildCenteredPriorityList(System.Int32 currentCol, System.Int32 centerCol)
private System.Int32 GetNextColumn(System.Int32 currentCol, System.Int32 direction)
private System.ValueTuple<System.Int32, System.Int32> GetAllowedColumnsForRow(System.Int32 row)
private System.Void AssignPointTypes()
private System.Void AssignRemainingTypesToRandomPoints(System.Collections.Generic.Queue<MegaCrit.Sts2.Core.Map.MapPointType> pointTypesToBeAssigned)
private System.Void ConnectRowToBoss()
private System.Void ConnectRowToStart()
private System.Void ForEachInRow(System.Int32 rowIndex, System.Action<MegaCrit.Sts2.Core.Map.MapPoint> processor)
private System.Void GenerateHourglassMap()
private System.Void PathGenerate(MegaCrit.Sts2.Core.Map.MapPoint startingPoint)
private System.Void RedirectToTreasure(MegaCrit.Sts2.Core.Map.MapPoint strayNode, MegaCrit.Sts2.Core.Map.MapPoint treasure)
protected virtual MegaCrit.Sts2.Core.Map.MapPoint[,] get_Grid()
public virtual MegaCrit.Sts2.Core.Map.MapPoint get_BossMapPoint()
public virtual MegaCrit.Sts2.Core.Map.MapPoint get_StartingMapPoint()
```

## MegaCrit.Sts2.Core.Map.SpoilsActMap+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Map.SpoilsActMap+<>c <>9
public static System.Action<MegaCrit.Sts2.Core.Map.MapPoint> <>9__27_0
public static System.Action<MegaCrit.Sts2.Core.Map.MapPoint> <>9__27_1
public static System.Func<MegaCrit.Sts2.Core.Map.MapPoint, System.Boolean> <>9__27_2
public static System.Func<MegaCrit.Sts2.Core.Map.MapPoint, System.Boolean> <>9__29_1
public static System.Func<MegaCrit.Sts2.Core.Map.MapPoint, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Map.MapPoint>> <>9__42_0
private static .cctor()
public .ctor()
internal System.Boolean <AssignPointTypes>b__27_2(MegaCrit.Sts2.Core.Map.MapPoint p)
internal System.Boolean <AssignRemainingTypesToRandomPoints>b__29_1(MegaCrit.Sts2.Core.Map.MapPoint p)
internal System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Map.MapPoint> <GetSiblings>b__42_0(MegaCrit.Sts2.Core.Map.MapPoint x)
internal System.Void <AssignPointTypes>b__27_0(MegaCrit.Sts2.Core.Map.MapPoint p)
internal System.Void <AssignPointTypes>b__27_1(MegaCrit.Sts2.Core.Map.MapPoint p)
```

## MegaCrit.Sts2.Core.Map.SpoilsActMap+<>c__DisplayClass37_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Map.MapPointType pointType
public .ctor()
internal System.Boolean <IsValidWithParents>b__0(MegaCrit.Sts2.Core.Map.MapPoint p)
```

## MegaCrit.Sts2.Core.Map.SpoilsActMap+<>c__DisplayClass39_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Map.MapPointType pointType
public .ctor()
internal System.Boolean <IsValidWithChildren>b__0(MegaCrit.Sts2.Core.Map.MapPoint p)
```

## MegaCrit.Sts2.Core.Map.SpoilsActMap+<>c__DisplayClass41_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Map.MapPointType pointType
public .ctor()
internal System.Boolean <IsValidWithSiblings>b__0(MegaCrit.Sts2.Core.Map.MapPoint p)
```

## MegaCrit.Sts2.Core.Map.SpoilsActMap+<>c__DisplayClass42_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Map.MapPoint mapPoint
public .ctor()
internal System.Boolean <GetSiblings>b__1(MegaCrit.Sts2.Core.Map.MapPoint x)
```

## MegaCrit.Sts2.Core.Map.StandardActMap

类型属性：`Public, Sealed, BeforeFieldInit`；基类：`MegaCrit.Sts2.Core.Map.ActMap`。

接口：

```text
private static readonly System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Map.MapPointType> _childMapPointRestrictions
private static const System.Int32 _iterations = 7
private static readonly System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Map.MapPointType> _lowerMapPointRestrictions
private readonly System.Int32 _mapLength
private static const System.Int32 _mapWidth = 7
private static readonly System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Map.MapPointType> _parentMapPointRestrictions
private readonly MegaCrit.Sts2.Core.Map.MapPointTypeCounts _pointTypeCounts
private readonly MegaCrit.Sts2.Core.Random.Rng _rng
private static readonly System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Map.MapPointType> _siblingPointTypeRestrictions
private static readonly System.Collections.Generic.HashSet<MegaCrit.Sts2.Core.Map.MapPointType> _upperMapPointRestrictions
private readonly MegaCrit.Sts2.Core.Map.MapPoint <BossMapPoint>k__BackingField
private readonly MegaCrit.Sts2.Core.Map.MapPoint[,] <Grid>k__BackingField
private readonly MegaCrit.Sts2.Core.Map.MapPoint <SecondBossMapPoint>k__BackingField
private readonly System.Boolean <ShouldReplaceTreasureWithElites>k__BackingField
private readonly MegaCrit.Sts2.Core.Map.MapPoint <StartingMapPoint>k__BackingField
public static const System.Int32 maxElites = 15
MegaCrit.Sts2.Core.Map.MapPoint BossMapPoint { public virtual get; }
MegaCrit.Sts2.Core.Map.MapPoint[,] Grid { protected virtual get; }
MegaCrit.Sts2.Core.Map.MapPoint SecondBossMapPoint { public virtual get; }
System.Boolean ShouldReplaceTreasureWithElites { public get; }
MegaCrit.Sts2.Core.Map.MapPoint StartingMapPoint { public virtual get; }
private static .cctor()
public .ctor(MegaCrit.Sts2.Core.Random.Rng mapRng, MegaCrit.Sts2.Core.Models.ActModel actModel, System.Boolean isMultiplayer, System.Boolean shouldReplaceTreasureWithElites, System.Boolean hasSecondBoss = False, MegaCrit.Sts2.Core.Map.MapPointTypeCounts mapPointTypeCountsOverride = null, System.Boolean enablePruning = True)
private MegaCrit.Sts2.Core.Map.MapCoord GenerateNextCoord(MegaCrit.Sts2.Core.Map.MapPoint current)
private MegaCrit.Sts2.Core.Map.MapPoint GetOrCreateMapPoint(MegaCrit.Sts2.Core.Map.MapCoord coord)
private MegaCrit.Sts2.Core.Map.MapPoint GetOrCreatePoint(System.Int32 col, System.Int32 row)
private MegaCrit.Sts2.Core.Map.MapPointType GetNextValidPointType(System.Collections.Generic.Queue<MegaCrit.Sts2.Core.Map.MapPointType> pointTypesQueue, MegaCrit.Sts2.Core.Map.MapPoint mapPoint)
private static System.Boolean IsValidForLower(MegaCrit.Sts2.Core.Map.MapPointType pointType, MegaCrit.Sts2.Core.Map.MapPoint mapPoint)
private static System.Boolean IsValidWithChildren(MegaCrit.Sts2.Core.Map.MapPointType pointType, MegaCrit.Sts2.Core.Map.MapPoint mapPoint)
private static System.Boolean IsValidWithParents(MegaCrit.Sts2.Core.Map.MapPointType pointType, MegaCrit.Sts2.Core.Map.MapPoint mapPoint)
private static System.Boolean IsValidWithSiblings(MegaCrit.Sts2.Core.Map.MapPointType pointType, MegaCrit.Sts2.Core.Map.MapPoint mapPoint)
private static System.Boolean RowsContainPointType(MegaCrit.Sts2.Core.Map.MapPointType pointType, System.Collections.Generic.IEnumerable<System.Collections.Generic.List<MegaCrit.Sts2.Core.Map.MapPoint>> rows)
private static System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Map.MapPoint> GetSiblings(MegaCrit.Sts2.Core.Map.MapPoint mapPoint)
private static System.Void ForEachInRow(MegaCrit.Sts2.Core.Map.MapPoint[,] grid, System.Int32 rowIndex, System.Action<MegaCrit.Sts2.Core.Map.MapPoint> processor, System.Boolean canBeModified = False)
private System.Boolean HasInvalidCrossover(MegaCrit.Sts2.Core.Map.MapPoint current, System.Int32 targetX)
private System.Boolean IsValidForUpper(MegaCrit.Sts2.Core.Map.MapPointType pointType, MegaCrit.Sts2.Core.Map.MapPoint mapPoint)
private System.Collections.Generic.List<System.Collections.Generic.List<MegaCrit.Sts2.Core.Map.MapPoint>> GetRows(System.Int32 firstRow, System.Int32 lastRow)
private System.Void <GenerateMap>b__28_0(MegaCrit.Sts2.Core.Map.MapPoint x)
private System.Void <GenerateMap>b__28_1(MegaCrit.Sts2.Core.Map.MapPoint x)
private System.Void AssignPointTypes()
private System.Void AssignPointTypesToRandomRows(System.Collections.Generic.Queue<MegaCrit.Sts2.Core.Map.MapPointType> pointTypesToBeAssigned, System.Collections.Generic.List<System.Collections.Generic.List<MegaCrit.Sts2.Core.Map.MapPoint>> rows)
private System.Void AssignRemainingTypesToRandomPoints(System.Collections.Generic.Queue<MegaCrit.Sts2.Core.Map.MapPointType> pointTypesToBeAssigned)
private System.Void EnsureRowsContainsPointType(MegaCrit.Sts2.Core.Map.MapPointType pointType, System.Collections.Generic.List<System.Collections.Generic.List<MegaCrit.Sts2.Core.Map.MapPoint>> rows)
private System.Void GenerateMap()
private System.Void PathGenerate(MegaCrit.Sts2.Core.Map.MapPoint startingPoint)
protected virtual MegaCrit.Sts2.Core.Map.MapPoint[,] get_Grid()
public static MegaCrit.Sts2.Core.Map.StandardActMap CreateFor(MegaCrit.Sts2.Core.Runs.RunState runState, System.Boolean replaceTreasureWithElites)
public System.Boolean get_ShouldReplaceTreasureWithElites()
public System.Boolean IsValidPointType(MegaCrit.Sts2.Core.Map.MapPointType pointType, MegaCrit.Sts2.Core.Map.MapPoint mapPoint)
public virtual MegaCrit.Sts2.Core.Map.MapPoint get_BossMapPoint()
public virtual MegaCrit.Sts2.Core.Map.MapPoint get_SecondBossMapPoint()
public virtual MegaCrit.Sts2.Core.Map.MapPoint get_StartingMapPoint()
```

## MegaCrit.Sts2.Core.Map.StandardActMap+<>c

类型属性：`NestedPrivate, Sealed, Serializable, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public static readonly MegaCrit.Sts2.Core.Map.StandardActMap+<>c <>9
public static System.Action<MegaCrit.Sts2.Core.Map.MapPoint> <>9__30_0
public static System.Action<MegaCrit.Sts2.Core.Map.MapPoint> <>9__30_1
public static System.Action<MegaCrit.Sts2.Core.Map.MapPoint> <>9__30_2
public static System.Action<MegaCrit.Sts2.Core.Map.MapPoint> <>9__30_3
public static System.Func<MegaCrit.Sts2.Core.Map.MapPoint, System.Boolean> <>9__30_4
public static System.Func<MegaCrit.Sts2.Core.Map.MapPoint, System.Boolean> <>9__34_0
public static System.Func<MegaCrit.Sts2.Core.Map.MapPoint, System.Boolean> <>9__35_0
public static System.Func<MegaCrit.Sts2.Core.Map.MapPoint, System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Map.MapPoint>> <>9__48_0
private static .cctor()
public .ctor()
internal System.Boolean <AssignPointTypes>b__30_4(MegaCrit.Sts2.Core.Map.MapPoint x)
internal System.Boolean <AssignPointTypesToRandomRows>b__34_0(MegaCrit.Sts2.Core.Map.MapPoint r)
internal System.Boolean <AssignRemainingTypesToRandomPoints>b__35_0(MegaCrit.Sts2.Core.Map.MapPoint p)
internal System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Map.MapPoint> <GetSiblings>b__48_0(MegaCrit.Sts2.Core.Map.MapPoint x)
internal System.Void <AssignPointTypes>b__30_0(MegaCrit.Sts2.Core.Map.MapPoint p)
internal System.Void <AssignPointTypes>b__30_1(MegaCrit.Sts2.Core.Map.MapPoint p)
internal System.Void <AssignPointTypes>b__30_2(MegaCrit.Sts2.Core.Map.MapPoint p)
internal System.Void <AssignPointTypes>b__30_3(MegaCrit.Sts2.Core.Map.MapPoint p)
```

## MegaCrit.Sts2.Core.Map.StandardActMap+<>c__DisplayClass32_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public System.Func<MegaCrit.Sts2.Core.Map.MapPoint, System.Boolean> <>9__1
public MegaCrit.Sts2.Core.Map.MapPointType pointType
public .ctor()
internal System.Boolean <RowsContainPointType>b__1(MegaCrit.Sts2.Core.Map.MapPoint p)
internal System.Collections.Generic.IEnumerable<MegaCrit.Sts2.Core.Map.MapPoint> <RowsContainPointType>b__0(System.Collections.Generic.List<MegaCrit.Sts2.Core.Map.MapPoint> row)
```

## MegaCrit.Sts2.Core.Map.StandardActMap+<>c__DisplayClass43_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Map.MapPointType pointType
public .ctor()
internal System.Boolean <IsValidWithParents>b__0(MegaCrit.Sts2.Core.Map.MapPoint p)
```

## MegaCrit.Sts2.Core.Map.StandardActMap+<>c__DisplayClass45_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Map.MapPointType pointType
public .ctor()
internal System.Boolean <IsValidWithChildren>b__0(MegaCrit.Sts2.Core.Map.MapPoint p)
```

## MegaCrit.Sts2.Core.Map.StandardActMap+<>c__DisplayClass47_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Map.MapPointType pointType
public .ctor()
internal System.Boolean <IsValidWithSiblings>b__0(MegaCrit.Sts2.Core.Map.MapPoint p)
```

## MegaCrit.Sts2.Core.Map.StandardActMap+<>c__DisplayClass48_0

类型属性：`NestedPrivate, Sealed, BeforeFieldInit`；基类：`System.Object`。

接口：

```text
public MegaCrit.Sts2.Core.Map.MapPoint mapPoint
public .ctor()
internal System.Boolean <GetSiblings>b__1(MegaCrit.Sts2.Core.Map.MapPoint x)
```
