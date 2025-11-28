# <a id="ChargerAstronomyEngine_CosineKittyAstronomy_ApsisInfo"></a> Struct ApsisInfo

Namespace: [ChargerAstronomyEngine.CosineKittyAstronomy](ChargerAstronomyEngine.CosineKittyAstronomy.md)  
Assembly: ChargerAstronomyEngine.dll  

An apsis event: pericenter (closest approach) or apocenter (farthest distance).

```csharp
public struct ApsisInfo
```

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Remarks

For the Moon orbiting the Earth, or a planet orbiting the Sun, an *apsis* is an
event where the orbiting body reaches its closest or farthest point from the primary body.
The closest approach is called *pericenter* and the farthest point is *apocenter*.

More specific terminology is common for particular orbiting bodies.
The Moon's closest approach to the Earth is called *perigee* and its farthest
point is called *apogee*. The closest approach of a planet to the Sun is called
*perihelion* and the furthest point is called *aphelion*.

This data structure is returned by #Astronomy.SearchLunarApsis and #Astronomy.NextLunarApsis
to iterate through consecutive alternating perigees and apogees.

## Fields

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_ApsisInfo_dist_au"></a> dist\_au

The distance between the centers of the bodies in astronomical units.

```csharp
public readonly double dist_au
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_ApsisInfo_dist_km"></a> dist\_km

The distance between the centers of the bodies in kilometers.

```csharp
public readonly double dist_km
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_ApsisInfo_kind"></a> kind

Whether this is a pericenter or apocenter event.

```csharp
public readonly ApsisKind kind
```

#### Field Value

 [ApsisKind](ChargerAstronomyEngine.CosineKittyAstronomy.Enums.ApsisKind.md)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_ApsisInfo_time"></a> time

The date and time of the apsis.

```csharp
public readonly AstroTime time
```

#### Field Value

 [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

