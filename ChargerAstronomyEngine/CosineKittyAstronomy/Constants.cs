using System;
using System.Collections.Generic;
using System.Text;

namespace ChargerAstronomyEngine.CosineKittyAstronomy
{
    internal static class Constants
    {
        /// <summary>
        /// The number of kilometers in one astronomical unit (AU).
        /// </summary>
        public const double KM_PER_AU = 1.4959787069098932e+8;

        /// <summary>
        /// The factor to convert radians to degrees = 180/pi.
        /// </summary>
        public const double RAD2DEG = 57.295779513082321;

        /// <summary>
        /// The factor to convert radians to sidereal hours = 12/pi.
        /// </summary>
        public const double RAD2HOUR = 3.819718634205488;

        /// <summary>
        /// The factor to convert degrees to radians = pi/180.
        /// </summary>
        public const double DEG2RAD = 0.017453292519943296;

        /// <summary>
        /// The factor to convert sidereal hours to radians = pi/12.
        /// </summary>
        public const double HOUR2RAD = 0.2617993877991494365;


        // Jupiter radius data are nominal values obtained from:
        // https://www.iau.org/static/resolutions/IAU2015_English.pdf
        // https://nssdc.gsfc.nasa.gov/planetary/factsheet/jupiterfact.html

        /// <summary>
        /// The equatorial radius of Jupiter, expressed in kilometers.
        /// </summary>
        public const double JUPITER_EQUATORIAL_RADIUS_KM = 71492.0;

        /// <summary>
        /// The polar radius of Jupiter, expressed in kilometers.
        /// </summary>
        public const double JUPITER_POLAR_RADIUS_KM = 66854.0;

        /// <summary>
        /// The volumetric mean radius of Jupiter, expressed in kilometers.
        /// </summary>
        public const double JUPITER_MEAN_RADIUS_KM = 69911.0;

        // The radii of Jupiter's four major moons are obtained from:
        // https://ssd.jpl.nasa.gov/?sat_phys_par

        /// <summary>
        /// The mean radius of Jupiter's moon Io, expressed in kilometers.
        /// </summary>
        public const double IO_RADIUS_KM = 1821.6;

        /// <summary>
        /// The mean radius of Jupiter's moon Europa, expressed in kilometers.
        /// </summary>
        public const double EUROPA_RADIUS_KM = 1560.8;

        /// <summary>
        /// The mean radius of Jupiter's moon Ganymede, expressed in kilometers.
        /// </summary>
        public const double GANYMEDE_RADIUS_KM = 2631.2;

        /// <summary>
        /// The mean radius of Jupiter's moon Callisto, expressed in kilometers.
        /// </summary>
        public const double CALLISTO_RADIUS_KM = 2410.3;

        /// <summary>
        /// The speed of light in AU/day.
        /// </summary>
        public const double C_AUDAY = 173.1446326846693;

        /// <summary>
        /// The number of astronomical units in one light-year.
        /// </summary>
        public const double AU_PER_LY = 63241.07708807546;

        internal const double DAYS_PER_TROPICAL_YEAR = 365.24217;
        internal const double ASEC360 = 1296000.0;
        internal const double ASEC2RAD = 4.848136811095359935899141e-6;
        internal const double PI2 = 2.0 * Math.PI;
        internal const double ARC = 3600.0 * 180.0 / Math.PI;       // arcseconds per radian

        internal const double SUN_RADIUS_KM = 695700.0;
        internal const double SUN_RADIUS_AU = SUN_RADIUS_KM / KM_PER_AU;

        internal const double EARTH_FLATTENING = 0.996647180302104;
        internal const double EARTH_EQUATORIAL_RADIUS_KM = 6378.1366;
        internal const double EARTH_EQUATORIAL_RADIUS_AU = EARTH_EQUATORIAL_RADIUS_KM / KM_PER_AU;
        internal const double EARTH_POLAR_RADIUS_KM = EARTH_EQUATORIAL_RADIUS_KM * EARTH_FLATTENING;
        internal const double EARTH_MEAN_RADIUS_KM = 6371.0;    // mean radius of the Earth's geoid, without atmosphere
        internal const double EARTH_ATMOSPHERE_KM = 88.0;       // effective atmosphere thickness for lunar eclipses
        internal const double EARTH_ECLIPSE_RADIUS_KM = EARTH_MEAN_RADIUS_KM + EARTH_ATMOSPHERE_KM;

        internal const double MOON_EQUATORIAL_RADIUS_KM = 1738.1;
        internal const double MOON_MEAN_RADIUS_KM = 1737.4;
        internal const double MOON_POLAR_RADIUS_KM = 1736.0;
        internal const double MOON_POLAR_RADIUS_AU = (MOON_POLAR_RADIUS_KM / KM_PER_AU);
        internal const double MOON_EQUATORIAL_RADIUS_AU = (MOON_EQUATORIAL_RADIUS_KM / KM_PER_AU);

        internal const double ANGVEL = 7.2921150e-5;
        internal const double SECONDS_PER_DAY = 24.0 * 3600.0;
        internal const double SOLAR_DAYS_PER_SIDEREAL_DAY = 0.9972695717592592;
        internal const double MEAN_SYNODIC_MONTH = 29.530588;     // average number of days for Moon to return to the same phase
        internal const double EARTH_ORBITAL_PERIOD = 365.256;
        internal const double NEPTUNE_ORBITAL_PERIOD = 60189.0;
        internal const double REFRACTION_NEAR_HORIZON = 34.0 / 60.0;   //  degrees of refractive "lift" seen for objects near horizon
        internal const double ASEC180 = 180.0 * 60.0 * 60.0;         // arcseconds per 180 degrees (or pi radians)
        internal const double AU_PER_PARSEC = (ASEC180 / Math.PI);   // exact definition of how many AU = one parsec
        internal const double EARTH_MOON_MASS_RATIO = 81.30056;

        //  Masses of the Sun and outer planets, used for:
        //  (1) Calculating the Solar System Barycenter
        //  (2) Integrating the movement of Pluto
        //
        //  https://web.archive.org/web/20120220062549/http://iau-comm4.jpl.nasa.gov/de405iom/de405iom.pdf
        //
        //  Page 10 in the above document describes the constants used in the DE405 ephemeris.
        //  The following are G*M values (gravity constant * mass) in [au^3 / day^2].
        //  This side-steps issues of not knowing the exact values of G and masses M[i];
        //  the products GM[i] are known extremely accurately.
        internal const double SUN_GM = 0.2959122082855911e-03;
        internal const double MERCURY_GM = 0.4912547451450812e-10;
        internal const double VENUS_GM = 0.7243452486162703e-09;
        internal const double EARTH_GM = 0.8887692390113509e-09;
        internal const double MARS_GM = 0.9549535105779258e-10;
        internal const double JUPITER_GM = 0.2825345909524226e-06;
        internal const double SATURN_GM = 0.8459715185680659e-07;
        internal const double URANUS_GM = 0.1292024916781969e-07;
        internal const double NEPTUNE_GM = 0.1524358900784276e-07;
        internal const double PLUTO_GM = 0.2188699765425970e-11;

        internal const double MOON_GM = EARTH_GM / EARTH_MOON_MASS_RATIO;

    }
}
