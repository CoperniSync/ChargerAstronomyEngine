# <a id="Assets_Scripts_CelestialBodies_MessierObject"></a> Class MessierObject

Namespace: [Assets.Scripts.CelestialBodies](Assets.Scripts.CelestialBodies.md)  
Assembly: Assembly\-CSharp.dll  

Represents a Messier deep-sky object 
in Unity using horizontal coordinates.
Author: Tommy Rodriguez
Created: 2025-10-05

```csharp
public sealed class MessierObject : CelestialBodyBase, IHorizontal
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CelestialBodyBase](Assets.Scripts.CelestialBodies.CelestialBodyBase.md) ← 
[MessierObject](Assets.Scripts.CelestialBodies.MessierObject.md)

#### Implements

IHorizontal

#### Inherited Members

[CelestialBodyBase.Azimuth](Assets.Scripts.CelestialBodies.CelestialBodyBase.md\#Assets\_Scripts\_CelestialBodies\_CelestialBodyBase\_Azimuth), 
[CelestialBodyBase.Altitude](Assets.Scripts.CelestialBodies.CelestialBodyBase.md\#Assets\_Scripts\_CelestialBodies\_CelestialBodyBase\_Altitude), 
[CelestialBodyBase.Distance](Assets.Scripts.CelestialBodies.CelestialBodyBase.md\#Assets\_Scripts\_CelestialBodies\_CelestialBodyBase\_Distance), 
[CelestialBodyBase.RightAscension](Assets.Scripts.CelestialBodies.CelestialBodyBase.md\#Assets\_Scripts\_CelestialBodies\_CelestialBodyBase\_RightAscension), 
[CelestialBodyBase.Declination](Assets.Scripts.CelestialBodies.CelestialBodyBase.md\#Assets\_Scripts\_CelestialBodies\_CelestialBodyBase\_Declination), 
[CelestialBodyBase.Magnitude](Assets.Scripts.CelestialBodies.CelestialBodyBase.md\#Assets\_Scripts\_CelestialBodies\_CelestialBodyBase\_Magnitude), 
[CelestialBodyBase.DistanceLy](Assets.Scripts.CelestialBodies.CelestialBodyBase.md\#Assets\_Scripts\_CelestialBodies\_CelestialBodyBase\_DistanceLy), 
[CelestialBodyBase.DrawnDistance](Assets.Scripts.CelestialBodies.CelestialBodyBase.md\#Assets\_Scripts\_CelestialBodies\_CelestialBodyBase\_DrawnDistance), 
[CelestialBodyBase.SetHorizontal\(HorizontalBody, float?\)](Assets.Scripts.CelestialBodies.CelestialBodyBase.md\#Assets\_Scripts\_CelestialBodies\_CelestialBodyBase\_SetHorizontal\_ChargerAstronomyShared\_Domain\_Horizontal\_HorizontalBody\_System\_Nullable\_System\_Single\_\_), 
[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="Assets_Scripts_CelestialBodies_MessierObject__ctor_ChargerAstronomyShared_Domain_Horizontal_HorizontalMessierObject_System_Single_UnityEngine_GameObject_"></a> MessierObject\(HorizontalMessierObject, float, GameObject\)

Prefab-spawning constructor for Messier objects.

```csharp
public MessierObject(HorizontalMessierObject hMessier, float drawnDistance = 125, GameObject prefab = null)
```

#### Parameters

`hMessier` HorizontalMessierObject

`drawnDistance` [float](https://learn.microsoft.com/dotnet/api/system.single)

`prefab` GameObject

## Properties

### <a id="Assets_Scripts_CelestialBodies_MessierObject_CommonName"></a> CommonName

```csharp
public string CommonName { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Assets_Scripts_CelestialBodies_MessierObject_Constellation"></a> Constellation

```csharp
public string Constellation { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Assets_Scripts_CelestialBodies_MessierObject_HorizontalBody"></a> HorizontalBody

```csharp
public HorizontalBody HorizontalBody { get; }
```

#### Property Value

 HorizontalBody

### <a id="Assets_Scripts_CelestialBodies_MessierObject_Magnitude"></a> Magnitude

```csharp
public float Magnitude { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Assets_Scripts_CelestialBodies_MessierObject_MessierId"></a> MessierId

```csharp
public string MessierId { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Assets_Scripts_CelestialBodies_MessierObject_NewGeneralCatalog"></a> NewGeneralCatalog

```csharp
public string NewGeneralCatalog { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Assets_Scripts_CelestialBodies_MessierObject_Position2D"></a> Position2D

```csharp
public Vector2 Position2D { get; }
```

#### Property Value

 Vector2

### <a id="Assets_Scripts_CelestialBodies_MessierObject_Position3D"></a> Position3D

```csharp
public Vector3 Position3D { get; }
```

#### Property Value

 Vector3

### <a id="Assets_Scripts_CelestialBodies_MessierObject_Size"></a> Size

```csharp
public string Size { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Assets_Scripts_CelestialBodies_MessierObject_Type"></a> Type

```csharp
public string Type { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Assets_Scripts_CelestialBodies_MessierObject_ViewingDifficulty"></a> ViewingDifficulty

```csharp
public string ViewingDifficulty { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Assets_Scripts_CelestialBodies_MessierObject_ViewingSeason"></a> ViewingSeason

```csharp
public string ViewingSeason { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Assets_Scripts_CelestialBodies_MessierObject_ApplyHorizontal_ChargerAstronomyShared_Domain_Horizontal_HorizontalMessierObject_"></a> ApplyHorizontal\(HorizontalMessierObject\)

Applies updated coordinates or metadata from Engine.

```csharp
public void ApplyHorizontal(HorizontalMessierObject hMessier)
```

#### Parameters

`hMessier` HorizontalMessierObject

### <a id="Assets_Scripts_CelestialBodies_MessierObject_FromHorizontal_ChargerAstronomyShared_Domain_Horizontal_HorizontalMessierObject_System_Single_"></a> FromHorizontal\(HorizontalMessierObject, float\)

One-time initialization from horizontal data.

```csharp
public void FromHorizontal(HorizontalMessierObject hMessier, float drawnDistance = 125)
```

#### Parameters

`hMessier` HorizontalMessierObject

`drawnDistance` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Assets_Scripts_CelestialBodies_MessierObject_SetState_System_Boolean_"></a> SetState\(bool\)

Enable or disable the messier Object's GameObject.

```csharp
public void SetState(bool state)
```

#### Parameters

`state` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Assets_Scripts_CelestialBodies_MessierObject_SetVisible_System_Boolean_"></a> SetVisible\(bool\)

Function used for toggling messier Objects on and off via UI

```csharp
public void SetVisible(bool newVisibility)
```

#### Parameters

`newVisibility` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Assets_Scripts_CelestialBodies_MessierObject_ToggleState"></a> ToggleState\(\)

Enable or disable the Messier object GameObject.

```csharp
public void ToggleState()
```

### <a id="Assets_Scripts_CelestialBodies_MessierObject_UpdateMessier"></a> UpdateMessier\(\)

Updates an existing Messier object's position and scale.

```csharp
public void UpdateMessier()
```

### <a id="Assets_Scripts_CelestialBodies_MessierObject_UpdatePosition"></a> UpdatePosition\(\)

Update the position of the messier Object's Game Object

```csharp
public void UpdatePosition()
```

