# <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Spherical"></a> Struct Spherical

Namespace: [ChargerAstronomyEngine.CosineKittyAstronomy](ChargerAstronomyEngine.CosineKittyAstronomy.md)  
Assembly: ChargerAstronomyEngine.dll  

Spherical coordinates: latitude, longitude, distance.

```csharp
public struct Spherical
```

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Spherical__ctor_System_Double_System_Double_System_Double_"></a> Spherical\(double, double, double\)

Creates a set of spherical coordinates.

```csharp
public Spherical(double lat, double lon, double dist)
```

#### Parameters

`lat` [double](https://learn.microsoft.com/dotnet/api/system.double)

The latitude angle: -90..+90 degrees.

`lon` [double](https://learn.microsoft.com/dotnet/api/system.double)

The longitude angle: 0..360 degrees.

`dist` [double](https://learn.microsoft.com/dotnet/api/system.double)

Distance in AU.

## Fields

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Spherical_dist"></a> dist

Distance in AU.

```csharp
public readonly double dist
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Spherical_lat"></a> lat

The latitude angle: -90..+90 degrees.

```csharp
public readonly double lat
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Spherical_lon"></a> lon

The longitude angle: 0..360 degrees.

```csharp
public readonly double lon
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

