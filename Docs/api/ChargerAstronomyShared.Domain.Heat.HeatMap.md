# <a id="ChargerAstronomyShared_Domain_Heat_HeatMap"></a> Class HeatMap

Namespace: [ChargerAstronomyShared.Domain.Heat](ChargerAstronomyShared.Domain.Heat.md)  
Assembly: ChargerAstronomyShared.dll  

A map of heat values within a tile index.

```csharp
public sealed class HeatMap
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[HeatMap](ChargerAstronomyShared.Domain.Heat.HeatMap.md)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="ChargerAstronomyShared_Domain_Heat_HeatMap__ctor_ChargerAstronomyShared_Domain_Heat_HeatConfig_"></a> HeatMap\(HeatConfig\)

```csharp
public HeatMap(HeatConfig cfg)
```

#### Parameters

`cfg` [HeatConfig](ChargerAstronomyShared.Domain.Heat.HeatConfig.md)

## Methods

### <a id="ChargerAstronomyShared_Domain_Heat_HeatMap_ActiveTileAtZero"></a> ActiveTileAtZero\(\)

```csharp
public IEnumerable<TileId> ActiveTileAtZero()
```

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[TileId](ChargerAstronomyShared.Contracts.Models.TileId.md)\>

### <a id="ChargerAstronomyShared_Domain_Heat_HeatMap_Apply_ChargerAstronomyShared_Contracts_Models_TileId__System_Single_"></a> Apply\(in TileId, float\)

Applies a delta to the heat value of a specific tile to increment or decrement it.

```csharp
public void Apply(in TileId id, float delta)
```

#### Parameters

`id` [TileId](ChargerAstronomyShared.Contracts.Models.TileId.md)

The ID of the desired tile

`delta` [float](https://learn.microsoft.com/dotnet/api/system.single)

The value to increase/decrease heat by.

### <a id="ChargerAstronomyShared_Domain_Heat_HeatMap_Apply_System_Collections_Generic_IEnumerable_System_ValueTuple_ChargerAstronomyShared_Contracts_Models_TileId_System_Single___"></a> Apply\(IEnumerable<\(TileId id, float delta\)\>\)

Applies deltas to multiple tiles.

```csharp
public void Apply(IEnumerable<(TileId id, float delta)> deltas)
```

#### Parameters

`deltas` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<\([TileId](ChargerAstronomyShared.Contracts.Models.TileId.md) [id](https://learn.microsoft.com/dotnet/api/system.valuetuple\-chargerastronomyshared.contracts.models.tileid,system.single\-.id), [float](https://learn.microsoft.com/dotnet/api/system.single) [delta](https://learn.microsoft.com/dotnet/api/system.valuetuple\-chargerastronomyshared.contracts.models.tileid,system.single\-.delta)\)\>

The value to increase/decrease heat by.

### <a id="ChargerAstronomyShared_Domain_Heat_HeatMap_Clear"></a> Clear\(\)

```csharp
public void Clear()
```

### <a id="ChargerAstronomyShared_Domain_Heat_HeatMap_Get_ChargerAstronomyShared_Contracts_Models_TileId__"></a> Get\(in TileId\)

Gets the heat value for a specific tile.

```csharp
public float Get(in TileId id)
```

#### Parameters

`id` [TileId](ChargerAstronomyShared.Contracts.Models.TileId.md)

The ID of the specific tile.

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

A float value representing heat.

### <a id="ChargerAstronomyShared_Domain_Heat_HeatMap_GetAllTrackedTiles"></a> GetAllTrackedTiles\(\)

```csharp
public IEnumerable<TileId> GetAllTrackedTiles()
```

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[TileId](ChargerAstronomyShared.Contracts.Models.TileId.md)\>

### <a id="ChargerAstronomyShared_Domain_Heat_HeatMap_GetMany_System_Collections_Generic_IEnumerable_ChargerAstronomyShared_Contracts_Models_TileId__"></a> GetMany\(IEnumerable<TileId\>\)

Gets the heat values for multiple tiles.

```csharp
public Dictionary<TileId, float> GetMany(IEnumerable<TileId> ids)
```

#### Parameters

`ids` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[TileId](ChargerAstronomyShared.Contracts.Models.TileId.md)\>

The list of tile IDs.

#### Returns

 [Dictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2)<[TileId](ChargerAstronomyShared.Contracts.Models.TileId.md), [float](https://learn.microsoft.com/dotnet/api/system.single)\>

A list of floating values represeting heat.

### <a id="ChargerAstronomyShared_Domain_Heat_HeatMap_InactiveTilesAboveZero"></a> InactiveTilesAboveZero\(\)

```csharp
public IEnumerable<TileId> InactiveTilesAboveZero()
```

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[TileId](ChargerAstronomyShared.Contracts.Models.TileId.md)\>

### <a id="ChargerAstronomyShared_Domain_Heat_HeatMap_Set_ChargerAstronomyShared_Contracts_Models_TileId__System_Single_"></a> Set\(in TileId, float\)

Sets the heat value for a specific tile.

```csharp
public void Set(in TileId id, float value)
```

#### Parameters

`id` [TileId](ChargerAstronomyShared.Contracts.Models.TileId.md)

The ID of the desired tile.

`value` [float](https://learn.microsoft.com/dotnet/api/system.single)

The desired heat value.

### <a id="ChargerAstronomyShared_Domain_Heat_HeatMap_Set_System_Collections_Generic_IEnumerable_ChargerAstronomyShared_Contracts_Models_TileId__System_Single_"></a> Set\(IEnumerable<TileId\>, float\)

Sets the heat value for multiple tiles.

```csharp
public void Set(IEnumerable<TileId> ids, float value)
```

#### Parameters

`ids` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[TileId](ChargerAstronomyShared.Contracts.Models.TileId.md)\>

The IDs of the desired tiles.

`value` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="ChargerAstronomyShared_Domain_Heat_HeatMap_StepDecay_System_Single_"></a> StepDecay\(float\)

Applies decay to the heat values.
Can use exponential decay OR instant decay based on config.

```csharp
public void StepDecay(float dtSeconds)
```

#### Parameters

`dtSeconds` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="ChargerAstronomyShared_Domain_Heat_HeatMap_TilesAbove_System_Single_System_Boolean_"></a> TilesAbove\(float, bool\)

```csharp
public IEnumerable<TileId> TilesAbove(float value, bool inclusive = true)
```

#### Parameters

`value` [float](https://learn.microsoft.com/dotnet/api/system.single)

`inclusive` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[TileId](ChargerAstronomyShared.Contracts.Models.TileId.md)\>

### <a id="ChargerAstronomyShared_Domain_Heat_HeatMap_TilesBelow_System_Single_System_Boolean_"></a> TilesBelow\(float, bool\)

```csharp
public IEnumerable<TileId> TilesBelow(float value, bool inclusive = true)
```

#### Parameters

`value` [float](https://learn.microsoft.com/dotnet/api/system.single)

`inclusive` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[TileId](ChargerAstronomyShared.Contracts.Models.TileId.md)\>

### <a id="ChargerAstronomyShared_Domain_Heat_HeatMap_TilesInRange_System_Single_System_Single_System_Boolean_"></a> TilesInRange\(float, float, bool\)

```csharp
public List<TileId> TilesInRange(float lower, float upper, bool inclusive = true)
```

#### Parameters

`lower` [float](https://learn.microsoft.com/dotnet/api/system.single)

`upper` [float](https://learn.microsoft.com/dotnet/api/system.single)

`inclusive` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[TileId](ChargerAstronomyShared.Contracts.Models.TileId.md)\>

