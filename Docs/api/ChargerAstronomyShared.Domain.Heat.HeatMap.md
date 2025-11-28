# <a id="ChargerAstronomyShared_Domain_Heat_HeatMap"></a> Class HeatMap

Namespace: [ChargerAstronomyShared.Domain.Heat](ChargerAstronomyShared.Domain.Heat.md)  
Assembly: ChargerAstronomyShared.dll  

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

Retrieves a list of active tiles that have a heat value of zero.

```csharp
public IEnumerable<TileId> ActiveTileAtZero()
```

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[TileId](ChargerAstronomyShared.Contracts.Models.TileId.md)\>

A list of <xref href="ChargerAstronomyShared.Contracts.Models.TileId" data-throw-if-not-resolved="false"></xref> objects representing the tiles that have heat values within the specified
    range. The list will be empty if no tiles match the criteria.

### <a id="ChargerAstronomyShared_Domain_Heat_HeatMap_Apply_ChargerAstronomyShared_Contracts_Models_TileId__System_Single_"></a> Apply\(in TileId, float\)

Applies a delta value onto the current value associated with the specified tile.

```csharp
public void Apply(in TileId id, float delta)
```

#### Parameters

`id` [TileId](ChargerAstronomyShared.Contracts.Models.TileId.md)

A <xref href="ChargerAstronomyShared.Contracts.Models.TileId" data-throw-if-not-resolved="false"></xref> object.

