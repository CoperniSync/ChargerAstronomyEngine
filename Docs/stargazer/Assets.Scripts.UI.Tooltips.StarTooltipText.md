# <a id="Assets_Scripts_UI_Tooltips_StarTooltipText"></a> Class StarTooltipText

Namespace: [Assets.Scripts.UI.Tooltips](Assets.Scripts.UI.Tooltips.md)  
Assembly: Assembly\-CSharp.dll  

```csharp
public class StarTooltipText : MonoBehaviour
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
Object ← 
Component ← 
Behaviour ← 
MonoBehaviour ← 
[StarTooltipText](Assets.Scripts.UI.Tooltips.StarTooltipText.md)

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Fields

### <a id="Assets_Scripts_UI_Tooltips_StarTooltipText_panel"></a> panel

```csharp
[Header("UI References")]
public RectTransform panel
```

#### Field Value

 RectTransform

### <a id="Assets_Scripts_UI_Tooltips_StarTooltipText_textObject"></a> textObject

```csharp
public Text textObject
```

#### Field Value

 Text

## Properties

### <a id="Assets_Scripts_UI_Tooltips_StarTooltipText_Instance"></a> Instance

```csharp
public static StarTooltipText Instance { get; }
```

#### Property Value

 [StarTooltipText](Assets.Scripts.UI.Tooltips.StarTooltipText.md)

## Methods

### <a id="Assets_Scripts_UI_Tooltips_StarTooltipText_Hide"></a> Hide\(\)

```csharp
public void Hide()
```

### <a id="Assets_Scripts_UI_Tooltips_StarTooltipText_ShowAtMouse_Assets_Scripts_CelestialBodies_Star_"></a> ShowAtMouse\(Star\)

update from a Star object and position at the mouse.

```csharp
public void ShowAtMouse(Star star)
```

#### Parameters

`star` [Star](Assets.Scripts.CelestialBodies.Star.md)

### <a id="Assets_Scripts_UI_Tooltips_StarTooltipText_ShowAtMouse"></a> ShowAtMouse\(\)

```csharp
public void ShowAtMouse()
```

### <a id="Assets_Scripts_UI_Tooltips_StarTooltipText_UpdateData_System_String_System_Int32_System_Single_System_Single_System_Single_"></a> UpdateData\(string, int, float, float, float\)

Update tooltip using raw values.

```csharp
public void UpdateData(string name, int id, float altitude, float azimuth, float distance)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`id` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`altitude` [float](https://learn.microsoft.com/dotnet/api/system.single)

`azimuth` [float](https://learn.microsoft.com/dotnet/api/system.single)

`distance` [float](https://learn.microsoft.com/dotnet/api/system.single)

