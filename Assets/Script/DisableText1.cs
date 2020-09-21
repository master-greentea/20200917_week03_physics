using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableText1 : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) {
            GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
