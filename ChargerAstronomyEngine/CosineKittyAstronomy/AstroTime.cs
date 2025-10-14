using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace ChargerAstronomyEngine.CosineKittyAstronomy
{
    /// <summary>
    /// A date and time used for astronomical calculations.
    /// </summary>
    public class AstroTime
    {
        private static readonly DateTime Origin = new DateTime(2000, 1, 1, 12, 0, 0, DateTimeKind.Utc);

        /// <summary>
        /// UT1/UTC number of days since noon on January 1, 2000.
        /// </summary>
        /// <remarks>
        /// The floating point number of days of Universal Time since noon UTC January 1, 2000.
        /// Astronomy Engine approximates UTC and UT1 as being the same thing, although they are
        /// not exactly equivalent; UTC and UT1 can disagree by up to plus or minus 0.9 seconds.
        /// This approximation is sufficient for the accuracy requirements of Astronomy Engine.
        ///
        /// Universal Time Coordinate (UTC) is the international standard for legal and civil
        /// timekeeping and replaces the older Greenwich Mean Time (GMT) standard.
        /// UTC is kept in sync with unpredictable observed changes in the Earth's rotation
        /// by occasionally adding leap seconds as needed.
        ///
        /// UT1 is an idealized time scale based on observed rotation of the Earth, which
        /// gradually slows down in an unpredictable way over time, due to tidal drag by the Moon and Sun,
        /// large scale weather events like hurricanes, and internal seismic and convection effects.
        /// Conceptually, UT1 drifts from atomic time continuously and erratically, whereas UTC
        /// is adjusted by a scheduled whole number of leap seconds as needed.
        ///
        /// The value in `ut` is appropriate for any calculation involving the Earth's rotation,
        /// such as calculating rise/set times, culumination, and anything involving apparent
        /// sidereal time.
        ///
        /// Before the era of atomic timekeeping, days based on the Earth's rotation
        /// were often known as *mean solar days*.
        /// </remarks>
        public readonly double ut;

        /// <summary>
        /// Terrestrial Time days since noon on January 1, 2000.
        /// </summary>
        /// <remarks>
        /// Terrestrial Time is an atomic time scale defined as a number of days since noon on January 1, 2000.
        /// In this system, days are not based on Earth rotations, but instead by
        /// the number of elapsed [SI seconds](https://physics.nist.gov/cuu/Units/second.html)
        /// divided by 86400. Unlike `ut`, `tt` increases uniformly without adjustments
        /// for changes in the Earth's rotation.
        ///
        /// The value in `tt` is used for calculations of movements not involving the Earth's rotation,
        /// such as the orbits of planets around the Sun, or the Moon around the Earth.
        ///
        /// Historically, Terrestrial Time has also been known by the term *Ephemeris Time* (ET).
        /// </remarks>
        public readonly double tt;

        internal double psi = double.NaN;    // For internal use only. Used to optimize Earth tilt calculations.
        internal double eps = double.NaN;    // For internal use only. Used to optimize Earth tilt calculations.
        internal double st = double.NaN;     // For internal use only.  Lazy-caches sidereal time (Earth rotation).

        private AstroTime(double ut, double tt)
        {
            this.ut = ut;
            this.tt = tt;
        }

        /// <summary>
        /// Creates an `AstroTime` object from a Universal Time day value.
        /// </summary>
        /// <param name="ut">The number of days after the J2000 epoch.</param>
        public AstroTime(double ut)
            : this(ut, Astronomy.TerrestrialTime(ut))
        {
        }

        /// <summary>
        /// Creates an `AstroTime` object from a .NET `DateTime` object.
        /// </summary>
        /// <param name="d">The date and time to be converted to AstroTime format.</param>
        public AstroTime(DateTime d)
            : this((d.ToUniversalTime() - Origin).TotalDays)
        {
        }

        /// <summary>
        /// Creates an `AstroTime` object from a UTC year, month, day, hour, minute and second.
        /// </summary>
        /// <param name="year">The UTC year value.</param>
        /// <param name="month">The UTC month value 1..12.</param>
        /// <param name="day">The UTC day of the month 1..31.</param>
        /// <param name="hour">The UTC hour value 0..23.</param>
        /// <param name="minute">The UTC minute value 0..59.</param>
        /// <param name="second">The UTC second value [0, 60).</param>
        public AstroTime(int year, int month, int day, int hour, int minute, double second)
            : this(UniversalTimeFromCalendar(year, month, day, hour, minute, second))
        {
        }

        /// <summary>
        /// Creates an `AstroTime` object from a Terrestrial Time day value.
        /// </summary>
        /// <remarks>
        /// This function can be used in rare cases where a time must be based
        /// on Terrestrial Time (TT) rather than Universal Time (UT).
        /// Most developers will want to invoke `new AstroTime(ut)` with a universal time
        /// instead of this function, because usually time is based on civil time adjusted
        /// by leap seconds to match the Earth's rotation, rather than the uniformly
        /// flowing TT used to calculate solar system dynamics. In rare cases
        /// where the caller already knows TT, this function is provided to create
        /// an `AstroTime` value that can be passed to Astronomy Engine functions.
        /// </remarks>
        /// <param name="tt">The number of days after the J2000 epoch.</param>
        public static AstroTime FromTerrestrialTime(double tt)
        {
            return new AstroTime(Astronomy.UniversalTime(tt), tt);
        }

        /// <summary>
        /// Converts this object to .NET `DateTime` format.
        /// </summary>
        /// <returns>a UTC `DateTime` object for this `AstroTime` value.</returns>
        public DateTime ToUtcDateTime()
        {
            return Origin.AddDays(ut).ToUniversalTime();
        }

        /// <summary>
        /// Converts this object to our custom type #CalendarDateTime.
        /// </summary>
        /// <remarks>
        /// The .NET type `DateTime` can only represent years in the range 0000..9999.
        /// However, the Astronomy Engine type #CalendarDateTime can represent
        /// years in the range -999999..+999999. This is a time span of nearly 2 million years.
        /// This function converts this `AstroTime` object to an equivalent Gregorian calendar representation.
        /// </remarks>
        public CalendarDateTime ToCalendarDateTime() => new CalendarDateTime(ut);

        /// <summary>
        /// Converts this `AstroTime` to ISO 8601 format, expressed in UTC with millisecond resolution.
        /// </summary>
        /// <returns>Example: "2019-08-30T17:45:22.763Z".</returns>
        public override string ToString() => ToCalendarDateTime().ToString();

        private static Regex re = new Regex(
            @"^
            ([\+\-]?[0-9]{4,6})     # 1 : year  : should be 4-digit, or 6-digit with +/- prefix, but be flexible
            -(0[0-9]|1[012])        # 2 : month
            -([012][0-9]|3[01])     # 3 : day
            T([01][0-9]|2[0-3])     # 4 : hour
            :([0-5][0-9])           # 5 : minute
            (                       # 6
                :
                (                   # 7
                    [0-5][0-9]      # optional seconds
                    (\.[0-9]+)?     # optional fraction of a second
                )
            )?
            Z$                      # terminator",
            RegexOptions.Compiled | RegexOptions.CultureInvariant | RegexOptions.IgnorePatternWhitespace
        );

        /// <summary>
        /// Converts a string of the format returned by #AstroTime.ToString back into an `AstroTime`.
        /// </summary>
        /// <remarks>
        /// This function attempts to parse an ISO 8601 formatted date and time string
        /// into an `AstroTime` object.
        /// If the string is valid, sets `time` to a new object and returns `true`.
        /// If the string is not valid, sets `time` to `null` and returns `false`.
        /// </remarks>
        /// <param name="text">The string from which to parse a date and time.</param>
        /// <param name="time">On success, receives the date and time value. On failure, receives `null`.</param>
        public static bool TryParse(string text, out AstroTime time)
        {
            time = null;

            if (text == null)
                return false;

            Match m = re.Match(text);
            if (!m.Success)
                return false;

            if (!int.TryParse(m.Groups[1].Value, out int year))
                return false;

            if (!int.TryParse(m.Groups[2].Value, out int month))
                return false;

            if (!int.TryParse(m.Groups[3].Value, out int day))
                return false;

            if (!int.TryParse(m.Groups[4].Value, out int hour))
                return false;

            if (!int.TryParse(m.Groups[5].Value, out int minute))
                return false;

            double second = 0.0;
            string stext = m.Groups[7].Value;
            if (!string.IsNullOrEmpty(stext))
            {
                var styles = NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent;
                if (!double.TryParse(stext, styles, CultureInfo.InvariantCulture, out second))
                    return false;
            }

            time = new AstroTime(year, month, day, hour, minute, second);
            return true;
        }

        /// <summary>
        /// Calculates the sum or difference of an #AstroTime with a specified floating point number of days.
        /// </summary>
        /// <remarks>
        /// Sometimes we need to adjust a given #AstroTime value by a certain amount of time.
        /// This function adds the given real number of days in `days` to the date and time in this object.
        ///
        /// More precisely, the result's Universal Time field `ut` is exactly adjusted by `days` and
        /// the Terrestrial Time field `tt` is adjusted for the resulting UTC date and time,
        /// using a best-fit piecewise polynomial model devised by
        /// [Espenak and Meeus](https://eclipse.gsfc.nasa.gov/SEhelp/deltatpoly2004.html).
        /// </remarks>
        /// <param name="days">A floating point number of days by which to adjust `time`. May be negative, 0, or positive.</param>
        /// <returns>A date and time that is conceptually equal to `time + days`.</returns>
        public AstroTime AddDays(double days)
        {
            return new AstroTime(this.ut + days);
        }

        /// <summary>
        /// Nutation angle `psi`. Intended for unit testing only.
        /// </summary>
        public double Psi => psi;

        /// <summary>
        /// Nutation angle `eps`. Intended for unit testing only.
        /// </summary>
        public double Eps => eps;

        private static double UniversalTimeFromCalendar(int year, int month, int day, int hour, int minute, double second)
        {
            // This formula is adapted from NOVAS C 3.1 function julian_date(),
            // which in turn comes from Henry F. Fliegel & Thomas C. Van Flendern:
            // Communications of the ACM, Vol 11, No 10, October 1968, p. 657.
            // See: https://dl.acm.org/doi/pdf/10.1145/364096.364097
            //
            // [Don Cross - 2023-02-25] I modified the formula so that it will
            // work correctly with years as far back as -999999.

            long y = (long)year;
            long m = (long)month;
            long d = (long)day;
            long f = (14 - m) / 12;

            long y2000 = (
                (d - 365972956)
                + (1461 * (y + 1000000 - f)) / 4
                + (367 * (m - 2 + 12 * f)) / 12
                - (3 * ((y + 1000100 - f) / 100)) / 4
            );

            double ut = (y2000 - 0.5) + (hour / 24.0) + (minute / 1440.0) + (second / 86400.0);
            return ut;
        }
    }

}
