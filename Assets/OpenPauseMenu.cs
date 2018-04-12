using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPauseMenu : MonoBehaviour {

	public GameObject PauseMenu;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		var open = Input.GetButton("Cancel");

		if (open) {
			PauseMenu.SetActive (true);
		}
	}
}
