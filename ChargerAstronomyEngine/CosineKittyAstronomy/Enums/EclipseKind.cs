using System;
using System.Collections.Generic;
using System.Text;

namespace ChargerAstronomyEngine.CosineKittyAstronomy.Enums
{
    /// <summary>The different kinds of lunar/solar eclipses.</summary>
    public enum EclipseKind
    {
        /// <summary>No eclipse found.</summary>
        None,

        /// <summary>A penumbral lunar eclipse. (Never used for a solar eclipse.)</summary>
        Penumbral,

        /// <summary>A partial lunar/solar eclipse.</summary>
        Partial,

        /// <summary>An annular solar eclipse. (Never used for a lunar eclipse.)</summary>
        Annular,

        /// <summary>A total lunar/solar eclipse.</summary>
        Total,
    }
}
