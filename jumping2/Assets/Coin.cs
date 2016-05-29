using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{


    private int score;
    public Text scoreText;

    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        score = 0;
        scoreText.text = "Score :" + score.ToString();
    }


    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "coin")
        {
            score = score + 1;
            scoreText.text = "Score :" + score.ToString();


        }
    }


}