using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnd : MonoBehaviour
{
    // Start is called before the first frame updat
    void OnTriggerEnter2D(Collider2D activator) {
        activator.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        GameObject.Find("Ball").GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        GameObject.Find("Text2").GetComponent<SpriteRenderer>().enabled = true;
        GameObject.Find("Text3").GetComponent<SpriteRenderer>().enabled = true;
    }
}
