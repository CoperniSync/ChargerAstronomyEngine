using ChargerAstronomyEngine.CosineKittyAstronomy.Enums;
using ChargerAstronomyShared.Domain.Equatorial;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChargerAstronomyEngine.CosineKittyAstronomy.SearchContexts
{
    internal class SearchContext_NegElongSlope : SearchContext
    {
        private readonly EquatorialCelestialBody body;

        public SearchContext_NegElongSlope(EquatorialCelestialBody body)
        {
            this.body = body;
        }

        public override double Eval(Astronomy astro, AstroTime time)
        {
            const double dt = 0.1;
            AstroTime t1 = time.AddDays(-dt / 2.0);
            AstroTime t2 = time.AddDays(+dt / 2.0);

            double e1 = astro.AngleFromSun(body, t1);
            double e2 = astro.AngleFromSun(body, t2);
            return (e1 - e2) / dt;
        }
    }
}
