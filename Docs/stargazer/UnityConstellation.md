# <a id="UnityConstellation"></a> Class UnityConstellation

Namespace:   
Assembly: Assembly\-CSharp.dll  

```csharp
public class UnityConstellation
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[UnityConstellation](UnityConstellation.md)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="UnityConstellation__ctor_ChargerAstronomyShared_Domain_Equatorial_Constellation_System_Collections_Generic_List_Assets_Scripts_CelestialBodies_Star__"></a> UnityConstellation\(Constellation, List<Star\>\)

Creates a constellation in the sky between already defined stars.

```csharp
public UnityConstellation(Constellation constellation, List<Star> starList)
```

#### Parameters

`constellation` Constellation

Information that the constellation will be created from

`starList` [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[Star](Assets.Scripts.CelestialBodies.Star.md)\>

The list of stars that the star data will be pulled from

#### Remarks

Ensure starList has been populated prior to calling this constructor.

## Methods

### <a id="UnityConstellation_SetState_System_Boolean_"></a> SetState\(bool\)

Toggles the visibility of the Constellation

```csharp
public void SetState(bool state)
```

#### Parameters

`state` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="UnityConstellation_UpdatePosition"></a> UpdatePosition\(\)

```csharp
public void UpdatePosition()
```

