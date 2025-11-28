//using ChargerAstronomyEngine.Data.Star;
//using ChargerAstronomyEngine.Streaming;
//using ChargerAstronomyShared.Contracts.Models;
//using ChargerAstronomyShared.Domain.Equatorial;
//using ChargerAstronomyShared.Domain.Horizontal;
//using ChargerAstronomyShared.Domain.Index;
//using ChargerAstronomyShared.Domain.SpatialIndex;
//using ChargerAstronomyShared.Domain.Heat;
//using FluentAssertions;
//using System;
//using System.ComponentModel.DataAnnotations;
//using System.Numerics;
//using Xunit;
//using ChargerAstronomyShared.Domain;
//using ChargerAstronomyEngine.CosineKittyAstronomy;
//using ChargerAstronomyEngine.CosineKittyAstronomy.Enums;
//using ChargerAstronomyEngine.Domain.Heat;

//namespace tests
//{
//    public class EquatorialCalculationTests
//    {
//        public EquatorialCalculationTests()
//        {
//        }

//        [Fact]
//        public void UpdatePlanetWorks()
//        {
//            /// Act
            
//            // Build a calculator
//            var tileIndex = new IcosphereTileIndex();
//            var heatServ = new HeatService(new HeatMap(new HeatConfig()), tileIndex);
//            var starIndex = new SpatialStarIndex<TestStar>(tileIndex);
//            var calculator = new EquatorialCalculator<TestStar>(heatServ, starIndex);

//            // Set up observer and location inputs for calculation
//            var astro = new Astronomy();
//            var obs = new Observer(52.5200, 13.4050, 34); // Berlin, Germany (copilot chose this lol)
//            var time = new CalendarDateTime(2024, 6, 1, 0, 0, 0);
//            var astroTime = new AstroTime(time);

//            var mars = new HorizontalPlanet(BodyType.Mars, BodyType.Mars.ToString());
//            var startingAlt = mars.Altitude;

//            /// Act
            
//            // Call the calculator method
//            calculator.UpdateTimeAndLocation(time, obs);
//            calculator.UpdatePositionOf(mars);

//            /// Assert

//            // Call the Astronomy library directly to get expected values
//            var goodEqu = astro.Equator(
//                mars,
//                astroTime,
//                obs,
//                EquatorEpoch.J2000,
//                Aberration.Corrected
//            );
//            var goodTop = astro.Horizon(astroTime, obs, goodEqu, Refraction.Normal);

//            mars.Altitude.Should().BeApproximately(goodTop.altitude, 1e-5, "Altitude should match calculated value.");
//            mars.Altitude.Should().NotBe(startingAlt, "Altitude should have changed from starting value.");
//        }


//        private class TestStar : IHorizontal
//        {

//            public TestStar(EquatorialStar equatorialStar)
//            {
//                HorizontalBody = new HorizontalStar(equatorialStar);
//            }

//            public override bool Equals(object? obj)
//            {
//                return obj is TestStar objTest && objTest.HorizontalBody is HorizontalStar objHor
//                    && this.HorizontalBody is HorizontalStar thisHor && thisHor.StarId == objHor.StarId;
//            }

//            public void SetState(bool visible)
//            {
//                throw new NotImplementedException();
//            }

//            public void UpdatePosition()
//            {
//                throw new NotImplementedException();
//            }

//            public HorizontalBody HorizontalBody { get; }
//        }
//    }
//}
