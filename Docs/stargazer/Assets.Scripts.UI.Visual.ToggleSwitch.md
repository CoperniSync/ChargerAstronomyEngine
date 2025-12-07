# <a id="Assets_Scripts_UI_Visual_ToggleSwitch"></a> Class ToggleSwitch

Namespace: [Assets.Scripts.UI.Visual](Assets.Scripts.UI.Visual.md)  
Assembly: Assembly\-CSharp.dll  

```csharp
public class ToggleSwitch : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
Object ← 
Component ← 
Behaviour ← 
MonoBehaviour ← 
[ToggleSwitch](Assets.Scripts.UI.Visual.ToggleSwitch.md)

#### Implements

IPointerClickHandler, 
IEventSystemHandler

#### Inherited Members

[object.Equals\(object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object, object\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Fields

### <a id="Assets_Scripts_UI_Visual_ToggleSwitch_sliderValue"></a> sliderValue

```csharp
[Header("Slider setup")]
[SerializeField]
[Range(0, 1)]
protected float sliderValue
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Assets_Scripts_UI_Visual_ToggleSwitch_transitionEffect"></a> transitionEffect

```csharp
protected Action transitionEffect
```

#### Field Value

 [Action](https://learn.microsoft.com/dotnet/api/system.action)

## Properties

### <a id="Assets_Scripts_UI_Visual_ToggleSwitch_CurrentValue"></a> CurrentValue

```csharp
public bool CurrentValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Assets_Scripts_UI_Visual_ToggleSwitch_Awake"></a> Awake\(\)

```csharp
protected virtual void Awake()
```

### <a id="Assets_Scripts_UI_Visual_ToggleSwitch_OnPointerClick_UnityEngine_EventSystems_PointerEventData_"></a> OnPointerClick\(PointerEventData\)

```csharp
public void OnPointerClick(PointerEventData eventData)
```

#### Parameters

`eventData` PointerEventData

### <a id="Assets_Scripts_UI_Visual_ToggleSwitch_OnValidate"></a> OnValidate\(\)

```csharp
protected virtual void OnValidate()
```

### <a id="Assets_Scripts_UI_Visual_ToggleSwitch_SetupForManager_Assets_Scripts_UI_Visual_ToggleSwitchGroupManager_"></a> SetupForManager\(ToggleSwitchGroupManager\)

```csharp
public void SetupForManager(ToggleSwitchGroupManager manager)
```

#### Parameters

`manager` [ToggleSwitchGroupManager](Assets.Scripts.UI.Visual.ToggleSwitchGroupManager.md)

### <a id="Assets_Scripts_UI_Visual_ToggleSwitch_ToggleByGroupManager_System_Boolean_"></a> ToggleByGroupManager\(bool\)

```csharp
public void ToggleByGroupManager(bool valueToSetTo)
```

#### Parameters

`valueToSetTo` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

