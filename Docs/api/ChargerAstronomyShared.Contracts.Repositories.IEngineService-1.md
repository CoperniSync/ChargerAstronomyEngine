# <a id="ChargerAstronomyShared_Contracts_Repositories_IEngineService_1"></a> Interface IEngineService<T\>

Namespace: [ChargerAstronomyShared.Contracts.Repositories](ChargerAstronomyShared.Contracts.Repositories.md)  
Assembly: ChargerAstronomyShared.dll  

```csharp
public interface IEngineService<T> where T : IHorizontal
```

#### Type Parameters

`T` 

## Properties

### <a id="ChargerAstronomyShared_Contracts_Repositories_IEngineService_1_ActivationQueue"></a> ActivationQueue

```csharp
BlockingCollection<T> ActivationQueue { get; }
```

#### Property Value

 [BlockingCollection](https://learn.microsoft.com/dotnet/api/system.collections.concurrent.blockingcollection\-1)<T\>

### <a id="ChargerAstronomyShared_Contracts_Repositories_IEngineService_1_DeactivationQueue"></a> DeactivationQueue

```csharp
BlockingCollection<T> DeactivationQueue { get; }
```

#### Property Value

 [BlockingCollection](https://learn.microsoft.com/dotnet/api/system.collections.concurrent.blockingcollection\-1)<T\>

### <a id="ChargerAstronomyShared_Contracts_Repositories_IEngineService_1_HeatService"></a> HeatService

```csharp
HeatService HeatService { get; }
```

#### Property Value

 [HeatService](ChargerAstronomyShared.Domain.Heat.HeatService.md)

### <a id="ChargerAstronomyShared_Contracts_Repositories_IEngineService_1_SpatialStarIndex"></a> SpatialStarIndex

```csharp
SpatialStarIndex<T> SpatialStarIndex { get; }
```

#### Property Value

 [SpatialStarIndex](ChargerAstronomyShared.Domain.SpatialIndex.SpatialStarIndex\-1.md)<T\>

### <a id="ChargerAstronomyShared_Contracts_Repositories_IEngineService_1_UpdateTransformQueue"></a> UpdateTransformQueue

```csharp
BlockingCollection<T> UpdateTransformQueue { get; }
```

#### Property Value

 [BlockingCollection](https://learn.microsoft.com/dotnet/api/system.collections.concurrent.blockingcollection\-1)<T\>

## Methods

### <a id="ChargerAstronomyShared_Contracts_Repositories_IEngineService_1_StartServices"></a> StartServices\(\)

Starts and initializes the engine services for the application.

```csharp
IEquatorialCalculator StartServices()
```

#### Returns

 [IEquatorialCalculator](ChargerAstronomyShared.Contracts.Repositories.IEquatorialCalculator.md)

An instance of <xref href="ChargerAstronomyShared.Contracts.Repositories.IEquatorialCalculator" data-throw-if-not-resolved="false"></xref> representing the initialized service.

### <a id="ChargerAstronomyShared_Contracts_Repositories_IEngineService_1_Step_System_Single_System_Numerics_Vector3_System_Single_"></a> Step\(float, Vector3, float\)

Advances the simulation by a single step, updating the state based on the elapsed time and camera direction.

```csharp
Task Step(float deltaTime, Vector3 cameraDirection, float horizontalFOV)
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

