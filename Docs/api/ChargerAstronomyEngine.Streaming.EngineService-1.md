# <a id="ChargerAstronomyEngine_Streaming_EngineService_1"></a> Class EngineService<T\>

Namespace: [ChargerAstronomyEngine.Streaming](ChargerAstronomyEngine.Streaming.md)  
Assembly: ChargerAstronomyEngine.dll  

```csharp
public class EngineService<T> : IEngineService<T> where T : IHorizontal
```

#### Type Parameters

`T` 

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

```csharp
public BlockingCollection<T> ActivationQueue { get; }
```

#### Property Value

 [BlockingCollection](https://learn.microsoft.com/dotnet/api/system.collections.concurrent.blockingcollection\-1)<T\>

### <a id="ChargerAstronomyEngine_Streaming_EngineService_1_DeactivationQueue"></a> DeactivationQueue

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

 [HeatService](ChargerAstronomyShared.Domain.Heat.HeatService.md)

### <a id="ChargerAstronomyEngine_Streaming_EngineService_1_SpatialStarIndex"></a> SpatialStarIndex

```csharp
public SpatialStarIndex<T> SpatialStarIndex { get; }
```

#### Property Value

 [SpatialStarIndex](ChargerAstronomyShared.Domain.SpatialIndex.SpatialStarIndex\-1.md)<T\>

### <a id="ChargerAstronomyEngine_Streaming_EngineService_1_UpdateTransformQueue"></a> UpdateTransformQueue

```csharp
public BlockingCollection<T> UpdateTransformQueue { get; }
```

#### Property Value

 [BlockingCollection](https://learn.microsoft.com/dotnet/api/system.collections.concurrent.blockingcollection\-1)<T\>

## Methods

### <a id="ChargerAstronomyEngine_Streaming_EngineService_1_StartServices"></a> StartServices\(\)

Starts and initializes the engine services for the application.

```csharp
public IEquatorialCalculator StartServices()
```

#### Returns

 [IEquatorialCalculator](ChargerAstronomyShared.Contracts.Repositories.IEquatorialCalculator.md)

An instance of <xref href="ChargerAstronomyShared.Contracts.Repositories.IEquatorialCalculator" data-throw-if-not-resolved="false"></xref> representing the initialized service.

### <a id="ChargerAstronomyEngine_Streaming_EngineService_1_Step_System_Single_System_Numerics_Vector3_System_Single_"></a> Step\(float, Vector3, float\)

Advances the simulation by a single step, updating the state based on the elapsed time and camera direction.

```csharp
public Task Step(float deltaTime, Vector3 cameraDirection, float horizontalFOV)
```

#### Parameters

`deltaTime` [float](https://learn.microsoft.com/dotnet/api/system.single)

The time, in seconds, that has elapsed since the last step. Must be greater than zero.

`cameraDirection` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

The direction the camera is facing, represented as a 3D vector.

`horizontalFOV` [float](https://learn.microsoft.com/dotnet/api/system.single)

The horizontal field of view, in degrees, used to determine the visible area. Must be a positive value.

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

A task that represents the asynchronous operation of stepping the simulation.

