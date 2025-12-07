# <a id="Assets_Scripts_Core_StarQueue"></a> Class StarQueue

Namespace: [Assets.Scripts.Core](Assets.Scripts.Core.md)  
Assembly: Assembly\-CSharp.dll  

```csharp
public class StarQueue
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[StarQueue](Assets.Scripts.Core.StarQueue.md)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="Assets_Scripts_Core_StarQueue__ctor_ChargerAstronomyShared_Contracts_Repositories_IEngineService_ChargerAstronomyShared_Contracts_Models_IHorizontal__System_Int32_System_String_"></a> StarQueue\(IEngineService<IHorizontal\>, int, string\)

Construct a new instance of StarQueue and have it start pulling data from the designated repo

```csharp
public StarQueue(IEngineService<IHorizontal> engineService, int amountToTake, string fileName = "AllStars.csv")
```

#### Parameters

`engineService` IEngineService<IHorizontal\>

`amountToTake` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`fileName` [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Assets_Scripts_Core_StarQueue_Dispose"></a> Dispose\(\)

```csharp
public void Dispose()
```

### <a id="Assets_Scripts_Core_StarQueue_IsCompleted"></a> IsCompleted\(\)

```csharp
public bool IsCompleted()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Assets_Scripts_Core_StarQueue_TryDequeue_System_Collections_Generic_List_Assets_Scripts_CelestialBodies_Star___"></a> TryDequeue\(ref List<Star\>\)

A star located by the Horizontal Coordinate method

```csharp
public bool TryDequeue(ref List<Star> starList)
```

#### Parameters

`starList` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[Star](Assets.Scripts.CelestialBodies.Star.md)\>

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

