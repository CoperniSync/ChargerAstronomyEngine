# <a id="ChargerAstronomyShared_Domain_Equatorial_BodyType"></a> Enum BodyType

Namespace: [ChargerAstronomyShared.Domain.Equatorial](ChargerAstronomyShared.Domain.Equatorial.md)  
Assembly: ChargerAstronomyShared.dll  

The enumeration of celestial bodies supported by Astronomy Engine.

```csharp
public enum BodyType
```

## Fields

`EMB = 11` 

The Earth/Moon Barycenter.



`Earth = 2` 

The planet Earth.
Some functions that accept a `Body` parameter will fail if passed this value
because they assume that an observation is being made from the Earth,
and therefore the Earth is not a target of observation.



`Invalid = -1` 

A placeholder value representing an invalid or unknown celestial body.



`Jupiter = 4` 

The planet Jupiter.



`Mars = 3` 

The planet Mars.



`Mercury = 0` 

The planet Mercury.



`Messier = 14` 

`Moon = 10` 

The Earth's natural satellite, the Moon.



`Neptune = 7` 

The planet Neptune.



`Pluto = 8` 

The planet Pluto.



`SSB = 12` 

The Solar System Barycenter.



`Saturn = 5` 

The planet Saturn.



`Star = 13` 

`Sun = 9` 

The Sun.



`Uranus = 6` 

The planet Uranus.



`Venus = 1` 

The planet Venus.



