using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Production : MonoBehaviour {

	public static Production production;

	public Text potFarmDisp, shroomFarmProduceDisp;

	public double potFarmCost, shroomFarmCost;

	void Update()
	{
		potFarmDisp.text ="Pot Farm\t" + "Cost: $" + potFarmCost.ToString () + "    Owned: " + PlayerCharacter.playChar.potFarmOwned.ToString () + "    P/P/W: " + (10 * PlayerCharacter.playChar.potFarmOwned * 7).ToString ();
		shroomFarmProduceDisp.text = "Shroom Farm\t\t" + "Cost: $" + shroomFarmCost.ToString () + "    Owned: " + PlayerCharacter.playChar.shroomFarmOwned.ToString () + "    P/P/W: " + (10 * PlayerCharacter.playChar.shroomFarmOwned * 7).ToString ();
	}

	public void BuyPotFarm()
	{
		if (PlayerCharacter.playChar.cash >= potFarmCost)
		{
			PlayerCharacter.playChar.cash -= potFarmCost;
			PlayerCharacter.playChar.potFarmOwned++;
		}
	}
	public void BuyShroomFarm()
	{
		if (PlayerCharacter.playChar.cash >= shroomFarmCost)
		{
			PlayerCharacter.playChar.cash -= shroomFarmCost;
			PlayerCharacter.playChar.shroomFarmOwned++;
		}
	}

}
