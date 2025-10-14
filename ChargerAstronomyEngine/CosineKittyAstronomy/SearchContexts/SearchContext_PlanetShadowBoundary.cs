using ChargerAstronomyEngine.CosineKittyAstronomy.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChargerAstronomyEngine.CosineKittyAstronomy.SearchContexts
{
    internal class SearchContext_PlanetShadowBoundary : SearchContext
    {
        private Body body;
        private double planet_radius_km;
        private double direction;

        public SearchContext_PlanetShadowBoundary(Body body, double planet_radius_km, double direction)
        {
            this.body = body;
            this.planet_radius_km = planet_radius_km;
            this.direction = direction;
        }

        public override double Eval(Astronomy astro, AstroTime time)
        {
            ShadowInfo shadow = astro.PlanetShadow(body, planet_radius_km, time);
            return direction * (shadow.r - shadow.p);
        }
    }
}
