# <a id="ChargerAstronomyShared_Domain_Geometry_TileGeometry"></a> Struct TileGeometry

Namespace: [ChargerAstronomyShared.Domain.Geometry](ChargerAstronomyShared.Domain.Geometry.md)  
Assembly: ChargerAstronomyShared.dll  

Information about the geometry of a tile.

```csharp
public readonly struct TileGeometry
```

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="ChargerAstronomyShared_Domain_Geometry_TileGeometry__ctor_ChargerAstronomyShared_Contracts_Models_TileId_System_Numerics_Vector3_System_Double_System_Collections_Generic_List_System_Numerics_Vector3__"></a> TileGeometry\(TileId, Vector3, double, List<Vector3\>\)

Initializes a new instance of the <xref href="ChargerAstronomyShared.Domain.Geometry.TileGeometry" data-throw-if-not-resolved="false"></xref> class with the specified tile identifier,
center position, rotation angle, and vertex list.

```csharp
public TileGeometry(TileId id, Vector3 center, double alpha, List<Vector3> vertices)
```

#### Parameters

`id` [TileId](ChargerAstronomyShared.Contracts.Models.TileId.md)

The unique identifier of the tile.

`center` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

The center position of the tile in 3D space.

`alpha` [double](https://learn.microsoft.com/dotnet/api/system.double)

The rotation angle of the tile, in radians.

`vertices` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)\>

The list of vertices defining the geometry of the tile. Cannot be null.

## Properties

### <a id="ChargerAstronomyShared_Domain_Geometry_TileGeometry_Alpha"></a> Alpha

The alpha angle (in radians) from the center of the tile. Used in calculations.

```csharp
public double Alpha { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyShared_Domain_Geometry_TileGeometry_Center"></a> Center

The vector pointing to the center of the tile.

```csharp
public Vector3 Center { get; }
```

#### Property Value

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="ChargerAstronomyShared_Domain_Geometry_TileGeometry_Id"></a> Id

The unique identifier of the tile.

```csharp
public TileId Id { get; }
```

#### Property Value

 [TileId](ChargerAstronomyShared.Contracts.Models.TileId.md)

### <a id="ChargerAstronomyShared_Domain_Geometry_TileGeometry_Vertices"></a> Vertices

The list of vertices that define the tile, in counter-clockwise order.

```csharp
public List<Vector3> Vertices { get; }
```

#### Property Value

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)\>

## Methods

### <a id="ChargerAstronomyShared_Domain_Geometry_TileGeometry_ToString"></a> ToString\(\)

Returns a string representation of the tile geometry, including its identifier and alpha value.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A string in the format "TileGeometry(Id={Id}, Alpha={Alpha})", where <code>Id</code> is the tile's identifier and
    <code>Alpha</code> is the alpha value formatted to three decimal places.

