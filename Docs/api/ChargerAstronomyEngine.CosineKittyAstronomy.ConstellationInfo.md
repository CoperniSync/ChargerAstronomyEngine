# <a id="ChargerAstronomyEngine_CosineKittyAstronomy_ConstellationInfo"></a> Struct ConstellationInfo

Namespace: [ChargerAstronomyEngine.CosineKittyAstronomy](ChargerAstronomyEngine.CosineKittyAstronomy.md)  
Assembly: ChargerAstronomyEngine.dll  

Reports the constellation that a given celestial point lies within.

```csharp
public struct ConstellationInfo
```

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Remarks

The #Astronomy.Constellation function returns this struct
to report which constellation corresponds with a given point in the sky.
Constellations are defined with respect to the B1875 equatorial system
per IAU standard. Although `Astronomy.Constellation` requires J2000 equatorial
coordinates, the struct contains converted B1875 coordinates for reference.

## Fields

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_ConstellationInfo_Dec1875"></a> Dec1875

Declination expressed in B1875 coordinates.

```csharp
public readonly double Dec1875
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_ConstellationInfo_Name"></a> Name

Full name of constellation, e.g. "Orion".

```csharp
public readonly string Name
```

#### Field Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_ConstellationInfo_Ra1875"></a> Ra1875

Right ascension expressed in B1875 coordinates.

```csharp
public readonly double Ra1875
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_ConstellationInfo_Symbol"></a> Symbol

3-character mnemonic symbol for the constellation, e.g. "Ori".

```csharp
public readonly string Symbol
```

#### Field Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

