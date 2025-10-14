using System;
using System.Collections.Generic;
using System.Text;

namespace ChargerAstronomyEngine.CosineKittyAstronomy
{
    /// <summary>
    /// Lunar libration angles, returned by #Astronomy.Libration.
    /// </summary>
    public struct LibrationInfo
    {
        /// <summary>Sub-Earth libration ecliptic latitude angle, in degrees.</summary>
        public double elat;

        /// <summary>Sub-Earth libration ecliptic longitude angle, in degrees.</summary>
        public double elon;

        /// <summary>Moon's geocentric ecliptic latitude in degrees.</summary>
        public double mlat;

        /// <summary>Moon's geocentric ecliptic longitude in degrees.</summary>
        public double mlon;

        /// <summary>Distance between the centers of the Earth and Moon in kilometers.</summary>
        public double dist_km;

        /// <summary>The apparent angular diameter of the Moon, in degrees, as seen from the center of the Earth.</summary>
        public double diam_deg;
    }
}
