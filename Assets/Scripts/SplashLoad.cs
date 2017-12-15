using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashLoad : MonoBehaviour {

	public float delay = 5;
	public string scene;

	void Start()
	{
		// when the scene is loaded, wait a few seconds then change the scene
		StartCoroutine (SplashLoadTimer (delay));
	}

	IEnumerator SplashLoadTimer(float delay){
		yield return new WaitForSeconds (delay);
		SceneManager.LoadScene(scene);
	}		
}
