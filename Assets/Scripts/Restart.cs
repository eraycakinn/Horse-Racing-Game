using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

	public void RestartGame()
	{
		SceneManager.LoadScene("Horse Game");
	}
	void Start(){
		Time.timeScale = 1;
	}
		
}
