# <a id="ChargerAstronomyShared_Domain_Coordinate_CoordinateTransform"></a> Class CoordinateTransform

Namespace: [ChargerAstronomyShared.Domain.Coordinate](ChargerAstronomyShared.Domain.Coordinate.md)  
Assembly: ChargerAstronomyEngine.dll  

Provides methods for transforming Equatorial and Horizontal coordinates to one another.

```csharp
public static class CoordinateTransform
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CoordinateTransform](ChargerAstronomyShared.Domain.Coordinate.CoordinateTransform.md)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Methods

### <a id="ChargerAstronomyShared_Domain_Coordinate_CoordinateTransform_EquatorialToHorizontal_System_Numerics_Vector3_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_ChargerAstronomyShared_Domain_Observer_ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_"></a> EquatorialToHorizontal\(Vector3, AstroTime, Observer, Astronomy\)

Transforms a direction vector from Equatorial coordinates to Horizontal coordinates.

```csharp
public static Vector3 EquatorialToHorizontal(Vector3 equatorialDirection, AstroTime time, Observer observer, Astronomy astronomy)
```

#### Parameters

`equatorialDirection` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

The equatorial vector.

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The current time.

`observer` [Observer](ChargerAstronomyShared.Domain.Observer.md)

The current <xref href="ChargerAstronomyShared.Domain.Observer" data-throw-if-not-resolved="false"></xref>.

`astronomy` [Astronomy](ChargerAstronomyEngine.CosineKittyAstronomy.Astronomy.md)

The CosineKittyAstronomy library.

#### Returns

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

A Horizontal vector.

### <a id="ChargerAstronomyShared_Domain_Coordinate_CoordinateTransform_HorizontalToEquatorial_System_Numerics_Vector3_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_ChargerAstronomyShared_Domain_Observer_ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_"></a> HorizontalToEquatorial\(Vector3, AstroTime, Observer, Astronomy\)

Transforms a direction vector from Horizontal coordinates to Equatorial coordinates.

```csharp
public static Vector3 HorizontalToEquatorial(Vector3 horizontalDirection, AstroTime time, Observer observer, Astronomy astronomy)
```

#### Parameters

`horizontalDirection` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

The horizontal vector.

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The current time.

`observer` [Observer](ChargerAstronomyShared.Domain.Observer.md)

The current <xref href="ChargerAstronomyShared.Domain.Observer" data-throw-if-not-resolved="false"></xref>.

`astronomy` [Astronomy](ChargerAstronomyEngine.CosineKittyAstronomy.Astronomy.md)

The CosineKitty Astronomy library./&gt;

#### Returns

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

An Equatorial vector.

