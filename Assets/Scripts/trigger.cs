using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class trigger : MonoBehaviour {

	int siralama=1;
	public Canvas finish;
	public Text sonuc1;
	public Text sonuc2;
	public Text sonuc3;
	public Text sonuc4;


	void Start(){

		foreach(Canvas i in finish.gameObject.GetComponentsInChildren<Canvas>())
		{
			i.enabled = false;
		}
		sonuc1.GetComponent<Text> ();
		sonuc2.GetComponent<Text> ();
		sonuc3.GetComponent<Text> ();
		sonuc4.GetComponent<Text> ();
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name=="Horse1") {
			if (siralama == 1) {
				sonuc1.text = "1.sırada Horse1";
			} else if (siralama == 2) {
				sonuc2.text = "2.sırada Horse1";
			}
			else if (siralama == 3) {
				sonuc3.text = "3.sırada Horse1";
			}
			else if (siralama == 4) {
				sonuc4.text = "4.sırada Horse1";
			}
		}

		if (other.gameObject.name=="Horse2") {
			if (siralama == 1) {
				sonuc1.text = "1.sırada Horse2";
			} else if (siralama == 2) {
				sonuc2.text = "2.sırada Horse2";
			}
			else if (siralama == 3) {
				sonuc3.text = "3.sırada Horse2";
			}
			else if (siralama == 4) {
				sonuc4.text = "4.sırada Horse2";
			}
		}

		if (other.gameObject.name=="Horse3") {
			if (siralama == 1) {
				sonuc1.text = "1.sırada Horse3";
			} else if (siralama == 2) {
				sonuc2.text = "2.sırada Horse3";
			}
			else if (siralama == 3) {
				sonuc3.text = "3.sırada Horse3";
			}
			else if (siralama == 4) {
				sonuc4.text = "4.sırada Horse3";
			}
		}

		if (other.gameObject.name=="Horse4") {
			if (siralama == 1) {
				sonuc1.text = "1.sırada Horse4";
			} else if (siralama == 2) {
				sonuc2.text = "2.sırada Horse4";
			}
			else if (siralama == 3) {
				sonuc3.text = "3.sırada Horse4";
			}
			else if (siralama == 4) {
				sonuc4.text = "4.sırada Horse4";
			}
		}

		siralama += 1;
		if (siralama > 4) {

			finish.gameObject.GetComponent<Canvas> ().enabled = true;

		}
			
	}
		
}


