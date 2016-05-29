using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Gamecontroller : MonoBehaviour
{
    public GameObject hazard;
    public float delta = 1.5f;
    public float speed = 2.0f;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    public int hazardCount;
    void Start()
    {
        StartCoroutine(SpawnWaves());

    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
        
                GameObject hazard2 = (GameObject)Instantiate(hazard, new Vector3(0, 0, 0), Quaternion.identity);
                hazard2.transform.Rotate(90, 0, 0);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
        }
    }
}