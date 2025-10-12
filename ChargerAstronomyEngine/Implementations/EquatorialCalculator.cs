using System;
using System.Collections.Generic;
using System.Text;

namespace ChargerAstronomyEngine.Implementations
{

    using ChargerAstronomyShared.Contracts.Interfaces;
    using ChargerAstronomyShared.Contracts.Models;
    using ChargerAstronomyShared.Domain.Equatorial;
    using ChargerAstronomyShared.Domain.Heat;
    using ChargerAstronomyShared.Domain.Horizontal;
    using CosineKitty;

    public class EquatorialCalculator : IEquatorialCalculator
    {
        private Observer observer;
        private readonly Dictionary<string, Body> planets;                    
        private const double AUConversion = 63241.0771; 
        private HeatService heatService;
        private AstroTime defaultTime;

        public double Latitude { get { return observer.latitude; } }

        public double Longitude { get { return observer.longitude; } }

        public HeatService HeatService {
            get { return heatService; }
            set { heatService = value; }
        }

        public EquatorialCalculator(double latitude, double longitude, HeatService heatService)
        {
            observer = new Observer(latitude, longitude, 0);
            planets = new Dictionary<string, Body>
            {
                {Body.Mercury.ToString(), Body.Mercury},
                {Body.Venus.ToString(), Body.Venus},
                {Body.Mars.ToString(), Body.Mars},
                {Body.Jupiter.ToString(), Body.Jupiter},
                {Body.Saturn.ToString(), Body.Saturn},
                {Body.Uranus.ToString(), Body.Uranus},
                {Body.Neptune.ToString(), Body.Neptune}
            };
            this.heatService = heatService;
            defaultTime = new AstroTime(2000, 1, 1, 12, 0, 0);
        }   

        public HorizontalMoon CreateMoon()
        {
            Equatorial equ = Astronomy.Equator(Body.Moon, defaultTime, observer, EquatorEpoch.OfDate, Aberration.Corrected);
            Topocentric hor = Astronomy.Horizon(defaultTime, observer, equ.ra, equ.dec, Refraction.Normal);
           
            var illumination = Astronomy.Illumination(Body.Moon, defaultTime);
            var phase = Astronomy.MoonPhase(defaultTime);
            var eqBody = new EquatorialStar { Declination = equ.dec, RightAscension = equ.ra, Distance = equ.dist, Magnitude = illumination.mag };
           
            return new HorizontalMoon(eqBody);
        }

        public IEnumerable<HorizontalPlanet> CreatePlanets()
        {
            List<HorizontalPlanet> planetList = new List<HorizontalPlanet>();

            // Loop through the dictionary created in the constructor and create a HorizontalPlanet object for each of them.
            foreach (var body in planets)
            {
                Equatorial equ = Astronomy.Equator(body.Value, defaultTime, observer, EquatorEpoch.J2000, Aberration.Corrected);
                var eqBody = new EquatorialStar
                {
                    ProperName = body.ToString(),
                    RightAscension = equ.ra,
                    Declination = equ.dec,
                    Distance = equ.dist
                };
                var illumination = Astronomy.Illumination(body.Value, defaultTime);
                // The name is provided and used as they key to find the enumeration in the GetPositionOf method.
                planetList.Add(new HorizontalPlanet(body.Key, illumination.phase_angle, eqBody));
            }

            return planetList;
        }

        public HorizontalSun CreateSun()
        {
            Equatorial equ = Astronomy.Equator(Body.Sun, defaultTime, observer, EquatorEpoch.OfDate, Aberration.Corrected);
            Topocentric hor = Astronomy.Horizon(defaultTime, observer, equ.ra, equ.dec, Refraction.Normal);
           
            var illumination = Astronomy.Illumination(Body.Sun, defaultTime);
            var eqBody = new EquatorialStar { Declination = equ.dec, RightAscension= equ.ra, Distance = equ.dist, Magnitude= illumination.mag };
           
            return new HorizontalSun(eqBody);
        }

        public void SetLocation(double latitude, double longitude)
        {
            observer = new Observer(latitude, longitude, 150);
        }

        public void UpdateHeatedTiles(CalendarDate dateTime)
        {
           foreach(TileId tileId in heatService.GetHeatMap().TilesAbove(-1))
            {
                 // This is just an example method for now. will have to implement this for real in the future. 
            }
        }

        public void UpdatePositionOf(HorizontalStar hoBody, CalendarDate dateTime)
        {
            var eqBody = hoBody.EquatorialBody;
            Astronomy.DefineStar(Body.Star1, eqBody.RightAscension, eqBody.Declination, eqBody.Distance >= 1 ? eqBody.Distance : 1);
            
            AstroTime astroTime = new AstroTime(dateTime.year, dateTime.month, dateTime.day, dateTime.hour, dateTime.minute, dateTime.second);
            Equatorial eq = Astronomy.Equator(Body.Star1, astroTime, observer, EquatorEpoch.J2000, Aberration.Corrected);
            
            Topocentric hor = Astronomy.Horizon(astroTime, observer, eq.ra, eq.dec, Refraction.None);
          
            hoBody.Altitude = hor.altitude;
            hoBody.Azimuth = hor.azimuth;
        }
    }
}
