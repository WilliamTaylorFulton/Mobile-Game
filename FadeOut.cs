using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class FadeOut : MonoBehaviour
{
	public Text timeAdd; 
	public Text playAgain; 

	void Start ()
	{
		timeAdd.canvasRenderer.SetAlpha( 0.0f );
		timeAdd.CrossFadeAlpha( 1.0f, 5.0f, false );


	}
		
	
}