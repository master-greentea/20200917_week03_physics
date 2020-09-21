using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tirgger : MonoBehaviour
{
    public Transform cameraTransform;
    Transform cameraFocus;
    void OnTriggerEnter2D(Collider2D activator) {
        Debug.Log("bruh");
        cameraFocus = activator.transform;
    }

    void OnTriggerExit2D(Collider2D activator) {
        if (activator.transform == cameraFocus) {
            cameraFocus = null;
        }
    }

    void Update() {
        if (cameraFocus != null) {
            cameraTransform.position = cameraFocus.transform.position + new Vector3(0f, 0f, -10f);
        }
    }
}
