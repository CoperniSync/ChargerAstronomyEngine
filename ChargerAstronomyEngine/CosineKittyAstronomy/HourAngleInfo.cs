using System;
using System.Collections.Generic;
using System.Text;

namespace ChargerAstronomyEngine.CosineKittyAstronomy
{
    /// <summary>
    /// Information about a celestial body crossing a specific hour angle.
    /// </summary>
    /// <remarks>
    /// Returned by the function #Astronomy.SearchHourAngle to report information about
    /// a celestial body crossing a certain hour angle as seen by a specified topocentric observer.
    /// </remarks>
    public struct HourAngleInfo
    {
        /// <summary>The date and time when the body crosses the specified hour angle.</summary>
        public readonly AstroTime time;

        /// <summary>Apparent coordinates of the body at the time it crosses the specified hour angle.</summary>
        public readonly Topocentric hor;

        internal HourAngleInfo(AstroTime time, Topocentric hor)
        {
            this.time = time;
            this.hor = hor;
        }
    }
}
