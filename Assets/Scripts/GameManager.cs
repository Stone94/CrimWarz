using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour 
{

	public Text ludeCostBuyDisp, ludeOwnedBuyDisp, weedCostBuyDisp, weedOwnedBuyDisp, shroomCostBuyDisp, shroomOwnedBuyDisp, 
	LSDCostBuyDisp, LSDOwnedBuyDisp, speedCostBuyDisp, speedOwnedBuyDisp, methCostBuyDisp, methOwnedBuyDisp, cokeCostBuyDisp,
	cokeOwnedBuyDisp, heroinCostBuyDisp,heroinOwnedBuyDisp;

	public PlayerCharacter PC;
	public Drugs Dg;


	public float ludesCost, weedCost, shroomCost, LSDCost, speedCost, methCost, cokeCost, heroinCost;

	void Awake()
	{
		PC = GameObject.FindObjectOfType<PlayerCharacter>();
	}

	void Update () 
	{
		setUITextValues ();
	}

	// set the values of the text objects
	public void setUITextValues()
	{
		ludeCostBuyDisp.text = "$" + Mathf.Round(ludesCost);
		ludeOwnedBuyDisp.text = PC.ludesOwned.ToString ();

		weedCostBuyDisp.text = "$" + Mathf.Round(weedCost);
		weedOwnedBuyDisp.text = PC.weedOwned.ToString ();

		shroomCostBuyDisp.text = "$" + Mathf.Round(shroomCost);
		shroomOwnedBuyDisp.text = PC.shroomOwned.ToString ();
	
		LSDCostBuyDisp.text = "$" + Mathf.Round(LSDCost);
		LSDOwnedBuyDisp.text = PC.LSDOwned.ToString ();
	
		speedCostBuyDisp.text = "$" + Mathf.Round(speedCost);
		speedOwnedBuyDisp.text = PC.speedOwned.ToString ();
	
		methCostBuyDisp.text = "$" + Mathf.Round(methCost);
		methOwnedBuyDisp.text = PC.methOwned.ToString ();
	
		cokeCostBuyDisp.text = "$" + Mathf.Round(cokeCost);
		cokeOwnedBuyDisp.text = PC.cokeOwned.ToString ();
	
		heroinCostBuyDisp.text = "$" + Mathf.Round(heroinCost);
		heroinOwnedBuyDisp.text = PC.heroinOwned.ToString ();

	}

}
