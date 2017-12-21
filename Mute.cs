using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CnControls;

public class Mute : MonoBehaviour {

	bool isMute;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void MuteButton ()
	{
		isMute = ! isMute;
		AudioListener.volume =  isMute ? 0 : 1;
	}
}
