﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuMgr : MonoBehaviour 
{
	public void ToGame ()
	{
		SceneManager.LoadScene ("PlatformerScene"); 
	}


}
