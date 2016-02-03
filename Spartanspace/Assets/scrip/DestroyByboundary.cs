using UnityEngine;
using System.Collections;

public class DestroyByboundary : MonoBehaviour {
	void OntriggerExit(Collider other)
	{
		Destroy (other.gameObject);
	}
}
