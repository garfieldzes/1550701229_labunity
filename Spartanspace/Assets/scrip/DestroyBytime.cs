using UnityEngine;
using System.Collections;

public class DestroyBytime : MonoBehaviour 
{
	public float lifetime;

	void Start()
	{
		Destroy (gameObject, lifetime);
	}

}
