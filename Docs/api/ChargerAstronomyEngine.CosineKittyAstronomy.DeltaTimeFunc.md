# <a id="ChargerAstronomyEngine_CosineKittyAstronomy_DeltaTimeFunc"></a> Delegate DeltaTimeFunc

Namespace: [ChargerAstronomyEngine.CosineKittyAstronomy](ChargerAstronomyEngine.CosineKittyAstronomy.md)  
Assembly: ChargerAstronomyEngine.dll  

Defines a function type for calculating Delta T.

```csharp
public delegate double DeltaTimeFunc(double ut)
```

#### Parameters

`ut` [double](https://learn.microsoft.com/dotnet/api/system.double)

#### Returns

 [double](https://learn.microsoft.com/dotnet/api/system.double)

## Remarks

Delta T is the discrepancy between times measured using an atomic clock
and times based on observations of the Earth's rotation, which is gradually
slowing down over time. Delta T = TT - UT, where
TT = Terrestrial Time, based on atomic time, and
UT = Universal Time, civil time based on the Earth's rotation.
Astronomy Engine defaults to using a Delta T function defined by
Espenak and Meeus in their "Five Millennium Canon of Solar Eclipses".
See: https://eclipse.gsfc.nasa.gov/SEhelp/deltatpoly2004.html

