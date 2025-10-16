using ChargerAstronomyEngine.CosineKittyAstronomy.Enums;
using ChargerAstronomyShared.Domain;
using ChargerAstronomyShared.Domain.Equatorial;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChargerAstronomyEngine.CosineKittyAstronomy.SearchContexts
{
    internal class SearchContext_Altitude : SearchContext
    {
        private readonly EquatorialCelestialBody body;
        private readonly int direction;
        private readonly Observer observer;
        private readonly double bodyRadiusAu;
        private readonly double targetAltitude;

        public SearchContext_Altitude(EquatorialCelestialBody body, Direction direction, Observer observer, double bodyRadiusAu, double targetAltitude)
        {
            this.body = body;
            this.direction = (int)direction;
            this.observer = observer;
            this.bodyRadiusAu = bodyRadiusAu;
            this.targetAltitude = targetAltitude;
        }

        public override double Eval(Astronomy astro, AstroTime time)
        {
            Equatorial ofdate = astro.Equator(body, time, observer, EquatorEpoch.OfDate, Aberration.Corrected);
            Topocentric hor = astro.Horizon(time, observer, ofdate, Refraction.None);
            double altitude = hor.altitude + Constants.RAD2DEG * Math.Asin(bodyRadiusAu / ofdate.dist);
            return direction * (altitude - targetAltitude);
        }
    }
}
