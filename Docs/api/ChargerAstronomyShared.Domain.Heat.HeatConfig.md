# <a id="ChargerAstronomyShared_Domain_Heat_HeatConfig"></a> Class HeatConfig

Namespace: [ChargerAstronomyShared.Domain.Heat](ChargerAstronomyShared.Domain.Heat.md)  
Assembly: ChargerAstronomyShared.dll  

Represents the configuration settings for heat-related calculations, including decay rate, clamping limits, and
precision thresholds.

```csharp
public sealed class HeatConfig
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[HeatConfig](ChargerAstronomyShared.Domain.Heat.HeatConfig.md)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Properties

### <a id="ChargerAstronomyShared_Domain_Heat_HeatConfig_AreaWeighted"></a> AreaWeighted

Indicates whether area weighting is applied in calculations.

```csharp
public bool AreaWeighted { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="ChargerAstronomyShared_Domain_Heat_HeatConfig_ClampMax"></a> ClampMax

The maximum heat value.

```csharp
public float ClampMax { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="ChargerAstronomyShared_Domain_Heat_HeatConfig_ClampMin"></a> ClampMin

The minimum heat value.

```csharp
public float ClampMin { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="ChargerAstronomyShared_Domain_Heat_HeatConfig_DecayPerSecond"></a> DecayPerSecond

The rate at which heat decays per second.

```csharp
public float DecayPerSecond { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="ChargerAstronomyShared_Domain_Heat_HeatConfig_Epsilon"></a> Epsilon

Gets the small positive value used as a tolerance for floating-point comparisons.

```csharp
public float Epsilon { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Remarks

No need for setters, this is a constant.

### <a id="ChargerAstronomyShared_Domain_Heat_HeatConfig_UseInstantDecay"></a> UseInstantDecay

Indicates whether instant decay is applied.

```csharp
public bool UseInstantDecay { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

