# <a id="ChargerAstronomyEngine_CosineKittyAstronomy_SearchContexts_SearchContext"></a> Class SearchContext

Namespace: [ChargerAstronomyEngine.CosineKittyAstronomy.SearchContexts](ChargerAstronomyEngine.CosineKittyAstronomy.SearchContexts.md)  
Assembly: ChargerAstronomyEngine.dll  

Represents a function whose ascending root is to be found.
See #Astronomy.Search.

```csharp
public abstract class SearchContext
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[SearchContext](ChargerAstronomyEngine.CosineKittyAstronomy.SearchContexts.SearchContext.md)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Methods

### <a id="ChargerAstronomyEngine_CosineKittyAstronomy_SearchContexts_SearchContext_Eval_ChargerAstronomyEngine_CosineKittyAstronomy_Astronomy_ChargerAstronomyEngine_CosineKittyAstronomy_AstroTime_"></a> Eval\(Astronomy, AstroTime\)

Evaluates the function at a given time

```csharp
public abstract double Eval(Astronomy astro, AstroTime time)
```

#### Parameters

`astro` [Astronomy](ChargerAstronomyEngine.CosineKittyAstronomy.Astronomy.md)

`time` [AstroTime](ChargerAstronomyEngine.CosineKittyAstronomy.AstroTime.md)

The time at which to evaluate the function.

#### Returns

 [double](https://learn.microsoft.com/dotnet/api/system.double)

The floating point value of the function at the specified time.

