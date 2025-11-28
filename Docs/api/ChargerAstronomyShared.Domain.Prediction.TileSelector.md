# <a id="ChargerAstronomyShared_Domain_Prediction_TileSelector"></a> Class TileSelector

Namespace: [ChargerAstronomyShared.Domain.Prediction](ChargerAstronomyShared.Domain.Prediction.md)  
Assembly: ChargerAstronomyShared.dll  

```csharp
public static class TileSelector
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[TileSelector](ChargerAstronomyShared.Domain.Prediction.TileSelector.md)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Methods

### <a id="ChargerAstronomyShared_Domain_Prediction_TileSelector_Select_ChargerAstronomyShared_Domain_Index_ITileIndex_System_Numerics_Vector3_System_Single_System_Collections_Generic_List_ChargerAstronomyShared_Contracts_Models_TileId__System_Boolean_System_Single_"></a> Select\(ITileIndex, Vector3, float, List<TileId\>, bool, float\)

Selects tiles from the given tile index that intersect with the specified camera direction and field of view
(FOV).

```csharp
public static List<TileId> Select(ITileIndex index, Vector3 cameraDirection, float fov, List<TileId> scratch, bool contains = false, float eps = 1E-06)
```

#### Parameters

`index` [ITileIndex](ChargerAstronomyShared.Domain.Index.ITileIndex.md)

The tile index containing the tiles and their associated geometry.

`cameraDirection` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

The direction of the camera in equatorial space. Must be a non-zero vector.

`fov` [float](https://learn.microsoft.com/dotnet/api/system.single)

The field of view (FOV) in radians. Must be a positive value.

`scratch` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[TileId](ChargerAstronomyShared.Contracts.Models.TileId.md)\>

A list to store the selected tiles. The method appends results to this list.

`contains` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

A boolean indicating whether to use a "contains" mode for selection. If <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>, tiles are
    selected if they intersect with the FOV. If <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, tiles are selected if they are fully
    contained within the FOV.

`eps` [float](https://learn.microsoft.com/dotnet/api/system.single)

A small epsilon value used for numerical precision adjustments. Defaults to 1e-6.

#### Returns

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[TileId](ChargerAstronomyShared.Contracts.Models.TileId.md)\>

A list of tile IDs representing the tiles that intersect with or are contained within the specified FOV, 
    depending on the value of <code class="paramref">contains</code>. The returned list is the same as the <code class="paramref">scratch</code> list.

#### Remarks

This method normalizes the <code class="paramref">cameraDirection</code> vector before performing
    calculations. The selection process accounts for the angular size of each tile and the specified FOV. If the
    FOV is smaller than the angular size of a tile, the tile is treated as intersecting the FOV.

