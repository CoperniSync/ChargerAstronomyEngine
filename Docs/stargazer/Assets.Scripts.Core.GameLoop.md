# <a id="Assets_Scripts_Core_GameLoop"></a> Class GameLoop

Namespace: [Assets.Scripts.Core](Assets.Scripts.Core.md)  
Assembly: Assembly\-CSharp.dll  

```csharp
public class GameLoop : MonoBehaviour
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
Object ← 
Component ← 
Behaviour ← 
MonoBehaviour ← 
[GameLoop](Assets.Scripts.Core.GameLoop.md)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Fields

### <a id="Assets_Scripts_Core_GameLoop_speedMult"></a> speedMult

```csharp
public float speedMult
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Assets_Scripts_Core_GameLoop_GetEngineState_UnityEngine_Vector3__System_Int32__System_DateTime__ChargerAstronomyShared_Domain_Observer__"></a> GetEngineState\(out Vector3, out int, out DateTime, out Observer\)

```csharp
public void GetEngineState(out Vector3 camDirection, out int engineYear, out DateTime engineTime, out Observer engineObserver)
```

#### Parameters

`camDirection` Vector3

`engineYear` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`engineTime` [DateTime](https://learn.microsoft.com/dotnet/api/system.datetime)

`engineObserver` Observer

### <a id="Assets_Scripts_Core_GameLoop_GetMessierList"></a> GetMessierList\(\)

```csharp
public List<MessierObject> GetMessierList()
```

#### Returns

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[MessierObject](Assets.Scripts.CelestialBodies.MessierObject.md)\>

### <a id="Assets_Scripts_Core_GameLoop_GetMoon"></a> GetMoon\(\)

```csharp
public Moon GetMoon()
```

#### Returns

 [Moon](Assets.Scripts.CelestialBodies.Moon.md)

### <a id="Assets_Scripts_Core_GameLoop_GetPlanetList"></a> GetPlanetList\(\)

```csharp
public List<Planet> GetPlanetList()
```

#### Returns

 [List](https://learn.microsoft.com/dotnet/api/system.collections.generic.list\-1)<[Planet](Assets.Scripts.CelestialBodies.Planet.md)\>

### <a id="Assets_Scripts_Core_GameLoop_GetProjectPath"></a> GetProjectPath\(\)

```csharp
public static string GetProjectPath()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Assets_Scripts_Core_GameLoop_GetSun"></a> GetSun\(\)

```csharp
public Sun GetSun()
```

#### Returns

 [Sun](Assets.Scripts.CelestialBodies.Sun.md)

### <a id="Assets_Scripts_Core_GameLoop_SetCameraPosition"></a> SetCameraPosition\(\)

Updates the engine's camera position based on the Input Container

```csharp
public void SetCameraPosition()
```

### <a id="Assets_Scripts_Core_GameLoop_SetConstellationVisibility_System_Boolean_"></a> SetConstellationVisibility\(bool\)

sets the visibilty of constelations

```csharp
public void SetConstellationVisibility(bool visible)
```

#### Parameters

`visible` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Assets_Scripts_Core_GameLoop_SetLabelVisibility_System_Boolean_"></a> SetLabelVisibility\(bool\)

sets the visibilty of conste;lations labels

```csharp
public void SetLabelVisibility(bool visible)
```

#### Parameters

`visible` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Assets_Scripts_Core_GameLoop_SetLocationAndTime"></a> SetLocationAndTime\(\)

```csharp
public void SetLocationAndTime()
```

### <a id="Assets_Scripts_Core_GameLoop_SetMessierVisibility_System_Boolean_"></a> SetMessierVisibility\(bool\)

set if the messier Objects are being forced from displaying

```csharp
public void SetMessierVisibility(bool visible)
```

#### Parameters

`visible` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Assets_Scripts_Core_GameLoop_SetSpeedMultiplier_System_Single_"></a> SetSpeedMultiplier\(float\)

```csharp
public void SetSpeedMultiplier(float speed)
```

#### Parameters

`speed` [float](https://learn.microsoft.com/dotnet/api/system.single)

