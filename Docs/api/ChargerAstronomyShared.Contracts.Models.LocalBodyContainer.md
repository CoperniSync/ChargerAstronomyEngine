# <a id="ChargerAstronomyShared_Contracts_Models_LocalBodyContainer"></a> Class LocalBodyContainer

Namespace: [ChargerAstronomyShared.Contracts.Models](ChargerAstronomyShared.Contracts.Models.md)  
Assembly: ChargerAstronomyShared.dll  

A container for horizontal instances of local celestial bodies.

```csharp
public class LocalBodyContainer
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[LocalBodyContainer](ChargerAstronomyShared.Contracts.Models.LocalBodyContainer.md)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="ChargerAstronomyShared_Contracts_Models_LocalBodyContainer__ctor_ChargerAstronomyShared_Domain_Horizontal_HorizontalMoon_ChargerAstronomyShared_Domain_Horizontal_HorizontalSun_System_Collections_Generic_List_ChargerAstronomyShared_Domain_Horizontal_HorizontalPlanet__"></a> LocalBodyContainer\(HorizontalMoon, HorizontalSun, List<HorizontalPlanet\>\)

Creates a new instance and sets celestial bodies.

```csharp
public LocalBodyContainer(HorizontalMoon newMoon, HorizontalSun newSun, List<HorizontalPlanet> newPlanets)
```

#### Parameters

`newMoon` [HorizontalMoon](ChargerAstronomyShared.Domain.Horizontal.HorizontalMoon.md)

The <xref href="ChargerAstronomyShared.Domain.Horizontal.HorizontalMoon" data-throw-if-not-resolved="false"></xref> instance representing the Moon.

`newSun` [HorizontalSun](ChargerAstronomyShared.Domain.Horizontal.HorizontalSun.md)

The <xref href="ChargerAstronomyShared.Domain.Horizontal.HorizontalSun" data-throw-if-not-resolved="false"></xref> instance representing the Sun.

`newPlanets` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[HorizontalPlanet](ChargerAstronomyShared.Domain.Horizontal.HorizontalPlanet.md)\>

A list of <xref href="ChargerAstronomyShared.Domain.Horizontal.HorizontalPlanet" data-throw-if-not-resolved="false"></xref> objects representing the planets.  This list must not be null.

## Properties

### <a id="ChargerAstronomyShared_Contracts_Models_LocalBodyContainer_moon"></a> moon

A horizontal instance of the Moon.

```csharp
public HorizontalMoon moon { get; }
```

#### Property Value

 [HorizontalMoon](ChargerAstronomyShared.Domain.Horizontal.HorizontalMoon.md)

### <a id="ChargerAstronomyShared_Contracts_Models_LocalBodyContainer_planets"></a> planets

A list of horizontal planets instances.

```csharp
public List<HorizontalPlanet> planets { get; }
```

#### Property Value

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[HorizontalPlanet](ChargerAstronomyShared.Domain.Horizontal.HorizontalPlanet.md)\>

### <a id="ChargerAstronomyShared_Contracts_Models_LocalBodyContainer_sun"></a> sun

A horizontal instance of the Sun.

```csharp
public HorizontalSun sun { get; }
```

#### Property Value

 [HorizontalSun](ChargerAstronomyShared.Domain.Horizontal.HorizontalSun.md)

