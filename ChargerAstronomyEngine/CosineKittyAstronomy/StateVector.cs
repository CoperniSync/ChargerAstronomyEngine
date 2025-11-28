using System;
using System.Collections.Generic;
using System.Text;

namespace ChargerAstronomyEngine.CosineKittyAstronomy
{
    /// <summary>
    /// A combination of a position vector and a velocity vector at a given moment in time.
    /// </summary>
    /// <remarks>
    /// A state vector represents the dynamic state of a point at a given moment.
    /// It includes the position vector of the point, expressed in Astronomical Units (AU)
    /// along with the velocity vector of the point, expressed in AU/day.
    /// </remarks>
    public struct StateVector
    {
        /// <summary>
        /// The position x-coordinate in AU.
        /// </summary>
        public double x;

        /// <summary>
        /// The position y-coordinate in AU.
        /// </summary>
        public double y;

        /// <summary>
        /// The position z-coordinate in AU.
        /// </summary>
        public double z;

        /// <summary>
        /// The velocity x-component in AU/day.
        /// </summary>
        public double vx;

        /// <summary>
        /// The velocity y-component in AU/day.
        /// </summary>
        public double vy;

        /// <summary>
        /// The velocity z-component in AU/day.
        /// </summary>
        public double vz;

        /// <summary>
        /// The date and time at which this vector is valid.
        /// </summary>
        public AstroTime t;

        /// <summary>
        /// Creates an AstroVector.
        /// </summary>
        /// <param name="x">A position x-coordinate expressed in AU.</param>
        /// <param name="y">A position y-coordinate expressed in AU.</param>
        /// <param name="z">A position z-coordinate expressed in AU.</param>
        /// <param name="vx">A velocity x-component expressed in AU/day.</param>
        /// <param name="vy">A velocity y-component expressed in AU/day.</param>
        /// <param name="vz">A velocity z-component expressed in AU/day.</param>
        /// <param name="t">The date and time at which this state vector is valid.</param>
        public StateVector(double x, double y, double z, double vx, double vy, double vz, AstroTime t)
        {
            if (t == null)
                throw new NullReferenceException("AstroTime parameter is not allowed to be null.");

            this.x = x;
            this.y = y;
            this.z = z;
            this.vx = vx;
            this.vy = vy;
            this.vz = vz;
            this.t = t;
        }

        /// <summary>
        /// Combines a position vector and a velocity vector into a single state vector.
        /// </summary>
        /// <param name="pos">A position vector.</param>
        /// <param name="vel">A velocity vector.</param>
        /// <param name="time">The common time that represents the given position and velocity.</param>
        public StateVector(AstroVector pos, AstroVector vel, AstroTime time)
        {
            if (time == null)
                throw new NullReferenceException("AstroTime parameter is not allowed to be null.");

            this.x = pos.x;
            this.y = pos.y;
            this.z = pos.z;
            this.vx = vel.x;
            this.vy = vel.y;
            this.vz = vel.z;
            this.t = time;
        }

        /// <summary>
        /// Converts the state vector to a string of the format (x, y, z, vx, vy, vz, t).
        /// </summary>
        public override string ToString()
        {
            return $"({x:G16}, {y:G16}, {z:G16}, {vx:G16}, {vy:G16}, {vz:G16}, {t})";
        }

        /// <summary>
        /// Returns the position vector associated with this state vector.
        /// </summary>
        public AstroVector Position()
        {
            return new AstroVector(x, y, z, t);
        }

        /// <summary>
        /// Returns the velocity vector associated with this state vector.
        /// </summary>
        public AstroVector Velocity()
        {
            return new AstroVector(vx, vy, vz, t);
        }
    }
}
