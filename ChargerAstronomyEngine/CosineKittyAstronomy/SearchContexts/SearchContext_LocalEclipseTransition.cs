using ChargerAstronomyShared.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChargerAstronomyEngine.CosineKittyAstronomy.SearchContexts
{
    internal class SearchContext_LocalEclipseTransition : SearchContext
    {
        private readonly Func<ShadowInfo, double> func;
        private readonly double direction;
        private readonly Observer observer;

        public SearchContext_LocalEclipseTransition(Func<ShadowInfo, double> func, double direction, Observer observer)
        {
            this.func = func;
            this.direction = direction;
            this.observer = observer;
        }

        public override double Eval(Astronomy astro, AstroTime time)
        {
            ShadowInfo shadow = astro.LocalMoonShadow(time, observer);
            return direction * func(shadow);
        }
    }
}
