# <a id="ChargerAstronomyEngine_Domain_Heat_HeatService"></a> Class HeatService

Namespace: [ChargerAstronomyEngine.Domain.Heat](ChargerAstronomyEngine.Domain.Heat.md)  
Assembly: ChargerAstronomyEngine.dll  

Service for managing heat mapping based on camera angle and <xref href="ChargerAstronomyShared.Domain.Observer" data-throw-if-not-resolved="false"></xref>.

```csharp
public sealed class HeatService
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[HeatService](ChargerAstronomyEngine.Domain.Heat.HeatService.md)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="ChargerAstronomyEngine_Domain_Heat_HeatService__ctor_ChargerAstronomyShared_Domain_Heat_HeatMap_ChargerAstronomyShared_Domain_Index_ITileIndex_ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_"></a> HeatService\(HeatMap, ITileIndex, Astronomy\)

```csharp
public HeatService(HeatMap heatMap, ITileIndex index, Astronomy astronomy)
```

#### Parameters

`heatMap` [HeatMap](ChargerAstronomyShared.Domain.Heat.HeatMap.md)

`index` [ITileIndex](ChargerAstronomyShared.Domain.Index.ITileIndex.md)

`astronomy` [Astronomy](ChargerAstronomyEngine.CosineKittyAstronomy.Astronomy.md)

## Fields

### <a id="ChargerAstronomyEngine_Domain_Heat_HeatService_heatMap"></a> heatMap

```csharp
public readonly HeatMap heatMap
```

#### Field Value

 [HeatMap](ChargerAstronomyShared.Domain.Heat.HeatMap.md)

### <a id="ChargerAstronomyEngine_Domain_Heat_HeatService_index"></a> index

```csharp
public readonly ITileIndex index
```

#### Field Value

 [ITileIndex](ChargerAstronomyShared.Domain.Index.ITileIndex.md)

## Methods

### <a id="ChargerAstronomyEngine_Domain_Heat_HeatService_GetActiveTiles"></a> GetActiveTiles\(\)

Gets all active tiles.

```csharp
public IEnumerable<TileId> GetActiveTiles()
```

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[TileId](ChargerAstronomyShared.Contracts.Models.TileId.md)\>

An <xref href="System.Collections.Generic.IEnumerable%601" data-throw-if-not-resolved="false"></xref> list of <xref href="ChargerAstronomyShared.Contracts.Models.TileId" data-throw-if-not-resolved="false"></xref>s.

### <a id="ChargerAstronomyEngine_Domain_Heat_HeatService_GetHeatMap"></a> GetHeatMap\(\)

The current heat map.

```csharp
public HeatMap GetHeatMap()
```

#### Returns

 [HeatMap](ChargerAstronomyShared.Domain.Heat.HeatMap.md)

### <a id="ChargerAstronomyEngine_Domain_Heat_HeatService_GetInactiveTiles"></a> GetInactiveTiles\(\)

Gets all inactive tiles.

```csharp
public IEnumerable<TileId> GetInactiveTiles()
```

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[TileId](ChargerAstronomyShared.Contracts.Models.TileId.md)\>

An <xref href="System.Collections.Generic.IEnumerable%601" data-throw-if-not-resolved="false"></xref> list of <xref href="ChargerAstronomyShared.Contracts.Models.TileId" data-throw-if-not-resolved="false"></xref>s.

### <a id="ChargerAstronomyEngine_Domain_Heat_HeatService_GetTileIndex"></a> GetTileIndex\(\)

The current tile index.

```csharp
public ITileIndex GetTileIndex()
```

#### Returns

 [ITileIndex](ChargerAstronomyShared.Domain.Index.ITileIndex.md)

### <a id="ChargerAstronomyEngine_Domain_Heat_HeatService_Step_System_Single_System_Numerics_Vector3_System_Single_"></a> Step\(float, Vector3, float\)

Steps the heat service, updating heat values based on camera direction and FOV.

```csharp
public Task Step(float deltaTime, Vector3 cameraDirectionHorizontal, float horizontalFOV)
```

#### Parameters

`deltaTime` [float](https://learn.microsoft.com/dotnet/api/system.single)

The amount of time that has passed during the step.

`cameraDirectionHorizontal` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

The horizontal direction of the camera.

`horizontalFOV` [float](https://learn.microsoft.com/dotnet/api/system.single)

The FOV (zoom) of the camera.

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

### <a id="ChargerAstronomyEngine_Domain_Heat_HeatService_UpdateTimeAndLocation_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_ChargerAstronomyShared_Domain_Observer_"></a> UpdateTimeAndLocation\(AstroTime, Observer\)

Updates the current time and observer location.

```csharp
public void UpdateTimeAndLocation(AstroTime time, Observer observer)
```

#### Parameters

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The new time.

`observer` [Observer](ChargerAstronomyShared.Domain.Observer.md)

The new <xref href="ChargerAstronomyShared.Domain.Observer" data-throw-if-not-resolved="false"></xref>.

