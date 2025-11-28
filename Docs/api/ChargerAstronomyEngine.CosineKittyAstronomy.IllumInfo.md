# <a id="ChargerAstronomyEngine_CosineKittyAstronomy_IllumInfo"></a> Struct IllumInfo

Namespace: [ChargerAstronomyEngine.CosineKittyAstronomy](ChargerAstronomyEngine.CosineKittyAstronomy.md)  
Assembly: ChargerAstronomyEngine.dll  

Information about the brightness and illuminated shape of a celestial body.

```csharp
public struct IllumInfo
```

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Remarks

Returned by the functions #Astronomy.Illumination and #Astronomy.SearchPeakMagnitude
to report the visual magnitude and illuminated fraction of a celestial body at a given date and time.

## Fields

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_IllumInfo_helio_dist"></a> helio\_dist

The distance between the Sun and the body at the observation time.

```csharp
public readonly double helio_dist
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_IllumInfo_mag"></a> mag

The visual magnitude of the body. Smaller values are brighter.

```csharp
public readonly double mag
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_IllumInfo_phase_angle"></a> phase\_angle

The angle in degrees between the Sun and the Earth, as seen from the body. Indicates the body's phase as seen from the Earth.

```csharp
public readonly double phase_angle
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_IllumInfo_phase_fraction"></a> phase\_fraction

A value in the range [0.0, 1.0] indicating what fraction of the body's apparent disc is illuminated, as seen from the Earth.

```csharp
public readonly double phase_fraction
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_IllumInfo_ring_tilt"></a> ring\_tilt

For Saturn, the tilt angle in degrees of its rings as seen from Earth. For all other bodies, 0.

```csharp
public readonly double ring_tilt
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_IllumInfo_time"></a> time

The date and time of the observation.

```csharp
public readonly AstroTime time
```

#### Field Value

 [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

