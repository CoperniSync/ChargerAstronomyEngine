# <a id="ChargerAstronomyShared_Domain_Horizontal_HorizontalBody"></a> Class HorizontalBody

Namespace: [ChargerAstronomyShared.Domain.Horizontal](ChargerAstronomyShared.Domain.Horizontal.md)  
Assembly: ChargerAstronomyShared.dll  

Represents an object that can be located in the sky according to horizontal coordinates.

```csharp
public abstract class HorizontalBody : EquatorialCelestialBody
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[EquatorialCelestialBody](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md) ← 
[HorizontalBody](ChargerAstronomyShared.Domain.Horizontal.HorizontalBody.md)

#### Derived

[HorizontalMessierObject](ChargerAstronomyShared.Domain.Horizontal.HorizontalMessierObject.md), 
[HorizontalMoon](ChargerAstronomyShared.Domain.Horizontal.HorizontalMoon.md), 
[HorizontalPlanet](ChargerAstronomyShared.Domain.Horizontal.HorizontalPlanet.md), 
[HorizontalStar](ChargerAstronomyShared.Domain.Horizontal.HorizontalStar.md), 
[HorizontalSun](ChargerAstronomyShared.Domain.Horizontal.HorizontalSun.md)

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
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="ChargerAstronomyShared_Domain_Horizontal_HorizontalBody__ctor_ChargerAstronomyShared_Domain_Equatorial_EquatorialCelestialBody_"></a> HorizontalBody\(EquatorialCelestialBody\)

Creates a new object by wrapping a <xref href="ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody" data-throw-if-not-resolved="false"></xref>

```csharp
protected HorizontalBody(EquatorialCelestialBody body)
```

#### Parameters

`body` [EquatorialCelestialBody](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md)

### <a id="ChargerAstronomyShared_Domain_Horizontal_HorizontalBody__ctor_ChargerAstronomyShared_Domain_Equatorial_BodyType_"></a> HorizontalBody\(BodyType\)

```csharp
protected HorizontalBody(BodyType bodyType)
```

#### Parameters

`bodyType` [BodyType](ChargerAstronomyShared.Domain.Equatorial.BodyType.md)

## Properties

### <a id="ChargerAstronomyShared_Domain_Horizontal_HorizontalBody_Altitude"></a> Altitude

The angle in decimal degrees formed between the horizon and the star

```csharp
public double Altitude { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyShared_Domain_Horizontal_HorizontalBody_Azimuth"></a> Azimuth

The angle in decimal degrees formed between due north and the star

```csharp
public double Azimuth { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

