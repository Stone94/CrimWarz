using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoanShark : MonoBehaviour{

	public BuyMenuDisp GM;

	public float debtAmount;

	public void payDebtFull(){
		if (PlayerCharacter.playChar.cash >= PlayerCharacter.playChar.debtLeft) {
			PlayerCharacter.playChar.cash -= PlayerCharacter.playChar.debtLeft;
			PlayerCharacter.playChar.debtLeft = 0f;
		} 
	}

	public void payDebt(){
		if (PlayerCharacter.playChar.cash >= debtAmount) {
			PlayerCharacter.playChar.cash -= debtAmount;
			PlayerCharacter.playChar.debtLeft -= debtAmount;
		} 
	}

	// give the player cash in exchange for more debt with an interest rate 

	public void getLoan(){
		if (PlayerCharacter.playChar.cash >= debtAmount) {
			PlayerCharacter.playChar.cash += debtAmount;
			PlayerCharacter.playChar.debtLeft += debtAmount * 1.25f;
		} 
	}

}
