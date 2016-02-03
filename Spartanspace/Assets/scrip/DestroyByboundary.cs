using UnityEngine;
using System.Collections;

public class DestroyByboundary : MonoBehaviour 
{
	void OnTriggerExit(Collider other)
	{
		Destroy (other.gameObject);
	}
}
