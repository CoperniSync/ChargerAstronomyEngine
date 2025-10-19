using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace ChargerAstronomyEngine.CosineKittyAstronomy
{
    /// <summary>
    /// A 3D Cartesian vector whose components are expressed in Astronomical Units (AU).
    /// </summary>
    public struct AstroVector
    {
        /// <summary>
        /// The Cartesian x-coordinate of the vector in AU.
        /// </summary>
        public double x;

        /// <summary>
        /// The Cartesian y-coordinate of the vector in AU.
        /// </summary>
        public double y;

        /// <summary>
        /// The Cartesian z-coordinate of the vector in AU.
        /// </summary>
        public double z;

        /// <summary>
        /// The date and time at which this vector is valid.
        /// </summary>
        public AstroTime t;

        /// <summary>
        /// Creates an AstroVector.
        /// </summary>
        /// <param name="x">A Cartesian x-coordinate expressed in AU.</param>
        /// <param name="y">A Cartesian y-coordinate expressed in AU.</param>
        /// <param name="z">A Cartesian z-coordinate expressed in AU.</param>
        /// <param name="t">The date and time at which this vector is valid.</param>
        public AstroVector(double x, double y, double z, AstroTime t)
        {
            if (t == null)
                throw new NullReferenceException("AstroTime parameter is not allowed to be null.");

            this.x = x;
            this.y = y;
            this.z = z;
            this.t = t;
        }

        /// <summary>
        /// Converts the vector to a string of the format (x, y, z, t).
        /// </summary>
        public override string ToString()
        {
            return $"({x:G16}, {y:G16}, {z:G16}, {t})";
        }

        // (0.1428571428571428, 1.333333333333333, 3.846153846153846E-07, 2023-02-14T09:45:30.000Z)
        private static Regex re = new Regex(
            @"^\s*\(\s*                 # (
            ([^\s,]+) \s* , \s*         # x ,
            ([^\s,]+) \s* , \s*         # y ,
            ([^\s,]+) \s* , \s*         # z ,
            ([^\s\)]+) \s* \) \s* $     # t )",
            RegexOptions.Compiled | RegexOptions.CultureInvariant | RegexOptions.IgnorePatternWhitespace
        );

        /// <summary>
        /// Parses a vector from a string as formatted by #AstroVector.ToString.
        /// On success, `vector` receives the vector and the function returns `true`.
        /// Otherwise, `vector` receives the value (0, 0, 0, null) and the function returns `false`.
        /// </summary>
        /// <param name="text">A string of the form "(x, y, z, t)".</param>
        /// <param name="vector">Receives the output vector.</param>
        public static bool TryParse(string text, out AstroVector vector)
        {
            vector = new AstroVector();
            if (text != null)
            {
                Match m = re.Match(text);
                if (m.Success)
                {
                    var styles = NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent;
                    return (
                        double.TryParse(m.Groups[1].Value, styles, CultureInfo.InvariantCulture, out vector.x) &&
                        double.TryParse(m.Groups[2].Value, styles, CultureInfo.InvariantCulture, out vector.y) &&
                        double.TryParse(m.Groups[3].Value, styles, CultureInfo.InvariantCulture, out vector.z) &&
                        AstroTime.TryParse(m.Groups[4].Value, out vector.t)
                    );
                }
            }
            return false;
        }

        /// <summary>
        /// Calculates the total distance in AU represented by this vector.
        /// </summary>
        /// <returns>The nonnegative length of the Cartisian vector in AU.</returns>
        public double Length()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }

#pragma warning disable 1591        // we don't need XML documentation for these operator overloads
        public static AstroVector operator -(AstroVector a)
        {
            return new AstroVector(-a.x, -a.y, -a.z, a.t);
        }

        public static AstroVector operator -(AstroVector a, AstroVector b)
        {
            return new AstroVector(
                a.x - b.x,
                a.y - b.y,
                a.z - b.z,
                VerifyIdenticalTimes(a.t, b.t)
            );
        }

        public static AstroVector operator +(AstroVector a, AstroVector b)
        {
            return new AstroVector(
                a.x + b.x,
                a.y + b.y,
                a.z + b.z,
                VerifyIdenticalTimes(a.t, b.t)
            );
        }

        public static double operator *(AstroVector a, AstroVector b)
        {
            // the scalar dot product of two vectors
            VerifyIdenticalTimes(a.t, b.t);
            return (a.x * b.x) + (a.y * b.y) + (a.z * b.z);
        }

        public static AstroVector operator *(double factor, AstroVector a)
        {
            return new AstroVector(
                factor * a.x,
                factor * a.y,
                factor * a.z,
                a.t
            );
        }

        public static AstroVector operator /(AstroVector a, double denom)
        {
            if (denom == 0.0)
                throw new ArgumentException("Attempt to divide a vector by zero.");

            return new AstroVector(
                a.x / denom,
                a.y / denom,
                a.z / denom,
                a.t
            );
        }
#pragma warning restore 1591

        private static AstroTime VerifyIdenticalTimes(AstroTime a, AstroTime b)
        {
            if (a.tt != b.tt)
                throw new ArgumentException("Attempt to operate on two vectors from different times.");

            // If either time has already had its nutation calculated, retain that work.
            return !double.IsNaN(a.psi) ? a : b;
        }
    }
}
