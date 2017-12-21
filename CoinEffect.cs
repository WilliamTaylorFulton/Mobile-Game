using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinEffect : MonoBehaviour {

		public GameObject explosion;
		public GameObject playerExplosion;

		void OnTriggerEnter(Collider other) 
		{
			if (other.tag == "Enemy")
			{
			Instantiate(explosion, transform.position, transform.rotation);

			}
			//Instantiate(explosion, transform.position, transform.rotation);
			if (other.tag == "Player")
			{
				Instantiate(playerExplosion, other.transform.position, other.transform.rotation);

			}
			Destroy(other.gameObject);
			Destroy(gameObject);
		}
}
