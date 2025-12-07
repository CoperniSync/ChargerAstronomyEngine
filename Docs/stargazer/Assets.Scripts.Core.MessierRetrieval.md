# <a id="Assets_Scripts_Core_MessierRetrieval"></a> Class MessierRetrieval

Namespace: [Assets.Scripts.Core](Assets.Scripts.Core.md)  
Assembly: Assembly\-CSharp.dll  

```csharp
public class MessierRetrieval
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MessierRetrieval](Assets.Scripts.Core.MessierRetrieval.md)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Methods

### <a id="Assets_Scripts_Core_MessierRetrieval_GetMessier_ChargerAstronomyShared_Contracts_Repositories_IEngineService_ChargerAstronomyShared_Contracts_Models_IHorizontal__System_String_"></a> GetMessier\(IEngineService<IHorizontal\>, string\)

Gets the messier object data from the file

```csharp
public static List<MessierObject> GetMessier(IEngineService<IHorizontal> engineService, string fileName = "messier-catalog.csv")
```

#### Parameters

`engineService` IEngineService<IHorizontal\>

`fileName` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[MessierObject](Assets.Scripts.CelestialBodies.MessierObject.md)\>

a list of all the Messier Objects in the file in type MessierObject

