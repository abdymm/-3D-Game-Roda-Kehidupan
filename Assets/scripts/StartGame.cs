﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

	public void Begin() {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}

}
