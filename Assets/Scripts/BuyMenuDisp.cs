using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BuyMenuDisp : MonoBehaviour 
{
	//TODO UI FEATURE** Make the buy experience like using a computer
	public static BuyMenuDisp BMD;
	public Text ludeCostBuyDisp, ludeOwnedBuyDisp, weedCostBuyDisp, weedOwnedBuyDisp, shroomCostBuyDisp, shroomOwnedBuyDisp, 
	LSDCostBuyDisp, LSDOwnedBuyDisp, speedCostBuyDisp, speedOwnedBuyDisp, methCostBuyDisp, methOwnedBuyDisp, cokeCostBuyDisp,
	cokeOwnedBuyDisp, heroinCostBuyDisp,heroinOwnedBuyDisp;

	public float ludesCost, weedCost, shroomCost, LSDCost, speedCost, methCost, cokeCost, heroinCost;


	void Update () 
	{
		setUITextValues ();
	}

	// set the values of the text objects 
	//TODO Round the values to 2 decimal places
	public void setUITextValues()
	{
		ludeCostBuyDisp.text = "$" + Mathf.Round(ludesCost);
		ludeOwnedBuyDisp.text = PlayerCharacter.playChar.ludesOwned.ToString ();

		weedCostBuyDisp.text = "$" + Mathf.Round(weedCost);
		weedOwnedBuyDisp.text = PlayerCharacter.playChar.weedOwned.ToString ();

		shroomCostBuyDisp.text = "$" + Mathf.Round(shroomCost);
		shroomOwnedBuyDisp.text = PlayerCharacter.playChar.shroomOwned.ToString ();
	
		LSDCostBuyDisp.text = "$" + Mathf.Round(LSDCost);
		LSDOwnedBuyDisp.text = PlayerCharacter.playChar.LSDOwned.ToString ();
	
		speedCostBuyDisp.text = "$" + Mathf.Round(speedCost);
		speedOwnedBuyDisp.text = PlayerCharacter.playChar.speedOwned.ToString ();
	
		methCostBuyDisp.text = "$" + Mathf.Round(methCost);
		methOwnedBuyDisp.text = PlayerCharacter.playChar.methOwned.ToString ();
	
		cokeCostBuyDisp.text = "$" + Mathf.Round(cokeCost);
			cokeOwnedBuyDisp.text = PlayerCharacter.playChar.cokeOwned.ToString ();
	
		heroinCostBuyDisp.text = "$" + Mathf.Round(heroinCost);
		heroinOwnedBuyDisp.text = PlayerCharacter.playChar.heroinOwned.ToString ();

	}

}
