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
		bankAccountD.text = "Account Balance: $" + Mathf.RoundToInt((float)PlayerCharacter.playChar.bankBalance);
			bankCashDispD.text = "Cash: $" + Mathf.RoundToInt((float)PlayerCharacter.playChar.cash);

		// Withdrawal
		bankAccountW.text = "Account Balance: $" + Mathf.RoundToInt((float)PlayerCharacter.playChar.bankBalance);
			bankCashDispW.text = "Cash: $" + Mathf.RoundToInt((float)PlayerCharacter.playChar.cash);
	}
}
