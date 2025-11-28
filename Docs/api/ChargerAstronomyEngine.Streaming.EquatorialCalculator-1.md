# <a id="ChargerAstronomyEngine_Streaming_EquatorialCalculator_1"></a> Class EquatorialCalculator<T\>

Namespace: [ChargerAstronomyEngine.Streaming](ChargerAstronomyEngine.Streaming.md)  
Assembly: ChargerAstronomyEngine.dll  

```csharp
public class EquatorialCalculator<T> : IEquatorialCalculator where T : IHorizontal
```

#### Type Parameters

`T` 

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[EquatorialCalculator<T\>](ChargerAstronomyEngine.Streaming.EquatorialCalculator\-1.md)

#### Implements

[IEquatorialCalculator](ChargerAstronomyShared.Contracts.Repositories.IEquatorialCalculator.md)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="ChargerAstronomyEngine_Streaming_EquatorialCalculator_1__ctor_ChargerAstronomyShared_Domain_Heat_HeatService_ChargerAstronomyShared_Domain_SpatialIndex_SpatialStarIndex__0__"></a> EquatorialCalculator\(HeatService, SpatialStarIndex<T\>\)

```csharp
public EquatorialCalculator(HeatService heatService, SpatialStarIndex<T> starIndex)
```

#### Parameters

`heatService` [HeatService](ChargerAstronomyShared.Domain.Heat.HeatService.md)

`starIndex` [SpatialStarIndex](ChargerAstronomyShared.Domain.SpatialIndex.SpatialStarIndex\-1.md)<T\>

## Methods

### <a id="ChargerAstronomyEngine_Streaming_EquatorialCalculator_1_GetTimeAndPlace_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime__ChargerAstronomyShared_Domain_Observer__"></a> GetTimeAndPlace\(out AstroTime, out Observer\)

```csharp
public void GetTimeAndPlace(out AstroTime time, out Observer location)
```

#### Parameters

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

`location` [Observer](ChargerAstronomyShared.Domain.Observer.md)

### <a id="ChargerAstronomyEngine_Streaming_EquatorialCalculator_1_IncrementTime_System_Single_"></a> IncrementTime\(float\)

Increments the time of the internal universal time used to perform calculations.

```csharp
public void IncrementTime(float deltaTime)
```

#### Parameters

`deltaTime` [float](https://learn.microsoft.com/dotnet/api/system.single)

The amount of time to increase by, in seconds.

### <a id="ChargerAstronomyEngine_Streaming_EquatorialCalculator_1_UpdateLocation_ChargerAstronomyShared_Domain_Observer_"></a> UpdateLocation\(Observer\)

Calculates and updates the position of an <xref href="ChargerAstronomyShared.Domain.Observer" data-throw-if-not-resolved="false"></xref>

```csharp
public void UpdateLocation(Observer newLocation)
```

#### Parameters

`newLocation` [Observer](ChargerAstronomyShared.Domain.Observer.md)

The new location for the <xref href="ChargerAstronomyShared.Domain.Observer" data-throw-if-not-resolved="false"></xref> to update to.

### <a id="ChargerAstronomyEngine_Streaming_EquatorialCalculator_1_UpdatePositionOf_ChargerAstronomyShared_Domain_Horizontal_HorizontalPlanet_"></a> UpdatePositionOf\(HorizontalPlanet\)

Updates the position and related properties of the specified planet based on the current astronomical time
and location.

```csharp
public void UpdatePositionOf(HorizontalPlanet planet)
```

#### Parameters

`planet` [HorizontalPlanet](ChargerAstronomyShared.Domain.Horizontal.HorizontalPlanet.md)

#### Exceptions

 [ArgumentException](https://learn.microsoft.com/dotnet/api/system.argumentexception)

Thrown if the <code class="paramref">planet</code> name is not recognized in the internal collection of known planets.

### <a id="ChargerAstronomyEngine_Streaming_EquatorialCalculator_1_UpdatePositionOf_ChargerAstronomyShared_Domain_Horizontal_HorizontalMoon_"></a> UpdatePositionOf\(HorizontalMoon\)

Updates the position, phase, and distance of the specified moon object based on the current astronomical
time and location.

```csharp
public void UpdatePositionOf(HorizontalMoon moon)
```

#### Parameters

`moon` [HorizontalMoon](ChargerAstronomyShared.Domain.Horizontal.HorizontalMoon.md)

The <xref href="ChargerAstronomyShared.Domain.Horizontal.HorizontalMoon" data-throw-if-not-resolved="false"></xref> object whose properties will be updated. Cannot be <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/null">null</a>.

### <a id="ChargerAstronomyEngine_Streaming_EquatorialCalculator_1_UpdatePositionOf_ChargerAstronomyShared_Domain_Horizontal_HorizontalSun_"></a> UpdatePositionOf\(HorizontalSun\)

Updates the position of the specified <xref href="ChargerAstronomyShared.Domain.Horizontal.HorizontalSun" data-throw-if-not-resolved="false"></xref> object based on the current astronomical
time and location.

```csharp
public void UpdatePositionOf(HorizontalSun sun)
```

#### Parameters

`sun` [HorizontalSun](ChargerAstronomyShared.Domain.Horizontal.HorizontalSun.md)

The <xref href="ChargerAstronomyShared.Domain.Horizontal.HorizontalSun" data-throw-if-not-resolved="false"></xref> object whose altitude, azimuth, and distance will be updated.

### <a id="ChargerAstronomyEngine_Streaming_EquatorialCalculator_1_UpdateStar__0_"></a> UpdateStar\(T\)

Updates the horizontal coordinates of the specified star based on the current time and location.

```csharp
public void UpdateStar(T star)
```

#### Parameters

`star` T

The star whose horizontal coordinates are to be updated. The star must have a valid <xref href="ChargerAstronomyShared.Domain.Horizontal.HorizontalBody" data-throw-if-not-resolved="false"></xref>
    property.

#### Remarks

This method calculates the star's equatorial coordinates using the J2000 epoch and
    applies corrections for aberration.  It then converts the equatorial coordinates to topocentric horizontal
    coordinates, updating the star's altitude and azimuth.

### <a id="ChargerAstronomyEngine_Streaming_EquatorialCalculator_1_UpdateTime_ChargerAstronomyShared_Domain_CalendarDateTime_"></a> UpdateTime\(CalendarDateTime\)

Updates the internal universal time used for calculations.

```csharp
public void UpdateTime(CalendarDateTime newTime)
```

#### Parameters

`newTime` [CalendarDateTime](ChargerAstronomyShared.Domain.CalendarDateTime.md)

The new universal time.

### <a id="ChargerAstronomyEngine_Streaming_EquatorialCalculator_1_UpdateTimeAndLocation_ChargerAstronomyShared_Domain_CalendarDateTime_ChargerAstronomyShared_Domain_Observer_"></a> UpdateTimeAndLocation\(CalendarDateTime, Observer\)

Updates the internal universal time and <xref href="ChargerAstronomyShared.Domain.Observer" data-throw-if-not-resolved="false"></xref> location for calculations.

```csharp
public void UpdateTimeAndLocation(CalendarDateTime newTime, Observer newLocation)
```

#### Parameters

`newTime` [CalendarDateTime](ChargerAstronomyShared.Domain.CalendarDateTime.md)

The new universal time.

`newLocation` [Observer](ChargerAstronomyShared.Domain.Observer.md)

The new location for the <xref href="ChargerAstronomyShared.Domain.Observer" data-throw-if-not-resolved="false"></xref> to update to.

