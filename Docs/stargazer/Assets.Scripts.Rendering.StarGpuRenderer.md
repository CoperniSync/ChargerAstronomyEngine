# <a id="Assets_Scripts_Rendering_StarGpuRenderer"></a> Class StarGpuRenderer

Namespace: [Assets.Scripts.Rendering](Assets.Scripts.Rendering.md)  
Assembly: Assembly\-CSharp.dll  

```csharp
public class StarGpuRenderer : MonoBehaviour
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
Object ← 
Component ← 
Behaviour ← 
MonoBehaviour ← 
[StarGpuRenderer](Assets.Scripts.Rendering.StarGpuRenderer.md)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Fields

### <a id="Assets_Scripts_Rendering_StarGpuRenderer_billboardToCamera"></a> billboardToCamera

```csharp
[Header("Settings")]
public bool billboardToCamera
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Assets_Scripts_Rendering_StarGpuRenderer_brightnessMultiplier"></a> brightnessMultiplier

```csharp
[Range(0.5, 5)]
public float brightnessMultiplier
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Assets_Scripts_Rendering_StarGpuRenderer_minDistanceClamp"></a> minDistanceClamp

```csharp
[Range(1, 100)]
public float minDistanceClamp
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Assets_Scripts_Rendering_StarGpuRenderer_sizeMultiplier"></a> sizeMultiplier

```csharp
[Range(0.5, 10)]
public float sizeMultiplier
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Assets_Scripts_Rendering_StarGpuRenderer_sizeVariation"></a> sizeVariation

```csharp
[Range(0, 1)]
public float sizeVariation
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Assets_Scripts_Rendering_StarGpuRenderer_starMaterial"></a> starMaterial

```csharp
[Header("Rendering")]
public Material starMaterial
```

#### Field Value

 Material

### <a id="Assets_Scripts_Rendering_StarGpuRenderer_starMesh"></a> starMesh

```csharp
public Mesh starMesh
```

#### Field Value

 Mesh

