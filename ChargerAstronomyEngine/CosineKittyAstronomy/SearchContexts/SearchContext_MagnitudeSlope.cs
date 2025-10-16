using ChargerAstronomyEngine.CosineKittyAstronomy.Enums;
using ChargerAstronomyShared.Domain.Equatorial;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChargerAstronomyEngine.CosineKittyAstronomy.SearchContexts
{
    internal class SearchContext_MagnitudeSlope : SearchContext
    {
        private readonly EquatorialCelestialBody body;

        public SearchContext_MagnitudeSlope(EquatorialCelestialBody body)
        {
            this.body = body;
        }

        public override double Eval(Astronomy astro, AstroTime time)
        {
            // The Search() function finds a transition from negative to positive values.
            // The derivative of magnitude y with respect to time t (dy/dt)
            // is negative as an object gets brighter, because the magnitude numbers
            // get smaller. At peak magnitude dy/dt = 0, then as the object gets dimmer,
            // dy/dt > 0.
            const double dt = 0.01;
            AstroTime t1 = time.AddDays(-dt / 2);
            AstroTime t2 = time.AddDays(+dt / 2);
            IllumInfo y1 = astro.Illumination(body, t1);
            IllumInfo y2 = astro.Illumination(body, t2);
            return (y2.mag - y1.mag) / dt;
        }
    }
}
