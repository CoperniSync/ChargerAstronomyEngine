# <a id="ChargerAstronomyShared_Contracts_Models_PageResult_1"></a> Class PageResult<T\>

Namespace: [ChargerAstronomyShared.Contracts.Models](ChargerAstronomyShared.Contracts.Models.md)  
Assembly: ChargerAstronomyShared.dll  

The response for a page request, used in star queues.

```csharp
public sealed class PageResult<T>
```

#### Type Parameters

`T` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[PageResult<T\>](ChargerAstronomyShared.Contracts.Models.PageResult\-1.md)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="ChargerAstronomyShared_Contracts_Models_PageResult_1__ctor_System_Collections_Generic_IReadOnlyList__0__System_Int32_System_Int32_System_Int32_"></a> PageResult\(IReadOnlyList<T\>, int, int, int\)

Initializes a new page result with the specified items, total, skip, and take values.

```csharp
public PageResult(IReadOnlyList<T> items, int total, int skip, int take)
```

#### Parameters

`items` [IReadOnlyList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1)<T\>

A read-only list of all items.

`total` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The total amount of items.

`skip` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The amount of items to skip.

`take` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The amount of items to take.

## Properties

### <a id="ChargerAstronomyShared_Contracts_Models_PageResult_1_HasNext"></a> HasNext

Boolean indicating if there is a next page available.

```csharp
public bool HasNext { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="ChargerAstronomyShared_Contracts_Models_PageResult_1_Items"></a> Items

Gets the collection of items in the current list.

```csharp
public IReadOnlyList<T> Items { get; }
```

#### Property Value

 [IReadOnlyList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1)<T\>

### <a id="ChargerAstronomyShared_Contracts_Models_PageResult_1_Skip"></a> Skip

The amount of items to skip.

```csharp
public int Skip { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="ChargerAstronomyShared_Contracts_Models_PageResult_1_Take"></a> Take

The amount of items to take, determines the quantity of items in the page.

```csharp
public int Take { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="ChargerAstronomyShared_Contracts_Models_PageResult_1_Total"></a> Total

Total amount of items available.

```csharp
public int Total { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="ChargerAstronomyShared_Contracts_Models_PageResult_1_NextRequest"></a> NextRequest\(\)

Recursively gets the next page request.

```csharp
public PageRequest NextRequest()
```

#### Returns

 [PageRequest](ChargerAstronomyShared.Contracts.Models.PageRequest.md)

A new PageRequest containing the next page.

