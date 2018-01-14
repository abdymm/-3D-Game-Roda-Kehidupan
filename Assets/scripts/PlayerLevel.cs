using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerLevel : MonoBehaviour {

	public Transform playerTransform;
	public Text levelText;

	// Update is called once per frame
	void Update () {
		levelText.text = "Level " + SceneManager.GetActiveScene ().buildIndex;
	}
}
