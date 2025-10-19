using ChargerAstronomyEngine.CosineKittyAstronomy.Enums;
using ChargerAstronomyEngine.CosineKittyAstronomy.Exceptions;
using ChargerAstronomyShared.Domain.Equatorial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChargerAstronomyEngine.CosineKittyAstronomy
{
    /// <summary>
    /// A simulation of zero or more small bodies moving through the Solar System.
    /// </summary>
    /// <remarks>
    /// This class calculates the movement of arbitrary small bodies,
    /// such as asteroids or comets, that move through the Solar System.
    /// It does so by calculating the gravitational forces on the small bodies
    /// from the Sun and planets. The user of this class supplies an enumeration
    /// of initial positions and velocities for the small bodies.
    /// Then the class can update the positions and velocities over small time steps.
    /// </remarks>
    public class GravitySimulator
    {
        /// <summary>
        /// The origin of the reference frame. See constructor for more info.
        /// </summary>
        public readonly EquatorialCelestialBody OriginBody;

        private GravSimEndpoint prev;
        private GravSimEndpoint curr;
        private const int GravitatorArraySize = 1 + (int)BodyType.Sun;
        private static readonly int[] PlanetIndexes = new int[] {
            (int)BodyType.Mercury,
            (int)BodyType.Venus,
            (int)BodyType.Earth,
            (int)BodyType.Mars,
            (int)BodyType.Jupiter,
            (int)BodyType.Saturn,
            (int)BodyType.Uranus,
            (int)BodyType.Neptune
        };

        /// <summary>Creates a gravity simulation object.</summary>
        /// <param name="originBody">
        /// Specifies the origin of the reference frame.
        /// All position vectors and velocity vectors will use `originBody`
        /// as the origin of the coordinate system.
        /// This origin applies to all the input vectors provided in the
        /// `bodyStates` parameter of this function, along with all
        /// output vectors returned by #GravitySimulator.Update.
        /// Most callers will want to provide one of the following:
        /// `Body.Sun` for heliocentric coordinates,
        /// `Body.SSB` for solar system barycentric coordinates,
        /// or `Body.Earth` for geocentric coordinates. Note that the
        /// gravity simulator does not correct for light travel time;
        /// all state vectors are tied to a Newtonian "instantaneous" time.
        /// </param>
        /// <param name="time">
        /// The initial time at which to start the simulation.
        /// </param>
        /// <param name="bodyStates">
        /// An enumeration of zero or more initial state vectors (positions and velocities)
        /// of the small bodies to be simulated.
        /// The caller must know the positions and velocities of the small bodies at an initial moment in time.
        /// Their positions and velocities are expressed with respect to `originBody`, using equatorial
        /// J2000 orientation (EQJ).
        /// Positions are expressed in astronomical units (AU).
        /// Velocities are expressed in AU/day.
        /// All the times embedded within the state vectors must be exactly equal to `time`,
        /// or this constructor will throw an exception.
        /// If `bodyStates` is null, the gravity simulator will contain zero small bodies.
        /// </param>
        public GravitySimulator(
            EquatorialCelestialBody originBody,
            AstroTime time,
            IEnumerable<StateVector> bodyStates)
        {
            OriginBody = originBody;

            // Verify that all the state vectors have matching times.
            StateVector[] bodyStateArray = (bodyStates == null) ? new StateVector[0] : bodyStates.ToArray();
            foreach (StateVector b in bodyStateArray)
                if (b.t.tt != time.tt)
                    throw new ArgumentException("Inconsistent time(s) in bodyStates");

            prev = new GravSimEndpoint
            {
                time = time,
                gravitators = new body_state_t[GravitatorArraySize],
                bodies = new body_grav_calc_t[bodyStateArray.Length],
            };

            curr = new GravSimEndpoint
            {
                time = time,
                gravitators = new body_state_t[GravitatorArraySize],
                bodies = bodyStateArray.Select(b =>
                    new body_grav_calc_t(
                        time.tt,
                        new TerseVector(b.x, b.y, b.z),
                        new TerseVector(b.vx, b.vy, b.vz),
                        TerseVector.Zero
                    )
                ).ToArray(),
            };

            // Calculate the states of the Sun and planets.
            CalcSolarSystem();

            // We need to do all the physics calculations in barycentric coordinates.
            // But the caller provides the input vectors with respect to `originBody`.
            // Correct the input body state vectors for the specified origin.
            if (originBody.BodyType != BodyType.SSB)
            {
                // Determine the barycentric state of the origin body.
                body_state_t ostate = InternalBodyState(originBody);

                // Add barycentric origin to origin-centric bodies to obtain barycentric bodies.
                for (int i = 0; i < curr.bodies.Length; ++i)
                {
                    curr.bodies[i].r += ostate.r;
                    curr.bodies[i].v += ostate.v;
                }
            }

            // Calculate the net acceleration experienced by the small bodies.
            CalcBodyAccelerations();

            // To prepare for a possible swap operation, duplicate the current state into the previous state.
            Duplicate();
        }

        /// <summary>
        /// The number of small bodies that are included in this gravity simulation.
        /// </summary>
        /// <remarks>
        /// #GravitySimulator.Update requres the caller to pass in an array to
        /// receive updated state vectors for the small bodies. This array must
        /// have the same number of elements as the bodies that are being simulated.
        /// `NumSmallBodies` returns this number as a convenience.
        /// </remarks>
        public int NumSmallBodies => curr.bodies.Length;

        /// <summary>
        /// The time represented by the current step of the gravity simulation.
        /// </summary>
        public AstroTime Time => curr.time;

        /// <summary>
        /// Advances a gravity simulation by a small time step.
        /// </summary>
        /// <remarks>
        /// Updates the simulation of the user-supplied small bodies
        /// to the time indicated by the `time` parameter.
        /// Updates the supplied array `bodyStates` of state vectors for the small bodies.
        /// This array must be the same size as the number of bodies supplied
        /// to the constructor of this object.
        /// The positions and velocities in the returned array are referenced
        /// to the `originBody` that was used to construct this simulator.
        /// </remarks>
        /// <param name="time">
        /// A time that is a small increment away from the current simulation time.
        /// It is up to the developer to figure out an appropriate time increment.
        /// Depending on the trajectories, a smaller or larger increment
        /// may be needed for the desired accuracy. Some experimentation may be needed.
        /// Generally, bodies that stay in the outer Solar System and move slowly can
        /// use larger time steps.  Bodies that pass into the inner Solar System and
        /// move faster will need a smaller time step to maintain accuracy.
        /// The `time` value may be after or before the current simulation time
        /// to move forward or backward in time.
        /// </param>
        /// <param name="bodyStates">
        /// If this array is not null, it must contain exactly the same number
        /// of elements as the number of small bodies that were added when this
        /// simulator was created. The non-null array receives updated state vectors
        /// for the simulated small bodies.
        /// If `bodyStates` is null, the simulation is updated but without returning
        /// the state vectors.
        /// </param>
        public void Update(AstroTime time, StateVector[] bodyStates)
        {
            int nbodies = NumSmallBodies;

            if (bodyStates != null && bodyStates.Length != nbodies)
                throw new ArgumentException($"This simulation contains {nbodies} small bodies, but the {nameof(bodyStates)} array has length {bodyStates.Length}. The array must either be null, or it must have the same number of elements.");

            double dt = time.tt - curr.time.tt;
            if (dt == 0.0)
            {
                // Special case: the time has not changed, so skip the usual physics calculations.
                // This allows another way for the caller to query the current body states.
                // It is also necessary to avoid dividing by `dt` if `dt` is zero.
                // To prepare for a possible swap operation, duplicate the current state into the previous state.
                Duplicate();
            }
            else
            {
                // Exchange the current state with the previous state. Then calculate the new current state.
                Swap();

                // Update the current time.
                curr.time = time;

                // Now that the time is set, it is safe to update the Solar System.
                CalcSolarSystem();

                // Estimate the positions of the small bodies as if their existing
                // accelerations apply across the whole time interval.
                for (int i = 0; i < nbodies; ++i)
                    curr.bodies[i].r = Astronomy.UpdatePosition(dt, prev.bodies[i].r, prev.bodies[i].v, prev.bodies[i].a);

                // Calculate the acceleration experienced by the small bodies at
                // their respective approximate next locations.
                CalcBodyAccelerations();

                for (int i = 0; i < nbodies; ++i)
                {
                    // Calculate the average of the acceleration vectors
                    // experienced by the previous body positions and
                    // their estimated next positions.
                    // These become estimates of the mean effective accelerations
                    // over the whole interval.
                    TerseVector acc = (curr.bodies[i].a + prev.bodies[i].a) / 2.0;

                    // Refine the estimates of position and velocity at the next time step,
                    // using the mean acceleration as a better approximation of the
                    // continuously changing acceleration acting on each body.
                    curr.bodies[i].tt = time.tt;
                    curr.bodies[i].r = Astronomy.UpdatePosition(dt, prev.bodies[i].r, prev.bodies[i].v, acc);
                    curr.bodies[i].v = Astronomy.UpdateVelocity(dt, prev.bodies[i].v, acc);
                }

                // Re-calculate accelerations experienced by each body.
                // These will be needed for the next simulation step (if any).
                // Also, they will be potentially useful if some day we add
                // a function to query the acceleration vectors for the bodies.
                CalcBodyAccelerations();
            }

            if (bodyStates != null)
            {
                // Translate our internal calculations of body positions and velocities
                // into state vectors that the caller can understand.
                // We have to convert the internal type body_grav_calc_t to the public
                // type StateVector.
                // Also convert from barycentric coordinates to coordinates based on the
                // selected origin body.
                body_state_t ostate = InternalBodyState(OriginBody);
                for (int i = 0; i < nbodies; ++i)
                {
                    bodyStates[i] = new StateVector(
                        curr.bodies[i].r.x - ostate.r.x,
                        curr.bodies[i].r.y - ostate.r.y,
                        curr.bodies[i].r.z - ostate.r.z,
                        curr.bodies[i].v.x - ostate.v.x,
                        curr.bodies[i].v.y - ostate.v.y,
                        curr.bodies[i].v.z - ostate.v.z,
                        time
                    );
                }
            }
        }

        /// <summary>
        /// Exchange the current time step with the previous time step.
        /// </summary>
        /// <remarks>
        /// Sometimes it is helpful to "explore" various times near a given
        /// simulation time step, while repeatedly returning to the original
        /// time step. For example, when backdating a position for light travel
        /// time, the caller may wish to repeatedly try different amounts of
        /// backdating. When the backdating solver has converged, the caller
        /// wants to leave the simulation in its original state.
        ///
        /// This function allows a single "undo" of a simulation, and does so
        /// very efficiently.
        ///
        /// Usually this function will be called immediately after a matching
        /// call to #GravitySimulator.Update. It has the effect of rolling
        /// back the most recent update. If called twice in a row, it reverts
        /// the swap and thus has no net effect.
        ///
        /// The constructor initializes the current state and previous
        /// state to be identical. Both states represent the `time` parameter that was
        /// passed into the constructor. Therefore, `Swap` will
        /// have no effect from the caller's point of view when passed a simulator
        /// that has not yet been updated by a call to #GravitySimulator.Update.
        /// </remarks>
        public void Swap()
        {
            var swap = curr;
            curr = prev;
            prev = swap;
        }

        /// <summary>
        /// Get the position and velocity of a Solar System body included in the simulation.
        /// </summary>
        /// <remarks>
        /// In order to simulate the movement of small bodies through the Solar System,
        /// the simulator needs to calculate the state vectors for the Sun and planets.
        ///
        /// If an application wants to know the positions of one or more of the planets
        /// in addition to the small bodies, this function provides a way to obtain
        /// their state vectors. This is provided for the sake of efficiency, to avoid
        /// redundant calculations.
        ///
        /// The state vector is returned relative to the position and velocity
        /// of the `originBody` parameter that was passed to this object's constructor.
        /// </remarks>
        ///
        /// <param name="body">
        /// The Sun, Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, or Neptune.
        /// </param>
        public StateVector SolarSystemBodyState(EquatorialCelestialBody body)
        {
            body_state_t bstate = InternalBodyState(body);
            body_state_t ostate = InternalBodyState(OriginBody);
            return Astronomy.ExportState(bstate - ostate, curr.time);
        }

        private void CalcSolarSystem()
        {
            double tt = curr.time.tt;

            // Initialize the Sun's position/velocity as zero vectors, then adjust from pulls of the planets.
            var ssb = new body_state_t(tt, TerseVector.Zero, TerseVector.Zero);

            curr.gravitators[(int)BodyType.Mercury] = Astronomy.AdjustBarycenterPosVel(ref ssb, tt, BodyType.Mercury, Constants.MERCURY_GM);
            curr.gravitators[(int)BodyType.Venus] = Astronomy.AdjustBarycenterPosVel(ref ssb, tt, BodyType.Venus, Constants.VENUS_GM);
            curr.gravitators[(int)BodyType.Earth] = Astronomy.AdjustBarycenterPosVel(ref ssb, tt, BodyType.Earth, Constants.EARTH_GM + Constants.MOON_GM);
            curr.gravitators[(int)BodyType.Mars] = Astronomy.AdjustBarycenterPosVel(ref ssb, tt, BodyType.Mars, Constants.MARS_GM);
            curr.gravitators[(int)BodyType.Jupiter] = Astronomy.AdjustBarycenterPosVel(ref ssb, tt, BodyType.Jupiter, Constants.JUPITER_GM);
            curr.gravitators[(int)BodyType.Saturn] = Astronomy.AdjustBarycenterPosVel(ref ssb, tt, BodyType.Saturn, Constants.SATURN_GM);
            curr.gravitators[(int)BodyType.Uranus] = Astronomy.AdjustBarycenterPosVel(ref ssb, tt, BodyType.Uranus, Constants.URANUS_GM);
            curr.gravitators[(int)BodyType.Neptune] = Astronomy.AdjustBarycenterPosVel(ref ssb, tt, BodyType.Neptune, Constants.NEPTUNE_GM);

            // Convert planets states from heliocentric to barycentric.
            foreach (int bindex in PlanetIndexes)
            {
                curr.gravitators[bindex].r -= ssb.r;
                curr.gravitators[bindex].v -= ssb.v;
            }

            // Convert heliocentric SSB to barycentric Sun.
            curr.gravitators[(int)BodyType.Sun] = new body_state_t(tt, -ssb.r, -ssb.v);
        }

        private body_state_t InternalBodyState(EquatorialCelestialBody body)
        {
            BodyType bodyType = body.BodyType;
            if (bodyType == BodyType.Sun || (bodyType >= BodyType.Mercury && bodyType <= BodyType.Neptune))
                return curr.gravitators[(int)bodyType];

            if (bodyType == BodyType.SSB)
                return new body_state_t(curr.time.tt, TerseVector.Zero, TerseVector.Zero);

            throw new InvalidBodyException(bodyType);
        }

        private void CalcBodyAccelerations()
        {
            // Calculate the gravitational acceleration experienced by the simulated bodies.
            const double EMB_GM = Constants.EARTH_GM + Constants.MOON_GM;
            for (int i = 0; i < curr.bodies.Length; ++i)
            {
                TerseVector a = TerseVector.Zero;
                a += Acceleration(curr.bodies[i].r, curr.gravitators[(int)BodyType.Sun].r, Constants.SUN_GM);
                a += Acceleration(curr.bodies[i].r, curr.gravitators[(int)BodyType.Mercury].r, Constants.MERCURY_GM);
                a += Acceleration(curr.bodies[i].r, curr.gravitators[(int)BodyType.Venus].r, Constants.VENUS_GM);
                a += Acceleration(curr.bodies[i].r, curr.gravitators[(int)BodyType.Earth].r, EMB_GM);
                a += Acceleration(curr.bodies[i].r, curr.gravitators[(int)BodyType.Mars].r, Constants.MARS_GM);
                a += Acceleration(curr.bodies[i].r, curr.gravitators[(int)BodyType.Jupiter].r, Constants.JUPITER_GM);
                a += Acceleration(curr.bodies[i].r, curr.gravitators[(int)BodyType.Saturn].r, Constants.SATURN_GM);
                a += Acceleration(curr.bodies[i].r, curr.gravitators[(int)BodyType.Uranus].r, Constants.URANUS_GM);
                a += Acceleration(curr.bodies[i].r, curr.gravitators[(int)BodyType.Neptune].r, Constants.NEPTUNE_GM);
                curr.bodies[i].a = a;
            }
        }

        private static TerseVector Acceleration(TerseVector smallPos, TerseVector majorPos, double gm)
        {
            double dx = majorPos.x - smallPos.x;
            double dy = majorPos.y - smallPos.y;
            double dz = majorPos.z - smallPos.z;
            double r2 = dx * dx + dy * dy + dz * dz;
            double pull = gm / (r2 * Math.Sqrt(r2));
            return new TerseVector(dx * pull, dy * pull, dz * pull);
        }

        private void Duplicate()
        {
            // Copy the current state into the previous state, so that both become the same moment in time.
            prev.time = curr.time;

            for (int i = 0; i < curr.gravitators.Length; ++i)
                prev.gravitators[i] = curr.gravitators[i];

            for (int i = 0; i < curr.bodies.Length; ++i)
                prev.bodies[i] = curr.bodies[i];
        }
    }
}
