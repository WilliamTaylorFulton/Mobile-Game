using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawSpawn : MonoBehaviour {
	public float delay = 0.1f;
	public GameObject Saw; 
	public GameObject SawRight; 
	public GameObject stopSpawn; 


	//public GameObject Saw; 
	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spawn", delay, delay); 

	}

	// Update is called once per frame
	void Spawn () {
		// Spawn between -7 and 9
		// How many we will spawn (1)
		// 0 z value
		if (stopSpawn.activeInHierarchy == false) {
			Instantiate (Saw, new Vector3 (3, -4, 0), Quaternion.identity); 
			Instantiate (SawRight, new Vector3 (-3, -4, 0), Quaternion.identity);
		}
		//.position = saw;
		//Instantiate (Saw, new Vector3(10,Random.Range(-6,6), 0), Quaternion.identity);


	}

}
