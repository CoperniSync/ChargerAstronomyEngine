using System;
using System.Collections.Generic;
using System.Text;

namespace ChargerAstronomyEngine.CosineKittyAstronomy
{
    /// <summary>
    /// Information about a body's rotation axis at a given time.
    /// </summary>
    /// <remarks>
    /// This structure is returned by #Astronomy.RotationAxis to report
    /// the orientation of a body's rotation axis at a given moment in time.
    /// The axis is specified by the direction in space that the body's north pole
    /// points, using angular equatorial coordinates in the J2000 system (EQJ).
    ///
    /// Thus `ra` is the right ascension, and `dec` is the declination, of the
    /// body's north pole vector at the given moment in time. The north pole
    /// of a body is defined as the pole that lies on the north side of the
    /// [Solar System's invariable plane](https://en.wikipedia.org/wiki/Invariable_plane),
    /// regardless of the body's direction of rotation.
    ///
    /// The `spin` field indicates the angular position of a prime meridian
    /// arbitrarily recommended for the body by the International Astronomical
    /// Union (IAU).
    ///
    /// The fields `ra`, `dec`, and `spin` correspond to the variables
    /// α0, δ0, and W, respectively, from
    /// [Report of the IAU Working Group on Cartographic Coordinates and Rotational Elements: 2015](https://astropedia.astrogeology.usgs.gov/download/Docs/WGCCRE/WGCCRE2015reprint.pdf).
    ///
    /// The field `north` is a unit vector pointing in the direction of the body's north pole.
    /// It is expressed in the J2000 mean equator system (EQJ).
    /// </remarks>
    public struct AxisInfo
    {
        /// <summary>The J2000 right ascension of the body's north pole direction, in sidereal hours.</summary>
        public double ra;

        /// <summary>The J2000 declination of the body's north pole direction, in degrees.</summary>
        public double dec;

        /// <summary>Rotation angle of the body's prime meridian, in degrees.</summary>
        public double spin;

        /// <summary>A J2000 dimensionless unit vector pointing in the direction of the body's north pole.</summary>
        public AstroVector north;
    }
}
