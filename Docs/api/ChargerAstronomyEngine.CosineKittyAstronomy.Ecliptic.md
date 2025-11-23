# <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Ecliptic"></a> Struct Ecliptic

Namespace: [ChargerAstronomyEngine.CosineKittyAstronomy](ChargerAstronomyEngine.CosineKittyAstronomy.md)  
Assembly: ChargerAstronomyEngine.dll  

Ecliptic angular and Cartesian coordinates.

```csharp
public struct Ecliptic
```

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Remarks

Coordinates of a celestial body as seen from the center of the Sun (heliocentric),
oriented with respect to the plane of the Earth's orbit around the Sun (the ecliptic).

## Fields

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Ecliptic_elat"></a> elat

Latitude in degrees north (positive) or south (negative) of the ecliptic plane.

```csharp
public readonly double elat
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Ecliptic_elon"></a> elon

Longitude in degrees around the ecliptic plane prograde from the equinox.

```csharp
public readonly double elon
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Ecliptic_vec"></a> vec

Cartesian ecliptic vector, with components as follows:
x: the direction of the equinox along the ecliptic plane.
y: in the ecliptic plane 90 degrees prograde from the equinox.
z: perpendicular to the ecliptic plane. Positive is north.

```csharp
public readonly AstroVector vec
```

#### Field Value

 [AstroVector](ChargerAstronomyEngine.CosineKittyAstronomy.AstroVector.md)

