# <a id="Assets_Scripts_CelestialBodies_Constellations_ConstellationSegment"></a> Class ConstellationSegment

Namespace: [Assets.Scripts.CelestialBodies.Constellations](Assets.Scripts.CelestialBodies.Constellations.md)  
Assembly: Assembly\-CSharp.dll  

Class that represents a line segment made between two Stars

```csharp
public class ConstellationSegment
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ConstellationSegment](Assets.Scripts.CelestialBodies.Constellations.ConstellationSegment.md)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="Assets_Scripts_CelestialBodies_Constellations_ConstellationSegment__ctor_Assets_Scripts_CelestialBodies_Star_Assets_Scripts_CelestialBodies_Star_ChargerAstronomyShared_Contracts_Repositories_IEngineService_ChargerAstronomyShared_Contracts_Models_IHorizontal__"></a> ConstellationSegment\(Star, Star, IEngineService<IHorizontal\>\)

Constructs a line segment based upon two stars

```csharp
public ConstellationSegment(Star starA, Star starB, IEngineService<IHorizontal> engineIn)
```

#### Parameters

`starA` [Star](Assets.Scripts.CelestialBodies.Star.md)

The star at the first endpoint of the segemnt

`starB` [Star](Assets.Scripts.CelestialBodies.Star.md)

The star at the second endpoint of the segemnt

`engineIn` IEngineService<IHorizontal\>

### <a id="Assets_Scripts_CelestialBodies_Constellations_ConstellationSegment__ctor_Assets_Scripts_CelestialBodies_Star_Assets_Scripts_CelestialBodies_Star_ChargerAstronomyShared_Contracts_Repositories_IEngineService_ChargerAstronomyShared_Contracts_Models_IHorizontal__System_String_"></a> ConstellationSegment\(Star, Star, IEngineService<IHorizontal\>, string\)

Constructs a line segment based upon two stars

```csharp
public ConstellationSegment(Star starA, Star starB, IEngineService<IHorizontal> engineIn, string name)
```

#### Parameters

`starA` [Star](Assets.Scripts.CelestialBodies.Star.md)

The star at the first endpoint of the segemnt

`starB` [Star](Assets.Scripts.CelestialBodies.Star.md)

The star at the second endpoint of the segemnt

`engineIn` IEngineService<IHorizontal\>

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the GameObject that is created

## Fields

### <a id="Assets_Scripts_CelestialBodies_Constellations_ConstellationSegment_endpoint1"></a> endpoint1

```csharp
public Star endpoint1
```

#### Field Value

 [Star](Assets.Scripts.CelestialBodies.Star.md)

### <a id="Assets_Scripts_CelestialBodies_Constellations_ConstellationSegment_endpoint2"></a> endpoint2

```csharp
public Star endpoint2
```

#### Field Value

 [Star](Assets.Scripts.CelestialBodies.Star.md)

## Methods

### <a id="Assets_Scripts_CelestialBodies_Constellations_ConstellationSegment_GetMidpoint"></a> GetMidpoint\(\)

```csharp
public Vector3 GetMidpoint()
```

#### Returns

 Vector3

### <a id="Assets_Scripts_CelestialBodies_Constellations_ConstellationSegment_IsOnScreen"></a> IsOnScreen\(\)

```csharp
public bool IsOnScreen()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Assets_Scripts_CelestialBodies_Constellations_ConstellationSegment_SetState_System_Boolean_"></a> SetState\(bool\)

```csharp
public void SetState(bool state)
```

#### Parameters

`state` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Assets_Scripts_CelestialBodies_Constellations_ConstellationSegment_UpdatePosition"></a> UpdatePosition\(\)

Update the position and orientation of the segment

```csharp
public void UpdatePosition()
```

### <a id="Assets_Scripts_CelestialBodies_Constellations_ConstellationSegment_addParent_UnityEngine_GameObject_"></a> addParent\(GameObject\)

```csharp
public void addParent(GameObject parent)
```

#### Parameters

`parent` GameObject

