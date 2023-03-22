namespace Tilia.SDK.WaveXR.Visual
{
    using UnityEngine;
    using Wave.Native;
    using Zinnia.Extension;

    /// <summary>
    /// The basis for defining a WaveXR passthrough layer.
    /// </summary>
    public abstract class PassthroughLayerProcessor : MonoBehaviour
    {
        [Tooltip("The image quality of the passthrough layer.")]
        [SerializeField]
        private WVR_PassthroughImageQuality imageQuality = WVR_PassthroughImageQuality.DefaultMode;
        /// <summary>
        /// The image quality of the passthrough layer.
        /// </summary>
        public WVR_PassthroughImageQuality ImageQuality
        {
            get
            {
                return imageQuality;
            }
            set
            {
                imageQuality = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterImageQualityChange();
                }
            }
        }

        /// <summary>
        /// Enables the camera passthrough.
        /// </summary>
        public abstract void EnablePassthrough();
        /// <summary>
        /// Disables the camera passthrough.
        /// </summary>
        public abstract void DisablePassthrough();
        /// <summary>
        /// Toggles the camera passthrough state.
        /// </summary>
        /// <param name="enabled">Whether to toggle to the enabled state or not.</param>
        public abstract void TogglePassthrough(bool enabled);

        protected virtual void OnEnable()
        {
            OnAfterImageQualityChange();
        }

        /// <summary>
        /// Called after <see cref="ImageQuality"/> has been changed.
        /// </summary>
        protected virtual void OnAfterImageQualityChange()
        {
            Interop.WVR_SetPassthroughImageQuality(ImageQuality);
        }
    }
}