using System;
using System.Collections.Generic;
using System.Text;

namespace ChargerAstronomyEngine.CosineKittyAstronomy
{
    /// <summary>
    /// Ecliptic angular and Cartesian coordinates.
    /// </summary>
    /// <remarks>
    /// Coordinates of a celestial body as seen from the center of the Sun (heliocentric),
    /// oriented with respect to the plane of the Earth's orbit around the Sun (the ecliptic).
    /// </remarks>
    public struct Ecliptic
    {
        /// <summary>
        /// Cartesian ecliptic vector, with components as follows:
        /// x: the direction of the equinox along the ecliptic plane.
        /// y: in the ecliptic plane 90 degrees prograde from the equinox.
        /// z: perpendicular to the ecliptic plane. Positive is north.
        /// </summary>
        public readonly AstroVector vec;

        /// <summary>
        /// Latitude in degrees north (positive) or south (negative) of the ecliptic plane.
        /// </summary>
        public readonly double elat;

        /// <summary>
        /// Longitude in degrees around the ecliptic plane prograde from the equinox.
        /// </summary>
        public readonly double elon;

        internal Ecliptic(AstroVector vec, double elat, double elon)
        {
            this.vec = vec;
            this.elat = elat;
            this.elon = elon;
        }
    }
}
