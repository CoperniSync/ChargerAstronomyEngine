# <a id="ChargerAstronomyShared_Contracts_Models_PageRequest"></a> Class PageRequest

Namespace: [ChargerAstronomyShared.Contracts.Models](ChargerAstronomyShared.Contracts.Models.md)  
Assembly: ChargerAstronomyShared.dll  

A request for a page of data, used in star queues.

```csharp
public sealed class PageRequest
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[PageRequest](ChargerAstronomyShared.Contracts.Models.PageRequest.md)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="ChargerAstronomyShared_Contracts_Models_PageRequest__ctor_System_Int32_System_Int32_"></a> PageRequest\(int, int\)

Initializes a new page request with the specified skip and take values.

```csharp
public PageRequest(int skip = 0, int take = 1000)
```

#### Parameters

`skip` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The number of items to skip. Must be greater than or equal to 0. Defaults to 0.

`take` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The number of items to take. Must be greater than or equal to 0. Defaults to 1000.

#### Remarks

Negatives values for <code class="paramref">skip</code> or <code class="paramref">take</code> will be replaced by 0.

## Properties

### <a id="ChargerAstronomyShared_Contracts_Models_PageRequest_Skip"></a> Skip

The amount of total items to skip.

```csharp
public int Skip { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="ChargerAstronomyShared_Contracts_Models_PageRequest_Take"></a> Take

The amount of items to take, determines the quantity of items in the page.

```csharp
public int Take { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

