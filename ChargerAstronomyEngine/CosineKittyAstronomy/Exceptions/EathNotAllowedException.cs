using System;
using System.Collections.Generic;
using System.Text;

namespace ChargerAstronomyEngine.CosineKittyAstronomy.Exceptions
{
    /// <summary>
    /// This exception is thrown by certain Astronomy Engine functions
    /// when an invalid attempt is made to use the Earth as the observed
    /// celestial body. Usually this happens for cases where the Earth itself
    /// is the location of the observer.
    /// </summary>
    public class EarthNotAllowedException : ArgumentException
    {
        internal EarthNotAllowedException() :
            base("The Earth is not allowed as the body parameter.")
        { }
    }
}
