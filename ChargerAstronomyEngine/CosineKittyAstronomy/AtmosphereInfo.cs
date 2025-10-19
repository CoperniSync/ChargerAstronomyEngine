using System;
using System.Collections.Generic;
using System.Text;

namespace ChargerAstronomyEngine.CosineKittyAstronomy
{

    /// <summary>
    /// Information about idealized atmospheric variables at a given elevation.
    /// </summary>
    public struct AtmosphereInfo
    {
        /// <summary>
        /// Atmospheric pressure in pascals.
        /// </summary>
        public double pressure;

        /// <summary>
        /// Atmospheric temperature in kelvins.
        /// </summary>
        public double temperature;

        /// <summary>
        /// Atmospheric density relative to sea level.
        /// </summary>
        public double density;
    }
}
