using ChargerAstronomyEngine.Data.Star;
using ChargerAstronomyShared.Domain.Equatorial;
using ChargerAstronomyShared.Domain.Horizontal;
using CosineKitty;
using FluentAssertions;

namespace tests
{
    public class AstronomyTest
    {
        CsvStarRepository repo;
        public AstronomyTest()
        {
            repo = new CsvStarRepository("AllStars.csv");
        }

        [Fact]
        public void VerifyDateAndTime()
        {
            var cdt = DateTime.Now;
            var calendarDateTime = new ChargerAstronomyShared.Domain.CalendarDateTime(cdt.Year, cdt.Month, cdt.Minute, cdt.Hour, cdt.Minute, cdt.Second);
            var astroTime = new ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime(calendarDateTime);
            astroTime.ToCalendarDateTime().ToString().Should().Be(calendarDateTime.ToString());
        }



        [Fact]
        public void GetStarLocation()
        {
            var lighyears = 25.304;
            var starId = 65795;
            var cdt = DateTime.Now;
            var caCDT = new ChargerAstronomyShared.Domain.CalendarDateTime(cdt.Year, cdt.Month, cdt.Minute, cdt.Hour, cdt.Minute, cdt.Second);
            var caAstro = new ChargerAstronomyEngine.CosineKittyAstronomy.Astronomy();
            var caObs = new ChargerAstronomyShared.Domain.Observer(34.72985, -86.58590, 193);
            var csObs = new Observer(caObs.latitude, caObs.longitude, caObs.height);

            var star = new HorizontalStar(new EquatorialStar { RightAscension = 18.61560722 , Declination = 38.78299311 , Distance = 25.304 });
            star.RightAscension = 18.61560722;
            star.Declination = 38.78299311;
            star.Distance = 1599901.6;

            CosineKitty.Astronomy.DefineStar(Body.Star1, star.RightAscension, star.Declination, lighyears);

            var caAstroTime = new ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime(caCDT);
            var csAstroTime = new CosineKitty.AstroTime(caAstroTime.ut);

            var cseq = CosineKitty.Astronomy.Equator(
                Body.Star1, 
                csAstroTime, 
                csObs,
                CosineKitty.EquatorEpoch.OfDate,
                CosineKitty.Aberration.Corrected);



            var eq = caAstro.Equator(
                star, 
                caAstroTime, 
                caObs, 
                ChargerAstronomyEngine.CosineKittyAstronomy.Enums.EquatorEpoch.OfDate, 
                ChargerAstronomyEngine.CosineKittyAstronomy.Enums.Aberration.Corrected);

            cseq.ra.Should().BeApproximately(eq.ra, 0.0001);
            cseq.dec.Should().BeApproximately(eq.dec, 0.0001);

            var hr = caAstro.Horizon(caAstroTime, caObs, eq, ChargerAstronomyEngine.CosineKittyAstronomy.Enums.Refraction.Normal);
            var chr = CosineKitty.Astronomy.Horizon(
                csAstroTime,
                csObs,
                cseq.ra,
                cseq.dec,
                CosineKitty.Refraction.Normal);

            chr.ra.Should().BeApproximately(hr.ra, .0001);
            chr.dec.Should().BeApproximately(hr.dec, .0001);

            chr.altitude.Should().BeApproximately(hr.altitude, .0001);
            chr.azimuth.Should().BeApproximately(hr.azimuth, .0001);
        }
    }
}
