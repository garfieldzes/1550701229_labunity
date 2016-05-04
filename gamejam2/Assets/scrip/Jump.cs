using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour
{
	public float speed;
	private Rigidbody rb;  
	bool canjump;
	int jumpcount=0;
	
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}
	public void jumper()
	{
		if(canjump || jumpcount <=1)
		{
			rb.velocity = Vector3.up * speed ;
			jumpcount++;
		}
	}
	void OnCollisionEnter(Collision other) {
		if (other.gameObject.tag== "cube")
		{
			rb.velocity = Vector3.up * speed ;
			canjump = true;
			jumpcount =0;
		}
		
	}
	void OnCollisionExit(Collision other)
	{
		if (other.gameObject.tag == "cube") 
		{
			canjump = false;
		}
	}
}