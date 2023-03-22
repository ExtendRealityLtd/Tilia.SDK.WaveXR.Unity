# Class WVRDeviceDetailsRecord

A DeviceDetailsRecord for a WVR\_DeviceType.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [BatteryChargeStatus]
  * [BatteryLevel]
  * [Device]
  * [HasPassThroughCamera]
  * [IsConnected]
  * [PassthroughProcessor]
  * [Priority]
  * [TrackingType]
  * [XRNodeType]
* [Methods]
  * [DisablePassThrough()]
  * [EnablePassThrough()]
  * [GetBatteryStatusFromChargeStatus(WVR\_DeviceType)]
  * [GetTrackingType(WVR\_DeviceType)]
  * [GetXRNodeFromDevice(WVR\_DeviceType)]
  * [HasPassThroughFeature()]
  * [SetDeviceType(Int32)]

## Details

##### Inheritance

* System.Object
* WVRDeviceDetailsRecord

##### Namespace

* [Tilia.SDK.WaveXR.Tracking.CameraRig]

##### Syntax

```
public class WVRDeviceDetailsRecord : BaseDeviceDetailsRecord
```

### Properties

#### BatteryChargeStatus

##### Declaration

```
public override BatteryStatus BatteryChargeStatus { get; protected set; }
```

#### BatteryLevel

##### Declaration

```
public override float BatteryLevel { get; protected set; }
```

#### Device

The device to listen for the state change on.

##### Declaration

```
public WVR_DeviceType Device { get; set; }
```

#### HasPassThroughCamera

##### Declaration

```
public override bool HasPassThroughCamera { get; protected set; }
```

#### IsConnected

##### Declaration

```
public override bool IsConnected { get; protected set; }
```

#### PassthroughProcessor

The [PassthroughLayerProcessor] for handling the camera passthrough.

##### Declaration

```
public PassthroughLayerProcessor PassthroughProcessor { get; set; }
```

#### Priority

##### Declaration

```
public override int Priority { get; protected set; }
```

#### TrackingType

##### Declaration

```
public override SpatialTrackingType TrackingType { get; protected set; }
```

#### XRNodeType

##### Declaration

```
public override XRNode XRNodeType { get; protected set; }
```

### Methods

#### DisablePassThrough()

##### Declaration

```
protected override void DisablePassThrough()
```

#### EnablePassThrough()

##### Declaration

```
protected override void EnablePassThrough()
```

#### GetBatteryStatusFromChargeStatus(WVR\_DeviceType)

Gets the BatteryStatus from the given device.

##### Declaration

```
protected virtual BatteryStatus GetBatteryStatusFromChargeStatus(WVR_DeviceType device)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| WVR\_DeviceType | device | The device to get battery status for. |

##### Returns

| Type | Description |
| --- | --- |
| BatteryStatus | The current device battery status. |

#### GetTrackingType(WVR\_DeviceType)

Gets the SpatialTrackingType of the given device.

##### Declaration

```
protected virtual SpatialTrackingType GetTrackingType(WVR_DeviceType device)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| WVR\_DeviceType | device | The device to check tracking on. |

##### Returns

| Type | Description |
| --- | --- |
| SpatialTrackingType | Thge found tracking type. |

#### GetXRNodeFromDevice(WVR\_DeviceType)

Gets the corresponding XRNode from the given WVR\_DeviceType.

##### Declaration

```
protected virtual XRNode GetXRNodeFromDevice(WVR_DeviceType device)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| WVR\_DeviceType | device | The device type to convert. |

##### Returns

| Type | Description |
| --- | --- |
| XRNode | The converted XR Node. |

#### HasPassThroughFeature()

Determines whether the device has a passthrough camera feature.

##### Declaration

```
protected virtual bool HasPassThroughFeature()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | Whether there is a passthrough camera feature. |

#### SetDeviceType(Int32)

Sets the DeviceType.

##### Declaration

```
public virtual void SetDeviceType(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index | The index of the WVR\_DeviceType. |

[Tilia.SDK.WaveXR.Tracking.CameraRig]: README.md
[PassthroughLayerProcessor]: ../../Visual/PassthroughLayerProcessor.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[BatteryChargeStatus]: #BatteryChargeStatus
[BatteryLevel]: #BatteryLevel
[Device]: #Device
[HasPassThroughCamera]: #HasPassThroughCamera
[IsConnected]: #IsConnected
[PassthroughProcessor]: #PassthroughProcessor
[Priority]: #Priority
[TrackingType]: #TrackingType
[XRNodeType]: #XRNodeType
[Methods]: #Methods
[DisablePassThrough()]: #DisablePassThrough
[EnablePassThrough()]: #EnablePassThrough
[GetBatteryStatusFromChargeStatus(WVR\_DeviceType)]: #GetBatteryStatusFromChargeStatusWVR\_DeviceType
[GetTrackingType(WVR\_DeviceType)]: #GetTrackingTypeWVR\_DeviceType
[GetXRNodeFromDevice(WVR\_DeviceType)]: #GetXRNodeFromDeviceWVR\_DeviceType
[HasPassThroughFeature()]: #HasPassThroughFeature
[SetDeviceType(Int32)]: #SetDeviceTypeInt32
