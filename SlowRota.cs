using UnityEngine;
using System.Collections;

public class SlowRota : MonoBehaviour {

	//Update is called every frame
	void Update () 
	{
		//Rotate thet transform of the game object this is attached to by 45 degrees, taking into account the time elapsed since last frame.
		transform.Rotate (new Vector3 (0, 0, 10) * Time.deltaTime);
	}
}
