# <a id="ChargerAstronomyShared_Contracts_Models_IHorizontal"></a> Interface IHorizontal

Namespace: [ChargerAstronomyShared.Contracts.Models](ChargerAstronomyShared.Contracts.Models.md)  
Assembly: ChargerAstronomyShared.dll  

Interface for horizontal celestial bodies.

```csharp
public interface IHorizontal
```

## Properties

### <a id="ChargerAstronomyShared_Contracts_Models_IHorizontal_HorizontalBody"></a> HorizontalBody

```csharp
HorizontalBody HorizontalBody { get; }
```

#### Property Value

 [HorizontalBody](ChargerAstronomyShared.Domain.Horizontal.HorizontalBody.md)

## Methods

### <a id="ChargerAstronomyShared_Contracts_Models_IHorizontal_SetState_System_Boolean_"></a> SetState\(bool\)

Sets the visibility state of the horizontal body.

```csharp
void SetState(bool visible)
```

#### Parameters

`visible` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

Visibility boolean.

### <a id="ChargerAstronomyShared_Contracts_Models_IHorizontal_UpdatePosition"></a> UpdatePosition\(\)

Updates the position of the horizontal body.

```csharp
void UpdatePosition()
```

