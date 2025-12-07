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

MonoBehaviour.IsInvoking\(\), 
MonoBehaviour.CancelInvoke\(\), 
MonoBehaviour.Invoke\(string, float\), 
MonoBehaviour.InvokeRepeating\(string, float, float\), 
MonoBehaviour.CancelInvoke\(string\), 
MonoBehaviour.IsInvoking\(string\), 
MonoBehaviour.StartCoroutine\(string\), 
MonoBehaviour.StartCoroutine\(string, object\), 
MonoBehaviour.StartCoroutine\(IEnumerator\), 
MonoBehaviour.StartCoroutine\_Auto\(IEnumerator\), 
MonoBehaviour.StopCoroutine\(IEnumerator\), 
MonoBehaviour.StopCoroutine\(Coroutine\), 
MonoBehaviour.StopCoroutine\(string\), 
MonoBehaviour.StopAllCoroutines\(\), 
MonoBehaviour.print\(object\), 
MonoBehaviour.destroyCancellationToken, 
MonoBehaviour.useGUILayout, 
MonoBehaviour.didStart, 
MonoBehaviour.didAwake, 
MonoBehaviour.runInEditMode, 
Behaviour.enabled, 
Behaviour.isActiveAndEnabled, 
Component.GetComponent\(Type\), 
Component.GetComponent<T\>\(\), 
Component.TryGetComponent\(Type, out Component\), 
Component.TryGetComponent<T\>\(out T\), 
Component.GetComponent\(string\), 
Component.GetComponentInChildren\(Type, bool\), 
Component.GetComponentInChildren\(Type\), 
Component.GetComponentInChildren<T\>\(bool\), 
Component.GetComponentInChildren<T\>\(\), 
Component.GetComponentsInChildren\(Type, bool\), 
Component.GetComponentsInChildren\(Type\), 
Component.GetComponentsInChildren<T\>\(bool\), 
Component.GetComponentsInChildren<T\>\(bool, List<T\>\), 
Component.GetComponentsInChildren<T\>\(\), 
Component.GetComponentsInChildren<T\>\(List<T\>\), 
Component.GetComponentInParent\(Type, bool\), 
Component.GetComponentInParent\(Type\), 
Component.GetComponentInParent<T\>\(bool\), 
Component.GetComponentInParent<T\>\(\), 
Component.GetComponentsInParent\(Type, bool\), 
Component.GetComponentsInParent\(Type\), 
Component.GetComponentsInParent<T\>\(bool\), 
Component.GetComponentsInParent<T\>\(bool, List<T\>\), 
Component.GetComponentsInParent<T\>\(\), 
Component.GetComponents\(Type\), 
Component.GetComponents\(Type, List<Component\>\), 
Component.GetComponents<T\>\(List<T\>\), 
Component.GetComponents<T\>\(\), 
Component.GetComponentIndex\(\), 
Component.CompareTag\(string\), 
Component.CompareTag\(TagHandle\), 
Component.SendMessageUpwards\(string, object, SendMessageOptions\), 
Component.SendMessageUpwards\(string, object\), 
Component.SendMessageUpwards\(string\), 
Component.SendMessageUpwards\(string, SendMessageOptions\), 
Component.SendMessage\(string, object\), 
Component.SendMessage\(string\), 
Component.SendMessage\(string, object, SendMessageOptions\), 
Component.SendMessage\(string, SendMessageOptions\), 
Component.BroadcastMessage\(string, object, SendMessageOptions\), 
Component.BroadcastMessage\(string, object\), 
Component.BroadcastMessage\(string\), 
Component.BroadcastMessage\(string, SendMessageOptions\), 
Component.transform, 
Component.gameObject, 
Component.tag, 
Object.GetEntityId\(\), 
Object.GetInstanceID\(\), 
Object.GetHashCode\(\), 
Object.Equals\(object\), 
Object.InstantiateAsync<T\>\(T\), 
Object.InstantiateAsync<T\>\(T, Transform\), 
Object.InstantiateAsync<T\>\(T, Vector3, Quaternion\), 
Object.InstantiateAsync<T\>\(T, Transform, Vector3, Quaternion\), 
Object.InstantiateAsync<T\>\(T, int\), 
Object.InstantiateAsync<T\>\(T, int, Transform\), 
Object.InstantiateAsync<T\>\(T, int, Vector3, Quaternion\), 
Object.InstantiateAsync<T\>\(T, int, ReadOnlySpan<Vector3\>, ReadOnlySpan<Quaternion\>\), 
Object.InstantiateAsync<T\>\(T, int, Transform, Vector3, Quaternion\), 
Object.InstantiateAsync<T\>\(T, int, Transform, Vector3, Quaternion, CancellationToken\), 
Object.InstantiateAsync<T\>\(T, int, Transform, ReadOnlySpan<Vector3\>, ReadOnlySpan<Quaternion\>\), 
Object.InstantiateAsync<T\>\(T, int, Transform, ReadOnlySpan<Vector3\>, ReadOnlySpan<Quaternion\>, CancellationToken\), 
Object.InstantiateAsync<T\>\(T, InstantiateParameters, CancellationToken\), 
Object.InstantiateAsync<T\>\(T, int, InstantiateParameters, CancellationToken\), 
Object.InstantiateAsync<T\>\(T, Vector3, Quaternion, InstantiateParameters, CancellationToken\), 
Object.InstantiateAsync<T\>\(T, int, Vector3, Quaternion, InstantiateParameters, CancellationToken\), 
Object.InstantiateAsync<T\>\(T, int, ReadOnlySpan<Vector3\>, ReadOnlySpan<Quaternion\>, InstantiateParameters, CancellationToken\), 
Object.Instantiate\(Object, Vector3, Quaternion\), 
Object.Instantiate\(Object, Vector3, Quaternion, Transform\), 
Object.Instantiate\(Object\), 
Object.Instantiate\(Object, Scene\), 
Object.Instantiate<T\>\(T, InstantiateParameters\), 
Object.Instantiate<T\>\(T, Vector3, Quaternion, InstantiateParameters\), 
Object.Instantiate\(Object, Transform\), 
Object.Instantiate\(Object, Transform, bool\), 
Object.Instantiate<T\>\(T\), 
Object.Instantiate<T\>\(T, Vector3, Quaternion\), 
Object.Instantiate<T\>\(T, Vector3, Quaternion, Transform\), 
Object.Instantiate<T\>\(T, Transform\), 
Object.Instantiate<T\>\(T, Transform, bool\), 
Object.Destroy\(Object, float\), 
Object.Destroy\(Object\), 
Object.DestroyImmediate\(Object, bool\), 
Object.DestroyImmediate\(Object\), 
Object.FindObjectsOfType\(Type\), 
Object.FindObjectsOfType\(Type, bool\), 
Object.FindObjectsByType\(Type, FindObjectsSortMode\), 
Object.FindObjectsByType\(Type, FindObjectsInactive, FindObjectsSortMode\), 
Object.DontDestroyOnLoad\(Object\), 
Object.DestroyObject\(Object, float\), 
Object.DestroyObject\(Object\), 
Object.FindSceneObjectsOfType\(Type\), 
Object.FindObjectsOfTypeIncludingAssets\(Type\), 
Object.FindObjectsOfType<T\>\(\), 
Object.FindObjectsByType<T\>\(FindObjectsSortMode\), 
Object.FindObjectsOfType<T\>\(bool\), 
Object.FindObjectsByType<T\>\(FindObjectsInactive, FindObjectsSortMode\), 
Object.FindObjectOfType<T\>\(\), 
Object.FindObjectOfType<T\>\(bool\), 
Object.FindFirstObjectByType<T\>\(\), 
Object.FindAnyObjectByType<T\>\(\), 
Object.FindFirstObjectByType<T\>\(FindObjectsInactive\), 
Object.FindAnyObjectByType<T\>\(FindObjectsInactive\), 
Object.FindObjectsOfTypeAll\(Type\), 
Object.FindObjectOfType\(Type\), 
Object.FindFirstObjectByType\(Type\), 
Object.FindAnyObjectByType\(Type\), 
Object.FindObjectOfType\(Type, bool\), 
Object.FindFirstObjectByType\(Type, FindObjectsInactive\), 
Object.FindAnyObjectByType\(Type, FindObjectsInactive\), 
Object.ToString\(\), 
Object.name, 
Object.hideFlags, 
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

