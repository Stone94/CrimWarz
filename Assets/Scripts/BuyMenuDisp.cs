using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BuyMenuDisp : MonoBehaviour 
{
	
	public static BuyMenuDisp BMD;
	public GameObject pocketBuyDisp;
	public Text ludeDisp, weedDisp, shroomDisp, LSDDisp, speedDisp, methDisp, cokeDisp, heroinDisp;

	public float ludesCost, weedCost, shroomCost, LSDCost, speedCost, methCost, cokeCost, heroinCost;


	void Update () 
	{
		setUITextValues ();
	}

	// set the values of the text objects 
	
	public void setUITextValues()
	{
		ludeDisp.text = "$" + Mathf.Round(ludesCost) + "\nIn Cargo Hold: " + PlayerCharacter.playChar.ludesOwned;
		weedDisp.text = "$" + Mathf.Round(weedCost)+ "\nIn Cargo Hold: " + PlayerCharacter.playChar.weedOwned;
		shroomDisp.text = "$" + Mathf.Round(shroomCost)+ "\nIn Cargo Hold: " + PlayerCharacter.playChar.shroomOwned;
		LSDDisp.text = "$" + Mathf.Round(LSDCost)+ "\nIn Cargo Hold: " + PlayerCharacter.playChar.LSDOwned;
		speedDisp.text = "$" + Mathf.Round(speedCost)+ "\nIn Cargo Hold: " + PlayerCharacter.playChar.speedOwned;
		methDisp.text = "$" + Mathf.Round(methCost)+ "\nIn Cargo Hold: " + PlayerCharacter.playChar.methOwned;
		cokeDisp.text = "$" + Mathf.Round(cokeCost)+ "\nIn Cargo Hold: " + PlayerCharacter.playChar.cokeOwned;
		heroinDisp.text = "$" + Mathf.Round(heroinCost)+ "\nIn Cargo Hold: " + PlayerCharacter.playChar.heroinOwned;
	}
}
