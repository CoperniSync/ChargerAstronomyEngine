# <a id="ChargerAstronomyEngine_CosineKittyAstronomy_NodeEventInfo"></a> Struct NodeEventInfo

Namespace: [ChargerAstronomyEngine.CosineKittyAstronomy](ChargerAstronomyEngine.CosineKittyAstronomy.md)  
Assembly: ChargerAstronomyEngine.dll  

Information about an ascending or descending node of a body.

```csharp
public struct NodeEventInfo
```

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Remarks

This structure is returned by #Astronomy.SearchMoonNode and #Astronomy.NextMoonNode
to report information about the center of the Moon passing through the ecliptic plane.

## Fields

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_NodeEventInfo_kind"></a> kind

Whether the node is ascending (south to north) or descending (north to south).

```csharp
public NodeEventKind kind
```

#### Field Value

 [NodeEventKind](ChargerAstronomyEngine.CosineKittyAstronomy.Enums.NodeEventKind.md)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_NodeEventInfo_time"></a> time

The time when the body passes through the ecliptic plane.

```csharp
public AstroTime time
```

#### Field Value

 [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

