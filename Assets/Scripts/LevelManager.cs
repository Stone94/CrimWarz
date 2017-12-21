using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour 
{
	public double taxiFare;

	//TODO Set a delay on loading level, 
	//TODO change time upon traveling
	public void LoadLevelStart(string name)
	{
		SceneManager.LoadScene (name);
	}
	//TODO Fix LEVEL "Travel" Buttons to use Level Start
	public void LoadLevel(string name)
	{
		if (PlayerCharacter.playChar.cash >= taxiFare) {
			PlayerCharacter.playChar.cash -= taxiFare;
			PlayerCharacter.playChar.hours += 2;
			SceneManager.LoadScene (name);
		}
	}

	public void Quit()
	{
		Application.Quit();
	}
}
