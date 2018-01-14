using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	bool isGameEnded = false;
	public GameObject panelLevelComplete;

	public float restartDelay = 2f;

	public void StartGame() {
		Debug.Log ("Start Game");
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}

	public void FinishLevel() {
		FindObjectOfType<AudioManager> ().Play ("PlayerWin");
		panelLevelComplete.SetActive(true);
	}

	public void EndGame() {
		if (!isGameEnded) {
			isGameEnded = true;
			Debug.Log ("Game OVer");
			Invoke ("Restart", restartDelay);
		}
	}

	public void Restart() {
		FindObjectOfType<AudioManager> ().Play ("MusicTheme");
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
}
