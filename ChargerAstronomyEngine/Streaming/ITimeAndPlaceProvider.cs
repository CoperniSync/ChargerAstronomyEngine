using System;
using System.Collections.Generic;
using System.Text;
using ChargerAstronomyEngine.CosineKittyAstronomy;
using ChargerAstronomyShared.Domain;

namespace ChargerAstronomyShared.Contracts.Models
{
    internal interface ITimeAndPlaceProvider
    {
        public void GetTimeAndPlace(out AstroTime time, out Observer location);

    }
}
