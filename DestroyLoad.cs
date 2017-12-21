using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyLoad : MonoBehaviour {


		void Awake() 
		{  
		GameObject.Find ("AudioHold");
		Destroy (this.gameObject);
	
		}

	}
