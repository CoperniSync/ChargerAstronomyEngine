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
using ChargerAstronomyEngine.Domain.Heat;

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

        /// <inheritdoc/>
        public void UpdateLocation(Observer newLocation)
        {
            location = newLocation;
        }

        /// <inheritdoc/>
        public void UpdateTimeAndLocation(CalendarDateTime newTime, Observer newLocation)
        {
            astroTime = new AstroTime(newTime);
            location = newLocation;
        }

        /// <inheritdoc/>
        public void UpdateTime(CalendarDateTime newTime)
        {
            astroTime = new AstroTime(newTime);
        }

        /// <inheritdoc/>
        public void GetTimeAndPlace(out AstroTime time, out Observer location)
        {
            time = astroTime;
            location = this.location;
        }

        /// <inheritdoc/>
        public void IncrementTime(float deltaTime)
        {
            astroTime = new AstroTime(astroTime.ut + deltaTime / 86400.0);
        }

        /// <summary>
        /// Updates the horizontal coordinates of the specified star based on the current time and location.
        /// </summary>
        /// <remarks>This method calculates the star's equatorial coordinates using the J2000 epoch and
        /// applies corrections for aberration.  It then converts the equatorial coordinates to topocentric horizontal
        /// coordinates, updating the star's altitude and azimuth.</remarks>
        /// <param name="star">The star whose horizontal coordinates are to be updated. The star must have a valid <see cref="HorizontalBody"/>
        /// property.</param>
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

        /// <summary>
        /// Updates the position and related properties of the specified planet based on the current astronomical time
        /// and location.
        /// </summary>
        /// <exception cref="ArgumentException">Thrown if the <paramref name="planet"/> name is not recognized in the internal collection of known planets.</exception>
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
                throw new ArgumentException(msg, planet.Name);
            }
        }

        /// <summary>
        /// Updates the position, phase, and distance of the specified moon object based on the current astronomical
        /// time and location.
        /// </summary>
        /// <param name="moon">The <see cref="HorizontalMoon"/> object whose properties will be updated. Cannot be <see langword="null"/>.</param>
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

        /// <summary>
        /// Updates the position of the specified <see cref="HorizontalSun"/> object based on the current astronomical
        /// time and location.
        /// </summary>
        /// <param name="sun">The <see cref="HorizontalSun"/> object whose altitude, azimuth, and distance will be updated.</param>
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
