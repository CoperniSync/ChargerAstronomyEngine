using System;
using System.Collections.Generic;
using System.Text;

namespace ChargerAstronomyEngine.CosineKittyAstronomy
{
    internal struct body_state_t
    {
        public double tt;       // Terrestrial Time in J2000 days
        public TerseVector r;   // position [au]
        public TerseVector v;   // velocity [au/day]

        public body_state_t(double tt, TerseVector r, TerseVector v)
        {
            this.tt = tt;
            this.r = r;
            this.v = v;
        }

        public static body_state_t operator -(body_state_t s)
        {
            return new body_state_t(s.tt, -s.r, -s.v);
        }

        public static body_state_t operator -(body_state_t a, body_state_t b)
        {
            return new body_state_t(a.tt, a.r - b.r, a.v - b.v);
        }
    }
}
