using System;
using System.Collections.Generic;
using System.Text;

namespace ChargerAstronomyEngine.CosineKittyAstronomy
{
    /// <summary>
    /// A function for which to solve a light-travel time problem.
    /// </summary>
    /// <remarks>
    /// The function #Astronomy.CorrectLightTravel solves a generalized
    /// problem of deducing how far in the past light must have left
    /// a target object to be seen by an observer at a specified time.
    /// This interface expresses an arbitrary position vector as
    /// function of time that is passed to #Astronomy.CorrectLightTravel.
    /// </remarks>
    public interface IPositionFunction
    {
        /// <summary>
        /// Returns a relative position vector for a given time.
        /// </summary>
        /// <param name="time">The time at which to evaluate a relative position vector.</param>
        AstroVector Position(AstroTime time);
    }
}
