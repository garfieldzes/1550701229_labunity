using UnityEngine;
using System.Collections;

public class Nextsen : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void DoPlayAgain()
	{
		Application.LoadLevel (0);
	}
	public void play()
	{
		Application.LoadLevel (1);
	}
}
