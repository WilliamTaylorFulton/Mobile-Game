﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blink : MonoBehaviour {

	public Sprite EyeOpen;
	public Sprite EyeLookLeft;
	public Sprite EyeLookRight;
	public Sprite EyeClosed; 

	float timer = 1.2f;
	float delay = 1.2f;
	void Update ()
	{
		timer -= Time.deltaTime;
		if (timer <= 0) {
			if (this.gameObject.GetComponent<SpriteRenderer> ().sprite == EyeOpen) {
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = EyeLookLeft;
				timer = delay; 
				return;
			}
			if (this.gameObject.GetComponent<SpriteRenderer> ().sprite == EyeLookLeft) {
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = EyeLookRight;
				timer = delay; 
				return;
			}
			if (this.gameObject.GetComponent<SpriteRenderer> ().sprite == EyeLookRight) {
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = EyeClosed;
				timer = (delay-1.0f); 
				return;
			}
			if (this.gameObject.GetComponent<SpriteRenderer> ().sprite == EyeClosed) {
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = EyeOpen;
				timer = delay; 
				return;
			}
		}
	}

}
