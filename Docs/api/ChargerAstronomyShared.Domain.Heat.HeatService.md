# <a id="ChargerAstronomyShared_Domain_Heat_HeatService"></a> Class HeatService

Namespace: [ChargerAstronomyShared.Domain.Heat](ChargerAstronomyShared.Domain.Heat.md)  
Assembly: ChargerAstronomyShared.dll  

```csharp
public sealed class HeatService
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[HeatService](ChargerAstronomyShared.Domain.Heat.HeatService.md)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="ChargerAstronomyShared_Domain_Heat_HeatService__ctor_ChargerAstronomyShared_Domain_Heat_HeatMap_ChargerAstronomyShared_Domain_Index_ITileIndex_"></a> HeatService\(HeatMap, ITileIndex\)

Initializes a new instance of the <xref href="ChargerAstronomyShared.Domain.Heat.HeatService" data-throw-if-not-resolved="false"></xref> class with the specified heat map and tile
index.

```csharp
public HeatService(HeatMap heatMap, ITileIndex index)
```

#### Parameters

`heatMap` [HeatMap](ChargerAstronomyShared.Domain.Heat.HeatMap.md)

The heat map used to manage and analyze heat data.

`index` [ITileIndex](ChargerAstronomyShared.Domain.Index.ITileIndex.md)

The tile index used for spatial data organization and lookup.

#### Exceptions

 [ArgumentNullException](https://learn.microsoft.com/dotnet/api/system.argumentnullexception)

Thrown if <code class="paramref">heatMap</code> or <code class="paramref">index</code> is <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>.

## Fields

### <a id="ChargerAstronomyShared_Domain_Heat_HeatService_heatMap"></a> heatMap

```csharp
public readonly HeatMap heatMap
```

#### Field Value

 [HeatMap](ChargerAstronomyShared.Domain.Heat.HeatMap.md)

### <a id="ChargerAstronomyShared_Domain_Heat_HeatService_index"></a> index

```csharp
public readonly ITileIndex index
```

#### Field Value

 [ITileIndex](ChargerAstronomyShared.Domain.Index.ITileIndex.md)

## Methods

### <a id="ChargerAstronomyShared_Domain_Heat_HeatService_GetHeatMap"></a> GetHeatMap\(\)

Retrieves the current heat map.

```csharp
public HeatMap GetHeatMap()
```

#### Returns

 [HeatMap](ChargerAstronomyShared.Domain.Heat.HeatMap.md)

The <xref href="ChargerAstronomyShared.Domain.Heat.HeatMap" data-throw-if-not-resolved="false"></xref> instance representing the current heat map data.

### <a id="ChargerAstronomyShared_Domain_Heat_HeatService_GetTileIndex"></a> GetTileIndex\(\)

Retrieves the current tile index.

```csharp
public ITileIndex GetTileIndex()
```

#### Returns

 [ITileIndex](ChargerAstronomyShared.Domain.Index.ITileIndex.md)

An object implementing <xref href="ChargerAstronomyShared.Domain.Index.ITileIndex" data-throw-if-not-resolved="false"></xref> that represents the current tile index.

### <a id="ChargerAstronomyShared_Domain_Heat_HeatService_Step_System_Single_System_Numerics_Vector3_System_Single_"></a> Step\(float, Vector3, float\)

Updates the heat map and processes tile selection based on the provided time step.

```csharp
public Task Step(float deltaTime, Vector3 cameraDirection, float horizontalFOV)
```

#### Parameters

`deltaTime` [float](https://learn.microsoft.com/dotnet/api/system.single)

The time step, in seconds, used to update the heat map decay.

`cameraDirection` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`horizontalFOV` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

#### Remarks

This method performs the following operations: <ul><li>Applies a decay step to the heat map using the specified <code class="paramref">deltaTime</code>.</li><li>Selects tiles based on a simulated camera
    direction and field of view, storing the results in a temporary collection.</li><li>Updates the heat map values for the selected tiles, ensuring they meet a minimum observed
    threshold.</li></ul>

