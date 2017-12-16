using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour 
{
	//TODO Set a delay on loading level, 
	//TODO change time upon traveling
	public void LoadLevelStart(string name)
	{
		SceneManager.LoadScene (name);
	}

	public void LoadLevel(string name)
	{
		SceneManager.LoadScene (name);
	}

	public void Quit()
	{
		Application.Quit();
	}
}
