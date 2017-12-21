using UnityEngine;
using System.Collections;
using System.Collections.Generic;
//Adding this allows us to access members of the UI namespace including Text.
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using CnControls;
public class CompletePlayerController : MonoBehaviour {

	// TEXT		
	public Text countText;	
	public Text countTextBack; 
	public Text loseText;
	public Text loseTextBack;
	public Text timeText; 
	public Text timeTextBack; 
	public Text timeAdd; 
	public Text timeAddBack; 
	public Text finalScore; 
	public Text finalScoreBack; 
	public Text highScore;
	public Text highScoreBack; 
	public Text newHighScore;
	public Text newHighScoreBack;
	public Text total; 
	public Text totalBack; 
	public GameObject totalCoin; 

	private int totalScore;  


	// BUTTONS
	public GameObject PlayAgainButton;
	public GameObject HomeButton;
	public GameObject PauseButton; 

	public GameObject HomeButtonDeath;
	public GameObject ToCharButton; 


	// PLAYER
	public GameObject player; 
	private Rigidbody2D rb2d;	
	public float speed;
	private int count;				
	public float jumpHeight = 150;
	public float timeLeft = 30;  
	private int highscore; 
	public GameObject blood; 
	public GameObject goldExplode; 
	public GameObject goldExplodeChest; 


	public GameObject LeftEye; 
	public GameObject RightEye; 
	public AudioClip[] audioClip;

