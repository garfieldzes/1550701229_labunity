using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5, 0, 0);
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "death")
        {
            Destroy(this.gameObject);
        }
    }
}
