using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverConditions : MonoBehaviour 
{
	public float maxDebt;
	public float maxDays;
	public float minDebt;
	//TODO make the hospital feature to restore health to prevent inevitable death.
	// Update is called once per frame
	void Update () {
		gameOverDebt ();
		gameOverDeath ();
	}

	// sets the debt related lose condition
	// TODO make the max debt and max days a public variable so we can change it from the editor for balance changes
	public void gameOverDebt()
	{
		if (PlayerCharacter.playChar.debtLeft >= maxDebt || PlayerCharacter.playChar.days >= maxDays && PlayerCharacter.playChar.debtLeft >= minDebt)
			SceneManager.LoadScene("01d Lose");
	}

	public void gameOverDeath()
	{
		if (PlayerCharacter.playChar.health <= 0) 
		{
			SceneManager.LoadScene ("01d Lose 1");
		}

	}

}