	bool isMute;


// START
	void Start()
	{
		count = 0;
		rb2d = GetComponent<Rigidbody2D> ();
		loseText.text = "";
		totalScore = PlayerPrefs.GetInt("Total");

		PauseButton.gameObject.SetActive (true);  
		HomeButton.gameObject.SetActive(true);
		//totalCoin.gameObject.SetActive (false); 
		PlayAgainButton.gameObject.SetActive(false);
		HomeButtonDeath.gameObject.SetActive(false);
		ToCharButton.gameObject.SetActive (false); 
		totalCoin.gameObject.SetActive (false);
	}

// UPDATE
	void Update ()
	{
		timeLeft -= Time.deltaTime;
		timeText.text = timeLeft.ToString ("F1");  
		timeTextBack.text = timeLeft.ToString ("F1");  

		// Gameover at 0:00
		if (timeLeft <= 0.0) {
			gameObject.SetActive (false);
			GameOver ();
		}	
		countText.text = count + ""; //display score
		countTextBack.text = count + ""; //display score
	 
		if (CnInputManager.GetButtonDown ("Jump")) {
			PlaySound (2); 
			rb2d.AddForce (Vector2.up * jumpHeight);
			
		}

		if (CnInputManager.GetButtonDown("Mute"))
			{
				MuteButton();
			}

	
	}


// MUTE BUTTON
	public void MuteButton ()
	{
			isMute = !isMute;
			AudioListener.volume =  isMute ? 0 : 1;
	}




//FIXED_UPDATE
	void FixedUpdate()
	{
		float horizontal = CnInputManager.GetAxis ("Horizontal");
		Vector2 movement = new Vector2 (horizontal, 0);
		rb2d.AddForce (movement * speed);
	}




// TRIGGER ENTER
	void OnTriggerEnter2D(Collider2D other) 
	{
		
		if (other.gameObject.CompareTag ("Chest")) 
		{
			Instantiate(goldExplodeChest, other.transform.position, other.transform.rotation);
			other.gameObject.SetActive(false); 
			timeLeft = timeLeft + 10; 
			count = (count + 10);
			AddTimeChest ();

		}

		if (other.gameObject.CompareTag ("PickUp")) 
		{
			Instantiate (goldExplode, other.transform.position, other.transform.rotation); 
			other.gameObject.SetActive (false);
			timeLeft = timeLeft + 1;
			count = count + 1;
			AddTimeCoin ();
		}

		if (other.gameObject.CompareTag("Enemy"))
		{
			Instantiate(blood, other.transform.position, other.transform.rotation);
			PlaySound (0);
			gameObject.SetActive(false); 
			GameOver (); 
		}
			
	}


//SOUND	
	void PlaySound (int clip)
	{
		AudioSource audio = GetComponent<AudioSource> ();
		audio.clip = audioClip [clip];
		audio.Play (1000); 
	}




// GAMEOVER
	void GameOver ()
	{
		PlayAgainButton.gameObject.SetActive(true);
		HomeButtonDeath.gameObject.SetActive (true); 
		ToCharButton.gameObject.SetActive (true); 
		totalCoin.gameObject.SetActive (true);
		HomeButton.gameObject.SetActive (false); 
		PauseButton.gameObject.SetActive (false); 


		loseText.text = "GAMEOVER \n";
		loseTextBack.text = "GAMEOVER \n";
		highScore.text = "High Score: " + PlayerPrefs.GetInt("Highscore");  
		highScoreBack.text = "High Score: " + PlayerPrefs.GetInt("Highscore");  
		FinalScore ();

		if (PlayerPrefs.GetInt ("Highscore") < count) 
		{ 
			//			timeAdd.canvasRenderer.SetAlpha( 1.0f );
			//PlaySound (3); 
			NewHigh(); 
			PlayerPrefs.SetInt ("Highscore", count);
			highScore.text = "High Score: " + PlayerPrefs.GetInt("Highscore");  
			highScoreBack.text = "High Score: " + PlayerPrefs.GetInt("Highscore");
		}

		Destroy (countText);  
		Destroy (countTextBack); 
		Destroy (timeText);
		Destroy (timeTextBack); 

		totalScore = totalScore + count; 
		PlayerPrefs.SetInt("Total", totalScore);
		total.text = "" + PlayerPrefs.GetInt("Total");
		totalBack.text = "" + PlayerPrefs.GetInt("Total");
		//PlayerPrefs.DeleteKey("Highscore");
	}


// COIN ADD TIME
	void AddTimeCoin ()
	{
		timeAdd.canvasRenderer.SetAlpha( 1.0f );
		timeAdd.CrossFadeAlpha( 0.0f, 1.5f, false );
		timeAddBack.canvasRenderer.SetAlpha( 1.0f );
		timeAddBack.CrossFadeAlpha( 0.0f, 1.5f, false );

		timeAdd.text = "+1";
		timeAddBack.text = "+1";
	}


// COIN ADD CHEST
	void AddTimeChest ()
	{
		timeAdd.canvasRenderer.SetAlpha( 1.0f );
		timeAdd.CrossFadeAlpha( 0.0f, 1.5f, false );
		timeAddBack.canvasRenderer.SetAlpha( 1.0f );
		timeAddBack.CrossFadeAlpha( 0.0f, 1.5f, false );
		//count = (count + 5);
		timeAdd.text = "+10";
		timeAddBack.text = "+10";
	}


// FINAL SCORE
	void FinalScore ()
	{
		finalScore.text = "Final Score: " + count;
		finalScoreBack.text = "Final Score: " + count;
	}

//	void TotalScore()
//	{
//		totalScore = PlayerPrefs.GetInt("Total");
//
//		total.text = "" + totalScore;
//	}
//		
	void NewHigh ()
	{
		newHighScore.canvasRenderer.SetAlpha( 1.0f );
		newHighScore.CrossFadeAlpha( 0.0f, 5f, false );
		newHighScoreBack.canvasRenderer.SetAlpha( 1.0f );
		newHighScoreBack.CrossFadeAlpha( 0.0f, 5f, false );
		newHighScore.text = "New High Score! "; 
		newHighScoreBack.text = "New High Score! "; 

	}


//	void Explosion (Collider2D other)
//	{
//		//Instantiate (goldExplode, other.transform.position, other.transform.rotation);
//		Instantiate (goldExplode); 
//
//	}
}
