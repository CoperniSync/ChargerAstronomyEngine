using System;
using System.Collections.Generic;
using System.Text;

namespace ChargerAstronomyEngine.CosineKittyAstronomy.Enums
{
    /// <summary>
    /// Selects whether to search for a rising event or a setting event for a celestial body.
    /// </summary>
    public enum Direction
    {
        /// <summary>
        /// Indicates a rising event: a celestial body is observed to rise above the horizon by an observer on the Earth.
        /// </summary>
        Rise = +1,

        /// <summary>
        /// Indicates a setting event: a celestial body is observed to sink below the horizon by an observer on the Earth.
        /// </summary>
        Set = -1,
    }
}
