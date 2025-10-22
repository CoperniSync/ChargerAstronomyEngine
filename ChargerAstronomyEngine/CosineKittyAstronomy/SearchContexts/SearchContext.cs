using System;
using System.Collections.Generic;
using System.Text;

namespace ChargerAstronomyEngine.CosineKittyAstronomy.SearchContexts
{
    /// <summary>
    /// Represents a function whose ascending root is to be found.
    /// See #Astronomy.Search.
    /// </summary>
    public abstract class SearchContext
    {
        /// <summary>
        /// Evaluates the function at a given time
        /// </summary>
        /// <param name="time">The time at which to evaluate the function.</param>
        /// <returns>The floating point value of the function at the specified time.</returns>
        public abstract double Eval(Astronomy astro, AstroTime time);
    }
}
