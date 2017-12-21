using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawn : MonoBehaviour {
	public float delay = 100.0f;
	public float delay2 = 75.0f;
	public float delay3 = 25.0f;
	public GameObject CloudHigh; 
	public GameObject CloudMid;
	public GameObject CloudLow;
	 


	//public GameObject Saw; 
	// Use this for initialization
	void Start () {
		InvokeRepeating ("SpawnHigh", delay, delay); 
		InvokeRepeating ("SpawnMid", delay2, delay2);
		InvokeRepeating ("SpawnLow", delay3, delay3);
	}

	// Update is called once per frame
	void SpawnHigh () 
	{
		Instantiate (CloudHigh, new Vector3(-5,Random.Range(3,5), 0), Quaternion.identity); 
		//Instantiate (CloudRight, new Vector3(-3,-4, 0), Quaternion.identity);

	}

	void SpawnMid () 
	{
		// Spawn between -7 and 9
		// How many we will spawn (1)
		// 0 z value
		//Instantiate (Cloud, new Vector3(3,-4, 0), Quaternion.identity); 
		Instantiate (CloudMid, new Vector3(-5,Random.Range(1,4), 0), Quaternion.identity);
		//.position = saw;
		//Instantiate (Saw, new Vector3(10,Random.Range(-6,6), 0), Quaternion.identity);


	}

	void SpawnLow () 
	{

		Instantiate (CloudLow, new Vector3(-4,(Random.Range(0,5)), 0), Quaternion.identity); 


	}

}