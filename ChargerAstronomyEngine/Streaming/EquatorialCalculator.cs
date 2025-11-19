using ChargerAstronomyEngine.CosineKittyAstronomy;
using ChargerAstronomyEngine.CosineKittyAstronomy.Enums;
using ChargerAstronomyShared.Domain;
using ChargerAstronomyShared.Domain.Heat;
using ChargerAstronomyShared.Domain.Horizontal;
using ChargerAstronomyShared.Domain.Equatorial;
using ChargerAstronomyShared.Domain.SpatialIndex;
using ChargerAstronomyShared.Contracts.Models;
using ChargerAstronomyShared.Contracts.Repositories;

using System;
using System.Text;
using System.Numerics;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace ChargerAstronomyEngine.Streaming
{
    public class EquatorialCalculator<T> : ITimeAndPlaceProvider, IEquatorialCalculator where T : IHorizontal
    {
        SpatialStarIndex<T> starIndex;

        AstroTime astroTime;
        Observer location;

        Astronomy astro;
        Dictionary<string, BodyType> planets;

        public EquatorialCalculator(HeatService heatService, SpatialStarIndex<T> starIndex)
        {
            this.starIndex = starIndex ?? throw new ArgumentNullException(nameof(starIndex));
            this.astro = new Astronomy();

            location = new Observer(0, 0, 150);

            var J200 = new CalendarDateTime(2000, 1, 1, 12, 0, 0);
            astroTime = new AstroTime(J200);

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

        public void UpdateLocation(Observer newLocation)
        {
            location = newLocation;
        }

        public void UpdateTimeAndLocation(CalendarDateTime newTime, Observer newLocation)
        {
            astroTime = new AstroTime(newTime);
            location = newLocation;
        }

        public void UpdateTime(CalendarDateTime newTime)
        {
            astroTime = new AstroTime(newTime);
        }

        public void GetTimeAndPlace(out AstroTime time, out Observer location)
        {
            time = astroTime;
            location = this.location;
        }

        public void IncrementTime(float deltaTime)
        {
            astroTime = new AstroTime(astroTime.ut + deltaTime / 86400.0);
        }

        public void UpdateStar(T star)
        {
            var horizontal = star.HorizontalBody;
            var currentTime = this.astroTime;
            var equatorial = astro.Equator(
                horizontal,
                currentTime,
                location,
                EquatorEpoch.J2000,
                Aberration.Corrected
            );

            var topocentric = astro.Horizon(currentTime, location, equatorial, Refraction.Normal);
            horizontal.Altitude = topocentric.altitude;
            horizontal.Azimuth = topocentric.azimuth;
        }

        public void UpdatePositionOf(HorizontalPlanet planet)
        {
            if (planets.TryGetValue(planet.Name, out BodyType bodyType))
            {
                var currentTime = this.astroTime;
                var equatorial = astro.Equator(
                    planet,
                    currentTime,
                    location,
                    EquatorEpoch.J2000,
                    Aberration.Corrected
                );

                var topocentric = astro.Horizon(currentTime, location, equatorial, Refraction.Normal);
                var illumination = astro.Illumination(planet, astroTime);
                planet.Altitude = topocentric.altitude;
                planet.Azimuth = topocentric.azimuth;
                planet.PhaseAngle = illumination.phase_angle;
                planet.Distance = equatorial.dist;
            } else
            {
                const string msg = "Planet name not recognized in UpdatePositionOf(HorizontalPlanet)";
                throw new ArgumentException(msg, nameof(planet));
            }
        }

        public void UpdatePositionOf(HorizontalMoon moon)
        {
            var currentTime = this.astroTime;
            var equatorial = astro.Equator(
                moon,
                currentTime,
                location,
                EquatorEpoch.J2000,
                Aberration.Corrected
            );

            var topocentric = astro.Horizon(currentTime, location, equatorial, Refraction.Normal);
            var illumination = astro.Illumination(moon, currentTime);
            var phase = astro.MoonPhase(currentTime);
            moon.Altitude = topocentric.altitude;
            moon.Azimuth = topocentric.azimuth;
            moon.Phase = phase;
            moon.Distance = equatorial.dist;
        }

        public void UpdatePositionOf(HorizontalSun sun)
        {
            var currentTime = this.astroTime;
            var equatorial = astro.Equator(
                sun,
                currentTime,
                location,
                EquatorEpoch.J2000,
                Aberration.Corrected
            );
            var topocentric = astro.Horizon(currentTime, location, equatorial, Refraction.Normal);
            sun.Altitude = topocentric.altitude;
            sun.Azimuth = topocentric.azimuth;
            sun.Distance = equatorial.dist;
        }
    }
}
