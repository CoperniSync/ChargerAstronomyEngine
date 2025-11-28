# <a id="Assets_Scripts_CelestialBodies_Planet"></a> Class Planet

Namespace: [Assets.Scripts.CelestialBodies](Assets.Scripts.CelestialBodies.md)  
Assembly: Assembly\-CSharp.dll  

A planet that converts its celestial coordinates to a Unity position.
Author: Tommy Rodriguez
Created: 2025-10-05

```csharp
public sealed class Planet : CelestialBodyBase
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CelestialBodyBase](Assets.Scripts.CelestialBodies.CelestialBodyBase.md) ← 
[Planet](Assets.Scripts.CelestialBodies.Planet.md)

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

### <a id="Assets_Scripts_CelestialBodies_Planet__ctor_ChargerAstronomyShared_Domain_Horizontal_HorizontalPlanet_System_Single_"></a> Planet\(HorizontalPlanet, float\)

Constructor for queue initialization of planet (like Star and Sun)

```csharp
public Planet(HorizontalPlanet hPlanet, float drawnDistance = 74)
```

#### Parameters

`hPlanet` HorizontalPlanet

`drawnDistance` [float](https://learn.microsoft.com/dotnet/api/system.single)

## Properties

### <a id="Assets_Scripts_CelestialBodies_Planet_HorizontalPlanet"></a> HorizontalPlanet

```csharp
public HorizontalPlanet HorizontalPlanet { get; }
```

#### Property Value

 HorizontalPlanet

### <a id="Assets_Scripts_CelestialBodies_Planet_LocalScale"></a> LocalScale

```csharp
public Vector3 LocalScale { get; }
```

#### Property Value

 Vector3

### <a id="Assets_Scripts_CelestialBodies_Planet_Magnitude"></a> Magnitude

```csharp
public float Magnitude { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Assets_Scripts_CelestialBodies_Planet_PhaseAngle"></a> PhaseAngle

```csharp
public float PhaseAngle { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Assets_Scripts_CelestialBodies_Planet_PlanetName"></a> PlanetName

```csharp
public string PlanetName { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Assets_Scripts_CelestialBodies_Planet_Position2D"></a> Position2D

```csharp
public Vector2 Position2D { get; }
```

#### Property Value

 Vector2

### <a id="Assets_Scripts_CelestialBodies_Planet_Position3D"></a> Position3D

```csharp
public Vector3 Position3D { get; }
```

#### Property Value

 Vector3

## Methods

### <a id="Assets_Scripts_CelestialBodies_Planet_ApplyHorizontal_ChargerAstronomyShared_Domain_Horizontal_HorizontalPlanet_"></a> ApplyHorizontal\(HorizontalPlanet\)

Updates position when the Engine sends a new horizontal state.

```csharp
public void ApplyHorizontal(HorizontalPlanet hPlanet)
```

#### Parameters

`hPlanet` HorizontalPlanet

### <a id="Assets_Scripts_CelestialBodies_Planet_FromHorizontal_ChargerAstronomyShared_Domain_Horizontal_HorizontalPlanet_System_Single_"></a> FromHorizontal\(HorizontalPlanet, float\)

One-time initialization when first instantiated in Unity.

```csharp
public void FromHorizontal(HorizontalPlanet hPlanet, float drawnDistance = 50)
```

#### Parameters

`hPlanet` HorizontalPlanet

`drawnDistance` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Assets_Scripts_CelestialBodies_Planet_ToggleState"></a> ToggleState\(\)

Enable or disable the planet’s GameObject.

```csharp
public void ToggleState()
```

### <a id="Assets_Scripts_CelestialBodies_Planet_UpdatePosition"></a> UpdatePosition\(\)

Update the planet’s world position based on a new HorizontalPlanet snapshot.

```csharp
public void UpdatePosition()
```

