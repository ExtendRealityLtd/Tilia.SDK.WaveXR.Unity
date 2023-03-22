# Class OverlayPassthroughLayerProcessor

Implements the WaveXR Overlay camera passthrough layer.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [AlphaValue]
* [Methods]
  * [DisablePassthrough()]
  * [EnablePassthrough()]
  * [OnAfterAlphaValueChange()]
  * [OnEnable()]
  * [TogglePassthrough(Boolean)]

## Details

##### Inheritance

* System.Object
* [PassthroughLayerProcessor]
* OverlayPassthroughLayerProcessor

##### Inherited Members

[PassthroughLayerProcessor.ImageQuality]

[PassthroughLayerProcessor.OnAfterImageQualityChange()]

##### Namespace

* [Tilia.SDK.WaveXR.Visual]

##### Syntax

```
public class OverlayPassthroughLayerProcessor : PassthroughLayerProcessor
```

### Properties

#### AlphaValue

The alpha level of the overlay passthrough layer.

##### Declaration

```
public float AlphaValue { get; set; }
```

### Methods

#### DisablePassthrough()

Disables the camera passthrough.

##### Declaration

```
public override void DisablePassthrough()
```

##### Overrides

[PassthroughLayerProcessor.DisablePassthrough()]

#### EnablePassthrough()

Enables the camera passthrough.

##### Declaration

```
public override void EnablePassthrough()
```

##### Overrides

[PassthroughLayerProcessor.EnablePassthrough()]

#### OnAfterAlphaValueChange()

Called after [AlphaValue] has been changed.

##### Declaration

```
protected virtual void OnAfterAlphaValueChange()
```

#### OnEnable()

##### Declaration

```
protected override void OnEnable()
```

##### Overrides

[PassthroughLayerProcessor.OnEnable()]

#### TogglePassthrough(Boolean)

Toggles the camera passthrough state.

##### Declaration

```
public override void TogglePassthrough(bool enabled)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | enabled | Whether to toggle to the enabled state or not. |

##### Overrides

[PassthroughLayerProcessor.TogglePassthrough(Boolean)]

[PassthroughLayerProcessor]: PassthroughLayerProcessor.md
[PassthroughLayerProcessor.ImageQuality]: PassthroughLayerProcessor.md#Tilia_SDK_WaveXR_Visual_PassthroughLayerProcessor_ImageQuality
[PassthroughLayerProcessor.OnAfterImageQualityChange()]: PassthroughLayerProcessor.md#Tilia_SDK_WaveXR_Visual_PassthroughLayerProcessor_OnAfterImageQualityChange
[Tilia.SDK.WaveXR.Visual]: README.md
[PassthroughLayerProcessor.DisablePassthrough()]: PassthroughLayerProcessor.md#Tilia_SDK_WaveXR_Visual_PassthroughLayerProcessor_DisablePassthrough
[PassthroughLayerProcessor.EnablePassthrough()]: PassthroughLayerProcessor.md#Tilia_SDK_WaveXR_Visual_PassthroughLayerProcessor_EnablePassthrough
[AlphaValue]: OverlayPassthroughLayerProcessor.md#AlphaValue
[PassthroughLayerProcessor.OnEnable()]: PassthroughLayerProcessor.md#Tilia_SDK_WaveXR_Visual_PassthroughLayerProcessor_OnEnable
[PassthroughLayerProcessor.TogglePassthrough(Boolean)]: PassthroughLayerProcessor.md#Tilia_SDK_WaveXR_Visual_PassthroughLayerProcessor_TogglePassthrough_System_Boolean_
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[AlphaValue]: #AlphaValue
[Methods]: #Methods
[DisablePassthrough()]: #DisablePassthrough
[EnablePassthrough()]: #EnablePassthrough
[OnAfterAlphaValueChange()]: #OnAfterAlphaValueChange
[OnEnable()]: #OnEnable
[TogglePassthrough(Boolean)]: #TogglePassthroughBoolean
