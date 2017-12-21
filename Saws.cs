using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saws : MonoBehaviour {
	public float wait = 10f;
	public GameObject Saw; 
	void Start () {
		
		InvokeRepeating ("SpawnSaw", wait, wait); 
	}

	// Update is called once per frame
	void FixedUpdate () {
		SpawnSaw();

	}
//
//	void goleft() {
//		SpawnSaw (); 
//		//transform.position += Vector3.left *speed* Time.deltaTime;
//	}
//
	void SpawnSaw () {
		// Spawn between -7 and 9
		// How many we will spawn (1)
		// 0 z value

		Instantiate (Saw, new Vector3(15,-4, 0), Quaternion.identity); 
		



	}
}