using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriChange : MonoBehaviour {
	public Sprite Coin1;
	public Sprite Coin2; 
	public Sprite Coin3; 
	public Sprite Coin4;
	public Sprite Coin5; 
	public Sprite Coin6; 
	public Sprite Coin7; 
	public Sprite Coin8; 
	public Sprite Coin9; 
	public Sprite Coin10; 
	public Sprite Coin11; 
	public Sprite Coin12; 
	public Sprite Coin13; 
	public Sprite Coin14; 
	public Sprite Coin15; 
	public Sprite Coin16; 
	public Sprite Coin17; 

	float timer = 0.05f;
	float delay = 0.05f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		timer -= Time.deltaTime;
		if (timer <= 0) 
		{
			if (this.gameObject.GetComponent<SpriteRenderer>().sprite == Coin1) 
			{
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Coin2;
				timer = delay; 
				return;
			}

			if (this.gameObject.GetComponent<SpriteRenderer> ().sprite == Coin2) 
			{
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Coin3;
				timer = delay; 
				return;
			}

			if (this.gameObject.GetComponent<SpriteRenderer> ().sprite == Coin3) 
			{
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Coin4;
				timer = delay; 
				return;
			}

			if (this.gameObject.GetComponent<SpriteRenderer> ().sprite == Coin4) 
			{
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Coin5;
				timer = delay; 
				return;
			}

			if (this.gameObject.GetComponent<SpriteRenderer> ().sprite == Coin5) 
			{
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Coin6;
				timer = delay; 
				return;
			}

			if (this.gameObject.GetComponent<SpriteRenderer> ().sprite == Coin6) 
			{
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Coin7;
				timer = delay; 
				return;
			}

			if (this.gameObject.GetComponent<SpriteRenderer> ().sprite == Coin7) 
			{
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Coin8;
				timer = delay; 
				return;
			}

			if (this.gameObject.GetComponent<SpriteRenderer> ().sprite == Coin8) 
			{
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Coin9;
				timer = delay; 
				return;
			}

			if (this.gameObject.GetComponent<SpriteRenderer> ().sprite == Coin9) 
			{
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Coin10;
				timer = delay; 
				return;
			}

			if (this.gameObject.GetComponent<SpriteRenderer> ().sprite == Coin10) 
			{
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Coin11;
				timer = delay; 
				return;
			}

			if (this.gameObject.GetComponent<SpriteRenderer> ().sprite == Coin11) 
			{
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Coin12;
				timer = delay; 
				return;
			}

			if (this.gameObject.GetComponent<SpriteRenderer> ().sprite == Coin12) 
			{
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Coin13;
				timer = delay; 
				return;
			}

			if (this.gameObject.GetComponent<SpriteRenderer> ().sprite == Coin13) 
			{
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Coin14;
				timer = delay; 
				return;
			}

			if (this.gameObject.GetComponent<SpriteRenderer> ().sprite == Coin14) 
			{
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Coin15;
				timer = delay; 
				return;
			}

			if (this.gameObject.GetComponent<SpriteRenderer> ().sprite == Coin15) 
			{
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Coin16;
				timer = delay; 
				return;
			}

			if (this.gameObject.GetComponent<SpriteRenderer> ().sprite == Coin16) 
			{
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Coin17;
				timer = delay; 
				return;
			}

			if (this.gameObject.GetComponent<SpriteRenderer> ().sprite == Coin17) 
			{
				this.gameObject.GetComponent<SpriteRenderer> ().sprite = Coin2;
				timer = delay; 
				return;
			}


		}
	}
}
