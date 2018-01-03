using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour 
{
	public int travelTime;

	//TODO Set a delay on loading level, when ready to add animated scenes.
	
	public void LoadLevelStart(string name)
	{
		SceneManager.LoadScene (name);
	}
	
	public void LoadLevel(string name)
	{
			PlayerCharacter.playChar.hours += travelTime;
			SceneManager.LoadScene (name);
	}

	public void Quit()
	{
		Application.Quit();
	}
}
