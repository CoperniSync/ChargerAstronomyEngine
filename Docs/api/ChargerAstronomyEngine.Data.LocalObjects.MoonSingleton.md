# <a id="ChargerAstronomyEngine_Data_LocalObjects_MoonSingleton"></a> Class MoonSingleton

Namespace: [ChargerAstronomyEngine.Data.LocalObjects](ChargerAstronomyEngine.Data.LocalObjects.md)  
Assembly: ChargerAstronomyEngine.dll  

```csharp
public sealed class MoonSingleton : EquatorialCelestialBody
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[EquatorialCelestialBody](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md) ← 
[MoonSingleton](ChargerAstronomyEngine.Data.LocalObjects.MoonSingleton.md)

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

### <a id="ChargerAstronomyEngine_Data_LocalObjects_MoonSingleton_CurrentTime"></a> CurrentTime

```csharp
public DateTime CurrentTime { get; }
```

#### Property Value

 [DateTime](https://learn.microsoft.com/dotnet/api/system.datetime)

### <a id="ChargerAstronomyEngine_Data_LocalObjects_MoonSingleton_Instance"></a> Instance

```csharp
public static MoonSingleton Instance { get; }
```

#### Property Value

 [MoonSingleton](ChargerAstronomyEngine.Data.LocalObjects.MoonSingleton.md)

## Methods

### <a id="ChargerAstronomyEngine_Data_LocalObjects_MoonSingleton_CreateMoon"></a> CreateMoon\(\)

Creates and returns a HorizontalMoon object using the current observer and time.

```csharp
public HorizontalMoon CreateMoon()
```

#### Returns

 [HorizontalMoon](ChargerAstronomyShared.Domain.Horizontal.HorizontalMoon.md)

