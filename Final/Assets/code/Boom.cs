using UnityEngine;
using System.Collections;

public class Boom : MonoBehaviour {
	bool canjump;
	int jumpcount=0;
	void Start ()
	{
		Rigidbody rb = GetComponent<Rigidbody> ();
	}
	
	void OnCollisionEnter(Collision other) 
	{
		if (other.gameObject.tag== "enemy")
		{
			Destroy(this.gameObject);
		}
	}
}