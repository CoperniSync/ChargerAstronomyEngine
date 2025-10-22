using System;
using System.Collections.Generic;
using System.Text;

namespace ChargerAstronomyEngine.CosineKittyAstronomy
{
    /// <summary>
    /// Equatorial angular and cartesian coordinates.
    /// </summary>
    /// <remarks>
    /// Coordinates of a celestial body as seen from the Earth
    /// (geocentric or topocentric, depending on context),
    /// oriented with respect to the projection of the Earth's equator onto the sky.
    /// </remarks>
    public struct Equatorial
    {
        /// <summary>
        /// Right ascension in sidereal hours.
        /// </summary>
        public readonly double ra;

        /// <summary>
        /// Declination in degrees.
        /// </summary>
        public readonly double dec;

        /// <summary>
        /// Distance to the celestial body in AU.
        /// </summary>
        public readonly double dist;

        /// <summary>
        /// Equatorial coordinates in cartesian vector form: x = March equinox, y = June solstice, z = north.
        /// </summary>
        public readonly AstroVector vec;

        internal Equatorial(double ra, double dec, double dist, AstroVector vec)
        {
            this.ra = ra;
            this.dec = dec;
            this.dist = dist;
            this.vec = vec;
        }
    }
}
