using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour 
{
	public Text highScore; 
	public GameObject player; 
	private int count;

	void StoreHighscore(int newHighscore)
	{
		if (player.activeInHierarchy == false) {
			int oldHighscore = PlayerPrefs.GetInt ("highscore", 0);    
			if (newHighscore > oldHighscore) {
				PlayerPrefs.SetInt ("highscore", newHighscore);
				PlayerPrefs.Save (); 
			}
		}
	}
}
