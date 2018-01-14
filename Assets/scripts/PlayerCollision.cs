using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	public PlayerMovement playerMovement;

	void OnCollisionEnter(Collision collisionInfo) {
		string collisionTag = collisionInfo.collider.tag;

		if (collisionTag == "obstacle") {
			playerMovement.enabled = false;

			FindObjectOfType<AudioManager> ().Play ("PlayerCrash");
			FindObjectOfType<AudioManager> ().Stop ("MusicTheme");


			FindObjectOfType<GameManager> ().EndGame ();
		

		}

	}
}
