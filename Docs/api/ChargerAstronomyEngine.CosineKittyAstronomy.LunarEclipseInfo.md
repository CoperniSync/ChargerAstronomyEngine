# <a id="ChargerAstronomyEngine_CosineKittyAstronomy_LunarEclipseInfo"></a> Struct LunarEclipseInfo

Namespace: [ChargerAstronomyEngine.CosineKittyAstronomy](ChargerAstronomyEngine.CosineKittyAstronomy.md)  
Assembly: ChargerAstronomyEngine.dll  

Information about a lunar eclipse.

```csharp
public struct LunarEclipseInfo
```

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Remarks

Returned by #Astronomy.SearchLunarEclipse or #Astronomy.NextLunarEclipse
to report information about a lunar eclipse event.
When a lunar eclipse is found, it is classified as penumbral, partial, or total.
Penumbral eclipses are difficult to observe, because the Moon is only slightly dimmed
by the Earth's penumbra; no part of the Moon touches the Earth's umbra.
Partial eclipses occur when part, but not all, of the Moon touches the Earth's umbra.
Total eclipses occur when the entire Moon passes into the Earth's umbra.

The `kind` field thus holds `EclipseKind.Penumbral`, `EclipseKind.Partial`,
or `EclipseKind.Total`, depending on the kind of lunar eclipse found.

The `obscuration` field holds a value in the range [0, 1] that indicates what fraction
of the Moon's apparent disc area is covered by the Earth's umbra at the eclipse's peak.
This indicates how dark the peak eclipse appears. For penumbral eclipses, the obscuration
is 0, because the Moon does not pass through the Earth's umbra. For partial eclipses,
the obscuration is somewhere between 0 and 1. For total lunar eclipses, the obscuration is 1.

Field `peak` holds the date and time of the center of the eclipse, when it is at its peak.

Fields `sd_penum`, `sd_partial`, and `sd_total` hold the semi-duration of each phase
of the eclipse, which is half of the amount of time the eclipse spends in each
phase (expressed in minutes), or 0 if the eclipse never reaches that phase.
By converting from minutes to days, and subtracting/adding with `peak`, the caller
may determine the date and time of the beginning/end of each eclipse phase.

## Fields

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_LunarEclipseInfo_kind"></a> kind

The type of lunar eclipse found.

```csharp
public EclipseKind kind
```

#### Field Value

 [EclipseKind](ChargerAstronomyEngine.CosineKittyAstronomy.Enums.EclipseKind.md)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_LunarEclipseInfo_obscuration"></a> obscuration

The peak fraction of the Moon's apparent disc that is covered by the Earth's umbra.

```csharp
public double obscuration
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_LunarEclipseInfo_peak"></a> peak

The time of the eclipse at its peak.

```csharp
public AstroTime peak
```

#### Field Value

 [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_LunarEclipseInfo_sd_partial"></a> sd\_partial

The semi-duration of the partial phase in minutes, or 0.0 if none.

```csharp
public double sd_partial
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_LunarEclipseInfo_sd_penum"></a> sd\_penum

The semi-duration of the penumbral phase in minutes.

```csharp
public double sd_penum
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_LunarEclipseInfo_sd_total"></a> sd\_total

The semi-duration of the total phase in minutes, or 0.0 if none.

```csharp
public double sd_total
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

