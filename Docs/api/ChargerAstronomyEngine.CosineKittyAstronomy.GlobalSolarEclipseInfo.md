# <a id="ChargerAstronomyEngine_CosineKittyAstronomy_GlobalSolarEclipseInfo"></a> Struct GlobalSolarEclipseInfo

Namespace: [ChargerAstronomyEngine.CosineKittyAstronomy](ChargerAstronomyEngine.CosineKittyAstronomy.md)  
Assembly: ChargerAstronomyEngine.dll  

Reports the time and geographic location of the peak of a solar eclipse.

```csharp
public struct GlobalSolarEclipseInfo
```

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Remarks

Returned by #Astronomy.SearchGlobalSolarEclipse or #Astronomy.NextGlobalSolarEclipse
to report information about a solar eclipse event.

The eclipse is classified as partial, annular, or total, depending on the
maximum amount of the Sun's disc obscured, as seen at the peak location
on the surface of the Earth.

The `kind` field thus holds `EclipseKind.Partial`, `EclipseKind.Annular`, or `EclipseKind.Total`.
A total eclipse is when the peak observer sees the Sun completely blocked by the Moon.
An annular eclipse is like a total eclipse, but the Moon is too far from the Earth's surface
to completely block the Sun; instead, the Sun takes on a ring-shaped appearance.
A partial eclipse is when the Moon blocks part of the Sun's disc, but nobody on the Earth
observes either a total or annular eclipse.

If `kind` is `EclipseKind.Total` or `EclipseKind.Annular`, the `latitude` and `longitude`
fields give the geographic coordinates of the center of the Moon's shadow projected
onto the daytime side of the Earth at the instant of the eclipse's peak.
If `kind` has any other value, `latitude` and `longitude` are undefined and should
not be used.

For total or annular eclipses, the `obscuration` field holds the fraction (0, 1]
of the Sun's apparent disc area that is blocked from view by the Moon's silhouette,
as seen by an observer located at the geographic coordinates `latitude`, `longitude`
at the darkest time `peak`. The value will always be 1 for total eclipses, and less than
1 for annular eclipses.
For partial eclipses, `obscuration` is undefined and should not be used.
This is because there is little practical use for an obscuration value of
a partial eclipse without supplying a particular observation location.
Developers who wish to find an obscuration value for partial solar eclipses should therefore use
#Astronomy.SearchLocalSolarEclipse and provide the geographic coordinates of an observer.

## Fields

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_GlobalSolarEclipseInfo_distance"></a> distance

The distance between the Sun/Moon shadow axis and the center of the Earth, in kilometers.

```csharp
public double distance
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_GlobalSolarEclipseInfo_kind"></a> kind

The type of solar eclipse: `EclipseKind.Partial`, `EclipseKind.Annular`, or `EclipseKind.Total`.

```csharp
public EclipseKind kind
```

#### Field Value

 [EclipseKind](ChargerAstronomyEngine.CosineKittyAstronomy.Enums.EclipseKind.md)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_GlobalSolarEclipseInfo_latitude"></a> latitude

The geographic latitude at the center of the peak eclipse shadow.

```csharp
public double latitude
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_GlobalSolarEclipseInfo_longitude"></a> longitude

The geographic longitude at the center of the peak eclipse shadow.

```csharp
public double longitude
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_GlobalSolarEclipseInfo_obscuration"></a> obscuration

The peak fraction of the Sun's apparent disc area obscured by the Moon (total and annular eclipses only).

```csharp
public double obscuration
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_GlobalSolarEclipseInfo_peak"></a> peak

The date and time when the solar eclipse is at its darkest.
This is the instant when the axis of the Moon's shadow cone passes closest to the Earth's center.

```csharp
public AstroTime peak
```

#### Field Value

 [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

