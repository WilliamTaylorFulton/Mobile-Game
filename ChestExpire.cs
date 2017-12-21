using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestExpire : MonoBehaviour {

	private float time = 3.0f; 

	// Update is called once per frame
	void Update () 
	{
		Destroy (gameObject, time); 
	}
}
