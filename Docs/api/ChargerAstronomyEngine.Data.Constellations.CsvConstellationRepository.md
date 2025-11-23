# <a id="ChargerAstronomyEngine_Data_Constellations_CsvConstellationRepository"></a> Class CsvConstellationRepository

Namespace: [ChargerAstronomyEngine.Data.Constellations](ChargerAstronomyEngine.Data.Constellations.md)  
Assembly: ChargerAstronomyEngine.dll  

Used to retrieve constellation data from the Stellarium Json file.
Author: Josh Johner
Created: SPR 2025

```csharp
public class CsvConstellationRepository : IConstellationRepository
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CsvConstellationRepository](ChargerAstronomyEngine.Data.Constellations.CsvConstellationRepository.md)

#### Implements

[IConstellationRepository](ChargerAstronomyShared.Contracts.Repositories.IConstellationRepository.md)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="ChargerAstronomyEngine_Data_Constellations_CsvConstellationRepository__ctor_System_String_"></a> CsvConstellationRepository\(string\)

Creates a new instance of the repository

```csharp
public CsvConstellationRepository(string repositoryPath)
```

#### Parameters

`repositoryPath` [string](https://learn.microsoft.com/dotnet/api/system.string)

The path to the directory containing the Json file.

## Methods

### <a id="ChargerAstronomyEngine_Data_Constellations_CsvConstellationRepository_GetConstellations"></a> GetConstellations\(\)

Gets all <xref href="ChargerAstronomyShared.Domain.Equatorial.Constellation" data-throw-if-not-resolved="false"></xref>s from the repository.

```csharp
public IEnumerable<Constellation> GetConstellations()
```

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Constellation](ChargerAstronomyShared.Domain.Equatorial.Constellation.md)\>

An <xref href="System.Collections.Generic.IEnumerable%601" data-throw-if-not-resolved="false"></xref> containing graphs of all the constellations.

