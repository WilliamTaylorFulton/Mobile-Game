using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour {

	public Text playAgain; 
	public GameObject player; 


	void Update ()
	{
		
		PlayerDead (); 

	}
	void PlayerDead()
	{
		if (player.activeInHierarchy == false )
		{
			StartCoroutine(BlinkText());
		//	Again (); 
		}
	}
	// Update is called once per frame
//	void Again ()
//	{
//		if (Input.GetKeyDown(KeyCode.Y))
//		{
//			SceneManager.LoadScene ("Platformer"); 
//		}
//	}
//
	void Start(){
		//get the Text component
		playAgain = GetComponent<Text>();
		//Call coroutine BlinkText on Start
		StartCoroutine(BlinkText());
	}

	//function to blink the text 
	public IEnumerator BlinkText(){
		//blink it forever. You can set a terminating condition depending upon your requirement
		while(true){

			playAgain.text= " ";
			playAgain.canvasRenderer.SetAlpha( 1.0f );
			playAgain.CrossFadeAlpha( 0.0f, 3f, false );
			playAgain.text= "Play Again?";
			if (Input.GetKeyDown(KeyCode.Y))
			{
				SceneManager.LoadScene ("PlatformerScene"); 
			}

		}
	}

}
