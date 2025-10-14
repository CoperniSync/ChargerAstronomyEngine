using System;
using System.Collections.Generic;
using System.Text;

namespace ChargerAstronomyEngine.CosineKittyAstronomy.SearchContexts
{
    internal class SearchContext_EarthShadowSlope : SearchContext
    {
        public override double Eval(Astronomy astro, AstroTime time)
        {
            const double dt = 1.0 / 86400.0;
            AstroTime t1 = time.AddDays(-dt);
            AstroTime t2 = time.AddDays(+dt);
            ShadowInfo shadow1 = astro.EarthShadow(t1);
            ShadowInfo shadow2 = astro.EarthShadow(t2);
            return (shadow2.r - shadow1.r) / dt;
        }
    }
}
