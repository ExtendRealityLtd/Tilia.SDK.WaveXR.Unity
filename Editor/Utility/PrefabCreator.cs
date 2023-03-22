namespace Tilia.SDK.WaveXR.Utility
{
    using System.IO;
    using UnityEditor;
    using Zinnia.Utility;

    public class PrefabCreator : BasePrefabCreator
    {
        private const string group = "Tilia/";
        private const string menuItemRoot = topLevelMenuLocation + group + subLevelMenuLocation;

        private const string package = "io.extendreality.tilia.sdk.wavexr.unity";
        private const string baseDirectory = "Runtime";
        private const string prefabDirectory = "Prefabs";
        private const string prefabSuffix = ".prefab";

        private const string prefabCameraRigsWaveXRIntegration = "CameraRigs.WaveXR";

        [MenuItem(menuItemRoot + "CameraRigs/" + prefabCameraRigsWaveXRIntegration, false, priority)]
        private static void AddCameraRigsWaveXRIntegration()
        {
            string prefab = prefabCameraRigsWaveXRIntegration + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, prefab);
            CreatePrefab(packageLocation);
        }
    }
}