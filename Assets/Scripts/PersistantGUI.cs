using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PersistantGUI : MonoBehaviour {
	//TODO Create the Rank Displays
	public static PersistantGUI GUI;

	public Text dateDisp, timeDisp, moneyDisp, debtDisp, playerFuelDisp, 
		playerHealthDisp, playerRepDisp, DrugsOwnedDisp, playerBankDisp;

	
	// Update is called once per frame
	void Update () 
	{
		UpdateUI ();
	}

	// update the players UI each frame
	
	public void UpdateUI ()
	{
		playerFuelDisp.text = "Fuel: " + PlayerCharacter.playChar.currentFuel + "/" + PlayerCharacter.playChar.maxFuel;
		playerHealthDisp.text = "Health: " + PlayerCharacter.playChar.health;
		playerBankDisp.text = "Bank: $" + PlayerCharacter.playChar.bankBalance.ToKMB ();
		playerRepDisp.text = "Rep: " + PlayerCharacter.playChar.rep;
		dateDisp.text = "Days: " + PlayerCharacter.playChar.days + "/" + PlayerCharacter.playChar.maxGameDays;
		timeDisp.text = "Time: " + PlayerCharacter.playChar.hours;
		moneyDisp.text = "Cash: $" + PlayerCharacter.playChar.cash.ToKMB();
		debtDisp.text = "Debt: $" + PlayerCharacter.playChar.debtLeft.ToKMB();
		DrugsOwnedDisp.text = "Cargo Hold: \n" + PlayerCharacter.playChar.drugsOwned + "/" + PlayerCharacter.playChar.drugMax;
	}
}
