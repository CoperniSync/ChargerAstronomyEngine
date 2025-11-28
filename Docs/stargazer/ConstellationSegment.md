# <a id="ConstellationSegment"></a> Class ConstellationSegment

Namespace:   
Assembly: Assembly\-CSharp.dll  

Class that represents a line segment made between two Stars

```csharp
public class ConstellationSegment
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ConstellationSegment](ConstellationSegment.md)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="ConstellationSegment__ctor_Assets_Scripts_CelestialBodies_Star_Assets_Scripts_CelestialBodies_Star_"></a> ConstellationSegment\(Star, Star\)

Constructs a line segment based upon two stars

```csharp
public ConstellationSegment(Star starA, Star starB)
```

#### Parameters

`starA` [Star](Assets.Scripts.CelestialBodies.Star.md)

The star at the first endpoint of the segemnt

`starB` [Star](Assets.Scripts.CelestialBodies.Star.md)

The star at the second endpoint of the segemnt

### <a id="ConstellationSegment__ctor_Assets_Scripts_CelestialBodies_Star_Assets_Scripts_CelestialBodies_Star_System_String_"></a> ConstellationSegment\(Star, Star, string\)

Constructs a line segment based upon two stars

```csharp
public ConstellationSegment(Star starA, Star starB, string name)
```

#### Parameters

`starA` [Star](Assets.Scripts.CelestialBodies.Star.md)

The star at the first endpoint of the segemnt

`starB` [Star](Assets.Scripts.CelestialBodies.Star.md)

The star at the second endpoint of the segemnt

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

The name of the GameObject that is created

## Fields

### <a id="ConstellationSegment_endpoint1"></a> endpoint1

```csharp
public Star endpoint1
```

#### Field Value

 [Star](Assets.Scripts.CelestialBodies.Star.md)

### <a id="ConstellationSegment_endpoint2"></a> endpoint2

```csharp
public Star endpoint2
```

#### Field Value

 [Star](Assets.Scripts.CelestialBodies.Star.md)

## Methods

### <a id="ConstellationSegment_SetState_System_Boolean_"></a> SetState\(bool\)

```csharp
public void SetState(bool state)
```

#### Parameters

`state` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="ConstellationSegment_UpdatePosition"></a> UpdatePosition\(\)

Update the position and orientation of the segment

```csharp
public void UpdatePosition()
```

