# <a id="ChargerAstronomyEngine_CosineKittyAstronomy_AxisInfo"></a> Struct AxisInfo

Namespace: [ChargerAstronomyEngine.CosineKittyAstronomy](ChargerAstronomyEngine.CosineKittyAstronomy.md)  
Assembly: ChargerAstronomyEngine.dll  

Information about a body's rotation axis at a given time.

```csharp
public struct AxisInfo
```

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Remarks

This structure is returned by #Astronomy.RotationAxis to report
the orientation of a body's rotation axis at a given moment in time.
The axis is specified by the direction in space that the body's north pole
points, using angular equatorial coordinates in the J2000 system (EQJ).

Thus `ra` is the right ascension, and `dec` is the declination, of the
body's north pole vector at the given moment in time. The north pole
of a body is defined as the pole that lies on the north side of the
[Solar System's invariable plane](https://en.wikipedia.org/wiki/Invariable_plane),
regardless of the body's direction of rotation.

The `spin` field indicates the angular position of a prime meridian
arbitrarily recommended for the body by the International Astronomical
Union (IAU).

The fields `ra`, `dec`, and `spin` correspond to the variables
α0, δ0, and W, respectively, from
[Report of the IAU Working Group on Cartographic Coordinates and Rotational Elements: 2015](https://astropedia.astrogeology.usgs.gov/download/Docs/WGCCRE/WGCCRE2015reprint.pdf).

The field `north` is a unit vector pointing in the direction of the body's north pole.
It is expressed in the J2000 mean equator system (EQJ).

## Fields

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_AxisInfo_dec"></a> dec

The J2000 declination of the body's north pole direction, in degrees.

```csharp
public double dec
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_AxisInfo_north"></a> north

A J2000 dimensionless unit vector pointing in the direction of the body's north pole.

```csharp
public AstroVector north
```

#### Field Value

 [AstroVector](ChargerAstronomyEngine.CosineKittyAstronomy.AstroVector.md)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_AxisInfo_ra"></a> ra

The J2000 right ascension of the body's north pole direction, in sidereal hours.

```csharp
public double ra
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_AxisInfo_spin"></a> spin

Rotation angle of the body's prime meridian, in degrees.

```csharp
public double spin
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

