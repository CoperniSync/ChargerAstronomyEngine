# <a id="ChargerAstronomyEngine_CosineKittyAstronomy_GravitySimulator"></a> Class GravitySimulator

Namespace: [ChargerAstronomyEngine.CosineKittyAstronomy](ChargerAstronomyEngine.CosineKittyAstronomy.md)  
Assembly: ChargerAstronomyEngine.dll  

A simulation of zero or more small bodies moving through the Solar System.

```csharp
public class GravitySimulator
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[GravitySimulator](ChargerAstronomyEngine.CosineKittyAstronomy.GravitySimulator.md)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Remarks

This class calculates the movement of arbitrary small bodies,
such as asteroids or comets, that move through the Solar System.
It does so by calculating the gravitational forces on the small bodies
from the Sun and planets. The user of this class supplies an enumeration
of initial positions and velocities for the small bodies.
Then the class can update the positions and velocities over small time steps.

## Constructors

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_GravitySimulator__ctor_ChargerAstronomyShared_Domain_Equatorial_EquatorialCelestialBody_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_System_Collections_Generic_IEnumerable_ChargerAstronomyEngine_CosineKittyAstronomy_StateVector__"></a> GravitySimulator\(EquatorialCelestialBody, AstroTime, IEnumerable<StateVector\>\)

Creates a gravity simulation object.

```csharp
public GravitySimulator(EquatorialCelestialBody originBody, AstroTime time, IEnumerable<StateVector> bodyStates)
```

#### Parameters

`originBody` [EquatorialCelestialBody](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md)

Specifies the origin of the reference frame.
All position vectors and velocity vectors will use `originBody`
as the origin of the coordinate system.
This origin applies to all the input vectors provided in the
`bodyStates` parameter of this function, along with all
output vectors returned by #GravitySimulator.Update.
Most callers will want to provide one of the following:
`Body.Sun` for heliocentric coordinates,
`Body.SSB` for solar system barycentric coordinates,
or `Body.Earth` for geocentric coordinates. Note that the
gravity simulator does not correct for light travel time;
all state vectors are tied to a Newtonian "instantaneous" time.

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The initial time at which to start the simulation.

`bodyStates` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[StateVector](ChargerAstronomyEngine.CosineKittyAstronomy.StateVector.md)\>

An enumeration of zero or more initial state vectors (positions and velocities)
of the small bodies to be simulated.
The caller must know the positions and velocities of the small bodies at an initial moment in time.
Their positions and velocities are expressed with respect to `originBody`, using equatorial
J2000 orientation (EQJ).
Positions are expressed in astronomical units (AU).
Velocities are expressed in AU/day.
All the times embedded within the state vectors must be exactly equal to `time`,
or this constructor will throw an exception.
If `bodyStates` is null, the gravity simulator will contain zero small bodies.

## Fields

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_GravitySimulator_OriginBody"></a> OriginBody

The origin of the reference frame. See constructor for more info.

```csharp
public readonly EquatorialCelestialBody OriginBody
```

#### Field Value

 [EquatorialCelestialBody](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md)

## Properties

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_GravitySimulator_NumSmallBodies"></a> NumSmallBodies

The number of small bodies that are included in this gravity simulation.

```csharp
public int NumSmallBodies { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Remarks

#GravitySimulator.Update requres the caller to pass in an array to
receive updated state vectors for the small bodies. This array must
have the same number of elements as the bodies that are being simulated.
`NumSmallBodies` returns this number as a convenience.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_GravitySimulator_Time"></a> Time

The time represented by the current step of the gravity simulation.

```csharp
public AstroTime Time { get; }
```

#### Property Value

 [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

## Methods

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_GravitySimulator_SolarSystemBodyState_ChargerAstronomyShared_Domain_Equatorial_EquatorialCelestialBody_"></a> SolarSystemBodyState\(EquatorialCelestialBody\)

Get the position and velocity of a Solar System body included in the simulation.

```csharp
public StateVector SolarSystemBodyState(EquatorialCelestialBody body)
```

#### Parameters

`body` [EquatorialCelestialBody](ChargerAstronomyShared.Domain.Equatorial.EquatorialCelestialBody.md)

The Sun, Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, or Neptune.

#### Returns

 [StateVector](ChargerAstronomyEngine.CosineKittyAstronomy.StateVector.md)

#### Remarks

In order to simulate the movement of small bodies through the Solar System,
the simulator needs to calculate the state vectors for the Sun and planets.

If an application wants to know the positions of one or more of the planets
in addition to the small bodies, this function provides a way to obtain
their state vectors. This is provided for the sake of efficiency, to avoid
redundant calculations.

The state vector is returned relative to the position and velocity
of the `originBody` parameter that was passed to this object's constructor.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_GravitySimulator_Swap"></a> Swap\(\)

Exchange the current time step with the previous time step.

```csharp
public void Swap()
```

#### Remarks

Sometimes it is helpful to "explore" various times near a given
simulation time step, while repeatedly returning to the original
time step. For example, when backdating a position for light travel
time, the caller may wish to repeatedly try different amounts of
backdating. When the backdating solver has converged, the caller
wants to leave the simulation in its original state.

This function allows a single "undo" of a simulation, and does so
very efficiently.

Usually this function will be called immediately after a matching
call to #GravitySimulator.Update. It has the effect of rolling
back the most recent update. If called twice in a row, it reverts
the swap and thus has no net effect.

The constructor initializes the current state and previous
state to be identical. Both states represent the `time` parameter that was
passed into the constructor. Therefore, `Swap` will
have no effect from the caller's point of view when passed a simulator
that has not yet been updated by a call to #GravitySimulator.Update.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_GravitySimulator_Update_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_ChargerAstronomyEngine_CosineKittyAstronomy_StateVector___"></a> Update\(AstroTime, StateVector\[\]\)

Advances a gravity simulation by a small time step.

```csharp
public void Update(AstroTime time, StateVector[] bodyStates)
```

#### Parameters

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

A time that is a small increment away from the current simulation time.
It is up to the developer to figure out an appropriate time increment.
Depending on the trajectories, a smaller or larger increment
may be needed for the desired accuracy. Some experimentation may be needed.
Generally, bodies that stay in the outer Solar System and move slowly can
use larger time steps.  Bodies that pass into the inner Solar System and
move faster will need a smaller time step to maintain accuracy.
The `time` value may be after or before the current simulation time
to move forward or backward in time.

`bodyStates` [StateVector](ChargerAstronomyEngine.CosineKittyAstronomy.StateVector.md)\[\]

If this array is not null, it must contain exactly the same number
of elements as the number of small bodies that were added when this
simulator was created. The non-null array receives updated state vectors
for the simulated small bodies.
If `bodyStates` is null, the simulation is updated but without returning
the state vectors.

#### Remarks

Updates the simulation of the user-supplied small bodies
to the time indicated by the `time` parameter.
Updates the supplied array `bodyStates` of state vectors for the small bodies.
This array must be the same size as the number of bodies supplied
to the constructor of this object.
The positions and velocities in the returned array are referenced
to the `originBody` that was used to construct this simulator.

