# <a id="ChargerAstronomyEngine_CosineKittyAstronomy_HourAngleInfo"></a> Struct HourAngleInfo

Namespace: [ChargerAstronomyEngine.CosineKittyAstronomy](ChargerAstronomyEngine.CosineKittyAstronomy.md)  
Assembly: ChargerAstronomyEngine.dll  

Information about a celestial body crossing a specific hour angle.

```csharp
public struct HourAngleInfo
```

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Remarks

Returned by the function #Astronomy.SearchHourAngle to report information about
a celestial body crossing a certain hour angle as seen by a specified topocentric observer.

## Fields

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_HourAngleInfo_hor"></a> hor

Apparent coordinates of the body at the time it crosses the specified hour angle.

```csharp
public readonly Topocentric hor
```

#### Field Value

 [Topocentric](ChargerAstronomyEngine.CosineKittyAstronomy.Topocentric.md)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_HourAngleInfo_time"></a> time

The date and time when the body crosses the specified hour angle.

```csharp
public readonly AstroTime time
```

#### Field Value

 [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

