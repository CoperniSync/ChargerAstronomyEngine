using System;
using System.Collections.Generic;
using System.Text;
using ChargerAstronomyEngine.CosineKittyAstronomy;
using ChargerAstronomyShared.Domain;

namespace ChargerAstronomyShared.Contracts.Models
{

    /// <summary>
    /// Provides time and location information.
    /// </summary>
    internal interface ITimeAndPlaceProvider
    {

        /// <summary>
        /// The current time and location.
        /// </summary>
        /// <param name="time">The current time within the engine.</param>
        /// <param name="location">The current Observer location within the engine.</param>
        public void GetTimeAndPlace(out AstroTime time, out Observer location);

    }
}
