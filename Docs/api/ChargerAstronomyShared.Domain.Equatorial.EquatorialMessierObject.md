# <a id="ChargerAstronomyShared_Domain_Equatorial_EquatorialMessierObject"></a> Class EquatorialMessierObject

Namespace: [ChargerAstronomyShared.Domain.Equatorial](ChargerAstronomyShared.Domain.Equatorial.md)  
Assembly: ChargerAstronomyShared.dll  

```csharp
public sealed class EquatorialMessierObject : EquatorialCelestialBody
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[EquatorialCelestialBody](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md) ← 
[EquatorialMessierObject](ChargerAstronomyShared.Domain.Equatorial.EquatorialMessierObject.md)

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

### <a id="ChargerAstronomyShared_Domain_Equatorial_EquatorialMessierObject__ctor"></a> EquatorialMessierObject\(\)

```csharp
public EquatorialMessierObject()
```

## Properties

### <a id="ChargerAstronomyShared_Domain_Equatorial_EquatorialMessierObject_CommonName"></a> CommonName

The commonly used main of the object

```csharp
public string? CommonName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="ChargerAstronomyShared_Domain_Equatorial_EquatorialMessierObject_Constellation"></a> Constellation

The constellation containing the object

```csharp
public string? Constellation { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="ChargerAstronomyShared_Domain_Equatorial_EquatorialMessierObject_MessierId"></a> MessierId

The 'M' prefixed identification number of the object

```csharp
public string? MessierId { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="ChargerAstronomyShared_Domain_Equatorial_EquatorialMessierObject_NewGeneralCatalog"></a> NewGeneralCatalog

The Messier Object identification in the New General Catalog

```csharp
public string? NewGeneralCatalog { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="ChargerAstronomyShared_Domain_Equatorial_EquatorialMessierObject_Size"></a> Size

The size (in light years) of the object (a 2 dimensional value as viewed)

```csharp
public string? Size { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="ChargerAstronomyShared_Domain_Equatorial_EquatorialMessierObject_Type"></a> Type

The Messier Object category

```csharp
public string? Type { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="ChargerAstronomyShared_Domain_Equatorial_EquatorialMessierObject_ViewingDifficulty"></a> ViewingDifficulty

The difficulty level of viewing the object

```csharp
public string? ViewingDifficulty { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="ChargerAstronomyShared_Domain_Equatorial_EquatorialMessierObject_ViewingSeason"></a> ViewingSeason

The celestial season in which the object can be viewed

```csharp
public string? ViewingSeason { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

