# <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy"></a> Class Astronomy

Namespace: [ChargerAstronomyEngine.CosineKittyAstronomy](ChargerAstronomyEngine.CosineKittyAstronomy.md)  
Assembly: ChargerAstronomyEngine.dll  

The wrapper class that holds Astronomy Engine functions.

```csharp
public class Astronomy
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Astronomy](ChargerAstronomyEngine.CosineKittyAstronomy.Astronomy.md)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Fields

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_CalcMoonCount"></a> CalcMoonCount

Counter used for performance testing.

```csharp
public int CalcMoonCount
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_AngleBetween_ChargerAstronomyEngine_CosineKittyAstronomy_AstroVector_ChargerAstronomyEngine_CosineKittyAstronomy_AstroVector_"></a> AngleBetween\(AstroVector, AstroVector\)

Calculates the angle in degrees between two vectors.

```csharp
public double AngleBetween(AstroVector a, AstroVector b)
```

#### Parameters

`a` [AstroVector](ChargerAstronomyEngine.CosineKittyAstronomy.AstroVector.md)

The first of a pair of vectors between which to measure an angle.

`b` [AstroVector](ChargerAstronomyEngine.CosineKittyAstronomy.AstroVector.md)

The second of a pair of vectors between which to measure an angle.

#### Returns

 [double](https://learn.microsoft.com/dotnet/api/system.double)

The angle between the two vectors expressed in degrees.
The value is in the range [0, 180].

#### Remarks

Given a pair of vectors, this function returns the angle in degrees
between the two vectors in 3D space.
The angle is measured in the plane that contains both vectors.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_AngleFromSun_ChargerAstronomyShared_Domain_Equatorial_EquatorialCelestialBody_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> AngleFromSun\(EquatorialCelestialBody, AstroTime\)

Returns the angle between the given body and the Sun, as seen from the Earth.

```csharp
public double AngleFromSun(EquatorialCelestialBody body, AstroTime time)
```

#### Parameters

`body` [EquatorialCelestialBody](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md)

The celestial body whose angle from the Sun is to be measured.
Not allowed to be `Body.Earth`.

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The time at which the observation is made.

#### Returns

 [double](https://learn.microsoft.com/dotnet/api/system.double)

Returns the angle in degrees between the Sun and the specified body as
seen from the center of the Earth.

#### Remarks

This function calculates the angular separation between the given body and the Sun,
as seen from the center of the Earth. This angle is helpful for determining how
easy it is to see the body away from the glare of the Sun.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_Atmosphere_System_Double_"></a> Atmosphere\(double\)

Calculates U.S. Standard Atmosphere (1976) variables as a function of elevation.

```csharp
public AtmosphereInfo Atmosphere(double elevationMeters)
```

#### Parameters

`elevationMeters` [double](https://learn.microsoft.com/dotnet/api/system.double)

The elevation above sea level at which to calculate atmospheric variables.
Must be in the range -500 to +100000, or an exception will occur.

#### Returns

 [AtmosphereInfo](ChargerAstronomyEngine.CosineKittyAstronomy.AtmosphereInfo.md)

#### Remarks

This function calculates idealized values of pressure, temperature, and density
using the U.S. Standard Atmosphere (1976) model.
1. COESA, U.S. Standard Atmosphere, 1976, U.S. Government Printing Office, Washington, DC, 1976.
2. Jursa, A. S., Ed., Handbook of Geophysics and the Space Environment, Air Force Geophysics Laboratory, 1985.
See:
https://hbcp.chemnetbase.com/faces/documents/14_12/14_12_0001.xhtml
https://ntrs.nasa.gov/api/citations/19770009539/downloads/19770009539.pdf
https://www.ngdc.noaa.gov/stp/space-weather/online-publications/miscellaneous/us-standard-atmosphere-1976/us-standard-atmosphere_st76-1562_noaa.pdf

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_BackdatePosition_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_ChargerAstronomyShared_Domain_Equatorial_EquatorialCelestialBody_ChargerAstronomyShared_Domain_Equatorial_EquatorialCelestialBody_ChargerAstronomyEngine_CosineKittyAstronomy_Enums_Aberration_"></a> BackdatePosition\(AstroTime, EquatorialCelestialBody, EquatorialCelestialBody, Aberration\)

Solve for light travel time correction of apparent position.

```csharp
public AstroVector BackdatePosition(AstroTime time, EquatorialCelestialBody observerBody, EquatorialCelestialBody targetBody, Aberration aberration)
```

#### Parameters

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The time of observation.

`observerBody` [EquatorialCelestialBody](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md)

The body to be used as the observation location.

`targetBody` [EquatorialCelestialBody](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md)

The body to be observed.

`aberration` [Aberration](ChargerAstronomyEngine.CosineKittyAstronomy.Enums.Aberration.md)

`Aberration.Corrected` to correct for aberration, or `Aberration.None` to leave uncorrected.

#### Returns

 [AstroVector](ChargerAstronomyEngine.CosineKittyAstronomy.AstroVector.md)

The position vector at the solved backdated time.
Its `t` field holds the time that light left the observed
body to arrive at the observer at the observation time.

#### Remarks

When observing a distant object, for example Jupiter as seen from Earth,
the amount of time it takes for light to travel from the object to the
observer can significantly affect the object's apparent position.

This function solves the light travel time correction for the apparent
relative position vector of a target body as seen by an observer body
at a given observation time.

For geocentric calculations, #Astronomy.GeoVector also includes light
travel time correction, but the time `t` embedded in its returned vector
refers to the observation time, not the backdated time that light left
the observed body. Thus `BackdatePosition` provides direct
access to the light departure time for callers that need it.

For a more generalized light travel correction solver, see #Astronomy.CorrectLightTravel.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_BaryState_ChargerAstronomyShared_Domain_Equatorial_BodyType_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> BaryState\(BodyType, AstroTime\)

Calculates barycentric position and velocity vectors for the given body.

```csharp
public StateVector BaryState(BodyType body, AstroTime time)
```

#### Parameters

`body` [BodyType](ChargerAstronomyShared.Domain.Equatorial.BodyType.md)

The celestial body whose barycentric state vector is to be calculated.
Supported values are `Body.Sun`, `Body.Moon`, `Body.EMB`, `Body.SSB`, and all planets:
`Body.Mercury`, `Body.Venus`, `Body.Earth`, `Body.Mars`, `Body.Jupiter`,
`Body.Saturn`, `Body.Uranus`, `Body.Neptune`, `Body.Pluto`.

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time for which to calculate position and velocity.

#### Returns

 [StateVector](ChargerAstronomyEngine.CosineKittyAstronomy.StateVector.md)

A structure that contains barycentric position and velocity vectors.

#### Remarks

Given a body and a time, calculates the barycentric position and velocity
vectors for the center of that body at that time.
The vectors are expressed in J2000 mean equator coordinates (EQJ).

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_CombineRotation_ChargerAstronomyEngine_CosineKittyAstronomy_RotationMatrix_ChargerAstronomyEngine_CosineKittyAstronomy_RotationMatrix_"></a> CombineRotation\(RotationMatrix, RotationMatrix\)

Creates a rotation based on applying one rotation followed by another.

```csharp
public RotationMatrix CombineRotation(RotationMatrix a, RotationMatrix b)
```

#### Parameters

`a` [RotationMatrix](ChargerAstronomyEngine.CosineKittyAstronomy.RotationMatrix.md)

The first rotation to apply.

`b` [RotationMatrix](ChargerAstronomyEngine.CosineKittyAstronomy.RotationMatrix.md)

The second rotation to apply.

#### Returns

 [RotationMatrix](ChargerAstronomyEngine.CosineKittyAstronomy.RotationMatrix.md)

The combined rotation matrix.

#### Remarks

Given two rotation matrices, returns a combined rotation matrix that is
equivalent to rotating based on the first matrix, followed by the second.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_Constellation_System_Double_System_Double_"></a> Constellation\(double, double\)

Determines the constellation that contains the given point in the sky.

```csharp
public ConstellationInfo Constellation(double ra, double dec)
```

#### Parameters

`ra` [double](https://learn.microsoft.com/dotnet/api/system.double)

The right ascension (RA) of a point in the sky, using the J2000 equatorial system (EQJ).

`dec` [double](https://learn.microsoft.com/dotnet/api/system.double)

The declination (DEC) of a point in the sky, using the J2000 equatorial system (EQJ).

#### Returns

 [ConstellationInfo](ChargerAstronomyEngine.CosineKittyAstronomy.ConstellationInfo.md)

A structure that contains the 3-letter abbreviation and full name
of the constellation that contains the given (ra,dec), along with
the converted B1875 (ra,dec) for that point.

#### Remarks

Given J2000 equatorial (EQJ) coordinates of a point in the sky, determines the
constellation that contains that point.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_CorrectLightTravel_ChargerAstronomyEngine_CosineKittyAstronomy_IPositionFunction_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> CorrectLightTravel\(IPositionFunction, AstroTime\)

Solve for light travel time of a vector function.

```csharp
public AstroVector CorrectLightTravel(IPositionFunction func, AstroTime time)
```

#### Parameters

`func` [IPositionFunction](ChargerAstronomyEngine.CosineKittyAstronomy.IPositionFunction.md)

An arbitrary position vector as a function of time.

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The observation time for which to solve for light travel delay.

#### Returns

 [AstroVector](ChargerAstronomyEngine.CosineKittyAstronomy.AstroVector.md)

The position vector at the solved backdated time.
The `t` field holds the time that light left the observed
body to arrive at the observer at the observation time.

#### Remarks

When observing a distant object, for example Jupiter as seen from Earth,
the amount of time it takes for light to travel from the object to the
observer can significantly affect the object's apparent position.
This function is a generic solver that figures out how long in the
past light must have left the observed object to reach the observer
at the specified observation time. It uses #IPositionFunction
to express an arbitrary position vector as a function of time.

This function repeatedly calls `func.Position`, passing a series of time
estimates in the past. Then `func.Position` must return a relative state vector between
the observer and the target. `CorrectLightTravel` keeps calling
`func.Position` with more and more refined estimates of the time light must have
left the target to arrive at the observer.

For common use cases, it is simpler to use #Astronomy.BackdatePosition
for calculating the light travel time correction of one body observing another body.

For geocentric calculations, #Astronomy.GeoVector also backdates the returned
position vector for light travel time, only it returns the observation time in
the returned vector's `t` field rather than the backdated time.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_DeltaT_EspenakMeeus_System_Double_"></a> DeltaT\_EspenakMeeus\(double\)

The default Delta T function used by Astronomy Engine.

```csharp
public static double DeltaT_EspenakMeeus(double ut)
```

#### Parameters

`ut` [double](https://learn.microsoft.com/dotnet/api/system.double)

The floating point number of days since noon UTC on January 1, 2000.

#### Returns

 [double](https://learn.microsoft.com/dotnet/api/system.double)

The estimated difference TT-UT on the given date, expressed in seconds.

#### Remarks

Espenak and Meeus use a series of piecewise polynomials to
approximate DeltaT of the Earth in their "Five Millennium Canon of Solar Eclipses".
See: https://eclipse.gsfc.nasa.gov/SEhelp/deltatpoly2004.html
This is the default Delta T function used by Astronomy Engine.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_EclipticGeoMoon_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> EclipticGeoMoon\(AstroTime\)

Calculates spherical ecliptic geocentric position of the Moon.

```csharp
public Spherical EclipticGeoMoon(AstroTime time)
```

#### Parameters

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time for which to calculate the Moon's position.

#### Returns

 [Spherical](ChargerAstronomyEngine.CosineKittyAstronomy.Spherical.md)

#### Remarks

Given a time of observation, calculates the Moon's geocentric position
in ecliptic spherical coordinates. Provides the ecliptic latitude and
longitude in degrees, and the geocentric distance in astronomical units (AU).

The ecliptic angles are measured in "ECT": relative to the true ecliptic plane and
equatorial plane at the specified time. This means the Earth's equator
is corrected for precession and nutation, and the plane of the Earth's
orbit is corrected for gradual obliquity drift.

This algorithm is based on the Nautical Almanac Office's *Improved Lunar Ephemeris* of 1954,
which in turn derives from E. W. Brown's lunar theories from the early twentieth century.
It is adapted from Turbo Pascal code from the book
[Astronomy on the Personal Computer](https://www.springer.com/us/book/9783540672210)
by Montenbruck and Pfleger.

To calculate a J2000 mean equator vector instead, use #Astronomy.GeoMoon.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_EclipticLongitude_ChargerAstronomyShared_Domain_Equatorial_EquatorialCelestialBody_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> EclipticLongitude\(EquatorialCelestialBody, AstroTime\)

Calculates heliocentric ecliptic longitude of a body.

```csharp
public double EclipticLongitude(EquatorialCelestialBody body, AstroTime time)
```

#### Parameters

`body` [EquatorialCelestialBody](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md)

A body other than the Sun.

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time at which the body's ecliptic longitude is to be calculated.

#### Returns

 [double](https://learn.microsoft.com/dotnet/api/system.double)

Returns the ecliptic longitude in degrees of the given body at the given time.

#### Remarks

This function calculates the angle around the plane of the Earth's orbit
of a celestial body, as seen from the center of the Sun.
The angle is measured prograde (in the direction of the Earth's orbit around the Sun)
in degrees from the true equinox of date. The ecliptic longitude is always in the range [0, 360).

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_Elongation_ChargerAstronomyShared_Domain_Equatorial_EquatorialCelestialBody_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> Elongation\(EquatorialCelestialBody, AstroTime\)

Determines visibility of a celestial body relative to the Sun, as seen from the Earth.

```csharp
public ElongationInfo Elongation(EquatorialCelestialBody body, AstroTime time)
```

#### Parameters

`body` [EquatorialCelestialBody](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md)

The celestial body whose visibility is to be calculated.

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time of the observation.

#### Returns

 [ElongationInfo](ChargerAstronomyEngine.CosineKittyAstronomy.ElongationInfo.md)

Returns a valid #ElongationInfo structure, or throws an exception if there is an error.

#### Remarks

This function returns an #ElongationInfo structure, which provides the following
information about the given celestial body at the given time:

- `visibility` is an enumerated type that specifies whether the body is more easily seen
   in the morning before sunrise, or in the evening after sunset.

- `elongation` is the angle in degrees between two vectors: one from the center of the Earth to the
   center of the Sun, the other from the center of the Earth to the center of the specified body.
   This angle indicates how far away the body is from the glare of the Sun.
   The elongation angle is always in the range [0, 180].

- `ecliptic_separation` is the absolute value of the difference between the body's ecliptic longitude
  and the Sun's ecliptic longitude, both as seen from the center of the Earth. This angle measures
  around the plane of the Earth's orbit, and ignores how far above or below that plane the body is.
  The ecliptic separation is measured in degrees and is always in the range [0, 180].

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_Equator_ChargerAstronomyShared_Domain_Equatorial_EquatorialCelestialBody_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_ChargerAstronomyShared_Domain_Observer_ChargerAstronomyEngine_CosineKittyAstronomy_Enums_EquatorEpoch_ChargerAstronomyEngine_CosineKittyAstronomy_Enums_Aberration_"></a> Equator\(EquatorialCelestialBody, AstroTime, Observer, EquatorEpoch, Aberration\)

Calculates equatorial coordinates of a celestial body as seen by an observer on the Earth's surface.

```csharp
public Equatorial Equator(EquatorialCelestialBody body, AstroTime time, Observer observer, EquatorEpoch equdate, Aberration aberration)
```

#### Parameters

`body` [EquatorialCelestialBody](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md)

The celestial body to be observed. Not allowed to be `Body.Earth`.

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time at which the observation takes place.

`observer` [Observer](ChargerAstronomyShared.Domain.Observer.md)

A location on or near the surface of the Earth.

`equdate` [EquatorEpoch](ChargerAstronomyEngine.CosineKittyAstronomy.Enums.EquatorEpoch.md)

Selects the date of the Earth's equator in which to express the equatorial coordinates.

`aberration` [Aberration](ChargerAstronomyEngine.CosineKittyAstronomy.Enums.Aberration.md)

Selects whether or not to correct for aberration.

#### Returns

 [Equatorial](ChargerAstronomyEngine.CosineKittyAstronomy.Equatorial.md)

Topocentric equatorial coordinates of the celestial body.

#### Remarks

Calculates topocentric equatorial coordinates in one of two different systems:
J2000 or true-equator-of-date, depending on the value of the `equdate` parameter.
Equatorial coordinates include right ascension, declination, and distance in astronomical units.

This function corrects for light travel time: it adjusts the apparent location
of the observed body based on how long it takes for light to travel from the body to the Earth.

This function corrects for *topocentric parallax*, meaning that it adjusts for the
angular shift depending on where the observer is located on the Earth. This is most
significant for the Moon, because it is so close to the Earth. However, parallax corection
has a small effect on the apparent positions of other bodies.

Correction for aberration is optional, using the `aberration` parameter.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_EquatorFromVector_ChargerAstronomyEngine_CosineKittyAstronomy_AstroVector_"></a> EquatorFromVector\(AstroVector\)

Given an equatorial vector, calculates equatorial angular coordinates.

```csharp
public Equatorial EquatorFromVector(AstroVector vector)
```

#### Parameters

`vector` [AstroVector](ChargerAstronomyEngine.CosineKittyAstronomy.AstroVector.md)

A vector in an equatorial coordinate system.

#### Returns

 [Equatorial](ChargerAstronomyEngine.CosineKittyAstronomy.Equatorial.md)

Angular coordinates expressed in the same equatorial system as `vector`.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_EquatorialToEcliptic_ChargerAstronomyEngine_CosineKittyAstronomy_AstroVector_"></a> EquatorialToEcliptic\(AstroVector\)

Converts a J2000 mean equator (EQJ) vector to a true ecliptic of date (ETC) vector and angles.

```csharp
public Ecliptic EquatorialToEcliptic(AstroVector eqj)
```

#### Parameters

`eqj` [AstroVector](ChargerAstronomyEngine.CosineKittyAstronomy.AstroVector.md)

Equatorial coordinates in the J2000 frame of reference.
You can call #Astronomy.GeoVector to obtain suitable equatorial coordinates.

#### Returns

 [Ecliptic](ChargerAstronomyEngine.CosineKittyAstronomy.Ecliptic.md)

Spherical and vector coordinates expressed in true ecliptic coordinates of date (ECT).

#### Remarks

Given coordinates relative to the Earth's equator at J2000 (the instant of noon UTC
on 1 January 2000), this function converts those coordinates to true ecliptic coordinates of date,
which are relative to the plane of the Earth's orbit around the Sun.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_GeoEmbState_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> GeoEmbState\(AstroTime\)

Calculates the geocentric position and velocity of the Earth/Moon barycenter.

```csharp
public StateVector GeoEmbState(AstroTime time)
```

#### Parameters

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time for which to calculate the EMB vectors.

#### Returns

 [StateVector](ChargerAstronomyEngine.CosineKittyAstronomy.StateVector.md)

The EMB's position and velocity vectors in geocentric J2000 equatorial coordinates.

#### Remarks

Given a time of observation, calculates the geocentric position and velocity vectors
of the Earth/Moon barycenter (EMB).
The position (x, y, z) components are expressed in AU (astronomical units).
The velocity (vx, vy, vz) components are expressed in AU/day.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_GeoMoon_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> GeoMoon\(AstroTime\)

Calculates equatorial geocentric position of the Moon at a given time.

```csharp
public AstroVector GeoMoon(AstroTime time)
```

#### Parameters

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time for which to calculate the Moon's position.

#### Returns

 [AstroVector](ChargerAstronomyEngine.CosineKittyAstronomy.AstroVector.md)

The Moon's position vector in J2000 equatorial coordinates (EQJ).

#### Remarks

Given a time of observation, calculates the Moon's position vector.
The vector indicates the Moon's center relative to the Earth's center.
The vector components are expressed in AU (astronomical units).
The coordinates are oriented with respect to the Earth's equator at the J2000 epoch.
In Astronomy Engine, this orientation is called EQJ.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_GeoMoonState_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> GeoMoonState\(AstroTime\)

Calculates equatorial geocentric position and velocity of the Moon at a given time.

```csharp
public StateVector GeoMoonState(AstroTime time)
```

#### Parameters

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time for which to calculate the Moon's position and velocity.

#### Returns

 [StateVector](ChargerAstronomyEngine.CosineKittyAstronomy.StateVector.md)

The Moon's position and velocity vectors in J2000 equatorial coordinates (EQJ).

#### Remarks

Given a time of observation, calculates the Moon's position and velocity vectors.
The position and velocity are of the Moon's center relative to the Earth's center.
The position (x, y, z) components are expressed in AU (astronomical units).
The velocity (vx, vy, vz) components are expressed in AU/day.
The coordinates are oriented with respect to the Earth's equator at the J2000 epoch.
In Astronomy Engine, this orientation is called EQJ.
If you need the Moon's position only, and not its velocity,
it is much more efficient to use #Astronomy.GeoMoon instead.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_GeoVector_ChargerAstronomyShared_Domain_Equatorial_EquatorialCelestialBody_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_ChargerAstronomyEngine_CosineKittyAstronomy_Enums_Aberration_"></a> GeoVector\(EquatorialCelestialBody, AstroTime, Aberration\)

Calculates geocentric Cartesian coordinates of a body in the J2000 equatorial system.

```csharp
public AstroVector GeoVector(EquatorialCelestialBody body, AstroTime time, Aberration aberration)
```

#### Parameters

`body` [EquatorialCelestialBody](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md)

A body for which to calculate a heliocentric position: the Sun, Moon, or any of the planets.

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time for which to calculate the position.

`aberration` [Aberration](ChargerAstronomyEngine.CosineKittyAstronomy.Enums.Aberration.md)

`Aberration.Corrected` to correct for aberration, or `Aberration.None` to leave uncorrected.

#### Returns

 [AstroVector](ChargerAstronomyEngine.CosineKittyAstronomy.AstroVector.md)

A geocentric position vector of the center of the given body.

#### Remarks

This function calculates the position of the given celestial body as a vector,
using the center of the Earth as the origin.  The result is expressed as a Cartesian
vector in the J2000 equatorial system: the coordinates are based on the mean equator
of the Earth at noon UTC on 1 January 2000.

If given an invalid value for `body`, this function will throw an exception.

Unlike #Astronomy.HelioVector, this function corrects for light travel time.
This means the position of the body is "back-dated" by the amount of time it takes
light to travel from that body to an observer on the Earth.

Also, the position can optionally be corrected for
[aberration](https://en.wikipedia.org/wiki/Aberration_of_light), an effect
causing the apparent direction of the body to be shifted due to transverse
movement of the Earth with respect to the rays of light coming from that body.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_GlobalSolarEclipsesAfter_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> GlobalSolarEclipsesAfter\(AstroTime\)

Enumerates a series of global solar eclipses that occur after a specified time.

```csharp
public IEnumerable<GlobalSolarEclipseInfo> GlobalSolarEclipsesAfter(AstroTime startTime)
```

#### Parameters

`startTime` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

Specifies the time to begin searching for consecutive solar eclipses.

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[GlobalSolarEclipseInfo](ChargerAstronomyEngine.CosineKittyAstronomy.GlobalSolarEclipseInfo.md)\>

#### Remarks

This is a convenience wrapper around the functions
#Astronomy.SearchGlobalSolarEclipse and #Astronomy.NextGlobalSolarEclipse.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_HelioDistance_ChargerAstronomyShared_Domain_Equatorial_EquatorialCelestialBody_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> HelioDistance\(EquatorialCelestialBody, AstroTime\)

Calculates the distance between a body and the Sun at a given time.

```csharp
public double HelioDistance(EquatorialCelestialBody body, AstroTime time)
```

#### Parameters

`body` [EquatorialCelestialBody](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md)

A body for which to calculate a heliocentric distance:
the Sun, Moon, EMB, SSB, any of the planets, or a user-defined star.

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time for which to calculate the heliocentric distance.

#### Returns

 [double](https://learn.microsoft.com/dotnet/api/system.double)

The heliocentric distance in AU.

#### Remarks

Given a date and time, this function calculates the distance between
the center of `body` and the center of the Sun, expressed in AU.
For the planets Mercury through Neptune, this function is significantly
more efficient than calling #Astronomy.HelioVector followed by taking the length
of the resulting vector.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_HelioState_ChargerAstronomyShared_Domain_Equatorial_EquatorialCelestialBody_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> HelioState\(EquatorialCelestialBody, AstroTime\)

Calculates heliocentric position and velocity vectors for the given body.

```csharp
public StateVector HelioState(EquatorialCelestialBody body, AstroTime time)
```

#### Parameters

`body` [EquatorialCelestialBody](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md)

The celestial body whose heliocentric state vector is to be calculated.
Supported values are `Body.Sun`, `Body.Moon`, `Body.EMB`, `Body.SSB`, and all planets:
`Body.Mercury`, `Body.Venus`, `Body.Earth`, `Body.Mars`, `Body.Jupiter`,
`Body.Saturn`, `Body.Uranus`, `Body.Neptune`, `Body.Pluto`.
Also allowed to be a user-defined star created by #Astronomy.DefineStar.

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time for which to calculate position and velocity.

#### Returns

 [StateVector](ChargerAstronomyEngine.CosineKittyAstronomy.StateVector.md)

A structure that contains heliocentric position and velocity vectors.

#### Remarks

Given a body and a time, calculates the position and velocity
vectors for the center of that body at that time, relative to the center of the Sun.
The vectors are expressed in J2000 mean equator coordinates (EQJ).
If you need the position vector only, it is more efficient to call #Astronomy.HelioVector.
The Sun's center is a non-inertial frame of reference. In other words, the Sun
experiences acceleration due to gravitational forces, mostly from the larger
planets (Jupiter, Saturn, Uranus, and Neptune). If you want to calculate momentum,
kinetic energy, or other quantities that require a non-accelerating frame
of reference, consider using #Astronomy.BaryState instead.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_HelioVector_ChargerAstronomyShared_Domain_Equatorial_EquatorialCelestialBody_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> HelioVector\(EquatorialCelestialBody, AstroTime\)

Calculates heliocentric Cartesian coordinates of a body in the J2000 equatorial system.

```csharp
public AstroVector HelioVector(EquatorialCelestialBody body, AstroTime time)
```

#### Parameters

`body` [EquatorialCelestialBody](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md)

A body for which to calculate a heliocentric position:
the Sun, Moon, EMB, SSB, or any of the planets.
Also allowed to be a user-defined star created by #Astronomy.DefineStar.

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time for which to calculate the position.

#### Returns

 [AstroVector](ChargerAstronomyEngine.CosineKittyAstronomy.AstroVector.md)

A heliocentric position vector of the center of the given body.

#### Remarks

This function calculates the position of the given celestial body as a vector,
using the center of the Sun as the origin.  The result is expressed as a Cartesian
vector in the J2000 equatorial system: the coordinates are based on the mean equator
of the Earth at noon UTC on 1 January 2000.

The position is not corrected for light travel time or aberration.
This is different from the behavior of #Astronomy.GeoVector.

If given an invalid value for `body`, this function will throw an #InvalidBodyException.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_Horizon_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_ChargerAstronomyShared_Domain_Observer_ChargerAstronomyEngine_CosineKittyAstronomy_Equatorial_ChargerAstronomyEngine_CosineKittyAstronomy_Enums_Refraction_"></a> Horizon\(AstroTime, Observer, Equatorial, Refraction\)

Calculates the apparent location of a body relative to the local horizon of an observer on the Earth.

```csharp
public Topocentric Horizon(AstroTime time, Observer observer, Equatorial eq, Refraction refraction)
```

#### Parameters

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time of the observation.

`observer` [Observer](ChargerAstronomyShared.Domain.Observer.md)

The geographic location of the observer.

`eq` [Equatorial](ChargerAstronomyEngine.CosineKittyAstronomy.Equatorial.md)

`refraction` [Refraction](ChargerAstronomyEngine.CosineKittyAstronomy.Enums.Refraction.md)

Selects whether to correct for atmospheric refraction, and if so, which model to use.
The recommended value for most uses is `Refraction.Normal`.
See remarks above for more details.

#### Returns

 [Topocentric](ChargerAstronomyEngine.CosineKittyAstronomy.Topocentric.md)

The body's apparent horizontal coordinates and equatorial coordinates, both optionally corrected for refraction.

#### Remarks

Given a date and time, the geographic location of an observer on the Earth, and
equatorial coordinates (right ascension and declination) of a celestial body,
this function returns horizontal coordinates (azimuth and altitude angles) for the body
relative to the horizon at the geographic location.

The right ascension `ra` and declination `dec` passed in must be *equator of date*
coordinates, based on the Earth's true equator at the date and time of the observation.
Otherwise the resulting horizontal coordinates will be inaccurate.
Equator of date coordinates can be obtained by calling #Astronomy.Equator, passing in
`EquatorEpoch.OfDate` as its `equdate` parameter. It is also recommended to enable
aberration correction by passing in `Aberration.Corrected` as the `aberration` parameter.

This function optionally corrects for atmospheric refraction.
For most uses, it is recommended to pass `Refraction.Normal` in the `refraction` parameter to
correct for optical lensing of the Earth's atmosphere that causes objects
to appear somewhat higher above the horizon than they actually are.
However, callers may choose to avoid this correction by passing in `Refraction.None`.
If refraction correction is enabled, the azimuth, altitude, right ascension, and declination
in the #Topocentric structure returned by this function will all be corrected for refraction.
If refraction is disabled, none of these four coordinates will be corrected; in that case,
the right ascension and declination in the returned structure will be numerically identical
to the respective `ra` and `dec` values passed in.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_HorizonFromVector_ChargerAstronomyEngine_CosineKittyAstronomy_AstroVector_ChargerAstronomyEngine_CosineKittyAstronomy_Enums_Refraction_"></a> HorizonFromVector\(AstroVector, Refraction\)

Converts Cartesian coordinates to horizontal coordinates.

```csharp
public Spherical HorizonFromVector(AstroVector vector, Refraction refraction)
```

#### Parameters

`vector` [AstroVector](ChargerAstronomyEngine.CosineKittyAstronomy.AstroVector.md)

Cartesian vector to be converted to horizontal coordinates.

`refraction` [Refraction](ChargerAstronomyEngine.CosineKittyAstronomy.Enums.Refraction.md)

`Refraction.Normal`: correct altitude for atmospheric refraction (recommended).
`Refraction.None`: no atmospheric refraction correction is performed.
`Refraction.JplHor`: for JPL Horizons compatibility testing only; not recommended for normal use.

#### Returns

 [Spherical](ChargerAstronomyEngine.CosineKittyAstronomy.Spherical.md)

Horizontal spherical coordinates as described above.

#### Remarks

Given a horizontal Cartesian vector, returns horizontal azimuth and altitude.

*IMPORTANT:* This function differs from #Astronomy.SphereFromVector in two ways:
- `Astronomy.SphereFromVector` returns a `lon` value that represents azimuth defined counterclockwise
  from north (e.g., west = +90), but this function represents a clockwise rotation
  (e.g., east = +90). The difference is because `Astronomy.SphereFromVector` is intended
  to preserve the vector "right-hand rule", while this function defines azimuth in a more
  traditional way as used in navigation and cartography.
- This function optionally corrects for atmospheric refraction, while `Astronomy.SphereFromVector`
  does not.

The returned structure contains the azimuth in `lon`.
It is measured in degrees clockwise from north: east = +90 degrees, west = +270 degrees.

The altitude is stored in `lat`.

The distance to the observed object is stored in `dist`,
and is expressed in astronomical units (AU).

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_HourAngle_ChargerAstronomyShared_Domain_Equatorial_EquatorialCelestialBody_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_ChargerAstronomyShared_Domain_Observer_"></a> HourAngle\(EquatorialCelestialBody, AstroTime, Observer\)

Finds the hour angle of a body for a given observer and time.

```csharp
public double HourAngle(EquatorialCelestialBody body, AstroTime time, Observer observer)
```

#### Parameters

`body` [EquatorialCelestialBody](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md)

The body whose observed hour angle is to be found.

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The time of the observation.

`observer` [Observer](ChargerAstronomyShared.Domain.Observer.md)

The geographic location where the observation takes place.

#### Returns

 [double](https://learn.microsoft.com/dotnet/api/system.double)

The real-valued hour angle of the body in the half-open range [0, 24).

#### Remarks

The *hour angle* of a celestial body indicates its position in the sky with respect
to the Earth's rotation. The hour angle depends on the location of the observer on the Earth.
The hour angle is 0 when the body's center reaches its highest angle above the horizon in a given day.
The hour angle increases by 1 unit for every sidereal hour that passes after that point, up
to 24 sidereal hours when it reaches the highest point again. So the hour angle indicates
the number of hours that have passed since the most recent time that the body has culminated,
or reached its highest point.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_IdentityMatrix"></a> IdentityMatrix\(\)

Creates an identity rotation matrix.

```csharp
public RotationMatrix IdentityMatrix()
```

#### Returns

 [RotationMatrix](ChargerAstronomyEngine.CosineKittyAstronomy.RotationMatrix.md)

The identity matrix.

#### Remarks

Returns a rotation matrix that has no effect on orientation.
This matrix can be the starting point for other operations,
such as using a series of calls to #Astronomy.Pivot to
create a custom rotation matrix.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_Illumination_ChargerAstronomyShared_Domain_Equatorial_EquatorialCelestialBody_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> Illumination\(EquatorialCelestialBody, AstroTime\)

Finds visual magnitude, phase angle, and other illumination information about a celestial body.

```csharp
public IllumInfo Illumination(EquatorialCelestialBody body, AstroTime time)
```

#### Parameters

`body` [EquatorialCelestialBody](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md)

The Sun, Moon, or any planet other than the Earth.

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time of the observation.

#### Returns

 [IllumInfo](ChargerAstronomyEngine.CosineKittyAstronomy.IllumInfo.md)

An #IllumInfo structure with fields as documented above.

#### Remarks

This function calculates information about how bright a celestial body appears from the Earth,
reported as visual magnitude, which is a smaller (or even negative) number for brighter objects
and a larger number for dimmer objects.

For bodies other than the Sun, it reports a phase angle, which is the angle in degrees between
the Sun and the Earth, as seen from the center of the body. Phase angle indicates what fraction
of the body appears illuminated as seen from the Earth. For example, when the phase angle is
near zero, it means the body appears "full" as seen from the Earth.  A phase angle approaching
180 degrees means the body appears as a thin crescent as seen from the Earth.  A phase angle
of 90 degrees means the body appears "half full".
For the Sun, the phase angle is always reported as 0; the Sun emits light rather than reflecting it,
so it doesn't have a phase angle.

When the body is Saturn, the returned structure contains a field `ring_tilt` that holds
the tilt angle in degrees of Saturn's rings as seen from the Earth. A value of 0 means
the rings appear edge-on, and are thus nearly invisible from the Earth. The `ring_tilt` holds
0 for all bodies other than Saturn.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_InverseRefractionAngle_ChargerAstronomyEngine_CosineKittyAstronomy_Enums_Refraction_System_Double_"></a> InverseRefractionAngle\(Refraction, double\)

Calculates the inverse of an atmospheric refraction angle.

```csharp
public double InverseRefractionAngle(Refraction refraction, double bent_altitude)
```

#### Parameters

`refraction` [Refraction](ChargerAstronomyEngine.CosineKittyAstronomy.Enums.Refraction.md)

The option selecting which refraction correction to use.
See #Astronomy.RefractionAngle.

`bent_altitude` [double](https://learn.microsoft.com/dotnet/api/system.double)

The apparent altitude that includes atmospheric refraction.

#### Returns

 [double](https://learn.microsoft.com/dotnet/api/system.double)

The angular adjustment in degrees to be added to the
altitude angle to correct for atmospheric lensing.
This will be less than or equal to zero.

#### Remarks

Given an observed altitude angle that includes atmospheric refraction,
calculates the negative angular correction to obtain the unrefracted
altitude. This is useful for cases where observed horizontal
coordinates are to be converted to another orientation system,
but refraction first must be removed from the observed position.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_InverseRotation_ChargerAstronomyEngine_CosineKittyAstronomy_RotationMatrix_"></a> InverseRotation\(RotationMatrix\)

Calculates the inverse of a rotation matrix.

```csharp
public RotationMatrix InverseRotation(RotationMatrix rotation)
```

#### Parameters

`rotation` [RotationMatrix](ChargerAstronomyEngine.CosineKittyAstronomy.RotationMatrix.md)

The rotation matrix to be inverted.

#### Returns

 [RotationMatrix](ChargerAstronomyEngine.CosineKittyAstronomy.RotationMatrix.md)

A rotation matrix that performs the opposite transformation.

#### Remarks

Given a rotation matrix that performs some coordinate transform,
this function returns the matrix that reverses that transform.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_JupiterMoons_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> JupiterMoons\(AstroTime\)

Calculates jovicentric positions and velocities of Jupiter's largest 4 moons.

```csharp
public JupiterMoonsInfo JupiterMoons(AstroTime time)
```

#### Parameters

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time for which to calculate the position vectors.

#### Returns

 [JupiterMoonsInfo](ChargerAstronomyEngine.CosineKittyAstronomy.JupiterMoonsInfo.md)

Position and velocity vectors of Jupiter's largest 4 moons.

#### Remarks

Calculates position and velocity vectors for Jupiter's moons
Io, Europa, Ganymede, and Callisto, at the given date and time.
The vectors are jovicentric (relative to the center of Jupiter).
Their orientation is the Earth's equatorial system at the J2000 epoch (EQJ).
The position components are expressed in astronomical units (AU), and the
velocity components are in AU/day.

To convert to heliocentric position vectors, call #Astronomy.HelioVector
with `Body.Jupiter` to get Jupiter's heliocentric position, then
add the jovicentric positions. Likewise, you can call #Astronomy.GeoVector
to convert to geocentric positions; however, you will have to manually
correct for light travel time from the Jupiter system to Earth to
figure out what time to pass to `jupiterMoons` to get an accurate picture
of how Jupiter and its moons look from Earth.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_LagrangePoint_System_Int32_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_ChargerAstronomyShared_Domain_Equatorial_EquatorialCelestialBody_ChargerAstronomyShared_Domain_Equatorial_EquatorialCelestialBody_"></a> LagrangePoint\(int, AstroTime, EquatorialCelestialBody, EquatorialCelestialBody\)

Calculates one of the 5 Lagrange points for a pair of co-orbiting bodies.

```csharp
public StateVector LagrangePoint(int point, AstroTime time, EquatorialCelestialBody major_body, EquatorialCelestialBody minor_body)
```

#### Parameters

`point` [int](https://learn.microsoft.com/dotnet/api/system.int32)

An integer 1..5 that selects which of the Lagrange points to calculate.

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The time for which the Lagrange point is to be calculated.

`major_body` [EquatorialCelestialBody](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md)

The more massive of the co-orbiting bodies: `Body.Sun` or `Body.Earth`.

`minor_body` [EquatorialCelestialBody](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md)

The less massive of the co-orbiting bodies. See main remarks.

#### Returns

 [StateVector](ChargerAstronomyEngine.CosineKittyAstronomy.StateVector.md)

The position and velocity of the selected Lagrange point with respect to the major body's center.

#### Remarks

Given a more massive "major" body and a much less massive "minor" body,
calculates one of the five Lagrange points in relation to the minor body's
orbit around the major body. The parameter `point` is an integer that
selects the Lagrange point as follows:

1 = the Lagrange point between the major body and minor body.
2 = the Lagrange point on the far side of the minor body.
3 = the Lagrange point on the far side of the major body.
4 = the Lagrange point 60 degrees ahead of the minor body's orbital position.
5 = the Lagrange point 60 degrees behind the minor body's orbital position.

The function returns the state vector for the selected Lagrange point
in J2000 mean equator coordinates (EQJ), with respect to the center of the
major body.

To calculate Sun/Earth Lagrange points, pass in `Body.Sun` for `major_body`
and `Body.EMB` (Earth/Moon barycenter) for `minor_body`.
For Lagrange points of the Sun and any other planet, pass in just that planet
(e.g. `Body.Jupiter`) for `minor_body`.
To calculate Earth/Moon Lagrange points, pass in `Body.Earth` and `Body.Moon`
for the major and minor bodies respectively.

In some cases, it may be more efficient to call #Astronomy.LagrangePointFast,
especially when the state vectors have already been calculated, or are needed
for some other purpose.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_LagrangePointFast_System_Int32_ChargerAstronomyEngine_CosineKittyAstronomy_StateVector_System_Double_ChargerAstronomyEngine_CosineKittyAstronomy_StateVector_System_Double_"></a> LagrangePointFast\(int, StateVector, double, StateVector, double\)

Calculates one of the 5 Lagrange points from body masses and state vectors.

```csharp
public StateVector LagrangePointFast(int point, StateVector major_state, double major_mass, StateVector minor_state, double minor_mass)
```

#### Parameters

`point` [int](https://learn.microsoft.com/dotnet/api/system.int32)

An integer 1..5 that selects which of the Lagrange points to calculate.

`major_state` [StateVector](ChargerAstronomyEngine.CosineKittyAstronomy.StateVector.md)

The state vector of the major (more massive) of the pair of bodies.

`major_mass` [double](https://learn.microsoft.com/dotnet/api/system.double)

The mass product GM of the major body.

`minor_state` [StateVector](ChargerAstronomyEngine.CosineKittyAstronomy.StateVector.md)

The state vector of the minor (less massive) of the pair of bodies.

`minor_mass` [double](https://learn.microsoft.com/dotnet/api/system.double)

The mass product GM of the minor body.

#### Returns

 [StateVector](ChargerAstronomyEngine.CosineKittyAstronomy.StateVector.md)

The position and velocity of the selected Lagrange point with respect to the major body's center.

#### Remarks

Given a more massive "major" body and a much less massive "minor" body,
calculates one of the five Lagrange points in relation to the minor body's
orbit around the major body. The parameter `point` is an integer that
selects the Lagrange point as follows:

1 = the Lagrange point between the major body and minor body.
2 = the Lagrange point on the far side of the minor body.
3 = the Lagrange point on the far side of the major body.
4 = the Lagrange point 60 degrees ahead of the minor body's orbital position.
5 = the Lagrange point 60 degrees behind the minor body's orbital position.

The caller passes in the state vector and mass for both bodies.
The state vectors can be in any orientation and frame of reference.
The body masses are expressed as GM products, where G = the universal
gravitation constant and M = the body's mass. Thus the units for
`major_mass` and `minor_mass` must be au^3/day^2.
Use #Astronomy.MassProduct to obtain GM values for various solar system bodies.

The function returns the state vector for the selected Lagrange point
using the same orientation as the state vector parameters `major_state` and `minor_state`,
and the position and velocity components are with respect to the major body's center.

Consider calling #Astronomy.LagrangePoint, instead of this function, for simpler usage in most cases.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_Libration_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> Libration\(AstroTime\)

Calculates the Moon's libration angles at a given moment in time.

```csharp
public LibrationInfo Libration(AstroTime time)
```

#### Parameters

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time for which to calculate lunar libration.

#### Returns

 [LibrationInfo](ChargerAstronomyEngine.CosineKittyAstronomy.LibrationInfo.md)

The Moon's ecliptic position and libration angles as seen from the Earth.

#### Remarks

Libration is an observed back-and-forth wobble of the portion of the
Moon visible from the Earth. It is caused by the imperfect tidal locking
of the Moon's fixed rotation rate, compared to its variable angular speed
of orbit around the Earth.

This function calculates a pair of perpendicular libration angles,
one representing rotation of the Moon in ecliptic longitude `elon`, the other
in ecliptic latitude `elat`, both relative to the Moon's mean Earth-facing position.

This function also returns the geocentric position of the Moon
expressed in ecliptic longitude `mlon`, ecliptic latitude `mlat`, the
distance `dist_km` between the centers of the Earth and Moon expressed in kilometers,
and the apparent angular diameter of the Moon `diam_deg`.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_LocalSolarEclipsesAfter_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_ChargerAstronomyShared_Domain_Observer_"></a> LocalSolarEclipsesAfter\(AstroTime, Observer\)

Enumerates a series of local solar eclipses that occur after a specified time.

```csharp
public IEnumerable<LocalSolarEclipseInfo> LocalSolarEclipsesAfter(AstroTime startTime, Observer observer)
```

#### Parameters

`startTime` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

Specifies the time to begin searching for consecutive solar eclipses.

`observer` [Observer](ChargerAstronomyShared.Domain.Observer.md)

The geographic location of the observer.

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[LocalSolarEclipseInfo](ChargerAstronomyEngine.CosineKittyAstronomy.LocalSolarEclipseInfo.md)\>

#### Remarks

This is a convenience wrapper around the functions
#Astronomy.SearchLocalSolarEclipse and #Astronomy.NextLocalSolarEclipse.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_LunarApsidesAfter_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> LunarApsidesAfter\(AstroTime\)

Enumerates a series of apogees/perigees that occur after a specified time.

```csharp
public IEnumerable<ApsisInfo> LunarApsidesAfter(AstroTime startTime)
```

#### Parameters

`startTime` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

Specifies the time to begin searching for consecutive lunar apsides.

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[ApsisInfo](ChargerAstronomyEngine.CosineKittyAstronomy.ApsisInfo.md)\>

#### Remarks

This is a convenience wrapper around the functions
#Astronomy.SearchLunarApsis and #Astronomy.NextLunarApsis.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_LunarEclipsesAfter_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> LunarEclipsesAfter\(AstroTime\)

Enumerates a series of lunar eclipses that occur after a specified time.

```csharp
public IEnumerable<LunarEclipseInfo> LunarEclipsesAfter(AstroTime startTime)
```

#### Parameters

`startTime` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

Specifies the time to begin searching for consecutive lunar eclipses.

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[LunarEclipseInfo](ChargerAstronomyEngine.CosineKittyAstronomy.LunarEclipseInfo.md)\>

#### Remarks

This is a convenience wrapper around the functions
#Astronomy.SearchLunarEclipse and #Astronomy.NextLunarEclipse.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_MassProduct_ChargerAstronomyShared_Domain_Equatorial_BodyType_"></a> MassProduct\(BodyType\)

Returns the product of mass and universal gravitational constant of a Solar System body.

```csharp
public double MassProduct(BodyType body)
```

#### Parameters

`body` [BodyType](ChargerAstronomyShared.Domain.Equatorial.BodyType.md)

The body for which to find the GM product.
Allowed to be the Sun, Moon, EMB (Earth/Moon Barycenter), or any planet.
Any other value will cause an exception to be thrown.

#### Returns

 [double](https://learn.microsoft.com/dotnet/api/system.double)

The mass product of the given body in au^3/day^2.

#### Remarks

For problems involving the gravitational interactions of Solar System bodies,
it is helpful to know the product GM, where G = the universal gravitational constant
and M = the mass of the body. In practice, GM is known to a higher precision than
either G or M alone, and thus using the product results in the most accurate results.
This function returns the product GM in the units au^3/day^2.
The values come from page 10 of a
[JPL memorandum regarding the DE405/LE405 ephemeris](https://web.archive.org/web/20120220062549/http://iau-comm4.jpl.nasa.gov/de405iom/de405iom.pdf).

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_MoonNodesAfter_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> MoonNodesAfter\(AstroTime\)

Enumerates a series of ascending/descending nodes of the Moon that occur after a specified time.

```csharp
public IEnumerable<NodeEventInfo> MoonNodesAfter(AstroTime startTime)
```

#### Parameters

`startTime` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

Specifies the time to begin searching for consecutive lunar apsides.

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[NodeEventInfo](ChargerAstronomyEngine.CosineKittyAstronomy.NodeEventInfo.md)\>

#### Remarks

This is a convenience wrapper around the functions
#Astronomy.SearchMoonNode and #Astronomy.NextMoonNode.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_MoonPhase_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> MoonPhase\(AstroTime\)

Returns the Moon's phase as an angle from 0 to 360 degrees.

```csharp
public double MoonPhase(AstroTime time)
```

#### Parameters

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time of the observation.

#### Returns

 [double](https://learn.microsoft.com/dotnet/api/system.double)

The angle as described above, a value in the range 0..360 degrees.

#### Remarks

This function determines the phase of the Moon using its apparent
ecliptic longitude relative to the Sun, as seen from the center of the Earth.
Certain values of the angle have conventional definitions:

- 0 = new moon
- 90 = first quarter
- 180 = full moon
- 270 = third quarter

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_MoonQuartersAfter_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> MoonQuartersAfter\(AstroTime\)

Enumerates a series of lunar quarter phases that occur after a specified time.

```csharp
public IEnumerable<MoonQuarterInfo> MoonQuartersAfter(AstroTime startTime)
```

#### Parameters

`startTime` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

Specifies the time to begin searching for consecutive lunar quarter phases.

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[MoonQuarterInfo](ChargerAstronomyEngine.CosineKittyAstronomy.MoonQuarterInfo.md)\>

#### Remarks

This is a convenience wrapper around the functions
#Astronomy.SearchMoonQuarter and #Astronomy.NextMoonQuarter.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_NextGlobalSolarEclipse_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> NextGlobalSolarEclipse\(AstroTime\)

Searches for the next global solar eclipse in a series.

```csharp
public GlobalSolarEclipseInfo NextGlobalSolarEclipse(AstroTime prevEclipseTime)
```

#### Parameters

`prevEclipseTime` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

A date and time near a new moon. Solar eclipse search will start at the next new moon.

#### Returns

 [GlobalSolarEclipseInfo](ChargerAstronomyEngine.CosineKittyAstronomy.GlobalSolarEclipseInfo.md)

#### Remarks

After using #Astronomy.SearchGlobalSolarEclipse to find the first solar eclipse
in a series, you can call this function to find the next consecutive solar eclipse.
Pass in the `peak` value from the #GlobalSolarEclipseInfo returned by the
previous call to `Astronomy.SearchGlobalSolarEclipse` or `Astronomy.NextGlobalSolarEclipse`
to find the next solar eclipse.

See #Astronomy.GlobalSolarEclipsesAfter for a convenient enumerator.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_NextLocalSolarEclipse_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_ChargerAstronomyShared_Domain_Observer_"></a> NextLocalSolarEclipse\(AstroTime, Observer\)

Searches for the next local solar eclipse in a series.

```csharp
public LocalSolarEclipseInfo NextLocalSolarEclipse(AstroTime prevEclipseTime, Observer observer)
```

#### Parameters

`prevEclipseTime` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

A date and time near a new moon. Solar eclipse search will start at the next new moon.

`observer` [Observer](ChargerAstronomyShared.Domain.Observer.md)

The geographic location of the observer.

#### Returns

 [LocalSolarEclipseInfo](ChargerAstronomyEngine.CosineKittyAstronomy.LocalSolarEclipseInfo.md)

#### Remarks

After using #Astronomy.SearchLocalSolarEclipse to find the first solar eclipse
in a series, you can call this function to find the next consecutive solar eclipse.
Pass in the `peak` value from the #LocalSolarEclipseInfo returned by the
previous call to `Astronomy.SearchLocalSolarEclipse` or `Astronomy.NextLocalSolarEclipse`
to find the next solar eclipse.

See #Astronomy.LocalSolarEclipsesAfter for a convenient enumerator.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_NextLunarApsis_ChargerAstronomyEngine_CosineKittyAstronomy_ApsisInfo_"></a> NextLunarApsis\(ApsisInfo\)

Finds the next lunar perigee or apogee event in a series.

```csharp
public ApsisInfo NextLunarApsis(ApsisInfo apsis)
```

#### Parameters

`apsis` [ApsisInfo](ChargerAstronomyEngine.CosineKittyAstronomy.ApsisInfo.md)

An apsis event obtained from a call to #Astronomy.SearchLunarApsis or `Astronomy.NextLunarApsis`.
See #Astronomy.SearchLunarApsis for more details.

#### Returns

 [ApsisInfo](ChargerAstronomyEngine.CosineKittyAstronomy.ApsisInfo.md)

Same as the return value for #Astronomy.SearchLunarApsis.

#### Remarks

This function requires an #ApsisInfo value obtained from a call
to #Astronomy.SearchLunarApsis or `Astronomy.NextLunarApsis`. Given
an apogee event, this function finds the next perigee event, and vice versa.

See #Astronomy.SearchLunarApsis for more details.
See #Astronomy.LunarApsidesAfter for a convenient enumerator.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_NextLunarEclipse_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> NextLunarEclipse\(AstroTime\)

Searches for the next lunar eclipse in a series.

```csharp
public LunarEclipseInfo NextLunarEclipse(AstroTime prevEclipseTime)
```

#### Parameters

`prevEclipseTime` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

A date and time near a full moon. Lunar eclipse search will start at the next full moon.

#### Returns

 [LunarEclipseInfo](ChargerAstronomyEngine.CosineKittyAstronomy.LunarEclipseInfo.md)

A #LunarEclipseInfo structure containing information about the lunar eclipse.

#### Remarks

After using #Astronomy.SearchLunarEclipse to find the first lunar eclipse
in a series, you can call this function to find the next consecutive lunar eclipse.
Pass in the `center` value from the #LunarEclipseInfo returned by the
previous call to `Astronomy.SearchLunarEclipse` or `Astronomy.NextLunarEclipse`
to find the next lunar eclipse.

See #Astronomy.LunarEclipsesAfter for a convenient enumerator.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_NextMoonNode_ChargerAstronomyEngine_CosineKittyAstronomy_NodeEventInfo_"></a> NextMoonNode\(NodeEventInfo\)

Searches for the next time when the Moon's center crosses through the ecliptic plane.

```csharp
public NodeEventInfo NextMoonNode(NodeEventInfo prevNode)
```

#### Parameters

`prevNode` [NodeEventInfo](ChargerAstronomyEngine.CosineKittyAstronomy.NodeEventInfo.md)

The previous node found from calling #Astronomy.SearchMoonNode or `Astronomy.NextMoonNode`.

#### Returns

 [NodeEventInfo](ChargerAstronomyEngine.CosineKittyAstronomy.NodeEventInfo.md)

#### Remarks

Call #Astronomy.SearchMoonNode to find the first of a series of nodes.
Then call `Astronomy.NextMoonNode` to find as many more consecutive nodes as desired.

See #Astronomy.MoonNodesAfter for a convenient enumerator.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_NextMoonQuarter_ChargerAstronomyEngine_CosineKittyAstronomy_MoonQuarterInfo_"></a> NextMoonQuarter\(MoonQuarterInfo\)

Continues searching for lunar quarters from a previous search.

```csharp
public MoonQuarterInfo NextMoonQuarter(MoonQuarterInfo mq)
```

#### Parameters

`mq` [MoonQuarterInfo](ChargerAstronomyEngine.CosineKittyAstronomy.MoonQuarterInfo.md)

The previous moon quarter found by a call to #Astronomy.SearchMoonQuarter or `Astronomy.NextMoonQuarter`.

#### Returns

 [MoonQuarterInfo](ChargerAstronomyEngine.CosineKittyAstronomy.MoonQuarterInfo.md)

The moon quarter that occurs next in time after the one passed in `mq`.

#### Remarks

After calling #Astronomy.SearchMoonQuarter, this function can be called
one or more times to continue finding consecutive lunar quarters.
This function finds the next consecutive moon quarter event after
the one passed in as the parameter `mq`.

See #Astronomy.MoonQuartersAfter for a convenient enumerator.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_NextPlanetApsis_ChargerAstronomyShared_Domain_Equatorial_EquatorialCelestialBody_ChargerAstronomyEngine_CosineKittyAstronomy_ApsisInfo_"></a> NextPlanetApsis\(EquatorialCelestialBody, ApsisInfo\)

Finds the next planetary perihelion or aphelion event in a series.

```csharp
public ApsisInfo NextPlanetApsis(EquatorialCelestialBody body, ApsisInfo apsis)
```

#### Parameters

`body` [EquatorialCelestialBody](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md)

The planet for which to find the next perihelion/aphelion event.
Not allowed to be `Body.Sun` or `Body.Moon`.
Must match the body passed into the call that produced the `apsis` parameter.

`apsis` [ApsisInfo](ChargerAstronomyEngine.CosineKittyAstronomy.ApsisInfo.md)

An apsis event obtained from a call to #Astronomy.SearchPlanetApsis or `Astronomy.NextPlanetApsis`.

#### Returns

 [ApsisInfo](ChargerAstronomyEngine.CosineKittyAstronomy.ApsisInfo.md)

Same as the return value for #Astronomy.SearchPlanetApsis.

#### Remarks

This function requires an #ApsisInfo value obtained from a call
to #Astronomy.SearchPlanetApsis or `Astronomy.NextPlanetApsis`.
Given an aphelion event, this function finds the next perihelion event, and vice versa.

See #Astronomy.SearchPlanetApsis for more details.
See #Astronomy.PlanetApsidesAfter for a convenient enumerator.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_NextTransit_ChargerAstronomyShared_Domain_Equatorial_EquatorialCelestialBody_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> NextTransit\(EquatorialCelestialBody, AstroTime\)

Searches for another transit of Mercury or Venus.

```csharp
public TransitInfo NextTransit(EquatorialCelestialBody body, AstroTime prevTransitTime)
```

#### Parameters

`body` [EquatorialCelestialBody](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md)

The planet whose transit is to be found. Must be `Body.Mercury` or `Body.Venus`.

`prevTransitTime` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

A date and time near the previous transit.

#### Returns

 [TransitInfo](ChargerAstronomyEngine.CosineKittyAstronomy.TransitInfo.md)

#### Remarks

After calling #Astronomy.SearchTransit to find a transit of Mercury or Venus,
this function finds the next transit after that.
Keep calling this function as many times as you want to keep finding more transits.

See #Astronomy.TransitsAfter for a convenient enumerator.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_ObserverGravity_System_Double_System_Double_"></a> ObserverGravity\(double, double\)

Calculates the gravitational acceleration experienced by an observer on the Earth.

```csharp
public static double ObserverGravity(double latitude, double height)
```

#### Parameters

`latitude` [double](https://learn.microsoft.com/dotnet/api/system.double)

The latitude of the observer in degrees north or south of the equator.
By formula symmetry, positive latitudes give the same answer as negative
latitudes, so the sign does not matter.

`height` [double](https://learn.microsoft.com/dotnet/api/system.double)

The height above the sea level geoid in meters.
No range checking is done; however, accuracy is only valid in the
range 0 to 100000 meters.

#### Returns

 [double](https://learn.microsoft.com/dotnet/api/system.double)

The effective gravitational acceleration expressed in meters per second squared [m/s^2].

#### Remarks

This function implements the WGS 84 Ellipsoidal Gravity Formula.
The result is a combination of inward gravitational acceleration
with outward centrifugal acceleration, as experienced by an observer
in the Earth's rotating frame of reference.
The resulting value increases toward the Earth's poles and decreases
toward the equator, consistent with changes of the weight measured
by a spring scale of a fixed mass moved to different latitudes and heights
on the Earth.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_ObserverState_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_ChargerAstronomyShared_Domain_Observer_ChargerAstronomyEngine_CosineKittyAstronomy_Enums_EquatorEpoch_"></a> ObserverState\(AstroTime, Observer, EquatorEpoch\)

Calculates geocentric equatorial position and velocity of an observer on the surface of the Earth.

```csharp
public StateVector ObserverState(AstroTime time, Observer observer, EquatorEpoch equdate)
```

#### Parameters

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time for which to calculate the observer's geocentric state vector.

`observer` [Observer](ChargerAstronomyShared.Domain.Observer.md)

The geographic location of a point on or near the surface of the Earth.

`equdate` [EquatorEpoch](ChargerAstronomyEngine.CosineKittyAstronomy.Enums.EquatorEpoch.md)

Selects the date of the Earth's equator in which to express the equatorial coordinates.
The caller may select `EquatorEpoch.J2000` to use the orientation of the Earth's equator
at noon UTC on January 1, 2000, in which case this function corrects for precession
and nutation of the Earth as it was at the moment specified by the `time` parameter.
Or the caller may select `EquatorEpoch.OfDate` to use the Earth's equator at `time`
as the orientation.

#### Returns

 [StateVector](ChargerAstronomyEngine.CosineKittyAstronomy.StateVector.md)

The position and velocity of the given geographic location, relative to the center of the Earth.

#### Remarks

This function calculates position and velocity vectors of an observer
on or near the surface of the Earth, expressed in equatorial
coordinates. It takes into account the rotation of the Earth at the given
time, along with the given latitude, longitude, and elevation of the observer.

The caller may pass a value in `equdate` to select either `EquatorEpoch.J2000`
for using J2000 coordinates, or `EquatorEpoch.OfDate` for using coordinates relative
to the Earth's equator at the specified time.

The returned position vector has components expressed in astronomical units (AU).
To convert to kilometers, multiply the `x`, `y`, and `z` values by
the constant value #Astronomy.KM_PER_AU.

The returned velocity vector is measured in AU/day.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_ObserverVector_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_ChargerAstronomyShared_Domain_Observer_ChargerAstronomyEngine_CosineKittyAstronomy_Enums_EquatorEpoch_"></a> ObserverVector\(AstroTime, Observer, EquatorEpoch\)

Calculates geocentric equatorial coordinates of an observer on the surface of the Earth.

```csharp
public AstroVector ObserverVector(AstroTime time, Observer observer, EquatorEpoch equdate)
```

#### Parameters

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time for which to calculate the observer's position vector.

`observer` [Observer](ChargerAstronomyShared.Domain.Observer.md)

The geographic location of a point on or near the surface of the Earth.

`equdate` [EquatorEpoch](ChargerAstronomyEngine.CosineKittyAstronomy.Enums.EquatorEpoch.md)

Selects the date of the Earth's equator in which to express the equatorial coordinates.
The caller may select `EquatorEpoch.J2000` to use the orientation of the Earth's equator
at noon UTC on January 1, 2000, in which case this function corrects for precession
and nutation of the Earth as it was at the moment specified by the `time` parameter.
Or the caller may select `EquatorEpoch.OfDate` to use the Earth's equator at `time`
as the orientation.

#### Returns

 [AstroVector](ChargerAstronomyEngine.CosineKittyAstronomy.AstroVector.md)

An equatorial vector from the center of the Earth to the specified location
on (or near) the Earth's surface.

#### Remarks

This function calculates a vector from the center of the Earth to
a point on or near the surface of the Earth, expressed in equatorial
coordinates. It takes into account the rotation of the Earth at the given
time, along with the given latitude, longitude, and elevation of the observer.

The caller may pass a value in `equdate` to select either `EquatorEpoch.J2000`
for using J2000 coordinates, or `EquatorEpoch.OfDate` for using coordinates relative
to the Earth's equator at the specified time.

The returned vector has components expressed in astronomical units (AU).
To convert to kilometers, multiply the `x`, `y`, and `z` values by
the constant value #Astronomy.KM_PER_AU.

The inverse of this function is also available: #Astronomy.VectorObserver.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_PairLongitude_ChargerAstronomyShared_Domain_Equatorial_EquatorialCelestialBody_ChargerAstronomyShared_Domain_Equatorial_EquatorialCelestialBody_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> PairLongitude\(EquatorialCelestialBody, EquatorialCelestialBody, AstroTime\)

Returns one body's ecliptic longitude with respect to another, as seen from the Earth.

```csharp
public double PairLongitude(EquatorialCelestialBody body1, EquatorialCelestialBody body2, AstroTime time)
```

#### Parameters

`body1` [EquatorialCelestialBody](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md)

The first body, whose longitude is to be found relative to the second body.

`body2` [EquatorialCelestialBody](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md)

The second body, relative to which the longitude of the first body is to be found.

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time of the observation.

#### Returns

 [double](https://learn.microsoft.com/dotnet/api/system.double)

An angle in the range [0, 360), expressed in degrees.

#### Remarks

This function determines where one body appears around the ecliptic plane
(the plane of the Earth's orbit around the Sun) as seen from the Earth,
relative to the another body's apparent position.
The function returns an angle in the half-open range [0, 360) degrees.
The value is the ecliptic longitude of `body1` relative to the ecliptic
longitude of `body2`.

The angle is 0 when the two bodies are at the same ecliptic longitude
as seen from the Earth. The angle increases in the prograde direction
(the direction that the planets orbit the Sun and the Moon orbits the Earth).

When the angle is 180 degrees, it means the two bodies appear on opposite sides
of the sky for an Earthly observer.

Neither `body1` nor `body2` is allowed to be `Body.Earth`.
If this happens, the function throws an exception.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_Pivot_ChargerAstronomyEngine_CosineKittyAstronomy_RotationMatrix_System_Int32_System_Double_"></a> Pivot\(RotationMatrix, int, double\)

Re-orients a rotation matrix by pivoting it by an angle around one of its axes.

```csharp
public RotationMatrix Pivot(RotationMatrix rotation, int axis, double angle)
```

#### Parameters

`rotation` [RotationMatrix](ChargerAstronomyEngine.CosineKittyAstronomy.RotationMatrix.md)

The input rotation matrix.

`axis` [int](https://learn.microsoft.com/dotnet/api/system.int32)

An integer that selects which coordinate axis to rotate around:
0 = x, 1 = y, 2 = z. Any other value will cause an ArgumentException to be thrown.

`angle` [double](https://learn.microsoft.com/dotnet/api/system.double)

An angle in degrees indicating the amount of rotation around the specified axis.
Positive angles indicate rotation counterclockwise as seen from the positive
direction along that axis, looking towards the origin point of the orientation system.
Any finite number of degrees is allowed, but best precision will result from keeping
`angle` in the range [-360, +360].

#### Returns

 [RotationMatrix](ChargerAstronomyEngine.CosineKittyAstronomy.RotationMatrix.md)

A pivoted matrix object.

#### Remarks

Given a rotation matrix, a selected coordinate axis, and an angle in degrees,
this function pivots the rotation matrix by that angle around that coordinate axis.

For example, if you have rotation matrix that converts ecliptic coordinates (ECL)
to horizontal coordinates (HOR), but you really want to convert ECL to the orientation
of a telescope camera pointed at a given body, you can use `Astronomy.Pivot` twice:
(1) pivot around the zenith axis by the body's azimuth, then (2) pivot around the
western axis by the body's altitude angle. The resulting rotation matrix will then
reorient ECL coordinates to the orientation of your telescope camera.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_PlanetApsidesAfter_ChargerAstronomyShared_Domain_Equatorial_EquatorialCelestialBody_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> PlanetApsidesAfter\(EquatorialCelestialBody, AstroTime\)

Enumerates a series of planet aphelia/perihelia that occur after a specified time.

```csharp
public IEnumerable<ApsisInfo> PlanetApsidesAfter(EquatorialCelestialBody body, AstroTime startTime)
```

#### Parameters

`body` [EquatorialCelestialBody](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md)

The planet for which to find a series of consecutive aphelia/perihelia.
Not allowed to be `Body.Sun` or `Body.Moon`.

`startTime` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

Specifies the time to begin searching for consecutive planetary apsides.

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[ApsisInfo](ChargerAstronomyEngine.CosineKittyAstronomy.ApsisInfo.md)\>

#### Remarks

This is a convenience wrapper around the functions
#Astronomy.SearchPlanetApsis and #Astronomy.NextPlanetApsis.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_PlanetOrbitalPeriod_ChargerAstronomyShared_Domain_Equatorial_BodyType_"></a> PlanetOrbitalPeriod\(BodyType\)

Returns the average number of days it takes for a planet to orbit the Sun.

```csharp
public double PlanetOrbitalPeriod(BodyType body)
```

#### Parameters

`body` [BodyType](ChargerAstronomyShared.Domain.Equatorial.BodyType.md)

One of the planets: Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune, or Pluto.

#### Returns

 [double](https://learn.microsoft.com/dotnet/api/system.double)

The mean orbital period of the body in days.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_RefractionAngle_ChargerAstronomyEngine_CosineKittyAstronomy_Enums_Refraction_System_Double_"></a> RefractionAngle\(Refraction, double\)

Calculates the amount of "lift" to an altitude angle caused by atmospheric refraction.

```csharp
public double RefractionAngle(Refraction refraction, double altitude)
```

#### Parameters

`refraction` [Refraction](ChargerAstronomyEngine.CosineKittyAstronomy.Enums.Refraction.md)

The option selecting which refraction correction to use.
If `Refraction.Normal`, uses a well-behaved refraction model that works well for
all valid values (-90 to +90) of `altitude`.
If `Refraction.JplHor`, this function returns a compatible value with the JPL Horizons tool.
If any other value (including `Refraction.None`), this function returns 0.

`altitude` [double](https://learn.microsoft.com/dotnet/api/system.double)

An altitude angle in a horizontal coordinate system. Must be a value between -90 and +90.

#### Returns

 [double](https://learn.microsoft.com/dotnet/api/system.double)

The angular adjustment in degrees to be added to the altitude angle to correct for atmospheric lensing.

#### Remarks

Given an altitude angle and a refraction option, calculates
the amount of "lift" caused by atmospheric refraction.
This is the number of degrees higher in the sky an object appears
due to the lensing of the Earth's atmosphere.
This function works best near sea level.
To correct for higher elevations, call #Astronomy.Atmosphere for that
elevation and multiply the refraction angle by the resulting relative density.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_RotateState_ChargerAstronomyEngine_CosineKittyAstronomy_RotationMatrix_ChargerAstronomyEngine_CosineKittyAstronomy_StateVector_"></a> RotateState\(RotationMatrix, StateVector\)

Applies a rotation to a state vector, yielding a rotated state vector.

```csharp
public StateVector RotateState(RotationMatrix rotation, StateVector state)
```

#### Parameters

`rotation` [RotationMatrix](ChargerAstronomyEngine.CosineKittyAstronomy.RotationMatrix.md)

A rotation matrix that specifies how the orientation of the state vector is to be changed.

`state` [StateVector](ChargerAstronomyEngine.CosineKittyAstronomy.StateVector.md)

The state vector whose orientation is to be changed.

#### Returns

 [StateVector](ChargerAstronomyEngine.CosineKittyAstronomy.StateVector.md)

A state vector in the orientation specified by `rotation`.

#### Remarks

This function transforms a state vector in one orientation to a state vector in another orientation.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_RotateVector_ChargerAstronomyEngine_CosineKittyAstronomy_RotationMatrix_ChargerAstronomyEngine_CosineKittyAstronomy_AstroVector_"></a> RotateVector\(RotationMatrix, AstroVector\)

Applies a rotation to a vector, yielding a rotated vector.

```csharp
public AstroVector RotateVector(RotationMatrix rotation, AstroVector vector)
```

#### Parameters

`rotation` [RotationMatrix](ChargerAstronomyEngine.CosineKittyAstronomy.RotationMatrix.md)

A rotation matrix that specifies how the orientation of the vector is to be changed.

`vector` [AstroVector](ChargerAstronomyEngine.CosineKittyAstronomy.AstroVector.md)

The vector whose orientation is to be changed.

#### Returns

 [AstroVector](ChargerAstronomyEngine.CosineKittyAstronomy.AstroVector.md)

A vector in the orientation specified by `rotation`.

#### Remarks

This function transforms a vector in one orientation to a vector
in another orientation.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_RotationAxis_ChargerAstronomyShared_Domain_Equatorial_BodyType_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> RotationAxis\(BodyType, AstroTime\)

Calculates information about a body's rotation axis at a given time.

```csharp
public AxisInfo RotationAxis(BodyType body, AstroTime time)
```

#### Parameters

`body` [BodyType](ChargerAstronomyShared.Domain.Equatorial.BodyType.md)

One of the following values:
`Body.Sun`, `Body.Moon`, `Body.Mercury`, `Body.Venus`, `Body.Earth`, `Body.Mars`,
`Body.Jupiter`, `Body.Saturn`, `Body.Uranus`, `Body.Neptune`, `Body.Pluto`.

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The time at which to calculate the body's rotation axis.

#### Returns

 [AxisInfo](ChargerAstronomyEngine.CosineKittyAstronomy.AxisInfo.md)

North pole orientation and body spin angle.

#### Remarks

Calculates the orientation of a body's rotation axis, along with
the rotation angle of its prime meridian, at a given moment in time.

This function uses formulas standardized by the IAU Working Group
on Cartographics and Rotational Elements 2015 report, as described
in the following document:

https://astropedia.astrogeology.usgs.gov/download/Docs/WGCCRE/WGCCRE2015reprint.pdf

See #AxisInfo for more detailed information.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_Rotation_ECL_EQD_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> Rotation\_ECL\_EQD\(AstroTime\)

Calculates a rotation matrix from J2000 mean ecliptic (ECL) to equatorial of-date (EQD).

```csharp
public RotationMatrix Rotation_ECL_EQD(AstroTime time)
```

#### Parameters

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time of the desired equator.

#### Returns

 [RotationMatrix](ChargerAstronomyEngine.CosineKittyAstronomy.RotationMatrix.md)

A rotation matrix that converts ECL to EQD.

#### Remarks

This is one of the family of functions that returns a rotation matrix
for converting from one orientation to another.
Source: ECL = ecliptic system, using equator at J2000 epoch.
Target: EQD = equatorial system, using equator of date.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_Rotation_ECL_EQJ"></a> Rotation\_ECL\_EQJ\(\)

Calculates a rotation matrix from J2000 mean ecliptic (ECL) to J2000 mean equator (EQJ).

```csharp
public RotationMatrix Rotation_ECL_EQJ()
```

#### Returns

 [RotationMatrix](ChargerAstronomyEngine.CosineKittyAstronomy.RotationMatrix.md)

A rotation matrix that converts ECL to EQJ.

#### Remarks

This is one of the family of functions that returns a rotation matrix
for converting from one orientation to another.
Source: ECL = ecliptic system, using equator at J2000 epoch.
Target: EQJ = equatorial system, using equator at J2000 epoch.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_Rotation_ECL_HOR_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_ChargerAstronomyShared_Domain_Observer_"></a> Rotation\_ECL\_HOR\(AstroTime, Observer\)

Calculates a rotation matrix from J2000 mean ecliptic (ECL) to horizontal (HOR).

```csharp
public RotationMatrix Rotation_ECL_HOR(AstroTime time, Observer observer)
```

#### Parameters

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time of the desired horizontal orientation.

`observer` [Observer](ChargerAstronomyShared.Domain.Observer.md)

A location near the Earth's mean sea level that defines the observer's horizon.

#### Returns

 [RotationMatrix](ChargerAstronomyEngine.CosineKittyAstronomy.RotationMatrix.md)

A rotation matrix that converts ECL to HOR at `time` and for `observer`.
The components of the horizontal vector are:
x = north, y = west, z = zenith (straight up from the observer).
These components are chosen so that the "right-hand rule" works for the vector
and so that north represents the direction where azimuth = 0.

#### Remarks

This is one of the family of functions that returns a rotation matrix
for converting from one orientation to another.
Source: ECL = ecliptic system, using equator at J2000 epoch.
Target: HOR = horizontal system.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_Rotation_ECT_EQD_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> Rotation\_ECT\_EQD\(AstroTime\)

Calculates a rotation matrix from true ecliptic of date (ECT) to equator of date (EQD).

```csharp
public RotationMatrix Rotation_ECT_EQD(AstroTime time)
```

#### Parameters

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time of the ecliptic/equator conversion.

#### Returns

 [RotationMatrix](ChargerAstronomyEngine.CosineKittyAstronomy.RotationMatrix.md)

A rotation matrix that converts ECT to EQD.

#### Remarks

This is one of the family of functions that returns a rotation matrix
for converting from one orientation to another.
Source: ECT = true ecliptic of date.
Target: EQD = equator of date.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_Rotation_ECT_EQJ_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> Rotation\_ECT\_EQJ\(AstroTime\)

Calculates a rotation matrix from true ecliptic of date (ECT) to J2000 mean equator (EQJ).

```csharp
public RotationMatrix Rotation_ECT_EQJ(AstroTime time)
```

#### Parameters

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time at which the Earth's equator defines the target orientation.

#### Returns

 [RotationMatrix](ChargerAstronomyEngine.CosineKittyAstronomy.RotationMatrix.md)

A rotation matrix that converts ECT to EQJ at `time`.

#### Remarks

This is one of the family of functions that returns a rotation matrix
for converting from one orientation to another.
Source: ECT = ecliptic system, using true equinox of the specified date/time.
Target: EQJ = equatorial system, using equator at J2000 epoch.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_Rotation_EQD_ECL_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> Rotation\_EQD\_ECL\(AstroTime\)

Calculates a rotation matrix from equatorial of-date (EQD) to J2000 mean ecliptic (ECL).

```csharp
public RotationMatrix Rotation_EQD_ECL(AstroTime time)
```

#### Parameters

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time of the source equator.

#### Returns

 [RotationMatrix](ChargerAstronomyEngine.CosineKittyAstronomy.RotationMatrix.md)

A rotation matrix that converts EQD to ECL.

#### Remarks

This is one of the family of functions that returns a rotation matrix
for converting from one orientation to another.
Source: EQD = equatorial system, using equator of date.
Target: ECL = ecliptic system, using equator at J2000 epoch.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_Rotation_EQD_ECT_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> Rotation\_EQD\_ECT\(AstroTime\)

Calculates a rotation matrix from equator of date (EQD) to true ecliptic of date (ECT) .

```csharp
public RotationMatrix Rotation_EQD_ECT(AstroTime time)
```

#### Parameters

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time of the equator/ecliptic conversion.

#### Returns

 [RotationMatrix](ChargerAstronomyEngine.CosineKittyAstronomy.RotationMatrix.md)

A rotation matrix that converts EQD to ECT.

#### Remarks

This is one of the family of functions that returns a rotation matrix
for converting from one orientation to another.
Source: EQD = equator of date.
Target: ECT = true ecliptic of date.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_Rotation_EQD_EQJ_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> Rotation\_EQD\_EQJ\(AstroTime\)

Calculates a rotation matrix from equatorial of-date (EQD) to J2000 mean equator (EQJ).

```csharp
public RotationMatrix Rotation_EQD_EQJ(AstroTime time)
```

#### Parameters

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time at which the Earth's equator defines the source orientation.

#### Returns

 [RotationMatrix](ChargerAstronomyEngine.CosineKittyAstronomy.RotationMatrix.md)

A rotation matrix that converts EQD at `time` to EQJ.

#### Remarks

This is one of the family of functions that returns a rotation matrix
for converting from one orientation to another.
Source: EQD = equatorial system, using equator of the specified date/time.
Target: EQJ = equatorial system, using equator at J2000 epoch.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_Rotation_EQD_HOR_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_ChargerAstronomyShared_Domain_Observer_"></a> Rotation\_EQD\_HOR\(AstroTime, Observer\)

Calculates a rotation matrix from equatorial of-date (EQD) to horizontal (HOR).

```csharp
public RotationMatrix Rotation_EQD_HOR(AstroTime time, Observer observer)
```

#### Parameters

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time at which the Earth's equator applies.

`observer` [Observer](ChargerAstronomyShared.Domain.Observer.md)

A location near the Earth's mean sea level that defines the observer's horizon.

#### Returns

 [RotationMatrix](ChargerAstronomyEngine.CosineKittyAstronomy.RotationMatrix.md)

A rotation matrix that converts EQD to HOR at `time` and for `observer`.
The components of the horizontal vector are:
x = north, y = west, z = zenith (straight up from the observer).
These components are chosen so that the "right-hand rule" works for the vector
and so that north represents the direction where azimuth = 0.

#### Remarks

This is one of the family of functions that returns a rotation matrix
for converting from one orientation to another.
Source: EQD = equatorial system, using equator of the specified date/time.
Target: HOR = horizontal system.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_Rotation_EQJ_ECL"></a> Rotation\_EQJ\_ECL\(\)

Calculates a rotation matrix from J2000 mean equator (EQJ) to J2000 mean ecliptic (ECL).

```csharp
public RotationMatrix Rotation_EQJ_ECL()
```

#### Returns

 [RotationMatrix](ChargerAstronomyEngine.CosineKittyAstronomy.RotationMatrix.md)

A rotation matrix that converts EQJ to ECL.

#### Remarks

This is one of the family of functions that returns a rotation matrix
for converting from one orientation to another.
Source: EQJ = equatorial system, using equator at J2000 epoch.
Target: ECL = ecliptic system, using equator at J2000 epoch.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_Rotation_EQJ_ECT_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> Rotation\_EQJ\_ECT\(AstroTime\)

Calculates a rotation matrix from J2000 mean equator (EQJ) to true ecliptic of date (ECT).

```csharp
public RotationMatrix Rotation_EQJ_ECT(AstroTime time)
```

#### Parameters

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time at which the Earth's equator defines the target orientation.

#### Returns

 [RotationMatrix](ChargerAstronomyEngine.CosineKittyAstronomy.RotationMatrix.md)

A rotation matrix that converts EQJ to ECT at `time`.

#### Remarks

This is one of the family of functions that returns a rotation matrix
for converting from one orientation to another.
Source: EQJ = equatorial system, using equator at J2000 epoch.
Target: ECT = ecliptic system, using true equinox of the specified date/time.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_Rotation_EQJ_EQD_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> Rotation\_EQJ\_EQD\(AstroTime\)

Calculates a rotation matrix from J2000 mean equator (EQJ) to equatorial of-date (EQD).

```csharp
public RotationMatrix Rotation_EQJ_EQD(AstroTime time)
```

#### Parameters

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time at which the Earth's equator defines the target orientation.

#### Returns

 [RotationMatrix](ChargerAstronomyEngine.CosineKittyAstronomy.RotationMatrix.md)

A rotation matrix that converts EQJ to EQD at `time`.

#### Remarks

This is one of the family of functions that returns a rotation matrix
for converting from one orientation to another.
Source: EQJ = equatorial system, using equator at J2000 epoch.
Target: EQD = equatorial system, using equator of the specified date/time.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_Rotation_EQJ_GAL"></a> Rotation\_EQJ\_GAL\(\)

Calculates a rotation matrix from J2000 mean equator (EQJ) to galactic (GAL).

```csharp
public RotationMatrix Rotation_EQJ_GAL()
```

#### Returns

 [RotationMatrix](ChargerAstronomyEngine.CosineKittyAstronomy.RotationMatrix.md)

A rotation matrix that converts EQJ to GAL.

#### Remarks

This is one of the family of functions that returns a rotation matrix
for converting from one orientation to another.
Source: EQJ = equatorial system, using the equator at the J2000 epoch.
Target: GAL = galactic system (IAU 1958 definition).

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_Rotation_EQJ_HOR_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_ChargerAstronomyShared_Domain_Observer_"></a> Rotation\_EQJ\_HOR\(AstroTime, Observer\)

Calculates a rotation matrix from J2000 mean equator (EQJ) to horizontal (HOR).

```csharp
public RotationMatrix Rotation_EQJ_HOR(AstroTime time, Observer observer)
```

#### Parameters

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time of the desired horizontal orientation.

`observer` [Observer](ChargerAstronomyShared.Domain.Observer.md)

A location near the Earth's mean sea level that defines the observer's horizon.

#### Returns

 [RotationMatrix](ChargerAstronomyEngine.CosineKittyAstronomy.RotationMatrix.md)

A rotation matrix that converts EQJ to HOR at `time` and for `observer`.
The components of the horizontal vector are:
x = north, y = west, z = zenith (straight up from the observer).
These components are chosen so that the "right-hand rule" works for the vector
and so that north represents the direction where azimuth = 0.

#### Remarks

This is one of the family of functions that returns a rotation matrix
for converting from one orientation to another.
Source: EQJ = equatorial system, using the equator at the J2000 epoch.
Target: HOR = horizontal system.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_Rotation_GAL_EQJ"></a> Rotation\_GAL\_EQJ\(\)

Calculates a rotation matrix from galactic (GAL) to J2000 mean equator (EQJ).

```csharp
public RotationMatrix Rotation_GAL_EQJ()
```

#### Returns

 [RotationMatrix](ChargerAstronomyEngine.CosineKittyAstronomy.RotationMatrix.md)

A rotation matrix that converts GAL to EQJ.

#### Remarks

This is one of the family of functions that returns a rotation matrix
for converting from one orientation to another.
Source: GAL = galactic system (IAU 1958 definition).
Target: EQJ = equatorial system, using the equator at the J2000 epoch.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_Rotation_HOR_ECL_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_ChargerAstronomyShared_Domain_Observer_"></a> Rotation\_HOR\_ECL\(AstroTime, Observer\)

Calculates a rotation matrix from horizontal (HOR) to J2000 mean ecliptic (ECL).

```csharp
public RotationMatrix Rotation_HOR_ECL(AstroTime time, Observer observer)
```

#### Parameters

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time of the horizontal observation.

`observer` [Observer](ChargerAstronomyShared.Domain.Observer.md)

The location of the horizontal observer.

#### Returns

 [RotationMatrix](ChargerAstronomyEngine.CosineKittyAstronomy.RotationMatrix.md)

A rotation matrix that converts HOR to ECL.

#### Remarks

This is one of the family of functions that returns a rotation matrix
for converting from one orientation to another.
Source: HOR = horizontal system.
Target: ECL = ecliptic system, using equator at J2000 epoch.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_Rotation_HOR_EQD_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_ChargerAstronomyShared_Domain_Observer_"></a> Rotation\_HOR\_EQD\(AstroTime, Observer\)

Calculates a rotation matrix from horizontal (HOR) to equatorial of-date (EQD).

```csharp
public RotationMatrix Rotation_HOR_EQD(AstroTime time, Observer observer)
```

#### Parameters

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time at which the Earth's equator applies.

`observer` [Observer](ChargerAstronomyShared.Domain.Observer.md)

A location near the Earth's mean sea level that defines the observer's horizon.

#### Returns

 [RotationMatrix](ChargerAstronomyEngine.CosineKittyAstronomy.RotationMatrix.md)

A rotation matrix that converts HOR to EQD at `time` and for `observer`.

#### Remarks

This is one of the family of functions that returns a rotation matrix
for converting from one orientation to another.
Source: HOR = horizontal system (x=North, y=West, z=Zenith).
Target: EQD = equatorial system, using equator of the specified date/time.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_Rotation_HOR_EQJ_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_ChargerAstronomyShared_Domain_Observer_"></a> Rotation\_HOR\_EQJ\(AstroTime, Observer\)

Calculates a rotation matrix from horizontal (HOR) to J2000 equatorial (EQJ).

```csharp
public RotationMatrix Rotation_HOR_EQJ(AstroTime time, Observer observer)
```

#### Parameters

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time of the observation.

`observer` [Observer](ChargerAstronomyShared.Domain.Observer.md)

A location near the Earth's mean sea level that defines the observer's horizon.

#### Returns

 [RotationMatrix](ChargerAstronomyEngine.CosineKittyAstronomy.RotationMatrix.md)

A rotation matrix that converts HOR to EQJ at `time` and for `observer`.

#### Remarks

This is one of the family of functions that returns a rotation matrix
for converting from one orientation to another.
Source: HOR = horizontal system (x=North, y=West, z=Zenith).
Target: EQJ = equatorial system, using equator at the J2000 epoch.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_Search_ChargerAstronomyEngine_CosineKittyAstronomy_SearchContexts_SearchContext_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_System_Double_"></a> Search\(SearchContext, AstroTime, AstroTime, double\)

Searches for a time at which a function's value increases through zero.

```csharp
public AstroTime Search(SearchContext func, AstroTime t1, AstroTime t2, double dt_tolerance_seconds)
```

#### Parameters

`func` [SearchContext](ChargerAstronomyEngine.CosineKittyAstronomy.SearchContexts.SearchContext.md)

The function for which to find the time of an ascending root.
See remarks above for more details.

`t1` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The lower time bound of the search window.
See remarks above for more details.

`t2` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The upper time bound of the search window.
See remarks above for more details.

`dt_tolerance_seconds` [double](https://learn.microsoft.com/dotnet/api/system.double)

Specifies an amount of time in seconds within which a bounded ascending root
is considered accurate enough to stop. A typical value is 1 second.

#### Returns

 [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

If successful, returns an #AstroTime value indicating a date and time
that is within `dt_tolerance_seconds` of an ascending root.
If no ascending root is found, or more than one root exists in the time
window `t1`..`t2`, the function returns `null`.
If the search does not converge within 20 iterations, an exception is thrown.

#### Remarks

Certain astronomy calculations involve finding a time when an event occurs.
Often such events can be defined as the root of a function:
the time at which the function's value becomes zero.

`Search` finds the *ascending root* of a function: the time at which
the function's value becomes zero while having a positive slope. That is, as time increases,
the function transitions from a negative value, through zero at a specific moment,
to a positive value later. The goal of the search is to find that specific moment.

The `func` parameter is an instance of the abstract class #SearchContext.
As an example, a caller may wish to find the moment a celestial body reaches a certain
ecliptic longitude. In that case, the caller might derive a class that contains
a #Body member to specify the body and a `double` to hold the target longitude.
It could subtract the target longitude from the actual longitude at a given time;
thus the difference would equal zero at the moment in time the planet reaches the
desired longitude.

The search calls `func.Eval` repeatedly to rapidly narrow in on any ascending
root within the time window specified by `t1` and `t2`. The search never
reports a solution outside this time window.

`Search` uses a combination of bisection and quadratic interpolation
to minimize the number of function calls. However, it is critical that the
supplied time window be small enough that there cannot be more than one root
(ascedning or descending) within it; otherwise the search can fail.
Beyond that, it helps to make the time window as small as possible, ideally
such that the function itself resembles a smooth parabolic curve within that window.

If an ascending root is not found, or more than one root
(ascending and/or descending) exists within the window `t1`..`t2`,
the search will return `null`.

If the search does not converge within 20 iterations, it will throw an exception.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_SearchAltitude_ChargerAstronomyShared_Domain_Equatorial_EquatorialCelestialBody_ChargerAstronomyShared_Domain_Observer_ChargerAstronomyEngine_CosineKittyAstronomy_Enums_Direction_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_System_Double_System_Double_"></a> SearchAltitude\(EquatorialCelestialBody, Observer, Direction, AstroTime, double, double\)

Finds the next time the center of a body passes through a given altitude.

```csharp
public AstroTime SearchAltitude(EquatorialCelestialBody body, Observer observer, Direction direction, AstroTime startTime, double limitDays, double altitude)
```

#### Parameters

`body` [EquatorialCelestialBody](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md)

The Sun, Moon, any planet other than the Earth,
or a user-defined star that was created by a call to #Astronomy.DefineStar.

`observer` [Observer](ChargerAstronomyShared.Domain.Observer.md)

The location where observation takes place.

`direction` [Direction](ChargerAstronomyEngine.CosineKittyAstronomy.Enums.Direction.md)

Either `Direction.Rise` to find an ascending altitude event
or `Direction.Set` to find a descending altitude event.

`startTime` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time at which to start the search.

`limitDays` [double](https://learn.microsoft.com/dotnet/api/system.double)

Limits how many days to search for the body reaching the altitude angle,
and defines the direction in time to search. When `limitDays` is positive, the
search is performed into the future, after `startTime`.
When negative, the search is performed into the past, before `startTime`.
To limit the search to the same day, you can use a value of 1 day.
In cases where you want to find the altitude event no matter how far
in the future (for example, for an observer near the south pole), you can
pass in a larger value like 365.

`altitude` [double](https://learn.microsoft.com/dotnet/api/system.double)

The desired altitude angle of the body's center above (positive)
or below (negative) the observer's local horizon, expressed in degrees.
Must be in the range [-90, +90].

#### Returns

 [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time of the altitude event, or `null` if no such event
occurs within the specified time window.

#### Remarks

Finds when the center of the given body ascends or descends through a given
altitude angle, as seen by an observer at the specified location on the Earth.
By using the appropriate combination of `direction` and `altitude` parameters,
this function can be used to find when civil, nautical, or astronomical twilight
begins (dawn) or ends (dusk).

Civil dawn begins before sunrise when the Sun ascends through 6 degrees below
the horizon. To find civil dawn, pass `Direction.Rise` for `direction` and -6 for `altitude`.

Civil dusk ends after sunset when the Sun descends through 6 degrees below the horizon.
To find civil dusk, pass `Direction.Set` for `direction` and -6 for `altitude`.

Nautical twilight is similar to civil twilight, only the `altitude` value should be -12 degrees.

Astronomical twilight uses -18 degrees as the `altitude` value.

By convention for twilight time calculations, the altitude is not corrected for
atmospheric refraction. This is because the target altitudes are below the horizon,
and refraction is not directly observable.

`SearchAltitude` is not intended to find rise/set times of a body for two reasons:
(1) Rise/set times of the Sun or Moon are defined by their topmost visible portion, not their centers.
(2) Rise/set times are affected significantly by atmospheric refraction.
Therefore, it is better to use #Astronomy.SearchRiseSet to find rise/set times, which
corrects for both of these considerations.

`SearchAltitude` will not work reliably for altitudes at or near the body's
maximum or minimum altitudes. To find the time a body reaches minimum or maximum altitude
angles, use #Astronomy.SearchHourAngle.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_SearchGlobalSolarEclipse_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> SearchGlobalSolarEclipse\(AstroTime\)

Searches for a solar eclipse visible anywhere on the Earth's surface.

```csharp
public GlobalSolarEclipseInfo SearchGlobalSolarEclipse(AstroTime startTime)
```

#### Parameters

`startTime` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time for starting the search for a solar eclipse.

#### Returns

 [GlobalSolarEclipseInfo](ChargerAstronomyEngine.CosineKittyAstronomy.GlobalSolarEclipseInfo.md)

#### Remarks

This function finds the first solar eclipse that occurs after `startTime`.
A solar eclipse may be partial, annular, or total.
See #GlobalSolarEclipseInfo for more information.
To find a series of solar eclipses, call this function once,
then keep calling #Astronomy.NextGlobalSolarEclipse as many times as desired,
passing in the `peak` value returned from the previous call.

See #Astronomy.GlobalSolarEclipsesAfter for a convenient enumerator.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_SearchHourAngle_ChargerAstronomyShared_Domain_Equatorial_EquatorialCelestialBody_ChargerAstronomyShared_Domain_Observer_System_Double_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_System_Int32_"></a> SearchHourAngle\(EquatorialCelestialBody, Observer, double, AstroTime, int\)

Searches for the time when the center of a body reaches a specified hour angle as seen by an observer on the Earth.

```csharp
public HourAngleInfo SearchHourAngle(EquatorialCelestialBody body, Observer observer, double hourAngle, AstroTime startTime, int direction = 1)
```

#### Parameters

`body` [EquatorialCelestialBody](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md)

The Sun, Moon, any planet other than the Earth,
or a user-defined star that was created by a call to #Astronomy.DefineStar.

`observer` [Observer](ChargerAstronomyShared.Domain.Observer.md)

Indicates a location on or near the surface of the Earth where the observer is located.

`hourAngle` [double](https://learn.microsoft.com/dotnet/api/system.double)

An hour angle value in the range [0, 24) indicating the number of sidereal hours after the
body's most recent culmination.

`startTime` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time at which to start the search.

`direction` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The direction in time to perform the search: a positive value
searches forward in time, a negative value searches backward in time.
The function throws an exception if `direction` is zero.

#### Returns

 [HourAngleInfo](ChargerAstronomyEngine.CosineKittyAstronomy.HourAngleInfo.md)

This function returns a valid #HourAngleInfo object on success.
If any error occurs, it throws an exception.
It never returns a null value.

#### Remarks

The *hour angle* of a celestial body indicates its position in the sky with respect
to the Earth's rotation. The hour angle depends on the location of the observer on the Earth.
The hour angle is 0 when the body's center reaches its highest angle above the horizon in a given day.
The hour angle increases by 1 unit for every sidereal hour that passes after that point, up
to 24 sidereal hours when it reaches the highest point again. So the hour angle indicates
the number of hours that have passed since the most recent time that the body has culminated,
or reached its highest point.

This function searches for the next or previous time a celestial body reaches the given hour angle
relative to the date and time specified by `startTime`.
To find when a body culminates, pass 0 for `hourAngle`.
To find when a body reaches its lowest point in the sky, pass 12 for `hourAngle`.

Note that, especially close to the Earth's poles, a body as seen on a given day
may always be above the horizon or always below the horizon, so the caller cannot
assume that a culminating object is visible nor that an object is below the horizon
at its minimum altitude.

On success, the function reports the date and time, along with the horizontal coordinates
of the body at that time, as seen by the given observer.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_SearchLocalSolarEclipse_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_ChargerAstronomyShared_Domain_Observer_"></a> SearchLocalSolarEclipse\(AstroTime, Observer\)

Searches for a solar eclipse visible at a specific location on the Earth's surface.

```csharp
public LocalSolarEclipseInfo SearchLocalSolarEclipse(AstroTime startTime, Observer observer)
```

#### Parameters

`startTime` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time for starting the search for a solar eclipse.

`observer` [Observer](ChargerAstronomyShared.Domain.Observer.md)

The geographic location of the observer.

#### Returns

 [LocalSolarEclipseInfo](ChargerAstronomyEngine.CosineKittyAstronomy.LocalSolarEclipseInfo.md)

#### Remarks

This function finds the first solar eclipse that occurs after `startTime`.
A solar eclipse may be partial, annular, or total.
See #LocalSolarEclipseInfo for more information.

To find a series of solar eclipses, call this function once,
then keep calling #Astronomy.NextLocalSolarEclipse as many times as desired,
passing in the `peak` value returned from the previous call.

IMPORTANT: An eclipse reported by this function might be partly or
completely invisible to the observer due to the time of day.

See #LocalSolarEclipseInfo for more information about this topic.
See #Astronomy.LocalSolarEclipsesAfter for a convenient enumerator.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_SearchLunarApsis_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> SearchLunarApsis\(AstroTime\)

Finds the date and time of the Moon's closest distance (perigee)
or farthest distance (apogee) with respect to the Earth.

```csharp
public ApsisInfo SearchLunarApsis(AstroTime startTime)
```

#### Parameters

`startTime` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time at which to start searching for the next perigee or apogee.

#### Returns

 [ApsisInfo](ChargerAstronomyEngine.CosineKittyAstronomy.ApsisInfo.md)

Returns an #ApsisInfo structure containing information about the next lunar apsis.

#### Remarks

Given a date and time to start the search in `startTime`, this function finds the
next date and time that the center of the Moon reaches the closest or farthest point
in its orbit with respect to the center of the Earth, whichever comes first
after `startTime`.

The closest point is called *perigee* and the farthest point is called *apogee*.
The word *apsis* refers to either event.

To iterate through consecutive alternating perigee and apogee events, call `Astronomy.SearchLunarApsis`
once, then use the return value to call #Astronomy.NextLunarApsis. After that,
keep feeding the previous return value from `Astronomy.NextLunarApsis` into another
call of `Astronomy.NextLunarApsis` as many times as desired.

See #Astronomy.LunarApsidesAfter for a convenient enumerator.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_SearchLunarEclipse_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> SearchLunarEclipse\(AstroTime\)

Searches for a lunar eclipse.

```csharp
public LunarEclipseInfo SearchLunarEclipse(AstroTime startTime)
```

#### Parameters

`startTime` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time for starting the search for a lunar eclipse.

#### Returns

 [LunarEclipseInfo](ChargerAstronomyEngine.CosineKittyAstronomy.LunarEclipseInfo.md)

A #LunarEclipseInfo structure containing information about the lunar eclipse.

#### Remarks

This function finds the first lunar eclipse that occurs after `startTime`.
A lunar eclipse may be penumbral, partial, or total.
See #LunarEclipseInfo for more information.
To find a series of lunar eclipses, call this function once,
then keep calling #Astronomy.NextLunarEclipse as many times as desired,
passing in the `center` value returned from the previous call.

See #Astronomy.LunarEclipsesAfter for a convenient enumerator.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_SearchMaxElongation_ChargerAstronomyShared_Domain_Equatorial_EquatorialCelestialBody_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> SearchMaxElongation\(EquatorialCelestialBody, AstroTime\)

Finds a date and time when Mercury or Venus reaches its maximum angle from the Sun as seen from the Earth.

```csharp
public ElongationInfo SearchMaxElongation(EquatorialCelestialBody body, AstroTime startTime)
```

#### Parameters

`body` [EquatorialCelestialBody](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md)

Either `Body.Mercury` or `Body.Venus`. Any other value will result in an exception.
To find the best viewing opportunites for planets farther from the Sun than the Earth is (Mars through Pluto)
use #Astronomy.SearchRelativeLongitude to find the next opposition event.

`startTime` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time at which to begin the search. The maximum elongation event found will always
be the first one that occurs after this date and time.

#### Returns

 [ElongationInfo](ChargerAstronomyEngine.CosineKittyAstronomy.ElongationInfo.md)

Either an exception will be thrown, or the function will return a valid value.

#### Remarks

Mercury and Venus are are often difficult to observe because they are closer to the Sun than the Earth is.
Mercury especially is almost always impossible to see because it gets lost in the Sun's glare.
The best opportunities for spotting Mercury, and the best opportunities for viewing Venus through
a telescope without atmospheric interference, are when these planets reach maximum elongation.
These are events where the planets reach the maximum angle from the Sun as seen from the Earth.

This function solves for those times, reporting the next maximum elongation event's date and time,
the elongation value itself, the relative longitude with the Sun, and whether the planet is best
observed in the morning or evening. See #Astronomy.Elongation for more details about the returned structure.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_SearchMoonNode_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> SearchMoonNode\(AstroTime\)

Searches for a time when the Moon's center crosses through the ecliptic plane.

```csharp
public NodeEventInfo SearchMoonNode(AstroTime startTime)
```

#### Parameters

`startTime` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time for starting the search for an ascending or descending node of the Moon.

#### Returns

 [NodeEventInfo](ChargerAstronomyEngine.CosineKittyAstronomy.NodeEventInfo.md)

#### Remarks

Searches for the first ascending or descending node of the Moon after `startTime`.
An ascending node is when the Moon's center passes through the ecliptic plane
(the plane of the Earth's orbit around the Sun) from south to north.
A descending node is when the Moon's center passes through the ecliptic plane
from north to south. Nodes indicate possible times of solar or lunar eclipses,
if the Moon also happens to be in the correct phase (new or full, respectively).
Call `Astronomy.SearchMoonNode` to find the first of a series of nodes.
Then call #Astronomy.NextMoonNode to find as many more consecutive nodes as desired.

See #Astronomy.MoonNodesAfter for a convenient enumerator.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_SearchMoonPhase_System_Double_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_System_Double_"></a> SearchMoonPhase\(double, AstroTime, double\)

Searches for the time that the Moon reaches a specified phase.

```csharp
public AstroTime SearchMoonPhase(double targetLon, AstroTime startTime, double limitDays)
```

#### Parameters

`targetLon` [double](https://learn.microsoft.com/dotnet/api/system.double)

The difference in geocentric longitude between the Sun and Moon
that specifies the lunar phase being sought. This can be any value
in the range [0, 360).  Certain values have conventional names:
0 = new moon, 90 = first quarter, 180 = full moon, 270 = third quarter.

`startTime` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The beginning of the time window in which to search for the Moon reaching the specified phase.

`limitDays` [double](https://learn.microsoft.com/dotnet/api/system.double)

The number of days away from `startTime` that limits the time window for the search.
If the value is negative, the search is performed into the past from `startTime`.
Otherwise, the search is performed into the future from `startTime`.

#### Returns

 [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

If successful, returns the date and time the moon reaches the phase specified by
`targetlon`. This function will return `null` if the phase does not
occur within `limitDays` of `startTime`; that is, if the search window is too small.

#### Remarks

Lunar phases are conventionally defined in terms of the Moon's geocentric ecliptic
longitude with respect to the Sun's geocentric ecliptic longitude.
When the Moon and the Sun have the same longitude, that is defined as a new moon.
When their longitudes are 180 degrees apart, that is defined as a full moon.

This function searches for any value of the lunar phase expressed as an
angle in degrees in the range [0, 360).

If you want to iterate through lunar quarters (new moon, first quarter, full moon, third quarter)
it is much easier to call the functions #Astronomy.SearchMoonQuarter and #Astronomy.NextMoonQuarter.
This function is useful for finding general phase angles outside those four quarters.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_SearchMoonQuarter_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> SearchMoonQuarter\(AstroTime\)

Finds the first lunar quarter after the specified date and time.

```csharp
public MoonQuarterInfo SearchMoonQuarter(AstroTime startTime)
```

#### Parameters

`startTime` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time at which to start the search.

#### Returns

 [MoonQuarterInfo](ChargerAstronomyEngine.CosineKittyAstronomy.MoonQuarterInfo.md)

A #MoonQuarterInfo structure reporting the next quarter phase and the time it will occur.

#### Remarks

A lunar quarter is one of the following four lunar phase events:
new moon, first quarter, full moon, third quarter.
This function finds the lunar quarter that happens soonest
after the specified date and time.

To continue iterating through consecutive lunar quarters, call this function once,
followed by calls to #Astronomy.NextMoonQuarter as many times as desired.

See #Astronomy.MoonQuartersAfter for a convenient enumerator.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_SearchPeakMagnitude_ChargerAstronomyShared_Domain_Equatorial_EquatorialCelestialBody_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> SearchPeakMagnitude\(EquatorialCelestialBody, AstroTime\)

Searches for the date and time Venus will next appear brightest as seen from the Earth.

```csharp
public IllumInfo SearchPeakMagnitude(EquatorialCelestialBody body, AstroTime startTime)
```

#### Parameters

`body` [EquatorialCelestialBody](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md)

Currently only `Body.Venus` is allowed. Any other value causes an exception.
See remarks above for more details.

`startTime` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time to start searching for the next peak magnitude event.

#### Returns

 [IllumInfo](ChargerAstronomyEngine.CosineKittyAstronomy.IllumInfo.md)

See documentation about the return value from #Astronomy.Illumination.

#### Remarks

This function searches for the date and time Venus appears brightest as seen from the Earth.
Currently only Venus is supported for the `body` parameter, though this could change in the future.
Mercury's peak magnitude occurs at superior conjunction, when it is virtually impossible to see from the Earth,
so peak magnitude events have little practical value for that planet.
Planets other than Venus and Mercury reach peak magnitude at opposition, which can
be found using #Astronomy.SearchRelativeLongitude.
The Moon reaches peak magnitude at full moon, which can be found using
#Astronomy.SearchMoonQuarter or #Astronomy.SearchMoonPhase.
The Sun reaches peak magnitude at perihelion, which occurs each year in January.
However, the difference is minor and has little practical value.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_SearchPlanetApsis_ChargerAstronomyShared_Domain_Equatorial_EquatorialCelestialBody_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> SearchPlanetApsis\(EquatorialCelestialBody, AstroTime\)

Finds the date and time of a planet's perihelion (closest approach to the Sun)
or aphelion (farthest distance from the Sun) after a given time.

```csharp
public ApsisInfo SearchPlanetApsis(EquatorialCelestialBody body, AstroTime startTime)
```

#### Parameters

`body` [EquatorialCelestialBody](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md)

The planet for which to find the next perihelion/aphelion event.
Not allowed to be `Body.Sun` or `Body.Moon`.

`startTime` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time at which to start searching for the next perihelion or aphelion.

#### Returns

 [ApsisInfo](ChargerAstronomyEngine.CosineKittyAstronomy.ApsisInfo.md)

Returns a structure in which `time` holds the date and time of the next planetary apsis,
`kind` holds either `ApsisKind.Pericenter` for perihelion or `ApsisKind.Apocenter` for aphelion.
and distance values `dist_au` (astronomical units) and `dist_km` (kilometers).

#### Remarks

Given a date and time to start the search in `startTime`, this function finds the
next date and time that the center of the specified planet reaches the closest or farthest point
in its orbit with respect to the center of the Sun, whichever comes first
after `startTime`.

The closest point is called *perihelion* and the farthest point is called *aphelion*.
The word *apsis* refers to either event.

To iterate through consecutive alternating perihelion and aphelion events,
call `Astronomy.SearchPlanetApsis` once, then use the return value to call
#Astronomy.NextPlanetApsis. After that, keep feeding the previous return value
from `Astronomy.NextPlanetApsis` into another call of `Astronomy.NextPlanetApsis`
as many times as desired.

See #Astronomy.PlanetApsidesAfter for a convenient enumerator.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_SearchRelativeLongitude_ChargerAstronomyShared_Domain_Equatorial_EquatorialCelestialBody_System_Double_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> SearchRelativeLongitude\(EquatorialCelestialBody, double, AstroTime\)

Searches for the time when the Earth and another planet are separated by a specified angle
in ecliptic longitude, as seen from the Sun.

```csharp
public AstroTime SearchRelativeLongitude(EquatorialCelestialBody body, double targetRelLon, AstroTime startTime)
```

#### Parameters

`body` [EquatorialCelestialBody](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md)

A planet other than the Earth.
If `body` is `Body.Earth`, `Body.Sun`, or `Body.Moon`, this function throws an exception.

`targetRelLon` [double](https://learn.microsoft.com/dotnet/api/system.double)

The desired relative longitude, expressed in degrees. Must be in the range [0, 360).

`startTime` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time at which to begin the search.

#### Returns

 [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time of the relative longitude event.

#### Remarks

A relative longitude is the angle between two bodies measured in the plane of the Earth's orbit
(the ecliptic plane). The distance of the bodies above or below the ecliptic plane is ignored.
If you imagine the shadow of the body cast onto the ecliptic plane, and the angle measured around
that plane from one body to the other in the direction the planets orbit the Sun, you will get an
angle somewhere between 0 and 360 degrees. This is the relative longitude.

Given a planet other than the Earth in `body` and a time to start the search in `startTime`,
this function searches for the next time that the relative longitude measured from the planet
to the Earth is `targetRelLon`.

Certain astronomical events are defined in terms of relative longitude between the Earth and another planet:

- When the relative longitude is 0 degrees, it means both planets are in the same direction from the Sun.
  For planets that orbit closer to the Sun (Mercury and Venus), this is known as *inferior conjunction*,
  a time when the other planet becomes very difficult to see because of being lost in the Sun's glare.
  (The only exception is in the rare event of a transit, when we see the silhouette of the planet passing
  between the Earth and the Sun.)

- When the relative longitude is 0 degrees and the other planet orbits farther from the Sun,
  this is known as *opposition*.  Opposition is when the planet is closest to the Earth, and
  also when it is visible for most of the night, so it is considered the best time to observe the planet.

- When the relative longitude is 180 degrees, it means the other planet is on the opposite side of the Sun
  from the Earth. This is called *superior conjunction*. Like inferior conjunction, the planet is
  very difficult to see from the Earth. Superior conjunction is possible for any planet other than the Earth.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_SearchRiseSet_ChargerAstronomyShared_Domain_Equatorial_EquatorialCelestialBody_ChargerAstronomyShared_Domain_Observer_ChargerAstronomyEngine_CosineKittyAstronomy_Enums_Direction_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_System_Double_System_Double_"></a> SearchRiseSet\(EquatorialCelestialBody, Observer, Direction, AstroTime, double, double\)

Searches for the next time a celestial body rises or sets as seen by an observer on the Earth.

```csharp
public AstroTime SearchRiseSet(EquatorialCelestialBody body, Observer observer, Direction direction, AstroTime startTime, double limitDays, double metersAboveGround = 0)
```

#### Parameters

`body` [EquatorialCelestialBody](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md)

The Sun, Moon, any planet other than the Earth,
or a user-defined star that was created by a call to #Astronomy.DefineStar.

`observer` [Observer](ChargerAstronomyShared.Domain.Observer.md)

The location where observation takes place.

`direction` [Direction](ChargerAstronomyEngine.CosineKittyAstronomy.Enums.Direction.md)

Either `Direction.Rise` to find a rise time or `Direction.Set` to find a set time.

`startTime` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time at which to start the search.

`limitDays` [double](https://learn.microsoft.com/dotnet/api/system.double)

Limits how many days to search for a rise or set time, and defines
the direction in time to search. When `limitDays` is positive, the
search is performed into the future, after `startTime`.
When negative, the search is performed into the past, before `startTime`.
To limit a rise or set time to the same day, you can use a value of 1 day.
In cases where you want to find the next rise or set time no matter how far
in the future (for example, for an observer near the south pole), you can
pass in a larger value like 365.

`metersAboveGround` [double](https://learn.microsoft.com/dotnet/api/system.double)

Usually the observer is located at ground level. Then this parameter
should be zero. But if the observer is significantly higher than ground
level, for example in an airplane, this parameter should be a positive
number indicating how far above the ground the observer is.
An exception occurs if `metersAboveGround` is negative.

#### Returns

 [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

On success, returns the date and time of the rise or set time as requested.
If the function returns `null`, it means the rise or set event does not occur
within `limitDays` days of `startTime`. This is a normal condition,
not an error.

#### Remarks

This function finds the next rise or set time of the Sun, Moon, or planet other than the Earth.
Rise time is when the body first starts to be visible above the horizon.
For example, sunrise is the moment that the top of the Sun first appears to peek above the horizon.
Set time is the moment when the body appears to vanish below the horizon.
Therefore, this function adjusts for the apparent angular radius of the observed body
(significant only for the Sun and Moon).

This function corrects for a typical value of atmospheric refraction, which causes celestial
bodies to appear higher above the horizon than they would if the Earth had no atmosphere.
Astronomy Engine uses a correction of 34 arcminutes. Real-world refraction varies based
on air temperature, pressure, and humidity; such weather-based conditions are outside
the scope of Astronomy Engine.

Note that rise or set may not occur in every 24 hour period.
For example, near the Earth's poles, there are long periods of time where
the Sun stays below the horizon, never rising.
Also, it is possible for the Moon to rise just before midnight but not set during the subsequent 24-hour day.
This is because the Moon sets nearly an hour later each day due to orbiting the Earth a
significant amount during each rotation of the Earth.
Therefore callers must not assume that the function will always succeed.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_SearchSunLongitude_System_Double_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_System_Double_"></a> SearchSunLongitude\(double, AstroTime, double\)

Searches for the time when the Sun reaches an apparent ecliptic longitude as seen from the Earth.

```csharp
public AstroTime SearchSunLongitude(double targetLon, AstroTime startTime, double limitDays)
```

#### Parameters

`targetLon` [double](https://learn.microsoft.com/dotnet/api/system.double)

The desired ecliptic longitude in degrees, relative to the true equinox of date.
This may be any value in the range [0, 360), although certain values have
conventional meanings:
0 = March equinox, 90 = June solstice, 180 = September equinox, 270 = December solstice.

`startTime` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time for starting the search for the desired longitude event.

`limitDays` [double](https://learn.microsoft.com/dotnet/api/system.double)

The real-valued number of days, which when added to `startTime`, limits the
range of time over which the search looks.
It is recommended to keep this value between 1 and 10 days.
See remarks above for more details.

#### Returns

 [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time when the Sun reaches the specified apparent ecliptic longitude.

#### Remarks

This function finds the moment in time, if any exists in the given time window,
that the center of the Sun reaches a specific ecliptic longitude as seen from the center of the Earth.

This function can be used to determine equinoxes and solstices.
However, it is usually more convenient and efficient to call #Astronomy.Seasons
to calculate all equinoxes and solstices for a given calendar year.

The function searches the window of time specified by `startTime` and `startTime+limitDays`.
The search will return `null` if the Sun never reaches the longitude `targetLon` or
if the window is so large that the longitude ranges more than 180 degrees within it.
It is recommended to keep the window smaller than 10 days when possible.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_SearchTransit_ChargerAstronomyShared_Domain_Equatorial_EquatorialCelestialBody_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> SearchTransit\(EquatorialCelestialBody, AstroTime\)

Searches for the first transit of Mercury or Venus after a given date.

```csharp
public TransitInfo SearchTransit(EquatorialCelestialBody body, AstroTime startTime)
```

#### Parameters

`body` [EquatorialCelestialBody](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md)

The planet whose transit is to be found. Must be `Body.Mercury` or `Body.Venus`.

`startTime` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time for starting the search for a transit.

#### Returns

 [TransitInfo](ChargerAstronomyEngine.CosineKittyAstronomy.TransitInfo.md)

#### Remarks

Finds the first transit of Mercury or Venus after a specified date.
A transit is when an inferior planet passes between the Sun and the Earth
so that the silhouette of the planet is visible against the Sun in the background.
To continue the search, pass the `finish` time in the returned structure to
#Astronomy.NextTransit.

See #Astronomy.TransitsAfter for a convenient enumerator.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_Seasons_System_Int32_"></a> Seasons\(int\)

Finds both equinoxes and both solstices for a given calendar year.

```csharp
public SeasonsInfo Seasons(int year)
```

#### Parameters

`year` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The calendar year number for which to calculate equinoxes and solstices.
The value may be any integer, but only the years 1800 through 2100 have been
validated for accuracy: unit testing against data from the
United States Naval Observatory confirms that all equinoxes and solstices
for that range of years are within 2 minutes of the correct time.

#### Returns

 [SeasonsInfo](ChargerAstronomyEngine.CosineKittyAstronomy.SeasonsInfo.md)

A #SeasonsInfo structure that contains four #AstroTime values:
the March and September equinoxes and the June and December solstices.

#### Remarks

The changes of seasons are defined by solstices and equinoxes.
Given a calendar year number, this function calculates the
March and September equinoxes and the June and December solstices.

The equinoxes are the moments twice each year when the plane of the
Earth's equator passes through the center of the Sun. In other words,
the Sun's declination is zero at both equinoxes.
The March equinox defines the beginning of spring in the northern hemisphere
and the beginning of autumn in the southern hemisphere.
The September equinox defines the beginning of autumn in the northern hemisphere
and the beginning of spring in the southern hemisphere.

The solstices are the moments twice each year when one of the Earth's poles
is most tilted toward the Sun. More precisely, the Sun's declination reaches
its minimum value at the December solstice, which defines the beginning of
winter in the northern hemisphere and the beginning of summer in the southern
hemisphere. The Sun's declination reaches its maximum value at the June solstice,
which defines the beginning of summer in the northern hemisphere and the beginning
of winter in the southern hemisphere.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_SiderealTime_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> SiderealTime\(AstroTime\)

Calculates Greenwich Apparent Sidereal Time (GAST).

```csharp
public double SiderealTime(AstroTime time)
```

#### Parameters

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time for which to find GAST.
As an optimization, this function caches the sidereal time value in `time`,
unless it has already been cached, in which case the cached value is reused.

#### Returns

 [double](https://learn.microsoft.com/dotnet/api/system.double)

GAST in sidereal hours.

#### Remarks

Given a date and time, this function calculates the rotation of the
Earth, represented by the equatorial angle of the Greenwich prime meridian
with respect to distant stars (not the Sun, which moves relative to background
stars by almost one degree per day).
This angle is called Greenwich Apparent Sidereal Time (GAST).
GAST is measured in sidereal hours in the half-open range [0, 24).
When GAST = 0, it means the prime meridian is aligned with the of-date equinox,
corrected at that time for precession and nutation of the Earth's axis.
In this context, the "equinox" is the direction in space where the Earth's
orbital plane (the ecliptic) intersects with the plane of the Earth's equator,
at the location on the Earth's orbit of the (seasonal) March equinox.
As the Earth rotates, GAST increases from 0 up to 24 sidereal hours,
then starts over at 0.
To convert to degrees, multiply the return value by 15.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_SphereFromVector_ChargerAstronomyEngine_CosineKittyAstronomy_AstroVector_"></a> SphereFromVector\(AstroVector\)

Converts Cartesian coordinates to spherical coordinates.

```csharp
public Spherical SphereFromVector(AstroVector vector)
```

#### Parameters

`vector` [AstroVector](ChargerAstronomyEngine.CosineKittyAstronomy.AstroVector.md)

Cartesian vector to be converted to spherical coordinates.

#### Returns

 [Spherical](ChargerAstronomyEngine.CosineKittyAstronomy.Spherical.md)

Spherical coordinates that are equivalent to the given vector.

#### Remarks

Given a Cartesian vector, returns latitude, longitude, and distance.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_SunPosition_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> SunPosition\(AstroTime\)

Calculates geocentric ecliptic coordinates for the Sun.

```csharp
public Ecliptic SunPosition(AstroTime time)
```

#### Parameters

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time for which to calculate the Sun's position.

#### Returns

 [Ecliptic](ChargerAstronomyEngine.CosineKittyAstronomy.Ecliptic.md)

The ecliptic coordinates of the Sun using the Earth's true equator of date.

#### Remarks

This function calculates the position of the Sun as seen from the Earth.
The returned value includes both Cartesian and spherical coordinates.
The x-coordinate and longitude values in the returned structure are based
on the *true equinox of date*: one of two points in the sky where the instantaneous
plane of the Earth's equator at the given date and time (the *equatorial plane*)
intersects with the plane of the Earth's orbit around the Sun (the *ecliptic plane*).
By convention, the apparent location of the Sun at the March equinox is chosen
as the longitude origin and x-axis direction, instead of the one for September.

`SunPosition` corrects for precession and nutation of the Earth's axis
in order to obtain the exact equatorial plane at the given time.

This function can be used for calculating changes of seasons: equinoxes and solstices.
In fact, the function #Astronomy.Seasons does use this function for that purpose.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_TransitsAfter_ChargerAstronomyShared_Domain_Equatorial_EquatorialCelestialBody_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> TransitsAfter\(EquatorialCelestialBody, AstroTime\)

Enumerates a series of transits of Mercury or Venus.

```csharp
public IEnumerable<TransitInfo> TransitsAfter(EquatorialCelestialBody body, AstroTime startTime)
```

#### Parameters

`body` [EquatorialCelestialBody](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md)

The planet whose transits are to be enumerated. Must be `Body.Mercury` or `Body.Venus`.

`startTime` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

Specifies the time to begin searching for consecutive transits.

#### Returns

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[TransitInfo](ChargerAstronomyEngine.CosineKittyAstronomy.TransitInfo.md)\>

#### Remarks

This is a convenience wrapper around the functions
#Astronomy.SearchTransit and #Astronomy.NextTransit.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_VectorFromHorizon_ChargerAstronomyEngine_CosineKittyAstronomy_Spherical_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_ChargerAstronomyEngine_CosineKittyAstronomy_Enums_Refraction_"></a> VectorFromHorizon\(Spherical, AstroTime, Refraction\)

Given apparent angular horizontal coordinates in `sphere`, calculate horizontal vector.

```csharp
public AstroVector VectorFromHorizon(Spherical sphere, AstroTime time, Refraction refraction)
```

#### Parameters

`sphere` [Spherical](ChargerAstronomyEngine.CosineKittyAstronomy.Spherical.md)

A structure that contains apparent horizontal coordinates:
`lat` holds the refracted altitude angle,
`lon` holds the azimuth in degrees clockwise from north,
and `dist` holds the distance from the observer to the object in AU.

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The date and time of the observation. This is needed because the returned
#AstroVector requires a valid time value when passed to certain other functions.

`refraction` [Refraction](ChargerAstronomyEngine.CosineKittyAstronomy.Enums.Refraction.md)

The refraction option used to model atmospheric lensing. See #Astronomy.RefractionAngle.
This specifies how refraction is to be removed from the altitude stored in `sphere.lat`.

#### Returns

 [AstroVector](ChargerAstronomyEngine.CosineKittyAstronomy.AstroVector.md)

A vector in the horizontal system: `x` = north, `y` = west, and `z` = zenith (up).

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_VectorFromSphere_ChargerAstronomyEngine_CosineKittyAstronomy_Spherical_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> VectorFromSphere\(Spherical, AstroTime\)

Converts spherical coordinates to Cartesian coordinates.

```csharp
public AstroVector VectorFromSphere(Spherical sphere, AstroTime time)
```

#### Parameters

`sphere` [Spherical](ChargerAstronomyEngine.CosineKittyAstronomy.Spherical.md)

Spherical coordinates to be converted.

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The time that should be included in the return value.

#### Returns

 [AstroVector](ChargerAstronomyEngine.CosineKittyAstronomy.AstroVector.md)

The vector form of the supplied spherical coordinates.

#### Remarks

Given spherical coordinates and a time at which they are valid,
returns a vector of Cartesian coordinates. The returned value
includes the time, as required by the type #AstroVector.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_VectorObserver_ChargerAstronomyEngine_CosineKittyAstronomy_AstroVector_ChargerAstronomyEngine_CosineKittyAstronomy_Enums_EquatorEpoch_"></a> VectorObserver\(AstroVector, EquatorEpoch\)

Calculates the geographic location corresponding to an equatorial vector.

```csharp
public Observer VectorObserver(AstroVector vector, EquatorEpoch equdate)
```

#### Parameters

`vector` [AstroVector](ChargerAstronomyEngine.CosineKittyAstronomy.AstroVector.md)

The geocentric equatorial position vector for which to find geographic coordinates.
The components are expressed in Astronomical Units (AU).
You can calculate AU by dividing kilometers by the constant #Astronomy.KM_PER_AU.
The time `vector.t` determines the Earth's rotation.

`equdate` [EquatorEpoch](ChargerAstronomyEngine.CosineKittyAstronomy.Enums.EquatorEpoch.md)

Selects the date of the Earth's equator in which `vector` is expressed.
The caller may select `EquatorEpoch.J2000` to use the orientation of the Earth's equator
at noon UTC on January 1, 2000, in which case this function corrects for precession
and nutation of the Earth as it was at the moment specified by `vector.t`.
Or the caller may select `EquatorEpoch.OfDate` to use the Earth's equator at `vector.t`
as the orientation.

#### Returns

 [Observer](ChargerAstronomyShared.Domain.Observer.md)

The geographic latitude, longitude, and elevation above sea level
that corresponds to the given equatorial vector.

#### Remarks

This is the inverse function of #Astronomy.ObserverVector.
Given a geocentric equatorial vector, it returns the geographic
latitude, longitude, and elevation for that vector.

