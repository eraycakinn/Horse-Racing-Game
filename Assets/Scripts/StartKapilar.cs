using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartKapilar : MonoBehaviour {
	
	float seconds=2.8f;
	float timer;
	float speed=10f;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer >= seconds) {
			transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.Euler (0, 90, 0), Time.deltaTime*speed);

		}

	}
}
