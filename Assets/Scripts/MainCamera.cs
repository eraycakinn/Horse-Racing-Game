using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MainCamera : MonoBehaviour {

	public GameObject cam;
	public GameObject finishline;
	public GameObject finishcam;
	public GameObject ortacam;
	float distanceToFinishLine;
	float distanceToOrtaCam;
	float timer;
	int seconds=6;
	public GameObject horse1,horse2,horse3,horse4;
	AudioSource horseRun;
	Canvas canvas;


	void Start () {
		cam.GetComponent<GameObject> ();
		finishline.GetComponent<GameObject> ();
		finishcam.GetComponent<GameObject> ();
		ortacam.GetComponent<GameObject> ();
		ortacam.SetActive (false);
		finishcam.SetActive (false);

		horseRun=GameObject.FindWithTag("horseRunVoice").GetComponent<AudioSource> ();
		canvas = GameObject.FindWithTag ("canvas").GetComponent<Canvas> ();

	}

	void Update ()
	{
	
		float horse1_pos = horse1.transform.position.x;
		float horse2_pos = horse2.transform.position.x;
		float horse3_pos = horse3.transform.position.x;
		float horse4_pos = horse4.transform.position.x;


		if (horse1_pos > horse2_pos && horse1_pos > horse3_pos && horse1_pos > horse4_pos) {
			
			if (!ortacam.activeSelf) {
				cam.transform.position = new Vector3 (horse1_pos + Time.deltaTime + 20f, 17.91f, -47.03f);
			} else {
				ortacam.transform.position = new Vector3 (horse1_pos + Time.deltaTime + 20f, 13.3f, -14.6f);
			}

		} else if (horse2_pos > horse1_pos && horse2_pos > horse3_pos && horse2_pos > horse4_pos) {
			
			if (!ortacam.activeSelf) {
				cam.transform.position = new Vector3 (horse2_pos + Time.deltaTime + 20f, 17.91f, -47.03f);
			} else {
				ortacam.transform.position = new Vector3 (horse2_pos + Time.deltaTime + 20f, 13.3f, -14.6f);
			}

		} else if (horse3_pos > horse1_pos && horse3_pos > horse2_pos && horse3_pos > horse4_pos) {
			
			if (!ortacam.activeSelf) {
				cam.transform.position = new Vector3 (horse3_pos + Time.deltaTime + 20f, 17.91f, -47.03f);
			} else {
				ortacam.transform.position = new Vector3 (horse3_pos + Time.deltaTime + 20f, 13.3f, -14.6f); //Kamera ileriden gitsin diye x eksenine 20 ekliyoruz.
			}

		} else if (horse4_pos > horse1_pos && horse4_pos > horse2_pos && horse4_pos > horse3_pos) {
			if (!ortacam.activeSelf) {
				cam.transform.position = new Vector3 (horse3_pos + Time.deltaTime + 20f, 17.91f, -47.03f);
			} else {
				ortacam.transform.position = new Vector3 (horse3_pos + Time.deltaTime + 20f, 13.3f, -14.6f);
			}
		}
			
		distanceToOrtaCam = ortacam.transform.position.x - cam.transform.position.x; 


		if (distanceToOrtaCam < 0) {
			ortacam.SetActive (true);

		}

		distanceToFinishLine = finishline.transform.position.x - ortacam.transform.position.x;

		if (distanceToFinishLine < -5) {
			
			timer += Time.deltaTime * 10;
			finishcam.SetActive (true);

			if (timer < seconds) {
				Time.timeScale = 0.1f;
				horseRun.pitch = 0.1f;
				horseRun.volume = 0.25f;

			} 
			else if(timer > seconds)
			{
				if (canvas.enabled == false) {
					
					Time.timeScale = 0.8f;
					horseRun.pitch = 0.52f;
				} 
				else {
					Time.timeScale = 0;
					horseRun.Stop ();
				}

			}

		}
	}
}