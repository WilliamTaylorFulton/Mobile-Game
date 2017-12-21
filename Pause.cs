using UnityEngine;
using System.Collections;
using CnControls;


public class Pause : MonoBehaviour {
	bool isMute;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void PauseButtonFunction()
	{
		
		if (Time.timeScale == 1)
		{
			Time.timeScale = 0;
		}
		else if (Time.timeScale == 0)
		{
			Time.timeScale = 1;
		}
	}
//	public void MuteButton ()
//	{
//		AudioListener.volume = 0;
//	}
	public void MuteButton ()
	{
		isMute = ! isMute;
		AudioListener.volume = 0;
	}
}