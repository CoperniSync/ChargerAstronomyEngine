using System;
using System.Collections.Generic;
using System.Text;

namespace ChargerAstronomyEngine.CosineKittyAstronomy.SearchContexts
{
    internal class SearchContext_MoonNode : SearchContext
    {
        public double Direction;

        public override double Eval(Astronomy astro, AstroTime time)
        {
            Spherical moon = astro.EclipticGeoMoon(time);
            return Direction * moon.lat;
        }
    }
}
