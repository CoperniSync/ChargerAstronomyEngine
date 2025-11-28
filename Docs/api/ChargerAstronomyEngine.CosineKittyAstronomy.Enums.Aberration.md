# <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Enums_Aberration"></a> Enum Aberration

Namespace: [ChargerAstronomyEngine.CosineKittyAstronomy.Enums](ChargerAstronomyEngine.CosineKittyAstronomy.Enums.md)  
Assembly: ChargerAstronomyEngine.dll  

Aberration calculation options.

```csharp
public enum Aberration
```

## Fields

`Corrected = 0` 

Request correction for aberration.



`None = 1` 

Do not correct for aberration.



## Remarks

[Aberration](https://en.wikipedia.org/wiki/Aberration_of_light) is an effect
causing the apparent direction of an observed body to be shifted due to transverse
movement of the Earth with respect to the rays of light coming from that body.
This angular correction can be anywhere from 0 to about 20 arcseconds,
depending on the position of the observed body relative to the instantaneous
velocity vector of the Earth.

Some Astronomy Engine functions allow optional correction for aberration by
passing in a value of this enumerated type.

Aberration correction is useful to improve accuracy of coordinates of
apparent locations of bodies seen from the Earth.
However, because aberration affects not only the observed body (such as a planet)
but the surrounding stars, aberration may be unhelpful (for example)
for determining exactly when a planet crosses from one constellation to another.

