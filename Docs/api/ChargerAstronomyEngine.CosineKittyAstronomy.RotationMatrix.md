# <a id="ChargerAstronomyEngine_CosineKittyAstronomy_RotationMatrix"></a> Struct RotationMatrix

Namespace: [ChargerAstronomyEngine.CosineKittyAstronomy](ChargerAstronomyEngine.CosineKittyAstronomy.md)  
Assembly: ChargerAstronomyEngine.dll  

A rotation matrix that can be used to transform one coordinate system to another.

```csharp
public struct RotationMatrix
```

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_RotationMatrix__ctor_System_Double_0__0___"></a> RotationMatrix\(double\[,\]\)

Creates a rotation matrix.

```csharp
public RotationMatrix(double[,] rot)
```

#### Parameters

`rot` [double](https://learn.microsoft.com/dotnet/api/system.double)\[,\]

A 3x3 array of floating point numbers defining the rotation matrix.

## Fields

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_RotationMatrix_rot"></a> rot

A normalized 3x3 rotation matrix.

```csharp
public readonly double[,] rot
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)\[,\]

