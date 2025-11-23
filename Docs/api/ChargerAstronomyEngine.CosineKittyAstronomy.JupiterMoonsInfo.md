# <a id="ChargerAstronomyEngine_CosineKittyAstronomy_JupiterMoonsInfo"></a> Struct JupiterMoonsInfo

Namespace: [ChargerAstronomyEngine.CosineKittyAstronomy](ChargerAstronomyEngine.CosineKittyAstronomy.md)  
Assembly: ChargerAstronomyEngine.dll  

Holds the positions and velocities of Jupiter's major 4 moons.

```csharp
public struct JupiterMoonsInfo
```

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Remarks

The #Astronomy.JupiterMoons function returns an object of this type
to report position and velocity vectors for Jupiter's largest 4 moons
Io, Europa, Ganymede, and Callisto. Each position vector is relative
to the center of Jupiter. Both position and velocity are oriented in
the EQJ system (that is, using Earth's equator at the J2000 epoch).
The positions are expressed in astronomical units (AU),
and the velocities in AU/day.

## Fields

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_JupiterMoonsInfo_callisto"></a> callisto

The position and velocity of Jupiter's moon Callisto.

```csharp
public StateVector callisto
```

#### Field Value

 [StateVector](ChargerAstronomyEngine.CosineKittyAstronomy.StateVector.md)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_JupiterMoonsInfo_europa"></a> europa

The position and velocity of Jupiter's moon Europa.

```csharp
public StateVector europa
```

#### Field Value

 [StateVector](ChargerAstronomyEngine.CosineKittyAstronomy.StateVector.md)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_JupiterMoonsInfo_ganymede"></a> ganymede

The position and velocity of Jupiter's moon Ganymede.

```csharp
public StateVector ganymede
```

#### Field Value

 [StateVector](ChargerAstronomyEngine.CosineKittyAstronomy.StateVector.md)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_JupiterMoonsInfo_io"></a> io

The position and velocity of Jupiter's moon Io.

```csharp
public StateVector io
```

#### Field Value

 [StateVector](ChargerAstronomyEngine.CosineKittyAstronomy.StateVector.md)

