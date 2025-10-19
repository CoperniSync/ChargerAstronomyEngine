using ChargerAstronomyShared.Domain.Equatorial;
using ChargerAstronomyShared.Domain.Horizontal;
using ChargerAstronomyEngine.CosineKittyAstronomy;
using ChargerAstronomyEngine.CosineKittyAstronomy.Enums;
using ChargerAstronomyShared.Domain;
using System;

namespace ChargerAstronomyEngine.Data.LocalObjects
{
    public sealed class MoonSingleton
    {
        private static readonly Lazy<MoonSingleton> _instance = new Lazy<MoonSingleton>(() => new MoonSingleton());

        private DateTime currentTime;
        private AstroTime astroTime;
        private Observer observer;

        public static MoonSingleton Instance => _instance.Value;

        public DateTime CurrentTime => currentTime;

        /// <summary>
        /// Private constructor to initialize the singleton instance with default values.
        /// </summary>
        private MoonSingleton()
        {
            // Default values: observer at the equator and prime meridian, J2000 epoch time.
            observer = new Observer(0, 0, 150);
            currentTime = new AstroTime(2000, 1, 1, 12, 0, 0).ToUtcDateTime();
            astroTime = new AstroTime(currentTime);
        }

        /// <summary>
        /// Creates and returns a HorizontalMoon object using the current observer and time.
        /// </summary>
        public HorizontalMoon CreateMoon()
        {
            // Create an instance of Astronomy
            var astronomy = new Astronomy();
            var moon = new HorizontalMoon();

            // Calculate equatorial and horizontal coordinates
            Equatorial equ = astronomy.Equator(moon, astroTime, observer, EquatorEpoch.OfDate, Aberration.Corrected);
            Topocentric hor = astronomy.Horizon(astroTime, observer, equ, Refraction.Normal);
            var illumination = astronomy.Illumination(moon, astroTime);
            var phase = astronomy.MoonPhase(astroTime);

            // Update moon properties
            moon.Azimuth = hor.azimuth;
            moon.Altitude = hor.altitude;
            moon.RightAscension = equ.ra;
            moon.Declination = equ.dec;
            moon.Distance = equ.dist;
            moon.Magnitude = illumination.mag;
            moon.Phase = phase;

            return moon;
        }
    }
}
