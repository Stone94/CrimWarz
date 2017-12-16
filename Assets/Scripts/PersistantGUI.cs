using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PersistantGUI : MonoBehaviour {

	public static PersistantGUI GUI;

	public Text dateDisp, timeDisp, moneyDisp, debtDisp, cryptoDisp, 
		playerHealthDisp, playerRepDisp;

	
	// Update is called once per frame
	void Update () 
	{
		UpdateUI ();
	}

	// update the players UI each frame
	//TODO Round the values to 2 decimal places
	public void UpdateUI ()
	{
		playerHealthDisp.text = "Health: " + PlayerCharacter.playChar.health;
		playerRepDisp.text = "Rep: " + PlayerCharacter.playChar.rep;
		dateDisp.text = "Days: " + PlayerCharacter.playChar.days;
		timeDisp.text = "Time: " + PlayerCharacter.playChar.hours;
		moneyDisp.text = "Cash: $" + PlayerCharacter.playChar.cash;
		debtDisp.text = "Debt: $" + PlayerCharacter.playChar.debtLeft;
		cryptoDisp.text = "Crypto: $" + PlayerCharacter.playChar.cryptoC;
	}
}
