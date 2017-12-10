using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepositButton : MonoBehaviour 
{
	public PlayerCharacter PC;
	public float transferAmount;

	void Update(){
		PC = GameObject.FindObjectOfType<PlayerCharacter>();

	}

	public void depositCash()
	{
		if ( transferAmount <= PC.cash) {
			PC.cash -= transferAmount;
			PC.bankBalance += transferAmount;
		}
	}

	public void withdrawCash()
	{
		if ( PC.bankBalance >= transferAmount) {
			PC.cash += transferAmount;
			PC.bankBalance -= transferAmount;
		}
	}
}
