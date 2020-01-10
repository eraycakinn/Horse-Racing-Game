using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	public Rigidbody rb;
	public float hiz=10.0f;
	public float hizlanma;
	public int max_hiz;
	Animator anim;
	private float seconds=3;
	private float timer;
	AudioSource horseRun;

	void Start () 
	{
		rb.GetComponents<Rigidbody>();
		anim = gameObject.GetComponent<Animator> ();
		anim.SetBool ("isRunning", false);
		horseRun=GameObject.FindWithTag("horseRunVoice").GetComponent<AudioSource> ();
		horseRun.PlayDelayed (3);

	}

	void Update(){
		timer += Time.deltaTime;
		if (timer > seconds)
		{
			anim.SetBool ("isRunning", true);

		
			hizlanma = Random.Range (10, 20) * Time.deltaTime;
			max_hiz = Random.Range (20, 50);

			if (hiz <= max_hiz) {
				hiz += hizlanma;
			} else {
				hiz -= hizlanma;
			}

			rb.transform.Translate (Vector3.forward * hiz * Time.deltaTime);

		}
	}
}
