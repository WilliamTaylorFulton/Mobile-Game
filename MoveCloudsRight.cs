using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class MoveCloudsRight: MonoBehaviour 
{
	public float speed;
	public GameObject Cloud; 

	void Start () {
		speed = 0.3f;

	}

	// Update is called once per frame
	void FixedUpdate () {

		goright();

	}

	void goright() {

		transform.position += Vector3.right * speed * Time.deltaTime;
	}
}