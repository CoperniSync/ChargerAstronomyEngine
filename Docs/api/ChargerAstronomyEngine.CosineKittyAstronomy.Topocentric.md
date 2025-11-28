# <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Topocentric"></a> Struct Topocentric

Namespace: [ChargerAstronomyEngine.CosineKittyAstronomy](ChargerAstronomyEngine.CosineKittyAstronomy.md)  
Assembly: ChargerAstronomyEngine.dll  

Coordinates of a celestial body as seen by a topocentric observer.

```csharp
public struct Topocentric
```

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Remarks

Contains horizontal and equatorial coordinates seen by an observer on or near
the surface of the Earth (a topocentric observer).
Optionally corrected for atmospheric refraction.

## Fields

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Topocentric_altitude"></a> altitude

Angle in degrees above (positive) or below (negative) the observer's horizon.

```csharp
public readonly double altitude
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Topocentric_azimuth"></a> azimuth

Compass direction around the horizon in degrees. 0=North, 90=East, 180=South, 270=West.

```csharp
public readonly double azimuth
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Topocentric_dec"></a> dec

Declination in degrees.

```csharp
public readonly double dec
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Topocentric_ra"></a> ra

Right ascension in sidereal hours.

```csharp
public readonly double ra
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

