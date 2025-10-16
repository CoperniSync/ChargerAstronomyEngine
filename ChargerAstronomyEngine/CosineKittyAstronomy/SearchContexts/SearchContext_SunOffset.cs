using System;
using System.Collections.Generic;
using System.Text;

namespace ChargerAstronomyEngine.CosineKittyAstronomy.SearchContexts
{
    internal class SearchContext_SunOffset : SearchContext
    {
        private readonly double targetLon;

        public SearchContext_SunOffset(double targetLon)
        {
            this.targetLon = targetLon;
        }

        public override double Eval(Astronomy astro, AstroTime time)
        {
            Ecliptic ecl = astro.SunPosition(time);
            return astro.LongitudeOffset(ecl.elon - targetLon);
        }
    }
}
