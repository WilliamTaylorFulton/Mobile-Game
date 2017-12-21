using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Sound : MonoBehaviour 

{
	//public int delay; 
	public AudioClip[] audioSplat;
	 
	void Start ()
	{
		PlaySound (0); 

	}
	void PlaySound (int clip)
	{
		AudioSource audio = GetComponent<AudioSource> ();
		audio.clip = audioSplat [clip];
		audio.Play (1000); 
	}

}﻿
