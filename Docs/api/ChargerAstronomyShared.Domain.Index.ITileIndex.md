# <a id="ChargerAstronomyShared_Domain_Index_ITileIndex"></a> Interface ITileIndex

Namespace: [ChargerAstronomyShared.Domain.Index](ChargerAstronomyShared.Domain.Index.md)  
Assembly: ChargerAstronomyShared.dll  

```csharp
public interface ITileIndex
```

## Properties

### <a id="ChargerAstronomyShared_Domain_Index_ITileIndex_TileCount"></a> TileCount

The total number of tiles.

```csharp
int TileCount { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="ChargerAstronomyShared_Domain_Index_ITileIndex_Tiles"></a> Tiles

Iterable list of tiles in this index.

```csharp
IReadOnlyList<TileId> Tiles { get; }
```

#### Property Value

 [IReadOnlyList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1)<[TileId](ChargerAstronomyShared.Contracts.Models.TileId.md)\>

## Methods

### <a id="ChargerAstronomyShared_Domain_Index_ITileIndex_DirectionToTileId_System_Numerics_Vector3_"></a> DirectionToTileId\(Vector3\)

Converts a direction vector to the corresponding TileId on the icosphere.

```csharp
TileId DirectionToTileId(Vector3 direction)
```

#### Parameters

`direction` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

#### Returns

 [TileId](ChargerAstronomyShared.Contracts.Models.TileId.md)

The <xref href="ChargerAstronomyShared.Contracts.Models.TileId" data-throw-if-not-resolved="false"></xref> in the specified direction.

#### Exceptions

 [InvalidOperationException](https://learn.microsoft.com/dotnet/api/system.invalidoperationexception)

### <a id="ChargerAstronomyShared_Domain_Index_ITileIndex_Enumerate"></a> Enumerate\(\)

Enumerates the geometry data for all tiles in the collection.

```csharp
IEnumerable<TileId> Enumerate()
```

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[TileId](ChargerAstronomyShared.Contracts.Models.TileId.md)\>

An <xref href="System.Collections.Generic.IEnumerable%601" data-throw-if-not-resolved="false"></xref> of <xref href="System.Tuple%602" data-throw-if-not-resolved="false"></xref> objects, where each tuple consists of a <xref href="ChargerAstronomyShared.Contracts.Models.TileId" data-throw-if-not-resolved="false"></xref> representing the tile identifier and a <xref href="ChargerAstronomyShared.Domain.Geometry.TileGeometry" data-throw-if-not-resolved="false"></xref> representing the
    associated geometry data.

#### Remarks

This method returns a sequence of tuples, where each tuple contains a tile identifier
    and its associated geometry data. The enumeration is deferred, meaning the tiles are retrieved lazily as the
    sequence is iterated.

### <a id="ChargerAstronomyShared_Domain_Index_ITileIndex_EnumerateGeometry"></a> EnumerateGeometry\(\)

Retrieves the geometry associated with the specified <xref href="ChargerAstronomyShared.Contracts.Models.TileId" data-throw-if-not-resolved="false"></xref>.

```csharp
IEnumerable<Tuple<TileId, TileGeometry>> EnumerateGeometry()
```

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Tuple](https://learn.microsoft.com/dotnet/api/system.tuple\-2)<[TileId](ChargerAstronomyShared.Contracts.Models.TileId.md), [TileGeometry](ChargerAstronomyShared.Domain.Geometry.TileGeometry.md)\>\>

The <xref href="ChargerAstronomyShared.Domain.Geometry.TileGeometry" data-throw-if-not-resolved="false"></xref> associated with the specified <code class="paramref">id</code>.

#### Exceptions

 [Exception](https://learn.microsoft.com/dotnet/api/system.exception)

Thrown if the geometry for the specified <code class="paramref">id</code> is not found.

### <a id="ChargerAstronomyShared_Domain_Index_ITileIndex_GetGeometry_ChargerAstronomyShared_Contracts_Models_TileId_"></a> GetGeometry\(TileId\)

Retrieves the geometry data associated with the specified tile.

```csharp
TileGeometry GetGeometry(TileId id)
```

#### Parameters

`id` [TileId](ChargerAstronomyShared.Contracts.Models.TileId.md)

The unique identifier of the tile whose geometry data is to be retrieved.

#### Returns

 [TileGeometry](ChargerAstronomyShared.Domain.Geometry.TileGeometry.md)

A <xref href="ChargerAstronomyShared.Domain.Geometry.TileGeometry" data-throw-if-not-resolved="false"></xref> object representing the geometry of the specified tile. Returns <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a> if the tile does not exist or has no associated geometry.

### <a id="ChargerAstronomyShared_Domain_Index_ITileIndex_GetTileAlpha_ChargerAstronomyShared_Contracts_Models_TileId_"></a> GetTileAlpha\(TileId\)

Retrieves the alpha angle for the specified tile.

```csharp
double GetTileAlpha(TileId id)
```

#### Parameters

`id` [TileId](ChargerAstronomyShared.Contracts.Models.TileId.md)

The identifier of the tile for which to retrieve the alpha value.

#### Returns

 [double](https://learn.microsoft.com/dotnet/api/system.double)

Returns the alpha angle from the center of the specified TileId in radians.

#### Exceptions

 [Exception](https://learn.microsoft.com/dotnet/api/system.exception)

Thrown if the specified tile is not found in the tile geometry map.

### <a id="ChargerAstronomyShared_Domain_Index_ITileIndex_GetTileCenter_ChargerAstronomyShared_Contracts_Models_TileId_"></a> GetTileCenter\(TileId\)

Calculates the center point of the specified tile.

```csharp
Vector3 GetTileCenter(TileId id)
```

#### Parameters

`id` [TileId](ChargerAstronomyShared.Contracts.Models.TileId.md)

The identifier of the tile for which to calculate the center.

#### Returns

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

The center point of the tile as a <xref href="System.Numerics.Vector3" data-throw-if-not-resolved="false"></xref>.

#### Exceptions

 [Exception](https://learn.microsoft.com/dotnet/api/system.exception)

Thrown if the specified tile identifier does not exist in the tile geometry map.

### <a id="ChargerAstronomyShared_Domain_Index_ITileIndex_Neigbors_ChargerAstronomyShared_Contracts_Models_TileId_"></a> Neigbors\(TileId\)

Retrieves the neighboring tiles of the specified tile.

```csharp
IEnumerable<TileId> Neigbors(TileId id)
```

#### Parameters

`id` [TileId](ChargerAstronomyShared.Contracts.Models.TileId.md)

The identifier of the tile for which to find neighbors.

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[TileId](ChargerAstronomyShared.Contracts.Models.TileId.md)\>

An <xref href="System.Collections.Generic.IEnumerable%601" data-throw-if-not-resolved="false"></xref> containing the identifiers of the neighboring tiles.

#### Exceptions

 [NotImplementedException](https://learn.microsoft.com/dotnet/api/system.notimplementedexception)

This method is not yet implemented.

