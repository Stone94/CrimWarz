using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepositButton : MonoBehaviour 
{

	public double transferAmount;
	public double bankDepositFee;

	public void depositCash()
	{
		// if the amount of cash the player is holding is greater then or equal to the amount he wants to transfer, deposit cash to bank.
		if ( transferAmount <= PlayerCharacter.playChar.cash) {
			PlayerCharacter.playChar.cash -= transferAmount;
			PlayerCharacter.playChar.bankBalance += transferAmount * bankDepositFee;
		}
	}

	public void withdrawCash()
	{
		// do the opposite of the deposit function without a fee
		if ( PlayerCharacter.playChar.bankBalance >= transferAmount) {
			PlayerCharacter.playChar.cash += transferAmount;
			PlayerCharacter.playChar.bankBalance -= transferAmount;
		}
	}
}
