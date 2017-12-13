using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PersistantGUI : MonoBehaviour {

	public static PersistantGUI GUI;

	public Text dateDisp, timeDisp, moneyDisp, debtDisp, cryptoDisp, 
		playerHealthDisp, playerRepDisp;

	
	// Update is called once per frame
	void Update () {
		UpdateUI ();
	}

	public void UpdateUI ()
	{
		playerHealthDisp.text = "Health: " + PlayerCharacter.playChar.health;
		playerRepDisp.text = "Rep: " + PlayerCharacter.playChar.rep;
		dateDisp.text = "Days: " + PlayerCharacter.playChar.days;
		timeDisp.text = "Time: " + PlayerCharacter.playChar.hours;
		moneyDisp.text = "Cash: $" + Mathf.Round (PlayerCharacter.playChar.cash);
		debtDisp.text = "Debt: $" + Mathf.Round (PlayerCharacter.playChar.debtLeft);
		cryptoDisp.text = "Crypto: $" + Mathf.Round (PlayerCharacter.playChar.cryptoC);
	}
}
