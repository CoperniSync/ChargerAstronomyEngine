using ChargerAstronomyEngine.CosineKittyAstronomy.Enums;
using ChargerAstronomyShared.Domain.Equatorial;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChargerAstronomyEngine.CosineKittyAstronomy
{
    internal struct BodyPosition : IPositionFunction
    {
        private Astronomy astro;
        private EquatorialCelestialBody observerBody;
        private EquatorialCelestialBody targetBody;
        private Aberration aberration;
        private AstroVector observerPos;    // used only when aberration == Aberration.None

        public BodyPosition(Astronomy astro, EquatorialCelestialBody observerBody, EquatorialCelestialBody targetBody, Aberration aberration, AstroVector observerPos)
        {
            this.astro = astro;
            this.observerBody = observerBody;
            this.targetBody = targetBody;
            this.aberration = aberration;
            this.observerPos = observerPos;
        }



        public AstroVector Position(AstroTime time)
        {
            if (aberration == Aberration.None)
            {
                // No aberration, so use the pre-calculated initial position of
                // the observer body that is already stored in `observerPos`.
                // To avoid an exception in the subtraction below, patch the time.
                observerPos.t = time;
            }
            else
            {
                // The following discussion is worded with the observer body being the Earth,
                // which is often the case. However, the same reasoning applies to any observer body
                // without loss of generality.
                //
                // To include aberration, make a good first-order approximation
                // by backdating the Earth's position also.
                // This is confusing, but it works for objects within the Solar System
                // because the distance the Earth moves in that small amount of light
                // travel time (a few minutes to a few hours) is well approximated
                // by a line segment that substends the angle seen from the remote
                // body viewing Earth. That angle is pretty close to the aberration
                // angle of the moving Earth viewing the remote body.
                // In other words, both of the following approximate the aberration angle:
                //     (transverse distance Earth moves) / (distance to body)
                //     (transverse speed of Earth) / (speed of light).

                observerPos = astro.HelioVector(observerBody, time);
            }

            // Subtract the bodies' heliocentric positions to obtain a relative position vector.
            return astro.HelioVector(targetBody, time) - observerPos;
        }
    }
}
