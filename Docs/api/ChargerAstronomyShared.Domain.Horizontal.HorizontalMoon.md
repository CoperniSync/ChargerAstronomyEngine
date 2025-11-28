# <a id="ChargerAstronomyShared_Domain_Horizontal_HorizontalMoon"></a> Class HorizontalMoon

Namespace: [ChargerAstronomyShared.Domain.Horizontal](ChargerAstronomyShared.Domain.Horizontal.md)  
Assembly: ChargerAstronomyShared.dll  

Represents the moon in horizontal coordinate form.

```csharp
public class HorizontalMoon : HorizontalBody
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[EquatorialCelestialBody](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md) ← 
[HorizontalBody](ChargerAstronomyShared.Domain.Horizontal.HorizontalBody.md) ← 
[HorizontalMoon](ChargerAstronomyShared.Domain.Horizontal.HorizontalMoon.md)

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

### <a id="ChargerAstronomyShared_Domain_Horizontal_HorizontalMoon__ctor"></a> HorizontalMoon\(\)

Creates a new object by wrapping a <xref href="ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody" data-throw-if-not-resolved="false"></xref>

```csharp
public HorizontalMoon()
```

## Properties

### <a id="ChargerAstronomyShared_Domain_Horizontal_HorizontalMoon_Phase"></a> Phase

A double representing the moon phase from 0° to 360°

```csharp
public double Phase { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

