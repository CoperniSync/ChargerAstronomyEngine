using System;
using System.Collections.Generic;
using System.Text;

namespace ChargerAstronomyEngine.CosineKittyAstronomy
{

    internal struct TerseVector
    {
        public double x;
        public double y;
        public double z;

        public TerseVector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static readonly TerseVector Zero = new TerseVector(0.0, 0.0, 0.0);

        public AstroVector ToAstroVector(AstroTime time)
        {
            return new AstroVector(x, y, z, time);
        }

        public static TerseVector operator +(TerseVector a, TerseVector b)
        {
            return new TerseVector(a.x + b.x, a.y + b.y, a.z + b.z);
        }

        public static TerseVector operator -(TerseVector a, TerseVector b)
        {
            return new TerseVector(a.x - b.x, a.y - b.y, a.z - b.z);
        }

        public static TerseVector operator -(TerseVector a)
        {
            return new TerseVector(-a.x, -a.y, -a.z);
        }

        public static TerseVector operator *(double s, TerseVector v)
        {
            return new TerseVector(s * v.x, s * v.y, s * v.z);
        }

        public static TerseVector operator /(TerseVector v, double s)
        {
            return new TerseVector(v.x / s, v.y / s, v.z / s);
        }

        public double Quadrature()
        {
            return x * x + y * y + z * z;
        }

        public double Magnitude()
        {
            return Math.Sqrt(Quadrature());
        }
    }
}
