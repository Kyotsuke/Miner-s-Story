using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public float MoveSpeed;
	public float CameraSpeed;

	private Transform player;
	private float BaseSpeed;
	private float SprintSpeed;

	// Use this for initialization
	void Start () {
		BaseSpeed = MoveSpeed;
		SprintSpeed = MoveSpeed * 2;
	}

	// Update is called once per frame
	void Update () {
		player = this.gameObject.transform.GetChild(0);
		var vertical = Input.GetButton("Vertical");
		var horizontal = Input.GetButton("Horizontal");
		var run = Input.GetButton("Fire3");

		if (run) {
			MoveSpeed = SprintSpeed;
		}

		if (!run) {
			MoveSpeed = BaseSpeed;
		}

		var x = Input.GetAxis("Vertical") * MoveSpeed;
		var z = Input.GetAxis("Horizontal") * MoveSpeed;

		var rotate = Input.GetButton("Fire2");
		var y = Input.GetAxis ("Mouse X") * Time.deltaTime * CameraSpeed;

		player.Translate(0, 0, -z);
		player.Translate(x, 0, 0);

		if (rotate) {
			player.Rotate(0, y, 0);
		}
	}
}
