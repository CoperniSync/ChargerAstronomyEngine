using ChargerAstronomyEngine.CosineKittyAstronomy.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChargerAstronomyEngine.CosineKittyAstronomy.Exceptions
{
    /// <summary>
    /// This exception is thrown by certain Astronomy Engine functions
    /// when a body is specified that is not appropriate for the given operation.
    /// </summary>
    public class InvalidBodyException : ArgumentException
    {
        internal InvalidBodyException(Body body) :
            base("Invalid body: " + body)
        { }
    }
    
}
