# <a id="ChargerAstronomyShared_Domain_Equatorial_EquatorialCelestialBody"></a> Class EquatorialCelestialBody

Namespace: [ChargerAstronomyShared.Domain.Equatorial](ChargerAstronomyShared.Domain.Equatorial.md)  
Assembly: ChargerAstronomyShared.dll  

A celestial body represented in equatorial coordinates.

```csharp
public abstract class EquatorialCelestialBody
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[EquatorialCelestialBody](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md)

#### Derived

[EquatorialMessierObject](ChargerAstronomyShared.Domain.Equatorial.EquatorialMessierObject.md), 
[EquatorialStar](ChargerAstronomyShared.Domain.Equatorial.EquatorialStar.md), 
[HorizontalBody](ChargerAstronomyShared.Domain.Horizontal.HorizontalBody.md), 
[MoonSingleton](ChargerAstronomyEngine.Data.LocalObjects.MoonSingleton.md), 
[PlanetsSingleton](ChargerAstronomyEngine.Data.LocalObjects.PlanetsSingleton.md), 
[SunSingleton](ChargerAstronomyEngine.Data.LocalObjects.SunSingleton.md)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="ChargerAstronomyShared_Domain_Equatorial_EquatorialCelestialBody__ctor_ChargerAstronomyShared_Domain_Equatorial_BodyType_"></a> EquatorialCelestialBody\(BodyType\)

```csharp
public EquatorialCelestialBody(BodyType body)
```

#### Parameters

`body` [BodyType](ChargerAstronomyShared.Domain.Equatorial.BodyType.md)

## Properties

### <a id="ChargerAstronomyShared_Domain_Equatorial_EquatorialCelestialBody_BodyType"></a> BodyType

```csharp
public BodyType BodyType { get; }
```

#### Property Value

 [BodyType](ChargerAstronomyShared.Domain.Equatorial.BodyType.md)

### <a id="ChargerAstronomyShared_Domain_Equatorial_EquatorialCelestialBody_Declination"></a> Declination

A measure in degrees how far an object is north or south of the celestial equator during the spring equinox of 2000

```csharp
public double Declination { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyShared_Domain_Equatorial_EquatorialCelestialBody_Distance"></a> Distance

Distance in light years from the earth.

```csharp
public double Distance { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyShared_Domain_Equatorial_EquatorialCelestialBody_Magnitude"></a> Magnitude

A logarithmic representation of a star's brightness (negative values being brighter)

```csharp
public double Magnitude { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyShared_Domain_Equatorial_EquatorialCelestialBody_RightAscension"></a> RightAscension

Measured in decimal hours from the point in the sky where the sun crosses the celestial equator during the spring equinox of 2000

```csharp
public double RightAscension { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

