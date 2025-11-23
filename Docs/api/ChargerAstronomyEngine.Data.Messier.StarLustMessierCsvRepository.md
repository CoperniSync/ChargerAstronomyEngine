# <a id="ChargerAstronomyEngine_Data_Messier_StarLustMessierCsvRepository"></a> Class StarLustMessierCsvRepository

Namespace: [ChargerAstronomyEngine.Data.Messier](ChargerAstronomyEngine.Data.Messier.md)  
Assembly: ChargerAstronomyEngine.dll  

Handles retrieving data from the csv listing of Messier Deep Space Objects retrieved from [Starlust.org](https://starlust.org/messier-catalog/)
If a new repository is used, a new converter that implements the <xref href="ChargerAstronomyShared.Contracts.Repositories.IMessierRepository" data-throw-if-not-resolved="false"></xref> needs to be created for it.
Author: Josh Johner
Created: SPR 2025

```csharp
public sealed class StarLustMessierCsvRepository : IMessierRepository
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[StarLustMessierCsvRepository](ChargerAstronomyEngine.Data.Messier.StarLustMessierCsvRepository.md)

#### Implements

[IMessierRepository](ChargerAstronomyShared.Contracts.Repositories.IMessierRepository.md)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="ChargerAstronomyEngine_Data_Messier_StarLustMessierCsvRepository__ctor_System_String_"></a> StarLustMessierCsvRepository\(string\)

Creates a new object.

```csharp
public StarLustMessierCsvRepository(string repositoryPath)
```

#### Parameters

`repositoryPath` [string](https://learn.microsoft.com/dotnet/api/system.string)

The path to the directory containing the file.

## Methods

### <a id="ChargerAstronomyEngine_Data_Messier_StarLustMessierCsvRepository_GetMessierObjects"></a> GetMessierObjects\(\)

Gets all Messier Objects from the repository.

```csharp
public IEnumerable<EquatorialMessierObject> GetMessierObjects()
```

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[EquatorialMessierObject](ChargerAstronomyShared.Domain.Equatorial.EquatorialMessierObject.md)\>

A <code>yieldable</code> <xref href="System.Collections.Generic.IEnumerable%601" data-throw-if-not-resolved="false"></xref> that can be lazily loaded when needed.

