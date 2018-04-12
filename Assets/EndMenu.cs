﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour {

	public static bool GameIsPaused = false;

	public GameObject endMenuUI;
	public GameObject gameUI;

	void Update () {
	}

	public void LoadMenu() {
		Time.timeScale = 1f;
		SceneManager.LoadScene ("Menu");
	}

	public void QuitGame() {
		Application.Quit ();
	}
}
