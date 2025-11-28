# <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Equatorial"></a> Struct Equatorial

Namespace: [ChargerAstronomyEngine.CosineKittyAstronomy](ChargerAstronomyEngine.CosineKittyAstronomy.md)  
Assembly: ChargerAstronomyEngine.dll  

Equatorial angular and cartesian coordinates.

```csharp
public struct Equatorial
```

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Remarks

Coordinates of a celestial body as seen from the Earth
(geocentric or topocentric, depending on context),
oriented with respect to the projection of the Earth's equator onto the sky.

## Fields

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Equatorial_dec"></a> dec

Declination in degrees.

```csharp
public readonly double dec
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Equatorial_dist"></a> dist

Distance to the celestial body in AU.

```csharp
public readonly double dist
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Equatorial_ra"></a> ra

Right ascension in sidereal hours.

```csharp
public readonly double ra
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Equatorial_vec"></a> vec

Equatorial coordinates in cartesian vector form: x = March equinox, y = June solstice, z = north.

```csharp
public readonly AstroVector vec
```

#### Field Value

 [AstroVector](ChargerAstronomyEngine.CosineKittyAstronomy.AstroVector.md)

