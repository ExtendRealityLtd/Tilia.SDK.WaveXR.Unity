# Installing the package

> * Level: Beginner
>
> * Reading Time: 5 minutes
>
> * Checked with:
>   * Unity 2019.4.40f1
>   * Vive Wave XR Plugin 5.2.0-r.8
>   * Vive Wave XR Plugin - Essence 5.2.0-r.8
>   * Vive Wave XR Plugin - Native 5.2.0-r.8

## Introduction

The [WaveXR Plugin] asset for the [Unity] software provides direct access to the WaveXR hardware API and therefore offers a number of additional features outside of the default Unity software XR offering.

This package contains the following functionality:

* CameraRig wrapper so a WaveXR specific CameraRig prefab can be used with the [Tilia.CameraRigs.TrackedAlias.Unity].
* Controller haptic feedback utilizing `WXRDevice`.

## Let's Start

### Step 1

> You may skip this step if you already have a Unity project to import the package into.

* Create a new project in the Unity software version `2019.4.40f1` (or above) using `3D Template` or open an existing project.

### Step 2: Configuring the Unity project

* Ensure the project `Scripting Runtime Version` is set to `.NET 4.x Equivalent`:
  * In the Unity software select `Main Menu -> Edit -> Project Settings` to open the `Project Settings` inspector.
  * Select `Player` from the left hand menu in the `Project Settings` window.
  * In the `Player` settings panel expand `Other Settings`.
  * Ensure the `Scripting Runtime Version` is set to `.NET 4.x Equivalent`.

### Step 3: Adding the Vive WaveXR Plugin asset to the Unity project.

* Visit the HTC Vive website and follow the [SDK Installation Instructions] and update the Unity project Scoped Registries to include the HTC Vive registry.

> The Tilia.SDK.WaveXR.Unity package will automatically include the required WaveXR Plugin packages so they do not need manually installing.

### Step 4: Adding the package to the Unity project manifest

* Navigate to the `Packages` directory of your project.
* Adjust the [project manifest file][Project-Manifest] `manifest.json` in a text editor.
  * Ensure `https://registry.npmjs.org/` is part of `scopedRegistries`.
    * Ensure `io.extendreality` is part of `scopes`.
  * Add `io.extendreality.tilia.sdk.wavexr.unity` to `dependencies`, stating the latest version.

  A minimal example ends up looking like this. Please note that the version `X.Y.Z` stated here is to be replaced with [the latest released version][Latest-Release] which is currently [![Release][Version-Release]][Releases].
  ```json
  {
    "scopedRegistries": [
      {
        "name": "npmjs",
        "url": "https://registry.npmjs.org/",
        "scopes": [
          "io.extendreality"
        ]
      }
    ],
    "dependencies": {
      "io.extendreality.tilia.sdk.wavexr.unity": "X.Y.Z",
      ...
    }
  }
  ```
* Switch back to the Unity software and wait for it to finish importing the added package.

### Done

The WaveXR Plugin package will now be available in your Unity project `Packages` directory ready for use in your project.

The package will now also show up in the Unity Package Manager UI. From then on the package can be updated by selecting the package in the Unity Package Manager and clicking on the `Update` button or using the version selection UI.

[WaveXR Plugin]: https://developer.vive.com/resources/vive-wave/tutorials/installing-wave-xr-plugin-unity/
[SDK Installation Instructions]: https://hub.vive.com/storage/docs/en-us/UnityXR/UnityXRGettingStart.html#adding-the-vive-registry
[Unity]: https://unity3d.com/
[Tilia.CameraRigs.TrackedAlias.Unity]: https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity
[Unity Package Manager]: https://docs.unity3d.com/Manual/upm-ui.html
[Project-Manifest]: https://docs.unity3d.com/Manual/upm-manifestPrj.html
[Version-Release]: https://img.shields.io/github/release/ExtendRealityLtd/Tilia.SDK.WaveXR.Unity.svg
[Releases]: ../../../../../releases
[Latest-Release]: ../../../../../releases/latest