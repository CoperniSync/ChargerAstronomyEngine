using ChargerAstronomyEngine.CosineKittyAstronomy;
using ChargerAstronomyShared.Contracts.Models;
using ChargerAstronomyShared.Contracts.Repositories;
using ChargerAstronomyShared.Domain;
using ChargerAstronomyShared.Domain.Heat;
using ChargerAstronomyShared.Domain.Horizontal;
using ChargerAstronomyShared.Domain.SpatialIndex;
using ChargerAstronomyEngine.CosineKittyAstronomy.Enums;

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ChargerAstronomyEngine.Streaming
{
    public class EquatorialCalculator : ITimeAndPlaceProvider, IEquatorialCalculator
    {
        SpatialStarIndex starIndex;

        AstroTime astroTime;
        Observer location;

        Astronomy astro;

        public EquatorialCalculator(HeatService heatService, SpatialStarIndex starIndex)
        {
            this.starIndex = starIndex ?? throw new ArgumentNullException(nameof(starIndex));
            this.astro = new Astronomy();

            location = new Observer(0, 0, 150);

            var J200 = new CalendarDateTime(2000, 1, 1, 12, 0, 0);
            astroTime = new AstroTime(J200);
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

        public void UpdateStar(HorizontalStar star)
        {
            var currentTime = this.astroTime;
            var equatorial = astro.Equator(
                star, 
                currentTime, 
                location, 
                EquatorEpoch.J2000, 
                Aberration.Corrected
            );

            var topocentric = astro.Horizon(currentTime, location, equatorial,Refraction.Normal);
            star.Altitude = topocentric.altitude;
            star.Azimuth = topocentric.azimuth;
        }

    }
}
