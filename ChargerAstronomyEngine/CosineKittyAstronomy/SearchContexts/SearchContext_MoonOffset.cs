using System;
using System.Collections.Generic;
using System.Text;

namespace ChargerAstronomyEngine.CosineKittyAstronomy.SearchContexts
{
    internal class SearchContext_MoonOffset : SearchContext
    {
        private readonly double targetLon;

        public SearchContext_MoonOffset(double targetLon)
        {
            this.targetLon = targetLon;
        }

        public override double Eval(Astronomy astro, AstroTime time)
        {
            double angle = astro.MoonPhase(time);
            return Astronomy.LongitudeOffset(angle - targetLon);
        }
    }
}
