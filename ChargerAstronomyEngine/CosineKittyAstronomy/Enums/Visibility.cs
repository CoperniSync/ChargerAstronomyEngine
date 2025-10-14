using System;
using System.Collections.Generic;
using System.Text;

namespace ChargerAstronomyEngine.CosineKittyAstronomy.Enums
{    
    /// <summary>
    /// Indicates whether a body (especially Mercury or Venus) is best seen in the morning or evening.
    /// </summary>
    public enum Visibility
    {
        /// <summary>
        /// The body is best visible in the morning, before sunrise.
        /// </summary>
        Morning,

        /// <summary>
        /// The body is best visible in the evening, after sunset.
        /// </summary>
        Evening,
    }
}
