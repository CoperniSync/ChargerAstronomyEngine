using ChargerAstronomyShared.Domain.Equatorial;
using ChargerAstronomyShared.Domain.Horizontal;
using CosineKitty;
using System;
using System.Collections.Generic;

namespace ChargerAstronomyEngine.Data.LocalObjects
{
    public sealed class PlanetsSingleton : EquatorialCelestialBody
    {
        private static readonly Lazy<PlanetsSingleton> _instance = new Lazy<PlanetsSingleton>(() => new PlanetsSingleton());

        private DateTime currentTime;
        private AstroTime astroTime;
        private Observer observer;
        private readonly Dictionary<string, Body> planets;

        public static PlanetsSingleton Instance => _instance.Value;

        public DateTime CurrentTime => currentTime;

        /// <summary>
        /// Private constructor to initialize the singleton instance with default values.
        /// </summary>
        private PlanetsSingleton()
        {
            // Default values: observer at the equator and prime meridian, J2000 epoch time.
            observer = new Observer(0, 0, 150);
            currentTime = new AstroTime(2000, 1, 1, 12, 0, 0).ToUtcDateTime();
            astroTime = new AstroTime(currentTime);

            // Initialize the dictionary of planets.
            planets = new Dictionary<string, Body>
            {
                { Body.Mercury.ToString(), Body.Mercury },
                { Body.Venus.ToString(), Body.Venus },
                { Body.Mars.ToString(), Body.Mars },
                { Body.Jupiter.ToString(), Body.Jupiter },
                { Body.Saturn.ToString(), Body.Saturn },
                { Body.Uranus.ToString(), Body.Uranus },
                { Body.Neptune.ToString(), Body.Neptune }
            };
        }

        /// <summary>
        /// Creates and returns a list of HorizontalPlanet objects for all planets.
        /// Updates the inherited properties from EquatorialCelestialBody.
        /// </summary>
        public IEnumerable<HorizontalPlanet> CreatePlanets()
        {
            List<HorizontalPlanet> planetList = new List<HorizontalPlanet>();

            foreach (var planet in planets)
            {
                Equatorial equ = Astronomy.Equator(planet.Value, astroTime, observer, EquatorEpoch.J2000, Aberration.Corrected);
                var illumination = Astronomy.Illumination(planet.Value, astroTime);

                // Update inherited properties from EquatorialCelestialBody
                RightAscension = equ.ra;
                Declination = equ.dec;
                Distance = equ.dist;
                Magnitude = illumination.mag;

                var eqBody = new EquatorialStar
                {
                    ProperName = planet.Key,
                    RightAscension = RightAscension,
                    Declination = Declination,
                    Distance = Distance,
                    Magnitude = Magnitude
                };

                planetList.Add(new HorizontalPlanet(planet.Key, illumination.phase_angle, eqBody));
            }

            return planetList;
        }
    }
}