using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BankScript : MonoBehaviour 
{
	public static BankScript bank;
	public Text bankAccountD, bankCashDispD, bankAccountW, bankCashDispW;

	void Update()
	{
		BankUIDisplay ();
	}

	// These will update the values of the bank panel.
	void BankUIDisplay ()
	{
		// Deposit
		bankAccountD.text = "Account Balance: $" + PlayerCharacter.playChar.bankBalance.ToString ();
		bankCashDispD.text = "Cash: $" + PlayerCharacter.playChar.cash.ToString ();

		// Withdrawal
		bankAccountW.text = "Account Balance: $" + PlayerCharacter.playChar.bankBalance.ToString ();
		bankCashDispW.text = "Cash: $" + PlayerCharacter.playChar.cash.ToString ();
	}
}
