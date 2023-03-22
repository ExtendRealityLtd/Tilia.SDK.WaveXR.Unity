namespace Tilia.SDK.WaveXR.Haptics
{
    using UnityEngine;
    using Wave.Essence;
    using Zinnia.Haptics;

    /// <summary>
    /// Creates a single haptic pulse on a <see cref="XR_Device"/> supported haptic device.
    /// </summary>
    public class WXRDeviceHapticPulser : HapticPulser
    {
        [Tooltip("The device to pulse.")]
        [SerializeField]
        private XR_Device device;
        /// <summary>
        /// The device to pulse.
        /// </summary>
        public XR_Device Device
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
        [Tooltip("The duration to pulse the XR_Device for in seconds.")]
        [SerializeField]
        private float duration = 0.1f;
        /// <summary>
        /// The duration to pulse the <see cref="XR_Device"/> for in seconds.
        /// </summary>
        public float Duration
        {
            get
            {
                return duration;
            }
            set
            {
                duration = value;
            }
        }
        [Tooltip("Determines whether to pulse the adpated dominant controller or just the given Device.")]
        [SerializeField]
        private bool useAdaptiveHand = false;
        /// <summary>
        /// Determines whether to pulse the adpated dominant controller or just the given <see cref="Device"/>.
        /// </summary>
        public bool UseAdaptiveHand
        {
            get
            {
                return useAdaptiveHand;
            }
            set
            {
                useAdaptiveHand = value;
            }
        }

        protected override void DoBegin()
        {
            WXRDevice.SendHapticImpulse(device, Intensity, Duration, UseAdaptiveHand);
        }

        protected override void DoCancel()
        {
            WXRDevice.SendHapticImpulse(device, 0f, 0f, UseAdaptiveHand);
        }
    }
}