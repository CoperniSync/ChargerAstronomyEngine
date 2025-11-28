using System;
using System.Collections.Generic;
using System.Text;

namespace ChargerAstronomyEngine.CosineKittyAstronomy.SearchContexts
{
    internal class SearchContext_EarthShadow : SearchContext
    {
        private readonly double radius_limit;
        private readonly double direction;

        public SearchContext_EarthShadow(double radius_limit, double direction)
        {
            this.radius_limit = radius_limit;
            this.direction = direction;
        }

        public override double Eval(Astronomy astro, AstroTime time)
        {
            return direction * (astro.EarthShadow(time).r - radius_limit);
        }
    }
}
