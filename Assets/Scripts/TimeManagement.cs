using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Apple.ReplayKit;

public class TimeManagement : MonoBehaviour 
{
	public float timeScaleDelay;
	public double bankInterestRate;

	void Start ()
	{
		StartCoroutine (time ());
	}


	// creates the timer, this will increment the hours by 1 and will increase debt, bank cash, and rep each day or every 24 ingame hours.
	private void timeAdd()
	{
		PlayerCharacter.playChar.hours += 1;

		if (PlayerCharacter.playChar.hours >= 24) 
		{
			PlayerCharacter.playChar.days += 1;
			PlayerCharacter.playChar.hours = 0;
			PlayerCharacter.playChar.debtLeft *= PlayerCharacter.playChar.debtInterestRate ;
			PlayerCharacter.playChar.bankBalance = (PlayerCharacter.playChar.bankBalance + PlayerCharacter.playChar.rep) * bankInterestRate;
			PlayerCharacter.playChar.rep += 5;
		}
	}

	// while the game is running and not paused, the time will increase by set seconds
	IEnumerator time()
	{
		while (true) 
		{
			timeAdd ();
			yield return new WaitForSeconds (timeScaleDelay);
		}
	}
}
