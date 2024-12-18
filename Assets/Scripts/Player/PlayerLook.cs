using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// code from https://youtu.be/rJqP5EesxLk?feature=shared

public class PlayerLook: MonoBehaviour {
    public Camera cam;
    private float xRotation = 0f;

    public float xSensitivity = 20f;
    public float ySensitivity = 20f;

    void Start() {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void ProcessLook(Vector2 input) {
        float mouseX = input.x;
        float mouseY = input.y;

        // calculate camera rotation for looking up and down
        xRotation -= (mouseY * Time.deltaTime) * ySensitivity;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);

        // apply this to our camera transform
        cam.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);

        // rotate player to look left and right
        transform.Rotate(Vector3.up * (mouseX * Time.deltaTime) * xSensitivity);
    }
}
