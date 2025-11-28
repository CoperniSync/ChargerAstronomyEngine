# <a id="Assets_Scripts_CelestialBodies_Star"></a> Class Star

Namespace: [Assets.Scripts.CelestialBodies](Assets.Scripts.CelestialBodies.md)  
Assembly: Assembly\-CSharp.dll  

A star that converts its celestial coordinates to a Unity position.
Rendered by StarGpuRenderer (no per-star GameObject).

```csharp
public sealed class Star : CelestialBodyBase, IHorizontal
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CelestialBodyBase](Assets.Scripts.CelestialBodies.CelestialBodyBase.md) ← 
[Star](Assets.Scripts.CelestialBodies.Star.md)

#### Implements

IHorizontal

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

### <a id="Assets_Scripts_CelestialBodies_Star__ctor_ChargerAstronomyShared_Domain_Horizontal_HorizontalStar_System_Single_"></a> Star\(HorizontalStar, float\)

```csharp
public Star(HorizontalStar hstar, float drawnDistance = 24)
```

#### Parameters

`hstar` HorizontalStar

`drawnDistance` [float](https://learn.microsoft.com/dotnet/api/system.single)

## Properties

### <a id="Assets_Scripts_CelestialBodies_Star_AllStars"></a> AllStars

```csharp
public static IReadOnlyList<Star> AllStars { get; }
```

#### Property Value

 [IReadOnlyList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1)<[Star](Assets.Scripts.CelestialBodies.Star.md)\>

### <a id="Assets_Scripts_CelestialBodies_Star_DrawnDistance"></a> DrawnDistance

Distance of the star sphere from origin.

```csharp
public float DrawnDistance { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Assets_Scripts_CelestialBodies_Star_HipparcosId"></a> HipparcosId

```csharp
public int HipparcosId { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Assets_Scripts_CelestialBodies_Star_HorizontalBody"></a> HorizontalBody

```csharp
public HorizontalBody HorizontalBody { get; }
```

#### Property Value

 HorizontalBody

### <a id="Assets_Scripts_CelestialBodies_Star_IsVisible"></a> IsVisible

```csharp
public bool IsVisible { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Assets_Scripts_CelestialBodies_Star_LocalScale"></a> LocalScale

```csharp
public Vector3 LocalScale { get; }
```

#### Property Value

 Vector3

### <a id="Assets_Scripts_CelestialBodies_Star_Magnitude"></a> Magnitude

```csharp
public float Magnitude { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Assets_Scripts_CelestialBodies_Star_Position2D"></a> Position2D

```csharp
public Vector2 Position2D { get; }
```

#### Property Value

 Vector2

### <a id="Assets_Scripts_CelestialBodies_Star_Position3D"></a> Position3D

```csharp
public Vector3 Position3D { get; }
```

#### Property Value

 Vector3

### <a id="Assets_Scripts_CelestialBodies_Star_StarName"></a> StarName

```csharp
public string StarName { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Assets_Scripts_CelestialBodies_Star_ApplyHorizontal_ChargerAstronomyShared_Domain_Horizontal_HorizontalStar_"></a> ApplyHorizontal\(HorizontalStar\)

Backend push: apply a fresh HorizontalStar.

```csharp
public void ApplyHorizontal(HorizontalStar hstar)
```

#### Parameters

`hstar` HorizontalStar

### <a id="Assets_Scripts_CelestialBodies_Star_SetState_System_Boolean_"></a> SetState\(bool\)

```csharp
public void SetState(bool state)
```

#### Parameters

`state` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Assets_Scripts_CelestialBodies_Star_ToggleState"></a> ToggleState\(\)

```csharp
public void ToggleState()
```

### <a id="Assets_Scripts_CelestialBodies_Star_UpdatePosition"></a> UpdatePosition\(\)

```csharp
public void UpdatePosition()
```

