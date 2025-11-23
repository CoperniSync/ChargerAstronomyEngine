# <a id="ChargerAstronomyEngine_Data_LocalObjects_SunSingleton"></a> Class SunSingleton

Namespace: [ChargerAstronomyEngine.Data.LocalObjects](ChargerAstronomyEngine.Data.LocalObjects.md)  
Assembly: ChargerAstronomyEngine.dll  

```csharp
public sealed class SunSingleton : EquatorialCelestialBody
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[EquatorialCelestialBody](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md) ← 
[SunSingleton](ChargerAstronomyEngine.Data.LocalObjects.SunSingleton.md)

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

### <a id="ChargerAstronomyEngine_Data_LocalObjects_SunSingleton_CurrentTime"></a> CurrentTime

```csharp
public DateTime CurrentTime { get; }
```

#### Property Value

 [DateTime](https://learn.microsoft.com/dotnet/api/system.datetime)

### <a id="ChargerAstronomyEngine_Data_LocalObjects_SunSingleton_Instance"></a> Instance

```csharp
public static SunSingleton Instance { get; }
```

#### Property Value

 [SunSingleton](ChargerAstronomyEngine.Data.LocalObjects.SunSingleton.md)

## Methods

### <a id="ChargerAstronomyEngine_Data_LocalObjects_SunSingleton_CreateSun"></a> CreateSun\(\)

Creates and returns a HorizontalMoon object using the current observer and time.
Updates the inherited properties from EquatorialCelestialBody.

```csharp
public HorizontalSun CreateSun()
```

#### Returns

 [HorizontalSun](ChargerAstronomyShared.Domain.Horizontal.HorizontalSun.md)

