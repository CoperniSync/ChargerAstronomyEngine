using ChargerAstronomyShared.Domain.Equatorial;
using ChargerAstronomyShared.Domain.Horizontal;
using ChargerAstronomyEngine.CosineKittyAstronomy;
using ChargerAstronomyEngine.CosineKittyAstronomy.Enums;
using ChargerAstronomyShared.Domain;
using System;
using System.Collections.Generic;

namespace ChargerAstronomyEngine.Data.LocalObjects
{
    /// <summary>
    /// Singleton class to manage and calculate horizontal positions of all planets (excluding Earth).
    /// </summary>
    public sealed class PlanetsSingleton
    {
        private static readonly Lazy<PlanetsSingleton> _instance = new Lazy<PlanetsSingleton>(() => new PlanetsSingleton());

        private readonly Observer observer;
        private readonly Dictionary<string, BodyType> planets;
        private DateTime currentTime;
        private AstroTime astroTime;

        public static PlanetsSingleton Instance => _instance.Value;

        public DateTime CurrentTime => currentTime;
        private PlanetsSingleton()
        {
            observer = new Observer(0, 0, 150);
            currentTime = new AstroTime(2000, 1, 1, 12, 0, 0).ToUtcDateTime();
            astroTime = new AstroTime(currentTime);

            planets = new Dictionary<string, BodyType>
            {
                { BodyType.Mercury.ToString(), BodyType.Mercury },
                { BodyType.Venus.ToString(), BodyType.Venus },
                { BodyType.Mars.ToString(), BodyType.Mars },
                { BodyType.Jupiter.ToString(), BodyType.Jupiter },
                { BodyType.Saturn.ToString(), BodyType.Saturn },
                { BodyType.Uranus.ToString(), BodyType.Uranus },
                { BodyType.Neptune.ToString(), BodyType.Neptune }
            };
        }

        /// <summary>
        /// Creates and returns a list of HorizontalPlanet objects for all planets.
        /// </summary>
        /// <returns>A list of HorizontalPlanet objects.</returns>
        public IEnumerable<HorizontalPlanet> CreatePlanets()
        {
            var astronomy = new Astronomy();
            var planetList = new List<HorizontalPlanet>();

            foreach (var planet in planets)
            {
                var planetObject = new HorizontalPlanet(planet.Value, planet.Key);

                Equatorial equ = astronomy.Equator(planetObject, astroTime, observer, EquatorEpoch.J2000, Aberration.Corrected);
                Topocentric hor = astronomy.Horizon(astroTime, observer, equ, Refraction.Normal);
                IllumInfo illumination = astronomy.Illumination(planetObject, astroTime);

                planetObject.Azimuth = hor.azimuth;
                planetObject.Altitude = hor.altitude;
                planetObject.RightAscension = equ.ra;
                planetObject.Declination = equ.dec;
                planetObject.Distance = equ.dist;
                planetObject.Magnitude = illumination.mag;

                planetList.Add(planetObject);
            }

            return planetList;
        }
    }
}