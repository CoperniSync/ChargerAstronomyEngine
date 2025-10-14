using System;
using System.Collections.Generic;
using System.Text;

namespace ChargerAstronomyEngine.CosineKittyAstronomy.Enums
{
    /// <summary>
    /// Indicates whether a crossing through the ecliptic plane is ascending or descending.
    /// </summary>
    public enum NodeEventKind
    {
        /// <summary>Placeholder value for a missing or invalid node.</summary>
        Invalid = 0,

        /// <summary>The body passes through the ecliptic plane from south to north.</summary>
        Ascending = +1,

        /// <summary>The body passes through the ecliptic plane from north to south.</summary>
        Descending = -1,
    }
}
