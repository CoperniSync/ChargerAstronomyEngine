using ChargerAstronomyShared.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChargerAstronomyEngine.CosineKittyAstronomy.SearchContexts
{
    internal class SearchContext_LocalMoonShadowSlope : SearchContext
    {
        private readonly Observer observer;

        public SearchContext_LocalMoonShadowSlope( Observer observer)
        {
            this.observer = observer;
        }

        public override double Eval(Astronomy astro, AstroTime time)
        {
            const double dt = 1.0 / 86400.0;
            AstroTime t1 = time.AddDays(-dt);
            AstroTime t2 = time.AddDays(+dt);
            ShadowInfo shadow1 = astro.LocalMoonShadow(t1, observer);
            ShadowInfo shadow2 = astro.LocalMoonShadow(t2, observer);
            return (shadow2.r - shadow1.r) / dt;
        }
    }
}
