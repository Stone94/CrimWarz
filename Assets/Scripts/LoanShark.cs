using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoanShark : MonoBehaviour{

	public static LoanShark loanShark;

	public double payDebtAmount;

	// Pay the debt in full if player has enough cash.
	public void payDebtFull(){
		if (PlayerCharacter.playChar.cash >= PlayerCharacter.playChar.debtLeft) {
			PlayerCharacter.playChar.cash -= PlayerCharacter.playChar.debtLeft;
			PlayerCharacter.playChar.debtLeft = 0;
		} 
	}

	// Pay the amount specified.
	public void payDebt(){
		if (PlayerCharacter.playChar.cash >= payDebtAmount) {
			PlayerCharacter.playChar.cash -= payDebtAmount;
			PlayerCharacter.playChar.debtLeft -= payDebtAmount;
		} 
	}

	// give the player cash in exchange for more debt with an interest rate 

	public void getLoan(){
		if (PlayerCharacter.playChar.cash >= payDebtAmount) {
			PlayerCharacter.playChar.cash += payDebtAmount;
			PlayerCharacter.playChar.debtLeft += payDebtAmount * PlayerCharacter.playChar.debtInterestRate;
		} 
	}

}
