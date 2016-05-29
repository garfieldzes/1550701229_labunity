using UnityEngine;
using System.Collections;

public class Boom : MonoBehaviour
{

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "boom")
        {
            Destroy(this.gameObject);

        }
    }

}