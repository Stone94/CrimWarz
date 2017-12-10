using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoanShark : MonoBehaviour{
	#region Script Accessors
	public GameManager GM;
	public PlayerCharacter PC;

	#endregion

	#region Variables
	public float debtAmount;
	#endregion

	void Start()
	{
		PC = GameObject.FindObjectOfType<PlayerCharacter>();
	}

	#region Pay Debt Functions
	public void payDebtFull(){
		if (PC.cash >= PC.debtLeft) {
			PC.cash -= PC.debtLeft;
			PC.debtLeft = 0f;
		} 
	}

	public void payDebt(){
		if (PC.cash >= debtAmount) {
			PC.cash -= debtAmount;
			PC.debtLeft -= debtAmount;
		} 
	}

	// give the player cash in exchange for more debt with an interest rate 

	public void getLoan(){
		if (PC.cash >= debtAmount) {
			PC.cash += debtAmount;
			PC.debtLeft += debtAmount * 1.25f;
		} 
	}
	#endregion	
}
