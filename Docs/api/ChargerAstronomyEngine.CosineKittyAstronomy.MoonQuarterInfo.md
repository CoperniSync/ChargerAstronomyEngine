# <a id="ChargerAstronomyEngine_CosineKittyAstronomy_MoonQuarterInfo"></a> Struct MoonQuarterInfo

Namespace: [ChargerAstronomyEngine.CosineKittyAstronomy](ChargerAstronomyEngine.CosineKittyAstronomy.md)  
Assembly: ChargerAstronomyEngine.dll  

A lunar quarter event (new moon, first quarter, full moon, or third quarter) along with its date and time.

```csharp
public struct MoonQuarterInfo
```

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Fields

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_MoonQuarterInfo_quarter"></a> quarter

0=new moon, 1=first quarter, 2=full moon, 3=third quarter.

```csharp
public readonly int quarter
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_MoonQuarterInfo_time"></a> time

The date and time of the lunar quarter.

```csharp
public readonly AstroTime time
```

#### Field Value

 [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

