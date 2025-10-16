using ChargerAstronomyEngine.CosineKittyAstronomy.Enums;
using ChargerAstronomyShared.Domain.Equatorial;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChargerAstronomyEngine.CosineKittyAstronomy.SearchContexts
{
    internal class SearchContext_PlanetShadowSlope : SearchContext
    {
        private EquatorialCelestialBody body;
        private double planet_radius_km;

        public SearchContext_PlanetShadowSlope(EquatorialCelestialBody body, double planet_radius_km)
        {
            this.body = body;
            this.planet_radius_km = planet_radius_km;
        }

        public override double Eval(Astronomy astro, AstroTime time)
        {
            const double dt = 1.0 / 86400.0;
            ShadowInfo shadow1 = astro.PlanetShadow(body, planet_radius_km, time.AddDays(-dt));
            ShadowInfo shadow2 = astro.PlanetShadow(body, planet_radius_km, time.AddDays(+dt));
            return (shadow2.r - shadow1.r) / dt;
        }
    }
}
