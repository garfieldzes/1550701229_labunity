using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Controller1 : MonoBehaviour
{
	public GameObject hazard ;
	public float delta = 1.5f;  // Amount to move left and right from the start point
	public float speed = 2.0f; 
	//private Vector3 startPos;
	public float spawnWait;
	public float startWait;
	public float waveWait;
	public int hazardCount;
	void Start ()
	{
		StartCoroutine (SpawnWaves ());
		
	}
	
	IEnumerator SpawnWaves ()
	{
		yield return new WaitForSeconds (startWait);
		while (true) {
			for (int i = 0; i < hazardCount; i++) {
				//float randomNum = Random.Range (-2.3f,4.5f);
				GameObject hazard2 = (GameObject)Instantiate (hazard, new Vector3 (5,2, 0), Quaternion.identity);
				hazard2.transform.Rotate(90,0,0);
				yield return new WaitForSeconds (spawnWait);
			}
			yield return new WaitForSeconds (waveWait);
		}
	}
}