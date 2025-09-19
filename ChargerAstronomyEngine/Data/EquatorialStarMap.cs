using System.Globalization;
using ChargerAstronomyShared.Domain.Equatorial;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;

public sealed class EquatorialStarMap : ClassMap<EquatorialStar>
{
    public EquatorialStarMap()
    {
        //ChargerAstronomyShared/Domain/Equatorial/EquatorialStar for why certain props are optional.

        Map(x => x.StarId).Name("StarID");
        Map(x => x.HipparcosId).Name("Hip");
        Map(x => x.HenryDraperId).Name("HD").Optional();
        Map(x => x.HarvardRevisedId).Name("HR").Optional();
        Map(x => x.GlieseId).Name("Gliese").Optional();
        Map(x => x.ProperName).Name("ProperName").Optional();

        Map(x => x.BayerFlamsteedDesignation).Name("BayerFlamsteed").Optional();

        Map(x => x.RightAscension).Name("RA").TypeConverterOption.CultureInfo(CultureInfo.InvariantCulture);
        Map(x => x.Declination).Name("Dec").TypeConverterOption.CultureInfo(CultureInfo.InvariantCulture);

        Map(x => x.Magnitude).Name("Mag").TypeConverterOption.CultureInfo(CultureInfo.InvariantCulture).Optional();
        Map(x => x.AbsoluteMagnitude).Name("AbsMag").TypeConverterOption.CultureInfo(CultureInfo.InvariantCulture).Optional();
        Map(x => x.Spectrum).Name("Spectrum").Optional();
        Map(x => x.ColorIndex).Name("ColorIndex").TypeConverterOption.CultureInfo(CultureInfo.InvariantCulture).Optional();
        Map(m => m.Distance).TypeConverter(new ParsecToLightyearConverter()).Optional();

        // These are not in the csv, so this doenst actually do anything.
        // I have this here incase we get a csv that adds these columns.
        Map(x => x.ParallaxMas).Name("parallax").Optional();
        Map(x => x.ProperMotionRaMasPerYear).Name("pmra").Optional();
        Map(x => x.ProperMotionDecMasPerYear).Name("pmdec").Optional();

    }

    /// <summary>
    /// A custom type converter to convert parsecs to light years (the distance data in the repository is in Parsecs... yes... that's actually a real thing).
    /// </summary>
    private class ParsecToLightyearConverter : DefaultTypeConverter
    {
        private const double conversionFactor = 3.262;
        public override object? ConvertFromString(string? text, IReaderRow row, MemberMapData memberMapData)
        {
            return double.TryParse(text, out var value) && value > 0 ? value * conversionFactor : 1;
        }
    }
}
