using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverConditions : MonoBehaviour 
{
	public static GameOverConditions GameOver;
	public float maxDebt;
	public float maxDays;
	public float minDebt;

	//TODO make the hospital feature to restore health to prevent inevitable death.
	// TODO Make loan time based, and loanshark hurt player if debt goes too long.

	void Update () {
		gameOverDebt ();
		gameOverDeath ();
		gameOverTime ();
	}

	// sets the debt related lose condition
	
	public void gameOverDebt()
	{
		if (PlayerCharacter.playChar.debtLeft >= maxDebt)
			SceneManager.LoadScene("01d Lose");
	}

	public void gameOverDeath()
	{
		if (PlayerCharacter.playChar.health <= 0) 
		{
			SceneManager.LoadScene ("01d Lose 1");
		}

	}

	public void gameOverTime()
	{
		if (PlayerCharacter.playChar.days >= PlayerCharacter.playChar.maxGameDays) 
		{
			SceneManager.LoadScene ("01d Lose 1");
		}

	}

}
