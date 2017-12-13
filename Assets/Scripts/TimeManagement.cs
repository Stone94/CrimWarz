using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManagement : MonoBehaviour {

	void Start ()
	{
		StartCoroutine (time ());
	}


	// creates the timer
	private void timeAdd()
	{
		PlayerCharacter.playChar.hours += 1;

		if (PlayerCharacter.playChar.hours >= 24) 
		{
			PlayerCharacter.playChar.days += 1;
			PlayerCharacter.playChar.hours = 0;
			PlayerCharacter.playChar.debtLeft *= 1.10f;
			PlayerCharacter.playChar.bankBalance = PlayerCharacter.playChar.bankBalance;
			PlayerCharacter.playChar.rep += 1;
		}
	}

	// while time remains true wait one second then add time
	IEnumerator time()
	{
		while (true) 
		{
			timeAdd ();
			yield return new WaitForSeconds (2);
		}
	}
}
