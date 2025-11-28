# <a id="ChargerAstronomyShared_Domain_Horizontal_HorizontalMessierObject"></a> Class HorizontalMessierObject

Namespace: [ChargerAstronomyShared.Domain.Horizontal](ChargerAstronomyShared.Domain.Horizontal.md)  
Assembly: ChargerAstronomyShared.dll  

A Messier Deep Space Object located in Horizontal coordinates
Author: Josh Johner
Created: SPR 2025

```csharp
public class HorizontalMessierObject : HorizontalBody
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[EquatorialCelestialBody](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md) ← 
[HorizontalBody](ChargerAstronomyShared.Domain.Horizontal.HorizontalBody.md) ← 
[HorizontalMessierObject](ChargerAstronomyShared.Domain.Horizontal.HorizontalMessierObject.md)

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

### <a id="ChargerAstronomyShared_Domain_Horizontal_HorizontalMessierObject__ctor_ChargerAstronomyShared_Domain_Equatorial_EquatorialMessierObject_"></a> HorizontalMessierObject\(EquatorialMessierObject\)

Creates a new object by wrapping a <xref href="ChargerAstronomyShared.Domain.Equatorial.EquatorialMessierObject" data-throw-if-not-resolved="false"></xref>

```csharp
public HorizontalMessierObject(EquatorialMessierObject body)
```

#### Parameters

`body` [EquatorialMessierObject](ChargerAstronomyShared.Domain.Equatorial.EquatorialMessierObject.md)

The <xref href="ChargerAstronomyShared.Domain.Equatorial.EquatorialMessierObject" data-throw-if-not-resolved="false"></xref> to base this object off of.

## Properties

### <a id="ChargerAstronomyShared_Domain_Horizontal_HorizontalMessierObject_CommonName"></a> CommonName

<xref href="ChargerAstronomyShared.Domain.Equatorial.EquatorialMessierObject.CommonName" data-throw-if-not-resolved="false"></xref>

```csharp
public string? CommonName { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="ChargerAstronomyShared_Domain_Horizontal_HorizontalMessierObject_Constellation"></a> Constellation

<xref href="ChargerAstronomyShared.Domain.Equatorial.EquatorialMessierObject.Constellation" data-throw-if-not-resolved="false"></xref>

```csharp
public string? Constellation { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="ChargerAstronomyShared_Domain_Horizontal_HorizontalMessierObject_MessierId"></a> MessierId

<xref href="ChargerAstronomyShared.Domain.Equatorial.EquatorialMessierObject.MessierId" data-throw-if-not-resolved="false"></xref>

```csharp
public string? MessierId { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="ChargerAstronomyShared_Domain_Horizontal_HorizontalMessierObject_NewGeneralCatalog"></a> NewGeneralCatalog

<xref href="ChargerAstronomyShared.Domain.Equatorial.EquatorialMessierObject.NewGeneralCatalog" data-throw-if-not-resolved="false"></xref>

```csharp
public string? NewGeneralCatalog { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="ChargerAstronomyShared_Domain_Horizontal_HorizontalMessierObject_Size"></a> Size

<xref href="ChargerAstronomyShared.Domain.Equatorial.EquatorialMessierObject.Size" data-throw-if-not-resolved="false"></xref>

```csharp
public string? Size { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="ChargerAstronomyShared_Domain_Horizontal_HorizontalMessierObject_Type"></a> Type

<xref href="ChargerAstronomyShared.Domain.Equatorial.EquatorialMessierObject.Type" data-throw-if-not-resolved="false"></xref>

```csharp
public string? Type { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="ChargerAstronomyShared_Domain_Horizontal_HorizontalMessierObject_ViewingDifficulty"></a> ViewingDifficulty

<xref href="ChargerAstronomyShared.Domain.Equatorial.EquatorialMessierObject.ViewingDifficulty" data-throw-if-not-resolved="false"></xref>

```csharp
public string? ViewingDifficulty { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="ChargerAstronomyShared_Domain_Horizontal_HorizontalMessierObject_ViewingSeason"></a> ViewingSeason

<xref href="ChargerAstronomyShared.Domain.Equatorial.EquatorialMessierObject.ViewingSeason" data-throw-if-not-resolved="false"></xref>

```csharp
public string? ViewingSeason { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

