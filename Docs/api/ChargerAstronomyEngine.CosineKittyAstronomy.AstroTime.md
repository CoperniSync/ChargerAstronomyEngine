# <a id="ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime"></a> Class AstroTime

Namespace: [ChargerAstronomyEngine.CosineKittyAstronomy](ChargerAstronomyEngine.CosineKittyAstronomy.md)  
Assembly: ChargerAstronomyEngine.dll  

A date and time used for astronomical calculations.

```csharp
public class AstroTime
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime__ctor_System_Double_"></a> AstroTime\(double\)

Creates an `AstroTime` object from a Universal Time day value.

```csharp
public AstroTime(double ut)
```

#### Parameters

`ut` [double](https://learn.microsoft.com/dotnet/api/system.double)

The number of days after the J2000 epoch.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime__ctor_System_DateTime_"></a> AstroTime\(DateTime\)

Creates an `AstroTime` object from a .NET `DateTime` object.

```csharp
public AstroTime(DateTime d)
```

#### Parameters

`d` [DateTime](https://learn.microsoft.com/dotnet/api/system.datetime)

The date and time to be converted to AstroTime format.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime__ctor_System_Int32_System_Int32_System_Int32_System_Int32_System_Int32_System_Double_"></a> AstroTime\(int, int, int, int, int, double\)

Creates an `AstroTime` object from a UTC year, month, day, hour, minute and second.

```csharp
public AstroTime(int year, int month, int day, int hour, int minute, double second)
```

#### Parameters

`year` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The UTC year value.

`month` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The UTC month value 1..12.

`day` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The UTC day of the month 1..31.

`hour` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The UTC hour value 0..23.

`minute` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The UTC minute value 0..59.

`second` [double](https://learn.microsoft.com/dotnet/api/system.double)

The UTC second value [0, 60).

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime__ctor_ChargerAstronomyShared_Domain_CalendarDateTime_"></a> AstroTime\(CalendarDateTime\)

```csharp
public AstroTime(CalendarDateTime cdt)
```

#### Parameters

`cdt` [CalendarDateTime](ChargerAstronomyShared.Domain.CalendarDateTime.md)

## Fields

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_tt"></a> tt

Terrestrial Time days since noon on January 1, 2000.

```csharp
public readonly double tt
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

#### Remarks

