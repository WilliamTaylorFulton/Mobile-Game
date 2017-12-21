using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using CnControls;
public class Contain : MonoBehaviour {

	private List<GameObject> models;
	// Default index of characters
	private int selectionIndex = 0; 
	private bool load; 
	private void Start () 
	{
		models = new List<GameObject> ();
		foreach (Transform t in transform) 
		{
			models.Add (t.gameObject); 
			t.gameObject.SetActive (false); 
		}
		models [selectionIndex].SetActive (true); 
	}
	public void Update ()
	{
		
	}


	public void Select (int index)
	{
		if (index == selectionIndex) 
		{
			return; 
		}
		if (index < 0 || index >= models.Count)
		{
				return; 
		}
		models[selectionIndex].SetActive(false); 
		selectionIndex = index; 
		models [selectionIndex].SetActive (true);



	}

}
