# <a id="ChargerAstronomyEngine_CosineKittyAstronomy_AstroVector"></a> Struct AstroVector

Namespace: [ChargerAstronomyEngine.CosineKittyAstronomy](ChargerAstronomyEngine.CosineKittyAstronomy.md)  
Assembly: ChargerAstronomyEngine.dll  

A 3D Cartesian vector whose components are expressed in Astronomical Units (AU).

```csharp
public struct AstroVector
```

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_AstroVector__ctor_System_Double_System_Double_System_Double_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> AstroVector\(double, double, double, AstroTime\)

Creates an AstroVector.

```csharp
public AstroVector(double x, double y, double z, AstroTime t)
```

#### Parameters

`x` [double](https://learn.microsoft.com/dotnet/api/system.double)

A Cartesian x-coordinate expressed in AU.

`y` [double](https://learn.microsoft.com/dotnet/api/system.double)

A Cartesian y-coordinate expressed in AU.

`z` [double](https://learn.microsoft.com/dotnet/api/system.double)

A Cartesian z-coordinate expressed in AU.

`t` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time at which this vector is valid.

## Fields

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_AstroVector_t"></a> t

The date and time at which this vector is valid.

```csharp
public AstroTime t
```

#### Field Value

 [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_AstroVector_x"></a> x

The Cartesian x-coordinate of the vector in AU.

```csharp
public double x
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_AstroVector_y"></a> y

The Cartesian y-coordinate of the vector in AU.

```csharp
public double y
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_AstroVector_z"></a> z

The Cartesian z-coordinate of the vector in AU.

```csharp
public double z
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

## Methods

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_AstroVector_Length"></a> Length\(\)

Calculates the total distance in AU represented by this vector.

```csharp
public double Length()
```

#### Returns

 [double](https://learn.microsoft.com/dotnet/api/system.double)

The nonnegative length of the Cartisian vector in AU.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_AstroVector_ToString"></a> ToString\(\)

Converts the vector to a string of the format (x, y, z, t).

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_AstroVector_TryParse_System_String_ChargerAstronomyEngine_CosineKittyAstronomy_AstroVector__"></a> TryParse\(string, out AstroVector\)

Parses a vector from a string as formatted by #AstroVector.ToString.
On success, `vector` receives the vector and the function returns `true`.
Otherwise, `vector` receives the value (0, 0, 0, null) and the function returns `false`.

```csharp
public static bool TryParse(string text, out AstroVector vector)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string)

A string of the form "(x, y, z, t)".

`vector` [AstroVector](ChargerAstronomyEngine.CosineKittyAstronomy.AstroVector.md)

Receives the output vector.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Operators

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_AstroVector_op_Addition_ChargerAstronomyEngine_CosineKittyAstronomy_AstroVector_ChargerAstronomyEngine_CosineKittyAstronomy_AstroVector_"></a> operator \+\(AstroVector, AstroVector\)

```csharp
public static AstroVector operator +(AstroVector a, AstroVector b)
```

#### Parameters

`a` [AstroVector](ChargerAstronomyEngine.CosineKittyAstronomy.AstroVector.md)

`b` [AstroVector](ChargerAstronomyEngine.CosineKittyAstronomy.AstroVector.md)

#### Returns

 [AstroVector](ChargerAstronomyEngine.CosineKittyAstronomy.AstroVector.md)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_AstroVector_op_Division_ChargerAstronomyEngine_CosineKittyAstronomy_AstroVector_System_Double_"></a> operator /\(AstroVector, double\)

```csharp
public static AstroVector operator /(AstroVector a, double denom)
```

#### Parameters

`a` [AstroVector](ChargerAstronomyEngine.CosineKittyAstronomy.AstroVector.md)

`denom` [double](https://learn.microsoft.com/dotnet/api/system.double)

#### Returns

 [AstroVector](ChargerAstronomyEngine.CosineKittyAstronomy.AstroVector.md)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_AstroVector_op_Multiply_ChargerAstronomyEngine_CosineKittyAstronomy_AstroVector_ChargerAstronomyEngine_CosineKittyAstronomy_AstroVector_"></a> operator \*\(AstroVector, AstroVector\)

```csharp
public static double operator *(AstroVector a, AstroVector b)
```

#### Parameters

`a` [AstroVector](ChargerAstronomyEngine.CosineKittyAstronomy.AstroVector.md)

`b` [AstroVector](ChargerAstronomyEngine.CosineKittyAstronomy.AstroVector.md)

#### Returns

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_AstroVector_op_Multiply_System_Double_ChargerAstronomyEngine_CosineKittyAstronomy_AstroVector_"></a> operator \*\(double, AstroVector\)

```csharp
public static AstroVector operator *(double factor, AstroVector a)
```

#### Parameters

`factor` [double](https://learn.microsoft.com/dotnet/api/system.double)

`a` [AstroVector](ChargerAstronomyEngine.CosineKittyAstronomy.AstroVector.md)

#### Returns

 [AstroVector](ChargerAstronomyEngine.CosineKittyAstronomy.AstroVector.md)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_AstroVector_op_Subtraction_ChargerAstronomyEngine_CosineKittyAstronomy_AstroVector_ChargerAstronomyEngine_CosineKittyAstronomy_AstroVector_"></a> operator \-\(AstroVector, AstroVector\)

```csharp
public static AstroVector operator -(AstroVector a, AstroVector b)
```

#### Parameters

`a` [AstroVector](ChargerAstronomyEngine.CosineKittyAstronomy.AstroVector.md)

`b` [AstroVector](ChargerAstronomyEngine.CosineKittyAstronomy.AstroVector.md)

#### Returns

 [AstroVector](ChargerAstronomyEngine.CosineKittyAstronomy.AstroVector.md)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_AstroVector_op_UnaryNegation_ChargerAstronomyEngine_CosineKittyAstronomy_AstroVector_"></a> operator \-\(AstroVector\)

```csharp
public static AstroVector operator -(AstroVector a)
```

#### Parameters

`a` [AstroVector](ChargerAstronomyEngine.CosineKittyAstronomy.AstroVector.md)

#### Returns

 [AstroVector](ChargerAstronomyEngine.CosineKittyAstronomy.AstroVector.md)

