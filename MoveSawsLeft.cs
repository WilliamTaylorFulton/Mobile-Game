using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class MoveSawsLeft : MonoBehaviour 
{
	public float speed;
	public GameObject Saw; 

	void Start () {
		speed = 2.0f;

	}

	// Update is called once per frame
	void FixedUpdate () {

		goleft();

	}

	void goleft() {
		
			transform.position += Vector3.left * speed * Time.deltaTime;
	}
}