Terrestrial Time is an atomic time scale defined as a number of days since noon on January 1, 2000.
In this system, days are not based on Earth rotations, but instead by
the number of elapsed [SI seconds](https://physics.nist.gov/cuu/Units/second.html)
divided by 86400. Unlike `ut`, `tt` increases uniformly without adjustments
for changes in the Earth's rotation.

The value in `tt` is used for calculations of movements not involving the Earth's rotation,
such as the orbits of planets around the Sun, or the Moon around the Earth.

Historically, Terrestrial Time has also been known by the term *Ephemeris Time* (ET).

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_ut"></a> ut

UT1/UTC number of days since noon on January 1, 2000.

```csharp
public readonly double ut
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

#### Remarks

The floating point number of days of Universal Time since noon UTC January 1, 2000.
Astronomy Engine approximates UTC and UT1 as being the same thing, although they are
not exactly equivalent; UTC and UT1 can disagree by up to plus or minus 0.9 seconds.
This approximation is sufficient for the accuracy requirements of Astronomy Engine.

Universal Time Coordinate (UTC) is the international standard for legal and civil
timekeeping and replaces the older Greenwich Mean Time (GMT) standard.
UTC is kept in sync with unpredictable observed changes in the Earth's rotation
by occasionally adding leap seconds as needed.

UT1 is an idealized time scale based on observed rotation of the Earth, which
gradually slows down in an unpredictable way over time, due to tidal drag by the Moon and Sun,
large scale weather events like hurricanes, and internal seismic and convection effects.
Conceptually, UT1 drifts from atomic time continuously and erratically, whereas UTC
is adjusted by a scheduled whole number of leap seconds as needed.

The value in `ut` is appropriate for any calculation involving the Earth's rotation,
such as calculating rise/set times, culumination, and anything involving apparent
sidereal time.

Before the era of atomic timekeeping, days based on the Earth's rotation
were often known as *mean solar days*.

## Properties

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_Eps"></a> Eps

Nutation angle `eps`. Intended for unit testing only.

```csharp
public double Eps { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_Psi"></a> Psi

Nutation angle `psi`. Intended for unit testing only.

```csharp
public double Psi { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

## Methods

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_AddDays_System_Double_"></a> AddDays\(double\)

Calculates the sum or difference of an #AstroTime with a specified floating point number of days.

```csharp
public AstroTime AddDays(double days)
```

#### Parameters

`days` [double](https://learn.microsoft.com/dotnet/api/system.double)

A floating point number of days by which to adjust `time`. May be negative, 0, or positive.

#### Returns

 [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

A date and time that is conceptually equal to `time + days`.

#### Remarks

Sometimes we need to adjust a given #AstroTime value by a certain amount of time.
This function adds the given real number of days in `days` to the date and time in this object.

More precisely, the result's Universal Time field `ut` is exactly adjusted by `days` and
the Terrestrial Time field `tt` is adjusted for the resulting UTC date and time,
using a best-fit piecewise polynomial model devised by
[Espenak and Meeus](https://eclipse.gsfc.nasa.gov/SEhelp/deltatpoly2004.html).

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_FromTerrestrialTime_System_Double_"></a> FromTerrestrialTime\(double\)

Creates an `AstroTime` object from a Terrestrial Time day value.

```csharp
public static AstroTime FromTerrestrialTime(double tt)
```

#### Parameters

`tt` [double](https://learn.microsoft.com/dotnet/api/system.double)

The number of days after the J2000 epoch.

#### Returns

 [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

#### Remarks

This function can be used in rare cases where a time must be based
on Terrestrial Time (TT) rather than Universal Time (UT).
Most developers will want to invoke `new AstroTime(ut)` with a universal time
instead of this function, because usually time is based on civil time adjusted
by leap seconds to match the Earth's rotation, rather than the uniformly
flowing TT used to calculate solar system dynamics. In rare cases
where the caller already knows TT, this function is provided to create
an `AstroTime` value that can be passed to Astronomy Engine functions.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_ToCalendarDateTime"></a> ToCalendarDateTime\(\)

Converts this object to our custom type #CalendarDateTime.

```csharp
public CalendarDateTime ToCalendarDateTime()
```

#### Returns

 [CalendarDateTime](ChargerAstronomyShared.Domain.CalendarDateTime.md)

#### Remarks

The .NET type `DateTime` can only represent years in the range 0000..9999.
However, the Astronomy Engine type #CalendarDateTime can represent
years in the range -999999..+999999. This is a time span of nearly 2 million years.
This function converts this `AstroTime` object to an equivalent Gregorian calendar representation.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_ToString"></a> ToString\(\)

Converts this `AstroTime` to ISO 8601 format, expressed in UTC with millisecond resolution.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

Example: "2019-08-30T17:45:22.763Z".

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_ToUtcDateTime"></a> ToUtcDateTime\(\)

Converts this object to .NET `DateTime` format.

```csharp
public DateTime ToUtcDateTime()
```

#### Returns

 [DateTime](https://learn.microsoft.com/dotnet/api/system.datetime)

a UTC `DateTime` object for this `AstroTime` value.

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_TryParse_System_String_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime__"></a> TryParse\(string, out AstroTime\)

Converts a string of the format returned by #AstroTime.ToString back into an `AstroTime`.

```csharp
public static bool TryParse(string text, out AstroTime time)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string)

The string from which to parse a date and time.

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

On success, receives the date and time value. On failure, receives `null`.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Remarks

This function attempts to parse an ISO 8601 formatted date and time string
into an `AstroTime` object.
If the string is valid, sets `time` to a new object and returns `true`.
If the string is not valid, sets `time` to `null` and returns `false`.

