# <a id="ChargerAstronomyShared_Domain_SpatialIndex_SpatialStarIndex_1"></a> Class SpatialStarIndex<T\>

Namespace: [ChargerAstronomyShared.Domain.SpatialIndex](ChargerAstronomyShared.Domain.SpatialIndex.md)  
Assembly: ChargerAstronomyShared.dll  

Represents a spatial index for organizing and retrieving stars based on their positions in tiles.

```csharp
public sealed class SpatialStarIndex<T> where T : IHorizontal
```

#### Type Parameters

`T` 

The type of stars to be indexed. Must implement <xref href="ChargerAstronomyShared.Contracts.Models.IHorizontal" data-throw-if-not-resolved="false"></xref> to provide positional data.

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[SpatialStarIndex<T\>](ChargerAstronomyShared.Domain.SpatialIndex.SpatialStarIndex\-1.md)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Remarks

This class provides efficient spatial indexing for stars by associating them with tiles
    defined by an <xref href="ChargerAstronomyShared.Domain.Index.ITileIndex" data-throw-if-not-resolved="false"></xref>. Stars can be added individually or in bulk, and their positions are used
    to determine the corresponding tile for indexing. The index supports retrieving all stars within a specific tile
    and ensures that each star is correctly associated with its corresponding tile.

## Constructors

### <a id="ChargerAstronomyShared_Domain_SpatialIndex_SpatialStarIndex_1__ctor_ChargerAstronomyShared_Domain_Index_ITileIndex_"></a> SpatialStarIndex\(ITileIndex\)

```csharp
public SpatialStarIndex(ITileIndex tileIndex)
```

#### Parameters

`tileIndex` [ITileIndex](ChargerAstronomyShared.Domain.Index.ITileIndex.md)

### <a id="ChargerAstronomyShared_Domain_SpatialIndex_SpatialStarIndex_1__ctor_ChargerAstronomyShared_Domain_Index_ITileIndex_System_Collections_Generic_IEnumerable__0__"></a> SpatialStarIndex\(ITileIndex, IEnumerable<T\>\)

```csharp
public SpatialStarIndex(ITileIndex tileIndex, IEnumerable<T> inputStars)
```

#### Parameters

`tileIndex` [ITileIndex](ChargerAstronomyShared.Domain.Index.ITileIndex.md)

`inputStars` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<T\>

## Properties

### <a id="ChargerAstronomyShared_Domain_SpatialIndex_SpatialStarIndex_1_Stars"></a> Stars

A read-only list of all stars used in the index.

```csharp
public IReadOnlyList<T> Stars { get; }
```

#### Property Value

 [IReadOnlyList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1)<T\>

### <a id="ChargerAstronomyShared_Domain_SpatialIndex_SpatialStarIndex_1_TileIndex"></a> TileIndex

The TileIndex used for spatial indexing.

```csharp
public ITileIndex TileIndex { get; }
```

#### Property Value

 [ITileIndex](ChargerAstronomyShared.Domain.Index.ITileIndex.md)

## Methods

### <a id="ChargerAstronomyShared_Domain_SpatialIndex_SpatialStarIndex_1_AddStar__0_"></a> AddStar\(T\)

Adds a new star to the collection and associates it with the appropriate tile.

```csharp
public void AddStar(T newStar)
```

#### Parameters

`newStar` T

The star to add. Must not be <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>.

#### Remarks

The star is added to the main collection and also indexed by its corresponding tile.
    If the tile does not already exist in the index, it will be created.

#### Exceptions

 [ArgumentNullException](https://learn.microsoft.com/dotnet/api/system.argumentnullexception)

Thrown if <code class="paramref">newStar</code> is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>.

### <a id="ChargerAstronomyShared_Domain_SpatialIndex_SpatialStarIndex_1_AddStar_ChargerAstronomyShared_Contracts_Models_PageResult__0__"></a> AddStar\(PageResult<T\>\)

Adds a collection of stars to the collection and associates it with the appropriate tile.

```csharp
public void AddStar(PageResult<T> newStars)
```

#### Parameters

`newStars` [PageResult](ChargerAstronomyShared.Contracts.Models.PageResult\-1.md)<T\>

A <xref href="ChargerAstronomyShared.Contracts.Models.PageResult%601" data-throw-if-not-resolved="false"></xref> containing the stars to add.  The collection must not be <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>.

#### Remarks

Each star is added to the main collection and also indexed by its corresponding tile.
    If the tile does not already exist in the index, it will be created.

#### Exceptions

 [ArgumentNullException](https://learn.microsoft.com/dotnet/api/system.argumentnullexception)

Thrown if <code class="paramref">newStars</code> is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>.

### <a id="ChargerAstronomyShared_Domain_SpatialIndex_SpatialStarIndex_1_GetStarsInTile_ChargerAstronomyShared_Contracts_Models_TileId_"></a> GetStarsInTile\(TileId\)

```csharp
public IReadOnlyList<T> GetStarsInTile(TileId tile)
```

#### Parameters

`tile` [TileId](ChargerAstronomyShared.Contracts.Models.TileId.md)

#### Returns

 [IReadOnlyList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1)<T\>

### <a id="ChargerAstronomyShared_Domain_SpatialIndex_SpatialStarIndex_1_GetTileForStar__0_"></a> GetTileForStar\(T\)

Returns the <xref href="ChargerAstronomyShared.Contracts.Models.TileId" data-throw-if-not-resolved="false"></xref> containing the given star.

```csharp
public TileId GetTileForStar(T star)
```

#### Parameters

`star` T

#### Returns

 [TileId](ChargerAstronomyShared.Contracts.Models.TileId.md)

