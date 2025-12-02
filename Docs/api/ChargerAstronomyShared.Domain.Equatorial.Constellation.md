# <a id="ChargerAstronomyShared_Domain_Equatorial_Constellation"></a> Class Constellation

Namespace: [ChargerAstronomyShared.Domain.Equatorial](ChargerAstronomyShared.Domain.Equatorial.md)  
Assembly: ChargerAstronomyShared.dll  

A graph representation of a constellation.

```csharp
public sealed class Constellation
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Constellation](ChargerAstronomyShared.Domain.Equatorial.Constellation.md)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="ChargerAstronomyShared_Domain_Equatorial_Constellation__ctor_System_String_System_String_System_String_"></a> Constellation\(string, string, string?\)

Returns a new object

```csharp
public Constellation(string Id, string name, string? nativeName)
```

#### Parameters

`Id` [string](https://learn.microsoft.com/dotnet/api/system.string)

The unique name of the constellation

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

The English name of the constellation

`nativeName` [string](https://learn.microsoft.com/dotnet/api/system.string)?

The native name of the constellation

## Properties

### <a id="ChargerAstronomyShared_Domain_Equatorial_Constellation_ConstellationId"></a> ConstellationId

The id of the constellation

```csharp
public string? ConstellationId { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="ChargerAstronomyShared_Domain_Equatorial_Constellation_ConstellationLines"></a> ConstellationLines

A list of vertices representing edges in the graph (each vertex is the HipparcosId of a star)

```csharp
public IEnumerable<Tuple<int, int>> ConstellationLines { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Tuple](https://learn.microsoft.com/dotnet/api/system.tuple\-2)<[int](https://learn.microsoft.com/dotnet/api/system.int32), [int](https://learn.microsoft.com/dotnet/api/system.int32)\>\>

### <a id="ChargerAstronomyShared_Domain_Equatorial_Constellation_ConstellationName"></a> ConstellationName

The English(native) name of the constellation

```csharp
public string? ConstellationName { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

