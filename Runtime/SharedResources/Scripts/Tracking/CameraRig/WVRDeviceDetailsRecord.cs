namespace Tilia.SDK.WaveXR.Tracking.CameraRig
{
    using Tilia.SDK.WaveXR.Visual;
    using UnityEngine;
    using UnityEngine.XR;
    using Wave.Native;
    using Zinnia.Tracking.CameraRig;
    using ZinniaExtensions = Zinnia.Extension;

    /// <summary>
    /// A <see cref="DeviceDetailsRecord"/> for a <see cref="WVR_DeviceType"/>.
    /// </summary>
    public class WVRDeviceDetailsRecord : BaseDeviceDetailsRecord
    {
        [Tooltip("The device to listen for the state change on.")]
        [SerializeField]
        private WVR_DeviceType device;
        /// <summary>
        /// The device to listen for the state change on.
        /// </summary>
        public WVR_DeviceType Device
        {
            get
            {
                return device;
            }
            set
            {
                device = value;
            }
        }
        [Tooltip("The PassthroughLayerProcessor for handling the camera passthrough.")]
        [SerializeField]
        private PassthroughLayerProcessor passthroughProcessor;
        /// <summary>
        /// The <see cref="PassthroughLayerProcessor"/> for handling the camera passthrough.
        /// </summary>
        public PassthroughLayerProcessor PassthroughProcessor
        {
            get
            {
                return passthroughProcessor;
            }
            set
            {
                passthroughProcessor = value;
            }
        }

        /// <inheritdoc/>
        public override XRNode XRNodeType { get => GetXRNodeFromDevice(Device); protected set => throw new System.NotImplementedException(); }
        /// <inheritdoc/>
        public override bool IsConnected { get => Interop.WVR_IsDeviceConnected(Device); protected set => throw new System.NotImplementedException(); }
        /// <inheritdoc/>
        public override int Priority { get => Interop.WVR_GetFocusedController() == Device ? 0 : 1; protected set => throw new System.NotImplementedException(); }
        /// <inheritdoc/>
        public override SpatialTrackingType TrackingType { get => GetTrackingType(Device); protected set => throw new System.NotImplementedException(); }
        /// <inheritdoc/>
        public override float BatteryLevel { get => Interop.WVR_GetDeviceBatteryPercentage(Device); protected set => throw new System.NotImplementedException(); }
        /// <inheritdoc/>
        public override BatteryStatus BatteryChargeStatus { get => GetBatteryStatusFromChargeStatus(Device); protected set => throw new System.NotImplementedException(); }
        /// <inheritdoc/>
        public override bool HasPassThroughCamera { get => HasPassThroughFeature() && PassthroughProcessor != null; protected set => throw new System.NotImplementedException(); }

        /// <inheritdoc/>
        protected override void EnablePassThrough()
        {
            if (!HasPassThroughCamera)
            {
                return;
            }

            PassthroughProcessor.EnablePassthrough();
            base.EnablePassThrough();
        }

        /// <inheritdoc/>
        protected override void DisablePassThrough()
        {
            if (!HasPassThroughCamera)
            {
                return;
            }

            PassthroughProcessor.DisablePassthrough();
            base.DisablePassThrough();
        }

        /// <summary>
        /// Sets the <see cref="DeviceType"/>.
        /// </summary>
        /// <param name="index">The index of the <see cref="WVR_DeviceType"/>.</param>
        public virtual void SetDeviceType(int index)
        {
            Device = ZinniaExtensions.EnumExtensions.GetByIndex<WVR_DeviceType>(index);
        }

        /// <summary>
        /// Gets the corresponding <see cref="XRNode"/> from the given <see cref="WVR_DeviceType"/>.
        /// </summary>
        /// <param name="device">The device type to convert.</param>
        /// <returns>The converted XR Node.</returns>
        protected virtual XRNode GetXRNodeFromDevice(WVR_DeviceType device)
        {
            switch (device)
            {
                case WVR_DeviceType.WVR_DeviceType_HMD:
                    return XRNode.Head;
                case WVR_DeviceType.WVR_DeviceType_Controller_Left:
                case WVR_DeviceType.WVR_DeviceType_ElectronicHand_Left:
                case WVR_DeviceType.WVR_DeviceType_NaturalHand_Left:
                    return XRNode.LeftHand;
                case WVR_DeviceType.WVR_DeviceType_Controller_Right:
                case WVR_DeviceType.WVR_DeviceType_ElectronicHand_Right:
                case WVR_DeviceType.WVR_DeviceType_NaturalHand_Right:
                    return XRNode.RightHand;
                case WVR_DeviceType.WVR_DeviceType_Camera:
                    return XRNode.CenterEye;
                case WVR_DeviceType.WVR_DeviceType_Tracker:
                    return XRNode.HardwareTracker;
                default:
                    return XRNode.TrackingReference;
            }
        }

        /// <summary>
        /// Gets the <see cref="SpatialTrackingType"/> of the given device.
        /// </summary>
        /// <param name="device">The device to check tracking on.</param>
        /// <returns>Thge found tracking type.</returns>
        protected virtual SpatialTrackingType GetTrackingType(WVR_DeviceType device)
        {
            switch (Interop.WVR_GetDegreeOfFreedom(device))
            {
                case WVR_NumDoF.WVR_NumDoF_3DoF:
                    return SpatialTrackingType.RotationOnly;
                case WVR_NumDoF.WVR_NumDoF_6DoF:
                    return SpatialTrackingType.RotationAndPosition;
            }

            return SpatialTrackingType.Unknown;
        }

        /// <summary>
        /// Gets the <see cref="BatteryStatus"/> from the given device.
        /// </summary>
        /// <param name="device">The device to get battery status for.</param>
        /// <returns>The current device battery status.</returns>
        protected virtual BatteryStatus GetBatteryStatusFromChargeStatus(WVR_DeviceType device)
        {
            switch (Interop.WVR_GetChargeStatus(device))
            {
                case WVR_ChargeStatus.WVR_ChargeStatus_Charging:
                    return BatteryStatus.Charging;
                case WVR_ChargeStatus.WVR_ChargeStatus_Discharging:
                    return BatteryStatus.Discharging;
                case WVR_ChargeStatus.WVR_ChargeStatus_Full:
                    return BatteryStatus.Full;
            }

            return BatteryStatus.Unknown;
        }

        /// <summary>
        /// Determines whether the device has a passthrough camera feature.
        /// </summary>
        /// <returns>Whether there is a passthrough camera feature.</returns>
        protected virtual bool HasPassThroughFeature()
        {
            ulong supportedFeatures = WVR_Android.WVR_GetSupportedFeatures();
            ulong passThruFeature = (ulong)WVR_SupportedFeature.WVR_SupportedFeature_PassthroughOverlay;
            return (supportedFeatures & passThruFeature) == passThruFeature;
        }
    }
}