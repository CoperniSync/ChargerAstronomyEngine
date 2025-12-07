# <a id="Assets_Scripts_CelestialBodies_Constellations_UnityConstellation"></a> Class UnityConstellation

Namespace: [Assets.Scripts.CelestialBodies.Constellations](Assets.Scripts.CelestialBodies.Constellations.md)  
Assembly: Assembly\-CSharp.dll  

```csharp
public class UnityConstellation
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[UnityConstellation](Assets.Scripts.CelestialBodies.Constellations.UnityConstellation.md)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="Assets_Scripts_CelestialBodies_Constellations_UnityConstellation__ctor_ChargerAstronomyShared_Domain_Equatorial_Constellation_System_Collections_Generic_List_Assets_Scripts_CelestialBodies_Star__ChargerAstronomyShared_Contracts_Repositories_IEngineService_ChargerAstronomyShared_Contracts_Models_IHorizontal__System_Boolean_"></a> UnityConstellation\(Constellation, List<Star\>, IEngineService<IHorizontal\>, bool\)

Creates a constellation in the sky between already defined stars.

```csharp
public UnityConstellation(Constellation constellation, List<Star> starList, IEngineService<IHorizontal> engineService, bool initalState = true)
```

#### Parameters

`constellation` Constellation

Information that the constellation will be created from

`starList` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[Star](Assets.Scripts.CelestialBodies.Star.md)\>

The list of stars that the star data will be pulled from

`engineService` IEngineService<IHorizontal\>

`initalState` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Whether the constellation should start visible

#### Remarks

SetState(lineActive);
    Ensure starList has been populated prior to calling this constructor.

## Methods

### <a id="Assets_Scripts_CelestialBodies_Constellations_UnityConstellation_SetLabelVisible_System_Boolean_"></a> SetLabelVisible\(bool\)

```csharp
public void SetLabelVisible(bool state)
```

#### Parameters

`state` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Assets_Scripts_CelestialBodies_Constellations_UnityConstellation_SetVisible_System_Boolean_"></a> SetVisible\(bool\)

Toggles the visibility of the Constellation

```csharp
public void SetVisible(bool state)
```

#### Parameters

`state` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Assets_Scripts_CelestialBodies_Constellations_UnityConstellation_UpdatePosition"></a> UpdatePosition\(\)

```csharp
public void UpdatePosition()
```

