# <a id="ChargerAstronomyEngine_CosineKittyAstronomy_StateVector"></a> Struct StateVector

Namespace: [ChargerAstronomyEngine.CosineKittyAstronomy](ChargerAstronomyEngine.CosineKittyAstronomy.md)  
Assembly: ChargerAstronomyEngine.dll  

A combination of a position vector and a velocity vector at a given moment in time.

```csharp
public struct StateVector
```

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Remarks

A state vector represents the dynamic state of a point at a given moment.
It includes the position vector of the point, expressed in Astronomical Units (AU)
along with the velocity vector of the point, expressed in AU/day.

## Constructors

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_StateVector__ctor_System_Double_System_Double_System_Double_System_Double_System_Double_System_Double_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> StateVector\(double, double, double, double, double, double, AstroTime\)

Creates an AstroVector.

```csharp
public StateVector(double x, double y, double z, double vx, double vy, double vz, AstroTime t)
```

#### Parameters

`x` [double](https://learn.microsoft.com/dotnet/api/system.double)

A position x-coordinate expressed in AU.

`y` [double](https://learn.microsoft.com/dotnet/api/system.double)

A position y-coordinate expressed in AU.

`z` [double](https://learn.microsoft.com/dotnet/api/system.double)

A position z-coordinate expressed in AU.

`vx` [double](https://learn.microsoft.com/dotnet/api/system.double)

A velocity x-component expressed in AU/day.

`vy` [double](https://learn.microsoft.com/dotnet/api/system.double)

A velocity y-component expressed in AU/day.

`vz` [double](https://learn.microsoft.com/dotnet/api/system.double)

A velocity z-component expressed in AU/day.

`t` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time at which this state vector is valid.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_StateVector__ctor_ChargerAstronomyEngine_CosineKittyAstronomy_AstroVector_ChargerAstronomyEngine_CosineKittyAstronomy_AstroVector_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> StateVector\(AstroVector, AstroVector, AstroTime\)

Combines a position vector and a velocity vector into a single state vector.

```csharp
public StateVector(AstroVector pos, AstroVector vel, AstroTime time)
```

#### Parameters

`pos` [AstroVector](ChargerAstronomyEngine.CosineKittyAstronomy.AstroVector.md)

A position vector.

`vel` [AstroVector](ChargerAstronomyEngine.CosineKittyAstronomy.AstroVector.md)

A velocity vector.

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The common time that represents the given position and velocity.

## Fields

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_StateVector_t"></a> t

The date and time at which this vector is valid.

```csharp
public AstroTime t
```

#### Field Value

 [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_StateVector_vx"></a> vx

The velocity x-component in AU/day.

```csharp
public double vx
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_StateVector_vy"></a> vy

The velocity y-component in AU/day.

```csharp
public double vy
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_StateVector_vz"></a> vz

The velocity z-component in AU/day.

```csharp
public double vz
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_StateVector_x"></a> x

The position x-coordinate in AU.

```csharp
public double x
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_StateVector_y"></a> y

The position y-coordinate in AU.

```csharp
public double y
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_StateVector_z"></a> z

The position z-coordinate in AU.

```csharp
public double z
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

## Methods

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_StateVector_Position"></a> Position\(\)

Returns the position vector associated with this state vector.

```csharp
public AstroVector Position()
```

#### Returns

 [AstroVector](ChargerAstronomyEngine.CosineKittyAstronomy.AstroVector.md)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_StateVector_ToString"></a> ToString\(\)

Converts the state vector to a string of the format (x, y, z, vx, vy, vz, t).

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_StateVector_Velocity"></a> Velocity\(\)

Returns the velocity vector associated with this state vector.

```csharp
public AstroVector Velocity()
```

#### Returns

 [AstroVector](ChargerAstronomyEngine.CosineKittyAstronomy.AstroVector.md)

