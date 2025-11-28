# <a id="ChargerAstronomyShared_Domain_Equatorial_EquatorialStar"></a> Class EquatorialStar

Namespace: [ChargerAstronomyShared.Domain.Equatorial](ChargerAstronomyShared.Domain.Equatorial.md)  
Assembly: ChargerAstronomyShared.dll  

```csharp
public sealed class EquatorialStar : EquatorialCelestialBody
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[EquatorialCelestialBody](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md) ← 
[EquatorialStar](ChargerAstronomyShared.Domain.Equatorial.EquatorialStar.md)

#### Inherited Members

[EquatorialCelestialBody.RightAscension](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md\#ChargerAstronomyShared\_Domain\_Equatorial\_EquatorialCelestialBody\_RightAscension), 
[EquatorialCelestialBody.Declination](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md\#ChargerAstronomyShared\_Domain\_Equatorial\_EquatorialCelestialBody\_Declination), 
[EquatorialCelestialBody.Magnitude](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md\#ChargerAstronomyShared\_Domain\_Equatorial\_EquatorialCelestialBody\_Magnitude), 
[EquatorialCelestialBody.Distance](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md\#ChargerAstronomyShared\_Domain\_Equatorial\_EquatorialCelestialBody\_Distance), 
[EquatorialCelestialBody.BodyType](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md\#ChargerAstronomyShared\_Domain\_Equatorial\_EquatorialCelestialBody\_BodyType), 
[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="ChargerAstronomyShared_Domain_Equatorial_EquatorialStar__ctor"></a> EquatorialStar\(\)

```csharp
public EquatorialStar()
```

## Properties

### <a id="ChargerAstronomyShared_Domain_Equatorial_EquatorialStar_AbsoluteMagnitude"></a> AbsoluteMagnitude

The actual brightness of the star

```csharp
public double? AbsoluteMagnitude { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)?

### <a id="ChargerAstronomyShared_Domain_Equatorial_EquatorialStar_BayerFlamsteedDesignation"></a> BayerFlamsteedDesignation

A combination of two star-naming systems - Bayer (Greek letter) and Flamsteed (number)

```csharp
public string? BayerFlamsteedDesignation { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="ChargerAstronomyShared_Domain_Equatorial_EquatorialStar_ColorIndex"></a> ColorIndex

Describes the color of a star based on its brightness according to Blue and Visual Green filters.

```csharp
public double? ColorIndex { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)?

### <a id="ChargerAstronomyShared_Domain_Equatorial_EquatorialStar_GlieseId"></a> GlieseId

Unique ID in the Gleise catalog

```csharp
public string? GlieseId { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="ChargerAstronomyShared_Domain_Equatorial_EquatorialStar_HarvardRevisedId"></a> HarvardRevisedId

The unique ID in the Harvard Revised catalog

```csharp
public int? HarvardRevisedId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)?

### <a id="ChargerAstronomyShared_Domain_Equatorial_EquatorialStar_HenryDraperId"></a> HenryDraperId

The unique ID in the Henry Draper catalog

```csharp
public int? HenryDraperId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)?

### <a id="ChargerAstronomyShared_Domain_Equatorial_EquatorialStar_HipparcosId"></a> HipparcosId

The unique ID in the Hipparcos catalog

```csharp
public int? HipparcosId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)?

### <a id="ChargerAstronomyShared_Domain_Equatorial_EquatorialStar_ParallaxMas"></a> ParallaxMas

Parallax in milliarcseconds (mas).
Convert to parsecs: distance_pc = 1000 / ParallaxMas

```csharp
public double? ParallaxMas { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)?

### <a id="ChargerAstronomyShared_Domain_Equatorial_EquatorialStar_ProperMotionDecMasPerYear"></a> ProperMotionDecMasPerYear

Proper motion in Declination, milliarcseconds per year.

```csharp
public double? ProperMotionDecMasPerYear { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)?

### <a id="ChargerAstronomyShared_Domain_Equatorial_EquatorialStar_ProperMotionRaMasPerYear"></a> ProperMotionRaMasPerYear

Proper motion in Right Ascension, milliarcseconds per year.

```csharp
public double? ProperMotionRaMasPerYear { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)?

### <a id="ChargerAstronomyShared_Domain_Equatorial_EquatorialStar_ProperName"></a> ProperName

The international Astronomical Union (IAU) or traditional historical name of the star

```csharp
public string? ProperName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="ChargerAstronomyShared_Domain_Equatorial_EquatorialStar_Spectrum"></a> Spectrum

A value defined by the Harvard classification to categorize stars according to color, temperature and spectral lines

```csharp
public string? Spectrum { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="ChargerAstronomyShared_Domain_Equatorial_EquatorialStar_StarId"></a> StarId

The unique ID in the Yale Star catalog

```csharp
public int StarId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

