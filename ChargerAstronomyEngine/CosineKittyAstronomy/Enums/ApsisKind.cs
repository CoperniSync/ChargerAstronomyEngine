using System;
using System.Collections.Generic;
using System.Text;

namespace ChargerAstronomyEngine.CosineKittyAstronomy.Enums
{
    /// <summary>
    /// The type of apsis: pericenter (closest approach) or apocenter (farthest distance).
    /// </summary>
    public enum ApsisKind
    {
        /// <summary>The body is at its closest approach to the object it orbits.</summary>
        Pericenter,

        /// <summary>The body is at its farthest distance from the object it orbits.</summary>
        Apocenter,
    }
}
