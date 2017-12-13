using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepositButton : MonoBehaviour 
{
	public float transferAmount;

	public void depositCash()
	{
		if ( transferAmount <= PlayerCharacter.playChar.cash) {
			PlayerCharacter.playChar.cash -= transferAmount;
			PlayerCharacter.playChar.bankBalance += transferAmount * 0.30f;
		}
	}

	public void withdrawCash()
	{
		if ( PlayerCharacter.playChar.bankBalance >= transferAmount) {
			PlayerCharacter.playChar.cash += transferAmount;
			PlayerCharacter.playChar.bankBalance -= transferAmount;
		}
	}
}
