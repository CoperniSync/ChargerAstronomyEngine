# <a id="ChargerAstronomyShared_Contracts_Repositories_IMessierRepository"></a> Interface IMessierRepository

Namespace: [ChargerAstronomyShared.Contracts.Repositories](ChargerAstronomyShared.Contracts.Repositories.md)  
Assembly: ChargerAstronomyShared.dll  

```csharp
public interface IMessierRepository
```

## Methods

### <a id="ChargerAstronomyShared_Contracts_Repositories_IMessierRepository_GetMessierObjects"></a> GetMessierObjects\(\)

Gets all Messier Objects from the repository.

```csharp
IEnumerable<EquatorialMessierObject> GetMessierObjects()
```

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[EquatorialMessierObject](ChargerAstronomyShared.Domain.Equatorial.EquatorialMessierObject.md)\>

A <code>yieldable</code> <xref href="System.Collections.Generic.IEnumerable%601" data-throw-if-not-resolved="false"></xref> that can be lazily loaded when needed.

