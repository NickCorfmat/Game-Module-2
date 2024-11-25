using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TV: Interactable {
    public GameObject decal;

    void Start() {
        decal.SetActive(false);
    }

    protected override void Interact() {
        BreakTV();
    }

    private void BreakTV() {
        decal.SetActive(true);
    }
}