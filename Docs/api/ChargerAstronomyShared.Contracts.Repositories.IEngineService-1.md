# <a id="ChargerAstronomyShared_Contracts_Repositories_IEngineService_1"></a> Interface IEngineService<T\>

Namespace: [ChargerAstronomyShared.Contracts.Repositories](ChargerAstronomyShared.Contracts.Repositories.md)  
Assembly: ChargerAstronomyShared.dll  

Service interface for the engine.

```csharp
public interface IEngineService<T> where T : IHorizontal
```

#### Type Parameters

`T` 

<xref href="ChargerAstronomyShared.Domain.Index.ITileIndex" data-throw-if-not-resolved="false"></xref> used in the current engine service.

## Properties

### <a id="ChargerAstronomyShared_Contracts_Repositories_IEngineService_1_ActivationQueue"></a> ActivationQueue

Queue for stars that need to be activated (made visible).

```csharp
BlockingCollection<T> ActivationQueue { get; }
```

#### Property Value

 [BlockingCollection](https://learn.microsoft.com/dotnet/api/system.collections.concurrent.blockingcollection\-1)<T\>

### <a id="ChargerAstronomyShared_Contracts_Repositories_IEngineService_1_DeactivationQueue"></a> DeactivationQueue

Queue for stars that need to be deactivated (made invisible).

```csharp
BlockingCollection<T> DeactivationQueue { get; }
```

#### Property Value

 [BlockingCollection](https://learn.microsoft.com/dotnet/api/system.collections.concurrent.blockingcollection\-1)<T\>

### <a id="ChargerAstronomyShared_Contracts_Repositories_IEngineService_1_SpatialStarIndex"></a> SpatialStarIndex

The spatial index containing all stars organized by tile.

```csharp
SpatialStarIndex<T> SpatialStarIndex { get; }
```

#### Property Value

 [SpatialStarIndex](ChargerAstronomyShared.Domain.SpatialIndex.SpatialStarIndex\-1.md)<T\>

### <a id="ChargerAstronomyShared_Contracts_Repositories_IEngineService_1_UpdateTransformQueue"></a> UpdateTransformQueue

Queue for stars that need their transforms updated.

```csharp
BlockingCollection<T> UpdateTransformQueue { get; }
```

#### Property Value

 [BlockingCollection](https://learn.microsoft.com/dotnet/api/system.collections.concurrent.blockingcollection\-1)<T\>

## Methods

### <a id="ChargerAstronomyShared_Contracts_Repositories_IEngineService_1_ForceStarUpdate__0_"></a> ForceStarUpdate\(T\)

Updates a star's horiziontal position

```csharp
void ForceStarUpdate(T star)
```

#### Parameters

`star` T

The star to be updated

### <a id="ChargerAstronomyShared_Contracts_Repositories_IEngineService_1_GetStats"></a> GetStats\(\)

Gets current engine statistics.

```csharp
EngineStats GetStats()
```

#### Returns

 [EngineStats](ChargerAstronomyShared.Contracts.Streaming.EngineStats.md)

An <xref href="ChargerAstronomyShared.Contracts.Streaming.EngineStats" data-throw-if-not-resolved="false"></xref> object.

### <a id="ChargerAstronomyShared_Contracts_Repositories_IEngineService_1_PlaceStars"></a> PlaceStars\(\)

Places stars in their initial positions.

```csharp
void PlaceStars()
```

### <a id="ChargerAstronomyShared_Contracts_Repositories_IEngineService_1_StartServices"></a> StartServices\(\)

```csharp
IEquatorialCalculator StartServices()
```

#### Returns

 [IEquatorialCalculator](ChargerAstronomyShared.Contracts.Repositories.IEquatorialCalculator.md)

### <a id="ChargerAstronomyShared_Contracts_Repositories_IEngineService_1_Step_System_Single_System_Single_System_Single_System_Single_System_Single_System_Single_System_Single_"></a> Step\(float, float, float, float, float, float, float\)

Steps the engine simulation forward by the specified delta time.

```csharp
void Step(float deltaTime, float camX, float camY, float camZ, float horizontalFOV, float magnitudeThreshold, float speedMult)
```

#### Parameters

`deltaTime` [float](https://learn.microsoft.com/dotnet/api/system.single)

The amount of time passed during the step.

`camX` [float](https://learn.microsoft.com/dotnet/api/system.single)

X value of the camera.

`camY` [float](https://learn.microsoft.com/dotnet/api/system.single)

Y value of the camera.

`camZ` [float](https://learn.microsoft.com/dotnet/api/system.single)

Z value of the camera.

`horizontalFOV` [float](https://learn.microsoft.com/dotnet/api/system.single)

The FOV (zoom) of the camera.

`magnitudeThreshold` [float](https://learn.microsoft.com/dotnet/api/system.single)

Maximum threshold for star visibility.

`speedMult` [float](https://learn.microsoft.com/dotnet/api/system.single)

The current speed of the simulation.

