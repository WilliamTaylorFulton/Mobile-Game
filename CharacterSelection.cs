using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharacterSelection : MonoBehaviour {

	private GameObject[] characterList; 
	//public GameObject[] charButtons; 
	private int index; 
	public Button Locked;


	// Use this for initialization
	private void Start () 
	{
		//int unlocked = PlayerPrefs.GetInt ("Total");

		index = PlayerPrefs.GetInt ("CharacterSelected"); 
		//  (1.) fill array with object 
		characterList = new GameObject[transform.childCount];  
		for (int i = 0; i < transform.childCount; i++) // for every child I have
		{
			characterList [i] = transform.GetChild (i).gameObject; 
		}

		//   (2.) Make sure no characters active at start 
		// make sure none are visible at start 
		foreach (GameObject go in characterList) 
		{
			go.SetActive(false);
		}

		//   (3.) Toggle on first index
		if (characterList [index]) 
		{
			characterList [index].SetActive (true); 
		}

	}
		


	public void Baby()
	{
		// Toggle off current
		characterList[index].SetActive(false); 
		index = 0; 
		characterList [index].SetActive (true); 

	}
	public void Bones()
	{
		characterList[index].SetActive(false); 
		index = 1; 
		characterList[index].SetActive(true); 
	}
	public void Bozo()
	{
		// Toggle off current
		characterList[index].SetActive(false); 
		index = 2; 
		characterList[index].SetActive(true); 
	}
	public void Buckets()
	{
		characterList[index].SetActive(false); 
		index = 3; 
		characterList[index].SetActive(true); 
	}
	public void Chief()
	{
		// Toggle off current
		characterList[index].SetActive(false); 
		index = 4; 
		characterList[index].SetActive(true); 
	}
	public void DeadLake()
	{
		characterList[index].SetActive(false); 
		index = 5; 
		characterList[index].SetActive(true); 
	}
	public void Dracula()
	{
		// Toggle off current
		characterList[index].SetActive(false); 
		index = 6; 
		characterList[index].SetActive(true); 
	}
	public void Footy()
	{
		characterList[index].SetActive(false); 
		index = 7; 
		characterList[index].SetActive(true); 
	}
	public void Frank()
	{
		// Toggle off current
		characterList[index].SetActive(false); 
		index = 8; 
		characterList[index].SetActive(true); 
	}
	public void Homer()
	{
		characterList[index].SetActive(false); 
		index = 9; 
		characterList[index].SetActive(true); 
	}
	public void Irex()
	{
		// Toggle off current
		characterList[index].SetActive(false); 
		index = 10; 
		characterList[index].SetActive(true); 
	}
	public void Kimmy()
	{
		characterList[index].SetActive(false); 
		index = 11; 
		characterList[index].SetActive(true); 
	}
	public void MrFancy()
	{
		// Toggle off current
		characterList[index].SetActive(false); 
		index = 12; 
		characterList[index].SetActive(true); 
	}
	public void MrPres()
	{
		characterList[index].SetActive(false); 
		index = 13; 
		characterList[index].SetActive(true); 
	}
	public void Oldie()
	{
		// Toggle off current
		characterList[index].SetActive(false); 
		index = 14; 
		characterList[index].SetActive(true); 
	}
	public void Penny()
	{
		characterList[index].SetActive(false); 
		index = 15; 
		characterList[index].SetActive(true); 
	}
	public void Prankster()
	{
		characterList[index].SetActive(false); 
		index = 16; 
		characterList[index].SetActive(true); 
	}
	public void Sammy()
	{
		characterList[index].SetActive(false); 
		index = 17; 
		characterList[index].SetActive(true); 
	}
	public void Teley()
	{
		characterList[index].SetActive(false); 
		index = 18; 
		characterList[index].SetActive(true); 
	}
	public void Wiz()
	{
		characterList[index].SetActive(false); 
		index = 19; 
		characterList[index].SetActive(true); 
	}

	public void Yin()
	{
		characterList[index].SetActive(false); 
		index = 20; 
		characterList[index].SetActive(true); 
	}
	public void EightBall()
	{
		characterList[index].SetActive(false); 
		index = 21; 
		characterList[index].SetActive(true); 
	}
	public void Albert()
	{
		characterList[index].SetActive(false); 
		index = 22; 
		characterList[index].SetActive(true); 
	}
	public void Bloom()
	{
		characterList[index].SetActive(false); 
		index = 23; 
		characterList[index].SetActive(true); 
	}
	public void Bob()
	{
		characterList[index].SetActive(false); 
		index = 24; 
		characterList[index].SetActive(true); 
	}
	public void Burnt()
	{
		characterList[index].SetActive(false); 
		index = 25; 
		characterList[index].SetActive(true); 
	}
	public void Drip()
	{
		characterList[index].SetActive(false); 
		index = 26; 
		characterList[index].SetActive(true); 
	}
	public void Dwight()
	{
		characterList[index].SetActive(false); 
		index = 27; 
		characterList[index].SetActive(true); 
	}
	public void Elvis()
	{
		characterList[index].SetActive(false); 
		index = 28; 
		characterList[index].SetActive(true); 
	}
	public void Fry()
	{
		characterList[index].SetActive(false); 
		index = 29; 
		characterList[index].SetActive(true); 
	}
	public void HotDog()
	{
		characterList[index].SetActive(false); 
		index = 30; 
		characterList[index].SetActive(true); 
	}
	public void King()
	{
		characterList[index].SetActive(false); 
		index = 31; 
		characterList[index].SetActive(true); 
	}
	public void Nash()
	{
		characterList[index].SetActive(false); 
		index = 32; 
		characterList[index].SetActive(true); 
	}
	public void Peg()
	{
		characterList[index].SetActive(false); 
		index = 33; 
		characterList[index].SetActive(true); 
	}
	public void Peppy()
	{
		characterList[index].SetActive(false); 
		index = 34; 
		characterList[index].SetActive(true); 
	}

	public void Cup()
	{
		characterList[index].SetActive(false); 
		index = 35; 
		characterList[index].SetActive(true); 
	}

	public void Doctor()
	{
		characterList[index].SetActive(false); 
		index = 36; 
		characterList[index].SetActive(true); 
	}

	public void Fuse()
	{
		characterList[index].SetActive(false); 
		index = 37; 
		characterList[index].SetActive(true); 
	}

	public void Jason()
	{
		characterList[index].SetActive(false); 
		index = 38; 
		characterList[index].SetActive(true); 
	}

	public void Kode()
	{
		characterList[index].SetActive(false); 
		index = 39; 
		characterList[index].SetActive(true); 
	}


	public void Confirm ()
	{
		PlayerPrefs.SetInt ("CharacterSelected", index); 
		SceneManager.LoadScene ("PlatformerScene"); 
	}
		
	

}
