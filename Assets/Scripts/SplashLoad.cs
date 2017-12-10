using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashLoad : MonoBehaviour {

	public float delay = 5;
	public string scene;

	void Start(){
		StartCoroutine (SplashLoadTimer (delay));
	}

	IEnumerator SplashLoadTimer(float delay){
		yield return new WaitForSeconds (delay);
		SceneManager.LoadScene(scene);
	}		
}
