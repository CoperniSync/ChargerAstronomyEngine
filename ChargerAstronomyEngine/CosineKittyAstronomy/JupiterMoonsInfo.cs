using System;
using System.Collections.Generic;
using System.Text;

namespace ChargerAstronomyEngine.CosineKittyAstronomy
{
    /// <summary>
    /// Holds the positions and velocities of Jupiter's major 4 moons.
    /// </summary>
    /// <remarks>
    /// The #Astronomy.JupiterMoons function returns an object of this type
    /// to report position and velocity vectors for Jupiter's largest 4 moons
    /// Io, Europa, Ganymede, and Callisto. Each position vector is relative
    /// to the center of Jupiter. Both position and velocity are oriented in
    /// the EQJ system (that is, using Earth's equator at the J2000 epoch).
    /// The positions are expressed in astronomical units (AU),
    /// and the velocities in AU/day.
    /// </remarks>
    public struct JupiterMoonsInfo
    {
        /// <summary>The position and velocity of Jupiter's moon Io.</summary>
        public StateVector io;

        /// <summary>The position and velocity of Jupiter's moon Europa.</summary>
        public StateVector europa;

        /// <summary>The position and velocity of Jupiter's moon Ganymede.</summary>
        public StateVector ganymede;

        /// <summary>The position and velocity of Jupiter's moon Callisto.</summary>
        public StateVector callisto;
    }
}
