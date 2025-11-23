# <a id="ChargerAstronomyEngine_Data_LocalObjects_PlanetsSingleton"></a> Class PlanetsSingleton

Namespace: [ChargerAstronomyEngine.Data.LocalObjects](ChargerAstronomyEngine.Data.LocalObjects.md)  
Assembly: ChargerAstronomyEngine.dll  

Singleton class to manage and calculate horizontal positions of all planets (excluding Earth).

```csharp
public sealed class PlanetsSingleton : EquatorialCelestialBody
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[EquatorialCelestialBody](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md) ← 
[PlanetsSingleton](ChargerAstronomyEngine.Data.LocalObjects.PlanetsSingleton.md)

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

## Properties

### <a id="ChargerAstronomyEngine_Data_LocalObjects_PlanetsSingleton_CurrentTime"></a> CurrentTime

```csharp
public DateTime CurrentTime { get; }
```

#### Property Value

 [DateTime](https://learn.microsoft.com/dotnet/api/system.datetime)

### <a id="ChargerAstronomyEngine_Data_LocalObjects_PlanetsSingleton_Instance"></a> Instance

```csharp
public static PlanetsSingleton Instance { get; }
```

#### Property Value

 [PlanetsSingleton](ChargerAstronomyEngine.Data.LocalObjects.PlanetsSingleton.md)

## Methods

### <a id="ChargerAstronomyEngine_Data_LocalObjects_PlanetsSingleton_CreatePlanets"></a> CreatePlanets\(\)

Creates and returns a list of HorizontalPlanet objects for all planets.

```csharp
public IEnumerable<HorizontalPlanet> CreatePlanets()
```

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[HorizontalPlanet](ChargerAstronomyShared.Domain.Horizontal.HorizontalPlanet.md)\>

A list of HorizontalPlanet objects.

