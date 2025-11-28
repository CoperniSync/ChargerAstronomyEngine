# <a id="ChargerAstronomyShared_Contracts_Models_TileId"></a> Class TileId

Namespace: [ChargerAstronomyShared.Contracts.Models](ChargerAstronomyShared.Contracts.Models.md)  
Assembly: ChargerAstronomyShared.dll  

Represents a unique identifier for a tile.

```csharp
public class TileId : IEquatable<TileId>
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[TileId](ChargerAstronomyShared.Contracts.Models.TileId.md)

#### Implements

[IEquatable<TileId\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="ChargerAstronomyShared_Contracts_Models_TileId__ctor_System_Int32_"></a> TileId\(int\)

Initializes a new <xref href="ChargerAstronomyShared.Contracts.Models.TileId" data-throw-if-not-resolved="false"></xref> with the specified index.

```csharp
public TileId(int index)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

The index representing the unique identifier of the tile.

## Fields

### <a id="ChargerAstronomyShared_Contracts_Models_TileId_Index"></a> Index

The unique integer identifier of a tile.

```csharp
public readonly int Index
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="ChargerAstronomyShared_Contracts_Models_TileId_active"></a> active

Indicates whether the object is active.

```csharp
public bool active
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="ChargerAstronomyShared_Contracts_Models_TileId_Equals_ChargerAstronomyShared_Contracts_Models_TileId_"></a> Equals\(TileId\)

Determines whether the current <xref href="ChargerAstronomyShared.Contracts.Models.TileId" data-throw-if-not-resolved="false"></xref> is equal to the specified <xref href="ChargerAstronomyShared.Contracts.Models.TileId" data-throw-if-not-resolved="false"></xref>.

```csharp
public bool Equals(TileId tileId)
```

#### Parameters

`tileId` [TileId](ChargerAstronomyShared.Contracts.Models.TileId.md)

The <xref href="ChargerAstronomyShared.Contracts.Models.TileId" data-throw-if-not-resolved="false"></xref> to compare with the current instance.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

<a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">true</a> if the specified <xref href="ChargerAstronomyShared.Contracts.Models.TileId" data-throw-if-not-resolved="false"></xref> has the same <xref href="ChargerAstronomyShared.Contracts.Models.TileId.Index" data-throw-if-not-resolved="false"></xref> value as the
    current instance; otherwise, <a href="https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/bool">false</a>.

### <a id="ChargerAstronomyShared_Contracts_Models_TileId_Equals_System_Object_"></a> Equals\(object\)

Determines whether the specified object is equal to the current <xref href="ChargerAstronomyShared.Contracts.Models.TileId" data-throw-if-not-resolved="false"></xref> instance.

```csharp
public override bool Equals(object obj)
```

#### Parameters

`obj` [object](https://learn.microsoft.com/dotnet/api/system.object)

The object to compare with the current <xref href="ChargerAstronomyShared.Contracts.Models.TileId" data-throw-if-not-resolved="false"></xref> instance.

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="ChargerAstronomyShared_Contracts_Models_TileId_GetHashCode"></a> GetHashCode\(\)

Returns the hash code for the current object.

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

An integer representing the hash code for the current object.

