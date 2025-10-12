using ChargerAstronomyShared.Domain.Equatorial;
using ChargerAstronomyShared.Domain.Horizontal;
using CosineKitty;
using System;

namespace ChargerAstronomyEngine.Data.LocalObjects
{
    public sealed class MoonSingleton : EquatorialCelestialBody
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
        /// Updates the inherited properties from EquatorialCelestialBody.
        /// </summary>
        public HorizontalMoon CreateMoon()
        {
            Equatorial equ = Astronomy.Equator(Body.Moon, astroTime, observer, EquatorEpoch.OfDate, Aberration.Corrected);

            // Update inherited properties from EquatorialCelestialBody
            RightAscension = equ.ra;
            Declination = equ.dec;
            Distance = equ.dist;
            Magnitude = Astronomy.Illumination(Body.Moon, astroTime).mag;

            return new HorizontalMoon(new EquatorialStar
            {
                Declination = Declination,
                RightAscension = RightAscension,
                Distance = Distance,
                Magnitude = Magnitude
            });
        }
    }
}
