using System;
using System.Collections.Generic;
using System.Text;

namespace ChargerAstronomyEngine.CosineKittyAstronomy.SearchContexts
{
    internal class SearchContext_MoonDistanceSlope : SearchContext
    {
        private readonly int direction;

        public SearchContext_MoonDistanceSlope(int direction)
        {
            this.direction = direction;
        }

        public static double MoonDistance(AstroTime time)
        {
            var context = new MoonContext(time.tt / 36525.0);
            MoonResult moon = context.CalcMoon();
            return moon.distance_au;
        }

        public override double Eval(Astronomy astro, AstroTime time)
        {
            const double dt = 0.001;
            AstroTime t1 = time.AddDays(-dt / 2.0);
            AstroTime t2 = time.AddDays(+dt / 2.0);
            double dist1 = MoonDistance(t1);
            double dist2 = MoonDistance(t2);
            return direction * (dist2 - dist1) / dt;
        }
    }
}
