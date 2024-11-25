using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch: Interactable {
    private bool lightsOn = false;

    private AudioSource switchSFX;

    void Start() {
        switchSFX = GetComponent<AudioSource>();
    }

    protected override void Interact() {
        switchSFX.Play();
        ToggleLights();
    }

    private void ToggleLights() {
        Light[] lights = FindObjectsOfType<Light>();

        foreach (Light light in lights) {
            light.enabled = lightsOn;
        }

        lightsOn = !lightsOn;
    }
}
