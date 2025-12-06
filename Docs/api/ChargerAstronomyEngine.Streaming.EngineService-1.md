# <a id="ChargerAstronomyEngine_Streaming_EngineService_1"></a> Class EngineService<T\>

Namespace: [ChargerAstronomyEngine.Streaming](ChargerAstronomyEngine.Streaming.md)  
Assembly: ChargerAstronomyEngine.dll  

Engine service. Manages star calculation, heat service, and spatial indexing.

```csharp
public class EngineService<T> : IEngineService<T> where T : IHorizontal
```

#### Type Parameters

`T` 

The <xref href="ChargerAstronomyShared.Domain.Index.ITileIndex" data-throw-if-not-resolved="false"></xref> used in the current spatial index.

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[EngineService<T\>](ChargerAstronomyEngine.Streaming.EngineService\-1.md)

#### Implements

[IEngineService<T\>](ChargerAstronomyShared.Contracts.Repositories.IEngineService\-1.md)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="ChargerAstronomyEngine_Streaming_EngineService_1__ctor_ChargerAstronomyShared_Domain_Index_ITileIndex_"></a> EngineService\(ITileIndex\)

```csharp
public EngineService(ITileIndex tileIndex)
```

#### Parameters

`tileIndex` [ITileIndex](ChargerAstronomyShared.Domain.Index.ITileIndex.md)

## Properties

### <a id="ChargerAstronomyEngine_Streaming_EngineService_1_ActivationQueue"></a> ActivationQueue

Queue for stars that need to be activated (made visible).

```csharp
public BlockingCollection<T> ActivationQueue { get; }
```

#### Property Value

 [BlockingCollection](https://learn.microsoft.com/dotnet/api/system.collections.concurrent.blockingcollection\-1)<T\>

### <a id="ChargerAstronomyEngine_Streaming_EngineService_1_DeactivationQueue"></a> DeactivationQueue

Queue for stars that need to be deactivated (made invisible).

```csharp
public BlockingCollection<T> DeactivationQueue { get; }
```

#### Property Value

 [BlockingCollection](https://learn.microsoft.com/dotnet/api/system.collections.concurrent.blockingcollection\-1)<T\>

### <a id="ChargerAstronomyEngine_Streaming_EngineService_1_HeatService"></a> HeatService

```csharp
public HeatService HeatService { get; }
```

#### Property Value

 [HeatService](ChargerAstronomyEngine.Streaming.HeatService.md)

### <a id="ChargerAstronomyEngine_Streaming_EngineService_1_SpatialStarIndex"></a> SpatialStarIndex

The spatial index containing all stars organized by tile.

```csharp
public SpatialStarIndex<T> SpatialStarIndex { get; }
```

#### Property Value

 [SpatialStarIndex](ChargerAstronomyShared.Domain.SpatialIndex.SpatialStarIndex\-1.md)<T\>

### <a id="ChargerAstronomyEngine_Streaming_EngineService_1_UpdateTransformQueue"></a> UpdateTransformQueue

Queue for stars that need their transforms updated.

```csharp
public BlockingCollection<T> UpdateTransformQueue { get; }
```

#### Property Value

 [BlockingCollection](https://learn.microsoft.com/dotnet/api/system.collections.concurrent.blockingcollection\-1)<T\>

## Methods

### <a id="ChargerAstronomyEngine_Streaming_EngineService_1_ForceStarUpdate__0_"></a> ForceStarUpdate\(T\)

Updates a star's horiziontal position

```csharp
public void ForceStarUpdate(T star)
```

#### Parameters

`star` T

The star to be updated

### <a id="ChargerAstronomyEngine_Streaming_EngineService_1_GetStats"></a> GetStats\(\)

Gets current engine statistics.

```csharp
public EngineStats GetStats()
```

#### Returns

 [EngineStats](ChargerAstronomyShared.Contracts.Streaming.EngineStats.md)

An <xref href="ChargerAstronomyShared.Contracts.Streaming.EngineStats" data-throw-if-not-resolved="false"></xref> object.

### <a id="ChargerAstronomyEngine_Streaming_EngineService_1_PlaceStars"></a> PlaceStars\(\)

Places stars in their initial positions.

```csharp
public void PlaceStars()
```

### <a id="ChargerAstronomyEngine_Streaming_EngineService_1_StartServices"></a> StartServices\(\)

Starts the engine calculator services.

```csharp
public IEquatorialCalculator StartServices()
```

#### Returns

 [IEquatorialCalculator](ChargerAstronomyShared.Contracts.Repositories.IEquatorialCalculator.md)

An <xref href="ChargerAstronomyEngine.Streaming.EquatorialCalculator%601" data-throw-if-not-resolved="false"></xref> instance.

### <a id="ChargerAstronomyEngine_Streaming_EngineService_1_Step_System_Single_System_Single_System_Single_System_Single_System_Single_System_Single_System_Single_"></a> Step\(float, float, float, float, float, float, float\)

Steps the engine simulation forward by the specified delta time.

```csharp
public void Step(float deltaTime, float camX, float camY, float camZ, float horizontalFOV, float magnitudeThreshold, float speedMult)
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

