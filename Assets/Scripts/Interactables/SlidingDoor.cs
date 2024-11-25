using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door: Interactable {
    private bool doorOpen;

    protected override void Interact() {
        ToggleDoor();
    }

    private void ToggleDoor() {
        doorOpen = !doorOpen;
        gameObject.GetComponent<Animator>().SetBool("IsOpen", doorOpen);
    }
}
