using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineralsCollision : MonoBehaviour {

	public float value;
	public float tryNb;
	public MoneyScript _MoneyScript;

	public ParticleSystem particule;

	void OnTriggerEnter(Collider collider) {

		if (collider.name == "Tool") {
			particule.Play();

			_MoneyScript.setValue (value);
			tryNb--;

			if (tryNb <= 0) {
				Destroy(gameObject);
			}
		}
	}
}
