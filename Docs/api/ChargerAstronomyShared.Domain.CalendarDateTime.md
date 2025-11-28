# <a id="ChargerAstronomyShared_Domain_CalendarDateTime"></a> Struct CalendarDateTime

Namespace: [ChargerAstronomyShared.Domain](ChargerAstronomyShared.Domain.md)  
Assembly: ChargerAstronomyShared.dll  

Represents a Gregorian calendar date and time within plus or minus 1 million years from the year 0.

```csharp
public struct CalendarDateTime
```

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Remarks

The C# standard type `System.DateTime` only allows years from 0001 to 9999.
However, the #AstroTime class can represent years in the range -999999 to +999999.
In order to support formatting dates with extreme year values in an extrapolated
Gregorian calendar, the `CalendarDateTime` class breaks out the components of
a date into separate fields.

## Constructors

### <a id="ChargerAstronomyShared_Domain_CalendarDateTime__ctor_System_Int32_System_Int32_System_Int32_System_Int32_System_Int32_System_Double_"></a> CalendarDateTime\(int, int, int, int, int, double\)

```csharp
public CalendarDateTime(int year, int month, int day, int hour, int minute, double second)
```

#### Parameters

`year` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`month` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`day` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`hour` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`minute` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`second` [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyShared_Domain_CalendarDateTime__ctor_System_Double_"></a> CalendarDateTime\(double\)

Convert a J2000 day value to a Gregorian calendar date.

```csharp
public CalendarDateTime(double ut)
```

#### Parameters

`ut` [double](https://learn.microsoft.com/dotnet/api/system.double)

The real-valued number of days since the J2000 epoch.

## Fields

### <a id="ChargerAstronomyShared_Domain_CalendarDateTime_day"></a> day

The day of the month in the reange 1..31.

```csharp
public int day
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="ChargerAstronomyShared_Domain_CalendarDateTime_hour"></a> hour

The hour in the range 0..23.

```csharp
public int hour
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="ChargerAstronomyShared_Domain_CalendarDateTime_minute"></a> minute

The minute in the range 0..59.

```csharp
public int minute
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="ChargerAstronomyShared_Domain_CalendarDateTime_month"></a> month

The calendar month in the range 1..12.

```csharp
public int month
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="ChargerAstronomyShared_Domain_CalendarDateTime_second"></a> second

The real-valued second in the half-open range [0, 60).

```csharp
public double second
```

#### Field Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyShared_Domain_CalendarDateTime_year"></a> year

The year value in the range -999999 to +999999.

```csharp
public int year
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="ChargerAstronomyShared_Domain_CalendarDateTime_ToString"></a> ToString\(\)

Converts this `CalendarDateTime` to ISO 8601 format, expressed in UTC with millisecond resolution.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

Example: "2019-08-30T17:45:22.763Z".

