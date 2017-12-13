using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BankScript : MonoBehaviour {
	public static BankScript bank;
	public Text bankAccountD, bankCashDispD, bankAccountW, bankCashDispW;

	public float bankInterestRate;


	void BankInterest()
	{
		PlayerCharacter.playChar.bankBalance *= bankInterestRate + PlayerCharacter.playChar.rep;
	}



	void Update()
	{
		BankUIDisplay ();
	}

	void BankUIDisplay ()
	{
		bankAccountD.text = "Account Balance: $" + PlayerCharacter.playChar.bankBalance.ToString ();
		bankCashDispD.text = "Cash: $" + PlayerCharacter.playChar.cash.ToString ();
		bankAccountW.text = "Account Balance: $" + PlayerCharacter.playChar.bankBalance.ToString ();
		bankCashDispW.text = "Cash: $" + PlayerCharacter.playChar.cash.ToString ();
	}
}