`delta` [float](https://learn.microsoft.com/dotnet/api/system.single)

The value to add to the current value of the specified tile.

#### Remarks

Retrieves the current value associated with the specified <code class="paramref">TileId</code>, adds the provided <code class="paramref">delta</code> to it, and updates the value.

### <a id="ChargerAstronomyShared_Domain_Heat_HeatMap_Apply_System_Collections_Generic_IEnumerable_System_ValueTuple_ChargerAstronomyShared_Contracts_Models_TileId_System_Single___"></a> Apply\(IEnumerable<\(TileId id, float delta\)\>\)

Applies a delta value to a collection of updates to tiles.

```csharp
public void Apply(IEnumerable<(TileId id, float delta)> deltas)
```

#### Parameters

`deltas` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<\([TileId](ChargerAstronomyShared.Contracts.Models.TileId.md) [id](https://learn.microsoft.com/dotnet/api/system.valuetuple\-chargerastronomyshared.contracts.models.tileid,system.single\-.id), [float](https://learn.microsoft.com/dotnet/api/system.single) [delta](https://learn.microsoft.com/dotnet/api/system.valuetuple\-chargerastronomyshared.contracts.models.tileid,system.single\-.delta)\)\>

A collection of tuples, each containing a <xref href="ChargerAstronomyShared.Contracts.Models.TileId" data-throw-if-not-resolved="false"></xref> representing the tile to update and a <xref href="System.Single" data-throw-if-not-resolved="false"></xref> representing the delta value to apply to the tile.

#### Remarks

This method iterates through the provided collection and applies each delta to the
    corresponding tile. Ensure that the collection is not null and contains valid tile identifiers and delta
    values.

### <a id="ChargerAstronomyShared_Domain_Heat_HeatMap_Get_ChargerAstronomyShared_Contracts_Models_TileId__"></a> Get\(in TileId\)

Retrieves the heat map value for the given tile.

```csharp
public float Get(in TileId id)
```

#### Parameters

`id` [TileId](ChargerAstronomyShared.Contracts.Models.TileId.md)

The tile for which to retrieve the heat map value.

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

The heat map value associated with the specified <code class="paramref">id</code> if it exists; otherwise, <code>0f</code>.

### <a id="ChargerAstronomyShared_Domain_Heat_HeatMap_InactiveTilesAboveZero"></a> InactiveTilesAboveZero\(\)

Retrieves a list of inactive tiles that have heat values above zero.

```csharp
public IEnumerable<TileId> InactiveTilesAboveZero()
```

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[TileId](ChargerAstronomyShared.Contracts.Models.TileId.md)\>

A list of <xref href="ChargerAstronomyShared.Contracts.Models.TileId" data-throw-if-not-resolved="false"></xref> objects representing the tiles that have heat values within the specified
    range. The list will be empty if no tiles match the criteria.

### <a id="ChargerAstronomyShared_Domain_Heat_HeatMap_Set_ChargerAstronomyShared_Contracts_Models_TileId__System_Single_"></a> Set\(in TileId, float\)

Sets the heat value for the given tile, or list of tiles.

```csharp
public void Set(in TileId id, float value)
```

#### Parameters

`id` [TileId](ChargerAstronomyShared.Contracts.Models.TileId.md)

A <xref href="ChargerAstronomyShared.Contracts.Models.TileId" data-throw-if-not-resolved="false"></xref> object to set the heat value of.

`value` [float](https://learn.microsoft.com/dotnet/api/system.single)

The heat value assigned to the tile.

### <a id="ChargerAstronomyShared_Domain_Heat_HeatMap_Set_System_Collections_Generic_IEnumerable_ChargerAstronomyShared_Contracts_Models_TileId__System_Single_"></a> Set\(IEnumerable<TileId\>, float\)

Sets the heat value for a collection of tiles.

```csharp
public void Set(IEnumerable<TileId> ids, float value)
```

#### Parameters

`ids` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[TileId](ChargerAstronomyShared.Contracts.Models.TileId.md)\>

A collection of <xref href="ChargerAstronomyShared.Contracts.Models.TileId" data-throw-if-not-resolved="false"></xref>s.

`value` [float](https://learn.microsoft.com/dotnet/api/system.single)

The heat value assigned to each tile in the list.

### <a id="ChargerAstronomyShared_Domain_Heat_HeatMap_StepDecay_System_Single_"></a> StepDecay\(float\)

Applies an exponential decay to the heat values in the heat map over a specified time interval.

```csharp
public void StepDecay(float dtSeconds)
```

#### Parameters

`dtSeconds` [float](https://learn.microsoft.com/dotnet/api/system.single)

The time interval, in seconds, over which the decay is applied. Must be greater than 0.

#### Remarks

This method updates the heat values in the heat map by applying an exponential decay
    formula: <code>Heat(t + dt) = Heat(t) * exp(-decayPerSecond * dt)</code>. The decay rate is determined by the
    <code>DecayPerSecond</code> configuration value.

### <a id="ChargerAstronomyShared_Domain_Heat_HeatMap_TilesAbove_System_Single_System_Boolean_"></a> TilesAbove\(float, bool\)

Retrieves a list of tiles that have a heat value above the specified threshold.

```csharp
public IEnumerable<TileId> TilesAbove(float value, bool inclusive = true)
```

#### Parameters

`value` [float](https://learn.microsoft.com/dotnet/api/system.single)

The threshold value to compare against the heat values of the tiles.

`inclusive` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

A boolean indicating whether the comparison should include tiles with heat values equal to the threshold. If
    <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, tiles with heat values equal to <code class="paramref">value</code> are included;  otherwise,
    only tiles with heat values strictly greater than <code class="paramref">value</code> are included.

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[TileId](ChargerAstronomyShared.Contracts.Models.TileId.md)\>

A list of <xref href="ChargerAstronomyShared.Contracts.Models.TileId" data-throw-if-not-resolved="false"></xref> objects representing the tiles that meet the specified heat value condition.
    The list will be empty if no tiles satisfy the condition.

### <a id="ChargerAstronomyShared_Domain_Heat_HeatMap_TilesBelow_System_Single_System_Boolean_"></a> TilesBelow\(float, bool\)

Retrieves a list of tiles that have a heat value below a specified threshold.

```csharp
public IEnumerable<TileId> TilesBelow(float value, bool inclusive = true)
```

#### Parameters

`value` [float](https://learn.microsoft.com/dotnet/api/system.single)

The threshold value to compare against the heat values of the tiles.

`inclusive` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

A boolean indicating whether tiles with heat values equal to the threshold should be included. If <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, tiles with heat values less than or equal to <code class="paramref">value</code> are included;
    otherwise, only tiles with heat values strictly less than <code class="paramref">value</code> are included.

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[TileId](ChargerAstronomyShared.Contracts.Models.TileId.md)\>

A list of <xref href="ChargerAstronomyShared.Contracts.Models.TileId" data-throw-if-not-resolved="false"></xref> objects representing the tiles that meet the specified condition. The list
    will be empty if no tiles satisfy the condition.

### <a id="ChargerAstronomyShared_Domain_Heat_HeatMap_TilesInRange_System_Single_System_Single_System_Boolean_"></a> TilesInRange\(float, float, bool\)

Retrieves a list of tiles that have heat values that fall within the specified range.

```csharp
public List<TileId> TilesInRange(float lower, float upper, bool inclusive = true)
```

#### Parameters

`lower` [float](https://learn.microsoft.com/dotnet/api/system.single)

The lower bound of the heat value range.

`upper` [float](https://learn.microsoft.com/dotnet/api/system.single)

The upper bound of the heat value range.

`inclusive` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

A boolean value indicating whether the range is inclusive.  If <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a>, tiles with heat
    values equal to the lower or upper bounds are included;  otherwise, only tiles with heat values strictly
    between the bounds are included.

#### Returns

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[TileId](ChargerAstronomyShared.Contracts.Models.TileId.md)\>

A list of <xref href="ChargerAstronomyShared.Contracts.Models.TileId" data-throw-if-not-resolved="false"></xref> objects representing the tiles that have heat values within the specified
    range. The list will be empty if no tiles match the criteria.

