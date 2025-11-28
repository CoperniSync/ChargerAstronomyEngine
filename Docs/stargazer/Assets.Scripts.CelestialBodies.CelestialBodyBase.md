# <a id="Assets_Scripts_CelestialBodies_CelestialBodyBase"></a> Class CelestialBodyBase

Namespace: [Assets.Scripts.CelestialBodies](Assets.Scripts.CelestialBodies.md)  
Assembly: Assembly\-CSharp.dll  

```csharp
public abstract class CelestialBodyBase
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CelestialBodyBase](Assets.Scripts.CelestialBodies.CelestialBodyBase.md)

#### Derived

[MessierObject](Assets.Scripts.CelestialBodies.MessierObject.md), 
[Moon](Assets.Scripts.CelestialBodies.Moon.md), 
[Planet](Assets.Scripts.CelestialBodies.Planet.md), 
[Star](Assets.Scripts.CelestialBodies.Star.md), 
[Sun](Assets.Scripts.CelestialBodies.Sun.md)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="Assets_Scripts_CelestialBodies_CelestialBodyBase__ctor"></a> CelestialBodyBase\(\)

```csharp
protected CelestialBodyBase()
```

### <a id="Assets_Scripts_CelestialBodies_CelestialBodyBase__ctor_ChargerAstronomyShared_Domain_Horizontal_HorizontalBody_System_Single_"></a> CelestialBodyBase\(HorizontalBody, float\)

```csharp
protected CelestialBodyBase(HorizontalBody horizontal, float drawnDitance = 74)
```

#### Parameters

`horizontal` HorizontalBody

`drawnDitance` [float](https://learn.microsoft.com/dotnet/api/system.single)

## Fields

### <a id="Assets_Scripts_CelestialBodies_CelestialBodyBase_equatorialBody"></a> equatorialBody

```csharp
protected EquatorialCelestialBody equatorialBody
```

#### Field Value

 EquatorialCelestialBody

### <a id="Assets_Scripts_CelestialBodies_CelestialBodyBase_horizontalBody"></a> horizontalBody

```csharp
protected HorizontalBody horizontalBody
```

#### Field Value

 HorizontalBody

## Properties

### <a id="Assets_Scripts_CelestialBodies_CelestialBodyBase_Altitude"></a> Altitude

Rotation from Y=0, in degrees.

```csharp
public float Altitude { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Assets_Scripts_CelestialBodies_CelestialBodyBase_Azimuth"></a> Azimuth

Rotation from North (X+), in degrees

```csharp
public float Azimuth { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Assets_Scripts_CelestialBodies_CelestialBodyBase_Declination"></a> Declination

```csharp
public double Declination { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="Assets_Scripts_CelestialBodies_CelestialBodyBase_Distance"></a> Distance

Distance from (0, 0, 0)

```csharp
public float Distance { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Assets_Scripts_CelestialBodies_CelestialBodyBase_DistanceLy"></a> DistanceLy

```csharp
public double DistanceLy { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="Assets_Scripts_CelestialBodies_CelestialBodyBase_DrawnDistance"></a> DrawnDistance

```csharp
public float DrawnDistance { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Assets_Scripts_CelestialBodies_CelestialBodyBase_Magnitude"></a> Magnitude

```csharp
public double Magnitude { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="Assets_Scripts_CelestialBodies_CelestialBodyBase_RightAscension"></a> RightAscension

```csharp
public double RightAscension { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

## Methods

### <a id="Assets_Scripts_CelestialBodies_CelestialBodyBase_GetLocation"></a> GetLocation\(\)

Converts the Azimuth/Altitude and DrawnDistance into a Unity Vector3 position

```csharp
protected Vector3 GetLocation()
```

#### Returns

 Vector3

### <a id="Assets_Scripts_CelestialBodies_CelestialBodyBase_SetHorizontal_ChargerAstronomyShared_Domain_Horizontal_HorizontalBody_System_Nullable_System_Single__"></a> SetHorizontal\(HorizontalBody, float?\)

```csharp
public void SetHorizontal(HorizontalBody horizontal, float? drawnDistance = null)
```

#### Parameters

`horizontal` HorizontalBody

`drawnDistance` [float](https://learn.microsoft.com/dotnet/api/system.single)?

