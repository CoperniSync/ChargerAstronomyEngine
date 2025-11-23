# <a id="ChargerAstronomyShared_Contracts_Models_SkyRegion"></a> Class SkyRegion

Namespace: [ChargerAstronomyShared.Contracts.Models](ChargerAstronomyShared.Contracts.Models.md)  
Assembly: ChargerAstronomyShared.dll  

A rectangular region of the sky defined by right ascension and declination.

```csharp
public sealed class SkyRegion
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[SkyRegion](ChargerAstronomyShared.Contracts.Models.SkyRegion.md)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="ChargerAstronomyShared_Contracts_Models_SkyRegion__ctor_System_Double_System_Double_System_Double_System_Double_"></a> SkyRegion\(double, double, double, double\)

Initializes a new <xref href="ChargerAstronomyShared.Contracts.Models.SkyRegion" data-throw-if-not-resolved="false"></xref>, a rectangular region of the sky defined by right ascension and declination.

```csharp
public SkyRegion(double raMinHours, double raMaxHours, double decMinDeg, double decMaxDeg)
```

#### Parameters

`raMinHours` [double](https://learn.microsoft.com/dotnet/api/system.double)

The minimum right ascension (RA) boundary, in hours. Must be in the range [0, 24).

`raMaxHours` [double](https://learn.microsoft.com/dotnet/api/system.double)

The maximum right ascension (RA) boundary, in hours. Must be in the range (0, 24] and greater than or equal
    to <code class="paramref">raMinHours</code>.

`decMinDeg` [double](https://learn.microsoft.com/dotnet/api/system.double)

The minimum declination (Dec) boundary, in degrees. Must be in the range [-90, 90].

`decMaxDeg` [double](https://learn.microsoft.com/dotnet/api/system.double)

The maximum declination (Dec) boundary, in degrees. Must be in the range [-90, 90] and greater than or equal
    to <code class="paramref">decMinDeg</code>.

#### Exceptions

 [ArgumentOutOfRangeException](https://learn.microsoft.com/dotnet/api/system.argumentoutofrangeexception)

Thrown if <code class="paramref">raMinHours</code> is not in the range [0, 24), or if <code class="paramref">raMaxHours</code> is
    not in the range (0, 24]. Thrown if <code class="paramref">decMinDeg</code> or <code class="paramref">decMaxDeg</code> is not in
    the range [-90, 90].

 [ArgumentException](https://learn.microsoft.com/dotnet/api/system.argumentexception)

Thrown if <code class="paramref">raMinHours</code> is greater than <code class="paramref">raMaxHours</code>, or if <code class="paramref">decMinDeg</code> is greater than <code class="paramref">decMaxDeg</code>.

## Properties

### <a id="ChargerAstronomyShared_Contracts_Models_SkyRegion_DecMaxDeg"></a> DecMaxDeg

Declination maximum in degrees [-90,+90].

```csharp
public double DecMaxDeg { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyShared_Contracts_Models_SkyRegion_DecMinDeg"></a> DecMinDeg

Declination minimum in degrees [-90,+90].

```csharp
public double DecMinDeg { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyShared_Contracts_Models_SkyRegion_RaMaxHours"></a> RaMaxHours

Right ascension maximum in hours (0,24].

```csharp
public double RaMaxHours { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

### <a id="ChargerAstronomyShared_Contracts_Models_SkyRegion_RaMinHours"></a> RaMinHours

Right ascension minimum in hours [0,24).

```csharp
public double RaMinHours { get; }
```

#### Property Value

 [double](https://learn.microsoft.com/dotnet/api/system.double)

