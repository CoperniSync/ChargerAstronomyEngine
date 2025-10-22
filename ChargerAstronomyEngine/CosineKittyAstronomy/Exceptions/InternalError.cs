using System;
using System.Collections.Generic;
using System.Text;

namespace ChargerAstronomyEngine.CosineKittyAstronomy.Exceptions
{
    /// <summary>
    /// This exception indicates an unexpected error occurred inside Astronomy Engine.
    /// Please report any such errors by creating an issue at:
    /// https://github.com/cosinekitty/astronomy/issues
    /// </summary>
    public class InternalError : Exception
    {
        internal InternalError(string message) :
            base("Internal error. Please report an issue at: https://github.com/cosinekitty/astronomy/issues. Diagnostic: " + message)
        { }
    }
}
