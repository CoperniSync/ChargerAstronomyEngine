using System;
using System.Collections.Generic;
using System.Text;

namespace ChargerAstronomyEngine.CosineKittyAstronomy
{
    internal class GravSimEndpoint
    {
        public AstroTime time;
        public body_state_t[] gravitators;
        public body_grav_calc_t[] bodies;
    }
}
