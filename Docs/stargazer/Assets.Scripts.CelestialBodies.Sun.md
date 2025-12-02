# <a id="Assets_Scripts_CelestialBodies_Sun"></a> Class Sun

Namespace: [Assets.Scripts.CelestialBodies](Assets.Scripts.CelestialBodies.md)  
Assembly: Assembly\-CSharp.dll  

Represents the Sun as a Unity object using horizontal coordinates.
Author: Tommy Rodriguez
Created: 2025-10-05

```csharp
public sealed class Sun : CelestialBodyBase
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CelestialBodyBase](Assets.Scripts.CelestialBodies.CelestialBodyBase.md) ← 
[Sun](Assets.Scripts.CelestialBodies.Sun.md)

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

### <a id="Assets_Scripts_CelestialBodies_Sun__ctor_ChargerAstronomyShared_Domain_Horizontal_HorizontalSun_System_Single_"></a> Sun\(HorizontalSun, float\)

Constructor for single Sun instantiation.

```csharp
public Sun(HorizontalSun hsun, float drawnDistance = 74)
```

#### Parameters

`hsun` HorizontalSun

`drawnDistance` [float](https://learn.microsoft.com/dotnet/api/system.single)

## Properties

### <a id="Assets_Scripts_CelestialBodies_Sun_Go"></a> Go

```csharp
public GameObject Go { get; }
```

#### Property Value

 GameObject

### <a id="Assets_Scripts_CelestialBodies_Sun_HorizontalSun"></a> HorizontalSun

```csharp
public HorizontalSun HorizontalSun { get; }
```

#### Property Value

 HorizontalSun

### <a id="Assets_Scripts_CelestialBodies_Sun_LocalScale"></a> LocalScale

```csharp
public Vector3 LocalScale { get; }
```

#### Property Value

 Vector3

### <a id="Assets_Scripts_CelestialBodies_Sun_Magnitude"></a> Magnitude

```csharp
public float Magnitude { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Assets_Scripts_CelestialBodies_Sun_Position2D"></a> Position2D

```csharp
public Vector2 Position2D { get; }
```

#### Property Value

 Vector2

### <a id="Assets_Scripts_CelestialBodies_Sun_Position3D"></a> Position3D

```csharp
public Vector3 Position3D { get; }
```

#### Property Value

 Vector3

## Methods

### <a id="Assets_Scripts_CelestialBodies_Sun_ApplyHorizontal_ChargerAstronomyShared_Domain_Horizontal_HorizontalSun_"></a> ApplyHorizontal\(HorizontalSun\)

Applies updated horizontal coordinates from the Engine.

```csharp
public void ApplyHorizontal(HorizontalSun hSun)
```

#### Parameters

`hSun` HorizontalSun

### <a id="Assets_Scripts_CelestialBodies_Sun_FromHorizontal_ChargerAstronomyShared_Domain_Horizontal_HorizontalSun_System_Single_"></a> FromHorizontal\(HorizontalSun, float\)

One-time initialization from horizontal data.

```csharp
public void FromHorizontal(HorizontalSun hSun, float drawnDistance = 100)
```

#### Parameters

`hSun` HorizontalSun

`drawnDistance` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Assets_Scripts_CelestialBodies_Sun_ToggleState"></a> ToggleState\(\)

Show/hide the Sun GameObject.

```csharp
public void ToggleState()
```

### <a id="Assets_Scripts_CelestialBodies_Sun_UpdatePosition"></a> UpdatePosition\(\)

Backend push: apply a fresh HorizontalSun.

```csharp
public void UpdatePosition()
```

