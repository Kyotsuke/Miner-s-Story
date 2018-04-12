using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour {

	public float countdown;
	public Text TimerText;
	public GameObject endMenuUI;
	public GameObject gameUI;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		countdown -= Time.deltaTime;

		int minutes = Mathf.FloorToInt(countdown / 60F);
		int seconds = Mathf.FloorToInt(countdown - minutes * 60);
		string niceTime = string.Format("{0:0}:{1:00}", minutes, seconds);

		TimerText.text = niceTime;

		if (countdown <= 0) {
			endMenuUI.SetActive (true);
			gameUI.SetActive (false);
		}
	}
}
