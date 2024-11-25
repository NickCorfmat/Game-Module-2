using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Faucet: Interactable {
    public ParticleSystem particles;
    private bool faucetOn = false;

    private AudioSource waterSFX;

    void Start() {
        particles.Stop();

        waterSFX = GetComponent<AudioSource>();
    }

    protected override void Interact() {
        ToggleFaucet();
    }

    private void ToggleFaucet() {
        faucetOn = !faucetOn;

        if (faucetOn) {
            particles.Play();
            waterSFX.Play();
        } else {
            particles.Stop();
            waterSFX.Stop();
        }
    }
}
