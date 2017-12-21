using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TotPref : MonoBehaviour {
	public Text total; 
	public Text totalBack; 
	// Use this for initialization
	void Start () 
	{
		PlayerPrefs.GetInt ("Total", 200); 
		total.text = "" + PlayerPrefs.GetInt("Total");
		totalBack.text = "" + PlayerPrefs.GetInt("Total");
	}

}
