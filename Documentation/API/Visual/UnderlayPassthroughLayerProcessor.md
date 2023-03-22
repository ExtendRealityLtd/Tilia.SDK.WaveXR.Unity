# Class UnderlayPassthroughLayerProcessor

Implements the WaveXR Underlay camera passthrough layer.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Methods]
  * [DisablePassthrough()]
  * [EnablePassthrough()]
  * [TogglePassthrough(Boolean)]

## Details

##### Inheritance

* System.Object
* [PassthroughLayerProcessor]
* UnderlayPassthroughLayerProcessor

##### Inherited Members

[PassthroughLayerProcessor.ImageQuality]

[PassthroughLayerProcessor.OnEnable()]

[PassthroughLayerProcessor.OnAfterImageQualityChange()]

##### Namespace

* [Tilia.SDK.WaveXR.Visual]

##### Syntax

```
public class UnderlayPassthroughLayerProcessor : PassthroughLayerProcessor
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
[PassthroughLayerProcessor.OnEnable()]: PassthroughLayerProcessor.md#Tilia_SDK_WaveXR_Visual_PassthroughLayerProcessor_OnEnable
[PassthroughLayerProcessor.OnAfterImageQualityChange()]: PassthroughLayerProcessor.md#Tilia_SDK_WaveXR_Visual_PassthroughLayerProcessor_OnAfterImageQualityChange
[Tilia.SDK.WaveXR.Visual]: README.md
[PassthroughLayerProcessor.DisablePassthrough()]: PassthroughLayerProcessor.md#Tilia_SDK_WaveXR_Visual_PassthroughLayerProcessor_DisablePassthrough
[PassthroughLayerProcessor.EnablePassthrough()]: PassthroughLayerProcessor.md#Tilia_SDK_WaveXR_Visual_PassthroughLayerProcessor_EnablePassthrough
[PassthroughLayerProcessor.TogglePassthrough(Boolean)]: PassthroughLayerProcessor.md#Tilia_SDK_WaveXR_Visual_PassthroughLayerProcessor_TogglePassthrough_System_Boolean_
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Methods]: #Methods
[DisablePassthrough()]: #DisablePassthrough
[EnablePassthrough()]: #EnablePassthrough
[TogglePassthrough(Boolean)]: #TogglePassthroughBoolean
