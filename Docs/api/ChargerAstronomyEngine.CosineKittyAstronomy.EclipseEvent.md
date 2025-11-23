# <a id="ChargerAstronomyEngine_CosineKittyAstronomy_EclipseEvent"></a> Struct EclipseEvent

Namespace: [ChargerAstronomyEngine.CosineKittyAstronomy](ChargerAstronomyEngine.CosineKittyAstronomy.md)  
Assembly: ChargerAstronomyEngine.dll  

Holds a time and the observed altitude of the Sun at that time.

```csharp
public struct EclipseEvent
```

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Remarks

When reporting a solar eclipse observed at a specific location on the Earth
(a "local" solar eclipse), a series of events occur. In addition
to the time of each event, it is important to know the altitude of the Sun,
because each event may be invisible to the observer if the Sun is below
the horizon.

If `altitude` is negative, the event is theoretical only; it would be
visible if the Earth were transparent, but the observer cannot actually see it.
If `altitude` is positive but less than a few degrees, visibility will be impaired by
atmospheric interference (sunrise or sunset conditions).

## Fields

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_EclipseEvent_altitude"></a> altitude

The angular altitude of the center of the Sun above/below the horizon, at `time`,
corrected for atmospheric refraction and expressed in degrees.

```csharp
public double altitude
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_EclipseEvent_time"></a> time

The date and time of the event.

```csharp
public AstroTime time
```

#### Field Value

 [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

