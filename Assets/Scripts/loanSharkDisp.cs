using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loanSharkDisp : MonoBehaviour {

	public Text loanShark;
	public PlayerCharacter PC;
	// Use this for initialization
	void Start () {
		PC = GameObject.FindObjectOfType<PlayerCharacter>();
	}
	
	// Update is called once per frame
	void Update () {
		loanIntro ();
	}


	public void loanIntro ()
	{
		if (PC.debtLeft >= 1){
			loanShark.text = "It's about time your punk ass came back! You better have my money, the clock is ticking!";
		}
		if (PC.debtLeft <= 0){
			loanShark.text = "Eh, my man! what can i do for you?";
		}
	}

}
