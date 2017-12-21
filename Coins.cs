using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour {
	public float delay = 0.1f;
	public float delaySaw = 1.0f;
	public float delaySlowMace = 10.0f;
	private float foreverDelay = 1000000.0f;
	public GameObject Coin; 
	public GameObject Mace;
	public GameObject SawLeft;
	public GameObject SawRight;
	public GameObject MaceSlow;
	public GameObject stopSpawn; 

	//public GameObject Chest; 

	public float posX = 1f; // Offset
	int count = 0; 

	//public GameObject Saw; 
	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spawn", delay, delay); 
		InvokeRepeating ("SpawnSaws", delaySaw, delaySaw); 
		InvokeRepeating ("SpawnSlowMace", delaySlowMace, delaySlowMace); 
	}

	// Update is called once per frame
	void Spawn () {
		// Spawn between -7 and 9
		// How many we will spawn (1)
		// 0 z value
	
		count = count + 1; 
		if (stopSpawn.activeInHierarchy == false)
		{
			Instantiate (Coin, new Vector3 (Random.Range (-2.4f, 2.4f), 7, 0), Quaternion.identity); 
			Instantiate (Mace, new Vector3 (Random.Range (-2.4f, 2.4f), 10, 0), Quaternion.identity);
		}
		
		//Instantiate (SawLeft, new Vector3(-2,16, 0), Quaternion.identity);
		//Instantiate (SawRight, new Vector3( 2,16, 0), Quaternion.identity);

//		if (count > 5) 
//		{
//			Instantiate (MaceSlow, new Vector3(Random.Range(-3, 3),10, 0), Quaternion.identity);
//
////			if (count > 10) 
////			{
////				Instantiate (Mace, new Vector3(Random.Range(-3, 3),10, 0), Quaternion.identity);
////
////
////			}
//
//		}

	}
	void SpawnSaws () {

		if (stopSpawn.activeInHierarchy == false) {
			count = count + 1; 
			Instantiate (SawLeft, new Vector3 (-2.8f, 8, 0), Quaternion.identity);
			Instantiate (SawRight, new Vector3 (2.8f, 8, 0), Quaternion.identity);
		}
		//		if (count > 5) 
		//		{
		//			Instantiate (MaceSlow, new Vector3(Random.Range(-3, 3),10, 0), Quaternion.identity);
		//
		////			if (count > 10) 
		////			{
		////				Instantiate (Mace, new Vector3(Random.Range(-3, 3),10, 0), Quaternion.identity);
		////
		////
		////			}
		//
		//		}

	}
//	void SpawnSlowMace ()
//	{
//		Instantiate (MaceSlow, new Vector3(-2.2f,5, 0), Quaternion.identity);
//	}
		

}
