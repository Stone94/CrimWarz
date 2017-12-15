using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePause : MonoBehaviour 
{
	public GameObject Pause;

	public bool Paused = false;

	void Start()
	{
		Paused = false; // Is the game paused?
	}

	void Update()
	{
		PauseInputController ();
	}

	// Button to pause the game.
	void PauseInputController ()
	{
		if (Input.GetKeyDown (KeyCode.Tab) || Input.GetKeyDown (KeyCode.Escape)) {
			Paused = !Paused;
			Time.timeScale = Paused ? 0 : 1;
		}
		// If the game is paused, open the pause panel
		if (Paused) {
			Pause.SetActive (true);
		}
		else {
			Pause.SetActive (false);
		}
	}
}
