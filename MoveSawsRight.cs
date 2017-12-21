using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class MoveSawsRight: MonoBehaviour 
{
	public float speed;
	public GameObject SawRight; 

	void Start () {
		speed = 2.0f;

	}

	// Update is called once per frame
	void FixedUpdate () {

		goright();

	}

	void goright() {

		transform.position += Vector3.right * speed * Time.deltaTime;
	}
}