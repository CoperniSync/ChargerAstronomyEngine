# <a id="ChargerAstronomyEngine_CosineKittyAstronomy_LocalSolarEclipseInfo"></a> Struct LocalSolarEclipseInfo

Namespace: [ChargerAstronomyEngine.CosineKittyAstronomy](ChargerAstronomyEngine.CosineKittyAstronomy.md)  
Assembly: ChargerAstronomyEngine.dll  

Information about a solar eclipse as seen by an observer at a given time and geographic location.

```csharp
public struct LocalSolarEclipseInfo
```

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Remarks

Returned by #Astronomy.SearchLocalSolarEclipse or #Astronomy.NextLocalSolarEclipse
to report information about a solar eclipse as seen at a given geographic location.

When a solar eclipse is found, it is classified as partial, annular, or total.
The `kind` field thus holds `EclipseKind.Partial`, `EclipseKind.Annular`, or `EclipseKind.Total`.
A partial solar eclipse is when the Moon does not line up directly enough with the Sun
to completely block the Sun's light from reaching the observer.
An annular eclipse occurs when the Moon's disc is completely visible against the Sun
but the Moon is too far away to completely block the Sun's light; this leaves the
Sun with a ring-like appearance.
A total eclipse occurs when the Moon is close enough to the Earth and aligned with the
Sun just right to completely block all sunlight from reaching the observer.

The `obscuration` field reports what fraction of the Sun's disc appears blocked
by the Moon when viewed by the observer at the peak eclipse time.
This is a value that ranges from 0 (no blockage) to 1 (total eclipse).
The obscuration value will be between 0 and 1 for partial eclipses and annular eclipses.
The value will be exactly 1 for total eclipses. Obscuration gives an indication
of how dark the eclipse appears.

There are 5 "event" fields, each of which contains a time and a solar altitude.
Field `peak` holds the date and time of the center of the eclipse, when it is at its peak.
The fields `partial_begin` and `partial_end` are always set, and indicate when
the eclipse begins/ends. If the eclipse reaches totality or becomes annular,
`total_begin` and `total_end` indicate when the total/annular phase begins/ends.
When an event field is valid, the caller must also check its `altitude` field to
see whether the Sun is above the horizon at the time indicated by the `time` field.
See #EclipseEvent for more information.

## Fields

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_LocalSolarEclipseInfo_kind"></a> kind

The type of solar eclipse: `EclipseKind.Partial`, `EclipseKind.Annular`, or `EclipseKind.Total`.

```csharp
public EclipseKind kind
```

#### Field Value

 [EclipseKind](ChargerAstronomyEngine.CosineKittyAstronomy.Enums.EclipseKind.md)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_LocalSolarEclipseInfo_obscuration"></a> obscuration

The fraction of the Sun's apparent disc area obscured by the Moon at the eclipse peak.

```csharp
public double obscuration
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_LocalSolarEclipseInfo_partial_begin"></a> partial\_begin

The time and Sun altitude at the beginning of the eclipse.

```csharp
public EclipseEvent partial_begin
```

#### Field Value

 [EclipseEvent](ChargerAstronomyEngine.CosineKittyAstronomy.EclipseEvent.md)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_LocalSolarEclipseInfo_partial_end"></a> partial\_end

The time and Sun altitude at the end of the eclipse.

```csharp
public EclipseEvent partial_end
```

#### Field Value

 [EclipseEvent](ChargerAstronomyEngine.CosineKittyAstronomy.EclipseEvent.md)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_LocalSolarEclipseInfo_peak"></a> peak

The time and Sun altitude when the eclipse reaches its peak.

```csharp
public EclipseEvent peak
```

#### Field Value

 [EclipseEvent](ChargerAstronomyEngine.CosineKittyAstronomy.EclipseEvent.md)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_LocalSolarEclipseInfo_total_begin"></a> total\_begin

If this is an annular or a total eclipse, the time and Sun altitude when annular/total phase begins; otherwise invalid.

```csharp
public EclipseEvent total_begin
```

#### Field Value

 [EclipseEvent](ChargerAstronomyEngine.CosineKittyAstronomy.EclipseEvent.md)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_LocalSolarEclipseInfo_total_end"></a> total\_end

If this is an annular or a total eclipse, the time and Sun altitude when annular/total phase ends; otherwise invalid.

```csharp
public EclipseEvent total_end
```

#### Field Value

 [EclipseEvent](ChargerAstronomyEngine.CosineKittyAstronomy.EclipseEvent.md)

