using ChargerAstronomyEngine.CosineKittyAstronomy.Enums;
using ChargerAstronomyShared.Domain.Equatorial;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChargerAstronomyEngine.CosineKittyAstronomy.SearchContexts
{
    internal class SearchContext_PlanetDistanceSlope : SearchContext
    {
        private readonly double direction;
        private readonly EquatorialCelestialBody body;

        public SearchContext_PlanetDistanceSlope(double direction, EquatorialCelestialBody body)
        {
            this.direction = direction;
            this.body = body;
        }

        public override double Eval(Astronomy astro, AstroTime time)
        {
            const double dt = 0.001;
            AstroTime t1 = time.AddDays(-dt / 2.0);
            AstroTime t2 = time.AddDays(+dt / 2.0);
            double r1 = astro.HelioDistance(body, t1);
            double r2 = astro.HelioDistance(body, t2);
            return direction * (r2 - r1) / dt;
        }
    }
}
