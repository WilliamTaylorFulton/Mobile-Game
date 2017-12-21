using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharMenu : MonoBehaviour 
{
	public void ToChar ()
	{
		SceneManager.LoadScene ("CharacterMenu"); 
	}


}