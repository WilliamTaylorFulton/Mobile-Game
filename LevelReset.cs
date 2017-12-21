using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelReset : MonoBehaviour {

	public Text playAgain; 
	public Text playAgainBack; 
	public GameObject player; 


	public void Update ()
	{

		PlayerDead (); 

	}
	void PlayerDead()
	{
		if (player.activeInHierarchy == false )
		{
			Again (); 
		}
	}

	public void Again()
	{
		playAgain.text = "Tap to play again!"; 
		playAgainBack.text = "Tap to play again!"; 
		if(Input.GetMouseButtonDown(0))
		{
			SceneManager.LoadScene ("PlatformerScene"); 
		}
	}
		

}