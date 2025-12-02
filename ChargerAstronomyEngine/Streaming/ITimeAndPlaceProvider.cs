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
        /// <param name="time"></param>
        /// <param name="location"></param>
        public void GetTimeAndPlace(out AstroTime time, out Observer location);

    }
}
