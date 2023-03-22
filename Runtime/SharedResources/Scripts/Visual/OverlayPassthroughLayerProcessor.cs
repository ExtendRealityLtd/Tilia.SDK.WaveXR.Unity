namespace Tilia.SDK.WaveXR.Visual
{
    using UnityEngine;
    using Wave.Native;
    using Zinnia.Extension;

    /// <summary>
    /// Implements the WaveXR Overlay camera passthrough layer.
    /// </summary>
    public class OverlayPassthroughLayerProcessor : PassthroughLayerProcessor
    {
        [Tooltip("The alpha level of the overlay passthrough layer.")]
        [SerializeField]
        private float alphaValue = 0.5f;
        /// <summary>
        /// The alpha level of the overlay passthrough layer.
        /// </summary>
        public float AlphaValue
        {
            get
            {
                return alphaValue;
            }
            set
            {
                alphaValue = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterAlphaValueChange();
                }
            }
        }

        /// <inheritdoc/>
        public override void EnablePassthrough()
        {
            Interop.WVR_ShowPassthroughOverlay(true);
        }

        /// <inheritdoc/>
        public override void DisablePassthrough()
        {
            Interop.WVR_ShowPassthroughOverlay(false);
        }

        /// <inheritdoc/>
        public override void TogglePassthrough(bool enabled)
        {
            Interop.WVR_ShowPassthroughOverlay(enabled);
        }

        /// <inheritdoc/>
        protected override void OnEnable()
        {
            base.OnEnable();
            OnAfterAlphaValueChange();
        }

        /// <summary>
        /// Called after <see cref="AlphaValue"/> has been changed.
        /// </summary>
        protected virtual void OnAfterAlphaValueChange()
        {
            Interop.WVR_SetPassthroughOverlayAlpha(AlphaValue);
        }
    }
}