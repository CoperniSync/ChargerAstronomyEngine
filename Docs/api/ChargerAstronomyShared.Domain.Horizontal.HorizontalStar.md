# <a id="ChargerAstronomyShared_Domain_Horizontal_HorizontalStar"></a> Class HorizontalStar

Namespace: [ChargerAstronomyShared.Domain.Horizontal](ChargerAstronomyShared.Domain.Horizontal.md)  
Assembly: ChargerAstronomyShared.dll  

A star located by the Horizontal Coordinate method

```csharp
public class HorizontalStar : HorizontalBody
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[EquatorialCelestialBody](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md) ← 
[HorizontalBody](ChargerAstronomyShared.Domain.Horizontal.HorizontalBody.md) ← 
[HorizontalStar](ChargerAstronomyShared.Domain.Horizontal.HorizontalStar.md)

#### Inherited Members

[HorizontalBody.Altitude](ChargerAstronomyShared.Domain.Horizontal.HorizontalBody.md\#ChargerAstronomyShared\_Domain\_Horizontal\_HorizontalBody\_Altitude), 
[HorizontalBody.Azimuth](ChargerAstronomyShared.Domain.Horizontal.HorizontalBody.md\#ChargerAstronomyShared\_Domain\_Horizontal\_HorizontalBody\_Azimuth), 
[EquatorialCelestialBody.RightAscension](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md\#ChargerAstronomyShared\_Domain\_Equatorial\_EquatorialCelestialBody\_RightAscension), 
[EquatorialCelestialBody.Declination](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md\#ChargerAstronomyShared\_Domain\_Equatorial\_EquatorialCelestialBody\_Declination), 
[EquatorialCelestialBody.Magnitude](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md\#ChargerAstronomyShared\_Domain\_Equatorial\_EquatorialCelestialBody\_Magnitude), 
[EquatorialCelestialBody.Distance](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md\#ChargerAstronomyShared\_Domain\_Equatorial\_EquatorialCelestialBody\_Distance), 
[EquatorialCelestialBody.BodyType](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md\#ChargerAstronomyShared\_Domain\_Equatorial\_EquatorialCelestialBody\_BodyType), 
[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="ChargerAstronomyShared_Domain_Horizontal_HorizontalStar__ctor_ChargerAstronomyShared_Domain_Equatorial_EquatorialStar_"></a> HorizontalStar\(EquatorialStar\)

Creates a new object by wrapping an <xref href="ChargerAstronomyShared.Domain.Horizontal.HorizontalStar.EquatorialStar" data-throw-if-not-resolved="false"></xref>

```csharp
public HorizontalStar(EquatorialStar body)
```

#### Parameters

`body` [EquatorialStar](ChargerAstronomyShared.Domain.Equatorial.EquatorialStar.md)

The <xref href="ChargerAstronomyShared.Domain.Horizontal.HorizontalStar.EquatorialStar" data-throw-if-not-resolved="false"></xref> to base this object off of.

## Properties

### <a id="ChargerAstronomyShared_Domain_Horizontal_HorizontalStar_AbsoluteMagnitude"></a> AbsoluteMagnitude

<xref href="ChargerAstronomyShared.Domain.Equatorial.EquatorialStar.AbsoluteMagnitude" data-throw-if-not-resolved="false"></xref>

```csharp
public double? AbsoluteMagnitude { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)?

### <a id="ChargerAstronomyShared_Domain_Horizontal_HorizontalStar_ColorIndex"></a> ColorIndex

<xref href="ChargerAstronomyShared.Domain.Equatorial.EquatorialStar.ColorIndex" data-throw-if-not-resolved="false"></xref>

```csharp
public double? ColorIndex { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)?

### <a id="ChargerAstronomyShared_Domain_Horizontal_HorizontalStar_HipparcosId"></a> HipparcosId

<xref href="ChargerAstronomyShared.Domain.Equatorial.EquatorialStar.HipparcosId" data-throw-if-not-resolved="false"></xref>

```csharp
public int? HipparcosId { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)?

### <a id="ChargerAstronomyShared_Domain_Horizontal_HorizontalStar_Spectrum"></a> Spectrum

<xref href="ChargerAstronomyShared.Domain.Equatorial.EquatorialStar.Spectrum" data-throw-if-not-resolved="false"></xref>

```csharp
public string? Spectrum { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="ChargerAstronomyShared_Domain_Horizontal_HorizontalStar_StarId"></a> StarId

<xref href="ChargerAstronomyShared.Domain.Equatorial.EquatorialStar.StarId" data-throw-if-not-resolved="false"></xref>

```csharp
public int StarId { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="ChargerAstronomyShared_Domain_Horizontal_HorizontalStar_StarName"></a> StarName

<xref href="ChargerAstronomyShared.Domain.Equatorial.EquatorialStar.ProperName" data-throw-if-not-resolved="false"></xref>

```csharp
public string? StarName { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

