# <a id="ChargerAstronomyEngine_CosineKittyAstronomy"></a> Namespace ChargerAstronomyEngine.CosineKittyAstronomy

### Namespaces

 [ChargerAstronomyEngine.CosineKittyAstronomy.Enums](ChargerAstronomyEngine.CosineKittyAstronomy.Enums.md)

 [ChargerAstronomyEngine.CosineKittyAstronomy.Exceptions](ChargerAstronomyEngine.CosineKittyAstronomy.Exceptions.md)

 [ChargerAstronomyEngine.CosineKittyAstronomy.SearchContexts](ChargerAstronomyEngine.CosineKittyAstronomy.SearchContexts.md)

### Classes

 [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

A date and time used for astronomical calculations.

 [Astronomy](ChargerAstronomyEngine.CosineKittyAstronomy.Astronomy.md)

The wrapper class that holds Astronomy Engine functions.

 [GravitySimulator](ChargerAstronomyEngine.CosineKittyAstronomy.GravitySimulator.md)

A simulation of zero or more small bodies moving through the Solar System.

### Structs

 [ApsisInfo](ChargerAstronomyEngine.CosineKittyAstronomy.ApsisInfo.md)

An apsis event: pericenter (closest approach) or apocenter (farthest distance).

 [AstroVector](ChargerAstronomyEngine.CosineKittyAstronomy.AstroVector.md)

A 3D Cartesian vector whose components are expressed in Astronomical Units (AU).

 [AtmosphereInfo](ChargerAstronomyEngine.CosineKittyAstronomy.AtmosphereInfo.md)

Information about idealized atmospheric variables at a given elevation.

 [AxisInfo](ChargerAstronomyEngine.CosineKittyAstronomy.AxisInfo.md)

Information about a body's rotation axis at a given time.

 [ConstellationInfo](ChargerAstronomyEngine.CosineKittyAstronomy.ConstellationInfo.md)

Reports the constellation that a given celestial point lies within.

 [EclipseEvent](ChargerAstronomyEngine.CosineKittyAstronomy.EclipseEvent.md)

Holds a time and the observed altitude of the Sun at that time.

 [Ecliptic](ChargerAstronomyEngine.CosineKittyAstronomy.Ecliptic.md)

Ecliptic angular and Cartesian coordinates.

 [ElongationInfo](ChargerAstronomyEngine.CosineKittyAstronomy.ElongationInfo.md)

Contains information about the visibility of a celestial body at a given date and time.
See #Astronomy.Elongation for more detailed information about the members of this structure.
See also #Astronomy.SearchMaxElongation for how to search for maximum elongation events.

 [Equatorial](ChargerAstronomyEngine.CosineKittyAstronomy.Equatorial.md)

Equatorial angular and cartesian coordinates.

 [GlobalSolarEclipseInfo](ChargerAstronomyEngine.CosineKittyAstronomy.GlobalSolarEclipseInfo.md)

Reports the time and geographic location of the peak of a solar eclipse.

 [HourAngleInfo](ChargerAstronomyEngine.CosineKittyAstronomy.HourAngleInfo.md)

Information about a celestial body crossing a specific hour angle.

 [IllumInfo](ChargerAstronomyEngine.CosineKittyAstronomy.IllumInfo.md)

Information about the brightness and illuminated shape of a celestial body.

 [JupiterMoonsInfo](ChargerAstronomyEngine.CosineKittyAstronomy.JupiterMoonsInfo.md)

Holds the positions and velocities of Jupiter's major 4 moons.

 [LibrationInfo](ChargerAstronomyEngine.CosineKittyAstronomy.LibrationInfo.md)

Lunar libration angles, returned by #Astronomy.Libration.

 [LocalSolarEclipseInfo](ChargerAstronomyEngine.CosineKittyAstronomy.LocalSolarEclipseInfo.md)

Information about a solar eclipse as seen by an observer at a given time and geographic location.

 [LunarEclipseInfo](ChargerAstronomyEngine.CosineKittyAstronomy.LunarEclipseInfo.md)

Information about a lunar eclipse.

 [MoonQuarterInfo](ChargerAstronomyEngine.CosineKittyAstronomy.MoonQuarterInfo.md)

A lunar quarter event (new moon, first quarter, full moon, or third quarter) along with its date and time.

 [NodeEventInfo](ChargerAstronomyEngine.CosineKittyAstronomy.NodeEventInfo.md)

Information about an ascending or descending node of a body.

 [RotationMatrix](ChargerAstronomyEngine.CosineKittyAstronomy.RotationMatrix.md)

A rotation matrix that can be used to transform one coordinate system to another.

 [SeasonsInfo](ChargerAstronomyEngine.CosineKittyAstronomy.SeasonsInfo.md)

The dates and times of changes of season for a given calendar year.
Call #Astronomy.Seasons to calculate this data structure for a given year.

 [Spherical](ChargerAstronomyEngine.CosineKittyAstronomy.Spherical.md)

Spherical coordinates: latitude, longitude, distance.

 [StateVector](ChargerAstronomyEngine.CosineKittyAstronomy.StateVector.md)

A combination of a position vector and a velocity vector at a given moment in time.

 [Topocentric](ChargerAstronomyEngine.CosineKittyAstronomy.Topocentric.md)

Coordinates of a celestial body as seen by a topocentric observer.

 [TransitInfo](ChargerAstronomyEngine.CosineKittyAstronomy.TransitInfo.md)

Information about a transit of Mercury or Venus, as seen from the Earth.

### Interfaces

 [IPositionFunction](ChargerAstronomyEngine.CosineKittyAstronomy.IPositionFunction.md)

A function for which to solve a light-travel time problem.

### Delegates

 [DeltaTimeFunc](ChargerAstronomyEngine.CosineKittyAstronomy.DeltaTimeFunc.md)

Defines a function type for calculating Delta T.

