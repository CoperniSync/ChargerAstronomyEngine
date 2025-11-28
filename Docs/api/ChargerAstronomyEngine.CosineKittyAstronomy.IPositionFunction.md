# <a id="ChargerAstronomyEngine_CosineKittyAstronomy_IPositionFunction"></a> Interface IPositionFunction

Namespace: [ChargerAstronomyEngine.CosineKittyAstronomy](ChargerAstronomyEngine.CosineKittyAstronomy.md)  
Assembly: ChargerAstronomyEngine.dll  

A function for which to solve a light-travel time problem.

```csharp
public interface IPositionFunction
```

## Remarks

The function #Astronomy.CorrectLightTravel solves a generalized
problem of deducing how far in the past light must have left
a target object to be seen by an observer at a specified time.
This interface expresses an arbitrary position vector as
function of time that is passed to #Astronomy.CorrectLightTravel.

## Methods

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_IPositionFunction_Position_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> Position\(AstroTime\)

Returns a relative position vector for a given time.

```csharp
AstroVector Position(AstroTime time)
```

#### Parameters

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The time at which to evaluate a relative position vector.

#### Returns

 [AstroVector](ChargerAstronomyEngine.CosineKittyAstronomy.AstroVector.md)

