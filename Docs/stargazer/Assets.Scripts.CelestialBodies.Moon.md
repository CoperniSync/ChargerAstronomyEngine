# <a id="Assets_Scripts_CelestialBodies_Moon"></a> Class Moon

Namespace: [Assets.Scripts.CelestialBodies](Assets.Scripts.CelestialBodies.md)  
Assembly: Assembly\-CSharp.dll  

Represents the Moon in Unity using horizontal coordinates.
Author: Tommy Rodriguez
Created: 2025-10-05

```csharp
public sealed class Moon : CelestialBodyBase
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CelestialBodyBase](Assets.Scripts.CelestialBodies.CelestialBodyBase.md) ← 
[Moon](Assets.Scripts.CelestialBodies.Moon.md)

#### Inherited Members

[CelestialBodyBase.Azimuth](Assets.Scripts.CelestialBodies.CelestialBodyBase.md\#Assets\_Scripts\_CelestialBodies\_CelestialBodyBase\_Azimuth), 
[CelestialBodyBase.Altitude](Assets.Scripts.CelestialBodies.CelestialBodyBase.md\#Assets\_Scripts\_CelestialBodies\_CelestialBodyBase\_Altitude), 
[CelestialBodyBase.Distance](Assets.Scripts.CelestialBodies.CelestialBodyBase.md\#Assets\_Scripts\_CelestialBodies\_CelestialBodyBase\_Distance), 
[CelestialBodyBase.RightAscension](Assets.Scripts.CelestialBodies.CelestialBodyBase.md\#Assets\_Scripts\_CelestialBodies\_CelestialBodyBase\_RightAscension), 
[CelestialBodyBase.Declination](Assets.Scripts.CelestialBodies.CelestialBodyBase.md\#Assets\_Scripts\_CelestialBodies\_CelestialBodyBase\_Declination), 
[CelestialBodyBase.Magnitude](Assets.Scripts.CelestialBodies.CelestialBodyBase.md\#Assets\_Scripts\_CelestialBodies\_CelestialBodyBase\_Magnitude), 
[CelestialBodyBase.DistanceLy](Assets.Scripts.CelestialBodies.CelestialBodyBase.md\#Assets\_Scripts\_CelestialBodies\_CelestialBodyBase\_DistanceLy), 
[CelestialBodyBase.DrawnDistance](Assets.Scripts.CelestialBodies.CelestialBodyBase.md\#Assets\_Scripts\_CelestialBodies\_CelestialBodyBase\_DrawnDistance), 
[CelestialBodyBase.SetHorizontal\(HorizontalBody, float?\)](Assets.Scripts.CelestialBodies.CelestialBodyBase.md\#Assets\_Scripts\_CelestialBodies\_CelestialBodyBase\_SetHorizontal\_ChargerAstronomyShared\_Domain\_Horizontal\_HorizontalBody\_System\_Nullable\_System\_Single\_\_), 
[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="Assets_Scripts_CelestialBodies_Moon__ctor_ChargerAstronomyShared_Domain_Horizontal_HorizontalMoon_System_Single_"></a> Moon\(HorizontalMoon, float\)

Constructor for single Moon instantiation.

```csharp
public Moon(HorizontalMoon hMoon, float drawnDistance = 95)
```

#### Parameters

`hMoon` HorizontalMoon

`drawnDistance` [float](https://learn.microsoft.com/dotnet/api/system.single)

## Properties

### <a id="Assets_Scripts_CelestialBodies_Moon_HorizontalMoon"></a> HorizontalMoon

```csharp
public HorizontalMoon HorizontalMoon { get; }
```

#### Property Value

 HorizontalMoon

### <a id="Assets_Scripts_CelestialBodies_Moon_LocalScale"></a> LocalScale

```csharp
public Vector3 LocalScale { get; }
```

#### Property Value

 Vector3

### <a id="Assets_Scripts_CelestialBodies_Moon_Magnitude"></a> Magnitude

```csharp
public float Magnitude { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Assets_Scripts_CelestialBodies_Moon_PhaseAngle"></a> PhaseAngle

```csharp
public float PhaseAngle { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Assets_Scripts_CelestialBodies_Moon_Position2D"></a> Position2D

```csharp
public Vector2 Position2D { get; }
```

#### Property Value

 Vector2

### <a id="Assets_Scripts_CelestialBodies_Moon_Position3D"></a> Position3D

```csharp
public Vector3 Position3D { get; }
```

#### Property Value

 Vector3

## Methods

### <a id="Assets_Scripts_CelestialBodies_Moon_ApplyHorizontal_ChargerAstronomyShared_Domain_Horizontal_HorizontalMoon_"></a> ApplyHorizontal\(HorizontalMoon\)

Applies updated horizontal coordinates from the Engine.

```csharp
public void ApplyHorizontal(HorizontalMoon hMoon)
```

#### Parameters

`hMoon` HorizontalMoon

### <a id="Assets_Scripts_CelestialBodies_Moon_FromHorizontal_ChargerAstronomyShared_Domain_Horizontal_HorizontalMoon_System_Single_"></a> FromHorizontal\(HorizontalMoon, float\)

One-time initialization from horizontal data.

```csharp
public void FromHorizontal(HorizontalMoon hMoon, float drawnDistance = 95)
```

#### Parameters

`hMoon` HorizontalMoon

`drawnDistance` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Assets_Scripts_CelestialBodies_Moon_UpdatePosition"></a> UpdatePosition\(\)

```csharp
public void UpdatePosition()
```

