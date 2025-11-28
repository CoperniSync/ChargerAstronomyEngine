# <a id="ChargerAstronomyEngine_CosineKittyAstronomy_ElongationInfo"></a> Struct ElongationInfo

Namespace: [ChargerAstronomyEngine.CosineKittyAstronomy](ChargerAstronomyEngine.CosineKittyAstronomy.md)  
Assembly: ChargerAstronomyEngine.dll  

Contains information about the visibility of a celestial body at a given date and time.
See #Astronomy.Elongation for more detailed information about the members of this structure.
See also #Astronomy.SearchMaxElongation for how to search for maximum elongation events.

```csharp
public struct ElongationInfo
```

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Fields

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_ElongationInfo_ecliptic_separation"></a> ecliptic\_separation

The difference between the ecliptic longitudes of the body and the Sun, as seen from the Earth.

```csharp
public readonly double ecliptic_separation
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_ElongationInfo_elongation"></a> elongation

The angle in degrees between the body and the Sun, as seen from the Earth.

```csharp
public readonly double elongation
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_ElongationInfo_time"></a> time

The date and time of the observation.

```csharp
public readonly AstroTime time
```

#### Field Value

 [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_ElongationInfo_visibility"></a> visibility

Whether the body is best seen in the morning or the evening.

```csharp
public readonly Visibility visibility
```

#### Field Value

 [Visibility](ChargerAstronomyEngine.CosineKittyAstronomy.Enums.Visibility.md)

