using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loanSharkDisp : MonoBehaviour {

	public Text loanShark;

	// Update is called once per frame
	void Update () {
		loanIntro ();
	}


	public void loanIntro ()
	{
		if (PlayerCharacter.playChar.debtLeft >= 1){
			loanShark.text = "It's about time your punk ass came back! You better have my money, the clock is ticking!";
		}
		if (PlayerCharacter.playChar.debtLeft <= 0){
			loanShark.text = "Eh, my man! what can i do for you?";
		}
	}

}
