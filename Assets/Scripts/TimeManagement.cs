﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeManagement : MonoBehaviour 
{
	//TODO make a more realistic date and time based on a calender
	//TODO Make events that can severely lower or raise product prices
	//TODO Make this only start when the game has started and player is not in main menu
	public float timeScaleDelay;
	public double bankInterestRate;

	void Awake ()
	{
		GetComponent <Drugs>();
	}

	void Start ()
	{
		StartCoroutine (time ());
	}


	// creates the timer, this will increment the hours by 1 and will increase debt, bank cash, and rep each day or every 24 ingame hours.
	private void timeAdd()
	{
		if (SceneManager.GetActiveScene ().buildIndex!=0 && SceneManager.GetActiveScene ().buildIndex !=1 && SceneManager.GetActiveScene ().buildIndex !=2) {
			
			PlayerCharacter.playChar.hours += 1;

			if (PlayerCharacter.playChar.hours >= 24) {
				PlayerCharacter.playChar.days += 1;
				PlayerCharacter.playChar.hours = 0;
				PlayerCharacter.playChar.debtLeft *= PlayerCharacter.playChar.debtInterestRate;
				PlayerCharacter.playChar.bankBalance = (PlayerCharacter.playChar.bankBalance + PlayerCharacter.playChar.rep) * bankInterestRate;
				PlayerCharacter.playChar.rep += 5;
			}
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
