﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolCollision : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		Debug.Log(other);
	}
}