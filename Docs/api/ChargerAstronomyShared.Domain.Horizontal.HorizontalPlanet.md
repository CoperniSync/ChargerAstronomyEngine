# <a id="ChargerAstronomyShared_Domain_Horizontal_HorizontalPlanet"></a> Class HorizontalPlanet

Namespace: [ChargerAstronomyShared.Domain.Horizontal](ChargerAstronomyShared.Domain.Horizontal.md)  
Assembly: ChargerAstronomyShared.dll  

A planet in our solar system in horizontal coordinate form.

```csharp
public class HorizontalPlanet : HorizontalBody
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[EquatorialCelestialBody](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md) ← 
[HorizontalBody](ChargerAstronomyShared.Domain.Horizontal.HorizontalBody.md) ← 
[HorizontalPlanet](ChargerAstronomyShared.Domain.Horizontal.HorizontalPlanet.md)

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

### <a id="ChargerAstronomyShared_Domain_Horizontal_HorizontalPlanet__ctor_ChargerAstronomyShared_Domain_Equatorial_BodyType_System_String_"></a> HorizontalPlanet\(BodyType, string\)

Returns a new planet object

```csharp
public HorizontalPlanet(BodyType body, string Name)
```

#### Parameters

`body` [BodyType](ChargerAstronomyShared.Domain.Equatorial.BodyType.md)

`Name` [string](https://learn.microsoft.com/dotnet/api/system.string)

## Properties

### <a id="ChargerAstronomyShared_Domain_Horizontal_HorizontalPlanet_Name"></a> Name

```csharp
public string Name { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="ChargerAstronomyShared_Domain_Horizontal_HorizontalPlanet_PhaseAngle"></a> PhaseAngle

```csharp
public double PhaseAngle { get; set; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

