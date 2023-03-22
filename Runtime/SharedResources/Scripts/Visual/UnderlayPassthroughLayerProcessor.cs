namespace Tilia.SDK.WaveXR.Visual
{
    using Wave.Native;

    /// <summary>
    /// Implements the WaveXR Underlay camera passthrough layer.
    /// </summary>
    public class UnderlayPassthroughLayerProcessor : PassthroughLayerProcessor
    {
        /// <inheritdoc/>
        public override void EnablePassthrough()
        {
            Interop.WVR_ShowPassthroughUnderlay(true);
        }

        /// <inheritdoc/>
        public override void DisablePassthrough()
        {
            Interop.WVR_ShowPassthroughUnderlay(false);
        }

        /// <inheritdoc/>
        public override void TogglePassthrough(bool enabled)
        {
            Interop.WVR_ShowPassthroughUnderlay(enabled);
        }
    }
}