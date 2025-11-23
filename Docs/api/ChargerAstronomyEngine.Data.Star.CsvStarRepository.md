# <a id="ChargerAstronomyEngine_Data_Star_CsvStarRepository"></a> Class CsvStarRepository

Namespace: [ChargerAstronomyEngine.Data.Star](ChargerAstronomyEngine.Data.Star.md)  
Assembly: ChargerAstronomyEngine.dll  

```csharp
public sealed class CsvStarRepository : IStarRepository
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CsvStarRepository](ChargerAstronomyEngine.Data.Star.CsvStarRepository.md)

#### Implements

[IStarRepository](ChargerAstronomyShared.Contracts.Repositories.IStarRepository.md)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="ChargerAstronomyEngine_Data_Star_CsvStarRepository__ctor_System_String_"></a> CsvStarRepository\(string\)

A repository of stars loaded from a CSV file.

```csharp
public CsvStarRepository(string csvPath)
```

#### Parameters

`csvPath` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Exceptions

 [ArgumentException](https://learn.microsoft.com/dotnet/api/system.argumentexception)

## Methods

### <a id="ChargerAstronomyEngine_Data_Star_CsvStarRepository_GetAllAsync_ChargerAstronomyShared_Contracts_Models_PageRequest_"></a> GetAllAsync\(PageRequest\)

Not implemented.

```csharp
public Task<PageResult<EquatorialStar>> GetAllAsync(PageRequest page)
```

#### Parameters

`page` [PageRequest](ChargerAstronomyShared.Contracts.Models.PageRequest.md)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[PageResult](ChargerAstronomyShared.Contracts.Models.PageResult\-1.md)<[EquatorialStar](ChargerAstronomyShared.Domain.Equatorial.EquatorialStar.md)\>\>

### <a id="ChargerAstronomyEngine_Data_Star_CsvStarRepository_GetAllSync_System_Threading_CancellationToken_"></a> GetAllSync\(CancellationToken\)

Provides a synchronous way to get all stars from the CSV file.
Used for testing only.

```csharp
public IEnumerable<EquatorialStar> GetAllSync(CancellationToken cancellationToken = default)
```

#### Parameters

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[EquatorialStar](ChargerAstronomyShared.Domain.Equatorial.EquatorialStar.md)\>

#### Exceptions

 [ArgumentException](https://learn.microsoft.com/dotnet/api/system.argumentexception)

 [FileNotFoundException](https://learn.microsoft.com/dotnet/api/system.io.filenotfoundexception)

### <a id="ChargerAstronomyEngine_Data_Star_CsvStarRepository_GetStarByIdAsync_System_Int32_"></a> GetStarByIdAsync\(int\)

Not implemented.

```csharp
public Task<EquatorialStar> GetStarByIdAsync(int id)
```

#### Parameters

`id` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[EquatorialStar](ChargerAstronomyShared.Domain.Equatorial.EquatorialStar.md)\>

### <a id="ChargerAstronomyEngine_Data_Star_CsvStarRepository_ProducePagesAsync_ChargerAstronomyShared_Contracts_Streaming_BlockingQueue_ChargerAstronomyShared_Contracts_Models_PageResult_ChargerAstronomyShared_Domain_Equatorial_EquatorialStar___ChargerAstronomyShared_Contracts_Models_PageRequest_System_Threading_CancellationToken_"></a> ProducePagesAsync\(BlockingQueue<PageResult<EquatorialStar\>\>, PageRequest, CancellationToken\)

Produces pages of stars into the provided queue, starting from the first PageRequest.

```csharp
public Task ProducePagesAsync(BlockingQueue<PageResult<EquatorialStar>> queue, PageRequest firstPage, CancellationToken cancellationToken = default)
```

#### Parameters

`queue` [BlockingQueue](ChargerAstronomyShared.Contracts.Streaming.BlockingQueue\-1.md)<[PageResult](ChargerAstronomyShared.Contracts.Models.PageResult\-1.md)<[EquatorialStar](ChargerAstronomyShared.Domain.Equatorial.EquatorialStar.md)\>\>

`firstPage` [PageRequest](ChargerAstronomyShared.Contracts.Models.PageRequest.md)

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

#### Exceptions

 [ArgumentNullException](https://learn.microsoft.com/dotnet/api/system.argumentnullexception)

 [ArgumentException](https://learn.microsoft.com/dotnet/api/system.argumentexception)

### <a id="ChargerAstronomyEngine_Data_Star_CsvStarRepository_QueryBySkyRegionAsync_ChargerAstronomyShared_Contracts_Models_SkyRegion_ChargerAstronomyShared_Contracts_Models_PageRequest_"></a> QueryBySkyRegionAsync\(SkyRegion, PageRequest\)

Not implemented.

```csharp
public Task<PageResult<EquatorialStar>> QueryBySkyRegionAsync(SkyRegion skyRegion, PageRequest page)
```

#### Parameters

`skyRegion` [SkyRegion](ChargerAstronomyShared.Contracts.Models.SkyRegion.md)

`page` [PageRequest](ChargerAstronomyShared.Contracts.Models.PageRequest.md)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[PageResult](ChargerAstronomyShared.Contracts.Models.PageResult\-1.md)<[EquatorialStar](ChargerAstronomyShared.Domain.Equatorial.EquatorialStar.md)\>\>

