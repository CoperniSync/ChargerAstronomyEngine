using System.Numerics;
using ChargerAstronomyEngine.CosineKittyAstronomy;

namespace ChargerAstronomyShared.Domain.Coordinate
{

    public static class CoordinateTransform
    {

        public static Vector3 HorizontalToEquatorial(
            Vector3 horizontalDirection,
            AstroTime time,
            Observer observer,
            Astronomy astronomy)
        {
            horizontalDirection = Vector3.Normalize(horizontalDirection);

            var horVector = new AstroVector(
                horizontalDirection.X,
                horizontalDirection.Y,
                horizontalDirection.Z,
                time
            );

            RotationMatrix rotation = astronomy.Rotation_HOR_EQJ(time, observer);

            AstroVector eqjVector = astronomy.RotateVector(rotation, horVector);

            return new Vector3(
                (float)eqjVector.x,
                (float)eqjVector.y,
                (float)eqjVector.z
            );
        }


        public static Vector3 EquatorialToHorizontal(
            Vector3 equatorialDirection,
            AstroTime time,
            Observer observer,
            Astronomy astronomy)
        {
            equatorialDirection = Vector3.Normalize(equatorialDirection);

            var eqjVector = new AstroVector(
                equatorialDirection.X,
                equatorialDirection.Y,
                equatorialDirection.Z,
                time
            );

            RotationMatrix rotation = astronomy.Rotation_EQJ_HOR(time, observer);

            AstroVector horVector = astronomy.RotateVector(rotation, eqjVector);

            return new Vector3(
                (float)horVector.x,
                (float)horVector.y,
                (float)horVector.z
            );
        }

    }
}