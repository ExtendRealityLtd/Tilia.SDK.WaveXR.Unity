# Class PassthroughLayerProcessor

The basis for defining a WaveXR passthrough layer.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [ImageQuality]
* [Methods]
  * [DisablePassthrough()]
  * [EnablePassthrough()]
  * [OnAfterImageQualityChange()]
  * [OnEnable()]
  * [TogglePassthrough(Boolean)]

## Details

##### Inheritance

* System.Object
* PassthroughLayerProcessor
* [OverlayPassthroughLayerProcessor]
* [UnderlayPassthroughLayerProcessor]

##### Namespace

* [Tilia.SDK.WaveXR.Visual]

##### Syntax

```
public abstract class PassthroughLayerProcessor : MonoBehaviour
```

### Properties

#### ImageQuality

The image quality of the passthrough layer.

##### Declaration

```
public WVR_PassthroughImageQuality ImageQuality { get; set; }
```

### Methods

#### DisablePassthrough()

Disables the camera passthrough.

##### Declaration

```
public abstract void DisablePassthrough()
```

#### EnablePassthrough()

Enables the camera passthrough.

##### Declaration

```
public abstract void EnablePassthrough()
```

#### OnAfterImageQualityChange()

Called after [ImageQuality] has been changed.

##### Declaration

```
protected virtual void OnAfterImageQualityChange()
```

#### OnEnable()

##### Declaration

```
protected virtual void OnEnable()
```

#### TogglePassthrough(Boolean)

Toggles the camera passthrough state.

##### Declaration

```
public abstract void TogglePassthrough(bool enabled)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | enabled | Whether to toggle to the enabled state or not. |

[OverlayPassthroughLayerProcessor]: OverlayPassthroughLayerProcessor.md
[UnderlayPassthroughLayerProcessor]: UnderlayPassthroughLayerProcessor.md
[Tilia.SDK.WaveXR.Visual]: README.md
[ImageQuality]: PassthroughLayerProcessor.md#ImageQuality
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[ImageQuality]: #ImageQuality
[Methods]: #Methods
[DisablePassthrough()]: #DisablePassthrough
[EnablePassthrough()]: #EnablePassthrough
[OnAfterImageQualityChange()]: #OnAfterImageQualityChange
[OnEnable()]: #OnEnable
[TogglePassthrough(Boolean)]: #TogglePassthroughBoolean
