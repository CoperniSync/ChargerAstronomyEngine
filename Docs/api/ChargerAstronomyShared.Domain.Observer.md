# <a id="ChargerAstronomyShared_Domain_Observer"></a> Struct Observer

Namespace: [ChargerAstronomyShared.Domain](ChargerAstronomyShared.Domain.md)  
Assembly: ChargerAstronomyShared.dll  

The location of an observer on (or near) the surface of the Earth.

```csharp
public struct Observer
```

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Remarks

This structure is passed to functions that calculate phenomena as observed
from a particular place on the Earth.

## Constructors

### <a id="ChargerAstronomyShared_Domain_Observer__ctor_System_Double_System_Double_System_Double_"></a> Observer\(double, double, double\)

Creates an Observer object.

```csharp
public Observer(double latitude, double longitude, double height)
```

#### Parameters

`latitude` [double](https://learn.microsoft.com/dotnet/api/system.double)

Geographic latitude in degrees north (positive) or south (negative) of the equator.

`longitude` [double](https://learn.microsoft.com/dotnet/api/system.double)

Geographic longitude in degrees east (positive) or west (negative) of the prime meridian at Greenwich, England.

`height` [double](https://learn.microsoft.com/dotnet/api/system.double)

The height above (positive) or below (negative) sea level, expressed in meters.

## Fields

### <a id="ChargerAstronomyShared_Domain_Observer_height"></a> height

The height above (positive) or below (negative) sea level, expressed in meters.

```csharp
public readonly double height
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyShared_Domain_Observer_latitude"></a> latitude

Geographic latitude in degrees north (positive) or south (negative) of the equator.

```csharp
public readonly double latitude
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyShared_Domain_Observer_longitude"></a> longitude

Geographic longitude in degrees east (positive) or west (negative) of the prime meridian at Greenwich, England.

```csharp
public readonly double longitude
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

## Methods

### <a id="ChargerAstronomyShared_Domain_Observer_ToString"></a> ToString\(\)

Converts an `Observer` to a string representation like `(N 26.728965, W 093.157562, 1234.567 m)`.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

