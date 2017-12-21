using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LockChars : MonoBehaviour
{
	void Start ()
	{
		int playerStyle = PlayerPrefs.GetInt("Total");
		PlayerPrefs.SetInt("Total", playerStyle + 500);

	}
//	public void Lock ()
//	{
//
////		if (PlayerPrefs.GetInt ("Total") < 50) 
////		{
////			
////			int playerStyle = PlayerPrefs.GetInt("Total");

////			gameObject.SetActive(false);
////		}
////
//	}
}
