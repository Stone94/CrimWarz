using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PersistantGUI : MonoBehaviour {

	public PlayerCharacter PC;

	public Text dateDisp, timeDisp, moneyDisp, debtDisp, cryptoDisp, 
		playerHealthDisp, playerRepDisp;

	
	// Update is called once per frame
	void Update () {
		PC = GameObject.FindObjectOfType<PlayerCharacter>();
		UpdateUI ();



	}

	public void UpdateUI ()
	{
		playerHealthDisp.text = "Health: " + PC.health;
		playerRepDisp.text = "Rep: " + PC.rep;
		dateDisp.text = "Days: " + PC.days;
		timeDisp.text = "Time: " + PC.hours;
		moneyDisp.text = "Cash: $" + Mathf.Round (PC.cash);
		debtDisp.text = "Debt: $" + Mathf.Round (PC.debtLeft);
		cryptoDisp.text = "Crypto: $" + Mathf.Round (PC.cryptoC);
	}
}
