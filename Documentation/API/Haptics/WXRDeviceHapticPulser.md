# Class WXRDeviceHapticPulser

Creates a single haptic pulse on a XR\_Device supported haptic device.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [Device]
  * [Duration]
  * [UseAdaptiveHand]
* [Methods]
  * [DoBegin()]
  * [DoCancel()]

## Details

##### Inheritance

* System.Object
* WXRDeviceHapticPulser

##### Namespace

* [Tilia.SDK.WaveXR.Haptics]

##### Syntax

```
public class WXRDeviceHapticPulser : HapticPulser
```

### Properties

#### Device

The device to pulse.

##### Declaration

```
public XR_Device Device { get; set; }
```

#### Duration

The duration to pulse the XR\_Device for in seconds.

##### Declaration

```
public float Duration { get; set; }
```

#### UseAdaptiveHand

Determines whether to pulse the adpated dominant controller or just the given [Device].

##### Declaration

```
public bool UseAdaptiveHand { get; set; }
```

### Methods

#### DoBegin()

##### Declaration

```
protected override void DoBegin()
```

#### DoCancel()

##### Declaration

```
protected override void DoCancel()
```

[Tilia.SDK.WaveXR.Haptics]: README.md
[Device]: WXRDeviceHapticPulser.md#Device
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[Device]: #Device
[Duration]: #Duration
[UseAdaptiveHand]: #UseAdaptiveHand
[Methods]: #Methods
[DoBegin()]: #DoBegin
[DoCancel()]: #DoCancel
