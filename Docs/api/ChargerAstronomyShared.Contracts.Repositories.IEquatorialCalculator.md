# <a id="ChargerAstronomyShared_Contracts_Repositories_IEquatorialCalculator"></a> Interface IEquatorialCalculator

Namespace: [ChargerAstronomyShared.Contracts.Repositories](ChargerAstronomyShared.Contracts.Repositories.md)  
Assembly: ChargerAstronomyShared.dll  

Converts a <xref href="ChargerAstronomyShared.Domain.Horizontal.HorizontalBody" data-throw-if-not-resolved="false"></xref> to a {T} object
Author: Josh Johner
Created: SPR 2025

```csharp
public interface IEquatorialCalculator
```

## Methods

### <a id="ChargerAstronomyShared_Contracts_Repositories_IEquatorialCalculator_IncrementTime_System_Single_"></a> IncrementTime\(float\)

Increments the time of the internal universal time used to perform calculations.

```csharp
void IncrementTime(float deltaTime)
```

#### Parameters

`deltaTime` [float](https://learn.microsoft.com/dotnet/api/system.single)

The amount of time to increase by, in seconds.

### <a id="ChargerAstronomyShared_Contracts_Repositories_IEquatorialCalculator_UpdateLocation_ChargerAstronomyShared_Domain_Observer_"></a> UpdateLocation\(Observer\)

Calculates and updates the position of an <xref href="ChargerAstronomyShared.Domain.Observer" data-throw-if-not-resolved="false"></xref>

```csharp
void UpdateLocation(Observer newLocation)
```

#### Parameters

`newLocation` [Observer](ChargerAstronomyShared.Domain.Observer.md)

The new location for the <xref href="ChargerAstronomyShared.Domain.Observer" data-throw-if-not-resolved="false"></xref> to update to.

### <a id="ChargerAstronomyShared_Contracts_Repositories_IEquatorialCalculator_UpdateTime_ChargerAstronomyShared_Domain_CalendarDateTime_"></a> UpdateTime\(CalendarDateTime\)

Updates the internal universal time used for calculations.

```csharp
void UpdateTime(CalendarDateTime newTime)
```

#### Parameters

`newTime` [CalendarDateTime](ChargerAstronomyShared.Domain.CalendarDateTime.md)

The new universal time.

### <a id="ChargerAstronomyShared_Contracts_Repositories_IEquatorialCalculator_UpdateTimeAndLocation_ChargerAstronomyShared_Domain_CalendarDateTime_ChargerAstronomyShared_Domain_Observer_"></a> UpdateTimeAndLocation\(CalendarDateTime, Observer\)

Updates the internal universal time and <xref href="ChargerAstronomyShared.Domain.Observer" data-throw-if-not-resolved="false"></xref> location for calculations.

```csharp
void UpdateTimeAndLocation(CalendarDateTime newTime, Observer newLocation)
```

#### Parameters

`newTime` [CalendarDateTime](ChargerAstronomyShared.Domain.CalendarDateTime.md)

The new universal time.

`newLocation` [Observer](ChargerAstronomyShared.Domain.Observer.md)

The new location for the <xref href="ChargerAstronomyShared.Domain.Observer" data-throw-if-not-resolved="false"></xref> to update to.

