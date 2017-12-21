using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySaws : MonoBehaviour {
	
	// Use this for initialization
	void OnTriggerEnter2D(Collider2D other) 
	{
		//Check the provided Collider2D parameter other to see if it is tagged "PickUp", if it is...
		if (other.gameObject.CompareTag ("EndSaw")) 
		{
			//... then set the other object we just collided with to inactive.
			Destroy(gameObject); 
		}

	}
}
