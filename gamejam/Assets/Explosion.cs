using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour 
{

	public GameObject explosion;
	void OnCollisionEnter(Collision other)
		{
			if (other.gameObject.tag == "Cubee") 
			{
				//Instantiate(explosion, transform.position, transform.rotation);
				Destroy(this.gameObject);
			}
	}

}