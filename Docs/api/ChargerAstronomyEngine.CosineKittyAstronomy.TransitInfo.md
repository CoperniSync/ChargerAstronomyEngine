# <a id="ChargerAstronomyEngine_CosineKittyAstronomy_TransitInfo"></a> Struct TransitInfo

Namespace: [ChargerAstronomyEngine.CosineKittyAstronomy](ChargerAstronomyEngine.CosineKittyAstronomy.md)  
Assembly: ChargerAstronomyEngine.dll  

Information about a transit of Mercury or Venus, as seen from the Earth.

```csharp
public struct TransitInfo
```

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Remarks

Returned by #Astronomy.SearchTransit or #Astronomy.NextTransit to report
information about a transit of Mercury or Venus.
A transit is when Mercury or Venus passes between the Sun and Earth so that
the other planet is seen in silhouette against the Sun.

The `start` field reports the moment in time when the planet first becomes
visible against the Sun in its background.
The `peak` field reports when the planet is most aligned with the Sun,
as seen from the Earth.
The `finish` field reports the last moment when the planet is visible
against the Sun in its background.

The calculations are performed from the point of view of a geocentric observer.

## Fields

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_TransitInfo_finish"></a> finish

Date and time at the end of the transit.

```csharp
public AstroTime finish
```

#### Field Value

 [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_TransitInfo_peak"></a> peak

Date and time of the peak of the transit.

```csharp
public AstroTime peak
```

#### Field Value

 [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_TransitInfo_separation"></a> separation

Angular separation in arcminutes between the centers of the Sun and the planet at time `peak`.

```csharp
public double separation
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_TransitInfo_start"></a> start

Date and time at the beginning of the transit.

```csharp
public AstroTime start
```

#### Field Value

 [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

