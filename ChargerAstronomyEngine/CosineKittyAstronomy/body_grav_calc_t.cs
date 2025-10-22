using System;
using System.Collections.Generic;
using System.Text;

namespace ChargerAstronomyEngine.CosineKittyAstronomy
{
    internal struct body_grav_calc_t
    {
        public double tt;       // J2000 terrestrial time [days]
        public TerseVector r;   // position [au]
        public TerseVector v;   // velocity [au/day]
        public TerseVector a;   // acceleration [au/day^2]

        public body_grav_calc_t(double tt, TerseVector r, TerseVector v, TerseVector a)
        {
            this.tt = tt;
            this.r = r;
            this.v = v;
            this.a = a;
        }
    }
}
