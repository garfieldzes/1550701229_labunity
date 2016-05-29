using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameObject enemy;
    public float spawnTime = 5f;
    public Text GameOver;
    public GameObject coin;

   

    void Start()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
        GameOver.gameObject.SetActive(false);
    
    }

    void Spawn()
    {
      
                int spawnPointX = Random.Range(20, 25);
                int spawnPointY = Random.Range(-3, 3);
                Vector3 spawnPosition = new Vector3(spawnPointX, spawnPointY, 5);
                Instantiate(enemy, spawnPosition, Quaternion.identity);
    }
    
}