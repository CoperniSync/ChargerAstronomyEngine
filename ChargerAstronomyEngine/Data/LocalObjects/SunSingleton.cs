using ChargerAstronomyEngine.CosineKittyAstronomy;
using ChargerAstronomyEngine.CosineKittyAstronomy.Enums;
using ChargerAstronomyShared.Domain;
using ChargerAstronomyShared.Domain.Equatorial;
using ChargerAstronomyShared.Domain.Horizontal;
using System;
using System.Numerics;

namespace ChargerAstronomyEngine.Data.LocalObjects
{
    public sealed class SunSingleton : EquatorialCelestialBody
    {
        private static readonly Lazy<SunSingleton> _instance = new Lazy<SunSingleton>(() => new SunSingleton());

        private DateTime currentTime;
        private AstroTime astroTime;
        private Observer observer;

        public static SunSingleton Instance => _instance.Value;

        public DateTime CurrentTime => currentTime;

        /// <summary>
        /// Private constructor to initialize the singleton instance with default values.
        /// </summary>
        private SunSingleton() : base(BodyType.Sun)
        {
            // Default values: observer at the equator and prime meridian, J2000 epoch time.
            observer = new Observer(0, 0, 150);
            currentTime = new AstroTime(2000, 1, 1, 12, 0, 0).ToUtcDateTime();
            astroTime = new AstroTime(currentTime);
        }

        /// <summary>
        /// Creates and returns a HorizontalMoon object using the current observer and time.
        /// Updates the inherited properties from EquatorialCelestialBody.
        /// </summary>
        public HorizontalSun CreateSun()
        {
            var astronomy = new Astronomy();
            var sun = new HorizontalSun();

            // Calculate equatorial and horizontal coordinates
            Equatorial equ = astronomy.Equator(sun, astroTime, observer, EquatorEpoch.OfDate, Aberration.Corrected);
            Topocentric hor = astronomy.Horizon(astroTime, observer, equ, Refraction.Normal);
            var illumination = astronomy.Illumination(sun, astroTime);

            sun.Azimuth = hor.azimuth;
            sun.Altitude = hor.altitude;
            sun.RightAscension = equ.ra;
            sun.Declination = equ.dec;
            sun.Distance = equ.dist;
            sun.Magnitude = illumination.mag;

            return sun;
        }
    }
}
