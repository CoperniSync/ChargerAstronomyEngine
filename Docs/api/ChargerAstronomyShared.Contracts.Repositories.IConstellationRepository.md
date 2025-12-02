# <a id="ChargerAstronomyShared_Contracts_Repositories_IConstellationRepository"></a> Interface IConstellationRepository

Namespace: [ChargerAstronomyShared.Contracts.Repositories](ChargerAstronomyShared.Contracts.Repositories.md)  
Assembly: ChargerAstronomyShared.dll  

Repository for accessing <xref href="ChargerAstronomyShared.Domain.Equatorial.Constellation" data-throw-if-not-resolved="false"></xref> data.

```csharp
public interface IConstellationRepository
```

## Methods

### <a id="ChargerAstronomyShared_Contracts_Repositories_IConstellationRepository_GetConstellations"></a> GetConstellations\(\)

Gets all <xref href="ChargerAstronomyShared.Domain.Equatorial.Constellation" data-throw-if-not-resolved="false"></xref>s from the repository.

```csharp
IEnumerable<Constellation> GetConstellations()
```

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Constellation](ChargerAstronomyShared.Domain.Equatorial.Constellation.md)\>

An <xref href="System.Collections.Generic.IEnumerable%601" data-throw-if-not-resolved="false"></xref> containing graphs of all the constellations.

