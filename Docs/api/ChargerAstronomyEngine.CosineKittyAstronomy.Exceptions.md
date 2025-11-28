# <a id="ChargerAstronomyEngine_CosineKittyAstronomy_Exceptions"></a> Namespace ChargerAstronomyEngine.CosineKittyAstronomy.Exceptions

### Classes

 [EarthNotAllowedException](ChargerAstronomyEngine.CosineKittyAstronomy.Exceptions.EarthNotAllowedException.md)

This exception is thrown by certain Astronomy Engine functions
when an invalid attempt is made to use the Earth as the observed
celestial body. Usually this happens for cases where the Earth itself
is the location of the observer.

 [InternalError](ChargerAstronomyEngine.CosineKittyAstronomy.Exceptions.InternalError.md)

This exception indicates an unexpected error occurred inside Astronomy Engine.
Please report any such errors by creating an issue at:
https://github.com/cosinekitty/astronomy/issues

 [InvalidBodyException](ChargerAstronomyEngine.CosineKittyAstronomy.Exceptions.InvalidBodyException.md)

This exception is thrown by certain Astronomy Engine functions
when a body is specified that is not appropriate for the given operation.

