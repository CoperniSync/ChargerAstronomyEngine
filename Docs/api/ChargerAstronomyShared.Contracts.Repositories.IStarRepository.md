# <a id="ChargerAstronomyShared_Contracts_Repositories_IStarRepository"></a> Interface IStarRepository

Namespace: [ChargerAstronomyShared.Contracts.Repositories](ChargerAstronomyShared.Contracts.Repositories.md)  
Assembly: ChargerAstronomyShared.dll  

```csharp
public interface IStarRepository
```

## Methods

### <a id="ChargerAstronomyShared_Contracts_Repositories_IStarRepository_GetAllAsync_ChargerAstronomyShared_Contracts_Models_PageRequest_"></a> GetAllAsync\(PageRequest\)

Not implemented.

```csharp
Task<PageResult<EquatorialStar>> GetAllAsync(PageRequest page)
```

#### Parameters

`page` [PageRequest](ChargerAstronomyShared.Contracts.Models.PageRequest.md)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[PageResult](ChargerAstronomyShared.Contracts.Models.PageResult\-1.md)<[EquatorialStar](ChargerAstronomyShared.Domain.Equatorial.EquatorialStar.md)\>\>

### <a id="ChargerAstronomyShared_Contracts_Repositories_IStarRepository_GetStarByIdAsync_System_Int32_"></a> GetStarByIdAsync\(int\)

Not implemented.

```csharp
Task<EquatorialStar> GetStarByIdAsync(int id)
```

#### Parameters

`id` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[EquatorialStar](ChargerAstronomyShared.Domain.Equatorial.EquatorialStar.md)\>

### <a id="ChargerAstronomyShared_Contracts_Repositories_IStarRepository_ProducePagesAsync_ChargerAstronomyShared_Contracts_Streaming_BlockingQueue_ChargerAstronomyShared_Contracts_Models_PageResult_ChargerAstronomyShared_Domain_Equatorial_EquatorialStar___ChargerAstronomyShared_Contracts_Models_PageRequest_System_Threading_CancellationToken_"></a> ProducePagesAsync\(BlockingQueue<PageResult<EquatorialStar\>\>, PageRequest, CancellationToken\)

Asynchronously produces pages of data and enqueues them into the specified queue.

```csharp
Task ProducePagesAsync(BlockingQueue<PageResult<EquatorialStar>> queue, PageRequest firstPage, CancellationToken cancellationToken = default)
```

#### Parameters

`queue` [BlockingQueue](ChargerAstronomyShared.Contracts.Streaming.BlockingQueue\-1.md)<[PageResult](ChargerAstronomyShared.Contracts.Models.PageResult\-1.md)<[EquatorialStar](ChargerAstronomyShared.Domain.Equatorial.EquatorialStar.md)\>\>

The queue into which the produced pages will be enqueued.

`firstPage` [PageRequest](ChargerAstronomyShared.Contracts.Models.PageRequest.md)

The initial page request that specifies the starting point for producing pages.

`cancellationToken` [CancellationToken](https://learn.microsoft.com/dotnet/api/system.threading.cancellationtoken)

A token to monitor for cancellation requests. The default value is <xref href="System.Threading.CancellationToken.None" data-throw-if-not-resolved="false"></xref>.

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task)

#### Remarks

This method processes the specified <code class="paramref">firstPage</code> and continues
    producing subsequent pages  based on the page's configuration. Pages are enqueued into the <code class="paramref">queue</code> as they are produced. The operation can be canceled by signaling the <code class="paramref">cancellationToken</code>.

### <a id="ChargerAstronomyShared_Contracts_Repositories_IStarRepository_QueryBySkyRegionAsync_ChargerAstronomyShared_Contracts_Models_SkyRegion_ChargerAstronomyShared_Contracts_Models_PageRequest_"></a> QueryBySkyRegionAsync\(SkyRegion, PageRequest\)

Not implemented.

```csharp
Task<PageResult<EquatorialStar>> QueryBySkyRegionAsync(SkyRegion skyRegion, PageRequest page)
```

#### Parameters

`skyRegion` [SkyRegion](ChargerAstronomyShared.Contracts.Models.SkyRegion.md)

`page` [PageRequest](ChargerAstronomyShared.Contracts.Models.PageRequest.md)

#### Returns

 [Task](https://learn.microsoft.com/dotnet/api/system.threading.tasks.task\-1)<[PageResult](ChargerAstronomyShared.Contracts.Models.PageResult\-1.md)<[EquatorialStar](ChargerAstronomyShared.Domain.Equatorial.EquatorialStar.md)\>\>

