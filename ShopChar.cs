using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopChar : MonoBehaviour 
{
	int coinAmount;
	int characterSold;

	public Text coinAmountText;
	public Text coinAmountTextBack; 

	// Use this for initialization
	public Button buyChar;

	void Start () 
	{
		coinAmount = PlayerPrefs.GetInt ("Total");
	}
	
	// Update is called once per frame
	void Update () 
	{
		//characterSold = PlayerPrefs.GetInt ("characterSold");
		if (coinAmount >= 50)// && characterSold == 0) 
		{
			buyChar.interactable = true;
		}
		coinAmount = PlayerPrefs.GetInt ("Total");
			
	}

	public void buyCharacter ()
	{
		coinAmount -= 50; 
		PlayerPrefs.SetInt ("Total", coinAmount);
		//PlayerPrefs.SetInt ("characterSold", 1); 
		Destroy (buyChar); 
		buyChar.gameObject.SetActive (false);

	}

}
