using System;
using System.Collections.Generic;
using System.Text;

namespace ChargerAstronomyEngine.CosineKittyAstronomy.Enums
{
    /// <summary>
    /// The enumeration of celestial bodies supported by Astronomy Engine.
    /// </summary>
    public enum Body
    {
        /// <summary>
        /// A placeholder value representing an invalid or unknown celestial body.
        /// </summary>
        Invalid = -1,

        /// <summary>
        /// The planet Mercury.
        /// </summary>
        Mercury,

        /// <summary>
        /// The planet Venus.
        /// </summary>
        Venus,

        /// <summary>
        /// The planet Earth.
        /// Some functions that accept a `Body` parameter will fail if passed this value
        /// because they assume that an observation is being made from the Earth,
        /// and therefore the Earth is not a target of observation.
        /// </summary>
        Earth,

        /// <summary>
        /// The planet Mars.
        /// </summary>
        Mars,

        /// <summary>
        /// The planet Jupiter.
        /// </summary>
        Jupiter,

        /// <summary>
        /// The planet Saturn.
        /// </summary>
        Saturn,

        /// <summary>
        /// The planet Uranus.
        /// </summary>
        Uranus,

        /// <summary>
        /// The planet Neptune.
        /// </summary>
        Neptune,

        /// <summary>
        /// The planet Pluto.
        /// </summary>
        Pluto,

        /// <summary>
        /// The Sun.
        /// </summary>
        Sun,

        /// <summary>
        /// The Earth's natural satellite, the Moon.
        /// </summary>
        Moon,

        /// <summary>
        /// The Earth/Moon Barycenter.
        /// </summary>
        EMB,

        /// <summary>
        /// The Solar System Barycenter.
        /// </summary>
        SSB,

        /// <summary>
        /// User-defined star #1.
        /// </summary>
        Star1 = 101,

        /// <summary>
        /// User-defined star #2.
        /// </summary>
        Star2,

        /// <summary>
        /// User-defined star #3.
        /// </summary>
        Star3,

        /// <summary>
        /// User-defined star #4.
        /// </summary>
        Star4,

        /// <summary>
        /// User-defined star #5.
        /// </summary>
        Star5,

        /// <summary>
        /// User-defined star #6.
        /// </summary>
        Star6,

        /// <summary>
        /// User-defined star #7.
        /// </summary>
        Star7,

        /// <summary>
        /// User-defined star #8.
        /// </summary>
        Star8,
    }
}
