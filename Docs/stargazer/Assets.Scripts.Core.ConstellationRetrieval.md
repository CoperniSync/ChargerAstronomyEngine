# <a id="Assets_Scripts_Core_ConstellationRetrieval"></a> Class ConstellationRetrieval

Namespace: [Assets.Scripts.Core](Assets.Scripts.Core.md)  
Assembly: Assembly\-CSharp.dll  

```csharp
public class ConstellationRetrieval
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ConstellationRetrieval](Assets.Scripts.Core.ConstellationRetrieval.md)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Methods

### <a id="Assets_Scripts_Core_ConstellationRetrieval_GetConstellations_System_Collections_Generic_List_Assets_Scripts_CelestialBodies_Constellations_UnityConstellation___System_Collections_Generic_List_Assets_Scripts_CelestialBodies_Star__ChargerAstronomyShared_Contracts_Repositories_IEngineService_ChargerAstronomyShared_Contracts_Models_IHorizontal__System_Boolean_System_String_"></a> GetConstellations\(ref List<UnityConstellation\>, List<Star\>, IEngineService<IHorizontal\>, bool, string\)

```csharp
public static void GetConstellations(ref List<UnityConstellation> constellationList, List<Star> starList, IEngineService<IHorizontal> engineIn, bool initalState = true, string path = "constellations.json")
```

#### Parameters

`constellationList` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[UnityConstellation](Assets.Scripts.CelestialBodies.Constellations.UnityConstellation.md)\>

`starList` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[Star](Assets.Scripts.CelestialBodies.Star.md)\>

`engineIn` IEngineService<IHorizontal\>

`initalState` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`path` [string](https://learn.microsoft.com/dotnet/api/system.string)

