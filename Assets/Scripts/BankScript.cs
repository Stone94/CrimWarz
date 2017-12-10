using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BankScript : MonoBehaviour {
	public Text bankAccountD, bankCashDispD, bankAccountW, bankCashDispW;

	public PlayerCharacter PC;


	void BankInterest()
	{
		PC.bankBalance *= 1.02f + PC.rep;
	}



	void Update()
	{
		BankUIDisplay ();
	}

	void BankUIDisplay ()
	{
		bankAccountD.text = "Account Balance: $" + PC.bankBalance.ToString ();
		bankCashDispD.text = "Cash: $" + PC.cash.ToString ();
		bankAccountW.text = "Account Balance: $" + PC.bankBalance.ToString ();
		bankCashDispW.text = "Cash: $" + PC.cash.ToString ();
		PC = GameObject.FindObjectOfType<PlayerCharacter> ();
	}
}
