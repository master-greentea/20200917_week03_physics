using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlopeMovement : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.position += new Vector3(-.02f, 0f, 0f);
        }

        // right movment
        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.position += new Vector3(.02f, 0f, 0f);
        }
    }
}
