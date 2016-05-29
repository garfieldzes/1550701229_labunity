using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Death1 : MonoBehaviour
{

    public Text GameOver;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "overtang")
        {
            Destroy(this.gameObject);
            GameOver.gameObject.SetActive(true);
        }
    }
}